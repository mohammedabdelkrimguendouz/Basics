using System;
using System.Data;
using System.Data.SqlClient;

namespace ContactsDataAccessLayer
{
    public class clsContactDataAccess
    {
        public static bool GetContactInfoByID(int ID, ref  string FirstName, ref string LastName,
            ref string Email , ref string Phone, ref string Address ,
            ref DateTime DateOfBirth, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@ContactID", ID);

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
                    if(Reader["ImagePath"]!=DBNull.Value)
                    {
                        ImagePath = (string)Reader["ImagePath"];
                    }
                    else
                        ImagePath = "";

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

        public static int AddNewContact(string FirstName, string LastName, string Email, string Phone,
            string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int ContactID = -1;

            string query = @"INSERT INTO Contacts(FirstName,LastName,Email,Phone,Address,DateOfBirth,CountryID,ImagePath)
                              VALUES(@FirstName,@LastName,@Email,@Phone,@Address,@DateOfBirth,@CountryID,@ImagePath);
                              SELECT SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            if(ImagePath=="")
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                 Command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if(Result!=null && int.TryParse(Result.ToString(),out int InsertID))
                {
                    ContactID = InsertID;
                }

            }catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return ContactID;
        }

        public static bool UpdateContact(int ID,string FirstName, string LastName, string Email, string Phone,
            string Address, DateTime DateOfBirth, int CountryID, string ImagePath)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int RowAffected = 0;

            string query = @"Update Contacts
                         set  FirstName=@FirstName,
                              LastName=@LastName,
                              Email=@Email,
                              Phone=@Phone,
                              Address=@Address,
                              DateOfBirth=@DateOfBirth,
                              CountryID=@CountryID,
                              ImagePath=@ImagePath
                              where ContactID=@ContactID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Address", Address);
            Command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            Command.Parameters.AddWithValue("@CountryID", CountryID);
            Command.Parameters.AddWithValue("@ContactID", ID);

            if (ImagePath == "")
                Command.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return (RowAffected>0);
        }

        public static bool DeleteContact(int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int RowAffected = 0;

            string query = @"DELETE FROM Contacts  WHERE ContactID=@ContactID";
                              
         
            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                Connection.Open();
                RowAffected = Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return (RowAffected > 0);
        }

        public static DataTable GetAllContacts()
        {
            DataTable TableContact = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Contacts;";

            SqlCommand Command = new SqlCommand(query, Connection);
            
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.HasRows)
                {
                    TableContact.Load(Reader);
                }
                Reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                
                Connection.Close();
            }
            return TableContact;
        }

        public static bool IsContactExist(int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            bool IsFound=false;

            string query = @"SELECT Found=1 FROM Contacts  WHERE ContactID=@ContactID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@ContactID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                    IsFound = true;
                 Reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
                IsFound = false;
            }
            finally
            {
                Connection.Close();
            }

            return IsFound;
        }

    }

   
}
