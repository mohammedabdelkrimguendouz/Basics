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
    public partial class frmListCustomers : Form
    {
        public bool IsChooseCustomer;
        public frmListCustomers()
        {
            InitializeComponent();
            
        }
        private void _ReferchListCustomers()
        {
            DataTable dt= clsCustomer.ListCustomers();
            dgvListCustomers.DataSource = dt;
            gbListCustomers.Text = " List Customers ( " + dt.Rows.Count + " ) Customer(s)";
        }

      
        private void _Search()

        {
            DataTable dt = new DataTable();
            if (txtFirstName.Text != "" && txtLastName.Text != "")
                dt= clsCustomer.SearchByFirstNameAndLastName(txtFirstName.Text, txtLastName.Text);
            else if (txtFirstName.Text != "")
                dt= clsCustomer.SearchByFirstName(txtFirstName.Text);
            else
                dt= clsCustomer.SearchByLastName(txtLastName.Text);

            gbListCustomers.Text = " List Customers ( " + dt.Rows.Count + " ) Customer(s)";
            dgvListCustomers.DataSource = dt;
        }

        private void _LoadData()
        {
            _ReferchListCustomers();
            IsChooseCustomer = false;
        }

        private void frmListCustomers_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Search();
        }

        private void btnRefrchListCustomers_Click(object sender, EventArgs e)
        {
            _ReferchListCustomers();
        }

     

        private void dgvListCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IsChooseCustomer = true;
            this.Close();
        }
    }
}
