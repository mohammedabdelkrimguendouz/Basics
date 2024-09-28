using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataView_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable();

            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(Double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            
            // Add Rows
            EmployeesDataTable.Rows.Add(1, "KARIM", "ALGERIA", 50000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "ALI", "JORDAN", 65000, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "SAMIR", "EGYPT", 30000, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "AHMED", "KSA", 15000, DateTime.Now);
            EmployeesDataTable.Rows.Add(5, "RAKWAN", "JORDAN", 840000, DateTime.Now);

            Console.WriteLine("Employees List : ");
            foreach (DataRow RecordEmployee in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }


            DataView EmployeesDataView1 = EmployeesDataTable.DefaultView;
            Console.WriteLine("\nEmployees List from Data View 1 : \n");
            for (int i=0;i<EmployeesDataView1.Count;i++)
            {
                Console.WriteLine("{0} , {1} , {2} , {3} ", EmployeesDataView1[i][0], EmployeesDataView1[i][1],
                    EmployeesDataView1[i][2], EmployeesDataView1[i][3]);
            }

            EmployeesDataView1.Sort = "Name ASC";
            Console.WriteLine("\nEmployees List from Data View 2 Sorting by Name ASC: \n");
            for (int i = 0; i < EmployeesDataView1.Count; i++)
            {
                Console.WriteLine("{0} , {1} , {2} , {3} ", EmployeesDataView1[i][0], EmployeesDataView1[i][1],
                    EmployeesDataView1[i][2], EmployeesDataView1[i][3]);
            }

            //Filter
            //EmployeesDataView1.RowFilter = "Country ='EGYPT' or Country='JORDAN'";
            //Console.WriteLine("\nEmployees List from Data View 1 filter \"EGYPT or JORDAN\": \n");
            //for (int i = 0; i < EmployeesDataView1.Count; i++)
            //{
            //    Console.WriteLine("{0} , {1} , {2} , {3} ", EmployeesDataView1[i][0], EmployeesDataView1[i][1],
            //        EmployeesDataView1[i][2], EmployeesDataView1[i][3]);
            //}
           
            
            Console.ReadKey();
        }
    }
}
