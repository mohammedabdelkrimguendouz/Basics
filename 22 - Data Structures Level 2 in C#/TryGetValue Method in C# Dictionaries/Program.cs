﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryGetValue_Method_in_C__Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating and initializing the dictionary
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
            {
                  { "Apple", 5 },
                  { "Banana", 2 }
            };


            // Using TryGetValue
            if (fruitBasket.TryGetValue("Apple", out int appleQuantity))
            {
                Console.WriteLine($"Apple quantity: {appleQuantity}");
            }
            else
            {
                Console.WriteLine("Apple not found in the basket.");
            }


            //the following line will make exception error because orange is not there.
            // Console.WriteLine($"Orange quantity: {fruitBasket["Orange"]}");


            // Using TryGetValue
            if (fruitBasket.TryGetValue("Orange", out int OrangeQuantity))
            {
                Console.WriteLine($"Orange quantity: {OrangeQuantity}");
            }
            else
            {
                Console.WriteLine("Orange not found in the basket.");
            }

            Console.ReadKey();
        }
    }
}
