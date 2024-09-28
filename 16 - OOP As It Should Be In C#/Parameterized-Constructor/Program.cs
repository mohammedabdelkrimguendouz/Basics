using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterized_Constructor
{
    class clsPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public clsPerson(int Id,string Name,short Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsPerson Person1 = new clsPerson(1,"karim",18);
            Console.WriteLine("Id = {0} ",Person1.Id);
            Console.WriteLine("Name = {0} ", Person1.Name);
            Console.WriteLine("Age = {0} ", Person1.Age);
            Console.ReadLine();
        }
    }
}
