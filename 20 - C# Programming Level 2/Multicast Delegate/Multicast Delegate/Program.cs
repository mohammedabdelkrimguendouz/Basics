using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate
{
    public delegate void MyDelegate(string message);
    
    internal class Program
    {
        static void Method1(string message)
        {
            Console.WriteLine("Method1: " + message);
        }


        static void Method2(string message)
        {
            Console.WriteLine("Method2: " + message);
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate;
            myDelegate = Method1;
            myDelegate += Method2;


            myDelegate("Hello, world!");


            myDelegate -= Method1;
            myDelegate("Another message.");

            Console.ReadKey();
        }
    }
}
