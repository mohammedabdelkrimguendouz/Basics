namespace ProductsAppWinForm
{
    partial class frmUsersManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManagement));
            this.gbListUsers = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvAllListUsers = new System.Windows.Forms.DataGridView();
            this.cmsUsersManagementListUsers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.btnListLogInRegisters = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshListUsers = new Guna.UI2.WinForms.Guna2Button();
            this.gbListLogInRegisters = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvListLogInRegisters = new System.Windows.Forms.DataGridView();
            this.cmsUsersManagementListLogInRegister = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDeleteAllListLogInRegister = new Guna.UI2.WinForms.Guna2Button();
            this.MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.txtSearchByUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPrintListUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintListLogInRegisters = new Guna.UI2.WinForms.Guna2Button();
            this.gbListUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListUsers)).BeginInit();
            this.cmsUsersManagementListUsers.SuspendLayout();
            this.gbListLogInRegisters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLogInRegisters)).BeginInit();
            this.cmsUsersManagementListLogInRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListUsers
            // 
            this.gbListUsers.Controls.Add(this.dgvAllListUsers);
            this.gbListUsers.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListUsers.ForeColor = System.Drawing.Color.Black;
            this.gbListUsers.Location = new System.Drawing.Point(12, 156);
            this.gbListUsers.Name = "gbListUsers";
            this.gbListUsers.Size = new System.Drawing.Size(496, 452);
            this.gbListUsers.TabIndex = 2;
            this.gbListUsers.Text = "List Users";
            // 
            // dgvAllListUsers
            // 
            this.dgvAllListUsers.AllowUserToAddRows = false;
            this.dgvAllListUsers.AllowUserToDeleteRows = false;
            this.dgvAllListUsers.AllowUserToOrderColumns = true;
            this.dgvAllListUsers.AllowUserToResizeColumns = false;
            this.dgvAllListUsers.AllowUserToResizeRows = false;
            this.dgvAllListUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllListUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAllListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllListUsers.ContextMenuStrip = this.cmsUsersManagementListUsers;
            this.dgvAllListUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllListUsers.Location = new System.Drawing.Point(0, 40);
            this.dgvAllListUsers.MultiSelect = false;
            this.dgvAllListUsers.Name = "dgvAllListUsers";
            this.dgvAllListUsers.ReadOnly = true;
            this.dgvAllListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllListUsers.Size = new System.Drawing.Size(496, 412);
            this.dgvAllListUsers.TabIndex = 0;
            // 
            // cmsUsersManagementListUsers
            // 
            this.cmsUsersManagementListUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsUsersManagementListUsers.Name = "cmsProductsManagement";
            this.cmsUsersManagementListUsers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsUsersManagementListUsers.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsUsersManagementListUsers.RenderStyle.ColorTable = null;
            this.cmsUsersManagementListUsers.RenderStyle.RoundedEdges = true;
            this.cmsUsersManagementListUsers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsUsersManagementListUsers.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsUsersManagementListUsers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsUsersManagementListUsers.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsUsersManagementListUsers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsUsersManagementListUsers.Size = new System.Drawing.Size(108, 48);
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
            // ToolTip1
            // 
            this.ToolTip1.AllowLinksHandling = true;
            this.ToolTip1.IsBalloon = true;
            this.ToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // btnListLogInRegisters
            // 
            this.btnListLogInRegisters.Animated = true;
            this.btnListLogInRegisters.BackColor = System.Drawing.Color.Transparent;
            this.btnListLogInRegisters.BorderRadius = 10;
            this.btnListLogInRegisters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListLogInRegisters.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnListLogInRegisters.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnListLogInRegisters.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnListLogInRegisters.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnListLogInRegisters.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnListLogInRegisters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListLogInRegisters.ForeColor = System.Drawing.Color.White;
            this.btnListLogInRegisters.Image = global::ProductsAppWinForm.Properties.Resources.icons8_reset_481;
            this.btnListLogInRegisters.Location = new System.Drawing.Point(1162, 109);
            this.btnListLogInRegisters.Name = "btnListLogInRegisters";
            this.btnListLogInRegisters.Size = new System.Drawing.Size(36, 41);
            this.btnListLogInRegisters.TabIndex = 16;
            this.ToolTip1.SetToolTip(this.btnListLogInRegisters, "Refrech List Log In Registers");
            this.btnListLogInRegisters.UseTransparentBackground = true;
            this.btnListLogInRegisters.Click += new System.EventHandler(this.btnListLogInRegisters_Click);
            // 
            // btnRefreshListUsers
            // 
            this.btnRefreshListUsers.Animated = true;
            this.btnRefreshListUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshListUsers.BorderRadius = 10;
            this.btnRefreshListUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshListUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshListUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefreshListUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefreshListUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefreshListUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRefreshListUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshListUsers.ForeColor = System.Drawing.Color.White;
            this.btnRefreshListUsers.Image = global::ProductsAppWinForm.Properties.Resources.icons8_reset_481;
            this.btnRefreshListUsers.Location = new System.Drawing.Point(12, 109);
            this.btnRefreshListUsers.Name = "btnRefreshListUsers";
            this.btnRefreshListUsers.Size = new System.Drawing.Size(36, 41);
            this.btnRefreshListUsers.TabIndex = 13;
            this.ToolTip1.SetToolTip(this.btnRefreshListUsers, "Refrech List Users");
            this.btnRefreshListUsers.UseTransparentBackground = true;
            this.btnRefreshListUsers.Click += new System.EventHandler(this.btnRefreshListUsers_Click);
            // 
            // gbListLogInRegisters
            // 
            this.gbListLogInRegisters.Controls.Add(this.dgvListLogInRegisters);
            this.gbListLogInRegisters.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListLogInRegisters.ForeColor = System.Drawing.Color.Black;
            this.gbListLogInRegisters.Location = new System.Drawing.Point(702, 156);
            this.gbListLogInRegisters.Name = "gbListLogInRegisters";
            this.gbListLogInRegisters.Size = new System.Drawing.Size(496, 452);
            this.gbListLogInRegisters.TabIndex = 14;
            this.gbListLogInRegisters.Text = "List Log In Registers";
            // 
            // dgvListLogInRegisters
            // 
            this.dgvListLogInRegisters.AllowUserToAddRows = false;
            this.dgvListLogInRegisters.AllowUserToDeleteRows = false;
            this.dgvListLogInRegisters.AllowUserToOrderColumns = true;
            this.dgvListLogInRegisters.AllowUserToResizeColumns = false;
            this.dgvListLogInRegisters.AllowUserToResizeRows = false;
            this.dgvListLogInRegisters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListLogInRegisters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListLogInRegisters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLogInRegisters.ContextMenuStrip = this.cmsUsersManagementListLogInRegister;
            this.dgvListLogInRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListLogInRegisters.Location = new System.Drawing.Point(0, 40);
            this.dgvListLogInRegisters.MultiSelect = false;
            this.dgvListLogInRegisters.Name = "dgvListLogInRegisters";
            this.dgvListLogInRegisters.ReadOnly = true;
            this.dgvListLogInRegisters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListLogInRegisters.Size = new System.Drawing.Size(496, 412);
            this.dgvListLogInRegisters.TabIndex = 0;
            // 
            // cmsUsersManagementListLogInRegister
            // 
            this.cmsUsersManagementListLogInRegister.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.cmsUsersManagementListLogInRegister.Name = "cmsProductsManagement";
            this.cmsUsersManagementListLogInRegister.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsUsersManagementListLogInRegister.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsUsersManagementListLogInRegister.RenderStyle.ColorTable = null;
            this.cmsUsersManagementListLogInRegister.RenderStyle.RoundedEdges = true;
            this.cmsUsersManagementListLogInRegister.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsUsersManagementListLogInRegister.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsUsersManagementListLogInRegister.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsUsersManagementListLogInRegister.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsUsersManagementListLogInRegister.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsUsersManagementListLogInRegister.Size = new System.Drawing.Size(108, 26);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::ProductsAppWinForm.Properties.Resources.multiply1;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "Delete";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
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
            this.btnAddNew.Image = global::ProductsAppWinForm.Properties.Resources.icons8_add_user_male_481;
            this.btnAddNew.Location = new System.Drawing.Point(89, 105);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(140, 45);
            this.btnAddNew.TabIndex = 18;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseTransparentBackground = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
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
            this.btnExit.Location = new System.Drawing.Point(516, 205);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 45);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::ProductsAppWinForm.Properties.Resources.icons8_management_482;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(514, 314);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(182, 200);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 15;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnDeleteAllListLogInRegister
            // 
            this.btnDeleteAllListLogInRegister.Animated = true;
            this.btnDeleteAllListLogInRegister.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAllListLogInRegister.BorderRadius = 10;
            this.btnDeleteAllListLogInRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAllListLogInRegister.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllListLogInRegister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteAllListLogInRegister.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteAllListLogInRegister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteAllListLogInRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDeleteAllListLogInRegister.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAllListLogInRegister.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAllListLogInRegister.Image = global::ProductsAppWinForm.Properties.Resources._9004852_trash_delete_bin_remove_icon;
            this.btnDeleteAllListLogInRegister.Location = new System.Drawing.Point(978, 105);
            this.btnDeleteAllListLogInRegister.Name = "btnDeleteAllListLogInRegister";
            this.btnDeleteAllListLogInRegister.Size = new System.Drawing.Size(148, 45);
            this.btnDeleteAllListLogInRegister.TabIndex = 20;
            this.btnDeleteAllListLogInRegister.Text = "DeleteAll";
            this.btnDeleteAllListLogInRegister.UseTransparentBackground = true;
            this.btnDeleteAllListLogInRegister.Click += new System.EventHandler(this.btnDeleteAllListLogInRegister_Click);
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
            // txtSearchByUserName
            // 
            this.txtSearchByUserName.BorderRadius = 15;
            this.txtSearchByUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchByUserName.DefaultText = "";
            this.txtSearchByUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchByUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchByUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchByUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByUserName.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchByUserName.Location = new System.Drawing.Point(425, 34);
            this.txtSearchByUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchByUserName.Name = "txtSearchByUserName";
            this.txtSearchByUserName.PasswordChar = '\0';
            this.txtSearchByUserName.PlaceholderText = "Search By User Name";
            this.txtSearchByUserName.SelectedText = "";
            this.txtSearchByUserName.Size = new System.Drawing.Size(389, 67);
            this.txtSearchByUserName.TabIndex = 22;
            this.txtSearchByUserName.TextChanged += new System.EventHandler(this.txtSearchByUserName_TextChanged);
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
            this.btnPrintListUsers.Location = new System.Drawing.Point(262, 105);
            this.btnPrintListUsers.Name = "btnPrintListUsers";
            this.btnPrintListUsers.Size = new System.Drawing.Size(180, 45);
            this.btnPrintListUsers.TabIndex = 40;
            this.btnPrintListUsers.Text = "Print";
            this.btnPrintListUsers.UseTransparentBackground = true;
            this.btnPrintListUsers.Click += new System.EventHandler(this.btnPrintListUsers_Click);
            // 
            // btnPrintListLogInRegisters
            // 
            this.btnPrintListLogInRegisters.Animated = true;
            this.btnPrintListLogInRegisters.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintListLogInRegisters.BorderRadius = 10;
            this.btnPrintListLogInRegisters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintListLogInRegisters.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintListLogInRegisters.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrintListLogInRegisters.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrintListLogInRegisters.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrintListLogInRegisters.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrintListLogInRegisters.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.btnPrintListLogInRegisters.ForeColor = System.Drawing.Color.White;
            this.btnPrintListLogInRegisters.Image = global::ProductsAppWinForm.Properties.Resources.printer2;
            this.btnPrintListLogInRegisters.Location = new System.Drawing.Point(766, 105);
            this.btnPrintListLogInRegisters.Name = "btnPrintListLogInRegisters";
            this.btnPrintListLogInRegisters.Size = new System.Drawing.Size(180, 45);
            this.btnPrintListLogInRegisters.TabIndex = 41;
            this.btnPrintListLogInRegisters.Text = "Print";
            this.btnPrintListLogInRegisters.UseTransparentBackground = true;
            this.btnPrintListLogInRegisters.Click += new System.EventHandler(this.btnPrintListLogInRegisters_Click);
            // 
            // frmUsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1216, 620);
            this.Controls.Add(this.btnPrintListLogInRegisters);
            this.Controls.Add(this.btnPrintListUsers);
            this.Controls.Add(this.txtSearchByUserName);
            this.Controls.Add(this.btnDeleteAllListLogInRegister);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnListLogInRegisters);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.gbListLogInRegisters);
            this.Controls.Add(this.btnRefreshListUsers);
            this.Controls.Add(this.gbListUsers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1232, 659);
            this.MinimumSize = new System.Drawing.Size(1232, 659);
            this.Name = "frmUsersManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users Management";
            this.Load += new System.EventHandler(this.frmUsersManagement_Load);
            this.gbListUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllListUsers)).EndInit();
            this.cmsUsersManagementListUsers.ResumeLayout(false);
            this.gbListLogInRegisters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLogInRegisters)).EndInit();
            this.cmsUsersManagementListLogInRegister.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbListUsers;
        internal System.Windows.Forms.DataGridView dgvAllListUsers;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip1;
        private Guna.UI2.WinForms.Guna2Button btnRefreshListUsers;
        private Guna.UI2.WinForms.Guna2GroupBox gbListLogInRegisters;
        internal System.Windows.Forms.DataGridView dgvListLogInRegisters;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnListLogInRegisters;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2Button btnDeleteAllListLogInRegister;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsUsersManagementListUsers;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsUsersManagementListLogInRegister;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private Guna.UI2.WinForms.Guna2MessageDialog MessageDialog1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchByUserName;
        private Guna.UI2.WinForms.Guna2Button btnPrintListLogInRegisters;
        private Guna.UI2.WinForms.Guna2Button btnPrintListUsers;
    }
}