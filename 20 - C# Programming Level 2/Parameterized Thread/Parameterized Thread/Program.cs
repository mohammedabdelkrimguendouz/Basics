using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parameterized_Thread
{
    internal class Program
    {
        static void Method1(string ThreadName)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {ThreadName} Method1: " + i);
                Thread.Sleep(500);
            }
        }
        static void Method2(string ThreadName)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {ThreadName} Method2: " + i);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {

            // Create a new thread and start it
            Thread thread = new Thread(()=>Method1("Thread1"));
            thread.Start();
            Thread thread2 = new Thread(()=>Method2("Thread2"));
            thread2.Start();

            thread.Join();
            thread2.Join();
            // join() method will wait for thread to finish it's execution then the main thread will continue execution.

            //Method1();
            // Main thread continues its execution
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(" Thread Main: " + i);
                Thread.Sleep(500);
            }
            Console.ReadKey();
        }
    }
}
