using System;

namespace BankSystem
{
    public abstract class clsScreen
    {
        protected static void _DrawScreenHeader(String Title, String SubTitle="")
        {
            Console.WriteLine("\t\t\t\t___________________________________________________");
            Console.WriteLine("\n\t\t\t\t\t\t" + Title);
            if (SubTitle != "")
            {
                Console.WriteLine("\t\t\t\t\t\t" + SubTitle);
            }
            Console.WriteLine("\t\t\t\t___________________________________________________");
            if(Global.CurrentUser == null)
                Console.WriteLine("\n\t\t\t\t User : ");
            else
                Console.WriteLine("\n\t\t\t\t User : " + Global.CurrentUser.UserName);
            Console.WriteLine("\n\t\t\t\t Date : " + DateTime.Now.ToString("dd/MM/yyyy")+"\n");
        }
        static protected void _ClearScreen()
        {
            Console.Clear();
        }
        protected static bool CheckAccessRights(clsUser.enMainMenueParmissions Permission)
        {
            if(Global.CurrentUser!=null)
            {
                if(!Global.CurrentUser.CheckAccessPermission(Permission))
                {
                    Console.WriteLine("\t\t\t\t___________________________________________________");
                    Console.WriteLine("\n\t\t\t\t\t Access Denied! contact your admin ");
                    Console.WriteLine("\t\t\t\t___________________________________________________");
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
