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
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID;
        private clsUser _User;
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode=(_UserID==-1)?enMode.AddNew:enMode.Update;
        }

        private void _SelectPermissionForUser()
        {
            if (_User.Permissions == (int)clsUser.enParmissions.pAll)
            {
                _SelectPermissions(true);
                rbSelectAllPermissions.Checked = true;
                return;
            }
            if (!_User.CheckAccessPermission(clsUser.enParmissions.pCreateBackup))
                tsCreateBackup.Checked = false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pRestoreBackup))
                tsRestoreBackup.Checked = false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pAddNewProduct))
                tsAddNewProduct.Checked= false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pProductManagement))
                tsProductsManagement.Checked= false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pAddNewCategory))
                tsAddNewCategory.Checked= false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pCategoriesManagement))
                tsCatogeriesManagement.Checked = false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pAddNewCustomer))
                tsAddNewCustomer.Checked = false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pCustomerManagement))
                tsCustomerManagement.Checked = false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pAddNewSale))
                tsAddNewSale.Checked = false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pSalesManagement))
                tsSalesManagement.Checked = false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pAddNewUser))
                tsAddNewUser.Checked = false;

            if (!_User.CheckAccessPermission(clsUser.enParmissions.pUsersManagement))
                tsUserManagement.Checked = false;


        }
        private void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New User ";
                rbSelectAllPermissions.Checked = true;
                _User = new clsUser();
                return;
            }
            _User = clsUser.Find(_UserID);
            if (_User == null)
            {
                MessageDialog1.Show("User not exist  with ID = " + _UserID, "Error");
                return;
            }
            _SelectPermissionForUser();
            lblMode.Text = "Edit User ID = " + _UserID;
            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _SelectPermissions(bool CheckedState)
        {
            tsAddNewCategory.Checked = CheckedState;
            tsAddNewProduct.Checked = CheckedState;
            tsUserManagement.Checked = CheckedState;
            tsSalesManagement.Checked = CheckedState;
            tsRestoreBackup.Checked = CheckedState;
            tsCreateBackup.Checked = CheckedState;
            tsCatogeriesManagement.Checked = CheckedState;
            tsAddNewUser.Checked = CheckedState;
            tsAddNewCustomer.Checked = CheckedState;
            tsAddNewSale.Checked = CheckedState;
            tsCustomerManagement.Checked = CheckedState;
            tsProductsManagement.Checked = CheckedState;
        }
      

        private void rbSelectAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            _SelectPermissions(true);
        }

        private void rbCancelSelectAllPermissions_CheckedChanged(object sender, EventArgs e)
        {
            _SelectPermissions(false);
        }

        private int _TotalPermission()
        {
            return (int)clsUser.enParmissions.pCreateBackup + (int)clsUser.enParmissions.pRestoreBackup + (int)clsUser.enParmissions.pAddNewProduct + (int)clsUser.enParmissions.pProductManagement +
                (int)clsUser.enParmissions.pAddNewCategory + (int)clsUser.enParmissions.pCategoriesManagement + (int)clsUser.enParmissions.pAddNewCustomer + (int)clsUser.enParmissions.pCustomerManagement +
                (int)clsUser.enParmissions.pAddNewSale + (int)clsUser.enParmissions.pSalesManagement + (int)clsUser.enParmissions.pAddNewUser + (int)clsUser.enParmissions.pUsersManagement;

        }
        private bool _IsInfoUserValide()
        {
            if(txtUserName.Text==""||txtPassword.Text=="")
                return false;
            if(_Mode==enMode.AddNew&& clsUser.IsUserExist(txtUserName.Text))
            {
                MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                MessageDialog1.Show("\nUser  exist  Cannot be added ", "Error");
                return false;
            }
             
            return true;
        }

        private int _GetTotalPrmissionsForUser()
        {
            int Permissions = 0;
            if (tsAddNewCategory.Checked)
                Permissions +=(int) clsUser.enParmissions.pAddNewCategory;
            if (tsAddNewCustomer.Checked)
                Permissions += (int)clsUser.enParmissions.pAddNewCustomer;
            if (tsAddNewProduct.Checked)
                Permissions += (int)clsUser.enParmissions.pAddNewProduct;
            if (tsAddNewSale.Checked)
                Permissions += (int)clsUser.enParmissions.pAddNewSale;
            if (tsAddNewUser.Checked)
                Permissions += (int)clsUser.enParmissions.pAddNewUser;
            if (tsCatogeriesManagement.Checked)
                Permissions += (int)clsUser.enParmissions.pCategoriesManagement;
            if (tsCreateBackup.Checked)
                Permissions += (int)clsUser.enParmissions.pCreateBackup;
            if (tsCustomerManagement.Checked)
                Permissions += (int)clsUser.enParmissions.pCustomerManagement;
            if (tsProductsManagement.Checked)
                Permissions += (int)clsUser.enParmissions.pProductManagement;
            if (tsRestoreBackup.Checked)
                Permissions += (int)clsUser.enParmissions.pRestoreBackup;
            if (tsSalesManagement.Checked)
                Permissions += (int)clsUser.enParmissions.pSalesManagement;
            if (tsUserManagement.Checked)
                Permissions += (int)clsUser.enParmissions.pUsersManagement;
            if (Permissions == _TotalPermission())
                Permissions = -1;
            return Permissions;
        }

        private void _Save()
        {
            if (_IsInfoUserValide())
            {
                _User.UserName = txtUserName.Text;
                _User.Password = txtPassword.Text;
                _User.Permissions = _GetTotalPrmissionsForUser();
                if (_User.Save())
                {
                    MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog1.Show("\nUser  Add  Successfully ", "Info");
                    lblUserID.Text = _User.UserID.ToString();
                    lblMode.Text = "Edite User ID = " + _User.UserID;
                    txtUserName.Enabled = false;
                    if (_Mode == enMode.AddNew)
                        _Mode = enMode.Update;
                }

                else
                {
                    MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    MessageDialog1.Show("\nUser  Was not Add  Successfully ", "Error");
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }
    }
}
