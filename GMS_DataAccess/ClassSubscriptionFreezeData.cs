using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class ClassSubscriptionFreezeData
    {
        public static bool getClassSubscriptionFreezeInfoById(int Id, ref DateTime FreezeStartDate,
            ref DateTime FreezeEndDate, ref int ClassSubscriptionId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM ClassSubscriptionFreezes WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                FreezeStartDate = (DateTime)reader["FreezeStartDate"];
                                FreezeEndDate = (DateTime)reader["FreezeEndDate"];
                                ClassSubscriptionId = (int)reader["ClassSubscriptionId"];
                            }
                            else isFound = false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                isFound = false;
                throw new Exception("An error occurred when user find class subscription freeze", ex);
            }

            return isFound;
        }

        public static bool getClassSubscriptionFreezeInfoBySubscriptionId(int ClassSubscriptionId, ref int Id,
            ref DateTime FreezeStartDate, ref DateTime FreezeEndDate)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM ClassSubscriptionFreezes WHERE ClassSubscriptionId = @ClassSubscriptionId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClassSubscriptionId", ClassSubscriptionId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Id = (int)reader["Id"];
                                FreezeStartDate = (DateTime)reader["FreezeStartDate"];
                                FreezeEndDate = (DateTime)reader["FreezeEndDate"];
                            }
                            else isFound = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                throw new Exception("An error occurred when user find class subscription freeze", ex);
            }

            return isFound;
        }

        public static int add(DateTime FreezeStartDate, DateTime FreezeEndDate, int ClassSubscriptionId)
        => CRUD.add(@$"INSERT INTO ClassSubscriptionFreezes (FreezeStartDate, FreezeEndDate ,ClassSubscriptionId)
                       VALUES (@FreezeStartDate, @FreezeEndDate, @ClassSubscriptionId);
                       SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, DateTime FreezeStartDate, DateTime FreezeEndDate, int ClassSubscriptionId)
        => CRUD.executeNonQuery(@$"UPDATE ClassSubscriptionFreezes
                                   SET FreezeStartDate = {FreezeStartDate},
                                       FreezeEndDate = {FreezeEndDate},
                                       ClassSubscriptionId = {ClassSubscriptionId}
                                   WHERE Id = {Id}");

        public static bool delete(int Id) => CRUD.executeNonQuery($"DELETE ClassSubscriptionFreezes WHERE Id = {Id}");

        public static DataTable get()
        => CRUD.getUsingDateTable(@"SELECT ClassSubscriptionFreezes.Id, CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                    ClassSubscriptionFreezes.FreezeStartDate, ClassSubscriptionFreezes.FreezeEndDate, ClassTypes.Name
                                    FROM ClassSubscriptionFreezes 
                                    INNER JOIN ClassSubscriptions ON ClassSubscriptionFreezes.ClassSubscriptionId = ClassSubscriptions.Id
                                    INNER JOIN ClassTypes ON ClassSubscriptions.ClassTypeId = ClassTypes.Id
                                    INNER JOIN Memberships ON ClassSubscriptions.MembershipId = Memberships.Id
                                    INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                    INNER JOIN Persons ON Clients.PersonId = Persons.Id;");
    }
}
