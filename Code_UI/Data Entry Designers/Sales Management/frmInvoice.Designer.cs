namespace Pharma
{
    partial class frmInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cboDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFindCustormer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtInvoiceDateTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoiceDateFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwTransactions = new System.Windows.Forms.ListView();
            this.colInvoiceId = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceCustomerGuid = new System.Windows.Forms.ColumnHeader();
            this.colOrganizationName = new System.Windows.Forms.ColumnHeader();
            this.colAttachmentReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colReferenceNumber = new System.Windows.Forms.ColumnHeader();
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
            this.colDiscount = new System.Windows.Forms.ColumnHeader();
            this.colReturningReason = new System.Windows.Forms.ColumnHeader();
            this.colReturnDate = new System.Windows.Forms.ColumnHeader();
            this.colVAT = new System.Windows.Forms.ColumnHeader();
            this.ssbValidator = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpRequisition = new System.Windows.Forms.GroupBox();
            this.btnSearchRequisition = new System.Windows.Forms.Button();
            this.lblLicense = new System.Windows.Forms.Label();
            this.btnPrepareInvoice = new System.Windows.Forms.Button();
            this.lvwRequisitionItems = new System.Windows.Forms.ListView();
            this.colReqId = new System.Windows.Forms.ColumnHeader();
            this.colReqItemGuid1 = new System.Windows.Forms.ColumnHeader();
            this.colSupplierReqGuid = new System.Windows.Forms.ColumnHeader();
            this.colReqBrandName = new System.Windows.Forms.ColumnHeader();
            this.colReqApprovedQuantity = new System.Windows.Forms.ColumnHeader();
            this.colReqQuanity = new System.Windows.Forms.ColumnHeader();
            this.colReqUnit = new System.Windows.Forms.ColumnHeader();
            this.btnSearchSuppliesRequisition = new System.Windows.Forms.Button();
            this.txtSuppliesRequisitionReferenceNumber = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInvoiceCustormerName = new System.Windows.Forms.TextBox();
            this.txtInvoiceTotalAmount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.txtAttachmentReferenceNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInvoiceApprovedBy = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtInvoiceApproveDate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtChekedBy = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCheckedDate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPreparedBy = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPreparedDate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboInvoiceType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grbReturning = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtReturnedDate = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtReturningReason = new System.Windows.Forms.TextBox();
            this.lblVoid = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.grbDelivery = new System.Windows.Forms.GroupBox();
            this.lblDelivered = new System.Windows.Forms.Label();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDeliveredBy = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.grvTransactionDetails = new System.Windows.Forms.DataGridView();
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
            this.btnPrintPreviewAttachment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.tabControlInvoice = new System.Windows.Forms.TabControl();
            this.tabPageInvoiceDetail = new System.Windows.Forms.TabPage();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.txtVATAmount = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.txtInvoiceDiscount = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnGenerateAttachmentNumber = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFilter.SuspendLayout();
            this.ssbValidator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.grpRequisition.SuspendLayout();
            this.grpInvoice.SuspendLayout();
            this.grbReturning.SuspendLayout();
            this.grbDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).BeginInit();
            this.panelToolBar.SuspendLayout();
            this.proformaToolStrip.SuspendLayout();
            this.tabControlInvoice.SuspendLayout();
            this.tabPageInvoiceDetail.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.cboDeliveryStatus);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.btnFindCustormer);
            this.grpFilter.Controls.Add(this.txtCustomerName);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.txtInvoiceDateTo);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Controls.Add(this.txtInvoiceDateFrom);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Location = new System.Drawing.Point(8, 39);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFilter.Size = new System.Drawing.Size(308, 175);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // cboDeliveryStatus
            // 
            this.cboDeliveryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliveryStatus.FormattingEnabled = true;
            this.cboDeliveryStatus.Location = new System.Drawing.Point(8, 120);
            this.cboDeliveryStatus.Name = "cboDeliveryStatus";
            this.cboDeliveryStatus.Size = new System.Drawing.Size(282, 22);
            this.cboDeliveryStatus.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Delivery Status";
            // 
            // btnFindCustormer
            // 
            this.btnFindCustormer.Location = new System.Drawing.Point(260, 36);
            this.btnFindCustormer.Name = "btnFindCustormer";
            this.btnFindCustormer.Size = new System.Drawing.Size(42, 22);
            this.btnFindCustormer.TabIndex = 5;
            this.btnFindCustormer.Text = "Find";
            this.btnFindCustormer.UseVisualStyleBackColor = true;
            this.btnFindCustormer.Click += new System.EventHandler(this.btnFindCustormer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(8, 36);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(248, 22);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(8, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(282, 24);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtInvoiceDateTo
            // 
            this.txtInvoiceDateTo.Location = new System.Drawing.Point(154, 77);
            this.txtInvoiceDateTo.Name = "txtInvoiceDateTo";
            this.txtInvoiceDateTo.Size = new System.Drawing.Size(137, 22);
            this.txtInvoiceDateTo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Invoice Date To";
            // 
            // txtInvoiceDateFrom
            // 
            this.txtInvoiceDateFrom.Location = new System.Drawing.Point(8, 77);
            this.txtInvoiceDateFrom.Name = "txtInvoiceDateFrom";
            this.txtInvoiceDateFrom.Size = new System.Drawing.Size(137, 22);
            this.txtInvoiceDateFrom.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Invoice Date From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers Organization Name";
            // 
            // lvwTransactions
            // 
            this.lvwTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInvoiceId,
            this.colInvoiceCustomerGuid,
            this.colOrganizationName,
            this.colAttachmentReferenceNumber,
            this.colReferenceNumber,
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
            this.colSuppliesRequisitionGuid,
            this.colDiscount,
            this.colReturningReason,
            this.colReturnDate,
            this.colVAT});
            this.lvwTransactions.FullRowSelect = true;
            this.lvwTransactions.GridLines = true;
            this.lvwTransactions.Location = new System.Drawing.Point(8, 223);
            this.lvwTransactions.Name = "lvwTransactions";
            this.lvwTransactions.Size = new System.Drawing.Size(308, 473);
            this.lvwTransactions.TabIndex = 13;
            this.lvwTransactions.UseCompatibleStateImageBehavior = false;
            this.lvwTransactions.View = System.Windows.Forms.View.Details;
            this.lvwTransactions.SelectedIndexChanged += new System.EventHandler(this.lvwTransactions_SelectedIndexChanged);
            this.lvwTransactions.Click += new System.EventHandler(this.lvwTransactions_Click);
            // 
            // colInvoiceId
            // 
            this.colInvoiceId.Text = "id";
            this.colInvoiceId.Width = 0;
            // 
            // colInvoiceCustomerGuid
            // 
            this.colInvoiceCustomerGuid.Text = "Customer Guid";
            this.colInvoiceCustomerGuid.Width = 0;
            // 
            // colOrganizationName
            // 
            this.colOrganizationName.Text = "Organization Name";
            this.colOrganizationName.Width = 0;
            // 
            // colAttachmentReferenceNumber
            // 
            this.colAttachmentReferenceNumber.Text = "Attachment Reference Number";
            this.colAttachmentReferenceNumber.Width = 0;
            // 
            // colReferenceNumber
            // 
            this.colReferenceNumber.Text = "Invoice Number";
            this.colReferenceNumber.Width = 150;
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
            this.colSuppliesRequisitionGuid.Text = "Supplies Requisition Guid";
            this.colSuppliesRequisitionGuid.Width = 0;
            // 
            // colDiscount
            // 
            this.colDiscount.Text = "Discount";
            this.colDiscount.Width = 0;
            // 
            // colReturningReason
            // 
            this.colReturningReason.Text = "Returning Reason";
            this.colReturningReason.Width = 0;
            // 
            // colReturnDate
            // 
            this.colReturnDate.Text = "Return Date";
            this.colReturnDate.Width = 0;
            // 
            // colVAT
            // 
            this.colVAT.Text = "VAT";
            this.colVAT.Width = 0;
            // 
            // ssbValidator
            // 
            this.ssbValidator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssbValidator.Location = new System.Drawing.Point(0, 724);
            this.ssbValidator.Name = "ssbValidator";
            this.ssbValidator.Size = new System.Drawing.Size(1274, 22);
            this.ssbValidator.TabIndex = 71;
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
            // grpRequisition
            // 
            this.grpRequisition.Controls.Add(this.btnSearchRequisition);
            this.grpRequisition.Controls.Add(this.lblLicense);
            this.grpRequisition.Controls.Add(this.btnPrepareInvoice);
            this.grpRequisition.Controls.Add(this.lvwRequisitionItems);
            this.grpRequisition.Controls.Add(this.btnSearchSuppliesRequisition);
            this.grpRequisition.Controls.Add(this.txtSuppliesRequisitionReferenceNumber);
            this.grpRequisition.Controls.Add(this.label28);
            this.grpRequisition.Controls.Add(this.label10);
            this.grpRequisition.Controls.Add(this.txtInvoiceCustormerName);
            this.grpRequisition.Location = new System.Drawing.Point(323, 71);
            this.grpRequisition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRequisition.Name = "grpRequisition";
            this.grpRequisition.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpRequisition.Size = new System.Drawing.Size(719, 165);
            this.grpRequisition.TabIndex = 15;
            this.grpRequisition.TabStop = false;
            this.grpRequisition.Text = "Select Items";
            // 
            // btnSearchRequisition
            // 
            this.btnSearchRequisition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRequisition.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchRequisition.Image")));
            this.btnSearchRequisition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRequisition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchRequisition.Location = new System.Drawing.Point(410, 27);
            this.btnSearchRequisition.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchRequisition.Name = "btnSearchRequisition";
            this.btnSearchRequisition.Size = new System.Drawing.Size(77, 28);
            this.btnSearchRequisition.TabIndex = 35;
            this.btnSearchRequisition.TabStop = false;
            this.btnSearchRequisition.Text = "Search";
            this.btnSearchRequisition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchRequisition.UseVisualStyleBackColor = true;
            this.btnSearchRequisition.Click += new System.EventHandler(this.btnSearchRequisition_Click);
            // 
            // lblLicense
            // 
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.ForeColor = System.Drawing.Color.Red;
            this.lblLicense.Location = new System.Drawing.Point(8, 69);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(704, 16);
            this.lblLicense.TabIndex = 22;
            // 
            // btnPrepareInvoice
            // 
            this.btnPrepareInvoice.Location = new System.Drawing.Point(495, 27);
            this.btnPrepareInvoice.Name = "btnPrepareInvoice";
            this.btnPrepareInvoice.Size = new System.Drawing.Size(216, 28);
            this.btnPrepareInvoice.TabIndex = 21;
            this.btnPrepareInvoice.Text = "Prepare Invoice";
            this.btnPrepareInvoice.UseVisualStyleBackColor = true;
            this.btnPrepareInvoice.Click += new System.EventHandler(this.btnPrepareInvoice_Click);
            // 
            // lvwRequisitionItems
            // 
            this.lvwRequisitionItems.BackColor = System.Drawing.SystemColors.Window;
            this.lvwRequisitionItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colReqId,
            this.colReqItemGuid1,
            this.colSupplierReqGuid,
            this.colReqBrandName,
            this.colReqApprovedQuantity,
            this.colReqQuanity,
            this.colReqUnit});
            this.lvwRequisitionItems.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwRequisitionItems.FullRowSelect = true;
            this.lvwRequisitionItems.GridLines = true;
            this.lvwRequisitionItems.Location = new System.Drawing.Point(8, 88);
            this.lvwRequisitionItems.Name = "lvwRequisitionItems";
            this.lvwRequisitionItems.Size = new System.Drawing.Size(704, 71);
            this.lvwRequisitionItems.TabIndex = 23;
            this.lvwRequisitionItems.UseCompatibleStateImageBehavior = false;
            this.lvwRequisitionItems.View = System.Windows.Forms.View.Details;
            this.lvwRequisitionItems.SelectedIndexChanged += new System.EventHandler(this.lvwRequisitionItems_SelectedIndexChanged);
            // 
            // colReqId
            // 
            this.colReqId.Text = "id";
            this.colReqId.Width = 0;
            // 
            // colReqItemGuid1
            // 
            this.colReqItemGuid1.Text = "Item Guid";
            this.colReqItemGuid1.Width = 0;
            // 
            // colSupplierReqGuid
            // 
            this.colSupplierReqGuid.Text = "Req Guid";
            this.colSupplierReqGuid.Width = 0;
            // 
            // colReqBrandName
            // 
            this.colReqBrandName.Text = "Item Name";
            this.colReqBrandName.Width = 360;
            // 
            // colReqApprovedQuantity
            // 
            this.colReqApprovedQuantity.Text = "Approved Quantity";
            this.colReqApprovedQuantity.Width = 150;
            // 
            // colReqQuanity
            // 
            this.colReqQuanity.Text = "Requested Quantity";
            this.colReqQuanity.Width = 150;
            // 
            // colReqUnit
            // 
            this.colReqUnit.Text = "Unit";
            this.colReqUnit.Width = 0;
            // 
            // btnSearchSuppliesRequisition
            // 
            this.btnSearchSuppliesRequisition.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSuppliesRequisition.Image = global::Pharma.Properties.Resources.New;
            this.btnSearchSuppliesRequisition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSuppliesRequisition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchSuppliesRequisition.Location = new System.Drawing.Point(6, 53);
            this.btnSearchSuppliesRequisition.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchSuppliesRequisition.Name = "btnSearchSuppliesRequisition";
            this.btnSearchSuppliesRequisition.Size = new System.Drawing.Size(74, 28);
            this.btnSearchSuppliesRequisition.TabIndex = 18;
            this.btnSearchSuppliesRequisition.TabStop = false;
            this.btnSearchSuppliesRequisition.Text = "New";
            this.btnSearchSuppliesRequisition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchSuppliesRequisition.UseVisualStyleBackColor = true;
            this.btnSearchSuppliesRequisition.Visible = false;
            this.btnSearchSuppliesRequisition.Click += new System.EventHandler(this.btnSearchSuppliesRequisition_Click);
            // 
            // txtSuppliesRequisitionReferenceNumber
            // 
            this.txtSuppliesRequisitionReferenceNumber.BackColor = System.Drawing.Color.Lavender;
            this.txtSuppliesRequisitionReferenceNumber.Location = new System.Drawing.Point(7, 33);
            this.txtSuppliesRequisitionReferenceNumber.Name = "txtSuppliesRequisitionReferenceNumber";
            this.txtSuppliesRequisitionReferenceNumber.ReadOnly = true;
            this.txtSuppliesRequisitionReferenceNumber.Size = new System.Drawing.Size(124, 22);
            this.txtSuppliesRequisitionReferenceNumber.TabIndex = 17;
            this.txtSuppliesRequisitionReferenceNumber.TextChanged += new System.EventHandler(this.txtSuppliesRequisitionReferenceNumber_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(123, 14);
            this.label28.TabIndex = 16;
            this.label28.Text = "Reference Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 14);
            this.label10.TabIndex = 33;
            this.label10.Text = "Customers Organization Name";
            // 
            // txtInvoiceCustormerName
            // 
            this.txtInvoiceCustormerName.BackColor = System.Drawing.Color.Lavender;
            this.txtInvoiceCustormerName.Location = new System.Drawing.Point(140, 33);
            this.txtInvoiceCustormerName.Name = "txtInvoiceCustormerName";
            this.txtInvoiceCustormerName.ReadOnly = true;
            this.txtInvoiceCustormerName.Size = new System.Drawing.Size(261, 22);
            this.txtInvoiceCustormerName.TabIndex = 34;
            // 
            // txtInvoiceTotalAmount
            // 
            this.txtInvoiceTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.txtInvoiceTotalAmount.Location = new System.Drawing.Point(368, 87);
            this.txtInvoiceTotalAmount.Name = "txtInvoiceTotalAmount";
            this.txtInvoiceTotalAmount.ReadOnly = true;
            this.txtInvoiceTotalAmount.Size = new System.Drawing.Size(148, 22);
            this.txtInvoiceTotalAmount.TabIndex = 56;
            this.txtInvoiceTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(272, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(92, 14);
            this.label23.TabIndex = 55;
            this.label23.Text = "Invoice Total:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.txtAttachmentReferenceNumber);
            this.grpInvoice.Controls.Add(this.label4);
            this.grpInvoice.Controls.Add(this.txtInvoiceApprovedBy);
            this.grpInvoice.Controls.Add(this.label21);
            this.grpInvoice.Controls.Add(this.txtInvoiceApproveDate);
            this.grpInvoice.Controls.Add(this.label22);
            this.grpInvoice.Controls.Add(this.txtChekedBy);
            this.grpInvoice.Controls.Add(this.label19);
            this.grpInvoice.Controls.Add(this.txtCheckedDate);
            this.grpInvoice.Controls.Add(this.label20);
            this.grpInvoice.Controls.Add(this.txtPreparedBy);
            this.grpInvoice.Controls.Add(this.label18);
            this.grpInvoice.Controls.Add(this.txtPreparedDate);
            this.grpInvoice.Controls.Add(this.label17);
            this.grpInvoice.Controls.Add(this.txtDueDate);
            this.grpInvoice.Controls.Add(this.label16);
            this.grpInvoice.Controls.Add(this.cboInvoiceType);
            this.grpInvoice.Controls.Add(this.label15);
            this.grpInvoice.Controls.Add(this.txtInvoiceDate);
            this.grpInvoice.Controls.Add(this.label14);
            this.grpInvoice.Controls.Add(this.txtInvoiceNo);
            this.grpInvoice.Controls.Add(this.label11);
            this.grpInvoice.Location = new System.Drawing.Point(323, 233);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(719, 139);
            this.grpInvoice.TabIndex = 24;
            this.grpInvoice.TabStop = false;
            // 
            // txtAttachmentReferenceNumber
            // 
            this.txtAttachmentReferenceNumber.BackColor = System.Drawing.Color.White;
            this.txtAttachmentReferenceNumber.Location = new System.Drawing.Point(430, 27);
            this.txtAttachmentReferenceNumber.Name = "txtAttachmentReferenceNumber";
            this.txtAttachmentReferenceNumber.Size = new System.Drawing.Size(160, 22);
            this.txtAttachmentReferenceNumber.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 14);
            this.label4.TabIndex = 47;
            this.label4.Text = "Attachment Ref. Number";
            // 
            // txtInvoiceApprovedBy
            // 
            this.txtInvoiceApprovedBy.Location = new System.Drawing.Point(12, 111);
            this.txtInvoiceApprovedBy.Name = "txtInvoiceApprovedBy";
            this.txtInvoiceApprovedBy.Size = new System.Drawing.Size(257, 22);
            this.txtInvoiceApprovedBy.TabIndex = 44;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 14);
            this.label21.TabIndex = 43;
            this.label21.Text = "Approved By";
            // 
            // txtInvoiceApproveDate
            // 
            this.txtInvoiceApproveDate.Location = new System.Drawing.Point(285, 111);
            this.txtInvoiceApproveDate.Name = "txtInvoiceApproveDate";
            this.txtInvoiceApproveDate.Size = new System.Drawing.Size(116, 22);
            this.txtInvoiceApproveDate.TabIndex = 46;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(282, 96);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(101, 14);
            this.label22.TabIndex = 45;
            this.label22.Text = "Approved Date";
            // 
            // txtChekedBy
            // 
            this.txtChekedBy.Location = new System.Drawing.Point(410, 67);
            this.txtChekedBy.Name = "txtChekedBy";
            this.txtChekedBy.Size = new System.Drawing.Size(188, 22);
            this.txtChekedBy.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(407, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 14);
            this.label19.TabIndex = 39;
            this.label19.Text = "Checked By";
            // 
            // txtCheckedDate
            // 
            this.txtCheckedDate.Location = new System.Drawing.Point(604, 70);
            this.txtCheckedDate.Name = "txtCheckedDate";
            this.txtCheckedDate.Size = new System.Drawing.Size(107, 22);
            this.txtCheckedDate.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(602, 53);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 14);
            this.label20.TabIndex = 41;
            this.label20.Text = "Checked Date";
            // 
            // txtPreparedBy
            // 
            this.txtPreparedBy.Location = new System.Drawing.Point(8, 69);
            this.txtPreparedBy.Name = "txtPreparedBy";
            this.txtPreparedBy.Size = new System.Drawing.Size(257, 22);
            this.txtPreparedBy.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 14);
            this.label18.TabIndex = 35;
            this.label18.Text = "Prepared By";
            // 
            // txtPreparedDate
            // 
            this.txtPreparedDate.Location = new System.Drawing.Point(285, 67);
            this.txtPreparedDate.Name = "txtPreparedDate";
            this.txtPreparedDate.Size = new System.Drawing.Size(116, 22);
            this.txtPreparedDate.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(282, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 14);
            this.label17.TabIndex = 37;
            this.label17.Text = "Prepared Date";
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(604, 27);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(108, 22);
            this.txtDueDate.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(601, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 14);
            this.label16.TabIndex = 31;
            this.label16.Text = "Invoice Due Date";
            // 
            // cboInvoiceType
            // 
            this.cboInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoiceType.FormattingEnabled = true;
            this.cboInvoiceType.Location = new System.Drawing.Point(8, 27);
            this.cboInvoiceType.Name = "cboInvoiceType";
            this.cboInvoiceType.Size = new System.Drawing.Size(188, 22);
            this.cboInvoiceType.TabIndex = 26;
            this.cboInvoiceType.SelectedIndexChanged += new System.EventHandler(this.cboInvoiceType_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "Invoice Type";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(332, 27);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.Size = new System.Drawing.Size(92, 22);
            this.txtInvoiceDate.TabIndex = 30;
            this.txtInvoiceDate.TextChanged += new System.EventHandler(this.txtInvoiceDate_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(332, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 14);
            this.label14.TabIndex = 29;
            this.label14.Text = "Invoice Date";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.BackColor = System.Drawing.Color.White;
            this.txtInvoiceNo.Location = new System.Drawing.Point(201, 27);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(125, 22);
            this.txtInvoiceNo.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 14);
            this.label11.TabIndex = 27;
            this.label11.Text = "Invoice Number";
            // 
            // grbReturning
            // 
            this.grbReturning.Controls.Add(this.btnReturn);
            this.grbReturning.Controls.Add(this.txtReturnedDate);
            this.grbReturning.Controls.Add(this.label27);
            this.grbReturning.Controls.Add(this.txtReturningReason);
            this.grbReturning.Controls.Add(this.lblVoid);
            this.grbReturning.Controls.Add(this.label26);
            this.grbReturning.Location = new System.Drawing.Point(1048, 209);
            this.grbReturning.Name = "grbReturning";
            this.grbReturning.Size = new System.Drawing.Size(206, 139);
            this.grbReturning.TabIndex = 64;
            this.grbReturning.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(7, 91);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(188, 24);
            this.btnReturn.TabIndex = 69;
            this.btnReturn.Text = "Void";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtReturnedDate
            // 
            this.txtReturnedDate.Location = new System.Drawing.Point(10, 67);
            this.txtReturnedDate.Name = "txtReturnedDate";
            this.txtReturnedDate.Size = new System.Drawing.Size(144, 22);
            this.txtReturnedDate.TabIndex = 68;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(10, 51);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(68, 14);
            this.label27.TabIndex = 67;
            this.label27.Text = "Void Date";
            // 
            // txtReturningReason
            // 
            this.txtReturningReason.Location = new System.Drawing.Point(10, 27);
            this.txtReturningReason.Name = "txtReturningReason";
            this.txtReturningReason.Size = new System.Drawing.Size(188, 22);
            this.txtReturningReason.TabIndex = 66;
            // 
            // lblVoid
            // 
            this.lblVoid.AutoSize = true;
            this.lblVoid.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoid.ForeColor = System.Drawing.Color.Red;
            this.lblVoid.Location = new System.Drawing.Point(28, 112);
            this.lblVoid.Name = "lblVoid";
            this.lblVoid.Size = new System.Drawing.Size(126, 22);
            this.lblVoid.TabIndex = 70;
            this.lblVoid.Text = "Invoice is Void";
            this.lblVoid.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(10, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(85, 14);
            this.label26.TabIndex = 65;
            this.label26.Text = "Void Reason";
            // 
            // grbDelivery
            // 
            this.grbDelivery.Controls.Add(this.lblDelivered);
            this.grbDelivery.Controls.Add(this.btnDeliver);
            this.grbDelivery.Controls.Add(this.txtDeliveryDate);
            this.grbDelivery.Controls.Add(this.label25);
            this.grbDelivery.Controls.Add(this.txtDeliveredBy);
            this.grbDelivery.Controls.Add(this.label24);
            this.grbDelivery.Location = new System.Drawing.Point(1048, 63);
            this.grbDelivery.Name = "grbDelivery";
            this.grbDelivery.Size = new System.Drawing.Size(206, 151);
            this.grbDelivery.TabIndex = 57;
            this.grbDelivery.TabStop = false;
            // 
            // lblDelivered
            // 
            this.lblDelivered.AutoSize = true;
            this.lblDelivered.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivered.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDelivered.Location = new System.Drawing.Point(28, 126);
            this.lblDelivered.Name = "lblDelivered";
            this.lblDelivered.Size = new System.Drawing.Size(163, 22);
            this.lblDelivered.TabIndex = 63;
            this.lblDelivered.Text = "Invoice is Delivered";
            this.lblDelivered.Visible = false;
            // 
            // btnDeliver
            // 
            this.btnDeliver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeliver.Location = new System.Drawing.Point(10, 99);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(188, 24);
            this.btnDeliver.TabIndex = 62;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(10, 73);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.Size = new System.Drawing.Size(144, 22);
            this.txtDeliveryDate.TabIndex = 61;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(10, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 14);
            this.label25.TabIndex = 60;
            this.label25.Text = "Delivery Date";
            // 
            // txtDeliveredBy
            // 
            this.txtDeliveredBy.Location = new System.Drawing.Point(10, 31);
            this.txtDeliveredBy.Name = "txtDeliveredBy";
            this.txtDeliveredBy.Size = new System.Drawing.Size(188, 22);
            this.txtDeliveredBy.TabIndex = 59;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(10, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 14);
            this.label24.TabIndex = 58;
            this.label24.Text = "Delivered By";
            // 
            // grvTransactionDetails
            // 
            this.grvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colBatchGuid,
            this.colBatchNumber,
            this.colBrandName,
            this.colUnit,
            this.colQuantity,
            this.colUnitPrice,
            this.colTotalPrice});
            this.grvTransactionDetails.Location = new System.Drawing.Point(2, 2);
            this.grvTransactionDetails.Name = "grvTransactionDetails";
            this.grvTransactionDetails.ReadOnly = true;
            this.grvTransactionDetails.Size = new System.Drawing.Size(914, 158);
            this.grvTransactionDetails.TabIndex = 48;
            this.grvTransactionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTransactionDetails_CellContentClick);
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
            this.lblTitle.Size = new System.Drawing.Size(1276, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "    Invoice";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolBar.Controls.Add(this.proformaToolStrip);
            this.panelToolBar.Location = new System.Drawing.Point(325, 40);
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
            this.btnPrintPreviewAttachment,
            this.toolStripSeparator1,
            this.btnClose});
            this.proformaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.proformaToolStrip.Name = "proformaToolStrip";
            this.proformaToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.proformaToolStrip.Size = new System.Drawing.Size(710, 25);
            this.proformaToolStrip.TabIndex = 14;
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
            this.btnNew.ToolTipText = "Prepare the system to accept a new invoice record";
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
            this.btnSave.ToolTipText = "Save the current invoice record (i.e. newly created or edited)";
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
            this.btnDelete.ToolTipText = "Delete the currently selected invoice record";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Enabled = false;
            this.btnPrintPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintPreview.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(147, 22);
            this.btnPrintPreview.Text = "Print Preview Invoice";
            this.btnPrintPreview.ToolTipText = "Preview the currently selected invoice record for printing";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnPrintPreviewAttachment
            // 
            this.btnPrintPreviewAttachment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreviewAttachment.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPrintPreviewAttachment.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnPrintPreviewAttachment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrintPreviewAttachment.Name = "btnPrintPreviewAttachment";
            this.btnPrintPreviewAttachment.Size = new System.Drawing.Size(172, 22);
            this.btnPrintPreviewAttachment.Text = "Print Preview Attachment";
            this.btnPrintPreviewAttachment.ToolTipText = "Preview the currently selected attachment record for printing";
            this.btnPrintPreviewAttachment.Click += new System.EventHandler(this.btnPrintPreviewAttachment_Click);
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
            this.btnClose.ToolTipText = "Close the invoice dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControlInvoice
            // 
            this.tabControlInvoice.Controls.Add(this.tabPageInvoiceDetail);
            this.tabControlInvoice.Location = new System.Drawing.Point(323, 377);
            this.tabControlInvoice.Name = "tabControlInvoice";
            this.tabControlInvoice.SelectedIndex = 0;
            this.tabControlInvoice.Size = new System.Drawing.Size(931, 319);
            this.tabControlInvoice.TabIndex = 47;
            // 
            // tabPageInvoiceDetail
            // 
            this.tabPageInvoiceDetail.Controls.Add(this.panelTotal);
            this.tabPageInvoiceDetail.Controls.Add(this.grvTransactionDetails);
            this.tabPageInvoiceDetail.Location = new System.Drawing.Point(4, 23);
            this.tabPageInvoiceDetail.Name = "tabPageInvoiceDetail";
            this.tabPageInvoiceDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInvoiceDetail.Size = new System.Drawing.Size(923, 292);
            this.tabPageInvoiceDetail.TabIndex = 1;
            this.tabPageInvoiceDetail.Text = "Invoice Detail";
            this.tabPageInvoiceDetail.UseVisualStyleBackColor = true;
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.txtVATAmount);
            this.panelTotal.Controls.Add(this.txtVAT);
            this.panelTotal.Controls.Add(this.label7);
            this.panelTotal.Controls.Add(this.txtDiscountAmount);
            this.panelTotal.Controls.Add(this.txtInvoiceDiscount);
            this.panelTotal.Controls.Add(this.label23);
            this.panelTotal.Controls.Add(this.txtInvoiceTotalAmount);
            this.panelTotal.Controls.Add(this.lblDiscount);
            this.panelTotal.Controls.Add(this.label2);
            this.panelTotal.Controls.Add(this.txtSubTotal);
            this.panelTotal.Location = new System.Drawing.Point(396, 166);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(520, 120);
            this.panelTotal.TabIndex = 49;
            // 
            // txtVATAmount
            // 
            this.txtVATAmount.ForeColor = System.Drawing.Color.Red;
            this.txtVATAmount.Location = new System.Drawing.Point(368, 57);
            this.txtVATAmount.Name = "txtVATAmount";
            this.txtVATAmount.ReadOnly = true;
            this.txtVATAmount.Size = new System.Drawing.Size(148, 22);
            this.txtVATAmount.TabIndex = 59;
            this.txtVATAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.White;
            this.txtVAT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtVAT.Location = new System.Drawing.Point(231, 57);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(50, 22);
            this.txtVAT.TabIndex = 57;
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 58;
            this.label7.Text = "% VAT:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.ForeColor = System.Drawing.Color.Red;
            this.txtDiscountAmount.Location = new System.Drawing.Point(368, 29);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.Size = new System.Drawing.Size(148, 22);
            this.txtDiscountAmount.TabIndex = 54;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInvoiceDiscount
            // 
            this.txtInvoiceDiscount.BackColor = System.Drawing.Color.White;
            this.txtInvoiceDiscount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInvoiceDiscount.Location = new System.Drawing.Point(231, 29);
            this.txtInvoiceDiscount.Name = "txtInvoiceDiscount";
            this.txtInvoiceDiscount.Size = new System.Drawing.Size(50, 22);
            this.txtInvoiceDiscount.TabIndex = 52;
            this.txtInvoiceDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInvoiceDiscount.TextChanged += new System.EventHandler(this.txtInvoiceDiscount_TextChanged);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(281, 33);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(83, 14);
            this.lblDiscount.TabIndex = 53;
            this.lblDiscount.Text = "% Discount:";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 50;
            this.label2.Text = "Sub Total:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.ForeColor = System.Drawing.Color.Red;
            this.txtSubTotal.Location = new System.Drawing.Point(368, 4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(148, 22);
            this.txtSubTotal.TabIndex = 51;
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGenerateAttachmentNumber
            // 
            this.btnGenerateAttachmentNumber.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGenerateAttachmentNumber.Location = new System.Drawing.Point(1048, 350);
            this.btnGenerateAttachmentNumber.Name = "btnGenerateAttachmentNumber";
            this.btnGenerateAttachmentNumber.Size = new System.Drawing.Size(206, 46);
            this.btnGenerateAttachmentNumber.TabIndex = 123;
            this.btnGenerateAttachmentNumber.Text = "Generate Attachment Reference Number";
            this.btnGenerateAttachmentNumber.UseVisualStyleBackColor = true;
            this.btnGenerateAttachmentNumber.Click += new System.EventHandler(this.btnGenerateAttachmentNumber_Click);
            // 
            // colId
            // 
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colBatchGuid
            // 
            this.colBatchGuid.HeaderText = "BatchGuid";
            this.colBatchGuid.Name = "colBatchGuid";
            this.colBatchGuid.ReadOnly = true;
            this.colBatchGuid.Visible = false;
            // 
            // colBatchNumber
            // 
            this.colBatchNumber.HeaderText = "Batch Number";
            this.colBatchNumber.Name = "colBatchNumber";
            this.colBatchNumber.ReadOnly = true;
            this.colBatchNumber.Width = 120;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Item Name";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            this.colBrandName.Width = 360;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Visible = false;
            this.colUnit.Width = 5;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            this.colQuantity.Width = 90;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 120;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.HeaderText = "Total Price";
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            this.colTotalPrice.Width = 150;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1274, 746);
            this.Controls.Add(this.btnGenerateAttachmentNumber);
            this.Controls.Add(this.tabControlInvoice);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvwTransactions);
            this.Controls.Add(this.ssbValidator);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpRequisition);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.grbDelivery);
            this.Controls.Add(this.grbReturning);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.Resize += new System.EventHandler(this.frmInvoice_Resize);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ssbValidator.ResumeLayout(false);
            this.ssbValidator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.grpRequisition.ResumeLayout(false);
            this.grpRequisition.PerformLayout();
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.grbReturning.ResumeLayout(false);
            this.grbReturning.PerformLayout();
            this.grbDelivery.ResumeLayout(false);
            this.grbDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).EndInit();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.proformaToolStrip.ResumeLayout(false);
            this.proformaToolStrip.PerformLayout();
            this.tabControlInvoice.ResumeLayout(false);
            this.tabPageInvoiceDetail.ResumeLayout(false);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindCustormer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtInvoiceDateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInvoiceDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colInvoiceId;
        private System.Windows.Forms.ColumnHeader colOrganizationName;
        private System.Windows.Forms.ColumnHeader colReferenceNumber;
        private System.Windows.Forms.ColumnHeader colInvoiceDate;
        private System.Windows.Forms.ColumnHeader colInvoiceType;
        private System.Windows.Forms.ColumnHeader colDueDate;
        private System.Windows.Forms.ColumnHeader colPreparedBy;
        private System.Windows.Forms.StatusStrip ssbValidator;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.ColumnHeader colCheckedBy;
        private System.Windows.Forms.ColumnHeader colApprovedBy;
        private System.Windows.Forms.ColumnHeader colDeliveredBy;
        private System.Windows.Forms.ColumnHeader colPreparedDate;
        private System.Windows.Forms.ColumnHeader colCheckedDate;
        private System.Windows.Forms.ColumnHeader colApprovalDate;
        private System.Windows.Forms.ColumnHeader colDeliveryDate;
        private System.Windows.Forms.ColumnHeader colDeliveryStatus;
        private System.Windows.Forms.ColumnHeader colSuppliesRequisitionGuid;
        private System.Windows.Forms.ListView lvwRequisitionItems;
        private System.Windows.Forms.ColumnHeader colReqId;
        private System.Windows.Forms.ColumnHeader colReqItemGuid1;
        private System.Windows.Forms.ColumnHeader colSupplierReqGuid;
        private System.Windows.Forms.ColumnHeader colReqBrandName;
        private System.Windows.Forms.ColumnHeader colReqUnit;
        private System.Windows.Forms.ColumnHeader colReqQuanity;
        private System.Windows.Forms.ColumnHeader colReqApprovedQuantity;
        private System.Windows.Forms.DataGridView grvTransactionDetails;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInvoiceCustormerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInvoiceDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPreparedBy;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPreparedDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboInvoiceType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtInvoiceApprovedBy;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtInvoiceApproveDate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtChekedBy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCheckedDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ColumnHeader colInvoiceCustomerGuid;
        private System.Windows.Forms.TextBox txtInvoiceTotalAmount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtDeliveredBy;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtReturningReason;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox grbDelivery;
        private System.Windows.Forms.TextBox txtReturnedDate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtSuppliesRequisitionReferenceNumber;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnSearchSuppliesRequisition;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelToolBar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnPrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.TabPage tabPageInvoiceDetail;
        private System.Windows.Forms.TextBox txtDiscountAmount;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoiceDiscount;
        private System.Windows.Forms.ColumnHeader colDiscount;
        private System.Windows.Forms.ComboBox cboDeliveryStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLicense;
        public System.Windows.Forms.Button btnPrepareInvoice;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnDelete;
        public System.Windows.Forms.Button btnReturn;
        public System.Windows.Forms.Button btnDeliver;
        private System.Windows.Forms.ColumnHeader colReturningReason;
        private System.Windows.Forms.ColumnHeader colReturnDate;
        private System.Windows.Forms.Label lblDelivered;
        private System.Windows.Forms.Label lblVoid;
        private System.Windows.Forms.TextBox txtAttachmentReferenceNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader colAttachmentReferenceNumber;
        public System.Windows.Forms.Button btnGenerateAttachmentNumber;
        private System.Windows.Forms.TextBox txtVATAmount;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader colVAT;
        private System.Windows.Forms.Button btnSearchRequisition;
        public System.Windows.Forms.GroupBox grpFilter;
        public System.Windows.Forms.ListView lvwTransactions;
        public System.Windows.Forms.GroupBox grpRequisition;
        public System.Windows.Forms.GroupBox grpInvoice;
        public System.Windows.Forms.TabControl tabControlInvoice;
        public System.Windows.Forms.Panel panelTotal;
        public System.Windows.Forms.GroupBox grbReturning;
        private System.Windows.Forms.ToolStrip proformaToolStrip;
        public System.Windows.Forms.ToolStripButton btnNew;
        public System.Windows.Forms.ToolStripButton btnPrintPreviewAttachment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalPrice;

    }
}