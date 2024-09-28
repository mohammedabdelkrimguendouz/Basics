using MyFirstEWinFormsProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstEWinFormsProject
{
    public partial class frmPictureBox : Form
    {
        public frmPictureBox()
        {
            InitializeComponent();
        }

        

        

        private void frmPictureBox_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedItem.ToString().ToLower())
            {
                case "boy":
                    pbPhoto.Image = Resources.Boy;
                    lblTitle.Text = "Boy";
                    break;
                case "girl":
                    pbPhoto.Image = Resources.Girl;
                    lblTitle.Text = "Girl";
                    break;
                case "book":
                    pbPhoto.Image = Resources.Book;
                    lblTitle.Text = "Book";
                    break;
                case "pen":
                    pbPhoto.Image = Resources.Pen;
                    lblTitle.Text = "Pen";
                    break;

            }
        }
    }
}
