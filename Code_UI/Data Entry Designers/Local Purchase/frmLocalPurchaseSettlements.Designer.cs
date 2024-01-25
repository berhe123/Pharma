namespace Pharma
{
    partial class frmLocalPurchaseSettlements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalPurchaseSettlements));
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.txtOrganizationName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.cboSettlementStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tabOtherPayments = new System.Windows.Forms.TabPage();
            this.lvwOtherPayments = new System.Windows.Forms.ListView();
            this.colOtherPaymentId = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentReason = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentReasonDescription = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentPaymentDate = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colOtherPaymentAmount = new System.Windows.Forms.ColumnHeader();
            this.grpSettlement = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSettle = new System.Windows.Forms.Button();
            this.grbCheckCPOInfo = new System.Windows.Forms.GroupBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboBank = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaturityDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCheckCPODate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCheckCPONo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSettlementDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvwPaymentRequests = new System.Windows.Forms.ListView();
            this.colRequestId = new System.Windows.Forms.ColumnHeader();
            this.colReqOrganizationName = new System.Windows.Forms.ColumnHeader();
            this.colRequestDate = new System.Windows.Forms.ColumnHeader();
            this.colReferenceNo = new System.Windows.Forms.ColumnHeader();
            this.colModeOfPayment = new System.Windows.Forms.ColumnHeader();
            this.colBankGuid = new System.Windows.Forms.ColumnHeader();
            this.colBankBranchName = new System.Windows.Forms.ColumnHeader();
            this.colCheckOrCPONumber = new System.Windows.Forms.ColumnHeader();
            this.colCheckOrCPODate = new System.Windows.Forms.ColumnHeader();
            this.colCheckMaturityDate = new System.Windows.Forms.ColumnHeader();
            this.colSettled = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.panelToolbar.SuspendLayout();
            this.proformaToolStrip.SuspendLayout();
            this.sbPurchaseOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.grpOrder.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.PaymentTabs.SuspendLayout();
            this.tabPurchaseOrderDetails.SuspendLayout();
            this.tabOtherPayments.SuspendLayout();
            this.grpSettlement.SuspendLayout();
            this.grbCheckCPOInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1101, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "    Maintain Batchs in the Local Purchase Order";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolbar.Controls.Add(this.proformaToolStrip);
            this.panelToolbar.Location = new System.Drawing.Point(375, 45);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(728, 28);
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
            this.proformaToolStrip.Size = new System.Drawing.Size(728, 25);
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
            this.sbPurchaseOrders.Location = new System.Drawing.Point(0, 943);
            this.sbPurchaseOrders.Name = "sbPurchaseOrders";
            this.sbPurchaseOrders.Size = new System.Drawing.Size(1135, 22);
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
            this.label2.Location = new System.Drawing.Point(398, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Order Number";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Enabled = false;
            this.txtOrderNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(398, 32);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(122, 23);
            this.txtOrderNumber.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(525, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Order Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.txtOrganizationName);
            this.grpOrder.Controls.Add(this.label16);
            this.grpOrder.Controls.Add(this.txtOrderDate);
            this.grpOrder.Controls.Add(this.label8);
            this.grpOrder.Controls.Add(this.txtOrderNumber);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Location = new System.Drawing.Point(375, 76);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(728, 67);
            this.grpOrder.TabIndex = 15;
            this.grpOrder.TabStop = false;
            // 
            // txtOrganizationName
            // 
            this.txtOrganizationName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationName.Location = new System.Drawing.Point(7, 32);
            this.txtOrganizationName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.ReadOnly = true;
            this.txtOrganizationName.Size = new System.Drawing.Size(384, 23);
            this.txtOrganizationName.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(7, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 16);
            this.label16.TabIndex = 20;
            this.label16.Text = "Suplier Name";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(525, 30);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(114, 23);
            this.txtOrderDate.TabIndex = 19;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.cboSettlementStatus);
            this.grpFilter.Controls.Add(this.label4);
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
            this.grpFilter.Size = new System.Drawing.Size(362, 195);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // cboSettlementStatus
            // 
            this.cboSettlementStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSettlementStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSettlementStatus.FormattingEnabled = true;
            this.cboSettlementStatus.Location = new System.Drawing.Point(12, 131);
            this.cboSettlementStatus.Name = "cboSettlementStatus";
            this.cboSettlementStatus.Size = new System.Drawing.Size(304, 24);
            this.cboSettlementStatus.TabIndex = 168;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 167;
            this.label4.Text = "Settlement Status";
            // 
            // btnSearchManufacturerFilter1
            // 
            this.btnSearchManufacturerFilter1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturerFilter1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturerFilter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturerFilter1.Location = new System.Drawing.Point(324, 32);
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
            this.txtOrderDateTo.Location = new System.Drawing.Point(217, 78);
            this.txtOrderDateTo.Name = "txtOrderDateTo";
            this.txtOrderDateTo.Size = new System.Drawing.Size(99, 23);
            this.txtOrderDateTo.TabIndex = 11;
            // 
            // txtOrderDateFrom
            // 
            this.txtOrderDateFrom.BackColor = System.Drawing.SystemColors.Window;
            this.txtOrderDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDateFrom.Location = new System.Drawing.Point(67, 78);
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
            this.label6.Location = new System.Drawing.Point(177, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "To:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(12, 81);
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
            this.txtManufacturerFilter.Size = new System.Drawing.Size(306, 23);
            this.txtManufacturerFilter.TabIndex = 4;
            this.txtManufacturerFilter.TextChanged += new System.EventHandler(this.txtManufacturerFilter_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnShow.Image = global::Pharma.Properties.Resources.refresh;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnShow.Location = new System.Drawing.Point(12, 162);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(304, 27);
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
            this.label3.Location = new System.Drawing.Point(67, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentTabs
            // 
            this.PaymentTabs.Controls.Add(this.tabPurchaseOrderDetails);
            this.PaymentTabs.Controls.Add(this.tabOtherPayments);
            this.PaymentTabs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTabs.Location = new System.Drawing.Point(373, 145);
            this.PaymentTabs.Name = "PaymentTabs";
            this.PaymentTabs.SelectedIndex = 0;
            this.PaymentTabs.Size = new System.Drawing.Size(737, 200);
            this.PaymentTabs.TabIndex = 107;
            // 
            // tabPurchaseOrderDetails
            // 
            this.tabPurchaseOrderDetails.Controls.Add(this.lvwPurchaseOrderDetails);
            this.tabPurchaseOrderDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPurchaseOrderDetails.Name = "tabPurchaseOrderDetails";
            this.tabPurchaseOrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPurchaseOrderDetails.Size = new System.Drawing.Size(729, 171);
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
            this.lvwPurchaseOrderDetails.Size = new System.Drawing.Size(724, 162);
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
            this.colPurchaseOrderDetailsItemName.Width = 350;
            // 
            // colPurchaseOrderDetailsQuantity
            // 
            this.colPurchaseOrderDetailsQuantity.Text = "Quantity";
            this.colPurchaseOrderDetailsQuantity.Width = 100;
            // 
            // colPurchaseOrderDetailsPriceperunit
            // 
            this.colPurchaseOrderDetailsPriceperunit.Text = "Price per Unit";
            this.colPurchaseOrderDetailsPriceperunit.Width = 100;
            // 
            // colLineTotal
            // 
            this.colLineTotal.Text = "Total";
            this.colLineTotal.Width = 150;
            // 
            // tabOtherPayments
            // 
            this.tabOtherPayments.Controls.Add(this.lvwOtherPayments);
            this.tabOtherPayments.Location = new System.Drawing.Point(4, 25);
            this.tabOtherPayments.Name = "tabOtherPayments";
            this.tabOtherPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtherPayments.Size = new System.Drawing.Size(643, 171);
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
            this.lvwOtherPayments.Size = new System.Drawing.Size(635, 166);
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
            this.colOtherPaymentPaymentReasonDescription.Width = 200;
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
            // grpSettlement
            // 
            this.grpSettlement.Controls.Add(this.btnNew);
            this.grpSettlement.Controls.Add(this.btnSettle);
            this.grpSettlement.Controls.Add(this.grbCheckCPOInfo);
            this.grpSettlement.Controls.Add(this.cboPaymentType);
            this.grpSettlement.Controls.Add(this.label15);
            this.grpSettlement.Controls.Add(this.txtSettlementDate);
            this.grpSettlement.Controls.Add(this.label7);
            this.grpSettlement.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSettlement.Location = new System.Drawing.Point(373, 351);
            this.grpSettlement.Name = "grpSettlement";
            this.grpSettlement.Size = new System.Drawing.Size(737, 334);
            this.grpSettlement.TabIndex = 108;
            this.grpSettlement.TabStop = false;
            this.grpSettlement.Text = "Settlement";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Pharma.Properties.Resources.New;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(455, 29);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 29);
            this.btnNew.TabIndex = 63;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSettle
            // 
            this.btnSettle.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettle.Location = new System.Drawing.Point(338, 29);
            this.btnSettle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(110, 29);
            this.btnSettle.TabIndex = 35;
            this.btnSettle.Text = "     Settle";
            this.btnSettle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettle.UseVisualStyleBackColor = true;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // grbCheckCPOInfo
            // 
            this.grbCheckCPOInfo.Controls.Add(this.txtBranchName);
            this.grbCheckCPOInfo.Controls.Add(this.label14);
            this.grbCheckCPOInfo.Controls.Add(this.cboBank);
            this.grbCheckCPOInfo.Controls.Add(this.label13);
            this.grbCheckCPOInfo.Controls.Add(this.txtMaturityDate);
            this.grbCheckCPOInfo.Controls.Add(this.label12);
            this.grbCheckCPOInfo.Controls.Add(this.txtCheckCPODate);
            this.grbCheckCPOInfo.Controls.Add(this.label11);
            this.grbCheckCPOInfo.Controls.Add(this.txtCheckCPONo);
            this.grbCheckCPOInfo.Controls.Add(this.label10);
            this.grbCheckCPOInfo.Location = new System.Drawing.Point(10, 110);
            this.grbCheckCPOInfo.Name = "grbCheckCPOInfo";
            this.grbCheckCPOInfo.Size = new System.Drawing.Size(574, 110);
            this.grbCheckCPOInfo.TabIndex = 24;
            this.grbCheckCPOInfo.TabStop = false;
            this.grbCheckCPOInfo.Text = "Mode of Payment Detail";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(276, 31);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(288, 23);
            this.txtBranchName.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(276, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 27;
            this.label14.Text = "Branch Name";
            // 
            // cboBank
            // 
            this.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBank.FormattingEnabled = true;
            this.cboBank.Location = new System.Drawing.Point(12, 31);
            this.cboBank.Name = "cboBank";
            this.cboBank.Size = new System.Drawing.Size(252, 24);
            this.cboBank.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Bank";
            // 
            // txtMaturityDate
            // 
            this.txtMaturityDate.Location = new System.Drawing.Point(276, 81);
            this.txtMaturityDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaturityDate.Name = "txtMaturityDate";
            this.txtMaturityDate.Size = new System.Drawing.Size(118, 23);
            this.txtMaturityDate.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "Maturity Date";
            // 
            // txtCheckCPODate
            // 
            this.txtCheckCPODate.Location = new System.Drawing.Point(153, 81);
            this.txtCheckCPODate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckCPODate.Name = "txtCheckCPODate";
            this.txtCheckCPODate.Size = new System.Drawing.Size(111, 23);
            this.txtCheckCPODate.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "Check/CPO Date";
            // 
            // txtCheckCPONo
            // 
            this.txtCheckCPONo.Location = new System.Drawing.Point(12, 81);
            this.txtCheckCPONo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckCPONo.Name = "txtCheckCPONo";
            this.txtCheckCPONo.Size = new System.Drawing.Size(130, 23);
            this.txtCheckCPONo.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Check/CPO Number";
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Location = new System.Drawing.Point(172, 36);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(152, 24);
            this.cboPaymentType.TabIndex = 23;
            this.cboPaymentType.SelectedIndexChanged += new System.EventHandler(this.cboPaymentType_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(172, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Mode of Payment";
            // 
            // txtSettlementDate
            // 
            this.txtSettlementDate.Location = new System.Drawing.Point(10, 36);
            this.txtSettlementDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSettlementDate.Name = "txtSettlementDate";
            this.txtSettlementDate.Size = new System.Drawing.Size(152, 23);
            this.txtSettlementDate.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Settlement Date";
            // 
            // lvwPaymentRequests
            // 
            this.lvwPaymentRequests.CheckBoxes = true;
            this.lvwPaymentRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRequestId,
            this.colReqOrganizationName,
            this.colRequestDate,
            this.colReferenceNo,
            this.colModeOfPayment,
            this.colBankGuid,
            this.colBankBranchName,
            this.colCheckOrCPONumber,
            this.colCheckOrCPODate,
            this.colCheckMaturityDate,
            this.colSettled,
            this.colPurchaseOrderGuid});
            this.lvwPaymentRequests.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPaymentRequests.FullRowSelect = true;
            this.lvwPaymentRequests.GridLines = true;
            this.lvwPaymentRequests.Location = new System.Drawing.Point(12, 237);
            this.lvwPaymentRequests.Name = "lvwPaymentRequests";
            this.lvwPaymentRequests.Size = new System.Drawing.Size(359, 448);
            this.lvwPaymentRequests.TabIndex = 109;
            this.lvwPaymentRequests.UseCompatibleStateImageBehavior = false;
            this.lvwPaymentRequests.View = System.Windows.Forms.View.Details;
            this.lvwPaymentRequests.SelectedIndexChanged += new System.EventHandler(this.lvwPaymentRequests_SelectedIndexChanged);
            // 
            // colRequestId
            // 
            this.colRequestId.Text = "Id";
            this.colRequestId.Width = 0;
            // 
            // colReqOrganizationName
            // 
            this.colReqOrganizationName.Text = "Supplier Name";
            this.colReqOrganizationName.Width = 150;
            // 
            // colRequestDate
            // 
            this.colRequestDate.Text = "Order Date";
            this.colRequestDate.Width = 100;
            // 
            // colReferenceNo
            // 
            this.colReferenceNo.Text = "Order No";
            this.colReferenceNo.Width = 100;
            // 
            // colModeOfPayment
            // 
            this.colModeOfPayment.Text = "Mode Of Payment";
            this.colModeOfPayment.Width = 0;
            // 
            // colBankGuid
            // 
            this.colBankGuid.Text = "BankGuid";
            this.colBankGuid.Width = 0;
            // 
            // colBankBranchName
            // 
            this.colBankBranchName.Text = "BankBranchName";
            this.colBankBranchName.Width = 0;
            // 
            // colCheckOrCPONumber
            // 
            this.colCheckOrCPONumber.Text = "CheckOrCPONumber";
            this.colCheckOrCPONumber.Width = 0;
            // 
            // colCheckOrCPODate
            // 
            this.colCheckOrCPODate.Text = "CheckOrCPODate";
            this.colCheckOrCPODate.Width = 0;
            // 
            // colCheckMaturityDate
            // 
            this.colCheckMaturityDate.Text = "CheckMaturityDate";
            this.colCheckMaturityDate.Width = 0;
            // 
            // colSettled
            // 
            this.colSettled.Text = "Settled";
            this.colSettled.Width = 0;
            // 
            // colPurchaseOrderGuid
            // 
            this.colPurchaseOrderGuid.Text = "";
            this.colPurchaseOrderGuid.Width = 0;
            // 
            // frmLocalPurchaseSettlements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1135, 965);
            this.Controls.Add(this.lvwPaymentRequests);
            this.Controls.Add(this.grpSettlement);
            this.Controls.Add(this.PaymentTabs);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.sbPurchaseOrders);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmLocalPurchaseSettlements";
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
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.PaymentTabs.ResumeLayout(false);
            this.tabPurchaseOrderDetails.ResumeLayout(false);
            this.tabOtherPayments.ResumeLayout(false);
            this.grpSettlement.ResumeLayout(false);
            this.grpSettlement.PerformLayout();
            this.grbCheckCPOInfo.ResumeLayout(false);
            this.grbCheckCPOInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.ToolStrip proformaToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.StatusStrip sbPurchaseOrders;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.TabPage tabPurchaseOrderDetails;
        private System.Windows.Forms.ListView lvwPurchaseOrderDetails;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsId;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsItemGuid;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsItemName;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsQuantity;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsPriceperunit;
        private System.Windows.Forms.ColumnHeader colLineTotal;
        private System.Windows.Forms.TabPage tabOtherPayments;
        private System.Windows.Forms.ListView lvwOtherPayments;
        private System.Windows.Forms.ColumnHeader colOtherPaymentId;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentOrderGuid;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentReason;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentReasonDescription;
        private System.Windows.Forms.ColumnHeader colOtherPaymentPaymentDate;
        private System.Windows.Forms.ColumnHeader colOtherPaymentReferenceNumber;
        private System.Windows.Forms.ColumnHeader colOtherPaymentAmount;
        private System.Windows.Forms.GroupBox grpSettlement;
        public System.Windows.Forms.Button btnNew;
        public System.Windows.Forms.Button btnSettle;
        private System.Windows.Forms.GroupBox grbCheckCPOInfo;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboBank;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaturityDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCheckCPODate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCheckCPONo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSettlementDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboSettlementStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwPaymentRequests;
        private System.Windows.Forms.ColumnHeader colRequestId;
        private System.Windows.Forms.ColumnHeader colReqOrganizationName;
        private System.Windows.Forms.ColumnHeader colRequestDate;
        private System.Windows.Forms.ColumnHeader colReferenceNo;
        private System.Windows.Forms.ColumnHeader colModeOfPayment;
        private System.Windows.Forms.ColumnHeader colBankGuid;
        private System.Windows.Forms.ColumnHeader colBankBranchName;
        private System.Windows.Forms.ColumnHeader colCheckOrCPONumber;
        private System.Windows.Forms.ColumnHeader colCheckOrCPODate;
        private System.Windows.Forms.ColumnHeader colCheckMaturityDate;
        private System.Windows.Forms.ColumnHeader colSettled;
        private System.Windows.Forms.TextBox txtOrganizationName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderGuid;
    }
}