using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Delegate_Example
{
    
    internal class Program
    {
        static Func<int, int> Square = SquareMethode;
        public static int SquareMethode(int X)
        {
            return X * X;
        }
        static void Main(string[] args)
        {
            int Result = Square(5);
            Console.WriteLine("Resulte is : " + Result);
            Console.ReadKey();
        }
    }
}
