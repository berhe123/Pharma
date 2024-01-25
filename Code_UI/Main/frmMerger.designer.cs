namespace Pharma
{
    partial class frmMerger
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwMergeDatabases = new System.Windows.Forms.ListView();
            this.colMergeDatabasesId = new System.Windows.Forms.ColumnHeader();
            this.colMergeDatabasesHostname = new System.Windows.Forms.ColumnHeader();
            this.colMergeDatabasesDatabaseguid = new System.Windows.Forms.ColumnHeader();
            this.colMergeDatabasesConnectionstring = new System.Windows.Forms.ColumnHeader();
            this.colMergeDatabasesAlias = new System.Windows.Forms.ColumnHeader();
            this.colMergeDatabasesIschildserver = new System.Windows.Forms.ColumnHeader();
            this.btnSaveServer = new System.Windows.Forms.Button();
            this.chkIsChildServer = new System.Windows.Forms.CheckBox();
            this.txtMergeDatabasesAlias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optAccessDatabase = new System.Windows.Forms.RadioButton();
            this.optSqlServerDatabase = new System.Windows.Forms.RadioButton();
            this.grpSQL = new System.Windows.Forms.GroupBox();
            this.txtDataBaseName = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSQLPassword = new System.Windows.Forms.TextBox();
            this.txtSQLUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optSQLServerAuthentication = new System.Windows.Forms.RadioButton();
            this.optWindowsAuthentication = new System.Windows.Forms.RadioButton();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.grpAccess = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtAccessPassword = new System.Windows.Forms.TextBox();
            this.txtAccessUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrawse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbEventColumnCriteria = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwColumnCriteria = new System.Windows.Forms.ListView();
            this.colTableName = new System.Windows.Forms.ColumnHeader();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEventsTablename = new System.Windows.Forms.ComboBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.sbManufacturerProformas = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpSQL.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpAccess.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grbEventColumnCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.sbManufacturerProformas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(4, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(689, 32);
            this.lblTitle.TabIndex = 48;
            this.lblTitle.Text = "   Event Merger";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwMergeDatabases);
            this.groupBox1.Controls.Add(this.btnSaveServer);
            this.groupBox1.Controls.Add(this.chkIsChildServer);
            this.groupBox1.Controls.Add(this.txtMergeDatabasesAlias);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grpSQL);
            this.groupBox1.Controls.Add(this.btnTestConnection);
            this.groupBox1.Controls.Add(this.grpAccess);
            this.groupBox1.Location = new System.Drawing.Point(7, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(443, 559);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect To Source Server";
            // 
            // lvwMergeDatabases
            // 
            this.lvwMergeDatabases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwMergeDatabases.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMergeDatabasesId,
            this.colMergeDatabasesHostname,
            this.colMergeDatabasesDatabaseguid,
            this.colMergeDatabasesConnectionstring,
            this.colMergeDatabasesAlias,
            this.colMergeDatabasesIschildserver});
            this.lvwMergeDatabases.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMergeDatabases.FullRowSelect = true;
            this.lvwMergeDatabases.GridLines = true;
            this.lvwMergeDatabases.Location = new System.Drawing.Point(8, 398);
            this.lvwMergeDatabases.MultiSelect = false;
            this.lvwMergeDatabases.Name = "lvwMergeDatabases";
            this.lvwMergeDatabases.Size = new System.Drawing.Size(422, 117);
            this.lvwMergeDatabases.TabIndex = 156;
            this.lvwMergeDatabases.UseCompatibleStateImageBehavior = false;
            this.lvwMergeDatabases.View = System.Windows.Forms.View.Details;
            this.lvwMergeDatabases.SelectedIndexChanged += new System.EventHandler(this.lvwMergeDatabases_SelectedIndexChanged);
            this.lvwMergeDatabases.DoubleClick += new System.EventHandler(this.lvwMergeDatabases_DoubleClick);
            // 
            // colMergeDatabasesId
            // 
            this.colMergeDatabasesId.Text = "Id";
            this.colMergeDatabasesId.Width = 0;
            // 
            // colMergeDatabasesHostname
            // 
            this.colMergeDatabasesHostname.Text = "Host Name";
            this.colMergeDatabasesHostname.Width = 200;
            // 
            // colMergeDatabasesDatabaseguid
            // 
            this.colMergeDatabasesDatabaseguid.Text = "Databaseguid";
            this.colMergeDatabasesDatabaseguid.Width = 0;
            // 
            // colMergeDatabasesConnectionstring
            // 
            this.colMergeDatabasesConnectionstring.Text = "Connectionstring";
            this.colMergeDatabasesConnectionstring.Width = 0;
            // 
            // colMergeDatabasesAlias
            // 
            this.colMergeDatabasesAlias.Text = "Server Logical Name";
            this.colMergeDatabasesAlias.Width = 200;
            // 
            // colMergeDatabasesIschildserver
            // 
            this.colMergeDatabasesIschildserver.Text = "Ischildserver";
            this.colMergeDatabasesIschildserver.Width = 0;
            // 
            // btnSaveServer
            // 
            this.btnSaveServer.Location = new System.Drawing.Point(133, 522);
            this.btnSaveServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveServer.Name = "btnSaveServer";
            this.btnSaveServer.Size = new System.Drawing.Size(169, 29);
            this.btnSaveServer.TabIndex = 155;
            this.btnSaveServer.Text = "&Save Server Settings";
            this.btnSaveServer.UseVisualStyleBackColor = true;
            this.btnSaveServer.Click += new System.EventHandler(this.btnSaveServer_Click);
            // 
            // chkIsChildServer
            // 
            this.chkIsChildServer.AutoSize = true;
            this.chkIsChildServer.Location = new System.Drawing.Point(249, 370);
            this.chkIsChildServer.Name = "chkIsChildServer";
            this.chkIsChildServer.Size = new System.Drawing.Size(181, 20);
            this.chkIsChildServer.TabIndex = 25;
            this.chkIsChildServer.Text = "This Server Is Child Server";
            this.chkIsChildServer.UseVisualStyleBackColor = true;
            // 
            // txtMergeDatabasesAlias
            // 
            this.txtMergeDatabasesAlias.Location = new System.Drawing.Point(8, 368);
            this.txtMergeDatabasesAlias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMergeDatabasesAlias.Name = "txtMergeDatabasesAlias";
            this.txtMergeDatabasesAlias.Size = new System.Drawing.Size(235, 23);
            this.txtMergeDatabasesAlias.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 348);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Logical Server Name ";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(304, 522);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 29);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optAccessDatabase);
            this.groupBox2.Controls.Add(this.optSqlServerDatabase);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(429, 60);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Source";
            // 
            // optAccessDatabase
            // 
            this.optAccessDatabase.AutoSize = true;
            this.optAccessDatabase.Location = new System.Drawing.Point(244, 24);
            this.optAccessDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optAccessDatabase.Name = "optAccessDatabase";
            this.optAccessDatabase.Size = new System.Drawing.Size(122, 20);
            this.optAccessDatabase.TabIndex = 4;
            this.optAccessDatabase.TabStop = true;
            this.optAccessDatabase.Text = "Access Database";
            this.optAccessDatabase.UseVisualStyleBackColor = true;
            // 
            // optSqlServerDatabase
            // 
            this.optSqlServerDatabase.AutoSize = true;
            this.optSqlServerDatabase.Location = new System.Drawing.Point(57, 24);
            this.optSqlServerDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optSqlServerDatabase.Name = "optSqlServerDatabase";
            this.optSqlServerDatabase.Size = new System.Drawing.Size(148, 20);
            this.optSqlServerDatabase.TabIndex = 3;
            this.optSqlServerDatabase.TabStop = true;
            this.optSqlServerDatabase.Text = "SQL Server Database";
            this.optSqlServerDatabase.UseVisualStyleBackColor = false;
            // 
            // grpSQL
            // 
            this.grpSQL.Controls.Add(this.txtDataBaseName);
            this.grpSQL.Controls.Add(this.txtServerName);
            this.grpSQL.Controls.Add(this.label1);
            this.grpSQL.Controls.Add(this.label4);
            this.grpSQL.Controls.Add(this.groupBox3);
            this.grpSQL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSQL.Location = new System.Drawing.Point(8, 85);
            this.grpSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSQL.Name = "grpSQL";
            this.grpSQL.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSQL.Size = new System.Drawing.Size(429, 264);
            this.grpSQL.TabIndex = 19;
            this.grpSQL.TabStop = false;
            // 
            // txtDataBaseName
            // 
            this.txtDataBaseName.Location = new System.Drawing.Point(14, 233);
            this.txtDataBaseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataBaseName.Name = "txtDataBaseName";
            this.txtDataBaseName.Size = new System.Drawing.Size(408, 23);
            this.txtDataBaseName.TabIndex = 16;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(14, 32);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(408, 23);
            this.txtServerName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter the database name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSQLPassword);
            this.groupBox3.Controls.Add(this.txtSQLUserName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.optSQLServerAuthentication);
            this.groupBox3.Controls.Add(this.optWindowsAuthentication);
            this.groupBox3.Location = new System.Drawing.Point(14, 62);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(408, 152);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log on to Server";
            // 
            // txtSQLPassword
            // 
            this.txtSQLPassword.Location = new System.Drawing.Point(192, 111);
            this.txtSQLPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSQLPassword.Name = "txtSQLPassword";
            this.txtSQLPassword.PasswordChar = '*';
            this.txtSQLPassword.Size = new System.Drawing.Size(201, 23);
            this.txtSQLPassword.TabIndex = 14;
            // 
            // txtSQLUserName
            // 
            this.txtSQLUserName.Location = new System.Drawing.Point(192, 83);
            this.txtSQLUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSQLUserName.Name = "txtSQLUserName";
            this.txtSQLUserName.Size = new System.Drawing.Size(201, 23);
            this.txtSQLUserName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "User Name:";
            // 
            // optSQLServerAuthentication
            // 
            this.optSQLServerAuthentication.AutoSize = true;
            this.optSQLServerAuthentication.Location = new System.Drawing.Point(60, 54);
            this.optSQLServerAuthentication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optSQLServerAuthentication.Name = "optSQLServerAuthentication";
            this.optSQLServerAuthentication.Size = new System.Drawing.Size(201, 20);
            this.optSQLServerAuthentication.TabIndex = 10;
            this.optSQLServerAuthentication.TabStop = true;
            this.optSQLServerAuthentication.Text = "Use SQL Server Authentication";
            this.optSQLServerAuthentication.UseVisualStyleBackColor = true;
            // 
            // optWindowsAuthentication
            // 
            this.optWindowsAuthentication.AutoSize = true;
            this.optWindowsAuthentication.Location = new System.Drawing.Point(60, 26);
            this.optWindowsAuthentication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optWindowsAuthentication.Name = "optWindowsAuthentication";
            this.optWindowsAuthentication.Size = new System.Drawing.Size(188, 20);
            this.optWindowsAuthentication.TabIndex = 9;
            this.optWindowsAuthentication.TabStop = true;
            this.optWindowsAuthentication.Text = "Use Windows Authentication";
            this.optWindowsAuthentication.UseVisualStyleBackColor = true;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(5, 522);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(126, 29);
            this.btnTestConnection.TabIndex = 20;
            this.btnTestConnection.Text = "&Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // grpAccess
            // 
            this.grpAccess.Controls.Add(this.groupBox6);
            this.grpAccess.Controls.Add(this.btnBrawse);
            this.grpAccess.Controls.Add(this.txtFileName);
            this.grpAccess.Controls.Add(this.label9);
            this.grpAccess.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccess.Location = new System.Drawing.Point(8, 85);
            this.grpAccess.Name = "grpAccess";
            this.grpAccess.Size = new System.Drawing.Size(429, 264);
            this.grpAccess.TabIndex = 22;
            this.grpAccess.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtAccessPassword);
            this.groupBox6.Controls.Add(this.txtAccessUserName);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(14, 93);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(402, 103);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Log on to Database";
            // 
            // txtAccessPassword
            // 
            this.txtAccessPassword.Location = new System.Drawing.Point(142, 54);
            this.txtAccessPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccessPassword.Name = "txtAccessPassword";
            this.txtAccessPassword.PasswordChar = '*';
            this.txtAccessPassword.Size = new System.Drawing.Size(201, 23);
            this.txtAccessPassword.TabIndex = 16;
            // 
            // txtAccessUserName
            // 
            this.txtAccessUserName.Location = new System.Drawing.Point(142, 26);
            this.txtAccessUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccessUserName.Name = "txtAccessUserName";
            this.txtAccessUserName.Size = new System.Drawing.Size(201, 23);
            this.txtAccessUserName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "User Name:";
            // 
            // btnBrawse
            // 
            this.btnBrawse.Location = new System.Drawing.Point(381, 57);
            this.btnBrawse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrawse.Name = "btnBrawse";
            this.btnBrawse.Size = new System.Drawing.Size(35, 23);
            this.btnBrawse.TabIndex = 13;
            this.btnBrawse.Text = "...";
            this.btnBrawse.UseVisualStyleBackColor = true;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(14, 57);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(355, 23);
            this.txtFileName.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Database file path";
            // 
            // grbEventColumnCriteria
            // 
            this.grbEventColumnCriteria.Controls.Add(this.label5);
            this.grbEventColumnCriteria.Controls.Add(this.btnRemove);
            this.grbEventColumnCriteria.Controls.Add(this.btnAdd);
            this.grbEventColumnCriteria.Controls.Add(this.lvwColumnCriteria);
            this.grbEventColumnCriteria.Controls.Add(this.label8);
            this.grbEventColumnCriteria.Controls.Add(this.cboEventsTablename);
            this.grbEventColumnCriteria.Location = new System.Drawing.Point(456, 45);
            this.grbEventColumnCriteria.Name = "grbEventColumnCriteria";
            this.grbEventColumnCriteria.Size = new System.Drawing.Size(391, 515);
            this.grbEventColumnCriteria.TabIndex = 51;
            this.grbEventColumnCriteria.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 56);
            this.label5.TabIndex = 156;
            this.label5.Text = "To Syncronize all tables in the Database Leave the Tables List Empty. To Syncroni" +
                "ze Part of the Database Add the Tables to Syncronize on the Table List";
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Image = global::Pharma.Properties.Resources.MINUS;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(305, 101);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(73, 23);
            this.btnRemove.TabIndex = 155;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Image = global::Pharma.Properties.Resources.PLUS;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(240, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 154;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwColumnCriteria
            // 
            this.lvwColumnCriteria.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTableName});
            this.lvwColumnCriteria.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lvwColumnCriteria.FullRowSelect = true;
            this.lvwColumnCriteria.GridLines = true;
            this.lvwColumnCriteria.LabelWrap = false;
            this.lvwColumnCriteria.Location = new System.Drawing.Point(9, 130);
            this.lvwColumnCriteria.Name = "lvwColumnCriteria";
            this.lvwColumnCriteria.Size = new System.Drawing.Size(372, 379);
            this.lvwColumnCriteria.TabIndex = 153;
            this.lvwColumnCriteria.UseCompatibleStateImageBehavior = false;
            this.lvwColumnCriteria.View = System.Windows.Forms.View.Details;
            // 
            // colTableName
            // 
            this.colTableName.Text = "Table Name";
            this.colTableName.Width = 350;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(9, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 18);
            this.label8.TabIndex = 148;
            this.label8.Text = "Table To Merge";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboEventsTablename
            // 
            this.cboEventsTablename.AllowDrop = true;
            this.cboEventsTablename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventsTablename.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboEventsTablename.FormattingEnabled = true;
            this.cboEventsTablename.Location = new System.Drawing.Point(9, 101);
            this.cboEventsTablename.Name = "cboEventsTablename";
            this.cboEventsTablename.Size = new System.Drawing.Size(228, 24);
            this.cboEventsTablename.TabIndex = 147;
            this.cboEventsTablename.SelectedIndexChanged += new System.EventHandler(this.cboEventsTablename_SelectedIndexChanged);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(456, 572);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(391, 29);
            this.btnMerge.TabIndex = 52;
            this.btnMerge.Text = "Synchronize Databases";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // mValidator
            // 
            this.mValidator.ContainerControl = this;
            // 
            // sbManufacturerProformas
            // 
            this.sbManufacturerProformas.AutoSize = false;
            this.sbManufacturerProformas.BackColor = System.Drawing.Color.Lavender;
            this.sbManufacturerProformas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.sbManufacturerProformas.Location = new System.Drawing.Point(0, 606);
            this.sbManufacturerProformas.Name = "sbManufacturerProformas";
            this.sbManufacturerProformas.Size = new System.Drawing.Size(852, 22);
            this.sbManufacturerProformas.TabIndex = 66;
            // 
            // lblMsg
            // 
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // frmMerger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 628);
            this.Controls.Add(this.sbManufacturerProformas);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.grbEventColumnCriteria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMerger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMerger";
            this.Load += new System.EventHandler(this.frmMerger_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpSQL.ResumeLayout(false);
            this.grpSQL.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpAccess.ResumeLayout(false);
            this.grpAccess.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.grbEventColumnCriteria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.sbManufacturerProformas.ResumeLayout(false);
            this.sbManufacturerProformas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optAccessDatabase;
        private System.Windows.Forms.RadioButton optSqlServerDatabase;
        private System.Windows.Forms.GroupBox grpSQL;
        private System.Windows.Forms.TextBox txtDataBaseName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSQLPassword;
        private System.Windows.Forms.TextBox txtSQLUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton optSQLServerAuthentication;
        private System.Windows.Forms.RadioButton optWindowsAuthentication;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbEventColumnCriteria;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView lvwColumnCriteria;
        private System.Windows.Forms.ColumnHeader colTableName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEventsTablename;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.GroupBox grpAccess;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtAccessPassword;
        private System.Windows.Forms.TextBox txtAccessUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrawse;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkIsChildServer;
        private System.Windows.Forms.TextBox txtMergeDatabasesAlias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSaveServer;
        private System.Windows.Forms.ListView lvwMergeDatabases;
        private System.Windows.Forms.ColumnHeader colMergeDatabasesId;
        private System.Windows.Forms.ColumnHeader colMergeDatabasesHostname;
        private System.Windows.Forms.ColumnHeader colMergeDatabasesDatabaseguid;
        private System.Windows.Forms.ColumnHeader colMergeDatabasesConnectionstring;
        private System.Windows.Forms.ColumnHeader colMergeDatabasesAlias;
        private System.Windows.Forms.ColumnHeader colMergeDatabasesIschildserver;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.StatusStrip sbManufacturerProformas;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
    }
}