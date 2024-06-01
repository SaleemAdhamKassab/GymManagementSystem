using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class OrderProductData
    {
        public static bool GetOrderProductDataByID(int Id, ref int Quantity, ref decimal Price, ref int ProductId, ref int OrderId)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM OrderProducts WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    Quantity = (int)reader["Quantity"];
                    Price = Convert.ToDecimal(reader["Price"]);
                    ProductId = (int)reader["ProductId"];
                    OrderId = (int)reader["OrderId"];
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

        public static bool GetOrderProductDataByOrderID(int OrderId, ref int Id, ref int Quantity, ref decimal Price, ref int ProductId)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM OrderProducts WHERE OrderId = @OrderId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderId", OrderId);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    Id = (int)reader["Id"];
                    Quantity = (int)reader["Quantity"];
                    Price = Convert.ToDecimal(reader["Price"]);
                    ProductId = (int)reader["ProductId"];
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

        public static DataTable getAllOrderProductDetails(int  OrderId)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString);

            string query = @"SELECT Orders.Id, Products.Name AS ProductName, Categories.Name AS CategoryName, OrderProducts.Quantity,
                             OrderProducts.Price
                             
                             FROM OrderProducts Inner JOIN Orders ON OrderProducts.OrderId = Orders.Id
                             INNER JOIN Products ON OrderProducts.ProductId = Products.Id
                             INNER JOIN Categories ON Categories.Id = Products.CategoryId
                             WHERE OrderId = @OrderId";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@OrderId", OrderId);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                ex = new Exception(ex.Message);
            }
            finally { connection.Close(); }

            return dt;
        }
    }
}
