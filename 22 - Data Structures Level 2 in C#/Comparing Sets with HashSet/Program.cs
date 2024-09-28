using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_Sets_with_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using SetEquals with HashSet
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set3 = new HashSet<int> { 3, 4, 5 };
            Console.WriteLine("\nset1 equals set2: " + set1.SetEquals(set2));
            Console.WriteLine("set1 equals set3: " + set1.SetEquals(set3));


            //Using IsSubsetOf with HashSet
            HashSet<int> set4 = new HashSet<int> { 1, 2 };
            HashSet<int> set5 = new HashSet<int> { 1, 2, 3,4,5 };
            Console.WriteLine("\nset4 is a subset of set5: " + set4.IsSubsetOf(set5));
            Console.WriteLine("set5 is a subset of set4: " + set5.IsSubsetOf(set4));

            //Using IsSupersetOf with HashSet 
            Console.WriteLine("\nset4 is a superset of set5: " + set4.IsSupersetOf(set5));
            Console.WriteLine("set5 is a superset of set4: " + set5.IsSupersetOf(set4));

            //Using Overlaps with HashSet
            HashSet<int> set6 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set7 = new HashSet<int> { 3, 4, 5 };
            HashSet<int> set8 = new HashSet<int> { 6, 7, 8 };
            Console.WriteLine("\nset6 overlaps set7: " + set6.Overlaps(set7));
            Console.WriteLine("set6 overlaps set8: " + set6.Overlaps(set8));

            Console.ReadKey();
        }
    }
}
