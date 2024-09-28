using Guna.UI2.WinForms;
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
    public partial class frmRestoreBackup : Form
    {
        public frmRestoreBackup()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _SeletcPathRestoreBackup()
        {
            openFileDialog1.DefaultExt = "bak";
            openFileDialog1.Filter = "Bakup Files(*.bak)|*.bak|All File(*.*)|*.*";
            openFileDialog1.Title = "Open a Backup File";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPathRestoreBackup.Text = openFileDialog1.FileName;
            }

        }
        private void btnSeletcPathRestore_Click(object sender, EventArgs e)
        {
            _SeletcPathRestoreBackup();
        }

        private void _RestoreBackup()
        {
            if (clsDataBase.RestoreBackup(txtPathRestoreBackup.Text))
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                MessageDialog1.Show("\nRestore Backup Susseccfully", "Information");
            }
            else
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog1.Show("\nRestore Backup was not Susseccfully", "Error");
            }
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (txtPathRestoreBackup.Text == "")
                return;
            _RestoreBackup();
        }
    }
}
