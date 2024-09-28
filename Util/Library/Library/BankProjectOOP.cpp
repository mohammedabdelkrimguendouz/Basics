#include <iostream>
#include"clsBankClient.h"
#include"clsInputValidate.h"
#include"clsUtil.h"
#include<iomanip>
using namespace std;

void ReadClientInfo(clsBankClient &Client)
{
    cout << "\n Enter First Name : ";
    Client.FirstName = clsInputValidate::ReadString();
    cout << "\n Enter Last Name : ";
    Client.LastName = clsInputValidate::ReadString();
    cout << "\n Enter Email : ";
    Client.Email = clsInputValidate::ReadString();
    cout << "\n Enter Phone : ";
    Client.Phone = clsInputValidate::ReadString();
    cout << "\n Enter Pin Code : ";
    Client.PinCode = clsInputValidate::ReadString();
    cout << "\n Enter Balance : ";
    Client.AccountBalance = clsInputValidate::ReadFloatNumber();
}

void UpdateClient()
{
    string AccountNumber = "";
    cout << "Please Enter Client Account Number : ";
    AccountNumber = clsInputValidate::ReadString();
    while (!clsBankClient::IsClientExist(AccountNumber))
    {
        cout << "Account Number is not found , choose another one : ";
        AccountNumber = clsInputValidate::ReadString();
    }
    clsBankClient Client = clsBankClient::Find(AccountNumber);
    Client.Print();
    cout << "\nUpdate Client Info : ";
    cout << "\n\n______________________";
    ReadClientInfo(Client);
    clsBankClient::enSaveResults SaveResult;
    SaveResult=Client.Save();
    switch (SaveResult)
    {
    case clsBankClient::enSaveResults::svFaildEmptyObject:
        cout << "\nErrore Account was not saved because it's Empty ";
        break;
    case clsBankClient::enSaveResults::svSucceeded:
        cout << "\nAccount Update Successfully :-)\n";
        Client.Print();
        break;
    }
    
}

void AddNewClient()
{
    string AccountNumber = "";
    cout << "\nPlease Enter Account Number : ";
    AccountNumber = clsInputValidate::ReadString();
    while (clsBankClient::IsClientExist(AccountNumber))
    {
        cout << "\nAccount Number Is Already Used,Choose another one : ";
        AccountNumber = clsInputValidate::ReadString();
    }
    clsBankClient NewClient = clsBankClient::GetAddNewClientObject(AccountNumber);
    ReadClientInfo(NewClient);
    clsBankClient::enSaveResults SaveResult;
    SaveResult = NewClient.Save();
    switch (SaveResult)
    {
    case clsBankClient::enSaveResults::svFaildEmptyObject:
        cout << "\nErrore Account was not saved because it's Empty ";
        break;
    case clsBankClient::enSaveResults::svSucceeded:
        cout << "\nAccount Addeded  Successfully :-)\n";
        NewClient.Print();
        break;
    case clsBankClient::enSaveResults::svFaildAccountNumberExist:
        cout << "\nError Acount Number Exist Already !";
        break;
    }

}

void DeleteClient()
{
    string AccountNumber = "";
    cout << "Please Enter Client Account Number : ";
    AccountNumber = clsInputValidate::ReadString();
    while (!clsBankClient::IsClientExist(AccountNumber))
    {
        cout << "Account Number is not found , choose another one : ";
        AccountNumber = clsInputValidate::ReadString();
    }
    clsBankClient Client = clsBankClient::Find(AccountNumber);
    Client.Print();
    char Answer = 'n';
    cout << "\n Are you sure want to delete this client y/n : ";
    cin >> Answer;
    if (Answer == 'y' || Answer == 'Y')
    {
        if (Client.Delete())
        {
            cout << "\nDelete Client Successfuly -)";
            Client.Print();
        }
        else
        {
            cout << "\nErrore Client was not deleted";
        }
    }
}

void PrintClientRecordLine(clsBankClient Client)
{
    cout << "| " << left << setw(15) << Client.AccountNumber();
    cout << "| " << left << setw(20) << Client.FullName();
    cout << "| " << left << setw(12) << Client.Phone;
    cout << "| " << left << setw(20) << Client.Email;
    cout << "| " << left << setw(12) << Client.PinCode;
    cout << "| " << left << setw(12) << Client.AccountBalance;
}

void ShowClientList()
{
    vector<clsBankClient> vClients = clsBankClient::GetClientsList();
    cout << "\n\t\t\t\t\t Client List(" << vClients.size() << ") Client(s)\n\n";
    cout << "\n______________________________________________________";
    cout << "______________________________________________\n" << endl;
    cout << "| " << left << setw(15) << "Account Number";
    cout << "| " << left << setw(20) << "Client Name";
    cout << "| " << left << setw(12) << "Phone";
    cout << "| " << left << setw(20) << "Email";
    cout << "| " << left << setw(10) << "Pin Code";
    cout << "| " << left << setw(12) << "Balance";
    cout << "\n______________________________________________________";
    cout << "______________________________________________\n" << endl;
    if (vClients.size() == 0)
    {
        cout << "\t\t\t\tNo Clients Available In The System!";
    }
    else
    {
        for (clsBankClient Client : vClients)
        {
            PrintClientRecordLine(Client);
            cout << endl;
        }
    }
    cout << "\n______________________________________________________";
    cout << "______________________________________________\n" << endl;
}

void PrintClientRecordBalnceLine(clsBankClient Client)
{
    cout << "| " << left << setw(15) << Client.AccountNumber();
    cout << "| " << left << setw(40) << Client.FullName();
    cout << "| " << left << setw(12) << Client.AccountBalance;
}
void ShowTotalBalances()
{
    vector<clsBankClient> vClients = clsBankClient::GetClientsList();
    cout << "\n\t\t\t\t Balances List(" << vClients.size() << ") Client(s)\n\n";
    cout << "\n______________________________________________________";
    cout << "______________________________________________\n" << endl;
    cout << "| " << left << setw(15) << "Account Number";
    cout << "| " << left << setw(40) << "Client Name";
    cout << "| " << left << setw(12) << "Balance";
    cout << "\n______________________________________________________";
    cout << "______________________________________________\n" << endl;
    double TotalBalnces = clsBankClient::GetTotalBalances();
    if (vClients.size() == 0)
    {
        cout << "\t\t\t\tNo Clients Available In The System!";
    }
    else
    {

        for (clsBankClient Client : vClients)
        {
            PrintClientRecordBalnceLine(Client);
            cout << endl;
        }
    }
    cout << "\n______________________________________________________";
    cout << "______________________________________________\n" << endl;
    cout << "\n\t\t\t\t\t Total Balances =  " << TotalBalnces ;
    cout <<"\n\t\t\t\t\t( "<< clsUtil::NumberToText(TotalBalnces)<<" )\n";
}
int main()
{
    //UpdateClient();
    //AddNewClient();
    //DeleteClient();
    //ShowClientList();
    ShowTotalBalances();
    return 0;
}
