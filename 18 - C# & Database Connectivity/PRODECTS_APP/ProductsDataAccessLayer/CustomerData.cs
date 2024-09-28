using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsDataAccessLayer
{
    public class clsCustomerDataAccess
    {
        public static bool Find(int CustomerID, ref string FirstName, ref string LastName, ref string Phone,ref string ImagePath
            , ref string Address, ref string Email, ref int CountryID)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Customers Where CustomerID=@CustomerID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Phone = (string)Reader["Phone"];
                    ImagePath = (string)Reader["ImagePath"];
                    Address = (string)Reader["Address"];
                    Email = (string)Reader["Email"];
                    CountryID = (int)Reader["CountryID"];
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

        public static bool DeleteCustomer(int CustomerID)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From Customers Where CustomerID=@CustomerID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
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

        public static DataTable ListCustomers()
        {
            DataTable CustomersDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" select * from CustomersInformation;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    CustomersDataTable.Load(Reader);
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
            return CustomersDataTable;
        }

        public static bool DeleteAllCustomers()
        {
            int RowEffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "delete from  Customers ;";
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

        static public int AddNewCustomer( string FirstName, string LastName, string Phone, string ImagePath
            ,  string Address,  string Email,  int CountryID)
        {
            int ProductID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into Customers(FirstName,LastName,Phone,ImagePath,Address,Email,CountryID) 
                              Values(@FirstName,@LastName,@Phone,@ImagePath,@Address,@Email,@CountryID);
                                  Select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
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

        static public bool UpdateCustomer(int CustomerID,string FirstName, string LastName, string Phone, string ImagePath
            , string Address, string Email, int CountryID)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Customers
                              set FirstName=@FirstName,
                                  LastName=@LastName,
                                  Phone=@Phone,
                                  ImagePath=@ImagePath,
                                  Address=@Address,
                                  Email=@Email,
                                  CountryID=@CountryID
                                 Where CustomerID=@CustomerID;
                                  ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CustomerID", CustomerID);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
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
            return RowEffected >0;
        }

        public static DataTable SearchByFirstName(string FirstName)
        {
            DataTable CustomersDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" select * from CustomersInformation Where FirstName=@FirstName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    CustomersDataTable.Load(Reader);
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
            return CustomersDataTable;
        }

        public static DataTable SearchByLastName(string LastName)
        {
            DataTable CustomersDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" select * from CustomersInformation Where LastName=@LastName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LastName", LastName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    CustomersDataTable.Load(Reader);
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
            return CustomersDataTable;
        }

        public static DataTable SearchByFirstNameAndLastName(string FirstName, string LastName)
        {
            DataTable CustomersDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" select * from CustomersInformation Where FirstName=@FirstName and LastName=@LastName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    CustomersDataTable.Load(Reader);
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
            return CustomersDataTable;
        }

        public static DataTable SearchByCountryName(string CountryName)
        {
            DataTable CustomersDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @" select * from CustomersInformation Where CountryName=@CountryName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    CustomersDataTable.Load(Reader);
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
            return CustomersDataTable;
        }

    }
}
