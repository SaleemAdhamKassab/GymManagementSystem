using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class ClassCategoriesData
    {
        public static bool getCategoryClassInfoById(int Id, ref string Name)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM ClassCategories WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Name = (string)reader["Name"];
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

        public static bool getCategoryClassInfoByName(ref int Id, string Name)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM ClassCategories WHERE Name = @Name";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

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
                ex = new Exception(ex.Message);
            }

            return isFound;
        }

        public static int add(string name) => CRUD.add($"INSERT INTO ClassCategories (Name) VALUES ('{name}'); SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, string name) 
        => CRUD.executeNonQuery($@"UPDATE ClassCategories
                                   SET Name = '{name}'
                                   WHERE Id = {Id}");

        public static bool delete(int id)
        => CRUD.executeNonQuery($@"DELETE FROM ClassCategories WHERE Id = {id}");

        public static DataTable get() => CRUD.getUsingDateTable($"SELECT * FROM ClassCategories");

        public static DataTable getClassTypesByClassCategorName(string categoryName)
        => CRUD.getUsingDateTable(@$"SELECT ClassTypes.Id, ClassTypes.Name, ClassTypes.Fees, ClassTypes.ImagePath,
                                    ClassCategories.Name AS CategoryName, ClassTypes.CategoryId
                                    FROM ClassCategories INNER JOIN ClassTypes ON ClassTypes.CategoryId = ClassCategories.Id
                                    WHERE ClassCategories.Name = '{categoryName}'");
    }
}
