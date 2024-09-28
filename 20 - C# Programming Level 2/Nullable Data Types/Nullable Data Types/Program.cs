using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> nullableInt=null;

            int? nullableInt2=null;
            if (nullableInt.HasValue)
            {
                Console.WriteLine(" Value is : " + nullableInt.Value);
            }
            else
                Console.WriteLine("not Value ");

            nullableInt2 = 5;
            if (nullableInt.HasValue)
            {
                Console.WriteLine(" Value is : " + nullableInt.Value);
            }
            else
                Console.WriteLine("not Value ");

            int Result = nullableInt2 ?? 0;
            // if nullableInt2==null --> defaulte value to result 
            // if nullableInt2!=null -->  value to result=nullableInt2

            string strValue = nullableInt2?.ToString();
            // if nullableInt2==null -->  not Convert nullableInt2 to string
            // if nullableInt2!=null -->  Convert nullableInt2 to string
            Console.ReadKey();
        }
    }
}
