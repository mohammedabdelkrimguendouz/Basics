#pragma once
#include<iostream>
#include<iomanip>
#include"clsScreen.h"
#include"clsInputValidate.h"
#include"clsClientListScreen.h"
#include"clsAddNewClientScreen.h"
#include"clsDeleteClientScreen.h"
#include"clsUpdateClientScreen.h"
#include"clsFindClientScreen.h"
#include"clsTransactionsScreen.h"
#include"clsManageUsersScreen.h"
#include"clsUser.h"
#include"clsLoginScreen.h"
#include"Global.h"
#include"clsLoginRegisterScreen.h"
#include"clsCurrencyExchangeMainScreen.h"
using namespace std;
class clsMainScreen :protected clsScreen
{
private:
	static short _ReadMainMenueOption()
	{
		cout <<setw(37)<<left<<""<< "\tChoose what do you want to do? [1 to 10] ? ";
		short Choice = clsInputValidate::ReadNumberBetween<short>(1, 10,"Enter Number Between 1 to 10 ?");
		return Choice;
	}
	enum enMainMenueOptions { eListClintes = 1, eAddNewClient = 2,
		eDeleteClient = 3, eUpdateClient = 4, eFindClient = 5, eShowTransactionsMenue = 6,
		eManageUsers = 7,eLoginRegister=8,eCurrencyExchange=9, eExit = 10 };
	static void _GoBackToMainMenue()
	{
		cout << setw(37) << left << "" << "\n\n \tPress any key to go back to Main Menue ...  ";
		system("pause>0");
		ShowMainMenue();
	}
	static void _ShowAllClientsListSecreen()
	{
		clsClientListScreen::ShowClientList();
	}
	static void _ShowAddNewClientsSecreen()
	{
		clsAddNewClientScreen::ShowAddNewClientScreen();
	}
	static void _ShowDeleteClientSecreen()
	{
		clsDeleteClientScreen::ShowDeleteClientScreen();
	}
	static void _ShowUpdateClientSecreen()
	{
		clsUpdateClientScreen::ShowUpdateClientScreen();
	}
	static void _ShowFindClientSecreen()
	{
		clsFindClientScreen::ShowFindClientScreen();
	}
	static void _ShowTransactionsMenue()
	{
		clsTransactionsScreen::ShowTransactionsMenue();
	}
	static void _ShowManageUsersMenue()
	{
		clsManageUsersScreen::ShowManageUsersMenue();
	}
	static void _ShowLoginRegisterScreen()
	{
		clsLoginRegisterScreen::ShowLoginRegisterScreen();
	}
	static void _ShowCurrencyExchangeMenue()
	{
		clsCurrencyExchangeMainScreen::ShowCurrenciesMenue();
	}
	static void _Logout()
	{
		CurrentUser = clsUser::Find("", "");
	}
	static void _PerformMainMenueOption(enMainMenueOptions MainMenueOption)
	{
		switch (MainMenueOption)
		{
		case enMainMenueOptions::eListClintes:
			 system("cls");
			 _ShowAllClientsListSecreen();
			_GoBackToMainMenue();
			break;
		case enMainMenueOptions::eAddNewClient:
			system("cls");
			_ShowAddNewClientsSecreen();
			_GoBackToMainMenue();
			break;
		case enMainMenueOptions::eDeleteClient:
			system("cls");
			_ShowDeleteClientSecreen();
			_GoBackToMainMenue();
			break;
		case enMainMenueOptions::eUpdateClient:
			system("cls");
			_ShowUpdateClientSecreen();
			_GoBackToMainMenue();
			break;
		case enMainMenueOptions::eFindClient:
			system("cls");
			_ShowFindClientSecreen();
			_GoBackToMainMenue();
			break;
		case enMainMenueOptions::eShowTransactionsMenue:
			system("cls");
			_ShowTransactionsMenue();
			_GoBackToMainMenue();
			break;
		case enMainMenueOptions::eManageUsers:
			system("cls");
			_ShowManageUsersMenue();
			_GoBackToMainMenue();
			break;
		case enMainMenueOptions::eLoginRegister:
			system("cls");
			_ShowLoginRegisterScreen();
			_GoBackToMainMenue();
			break;
		case enMainMenueOptions::eCurrencyExchange:
			system("cls");
			_ShowCurrencyExchangeMenue();
			_GoBackToMainMenue();
			break;
		case clsMainScreen::eExit:
			system("cls");
			_Logout();
			break;
		default:
			break;
		}
	}
public:
	static void ShowMainMenue()
	{
		 system("cls");
		_DrawScreenHeader("\t\tMain Screen");
		cout << setw(37) << left << "" << "============================================\n";
		cout << setw(37) << left << "" << "\t\t\tMain Menue\n";
		cout << setw(37) << left << "" << "============================================\n";
		cout << setw(37) << left << "" << "\t[1] Show Client List.\n";
		cout << setw(37) << left << "" << "\t[2] Add New Client.\n";
		cout << setw(37) << left << "" << "\t[3] Delete Client.\n";
		cout << setw(37) << left << "" << "\t[4] Update Client Info.\n";
		cout << setw(37) << left << "" << "\t[5] Find Client.\n";
		cout << setw(37) << left << "" << "\t[6] Transaction.\n";
		cout << setw(37) << left << "" << "\t[7] Menage Users.\n";
		cout << setw(37) << left << "" << "\t[8] Login Register.\n";
		cout << setw(37) << left << "" << "\t[9] Currency Exchange.\n";
		cout << setw(37) << left << "" << "\t[10] LogOut.\n";
		cout << setw(37) << left << "" <<"============================================\n";
		_PerformMainMenueOption((enMainMenueOptions)_ReadMainMenueOption());
	}
};

