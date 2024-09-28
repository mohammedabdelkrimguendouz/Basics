#pragma once
#include<iostream>
#include<iomanip>
#include"clsScreen.h"
#include"clsInputValidate.h"
#include"clsBankClient.h"
class clsWithdrawScreen:protected clsScreen
{
private:
    static void _PrintClient(clsBankClient Client)
    {
        cout << "\nClient Card : ";
        cout << "\n_____________________________";
        cout << "\nFirst Name     : " << Client.FirstName;
        cout << "\nLast Name      : " << Client.LastName;
        cout << "\nFull Name      : " << Client.FullName();
        cout << "\nEmail          : " << Client.Email;
        cout << "\nPhone          : " << Client.Phone;
        cout << "\nAccount Number : " << Client.AccountNumber();
        cout << "\nPassword       : " << Client.PinCode;
        cout << "\nAccountBalance : " << Client.AccountBalance;
        cout << "\n_____________________________\n";
    }
    static string _ReadAccountNumber()
    {
        cout << "\nPlease Enter  Account Number : ";
        return clsInputValidate::ReadString<string>();
    }
public:
    static void ShowWithdrawScreen()
    {
        _DrawScreenHeader("\t   Withdraw Screen");
        string AccountNumber = _ReadAccountNumber();
        while (!clsBankClient::IsClientExist(AccountNumber))
        {
            cout << "\nClient With [" << AccountNumber << "] does not exist.\n";
            AccountNumber = _ReadAccountNumber();
        }
        clsBankClient Client = clsBankClient::Find(AccountNumber);
        _PrintClient(Client);
        double Amount = 0;
        cout << "\nPlease enter Withdraw amount  ?";
        Amount = clsInputValidate::ReadNumber<float>();
        char Answer = 'n';
        cout << "\n Are you sure you want to perfrom this transaction ? y/n : ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            if (Client.Withdraw(Amount))
            {
                cout << "\nAmount Withdraw  Successfuly :-)";
                cout << "\n New Balance is : " << Client.AccountBalance;
            }
            else
            {
                cout << "\ncannot withdraw,Insuffecient Balance!\n";
                cout << "\nAmount Withdraw is : " << Amount;
                cout << "\nYour Balance is : " << Client.AccountBalance;
            }
        }
        else
        {
            cout << "\nOpearation was cancelled.\n";
        }
            
    }    
};