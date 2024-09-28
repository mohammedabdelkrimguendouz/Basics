using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;


namespace BankSystemDataAccessLayer
{
    public class clsBankClientDataAccess
    {

        public static bool GetClientInfoByID(int ID, ref string FirstName, ref string LastName,
           ref string Email, ref string Phone, ref string Address,
           ref DateTime DateOfBirth, ref string ImagePath,ref int CountryID,ref string AccountNumber,
           ref string PinCode,ref double AccountBalance)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from ClientsInformation 
                            Where ClientID=@ClientID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    // The record was found
                    IsFound = true;

                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (string)Reader["Phone"];
                    Address = (string)Reader["Address"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    CountryID = (int)Reader["CountryID"];
                    ImagePath = (string)Reader["ImagePath"];
                    AccountNumber = (string)Reader["AccountNumber"];
                    AccountBalance = (Double)Reader["AccountBalance"];
                    PinCode = (string)Reader["PinCode"];
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

        public static bool GetClientInfoByAccountNumber(ref int ID, ref string FirstName, ref string LastName,
          ref string Email, ref string Phone, ref string Address,
          ref DateTime DateOfBirth, ref string ImagePath, ref int CountryID,  string AccountNumber,
          ref string PinCode, ref double AccountBalance)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from ClientsInformation 
                            Where AccountNumber=@AccountNumber";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    // The record was found
                    IsFound = true;

                    FirstName = (string)Reader["FirstName"];
                    LastName = (string)Reader["LastName"];
                    Email = (string)Reader["Email"];
                    Phone = (string)Reader["Phone"];
                    Address = (string)Reader["Address"];
                    DateOfBirth = (DateTime)Reader["DateOfBirth"];
                    CountryID = (int)Reader["CountryID"];
                    ImagePath = (string)Reader["ImagePath"];
                    ID = (int)Reader["ClientID"];
                    AccountBalance = (Double)Reader["AccountBalance"];
                    PinCode = (string)Reader["PinCode"];
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
        public static int AddNewClient(string FirstName, string LastName, string Email, string Phone,
            string Address,string ImagePath, int CountryID, DateTime DateOfBirth,string AccountNumber,
            string PinCode,double AccountBalance)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int ClientID = -1;

            string query = @"INSERT INTO Persons(FirstName,LastName,Email,Phone,Address,DateOfBirth,CountryID,ImagePath)
                              VALUES(@FirstName,@LastName,@Email,@Phone,@Address,@DateOfBirth,@CountryID,@ImagePath);
                               INSERT INTO Clients(AccountNumber,PinCode,AccountBalance,PersonID)
                               VALUES(@AccountNumber,@PinCode,@AccountBalance,SCOPE_IDENTITY());
                               SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            Command.Parameters.AddWithValue("@PinCode", PinCode);
            Command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
            Command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertID))
                {
                    ClientID = InsertID;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);
                ClientID = -1;
            }
            finally
            {
                Connection.Close();
            }

            return ClientID;
        }

         public static bool UpdateClient(int ID,string FirstName, string LastName, string Email, string Phone,
             string Address, string ImagePath, int CountryID, DateTime DateOfBirth,
             string AccountNumber, string PinCode, double AccountBalance)
         {
             SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

             int RowAffected = 0;

             string query = @"Update Clients 
                              set AccountBalance=@AccountBalance,
                                  AccountNumber=@AccountNumber,
                                  PinCode=@PinCode
                              where ClientID=@ClientID;

                              Update Persons 
                              set FirstName=@FirstName,
                                  LastName=@LastName,
                                  Email=@Email,
                                  Phone=@Phone,
                                  Address=@Address,
                                  CountryID=@CountryID,
                                  ImagePath=@ImagePath,
                                  DateOfBirth=@DateOfBirth
                              where PersonID=(SElect PersonID from Clients Where ClientID=@ClientID)";

             SqlCommand Command = new SqlCommand(query, Connection);

             Command.Parameters.AddWithValue("@FirstName", FirstName);
             Command.Parameters.AddWithValue("@LastName", LastName);
             Command.Parameters.AddWithValue("@Email", Email);
             Command.Parameters.AddWithValue("@Phone", Phone);
             Command.Parameters.AddWithValue("@Address", Address);
             Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
             Command.Parameters.AddWithValue("@CountryID", CountryID);
             Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
             Command.Parameters.AddWithValue("@PinCode", PinCode);
             Command.Parameters.AddWithValue("@AccountBalance", AccountBalance);
             Command.Parameters.AddWithValue("@ImagePath", ImagePath);
             Command.Parameters.AddWithValue("@ClientID", ID);
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


        public static bool DeleteClient(int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int RowAffected = 0;

            string query = @"declare @IdSaved int;

                                set @IdSaved= (select PersonID from Clients Where ClientID=@ClientID);
                                delete from Clients
                                Where ClientID=@ClientID;

                                 delete from Persons
                                 Where PersonID=@IdSaved;";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ClientID", ID);
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

        public static void DeleteAllClient()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            

            string query = @"
                                delete from Clients;
                                
                                 delete from Persons;
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

        public static DataTable ListClients()
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable ClientsDataTable = new DataTable();

            string query = @"select * from ClientsInformation ";
            SqlCommand Command = new SqlCommand(query, Connection);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ClientsDataTable.Load(Reader);
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

            return ClientsDataTable;
        }

        public static bool IsClientExistByID(int ID)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found=1 from ClientsInformation 
                            Where ClientID=@ClientID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ID);

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

        public static bool IsClientExistByAccountNumber(string AccountNumber)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found=1 from ClientsInformation 
                            Where AccountNumber=@AccountNumber";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

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

        public static bool SaveNewBalance(int ID,double NewBalance)
        {
            int RowAffected = 0;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"Update Clients
                             set AccountBalance=@AccountBalance
                            Where ClientID=@ClientID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@ClientID", ID);
            Command.Parameters.AddWithValue("@AccountBalance", NewBalance);
            try
            {
                Connection.Open();
                RowAffected  = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                RowAffected = 0;
            }
            finally
            {
                Connection.Close();
            }

            return RowAffected>0;
        }
        public static DataTable FindClientByAccountNumber(string AccountNumber)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            DataTable ClientDataTable = new DataTable();

            string query = @"select * from ClientsInformation Where AccountNumber=@AccountNumber ;";
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    ClientDataTable.Load(Reader);
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

            return ClientDataTable;
        }
    }
}

       