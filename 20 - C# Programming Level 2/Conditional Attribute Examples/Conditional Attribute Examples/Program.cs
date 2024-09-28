using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Attribute_Examples
{
    public class MyClass
    {
        [Conditional("DEBUG")]
        public void DebugMethode()
        {
            Console.WriteLine("Debug methode");
        }
        public void NormalMethode()
        {
            Console.WriteLine("Normal methode");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.DebugMethode();
            myClass.NormalMethode();
            Console.ReadKey();
        }
    }
}
