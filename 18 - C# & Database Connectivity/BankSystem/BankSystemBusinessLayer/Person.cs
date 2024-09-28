using System;


namespace BankSystemBusinessLayer
{
    public class clsPerson
    {
        public int ID { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ImagePath { get; set; }

        public clsPerson() { }
        public clsPerson(int iD, string firstName, string lastName, string email, string phone, string address, int countryID, DateTime dateOfBirth, string imagePath)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Address = address;
            CountryID = countryID;
            DateOfBirth = dateOfBirth;
            ImagePath = imagePath;
        }
    }
}
