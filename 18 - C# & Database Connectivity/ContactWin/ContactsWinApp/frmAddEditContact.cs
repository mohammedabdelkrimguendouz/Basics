using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsWinApp
{
    public partial class frmAddEditContact : Form
    {
        public enum enMode { AddNew=0, Update=1 }
        private enMode _Mode;
         int _ContactID ;
         clsContact _Contact;
        public frmAddEditContact(int ContactID)
        {
            InitializeComponent();
            _ContactID=ContactID;
            _Mode=(_ContactID==-1)?enMode.AddNew:enMode.Update;
        }
        private void _FillCountriesInCompoBox()
        {
            DataTable TableCountries = clsCountry.GetAllCountries();
            foreach (DataRow Row in TableCountries.Rows)
            {
                cbCountry.Items.Add(Row["CountryName"]);
            }

        }

        private void _LoadData()
        {
            _FillCountriesInCompoBox();
            cbCountry.SelectedIndex = 0;
            if(_Mode==enMode.AddNew)
            {
                lblMode.Text = "Add New Contact";
                _Contact = new clsContact();
                return;
            }
            _Contact = clsContact.Find(_ContactID);
            if(_Contact == null )
            {
                MessageBox.Show("this form well be closed because No Contact With ID : "+_ContactID, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
                return;
            }
            
            lblMode.Text = "Edit Contact ID = " + _ContactID;
            lblContactID.Text = _ContactID.ToString();
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtEmail.Text = _Contact.Email;
            txtPhone.Text = _Contact.Phone;
            rtxtAddress.Text = _Contact.Address;
            dtpDateOfBirth.Value =_Contact.DateOfBirth;
            if(_Contact.ImagePath!="")
            {
                pbxImage.Load(_Contact.ImagePath);
            }
                
            linklblRemoveImage.Visible = (_Contact.ImagePath != "");
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Contact.CountryID).CountryName);
        }

        private void frmAddEditContact_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _Save()
        {
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int CountryID = clsCountry.FindByName(cbCountry.Text).ID;
            _Contact.CountryID = CountryID;
            _Contact.Phone = txtPhone.Text;
            _Contact.Email = txtEmail.Text;
            _Contact.Address = rtxtAddress.Text;
            _Contact.DateOfBirth = dtpDateOfBirth.Value;
            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            if (pbxImage.Location != null)
                _Contact.ImagePath = pbxImage.ImageLocation;
            else
                _Contact.ImagePath = "";
            if (_Contact.Save())
            {
                MessageBox.Show("Data Saved Successfully ", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMode.Text = "Edit Contact ID = " + _Contact.ID;
                lblContactID.Text = _Contact.ID.ToString();
            }
            else
            {
                MessageBox.Show("Data is not Saved Successfully ", "Erorr",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void linklblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pbxImage.Load(selectedFilePath);
                linklblRemoveImage.Visible=true;
            }
        }

        private void linklblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbxImage.ImageLocation = null;
            linklblRemoveImage.Visible = false;
        }
    }
}
