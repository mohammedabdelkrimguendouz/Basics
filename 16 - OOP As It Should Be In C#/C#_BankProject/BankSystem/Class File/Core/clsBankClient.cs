using System;
using System.IO;
using System.Collections.Generic;
using BankSystem;
using static BankSystem.clsUser;
using classLibraryUtil;

public class clsBankClient :clsPerson
{
    public enum enMode {UpdateMode=1,AddNewMode=2};
    private enMode _Mode;
    private bool _MarkedForDelete = false;
    public bool MarkedForDelete()
    {
        return _MarkedForDelete;
    }

    public class clsTransferLogRegister
    {
        public string DateTime { set; get; }
        public string AccountNumberSource { set; get; }
        public string AccountNumberDestin { set; get; }
        public double AmountTransfer { set; get; }
        public double BalanceSource { set; get; }
        public double BalanceDestin { set; get; }
        public string CurrentUserName { set; get; }

        public clsTransferLogRegister(string dateTime, string accountNumberSource, string accountNumberDestin, double amountTransfer, double balanceSource, double balanceDestin, string currentUserName)
        {
            DateTime = dateTime;
            AccountNumberSource = accountNumberSource;
            AccountNumberDestin = accountNumberDestin;
            AmountTransfer = amountTransfer;
            BalanceSource = balanceSource;
            BalanceDestin = balanceDestin;
            CurrentUserName = currentUserName;
        }
    }
    public string AccountNumber {  get; }
    public string PinCode { get; set; }
    public double AccountBalance {  get; set; }

    static private string _PathFileClients = "C:\\Users\\KarimPc\\Desktop\\C#_BankProject\\BankSystem\\Clients.txt";
    static private string _PathFileTransferLog = "C:\\Users\\KarimPc\\Desktop\\C#_BankProject\\BankSystem\\TransferLog.txt";


    public clsBankClient(clsBankClient.enMode Mode,string FirstName,string LastName,string Email,string Phone,
        string AccountNumber, string PinCode, double AccountBalance):base(FirstName,LastName,Email,Phone)
    {
        _Mode = Mode;
        this.AccountNumber = AccountNumber;
        this.PinCode = PinCode;
        this.AccountBalance = AccountBalance;
    }

    private static clsBankClient _ConvertLineToClientObject(string Line, string Separator = "#//#")
    {
        string[] Separators=new string[] {Separator};   
        string[] arrClient = Line.Split(Separators,StringSplitOptions.RemoveEmptyEntries);

       clsBankClient Client = new clsBankClient(enMode.UpdateMode, arrClient[0], arrClient[1], arrClient[2], arrClient[3],
             arrClient[4], arrClient[5], Convert.ToDouble(arrClient[6]));
       return Client;
    }

    private static string _ConvertClientObjectToLine(clsBankClient Client, string Separator = "#//#")
    {
        string LineClient = "";
        LineClient += Client.FirstName + Separator;
        LineClient += Client.LastName + Separator;
        LineClient += Client.Email+ Separator;
        LineClient += Client.Phone+ Separator;
        LineClient += Client.AccountNumber+ Separator;
        LineClient += Client.PinCode + Separator;
        LineClient += Client.AccountBalance;
        return LineClient;
    }

    private static List<clsBankClient> _LoadClientsDataFromFile()
    {
        List<clsBankClient> _ListClients = new List<clsBankClient>();
        if (File.Exists(_PathFileClients))
        {
            StreamReader MyFile = new StreamReader(_PathFileClients);
            string Line;
            
            while ((Line = MyFile.ReadLine()) != null)
            {
                clsBankClient Client = _ConvertLineToClientObject(Line);
                _ListClients.Add(Client);
            }
            MyFile.Close(); 
        }
        return _ListClients;
    }

