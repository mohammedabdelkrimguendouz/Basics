using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_LINQ_Queries_with_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary for grouping
            Dictionary<string, string> fruitsCategory = new Dictionary<string, string>
        {
            { "Apple", "Tree" },
            { "Banana", "Herb" },
            { "Cherry", "Tree" },
            { "Strawberry", "Bush" },
            { "Raspberry", "Bush" }
        };


            // Grouping fruits by category
            var groupedFruits = fruitsCategory.GroupBy(kpv => kpv.Value);
            foreach (var group in groupedFruits)
            {
                Console.WriteLine($"Category: {group.Key}");
                foreach (var fruit in group)
                {
                    Console.WriteLine($" - {fruit.Key}");
                }
            }


            // Another Dictionary for combined queries
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Orange", 5 },
            { "Banana", 2 },
            { "Apple", 7 }
        };


            // Combined LINQ queries
            var sortedFilteredFruits = fruitBasket.Where(kvp => kvp.Value > 3).
                                                   OrderBy(kvp => kvp.Key).
                                                   Select(kvp => new { kvp.Key, kvp.Value });
            

            Console.WriteLine("\nSorted and Filtered Fruits :");
            foreach (var fruit in sortedFilteredFruits)
            { 
                Console.WriteLine($"Fruit: {fruit.Key}, Quantity: {fruit.Value}");
            }

            Console.ReadKey();
        }
    }
}
