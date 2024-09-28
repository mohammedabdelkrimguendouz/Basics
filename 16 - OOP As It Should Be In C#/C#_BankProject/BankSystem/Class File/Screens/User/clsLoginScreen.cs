using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class clsLoginScreen:clsScreen
    {

       private static bool _Login()
        {
            string UserName, Password;
            byte FaildLoginCount = 0;
            bool LoginFaild = false;
            do
            {
                if (LoginFaild)
                {
                    FaildLoginCount++;
                    Console.WriteLine("\nInvalide UserName OR Password !");

                    Console.WriteLine("You have " + (3 - FaildLoginCount) + " Traile(s) to login");

                }
                if (FaildLoginCount == 3)
                {
                    Console.WriteLine("\n\n\nYou are Locked after 3 faild trails\n\n");
                    return false;
                }

                Console.Write("\nEnter User Name : ");
                UserName = Console.ReadLine();
                Console.Write("\nEnter Password : ");
                Password = Console.ReadLine();
                Global.CurrentUser = clsUser.Find(UserName, Password);
                LoginFaild = (Global.CurrentUser == null);

            } while (LoginFaild);
            Global.CurrentUser.RegisterLogIn();
            clsMainScreen.ShowMainMenue();
            return true;
        }
       public static bool ShowLogin()
       {
            _ClearScreen();
            _DrawScreenHeader("Login Screen");
            return _Login();
       }
    }
}
