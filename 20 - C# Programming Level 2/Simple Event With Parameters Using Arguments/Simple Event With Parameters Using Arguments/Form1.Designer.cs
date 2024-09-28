namespace Simple_Event_With_Parameters_Using_Arguments
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlCalculatore1 = new Simple_Event_With_Parameters_Using_Arguments.ctrlCalculatore();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlCalculatore1
            // 
            this.ctrlCalculatore1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ctrlCalculatore1.Location = new System.Drawing.Point(39, 22);
            this.ctrlCalculatore1.Name = "ctrlCalculatore1";
            this.ctrlCalculatore1.Size = new System.Drawing.Size(512, 188);
            this.ctrlCalculatore1.TabIndex = 2;
            this.ctrlCalculatore1.OnCalculationComplete += new System.EventHandler<Simple_Event_With_Parameters_Using_Arguments.ctrlCalculatore.CalculationCompleteEventArgs>(this.ctrlCalculatore1_OnCalculationComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 334);
            this.Controls.Add(this.ctrlCalculatore1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private ctrlCalculatore ctrlCalculatore1;
    }
}

