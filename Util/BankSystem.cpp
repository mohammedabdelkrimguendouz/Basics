#include<iostream>
#include<string>
#include<vector>
#include<fstream>
#include<iomanip>
using namespace std;
enum enMainMenueParmissions{pAll=-1,pListClintes=1,pAddNewClient=2,pDeleteClient=4,pUpdateClient=8,pFindClient=16,pShowTransactionsMenue=32,pManageUsers=64};
enum enManageUsersMenueOptions{eListUsers=1,eAddNewUsers=2,eDeleteUser=3,eUpdateUser=4,eFindUser=5,eReturnMainMenue=6};
enum enMainMenueOptions{eListClintes=1,eAddNewClient=2,eDeleteClient=3,eUpdateClient=4,eFindClient=5,eShowTransactionsMenue=6,eManageUsers=7,eLogOut=8};
enum enTransactionsMenueOptions{eDeposite=1,eWithdraw=2,eShowTotalBalances=3,eShowMainMenue=4};
struct stClients
{
    string AccountNumber;
    string CodePin;
    string ClientName;
    string PhoneNumber;
    double Balanced;
    bool MarkClientForDelete=false;
};
struct stUsers
{
    string UserName;
    string Password;
    int Permission;
    bool MarkUserForDelete=false;
};

stUsers CurrentUser;

const string ClientsFileName="FileClients.txt";
const string UsersFileName="FileUsers.txt";
void ShowMainMenue();
void ShowTransactionsMenue();
void Login();
void ShowManageUsersMenue();

bool CheckAccessPermission(enMainMenueParmissions Permission)
{
    if(CurrentUser.Permission==enMainMenueParmissions::pAll) return true;
    if((Permission&CurrentUser.Permission)==Permission) return true;
    return false;
}

void ShowAccessDeniedMessage()
{
    cout<<"\n******************************************\n";
    cout<<" Access Denied ,\n You dont Have Permission To Do this,\n Please Conact Your Admin\n";
    cout<<"\n******************************************\n";

}

