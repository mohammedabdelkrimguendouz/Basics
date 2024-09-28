using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_Dictionary
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public int Age { get; set; }
            public string NationalNo { get; set; }

            public Person(string Name, int Id, int Age, string NationalNo)
            { 
                this.Age = Age;
                this.NationalNo = NationalNo;
                this.Id = Id;
                this.Name = Name;
            }
        }
        static void Main(string[] args)
        {
            // Creating the dictionary
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>();


            // Adding elements
            fruitBasket.Add("Apple", 5);
            fruitBasket.Add("Banana", 2);
            //the following commented line will casue an error because they key is repeated.
            //fruitBasket.Add("Banana", 5);
            fruitBasket.Add("Orange", 12);


            // Accessing and updating elements
            fruitBasket["Apple"] = 10;


            Console.WriteLine("\nDictionary Content:");
            // Iterating through the dictionary
            foreach (KeyValuePair<string, int> item in fruitBasket)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }


            // Removing an element
            fruitBasket.Remove("Banana");

            Console.WriteLine("\nDictionary Content after removing Banana:");
            // Iterating through the dictionary after removing Banana
            foreach (KeyValuePair<string, int> item in fruitBasket)
            {
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            }

            Dictionary<string, Person> People = new Dictionary<string, Person>();

            People.Add("n1", new Person("ali", 1, 34, "n1"));
            People.Add("n2", new Person("karim", 2, 24, "n2"));
            People.Add("n3", new Person("samir", 3, 12, "n3"));
            People.Add("n4", new Person("yacine", 4, 30, "n4"));
            People.Add("n5", new Person("mohammed", 5, 44, "n5"));


            Console.WriteLine("Count : " + People.Count);

            Console.WriteLine("\nDictionary Content:");
            // Iterating through the dictionary
            foreach (KeyValuePair<string, Person> item in People)
            {
                Console.WriteLine($" Key --> National No : {item.Key}  Value ---> Name : {item.Value.Name} ,  Id : {item.Value.Id} ,  Age : {item.Value.Age}");
            }


            Console.WriteLine(People.Remove("n3"));

            

            Console.WriteLine("\nDictionary Content after removing National no n3:");
            // Iterating through the dictionary after removing Banana
            foreach (KeyValuePair<string, Person> item in People)
            {
                Console.WriteLine($" Key --> National No : {item.Key}  Value ---> Name : {item.Value.Name} ,  Id : {item.Value.Id} ,  Age : {item.Value.Age}");
            }

            Console.ReadKey();
        }
    }
}
