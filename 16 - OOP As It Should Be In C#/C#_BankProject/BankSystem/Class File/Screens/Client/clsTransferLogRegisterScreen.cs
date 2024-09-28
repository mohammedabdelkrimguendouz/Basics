using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class clsTransferLogRegisterScreen:clsScreen
    {
        static private void PrintTransferLogRegisterRecordLine(clsBankClient.clsTransferLogRegister TransferLog)
        {
            Console.WriteLine(
                String.Format("{0,-23}{1,-15}{2,-15}{3,-21}{4,-21}{5,-18}", "| "+ TransferLog.DateTime, "| "+TransferLog.AccountNumberSource, "| "+TransferLog.AccountNumberDestin
                , "| "+TransferLog.AmountTransfer, "| "+TransferLog.BalanceSource, "| "+TransferLog.BalanceDestin, "| "+TransferLog.CurrentUserName));

        }
        static public void ShowTranferLogRegister()
        {
            List<clsBankClient.clsTransferLogRegister> ListTransferLogRegister = clsBankClient.GetTransferLogRegisterList();
            _ClearScreen();
            string Title = "Transfer Log List Screen";
            string SubTitle = $"( {ListTransferLogRegister.Count} ) Record(s)";
            _DrawScreenHeader(Title, SubTitle);
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            Console.WriteLine(
                String.Format("{0,-23}{1,-15}{2,-15}{3,-21}{4,-21}{5,-18}", "| Date/Time", "| s.Acc", "| d.Acc"
                , "| Amount", "| S.Balanc", "| d.Balance","| User"));
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            double TotalBalances = clsBankClient.GetTotalBalances();
            if (ListTransferLogRegister.Count == 0)
                Console.WriteLine("\n\t\t\t\\tNo Record Available in the System!");

            else
            {
                foreach (clsBankClient.clsTransferLogRegister Transfer in ListTransferLogRegister)
                {
                    PrintTransferLogRegisterRecordLine(Transfer);
                    Console.Write("\n");
                }
            }
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");

        }
    }
}
