
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace MyNameSpace
{
   
    public class MyClass
    {
        public int Property1 {  get; set; }
        public string Property2 { get;  }
    

        public void Methode1()
        {
            Console.WriteLine(" Methode 1");
        }
        public void Methode2(int Value1,string Value2)
        {
            Console.WriteLine($" Methode 2 With Parammater {Value1} , {Value2}");
        }
       
    }
    internal class Program
    {
        static string GetParamterList(ParameterInfo[] parameters)
        {
            return string.Join(" , ", parameters.Select(parameter => $"{parameter.ParameterType} {parameter.Name}"));
        }
        static void Main(string[] args)
        {
            Type MyClassType= typeof(MyClass);

            Console.WriteLine("Type Name : "+MyClassType.Name);
            Console.WriteLine("Name Space : " + MyClassType.Namespace);
            Console.WriteLine("FullName Name : " + MyClassType.FullName);

            Console.WriteLine("\nProperties  : ");
            foreach(var Property in MyClassType.GetProperties())
            {
                Console.WriteLine($"\n Name : {Property.Name} , PropertyType :  {Property.PropertyType}," +
                    $" CanRead :  {Property.CanRead} , CanWrite :  {Property.CanWrite} , Attributes : {Property.Attributes}");
            }
            Console.WriteLine("\nMethode  : ");
            foreach (var Methode in MyClassType.GetMethods())
            {
                Console.WriteLine($"\n\t {Methode.ReturnType} {Methode.Name} ( {GetParamterList(Methode.GetParameters())} )");
            }

            object MyClassInstance = Activator.CreateInstance(MyClassType);

            MyClassType.GetProperty("Property1").SetValue(MyClassInstance, 42);

            int Property1Value = (int)MyClassType.GetProperty("Property1").GetValue(MyClassInstance);
            Console.WriteLine(" Property 1 value = " + Property1Value);

            MyClassType.GetMethod("Methode1").Invoke(MyClassInstance, null);

            object[] Parametrs = { 100, "Karim Guendouz" };
            MyClassType.GetMethod("Methode2").Invoke(MyClassInstance, Parametrs);
            Console.ReadKey();
        }
    }
}
