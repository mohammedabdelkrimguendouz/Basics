using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int valType = 10;

            object objType = valType; // Boxing

            int unboxedValType = (int)objType; // Unboxing


            Console.WriteLine("Unboxed Value: " + unboxedValType);

            Console.ReadKey();
        }
    }
}
