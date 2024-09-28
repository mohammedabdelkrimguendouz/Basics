using System;
using System.Data;
using ContactsDataAccessLayer;


namespace ContactsBusinessLayer
{
    public class clsContact
    {
        public enum enMode { Update,AddNew};
        public enMode Mode = enMode.Update;

        public int ID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public DateTime DateOfBirth { set; get; }

        public string ImagePath { set; get; }

        public int CountryID { set; get; }

        public clsContact()
        {
            ID = -1;
            FirstName = "";
            LastName = "";
            Email = "";
            Phone = "";
            Address = "";
            DateOfBirth = DateTime.Now;
            CountryID = -1;
            ImagePath = "";
            Mode = enMode.AddNew;
        }

        private clsContact(int ID, string FirstName, string LastName,
            string Email, string Phone, string Address, DateTime DateOfBirth, int CountryID, string ImagePath)

        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
            this.Address = Address;
            this.DateOfBirth = DateOfBirth;
            this.CountryID = CountryID;
            this.ImagePath = ImagePath;
            Mode = enMode.Update;
        }

        private bool _AddNewContact()
        {
            this.ID = clsContactDataAccess.AddNewContact(this.FirstName,this.LastName,this.Email,this.Phone,
                this.Address,this.DateOfBirth,this.CountryID,this.ImagePath);
            return (this.ID != -1);
        }
       
        public static clsContact Find(int ID)
        {

            string FirstName="", LastName="", Email="", Phone="", Address="",ImagePath=""; 
            DateTime DateOfBirth=DateTime.Now;
            int CountryID=-1;

          if (clsContactDataAccess.GetContactInfoByID(ID,ref FirstName, ref LastName, 
                        ref Email, ref Phone, ref Address,ref DateOfBirth,ref CountryID,ref ImagePath))

             return new clsContact(ID, FirstName, LastName, 
                        Email, Phone, Address, DateOfBirth, CountryID, ImagePath);
          else
                return null;

        }

        private bool _UpdateContact()
        {
            return clsContactDataAccess.UpdateContact(this.ID, this.FirstName, this.LastName,
                         this.Email, this.Phone, this.Address, this.DateOfBirth, this.CountryID, this.ImagePath);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.AddNew:
                    if(_AddNewContact())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;
                    
                case enMode.Update:
                    return _UpdateContact();
            }
            return true;
        }

        public static bool DeleteContact(int ID)
        {
            return clsContactDataAccess.DeleteContact(ID);
        }

        static public DataTable GetAllContacts()
        {
            return clsContactDataAccess.GetAllContacts();

        }

        static public bool ISContactExist(int ID)
        {
            return clsContactDataAccess.IsContactExist(ID);
        }

    }
}
