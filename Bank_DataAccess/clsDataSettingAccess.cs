using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Bank_DataAccess
{
    public class clsDataSettingAccess
    {
        // public static string ConnactionString = "Server=.;Database=BankDB; User Id= sa;Password=sa123456;";

        public static string ConnactionString = ConfigurationManager.ConnectionStrings["MyDbConnaction"].ConnectionString;
    }
}
