using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SP_CheckPersonExists
{
    internal class Program
    {
        static void CheckPersonExists(int PersonID)
        {
            try
            {
                string ConnectionString = "Server=.;Database=Test;User Id=sa;Password=sa123456";
                using (SqlConnection Connection = new SqlConnection(ConnectionString))
                {
                    Connection.Open();

                    using (SqlCommand Command = new SqlCommand("SP_CheckPersonExists", Connection))
                    {
                        Command.CommandType = CommandType.StoredProcedure;
                        Command.Parameters.AddWithValue("@PersonID", (object)PersonID??DBNull.Value);



                        SqlParameter returnParameter = new SqlParameter("@ReturnVal", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.ReturnValue
                        };
                        Command.Parameters.Add(returnParameter);


                        Command.ExecuteNonQuery();


                        // Retrieve the ID of the new person
                        bool PersonExists = (int)returnParameter.Value==1;
                        Console.WriteLine($" Is Person With {PersonID} Exist :  {PersonExists}");


                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }
        static void Main(string[] args)
        {

            CheckPersonExists(1);
            CheckPersonExists(2);
            CheckPersonExists(3);
            Console.ReadKey();
        }
    }
}
