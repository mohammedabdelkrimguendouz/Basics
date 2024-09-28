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
    public partial class frmWithdraw : Form
    {
        private string _AccountNumber;

        private double _AccountBalance;
        public frmWithdraw(string AccountNumber, double AccountBalance)
        {
            InitializeComponent();
            _AccountBalance = AccountBalance;
            _AccountNumber = AccountNumber;
        }

        private bool _Withdraw()
        {
            clsBankClient Client = clsBankClient.Find(_AccountNumber);
            return (Client.Witdraw(Convert.ToDouble(txtAmountWithdraw.Text)));
        }

        private void _LoadData()
        {
            lblAccountBalanceWithdraw.Text = _AccountBalance.ToString();
            lblAccountNumberWithdraw.Text = _AccountNumber;
        }
        private void btnCancleWithdraw_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWithdraw_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (_Withdraw())
            {

                MessageBox.Show("Withdraw Successfully ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {

                MessageBox.Show("Withdraw is  not  Successfully ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
