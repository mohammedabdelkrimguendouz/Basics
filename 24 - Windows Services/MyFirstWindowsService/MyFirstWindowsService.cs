using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWindowsService
{
    public partial class MyFirstWindowsService : ServiceBase
    {
        public MyFirstWindowsService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            string LogDirectory = @"C:/Logs";
            string LogFilePath = Path.Combine(LogDirectory,"MyServiceLogs.txt");

            if (!Directory.Exists(LogDirectory))
                Directory.CreateDirectory(LogDirectory);

            string LogMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Service Started\n";
            File.AppendAllText(LogFilePath, LogMessage);
        }

        protected override void OnStop()
        {
            string LogDirectory = @"C:/Logs";
            string LogFilePath = Path.Combine(LogDirectory, "MyServiceLogs.txt");

            if (!Directory.Exists(LogDirectory))
                Directory.CreateDirectory(LogDirectory);

            string LogMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Service Stoped\n";
            File.AppendAllText(LogFilePath, LogMessage);
        }


    }

}
