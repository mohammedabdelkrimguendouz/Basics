﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Binary_Serialization_Example
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Person class
            Person person = new Person { Name = "Mohammed Abdelkrim", Age = 46 };
            // Binary serialization
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream stream=new FileStream("Person.bin",FileMode.Create))
            {
                formatter.Serialize(stream, person);
            }
            // Deserialize the object back
            using (FileStream stream = new FileStream("person.bin", FileMode.Open))
            {
                Person deserializedPerson = (Person)formatter.Deserialize(stream);
                Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
               
            }
            Console.ReadKey();
        }
    }
}
