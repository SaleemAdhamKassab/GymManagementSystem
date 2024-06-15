using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class SalesOrderProductData
    {
        public static bool getSalesOrderProductInfoById(int Id, ref double Price, ref int ProductId,
        ref int SalesOrderId, ref int Quantity, ref int? Discount)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM SaleOrderProducts WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    Price = (double)reader["Price"];
                    ProductId = (int)reader["ProductId"];
                    SalesOrderId = (int)reader["SalesOrderId"];
                    Quantity = (int)reader["Quantity"];
                    Discount = reader["Discount"] != DBNull.Value ? (int)reader["Discount"] : 0;
                }

                else
                    IsFound = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                IsFound = false;
                ex = new Exception(ex.Message);
            }
            finally
            { connection.Close(); }

            return IsFound;
        }

        public static DataTable get() => CRUD.getUsingDateTable("SELECT * FROM SaleOrderProducts");

        public static int add(double originalPrice, double amount, int clientId, int userId,
            double amountAfterDiscount, List<(double, int, int, int)>saleOrderProducts)
        {
            int orderId = -1, productId = -1, quantity = 0, discount = 0;
            double priceAfterDiscount = 0;

            orderId = CRUD.add($"INSERT INTO SalesOrders (Date, ClientId, UserId) VALUES ('{DateTime.Now}', '{clientId}', '{userId}'); SELECT SCOPE_IDENTITY(); ");

            for (int i = 0; i < saleOrderProducts.Count; i++)
            {
                priceAfterDiscount = saleOrderProducts.ElementAt(i).Item1;
                productId = saleOrderProducts.ElementAt(i).Item2;
                quantity = saleOrderProducts.ElementAt(i).Item3;
                discount = saleOrderProducts.ElementAt(i).Item4;


            }

            return -1;
        }
    }
}
