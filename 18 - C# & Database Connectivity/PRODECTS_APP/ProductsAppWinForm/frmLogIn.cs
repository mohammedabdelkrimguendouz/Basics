using ProductsAppWinForm.Properties;
using ProductsBusnisseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsAppWinForm
{
    public partial class frmLogIn : Form
    {
       
        public frmLogIn()
        {
            InitializeComponent();
        }

        public enum enModePassword { Hide=0,Show=1};
        private enModePassword _ModePassword;
        private void _InitializeForm()
        {
            txtPasswordLogIn.Text = string.Empty;
            txtUserNameLogIn.Text = string.Empty;
            _ModePassword = enModePassword.Hide;
            btnShowHidePassword.Image = Resources.hidden;
            txtPasswordLogIn.PasswordChar = '*';
        }
        private void btnCancleLogIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _LogIn()
        {
            if(clsUser.IsUserExist(txtUserNameLogIn.Text,txtPasswordLogIn.Text)) 
            {
                clsGlobal.UserActive = clsUser.Find(txtUserNameLogIn.Text);
                clsGlobal.UserActive.SaveLogIn();
                this.Hide();
                frmMain Form1 = new frmMain();
                Form1.ShowDialog();
                _InitializeForm();
                this.Visible = true;
            }
            else
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog1.Show("\nUser Name Or Password Incorrect !","Error");
            }
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            _LogIn();
        }

        private void _Show()
        {
            _ModePassword = enModePassword.Show;
            btnShowHidePassword.Image = Resources.show;
            txtPasswordLogIn.PasswordChar = '\0';
        }

        private void _Hidden()
        {
            _ModePassword = enModePassword.Hide;
            btnShowHidePassword.Image = Resources.hidden;
            txtPasswordLogIn.PasswordChar = '*';
        }
        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (_ModePassword == enModePassword.Hide)
                _Show();
            else
                _Hidden();
        }
    }
}
