using System;
using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    public class HealthFormData
    {
        public static bool getHealthFormInfoById(int Id, ref string healthIssue, ref string? emargencyContactName,
            ref string? emargencyContactPhone, ref DateTime dateFilled, ref int membershipId)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM HealthForms WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                healthIssue = (string)reader["HealthIssue"];
                                emargencyContactName = reader["EmergencyContactName"] == null ? string.Empty : (string)reader["EmargencyContactName"];
                                emargencyContactPhone = reader["EmergencyContactPhone"] == null ? string.Empty : (string)reader["EmargencyContactPhone"];
                                dateFilled = (DateTime)reader["DateFilled"];
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
                ex = new Exception(ex.Message);
            }

            return isFound;
        }

        public static bool getHealthFormInfoByMembershipId(int MembershipId, ref int Id, ref string healthIssue, ref string? emargencyContactName,
            ref string? emargencyContactPhone, ref DateTime dateFilled)
        {
            bool isFound = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM HealthForms WHERE MembershipId = @MembershipId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MembershipId", MembershipId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                Id = (int)reader["Id"];
                                healthIssue = (string)reader["HealthIssue"];
                                emargencyContactName = reader["EmergencyContactName"] == null ? string.Empty : (string)reader["EmargencyContactName"];
                                emargencyContactPhone = reader["EmergencyContactPhone"] == null ? string.Empty : (string)reader["EmargencyContactPhone"];
                                dateFilled = (DateTime)reader["DateFilled"];
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

        public static int add(string healthIssue, string? emergencyContactName, string? emergencyContactPhone, DateTime dateFilled, int membershipId)
        {
            int Id = -1;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = @$"INSERT INTO HealthForms (HealthIssue, EmergencyContactName, EmergencyContactPhone,
                                      DateFilled, MembershipId)
                                      VALUES (@HealthIssue, @EmergencyContactName, @EmergencyContactPhone,
                                      @dateFilled, @membershipId);
                                      SELECT SCOPE_IDENTITY();";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HealthIssue", healthIssue);
                        if (emergencyContactName != string.Empty)
                            command.Parameters.AddWithValue("@EmergencyContactName", emergencyContactName);
                        else
                            command.Parameters.AddWithValue("@EmergencyContactName", System.DBNull.Value);
                        if (emergencyContactPhone != string.Empty)
                            command.Parameters.AddWithValue("@EmergencyContactPhone", emergencyContactPhone);
                        else
                            command.Parameters.AddWithValue("@EmergencyContactPhone", System.DBNull.Value);
                        command.Parameters.AddWithValue("@DateFilled", dateFilled);
                        command.Parameters.AddWithValue("@MembershipId", membershipId);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                            Id = insertedId;
                    }


                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the health form.", ex);
            }

            return Id;
        }

        public static bool update(int Id, string HealthIssue, string? EmergencyContactName,  string? EmergencyContactPhone,
            DateTime DateFilled, int MembershipId)
        {
            int rowsAffected = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataAccessSettings.ConnectionString))
                {
                    connection.Open();

                    string query = $@"UPDATE HealthForms
                                      SET HealthIssue = @HealthIssue,
                                          EmergencyContactName = @EmergencyContactName,
                                          EmergencyContactPhone = @EmergencyContactPhone,
                                          DateFilled = @DateFilled
                                          WHERE MembershipId = @MembershipId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@HealthIssue", HealthIssue);
                        if (EmergencyContactName != string.Empty)
                            command.Parameters.AddWithValue("@EmergencyContactName", EmergencyContactName);
                        else
                            command.Parameters.AddWithValue("@EmergencyContactName", System.DBNull.Value);
                        if (EmergencyContactPhone != string.Empty)
                            command.Parameters.AddWithValue("@EmergencyContactPhone", EmergencyContactPhone);
                        else
                            command.Parameters.AddWithValue("@EmergencyContactPhone", System.DBNull.Value);
                        command.Parameters.AddWithValue("@DateFilled", DateFilled);
                        command.Parameters.AddWithValue("@MembershipId", MembershipId);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating health form", ex);
            }

            return (rowsAffected > 0);
        }

        public static bool delete(int Id) => CRUD.executeNonQuery($"DELETE HealthForms WHERE Id = {Id}");

        public static DataTable get()
        => CRUD.getUsingDateTable($@"SELECT HealthForms.MembershipId, CONCAT(Persons.FirstName, ' ', Persons.SecondName, ' ', Persons.ThirdName, ' ', Persons.LastName) AS ClientName,
                                     HealthForms.HealthIssue, HealthForms.EmergencyContactName,HealthForms.EmergencyContactPhone,
                                     HealthForms.DateFilled FROM HealthForms
                                     INNER JOIN Memberships ON HealthForms.MembershipId = Memberships.Id
                                     INNER JOIN Clients ON Memberships.ClientId = Clients.Id
                                     INNER JOIN Persons ON Clients.PersonId = Persons.Id");

    }
}
