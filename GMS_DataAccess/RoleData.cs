using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class RoleData
    {
        public static int add(string name) => CRUD.add($"INSERT INTO Roles (Name) VALUES ('{name.Trim()}'); SELECT SCOPE_IDENTITY();");
        public static DataTable get() => CRUD.getUsingDateTable("SELECT * FROM Roles");
        public static bool update(int Id, string name) => CRUD.executeNonQuery($"UPDATE Roles SET Name = {name.Trim()} WHERE Id = {Id}");
        public static bool delete(int Id) => CRUD.executeNonQuery($"DELETE Roles WHERE Id = {Id}");
        public static bool findById(int Id, ref string name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Roles WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    name = (string)reader["Name"];
                }
                else
                {
                    isFound = false;
                }
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

        public static bool findByName(ref int Id, string name)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Roles WHERE Name = @name";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Id = (int)reader["Id"];
                }
                else
                {
                    isFound = false;
                }
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
    }
}
