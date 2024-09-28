using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Datatypes_Example_2
{
    internal class Program
    {
        static void Procedure1(string Name ,Nullable<int> Age)
        {
            Console.WriteLine("\nName : " + Name);
            if(Age.HasValue)
            {
                Console.WriteLine("Age : " + Age);
            }
            else
                Console.WriteLine("Age not value  ");
        }
        static void Procedure2(string Name, int? Age)
        {
            Console.WriteLine("\nName : " + Name);
            if (Age.HasValue)
            {
                Console.WriteLine("Age : " + Age.ToString()) ;
            }
            else
                Console.WriteLine("Age not value  ");
        }
        static void Main(string[] args)
        {
            Procedure1("karim", null);
            Procedure1("ali",45);

            Procedure2("karim", null);
            Procedure2("ali", 45);

            Console.ReadKey();
        }
    }
}
