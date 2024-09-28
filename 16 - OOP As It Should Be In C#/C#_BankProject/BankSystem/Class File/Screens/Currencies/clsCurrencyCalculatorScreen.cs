using System;
using System.Collections.Generic;
using System.Net;


namespace BankSystem.Class_File.Screens.Currencies
{
    public class clsCurrencyCalculatorScreen:clsScreen
    {

        private static clsCurrency _ReadCurrency()
        {
            string CurrencyCode=Console.ReadLine();

            while(!clsCurrency.IsCurrencyExist(CurrencyCode))
            {
                Console.Write("\nCurrency not found,Enter anthore one : ");
                CurrencyCode = Console.ReadLine(); 
            }
            return clsCurrency.FindByCode(CurrencyCode);
        }

        private static void _PrintCurrency(clsCurrency Currency)
        {
            Console.WriteLine("__________________________________\n");
            Console.WriteLine($"Country    : {Currency.Country}");
            Console.WriteLine($"Code       : {Currency.CurrencyCode}");
            Console.WriteLine($"Name       : {Currency.CurrencyName}");
            Console.WriteLine($"Rate(1$)   : {Currency.Rate()}");
            Console.WriteLine("___________________________________\n");
        }

        private static void _ShowResultCalcultor(clsCurrency CurrencyFrom,clsCurrency CurrencyTo,double AmountExchange)
        {
            Console.WriteLine("\nConvert From : ");
            _PrintCurrency(CurrencyFrom);
            double CalculatorCurrency = CurrencyFrom.ConvertToCurrency(CurrencyTo, AmountExchange);
            Console.WriteLine(AmountExchange +" "+ CurrencyFrom.CurrencyCode + " = " + CalculatorCurrency+" " + CurrencyTo.CurrencyCode);
        }

        static public void ShowCurrencyCalculator()
        {
            ConsoleKeyInfo Continue ;
            double AmountExchange;
            do
            {
                _ClearScreen();
                _DrawScreenHeader("Currency Calculator Screen");

                Console.Write("\nPlease Enter Currency From Code : ");
                clsCurrency CurrencyFrom = _ReadCurrency();

                Console.Write("\nPlease Enter Currency To Code : ");
                clsCurrency CurrencyTo = _ReadCurrency();

                Console.Write("\nPlease Enter Amount Exchange  : ");
                AmountExchange = Convert.ToDouble(Console.ReadLine());

                _ShowResultCalcultor(CurrencyFrom, CurrencyTo, AmountExchange);
               


                Console.Write("\nDo you want to perform another calculation ? y/n ? ");
                Continue = Console.ReadKey();
            }while(Continue.KeyChar == 'y'|| Continue.KeyChar=='Y');
        }
    }
}
