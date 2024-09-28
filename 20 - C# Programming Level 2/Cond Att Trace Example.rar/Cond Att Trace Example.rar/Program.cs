//#define Koko

//#define TRACE_ENABLED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cond_Att_Trace_Example.rar
{
    internal class Program
    {
        [Conditional("Koko")]
        public static void  LogKoko(string message)
        {
            Console.WriteLine($"[Koko] = {message}");
        }
        [Conditional("TRACE_ENABLED")]
        public static void LogTrace(string message)
        {
            Console.WriteLine($"[TRACE] = {message}");
        }
        static void Main(string[] args)
        {
            LogTrace("Welcom Log TRACE");
            LogKoko("Welcom Log Koko");
            Console.WriteLine($"reset program");
            Console.ReadKey();
        }
    }
}
