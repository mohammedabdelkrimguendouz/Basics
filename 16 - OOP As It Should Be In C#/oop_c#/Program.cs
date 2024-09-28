using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_c_
{

    class clsPerson
    {
        public string FirstName;
        public string LastName;
        public string FullName()
        {
            return FirstName + ' ' + LastName;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Create object from class
            clsPerson Person1 = new clsPerson();


            Console.WriteLine("Accessing Object 1 (Person1):");
            Person1.FirstName = "Mohammed";
            Person1.LastName = "Abu-Hadhoud";
            Console.WriteLine(Person1.FullName());


            //Create another object from class
            clsPerson Person2 = new clsPerson();
            Console.WriteLine("\nAccessing Object 2 (Person2):");
            Person2.FirstName = "Ali";
            Person2.LastName = "Maher";
            Console.WriteLine(Person2.FullName());
            Console.ReadKey();

        }
    }
}
