using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
	public class SupplierData
	{
		public static DataTable get() => CRUD.getUsingDateTable($"SELECT *  FROM Suppliers  s join Persons p on s.personId= p.id order by p.FirstName;");

		public static bool getSupplierDataByPSupplierId(int Id, ref int personId)
		{
			bool isFound = false;

			string query = "SELECT * FROM Users WHERE Id = @Id";

			SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

			SqlCommand command = new SqlCommand(query, connection);

			command.Parameters.AddWithValue("@Id", Id);

			try
			{
				connection.Open();

				SqlDataReader reader = command.ExecuteReader();

				if (reader.Read())
				{
					isFound = true;

					personId = (int)reader["PersonId"];
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

		public static int addSupplier(int personId) => CRUD.add($"INSERT INTO Persons (PersonId) VALUES ({personId}); SELECT SCOPE_IDETITY();");

		public static bool updateSupplier(int supplierId, int personId) => CRUD.executeNonQuery($"UPDATE Suppliers SET PersonId = {personId} WHERE Id = {supplierId}");

		public static bool deleteSupplier(int Id) => CRUD.executeNonQuery($"DELETE Suppliers WHERE Id = {Id}");

		public static bool isSupplierExist(int Id) => CRUD.isExists($"SELECT Found = 1 FROM Suppliers WHERE Id = {Id}");
	}
}
