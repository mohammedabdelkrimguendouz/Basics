using System;
using System.Collections.Generic;


namespace BankSystem
{
    public class clsListUsersScreen:clsScreen
    {
        private static void PrintUserRecordLine(clsUser User)
        {
            Console.WriteLine(
                String.Format("{0,-18}{1,-23}{2,-17}{3,-25}{4,-14}{5,-14}", "| " + User.UserName, "| " + User.FullName, "| " + User.Phone
                , "| " + User.Email, "| " + User.Password, "| " + User.Permissions));
        }
        public static void ShowListUsers()
        {
            List<clsUser> ListClient = clsUser.GetUsersList();
            _ClearScreen();
            string Title = "List Users Screen";
            string SubTitle = $"( {ListClient.Count} ) User(s)";
            _DrawScreenHeader(Title, SubTitle);
            Console.WriteLine("\n____________________________________________________________"
                    + "______________________________________________________\n");
            Console.WriteLine(
                String.Format("{0,-18}{1,-23}{2,-17}{3,-25}{4,-14}{5,-14}", "| User Name", "| Full Name", "| Phone"
                , "| Email", "| Password", "| Permissions"));
            Console.WriteLine("____________________________________________________________"
                    + "______________________________________________________\n");
            if (ListClient.Count == 0)
                Console.WriteLine("\n\t\t\t\tNo Users Available in the System!");

            else
            {
                foreach (clsUser User in ListClient)
                {
                    PrintUserRecordLine(User);
                    Console.Write("\n");
                }
            }
            Console.WriteLine("____________________________________________________________"
                    + "______________________________________________________\n");
        }
    }
}
