using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------Exemple 1------------------\n");

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);


            Console.WriteLine("Elements in ArrayList:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            list.Remove(20); // Removing an element
            Console.WriteLine("After removing an element:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------Exemple 2------------------\n");
            ArrayList list2 = new ArrayList(); // Creating an ArrayList
            list2.Add(10); // Adding elements
            list2.Add("Hello");
            list2.Add(true);
            list2.Add(55.78);


            Console.WriteLine("Total elements in ArrayList2: " + list2.Count);


            Console.WriteLine("Content of ArrayList2 using index:");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine("Index " + i + " : " + list2[i]);
            }

            Console.ReadKey();
        }
    }
}
