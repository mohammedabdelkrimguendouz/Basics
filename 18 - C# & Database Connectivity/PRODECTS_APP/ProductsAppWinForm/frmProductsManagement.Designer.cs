namespace ProductsAppWinForm
{
    partial class frmProductsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductsManagement));
            this.gbListProducts = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllListProducts = new System.Windows.Forms.DataGridView();
            this.cmsProductsManagement = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSearchProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.rbSearchByCategory = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbSearchByName = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btnPrintListProducts = new Guna.UI2.WinForms.Guna2Button();
            this.gbListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListProducts)).BeginInit();
            this.cmsProductsManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListProducts
            // 
            this.gbListProducts.Controls.Add(this.dgvAllListProducts);
            this.gbListProducts.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListProducts.ForeColor = System.Drawing.Color.Black;
            this.gbListProducts.Location = new System.Drawing.Point(12, 136);
            this.gbListProducts.Name = "gbListProducts";
            this.gbListProducts.Size = new System.Drawing.Size(1048, 363);
            this.gbListProducts.TabIndex = 1;
            this.gbListProducts.Text = "List Products";
            // 
            // dgvAllListProducts
            // 
            this.dgvAllListProducts.AllowUserToAddRows = false;
            this.dgvAllListProducts.AllowUserToDeleteRows = false;
            this.dgvAllListProducts.AllowUserToOrderColumns = true;
            this.dgvAllListProducts.AllowUserToResizeColumns = false;
            this.dgvAllListProducts.AllowUserToResizeRows = false;
            this.dgvAllListProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllListProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllListProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllListProducts.ContextMenuStrip = this.cmsProductsManagement;
            this.dgvAllListProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllListProducts.Location = new System.Drawing.Point(0, 40);
            this.dgvAllListProducts.MultiSelect = false;
            this.dgvAllListProducts.Name = "dgvAllListProducts";
            this.dgvAllListProducts.ReadOnly = true;
            this.dgvAllListProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllListProducts.Size = new System.Drawing.Size(1048, 323);
            this.dgvAllListProducts.TabIndex = 0;
            // 
            // cmsProductsManagement
            // 
            this.cmsProductsManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.photoToolStripMenuItem});
            this.cmsProductsManagement.Name = "cmsProductsManagement";
            this.cmsProductsManagement.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsProductsManagement.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsProductsManagement.RenderStyle.ColorTable = null;
            this.cmsProductsManagement.RenderStyle.RoundedEdges = true;
            this.cmsProductsManagement.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsProductsManagement.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsProductsManagement.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsProductsManagement.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsProductsManagement.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsProductsManagement.Size = new System.Drawing.Size(108, 70);
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
            // cbSearchProduct
            // 
            this.cbSearchProduct.BackColor = System.Drawing.Color.Transparent;
            this.cbSearchProduct.BorderRadius = 10;
            this.cbSearchProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearchProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbSearchProduct.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearchProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbSearchProduct.ItemHeight = 30;
            this.cbSearchProduct.Location = new System.Drawing.Point(464, 39);
            this.cbSearchProduct.Name = "cbSearchProduct";
            this.cbSearchProduct.Size = new System.Drawing.Size(260, 36);
            this.cbSearchProduct.Sorted = true;
            this.cbSearchProduct.TabIndex = 2;
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
            this.btnSearch.Location = new System.Drawing.Point(768, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 39);
            this.btnSearch.TabIndex = 13;
            this.ToolTip1.SetToolTip(this.btnSearch, "Search");
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefreshProducts
            // 
            this.btnRefreshProducts.Animated = true;
            this.btnRefreshProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshProducts.BorderRadius = 10;
            this.btnRefreshProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefreshProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProducts.ForeColor = System.Drawing.Color.White;
            this.btnRefreshProducts.Image = global::ProductsAppWinForm.Properties.Resources.icons8_reset_481;
            this.btnRefreshProducts.Location = new System.Drawing.Point(12, 91);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(36, 39);
            this.btnRefreshProducts.TabIndex = 12;
            this.ToolTip1.SetToolTip(this.btnRefreshProducts, "List Products");
            this.btnRefreshProducts.UseTransparentBackground = true;
            this.btnRefreshProducts.Click += new System.EventHandler(this.btnRefreshProducts_Click);
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
            this.btnExit.Location = new System.Drawing.Point(12, 537);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 45);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDeleteAllProducts
            // 
            this.btnDeleteAllProducts.Animated = true;
            this.btnDeleteAllProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAllProducts.BorderRadius = 10;
            this.btnDeleteAllProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteAllProducts.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllProducts.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAllProducts.Image = global::ProductsAppWinForm.Properties.Resources._9004852_trash_delete_bin_remove_icon;
            this.btnDeleteAllProducts.Location = new System.Drawing.Point(301, 537);
            this.btnDeleteAllProducts.Name = "btnDeleteAllProducts";
            this.btnDeleteAllProducts.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteAllProducts.TabIndex = 8;
            this.btnDeleteAllProducts.Text = "DeleteAll";
            this.btnDeleteAllProducts.UseTransparentBackground = true;
            this.btnDeleteAllProducts.Click += new System.EventHandler(this.btnDeleteAllProducts_Click);
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
            this.btnAddNew.Location = new System.Drawing.Point(879, 537);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(180, 45);
            this.btnAddNew.TabIndex = 7;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseTransparentBackground = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // rbSearchByCategory
            // 
            this.rbSearchByCategory.Checked = true;
            this.rbSearchByCategory.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByCategory.CheckedState.BorderThickness = 0;
            this.rbSearchByCategory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByCategory.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbSearchByCategory.Location = new System.Drawing.Point(392, 27);
            this.rbSearchByCategory.Name = "rbSearchByCategory";
            this.rbSearchByCategory.Size = new System.Drawing.Size(20, 20);
            this.rbSearchByCategory.TabIndex = 14;
            this.rbSearchByCategory.Text = "guna2CustomRadioButton1";
            this.rbSearchByCategory.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbSearchByCategory.UncheckedState.BorderThickness = 2;
            this.rbSearchByCategory.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbSearchByCategory.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbSearchByCategory.CheckedChanged += new System.EventHandler(this.rbSearchByCategory_CheckedChanged);
            // 
            // rbSearchByName
            // 
            this.rbSearchByName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByName.CheckedState.BorderThickness = 0;
            this.rbSearchByName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbSearchByName.Location = new System.Drawing.Point(392, 67);
            this.rbSearchByName.Name = "rbSearchByName";
            this.rbSearchByName.Size = new System.Drawing.Size(20, 20);
            this.rbSearchByName.TabIndex = 15;
            this.rbSearchByName.Text = "guna2CustomRadioButton2";
            this.rbSearchByName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbSearchByName.UncheckedState.BorderThickness = 2;
            this.rbSearchByName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbSearchByName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbSearchByName.CheckedChanged += new System.EventHandler(this.rbSearchByName_CheckedChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(273, 25);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(84, 30);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Categories";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(273, 65);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(49, 30);
            this.guna2HtmlLabel2.TabIndex = 17;
            this.guna2HtmlLabel2.Text = "Name";
            // 
            // ToolTip1
            // 
            this.ToolTip1.AllowLinksHandling = true;
            this.ToolTip1.IsBalloon = true;
            this.ToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // btnPrintListProducts
            // 
            this.btnPrintListProducts.Animated = true;
            this.btnPrintListProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintListProducts.BorderRadius = 10;
            this.btnPrintListProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintListProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintListProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintListProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintListProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintListProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrintListProducts.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.btnPrintListProducts.ForeColor = System.Drawing.Color.White;
            this.btnPrintListProducts.Image = global::ProductsAppWinForm.Properties.Resources.printer2;
            this.btnPrintListProducts.Location = new System.Drawing.Point(590, 537);
            this.btnPrintListProducts.Name = "btnPrintListProducts";
            this.btnPrintListProducts.Size = new System.Drawing.Size(180, 45);
            this.btnPrintListProducts.TabIndex = 41;
            this.btnPrintListProducts.Text = "Print";
            this.btnPrintListProducts.UseTransparentBackground = true;
            this.btnPrintListProducts.Click += new System.EventHandler(this.btnPrintListProducts_Click);
            // 
            // frmProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.btnPrintListProducts);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.rbSearchByName);
            this.Controls.Add(this.rbSearchByCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefreshProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteAllProducts);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.cbSearchProduct);
            this.Controls.Add(this.gbListProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1088, 647);
            this.MinimumSize = new System.Drawing.Size(1088, 647);
            this.Name = "frmProductsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Management";
            this.Load += new System.EventHandler(this.frmProductsManagement_Load);
            this.gbListProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListProducts)).EndInit();
            this.cmsProductsManagement.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbListProducts;
        internal System.Windows.Forms.DataGridView dgvAllListProducts;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchProduct;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsProductsManagement;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photoToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllProducts;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
        private Guna.UI2.WinForms.Guna2Button btnRefreshProducts;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbSearchByName;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbSearchByCategory;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip1;
        private Guna.UI2.WinForms.Guna2Button btnPrintListProducts;
    }
}