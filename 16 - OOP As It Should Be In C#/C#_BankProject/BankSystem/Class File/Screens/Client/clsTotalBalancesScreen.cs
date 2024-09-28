using classLibraryUtil;
using System;
using System.Collections.Generic;


namespace BankSystem
{
    public class clsTotalBalancesScreen:clsScreen
    {
        static private void PrintClientRecordBalanceLine(clsBankClient Client)
        {
            Console.WriteLine(String.Format("{0,-30}{1,-60}{2,-20}", "| " + Client.AccountNumber, "| " + Client.FullName, "| " + Client.AccountBalance));

        }
        static public void ShowTotalBalances()
        {
            List<clsBankClient> ListClient = clsBankClient.GetClientsList();
            _ClearScreen();
            string Title = "Balance List Screen";
            string SubTitle = $"( {ListClient.Count} ) Client(s)";
            _DrawScreenHeader(Title, SubTitle);
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            Console.WriteLine(String.Format("{0,-30}{1,-60}{2,-20}", "| AccountNumber", "| Client Name", "| Account Balance"));
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            double TotalBalances = clsBankClient.GetTotalBalances();
            if (ListClient.Count == 0)
                Console.WriteLine("\n\t\t\t\\tNo Clients Available in the System!");

            else
            {
                foreach (clsBankClient Client in ListClient)
                {
                    PrintClientRecordBalanceLine(Client);
                    Console.Write("\n");
                }
            }
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            Console.WriteLine("\n\t\t\t\t\t\tTotal Balances = " + TotalBalances);
            Console.WriteLine("\n\t\t\t\t\t\t(" + clsUtil.NumberToText((int)TotalBalances) + ")");
        }
    }
}
