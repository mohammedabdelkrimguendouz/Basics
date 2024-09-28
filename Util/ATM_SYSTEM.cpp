#include<iostream>
#include<vector>
#include<fstream>
#include<iomanip>
using namespace std;
const string ClientsFileName="FileClients.txt";
const string UsersFileName="FileUsers.txt";
enum enMainMenueOptions{eQuikWithdraw=1,eNormalWithdraw=2,eDeposite=3,eCheckBalanced=4,eShowClientInformation=5,eLogOut=6};

struct stClients
{
    string AccountNumber;
    string CodePin;
    string ClientName;
    string PhoneNumber;
    double Balanced;
    bool MarkClientForDelete=false;
};
void Login();
void ShowMainMenue();
void ShowQuickWithdrawSecreen();
void ShowNormalWithdrawSecreen();
stClients CurrentClient;

void GoBackToMainMenue()
{
    cout<<"\n\n Press any key to go back to  Maine Menue ...  ";
    system("pause>0");
    ShowMainMenue();
}

enMainMenueOptions ReadMainMenueOption()
{
    short Choice;
    do
    {
        cout<<" Chosse Wate do you want to do ? [1 to 5] ? ";
        cin>>Choice;
    }while(Choice<=0||Choice>6);
    return (enMainMenueOptions)Choice;
}

vector<string> SplitString(string Line,string Seperator="#//#")
{
    vector<string> vString;
    string Word;
    short pos=0;
    while((pos=Line.find(Seperator)) != Line.npos)
    {
        Word=Line.substr(0,pos);
        if(Word!="")
        {
            vString.push_back(Word);
        }
        Line.erase(0,pos+Seperator.length());
    }

    if(Line!="")
    {
        vString.push_back(Line);
    }
    return vString;
}

stClients ConvertLineToRecord(string Line,string Seperator="#//#")
{
    vector<string>vClients=SplitString(Line,Seperator);
    stClients Client;
    Client.AccountNumber=vClients[0];
    Client.CodePin=vClients[1];
    Client.ClientName=vClients[2];
    Client.PhoneNumber=vClients[3];
    Client.Balanced=stod(vClients[4]);
    return Client;
}

vector<stClients> LoadClientsDataFromFile(string ClientsFileName)
{
    fstream MyFile;
    vector<stClients> vClients;
    stClients sClients;
    MyFile.open(ClientsFileName,ios::in);
    if(MyFile.is_open())
    {
         string Line;
         while(getline(MyFile,Line))
        {
            sClients=ConvertLineToRecord(Line);
            vClients.push_back(sClients);
        }
        MyFile.close();
    }
    return vClients;
}
bool FindClientByAccountNumberAndPinCode(string AccountNumber,string PinCode,stClients &Client)
{
   vector<stClients> vClient=LoadClientsDataFromFile(ClientsFileName);
   for(stClients C:vClient)
   {
       if(C.AccountNumber==AccountNumber&&C.CodePin==PinCode)
       {
           Client=C;
           return true;
       }
   }
   return false;
}

string ConvertRecordToLine(stClients Client,string Seperator="#//#")
{
    string Line="";
    Line+=Client.AccountNumber+Seperator;
    Line+=Client.CodePin+Seperator;
    Line+=Client.ClientName+Seperator;
    Line+=Client.PhoneNumber+Seperator;
    Line+=to_string(Client.Balanced);
    return Line;
}

void ShowClientInformation()
{
    cout<<"\nThe following are the client details: \n";
    cout<<"\n******************************************";
    cout<<"\nAccount Number : "<<CurrentClient.AccountNumber;
    cout<<"\nPin Code       : "<<CurrentClient.CodePin;
    cout<<"\nClient Name    : "<<CurrentClient.ClientName;
    cout<<"\nPhone          : "<<CurrentClient.PhoneNumber;
    cout<<"\nAccount Balanced : "<<CurrentClient.Balanced;
    cout<<"\n*******************************************\n";
}

void ShowCheckBalancSecreen()
{
    cout<<"\n==========================================\n";
    cout<<"\tCheck Balanc Secreen ";
    cout<<"\n==========================================\n";
    cout<<"\n Your Balanc is : "<<CurrentClient.Balanced<<"\n";
}
void SaveClientsDataToFile(string FileName,vector<stClients> vClient)
{
    fstream MyFile;
    MyFile.open(FileName,ios::out);
    string Line;
    if(MyFile.is_open())
    {
        for(stClients C:vClient)
        {
             if(C.MarkClientForDelete==false)
             {
                  Line=ConvertRecordToLine(C);
                  MyFile<<Line<<endl;
             }
        }
        MyFile.close();
    }

}

bool DepositBalancesToClientByAccountNumber(string AccountNumber, double Amount,vector<stClients> &vClient)
{
    char Answer='Y';
    cout<<"Are you sure you want perform this transaction ? Y/N ? ";
    cin>>Answer;
    if(toupper(Answer)=='Y')
    {
       for(stClients &C:vClient)
       {
           if(C.AccountNumber==CurrentClient.AccountNumber)
           {
               C.Balanced+=Amount;
               SaveClientsDataToFile(ClientsFileName,vClient);
               cout<<"\nDone Successfully , New Balnces is : "<<C.Balanced;
               return true;
           }
       }
    }
    return false;
}

double ReadDepositeAmount()
{
    double DepoisteAmount;
    do
    {
        cout<<"\nEnter a positive Deposit Amount ? ";
        cin>>DepoisteAmount;
    }while(DepoisteAmount<0);
    return DepoisteAmount;

}

