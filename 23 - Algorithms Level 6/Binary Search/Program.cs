using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static int BinarySearch(int[] arr, int X)
        {
            int Start = 0;
            int End= arr.Length-1;

            int Iteration = 0;

            while(Start<=End)
            {
                //Console.WriteLine($"Iteration : {++Iteration}");
                int Middle = Start + (End - Start) / 2;

                if (arr[Middle]==X)
                    return Middle;

                if (arr[Middle] > X)
                    End = Middle - 1;
                else
                    Start = Middle + 1;

            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1,12,19,24,30,33,39,44,48,50,52,60,77 };

            int X = 52;

            int Result= BinarySearch(arr, X);

            if(Result!=-1)
                Console.WriteLine($" Element  Found at index : [{Result}]");
            else
                Console.WriteLine($"Element Not Found in the array ");



            Console.ReadKey();
        }
    }
}
