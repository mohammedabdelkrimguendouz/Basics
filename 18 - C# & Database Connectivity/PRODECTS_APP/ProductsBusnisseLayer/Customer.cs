using ProductsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductsBusnisseLayer
{
    public class clsCustomer
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        
        public string ImagePath { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int CountryID { get; set; }

        public clsCustomer()
        {
            _Mode = enMode.AddNew; LastName = string.Empty;
            CustomerID = -1; Address = string.Empty; Phone = string.Empty;
            FirstName = string.Empty; ImagePath = string.Empty;
            CountryID = -1; Email = string.Empty;
        }
        private clsCustomer(int customerID, string firstName, string lastName, string phone, string imagePath, string address, string email, int countryID)
        {
            _Mode = enMode.Update ;
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            ImagePath = imagePath;
            Address = address;
            Email = email;
            CountryID = countryID;
        }
        public static clsCustomer Find(int CustomerID)
        {
            string FirstName = "", LastName = "", phone = "", ImagePath = "", Address = "", Email = "";
            int CountryID =-1;
            if (clsCustomerDataAccess.Find(CustomerID, ref FirstName, ref LastName, ref phone, ref ImagePath, ref Address, ref Email,ref CountryID))
            {
                return new clsCustomer(CustomerID, FirstName, LastName, phone, ImagePath, Address, Email,CountryID);
            }
            return null;
        }

        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomerDataAccess.DeleteCustomer(CustomerID);
        }

        public static DataTable ListCustomers()
        {
            return clsCustomerDataAccess.ListCustomers() ;
        }

        public static bool DeleteAllCustomers()
        {
            return clsCustomerDataAccess.DeleteAllCustomers();
        }

        public static DataTable SearchByFirstName(string FirstName)
        {
            return clsCustomerDataAccess.SearchByFirstName(FirstName);
        }

        public static DataTable SearchByLastName(string LastName)
        {
            return clsCustomerDataAccess.SearchByLastName(LastName);
        }

        public static DataTable SearchByFirstNameAndLastName(string FirstName, string LastName)
        {
            return clsCustomerDataAccess.SearchByFirstNameAndLastName(FirstName, LastName);
        }

        public static DataTable SearchByCountryName(string CountryName)
        {
            return clsCustomerDataAccess.SearchByCountryName(CountryName);
        }
        private bool _AddNewCustomer()
        {
            CustomerID = clsCustomerDataAccess.AddNewCustomer(FirstName, LastName, Phone, ImagePath, Address, Email, CountryID);
            return CustomerID != -1;
        }
        private bool _UpdateCustomer()
        {
            return clsCustomerDataAccess.UpdateCustomer(CustomerID, FirstName, LastName, Phone, ImagePath, Address, Email, CountryID);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCustomer())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateCustomer();
            }
            return false;
        }
    }
}
