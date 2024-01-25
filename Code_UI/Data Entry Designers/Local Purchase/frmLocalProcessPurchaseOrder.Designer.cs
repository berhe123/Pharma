namespace Pharma
{
    partial class frmLocalProcessPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalProcessPurchaseOrder));
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
            this.PaymentTabs = new System.Windows.Forms.TabControl();
            this.panelToolbar.SuspendLayout();
            this.proformaToolStrip.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.sbPurchaseOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.tabPageDetail.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.tabOtherPayments.SuspendLayout();
            this.grpOtherPayments.SuspendLayout();
            this.toolStripOtherPayment.SuspendLayout();
            this.PaymentTabs.SuspendLayout();
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
            this.lblTitle.Text = "    Maintain Payments Made to Local Purchase Orders";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
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
            this.lvwPurchaseOrderDetails.SelectedIndexChanged += new System.EventHandler(this.lvwPurchaseOrderDetails_SelectedIndexChanged);
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
            this.colPurchaseOrderDetailsItemName.Width = 400;
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
            this.colPurchaseOrderDetailsFreightcharge.Width = 0;
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
            this.label18.Text = "Supplier";
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
            this.tabOtherPayments.Text = "Local Purchase Order Payments";
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
            // PaymentTabs
            // 
            this.PaymentTabs.Controls.Add(this.tabOtherPayments);
            this.PaymentTabs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTabs.Location = new System.Drawing.Point(313, 356);
            this.PaymentTabs.Name = "PaymentTabs";
            this.PaymentTabs.SelectedIndex = 0;
            this.PaymentTabs.Size = new System.Drawing.Size(708, 330);
            this.PaymentTabs.TabIndex = 22;
            // 
            // frmLocalProcessPurchaseOrder
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
            this.Name = "frmLocalProcessPurchaseOrder";
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
            this.tabDetail.ResumeLayout(false);
            this.tabPageDetail.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.tabOtherPayments.ResumeLayout(false);
            this.tabOtherPayments.PerformLayout();
            this.grpOtherPayments.ResumeLayout(false);
            this.grpOtherPayments.PerformLayout();
            this.toolStripOtherPayment.ResumeLayout(false);
            this.toolStripOtherPayment.PerformLayout();
            this.PaymentTabs.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSearchManufacturerFilter1;
        private System.Windows.Forms.TabControl PaymentTabs;
        private System.Windows.Forms.TabPage tabOtherPayments;
        private System.Windows.Forms.ListView lvwOtherPayments;
        private System.Windows.Forms.ColumnHeader colOtherPaymentId;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentOrderGuid;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentReason;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentReasonDescription;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentDate;
        private System.Windows.Forms.ColumnHeader colOtherPaymentReferenceNumber;
        private System.Windows.Forms.ColumnHeader colOtherPaymentAmount;
        private System.Windows.Forms.GroupBox grpOtherPayments;
        private System.Windows.Forms.TextBox txtOtherPaymentPaymentDate;
        public System.Windows.Forms.ComboBox cboOtherPaymentPaymentReason;
        private System.Windows.Forms.TextBox txtOtherPaymentReferenceNumber;
        private System.Windows.Forms.TextBox txtOtherPaymentAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ToolStrip toolStripOtherPayment;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripButton btnNewOtherPayment;
        public System.Windows.Forms.ToolStripButton btnSaveOtherPayment;
        public System.Windows.Forms.ToolStripButton btnDeleteOtherPayment;
    }
}