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
    public partial class frmUsersManagement : Form
    {
       
        public frmUsersManagement()
        {
            InitializeComponent();
        }
        private void _RefershListUsers()
        {
            DataTable UsersDataTable = clsUser.ListUsers();
            dgvAllListUsers.DataSource = UsersDataTable;
            gbListUsers.Text = "List Users ( " + UsersDataTable.Rows.Count + " User(s) )";
        }
        private void _RefershListLogInRegisters()
        {
            DataTable LogInRegistersDataTable = clsUser.ListLogInRegisters();
            dgvListLogInRegisters.DataSource = LogInRegistersDataTable;
            gbListLogInRegisters.Text = "List Log In Registers ( " + LogInRegistersDataTable.Rows.Count + " Register(s) )";
        }
        private void _LoadData()
        {
            _RefershListUsers();
            _RefershListLogInRegisters();
        }
        private void frmUsersManagement_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnRefreshListUsers_Click(object sender, EventArgs e)
        {
               _RefershListUsers();
        }

        private void btnListLogInRegisters_Click(object sender, EventArgs e)
        {
            _RefershListLogInRegisters();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddEditUser Form1 = new frmAddEditUser(-1);
            Form1.ShowDialog();
            _RefershListUsers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser Form1 = new frmAddEditUser((int)dgvAllListUsers.CurrentRow.Cells[0].Value);
            Form1.ShowDialog();
            _RefershListUsers();
        }

        private void _DeleteUser()
        {
            if(clsUser.DeleteUser((int)dgvAllListUsers.CurrentRow.Cells[0].Value))
                MessageDialog1.Show("\n User  delete Successfully ", "Info ");
            else
                MessageDialog1.Show("\n User  Cannot be delete  ", "Error ");
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAllListUsers.CurrentRow.Cells[1].Value.ToString().ToLower() == "admin")
                MessageDialog1.Show("\n User admin Cannot be delete  ", "Error ");
            else
            {
                _DeleteUser();
                _RefershListUsers();
            }
                

        }

        private void _DeleteAllLogInRegister()
        {
            if (clsUser.DeleteAllLogInRegister())
                MessageDialog1.Show("\n Log In Register  delete Successfully ", "Info ");
            else
                MessageDialog1.Show("\n Log In Register Was not delete Successfully  ", "Error ");
        }
        private void btnDeleteAllListLogInRegister_Click(object sender, EventArgs e)
        {
            if(dgvListLogInRegisters.RowCount>=0)
                _DeleteAllLogInRegister();
                _RefershListLogInRegisters();

        }

        private void _DeleteLogInRegister()
        {
            if (clsUser.DeleteLogInRegister((int)dgvListLogInRegisters.CurrentRow.Cells[0].Value))
                MessageDialog1.Show("\n Register  delete Successfully ", "Info ");
            else
                MessageDialog1.Show("\n Register  Cannot be delete  ", "Error ");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _DeleteLogInRegister();
            _RefershListLogInRegisters();
        }

        private void _Search()
        {
            dgvAllListUsers.DataSource = clsUser.SearchUser(txtSearchByUserName.Text);
            dgvListLogInRegisters.DataSource = clsUser.SearchLogInRegisterForUser(txtSearchByUserName.Text);
        }

        private void txtSearchByUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchByUserName.Text == "")
            {
                _RefershListLogInRegisters();
                _RefershListUsers();
            }
            else
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



        private void btnPrintListUsers_Click(object sender, EventArgs e)
        {
            _Print(dgvAllListUsers,"List Users");
        }

        private void btnPrintListLogInRegisters_Click(object sender, EventArgs e)
        {
            _Print(dgvListLogInRegisters, "List LogIn Registers");
        }
    }
}
