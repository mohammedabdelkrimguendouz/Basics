using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_HashSet_to_Remove_Duplicates_from_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = { 1, 2, 3, 4, 1, 4, 5, 5, 10, -1, 3 };

            // Methode 1
            //HashSet<int> hashsetNumbers= arrNumbers.ToHashSet();

            // Methode 2
            HashSet<int> UniqueNumbers = new HashSet<int>(arrNumbers);

            //arrNumbers = UniqueNumbers.ToArray();

            foreach(int Number in UniqueNumbers)
            {
                Console.WriteLine(Number);
            }
            Console.ReadKey();
        }
    }
}
