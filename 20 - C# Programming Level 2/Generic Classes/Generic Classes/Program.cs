using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Classes
{
    public class GenericBox<T>
    {
        private T content;


        public GenericBox(T value)
        {
            content = value;
        }


        public T GetContent()
        {
            return content;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usage:
            GenericBox<int> intBox = new GenericBox<int>(42);
            Console.WriteLine("Content of intBox: " + intBox.GetContent()); // Outputs: 42


            GenericBox<string> stringBox = new GenericBox<string>("Hello, World!");
            Console.WriteLine("Content of stringBox: " + stringBox.GetContent()); // Outputs: Hello, World!
            Console.ReadKey();
        }
    }
}
