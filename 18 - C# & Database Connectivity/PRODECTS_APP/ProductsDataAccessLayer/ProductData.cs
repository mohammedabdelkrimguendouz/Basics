using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;



namespace ProductsDataAccessLayer
{
    public class clsProductDataAccess
    {
        static public int AddNewProduct(string Name,string Description,double Price
            , int Quantity, string ImagePath,int CategoryID)
        {
            int ProductID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into Products(Name,Price,ImagePath,Quantity,Description,CategoryID) 
                              Values(@Name,@Price,@ImagePath,@Quantity,@Description,@CategoryID);
                                  Select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
            if(ImagePath!="")
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            if (Description != "")
                Command.Parameters.AddWithValue("@Description", Description);
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);


            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if (Result!=null && int.TryParse(Result.ToString(),out int InsertedID))
                {
                    ProductID = InsertedID;
                }
            }
            catch
            {
                ProductID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return ProductID;
        }

        static public bool UpdateProduct(int ProductID, string Name, string Description, double Price
            , int Quantity, string ImagePath, int CategoryID)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update  Products
                             set Name=@Name,
                                 Price=@Price,
                                 ImagePath=@ImagePath,
                                 Quantity=@Quantity,
                                 Description=@Description , 
                                 CategoryID=@CategoryID
                                 Where ProductID=@ProductID ;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            Command.Parameters.AddWithValue("@Price", Price);
            Command.Parameters.AddWithValue("@Quantity", Quantity);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
            Command.Parameters.AddWithValue("@ProductID", ProductID);
            if (ImagePath != "")
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            if (Description != "")
                Command.Parameters.AddWithValue("@Description", Description);
            else
                Command.Parameters.AddWithValue("@Description", DBNull.Value);


            try
            {
                Connection.Open();
                RowEffected= Command.ExecuteNonQuery();
                
            }
            catch
            {
                RowEffected = 0;
            }
            finally
            {
                Connection.Close();
            }
            return RowEffected>0;
        }

        public static bool Find(int ProductID,ref string Name, ref string Description, ref double Price
            , ref int Quantity, ref string ImagePath, ref int CategoryID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Products Where ProductID=@ProductID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ProductID", ProductID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    Name = (string)Reader["Name"];
                    Description =(Reader["Description"]!=DBNull.Value)?(string)Reader["Description"]:"";
                    ImagePath = (Reader["ImagePath"] != DBNull.Value)?(string)Reader["ImagePath"] :"";
                    Price = (double)Reader["Price"];
                    Quantity = (int)Reader["Quantity"];
                    CategoryID = (int)Reader["CategoryID"];
                }
                Reader.Close();
            }
            catch
            {
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }
            return IsFound;
        }

        public static DataTable ListProducts()
        {
            DataTable ProductsDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" select * from ProductsInformation;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    ProductsDataTable.Load(Reader);
                }
                Reader.Close();
            }
            catch
            {
                
            }
            finally
            {
                Connection.Close();
            }
            return ProductsDataTable;
        }

        public static bool DeleteProduct(int ProductID)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From Products Where ProductID=@ProductID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ProductID", ProductID);
            try
            {
                Connection.Open();
                RowEffected = Command.ExecuteNonQuery();
            }
            catch
            {
                RowEffected = 0;
            }
            finally
            {
                Connection.Close();
            }
            return (RowEffected>0);
        }

        public static bool DeleteAllProducts()
        {
            int RowEffected  =-1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete from  Products ;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                RowEffected = Command.ExecuteNonQuery();
            }
            catch
            {
                RowEffected = -1;
            }
            finally
            {
                Connection.Close();
            }
            return (RowEffected >= 0);
        }

        public static DataTable ListProductsForCategory(string Category)
        {
            DataTable ProductsDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" select * from ProductsInformation Where CategoryName=@CategoryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CategoryName", Category);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    ProductsDataTable.Load(Reader);
                }
                Reader.Close();
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return ProductsDataTable;
        }

        public static DataTable ListProductsForName(string Name)
        {
            DataTable ProductsDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" select * from ProductsInformation Where Name=@Name;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Name", Name);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    ProductsDataTable.Load(Reader);
                }
                Reader.Close();
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return ProductsDataTable;
        }

    }
}
