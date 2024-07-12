using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class ClassSubscriptionData
    {
        public static bool getClassSubscriptionInfoById(int Id, ref DateTime startDate, ref DateTime expireDate, ref byte subscripeStatus,
            ref bool isFrozen, ref int paymentId, ref int classTypeId, ref int membershipId)
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
                                classTypeId = (int)reader["ClassTypeId"];
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
            ref bool isFrozen, ref int paymentId, ref int classTypeId)
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
                                classTypeId = (int)reader["ClassTypeId"];
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

        public static int add(DateTime startDate, DateTime expireDate, int paymentId, int classTypeId, int membershipId)
        => CRUD.add(@$"INSERT INTO ClassSubscriptions (StartDate,
                ExpireDate, SubscripeStatus, IsFrozen, PaymentId, ClassTypeId, MembershipId)
        VALUES ('{startDate}', '{expireDate}', {1}, {0}, {paymentId}, {classTypeId}, 
                {membershipId}); SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, DateTime startDate, DateTime expireDate, byte subscripeStatus, bool isFrozen,
        int paymentId, int classTypeId, int membershipId)
        => CRUD.executeNonQuery(@$"UPDATE ClassSubscriptions
                                   SET StartDate = '{startDate}',
                                       ExpireDate = '{expireDate}',
                                       SubscripeStatus = '{subscripeStatus}',
                                       IsFrozen = {isFrozen},
                                       PaymentId = {paymentId},
                                       ClassTypeId = {classTypeId},
                                       MembershipId = {membershipId}
                                   WHERE Id = {Id}");

        public static bool takeFreeze(int Id)
        => CRUD.executeNonQuery(@$"UPDATE ClassSubscriptions
                                   SET SubscripeStatus = 3
                                   WHERE Id = {Id}");

        public static bool renew(int Id)
        => CRUD.executeNonQuery($@"UPDATE ClassSubscriptions
                                   SET SubscripeStatus = 2
                                   WHERE Id = {Id}");

        public static DataTable getExpiredSoonList()
        => CRUD.getUsingDateTable(@"SELECT Memberships.Id, CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                    ClassTypes.Name AS ClassName, Persons.Phone, ClassSubscriptions.StartDate, ClassSubscriptions.ExpireDate
                                    FROM ClassSubscriptions INNER JOIN Memberships ON ClassSubscriptions.MembershipId = Memberships.Id
                                    INNER JOIN ClassTypes ON ClassSubscriptions.ClassTypeId = ClassTypes.Id
                                    INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                    INNER JOIN Persons ON Clients.PersonId = Persons.Id
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

        public static bool delete(int id) => CRUD.executeNonQuery($"DELETE ClassSubscriptions WHERE Id = {id}");

        public static bool checkActivationClassesForMembership(int membershipId)
        {
            bool isActive = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @$"SELECT InActive = 1 FROM
                                      (
                                      SELECT Memberships.Id, CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                      ClassSubscriptions.StartDate, ClassSubscriptions.ExpireDate, 
                                      CASE 
                                      	WHEN ClassSubscriptions.SubscripeStatus = 1 THEN 'New'
                                      	WHEN ClassSubscriptions.SubscripeStatus = 2 THEN 'Renew'
                                      	WHEN ClassSubscriptions.SubscripeStatus = 3 THEN 'Freeze'
                                      	WHEN ClassSubscriptions.SubscripeStatus = 4 THEN 'Expired'
                                      	WHEN ClassSubscriptions.SubscripeStatus = 5 THEN 'Expired Soon'
                                      END AS SubsribtionStatus, ClassTypes.Name AS ClassName,ClassTypes.Fees
                                      FROM ClassSubscriptions
                                      INNER JOIN ClassTypes ON ClassSubscriptions.ClassTypeId = ClassTypes.Id
                                      INNER JOIN Memberships ON ClassSubscriptions.MembershipId = Memberships.Id
                                      INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                      INNER JOIN Persons ON Clients.PersonId = Persons.Id
                                      WHERE MembershipId = 1 AND ClassSubscriptions.ExpireDate >= GETDATE()) AS InActiveMembership";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipId", membershipId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                isActive = true;
                            }
                            else isActive = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isActive = false;
                ex = new Exception(ex.Message);
            }

            return isActive;
        }

        public static DataTable get() 
        => CRUD.getUsingDateTable(@"SELECT ClassSubscriptions.Id,
                                    CONCAT(ClientPerson.FirstName, ' ', ClientPerson.SecondName, ' ', ClientPerson.ThirdName, ' ', ClientPerson.LastName) AS ClientName,
                                    ClassSubscriptions.StartDate, ClassSubscriptions.ExpireDate,
                                    CASE WHEN ClassSubscriptions.SubscripeStatus = 1 THEN 'New'
                                    	 WHEN ClassSubscriptions.SubscripeStatus = 2 THEN 'Renew'
                                    	 WHEN ClassSubscriptions.SubscripeStatus = 3 THEN 'Freeze'
                                    	 WHEN ClassSubscriptions.SubscripeStatus = 4 THEN 'Expired'
                                    	 WHEN ClassSubscriptions.SubscripeStatus = 5 THEN 'Expire Soon'
                                    END AS SubscriptionStatus, ClassSubscriptions.IsFrozen, Payments.Amount, CoachName = 'Coach test'
                                    FROM ClassSubscriptions 
                                    INNER JOIN Payments ON ClassSubscriptions.PaymentId = Payments.Id
                                    INNER JOIN Memberships AS MembershipClient ON ClassSubscriptions.MembershipId = MembershipClient.Id
                                    INNER JOIN Clients ON MembershipClient.ClientId = Clients.Id
                                    INNER JOIN Persons AS ClientPerson ON Clients.PersonId = ClientPerson.Id
                                    INNER JOIN ClassTypes ON ClassSubscriptions.ClassTypeId = ClassTypes.Id");
    }
}
