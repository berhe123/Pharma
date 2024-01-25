namespace Pharma
{
    partial class frmListOfItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfItems));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpManufacturer = new System.Windows.Forms.GroupBox();
            this.btnSearchManufacturerFilter1 = new System.Windows.Forms.Button();
            this.btnSearchManufacturer = new System.Windows.Forms.Button();
            this.txtManufacturerFilter = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboItemCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpReorderLevel = new System.Windows.Forms.GroupBox();
            this.txtReorderLevel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpReportType = new System.Windows.Forms.GroupBox();
            this.optStockValue = new System.Windows.Forms.RadioButton();
            this.optItemQuantityBelowReorderLevel = new System.Windows.Forms.RadioButton();
            this.optPriceList = new System.Windows.Forms.RadioButton();
            this.optSimpleList = new System.Windows.Forms.RadioButton();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.cboStoreName = new System.Windows.Forms.ComboBox();
            this.cboStoreLocation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpExpiry = new System.Windows.Forms.GroupBox();
            this.grpManufacturer.SuspendLayout();
            this.grpReorderLevel.SuspendLayout();
            this.grpReportType.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(488, 312);
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
            this.btnPreview.Location = new System.Drawing.Point(392, 312);
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
            this.line1.Size = new System.Drawing.Size(660, 1);
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
            this.label3.Size = new System.Drawing.Size(592, 36);
            this.label3.TabIndex = 121;
            this.label3.Text = "    Items List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpManufacturer
            // 
            this.grpManufacturer.Controls.Add(this.btnSearchManufacturerFilter1);
            this.grpManufacturer.Controls.Add(this.btnSearchManufacturer);
            this.grpManufacturer.Controls.Add(this.txtManufacturerFilter);
            this.grpManufacturer.Controls.Add(this.label13);
            this.grpManufacturer.Controls.Add(this.cboItemCategory);
            this.grpManufacturer.Controls.Add(this.label7);
            this.grpManufacturer.Location = new System.Drawing.Point(8, 108);
            this.grpManufacturer.Name = "grpManufacturer";
            this.grpManufacturer.Size = new System.Drawing.Size(352, 115);
            this.grpManufacturer.TabIndex = 123;
            this.grpManufacturer.TabStop = false;
            // 
            // btnSearchManufacturerFilter1
            // 
            this.btnSearchManufacturerFilter1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturerFilter1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturerFilter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturerFilter1.Location = new System.Drawing.Point(308, 28);
            this.btnSearchManufacturerFilter1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturerFilter1.Name = "btnSearchManufacturerFilter1";
            this.btnSearchManufacturerFilter1.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturerFilter1.TabIndex = 180;
            this.btnSearchManufacturerFilter1.TabStop = false;
            this.btnSearchManufacturerFilter1.Text = "...";
            this.btnSearchManufacturerFilter1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchManufacturerFilter1.UseVisualStyleBackColor = true;
            this.btnSearchManufacturerFilter1.Click += new System.EventHandler(this.btnSearchManufacturerFilter1_Click);
            // 
            // btnSearchManufacturer
            // 
            this.btnSearchManufacturer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchManufacturer.Image")));
            this.btnSearchManufacturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturer.Location = new System.Drawing.Point(274, 6);
            this.btnSearchManufacturer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturer.Name = "btnSearchManufacturer";
            this.btnSearchManufacturer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturer.TabIndex = 153;
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
            this.txtManufacturerFilter.Size = new System.Drawing.Size(294, 23);
            this.txtManufacturerFilter.TabIndex = 152;
            this.txtManufacturerFilter.TextChanged += new System.EventHandler(this.txtManufacturerFilter_TextChanged);
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 16);
            this.label13.TabIndex = 151;
            this.label13.Text = "Supplier";
            // 
            // cboItemCategory
            // 
            this.cboItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemCategory.FormattingEnabled = true;
            this.cboItemCategory.Location = new System.Drawing.Point(12, 80);
            this.cboItemCategory.Name = "cboItemCategory";
            this.cboItemCategory.Size = new System.Drawing.Size(294, 24);
            this.cboItemCategory.TabIndex = 127;
            this.cboItemCategory.SelectedIndexChanged += new System.EventHandler(this.cboItemCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 126;
            this.label7.Text = "Item Category";
            // 
            // grpReorderLevel
            // 
            this.grpReorderLevel.Controls.Add(this.txtReorderLevel);
            this.grpReorderLevel.Controls.Add(this.label1);
            this.grpReorderLevel.Location = new System.Drawing.Point(8, 230);
            this.grpReorderLevel.Name = "grpReorderLevel";
            this.grpReorderLevel.Size = new System.Drawing.Size(352, 61);
            this.grpReorderLevel.TabIndex = 124;
            this.grpReorderLevel.TabStop = false;
            // 
            // txtReorderLevel
            // 
            this.txtReorderLevel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReorderLevel.Location = new System.Drawing.Point(184, 24);
            this.txtReorderLevel.Name = "txtReorderLevel";
            this.txtReorderLevel.Size = new System.Drawing.Size(84, 23);
            this.txtReorderLevel.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 127;
            this.label1.Text = "Reorder Quantity Level >=";
            // 
            // grpReportType
            // 
            this.grpReportType.Controls.Add(this.optStockValue);
            this.grpReportType.Controls.Add(this.optItemQuantityBelowReorderLevel);
            this.grpReportType.Controls.Add(this.optPriceList);
            this.grpReportType.Controls.Add(this.optSimpleList);
            this.grpReportType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportType.Location = new System.Drawing.Point(8, 42);
            this.grpReportType.Name = "grpReportType";
            this.grpReportType.Size = new System.Drawing.Size(576, 60);
            this.grpReportType.TabIndex = 125;
            this.grpReportType.TabStop = false;
            this.grpReportType.Text = "Report Type";
            // 
            // optStockValue
            // 
            this.optStockValue.AutoSize = true;
            this.optStockValue.BackColor = System.Drawing.Color.Transparent;
            this.optStockValue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optStockValue.Location = new System.Drawing.Point(457, 28);
            this.optStockValue.Name = "optStockValue";
            this.optStockValue.Size = new System.Drawing.Size(93, 20);
            this.optStockValue.TabIndex = 3;
            this.optStockValue.Text = "Stock Value";
            this.optStockValue.UseVisualStyleBackColor = false;
            this.optStockValue.CheckedChanged += new System.EventHandler(this.optStockValue_CheckedChanged);
            // 
            // optItemQuantityBelowReorderLevel
            // 
            this.optItemQuantityBelowReorderLevel.AutoSize = true;
            this.optItemQuantityBelowReorderLevel.BackColor = System.Drawing.Color.Transparent;
            this.optItemQuantityBelowReorderLevel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optItemQuantityBelowReorderLevel.Location = new System.Drawing.Point(247, 28);
            this.optItemQuantityBelowReorderLevel.Name = "optItemQuantityBelowReorderLevel";
            this.optItemQuantityBelowReorderLevel.Size = new System.Drawing.Size(179, 20);
            this.optItemQuantityBelowReorderLevel.TabIndex = 2;
            this.optItemQuantityBelowReorderLevel.Text = "Items Below Reorder Level";
            this.optItemQuantityBelowReorderLevel.UseVisualStyleBackColor = false;
            this.optItemQuantityBelowReorderLevel.CheckedChanged += new System.EventHandler(this.optItemQuantityBelowReorderLevel_CheckedChanged);
            // 
            // optPriceList
            // 
            this.optPriceList.AutoSize = true;
            this.optPriceList.BackColor = System.Drawing.Color.Transparent;
            this.optPriceList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optPriceList.Location = new System.Drawing.Point(139, 28);
            this.optPriceList.Name = "optPriceList";
            this.optPriceList.Size = new System.Drawing.Size(77, 20);
            this.optPriceList.TabIndex = 1;
            this.optPriceList.Text = "Price List";
            this.optPriceList.UseVisualStyleBackColor = false;
            this.optPriceList.CheckedChanged += new System.EventHandler(this.optPriceList_CheckedChanged);
            // 
            // optSimpleList
            // 
            this.optSimpleList.AutoSize = true;
            this.optSimpleList.BackColor = System.Drawing.Color.Transparent;
            this.optSimpleList.Checked = true;
            this.optSimpleList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optSimpleList.Location = new System.Drawing.Point(12, 28);
            this.optSimpleList.Name = "optSimpleList";
            this.optSimpleList.Size = new System.Drawing.Size(96, 20);
            this.optSimpleList.TabIndex = 0;
            this.optSimpleList.TabStop = true;
            this.optSimpleList.Text = "List of Items";
            this.optSimpleList.UseVisualStyleBackColor = false;
            this.optSimpleList.CheckedChanged += new System.EventHandler(this.optSimpleList_CheckedChanged);
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.cboStoreName);
            this.grpLocation.Controls.Add(this.cboStoreLocation);
            this.grpLocation.Controls.Add(this.label8);
            this.grpLocation.Controls.Add(this.label2);
            this.grpLocation.Enabled = false;
            this.grpLocation.Location = new System.Drawing.Point(364, 108);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(218, 115);
            this.grpLocation.TabIndex = 126;
            this.grpLocation.TabStop = false;
            // 
            // cboStoreName
            // 
            this.cboStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreName.FormattingEnabled = true;
            this.cboStoreName.Location = new System.Drawing.Point(14, 80);
            this.cboStoreName.Name = "cboStoreName";
            this.cboStoreName.Size = new System.Drawing.Size(194, 24);
            this.cboStoreName.TabIndex = 127;
            // 
            // cboStoreLocation
            // 
            this.cboStoreLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoreLocation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStoreLocation.FormattingEnabled = true;
            this.cboStoreLocation.Location = new System.Drawing.Point(12, 31);
            this.cboStoreLocation.Name = "cboStoreLocation";
            this.cboStoreLocation.Size = new System.Drawing.Size(194, 24);
            this.cboStoreLocation.TabIndex = 125;
            this.cboStoreLocation.SelectedIndexChanged += new System.EventHandler(this.cboStoreLocation_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 124;
            this.label8.Text = "Store Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 126;
            this.label2.Text = "Store Name";
            // 
            // grpExpiry
            // 
            this.grpExpiry.Location = new System.Drawing.Point(364, 229);
            this.grpExpiry.Name = "grpExpiry";
            this.grpExpiry.Size = new System.Drawing.Size(218, 62);
            this.grpExpiry.TabIndex = 127;
            this.grpExpiry.TabStop = false;
            // 
            // frmListOfItems
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(591, 344);
            this.Controls.Add(this.grpExpiry);
            this.Controls.Add(this.grpLocation);
            this.Controls.Add(this.grpReportType);
            this.Controls.Add(this.grpReorderLevel);
            this.Controls.Add(this.grpManufacturer);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items List";
            this.Load += new System.EventHandler(this.frmListOfItems_Load);
            this.grpManufacturer.ResumeLayout(false);
            this.grpManufacturer.PerformLayout();
            this.grpReorderLevel.ResumeLayout(false);
            this.grpReorderLevel.PerformLayout();
            this.grpReportType.ResumeLayout(false);
            this.grpReportType.PerformLayout();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpManufacturer;
        private System.Windows.Forms.ComboBox cboItemCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReorderLevel;
        private System.Windows.Forms.Button btnSearchManufacturer;
        private System.Windows.Forms.TextBox txtManufacturerFilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpReportType;
        private System.Windows.Forms.RadioButton optSimpleList;
        private System.Windows.Forms.RadioButton optItemQuantityBelowReorderLevel;
        private System.Windows.Forms.RadioButton optPriceList;
        private System.Windows.Forms.GroupBox grpLocation;
        private System.Windows.Forms.ComboBox cboStoreName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStoreLocation;
        private System.Windows.Forms.Button btnSearchManufacturerFilter1;
        private System.Windows.Forms.GroupBox grpReorderLevel;
        private System.Windows.Forms.GroupBox grpExpiry;
        private System.Windows.Forms.RadioButton optStockValue;
    }
}