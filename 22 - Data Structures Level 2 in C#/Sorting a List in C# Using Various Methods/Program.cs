using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_a_List_in_C__Using_Various_Methods
{

    public class Test
    {
        public int intValue { set; get; }
        public string strValue { set; get; }

        public Test(int intValue, string strValue)
        { 
            this.intValue = intValue;
            this.strValue = strValue;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {



            // List initialization
            List<int> numbers = new List<int> { 44, 22, 55, 666, 9, -6, 345, 11, 3, 3 };


            // Default Sorting (Ascending)
            numbers.Sort();
            Console.WriteLine("Sorted in Ascending Order: " + string.Join(", ", numbers));


            // Sorting in Descending Order
            numbers.Reverse();
            Console.WriteLine("Sorted in Descending Order: " + string.Join(", ", numbers));


            // Sorting with LINQ
            Console.WriteLine("Sorted Ascending with LINQ: " + string.Join(", ", numbers.OrderBy(n => n)));
            Console.WriteLine("Sorted Descending with LINQ: " + string.Join(", ", numbers.OrderByDescending(n => n)));

            //List<Test> Tests = new List<Test> { new Test(1, "karim"), new Test(9, "ali"), new Test(5, "sami"), new Test(0, "zaki") };

            //Tests.Sort((x, y) => x.intValue.CompareTo(y.intValue));
            //Console.WriteLine("Sorted in Ascending Order: " + string.Join(", ", Tests));

            //Console.WriteLine("Sorted Ascending with LINQ: " + string.Join(", ", Tests.OrderBy(Test => Test.intValue)));
            //Console.WriteLine("Sorted Descending with LINQ: " + string.Join(", ", Tests.OrderByDescending(Test => Test.strValue)));

            //// Waiting for a key press
            Console.ReadKey();
        }
    }
}
