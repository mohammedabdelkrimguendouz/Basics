using System;
using System.Collections.Generic;

namespace BankSystem
{
    public class clsFindClientScreen:clsScreen
    {
        public static void ShowFindClient()
        {
            if (!CheckAccessRights(clsUser.enMainMenueParmissions.pFindClient))
                return;
            _ClearScreen();
            string Title = "Find Client Screen";
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
        }
    }
}
