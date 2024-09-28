using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_LINQ_with_HashSet_Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating and populating a HashSet of strings
            HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona","Yacine" };


            // Using LINQ to filter names that start with 'C'
            var namesStartingWithC = names.Where(name => name.StartsWith("C"));


            // Displaying the names starting with 'C'
            Console.WriteLine("Names Starting with C:");
            foreach (var name in namesStartingWithC)
            {
                Console.WriteLine(name);
            }

            // Using LINQ to filter names that start with 'C'
            var namesEndingWithe = names.Where(name => name.EndsWith("e"));


            // Displaying the names starting with 'C'
            Console.WriteLine("Names Ending with e:");
            foreach (var name in namesEndingWithe)
            {
                Console.WriteLine(name);
            }


            // Using LINQ to find names with length equal than 5 characters
            var namesLongerEqualFive = names.Where(name => name.Length == 5);


            // Displaying the names longer than four characters
            Console.WriteLine("\nNames Longer Equal Five Characters:");
            foreach (var name in namesLongerEqualFive)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
