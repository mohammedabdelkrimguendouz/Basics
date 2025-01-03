﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Sets_with_SortedSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5, 6, 7 };


            // Check if set1 is equal to set2
            bool areEqual = set1.SetEquals(set2);
            Console.WriteLine("Are set1 and set2 equal ? " + areEqual);


            // Check if set1 is a subset of set2
            bool isSubset = set1.IsSubsetOf(set2);
            Console.WriteLine("Is set1 a subset of set2 ? " + isSubset);


            // Check if set1 is a superset of set2
            bool isSuperset = set1.IsSupersetOf(set2);
            Console.WriteLine("Is set1 a superset of set2 ? " + isSuperset);

            // Check if Overlaps set1 & set2
            bool isOverlaps = set1.Overlaps(set2);
            Console.WriteLine("Is Overlaps set1 & set2 ? " + isOverlaps);
            Console.ReadKey();
        }
    }
}
