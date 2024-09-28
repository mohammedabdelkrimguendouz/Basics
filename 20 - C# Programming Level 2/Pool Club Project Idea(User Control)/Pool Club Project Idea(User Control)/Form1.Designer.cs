namespace Pool_Club_Project_Idea_User_Control_
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
            this.ctrlPoolTable1 = new Pool_Club_Project_Idea_User_Control_.ctrlPoolTable();
            this.ctrlPoolTable2 = new Pool_Club_Project_Idea_User_Control_.ctrlPoolTable();
            this.ctrlPoolTable3 = new Pool_Club_Project_Idea_User_Control_.ctrlPoolTable();
            this.ctrlPoolTable4 = new Pool_Club_Project_Idea_User_Control_.ctrlPoolTable();
            this.ctrlPoolTable5 = new Pool_Club_Project_Idea_User_Control_.ctrlPoolTable();
            this.ctrlPoolTable6 = new Pool_Club_Project_Idea_User_Control_.ctrlPoolTable();
            this.ctrlPoolTable7 = new Pool_Club_Project_Idea_User_Control_.ctrlPoolTable();
            this.ctrlPoolTable8 = new Pool_Club_Project_Idea_User_Control_.ctrlPoolTable();
            this.SuspendLayout();
            // 
            // ctrlPoolTable1
            // 
            this.ctrlPoolTable1.HourlyRate = 10F;
            this.ctrlPoolTable1.Location = new System.Drawing.Point(341, 12);
            this.ctrlPoolTable1.Name = "ctrlPoolTable1";
            this.ctrlPoolTable1.Size = new System.Drawing.Size(333, 242);
            this.ctrlPoolTable1.TabIndex = 0;
            this.ctrlPoolTable1.TablePlayer = "Player";
            this.ctrlPoolTable1.TableTitle = "Table";
            // 
            // ctrlPoolTable2
            // 
            this.ctrlPoolTable2.HourlyRate = 10F;
            this.ctrlPoolTable2.Location = new System.Drawing.Point(2, 12);
            this.ctrlPoolTable2.Name = "ctrlPoolTable2";
            this.ctrlPoolTable2.Size = new System.Drawing.Size(333, 242);
            this.ctrlPoolTable2.TabIndex = 1;
            this.ctrlPoolTable2.TablePlayer = "Player";
            this.ctrlPoolTable2.TableTitle = "Table";
            this.ctrlPoolTable2.OnTableCompleted += new System.EventHandler<Pool_Club_Project_Idea_User_Control_.ctrlPoolTable.TableCompletedEventArgs>(this.ctrlPoolTable2_OnTableCompleted);
            // 
            // ctrlPoolTable3
            // 
            this.ctrlPoolTable3.HourlyRate = 10F;
            this.ctrlPoolTable3.Location = new System.Drawing.Point(680, 12);
            this.ctrlPoolTable3.Name = "ctrlPoolTable3";
            this.ctrlPoolTable3.Size = new System.Drawing.Size(333, 242);
            this.ctrlPoolTable3.TabIndex = 2;
            this.ctrlPoolTable3.TablePlayer = "Player";
            this.ctrlPoolTable3.TableTitle = "Table";
            // 
            // ctrlPoolTable4
            // 
            this.ctrlPoolTable4.HourlyRate = 10F;
            this.ctrlPoolTable4.Location = new System.Drawing.Point(1019, 12);
            this.ctrlPoolTable4.Name = "ctrlPoolTable4";
            this.ctrlPoolTable4.Size = new System.Drawing.Size(333, 242);
            this.ctrlPoolTable4.TabIndex = 3;
            this.ctrlPoolTable4.TablePlayer = "Player";
            this.ctrlPoolTable4.TableTitle = "Table";
            // 
            // ctrlPoolTable5
            // 
            this.ctrlPoolTable5.HourlyRate = 10F;
            this.ctrlPoolTable5.Location = new System.Drawing.Point(1019, 272);
            this.ctrlPoolTable5.Name = "ctrlPoolTable5";
            this.ctrlPoolTable5.Size = new System.Drawing.Size(333, 242);
            this.ctrlPoolTable5.TabIndex = 7;
            this.ctrlPoolTable5.TablePlayer = "Player";
            this.ctrlPoolTable5.TableTitle = "Table";
            // 
            // ctrlPoolTable6
            // 
            this.ctrlPoolTable6.HourlyRate = 10F;
            this.ctrlPoolTable6.Location = new System.Drawing.Point(680, 272);
            this.ctrlPoolTable6.Name = "ctrlPoolTable6";
            this.ctrlPoolTable6.Size = new System.Drawing.Size(333, 242);
            this.ctrlPoolTable6.TabIndex = 6;
            this.ctrlPoolTable6.TablePlayer = "Player";
            this.ctrlPoolTable6.TableTitle = "Table";
            // 
            // ctrlPoolTable7
            // 
            this.ctrlPoolTable7.HourlyRate = 10F;
            this.ctrlPoolTable7.Location = new System.Drawing.Point(2, 272);
            this.ctrlPoolTable7.Name = "ctrlPoolTable7";
            this.ctrlPoolTable7.Size = new System.Drawing.Size(333, 242);
            this.ctrlPoolTable7.TabIndex = 5;
            this.ctrlPoolTable7.TablePlayer = "Player";
            this.ctrlPoolTable7.TableTitle = "Table";
            // 
            // ctrlPoolTable8
            // 
            this.ctrlPoolTable8.HourlyRate = 10F;
            this.ctrlPoolTable8.Location = new System.Drawing.Point(341, 272);
            this.ctrlPoolTable8.Name = "ctrlPoolTable8";
            this.ctrlPoolTable8.Size = new System.Drawing.Size(333, 242);
            this.ctrlPoolTable8.TabIndex = 4;
            this.ctrlPoolTable8.TablePlayer = "Player";
            this.ctrlPoolTable8.TableTitle = "Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1356, 538);
            this.Controls.Add(this.ctrlPoolTable5);
            this.Controls.Add(this.ctrlPoolTable6);
            this.Controls.Add(this.ctrlPoolTable7);
            this.Controls.Add(this.ctrlPoolTable8);
            this.Controls.Add(this.ctrlPoolTable4);
            this.Controls.Add(this.ctrlPoolTable3);
            this.Controls.Add(this.ctrlPoolTable2);
            this.Controls.Add(this.ctrlPoolTable1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPoolTable ctrlPoolTable1;
        private ctrlPoolTable ctrlPoolTable2;
        private ctrlPoolTable ctrlPoolTable3;
        private ctrlPoolTable ctrlPoolTable4;
        private ctrlPoolTable ctrlPoolTable5;
        private ctrlPoolTable ctrlPoolTable6;
        private ctrlPoolTable ctrlPoolTable7;
        private ctrlPoolTable ctrlPoolTable8;
    }
}

