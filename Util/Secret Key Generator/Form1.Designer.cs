namespace Secret_Key_Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSecretKey = new TextBox();
            btnGenerate = new Button();
            label1 = new Label();
            btnCopy = new Button();
            btnClose = new Button();
            cbLengthByte = new ComboBox();
            lblLengthByte = new Label();
            SuspendLayout();
            // 
            // txtSecretKey
            // 
            txtSecretKey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecretKey.Location = new Point(12, 149);
            txtSecretKey.Multiline = true;
            txtSecretKey.Name = "txtSecretKey";
            txtSecretKey.ReadOnly = true;
            txtSecretKey.ScrollBars = ScrollBars.Both;
            txtSecretKey.Size = new Size(712, 167);
            txtSecretKey.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(296, 322);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(122, 41);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(187, 9);
            label1.Name = "label1";
            label1.Size = new Size(345, 47);
            label1.TabIndex = 2;
            label1.Text = "Secret Key Generator";
            // 
            // btnCopy
            // 
            btnCopy.Cursor = Cursors.Hand;
            btnCopy.Enabled = false;
            btnCopy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopy.Location = new Point(431, 322);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(122, 41);
            btnCopy.TabIndex = 3;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(161, 322);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 41);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbLengthByte
            // 
            cbLengthByte.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLengthByte.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLengthByte.FormattingEnabled = true;
            cbLengthByte.Items.AddRange(new object[] { "128", "256", "32", "512", "64" });
            cbLengthByte.Location = new Point(278, 87);
            cbLengthByte.Name = "cbLengthByte";
            cbLengthByte.Size = new Size(195, 33);
            cbLengthByte.TabIndex = 5;
            // 
            // lblLengthByte
            // 
            lblLengthByte.AutoSize = true;
            lblLengthByte.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLengthByte.Location = new Point(123, 90);
            lblLengthByte.Name = "lblLengthByte";
            lblLengthByte.Size = new Size(125, 25);
            lblLengthByte.TabIndex = 6;
            lblLengthByte.Text = "Length Byte : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 368);
            Controls.Add(lblLengthByte);
            Controls.Add(cbLengthByte);
            Controls.Add(btnClose);
            Controls.Add(btnCopy);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(txtSecretKey);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secret Key Generator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSecretKey;
        private Button btnGenerate;
        private Label label1;
        private Button btnCopy;
        private Button btnClose;
        private ComboBox cbLengthByte;
        private Label lblLengthByte;
    }
}
