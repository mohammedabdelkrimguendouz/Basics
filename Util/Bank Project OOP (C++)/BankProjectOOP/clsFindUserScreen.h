#pragma once
#include<iostream>
#include"clsInputValidate.h"
#include"clsUser.h"
#include"clsScreen.h"
using namespace std;
class clsFindUserScreen:protected clsScreen
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
public:
    static void ShowFindUserScreen()
    {
        _DrawScreenHeader("\t  Find User Screen");
        string UserName = "";
        cout << "Please Enter User Name : ";
        UserName = clsInputValidate::ReadString<string>();
        while (!clsUser::IsUserExist(UserName))
        {
            cout << "Account Number is not found , choose another one : ";
            UserName = clsInputValidate::ReadString<string>();
        }
        clsUser User = clsUser::Find(UserName);
        if (!User.IsEmpty())
        {
            cout << "\nUser Found :-)\n";
        }
        else
        {
            cout << "\nUser Was not Found :-(\n";
        }
        _PrintUser(User);

    }
};

