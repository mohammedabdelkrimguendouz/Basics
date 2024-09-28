#pragma once
#include<iostream>
#include"clsInputValidate.h"
#include"clsUser.h"
#include"clsScreen.h"
using namespace std;
class clsDeleteUserScreen :protected clsScreen
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
    static void ShowDeleteUserScreen()
    {
        _DrawScreenHeader("\t Delete User Screen");
        string UserName = "";
        cout << "Please Enter User Name : ";
        UserName = clsInputValidate::ReadString<string>();
        while (!clsUser::IsUserExist(UserName))
        {
            cout << "User Name is not found , choose another one : ";
            UserName = clsInputValidate::ReadString<string>();
        }
        clsUser User = clsUser::Find(UserName);
        _PrintUser(User);
        char Answer = 'n';
        cout << "\n Are you sure want to delete this User y/n : ";
        cin >> Answer;
        if (Answer == 'y' || Answer == 'Y')
        {
            if (User.Delete())
            {
                cout << "\nUser Deleted  Successfuly :-)";
                _PrintUser(User);
            }
            else
            {
                cout << "\nErrore User was not deleted";
            }
        }


    }
};

