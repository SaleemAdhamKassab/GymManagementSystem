using System;
using System.Data.SqlClient;
using System.Data;

namespace GMS_DataAccess
{
    public class OfferData
    {
        public static bool getOfferInfoById(int Id, ref string name, ref int discount, ref int duration, ref DateTime startDate,
            ref DateTime endDate, ref DateTime addedOn, ref float feeAfterDiscount, ref int classTypeId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Offers WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                name = (string)reader["Name"];
                                discount = (int)reader["Discount"];
                                duration = (int)reader["Duration"];
                                startDate = (DateTime)reader["StartDate"];
                                endDate = (DateTime)reader["EndDate"];
                                addedOn = (DateTime)reader["AddedOn"];
                                feeAfterDiscount = Convert.ToSingle(reader["FeeAfterDiscount"]);
                                classTypeId = (int)reader["ClassTypeId"];
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
                throw ex = new Exception(ex.Message);
            }

            return isFound;
        }

        public static bool getOfferInfoByName(string name, ref int Id, ref int discount, ref int duration, ref DateTime startDate,
            ref DateTime endDate, ref DateTime addedOn, ref float feeAfterDiscount, ref int classTypeId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Offers WHERE Name = @name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Id = (int)reader["Id"];
                                discount = (int)reader["Discount"];
                                duration = (int)reader["Duration"];
                                startDate = (DateTime)reader["StartDate"];
                                endDate = (DateTime)reader["EndDate"];
                                addedOn = (DateTime)reader["AddedOn"];
                                feeAfterDiscount = Convert.ToSingle(reader["FeeAfterDiscount"]);
                                classTypeId = (int)reader["ClassTypeId"];
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
                throw ex = new Exception(ex.Message);
            }

            return isFound;
        }

        public static int add(string name, int discount, int duration, DateTime startDate, DateTime endDate,
            DateTime addedOn, float feeAfterDiscount, int classTypeId)
        => CRUD.add($@"INSERT INTO Offers (Name, Discount, Duration, StartDate, EndDate, AddedOn, FeeAfterDiscount, ClassTypeId)
                       VALUES ('{name}', {discount}, {duration}, '{startDate}', '{endDate}', 
                                '{addedOn}', {feeAfterDiscount}, {classTypeId}); SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, string name, int discount, int duration, DateTime startDate, DateTime endDate,
            DateTime addedOn, float feeAfterDiscount, int classTypeId)
        => CRUD.executeNonQuery($@"UPDATE Offers
                                   SET Name = '{name}',
                                       Discount = {discount},
                                       Duration = {duration},
                                       StartDate = '{startDate}', 
                                       EndDate = '{endDate}', 
                                       AddedOn = '{addedOn}',
                                       FeeAfterDiscount = {feeAfterDiscount},
                                       ClassTypeId = {classTypeId}
                                   WHERE Id = {Id}");

        public static DataTable getOfferClassByClassName(string className)
        => CRUD.getUsingDateTable(@$"SELECT Offers.Name, ClassTypes.Name AS ClassName, Offers.Discount, Offers.Duration, Offers.StartDate,
                                     Offers.EndDate, Offers.AddedOn, Offers.FeeAfterDiscount,
                                     ClassTypes.Fees
                                     FROM Offers INNER JOIN ClassTypes ON Offers.ClassTypeId = ClassTypes.Id
                                     WHERE ClassTypes.Name = '{className}' AND (GETDATE() BETWEEN Offers.StartDate AND Offers.EndDate)");

        public static DataTable get()
        => CRUD.getUsingDateTable(@"SELECT Offers.Id, Offers.Name AS OfferName, ClassTypes.Name AS ClassName, 
                                    CONCAT(Offers.Discount, '', '%')AS Discount,
                                    CONCAT(Offers.Duration, ' ', 'm') AS Duration,
                                    FORMAT(Offers.StartDate, 'dd-MM-yyyy') AS StartDate , 
                                    FORMAT(Offers.EndDate, 'dd-MM-yyyy') AS EndDate,
                                    FORMAT(Offers.AddedOn, 'dd-MM-yyyy') AS AddedOn,
                                    Offers.FeeAfterDiscount
                                    FROM Offers INNER JOIN ClassTypes ON Offers.ClassTypeId = ClassTypes.Id
                                    ORDER BY AddedOn DESC");

        
    }
}
