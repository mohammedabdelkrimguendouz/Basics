namespace BankSystemWinApp
{
    partial class frmWithdraw
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
            this.btnCancleWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.lblAccountBalanceWithdraw = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblAccountNumberWithdraw = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lable = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtAmountWithdraw = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnCancleWithdraw
            // 
            this.btnCancleWithdraw.Animated = true;
            this.btnCancleWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnCancleWithdraw.BorderRadius = 10;
            this.btnCancleWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancleWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancleWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancleWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancleWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancleWithdraw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancleWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancleWithdraw.ForeColor = System.Drawing.Color.Black;
            this.btnCancleWithdraw.IndicateFocus = true;
            this.btnCancleWithdraw.Location = new System.Drawing.Point(60, 220);
            this.btnCancleWithdraw.Name = "btnCancleWithdraw";
            this.btnCancleWithdraw.Size = new System.Drawing.Size(140, 39);
            this.btnCancleWithdraw.TabIndex = 30;
            this.btnCancleWithdraw.Text = "Cancle";
            this.btnCancleWithdraw.UseTransparentBackground = true;
            this.btnCancleWithdraw.Click += new System.EventHandler(this.btnCancleWithdraw_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Animated = true;
            this.btnWithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.BorderRadius = 10;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWithdraw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.Black;
            this.btnWithdraw.IndicateFocus = true;
            this.btnWithdraw.Location = new System.Drawing.Point(252, 220);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(140, 39);
            this.btnWithdraw.TabIndex = 29;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseTransparentBackground = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblAccountBalanceWithdraw
            // 
            this.lblAccountBalanceWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountBalanceWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountBalanceWithdraw.Location = new System.Drawing.Point(279, 86);
            this.lblAccountBalanceWithdraw.Name = "lblAccountBalanceWithdraw";
            this.lblAccountBalanceWithdraw.Size = new System.Drawing.Size(93, 27);
            this.lblAccountBalanceWithdraw.TabIndex = 28;
            this.lblAccountBalanceWithdraw.Text = "4536.654";
            // 
            // lblAccountNumberWithdraw
            // 
            this.lblAccountNumberWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAccountNumberWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumberWithdraw.Location = new System.Drawing.Point(279, 26);
            this.lblAccountNumberWithdraw.Name = "lblAccountNumberWithdraw";
            this.lblAccountNumberWithdraw.Size = new System.Drawing.Size(53, 27);
            this.lblAccountNumberWithdraw.TabIndex = 27;
            this.lblAccountNumberWithdraw.Text = "A111";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(77, 86);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(163, 27);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Your Balance  $ : ";
            // 
            // lable
            // 
            this.lable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(77, 26);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(174, 27);
            this.lable.TabIndex = 25;
            this.lable.Text = "Account Number : ";
            // 
            // txtAmountWithdraw
            // 
            this.txtAmountWithdraw.Animated = true;
            this.txtAmountWithdraw.BorderRadius = 12;
            this.txtAmountWithdraw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountWithdraw.DefaultText = "";
            this.txtAmountWithdraw.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmountWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmountWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountWithdraw.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmountWithdraw.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAmountWithdraw.ForeColor = System.Drawing.Color.Black;
            this.txtAmountWithdraw.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAmountWithdraw.Location = new System.Drawing.Point(99, 135);
            this.txtAmountWithdraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmountWithdraw.Name = "txtAmountWithdraw";
            this.txtAmountWithdraw.PasswordChar = '\0';
            this.txtAmountWithdraw.PlaceholderText = "Amount Withdraw";
            this.txtAmountWithdraw.SelectedText = "";
            this.txtAmountWithdraw.Size = new System.Drawing.Size(257, 50);
            this.txtAmountWithdraw.TabIndex = 24;
            // 
            // frmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 284);
            this.Controls.Add(this.btnCancleWithdraw);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblAccountBalanceWithdraw);
            this.Controls.Add(this.lblAccountNumberWithdraw);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.txtAmountWithdraw);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(468, 323);
            this.MinimumSize = new System.Drawing.Size(468, 323);
            this.Name = "frmWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.frmWithdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancleWithdraw;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccountBalanceWithdraw;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccountNumberWithdraw;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lable;
        private Guna.UI2.WinForms.Guna2TextBox txtAmountWithdraw;
    }
}