using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Writing_to_Registry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string KeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware";
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
            string ValueName = "YourValueName";
            string ValueData = "YourValueData";

            try
            {
                Registry.SetValue(KeyPath, ValueName, ValueData, RegistryValueKind.String);
                //Console.WriteLine($" value {ValueName} Add successfully .");
            }
            catch(Exception Ex) 
            {
                Console.WriteLine($"Error : {Ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
