using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reading_from_Registry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string KeyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware";
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
            string ValueName = "YourValueName";


            try
            {
                string ValueData = Registry.GetValue(KeyPath, ValueName, null) as string;
                if (ValueData != null)
                {
                    Console.WriteLine($" valueData is :  {ValueData}.");
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine($"Error : {Ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
