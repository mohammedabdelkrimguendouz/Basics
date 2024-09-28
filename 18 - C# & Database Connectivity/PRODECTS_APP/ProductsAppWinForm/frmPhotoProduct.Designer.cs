namespace ProductsAppWinForm
{
    partial class frmPhotoProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhotoProduct));
            this.pbShowImageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pbShowImageProduct
            // 
            this.pbShowImageProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbShowImageProduct.ImageRotate = 0F;
            this.pbShowImageProduct.Location = new System.Drawing.Point(0, 0);
            this.pbShowImageProduct.Name = "pbShowImageProduct";
            this.pbShowImageProduct.Size = new System.Drawing.Size(356, 260);
            this.pbShowImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowImageProduct.TabIndex = 0;
            this.pbShowImageProduct.TabStop = false;
            // 
            // frmPhotoProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 260);
            this.Controls.Add(this.pbShowImageProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 299);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(372, 299);
            this.Name = "frmPhotoProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Product";
            this.Load += new System.EventHandler(this.frmPhotoProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImageProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbShowImageProduct;
    }
}