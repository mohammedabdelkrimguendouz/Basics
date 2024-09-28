using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    internal class Program
    {
        public static void ConcatenateStrings(ulong Iteration)
        {
            string result = "";
            for (ulong i = 0; i < Iteration; i++)
            {
                result += "a";
            }

        }
        public static void ConcatenateStringBuilder(ulong Iteration)
        {
            StringBuilder sb = new StringBuilder();
            
            for (ulong i = 0; i < Iteration; i++)
            {
                sb.Append("a");
            }
            string result = sb.ToString();
        }
        static void Main(string[] args)
        {
            ulong Iteration = 9000000000000000000;
            Stopwatch StopWatch1 = Stopwatch.StartNew();
            ConcatenateStrings(Iteration);
            StopWatch1.Stop();
            Console.WriteLine($"\n Concatenate Strings = {StopWatch1.ElapsedMilliseconds} ms");


            Stopwatch StopWatch2 = Stopwatch.StartNew();
            ConcatenateStringBuilder(Iteration);
            StopWatch2.Stop();
            Console.WriteLine($"\n Concatenate Strings  builder = {StopWatch2.ElapsedMilliseconds} ms");


            Console.ReadKey();
        }
    }
}
