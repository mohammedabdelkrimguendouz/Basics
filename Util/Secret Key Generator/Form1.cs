using System.Security.Cryptography;
using System;


namespace Secret_Key_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtSecretKey.Text.Trim());
        }

        private string _GenerateSecretKey(int length = 64)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var keyBytes = new byte[length];
                rng.GetBytes(keyBytes);
                return Convert.ToBase64String(keyBytes);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtSecretKey.Text = _GenerateSecretKey();
            btnCopy.Enabled = true;
        }
    }
}
