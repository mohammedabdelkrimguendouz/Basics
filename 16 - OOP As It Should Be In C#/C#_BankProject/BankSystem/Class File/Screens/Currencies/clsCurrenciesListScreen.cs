using System;
using System.Collections.Generic;


namespace BankSystem.Class_File.Screens.Currencies
{
    public class clsCurrenciesListScreen:clsScreen
    {
        private static void PrintCurrencyRecordLine(clsCurrency Currency)
        {
            Console.WriteLine(
                String.Format("{0,-45}{1,-10}{2,-45}{3,-10}", "| " + Currency.Country, "| " + Currency.CurrencyCode, "| " + Currency.CurrencyName
                , "| " + Currency.Rate()));
        }
        public static void ShowCurrenciesList()
        {

            List<clsCurrency> ListCurrency = clsCurrency.GetCurrenciesList();
            _ClearScreen();
            string Title = "Currencies List Screen";
            string SubTitle = $"( {ListCurrency.Count} ) Currency";
            _DrawScreenHeader(Title, SubTitle);
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            Console.WriteLine(
                String.Format("{0,-45}{1,-10}{2,-45}{3,-10}", "| Country", "| Code", "| Name"
                , "| Rate/(1$)"));
            Console.WriteLine("____________________________________________________________"
                    + "______________________________________________________\n");
            if (ListCurrency.Count == 0)
                Console.WriteLine("\n\t\t\t\tNo Currency Available in the System!");

            else
            {
                foreach (clsCurrency Currency in ListCurrency)
                {
                    PrintCurrencyRecordLine(Currency);
                    Console.Write("\n");
                }
            }
            Console.WriteLine("____________________________________________________________"
                    + "______________________________________________________\n");
        }
    }
}
