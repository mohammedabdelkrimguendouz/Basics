namespace MyFirstEWinFormsProject
{
    partial class frmDialog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnSaveFileDialoge = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnOpenFileDialoge = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFileDialogeMulti = new System.Windows.Forms.Button();
            this.btnFolderBrowserDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ProgrammingAdvices.com";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "change Back Ground Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(488, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Chang Fore Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(256, 29);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(314, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(256, 29);
            this.textBox3.TabIndex = 5;
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeFont.Location = new System.Drawing.Point(223, 144);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(213, 29);
            this.btnChangeFont.TabIndex = 6;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(117, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(434, 29);
            this.textBox4.TabIndex = 7;
            // 
            // btnSaveFileDialoge
            // 
            this.btnSaveFileDialoge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFileDialoge.Location = new System.Drawing.Point(12, 214);
            this.btnSaveFileDialoge.Name = "btnSaveFileDialoge";
            this.btnSaveFileDialoge.Size = new System.Drawing.Size(213, 29);
            this.btnSaveFileDialoge.TabIndex = 8;
            this.btnSaveFileDialoge.Text = "Save File Dialoge";
            this.btnSaveFileDialoge.UseVisualStyleBackColor = true;
            this.btnSaveFileDialoge.Click += new System.EventHandler(this.btnSaveFileDialoge_Click);
            // 
            // btnOpenFileDialoge
            // 
            this.btnOpenFileDialoge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFileDialoge.Location = new System.Drawing.Point(257, 214);
            this.btnOpenFileDialoge.Name = "btnOpenFileDialoge";
            this.btnOpenFileDialoge.Size = new System.Drawing.Size(213, 29);
            this.btnOpenFileDialoge.TabIndex = 9;
            this.btnOpenFileDialoge.Text = "Open File Dialoge";
            this.btnOpenFileDialoge.UseVisualStyleBackColor = true;
            this.btnOpenFileDialoge.Click += new System.EventHandler(this.btnOpenFileDialoge_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFileDialogeMulti
            // 
            this.btnOpenFileDialogeMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFileDialogeMulti.Location = new System.Drawing.Point(505, 214);
            this.btnOpenFileDialogeMulti.Name = "btnOpenFileDialogeMulti";
            this.btnOpenFileDialogeMulti.Size = new System.Drawing.Size(245, 29);
            this.btnOpenFileDialogeMulti.TabIndex = 10;
            this.btnOpenFileDialogeMulti.Text = "Open File Dialoge Multi Selected";
            this.btnOpenFileDialogeMulti.UseVisualStyleBackColor = true;
            this.btnOpenFileDialogeMulti.Click += new System.EventHandler(this.btnOpenFileDialogeMulti_Click);
            // 
            // btnFolderBrowserDialog
            // 
            this.btnFolderBrowserDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderBrowserDialog.Location = new System.Drawing.Point(257, 259);
            this.btnFolderBrowserDialog.Name = "btnFolderBrowserDialog";
            this.btnFolderBrowserDialog.Size = new System.Drawing.Size(213, 29);
            this.btnFolderBrowserDialog.TabIndex = 11;
            this.btnFolderBrowserDialog.Text = "Folder Browser Dialog";
            this.btnFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.btnFolderBrowserDialog.Click += new System.EventHandler(this.btnFolderBrowserDialog_Click);
            // 
            // frmDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 300);
            this.Controls.Add(this.btnFolderBrowserDialog);
            this.Controls.Add(this.btnOpenFileDialogeMulti);
            this.Controls.Add(this.btnOpenFileDialoge);
            this.Controls.Add(this.btnSaveFileDialoge);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDialog";
            this.Text = "frmDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnSaveFileDialoge;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDialoge;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDialogeMulti;
        private System.Windows.Forms.Button btnFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}