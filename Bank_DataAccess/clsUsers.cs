using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Bank_DataAccess
{
    public class clsUsersData
    {
        public static bool GetUserInfoByID(int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool IsActive, ref int Permissions)
        {
            bool Isfound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"Select * from Users where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Isfound = true;

                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permissions = (int)reader["Permissions"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return Isfound;
        }

        public static bool GetUserInfoByPersonID(int PersonID, ref int UserID, ref string UserName, ref string Password, ref bool IsActive, ref int Permissions)
        {
            bool Isfound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"Select * from Users where PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Isfound = true;

                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permissions = (int)reader["Permissions"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Isfound = false;
            }
            finally
            {
                connection.Close();
            }
            return Isfound;
        }

        public static bool GetUserInfoByUserNameAndPassword(string UserName, string Password,ref int UserID , ref int PersonID, ref bool IsActive, ref int Permissions)
        {
            bool Isfound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"Select * from Users where UserName = @UserName and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Isfound = true;

                    UserID = (int)reader["UserID"];
                    UserName = (string)reader["UserName"];
                    Password = (string)reader["Password"];
                    IsActive = (bool)reader["IsActive"];
                    Permissions = (int)reader["Permissions"];
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Isfound = false;
                clsEventLog.LogExseptionsToLogerViewr("This is Get User Info By User Name And Password", EventLogEntryType.Error);
            }
            finally
            {
                connection.Close();
            }
            return Isfound;
        }

        public static int AddNewUser(int PersonID, string UserName, string Password, bool IsActive,int Permissions)
        {
            //this function will return the new person id if succeeded and -1 if not.
            int UserID = -1;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);

            string query = @"INSERT INTO Users
                                         (PersonID,UserName,Password,IsActive,Permissions)
                             VALUES
                                         (@PersonID, @UserName,@Password,@IsActive,@Permissions);
                             SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            finally
            {
                connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string UserName, string Password, bool IsActive, int Permissions)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"Update  Users 
                                     set
                                          PersonID = @PersonID,
                                          UserName = @UserName,
                                          Password =@Password, 
                                          IsActive =@IsActive, 
                                          Permissions=@Permissions
                                      where UserID = @UserID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@Permissions", Permissions);

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

        public static bool DeleteUser(int UserID)
        {
            int RowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = "Delete Users Where UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { connection.Close(); }
            return (RowsAffected > 0);
        }

        public static bool IsUserExist(int UserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);

            string query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"select  Found=1 from Users Where PersonID =@PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isfound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }

        public static DataTable GetAllUser()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"Select * from Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
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
            return dt;
        }


        public static bool IsUserExist(string UserName)
        {
            bool isfound = false;
            SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString);
            string query = @"select  Found=1 from Users Where UserName =@UserName";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                isfound = reader.HasRows;

                reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }
            return isfound;
        }
    }
}
