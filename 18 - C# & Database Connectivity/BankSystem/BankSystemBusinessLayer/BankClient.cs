using BankSystemDataAccessLayer;
using System;
using System.Data;


namespace BankSystemBusinessLayer
{
    public class clsBankClient:clsPerson
    {
        public enum enMode { Update, AddNew };
        private enMode _Mode ;
        public string AccountNumber {  get; set; }
        public string PinCode { get; set; }
        public double AccountBalance {  get; set; }
       
        
        public clsBankClient()
        {
            AccountNumber = "";AccountBalance = 0.0;PinCode = "";
            FirstName = "";LastName = "";Email = " "; Phone = ""; Address = "";
            ImagePath = ""; CountryID = -1; ID = -1; DateOfBirth = DateTime.Now;
            _Mode = enMode.AddNew;
        }

        private clsBankClient(int ID, string FirstName, string LastName,
            string Email, string Phone, string Address, DateTime DateOfBirth, int CountryID,
            string ImagePath, string accountNumber, string pinCode,
            double accountBalance)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email; this.Phone = Phone;
            this.Address = Address; this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;
            AccountNumber = accountNumber;
            PinCode = pinCode;
            AccountBalance = accountBalance;
        }

        public static clsBankClient Find(int ID)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now; string AccountNumber = "", PinCode = ""; double AccountBalance = 0.0;
            int CountryID = -1;

            if (clsBankClientDataAccess.GetClientInfoByID(ID, ref FirstName, ref LastName,
                          ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath, ref CountryID,
                         ref AccountNumber, ref PinCode, ref AccountBalance))

                return new clsBankClient(ID, FirstName, LastName,
                           Email, Phone, Address, DateOfBirth, CountryID, ImagePath, AccountNumber, PinCode, AccountBalance);
            else
                return null;
        }

        public static clsBankClient Find(string AccountNumber)
        {
            string FirstName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now; string PinCode = ""; double AccountBalance = 0.0;
            int CountryID = -1, ID = -1;

            if (clsBankClientDataAccess.GetClientInfoByAccountNumber(ref ID, ref FirstName, ref LastName,
                          ref Email, ref Phone, ref Address, ref DateOfBirth, ref ImagePath, ref CountryID,
                          AccountNumber, ref PinCode, ref AccountBalance))

                return new clsBankClient(ID, FirstName, LastName,
                           Email, Phone, Address, DateOfBirth, CountryID, ImagePath, AccountNumber, PinCode, AccountBalance);
            else
                return null;
        }


        private bool _AddNewClient()
        {
            this.ID = clsBankClientDataAccess.AddNewClient(this.FirstName, this.LastName, this.Email, this.Phone, this.Address,
                this.ImagePath, this.CountryID, this.DateOfBirth,this.AccountNumber,this.PinCode,this.AccountBalance);
            return (this.ID != -1);
        }

        private bool _UpdateClient()
        {
            return clsBankClientDataAccess.UpdateClient(ID, FirstName, LastName, Email, Phone, Address,
                ImagePath, CountryID, DateOfBirth,AccountNumber, PinCode, AccountBalance);
        }

        static public DataTable ListClients()
        {
            return clsBankClientDataAccess.ListClients();
        }
        static public bool DeleteClient(int ID)
        {
            return clsBankClientDataAccess.DeleteClient(ID);
        }
        
        public static bool IsClientExist(int ID)
        {
            return clsBankClientDataAccess.IsClientExistByID(ID);
        }
        public static bool IsClientExist(string AccountNumber)
        {
            return clsBankClientDataAccess.IsClientExistByAccountNumber(AccountNumber);
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewClient())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateClient();
                    
            }
            return false;
        }

        private bool _SaveNewBalance()
        {
            return clsBankClientDataAccess.SaveNewBalance(this.ID, this.AccountBalance);
        }

        public bool Deposite(double Amount)
        {
            this.AccountBalance += Amount;
            return _SaveNewBalance();
        }
        public bool Witdraw(double Amount)
        {
            if(Amount<=this.AccountBalance)
            {
                this.AccountBalance -= Amount;
                return _SaveNewBalance();
            }
            return false;
            
        }
        
        static public void DeleteAllClients()
        {
            clsBankClientDataAccess.DeleteAllClient();
        }
        static public DataTable FindClientByAccountNumber(string AccountNumber)
        {
            return clsBankClientDataAccess.FindClientByAccountNumber(AccountNumber);
        }
    }
}
