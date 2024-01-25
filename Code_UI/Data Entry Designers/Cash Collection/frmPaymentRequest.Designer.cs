namespace Pharma
{
    partial class frmPaymentRequest
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
            this.lvwPaymentRequests = new System.Windows.Forms.ListView();
            this.colRequestId = new System.Windows.Forms.ColumnHeader();
            this.colCustomerGuid = new System.Windows.Forms.ColumnHeader();
            this.colReqOrganizationName = new System.Windows.Forms.ColumnHeader();
            this.colReferenceNo = new System.Windows.Forms.ColumnHeader();
            this.colRequestDate = new System.Windows.Forms.ColumnHeader();
            this.colVoid = new System.Windows.Forms.ColumnHeader();
            this.colVoidDate = new System.Windows.Forms.ColumnHeader();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnFindCustormer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRequestDateTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRequestDateFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.ssbValidator = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.btnFindOrganization = new System.Windows.Forms.Button();
            this.txtReferenceNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRequestDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrganizationName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.txtTotalReqAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lvwRequestInvoices = new System.Windows.Forms.ListView();
            this.colCashCollectionInvoiceId = new System.Windows.Forms.ColumnHeader();
            this.colReqInvoiceGuid = new System.Windows.Forms.ColumnHeader();
            this.colReqInvoiceNo = new System.Windows.Forms.ColumnHeader();
            this.colItemCount = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceTotalAmount = new System.Windows.Forms.ColumnHeader();
            this.tsbToolBar = new System.Windows.Forms.ToolStrip();
            this.btnNewPaymentRequest = new System.Windows.Forms.ToolStripButton();
            this.btnSavePaymentRequest = new System.Windows.Forms.ToolStripButton();
            this.btnDeletePaymentRequest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrintPaymentRequest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.btnSearchInvoice = new System.Windows.Forms.Button();
            this.txtInvoiceDateTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceDateFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInvertSelection = new System.Windows.Forms.Button();
            this.btnDeselectAll = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.lvwTransactions = new System.Windows.Forms.ListView();
            this.colReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colOrganizationName = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceGuid = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceCustomerGuid = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceDate = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceType = new System.Windows.Forms.ColumnHeader();
            this.colDueDate = new System.Windows.Forms.ColumnHeader();
            this.colPreparedBy = new System.Windows.Forms.ColumnHeader();
            this.colCheckedBy = new System.Windows.Forms.ColumnHeader();
            this.colApprovedBy = new System.Windows.Forms.ColumnHeader();
            this.colDeliveredBy = new System.Windows.Forms.ColumnHeader();
            this.colPreparedDate = new System.Windows.Forms.ColumnHeader();
            this.colCheckedDate = new System.Windows.Forms.ColumnHeader();
            this.colApprovalDate = new System.Windows.Forms.ColumnHeader();
            this.colDeliveryDate = new System.Windows.Forms.ColumnHeader();
            this.colDeliveryStatus = new System.Windows.Forms.ColumnHeader();
            this.colSuppliesRequisitionGuid = new System.Windows.Forms.ColumnHeader();
            this.line3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnVoid = new System.Windows.Forms.Button();
            this.grpVoid = new System.Windows.Forms.GroupBox();
            this.txtVoidDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVoid = new System.Windows.Forms.Label();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.ssbValidator.SuspendLayout();
            this.grpRequest.SuspendLayout();
            this.tsbToolBar.SuspendLayout();
            this.grpInvoice.SuspendLayout();
            this.grpVoid.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPaymentRequests
            // 
            this.lvwPaymentRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRequestId,
            this.colCustomerGuid,
            this.colReqOrganizationName,
            this.colReferenceNo,
            this.colRequestDate,
            this.colVoid,
            this.colVoidDate});
            this.lvwPaymentRequests.FullRowSelect = true;
            this.lvwPaymentRequests.GridLines = true;
            this.lvwPaymentRequests.Location = new System.Drawing.Point(8, 175);
            this.lvwPaymentRequests.Name = "lvwPaymentRequests";
            this.lvwPaymentRequests.Size = new System.Drawing.Size(359, 499);
            this.lvwPaymentRequests.TabIndex = 11;
            this.lvwPaymentRequests.UseCompatibleStateImageBehavior = false;
            this.lvwPaymentRequests.View = System.Windows.Forms.View.Details;
            this.lvwPaymentRequests.SelectedIndexChanged += new System.EventHandler(this.lvwPaymentRequests_SelectedIndexChanged);
            // 
            // colRequestId
            // 
            this.colRequestId.Text = "Id";
            this.colRequestId.Width = 0;
            // 
            // colCustomerGuid
            // 
            this.colCustomerGuid.Text = "Customer Guid";
            this.colCustomerGuid.Width = 0;
            // 
            // colReqOrganizationName
            // 
            this.colReqOrganizationName.Text = "Customer Name";
            this.colReqOrganizationName.Width = 0;
            // 
            // colReferenceNo
            // 
            this.colReferenceNo.Text = "Reference Number";
            this.colReferenceNo.Width = 180;
            // 
            // colRequestDate
            // 
            this.colRequestDate.Text = "Request Date";
            this.colRequestDate.Width = 150;
            // 
            // colVoid
            // 
            this.colVoid.Text = "Void";
            this.colVoid.Width = 0;
            // 
            // colVoidDate
            // 
            this.colVoidDate.Text = "Void Date";
            this.colVoidDate.Width = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnFindCustormer);
            this.grpFilter.Controls.Add(this.txtCustomerName);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.txtRequestDateTo);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Controls.Add(this.txtRequestDateFrom);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Location = new System.Drawing.Point(8, 40);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(4);
            this.grpFilter.Size = new System.Drawing.Size(359, 129);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // btnFindCustormer
            // 
            this.btnFindCustormer.Location = new System.Drawing.Point(293, 27);
            this.btnFindCustormer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindCustormer.Name = "btnFindCustormer";
            this.btnFindCustormer.Size = new System.Drawing.Size(43, 24);
            this.btnFindCustormer.TabIndex = 5;
            this.btnFindCustormer.Text = "Find";
            this.btnFindCustormer.UseVisualStyleBackColor = true;
            this.btnFindCustormer.Click += new System.EventHandler(this.btnFindCustormer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(12, 27);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(278, 22);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 94);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(324, 24);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRequestDateTo
            // 
            this.txtRequestDateTo.Location = new System.Drawing.Point(159, 66);
            this.txtRequestDateTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRequestDateTo.Name = "txtRequestDateTo";
            this.txtRequestDateTo.Size = new System.Drawing.Size(131, 22);
            this.txtRequestDateTo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Request Date To";
            // 
            // txtRequestDateFrom
            // 
            this.txtRequestDateFrom.Location = new System.Drawing.Point(12, 66);
            this.txtRequestDateFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRequestDateFrom.Name = "txtRequestDateFrom";
            this.txtRequestDateFrom.Size = new System.Drawing.Size(131, 22);
            this.txtRequestDateFrom.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Request Date From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers Organization Name";
            // 
            // mValidator
            // 
            this.mValidator.ContainerControl = this;
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
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.btnFindOrganization);
            this.grpRequest.Controls.Add(this.txtReferenceNo);
            this.grpRequest.Controls.Add(this.label8);
            this.grpRequest.Controls.Add(this.txtRequestDate);
            this.grpRequest.Controls.Add(this.label7);
            this.grpRequest.Controls.Add(this.txtOrganizationName);
            this.grpRequest.Controls.Add(this.label16);
            this.grpRequest.Location = new System.Drawing.Point(373, 61);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(867, 58);
            this.grpRequest.TabIndex = 13;
            this.grpRequest.TabStop = false;
            // 
            // btnFindOrganization
            // 
            this.btnFindOrganization.Location = new System.Drawing.Point(363, 29);
            this.btnFindOrganization.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindOrganization.Name = "btnFindOrganization";
            this.btnFindOrganization.Size = new System.Drawing.Size(43, 24);
            this.btnFindOrganization.TabIndex = 16;
            this.btnFindOrganization.Text = "Find";
            this.btnFindOrganization.UseVisualStyleBackColor = true;
            this.btnFindOrganization.Click += new System.EventHandler(this.btnFindOrganization_Click);
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(447, 30);
            this.txtReferenceNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(134, 22);
            this.txtReferenceNo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 14);
            this.label8.TabIndex = 17;
            this.label8.Text = "Reference No";
            // 
            // txtRequestDate
            // 
            this.txtRequestDate.Location = new System.Drawing.Point(601, 30);
            this.txtRequestDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRequestDate.Name = "txtRequestDate";
            this.txtRequestDate.Size = new System.Drawing.Size(134, 22);
            this.txtRequestDate.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Request Date";
            // 
            // txtOrganizationName
            // 
            this.txtOrganizationName.Location = new System.Drawing.Point(10, 30);
            this.txtOrganizationName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.Size = new System.Drawing.Size(350, 22);
            this.txtOrganizationName.TabIndex = 15;
            this.txtOrganizationName.TextChanged += new System.EventHandler(this.txtOrganizationName_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 14);
            this.label16.TabIndex = 14;
            this.label16.Text = "Customers Organization Name";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(726, 450);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(67, 87);
            this.btnRemoveItem.TabIndex = 32;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtTotalReqAmount
            // 
            this.txtTotalReqAmount.ForeColor = System.Drawing.Color.Red;
            this.txtTotalReqAmount.Location = new System.Drawing.Point(1060, 649);
            this.txtTotalReqAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalReqAmount.Name = "txtTotalReqAmount";
            this.txtTotalReqAmount.ReadOnly = true;
            this.txtTotalReqAmount.Size = new System.Drawing.Size(148, 22);
            this.txtTotalReqAmount.TabIndex = 40;
            this.txtTotalReqAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Location = new System.Drawing.Point(958, 649);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(95, 22);
            this.lblTotalAmount.TabIndex = 39;
            this.lblTotalAmount.Text = "Total Amount:";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwRequestInvoices
            // 
            this.lvwRequestInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCashCollectionInvoiceId,
            this.colReqInvoiceGuid,
            this.colReqInvoiceNo,
            this.colItemCount,
            this.colInvoiceTotalAmount});
            this.lvwRequestInvoices.FullRowSelect = true;
            this.lvwRequestInvoices.GridLines = true;
            this.lvwRequestInvoices.Location = new System.Drawing.Point(806, 175);
            this.lvwRequestInvoices.Name = "lvwRequestInvoices";
            this.lvwRequestInvoices.Size = new System.Drawing.Size(428, 466);
            this.lvwRequestInvoices.TabIndex = 38;
            this.lvwRequestInvoices.UseCompatibleStateImageBehavior = false;
            this.lvwRequestInvoices.View = System.Windows.Forms.View.Details;
            // 
            // colCashCollectionInvoiceId
            // 
            this.colCashCollectionInvoiceId.Text = "Id";
            this.colCashCollectionInvoiceId.Width = 0;
            // 
            // colReqInvoiceGuid
            // 
            this.colReqInvoiceGuid.Text = "Guid";
            this.colReqInvoiceGuid.Width = 0;
            // 
            // colReqInvoiceNo
            // 
            this.colReqInvoiceNo.Text = "Invoice No";
            this.colReqInvoiceNo.Width = 150;
            // 
            // colItemCount
            // 
            this.colItemCount.Text = "Item Count";
            this.colItemCount.Width = 100;
            // 
            // colInvoiceTotalAmount
            // 
            this.colInvoiceTotalAmount.Text = "Invoice Total";
            this.colInvoiceTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colInvoiceTotalAmount.Width = 150;
            // 
            // tsbToolBar
            // 
            this.tsbToolBar.AutoSize = false;
            this.tsbToolBar.BackColor = System.Drawing.Color.Transparent;
            this.tsbToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewPaymentRequest,
            this.btnSavePaymentRequest,
            this.btnDeletePaymentRequest,
            this.toolStripSeparator1,
            this.btnPrintPaymentRequest,
            this.toolStripSeparator2,
            this.btnClose});
            this.tsbToolBar.Location = new System.Drawing.Point(373, 40);
            this.tsbToolBar.Name = "tsbToolBar";
            this.tsbToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsbToolBar.Size = new System.Drawing.Size(774, 25);
            this.tsbToolBar.TabIndex = 12;
            this.tsbToolBar.Text = "toolStrip1";
            // 
            // btnNewPaymentRequest
            // 
            this.btnNewPaymentRequest.Image = global::Pharma.Properties.Resources.New;
            this.btnNewPaymentRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewPaymentRequest.Name = "btnNewPaymentRequest";
            this.btnNewPaymentRequest.Size = new System.Drawing.Size(51, 22);
            this.btnNewPaymentRequest.Text = "New";
            this.btnNewPaymentRequest.ToolTipText = "Prepare the system to accept a new payment request record";
            this.btnNewPaymentRequest.Click += new System.EventHandler(this.btnNewPaymentRequest_Click);
            // 
            // btnSavePaymentRequest
            // 
            this.btnSavePaymentRequest.Image = global::Pharma.Properties.Resources.save;
            this.btnSavePaymentRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSavePaymentRequest.Name = "btnSavePaymentRequest";
            this.btnSavePaymentRequest.Size = new System.Drawing.Size(51, 22);
            this.btnSavePaymentRequest.Text = "Save";
            this.btnSavePaymentRequest.ToolTipText = "Save the current payment request record (i.e. newly created or edited)";
            this.btnSavePaymentRequest.Click += new System.EventHandler(this.btnSavePaymentRequest_Click);
            // 
            // btnDeletePaymentRequest
            // 
            this.btnDeletePaymentRequest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePaymentRequest.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeletePaymentRequest.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeletePaymentRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeletePaymentRequest.Name = "btnDeletePaymentRequest";
            this.btnDeletePaymentRequest.Size = new System.Drawing.Size(64, 22);
            this.btnDeletePaymentRequest.Text = "Delete";
            this.btnDeletePaymentRequest.ToolTipText = "Delete the currently selected payment request record";
            this.btnDeletePaymentRequest.Click += new System.EventHandler(this.btnDeletePaymentRequest_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrintPaymentRequest
            // 
            this.btnPrintPaymentRequest.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnPrintPaymentRequest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintPaymentRequest.Name = "btnPrintPaymentRequest";
            this.btnPrintPaymentRequest.Size = new System.Drawing.Size(96, 22);
            this.btnPrintPaymentRequest.Text = "Print Preview";
            this.btnPrintPaymentRequest.ToolTipText = "Preview the currently selected payment request record for printing";
            this.btnPrintPaymentRequest.Click += new System.EventHandler(this.btnPrintPaymentRequest_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 22);
            this.btnClose.Text = "Close";
            this.btnClose.ToolTipText = "Close the Payment Request dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(726, 320);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(67, 87);
            this.btnAddItem.TabIndex = 31;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.btnSearchInvoice);
            this.grpInvoice.Controls.Add(this.txtInvoiceDateTo);
            this.grpInvoice.Controls.Add(this.label2);
            this.grpInvoice.Controls.Add(this.txtInvoiceDateFrom);
            this.grpInvoice.Controls.Add(this.label3);
            this.grpInvoice.Location = new System.Drawing.Point(373, 116);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(339, 53);
            this.grpInvoice.TabIndex = 21;
            this.grpInvoice.TabStop = false;
            // 
            // btnSearchInvoice
            // 
            this.btnSearchInvoice.Location = new System.Drawing.Point(272, 26);
            this.btnSearchInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchInvoice.Name = "btnSearchInvoice";
            this.btnSearchInvoice.Size = new System.Drawing.Size(62, 24);
            this.btnSearchInvoice.TabIndex = 26;
            this.btnSearchInvoice.Text = "Search";
            this.btnSearchInvoice.UseVisualStyleBackColor = true;
            this.btnSearchInvoice.Click += new System.EventHandler(this.btnSearchInvoice_Click);
            // 
            // txtInvoiceDateTo
            // 
            this.txtInvoiceDateTo.Location = new System.Drawing.Point(143, 28);
            this.txtInvoiceDateTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInvoiceDateTo.Name = "txtInvoiceDateTo";
            this.txtInvoiceDateTo.Size = new System.Drawing.Size(125, 22);
            this.txtInvoiceDateTo.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "Invoice Date To";
            // 
            // txtInvoiceDateFrom
            // 
            this.txtInvoiceDateFrom.Location = new System.Drawing.Point(7, 28);
            this.txtInvoiceDateFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInvoiceDateFrom.Name = "txtInvoiceDateFrom";
            this.txtInvoiceDateFrom.Size = new System.Drawing.Size(125, 22);
            this.txtInvoiceDateFrom.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Invoice Date From";
            // 
            // btnInvertSelection
            // 
            this.btnInvertSelection.Location = new System.Drawing.Point(597, 175);
            this.btnInvertSelection.Name = "btnInvertSelection";
            this.btnInvertSelection.Size = new System.Drawing.Size(115, 27);
            this.btnInvertSelection.TabIndex = 29;
            this.btnInvertSelection.Text = "Invert Selection";
            this.btnInvertSelection.UseVisualStyleBackColor = true;
            this.btnInvertSelection.Click += new System.EventHandler(this.btnInvertSelection_Click);
            // 
            // btnDeselectAll
            // 
            this.btnDeselectAll.Location = new System.Drawing.Point(486, 175);
            this.btnDeselectAll.Name = "btnDeselectAll";
            this.btnDeselectAll.Size = new System.Drawing.Size(109, 27);
            this.btnDeselectAll.TabIndex = 28;
            this.btnDeselectAll.Text = "Deselect  All";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.btnDeselectAll.Click += new System.EventHandler(this.btnDeselectAll_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(373, 175);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(111, 27);
            this.btnSelectAll.TabIndex = 27;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // lvwTransactions
            // 
            this.lvwTransactions.CheckBoxes = true;
            this.lvwTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colReferenceNumber,
            this.colOrganizationName,
            this.colInvoiceGuid,
            this.colInvoiceCustomerGuid,
            this.colInvoiceDate,
            this.colInvoiceType,
            this.colDueDate,
            this.colPreparedBy,
            this.colCheckedBy,
            this.colApprovedBy,
            this.colDeliveredBy,
            this.colPreparedDate,
            this.colCheckedDate,
            this.colApprovalDate,
            this.colDeliveryDate,
            this.colDeliveryStatus,
            this.colSuppliesRequisitionGuid});
            this.lvwTransactions.FullRowSelect = true;
            this.lvwTransactions.GridLines = true;
            this.lvwTransactions.Location = new System.Drawing.Point(373, 205);
            this.lvwTransactions.Name = "lvwTransactions";
            this.lvwTransactions.Size = new System.Drawing.Size(339, 470);
            this.lvwTransactions.TabIndex = 30;
            this.lvwTransactions.UseCompatibleStateImageBehavior = false;
            this.lvwTransactions.View = System.Windows.Forms.View.Details;
            // 
            // colReferenceNumber
            // 
            this.colReferenceNumber.Text = "Invoice Number";
            this.colReferenceNumber.Width = 150;
            // 
            // colOrganizationName
            // 
            this.colOrganizationName.Text = "Organization Name";
            this.colOrganizationName.Width = 0;
            // 
            // colInvoiceGuid
            // 
            this.colInvoiceGuid.Text = "Guid";
            this.colInvoiceGuid.Width = 0;
            // 
            // colInvoiceCustomerGuid
            // 
            this.colInvoiceCustomerGuid.Width = 0;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Text = "Invoice Date";
            this.colInvoiceDate.Width = 120;
            // 
            // colInvoiceType
            // 
            this.colInvoiceType.Width = 0;
            // 
            // colDueDate
            // 
            this.colDueDate.Width = 0;
            // 
            // colPreparedBy
            // 
            this.colPreparedBy.Width = 0;
            // 
            // colCheckedBy
            // 
            this.colCheckedBy.Width = 0;
            // 
            // colApprovedBy
            // 
            this.colApprovedBy.Width = 0;
            // 
            // colDeliveredBy
            // 
            this.colDeliveredBy.Width = 0;
            // 
            // colPreparedDate
            // 
            this.colPreparedDate.Width = 0;
            // 
            // colCheckedDate
            // 
            this.colCheckedDate.Width = 0;
            // 
            // colApprovalDate
            // 
            this.colApprovalDate.Width = 0;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.Width = 0;
            // 
            // colDeliveryStatus
            // 
            this.colDeliveryStatus.Width = 0;
            // 
            // colSuppliesRequisitionGuid
            // 
            this.colSuppliesRequisitionGuid.Width = 0;
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
            this.lblTitle.Text = "    Payment Request";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVoid
            // 
            this.btnVoid.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnVoid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoid.Location = new System.Drawing.Point(176, 26);
            this.btnVoid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(100, 24);
            this.btnVoid.TabIndex = 36;
            this.btnVoid.Text = "Void";
            this.btnVoid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoid.UseVisualStyleBackColor = true;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // grpVoid
            // 
            this.grpVoid.Controls.Add(this.txtVoidDate);
            this.grpVoid.Controls.Add(this.label4);
            this.grpVoid.Controls.Add(this.btnVoid);
            this.grpVoid.Controls.Add(this.lblVoid);
            this.grpVoid.Location = new System.Drawing.Point(806, 116);
            this.grpVoid.Name = "grpVoid";
            this.grpVoid.Size = new System.Drawing.Size(428, 53);
            this.grpVoid.TabIndex = 33;
            this.grpVoid.TabStop = false;
            // 
            // txtVoidDate
            // 
            this.txtVoidDate.Location = new System.Drawing.Point(14, 27);
            this.txtVoidDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVoidDate.Name = "txtVoidDate";
            this.txtVoidDate.Size = new System.Drawing.Size(134, 22);
            this.txtVoidDate.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 14);
            this.label4.TabIndex = 34;
            this.label4.Text = "Void Date";
            // 
            // lblVoid
            // 
            this.lblVoid.AutoSize = true;
            this.lblVoid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoid.ForeColor = System.Drawing.Color.Red;
            this.lblVoid.Location = new System.Drawing.Point(284, 27);
            this.lblVoid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoid.Name = "lblVoid";
            this.lblVoid.Size = new System.Drawing.Size(138, 23);
            this.lblVoid.TabIndex = 37;
            this.lblVoid.Text = "Request is Void";
            this.lblVoid.Visible = false;
            // 
            // frmPaymentRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 764);
            this.Controls.Add(this.lvwTransactions);
            this.Controls.Add(this.btnInvertSelection);
            this.Controls.Add(this.txtTotalReqAmount);
            this.Controls.Add(this.btnDeselectAll);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvwRequestInvoices);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lvwPaymentRequests);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.tsbToolBar);
            this.Controls.Add(this.ssbValidator);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpRequest);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.grpVoid);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPaymentRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPaymentRequest_Load);
            this.Resize += new System.EventHandler(this.frmPaymentRequest_Resize);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.ssbValidator.ResumeLayout(false);
            this.ssbValidator.PerformLayout();
            this.grpRequest.ResumeLayout(false);
            this.grpRequest.PerformLayout();
            this.tsbToolBar.ResumeLayout(false);
            this.tsbToolBar.PerformLayout();
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.grpVoid.ResumeLayout(false);
            this.grpVoid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFindCustormer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRequestDateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRequestDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.StatusStrip ssbValidator;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.GroupBox grpRequest;
        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.ListView lvwRequestInvoices;
        private System.Windows.Forms.Button btnSearchInvoice;
        private System.Windows.Forms.TextBox txtInvoiceDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoiceDateFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvwTransactions;
        private System.Windows.Forms.ColumnHeader colInvoiceGuid;
        private System.Windows.Forms.ColumnHeader colInvoiceCustomerGuid;
        private System.Windows.Forms.ColumnHeader colOrganizationName;
        private System.Windows.Forms.ColumnHeader colReferenceNumber;
        private System.Windows.Forms.ColumnHeader colInvoiceDate;
        private System.Windows.Forms.ColumnHeader colInvoiceType;
        private System.Windows.Forms.ColumnHeader colDueDate;
        private System.Windows.Forms.ColumnHeader colPreparedBy;
        private System.Windows.Forms.ColumnHeader colCheckedBy;
        private System.Windows.Forms.ColumnHeader colApprovedBy;
        private System.Windows.Forms.ColumnHeader colDeliveredBy;
        private System.Windows.Forms.ColumnHeader colPreparedDate;
        private System.Windows.Forms.ColumnHeader colCheckedDate;
        private System.Windows.Forms.ColumnHeader colApprovalDate;
        private System.Windows.Forms.ColumnHeader colDeliveryDate;
        private System.Windows.Forms.ColumnHeader colDeliveryStatus;
        private System.Windows.Forms.ColumnHeader colSuppliesRequisitionGuid;
        private System.Windows.Forms.ToolStrip tsbToolBar;
        private System.Windows.Forms.ToolStripButton btnNewPaymentRequest;
        private System.Windows.Forms.TextBox txtRequestDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReferenceNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalReqAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ListView lvwPaymentRequests;
        private System.Windows.Forms.ColumnHeader colRequestId;
        private System.Windows.Forms.ColumnHeader colRequestDate;
        private System.Windows.Forms.ColumnHeader colReferenceNo;
        private System.Windows.Forms.TextBox txtOrganizationName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ColumnHeader colReqOrganizationName;
        private System.Windows.Forms.ColumnHeader colReqInvoiceGuid;
        private System.Windows.Forms.ColumnHeader colReqInvoiceNo;
        private System.Windows.Forms.ColumnHeader colItemCount;
        private System.Windows.Forms.ColumnHeader colInvoiceTotalAmount;
        private System.Windows.Forms.ToolStripButton btnPrintPaymentRequest;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.Button btnInvertSelection;
        private System.Windows.Forms.Button btnDeselectAll;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnFindOrganization;
        private System.Windows.Forms.ColumnHeader colCustomerGuid;
        private System.Windows.Forms.ColumnHeader colCashCollectionInvoiceId;
        public System.Windows.Forms.Button btnAddItem;
        public System.Windows.Forms.ToolStripButton btnSavePaymentRequest;
        public System.Windows.Forms.Button btnRemoveItem;
        public System.Windows.Forms.ToolStripButton btnDeletePaymentRequest;
        public System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.GroupBox grpVoid;
        private System.Windows.Forms.Label lblVoid;
        private System.Windows.Forms.TextBox txtVoidDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader colVoid;
        private System.Windows.Forms.ColumnHeader colVoidDate;
    }
}