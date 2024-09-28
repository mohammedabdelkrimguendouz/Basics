using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Bubble_Sort
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            bool IsSwaped = false;
            int n = arr.Length;
            for(int i=0;i<n-1;i++)
            { 
                IsSwaped = false;
                for(int j=0; j<arr.Length-1-i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int Swap = arr[j];
                        arr[j]=arr[j+1];
                        arr[j+1]=Swap;

                        IsSwaped = true;
                    }
                    if (!IsSwaped)
                        return;
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {10,9,8,7,6,5,4,3,2,1,0};

            Console.WriteLine($"Original Array : {string.Join(" , ",arr)}");
          
            BubbleSort(arr);

            Console.WriteLine($"Sorted Array : {string.Join(" , ", arr)}");

            Console.ReadKey();
        }
    }
}
