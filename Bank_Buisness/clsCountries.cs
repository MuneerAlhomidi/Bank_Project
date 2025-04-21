using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Buisness
{
    public class clsCountry
    {
        public int CountryID {  get; set; }
        public string CountryName { get; set; }

        clsCountry() 
        {
           this. CountryID = -1;
           this. CountryName = "";
        }

        clsCountry(int CountryID,string CountryName)
        {
            this.CountryID = CountryID;
            this. CountryName = CountryName;

        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            bool isfound = clsCountryData.GetCountryInfoByName(CountryName, ref CountryID);
            if (isfound)
                return new clsCountry(CountryID, CountryName);
            return null;
            
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";
            bool isfound = clsCountryData.GetCountryInfoByID(CountryID, ref CountryName);
            if (isfound)
                return new clsCountry(CountryID, CountryName);
            return null;

        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountries();
        }
    }
}
