using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Synchronization_Example
{
    internal class Program
    {
        static int sharedCounter = 0;
        static object lockObject = new object();
        static void IncrementCounter()
        {
            for (int i = 0; i < 100000; i++)
            {
                // Use lock to synchronize access to the shared counter
                lock (lockObject)
                {
                    sharedCounter++;
                }
            }
        }
        static void Main(string[] args)
        {
            // Create two threads that increment a shared counter
            Thread t1 = new Thread(IncrementCounter);
            Thread t2 = new Thread(IncrementCounter);


            t1.Start();
            t2.Start();


            // Wait for both threads to complete
            t1.Join();
            t2.Join();


            Console.WriteLine("Final Counter Value: " + sharedCounter);
            Console.ReadKey();
        }
    }
}
