using System;
using System.Collections.Generic;


namespace BankSystem
{
    public class clsDeleteUserScreen:clsScreen
    {
        public static void ShowDeleteUser()
        {
            _ClearScreen();
            string Title = "Delete User Screen";
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
            Console.Write("\nAre you sure you want to delete this User y/n ? ");
            var Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
            {
                if (User.Delete())
                {
                    Console.WriteLine("\n\nUser Deleted Successfully :-)\n");
                }
                else
                {
                    Console.WriteLine("\n\nError User Was Not Deleted :-(\n");
                }
            }
        }
    }
}
