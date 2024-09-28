#pragma once
#include<iostream>
#include<iomanip>
#include"clsScreen.h"
#include"clsInputValidate.h"
#include"clsBankClient.h"
class clsTransferScreen:protected clsScreen
{
private:
	static void _PrintClient(clsBankClient Client)
	{
        cout << "\nClient Card : ";
        cout << "\n_____________________________";
        cout << "\nFull Name      : " << Client.FullName();
        cout << "\nAccount Number : " << Client.AccountNumber();
        cout << "\nAccountBalance : " << Client.AccountBalance;
        cout << "\n_____________________________\n";
	}
    static string _ReadAccountNumber()
    {
        string AccountNumber;
        cout << "Please Enter Account Number to transfer  : ";
        AccountNumber = clsInputValidate::ReadString<string>();
        while (!clsBankClient::IsClientExist(AccountNumber))
        {
            cout << "\nAccount Number is not found  ,Choose anthoer one :";
            AccountNumber = clsInputValidate::ReadString<string>();
        }
        return AccountNumber;
    }
    static float _ReadAmount(clsBankClient SourceClient)
    {
        float Amount;
        cout << "\nEnter Transfer Amount : ";
        Amount = clsInputValidate::ReadNumber<float>();
        while (Amount > SourceClient.AccountBalance)
        {
            cout << "Account Exceedsthe available Balance, Enter anthor Amount : ";
            Amount = clsInputValidate::ReadNumber<float>();
        }
        return Amount;
    }
public:
    static void ShowTransferScreen()
    {
        _DrawScreenHeader("\t   Transfer Screen");
        
        clsBankClient SourceClient = clsBankClient::Find(_ReadAccountNumber());
        _PrintClient(SourceClient);
        
        clsBankClient DestinationClient = clsBankClient::Find(_ReadAccountNumber());
        _PrintClient(DestinationClient);
        
        float Amount = _ReadAmount(SourceClient);

        char Answer = 'n';
        cout << "\n Are you sure you want to perfrom this transaction ? y/n : ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            if (SourceClient.Transfer(Amount, DestinationClient,CurrentUser.UserName))
            {
                cout << "\nTransfer done  Successfuly :-)";
            }
            else
            {
                cout << "\nTransfer was Faild.\n";
            }
        }
        _PrintClient(SourceClient);
        _PrintClient(DestinationClient);
    }
};

