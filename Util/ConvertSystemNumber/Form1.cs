using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertSystemNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private bool IsBinaryNumber(string Number)
        {
            foreach (char C in Number)
            {
                if(C!='1'&& C!='0')
                    return false;
            }
            return true;
        }

        private bool IsOctalNumber(string Number)
        {
            foreach (char C in Number)
            {
                if ((int)C<48 || (int)C>55)
                    return false;
            }
            return true;
        }

        private bool IsDecimalNumber(string Number)
        {
            foreach (char C in Number)
            {
                if ((int)C < 48 || (int)C > 57)
                    return false;
            }
            return true;
        }

        private bool IsLetterHexadecimal(char Letter)
        {
            if ((int)Char.ToUpper(Letter) < 65 || (int)Char.ToUpper(Letter) > 70)
                return false;
            return true;
        }

        private bool IsHexadecimalNumber(string Number)
        {
            foreach (char C in Number)
            {
                if (((int)C < 48 || (int)C > 57) && !IsLetterHexadecimal(C) )
                    return false;
            }
            return true;
        }
        private bool IsNumberValide()
        {
            if (string.IsNullOrWhiteSpace(txtNumber.Text)) return false;
            if (cbSystemNumber.Text == "Decimal")
            {
                return IsDecimalNumber(txtNumber.Text.Trim());
            }
            else if (cbSystemNumber.Text == "Binary")
            {
                return IsBinaryNumber(txtNumber.Text.Trim());
            }
            else if (cbSystemNumber.Text == "Octal")
            {
                return IsOctalNumber(txtNumber.Text.Trim());
            }
            else
                return IsHexadecimalNumber(txtNumber.Text.Trim());
           
        }
        
        private void ShowConversion()
        {

        }

       
        private void ConvertBinaryToAuthor()
        {
            lblDecimal.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim(),2));
            lblOctal.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim(), 2),8);
            lblHexadecimal.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim(), 2),16).ToUpper();
        }
        private void ConvertDecimalToAuthor()
        {
            lblBinary.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim()),2);
            lblOctal.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim()),8);
            lblHexadecimal.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim()),16).ToUpper();
        }
        private void ConvertOctalToAuthor()
        {
            lblDecimal.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim(), 8));
            lblBinary.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim(), 8), 2);
            lblHexadecimal.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim(), 8), 16).ToUpper();
        }
        private void ConvertHexadecimalToAuthor()
        {
            lblDecimal.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim(), 16));
            lblBinary.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim(), 16), 2);
            lblOctal.Text = Convert.ToString(Convert.ToInt32(txtNumber.Text.Trim(), 16), 8);
        }

        private void ConvertionsNumbers()
        {
            switch(cbSystemNumber.Text)
            {
                case "Binary":
                    lblBinary.Text = txtNumber.Text;
                    ConvertBinaryToAuthor();
                    break;
                case "Decimal":
                    lblDecimal.Text = txtNumber.Text;
                    ConvertDecimalToAuthor();
                    break;
                case "Octal":
                    lblOctal.Text = txtNumber.Text;
                    ConvertOctalToAuthor();
                    break;
                case "Hexadecimal":
                    lblHexadecimal.Text = txtNumber.Text.ToUpper();
                    ConvertHexadecimalToAuthor();
                    break;
            }
        }

        private void MessageError()
        {
            MessageDialog1.Caption = "Error";
            MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            MessageDialog1.Text = Environment.NewLine+"Inconsistent number !";
            MessageDialog1.Show();
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (IsNumberValide())
                ConvertionsNumbers();
            else
                MessageError();

        }
    }
}
