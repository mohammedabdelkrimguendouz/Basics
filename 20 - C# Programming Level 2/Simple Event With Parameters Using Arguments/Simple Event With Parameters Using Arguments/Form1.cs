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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ctrlCalculatore1_OnCalculationComplete(object sender, ctrlCalculatore.CalculationCompleteEventArgs e)
        {
            
            MessageBox.Show($"Result = {e.Result} , Val1 = {e.Val1} , Val2 = {e.Val2}");
        }
    }
}
