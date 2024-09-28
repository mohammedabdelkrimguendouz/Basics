using DGVPrinterHelper;
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
    public partial class frmProductsManagement : Form
    {
        public frmProductsManagement()
        {
            InitializeComponent();
        }
        private void _RefershListProducts()
        {
            DataTable ProductsDataTable = clsProduct.ListProducts();
            dgvAllListProducts.DataSource = ProductsDataTable;
            gbListProducts.Text = "List Products ( " + ProductsDataTable.Rows.Count+" Product(s) )";
        }

        private void _FillProductNameInComboBox()
        {
            DataTable ProductNameDataTable = clsProduct.ListProducts();
            foreach (DataRow Row in ProductNameDataTable.Rows)
            {
                cbSearchProduct.Items.Add(Row["Name"]);
            }
        }
        private void _FillCategoriesInComboBox()
        {
            DataTable CategoriesDataTable = clsCategory.ListCategories();
            foreach (DataRow RowCategory in CategoriesDataTable.Rows)
            {
                cbSearchProduct.Items.Add(RowCategory["CategoryName"]);
            }
        }
        private void _LoadData()
        {
            _RefershListProducts();
            _FillCategoriesInComboBox();
            if(cbSearchProduct.Items.Count>=0)
               cbSearchProduct.SelectedIndex = 0;
        }
        private void frmProductsManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditProduct Form1 = new frmAddEditProduct((int)dgvAllListProducts.CurrentRow.Cells[0].Value);
            Form1.ShowDialog();
            _RefershListProducts();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditProduct Form1 = new frmAddEditProduct(-1);
            Form1.ShowDialog();
            _RefershListProducts();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _Delete()
        {
            MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

            if (MessageDialog1.Show("\nAre You sure td delete this Product ? ", "Question") == DialogResult.Yes)
            {
                MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                if (clsProduct.DeleteProduct((int)dgvAllListProducts.CurrentRow.Cells[0].Value))
                {
                    MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    
                    MessageDialog1.Show("Delete Suseccfully ", "Information");
                    _RefershListProducts();
                }
                else
                {
                    MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    
                    MessageDialog1.Show("Delete was not Suseccfully ", "Error");
                }
            }

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Delete();
        }

        private void photoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhotoProduct Form1 = new frmPhotoProduct((string)dgvAllListProducts.CurrentRow.Cells[6].Value);
            Form1.ShowDialog(); 
        }

       
        private void btnDeleteAllProducts_Click(object sender, EventArgs e)
        {
            if(dgvAllListProducts.RowCount>=0)
            {
                if (clsProduct.DeleteAllProducts())
                    _RefershListProducts();
            }
           
        }

        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            _RefershListProducts();
        }

        private void _FillInComboBox()
        {
            cbSearchProduct.Items.Clear();
            if (rbSearchByCategory.Checked)
                _FillCategoriesInComboBox();
            else
                _FillProductNameInComboBox();
            if(cbSearchProduct.Items.Count>=0)
               cbSearchProduct.SelectedIndex = 0;
        }
        private void rbSearchByCategory_CheckedChanged(object sender, EventArgs e)
        {

            _FillInComboBox();
            
        }

        private void rbSearchByName_CheckedChanged(object sender, EventArgs e)
        {
            _FillInComboBox();
        }

        private void _Search()

        {
            DataTable dt = new DataTable(); 
            if(rbSearchByCategory.Checked)
                 dt = clsProduct.ListProductsForCategory(cbSearchProduct.Text);
            else if(rbSearchByName.Checked)
                dt = clsProduct.ListProductsForName(cbSearchProduct.Text);
            dgvAllListProducts.DataSource = dt;
            gbListProducts.Text = " List Products ( " + dt.Rows.Count + " ) Prodect(s)";

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Search();
        }
        private void _Print(DataGridView dgvName, string Title)
        {
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.Title = Title;
            dgvPrinter.SubTitle = DateTime.Now.ToString();
            dgvPrinter.PorportionalColumns = true;
            dgvPrinter.Footer = "Salaes Management";
            dgvPrinter.FooterSpacing = 15;
            dgvPrinter.PageNumbers = true;
            dgvPrinter.PrintDataGridView(dgvName);

        }
        private void btnPrintListProducts_Click(object sender, EventArgs e)
        {
            _Print(dgvAllListProducts,"List Products");
        }
    }
}
