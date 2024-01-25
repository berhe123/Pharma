namespace Pharma
{
    partial class frmCustomersProofReading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersProofReading));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.cboCustomerType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLocation = new System.Windows.Forms.ComboBox();
            this.grpDiscount = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCreditLimit = new System.Windows.Forms.TextBox();
            this.txtDiscountRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomerFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.chkSimpleList = new System.Windows.Forms.CheckBox();
            this.btnSearchCustomer1 = new System.Windows.Forms.Button();
            this.grpLocation.SuspendLayout();
            this.grpDiscount.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(266, 366);
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
            this.btnPreview.Location = new System.Drawing.Point(170, 366);
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
            this.line1.Size = new System.Drawing.Size(371, 1);
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
            this.label3.Size = new System.Drawing.Size(371, 36);
            this.label3.TabIndex = 121;
            this.label3.Text = "    Customer Proof Reading";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.cboCustomerType);
            this.grpLocation.Controls.Add(this.label8);
            this.grpLocation.Controls.Add(this.label7);
            this.grpLocation.Controls.Add(this.cboLocation);
            this.grpLocation.Enabled = false;
            this.grpLocation.Location = new System.Drawing.Point(8, 140);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(352, 120);
            this.grpLocation.TabIndex = 123;
            this.grpLocation.TabStop = false;
            // 
            // cboCustomerType
            // 
            this.cboCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomerType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustomerType.FormattingEnabled = true;
            this.cboCustomerType.Location = new System.Drawing.Point(12, 86);
            this.cboCustomerType.Name = "cboCustomerType";
            this.cboCustomerType.Size = new System.Drawing.Size(294, 24);
            this.cboCustomerType.TabIndex = 127;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 124;
            this.label8.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 126;
            this.label7.Text = "Customer Type";
            // 
            // cboLocation
            // 
            this.cboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocation.FormattingEnabled = true;
            this.cboLocation.Location = new System.Drawing.Point(12, 35);
            this.cboLocation.Name = "cboLocation";
            this.cboLocation.Size = new System.Drawing.Size(294, 24);
            this.cboLocation.TabIndex = 125;
            // 
            // grpDiscount
            // 
            this.grpDiscount.Controls.Add(this.label5);
            this.grpDiscount.Controls.Add(this.label4);
            this.grpDiscount.Controls.Add(this.txtCreditLimit);
            this.grpDiscount.Controls.Add(this.txtDiscountRate);
            this.grpDiscount.Controls.Add(this.label2);
            this.grpDiscount.Controls.Add(this.label1);
            this.grpDiscount.Enabled = false;
            this.grpDiscount.Location = new System.Drawing.Point(8, 265);
            this.grpDiscount.Name = "grpDiscount";
            this.grpDiscount.Size = new System.Drawing.Size(352, 90);
            this.grpDiscount.TabIndex = 124;
            this.grpDiscount.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 145;
            this.label5.Text = "Birr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.TabIndex = 144;
            this.label4.Text = "%";
            // 
            // txtCreditLimit
            // 
            this.txtCreditLimit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditLimit.Location = new System.Drawing.Point(132, 53);
            this.txtCreditLimit.Name = "txtCreditLimit";
            this.txtCreditLimit.Size = new System.Drawing.Size(84, 23);
            this.txtCreditLimit.TabIndex = 143;
            // 
            // txtDiscountRate
            // 
            this.txtDiscountRate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountRate.Location = new System.Drawing.Point(132, 25);
            this.txtDiscountRate.Name = "txtDiscountRate";
            this.txtDiscountRate.Size = new System.Drawing.Size(84, 23);
            this.txtDiscountRate.TabIndex = 142;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 128;
            this.label2.Text = "Credit Limit >=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = "Discount Rate >=";
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnSearchCustomer1);
            this.grpCustomer.Controls.Add(this.txtCustomerFilter);
            this.grpCustomer.Controls.Add(this.label6);
            this.grpCustomer.Controls.Add(this.btnSearchCustomer);
            this.grpCustomer.Location = new System.Drawing.Point(6, 48);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(352, 86);
            this.grpCustomer.TabIndex = 125;
            this.grpCustomer.TabStop = false;
            // 
            // txtCustomerFilter
            // 
            this.txtCustomerFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerFilter.Location = new System.Drawing.Point(12, 45);
            this.txtCustomerFilter.Name = "txtCustomerFilter";
            this.txtCustomerFilter.Size = new System.Drawing.Size(292, 23);
            this.txtCustomerFilter.TabIndex = 149;
            this.txtCustomerFilter.TextChanged += new System.EventHandler(this.txtCustomerFilter_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 151;
            this.label6.Text = "Customer";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer.Location = new System.Drawing.Point(262, 10);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer.TabIndex = 150;
            this.btnSearchCustomer.TabStop = false;
            this.btnSearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Visible = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // chkSimpleList
            // 
            this.chkSimpleList.Checked = true;
            this.chkSimpleList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSimpleList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSimpleList.Location = new System.Drawing.Point(20, 45);
            this.chkSimpleList.Name = "chkSimpleList";
            this.chkSimpleList.Size = new System.Drawing.Size(92, 21);
            this.chkSimpleList.TabIndex = 155;
            this.chkSimpleList.Text = "Simple List";
            this.chkSimpleList.UseVisualStyleBackColor = true;
            this.chkSimpleList.CheckedChanged += new System.EventHandler(this.chkSimpleList_CheckedChanged);
            // 
            // btnSearchCustomer1
            // 
            this.btnSearchCustomer1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer1.Location = new System.Drawing.Point(308, 42);
            this.btnSearchCustomer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer1.Name = "btnSearchCustomer1";
            this.btnSearchCustomer1.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer1.TabIndex = 180;
            this.btnSearchCustomer1.TabStop = false;
            this.btnSearchCustomer1.Text = "...";
            this.btnSearchCustomer1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomer1.UseVisualStyleBackColor = true;
            this.btnSearchCustomer1.Click += new System.EventHandler(this.btnSearchCustomer1_Click);
            // 
            // frmCustomersProofReading
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(366, 395);
            this.Controls.Add(this.chkSimpleList);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.grpDiscount);
            this.Controls.Add(this.grpLocation);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomersProofReading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Proof Reading";
            this.Load += new System.EventHandler(this.frmListOfCustomers_Load);
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.grpDiscount.ResumeLayout(false);
            this.grpDiscount.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.ComboBox cboCustomerType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboLocation;
        private System.Windows.Forms.GroupBox grpDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCreditLimit;
        private System.Windows.Forms.TextBox txtDiscountRate;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtCustomerFilter;
        private System.Windows.Forms.CheckBox chkSimpleList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSearchCustomer1;
    }
}