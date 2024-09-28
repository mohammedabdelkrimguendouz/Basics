using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normal_Delegate_Example
{
    public delegate int SquareDelegate(int  X);

    internal class Program
    {
        public static int SquareMethode(int X)
        {
            return X * X;
        }
        static void Main(string[] args)
        {
            SquareDelegate Square = new SquareDelegate(SquareMethode);
            int Resulte = Square(5);
            Console.WriteLine("Resulte is : " + Resulte);
            Console.ReadKey();
        }
    }
}
