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
    public partial class frmListProducts : Form
    {

        private bool IsChooseProduct;
        public frmListProducts()
        {
            InitializeComponent();
        }

        private void _RefershListProducts()
        {
            DataTable ProductsDataTable = clsProduct.ListProducts();
            dgvAllListProducts.DataSource = ProductsDataTable;
            gbListProducts.Text = "List Products ( " + ProductsDataTable.Rows.Count + " Product(s) )";
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
            IsChooseProduct = false;
            _RefershListProducts();
            _FillCategoriesInComboBox();
            if (cbSearchProduct.Items.Count >= 0)
                cbSearchProduct.SelectedIndex = 0;
        }

        private void _FillInComboBox()
        {
            cbSearchProduct.Items.Clear();
            if (rbSearchByCategory.Checked)
                _FillCategoriesInComboBox();
            else
                _FillProductNameInComboBox();
            if (cbSearchProduct.Items.Count >= 0)
                cbSearchProduct.SelectedIndex = 0;
        }

        private void _Search()

        {
            DataTable dt = new DataTable();
            if (rbSearchByCategory.Checked)
                dt = clsProduct.ListProductsForCategory(cbSearchProduct.Text);
            else if (rbSearchByName.Checked)
                dt = clsProduct.ListProductsForName(cbSearchProduct.Text);
            dgvAllListProducts.DataSource = dt;
            gbListProducts.Text = " List Products ( " + dt.Rows.Count + " ) Prodect(s)";

        }
        private void frmListProducts_Load(object sender, EventArgs e)
        {
            _LoadData();
        }



        private void btnRefrechListProducts_Click(object sender, EventArgs e)
        {
            _RefershListProducts();
        }

        private void rbSearchByCategory_CheckedChanged(object sender, EventArgs e)
        {
            _FillInComboBox();
        }

        private void rbSearchByName_CheckedChanged(object sender, EventArgs e)
        {
            _FillInComboBox();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Search();
        }

        private void dgvAllListProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IsChooseProduct = true;
            this.Close();
        }
    }
}
