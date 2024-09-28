namespace ProductsAppWinForm
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.txtUserNameLogIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPasswordLogIn = new Guna.UI2.WinForms.Guna2TextBox();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnShowHidePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancleLogIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogIn = new Guna.UI2.WinForms.Guna2Button();
            this.pbImageLogIn = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageLogIn)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserNameLogIn
            // 
            this.txtUserNameLogIn.Animated = true;
            this.txtUserNameLogIn.BorderRadius = 10;
            this.txtUserNameLogIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameLogIn.DefaultText = "";
            this.txtUserNameLogIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserNameLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserNameLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameLogIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserNameLogIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameLogIn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameLogIn.ForeColor = System.Drawing.Color.Black;
            this.txtUserNameLogIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserNameLogIn.Location = new System.Drawing.Point(100, 253);
            this.txtUserNameLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserNameLogIn.Name = "txtUserNameLogIn";
            this.txtUserNameLogIn.PasswordChar = '\0';
            this.txtUserNameLogIn.PlaceholderText = "User Name";
            this.txtUserNameLogIn.SelectedText = "";
            this.txtUserNameLogIn.Size = new System.Drawing.Size(257, 50);
            this.txtUserNameLogIn.TabIndex = 2;
            // 
            // txtPasswordLogIn
            // 
            this.txtPasswordLogIn.Animated = true;
            this.txtPasswordLogIn.BorderRadius = 10;
            this.txtPasswordLogIn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPasswordLogIn.DefaultText = "";
            this.txtPasswordLogIn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPasswordLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordLogIn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPasswordLogIn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordLogIn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogIn.ForeColor = System.Drawing.Color.Black;
            this.txtPasswordLogIn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPasswordLogIn.Location = new System.Drawing.Point(100, 332);
            this.txtPasswordLogIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordLogIn.Name = "txtPasswordLogIn";
            this.txtPasswordLogIn.PasswordChar = '*';
            this.txtPasswordLogIn.PlaceholderText = "Password";
            this.txtPasswordLogIn.SelectedText = "";
            this.txtPasswordLogIn.Size = new System.Drawing.Size(257, 50);
            this.txtPasswordLogIn.TabIndex = 3;
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
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2HtmlLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(434, 61);
            this.guna2HtmlLabel1.TabIndex = 6;
            this.guna2HtmlLabel1.Text = "Sales Management Project";
            // 
            // btnShowHidePassword
            // 
            this.btnShowHidePassword.Animated = true;
            this.btnShowHidePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowHidePassword.BorderRadius = 10;
            this.btnShowHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHidePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowHidePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowHidePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowHidePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowHidePassword.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowHidePassword.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.btnShowHidePassword.ForeColor = System.Drawing.Color.White;
            this.btnShowHidePassword.Image = global::ProductsAppWinForm.Properties.Resources.hidden;
            this.btnShowHidePassword.Location = new System.Drawing.Point(364, 332);
            this.btnShowHidePassword.Name = "btnShowHidePassword";
            this.btnShowHidePassword.Size = new System.Drawing.Size(55, 50);
            this.btnShowHidePassword.TabIndex = 7;
            this.btnShowHidePassword.UseTransparentBackground = true;
            this.btnShowHidePassword.Click += new System.EventHandler(this.btnShowHidePassword_Click);
            // 
            // btnCancleLogIn
            // 
            this.btnCancleLogIn.Animated = true;
            this.btnCancleLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnCancleLogIn.BorderRadius = 10;
            this.btnCancleLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancleLogIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancleLogIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancleLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancleLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancleLogIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancleLogIn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleLogIn.ForeColor = System.Drawing.Color.White;
            this.btnCancleLogIn.Image = global::ProductsAppWinForm.Properties.Resources.multiply;
            this.btnCancleLogIn.Location = new System.Drawing.Point(44, 406);
            this.btnCancleLogIn.Name = "btnCancleLogIn";
            this.btnCancleLogIn.Size = new System.Drawing.Size(134, 45);
            this.btnCancleLogIn.TabIndex = 5;
            this.btnCancleLogIn.Text = "Cancle";
            this.btnCancleLogIn.UseTransparentBackground = true;
            this.btnCancleLogIn.Click += new System.EventHandler(this.btnCancleLogIn_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Animated = true;
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.BorderRadius = 10;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogIn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Image = global::ProductsAppWinForm.Properties.Resources.tick_mark;
            this.btnLogIn.Location = new System.Drawing.Point(260, 406);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(134, 45);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseTransparentBackground = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pbImageLogIn
            // 
            this.pbImageLogIn.BackColor = System.Drawing.Color.Transparent;
            this.pbImageLogIn.BorderRadius = 10;
            this.pbImageLogIn.Image = global::ProductsAppWinForm.Properties.Resources.man1;
            this.pbImageLogIn.ImageRotate = 0F;
            this.pbImageLogIn.Location = new System.Drawing.Point(118, 86);
            this.pbImageLogIn.Name = "pbImageLogIn";
            this.pbImageLogIn.Size = new System.Drawing.Size(218, 160);
            this.pbImageLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageLogIn.TabIndex = 1;
            this.pbImageLogIn.TabStop = false;
            this.pbImageLogIn.UseTransparentBackground = true;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 497);
            this.Controls.Add(this.btnShowHidePassword);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnCancleLogIn);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPasswordLogIn);
            this.Controls.Add(this.txtUserNameLogIn);
            this.Controls.Add(this.pbImageLogIn);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(472, 536);
            this.MinimumSize = new System.Drawing.Size(472, 536);
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageLogIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbImageLogIn;
        private Guna.UI2.WinForms.Guna2TextBox txtUserNameLogIn;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswordLogIn;
        private Guna.UI2.WinForms.Guna2Button btnLogIn;
        private Guna.UI2.WinForms.Guna2Button btnCancleLogIn;
        public Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnShowHidePassword;
    }
}