using System;
using MyFirstClassLibrary;
internal class Program
{
   static void Main(string[] args)
   {
        
        clsMyMath MyMath1 = new clsMyMath();
        Console.WriteLine( MyMath1.Sum(1, 2));

        clsMyMath MyMath2 = new clsMyMath();
        Console.WriteLine(MyMath2.Sum(12, 4,4));
        Console.ReadKey();
    }
}
