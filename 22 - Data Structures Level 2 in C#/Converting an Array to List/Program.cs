using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_an_Array_to_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array initialization
            int[] numbersArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            
            // Converting the array to a list
            //Methode 1
           // List<int> numbersList = new List<int>(numbersArray);

            //Mothode2
            List<int> numbersList=numbersArray.ToList();


            // Displaying the list elements
            Console.WriteLine("List elements: " + string.Join(", ", numbersList));


            // Waiting for a key press
            Console.ReadKey();
        }
    }
}
