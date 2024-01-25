namespace Pharma
{
    partial class frmProforma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProforma));
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchPurchaseOrder = new System.Windows.Forms.Button();
            this.btnFindCustormer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProformaDateTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProformaDateFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwTransactions = new System.Windows.Forms.ListView();
            this.colProformaId = new System.Windows.Forms.ColumnHeader();
            this.colOrganizationName = new System.Windows.Forms.ColumnHeader();
            this.colReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colProformaDate = new System.Windows.Forms.ColumnHeader();
            this.colApprovedBy = new System.Windows.Forms.ColumnHeader();
            this.colApprovalDate = new System.Windows.Forms.ColumnHeader();
            this.colRequestedBy = new System.Windows.Forms.ColumnHeader();
            this.colCustomerGuid = new System.Windows.Forms.ColumnHeader();
            this.grpDataEntry = new System.Windows.Forms.GroupBox();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApprovedDate = new System.Windows.Forms.TextBox();
            this.txtRequestedBy = new System.Windows.Forms.TextBox();
            this.btnFindCustormerDataEntry = new System.Windows.Forms.Button();
            this.txtApprovedBy = new System.Windows.Forms.TextBox();
            this.txtProformaDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrganizationName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.indexBar = new Pharma.IndexBar();
            this.lvwItems = new System.Windows.Forms.ListView();
            this.colItemId = new System.Windows.Forms.ColumnHeader();
            this.colItemBrandName = new System.Windows.Forms.ColumnHeader();
            this.colItemUnitPrice = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.cboItemCategory = new System.Windows.Forms.ComboBox();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.proformaDetailToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSaveDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDetail = new System.Windows.Forms.ToolStripButton();
            this.grvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProformaItemGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProformaGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssbValidator = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
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
            this.grpFilter.SuspendLayout();
            this.grpDataEntry.SuspendLayout();
            this.grpItems.SuspendLayout();
            this.grpDetail.SuspendLayout();
            this.proformaDetailToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).BeginInit();
            this.ssbValidator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panelToolBar.SuspendLayout();
            this.proformaToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnSearchPurchaseOrder);
            this.grpFilter.Controls.Add(this.btnFindCustormer);
            this.grpFilter.Controls.Add(this.txtCustomerName);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.txtProformaDateTo);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Controls.Add(this.txtProformaDateFrom);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Location = new System.Drawing.Point(8, 36);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFilter.Size = new System.Drawing.Size(332, 154);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // btnSearchPurchaseOrder
            // 
            this.btnSearchPurchaseOrder.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchPurchaseOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPurchaseOrder.Image")));
            this.btnSearchPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchPurchaseOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchPurchaseOrder.Location = new System.Drawing.Point(296, 30);
            this.btnSearchPurchaseOrder.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchPurchaseOrder.Name = "btnSearchPurchaseOrder";
            this.btnSearchPurchaseOrder.Size = new System.Drawing.Size(30, 28);
            this.btnSearchPurchaseOrder.TabIndex = 6;
            this.btnSearchPurchaseOrder.TabStop = false;
            this.btnSearchPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnSearchPurchaseOrder.Visible = false;
            this.btnSearchPurchaseOrder.Click += new System.EventHandler(this.btnSearchPurchaseOrder_Click);
            // 
            // btnFindCustormer
            // 
            this.btnFindCustormer.Location = new System.Drawing.Point(263, 30);
            this.btnFindCustormer.Name = "btnFindCustormer";
            this.btnFindCustormer.Size = new System.Drawing.Size(30, 28);
            this.btnFindCustormer.TabIndex = 5;
            this.btnFindCustormer.Text = "...";
            this.btnFindCustormer.UseVisualStyleBackColor = true;
            this.btnFindCustormer.Click += new System.EventHandler(this.btnFindCustormer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(9, 35);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(251, 22);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(8, 104);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(318, 24);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProformaDateTo
            // 
            this.txtProformaDateTo.Location = new System.Drawing.Point(178, 78);
            this.txtProformaDateTo.Name = "txtProformaDateTo";
            this.txtProformaDateTo.Size = new System.Drawing.Size(145, 22);
            this.txtProformaDateTo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Proforma Date To";
            // 
            // txtProformaDateFrom
            // 
            this.txtProformaDateFrom.Location = new System.Drawing.Point(9, 78);
            this.txtProformaDateFrom.Name = "txtProformaDateFrom";
            this.txtProformaDateFrom.Size = new System.Drawing.Size(145, 22);
            this.txtProformaDateFrom.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "Proforma Date From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers Organization Name";
            // 
            // lvwTransactions
            // 
            this.lvwTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProformaId,
            this.colOrganizationName,
            this.colReferenceNumber,
            this.colProformaDate,
            this.colApprovedBy,
            this.colApprovalDate,
            this.colRequestedBy,
            this.colCustomerGuid});
            this.lvwTransactions.FullRowSelect = true;
            this.lvwTransactions.GridLines = true;
            this.lvwTransactions.Location = new System.Drawing.Point(8, 199);
            this.lvwTransactions.Name = "lvwTransactions";
            this.lvwTransactions.Size = new System.Drawing.Size(332, 509);
            this.lvwTransactions.TabIndex = 12;
            this.lvwTransactions.UseCompatibleStateImageBehavior = false;
            this.lvwTransactions.View = System.Windows.Forms.View.Details;
            this.lvwTransactions.SelectedIndexChanged += new System.EventHandler(this.lvwTransactions_SelectedIndexChanged);
            this.lvwTransactions.Click += new System.EventHandler(this.lvwTransactions_Click);
            // 
            // colProformaId
            // 
            this.colProformaId.Text = "id";
            this.colProformaId.Width = 0;
            // 
            // colOrganizationName
            // 
            this.colOrganizationName.Text = "Organization Name";
            this.colOrganizationName.Width = 0;
            // 
            // colReferenceNumber
            // 
            this.colReferenceNumber.Text = "Reference Number";
            this.colReferenceNumber.Width = 150;
            // 
            // colProformaDate
            // 
            this.colProformaDate.Text = "Proforma Date";
            this.colProformaDate.Width = 150;
            // 
            // colApprovedBy
            // 
            this.colApprovedBy.Width = 0;
            // 
            // colApprovalDate
            // 
            this.colApprovalDate.Width = 0;
            // 
            // colRequestedBy
            // 
            this.colRequestedBy.Width = 0;
            // 
            // colCustomerGuid
            // 
            this.colCustomerGuid.Text = "Customer Guid";
            this.colCustomerGuid.Width = 0;
            // 
            // grpDataEntry
            // 
            this.grpDataEntry.Controls.Add(this.txtInvoiceNumber);
            this.grpDataEntry.Controls.Add(this.label8);
            this.grpDataEntry.Controls.Add(this.txtReferenceNumber);
            this.grpDataEntry.Controls.Add(this.label7);
            this.grpDataEntry.Controls.Add(this.button1);
            this.grpDataEntry.Controls.Add(this.label4);
            this.grpDataEntry.Controls.Add(this.label2);
            this.grpDataEntry.Controls.Add(this.txtApprovedDate);
            this.grpDataEntry.Controls.Add(this.txtRequestedBy);
            this.grpDataEntry.Controls.Add(this.btnFindCustormerDataEntry);
            this.grpDataEntry.Controls.Add(this.txtApprovedBy);
            this.grpDataEntry.Controls.Add(this.txtProformaDate);
            this.grpDataEntry.Controls.Add(this.label13);
            this.grpDataEntry.Controls.Add(this.label12);
            this.grpDataEntry.Controls.Add(this.txtOrganizationName);
            this.grpDataEntry.Controls.Add(this.label9);
            this.grpDataEntry.Location = new System.Drawing.Point(351, 66);
            this.grpDataEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDataEntry.Name = "grpDataEntry";
            this.grpDataEntry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDataEntry.Size = new System.Drawing.Size(907, 124);
            this.grpDataEntry.TabIndex = 14;
            this.grpDataEntry.TabStop = false;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.ForeColor = System.Drawing.Color.Red;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(772, 31);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(126, 23);
            this.txtInvoiceNumber.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(772, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Invoice #";
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.BackColor = System.Drawing.Color.White;
            this.txtReferenceNumber.Location = new System.Drawing.Point(9, 95);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.ReadOnly = true;
            this.txtReferenceNumber.Size = new System.Drawing.Size(287, 22);
            this.txtReferenceNumber.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 14);
            this.label7.TabIndex = 26;
            this.label7.Text = "Reference Number";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(332, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 18;
            this.button1.TabStop = false;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "Requested By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 30;
            this.label2.Text = "Approved  Date";
            // 
            // txtApprovedDate
            // 
            this.txtApprovedDate.Location = new System.Drawing.Point(652, 95);
            this.txtApprovedDate.Name = "txtApprovedDate";
            this.txtApprovedDate.Size = new System.Drawing.Size(109, 22);
            this.txtApprovedDate.TabIndex = 31;
            // 
            // txtRequestedBy
            // 
            this.txtRequestedBy.Location = new System.Drawing.Point(368, 31);
            this.txtRequestedBy.Name = "txtRequestedBy";
            this.txtRequestedBy.Size = new System.Drawing.Size(275, 22);
            this.txtRequestedBy.TabIndex = 20;
            // 
            // btnFindCustormerDataEntry
            // 
            this.btnFindCustormerDataEntry.Location = new System.Drawing.Point(299, 28);
            this.btnFindCustormerDataEntry.Name = "btnFindCustormerDataEntry";
            this.btnFindCustormerDataEntry.Size = new System.Drawing.Size(30, 28);
            this.btnFindCustormerDataEntry.TabIndex = 17;
            this.btnFindCustormerDataEntry.Text = "...";
            this.btnFindCustormerDataEntry.UseVisualStyleBackColor = true;
            this.btnFindCustormerDataEntry.Click += new System.EventHandler(this.btnFindCustormerDataEntry_Click);
            // 
            // txtApprovedBy
            // 
            this.txtApprovedBy.Location = new System.Drawing.Point(368, 95);
            this.txtApprovedBy.Name = "txtApprovedBy";
            this.txtApprovedBy.Size = new System.Drawing.Size(275, 22);
            this.txtApprovedBy.TabIndex = 29;
            // 
            // txtProformaDate
            // 
            this.txtProformaDate.Location = new System.Drawing.Point(652, 31);
            this.txtProformaDate.Name = "txtProformaDate";
            this.txtProformaDate.Size = new System.Drawing.Size(109, 22);
            this.txtProformaDate.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(652, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 14);
            this.label13.TabIndex = 21;
            this.label13.Text = "Proforma Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(368, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "Approved  By";
            // 
            // txtOrganizationName
            // 
            this.txtOrganizationName.Location = new System.Drawing.Point(9, 31);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.Size = new System.Drawing.Size(287, 22);
            this.txtOrganizationName.TabIndex = 16;
            this.txtOrganizationName.TextChanged += new System.EventHandler(this.txtOrganizationName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 14);
            this.label9.TabIndex = 15;
            this.label9.Text = "Customers Organization Name";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnAddItem.Location = new System.Drawing.Point(668, 372);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(48, 87);
            this.btnAddItem.TabIndex = 37;
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.lvwItems);
            this.grpItems.Controls.Add(this.label3);
            this.grpItems.Controls.Add(this.cboItemCategory);
            this.grpItems.Location = new System.Drawing.Point(351, 194);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(311, 522);
            this.grpItems.TabIndex = 32;
            this.grpItems.TabStop = false;
            // 
            // indexBar
            // 
            this.indexBar.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexBar.Location = new System.Drawing.Point(321, 187);
            this.indexBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.indexBar.Name = "indexBar";
            this.indexBar.Alignment = Pharma.IndexBar.IndexBarAlignment.Horizontal;
            this.indexBar.Size = new System.Drawing.Size(928, 30);
            this.indexBar.TabIndex = 35;
            this.indexBar.LetterListener += new System.EventHandler(this.indexBar_LetterListener);
            // 
            // lvwItems
            // 
            this.lvwItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemId,
            this.colItemBrandName,
            this.colItemUnitPrice});
            this.lvwItems.FullRowSelect = true;
            this.lvwItems.GridLines = true;
            this.lvwItems.Location = new System.Drawing.Point(58, 52);
            this.lvwItems.Name = "lvwItems";
            this.lvwItems.Size = new System.Drawing.Size(246, 464);
            this.lvwItems.TabIndex = 36;
            this.lvwItems.UseCompatibleStateImageBehavior = false;
            this.lvwItems.View = System.Windows.Forms.View.Details;
            this.lvwItems.SelectedIndexChanged += new System.EventHandler(this.lvwItems_SelectedIndexChanged);
            this.lvwItems.DoubleClick += new System.EventHandler(this.lvwItems_DoubleClick);
            this.lvwItems.Click += new System.EventHandler(this.lvwItems_Click);
            // 
            // colItemId
            // 
            this.colItemId.Width = 0;
            // 
            // colItemBrandName
            // 
            this.colItemBrandName.Text = "Brand Name";
            this.colItemBrandName.Width = 220;
            // 
            // colItemUnitPrice
            // 
            this.colItemUnitPrice.Text = "Unit Price";
            this.colItemUnitPrice.Width = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "Item Category";
            // 
            // cboItemCategory
            // 
            this.cboItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemCategory.FormattingEnabled = true;
            this.cboItemCategory.Location = new System.Drawing.Point(58, 27);
            this.cboItemCategory.Name = "cboItemCategory";
            this.cboItemCategory.Size = new System.Drawing.Size(246, 22);
            this.cboItemCategory.TabIndex = 34;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.proformaDetailToolStrip);
            this.grpDetail.Controls.Add(this.grvTransactionDetails);
            this.grpDetail.Location = new System.Drawing.Point(720, 194);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(538, 522);
            this.grpDetail.TabIndex = 38;
            this.grpDetail.TabStop = false;
            // 
            // proformaDetailToolStrip
            // 
            this.proformaDetailToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.proformaDetailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnSaveDetail,
            this.btnDeleteDetail});
            this.proformaDetailToolStrip.Location = new System.Drawing.Point(3, 18);
            this.proformaDetailToolStrip.Name = "proformaDetailToolStrip";
            this.proformaDetailToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.proformaDetailToolStrip.Size = new System.Drawing.Size(532, 25);
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
            this.btnSaveDetail.ToolTipText = "Save the current item record (i.e. newly created or edited)";
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
            this.btnDeleteDetail.ToolTipText = "Delete the currently selected item record";
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // grvTransactionDetails
            // 
            this.grvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colProformaItemGuid,
            this.colProformaGuid,
            this.colBrandName,
            this.colQuantity,
            this.colUnitPrice,
            this.colTotal});
            this.grvTransactionDetails.Location = new System.Drawing.Point(6, 50);
            this.grvTransactionDetails.Name = "grvTransactionDetails";
            this.grvTransactionDetails.Size = new System.Drawing.Size(526, 466);
            this.grvTransactionDetails.TabIndex = 40;
            this.grvTransactionDetails.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grvTransactionDetails_UserDeletingRow);
            this.grvTransactionDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTransactionDetails_CellEndEdit);
            // 
            // colId
            // 
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colProformaItemGuid
            // 
            this.colProformaItemGuid.HeaderText = "ItemGuid";
            this.colProformaItemGuid.Name = "colProformaItemGuid";
            this.colProformaItemGuid.Visible = false;
            // 
            // colProformaGuid
            // 
            this.colProformaGuid.HeaderText = "ProformaGuid";
            this.colProformaGuid.Name = "colProformaGuid";
            this.colProformaGuid.Visible = false;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            this.colBrandName.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 66;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "Unit Price";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 90;
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // ssbValidator
            // 
            this.ssbValidator.BackColor = System.Drawing.Color.Lavender;
            this.ssbValidator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg,
            this.lblStatus});
            this.ssbValidator.Location = new System.Drawing.Point(0, 724);
            this.ssbValidator.Name = "ssbValidator";
            this.ssbValidator.Size = new System.Drawing.Size(1267, 22);
            this.ssbValidator.TabIndex = 41;
            this.ssbValidator.Text = "statusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
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
            this.lblTitle.Text = "    Proforma";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolBar.Controls.Add(this.proformaToolStrip);
            this.panelToolBar.Location = new System.Drawing.Point(351, 40);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(710, 28);
            this.panelToolBar.TabIndex = 13;
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
            this.proformaToolStrip.TabIndex = 91;
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
            this.btnNew.ToolTipText = "Prepare the system to accept a new proforma record";
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
            this.btnSave.ToolTipText = "Save the current proforma record (i.e. newly created or edited)";
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
            this.btnDelete.ToolTipText = "Delete the currently selected proforma record";
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
            this.btnPrintPreview.ToolTipText = "Preview the currently selected proforma record for printing";
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
            this.btnClose.ToolTipText = "Close the Proforma dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1267, 746);
            this.Controls.Add(this.indexBar);
            this.Controls.Add(this.lvwTransactions);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ssbValidator);
            this.Controls.Add(this.grpDataEntry);
            this.Controls.Add(this.grpItems);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.grpFilter);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProforma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Proforma";
            this.Load += new System.EventHandler(this.frmProforma_Load);
            this.Resize += new System.EventHandler(this.frmProforma_Resize);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpDataEntry.ResumeLayout(false);
            this.grpDataEntry.PerformLayout();
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.GroupBox grpDataEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProformaDateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProformaDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip ssbValidator;
        private System.Windows.Forms.TextBox txtApprovedBy;
        private System.Windows.Forms.TextBox txtProformaDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOrganizationName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvwTransactions;
        private System.Windows.Forms.ColumnHeader colProformaId;
        private System.Windows.Forms.ColumnHeader colOrganizationName;
        private System.Windows.Forms.ColumnHeader colProformaDate;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.ColumnHeader colApprovalDate;
        private System.Windows.Forms.ColumnHeader colRequestedBy;
        private System.Windows.Forms.ColumnHeader colApprovedBy;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFindCustormer;
        private System.Windows.Forms.Button btnFindCustormerDataEntry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApprovedDate;
        private System.Windows.Forms.TextBox txtRequestedBy;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.DataGridView grvTransactionDetails;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.ComboBox cboItemCategory;
        private System.Windows.Forms.ListView lvwItems;
        private System.Windows.Forms.ColumnHeader colItemId;
        private System.Windows.Forms.ColumnHeader colItemBrandName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader colCustomerGuid;
        private System.Windows.Forms.ColumnHeader colItemUnitPrice;
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
        private System.Windows.Forms.ToolStrip proformaDetailToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Button btnSearchPurchaseOrder;
        private System.Windows.Forms.Button button1;
        private IndexBar indexBar;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader colReferenceNumber;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        public System.Windows.Forms.Button btnAddItem;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnDelete;
        public System.Windows.Forms.ToolStripButton btnSaveDetail;
        public System.Windows.Forms.ToolStripButton btnDeleteDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProformaItemGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProformaGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}