namespace Pharma
{
    partial class frmStockCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockCard));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboStoreName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboStoreLocation = new System.Windows.Forms.ComboBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchManufacturerFilter1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.btnSearchManufacturer = new System.Windows.Forms.Button();
            this.txtManufacturerFilter = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grpReportType = new System.Windows.Forms.GroupBox();
            this.optOrganizationSpecific = new System.Windows.Forms.RadioButton();
            this.optStandard = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpReportType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(266, 391);
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
            this.btnPreview.Location = new System.Drawing.Point(170, 391);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 24);
            this.btnPreview.TabIndex = 51;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDateTo);
            this.groupBox1.Controls.Add(this.txtDateFrom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(8, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 66);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // txtDateTo
            // 
            this.txtDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTo.Location = new System.Drawing.Point(186, 33);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(154, 23);
            this.txtDateTo.TabIndex = 177;
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFrom.Location = new System.Drawing.Point(12, 33);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(154, 23);
            this.txtDateFrom.TabIndex = 176;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(186, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 16);
            this.label6.TabIndex = 148;
            this.label6.Text = "Date To";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(12, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 16);
            this.label9.TabIndex = 146;
            this.label9.Text = "Date From";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label3.Text = "    Stock Card";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboStoreName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboStoreLocation);
            this.groupBox2.Location = new System.Drawing.Point(8, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 72);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            // 
            // cboStoreName
            // 
            this.cboStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreName.FormattingEnabled = true;
            this.cboStoreName.Location = new System.Drawing.Point(186, 35);
            this.cboStoreName.Name = "cboStoreName";
            this.cboStoreName.Size = new System.Drawing.Size(154, 24);
            this.cboStoreName.TabIndex = 127;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 124;
            this.label8.Text = "Store Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(186, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 126;
            this.label7.Text = "Store Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(12, 35);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(154, 24);
            this.cboStoreLocation.TabIndex = 125;
            this.cboStoreLocation.SelectedIndexChanged += new System.EventHandler(this.cboStoreLocation_SelectedIndexChanged);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnSearchManufacturerFilter1);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Controls.Add(this.cboItem);
            this.grpFilter.Controls.Add(this.btnSearchManufacturer);
            this.grpFilter.Controls.Add(this.txtManufacturerFilter);
            this.grpFilter.Controls.Add(this.label13);
            this.grpFilter.Location = new System.Drawing.Point(8, 193);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(352, 110);
            this.grpFilter.TabIndex = 124;
            this.grpFilter.TabStop = false;
            // 
            // btnSearchManufacturerFilter1
            // 
            this.btnSearchManufacturerFilter1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturerFilter1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturerFilter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturerFilter1.Location = new System.Drawing.Point(306, 30);
            this.btnSearchManufacturerFilter1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturerFilter1.Name = "btnSearchManufacturerFilter1";
            this.btnSearchManufacturerFilter1.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturerFilter1.TabIndex = 182;
            this.btnSearchManufacturerFilter1.TabStop = false;
            this.btnSearchManufacturerFilter1.Text = "...";
            this.btnSearchManufacturerFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchManufacturerFilter1.UseVisualStyleBackColor = true;
            this.btnSearchManufacturerFilter1.Click += new System.EventHandler(this.btnSearchManufacturerFilter1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 151;
            this.label1.Text = "Item";
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(12, 78);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(292, 24);
            this.cboItem.TabIndex = 152;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // btnSearchManufacturer
            // 
            this.btnSearchManufacturer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchManufacturer.Image")));
            this.btnSearchManufacturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturer.Location = new System.Drawing.Point(274, 2);
            this.btnSearchManufacturer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturer.Name = "btnSearchManufacturer";
            this.btnSearchManufacturer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturer.TabIndex = 150;
            this.btnSearchManufacturer.TabStop = false;
            this.btnSearchManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchManufacturer.UseVisualStyleBackColor = true;
            this.btnSearchManufacturer.Visible = false;
            this.btnSearchManufacturer.Click += new System.EventHandler(this.btnSearchManufacturer_Click);
            // 
            // txtManufacturerFilter
            // 
            this.txtManufacturerFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtManufacturerFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturerFilter.Location = new System.Drawing.Point(12, 32);
            this.txtManufacturerFilter.Name = "txtManufacturerFilter";
            this.txtManufacturerFilter.Size = new System.Drawing.Size(292, 23);
            this.txtManufacturerFilter.TabIndex = 149;
            this.txtManufacturerFilter.TextChanged += new System.EventHandler(this.txtManufacturer_TextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 148;
            this.label13.Text = "Supplier";
            // 
            // grpReportType
            // 
            this.grpReportType.Controls.Add(this.optOrganizationSpecific);
            this.grpReportType.Controls.Add(this.optStandard);
            this.grpReportType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportType.Location = new System.Drawing.Point(8, 46);
            this.grpReportType.Name = "grpReportType";
            this.grpReportType.Size = new System.Drawing.Size(352, 60);
            this.grpReportType.TabIndex = 128;
            this.grpReportType.TabStop = false;
            this.grpReportType.Text = "Report Type";
            // 
            // optOrganizationSpecific
            // 
            this.optOrganizationSpecific.AutoSize = true;
            this.optOrganizationSpecific.BackColor = System.Drawing.Color.Transparent;
            this.optOrganizationSpecific.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optOrganizationSpecific.Location = new System.Drawing.Point(186, 26);
            this.optOrganizationSpecific.Name = "optOrganizationSpecific";
            this.optOrganizationSpecific.Size = new System.Drawing.Size(146, 20);
            this.optOrganizationSpecific.TabIndex = 1;
            this.optOrganizationSpecific.Text = "Organization Specific";
            this.optOrganizationSpecific.UseVisualStyleBackColor = false;
            // 
            // optStandard
            // 
            this.optStandard.AutoSize = true;
            this.optStandard.BackColor = System.Drawing.Color.Transparent;
            this.optStandard.Checked = true;
            this.optStandard.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optStandard.Location = new System.Drawing.Point(12, 28);
            this.optStandard.Name = "optStandard";
            this.optStandard.Size = new System.Drawing.Size(78, 20);
            this.optStandard.TabIndex = 0;
            this.optStandard.TabStop = true;
            this.optStandard.Text = "Standard";
            this.optStandard.UseVisualStyleBackColor = false;
            // 
            // frmStockCard
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(365, 429);
            this.Controls.Add(this.grpReportType);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStockCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Card";
            this.Load += new System.EventHandler(this.frmStockCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpReportType.ResumeLayout(false);
            this.grpReportType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboStoreName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboStoreLocation;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnSearchManufacturer;
        private System.Windows.Forms.TextBox txtManufacturerFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.GroupBox grpReportType;
        private System.Windows.Forms.RadioButton optOrganizationSpecific;
        private System.Windows.Forms.RadioButton optStandard;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.Button btnSearchManufacturerFilter1;
    }
}