    private static void _SaveClientsDataToFile(List<clsBankClient> Clients)
    {
        if(File.Exists(_PathFileClients))
        {
            StreamWriter MyFile = new StreamWriter(_PathFileClients);
            string DataLine;
            foreach (clsBankClient Client in Clients)
            {
                if (Client.MarkedForDelete() == false)
                {
                    DataLine = _ConvertClientObjectToLine(Client);
                    MyFile.WriteLine(DataLine);
                }

            }
            MyFile.Close();
        }
        
        
        
    }

    private  void _Save()
    {
        List<clsBankClient> _ListClients = _LoadClientsDataFromFile();

        for (int i = 0; i < _ListClients.Count; i++)
        {
            if (_ListClients[i].AccountNumber == AccountNumber)
            {
                _ListClients[i].AccountBalance = this.AccountBalance;
                break;
            }
        }
        _SaveClientsDataToFile(_ListClients);
    }
    private void _Update()
    {
        List<clsBankClient> _ListClients = _LoadClientsDataFromFile();
        
        for (int i=0;i<_ListClients.Count;i++)
        {
            if (_ListClients[i].AccountNumber == AccountNumber)
            {
                _ListClients[i] = this;
                break;
            }
        }
        _SaveClientsDataToFile(_ListClients);
    }

    private void _AddDataLineToFile(string DataLine)
    {
        if (File.Exists(_PathFileClients))
        {
            StreamWriter MyFile = new StreamWriter(_PathFileClients, true);
            MyFile.WriteLine(DataLine);
            MyFile.Close();
        }
        
    }
    private void _AddNew()
    {
        _AddDataLineToFile(_ConvertClientObjectToLine(this));
    }

    public static clsBankClient Find(string AccountNumber)
    {
        if(File.Exists(_PathFileClients))
        {
            StreamReader MyFile = new StreamReader(_PathFileClients);
            string Line;
            while ((Line = MyFile.ReadLine()) != null)
            {
                clsBankClient Client = _ConvertLineToClientObject(Line);
                if (Client.AccountNumber == AccountNumber)
                {
                    
                    MyFile.Close();
                    return Client;
                }
            }
            MyFile.Close();
        }
        
        return null;
    }

    public static clsBankClient Find(string AccountNumber,string PinCode)
    {
        if(File.Exists(_PathFileClients))
        {
        StreamReader MyFile = new StreamReader(_PathFileClients);
        string Line;
        while ((Line = MyFile.ReadLine()) != null)
        {
            clsBankClient Client = _ConvertLineToClientObject(Line);
            if (Client.AccountNumber == AccountNumber&&Client.PinCode==PinCode)
            {
                MyFile.Close();
                return Client;
            }
        }
        MyFile.Close();
        }
        return null;
    }
    
    public void Print()
    {
        Console.WriteLine("\nClient Card : ");
        Console.WriteLine("_______________________________________\n");
        Console.WriteLine($"First Name      : {FirstName}");
        Console.WriteLine($"Last Name       : {LastName}");
        Console.WriteLine($"Full Name       : {FullName}");
        Console.WriteLine($"Email           : {Email}");
        Console.WriteLine($"Phone           : {Phone}");
        Console.WriteLine($"Account Number  : {AccountNumber}");
        Console.WriteLine($"Pin Code        : {PinCode}");
        Console.WriteLine($"Account Balance : {AccountBalance:C}");
        Console.WriteLine("_______________________________________\n");
    }

    public bool Delete()
    {
        List<clsBankClient> _ListClients = _LoadClientsDataFromFile();

        for (int i = 0; i < _ListClients.Count; i++)
        {
            if (_ListClients[i].AccountNumber == AccountNumber)
            {
                _ListClients[i]._MarkedForDelete = true;
                break;
            }
        }
        _SaveClientsDataToFile(_ListClients);
        return true;
    }
    public static bool IsClientExist(string AccountNumber)
    {
        return !(Find(AccountNumber) == null);
    }
   
