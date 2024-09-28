using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataSet_Exemple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable("EmployeesDataTable");
            EmployeesDataTable.Columns.Add("ID", typeof(int));
            EmployeesDataTable.Columns.Add("Name", typeof(string));
            EmployeesDataTable.Columns.Add("Country", typeof(string));
            EmployeesDataTable.Columns.Add("Salary", typeof(Double));
            EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            EmployeesDataTable.Rows.Add(1, "KARIM", "ALGERIA", 50000, DateTime.Now);
            EmployeesDataTable.Rows.Add(2, "ALI", "JORDAN", 65000, DateTime.Now);
            EmployeesDataTable.Rows.Add(3, "SAMIR", "EGYPT", 30000, DateTime.Now);
            EmployeesDataTable.Rows.Add(4, "AHMED", "KSA", 15000, DateTime.Now);
            EmployeesDataTable.Rows.Add(6, "RAKWAN", "JORDAN", 840000, DateTime.Now);

            Console.WriteLine("\nEmployees List : \n");
            foreach (DataRow RecordEmployee in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }


            DataTable DepartmentsDataTable = new DataTable("DepartmentsDataTable");
            DepartmentsDataTable.Columns.Add("DepartmentID", typeof(int));
            DepartmentsDataTable.Columns.Add("Name", typeof(string));


            DepartmentsDataTable.Rows.Add(1, "IT");
            DepartmentsDataTable.Rows.Add(2, "Markiting");
            DepartmentsDataTable.Rows.Add(3, "HR");
            

            Console.WriteLine("\nDepartment List : \n");
            foreach (DataRow RecordDepartment in DepartmentsDataTable.Rows)
            {
                Console.WriteLine($"DepartmentID : {RecordDepartment["DepartmentID"]}\tName : {RecordDepartment["Name"]}");
            }

            DataSet DataSet1 =new DataSet();
            DataSet1.Tables.Add(EmployeesDataTable);
            DataSet1.Tables.Add(DepartmentsDataTable);

            Console.WriteLine("\nEmployees List for Data set 1: \n");
            foreach (DataRow RecordEmployee in DataSet1.Tables["EmployeesDataTable"].Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }

            Console.WriteLine("\nDepartment List for data set 1 : \n");
            foreach (DataRow RecordDepartment in DataSet1.Tables["DepartmentsDataTable"].Rows)
            {
                Console.WriteLine($"DepartmentID : {RecordDepartment["DepartmentID"]}\tName : {RecordDepartment["Name"]}");
            }

            Console.ReadKey();
        }
    }
}
