﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Invoke
{
    internal class Program
    {
        static void Function1()
        {
            Console.WriteLine("Function 1 is starting.");
            Task.Delay(1000).Wait(); // Simulating work
            Console.WriteLine("Function 1 is completed.");
        }


        static void Function2()
        {
            Console.WriteLine("Function 2 is starting.");
            Task.Delay(1000).Wait(); // Simulating work
            Console.WriteLine("Function 2 is completed.");
        }


        static void Function3()
        {
            Console.WriteLine("Function 3 is starting.");
            Task.Delay(1000).Wait(); // Simulating work
            Console.WriteLine("Function 3 is completed.");
        }
        static void Main(string[] args)
        {
            // Run the functions in parallel
            Console.WriteLine("Starting parallel functions.");
            Parallel.Invoke(Function1, Function2, Function3);

            Console.WriteLine("All parallel functions are completed.");

            Parallel.Invoke(
            () => Console.WriteLine($"Action 1 on thread {Task.CurrentId}"),
            () => Console.WriteLine($"Action 2 on thread {Task.CurrentId}"),
            () => Console.WriteLine($"Action 3 on thread {Task.CurrentId}")
        );

            
            Console.ReadKey();
        }
    }
}
