using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_a_List_of_Custom_Objects
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>
            {
                new Person("karim",34),
                new Person("yacine",27),
                new Person("ali",20),
                new Person("koko",31),
                new Person("ahmed",17),
                new Person("mohammed",40),
                new Person("samir",29),
                new Person("maher",24),
                new Person("amin",50),
            };

            foreach (Person person in People)
            {
                Console.WriteLine($"name : {person.Name} , age : {person.Age}");
            }

            //using find
            Person FindPerson = People.Find(person => person.Name.Length < 5);
            if(FindPerson!=null)
                Console.WriteLine($"\nfind person length name < 5 : , Name : {FindPerson.Name} , age {FindPerson.Age}");

            //using FirstOrDefault(LINQ) same Find
            Person SearchResult = People.FirstOrDefault(person => person.Name=="mohammed");
            if (SearchResult != null)
            {
                SearchResult.Age = 19;
                Console.WriteLine($"\nUpdate {SearchResult.Name} age to  :{SearchResult.Age}");
            }

            List<Person> PeopleOver30=People.FindAll(Person => Person.Age>30);
            PeopleOver30.ForEach(person => Console.WriteLine($"\nName : {person.Name} , age {person.Age} "));

            bool ContainsAlice = People.Any(person => person.Name == "karim");
            Console.WriteLine("\nList contain person name karim : " + ContainsAlice);

            bool ExistOver40 = People.Exists(person => person.Age >40);
            Console.WriteLine("\nexist person Age Over 40  : " + ExistOver40);

            People.RemoveAt(0);
            Console.WriteLine("\nRemove first person ");
            People.ForEach(person => Console.WriteLine($"Name : {person.Name} , age {person.Age} "));


            People.RemoveAll(person => person.Age < 30);
            Console.WriteLine("\nRemove where person age < 30");
            People.ForEach(person => Console.WriteLine($"Name : {person.Name} , age {person.Age} "));



            Console.ReadKey();
        }
    }
}
