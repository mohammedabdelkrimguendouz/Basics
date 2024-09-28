using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace ContactsDataAccessLayer
{
    public class clsCountryDataAccess
    {
        public static bool GetCountryInfoByID(int ID,ref string CountryName,ref string Code,ref string PhoneCode)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    // The record was found
                    IsFound = true;
                    CountryName = (string)Reader["CountryName"];
                    Code =(Reader["Code"]==DBNull.Value)?"":(string)Reader["Code"];
                    PhoneCode = (Reader["PhoneCode"] == DBNull.Value) ? "" : (string)Reader["PhoneCode"]; 
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

        public static bool GetCountryInfoByName(ref int ID, string CountryName, ref string Code, ref string PhoneCode)
        {
            bool IsFound = false;

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {

                    // The record was found
                    IsFound = true;
                    ID = (int)Reader["CountryID"];
                    Code = (Reader["Code"] == DBNull.Value) ? "" : (string)Reader["Code"];
                    PhoneCode = (Reader["PhoneCode"] == DBNull.Value) ? "" : (string)Reader["PhoneCode"];
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

        public static int AddNewCountry(string CountryName,string Code,string PhoneCode)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int CountryID = -1;

            string query = @"INSERT INTO Countries(CountryName,Code,PhoneCode) VALUES(@CountryName,@Code,@PhoneCode);
                             SELECT SCOPE_IDENTITY()";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            if(Code=="")
                Command.Parameters.AddWithValue("@Code", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Code", Code);
            if(PhoneCode=="")
                Command.Parameters.AddWithValue("@PhoneCode", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@PhoneCode", PhoneCode);

            try
            {
                Connection.Open();
                Object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertID))
                {
                    CountryID = InsertID;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }

            return CountryID;
        }

        public static bool UpdateCountry(int ID, string CountryName, string Code, string PhoneCode)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int RowAffected = 0;

            string query = @"Update Countries
                             set  CountryName=@CountryName,
                                  Code=@Code,
                                  PhoneCode=@PhoneCode
                                  where CountryID=@CountryID;";

            SqlCommand Command = new SqlCommand(query, Connection);

            Command.Parameters.AddWithValue("@CountryID", ID);
            Command.Parameters.AddWithValue("@CountryName", CountryName);
            if (Code == "")
                Command.Parameters.AddWithValue("@Code", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@Code", Code);
            if (PhoneCode == "")
                Command.Parameters.AddWithValue("@PhoneCode", DBNull.Value);
            else
                Command.Parameters.AddWithValue("@PhoneCode", PhoneCode);


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

        public static bool DeleteCountry(int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            int RowAffected = 0;

            string query = @"DELETE FROM Countries  WHERE CountryID=@CountryID";


            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@CountryID", ID);

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

        public static DataTable GetAllCountries()
        {
            DataTable TableCountries = new DataTable();

            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT * FROM Countries;";

            SqlCommand Command = new SqlCommand(query, Connection);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    TableCountries.Load(Reader);
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
            return TableCountries;
        }

        public static bool IsCountryExist(int ID)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            bool IsFound = false;

            string query = @"SELECT Found=1 FROM Countries  WHERE CountryID=@CountryID";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@CountryID", ID);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
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

        public static bool IsCountryExistByName(string CountryName)
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            bool IsFound = false;

            string query = @"SELECT Found=1 FROM Countries  WHERE CountryName=@CountryName";

            SqlCommand Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                IsFound = Reader.HasRows;
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
