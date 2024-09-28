using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_IComparable_in_Custom_Classes
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string Name, int Age) 
        { 
            this.Name=Name;
            this.Age=Age;
        }

        public int CompareTo(Person other)
        {
            if (other == null) return 1;

            return Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"{Name} , {Age} Years old";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a list of Person instances
            List<Person> people = new List<Person>
        {
            new Person("John", 30),
            new Person("Jane", 25),
            new Person("Doe", 28),
        };


            // Sorting the list using IComparable implementation
            people.Sort();


            // Printing the sorted list
            Console.WriteLine("People sorted by age:");
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadKey();
        }
    }
}
