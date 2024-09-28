using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Class_File.Screens.Currencies
{
    public class clsUpdateRateScreen:clsScreen
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

        private static double _ReadRate()
        {
            Console.Write("\nPlease Enter New Rate : ");
            return Convert.ToDouble(Console.ReadLine());
        }
        public static void ShowUpdateRate()
        {
            _ClearScreen();
            string Title = "Update Rate Screen";
            _DrawScreenHeader(Title);

            string CurrencyCode;
            Console.Write("\nPlease Enter Currency Code : ");
            CurrencyCode = Console.ReadLine();

            while(!clsCurrency.IsCurrencyExist(CurrencyCode))
            {
                Console.Write("\nCurrency is not found Please choose anthore one : ");
                CurrencyCode = Console.ReadLine();
            }
            clsCurrency Currency = clsCurrency.FindByCode(CurrencyCode);
            _PrintCurrency(Currency);

            Console.Write("\nAre you sure you want to Update this Rate y/n ? ");
            var Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
            {
                Console.Write("\n\nUpdate Rate .");
                Console.WriteLine("\n__________________________");
                Currency.UpdateRate(_ReadRate());
                Console.WriteLine("\n\nCurrency Rate Updated Successfully :-)");
                _PrintCurrency(Currency);
            }

            
            
        }
    }
}
