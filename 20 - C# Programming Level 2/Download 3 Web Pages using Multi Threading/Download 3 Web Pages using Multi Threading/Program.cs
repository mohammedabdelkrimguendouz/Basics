using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Download_3_Web_Pages_using_Multi_Threading
{
    internal class Program
    {
        static void DownloadAndPrint(string URL)
        {
            string Content;
            using(WebClient Client=new WebClient())
            {
                Thread.Sleep(100);
                Content=Client.DownloadString(URL);
            }
            Console.WriteLine($" {URL} : {Content.Length} Charaters Downloaded");
            using(StreamWriter sw=new StreamWriter("Content.txt",true))
            {
                sw.WriteLine(URL + " : \n\n");
                sw.WriteLine(Content);
                sw.WriteLine("\n\n\n\n\n");
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => DownloadAndPrint("https://programmingadvices.com"));
            thread1.Start();
            Console.WriteLine("\nThread 1 started ...");
            Thread thread2 = new Thread(() => DownloadAndPrint("https://www.amazon.com"));
            thread2.Start();
            Console.WriteLine("\nThread 2 started ...");
            Thread thread3 = new Thread(() => DownloadAndPrint("https://www.cnn.com"));
            thread3.Start();
            Console.WriteLine("\nThread 3 started ...");

            thread1.Join();
            thread2.Join();
            thread3.Join();


            Console.WriteLine("\n\nDone all threads finish execution");
            Console.ReadKey();
        }
    }
}
