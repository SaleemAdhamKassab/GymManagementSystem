using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class PersonData
    {
        public static bool getPersonDataById(int Id, ref string firstName, ref string lastName, ref string address,
            ref string phone, ref int roleId)
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

                    firstName = (string)reader["FirstName"];
                    lastName = (string)reader["LastName"];
                    address = (string)reader["Address"];
                    phone = (string)reader["Phone"];
                    Id = (int)reader["Id"];
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

        public static int add(string firstName, string lastName, string address, string phone, int roleId) =>
            CRUD.add($"INSERT INTO Persons (FirstName, LastName, Address, Phone, RoleId) VALUES ('{firstName.Trim()}', '{lastName.Trim()}', '{
                address.Trim()}', '{phone.Trim()}', '{roleId}')");

        public static bool update(int personId, string firstName, string lastName, string address, string phone, int roleId)
            => CRUD.executeNonQuery($"UPDATE Persons SET FirstName = '{firstName.Trim()}', LastName = '{lastName.Trim()
                }, Address = '{address.Trim()}', Phone = '{phone.Trim()}', RoleId = {roleId}");

        public static bool isPersonExist(int personId) => CRUD.isExists($"SELECT Found = 1 FROM Persons WHERE PersonId = {personId}");

        public static DataTable getPersonList() => CRUD.getUsingDateTable("SELECT * FROM Persons");
        public static bool deletePerson(int Id) => CRUD.executeNonQuery($"DELETE Persons WHERE Id = {Id}");
    }
}
