using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstEWinFormsProject
{
    public partial class frmchkRadioGroup : Form
    {
        public frmchkRadioGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chkSendEmail.Checked.ToString());
            MessageBox.Show(chkSendEmail.Tag.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = chkSendEmail.Checked;
            chkSendEmail.Tag = 30122004;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rdSmall.Checked.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = false;
        }
    }
}
