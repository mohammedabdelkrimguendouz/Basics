using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public class clsPerson
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }   

        public clsPerson(int ID, string FirstName, string LastName, string Title)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
        }

        public string FullName
        {
            get
            {
                return FirstName +' '+ LastName;
            }
        }
    }

    public class clsEmployee:clsPerson
    {
        public float Salary {  get; set; }  
        public string DepartmentName {  get; set; }

        public clsEmployee(int ID, string FirstName, string LastName, string Title,
            float Salary, string DepartmentName) : base(ID, FirstName, LastName, Title)
        {
            this.Salary = Salary;
            this.DepartmentName = DepartmentName;
        }

        public void IncreaseSalaryBy(float Amount)
        {
            Salary += Amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Employee
            clsEmployee Employee1 = new clsEmployee(10, "Mohammed", "Abu-Hadhoud", "Mr.", 5000, "IT");

            //the following inherited from base class person
            
            Console.WriteLine("Accessing Object 1 (Employee1):\n");
            Console.WriteLine("ID := {0}", Employee1.ID);
            Console.WriteLine("Title := {0}", Employee1.Title);
            Console.WriteLine("Full Name := {0}", Employee1.FullName);
            Console.WriteLine("Department Name := {0}", Employee1.DepartmentName);
            Console.WriteLine("Salary := {0}", Employee1.Salary);

            Employee1.IncreaseSalaryBy(200);
            Console.WriteLine("Salary after increase := {0}", Employee1.Salary);
            Console.ReadKey();
        }
    }
}
