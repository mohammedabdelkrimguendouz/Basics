using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains__Exists__Find__FindAll__and_Any_List_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List initialization
            List<string> words = new List<string> { "apple", "banana", "cherry", "date", "elderberry", "fig", "grape", "honeydew" };


            // Using Contains
            Console.WriteLine("List contains 'date': " + words.Contains("date"));


            // Using Exists
            Console.WriteLine("List contains a word of length 5: " + words.Exists(word => word.Length == 5));


            // Using Find
            Console.WriteLine("First word longer than 5 characters: " + words.Find(word => word.Length > 5));


            // Using FindAll
            Console.WriteLine("Words longer than 5 characters: " + string.Join(", ", words.FindAll(word => word.Length > 5)));


            // Using Any
            Console.WriteLine("Any words starting with 'a': " + words.Any(word => word.StartsWith("a")));

            Console.WriteLine("Any words Ending with 'a': " + words.Any(word => word.EndsWith("a")));


            // Waiting for a key press
            Console.ReadKey();
        }
    }
}
