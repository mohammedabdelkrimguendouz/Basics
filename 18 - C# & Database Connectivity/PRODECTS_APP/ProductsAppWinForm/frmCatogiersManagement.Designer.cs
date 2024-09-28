namespace ProductsAppWinForm
{
    partial class frmCatogiersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatogiersManagement));
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteAllProducts = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.cmsCatogiersManagement = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbListProducts = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllListCatogiers = new System.Windows.Forms.DataGridView();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnPrintListUsers = new Guna.UI2.WinForms.Guna2Button();
            this.cmsCatogiersManagement.SuspendLayout();
            this.gbListProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListCatogiers)).BeginInit();
            this.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(512, 266);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 45);
            this.btnExit.TabIndex = 13;
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
            this.btnDeleteAllProducts.Location = new System.Drawing.Point(512, 118);
            this.btnDeleteAllProducts.Name = "btnDeleteAllProducts";
            this.btnDeleteAllProducts.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteAllProducts.TabIndex = 12;
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
            this.btnAddNew.Location = new System.Drawing.Point(512, 44);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(180, 45);
            this.btnAddNew.TabIndex = 11;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseTransparentBackground = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // cmsCatogiersManagement
            // 
            this.cmsCatogiersManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsCatogiersManagement.Name = "cmsProductsManagement";
            this.cmsCatogiersManagement.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsCatogiersManagement.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsCatogiersManagement.RenderStyle.ColorTable = null;
            this.cmsCatogiersManagement.RenderStyle.RoundedEdges = true;
            this.cmsCatogiersManagement.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsCatogiersManagement.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsCatogiersManagement.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsCatogiersManagement.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsCatogiersManagement.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsCatogiersManagement.Size = new System.Drawing.Size(108, 48);
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
            // gbListProducts
            // 
            this.gbListProducts.Controls.Add(this.dgvAllListCatogiers);
            this.gbListProducts.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListProducts.ForeColor = System.Drawing.Color.Black;
            this.gbListProducts.Location = new System.Drawing.Point(0, 44);
            this.gbListProducts.Name = "gbListProducts";
            this.gbListProducts.Size = new System.Drawing.Size(488, 279);
            this.gbListProducts.TabIndex = 15;
            this.gbListProducts.Text = "List Catogiers";
            // 
            // dgvAllListCatogiers
            // 
            this.dgvAllListCatogiers.AllowUserToAddRows = false;
            this.dgvAllListCatogiers.AllowUserToDeleteRows = false;
            this.dgvAllListCatogiers.AllowUserToOrderColumns = true;
            this.dgvAllListCatogiers.AllowUserToResizeColumns = false;
            this.dgvAllListCatogiers.AllowUserToResizeRows = false;
            this.dgvAllListCatogiers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllListCatogiers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllListCatogiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllListCatogiers.ContextMenuStrip = this.cmsCatogiersManagement;
            this.dgvAllListCatogiers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllListCatogiers.Location = new System.Drawing.Point(0, 40);
            this.dgvAllListCatogiers.MultiSelect = false;
            this.dgvAllListCatogiers.Name = "dgvAllListCatogiers";
            this.dgvAllListCatogiers.ReadOnly = true;
            this.dgvAllListCatogiers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllListCatogiers.Size = new System.Drawing.Size(488, 239);
            this.dgvAllListCatogiers.TabIndex = 0;
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
            // btnPrintListUsers
            // 
            this.btnPrintListUsers.Animated = true;
            this.btnPrintListUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintListUsers.BorderRadius = 10;
            this.btnPrintListUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintListUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintListUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintListUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintListUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintListUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrintListUsers.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.btnPrintListUsers.ForeColor = System.Drawing.Color.White;
            this.btnPrintListUsers.Image = global::ProductsAppWinForm.Properties.Resources.printer2;
            this.btnPrintListUsers.Location = new System.Drawing.Point(512, 192);
            this.btnPrintListUsers.Name = "btnPrintListUsers";
            this.btnPrintListUsers.Size = new System.Drawing.Size(180, 45);
            this.btnPrintListUsers.TabIndex = 41;
            this.btnPrintListUsers.Text = "Print";
            this.btnPrintListUsers.UseTransparentBackground = true;
            this.btnPrintListUsers.Click += new System.EventHandler(this.btnPrintListUsers_Click);
            // 
            // frmCatogiersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 370);
            this.Controls.Add(this.btnPrintListUsers);
            this.Controls.Add(this.gbListProducts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDeleteAllProducts);
            this.Controls.Add(this.btnAddNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(742, 409);
            this.MinimumSize = new System.Drawing.Size(742, 409);
            this.Name = "frmCatogiersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catogiers  Management";
            this.Load += new System.EventHandler(this.frmCatogiersManagement_Load);
            this.cmsCatogiersManagement.ResumeLayout(false);
            this.gbListProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListCatogiers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllProducts;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsCatogiersManagement;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2GroupBox gbListProducts;
        internal System.Windows.Forms.DataGridView dgvAllListCatogiers;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
        private Guna.UI2.WinForms.Guna2Button btnPrintListUsers;
    }
}