using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class ClassSubscriptionData
    {
        public static bool getClassSubscriptionInfoById(int Id, ref DateTime startDate, ref DateTime expireDate,
            ref byte subscripeStatus,
            ref bool isFrozen, ref int paymentId, ref int coachId, ref int membershipId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM ClassSubscriptions WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue( "@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                startDate = (DateTime)reader["StartDate"];
                                expireDate = (DateTime)reader["ExpireDate"];
                                subscripeStatus = Convert.ToByte(reader["SubscripeStatus"]);
                                isFrozen = Convert.ToBoolean(reader["IsFrozen"]);
                                paymentId = (int)reader["PaymentId"];
                                coachId = (int)reader["CoachId"];
                                membershipId = (int)reader["MembershipId"];
                            }
                            else isFound = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                ex = new Exception(ex.Message);
            }

            return isFound;
        }

        public static bool getClassSubscriptionInfoByMemberId(int membershipId, ref int Id, ref DateTime startDate, 
            ref DateTime expireDate,
            ref byte subscripeStatus,
            ref bool isFrozen, ref int paymentId, ref int coachId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM ClassSubscriptions WHERE MembershipId = @MembershipId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipId", membershipId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Id = (int)reader["Id"];
                                startDate = (DateTime)reader["StartDate"];
                                expireDate = (DateTime)reader["ExpireDate"];
                                subscripeStatus = Convert.ToByte(reader["SubscripeStatus"]);
                                isFrozen = Convert.ToBoolean(reader["IsFrozen"]);
                                paymentId = (int)reader["PaymentId"];
                                coachId = (int)reader["coachId"];
                            }
                            else isFound = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                ex = new Exception(ex.Message);
            }

            return isFound;
        }

        public static int add(DateTime startDate, DateTime expireDate, int paymentId, int coachId, int membershipId)
        => CRUD.add(@$"INSERT INTO ClassSubscriptions (StartDate,
                ExpireDate, SubscripeStatus, IsFrozen, PaymentId, coachId, MembershipId)
        VALUES ('{startDate}', '{expireDate}', {1}, {0}, {paymentId}, {coachId}, 
                {membershipId}); SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, DateTime startDate, DateTime expireDate, byte subscripeStatus, bool isFrozen,
        int paymentId, int coachId, int membershipId)
        => CRUD.executeNonQuery(@$"UPDATE ClassSubscriptions
                                   SET StartDate = '{startDate}',
                                       ExpireDate = '{expireDate}',
                                       SubscripeStatus = '{subscripeStatus}',
                                       IsFrozen = {isFrozen},
                                       PaymentId = {paymentId},
                                       CoachId = {coachId},
                                       MembershipId = {membershipId}
                                   WHERE Id = {Id}");

        public static bool takeFreeze(int Id)
        => CRUD.executeNonQuery(@$"UPDATE ClassSubscriptions
                                   SET SubscripeStatus = 3
                                   WHERE Id = {Id}");

        public static bool renew(int Id, DateTime startDate, DateTime expireDate, int paymentId)
        => CRUD.executeNonQuery($@"UPDATE ClassSubscriptions
                                   SET SubscripeStatus = 2,
                                       StartDate = '{startDate}',
                                       ExpireDate = '{expireDate}',
                                       PaymentId = {paymentId}
                                   WHERE Id = {Id}");

        public static DataTable getExpiredSoonList()
        => CRUD.getUsingDateTable(@"SELECT Memberships.Id, CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                    ClassTypes.Name AS ClassName, Persons.Phone, ClassSubscriptions.StartDate, ClassSubscriptions.ExpireDate
                                    FROM ClassSubscriptions 
                                    INNER JOIN Memberships ON ClassSubscriptions.MembershipId = Memberships.Id
                                    INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                    INNER JOIN Persons ON Clients.PersonId = Persons.Id
                                    INNER JOIN Coaches ON ClassSubscriptions.CoachId = Coaches.Id
                                    INNER JOIN ClassTypes ON ClassTypes.Id = Coaches.ClassTypeId
                                    WHERE ClassSubscriptions.ExpireDate BETWEEN GETDATE() AND DATEADD(DAY, 7, GETDATE())
                                    ORDER BY ClassSubscriptions.ExpireDate DESC");

        public static DataTable getExpiredList()
        => CRUD.getUsingDateTable(@"SELECT Memberships.Id, CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                    ClassTypes.Name AS ClassName, ClassSubscriptions.StartDate, ClassSubscriptions.ExpireDate
                                    FROM ClassSubscriptions INNER JOIN Memberships ON ClassSubscriptions.MembershipId = Memberships.Id
                                    INNER JOIN ClassTypes ON ClassSubscriptions.ClassTypeId = ClassTypes.Id
                                    INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                    INNER JOIN Persons ON Clients.PersonId = Persons.Id
                                    WHERE ClassSubscriptions.ExpireDate >= GETDATE()
                                    ORDER BY ClassSubscriptions.ExpireDate DESC");

        //        SELECT COUNT(*) FROM ClassSubscriptions
        //WHERE MembershipId = 1
        //AND
        //ExpireDate >= GETDATE()

        public static bool isExpired(int Id)
        {
            bool isExpireSoon = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = $@"SELECT IsExpired = 1 FROM ClassSubscriptions
                                  WHERE Id = {Id} AND ClassSubscriptions.ExpireDate <= DATEADD(DAY, 1, GETDATE())";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                isExpireSoon = true;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isExpireSoon = false;
                throw new Exception(ex.Message);
            }

            return isExpireSoon;
        }

        public static bool IsMembershipSubscriped(int membershipId, int classTypeId)
        {
            bool isMembershipSubscriped = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @$"SELECT isSubscriped = 1 FROM ClassSubscriptions
                                      INNER JOIN Coaches ON ClassSubscriptions.CoachId = Coaches.Id
                                      INNER JOIN ClassTypes ON Coaches.ClassTypeId = ClassTypes.Id
                                      WHERE MembershipId = {membershipId} AND ClassTypeId = {classTypeId}";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipId", membershipId);
                        command.Parameters.AddWithValue("@ClassTypeId", classTypeId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isMembershipSubscriped = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isMembershipSubscriped = false;
                throw new Exception(ex.Message);
            }

            return isMembershipSubscriped;
        }

        public static bool delete(int id) => CRUD.executeNonQuery($"DELETE ClassSubscriptions WHERE Id = {id}");


    }
}
