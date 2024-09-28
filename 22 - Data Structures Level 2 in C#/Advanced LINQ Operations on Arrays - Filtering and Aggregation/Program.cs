using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_LINQ_Operations_on_Arrays___Filtering_and_Aggregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of numbers
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // Filtering to get only even numbers
            var evenNumbers = numbers.Where(n => n % 2 == 0);


            // Aggregating - calculating the sum of even numbers
            int sumOfEvenNumbers = evenNumbers.Sum();


            // Displaying the results
            Console.WriteLine("Even Numbers:");
            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\nSum of Even Numbers: {sumOfEvenNumbers}");
            Console.WriteLine($"\nAvg of Even Numbers: {evenNumbers.Average()}");
            Console.WriteLine($"\nMax of Even Numbers: {evenNumbers.Max()}");
            Console.WriteLine($"\nMin of Even Numbers: {evenNumbers.Min()}");
            Console.ReadKey();
        }
    }
}
