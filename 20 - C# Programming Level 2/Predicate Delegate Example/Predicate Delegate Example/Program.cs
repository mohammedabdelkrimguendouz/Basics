using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Delegate_Example
{
    internal class Program
    {
        static Predicate<int> IsEvenPredicate=IsEven;

        static bool IsEven(int X)
        {
            return X%2 == 0;
        }
        static void Main(string[] args)
        {
            bool Result=IsEvenPredicate(6);
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
