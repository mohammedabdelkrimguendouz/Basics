using BankSystemBusinessLayer;
using System;
using System.Data;


namespace ConsolAppBankSystem
{
    internal class Program
    {
        static void TestFindClient(int ID)
        {
            clsBankClient Client = clsBankClient.Find(ID);
            if(Client!=null)
            {
                Console.WriteLine(Client.FirstName + " " + Client.LastName + " " + Client.ID + " " + Client.AccountNumber
                    + " " + Client.AccountBalance + " " + Client.Email+" "+Client.ImagePath) ;
            }else
            {
                Console.WriteLine("Client dont exist -(");
            }

        }
        static void TestAddNewClient()
        {
            clsBankClient Client=new clsBankClient();
            Client.Address = "STREET 123";
            Client.AccountBalance = 60000;
            Client.Email = "ali@gmail";
            Client.AccountNumber = "A111";
            Client.CountryID = 1;
            Client.DateOfBirth = DateTime.Now;
            Client.FirstName = "ali";
            Client.LastName = "Guendouz";
            Client.Phone = "o665305105";
            Client.PinCode = "1234";
            Client.ImagePath = "C:\\Users\\KarimPc\\Desktop\\Photo\\Arsenal.png";
            if(Client.Save())
            {
                Console.WriteLine("Add  -)");
            }

        }

        static void TestUpdateClient(int ID)
        {
            clsBankClient Client =clsBankClient.Find(ID);
            if(Client!=null)
            {
                Client.Address = "STREET 678";
                Client.AccountBalance = 90000;
                Client.Email = "KOKO@gmail";
                Client.AccountNumber = "A114";
                Client.CountryID = 1;
                Client.DateOfBirth = DateTime.Now;
                Client.FirstName = "KOKO";
                Client.LastName = "Guendouz";
                Client.Phone = "0668650682";
                Client.PinCode = "1111";
                Client.ImagePath = "C:\\Users\\KarimPc\\Desktop\\Photo\\Arsenal.png";
                if (Client.Save())
                {
                    Console.WriteLine("Update Ok  -)");
                }
            }
            else
            {
                Console.WriteLine("Client not exist  -)");
            }
            

        }

        static void TestDeleteClient(int ID)
        {
            if(clsBankClient.DeleteClient(ID))
            {
                Console.WriteLine("Delete OK ");
            }
            else
            {
                Console.WriteLine("Delete Not ");
            }
        }

        static void TestListClients()
        {
            DataTable ClientsDataTable = clsBankClient.ListClients();
            foreach(DataRow Row in ClientsDataTable.Rows)
            {
                Console.WriteLine("{0} , {1} , {2} , {3} , {4} ,{5} , {6} , {7} , {8} ,{9} , {10} , {11} ", Row[0],
                    Row[1], Row[2], Row[3], Row[4], Row[5], Row[6], Row[7], Row[8], Row[9], Row[10], Row[11]);
                Console.WriteLine("\n");
            }
        }

        static void IsClientExist(int ID)
        {
            if (clsBankClient.IsClientExist(ID))
            {
                Console.WriteLine("\nExist\n");
            }
            else
            {
                Console.WriteLine("\nnot Exist\n");
            }

        }
        static void IsClientExist(string AccountNumber)
        {
            if (clsBankClient.IsClientExist(AccountNumber))
            {
                Console.WriteLine("\nExist\n");
            }
            else
            {
                Console.WriteLine("\nnot Exist\n");
            }
        }

        static void TestDeposite(string AccountNumber,double Amount)
        {
            clsBankClient Client = clsBankClient.Find(AccountNumber);
            if (Client != null)
            {
                Client.Deposite(Amount);
            }
            
        }

        static void TestWithdraw(string AccountNumber, double Amount)
        {
            clsBankClient Client = clsBankClient.Find(AccountNumber);
            if (Client!=null)
            {
                Client.Witdraw(Amount);
            }
            
            
        }

       

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcom \n\n");
            //TestAddNewClient();
            //TestFindClient(7);
            //TestUpdateClient(1011);
            // TestDeleteClient(1010);
            //TestListClients();
            //IsClientExist(1011);IsClientExist(1);IsClientExist(1012);
            //IsClientExist("A114");IsClientExist("A110");IsClientExist("A111");
            //TestDeposite("A111",10000);
            //TestWithdraw("A114",5555);
            
            Console.ReadKey();
        }
    }
}
