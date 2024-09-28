using ProductsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsBusnisseLayer
{
    public class clsCategory
    {
        public enum enMode { AddNew,Update};
        private enMode _Mode;
        public int CategoryID {  get; set; }
        public string CategoryName { get; set; }

        public int test { get; set; }
        public clsCategory()
        {
            this.CategoryID = -1;
            this.CategoryName = string.Empty;
            _Mode = enMode.AddNew;
        }

        private clsCategory(int CategoryID,string CategoryName)
        {
            this.CategoryName = CategoryName;
            this.CategoryID = CategoryID;
            _Mode = enMode.Update;
        }
        static public DataTable ListCategories()
        {

            return clsCategoryDataAccess.ListCategories();  
        }
        static public clsCategory Find(int CategoryID)
        {
            string CategoryName = "";
            if(clsCategoryDataAccess.Find(CategoryID,ref CategoryName))
                return new clsCategory(CategoryID,CategoryName);
            return null;
        }
        static public clsCategory Find(string CategoryName)
        {
            int CategoryID = -1;
            if (clsCategoryDataAccess.Find(ref CategoryID,  CategoryName))
                return new clsCategory(CategoryID, CategoryName);
            return null;
        }

        static public bool IsCatogeryExist(int CategoryID)
        {
            return clsCategoryDataAccess.IsCatogeryExist(CategoryID);
        }
        static public bool IsCatogeryExist(string CategoryName)
        {
            return clsCategoryDataAccess.IsCatogeryExist(CategoryName);
        }

        static public bool DeleteAllCategories()
        {
            return clsCategoryDataAccess.DeleteAllCategories();
        }

        public static bool DeleteCategory(int CategoryID)
        {
            return clsCategoryDataAccess.DeleteCatogery(CategoryID);
        }
        public static bool DeleteCategory(string CategoryName)
        {
            return clsCategoryDataAccess.DeleteCatogery(CategoryName);
        }
        private bool _AddNewCatogery()
        {
            this.CategoryID = clsCategoryDataAccess.AddNewCatogery(this.CategoryName);
            return (this.CategoryID != -1);
        }

        private bool _UpdateCatogery()
        {
            return clsCategoryDataAccess.UpdateCatogery(this.CategoryID, this.CategoryName);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewCatogery())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateCatogery();
            }
            return false;
        }
    }
}
