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
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            _EnableItemForUserActive();
        }
        private void _EnableItemForUserActive()
        {
            if (clsGlobal.UserActive.Permissions == (int)clsUser.enParmissions.pAll)
                return;
            if(!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pCreateBackup))
                this.createABackupToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pRestoreBackup))
                this.restoreABackupToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pAddNewProduct))
                this.addNewProductToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pProductManagement))
                this.productManagementToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pAddNewCategory))
                this.addNewCategoryToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pCategoriesManagement))
                this.categoriesManagementToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pAddNewCustomer))
                this.addNewCustomerToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pCustomerManagement))
                this.customerManagementToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pAddNewSale))
                this.addNewSaleToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pSalesManagement))
                this.salesManagementToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pAddNewUser))
                this.addNewUserToolStripMenuItem.Enabled = false;

            if (!clsGlobal.UserActive.CheckAccessPermission(clsUser.enParmissions.pUsersManagement))
                this.usersManagementToolStripMenuItem.Enabled = false;



        }

       

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditProduct Form1 = new frmAddEditProduct(-1);
            Form1.ShowDialog();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsManagement Form1 = new frmProductsManagement();
            Form1.ShowDialog();
        }

       
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createABackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreateBackup Form1 = new frmCreateBackup();
            Form1.ShowDialog();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCategory Form1 = new frmAddEditCategory(-1);
            Form1.ShowDialog();
        }

        private void categoriesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatogiersManagement Form1 = new frmCatogiersManagement();
            Form1.ShowDialog();
        }

        private void restoreABackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestoreBackup Form1 = new frmRestoreBackup();
            Form1.ShowDialog();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser Form1 = new frmAddEditUser(-1);
            Form1.ShowDialog();
        }

        private void usersManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersManagement Form1 = new frmUsersManagement();
            Form1.ShowDialog();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditeCustomer Form1 = new frmAddEditeCustomer(-1);
            Form1.ShowDialog();
        }

        private void customerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersManagement Form1 = new frmCustomersManagement();
            Form1.ShowDialog();
        }

        private void addNewSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewOrder Form1 = new frmAddNewOrder();
            Form1.ShowDialog();
        }
    }
}
