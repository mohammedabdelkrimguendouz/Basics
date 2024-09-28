#pragma once
#include<iostream>
#include"clsInputValidate.h"
#include"clsUser.h"
#include"clsScreen.h"
using namespace std;
class clsUpdateUserScreen :protected clsScreen
{
private:
    static void _PrintUser(clsUser User)
    {
        cout << "\nUser Card : ";
        cout << "\n_____________________________";
        cout << "\nFirst Name     : " << User.FirstName;
        cout << "\nLast Name      : " << User.LastName;
        cout << "\nFull Name      : " << User.FullName();
        cout << "\nEmail          : " << User.Email;
        cout << "\nPhone          : " << User.Phone;
        cout << "\nUser Name      : " << User.UserName;
        cout << "\nPassword       : " << User.Password;
        cout << "\nPermissions    : " << User.Permissions;
        cout << "\n_____________________________\n";
    }
    static int _ReadPermissionsToSet()
    {
        int Permissions = 0;
        char Answer = 'n';
        cout << "\nDo you want to giv full access ? Y/N ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') return -1;
        cout << "\ndo you want to giv  access to : \n";
        cout << "\nShow Users List ? Y/N ?";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pListClients;
        cout << "\nAdd New User ? Y/N ?";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pAddNewClient;
        cout << "\nDelete User ? Y/N ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pDeleteClient;
        cout << "\nUpdate User ? Y/N ?";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pUpdateClient;
        cout << "\nFind User ? Y/N ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pFindClient;
        cout << "\nTransactions  ? Y/N ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pTransactions;
        cout << "\nMange Users  ? Y/N ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pManageUsers;
        cout << "\nShow Login Register  ? Y/N ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pShowLogInRegister;
        return Permissions;
    }
    static void _ReadUserInfo(clsUser& User)
    {
        cout << "\nEnter First Name : ";
        User.FirstName = clsInputValidate::ReadString<string>();
        cout << "\nEnter Last Name : ";
        User.LastName = clsInputValidate::ReadString<string>();
        cout << "\nEnter Email : ";
        User.Email = clsInputValidate::ReadString<string>();
        cout << "\nEnter Phone : ";
        User.Phone = clsInputValidate::ReadString<string>();
        cout << "\nEnter Password : ";
        User.Password = clsInputValidate::ReadString<string>();
        cout << "\nEnter Permissions : ";
        User.Permissions = _ReadPermissionsToSet();
    }
public:
    static void ShowUpdateUserScreen()
    {
        _DrawScreenHeader("\tUpdate User Screen");
        string UserName = "";
        cout << "Please Enter User Name : ";
        UserName = clsInputValidate::ReadString<string>();
        while (!clsUser::IsUserExist(UserName))
        {
            cout << "Account Number is not found , choose another one : ";
            UserName = clsInputValidate::ReadString<string>();
        }
        clsUser User = clsUser::Find(UserName);
        _PrintUser(User);
        char Answer = 'n';
        cout << "\nAre you sure you want to update this User Y/N ?";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            cout << "\n\nUpdate User Info : ";
            cout << "\n_________________________ \n";
            _ReadUserInfo(User);
            clsUser::enSaveResults SaveResult;
            SaveResult = User.Save();
            switch (SaveResult)
            {
            case clsUser::enSaveResults::svFaildEmptyObject:
                cout << "\nErrore User was not saved because it's Empty ";
                break;
            case clsUser::enSaveResults::svSucceeded:
                cout << "\nUser Update Successfully :-)\n";
                _PrintUser(User);
                break;
            }
        }
    }
};

