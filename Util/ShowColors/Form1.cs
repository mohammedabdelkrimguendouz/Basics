using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowColors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumericUpDownChangeColor()
        {
            tbRedColor.Value = (int)nudRed.Value;
            tbGreenColor.Value = (int)nudGreen.Value;
            tbBlueColor.Value = (int)nudBlue.Value;
            tbAlpha.Value = (int)nudAlpha.Value;
            ChangeColor();
        }
        private void nudChangeColor(object sender, EventArgs e)
        {
            NumericUpDownChangeColor();
        }

        private void TrackBarChangeColor()
        {
            nudRed.Value = tbRedColor.Value;
            nudGreen.Value = tbGreenColor.Value;
            nudBlue.Value = tbBlueColor.Value;
            nudAlpha.Value = tbAlpha.Value;
            ChangeColor();
        }
        private void tbChangeColor(object sender, EventArgs e)
        {
            TrackBarChangeColor();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UpdateInformationColor()
        {
            nudRed.Value = tbRedColor.Value = plColor.BackColor.R;
            nudBlue.Value = tbBlueColor.Value = plColor.BackColor.B;
            nudGreen.Value = tbGreenColor.Value = plColor.BackColor.G;
            nudAlpha.Value = tbAlpha.Value = plColor.BackColor.A;
            lblColorHex.Text= "#" + Convert.ToString(plColor.BackColor.ToArgb(), 16).ToUpper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NumericUpDownChangeColor();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblColorHex.Text);
        }

        private void ChangeColor()
        {
            plColor.BackColor = Color.FromArgb((int)nudAlpha.Value, (int)nudRed.Value, (int)(nudGreen.Value), (int)(nudBlue.Value));
            lblColorHex.Text = "#" + Convert.ToString(plColor.BackColor.ToArgb(), 16).ToUpper();
        }
        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                plColor.BackColor = colorDialog1.Color;
                UpdateInformationColor();
            }
        }

       
    }
}
