using classLibraryUtil;
using System;
using System.Collections.Generic;

namespace BankSystem
{
    public class clsTransactionsScreen:clsScreen
    {
        enum enTranactionsMenueOptions
        {
            eDeposite = 1, eWithdraw = 2, eShowTotalBalance = 3, eTransfer = 4,
            eTransferLog=5,eShowMainMenue = 6,

        };
        static private void _GoBackToTransactionsMenue()
        {
            Console.Write("\n\n Press any key to go back to Transactions Menue ...  ");
            Console.ReadKey();
            ShowTransactionsMenue();
        }
        static private int _ReadTransactionsMenueOption()
        {
            Console.Write("\t\t\t\tChoose What do you want do [1-6] : ");
            return clsUtil.ReadNumberBetween(1, 6, "\t\tInvalide Number, Please Enter Agine : ");
        }

        static private void _ShowDepositeScreen()
        {
            clsDepositBalanceScreen.ShowDepositBalance();
        }
        static private void _ShowWithdrawScreen()
        {
            clsWithdrawBalanceScreen.ShowWithdrawBalance();
        }
        static private void _ShowTotalBalancesScreen()
        {
            clsTotalBalancesScreen.ShowTotalBalances();
        }
        static private void _ShowTransferScreen()
        {
            clsTransferScreen.ShowTransfer();
        }
        static private void _ShowTransferLogScreen()
        {
            clsTransferLogRegisterScreen.ShowTranferLogRegister();
        }


        static private void _PerformTransactionsMenueOptions(enTranactionsMenueOptions TranactionsMenueOption)
        {
            switch(TranactionsMenueOption)
            {
                case enTranactionsMenueOptions.eDeposite:
                    _ClearScreen();
                    _ShowDepositeScreen();
                    _GoBackToTransactionsMenue();
                    break;
                case enTranactionsMenueOptions.eWithdraw:
                    _ClearScreen();
                    _ShowWithdrawScreen();
                    _GoBackToTransactionsMenue();
                    break;
                case enTranactionsMenueOptions.eShowTotalBalance:
                    _ClearScreen();
                    _ShowTotalBalancesScreen();
                    _GoBackToTransactionsMenue();
                    break;
                case enTranactionsMenueOptions.eTransfer:
                    _ClearScreen();
                    _ShowTransferScreen();
                    _GoBackToTransactionsMenue();
                    break;
                case enTranactionsMenueOptions.eTransferLog:
                    _ClearScreen();
                    _ShowTransferLogScreen();
                    _GoBackToTransactionsMenue();
                    break;
                case enTranactionsMenueOptions.eShowMainMenue:
                    
                    break;
            }
        }
        static public void ShowTransactionsMenue()
        {
            if (!CheckAccessRights(clsUser.enMainMenueParmissions.pShowTransactionsMenue))
                return;
            _ClearScreen();
            _DrawScreenHeader("  Transactions  Screen", "");
            Console.WriteLine("\n\t\t\t\t===================================================");
            Console.WriteLine("\t\t\t\t\t\t     Transactions Menue");
            Console.WriteLine("\t\t\t\t===================================================");
            Console.WriteLine("\t\t\t\t  [1] Deposite.");
            Console.WriteLine("\t\t\t\t  [2] Withdraw.");
            Console.WriteLine("\t\t\t\t  [3] Total Balance.");
            Console.WriteLine("\t\t\t\t  [4] Transfer.");
            Console.WriteLine("\t\t\t\t  [5] Transfer Log.");
            Console.WriteLine("\t\t\t\t  [6] Main Menue.");
            Console.WriteLine("\t\t\t\t===================================================");
            _PerformTransactionsMenueOptions((enTranactionsMenueOptions)_ReadTransactionsMenueOption());
        }
    }
}
