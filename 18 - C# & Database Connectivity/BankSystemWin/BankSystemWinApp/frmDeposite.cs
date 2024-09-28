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
    public partial class frmDeposite : Form
    {
        private string _AccountNumber;

        private double _AccountBalance;
        public frmDeposite(string AccountNumber,double AccountBalance)
        {
            InitializeComponent();
            _AccountBalance = AccountBalance;
            _AccountNumber = AccountNumber;
        }
        private bool _Deposite()
        {
            clsBankClient Client = clsBankClient.Find(_AccountNumber);
            return (Client.Deposite(Convert.ToDouble(txtAmountDeposite.Text)));
        }

        private void _LoadData()
        {
            lblAccountBalanceDeposite.Text = _AccountBalance.ToString();
            lblAccountNumberDeposite.Text = _AccountNumber;
        }
        private void btnCancleDeposite_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeposite_Click(object sender, EventArgs e)
        {
            if (_Deposite())
            {

                MessageBox.Show("Deposite Successfully ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {

                MessageBox.Show("Deposite is  not  Successfully ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void frmDeposite_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
