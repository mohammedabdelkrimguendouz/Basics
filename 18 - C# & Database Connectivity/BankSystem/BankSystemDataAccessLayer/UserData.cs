using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemDataAccessLayer
{
    public class clsUserDataAccess
    {
        public static bool GetUserInfoByID(int ID, ref string UserName, ref string Password)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users 
                            Where UserID=@UserID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@UserID", ID);
            
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    // The record was found
                    IsFound = true;


                    UserName = (string)Reader["UserName"];
                    Password = (string)Reader["Password"];
                }
                else
                {
                    // The record was not found
                    IsFound = false;
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static DataTable FindUserByUserName(string UserName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable UserDataTable = new DataTable();

            string query = @"select * from Users Where UserName=@UserName ";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    UserDataTable.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);

            }


            finally
            {
                Connection.Close();
            }

            return UserDataTable;
        }
        public static bool GetUserInfoByUserNameAndPassword(ref int ID, string UserName, string Password)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Users 
                            Where UserName=@UserName and Password=@Password";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    // The record was found
                    IsFound = true;

                    
                    ID = (int)Reader["UserID"];
                    
                }
                else
                {
                    // The record was not found
                    IsFound = false;
                }

                Reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }
        public static int AddNewUser(string UserName,  string Password)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int UserID = -1;

            string query = @"INSERT INTO Users(UserName,Password)
                              VALUES(@UserName,@Password);
                               
                               SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            

            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertID))
                {
                    UserID = InsertID;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);
                UserID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return UserID;
        }

        public static bool UpdateUser(int ID, string UserName, string Password)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int RowAffected = 0;

            string query = @"Update Users 
                              set UserName=@UserName,
                                  Password=@Password
                              where UserID=@UserID;
                              ";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            Command.Parameters.AddWithValue("@UserID", ID);
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);
                RowAffected = 0;
            }


            finally
            {
                Connection.Close();
            }

            return (RowAffected > 0);
        }


        
        public static bool DeleteUser(int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int RowAffected = 0;

            string query = @"delete from LogInRegisters Where UserID=@UserID;
                           delete from Users  Where UserID=@UserID;" ;

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserID", ID);
            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);

                RowAffected = 0;
            }


            finally
            {
                Connection.Close();
            }

            return (RowAffected > 0);
        }

        public static DataTable ListUsers()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable UsersDataTable = new DataTable();

            string query = @"select * from Users ";
            SqlCommand Command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    UsersDataTable.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);

            }


            finally
            {
                Connection.Close();
            }

            return UsersDataTable;
        }

        public static bool IsUserExistByUserName(string UserName)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found=1 from Users 
                            Where UserName=@UserName";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;


                Reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static bool IsUserExistByUserNameAndPassword(string UserName,string Password)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found=1 from Users 
                            Where UserName=@UserName and Password=@Password";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@UserName", UserName);
            Command.Parameters.AddWithValue("@Password", Password);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;


                Reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

        public static int SaveLogInRegister(int UserID, DateTime DateLogIn)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int LogInID = -1;

            string query = @"INSERT INTO LogInRegisters(DateLogIn,UserID)
                              VALUES(@DateLogIn,@UserID);
                               
                               SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@DateLogIn", DateLogIn);
            Command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertID))
                {
                    LogInID = InsertID;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);
                LogInID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return LogInID;
        }

        public static DataTable ListLogInRegisters()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable LogDataTable = new DataTable();

            string query = @"select * from LogInRegistersInfo ";
            SqlCommand Command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    LogDataTable.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);

            }


            finally
            {
                Connection.Close();
            }

            return LogDataTable;
        }

        public static DataTable GetListRigestersForUser(string UserName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable LogDataTable = new DataTable();

            string query = @"select * from LogInRegistersInfo where UserName=@UserName";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    LogDataTable.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);

            }


            finally
            {
                Connection.Close();
            }

            return LogDataTable;
        }
        public static DataTable GetListLogInByDate(DateTime DateLogIn)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable LogDataTable = new DataTable();

            string query = @"select * from LogInRegistersInfo where DateLogIn=@DateLogIn";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@DateLogIn", DateLogIn);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    LogDataTable.Load(Reader);
                Reader.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);

            }


            finally
            {
                Connection.Close();
            }

            return LogDataTable;
        }
        public static void DeleteAllRegistersLogIn()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);



            string query = @"
                                delete from LogInRegisters;
                                
                                 
                                 ";

            SqlCommand Command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);

            }


            finally
            {
                Connection.Close();
            }


        }
    }
}
