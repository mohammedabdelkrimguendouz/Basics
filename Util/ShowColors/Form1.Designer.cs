namespace ShowColors
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.plColor = new Guna.UI2.WinForms.Guna2Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.nudAlpha = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnChooseColor = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nudRed = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudGreen = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudBlue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tbRedColor = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbGreenColor = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbBlueColor = new Guna.UI2.WinForms.Guna2TrackBar();
            this.tbAlpha = new Guna.UI2.WinForms.Guna2TrackBar();
            this.btnCopy = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinized = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.lblColorHex = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Silver;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(179, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(171, 34);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Color Display";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plColor
            // 
            this.plColor.BackColor = System.Drawing.Color.White;
            this.plColor.BorderColor = System.Drawing.Color.Silver;
            this.plColor.BorderRadius = 4;
            this.plColor.BorderThickness = 2;
            this.plColor.Location = new System.Drawing.Point(49, 69);
            this.plColor.Name = "plColor";
            this.plColor.Size = new System.Drawing.Size(359, 136);
            this.plColor.TabIndex = 3;
            // 
            // nudAlpha
            // 
            this.nudAlpha.AutoRoundedCorners = true;
            this.nudAlpha.BackColor = System.Drawing.Color.Transparent;
            this.nudAlpha.BorderColor = System.Drawing.Color.Silver;
            this.nudAlpha.BorderRadius = 10;
            this.nudAlpha.BorderThickness = 2;
            this.nudAlpha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudAlpha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudAlpha.Location = new System.Drawing.Point(162, 237);
            this.nudAlpha.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAlpha.Name = "nudAlpha";
            this.nudAlpha.Size = new System.Drawing.Size(68, 36);
            this.nudAlpha.TabIndex = 4;
            this.nudAlpha.UseTransparentBackground = true;
            this.nudAlpha.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudAlpha.ValueChanged += new System.EventHandler(this.nudChangeColor);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Animated = true;
            this.btnChooseColor.AutoRoundedCorners = true;
            this.btnChooseColor.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseColor.BorderColor = System.Drawing.Color.Silver;
            this.btnChooseColor.BorderRadius = 12;
            this.btnChooseColor.BorderThickness = 2;
            this.btnChooseColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseColor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseColor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseColor.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseColor.Font = new System.Drawing.Font("Simplified Arabic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChooseColor.ForeColor = System.Drawing.Color.White;
            this.btnChooseColor.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnChooseColor.Location = new System.Drawing.Point(435, 112);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(115, 45);
            this.btnChooseColor.TabIndex = 6;
            this.btnChooseColor.Text = "Choose Color";
            this.btnChooseColor.UseTransparentBackground = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 235);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(114, 34);
            this.guna2HtmlLabel2.TabIndex = 7;
            this.guna2HtmlLabel2.Text = "Color ARGB : ";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Simplified Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(15, 287);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(97, 34);
            this.guna2HtmlLabel3.TabIndex = 8;
            this.guna2HtmlLabel3.Text = "Color Hex : ";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(138, 240);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(13, 30);
            this.guna2HtmlLabel5.TabIndex = 10;
            this.guna2HtmlLabel5.Text = "A";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(241, 240);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(13, 30);
            this.guna2HtmlLabel6.TabIndex = 12;
            this.guna2HtmlLabel6.Text = "R";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(344, 240);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(14, 30);
            this.guna2HtmlLabel7.TabIndex = 14;
            this.guna2HtmlLabel7.Text = "G";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(448, 240);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(13, 30);
            this.guna2HtmlLabel8.TabIndex = 16;
            this.guna2HtmlLabel8.Text = "B";
            // 
            // nudRed
            // 
            this.nudRed.AutoRoundedCorners = true;
            this.nudRed.BackColor = System.Drawing.Color.Transparent;
            this.nudRed.BorderColor = System.Drawing.Color.Silver;
            this.nudRed.BorderRadius = 10;
            this.nudRed.BorderThickness = 2;
            this.nudRed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudRed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudRed.Location = new System.Drawing.Point(265, 237);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(68, 36);
            this.nudRed.TabIndex = 17;
            this.nudRed.UseTransparentBackground = true;
            this.nudRed.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.ValueChanged += new System.EventHandler(this.nudChangeColor);
            // 
            // nudGreen
            // 
            this.nudGreen.AutoRoundedCorners = true;
            this.nudGreen.BackColor = System.Drawing.Color.Transparent;
            this.nudGreen.BorderColor = System.Drawing.Color.Silver;
            this.nudGreen.BorderRadius = 10;
            this.nudGreen.BorderThickness = 2;
            this.nudGreen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudGreen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudGreen.Location = new System.Drawing.Point(369, 237);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(68, 36);
            this.nudGreen.TabIndex = 18;
            this.nudGreen.UseTransparentBackground = true;
            this.nudGreen.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.ValueChanged += new System.EventHandler(this.nudChangeColor);
            // 
            // nudBlue
            // 
            this.nudBlue.AutoRoundedCorners = true;
            this.nudBlue.BackColor = System.Drawing.Color.Transparent;
            this.nudBlue.BorderColor = System.Drawing.Color.Silver;
            this.nudBlue.BorderRadius = 10;
            this.nudBlue.BorderThickness = 2;
            this.nudBlue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudBlue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudBlue.Location = new System.Drawing.Point(472, 237);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(68, 36);
            this.nudBlue.TabIndex = 19;
            this.nudBlue.UseTransparentBackground = true;
            this.nudBlue.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.ValueChanged += new System.EventHandler(this.nudChangeColor);
            // 
            // tbRedColor
            // 
            this.tbRedColor.DisplayFocus = true;
            this.tbRedColor.HoverState.FillColor = System.Drawing.Color.Silver;
            this.tbRedColor.IndicateFocus = true;
            this.tbRedColor.Location = new System.Drawing.Point(27, 373);
            this.tbRedColor.Maximum = 255;
            this.tbRedColor.Name = "tbRedColor";
            this.tbRedColor.Size = new System.Drawing.Size(500, 30);
            this.tbRedColor.SmallChange = 2;
            this.tbRedColor.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tbRedColor.TabIndex = 20;
            this.tbRedColor.ThumbColor = System.Drawing.Color.Red;
            this.tbRedColor.ValueChanged += new System.EventHandler(this.tbChangeColor);
            // 
            // tbGreenColor
            // 
            this.tbGreenColor.DisplayFocus = true;
            this.tbGreenColor.HoverState.FillColor = System.Drawing.Color.Silver;
            this.tbGreenColor.IndicateFocus = true;
            this.tbGreenColor.Location = new System.Drawing.Point(27, 421);
            this.tbGreenColor.Maximum = 255;
            this.tbGreenColor.Name = "tbGreenColor";
            this.tbGreenColor.Size = new System.Drawing.Size(500, 30);
            this.tbGreenColor.SmallChange = 2;
            this.tbGreenColor.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tbGreenColor.TabIndex = 21;
            this.tbGreenColor.ThumbColor = System.Drawing.Color.Lime;
            this.tbGreenColor.ValueChanged += new System.EventHandler(this.tbChangeColor);
            // 
            // tbBlueColor
            // 
            this.tbBlueColor.DisplayFocus = true;
            this.tbBlueColor.HoverState.FillColor = System.Drawing.Color.Silver;
            this.tbBlueColor.IndicateFocus = true;
            this.tbBlueColor.Location = new System.Drawing.Point(27, 469);
            this.tbBlueColor.Maximum = 255;
            this.tbBlueColor.Name = "tbBlueColor";
            this.tbBlueColor.Size = new System.Drawing.Size(500, 30);
            this.tbBlueColor.SmallChange = 2;
            this.tbBlueColor.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tbBlueColor.TabIndex = 22;
            this.tbBlueColor.ThumbColor = System.Drawing.Color.Blue;
            this.tbBlueColor.ValueChanged += new System.EventHandler(this.tbChangeColor);
            // 
            // tbAlpha
            // 
            this.tbAlpha.DisplayFocus = true;
            this.tbAlpha.HoverState.FillColor = System.Drawing.Color.Silver;
            this.tbAlpha.IndicateFocus = true;
            this.tbAlpha.Location = new System.Drawing.Point(27, 325);
            this.tbAlpha.Maximum = 255;
            this.tbAlpha.Name = "tbAlpha";
            this.tbAlpha.Size = new System.Drawing.Size(500, 30);
            this.tbAlpha.SmallChange = 2;
            this.tbAlpha.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.tbAlpha.TabIndex = 23;
            this.tbAlpha.ThumbColor = System.Drawing.Color.Gray;
            this.tbAlpha.ValueChanged += new System.EventHandler(this.tbChangeColor);
            // 
            // btnCopy
            // 
            this.btnCopy.Animated = true;
            this.btnCopy.AutoRoundedCorners = true;
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.BorderColor = System.Drawing.Color.Silver;
            this.btnCopy.BorderRadius = 10;
            this.btnCopy.BorderThickness = 2;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Image = global::ShowColors.Properties.Resources.paper_7603798;
            this.btnCopy.Location = new System.Drawing.Point(241, 291);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(47, 31);
            this.btnCopy.TabIndex = 24;
            this.btnCopy.UseTransparentBackground = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnMinized
            // 
            this.btnMinized.Animated = true;
            this.btnMinized.AutoRoundedCorners = true;
            this.btnMinized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinized.BorderRadius = 20;
            this.btnMinized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinized.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinized.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinized.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinized.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinized.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinized.ForeColor = System.Drawing.Color.White;
            this.btnMinized.Image = global::ShowColors.Properties.Resources.icons8_minimize_window_100__1_;
            this.btnMinized.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMinized.Location = new System.Drawing.Point(474, 1);
            this.btnMinized.Name = "btnMinized";
            this.btnMinized.Size = new System.Drawing.Size(42, 45);
            this.btnMinized.TabIndex = 1;
            this.btnMinized.UseTransparentBackground = true;
            this.btnMinized.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.AutoRoundedCorners = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderRadius = 20;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::ShowColors.Properties.Resources.icons8_close_window_100;
            this.btnClose.ImageSize = new System.Drawing.Size(50, 50);
            this.btnClose.Location = new System.Drawing.Point(532, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseTransparentBackground = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblColorHex
            // 
            this.lblColorHex.BackColor = System.Drawing.Color.Transparent;
            this.lblColorHex.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorHex.Location = new System.Drawing.Point(118, 292);
            this.lblColorHex.Name = "lblColorHex";
            this.lblColorHex.Size = new System.Drawing.Size(3, 2);
            this.lblColorHex.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(576, 538);
            this.ControlBox = false;
            this.Controls.Add(this.lblColorHex);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbAlpha);
            this.Controls.Add(this.tbBlueColor);
            this.Controls.Add(this.tbGreenColor);
            this.Controls.Add(this.tbRedColor);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.nudAlpha);
            this.Controls.Add(this.plColor);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnMinized);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnMinized;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel plColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudAlpha;
        private Guna.UI2.WinForms.Guna2GradientButton btnChooseColor;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudRed;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudGreen;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudBlue;
        private Guna.UI2.WinForms.Guna2TrackBar tbRedColor;
        private Guna.UI2.WinForms.Guna2TrackBar tbGreenColor;
        private Guna.UI2.WinForms.Guna2TrackBar tbBlueColor;
        private Guna.UI2.WinForms.Guna2TrackBar tbAlpha;
        private Guna.UI2.WinForms.Guna2Button btnCopy;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblColorHex;
    }
}

