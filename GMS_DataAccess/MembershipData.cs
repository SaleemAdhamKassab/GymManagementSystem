using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class MembershipData
    {
        public static bool getMembershipInfoById(int Id, ref DateTime dateOfBelong, ref bool isActive, ref int clientId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Memeberships WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                dateOfBelong = (DateTime)reader["DateOfBelong"];
                                isActive = Convert.ToBoolean(reader["IsActive"]);
                                clientId = (int)reader["ClientId"];
                            }
                            else isFound = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isActive = false;
                ex = new Exception(ex.Message);
            }

            return isFound;
        }

        public static bool getMembershipInfoByClientId(int ClientId, ref int Id, ref DateTime dateOfBelong,
            ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Memberships WHERE ClientId = @ClientId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientId", ClientId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                Id = (int)reader["Id"];
                                dateOfBelong = (DateTime)reader["DateOfBelong"];
                                isActive = Convert.ToBoolean(reader["IsActive"]);
                            }
                            else isFound = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isActive = false;
                ex = new Exception(ex.Message);
            }

            return isFound;
        }

        public static int add(DateTime dateOfBelong, int clientId)
        => CRUD.add(@$"INSERT INTO Memberships (DateOfBelong, IsActive, ClientId)
                       VALUES ('{dateOfBelong}', {1}, {clientId});
                       SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, DateTime dateOfBelong, bool isActive)
        => CRUD.executeNonQuery(@$"UPDATE Memberships
                                   SET DateOfBelong = '{dateOfBelong}',
                                       IsActive = {isActive}
                                   WHERE Id = {Id}");

        public static bool activate(int Id)
        => CRUD.executeNonQuery($@"UPDATE Memberships
                                   SET IsAcive = 1
                                   WHERE Id = {Id}");

        public static bool deactivate(int Id)
        => CRUD.executeNonQuery($@"UPDATE Memberships
                                   SET IsAcive = 0
                                   WHERE Id = {Id}");

        public static bool delete(int Id)
        => CRUD.executeNonQuery(@$"DELETE Memberships WHERE Id = {Id}");

        public static DataTable get()
        => CRUD.getUsingDateTable(@"SELECT Memberships.Id, 
                                    CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                    Memberships.DateOfBelong, Gendor = CASE 
									WHEN Persons.Gendor = 0 THEN 'Male'
									WHEN Persons.Gendor = 1 THEN 'Female'
									END, Persons.Phone, Memberships.IsActive FROM Memberships
                                    INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                    INNER JOIN Persons ON Clients.PersonId = Persons.Id
                                    ORDER BY Memberships.DateOfBelong DESC");
    }
}
