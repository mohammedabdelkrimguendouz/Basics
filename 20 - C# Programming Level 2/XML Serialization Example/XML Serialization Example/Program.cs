using System;
using System.IO;
using System.Xml.Serialization;

namespace XML_Serialization_Example
{
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Defintion()
        {
            return Name + " " + Age;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Person1 = new Person { Name = "koko", Age = 20 };

            // XML serialization
            XmlSerializer Serializer = new XmlSerializer(typeof(Person));
            using (TextWriter Writer=new StreamWriter("Person.xml"))
            {
                Serializer.Serialize(Writer, Person1);
            }

            // Deserialize the object back
            using (TextReader Reader = new StreamReader("Person.xml"))
            {
                Person deserializedPerson = (Person)Serializer.Deserialize(Reader);
                Console.WriteLine($"Name : {deserializedPerson.Name} , Age : {deserializedPerson.Age}");
            }
            Console.ReadKey();
        }
    }
}
