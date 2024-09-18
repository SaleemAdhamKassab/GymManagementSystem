using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace GMS_DataAccess
{
    public class CoachData
    {
        public static bool getCoachInfoById(int Id, ref string achivementsAndAwards, ref bool isActive,
            ref int personId, ref int classTypeId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Coaches WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                achivementsAndAwards = (string)reader["AchievementsAndAwards"];
                                isActive = Convert.ToBoolean(reader["IsActive"]);
                                personId = (int)reader["PersonId"];
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
                throw new Exception(ex.Message);
            }

            return isFound;
        }

        public static bool getCoachInfoByPersonId(int personId, ref int Id, ref string achivementsAndAwards, 
            ref bool isActive, ref int classTypeId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Coaches WHERE PersonId = @PersonId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonId", personId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Id = (int)reader["Id"];
                                achivementsAndAwards = (string)reader["AchievementsAndAwards"];
                                isActive = Convert.ToBoolean(reader["IsActive"]);
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
                throw new Exception(ex.Message);
            }

            return isFound;
        }

        public static bool getCoachInfoByFullName(string FirstName, string SecondName, string ThirdName, string LastName,
            ref byte gendor, ref DateTime dateOfBirth, ref string address, ref string phone, 
            ref string? email, ref string? imagePath, ref int roleId,
            ref int Id, ref string achievementAndAwards, ref bool isActive, ref int personId, ref int classTypeId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = $@"SELECT Persons.FirstName, Persons.SecondName, Persons.ThirdName, Persons.LastName,
                                      Persons.Gendor, Persons.DateOfBirth, Persons.Address, Persons.Phone, Persons.Email, Persons.ImagePath, Persons.RoleId,
                                      Coaches.Id, Coaches.AchievementsAndAwards, Coaches.IsActive,
				                      Coaches.PersonId, Coaches.ClassTypeId
                                      FROM Coaches
                                      INNER JOIN Persons ON Coaches.PersonId = Persons.Id
                                      WHERE FirstName = '{FirstName}' AND SecondName = '{SecondName}' AND ThirdName = '{ThirdName}' AND LastName = '{LastName}'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@SecondName", SecondName);
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                        command.Parameters.AddWithValue("@LastName", LastName);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                gendor = Convert.ToByte(reader["Gendor"]);
                                dateOfBirth = (DateTime)reader["DateOfBirth"];
                                address = (string)reader["Address"];
                                phone = (string)reader["Phone"];
                                email = reader["Email"] == DBNull.Value ? null : (string)reader["Email"];
                                imagePath = reader["ImagePath"] == DBNull.Value ? null : (string)reader["ImagePath"];
                                roleId = (int)reader["RoleId"];
                                Id = (int)reader["Id"];
                                achievementAndAwards = (string)reader["AchievementsAndAwards"];
                                isActive = Convert.ToBoolean(reader["IsActive"]);
                                personId = (int)reader["PersonId"];
                                classTypeId = (int)reader["ClassTypeId"];
                                return true;
                            }

                            else isFound = false;
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return isFound;
        }

        public static int add(string fName, string sName, string thName, string lName,
            byte gendor, DateTime dateOfBirth, string address, string phone, string email,
            string imagePath, string achievmentAndAwards, bool isActive, int classTypeId)
        {
            int personId = -1, coachId = -1;

            personId = PersonData.add(fName, sName, thName, lName, gendor, dateOfBirth, address, phone, email, imagePath, 4);

            if (personId == -1)
            {
                PersonData.deletePerson(personId);
                return -1;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Coaches (AchievementsAndAwards, PersonId, ClassTypeId, IsActive)
                                 VALUES (@achievmentAndAwards, @personId, @classTypeId, @isActive);
                                 SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@achievmentAndAwards", achievmentAndAwards);
                        command.Parameters.AddWithValue("@personId", personId);
                        command.Parameters.AddWithValue("@classTypeId", classTypeId);
                        command.Parameters.AddWithValue("@isActive", isActive);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                        {
                            coachId = insertedId;
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return coachId;
        }

        public static bool update(int Id, string fName, string sName, string thName, string lName,
            byte gendor, DateTime dateOfBirth, string address, string phone, string email,
            string imagePath, string achievmentAndAwards, bool isActive, int classTypeId, int personId)
        {
            int rowsAffected = 0;
            bool isPersonUpdated = false;

            isPersonUpdated = PersonData.update(personId, fName, sName, thName, lName, gendor,
            dateOfBirth, address, phone, email, imagePath, 4);

            if (!isPersonUpdated)
                return false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @"UPDATE Coaches
                                     SET AchievementsAndAwards = @achievmentAndAwards,
                                         ClassTypeId = @classTypeId,
                                         IsActive = @isActive
                                     WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@achievmentAndAwards", achievmentAndAwards);
                        command.Parameters.AddWithValue("@classTypeId", classTypeId);
                        command.Parameters.AddWithValue("@isActive", isActive);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return (rowsAffected > 0);
        }

        public static DataTable get()
        => CRUD.getUsingDateTable(@"SELECT Coaches.Id, 
                                    CoachName = CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName),
                                    AchievementsAndAwards, ClassName = Name, Coaches.IsActive
                                    FROM Coaches
                                    INNER JOIN Persons ON Coaches.PersonId = Persons.Id
                                    INNER JOIN ClassTypes ON Coaches.ClassTypeId = ClassTypes.Id");

        public static DataTable getCoachClassesInfoByPersonId(int personId)
        => CRUD.getUsingDateTable($@"SELECT Coaches.Id,CoachName = CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName),
                                     CASE 
                                     WHEN Persons.Gendor = 0 THEN 'Male'
                                     ELSE 'Femal'
                                     END AS Gendor, Persons.DateOfBirth, Persons.Email,
                                     ClassTypes.Name AS ClassName FROM Coaches
                                     INNER JOIN ClassTypes ON Coaches.ClassTypeId = ClassTypes.Id
                                     INNER JOIN Persons ON Coaches.PersonId = Persons.Id
                                     WHERE PersonId = {personId}");

        public static DataTable getAllCoachWithOneClassByClassName(string className)
        => CRUD.getUsingDateTable($@"SELECT Coaches.Id,CoachName = CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName),
                                     CASE 
                                     WHEN Persons.Gendor = 0 THEN 'Male'
                                     ELSE 'Femal'
                                     END AS Gendor, Coaches.AchievementsAndAwards, Persons.Email,
                                     ClassTypes.Name AS ClassName FROM Coaches
                                     INNER JOIN Persons ON Coaches.PersonId = Persons.Id
                                     INNER JOIN ClassTypes ON Coaches.ClassTypeId = ClassTypes.Id
                                     WHERE ClassTypes.Name = '{className}'");
    }
}
