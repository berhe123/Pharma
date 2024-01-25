namespace Pharma
{
    partial class frmRegisterBatchs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterBatchs));
            this.lvwPurchaseOrders = new System.Windows.Forms.ListView();
            this.colAutoID = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerProformaGuid = new System.Windows.Forms.ColumnHeader();
            this.colOrderNumber = new System.Windows.Forms.ColumnHeader();
            this.colOrderDate = new System.Windows.Forms.ColumnHeader();
            this.colTermsOfContract = new System.Windows.Forms.ColumnHeader();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.proformaToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.sbPurchaseOrders = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PaymentTabs = new System.Windows.Forms.TabControl();
            this.tabPurchaseOrderDetails = new System.Windows.Forms.TabPage();
            this.lvwPurchaseOrderDetails = new System.Windows.Forms.ListView();
            this.colPurchaseOrderDetailsId = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsItemGuid = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsItemName = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsQuantity = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsPriceperunit = new System.Windows.Forms.ColumnHeader();
            this.colLineTotal = new System.Windows.Forms.ColumnHeader();
            this.tabInsurancePayments = new System.Windows.Forms.TabPage();
            this.lvwInsurancePayments = new System.Windows.Forms.ListView();
            this.colInsurancePaymentID = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentInsurerName = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentInsuredDate = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentAmount = new System.Windows.Forms.ColumnHeader();
            this.tabBankPayments = new System.Windows.Forms.TabPage();
            this.lvwBankPayments = new System.Windows.Forms.ListView();
            this.colBankPaymentID = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentBankName = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentSubmissionDate = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentServiceCharge = new System.Windows.Forms.ColumnHeader();
            this.tabOtherPayments = new System.Windows.Forms.TabPage();
            this.lvwOtherPayments = new System.Windows.Forms.ListView();
            this.colOtherPaymentId = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentReason = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentReasonDescription = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentDate = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentAmount = new System.Windows.Forms.ColumnHeader();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.tabControlBatchs = new System.Windows.Forms.TabControl();
            this.tabPageBatchs = new System.Windows.Forms.TabPage();
            this.grpBatch = new System.Windows.Forms.GroupBox();
            this.txtBatchsExpirydate = new System.Windows.Forms.TextBox();
            this.txtBatchsManufactureddate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboBatchsItemid = new System.Windows.Forms.ComboBox();
            this.txtBatchsQuantity = new System.Windows.Forms.TextBox();
            this.txtBatchsPriceperunit = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBatchsBatchnumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.toolStripBatchs = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewBatch = new System.Windows.Forms.ToolStripButton();
            this.btnSaveBatch = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteBatch = new System.Windows.Forms.ToolStripButton();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchManufacturerFilter1 = new System.Windows.Forms.Button();
            this.txtOrderDateTo = new System.Windows.Forms.TextBox();
            this.txtOrderDateFrom = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchManufacturerFilter = new System.Windows.Forms.Button();
            this.txtManufacturerFilter = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelToolbar.SuspendLayout();
            this.proformaToolStrip.SuspendLayout();
            this.sbPurchaseOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.PaymentTabs.SuspendLayout();
            this.tabPurchaseOrderDetails.SuspendLayout();
            this.tabInsurancePayments.SuspendLayout();
            this.tabBankPayments.SuspendLayout();
            this.tabOtherPayments.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.tabControlBatchs.SuspendLayout();
            this.tabPageBatchs.SuspendLayout();
            this.grpBatch.SuspendLayout();
            this.toolStripBatchs.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPurchaseOrders
            // 
            this.lvwPurchaseOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAutoID,
            this.colManufacturerProformaGuid,
            this.colOrderNumber,
            this.colOrderDate,
            this.colTermsOfContract});
            this.lvwPurchaseOrders.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPurchaseOrders.FullRowSelect = true;
            this.lvwPurchaseOrders.GridLines = true;
            this.lvwPurchaseOrders.Location = new System.Drawing.Point(9, 190);
            this.lvwPurchaseOrders.MultiSelect = false;
            this.lvwPurchaseOrders.Name = "lvwPurchaseOrders";
            this.lvwPurchaseOrders.Size = new System.Drawing.Size(296, 494);
            this.lvwPurchaseOrders.TabIndex = 13;
            this.lvwPurchaseOrders.UseCompatibleStateImageBehavior = false;
            this.lvwPurchaseOrders.View = System.Windows.Forms.View.Details;
            this.lvwPurchaseOrders.SelectedIndexChanged += new System.EventHandler(this.lvwPurchaseOrders_SelectedIndexChanged);
            this.lvwPurchaseOrders.DoubleClick += new System.EventHandler(this.lvwPurchaseOrders_DoubleClick);
            // 
            // colAutoID
            // 
            this.colAutoID.Width = 0;
            // 
            // colManufacturerProformaGuid
            // 
            this.colManufacturerProformaGuid.DisplayIndex = 4;
            this.colManufacturerProformaGuid.Text = "Manufacturer Proforma Guid";
            this.colManufacturerProformaGuid.Width = 0;
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.DisplayIndex = 1;
            this.colOrderNumber.Text = "Order Number";
            this.colOrderNumber.Width = 120;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DisplayIndex = 2;
            this.colOrderDate.Text = "Order Date";
            this.colOrderDate.Width = 120;
            // 
            // colTermsOfContract
            // 
            this.colTermsOfContract.DisplayIndex = 3;
            this.colTermsOfContract.Text = "Terms of Contract";
            this.colTermsOfContract.Width = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1022, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "    Maintain Batchs in the Purchase Order";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolbar.Controls.Add(this.proformaToolStrip);
            this.panelToolbar.Location = new System.Drawing.Point(313, 42);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(710, 28);
            this.panelToolbar.TabIndex = 106;
            // 
            // proformaToolStrip
            // 
            this.proformaToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.proformaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
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
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 22);
            this.btnClose.Text = "Close";
            this.btnClose.ToolTipText = "Close the Batch Maintenance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // sbPurchaseOrders
            // 
            this.sbPurchaseOrders.AutoSize = false;
            this.sbPurchaseOrders.BackColor = System.Drawing.Color.Lavender;
            this.sbPurchaseOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.sbPurchaseOrders.Location = new System.Drawing.Point(0, 688);
            this.sbPurchaseOrders.Name = "sbPurchaseOrders";
            this.sbPurchaseOrders.Size = new System.Drawing.Size(1063, 22);
            this.sbPurchaseOrders.TabIndex = 41;
            // 
            // lblMsg
            // 
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
            this.line3.Location = new System.Drawing.Point(2, 38);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1022, 1);
            this.line3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Order Number";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Enabled = false;
            this.txtOrderNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(6, 36);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(144, 23);
            this.txtOrderNumber.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(183, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Order Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentTabs
            // 
            this.PaymentTabs.Controls.Add(this.tabPurchaseOrderDetails);
            this.PaymentTabs.Controls.Add(this.tabInsurancePayments);
            this.PaymentTabs.Controls.Add(this.tabBankPayments);
            this.PaymentTabs.Controls.Add(this.tabOtherPayments);
            this.PaymentTabs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTabs.Location = new System.Drawing.Point(313, 144);
            this.PaymentTabs.Name = "PaymentTabs";
            this.PaymentTabs.SelectedIndex = 0;
            this.PaymentTabs.Size = new System.Drawing.Size(719, 200);
            this.PaymentTabs.TabIndex = 20;
            // 
            // tabPurchaseOrderDetails
            // 
            this.tabPurchaseOrderDetails.Controls.Add(this.lvwPurchaseOrderDetails);
            this.tabPurchaseOrderDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPurchaseOrderDetails.Name = "tabPurchaseOrderDetails";
            this.tabPurchaseOrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPurchaseOrderDetails.Size = new System.Drawing.Size(711, 171);
            this.tabPurchaseOrderDetails.TabIndex = 3;
            this.tabPurchaseOrderDetails.Text = "Purchase Order Details ";
            this.tabPurchaseOrderDetails.UseVisualStyleBackColor = true;
            // 
            // lvwPurchaseOrderDetails
            // 
            this.lvwPurchaseOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPurchaseOrderDetailsId,
            this.colPurchaseOrderDetailsPurchaseOrderGuid,
            this.colPurchaseOrderDetailsItemGuid,
            this.colPurchaseOrderDetailsItemName,
            this.colPurchaseOrderDetailsQuantity,
            this.colPurchaseOrderDetailsPriceperunit,
            this.colLineTotal});
            this.lvwPurchaseOrderDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPurchaseOrderDetails.FullRowSelect = true;
            this.lvwPurchaseOrderDetails.GridLines = true;
            this.lvwPurchaseOrderDetails.Location = new System.Drawing.Point(2, 3);
            this.lvwPurchaseOrderDetails.MultiSelect = false;
            this.lvwPurchaseOrderDetails.Name = "lvwPurchaseOrderDetails";
            this.lvwPurchaseOrderDetails.Size = new System.Drawing.Size(696, 162);
            this.lvwPurchaseOrderDetails.TabIndex = 21;
            this.lvwPurchaseOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvwPurchaseOrderDetails.View = System.Windows.Forms.View.Details;
            this.lvwPurchaseOrderDetails.SelectedIndexChanged += new System.EventHandler(this.lvwPurchaseOrderDetails_SelectedIndexChanged);
            this.lvwPurchaseOrderDetails.DoubleClick += new System.EventHandler(this.lvwPurchaseOrderDetails_DoubleClick);
            // 
            // colPurchaseOrderDetailsId
            // 
            this.colPurchaseOrderDetailsId.Text = "ID";
            this.colPurchaseOrderDetailsId.Width = 0;
            // 
            // colPurchaseOrderDetailsPurchaseOrderGuid
            // 
            this.colPurchaseOrderDetailsPurchaseOrderGuid.Text = "Purchase Order Guid";
            this.colPurchaseOrderDetailsPurchaseOrderGuid.Width = 0;
            // 
            // colPurchaseOrderDetailsItemGuid
            // 
            this.colPurchaseOrderDetailsItemGuid.Text = "Item Guid";
            this.colPurchaseOrderDetailsItemGuid.Width = 0;
            // 
            // colPurchaseOrderDetailsItemName
            // 
            this.colPurchaseOrderDetailsItemName.Text = "Item";
            this.colPurchaseOrderDetailsItemName.Width = 250;
            // 
            // colPurchaseOrderDetailsQuantity
            // 
            this.colPurchaseOrderDetailsQuantity.Text = "Quantity";
            this.colPurchaseOrderDetailsQuantity.Width = 120;
            // 
            // colPurchaseOrderDetailsPriceperunit
            // 
            this.colPurchaseOrderDetailsPriceperunit.Text = "Price per Unit";
            this.colPurchaseOrderDetailsPriceperunit.Width = 120;
            // 
            // colLineTotal
            // 
            this.colLineTotal.Text = "Total";
            this.colLineTotal.Width = 150;
            // 
            // tabInsurancePayments
            // 
            this.tabInsurancePayments.Controls.Add(this.lvwInsurancePayments);
            this.tabInsurancePayments.Location = new System.Drawing.Point(4, 25);
            this.tabInsurancePayments.Name = "tabInsurancePayments";
            this.tabInsurancePayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsurancePayments.Size = new System.Drawing.Size(711, 171);
            this.tabInsurancePayments.TabIndex = 0;
            this.tabInsurancePayments.Text = "Insurance Payments";
            this.tabInsurancePayments.UseVisualStyleBackColor = true;
            // 
            // lvwInsurancePayments
            // 
            this.lvwInsurancePayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colInsurancePaymentID,
            this.colInsurancePaymentPurchaseOrderGuid,
            this.colInsurancePaymentInsurerName,
            this.colInsurancePaymentInsuredDate,
            this.colInsurancePaymentReferenceNumber,
            this.colInsurancePaymentAmount});
            this.lvwInsurancePayments.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwInsurancePayments.FullRowSelect = true;
            this.lvwInsurancePayments.GridLines = true;
            this.lvwInsurancePayments.Location = new System.Drawing.Point(2, 2);
            this.lvwInsurancePayments.MultiSelect = false;
            this.lvwInsurancePayments.Name = "lvwInsurancePayments";
            this.lvwInsurancePayments.Size = new System.Drawing.Size(696, 166);
            this.lvwInsurancePayments.TabIndex = 22;
            this.lvwInsurancePayments.UseCompatibleStateImageBehavior = false;
            this.lvwInsurancePayments.View = System.Windows.Forms.View.Details;
            // 
            // colInsurancePaymentID
            // 
            this.colInsurancePaymentID.Text = "Insurance Payment ID";
            this.colInsurancePaymentID.Width = 0;
            // 
            // colInsurancePaymentPurchaseOrderGuid
            // 
            this.colInsurancePaymentPurchaseOrderGuid.Text = "Purchase Order Guid";
            this.colInsurancePaymentPurchaseOrderGuid.Width = 0;
            // 
            // colInsurancePaymentInsurerName
            // 
            this.colInsurancePaymentInsurerName.Text = "Insurer Name";
            this.colInsurancePaymentInsurerName.Width = 280;
            // 
            // colInsurancePaymentInsuredDate
            // 
            this.colInsurancePaymentInsuredDate.Text = "Insured Date";
            this.colInsurancePaymentInsuredDate.Width = 120;
            // 
            // colInsurancePaymentReferenceNumber
            // 
            this.colInsurancePaymentReferenceNumber.Text = "Reference Number";
            this.colInsurancePaymentReferenceNumber.Width = 150;
            // 
            // colInsurancePaymentAmount
            // 
            this.colInsurancePaymentAmount.Text = "Amount";
            this.colInsurancePaymentAmount.Width = 100;
            // 
            // tabBankPayments
            // 
            this.tabBankPayments.Controls.Add(this.lvwBankPayments);
            this.tabBankPayments.Location = new System.Drawing.Point(4, 25);
            this.tabBankPayments.Name = "tabBankPayments";
            this.tabBankPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabBankPayments.Size = new System.Drawing.Size(711, 171);
            this.tabBankPayments.TabIndex = 1;
            this.tabBankPayments.Text = "Bank Payments";
            this.tabBankPayments.UseVisualStyleBackColor = true;
            // 
            // lvwBankPayments
            // 
            this.lvwBankPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBankPaymentID,
            this.colBankPaymentPurchaseOrderGuid,
            this.colBankPaymentBankName,
            this.colBankPaymentSubmissionDate,
            this.colBankPaymentReferenceNumber,
            this.colBankPaymentServiceCharge});
            this.lvwBankPayments.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBankPayments.FullRowSelect = true;
            this.lvwBankPayments.GridLines = true;
            this.lvwBankPayments.Location = new System.Drawing.Point(2, 2);
            this.lvwBankPayments.MultiSelect = false;
            this.lvwBankPayments.Name = "lvwBankPayments";
            this.lvwBankPayments.Size = new System.Drawing.Size(696, 166);
            this.lvwBankPayments.TabIndex = 23;
            this.lvwBankPayments.UseCompatibleStateImageBehavior = false;
            this.lvwBankPayments.View = System.Windows.Forms.View.Details;
            // 
            // colBankPaymentID
            // 
            this.colBankPaymentID.Text = "Bank Payment ID";
            this.colBankPaymentID.Width = 0;
            // 
            // colBankPaymentPurchaseOrderGuid
            // 
            this.colBankPaymentPurchaseOrderGuid.Text = "Purchase Order Guid";
            this.colBankPaymentPurchaseOrderGuid.Width = 0;
            // 
            // colBankPaymentBankName
            // 
            this.colBankPaymentBankName.Text = "Bank Name";
            this.colBankPaymentBankName.Width = 280;
            // 
            // colBankPaymentSubmissionDate
            // 
            this.colBankPaymentSubmissionDate.Text = "Submission Date";
            this.colBankPaymentSubmissionDate.Width = 120;
            // 
            // colBankPaymentReferenceNumber
            // 
            this.colBankPaymentReferenceNumber.Text = "Reference Number";
            this.colBankPaymentReferenceNumber.Width = 150;
            // 
            // colBankPaymentServiceCharge
            // 
            this.colBankPaymentServiceCharge.Text = "Service Charge";
            this.colBankPaymentServiceCharge.Width = 110;
            // 
            // tabOtherPayments
            // 
            this.tabOtherPayments.Controls.Add(this.lvwOtherPayments);
            this.tabOtherPayments.Location = new System.Drawing.Point(4, 25);
            this.tabOtherPayments.Name = "tabOtherPayments";
            this.tabOtherPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtherPayments.Size = new System.Drawing.Size(711, 171);
            this.tabOtherPayments.TabIndex = 2;
            this.tabOtherPayments.Text = "Other Payments";
            this.tabOtherPayments.UseVisualStyleBackColor = true;
            // 
            // lvwOtherPayments
            // 
            this.lvwOtherPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOtherPaymentId,
            this.colOtherPaymentPaymentOrderGuid,
            this.colOtherPaymentPaymentReason,
            this.colOtherPaymentPaymentReasonDescription,
            this.colOtherPaymentPaymentDate,
            this.colOtherPaymentReferenceNumber,
            this.colOtherPaymentAmount});
            this.lvwOtherPayments.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwOtherPayments.FullRowSelect = true;
            this.lvwOtherPayments.GridLines = true;
            this.lvwOtherPayments.Location = new System.Drawing.Point(2, 2);
            this.lvwOtherPayments.MultiSelect = false;
            this.lvwOtherPayments.Name = "lvwOtherPayments";
            this.lvwOtherPayments.Size = new System.Drawing.Size(696, 166);
            this.lvwOtherPayments.TabIndex = 24;
            this.lvwOtherPayments.UseCompatibleStateImageBehavior = false;
            this.lvwOtherPayments.View = System.Windows.Forms.View.Details;
            // 
            // colOtherPaymentId
            // 
            this.colOtherPaymentId.Text = "Other Payment ID";
            this.colOtherPaymentId.Width = 0;
            // 
            // colOtherPaymentPaymentOrderGuid
            // 
            this.colOtherPaymentPaymentOrderGuid.Text = "Purchase Order Guid";
            this.colOtherPaymentPaymentOrderGuid.Width = 0;
            // 
            // colOtherPaymentPaymentReason
            // 
            this.colOtherPaymentPaymentReason.Text = "Payment Reason";
            this.colOtherPaymentPaymentReason.Width = 0;
            // 
            // colOtherPaymentPaymentReasonDescription
            // 
            this.colOtherPaymentPaymentReasonDescription.Text = "Payment Reason";
            this.colOtherPaymentPaymentReasonDescription.Width = 280;
            // 
            // colOtherPaymentPaymentDate
            // 
            this.colOtherPaymentPaymentDate.Text = "Payment Date";
            this.colOtherPaymentPaymentDate.Width = 120;
            // 
            // colOtherPaymentReferenceNumber
            // 
            this.colOtherPaymentReferenceNumber.Text = "Reference Number";
            this.colOtherPaymentReferenceNumber.Width = 150;
            // 
            // colOtherPaymentAmount
            // 
            this.colOtherPaymentAmount.Text = "Amount";
            this.colOtherPaymentAmount.Width = 110;
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.txtOrderDate);
            this.grpOrder.Controls.Add(this.label8);
            this.grpOrder.Controls.Add(this.txtOrderNumber);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Location = new System.Drawing.Point(313, 75);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(719, 63);
            this.grpOrder.TabIndex = 15;
            this.grpOrder.TabStop = false;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(183, 36);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(144, 23);
            this.txtOrderDate.TabIndex = 19;
            // 
            // tabControlBatchs
            // 
            this.tabControlBatchs.Controls.Add(this.tabPageBatchs);
            this.tabControlBatchs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBatchs.Location = new System.Drawing.Point(313, 350);
            this.tabControlBatchs.Name = "tabControlBatchs";
            this.tabControlBatchs.SelectedIndex = 0;
            this.tabControlBatchs.Size = new System.Drawing.Size(719, 334);
            this.tabControlBatchs.TabIndex = 25;
            // 
            // tabPageBatchs
            // 
            this.tabPageBatchs.Controls.Add(this.grpBatch);
            this.tabPageBatchs.Controls.Add(this.lvwBatchs);
            this.tabPageBatchs.Controls.Add(this.toolStripBatchs);
            this.tabPageBatchs.Location = new System.Drawing.Point(4, 25);
            this.tabPageBatchs.Name = "tabPageBatchs";
            this.tabPageBatchs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBatchs.Size = new System.Drawing.Size(711, 305);
            this.tabPageBatchs.TabIndex = 0;
            this.tabPageBatchs.Text = "Batchs";
            this.tabPageBatchs.UseVisualStyleBackColor = true;
            // 
            // grpBatch
            // 
            this.grpBatch.BackColor = System.Drawing.Color.Transparent;
            this.grpBatch.Controls.Add(this.txtBatchsExpirydate);
            this.grpBatch.Controls.Add(this.txtBatchsManufactureddate);
            this.grpBatch.Controls.Add(this.label4);
            this.grpBatch.Controls.Add(this.cboBatchsItemid);
            this.grpBatch.Controls.Add(this.txtBatchsQuantity);
            this.grpBatch.Controls.Add(this.txtBatchsPriceperunit);
            this.grpBatch.Controls.Add(this.label21);
            this.grpBatch.Controls.Add(this.label16);
            this.grpBatch.Controls.Add(this.txtBatchsBatchnumber);
            this.grpBatch.Controls.Add(this.label13);
            this.grpBatch.Controls.Add(this.label15);
            this.grpBatch.Controls.Add(this.label1);
            this.grpBatch.Location = new System.Drawing.Point(4, 34);
            this.grpBatch.Name = "grpBatch";
            this.grpBatch.Size = new System.Drawing.Size(702, 66);
            this.grpBatch.TabIndex = 27;
            this.grpBatch.TabStop = false;
            // 
            // txtBatchsExpirydate
            // 
            this.txtBatchsExpirydate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchsExpirydate.Location = new System.Drawing.Point(570, 31);
            this.txtBatchsExpirydate.Name = "txtBatchsExpirydate";
            this.txtBatchsExpirydate.Size = new System.Drawing.Size(117, 23);
            this.txtBatchsExpirydate.TabIndex = 39;
            // 
            // txtBatchsManufactureddate
            // 
            this.txtBatchsManufactureddate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchsManufactureddate.Location = new System.Drawing.Point(446, 31);
            this.txtBatchsManufactureddate.Name = "txtBatchsManufactureddate";
            this.txtBatchsManufactureddate.Size = new System.Drawing.Size(117, 23);
            this.txtBatchsManufactureddate.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(570, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Expiry Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboBatchsItemid
            // 
            this.cboBatchsItemid.AllowDrop = true;
            this.cboBatchsItemid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatchsItemid.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboBatchsItemid.FormattingEnabled = true;
            this.cboBatchsItemid.Location = new System.Drawing.Point(6, 30);
            this.cboBatchsItemid.Name = "cboBatchsItemid";
            this.cboBatchsItemid.Size = new System.Drawing.Size(171, 24);
            this.cboBatchsItemid.TabIndex = 29;
            this.cboBatchsItemid.SelectedIndexChanged += new System.EventHandler(this.cboBatchsItemid_SelectedIndexChanged);
            // 
            // txtBatchsQuantity
            // 
            this.txtBatchsQuantity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchsQuantity.Location = new System.Drawing.Point(278, 31);
            this.txtBatchsQuantity.Name = "txtBatchsQuantity";
            this.txtBatchsQuantity.Size = new System.Drawing.Size(62, 23);
            this.txtBatchsQuantity.TabIndex = 33;
            // 
            // txtBatchsPriceperunit
            // 
            this.txtBatchsPriceperunit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchsPriceperunit.Location = new System.Drawing.Point(346, 31);
            this.txtBatchsPriceperunit.Name = "txtBatchsPriceperunit";
            this.txtBatchsPriceperunit.ReadOnly = true;
            this.txtBatchsPriceperunit.Size = new System.Drawing.Size(86, 23);
            this.txtBatchsPriceperunit.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(346, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(86, 16);
            this.label21.TabIndex = 34;
            this.label21.Text = "Price per Unit";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(278, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "Quantity";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBatchsBatchnumber
            // 
            this.txtBatchsBatchnumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchsBatchnumber.Location = new System.Drawing.Point(184, 30);
            this.txtBatchsBatchnumber.Name = "txtBatchsBatchnumber";
            this.txtBatchsBatchnumber.Size = new System.Drawing.Size(88, 23);
            this.txtBatchsBatchnumber.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(446, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Manufactured Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(184, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Batch Number";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Item";
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
            this.lvwBatchs.Location = new System.Drawing.Point(4, 107);
            this.lvwBatchs.MultiSelect = false;
            this.lvwBatchs.Name = "lvwBatchs";
            this.lvwBatchs.Size = new System.Drawing.Size(702, 194);
            this.lvwBatchs.TabIndex = 40;
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
            this.colBatchsItemname.Width = 200;
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
            this.colBatchsManufactureddate.Width = 130;
            // 
            // colBatchsExpirydate
            // 
            this.colBatchsExpirydate.Text = "Expiry Date";
            this.colBatchsExpirydate.Width = 100;
            // 
            // toolStripBatchs
            // 
            this.toolStripBatchs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripBatchs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnNewBatch,
            this.btnSaveBatch,
            this.btnDeleteBatch});
            this.toolStripBatchs.Location = new System.Drawing.Point(3, 3);
            this.toolStripBatchs.Name = "toolStripBatchs";
            this.toolStripBatchs.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripBatchs.Size = new System.Drawing.Size(705, 25);
            this.toolStripBatchs.TabIndex = 26;
            this.toolStripBatchs.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewBatch
            // 
            this.btnNewBatch.BackColor = System.Drawing.Color.GhostWhite;
            this.btnNewBatch.Image = ((System.Drawing.Image)(resources.GetObject("btnNewBatch.Image")));
            this.btnNewBatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewBatch.Name = "btnNewBatch";
            this.btnNewBatch.Size = new System.Drawing.Size(51, 22);
            this.btnNewBatch.Text = "&New";
            this.btnNewBatch.ToolTipText = "Prepare the system to accept a new batch record";
            this.btnNewBatch.Click += new System.EventHandler(this.btnNewBatchs_Click);
            // 
            // btnSaveBatch
            // 
            this.btnSaveBatch.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBatch.Image")));
            this.btnSaveBatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveBatch.Name = "btnSaveBatch";
            this.btnSaveBatch.Size = new System.Drawing.Size(51, 22);
            this.btnSaveBatch.Text = "&Save";
            this.btnSaveBatch.ToolTipText = "Save the current batch record (i.e. newly created or edited)";
            this.btnSaveBatch.Click += new System.EventHandler(this.btnSaveBatchs_Click);
            // 
            // btnDeleteBatch
            // 
            this.btnDeleteBatch.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBatch.Image")));
            this.btnDeleteBatch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteBatch.Name = "btnDeleteBatch";
            this.btnDeleteBatch.Size = new System.Drawing.Size(60, 22);
            this.btnDeleteBatch.Text = "&Delete";
            this.btnDeleteBatch.ToolTipText = "Delete the currently selected batch record";
            this.btnDeleteBatch.Click += new System.EventHandler(this.btnDeleteBatchs_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnSearchManufacturerFilter1);
            this.grpFilter.Controls.Add(this.txtOrderDateTo);
            this.grpFilter.Controls.Add(this.txtOrderDateFrom);
            this.grpFilter.Controls.Add(this.label18);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label9);
            this.grpFilter.Controls.Add(this.btnSearchManufacturerFilter);
            this.grpFilter.Controls.Add(this.txtManufacturerFilter);
            this.grpFilter.Controls.Add(this.btnShow);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Location = new System.Drawing.Point(9, 41);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(296, 146);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // btnSearchManufacturerFilter1
            // 
            this.btnSearchManufacturerFilter1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturerFilter1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturerFilter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturerFilter1.Location = new System.Drawing.Point(258, 34);
            this.btnSearchManufacturerFilter1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturerFilter1.Name = "btnSearchManufacturerFilter1";
            this.btnSearchManufacturerFilter1.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturerFilter1.TabIndex = 5;
            this.btnSearchManufacturerFilter1.TabStop = false;
            this.btnSearchManufacturerFilter1.Text = "...";
            this.btnSearchManufacturerFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchManufacturerFilter1.UseVisualStyleBackColor = true;
            this.btnSearchManufacturerFilter1.Click += new System.EventHandler(this.btnSearchManufacturerFilter1_Click);
            // 
            // txtOrderDateTo
            // 
            this.txtOrderDateTo.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDateTo.Location = new System.Drawing.Point(191, 87);
            this.txtOrderDateTo.Name = "txtOrderDateTo";
            this.txtOrderDateTo.Size = new System.Drawing.Size(99, 23);
            this.txtOrderDateTo.TabIndex = 11;
            // 
            // txtOrderDateFrom
            // 
            this.txtOrderDateFrom.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDateFrom.Location = new System.Drawing.Point(54, 87);
            this.txtOrderDateFrom.Name = "txtOrderDateFrom";
            this.txtOrderDateFrom.Size = new System.Drawing.Size(99, 23);
            this.txtOrderDateFrom.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(10, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "Manufacturer";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(161, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "To:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(10, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "From:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchManufacturerFilter
            // 
            this.btnSearchManufacturerFilter.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturerFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchManufacturerFilter.Image")));
            this.btnSearchManufacturerFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturerFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturerFilter.Location = new System.Drawing.Point(226, 10);
            this.btnSearchManufacturerFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturerFilter.Name = "btnSearchManufacturerFilter";
            this.btnSearchManufacturerFilter.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturerFilter.TabIndex = 6;
            this.btnSearchManufacturerFilter.TabStop = false;
            this.btnSearchManufacturerFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchManufacturerFilter.UseVisualStyleBackColor = true;
            this.btnSearchManufacturerFilter.Visible = false;
            this.btnSearchManufacturerFilter.Click += new System.EventHandler(this.btnSearchManufacturerFilter_Click);
            // 
            // txtManufacturerFilter
            // 
            this.txtManufacturerFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtManufacturerFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturerFilter.Location = new System.Drawing.Point(10, 37);
            this.txtManufacturerFilter.Name = "txtManufacturerFilter";
            this.txtManufacturerFilter.Size = new System.Drawing.Size(246, 23);
            this.txtManufacturerFilter.TabIndex = 4;
            this.txtManufacturerFilter.TextChanged += new System.EventHandler(this.txtManufacturerFilter_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnShow.Image = global::Pharma.Properties.Resources.refresh;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShow.Location = new System.Drawing.Point(10, 115);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(278, 27);
            this.btnShow.TabIndex = 12;
            this.btnShow.TabStop = false;
            this.btnShow.Text = "&Show Orders List";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(54, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRegisterBatchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1063, 710);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.PaymentTabs);
            this.Controls.Add(this.tabControlBatchs);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.sbPurchaseOrders);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvwPurchaseOrders);
            this.Name = "frmRegisterBatchs";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Batchs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.Resize += new System.EventHandler(this.frmRegisterBatchs_Resize);
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.proformaToolStrip.ResumeLayout(false);
            this.proformaToolStrip.PerformLayout();
            this.sbPurchaseOrders.ResumeLayout(false);
            this.sbPurchaseOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.PaymentTabs.ResumeLayout(false);
            this.tabPurchaseOrderDetails.ResumeLayout(false);
            this.tabInsurancePayments.ResumeLayout(false);
            this.tabBankPayments.ResumeLayout(false);
            this.tabOtherPayments.ResumeLayout(false);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.tabControlBatchs.ResumeLayout(false);
            this.tabPageBatchs.ResumeLayout(false);
            this.tabPageBatchs.PerformLayout();
            this.grpBatch.ResumeLayout(false);
            this.grpBatch.PerformLayout();
            this.toolStripBatchs.ResumeLayout(false);
            this.toolStripBatchs.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.ToolStrip proformaToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ListView lvwPurchaseOrders;
        private System.Windows.Forms.ColumnHeader colAutoID;
        private System.Windows.Forms.ColumnHeader colOrderNumber;
        private System.Windows.Forms.ColumnHeader colOrderDate;
        private System.Windows.Forms.ColumnHeader colTermsOfContract;
        private System.Windows.Forms.StatusStrip sbPurchaseOrders;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaGuid;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.TabControl PaymentTabs;
        private System.Windows.Forms.TabPage tabPurchaseOrderDetails;
        private System.Windows.Forms.TabPage tabInsurancePayments;
        private System.Windows.Forms.ListView lvwInsurancePayments;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentID;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentInsurerName;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentInsuredDate;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentReferenceNumber;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentAmount;
        private System.Windows.Forms.TabPage tabBankPayments;
        private System.Windows.Forms.ListView lvwBankPayments;
        private System.Windows.Forms.ColumnHeader colBankPaymentID;
        private System.Windows.Forms.ColumnHeader colBankPaymentPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colBankPaymentBankName;
        private System.Windows.Forms.ColumnHeader colBankPaymentSubmissionDate;
        private System.Windows.Forms.ColumnHeader colBankPaymentReferenceNumber;
        private System.Windows.Forms.ColumnHeader colBankPaymentServiceCharge;
        private System.Windows.Forms.TabPage tabOtherPayments;
        private System.Windows.Forms.ListView lvwOtherPayments;
        private System.Windows.Forms.ColumnHeader colOtherPaymentId;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentOrderGuid;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentReason;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentReasonDescription;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentDate;
        private System.Windows.Forms.ColumnHeader colOtherPaymentReferenceNumber;
        private System.Windows.Forms.ColumnHeader colOtherPaymentAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControlBatchs;
        private System.Windows.Forms.TabPage tabPageBatchs;
        private System.Windows.Forms.ToolStrip toolStripBatchs;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnNewBatch;
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
        private System.Windows.Forms.GroupBox grpBatch;
        private System.Windows.Forms.TextBox txtBatchsQuantity;
        private System.Windows.Forms.TextBox txtBatchsPriceperunit;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBatchsBatchnumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cboBatchsItemid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwPurchaseOrderDetails;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsId;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsItemGuid;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsItemName;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsQuantity;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsPriceperunit;
        private System.Windows.Forms.ColumnHeader colLineTotal;
        public System.Windows.Forms.ToolStripButton btnSaveBatch;
        public System.Windows.Forms.ToolStripButton btnDeleteBatch;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.TextBox txtOrderDateTo;
        private System.Windows.Forms.TextBox txtOrderDateFrom;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchManufacturerFilter;
        private System.Windows.Forms.TextBox txtManufacturerFilter;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtBatchsExpirydate;
        private System.Windows.Forms.TextBox txtBatchsManufactureddate;
        private System.Windows.Forms.Button btnSearchManufacturerFilter1;
    }
}