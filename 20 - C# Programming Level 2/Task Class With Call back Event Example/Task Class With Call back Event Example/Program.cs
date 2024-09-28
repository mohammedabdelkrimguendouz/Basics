using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_Class_With_Call_back_Event_Example
{
    public class CustomEventArgs:EventArgs
    {
        public int Parameter1 { get; }
        public string Parameter2 { get; }

        public CustomEventArgs(int parameter1, string parameter2)
        {
            Parameter1 = parameter1;
            Parameter2 = parameter2;
        }
    }
    internal class Program
    {
        public delegate void CallBackEventHandler(object sender, CustomEventArgs e);
        public  static event CallBackEventHandler CallBackEvent;

        static void OnCallBackReceived(object sender, CustomEventArgs e)
        {
            Console.WriteLine($"Event Received --> Parameter1 : {e.Parameter1} ,Parameter2 : {e.Parameter2} ");
        }
        static async Task PerformAsyncOperation(CallBackEventHandler CallBack)
        {
            await Task.Delay(2000);
            CustomEventArgs eventArgs = new CustomEventArgs(42, "Karim");
            CallBack.Invoke(null, eventArgs);
        }
        static async Task Main(string[] args)
        {
            CallBackEvent += OnCallBackReceived;

            Task PerformTask=PerformAsyncOperation(CallBackEvent);

            Console.WriteLine($"Doing some other work... ");

            await PerformTask;

            Console.WriteLine($"Done.");



            Console.ReadKey();
        }
    }
}
