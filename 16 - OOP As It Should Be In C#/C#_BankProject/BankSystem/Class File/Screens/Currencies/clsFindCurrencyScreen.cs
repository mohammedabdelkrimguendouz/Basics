using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Class_File.Screens.Currencies
{
    public class clsFindCurrencyScreen:clsScreen
    {
        private static void _PrintCurrency(clsCurrency Currency)
        {
            Console.WriteLine("\nCurrency Card : ");
            Console.WriteLine("__________________________________\n");
            Console.WriteLine($"Country    : {Currency.Country}");
            Console.WriteLine($"Code       : {Currency.CurrencyCode}");
            Console.WriteLine($"Name       : {Currency.CurrencyName}");
            Console.WriteLine($"Rate(1$)   : {Currency.Rate()}");
            Console.WriteLine("___________________________________\n");
        }
        private static string _ReadCurrencyCode()
        {
            Console.Write("Please Enter Currency Code : ");
            return Console.ReadLine();
        }
        private static string  _ReadCurrencyCountryName()
        {
            Console.Write("Please Enter Country Name : ");
            return Console.ReadLine();
        }

        private static void _ShowResult(clsCurrency Currency)
        {
            if (Currency != null)
            {
                Console.WriteLine("\nCurrency Found :-)");
                _PrintCurrency(Currency);
            }
            else
                Console.WriteLine("\nCurrency not Found :-(");
        }
        public static void ShowFindCurrency()
        {
            _ClearScreen();
            string Title = "Find Currency Screen";
            _DrawScreenHeader(Title);
            string FindBy;
            Console.Write("\nFind By: [1] code or [2] Country ? ");
            FindBy = Console.ReadLine();
            clsCurrency CurrencyFind = null;
            
            switch (FindBy)
            {
                case "1":
                     CurrencyFind= clsCurrency.FindByCode(_ReadCurrencyCode());
                    break;
                case "2":
                      CurrencyFind = clsCurrency.FindByCountry(_ReadCurrencyCountryName());
                   break;
            }
            _ShowResult(CurrencyFind);
        }
    }
}
