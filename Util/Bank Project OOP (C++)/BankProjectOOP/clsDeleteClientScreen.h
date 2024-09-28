#pragma once
#include<iostream>
#include"clsInputValidate.h"
#include"clsBankClient.h"
#include"clsScreen.h"
using namespace std;

class clsDeleteClientScreen:protected clsScreen
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
public:
	static void ShowDeleteClientScreen()
	{
        if (!CheckAccessRights(clsUser::enParmissions::pDeleteClient))
        {
            return;
        }
        _DrawScreenHeader("\t Delete Client Screen");
        string AccountNumber = "";
        cout << "Please Enter Client Account Number : ";
        AccountNumber = clsInputValidate::ReadString<string>();
        while (!clsBankClient::IsClientExist(AccountNumber))
        {
            cout << "Account Number is not found , choose another one : ";
            AccountNumber = clsInputValidate::ReadString<string>();
        }
        clsBankClient Client = clsBankClient::Find(AccountNumber);
        _PrintClient(Client);
        char Answer = 'n';
        cout << "\n Are you sure want to delete this client y/n : ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            if (Client.Delete())
            {
                cout << "\nClient Deleted Successfuly :-)";
                _PrintClient(Client);
            }
            else
            {
               cout << "\nErrore Client was not deleted";
            }
        }
        

	}
};