string ReadUserName()
{
    string UserName;
    cout<<" Pleas Enter User Name ? ";
    getline(cin>>ws,UserName);
    return UserName;
}
string ReadPassword()
{
    string Password;
    cout<<" Pleas Enter Password ? ";
    getline(cin>>ws,Password);
    return Password;
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


stUsers ConvertUserLineToRecord(string Line,string Seperator="#//#")
{
    vector<string>vUser=SplitString(Line,Seperator);
    stUsers User;
    User.UserName=vUser[0];
    User.Password=vUser[1];
    User.Permission=stoi(vUser[2]);
    return User;
}


string ReadClientAccountNumber()
{
    string ClientAccountNumber="";
    cout<<"Enter Account Number ? ";
    cin>>ClientAccountNumber;
    return ClientAccountNumber;
}




void GoBackToMainMenue()
{
    cout<<"\n\n Press any key to go back to Main Menue ...  ";
    system("pause>0");
    ShowMainMenue();
}


void GoBackToMainMenueTransactions()
{

    cout<<"\n\n Press any key to go back to  Transactions Menue ...  ";
    system("pause>0");
    ShowTransactionsMenue();
}

void GoBackToManageUserMenue()
{
    cout<<"\n\n Press any key to go back to  Manage User Menue ...  ";
    system("pause>0");
    ShowManageUsersMenue();
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
string ConvertUserRecordToLine(stUsers User,string Seperator="#//#")
{
    string Line="";
    Line+=User.UserName+Seperator;
    Line+=User.Password+Seperator;
    Line+=to_string(User.Permission);
    return Line;
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
vector<stUsers> LoadUsersDataFromFile(string UsersFileName)
{
    fstream MyFile;
    vector<stUsers> vUser;
    stUsers sUser;
    MyFile.open(UsersFileName,ios::in);
    if(MyFile.is_open())
    {
         string Line;
         while(getline(MyFile,Line))
        {
            sUser=ConvertUserLineToRecord(Line);
            vUser.push_back(sUser);
        }
        MyFile.close();
    }
    return vUser;
}

void PrintUserRecordLine(stUsers User)
{
    cout<<"| "<<left<<setw(15)<<User.UserName;
    cout<<"| "<<left<<setw(10)<<User.Password;
    cout<<"| "<<left<<setw(40)<<User.Permission;
}

void PrintClientRecordLine(stClients Client)
{
    cout<<"| "<<left<<setw(15)<<Client.AccountNumber;
    cout<<"| "<<left<<setw(10)<<Client.CodePin;
    cout<<"| "<<left<<setw(40)<<Client.ClientName;
    cout<<"| "<<left<<setw(12)<<Client.PhoneNumber;
    cout<<"| "<<left<<setw(12)<<Client.Balanced;
}

void PrintClientCard(stClients Client)
{
    cout<<"\nThe following are the client details: \n";
    cout<<"\n--------------------------------------\n";
    cout<<"\nAccount Number : "<<Client.AccountNumber;
    cout<<"\nPin Code       : "<<Client.CodePin;
    cout<<"\nClient Name    : "<<Client.ClientName;
    cout<<"\nPhone          : "<<Client.PhoneNumber;
    cout<<"\nAccount Balanced : "<<Client.Balanced;
    cout<<"\n--------------------------------------\n";
}

bool UserExistsByUserName(string UserName,string FileName)
{

    fstream MyFile;
    MyFile.open(FileName,ios::in);
    if(MyFile.is_open())
    {
        string Line;
        stUsers sUser;
        while(getline(MyFile,Line))
        {
            sUser=ConvertUserLineToRecord(Line);
            if(sUser.UserName==UserName)
            {
                MyFile.close();
                return true;
            }
        }
        MyFile.close();
    }
    return false;
}


bool ClientExistsByAccountNumber(string AccountNumber,string FileName)
{

    fstream MyFile;
    MyFile.open(FileName,ios::in);
    if(MyFile.is_open())
    {
        string Line;
        stClients Client;
        while(getline(MyFile,Line))
        {
            Client=ConvertLineToRecord(Line);
            if(Client.AccountNumber==AccountNumber)
            {
                MyFile.close();
                return true;
            }
        }
        MyFile.close();
    }
    return false;
}

int ReadPermissionToSet()
{
   int Permissions=0;
   char Answer='n';
   cout<<"\n Do you want to giv full access ? Y/N ? ";
   cin>>Answer;
   if(Answer=='y'||Answer=='Y') return -1;
   cout<<"\n do you want to giv  access to : \n";
   cout<<"Show Clients ? Y/N ?";
   cin>>Answer;
   if(Answer=='y'||Answer=='Y') Permissions+=enMainMenueParmissions::pListClintes;
   cout<<"\nAdd New Client ? Y/N ?";
   cin>>Answer;
   if(Answer=='y'||Answer=='Y') Permissions+=enMainMenueParmissions::pAddNewClient;
   cout<<"\nDelete Client ? Y/N ? ";
   cin>>Answer;
   if(Answer=='y'||Answer=='Y') Permissions+=enMainMenueParmissions::pDeleteClient;
   cout<<"\nUpdate Client ? Y/N ?";
   cin>>Answer;
   if(Answer=='y'||Answer=='Y') Permissions+=enMainMenueParmissions::pUpdateClient;
   cout<<"\nFind Client ? Y/N ? ";
   cin>>Answer;
   if(Answer=='y'||Answer=='Y') Permissions+=enMainMenueParmissions::pFindClient;
   cout<<"\nTransaction  ? y/n ";
   cin>>Answer;
   if(Answer=='y'||Answer=='Y') Permissions+=enMainMenueParmissions::pShowTransactionsMenue;
   cout<<"\nMange User  ? y/n ";
   cin>>Answer;
   if(Answer=='y'||Answer=='Y') Permissions+=enMainMenueParmissions::pManageUsers;

   return Permissions;
}

stUsers ReadNewUser()
{
    stUsers User;
    cout<<" Enter User Name ? ";
    getline(cin>>ws,User.UserName);
    while(UserExistsByUserName(User.UserName,UsersFileName))
    {
        cout<<"\nUser Withe ["<<User.UserName<<"] already exists ,Enter anther User Name ? ";
        getline(cin>>ws,User.UserName);
    }
    cout<<" Passowrd ? ";
    getline(cin>>ws,User.Password);
    User.Permission=ReadPermissionToSet();
    return User;
}
stClients ReadNewClient()
{
    stClients Client;
    cout<<"Enter Account Number ? ";
    getline(cin>>ws,Client.AccountNumber);

    while(ClientExistsByAccountNumber(Client.AccountNumber,ClientsFileName))
    {
        cout<<"\nClient Withe ["<<Client.AccountNumber<<"] already exists ,Enter anther Account Numbre ? ";
        getline(cin>>ws,Client.AccountNumber);
    }

    cout<<"Enter Pin Code ? ";
    getline(cin,Client.CodePin);

    cout<<"Enter Client Name ? ";
    getline(cin,Client.ClientName);

    cout<<"Enter PhoneNumber ? ";
    getline(cin,Client.PhoneNumber);

    cout<<"Enter Balanced ? ";
    cin>>Client.Balanced;

    return Client;

}

bool FindClientByAccountNumber(string AccountNumber, vector<stClients> vClient,stClients &Client)
{
    for(stClients C:vClient)
    {
        if(C.AccountNumber==AccountNumber)
        {
            Client=C;
            return true;
        }
    }
    return false;
}

bool FindUserByUserNameAndPassword(string UserName, string Password,stUsers &User)
{
    vector<stUsers>vUsers=LoadUsersDataFromFile(UsersFileName);
    for(stUsers U:vUsers)
    {
        if(U.UserName==UserName&&U.Password==Password)
        {
            User=U;
            return true;
        }
    }
    return false;
}


void ShowAllClientsSecreen()
{
    if(!CheckAccessPermission(enMainMenueParmissions::pListClintes))
    {
        ShowAccessDeniedMessage();
        return ;
    }
    vector<stClients> vClients=LoadClientsDataFromFile(ClientsFileName);
    cout<<"\n\t\t\t\t Client List("<<vClients.size()<<") Client(s)\n\n";
    cout<<"\n______________________________________________________";
    cout<<"______________________________________________\n"<<endl;
    cout<<"| "<<left<<setw(15)<<"Account Number";
    cout<<"| "<<left<<setw(10)<<"Pin Code";
    cout<<"| "<<left<<setw(40)<<"Client Name";
    cout<<"| "<<left<<setw(12)<<"Phone";
    cout<<"| "<<left<<setw(12)<<"Balanced";
    cout<<"\n______________________________________________________";
    cout<<"______________________________________________\n"<<endl;
    if(vClients.size()==0)
    {
        cout<<"\t\t\t\tNo Clients Available In The System!";
    }
    else
    {
        for(stClients Client:vClients)
        {
            PrintClientRecordLine(Client);
            cout<<endl;
        }
    }
    cout<<"\n______________________________________________________";
    cout<<"______________________________________________\n"<<endl;
}

void AddDataLineToFile(string FileName,string Line)
{
   fstream MyFile;
   MyFile.open(FileName,ios::out | ios::app );
   if(MyFile.is_open())
   {
       MyFile<<Line<<endl;
       MyFile.close();
   }
}



void AddNewClient()
{
   stClients sClient;
   sClient=ReadNewClient();
   AddDataLineToFile(ClientsFileName,ConvertRecordToLine(sClient));
}

void AddNewClients()
{
    char AddMore='Y';
    do
    {
         cout<<"Adding New Client : \n\n";
         AddNewClient();
         cout<<"Client Add Successfully, do you want to Add More Clients ? Y/N ? ";
         cin>>AddMore;
    }while(toupper(AddMore)=='Y');
}

enMainMenueOptions ReadMainMenueOption()
{
    short MainMenueOption=0;
    do
    {
        cout<<"\n Choose Whate do you want to de ? [ 1 to 8 ] ? ";
        cin>>MainMenueOption;
    }while(MainMenueOption<=0||MainMenueOption>8);
    return (enMainMenueOptions)MainMenueOption;
}

enTransactionsMenueOptions ReadMenueTransactions()
{
    short MenueTransactions=0;
    do
    {
        cout<<"\n Choose Whate do you want to de ? [ 1 to 4 ] ? ";
        cin>>MenueTransactions;
    }while(MenueTransactions<=0||MenueTransactions>4);
    return (enTransactionsMenueOptions)MenueTransactions;
}

enManageUsersMenueOptions ReadManageUsersMenue()
{
    short MenueMengeUser=0;
    do
    {
        cout<<"\n Choose Whate do you want to de ? [ 1 to 6 ] ? ";
        cin>>MenueMengeUser;
    }while(MenueMengeUser<=0||MenueMengeUser>6);
    return (enManageUsersMenueOptions)MenueMengeUser;
}

bool MarkClientForDeleteByAccountNumber(string AccountNumber,vector<stClients> &vClient)
{
    for(stClients &C:vClient)
    {
        if(AccountNumber==C.AccountNumber)
        {
            C.MarkClientForDelete=true;
            return true;
        }
    }
    return false;
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



void SaveUsersDataToFile(string FileName,vector<stUsers> vUser)
{
    fstream MyFile;
    MyFile.open(FileName,ios::out);
    string Line;
    if(MyFile.is_open())
    {
        for(stUsers U:vUser)
        {
             if(U.MarkUserForDelete==false)
             {
                  Line=ConvertUserRecordToLine(U);
                  MyFile<<Line<<endl;
             }
        }
        MyFile.close();
    }

}




void PrintUserCard(stUsers User)
{
    cout<<"\nThe following are the User details: \n";
    cout<<"\n--------------------------------------\n";
    cout<<"\nUser Name   : "<<User.UserName;
    cout<<"\nPassword    : "<<User.Password;
    cout<<"\nPermissions : "<<User.Permission;
    cout<<"\n--------------------------------------\n";
}

bool MarkUserForDeleteByUserName(string UserName,vector<stUsers> &vUser)
{
    for(stUsers &U:vUser)
    {
        if(UserName==U.UserName)
        {
            U.MarkUserForDelete=true;
            return true;
        }
    }
    return false;

}

bool DeleteClientByAccountNumber(string AccountNumber,vector<stClients> &vClient)
{
    stClients Client;
    char Answer='Y';
   if(FindClientByAccountNumber(AccountNumber,vClient,Client))
   {
       PrintClientCard(Client);
       cout<<"\n\n Are you sure you want delete this client ? Y/N ? ";
       cin>>Answer;
       if(Answer=='Y' || Answer=='y')
       {
            MarkClientForDeleteByAccountNumber(AccountNumber,vClient);
            SaveClientsDataToFile(ClientsFileName,vClient);
            vClient=LoadClientsDataFromFile(ClientsFileName);
            cout<<"\n\n Client Deleted Successfully .";
            return true;
       }

   }
   else
   {
       cout<<"Client With Account("<<AccountNumber<<") is Not Found! ";
   }
   return false;

}


bool DeleteUserByUserName(string UserName,string Password,vector<stUsers> &vUser)
{
    stUsers User;
    char Answer='Y';
   if(FindUserByUserNameAndPassword(UserName,Password,User))
   {
       PrintUserCard(User);
       cout<<"\n\n Are you sure you want delete this User ? Y/N ? ";
       cin>>Answer;
       if(Answer=='Y' || Answer=='y')
       {
            MarkUserForDeleteByUserName(UserName,vUser);
            SaveUsersDataToFile(UsersFileName,vUser);
            vUser=LoadUsersDataFromFile(UsersFileName);
            cout<<"\n\n User Deleted Successfully .";
            return true;
       }

   }
   else
   {
       cout<<"Incoorect Password/UserName ! ";
   }
   return false;

}


void ShowAddNewClientsScreen()
{
    if(!CheckAccessPermission(enMainMenueParmissions::pAddNewClient))
    {
        ShowAccessDeniedMessage();
        return ;
    }
    cout<<"\n-----------------------------------\n";
    cout<<"\n    Add New Client  Screen \n";
    cout<<"\n-----------------------------------\n";
    AddNewClients();
}

void ShowDeleteClientsScreen()
{
    if(!CheckAccessPermission(enMainMenueParmissions::pDeleteClient))
    {
        ShowAccessDeniedMessage();
        return ;
    }
    cout<<"\n-----------------------------------\n";
    cout<<"\n    Delete Client  Screen \n";
    cout<<"\n-----------------------------------\n";
    vector<stClients> vClient=LoadClientsDataFromFile(ClientsFileName);
    string AccountNumber=ReadClientAccountNumber();
    DeleteClientByAccountNumber(AccountNumber,vClient);
}


stClients ChangeClientRecord(string AccountNumber)
{
    stClients Client;
    Client.AccountNumber=AccountNumber;
    cout<<"Enter Pin Code ? ";
    getline(cin>>ws,Client.CodePin);

    cout<<"Enter Client Name ? ";
    getline(cin,Client.ClientName);

    cout<<"Enter PhoneNumber ? ";
    getline(cin,Client.PhoneNumber);

    cout<<"Enter Balanced ? ";
    cin>>Client.Balanced;

    return Client;

}



bool UpdateClientByAccountNumber(string AccountNumber,vector<stClients> &vClient)
{
    stClients Client;
    char Answer='Y';
    if(FindClientByAccountNumber(AccountNumber,vClient,Client))
    {
       PrintClientCard(Client);
       cout<<"\n\n Are you sure you want Update this client ? Y/N ? ";
       cin>>Answer;
       if(Answer=='Y' || Answer=='y')
       {
           system("cls");
            for(stClients &C:vClient)
            {
                if(C.AccountNumber==AccountNumber)
                {
                    C=ChangeClientRecord(AccountNumber);
                    break;
                }
            }
            SaveClientsDataToFile(ClientsFileName,vClient);
            cout<<"\n\nClient Update Successfully .";
            return true;
       }

    }
   else
   {
       cout<<"Client With Account("<<AccountNumber<<") is Not Found! ";
   }
   return false;

}


void ShowUpdateClientSecreen()
{
    if(!CheckAccessPermission(enMainMenueParmissions::pUpdateClient))
    {
        ShowAccessDeniedMessage();
        return ;
    }
    cout<<"\n-----------------------------------\n";
    cout<<"\n    Update Client Screen \n";
    cout<<"\n-----------------------------------\n";
    vector<stClients> vClient=LoadClientsDataFromFile(ClientsFileName);
    string AccountNumber=ReadClientAccountNumber();
    UpdateClientByAccountNumber(AccountNumber,vClient);
}



stUsers ChangeUserRecord(string UserName)
{
    stUsers User;
    User.UserName=UserName;
    User.Password=ReadPassword();
    User.Permission=ReadPermissionToSet();
    return User;

}



bool UpdateUserByUserNameAndPassword(string UserName,string Password,vector<stUsers> &vUser)
{
    stUsers User;
    char Answer='Y';
    if(FindUserByUserNameAndPassword(UserName,Password,User))
    {
       PrintUserCard(User);
       cout<<"\n\n Are you sure you want Update this User ? Y/N ? ";
       cin>>Answer;
       if(Answer=='Y' || Answer=='y')
       {
            for(stUsers &U:vUser)
            {
                if(U.UserName==UserName)
                {
                    U=ChangeUserRecord(UserName);
                    break;
                }
            }
            SaveUsersDataToFile(UsersFileName,vUser);
            cout<<"\n\nClient Update Successfully .";
            return true;
       }

    }
   else
   {
       cout<<"Incorecct Password/UserName! ";
   }
   return false;

}


void ShowUpdateUserSecreen()
{
    cout<<"\n-----------------------------------\n";
    cout<<"\n    User Client Screen \n";
    cout<<"\n-----------------------------------\n";
    vector<stUsers> vUser=LoadUsersDataFromFile(UsersFileName);
    string UserName=ReadUserName();
    string Password=ReadPassword();
    UpdateUserByUserNameAndPassword(UserName,Password,vUser);
}




void ShowFindClientScreen()
{
    if(!CheckAccessPermission(enMainMenueParmissions::pFindClient))
    {
        ShowAccessDeniedMessage();
        return ;
    }
    cout<<"\n-----------------------------------\n";
    cout<<"\n    Find Client Screen \n";
    cout<<"\n-----------------------------------\n";
    stClients Client;
    vector<stClients> vClient=LoadClientsDataFromFile(ClientsFileName);
    string AccountNumber=ReadClientAccountNumber();
    if(FindClientByAccountNumber(AccountNumber,vClient,Client))
       PrintClientCard(Client);
    else
       cout<<"Client With Account("<<AccountNumber<<") is Not Found! ";
}

void ShowFindUserScreen()
{
    cout<<"\n-----------------------------------\n";
    cout<<"    Find User Screen \n";
    cout<<"-----------------------------------\n";
    stUsers User;
    vector<stUsers> vUser=LoadUsersDataFromFile(UsersFileName);
    string UserName=ReadUserName();
    string Password=ReadPassword();
    if(FindUserByUserNameAndPassword(UserName,Password,User))
       PrintUserCard(User);
    else
       cout<<"Incoorect Password/UserName ! ";
}




void PerformMainMenueOption(enMainMenueOptions MainMenueOption)
{
    switch(MainMenueOption)
    {
    case enMainMenueOptions::eListClintes :
        system("cls");
        ShowAllClientsSecreen();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eAddNewClient:
        system("cls");
        ShowAddNewClientsScreen();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eDeleteClient:
        system("cls");
        ShowDeleteClientsScreen();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eUpdateClient:
        system("cls");
        ShowUpdateClientSecreen();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eFindClient:
        system("cls");
        ShowFindClientScreen();
        GoBackToMainMenue();
        break;
    case enMainMenueOptions::eShowTransactionsMenue:
        system("cls");
        ShowTransactionsMenue();
        break;
    case enMainMenueOptions::eManageUsers:
        system("cls");
        ShowManageUsersMenue();
        break;
    case enMainMenueOptions::eLogOut:
        system("cls");
        //ShowEndSecreen();
         Login();
        break;
    }
}

void ShowMainMenue()
{
    system("cls");
    cout<<"==================================================\n";
    cout<<"\t\t Main Menue Secreen "<<endl;
    cout<<"==================================================\n";
    cout<<"\t [1] Show Client List.\n";
    cout<<"\t [2] Add New Client.\n";
    cout<<"\t [3] Delete Client.\n";
    cout<<"\t [4] Update Client.\n";
    cout<<"\t [5] Fined Client.\n";
    cout<<"\t [6] Transactions.\n";
    cout<<"\t [7] Mange Users.\n";
    cout<<"\t [8] Log Out.\n";
    cout<<"==================================================\n";
    PerformMainMenueOption(ReadMainMenueOption());
}

bool DepositBalancesByAccountNumber(string AccountNumber,vector<stClients> &vClient,double Amount)
{
    char Answer='Y';
    cout<<"\nAre you sure you want perform this transaction ? Y/N ? ";
    cin>>Answer;
    if(Answer=='Y' || Answer=='y')
    {
        for(stClients &C:vClient)
        {
           if(C.AccountNumber==AccountNumber)
           {
            C.Balanced+=Amount;
            SaveClientsDataToFile(ClientsFileName,vClient);
            cout<<"\nDonne, New Balnces is : "<<C.Balanced;
            return true;
           }
        }
    }
}


void ShowDepositSecreen()
{
    cout<<"\n-----------------------------------\n";
    cout<<"\n    Deposit Screen \n";
    cout<<"\n-----------------------------------\n";
    vector<stClients> vClient=LoadClientsDataFromFile(ClientsFileName);
    string AccountNumber=ReadClientAccountNumber();
    stClients Client;
    while(!FindClientByAccountNumber(AccountNumber,vClient,Client))
    {
          cout<<"\nClient With Account["<<AccountNumber<<"] does not exist. \n";
          AccountNumber=ReadClientAccountNumber();
    }
    PrintClientCard(Client);
    double Amount=0;
    cout<<"\nPleas enter deposit amount ?";
    cin>>Amount;
    DepositBalancesByAccountNumber(AccountNumber,vClient,Amount);
}


double ReadWithdrawAmount(double ClientBalnces)
{
    double WithdrawAmount=0;
    cout<<"\nPleas enter withdraw amount ?";
    cin>> WithdrawAmount;
    while(WithdrawAmount>ClientBalnces)
    {
        cout<<"\nAmount Exceed the balanced, you can Withdraw up to : "<<ClientBalnces;
        cout<<"\nPleas enter anthore Withdraw amount ? ";
        cin>>WithdrawAmount;
    }
    return  WithdrawAmount;
}


void ShowWithdrawSecreen()
{
    cout<<"\n-----------------------------------\n";
    cout<<"\n    Withdraw Screen \n";
    cout<<"\n-----------------------------------\n";
    vector<stClients> vClient=LoadClientsDataFromFile(ClientsFileName);
    string AccountNumber=ReadClientAccountNumber();
    stClients Client;
    while(!FindClientByAccountNumber(AccountNumber,vClient,Client))
    {
          cout<<"\nClient With Account["<<AccountNumber<<"] does not exist. \n";
          AccountNumber=ReadClientAccountNumber();
    }
    PrintClientCard(Client);
    double Amount=0;
    cout<<"\nPleas enter Withdraw amount ?";
    cin>>Amount;
    while(Amount>Client.Balanced)
    {
        cout<<"\nAmount Exceeds the balance you can withdraw up to : "<<Client.Balanced;
        cout<<"\nPleas enter Withdraw amount ?";
        cin>>Amount;
    }
    DepositBalancesByAccountNumber(AccountNumber,vClient,Amount*-1);
}


void PrintClientRecordBalnceLine(stClients Client)
{
    cout<<"| "<<left<<setw(20)<<Client.AccountNumber;
    cout<<"| "<<left<<setw(45)<<Client.ClientName;
    cout<<"| "<<left<<setw(25)<<Client.Balanced;
}

void ShowTotalBalances()
{
    double TotalBalnces=0;
    vector<stClients> vClients=LoadClientsDataFromFile(ClientsFileName);
    cout<<"\n\t\t\t\t Client List("<<vClients.size()<<") Client(s)\n\n";
    cout<<"\n______________________________________________________";
    cout<<"______________________________________________\n"<<endl;
    cout<<"| "<<left<<setw(20)<<"Account Number";
    cout<<"| "<<left<<setw(45)<<"Client Name";
    cout<<"| "<<left<<setw(25)<<"Balanced";
    cout<<"\n______________________________________________________";
    cout<<"______________________________________________\n"<<endl;
    if(vClients.size()==0)
    {
        cout<<"\t\t\t\tNo Clients Available In The System!";
    }
    else
    {

        for(stClients Client:vClients)
        {
            TotalBalnces+=Client.Balanced;
            PrintClientRecordBalnceLine(Client);
            cout<<endl;
        }
    }
    cout<<"\n______________________________________________________";
    cout<<"______________________________________________\n"<<endl;
    cout<<"\n\t\t\t\t\t Total Balances : "<<TotalBalnces;
}

void PerformTransactionsMenueOption(enTransactionsMenueOptions  MenueTransactions)
{
    switch(MenueTransactions)
    {
    case enTransactionsMenueOptions::eDeposite:
        system("cls");
        ShowDepositSecreen();
        GoBackToMainMenueTransactions();
        break;
    case enTransactionsMenueOptions::eWithdraw:
        system("cls");
        ShowWithdrawSecreen();
        GoBackToMainMenueTransactions();
        break;
    case enTransactionsMenueOptions::eShowTotalBalances:
        system("cls");
        ShowTotalBalances();
        GoBackToMainMenueTransactions();
        break;
    case enTransactionsMenueOptions::eShowMainMenue:
        GoBackToMainMenue();
        break;
    }
}

void ShowTransactionsMenue()
{
    if(!CheckAccessPermission(enMainMenueParmissions::pShowTransactionsMenue))
    {
        ShowAccessDeniedMessage();
        GoBackToMainMenue();
        return ;
    }
    system("cls");
    cout<<"==================================================\n";
    cout<<"\t Transactions Menue Secreen "<<endl;
    cout<<"==================================================\n";
    cout<<"\t [1] Diposit.\n";
    cout<<"\t [2] Withdraw.\n";
    cout<<"\t [3] Total Balances.\n";
    cout<<"\t [4] Main Menue.\n";
    cout<<"==================================================\n";
    PerformTransactionsMenueOption(ReadMenueTransactions());
}


void ShowAllUsersSecreen()
{
    vector<stUsers> vUser=LoadUsersDataFromFile(UsersFileName);
    cout<<"\n\t\t\t\t Users List("<<vUser.size()<<") Client(s)\n\n";
    cout<<"\n______________________________________________________";
    cout<<"______________________________________________\n"<<endl;
    cout<<"| "<<left<<setw(15)<<"User Name";
    cout<<"| "<<left<<setw(10)<<"Passowrd";
    cout<<"| "<<left<<setw(40)<<"Permission";
    cout<<"\n______________________________________________________";
    cout<<"______________________________________________\n"<<endl;
    if(vUser.size()==0)
    {
        cout<<"\t\t\tNo Users Available In The System \n";
    }
    else{
        for(stUsers User:vUser)
        {
            PrintUserRecordLine(User);
            cout<<endl;
        }
    }
    cout<<"\n______________________________________________________";
    cout<<"______________________________________________\n"<<endl;
}


void AddNewUser()
{
   stUsers sUser;
   sUser=ReadNewUser();
   AddDataLineToFile(UsersFileName,ConvertUserRecordToLine(sUser));
}

void AddNewUsers()
{
    char AddMore='Y';
    do
    {
         cout<<"Adding New User : \n\n";
         AddNewUser();
         cout<<"User Add Successfully, do you want to Add More User ? Y/N ? ";
         cin>>AddMore;
    }while(toupper(AddMore)=='Y');
}

void ShowAddNewUsersScreen()
{
    cout<<"\n-----------------------------------\n";
    cout<<"\n    Add New User  Screen \n";
    cout<<"\n-----------------------------------\n";
    AddNewUsers();
}

void ShowDeleteUsersScreen()
{
    cout<<"\n-----------------------------------\n";
    cout<<"\n    Delete User  Screen \n";
    cout<<"\n-----------------------------------\n";
    vector<stUsers> vUser=LoadUsersDataFromFile(UsersFileName);
    string UserName=ReadUserName();
    string Password=ReadPassword();
    DeleteUserByUserName(UserName,Password,vUser);
}

void PerformManageUserMenueOption(enManageUsersMenueOptions  MenueMangeUser)
{
    switch(MenueMangeUser)
    {
    case enManageUsersMenueOptions::eListUsers:
        system("cls");
        ShowAllUsersSecreen();
        GoBackToManageUserMenue();
        break;
    case enManageUsersMenueOptions::eAddNewUsers:
        system("cls");
        ShowAddNewUsersScreen();
        GoBackToManageUserMenue();
        break;
    case enManageUsersMenueOptions::eDeleteUser:
        system("cls");
        ShowDeleteUsersScreen();
        GoBackToManageUserMenue();
        break;
    case enManageUsersMenueOptions::eUpdateUser:
        system("cls");
        ShowUpdateUserSecreen();
        GoBackToManageUserMenue();
        break;
    case enManageUsersMenueOptions::eFindUser:
        system("cls");
        ShowFindUserScreen();
        GoBackToManageUserMenue();
        break;
    case enManageUsersMenueOptions::eReturnMainMenue:
        GoBackToMainMenue();
        break;
    }
}

void ShowManageUsersMenue()
{
    if(!CheckAccessPermission(enMainMenueParmissions::pManageUsers))
    {
        ShowAccessDeniedMessage();
        GoBackToMainMenue();
        return ;
    }
    system("cls");
    cout<<"==================================================\n";
    cout<<"\t Mange User Menue Secreen "<<endl;
    cout<<"==================================================\n";
    cout<<"\t [1] List Users.\n";
    cout<<"\t [2] Add New User.\n";
    cout<<"\t [3] Delete User.\n";
    cout<<"\t [4] Update User.\n";
    cout<<"\t [5] Find User.\n";
    cout<<"\t [6] Main Menue.\n";
    cout<<"==================================================\n";
    PerformManageUserMenueOption(ReadManageUsersMenue());
}

bool LoadUserInfo(string UserName,string Password)
{
    if(FindUserByUserNameAndPassword(UserName,Password,CurrentUser))
        return true;
    return false;
}

void Login()
{
    int LoginFaild=false;
    string UserName,Password;
    do
    {
        system("cls");
        cout<<"\n-----------------------------------\n";
        cout<<"\t    Login Screen \n";
        cout<<"-----------------------------------\n";
        if(LoginFaild)
        {
           cout<<"Incorecct UserName/Password ! \n";
        }
        cout<<"Enter User Name ? ";
        getline(cin>>ws , UserName);
        cout<<"Enter Passowrd ? ";
        getline(cin,Password);
        LoginFaild=!LoadUserInfo(UserName,Password);
    }while(LoginFaild);
    ShowMainMenue();
}


int main()
{
    Login();
    return 0;
}
