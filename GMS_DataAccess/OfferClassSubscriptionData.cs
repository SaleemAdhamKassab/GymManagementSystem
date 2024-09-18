using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class OfferClassSubscriptionData
    {
        public static bool getOfferClassSubscriptionInfoById(int Id, ref DateTime subscripeData, ref float paidAmount,
            ref int classSubscriptionId, ref int offerId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM OfferClassSubscriptions WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                subscripeData = (DateTime)reader["SubscripeDate"];
                                paidAmount = (float)reader["PaidAmount"];
                                classSubscriptionId = (int)reader["ClassSubscriptionId"];
                                offerId = (int)reader["OfferId"];
                            }
                            else
                                isFound = false;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                isFound = false;
                throw new Exception(ex.Message);
            }

            return isFound;
        }

        public static bool getOfferClassSubscriptionInfoByOfferId(int offerId, ref int Id, ref DateTime subscripeData, ref float paidAmount,
            ref int classSubscriptionId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM OfferClassSubscriptions WHERE OfferId = @offerId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@offerId", offerId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Id = (int)reader["Id"];
                                subscripeData = (DateTime)reader["SubscripeDate"];
                                paidAmount = Convert.ToSingle(reader["PaidAmount"]);
                                classSubscriptionId = (int)reader["ClassSubscriptionId"];
                            }
                            else
                                isFound = false;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                isFound = false;
                throw new Exception(ex.Message);
            }

            return isFound;
        }

        public static int add(DateTime subscripeDate, float PaidAmount, int classSubscriptionId, int offerId)
        => CRUD.add(@$"INSERT INTO OfferClassSubscriptions (SubscripeDate, PaidAmount, ClassSubscriptionId, OfferId)
                       VALUES ('{subscripeDate}', {PaidAmount}, {classSubscriptionId}, {offerId}); SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, DateTime subscripeDate, float PaidAmount, int classSubscriptionId, int offerId)
        => CRUD.executeNonQuery(@$"UPDATE OfferClassSubscriptions
                                   SET SubscripeDate = '{subscripeDate}',
                                       PaidAmount = {PaidAmount},
                                       ClassScubscriptionId = {classSubscriptionId},
                                       OfferId = {offerId}
                                   WHERE Id = {Id}");


        public static DataTable getOfferSubscripers(int offerId)
        => CRUD.getUsingDateTable(@$"SELECT Memberships.Id, 
                                     CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS MembershipName,
                                     OfferClassSubscriptions.SubscripeDate, OfferClassSubscriptions.PaidAmount,
                                     CASE WHEN
                                     ClassSubscriptions.SubscripeStatus = 1 THEN 'New' 
                                     WHEN ClassSubscriptions.SubscripeStatus = 2 THEN 'Renew'
                                     WHEN ClassSubscriptions.SubscripeStatus = 3 THEN 'Freee'
                                     WHEN ClassSubscriptions.SubscripeStatus = 4 THEN 'Expired'
                                     WHEN ClassSubscriptions.SubscripeStatus = 5 THEN 'Expire Soon'
                                     END AS SubscripeStatus
                                     FROM OfferClassSubscriptions 
                                     INNER JOIN Offers ON OfferClassSubscriptions.OfferId = Offers.Id
                                     INNER JOIN ClassSubscriptions ON OfferClassSubscriptions.ClassSubscriptionId = ClassSubscriptions.Id
                                     INNER JOIN Coaches ON ClassSubscriptions.CoachId = Coaches.Id
                                     INNER JOIN ClassTypes ON Coaches.ClassTypeId = ClassTypes.Id
                                     INNER JOIN Memberships ON ClassSubscriptions.MembershipId = Memberships.Id
                                     INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                     INNER JOIN Persons ON Clients.PersonId = Persons.Id
                                     WHERE Offers.Id = {offerId}
                                     ORDER BY OfferClassSubscriptions.SubscripeDate DESC");
    }
}
