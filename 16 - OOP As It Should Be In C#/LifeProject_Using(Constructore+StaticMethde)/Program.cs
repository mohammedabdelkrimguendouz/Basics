using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace LifeProject_Using_Constructore_StaticMethde_
{
    class clsPerson
    {
        public int Age { set; get; }
        public string Name { set; get; }
        public int Id { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }

        public clsPerson(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }
        public static clsPerson Find(int Id)
        {
            if (Id == 10)
                return new clsPerson(10, "karim", 19);
            return null;
        }
        public static clsPerson Find(string UserName,string Password)
        {
            if (UserName == "User1"&&Password=="p1234")
                return new clsPerson(10, "karim", 19);
            return null;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // clsPerson Person1 = new clsPerson(10,"karim",19);
            clsPerson Person1 = clsPerson.Find(10);
            if(Person1!=null)
            {
                Console.WriteLine("Id={0}", Person1.Id);
                Console.WriteLine("Name={0}", Person1.Name);
                Console.WriteLine("Age={0}", Person1.Age);
            }
            else
                Console.WriteLine("Person not found");

            clsPerson Person2 = clsPerson.Find(11);
            if (Person2 != null)
            {
                Console.WriteLine("Id={0}", Person2.Id);
                Console.WriteLine("Name={0}", Person2.Name);
                Console.WriteLine("Age={0}", Person2.Age);
            }
            else
                Console.WriteLine("\nPerson not found\n");

            clsPerson Person3 = clsPerson.Find("User1","p1234");
            if (Person3 != null)
            {
                Console.WriteLine("Id={0}", Person3.Id);
                Console.WriteLine("Name={0}", Person3.Name);
                Console.WriteLine("Age={0}", Person3.Age);
            }
            else
                Console.WriteLine("Person not found");

            Console.ReadKey();
        }
    }
}
