using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystemWinApp
{
    public partial class frmSystem : Form
    {
        public frmSystem()
        {
            InitializeComponent();
        }

        private void _RefreshClientsList()
        {
            dgvAllClients.DataSource = clsBankClient.ListClients();
        }
        private void _RefreshUsersList()
        {
            dgvAllUsers.DataSource = clsUser.ListUsers();
        }
        private void _GetListLogInRegisters()
        {
            dgvAllLogInRegisters.DataSource = clsUser.clsLogInRegister.ListLogInRegisters();
        }

        private void _SearchUserInfoByUserName()
        {
            if (txtSearchUser.Text == "")
            {
                _RefreshUsersList();
                _GetListLogInRegisters();
            }
            else
            {
                dgvAllLogInRegisters.DataSource = clsUser.GetListRigestersForUser(txtSearchUser.Text);
                dgvAllUsers.DataSource = clsUser.FindUserByUserName(txtSearchUser.Text);
            }
        }

        private void frmSystem_Load(object sender, EventArgs e)
        {
            _RefreshClientsList();
            _RefreshUsersList();
            _GetListLogInRegisters();
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            _SearchUserInfoByUserName();
        }

        private void btnClearRegisterLogIn_Click(object sender, EventArgs e)
        {
            clsUser.clsLogInRegister.DeleteAllListLogInRegisters();
            _GetListLogInRegisters();
        }
        private void _ListLogInByDate()
        {
            dgvAllLogInRegisters.DataSource = clsUser.GetListLogInByDate(dtpSearchLogInRegister.Value);
        }

        private void btnSearchLogInByDate_Click(object sender, EventArgs e)
        {
            _ListLogInByDate();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser Form = new frmAddEditUser(-1);
            Form.ShowDialog();
            _RefreshUsersList();
        }

        private void btnSingOut_Click(object sender, EventArgs e)
        {
            clsGlobal.UserActive = null;
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsUser.DeleteUser((int)dgvAllUsers.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("User Deleted Successfully ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshUsersList();
                _GetListLogInRegisters();
            }else
                MessageBox.Show("User is not  Deleted Successfully ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser Form = new frmAddEditUser((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _RefreshUsersList();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clsBankClient.DeleteClient((int)dgvAllClients.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Client Deleted Successfully ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshClientsList();
                
            }
            else
                MessageBox.Show("Client is not  Deleted Successfully ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClearAllClients_Click(object sender, EventArgs e)
        {
            clsBankClient.DeleteAllClients();
            _RefreshClientsList();
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchClient.Text!="")
            {
                dgvAllClients.DataSource = clsBankClient.FindClientByAccountNumber(txtSearchClient.Text);
            }
            else
            {
                _RefreshClientsList();
            }
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            frmAddEditClient Form = new frmAddEditClient(-1);
            Form.ShowDialog();
            _RefreshClientsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClient Form = new frmAddEditClient((int)dgvAllClients.CurrentRow.Cells[0].Value);
            Form.ShowDialog();
            _RefreshClientsList();
        }

        
        
        private void debositToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDeposite Form = new frmDeposite((string)dgvAllClients.CurrentRow.Cells[9].Value, (double)dgvAllClients.CurrentRow.Cells[11].Value);
            Form.ShowDialog();
            _RefreshClientsList();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWithdraw Form = new frmWithdraw((string)dgvAllClients.CurrentRow.Cells[9].Value, (double)dgvAllClients.CurrentRow.Cells[11].Value);
            Form.ShowDialog();
            _RefreshClientsList();
        }
    }
}
