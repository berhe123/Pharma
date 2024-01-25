namespace Pharma
{
    partial class frmIssuance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssuance));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTransactionDateTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransactionDateFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStoreNameSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStoreLocationSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwTransactions = new System.Windows.Forms.ListView();
            this.colTrasactionId = new System.Windows.Forms.ColumnHeader();
            this.colStoreName = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceGuid = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceNumber = new System.Windows.Forms.ColumnHeader();
            this.colRefNo = new System.Windows.Forms.ColumnHeader();
            this.colTransactionType = new System.Windows.Forms.ColumnHeader();
            this.colTransactionBy = new System.Windows.Forms.ColumnHeader();
            this.colTransactionDate = new System.Windows.Forms.ColumnHeader();
            this.colLocationName = new System.Windows.Forms.ColumnHeader();
            this.colIssuedTo = new System.Windows.Forms.ColumnHeader();
            this.grpDataEntry = new System.Windows.Forms.GroupBox();
            this.cboIssuedTo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboStoreLocation = new System.Windows.Forms.ComboBox();
            this.txtIssuedTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransactionDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTransactionBy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReferenceNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboStoreName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssbValidator = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelToolBar = new System.Windows.Forms.Panel();
            this.proformaToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.lblVoid = new System.Windows.Forms.Label();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.lvwInvoiceDetails = new System.Windows.Forms.ListView();
            this.colInvoiceDetailsId = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceDetailsInvoiceGuid = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceDetailsBatchGuid = new System.Windows.Forms.ColumnHeader();
            this.colBatchNumber = new System.Windows.Forms.ColumnHeader();
            this.colItemName = new System.Windows.Forms.ColumnHeader();
            this.colUnitOfMeasurement = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceDetailsQuantity = new System.Windows.Forms.ColumnHeader();
            this.colUnitPrice = new System.Windows.Forms.ColumnHeader();
            this.colLineTotal = new System.Windows.Forms.ColumnHeader();
            this.cboInvoiceType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInvoiceCustormerName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblDelivered = new System.Windows.Forms.Label();
            this.tabControlIssuanceDetail = new System.Windows.Forms.TabControl();
            this.tabPageIssuanceDetail = new System.Windows.Forms.TabPage();
            this.proformaDetailToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSaveDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetBatchesFromInvoice = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.grpDataEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).BeginInit();
            this.ssbValidator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panelToolBar.SuspendLayout();
            this.proformaToolStrip.SuspendLayout();
            this.grpInvoice.SuspendLayout();
            this.tabControlIssuanceDetail.SuspendLayout();
            this.tabPageIssuanceDetail.SuspendLayout();
            this.proformaDetailToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtTransactionDateTo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTransactionDateFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboStoreNameSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboStoreLocationSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(331, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(7, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(319, 26);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTransactionDateTo
            // 
            this.txtTransactionDateTo.Location = new System.Drawing.Point(171, 84);
            this.txtTransactionDateTo.Name = "txtTransactionDateTo";
            this.txtTransactionDateTo.Size = new System.Drawing.Size(154, 22);
            this.txtTransactionDateTo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Issuance Date To";
            // 
            // txtTransactionDateFrom
            // 
            this.txtTransactionDateFrom.Location = new System.Drawing.Point(8, 84);
            this.txtTransactionDateFrom.Name = "txtTransactionDateFrom";
            this.txtTransactionDateFrom.Size = new System.Drawing.Size(154, 22);
            this.txtTransactionDateFrom.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Issuance Date From";
            // 
            // cboStoreNameSearch
            // 
            this.cboStoreNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreNameSearch.FormattingEnabled = true;
            this.cboStoreNameSearch.Location = new System.Drawing.Point(171, 37);
            this.cboStoreNameSearch.Name = "cboStoreNameSearch";
            this.cboStoreNameSearch.Size = new System.Drawing.Size(154, 22);
            this.cboStoreNameSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Store Name";
            // 
            // cboStoreLocationSearch
            // 
            this.cboStoreLocationSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocationSearch.FormattingEnabled = true;
            this.cboStoreLocationSearch.Location = new System.Drawing.Point(8, 37);
            this.cboStoreLocationSearch.Name = "cboStoreLocationSearch";
            this.cboStoreLocationSearch.Size = new System.Drawing.Size(154, 22);
            this.cboStoreLocationSearch.TabIndex = 4;
            this.cboStoreLocationSearch.SelectedIndexChanged += new System.EventHandler(this.cboStoreLocationSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Store Location";
            // 
            // lvwTransactions
            // 
            this.lvwTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTrasactionId,
            this.colStoreName,
            this.colInvoiceGuid,
            this.colInvoiceNumber,
            this.colRefNo,
            this.colTransactionType,
            this.colTransactionBy,
            this.colTransactionDate,
            this.colLocationName,
            this.colIssuedTo});
            this.lvwTransactions.FullRowSelect = true;
            this.lvwTransactions.GridLines = true;
            this.lvwTransactions.Location = new System.Drawing.Point(7, 190);
            this.lvwTransactions.Name = "lvwTransactions";
            this.lvwTransactions.Size = new System.Drawing.Size(331, 476);
            this.lvwTransactions.TabIndex = 12;
            this.lvwTransactions.UseCompatibleStateImageBehavior = false;
            this.lvwTransactions.View = System.Windows.Forms.View.Details;
            this.lvwTransactions.SelectedIndexChanged += new System.EventHandler(this.lvwTransactions_SelectedIndexChanged);
            this.lvwTransactions.Click += new System.EventHandler(this.lvwTransactions_Click);
            // 
            // colTrasactionId
            // 
            this.colTrasactionId.Text = "id";
            this.colTrasactionId.Width = 0;
            // 
            // colStoreName
            // 
            this.colStoreName.Text = "Store Name";
            this.colStoreName.Width = 0;
            // 
            // colInvoiceGuid
            // 
            this.colInvoiceGuid.Text = "Invoice Guid";
            this.colInvoiceGuid.Width = 0;
            // 
            // colInvoiceNumber
            // 
            this.colInvoiceNumber.Text = "Invoice #";
            this.colInvoiceNumber.Width = 90;
            // 
            // colRefNo
            // 
            this.colRefNo.Text = "Reference #";
            this.colRefNo.Width = 100;
            // 
            // colTransactionType
            // 
            this.colTransactionType.Width = 0;
            // 
            // colTransactionBy
            // 
            this.colTransactionBy.Width = 0;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Text = "Issuance Date";
            this.colTransactionDate.Width = 110;
            // 
            // colLocationName
            // 
            this.colLocationName.Text = "LocationName";
            this.colLocationName.Width = 0;
            // 
            // colIssuedTo
            // 
            this.colIssuedTo.Text = "Issued To";
            this.colIssuedTo.Width = 0;
            // 
            // grpDataEntry
            // 
            this.grpDataEntry.Controls.Add(this.cboIssuedTo);
            this.grpDataEntry.Controls.Add(this.label12);
            this.grpDataEntry.Controls.Add(this.cboStoreLocation);
            this.grpDataEntry.Controls.Add(this.txtIssuedTo);
            this.grpDataEntry.Controls.Add(this.label3);
            this.grpDataEntry.Controls.Add(this.txtTransactionDate);
            this.grpDataEntry.Controls.Add(this.label13);
            this.grpDataEntry.Controls.Add(this.txtTransactionBy);
            this.grpDataEntry.Controls.Add(this.label11);
            this.grpDataEntry.Controls.Add(this.txtReferenceNo);
            this.grpDataEntry.Controls.Add(this.label9);
            this.grpDataEntry.Controls.Add(this.cboStoreName);
            this.grpDataEntry.Controls.Add(this.label7);
            this.grpDataEntry.Controls.Add(this.label8);
            this.grpDataEntry.Location = new System.Drawing.Point(347, 273);
            this.grpDataEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDataEntry.Name = "grpDataEntry";
            this.grpDataEntry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDataEntry.Size = new System.Drawing.Size(719, 146);
            this.grpDataEntry.TabIndex = 25;
            this.grpDataEntry.TabStop = false;
            // 
            // cboIssuedTo
            // 
            this.cboIssuedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIssuedTo.FormattingEnabled = true;
            this.cboIssuedTo.Location = new System.Drawing.Point(232, 114);
            this.cboIssuedTo.Name = "cboIssuedTo";
            this.cboIssuedTo.Size = new System.Drawing.Size(209, 22);
            this.cboIssuedTo.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 14);
            this.label12.TabIndex = 39;
            this.label12.Text = "Issued To";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(232, 32);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(209, 22);
            this.cboStoreLocation.TabIndex = 38;
            this.cboStoreLocation.SelectedIndexChanged += new System.EventHandler(this.cboStoreLocation_SelectedIndexChanged);
            // 
            // txtIssuedTo
            // 
            this.txtIssuedTo.Location = new System.Drawing.Point(10, 118);
            this.txtIssuedTo.Name = "txtIssuedTo";
            this.txtIssuedTo.Size = new System.Drawing.Size(209, 22);
            this.txtIssuedTo.TabIndex = 37;
            this.txtIssuedTo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "Issued To";
            this.label3.Visible = false;
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(470, 75);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(206, 22);
            this.txtTransactionDate.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(470, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 14);
            this.label13.TabIndex = 34;
            this.label13.Text = "Issued Date";
            // 
            // txtTransactionBy
            // 
            this.txtTransactionBy.Location = new System.Drawing.Point(232, 75);
            this.txtTransactionBy.Name = "txtTransactionBy";
            this.txtTransactionBy.Size = new System.Drawing.Size(209, 22);
            this.txtTransactionBy.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 32;
            this.label11.Text = "Issued By";
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(10, 32);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(206, 22);
            this.txtReferenceNo.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 14);
            this.label9.TabIndex = 26;
            this.label9.Text = "Reference Number\r\n";
            // 
            // cboStoreName
            // 
            this.cboStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreName.FormattingEnabled = true;
            this.cboStoreName.Location = new System.Drawing.Point(470, 32);
            this.cboStoreName.Name = "cboStoreName";
            this.cboStoreName.Size = new System.Drawing.Size(206, 22);
            this.cboStoreName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 30;
            this.label7.Text = "Store Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(232, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 14);
            this.label8.TabIndex = 28;
            this.label8.Text = "Store Location";
            // 
            // grvTransactionDetails
            // 
            this.grvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colBatchGuid,
            this.colTransactionGuid,
            this.colBatchNo,
            this.colBrandName,
            this.colQuantity});
            this.grvTransactionDetails.Location = new System.Drawing.Point(4, 32);
            this.grvTransactionDetails.Name = "grvTransactionDetails";
            this.grvTransactionDetails.Size = new System.Drawing.Size(702, 174);
            this.grvTransactionDetails.TabIndex = 40;
            this.grvTransactionDetails.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grvTransactionDetails_UserDeletingRow);
            // 
            // colId
            // 
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colBatchGuid
            // 
            this.colBatchGuid.HeaderText = "BatchGuid";
            this.colBatchGuid.Name = "colBatchGuid";
            this.colBatchGuid.Visible = false;
            // 
            // colTransactionGuid
            // 
            this.colTransactionGuid.HeaderText = "TransactionGuid";
            this.colTransactionGuid.Name = "colTransactionGuid";
            this.colTransactionGuid.Visible = false;
            // 
            // colBatchNo
            // 
            this.colBatchNo.HeaderText = "Batch No";
            this.colBatchNo.Name = "colBatchNo";
            this.colBatchNo.ReadOnly = true;
            this.colBatchNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBatchNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colBatchNo.Width = 200;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            this.colBrandName.Width = 330;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // ssbValidator
            // 
            this.ssbValidator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssbValidator.Location = new System.Drawing.Point(0, 742);
            this.ssbValidator.Name = "ssbValidator";
            this.ssbValidator.Size = new System.Drawing.Size(1264, 22);
            this.ssbValidator.TabIndex = 41;
            this.ssbValidator.Text = "statusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // mValidator
            // 
            this.mValidator.ContainerControl = this;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(0, 36);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1022, 1);
            this.line3.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1022, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "    Goods Issuance";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolBar.Controls.Add(this.proformaToolStrip);
            this.panelToolBar.Location = new System.Drawing.Point(347, 40);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(710, 28);
            this.panelToolBar.TabIndex = 124;
            // 
            // proformaToolStrip
            // 
            this.proformaToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.proformaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnNew,
            this.btnSave,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnPrintPreview,
            this.toolStripSeparator1,
            this.btnClose});
            this.proformaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.proformaToolStrip.Name = "proformaToolStrip";
            this.proformaToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.proformaToolStrip.Size = new System.Drawing.Size(710, 25);
            this.proformaToolStrip.TabIndex = 13;
            this.proformaToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNew.Image = global::Pharma.Properties.Resources.New;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(53, 22);
            this.btnNew.Text = "New";
            this.btnNew.ToolTipText = "Prepare the system to accept a new goods issuance record";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Image = global::Pharma.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 22);
            this.btnSave.Text = "Save";
            this.btnSave.ToolTipText = "Save the current goods issuance record (i.e. newly created or edited)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Image = global::Pharma.Properties.Resources.delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Delete the currently selected goods issuance record";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintPreview.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(103, 22);
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.ToolTipText = "Preview the currently selected goods issuance record for printing";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 22);
            this.btnClose.Text = "Close";
            this.btnClose.ToolTipText = "Close the Goods Issuance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.lblVoid);
            this.grpInvoice.Controls.Add(this.btnSearchInvoice);
            this.grpInvoice.Controls.Add(this.lvwInvoiceDetails);
            this.grpInvoice.Controls.Add(this.cboInvoiceType);
            this.grpInvoice.Controls.Add(this.label15);
            this.grpInvoice.Controls.Add(this.txtInvoiceDate);
            this.grpInvoice.Controls.Add(this.label4);
            this.grpInvoice.Controls.Add(this.txtInvoiceNumber);
            this.grpInvoice.Controls.Add(this.label10);
            this.grpInvoice.Controls.Add(this.txtInvoiceCustormerName);
            this.grpInvoice.Controls.Add(this.label23);
            this.grpInvoice.Controls.Add(this.lblDelivered);
            this.grpInvoice.Location = new System.Drawing.Point(347, 72);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(899, 204);
            this.grpInvoice.TabIndex = 14;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "From Invoice";
            // 
            // lblVoid
            // 
            this.lblVoid.AutoSize = true;
            this.lblVoid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoid.ForeColor = System.Drawing.Color.Red;
            this.lblVoid.Location = new System.Drawing.Point(470, 74);
            this.lblVoid.Name = "lblVoid";
            this.lblVoid.Size = new System.Drawing.Size(130, 23);
            this.lblVoid.TabIndex = 71;
            this.lblVoid.Text = "Invoice is Void";
            this.lblVoid.Visible = false;
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchInvoice.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchInvoice.Image")));
            this.btnSearchInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchInvoice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchInvoice.Location = new System.Drawing.Point(186, 29);
            this.btnSearchInvoice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(30, 28);
            this.btnSearchInvoice.TabIndex = 17;
            this.btnSearchInvoice.TabStop = false;
            this.btnSearchInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchInvoice_Click);
            // 
            // lvwInvoiceDetails
            // 
            this.lvwInvoiceDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInvoiceDetailsId,
            this.colInvoiceDetailsInvoiceGuid,
            this.colInvoiceDetailsBatchGuid,
            this.colBatchNumber,
            this.colItemName,
            this.colUnitOfMeasurement,
            this.colInvoiceDetailsQuantity,
            this.colUnitPrice,
            this.colLineTotal});
            this.lvwInvoiceDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwInvoiceDetails.FullRowSelect = true;
            this.lvwInvoiceDetails.GridLines = true;
            this.lvwInvoiceDetails.Location = new System.Drawing.Point(10, 99);
            this.lvwInvoiceDetails.MultiSelect = false;
            this.lvwInvoiceDetails.Name = "lvwInvoiceDetails";
            this.lvwInvoiceDetails.Size = new System.Drawing.Size(702, 98);
            this.lvwInvoiceDetails.TabIndex = 24;
            this.lvwInvoiceDetails.UseCompatibleStateImageBehavior = false;
            this.lvwInvoiceDetails.View = System.Windows.Forms.View.Details;
            // 
            // colInvoiceDetailsId
            // 
            this.colInvoiceDetailsId.Text = "Id";
            this.colInvoiceDetailsId.Width = 0;
            // 
            // colInvoiceDetailsInvoiceGuid
            // 
            this.colInvoiceDetailsInvoiceGuid.Text = "Invoice Guid";
            this.colInvoiceDetailsInvoiceGuid.Width = 0;
            // 
            // colInvoiceDetailsBatchGuid
            // 
            this.colInvoiceDetailsBatchGuid.Text = "Batch Guid";
            this.colInvoiceDetailsBatchGuid.Width = 0;
            // 
            // colBatchNumber
            // 
            this.colBatchNumber.Text = "Batch Number";
            this.colBatchNumber.Width = 150;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Item Name";
            this.colItemName.Width = 300;
            // 
            // colUnitOfMeasurement
            // 
            this.colUnitOfMeasurement.Text = "Unit";
            this.colUnitOfMeasurement.Width = 150;
            // 
            // colInvoiceDetailsQuantity
            // 
            this.colInvoiceDetailsQuantity.Text = "Quantity";
            this.colInvoiceDetailsQuantity.Width = 70;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Text = "Unit Price";
            this.colUnitPrice.Width = 0;
            // 
            // colLineTotal
            // 
            this.colLineTotal.Text = "Total";
            this.colLineTotal.Width = 0;
            // 
            // cboInvoiceType
            // 
            this.cboInvoiceType.BackColor = System.Drawing.Color.Lavender;
            this.cboInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoiceType.Enabled = false;
            this.cboInvoiceType.FormattingEnabled = true;
            this.cboInvoiceType.Location = new System.Drawing.Point(470, 34);
            this.cboInvoiceType.Name = "cboInvoiceType";
            this.cboInvoiceType.Size = new System.Drawing.Size(206, 22);
            this.cboInvoiceType.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(470, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 14);
            this.label15.TabIndex = 20;
            this.label15.Text = "Invoice Type";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.BackColor = System.Drawing.Color.Lavender;
            this.txtInvoiceDate.Location = new System.Drawing.Point(232, 34);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(206, 22);
            this.txtInvoiceDate.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 14);
            this.label4.TabIndex = 18;
            this.label4.Text = "Invoice Date";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.BackColor = System.Drawing.Color.Lavender;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(10, 34);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(172, 22);
            this.txtInvoiceNumber.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "Invoice Number";
            // 
            // txtInvoiceCustormerName
            // 
            this.txtInvoiceCustormerName.BackColor = System.Drawing.Color.Lavender;
            this.txtInvoiceCustormerName.Location = new System.Drawing.Point(10, 74);
            this.txtInvoiceCustormerName.Name = "txtInvoiceCustormerName";
            this.txtInvoiceCustormerName.ReadOnly = true;
            this.txtInvoiceCustormerName.Size = new System.Drawing.Size(428, 22);
            this.txtInvoiceCustormerName.TabIndex = 23;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 60);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 14);
            this.label23.TabIndex = 22;
            this.label23.Text = "Customers Organization Name";
            // 
            // lblDelivered
            // 
            this.lblDelivered.AutoSize = true;
            this.lblDelivered.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivered.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDelivered.Location = new System.Drawing.Point(470, 74);
            this.lblDelivered.Name = "lblDelivered";
            this.lblDelivered.Size = new System.Drawing.Size(172, 23);
            this.lblDelivered.TabIndex = 72;
            this.lblDelivered.Text = "Invoice is Delivered";
            this.lblDelivered.Visible = false;
            // 
            // tabControlIssuanceDetail
            // 
            this.tabControlIssuanceDetail.Controls.Add(this.tabPageIssuanceDetail);
            this.tabControlIssuanceDetail.Location = new System.Drawing.Point(347, 424);
            this.tabControlIssuanceDetail.Name = "tabControlIssuanceDetail";
            this.tabControlIssuanceDetail.SelectedIndex = 0;
            this.tabControlIssuanceDetail.Size = new System.Drawing.Size(719, 238);
            this.tabControlIssuanceDetail.TabIndex = 38;
            // 
            // tabPageIssuanceDetail
            // 
            this.tabPageIssuanceDetail.Controls.Add(this.proformaDetailToolStrip);
            this.tabPageIssuanceDetail.Controls.Add(this.grvTransactionDetails);
            this.tabPageIssuanceDetail.Location = new System.Drawing.Point(4, 23);
            this.tabPageIssuanceDetail.Name = "tabPageIssuanceDetail";
            this.tabPageIssuanceDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIssuanceDetail.Size = new System.Drawing.Size(711, 211);
            this.tabPageIssuanceDetail.TabIndex = 1;
            this.tabPageIssuanceDetail.Text = "Issuance Detail";
            this.tabPageIssuanceDetail.UseVisualStyleBackColor = true;
            // 
            // proformaDetailToolStrip
            // 
            this.proformaDetailToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.proformaDetailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnSaveDetail,
            this.btnDeleteDetail,
            this.toolStripSeparator2,
            this.btnGetBatchesFromInvoice});
            this.proformaDetailToolStrip.Location = new System.Drawing.Point(3, 3);
            this.proformaDetailToolStrip.Name = "proformaDetailToolStrip";
            this.proformaDetailToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.proformaDetailToolStrip.Size = new System.Drawing.Size(705, 25);
            this.proformaDetailToolStrip.TabIndex = 39;
            this.proformaDetailToolStrip.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // btnSaveDetail
            // 
            this.btnSaveDetail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveDetail.Image = global::Pharma.Properties.Resources.save;
            this.btnSaveDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveDetail.Name = "btnSaveDetail";
            this.btnSaveDetail.Size = new System.Drawing.Size(56, 22);
            this.btnSaveDetail.Text = "Save";
            this.btnSaveDetail.ToolTipText = "Save the current goods issuance detail record (i.e. newly created or edited)";
            this.btnSaveDetail.Click += new System.EventHandler(this.btnSaveDetail_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDetail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteDetail.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeleteDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteDetail.Text = "Delete";
            this.btnDeleteDetail.ToolTipText = "Delete the currently selected goods issuance detail record";
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGetBatchesFromInvoice
            // 
            this.btnGetBatchesFromInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBatchesFromInvoice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetBatchesFromInvoice.Image = global::Pharma.Properties.Resources.refresh;
            this.btnGetBatchesFromInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetBatchesFromInvoice.Name = "btnGetBatchesFromInvoice";
            this.btnGetBatchesFromInvoice.Size = new System.Drawing.Size(173, 22);
            this.btnGetBatchesFromInvoice.Text = "Get Batches From Invoice";
            this.btnGetBatchesFromInvoice.ToolTipText = "Fill the goods issuance details list by importing data from the details of the in" +
                "voice selected above";
            this.btnGetBatchesFromInvoice.Click += new System.EventHandler(this.btnGetBatchesFromInvoice_Click);
            // 
            // frmIssuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 764);
            this.Controls.Add(this.tabControlIssuanceDetail);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvwTransactions);
            this.Controls.Add(this.ssbValidator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpDataEntry);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIssuance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Issuance";
            this.Load += new System.EventHandler(this.frmRecieving_Load);
            this.Resize += new System.EventHandler(this.frmIssuance_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDataEntry.ResumeLayout(false);
            this.grpDataEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).EndInit();
            this.ssbValidator.ResumeLayout(false);
            this.ssbValidator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.proformaToolStrip.ResumeLayout(false);
            this.proformaToolStrip.PerformLayout();
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.tabControlIssuanceDetail.ResumeLayout(false);
            this.tabPageIssuanceDetail.ResumeLayout(false);
            this.tabPageIssuanceDetail.PerformLayout();
            this.proformaDetailToolStrip.ResumeLayout(false);
            this.proformaDetailToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpDataEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStoreLocationSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStoreNameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTransactionDateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransactionDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip ssbValidator;
        private System.Windows.Forms.TextBox txtTransactionDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTransactionBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReferenceNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboStoreName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvwTransactions;
        private System.Windows.Forms.DataGridView grvTransactionDetails;
        private System.Windows.Forms.ColumnHeader colTrasactionId;
        private System.Windows.Forms.ColumnHeader colStoreName;
        private System.Windows.Forms.ColumnHeader colTransactionDate;
        private System.Windows.Forms.ColumnHeader colRefNo;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.ColumnHeader colTransactionBy;
        private System.Windows.Forms.ColumnHeader colTransactionType;
        private System.Windows.Forms.ColumnHeader colLocationName;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.ToolStrip proformaToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnPrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.ComboBox cboInvoiceType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInvoiceCustormerName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListView lvwInvoiceDetails;
        private System.Windows.Forms.ColumnHeader colInvoiceDetailsId;
        private System.Windows.Forms.ColumnHeader colInvoiceDetailsInvoiceGuid;
        private System.Windows.Forms.ColumnHeader colInvoiceDetailsBatchGuid;
        private System.Windows.Forms.ColumnHeader colInvoiceDetailsQuantity;
        private System.Windows.Forms.ColumnHeader colInvoiceGuid;
        private System.Windows.Forms.Button btnSearchInvoice;
        private System.Windows.Forms.TabControl tabControlIssuanceDetail;
        private System.Windows.Forms.TabPage tabPageIssuanceDetail;
        private System.Windows.Forms.ColumnHeader colBatchNumber;
        private System.Windows.Forms.ColumnHeader colItemName;
        private System.Windows.Forms.ColumnHeader colUnitPrice;
        private System.Windows.Forms.ColumnHeader colLineTotal;
        private System.Windows.Forms.ColumnHeader colUnitOfMeasurement;
        private System.Windows.Forms.ToolStrip proformaDetailToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnDelete;
        public System.Windows.Forms.ToolStripButton btnSaveDetail;
        public System.Windows.Forms.ToolStripButton btnDeleteDetail;
        public System.Windows.Forms.ToolStripButton btnGetBatchesFromInvoice;
        private System.Windows.Forms.TextBox txtIssuedTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader colIssuedTo;
        private System.Windows.Forms.ColumnHeader colInvoiceNumber;
        private System.Windows.Forms.Label lblVoid;
        private System.Windows.Forms.Label lblDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.ComboBox cboStoreLocation;
        private System.Windows.Forms.ComboBox cboIssuedTo;
        private System.Windows.Forms.Label label12;
    }
}