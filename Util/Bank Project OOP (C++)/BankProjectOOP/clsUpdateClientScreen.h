#pragma once
#include<iostream>
#include"clsInputValidate.h"
#include"clsBankClient.h"
#include"clsScreen.h"
using namespace std;
class clsUpdateClientScreen:protected clsScreen
{
private:
    static void _ReadClientInfo(clsBankClient& Client)
    {
        cout << "\n Enter First Name : ";
        Client.FirstName = clsInputValidate::ReadString<string>();
        cout << "\n Enter Last Name : ";
        Client.LastName = clsInputValidate::ReadString<string>();
        cout << "\n Enter Email : ";
        Client.Email = clsInputValidate::ReadString<string>();
        cout << "\n Enter Phone : ";
        Client.Phone = clsInputValidate::ReadString<string>();
        cout << "\n Enter Pin Code : ";
        Client.PinCode = clsInputValidate::ReadString<string>();
        cout << "\n Enter Balance : ";
        Client.AccountBalance = clsInputValidate::ReadNumber<float>();
    }
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
	static void ShowUpdateClientScreen()
	{
        if (!CheckAccessRights(clsUser::enParmissions::pUpdateClient))
        {
            return;
        }
        _DrawScreenHeader("\tUpdate Client Screen");
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
        cout << "\nUpdate Client Info : ";
        cout << "\n\n______________________";
        _ReadClientInfo(Client);
        clsBankClient::enSaveResults SaveResult;
        SaveResult = Client.Save();
        switch (SaveResult)
        {
        case clsBankClient::enSaveResults::svFaildEmptyObject:
            cout << "\nErrore Account was not saved because it's Empty ";
            break;
        case clsBankClient::enSaveResults::svSucceeded:
            cout << "\nAccount Update Successfully :-)\n";
            _PrintClient(Client);
            break;
        }
	}
};

