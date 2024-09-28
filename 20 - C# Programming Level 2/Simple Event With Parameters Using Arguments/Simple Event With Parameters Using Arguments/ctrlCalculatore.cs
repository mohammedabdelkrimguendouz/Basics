using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Event_With_Parameters_Using_Arguments
{
    public partial class ctrlCalculatore : UserControl
    {
        //public event Action<float> OnCalculationComplete;

        //protected virtual void CalculationComplete(float Result)
        //{
        //    Action<float> handler = OnCalculationComplete;
        //    if (handler != null)
        //    {
        //        handler(Result);
        //    }
        //}

        public class CalculationCompleteEventArgs:EventArgs
        {
            public int Val1 { get; }
            public int Val2 { get; }
            public int Result {  get; }
            public CalculationCompleteEventArgs(int val1, int val2, int result)
            {
                Val1 = val1;
                Val2 = val2;
                Result = result;
            }
        }

        public event EventHandler<CalculationCompleteEventArgs> OnCalculationComplete;

        public void RaiseOnCalculationComplete(int Result,int Val1,int Val2)
        {
            RaiseOnCalculationComplete(new CalculationCompleteEventArgs(Val1, Val2, Result));
        }

        protected virtual void RaiseOnCalculationComplete(CalculationCompleteEventArgs e)
        {
            OnCalculationComplete?.Invoke(this, e);
        }


        public ctrlCalculatore()
        {
            InitializeComponent();
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            int Val1, Val2;
            Val1 = Convert.ToInt32(txtNumber1.Text);
            Val2 = Convert.ToInt32(txtNumber2.Text);

            int Result = Val1+Val2;

            lblResults.Text = Result.ToString();
            if (OnCalculationComplete != null)
                RaiseOnCalculationComplete(Result, Val1, Val2);
        }
    }
}
