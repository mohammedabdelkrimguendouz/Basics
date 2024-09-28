using BankSystem.Class_File.Screens.Currencies;
using classLibraryUtil;
using System;

namespace BankSystem
{
    public class clsMainScreen :clsScreen
    {
        
        enum enMainMenueOptions { eListClintes = 1, eAddNewClient = 2, eDeleteClient = 3, eUpdateClient = 4,
            eFindClient = 5, eShowTransactionsMenue = 6, eManageUsers = 7,eLogInRegister=8,eCurrencyExchange=9, eLogout = 10 };
        static private void _GoBackToMainMenue()
        {
            Console.Write("\n\n Press any key to go back to Main Menue ...  ");
            Console.ReadKey();
            ShowMainMenue();
        }
        static private int _ReadMainMenueOption()
        {
            Console.Write("\t\t\t\tChoose What do you want do [1-10] : ");
            return clsUtil.ReadNumberBetween(1,10, "\t\tInvalide Number, Please Enter Agine : ");
        }

        private static void _ShowAllClientsScreen()
        {
            clsClientListScreen.ShowClientsList();

        }
        private static void _ShowAddNewClientsScreen()
        {
            clsAddNewClientScreen.ShowAddNewClient();
        }
        static void _ShowDeleteClientScreen()
        {
            clsDeleteClientScreen.ShowDeleteClient();
        }
        static void _ShowUpdateClientScreen()
        {
            clsUpdateClientScreen.ShowUpdateClient();
        }
        static void _ShowFindClientScreen()
        {
            clsFindClientScreen.ShowFindClient();
        }
        static void _ShowTransactionsMenue()
        {
            clsTransactionsScreen.ShowTransactionsMenue();
        }
        static void _ShowManageUsersMenue()
        {
            clsManageUsersScreen.ShowManageUsersMenue();
        }

        static void _ShowLogInRegisterScreen()
        {
            clsLogInRegsterScreen.ShowLogInRegister();
        }
        static void _Logout()
        {
            Global.CurrentUser = clsUser.Find("", "");
        }

        static void _ShowCurrencyExchangeScreen()
        {
            clsCurrencyExchangeMainScreen.ShowCurrencyExchangeMenue();
        }
        static private void _PerformMainMenueOption(enMainMenueOptions MainMenueOption)
        {
            switch(MainMenueOption) 
            {
                case enMainMenueOptions.eListClintes:
                    _ClearScreen();
                    _ShowAllClientsScreen();
                    _GoBackToMainMenue();
                    break;
                case enMainMenueOptions.eAddNewClient:
                    _ClearScreen();
                    _ShowAddNewClientsScreen();
                    _GoBackToMainMenue();
                    break;
                case enMainMenueOptions.eDeleteClient:
                    _ClearScreen();
                    _ShowDeleteClientScreen();
                    _GoBackToMainMenue();
                    break;
                case enMainMenueOptions.eUpdateClient:
                    _ClearScreen();
                    _ShowUpdateClientScreen();
                    _GoBackToMainMenue();
                    break;
                case enMainMenueOptions.eFindClient:
                    _ClearScreen();
                    _ShowFindClientScreen();
                    _GoBackToMainMenue();
                    break;
                case enMainMenueOptions.eShowTransactionsMenue:
                    _ClearScreen();
                    _ShowTransactionsMenue();
                    _GoBackToMainMenue();
                    break;
                case enMainMenueOptions.eManageUsers:
                    _ClearScreen();
                    _ShowManageUsersMenue();
                    _GoBackToMainMenue();
                    break;
                case enMainMenueOptions.eLogInRegister:
                    _ClearScreen();
                    _ShowLogInRegisterScreen();
                    _GoBackToMainMenue();
                    break;
                case enMainMenueOptions.eCurrencyExchange:
                    _ClearScreen();
                    _ShowCurrencyExchangeScreen();
                    _GoBackToMainMenue();
                    break;
                case enMainMenueOptions.eLogout:
                    _ClearScreen();
                    _Logout();
                   // clsLoginScreen.ShowLogin();
                    break;
                
            }

        }

        static public void ShowMainMenue()
        {
            _ClearScreen();
            _DrawScreenHeader("   Main Screen","");
            Console.WriteLine("\n\t\t\t\t===================================================");
            Console.WriteLine("\t\t\t\t\t\t     Main Menue");
            Console.WriteLine("\t\t\t\t===================================================");
            Console.WriteLine("\t\t\t\t  [1] Show Client List.");
            Console.WriteLine("\t\t\t\t  [2] Add New Client.");
            Console.WriteLine("\t\t\t\t  [3] Delete Client.");
            Console.WriteLine("\t\t\t\t  [4] Update Client.");
            Console.WriteLine("\t\t\t\t  [5] Find Client.");
            Console.WriteLine("\t\t\t\t  [6] Transactions.");
            Console.WriteLine("\t\t\t\t  [7] Manage Users.");
            Console.WriteLine("\t\t\t\t  [8] Login Register.");
            Console.WriteLine("\t\t\t\t  [9] Currency Exchange.");
            Console.WriteLine("\t\t\t\t  [10] LogOut.");
            Console.WriteLine("\t\t\t\t===================================================");
            _PerformMainMenueOption((enMainMenueOptions)_ReadMainMenueOption());
        }

    }
}
