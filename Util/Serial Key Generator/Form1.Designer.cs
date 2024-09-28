namespace Serial_Key_Generator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plGenerator = new System.Windows.Forms.Panel();
            this.btnAddSerialKeys = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.nudSerialCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plCharacters = new System.Windows.Forms.Panel();
            this.chkLowerCase = new System.Windows.Forms.CheckBox();
            this.chkNumber = new System.Windows.Forms.CheckBox();
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plSection = new System.Windows.Forms.Panel();
            this.txtSeperatoreKey = new System.Windows.Forms.TextBox();
            this.nudSection = new System.Windows.Forms.NumericUpDown();
            this.nudCharsPerSection = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chNumberOfKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKeys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.lblNumberSerial = new System.Windows.Forms.Label();
            this.btnShowListKeys = new System.Windows.Forms.Button();
            this.btnClearListKeys = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.plGenerator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerialCount)).BeginInit();
            this.plCharacters.SuspendLayout();
            this.plSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharsPerSection)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plGenerator
            // 
            this.plGenerator.BackColor = System.Drawing.Color.LightBlue;
            this.plGenerator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plGenerator.Controls.Add(this.btnAddSerialKeys);
            this.plGenerator.Controls.Add(this.btnGenerate);
            this.plGenerator.Controls.Add(this.nudSerialCount);
            this.plGenerator.Controls.Add(this.label4);
            this.plGenerator.Controls.Add(this.label1);
            this.plGenerator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plGenerator.Location = new System.Drawing.Point(291, 12);
            this.plGenerator.Name = "plGenerator";
            this.plGenerator.Size = new System.Drawing.Size(165, 100);
            this.plGenerator.TabIndex = 0;
            // 
            // btnAddSerialKeys
            // 
            this.btnAddSerialKeys.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddSerialKeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSerialKeys.Location = new System.Drawing.Point(1, 41);
            this.btnAddSerialKeys.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddSerialKeys.Name = "btnAddSerialKeys";
            this.btnAddSerialKeys.Size = new System.Drawing.Size(73, 28);
            this.btnAddSerialKeys.TabIndex = 4;
            this.btnAddSerialKeys.Text = "Add";
            this.btnAddSerialKeys.UseVisualStyleBackColor = false;
            this.btnAddSerialKeys.Click += new System.EventHandler(this.btnAddSerialKeys_Click);
            this.btnAddSerialKeys.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnAddSerialKeys.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.Location = new System.Drawing.Point(83, 41);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(73, 28);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            this.btnGenerate.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnGenerate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // nudSerialCount
            // 
            this.nudSerialCount.Location = new System.Drawing.Point(98, 10);
            this.nudSerialCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudSerialCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSerialCount.Name = "nudSerialCount";
            this.nudSerialCount.Size = new System.Drawing.Size(60, 20);
            this.nudSerialCount.TabIndex = 2;
            this.nudSerialCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSerialCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(-2, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Serial Count : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label1.Location = new System.Drawing.Point(-2, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MinimumSize = new System.Drawing.Size(163, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plCharacters
            // 
            this.plCharacters.BackColor = System.Drawing.Color.LightBlue;
            this.plCharacters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plCharacters.Controls.Add(this.chkLowerCase);
            this.plCharacters.Controls.Add(this.chkNumber);
            this.plCharacters.Controls.Add(this.chkUpperCase);
            this.plCharacters.Controls.Add(this.label2);
            this.plCharacters.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plCharacters.Location = new System.Drawing.Point(183, 12);
            this.plCharacters.Name = "plCharacters";
            this.plCharacters.Size = new System.Drawing.Size(102, 100);
            this.plCharacters.TabIndex = 3;
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.Location = new System.Drawing.Point(15, 48);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(79, 17);
            this.chkLowerCase.TabIndex = 3;
            this.chkLowerCase.Text = "LowerCase";
            this.chkLowerCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkNumber
            // 
            this.chkNumber.AutoSize = true;
            this.chkNumber.Checked = true;
            this.chkNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNumber.Location = new System.Drawing.Point(15, 28);
            this.chkNumber.Name = "chkNumber";
            this.chkNumber.Size = new System.Drawing.Size(63, 17);
            this.chkNumber.TabIndex = 2;
            this.chkNumber.Text = "Number";
            this.chkNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNumber.UseVisualStyleBackColor = true;
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.AutoSize = true;
            this.chkUpperCase.Checked = true;
            this.chkUpperCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpperCase.Location = new System.Drawing.Point(15, 8);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(79, 17);
            this.chkUpperCase.TabIndex = 1;
            this.chkUpperCase.Text = "UpperCase";
            this.chkUpperCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(-2, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MinimumSize = new System.Drawing.Size(100, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Characters";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plSection
            // 
            this.plSection.BackColor = System.Drawing.Color.LightBlue;
            this.plSection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plSection.Controls.Add(this.txtSeperatoreKey);
            this.plSection.Controls.Add(this.nudSection);
            this.plSection.Controls.Add(this.nudCharsPerSection);
            this.plSection.Controls.Add(this.label8);
            this.plSection.Controls.Add(this.label7);
            this.plSection.Controls.Add(this.label6);
            this.plSection.Controls.Add(this.label5);
            this.plSection.Controls.Add(this.label3);
            this.plSection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plSection.Location = new System.Drawing.Point(2, 12);
            this.plSection.Name = "plSection";
            this.plSection.Size = new System.Drawing.Size(175, 100);
            this.plSection.TabIndex = 4;
            // 
            // txtSeperatoreKey
            // 
            this.txtSeperatoreKey.Location = new System.Drawing.Point(122, 55);
            this.txtSeperatoreKey.Name = "txtSeperatoreKey";
            this.txtSeperatoreKey.Size = new System.Drawing.Size(46, 20);
            this.txtSeperatoreKey.TabIndex = 5;
            this.txtSeperatoreKey.Text = "-";
            this.txtSeperatoreKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudSection
            // 
            this.nudSection.Location = new System.Drawing.Point(71, 33);
            this.nudSection.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudSection.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSection.Name = "nudSection";
            this.nudSection.Size = new System.Drawing.Size(48, 20);
            this.nudSection.TabIndex = 7;
            this.nudSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSection.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudCharsPerSection
            // 
            this.nudCharsPerSection.Location = new System.Drawing.Point(125, 15);
            this.nudCharsPerSection.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCharsPerSection.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudCharsPerSection.Name = "nudCharsPerSection";
            this.nudCharsPerSection.Size = new System.Drawing.Size(48, 20);
            this.nudCharsPerSection.TabIndex = 6;
            this.nudCharsPerSection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCharsPerSection.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Section?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Section Separtor?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "chars Per Section?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "How Many : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(-2, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MinimumSize = new System.Drawing.Size(173, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Section";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumberOfKey,
            this.chKeys});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Enabled = false;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(2, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(452, 398);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            // 
            // chNumberOfKey
            // 
            this.chNumberOfKey.Text = "";
            this.chNumberOfKey.Width = 53;
            // 
            // chKeys
            // 
            this.chKeys.Text = "Keys";
            this.chKeys.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chKeys.Width = 398;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCopy,
            this.tsmDelete,
            this.tsmAdd});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 70);
            // 
            // tsmCopy
            // 
            this.tsmCopy.Image = global::Serial_Key_Generator.Properties.Resources._8725676_copy_icon;
            this.tsmCopy.Name = "tsmCopy";
            this.tsmCopy.Size = new System.Drawing.Size(143, 22);
            this.tsmCopy.Text = "Copy";
            this.tsmCopy.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::Serial_Key_Generator.Properties.Resources._9004852_trash_delete_bin_remove_icon;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(143, 22);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Image = global::Serial_Key_Generator.Properties.Resources._2303130_add_create_new_plus_icon;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(143, 22);
            this.tsmAdd.Text = "Add One Key";
            this.tsmAdd.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "379460_key_icon.ico");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "379460_key_icon.ico");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(-1, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Number Keys : ";
            // 
            // lblNumberSerial
            // 
            this.lblNumberSerial.AutoSize = true;
            this.lblNumberSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberSerial.ForeColor = System.Drawing.Color.Black;
            this.lblNumberSerial.Location = new System.Drawing.Point(111, 124);
            this.lblNumberSerial.Name = "lblNumberSerial";
            this.lblNumberSerial.Size = new System.Drawing.Size(17, 18);
            this.lblNumberSerial.TabIndex = 7;
            this.lblNumberSerial.Text = "0";
            // 
            // btnShowListKeys
            // 
            this.btnShowListKeys.BackColor = System.Drawing.Color.SteelBlue;
            this.btnShowListKeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowListKeys.Location = new System.Drawing.Point(151, 115);
            this.btnShowListKeys.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowListKeys.Name = "btnShowListKeys";
            this.btnShowListKeys.Size = new System.Drawing.Size(98, 35);
            this.btnShowListKeys.TabIndex = 8;
            this.btnShowListKeys.Text = "Show List Keys";
            this.btnShowListKeys.UseVisualStyleBackColor = false;
            this.btnShowListKeys.Click += new System.EventHandler(this.btnShowListKeys_Click);
            this.btnShowListKeys.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnShowListKeys.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // btnClearListKeys
            // 
            this.btnClearListKeys.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClearListKeys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearListKeys.Enabled = false;
            this.btnClearListKeys.Location = new System.Drawing.Point(259, 115);
            this.btnClearListKeys.Margin = new System.Windows.Forms.Padding(0);
            this.btnClearListKeys.Name = "btnClearListKeys";
            this.btnClearListKeys.Size = new System.Drawing.Size(98, 35);
            this.btnClearListKeys.TabIndex = 9;
            this.btnClearListKeys.Text = "Clear List Keys";
            this.btnClearListKeys.UseVisualStyleBackColor = false;
            this.btnClearListKeys.Click += new System.EventHandler(this.btnClearListKeys_Click);
            this.btnClearListKeys.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnClearListKeys.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_MouseMove);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(-1, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Max Keys : 50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(458, 161);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClearListKeys);
            this.Controls.Add(this.btnShowListKeys);
            this.Controls.Add(this.lblNumberSerial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.plSection);
            this.Controls.Add(this.plCharacters);
            this.Controls.Add(this.plGenerator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(474, 591);
            this.MinimumSize = new System.Drawing.Size(474, 200);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Key Generator";
            this.plGenerator.ResumeLayout(false);
            this.plGenerator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerialCount)).EndInit();
            this.plCharacters.ResumeLayout(false);
            this.plCharacters.PerformLayout();
            this.plSection.ResumeLayout(false);
            this.plSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCharsPerSection)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plGenerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plCharacters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plSection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSerialCount;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkLowerCase;
        private System.Windows.Forms.CheckBox chkNumber;
        private System.Windows.Forms.CheckBox chkUpperCase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCharsPerSection;
        private System.Windows.Forms.NumericUpDown nudSection;
        private System.Windows.Forms.TextBox txtSeperatoreKey;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chNumberOfKey;
        private System.Windows.Forms.ColumnHeader chKeys;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnAddSerialKeys;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblNumberSerial;
        private System.Windows.Forms.Button btnShowListKeys;
        private System.Windows.Forms.Button btnClearListKeys;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
    }
}

