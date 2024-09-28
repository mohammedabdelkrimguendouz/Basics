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
            SuspendLayout();
            // 
            // txtSecretKey
            // 
            txtSecretKey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSecretKey.Location = new Point(12, 84);
            txtSecretKey.Multiline = true;
            txtSecretKey.Name = "txtSecretKey";
            txtSecretKey.ReadOnly = true;
            txtSecretKey.Size = new Size(543, 66);
            txtSecretKey.TabIndex = 0;
            txtSecretKey.TextAlign = HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            btnGenerate.Cursor = Cursors.Hand;
            btnGenerate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.Location = new Point(213, 174);
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
            label1.Location = new Point(125, 9);
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
            btnCopy.Location = new Point(348, 174);
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
            btnClose.Location = new Point(78, 174);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 41);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 246);
            Controls.Add(btnClose);
            Controls.Add(btnCopy);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(txtSecretKey);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Secret Key Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSecretKey;
        private Button btnGenerate;
        private Label label1;
        private Button btnCopy;
        private Button btnClose;
    }
}
