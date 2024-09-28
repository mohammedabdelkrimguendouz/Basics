using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddEvent_In_User_Control
{
    public partial class ctrlCalculatore : UserControl
    {
        public ctrlCalculatore()
        {
            InitializeComponent();
        }

        public event Action<float> OnCalculationComplete;

        protected virtual void CalculationComplete(float Result)
        {
            Action<float> handler= OnCalculationComplete;
            if(handler != null )
            {
                handler(Result);
            }
        }
        private void btnCalculation_Click(object sender, EventArgs e)
        {
            float Result = float.Parse(txtNumber1.Text) + float.Parse(txtNumber2.Text);
            lblResults.Text=Result.ToString();
            if(OnCalculationComplete!= null )
                CalculationComplete(Result);
        }
    }
}
