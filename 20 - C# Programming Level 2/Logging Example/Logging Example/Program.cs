using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Logging_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SourceName = "KokoApp";
            if(!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
                //EventLog.CreateEventSource(SourceName, "Security");
                //EventLog.CreateEventSource(SourceName, "Setup");
                //EventLog.CreateEventSource(SourceName, "System");
                Console.WriteLine("\nEvent Created");
            }
            EventLog.WriteEntry(SourceName, "this is information -) ", EventLogEntryType.Information);

            EventLog.WriteEntry(SourceName, "this is Werning -) ", EventLogEntryType.Warning);

            EventLog.WriteEntry(SourceName, "this is Error -( ", EventLogEntryType.Error);

            Console.WriteLine("\nEvent Writed");

            Console.ReadKey();
        }
    }
}
