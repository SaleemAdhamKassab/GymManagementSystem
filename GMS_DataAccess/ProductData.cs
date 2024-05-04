using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS_DataAccess
{
	public class ProductData
	{
		public static bool getProductDataByID(int id, ref string name, ref short quantity, ref int categoryId)
		{
			bool isFound = false;

			SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

			string query = $"SELECT * FROM Products WHERE Id = @id";

			SqlCommand command = new SqlCommand(query, connection);
			command.Parameters.AddWithValue("@Id", id);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					isFound = true;
					name = (string)reader["Name"];
					quantity = (short)reader["Quantity"];
					categoryId = (int)reader["CategoryId"];
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

		public static bool getProductDataByName(ref int id, string name, ref short quantity, ref int categoryId)
		{
			bool isFound = false;

			SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

			string query = "SELECT * FROM Products WHERE Name = @name";

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
					quantity = (short)reader["Quantity"];
					categoryId = (int)reader["CategoryId"];
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

			return CRUD.getUsingDateTable($"SELECT * FROM Products where lower(name) like '%{searchString}' order by name");
		}
		public static int add(string name, int quantity, int categoryId) =>
		CRUD.add($"INSERT INTO Products (Name, Quantity, CategoryId) VALUES ('{name.Trim()}', {quantity}, {categoryId}); SELECT SCOPE_IDENTITY();");
		public static bool update(int id, string name, int quantity, int categoryId) =>
		CRUD.executeNonQuery($"UPDATE Products SET Name = '{name.Trim()}', Quantity = {quantity}, CategoryId = {categoryId} WHERE Id = {id}");
		public static bool delete(int id) => CRUD.executeNonQuery($"DELETE Products WHERE Id = {id}");
	}
}
