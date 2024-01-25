namespace Pharma
{
    partial class frmSelectProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectProduct));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchManufacturer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenericNameFilter = new System.Windows.Forms.TextBox();
            this.txtBrandNameFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchManufacturerFilter = new System.Windows.Forms.Button();
            this.txtManufacturerFilter = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
            this.lvwProducts = new System.Windows.Forms.ListView();
            this.colGuid = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerGuid = new System.Windows.Forms.ColumnHeader();
            this.colProductsManufacturer = new System.Windows.Forms.ColumnHeader();
            this.colProductsBrandname = new System.Windows.Forms.ColumnHeader();
            this.colProductsGenericname = new System.Windows.Forms.ColumnHeader();
            this.colProductsStatus = new System.Windows.Forms.ColumnHeader();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(295, 506);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(84, 26);
            this.btnSelect.TabIndex = 14;
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
            this.btnClose.Location = new System.Drawing.Point(394, 506);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 26);
            this.btnClose.TabIndex = 15;
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
            this.label1.Size = new System.Drawing.Size(490, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Product Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnSearchManufacturer);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.txtGenericNameFilter);
            this.grpFilter.Controls.Add(this.txtBrandNameFilter);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.btnSearchManufacturerFilter);
            this.grpFilter.Controls.Add(this.txtManufacturerFilter);
            this.grpFilter.Controls.Add(this.btnRefresh);
            this.grpFilter.Location = new System.Drawing.Point(4, 40);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(474, 136);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // btnSearchManufacturer
            // 
            this.btnSearchManufacturer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturer.Location = new System.Drawing.Point(284, 38);
            this.btnSearchManufacturer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturer.Name = "btnSearchManufacturer";
            this.btnSearchManufacturer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturer.TabIndex = 5;
            this.btnSearchManufacturer.TabStop = false;
            this.btnSearchManufacturer.Text = "...";
            this.btnSearchManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchManufacturer.UseVisualStyleBackColor = true;
            this.btnSearchManufacturer.Click += new System.EventHandler(this.btnSearchManufacturer_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manufacturer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGenericNameFilter
            // 
            this.txtGenericNameFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenericNameFilter.Location = new System.Drawing.Point(168, 99);
            this.txtGenericNameFilter.Name = "txtGenericNameFilter";
            this.txtGenericNameFilter.Size = new System.Drawing.Size(148, 23);
            this.txtGenericNameFilter.TabIndex = 10;
            // 
            // txtBrandNameFilter
            // 
            this.txtBrandNameFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandNameFilter.Location = new System.Drawing.Point(10, 99);
            this.txtBrandNameFilter.Name = "txtBrandNameFilter";
            this.txtBrandNameFilter.Size = new System.Drawing.Size(148, 23);
            this.txtBrandNameFilter.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Brand Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(168, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Generic Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearchManufacturerFilter
            // 
            this.btnSearchManufacturerFilter.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturerFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchManufacturerFilter.Image")));
            this.btnSearchManufacturerFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturerFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturerFilter.Location = new System.Drawing.Point(368, 36);
            this.btnSearchManufacturerFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturerFilter.Name = "btnSearchManufacturerFilter";
            this.btnSearchManufacturerFilter.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturerFilter.TabIndex = 6;
            this.btnSearchManufacturerFilter.TabStop = false;
            this.btnSearchManufacturerFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchManufacturerFilter.UseVisualStyleBackColor = true;
            this.btnSearchManufacturerFilter.Visible = false;
            this.btnSearchManufacturerFilter.Click += new System.EventHandler(this.btnSearchManufacturerFilter_Click);
            // 
            // txtManufacturerFilter
            // 
            this.txtManufacturerFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtManufacturerFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturerFilter.Location = new System.Drawing.Point(11, 41);
            this.txtManufacturerFilter.Name = "txtManufacturerFilter";
            this.txtManufacturerFilter.Size = new System.Drawing.Size(272, 23);
            this.txtManufacturerFilter.TabIndex = 4;
            this.txtManufacturerFilter.TextChanged += new System.EventHandler(this.txtManufacturerFilter_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Pharma.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(347, 97);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 24);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(0, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(490, 1);
            this.line1.TabIndex = 1;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(4, 500);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(492, 1);
            this.line3.TabIndex = 13;
            // 
            // lvwProducts
            // 
            this.lvwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGuid,
            this.colManufacturerGuid,
            this.colProductsManufacturer,
            this.colProductsBrandname,
            this.colProductsGenericname,
            this.colProductsStatus});
            this.lvwProducts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwProducts.FullRowSelect = true;
            this.lvwProducts.GridLines = true;
            this.lvwProducts.Location = new System.Drawing.Point(4, 182);
            this.lvwProducts.MultiSelect = false;
            this.lvwProducts.Name = "lvwProducts";
            this.lvwProducts.Size = new System.Drawing.Size(474, 309);
            this.lvwProducts.TabIndex = 12;
            this.lvwProducts.UseCompatibleStateImageBehavior = false;
            this.lvwProducts.View = System.Windows.Forms.View.Details;
            this.lvwProducts.SelectedIndexChanged += new System.EventHandler(this.lvwProducts_SelectedIndexChanged);
            this.lvwProducts.DoubleClick += new System.EventHandler(this.lvwProducts_DoubleClick);
            // 
            // colGuid
            // 
            this.colGuid.Text = "Guid";
            this.colGuid.Width = 0;
            // 
            // colManufacturerGuid
            // 
            this.colManufacturerGuid.Text = "Manufacturer Guid";
            this.colManufacturerGuid.Width = 0;
            // 
            // colProductsManufacturer
            // 
            this.colProductsManufacturer.Text = "Manufacturer";
            this.colProductsManufacturer.Width = 150;
            // 
            // colProductsBrandname
            // 
            this.colProductsBrandname.Text = "Brand Name";
            this.colProductsBrandname.Width = 150;
            // 
            // colProductsGenericname
            // 
            this.colProductsGenericname.Text = "Generic Name";
            this.colProductsGenericname.Width = 150;
            // 
            // colProductsStatus
            // 
            this.colProductsStatus.Text = "Status";
            this.colProductsStatus.Width = 0;
            // 
            // frmSelectProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(483, 540);
            this.ControlBox = false;
            this.Controls.Add(this.lvwProducts);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectProduct";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart System";
            this.Load += new System.EventHandler(this.frmSelectProduct_Load);
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
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Button btnSearchManufacturerFilter;
        private System.Windows.Forms.TextBox txtManufacturerFilter;
        private System.Windows.Forms.TextBox txtGenericNameFilter;
        private System.Windows.Forms.TextBox txtBrandNameFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwProducts;
        private System.Windows.Forms.ColumnHeader colGuid;
        private System.Windows.Forms.ColumnHeader colManufacturerGuid;
        private System.Windows.Forms.ColumnHeader colProductsBrandname;
        private System.Windows.Forms.ColumnHeader colProductsGenericname;
        private System.Windows.Forms.ColumnHeader colProductsStatus;
        private System.Windows.Forms.ColumnHeader colProductsManufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchManufacturer;
    }
}