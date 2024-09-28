using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_SortedDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a SortedDictionary with string keys and integer values
            SortedDictionary<string, int> sortedDict = new SortedDictionary<string, int>();

            // Adding elements to the SortedDictionary
            sortedDict.Add("apple", 10);
            sortedDict.Add("banana", 20);
            sortedDict.Add("orange", 15);

            // Displaying the contents of the SortedDictionary
            Console.WriteLine("Contents of the SortedDictionary:");
            foreach (KeyValuePair<string,int> kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Accessing values by key
            Console.WriteLine("\nAccessing values by key:");
            Console.WriteLine($"Value of 'apple': {sortedDict["apple"]}");
            Console.WriteLine($"Value of 'orange': {sortedDict["orange"]}");

            // Checking if a key exists
            Console.WriteLine("\nChecking if a key exists:");
            Console.WriteLine($"Contains 'banana': {sortedDict.ContainsKey("banana")}");
            Console.WriteLine($"Contains 'grape': {sortedDict.ContainsKey("grape")}");

            var filter = sortedDict.Where(kvp => kvp.Value > 10);
            Console.WriteLine("\nContents of the SortedDictionary where Qountity > 10:\n");
            foreach (var kvp in filter)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine("Sum is :" + sortedDict.Sum(KeyValuePair=>KeyValuePair.Value));
            Console.WriteLine("Avarge is :" + sortedDict.Average(KeyValuePair => KeyValuePair.Value));
            Console.WriteLine("Max is :" + sortedDict.Max(KeyValuePair => KeyValuePair.Value));
            Console.WriteLine("Min is :" + sortedDict.Min(KeyValuePair => KeyValuePair.Value));
            

            // Removing an element
            sortedDict.Remove("banana");

            // Displaying the contents after removal
            Console.WriteLine("\nContents of the SortedDictionary after removal:");
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
            Console.ReadKey();
        }
    }
}
