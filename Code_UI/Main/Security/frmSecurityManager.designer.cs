namespace SecurityManager
{
    partial class frmSec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being usPharma.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSec));
            this.tabSecurity = new System.Windows.Forms.TabControl();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewGroup = new System.Windows.Forms.ToolStripButton();
            this.btnSaveGroup = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteGroup = new System.Windows.Forms.ToolStripButton();
            this.lvwGroups = new System.Windows.Forms.ListView();
            this.colID = new System.Windows.Forms.ColumnHeader();
            this.colGroupName = new System.Windows.Forms.ColumnHeader();
            this.colAccessRight = new System.Windows.Forms.ColumnHeader();
            this.colDescription = new System.Windows.Forms.ColumnHeader();
            this.tosApplication = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.btnNewApp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveApp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteApp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCloseApp = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboGroupAccessRight = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cboUserAccessRight = new System.Windows.Forms.ComboBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.cboGroupNameUser = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewUser = new System.Windows.Forms.ToolStripButton();
            this.btnSaveUser = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.cboGroupNameSearch = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFill = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lvwUsers = new System.Windows.Forms.ListView();
            this.colUserId = new System.Windows.Forms.ColumnHeader();
            this.colUserName = new System.Windows.Forms.ColumnHeader();
            this.colPassword = new System.Windows.Forms.ColumnHeader();
            this.colFirstName = new System.Windows.Forms.ColumnHeader();
            this.colFatherName = new System.Windows.Forms.ColumnHeader();
            this.colGrandName = new System.Windows.Forms.ColumnHeader();
            this.colGroupNameUser = new System.Windows.Forms.ColumnHeader();
            this.colAccessRightUser = new System.Windows.Forms.ColumnHeader();
            this.colRemark = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtGrandName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabApps = new System.Windows.Forms.TabPage();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvwApplicationUsers = new System.Windows.Forms.ListView();
            this.colAppId = new System.Windows.Forms.ColumnHeader();
            this.colSavedAppUserID = new System.Windows.Forms.ColumnHeader();
            this.colSavedAppUserName = new System.Windows.Forms.ColumnHeader();
            this.cboApplicantionName = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvwAppUserList = new System.Windows.Forms.ListView();
            this.colAppUserName = new System.Windows.Forms.ColumnHeader();
            this.colAppUserID = new System.Windows.Forms.ColumnHeader();
            this.cboGroupNameApplication = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnFillUsersApplication = new System.Windows.Forms.Button();
            this.imgToolBar = new System.Windows.Forms.ImageList(this.components);
            this.errValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnApplications = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.tabSecurity.SuspendLayout();
            this.tabGroups.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tosApplication.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabApps.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidator)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSecurity
            // 
            this.tabSecurity.Controls.Add(this.tabGroups);
            this.tabSecurity.Controls.Add(this.tabUsers);
            this.tabSecurity.Controls.Add(this.tabApps);
            this.tabSecurity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSecurity.ItemSize = new System.Drawing.Size(200, 25);
            this.tabSecurity.Location = new System.Drawing.Point(136, 13);
            this.tabSecurity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabSecurity.Name = "tabSecurity";
            this.tabSecurity.SelectedIndex = 0;
            this.tabSecurity.Size = new System.Drawing.Size(604, 520);
            this.tabSecurity.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabSecurity.TabIndex = 0;
            this.tabSecurity.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabSecurity_Selected);
            // 
            // tabGroups
            // 
            this.tabGroups.BackColor = System.Drawing.Color.Transparent;
            this.tabGroups.Controls.Add(this.toolStrip1);
            this.tabGroups.Controls.Add(this.lvwGroups);
            this.tabGroups.Controls.Add(this.tosApplication);
            this.tabGroups.Controls.Add(this.groupBox1);
            this.tabGroups.Location = new System.Drawing.Point(4, 29);
            this.tabGroups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabGroups.Size = new System.Drawing.Size(596, 487);
            this.tabGroups.TabIndex = 0;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnNewGroup,
            this.btnSaveGroup,
            this.btnDeleteGroup});
            this.toolStrip1.Location = new System.Drawing.Point(3, 4);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(590, 25);
            this.toolStrip1.TabIndex = 92;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGroup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewGroup.Image = global::Pharma.Properties.Resources.New;
            this.btnNewGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(53, 22);
            this.btnNewGroup.Text = "New";
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // btnSaveGroup
            // 
            this.btnSaveGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGroup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveGroup.Image = global::Pharma.Properties.Resources.save;
            this.btnSaveGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveGroup.Name = "btnSaveGroup";
            this.btnSaveGroup.Size = new System.Drawing.Size(56, 22);
            this.btnSaveGroup.Text = "Save";
            this.btnSaveGroup.Click += new System.EventHandler(this.btnSaveGroup_Click);
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGroup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteGroup.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeleteGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteGroup.Text = "Delete";
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // lvwGroups
            // 
            this.lvwGroups.AllowColumnReorder = true;
            this.lvwGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colGroupName,
            this.colAccessRight,
            this.colDescription});
            this.lvwGroups.FullRowSelect = true;
            this.lvwGroups.GridLines = true;
            this.lvwGroups.Location = new System.Drawing.Point(6, 183);
            this.lvwGroups.Name = "lvwGroups";
            this.lvwGroups.Size = new System.Drawing.Size(584, 268);
            this.lvwGroups.TabIndex = 3;
            this.lvwGroups.UseCompatibleStateImageBehavior = false;
            this.lvwGroups.View = System.Windows.Forms.View.Details;
            this.lvwGroups.SelectedIndexChanged += new System.EventHandler(this.lvwGroups_SelectedIndexChanged);
            this.lvwGroups.Click += new System.EventHandler(this.lvwGroups_Click);
            // 
            // colID
            // 
            this.colID.Text = "id";
            this.colID.Width = 0;
            // 
            // colGroupName
            // 
            this.colGroupName.Text = "Group Name";
            this.colGroupName.Width = 250;
            // 
            // colAccessRight
            // 
            this.colAccessRight.Text = "Access Right";
            this.colAccessRight.Width = 150;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 200;
            // 
            // tosApplication
            // 
            this.tosApplication.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.btnNewApp,
            this.toolStripSeparator1,
            this.btnSaveApp,
            this.toolStripSeparator2,
            this.btnDeleteApp,
            this.toolStripSeparator3,
            this.btnCloseApp});
            this.tosApplication.Location = new System.Drawing.Point(3, 4);
            this.tosApplication.Name = "tosApplication";
            this.tosApplication.Size = new System.Drawing.Size(590, 25);
            this.tosApplication.TabIndex = 0;
            this.tosApplication.Visible = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton2.Text = "             ";
            // 
            // btnNewApp
            // 
            this.btnNewApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewApp.Image = ((System.Drawing.Image)(resources.GetObject("btnNewApp.Image")));
            this.btnNewApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewApp.Name = "btnNewApp";
            this.btnNewApp.Size = new System.Drawing.Size(53, 22);
            this.btnNewApp.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSaveApp
            // 
            this.btnSaveApp.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveApp.Image")));
            this.btnSaveApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveApp.Name = "btnSaveApp";
            this.btnSaveApp.Size = new System.Drawing.Size(56, 22);
            this.btnSaveApp.Text = "Save";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeleteApp
            // 
            this.btnDeleteApp.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteApp.Image")));
            this.btnDeleteApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteApp.Name = "btnDeleteApp";
            this.btnDeleteApp.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteApp.Text = "Delete";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseApp.Image")));
            this.btnCloseApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(59, 22);
            this.btnCloseApp.Text = "Close";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboGroupAccessRight);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtGroupName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cboGroupAccessRight
            // 
            this.cboGroupAccessRight.FormattingEnabled = true;
            this.cboGroupAccessRight.Location = new System.Drawing.Point(329, 28);
            this.cboGroupAccessRight.Name = "cboGroupAccessRight";
            this.cboGroupAccessRight.Size = new System.Drawing.Size(247, 24);
            this.cboGroupAccessRight.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(4, 69);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(572, 73);
            this.txtDescription.TabIndex = 6;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(4, 28);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(306, 23);
            this.txtGroupName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Access Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name";
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.groupBox5);
            this.tabUsers.Controls.Add(this.toolStrip2);
            this.tabUsers.Controls.Add(this.cboGroupNameSearch);
            this.tabUsers.Controls.Add(this.label11);
            this.tabUsers.Controls.Add(this.btnFill);
            this.tabUsers.Controls.Add(this.lvwUsers);
            this.tabUsers.Controls.Add(this.groupBox2);
            this.tabUsers.Location = new System.Drawing.Point(4, 29);
            this.tabUsers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUsers.Size = new System.Drawing.Size(596, 487);
            this.tabUsers.TabIndex = 1;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            this.tabUsers.Click += new System.EventHandler(this.tabUsers_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cboUserAccessRight);
            this.groupBox5.Controls.Add(this.txtConfirmPassword);
            this.groupBox5.Controls.Add(this.cboGroupNameUser);
            this.groupBox5.Controls.Add(this.txtPassword);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtUserName);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(4, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(587, 108);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Login Info";
            // 
            // cboUserAccessRight
            // 
            this.cboUserAccessRight.FormattingEnabled = true;
            this.cboUserAccessRight.Location = new System.Drawing.Point(211, 76);
            this.cboUserAccessRight.Name = "cboUserAccessRight";
            this.cboUserAccessRight.Size = new System.Drawing.Size(167, 24);
            this.cboUserAccessRight.TabIndex = 14;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(414, 35);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(167, 23);
            this.txtConfirmPassword.TabIndex = 16;
            // 
            // cboGroupNameUser
            // 
            this.cboGroupNameUser.FormattingEnabled = true;
            this.cboGroupNameUser.Location = new System.Drawing.Point(10, 76);
            this.cboGroupNameUser.Name = "cboGroupNameUser";
            this.cboGroupNameUser.Size = new System.Drawing.Size(167, 24);
            this.cboGroupNameUser.TabIndex = 13;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(211, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 23);
            this.txtPassword.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(414, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 16);
            this.label12.TabIndex = 7;
            this.label12.Text = "Confirm Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(10, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(167, 23);
            this.txtUserName.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Group Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Access Right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Password";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnNewUser,
            this.btnSaveUser,
            this.btnDeleteUser});
            this.toolStrip2.Location = new System.Drawing.Point(3, 4);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(590, 25);
            this.toolStrip2.TabIndex = 93;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewUser.Image = global::Pharma.Properties.Resources.New;
            this.btnNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(53, 22);
            this.btnNewUser.Text = "New";
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveUser.Image = global::Pharma.Properties.Resources.save;
            this.btnSaveUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(56, 22);
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteUser.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteUser.Text = "Delete";
            // 
            // cboGroupNameSearch
            // 
            this.cboGroupNameSearch.FormattingEnabled = true;
            this.cboGroupNameSearch.Location = new System.Drawing.Point(95, 263);
            this.cboGroupNameSearch.Name = "cboGroupNameSearch";
            this.cboGroupNameSearch.Size = new System.Drawing.Size(205, 24);
            this.cboGroupNameSearch.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 267);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Group name:";
            // 
            // btnFill
            // 
            this.btnFill.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFill.ImageIndex = 8;
            this.btnFill.ImageList = this.imageList1;
            this.btnFill.Location = new System.Drawing.Point(304, 263);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(86, 24);
            this.btnFill.TabIndex = 8;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1dreiMann.ico");
            this.imageList1.Images.SetKeyName(1, "1Mann.ico");
            this.imageList1.Images.SetKeyName(2, "016.ico");
            this.imageList1.Images.SetKeyName(3, "WinXP50.ico");
            this.imageList1.Images.SetKeyName(4, "New.gif");
            this.imageList1.Images.SetKeyName(5, "Save.bmp");
            this.imageList1.Images.SetKeyName(6, "delete.gif");
            this.imageList1.Images.SetKeyName(7, "Stop.gif");
            this.imageList1.Images.SetKeyName(8, "Search.gif");
            this.imageList1.Images.SetKeyName(9, "props.ico");
            this.imageList1.Images.SetKeyName(10, "ARW06RT.ICO");
            this.imageList1.Images.SetKeyName(11, "ARW06LT.ICO");
            this.imageList1.Images.SetKeyName(12, "CHECKMRK.ICO");
            this.imageList1.Images.SetKeyName(13, "Yes.ico");
            this.imageList1.Images.SetKeyName(14, "no.ico");
            // 
            // lvwUsers
            // 
            this.lvwUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserId,
            this.colUserName,
            this.colPassword,
            this.colFirstName,
            this.colFatherName,
            this.colGrandName,
            this.colGroupNameUser,
            this.colAccessRightUser,
            this.colRemark});
            this.lvwUsers.FullRowSelect = true;
            this.lvwUsers.GridLines = true;
            this.lvwUsers.Location = new System.Drawing.Point(6, 292);
            this.lvwUsers.Name = "lvwUsers";
            this.lvwUsers.Size = new System.Drawing.Size(584, 188);
            this.lvwUsers.TabIndex = 5;
            this.lvwUsers.UseCompatibleStateImageBehavior = false;
            this.lvwUsers.View = System.Windows.Forms.View.Details;
            this.lvwUsers.Click += new System.EventHandler(this.lvwUsers_Click);
            // 
            // colUserId
            // 
            this.colUserId.Text = "Id";
            this.colUserId.Width = 0;
            // 
            // colUserName
            // 
            this.colUserName.Text = "User Name";
            this.colUserName.Width = 250;
            // 
            // colPassword
            // 
            this.colPassword.Text = "Password";
            this.colPassword.Width = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "FirstName";
            this.colFirstName.Width = 0;
            // 
            // colFatherName
            // 
            this.colFatherName.Text = "Father Name";
            this.colFatherName.Width = 0;
            // 
            // colGrandName
            // 
            this.colGrandName.DisplayIndex = 8;
            this.colGrandName.Text = "GrandName";
            this.colGrandName.Width = 0;
            // 
            // colGroupNameUser
            // 
            this.colGroupNameUser.DisplayIndex = 5;
            this.colGroupNameUser.Text = "Group Name";
            this.colGroupNameUser.Width = 175;
            // 
            // colAccessRightUser
            // 
            this.colAccessRightUser.DisplayIndex = 6;
            this.colAccessRightUser.Text = "Access Right";
            this.colAccessRightUser.Width = 150;
            // 
            // colRemark
            // 
            this.colRemark.DisplayIndex = 7;
            this.colRemark.Text = "Remark";
            this.colRemark.Width = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRemark);
            this.groupBox2.Controls.Add(this.txtGrandName);
            this.groupBox2.Controls.Add(this.txtFatherName);
            this.groupBox2.Controls.Add(this.txtFirstName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(4, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personal Info";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(10, 78);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(566, 23);
            this.txtRemark.TabIndex = 17;
            // 
            // txtGrandName
            // 
            this.txtGrandName.Location = new System.Drawing.Point(414, 35);
            this.txtGrandName.Name = "txtGrandName";
            this.txtGrandName.Size = new System.Drawing.Size(167, 23);
            this.txtGrandName.TabIndex = 12;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(211, 35);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(167, 23);
            this.txtFatherName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(10, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(167, 23);
            this.txtFirstName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Father Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Grand Father Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 8;
            this.label13.Text = "Remark";
            // 
            // tabApps
            // 
            this.tabApps.Controls.Add(this.btnDeselectAll);
            this.tabApps.Controls.Add(this.btnSelectAll);
            this.tabApps.Controls.Add(this.btnRemove);
            this.tabApps.Controls.Add(this.btnAdd);
            this.tabApps.Controls.Add(this.groupBox4);
            this.tabApps.Controls.Add(this.groupBox3);
            this.tabApps.Location = new System.Drawing.Point(4, 29);
            this.tabApps.Name = "tabApps";
            this.tabApps.Padding = new System.Windows.Forms.Padding(3);
            this.tabApps.Size = new System.Drawing.Size(596, 487);
            this.tabApps.TabIndex = 2;
            this.tabApps.Text = "Roles";
            this.tabApps.UseVisualStyleBackColor = true;
            this.tabApps.Click += new System.EventHandler(this.tabApps_Click);
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeselectAll.ImageIndex = 14;
            this.btnDeselectAll.ImageList = this.imageList1;
            this.btnDeselectAll.Location = new System.Drawing.Point(151, 442);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(112, 30);
            this.btnDeselectAll.TabIndex = 24;
            this.btnDeselectAll.Text = "Deselect All";
            this.btnDeselectAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSelectAll.ImageIndex = 13;
            this.btnSelectAll.ImageList = this.imageList1;
            this.btnSelectAll.Location = new System.Drawing.Point(3, 442);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(112, 30);
            this.btnSelectAll.TabIndex = 23;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ImageIndex = 11;
            this.btnRemove.ImageList = this.imageList1;
            this.btnRemove.Location = new System.Drawing.Point(269, 216);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 66);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageIndex = 10;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(269, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 66);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvwApplicationUsers);
            this.groupBox4.Controls.Add(this.cboApplicantionName);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(347, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 419);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // lvwApplicationUsers
            // 
            this.lvwApplicationUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAppId,
            this.colSavedAppUserID,
            this.colSavedAppUserName});
            this.lvwApplicationUsers.FullRowSelect = true;
            this.lvwApplicationUsers.GridLines = true;
            this.lvwApplicationUsers.Location = new System.Drawing.Point(6, 68);
            this.lvwApplicationUsers.Name = "lvwApplicationUsers";
            this.lvwApplicationUsers.Size = new System.Drawing.Size(235, 345);
            this.lvwApplicationUsers.TabIndex = 25;
            this.lvwApplicationUsers.UseCompatibleStateImageBehavior = false;
            this.lvwApplicationUsers.View = System.Windows.Forms.View.Details;
            // 
            // colAppId
            // 
            this.colAppId.Width = 0;
            // 
            // colSavedAppUserID
            // 
            this.colSavedAppUserID.Width = 0;
            // 
            // colSavedAppUserName
            // 
            this.colSavedAppUserName.Text = "User Name";
            this.colSavedAppUserName.Width = 300;
            // 
            // cboApplicantionName
            // 
            this.cboApplicantionName.FormattingEnabled = true;
            this.cboApplicantionName.Location = new System.Drawing.Point(6, 38);
            this.cboApplicantionName.Name = "cboApplicantionName";
            this.cboApplicantionName.Size = new System.Drawing.Size(235, 24);
            this.cboApplicantionName.TabIndex = 24;
            this.cboApplicantionName.SelectedIndexChanged += new System.EventHandler(this.cboApplicantionName_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Application Roles";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvwAppUserList);
            this.groupBox3.Controls.Add(this.cboGroupNameApplication);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnFillUsersApplication);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 419);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // lvwAppUserList
            // 
            this.lvwAppUserList.CheckBoxes = true;
            this.lvwAppUserList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAppUserName,
            this.colAppUserID});
            this.lvwAppUserList.FullRowSelect = true;
            this.lvwAppUserList.GridLines = true;
            this.lvwAppUserList.Location = new System.Drawing.Point(7, 67);
            this.lvwAppUserList.Name = "lvwAppUserList";
            this.lvwAppUserList.Size = new System.Drawing.Size(247, 346);
            this.lvwAppUserList.TabIndex = 22;
            this.lvwAppUserList.UseCompatibleStateImageBehavior = false;
            this.lvwAppUserList.View = System.Windows.Forms.View.Details;
            // 
            // colAppUserName
            // 
            this.colAppUserName.Text = "User Name";
            this.colAppUserName.Width = 300;
            // 
            // colAppUserID
            // 
            this.colAppUserID.Text = "Id";
            this.colAppUserID.Width = 0;
            // 
            // cboGroupNameApplication
            // 
            this.cboGroupNameApplication.FormattingEnabled = true;
            this.cboGroupNameApplication.Location = new System.Drawing.Point(6, 37);
            this.cboGroupNameApplication.Name = "cboGroupNameApplication";
            this.cboGroupNameApplication.Size = new System.Drawing.Size(153, 24);
            this.cboGroupNameApplication.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 19;
            this.label14.Text = "Group Name";
            // 
            // btnFillUsersApplication
            // 
            this.btnFillUsersApplication.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFillUsersApplication.ImageIndex = 8;
            this.btnFillUsersApplication.ImageList = this.imageList1;
            this.btnFillUsersApplication.Location = new System.Drawing.Point(165, 33);
            this.btnFillUsersApplication.Name = "btnFillUsersApplication";
            this.btnFillUsersApplication.Size = new System.Drawing.Size(89, 28);
            this.btnFillUsersApplication.TabIndex = 20;
            this.btnFillUsersApplication.Text = "Fill";
            this.btnFillUsersApplication.UseVisualStyleBackColor = true;
            this.btnFillUsersApplication.Click += new System.EventHandler(this.btnFillUsersApplication_Click);
            // 
            // imgToolBar
            // 
            this.imgToolBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgToolBar.ImageStream")));
            this.imgToolBar.TransparentColor = System.Drawing.Color.Transparent;
            this.imgToolBar.Images.SetKeyName(0, "open.ico");
            this.imgToolBar.Images.SetKeyName(1, "new.ico");
            this.imgToolBar.Images.SetKeyName(2, "save.ico");
            this.imgToolBar.Images.SetKeyName(3, "delete.ico");
            // 
            // errValidator
            // 
            this.errValidator.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(3, 13);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.btnApplications);
            this.splitContainer1.Panel2.Controls.Add(this.btnUsers);
            this.splitContainer1.Panel2.Controls.Add(this.btnGroups);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 100;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(127, 521);
            this.splitContainer1.SplitterDistance = 102;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnApplications
            // 
            this.btnApplications.BackColor = System.Drawing.Color.Transparent;
            this.btnApplications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnApplications.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnApplications.ImageKey = "props.ico";
            this.btnApplications.ImageList = this.imageList1;
            this.btnApplications.Location = new System.Drawing.Point(15, 238);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(97, 59);
            this.btnApplications.TabIndex = 2;
            this.btnApplications.Text = "Applicantions";
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApplications.UseVisualStyleBackColor = false;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.ImageKey = "1Mann.ico";
            this.btnUsers.ImageList = this.imageList1;
            this.btnUsers.Location = new System.Drawing.Point(15, 127);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(97, 59);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.BackColor = System.Drawing.Color.Transparent;
            this.btnGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGroups.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGroups.ImageIndex = 0;
            this.btnGroups.ImageList = this.imageList1;
            this.btnGroups.Location = new System.Drawing.Point(15, 16);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(97, 59);
            this.btnGroups.TabIndex = 0;
            this.btnGroups.Text = "Groups";
            this.btnGroups.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGroups.UseVisualStyleBackColor = false;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // frmSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(746, 546);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabSecurity);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users and Groups";
            this.Load += new System.EventHandler(this.frmSec_Load);
            this.tabSecurity.ResumeLayout(false);
            this.tabGroups.ResumeLayout(false);
            this.tabGroups.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tosApplication.ResumeLayout(false);
            this.tosApplication.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabApps.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errValidator)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSecurity;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.ToolStrip tosApplication;
        private System.Windows.Forms.ToolStripButton btnNewApp;
        private System.Windows.Forms.ToolStripButton btnSaveApp;
        private System.Windows.Forms.ToolStripButton btnDeleteApp;
        private System.Windows.Forms.ToolStripButton btnCloseApp;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList imgToolBar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lvwGroups;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwUsers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboGroupAccessRight;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colGroupName;
        private System.Windows.Forms.ColumnHeader colAccessRight;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ErrorProvider errValidator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboUserAccessRight;
        private System.Windows.Forms.ComboBox cboGroupNameUser;
        private System.Windows.Forms.TextBox txtGrandName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cboGroupNameSearch;
        private System.Windows.Forms.ColumnHeader colUserId;
        private System.Windows.Forms.ColumnHeader colUserName;
        private System.Windows.Forms.ColumnHeader colPassword;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colFatherName;
        private System.Windows.Forms.ColumnHeader colGrandName;
        private System.Windows.Forms.ColumnHeader colGroupNameUser;
        private System.Windows.Forms.ColumnHeader colAccessRightUser;
        private System.Windows.Forms.ColumnHeader colRemark;
        private System.Windows.Forms.TabPage tabApps;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvwAppUserList;
        private System.Windows.Forms.ColumnHeader colAppUserID;
        private System.Windows.Forms.ColumnHeader colAppUserName;
        private System.Windows.Forms.ComboBox cboGroupNameApplication;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFillUsersApplication;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboApplicantionName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvwApplicationUsers;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.ColumnHeader colAppId;
        private System.Windows.Forms.ColumnHeader colSavedAppUserID;
        private System.Windows.Forms.ColumnHeader colSavedAppUserName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnNewGroup;
        private System.Windows.Forms.ToolStripButton btnSaveGroup;
        private System.Windows.Forms.ToolStripButton btnDeleteGroup;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewUser;
        private System.Windows.Forms.ToolStripButton btnSaveUser;
        private System.Windows.Forms.ToolStripButton btnDeleteUser;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

