namespace ProductsAppWinForm
{
    partial class frmRestoreBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRestoreBackup));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSeletcPathRestore = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancle = new Guna.UI2.WinForms.Guna2Button();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.txtPathRestoreBackup = new Guna.UI2.WinForms.Guna2TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2HtmlLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(105, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(385, 37);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Select the course of restore the backup";
            // 
            // btnSeletcPathRestore
            // 
            this.btnSeletcPathRestore.Animated = true;
            this.btnSeletcPathRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnSeletcPathRestore.BorderRadius = 10;
            this.btnSeletcPathRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeletcPathRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeletcPathRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeletcPathRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeletcPathRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeletcPathRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeletcPathRestore.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeletcPathRestore.ForeColor = System.Drawing.Color.White;
            this.btnSeletcPathRestore.Location = new System.Drawing.Point(12, 124);
            this.btnSeletcPathRestore.Name = "btnSeletcPathRestore";
            this.btnSeletcPathRestore.Size = new System.Drawing.Size(100, 32);
            this.btnSeletcPathRestore.TabIndex = 25;
            this.btnSeletcPathRestore.Text = "Select";
            this.btnSeletcPathRestore.UseTransparentBackground = true;
            this.btnSeletcPathRestore.Click += new System.EventHandler(this.btnSeletcPathRestore_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Animated = true;
            this.btnCancle.BackColor = System.Drawing.Color.Transparent;
            this.btnCancle.BorderRadius = 10;
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancle.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Image = global::ProductsAppWinForm.Properties.Resources.multiply;
            this.btnCancle.Location = new System.Drawing.Point(147, 223);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(134, 45);
            this.btnCancle.TabIndex = 24;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseTransparentBackground = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Animated = true;
            this.btnRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnRestore.BorderRadius = 10;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRestore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRestore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRestore.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Image = global::ProductsAppWinForm.Properties.Resources.tick_mark;
            this.btnRestore.Location = new System.Drawing.Point(395, 223);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(134, 45);
            this.btnRestore.TabIndex = 23;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseTransparentBackground = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // txtPathRestoreBackup
            // 
            this.txtPathRestoreBackup.Animated = true;
            this.txtPathRestoreBackup.BorderRadius = 10;
            this.txtPathRestoreBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPathRestoreBackup.DefaultText = "";
            this.txtPathRestoreBackup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPathRestoreBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPathRestoreBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathRestoreBackup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathRestoreBackup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathRestoreBackup.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathRestoreBackup.ForeColor = System.Drawing.Color.Black;
            this.txtPathRestoreBackup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathRestoreBackup.Location = new System.Drawing.Point(135, 64);
            this.txtPathRestoreBackup.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathRestoreBackup.Multiline = true;
            this.txtPathRestoreBackup.Name = "txtPathRestoreBackup";
            this.txtPathRestoreBackup.PasswordChar = '\0';
            this.txtPathRestoreBackup.PlaceholderText = "";
            this.txtPathRestoreBackup.ReadOnly = true;
            this.txtPathRestoreBackup.SelectedText = "";
            this.txtPathRestoreBackup.Size = new System.Drawing.Size(423, 152);
            this.txtPathRestoreBackup.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MessageDialog1
            // 
            this.MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageDialog1.Caption = null;
            this.MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.MessageDialog1.Parent = this;
            this.MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.MessageDialog1.Text = null;
            // 
            // frmRestoreBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 280);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnSeletcPathRestore);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtPathRestoreBackup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 319);
            this.MinimumSize = new System.Drawing.Size(610, 319);
            this.Name = "frmRestoreBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restore Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnSeletcPathRestore;
        private Guna.UI2.WinForms.Guna2Button btnCancle;
        private Guna.UI2.WinForms.Guna2Button btnRestore;
        private Guna.UI2.WinForms.Guna2TextBox txtPathRestoreBackup;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
    }
}