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
    public partial class frmAddEditProduct : Form
    {
        public enum enMode { AddNew=0,Update=1 };
        private enMode _Mode;
        private int _ProductID;
        private clsProduct _Product;
        public frmAddEditProduct(int ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
            _Mode=(_ProductID==-1)?enMode.AddNew:enMode.Update;
        }

        private void _FillCategoriesInComboBox()
        {
            DataTable CategoriesDataTable = clsCategory.ListCategories();
            foreach(DataRow RowCategory in CategoriesDataTable.Rows)
            {
                cbCategories.Items.Add(RowCategory["CategoryName"]);
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            _FillCategoriesInComboBox();
            if(cbCategories.Items.Count>=0)
                cbCategories.SelectedIndex = 0;

            if (_Mode==enMode.AddNew)
            {
                _Product = new clsProduct();
                return;
            }
            _Product= clsProduct.Find(_ProductID);
            if(_Product==null)
            {
                MessageDialog.Show("\nProduct Wit ID = " + _ProductID + " Not Exist !", "Error");
                return;
            }
            lblMode.Text = "Edit Product ID = " + _ProductID;
            lblProductID.Text = _ProductID.ToString();
            txtName.Text = _Product.Name;
            txtDescription.Text = _Product.Description;
            txtPrice.Text = _Product.Price.ToString();
            nudQuantity.Value = _Product.Quantity;
            if(_Product.ImagePath != "")
            {
                pbImageProduct.ImageLocation = _Product.ImagePath;
                pbImageProduct.Load(pbImageProduct.ImageLocation);
            }
            else
            {
                //pbImageProduct.Image = pbImageProduct.ErrorImage;
            }
            lblRemoveImage.Visible = (_Product.ImagePath != "");
            cbCategories.SelectedIndex = cbCategories.FindString(clsCategory.Find(_Product.CategoryID).CategoryName);
        }

        private void frmAddEditProduct_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private bool _IsInfoValide()
        {
            if (txtName.Text == "" || txtPrice.Text == "")
                return false;
            if (!double.TryParse(txtPrice.Text, out double Result))
                return false;
            return true;
        }
        private bool _Save()
        {
            if(_IsInfoValide())
            {
                _Product.CategoryID = clsCategory.Find(cbCategories.Text).CategoryID;
                _Product.Price =Convert.ToDouble(txtPrice.Text);
                _Product.Name = txtName.Text;
                if (txtDescription.Text == "")
                    _Product.Description = "";
                else
                    _Product.Description = txtDescription.Text;
                if (pbImageProduct.ImageLocation == null)
                    _Product.ImagePath = "";
                else
                    _Product.ImagePath = pbImageProduct.ImageLocation;
                _Product.Quantity =(int) nudQuantity.Value;
                return _Product.Save();
            }
            return false;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_Save())
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                MessageDialog1.Show("\nData Saved Successfully ", "Info");
                lblMode.Text = "Edit Product ID = " + _Product.ProductID;
                lblProductID.Text = _Product.ProductID.ToString();
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
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string ImagePath=openFileDialog1.FileName;
                pbImageProduct.ImageLocation = ImagePath;
                pbImageProduct.Load(pbImageProduct.ImageLocation);
                lblRemoveImage.Visible = true;
            }
        }

        private void lblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pbImageProduct.ImageLocation = null;
            lblRemoveImage.Visible = false;
        }

    }
}
