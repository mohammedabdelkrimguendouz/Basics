using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructore
{
    class clsPerson
    {

        public clsPerson()
        {
            Console.WriteLine("Constructor called.");
        }

        // destructor
        ~clsPerson()
        {
            Console.WriteLine("Destructor called.");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creates object of Person
            clsPerson p1 = new clsPerson();
            Console.ReadKey();
        }
    }
}
