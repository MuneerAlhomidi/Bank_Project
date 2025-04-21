using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Bank_DataAccess
{
    public class clsClientsData
    {
        public static bool GetClientInfoByClientID(int  clientID, ref int PersonID,ref string PinCode, 
                                              ref string AccountNumber,ref float AccountBalance)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = "SELECT * FROM Clients WHERE ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", clientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    isfound = true;
                    PersonID = (int)reader["PersonID"];
                    PinCode = (string)reader["PinCode"];
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);
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


        public static bool GetClientInfoByPersonID( int PersonID,ref int clientID, ref string PinCode,
                                              ref string AccountNumber, ref float AccountBalance)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = "SELECT * FROM Clients WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    PersonID = (int)reader["ClientID"];
                    PinCode = (string)reader["PinCode"];
                    AccountNumber = (string)reader["AccountNumber"];
                    AccountBalance = Convert.ToSingle(reader["AccountBalance"]);
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

     
        public static int AddNewClient(int PersonID,string PinCode,string AccountNumber,float AccountBalance)
        {
            int ClientID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"Insert into Clients
                                          (PersonID,PinCode,AccountNumber,AccountBalance) 
                                  Values         
                                          (@PersonID,@PinCode,@AccountNumber,@AccountBalance);
                                           Select SCOPE_IDENTITY() ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return ClientID;
        }

        public static bool UpdateClient(int ClientID,int PersonID, string PinCode, string AccountNumber, float AccountBalance)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"Update Clients 
                            set
                                   
                                  PersonID = @PersonID,
                                  PinCode = @PinCode,
                                  AccountNumber = @AccountNumber,
                                  AccountBalance = @AccountBalance

                           Where  ClientID = @ClientID";

            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ClientID",ClientID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return (RowsAffected > 0);
        }

        public static bool DeleteClient(int ClientID)
        {
            int rowsaffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = "Delete Clients where ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ClientID",ClientID);
            try
            {
                connection.Open();
                rowsaffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }

            return (rowsaffected > 0);
        }

        public static bool IsExistClients(int ClientID)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = "Select Found=1 from Clients where ClientID = @ClientID";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isfound = reader.HasRows;

                reader.Close();
            }
            catch( Exception ex)
            {

            }
            finally
            {
                connection.Close() ;
            }
            return isfound;
        }

        public static DataTable GetAllClient()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString) ;
            string query = @"SELECT Clients.ClientID, Clients.PersonID,
                                    fullName = People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName, '')
                                    + ' ' + People.LastName , Clients.PinCode, Clients.AccountNumber, Clients.AccountBalance
                           FROM     Clients INNER JOIN
                                     People ON Clients.PersonID = People.PersonID";
            SqlCommand command = new SqlCommand(query,connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch ( Exception ex )
            {

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static DataTable GetTotalBalance()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString))
                {
                    connection.Open();
                    string query = @"SELECT Clients.AccountNumber,fullName = People.FirstName + ' ' + 
                                         People.SecondName + ' ' + People.ThirdName + ' ' +  
                                         ISNULL(People.LastName,''), Clients.AccountBalance
                                FROM     Clients INNER JOIN
                                         People ON Clients.PersonID = People.PersonID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }

                    }
                }
            }
            catch (Exception ex) { }

            return dt;
        }

        public static bool IsExistClientForPerson(int PersonID)
        {
            bool  isfound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"SELECT Found=1 From Clients Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isfound = reader.HasRows;

                reader.Close();
            }
            catch( Exception ex )
            {
                isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }

        public static bool IsExistClientForAccountNumber(string AccountNumber)
        {
            bool isfound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"SELECT Found=1 From Clients Where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(@"AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isfound = reader.HasRows;

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

        public static bool ChengeBalance(int ClientID,float AccountBalance)
        {
            int RowsAffected = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString))
                {
                    connection.Open();
                    string query = @"Update Clients set AccountBalance = @AccountBalance
                                             where ClientID = @ClientID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ClientID", ClientID);
                        command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

                        RowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

            return (RowsAffected > 0);
        }
    }
}
