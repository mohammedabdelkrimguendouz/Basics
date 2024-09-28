﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a new List of integers
            List<int> numbers = new List<int>();

            Console.WriteLine("Capacity: " + numbers.Capacity);
            // Adding elements to the list
            numbers.Add(1); // Add 1 to the list
            Console.WriteLine("Capacity: " + numbers.Capacity);
            numbers.Add(2); // Add 2 to the list
            numbers.Add(3); // Add 3 to the list
            numbers.Add(4); // Add 4 to the list
            numbers.Add(5); // Add 5 to the list
         
            // Displaying the total number of elements in the list
            Console.WriteLine("Number of items in the list: " + numbers.Count);
            Console.WriteLine("Capacity: " + numbers.Capacity);
            Console.WriteLine("Contains 5 : " + numbers.Contains(5));
            Console.WriteLine("Max  : " + numbers.Max());
            Console.WriteLine("Min  : " + numbers.Min());
            Console.WriteLine("Average  : " + numbers.Average());
           

            // Accessing and displaying each element in the list
            Console.WriteLine(numbers[0]); // Displays the first element (1)
            Console.WriteLine(numbers[1]); // Displays the second element (2)
            Console.WriteLine(numbers[2]); // Displays the third element (3)
            Console.WriteLine(numbers[3]); // Displays the fourth element (4)
            Console.WriteLine(numbers[4]); // Displays the fifth element (5)


            // Modifying an element in the list
            Console.WriteLine("Changing the value of item 2 of the list to 500:");
            numbers[1] = 500; // Change the value of the second element to 500
            Console.WriteLine(numbers[1]); // Displays the new value of the second element (500)

            Console.ReadKey();

        }
    }
}
