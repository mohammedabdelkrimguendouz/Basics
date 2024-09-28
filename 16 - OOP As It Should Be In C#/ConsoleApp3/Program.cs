using System;
using MyFirstClassLibrary;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsMyMath MyMath1=new clsMyMath();
            Console.WriteLine(MyMath1.Sum(20, 30, 45));
            Console.ReadKey();
        }
    }
}
