using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductsDataAccessLayer
{
    public class clsCategoryDataAccess
    {
        static public DataTable ListCategories()
        {
            DataTable CategoriesDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Categories; "; 
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                
                if (Reader.HasRows)
                {
                    CategoriesDataTable.Load(Reader);
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
            return CategoriesDataTable;
        }
        static public bool Find(int CategoryID,ref string CategoryName)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Categories Where CategoryID=@CategoryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;

                    CategoryName = (string)Reader["CategoryName"];
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
        static public bool Find(ref int CategoryID,  string CategoryName)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "select * from Categories Where CategoryName=@CategoryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CategoryName", CategoryName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;

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

        static public bool IsCatogeryExist(int CategoryID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select found=1 From Categories Where CategoryID=@CategoryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
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

        static public bool IsCatogeryExist(string CategoryName)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select found=1 From Categories Where CategoryName=@CategoryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CategoryName", CategoryName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
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

        static public int AddNewCatogery(string CategoryName)
        {
            int CategoryID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into Categories(CategoryName)Values(@CategoryName);
                                  select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CategoryName", CategoryName);
            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    CategoryID = InsertedID;
                }
            }
            catch
            {
                CategoryID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return CategoryID;
        }

        static public bool UpdateCatogery(int CategoryID,string CategoryName)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update  Categories
                             set CategoryName=@CategoryName
                                 
                                 Where CategoryID=@CategoryID ;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CategoryName", CategoryName);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
            

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
            return RowEffected > 0;
        }

        public static bool DeleteAllCategories()
        {
            int RowEffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete from  Categories ;";
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

        public static bool DeleteCatogery(int CategoryID)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From Categories Where CategoryID=@CategoryID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CategoryID", CategoryID);
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
            return (RowEffected > 0);
        }

        public static bool DeleteCatogery(string CategoryName)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From Categories Where CategoryName=@CategoryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CategoryName", CategoryName);
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
            return (RowEffected > 0);
        }


    }
}