    public static clsBankClient GetAddNewClientObject(string AccountNumber)
    {
        clsBankClient NewClient = new clsBankClient(enMode.AddNewMode, "", "", "", "", AccountNumber, "", 0);
        return NewClient;
    }

    public static double GetTotalBalances()
    {
        List<clsBankClient> _ListClients = clsBankClient.GetClientsList();
        double TotalBalances = 0;
        foreach (clsBankClient Client in _ListClients)
        {
            TotalBalances += Client.AccountBalance;
        }
        return TotalBalances;
    }
    public enum enSaveResult { svSucceeded=1,svFaild=2}
    public enSaveResult Save()
    {
        switch(_Mode)
        {
            case enMode.UpdateMode:
                _Update();
                return  enSaveResult.svSucceeded;
            case enMode.AddNewMode:
                _AddNew();
                _Mode = enMode.UpdateMode;
                return enSaveResult.svSucceeded;
        }
        return enSaveResult.svFaild;
    }

    public static List<clsBankClient> GetClientsList()
    {
        return _LoadClientsDataFromFile();
    }
    public void Deposite(double Amount)
    {
        AccountBalance += Amount;
        _Save();
    }
    public void Withdraw(double Amount)
    {
        AccountBalance -= Amount;
        _Save();
    }

    private string _PrepareTransferLogRecord(clsBankClient ClintTo, double Amount,string UserName, string Separtore = "#//#")
    {
        string TransferLogRecord = "";
        TransferLogRecord += DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss") + Separtore;
        TransferLogRecord += this.AccountNumber + Separtore;
        TransferLogRecord += ClintTo.AccountNumber + Separtore;
        TransferLogRecord += Amount + Separtore;
        TransferLogRecord += this.AccountBalance + Separtore;
        TransferLogRecord += ClintTo.AccountBalance + Separtore;
        TransferLogRecord += UserName;

        return TransferLogRecord;
    }
    private void _RegisterTransferLog(clsBankClient ClientTo, double Amount,string UserName)
    {
        if (File.Exists(_PathFileTransferLog))
        {
            StreamWriter MyFile = new StreamWriter(_PathFileTransferLog, true);
            MyFile.WriteLine(_PrepareTransferLogRecord(ClientTo, Amount,UserName));
            MyFile.Close();
        }
    }
    public bool Transfer(clsBankClient ClientTo,double Amount,string UserName)
    {
        this.Withdraw(Amount);
        ClientTo.Deposite(Amount);
        _RegisterTransferLog(ClientTo, Amount, UserName);
        return true;
    }

    static private clsTransferLogRegister _ConvertLineToTransferLogRegisterRecord(string Line, string Separator = "#//#")
    {

        string[] Separators = new string[] { Separator };
        string[] arrRecordRegister = Line.Split(Separators, StringSplitOptions.RemoveEmptyEntries);

        clsTransferLogRegister TransferogRegisterRecord = new clsTransferLogRegister(arrRecordRegister[0], arrRecordRegister[1], arrRecordRegister[2], Convert.ToDouble(arrRecordRegister[3]),
          Convert.ToDouble(arrRecordRegister[4]), Convert.ToDouble(arrRecordRegister[5]), arrRecordRegister[6]);
        return TransferogRegisterRecord;
    }
    static public List<clsTransferLogRegister> GetTransferLogRegisterList()
    {
        List<clsTransferLogRegister> _ListTransferLogRegister = new List<clsTransferLogRegister>();
        if (File.Exists(_PathFileTransferLog))
        {
            StreamReader MyFile = new StreamReader(_PathFileTransferLog);
            string Line;

            while ((Line = MyFile.ReadLine()) != null)
            {
                clsTransferLogRegister RecordTransferLogRegister = _ConvertLineToTransferLogRegisterRecord(Line);
                _ListTransferLogRegister.Add(RecordTransferLogRegister);
            }
            MyFile.Close();
        }
        return _ListTransferLogRegister;
    }

}
