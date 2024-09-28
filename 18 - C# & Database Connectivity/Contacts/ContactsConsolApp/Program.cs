
using System;
using System.Data;
using ContactsBusinessLayer;

namespace ContactsConsolApp
{
    internal class Program
    {
        static void TestFindContact(int ID)

        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                Console.WriteLine(Contact1.FirstName+ " " + Contact1.LastName);
                Console.WriteLine(Contact1.Email);
                Console.WriteLine(Contact1.Phone);
                Console.WriteLine(Contact1.Address);
                Console.WriteLine(Contact1.DateOfBirth);
                Console.WriteLine(Contact1.CountryID);
                Console.WriteLine(Contact1.ImagePath);
            }
            else 
            {
                Console.WriteLine("Contact [" + ID + "] Not found!");   
            }
        }

        static void TestAddNewContact()
        {
            clsContact Contact = new clsContact();
            Contact.FirstName = "KARIM";
            Contact.LastName = "GUENDOUZ";
            Contact.Email = "KARIM@GMAIL";
            Contact.Phone = "4738975389";
            Contact.Address = "123 STREET";
            Contact.ImagePath = "";
            Contact.CountryID = 2;
            Contact.DateOfBirth = new DateTime(1977, 11, 6, 10, 30, 0);
            if(Contact.Save())
            {
                Console.WriteLine("Contact Add Successuflly With ID : " + Contact.ID);
            }
        }

        static void TestUpdateContact(int ID)
        {
            clsContact Contact = clsContact.Find(ID);
            if(Contact!=null)
            {
                Contact.FirstName = "AHMED";
                Contact.LastName = "GUENDOUZ";
                Contact.Email = "ALI@GMAIL";
                Contact.Phone = "47756756745";
                Contact.Address = "123 STREET";
                Contact.ImagePath = "C:\\Users\\KarimPc\\Desktop\\Foundation";
                Contact.CountryID = 3;
                Contact.DateOfBirth = new DateTime(2000, 11, 6, 10, 30, 0);
                if (Contact.Save())
                {
                    Console.WriteLine("Contact Update Successuflly -)");
                }
            }
            else
            {
                Console.WriteLine("Contact Not Found -(");
            }
            
        }

        static void TestDeleteContact(int ID)
        {
            if(clsContact.ISContactExist(ID))
            {
                if (clsContact.DeleteContact(ID))
                {
                    Console.WriteLine("Contact Delete Succefully -)");
                }
                else
                {
                    Console.WriteLine("Contact Delete Falide -(");
                }
            }
            else
            {
                Console.WriteLine($"Contact With ID : {ID} not found.");
            }

            
        }

        static void ListContacts()
        {
            DataTable TableContact = clsContact.GetAllContacts();

            Console.WriteLine("Contacts Data : \n");
            foreach(DataRow Row in TableContact.Rows)
            {
                Console.WriteLine($"ID : {Row["ContactID"]} \tFirstName : {Row["FirstName"]} \tLastName : {Row["LastName"]}\n");
            }


        }

        static void TestIsContactExist(int ID)
        {
            if(clsContact.ISContactExist(ID))
            {
                Console.WriteLine("Yes ,Contact is there");
            }
            else
            {
                Console.WriteLine("No ,Contact is not there");
            }
        }




        static void TestFindCountry(int ID)

        {
            clsCountry Country = clsCountry.Find(ID);

            if (Country != null)
            {
                Console.WriteLine("Country Name : " + Country.CountryName + "\tCode : "+Country.Code+
                    "\tPhoneCode : "+Country.PhoneCode);
            }
            else
            {
                Console.WriteLine("Country With [" + ID + "] Not found!");
            }
        }

        static void TestFindCountryByName(string CountryName)

        {
            clsCountry Country = clsCountry.FindByName(CountryName);

            if (Country != null)
            {
                Console.WriteLine("CountryID : " + Country.ID + "\tCode : " + Country.Code +
                    "\tPhoneCode : " + Country.PhoneCode);
            }
            else
            {
                Console.WriteLine("Country With Country name :  [" + CountryName + "] Not found!");
            }
        }
        static void TestAddNewCountry()
        {
            clsCountry Country = new clsCountry();
            Country.CountryName = "Marocco";
            Country.Code = "UVV";
            Country.PhoneCode = "123";
            if (Country.Save())
            {
                Console.WriteLine("Country Add Successuflly With ID : " + Country.ID);
            }
        }

        static void TestUpdateCountry(int ID)
        {
            clsCountry Country = clsCountry.Find(ID);
            if (Country != null)
            {
                Country.CountryName = "Ouargla";
                Country.Code = "CVV";
                Country.PhoneCode = "456";
                if (Country.Save())
                {
                    Console.WriteLine("Country Update Successuflly -)");
                }
            }
            else
            {
                Console.WriteLine($"Country With ID :  {ID} Not Found -(");
            }

        }

        static void TestDeleteCountry(int ID)
        {
            if (clsCountry.IsCountriesExist(ID))
            {
                if (clsCountry.DeleteCountry(ID))
                {
                    Console.WriteLine("Country Delete Succefully -)");
                }
                else
                {
                    Console.WriteLine("Country Delete Falide -(");
                }
            }
            else
            {
                Console.WriteLine($"Country With ID : {ID} not found.");
            }


        }
        static void ListCountries()
        {
            DataTable TableCountries = clsCountry.GetAllCountries();

            Console.WriteLine("Countries  Data : \n");
            foreach (DataRow Row in TableCountries.Rows)
            {
                Console.WriteLine($"ID : {Row["CountryID"]} \tCountryName : {Row["CountryName"]}" +
                    $" \tCode : {Row["Code"]} \tPhoneCode : {Row["PhoneCode"]}\n");
            }


        }

        static void TestIsCountryExist(int ID)
        {
            if (clsCountry.IsCountriesExist(ID))
            {
                Console.WriteLine("Yes ,Country is there");
            }
            else
            {
                Console.WriteLine("No ,Country is not there");
            }
        }

        static void TestIsCountryExistByName(string CountryName)
        {
            if (clsCountry.IsCountriesExistByName(CountryName))
            {
                Console.WriteLine("Yes ,Country is there");
            }
            else
            {
                Console.WriteLine("No ,Country is not there");
            }
        }

        static void Main(string[] args)
        {
            //TestFindContact(8);
            //TestAddNewContact();
            //TestUpdateContact(4);
            //TestDeleteContact(10);
            ListContacts();
            //TestIsContactExist(7);   


            //TestFindCountry(5);
            //TestAddNewCountry();
            //TestUpdateCountry(1006);
            //TestDeleteCountry(1006);
            //ListCountries();
            //TestIsCountryExist(10);
            //TestFindCountryByName("United States");
            //TestIsCountryExistByName("ALGERIA");
            
            Console.ReadKey();
        }
    }
}
