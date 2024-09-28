using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_Overriding
{
    public class clsA
    {
        public virtual void Print()
        {
            Console.WriteLine("Hi I\'m the print method from the base class A");
        }
    }

    public class clsB:clsA
    {
        public override void Print()
        {
            Console.WriteLine("Hi I\'m the print method from the sub class B");
            base.Print();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsB ObjB=new clsB();
            ObjB.Print();
            Console.ReadKey();
        }
    }
}
