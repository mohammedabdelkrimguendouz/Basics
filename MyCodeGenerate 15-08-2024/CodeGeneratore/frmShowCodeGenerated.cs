﻿using System;
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
    public partial class frmShowCodeGenerated : Form
    {
        private string _BusinessLayer = "";
        private string _DataAccessLayer = "";

        public frmShowCodeGenerated(string BusinessLayer, string DataAccessLayer)
        {
            InitializeComponent();
            _BusinessLayer=BusinessLayer;
            _DataAccessLayer = DataAccessLayer;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShowCodeGenerate_Load(object sender, EventArgs e)
        {
            txtBusinessLayer.Clear();
            txtBusinessLayer.Text = _BusinessLayer;

            txtDataAccessLayer.Clear();
            txtDataAccessLayer.Text = _DataAccessLayer;

            
            
        }

        private void _CopyToClipboard(string Text)
        {
            Clipboard.SetText(Text);
            if (Clipboard.ContainsText())
                MessageBox.Show("Text Copied Successfully -) ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Failed To Copy Text -( ", "Erroe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCopyBusiness_Click(object sender, EventArgs e)
        {
            _CopyToClipboard(_BusinessLayer);
        }

        private void btnCopyDataAccess_Click(object sender, EventArgs e)
        {
            _CopyToClipboard(_DataAccessLayer);
        }

       
    }
}
