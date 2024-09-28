using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Insertion_Sort
{
    internal class Program
    {
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1 ; i++)
            {
                int j = i + 1;
                int Key = arr[j];
                while (j > 0 && Key < arr[j-1])
                {
                    arr[j]= arr[j-1];
                    j--;
                }
                arr[j] = Key;
            }
        }
      
        static void Main(string[] args)
        {
            int[] arr = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine($"Original Array : {string.Join(" , ", arr)}");

            InsertionSort(arr);

            Console.WriteLine($"Sorted Array : {string.Join(" , ", arr)}");

            Console.ReadKey();
        }
    }
}
