namespace Pharma
{
    partial class frmSelectInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectInvoice));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceDateTo = new System.Windows.Forms.TextBox();
            this.txtInvoiceDateFrom = new System.Windows.Forms.TextBox();
            this.chkNotIssued = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchCustomerFilter = new System.Windows.Forms.Button();
            this.txtCustomerFilter = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReferenceNumberLike = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
            this.lvwTransactions = new System.Windows.Forms.ListView();
            this.colGuid = new System.Windows.Forms.ColumnHeader();
            this.colCustomerGuid = new System.Windows.Forms.ColumnHeader();
            this.colOrganizationName = new System.Windows.Forms.ColumnHeader();
            this.colReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceDate = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceType = new System.Windows.Forms.ColumnHeader();
            this.colDueDate = new System.Windows.Forms.ColumnHeader();
            this.colPreparedBy = new System.Windows.Forms.ColumnHeader();
            this.colPreparedDate = new System.Windows.Forms.ColumnHeader();
            this.colCheckedBy = new System.Windows.Forms.ColumnHeader();
            this.colCheckedDate = new System.Windows.Forms.ColumnHeader();
            this.colDeliveredBy = new System.Windows.Forms.ColumnHeader();
            this.colDeliveryDate = new System.Windows.Forms.ColumnHeader();
            this.colApprovedBy = new System.Windows.Forms.ColumnHeader();
            this.colApprovalDate = new System.Windows.Forms.ColumnHeader();
            this.colDeliveryStatus = new System.Windows.Forms.ColumnHeader();
            this.colSuppliesRequisitionGuid = new System.Windows.Forms.ColumnHeader();
            this.colDiscount = new System.Windows.Forms.ColumnHeader();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(557, 506);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(84, 26);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "&Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(656, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 26);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Invoice Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnSearchCustomer);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.txtInvoiceDateTo);
            this.grpFilter.Controls.Add(this.txtInvoiceDateFrom);
            this.grpFilter.Controls.Add(this.chkNotIssued);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label9);
            this.grpFilter.Controls.Add(this.btnSearchCustomerFilter);
            this.grpFilter.Controls.Add(this.txtCustomerFilter);
            this.grpFilter.Controls.Add(this.btnRefresh);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.txtReferenceNumberLike);
            this.grpFilter.Location = new System.Drawing.Point(4, 40);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(736, 101);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer.Location = new System.Drawing.Point(288, 66);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer.TabIndex = 8;
            this.btnSearchCustomer.Text = "...";
            this.btnSearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(394, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Invoice Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer";
            // 
            // txtInvoiceDateTo
            // 
            this.txtInvoiceDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceDateTo.Location = new System.Drawing.Point(532, 69);
            this.txtInvoiceDateTo.Name = "txtInvoiceDateTo";
            this.txtInvoiceDateTo.Size = new System.Drawing.Size(99, 23);
            this.txtInvoiceDateTo.TabIndex = 14;
            // 
            // txtInvoiceDateFrom
            // 
            this.txtInvoiceDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceDateFrom.Location = new System.Drawing.Point(395, 69);
            this.txtInvoiceDateFrom.Name = "txtInvoiceDateFrom";
            this.txtInvoiceDateFrom.Size = new System.Drawing.Size(99, 23);
            this.txtInvoiceDateFrom.TabIndex = 12;
            // 
            // chkNotIssued
            // 
            this.chkNotIssued.Checked = true;
            this.chkNotIssued.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotIssued.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotIssued.Location = new System.Drawing.Point(351, 22);
            this.chkNotIssued.Name = "chkNotIssued";
            this.chkNotIssued.Size = new System.Drawing.Size(277, 19);
            this.chkNotIssued.TabIndex = 5;
            this.chkNotIssued.Text = "Show not issued invoices only";
            this.chkNotIssued.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(502, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "To:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(351, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "From:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchCustomerFilter
            // 
            this.btnSearchCustomerFilter.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomerFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomerFilter.Image")));
            this.btnSearchCustomerFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomerFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomerFilter.Location = new System.Drawing.Point(312, 40);
            this.btnSearchCustomerFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomerFilter.Name = "btnSearchCustomerFilter";
            this.btnSearchCustomerFilter.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomerFilter.TabIndex = 9;
            this.btnSearchCustomerFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomerFilter.UseVisualStyleBackColor = true;
            this.btnSearchCustomerFilter.Visible = false;
            this.btnSearchCustomerFilter.Click += new System.EventHandler(this.btnSearchCustomerFilter_Click);
            // 
            // txtCustomerFilter
            // 
            this.txtCustomerFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFilter.Location = new System.Drawing.Point(14, 69);
            this.txtCustomerFilter.Name = "txtCustomerFilter";
            this.txtCustomerFilter.Size = new System.Drawing.Size(272, 23);
            this.txtCustomerFilter.TabIndex = 7;
            this.txtCustomerFilter.TextChanged += new System.EventHandler(this.txtCustomerFilter_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Pharma.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(635, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 24);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reference Number Like...";
            // 
            // txtReferenceNumberLike
            // 
            this.txtReferenceNumberLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReferenceNumberLike.Location = new System.Drawing.Point(170, 20);
            this.txtReferenceNumberLike.Name = "txtReferenceNumberLike";
            this.txtReferenceNumberLike.Size = new System.Drawing.Size(147, 23);
            this.txtReferenceNumberLike.TabIndex = 4;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(0, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(746, 1);
            this.line1.TabIndex = 1;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(4, 500);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(746, 1);
            this.line3.TabIndex = 17;
            // 
            // lvwTransactions
            // 
            this.lvwTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGuid,
            this.colCustomerGuid,
            this.colOrganizationName,
            this.colReferenceNumber,
            this.colInvoiceDate,
            this.colInvoiceType,
            this.colDueDate,
            this.colPreparedBy,
            this.colPreparedDate,
            this.colCheckedBy,
            this.colCheckedDate,
            this.colDeliveredBy,
            this.colDeliveryDate,
            this.colApprovedBy,
            this.colApprovalDate,
            this.colDeliveryStatus,
            this.colSuppliesRequisitionGuid,
            this.colDiscount});
            this.lvwTransactions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTransactions.FullRowSelect = true;
            this.lvwTransactions.GridLines = true;
            this.lvwTransactions.Location = new System.Drawing.Point(4, 152);
            this.lvwTransactions.Name = "lvwTransactions";
            this.lvwTransactions.Size = new System.Drawing.Size(736, 342);
            this.lvwTransactions.TabIndex = 16;
            this.lvwTransactions.UseCompatibleStateImageBehavior = false;
            this.lvwTransactions.View = System.Windows.Forms.View.Details;
            this.lvwTransactions.DoubleClick += new System.EventHandler(this.lvwTransactions_DoubleClick);
            // 
            // colGuid
            // 
            this.colGuid.Text = "Guid";
            this.colGuid.Width = 0;
            // 
            // colCustomerGuid
            // 
            this.colCustomerGuid.Text = "Customer Guid";
            this.colCustomerGuid.Width = 0;
            // 
            // colOrganizationName
            // 
            this.colOrganizationName.Text = "Organization Name";
            this.colOrganizationName.Width = 0;
            // 
            // colReferenceNumber
            // 
            this.colReferenceNumber.Text = "Invoice Number";
            this.colReferenceNumber.Width = 150;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Text = "Invoice Date";
            this.colInvoiceDate.Width = 100;
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
            this.colPreparedBy.Text = "Prepared By";
            this.colPreparedBy.Width = 120;
            // 
            // colPreparedDate
            // 
            this.colPreparedDate.Text = "Prepared Date";
            this.colPreparedDate.Width = 100;
            // 
            // colCheckedBy
            // 
            this.colCheckedBy.Text = "Checked By";
            this.colCheckedBy.Width = 0;
            // 
            // colCheckedDate
            // 
            this.colCheckedDate.Text = "Checked Date";
            this.colCheckedDate.Width = 0;
            // 
            // colDeliveredBy
            // 
            this.colDeliveredBy.Text = "Delivered By";
            this.colDeliveredBy.Width = 0;
            // 
            // colDeliveryDate
            // 
            this.colDeliveryDate.Text = "Delivery Date";
            this.colDeliveryDate.Width = 0;
            // 
            // colApprovedBy
            // 
            this.colApprovedBy.Text = "Approved By";
            this.colApprovedBy.Width = 120;
            // 
            // colApprovalDate
            // 
            this.colApprovalDate.Text = "Approval Date";
            this.colApprovalDate.Width = 100;
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
            // frmSelectInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(745, 540);
            this.ControlBox = false;
            this.Controls.Add(this.lvwTransactions);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectInvoice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart System";
            this.Load += new System.EventHandler(this.frmSelectInvoice_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReferenceNumberLike;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Button btnSearchCustomerFilter;
        private System.Windows.Forms.TextBox txtCustomerFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvwTransactions;
        private System.Windows.Forms.ColumnHeader colGuid;
        private System.Windows.Forms.ColumnHeader colCustomerGuid;
        private System.Windows.Forms.ColumnHeader colOrganizationName;
        private System.Windows.Forms.ColumnHeader colReferenceNumber;
        private System.Windows.Forms.ColumnHeader colInvoiceDate;
        private System.Windows.Forms.ColumnHeader colInvoiceType;
        private System.Windows.Forms.ColumnHeader colDueDate;
        private System.Windows.Forms.ColumnHeader colPreparedBy;
        private System.Windows.Forms.ColumnHeader colCheckedBy;
        private System.Windows.Forms.ColumnHeader colApprovedBy;
        private System.Windows.Forms.ColumnHeader colDeliveredBy;
        private System.Windows.Forms.ColumnHeader colPreparedDate;
        private System.Windows.Forms.ColumnHeader colCheckedDate;
        private System.Windows.Forms.ColumnHeader colApprovalDate;
        private System.Windows.Forms.ColumnHeader colDeliveryDate;
        private System.Windows.Forms.ColumnHeader colDeliveryStatus;
        private System.Windows.Forms.ColumnHeader colSuppliesRequisitionGuid;
        private System.Windows.Forms.ColumnHeader colDiscount;
        private System.Windows.Forms.CheckBox chkNotIssued;
        private System.Windows.Forms.TextBox txtInvoiceDateTo;
        private System.Windows.Forms.TextBox txtInvoiceDateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchCustomer;
    }
}