namespace Pharma
{
    partial class frmSelectPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectPurchaseOrder));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.chkLocalPurchase = new System.Windows.Forms.CheckBox();
            this.btnSearchManufacturer = new System.Windows.Forms.Button();
            this.chkNotReceived = new System.Windows.Forms.CheckBox();
            this.txtOrderDateFrom = new System.Windows.Forms.TextBox();
            this.txtOrderDateTo = new System.Windows.Forms.TextBox();
            this.txtManufacturerFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchManufacturerFilter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
            this.lvwPurchaseOrders = new System.Windows.Forms.ListView();
            this.colGuid = new System.Windows.Forms.ColumnHeader();
            this.colManufacturerProformaGuid = new System.Windows.Forms.ColumnHeader();
            this.colOrderNumber = new System.Windows.Forms.ColumnHeader();
            this.colOrderDate = new System.Windows.Forms.ColumnHeader();
            this.colTermsOfContract = new System.Windows.Forms.ColumnHeader();
            this.colCurrencyType = new System.Windows.Forms.ColumnHeader();
            this.colCurrency = new System.Windows.Forms.ColumnHeader();
            this.colFreightCharge = new System.Windows.Forms.ColumnHeader();
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
            this.label1.Text = "    Purchase Order Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.chkLocalPurchase);
            this.grpFilter.Controls.Add(this.btnSearchManufacturer);
            this.grpFilter.Controls.Add(this.chkNotReceived);
            this.grpFilter.Controls.Add(this.txtOrderDateFrom);
            this.grpFilter.Controls.Add(this.txtOrderDateTo);
            this.grpFilter.Controls.Add(this.txtManufacturerFilter);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.label4);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label9);
            this.grpFilter.Controls.Add(this.btnSearchManufacturerFilter);
            this.grpFilter.Controls.Add(this.btnRefresh);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.txtName);
            this.grpFilter.Location = new System.Drawing.Point(4, 40);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(736, 101);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // chkLocalPurchase
            // 
            this.chkLocalPurchase.Checked = true;
            this.chkLocalPurchase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLocalPurchase.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLocalPurchase.Location = new System.Drawing.Point(323, 17);
            this.chkLocalPurchase.Name = "chkLocalPurchase";
            this.chkLocalPurchase.Size = new System.Drawing.Size(118, 19);
            this.chkLocalPurchase.TabIndex = 16;
            this.chkLocalPurchase.Text = "Local";
            this.chkLocalPurchase.UseVisualStyleBackColor = true;
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
            // chkNotReceived
            // 
            this.chkNotReceived.Checked = true;
            this.chkNotReceived.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotReceived.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotReceived.Location = new System.Drawing.Point(466, 19);
            this.chkNotReceived.Name = "chkNotReceived";
            this.chkNotReceived.Size = new System.Drawing.Size(258, 19);
            this.chkNotReceived.TabIndex = 5;
            this.chkNotReceived.Text = "Show not received purchase orders only";
            this.chkNotReceived.UseVisualStyleBackColor = true;
            // 
            // txtOrderDateFrom
            // 
            this.txtOrderDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDateFrom.Location = new System.Drawing.Point(379, 72);
            this.txtOrderDateFrom.Name = "txtOrderDateFrom";
            this.txtOrderDateFrom.Size = new System.Drawing.Size(99, 23);
            this.txtOrderDateFrom.TabIndex = 12;
            // 
            // txtOrderDateTo
            // 
            this.txtOrderDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderDateTo.Location = new System.Drawing.Point(516, 72);
            this.txtOrderDateTo.Name = "txtOrderDateTo";
            this.txtOrderDateTo.Size = new System.Drawing.Size(99, 23);
            this.txtOrderDateTo.TabIndex = 14;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Order Date";
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
            this.btnSearchManufacturerFilter.Location = new System.Drawing.Point(242, 42);
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
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Number Like...";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(148, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 23);
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
            // lvwPurchaseOrders
            // 
            this.lvwPurchaseOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGuid,
            this.colManufacturerProformaGuid,
            this.colOrderNumber,
            this.colOrderDate,
            this.colTermsOfContract,
            this.colCurrencyType,
            this.colCurrency,
            this.colFreightCharge});
            this.lvwPurchaseOrders.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwPurchaseOrders.FullRowSelect = true;
            this.lvwPurchaseOrders.GridLines = true;
            this.lvwPurchaseOrders.Location = new System.Drawing.Point(4, 152);
            this.lvwPurchaseOrders.MultiSelect = false;
            this.lvwPurchaseOrders.Name = "lvwPurchaseOrders";
            this.lvwPurchaseOrders.Size = new System.Drawing.Size(736, 342);
            this.lvwPurchaseOrders.TabIndex = 16;
            this.lvwPurchaseOrders.UseCompatibleStateImageBehavior = false;
            this.lvwPurchaseOrders.View = System.Windows.Forms.View.Details;
            this.lvwPurchaseOrders.SelectedIndexChanged += new System.EventHandler(this.lvwPurchaseOrders_SelectedIndexChanged_1);
            this.lvwPurchaseOrders.DoubleClick += new System.EventHandler(this.lvwPurchaseOrders_DoubleClick);
            // 
            // colGuid
            // 
            this.colGuid.Text = "Guid";
            this.colGuid.Width = 0;
            // 
            // colManufacturerProformaGuid
            // 
            this.colManufacturerProformaGuid.DisplayIndex = 4;
            this.colManufacturerProformaGuid.Text = "Manufacturer Proforma Guid";
            this.colManufacturerProformaGuid.Width = 0;
            // 
            // colOrderNumber
            // 
            this.colOrderNumber.DisplayIndex = 1;
            this.colOrderNumber.Text = "Order Number";
            this.colOrderNumber.Width = 120;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DisplayIndex = 2;
            this.colOrderDate.Text = "Order Date";
            this.colOrderDate.Width = 120;
            // 
            // colTermsOfContract
            // 
            this.colTermsOfContract.DisplayIndex = 3;
            this.colTermsOfContract.Text = "Terms of Contract";
            this.colTermsOfContract.Width = 0;
            // 
            // colCurrencyType
            // 
            this.colCurrencyType.Text = "Currency Type ID";
            this.colCurrencyType.Width = 0;
            // 
            // colCurrency
            // 
            this.colCurrency.Text = "Currency";
            this.colCurrency.Width = 120;
            // 
            // colFreightCharge
            // 
            this.colFreightCharge.Text = "Freight Charge";
            this.colFreightCharge.Width = 0;
            // 
            // frmSelectPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(745, 540);
            this.ControlBox = false;
            this.Controls.Add(this.lvwPurchaseOrders);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectPurchaseOrder";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart System";
            this.Load += new System.EventHandler(this.frmSelectPurchaseOrder_Load);
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
        private System.Windows.Forms.Button btnSearchManufacturerFilter;
        private System.Windows.Forms.TextBox txtManufacturerFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvwPurchaseOrders;
        private System.Windows.Forms.ColumnHeader colGuid;
        private System.Windows.Forms.ColumnHeader colManufacturerProformaGuid;
        private System.Windows.Forms.ColumnHeader colOrderNumber;
        private System.Windows.Forms.ColumnHeader colOrderDate;
        private System.Windows.Forms.ColumnHeader colTermsOfContract;
        private System.Windows.Forms.ColumnHeader colCurrencyType;
        private System.Windows.Forms.ColumnHeader colCurrency;
        private System.Windows.Forms.ColumnHeader colFreightCharge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderDateFrom;
        private System.Windows.Forms.TextBox txtOrderDateTo;
        private System.Windows.Forms.CheckBox chkNotReceived;
        private System.Windows.Forms.Button btnSearchManufacturer;
        public System.Windows.Forms.CheckBox chkLocalPurchase;
    }
}