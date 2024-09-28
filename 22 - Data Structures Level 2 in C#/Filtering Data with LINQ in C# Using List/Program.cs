using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_Data_with_LINQ_in_C__Using_List
{
    internal class Program
    {
        static bool IsNumberPrime(int Number)
        {
            if(Number == 1) return false;

            for (int i = 2; i <= Number / 2; i++)
            {
                if (Number % i == 0)
                    return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            // List initialization
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // LINQ Filtering
            Console.WriteLine("Even Numbers: " + string.Join(", ", numbers.Where(n => n % 2 == 0)));
            Console.WriteLine("Odd Numbers: " + string.Join(", ", numbers.Where(n => n % 2 != 0)));
            Console.WriteLine("Numbers Greater Than 5: " + string.Join(", ", numbers.Where(n => n > 5)));
            Console.WriteLine("Every Second Number: " + string.Join(", ", numbers.Where((n, index) => index % 2 == 1)));
            Console.WriteLine("Numbers Between 3 and 8: " + string.Join(", ", numbers.Where(n => n > 3 && n < 8)));
            Console.WriteLine("Numbers Prime: " + string.Join(", ", numbers.Where(n => IsNumberPrime(n))));

            // Waiting for a key press
            Console.ReadKey();
        }
    }
}
