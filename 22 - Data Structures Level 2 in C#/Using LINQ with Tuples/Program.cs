using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_LINQ_with_Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of tuples representing ID, Name, and Age
            List<(int Id, string Name, int Age)> people = new List<(int, string, int)>
        {
            (1, "Alice", 30),
            (2, "Bob", 25),
            (3, "Charlie", 35),
            (4, "Diana", 28)
        };
            Console.WriteLine("All People : ");
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            // Filter people with age above 30
            var filteredPeople = people.Where(p => p.Age > 30);

            Console.WriteLine("filter people age > 30 : ");
            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }


            // Find average age
            double averageAge = people.Average(p => p.Age);
            Console.WriteLine("Average Age: " + averageAge);

            double SumAge = people.Sum(p => p.Age);
            Console.WriteLine("Sum Age: " + SumAge);

            double MaxAge = people.Max(p => p.Age);
            Console.WriteLine("Max Age: " + MaxAge);

            double MinAge = people.Min(p => p.Age);
            Console.WriteLine("Min Age: " + MinAge);

            Console.WriteLine("Count : " + people.Count);

            var SortedPeopleByAgeAsc= people.OrderBy(p=>p.Age);

            Console.WriteLine("people sorted by age  Asc: ");
            foreach (var person in SortedPeopleByAgeAsc)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
            Console.ReadKey();
        }
    }
}
