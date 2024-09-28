namespace ProductsAppWinForm
{
    partial class frmCreateBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateBackup));
            this.btnSeletcPathBackup = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnCancle = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.txtPathCreateBackup = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnSeletcPathBackup
            // 
            this.btnSeletcPathBackup.Animated = true;
            this.btnSeletcPathBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnSeletcPathBackup.BorderRadius = 10;
            this.btnSeletcPathBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeletcPathBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSeletcPathBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSeletcPathBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSeletcPathBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeletcPathBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSeletcPathBackup.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeletcPathBackup.ForeColor = System.Drawing.Color.White;
            this.btnSeletcPathBackup.Location = new System.Drawing.Point(11, 119);
            this.btnSeletcPathBackup.Name = "btnSeletcPathBackup";
            this.btnSeletcPathBackup.Size = new System.Drawing.Size(100, 32);
            this.btnSeletcPathBackup.TabIndex = 20;
            this.btnSeletcPathBackup.Text = "Select";
            this.btnSeletcPathBackup.UseTransparentBackground = true;
            this.btnSeletcPathBackup.Click += new System.EventHandler(this.btnSeletcPathBackup_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2HtmlLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(84, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(396, 37);
            this.guna2HtmlLabel1.TabIndex = 21;
            this.guna2HtmlLabel1.Text = "Select the course of creating the backup";
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
            this.btnCancle.Location = new System.Drawing.Point(118, 223);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(134, 45);
            this.btnCancle.TabIndex = 19;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseTransparentBackground = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Animated = true;
            this.btnBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnBackup.BorderRadius = 10;
            this.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBackup.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Image = global::ProductsAppWinForm.Properties.Resources.tick_mark;
            this.btnBackup.Location = new System.Drawing.Point(380, 223);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(134, 45);
            this.btnBackup.TabIndex = 18;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseTransparentBackground = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // txtPathCreateBackup
            // 
            this.txtPathCreateBackup.Animated = true;
            this.txtPathCreateBackup.BorderRadius = 10;
            this.txtPathCreateBackup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPathCreateBackup.DefaultText = "";
            this.txtPathCreateBackup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPathCreateBackup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPathCreateBackup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathCreateBackup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPathCreateBackup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathCreateBackup.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.txtPathCreateBackup.ForeColor = System.Drawing.Color.Black;
            this.txtPathCreateBackup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPathCreateBackup.Location = new System.Drawing.Point(118, 64);
            this.txtPathCreateBackup.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathCreateBackup.Multiline = true;
            this.txtPathCreateBackup.Name = "txtPathCreateBackup";
            this.txtPathCreateBackup.PasswordChar = '\0';
            this.txtPathCreateBackup.PlaceholderText = "";
            this.txtPathCreateBackup.ReadOnly = true;
            this.txtPathCreateBackup.SelectedText = "";
            this.txtPathCreateBackup.Size = new System.Drawing.Size(423, 152);
            this.txtPathCreateBackup.TabIndex = 23;
            // 
            // frmCreateBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 280);
            this.Controls.Add(this.txtPathCreateBackup);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnSeletcPathBackup);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnBackup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 319);
            this.MinimumSize = new System.Drawing.Size(610, 319);
            this.Name = "frmCreateBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCancle;
        private Guna.UI2.WinForms.Guna2Button btnBackup;
        private Guna.UI2.WinForms.Guna2Button btnSeletcPathBackup;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
        private Guna.UI2.WinForms.Guna2TextBox txtPathCreateBackup;
    }
}