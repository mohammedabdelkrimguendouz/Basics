using BankSystemBusinessLayer;
using BankSystemWinApp.Properties;
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
    public partial class frmAddEditClient : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;
        int _ClientID;
        clsBankClient _Client;
        public frmAddEditClient( int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
            _Mode=(_ClientID==-1)?enMode.AddNew:enMode.Update;
        }

        private void _FillCountriesInComboBox()
        {
            DataTable TableCounries = clsCountry.GetAllCountries();
            foreach(DataRow RowCountry in TableCounries.Rows)
            {
                cbCountries.Items.Add(RowCountry["CountryName"]);
            }
        }
        private void _LoadData()
        {
            _FillCountriesInComboBox();
            cbCountries.SelectedIndex = 0;
            if(_Mode==enMode.AddNew)
            {
                _Client = new clsBankClient();
                lblModeClient.Text = "Add New Client ";
                return;
            }
            _Client = clsBankClient.Find(_ClientID);
            if(_Client==null)
            {
                MessageBox.Show("this form well be closed because No Client With ID : " + _ClientID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                
            }
            txtAccountBalance.Text = _Client.AccountBalance.ToString();
            txtAccountNumber.Text = _Client.AccountNumber;
            txtPinCode.Text = _Client.PinCode;
            lblModeClient.Text = "Edit Client ID = " + _ClientID;
            txtFirstName.Text = _Client.FirstName;
            txtLastName.Text = _Client.LastName;
            txtEmail.Text = _Client.Email;
            txtPhone.Text = _Client.Phone;
            txtAddress.Text = _Client.Address;
            dtpDateOfBirth.Value = _Client.DateOfBirth;
            pbImageClient.ImageLocation = _Client.ImagePath;
            pbImageClient.Load(pbImageClient.ImageLocation);
            lblRemoveImage.Visible = true;
            txtAccountNumber.Visible = false;
            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(_Client.CountryID).CountryName);
        }

        private bool _IsClientInfoValide()
        {
            if(txtAccountBalance.Text==""||txtAccountNumber.Text==""||txtAddress.Text==""||txtEmail.Text==""||
                txtFirstName.Text==""||txtLastName.Text==""||txtPhone.Text==""||txtPinCode.Text==""||pbImageClient.Location.ToString()==string.Empty)
            {
                MessageBox.Show("Data is not Complet ", "Erorr",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_Mode == enMode.AddNew)
            {

                if (clsBankClient.IsClientExist(txtAccountNumber.Text))
                {
                    MessageBox.Show("Account Number Alerdy Exist Pleas Write anthore one  ", "Erorr",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void frmAddEditClient_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnCancleClient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _Save()
        {
            if (_IsClientInfoValide())
            {
                int CountryID = clsCountry.FindByName(cbCountries.Text).ID;
                _Client.AccountBalance =Convert.ToDouble(txtAccountBalance.Text);
                _Client.CountryID = CountryID;
                _Client.Phone = txtPhone.Text;
                _Client.Email = txtEmail.Text;
                _Client.Address = txtAddress.Text;
                _Client.DateOfBirth = dtpDateOfBirth.Value;
                _Client.FirstName = txtFirstName.Text;
                _Client.LastName = txtLastName.Text;
                _Client.AccountNumber = txtAccountNumber.Text;
                _Client.PinCode = txtPinCode.Text;
                _Client.ImagePath = pbImageClient.ImageLocation;
                
               
                if (_Client.Save())
                {
                    MessageBox.Show("Data Saved Successfully ", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblModeClient.Text = "Edit Client ID = " + _Client.ID;
                    txtAccountNumber.Visible = false;
                }
                else
                {
                    MessageBox.Show("Data is not Saved Successfully ", "Erorr",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void lblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImageClient.ImageLocation = null;
            lblRemoveImage.Visible = false;
        }

        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbImageClient.ImageLocation = selectedFilePath;
                pbImageClient.Load(pbImageClient.ImageLocation);
                lblRemoveImage.Visible = true;
            }
        }
    }
}
