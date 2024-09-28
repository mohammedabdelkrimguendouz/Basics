namespace StudentProject_WinForm
{
    partial class frmAddEditStudents
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
            btnSave = new Button();
            btnClose = new Button();
            txtName = new TextBox();
            label1 = new Label();
            Age = new Label();
            label4 = new Label();
            label3 = new Label();
            lblID = new Label();
            nudAge = new NumericUpDown();
            nudGrade = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGrade).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(339, 241);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(139, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(149, 241);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 40);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(328, 23);
            txtName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 8;
            label1.Text = "Name : ";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(12, 93);
            Age.Name = "Age";
            Age.Size = new Size(28, 15);
            Age.TabIndex = 9;
            Age.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 138);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 19);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 12;
            label3.Text = "ID : ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = SystemColors.Control;
            lblID.ForeColor = Color.Red;
            lblID.Location = new Point(61, 19);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 15);
            lblID.TabIndex = 13;
            lblID.Text = "ID : ";
            // 
            // nudAge
            // 
            nudAge.Location = new Point(74, 91);
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(120, 23);
            nudAge.TabIndex = 14;
            // 
            // nudGrade
            // 
            nudGrade.Location = new Point(74, 138);
            nudGrade.Name = "nudGrade";
            nudGrade.Size = new Size(120, 23);
            nudGrade.TabIndex = 15;
            // 
            // frmAddEditStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 293);
            Controls.Add(nudGrade);
            Controls.Add(nudAge);
            Controls.Add(lblID);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Age);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Name = "frmAddEditStudents";
            Text = "frmAddEditStudents";
            Load += frmAddEditStudents_Load;
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnClose;
        private TextBox txtName;
        private Label label1;
        private Label Age;
        private Label label4;
        private Label label3;
        private Label lblID;
        private NumericUpDown nudAge;
        private NumericUpDown nudGrade;
    }
}