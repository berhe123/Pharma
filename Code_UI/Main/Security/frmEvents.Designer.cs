//
// ...
// Wizard generated code
// Date: 2/25/2010 9:44:26 AM
// Class: frmEvents
// ...
//
namespace Pharma
{
    partial class frmEvents
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


        #region Windows Form Designer generated code Events


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpEventsList = new System.Windows.Forms.GroupBox();
            this.lvwEvents = new System.Windows.Forms.ListView();
            this.colEventsId = new System.Windows.Forms.ColumnHeader();
            this.colEventsTablename = new System.Windows.Forms.ColumnHeader();
            this.colEventsTableidfieldname = new System.Windows.Forms.ColumnHeader();
            this.colEventsTableid = new System.Windows.Forms.ColumnHeader();
            this.colEventsUserid = new System.Windows.Forms.ColumnHeader();
            this.colEventsUsername = new System.Windows.Forms.ColumnHeader();
            this.colEventsEventdate = new System.Windows.Forms.ColumnHeader();
            this.colEventsEventtime = new System.Windows.Forms.ColumnHeader();
            this.colEventsEventtype = new System.Windows.Forms.ColumnHeader();
            this.colEventsSearchfield = new System.Windows.Forms.ColumnHeader();
            this.colEventsSearchvalue = new System.Windows.Forms.ColumnHeader();
            this.colEventsComputername = new System.Windows.Forms.ColumnHeader();
            this.colEventsRestored = new System.Windows.Forms.ColumnHeader();
            this.colEventsMerged = new System.Windows.Forms.ColumnHeader();
            this.colEventsTablerowguid = new System.Windows.Forms.ColumnHeader();
            this.ssEvents = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEventsComputername = new System.Windows.Forms.Label();
            this.txtEventsSearchvalue = new System.Windows.Forms.TextBox();
            this.lblEventsSearchvalue = new System.Windows.Forms.Label();
            this.txtEventsSearchfield = new System.Windows.Forms.TextBox();
            this.lblEventsSearchfield = new System.Windows.Forms.Label();
            this.lblEventsEventtype = new System.Windows.Forms.Label();
            this.txtEventsEventtimefrom = new System.Windows.Forms.TextBox();
            this.lblEventsEventtime = new System.Windows.Forms.Label();
            this.txtEventsEventdatefrom = new System.Windows.Forms.TextBox();
            this.lblEventsEventdate = new System.Windows.Forms.Label();
            this.txtEventsUsername = new System.Windows.Forms.TextBox();
            this.lblEventsUsername = new System.Windows.Forms.Label();
            this.txtEventsUserid = new System.Windows.Forms.TextBox();
            this.lblEventsUserid = new System.Windows.Forms.Label();
            this.txtEventsComputerName = new System.Windows.Forms.TextBox();
            this.cboEventsTablename = new System.Windows.Forms.ComboBox();
            this.lblEventsTablename = new System.Windows.Forms.Label();
            this.grpEventsEntry = new System.Windows.Forms.GroupBox();
            this.chkEventTime = new System.Windows.Forms.CheckBox();
            this.grbEventTime = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventsEventtimeto = new System.Windows.Forms.TextBox();
            this.chkEventDate = new System.Windows.Forms.CheckBox();
            this.grbEventDate = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventsEventdateto = new System.Windows.Forms.TextBox();
            this.cboEventType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRestoreEvent = new System.Windows.Forms.Button();
            this.btnFindEvents = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbEventColumnCriteria = new System.Windows.Forms.GroupBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColumnType = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwColumnCriteria = new System.Windows.Forms.ListView();
            this.colColumnName = new System.Windows.Forms.ColumnHeader();
            this.colOperator = new System.Windows.Forms.ColumnHeader();
            this.colColumnValue = new System.Windows.Forms.ColumnHeader();
            this.colColumnType = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColumnValueField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTableCurrentFields = new System.Windows.Forms.ComboBox();
            this.grvEventData = new System.Windows.Forms.DataGridView();
            this.cboColumnValue = new System.Windows.Forms.ComboBox();
            this.grpEventsList.SuspendLayout();
            this.ssEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.grpEventsEntry.SuspendLayout();
            this.grbEventTime.SuspendLayout();
            this.grbEventDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grbEventColumnCriteria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEventData)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEventsList
            // 
            this.grpEventsList.Controls.Add(this.lvwEvents);
            this.grpEventsList.Location = new System.Drawing.Point(9, 350);
            this.grpEventsList.Name = "grpEventsList";
            this.grpEventsList.Size = new System.Drawing.Size(1160, 261);
            this.grpEventsList.TabIndex = 2;
            this.grpEventsList.TabStop = false;
            // 
            // lvwEvents
            // 
            this.lvwEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEventsId,
            this.colEventsTablename,
            this.colEventsTableidfieldname,
            this.colEventsTableid,
            this.colEventsUserid,
            this.colEventsUsername,
            this.colEventsEventdate,
            this.colEventsEventtime,
            this.colEventsEventtype,
            this.colEventsSearchfield,
            this.colEventsSearchvalue,
            this.colEventsComputername,
            this.colEventsRestored,
            this.colEventsMerged,
            this.colEventsTablerowguid});
            this.lvwEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwEvents.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwEvents.FullRowSelect = true;
            this.lvwEvents.GridLines = true;
            this.lvwEvents.Location = new System.Drawing.Point(3, 16);
            this.lvwEvents.MultiSelect = false;
            this.lvwEvents.Name = "lvwEvents";
            this.lvwEvents.Size = new System.Drawing.Size(1154, 242);
            this.lvwEvents.TabIndex = 0;
            this.lvwEvents.UseCompatibleStateImageBehavior = false;
            this.lvwEvents.View = System.Windows.Forms.View.Details;
            this.lvwEvents.SelectedIndexChanged += new System.EventHandler(this.lvwEvents_SelectedIndexChanged);
            this.lvwEvents.DoubleClick += new System.EventHandler(this.lvwEvents_DoubleClick);
            // 
            // colEventsId
            // 
            this.colEventsId.Text = "Id";
            this.colEventsId.Width = 0;
            // 
            // colEventsTablename
            // 
            this.colEventsTablename.Text = "Table Name";
            this.colEventsTablename.Width = 150;
            // 
            // colEventsTableidfieldname
            // 
            this.colEventsTableidfieldname.Text = "Tableidfieldname";
            this.colEventsTableidfieldname.Width = 0;
            // 
            // colEventsTableid
            // 
            this.colEventsTableid.Text = "Tableid";
            this.colEventsTableid.Width = 0;
            // 
            // colEventsUserid
            // 
            this.colEventsUserid.Text = "User Log In Name";
            this.colEventsUserid.Width = 150;
            // 
            // colEventsUsername
            // 
            this.colEventsUsername.Text = "User Name";
            this.colEventsUsername.Width = 200;
            // 
            // colEventsEventdate
            // 
            this.colEventsEventdate.Text = "Event Date";
            this.colEventsEventdate.Width = 100;
            // 
            // colEventsEventtime
            // 
            this.colEventsEventtime.Text = "Event Time";
            this.colEventsEventtime.Width = 90;
            // 
            // colEventsEventtype
            // 
            this.colEventsEventtype.Text = "Event Type";
            this.colEventsEventtype.Width = 100;
            // 
            // colEventsSearchfield
            // 
            this.colEventsSearchfield.Text = "Search Field";
            this.colEventsSearchfield.Width = 120;
            // 
            // colEventsSearchvalue
            // 
            this.colEventsSearchvalue.Text = "Search Value";
            this.colEventsSearchvalue.Width = 120;
            // 
            // colEventsComputername
            // 
            this.colEventsComputername.Text = "Computer Name";
            this.colEventsComputername.Width = 120;
            // 
            // colEventsRestored
            // 
            this.colEventsRestored.Text = "Restored";
            this.colEventsRestored.Width = 0;
            // 
            // colEventsMerged
            // 
            this.colEventsMerged.Text = "Merged";
            this.colEventsMerged.Width = 0;
            // 
            // colEventsTablerowguid
            // 
            this.colEventsTablerowguid.Text = "Tablerowguid";
            this.colEventsTablerowguid.Width = 0;
            // 
            // ssEvents
            // 
            this.ssEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssEvents.Location = new System.Drawing.Point(0, 742);
            this.ssEvents.Name = "ssEvents";
            this.ssEvents.Size = new System.Drawing.Size(1184, 22);
            this.ssEvents.TabIndex = 45;
            this.ssEvents.Text = "ssEvents";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(44, 17);
            this.lblMsg.Text = "lblMsg";
            // 
            // mValidator
            // 
            this.mValidator.ContainerControl = this;
            // 
            // lblEventsComputername
            // 
            this.lblEventsComputername.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEventsComputername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventsComputername.Location = new System.Drawing.Point(9, 116);
            this.lblEventsComputername.Name = "lblEventsComputername";
            this.lblEventsComputername.Size = new System.Drawing.Size(124, 18);
            this.lblEventsComputername.TabIndex = 146;
            this.lblEventsComputername.Text = "Computer Name";
            this.lblEventsComputername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEventsSearchvalue
            // 
            this.txtEventsSearchvalue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventsSearchvalue.Location = new System.Drawing.Point(178, 193);
            this.txtEventsSearchvalue.Name = "txtEventsSearchvalue";
            this.txtEventsSearchvalue.Size = new System.Drawing.Size(279, 23);
            this.txtEventsSearchvalue.TabIndex = 141;
            // 
            // lblEventsSearchvalue
            // 
            this.lblEventsSearchvalue.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEventsSearchvalue.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventsSearchvalue.Location = new System.Drawing.Point(178, 172);
            this.lblEventsSearchvalue.Name = "lblEventsSearchvalue";
            this.lblEventsSearchvalue.Size = new System.Drawing.Size(107, 18);
            this.lblEventsSearchvalue.TabIndex = 146;
            this.lblEventsSearchvalue.Text = "Search Value";
            this.lblEventsSearchvalue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEventsSearchfield
            // 
            this.txtEventsSearchfield.Enabled = false;
            this.txtEventsSearchfield.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventsSearchfield.Location = new System.Drawing.Point(9, 192);
            this.txtEventsSearchfield.Name = "txtEventsSearchfield";
            this.txtEventsSearchfield.Size = new System.Drawing.Size(163, 23);
            this.txtEventsSearchfield.TabIndex = 141;
            // 
            // lblEventsSearchfield
            // 
            this.lblEventsSearchfield.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEventsSearchfield.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventsSearchfield.Location = new System.Drawing.Point(9, 172);
            this.lblEventsSearchfield.Name = "lblEventsSearchfield";
            this.lblEventsSearchfield.Size = new System.Drawing.Size(142, 18);
            this.lblEventsSearchfield.TabIndex = 146;
            this.lblEventsSearchfield.Text = "Search Field Name";
            this.lblEventsSearchfield.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEventsEventtype
            // 
            this.lblEventsEventtype.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEventsEventtype.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventsEventtype.Location = new System.Drawing.Point(9, 19);
            this.lblEventsEventtype.Name = "lblEventsEventtype";
            this.lblEventsEventtype.Size = new System.Drawing.Size(107, 18);
            this.lblEventsEventtype.TabIndex = 146;
            this.lblEventsEventtype.Text = "Event Type";
            this.lblEventsEventtype.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEventsEventtimefrom
            // 
            this.txtEventsEventtimefrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventsEventtimefrom.Location = new System.Drawing.Point(13, 47);
            this.txtEventsEventtimefrom.Name = "txtEventsEventtimefrom";
            this.txtEventsEventtimefrom.Size = new System.Drawing.Size(107, 23);
            this.txtEventsEventtimefrom.TabIndex = 141;
            // 
            // lblEventsEventtime
            // 
            this.lblEventsEventtime.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEventsEventtime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventsEventtime.Location = new System.Drawing.Point(10, 23);
            this.lblEventsEventtime.Name = "lblEventsEventtime";
            this.lblEventsEventtime.Size = new System.Drawing.Size(107, 21);
            this.lblEventsEventtime.TabIndex = 146;
            this.lblEventsEventtime.Text = "Event Time From ";
            this.lblEventsEventtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEventsEventdatefrom
            // 
            this.txtEventsEventdatefrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventsEventdatefrom.Location = new System.Drawing.Point(9, 45);
            this.txtEventsEventdatefrom.Name = "txtEventsEventdatefrom";
            this.txtEventsEventdatefrom.Size = new System.Drawing.Size(107, 23);
            this.txtEventsEventdatefrom.TabIndex = 141;
            // 
            // lblEventsEventdate
            // 
            this.lblEventsEventdate.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEventsEventdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventsEventdate.Location = new System.Drawing.Point(6, 24);
            this.lblEventsEventdate.Name = "lblEventsEventdate";
            this.lblEventsEventdate.Size = new System.Drawing.Size(107, 18);
            this.lblEventsEventdate.TabIndex = 146;
            this.lblEventsEventdate.Text = "Event Date From ";
            this.lblEventsEventdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEventsUsername
            // 
            this.txtEventsUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventsUsername.Location = new System.Drawing.Point(178, 90);
            this.txtEventsUsername.Name = "txtEventsUsername";
            this.txtEventsUsername.Size = new System.Drawing.Size(279, 23);
            this.txtEventsUsername.TabIndex = 141;
            // 
            // lblEventsUsername
            // 
            this.lblEventsUsername.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEventsUsername.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventsUsername.Location = new System.Drawing.Point(178, 69);
            this.lblEventsUsername.Name = "lblEventsUsername";
            this.lblEventsUsername.Size = new System.Drawing.Size(107, 18);
            this.lblEventsUsername.TabIndex = 146;
            this.lblEventsUsername.Text = "User Full Name";
            this.lblEventsUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEventsUserid
            // 
            this.txtEventsUserid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventsUserid.Location = new System.Drawing.Point(9, 90);
            this.txtEventsUserid.Name = "txtEventsUserid";
            this.txtEventsUserid.Size = new System.Drawing.Size(160, 23);
            this.txtEventsUserid.TabIndex = 141;
            // 
            // lblEventsUserid
            // 
            this.lblEventsUserid.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEventsUserid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventsUserid.Location = new System.Drawing.Point(9, 65);
            this.lblEventsUserid.Name = "lblEventsUserid";
            this.lblEventsUserid.Size = new System.Drawing.Size(110, 18);
            this.lblEventsUserid.TabIndex = 146;
            this.lblEventsUserid.Text = "User Log In Name";
            this.lblEventsUserid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEventsComputerName
            // 
            this.txtEventsComputerName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventsComputerName.Location = new System.Drawing.Point(9, 141);
            this.txtEventsComputerName.Name = "txtEventsComputerName";
            this.txtEventsComputerName.Size = new System.Drawing.Size(448, 23);
            this.txtEventsComputerName.TabIndex = 141;
            // 
            // cboEventsTablename
            // 
            this.cboEventsTablename.AllowDrop = true;
            this.cboEventsTablename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventsTablename.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboEventsTablename.FormattingEnabled = true;
            this.cboEventsTablename.Location = new System.Drawing.Point(178, 38);
            this.cboEventsTablename.Name = "cboEventsTablename";
            this.cboEventsTablename.Size = new System.Drawing.Size(279, 24);
            this.cboEventsTablename.TabIndex = 125;
            this.cboEventsTablename.SelectedIndexChanged += new System.EventHandler(this.cboEventsTablename_SelectedIndexChanged);
            // 
            // lblEventsTablename
            // 
            this.lblEventsTablename.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEventsTablename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEventsTablename.Location = new System.Drawing.Point(178, 19);
            this.lblEventsTablename.Name = "lblEventsTablename";
            this.lblEventsTablename.Size = new System.Drawing.Size(107, 18);
            this.lblEventsTablename.TabIndex = 146;
            this.lblEventsTablename.Text = "Table Name";
            this.lblEventsTablename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpEventsEntry
            // 
            this.grpEventsEntry.Controls.Add(this.chkEventTime);
            this.grpEventsEntry.Controls.Add(this.grbEventTime);
            this.grpEventsEntry.Controls.Add(this.chkEventDate);
            this.grpEventsEntry.Controls.Add(this.grbEventDate);
            this.grpEventsEntry.Controls.Add(this.cboEventType);
            this.grpEventsEntry.Controls.Add(this.lblEventsTablename);
            this.grpEventsEntry.Controls.Add(this.cboEventsTablename);
            this.grpEventsEntry.Controls.Add(this.txtEventsComputerName);
            this.grpEventsEntry.Controls.Add(this.lblEventsUserid);
            this.grpEventsEntry.Controls.Add(this.txtEventsUserid);
            this.grpEventsEntry.Controls.Add(this.lblEventsUsername);
            this.grpEventsEntry.Controls.Add(this.txtEventsUsername);
            this.grpEventsEntry.Controls.Add(this.lblEventsEventtype);
            this.grpEventsEntry.Controls.Add(this.lblEventsSearchfield);
            this.grpEventsEntry.Controls.Add(this.txtEventsSearchfield);
            this.grpEventsEntry.Controls.Add(this.lblEventsSearchvalue);
            this.grpEventsEntry.Controls.Add(this.txtEventsSearchvalue);
            this.grpEventsEntry.Controls.Add(this.lblEventsComputername);
            this.grpEventsEntry.Location = new System.Drawing.Point(9, 37);
            this.grpEventsEntry.Name = "grpEventsEntry";
            this.grpEventsEntry.Size = new System.Drawing.Size(731, 243);
            this.grpEventsEntry.TabIndex = 3;
            this.grpEventsEntry.TabStop = false;
            // 
            // chkEventTime
            // 
            this.chkEventTime.AutoSize = true;
            this.chkEventTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEventTime.Location = new System.Drawing.Point(475, 125);
            this.chkEventTime.Name = "chkEventTime";
            this.chkEventTime.Size = new System.Drawing.Size(99, 20);
            this.chkEventTime.TabIndex = 151;
            this.chkEventTime.Text = "Event Time  ";
            this.chkEventTime.UseVisualStyleBackColor = true;
            this.chkEventTime.CheckedChanged += new System.EventHandler(this.chkEventTime_CheckedChanged);
            // 
            // grbEventTime
            // 
            this.grbEventTime.Controls.Add(this.label2);
            this.grbEventTime.Controls.Add(this.txtEventsEventtimeto);
            this.grbEventTime.Controls.Add(this.lblEventsEventtime);
            this.grbEventTime.Controls.Add(this.txtEventsEventtimefrom);
            this.grbEventTime.Location = new System.Drawing.Point(470, 125);
            this.grbEventTime.Name = "grbEventTime";
            this.grbEventTime.Size = new System.Drawing.Size(255, 90);
            this.grbEventTime.TabIndex = 150;
            this.grbEventTime.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(133, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 148;
            this.label2.Text = "Event Time To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEventsEventtimeto
            // 
            this.txtEventsEventtimeto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventsEventtimeto.Location = new System.Drawing.Point(136, 47);
            this.txtEventsEventtimeto.Name = "txtEventsEventtimeto";
            this.txtEventsEventtimeto.Size = new System.Drawing.Size(107, 23);
            this.txtEventsEventtimeto.TabIndex = 147;
            // 
            // chkEventDate
            // 
            this.chkEventDate.AutoSize = true;
            this.chkEventDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEventDate.Location = new System.Drawing.Point(475, 16);
            this.chkEventDate.Name = "chkEventDate";
            this.chkEventDate.Size = new System.Drawing.Size(88, 20);
            this.chkEventDate.TabIndex = 149;
            this.chkEventDate.Text = "Event Date";
            this.chkEventDate.UseVisualStyleBackColor = true;
            this.chkEventDate.CheckedChanged += new System.EventHandler(this.chkEventDate_CheckedChanged);
            // 
            // grbEventDate
            // 
            this.grbEventDate.Controls.Add(this.label1);
            this.grbEventDate.Controls.Add(this.txtEventsEventdateto);
            this.grbEventDate.Controls.Add(this.lblEventsEventdate);
            this.grbEventDate.Controls.Add(this.txtEventsEventdatefrom);
            this.grbEventDate.Location = new System.Drawing.Point(470, 19);
            this.grbEventDate.Name = "grbEventDate";
            this.grbEventDate.Size = new System.Drawing.Size(255, 92);
            this.grbEventDate.TabIndex = 148;
            this.grbEventDate.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(132, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 148;
            this.label1.Text = "Event Date To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEventsEventdateto
            // 
            this.txtEventsEventdateto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventsEventdateto.Location = new System.Drawing.Point(135, 43);
            this.txtEventsEventdateto.Name = "txtEventsEventdateto";
            this.txtEventsEventdateto.Size = new System.Drawing.Size(107, 23);
            this.txtEventsEventdateto.TabIndex = 147;
            // 
            // cboEventType
            // 
            this.cboEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEventType.FormattingEnabled = true;
            this.cboEventType.Location = new System.Drawing.Point(9, 38);
            this.cboEventType.Name = "cboEventType";
            this.cboEventType.Size = new System.Drawing.Size(163, 24);
            this.cboEventType.TabIndex = 147;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnRestoreEvent);
            this.groupBox1.Controls.Add(this.btnFindEvents);
            this.groupBox1.Location = new System.Drawing.Point(12, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1160, 58);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(441, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::Pharma.Properties.Resources.New;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(297, 19);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(130, 27);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Clear Form";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNewEvents_Click);
            // 
            // btnRestoreEvent
            // 
            this.btnRestoreEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestoreEvent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreEvent.Image = global::Pharma.Properties.Resources.Undo;
            this.btnRestoreEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestoreEvent.Location = new System.Drawing.Point(153, 19);
            this.btnRestoreEvent.Name = "btnRestoreEvent";
            this.btnRestoreEvent.Size = new System.Drawing.Size(130, 27);
            this.btnRestoreEvent.TabIndex = 1;
            this.btnRestoreEvent.Text = "   Restore Event";
            this.btnRestoreEvent.UseVisualStyleBackColor = true;
            this.btnRestoreEvent.Click += new System.EventHandler(this.btnRestoreEvent_Click);
            // 
            // btnFindEvents
            // 
            this.btnFindEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFindEvents.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindEvents.Image = global::Pharma.Properties.Resources.refresh;
            this.btnFindEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindEvents.Location = new System.Drawing.Point(9, 19);
            this.btnFindEvents.Name = "btnFindEvents";
            this.btnFindEvents.Size = new System.Drawing.Size(130, 27);
            this.btnFindEvents.TabIndex = 0;
            this.btnFindEvents.Text = "Find Events";
            this.btnFindEvents.UseVisualStyleBackColor = true;
            this.btnFindEvents.Click += new System.EventHandler(this.btnFindEvents_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(-3, -2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1022, 36);
            this.lblTitle.TabIndex = 47;
            this.lblTitle.Text = "   Event Viewer ";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grbEventColumnCriteria
            // 
            this.grbEventColumnCriteria.Controls.Add(this.cboColumnValue);
            this.grbEventColumnCriteria.Controls.Add(this.cboOperator);
            this.grbEventColumnCriteria.Controls.Add(this.label6);
            this.grbEventColumnCriteria.Controls.Add(this.label4);
            this.grbEventColumnCriteria.Controls.Add(this.txtColumnType);
            this.grbEventColumnCriteria.Controls.Add(this.btnRemove);
            this.grbEventColumnCriteria.Controls.Add(this.btnAdd);
            this.grbEventColumnCriteria.Controls.Add(this.lvwColumnCriteria);
            this.grbEventColumnCriteria.Controls.Add(this.label5);
            this.grbEventColumnCriteria.Controls.Add(this.txtColumnValueField);
            this.grbEventColumnCriteria.Controls.Add(this.label3);
            this.grbEventColumnCriteria.Controls.Add(this.cboTableCurrentFields);
            this.grbEventColumnCriteria.Location = new System.Drawing.Point(747, 38);
            this.grbEventColumnCriteria.Name = "grbEventColumnCriteria";
            this.grbEventColumnCriteria.Size = new System.Drawing.Size(425, 242);
            this.grbEventColumnCriteria.TabIndex = 48;
            this.grbEventColumnCriteria.TabStop = false;
            // 
            // cboOperator
            // 
            this.cboOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperator.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Location = new System.Drawing.Point(9, 80);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(61, 24);
            this.cboOperator.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(9, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 158;
            this.label6.Text = "Operator";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(265, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 157;
            this.label4.Text = "Column Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtColumnType
            // 
            this.txtColumnType.Enabled = false;
            this.txtColumnType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnType.Location = new System.Drawing.Point(268, 36);
            this.txtColumnType.Name = "txtColumnType";
            this.txtColumnType.Size = new System.Drawing.Size(148, 23);
            this.txtColumnType.TabIndex = 156;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemove.Image = global::Pharma.Properties.Resources.MINUS;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(333, 80);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 23);
            this.btnRemove.TabIndex = 155;
            this.btnRemove.Text = "Remove";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Image = global::Pharma.Properties.Resources.PLUS;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(268, 80);
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
            this.colColumnName,
            this.colOperator,
            this.colColumnValue,
            this.colColumnType});
            this.lvwColumnCriteria.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lvwColumnCriteria.FullRowSelect = true;
            this.lvwColumnCriteria.GridLines = true;
            this.lvwColumnCriteria.LabelWrap = false;
            this.lvwColumnCriteria.Location = new System.Drawing.Point(9, 109);
            this.lvwColumnCriteria.Name = "lvwColumnCriteria";
            this.lvwColumnCriteria.Size = new System.Drawing.Size(410, 127);
            this.lvwColumnCriteria.TabIndex = 153;
            this.lvwColumnCriteria.UseCompatibleStateImageBehavior = false;
            this.lvwColumnCriteria.View = System.Windows.Forms.View.Details;
            // 
            // colColumnName
            // 
            this.colColumnName.Text = "Column Name";
            this.colColumnName.Width = 200;
            // 
            // colOperator
            // 
            this.colOperator.Text = "Operator";
            this.colOperator.Width = 70;
            // 
            // colColumnValue
            // 
            this.colColumnValue.Text = "Column Value";
            this.colColumnValue.Width = 150;
            // 
            // colColumnType
            // 
            this.colColumnType.Text = "Column Type";
            this.colColumnType.Width = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(73, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 152;
            this.label5.Text = "Column Value";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtColumnValueField
            // 
            this.txtColumnValueField.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnValueField.Location = new System.Drawing.Point(73, 80);
            this.txtColumnValueField.Name = "txtColumnValueField";
            this.txtColumnValueField.Size = new System.Drawing.Size(189, 23);
            this.txtColumnValueField.TabIndex = 151;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 18);
            this.label3.TabIndex = 148;
            this.label3.Text = " Table Columns (Current)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboTableCurrentFields
            // 
            this.cboTableCurrentFields.AllowDrop = true;
            this.cboTableCurrentFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableCurrentFields.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboTableCurrentFields.FormattingEnabled = true;
            this.cboTableCurrentFields.Location = new System.Drawing.Point(9, 34);
            this.cboTableCurrentFields.Name = "cboTableCurrentFields";
            this.cboTableCurrentFields.Size = new System.Drawing.Size(253, 24);
            this.cboTableCurrentFields.TabIndex = 147;
            this.cboTableCurrentFields.SelectedIndexChanged += new System.EventHandler(this.cboTableCurrentFields_SelectedIndexChanged);
            // 
            // grvEventData
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvEventData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grvEventData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEventData.Location = new System.Drawing.Point(9, 614);
            this.grvEventData.Name = "grvEventData";
            this.grvEventData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvEventData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grvEventData.Size = new System.Drawing.Size(1157, 125);
            this.grvEventData.TabIndex = 49;
            // 
            // cboColumnValue
            // 
            this.cboColumnValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColumnValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColumnValue.FormattingEnabled = true;
            this.cboColumnValue.Location = new System.Drawing.Point(73, 79);
            this.cboColumnValue.Name = "cboColumnValue";
            this.cboColumnValue.Size = new System.Drawing.Size(189, 24);
            this.cboColumnValue.TabIndex = 160;
            this.cboColumnValue.Visible = false;
            // 
            // frmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 764);
            this.Controls.Add(this.grvEventData);
            this.Controls.Add(this.grbEventColumnCriteria);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ssEvents);
            this.Controls.Add(this.grpEventsEntry);
            this.Controls.Add(this.grpEventsList);
            this.Name = "frmEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Load += new System.EventHandler(this.frmEvents_Load);
            this.Activated += new System.EventHandler(this.frmEvents_Activated);
            this.grpEventsList.ResumeLayout(false);
            this.ssEvents.ResumeLayout(false);
            this.ssEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.grpEventsEntry.ResumeLayout(false);
            this.grpEventsEntry.PerformLayout();
            this.grbEventTime.ResumeLayout(false);
            this.grbEventTime.PerformLayout();
            this.grbEventDate.ResumeLayout(false);
            this.grbEventDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grbEventColumnCriteria.ResumeLayout(false);
            this.grbEventColumnCriteria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvEventData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion



        // Declare Controls
        // put this in the InitializeComponents Method

        // put these outside the InitializeComponents Method

        private System.Windows.Forms.StatusStrip ssEvents;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.GroupBox grpEventsList;
        private System.Windows.Forms.ListView lvwEvents;

        private System.Windows.Forms.ColumnHeader colEventsId;
        private System.Windows.Forms.ColumnHeader colEventsTablename;
        private System.Windows.Forms.ColumnHeader colEventsTableidfieldname;
        private System.Windows.Forms.ColumnHeader colEventsTableid;
        private System.Windows.Forms.ColumnHeader colEventsUserid;
        private System.Windows.Forms.ColumnHeader colEventsUsername;
        private System.Windows.Forms.ColumnHeader colEventsEventdate;
        private System.Windows.Forms.ColumnHeader colEventsEventtime;
        private System.Windows.Forms.ColumnHeader colEventsEventtype;
        private System.Windows.Forms.ColumnHeader colEventsSearchfield;
        private System.Windows.Forms.ColumnHeader colEventsSearchvalue;
        private System.Windows.Forms.ColumnHeader colEventsComputername;
        private System.Windows.Forms.ColumnHeader colEventsRestored;
        private System.Windows.Forms.ColumnHeader colEventsMerged;
        private System.Windows.Forms.ColumnHeader colEventsTablerowguid;
        private System.Windows.Forms.GroupBox grpEventsEntry;
        private System.Windows.Forms.Label lblEventsTablename;
        private System.Windows.Forms.ComboBox cboEventsTablename;
        private System.Windows.Forms.TextBox txtEventsComputerName;
        private System.Windows.Forms.Label lblEventsUserid;
        private System.Windows.Forms.TextBox txtEventsUserid;
        private System.Windows.Forms.Label lblEventsUsername;
        private System.Windows.Forms.TextBox txtEventsUsername;
        private System.Windows.Forms.Label lblEventsEventdate;
        private System.Windows.Forms.TextBox txtEventsEventdatefrom;
        private System.Windows.Forms.Label lblEventsEventtime;
        private System.Windows.Forms.TextBox txtEventsEventtimefrom;
        private System.Windows.Forms.Label lblEventsEventtype;
        private System.Windows.Forms.Label lblEventsSearchfield;
        private System.Windows.Forms.TextBox txtEventsSearchfield;
        private System.Windows.Forms.Label lblEventsSearchvalue;
        private System.Windows.Forms.TextBox txtEventsSearchvalue;
        private System.Windows.Forms.Label lblEventsComputername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbEventDate;
        private System.Windows.Forms.ComboBox cboEventType;
        private System.Windows.Forms.GroupBox grbEventTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEventsEventtimeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventsEventdateto;
        private System.Windows.Forms.CheckBox chkEventTime;
        private System.Windows.Forms.CheckBox chkEventDate;
        private System.Windows.Forms.GroupBox grbEventColumnCriteria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTableCurrentFields;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColumnValueField;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvwColumnCriteria;
        private System.Windows.Forms.ColumnHeader colColumnName;
        private System.Windows.Forms.ColumnHeader colColumnValue;
        private System.Windows.Forms.Button btnRestoreEvent;
        private System.Windows.Forms.Button btnFindEvents;
        private System.Windows.Forms.DataGridView grvEventData;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ColumnHeader colColumnType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColumnType;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader colOperator;
        private System.Windows.Forms.ComboBox cboColumnValue;


    }
}
