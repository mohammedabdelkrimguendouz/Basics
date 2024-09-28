#pragma once
#include<iostream>
#include<iomanip>
#include"clsScreen.h"
#include"clsBankClient.h"
#include"clsUtil.h"
class clsTotalBalancesSecreen:protected clsScreen
{
private:
    static void _PrintClientRecordBalnceLine(clsBankClient Client)
    {
        cout << setw(8) << left << "" << "| " << setw(15) << left << Client.AccountNumber();
        cout << "| "  <<setw(40)<< left <<  Client.FullName();
        cout << "| " << setw(12)<< left  << Client.AccountBalance;
    }
public:
    
    static void ShowTotalBalances()
    {
        vector<clsBankClient> vClients = clsBankClient::GetClientsList();
        string Title = "\t List Balances Secreen";
        string SubTitle = "\t   (" + to_string(vClients.size()) + ") Client(s).";
        _DrawScreenHeader(Title, SubTitle);
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________\n" << endl;
        cout << setw(8) << left << "" << "| " << setw(15) << left << "Account Number";
        cout << "| " << left << setw(40) << "Client Name";
        cout << "| " << left << setw(12) << "Balance";
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
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
                _PrintClientRecordBalnceLine(Client);
                cout << endl;
            }
        }
        cout << setw(8) << left << "" << "\n\t______________________________________________________";
        cout << "______________________________________________\n" << endl;
        cout << "\n\t\t\t\t\t Total Balances =  " << TotalBalnces;
        cout << "\n\t\t\t\t\t( " << clsUtil::NumberToText(TotalBalnces) << " )\n";
    }
};

