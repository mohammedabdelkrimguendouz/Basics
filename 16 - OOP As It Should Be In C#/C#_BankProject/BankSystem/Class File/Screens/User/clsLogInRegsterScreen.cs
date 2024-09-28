using classLibraryUtil;
using System;
using System.Collections.Generic;


namespace BankSystem
{
    public class clsLogInRegsterScreen:clsScreen
    {
        static private void PrintLogInRegisterRecordLine(clsUser.clsLogInRegister Record)
        {
            Console.WriteLine(String.Format("{0,-35}{1,-40}{2,-20}{3,-20}", "| " + Record.DateTime, "| " + Record.UserName, "| " + Record.Password,"| "+Record.Permissions));

        }
        static public void ShowLogInRegister()
        {
            if (!CheckAccessRights(clsUser.enMainMenueParmissions.pLogInRegister))
                return;
            List<clsUser.clsLogInRegister> ListLogInRegister = clsUser.GetLogInRegisterList();
            _ClearScreen();
            string Title = "Login Register List Screen";
            string SubTitle = $"( {ListLogInRegister.Count} ) Record(s)";
            _DrawScreenHeader(Title, SubTitle);
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            Console.WriteLine(String.Format("{0,-35}{1,-40}{2,-20}{3,-20}", "| Date/Time", "| User Name", "| Password","| Permissions"));
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            double TotalBalances = clsBankClient.GetTotalBalances();
            if (ListLogInRegister.Count == 0)
                Console.WriteLine("\n\t\t\t\\tNo Record Available in the System!");

            else
            {
                foreach (clsUser.clsLogInRegister Record in ListLogInRegister)
                {
                    PrintLogInRegisterRecordLine(Record);
                    Console.Write("\n");
                }
            }
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            
        }
    }
}
