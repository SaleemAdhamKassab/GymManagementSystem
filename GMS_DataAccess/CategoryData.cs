using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
	public class CategoryData
	{
		
		public static int add(string name) => CRUD.add($"insert into Categories (name) values ('{name}'); SELECT SCOPE_IdENTITY();");
		public static DataTable get() => CRUD.getUsingDateTable("select * from categories order by name");

		public static bool update(int Id, string name) => CRUD.executeNonQuery($"UPDATE Categories SET Name = ('{name}') WHERE ID = ('{Id}')");

        public static bool delete(int Id) => CRUD.executeNonQuery($"DELETE Categories WHERE ID = ('{Id}')");

        public static bool isCategoryExist(int Id) => CRUD.isExists($"SELECT isFOUND = 1 FROM Categories WHERE ID = ('{Id}')");

        public static bool findByID(int ID, ref string Name)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = $"SELECT * FROM Categories WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Name = (string)reader["Name"];
                }
                else
                    isFound = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                throw new Exception("Error: " + ex.Message); ;
            }
            finally
            { connection.Close(); }

            return isFound;
        }

        public static bool findByName(ref int ID, string Name)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = $"SELECT * FROM Categories WHERE Name = @Name";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Name", Name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = (int)reader["ID"];
                }
                else
                    isFound = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                throw new Exception("Error: " + ex.Message); ;
            }
            finally
            { connection.Close(); }

            return isFound;
        }
    }
}
