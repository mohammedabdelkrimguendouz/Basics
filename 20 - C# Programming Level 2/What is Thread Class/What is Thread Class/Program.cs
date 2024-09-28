using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace What_is_Thread_Class
{
    internal class Program
    {
        static void Method1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method1: " + i);
                Thread.Sleep(500);
            }
        }
        static void Method2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Method2: " + i);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            // Note that your program is the main thread.


            // Create a new thread and start it
            Thread thread = new Thread(Method1);
            thread.Start();
            Thread thread2 = new Thread(Method2);
            thread2.Start();

            //thread.Join(); 
            //thread2.Join(); 
            // join() method will wait for thread to finish it's execution then the main thread will continue execution.

            //Method1();
            // Main thread continues its execution
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("Main: " + i);
                Thread.Sleep(500); 
            }
            Console.ReadKey();
        }
    }
}
