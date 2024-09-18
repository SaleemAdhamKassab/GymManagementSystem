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

                    string query = "SELECT * FROM Memberships WHERE Id = @Id";

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
                                   SET IsActive = 1
                                   WHERE Id = {Id}");

        public static bool deactivate(int Id)
        => CRUD.executeNonQuery($@"UPDATE Memberships
                                   SET IsAcive = 0
                                   WHERE Id = {Id}");

        public static bool delete(int Id)
        => CRUD.executeNonQuery(@$"DELETE Memberships WHERE Id = {Id}");

        public static DataTable get()
        => CRUD.getUsingDateTable(@"SELECT Memberships.Id, CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                    Memberships.DateOfBelong, Gendor = 
                                    CASE 
                                    WHEN Persons.Gendor = 0 THEN 'Male'
                                    WHEN Persons.Gendor = 1 THEN 'Female'
                                    END, Persons.Phone, 
                                    CAST(CASE WHEN EXISTS (SELECT 1 FROM ClassSubscriptions 
                                         WHERE ClassSubscriptions.MembershipId = Memberships.Id 
                                         AND ClassSubscriptions.ExpireDate >= GETDATE())
                                        THEN 1 
                                        ELSE 0
                                    END AS BIT) AS IsActive FROM Memberships
                                    INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                    INNER JOIN Persons ON Clients.PersonId = Persons.Id
                                    ORDER BY Memberships.DateOfBelong DESC");

        public static DataTable getDetailsOfClassSubscriptionsByMembershipId(int membershipId)
        => CRUD.getUsingDateTable(@$"SELECT ClassSubscriptions.Id,
                                     ClassTypes.Name AS ClassName, CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS Coach,
                                     ClassSubscriptions.StartDate, ClassSubscriptions.ExpireDate,
                                     CASE 
                                     WHEN ClassSubscriptions.SubscripeStatus = 1 THEN 'New'
                                     WHEN ClassSubscriptions.SubscripeStatus = 2 THEN 'Renew'
                                     WHEN ClassSubscriptions.SubscripeStatus = 3 THEN 'Freeze'
                                     WHEN ClassSubscriptions.SubscripeStatus = 4 THEN 'Expired'
                                     WHEN ClassSubscriptions.SubscripeStatus = 5 THEN 'Expire soon'
                                     ELSE 'Un known'
                                     END AS SubscripStatus
                                     FROM ClassSubscriptions
                                     INNER JOIN Memberships ON ClassSubscriptions.MembershipId = Memberships.Id
                                     INNER JOIN Coaches ON ClassSubscriptions.CoachId = Coaches.Id
                                     INNER JOIN ClassTypes ON Coaches.ClassTypeId = ClassTypes.Id
                                     INNER JOIN Persons ON Coaches.PersonId = Persons.Id
                                     WHERE MembershipId = {membershipId}");

        public static Dictionary<string, int> numberOfMembershipsToCategories()
        {
            Dictionary<string, int> categorisWithMemberships = new Dictionary<string, int>();

            using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
            {
                connection.Open();

                string query = @"WITH MembershipsToCategories AS
                        (
                        SELECT ClassCategories.Name AS CategoryName, ClassSubscriptions.MembershipId FROM ClassSubscriptions
                        INNER JOIN Coaches ON ClassSubscriptions.CoachId = Coaches.Id
                        INNER JOIN ClassTypes ON Coaches.ClassTypeId = ClassTypes.Id
                        INNER JOIN ClassCategories ON ClassTypes.CategoryId = ClassCategories.Id
                        )
                        SELECT CategoryName, COUNT(MembershipsToCategories.MembershipId) AS Memberships -- fixed typo here
                        FROM MembershipsToCategories
                        GROUP BY MembershipsToCategories.CategoryName
                        ORDER BY CategoryName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string categoryName = reader["CategoryName"].ToString();
                            int membershipCount = Convert.ToInt32(reader["Memberships"]);
                            categorisWithMemberships.Add(categoryName, membershipCount);
                        }
                    }
                }
            }

            return categorisWithMemberships;
        }

    }
}
