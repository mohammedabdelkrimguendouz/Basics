using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConctrutor_VS_StaticClass
{
    class Settings
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

        //this is a private constructor to prevent creating object from this class
        private Settings()
        {

        }
    }

    //static class Settings
    //{
    //    public static int DayNumber
    //    {
    //        get
    //        {
    //            return DateTime.Today.Day;
    //        }
    //    }

    //    public static string DayName
    //    {
    //        get
    //        {
    //            return DateTime.Today.DayOfWeek.ToString();
    //        }
    //    }

    //    public static string ProjectPath
    //    {
    //        get;
    //        set;
    //    }

    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            // You cannot create an object here because class has private constructor
            //Settings Obj1 = new Settings();

            //
            // Read the static properties.
            //
            Console.WriteLine(Settings.DayNumber);
            Console.WriteLine(Settings.DayName);

            //
            // Change the value of the static bool property.
            //
            Settings.ProjectPath = @"C:\MyProjects\";
            Console.WriteLine(Settings.ProjectPath);
            Console.ReadKey();
        }
    }
}
