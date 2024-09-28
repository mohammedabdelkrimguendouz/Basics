namespace Example_1_Change_Desktop_Wallpaper
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
            this.btnChangeWallpaper = new System.Windows.Forms.Button();
            this.pbWallpaper = new System.Windows.Forms.PictureBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbWallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangeWallpaper
            // 
            this.btnChangeWallpaper.Enabled = false;
            this.btnChangeWallpaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeWallpaper.Location = new System.Drawing.Point(242, 219);
            this.btnChangeWallpaper.Name = "btnChangeWallpaper";
            this.btnChangeWallpaper.Size = new System.Drawing.Size(159, 40);
            this.btnChangeWallpaper.TabIndex = 0;
            this.btnChangeWallpaper.Text = "Change";
            this.btnChangeWallpaper.UseVisualStyleBackColor = true;
            this.btnChangeWallpaper.Click += new System.EventHandler(this.btnChangeWallpaper_Click);
            // 
            // pbWallpaper
            // 
            this.pbWallpaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWallpaper.Location = new System.Drawing.Point(164, 24);
            this.pbWallpaper.Name = "pbWallpaper";
            this.pbWallpaper.Size = new System.Drawing.Size(300, 175);
            this.pbWallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWallpaper.TabIndex = 1;
            this.pbWallpaper.TabStop = false;
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(12, 93);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(137, 40);
            this.btnChoose.TabIndex = 2;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 275);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.pbWallpaper);
            this.Controls.Add(this.btnChangeWallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Wallpaper";
            ((System.ComponentModel.ISupportInitialize)(this.pbWallpaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeWallpaper;
        private System.Windows.Forms.PictureBox pbWallpaper;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

