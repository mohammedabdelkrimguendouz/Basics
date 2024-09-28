using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAdapter_Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConnectionString = "Server=.;Database=HR_Database;User Id=sa;Password=sa123456;";
            string Query = "SELECT * FROM Employees";
            DataSet DataSet1 = new DataSet();
            SqlConnection Connection = new SqlConnection(ConnectionString);
            SqlDataAdapter DataAdapter = new SqlDataAdapter(Query,ConnectionString);

            Connection.Open();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.Fill(DataSet1, "Employees");

            Connection.Close();
            Console.WriteLine("\nEmployees List : \n");
            DataTable DataTable1 = DataSet1.Tables["Employees"];

            foreach(DataRow RecordRow in DataTable1.Rows)
            {
                Console.WriteLine("{0} , {1} , {2} ", RecordRow["ID"], RecordRow["FirstName"], RecordRow["LastName"]);
            }

            // After Maniplute data
            // add-delte-update ....

            Connection.Open();
            DataAdapter.SelectCommand.Connection = Connection;
            DataAdapter.Update(DataSet1, "Employees");



            Console.ReadKey();
        }
    }
}
