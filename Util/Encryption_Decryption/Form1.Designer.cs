namespace Encryption_Decryption
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plDecryption = new Guna.UI2.WinForms.Guna2Panel();
            this.cbxDecryption = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCopyOriginalText = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveOriginalText = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOriginalTextAfterDecryption = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetDecryption = new Guna.UI2.WinForms.Guna2Button();
            this.btnDecryption = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenFileDecrypted = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTextEncrypted = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.plEncryption = new Guna.UI2.WinForms.Guna2Panel();
            this.cbxEncryption = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCopyEncryptedText = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveEncryptedText = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTextEncryptedAfterEncryption = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnResetEncryption = new Guna.UI2.WinForms.Guna2Button();
            this.btnEncryption = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenFileOriginalText = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtOriginalText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.MessageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.tsBackGroundColor = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.plDecryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.plEncryption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // plDecryption
            // 
            this.plDecryption.AutoSize = true;
            this.plDecryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.plDecryption.BorderRadius = 10;
            this.plDecryption.BorderThickness = 2;
            this.plDecryption.Controls.Add(this.cbxDecryption);
            this.plDecryption.Controls.Add(this.guna2PictureBox2);
            this.plDecryption.Controls.Add(this.btnCopyOriginalText);
            this.plDecryption.Controls.Add(this.btnSaveOriginalText);
            this.plDecryption.Controls.Add(this.guna2HtmlLabel3);
            this.plDecryption.Controls.Add(this.txtOriginalTextAfterDecryption);
            this.plDecryption.Controls.Add(this.btnResetDecryption);
            this.plDecryption.Controls.Add(this.btnDecryption);
            this.plDecryption.Controls.Add(this.btnOpenFileDecrypted);
            this.plDecryption.Controls.Add(this.guna2HtmlLabel2);
            this.plDecryption.Controls.Add(this.txtTextEncrypted);
            this.plDecryption.Controls.Add(this.guna2HtmlLabel1);
            this.plDecryption.Location = new System.Drawing.Point(582, 82);
            this.plDecryption.Name = "plDecryption";
            this.plDecryption.Size = new System.Drawing.Size(510, 516);
            this.plDecryption.TabIndex = 0;
            // 
            // cbxDecryption
            // 
            this.cbxDecryption.BackColor = System.Drawing.Color.Transparent;
            this.cbxDecryption.BorderColor = System.Drawing.Color.Silver;
            this.cbxDecryption.BorderRadius = 10;
            this.cbxDecryption.BorderThickness = 2;
            this.cbxDecryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxDecryption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxDecryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDecryption.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDecryption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxDecryption.Font = new System.Drawing.Font("MV Boli", 12F);
            this.cbxDecryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxDecryption.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxDecryption.ItemHeight = 30;
            this.cbxDecryption.Items.AddRange(new object[] {
            "TextArabic",
            "TextEnglish"});
            this.cbxDecryption.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxDecryption.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.cbxDecryption.Location = new System.Drawing.Point(347, 57);
            this.cbxDecryption.Name = "cbxDecryption";
            this.cbxDecryption.Size = new System.Drawing.Size(144, 36);
            this.cbxDecryption.StartIndex = 1;
            this.cbxDecryption.TabIndex = 7;
            this.cbxDecryption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbxDecryption.SelectedIndexChanged += new System.EventHandler(this.cbxDecryption_SelectedIndexChanged);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BorderRadius = 2;
            this.guna2PictureBox2.Image = global::Encryption_Decryption.Properties.Resources.decryption;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(110, 11);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(50, 40);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 10;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // btnCopyOriginalText
            // 
            this.btnCopyOriginalText.Animated = true;
            this.btnCopyOriginalText.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyOriginalText.BorderColor = System.Drawing.Color.Silver;
            this.btnCopyOriginalText.BorderRadius = 10;
            this.btnCopyOriginalText.BorderThickness = 2;
            this.btnCopyOriginalText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyOriginalText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyOriginalText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyOriginalText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopyOriginalText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopyOriginalText.Enabled = false;
            this.btnCopyOriginalText.FillColor = System.Drawing.Color.Gold;
            this.btnCopyOriginalText.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.btnCopyOriginalText.ForeColor = System.Drawing.Color.Black;
            this.btnCopyOriginalText.Image = global::Encryption_Decryption.Properties.Resources.icons8_copy_100;
            this.btnCopyOriginalText.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCopyOriginalText.Location = new System.Drawing.Point(395, 423);
            this.btnCopyOriginalText.Name = "btnCopyOriginalText";
            this.btnCopyOriginalText.Size = new System.Drawing.Size(96, 39);
            this.btnCopyOriginalText.TabIndex = 13;
            this.btnCopyOriginalText.Text = "Copy";
            this.btnCopyOriginalText.UseTransparentBackground = true;
            this.btnCopyOriginalText.Click += new System.EventHandler(this.btnCopyOriginalText_Click);
            // 
            // btnSaveOriginalText
            // 
            this.btnSaveOriginalText.Animated = true;
            this.btnSaveOriginalText.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveOriginalText.BorderColor = System.Drawing.Color.Silver;
            this.btnSaveOriginalText.BorderRadius = 10;
            this.btnSaveOriginalText.BorderThickness = 2;
            this.btnSaveOriginalText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveOriginalText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveOriginalText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveOriginalText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveOriginalText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveOriginalText.Enabled = false;
            this.btnSaveOriginalText.FillColor = System.Drawing.Color.Gold;
            this.btnSaveOriginalText.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.btnSaveOriginalText.ForeColor = System.Drawing.Color.Black;
            this.btnSaveOriginalText.Image = global::Encryption_Decryption.Properties.Resources.icons8_save_100;
            this.btnSaveOriginalText.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveOriginalText.Location = new System.Drawing.Point(395, 378);
            this.btnSaveOriginalText.Name = "btnSaveOriginalText";
            this.btnSaveOriginalText.Size = new System.Drawing.Size(96, 39);
            this.btnSaveOriginalText.TabIndex = 12;
            this.btnSaveOriginalText.Text = "Save";
            this.btnSaveOriginalText.UseTransparentBackground = true;
            this.btnSaveOriginalText.Click += new System.EventHandler(this.btnSaveOriginalText_Click);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(19, 312);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(161, 30);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.TabStop = false;
            this.guna2HtmlLabel3.Text = "Original Text :";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOriginalTextAfterDecryption
            // 
            this.txtOriginalTextAfterDecryption.Animated = true;
            this.txtOriginalTextAfterDecryption.AutoScrollMargin = new System.Drawing.Size(10, 1);
            this.txtOriginalTextAfterDecryption.BorderRadius = 11;
            this.txtOriginalTextAfterDecryption.BorderThickness = 2;
            this.txtOriginalTextAfterDecryption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOriginalTextAfterDecryption.DefaultText = "";
            this.txtOriginalTextAfterDecryption.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOriginalTextAfterDecryption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOriginalTextAfterDecryption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOriginalTextAfterDecryption.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOriginalTextAfterDecryption.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.txtOriginalTextAfterDecryption.Font = new System.Drawing.Font("MV Boli", 11.25F);
            this.txtOriginalTextAfterDecryption.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtOriginalTextAfterDecryption.Location = new System.Drawing.Point(14, 350);
            this.txtOriginalTextAfterDecryption.Margin = new System.Windows.Forms.Padding(5);
            this.txtOriginalTextAfterDecryption.Multiline = true;
            this.txtOriginalTextAfterDecryption.Name = "txtOriginalTextAfterDecryption";
            this.txtOriginalTextAfterDecryption.PasswordChar = '\0';
            this.txtOriginalTextAfterDecryption.PlaceholderText = "Original Text After Decryption";
            this.txtOriginalTextAfterDecryption.ReadOnly = true;
            this.txtOriginalTextAfterDecryption.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginalTextAfterDecryption.SelectedText = "";
            this.txtOriginalTextAfterDecryption.Size = new System.Drawing.Size(368, 133);
            this.txtOriginalTextAfterDecryption.TabIndex = 6;
            this.txtOriginalTextAfterDecryption.TabStop = false;
            // 
            // btnResetDecryption
            // 
            this.btnResetDecryption.Animated = true;
            this.btnResetDecryption.BackColor = System.Drawing.Color.Transparent;
            this.btnResetDecryption.BorderColor = System.Drawing.Color.Silver;
            this.btnResetDecryption.BorderRadius = 10;
            this.btnResetDecryption.BorderThickness = 2;
            this.btnResetDecryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetDecryption.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetDecryption.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetDecryption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetDecryption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetDecryption.FillColor = System.Drawing.Color.Red;
            this.btnResetDecryption.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.btnResetDecryption.ForeColor = System.Drawing.Color.Black;
            this.btnResetDecryption.Image = global::Encryption_Decryption.Properties.Resources.icons8_reset_48;
            this.btnResetDecryption.ImageSize = new System.Drawing.Size(30, 30);
            this.btnResetDecryption.Location = new System.Drawing.Point(220, 245);
            this.btnResetDecryption.Name = "btnResetDecryption";
            this.btnResetDecryption.Size = new System.Drawing.Size(133, 39);
            this.btnResetDecryption.TabIndex = 11;
            this.btnResetDecryption.Text = "Reset";
            this.btnResetDecryption.UseTransparentBackground = true;
            this.btnResetDecryption.Click += new System.EventHandler(this.btnResetDecryption_Click);
            // 
            // btnDecryption
            // 
            this.btnDecryption.Animated = true;
            this.btnDecryption.BackColor = System.Drawing.Color.Transparent;
            this.btnDecryption.BorderColor = System.Drawing.Color.Silver;
            this.btnDecryption.BorderRadius = 10;
            this.btnDecryption.BorderThickness = 2;
            this.btnDecryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecryption.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecryption.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecryption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecryption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecryption.FillColor = System.Drawing.Color.Blue;
            this.btnDecryption.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryption.ForeColor = System.Drawing.Color.Black;
            this.btnDecryption.Image = global::Encryption_Decryption.Properties.Resources.decryption;
            this.btnDecryption.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDecryption.Location = new System.Drawing.Point(53, 245);
            this.btnDecryption.Name = "btnDecryption";
            this.btnDecryption.Size = new System.Drawing.Size(133, 39);
            this.btnDecryption.TabIndex = 10;
            this.btnDecryption.Text = "Decryption";
            this.btnDecryption.UseTransparentBackground = true;
            this.btnDecryption.Click += new System.EventHandler(this.btnDecryption_Click);
            // 
            // btnOpenFileDecrypted
            // 
            this.btnOpenFileDecrypted.Animated = true;
            this.btnOpenFileDecrypted.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFileDecrypted.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenFileDecrypted.BorderRadius = 10;
            this.btnOpenFileDecrypted.BorderThickness = 2;
            this.btnOpenFileDecrypted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFileDecrypted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileDecrypted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileDecrypted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFileDecrypted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFileDecrypted.FillColor = System.Drawing.Color.Gold;
            this.btnOpenFileDecrypted.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.btnOpenFileDecrypted.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFileDecrypted.Image = global::Encryption_Decryption.Properties.Resources.icons8_open_file_100;
            this.btnOpenFileDecrypted.ImageSize = new System.Drawing.Size(30, 30);
            this.btnOpenFileDecrypted.Location = new System.Drawing.Point(402, 137);
            this.btnOpenFileDecrypted.Name = "btnOpenFileDecrypted";
            this.btnOpenFileDecrypted.Size = new System.Drawing.Size(96, 39);
            this.btnOpenFileDecrypted.TabIndex = 9;
            this.btnOpenFileDecrypted.Text = "Open";
            this.btnOpenFileDecrypted.UseTransparentBackground = true;
            this.btnOpenFileDecrypted.Click += new System.EventHandler(this.btnOpenFileDecrypted_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(19, 57);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(189, 30);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.TabStop = false;
            this.guna2HtmlLabel2.Text = "Text Decrypted :";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTextEncrypted
            // 
            this.txtTextEncrypted.Animated = true;
            this.txtTextEncrypted.AutoScrollMargin = new System.Drawing.Size(10, 1);
            this.txtTextEncrypted.BorderRadius = 11;
            this.txtTextEncrypted.BorderThickness = 2;
            this.txtTextEncrypted.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTextEncrypted.DefaultText = "";
            this.txtTextEncrypted.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTextEncrypted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTextEncrypted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTextEncrypted.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTextEncrypted.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTextEncrypted.Font = new System.Drawing.Font("MV Boli", 11.25F);
            this.txtTextEncrypted.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTextEncrypted.Location = new System.Drawing.Point(14, 95);
            this.txtTextEncrypted.Margin = new System.Windows.Forms.Padding(5);
            this.txtTextEncrypted.Multiline = true;
            this.txtTextEncrypted.Name = "txtTextEncrypted";
            this.txtTextEncrypted.PasswordChar = '\0';
            this.txtTextEncrypted.PlaceholderText = "Enter Text Decrypted Or Choose File Decrypted";
            this.txtTextEncrypted.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextEncrypted.SelectedText = "";
            this.txtTextEncrypted.Size = new System.Drawing.Size(380, 133);
            this.txtTextEncrypted.TabIndex = 8;
            this.txtTextEncrypted.TextChanged += new System.EventHandler(this.txtTextEncrypted_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(166, 10);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(187, 48);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Decryption";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plEncryption
            // 
            this.plEncryption.AutoSize = true;
            this.plEncryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.plEncryption.BorderRadius = 10;
            this.plEncryption.BorderThickness = 2;
            this.plEncryption.Controls.Add(this.cbxEncryption);
            this.plEncryption.Controls.Add(this.guna2PictureBox1);
            this.plEncryption.Controls.Add(this.btnCopyEncryptedText);
            this.plEncryption.Controls.Add(this.btnSaveEncryptedText);
            this.plEncryption.Controls.Add(this.guna2HtmlLabel4);
            this.plEncryption.Controls.Add(this.txtTextEncryptedAfterEncryption);
            this.plEncryption.Controls.Add(this.btnResetEncryption);
            this.plEncryption.Controls.Add(this.btnEncryption);
            this.plEncryption.Controls.Add(this.btnOpenFileOriginalText);
            this.plEncryption.Controls.Add(this.guna2HtmlLabel5);
            this.plEncryption.Controls.Add(this.txtOriginalText);
            this.plEncryption.Controls.Add(this.guna2HtmlLabel6);
            this.plEncryption.Location = new System.Drawing.Point(12, 82);
            this.plEncryption.Name = "plEncryption";
            this.plEncryption.Size = new System.Drawing.Size(510, 516);
            this.plEncryption.TabIndex = 1;
            // 
            // cbxEncryption
            // 
            this.cbxEncryption.BackColor = System.Drawing.Color.Transparent;
            this.cbxEncryption.BorderColor = System.Drawing.Color.Silver;
            this.cbxEncryption.BorderRadius = 10;
            this.cbxEncryption.BorderThickness = 2;
            this.cbxEncryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxEncryption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxEncryption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEncryption.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEncryption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxEncryption.Font = new System.Drawing.Font("MV Boli", 12F);
            this.cbxEncryption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxEncryption.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxEncryption.ItemHeight = 30;
            this.cbxEncryption.Items.AddRange(new object[] {
            "TextArabic",
            "TextEnglish"});
            this.cbxEncryption.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxEncryption.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Gray;
            this.cbxEncryption.Location = new System.Drawing.Point(347, 57);
            this.cbxEncryption.Name = "cbxEncryption";
            this.cbxEncryption.Size = new System.Drawing.Size(144, 36);
            this.cbxEncryption.StartIndex = 1;
            this.cbxEncryption.TabIndex = 0;
            this.cbxEncryption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbxEncryption.SelectedIndexChanged += new System.EventHandler(this.cbxEncryption_SelectedIndexChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 2;
            this.guna2PictureBox1.Image = global::Encryption_Decryption.Properties.Resources.icons8_encryption_48__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(110, 11);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(50, 40);
            this.guna2PictureBox1.TabIndex = 3;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btnCopyEncryptedText
            // 
            this.btnCopyEncryptedText.Animated = true;
            this.btnCopyEncryptedText.BackColor = System.Drawing.Color.Transparent;
            this.btnCopyEncryptedText.BorderColor = System.Drawing.Color.Silver;
            this.btnCopyEncryptedText.BorderRadius = 10;
            this.btnCopyEncryptedText.BorderThickness = 2;
            this.btnCopyEncryptedText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopyEncryptedText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyEncryptedText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopyEncryptedText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopyEncryptedText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopyEncryptedText.Enabled = false;
            this.btnCopyEncryptedText.FillColor = System.Drawing.Color.Gold;
            this.btnCopyEncryptedText.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.btnCopyEncryptedText.ForeColor = System.Drawing.Color.Black;
            this.btnCopyEncryptedText.Image = global::Encryption_Decryption.Properties.Resources.icons8_copy_100;
            this.btnCopyEncryptedText.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCopyEncryptedText.Location = new System.Drawing.Point(395, 423);
            this.btnCopyEncryptedText.Name = "btnCopyEncryptedText";
            this.btnCopyEncryptedText.Size = new System.Drawing.Size(96, 39);
            this.btnCopyEncryptedText.TabIndex = 6;
            this.btnCopyEncryptedText.Text = "Copy";
            this.btnCopyEncryptedText.UseTransparentBackground = true;
            this.btnCopyEncryptedText.Click += new System.EventHandler(this.btnCopyEncryptedText_Click);
            // 
            // btnSaveEncryptedText
            // 
            this.btnSaveEncryptedText.Animated = true;
            this.btnSaveEncryptedText.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveEncryptedText.BorderColor = System.Drawing.Color.Silver;
            this.btnSaveEncryptedText.BorderRadius = 10;
            this.btnSaveEncryptedText.BorderThickness = 2;
            this.btnSaveEncryptedText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEncryptedText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEncryptedText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveEncryptedText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveEncryptedText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveEncryptedText.Enabled = false;
            this.btnSaveEncryptedText.FillColor = System.Drawing.Color.Gold;
            this.btnSaveEncryptedText.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.btnSaveEncryptedText.ForeColor = System.Drawing.Color.Black;
            this.btnSaveEncryptedText.Image = global::Encryption_Decryption.Properties.Resources.icons8_save_100;
            this.btnSaveEncryptedText.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaveEncryptedText.Location = new System.Drawing.Point(395, 378);
            this.btnSaveEncryptedText.Name = "btnSaveEncryptedText";
            this.btnSaveEncryptedText.Size = new System.Drawing.Size(96, 39);
            this.btnSaveEncryptedText.TabIndex = 5;
            this.btnSaveEncryptedText.Text = "Save";
            this.btnSaveEncryptedText.UseTransparentBackground = true;
            this.btnSaveEncryptedText.Click += new System.EventHandler(this.btnSaveEncryptedText_Click);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(19, 312);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(189, 30);
            this.guna2HtmlLabel4.TabIndex = 7;
            this.guna2HtmlLabel4.TabStop = false;
            this.guna2HtmlLabel4.Text = "Text Decrypted :";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTextEncryptedAfterEncryption
            // 
            this.txtTextEncryptedAfterEncryption.Animated = true;
            this.txtTextEncryptedAfterEncryption.AutoScrollMargin = new System.Drawing.Size(10, 1);
            this.txtTextEncryptedAfterEncryption.BorderRadius = 11;
            this.txtTextEncryptedAfterEncryption.BorderThickness = 2;
            this.txtTextEncryptedAfterEncryption.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTextEncryptedAfterEncryption.DefaultText = "";
            this.txtTextEncryptedAfterEncryption.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTextEncryptedAfterEncryption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTextEncryptedAfterEncryption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTextEncryptedAfterEncryption.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTextEncryptedAfterEncryption.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.txtTextEncryptedAfterEncryption.Font = new System.Drawing.Font("MV Boli", 11.25F);
            this.txtTextEncryptedAfterEncryption.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtTextEncryptedAfterEncryption.Location = new System.Drawing.Point(19, 350);
            this.txtTextEncryptedAfterEncryption.Margin = new System.Windows.Forms.Padding(5);
            this.txtTextEncryptedAfterEncryption.Multiline = true;
            this.txtTextEncryptedAfterEncryption.Name = "txtTextEncryptedAfterEncryption";
            this.txtTextEncryptedAfterEncryption.PasswordChar = '\0';
            this.txtTextEncryptedAfterEncryption.PlaceholderText = "Original Text After Encryption";
            this.txtTextEncryptedAfterEncryption.ReadOnly = true;
            this.txtTextEncryptedAfterEncryption.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTextEncryptedAfterEncryption.SelectedText = "";
            this.txtTextEncryptedAfterEncryption.Size = new System.Drawing.Size(368, 133);
            this.txtTextEncryptedAfterEncryption.TabIndex = 6;
            this.txtTextEncryptedAfterEncryption.TabStop = false;
            // 
            // btnResetEncryption
            // 
            this.btnResetEncryption.Animated = true;
            this.btnResetEncryption.BackColor = System.Drawing.Color.Transparent;
            this.btnResetEncryption.BorderColor = System.Drawing.Color.Silver;
            this.btnResetEncryption.BorderRadius = 10;
            this.btnResetEncryption.BorderThickness = 2;
            this.btnResetEncryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetEncryption.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnResetEncryption.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnResetEncryption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnResetEncryption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnResetEncryption.FillColor = System.Drawing.Color.Red;
            this.btnResetEncryption.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.btnResetEncryption.ForeColor = System.Drawing.Color.Black;
            this.btnResetEncryption.Image = global::Encryption_Decryption.Properties.Resources.icons8_reset_48;
            this.btnResetEncryption.ImageSize = new System.Drawing.Size(30, 30);
            this.btnResetEncryption.Location = new System.Drawing.Point(220, 245);
            this.btnResetEncryption.Name = "btnResetEncryption";
            this.btnResetEncryption.Size = new System.Drawing.Size(133, 39);
            this.btnResetEncryption.TabIndex = 4;
            this.btnResetEncryption.Text = "Reset";
            this.btnResetEncryption.UseTransparentBackground = true;
            this.btnResetEncryption.Click += new System.EventHandler(this.btnResetEncryption_Click);
            // 
            // btnEncryption
            // 
            this.btnEncryption.Animated = true;
            this.btnEncryption.BackColor = System.Drawing.Color.Transparent;
            this.btnEncryption.BorderColor = System.Drawing.Color.Silver;
            this.btnEncryption.BorderRadius = 10;
            this.btnEncryption.BorderThickness = 2;
            this.btnEncryption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncryption.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncryption.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncryption.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncryption.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncryption.FillColor = System.Drawing.Color.Blue;
            this.btnEncryption.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryption.ForeColor = System.Drawing.Color.Black;
            this.btnEncryption.Image = global::Encryption_Decryption.Properties.Resources.icons8_encryption_48__1_;
            this.btnEncryption.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEncryption.Location = new System.Drawing.Point(53, 245);
            this.btnEncryption.Name = "btnEncryption";
            this.btnEncryption.Size = new System.Drawing.Size(133, 39);
            this.btnEncryption.TabIndex = 3;
            this.btnEncryption.Text = "Encryption";
            this.btnEncryption.UseTransparentBackground = true;
            this.btnEncryption.Click += new System.EventHandler(this.btnEncryption_Click);
            // 
            // btnOpenFileOriginalText
            // 
            this.btnOpenFileOriginalText.Animated = true;
            this.btnOpenFileOriginalText.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenFileOriginalText.BorderColor = System.Drawing.Color.Silver;
            this.btnOpenFileOriginalText.BorderRadius = 10;
            this.btnOpenFileOriginalText.BorderThickness = 2;
            this.btnOpenFileOriginalText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenFileOriginalText.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileOriginalText.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenFileOriginalText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenFileOriginalText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenFileOriginalText.FillColor = System.Drawing.Color.Gold;
            this.btnOpenFileOriginalText.Font = new System.Drawing.Font("MV Boli", 14.25F);
            this.btnOpenFileOriginalText.ForeColor = System.Drawing.Color.Black;
            this.btnOpenFileOriginalText.Image = global::Encryption_Decryption.Properties.Resources.icons8_open_file_100;
            this.btnOpenFileOriginalText.ImageSize = new System.Drawing.Size(30, 30);
            this.btnOpenFileOriginalText.Location = new System.Drawing.Point(411, 137);
            this.btnOpenFileOriginalText.Name = "btnOpenFileOriginalText";
            this.btnOpenFileOriginalText.Size = new System.Drawing.Size(96, 39);
            this.btnOpenFileOriginalText.TabIndex = 2;
            this.btnOpenFileOriginalText.Text = "Open";
            this.btnOpenFileOriginalText.UseTransparentBackground = true;
            this.btnOpenFileOriginalText.Click += new System.EventHandler(this.btnOpenFileOriginalText_Click);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(19, 57);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(161, 30);
            this.guna2HtmlLabel5.TabIndex = 2;
            this.guna2HtmlLabel5.TabStop = false;
            this.guna2HtmlLabel5.Text = "Original Text :";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOriginalText
            // 
            this.txtOriginalText.Animated = true;
            this.txtOriginalText.AutoScrollMargin = new System.Drawing.Size(10, 1);
            this.txtOriginalText.BorderRadius = 11;
            this.txtOriginalText.BorderThickness = 2;
            this.txtOriginalText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOriginalText.DefaultText = "";
            this.txtOriginalText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOriginalText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOriginalText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOriginalText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOriginalText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOriginalText.Font = new System.Drawing.Font("MV Boli", 11.25F);
            this.txtOriginalText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOriginalText.Location = new System.Drawing.Point(19, 95);
            this.txtOriginalText.Margin = new System.Windows.Forms.Padding(5);
            this.txtOriginalText.Multiline = true;
            this.txtOriginalText.Name = "txtOriginalText";
            this.txtOriginalText.PasswordChar = '\0';
            this.txtOriginalText.PlaceholderText = "Enter Original Text Or Choose File Text";
            this.txtOriginalText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginalText.SelectedText = "";
            this.txtOriginalText.Size = new System.Drawing.Size(380, 133);
            this.txtOriginalText.TabIndex = 0;
            this.txtOriginalText.TextChanged += new System.EventHandler(this.txtOriginalText_TextChanged);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(166, 10);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(186, 48);
            this.guna2HtmlLabel6.TabIndex = 0;
            this.guna2HtmlLabel6.TabStop = false;
            this.guna2HtmlLabel6.Text = "Encryption";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(308, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(521, 65);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Encryption-Decryption";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 150;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // MessageDialog
            // 
            this.MessageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageDialog.Caption = "Save";
            this.MessageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.MessageDialog.Parent = this;
            this.MessageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.MessageDialog.Text = "Saved Successfully";
            // 
            // tsBackGroundColor
            // 
            this.tsBackGroundColor.Animated = true;
            this.tsBackGroundColor.CheckedState.BorderColor = System.Drawing.Color.Silver;
            this.tsBackGroundColor.CheckedState.BorderRadius = 10;
            this.tsBackGroundColor.CheckedState.BorderThickness = 2;
            this.tsBackGroundColor.CheckedState.FillColor = System.Drawing.Color.Black;
            this.tsBackGroundColor.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsBackGroundColor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsBackGroundColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tsBackGroundColor.Location = new System.Drawing.Point(955, 25);
            this.tsBackGroundColor.Name = "tsBackGroundColor";
            this.tsBackGroundColor.Size = new System.Drawing.Size(68, 24);
            this.tsBackGroundColor.TabIndex = 3;
            this.tsBackGroundColor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsBackGroundColor.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsBackGroundColor.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsBackGroundColor.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsBackGroundColor.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 614);
            this.Controls.Add(this.tsBackGroundColor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.plEncryption);
            this.Controls.Add(this.plDecryption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1120, 653);
            this.MinimumSize = new System.Drawing.Size(1120, 653);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption-Decryption";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plDecryption.ResumeLayout(false);
            this.plDecryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.plEncryption.ResumeLayout(false);
            this.plEncryption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel plDecryption;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTextEncrypted;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btnOpenFileDecrypted;
        private Guna.UI2.WinForms.Guna2Button btnResetDecryption;
        private Guna.UI2.WinForms.Guna2Button btnDecryption;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtOriginalTextAfterDecryption;
        private Guna.UI2.WinForms.Guna2Button btnCopyOriginalText;
        private Guna.UI2.WinForms.Guna2Button btnSaveOriginalText;
        private Guna.UI2.WinForms.Guna2Panel plEncryption;
        private Guna.UI2.WinForms.Guna2Button btnCopyEncryptedText;
        private Guna.UI2.WinForms.Guna2Button btnSaveEncryptedText;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtTextEncryptedAfterEncryption;
        private Guna.UI2.WinForms.Guna2Button btnResetEncryption;
        private Guna.UI2.WinForms.Guna2Button btnEncryption;
        private Guna.UI2.WinForms.Guna2Button btnOpenFileOriginalText;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox txtOriginalText;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cbxDecryption;
        private Guna.UI2.WinForms.Guna2ComboBox cbxEncryption;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsBackGroundColor;
    }
}

