using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace ProductsDataAccessLayer
{
    public class clsUserDataAccess
    {
        static public bool IsUserExist(string UserName, string Password)
        {
            bool IsFound = false;
            SqlConnection Connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select Found=1 From Users Where UserName=@UserName and Password=@Password;";
            SqlCommand Command=new SqlCommand(Query,Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.Read())
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
        static public bool IsUserExist(string UserName)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select Found=1 From Users Where UserName=@UserName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
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

        static public bool SaveLogIn(int UserID,DateTime Date)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert Into LogInRegisters(UserID,Date)
                             Values(@UserID,@Date);   ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@Date", Date);
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
            return (RowEffected > 0);
        }
        static public bool Find(ref int UserID, string UserName,  string Password, ref int Permissions)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Users Where UserName=@UserName and Password=@Password;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    UserID = (int)Reader["UserID"];
                    Permissions = (int)Reader["Permissions"];
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
        static public bool Find(ref int UserID,  string UserName, ref string Password, ref int Permissions)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Users Where UserName=@UserName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    UserID = (int)Reader["UserID"];
                    Password = (string)Reader["Password"];
                    Permissions = (int)Reader["Permissions"];
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
        static public bool Find(int UserID,ref string UserName,ref string Password,ref int Permissions)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Users Where UserID=@UserID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.Read())
                {
                    IsFound = true;
                    UserName =(string) Reader["UserName"];
                    Password = (string)Reader["Password"];
                    Permissions = (int)Reader["Permissions"];
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

        static public int AddNewUser(string UserName,string Password,int Permissions)
        {
            int UserID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into Users(UserName,Password,Permissions)Values(@UserName,@Password,@Permissions);
                                  select SCOPE_IDENTITY();";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permissions", Permissions);
            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    UserID = InsertedID;
                }
            }
            catch
            {
                UserID = -1;
            }
            finally
            {
                Connection.Close();
            }
            return UserID;
        }

        static public bool UpdateUser(int UserID,string UserName, string Password, int Permissions)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update  Users
                             set UserName=@UserName,
                                 Password=@Password,
                                 Permissions=@Permissions
                                 
                                 Where UserID=@UserID ;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@Permissions", Permissions);
            Command.Parameters.AddWithValue("@UserID", UserID);


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

        static public DataTable ListUsers()
        {
            DataTable UsersDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Users; ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    UsersDataTable.Load(Reader);
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
            return UsersDataTable;
        }

        static public DataTable ListLogInRegisters()
        {
            DataTable LogInRegistersInformationDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From LogInRegistersInformation; ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    LogInRegistersInformationDataTable.Load(Reader);
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
            return LogInRegistersInformationDataTable;
        }

        public static bool DeleteUser(int UserID)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From Users Where UserID=@UserID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
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
        public static bool DeleteUser(string UserName)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From Users Where UserName=@UserName;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
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

        public static bool DeleteAllLogInRegister()
        {
            int RowEffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From LogInRegisters;";
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

        public static bool DeleteLogInRegister(int LogInRegisterID)
        {
            int RowEffected = 0;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From LogInRegisters where LogInRegisterID=@LogInRegisterID;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LogInRegisterID", LogInRegisterID);
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

        static public DataTable SearchUser(int UserID)
        {
            DataTable UserDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Users Where UserID=@UserID; ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserID", UserID);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    UserDataTable.Load(Reader);
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
            return UserDataTable;
        }
        static public DataTable SearchUser(string UserName)
        {
            DataTable UserDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Users Where UserName=@UserName; ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    UserDataTable.Load(Reader);
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
            return UserDataTable;
        }

        static public DataTable SearchLogInRegisterForUser(string UserName)
        {
            DataTable LogInRegistersInformationDataTable = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From LogInRegistersInformation Where UserName=@UserName; ";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    LogInRegistersInformationDataTable.Load(Reader);
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
            return LogInRegistersInformationDataTable;
        }

    }
}
