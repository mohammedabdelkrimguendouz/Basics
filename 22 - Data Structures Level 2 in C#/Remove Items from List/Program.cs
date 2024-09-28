﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Items_from_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List initialization
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12,13,14,15,16,17,18,19,20 };


            // Removing an item by value
            numbers.Remove(5);
            Console.WriteLine("After removing 5: " + string.Join(", ", numbers));


            // Removing an item by index
            numbers.RemoveAt(0);
            Console.WriteLine("After removing first element: " + string.Join(", ", numbers));


            // Removing multiple items
            numbers.RemoveAll(n => n % 2 == 0);
            //numbers.RemoveAll(n => n >10);
            Console.WriteLine("After removing all even numbers: " + string.Join(", ", numbers));

            numbers.RemoveRange(0, 2);
            Console.WriteLine("After removing 2 numbers after first item: " + string.Join(", ", numbers));
            // Clearing the list
            numbers.Clear();
            Console.WriteLine("After clearing the list, count: " + numbers.Count);


            // Waiting for a key press
            Console.ReadKey();
        }
    }
}
