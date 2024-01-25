namespace Pharma
{
    partial class frmRequesition
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnview = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemcode = new System.Windows.Forms.TextBox();
            this.indexBar = new Pharma.IndexBar();
            this.lvwItems = new System.Windows.Forms.ListView();
            this.colItemId = new System.Windows.Forms.ColumnHeader();
            this.colItemBrandName = new System.Windows.Forms.ColumnHeader();
            this.colItemUnit = new System.Windows.Forms.ColumnHeader();
            this.cboItemCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.grvTransactionDetails = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReqItemGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequesitionGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApprovedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssbValidator = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtOrganizationName = new System.Windows.Forms.TextBox();
            this.btnFindCustormerDataEntry = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReferenceNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new System.Windows.Forms.TextBox();
            this.lblLicense = new System.Windows.Forms.Label();
            this.grpDataEntry = new System.Windows.Forms.GroupBox();
            this.btnPrepareInvoice = new System.Windows.Forms.Button();
            this.grpItems.SuspendLayout();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).BeginInit();
            this.ssbValidator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.grpDataEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnAddItem.Location = new System.Drawing.Point(529, 287);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(48, 64);
            this.btnAddItem.TabIndex = 37;
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.label2);
            this.grpItems.Controls.Add(this.txtItemName);
            this.grpItems.Controls.Add(this.btnview);
            this.grpItems.Controls.Add(this.label1);
            this.grpItems.Controls.Add(this.txtItemcode);
            this.grpItems.Controls.Add(this.indexBar);
            this.grpItems.Controls.Add(this.lvwItems);
            this.grpItems.Controls.Add(this.cboItemCategory);
            this.grpItems.Location = new System.Drawing.Point(12, 132);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(439, 522);
            this.grpItems.TabIndex = 32;
            this.grpItems.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 41;
            this.label2.Text = "Brand Name";
            this.label2.Visible = false;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.White;
            this.txtItemName.Location = new System.Drawing.Point(96, 7);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(93, 22);
            this.txtItemName.TabIndex = 40;
            this.txtItemName.Visible = false;
            this.txtItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemName_KeyPress);
            // 
            // btnview
            // 
            this.btnview.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnview.Location = new System.Drawing.Point(364, 6);
            this.btnview.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(70, 25);
            this.btnview.TabIndex = 39;
            this.btnview.TabStop = false;
            this.btnview.Text = "Search";
            this.btnview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Visible = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 26;
            this.label1.Text = "Item Code";
            this.label1.Visible = false;
            // 
            // txtItemcode
            // 
            this.txtItemcode.BackColor = System.Drawing.Color.White;
            this.txtItemcode.Location = new System.Drawing.Point(267, 8);
            this.txtItemcode.Name = "txtItemcode";
            this.txtItemcode.Size = new System.Drawing.Size(93, 22);
            this.txtItemcode.TabIndex = 27;
            this.txtItemcode.Visible = false;
            this.txtItemcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtItemcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemcode_KeyPress);
            // 
            // indexBar
            // 
            this.indexBar.Alignment = Pharma.IndexBar.IndexBarAlignment.Vertical;
            this.indexBar.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexBar.Location = new System.Drawing.Point(7, 66);
            this.indexBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.indexBar.Name = "indexBar";
            this.indexBar.Size = new System.Drawing.Size(48, 464);
            this.indexBar.TabIndex = 35;
            this.indexBar.Load += new System.EventHandler(this.indexBar_Load);
            this.indexBar.LetterListener += new System.EventHandler(this.indexBar_LetterListener);
            // 
            // lvwItems
            // 
            this.lvwItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemId,
            this.colItemBrandName,
            this.colItemUnit});
            this.lvwItems.FullRowSelect = true;
            this.lvwItems.GridLines = true;
            this.lvwItems.Location = new System.Drawing.Point(58, 66);
            this.lvwItems.Name = "lvwItems";
            this.lvwItems.Size = new System.Drawing.Size(360, 464);
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
            this.colItemBrandName.Width = 420;
            // 
            // colItemUnit
            // 
            this.colItemUnit.Text = "Unit";
            this.colItemUnit.Width = 0;
            // 
            // cboItemCategory
            // 
            this.cboItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemCategory.FormattingEnabled = true;
            this.cboItemCategory.Location = new System.Drawing.Point(12, 38);
            this.cboItemCategory.Name = "cboItemCategory";
            this.cboItemCategory.Size = new System.Drawing.Size(409, 22);
            this.cboItemCategory.TabIndex = 34;
            this.cboItemCategory.SelectedIndexChanged += new System.EventHandler(this.cboItemCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "Item Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.grvTransactionDetails);
            this.grpDetail.Location = new System.Drawing.Point(670, 119);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(581, 535);
            this.grpDetail.TabIndex = 38;
            this.grpDetail.TabStop = false;
            // 
            // grvTransactionDetails
            // 
            this.grvTransactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactionDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colReqItemGuid,
            this.colRequesitionGuid,
            this.colBrandName,
            this.colUnit,
            this.colApprovedQuantity});
            this.grvTransactionDetails.Location = new System.Drawing.Point(0, 0);
            this.grvTransactionDetails.Name = "grvTransactionDetails";
            this.grvTransactionDetails.Size = new System.Drawing.Size(581, 536);
            this.grvTransactionDetails.TabIndex = 40;
            this.grvTransactionDetails.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.grvTransactionDetails_UserDeletingRow);
            this.grvTransactionDetails.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTransactionDetails_CellEndEdit);
            this.grvTransactionDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvTransactionDetails_CellContentClick);
            // 
            // colId
            // 
            this.colId.HeaderText = "id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colReqItemGuid
            // 
            this.colReqItemGuid.HeaderText = "ItemGuid";
            this.colReqItemGuid.Name = "colReqItemGuid";
            this.colReqItemGuid.Visible = false;
            // 
            // colRequesitionGuid
            // 
            this.colRequesitionGuid.HeaderText = "RequesitionGuid";
            this.colRequesitionGuid.Name = "colRequesitionGuid";
            this.colRequesitionGuid.Visible = false;
            // 
            // colBrandName
            // 
            this.colBrandName.HeaderText = "Brand Name";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.ReadOnly = true;
            this.colBrandName.Width = 350;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "Unit";
            this.colUnit.Name = "colUnit";
            this.colUnit.Visible = false;
            // 
            // colApprovedQuantity
            // 
            this.colApprovedQuantity.HeaderText = "Quantity";
            this.colApprovedQuantity.Name = "colApprovedQuantity";
            this.colApprovedQuantity.Width = 172;
            // 
            // ssbValidator
            // 
            this.ssbValidator.BackColor = System.Drawing.Color.Lavender;
            this.ssbValidator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg,
            this.lblStatus});
            this.ssbValidator.Location = new System.Drawing.Point(0, 658);
            this.ssbValidator.Name = "ssbValidator";
            this.ssbValidator.Size = new System.Drawing.Size(1307, 22);
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
            this.lblTitle.Size = new System.Drawing.Size(1117, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "      Items list";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // txtOrganizationName
            // 
            this.txtOrganizationName.Location = new System.Drawing.Point(9, 31);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.Size = new System.Drawing.Size(399, 22);
            this.txtOrganizationName.TabIndex = 16;
            this.txtOrganizationName.TextChanged += new System.EventHandler(this.txtOrganizationName_TextChanged);
            // 
            // btnFindCustormerDataEntry
            // 
            this.btnFindCustormerDataEntry.Location = new System.Drawing.Point(412, 28);
            this.btnFindCustormerDataEntry.Name = "btnFindCustormerDataEntry";
            this.btnFindCustormerDataEntry.Size = new System.Drawing.Size(30, 28);
            this.btnFindCustormerDataEntry.TabIndex = 17;
            this.btnFindCustormerDataEntry.Text = "...";
            this.btnFindCustormerDataEntry.UseVisualStyleBackColor = true;
            this.btnFindCustormerDataEntry.Click += new System.EventHandler(this.btnFindCustormerDataEntry_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(631, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 14);
            this.label7.TabIndex = 26;
            this.label7.Text = "Reference Number";
            // 
            // txtReferenceNumber
            // 
            this.txtReferenceNumber.BackColor = System.Drawing.Color.White;
            this.txtReferenceNumber.Location = new System.Drawing.Point(631, 30);
            this.txtReferenceNumber.Name = "txtReferenceNumber";
            this.txtReferenceNumber.Size = new System.Drawing.Size(135, 22);
            this.txtReferenceNumber.TabIndex = 27;
            this.txtReferenceNumber.TextChanged += new System.EventHandler(this.txtReferenceNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(773, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "Invoice #";
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNumber.ForeColor = System.Drawing.Color.Red;
            this.txtInvoiceNumber.Location = new System.Drawing.Point(776, 28);
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.ReadOnly = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(89, 23);
            this.txtInvoiceNumber.TabIndex = 33;
            // 
            // lblLicense
            // 
            this.lblLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicense.ForeColor = System.Drawing.Color.Red;
            this.lblLicense.Location = new System.Drawing.Point(6, 64);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(751, 17);
            this.lblLicense.TabIndex = 34;
            // 
            // grpDataEntry
            // 
            this.grpDataEntry.Controls.Add(this.btnPrepareInvoice);
            this.grpDataEntry.Controls.Add(this.lblLicense);
            this.grpDataEntry.Controls.Add(this.txtInvoiceNumber);
            this.grpDataEntry.Controls.Add(this.label8);
            this.grpDataEntry.Controls.Add(this.txtReferenceNumber);
            this.grpDataEntry.Controls.Add(this.label7);
            this.grpDataEntry.Controls.Add(this.btnFindCustormerDataEntry);
            this.grpDataEntry.Controls.Add(this.txtOrganizationName);
            this.grpDataEntry.Controls.Add(this.label9);
            this.grpDataEntry.Location = new System.Drawing.Point(30, 44);
            this.grpDataEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDataEntry.Name = "grpDataEntry";
            this.grpDataEntry.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDataEntry.Size = new System.Drawing.Size(1087, 68);
            this.grpDataEntry.TabIndex = 14;
            this.grpDataEntry.TabStop = false;
            // 
            // btnPrepareInvoice
            // 
            this.btnPrepareInvoice.Location = new System.Drawing.Point(874, 24);
            this.btnPrepareInvoice.Name = "btnPrepareInvoice";
            this.btnPrepareInvoice.Size = new System.Drawing.Size(210, 33);
            this.btnPrepareInvoice.TabIndex = 35;
            this.btnPrepareInvoice.Text = "Prepare Order";
            this.btnPrepareInvoice.UseVisualStyleBackColor = true;
            this.btnPrepareInvoice.Click += new System.EventHandler(this.btnPrepareInvoice_Click);
            // 
            // frmRequesition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1307, 680);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ssbValidator);
            this.Controls.Add(this.grpDataEntry);
            this.Controls.Add(this.grpItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpDetail);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRequesition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items List";
            this.Load += new System.EventHandler(this.frmRequesition_Load);
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            this.grpDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactionDetails)).EndInit();
            this.ssbValidator.ResumeLayout(false);
            this.ssbValidator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.grpDataEntry.ResumeLayout(false);
            this.grpDataEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion        

        private System.Windows.Forms.StatusStrip ssbValidator;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.DataGridView grvTransactionDetails;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.ComboBox cboItemCategory;
        private System.Windows.Forms.ListView lvwItems;
        private System.Windows.Forms.ColumnHeader colItemId;
        private System.Windows.Forms.ColumnHeader colItemBrandName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader colItemUnit;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.TextBox txtItemsManufacturerid;
        private System.Windows.Forms.TextBox txtManufacturerFilter;
        private System.Windows.Forms.ComboBox cboItemCategoryFilter;
        private System.Windows.Forms.CheckBox chkProductsStatus;


        private IndexBar indexBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        public System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.GroupBox grpDataEntry;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.TextBox txtInvoiceNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReferenceNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFindCustormerDataEntry;
        private System.Windows.Forms.TextBox txtOrganizationName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPrepareInvoice;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReqItemGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequesitionGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApprovedQuantity;
    }
}