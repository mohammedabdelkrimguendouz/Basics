using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converting_a_List_to_an_Array
{
    internal class Program
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
        static void Main(string[] args)
        {


            // List initialization
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // Converting the list to an array
            int[] numbersArray = numbers.ToArray();


            // Displaying the array elements
            Console.WriteLine("Array elements: " + string.Join(", ", numbersArray));


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
            Person[] personArray = People.ToArray();

            for (int i = 0; i < personArray.Length; i++)
            {
                Console.WriteLine($"Name : {personArray[i].Name} , age : {personArray[i].Age}");
            }
           
            

            // Waiting for a key press
            Console.ReadKey();
        }
    }
}
