using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_with_Custom_Attributes
{
    [AttributeUsage(AttributeTargets.Class| AttributeTargets.Method ,AllowMultiple =true)]
    public class MyCustomAttribute:Attribute
    {
        public string Description {  get; }
        public MyCustomAttribute(string description)
        {
            Description = description;
        }
    }

    [MyCustom("this is class attribute")]
    public class MyClass
    {
        [MyCustom("this is Methode 1 attribute")]
        [MyCustom("this is Methode 1 attribute")]
        public void MyMethode1()
        {

        }

        
        [MyCustom("this is Methode 2 attribute")]
        public void MyMethode2()
        {

        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Type MyClassType= typeof(MyClass);

            object[] ClassAttributes=MyClassType.GetCustomAttributes(typeof(MyCustomAttribute),false);

            foreach(MyCustomAttribute attribute in ClassAttributes)
            {
                Console.WriteLine($"Class Attribute : {attribute.Description}");
            }
            MethodInfo methodInfo = MyClassType.GetMethod("MyMethode1");

            object[] MethodeAttributes = methodInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);
            foreach (MyCustomAttribute attribute in MethodeAttributes)
            {
                Console.WriteLine($"Methode Attribute : {attribute.Description}");
            }

            Console.ReadKey();
        }
    }
}
