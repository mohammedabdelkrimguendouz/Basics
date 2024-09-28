using System;
using System.Collections.Generic;


namespace BankSystem
{
    public class clsWithdrawBalanceScreen:clsScreen
    {
        static private double _ReadAmount(clsBankClient Client)
        {
            Console.Write("\nPlease enter Withdraw amount : ");
            double Amount = Convert.ToDouble(Console.ReadLine());
            while (Amount < 0 || Amount > Client.AccountBalance)
            {
                Console.WriteLine("\n Error, Your Balance is :" + Client.AccountBalance);
                Console.Write("\nPlease enter Withdraw amount : ");
                Amount = Convert.ToDouble(Console.ReadLine());
            }
            return Amount;
        }
        public static void ShowWithdrawBalance()
        {
            _ClearScreen();
            string Title = "Withdraw Balance Screen";
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
            double Amount=_ReadAmount(Client);
            Console.Write("\nAre you sure you want perform this transaction ? Y/N ? ");
            var Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
            {
                Client.Withdraw(Amount);
                Console.WriteLine("\nWithdarw Balance Sucsseflly -)\n");
                Console.WriteLine("New Balance is : " + Client.AccountBalance);
            }
            else
            {
                Console.WriteLine("\nOparation was canclled -(");
            }
        }
    }
}