void PerformDepositeOption()
{
    double DepositeAmount=ReadDepositeAmount();
    vector<stClients>vClient=LoadClientsDataFromFile(ClientsFileName);
    DepositBalancesToClientByAccountNumber(CurrentClient.AccountNumber,DepositeAmount,vClient);
    CurrentClient.Balanced+=DepositeAmount;
}

void ShowDepositeSecreen()
{
    cout<<"\n==========================================\n";
    cout<<"\tDeposite Secreen ";
    cout<<"\n==========================================\n";
    PerformDepositeOption();
}
short ReadQuickWithdrawOption()
{
    short Choice=0;
    while(Choice<1 || Choice>9)
    {
        cout<<"\nChoose what to withdraw from[1 to 8] ? ";
        cin>>Choice;
    }
    return Choice;

}
short GetWithdrawAmount(short QuickWithdrawOption)
{
    short ArrQuickWithdraw[8]={20,50,100,200,400,600,800,1000};
    return ArrQuickWithdraw[QuickWithdrawOption-1];

}
void PerformQuickWithdrawOption(short QuickWithdrawOption)
{
  if(QuickWithdrawOption==9) return;
  short WithdrawAmount=GetWithdrawAmount(QuickWithdrawOption);
  if(WithdrawAmount>CurrentClient.Balanced)
  {
      cout<<"\nThe Amount exceed your balance,make another choice.\n";
      cout<<"Press AnyKey to countinue...";
      system("pause>0");
      ShowQuickWithdrawSecreen();
      return;
  }
  vector<stClients> vClient=LoadClientsDataFromFile(ClientsFileName);
  DepositBalancesToClientByAccountNumber(CurrentClient.AccountNumber,WithdrawAmount*-1,vClient);
  CurrentClient.Balanced-=WithdrawAmount;
}
void ShowQuickWithdrawSecreen()
{
    system("cls");
    cout<<"\n==========================================\n";
    cout<<"\tQuick Withdraw Secreen ";
    cout<<"\n==========================================\n";
    cout<<"\t[1] 20\t\t[2] 50\n";
    cout<<"\t[3] 100\t\t[4] 200\n";
    cout<<"\t[5] 400\t\t[6] 600\n";
    cout<<"\t[7] 800\t\t[8] 1000\n";
    cout<<"\t[9] Exit";
    cout<<"\n==========================================\n";
    cout<<"Your Balance is : "<<CurrentClient.Balanced;
    PerformQuickWithdrawOption(ReadQuickWithdrawOption());
}

int ReadWithdrawAmount()
{
    int WithdrawAmount;
    do
    {
          cout<<"Enter a amount Multiple of 5/'s ? ";
          cin>>WithdrawAmount;
    }while(WithdrawAmount%5!=0);
    return WithdrawAmount;
}

void PerformNormalWithdrawOption()
{
   int WithdrawAmount=ReadWithdrawAmount();
   if(WithdrawAmount>CurrentClient.Balanced)
   {
      cout<<"\nThe Amount exceed your balance,make another choice.\n";
      cout<<"Press AnyKey to countinue...";
      system("pause>0");
      ShowNormalWithdrawSecreen();
      return;
   }
   vector<stClients>vClient=LoadClientsDataFromFile(ClientsFileName);
   DepositBalancesToClientByAccountNumber(CurrentClient.AccountNumber,WithdrawAmount*-1,vClient);
   CurrentClient.Balanced-=WithdrawAmount;
}

void ShowNormalWithdrawSecreen()
{
    system("cls");
    cout<<"\n==========================================\n";
    cout<<"\tNormal Withdraw Secreen ";
    cout<<"\n==========================================\n";
    PerformNormalWithdrawOption();
}

void PerformMainMenueOptions(enMainMenueOptions MainMenueOption)
{
    switch(MainMenueOption)
    {
    case enMainMenueOptions::eQuikWithdraw:
        system("cls");
        ShowQuickWithdrawSecreen();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eNormalWithdraw:
        system("cls");
        ShowNormalWithdrawSecreen();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eDeposite:
        system("cls");
        ShowDepositeSecreen();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eCheckBalanced:
        system("cls");
        ShowCheckBalancSecreen();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eShowClientInformation:
        system("cls");
        ShowClientInformation();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eLogOut:
        system("cls");
        Login();
        break;

    }
}

void ShowMainMenue()
{
    system("cls");
    cout<<"\n====================================================\n";
    cout<<"\t\tATM Main Menue Secreen ";
    cout<<"\n====================================================\n";
    cout<<"\t[1] Quick Withdraw \n";
    cout<<"\t[2] Normal Withdraw \n";
    cout<<"\t[3] Deposite \n";
    cout<<"\t[4] Check Balanced \n";
    cout<<"\t[5] Show My Information \n";
    cout<<"\t[6] Log Out ";
    cout<<"\n====================================================\n";
    PerformMainMenueOptions(ReadMainMenueOption());
}
bool LoadClientInfo(string AccountNumber,string PinCode)
{
    if(FindClientByAccountNumberAndPinCode(AccountNumber,PinCode,CurrentClient))
        return true;
    return false;
}
void Login()
{
    int LoginFaild=false;
    string AccountNumber,PinCode;
    do
    {
        system("cls");
        cout<<"\n==========================================\n";
        cout<<"\t\tSecreen Login ";
        cout<<"\n==========================================\n";
        if(LoginFaild)
        {
            cout<<"Invalide AccountNumber/Password ! \n";
        }
        cout<<"Please Enter Your Account Number ? ";
        cin>>AccountNumber;
        cout<<"Please Enter Your Pin Code ? ";
        cin>>PinCode;
        LoginFaild=!LoadClientInfo(AccountNumber,PinCode);
    }while(LoginFaild);
    ShowMainMenue();
}

int main()
{
    Login();
    return 0;
}
