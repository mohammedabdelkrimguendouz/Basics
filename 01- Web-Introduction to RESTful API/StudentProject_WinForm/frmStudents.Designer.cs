namespace StudentProject_WinForm
{
    partial class frmStudents
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
            components = new System.ComponentModel.Container();
            btnPassedStudents = new Button();
            btnAllStudents = new Button();
            btnAveargeGrade = new Button();
            btnAdd = new Button();
            dgvListStudents = new DataGridView();
            cmsListStudents = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvListStudents).BeginInit();
            cmsListStudents.SuspendLayout();
            SuspendLayout();
            // 
            // btnPassedStudents
            // 
            btnPassedStudents.Location = new Point(211, 44);
            btnPassedStudents.Name = "btnPassedStudents";
            btnPassedStudents.Size = new Size(139, 40);
            btnPassedStudents.TabIndex = 9;
            btnPassedStudents.Text = "Passed Students";
            btnPassedStudents.UseVisualStyleBackColor = true;
            btnPassedStudents.Click += btnPassedStudents_Click;
            // 
            // btnAllStudents
            // 
            btnAllStudents.Location = new Point(383, 44);
            btnAllStudents.Name = "btnAllStudents";
            btnAllStudents.Size = new Size(139, 40);
            btnAllStudents.TabIndex = 8;
            btnAllStudents.Text = "All Students";
            btnAllStudents.UseVisualStyleBackColor = true;
            btnAllStudents.Click += btnAllStudents_Click;
            // 
            // btnAveargeGrade
            // 
            btnAveargeGrade.Location = new Point(568, 44);
            btnAveargeGrade.Name = "btnAveargeGrade";
            btnAveargeGrade.Size = new Size(139, 40);
            btnAveargeGrade.TabIndex = 7;
            btnAveargeGrade.Text = "Avearge Grade";
            btnAveargeGrade.UseVisualStyleBackColor = true;
            btnAveargeGrade.Click += btnAveargeGrade_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(749, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvListStudents
            // 
            dgvListStudents.AllowUserToAddRows = false;
            dgvListStudents.AllowUserToDeleteRows = false;
            dgvListStudents.AllowUserToOrderColumns = true;
            dgvListStudents.AllowUserToResizeColumns = false;
            dgvListStudents.AllowUserToResizeRows = false;
            dgvListStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListStudents.ContextMenuStrip = cmsListStudents;
            dgvListStudents.Location = new Point(12, 90);
            dgvListStudents.Name = "dgvListStudents";
            dgvListStudents.Size = new Size(876, 312);
            dgvListStudents.TabIndex = 5;
            // 
            // cmsListStudents
            // 
            cmsListStudents.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem });
            cmsListStudents.Name = "cmsListStudents";
            cmsListStudents.Size = new Size(181, 70);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(180, 22);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // frmStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 450);
            Controls.Add(btnPassedStudents);
            Controls.Add(btnAllStudents);
            Controls.Add(btnAveargeGrade);
            Controls.Add(btnAdd);
            Controls.Add(dgvListStudents);
            Name = "frmStudents";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Students";
            ((System.ComponentModel.ISupportInitialize)dgvListStudents).EndInit();
            cmsListStudents.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnPassedStudents;
        private Button btnAllStudents;
        private Button btnAveargeGrade;
        private Button btnAdd;
        private DataGridView dgvListStudents;
        private ContextMenuStrip cmsListStudents;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}