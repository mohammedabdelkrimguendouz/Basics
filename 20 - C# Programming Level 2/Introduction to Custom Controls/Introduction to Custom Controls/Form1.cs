using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction_to_Custom_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                MessageBox.Show(myCustomTextBox1.IsValide().ToString());
            else
                MessageBox.Show(myCustomTextBox1.IsValide().ToString());
        }

        private void myCustomTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!myCustomTextBox1.IsValide())
            {
                e.Cancel = true;
                myCustomTextBox1.Focus();
                errorProvider1.SetError(myCustomTextBox1, "Not Valide");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(myCustomTextBox1, null);
            }
        }
    }
}
