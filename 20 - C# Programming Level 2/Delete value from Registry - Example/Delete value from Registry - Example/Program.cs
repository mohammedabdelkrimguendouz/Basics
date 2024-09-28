﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Delete_value_from_Registry___Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Specify the registry key path and value name
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
            string valueName = "YourValueName";


            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey key = baseKey.OpenSubKey(keyPath,true))
                    {
                        if (key != null)
                        {
                            // Delete the specified value
                            key.DeleteValue(valueName);


                            Console.WriteLine($"Successfully deleted value '{valueName}' from registry key '{keyPath}'");
                        }
                        else
                        {
                            Console.WriteLine($"Registry key '{keyPath}' not found");
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }


            Console.ReadKey();
        }
    }
}
