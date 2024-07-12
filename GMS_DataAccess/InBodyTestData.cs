using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class InBodyTestData
    {
        public static bool getInBodyTestInfoById(int Id, ref DateTime measurementDate, ref float weight, ref float height,
            ref float fatPercentage, ref float muscleMass, ref float waterPercentage,
            ref bool fluidRetention, ref int membershipId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM InBodyInfomation WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                measurementDate = (DateTime)reader["MeasurementDate"];
                                weight = Convert.ToSingle(reader["Weight"]);
                                height = Convert.ToSingle(reader["Height"]);
                                fatPercentage = Convert.ToSingle(reader["FatPercentage"]);
                                muscleMass = Convert.ToSingle(reader["MuscleMass"]);
                                waterPercentage = Convert.ToSingle(reader["WaterPercentage"]);
                                fluidRetention = Convert.ToBoolean(reader["FluidRetention"]);
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
                throw new Exception("An error occurred while finding the InBody test", ex);
            }

            return isFound;
        }

        public static bool getInBodyTestInfoByMembershipId(int MembershipId, ref int Id, ref DateTime measurementDate,
            ref float weight, ref float height,
            ref float fatPercentage, ref float muscleMass, ref float waterPercentage,
            ref bool fluidRetention)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM InBodyInfomation WHERE MembershipId = @MembershipId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipId", MembershipId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                measurementDate = (DateTime)reader["MeasurementDate"];
                                weight = Convert.ToSingle(reader["Weight"]);
                                height = Convert.ToSingle(reader["Height"]);
                                fatPercentage = Convert.ToSingle(reader["FatPercentage"]);
                                muscleMass = Convert.ToSingle(reader["MuscleMass"]);
                                waterPercentage = Convert.ToSingle(reader["WaterPercentage"]);
                                fluidRetention = Convert.ToBoolean(reader["FluidRetention"]);
                                Id = (int)reader["Id"];
                            }
                            else isFound = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                isFound = false;
                throw new Exception("An error occurred while finding the InBody test", ex);
            }

            return isFound;
        }

        public static int add(DateTime measurementDate, float weight, float height,
            float fatPercentage, float muscleMass, float waterPercentage,
            bool fluidRetention, int membershipId)
        => CRUD.add($@"INSERT INTO InBodyInfomation (MeasurementDate, Weight, Height, FatPercentage,
                       MuscleMass, WaterPercentage, FluidRetention, MembershipId)
                       VALUES ('{measurementDate}', {weight}, {height}, {fatPercentage},
                       {muscleMass}, {waterPercentage}, {fluidRetention}, {membershipId});
                       SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, DateTime measurementDate, float weight, float height,
            float fatPercentage, float muscleMass, float waterPercentage,
            bool fluidRetention)
        => CRUD.executeNonQuery($@"UPDATE InBodyInfomation
                                   SET MeasurementDate = '{measurementDate}',
                                       Weight = {weight},
                                       Height = {height},
                                       FatPercentage = {fatPercentage},
                                       MuscleMass = {muscleMass}
                                       WaterPercentage = {waterPercentage},
                                       FluidRetention = {fluidRetention},
                                       WHERE Id = {Id}");

        public static bool delete(int Id) => CRUD.executeNonQuery($"DELETE InBodyInfomation WHERE Id = {Id}");

        public static DataTable get()
        => CRUD.getUsingDateTable(@"SELECT InBodyInfomation.Id, CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                    InBodyInfomation.MeasurementDate, InBodyInfomation.Weight, InBodyInfomation.Height, InBodyInfomation.FatPercentage, InBodyInfomation.MuscleMass,
                                    InBodyInfomation.WaterPercentage, InBodyInfomation.FluidRetention FROM InBodyInfomation
                                    INNER JOIN Memberships ON InBodyInfomation.MembershipId = Memberships.Id
                                    INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                    INNER JOIN Persons ON Clients.PersonId = Persons.Id");
    }
}
