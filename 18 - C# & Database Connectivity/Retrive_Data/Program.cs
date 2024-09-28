using System;
using System.Data;
using System.Net;
using System.Data.SqlClient;
using System.Security.Policy;


namespace Program
{
    internal class Program
    {
        static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;"; 
        static void PrintAllContacts()
        {
            SqlConnection Connection=new SqlConnection(ConnectionString);
            string Query = "SELECT * FROM Contacts";
            SqlCommand Command=new SqlCommand(Query,Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader=Command.ExecuteReader();
                while (Reader.Read())
                {
                    int ContactID =(int) Reader["ContactID"];
                    string FirstName = (string)Reader["FirstName"];
                    string LastName= (string)Reader["LastName"];
                    string Email= (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address= (string)Reader["Address"];
                    int CountryID= (int)Reader["CountryID"];
                    
                    Console.WriteLine($"Contact ID : {ContactID}");
                    Console.WriteLine($"Name : {FirstName} {LastName}");
                    Console.WriteLine($"Email : {Email}");
                    Console.WriteLine($"Phone : {Phone}");
                    Console.WriteLine($"Adress : {Address}");
                    Console.WriteLine($"Country ID : {CountryID}");
                    Console.WriteLine();


                }
                Reader.Close();
                Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void PrintAllContactsWithFirstName(string FirstName)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "SELECT * FROM Contacts WHERE FirstName=@FirstName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    int contactID = (int)Reader["ContactID"];
                    string firstName = (string)Reader["FirstName"];
                    string lastName = (string)Reader["LastName"];
                    string email = (string)Reader["Email"];
                    string phone = (string)Reader["Phone"];
                    string address = (string)Reader["Address"];
                    int countryID = (int)Reader["CountryID"];

                    Console.WriteLine($"Contact ID : {contactID}");
                    Console.WriteLine($"Name : {firstName} {lastName}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Adress : {address}");
                    Console.WriteLine($"Country ID : {countryID}");
                    Console.WriteLine();


                }
                Reader.Close();
                Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void PrintAllContactsWithFirstNameAndCountry(string FirstName,int CountryID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "SELECT * FROM Contacts WHERE FirstName=@FirstName and CountryID=@CountryID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    int contactID = (int)Reader["ContactID"];
                    string firstName = (string)Reader["FirstName"];
                    string lastName = (string)Reader["LastName"];
                    string email = (string)Reader["Email"];
                    string phone = (string)Reader["Phone"];
                    string address = (string)Reader["Address"];
                    int countryID = (int)Reader["CountryID"];

                    Console.WriteLine($"Contact ID : {contactID}");
                    Console.WriteLine($"Name : {firstName} {lastName}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Adress : {address}");
                    Console.WriteLine($"Country ID : {countryID}");
                    Console.WriteLine();


                }
                Reader.Close();
                Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void SearchContactsStartsWith(string StartsWith)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "SELECT * FROM Contacts WHERE FirstName Like '' + @StartsWith + '%'";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StartsWith", StartsWith);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    int contactID = (int)Reader["ContactID"];
                    string firstName = (string)Reader["FirstName"];
                    string lastName = (string)Reader["LastName"];
                    string email = (string)Reader["Email"];
                    string phone = (string)Reader["Phone"];
                    string address = (string)Reader["Address"];
                    int countryID = (int)Reader["CountryID"];

                    Console.WriteLine($"Contact ID : {contactID}");
                    Console.WriteLine($"Name : {firstName} {lastName}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Adress : {address}");
                    Console.WriteLine($"Country ID : {countryID}");
                    Console.WriteLine();


                }
                Reader.Close();
                Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void SearchContactsEndsWith(string EndsWith)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "SELECT * FROM Contacts WHERE FirstName Like '%' + @EndsWith + ''";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@EndsWith",EndsWith );

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    int contactID = (int)Reader["ContactID"];
                    string firstName = (string)Reader["FirstName"];
                    string lastName = (string)Reader["LastName"];
                    string email = (string)Reader["Email"];
                    string phone = (string)Reader["Phone"];
                    string address = (string)Reader["Address"];
                    int countryID = (int)Reader["CountryID"];

                    Console.WriteLine($"Contact ID : {contactID}");
                    Console.WriteLine($"Name : {firstName} {lastName}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Adress : {address}");
                    Console.WriteLine($"Country ID : {countryID}");
                    Console.WriteLine();


                }
                Reader.Close();
                Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void SearchContactsContains(string Contains)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "SELECT * FROM Contacts WHERE FirstName Like '%' + @Contains + '%'";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Contains", Contains);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    int contactID = (int)Reader["ContactID"];
                    string firstName = (string)Reader["FirstName"];
                    string lastName = (string)Reader["LastName"];
                    string email = (string)Reader["Email"];
                    string phone = (string)Reader["Phone"];
                    string address = (string)Reader["Address"];
                    int countryID = (int)Reader["CountryID"];

