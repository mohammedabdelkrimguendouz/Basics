#pragma once
#include<iostream>
#include<iomanip>
#include"clsScreen.h"
#include"clsInputValidate.h"
#include"clsBankClient.h"
using namespace std;
class clsDepositScreen:protected clsScreen
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
    static void ShowDepositScreen()
	{
        _DrawScreenHeader("\t   Deposit Screen");
        string AccountNumber = _ReadAccountNumber();
        while (!clsBankClient::IsClientExist(AccountNumber))
        {
            cout << "\nClient With ["<<AccountNumber<<"] does not exist.\n";
            string AccountNumber = _ReadAccountNumber();
        }
        clsBankClient Client = clsBankClient::Find(AccountNumber);
        _PrintClient(Client);
        double Amount = 0;
        cout << "\nPlease enter deposit amount  ?";
        Amount=clsInputValidate::ReadNumber<double>();
        char Answer = 'n';
        cout << "\n Are you sure you want to perfrom this transaction ? y/n : ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            Client.Deposit(Amount);
            cout << "\nAmount Deposited  Successfuly :-)";
            cout << "\n New Balance is : " << Client.AccountBalance;
        }
        else
        {
            cout << "\nOpearation was cancelled.\n";
        }
	}
};

