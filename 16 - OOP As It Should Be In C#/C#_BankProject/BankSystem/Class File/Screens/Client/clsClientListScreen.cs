using System;
using System.Collections.Generic;
namespace BankSystem
{
    public class clsClientListScreen:clsScreen
    {
        private static void PrintClientRecordLine(clsBankClient Client)
        {
            Console.WriteLine(
                String.Format("{0,-18}{1,-23}{2,-17}{3,-25}{4,-14}{5,-14}", "| " + Client.AccountNumber, "| " + Client.FullName, "| " + Client.Phone
                , "| " + Client.Email, "| " + Client.PinCode, "| " + Client.AccountBalance));
        }
        public static void ShowClientsList()
        {
            if (!CheckAccessRights(clsUser.enMainMenueParmissions.pListClintes))
                return;
            List<clsBankClient> ListClient = clsBankClient.GetClientsList();
            _ClearScreen();
            string Title = "Client List Screen";
            string SubTitle = $"( {ListClient.Count} ) Client(s)";
            _DrawScreenHeader(Title, SubTitle);
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            Console.WriteLine(
                String.Format("{0,-18}{1,-23}{2,-17}{3,-25}{4,-14}{5,-14}", "| Account Number", "| Client Name", "| Phone"
                , "| Email", "| Pin Code", "| Account Balance"));
            Console.WriteLine("____________________________________________________________"
                    + "______________________________________________________\n");
            if (ListClient.Count == 0)
                Console.WriteLine("\n\t\t\t\tNo Clients Available in the System!");

            else
            {
                foreach (clsBankClient Client in ListClient)
                {
                    PrintClientRecordLine(Client);
                    Console.Write("\n");
                }
            }
            Console.WriteLine("____________________________________________________________"
                    + "______________________________________________________\n");
        }
    }
}
