using ProductsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsBusnisseLayer
{
    public class clsCountry
    {
        public enum enMode { Update, AddNew };
        private enMode Mode = enMode.Update;
        public int ID { get; set; }
        public string CountryName { get; set; }
        public clsCountry()
        {
            ID = -1;
            CountryName = "";
            Mode = enMode.AddNew;
        }

        private clsCountry(int ID, string CountryName)
        {
            this.ID = ID;
            this.CountryName = CountryName;
            
            Mode = enMode.Update;
        }

        public static clsCountry Find(int ID)
        {

            string CountryName = "";

            if (clsCountryDataAccess.GetCountryInfoByID(ID, ref CountryName))

                return new clsCountry(ID, CountryName);
            else
                return null;

        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;
            if (clsCountryDataAccess.GetCountryInfoByName(ref CountryID, CountryName))

                return new clsCountry(CountryID, CountryName);
            else
                return null;

        }

        private bool _AddNewCountry()
        {
            this.ID = clsCountryDataAccess.AddNewCountry(this.CountryName);
            return (this.ID != -1);
        }

        private bool _UpdateCountry()
        {
            return clsCountryDataAccess.UpdateCountry(this.ID, this.CountryName);
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
            return false;
        }
    }
}
