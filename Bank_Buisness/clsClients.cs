using Bank_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Buisness
{
    public class clsClients
    {
        public enum enMode { AddNew =0,Update =1 }

        
        public enMode Mode = enMode.AddNew;

        public int ClientID {  get; set; }
        public int PersonID {  get; set; }
        public string PinCode {  get; set; }
        public string AccountNumber {  get; set; }
        public float AccountBalanc { get; set; }

        public clsPerson PersonInfo;

       
        public clsClients() 
        {
            this.ClientID = -1;
            this.PersonID = -1;
            this.PinCode = "";
            this.AccountNumber = "";
            this.AccountBalanc = 0;
            Mode = enMode.AddNew;
        }

        public clsClients( int clientID, int personID, string pinCode, string accountNumber, float AccountBalanc)
        {
            
            this.ClientID = clientID;
            this.PersonID = personID;
            this.PinCode = pinCode;
            this.AccountNumber = accountNumber;
            this.AccountBalanc = AccountBalanc;
            this.PersonInfo = clsPerson.FindPerson(personID);
           Mode = enMode.Update;
        }

        private bool _AddNewClient()
        {
            this.ClientID = clsClientsData.AddNewClient(this.PersonID, this.PinCode, this.AccountNumber, this.AccountBalanc);
            return (this.ClientID != -1);
        }

        private bool _UpdateClient()
        {
            return clsClientsData.UpdateClient(this.ClientID, this.PersonID, this.PinCode,this.AccountNumber, this.AccountBalanc);
        }

        public static clsClients Find( int clientID )
        {
            int PersonID = -1;
            string PinCode = "", AccountNumber = "";
            float AccountBalanc = 0;

            if(clsClientsData.GetClientInfoByClientID(clientID,ref  PersonID,ref PinCode,ref AccountNumber,ref AccountBalanc))
                return new clsClients(clientID,PersonID,PinCode,AccountNumber,AccountBalanc);
            else 
                return null;
            
        }


        public static clsClients FindForPersonID(int PersonID)
        {
            int ClientID = -1;
            string PinCode = "", AccountNumber = "";
            float AccountBalanc = 0;

            if (clsClientsData.GetClientInfoByPersonID(PersonID, ref ClientID, ref PinCode, ref AccountNumber, ref AccountBalanc))
                return new clsClients(ClientID, PersonID, PinCode, AccountNumber, AccountBalanc);
            else
                return null;

        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewClient())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    { return false; }
                case enMode.Update:
                    return _UpdateClient();
            }
            return false;
        }

        public static bool DeleteClient(int ClientID)
        {
            return clsClientsData.DeleteClient(ClientID);
        }

        public static bool IsExistClient(int ClientID)
        {
            return clsClientsData.IsExistClients(ClientID);
        }

        public static bool IsExistClientForPerson(int PersonID)
        {
            return clsClientsData.IsExistClientForPerson(PersonID);
        }

        public static DataTable GetAllClients()
        {
            return clsClientsData.GetAllClient();   
        }

        public static DataTable GetTotalBalance()
        {
            return clsClientsData.GetTotalBalance();
        }

        public static bool IsExistClientForAccountNumber(string AccountNumber)
        {
            return clsClientsData.IsExistClientForAccountNumber(AccountNumber);
        }

        public static bool ChangeBalance(int ClientID,float AccountBalanc)
        {
            return clsClientsData.ChengeBalance(ClientID, AccountBalanc);
        }

        public bool ChangeBalance()
        {
            return clsClientsData.ChengeBalance(this.ClientID,this.AccountBalanc);
        }

        public  void  Deposit(float Amount)
        {
            AccountBalanc += Amount;
            ChangeBalance(this.ClientID,this.AccountBalanc);
        }

        public bool  WithDraw(float Amount)
        {
            if (Amount < 0)
            {
                return false;
            }
            else
            {
                AccountBalanc -= Amount;
                ChangeBalance(this.ClientID, this.AccountBalanc);
                return true;
            }
        }

      
        
    }
}
