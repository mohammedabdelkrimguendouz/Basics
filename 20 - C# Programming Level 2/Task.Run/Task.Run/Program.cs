using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskRun
{
    internal class Program
    {
        static void DownloadFile(string TaskName)
        {
            Console.WriteLine($"{TaskName} Started ");

            Thread.Sleep(2000);

            Console.WriteLine($"{TaskName} Completed ");
        }
        static async Task Main(string[] args)
        {
            Task Task1=Task.Run(()=>DownloadFile("Download File 1"));
            Task Task2 = Task.Run(() => DownloadFile("Download File 2"));

            await Task.WhenAll(Task1,Task2);

            Console.WriteLine($"task 1 and task 2 completed ");
            Console.ReadKey();
        }
    }
}
