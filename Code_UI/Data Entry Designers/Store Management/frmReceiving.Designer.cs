namespace Pharma
{
    partial class frmReceiving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiving));
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
            this.colPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colStoreName = new System.Windows.Forms.ColumnHeader();
            this.colRefNo = new System.Windows.Forms.ColumnHeader();
            this.colTransactionType = new System.Windows.Forms.ColumnHeader();
            this.colTransactionBy = new System.Windows.Forms.ColumnHeader();
            this.colTransactionDate = new System.Windows.Forms.ColumnHeader();
            this.colCheckedBy = new System.Windows.Forms.ColumnHeader();
            this.colCheckedDate = new System.Windows.Forms.ColumnHeader();
            this.colDeliveredBy = new System.Windows.Forms.ColumnHeader();
            this.colDeliveryDate = new System.Windows.Forms.ColumnHeader();
            this.colLocationName = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderType = new System.Windows.Forms.ColumnHeader();
            this.grpDataEntry = new System.Windows.Forms.GroupBox();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDeliveredBy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckedDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTransactionDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCheckedBy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTransactionBy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReferenceNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboStoreName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboStoreLocation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.proformaDetailToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSaveDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetBatchesFromPurchaseOrder = new System.Windows.Forms.ToolStripButton();
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
            this.btnSearchPurchaseOrder = new System.Windows.Forms.Button();
            this.grpPO = new System.Windows.Forms.GroupBox();
            this.lvwBatchs = new System.Windows.Forms.ListView();
            this.colBatchsId = new System.Windows.Forms.ColumnHeader();
            this.colBatchsPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colBatchsBatchnumber = new System.Windows.Forms.ColumnHeader();
            this.colBatchsItemGuid = new System.Windows.Forms.ColumnHeader();
            this.colBatchsItemname = new System.Windows.Forms.ColumnHeader();
            this.colBatchsQuantity = new System.Windows.Forms.ColumnHeader();
            this.colBatchsPriceperunit = new System.Windows.Forms.ColumnHeader();
            this.colBatchsFreightpayments = new System.Windows.Forms.ColumnHeader();
            this.colBatchsInsurancepayments = new System.Windows.Forms.ColumnHeader();
            this.colBatchsBankpayments = new System.Windows.Forms.ColumnHeader();
            this.colBatchsOtherpayments = new System.Windows.Forms.ColumnHeader();
            this.colBatchsSuggestedsaleprice = new System.Windows.Forms.ColumnHeader();
            this.colBatchsSaleprice = new System.Windows.Forms.ColumnHeader();
            this.colBatchsManufactureddate = new System.Windows.Forms.ColumnHeader();
            this.colBatchsExpirydate = new System.Windows.Forms.ColumnHeader();
            this.dtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControlDetail = new System.Windows.Forms.TabControl();
            this.tabPageReceivingDetail = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.grpDataEntry.SuspendLayout();
            this.proformaDetailToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).BeginInit();
            this.ssbValidator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panelToolBar.SuspendLayout();
            this.proformaToolStrip.SuspendLayout();
            this.grpPO.SuspendLayout();
            this.tabControlDetail.SuspendLayout();
            this.tabPageReceivingDetail.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(6, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(374, 145);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(10, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(354, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTransactionDateTo
            // 
            this.txtTransactionDateTo.Location = new System.Drawing.Point(194, 82);
            this.txtTransactionDateTo.Name = "txtTransactionDateTo";
            this.txtTransactionDateTo.Size = new System.Drawing.Size(169, 22);
            this.txtTransactionDateTo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Recieving Date To";
            // 
            // txtTransactionDateFrom
            // 
            this.txtTransactionDateFrom.Location = new System.Drawing.Point(10, 82);
            this.txtTransactionDateFrom.Name = "txtTransactionDateFrom";
            this.txtTransactionDateFrom.Size = new System.Drawing.Size(169, 22);
            this.txtTransactionDateFrom.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Recieving Date From";
            // 
            // cboStoreNameSearch
            // 
            this.cboStoreNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreNameSearch.FormattingEnabled = true;
            this.cboStoreNameSearch.Location = new System.Drawing.Point(194, 31);
            this.cboStoreNameSearch.Name = "cboStoreNameSearch";
            this.cboStoreNameSearch.Size = new System.Drawing.Size(169, 22);
            this.cboStoreNameSearch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Store Name";
            // 
            // cboStoreLocationSearch
            // 
            this.cboStoreLocationSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocationSearch.FormattingEnabled = true;
            this.cboStoreLocationSearch.Location = new System.Drawing.Point(10, 31);
            this.cboStoreLocationSearch.Name = "cboStoreLocationSearch";
            this.cboStoreLocationSearch.Size = new System.Drawing.Size(169, 22);
            this.cboStoreLocationSearch.TabIndex = 4;
            this.cboStoreLocationSearch.SelectedIndexChanged += new System.EventHandler(this.cboStoreLocationSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Store Location";
            // 
            // lvwTransactions
            // 
            this.lvwTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTrasactionId,
            this.colPurchaseOrderGuid,
            this.colStoreName,
            this.colRefNo,
            this.colTransactionType,
            this.colTransactionBy,
            this.colTransactionDate,
            this.colCheckedBy,
            this.colCheckedDate,
            this.colDeliveredBy,
            this.colDeliveryDate,
            this.colLocationName,
            this.colPurchaseOrderType});
            this.lvwTransactions.FullRowSelect = true;
            this.lvwTransactions.GridLines = true;
            this.lvwTransactions.Location = new System.Drawing.Point(6, 192);
            this.lvwTransactions.Name = "lvwTransactions";
            this.lvwTransactions.Size = new System.Drawing.Size(374, 496);
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
            // colPurchaseOrderGuid
            // 
            this.colPurchaseOrderGuid.Text = "Purchase Order Guid";
            this.colPurchaseOrderGuid.Width = 0;
            // 
            // colStoreName
            // 
            this.colStoreName.Text = "Store Name";
            this.colStoreName.Width = 0;
            // 
            // colRefNo
            // 
            this.colRefNo.Text = "Reference Number";
            this.colRefNo.Width = 190;
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
            this.colTransactionDate.Text = "Recieving Date";
            this.colTransactionDate.Width = 150;
            // 
            // colCheckedBy
            // 
            this.colCheckedBy.Width = 0;
            // 
            // colCheckedDate
            // 
            this.colCheckedDate.Width = 0;
            // 
            // colDeliveredBy
            // 
            this.colDeliveredBy.Text = "Delivered By";
            this.colDeliveredBy.Width = 0;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.Text = "Delivery Date";
            this.colDeliveryDate.Width = 0;
            // 
            // colLocationName
            // 
            this.colLocationName.Text = "LocationName";
            this.colLocationName.Width = 0;
            // 
            // colPurchaseOrderType
            // 
            this.colPurchaseOrderType.Text = "PurchaseOrderType";
            this.colPurchaseOrderType.Width = 0;
            // 
            // grpDataEntry
            // 
            this.grpDataEntry.Controls.Add(this.txtDeliveryDate);
            this.grpDataEntry.Controls.Add(this.label3);
            this.grpDataEntry.Controls.Add(this.txtDeliveredBy);
            this.grpDataEntry.Controls.Add(this.label4);
            this.grpDataEntry.Controls.Add(this.txtCheckedDate);
            this.grpDataEntry.Controls.Add(this.label14);
            this.grpDataEntry.Controls.Add(this.txtTransactionDate);
            this.grpDataEntry.Controls.Add(this.label13);
            this.grpDataEntry.Controls.Add(this.txtCheckedBy);
            this.grpDataEntry.Controls.Add(this.label12);
            this.grpDataEntry.Controls.Add(this.txtTransactionBy);
            this.grpDataEntry.Controls.Add(this.label11);
            this.grpDataEntry.Controls.Add(this.txtReferenceNo);
            this.grpDataEntry.Controls.Add(this.label9);
            this.grpDataEntry.Controls.Add(this.cboStoreName);
            this.grpDataEntry.Controls.Add(this.label7);
            this.grpDataEntry.Controls.Add(this.cboStoreLocation);
            this.grpDataEntry.Controls.Add(this.label8);
            this.grpDataEntry.Location = new System.Drawing.Point(388, 254);
            this.grpDataEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDataEntry.Name = "grpDataEntry";
            this.grpDataEntry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDataEntry.Size = new System.Drawing.Size(691, 184);
            this.grpDataEntry.TabIndex = 21;
            this.grpDataEntry.TabStop = false;
            this.grpDataEntry.Text = "Goods Receiving";
            this.grpDataEntry.Enter += new System.EventHandler(this.grpDataEntry_Enter);
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(458, 154);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(206, 22);
            this.txtDeliveryDate.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 38;
            this.label3.Text = "Delivery Date";
            // 
            // txtDeliveredBy
            // 
            this.txtDeliveredBy.Location = new System.Drawing.Point(229, 154);
            this.txtDeliveredBy.Name = "txtDeliveredBy";
            this.txtDeliveredBy.Size = new System.Drawing.Size(206, 22);
            this.txtDeliveredBy.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 14);
            this.label4.TabIndex = 36;
            this.label4.Text = "Delivered By";
            // 
            // txtCheckedDate
            // 
            this.txtCheckedDate.Location = new System.Drawing.Point(459, 114);
            this.txtCheckedDate.Name = "txtCheckedDate";
            this.txtCheckedDate.Size = new System.Drawing.Size(206, 22);
            this.txtCheckedDate.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(459, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 14);
            this.label14.TabIndex = 34;
            this.label14.Text = "Checked  Date";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(459, 73);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(206, 22);
            this.txtTransactionDate.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(459, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 14);
            this.label13.TabIndex = 30;
            this.label13.Text = "Recieved Date";
            // 
            // txtCheckedBy
            // 
            this.txtCheckedBy.Location = new System.Drawing.Point(229, 114);
            this.txtCheckedBy.Name = "txtCheckedBy";
            this.txtCheckedBy.Size = new System.Drawing.Size(206, 22);
            this.txtCheckedBy.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 14);
            this.label12.TabIndex = 32;
            this.label12.Text = "Checked By";
            // 
            // txtTransactionBy
            // 
            this.txtTransactionBy.Location = new System.Drawing.Point(229, 73);
            this.txtTransactionBy.Name = "txtTransactionBy";
            this.txtTransactionBy.Size = new System.Drawing.Size(206, 22);
            this.txtTransactionBy.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "Recieved By";
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(12, 73);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(206, 22);
            this.txtReferenceNo.TabIndex = 27;
            this.txtReferenceNo.TextChanged += new System.EventHandler(this.txtReferenceNo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 14);
            this.label9.TabIndex = 26;
            this.label9.Text = "Reference Number\r\n";
            // 
            // cboStoreName
            // 
            this.cboStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreName.FormattingEnabled = true;
            this.cboStoreName.Location = new System.Drawing.Point(229, 33);
            this.cboStoreName.Name = "cboStoreName";
            this.cboStoreName.Size = new System.Drawing.Size(206, 22);
            this.cboStoreName.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 24;
            this.label7.Text = "Store Name";
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(12, 33);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(206, 22);
            this.cboStoreLocation.TabIndex = 23;
            this.cboStoreLocation.SelectedIndexChanged += new System.EventHandler(this.cboStoreLocation_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 14);
            this.label8.TabIndex = 22;
            this.label8.Text = "Store Location";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.BackColor = System.Drawing.Color.Lavender;
            this.txtOrderNumber.Location = new System.Drawing.Point(6, 36);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.ReadOnly = true;
            this.txtOrderNumber.Size = new System.Drawing.Size(144, 22);
            this.txtOrderNumber.TabIndex = 16;
            this.txtOrderNumber.TextChanged += new System.EventHandler(this.txtOrderNumber_TextChanged);
            // 
            // proformaDetailToolStrip
            // 
            this.proformaDetailToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.proformaDetailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnSaveDetail,
            this.btnDeleteDetail,
            this.toolStripSeparator2,
            this.btnGetBatchesFromPurchaseOrder});
            this.proformaDetailToolStrip.Location = new System.Drawing.Point(3, 3);
            this.proformaDetailToolStrip.Name = "proformaDetailToolStrip";
            this.proformaDetailToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.proformaDetailToolStrip.Size = new System.Drawing.Size(679, 25);
            this.proformaDetailToolStrip.TabIndex = 41;
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
            this.btnSaveDetail.ToolTipText = "Save the current goods receiving detail record (i.e. newly created or edited)";
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
            this.btnDeleteDetail.ToolTipText = "Delete the currently selected goods receiving detail record";
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGetBatchesFromPurchaseOrder
            // 
            this.btnGetBatchesFromPurchaseOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBatchesFromPurchaseOrder.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetBatchesFromPurchaseOrder.Image = global::Pharma.Properties.Resources.refresh;
            this.btnGetBatchesFromPurchaseOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetBatchesFromPurchaseOrder.Name = "btnGetBatchesFromPurchaseOrder";
            this.btnGetBatchesFromPurchaseOrder.Size = new System.Drawing.Size(222, 22);
            this.btnGetBatchesFromPurchaseOrder.Text = "Get Batches From Purchase Order";
            this.btnGetBatchesFromPurchaseOrder.ToolTipText = "Fill the goods receiving details list by importing data from the details of the o" +
                "rder selected above";
            this.btnGetBatchesFromPurchaseOrder.Click += new System.EventHandler(this.btnGetBatchesFromPurchaseOrder_Click);
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
            this.grvTransactionDetails.Size = new System.Drawing.Size(678, 180);
            this.grvTransactionDetails.TabIndex = 42;
            this.grvTransactionDetails.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grvTransactionDetails_UserDeletingRow);
            this.grvTransactionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTransactionDetails_CellContentClick);
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
            this.ssbValidator.TabIndex = 43;
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
            this.line3.Location = new System.Drawing.Point(-2, 36);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1022, 1);
            this.line3.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(-2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1022, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "    Goods Receiving";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolBar.Controls.Add(this.proformaToolStrip);
            this.panelToolBar.Location = new System.Drawing.Point(387, 38);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(710, 28);
            this.panelToolBar.TabIndex = 122;
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
            this.btnNew.ToolTipText = "Prepare the system to accept a new goods receiving record";
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
            this.btnSave.ToolTipText = "Save the current goods receiving record (i.e. newly created or edited)";
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
            this.btnDelete.ToolTipText = "Delete the currently selected goods receiving record";
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
            this.btnPrintPreview.ToolTipText = "Preview the currently selected goods receiving record for printing";
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
            this.btnClose.ToolTipText = "Close the Goods Receiving dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearchPurchaseOrder
            // 
            this.btnSearchPurchaseOrder.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchPurchaseOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPurchaseOrder.Image")));
            this.btnSearchPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPurchaseOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchPurchaseOrder.Location = new System.Drawing.Point(154, 34);
            this.btnSearchPurchaseOrder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchPurchaseOrder.Name = "btnSearchPurchaseOrder";
            this.btnSearchPurchaseOrder.Size = new System.Drawing.Size(30, 28);
            this.btnSearchPurchaseOrder.TabIndex = 17;
            this.btnSearchPurchaseOrder.TabStop = false;
            this.btnSearchPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnSearchPurchaseOrder.Click += new System.EventHandler(this.btnSearchPurchaseOrder_Click);
            // 
            // grpPO
            // 
            this.grpPO.Controls.Add(this.lvwBatchs);
            this.grpPO.Controls.Add(this.btnSearchPurchaseOrder);
            this.grpPO.Controls.Add(this.txtOrderNumber);
            this.grpPO.Controls.Add(this.dtOrderDate);
            this.grpPO.Controls.Add(this.label10);
            this.grpPO.Controls.Add(this.label15);
            this.grpPO.Location = new System.Drawing.Point(388, 68);
            this.grpPO.Name = "grpPO";
            this.grpPO.Size = new System.Drawing.Size(738, 181);
            this.grpPO.TabIndex = 14;
            this.grpPO.TabStop = false;
            this.grpPO.Text = "From Purchase Order";
            // 
            // lvwBatchs
            // 
            this.lvwBatchs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBatchsId,
            this.colBatchsPurchaseOrderGuid,
            this.colBatchsBatchnumber,
            this.colBatchsItemGuid,
            this.colBatchsItemname,
            this.colBatchsQuantity,
            this.colBatchsPriceperunit,
            this.colBatchsFreightpayments,
            this.colBatchsInsurancepayments,
            this.colBatchsBankpayments,
            this.colBatchsOtherpayments,
            this.colBatchsSuggestedsaleprice,
            this.colBatchsSaleprice,
            this.colBatchsManufactureddate,
            this.colBatchsExpirydate});
            this.lvwBatchs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBatchs.FullRowSelect = true;
            this.lvwBatchs.GridLines = true;
            this.lvwBatchs.Location = new System.Drawing.Point(8, 65);
            this.lvwBatchs.MultiSelect = false;
            this.lvwBatchs.Name = "lvwBatchs";
            this.lvwBatchs.Size = new System.Drawing.Size(726, 110);
            this.lvwBatchs.TabIndex = 20;
            this.lvwBatchs.UseCompatibleStateImageBehavior = false;
            this.lvwBatchs.View = System.Windows.Forms.View.Details;
            this.lvwBatchs.SelectedIndexChanged += new System.EventHandler(this.lvwBatchs_SelectedIndexChanged);
            // 
            // colBatchsId
            // 
            this.colBatchsId.Text = "Batch Id";
            this.colBatchsId.Width = 0;
            // 
            // colBatchsPurchaseOrderGuid
            // 
            this.colBatchsPurchaseOrderGuid.Text = "Purchase Order Guid";
            this.colBatchsPurchaseOrderGuid.Width = 0;
            // 
            // colBatchsBatchnumber
            // 
            this.colBatchsBatchnumber.Text = "Batch Number";
            this.colBatchsBatchnumber.Width = 100;
            // 
            // colBatchsItemGuid
            // 
            this.colBatchsItemGuid.Text = "Item Guid";
            this.colBatchsItemGuid.Width = 0;
            // 
            // colBatchsItemname
            // 
            this.colBatchsItemname.Text = "Item";
            this.colBatchsItemname.Width = 360;
            // 
            // colBatchsQuantity
            // 
            this.colBatchsQuantity.Text = "Quantity";
            this.colBatchsQuantity.Width = 70;
            // 
            // colBatchsPriceperunit
            // 
            this.colBatchsPriceperunit.Text = "Price Per Unit";
            this.colBatchsPriceperunit.Width = 95;
            // 
            // colBatchsFreightpayments
            // 
            this.colBatchsFreightpayments.Text = "Freight Payments";
            this.colBatchsFreightpayments.Width = 0;
            // 
            // colBatchsInsurancepayments
            // 
            this.colBatchsInsurancepayments.Text = "Insurance Payments";
            this.colBatchsInsurancepayments.Width = 0;
            // 
            // colBatchsBankpayments
            // 
            this.colBatchsBankpayments.Text = "Bank Payments";
            this.colBatchsBankpayments.Width = 0;
            // 
            // colBatchsOtherpayments
            // 
            this.colBatchsOtherpayments.Text = "Other Payments";
            this.colBatchsOtherpayments.Width = 0;
            // 
            // colBatchsSuggestedsaleprice
            // 
            this.colBatchsSuggestedsaleprice.Text = "Suggested Sale Price";
            this.colBatchsSuggestedsaleprice.Width = 0;
            // 
            // colBatchsSaleprice
            // 
            this.colBatchsSaleprice.Text = "Actual Sale Price";
            this.colBatchsSaleprice.Width = 0;
            // 
            // colBatchsManufactureddate
            // 
            this.colBatchsManufactureddate.Text = "Manufactured Date";
            this.colBatchsManufactureddate.Width = 0;
            // 
            // colBatchsExpirydate
            // 
            this.colBatchsExpirydate.Text = "Expiry Date";
            this.colBatchsExpirydate.Width = 0;
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.AllowDrop = true;
            this.dtOrderDate.CalendarFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtOrderDate.CustomFormat = "dddd, MMM dd, yyyy";
            this.dtOrderDate.Enabled = false;
            this.dtOrderDate.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.dtOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOrderDate.Location = new System.Drawing.Point(214, 36);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Size = new System.Drawing.Size(144, 23);
            this.dtOrderDate.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(214, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Purchase Order Date";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Purchase Order Number";
            // 
            // tabControlDetail
            // 
            this.tabControlDetail.Controls.Add(this.tabPageReceivingDetail);
            this.tabControlDetail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlDetail.Location = new System.Drawing.Point(388, 443);
            this.tabControlDetail.Name = "tabControlDetail";
            this.tabControlDetail.SelectedIndex = 0;
            this.tabControlDetail.Size = new System.Drawing.Size(693, 247);
            this.tabControlDetail.TabIndex = 40;
            // 
            // tabPageReceivingDetail
            // 
            this.tabPageReceivingDetail.Controls.Add(this.grvTransactionDetails);
            this.tabPageReceivingDetail.Controls.Add(this.proformaDetailToolStrip);
            this.tabPageReceivingDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageReceivingDetail.Name = "tabPageReceivingDetail";
            this.tabPageReceivingDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReceivingDetail.Size = new System.Drawing.Size(685, 218);
            this.tabPageReceivingDetail.TabIndex = 0;
            this.tabPageReceivingDetail.Text = "Receiving Detail";
            this.tabPageReceivingDetail.UseVisualStyleBackColor = true;
            // 
            // frmReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 764);
            this.Controls.Add(this.tabControlDetail);
            this.Controls.Add(this.lvwTransactions);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ssbValidator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpPO);
            this.Controls.Add(this.grpDataEntry);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmReceiving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Receiving";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRecieving_Load);
            this.Resize += new System.EventHandler(this.frmReceiving_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDataEntry.ResumeLayout(false);
            this.grpDataEntry.PerformLayout();
            this.proformaDetailToolStrip.ResumeLayout(false);
            this.proformaDetailToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).EndInit();
            this.ssbValidator.ResumeLayout(false);
            this.ssbValidator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.proformaToolStrip.ResumeLayout(false);
            this.proformaToolStrip.PerformLayout();
            this.grpPO.ResumeLayout(false);
            this.grpPO.PerformLayout();
            this.tabControlDetail.ResumeLayout(false);
            this.tabPageReceivingDetail.ResumeLayout(false);
            this.tabPageReceivingDetail.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCheckedDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTransactionDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCheckedBy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReferenceNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboStoreName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboStoreLocation;
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
        private System.Windows.Forms.ColumnHeader colCheckedBy;
        private System.Windows.Forms.ColumnHeader colTransactionType;
        private System.Windows.Forms.ColumnHeader colCheckedDate;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.ColumnHeader colLocationName;
        private System.Windows.Forms.ToolStrip proformaDetailToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
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
        private System.Windows.Forms.Button btnSearchPurchaseOrder;
        private System.Windows.Forms.GroupBox grpPO;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView lvwBatchs;
        private System.Windows.Forms.ColumnHeader colBatchsId;
        private System.Windows.Forms.ColumnHeader colBatchsPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colBatchsBatchnumber;
        private System.Windows.Forms.ColumnHeader colBatchsItemGuid;
        private System.Windows.Forms.ColumnHeader colBatchsItemname;
        private System.Windows.Forms.ColumnHeader colBatchsQuantity;
        private System.Windows.Forms.ColumnHeader colBatchsPriceperunit;
        private System.Windows.Forms.ColumnHeader colBatchsFreightpayments;
        private System.Windows.Forms.ColumnHeader colBatchsInsurancepayments;
        private System.Windows.Forms.ColumnHeader colBatchsBankpayments;
        private System.Windows.Forms.ColumnHeader colBatchsOtherpayments;
        private System.Windows.Forms.ColumnHeader colBatchsSuggestedsaleprice;
        private System.Windows.Forms.ColumnHeader colBatchsSaleprice;
        private System.Windows.Forms.ColumnHeader colBatchsManufactureddate;
        private System.Windows.Forms.ColumnHeader colBatchsExpirydate;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDeliveredBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControlDetail;
        private System.Windows.Forms.TabPage tabPageReceivingDetail;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colDeliveredBy;
        private System.Windows.Forms.ColumnHeader colDeliveryDate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnDelete;
        public System.Windows.Forms.ToolStripButton btnSaveDetail;
        public System.Windows.Forms.ToolStripButton btnDeleteDetail;
        public System.Windows.Forms.ToolStripButton btnGetBatchesFromPurchaseOrder;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.TextBox txtTransactionBy;
        private System.Windows.Forms.Label label11;
    }
}