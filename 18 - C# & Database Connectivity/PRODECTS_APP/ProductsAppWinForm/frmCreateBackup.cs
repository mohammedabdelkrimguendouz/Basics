using ProductsBusnisseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsAppWinForm
{
    public partial class frmCreateBackup : Form
    {
        public frmCreateBackup()
        {
            InitializeComponent();
        }

        private void _SeletcPathCreateBackup()
        {
            //saveFileDialog1.DefaultExt = "bak";
            saveFileDialog1.Filter = "Bakup Files(*.bak)|*.bak|All File(*.*)|*.*";
            saveFileDialog1.Title = "Save a Backup File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathCreateBackup.Text = saveFileDialog1.FileName;
            }

        }

        private void _CreateBackup()
        {
            if(clsDataBase.CreateBackup(txtPathCreateBackup.Text))
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                MessageDialog1.Show("\nCreate Backup Susseccfully","Information");
            }else
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog1.Show("\nCreate Backup was not Susseccfully\n\nError Perhaps because there " +
                    "is no validity to place the backup file in the path you set try again to" +
                    " place the track in the desktop", "Error");
            }
        }
        private void btnSeletcPathBackup_Click(object sender, EventArgs e)
        {
            _SeletcPathCreateBackup();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (txtPathCreateBackup.Text == "")
                return;
            _CreateBackup();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
