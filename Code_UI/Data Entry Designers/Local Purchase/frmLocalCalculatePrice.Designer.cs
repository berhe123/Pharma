﻿namespace Pharma
{
    partial class frmLocalCalculatePrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalCalculatePrice));
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.lblTotalFOB = new System.Windows.Forms.Label();
            this.txtTotalFOB = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.lvwPurchaseOrderDetails = new System.Windows.Forms.ListView();
            this.colPurchaseOrderDetailsId = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsPurchaseOrderGuid = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsItemGuid = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsItemName = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsQuantity = new System.Windows.Forms.ColumnHeader();
            this.colPurchaseOrderDetailsPriceperunit = new System.Windows.Forms.ColumnHeader();
            this.colLineTotal = new System.Windows.Forms.ColumnHeader();
            this.tabOtherPayments = new System.Windows.Forms.TabPage();
            this.txtTotalOther = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
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
            this.btnSearchPurchaseOrder = new System.Windows.Forms.Button();
            this.tabControlPriceAnalysis = new System.Windows.Forms.TabControl();
            this.tabPagePriceAnalysis = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPriceAnalysisTotalCostInBirrTotal = new System.Windows.Forms.TextBox();
            this.txtPriceAnalysisUnitCostInBirrTotal = new System.Windows.Forms.TextBox();
            this.lblTotalAmountIn = new System.Windows.Forms.Label();
            this.txtPriceAnalysisBatchTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
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
            this.colExchangeRate = new System.Windows.Forms.ColumnHeader();
            this.colProfitMargin = new System.Windows.Forms.ColumnHeader();
            this.label32 = new System.Windows.Forms.Label();
            this.txtProfitMargin = new System.Windows.Forms.TextBox();
            this.btnSaveActualPriceForBatch = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.txtActualSellingPrice = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtSuggestedSellingPrice = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPriceAnalysisUnitPriceInBirr = new System.Windows.Forms.TextBox();
            this.txtPriceAnalysisUnitOtherInBirr = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBatchNumber = new System.Windows.Forms.Label();
            this.txtPriceAnalysisTotalPriceInBirr = new System.Windows.Forms.TextBox();
            this.txtPriceAnalysisTotalOtherInBirr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelToolbar = new System.Windows.Forms.Panel();
            this.proformaToolStrip.SuspendLayout();
            this.sbPurchaseOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.PaymentTabs.SuspendLayout();
            this.tabPurchaseOrderDetails.SuspendLayout();
            this.tabOtherPayments.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.tabControlPriceAnalysis.SuspendLayout();
            this.tabPagePriceAnalysis.SuspendLayout();
            this.panelToolbar.SuspendLayout();
            this.SuspendLayout();
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
            this.lblTitle.Text = "    Calculate Price for Items in the Local Purchase Order";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.proformaToolStrip.Size = new System.Drawing.Size(781, 25);
            this.proformaToolStrip.TabIndex = 2;
            this.proformaToolStrip.Text = "toolStrip1";
            this.proformaToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.proformaToolStrip_ItemClicked);
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
            this.btnClose.ToolTipText = "Close the Calculate Price dialog";
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
            this.sbPurchaseOrders.Size = new System.Drawing.Size(1173, 22);
            this.sbPurchaseOrders.TabIndex = 77;
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
            this.label2.Location = new System.Drawing.Point(6, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Order Number";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Enabled = false;
            this.txtOrderNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNumber.Location = new System.Drawing.Point(6, 28);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(98, 23);
            this.txtOrderNumber.TabIndex = 5;
            this.txtOrderNumber.TextChanged += new System.EventHandler(this.txtOrderNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(156, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Order Date";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaymentTabs
            // 
            this.PaymentTabs.Controls.Add(this.tabPurchaseOrderDetails);
            this.PaymentTabs.Controls.Add(this.tabOtherPayments);
            this.PaymentTabs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTabs.Location = new System.Drawing.Point(6, 123);
            this.PaymentTabs.Name = "PaymentTabs";
            this.PaymentTabs.SelectedIndex = 0;
            this.PaymentTabs.Size = new System.Drawing.Size(781, 204);
            this.PaymentTabs.TabIndex = 14;
            // 
            // tabPurchaseOrderDetails
            // 
            this.tabPurchaseOrderDetails.Controls.Add(this.lblTotalFOB);
            this.tabPurchaseOrderDetails.Controls.Add(this.txtTotalFOB);
            this.tabPurchaseOrderDetails.Controls.Add(this.label25);
            this.tabPurchaseOrderDetails.Controls.Add(this.lvwPurchaseOrderDetails);
            this.tabPurchaseOrderDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPurchaseOrderDetails.Name = "tabPurchaseOrderDetails";
            this.tabPurchaseOrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPurchaseOrderDetails.Size = new System.Drawing.Size(773, 175);
            this.tabPurchaseOrderDetails.TabIndex = 3;
            this.tabPurchaseOrderDetails.Text = "Purchase Order Details ";
            this.tabPurchaseOrderDetails.UseVisualStyleBackColor = true;
            // 
            // lblTotalFOB
            // 
            this.lblTotalFOB.AutoSize = true;
            this.lblTotalFOB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFOB.Location = new System.Drawing.Point(509, 145);
            this.lblTotalFOB.Name = "lblTotalFOB";
            this.lblTotalFOB.Size = new System.Drawing.Size(38, 16);
            this.lblTotalFOB.TabIndex = 17;
            this.lblTotalFOB.Text = "(Birr)";
            // 
            // txtTotalFOB
            // 
            this.txtTotalFOB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFOB.Location = new System.Drawing.Point(554, 142);
            this.txtTotalFOB.Name = "txtTotalFOB";
            this.txtTotalFOB.ReadOnly = true;
            this.txtTotalFOB.Size = new System.Drawing.Size(144, 23);
            this.txtTotalFOB.TabIndex = 18;
            this.txtTotalFOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(466, 145);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 16);
            this.label25.TabIndex = 16;
            this.label25.Text = "Total";
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
            this.lvwPurchaseOrderDetails.Size = new System.Drawing.Size(770, 133);
            this.lvwPurchaseOrderDetails.TabIndex = 15;
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
            this.colPurchaseOrderDetailsPriceperunit.Width = 120;
            // 
            // colLineTotal
            // 
            this.colLineTotal.Text = "Total";
            this.colLineTotal.Width = 150;
            // 
            // tabOtherPayments
            // 
            this.tabOtherPayments.Controls.Add(this.txtTotalOther);
            this.tabOtherPayments.Controls.Add(this.label29);
            this.tabOtherPayments.Controls.Add(this.lvwOtherPayments);
            this.tabOtherPayments.Location = new System.Drawing.Point(4, 25);
            this.tabOtherPayments.Name = "tabOtherPayments";
            this.tabOtherPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabOtherPayments.Size = new System.Drawing.Size(711, 175);
            this.tabOtherPayments.TabIndex = 2;
            this.tabOtherPayments.Text = "Local Purchase Payments";
            this.tabOtherPayments.UseVisualStyleBackColor = true;
            // 
            // txtTotalOther
            // 
            this.txtTotalOther.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOther.Location = new System.Drawing.Point(554, 149);
            this.txtTotalOther.Name = "txtTotalOther";
            this.txtTotalOther.ReadOnly = true;
            this.txtTotalOther.Size = new System.Drawing.Size(144, 23);
            this.txtTotalOther.TabIndex = 33;
            this.txtTotalOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(473, 152);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 16);
            this.label29.TabIndex = 32;
            this.label29.Text = "Total:";
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
            this.lvwOtherPayments.Size = new System.Drawing.Size(696, 146);
            this.lvwOtherPayments.TabIndex = 31;
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
            this.grpOrder.Controls.Add(this.btnSearchPurchaseOrder);
            this.grpOrder.Controls.Add(this.label8);
            this.grpOrder.Controls.Add(this.txtOrderNumber);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Location = new System.Drawing.Point(6, 65);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(781, 55);
            this.grpOrder.TabIndex = 3;
            this.grpOrder.TabStop = false;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Enabled = false;
            this.txtOrderDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDate.Location = new System.Drawing.Point(156, 28);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(144, 23);
            this.txtOrderDate.TabIndex = 8;
            this.txtOrderDate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearchPurchaseOrder
            // 
            this.btnSearchPurchaseOrder.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchPurchaseOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPurchaseOrder.Image")));
            this.btnSearchPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPurchaseOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchPurchaseOrder.Location = new System.Drawing.Point(108, 25);
            this.btnSearchPurchaseOrder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchPurchaseOrder.Name = "btnSearchPurchaseOrder";
            this.btnSearchPurchaseOrder.Size = new System.Drawing.Size(30, 28);
            this.btnSearchPurchaseOrder.TabIndex = 6;
            this.btnSearchPurchaseOrder.TabStop = false;
            this.btnSearchPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnSearchPurchaseOrder.Click += new System.EventHandler(this.btnSearchPurchaseOrder_Click);
            // 
            // tabControlPriceAnalysis
            // 
            this.tabControlPriceAnalysis.Controls.Add(this.tabPagePriceAnalysis);
            this.tabControlPriceAnalysis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPriceAnalysis.Location = new System.Drawing.Point(6, 331);
            this.tabControlPriceAnalysis.Name = "tabControlPriceAnalysis";
            this.tabControlPriceAnalysis.SelectedIndex = 0;
            this.tabControlPriceAnalysis.Size = new System.Drawing.Size(1160, 353);
            this.tabControlPriceAnalysis.TabIndex = 34;
            // 
            // tabPagePriceAnalysis
            // 
            this.tabPagePriceAnalysis.Controls.Add(this.panel4);
            this.tabPagePriceAnalysis.Controls.Add(this.panel3);
            this.tabPagePriceAnalysis.Controls.Add(this.panel2);
            this.tabPagePriceAnalysis.Controls.Add(this.label9);
            this.tabPagePriceAnalysis.Controls.Add(this.txtPriceAnalysisTotalCostInBirrTotal);
            this.tabPagePriceAnalysis.Controls.Add(this.txtPriceAnalysisUnitCostInBirrTotal);
            this.tabPagePriceAnalysis.Controls.Add(this.lblTotalAmountIn);
            this.tabPagePriceAnalysis.Controls.Add(this.txtPriceAnalysisBatchTotalPrice);
            this.tabPagePriceAnalysis.Controls.Add(this.btnCalculatePrice);
            this.tabPagePriceAnalysis.Controls.Add(this.lvwBatchs);
            this.tabPagePriceAnalysis.Controls.Add(this.label32);
            this.tabPagePriceAnalysis.Controls.Add(this.txtProfitMargin);
            this.tabPagePriceAnalysis.Controls.Add(this.btnSaveActualPriceForBatch);
            this.tabPagePriceAnalysis.Controls.Add(this.label31);
            this.tabPagePriceAnalysis.Controls.Add(this.txtActualSellingPrice);
            this.tabPagePriceAnalysis.Controls.Add(this.label30);
            this.tabPagePriceAnalysis.Controls.Add(this.txtSuggestedSellingPrice);
            this.tabPagePriceAnalysis.Controls.Add(this.label16);
            this.tabPagePriceAnalysis.Controls.Add(this.txtPriceAnalysisUnitPriceInBirr);
            this.tabPagePriceAnalysis.Controls.Add(this.txtPriceAnalysisUnitOtherInBirr);
            this.tabPagePriceAnalysis.Controls.Add(this.label19);
            this.tabPagePriceAnalysis.Controls.Add(this.lblBatchNumber);
            this.tabPagePriceAnalysis.Controls.Add(this.txtPriceAnalysisTotalPriceInBirr);
            this.tabPagePriceAnalysis.Controls.Add(this.txtPriceAnalysisTotalOtherInBirr);
            this.tabPagePriceAnalysis.Controls.Add(this.label10);
            this.tabPagePriceAnalysis.Controls.Add(this.txtItem);
            this.tabPagePriceAnalysis.Controls.Add(this.txtBatchNumber);
            this.tabPagePriceAnalysis.Controls.Add(this.label1);
            this.tabPagePriceAnalysis.Location = new System.Drawing.Point(4, 25);
            this.tabPagePriceAnalysis.Name = "tabPagePriceAnalysis";
            this.tabPagePriceAnalysis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePriceAnalysis.Size = new System.Drawing.Size(1152, 324);
            this.tabPagePriceAnalysis.TabIndex = 1;
            this.tabPagePriceAnalysis.Text = "Price Analysis";
            this.tabPagePriceAnalysis.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Location = new System.Drawing.Point(985, 209);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(116, 1);
            this.panel4.TabIndex = 71;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Location = new System.Drawing.Point(985, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(116, 1);
            this.panel3.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(768, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 1);
            this.panel2.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(601, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 16);
            this.label9.TabIndex = 59;
            this.label9.Text = "Total Cost (Price + Other):";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPriceAnalysisTotalCostInBirrTotal
            // 
            this.txtPriceAnalysisTotalCostInBirrTotal.BackColor = System.Drawing.Color.Lavender;
            this.txtPriceAnalysisTotalCostInBirrTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAnalysisTotalCostInBirrTotal.Location = new System.Drawing.Point(768, 146);
            this.txtPriceAnalysisTotalCostInBirrTotal.Name = "txtPriceAnalysisTotalCostInBirrTotal";
            this.txtPriceAnalysisTotalCostInBirrTotal.ReadOnly = true;
            this.txtPriceAnalysisTotalCostInBirrTotal.Size = new System.Drawing.Size(116, 23);
            this.txtPriceAnalysisTotalCostInBirrTotal.TabIndex = 60;
            this.txtPriceAnalysisTotalCostInBirrTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPriceAnalysisUnitCostInBirrTotal
            // 
            this.txtPriceAnalysisUnitCostInBirrTotal.BackColor = System.Drawing.Color.Lavender;
            this.txtPriceAnalysisUnitCostInBirrTotal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAnalysisUnitCostInBirrTotal.Location = new System.Drawing.Point(984, 146);
            this.txtPriceAnalysisUnitCostInBirrTotal.Name = "txtPriceAnalysisUnitCostInBirrTotal";
            this.txtPriceAnalysisUnitCostInBirrTotal.ReadOnly = true;
            this.txtPriceAnalysisUnitCostInBirrTotal.Size = new System.Drawing.Size(116, 23);
            this.txtPriceAnalysisUnitCostInBirrTotal.TabIndex = 67;
            this.txtPriceAnalysisUnitCostInBirrTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmountIn
            // 
            this.lblTotalAmountIn.AutoSize = true;
            this.lblTotalAmountIn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountIn.Location = new System.Drawing.Point(570, 53);
            this.lblTotalAmountIn.Name = "lblTotalAmountIn";
            this.lblTotalAmountIn.Size = new System.Drawing.Size(133, 16);
            this.lblTotalAmountIn.TabIndex = 40;
            this.lblTotalAmountIn.Text = "Total Amount - In Birr";
            this.lblTotalAmountIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPriceAnalysisBatchTotalPrice
            // 
            this.txtPriceAnalysisBatchTotalPrice.BackColor = System.Drawing.Color.Lavender;
            this.txtPriceAnalysisBatchTotalPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAnalysisBatchTotalPrice.Location = new System.Drawing.Point(570, 69);
            this.txtPriceAnalysisBatchTotalPrice.Name = "txtPriceAnalysisBatchTotalPrice";
            this.txtPriceAnalysisBatchTotalPrice.ReadOnly = true;
            this.txtPriceAnalysisBatchTotalPrice.Size = new System.Drawing.Size(116, 23);
            this.txtPriceAnalysisBatchTotalPrice.TabIndex = 42;
            this.txtPriceAnalysisBatchTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnCalculatePrice.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnCalculatePrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculatePrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCalculatePrice.Location = new System.Drawing.Point(570, 22);
            this.btnCalculatePrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(115, 27);
            this.btnCalculatePrice.TabIndex = 39;
            this.btnCalculatePrice.TabStop = false;
            this.btnCalculatePrice.Text = "&Calculate";
            this.btnCalculatePrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
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
            this.colExchangeRate,
            this.colProfitMargin});
            this.lvwBatchs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBatchs.FullRowSelect = true;
            this.lvwBatchs.GridLines = true;
            this.lvwBatchs.Location = new System.Drawing.Point(8, 56);
            this.lvwBatchs.MultiSelect = false;
            this.lvwBatchs.Name = "lvwBatchs";
            this.lvwBatchs.Size = new System.Drawing.Size(495, 262);
            this.lvwBatchs.TabIndex = 38;
            this.lvwBatchs.UseCompatibleStateImageBehavior = false;
            this.lvwBatchs.View = System.Windows.Forms.View.Details;
            this.lvwBatchs.SelectedIndexChanged += new System.EventHandler(this.lvwBatchs_SelectedIndexChanged);
            this.lvwBatchs.DoubleClick += new System.EventHandler(this.lvwBatchs_DoubleClick);
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
            this.colBatchsItemname.Width = 300;
            // 
            // colBatchsQuantity
            // 
            this.colBatchsQuantity.Text = "Quantity";
            this.colBatchsQuantity.Width = 70;
            // 
            // colBatchsPriceperunit
            // 
            this.colBatchsPriceperunit.Text = "Price Per Unit";
            this.colBatchsPriceperunit.Width = 0;
            // 
            // colBatchsFreightpayments
            // 
            this.colBatchsFreightpayments.Text = "Freight";
            this.colBatchsFreightpayments.Width = 0;
            // 
            // colBatchsInsurancepayments
            // 
            this.colBatchsInsurancepayments.Text = "Insurance";
            this.colBatchsInsurancepayments.Width = 0;
            // 
            // colBatchsBankpayments
            // 
            this.colBatchsBankpayments.Text = "Bank";
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
            // colExchangeRate
            // 
            this.colExchangeRate.Text = "Exchange Rate";
            this.colExchangeRate.Width = 0;
            // 
            // colProfitMargin
            // 
            this.colProfitMargin.Text = "Profit Margin";
            this.colProfitMargin.Width = 0;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(854, 185);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(126, 16);
            this.label32.TabIndex = 69;
            this.label32.Text = "Profit Margin - In %:";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProfitMargin
            // 
            this.txtProfitMargin.BackColor = System.Drawing.Color.Lavender;
            this.txtProfitMargin.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfitMargin.Location = new System.Drawing.Point(985, 182);
            this.txtProfitMargin.Name = "txtProfitMargin";
            this.txtProfitMargin.ReadOnly = true;
            this.txtProfitMargin.Size = new System.Drawing.Size(116, 23);
            this.txtProfitMargin.TabIndex = 70;
            this.txtProfitMargin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSaveActualPriceForBatch
            // 
            this.btnSaveActualPriceForBatch.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSaveActualPriceForBatch.Image = global::Pharma.Properties.Resources.save1;
            this.btnSaveActualPriceForBatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveActualPriceForBatch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveActualPriceForBatch.Location = new System.Drawing.Point(1103, 239);
            this.btnSaveActualPriceForBatch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSaveActualPriceForBatch.Name = "btnSaveActualPriceForBatch";
            this.btnSaveActualPriceForBatch.Size = new System.Drawing.Size(26, 27);
            this.btnSaveActualPriceForBatch.TabIndex = 76;
            this.btnSaveActualPriceForBatch.TabStop = false;
            this.btnSaveActualPriceForBatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveActualPriceForBatch.UseVisualStyleBackColor = true;
            this.btnSaveActualPriceForBatch.Click += new System.EventHandler(this.btnSaveActualPriceForBatch_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(509, 243);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(471, 16);
            this.label31.TabIndex = 74;
            this.label31.Text = "Actual Selling Price (Same as Suggested Selling Price at the time of Calculation)" +
                ":";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtActualSellingPrice
            // 
            this.txtActualSellingPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActualSellingPrice.Location = new System.Drawing.Point(985, 240);
            this.txtActualSellingPrice.Name = "txtActualSellingPrice";
            this.txtActualSellingPrice.Size = new System.Drawing.Size(116, 23);
            this.txtActualSellingPrice.TabIndex = 75;
            this.txtActualSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(564, 217);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(416, 16);
            this.label30.TabIndex = 72;
            this.label30.Text = "Suggested Selling Price (Total Cost + Total Cost * Profit Margin / 100):";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSuggestedSellingPrice
            // 
            this.txtSuggestedSellingPrice.BackColor = System.Drawing.Color.Lavender;
            this.txtSuggestedSellingPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuggestedSellingPrice.Location = new System.Drawing.Point(985, 214);
            this.txtSuggestedSellingPrice.Name = "txtSuggestedSellingPrice";
            this.txtSuggestedSellingPrice.ReadOnly = true;
            this.txtSuggestedSellingPrice.Size = new System.Drawing.Size(116, 23);
            this.txtSuggestedSellingPrice.TabIndex = 73;
            this.txtSuggestedSellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(984, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 16);
            this.label16.TabIndex = 61;
            this.label16.Text = "Amount per Unit - In Birr";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPriceAnalysisUnitPriceInBirr
            // 
            this.txtPriceAnalysisUnitPriceInBirr.BackColor = System.Drawing.Color.Lavender;
            this.txtPriceAnalysisUnitPriceInBirr.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAnalysisUnitPriceInBirr.Location = new System.Drawing.Point(984, 69);
            this.txtPriceAnalysisUnitPriceInBirr.Name = "txtPriceAnalysisUnitPriceInBirr";
            this.txtPriceAnalysisUnitPriceInBirr.ReadOnly = true;
            this.txtPriceAnalysisUnitPriceInBirr.Size = new System.Drawing.Size(116, 23);
            this.txtPriceAnalysisUnitPriceInBirr.TabIndex = 62;
            this.txtPriceAnalysisUnitPriceInBirr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPriceAnalysisUnitOtherInBirr
            // 
            this.txtPriceAnalysisUnitOtherInBirr.BackColor = System.Drawing.Color.Lavender;
            this.txtPriceAnalysisUnitOtherInBirr.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAnalysisUnitOtherInBirr.Location = new System.Drawing.Point(984, 98);
            this.txtPriceAnalysisUnitOtherInBirr.Name = "txtPriceAnalysisUnitOtherInBirr";
            this.txtPriceAnalysisUnitOtherInBirr.ReadOnly = true;
            this.txtPriceAnalysisUnitOtherInBirr.Size = new System.Drawing.Size(116, 23);
            this.txtPriceAnalysisUnitOtherInBirr.TabIndex = 66;
            this.txtPriceAnalysisUnitOtherInBirr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(768, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(133, 16);
            this.label19.TabIndex = 49;
            this.label19.Text = "Total Amount - In Birr";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBatchNumber
            // 
            this.lblBatchNumber.AutoSize = true;
            this.lblBatchNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatchNumber.Location = new System.Drawing.Point(6, 6);
            this.lblBatchNumber.Name = "lblBatchNumber";
            this.lblBatchNumber.Size = new System.Drawing.Size(52, 16);
            this.lblBatchNumber.TabIndex = 35;
            this.lblBatchNumber.Text = "Batch #";
            this.lblBatchNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPriceAnalysisTotalPriceInBirr
            // 
            this.txtPriceAnalysisTotalPriceInBirr.BackColor = System.Drawing.Color.Lavender;
            this.txtPriceAnalysisTotalPriceInBirr.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAnalysisTotalPriceInBirr.Location = new System.Drawing.Point(768, 69);
            this.txtPriceAnalysisTotalPriceInBirr.Name = "txtPriceAnalysisTotalPriceInBirr";
            this.txtPriceAnalysisTotalPriceInBirr.ReadOnly = true;
            this.txtPriceAnalysisTotalPriceInBirr.Size = new System.Drawing.Size(116, 23);
            this.txtPriceAnalysisTotalPriceInBirr.TabIndex = 50;
            this.txtPriceAnalysisTotalPriceInBirr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPriceAnalysisTotalOtherInBirr
            // 
            this.txtPriceAnalysisTotalOtherInBirr.BackColor = System.Drawing.Color.Lavender;
            this.txtPriceAnalysisTotalOtherInBirr.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAnalysisTotalOtherInBirr.Location = new System.Drawing.Point(768, 98);
            this.txtPriceAnalysisTotalOtherInBirr.Name = "txtPriceAnalysisTotalOtherInBirr";
            this.txtPriceAnalysisTotalOtherInBirr.ReadOnly = true;
            this.txtPriceAnalysisTotalOtherInBirr.Size = new System.Drawing.Size(116, 23);
            this.txtPriceAnalysisTotalOtherInBirr.TabIndex = 57;
            this.txtPriceAnalysisTotalOtherInBirr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(719, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 56;
            this.label10.Text = "Other:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItem
            // 
            this.txtItem.BackColor = System.Drawing.Color.Lavender;
            this.txtItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(107, 22);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(286, 23);
            this.txtItem.TabIndex = 37;
            // 
            // txtBatchNumber
            // 
            this.txtBatchNumber.BackColor = System.Drawing.Color.Lavender;
            this.txtBatchNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBatchNumber.Location = new System.Drawing.Point(8, 22);
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.ReadOnly = true;
            this.txtBatchNumber.Size = new System.Drawing.Size(100, 23);
            this.txtBatchNumber.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Price:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelToolbar
            // 
            this.panelToolbar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolbar.Controls.Add(this.proformaToolStrip);
            this.panelToolbar.Location = new System.Drawing.Point(6, 42);
            this.panelToolbar.Name = "panelToolbar";
            this.panelToolbar.Size = new System.Drawing.Size(781, 28);
            this.panelToolbar.TabIndex = 106;
            // 
            // frmLocalCalculatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1173, 710);
            this.Controls.Add(this.tabControlPriceAnalysis);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.sbPurchaseOrders);
            this.Controls.Add(this.panelToolbar);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.PaymentTabs);
            this.Controls.Add(this.grpOrder);
            this.Name = "frmLocalCalculatePrice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Price";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.Resize += new System.EventHandler(this.frmCalculatePrice_Resize);
            this.proformaToolStrip.ResumeLayout(false);
            this.proformaToolStrip.PerformLayout();
            this.sbPurchaseOrders.ResumeLayout(false);
            this.sbPurchaseOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.PaymentTabs.ResumeLayout(false);
            this.tabPurchaseOrderDetails.ResumeLayout(false);
            this.tabPurchaseOrderDetails.PerformLayout();
            this.tabOtherPayments.ResumeLayout(false);
            this.tabOtherPayments.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.tabControlPriceAnalysis.ResumeLayout(false);
            this.tabPagePriceAnalysis.ResumeLayout(false);
            this.tabPagePriceAnalysis.PerformLayout();
            this.panelToolbar.ResumeLayout(false);
            this.panelToolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolStrip proformaToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.StatusStrip sbPurchaseOrders;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.TabControl PaymentTabs;
        private System.Windows.Forms.TabPage tabPurchaseOrderDetails;
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
        private System.Windows.Forms.TabControl tabControlPriceAnalysis;
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
        private System.Windows.Forms.ListView lvwPurchaseOrderDetails;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsId;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsPurchaseOrderGuid;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsItemGuid;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsItemName;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsQuantity;
        private System.Windows.Forms.ColumnHeader colPurchaseOrderDetailsPriceperunit;
        private System.Windows.Forms.ColumnHeader colLineTotal;
        private System.Windows.Forms.ColumnHeader colExchangeRate;
        private System.Windows.Forms.ColumnHeader colProfitMargin;
        private System.Windows.Forms.Label lblTotalFOB;
        private System.Windows.Forms.TextBox txtTotalFOB;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtTotalOther;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panelToolbar;
        private System.Windows.Forms.TabPage tabPagePriceAnalysis;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPriceAnalysisUnitPriceInBirr;
        private System.Windows.Forms.TextBox txtPriceAnalysisUnitOtherInBirr;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblBatchNumber;
        private System.Windows.Forms.TextBox txtPriceAnalysisTotalPriceInBirr;
        private System.Windows.Forms.TextBox txtPriceAnalysisTotalOtherInBirr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtActualSellingPrice;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtSuggestedSellingPrice;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtProfitMargin;
        private System.Windows.Forms.Button btnSearchPurchaseOrder;
        private System.Windows.Forms.Label lblTotalAmountIn;
        private System.Windows.Forms.TextBox txtPriceAnalysisBatchTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPriceAnalysisTotalCostInBirrTotal;
        private System.Windows.Forms.TextBox txtPriceAnalysisUnitCostInBirrTotal;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnSaveActualPriceForBatch;
        public System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.TextBox txtOrderDate;
    }
}