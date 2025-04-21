using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bank_Buisness.ClsTransferLog;

namespace Bank_Buisness
{
    public class clsEmployees
    {
        public enum enMode { AddNew =0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

       public int PersonID { get; set; }    
       public int DepartmentID { get; set; }
        public int EmployeeID { get; set; }

       public string JobTitle {  get; set; }
       public DateTime HireDate {  get; set; }
       public Single Salary {  get; set; }
       public string Notes {  get; set; }

        public clsEmployees()
        {
            this.EmployeeID = -1;
            this.DepartmentID = -1;
            this.PersonID = -1;
            this.JobTitle = "";
            this.HireDate = DateTime.Now;
            this.Salary = 0;
            this.Notes = "";

            _Mode = enMode.AddNew;  
        }

        public clsEmployees(
            int personID, int departmentID, int employeeID, string jobTitle, DateTime hireDate, float salary, string notes)
        {
            

            this.PersonID = personID;
            this.DepartmentID = departmentID;
            this.EmployeeID = employeeID;
            this.JobTitle = jobTitle;
            this.HireDate = hireDate;
            this.Salary = salary;
            this.Notes = notes;

            _Mode = enMode.Update;
        }

        public static clsEmployees GetEmployee(int EmployeeID)
        {
            int PersonID = -1;
            int DepartmentID = -1;
            string JobTitle = "";
            DateTime HireDate = default;
            Single Salary = 0;
            string Notes = "";


            if (clsEmployeeData.GetEmployee(EmployeeID, ref PersonID, ref DepartmentID, ref JobTitle, ref HireDate, ref Salary, ref Notes))
                return new clsEmployees(EmployeeID, PersonID, DepartmentID, JobTitle, HireDate, Salary, Notes);

            return null;
        }
        private bool _AddNewEmployee()
        {
            EmployeeID = clsEmployeeData.AddNewEmployee(PersonID, DepartmentID, JobTitle, HireDate, Salary, Notes);

            return EmployeeID != -1;
        }

        private bool _UpdateEmployee()
        {
            return clsEmployeeData.UpdateEmployee(EmployeeID, PersonID, DepartmentID, JobTitle, HireDate, Salary, Notes);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewEmployee())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateEmployee();


            }

            return false;
        }

        public static bool DeleteEmployee(int EmployeeID)
        {
            return clsEmployeeData.DeleteEmployee(EmployeeID);
        }

        public static DataTable GetEmployees()
        {
            return clsEmployeeData.GetEmployees();
        }

        public static DataTable GetEmployeesByEmployeeID(int EmployeeID)
        {
            return clsEmployeeData.GetEmployeesByEmployeeID(EmployeeID);
        }

        public static bool IsEmployeeExistByEmployeeID(int EmployeeID)
        {
            return clsEmployeeData.IsEmployeeExistByEmployeeID(EmployeeID);
        }


    }
}
