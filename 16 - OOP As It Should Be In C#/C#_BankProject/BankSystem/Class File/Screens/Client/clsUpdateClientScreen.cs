using System;
using System.Collections.Generic;

namespace BankSystem
{
    public class clsUpdateClientScreen:clsScreen
    {

        private static void ReadClientInfo(clsBankClient Client)
        {
            Console.Write("\nEnter First Name : ");
            Client.FirstName = Console.ReadLine();
            Console.Write("\nEnter Last Name : ");
            Client.LastName = Console.ReadLine();
            Console.Write("\nEnter Email : ");
            Client.Email = Console.ReadLine();
            Console.Write("\nEnter Phone : ");
            Client.Phone = Console.ReadLine();
            Console.Write("\nEnter PinCode : ");
            Client.PinCode = Console.ReadLine();
            Console.Write("\nEnter Account Balance : ");
            Client.AccountBalance = Convert.ToDouble(Console.ReadLine());
        }
        public static void ShowUpdateClient()
        {
            if (!CheckAccessRights(clsUser.enMainMenueParmissions.pUpdateClient))
                return;
            _ClearScreen();
            string Title = "Update Client Screen";
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
            Console.Write("\n\nUpdate Client Info.");
            Console.WriteLine("\n__________________________");
            ReadClientInfo(Client);
            clsBankClient.enSaveResult SaveResult = Client.Save();
            switch (SaveResult)
            {
                case clsBankClient.enSaveResult.svSucceeded:
                    Console.WriteLine("\nUpdate Client Successflly :-)");
                    Client.Print();
                    break;
                case clsBankClient.enSaveResult.svFaild:
                    Console.WriteLine("\nError Client was not Updated  :-(");
                    break;
            }
        }
     
        
    }
}
