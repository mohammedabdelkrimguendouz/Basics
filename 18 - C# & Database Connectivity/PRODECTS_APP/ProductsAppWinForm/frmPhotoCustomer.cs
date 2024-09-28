using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsAppWinForm
{
    public partial class frmPhotoCustomer : Form
    {
        private string _ImagePath = "";
        public frmPhotoCustomer(string ImagePath)
        {
            InitializeComponent();
            _ImagePath= ImagePath;
        }
        private void _ShowPhoto()
        {
            if (_ImagePath != "")
            {
                pbImageCustomer.ImageLocation = _ImagePath;
                pbImageCustomer.Load(pbImageCustomer.ImageLocation);
            }

        }

        private void frmPhotoCustomer_Load(object sender, EventArgs e)
        {
            _ShowPhoto();
        }
    }
}
