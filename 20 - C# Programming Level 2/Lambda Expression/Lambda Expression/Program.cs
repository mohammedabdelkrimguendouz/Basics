using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression
{
    internal class Program
    {
        static void ExecuteOperation(int X,int Y, Func<int, int, int> Operation)
        {
            int Result=Operation(X,Y);
            Console.WriteLine(Result);
        }
        static void Main(string[] args)
        {
            Func<int, int, int> Add = (X, Y) => X + Y;
            Func<int, int, int> Sub = (X, Y) => X - Y;
            ExecuteOperation(10, 20, Add);
            ExecuteOperation(10, 20, Sub);
            Console.ReadKey();
        }
    }
}
