namespace ProductsAppWinForm
{
    partial class frmPhotoCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhotoCustomer));
            this.pbImageCustomer = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImageCustomer
            // 
            this.pbImageCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImageCustomer.ImageRotate = 0F;
            this.pbImageCustomer.Location = new System.Drawing.Point(0, 0);
            this.pbImageCustomer.Name = "pbImageCustomer";
            this.pbImageCustomer.Size = new System.Drawing.Size(356, 260);
            this.pbImageCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageCustomer.TabIndex = 0;
            this.pbImageCustomer.TabStop = false;
            // 
            // frmPhotoCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 260);
            this.Controls.Add(this.pbImageCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(372, 299);
            this.MinimumSize = new System.Drawing.Size(372, 299);
            this.Name = "frmPhotoCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Customer";
            this.Load += new System.EventHandler(this.frmPhotoCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbImageCustomer;
    }
}