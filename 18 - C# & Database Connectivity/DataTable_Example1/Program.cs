using System;
using System.Data;
using System.Linq;


namespace DataTable_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable EmployeesDataTable = new DataTable();

            // Add Columns
            //EmployeesDataTable.Columns.Add("ID", typeof(int));
            //EmployeesDataTable.Columns.Add("Name",typeof(string));
            //EmployeesDataTable.Columns.Add("Country", typeof(string));
            //EmployeesDataTable.Columns.Add("Salary", typeof(Double));
            //EmployeesDataTable.Columns.Add("Date", typeof(DateTime));

            // Methode advanced Create Cloumn
            //Add ID
            DataColumn dtColumn = new DataColumn();
            dtColumn.AllowDBNull = false;
            dtColumn.DataType = typeof(int);
            dtColumn.ColumnName = "ID";
            dtColumn.AutoIncrement = true;
            dtColumn.AutoIncrementSeed = 1;
            dtColumn.AutoIncrementStep = 1;
            dtColumn.Caption = "Employee ID";
            dtColumn.ReadOnly=true;
            dtColumn.Unique = true;
            EmployeesDataTable.Columns.Add(dtColumn);

            // Add Name
            dtColumn = new DataColumn();
            dtColumn.AllowDBNull = false;
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Name";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Employee Name";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            EmployeesDataTable.Columns.Add(dtColumn);


            //Add Country 
            dtColumn = new DataColumn();
            dtColumn.AllowDBNull = false;
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Country";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Country";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            EmployeesDataTable.Columns.Add(dtColumn);

            // Add Salary
            dtColumn = new DataColumn();
            dtColumn.AllowDBNull = true;
            dtColumn.DataType = typeof(Double);
            dtColumn.ColumnName = "Salary";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Salary";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            EmployeesDataTable.Columns.Add(dtColumn);


            //Add Date
            dtColumn = new DataColumn();
            dtColumn.AllowDBNull = true;
            dtColumn.DataType = typeof(DateTime);
            dtColumn.ColumnName = "Date";
            dtColumn.AutoIncrement = false;
            dtColumn.Caption = "Date";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;
            EmployeesDataTable.Columns.Add(dtColumn);

            // Make ID Coulmn the Primary Key Column
            // Primary Key 
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = EmployeesDataTable.Columns["ID"];
            EmployeesDataTable.PrimaryKey = PrimaryKeyColumns;
            // Add Rows
            EmployeesDataTable.Rows.Add(null, "KARIM", "ALGERIA", 50000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "ALI", "JORDAN", 65000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "SAMIR", "EGYPT", 30000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "AHMED", "KSA", 15000, DateTime.Now);
            EmployeesDataTable.Rows.Add(null, "RAKWAN", "JORDAN", 840000, DateTime.Now);

            Console.WriteLine("Employees List : ");
            foreach (DataRow RecordEmployee in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }


            // FUNCTIEN SUM,AVG,Min,Count,Max

            /*int EmployeeCount = EmployeesDataTable.Rows.Count;
            double TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", string.Empty));
            double AvargeSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", string.Empty));
            double MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", string.Empty));
            double MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", string.Empty));

            Console.WriteLine("Count Of Employees : " +EmployeeCount);
            Console.WriteLine("Total Employees Salaries: " +TotalSalaries);
            Console.WriteLine("Avarge Employees Salaries: " +AvargeSalaries);
            Console.WriteLine("Min Salary : " +MinSalary);
            Console.WriteLine("Max Salary : " +MaxSalary);
            */

            // FILTER DataTable 
            /*int ResultCount = 0;
            Console.WriteLine("\n\n Filter \"JORDAN\" Employees\n");
            DataRow[] ResultRow = EmployeesDataTable.Select("Country='JORDAN'");
            foreach (DataRow RecordEmployee in ResultRow)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }

            ResultCount = ResultRow.Count();
            TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)","Country='JORDAN'"));
            AvargeSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "Country='JORDAN'"));
            MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "Country='JORDAN'"));
            MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "Country='JORDAN'"));

            Console.WriteLine("Count Of Employees : " + ResultCount);
            Console.WriteLine("Total Employees Salaries: " + TotalSalaries);
            Console.WriteLine("Avarge Employees Salaries: " + AvargeSalaries);
            Console.WriteLine("Min Salary : " + MinSalary);
            Console.WriteLine("Max Salary : " + MaxSalary);


            Console.WriteLine("\n\n\n Filter \"JORDAN OR EGYPT\" Employees\n");
            ResultRow = EmployeesDataTable.Select("Country='JORDAN' or Country='EGYPT'");
            foreach (DataRow RecordEmployee in ResultRow)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }

            ResultCount = ResultRow.Count();
            TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "Country='JORDAN' or Country='EGYPT'"));
            AvargeSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "Country='JORDAN' or Country='EGYPT'"));
            MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "Country='JORDAN' or Country='EGYPT'"));
            MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "Country='JORDAN' or Country='EGYPT'"));

            Console.WriteLine("Count Of Employees : " + ResultCount);
            Console.WriteLine("Total Employees Salaries: " + TotalSalaries);
            Console.WriteLine("Avarge Employees Salaries: " + AvargeSalaries);
            Console.WriteLine("Min Salary : " + MinSalary);
            Console.WriteLine("Max Salary : " + MaxSalary);

            Console.WriteLine("\n\n\n Filter \"ID=1\" Employees\n");
            ResultRow = EmployeesDataTable.Select("ID=1");
            foreach (DataRow RecordEmployee in ResultRow)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }

            ResultCount = ResultRow.Count();
            TotalSalaries = Convert.ToDouble(EmployeesDataTable.Compute("SUM(Salary)", "ID=1"));
            AvargeSalaries = Convert.ToDouble(EmployeesDataTable.Compute("AVG(Salary)", "ID=1"));
            MinSalary = Convert.ToDouble(EmployeesDataTable.Compute("Min(Salary)", "ID=1"));
            MaxSalary = Convert.ToDouble(EmployeesDataTable.Compute("Max(Salary)", "ID=1"));

            Console.WriteLine("Count Of Employees : " + ResultCount);
            Console.WriteLine("Total Employees Salaries: " + TotalSalaries);
            Console.WriteLine("Avarge Employees Salaries: " + AvargeSalaries);
            Console.WriteLine("Min Salary : " + MinSalary);
            Console.WriteLine("Max Salary : " + MaxSalary);
            */

            // Sorting (Slow)

            /*Console.WriteLine("\n\n Sort ID DESC");
            EmployeesDataTable.DefaultView.Sort="ID DESC";
            EmployeesDataTable = EmployeesDataTable.DefaultView.ToTable();
            foreach (DataRow RecordEmployee in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }

            Console.WriteLine("\n\n Sort Name ASC");
            EmployeesDataTable.DefaultView.Sort = "Name ASC";
            EmployeesDataTable = EmployeesDataTable.DefaultView.ToTable();
            foreach (DataRow RecordEmployee in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }

            Console.WriteLine("\n\n Sort Salary DESC");
            EmployeesDataTable.DefaultView.Sort = "Salary DESC";
            EmployeesDataTable = EmployeesDataTable.DefaultView.ToTable();
            foreach (DataRow RecordEmployee in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }
            */

            // Delete Rows

            /*Console.WriteLine("\n\nDelete Employee with ID=4 ");
            DataRow[] ResultRow = EmployeesDataTable.Select("ID=4");
            foreach (var RecordEmployee in ResultRow)
            {
                RecordEmployee.Delete();
            }
            //EmployeesDataTable.AcceptChanges();  يقوم بالتعديل مع داتابيز 
            foreach (DataRow RecordEmployee in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }
            */

            // Update Rows 

            /*Console.WriteLine("Update Employye ID=4");
            DataRow[] Result = EmployeesDataTable.Select("ID=4");
            foreach(var  ResultRow in Result)
            {
                ResultRow["Name"] = "Maher Ahmed";
                ResultRow["Salary"] = 10000;
            }
            //EmployeesDataTable.AcceptChanges();
            foreach (DataRow RecordEmployee in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }
            */

            // Clear DataTable

            /*EmployeesDataTable.Clear();
            foreach (DataRow RecordEmployee in EmployeesDataTable.Rows)
            {
                Console.WriteLine($"ID : {RecordEmployee["ID"]}\tName : {RecordEmployee["Name"]}\tCountry : {RecordEmployee["Country"]}" +
                    $"\tSalary : {RecordEmployee["Salary"]}\tDate : {RecordEmployee["Date"]}");
            }
            */

           


            Console.ReadKey();
        }
    }
}
