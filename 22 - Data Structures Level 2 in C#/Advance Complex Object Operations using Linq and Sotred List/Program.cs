using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Complex_Object_Operations_using_Linq_and_Sotred_List
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }


        public Employee(string name, string department, decimal salary)
        {
            Name = name;
            Department = department;
            Salary = salary;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, Employee> employees = new SortedList<int, Employee>()
        {
            { 1, new Employee("Alice", "HR", 50000) },
            { 2, new Employee("Bob", "IT", 70000) },
            { 3, new Employee("Charlie", "HR", 52000) },
            { 4, new Employee("Daisy", "IT", 80000) },
            { 5, new Employee("Ethan", "Marketing", 45000) }
        };


            var query = employees
                .Where(e => e.Value.Department == "IT")
                .OrderByDescending(e => e.Value.Salary)
                .Select(e => e.Value.Name);


            Console.WriteLine("IT Department Employees sorted by Salary (Descending):");
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }

            var query2 = employees
               .Where(e => e.Value.Department == "HR")
               .OrderBy(e => e.Value.Salary);
        
            Console.WriteLine("HR Department Employees sorted by Salary (Ascending):");
            foreach (var employee in query2)
            {
                Console.WriteLine($"Key : {employee.Key} --> Value : Name : {employee.Value.Name} , " +
                    $"Department : {employee.Value.Name} , Salary : {employee.Value.Salary} ");
            }


            var query3 = employees
                .Where(e => e.Value.Salary >50000)
                .OrderBy(e => e.Value.Salary)
                .Select(e => e.Value.Name);


            Console.WriteLine("  Employees Salary > 50000 sorted by Salary (Descending):");
            foreach (var name in query3)
            {
                Console.WriteLine(name);
            }


            Console.ReadKey();
        }
    }
}
