using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_SimpleProject
{
    public partial class ctrlSimpleCalc : UserControl
    {
        public ctrlSimpleCalc()
        {
            InitializeComponent();
        }

        public float Result
        {
            get { return float.Parse(lblResulte.Text); } 
           // set { lblResulte.Text = value.ToString(); }
        }
       


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResulte.Text = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text)).ToString();
        }
    }
}
