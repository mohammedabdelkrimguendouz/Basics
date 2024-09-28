#pragma once
#include<iostream>
#include<iomanip>
#include"clsScreen.h"
#include"clsInputValidate.h"
#include"clsDepositScreen.h"
#include"clsWithdrawScreen.h"
#include"clsTotalBalancesSecreen.h"
#include"clsTransferScreen.h"
#include"clsTransferLogScreen.h"
using namespace std;
class clsTransactionsScreen:protected clsScreen
{
private:
	static short _ReadTransactionMenueOption()
	{
		cout << setw(37) << left << "" << "\tChoose what do you want to do? [1 to 6] ? ";
		short Choice = clsInputValidate::ReadNumberBetween<short>(1, 6, "Enter Number Between 1 to 6 ?");
		return Choice;
	}
	enum enTransactionsMenueOptions { eDeposit = 1, eWithdraw = 2,
		eShowTotalBalances = 3,eTransfer=4,eTranferLog=5, eShowMainMenue = 6 };
	static void _GoBackToTransactionsMenue()
	{
		cout << setw(37) << left << "" << "\n\n \tPress any key to go back to Transaction Menue ...  ";
		system("pause>0");
		ShowTransactionsMenue();
	}
	
	static void _ShowDepositScreen()
	{
		clsDepositScreen::ShowDepositScreen();
	}
	static void _ShowWithdrawScreen()
	{
		clsWithdrawScreen::ShowWithdrawScreen();
	}
	static void _ShowTotalBalancesScreen()
	{
		clsTotalBalancesSecreen::ShowTotalBalances();
	}
	static void _ShowTransferScreen()
	{
		clsTransferScreen::ShowTransferScreen();
	}
	static void _ShowTransferLogScreen()
	{
		clsTransferLogScreen::ShowTransferLogScreen();
	}
	static void _PerformTransactionMenueOption(enTransactionsMenueOptions TransactionsMenueOption)
	{
		switch (TransactionsMenueOption)
		{
		case enTransactionsMenueOptions::eDeposit:
			system("cls");
			_ShowDepositScreen();
			_GoBackToTransactionsMenue();
			break;
		case enTransactionsMenueOptions::eWithdraw:
			system("cls");
			_ShowWithdrawScreen();
			_GoBackToTransactionsMenue();
			break;
		case enTransactionsMenueOptions::eShowTotalBalances:
			system("cls");
			_ShowTotalBalancesScreen();
			_GoBackToTransactionsMenue();
			break;
		case enTransactionsMenueOptions::eTransfer:
			system("cls");
			_ShowTransferScreen();
			_GoBackToTransactionsMenue();
			break;
		case enTransactionsMenueOptions::eTranferLog:
			system("cls");
			_ShowTransferLogScreen();
			_GoBackToTransactionsMenue();
			break;
		case enTransactionsMenueOptions::eShowMainMenue:
			break;
		}
	}
public:
	static void ShowTransactionsMenue()
	{
		if (!CheckAccessRights(clsUser::enParmissions::pTransactions))
		{
			return;
		}
		system("cls");
		_DrawScreenHeader("\tTransactions Screen");
		cout << setw(37) << left << "" << "============================================\n";
		cout << setw(37) << left << "" << "\t\tTransactions Menue\n";
		cout << setw(37) << left << "" << "============================================\n";
		cout << setw(37) << left << "" << "\t[1] Deposit.\n";
		cout << setw(37) << left << "" << "\t[2] Withdraw.\n";
		cout << setw(37) << left << "" << "\t[3] Total Balances.\n";
		cout << setw(37) << left << "" << "\t[4] Transfer.\n";
		cout << setw(37) << left << "" << "\t[5] Transfer Log.\n";
		cout << setw(37) << left << "" << "\t[6] Main Menue.\n";
		cout << setw(37) << left << "" << "============================================\n";
		_PerformTransactionMenueOption((enTransactionsMenueOptions)_ReadTransactionMenueOption());
	}
};

