namespace Pharma
{
    partial class frmProcessPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcessPurchaseOrder));
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sbPurchaseOrders = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line3 = new System.Windows.Forms.Panel();
            this.PaymentTabs = new System.Windows.Forms.TabControl();
            this.tabInsurancePayments = new System.Windows.Forms.TabPage();
            this.lvwInsurancePayments = new System.Windows.Forms.ListView();
            this.colInsurancePaymentID = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentInsurerName = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentInsuredDate = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colInsurancePaymentAmount = new System.Windows.Forms.ColumnHeader();
            this.grpInsurancePayments = new System.Windows.Forms.GroupBox();
            this.txtInsurancePaymentInsuredDate = new System.Windows.Forms.TextBox();
            this.txtInsurancePaymentReferencenumber = new System.Windows.Forms.TextBox();
            this.txtInsurancePaymentAmount = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInsurancePaymentInsurerName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.toolStripInsurancePayments = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewInsurancePayment = new System.Windows.Forms.ToolStripButton();
            this.btnSaveInsurancePayment = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteInsurancePayment = new System.Windows.Forms.ToolStripButton();
            this.tabBankPayments = new System.Windows.Forms.TabPage();
            this.lvwBankPayments = new System.Windows.Forms.ListView();
            this.colBankPaymentID = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentBankName = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentSubmissionDate = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colBankPaymentServiceCharge = new System.Windows.Forms.ColumnHeader();
            this.grpBankPayments = new System.Windows.Forms.GroupBox();
            this.txtBankPaymentSubmissionDate = new System.Windows.Forms.TextBox();
            this.txtBankPaymentReferenceNumber = new System.Windows.Forms.TextBox();
            this.txtBankPaymentServiceCharge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankPaymentBankName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStripBankPayments = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewBankPayment = new System.Windows.Forms.ToolStripButton();
            this.btnSaveBankPayment = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteBankPayment = new System.Windows.Forms.ToolStripButton();
            this.tabOtherPayments = new System.Windows.Forms.TabPage();
            this.lvwOtherPayments = new System.Windows.Forms.ListView();
            this.colOtherPaymentId = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentReason = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentReasonDescription = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentDate = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentAmount = new System.Windows.Forms.ColumnHeader();
            this.grpOtherPayments = new System.Windows.Forms.GroupBox();
            this.txtOtherPaymentPaymentDate = new System.Windows.Forms.TextBox();
            this.cboOtherPaymentPaymentReason = new System.Windows.Forms.ComboBox();
            this.txtOtherPaymentReferenceNumber = new System.Windows.Forms.TextBox();
            this.txtOtherPaymentAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.toolStripOtherPayment = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewOtherPayment = new System.Windows.Forms.ToolStripButton();
            this.btnSaveOtherPayment = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteOtherPayment = new System.Windows.Forms.ToolStripButton();
            this.tabDetail = new System.Windows.Forms.TabControl();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.lvwPurchaseOrderDetails = new System.Windows.Forms.ListView();
            this.colPurchaseOrderDetailsId = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsItemGuid = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsItemName = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsQuantity = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsPriceperunit = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsCurrencytype = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsCurrencytypedescription = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsFreightcharge = new System.Windows.Forms.ColumnHeader();
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
            this.grpOrder.SuspendLayout();
            this.sbPurchaseOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.PaymentTabs.SuspendLayout();
            this.tabInsurancePayments.SuspendLayout();
            this.grpInsurancePayments.SuspendLayout();
            this.toolStripInsurancePayments.SuspendLayout();
            this.tabBankPayments.SuspendLayout();
            this.grpBankPayments.SuspendLayout();
            this.toolStripBankPayments.SuspendLayout();
            this.tabOtherPayments.SuspendLayout();
            this.grpOtherPayments.SuspendLayout();
            this.toolStripOtherPayment.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.tabPageDetail.SuspendLayout();
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
            this.lvwPurchaseOrders.Location = new System.Drawing.Point(9, 192);
            this.lvwPurchaseOrders.MultiSelect = false;
            this.lvwPurchaseOrders.Name = "lvwPurchaseOrders";
            this.lvwPurchaseOrders.Size = new System.Drawing.Size(296, 494);
            this.lvwPurchaseOrders.TabIndex = 13;
            this.lvwPurchaseOrders.UseCompatibleStateImageBehavior = false;
            this.lvwPurchaseOrders.View = System.Windows.Forms.View.Details;
            this.lvwPurchaseOrders.SelectedIndexChanged += new System.EventHandler(this.lvwPurchaseOrders_SelectedIndexChanged);
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
            this.lblTitle.Text = "    Maintain Payments Made to Purchase Orders";
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
            this.btnClose.ToolTipText = "Close the Cost Accumulation dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.txtOrderDate);
            this.grpOrder.Controls.Add(this.label8);
            this.grpOrder.Controls.Add(this.txtOrderNumber);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Location = new System.Drawing.Point(313, 72);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(710, 58);
            this.grpOrder.TabIndex = 15;
            this.grpOrder.TabStop = false;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(183, 30);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(144, 23);
            this.txtOrderDate.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(183, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Order Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Enabled = false;
            this.txtOrderNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(6, 30);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(144, 23);
            this.txtOrderNumber.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Order Number";
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
            this.sbPurchaseOrders.TabIndex = 56;
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
            // PaymentTabs
            // 
            this.PaymentTabs.Controls.Add(this.tabInsurancePayments);
            this.PaymentTabs.Controls.Add(this.tabBankPayments);
            this.PaymentTabs.Controls.Add(this.tabOtherPayments);
            this.PaymentTabs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTabs.Location = new System.Drawing.Point(313, 356);
            this.PaymentTabs.Name = "PaymentTabs";
            this.PaymentTabs.SelectedIndex = 0;
            this.PaymentTabs.Size = new System.Drawing.Size(708, 330);
            this.PaymentTabs.TabIndex = 22;
            // 
            // tabInsurancePayments
            // 
            this.tabInsurancePayments.Controls.Add(this.lvwInsurancePayments);
            this.tabInsurancePayments.Controls.Add(this.grpInsurancePayments);
            this.tabInsurancePayments.Controls.Add(this.toolStripInsurancePayments);
            this.tabInsurancePayments.Location = new System.Drawing.Point(4, 25);
            this.tabInsurancePayments.Name = "tabInsurancePayments";
            this.tabInsurancePayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsurancePayments.Size = new System.Drawing.Size(700, 301);
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
            this.lvwInsurancePayments.Location = new System.Drawing.Point(6, 102);
            this.lvwInsurancePayments.MultiSelect = false;
            this.lvwInsurancePayments.Name = "lvwInsurancePayments";
            this.lvwInsurancePayments.Size = new System.Drawing.Size(685, 194);
            this.lvwInsurancePayments.TabIndex = 33;
            this.lvwInsurancePayments.UseCompatibleStateImageBehavior = false;
            this.lvwInsurancePayments.View = System.Windows.Forms.View.Details;
            this.lvwInsurancePayments.SelectedIndexChanged += new System.EventHandler(this.lvwInsurancePayments_SelectedIndexChanged);
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
            this.colInsurancePaymentAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colInsurancePaymentAmount.Width = 100;
            // 
            // grpInsurancePayments
            // 
            this.grpInsurancePayments.BackColor = System.Drawing.Color.Transparent;
            this.grpInsurancePayments.Controls.Add(this.txtInsurancePaymentInsuredDate);
            this.grpInsurancePayments.Controls.Add(this.txtInsurancePaymentReferencenumber);
            this.grpInsurancePayments.Controls.Add(this.txtInsurancePaymentAmount);
            this.grpInsurancePayments.Controls.Add(this.label21);
            this.grpInsurancePayments.Controls.Add(this.label16);
            this.grpInsurancePayments.Controls.Add(this.txtInsurancePaymentInsurerName);
            this.grpInsurancePayments.Controls.Add(this.label13);
            this.grpInsurancePayments.Controls.Add(this.label15);
            this.grpInsurancePayments.Location = new System.Drawing.Point(6, 30);
            this.grpInsurancePayments.Name = "grpInsurancePayments";
            this.grpInsurancePayments.Size = new System.Drawing.Size(685, 66);
            this.grpInsurancePayments.TabIndex = 24;
            this.grpInsurancePayments.TabStop = false;
            // 
            // txtInsurancePaymentInsuredDate
            // 
            this.txtInsurancePaymentInsuredDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsurancePaymentInsuredDate.Location = new System.Drawing.Point(283, 31);
            this.txtInsurancePaymentInsuredDate.Name = "txtInsurancePaymentInsuredDate";
            this.txtInsurancePaymentInsuredDate.Size = new System.Drawing.Size(112, 23);
            this.txtInsurancePaymentInsuredDate.TabIndex = 28;
            // 
            // txtInsurancePaymentReferencenumber
            // 
            this.txtInsurancePaymentReferencenumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsurancePaymentReferencenumber.Location = new System.Drawing.Point(396, 31);
            this.txtInsurancePaymentReferencenumber.Name = "txtInsurancePaymentReferencenumber";
            this.txtInsurancePaymentReferencenumber.Size = new System.Drawing.Size(159, 23);
            this.txtInsurancePaymentReferencenumber.TabIndex = 30;
            // 
            // txtInsurancePaymentAmount
            // 
            this.txtInsurancePaymentAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsurancePaymentAmount.Location = new System.Drawing.Point(562, 31);
            this.txtInsurancePaymentAmount.Name = "txtInsurancePaymentAmount";
            this.txtInsurancePaymentAmount.Size = new System.Drawing.Size(112, 23);
            this.txtInsurancePaymentAmount.TabIndex = 32;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(562, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 16);
            this.label21.TabIndex = 31;
            this.label21.Text = "Amount";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(396, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(159, 16);
            this.label16.TabIndex = 29;
            this.label16.Text = "Reference Number";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInsurancePaymentInsurerName
            // 
            this.txtInsurancePaymentInsurerName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsurancePaymentInsurerName.Location = new System.Drawing.Point(9, 31);
            this.txtInsurancePaymentInsurerName.Name = "txtInsurancePaymentInsurerName";
            this.txtInsurancePaymentInsurerName.Size = new System.Drawing.Size(267, 23);
            this.txtInsurancePaymentInsurerName.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(283, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Insured Date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "Insurer Name";
            // 
            // toolStripInsurancePayments
            // 
            this.toolStripInsurancePayments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripInsurancePayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnNewInsurancePayment,
            this.btnSaveInsurancePayment,
            this.btnDeleteInsurancePayment});
            this.toolStripInsurancePayments.Location = new System.Drawing.Point(3, 3);
            this.toolStripInsurancePayments.Name = "toolStripInsurancePayments";
            this.toolStripInsurancePayments.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripInsurancePayments.Size = new System.Drawing.Size(694, 25);
            this.toolStripInsurancePayments.TabIndex = 23;
            this.toolStripInsurancePayments.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewInsurancePayment
            // 
            this.btnNewInsurancePayment.BackColor = System.Drawing.Color.GhostWhite;
            this.btnNewInsurancePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnNewInsurancePayment.Image")));
            this.btnNewInsurancePayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewInsurancePayment.Name = "btnNewInsurancePayment";
            this.btnNewInsurancePayment.Size = new System.Drawing.Size(51, 22);
            this.btnNewInsurancePayment.Text = "&New";
            this.btnNewInsurancePayment.ToolTipText = "Prepare the system to accept a new insurance payment record";
            this.btnNewInsurancePayment.Click += new System.EventHandler(this.btnNewInsurancePayments_Click);
            // 
            // btnSaveInsurancePayment
            // 
            this.btnSaveInsurancePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveInsurancePayment.Image")));
            this.btnSaveInsurancePayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveInsurancePayment.Name = "btnSaveInsurancePayment";
            this.btnSaveInsurancePayment.Size = new System.Drawing.Size(51, 22);
            this.btnSaveInsurancePayment.Text = "&Save";
            this.btnSaveInsurancePayment.ToolTipText = "Save the current insurance payment record (i.e. newly created or edited)";
            this.btnSaveInsurancePayment.Click += new System.EventHandler(this.btnSaveInsurancePayments_Click);
            // 
            // btnDeleteInsurancePayment
            // 
            this.btnDeleteInsurancePayment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteInsurancePayment.Image")));
            this.btnDeleteInsurancePayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteInsurancePayment.Name = "btnDeleteInsurancePayment";
            this.btnDeleteInsurancePayment.Size = new System.Drawing.Size(60, 22);
            this.btnDeleteInsurancePayment.Text = "&Delete";
            this.btnDeleteInsurancePayment.ToolTipText = "Delete the currently selected insurance payment record";
            this.btnDeleteInsurancePayment.Click += new System.EventHandler(this.btnDeleteInsurancePayments_Click);
            // 
            // tabBankPayments
            // 
            this.tabBankPayments.Controls.Add(this.lvwBankPayments);
            this.tabBankPayments.Controls.Add(this.grpBankPayments);
            this.tabBankPayments.Controls.Add(this.toolStripBankPayments);
            this.tabBankPayments.Location = new System.Drawing.Point(4, 25);
            this.tabBankPayments.Name = "tabBankPayments";
            this.tabBankPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabBankPayments.Size = new System.Drawing.Size(700, 301);
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
            this.lvwBankPayments.Location = new System.Drawing.Point(6, 102);
            this.lvwBankPayments.MultiSelect = false;
            this.lvwBankPayments.Name = "lvwBankPayments";
            this.lvwBankPayments.Size = new System.Drawing.Size(685, 194);
            this.lvwBankPayments.TabIndex = 44;
            this.lvwBankPayments.UseCompatibleStateImageBehavior = false;
            this.lvwBankPayments.View = System.Windows.Forms.View.Details;
            this.lvwBankPayments.SelectedIndexChanged += new System.EventHandler(this.lvwBankPayments_SelectedIndexChanged);
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
            // grpBankPayments
            // 
            this.grpBankPayments.BackColor = System.Drawing.Color.Transparent;
            this.grpBankPayments.Controls.Add(this.txtBankPaymentSubmissionDate);
            this.grpBankPayments.Controls.Add(this.txtBankPaymentReferenceNumber);
            this.grpBankPayments.Controls.Add(this.txtBankPaymentServiceCharge);
            this.grpBankPayments.Controls.Add(this.label1);
            this.grpBankPayments.Controls.Add(this.label4);
            this.grpBankPayments.Controls.Add(this.txtBankPaymentBankName);
            this.grpBankPayments.Controls.Add(this.label5);
            this.grpBankPayments.Controls.Add(this.label7);
            this.grpBankPayments.Location = new System.Drawing.Point(6, 30);
            this.grpBankPayments.Name = "grpBankPayments";
            this.grpBankPayments.Size = new System.Drawing.Size(685, 66);
            this.grpBankPayments.TabIndex = 35;
            this.grpBankPayments.TabStop = false;
            // 
            // txtBankPaymentSubmissionDate
            // 
            this.txtBankPaymentSubmissionDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankPaymentSubmissionDate.Location = new System.Drawing.Point(283, 31);
            this.txtBankPaymentSubmissionDate.Name = "txtBankPaymentSubmissionDate";
            this.txtBankPaymentSubmissionDate.Size = new System.Drawing.Size(105, 23);
            this.txtBankPaymentSubmissionDate.TabIndex = 39;
            // 
            // txtBankPaymentReferenceNumber
            // 
            this.txtBankPaymentReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankPaymentReferenceNumber.Location = new System.Drawing.Point(396, 31);
            this.txtBankPaymentReferenceNumber.Name = "txtBankPaymentReferenceNumber";
            this.txtBankPaymentReferenceNumber.Size = new System.Drawing.Size(159, 23);
            this.txtBankPaymentReferenceNumber.TabIndex = 41;
            // 
            // txtBankPaymentServiceCharge
            // 
            this.txtBankPaymentServiceCharge.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankPaymentServiceCharge.Location = new System.Drawing.Point(562, 31);
            this.txtBankPaymentServiceCharge.Name = "txtBankPaymentServiceCharge";
            this.txtBankPaymentServiceCharge.Size = new System.Drawing.Size(112, 23);
            this.txtBankPaymentServiceCharge.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(562, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Service Charge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(396, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Reference Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBankPaymentBankName
            // 
            this.txtBankPaymentBankName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBankPaymentBankName.Location = new System.Drawing.Point(9, 31);
            this.txtBankPaymentBankName.Name = "txtBankPaymentBankName";
            this.txtBankPaymentBankName.Size = new System.Drawing.Size(267, 23);
            this.txtBankPaymentBankName.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(283, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Submission Date";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Bank Name";
            // 
            // toolStripBankPayments
            // 
            this.toolStripBankPayments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripBankPayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.btnNewBankPayment,
            this.btnSaveBankPayment,
            this.btnDeleteBankPayment});
            this.toolStripBankPayments.Location = new System.Drawing.Point(3, 3);
            this.toolStripBankPayments.Name = "toolStripBankPayments";
            this.toolStripBankPayments.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripBankPayments.Size = new System.Drawing.Size(694, 25);
            this.toolStripBankPayments.TabIndex = 34;
            this.toolStripBankPayments.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewBankPayment
            // 
            this.btnNewBankPayment.BackColor = System.Drawing.Color.GhostWhite;
            this.btnNewBankPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnNewBankPayment.Image")));
            this.btnNewBankPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewBankPayment.Name = "btnNewBankPayment";
            this.btnNewBankPayment.Size = new System.Drawing.Size(51, 22);
            this.btnNewBankPayment.Text = "&New";
            this.btnNewBankPayment.ToolTipText = "Prepare the system to accept a new bank payment record";
            this.btnNewBankPayment.Click += new System.EventHandler(this.btnNewBankPayments_Click);
            // 
            // btnSaveBankPayment
            // 
            this.btnSaveBankPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveBankPayment.Image")));
            this.btnSaveBankPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveBankPayment.Name = "btnSaveBankPayment";
            this.btnSaveBankPayment.Size = new System.Drawing.Size(51, 22);
            this.btnSaveBankPayment.Text = "&Save";
            this.btnSaveBankPayment.ToolTipText = "Save the current bank payment record (i.e. newly created or edited)";
            this.btnSaveBankPayment.Click += new System.EventHandler(this.btnSaveBankPayments_Click);
            // 
            // btnDeleteBankPayment
            // 
            this.btnDeleteBankPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteBankPayment.Image")));
            this.btnDeleteBankPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteBankPayment.Name = "btnDeleteBankPayment";
            this.btnDeleteBankPayment.Size = new System.Drawing.Size(60, 22);
            this.btnDeleteBankPayment.Text = "&Delete";
            this.btnDeleteBankPayment.ToolTipText = "Delete the currently selected bank payment record";
            this.btnDeleteBankPayment.Click += new System.EventHandler(this.btnDeleteBankPayments_Click);
            // 
            // tabOtherPayments
            // 
            this.tabOtherPayments.Controls.Add(this.lvwOtherPayments);
            this.tabOtherPayments.Controls.Add(this.grpOtherPayments);
            this.tabOtherPayments.Controls.Add(this.toolStripOtherPayment);
            this.tabOtherPayments.Location = new System.Drawing.Point(4, 25);
            this.tabOtherPayments.Name = "tabOtherPayments";
            this.tabOtherPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtherPayments.Size = new System.Drawing.Size(700, 301);
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
            this.lvwOtherPayments.Location = new System.Drawing.Point(6, 102);
            this.lvwOtherPayments.MultiSelect = false;
            this.lvwOtherPayments.Name = "lvwOtherPayments";
            this.lvwOtherPayments.Size = new System.Drawing.Size(685, 194);
            this.lvwOtherPayments.TabIndex = 55;
            this.lvwOtherPayments.UseCompatibleStateImageBehavior = false;
            this.lvwOtherPayments.View = System.Windows.Forms.View.Details;
            this.lvwOtherPayments.SelectedIndexChanged += new System.EventHandler(this.lvwOtherPayments_SelectedIndexChanged);
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
            // grpOtherPayments
            // 
            this.grpOtherPayments.BackColor = System.Drawing.Color.Transparent;
            this.grpOtherPayments.Controls.Add(this.txtOtherPaymentPaymentDate);
            this.grpOtherPayments.Controls.Add(this.cboOtherPaymentPaymentReason);
            this.grpOtherPayments.Controls.Add(this.txtOtherPaymentReferenceNumber);
            this.grpOtherPayments.Controls.Add(this.txtOtherPaymentAmount);
            this.grpOtherPayments.Controls.Add(this.label10);
            this.grpOtherPayments.Controls.Add(this.label11);
            this.grpOtherPayments.Controls.Add(this.label12);
            this.grpOtherPayments.Controls.Add(this.label14);
            this.grpOtherPayments.Location = new System.Drawing.Point(6, 30);
            this.grpOtherPayments.Name = "grpOtherPayments";
            this.grpOtherPayments.Size = new System.Drawing.Size(685, 66);
            this.grpOtherPayments.TabIndex = 46;
            this.grpOtherPayments.TabStop = false;
            // 
            // txtOtherPaymentPaymentDate
            // 
            this.txtOtherPaymentPaymentDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherPaymentPaymentDate.Location = new System.Drawing.Point(281, 31);
            this.txtOtherPaymentPaymentDate.Name = "txtOtherPaymentPaymentDate";
            this.txtOtherPaymentPaymentDate.Size = new System.Drawing.Size(105, 23);
            this.txtOtherPaymentPaymentDate.TabIndex = 50;
            // 
            // cboOtherPaymentPaymentReason
            // 
            this.cboOtherPaymentPaymentReason.AllowDrop = true;
            this.cboOtherPaymentPaymentReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOtherPaymentPaymentReason.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboOtherPaymentPaymentReason.FormattingEnabled = true;
            this.cboOtherPaymentPaymentReason.Location = new System.Drawing.Point(9, 30);
            this.cboOtherPaymentPaymentReason.Name = "cboOtherPaymentPaymentReason";
            this.cboOtherPaymentPaymentReason.Size = new System.Drawing.Size(261, 24);
            this.cboOtherPaymentPaymentReason.TabIndex = 48;
            // 
            // txtOtherPaymentReferenceNumber
            // 
            this.txtOtherPaymentReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherPaymentReferenceNumber.Location = new System.Drawing.Point(396, 31);
            this.txtOtherPaymentReferenceNumber.Name = "txtOtherPaymentReferenceNumber";
            this.txtOtherPaymentReferenceNumber.Size = new System.Drawing.Size(159, 23);
            this.txtOtherPaymentReferenceNumber.TabIndex = 52;
            // 
            // txtOtherPaymentAmount
            // 
            this.txtOtherPaymentAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherPaymentAmount.Location = new System.Drawing.Point(562, 31);
            this.txtOtherPaymentAmount.Name = "txtOtherPaymentAmount";
            this.txtOtherPaymentAmount.Size = new System.Drawing.Size(112, 23);
            this.txtOtherPaymentAmount.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(562, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "Amount";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(396, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Reference Number";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(281, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Payment Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 16);
            this.label14.TabIndex = 47;
            this.label14.Text = "Payment Reason";
            // 
            // toolStripOtherPayment
            // 
            this.toolStripOtherPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripOtherPayment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.btnNewOtherPayment,
            this.btnSaveOtherPayment,
            this.btnDeleteOtherPayment});
            this.toolStripOtherPayment.Location = new System.Drawing.Point(3, 3);
            this.toolStripOtherPayment.Name = "toolStripOtherPayment";
            this.toolStripOtherPayment.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripOtherPayment.Size = new System.Drawing.Size(694, 25);
            this.toolStripOtherPayment.TabIndex = 45;
            this.toolStripOtherPayment.Text = "toolStrip1";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewOtherPayment
            // 
            this.btnNewOtherPayment.BackColor = System.Drawing.Color.GhostWhite;
            this.btnNewOtherPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnNewOtherPayment.Image")));
            this.btnNewOtherPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewOtherPayment.Name = "btnNewOtherPayment";
            this.btnNewOtherPayment.Size = new System.Drawing.Size(51, 22);
            this.btnNewOtherPayment.Text = "&New";
            this.btnNewOtherPayment.ToolTipText = "Prepare the system to accept a new miscellaneous payment record";
            this.btnNewOtherPayment.Click += new System.EventHandler(this.btnNewPurchaseOrderPayments_Click);
            // 
            // btnSaveOtherPayment
            // 
            this.btnSaveOtherPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveOtherPayment.Image")));
            this.btnSaveOtherPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveOtherPayment.Name = "btnSaveOtherPayment";
            this.btnSaveOtherPayment.Size = new System.Drawing.Size(51, 22);
            this.btnSaveOtherPayment.Text = "&Save";
            this.btnSaveOtherPayment.ToolTipText = "Save the current miscellaneous payment record (i.e. newly created or edited)";
            this.btnSaveOtherPayment.Click += new System.EventHandler(this.btnSavePurchaseOrderPayments_Click);
            // 
            // btnDeleteOtherPayment
            // 
            this.btnDeleteOtherPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteOtherPayment.Image")));
            this.btnDeleteOtherPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteOtherPayment.Name = "btnDeleteOtherPayment";
            this.btnDeleteOtherPayment.Size = new System.Drawing.Size(60, 22);
            this.btnDeleteOtherPayment.Text = "&Delete";
            this.btnDeleteOtherPayment.ToolTipText = "Delete the currently selected miscellaneous payment record";
            this.btnDeleteOtherPayment.Click += new System.EventHandler(this.btnDeletePurchaseOrderPayments_Click);
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.tabPageDetail);
            this.tabDetail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDetail.Location = new System.Drawing.Point(313, 134);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedIndex = 0;
            this.tabDetail.Size = new System.Drawing.Size(710, 218);
            this.tabDetail.TabIndex = 20;
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.lvwPurchaseOrderDetails);
            this.tabPageDetail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(702, 189);
            this.tabPageDetail.TabIndex = 0;
            this.tabPageDetail.Text = "Order Details";
            this.tabPageDetail.UseVisualStyleBackColor = true;
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
            this.colPurchaseOrderDetailsCurrencytype,
            this.colPurchaseOrderDetailsCurrencytypedescription,
            this.colPurchaseOrderDetailsFreightcharge});
            this.lvwPurchaseOrderDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPurchaseOrderDetails.FullRowSelect = true;
            this.lvwPurchaseOrderDetails.GridLines = true;
            this.lvwPurchaseOrderDetails.Location = new System.Drawing.Point(3, 6);
            this.lvwPurchaseOrderDetails.MultiSelect = false;
            this.lvwPurchaseOrderDetails.Name = "lvwPurchaseOrderDetails";
            this.lvwPurchaseOrderDetails.Size = new System.Drawing.Size(696, 178);
            this.lvwPurchaseOrderDetails.TabIndex = 21;
            this.lvwPurchaseOrderDetails.UseCompatibleStateImageBehavior = false;
            this.lvwPurchaseOrderDetails.View = System.Windows.Forms.View.Details;
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
            this.colPurchaseOrderDetailsQuantity.Width = 80;
            // 
            // colPurchaseOrderDetailsPriceperunit
            // 
            this.colPurchaseOrderDetailsPriceperunit.Text = "Price per Unit";
            this.colPurchaseOrderDetailsPriceperunit.Width = 100;
            // 
            // colPurchaseOrderDetailsCurrencytype
            // 
            this.colPurchaseOrderDetailsCurrencytype.Text = "Currency Type Id";
            this.colPurchaseOrderDetailsCurrencytype.Width = 0;
            // 
            // colPurchaseOrderDetailsCurrencytypedescription
            // 
            this.colPurchaseOrderDetailsCurrencytypedescription.Text = "Currency Type";
            this.colPurchaseOrderDetailsCurrencytypedescription.Width = 100;
            // 
            // colPurchaseOrderDetailsFreightcharge
            // 
            this.colPurchaseOrderDetailsFreightcharge.Text = "Freight Charge";
            this.colPurchaseOrderDetailsFreightcharge.Width = 120;
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
            this.grpFilter.Location = new System.Drawing.Point(9, 43);
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
            this.btnSearchManufacturerFilter.Location = new System.Drawing.Point(210, 6);
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
            // frmProcessPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1063, 710);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.tabDetail);
            this.Controls.Add(this.PaymentTabs);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.sbPurchaseOrders);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvwPurchaseOrders);
            this.Name = "frmProcessPurchaseOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Purchase Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.Resize += new System.EventHandler(this.frmProcessPurchaseOrder_Resize);
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.proformaToolStrip.ResumeLayout(false);
            this.proformaToolStrip.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.sbPurchaseOrders.ResumeLayout(false);
            this.sbPurchaseOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.PaymentTabs.ResumeLayout(false);
            this.tabInsurancePayments.ResumeLayout(false);
            this.tabInsurancePayments.PerformLayout();
            this.grpInsurancePayments.ResumeLayout(false);
            this.grpInsurancePayments.PerformLayout();
            this.toolStripInsurancePayments.ResumeLayout(false);
            this.toolStripInsurancePayments.PerformLayout();
            this.tabBankPayments.ResumeLayout(false);
            this.tabBankPayments.PerformLayout();
            this.grpBankPayments.ResumeLayout(false);
            this.grpBankPayments.PerformLayout();
            this.toolStripBankPayments.ResumeLayout(false);
            this.toolStripBankPayments.PerformLayout();
            this.tabOtherPayments.ResumeLayout(false);
            this.tabOtherPayments.PerformLayout();
            this.grpOtherPayments.ResumeLayout(false);
            this.grpOtherPayments.PerformLayout();
            this.toolStripOtherPayment.ResumeLayout(false);
            this.toolStripOtherPayment.PerformLayout();
            this.tabDetail.ResumeLayout(false);
            this.tabPageDetail.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colTermsOfContract;
        private System.Windows.Forms.StatusStrip sbPurchaseOrders;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaGuid;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.TabControl PaymentTabs;
        private System.Windows.Forms.TabPage tabBankPayments;
        private System.Windows.Forms.TabPage tabOtherPayments;
        private System.Windows.Forms.TabPage tabInsurancePayments;
        private System.Windows.Forms.ToolStrip toolStripInsurancePayments;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnNewInsurancePayment;
        private System.Windows.Forms.GroupBox grpInsurancePayments;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtInsurancePaymentInsurerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtInsurancePaymentReferencenumber;
        private System.Windows.Forms.TextBox txtInsurancePaymentAmount;
        private System.Windows.Forms.ListView lvwInsurancePayments;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentID;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentInsurerName;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentInsuredDate;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentReferenceNumber;
        private System.Windows.Forms.ColumnHeader colInsurancePaymentAmount;
        private System.Windows.Forms.ToolStrip toolStripBankPayments;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton btnNewBankPayment;
        private System.Windows.Forms.GroupBox grpBankPayments;
        private System.Windows.Forms.TextBox txtBankPaymentReferenceNumber;
        private System.Windows.Forms.TextBox txtBankPaymentServiceCharge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBankPaymentBankName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvwBankPayments;
        private System.Windows.Forms.ColumnHeader colBankPaymentID;
        private System.Windows.Forms.ColumnHeader colBankPaymentPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colBankPaymentBankName;
        private System.Windows.Forms.ColumnHeader colBankPaymentSubmissionDate;
        private System.Windows.Forms.ColumnHeader colBankPaymentReferenceNumber;
        private System.Windows.Forms.ColumnHeader colBankPaymentServiceCharge;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btnNewOtherPayment;
        private System.Windows.Forms.ListView lvwOtherPayments;
        private System.Windows.Forms.ColumnHeader colOtherPaymentId;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentOrderGuid;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentReasonDescription;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentDate;
        private System.Windows.Forms.ColumnHeader colOtherPaymentReferenceNumber;
        private System.Windows.Forms.ColumnHeader colOtherPaymentAmount;
        private System.Windows.Forms.GroupBox grpOtherPayments;
        private System.Windows.Forms.TextBox txtOtherPaymentReferenceNumber;
        private System.Windows.Forms.TextBox txtOtherPaymentAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox cboOtherPaymentPaymentReason;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentReason;
        private System.Windows.Forms.TabControl tabDetail;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.ListView lvwPurchaseOrderDetails;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsId;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsItemGuid;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsItemName;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsQuantity;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsPriceperunit;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsCurrencytype;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsCurrencytypedescription;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsFreightcharge;
        public System.Windows.Forms.ToolStripButton btnSaveInsurancePayment;
        public System.Windows.Forms.ToolStripButton btnDeleteInsurancePayment;
        public System.Windows.Forms.ToolStripButton btnSaveBankPayment;
        public System.Windows.Forms.ToolStripButton btnDeleteBankPayment;
        public System.Windows.Forms.ToolStrip toolStripOtherPayment;
        public System.Windows.Forms.ToolStripButton btnDeleteOtherPayment;
        public System.Windows.Forms.ToolStripButton btnSaveOtherPayment;
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
        private System.Windows.Forms.TextBox txtInsurancePaymentInsuredDate;
        private System.Windows.Forms.TextBox txtBankPaymentSubmissionDate;
        private System.Windows.Forms.TextBox txtOtherPaymentPaymentDate;
        private System.Windows.Forms.Button btnSearchManufacturerFilter1;
    }
}