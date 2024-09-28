namespace Pool_Club_Project_Idea_User_Control_
{
    partial class ctrlPoolTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStartStopTime = new System.Windows.Forms.Button();
            this.gbpTable = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(60, 200);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(103, 29);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00:00";
            // 
            // btnStartStopTime
            // 
            this.btnStartStopTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartStopTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStartStopTime.FlatAppearance.BorderSize = 2;
            this.btnStartStopTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStopTime.ForeColor = System.Drawing.Color.White;
            this.btnStartStopTime.Location = new System.Drawing.Point(228, 77);
            this.btnStartStopTime.Name = "btnStartStopTime";
            this.btnStartStopTime.Size = new System.Drawing.Size(99, 38);
            this.btnStartStopTime.TabIndex = 2;
            this.btnStartStopTime.Text = "Start";
            this.btnStartStopTime.UseVisualStyleBackColor = true;
            this.btnStartStopTime.Click += new System.EventHandler(this.btnStartStopTime_Click);
            // 
            // gbpTable
            // 
            this.gbpTable.BackColor = System.Drawing.Color.Black;
            this.gbpTable.Controls.Add(this.lblName);
            this.gbpTable.Controls.Add(this.btnEnd);
            this.gbpTable.Controls.Add(this.lblTime);
            this.gbpTable.Controls.Add(this.btnStartStopTime);
            this.gbpTable.Controls.Add(this.pictureBox1);
            this.gbpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbpTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpTable.ForeColor = System.Drawing.Color.White;
            this.gbpTable.Location = new System.Drawing.Point(0, 0);
            this.gbpTable.Name = "gbpTable";
            this.gbpTable.Size = new System.Drawing.Size(333, 242);
            this.gbpTable.TabIndex = 3;
            this.gbpTable.TabStop = false;
            this.gbpTable.Text = "Table";
            this.gbpTable.Enter += new System.EventHandler(this.gbpTable_Enter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(130, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Player";
            // 
            // btnEnd
            // 
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEnd.FlatAppearance.BorderSize = 2;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(228, 130);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(99, 38);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pool_Club_Project_Idea_User_Control_.Properties.Resources.pool;
            this.pictureBox1.Location = new System.Drawing.Point(6, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlPoolTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbpTable);
            this.Name = "ctrlPoolTable";
            this.Size = new System.Drawing.Size(333, 242);
            this.Load += new System.EventHandler(this.ctrlPoolTable_Load);
            this.gbpTable.ResumeLayout(false);
            this.gbpTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStartStopTime;
        private System.Windows.Forms.GroupBox gbpTable;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer timer1;
    }
}
