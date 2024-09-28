using System;
using System.Collections.Generic;
using System.Security.Policy;


namespace BankSystem
{
    public class clsTransferScreen : clsScreen
    {
        static private void _PrintClinetCard(clsBankClient Client)
        {
            Console.WriteLine("\n\nClient Card : ");
            Console.WriteLine("________________________________\n");
            Console.WriteLine($"Full Name       : {Client.FullName}");
            Console.WriteLine($"Acc Number      : {Client.AccountNumber}");
            Console.WriteLine($"Balance         : {Client.AccountBalance}");
            Console.WriteLine("_________________________________\n");
        }
        private static string _ReadAccountNumber()
        {
            string AccountNumber;
            AccountNumber = Console.ReadLine();
            while (!clsBankClient.IsClientExist(AccountNumber))
            {
                Console.Write("\nAccount Number is not found , Choose anthore one : ");
                AccountNumber = Console.ReadLine();
            }
            return AccountNumber;
        }

        private static double _ReadAmountTransfer(clsBankClient ClientFrom)
        {
            double Amount = Convert.ToDouble(Console.ReadLine());

            while (Amount > ClientFrom.AccountBalance)
            {
                Console.Write("\n\nAmount Exceeds the available Balance ,Enter anther Amount ?  ");
                Amount = Convert.ToDouble(Console.ReadLine());
            }
            return Amount;
        }

        public static void ShowTransfer()
        {
            _ClearScreen();
            string Title = "Transfer Screen";
            _DrawScreenHeader(Title);

            Console.Write("\n\nPlease Enter Account Number to tranfer from  : ");
            clsBankClient ClientFrom = clsBankClient.Find(_ReadAccountNumber());
            _PrintClinetCard(ClientFrom);

            Console.Write("\n\nPlease Enter Account Number to tranfer to  : ");
            clsBankClient ClientTo = clsBankClient.Find(_ReadAccountNumber());
            _PrintClinetCard(ClientTo);

            Console.Write("\n Enter Transfer Amount ? ");

            double Amount = _ReadAmountTransfer(ClientFrom);
            Console.Write("\n\nAre you sure you want to delete this User y/n ? ");
            var Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
            {
                if(ClientFrom.Transfer(ClientTo,Amount,Global.CurrentUser.UserName))
                {
                    Console.WriteLine("\n\nTransfer done successflly");
                    _PrintClinetCard(ClientFrom);
                    _PrintClinetCard(ClientTo);
                }
            }
        }
    }
}
