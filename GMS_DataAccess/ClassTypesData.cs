using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace GMS_DataAccess
{
    public class ClassTypesData
    {
        public static bool getClassDataTypesById(int Id, ref string name, ref float fees,
            ref bool allowFreeze, ref string? imagePath,ref int coachId, ref int categoryId)
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
                                coachId = (int)reader["CoachId"];
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
            ref bool allowFreeze, ref string? imagePath, ref int coachId, ref int categoryId)
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
                                coachId = (int)reader["CoachId"];
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

        public static int add(string name, float fees, bool allowFreeze, string? imagePath, int coachId, int categoryId)
        => CRUD.add(@$"INSERT INTO ClassTypes (Name, Fees, AllowFreeze, ImagePath, CoachId, CategoryId)
                    VALUES ('{name}', {fees}, {allowFreeze}, {imagePath}, {coachId}, {categoryId}); SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, string name, float fees, bool allowFreeze, string? imagePath, int coachId, int categoryId)
        => CRUD.executeNonQuery(@$"UPDATE ClassTypes SET Name = '{name}', Fees = {fees}, AllowFreeze = {allowFreeze},
                                                       ImagePath = '{imagePath}' CoachId = {coachId}, CategoryId = {categoryId}
                                    WHERE Id = {Id}");

        public static bool delete(int Id) => CRUD.executeNonQuery($"DELETE ClassTypes WHERE Id = {Id}");

        public static DataTable get() => CRUD.getUsingDateTable("SELECT * FROM ClassTypes");


    }
}
