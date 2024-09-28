using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize the jagged array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4 };
            jaggedArray[2] = new int[] { 8,6 };


            // Display the array elements
            Console.WriteLine("Element of Jagged array :");
            for (int Row = 0; Row < jaggedArray.Length; Row++)
            {
                for (int Col = 0; Col < jaggedArray[Row].Length; Col++)
                {
                    Console.Write(jaggedArray[Row][Col] + " ");
                }
                Console.WriteLine();
            }

            // Flatten the jagged array and sum all elements
            int totalSum = jaggedArray.SelectMany(subArr => subArr).Sum();
            Console.WriteLine("Total Sum: " + totalSum);


            // Find the maximum element in the jagged array
            int maxElement = jaggedArray.SelectMany(subArray => subArray).Max();
            Console.WriteLine("Maximum Element: " + maxElement);


            // Filter arrays having more than 3 elements and select their first element
            var firstElements = jaggedArray.Where(subArray => subArray.Length > 3)
                                           .Select(subArray => subArray.First());
            Console.Write("First Elements of Long Rows: ");
            foreach (var element in firstElements)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
        }
    }
}
