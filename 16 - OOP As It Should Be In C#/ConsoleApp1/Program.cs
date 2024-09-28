using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiding
{
    public class MyBaseClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Base class implementation");
        }


        public virtual void MyOtherMethod()
        {
            Console.WriteLine("Base class implementation of MyOtherMethod");
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public override void MyMethod()
        {
            Console.WriteLine("Derived class implementation using override");
        }


        public new void MyOtherMethod()
        {
            Console.WriteLine("Derived class implementation of MyOtherMethod using new");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBaseClass myBaseObj = new MyBaseClass();
            Console.WriteLine("\nBase Object:\n");
            myBaseObj.MyMethod(); // Output: "Base class implementation"
            myBaseObj.MyOtherMethod(); // Output: "Base class implementation of MyOtherMethod"


            MyDerivedClass myDerivedObj = new MyDerivedClass();
            Console.WriteLine("\nDerived Object:\n");
            myDerivedObj.MyMethod(); // Output: "Derived class implementation using override"
            myDerivedObj.MyOtherMethod(); // Output: "Derived class implementation of MyOtherMethod using new"


            MyBaseClass myDerivedObjAsBase = myDerivedObj;
            Console.WriteLine("\nAfter Castring:\n");
            myDerivedObjAsBase.MyMethod(); // Output: "Derived class implementation using override"
            myDerivedObjAsBase.MyOtherMethod(); // Output: "Base class implementation of MyOtherMethod"

            Console.ReadKey();
        }
    }
}
