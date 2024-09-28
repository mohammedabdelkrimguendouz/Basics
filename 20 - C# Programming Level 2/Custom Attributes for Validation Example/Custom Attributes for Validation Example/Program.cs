using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attributes_for_Validation_Example
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class RangeAttribute : Attribute
    {
        public int Min { get; }
        public int Max { get; }
        public string ErrorMessage { get; set; }

        public RangeAttribute(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }

    public class Person
    {
        [Range(18,40,ErrorMessage ="Age must be between 18 and 40.")]
        public int Age { get; set; }

        [Range(20, 30, ErrorMessage = "Exprience must be between 20 and 30.")]
        public int Exprience { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        public static bool ValidatePerson(Person person)
        {
            Type type = typeof(Person);
            foreach(var Proprity in type.GetProperties())
            {
                if(Attribute.IsDefined(Proprity, typeof(RangeAttribute)))
                {
                    var rangeAttribute=(RangeAttribute)Attribute.GetCustomAttribute(Proprity,typeof(RangeAttribute));
                    int Value = (int)Proprity.GetValue(person);
                    if(Value<rangeAttribute.Min || Value>rangeAttribute.Max)
                    {
                        Console.WriteLine($"validition faild for proprity {Proprity.Name} : {rangeAttribute.ErrorMessage}");
                        return false;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {

            Person person = new Person { Age = 30, Name = "karim" ,Exprience=15};
            if(ValidatePerson(person))
            {
                Console.WriteLine("Person is valide");
            }
            else
            {
                Console.WriteLine("Person is not valide");
            }
            Console.ReadKey();
        }
    }
}
