using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable MyHashTable = new Hashtable();

            MyHashTable.Add("Key1", "Value1");
            MyHashTable.Add("Key2", "Value2");
            MyHashTable.Add("Key3", "Value3");

            Console.WriteLine("Is Exist value1 :"+ MyHashTable.ContainsValue("Value1"));

            Console.WriteLine("Is Exist Key4 :" + MyHashTable.ContainsKey("Key4"));

            // Accessing an element
            Console.WriteLine($"Accessing key1: {MyHashTable["Key1"]}");


            // Modifying an element
            MyHashTable["Key1"] = "newValue1";

            
            // Removing an element
            MyHashTable.Remove("Key2");

            // Iterating over elements
            Console.WriteLine("\nCurrent Hashtable contents:");
            foreach (DictionaryEntry entry in MyHashTable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
            Console.ReadKey();

            
        }
    }
}
