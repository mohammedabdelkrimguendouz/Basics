using BankSystemDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Permissions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemBusinessLayer
{
    public class clsUser
    {
        public enum enMode { Update, AddNew };
        private enMode _Mode;

        public int ID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public class clsLogInRegister
        {
            public int LogInID { get; set; }
            public DateTime DateLogIn { get; set; }

            public clsLogInRegister()
            {
                LogInID = -1;
                DateLogIn = DateTime.Now;
            }
             public bool SaveLogInRegister(int UserID)
             {
               LogInID= clsUserDataAccess.SaveLogInRegister(UserID, DateLogIn);
                return (LogInID != -1);
             }
             static public DataTable ListLogInRegisters()
            {
                return clsUserDataAccess.ListLogInRegisters();
            }
            static public void DeleteAllListLogInRegisters()
            {
                 clsUserDataAccess.DeleteAllRegistersLogIn();
            }



        }


        public clsUser()
        {
            UserName = ""; Password = "";
            ID = -1;
            _Mode = enMode.AddNew;
        }

        private clsUser(int ID,  string UserName, string Password)
        {
            this.ID = ID;
            _Mode = enMode.Update;
            this.UserName = UserName;
            this.Password = Password;
        }

        public static clsUser Find(int ID)
        {
            string UserName = "", Password="";
            if (clsUserDataAccess.GetUserInfoByID(ID,ref UserName,ref Password ))

                return new clsUser(ID,UserName,Password );
            else
                return null;
        }

        public static clsUser Find(string UserName,string Password)
        {
            int ID = -1;
            if (clsUserDataAccess.GetUserInfoByUserNameAndPassword(ref ID,  UserName, Password))
                return new clsUser(ID, UserName, Password);
            else
                return null;
        }


        private bool _AddNewUser()
        {
            this.ID =clsUserDataAccess.AddNewUser( this.UserName, this.Password);
            return (this.ID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserDataAccess.UpdateUser(ID, this.UserName, this.Password);
        }

        static public DataTable ListUsers()
        {
            return clsUserDataAccess.ListUsers() ;
        }
        
        static public bool DeleteUser(int ID)
        {
            return clsUserDataAccess.DeleteUser(ID);
        }

        public static bool IsUserExist(string UserName)
        {
            return clsUserDataAccess.IsUserExistByUserName(UserName);
        }
        public static bool IsUserExist(string UserName,string Password)
        {
            return clsUserDataAccess.IsUserExistByUserNameAndPassword(UserName,Password);
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

        public bool LogIn()
        {
            clsLogInRegister LogInRegister = new clsLogInRegister();
            return LogInRegister.SaveLogInRegister(ID);
            
        }
        static public DataTable GetListRigestersForUser(string UserName)
        {
            return clsUserDataAccess.GetListRigestersForUser(UserName);
        }
        static public DataTable FindUserByUserName(string UserName)
        {
            return clsUserDataAccess.FindUserByUserName(UserName);
        }
        static public DataTable GetListLogInByDate(DateTime Date)
        {
            return clsUserDataAccess.GetListLogInByDate(Date);
        }
    }
}
