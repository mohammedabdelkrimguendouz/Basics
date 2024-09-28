using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemWinApp
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LogIn()
        {
            if (clsUser.IsUserExist(txtUserName.Text, txtPassword.Text))
            {
                clsGlobal.UserActive = clsUser.Find(txtUserName.Text, txtPassword.Text);
                clsGlobal.UserActive.LogIn();
                this.Hide();
                frmSystem Form = new frmSystem();
                Form.ShowDialog();
                this.Visible= true;
            }
            else
            {
                MessageBox.Show("User Name OR Password Incorect !", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                
               
            }
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            _LogIn(); 
        }
    }
}
