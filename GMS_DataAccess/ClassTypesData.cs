using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace GMS_DataAccess
{
    public class ClassTypesData
    {
        public static bool getClassDataTypesById(int Id, ref string name, ref float fees,
            ref bool allowFreeze, ref string? imagePath, ref int categoryId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ClassTypes WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                name = (string)reader["Name"];
                                fees = Convert.ToSingle(reader["Fees"]);
                                allowFreeze = Convert.ToBoolean(reader["AllowFreeze"]);
                                imagePath = reader["ImagePath"] == DBNull.Value ? string.Empty : (string)reader["ImagePath"];
                                categoryId = (int)reader["CategoryId"];
                            }
                            else return false;
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

        public static bool getClassTypeInfoByName(string Name, ref int Id, ref float fees,
            ref bool allowFreeze, ref string? imagePath, ref int categoryId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM ClassTypes WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Id = (int)reader["Id"];
                                fees = Convert.ToSingle(reader["Fees"]);
                                allowFreeze = Convert.ToBoolean(reader["AllowFreeze"]);
                                imagePath = reader["ImagePath"] == DBNull.Value ? string.Empty : (string)reader["ImagePath"];
                                categoryId = (int)reader["CategoryId"];
                            }
                            else return false;
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

        public static int add(string name, float fees, bool allowFreeze, string? imagePath, int categoryId)
        {
            int classId = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @$"INSERT INTO ClassTypes (Name, Fees, AllowFreeze, ImagePath, CategoryId)
                    VALUES (@name, @fees, @allowFreeze, @imagePath, @categoryId); SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Fees", fees);
                        command.Parameters.AddWithValue("@AllowFreeze", allowFreeze);
                        if (imagePath != null)
                            command.Parameters.AddWithValue("@ImagePath", imagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);

                        command.Parameters.AddWithValue("@CategoryId", categoryId);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                        {
                            classId = insertedId;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return classId;
        }
        public static bool update(int Id, string name, float fees, bool allowFreeze, string? imagePath, int categoryId)
        {
            //CRUD.executeNonQuery(@$"UPDATE ClassTypes 
            //                       SET Name = '{name}',
            //                       Fees = {fees}, 
            //                       AllowFreeze = {allowFreeze},
            //                       ImagePath = '{imagePath}',
            //                       CategoryId = {categoryId}
            //                       WHERE Id = {Id}");

            int rowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @$"UPDATE ClassTypes
                                  SET Name = @name,
                                      Fees = @fees,
                                      AllowFreeze = @allowFreeze,
                                      ImagePath = @imagePath,
                                      CategoryId = @categoryId
                                  WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Fees", fees);
                        command.Parameters.AddWithValue("@AllowFreeze", allowFreeze);
                        if (imagePath != string.Empty)
                            command.Parameters.AddWithValue("@ImagePath", imagePath);
                        else
                            command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
                        command.Parameters.AddWithValue("@CategoryId", categoryId);

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
        public static bool delete(int Id) => CRUD.executeNonQuery($"DELETE ClassTypes WHERE Id = {Id}");

        public static DataTable get() => 
        CRUD.getUsingDateTable(@$"SELECT ClassTypes.Id, ClassTypes.Name AS ClassName, Fees, 
                                  ClassCategories.Name AS CategoryName, 
                                  AllowFreeze
                                  FROM ClassTypes
                                  INNER JOIN ClassCategories ON ClassTypes.CategoryId = ClassCategories.Id
                                  ORDER BY Id");


    }
}
