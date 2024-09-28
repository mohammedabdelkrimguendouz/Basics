namespace ProductsAppWinForm
{
    partial class frmListProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListProducts));
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbSearchByName = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.rbSearchByCategory = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshProducts = new Guna.UI2.WinForms.Guna2Button();
            this.cbSearchProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gbListProducts = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllListProducts = new System.Windows.Forms.DataGridView();
            this.ToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btnRefrechListProducts = new Guna.UI2.WinForms.Guna2Button();
            this.gbListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(273, 48);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(49, 30);
            this.guna2HtmlLabel2.TabIndex = 25;
            this.guna2HtmlLabel2.Text = "Name";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(273, 8);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(84, 30);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Categories";
            // 
            // rbSearchByName
            // 
            this.rbSearchByName.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByName.CheckedState.BorderThickness = 0;
            this.rbSearchByName.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByName.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbSearchByName.Location = new System.Drawing.Point(392, 50);
            this.rbSearchByName.Name = "rbSearchByName";
            this.rbSearchByName.Size = new System.Drawing.Size(20, 20);
            this.rbSearchByName.TabIndex = 23;
            this.rbSearchByName.Text = "guna2CustomRadioButton2";
            this.rbSearchByName.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbSearchByName.UncheckedState.BorderThickness = 2;
            this.rbSearchByName.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbSearchByName.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbSearchByName.CheckedChanged += new System.EventHandler(this.rbSearchByName_CheckedChanged);
            // 
            // rbSearchByCategory
            // 
            this.rbSearchByCategory.Checked = true;
            this.rbSearchByCategory.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByCategory.CheckedState.BorderThickness = 0;
            this.rbSearchByCategory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbSearchByCategory.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbSearchByCategory.Location = new System.Drawing.Point(392, 10);
            this.rbSearchByCategory.Name = "rbSearchByCategory";
            this.rbSearchByCategory.Size = new System.Drawing.Size(20, 20);
            this.rbSearchByCategory.TabIndex = 22;
            this.rbSearchByCategory.Text = "guna2CustomRadioButton1";
            this.rbSearchByCategory.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbSearchByCategory.UncheckedState.BorderThickness = 2;
            this.rbSearchByCategory.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbSearchByCategory.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rbSearchByCategory.CheckedChanged += new System.EventHandler(this.rbSearchByCategory_CheckedChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(768, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 39);
            this.btnSearch.TabIndex = 21;
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
            this.btnRefreshProducts.Location = new System.Drawing.Point(-124, 54);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(36, 39);
            this.btnRefreshProducts.TabIndex = 20;
            this.btnRefreshProducts.UseTransparentBackground = true;
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
            this.cbSearchProduct.Location = new System.Drawing.Point(464, 22);
            this.cbSearchProduct.Name = "cbSearchProduct";
            this.cbSearchProduct.Size = new System.Drawing.Size(260, 36);
            this.cbSearchProduct.Sorted = true;
            this.cbSearchProduct.TabIndex = 19;
            // 
            // gbListProducts
            // 
            this.gbListProducts.Controls.Add(this.dgvAllListProducts);
            this.gbListProducts.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListProducts.ForeColor = System.Drawing.Color.Black;
            this.gbListProducts.Location = new System.Drawing.Point(10, 99);
            this.gbListProducts.Name = "gbListProducts";
            this.gbListProducts.Size = new System.Drawing.Size(1048, 497);
            this.gbListProducts.TabIndex = 18;
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
            this.dgvAllListProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllListProducts.Location = new System.Drawing.Point(0, 40);
            this.dgvAllListProducts.MultiSelect = false;
            this.dgvAllListProducts.Name = "dgvAllListProducts";
            this.dgvAllListProducts.ReadOnly = true;
            this.dgvAllListProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllListProducts.Size = new System.Drawing.Size(1048, 457);
            this.dgvAllListProducts.TabIndex = 0;
            this.dgvAllListProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllListProducts_CellDoubleClick);
            // 
            // ToolTip1
            // 
            this.ToolTip1.AllowLinksHandling = true;
            this.ToolTip1.IsBalloon = true;
            this.ToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // btnRefrechListProducts
            // 
            this.btnRefrechListProducts.Animated = true;
            this.btnRefrechListProducts.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrechListProducts.BorderRadius = 10;
            this.btnRefrechListProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrechListProducts.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefrechListProducts.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefrechListProducts.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefrechListProducts.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefrechListProducts.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefrechListProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrechListProducts.ForeColor = System.Drawing.Color.White;
            this.btnRefrechListProducts.Image = global::ProductsAppWinForm.Properties.Resources.icons8_reset_481;
            this.btnRefrechListProducts.Location = new System.Drawing.Point(12, 54);
            this.btnRefrechListProducts.Name = "btnRefrechListProducts";
            this.btnRefrechListProducts.Size = new System.Drawing.Size(36, 39);
            this.btnRefrechListProducts.TabIndex = 26;
            this.ToolTip1.SetToolTip(this.btnRefrechListProducts, "Refrech List Products");
            this.btnRefrechListProducts.UseTransparentBackground = true;
            this.btnRefrechListProducts.Click += new System.EventHandler(this.btnRefrechListProducts_Click);
            // 
            // frmListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.btnRefrechListProducts);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.rbSearchByName);
            this.Controls.Add(this.rbSearchByCategory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefreshProducts);
            this.Controls.Add(this.cbSearchProduct);
            this.Controls.Add(this.gbListProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1088, 647);
            this.MinimumSize = new System.Drawing.Size(1088, 647);
            this.Name = "frmListProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Products";
            this.Load += new System.EventHandler(this.frmListProducts_Load);
            this.gbListProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbSearchByName;
        private Guna.UI2.WinForms.Guna2CustomRadioButton rbSearchByCategory;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnRefreshProducts;
        private Guna.UI2.WinForms.Guna2ComboBox cbSearchProduct;
        private Guna.UI2.WinForms.Guna2GroupBox gbListProducts;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip1;
        private Guna.UI2.WinForms.Guna2Button btnRefrechListProducts;
        public System.Windows.Forms.DataGridView dgvAllListProducts;
    }
}