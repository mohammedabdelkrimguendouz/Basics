using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_and_Adding_Items_to_ObservableCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an ObservableCollection of strings
            ObservableCollection<string> names = new ObservableCollection<string>();

            // Adding items to the collection
            names.Add("Alice");
            names.Add("Bob");
            names.Add("James");
            names.Add("Jack");

            Console.WriteLine("\nUsing for\n");
            // Displaying items
            for (int i=0;i<names.Count;i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("\nUsing foreach\n");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
