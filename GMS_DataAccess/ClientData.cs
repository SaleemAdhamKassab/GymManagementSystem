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

        public static bool getClientInfoByFullName(string fullName,
            ref string phone, ref string address, ref string? email, ref string? imagePath, ref int roleId, ref int personId, ref int clientId)
        {
            bool IsFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT FullName, Gendor, DateOfBirth, Phone, Address, Email, ImagePath, RoleId, PersonId, ClientId
                                     FROM (
                                     SELECT FullName = CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName),
                                                                     Persons.Gendor, Persons.DateOfBirth, Persons.Phone, Persons.Address, Persons.Email, Persons.ImagePath, Persons.RoleId, Persons.Id AS PersonId, 
                                     								 Clients.Id AS ClientId
                                     								 FROM Clients INNER JOIN Persons 
                                                                      ON Clients.PersonId = Persons.Id
                                     ) AS ClientInfo
                                     WHERE FullName = @fullName";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                phone = (string)reader["Phone"];
                                address = (string)reader["Address"];
                                email = reader["Email"] != DBNull.Value ? (string)reader["Email"] : string.Empty;
                                imagePath = reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : string.Empty;
                                roleId = (int)reader["RoleId"];
                                personId = (int)reader["PersonId"];
                                clientId = (int)reader["ClientId"];
                            }
                            else IsFound = false;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                IsFound = false;
                ex = new Exception(ex.Message);
            }

            return IsFound;
        }

        public static DataTable getClientsList() => 
        CRUD.getUsingDateTable(@"SELECT Clients.Id ,FullName = CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName),
                                 CASE WHEN Persons.Gendor = 0 THEN 'Male' WHEN Persons.Gendor = 1 THEN 'Female' END AS Gendor,
								 FORMAT(Persons.DateOfBirth, 'dd-MM-yyyy') AS DateOfBirth, Persons.Phone, Persons.Address, Persons.Email FROM Clients INNER JOIN Persons 
                                 ON Clients.PersonId = Persons.Id");

        public static int add(string firstName, string secondName, string thirdName, string lastName, byte gendor, DateTime dateOfBirth,
            string address, string phone, string? email, string? imagePath, int roleId, int personId)
        {
            int clientId = -1;
            personId = -1;

            personId = PersonData.add(firstName, secondName, thirdName, lastName, gendor, dateOfBirth, address, phone, email,
                imagePath, roleId);

            if (personId == -1)
                return clientId;

            string query = $"INSERT INTO Clients (PersonId) VALUES ({personId}); SELECT SCOPE_IDENTITY();";

            clientId = CRUD.add(query);

            return clientId;
        }

        public static bool update(int clientId, string firstName, string secondName, string thirdName, string lastName,
            byte gendor, DateTime dateOfBirth, string address, string phone, string? email, string? imagePath, int roleId, int personId) =>
            PersonData.update(personId, firstName, secondName, thirdName, lastName, gendor, dateOfBirth,
            address, phone, email, imagePath, roleId);

        public static bool delete(int clientId, int personId)
        => CRUD.executeNonQuery($"DELETE Clients WHERE Id = {clientId}") ? PersonData.deletePerson(personId) : false;


    }
}
