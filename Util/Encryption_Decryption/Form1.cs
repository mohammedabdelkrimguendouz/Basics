using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using System.IO;
using Guna.UI2.WinForms;


namespace Encryption_Decryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                txtOriginalText.Focus();
                txtOriginalText.Select(0, 0);

            }));
        }

        enum enModeText { eArabic,eEnglish};

        enModeText ModeText = enModeText.eEnglish;

        const short EncryptionKey = 3;

        private string EncryptText(string Text)
        {
            string TextEncryption = "";
            for (short i = 0; i < Text.Length; i++)
            {
                TextEncryption =TextEncryption+ Convert.ToChar(((int)Text[i] + EncryptionKey));
            }
            return TextEncryption ;
        }
        private string DecryptText(string Text)
        {
            string TextDecryption = "";
            for (int i = 0; i < Text.Length; i++)
            {
                TextDecryption = TextDecryption+(char)((int)Text[i] - EncryptionKey);
            }
            return TextDecryption;
        }

        private void ShowTextDecrypted(string TextDecrypted)
        {
            txtTextEncryptedAfterEncryption.Text = TextDecrypted;
        }
        private void Encryption()
        {

            ShowTextDecrypted(EncryptText(txtOriginalText.Text));
        }
        private void btnEncryption_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOriginalText.Text))
            {
                Encryption();
                btnCopyEncryptedText.Enabled = btnSaveEncryptedText.Enabled= true;
            }
                
            else
            {
                errorProvider1.SetError(txtOriginalText, "Text Is Empty ");
                txtOriginalText.BorderColor = Color.Red;
            }
        }

        private void txtOriginalText_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtOriginalText, "");
            txtOriginalText.BorderColor = Color.Silver;
        }

        private void ResetEncryption()
        {
            errorProvider1.SetError(txtOriginalText, "");
            txtOriginalText.BorderColor = Color.Silver;
            txtOriginalText.Clear();
            txtTextEncryptedAfterEncryption.Clear();
            btnCopyEncryptedText.Enabled = btnSaveEncryptedText.Enabled = false;
        }
        private void btnResetEncryption_Click(object sender, EventArgs e)
        {
            ResetEncryption();
        }

        private void Open(Guna2TextBox TextBoxName)
        {
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            //openFileTextOriginalDialog.Title = "karim save as";
            openFileDialog.FilterIndex = 1;
            openFileDialog.FileName = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                GetTextFromFile(openFileDialog.FileName,TextBoxName);
            }
        }
        private void GetTextFromFile(string FileName, Guna2TextBox TextBoxName)
        {
            var MyFile=new StreamReader(FileName);
            TextBoxName.Text = MyFile.ReadToEnd();
            MyFile.Close();
        }
        private void btnOpenFileOriginalText_Click(object sender, EventArgs e)
        {
            Open((Guna2TextBox)txtOriginalText);
        }

        private void btnCopyEncryptedText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtTextEncryptedAfterEncryption.Text);
        }

        private void SetTextToFile(string FileName, Guna2TextBox TextBoxName)
        {
            var MyFile = new StreamWriter(FileName);
            MyFile.Write(TextBoxName.Text);
            MyFile.Close();

        }

        private void Save(Guna2TextBox TextBoxName)
        {
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            //saveFileTextEncryptedAfterEncryptionDialog.Title = "karim save as";
            saveFileDialog.FilterIndex = 2;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SetTextToFile(saveFileDialog.FileName, TextBoxName);
                MessageDialog.Show();
            }
        }
        private void btnSaveEncryptedText_Click(object sender, EventArgs e)
        {
            Save((Guna2TextBox)txtTextEncryptedAfterEncryption);
        }

        private void txtTextEncrypted_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTextEncrypted, "");
            txtTextEncrypted.BorderColor = Color.Silver;
        }

        private void ShowOriginalText(string OriginalText)
        {
            txtOriginalTextAfterDecryption.Text = OriginalText;
        }
        private void Decryption()
        {
            ShowOriginalText(DecryptText(txtTextEncrypted.Text));
        }
        private void btnDecryption_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTextEncrypted.Text))
            {
                Decryption();
                btnCopyOriginalText.Enabled = btnSaveOriginalText.Enabled = true;
            }

            else
            {
                errorProvider1.SetError(txtTextEncrypted, "Text Is Empty ");
                txtTextEncrypted.BorderColor = Color.Red;
            }
        }

        private void ResetDecryption()
        {
            errorProvider1.SetError(txtTextEncrypted, "");
            txtTextEncrypted.BorderColor = Color.Silver;
            txtTextEncrypted.Clear();
            txtOriginalTextAfterDecryption.Clear();
            btnCopyOriginalText.Enabled = btnSaveOriginalText.Enabled = false;
        }
        private void btnResetDecryption_Click(object sender, EventArgs e)
        {
            ResetDecryption();
        }

        private void btnCopyOriginalText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtOriginalTextAfterDecryption.Text);
        }

        private void btnSaveOriginalText_Click(object sender, EventArgs e)
        {
            Save((Guna2TextBox)txtOriginalTextAfterDecryption);
        }

        private void btnOpenFileDecrypted_Click(object sender, EventArgs e)
        {
            Open((Guna2TextBox)txtTextEncrypted);
        }

        private void ConvertModeTextEncryption()
        {
            if (cbxEncryption.SelectedIndex == 1)
            {
                txtOriginalText.RightToLeft = RightToLeft.No;
                txtTextEncryptedAfterEncryption.RightToLeft = RightToLeft.No;   
                txtOriginalText.PlaceholderText = "Enter Original Text Or Choose File Text";
                txtTextEncryptedAfterEncryption.PlaceholderText = "Original Text After Encryption";

            }
            else
            {
                txtOriginalText.RightToLeft = RightToLeft.Yes;
                txtTextEncryptedAfterEncryption.RightToLeft = RightToLeft.Yes;
                txtOriginalText.PlaceholderText = "ادخل النص الاصلي اواختر  ملف النص";
                txtTextEncryptedAfterEncryption.PlaceholderText = "النص الاصلي بعد التشفير";
            }
        }
        private void ConvertModeTextDecryption()
        {
            if (cbxDecryption.SelectedIndex == 1)
            {
                txtTextEncrypted.RightToLeft = RightToLeft.No;
                txtOriginalTextAfterDecryption.RightToLeft = RightToLeft.No;
                txtTextEncrypted.PlaceholderText = "Enter Text Decrypted Or Choose File Decrypted";
                txtOriginalTextAfterDecryption.PlaceholderText = "Original Text After Decryption";

            }
            else
            {
                txtTextEncrypted.RightToLeft = RightToLeft.Yes;
                txtOriginalTextAfterDecryption.RightToLeft = RightToLeft.Yes;
                txtTextEncrypted.PlaceholderText = "ادخل النص المشفر اواختر  الملف المشفر";
                txtOriginalTextAfterDecryption.PlaceholderText = "النص الاصلي بعد فك التشفير";
            }
        }
        private void cbxEncryption_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertModeTextEncryption();
        }

        private void cbxDecryption_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertModeTextDecryption();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(tsBackGroundColor.Checked)
            {
                this.BackColor = Color.Black;
                lblTitle.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                lblTitle.ForeColor = Color.Black;
            }
        }
    }
}
