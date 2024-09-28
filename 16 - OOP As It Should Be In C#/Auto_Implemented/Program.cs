using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Implemented
{
    class clsEmployee
    {
        public int ID { get; set; }
        public string Name { get; set;}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an object of Employee class.
            clsEmployee Employee1 = new clsEmployee();

            Employee1.ID = 7;
            Employee1.Name = "Mohammed Abu-Hadhoud";


            Console.WriteLine("Employee Id:={0}", Employee1.ID);
            Console.WriteLine("Employee Name:={0}", Employee1.Name);
            Console.ReadLine();
        }
    }
}
