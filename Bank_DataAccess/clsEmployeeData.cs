using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_DataAccess
{
    public class clsEmployeeData
    {
        public static bool GetEmployee(int EmployeeID, ref int PersonID, ref int DepartmentID, ref string JobTitle, ref DateTime HireDate, ref Single Salary, ref string Notes)
        {
            SqlConnection Connection = new SqlConnection(clsDataSettingAccess.ConnactionString);

            string query = @"Select * from Employees where EmployeeID = @EmployeeID;";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            bool IsFound = false;
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    IsFound = true;
                    PersonID = (int)Reader["PersonID"];
                    DepartmentID = (int)Reader["DepartmentID"];
                    JobTitle = (string)Reader["JobTitle"];
                    HireDate = (DateTime)Reader["HireDate"];
                    Salary = (Single)Reader["Salary"];
                    if (Reader["Notes"] != DBNull.Value)
                        Notes = (string)Reader["Notes"];

                }
                Reader.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static int AddNewEmployee(int PersonID, int DepartmentID, string JobTitle, DateTime HireDate, Single Salary, string Notes)
        {
            SqlConnection Connection = new SqlConnection(clsDataSettingAccess.ConnactionString);

            string query = @"Insert into Employees (PersonID,DepartmentID,JobTitle,HireDate,Salary,Notes) 
Values (@PersonID,@DepartmentID,@JobTitle,@HireDate,@Salary,@Notes); 
SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            Command.Parameters.AddWithValue("@JobTitle", JobTitle);
            Command.Parameters.AddWithValue("@HireDate", HireDate);
            Command.Parameters.AddWithValue("@Salary", Salary);
            if (string.IsNullOrWhiteSpace(Notes))
            {
                Command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@Notes", Notes);
            }


            int EmployeeID = -1;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int ID))
                {
                    EmployeeID = ID;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                Connection.Close();
            }

            return EmployeeID;
        }

        public static bool UpdateEmployee(int EmployeeID, int PersonID, int DepartmentID, string JobTitle, DateTime HireDate, Single Salary, string Notes)
        {
            SqlConnection Connection = new SqlConnection(clsDataSettingAccess.ConnactionString);

            string query = @"Update Employees Set 
PersonID = @PersonID,
DepartmentID = @DepartmentID,
JobTitle = @JobTitle,
HireDate = @HireDate,
Salary = @Salary,
Notes = @Notes
where EmployeeID = @EmployeeID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            Command.Parameters.AddWithValue("@PersonID", PersonID);
            Command.Parameters.AddWithValue("@DepartmentID", DepartmentID);
            Command.Parameters.AddWithValue("@JobTitle", JobTitle);
            Command.Parameters.AddWithValue("@HireDate", HireDate);
            Command.Parameters.AddWithValue("@Salary", Salary);
            if (string.IsNullOrWhiteSpace(Notes))
            {
                Command.Parameters.AddWithValue("@Notes", DBNull.Value);
            }
            else
            {
                Command.Parameters.AddWithValue("@Notes", Notes);
            }


            int RowAffected = 0;
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return RowAffected > 0;
        }

        public static bool DeleteEmployee(int EmployeeID)
        {
            SqlConnection Connection = new SqlConnection(clsDataSettingAccess.ConnactionString);

            string query = @"DELETE FROM Employees
                                      WHERE EmployeeID = @EmployeeID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            int RowAffected = 0;
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }

            return RowAffected > 0;
        }

        public static DataTable GetEmployees()
        {
            SqlConnection Connection = new SqlConnection(clsDataSettingAccess.ConnactionString);

            string query = @"Select * FROM Employees";

            SqlCommand Command = new SqlCommand(query, Connection);

            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dataTable.Load(Reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return dataTable;
        }

        public static DataTable GetEmployeesByEmployeeID(int EmployeeID)
        {
            SqlConnection Connection = new SqlConnection(clsDataSettingAccess.ConnactionString);

            string query = @"Select * FROM Employees Where EmployeeID = @EmployeeID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            DataTable dataTable = new DataTable();
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dataTable.Load(Reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Connection.Close();
            }


            return dataTable;
        }

        public static bool IsEmployeeExistByEmployeeID(int EmployeeID)
        {
            SqlConnection Connection = new SqlConnection(clsDataSettingAccess.ConnactionString);

            string query = @"Select IsFound = 1 from Employees where EmployeeID = @EmployeeID;";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            bool IsFound = false;
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();

                if (Result != null)
                {
                    IsFound = true;
                }

            }
            catch (Exception ex)
            {
                //
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }


    }
}
