using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructore
{
    static class Settings
    {
        public static int DayNumber
        {
            get
            {
                return DateTime.Today.Day;
            }
        }


        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }


        public static string ProjectPath
        {
            get;
            set;
        }
        //this is a static constructor will be called once during the program
        static Settings()
        {
            ProjectPath = @"C:\MyProjects\";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // You cannot create an object here because class is static
            //Settings Obj1 = new Settings();

            //
            // Read the static properties.
            //
            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);
            //
            // Change the value of the static bool property.
            //

            Console.WriteLine(Settings.ProjectPath);

            Console.ReadKey();
        }
    }
}
