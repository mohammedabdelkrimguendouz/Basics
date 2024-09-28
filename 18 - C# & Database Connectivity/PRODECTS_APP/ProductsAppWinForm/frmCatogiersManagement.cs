using DGVPrinterHelper;
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
    public partial class frmCatogiersManagement : Form
    {
        public frmCatogiersManagement()
        {
            InitializeComponent();
        }

        private void _RefershListCatogiers()
        {
            DataTable CatogiersDataTable = clsCategory.ListCategories();
            dgvAllListCatogiers.DataSource = CatogiersDataTable;
            gbListProducts.Text = "List Catogiers ( " + CatogiersDataTable.Rows.Count + " Catogier(s) )";
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditCategory Form1 = new frmAddEditCategory(-1);
            Form1.ShowDialog();
            _RefershListCatogiers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCategory Form1 = new frmAddEditCategory((int)dgvAllListCatogiers.CurrentRow.Cells[0].Value);
            Form1.ShowDialog();
            _RefershListCatogiers();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCatogiersManagement_Load(object sender, EventArgs e)
        {
            _RefershListCatogiers();
        }

        private void btnDeleteAllProducts_Click(object sender, EventArgs e)
        {
            if(dgvAllListCatogiers.RowCount>=0)
            {
                if (clsCategory.DeleteAllCategories())
                    _RefershListCatogiers();
            }
           
        }
        private void _Delete()
        {
            MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

            if (MessageDialog1.Show("\nAre You sure td delete this Catogory ? ", "Question") == DialogResult.Yes)
            {
                MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                if (clsCategory.DeleteCategory((int)dgvAllListCatogiers.CurrentRow.Cells[0].Value))
                {
                    MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;

                    MessageDialog1.Show("Delete Suseccfully ", "Information");
                    _RefershListCatogiers();
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

        private void _Print(DataGridView dgvName,string Title)
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
        private void btnPrintListUsers_Click(object sender, EventArgs e)
        {
            _Print(dgvAllListCatogiers, "List Catogiers");
        }
    }
}
