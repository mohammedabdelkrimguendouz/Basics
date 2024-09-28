#pragma once
#include<iostream>
#include"clsInputValidate.h"
#include"clsMainScreen.h"
#include"clsScreen.h"
#include"clsUser.h"
#include"Global.h"
using namespace std;
class clsLoginScreen:protected clsScreen
{
private:
	static bool _Login()
	{
		 string UserName, Password;
		 bool LoginFaild = false;
		 short FaildLoginCount = 0;
		 do
		 {
			 if (LoginFaild)
			 {
				 FaildLoginCount++;
				 cout << "\nInvalid UserName/Password !";
				 cout << "\nYou have " << (3-FaildLoginCount) << " Trial(s) to login.\n";
				 
			 }
			 if (FaildLoginCount == 3)
			 {
				 cout << "\n\n You are Locked after 3 faild trials\n\n";
				 return false;
			 }
			 cout << "\nPlease Enter User Name : ";
			 UserName = clsInputValidate::ReadString<string>();
			 cout << "Please Enter Password : ";
			 Password = clsInputValidate::ReadString<string>();
			 CurrentUser = clsUser::Find(UserName, Password);
			 LoginFaild = CurrentUser.IsEmpty();
		 } while (LoginFaild);
		 CurrentUser.RegisterLogIn();
		clsMainScreen::ShowMainMenue();
		return true;
	}

public:
	static bool ShowLoginScreen()
	{
		system("cls");
		_DrawScreenHeader("\t   Login Screen");
		return _Login();
	}
};

