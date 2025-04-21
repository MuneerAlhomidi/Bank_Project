using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Buisness
{
    public class ClsTransferLog
    {
        public enum Mode { AddNew = 0, Update = 1 }
        public Mode _Mode = Mode.AddNew;

     
        public DateTime dateTime { get; set; }
        public string SourceAccount {  get; set; }
        public string DestinationAccount { get; set; }
        public float Amount {  get; set; }
        public float SourceBalance { get; set; }
        public float DestinationBalance {  get; set; }
        public string UserName {  get; set; }

        public clsClients _Client;

        public ClsTransferLog ()
        {
           
            this .dateTime = DateTime.Now;
            this.SourceAccount = "";
            this.DestinationAccount = "";
            this.Amount = 0;
            this.SourceBalance = 0;
            this.DestinationBalance =0;
            this.UserName = "";

            _Mode = Mode.AddNew;
        }

        public ClsTransferLog(DateTime dateTime, string SourceAccount, string DestinationAccount, 
                              float Amount ,float SourceBalance, float DestinationBalance, string UserName)
        {
           
            this.dateTime = dateTime;
            this.SourceAccount=SourceAccount;
            this.DestinationAccount=DestinationAccount;
            this.Amount = Amount;
            this.SourceBalance = SourceBalance;
            this.DestinationBalance = DestinationBalance;
            this.UserName = UserName;

            _Mode = Mode.Update;

        }

        private bool _AddNew()
        {
            return clsTransferLogData.AddNew(this.dateTime, this.SourceAccount, this.DestinationAccount, this.Amount, this.SourceBalance, this.DestinationBalance, this.UserName);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case Mode.AddNew:
                    if (_AddNew())
                    {
                        return true;

                    }
                    else
                        return false;
            }
            return false;
        }

        public static DataTable GetAllTransferLog()
        {
            return clsTransferLogData.GetAllTransferLog();
        }
    }
}
