using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SP_AddNewPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string ConnectionString = "Server=.;Database=Test;User Id=sa;Password=sa123456";
            try
            {
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();
                    
                    using (SqlCommand Command = new SqlCommand("SP_AddNewPerson", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;  
                        Command.Parameters.AddWithValue("@FirstName", "karim");

                        Command.Parameters.AddWithValue("@LastName", "Guendouz");
                        Command.Parameters.AddWithValue("@Email", "Test@gmail.com");

                        SqlParameter outputIdParam = new SqlParameter("@NewPersonID", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        Command.Parameters.Add(outputIdParam);


                        Command.ExecuteNonQuery();


                        // Retrieve the ID of the new person
                        int newPersonID = (int)outputIdParam.Value;
                        Console.WriteLine($"New Person ID: {newPersonID}");


                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Console.ReadKey();
        }
    }
}
