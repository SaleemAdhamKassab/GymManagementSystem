using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
	public class ProductData
	{
		public static bool getProductDataByID(int id, ref string name, ref int quantity, ref double price, ref double PriceWithProfit, ref int categoryId, ref string ImagePath)
		{
			bool isFound = false;

			SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

			string query = $"SELECT * FROM Products WHERE Id = {id}";
			SqlCommand command = new SqlCommand(query, connection);
			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					isFound = true;
					name = (string)reader["Name"];
					quantity = (int)reader["Quantity"];
					price = (double)reader["Price"];
					PriceWithProfit = (double)reader["PriceWithProfit"];
					categoryId = (int)reader["CategoryId"];
					ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : string.Empty;
				}
				else
					isFound = false;

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

		public static bool getProductDataByName(ref int id, string name, ref int quantity, ref double price, ref double PriceWithProfit, ref int categoryId, ref string ImagePath)
		{
			bool isFound = false;

			SqlConnection connection = new (DataAccessSettings.ConnectionString);

			string query = "SELECT * FROM Products WHERE lower(Name) = @name";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@Name", name);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					isFound = true;
					id = (int)reader["Id"];
					quantity = (int)reader["Quantity"];
					price = (double)reader["Price"];
					PriceWithProfit = (double)reader["PriceWithProfit"];
					categoryId = (int)reader["CategoryId"];
                    ImagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : string.Empty;
                }
				else
					isFound = false;

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

		public static DataTable get(string searchString)
		{
			if (!string.IsNullOrEmpty(searchString))
				searchString = searchString.Trim().ToLower();

			return CRUD.getUsingDateTable($"SELECT * FROM Products where lower(name) like '%{searchString}%' order by name");
		}
		public static DataTable get() => CRUD.getUsingDateTable("SELECT * FROM Products");
		public static DataTable getProductsByItem(int categoryId) => 
		CRUD.getUsingDateTable($"SELECT Products.Id, Products.Name, Products.Quantity FROM Products INNER JOIN Categories ON Products.CategoryId = Categories.Id WHERE Categories.Id = {categoryId}");
		public static int add(string name, int quantity, double price, double priceWithProfit, int categoryId, string imagePath) =>
		CRUD.add($"INSERT INTO Products (Name, Quantity, Price, PriceWithProfit, CategoryId, ImagePath) VALUES ('{name.Trim()}', {quantity}, {price}, {priceWithProfit}, {categoryId}, {imagePath}); SELECT SCOPE_IDENTITY();");
		public static bool update(int id, string name, int quantity, double price, double priceWithProfit, int categoryId, string imagePath) =>
		CRUD.executeNonQuery($"UPDATE Products SET Name = '{name.Trim()}', Quantity = {quantity}, Price = {price}, PriceWithProfit = {priceWithProfit}, CategoryId = {categoryId}, ImagePath = {imagePath} WHERE Id = {id}");
		public static bool delete(int id) => CRUD.executeNonQuery($"DELETE Products WHERE Id = {id}");
	}
}
