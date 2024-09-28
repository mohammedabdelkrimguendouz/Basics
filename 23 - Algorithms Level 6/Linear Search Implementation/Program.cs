using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search_Implementation
{
    internal class Program
    {
        static int LinearSearch(int[] arr,int NumberSearch)
        {
            for(int i = 0;i<arr.Length;i++)
            {
                if(arr[i] == NumberSearch)
                    return i;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 4, 0, -4, 5, 9, 1, 3, 8, 45, 17, 20, 44 };

            int NumberSearch = 17;

            Console.WriteLine($" Index is  Number Search {NumberSearch} : [{ LinearSearch(arr,NumberSearch )}]");

            Console.ReadKey();
        }
    }
}
