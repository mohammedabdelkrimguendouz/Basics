namespace ProductsAppWinForm
{
    partial class frmListCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListCustomers));
            this.btnRefreshListCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefrchListCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.ToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.dgvListCustomers = new System.Windows.Forms.DataGridView();
            this.gbListCustomers = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomers)).BeginInit();
            this.gbListCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefreshListCustomers
            // 
            this.btnRefreshListCustomers.Animated = true;
            this.btnRefreshListCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshListCustomers.BorderRadius = 10;
            this.btnRefreshListCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshListCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshListCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshListCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshListCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshListCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefreshListCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshListCustomers.ForeColor = System.Drawing.Color.White;
            this.btnRefreshListCustomers.Image = global::ProductsAppWinForm.Properties.Resources.icons8_reset_481;
            this.btnRefreshListCustomers.Location = new System.Drawing.Point(-225, 21);
            this.btnRefreshListCustomers.Name = "btnRefreshListCustomers";
            this.btnRefreshListCustomers.Size = new System.Drawing.Size(36, 39);
            this.btnRefreshListCustomers.TabIndex = 25;
            this.btnRefreshListCustomers.UseTransparentBackground = true;
            // 
            // btnRefrchListCustomers
            // 
            this.btnRefrchListCustomers.Animated = true;
            this.btnRefrchListCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrchListCustomers.BorderRadius = 10;
            this.btnRefrchListCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrchListCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefrchListCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefrchListCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefrchListCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefrchListCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefrchListCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrchListCustomers.ForeColor = System.Drawing.Color.White;
            this.btnRefrchListCustomers.Image = global::ProductsAppWinForm.Properties.Resources.icons8_reset_481;
            this.btnRefrchListCustomers.Location = new System.Drawing.Point(10, 82);
            this.btnRefrchListCustomers.Name = "btnRefrchListCustomers";
            this.btnRefrchListCustomers.Size = new System.Drawing.Size(36, 39);
            this.btnRefrchListCustomers.TabIndex = 27;
            this.ToolTip1.SetToolTip(this.btnRefrchListCustomers, "Refrch List Customers");
            this.btnRefrchListCustomers.UseTransparentBackground = true;
            this.btnRefrchListCustomers.Click += new System.EventHandler(this.btnRefrchListCustomers_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BorderRadius = 15;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Location = new System.Drawing.Point(371, 77);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(279, 43);
            this.txtLastName.TabIndex = 34;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderRadius = 15;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe Print", 11.25F);
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Location = new System.Drawing.Point(371, 13);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(279, 43);
            this.txtFirstName.TabIndex = 33;
            // 
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 10;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::ProductsAppWinForm.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(704, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 39);
            this.btnSearch.TabIndex = 35;
            this.ToolTip1.SetToolTip(this.btnSearch, "Search");
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.AllowLinksHandling = true;
            this.ToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // dgvListCustomers
            // 
            this.dgvListCustomers.AllowUserToAddRows = false;
            this.dgvListCustomers.AllowUserToDeleteRows = false;
            this.dgvListCustomers.AllowUserToOrderColumns = true;
            this.dgvListCustomers.AllowUserToResizeColumns = false;
            this.dgvListCustomers.AllowUserToResizeRows = false;
            this.dgvListCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListCustomers.Location = new System.Drawing.Point(0, 40);
            this.dgvListCustomers.MultiSelect = false;
            this.dgvListCustomers.Name = "dgvListCustomers";
            this.dgvListCustomers.ReadOnly = true;
            this.dgvListCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCustomers.Size = new System.Drawing.Size(1250, 417);
            this.dgvListCustomers.TabIndex = 0;
            this.dgvListCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCustomers_CellDoubleClick);
            // 
            // gbListCustomers
            // 
            this.gbListCustomers.Controls.Add(this.dgvListCustomers);
            this.gbListCustomers.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListCustomers.ForeColor = System.Drawing.Color.Black;
            this.gbListCustomers.Location = new System.Drawing.Point(10, 127);
            this.gbListCustomers.Name = "gbListCustomers";
            this.gbListCustomers.Size = new System.Drawing.Size(1250, 457);
            this.gbListCustomers.TabIndex = 24;
            this.gbListCustomers.Text = "List Customers";
            // 
            // frmListCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1272, 596);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnRefrchListCustomers);
            this.Controls.Add(this.btnRefreshListCustomers);
            this.Controls.Add(this.gbListCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1288, 635);
            this.MinimumSize = new System.Drawing.Size(1288, 635);
            this.Name = "frmListCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Customers";
            this.Load += new System.EventHandler(this.frmListCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomers)).EndInit();
            this.gbListCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnRefreshListCustomers;
        private Guna.UI2.WinForms.Guna2Button btnRefrchListCustomers;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip1;
        public System.Windows.Forms.DataGridView dgvListCustomers;
        public Guna.UI2.WinForms.Guna2GroupBox gbListCustomers;
    }
}