﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();


            // Insertion
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);


            // Traversal
            Console.WriteLine("Linked List:");
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }


            // Deletion
            linkedList.Remove(2);


            // Search
            if (linkedList.Contains(3))
            {
                Console.WriteLine("Element 3 found.");
            }
            else
            {
                Console.WriteLine("Element 3 not found.");
            }
            Console.ReadKey();
        }
    }
}
