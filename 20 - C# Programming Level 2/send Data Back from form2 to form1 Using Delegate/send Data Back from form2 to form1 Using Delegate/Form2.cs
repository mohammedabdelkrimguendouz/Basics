using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace send_Data_Back_from_form2_to_form1_Using_Delegate
{
    public partial class Form2 : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);

        public event DataBackEventHandler DataBack;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSendDataBackToForm1_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, int.Parse(txtPersonID.Text));
            this.Close();
        }
    }
}
