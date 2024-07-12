using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class PaymentMethodData
    {
        public static bool getPaymentMethodById(int Id, ref string Name)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM PaymentMethods WHERE Id = @Id";

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

        public static bool getPaymentMethodByName(string Name, ref int Id)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM PaymentMethods WHERE Name = @Name";

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

        public static int add(string name)
        => CRUD.add($"INSERT INTO PaymentMethods (Name) VALUES '({name})'; SELECT SCOPE_IDENTITY();");

        public static bool update(int Id, string name)
        => CRUD.executeNonQuery(@$"UPDATE PaymentMethods 
                                SET Name = '{name}'
                                WHERE Id = {Id}");

        public static DataTable get()
        => CRUD.getUsingDateTable("SELECT * FROM PaymentMethods");

        public static bool delete(int Id)
        => CRUD.executeNonQuery($"DELETE PaymentMethods WHERE Id = {Id}");
    }
}
