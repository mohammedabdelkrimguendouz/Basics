using System;
using System.Data;
using ContactsDataAccessLayer;

namespace ContactsBusinessLayer
{
    public class clsCountry
    {
        public enum enMode { Update, AddNew };
        private enMode Mode = enMode.Update;
        public int ID { get; set; }
        public string CountryName {  get; set; }    
        public string Code { get; set; }
        public string PhoneCode {  get; set; }
        public clsCountry() 
        {
            ID = -1;
            CountryName = "";
            Code = "";
            PhoneCode = "";
            Mode = enMode.AddNew;
        }

        private clsCountry(int ID, string CountryName,string Code,string PhoneCode)
        {
            this.ID = ID;
            this.CountryName = CountryName;
            this.Code = Code;
            this.PhoneCode = PhoneCode;
            Mode = enMode.Update;
        }

        public static clsCountry Find(int ID)
        {

            string CountryName = "",Code="",PhoneCode="";

            if (clsCountryDataAccess.GetCountryInfoByID(ID,ref CountryName,ref Code,ref PhoneCode))

                return new clsCountry(ID,CountryName,Code,PhoneCode);
            else
                return null;

        }

        public static clsCountry FindByName(string CountryName)
        {
            string  Code = "", PhoneCode = "";
            int CountryID=-1;
            if (clsCountryDataAccess.GetCountryInfoByName(ref CountryID,  CountryName,ref Code,ref PhoneCode))

                return new clsCountry(CountryID, CountryName, Code, PhoneCode);
            else
                return null;

        }

        private bool _AddNewCountry()
        {
            this.ID = clsCountryDataAccess.AddNewCountry(this.CountryName,this.Code,this.PhoneCode);
            return (this.ID != -1);
        }

        private bool _UpdateCountry()
        {
            return clsCountryDataAccess.UpdateCountry(this.ID, this.CountryName,this.Code,this.PhoneCode);
        }
        static public bool DeleteCountry(int ID)
        {
            return clsCountryDataAccess.DeleteCountry(ID);
        }

        static public DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries();
        }

        static public bool IsCountriesExist(int ID)
        {
            return clsCountryDataAccess.IsCountryExist(ID);
        }

        static public bool IsCountriesExistByName(string CountryName)
        {
            return clsCountryDataAccess.IsCountryExistByName(CountryName);
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateCountry();
                   
            }
            return true;
        }
    }
}
