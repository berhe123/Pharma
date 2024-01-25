namespace Pharma
{
    partial class frmPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label1 = new System.Windows.Forms.Label();
            this.lvwPurchaseOrders = new System.Windows.Forms.ListView();
            this.colAutoID = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerProformaGuid = new System.Windows.Forms.ColumnHeader();
            this.colOrderNumber = new System.Windows.Forms.ColumnHeader();
            this.colOrderDate = new System.Windows.Forms.ColumnHeader();
            this.colTermsOfContract = new System.Windows.Forms.ColumnHeader();
            this.colCurrencyType = new System.Windows.Forms.ColumnHeader();
            this.colCurrency = new System.Windows.Forms.ColumnHeader();
            this.colFreightCharge = new System.Windows.Forms.ColumnHeader();
            this.colPlaceOfOrigin = new System.Windows.Forms.ColumnHeader();
            this.colPlaceOfDestination = new System.Windows.Forms.ColumnHeader();
            this.colOrderType = new System.Windows.Forms.ColumnHeader();
            this.colOrderTypeDescription = new System.Windows.Forms.ColumnHeader();
            this.colOrderStatus = new System.Windows.Forms.ColumnHeader();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.proformaToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.sbPurchaseOrders = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line3 = new System.Windows.Forms.Panel();
            this.tabDetail = new System.Windows.Forms.TabControl();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblTotalFOB = new System.Windows.Forms.Label();
            this.lblTotalCandFCurrency = new System.Windows.Forms.Label();
            this.txtTotalFOB = new System.Windows.Forms.TextBox();
            this.lblFreightChargeCurrency = new System.Windows.Forms.Label();
            this.lblFreight = new System.Windows.Forms.Label();
            this.lblTotalFOBCurrency = new System.Windows.Forms.Label();
            this.txtFreightCharge = new System.Windows.Forms.TextBox();
            this.lblTotalCandF = new System.Windows.Forms.Label();
            this.txtTotalCandF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCurrencyType = new System.Windows.Forms.ComboBox();
            this.gvwPurchaseOrderDetail = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseOrderGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gcboItem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSaveDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetDetailFromProforma = new System.Windows.Forms.ToolStripButton();
            this.cboTermsOfShipment = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearchProforma = new System.Windows.Forms.Button();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboTermsOfPayment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDispatch = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProformaNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lvwManufacturerProformaDetails = new System.Windows.Forms.ListView();
            this.colManufacturerProformaDetailsId = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerProformaDetailsManufacturerProformaGuid = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerProformaDetailsNotificationnumber = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerProformaDetailsItemGuid = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerProformaDetailsItemName = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerProformaDetailsQuantity = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerProformaDetailsPriceperunit = new System.Windows.Forms.ColumnHeader();
            this.colLineTotal = new System.Windows.Forms.ColumnHeader();
            this.txtTermsOfContractOrder = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpProforma = new System.Windows.Forms.GroupBox();
            this.txtProformaDate = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDestinationPlace = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOriginPlace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.cboOrderStatus = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReceivingReferenceNumber = new System.Windows.Forms.TextBox();
            this.grpFilter.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.proformaToolStrip.SuspendLayout();
            this.sbPurchaseOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.tabDetail.SuspendLayout();
            this.tabPageDetail.SuspendLayout();
            this.panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPurchaseOrderDetail)).BeginInit();
            this.orderDetailToolStrip.SuspendLayout();
            this.grpProforma.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
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
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Location = new System.Drawing.Point(9, 40);
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
            this.btnSearchManufacturerFilter.Location = new System.Drawing.Point(216, 8);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwPurchaseOrders
            // 
            this.lvwPurchaseOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAutoID,
            this.colManufacturerProformaGuid,
            this.colOrderNumber,
            this.colOrderDate,
            this.colTermsOfContract,
            this.colCurrencyType,
            this.colCurrency,
            this.colFreightCharge,
            this.colPlaceOfOrigin,
            this.colPlaceOfDestination,
            this.colOrderType,
            this.colOrderTypeDescription,
            this.colOrderStatus});
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
            // colCurrencyType
            // 
            this.colCurrencyType.Text = "Currency Type ID";
            this.colCurrencyType.Width = 0;
            // 
            // colCurrency
            // 
            this.colCurrency.Text = "Currency";
            this.colCurrency.Width = 0;
            // 
            // colFreightCharge
            // 
            this.colFreightCharge.Text = "Freight Charge";
            this.colFreightCharge.Width = 0;
            // 
            // colPlaceOfOrigin
            // 
            this.colPlaceOfOrigin.Text = "Origin";
            this.colPlaceOfOrigin.Width = 0;
            // 
            // colPlaceOfDestination
            // 
            this.colPlaceOfDestination.Text = "Destination";
            this.colPlaceOfDestination.Width = 0;
            // 
            // colOrderType
            // 
            this.colOrderType.Text = "Order Type";
            this.colOrderType.Width = 0;
            // 
            // colOrderTypeDescription
            // 
            this.colOrderTypeDescription.Text = "Order Type";
            this.colOrderTypeDescription.Width = 0;
            // 
            // colOrderStatus
            // 
            this.colOrderStatus.Text = "Order Status";
            this.colOrderStatus.Width = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(2, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1044, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "    Maintain Purchase Orders";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolbar.Controls.Add(this.proformaToolStrip);
            this.panelToolbar.Location = new System.Drawing.Point(313, 42);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(725, 28);
            this.panelToolbar.TabIndex = 106;
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
            this.toolStripSeparator2,
            this.btnClose});
            this.proformaToolStrip.Location = new System.Drawing.Point(0, 0);
            this.proformaToolStrip.Name = "proformaToolStrip";
            this.proformaToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.proformaToolStrip.Size = new System.Drawing.Size(725, 25);
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
            this.btnNew.ToolTipText = "Prepare the system to accept a new purchase order record";
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
            this.btnSave.ToolTipText = "Save the current purchase order record (i.e. newly created or edited)";
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
            this.btnDelete.ToolTipText = "Delete the currently selected purchase order record";
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
            this.btnPrintPreview.ToolTipText = "Preview the currently selected purchase order record for printing";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.btnClose.ToolTipText = "Close the Purchase Order dialog";
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
            this.sbPurchaseOrders.Size = new System.Drawing.Size(1274, 22);
            this.sbPurchaseOrders.TabIndex = 62;
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
            this.line3.Size = new System.Drawing.Size(1044, 1);
            this.line3.TabIndex = 1;
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.tabPageDetail);
            this.tabDetail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDetail.Location = new System.Drawing.Point(314, 376);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.SelectedIndex = 0;
            this.tabDetail.Size = new System.Drawing.Size(896, 308);
            this.tabDetail.TabIndex = 47;
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.panelTotal);
            this.tabPageDetail.Controls.Add(this.label4);
            this.tabPageDetail.Controls.Add(this.cboCurrencyType);
            this.tabPageDetail.Controls.Add(this.gvwPurchaseOrderDetail);
            this.tabPageDetail.Controls.Add(this.orderDetailToolStrip);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 25);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(888, 279);
            this.tabPageDetail.TabIndex = 0;
            this.tabPageDetail.Text = "Order Details";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // panelTotal
            // 
            this.panelTotal.Controls.Add(this.lblTotalFOB);
            this.panelTotal.Controls.Add(this.lblTotalCandFCurrency);
            this.panelTotal.Controls.Add(this.txtTotalFOB);
            this.panelTotal.Controls.Add(this.lblFreightChargeCurrency);
            this.panelTotal.Controls.Add(this.lblFreight);
            this.panelTotal.Controls.Add(this.lblTotalFOBCurrency);
            this.panelTotal.Controls.Add(this.txtFreightCharge);
            this.panelTotal.Controls.Add(this.lblTotalCandF);
            this.panelTotal.Controls.Add(this.txtTotalCandF);
            this.panelTotal.Location = new System.Drawing.Point(363, 199);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(520, 78);
            this.panelTotal.TabIndex = 52;
            // 
            // lblTotalFOB
            // 
            this.lblTotalFOB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFOB.Location = new System.Drawing.Point(71, 6);
            this.lblTotalFOB.Name = "lblTotalFOB";
            this.lblTotalFOB.Size = new System.Drawing.Size(203, 16);
            this.lblTotalFOB.TabIndex = 53;
            this.lblTotalFOB.Text = "Total F.O.B.";
            this.lblTotalFOB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalCandFCurrency
            // 
            this.lblTotalCandFCurrency.AutoSize = true;
            this.lblTotalCandFCurrency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCandFCurrency.Location = new System.Drawing.Point(280, 55);
            this.lblTotalCandFCurrency.Name = "lblTotalCandFCurrency";
            this.lblTotalCandFCurrency.Size = new System.Drawing.Size(69, 16);
            this.lblTotalCandFCurrency.TabIndex = 60;
            this.lblTotalCandFCurrency.Text = "(Currency)";
            // 
            // txtTotalFOB
            // 
            this.txtTotalFOB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFOB.Location = new System.Drawing.Point(360, 2);
            this.txtTotalFOB.Name = "txtTotalFOB";
            this.txtTotalFOB.ReadOnly = true;
            this.txtTotalFOB.Size = new System.Drawing.Size(144, 23);
            this.txtTotalFOB.TabIndex = 55;
            this.txtTotalFOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFreightChargeCurrency
            // 
            this.lblFreightChargeCurrency.AutoSize = true;
            this.lblFreightChargeCurrency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreightChargeCurrency.Location = new System.Drawing.Point(280, 30);
            this.lblFreightChargeCurrency.Name = "lblFreightChargeCurrency";
            this.lblFreightChargeCurrency.Size = new System.Drawing.Size(69, 16);
            this.lblFreightChargeCurrency.TabIndex = 57;
            this.lblFreightChargeCurrency.Text = "(Currency)";
            // 
            // lblFreight
            // 
            this.lblFreight.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreight.Location = new System.Drawing.Point(71, 31);
            this.lblFreight.Name = "lblFreight";
            this.lblFreight.Size = new System.Drawing.Size(203, 16);
            this.lblFreight.TabIndex = 56;
            this.lblFreight.Text = "Freight Charge";
            this.lblFreight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalFOBCurrency
            // 
            this.lblTotalFOBCurrency.AutoSize = true;
            this.lblTotalFOBCurrency.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFOBCurrency.Location = new System.Drawing.Point(280, 5);
            this.lblTotalFOBCurrency.Name = "lblTotalFOBCurrency";
            this.lblTotalFOBCurrency.Size = new System.Drawing.Size(69, 16);
            this.lblTotalFOBCurrency.TabIndex = 54;
            this.lblTotalFOBCurrency.Text = "(Currency)";
            // 
            // txtFreightCharge
            // 
            this.txtFreightCharge.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreightCharge.Location = new System.Drawing.Point(360, 27);
            this.txtFreightCharge.Name = "txtFreightCharge";
            this.txtFreightCharge.ReadOnly = true;
            this.txtFreightCharge.Size = new System.Drawing.Size(144, 23);
            this.txtFreightCharge.TabIndex = 58;
            this.txtFreightCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalCandF
            // 
            this.lblTotalCandF.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCandF.Location = new System.Drawing.Point(71, 56);
            this.lblTotalCandF.Name = "lblTotalCandF";
            this.lblTotalCandF.Size = new System.Drawing.Size(203, 16);
            this.lblTotalCandF.TabIndex = 59;
            this.lblTotalCandF.Text = "Total C + F";
            this.lblTotalCandF.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTotalCandF
            // 
            this.txtTotalCandF.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCandF.Location = new System.Drawing.Point(360, 52);
            this.txtTotalCandF.Name = "txtTotalCandF";
            this.txtTotalCandF.ReadOnly = true;
            this.txtTotalCandF.Size = new System.Drawing.Size(144, 23);
            this.txtTotalCandF.TabIndex = 61;
            this.txtTotalCandF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Currency";
            // 
            // cboCurrencyType
            // 
            this.cboCurrencyType.AllowDrop = true;
            this.cboCurrencyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrencyType.Enabled = false;
            this.cboCurrencyType.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboCurrencyType.FormattingEnabled = true;
            this.cboCurrencyType.Location = new System.Drawing.Point(724, 2);
            this.cboCurrencyType.Name = "cboCurrencyType";
            this.cboCurrencyType.Size = new System.Drawing.Size(157, 24);
            this.cboCurrencyType.TabIndex = 50;
            this.cboCurrencyType.SelectedIndexChanged += new System.EventHandler(this.cboCurrencyType_SelectedIndexChanged);
            // 
            // gvwPurchaseOrderDetail
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwPurchaseOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvwPurchaseOrderDetail.BackgroundColor = System.Drawing.Color.DimGray;
            this.gvwPurchaseOrderDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvwPurchaseOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvwPurchaseOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwPurchaseOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PurchaseOrderGuid,
            this.ItemGuid,
            this.gcboItem,
            this.Quantity,
            this.PricePerUnit,
            this.LineTotal});
            this.gvwPurchaseOrderDetail.Location = new System.Drawing.Point(3, 29);
            this.gvwPurchaseOrderDetail.Name = "gvwPurchaseOrderDetail";
            this.gvwPurchaseOrderDetail.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvwPurchaseOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvwPurchaseOrderDetail.Size = new System.Drawing.Size(880, 166);
            this.gvwPurchaseOrderDetail.TabIndex = 51;
            this.gvwPurchaseOrderDetail.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvwPurchaseOrderDetail_RowLeave);
            this.gvwPurchaseOrderDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvwPurchaseOrderDetail_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Visible = false;
            // 
            // PurchaseOrderGuid
            // 
            this.PurchaseOrderGuid.HeaderText = "Purchase Order Guid";
            this.PurchaseOrderGuid.Name = "PurchaseOrderGuid";
            this.PurchaseOrderGuid.ReadOnly = true;
            this.PurchaseOrderGuid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PurchaseOrderGuid.Visible = false;
            // 
            // ItemGuid
            // 
            this.ItemGuid.HeaderText = "ItemGuid";
            this.ItemGuid.Name = "ItemGuid";
            this.ItemGuid.ReadOnly = true;
            this.ItemGuid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ItemGuid.Visible = false;
            // 
            // gcboItem
            // 
            this.gcboItem.FillWeight = 37.47122F;
            this.gcboItem.HeaderText = "Item";
            this.gcboItem.Name = "gcboItem";
            this.gcboItem.ReadOnly = true;
            this.gcboItem.Width = 320;
            // 
            // Quantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quantity.FillWeight = 31.7089F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Quantity.Width = 150;
            // 
            // PricePerUnit
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.PricePerUnit.DefaultCellStyle = dataGridViewCellStyle4;
            this.PricePerUnit.FillWeight = 37.47122F;
            this.PricePerUnit.HeaderText = "Price per Unit";
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            this.PricePerUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PricePerUnit.Width = 150;
            // 
            // LineTotal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.LineTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.LineTotal.FillWeight = 44.39246F;
            this.LineTotal.HeaderText = "Total";
            this.LineTotal.Name = "LineTotal";
            this.LineTotal.ReadOnly = true;
            this.LineTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LineTotal.Width = 180;
            // 
            // orderDetailToolStrip
            // 
            this.orderDetailToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orderDetailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnSaveDetail,
            this.btnDeleteDetail,
            this.toolStripSeparator1,
            this.btnGetDetailFromProforma});
            this.orderDetailToolStrip.Location = new System.Drawing.Point(3, 3);
            this.orderDetailToolStrip.Name = "orderDetailToolStrip";
            this.orderDetailToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.orderDetailToolStrip.Size = new System.Drawing.Size(882, 25);
            this.orderDetailToolStrip.TabIndex = 48;
            this.orderDetailToolStrip.Text = "toolStrip2";
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
            this.btnSaveDetail.ToolTipText = "Save the current order detail record (i.e. newly created or edited)";
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
            this.btnDeleteDetail.ToolTipText = "Delete the currently selected order detail record";
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGetDetailFromProforma
            // 
            this.btnGetDetailFromProforma.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetDetailFromProforma.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetDetailFromProforma.Image = global::Pharma.Properties.Resources.refresh;
            this.btnGetDetailFromProforma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetDetailFromProforma.Name = "btnGetDetailFromProforma";
            this.btnGetDetailFromProforma.Size = new System.Drawing.Size(174, 22);
            this.btnGetDetailFromProforma.Text = "Get Detail From Proforma";
            this.btnGetDetailFromProforma.ToolTipText = "Fill the order details list by importing data from the details of the proforma se" +
                "lected above";
            this.btnGetDetailFromProforma.Click += new System.EventHandler(this.btnGetDetailFromProforma_Click);
            // 
            // cboTermsOfShipment
            // 
            this.cboTermsOfShipment.AllowDrop = true;
            this.cboTermsOfShipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTermsOfShipment.Enabled = false;
            this.cboTermsOfShipment.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboTermsOfShipment.FormattingEnabled = true;
            this.cboTermsOfShipment.Location = new System.Drawing.Point(366, 63);
            this.cboTermsOfShipment.Name = "cboTermsOfShipment";
            this.cboTermsOfShipment.Size = new System.Drawing.Size(166, 24);
            this.cboTermsOfShipment.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(366, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Terms of Shipment";
            // 
            // btnSearchProforma
            // 
            this.btnSearchProforma.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchProforma.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProforma.Image")));
            this.btnSearchProforma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchProforma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchProforma.Location = new System.Drawing.Point(150, 21);
            this.btnSearchProforma.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchProforma.Name = "btnSearchProforma";
            this.btnSearchProforma.Size = new System.Drawing.Size(30, 28);
            this.btnSearchProforma.TabIndex = 18;
            this.btnSearchProforma.TabStop = false;
            this.btnSearchProforma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchProforma.UseVisualStyleBackColor = true;
            this.btnSearchProforma.Click += new System.EventHandler(this.btnSearchProforma_Click);
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.BackColor = System.Drawing.SystemColors.Window;
            this.txtManufacturer.Enabled = false;
            this.txtManufacturer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturer.Location = new System.Drawing.Point(366, 24);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(329, 23);
            this.txtManufacturer.TabIndex = 22;
            this.txtManufacturer.TextChanged += new System.EventHandler(this.txtManufacturer_TextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(366, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(238, 16);
            this.label13.TabIndex = 21;
            this.label13.Text = "Manufacturer";
            // 
            // cboTermsOfPayment
            // 
            this.cboTermsOfPayment.AllowDrop = true;
            this.cboTermsOfPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTermsOfPayment.Enabled = false;
            this.cboTermsOfPayment.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboTermsOfPayment.FormattingEnabled = true;
            this.cboTermsOfPayment.Location = new System.Drawing.Point(190, 63);
            this.cboTermsOfPayment.Name = "cboTermsOfPayment";
            this.cboTermsOfPayment.Size = new System.Drawing.Size(166, 24);
            this.cboTermsOfPayment.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(190, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Terms of Payment";
            // 
            // cboDispatch
            // 
            this.cboDispatch.AllowDrop = true;
            this.cboDispatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDispatch.Enabled = false;
            this.cboDispatch.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboDispatch.FormattingEnabled = true;
            this.cboDispatch.Location = new System.Drawing.Point(14, 63);
            this.cboDispatch.Name = "cboDispatch";
            this.cboDispatch.Size = new System.Drawing.Size(134, 24);
            this.cboDispatch.TabIndex = 26;
            this.cboDispatch.SelectedIndexChanged += new System.EventHandler(this.cboDispatch_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Dispatch";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(190, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Proforma Date";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProformaNumber
            // 
            this.txtProformaNumber.BackColor = System.Drawing.Color.Lavender;
            this.txtProformaNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProformaNumber.Location = new System.Drawing.Point(14, 24);
            this.txtProformaNumber.Name = "txtProformaNumber";
            this.txtProformaNumber.ReadOnly = true;
            this.txtProformaNumber.Size = new System.Drawing.Size(134, 23);
            this.txtProformaNumber.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "Proforma Number";
            // 
            // lvwManufacturerProformaDetails
            // 
            this.lvwManufacturerProformaDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colManufacturerProformaDetailsId,
            this.colManufacturerProformaDetailsManufacturerProformaGuid,
            this.colManufacturerProformaDetailsNotificationnumber,
            this.colManufacturerProformaDetailsItemGuid,
            this.colManufacturerProformaDetailsItemName,
            this.colManufacturerProformaDetailsQuantity,
            this.colManufacturerProformaDetailsPriceperunit,
            this.colLineTotal});
            this.lvwManufacturerProformaDetails.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwManufacturerProformaDetails.FullRowSelect = true;
            this.lvwManufacturerProformaDetails.GridLines = true;
            this.lvwManufacturerProformaDetails.Location = new System.Drawing.Point(14, 90);
            this.lvwManufacturerProformaDetails.MultiSelect = false;
            this.lvwManufacturerProformaDetails.Name = "lvwManufacturerProformaDetails";
            this.lvwManufacturerProformaDetails.Size = new System.Drawing.Size(664, 90);
            this.lvwManufacturerProformaDetails.TabIndex = 35;
            this.lvwManufacturerProformaDetails.UseCompatibleStateImageBehavior = false;
            this.lvwManufacturerProformaDetails.View = System.Windows.Forms.View.Details;
            // 
            // colManufacturerProformaDetailsId
            // 
            this.colManufacturerProformaDetailsId.Text = "ID";
            this.colManufacturerProformaDetailsId.Width = 0;
            // 
            // colManufacturerProformaDetailsManufacturerProformaGuid
            // 
            this.colManufacturerProformaDetailsManufacturerProformaGuid.Text = "Manufacturer Proforma Guid";
            this.colManufacturerProformaDetailsManufacturerProformaGuid.Width = 0;
            // 
            // colManufacturerProformaDetailsNotificationnumber
            // 
            this.colManufacturerProformaDetailsNotificationnumber.Text = "Notification #";
            this.colManufacturerProformaDetailsNotificationnumber.Width = 100;
            // 
            // colManufacturerProformaDetailsItemGuid
            // 
            this.colManufacturerProformaDetailsItemGuid.Text = "Item Guid";
            this.colManufacturerProformaDetailsItemGuid.Width = 0;
            // 
            // colManufacturerProformaDetailsItemName
            // 
            this.colManufacturerProformaDetailsItemName.Text = "Item";
            this.colManufacturerProformaDetailsItemName.Width = 165;
            // 
            // colManufacturerProformaDetailsQuantity
            // 
            this.colManufacturerProformaDetailsQuantity.Text = "Quantity";
            this.colManufacturerProformaDetailsQuantity.Width = 80;
            // 
            // colManufacturerProformaDetailsPriceperunit
            // 
            this.colManufacturerProformaDetailsPriceperunit.Text = "Price per Unit";
            this.colManufacturerProformaDetailsPriceperunit.Width = 100;
            // 
            // colLineTotal
            // 
            this.colLineTotal.Text = "Total";
            this.colLineTotal.Width = 160;
            // 
            // txtTermsOfContractOrder
            // 
            this.txtTermsOfContractOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTermsOfContractOrder.Location = new System.Drawing.Point(504, 284);
            this.txtTermsOfContractOrder.Multiline = true;
            this.txtTermsOfContractOrder.Name = "txtTermsOfContractOrder";
            this.txtTermsOfContractOrder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTermsOfContractOrder.Size = new System.Drawing.Size(509, 78);
            this.txtTermsOfContractOrder.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(190, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 16);
            this.label12.TabIndex = 41;
            this.label12.Text = "Conditions and Terms of Contract";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Order Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(12, 26);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(144, 23);
            this.txtOrderNumber.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Order Number";
            // 
            // grpProforma
            // 
            this.grpProforma.Controls.Add(this.txtProformaDate);
            this.grpProforma.Controls.Add(this.cboType);
            this.grpProforma.Controls.Add(this.label14);
            this.grpProforma.Controls.Add(this.txtDestinationPlace);
            this.grpProforma.Controls.Add(this.label17);
            this.grpProforma.Controls.Add(this.txtOriginPlace);
            this.grpProforma.Controls.Add(this.label3);
            this.grpProforma.Controls.Add(this.cboTermsOfShipment);
            this.grpProforma.Controls.Add(this.lvwManufacturerProformaDetails);
            this.grpProforma.Controls.Add(this.label11);
            this.grpProforma.Controls.Add(this.label16);
            this.grpProforma.Controls.Add(this.btnSearchProforma);
            this.grpProforma.Controls.Add(this.txtProformaNumber);
            this.grpProforma.Controls.Add(this.txtManufacturer);
            this.grpProforma.Controls.Add(this.label15);
            this.grpProforma.Controls.Add(this.label13);
            this.grpProforma.Controls.Add(this.cboTermsOfPayment);
            this.grpProforma.Controls.Add(this.label7);
            this.grpProforma.Controls.Add(this.cboDispatch);
            this.grpProforma.Controls.Add(this.label5);
            this.grpProforma.Location = new System.Drawing.Point(314, 71);
            this.grpProforma.Name = "grpProforma";
            this.grpProforma.Size = new System.Drawing.Size(910, 185);
            this.grpProforma.TabIndex = 15;
            this.grpProforma.TabStop = false;
            // 
            // txtProformaDate
            // 
            this.txtProformaDate.Enabled = false;
            this.txtProformaDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProformaDate.Location = new System.Drawing.Point(190, 24);
            this.txtProformaDate.Name = "txtProformaDate";
            this.txtProformaDate.Size = new System.Drawing.Size(166, 23);
            this.txtProformaDate.TabIndex = 20;
            // 
            // cboType
            // 
            this.cboType.AllowDrop = true;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Enabled = false;
            this.cboType.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(706, 23);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(172, 24);
            this.cboType.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(706, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(172, 16);
            this.label14.TabIndex = 23;
            this.label14.Text = "Proforma Type";
            // 
            // txtDestinationPlace
            // 
            this.txtDestinationPlace.Enabled = false;
            this.txtDestinationPlace.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestinationPlace.Location = new System.Drawing.Point(706, 66);
            this.txtDestinationPlace.Name = "txtDestinationPlace";
            this.txtDestinationPlace.Size = new System.Drawing.Size(172, 23);
            this.txtDestinationPlace.TabIndex = 34;
            this.txtDestinationPlace.TextChanged += new System.EventHandler(this.txtDestinationPlace_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(706, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "Destination";
            // 
            // txtOriginPlace
            // 
            this.txtOriginPlace.Enabled = false;
            this.txtOriginPlace.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginPlace.Location = new System.Drawing.Point(550, 66);
            this.txtOriginPlace.Name = "txtOriginPlace";
            this.txtOriginPlace.Size = new System.Drawing.Size(144, 23);
            this.txtOriginPlace.TabIndex = 32;
            this.txtOriginPlace.TextChanged += new System.EventHandler(this.txtOriginPlace_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Origin";
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.cboOrderStatus);
            this.grpOrder.Controls.Add(this.label19);
            this.grpOrder.Controls.Add(this.txtOrderDate);
            this.grpOrder.Controls.Add(this.label10);
            this.grpOrder.Controls.Add(this.txtReceivingReferenceNumber);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label12);
            this.grpOrder.Controls.Add(this.txtOrderNumber);
            this.grpOrder.Controls.Add(this.label8);
            this.grpOrder.Location = new System.Drawing.Point(314, 258);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(948, 112);
            this.grpOrder.TabIndex = 36;
            this.grpOrder.TabStop = false;
            // 
            // cboOrderStatus
            // 
            this.cboOrderStatus.AllowDrop = true;
            this.cboOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrderStatus.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboOrderStatus.FormattingEnabled = true;
            this.cboOrderStatus.Location = new System.Drawing.Point(706, 26);
            this.cboOrderStatus.Name = "cboOrderStatus";
            this.cboOrderStatus.Size = new System.Drawing.Size(234, 24);
            this.cboOrderStatus.TabIndex = 44;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(706, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(172, 16);
            this.label19.TabIndex = 43;
            this.label19.Text = "Order Status";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(12, 81);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(144, 23);
            this.txtOrderDate.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(706, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Receiving Reference Number";
            this.label10.Visible = false;
            // 
            // txtReceivingReferenceNumber
            // 
            this.txtReceivingReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivingReferenceNumber.ForeColor = System.Drawing.Color.Red;
            this.txtReceivingReferenceNumber.Location = new System.Drawing.Point(706, 82);
            this.txtReceivingReferenceNumber.Name = "txtReceivingReferenceNumber";
            this.txtReceivingReferenceNumber.ReadOnly = true;
            this.txtReceivingReferenceNumber.Size = new System.Drawing.Size(172, 23);
            this.txtReceivingReferenceNumber.TabIndex = 46;
            this.txtReceivingReferenceNumber.Visible = false;
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1274, 710);
            this.Controls.Add(this.txtTermsOfContractOrder);
            this.Controls.Add(this.grpProforma);
            this.Controls.Add(this.tabDetail);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.sbPurchaseOrders);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.lvwPurchaseOrders);
            this.Name = "frmPurchaseOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.Resize += new System.EventHandler(this.frmPurchaseOrder_Resize);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.proformaToolStrip.ResumeLayout(false);
            this.proformaToolStrip.PerformLayout();
            this.sbPurchaseOrders.ResumeLayout(false);
            this.sbPurchaseOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.tabDetail.ResumeLayout(false);
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwPurchaseOrderDetail)).EndInit();
            this.orderDetailToolStrip.ResumeLayout(false);
            this.orderDetailToolStrip.PerformLayout();
            this.grpProforma.ResumeLayout(false);
            this.grpProforma.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.ToolStrip proformaToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ListView lvwPurchaseOrders;
        private System.Windows.Forms.ColumnHeader colAutoID;
        private System.Windows.Forms.ColumnHeader colOrderNumber;
        private System.Windows.Forms.ColumnHeader colOrderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearchManufacturerFilter;
        private System.Windows.Forms.TextBox txtManufacturerFilter;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ColumnHeader colTermsOfContract;
        private System.Windows.Forms.StatusStrip sbPurchaseOrders;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaGuid;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.TabControl tabDetail;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.ToolStrip orderDetailToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton btnSaveDetail;
        private System.Windows.Forms.ToolStripButton btnDeleteDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGetDetailFromProforma;
        private System.Windows.Forms.DataGridView gvwPurchaseOrderDetail;
        public System.Windows.Forms.ComboBox cboTermsOfShipment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearchProforma;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox cboTermsOfPayment;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cboDispatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtProformaNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView lvwManufacturerProformaDetails;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaDetailsId;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaDetailsManufacturerProformaGuid;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaDetailsNotificationnumber;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaDetailsItemGuid;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaDetailsItemName;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaDetailsQuantity;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaDetailsPriceperunit;
        private System.Windows.Forms.TextBox txtTermsOfContractOrder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cboCurrencyType;
        private System.Windows.Forms.ColumnHeader colLineTotal;
        private System.Windows.Forms.GroupBox grpProforma;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPrintPreview;
        private System.Windows.Forms.ColumnHeader colCurrencyType;
        private System.Windows.Forms.ColumnHeader colCurrency;
        private System.Windows.Forms.ColumnHeader colFreightCharge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReceivingReferenceNumber;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.TextBox txtDestinationPlace;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtOriginPlace;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader colPlaceOfOrigin;
        private System.Windows.Forms.ColumnHeader colPlaceOfDestination;
        private System.Windows.Forms.ColumnHeader colOrderType;
        private System.Windows.Forms.ColumnHeader colOrderTypeDescription;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblTotalFOB;
        private System.Windows.Forms.Label lblTotalCandFCurrency;
        private System.Windows.Forms.TextBox txtTotalFOB;
        private System.Windows.Forms.Label lblFreightChargeCurrency;
        private System.Windows.Forms.Label lblFreight;
        private System.Windows.Forms.Label lblTotalFOBCurrency;
        private System.Windows.Forms.TextBox txtFreightCharge;
        private System.Windows.Forms.Label lblTotalCandF;
        private System.Windows.Forms.TextBox txtTotalCandF;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderDateTo;
        private System.Windows.Forms.TextBox txtOrderDateFrom;
        private System.Windows.Forms.TextBox txtProformaDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Button btnSearchManufacturerFilter1;
        public System.Windows.Forms.ComboBox cboOrderStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ColumnHeader colOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseOrderGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemGuid;
        private System.Windows.Forms.DataGridViewComboBoxColumn gcboItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineTotal;
    }
}