using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class UserData
    {
        public static bool GetUserInfoById(int Id, ref string UserName,
            ref string Password, ref bool isAdmin, ref bool isActive, ref int PersonId)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Users WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    isAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                    isActive = Convert.ToBoolean(reader["IsActive"]);
                    PersonId = (int)reader["PersonId"];
                }
                else IsFound = false;

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

        public static bool getUserInfoByPersonId(int personId, ref int UserId, ref string userName, ref bool isAdmin,
            ref string password, ref bool isActive)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users WHERE PersonId = @personId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@personId", personId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                UserId = (int)reader["UserId"];
                                userName = (string)reader["UserName"];
                                password = (string)reader["Password"];
                                isAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                                isActive = Convert.ToBoolean(reader["IsActive"]);
                            }
                            else isFound = false;
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

        public static bool getUserByUserNameAndPassword(string UserName, string Password, ref int Id,
            ref bool IsAdmin, ref bool IsActive, ref int PersonId)
        {
            bool isFound = false;

            using ( SqlConnection connection = new SqlConnection( DataAccessSettings.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@Password", Password);

                    using ( SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            isFound = true;

                            Id = (int)reader["Id"];
                            IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
                            IsActive = Convert.ToBoolean(reader["IsActive"]);
                            PersonId = (int)reader["PersonId"];
                        }
                        else { isFound = false; }
                    }
                }
            }

            return isFound;
        }

        public static DataTable get()
        => CRUD.getUsingDateTable(@"SELECT Users.Id, Name = CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName),
                                    Users.UserName, Persons.Email, 
									CASE
									WHEN Persons.Gendor = 0 THEN 'Male'
									WHEN Persons.Gendor = 1 THEN 'Female'
									END AS Gendor, 
									Persons.Phone, Persons.Address,
									CASE 
									WHEN Users.IsAdmin = 1 THEN 'Admin'
									WHEN Users.IsAdmin = 0 THEN 'User'
									END AS Role, 
                                    Users.IsActive
                                    FROM Users
                                    INNER JOIN Persons ON Users.PersonId = Persons.Id");

        public static int add(string fName, string sName, string thName, string lName, byte gendor, DateTime DOF,
            string address, string phone, string email, string imagePath,
            string userName, string password, bool isAdmin, bool isAcive)
        {
            int userId = -1, personId = -1;

            personId = PersonData.add(fName, sName, thName, lName, gendor, DOF, address, phone, email, imagePath, 6);

            if (personId == -1) return -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Users (UserName, Password, IsAdmin, IsActive, PersonId)
                                     VALUES (@userName, @password, @isAdmin, @isActive, @personId);
                                     SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@IsAdmin", isAdmin);
                        command.Parameters.AddWithValue("@isActive", isAcive);
                        command.Parameters.AddWithValue("@personId", personId);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                        {
                            userId = insertedId;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return userId;
        }

        public static bool update(int Id, string fName, string sName, string thName, string lName, byte gendor, DateTime DOF,
            string address, string phone, string email, string imagePath,
            string userName, string password, bool isAdmin, bool isActive, int personId)
        {
            int rowsAffected = 0;
            bool isPersonUpdated = false;

            isPersonUpdated = PersonData.update(personId, fName, sName, thName, lName,
                gendor, DOF, address, phone,
                email, imagePath, 6);

            if (!isPersonUpdated) return false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Users
                                     SET UserName = @userName,
                                         Password = @password,
                                         IsAdmin = @isAdmin,
                                         IsActive = @isActive
                                     WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@IsAdmin", isAdmin);
                        command.Parameters.AddWithValue("@isActive", isActive);

                        rowsAffected = command.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return (rowsAffected > 0);
        }

        public static bool Delete(int Id)
        => CRUD.executeNonQuery($"DELETE FROM Users WHERE Id = {Id}");
    }
}
