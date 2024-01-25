namespace Pharma
{
    partial class frmRecall
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
            this.colStoreName = new System.Windows.Forms.ColumnHeader();
            this.colRefNo = new System.Windows.Forms.ColumnHeader();
            this.colTransactionType = new System.Windows.Forms.ColumnHeader();
            this.colTransactionBy = new System.Windows.Forms.ColumnHeader();
            this.colTransactionDate = new System.Windows.Forms.ColumnHeader();
            this.colCheckedBy = new System.Windows.Forms.ColumnHeader();
            this.colCheckedDate = new System.Windows.Forms.ColumnHeader();
            this.colLocationName = new System.Windows.Forms.ColumnHeader();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowBachsByOrder = new System.Windows.Forms.Button();
            this.txtCheckedDate = new System.Windows.Forms.TextBox();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tabControlRecalledDetail = new System.Windows.Forms.TabControl();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.proformaDetailToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnSaveDetail = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDetail = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGetBatchesFromInvoice = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).BeginInit();
            this.ssbValidator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panelToolBar.SuspendLayout();
            this.proformaToolStrip.SuspendLayout();
            this.tabControlRecalledDetail.SuspendLayout();
            this.tabPageDetail.SuspendLayout();
            this.proformaDetailToolStrip.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(6, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(360, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(8, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(348, 22);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTransactionDateTo
            // 
            this.txtTransactionDateTo.Location = new System.Drawing.Point(185, 73);
            this.txtTransactionDateTo.Name = "txtTransactionDateTo";
            this.txtTransactionDateTo.Size = new System.Drawing.Size(169, 22);
            this.txtTransactionDateTo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Recall Date To";
            // 
            // txtTransactionDateFrom
            // 
            this.txtTransactionDateFrom.Location = new System.Drawing.Point(8, 73);
            this.txtTransactionDateFrom.Name = "txtTransactionDateFrom";
            this.txtTransactionDateFrom.Size = new System.Drawing.Size(169, 22);
            this.txtTransactionDateFrom.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Recall Date From";
            // 
            // cboStoreNameSearch
            // 
            this.cboStoreNameSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreNameSearch.FormattingEnabled = true;
            this.cboStoreNameSearch.Location = new System.Drawing.Point(185, 31);
            this.cboStoreNameSearch.Name = "cboStoreNameSearch";
            this.cboStoreNameSearch.Size = new System.Drawing.Size(169, 22);
            this.cboStoreNameSearch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Store Name";
            // 
            // cboStoreLocationSearch
            // 
            this.cboStoreLocationSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocationSearch.FormattingEnabled = true;
            this.cboStoreLocationSearch.Location = new System.Drawing.Point(8, 31);
            this.cboStoreLocationSearch.Name = "cboStoreLocationSearch";
            this.cboStoreLocationSearch.Size = new System.Drawing.Size(169, 22);
            this.cboStoreLocationSearch.TabIndex = 1;
            this.cboStoreLocationSearch.SelectedIndexChanged += new System.EventHandler(this.cboStoreLocationSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Location";
            // 
            // lvwTransactions
            // 
            this.lvwTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTrasactionId,
            this.colStoreName,
            this.colRefNo,
            this.colTransactionType,
            this.colTransactionBy,
            this.colTransactionDate,
            this.colCheckedBy,
            this.colCheckedDate,
            this.colLocationName});
            this.lvwTransactions.FullRowSelect = true;
            this.lvwTransactions.GridLines = true;
            this.lvwTransactions.Location = new System.Drawing.Point(6, 169);
            this.lvwTransactions.Name = "lvwTransactions";
            this.lvwTransactions.Size = new System.Drawing.Size(360, 505);
            this.lvwTransactions.TabIndex = 0;
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
            // colStoreName
            // 
            this.colStoreName.Text = "Store Name";
            this.colStoreName.Width = 0;
            // 
            // colRefNo
            // 
            this.colRefNo.Text = "Reference Number";
            this.colRefNo.Width = 200;
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
            this.colTransactionDate.Text = "Recall Date";
            this.colTransactionDate.Width = 120;
            // 
            // colCheckedBy
            // 
            this.colCheckedBy.Width = 0;
            // 
            // colCheckedDate
            // 
            this.colCheckedDate.Width = 0;
            // 
            // colLocationName
            // 
            this.colLocationName.Text = "LocationName";
            this.colLocationName.Width = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowBachsByOrder);
            this.groupBox3.Controls.Add(this.txtCheckedDate);
            this.groupBox3.Controls.Add(this.txtOrderNumber);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTransactionDate);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtCheckedBy);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtTransactionBy);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtReferenceNo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cboStoreName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cboStoreLocation);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(373, 74);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(691, 149);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnShowBachsByOrder
            // 
            this.btnShowBachsByOrder.Location = new System.Drawing.Point(5, 111);
            this.btnShowBachsByOrder.Name = "btnShowBachsByOrder";
            this.btnShowBachsByOrder.Size = new System.Drawing.Size(185, 23);
            this.btnShowBachsByOrder.TabIndex = 6;
            this.btnShowBachsByOrder.Text = "Show Batchs No";
            this.btnShowBachsByOrder.UseVisualStyleBackColor = true;
            this.btnShowBachsByOrder.Click += new System.EventHandler(this.btnShowBachsByOrder_Click);
            // 
            // txtCheckedDate
            // 
            this.txtCheckedDate.Location = new System.Drawing.Point(416, 118);
            this.txtCheckedDate.Name = "txtCheckedDate";
            this.txtCheckedDate.Size = new System.Drawing.Size(206, 22);
            this.txtCheckedDate.TabIndex = 33;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(10, 76);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(169, 22);
            this.txtOrderNumber.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(416, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 14);
            this.label14.TabIndex = 32;
            this.label14.Text = "Checked  Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Purchase Order Number";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(416, 77);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(206, 22);
            this.txtTransactionDate.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(416, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 14);
            this.label13.TabIndex = 30;
            this.label13.Text = "Recall  Date";
            // 
            // txtCheckedBy
            // 
            this.txtCheckedBy.Location = new System.Drawing.Point(196, 118);
            this.txtCheckedBy.Name = "txtCheckedBy";
            this.txtCheckedBy.Size = new System.Drawing.Size(206, 22);
            this.txtCheckedBy.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "Checked By";
            // 
            // txtTransactionBy
            // 
            this.txtTransactionBy.Location = new System.Drawing.Point(196, 77);
            this.txtTransactionBy.Name = "txtTransactionBy";
            this.txtTransactionBy.Size = new System.Drawing.Size(206, 22);
            this.txtTransactionBy.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(196, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 14);
            this.label11.TabIndex = 26;
            this.label11.Text = "Issued By";
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Location = new System.Drawing.Point(9, 30);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(161, 22);
            this.txtReferenceNo.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 14);
            this.label9.TabIndex = 22;
            this.label9.Text = "Reference Number\r\n";
            // 
            // cboStoreName
            // 
            this.cboStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreName.FormattingEnabled = true;
            this.cboStoreName.Location = new System.Drawing.Point(416, 30);
            this.cboStoreName.Name = "cboStoreName";
            this.cboStoreName.Size = new System.Drawing.Size(206, 22);
            this.cboStoreName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(416, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Store Name";
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(196, 30);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(206, 22);
            this.cboStoreLocation.TabIndex = 19;
            this.cboStoreLocation.SelectedIndexChanged += new System.EventHandler(this.cboStoreLocation_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 14);
            this.label8.TabIndex = 18;
            this.label8.Text = "Store Location";
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
            this.grvTransactionDetails.Location = new System.Drawing.Point(4, 33);
            this.grvTransactionDetails.Name = "grvTransactionDetails";
            this.grvTransactionDetails.Size = new System.Drawing.Size(674, 379);
            this.grvTransactionDetails.TabIndex = 0;
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
            this.ssbValidator.TabIndex = 4;
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
            this.line3.Location = new System.Drawing.Point(0, 36);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1022, 1);
            this.line3.TabIndex = 127;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1022, 36);
            this.lblTitle.TabIndex = 126;
            this.lblTitle.Text = "    Recalled Items";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelToolBar
            // 
            this.panelToolBar.BackColor = System.Drawing.Color.Transparent;
            this.panelToolBar.Controls.Add(this.proformaToolStrip);
            this.panelToolBar.Location = new System.Drawing.Point(373, 40);
            this.panelToolBar.Name = "panelToolBar";
            this.panelToolBar.Size = new System.Drawing.Size(710, 28);
            this.panelToolBar.TabIndex = 128;
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
            this.btnNew.ToolTipText = "Prepare the system to accept a new recalled goods record";
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
            this.btnSave.ToolTipText = "Save the current recalled goods record (i.e. newly created or edited)";
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
            this.btnDelete.ToolTipText = "Delete the currently selected recalled goods record";
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
            this.btnPrintPreview.ToolTipText = "Preview the currently selected recalled goods record for printing";
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
            this.btnClose.ToolTipText = "Close the Recalled Goods dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControlRecalledDetail
            // 
            this.tabControlRecalledDetail.Controls.Add(this.tabPageDetail);
            this.tabControlRecalledDetail.Location = new System.Drawing.Point(373, 232);
            this.tabControlRecalledDetail.Name = "tabControlRecalledDetail";
            this.tabControlRecalledDetail.SelectedIndex = 0;
            this.tabControlRecalledDetail.Size = new System.Drawing.Size(691, 444);
            this.tabControlRecalledDetail.TabIndex = 129;
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.proformaDetailToolStrip);
            this.tabPageDetail.Controls.Add(this.grvTransactionDetails);
            this.tabPageDetail.Location = new System.Drawing.Point(4, 23);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(683, 417);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Recalled Items Detail";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // proformaDetailToolStrip
            // 
            this.proformaDetailToolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.proformaDetailToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.btnSaveDetail,
            this.btnDeleteDetail,
            this.toolStripSeparator2,
            this.btnGetBatchesFromInvoice});
            this.proformaDetailToolStrip.Location = new System.Drawing.Point(3, 3);
            this.proformaDetailToolStrip.Name = "proformaDetailToolStrip";
            this.proformaDetailToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.proformaDetailToolStrip.Size = new System.Drawing.Size(677, 25);
            this.proformaDetailToolStrip.TabIndex = 114;
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
            this.btnSaveDetail.ToolTipText = "Save the current recalled goods detail record (i.e. newly created or edited)";
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
            this.btnDeleteDetail.ToolTipText = "Delete the currently selected recalled goods detail record";
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGetBatchesFromInvoice
            // 
            this.btnGetBatchesFromInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetBatchesFromInvoice.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGetBatchesFromInvoice.Image = global::Pharma.Properties.Resources.refresh;
            this.btnGetBatchesFromInvoice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetBatchesFromInvoice.Name = "btnGetBatchesFromInvoice";
            this.btnGetBatchesFromInvoice.Size = new System.Drawing.Size(173, 22);
            this.btnGetBatchesFromInvoice.Text = "Get Batches From Invoice";
            // 
            // frmRecall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1264, 764);
            this.Controls.Add(this.tabControlRecalledDetail);
            this.Controls.Add(this.panelToolBar);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvwTransactions);
            this.Controls.Add(this.ssbValidator);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRecall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRecieving_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).EndInit();
            this.ssbValidator.ResumeLayout(false);
            this.ssbValidator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.panelToolBar.ResumeLayout(false);
            this.panelToolBar.PerformLayout();
            this.proformaToolStrip.ResumeLayout(false);
            this.proformaToolStrip.PerformLayout();
            this.tabControlRecalledDetail.ResumeLayout(false);
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            this.proformaDetailToolStrip.ResumeLayout(false);
            this.proformaDetailToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.TextBox txtTransactionBy;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.Button btnShowBachsByOrder;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader colLocationName;
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
        private System.Windows.Forms.TabControl tabControlRecalledDetail;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.ToolStrip proformaDetailToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnDelete;
        public System.Windows.Forms.ToolStripButton btnSaveDetail;
        public System.Windows.Forms.ToolStripButton btnDeleteDetail;
        public System.Windows.Forms.ToolStripButton btnGetBatchesFromInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransactionGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
    }
}