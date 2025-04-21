using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bank_DataAccess
{
    public class clsCurrenciesData
    {
        public static bool GetCurrenceByID(int CurrenceID,ref string Country,ref string Code,ref string Name,ref float Rate)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = "Select * from Currencies Where CurrenceID = @CurrenceID";

            

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CurrenceID", CurrenceID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isfound = true;
                 
                    Country = (string)reader["Country"];
                    Code = (string)reader["Code"];
                    Name = (string)reader["Name"];
                    Rate =Convert.ToSingle( reader["Rate"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }

        public static int AddNewCurrence(string Country, string Code, string Name, float Rate)
        {
            int currnceID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"insert into Currencies (Country,Code,Name,Rate)
                             Values (@Country,@Code,@Name,@Rate);
                             select SCOPE_IDENTITY";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@code", Code);
            command.Parameters.AddWithValue(@"Name", Name);
            command.Parameters.AddWithValue("@Rate", Rate);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result == null && int.TryParse(result.ToString(), out int InsertID))
                {
                    currnceID = InsertID;
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return currnceID;
        }

        public static bool UpdateCurrnce(int CurrenceID,string Country, string Code, string Name, float Rate)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"Update Currencies 
                             set 
                                  Rate = @Rate
                            Where CurrenceID = @CurrenceID  ";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@CurrenceID",CurrenceID);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@code", Code);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Rate", Rate);

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static DataTable AllCurrncies()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = "Select * from Currencies ";

            SqlCommand command = new SqlCommand(query,connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataTable.Load(reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }
    }
}
