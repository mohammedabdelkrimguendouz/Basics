using ProductsDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProductsBusnisseLayer
{
    public class clsProduct
    {
        public enum enMode { AddNew=0,Update=1};
        private enMode _Mode;
        public int ProductID { get; set; } 
        public string Name {  get; set; }
        public string Description { get; set; }
        public double Price {  get; set; }  
        public int Quantity {  get; set; }
        public string ImagePath {  get; set; }

        public int CategoryID {  get; set; }

        public clsProduct()
        {
            _Mode = enMode.AddNew;Description = string.Empty;
            ProductID = -1;Price = 0.0;Quantity = 0;
            Name = string.Empty;ImagePath = string.Empty;
            CategoryID = -1;
        }
        private clsProduct(int ProductID, string Name, string Description, double Price, int Quantity, string ImagePath,int CategoryID)
        {
            this._Mode = enMode.Update ;
            this.ProductID = ProductID;
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Quantity = Quantity;
            this.ImagePath = ImagePath;
            this.CategoryID = CategoryID;
        }

        public static clsProduct Find(int ProductID)
        {
            string Name = "", Description = "", ImagePath = "";
            double Price = 0.0;
            int Quantity = 0, CategoryID = -1;
            if(clsProductDataAccess.Find(ProductID, ref Name, ref Description, ref Price, ref Quantity, ref ImagePath, ref CategoryID))
            {
                return new clsProduct(ProductID, Name, Description, Price, Quantity, ImagePath, CategoryID);
            }
            return null;
        }    

        public static bool DeleteProduct(int ProductID)
        {
            return clsProductDataAccess.DeleteProduct(ProductID);
        }

        public static DataTable ListProducts()
        {
            return clsProductDataAccess.ListProducts();
        }

        public static bool DeleteAllProducts()
        {
            return clsProductDataAccess.DeleteAllProducts();
        }


        private bool _AddNewProduct()
        {
            this.ProductID = clsProductDataAccess.AddNewProduct(Name, Description, Price, Quantity, ImagePath, CategoryID);
            return (ProductID != -1);
        }
        private bool _UpdateProduct()
        {
            return clsProductDataAccess.UpdateProduct(this.ProductID, Name, Description, Price, Quantity, ImagePath, CategoryID);
        }
        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if(_AddNewProduct())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;
                case enMode.Update:
                    return _UpdateProduct();
            }
            return false;
        }

        public static DataTable ListProductsForCategory(string Category)
        {
            return clsProductDataAccess.ListProductsForCategory(Category);
        }
        public static DataTable ListProductsForName(string Name)
        {
            return clsProductDataAccess.ListProductsForName(Name);
        }
    }
}
