using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class UserData
    {
        public static bool GetUserInfoById(int Id, ref string UserName, ref string Password, ref int PersonId)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    PersonId = (int)reader["PersonId"];
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
    }
}
