#pragma once
#include <iostream>
#include"clsScreen.h"
#include"clsUser.h"
#include"clsInputValidate.h"
#include<iomanip>
using namespace std;
class clsAddNewUserScreen:protected clsScreen
{
private:
    static int _ReadPermissionsToSet()
    {
        int Permissions = 0;
        char Answer = 'n';
        cout << "\nDo you want to giv full access ? Y/N ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') return -1;
        cout << "\ndo you want to giv  access to : \n";
        cout << "\nShow Clients List ? Y/N ?";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pListClients;
        cout << "\nAdd New Client ? Y/N ?";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pAddNewClient;
        cout << "\nDelete Client ? Y/N ? ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pDeleteClient;
        cout << "\nUpdate Client ? Y/N ?";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y') Permissions += clsUser::enParmissions::pUpdateClient;
        cout << "\nFind Client ? Y/N ? ";
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
public:
    static void ShowAddNewUserScreen()
    {
        _DrawScreenHeader("\t  Add New User Screen");
        string UserName = "";
        cout << "\nPlease Enter User Name : ";
        UserName = clsInputValidate::ReadString<string>();
        while (clsUser::IsUserExist(UserName))
        {
            cout << "\nUser Name Is Already Used,Choose another one : ";
            UserName = clsInputValidate::ReadString<string>();
        }
        clsUser NewUser = clsUser::GetAddNewUserObject(UserName);
        _ReadUserInfo(NewUser);
        clsUser::enSaveResults SaveResult;
        SaveResult = NewUser.Save();
        switch (SaveResult)
        {
        case clsUser::enSaveResults::svFaildEmptyObject:
            cout << "\nErrore User was not saved because it's Empty ";
            break;
        case clsUser::enSaveResults::svSucceeded:
            cout << "\nUser Addeded  Successfully :-)\n";
            _PrintUser(NewUser);
            break;
        case clsUser::enSaveResults::svFaildUserNameExist:
            cout << "\nError User Name Exist Already !";
            break;
        }

    }
};

