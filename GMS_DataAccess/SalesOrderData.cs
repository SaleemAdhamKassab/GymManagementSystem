using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
	public class SalesOrderData
	{
		public static bool getSaleOrderInfoById(int Id, ref DateTime Date, ref double Amount,
			ref int ClientId, ref int UserId, ref double AmountAfterDiscount)
		{
			bool IsFound = false;

			SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

			string query = "SELECT * FROM SalesOrders WHERE Id = @Id";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("Id", Id);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					IsFound = true;

					Id = (int)reader["Id"];
					Date = (DateTime)reader["Date"];
					Amount = reader["Amount"] != DBNull.Value ? (double)reader["Amount"] : 0;
					ClientId = (int)reader["ClientId"];
					UserId = (int)reader["UserId"];
					AmountAfterDiscount = reader["AmountAfterDiscount"] != DBNull.Value ?
						(double)reader["AmountAfterDiscount"] : 0;
				}
				else IsFound = false;

				reader.Close();
			}
			catch (Exception ex)
			{
				IsFound = false;
				ex = new Exception(ex.Message);
			}
			finally { connection.Close(); }

			return IsFound;
		}

		public static int add(double amount, int clientId, int userId, double amountAfterDiscount,
			List<(double, int, int, int?)> saleOrderProducts)
		{
			int orderSaleId = -1;
			double price = 0;
			int productId = -1, quantity = 0;
			string discount = "NULL";
			int saleOrderProductId = -1;

			orderSaleId = CRUD.add($"INSERT INTO SalesOrders (Date, ClientId, UserId) VALUES ('{DateTime.Now}', '{clientId}', '{userId}'); SELECT SCOPE_IDENTITY();");

			if (orderSaleId == -1)
				return -1;

			for (int i = 0; i < saleOrderProducts.Count; i++)
			{
				price = saleOrderProducts.ElementAt(i).Item1;
				productId = saleOrderProducts.ElementAt(i).Item2;
				quantity = saleOrderProducts.ElementAt(i).Item3;
				discount = saleOrderProducts.ElementAt(i).Item4 == 0 ? "NULL" : saleOrderProducts.ElementAt(i).Item4.ToString();

				saleOrderProductId = CRUD.add($"INSERT INTO SaleOrderProducts (Price, ProductId, SalesOrderId, Quantity, Discount) VALUES ({price}, {productId}, {orderSaleId}, {quantity},{discount} ); SELECT SCOPE_IDENTITY();");

				// Update product for quantity
				CRUD.executeNonQuery($"UPDATE Products SET Quantity = Quantity - {quantity} WHERE Id = {productId}");
			}

			string query = $"UPDATE SalesOrders SET Amount = {amount}, AmountAfterDiscount = {amountAfterDiscount} WHERE Id = {orderSaleId}";

			// Update SaleOrder for Amount, and AmountAfterDiscount
			CRUD.executeNonQuery(query);


			return orderSaleId;
		}

		public static DataTable get(string searchString)
		{
			if (string.IsNullOrEmpty(searchString))
			{
				return CRUD.getUsingDateTable(@"SELECT SalesOrders.Id, SalesOrders.Date, CONCAT(Persons.FirstName, ' ', Persons.LastName) AS Client, 
                                    Users.UserName,
                                    SalesOrders.Amount, SalesOrders.AmountAfterDiscount
                                    FROM SalesOrders
                                    INNER JOIN Clients ON SalesOrders.ClientId = Clients.Id
                                    INNER JOIN Persons ON Clients.PersonId = Persons.Id
                                    INNER JOIN Users ON SalesOrders.UserId = Users.Id
                                    ORDER BY SalesOrders.Date DESC");
			}
			else
			{
				return CRUD.getUsingDateTable(@$"SELECT SalesOrders.Id, SalesOrders.Date, CONCAT(Persons.FirstName, ' ', Persons.LastName) AS Client, Users.UserName,
                                                SalesOrders.Amount, SalesOrders.AmountAfterDiscount
                                                FROM SalesOrders
                                                INNER JOIN Clients ON SalesOrders.ClientId = Clients.Id
                                                INNER JOIN Persons ON Clients.PersonId = Persons.Id
                                                INNER JOIN Users ON SalesOrders.UserId = Users.Id
                                                WHERE lower(CONCAT(Persons.FirstName, ' ', Persons.LastName)) LIKE '%{searchString.Trim().ToLower()}%'
                                                    
                                                ORDER BY SalesOrders.Date DESC");
			}
		}

		// This is for show order details
		public static DataTable getOrderDetails(int orderId)
		=> CRUD.getUsingDateTable($"SELECT Products.Name AS ProductName, SaleOrderProducts.Quantity, SaleOrderProducts.Price, case WHEN Discount > 0 THEN CONCAT(SaleOrderProducts.Discount, '%') END AS Discount , AfterDiscount = (SaleOrderProducts.Price * (100 - SaleOrderProducts.Discount) / 100) FROM SalesOrders INNER JOIN SaleOrderProducts ON SalesOrders.Id = SaleOrderProducts.SalesOrderId INNER JOIN Products ON SaleOrderProducts.ProductID = Products.Id WHERE SalesOrders.Id = {orderId}");

		public static bool deleteOrder(int SalesOrderId)
		{
			bool isDeleted = false;

			isDeleted = CRUD.executeNonQuery($"DELETE SaleOrderProducts WHERE SalesOrderId = {SalesOrderId}");

			if (!isDeleted) return false;

			return CRUD.executeNonQuery($"DELETE SalesOrders WHERE Id = {SalesOrderId}");
		}

		public static List<string> outOfStockProductNames(List<(double, int, int, int?)> saleOrderProducts)
		{
			List<string> result = new();

			string query = string.Empty;
			string productName = string.Empty;

			foreach (var prodoctID in saleOrderProducts)
			{
				query = $"SELECT Name FROM Products WHERE Id = {prodoctID.Item2} AND Quantity = 0";

				productName = CRUD.getOneValueBasedOnCondition(query, "Name").ToString();

				if (!string.IsNullOrEmpty(productName))
					result.Add(productName);
			}

            return result;
        }

        public static decimal getTheProfitsOfSales()
        {
            decimal profits = 0.0m;

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                connection.Open();
                string query = @"WITH OrdersDetailed AS
                                (
                                    SELECT SalesOrders.ClientId, SalesOrderId, 
                                           CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                           SaleOrderProducts.ProductID, Products.Name AS ProductName, 
                                           SaleOrderProducts.Quantity, SaleOrderProducts.Price AS PriceSale, 
                                           SaleOrderProducts.Discount, Products.Price AS OriginalPriceFromSuplier,
                                           Products.PriceWithProfit
                                    FROM SaleOrderProducts
                                    INNER JOIN SalesOrders ON SaleOrderProducts.SalesOrderId = SalesOrders.Id
                                    INNER JOIN Clients ON SalesOrders.ClientId = Clients.Id
                                    INNER JOIN Persons ON Clients.PersonId = Persons.Id
                                    INNER JOIN Products ON SaleOrderProducts.ProductID = Products.Id
                                )
                                SELECT SUM((OrdersDetailed.PriceSale - COALESCE(OrdersDetailed.Discount, 0) - OrdersDetailed.OriginalPriceFromSuplier) * OrdersDetailed.Quantity) AS TotalProfit
                                FROM OrdersDetailed;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && decimal.TryParse(result.ToString(), out decimal profitInserted))
                    {
                        profits = profitInserted;
                    }
                }

                return profits;
            }
        }
    }
			return result;
		}
	}
}
