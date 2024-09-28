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
using System.Xml.Linq;

namespace ProductsAppWinForm
{
    public partial class frmAddEditeCustomer : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _CustomerID;
        private clsCustomer _Customer;

        public frmAddEditeCustomer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
            _Mode = (_CustomerID == -1) ? enMode.AddNew : enMode.Update;
        }

        private void _FillCountriesInComboBox()
        {
            DataTable CountriesDataTable = clsCountry.GetAllCountries();
            foreach (DataRow RowCountry in CountriesDataTable.Rows)
            {
                cbCountries.Items.Add(RowCountry["CountryName"]);
            }
        }

        private void _LoadData()
        {
            _FillCountriesInComboBox();
            if (cbCountries.Items.Count >= 0)
                cbCountries.SelectedIndex = 0;
            if (_Mode == enMode.AddNew)
            {
                _Customer = new clsCustomer();
                pbImageCustomer.ImageLocation = null;
                return;
            }
            _Customer = clsCustomer.Find(_CustomerID);
            if (_Customer == null)
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog1.Show("\nCustomer With ID = " + _CustomerID + " Not Exist !", "Error");
                return;
            }
            lblMode.Text = "Edit Customer ID = " + _CustomerID;
            lblCustomerID.Text = _CustomerID.ToString();
            txtFirstName.Text = _Customer.FirstName;
            txtLastName.Text = _Customer.LastName;
            txtPhone.Text = _Customer.Phone;
            txtAddress.Text = _Customer.Address;
            txtEmail.Text = _Customer.Email;
            pbImageCustomer.ImageLocation = _Customer.ImagePath;
            pbImageCustomer.Load(pbImageCustomer.ImageLocation);
            lblRemoveImage.Visible = true;
            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(_Customer.CountryID).CountryName);
        }
        private void frmAddEditeCustomer_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool _IsInfoCustomerValide()
        {
            if (txtAddress.Text == "" || txtEmail.Text == "" || txtFirstName.Text == ""
                || txtLastName.Text == "" || txtPhone.Text == "" || pbImageCustomer.ImageLocation == null)
                return false;
            return true;
        }
        private bool _Save()
        {
            if (_IsInfoCustomerValide())
            {
                _Customer.FirstName = txtFirstName.Text;
                _Customer.LastName = txtLastName.Text;
                _Customer.Email = txtEmail.Text;
                _Customer.Phone = txtPhone.Text;
                _Customer.Address = txtAddress.Text;
                _Customer.CountryID = clsCountry.Find(cbCountries.Text).ID;
                _Customer.ImagePath = pbImageCustomer.ImageLocation;
                return _Customer.Save();
            }
            return false;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_Save())
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                MessageDialog1.Show("\nData Saved Successfully ", "Info");
                lblMode.Text = "Edit Customer ID = " + _Customer.CustomerID;
                lblCustomerID.Text = _Customer.CustomerID.ToString();
            }

            else
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog1.Show("\nData Was not Saved Successfully ", "Error");
            }
        }

        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.AddExtension = true;
            openFileDialog1.Filter = "Images File |*.png;*.jpeg;*.gif;*.bmp;*.tiff;*.webp;*.svg;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ImagePath = openFileDialog1.FileName;
                pbImageCustomer.ImageLocation = ImagePath;
                pbImageCustomer.Load(pbImageCustomer.ImageLocation);
                lblRemoveImage.Visible = true;
            }
        }

        private void lblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImageCustomer.ImageLocation = null;
            lblRemoveImage.Visible = false;
        }
    }
}
