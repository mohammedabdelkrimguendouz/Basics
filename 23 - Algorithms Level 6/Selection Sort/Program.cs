using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        static void SelectionSortAscending(int[] arr)
        {
            int n = arr.Length;
            for(int i=0; i<n-1; i++)
            {
                int MinIndex = i;
                for(int j=i+1;j<n;j++)
                {
                    if(arr[j] < arr[MinIndex])
                        MinIndex = j;
                }
                if(i!=MinIndex)
                {
                    int Swap = arr[i];
                    arr[i] = arr[MinIndex];
                    arr[MinIndex] = Swap;
                }
            }
        }
        static void SelectionSortDescending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int MinIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] > arr[MinIndex])
                        MinIndex = j;
                }
                if (i != MinIndex)
                {
                    int Swap = arr[i];
                    arr[i] = arr[MinIndex];
                    arr[MinIndex] = Swap;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {10,9,8,7,6,5,4,3,2,1};

            Console.WriteLine("--------------------------Selection Sort Ascending ---------------------");

            Console.WriteLine($"Original Array : {string.Join(" , ", arr)}");

            SelectionSortAscending(arr);

            Console.WriteLine($"Sorted Array : {string.Join(" , ", arr)}");

            Console.WriteLine("--------------------------Selection Sort Descending ---------------------");

            Console.WriteLine($"Original Array : {string.Join(" , ", arr)}");

            SelectionSortDescending(arr);

            Console.WriteLine($"Sorted Array : {string.Join(" , ", arr)}");


            Console.ReadKey();
        }
    }
}
