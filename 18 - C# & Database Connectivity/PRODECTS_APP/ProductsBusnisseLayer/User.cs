using ProductsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsBusnisseLayer
{
    public class clsUser
    {
        public enum enParmissions
        {
            pAll = -1, pCreateBackup = 1, pRestoreBackup = 2, pAddNewProduct = 4, pProductManagement = 8,
            pAddNewCategory=16, pCategoriesManagement = 32, pAddNewCustomer = 64, pCustomerManagement = 128,
            pAddNewSale=256,pSalesManagement=512,pAddNewUser=1024,pUsersManagement=2048
        };

        public enum enMode { AddNew, Update };
        private enMode _Mode;
        public int UserID {  get; set; }
        public int Permissions {  get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public clsUser()
        {
            UserName = string.Empty;
            Password = string.Empty;
            UserID = -1;
            Permissions = 0;
            _Mode = enMode.AddNew;
        }
        private clsUser(int UserID,string UserName, string Password,int Permissions)
        {
            this.UserID = UserID;
            this.Permissions = Permissions;
            this.UserName = UserName;
            this.Password = Password;
            _Mode = enMode.Update;
        }
        static public bool IsUserExist(string UserName, string Password)
        {
            return clsUserDataAccess.IsUserExist(UserName, Password);

        }
        static public bool IsUserExist(string UserName)
        {
            return clsUserDataAccess.IsUserExist(UserName);
        }

        public bool SaveLogIn()
        {
            return clsUserDataAccess.SaveLogIn(this.UserID, DateTime.Now);
        }

        static public clsUser Find(int UserID)
        {
            int Permissions = 0;string UserName = "", Password = "";
            if (clsUserDataAccess.Find(UserID, ref UserName, ref Password, ref Permissions))
            {
                return new clsUser(UserID, UserName, Password, Permissions);
            }
            else
                return null;
        }
        static public clsUser Find(string UserName)
        {
            int Permissions = 0, UserID = -1;string Password = "";
            if (clsUserDataAccess.Find(ref UserID,  UserName, ref Password, ref Permissions))
            {
                return new clsUser(UserID, UserName, Password, Permissions);
            }
            else
                return null;
        }
        static public clsUser Find(string UserName,string Password)
        {
            int Permissions = 0; int UserID = -1;
            if (clsUserDataAccess.Find(ref UserID,  UserName,  Password, ref Permissions))
            {
                return new clsUser(UserID, UserName, Password, Permissions);
            }
            else
                return null;
        }

        public bool CheckAccessPermission(enParmissions Permission)
        {
            if (this.Permissions == (int)enParmissions.pAll) return true;
            if (((int)Permission & this.Permissions) == (int)Permission) return true;
            return false;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.UserName, this.Password, this.Permissions);
            return (this.UserID != -1);
        }

        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.UserName, this.Password, this.Permissions);
        }

        public static DataTable ListUsers()
        {
            return clsUserDataAccess.ListUsers();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateUser();
            }
            return false;
        }

        public static DataTable ListLogInRegisters()
        {
            return clsUserDataAccess.ListLogInRegisters();
        }


        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }
        public static bool DeleteUser(string UserName)
        {
            return clsUserDataAccess.DeleteUser(UserName);
        }
        public static bool DeleteAllLogInRegister()
        {
            return clsUserDataAccess.DeleteAllLogInRegister();
        }

        public static bool DeleteLogInRegister(int LogInRegisterID)
        {
            return clsUserDataAccess.DeleteLogInRegister(LogInRegisterID);
        }

        public static DataTable SearchUser(int UserID)
        {
            return clsUserDataAccess.SearchUser(UserID);
        }
        public static DataTable SearchUser(string UserName)
        {
            return clsUserDataAccess.SearchUser(UserName);
        }
        public static DataTable SearchLogInRegisterForUser(string UserName)
        {
            return clsUserDataAccess.SearchLogInRegisterForUser(UserName);
        }

    }
}
