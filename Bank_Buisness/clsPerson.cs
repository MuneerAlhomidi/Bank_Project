using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Buisness
{
    public class clsPerson
    {
        public enum enMode { AddNwe = 0, Update = 1 }
        private enMode _Mode = enMode.AddNwe;

        public int PersonID {  get; set; }
        
        public string FirstName { get; set; }
        public string SecondName {  get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string NationalNo { get; set; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public DateTime DateOfBirth { get; set; }
        public short Gendor {  get; set; }
        public string Address {  get; set; }
        public string Phone {  get; set; }
        public string Email {  get; set; }
        public int NationalityCountryID {  get; set; }
        public clsCountry countriesInfo;
        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public clsPerson() 
        {
            this.PersonID = -1;
           
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.NationalNo = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.NationalityCountryID = -1;
            this.ImagePath = "";

            _Mode = enMode.AddNwe;
        }

        private clsPerson( int personID,string firstName, string secondName, string thirdName,
            string lastName, string NationalNo, DateTime dateOfBirth, short gendor, string address, string phone, string email,
            int nationalityCountryID,  string imagePath)
        {
          
            this. PersonID = personID;
           
            this. FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = dateOfBirth;
            this.Gendor = gendor;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.NationalityCountryID = nationalityCountryID;
            this.countriesInfo = clsCountry.Find(nationalityCountryID);
            this.ImagePath = imagePath;

            _Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(
                this.FirstName,this. SecondName,this.ThirdName, 
                this.LastName, this.NationalNo, this.Gendor,this.DateOfBirth,this.Address,this.Phone,
                this.Email,this.NationalityCountryID,this.ImagePath);
            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(
                this.PersonID,  this.FirstName, this.SecondName,
                this.ThirdName,  this.LastName, this.NationalNo, this.Gendor, this.DateOfBirth, 
                this.Address, this.Phone,this.Email, 
                this.NationalityCountryID, this.ImagePath);
        }

        public static clsPerson FindPerson(int PersonID)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "";
            string NationalNo = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gendor = 0;
            string Address = "", Phone = "", Email = "", ImagePath = "";
            int NationalityCountryID = -1;

            bool Isfound = clsPersonData.GetPersonInfoByID( PersonID, ref  FirstName, ref  SecondName, ref  ThirdName,
            ref  LastName, ref NationalNo, ref  Gendor, ref  DateOfBirth, ref  Address, ref  Phone,
            ref  Email, ref NationalityCountryID, ref  ImagePath); 
                if(Isfound)
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth,Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
           else return null;
                                             
        }

        public static clsPerson FindPerson(string NationalNo)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "";
            int PersonID = -1;
            DateTime DateOfBirth = DateTime.Now;
            short Gendor = 0;
            string Address = "", Phone = "", Email = "", ImagePath = "";
            int NationalityCountryID = -1;

            bool Isfound = clsPersonData.GetPersonInfoByNationalNo(NationalNo, ref PersonID , ref FirstName, ref SecondName, ref ThirdName,
            ref LastName, ref Gendor, ref DateOfBirth, ref Address, ref Phone,
            ref Email, ref NationalityCountryID, ref ImagePath);
            if (Isfound)
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor, Address, Phone, Email, NationalityCountryID, ImagePath);
            else return null;

        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNwe:
                    if(_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    { return false; }
                case enMode.Update:
                    return _UpdatePerson();
            }
            return true;
        }

        public static DataTable GetAllPerson()
        {
            return clsPersonData.GetAllPerson();
        }

        public static bool Delete(int PersonID)
        {
           return clsPersonData.DeletePerson(PersonID);
        }

        public static bool IsExistPerson(int PersonID)
        {
            return clsPersonData.IsPersonExist(PersonID);
        }

        public static bool IsExistPerson(string NationalNo)
        {
            return clsPersonData.IsPersonExist(NationalNo);
        }
    }
}
