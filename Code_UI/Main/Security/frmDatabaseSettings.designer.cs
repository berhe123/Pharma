namespace Pharma
{
    partial class frmDatabaseSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optAccessDatabase = new System.Windows.Forms.RadioButton();
            this.optSqlServerDatabase = new System.Windows.Forms.RadioButton();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.grpSQL = new System.Windows.Forms.GroupBox();
            this.txtDataBaseName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSQLPassword = new System.Windows.Forms.TextBox();
            this.txtSQLUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.optSQLServerAuthentication = new System.Windows.Forms.RadioButton();
            this.optWindowsAuthentication = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAccess = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtAccessPassword = new System.Windows.Forms.TextBox();
            this.txtAccessUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrawse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.grpSQL.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpAccess.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optAccessDatabase);
            this.groupBox1.Controls.Add(this.optSqlServerDatabase);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(466, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // optAccessDatabase
            // 
            this.optAccessDatabase.AutoSize = true;
            this.optAccessDatabase.Location = new System.Drawing.Point(276, 28);
            this.optAccessDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optAccessDatabase.Name = "optAccessDatabase";
            this.optAccessDatabase.Size = new System.Drawing.Size(122, 20);
            this.optAccessDatabase.TabIndex = 4;
            this.optAccessDatabase.TabStop = true;
            this.optAccessDatabase.Text = "Access Database";
            this.optAccessDatabase.UseVisualStyleBackColor = true;
            this.optAccessDatabase.Click += new System.EventHandler(this.optAccessDatabase_Click);
            // 
            // optSqlServerDatabase
            // 
            this.optSqlServerDatabase.AutoSize = true;
            this.optSqlServerDatabase.Location = new System.Drawing.Point(60, 28);
            this.optSqlServerDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optSqlServerDatabase.Name = "optSqlServerDatabase";
            this.optSqlServerDatabase.Size = new System.Drawing.Size(148, 20);
            this.optSqlServerDatabase.TabIndex = 3;
            this.optSqlServerDatabase.TabStop = true;
            this.optSqlServerDatabase.Text = "SQL Server Database";
            this.optSqlServerDatabase.UseVisualStyleBackColor = false;
            this.optSqlServerDatabase.Click += new System.EventHandler(this.optSqlServerDatabase_Click);
            this.optSqlServerDatabase.CheckedChanged += new System.EventHandler(this.optSqlServerDatabase_CheckedChanged);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(14, 32);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(408, 23);
            this.txtServerName.TabIndex = 7;
            // 
            // grpSQL
            // 
            this.grpSQL.Controls.Add(this.txtDataBaseName);
            this.grpSQL.Controls.Add(this.txtServerName);
            this.grpSQL.Controls.Add(this.label1);
            this.grpSQL.Controls.Add(this.label4);
            this.grpSQL.Controls.Add(this.groupBox3);
            this.grpSQL.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSQL.Location = new System.Drawing.Point(11, 114);
            this.grpSQL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSQL.Name = "grpSQL";
            this.grpSQL.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSQL.Size = new System.Drawing.Size(466, 270);
            this.grpSQL.TabIndex = 5;
            this.grpSQL.TabStop = false;
            // 
            // txtDataBaseName
            // 
            this.txtDataBaseName.Location = new System.Drawing.Point(14, 235);
            this.txtDataBaseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataBaseName.Name = "txtDataBaseName";
            this.txtDataBaseName.Size = new System.Drawing.Size(408, 23);
            this.txtDataBaseName.TabIndex = 16;
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
            this.groupBox3.Size = new System.Drawing.Size(408, 145);
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
            this.optSQLServerAuthentication.CheckedChanged += new System.EventHandler(this.optSQLServerAuthentication_CheckedChanged);
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
            this.optWindowsAuthentication.CheckedChanged += new System.EventHandler(this.optWindowsAuthentication_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Enter the database name:";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(359, 393);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(118, 29);
            this.btnTestConnection.TabIndex = 17;
            this.btnTestConnection.Text = "&Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(237, 439);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(118, 29);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(359, 439);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 29);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpAccess
            // 
            this.grpAccess.Controls.Add(this.groupBox6);
            this.grpAccess.Controls.Add(this.btnBrawse);
            this.grpAccess.Controls.Add(this.txtFileName);
            this.grpAccess.Controls.Add(this.label5);
            this.grpAccess.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccess.Location = new System.Drawing.Point(11, 115);
            this.grpAccess.Name = "grpAccess";
            this.grpAccess.Size = new System.Drawing.Size(466, 270);
            this.grpAccess.TabIndex = 11;
            this.grpAccess.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtAccessPassword);
            this.groupBox6.Controls.Add(this.txtAccessUserName);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Location = new System.Drawing.Point(14, 62);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox6.Size = new System.Drawing.Size(408, 103);
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
            this.btnBrawse.Location = new System.Drawing.Point(424, 32);
            this.btnBrawse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrawse.Name = "btnBrawse";
            this.btnBrawse.Size = new System.Drawing.Size(35, 23);
            this.btnBrawse.TabIndex = 13;
            this.btnBrawse.Text = "...";
            this.btnBrawse.UseVisualStyleBackColor = true;
            this.btnBrawse.Click += new System.EventHandler(this.btnBrawse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(14, 32);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(408, 23);
            this.txtFileName.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Database file path";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(0, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(516, 1);
            this.line1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(526, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "    Provide connection info";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(11, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 1);
            this.panel1.TabIndex = 18;
            // 
            // frmDatabaseSettings
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(490, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAccess);
            this.Controls.Add(this.grpSQL);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmDatabaseSettings";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Connection Settings";
            this.Load += new System.EventHandler(this.frmDatabaseSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSQL.ResumeLayout(false);
            this.grpSQL.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpAccess.ResumeLayout(false);
            this.grpAccess.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optAccessDatabase;
        private System.Windows.Forms.RadioButton optSqlServerDatabase;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.GroupBox grpSQL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton optSQLServerAuthentication;
        private System.Windows.Forms.RadioButton optWindowsAuthentication;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQLPassword;
        private System.Windows.Forms.TextBox txtSQLUserName;
        private System.Windows.Forms.TextBox txtDataBaseName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpAccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtAccessPassword;
        private System.Windows.Forms.TextBox txtAccessUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrawse;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
    }
}