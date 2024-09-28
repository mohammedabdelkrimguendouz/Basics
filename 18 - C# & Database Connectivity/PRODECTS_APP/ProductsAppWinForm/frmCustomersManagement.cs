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
using DGVPrinterHelper;

namespace ProductsAppWinForm
{
    public partial class frmCustomersManagement : Form
    {
        public frmCustomersManagement()
        {
            InitializeComponent();
        }

        private void _RefershListCustomers()
        {
            DataTable CustomersDataTable = clsCustomer.ListCustomers();
            dgvAllListCustomers.DataSource = CustomersDataTable;
            gbListCustomers.Text = "List Customers ( " + CustomersDataTable.Rows.Count + " Customer(s) )";
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
            _RefershListCustomers();
            _FillCountriesInComboBox();
            cbCountries.SelectedIndex = 0;
        }

        private void _Delete()
        {
            
                if (clsCustomer.DeleteCustomer((int)dgvAllListCustomers.CurrentRow.Cells[0].Value))
                {
                    MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    MessageDialog1.Show("Delete Suseccfully ", "Information");
                    _RefershListCustomers();
                }
                else
                {
                    MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    MessageDialog1.Show("Delete was not Suseccfully ", "Error");
                }
            

        }

        private DataTable _ListSearchByCountry()
        {
            return clsCustomer.SearchByCountryName(cbCountries.Text);
        }
        private DataTable _ListSearchByName()
        {
            if (txtFirstName.Text == "" && txtLastName.Text == "")
                return new DataTable();
            if (txtFirstName.Text != "" && txtLastName.Text != "")
                return clsCustomer.SearchByFirstNameAndLastName(txtFirstName.Text, txtLastName.Text);
            if (txtFirstName.Text != "")
                return clsCustomer.SearchByFirstName(txtFirstName.Text);
            return clsCustomer.SearchByLastName(txtLastName.Text);

        }
        private void _Search()

        {
            DataTable dt = new DataTable();
            if (rbSearchByCountries.Checked)
               dt= _ListSearchByCountry();
            else if (rbSearchByName.Checked)
               dt= _ListSearchByName();
            dgvAllListCustomers.DataSource = dt;
            gbListCustomers.Text = " List Customers ( " + dt.Rows.Count + " ) Customer(s)";

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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditeCustomer Form1 = new frmAddEditeCustomer(-1);
            Form1.ShowDialog();
            _RefershListCustomers();
        }

        private void frmCustomersManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnRefreshListCustomers_Click(object sender, EventArgs e)
        {
            _RefershListCustomers();
        }

        private void btnDeleteAllCustomers_Click(object sender, EventArgs e)
        {
            if (dgvAllListCustomers.RowCount >= 0)
            {
                if (clsCustomer.DeleteAllCustomers())
                    _RefershListCustomers();
                    
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditeCustomer Form1 = new frmAddEditeCustomer((int)dgvAllListCustomers.CurrentRow.Cells[0].Value);
            Form1.ShowDialog();
            _RefershListCustomers();
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            _Print(dgvAllListCustomers,"List Customers");
        }

        private void photoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhotoCustomer Form1 = new frmPhotoCustomer((string)dgvAllListCustomers.CurrentRow.Cells[6].Value);
            Form1.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Delete();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Search();
        }

     
    }
}

