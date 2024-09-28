using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Access_Medifiers
{
    class clsA
    {
        public int X1=10;
        private int X2=20;
        protected int X3=30;

        public int Fun1()
        {
            return 100;
        }

        private int Fun2()
        {
            return 200;
        }

        protected int Fun3()
        {
            return 300;
        }


    }

    class clsB : clsA
    {
        public int Fun4()
        {
            return X1 + X3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsA A = new clsA();
            Console.WriteLine("x1 = {0}", A.X1);
            Console.WriteLine("Result Fun1 = {0}", A.Fun1());

            clsB B = new clsB();
            Console.WriteLine("x1 = {0}",B.X1 );
            Console.WriteLine("Result Fun1 = {0}",B.Fun1());
            Console.WriteLine("Result Fun4 = {0}", B.Fun4());



            Console.ReadKey();


        }
    }
}
