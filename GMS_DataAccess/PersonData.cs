using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class PersonData
    {
        public static bool getPersonDataById(int Id, ref string firstName, ref string secondName,
            ref string thirdName, ref string lastName, ref byte gendor, ref DateTime dateOfBirth, ref string address,
            ref string? email, ref string phone, ref string? imagePath, ref int roleId)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Persons WHERE Id = @Id";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Id", Id);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Id = (int)reader["Id"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    thirdName = (string)reader["ThirdName"];
                    lastName = (string)reader["LastName"];
                    gendor = Convert.ToByte(reader["Gendor"]);
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    address = (string)reader["Address"];
                    phone = (string)reader["Phone"];
                    email = reader["Email"] == DBNull.Value ? null : (string)reader["Email"];
                    imagePath = reader["ImagePath"] == DBNull.Value ? null : (string)reader["ImagePath"];
                    roleId = (int)reader["RoleId"];
                }
                else
                    isFound = false;

                reader.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
                ex = new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int add(string firstName, string secondName, string thirdName, string lastName, byte gendor,
            DateTime dateOfBirth, string address, string phone, string? email, string? imagePath, int roleId)
        {
            int personId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Persons (FirstName, SecondName, ThirdName, LastName,
                             Gendor, DateOfBirth, Address, Phone, Email, ImagePath, RoleId)
                             VALUES (@firstName, @secondName, @thirdName, @lastName,
                             @gendor, @dateOfBirth, @address, @phone, @email, @imagePath, @roleId);
                             SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@SecondName", secondName);
                        command.Parameters.AddWithValue("@ThirdName", thirdName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Gendor", gendor);
                        command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? System.DBNull.Value : email.Trim());
                        command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(imagePath) ? System.DBNull.Value : imagePath.Trim());
                        command.Parameters.AddWithValue("@RoleId", roleId);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                            personId = insertedId;
                    }

                }
            }
            catch (Exception ex)
            {
                ex = new Exception(ex.Message);
            }

            return personId;
        }

        public static bool update(int personId, string firstName, string secondName, string thirdName, string lastName, byte gendor,
            DateTime DateOfBirth, string address, string phone, string? email, string? imagePath, int roleId)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = @"UPDATE Persons
                                    SET FirstName = @firstName,
                                        SecondName = @secondName,
                                        ThirdName = @thirdName,
                                        LastName = @lastName,
                                        Gendor = @gendor,
                                        DateOfBirth = @dateOfBirth,
                                        Address = @address,
                                        Phone = @phone,
                                        Email = @email,
                                        ImagePath = @imagePath,
                                        RoleId = @roleId
                                    WHERE Id = @personId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PersonId", personId);
                        command.Parameters.AddWithValue("@FirstName", firstName);
                        command.Parameters.AddWithValue("@SecondName", secondName);
                        command.Parameters.AddWithValue("@ThirdName", thirdName);
                        command.Parameters.AddWithValue("@LastName", lastName);
                        command.Parameters.AddWithValue("@Gendor", gendor);
                        command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Phone", phone);
                        command.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? System.DBNull.Value : email.Trim());
                        command.Parameters.AddWithValue("@ImagePath", string.IsNullOrEmpty(imagePath) ? System.DBNull.Value : imagePath.Trim());
                        command.Parameters.AddWithValue("@RoleId", roleId);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ex = new Exception(ex.Message);
            }

            return (rowsAffected > 0);
        }

        //public static bool update(int personId, string firstName, string secName, string thirdName, string lastName, byte gendor,
        //    string address, string phone, string? email, string? imagePath, int roleId)
        //=> CRUD.executeNonQuery($"UPDATE Persons SET FirstName = {firstName}, SecondName = {secName}, ThirdName = {thirdName}, LastName = {lastName
        //    }, {gendor}, {address}, {phone}, {email}, {imagePath}, {roleId}");

        public static bool isPersonExist(int personId) => CRUD.isExists($"SELECT Found = 1 FROM Persons WHERE PersonId = {personId}");

        public static DataTable getPersonList() => CRUD.getUsingDateTable("SELECT * FROM Persons");
        public static bool deletePerson(int Id) => CRUD.executeNonQuery($"DELETE Persons WHERE Id = {Id}");
    }
}
