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
    public class clsCurrence
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private  enMode _Mode = enMode.AddNew;

        public int CurrenceID { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public float Rate {  get; set; }

        public clsCurrence()
        {
            this.CurrenceID = -1;
            this.Country = "";
            this.Code = "";
            this.Name = "";
            this.Rate = 0;

            _Mode = enMode.AddNew;
        }

        public clsCurrence( int currenceID, string country, string code, string name, float rate)
        {
          
            this.CurrenceID = currenceID;
            this.Country = country;
            this.Code = code;
            this.Name = name;
            this.Rate = rate;

            _Mode= enMode.Update;
        }

        public static clsCurrence Find(int currenceID)
        {
            string Country ="";
            string Code = "", Name = "";
            float Rate = 0;
            if(clsCurrenciesData.GetCurrenceByID(currenceID,ref Country,ref Code,ref Name,ref Rate))
                return new clsCurrence(currenceID,Country,Code,Name,Rate);
            else
                return null;
        }

        private bool _AddNewCurrence()
        {
            this.CurrenceID = clsCurrenciesData.AddNewCurrence(this.Country, this.Code, this.Name, this.Rate);
            return (this.CurrenceID != -1);

        }

        private bool _UpdateCurrence()
        {
            return clsCurrenciesData.UpdateCurrnce(this.CurrenceID, this.Country, this.Code,this.Name, this.Rate);
        }

        public static DataTable AllCurrence()
        {
            return clsCurrenciesData.AllCurrncies();
        }

        public bool save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCurrence())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdateCurrence();
            }
            return false;
        }
    }
}
