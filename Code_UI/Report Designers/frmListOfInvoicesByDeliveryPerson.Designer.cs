namespace Pharma
{
    partial class frmListOfInvoicesByDeliveryPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfInvoicesByDeliveryPerson));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.cboIssuedTo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDateToRequest = new System.Windows.Forms.TextBox();
            this.txtDateFromRequest = new System.Windows.Forms.TextBox();
            this.cboSettlementStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkRequestDate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer1 = new System.Windows.Forms.Button();
            this.txtCustomerFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.grpRequest.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(197, 286);
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
            this.btnPreview.Location = new System.Drawing.Point(101, 286);
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
            this.label3.Text = "    Payment Requests List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.cboIssuedTo);
            this.grpRequest.Controls.Add(this.label12);
            this.grpRequest.Controls.Add(this.txtDateToRequest);
            this.grpRequest.Controls.Add(this.txtDateFromRequest);
            this.grpRequest.Controls.Add(this.cboSettlementStatus);
            this.grpRequest.Controls.Add(this.label5);
            this.grpRequest.Controls.Add(this.chkRequestDate);
            this.grpRequest.Controls.Add(this.label1);
            this.grpRequest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRequest.Location = new System.Drawing.Point(8, 130);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(406, 140);
            this.grpRequest.TabIndex = 125;
            this.grpRequest.TabStop = false;
            // 
            // cboIssuedTo
            // 
            this.cboIssuedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIssuedTo.FormattingEnabled = true;
            this.cboIssuedTo.Location = new System.Drawing.Point(209, 44);
            this.cboIssuedTo.Name = "cboIssuedTo";
            this.cboIssuedTo.Size = new System.Drawing.Size(193, 24);
            this.cboIssuedTo.TabIndex = 177;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 16);
            this.label12.TabIndex = 176;
            this.label12.Text = "Invoice Delivered By";
            // 
            // txtDateToRequest
            // 
            this.txtDateToRequest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateToRequest.Location = new System.Drawing.Point(209, 101);
            this.txtDateToRequest.Name = "txtDateToRequest";
            this.txtDateToRequest.Size = new System.Drawing.Size(193, 23);
            this.txtDateToRequest.TabIndex = 175;
            // 
            // txtDateFromRequest
            // 
            this.txtDateFromRequest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFromRequest.Location = new System.Drawing.Point(12, 101);
            this.txtDateFromRequest.Name = "txtDateFromRequest";
            this.txtDateFromRequest.Size = new System.Drawing.Size(193, 23);
            this.txtDateFromRequest.TabIndex = 174;
            // 
            // cboSettlementStatus
            // 
            this.cboSettlementStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSettlementStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSettlementStatus.FormattingEnabled = true;
            this.cboSettlementStatus.Location = new System.Drawing.Point(10, 44);
            this.cboSettlementStatus.Name = "cboSettlementStatus";
            this.cboSettlementStatus.Size = new System.Drawing.Size(193, 24);
            this.cboSettlementStatus.TabIndex = 163;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 162;
            this.label5.Text = "Settlement Status";
            // 
            // chkRequestDate
            // 
            this.chkRequestDate.Checked = true;
            this.chkRequestDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRequestDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRequestDate.Location = new System.Drawing.Point(12, 84);
            this.chkRequestDate.Name = "chkRequestDate";
            this.chkRequestDate.Size = new System.Drawing.Size(144, 21);
            this.chkRequestDate.TabIndex = 160;
            this.chkRequestDate.Text = "Invoice Date From";
            this.chkRequestDate.UseVisualStyleBackColor = true;
            this.chkRequestDate.CheckedChanged += new System.EventHandler(this.chkRequestDate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(209, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 161;
            this.label1.Text = "Invoice Date To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnSearchCustomer1);
            this.grpCustomer.Controls.Add(this.txtCustomerFilter);
            this.grpCustomer.Controls.Add(this.label6);
            this.grpCustomer.Controls.Add(this.btnSearchCustomer);
            this.grpCustomer.Location = new System.Drawing.Point(8, 44);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(406, 78);
            this.grpCustomer.TabIndex = 127;
            this.grpCustomer.TabStop = false;
            // 
            // btnSearchCustomer1
            // 
            this.btnSearchCustomer1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer1.Location = new System.Drawing.Point(368, 35);
            this.btnSearchCustomer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer1.Name = "btnSearchCustomer1";
            this.btnSearchCustomer1.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer1.TabIndex = 181;
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
            this.txtCustomerFilter.Location = new System.Drawing.Point(10, 40);
            this.txtCustomerFilter.Name = "txtCustomerFilter";
            this.txtCustomerFilter.Size = new System.Drawing.Size(350, 23);
            this.txtCustomerFilter.TabIndex = 159;
            this.txtCustomerFilter.TextChanged += new System.EventHandler(this.txtCustomerFilter_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 163;
            this.label6.Text = "Customer";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer.Location = new System.Drawing.Point(260, 10);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer.TabIndex = 160;
            this.btnSearchCustomer.TabStop = false;
            this.btnSearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Visible = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // frmListOfInvoicesByDeliveryPerson
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(420, 322);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpRequest);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfInvoicesByDeliveryPerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Requests List";
            this.Load += new System.EventHandler(this.frmListOfCustomers_Load);
            this.grpRequest.ResumeLayout(false);
            this.grpRequest.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpRequest;
        private System.Windows.Forms.CheckBox chkRequestDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtCustomerFilter;
        private System.Windows.Forms.ComboBox cboSettlementStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateToRequest;
        private System.Windows.Forms.TextBox txtDateFromRequest;
        private System.Windows.Forms.Button btnSearchCustomer1;
        private System.Windows.Forms.ComboBox cboIssuedTo;
        private System.Windows.Forms.Label label12;
    }
}