#pragma once
#include <iostream>
#include"clsScreen.h"
#include"clsBankClient.h"
#include"clsInputValidate.h"
#include"clsManageUsersScreen.h"
#include<iomanip>
using namespace std;
class clsAddNewClientScreen:protected clsScreen
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

    static void ShowAddNewClientScreen()
    {
        if (!CheckAccessRights(clsUser::enParmissions::pAddNewClient))
        {
            return;
        }
        _DrawScreenHeader("\t  Add New Client Screen");
        string AccountNumber = "";
        cout << "\nPlease Enter Account Number : ";
        AccountNumber = clsInputValidate::ReadString<string>();
        while (clsBankClient::IsClientExist(AccountNumber))
        {
            cout << "\nAccount Number Is Already Used,Choose another one : ";
            AccountNumber = clsInputValidate::ReadString<string>();
        }
        clsBankClient NewClient = clsBankClient::GetAddNewClientObject(AccountNumber);
        _ReadClientInfo(NewClient);
        clsBankClient::enSaveResults SaveResult;
        SaveResult = NewClient.Save();
        switch (SaveResult)
        {
        case clsBankClient::enSaveResults::svFaildEmptyObject:
            cout << "\nErrore Account was not saved because it's Empty ";
            break;
        case clsBankClient::enSaveResults::svSucceeded:
            cout << "\nAccount Addeded  Successfully :-)\n";
            _PrintClient(NewClient);
            break;
        case clsBankClient::enSaveResults::svFaildAccountNumberExist:
            cout << "\nError Acount Number Exist Already !";
            break;
        }

    }
};

