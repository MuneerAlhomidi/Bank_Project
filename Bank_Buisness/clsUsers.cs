using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Bank_Buisness
{
    public class clsUsers
    {
        public enum enMode { AddNew =0, Update = 1 }
        private enMode _Mode;

        public enum enPermissions { eAll = -1, eClients = 1, eUsers = 2, ePeople = 4, eTransations = 8, eEmployees = 16, eUpdateUser = 32, eUpdateClient = 64, eUpdatePeople = 128,eUpdateEmploeeys = 256 }

        public int UserID { get; set; }
        public int PersonID {  get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public bool IsActive {  get; set; }
        public int Permissions {  get; set; }

        public clsPerson SelectPersonInfo;

        public clsUsers()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = false;
            this.Permissions = -1;
            _Mode = enMode.AddNew;
        }

        public clsUsers( int userID, int personID, string userName, string password, bool isActive, int permissions)
        {
           
            this.UserID = userID;
            this.PersonID = personID;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = isActive;
            this.Permissions = permissions;
            this.SelectPersonInfo = clsPerson.FindPerson(personID);

            _Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            this.Password = clsHashing.ComputeHash(this.Password);
            this.UserID = clsUsersData.AddNewUser(this.PersonID, this.UserName, this.Password, this.IsActive,this.Permissions );
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            this.Password = clsHashing.ComputeHash(this.Password);
            return clsUsersData.UpdateUser(this.UserID,this.PersonID,this.UserName,this.Password,this.IsActive,this.Permissions);
        }

        public static clsUsers Find(int userID)
        {
            int PersonID = -1, Permissions = -1;
            string UserName = "" , Password = "";
            bool IsActive = false;

            if (clsUsersData.GetUserInfoByID(userID,ref PersonID, ref UserName, ref Password, ref IsActive, ref Permissions))
                return new  clsUsers(userID,PersonID ,UserName, Password, IsActive, Permissions);
            else
                return null;
        }

        public static clsUsers FindUserByPersonID(int PersonID)
        {
            int UserID = -1, Permissions = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            if (clsUsersData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive, ref Permissions))
                return new clsUsers(UserID, PersonID, UserName, Password, IsActive, Permissions);
            else
                return null;
        }

        public static clsUsers FindUserByUserNameAndPassword(string UserName, string Password)
        {
            int PersonID = -1;
            int UserID = -1;
            bool IsActive = false;
            int Permissions = -1;
            
            if(clsUsersData.GetUserInfoByUserNameAndPassword(UserName,Password,ref UserID, ref PersonID ,ref IsActive,ref Permissions))
                return new clsUsers(UserID,PersonID,UserName,Password,IsActive,Permissions);
            else
                return null;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUsersData.DeleteUser(UserID);
        }

        public static DataTable GetAllUser()
        {
            return clsUsersData.GetAllUser();
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        
                        return false;
                    }
                    case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static bool IsExistUser(int UserID)
        {
            return clsUsersData.IsUserExist(UserID);
        }

        public static bool IsExistUser(string UserName)
        {
            return clsUsersData.IsUserExist(UserName);
        }

        public static bool IsExistUserByPeronID(int PeronID)
        {
            return clsUsersData.IsUserExistByPersonID(PeronID);
        }

        

        public bool CheckAccessPermission(clsUsers.enPermissions permissions)
        {
            if (this.Permissions == (int)enPermissions.eAll)
            {
                return true;
            }

            return ((int)permissions & this.Permissions) == (int)permissions;

       
        }

       
    }
}
