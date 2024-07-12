using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class PaymentData
    {
        public static bool getPaymentInfoById(int Id, ref float Amount, ref DateTime Date, ref int PaymentMethodId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    string query = "SELECT * FROM Payments WHERE Id = @Id";

                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {
                                isFound = true;

                                Amount = Convert.ToSingle(reader["Amount"]);
                                Date = (DateTime)reader["Date"];
                                PaymentMethodId = (int)reader["PaymentMethodId"];
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

        public static int add(float amount, DateTime date, int PaymentMethodId)
        => CRUD.add(@$"INSERT INTO Payments (Amount, Date, PaymentMethodId)
                    VALUES ({amount}, '{date}', {PaymentMethodId});
                    SELECT SCOPE_IDENTITY();");

        public static bool Update(int Id, float amount, DateTime date, int PaymentMethodId)
        => CRUD.executeNonQuery(@$"UPDATE Payments
                                SET Id = {Id},
                                    Amount = {amount},
                                    Date = {date},
                                    PaymentMethodId = {PaymentMethodId}");

        public static bool delete(int Id)
        => CRUD.executeNonQuery($"DELETE Payments WHERE Id = {Id}");

        public static DataTable get()
        => CRUD.getUsingDateTable("SELECT * FROM Payments");
    }
}
