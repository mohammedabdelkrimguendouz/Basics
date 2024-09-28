using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilizing_LINQ_with_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating and initializing the dictionary
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


            // Using LINQ to transform items
            var fruitInfo = fruitBasket.Select(kpv => new { kpv.Key, kpv.Value });


            // Displaying the results
            Console.WriteLine("Transformed Items:");
            foreach (var item in fruitInfo)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }




            // Using LINQ to filter items
            var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);


            Console.WriteLine("\nFiltered Items >3:");
            foreach (var item in filteredFruit)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }


            // Using LINQ to sort by value
            var sortedByQuantity = fruitBasket.OrderBy(kpv => kpv.Value);


            Console.WriteLine("\nSorted Items:");
            foreach (var item in sortedByQuantity)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }


            // Using LINQ to sort by value
            var sortedByQuantityDesc = fruitBasket.OrderByDescending(kpv => kpv.Value);


            Console.WriteLine("\nSorted Items Desc:");
            foreach (var item in sortedByQuantityDesc)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            // Using LINQ to aggregate data
            int totalQuantity = fruitBasket.Sum(kpv => kpv.Value);
            Console.WriteLine($"\nTotal Quantity: {totalQuantity}");

            double AvgQuantity = fruitBasket.Average(kvp => kvp.Value);
            Console.WriteLine($"\nAvarge Quantity: {AvgQuantity}");

            int MaxQuantity = fruitBasket.Max(kpv => kpv.Value);
            Console.WriteLine($"\nMax Quantity: {MaxQuantity}");

            int MinQuantity = fruitBasket.Min(kpv => kpv.Value);
            Console.WriteLine($"\nMin Quantity: {MinQuantity}");


            Console.ReadKey();
        }
    }
}
