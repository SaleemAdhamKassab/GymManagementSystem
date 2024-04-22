using System.Data;
using System.Data.SqlClient;

namespace GMS_DataAccess
{
    internal class CRUD
    {

        /////////// Old Project
        public static SqlCommand sharedSqlCommand(string query) => new SqlCommand()
        {
            Connection = new SqlConnection(DataAccessSettings.ConnectionString),
            CommandType = CommandType.Text,
            CommandText = query
        };
        private static void sharedErrorMessage(string errorMessage) => throw new Exception("Error: " + errorMessage);
        public static int add(string query)
        {
            int insertedId = -1;
            SqlCommand sqlCommand = sharedSqlCommand(query);
            try
            {
                sqlCommand.Connection.Open();
                object result = sqlCommand.ExecuteScalar();

                //if (result != null && int.TryParse(result.ToString(), out int id))
                if (result != null)
                    insertedId = int.Parse(result.ToString());
            }
            catch (Exception ex)
            {
                sharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return insertedId;
        }
        public static bool executeNonQuery(string query)
        {
            SqlCommand sqlCommand = sharedSqlCommand(query);
            try
            {
                sqlCommand.Connection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                sharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return false;
        }






        public static int getById(string query)
        {
            int id = -1;
            SqlCommand sqlCommand = sharedSqlCommand(query);
            try
            {
                sqlCommand.Connection.Open();
                object result = sqlCommand.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int resultId))
                    id = resultId;
            }
            catch (Exception ex)
            {
                sharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return id;
        }
        public static DataTable getUsingDateTable(string query)
        {
            DataTable dataTable = new();
            SqlCommand sqlCommand = sharedSqlCommand(query);
            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                    dataTable.Load(dataReader);
                dataReader.Close();

            }
            catch (Exception ex)
            {
                sharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return dataTable;
        }
        public static object getOneValueBasedOnCondition(string query, string name)
        {
            object result = "";
            SqlCommand sqlCommand = sharedSqlCommand(query);
            try
            {
                sqlCommand.Connection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                    result = (object)reader[name];

                reader.Close();
            }
            catch (Exception ex)
            {
                sharedErrorMessage(ex.Message);
            }
            finally
            {
                sqlCommand.Connection.Close();
            }

            return result;
        }
        public static bool isExists(string query) => getById(query) > 0;



        //// Saleem



        //// Nidal


    }
}