using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate_Example
{
    internal class Program
    {
        static void ParrameterLessMethode()
        {
            Console.WriteLine(" this is Parrameter Less Action");
        }
        static void ActionWithIntParrameterMethode(int X)
        {
            Console.WriteLine(" this is Action With Int Parrameter : "+X);
        }
        static void ActionWithMultibleParrametersMethode(string Message, int X)
        {
            Console.WriteLine(" this is Action With Multible Parrameters : " + X + " and : "+Message);
        }

        static void Main(string[] args)
        {
            Action ParrameterLessAction = ParrameterLessMethode;
            Action<int> ActionWithIntParrameter = ActionWithIntParrameterMethode;
            Action<string, int> ActionWithMultibleParrameters = ActionWithMultibleParrametersMethode;

            ParrameterLessAction();
            ActionWithIntParrameter(10);
            ActionWithMultibleParrameters("Karim", 50);
            Console.ReadKey();
        }

    }
}
