using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate_With_Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action ParrameterLessAction = () =>
            {
                Console.WriteLine(" this is Parrameter Less Action");
            };
            Action<int> ActionWithIntParrameter = (X)=>
            {
                Console.WriteLine(" this is Action With Int Parrameter : " + X);
            };
            Action<string, int> ActionWithMultibleParrameters = (str, num) =>
            {
                Console.WriteLine(" this is Action With Multible Parrameters : " + num + " and : " + str);
            };

            ParrameterLessAction();
            ActionWithIntParrameter(10);
            ActionWithMultibleParrameters("Karim", 50);
            Console.ReadKey();
        }
    }
}
