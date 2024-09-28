using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logger_Example
{
    public class Logger
    {
        public delegate void LogAction(string Message);

        private LogAction _LogAction;
        
        public Logger(LogAction LogAction)
        {
            _LogAction=LogAction;
        }
        public void Log(string Message)
        {
            _LogAction(Message);
        }
    }
    public class Program
    {
        public static void LogToScreen(string Message)
        {
            Console.WriteLine(Message);
        }
        public static void LogToFile(string Message)
        {
            string FileName = "Log.txt";
            using(StreamWriter Writer = new StreamWriter(FileName,true))
            {
                Writer.WriteLine(Message);
            }
        }
        static void Main(string[] args)
        {
            Logger ScreenLogger = new Logger(LogToScreen);
            Logger FileLogger = new Logger(LogToFile);

            ScreenLogger.Log("Display in screen ");
            FileLogger.Log("Display in File ");

            Console.ReadKey();

        }
    }
}
