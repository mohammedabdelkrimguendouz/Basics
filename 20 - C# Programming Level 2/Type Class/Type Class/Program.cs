using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(string);


            Console.WriteLine("Type Information:");
            Console.WriteLine($"Name: {myType.Name}");
            Console.WriteLine($"Full Name: {myType.FullName}");
            Console.WriteLine($"Is Class: {myType.IsClass}");
            Console.WriteLine($"Name space: {myType.Namespace}");
            Console.WriteLine($"Reflected Type: {myType.ReflectedType}");
            Console.WriteLine($"Attributes: {myType.Attributes}");
            Console.WriteLine($"Base Type: {myType.BaseType}");
            Console.WriteLine($"Is Enum: {myType.IsEnum}");
            Console.WriteLine($"Is Array: {myType.IsArray}");
            Console.WriteLine($"GUID: {myType.GUID}");
            Console.WriteLine($"Is Interface: {myType.IsInterface}");
            Console.ReadKey();
        }
    }
}
