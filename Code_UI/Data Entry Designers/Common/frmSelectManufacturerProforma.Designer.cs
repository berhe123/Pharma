namespace Pharma
{
    partial class frmSelectManufacturerProforma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectManufacturerProforma));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwManufacturerProformas = new System.Windows.Forms.ListView();
            this.colGuid = new System.Windows.Forms.ColumnHeader();
            this.colProformaNumber = new System.Windows.Forms.ColumnHeader();
            this.colProformaDate = new System.Windows.Forms.ColumnHeader();
            this.colRequestNumber = new System.Windows.Forms.ColumnHeader();
            this.colRequestDate = new System.Windows.Forms.ColumnHeader();
            this.colDispatch = new System.Windows.Forms.ColumnHeader();
            this.colTermsOfPayment = new System.Windows.Forms.ColumnHeader();
            this.colTermsOfShipment = new System.Windows.Forms.ColumnHeader();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnSearchManufacturer = new System.Windows.Forms.Button();
            this.chkNotConvertedToPurchaseOrder = new System.Windows.Forms.CheckBox();
            this.txtProformaDateFrom = new System.Windows.Forms.TextBox();
            this.txtManufacturerFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProformaDateTo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchManufacturerFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProformaNumberLike = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
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
            this.label1.Size = new System.Drawing.Size(746, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Manufacturer Proforma Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwManufacturerProformas
            // 
            this.lvwManufacturerProformas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGuid,
            this.colProformaNumber,
            this.colProformaDate,
            this.colRequestNumber,
            this.colRequestDate,
            this.colDispatch,
            this.colTermsOfPayment,
            this.colTermsOfShipment});
            this.lvwManufacturerProformas.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwManufacturerProformas.FullRowSelect = true;
            this.lvwManufacturerProformas.GridLines = true;
            this.lvwManufacturerProformas.Location = new System.Drawing.Point(4, 152);
            this.lvwManufacturerProformas.MultiSelect = false;
            this.lvwManufacturerProformas.Name = "lvwManufacturerProformas";
            this.lvwManufacturerProformas.Size = new System.Drawing.Size(736, 342);
            this.lvwManufacturerProformas.TabIndex = 16;
            this.lvwManufacturerProformas.UseCompatibleStateImageBehavior = false;
            this.lvwManufacturerProformas.View = System.Windows.Forms.View.Details;
            this.lvwManufacturerProformas.SelectedIndexChanged += new System.EventHandler(this.lvwManufacturerProformas_SelectedIndexChanged);
            this.lvwManufacturerProformas.DoubleClick += new System.EventHandler(this.lvwManufacturers_DoubleClick);
            // 
            // colGuid
            // 
            this.colGuid.Text = "Guid";
            this.colGuid.Width = 0;
            // 
            // colProformaNumber
            // 
            this.colProformaNumber.Text = "Proforma Number";
            this.colProformaNumber.Width = 120;
            // 
            // colProformaDate
            // 
            this.colProformaDate.Text = "Proforma Date";
            this.colProformaDate.Width = 120;
            // 
            // colRequestNumber
            // 
            this.colRequestNumber.Text = "Request Number";
            this.colRequestNumber.Width = 120;
            // 
            // colRequestDate
            // 
            this.colRequestDate.Text = "Request Date";
            this.colRequestDate.Width = 120;
            // 
            // colDispatch
            // 
            this.colDispatch.Text = "Dispatch";
            this.colDispatch.Width = 120;
            // 
            // colTermsOfPayment
            // 
            this.colTermsOfPayment.Text = "Terms of Payment";
            this.colTermsOfPayment.Width = 150;
            // 
            // colTermsOfShipment
            // 
            this.colTermsOfShipment.Text = "Terms of Shipment";
            this.colTermsOfShipment.Width = 120;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnSearchManufacturer);
            this.grpFilter.Controls.Add(this.chkNotConvertedToPurchaseOrder);
            this.grpFilter.Controls.Add(this.txtProformaDateFrom);
            this.grpFilter.Controls.Add(this.txtManufacturerFilter);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.txtProformaDateTo);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label9);
            this.grpFilter.Controls.Add(this.btnSearchManufacturerFilter);
            this.grpFilter.Controls.Add(this.btnRefresh);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.txtProformaNumberLike);
            this.grpFilter.Location = new System.Drawing.Point(4, 40);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(736, 101);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // btnSearchManufacturer
            // 
            this.btnSearchManufacturer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturer.Location = new System.Drawing.Point(288, 70);
            this.btnSearchManufacturer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturer.Name = "btnSearchManufacturer";
            this.btnSearchManufacturer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturer.TabIndex = 8;
            this.btnSearchManufacturer.Text = "...";
            this.btnSearchManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchManufacturer.UseVisualStyleBackColor = true;
            this.btnSearchManufacturer.Click += new System.EventHandler(this.btnSearchManufacturer_Click);
            // 
            // chkNotConvertedToPurchaseOrder
            // 
            this.chkNotConvertedToPurchaseOrder.Checked = true;
            this.chkNotConvertedToPurchaseOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotConvertedToPurchaseOrder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotConvertedToPurchaseOrder.Location = new System.Drawing.Point(334, 18);
            this.chkNotConvertedToPurchaseOrder.Name = "chkNotConvertedToPurchaseOrder";
            this.chkNotConvertedToPurchaseOrder.Size = new System.Drawing.Size(384, 19);
            this.chkNotConvertedToPurchaseOrder.TabIndex = 5;
            this.chkNotConvertedToPurchaseOrder.Text = "Show proformas not converted to purchase order only";
            this.chkNotConvertedToPurchaseOrder.UseVisualStyleBackColor = true;
            // 
            // txtProformaDateFrom
            // 
            this.txtProformaDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProformaDateFrom.Location = new System.Drawing.Point(383, 72);
            this.txtProformaDateFrom.Name = "txtProformaDateFrom";
            this.txtProformaDateFrom.Size = new System.Drawing.Size(99, 23);
            this.txtProformaDateFrom.TabIndex = 12;
            // 
            // txtManufacturerFilter
            // 
            this.txtManufacturerFilter.BackColor = System.Drawing.SystemColors.Window;
            this.txtManufacturerFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManufacturerFilter.Location = new System.Drawing.Point(14, 72);
            this.txtManufacturerFilter.Name = "txtManufacturerFilter";
            this.txtManufacturerFilter.Size = new System.Drawing.Size(272, 23);
            this.txtManufacturerFilter.TabIndex = 7;
            this.txtManufacturerFilter.TextChanged += new System.EventHandler(this.txtManufacturerFilter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proforma Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Manufacturer";
            // 
            // txtProformaDateTo
            // 
            this.txtProformaDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProformaDateTo.Location = new System.Drawing.Point(520, 72);
            this.txtProformaDateTo.Name = "txtProformaDateTo";
            this.txtProformaDateTo.Size = new System.Drawing.Size(99, 23);
            this.txtProformaDateTo.TabIndex = 14;
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
            // btnSearchManufacturerFilter
            // 
            this.btnSearchManufacturerFilter.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchManufacturerFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchManufacturerFilter.Image")));
            this.btnSearchManufacturerFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchManufacturerFilter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchManufacturerFilter.Location = new System.Drawing.Point(282, 42);
            this.btnSearchManufacturerFilter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchManufacturerFilter.Name = "btnSearchManufacturerFilter";
            this.btnSearchManufacturerFilter.Size = new System.Drawing.Size(30, 28);
            this.btnSearchManufacturerFilter.TabIndex = 9;
            this.btnSearchManufacturerFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchManufacturerFilter.UseVisualStyleBackColor = true;
            this.btnSearchManufacturerFilter.Visible = false;
            this.btnSearchManufacturerFilter.Click += new System.EventHandler(this.btnSearchManufacturerFilter_Click);
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
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proforma Number Like...";
            // 
            // txtProformaNumberLike
            // 
            this.txtProformaNumberLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProformaNumberLike.Location = new System.Drawing.Point(164, 17);
            this.txtProformaNumberLike.Name = "txtProformaNumberLike";
            this.txtProformaNumberLike.Size = new System.Drawing.Size(153, 23);
            this.txtProformaNumberLike.TabIndex = 4;
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
            // frmSelectManufacturerProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(745, 540);
            this.ControlBox = false;
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lvwManufacturerProformas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectManufacturerProforma";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart System";
            this.Load += new System.EventHandler(this.frmSelectManufacturerProforma_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwManufacturerProformas;
        private System.Windows.Forms.ColumnHeader colGuid;
        private System.Windows.Forms.ColumnHeader colProformaNumber;
        private System.Windows.Forms.ColumnHeader colProformaDate;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProformaNumberLike;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Button btnSearchManufacturerFilter;
        private System.Windows.Forms.TextBox txtManufacturerFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader colRequestNumber;
        private System.Windows.Forms.ColumnHeader colRequestDate;
        private System.Windows.Forms.ColumnHeader colDispatch;
        private System.Windows.Forms.ColumnHeader colTermsOfPayment;
        private System.Windows.Forms.ColumnHeader colTermsOfShipment;
        private System.Windows.Forms.TextBox txtProformaDateTo;
        private System.Windows.Forms.TextBox txtProformaDateFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkNotConvertedToPurchaseOrder;
        private System.Windows.Forms.Button btnSearchManufacturer;
    }
}