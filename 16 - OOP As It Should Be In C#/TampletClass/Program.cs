using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TampletClass
{
    public class Test<T>
    {
        public T Value { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test<int> Test1 = new Test<int> ();
            Test1.Value = 1;
            Console.WriteLine(Test1.Value);

            Test<double> Test2 = new Test<double>();
            Test2.Value = 5.879;
            Console.WriteLine(Test2.Value);

            Test<string> Test3 = new Test<string>();
            Test3.Value = "karim";
            Console.WriteLine(Test3.Value);

            Test<char> Test4 = new Test<char>();
            Test4.Value = 'A';
            Console.WriteLine(Test4.Value);
            Console.ReadKey();

        }
    }
}
