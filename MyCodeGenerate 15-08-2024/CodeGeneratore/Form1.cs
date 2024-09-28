using CodeGeneratore_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGeneratore
{
    public partial class Form1 : Form
    {
        private clsCodeGeneratore _CodeGeneratore = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void _FillTablesInComboBox()
        {
            
            if (cbTables.Items.Count > -1)
                  cbTables.Items.Clear();
            DataTable dt =clsCodeGeneratore.GetAllTables();
            foreach (DataRow Row in dt.Rows)
            {
                cbTables.Items.Add(Row["TABLE_NAME"]);
            }

            if(cbTables.Items.Count>-1)
                 cbTables.SelectedIndex = 0;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            _CodeGeneratore=new clsCodeGeneratore (txtServer.Text.Trim(), txtDataBase.Text.Trim(),
               txtUserId.Text.Trim(), txtPassword.Text.Trim());

            if (!_CodeGeneratore.IsConnectionValide())
            {
                MessageBox.Show("Error Connection -( ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            gbGenerateCode.Enabled = true;
            _FillTablesInComboBox();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "sa123456";
            txtServer.Text = ".";
            txtUserId.Text = "sa";
        }

        private void btnGenrate_Click(object sender, EventArgs e)
        {
            _CodeGeneratore.SelectedTable = cbTables.Text;
            string BusinessLayer = _CodeGeneratore.GenerateBusinessLayer();
            string DataAccessLayer = _CodeGeneratore.GenerateDataAccessLayer();

            frmShowCodeGenerated frm = new frmShowCodeGenerated(BusinessLayer, DataAccessLayer);
            frm.ShowDialog();
           
        }
    }
}
