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
    public partial class frmAddEditCategory : Form
    {
        public enum enMode { AddNew=0,Update=1};
        private enMode _Mode;
        private int _CategoryID;
        private clsCategory _Category;
        public frmAddEditCategory(int CategoryID)
        {
            InitializeComponent();
            _CategoryID = CategoryID;
            _Mode=(_CategoryID==-1)?enMode.AddNew:enMode.Update;
        }

        

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadData()
        {
            if(_Mode==enMode.AddNew)
            {
                lblMode.Text = "Add New Category ";
                _Category = new clsCategory();
                return;
            }
            _Category = clsCategory.Find(_CategoryID);
            if(_Category==null)
            {
                MessageDialog1.Show("\nCategory not exist  with ID = " + _CategoryID,"Error");
                return;
            }
            lblMode.Text = "Edit Category ID = " + _CategoryID;
            lblCatogeryID.Text = _Category.CategoryID.ToString();
            txtCategoryName.Text = _Category.CategoryName;
            
        }
        private void frmAddEditCategory_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _Save()
        {
            if(!clsCategory.IsCatogeryExist(txtCategoryName.Text))
            {
                _Category.CategoryName = txtCategoryName.Text;
                if(_Category.Save())
                {
                    MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog1.Show("\nCategory  Add  Successfully ", "Info");
                    this.Close();
                }
                   
                else
                {
                    MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    MessageDialog1.Show("\nCategory  Was not Add  Successfully ", "Error");
                }   
            }
            else
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog1.Show("\nCategory  exist  Cannot be added ", "Error");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
    }
}
