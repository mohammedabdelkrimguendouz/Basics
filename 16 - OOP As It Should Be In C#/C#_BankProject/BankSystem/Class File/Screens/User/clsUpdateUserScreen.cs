using System;
using System.Collections.Generic;


namespace BankSystem
{
    public class clsUpdateUserScreen:clsScreen
    {
        private static int _ReadPermissionsToSet()
        {
            int Permissions = 0;
            ConsoleKeyInfo Answer;
            Console.Write("\nDo you want to give full access ? y/n ? ");
            Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
                return Permissions = -1;
            Console.WriteLine("\nDo you want to give  access to : ");
            Console.Write("\nShow List Client ? y/n ? ");
            Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
                Permissions += (int)clsUser.enMainMenueParmissions.pListClintes;
            Console.Write("\nAdd New Client ? y/n ? ");
            Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
                Permissions += (int)clsUser.enMainMenueParmissions.pAddNewClient;
            Console.Write("\nDelete Client ? y/n ? ");
            Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
                Permissions += (int)clsUser.enMainMenueParmissions.pDeleteClient;
            Console.Write("\nUpdate Client ? y/n ? ");
            Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
                Permissions += (int)clsUser.enMainMenueParmissions.pUpdateClient;
            Console.Write("\nFind Client ? y/n ? ");
            Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
                Permissions += (int)clsUser.enMainMenueParmissions.pFindClient;
            Console.Write("\nTransactions ? y/n ? ");
            Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
                Permissions += (int)clsUser.enMainMenueParmissions.pShowTransactionsMenue;
            Console.Write("\nManage User ? y/n ? ");
            Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
                Permissions += (int)clsUser.enMainMenueParmissions.pManageUsers;
            Console.Write("\nLogIn Register ? y/n ? ");
            Answer = Console.ReadKey();
            if (Answer.KeyChar == 'Y' || Answer.KeyChar == 'y')
                Permissions += (int)clsUser.enMainMenueParmissions.pLogInRegister;
            return Permissions;
        }
        private static void _ReadUserInfo(clsUser User)
        {
            Console.Write("\nEnter First Name : ");
            User.FirstName = Console.ReadLine();
            Console.Write("\nEnter Last Name : ");
            User.LastName = Console.ReadLine();
            Console.Write("\nEnter Email : ");
            User.Email = Console.ReadLine();
            Console.Write("\nEnter Phone : ");
            User.Phone = Console.ReadLine();
            Console.Write("\nEnter Password : ");
            User.Password = Console.ReadLine();
            User.Permissions = _ReadPermissionsToSet();
        }
        public static void ShowUpdateUser()
        {
            _ClearScreen();
            string Title = "Update User Screen";
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
            Console.Write("\n\nUpdate User Info.");
            Console.WriteLine("\n__________________________");
            _ReadUserInfo(User);
            clsUser.enSaveResult SaveResult = User.Save();
            switch (SaveResult)
            {
                case clsUser.enSaveResult.svSucceeded:
                    Console.WriteLine("\nUpdate User Successflly :-)");
                    User.Print();
                    break;
                case clsUser.enSaveResult.svFaild:
                    Console.WriteLine("\nError User was not Updated  :-(");
                    break;
            }
        }
    }
}
