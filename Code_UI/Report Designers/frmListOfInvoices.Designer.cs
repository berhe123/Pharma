namespace Pharma
{
    partial class frmListOfInvoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfInvoices));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer1 = new System.Windows.Forms.Button();
            this.txtCustomerFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.txtDateToInvoice = new System.Windows.Forms.TextBox();
            this.txtDateFromInvoice = new System.Windows.Forms.TextBox();
            this.cboInvoiceType = new System.Windows.Forms.ComboBox();
            this.chkInvoiceDate = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDelivery = new System.Windows.Forms.GroupBox();
            this.txtDateToDelivery = new System.Windows.Forms.TextBox();
            this.txtDateFromDelivery = new System.Windows.Forms.TextBox();
            this.cboDeliveryStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkDeliveryDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpReportType = new System.Windows.Forms.GroupBox();
            this.optCustomerInvoiceList = new System.Windows.Forms.RadioButton();
            this.optCustomerAggregate = new System.Windows.Forms.RadioButton();
            this.optSimpleList = new System.Windows.Forms.RadioButton();
            this.grpCustomer.SuspendLayout();
            this.grpInvoice.SuspendLayout();
            this.grpDelivery.SuspendLayout();
            this.grpReportType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(306, 466);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 24);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(210, 466);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 24);
            this.btnPreview.TabIndex = 51;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(0, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(426, 1);
            this.line1.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 36);
            this.label3.TabIndex = 121;
            this.label3.Text = "    Invoices List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnSearchCustomer1);
            this.grpCustomer.Controls.Add(this.txtCustomerFilter);
            this.grpCustomer.Controls.Add(this.label4);
            this.grpCustomer.Controls.Add(this.btnSearchCustomer);
            this.grpCustomer.Location = new System.Drawing.Point(4, 138);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(396, 74);
            this.grpCustomer.TabIndex = 123;
            this.grpCustomer.TabStop = false;
            // 
            // btnSearchCustomer1
            // 
            this.btnSearchCustomer1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer1.Location = new System.Drawing.Point(352, 40);
            this.btnSearchCustomer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer1.Name = "btnSearchCustomer1";
            this.btnSearchCustomer1.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer1.TabIndex = 179;
            this.btnSearchCustomer1.TabStop = false;
            this.btnSearchCustomer1.Text = "...";
            this.btnSearchCustomer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomer1.UseVisualStyleBackColor = true;
            this.btnSearchCustomer1.Click += new System.EventHandler(this.btnSearchCustomer1_Click);
            // 
            // txtCustomerFilter
            // 
            this.txtCustomerFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFilter.Location = new System.Drawing.Point(12, 43);
            this.txtCustomerFilter.Name = "txtCustomerFilter";
            this.txtCustomerFilter.Size = new System.Drawing.Size(338, 23);
            this.txtCustomerFilter.TabIndex = 156;
            this.txtCustomerFilter.TextChanged += new System.EventHandler(this.txtCustomerFilter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 163;
            this.label4.Text = "Customer";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer.Location = new System.Drawing.Point(320, 10);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer.TabIndex = 157;
            this.btnSearchCustomer.TabStop = false;
            this.btnSearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Visible = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.txtDateToInvoice);
            this.grpInvoice.Controls.Add(this.txtDateFromInvoice);
            this.grpInvoice.Controls.Add(this.cboInvoiceType);
            this.grpInvoice.Controls.Add(this.chkInvoiceDate);
            this.grpInvoice.Controls.Add(this.label6);
            this.grpInvoice.Controls.Add(this.label1);
            this.grpInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInvoice.Location = new System.Drawing.Point(4, 215);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(396, 118);
            this.grpInvoice.TabIndex = 125;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Invoice";
            // 
            // txtDateToInvoice
            // 
            this.txtDateToInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateToInvoice.Location = new System.Drawing.Point(196, 87);
            this.txtDateToInvoice.Name = "txtDateToInvoice";
            this.txtDateToInvoice.Size = new System.Drawing.Size(154, 23);
            this.txtDateToInvoice.TabIndex = 171;
            // 
            // txtDateFromInvoice
            // 
            this.txtDateFromInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFromInvoice.Location = new System.Drawing.Point(14, 87);
            this.txtDateFromInvoice.Name = "txtDateFromInvoice";
            this.txtDateFromInvoice.Size = new System.Drawing.Size(154, 23);
            this.txtDateFromInvoice.TabIndex = 170;
            // 
            // cboInvoiceType
            // 
            this.cboInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoiceType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInvoiceType.FormattingEnabled = true;
            this.cboInvoiceType.Location = new System.Drawing.Point(14, 40);
            this.cboInvoiceType.Name = "cboInvoiceType";
            this.cboInvoiceType.Size = new System.Drawing.Size(156, 24);
            this.cboInvoiceType.TabIndex = 129;
            // 
            // chkInvoiceDate
            // 
            this.chkInvoiceDate.Checked = true;
            this.chkInvoiceDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInvoiceDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvoiceDate.Location = new System.Drawing.Point(14, 70);
            this.chkInvoiceDate.Name = "chkInvoiceDate";
            this.chkInvoiceDate.Size = new System.Drawing.Size(88, 21);
            this.chkInvoiceDate.TabIndex = 160;
            this.chkInvoiceDate.Text = "Date From";
            this.chkInvoiceDate.UseVisualStyleBackColor = true;
            this.chkInvoiceDate.CheckedChanged += new System.EventHandler(this.chkInvoiceDate_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 162;
            this.label6.Text = "Type";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(196, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 161;
            this.label1.Text = "Date To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpDelivery
            // 
            this.grpDelivery.Controls.Add(this.txtDateToDelivery);
            this.grpDelivery.Controls.Add(this.txtDateFromDelivery);
            this.grpDelivery.Controls.Add(this.cboDeliveryStatus);
            this.grpDelivery.Controls.Add(this.label5);
            this.grpDelivery.Controls.Add(this.chkDeliveryDate);
            this.grpDelivery.Controls.Add(this.label2);
            this.grpDelivery.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDelivery.Location = new System.Drawing.Point(4, 337);
            this.grpDelivery.Name = "grpDelivery";
            this.grpDelivery.Size = new System.Drawing.Size(396, 118);
            this.grpDelivery.TabIndex = 126;
            this.grpDelivery.TabStop = false;
            this.grpDelivery.Text = "Delivery";
            // 
            // txtDateToDelivery
            // 
            this.txtDateToDelivery.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateToDelivery.Location = new System.Drawing.Point(196, 86);
            this.txtDateToDelivery.Name = "txtDateToDelivery";
            this.txtDateToDelivery.Size = new System.Drawing.Size(154, 23);
            this.txtDateToDelivery.TabIndex = 171;
            // 
            // txtDateFromDelivery
            // 
            this.txtDateFromDelivery.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFromDelivery.Location = new System.Drawing.Point(14, 86);
            this.txtDateFromDelivery.Name = "txtDateFromDelivery";
            this.txtDateFromDelivery.Size = new System.Drawing.Size(154, 23);
            this.txtDateFromDelivery.TabIndex = 170;
            // 
            // cboDeliveryStatus
            // 
            this.cboDeliveryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeliveryStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeliveryStatus.FormattingEnabled = true;
            this.cboDeliveryStatus.Location = new System.Drawing.Point(14, 39);
            this.cboDeliveryStatus.Name = "cboDeliveryStatus";
            this.cboDeliveryStatus.Size = new System.Drawing.Size(156, 24);
            this.cboDeliveryStatus.TabIndex = 129;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 128;
            this.label5.Text = "Status";
            // 
            // chkDeliveryDate
            // 
            this.chkDeliveryDate.Checked = true;
            this.chkDeliveryDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeliveryDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeliveryDate.Location = new System.Drawing.Point(14, 69);
            this.chkDeliveryDate.Name = "chkDeliveryDate";
            this.chkDeliveryDate.Size = new System.Drawing.Size(88, 21);
            this.chkDeliveryDate.TabIndex = 161;
            this.chkDeliveryDate.Text = "Date From";
            this.chkDeliveryDate.UseVisualStyleBackColor = true;
            this.chkDeliveryDate.CheckedChanged += new System.EventHandler(this.chkDeliveryDate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(196, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 152;
            this.label2.Text = "Date To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpReportType
            // 
            this.grpReportType.Controls.Add(this.optCustomerInvoiceList);
            this.grpReportType.Controls.Add(this.optCustomerAggregate);
            this.grpReportType.Controls.Add(this.optSimpleList);
            this.grpReportType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportType.Location = new System.Drawing.Point(4, 41);
            this.grpReportType.Name = "grpReportType";
            this.grpReportType.Size = new System.Drawing.Size(396, 93);
            this.grpReportType.TabIndex = 127;
            this.grpReportType.TabStop = false;
            this.grpReportType.Text = "Report Type";
            // 
            // optCustomerInvoiceList
            // 
            this.optCustomerInvoiceList.AutoSize = true;
            this.optCustomerInvoiceList.BackColor = System.Drawing.Color.Transparent;
            this.optCustomerInvoiceList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCustomerInvoiceList.Location = new System.Drawing.Point(159, 58);
            this.optCustomerInvoiceList.Name = "optCustomerInvoiceList";
            this.optCustomerInvoiceList.Size = new System.Drawing.Size(199, 20);
            this.optCustomerInvoiceList.TabIndex = 2;
            this.optCustomerInvoiceList.Text = "List of Invoices With Customer";
            this.optCustomerInvoiceList.UseVisualStyleBackColor = false;
            this.optCustomerInvoiceList.CheckedChanged += new System.EventHandler(this.optCustomerInvoiceList_CheckedChanged);
            // 
            // optCustomerAggregate
            // 
            this.optCustomerAggregate.AutoSize = true;
            this.optCustomerAggregate.BackColor = System.Drawing.Color.Transparent;
            this.optCustomerAggregate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optCustomerAggregate.Location = new System.Drawing.Point(159, 26);
            this.optCustomerAggregate.Name = "optCustomerAggregate";
            this.optCustomerAggregate.Size = new System.Drawing.Size(218, 20);
            this.optCustomerAggregate.TabIndex = 1;
            this.optCustomerAggregate.Text = "Invoices Aggregated by Customer";
            this.optCustomerAggregate.UseVisualStyleBackColor = false;
            this.optCustomerAggregate.CheckedChanged += new System.EventHandler(this.optCustomerAggregate_CheckedChanged);
            // 
            // optSimpleList
            // 
            this.optSimpleList.AutoSize = true;
            this.optSimpleList.BackColor = System.Drawing.Color.Transparent;
            this.optSimpleList.Checked = true;
            this.optSimpleList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSimpleList.Location = new System.Drawing.Point(12, 26);
            this.optSimpleList.Name = "optSimpleList";
            this.optSimpleList.Size = new System.Drawing.Size(110, 20);
            this.optSimpleList.TabIndex = 0;
            this.optSimpleList.TabStop = true;
            this.optSimpleList.Text = "List of Invoices";
            this.optSimpleList.UseVisualStyleBackColor = false;
            this.optSimpleList.CheckedChanged += new System.EventHandler(this.optSimpleList_CheckedChanged);
            // 
            // frmListOfInvoices
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(408, 499);
            this.Controls.Add(this.grpReportType);
            this.Controls.Add(this.grpDelivery);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices List";
            this.Load += new System.EventHandler(this.frmListOfCustomers_Load);
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.grpDelivery.ResumeLayout(false);
            this.grpDelivery.PerformLayout();
            this.grpReportType.ResumeLayout(false);
            this.grpReportType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.ComboBox cboInvoiceType;
        private System.Windows.Forms.GroupBox grpDelivery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDeliveryStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtCustomerFilter;
        private System.Windows.Forms.CheckBox chkInvoiceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkDeliveryDate;
        private System.Windows.Forms.GroupBox grpReportType;
        private System.Windows.Forms.RadioButton optCustomerAggregate;
        private System.Windows.Forms.RadioButton optSimpleList;
        private System.Windows.Forms.RadioButton optCustomerInvoiceList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateToInvoice;
        private System.Windows.Forms.TextBox txtDateFromInvoice;
        private System.Windows.Forms.TextBox txtDateToDelivery;
        private System.Windows.Forms.TextBox txtDateFromDelivery;
        private System.Windows.Forms.Button btnSearchCustomer1;
    }
}