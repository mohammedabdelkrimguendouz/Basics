using System;
using System.Collections.Generic;

namespace BankSystem
{
    public class clsDepositBalanceScreen:clsScreen
    {
        static public void ShowDepositBalance()
        {
            _ClearScreen();
            string Title = "Deposite Balance Screen";
            _DrawScreenHeader(Title);
            string AccountNumber;
            Console.Write("\nPlease Enter client Account Number : ");
            AccountNumber = Console.ReadLine();
            while (!clsBankClient.IsClientExist(AccountNumber))
            {
                Console.Write("\nAccount Number is not found , Choose anthore one : ");
                AccountNumber = Console.ReadLine();
            }
            clsBankClient Client = clsBankClient.Find(AccountNumber);
            Client.Print();
            Console.Write("\nPlease enter deposit amount : ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nAre you sure you want perform this transaction ? Y/N ? ");
            var Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
            {
                Client.Deposite(Amount);
                Console.WriteLine("\nDeposit Balance Sucsseflly -)\n");
                Console.WriteLine("New Balance is : "+Client.AccountBalance);
            }
            else
            {
                Console.WriteLine("\nOparation was canclled -(");
            }
        }
    }
}
