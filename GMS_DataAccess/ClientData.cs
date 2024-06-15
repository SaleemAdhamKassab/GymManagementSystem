using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class ClientData
    {
        public static bool GetClientDataById(int Id, ref int PersonId)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Clients WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    PersonId = (int)reader["PersonId"];
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
            finally { connection.Close(); }

            return IsFound;
        }

        public static bool getClientInfoByFullName(string FirstName, string LastName, ref int id, ref int personId)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = @"SELECT Clients.Id, Clients.PersonId FROM 
                             Clients INNER JOIN Persons ON Clients.PersonId = Persons.Id
                             WHERE FirstName = @FirstName AND LastName = @LastName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    id = (int)reader["Id"];
                    personId = (int)reader["PersonId"];
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
            finally { connection.Close(); }

            return IsFound;
        }

        public static DataTable getClientsList() => 
        CRUD.getUsingDateTable(@"SELECT FullName = CONCAT(Persons.FirstName, ' ', Persons.LastName),
                                 Persons.Phone, Persons.Address FROM Clients INNER JOIN Persons 
                                 ON Clients.PersonId = Persons.Id;");
    }
}
