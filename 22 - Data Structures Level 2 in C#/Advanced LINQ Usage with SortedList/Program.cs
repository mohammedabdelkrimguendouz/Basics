using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_LINQ_Usage_with_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize a SortedList of int keys and string values with fruit names
            SortedList<int, string> sortedList = new SortedList<int, string>()
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Cherry" },
            { 4, "Date" },
            { 5, "Grape" },
            { 6, "Fig" },
            { 7, "Elderberry" }
        };

            var Groups = sortedList.GroupBy(kvp => kvp.Value.Length);

            foreach(var Group in Groups)
            {
                Console.WriteLine($"Length {Group.Key} : {string.Join(" , ",Group.Select(kvp=>kvp.Value))}");
            }
            Console.ReadKey();
        }
    }
}
