using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetInC_
{

    class clsEmployee
    {
        private int _ID;
        private string _Name = string.Empty;

        public int ID
        {
            // Read only
            get
            {
                return _ID;
            }
        }
        public string Name
        {

            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of Employee class.

        clsEmployee Employee1 = new clsEmployee();

        //Employee1.ID = 7;
        Employee1.Name = "Mohammed Abu-Hadhoud";

        Console.WriteLine("Employee Id:={0}", Employee1.ID);
        Console.WriteLine("Employee Name:={0}", Employee1.Name);
        Console.ReadLine();
        }
    }
}
