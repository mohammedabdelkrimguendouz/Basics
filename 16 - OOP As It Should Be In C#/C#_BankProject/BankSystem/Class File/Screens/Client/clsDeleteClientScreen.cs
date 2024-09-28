using System;
using System.Collections.Generic;

namespace BankSystem
{
    public class clsDeleteClientScreen:clsScreen
    {
        public static void ShowDeleteClient()
        {
            if (!CheckAccessRights(clsUser.enMainMenueParmissions.pDeleteClient))
                return;
            _ClearScreen();
            string Title = "Delete Client Screen";
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
            Console.Write("\nAre you sure you want to delete this client y/n ? ");
            var Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
            {
                if (Client.Delete())
                {
                    Console.WriteLine("\n\nClient Deleted Successfully :-)\n");
                }
                else
                {
                    Console.WriteLine("\n\nError Client Was Not Deleted :-(\n");
                }
            }
        }
    }
}
