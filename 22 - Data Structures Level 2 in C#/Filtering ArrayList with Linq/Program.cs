using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_ArrayList_with_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n-----------------------Exemple 1---------------------------\n");
            ArrayList arrayList = new ArrayList { 10,9,8,7,6,5,4,3,2,1,0,2 };


            //we use cast here to convert it to int first then we apply the filter.
            var evenNumbers = arrayList.Cast<int>().Where(num => (num % 2 == 0));


            Console.WriteLine("All even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("\n-----------------------Exemple 2---------------------------\n");

            var minValue = arrayList.Cast<int>().Min();
            var maxValue = arrayList.Cast<int>().Max();
            var Sum = arrayList.Cast<int>().Sum();
            var Average = arrayList.Cast<int>().Average();
            var Count = arrayList.Cast<int>().Count();

            Console.WriteLine("\nArrayList Items: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i].ToString() + " ");
            }

            Console.WriteLine("\n\nMinimum value in the ArrayList: " + minValue);
            Console.WriteLine("Maximum value in the ArrayList: " + maxValue);
            Console.WriteLine("Sum values in the ArrayList: " + Sum);
            Console.WriteLine("Average values in the ArrayList: " + Average);
            Console.WriteLine("Count Items in the ArrayList: " + Count);
            
            arrayList.Sort();
            Console.WriteLine("\nArrayList Items After Sorting: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i].ToString() + " ");
            }


            Console.WriteLine("\n-----------------------Exemple 3---------------------------\n");


            int targetNumber = 2;

            var count = arrayList.Cast<int>().Count(num => num == targetNumber);

            Console.WriteLine($"Number of occurrences of {targetNumber} in the ArrayList: {count}");

            Console.ReadKey();
        }
    }
}
