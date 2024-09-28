using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Generate_Password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            lblPasswordLength.Text = trackBar1.Value.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtPassword.Text))
                Clipboard.SetText(txtPassword.Text);
            else
                Clipboard.SetText(" ");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss");
        }

        private void btnCopy_MouseMove(object sender, MouseEventArgs e)
        {
            btnCopy.BackColor = Color.Blue;
        }

        private void btnCopy_MouseLeave(object sender, EventArgs e)
        {
            btnCopy.BackColor = Color.DarkBlue;
        }

        private void btnGenerate_MouseMove(object sender, MouseEventArgs e)
        {
            btnGenerate.BackColor = Color.Green;
        }

        private void btnGenerate_MouseLeave(object sender, EventArgs e)
        {
            btnGenerate.BackColor = Color.DarkGreen;
        }

        public enum enCharType
        {
           UpperCase =1, LowerCase = 2, Numbers =4, Symbols=8
        };

        stInformationPassword InformationPassword;
        public struct stInformationPassword
        {
            public int PermissionCharPassword;
            public byte PasswordLength;
        }

        private int GetPermissionCharTypePassword()
        {
            int permission = 0;
            if (chkUpperCase.Checked) permission += (int)enCharType.UpperCase;
            if (chkLowerCase.Checked) permission += (int)enCharType.LowerCase;
            if (chkNumbers.Checked) permission += (int)enCharType.Numbers;
            if (chkSymbols.Checked) permission += (int)enCharType.Symbols;
            return permission;

        }
        private void SetRecordInformationPassword()
        {
            InformationPassword.PasswordLength = Convert.ToByte(lblPasswordLength.Text);
            InformationPassword.PermissionCharPassword = GetPermissionCharTypePassword();
        }

        private bool IsCheckBoxCheked()
        {
            if (chkLowerCase.Checked || chkNumbers.Checked || chkUpperCase.Checked || chkSymbols.Checked)
                return true;
            return false;
        }

        private List<int> GetListPermission()
        {
            List<int> ListPermission=new List<int>();

            if(((int)enCharType.UpperCase & InformationPassword.PermissionCharPassword) == (int)enCharType.UpperCase)
                ListPermission.Add((int)enCharType.UpperCase);
            if (((int)enCharType.LowerCase & InformationPassword.PermissionCharPassword) == (int)enCharType.LowerCase)
                ListPermission.Add((int)enCharType.LowerCase);
            if (((int)enCharType.Numbers & InformationPassword.PermissionCharPassword) == (int)enCharType.Numbers)
                ListPermission.Add((int)enCharType.Numbers);
            if (((int)enCharType.Symbols & InformationPassword.PermissionCharPassword) == (int)enCharType.Symbols)
                ListPermission.Add((int)enCharType.Symbols);           
            return ListPermission;
        }
        private char GetRandomCharacter(List<int> ListPermission)
        {
            
            int seed;
            Random random;
            using (System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[4];
                rng.GetBytes(buffer);
                seed = BitConverter.ToInt32(buffer, 0);
                random = new Random(seed);
            }
            enCharType CharType = (enCharType)ListPermission[ random.Next(ListPermission.Count)];
            

            switch (CharType)
            {
                case enCharType.LowerCase:
                    {
                        return (char) random.Next(97, 123);
                    }
                case enCharType.UpperCase:
                    {
                        return (char)random.Next(65, 91);
                    }
                case enCharType.Numbers:
                    {
                        return (char)random.Next(48, 58);
                    }
                case enCharType.Symbols:
                    {
                        int[] ArraySymbolsRandom = { new Random().Next(35, 39), 45, 95, 126 };
                        return (char)ArraySymbolsRandom[random.Next(ArraySymbolsRandom.Count())];
                    }

            }
            return '0';
        }

        private string GeneratePassword()
        {
            string Word = "";
            List<int> ListPermission = GetListPermission();
            for (short i = 1; i <= InformationPassword.PasswordLength; i++)
            {
                Word += GetRandomCharacter(ListPermission);
            }
            return Word;
        }

        private void ShowPassword()
        {
            txtPassword.Text = GeneratePassword();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(IsCheckBoxCheked())
            {
                SetRecordInformationPassword();
                ShowPassword();
            }
            else
                MessageBox.Show("Please select character set ! ", "Character set error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        private void btnClear_MouseMove(object sender, MouseEventArgs e)
        {
            btnClear.BackColor = Color.Red;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.DarkRed;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        
    }
}
