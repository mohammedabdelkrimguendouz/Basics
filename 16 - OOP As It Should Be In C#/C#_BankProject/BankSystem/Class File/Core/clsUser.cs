using classLibraryUtil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace BankSystem
{
    public class clsUser : clsPerson
    {
        public enum enMode { UpdateMode = 1, AddNewMode = 2 };
        public enum enMainMenueParmissions
        {
            pAll = -1, pListClintes = 1, pAddNewClient = 2, pDeleteClient = 4,
            pUpdateClient = 8, pFindClient = 16, pShowTransactionsMenue = 32, pManageUsers = 64,pLogInRegister=128
        };

        public class clsLogInRegister
        {
            
            public string DateTime {  get; set; }
            public string UserName {  get; set; }
            public string Password {  get; set; }
            public int Permissions {  get; set; }
            public clsLogInRegister(string DateTime, string UserName, string Password, int Permissions)
            {
                this.DateTime = DateTime;
                this.UserName = UserName;
                this.Password = Password;
                this.Permissions = Permissions;
            }
        }

        private enMode _Mode;
        private bool _MarkedForDelete = false;
        public bool MarkedForDelete()
        {
            return _MarkedForDelete;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }

        static private string _PathFileUsers = "C:\\Users\\KarimPc\\Desktop\\C#_BankProject\\BankSystem\\Users.txt";
        static private string _PathFileLoginRegister = "C:\\Users\\KarimPc\\Desktop\\C#_BankProject\\BankSystem\\LoginRegister.txt";
        

        public clsUser(clsUser.enMode Mode, string FirstName, string LastName, string Email, string Phone,
            string UserName, string Password, int Permissions) : base(FirstName, LastName, Email, Phone)
        {
            _Mode = Mode;
            this.UserName = UserName;
            this.Password = Password;
            this.Permissions = Permissions;
        }
        private static clsUser _ConvertLineToUserObject(string Line, string Separator = "#//#")
        {
            string[] Separators = new string[] { Separator };
            string[] arrUser = Line.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

            clsUser User = new clsUser(enMode.UpdateMode, arrUser[0], arrUser[1], arrUser[2], arrUser[3],
                  arrUser[4],clsUtil.DecryptText(arrUser[5]), Convert.ToInt32(arrUser[6]));
            return User;
        }

        private static string _ConvertUserObjectToLine(clsUser User, string Separator = "#//#")
        {
            string LineUser = "";
            LineUser += User.FirstName + Separator;
            LineUser += User.LastName + Separator;
            LineUser += User.Email + Separator;
            LineUser += User.Phone + Separator;
            LineUser += User.UserName + Separator;
            LineUser += clsUtil.EncryptText(User.Password) + Separator;
            LineUser += User.Permissions;
            return LineUser;
        }

        static private clsLogInRegister _ConvertLineToLogInRegisterRecord(string Line, string Separator = "#//#")
        {
            
            string[] Separators = new string[] { Separator };
            string[] arrRecordRegister = Line.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

            clsLogInRegister LogInRegisterRecord = new clsLogInRegister(arrRecordRegister[0], arrRecordRegister[1], arrRecordRegister[2], Convert.ToInt32(arrRecordRegister[3]));
            return LogInRegisterRecord;
        }

        private static List<clsUser> _LoadUsersDataFromFile()
        {
            List<clsUser> _ListUsers = new List<clsUser>();
            if (File.Exists(_PathFileUsers))
            {
                StreamReader MyFile = new StreamReader(_PathFileUsers);
                string Line;

                while ((Line = MyFile.ReadLine()) != null)
                {
                    clsUser User = _ConvertLineToUserObject(Line);
                    _ListUsers.Add(User);
                }
                MyFile.Close();
            }
            return _ListUsers;
        }

        private static void _SaveUsersDataToFile(List<clsUser> Users)
        {
            if (File.Exists(_PathFileUsers))
            {
                StreamWriter MyFile = new StreamWriter(_PathFileUsers);
                string DataLine;
                foreach (clsUser User in Users)
                {
                    if (User.MarkedForDelete() == false)
                    {
                        DataLine = _ConvertUserObjectToLine(User);
                        MyFile.WriteLine(DataLine);
                    }

                }
                MyFile.Close();
            }
        }

        private void _Update()
        {
            List<clsUser> _ListUsers = _LoadUsersDataFromFile();

            for (int i = 0; i < _ListUsers.Count; i++)
            {
                if (_ListUsers[i].UserName == UserName)
                {
                    _ListUsers[i] = this;
                    break;
                }
            }
            _SaveUsersDataToFile(_ListUsers);
        }

        private string _PrepareLogInRegisterRecord(string Separtore="#//#" )
        {
            string LogInRegisterRecord = "";
            LogInRegisterRecord += DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss")  + Separtore;
            LogInRegisterRecord += Global.CurrentUser.UserName + Separtore;
            LogInRegisterRecord += Global.CurrentUser.Password + Separtore;
            LogInRegisterRecord += Global.CurrentUser.Permissions ;

            return LogInRegisterRecord;
        }

        


        private void _AddDataLineToFile(string DataLine)
        {
            if (File.Exists(_PathFileUsers))
            {
                StreamWriter MyFile = new StreamWriter(_PathFileUsers, true);
                MyFile.WriteLine(DataLine);
                MyFile.Close();
            }

        }
        private void _AddNew()
        {
            _AddDataLineToFile(_ConvertUserObjectToLine(this));
        }

        public static clsUser Find(string UserName)
        {
            if (File.Exists(_PathFileUsers))
            {
                StreamReader MyFile = new StreamReader(_PathFileUsers);
                string Line;
                while ((Line = MyFile.ReadLine()) != null)
                {
                    clsUser User = _ConvertLineToUserObject(Line);
                    if (User.UserName == UserName)
                    {

                        MyFile.Close();
                        return User;
                    }
                }
                MyFile.Close();
            }

            return null;
        }

        public static clsUser Find(string UserName, string Password)
        {
            if (File.Exists(_PathFileUsers))
            {
                StreamReader MyFile = new StreamReader(_PathFileUsers);
                string Line;
                while ((Line = MyFile.ReadLine()) != null)
                {
                    clsUser User = _ConvertLineToUserObject(Line);
                    if (User.UserName == UserName && User.Password == Password)
                    {
                        MyFile.Close();
                        return User;
                    }
                }
                MyFile.Close();
            }
            return null;
        }

        public void Print()
        {
            Console.WriteLine("\nUser Card : ");
            Console.WriteLine("_______________________________________\n");
            Console.WriteLine($"First Name      : {FirstName}");
            Console.WriteLine($"Last Name       : {LastName}");
            Console.WriteLine($"Full Name       : {FullName}");
            Console.WriteLine($"Email           : {Email}");
            Console.WriteLine($"Phone           : {Phone}");
            Console.WriteLine($"User Name       : {UserName}");
            Console.WriteLine($"Password        : {Password}");
            Console.WriteLine($"Permission      : {Permissions}");
            Console.WriteLine("_______________________________________\n");
        }

        public bool Delete()
        {
            List<clsUser> _ListUsers = _LoadUsersDataFromFile();

            for (int i = 0; i < _ListUsers.Count; i++)
            {
                if (_ListUsers[i].UserName == UserName)
                {
                    _ListUsers[i]._MarkedForDelete = true;
                    break;
                }
            }
            _SaveUsersDataToFile(_ListUsers);
            return true;
        }
        public static bool IsUserExist(string UserName)
        {
            return !(Find(UserName) == null);
        }

        public enum enSaveResult { svSucceeded = 1, svFaild = 2 }
        public enSaveResult Save()
        {
            switch (_Mode)
            {
                case enMode.UpdateMode:
                    _Update();
                    return enSaveResult.svSucceeded;
                case enMode.AddNewMode:
                    _AddNew();
                    _Mode = enMode.UpdateMode;
                    return enSaveResult.svSucceeded;
            }
            return enSaveResult.svFaild;
        }
        public static List<clsUser> GetUsersList()
        {
            return _LoadUsersDataFromFile();
        }
        public static clsUser GetAddNewUserObject(string UserName)
        {
            clsUser NewClient = new clsUser(enMode.AddNewMode, "", "", "", "", UserName, "", 0);
            return NewClient;


        }

        public bool CheckAccessPermission(enMainMenueParmissions Permissions)
        {
            if (this.Permissions == (int)enMainMenueParmissions.pAll)
                return true;
            if ((this.Permissions & (int)Permissions) == (int)Permissions)
                return true;
            return false;
        }
        
        public void RegisterLogIn()
        {
            if (File.Exists(_PathFileLoginRegister))
            {
                StreamWriter MyFile = new StreamWriter(_PathFileLoginRegister, true);
                MyFile.WriteLine(_PrepareLogInRegisterRecord());
                MyFile.Close();
            }
        }

        
        static public List<clsLogInRegister> GetLogInRegisterList()
        {
            List<clsLogInRegister> _ListLogInRegister = new List<clsLogInRegister>();
            if (File.Exists(_PathFileLoginRegister))
            {
                StreamReader MyFile = new StreamReader(_PathFileLoginRegister);
                string Line;

                while ((Line = MyFile.ReadLine()) != null)
                {
                    clsLogInRegister RecordLogInRegister= _ConvertLineToLogInRegisterRecord(Line);
                   _ListLogInRegister.Add(RecordLogInRegister);
                }
                MyFile.Close();
            }
            return _ListLogInRegister;
        }
    }
}