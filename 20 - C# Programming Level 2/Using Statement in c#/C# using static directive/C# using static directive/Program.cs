using System;
using static System.Math;

namespace C__using_static_directive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = Sqrt(9);
            Console.WriteLine("Square root of 9 is " + n);
            Console.ReadKey();
        }
    }
}
