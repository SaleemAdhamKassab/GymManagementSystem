using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
	public class OrderData
	{
		public static DataTable getOrders(string searchString)
		{
			if (!string.IsNullOrEmpty(searchString))
				searchString = searchString.Trim().ToLower();

			//search for date
			if (!string.IsNullOrEmpty(searchString) && searchString.Contains("-"))
				return CRUD.getUsingDateTable($"select o.Id 'OrderId', o.Date, u.UserName, CONCAT(per.FirstName ,' ', per.LastName) 'Supplier' , o.TotalAmount, o.Discount from Orders o join OrderProducts p on p.OrderId = o.Id join Users u on o.UserId = u.Id join Suppliers s on o.SupplierId = s.Id join Persons per on s.PersonId = per.Id  where o.Date ='{searchString}'");
			else
				return CRUD.getUsingDateTable($"select o.Id 'OrderId', o.Date, u.UserName, CONCAT(per.FirstName ,' ', per.LastName) 'Supplier' , o.TotalAmount, o.Discount from Orders o join OrderProducts p on p.OrderId = o.Id join Users u on o.UserId = u.Id join Suppliers s on o.SupplierId = s.Id join Persons per on s.PersonId = per.Id  where lower(u.UserName) like '%{searchString}%' or lower(per.FirstName) like '%{searchString}%' or lower(per.LastName) like '%{searchString}%' order by date desc");
		}
		public static DataTable getOrderDetails(int orderId) => CRUD.getUsingDateTable($"select c.Name 'Category Name', p.Name 'Product Name', op.Price, op.Quantity from OrderProducts op join Products p on op.ProductId = p.Id join Categories c on c.Id = p.CategoryId join orders o on op.OrderId = o.Id where o.Id = {orderId}");
		public static bool getOrderDataById(int Id, ref DateTime date, ref int userId, ref int supplierId, ref double? totalAmount, ref double? discount)
		{
			bool isFound = true;

			SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

			string query = "SELECT * FROM Orders WHERE Id = @Id";

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Id", Id);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					isFound = true;

					date = (DateTime)reader["Date"];
					userId = (int)reader["userId"];
					supplierId = (int)reader["SupplierID"];
					if (reader["TotalAmount"] != DBNull.Value)
						totalAmount = (double)reader["TotalAmount"];
					else
						totalAmount = null;
					if (reader["Discount"] != DBNull.Value)
						discount = (double)reader["Discount"];
					else
						discount = null;
				}
				else { isFound = false; }

				reader.Close();
			}
			catch (Exception ex)
			{
				isFound = false;
				ex = new Exception(ex.Message);
			}
			finally
			{
				connection.Close();
			}

			return isFound;
		}
		public static int add(DateTime date, int supplierId, int userId, double? discount, List<(int, decimal, int)> orderProducts)
		{
			//1) insert into Orders
			int orderId = CRUD.add($"INSERT INTO Orders (Date, SupplierId, UserId) VALUES ('{date}', '{supplierId}', '{userId}');SELECT SCOPE_IDENTITY();");

			string query = string.Empty;
			int productId = 0, productQuantity = 0;
			decimal productPrice = 0, orderTotalAmount = 0;

			//productQuantities -> productId - Quantity
			List<(int, int)> productQuantities = [];


			for (int i = 0; i < orderProducts.Count; i++)
			{
				productId = orderProducts.ElementAt(i).Item1;
				productPrice = orderProducts.ElementAt(i).Item2;
				productQuantity = orderProducts.ElementAt(i).Item3;

				productQuantities.Add(new(productId, productQuantity));

				//2) insert into OrderProducts
				query = $"INSERT INTO OrderProducts (ProductId,Price,Quantity, OrderId) VALUES ({productId}, {productPrice}, {productQuantity}, {orderId});SELECT SCOPE_IDENTITY();";
				orderTotalAmount += productPrice * productQuantity;
				CRUD.add(query);
			}

			//3) Update Orders
			query = $"UPDATE Orders SET TotalAmount = {orderTotalAmount}, Discount = '{discount}' where id = {orderId}";
			CRUD.executeNonQuery(query);

			//4) Update Product Quantity
			for (int i = 0; i < productQuantities.Count; i++)
			{
				query = $"UPDATE Products SET Quantity = Quantity + {productQuantities[i].Item2} where id = {productQuantities[i].Item1}";
				CRUD.executeNonQuery(query);
			}

			return orderId;
		}
		public static void delete(int orderId)
		{
			string query = string.Empty;

			query = $"delete from OrderProducts where orderId = {orderId}";
			CRUD.executeNonQuery(query);
			query = $"delete from Orders where id = {orderId}";
			CRUD.executeNonQuery(query);
		}
	}
}
