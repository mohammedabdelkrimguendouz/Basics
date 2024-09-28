using System;
using System.Collections.Generic;


namespace BankSystem
{
    public class clsFindUserScreen:clsScreen
    {
        public static void ShowFindUser()
        {
            _ClearScreen();
            string Title = "Find User Screen";
            _DrawScreenHeader(Title);
            string UserName;
            Console.Write("\nPlease Enter User Name : ");
            UserName = Console.ReadLine();
            while (!clsUser.IsUserExist(UserName))
            {
                Console.Write("\nUser Name is not found , Choose anthore one : ");
                UserName = Console.ReadLine();
            }
            clsUser User = clsUser.Find(UserName);
            User.Print();
        }
    }
}
