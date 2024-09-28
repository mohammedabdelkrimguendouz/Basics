using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Class_Example_2
{
    internal class Program
    {
        static async Task DownloadAndPrintAsync(string URL)
        {
            string Content;
            using (WebClient Client = new WebClient())
            {
                await Task.Delay(500);
                Content = await Client.DownloadStringTaskAsync(URL);
            }
            Console.WriteLine($" {URL} : {Content.Length} Charaters Downloaded");
        }
        static async Task Main(string[] args)
        {
            Task Task1 = DownloadAndPrintAsync("https://programmingadvices.com");
            Console.WriteLine("\nTask 1 started ...");

            Task Task2 = DownloadAndPrintAsync("https://www.amazon.com");
            Console.WriteLine("\nTask 2 started ...");

            Task Task3= DownloadAndPrintAsync("https://www.cnn.com");
            Console.WriteLine("\nTask 3 started ...");


            await Task.WhenAll(Task1, Task2, Task3);

            Console.WriteLine("\n\nDone all Tasks finish execution");
            Console.ReadKey();
        }
    }
}
