namespace AddEvent_In_User_Control
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
            this.ctrlCalculatore1 = new AddEvent_In_User_Control.ctrlCalculatore();
            this.SuspendLayout();
            // 
            // ctrlCalculatore1
            // 
            this.ctrlCalculatore1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlCalculatore1.Location = new System.Drawing.Point(53, 26);
            this.ctrlCalculatore1.Name = "ctrlCalculatore1";
            this.ctrlCalculatore1.Size = new System.Drawing.Size(475, 163);
            this.ctrlCalculatore1.TabIndex = 0;
            this.ctrlCalculatore1.OnCalculationComplete += new System.Action<float>(this.ctrlCalculatore1_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(580, 228);
            this.Controls.Add(this.ctrlCalculatore1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCalculatore ctelCalculatore1;
        private ctrlCalculatore ctrlCalculatore1;
    }
}

