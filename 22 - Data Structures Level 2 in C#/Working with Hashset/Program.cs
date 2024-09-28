using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a HashSet of strings
            HashSet<string> fruits = new HashSet<string>();




            // Adding elements to the HashSet
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");


            // Trying to add a duplicate element
            fruits.Add("Apple"); // This will not be added
            fruits.Add("Apple"); // This will not be added

            Console.WriteLine("Count : "+ fruits.Count);

            List<string> ListFruits= fruits.ToList();

            string[] ArrFruits = fruits.ToArray();

            Console.WriteLine("element of ArrFruits : " + string.Join(" , ", ArrFruits));
            Console.WriteLine("element of ListFruits : " + string.Join(" , ", ListFruits));

            fruits.RemoveWhere(f => f.Length < 6);
            

            // Displaying the elements in the HashSet
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Checking if "Apple" is in the HashSet
            if (fruits.Contains("Apple"))
            {
                Console.WriteLine("Apple is in the HashSet");
            }
            else
            {
                Console.WriteLine("Apple is not in the HashSet");
            }

            if (fruits.Contains("Orange"))
            {
                Console.WriteLine("Orange is in the HashSet");
            }
            else
            {
                Console.WriteLine("Orange is not in the HashSet");
            }


            // Removing "Banana" from the HashSet
            fruits.Remove("Banana");

            Console.WriteLine("\nHashset Item Count after removing Banana = " + fruits.Count.ToString());
            // Displaying the remaining elements
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            //this will remove all elements
            fruits.Clear();
            Console.WriteLine("\nHashset Item Count after clear = " + fruits.Count.ToString());

            Console.ReadKey();
        }
    }
}
