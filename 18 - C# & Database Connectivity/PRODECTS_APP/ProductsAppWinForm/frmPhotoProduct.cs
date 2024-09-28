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
    public partial class frmPhotoProduct : Form
    {
        private string _ImagePath = "";
        public frmPhotoProduct(string ImagePath)
        {
            InitializeComponent();
            _ImagePath = ImagePath;
        }
        private void _ShowPhoto()
        {
            if(_ImagePath!="")
            {
                pbShowImageProduct.ImageLocation = _ImagePath;
                pbShowImageProduct.Load(pbShowImageProduct.ImageLocation);
            }
            
        }
        private void frmPhotoProduct_Load(object sender, EventArgs e)
        {
            _ShowPhoto();   
        }
    }
}
