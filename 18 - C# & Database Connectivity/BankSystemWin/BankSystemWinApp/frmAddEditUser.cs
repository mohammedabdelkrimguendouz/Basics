using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemWinApp
{
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        int _UserID;
        clsUser _User;
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode=(UserID==-1)?enMode.AddNew:enMode.Update;
        }
        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New User";
                txtUserNameAddAndEditUser.Visible = true;
                _User = new clsUser();
                return;
            }
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageBox.Show("this form well be closed because No User With ID : " + _UserID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblMode.Text = "Edit User ID = " + _UserID;
            txtUserNameAddAndEditUser.Text = _User.UserName;
            txtUserNameAddAndEditUser.Visible = false;
            txtPasswordAddAndEditUser.Text = _User.Password;
            txtCofirmPasswordAddAndEditUser.Text = _User.Password;
        }

        private void btnCancleAddAndEditUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private bool _IsInfoUserValide()
        {
            
            if(txtUserNameAddAndEditUser.Text=="" ||txtPasswordAddAndEditUser.Text==""||txtCofirmPasswordAddAndEditUser.Text=="")
            {
                MessageBox.Show("Data is not Complet ", "Erorr",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(_Mode==enMode.AddNew)
            {
                
                if (clsUser.IsUserExist(txtUserNameAddAndEditUser.Text))
                {
                    MessageBox.Show("User Name Alerdy Exist Pleas Write anthore one  ", "Erorr",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
            if(txtPasswordAddAndEditUser.Text != txtCofirmPasswordAddAndEditUser.Text)
            {
                MessageBox.Show("Confirm Password is not same of Password ", "Erorr",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

             return true;
        }

        private void _Save()
        {

            if(_IsInfoUserValide())
            {
                _User.UserName=txtUserNameAddAndEditUser.Text;
                _User.Password = txtPasswordAddAndEditUser.Text;
                if (_User.Save())
                {
                    MessageBox.Show("Data Saved Successfully ", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblMode.Text = "Edit User ID = " + _User.ID;
                }
                else
                {
                    MessageBox.Show("Data is not Saved Successfully ", "Erorr",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void btnSaveAddAndEditUser_Click(object sender, EventArgs e)
        {
            _Save();
        }
    }
}
