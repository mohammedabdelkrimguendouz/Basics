using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obsolete_Attribute
{
    public class MyClass
    {
       // [Obsolete(" this Methode is marked as absolete , and will be deprecated in the future.")]
        [Obsolete("Koko")]

        public void Methode1()
        {
            Console.WriteLine("Methode marked absolete");
        }

        
        public void Methode2()
        {
            Console.WriteLine("Methode recommand");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass=new MyClass();
            myClass.Methode1();
            myClass.Methode2();
            Console.ReadKey();
        }
    }
}
