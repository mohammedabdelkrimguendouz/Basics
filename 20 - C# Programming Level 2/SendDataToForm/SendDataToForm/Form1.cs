using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataToForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendDataToForm2_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtPersonID.Text,out int PersonID))
            {
                Form2 frm = new Form2(PersonID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Person ID Shoulde be a Number !");
                txtPersonID.Focus();
            }
            
        }
    }
}
