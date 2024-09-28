using System;
using System.Collections.Generic;


namespace BankSystem
{
    public class clsAddNewClientScreen:clsScreen
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
        public static void ShowAddNewClient()
        {
            if (!CheckAccessRights(clsUser.enMainMenueParmissions.pAddNewClient))
                return;
            _ClearScreen();
            string Title = "Add New Client Screen";
            _DrawScreenHeader(Title);
            string AccountNumber;
            Console.Write("\nPlease Enter  Account Number : ");
            AccountNumber = Console.ReadLine();
            while (clsBankClient.IsClientExist(AccountNumber))
            {
                Console.Write("\nAccount Number is  already exist , Choose anthore one : ");
                AccountNumber = Console.ReadLine();
            }
            clsBankClient NewClient = clsBankClient.GetAddNewClientObject(AccountNumber);
            ReadClientInfo(NewClient);
            clsBankClient.enSaveResult SaveResult = NewClient.Save();
            switch (SaveResult)
            {
                case clsBankClient.enSaveResult.svSucceeded:
                    Console.WriteLine("\nClient Add Successflly :-)");
                    NewClient.Print();
                    break;
                case clsBankClient.enSaveResult.svFaild:
                    Console.WriteLine("\nError Client was not  Add  :-(");
                    break;
            }
        }
    }
}
