using classLibraryUtil;
using System;
using System.Collections.Generic;


namespace BankSystem
{
    
    public class clsManageUsersScreen:clsScreen
    {
        enum enManageUsersMenueOptions
        {
            eListUsers = 1, eAddNewUsers = 2, eDeleteUser = 3,
            eUpdateUser = 4, eFindUser = 5, eMainMenue = 6
        };
        static private void _GoBackToManageUsersMenue()
        {
            Console.Write("\n\n Press any key to go back to Manage Users Menue ...  ");
            Console.ReadKey();
            ShowManageUsersMenue();
        }
        static private int _ReadManageUsersMenueOption()
        {
            Console.Write("\t\t\t\tChoose What do you want do [1-6] : ");
            return clsUtil.ReadNumberBetween(1, 6, "\t\tInvalide Number, Please Enter Agine : ");
        }
        static private void _ShowListUsersScreen()
        {
            clsListUsersScreen.ShowListUsers();
        }
        static private void _ShowAddNewUserScreen()
        {
            clsAddNewUserScreen.ShowAddNewUser();
        }
        static private void _ShowDeleteUserScreen()
        {
            clsDeleteUserScreen.ShowDeleteUser();
        }
        static private void _ShowUpdateUserScreen()
        {
            clsUpdateUserScreen.ShowUpdateUser();
        }
        static private void _ShowFindUserScreen()
        {
            clsFindUserScreen.ShowFindUser();
        }

        static private void _PerformManageUsersMenueOptions(enManageUsersMenueOptions ManageUsersMenueOptions)
        {
            switch(ManageUsersMenueOptions)
            {
                case enManageUsersMenueOptions.eListUsers:
                    _ClearScreen();
                    _ShowListUsersScreen();
                    _GoBackToManageUsersMenue();
                    break;
                case enManageUsersMenueOptions.eAddNewUsers:
                    _ClearScreen();
                    _ShowAddNewUserScreen();
                    _GoBackToManageUsersMenue();
                    break;
                case enManageUsersMenueOptions.eDeleteUser:
                    _ClearScreen();
                    _ShowDeleteUserScreen();
                    _GoBackToManageUsersMenue();
                    break;
                case enManageUsersMenueOptions.eUpdateUser:
                    _ClearScreen();
                    _ShowUpdateUserScreen();
                    _GoBackToManageUsersMenue();
                    break;
                case enManageUsersMenueOptions.eFindUser:
                    _ClearScreen();
                    _ShowFindUserScreen();
                    _GoBackToManageUsersMenue();
                    break;
                case enManageUsersMenueOptions.eMainMenue:
                    break;

            }
        }
        static public void ShowManageUsersMenue()
        {
            if (!CheckAccessRights(clsUser.enMainMenueParmissions.pManageUsers))
                return;
            _ClearScreen();
            _DrawScreenHeader("   Manage Users Screen", "");
            Console.WriteLine("\n\t\t\t\t===================================================");
            Console.WriteLine("\t\t\t\t\t\t     Mange Users Menue");
            Console.WriteLine("\t\t\t\t===================================================");
            Console.WriteLine("\t\t\t\t  [1] List Users.");
            Console.WriteLine("\t\t\t\t  [2] Add New User.");
            Console.WriteLine("\t\t\t\t  [3] Delete User.");
            Console.WriteLine("\t\t\t\t  [4] Update User.");
            Console.WriteLine("\t\t\t\t  [5] Find User.");
            Console.WriteLine("\t\t\t\t  [6] Main Menue.");
            Console.WriteLine("\t\t\t\t===================================================");
            _PerformManageUsersMenueOptions((enManageUsersMenueOptions)_ReadManageUsersMenueOption());
        }
    }
}
