namespace UserControl_SimpleProject
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
            this.ctrlSimpleCalc1 = new UserControl_SimpleProject.ctrlSimpleCalc();
            this.ctrlSimpleCalc2 = new UserControl_SimpleProject.ctrlSimpleCalc();
            this.ctrlSimpleCalc3 = new UserControl_SimpleProject.ctrlSimpleCalc();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlSimpleCalc1
            // 
            this.ctrlSimpleCalc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSimpleCalc1.Location = new System.Drawing.Point(23, 28);
            this.ctrlSimpleCalc1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSimpleCalc1.Name = "ctrlSimpleCalc1";
            this.ctrlSimpleCalc1.Size = new System.Drawing.Size(149, 200);
            this.ctrlSimpleCalc1.TabIndex = 0;
            // 
            // ctrlSimpleCalc2
            // 
            this.ctrlSimpleCalc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSimpleCalc2.Location = new System.Drawing.Point(252, 97);
            this.ctrlSimpleCalc2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSimpleCalc2.Name = "ctrlSimpleCalc2";
            this.ctrlSimpleCalc2.Size = new System.Drawing.Size(149, 200);
            this.ctrlSimpleCalc2.TabIndex = 1;
            // 
            // ctrlSimpleCalc3
            // 
            this.ctrlSimpleCalc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlSimpleCalc3.Location = new System.Drawing.Point(484, 174);
            this.ctrlSimpleCalc3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlSimpleCalc3.Name = "ctrlSimpleCalc3";
            this.ctrlSimpleCalc3.Size = new System.Drawing.Size(149, 200);
            this.ctrlSimpleCalc3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlSimpleCalc3);
            this.Controls.Add(this.ctrlSimpleCalc2);
            this.Controls.Add(this.ctrlSimpleCalc1);
            this.Name = "Form1";
            this.Text = "User Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlSimpleCalc ctrlSimpleCalc1;
        private ctrlSimpleCalc ctrlSimpleCalc2;
        private ctrlSimpleCalc ctrlSimpleCalc3;
        private System.Windows.Forms.Button button1;
    }
}

