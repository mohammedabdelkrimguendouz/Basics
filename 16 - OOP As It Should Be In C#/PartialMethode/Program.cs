using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the code of Person Class is seperated in 2 files Person1.cs and PersonPrinting.cs
            Person person1 = new Person();
            person1.Age = 25;
            person1.Birthday(); // Output: "Current age: 26"
            Console.ReadKey();

        }
    }
}
