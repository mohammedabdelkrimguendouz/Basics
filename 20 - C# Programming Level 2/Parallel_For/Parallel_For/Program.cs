using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_For
{
    internal class Program
    {
        static void ProcessIteration(int i)
        {
            Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");
            // Simulate some work
            Task.Delay(1000).Wait();
        }
        static void Main(string[] args)
        {
            // Define the number of iterations
            int numberOfIterations = 10;

            // Use Parallel.For to execute the loop in parallel
            Parallel.For(0, numberOfIterations, ProcessIteration);

            // Or 

            // Use Parallel.For to execute the loop in parallel
            //Parallel.For(0, numberOfIterations, i =>
            //{
            //    Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");
            //    // Simulate some work
            //    Task.Delay(1000).Wait();
            //});


            Console.WriteLine("All iterations completed.");
            Console.ReadKey();
        }
    }
}
