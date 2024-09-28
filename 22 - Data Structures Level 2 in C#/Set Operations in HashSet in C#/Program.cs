using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Operations_in_HashSet_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 0,1, 2, 3,4,5 };
            HashSet<int> set2 = new HashSet<int> { 4, 5,6,7,8,9,0 };


            // Union of set1 and set2
            //set1.UnionWith(set2);

            //Console.WriteLine("Union of sets:");
            //foreach (int item in set1)
            //{
            //    Console.WriteLine(item);
            //}

            //Intersect of set1 and set2
            //set1.IntersectWith(set2);

            //Console.WriteLine("Intersect of sets:");
            //foreach (int item in set1)
            //{
            //    Console.WriteLine(item);
            //}


            //Difference  of set1 - set2
            //set1.ExceptWith(set2);
            //Console.WriteLine("Difference  of set1 - set2:");
            //foreach (int item in set1)
            //{
            //    Console.WriteLine(item);
            //}

            //Difference  of set2 - set1
            //set2.ExceptWith(set1);
            //Console.WriteLine("Difference  of set2 - set1:");
            //foreach (int item in set2)
            //{
            //    Console.WriteLine(item);
            //}

            //Symmetric Difference  Between set1 and set2
            set1.SymmetricExceptWith(set2);
            Console.WriteLine("Symmetric Difference  Between set1 and set2 :");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
