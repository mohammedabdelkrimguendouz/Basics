using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateProjectc_
{

    class clsCalculatore
    {
        private float _LastNumber;
        private float _Result=0;
        private string _LastOperation = " Clear ";
        private float _PreviousResult;

        private bool _IsZero(float Number)
        {
            return (Number == 0);
        }
        public void Add(int Number)
        {
            _LastNumber = Number;
            _PreviousResult = _Result;
            _Result += Number;
            _LastOperation = " Adding ";
        }
        public void Subtract(int Number)
        {
            _LastNumber = Number;
            _PreviousResult = _Result;
            _Result -= Number;
            _LastOperation = " Subtracting ";
        }

        public void Multiply(int Number)
        {
            _LastNumber = Number;
            _PreviousResult = _Result;
            _Result *= Number;
            _LastOperation = " Multiplying ";
        }

        public bool Divide(int Number)
        {
            _LastOperation = " Dividing ";
            _LastNumber = Number;
            bool Succeeded = true;
            if (_IsZero(Number))
            {
                Number = 1;
                Succeeded = false;
            }
                
            _PreviousResult = _Result;
            _Result /= Number;
            return Succeeded;
        }
        public void PrintResult()
        {
            Console.WriteLine("Result After {0} {1} is : {2}", _LastOperation, _LastNumber, _Result);
        }

        public float GetFinalResult()
        {
            return _Result;
        }

        public void Clear()
        {
            _LastNumber = 0;
            _Result = 0;
            _PreviousResult = 0;
            _LastOperation = " Clear ";
        }
        public void CancleLastOperation()
        {
            _Result = _PreviousResult;
            _LastOperation = " Cancelling Last Operation ";
            _LastNumber = 0;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            clsCalculatore Calculatore1 = new clsCalculatore();
            Calculatore1.Add(10);
            Calculatore1.PrintResult();
            Calculatore1.Add(100);
            Calculatore1.PrintResult();
            Calculatore1.Subtract(20);
            Calculatore1.PrintResult();
            Calculatore1.Divide(0);
            Calculatore1.PrintResult();
            
            Calculatore1.Multiply(3);
            Calculatore1.PrintResult();
            Calculatore1.CancleLastOperation();
            Calculatore1.PrintResult();
            Calculatore1.Clear();
            Calculatore1.PrintResult();
            Console.ReadLine();
        }
        
    }
}