                    Console.WriteLine($"Contact ID : {contactID}");
                    Console.WriteLine($"Name : {firstName} {lastName}");
                    Console.WriteLine($"Email : {email}");
                    Console.WriteLine($"Phone : {phone}");
                    Console.WriteLine($"Adress : {address}");
                    Console.WriteLine($"Country ID : {countryID}");
                    Console.WriteLine();


                }
                Reader.Close();
                Connection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static string GetFirstName(int ContactID)
        {
            string FirstName ="";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "SELECT FirstName FROM Contacts WHERE ContactID=@ContactID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if(Result!=null)
                {
                    FirstName = Result.ToString();
                }
                Connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : "+ ex.Message);
            }
            return FirstName;
        }

        static bool FindContactByID(int ContactID,ref stContact ContactInfo)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "SELECT * FROM Contacts WHERE ContactID=@ContactID";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    IsFound = true;
                    ContactInfo.ID = (int)Reader["ContactID"];
                    ContactInfo.FirstName = (string)Reader["FirstName"];
                    ContactInfo.LastName = (string)Reader["LastName"];
                    ContactInfo.Email = (string)Reader["Email"];
                    ContactInfo.Phone = (string)Reader["Phone"];
                    ContactInfo.Address = (string)Reader["Address"];
                    ContactInfo.CountryID = (int)Reader["CountryID"];
                }
                Connection.Close();
                Reader.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            return IsFound;
        }

        static void AddNewContact(stContact NewContact)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,CountryID)
                           VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID)";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", NewContact.FirstName);
            Command.Parameters.AddWithValue("@LastName", NewContact.LastName);
            Command.Parameters.AddWithValue("@Email", NewContact.Email);
            Command.Parameters.AddWithValue("@Phone", NewContact.Phone);
            Command.Parameters.AddWithValue("@Address", NewContact.Address);
            Command.Parameters.AddWithValue("@CountryID", NewContact.CountryID);

            try
            {
                Connection.Open();
                int RowAffected = Command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    Console.WriteLine("Record Inserted Successfully -)");
                }
                else
                {
                    Console.WriteLine("Record Insertion Failed -(");
                }
                Connection.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : "+ex.Message);
            }
        }

        static void AddNewContactAndGetID(stContact NewContact)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,CountryID)
                           VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", NewContact.FirstName);
            Command.Parameters.AddWithValue("@LastName", NewContact.LastName);
            Command.Parameters.AddWithValue("@Email", NewContact.Email);
            Command.Parameters.AddWithValue("@Phone", NewContact.Phone);
            Command.Parameters.AddWithValue("@Address", NewContact.Address);
            Command.Parameters.AddWithValue("@CountryID", NewContact.CountryID);

            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(),out int InsertedID))
                {
                    Console.WriteLine($"New Insert ID : {InsertedID}");
                }
                else
                {
                    Console.WriteLine($"Faild to retrive the inserted ID");
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void UpdateContact(int ContactID,stContact ContactInfo)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"UPDATE Contacts
                             set FirstName=@FirstName,
                                 LastName=@LastName,
                                 Email=@Email,
                                 Phone=@Phone,
                                 Address=@Address,
                                 CountryID=@CountryID
                              Where ContactID=@ContactID"
                           ;

            SqlCommand Command = new SqlCommand(Query, Connection);

            Command.Parameters.AddWithValue("@FirstName", ContactInfo.FirstName);
            Command.Parameters.AddWithValue("@LastName", ContactInfo.LastName);
            Command.Parameters.AddWithValue("@Email", ContactInfo.Email);
            Command.Parameters.AddWithValue("@Phone", ContactInfo.Phone);
            Command.Parameters.AddWithValue("@Address", ContactInfo.Address);
            Command.Parameters.AddWithValue("@CountryID", ContactInfo.CountryID);
            Command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Connection.Open();
                int RowAffected = Command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    Console.WriteLine("Record Updated Successfully -)");
                }
                else
                {
                    Console.WriteLine("Record Updated Failed -(");
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void DeleteContact(int ContactID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"delete from Contacts where ContactID=@ContactID;";

            SqlCommand Command = new SqlCommand(Query, Connection);
          
            Command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                Connection.Open();
                int RowAffected = Command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    Console.WriteLine("Record Deleted Successfully -)");
                }
                else
                {
                    Console.WriteLine("Record Deleted Failed -(");
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static void DeleteContacts(string ContactIDs)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = @"delete from Contacts where ContactID In ("+ ContactIDs + ")";

            SqlCommand Command = new SqlCommand(Query, Connection);

            

            try
            {
                Connection.Open();
                int RowAffected = Command.ExecuteNonQuery();
                if (RowAffected > 0)
                {
                    Console.WriteLine("Record Deleted Successfully -)");
                }
                else
                {
                    Console.WriteLine("Record Deleted Failed -(");
                }
                Connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        public struct stContact
        {
            public int ID { get; set;}
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

            public string Phone { get; set; }

            public string Address { get; set; }

            public int CountryID { get; set; }
        }

        static void Main(string[] args)
        {
            //PrintAllContacts();
            //PrintAllContactsWithFirstName("Jane");
            //PrintAllContactsWithFirstNameAndCountry("Jane",1);
            //SearchContactsStartsWith("j");
            //SearchContactsEndsWith("ne");
            //earchContactsContains("ae");
            //Console.WriteLine(GetFirstName(1));

            /*stContact ContactInfo = new stContact();
            if (FindContactByID(1, ref ContactInfo))
            {
                Console.WriteLine($"Contact ID : {ContactInfo.ID}");
                Console.WriteLine($"Name : {ContactInfo.FirstName} {ContactInfo.LastName}");
                Console.WriteLine($"Email : {ContactInfo.Email}");
                Console.WriteLine($"Phone : {ContactInfo.Phone}");
                Console.WriteLine($"Adress : {ContactInfo.Address}");
                Console.WriteLine($"Country ID : {ContactInfo.CountryID}");
            }
            else
            {
                Console.WriteLine("Contact is not Found -(");
            }
            */

            /*stContact Contact = new stContact
            {
                FirstName = "Karim",
                LastName = "Guendouz",
                Email = "Karim@gmail.com",
                Phone = "0668650682",
                Address="123 Main Street",
                CountryID=1
            };
            AddNewContact(Contact);
            */


            /*stContact Contact2 = new stContact
            {
                FirstName = "Lila",
                LastName = "Maher",
                Email = "Lila@gmail.com",
                Phone = "0668760932",
                Address = "123 Main Street",
                CountryID = 1
            };
            AddNewContactAndGetID(Contact2);
            */

            /*stContact ContactInfo2 = new stContact
            {
                FirstName = "Amine",
                LastName = "Guendouz",
                Email = "Amine@gmail.com",
                Phone = "0698650352",
                Address = "123 Main Street",
                CountryID = 3,
            };
            UpdateContact(1, ContactInfo2);
            */

            //DeleteContact(15);
            //DeleteContacts("8,9,10");



            Console.ReadKey();
        }
    }
}
