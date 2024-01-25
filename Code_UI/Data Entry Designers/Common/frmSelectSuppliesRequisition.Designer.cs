namespace Pharma
{
    partial class frmSelectSuppliesRequisition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectSuppliesRequisition));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.chkNotConvertedToInvoice = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRequestDateFrom = new System.Windows.Forms.TextBox();
            this.txtRequestDateTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchCustomerFilter = new System.Windows.Forms.Button();
            this.txtCustomerFilter = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
            this.lvwRequisitions = new System.Windows.Forms.ListView();
            this.colGuid = new System.Windows.Forms.ColumnHeader();
            this.colOrganizationName = new System.Windows.Forms.ColumnHeader();
            this.colReferenceNumber = new System.Windows.Forms.ColumnHeader();
            this.colRequestDate = new System.Windows.Forms.ColumnHeader();
            this.colRequestedBy = new System.Windows.Forms.ColumnHeader();
            this.colApprovalDate = new System.Windows.Forms.ColumnHeader();
            this.colApprovedBy = new System.Windows.Forms.ColumnHeader();
            this.colItemName = new System.Windows.Forms.ColumnHeader();
            this.colCustomerGuid = new System.Windows.Forms.ColumnHeader();
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
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Supplies Requisition Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnSearchCustomer);
            this.grpFilter.Controls.Add(this.chkNotConvertedToInvoice);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.txtRequestDateFrom);
            this.grpFilter.Controls.Add(this.txtRequestDateTo);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label9);
            this.grpFilter.Controls.Add(this.btnSearchCustomerFilter);
            this.grpFilter.Controls.Add(this.txtCustomerFilter);
            this.grpFilter.Controls.Add(this.btnRefresh);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.txtName);
            this.grpFilter.Location = new System.Drawing.Point(4, 40);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1054, 101);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer.Location = new System.Drawing.Point(286, 70);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer.TabIndex = 8;
            this.btnSearchCustomer.Text = "...";
            this.btnSearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // chkNotConvertedToInvoice
            // 
            this.chkNotConvertedToInvoice.Checked = true;
            this.chkNotConvertedToInvoice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotConvertedToInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotConvertedToInvoice.Location = new System.Drawing.Point(334, 18);
            this.chkNotConvertedToInvoice.Name = "chkNotConvertedToInvoice";
            this.chkNotConvertedToInvoice.Size = new System.Drawing.Size(324, 19);
            this.chkNotConvertedToInvoice.TabIndex = 5;
            this.chkNotConvertedToInvoice.Text = "Show requisitions not converted to invoice only";
            this.chkNotConvertedToInvoice.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Request Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customer";
            // 
            // txtRequestDateFrom
            // 
            this.txtRequestDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestDateFrom.Location = new System.Drawing.Point(381, 72);
            this.txtRequestDateFrom.Name = "txtRequestDateFrom";
            this.txtRequestDateFrom.Size = new System.Drawing.Size(99, 23);
            this.txtRequestDateFrom.TabIndex = 12;
            // 
            // txtRequestDateTo
            // 
            this.txtRequestDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequestDateTo.Location = new System.Drawing.Point(518, 72);
            this.txtRequestDateTo.Name = "txtRequestDateTo";
            this.txtRequestDateTo.Size = new System.Drawing.Size(99, 23);
            this.txtRequestDateTo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(490, 75);
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
            this.label9.Location = new System.Drawing.Point(339, 75);
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
            this.btnSearchCustomerFilter.Location = new System.Drawing.Point(250, 42);
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
            this.txtCustomerFilter.Location = new System.Drawing.Point(14, 72);
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
            this.btnRefresh.Location = new System.Drawing.Point(628, 71);
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
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Reference Number Like...";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(170, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 23);
            this.txtName.TabIndex = 4;
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
            // lvwRequisitions
            // 
            this.lvwRequisitions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGuid,
            this.colOrganizationName,
            this.colReferenceNumber,
            this.colRequestDate,
            this.colRequestedBy,
            this.colApprovalDate,
            this.colApprovedBy,
            this.colItemName,
            this.colCustomerGuid});
            this.lvwRequisitions.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwRequisitions.FullRowSelect = true;
            this.lvwRequisitions.GridLines = true;
            this.lvwRequisitions.Location = new System.Drawing.Point(4, 152);
            this.lvwRequisitions.Name = "lvwRequisitions";
            this.lvwRequisitions.Size = new System.Drawing.Size(1054, 342);
            this.lvwRequisitions.TabIndex = 16;
            this.lvwRequisitions.UseCompatibleStateImageBehavior = false;
            this.lvwRequisitions.View = System.Windows.Forms.View.Details;
            this.lvwRequisitions.SelectedIndexChanged += new System.EventHandler(this.lvwRequisitions_SelectedIndexChanged_1);
            this.lvwRequisitions.DoubleClick += new System.EventHandler(this.lvwRequisitions_DoubleClick);
            // 
            // colGuid
            // 
            this.colGuid.Text = "Guid";
            this.colGuid.Width = 0;
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
            // colRequestDate
            // 
            this.colRequestDate.Text = "Request Date";
            this.colRequestDate.Width = 120;
            // 
            // colRequestedBy
            // 
            this.colRequestedBy.Text = "Requested By";
            this.colRequestedBy.Width = 150;
            // 
            // colApprovalDate
            // 
            this.colApprovalDate.Text = "Approval Date";
            this.colApprovalDate.Width = 118;
            // 
            // colApprovedBy
            // 
            this.colApprovedBy.Text = "Approved By";
            this.colApprovedBy.Width = 150;
            // 
            // colItemName
            // 
            this.colItemName.Text = "Item Name";
            this.colItemName.Width = 360;
            // 
            // colCustomerGuid
            // 
            this.colCustomerGuid.Text = "Customer Guid";
            this.colCustomerGuid.Width = 0;
            // 
            // frmSelectSuppliesRequisition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1099, 540);
            this.ControlBox = false;
            this.Controls.Add(this.lvwRequisitions);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectSuppliesRequisition";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart System";
            this.Load += new System.EventHandler(this.frmSelectSuppliesRequisition_Load);
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
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Button btnSearchCustomerFilter;
        private System.Windows.Forms.TextBox txtCustomerFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvwRequisitions;
        private System.Windows.Forms.ColumnHeader colGuid;
        private System.Windows.Forms.ColumnHeader colOrganizationName;
        private System.Windows.Forms.ColumnHeader colReferenceNumber;
        private System.Windows.Forms.ColumnHeader colRequestDate;
        private System.Windows.Forms.ColumnHeader colApprovedBy;
        private System.Windows.Forms.ColumnHeader colApprovalDate;
        private System.Windows.Forms.ColumnHeader colRequestedBy;
        private System.Windows.Forms.ColumnHeader colCustomerGuid;
        private System.Windows.Forms.TextBox txtRequestDateFrom;
        private System.Windows.Forms.TextBox txtRequestDateTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkNotConvertedToInvoice;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.ColumnHeader colItemName;
    }
}