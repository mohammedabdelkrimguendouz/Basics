namespace ProductsAppWinForm
{
    partial class frmCustomersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersManagement));
            this.btnRefreshListCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.gbListCustomers = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllListCustomers = new System.Windows.Forms.DataGridView();
            this.cmsCustomersManagement = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbSearchByName = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbSearchByCountries = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.gbListCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListCustomers)).BeginInit();
            this.cmsCustomersManagement.SuspendLayout();
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
            this.btnRefreshListCustomers.Location = new System.Drawing.Point(12, 92);
            this.btnRefreshListCustomers.Name = "btnRefreshListCustomers";
            this.btnRefreshListCustomers.Size = new System.Drawing.Size(36, 39);
            this.btnRefreshListCustomers.TabIndex = 23;
            this.ToolTip1.SetToolTip(this.btnRefreshListCustomers, "Referch List Customers");
            this.btnRefreshListCustomers.UseTransparentBackground = true;
            this.btnRefreshListCustomers.Click += new System.EventHandler(this.btnRefreshListCustomers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 10;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::ProductsAppWinForm.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(12, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 45);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteAllCustomers
            // 
            this.btnDeleteAllCustomers.Animated = true;
            this.btnDeleteAllCustomers.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAllCustomers.BorderRadius = 10;
            this.btnDeleteAllCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteAllCustomers.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllCustomers.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAllCustomers.Image = global::ProductsAppWinForm.Properties.Resources._9004852_trash_delete_bin_remove_icon;
            this.btnDeleteAllCustomers.Location = new System.Drawing.Point(338, 538);
            this.btnDeleteAllCustomers.Name = "btnDeleteAllCustomers";
            this.btnDeleteAllCustomers.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteAllCustomers.TabIndex = 21;
            this.btnDeleteAllCustomers.Text = "DeleteAll";
            this.btnDeleteAllCustomers.UseTransparentBackground = true;
            this.btnDeleteAllCustomers.Click += new System.EventHandler(this.btnDeleteAllCustomers_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Animated = true;
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BorderRadius = 10;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNew.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = global::ProductsAppWinForm.Properties.Resources.icons8_add_product_481;
            this.btnAddNew.Location = new System.Drawing.Point(990, 538);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(180, 45);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseTransparentBackground = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // gbListCustomers
            // 
            this.gbListCustomers.Controls.Add(this.dgvAllListCustomers);
            this.gbListCustomers.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListCustomers.ForeColor = System.Drawing.Color.Black;
            this.gbListCustomers.Location = new System.Drawing.Point(12, 137);
            this.gbListCustomers.Name = "gbListCustomers";
            this.gbListCustomers.Size = new System.Drawing.Size(1250, 363);
            this.gbListCustomers.TabIndex = 18;
            this.gbListCustomers.Text = "List Customers";
            // 
            // dgvAllListCustomers
            // 
            this.dgvAllListCustomers.AllowUserToAddRows = false;
            this.dgvAllListCustomers.AllowUserToDeleteRows = false;
            this.dgvAllListCustomers.AllowUserToOrderColumns = true;
            this.dgvAllListCustomers.AllowUserToResizeColumns = false;
            this.dgvAllListCustomers.AllowUserToResizeRows = false;
            this.dgvAllListCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllListCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllListCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllListCustomers.ContextMenuStrip = this.cmsCustomersManagement;
            this.dgvAllListCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllListCustomers.Location = new System.Drawing.Point(0, 40);
            this.dgvAllListCustomers.MultiSelect = false;
            this.dgvAllListCustomers.Name = "dgvAllListCustomers";
            this.dgvAllListCustomers.ReadOnly = true;
            this.dgvAllListCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllListCustomers.Size = new System.Drawing.Size(1250, 323);
            this.dgvAllListCustomers.TabIndex = 0;
            // 
            // cmsCustomersManagement
            // 
            this.cmsCustomersManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.photoToolStripMenuItem});
            this.cmsCustomersManagement.Name = "cmsProductsManagement";
            this.cmsCustomersManagement.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsCustomersManagement.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsCustomersManagement.RenderStyle.ColorTable = null;
            this.cmsCustomersManagement.RenderStyle.RoundedEdges = true;
            this.cmsCustomersManagement.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsCustomersManagement.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsCustomersManagement.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsCustomersManagement.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsCustomersManagement.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsCustomersManagement.Size = new System.Drawing.Size(108, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::ProductsAppWinForm.Properties.Resources.update;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::ProductsAppWinForm.Properties.Resources.multiply1;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // photoToolStripMenuItem
            // 
            this.photoToolStripMenuItem.Image = global::ProductsAppWinForm.Properties.Resources.picture;
            this.photoToolStripMenuItem.Name = "photoToolStripMenuItem";
            this.photoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.photoToolStripMenuItem.Text = "Photo";
            this.photoToolStripMenuItem.Click += new System.EventHandler(this.photoToolStripMenuItem_Click);
            // 
            // ToolTip1
            // 
            this.ToolTip1.AllowLinksHandling = true;
            this.ToolTip1.IsBalloon = true;
            this.ToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
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
            this.btnSearch.Location = new System.Drawing.Point(700, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 39);
            this.btnSearch.TabIndex = 34;
            this.ToolTip1.SetToolTip(this.btnSearch, "Search");
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MessageDialog1
            // 
            this.MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.MessageDialog1.Caption = null;
            this.MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.MessageDialog1.Parent = this;
            this.MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.MessageDialog1.Text = null;
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
            this.txtFirstName.Location = new System.Drawing.Point(288, 69);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(279, 43);
            this.txtFirstName.TabIndex = 30;
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
            this.txtLastName.Location = new System.Drawing.Point(619, 69);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(279, 43);
            this.txtLastName.TabIndex = 32;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(121, 69);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(49, 30);
            this.guna2HtmlLabel2.TabIndex = 38;
            this.guna2HtmlLabel2.Text = "Name";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(121, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(79, 30);
            this.guna2HtmlLabel1.TabIndex = 37;
            this.guna2HtmlLabel1.Text = "Countries";
            // 
            // rbSearchByName
            // 
            this.rbSearchByName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByName.CheckedState.BorderThickness = 0;
            this.rbSearchByName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbSearchByName.Location = new System.Drawing.Point(222, 79);
            this.rbSearchByName.Name = "rbSearchByName";
            this.rbSearchByName.Size = new System.Drawing.Size(20, 20);
            this.rbSearchByName.TabIndex = 36;
            this.rbSearchByName.Text = "guna2CustomRadioButton2";
            this.rbSearchByName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbSearchByName.UncheckedState.BorderThickness = 2;
            this.rbSearchByName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbSearchByName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbSearchByCountries
            // 
            this.rbSearchByCountries.Checked = true;
            this.rbSearchByCountries.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByCountries.CheckedState.BorderThickness = 0;
            this.rbSearchByCountries.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByCountries.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbSearchByCountries.Location = new System.Drawing.Point(222, 18);
            this.rbSearchByCountries.Name = "rbSearchByCountries";
            this.rbSearchByCountries.Size = new System.Drawing.Size(20, 20);
            this.rbSearchByCountries.TabIndex = 35;
            this.rbSearchByCountries.Text = "guna2CustomRadioButton1";
            this.rbSearchByCountries.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbSearchByCountries.UncheckedState.BorderThickness = 2;
            this.rbSearchByCountries.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbSearchByCountries.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cbCountries
            // 
            this.cbCountries.BackColor = System.Drawing.Color.Transparent;
            this.cbCountries.BorderRadius = 10;
            this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCountries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCountries.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCountries.ItemHeight = 30;
            this.cbCountries.Location = new System.Drawing.Point(288, 12);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(279, 36);
            this.cbCountries.Sorted = true;
            this.cbCountries.TabIndex = 33;
            // 
            // btnPrint
            // 
            this.btnPrint.Animated = true;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderRadius = 10;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::ProductsAppWinForm.Properties.Resources.printer2;
            this.btnPrint.Location = new System.Drawing.Point(664, 538);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(180, 45);
            this.btnPrint.TabIndex = 39;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseTransparentBackground = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmCustomersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1274, 608);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.rbSearchByName);
            this.Controls.Add(this.rbSearchByCountries);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbCountries);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnRefreshListCustomers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteAllCustomers);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gbListCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1088, 647);
            this.Name = "frmCustomersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Management";
            this.Load += new System.EventHandler(this.frmCustomersManagement_Load);
            this.gbListCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListCustomers)).EndInit();
            this.cmsCustomersManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnRefreshListCustomers;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllCustomers;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2GroupBox gbListCustomers;
        internal System.Windows.Forms.DataGridView dgvAllListCustomers;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsCustomersManagement;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photoToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbSearchByName;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbSearchByCountries;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
    }
}