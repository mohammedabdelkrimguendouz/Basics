using classLibraryUtil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Class_File.Screens.Currencies
{
    public class clsCurrencyExchangeMainScreen :clsScreen
    {
        enum enCurrencyExchangeMenueOptions { eListCurrencies=1,eFindCurrency=2,eUpdateRate=3,eCurrencyCalculator=4
        ,eMainMenue=5}

        static private void _GoBackToCurrencyExchangeMenue()
        {
            Console.Write("\n\n Press any key to go back to Currency Exchange Menue ...  ");
            Console.ReadKey();
            ShowCurrencyExchangeMenue(); 
        }
        static private int _ReadCurrencyExchangeMenueOption()
        {
            Console.Write("\t\t\t\tChoose What do you want do [1-5] : ");
            return clsUtil.ReadNumberBetween(1, 5, "\t\tInvalide Number, Please Enter Agine : ");
        }

        static void _ShowAllCurrenciesScreen()
        {
            clsCurrenciesListScreen.ShowCurrenciesList();
        }

        static void _ShowFindCurrencyScreen()
        {
            clsFindCurrencyScreen.ShowFindCurrency();

        }

        static void _ShowUpdateRateScreen()
        {
            clsUpdateRateScreen.ShowUpdateRate();
        }

        static void _ShowCurrencyCalculatorScreen()
        {
            clsCurrencyCalculatorScreen.ShowCurrencyCalculator();
        }
        static private void _PerformCurrencyExchangeMenueOptions(enCurrencyExchangeMenueOptions CurrencyExchangeMenueOption)
        {
            switch(CurrencyExchangeMenueOption)
            {
                case enCurrencyExchangeMenueOptions.eListCurrencies:
                    _ClearScreen();
                    _ShowAllCurrenciesScreen();
                    _GoBackToCurrencyExchangeMenue();
                    break;
                case enCurrencyExchangeMenueOptions.eFindCurrency:
                    _ClearScreen();
                    _ShowFindCurrencyScreen();
                    _GoBackToCurrencyExchangeMenue();
                    break;
                case enCurrencyExchangeMenueOptions.eUpdateRate:
                    _ClearScreen();
                    _ShowUpdateRateScreen();
                    _GoBackToCurrencyExchangeMenue();
                    break;
                case enCurrencyExchangeMenueOptions.eCurrencyCalculator:
                    _ClearScreen();
                    _ShowCurrencyCalculatorScreen();
                    _GoBackToCurrencyExchangeMenue();
                    break;
                case enCurrencyExchangeMenueOptions.eMainMenue:
                   
                    break;
            }
        }
        static public void ShowCurrencyExchangeMenue()
        {
            
            _ClearScreen();
            _DrawScreenHeader("Currency Exchange Main Screen", "");
            Console.WriteLine("\n\t\t\t\t===================================================");
            Console.WriteLine("\t\t\t\t\t     Currency Exchange Menue");
            Console.WriteLine("\t\t\t\t===================================================");
            Console.WriteLine("\t\t\t\t  [1] List Currencies.");
            Console.WriteLine("\t\t\t\t  [2] Find Currency.");
            Console.WriteLine("\t\t\t\t  [3] Update Rate.");
            Console.WriteLine("\t\t\t\t  [4] Currency Calculator.");
            Console.WriteLine("\t\t\t\t  [5] Main Menue.");
            Console.WriteLine("\t\t\t\t===================================================");
            _PerformCurrencyExchangeMenueOptions((enCurrencyExchangeMenueOptions)_ReadCurrencyExchangeMenueOption());
        }


    }
}
