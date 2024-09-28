namespace BankSystemWinApp
{
    partial class frmSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSystem));
            this.tcSystem = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpClients = new System.Windows.Forms.TabPage();
            this.btnAddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearchClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClearAllClients = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAllClients = new System.Windows.Forms.DataGridView();
            this.cmsClients = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.btnSingOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchLogInByDate = new Guna.UI2.WinForms.Guna2Button();
            this.dtpSearchLogInRegister = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnClearRegisterLogIn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearchUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelLogInRegisters = new System.Windows.Forms.Panel();
            this.dgvAllLogInRegisters = new System.Windows.Forms.DataGridView();
            this.panelListUsers = new System.Windows.Forms.Panel();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.cmsUsers = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcSystem.SuspendLayout();
            this.tpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
            this.cmsClients.SuspendLayout();
            this.tpUsers.SuspendLayout();
            this.panelLogInRegisters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLogInRegisters)).BeginInit();
            this.panelListUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.cmsUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcSystem
            // 
            this.tcSystem.Controls.Add(this.tpClients);
            this.tcSystem.Controls.Add(this.tpUsers);
            this.tcSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSystem.HotTrack = true;
            this.tcSystem.ItemSize = new System.Drawing.Size(180, 40);
            this.tcSystem.Location = new System.Drawing.Point(0, 0);
            this.tcSystem.Name = "tcSystem";
            this.tcSystem.SelectedIndex = 0;
            this.tcSystem.Size = new System.Drawing.Size(1257, 536);
            this.tcSystem.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tcSystem.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSystem.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSystem.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tcSystem.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tcSystem.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tcSystem.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSystem.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSystem.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tcSystem.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSystem.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tcSystem.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tcSystem.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tcSystem.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tcSystem.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tcSystem.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tcSystem.TabIndex = 0;
            this.tcSystem.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tcSystem.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpClients
            // 
            this.tpClients.Controls.Add(this.btnAddNewClient);
            this.tpClients.Controls.Add(this.guna2HtmlLabel2);
            this.tpClients.Controls.Add(this.txtSearchClient);
            this.tpClients.Controls.Add(this.btnClearAllClients);
            this.tpClients.Controls.Add(this.dgvAllClients);
            this.tpClients.Location = new System.Drawing.Point(4, 44);
            this.tpClients.Name = "tpClients";
            this.tpClients.Padding = new System.Windows.Forms.Padding(3);
            this.tpClients.Size = new System.Drawing.Size(1249, 488);
            this.tpClients.TabIndex = 0;
            this.tpClients.Text = "Clients";
            this.tpClients.UseVisualStyleBackColor = true;
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Animated = true;
            this.btnAddNewClient.BorderRadius = 10;
            this.btnAddNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewClient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewClient.ForeColor = System.Drawing.Color.Black;
            this.btnAddNewClient.IndicateFocus = true;
            this.btnAddNewClient.Location = new System.Drawing.Point(198, 21);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(140, 39);
            this.btnAddNewClient.TabIndex = 10;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseTransparentBackground = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(603, 6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(63, 26);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Search";
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Animated = true;
            this.txtSearchClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSearchClient.BorderRadius = 10;
            this.txtSearchClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchClient.DefaultText = "";
            this.txtSearchClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClient.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSearchClient.ForeColor = System.Drawing.Color.Black;
            this.txtSearchClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchClient.Location = new System.Drawing.Point(528, 40);
            this.txtSearchClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.PasswordChar = '\0';
            this.txtSearchClient.PlaceholderText = "Account Number";
            this.txtSearchClient.SelectedText = "";
            this.txtSearchClient.Size = new System.Drawing.Size(229, 48);
            this.txtSearchClient.TabIndex = 8;
            this.txtSearchClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // btnClearAllClients
            // 
            this.btnClearAllClients.Animated = true;
            this.btnClearAllClients.BorderRadius = 10;
            this.btnClearAllClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAllClients.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearAllClients.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearAllClients.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearAllClients.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearAllClients.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearAllClients.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearAllClients.ForeColor = System.Drawing.Color.White;
            this.btnClearAllClients.IndicateFocus = true;
            this.btnClearAllClients.Location = new System.Drawing.Point(912, 21);
            this.btnClearAllClients.Name = "btnClearAllClients";
            this.btnClearAllClients.Size = new System.Drawing.Size(140, 39);
            this.btnClearAllClients.TabIndex = 7;
            this.btnClearAllClients.Text = "Clear All Clients ";
            this.btnClearAllClients.UseTransparentBackground = true;
            this.btnClearAllClients.Click += new System.EventHandler(this.btnClearAllClients_Click);
            // 
            // dgvAllClients
            // 
            this.dgvAllClients.AllowUserToAddRows = false;
            this.dgvAllClients.AllowUserToDeleteRows = false;
            this.dgvAllClients.AllowUserToResizeColumns = false;
            this.dgvAllClients.AllowUserToResizeRows = false;
            this.dgvAllClients.ColumnHeadersHeight = 25;
            this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAllClients.ContextMenuStrip = this.cmsClients;
            this.dgvAllClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvAllClients.Location = new System.Drawing.Point(3, 95);
            this.dgvAllClients.MultiSelect = false;
            this.dgvAllClients.Name = "dgvAllClients";
            this.dgvAllClients.ReadOnly = true;
            this.dgvAllClients.Size = new System.Drawing.Size(1243, 390);
            this.dgvAllClients.TabIndex = 0;
            // 
            // cmsClients
            // 
            this.cmsClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.debositToolStripMenuItem,
            this.withdrawToolStripMenuItem});
            this.cmsClients.Name = "cmsClients";
            this.cmsClients.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsClients.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsClients.RenderStyle.ColorTable = null;
            this.cmsClients.RenderStyle.RoundedEdges = true;
            this.cmsClients.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsClients.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsClients.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsClients.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsClients.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsClients.Size = new System.Drawing.Size(126, 92);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.btnSingOut);
            this.tpUsers.Controls.Add(this.btnAddUser);
            this.tpUsers.Controls.Add(this.btnSearchLogInByDate);
            this.tpUsers.Controls.Add(this.dtpSearchLogInRegister);
            this.tpUsers.Controls.Add(this.btnClearRegisterLogIn);
            this.tpUsers.Controls.Add(this.guna2HtmlLabel1);
            this.tpUsers.Controls.Add(this.txtSearchUser);
            this.tpUsers.Controls.Add(this.panelLogInRegisters);
            this.tpUsers.Controls.Add(this.panelListUsers);
            this.tpUsers.Controls.Add(this.pictureBox1);
            this.tpUsers.Location = new System.Drawing.Point(4, 44);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(1249, 488);
            this.tpUsers.TabIndex = 1;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // btnSingOut
            // 
            this.btnSingOut.Animated = true;
            this.btnSingOut.BorderRadius = 10;
            this.btnSingOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSingOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSingOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSingOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSingOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSingOut.FillColor = System.Drawing.Color.Black;
            this.btnSingOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSingOut.ForeColor = System.Drawing.Color.White;
            this.btnSingOut.IndicateFocus = true;
            this.btnSingOut.Location = new System.Drawing.Point(544, 6);
            this.btnSingOut.Name = "btnSingOut";
            this.btnSingOut.Size = new System.Drawing.Size(140, 39);
            this.btnSingOut.TabIndex = 10;
            this.btnSingOut.Text = "Sing Out";
            this.btnSingOut.UseTransparentBackground = true;
            this.btnSingOut.Click += new System.EventHandler(this.btnSingOut_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Animated = true;
            this.btnAddUser.BorderRadius = 10;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.IndicateFocus = true;
            this.btnAddUser.Location = new System.Drawing.Point(132, 17);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(140, 39);
            this.btnAddUser.TabIndex = 9;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseTransparentBackground = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnSearchLogInByDate
            // 
            this.btnSearchLogInByDate.Animated = true;
            this.btnSearchLogInByDate.BorderRadius = 10;
            this.btnSearchLogInByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchLogInByDate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearchLogInByDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchLogInByDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchLogInByDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchLogInByDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchLogInByDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchLogInByDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchLogInByDate.ForeColor = System.Drawing.Color.White;
            this.btnSearchLogInByDate.Location = new System.Drawing.Point(924, 6);
            this.btnSearchLogInByDate.Name = "btnSearchLogInByDate";
            this.btnSearchLogInByDate.Size = new System.Drawing.Size(62, 27);
            this.btnSearchLogInByDate.TabIndex = 8;
            this.btnSearchLogInByDate.Text = "Search";
            this.btnSearchLogInByDate.UseTransparentBackground = true;
            this.btnSearchLogInByDate.Click += new System.EventHandler(this.btnSearchLogInByDate_Click);
            // 
            // dtpSearchLogInRegister
            // 
            this.dtpSearchLogInRegister.Checked = true;
            this.dtpSearchLogInRegister.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtpSearchLogInRegister.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSearchLogInRegister.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpSearchLogInRegister.Location = new System.Drawing.Point(859, 36);
            this.dtpSearchLogInRegister.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSearchLogInRegister.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSearchLogInRegister.Name = "dtpSearchLogInRegister";
            this.dtpSearchLogInRegister.Size = new System.Drawing.Size(201, 39);
            this.dtpSearchLogInRegister.TabIndex = 7;
            this.dtpSearchLogInRegister.Value = new System.DateTime(2024, 3, 28, 3, 21, 0, 486);
            // 
            // btnClearRegisterLogIn
            // 
            this.btnClearRegisterLogIn.Animated = true;
            this.btnClearRegisterLogIn.BorderRadius = 10;
            this.btnClearRegisterLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearRegisterLogIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearRegisterLogIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearRegisterLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearRegisterLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearRegisterLogIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClearRegisterLogIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearRegisterLogIn.ForeColor = System.Drawing.Color.White;
            this.btnClearRegisterLogIn.IndicateFocus = true;
            this.btnClearRegisterLogIn.Location = new System.Drawing.Point(1078, 12);
            this.btnClearRegisterLogIn.Name = "btnClearRegisterLogIn";
            this.btnClearRegisterLogIn.Size = new System.Drawing.Size(158, 39);
            this.btnClearRegisterLogIn.TabIndex = 6;
            this.btnClearRegisterLogIn.Text = "Clear All Register Log In";
            this.btnClearRegisterLogIn.UseTransparentBackground = true;
            this.btnClearRegisterLogIn.Click += new System.EventHandler(this.btnClearRegisterLogIn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(564, 74);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(63, 26);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Search";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Animated = true;
            this.txtSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSearchUser.BorderRadius = 10;
            this.txtSearchUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchUser.DefaultText = "";
            this.txtSearchUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUser.ForeColor = System.Drawing.Color.Black;
            this.txtSearchUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchUser.Location = new System.Drawing.Point(491, 107);
            this.txtSearchUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.PasswordChar = '\0';
            this.txtSearchUser.PlaceholderText = "User Name";
            this.txtSearchUser.SelectedText = "";
            this.txtSearchUser.Size = new System.Drawing.Size(229, 48);
            this.txtSearchUser.TabIndex = 4;
            this.txtSearchUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchUser.TextChanged += new System.EventHandler(this.txtSearchUser_TextChanged);
            // 
            // panelLogInRegisters
            // 
            this.panelLogInRegisters.Controls.Add(this.dgvAllLogInRegisters);
            this.panelLogInRegisters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogInRegisters.Location = new System.Drawing.Point(859, 81);
            this.panelLogInRegisters.Name = "panelLogInRegisters";
            this.panelLogInRegisters.Size = new System.Drawing.Size(382, 411);
            this.panelLogInRegisters.TabIndex = 3;
            // 
            // dgvAllLogInRegisters
            // 
            this.dgvAllLogInRegisters.AllowUserToAddRows = false;
            this.dgvAllLogInRegisters.AllowUserToDeleteRows = false;
            this.dgvAllLogInRegisters.AllowUserToResizeColumns = false;
            this.dgvAllLogInRegisters.AllowUserToResizeRows = false;
            this.dgvAllLogInRegisters.ColumnHeadersHeight = 30;
            this.dgvAllLogInRegisters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllLogInRegisters.Location = new System.Drawing.Point(0, 0);
            this.dgvAllLogInRegisters.MultiSelect = false;
            this.dgvAllLogInRegisters.Name = "dgvAllLogInRegisters";
            this.dgvAllLogInRegisters.ReadOnly = true;
            this.dgvAllLogInRegisters.RowHeadersWidth = 80;
            this.dgvAllLogInRegisters.Size = new System.Drawing.Size(382, 411);
            this.dgvAllLogInRegisters.TabIndex = 0;
            // 
            // panelListUsers
            // 
            this.panelListUsers.Controls.Add(this.dgvAllUsers);
            this.panelListUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelListUsers.Location = new System.Drawing.Point(0, 81);
            this.panelListUsers.Name = "panelListUsers";
            this.panelListUsers.Size = new System.Drawing.Size(382, 411);
            this.panelListUsers.TabIndex = 1;
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.AllowUserToResizeColumns = false;
            this.dgvAllUsers.AllowUserToResizeRows = false;
            this.dgvAllUsers.ColumnHeadersHeight = 30;
            this.dgvAllUsers.ContextMenuStrip = this.cmsUsers;
            this.dgvAllUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvAllUsers.MultiSelect = false;
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersWidth = 80;
            this.dgvAllUsers.Size = new System.Drawing.Size(382, 411);
            this.dgvAllUsers.TabIndex = 0;
            // 
            // cmsUsers
            // 
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.editeToolStripMenuItem});
            this.cmsUsers.Name = "cmsUsers";
            this.cmsUsers.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsUsers.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsUsers.RenderStyle.ColorTable = null;
            this.cmsUsers.RenderStyle.RoundedEdges = true;
            this.cmsUsers.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsUsers.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsUsers.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsUsers.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsUsers.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsUsers.Size = new System.Drawing.Size(108, 48);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editeToolStripMenuItem
            // 
            this.editeToolStripMenuItem.Name = "editeToolStripMenuItem";
            this.editeToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editeToolStripMenuItem.Text = "Edit";
            this.editeToolStripMenuItem.Click += new System.EventHandler(this.editeToolStripMenuItem_Click);
            // 
            // debositToolStripMenuItem
            // 
            this.debositToolStripMenuItem.Name = "debositToolStripMenuItem";
            this.debositToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.debositToolStripMenuItem.Text = "Debosit";
            this.debositToolStripMenuItem.Click += new System.EventHandler(this.debositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystemWinApp.Properties.Resources.bank;
            this.pictureBox1.Location = new System.Drawing.Point(469, 179);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 536);
            this.Controls.Add(this.tcSystem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1273, 575);
            this.MinimumSize = new System.Drawing.Size(1273, 575);
            this.Name = "frmSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System";
            this.Load += new System.EventHandler(this.frmSystem_Load);
            this.tcSystem.ResumeLayout(false);
            this.tpClients.ResumeLayout(false);
            this.tpClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
            this.cmsClients.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            this.tpUsers.PerformLayout();
            this.panelLogInRegisters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllLogInRegisters)).EndInit();
            this.panelListUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tcSystem;
        private System.Windows.Forms.TabPage tpClients;
        private System.Windows.Forms.TabPage tpUsers;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler2;
        private System.Windows.Forms.DataGridView dgvAllClients;
        private System.Windows.Forms.Panel panelListUsers;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogInRegisters;
        private System.Windows.Forms.DataGridView dgvAllLogInRegisters;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnClearRegisterLogIn;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSearchLogInRegister;
        private Guna.UI2.WinForms.Guna2Button btnSearchLogInByDate;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Button btnSingOut;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsClients;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button btnClearAllClients;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchClient;
        private Guna.UI2.WinForms.Guna2Button btnAddNewClient;
        private System.Windows.Forms.ToolStripMenuItem debositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
    }
}

