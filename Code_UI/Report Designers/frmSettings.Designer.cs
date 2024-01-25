namespace Pharma
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Organization Info");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Defaults");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Organization", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21});
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Drug Registration Fee");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Drug Registration", new System.Windows.Forms.TreeNode[] {
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Supplier Proforma");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Purchase Order");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Price Calculation");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Importing", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27});
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Goods Receiving");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Goods Issuance");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Store Management ", new System.Windows.Forms.TreeNode[] {
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Proforma");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Supplies Requisition");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Invoice");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Sales", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Payment Request");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Payment Settlement");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Cash Collection", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tvwSettings = new System.Windows.Forms.TreeView();
            this.imageSettings = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Panel();
            this.line1 = new System.Windows.Forms.Panel();
            this.panelOrganization = new System.Windows.Forms.Panel();
            this.txtOrganizationFSNumber = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.txtOrganizationMRC = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.txtOrganizationVAT = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.txtOrganizationAddress = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtOrganizationTIN = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtOrganizationPOBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrganizationFax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrganizationTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrganizationName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPhoto = new System.Windows.Forms.GroupBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.tsPhoto = new System.Windows.Forms.ToolStrip();
            this.btnImportLogo = new System.Windows.Forms.ToolStripButton();
            this.btnPasteLogo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefreshLogo = new System.Windows.Forms.ToolStripButton();
            this.btnClearLogo = new System.Windows.Forms.ToolStripButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label45 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.dlgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelSupplierProforma = new System.Windows.Forms.Panel();
            this.chkSupplierProformaGenerateNotificationNumber = new System.Windows.Forms.CheckBox();
            this.cboSupplierProformaTermsOfShipment = new System.Windows.Forms.ComboBox();
            this.cboSupplierProformaDispatch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelPurchaseOrder = new System.Windows.Forms.Panel();
            this.chkPurchaseOrderGenerateReferenceNumber = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelPriceCalculation = new System.Windows.Forms.Panel();
            this.chkAllowPriceRecalculation = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelGoodsReceiving = new System.Windows.Forms.Panel();
            this.chkGoodsReceivingGenerateReferenceNumber = new System.Windows.Forms.CheckBox();
            this.cboGoodsReceivingStore = new System.Windows.Forms.ComboBox();
            this.cboGoodsReceivingLocation = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGoodsReceivingDeliveredBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGoodsReceivingCheckedBy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGoodsReceivingReceivedBy = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelGoodsIssuance = new System.Windows.Forms.Panel();
            this.txtGoodsIssuanceIssuedTo = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.chkGoodsIssuanceGenerateReferenceNumber = new System.Windows.Forms.CheckBox();
            this.cboGoodsIssuanceStore = new System.Windows.Forms.ComboBox();
            this.cboGoodsIssuanceLocation = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGoodsIssuanceCheckedBy = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtGoodsIssuanceIssuedBy = new System.Windows.Forms.TextBox();
            this.lblIssuedTo = new System.Windows.Forms.Label();
            this.cboGoodsIssuanceIssuedTo = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panelSuppliesRequisition = new System.Windows.Forms.Panel();
            this.chkSuppliesRequisitionRequestorDifferenctFromLicensee = new System.Windows.Forms.CheckBox();
            this.chkSuppliesRequisitionGenerateReferenceNumber = new System.Windows.Forms.CheckBox();
            this.txtSuppliesRequisitionApprovedBy = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtSuppliesRequisitionRequestedBy = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panelInvoice = new System.Windows.Forms.Panel();
            this.label67 = new System.Windows.Forms.Label();
            this.txtVATPercentage = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.txtInvoiceReturningReason = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtInvoiceDueDateLength = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtInvoiceApprovedBy = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInvoiceDeliveredBy = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkInvoiceGenerateReferenceNumber = new System.Windows.Forms.CheckBox();
            this.cboInvoiceInvoiceType = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtInvoiceCheckedBy = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtInvoicePreparedBy = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label34 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panelPaymentRequest = new System.Windows.Forms.Panel();
            this.chkPaymentRequestGenerateReferenceNumber = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panelPaymentSettlement = new System.Windows.Forms.Panel();
            this.label42 = new System.Windows.Forms.Label();
            this.txtPaymentSettlementCheckMaturityDateLength = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panelDrugRegistrationFee = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.txtDrugRegistrationFeePercentagePaidByManufacturer = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panelDefaults = new System.Windows.Forms.Panel();
            this.btnSearchDefaultWorkingManufacturer = new System.Windows.Forms.Button();
            this.txtDefaultWorkingManufacturer = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.cboDefaultWorkingStore = new System.Windows.Forms.ComboBox();
            this.cboDefaultWorkingLocation = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label58 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label63 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.txtProformaRequestedBy = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.txtProformaApprovedBy = new System.Windows.Forms.TextBox();
            this.chkProformaGenerateReferenceNumber = new System.Windows.Forms.CheckBox();
            this.panelProforma = new System.Windows.Forms.Panel();
            this.label64 = new System.Windows.Forms.Label();
            this.txtProformaValidityPeriodLength = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelOrganization.SuspendLayout();
            this.gbPhoto.SuspendLayout();
            this.tsPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelSupplierProforma.SuspendLayout();
            this.panelPurchaseOrder.SuspendLayout();
            this.panelPriceCalculation.SuspendLayout();
            this.panelGoodsReceiving.SuspendLayout();
            this.panelGoodsIssuance.SuspendLayout();
            this.panelSuppliesRequisition.SuspendLayout();
            this.panelInvoice.SuspendLayout();
            this.panelPaymentRequest.SuspendLayout();
            this.panelPaymentSettlement.SuspendLayout();
            this.panelDrugRegistrationFee.SuspendLayout();
            this.panelDefaults.SuspendLayout();
            this.panelProforma.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwSettings
            // 
            this.tvwSettings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwSettings.ImageIndex = 0;
            this.tvwSettings.ImageList = this.imageSettings;
            this.tvwSettings.Location = new System.Drawing.Point(6, 40);
            this.tvwSettings.Name = "tvwSettings";
            treeNode20.Name = "nodeOrganizationG";
            treeNode20.Text = "Organization Info";
            treeNode21.Name = "nodeDefaults";
            treeNode21.Text = "Defaults";
            treeNode22.Name = "nodeOrganization";
            treeNode22.Text = "Organization";
            treeNode23.Name = "nodeDrugRegistrationFee";
            treeNode23.Text = "Drug Registration Fee";
            treeNode24.Name = "nodeDrugRegistration";
            treeNode24.Text = "Drug Registration";
            treeNode25.Name = "nodeSupplierProforma";
            treeNode25.Text = "Supplier Proforma";
            treeNode26.Name = "nodePurchaseOrder";
            treeNode26.Text = "Purchase Order";
            treeNode27.Name = "nodePriceCalculation";
            treeNode27.Text = "Price Calculation";
            treeNode28.Name = "nodeImporting";
            treeNode28.Text = "Importing";
            treeNode29.Name = "nodeGoodsReceiving";
            treeNode29.Text = "Goods Receiving";
            treeNode30.Name = "nodeGoodsIssuance";
            treeNode30.Text = "Goods Issuance";
            treeNode31.Name = "nodeStoreManagement";
            treeNode31.Text = "Store Management ";
            treeNode32.Name = "nodeProforma";
            treeNode32.Text = "Proforma";
            treeNode33.Name = "nodeSuppliesRequisition";
            treeNode33.Text = "Supplies Requisition";
            treeNode34.Name = "nodeInvoice";
            treeNode34.Text = "Invoice";
            treeNode35.Name = "nodeSales";
            treeNode35.Text = "Sales";
            treeNode36.Name = "nodePaymentRequest";
            treeNode36.Text = "Payment Request";
            treeNode37.Name = "nodePaymentSettlement";
            treeNode37.Text = "Payment Settlement";
            treeNode38.Name = "nodeCashCollection";
            treeNode38.Text = "Cash Collection";
            this.tvwSettings.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode24,
            treeNode28,
            treeNode31,
            treeNode35,
            treeNode38});
            this.tvwSettings.SelectedImageIndex = 0;
            this.tvwSettings.Size = new System.Drawing.Size(223, 440);
            this.tvwSettings.TabIndex = 0;
            this.tvwSettings.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwSettings_AfterSelect);
            // 
            // imageSettings
            // 
            this.imageSettings.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSettings.ImageStream")));
            this.imageSettings.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSettings.Images.SetKeyName(0, "View Details.bmp.gif");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 36);
            this.label1.TabIndex = 104;
            this.label1.Text = "    Global Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.line2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line2.Location = new System.Drawing.Point(235, 479);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(515, 1);
            this.line2.TabIndex = 108;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(0, 36);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(757, 2);
            this.line1.TabIndex = 109;
            // 
            // panelOrganization
            // 
            this.panelOrganization.Controls.Add(this.txtOrganizationFSNumber);
            this.panelOrganization.Controls.Add(this.label59);
            this.panelOrganization.Controls.Add(this.txtOrganizationMRC);
            this.panelOrganization.Controls.Add(this.label56);
            this.panelOrganization.Controls.Add(this.txtOrganizationVAT);
            this.panelOrganization.Controls.Add(this.label55);
            this.panelOrganization.Controls.Add(this.txtOrganizationAddress);
            this.panelOrganization.Controls.Add(this.label48);
            this.panelOrganization.Controls.Add(this.txtOrganizationTIN);
            this.panelOrganization.Controls.Add(this.label46);
            this.panelOrganization.Controls.Add(this.txtOrganizationPOBox);
            this.panelOrganization.Controls.Add(this.label5);
            this.panelOrganization.Controls.Add(this.txtOrganizationFax);
            this.panelOrganization.Controls.Add(this.label4);
            this.panelOrganization.Controls.Add(this.txtOrganizationTelephone);
            this.panelOrganization.Controls.Add(this.label3);
            this.panelOrganization.Controls.Add(this.txtOrganizationName);
            this.panelOrganization.Controls.Add(this.label2);
            this.panelOrganization.Controls.Add(this.gbPhoto);
            this.panelOrganization.Controls.Add(this.label45);
            this.panelOrganization.Controls.Add(this.panel21);
            this.panelOrganization.Controls.Add(this.label44);
            this.panelOrganization.Controls.Add(this.panel20);
            this.panelOrganization.Location = new System.Drawing.Point(-1000, 40);
            this.panelOrganization.Name = "panelOrganization";
            this.panelOrganization.Size = new System.Drawing.Size(515, 432);
            this.panelOrganization.TabIndex = 120;
            // 
            // txtOrganizationFSNumber
            // 
            this.txtOrganizationFSNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationFSNumber.Location = new System.Drawing.Point(164, 89);
            this.txtOrganizationFSNumber.Name = "txtOrganizationFSNumber";
            this.txtOrganizationFSNumber.Size = new System.Drawing.Size(130, 23);
            this.txtOrganizationFSNumber.TabIndex = 4;
            // 
            // label59
            // 
            this.label59.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label59.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label59.Location = new System.Drawing.Point(164, 74);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(130, 16);
            this.label59.TabIndex = 169;
            this.label59.Text = "FS Number";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrganizationMRC
            // 
            this.txtOrganizationMRC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationMRC.Location = new System.Drawing.Point(308, 89);
            this.txtOrganizationMRC.Name = "txtOrganizationMRC";
            this.txtOrganizationMRC.Size = new System.Drawing.Size(160, 23);
            this.txtOrganizationMRC.TabIndex = 5;
            // 
            // label56
            // 
            this.label56.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label56.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label56.Location = new System.Drawing.Point(308, 74);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(160, 16);
            this.label56.TabIndex = 167;
            this.label56.Text = "Machine Registration Code";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrganizationVAT
            // 
            this.txtOrganizationVAT.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationVAT.Location = new System.Drawing.Point(17, 89);
            this.txtOrganizationVAT.Name = "txtOrganizationVAT";
            this.txtOrganizationVAT.Size = new System.Drawing.Size(130, 23);
            this.txtOrganizationVAT.TabIndex = 3;
            // 
            // label55
            // 
            this.label55.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label55.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label55.Location = new System.Drawing.Point(17, 74);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(130, 16);
            this.label55.TabIndex = 165;
            this.label55.Text = "VAT";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrganizationAddress
            // 
            this.txtOrganizationAddress.Font = new System.Drawing.Font("Nyala", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationAddress.Location = new System.Drawing.Point(17, 131);
            this.txtOrganizationAddress.Name = "txtOrganizationAddress";
            this.txtOrganizationAddress.Size = new System.Drawing.Size(451, 24);
            this.txtOrganizationAddress.TabIndex = 6;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label48.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label48.Location = new System.Drawing.Point(17, 116);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(143, 16);
            this.label48.TabIndex = 163;
            this.label48.Text = "Address";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrganizationTIN
            // 
            this.txtOrganizationTIN.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationTIN.Location = new System.Drawing.Point(308, 47);
            this.txtOrganizationTIN.Name = "txtOrganizationTIN";
            this.txtOrganizationTIN.Size = new System.Drawing.Size(160, 23);
            this.txtOrganizationTIN.TabIndex = 2;
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label46.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label46.Location = new System.Drawing.Point(308, 32);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(160, 16);
            this.label46.TabIndex = 161;
            this.label46.Text = "TIN";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrganizationPOBox
            // 
            this.txtOrganizationPOBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationPOBox.Location = new System.Drawing.Point(17, 216);
            this.txtOrganizationPOBox.Name = "txtOrganizationPOBox";
            this.txtOrganizationPOBox.Size = new System.Drawing.Size(451, 23);
            this.txtOrganizationPOBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(17, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 159;
            this.label5.Text = "P.O.Box";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrganizationFax
            // 
            this.txtOrganizationFax.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationFax.Location = new System.Drawing.Point(308, 174);
            this.txtOrganizationFax.Name = "txtOrganizationFax";
            this.txtOrganizationFax.Size = new System.Drawing.Size(160, 23);
            this.txtOrganizationFax.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(308, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 157;
            this.label4.Text = "Fax";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrganizationTelephone
            // 
            this.txtOrganizationTelephone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationTelephone.Location = new System.Drawing.Point(17, 174);
            this.txtOrganizationTelephone.Name = "txtOrganizationTelephone";
            this.txtOrganizationTelephone.Size = new System.Drawing.Size(277, 23);
            this.txtOrganizationTelephone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 155;
            this.label3.Text = "Telephone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrganizationName
            // 
            this.txtOrganizationName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganizationName.Location = new System.Drawing.Point(17, 47);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.Size = new System.Drawing.Size(277, 23);
            this.txtOrganizationName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 153;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbPhoto
            // 
            this.gbPhoto.BackColor = System.Drawing.Color.Transparent;
            this.gbPhoto.Controls.Add(this.lblLogo);
            this.gbPhoto.Controls.Add(this.tsPhoto);
            this.gbPhoto.Controls.Add(this.picLogo);
            this.gbPhoto.Location = new System.Drawing.Point(17, 268);
            this.gbPhoto.Name = "gbPhoto";
            this.gbPhoto.Size = new System.Drawing.Size(417, 138);
            this.gbPhoto.TabIndex = 152;
            this.gbPhoto.TabStop = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLogo.Location = new System.Drawing.Point(68, 118);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(30, 13);
            this.lblLogo.TabIndex = 33;
            this.lblLogo.Text = "Logo";
            // 
            // tsPhoto
            // 
            this.tsPhoto.AllowItemReorder = true;
            this.tsPhoto.AutoSize = false;
            this.tsPhoto.BackColor = System.Drawing.Color.GhostWhite;
            this.tsPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPhoto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportLogo,
            this.btnPasteLogo,
            this.toolStripSeparator1,
            this.btnRefreshLogo,
            this.btnClearLogo});
            this.tsPhoto.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsPhoto.Location = new System.Drawing.Point(3, 16);
            this.tsPhoto.Name = "tsPhoto";
            this.tsPhoto.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsPhoto.Size = new System.Drawing.Size(61, 119);
            this.tsPhoto.TabIndex = 10;
            this.tsPhoto.Text = "toolStrip2";
            // 
            // btnImportLogo
            // 
            this.btnImportLogo.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnImportLogo.Image")));
            this.btnImportLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportLogo.Name = "btnImportLogo";
            this.btnImportLogo.Size = new System.Drawing.Size(59, 20);
            this.btnImportLogo.Text = "Open";
            this.btnImportLogo.Click += new System.EventHandler(this.btnImportLogo_Click);
            // 
            // btnPasteLogo
            // 
            this.btnPasteLogo.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnPasteLogo.Image")));
            this.btnPasteLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPasteLogo.Name = "btnPasteLogo";
            this.btnPasteLogo.Size = new System.Drawing.Size(59, 20);
            this.btnPasteLogo.Text = "Paste";
            this.btnPasteLogo.Click += new System.EventHandler(this.btnPasteLogo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(59, 6);
            // 
            // btnRefreshLogo
            // 
            this.btnRefreshLogo.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshLogo.Image")));
            this.btnRefreshLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshLogo.Name = "btnRefreshLogo";
            this.btnRefreshLogo.Size = new System.Drawing.Size(59, 20);
            this.btnRefreshLogo.Text = "Refresh";
            this.btnRefreshLogo.Click += new System.EventHandler(this.btnRefreshLogo_Click);
            // 
            // btnClearLogo
            // 
            this.btnClearLogo.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLogo.Image = global::Pharma.Properties.Resources.delete;
            this.btnClearLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearLogo.Name = "btnClearLogo";
            this.btnClearLogo.Size = new System.Drawing.Size(59, 20);
            this.btnClearLogo.Text = "Clear";
            this.btnClearLogo.Click += new System.EventHandler(this.btnClearLogo_Click);
            // 
            // picLogo
            // 
            this.picLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picLogo.Location = new System.Drawing.Point(68, 18);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(106, 96);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 22;
            this.picLogo.TabStop = false;
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label45.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label45.Location = new System.Drawing.Point(0, 248);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(116, 16);
            this.label45.TabIndex = 151;
            this.label45.Text = "Organization Logo";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel21.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel21.Location = new System.Drawing.Point(0, 258);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(515, 1);
            this.panel21.TabIndex = 150;
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label44.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label44.Location = new System.Drawing.Point(0, 9);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(124, 16);
            this.label44.TabIndex = 149;
            this.label44.Text = "Organization Info";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel20.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel20.Location = new System.Drawing.Point(0, 17);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(515, 1);
            this.panel20.TabIndex = 148;
            // 
            // dlgOpenFileDialog
            // 
            this.dlgOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenFileDialog_FileOk);
            // 
            // panelSupplierProforma
            // 
            this.panelSupplierProforma.Controls.Add(this.chkSupplierProformaGenerateNotificationNumber);
            this.panelSupplierProforma.Controls.Add(this.cboSupplierProformaTermsOfShipment);
            this.panelSupplierProforma.Controls.Add(this.cboSupplierProformaDispatch);
            this.panelSupplierProforma.Controls.Add(this.label8);
            this.panelSupplierProforma.Controls.Add(this.label9);
            this.panelSupplierProforma.Controls.Add(this.label11);
            this.panelSupplierProforma.Controls.Add(this.panel2);
            this.panelSupplierProforma.Controls.Add(this.label12);
            this.panelSupplierProforma.Controls.Add(this.panel3);
            this.panelSupplierProforma.Location = new System.Drawing.Point(-1000, 40);
            this.panelSupplierProforma.Name = "panelSupplierProforma";
            this.panelSupplierProforma.Size = new System.Drawing.Size(515, 432);
            this.panelSupplierProforma.TabIndex = 121;
            // 
            // chkSupplierProformaGenerateNotificationNumber
            // 
            this.chkSupplierProformaGenerateNotificationNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSupplierProformaGenerateNotificationNumber.Location = new System.Drawing.Point(21, 148);
            this.chkSupplierProformaGenerateNotificationNumber.Name = "chkSupplierProformaGenerateNotificationNumber";
            this.chkSupplierProformaGenerateNotificationNumber.Size = new System.Drawing.Size(213, 20);
            this.chkSupplierProformaGenerateNotificationNumber.TabIndex = 161;
            this.chkSupplierProformaGenerateNotificationNumber.Text = "Generate Notification Number";
            this.chkSupplierProformaGenerateNotificationNumber.UseVisualStyleBackColor = true;
            // 
            // cboSupplierProformaTermsOfShipment
            // 
            this.cboSupplierProformaTermsOfShipment.AllowDrop = true;
            this.cboSupplierProformaTermsOfShipment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplierProformaTermsOfShipment.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboSupplierProformaTermsOfShipment.FormattingEnabled = true;
            this.cboSupplierProformaTermsOfShipment.Location = new System.Drawing.Point(188, 57);
            this.cboSupplierProformaTermsOfShipment.Name = "cboSupplierProformaTermsOfShipment";
            this.cboSupplierProformaTermsOfShipment.Size = new System.Drawing.Size(144, 24);
            this.cboSupplierProformaTermsOfShipment.TabIndex = 157;
            // 
            // cboSupplierProformaDispatch
            // 
            this.cboSupplierProformaDispatch.AllowDrop = true;
            this.cboSupplierProformaDispatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSupplierProformaDispatch.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboSupplierProformaDispatch.FormattingEnabled = true;
            this.cboSupplierProformaDispatch.Location = new System.Drawing.Point(21, 57);
            this.cboSupplierProformaDispatch.Name = "cboSupplierProformaDispatch";
            this.cboSupplierProformaDispatch.Size = new System.Drawing.Size(144, 24);
            this.cboSupplierProformaDispatch.TabIndex = 156;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(188, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 155;
            this.label8.Text = "Terms of Shipment";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(21, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 16);
            this.label9.TabIndex = 153;
            this.label9.Text = "Dispatch";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(0, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 16);
            this.label11.TabIndex = 151;
            this.label11.Text = "Notification Number";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(515, 1);
            this.panel2.TabIndex = 150;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(0, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(210, 16);
            this.label12.TabIndex = 149;
            this.label12.Text = "Supplier Proforma - Default Values";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 1);
            this.panel3.TabIndex = 148;
            // 
            // panelPurchaseOrder
            // 
            this.panelPurchaseOrder.Controls.Add(this.chkPurchaseOrderGenerateReferenceNumber);
            this.panelPurchaseOrder.Controls.Add(this.label15);
            this.panelPurchaseOrder.Controls.Add(this.panel7);
            this.panelPurchaseOrder.Location = new System.Drawing.Point(-1000, 40);
            this.panelPurchaseOrder.Name = "panelPurchaseOrder";
            this.panelPurchaseOrder.Size = new System.Drawing.Size(515, 432);
            this.panelPurchaseOrder.TabIndex = 122;
            // 
            // chkPurchaseOrderGenerateReferenceNumber
            // 
            this.chkPurchaseOrderGenerateReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPurchaseOrderGenerateReferenceNumber.Location = new System.Drawing.Point(36, 40);
            this.chkPurchaseOrderGenerateReferenceNumber.Name = "chkPurchaseOrderGenerateReferenceNumber";
            this.chkPurchaseOrderGenerateReferenceNumber.Size = new System.Drawing.Size(213, 20);
            this.chkPurchaseOrderGenerateReferenceNumber.TabIndex = 161;
            this.chkPurchaseOrderGenerateReferenceNumber.Text = "Generate Reference Number";
            this.chkPurchaseOrderGenerateReferenceNumber.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(0, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(220, 16);
            this.label15.TabIndex = 149;
            this.label15.Text = "Purchase Order - Reference Number";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel7.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel7.Location = new System.Drawing.Point(0, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(515, 1);
            this.panel7.TabIndex = 148;
            // 
            // panelPriceCalculation
            // 
            this.panelPriceCalculation.Controls.Add(this.chkAllowPriceRecalculation);
            this.panelPriceCalculation.Controls.Add(this.label7);
            this.panelPriceCalculation.Controls.Add(this.panel5);
            this.panelPriceCalculation.Location = new System.Drawing.Point(-1000, 40);
            this.panelPriceCalculation.Name = "panelPriceCalculation";
            this.panelPriceCalculation.Size = new System.Drawing.Size(515, 432);
            this.panelPriceCalculation.TabIndex = 123;
            // 
            // chkAllowPriceRecalculation
            // 
            this.chkAllowPriceRecalculation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllowPriceRecalculation.Location = new System.Drawing.Point(36, 40);
            this.chkAllowPriceRecalculation.Name = "chkAllowPriceRecalculation";
            this.chkAllowPriceRecalculation.Size = new System.Drawing.Size(138, 20);
            this.chkAllowPriceRecalculation.TabIndex = 161;
            this.chkAllowPriceRecalculation.Text = "Allow Recalculation";
            this.chkAllowPriceRecalculation.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(0, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 16);
            this.label7.TabIndex = 149;
            this.label7.Text = "Price Calculation";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Location = new System.Drawing.Point(0, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(515, 1);
            this.panel5.TabIndex = 148;
            // 
            // panelGoodsReceiving
            // 
            this.panelGoodsReceiving.Controls.Add(this.chkGoodsReceivingGenerateReferenceNumber);
            this.panelGoodsReceiving.Controls.Add(this.cboGoodsReceivingStore);
            this.panelGoodsReceiving.Controls.Add(this.cboGoodsReceivingLocation);
            this.panelGoodsReceiving.Controls.Add(this.label14);
            this.panelGoodsReceiving.Controls.Add(this.label16);
            this.panelGoodsReceiving.Controls.Add(this.txtGoodsReceivingDeliveredBy);
            this.panelGoodsReceiving.Controls.Add(this.label6);
            this.panelGoodsReceiving.Controls.Add(this.txtGoodsReceivingCheckedBy);
            this.panelGoodsReceiving.Controls.Add(this.label10);
            this.panelGoodsReceiving.Controls.Add(this.txtGoodsReceivingReceivedBy);
            this.panelGoodsReceiving.Controls.Add(this.label13);
            this.panelGoodsReceiving.Controls.Add(this.label17);
            this.panelGoodsReceiving.Controls.Add(this.panel4);
            this.panelGoodsReceiving.Controls.Add(this.label18);
            this.panelGoodsReceiving.Controls.Add(this.panel6);
            this.panelGoodsReceiving.Location = new System.Drawing.Point(-1000, 40);
            this.panelGoodsReceiving.Name = "panelGoodsReceiving";
            this.panelGoodsReceiving.Size = new System.Drawing.Size(515, 432);
            this.panelGoodsReceiving.TabIndex = 124;
            // 
            // chkGoodsReceivingGenerateReferenceNumber
            // 
            this.chkGoodsReceivingGenerateReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGoodsReceivingGenerateReferenceNumber.Location = new System.Drawing.Point(14, 222);
            this.chkGoodsReceivingGenerateReferenceNumber.Name = "chkGoodsReceivingGenerateReferenceNumber";
            this.chkGoodsReceivingGenerateReferenceNumber.Size = new System.Drawing.Size(213, 20);
            this.chkGoodsReceivingGenerateReferenceNumber.TabIndex = 164;
            this.chkGoodsReceivingGenerateReferenceNumber.Text = "Generate Reference Number";
            this.chkGoodsReceivingGenerateReferenceNumber.UseVisualStyleBackColor = true;
            // 
            // cboGoodsReceivingStore
            // 
            this.cboGoodsReceivingStore.AllowDrop = true;
            this.cboGoodsReceivingStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoodsReceivingStore.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboGoodsReceivingStore.FormattingEnabled = true;
            this.cboGoodsReceivingStore.Location = new System.Drawing.Point(223, 53);
            this.cboGoodsReceivingStore.Name = "cboGoodsReceivingStore";
            this.cboGoodsReceivingStore.Size = new System.Drawing.Size(180, 24);
            this.cboGoodsReceivingStore.TabIndex = 163;
            // 
            // cboGoodsReceivingLocation
            // 
            this.cboGoodsReceivingLocation.AllowDrop = true;
            this.cboGoodsReceivingLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoodsReceivingLocation.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboGoodsReceivingLocation.FormattingEnabled = true;
            this.cboGoodsReceivingLocation.Location = new System.Drawing.Point(15, 53);
            this.cboGoodsReceivingLocation.Name = "cboGoodsReceivingLocation";
            this.cboGoodsReceivingLocation.Size = new System.Drawing.Size(180, 24);
            this.cboGoodsReceivingLocation.TabIndex = 162;
            this.cboGoodsReceivingLocation.SelectedIndexChanged += new System.EventHandler(this.cboGoodsReceivingLocation_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(223, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 16);
            this.label14.TabIndex = 161;
            this.label14.Text = "Store";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(15, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 16);
            this.label16.TabIndex = 160;
            this.label16.Text = "Location";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGoodsReceivingDeliveredBy
            // 
            this.txtGoodsReceivingDeliveredBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsReceivingDeliveredBy.Location = new System.Drawing.Point(14, 145);
            this.txtGoodsReceivingDeliveredBy.Name = "txtGoodsReceivingDeliveredBy";
            this.txtGoodsReceivingDeliveredBy.Size = new System.Drawing.Size(180, 23);
            this.txtGoodsReceivingDeliveredBy.TabIndex = 158;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(14, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 16);
            this.label6.TabIndex = 159;
            this.label6.Text = "Delivered By";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGoodsReceivingCheckedBy
            // 
            this.txtGoodsReceivingCheckedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsReceivingCheckedBy.Location = new System.Drawing.Point(223, 99);
            this.txtGoodsReceivingCheckedBy.Name = "txtGoodsReceivingCheckedBy";
            this.txtGoodsReceivingCheckedBy.Size = new System.Drawing.Size(180, 23);
            this.txtGoodsReceivingCheckedBy.TabIndex = 156;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(223, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 16);
            this.label10.TabIndex = 157;
            this.label10.Text = "CheckedBy";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGoodsReceivingReceivedBy
            // 
            this.txtGoodsReceivingReceivedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsReceivingReceivedBy.Location = new System.Drawing.Point(15, 99);
            this.txtGoodsReceivingReceivedBy.Name = "txtGoodsReceivingReceivedBy";
            this.txtGoodsReceivingReceivedBy.Size = new System.Drawing.Size(180, 23);
            this.txtGoodsReceivingReceivedBy.TabIndex = 154;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(15, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 16);
            this.label13.TabIndex = 155;
            this.label13.Text = "Received By";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(0, 189);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 16);
            this.label17.TabIndex = 151;
            this.label17.Text = "Reference Number";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Location = new System.Drawing.Point(0, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 1);
            this.panel4.TabIndex = 150;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(0, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(196, 16);
            this.label18.TabIndex = 149;
            this.label18.Text = "Goods Receiving - Default Values";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Location = new System.Drawing.Point(0, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(515, 1);
            this.panel6.TabIndex = 148;
            // 
            // panelGoodsIssuance
            // 
            this.panelGoodsIssuance.Controls.Add(this.txtGoodsIssuanceIssuedTo);
            this.panelGoodsIssuance.Controls.Add(this.label41);
            this.panelGoodsIssuance.Controls.Add(this.chkGoodsIssuanceGenerateReferenceNumber);
            this.panelGoodsIssuance.Controls.Add(this.cboGoodsIssuanceStore);
            this.panelGoodsIssuance.Controls.Add(this.cboGoodsIssuanceLocation);
            this.panelGoodsIssuance.Controls.Add(this.label19);
            this.panelGoodsIssuance.Controls.Add(this.label20);
            this.panelGoodsIssuance.Controls.Add(this.txtGoodsIssuanceCheckedBy);
            this.panelGoodsIssuance.Controls.Add(this.label22);
            this.panelGoodsIssuance.Controls.Add(this.txtGoodsIssuanceIssuedBy);
            this.panelGoodsIssuance.Controls.Add(this.lblIssuedTo);
            this.panelGoodsIssuance.Controls.Add(this.cboGoodsIssuanceIssuedTo);
            this.panelGoodsIssuance.Controls.Add(this.label23);
            this.panelGoodsIssuance.Controls.Add(this.label24);
            this.panelGoodsIssuance.Controls.Add(this.panel8);
            this.panelGoodsIssuance.Controls.Add(this.label25);
            this.panelGoodsIssuance.Controls.Add(this.panel9);
            this.panelGoodsIssuance.Location = new System.Drawing.Point(-1000, 40);
            this.panelGoodsIssuance.Name = "panelGoodsIssuance";
            this.panelGoodsIssuance.Size = new System.Drawing.Size(515, 432);
            this.panelGoodsIssuance.TabIndex = 125;
            // 
            // txtGoodsIssuanceIssuedTo
            // 
            this.txtGoodsIssuanceIssuedTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsIssuanceIssuedTo.Location = new System.Drawing.Point(223, 99);
            this.txtGoodsIssuanceIssuedTo.Name = "txtGoodsIssuanceIssuedTo";
            this.txtGoodsIssuanceIssuedTo.Size = new System.Drawing.Size(180, 23);
            this.txtGoodsIssuanceIssuedTo.TabIndex = 165;
            this.txtGoodsIssuanceIssuedTo.Visible = false;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label41.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label41.Location = new System.Drawing.Point(223, 84);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(180, 16);
            this.label41.TabIndex = 166;
            this.label41.Text = "Issued To";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label41.Visible = false;
            // 
            // chkGoodsIssuanceGenerateReferenceNumber
            // 
            this.chkGoodsIssuanceGenerateReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGoodsIssuanceGenerateReferenceNumber.Location = new System.Drawing.Point(14, 218);
            this.chkGoodsIssuanceGenerateReferenceNumber.Name = "chkGoodsIssuanceGenerateReferenceNumber";
            this.chkGoodsIssuanceGenerateReferenceNumber.Size = new System.Drawing.Size(213, 20);
            this.chkGoodsIssuanceGenerateReferenceNumber.TabIndex = 164;
            this.chkGoodsIssuanceGenerateReferenceNumber.Text = "Generate Reference Number";
            this.chkGoodsIssuanceGenerateReferenceNumber.UseVisualStyleBackColor = true;
            // 
            // cboGoodsIssuanceStore
            // 
            this.cboGoodsIssuanceStore.AllowDrop = true;
            this.cboGoodsIssuanceStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoodsIssuanceStore.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboGoodsIssuanceStore.FormattingEnabled = true;
            this.cboGoodsIssuanceStore.Location = new System.Drawing.Point(223, 53);
            this.cboGoodsIssuanceStore.Name = "cboGoodsIssuanceStore";
            this.cboGoodsIssuanceStore.Size = new System.Drawing.Size(180, 24);
            this.cboGoodsIssuanceStore.TabIndex = 163;
            // 
            // cboGoodsIssuanceLocation
            // 
            this.cboGoodsIssuanceLocation.AllowDrop = true;
            this.cboGoodsIssuanceLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoodsIssuanceLocation.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboGoodsIssuanceLocation.FormattingEnabled = true;
            this.cboGoodsIssuanceLocation.Location = new System.Drawing.Point(15, 53);
            this.cboGoodsIssuanceLocation.Name = "cboGoodsIssuanceLocation";
            this.cboGoodsIssuanceLocation.Size = new System.Drawing.Size(180, 24);
            this.cboGoodsIssuanceLocation.TabIndex = 162;
            this.cboGoodsIssuanceLocation.SelectedIndexChanged += new System.EventHandler(this.cboGoodsIssuanceLocation_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(223, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 16);
            this.label19.TabIndex = 161;
            this.label19.Text = "Store";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(15, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(143, 16);
            this.label20.TabIndex = 160;
            this.label20.Text = "Location";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGoodsIssuanceCheckedBy
            // 
            this.txtGoodsIssuanceCheckedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsIssuanceCheckedBy.Location = new System.Drawing.Point(15, 143);
            this.txtGoodsIssuanceCheckedBy.Name = "txtGoodsIssuanceCheckedBy";
            this.txtGoodsIssuanceCheckedBy.Size = new System.Drawing.Size(180, 23);
            this.txtGoodsIssuanceCheckedBy.TabIndex = 156;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(15, 128);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(180, 16);
            this.label22.TabIndex = 157;
            this.label22.Text = "Checked By";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGoodsIssuanceIssuedBy
            // 
            this.txtGoodsIssuanceIssuedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoodsIssuanceIssuedBy.Location = new System.Drawing.Point(15, 99);
            this.txtGoodsIssuanceIssuedBy.Name = "txtGoodsIssuanceIssuedBy";
            this.txtGoodsIssuanceIssuedBy.Size = new System.Drawing.Size(180, 23);
            this.txtGoodsIssuanceIssuedBy.TabIndex = 154;
            // 
            // lblIssuedTo
            // 
            this.lblIssuedTo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblIssuedTo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblIssuedTo.Location = new System.Drawing.Point(223, 126);
            this.lblIssuedTo.Name = "lblIssuedTo";
            this.lblIssuedTo.Size = new System.Drawing.Size(180, 16);
            this.lblIssuedTo.TabIndex = 166;
            this.lblIssuedTo.Text = "Issued To";
            this.lblIssuedTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboGoodsIssuanceIssuedTo
            // 
            this.cboGoodsIssuanceIssuedTo.AllowDrop = true;
            this.cboGoodsIssuanceIssuedTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGoodsIssuanceIssuedTo.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboGoodsIssuanceIssuedTo.FormattingEnabled = true;
            this.cboGoodsIssuanceIssuedTo.Location = new System.Drawing.Point(223, 143);
            this.cboGoodsIssuanceIssuedTo.Name = "cboGoodsIssuanceIssuedTo";
            this.cboGoodsIssuanceIssuedTo.Size = new System.Drawing.Size(180, 24);
            this.cboGoodsIssuanceIssuedTo.TabIndex = 162;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label23.Location = new System.Drawing.Point(15, 84);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(180, 16);
            this.label23.TabIndex = 155;
            this.label23.Text = "Issued By";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(0, 185);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(116, 16);
            this.label24.TabIndex = 151;
            this.label24.Text = "Reference Number";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel8.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel8.Location = new System.Drawing.Point(0, 195);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(515, 1);
            this.panel8.TabIndex = 150;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(0, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(196, 16);
            this.label25.TabIndex = 149;
            this.label25.Text = "Goods Issuance - Default Values";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel9.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel9.Location = new System.Drawing.Point(0, 17);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(515, 1);
            this.panel9.TabIndex = 148;
            // 
            // panelSuppliesRequisition
            // 
            this.panelSuppliesRequisition.Controls.Add(this.chkSuppliesRequisitionRequestorDifferenctFromLicensee);
            this.panelSuppliesRequisition.Controls.Add(this.chkSuppliesRequisitionGenerateReferenceNumber);
            this.panelSuppliesRequisition.Controls.Add(this.txtSuppliesRequisitionApprovedBy);
            this.panelSuppliesRequisition.Controls.Add(this.label27);
            this.panelSuppliesRequisition.Controls.Add(this.txtSuppliesRequisitionRequestedBy);
            this.panelSuppliesRequisition.Controls.Add(this.label28);
            this.panelSuppliesRequisition.Controls.Add(this.label29);
            this.panelSuppliesRequisition.Controls.Add(this.panel10);
            this.panelSuppliesRequisition.Controls.Add(this.label30);
            this.panelSuppliesRequisition.Controls.Add(this.panel11);
            this.panelSuppliesRequisition.Location = new System.Drawing.Point(-1000, 40);
            this.panelSuppliesRequisition.Name = "panelSuppliesRequisition";
            this.panelSuppliesRequisition.Size = new System.Drawing.Size(515, 432);
            this.panelSuppliesRequisition.TabIndex = 126;
            // 
            // chkSuppliesRequisitionRequestorDifferenctFromLicensee
            // 
            this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.Location = new System.Drawing.Point(16, 34);
            this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.Name = "chkSuppliesRequisitionRequestorDifferenctFromLicensee";
            this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.Size = new System.Drawing.Size(226, 20);
            this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.TabIndex = 165;
            this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.Text = "Requestor Different From Licensee";
            this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.UseVisualStyleBackColor = true;
            this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.CheckedChanged += new System.EventHandler(this.chkSuppliesRequisitionRequestorDifferenctFromLicensee_CheckedChanged);
            // 
            // chkSuppliesRequisitionGenerateReferenceNumber
            // 
            this.chkSuppliesRequisitionGenerateReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSuppliesRequisitionGenerateReferenceNumber.Location = new System.Drawing.Point(14, 196);
            this.chkSuppliesRequisitionGenerateReferenceNumber.Name = "chkSuppliesRequisitionGenerateReferenceNumber";
            this.chkSuppliesRequisitionGenerateReferenceNumber.Size = new System.Drawing.Size(213, 20);
            this.chkSuppliesRequisitionGenerateReferenceNumber.TabIndex = 164;
            this.chkSuppliesRequisitionGenerateReferenceNumber.Text = "Generate Reference Number";
            this.chkSuppliesRequisitionGenerateReferenceNumber.UseVisualStyleBackColor = true;
            // 
            // txtSuppliesRequisitionApprovedBy
            // 
            this.txtSuppliesRequisitionApprovedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppliesRequisitionApprovedBy.Location = new System.Drawing.Point(16, 126);
            this.txtSuppliesRequisitionApprovedBy.Name = "txtSuppliesRequisitionApprovedBy";
            this.txtSuppliesRequisitionApprovedBy.Size = new System.Drawing.Size(180, 23);
            this.txtSuppliesRequisitionApprovedBy.TabIndex = 156;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label27.Location = new System.Drawing.Point(16, 111);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(180, 16);
            this.label27.TabIndex = 157;
            this.label27.Text = "Approved By";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSuppliesRequisitionRequestedBy
            // 
            this.txtSuppliesRequisitionRequestedBy.Enabled = false;
            this.txtSuppliesRequisitionRequestedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuppliesRequisitionRequestedBy.Location = new System.Drawing.Point(42, 75);
            this.txtSuppliesRequisitionRequestedBy.Name = "txtSuppliesRequisitionRequestedBy";
            this.txtSuppliesRequisitionRequestedBy.Size = new System.Drawing.Size(180, 23);
            this.txtSuppliesRequisitionRequestedBy.TabIndex = 154;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label28.Location = new System.Drawing.Point(42, 60);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(180, 16);
            this.label28.TabIndex = 155;
            this.label28.Text = "Requested By";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label29.Location = new System.Drawing.Point(0, 163);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(116, 16);
            this.label29.TabIndex = 151;
            this.label29.Text = "Reference Number";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel10.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel10.Location = new System.Drawing.Point(0, 173);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(515, 1);
            this.panel10.TabIndex = 150;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label30.Location = new System.Drawing.Point(0, 9);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(220, 16);
            this.label30.TabIndex = 149;
            this.label30.Text = "Supplies Requisition - Default Values";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel11.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel11.Location = new System.Drawing.Point(0, 17);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(515, 1);
            this.panel11.TabIndex = 148;
            // 
            // panelInvoice
            // 
            this.panelInvoice.Controls.Add(this.label67);
            this.panelInvoice.Controls.Add(this.txtVATPercentage);
            this.panelInvoice.Controls.Add(this.label66);
            this.panelInvoice.Controls.Add(this.txtInvoiceReturningReason);
            this.panelInvoice.Controls.Add(this.label39);
            this.panelInvoice.Controls.Add(this.label38);
            this.panelInvoice.Controls.Add(this.txtInvoiceDueDateLength);
            this.panelInvoice.Controls.Add(this.label37);
            this.panelInvoice.Controls.Add(this.txtInvoiceApprovedBy);
            this.panelInvoice.Controls.Add(this.label36);
            this.panelInvoice.Controls.Add(this.label35);
            this.panelInvoice.Controls.Add(this.panel1);
            this.panelInvoice.Controls.Add(this.txtInvoiceDeliveredBy);
            this.panelInvoice.Controls.Add(this.label21);
            this.panelInvoice.Controls.Add(this.chkInvoiceGenerateReferenceNumber);
            this.panelInvoice.Controls.Add(this.cboInvoiceInvoiceType);
            this.panelInvoice.Controls.Add(this.label26);
            this.panelInvoice.Controls.Add(this.txtInvoiceCheckedBy);
            this.panelInvoice.Controls.Add(this.label31);
            this.panelInvoice.Controls.Add(this.txtInvoicePreparedBy);
            this.panelInvoice.Controls.Add(this.label32);
            this.panelInvoice.Controls.Add(this.label33);
            this.panelInvoice.Controls.Add(this.panel12);
            this.panelInvoice.Controls.Add(this.label34);
            this.panelInvoice.Controls.Add(this.panel13);
            this.panelInvoice.Controls.Add(this.panel14);
            this.panelInvoice.Location = new System.Drawing.Point(-1000, 40);
            this.panelInvoice.Name = "panelInvoice";
            this.panelInvoice.Size = new System.Drawing.Size(515, 432);
            this.panelInvoice.TabIndex = 127;
            // 
            // label67
            // 
            this.label67.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label67.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label67.Location = new System.Drawing.Point(106, 363);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(40, 16);
            this.label67.TabIndex = 178;
            this.label67.Text = "%";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVATPercentage
            // 
            this.txtVATPercentage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVATPercentage.Location = new System.Drawing.Point(51, 360);
            this.txtVATPercentage.Name = "txtVATPercentage";
            this.txtVATPercentage.Size = new System.Drawing.Size(40, 23);
            this.txtVATPercentage.TabIndex = 177;
            // 
            // label66
            // 
            this.label66.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label66.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label66.Location = new System.Drawing.Point(5, 338);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(203, 16);
            this.label66.TabIndex = 176;
            this.label66.Text = "Value Added Tax Percentage";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceReturningReason
            // 
            this.txtInvoiceReturningReason.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceReturningReason.Location = new System.Drawing.Point(15, 184);
            this.txtInvoiceReturningReason.Name = "txtInvoiceReturningReason";
            this.txtInvoiceReturningReason.Size = new System.Drawing.Size(387, 23);
            this.txtInvoiceReturningReason.TabIndex = 174;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label39.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label39.Location = new System.Drawing.Point(15, 169);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(180, 16);
            this.label39.TabIndex = 175;
            this.label39.Text = "Returning Reason";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label38.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label38.Location = new System.Drawing.Point(210, 301);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(40, 16);
            this.label38.TabIndex = 173;
            this.label38.Text = "Days";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceDueDateLength
            // 
            this.txtInvoiceDueDateLength.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceDueDateLength.Location = new System.Drawing.Point(168, 298);
            this.txtInvoiceDueDateLength.Name = "txtInvoiceDueDateLength";
            this.txtInvoiceDueDateLength.Size = new System.Drawing.Size(40, 23);
            this.txtInvoiceDueDateLength.TabIndex = 171;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label37.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label37.Location = new System.Drawing.Point(48, 301);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(118, 16);
            this.label37.TabIndex = 172;
            this.label37.Text = "Due Date Length = ";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceApprovedBy
            // 
            this.txtInvoiceApprovedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceApprovedBy.Location = new System.Drawing.Point(15, 140);
            this.txtInvoiceApprovedBy.Name = "txtInvoiceApprovedBy";
            this.txtInvoiceApprovedBy.Size = new System.Drawing.Size(180, 23);
            this.txtInvoiceApprovedBy.TabIndex = 169;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label36.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label36.Location = new System.Drawing.Point(15, 125);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(180, 16);
            this.label36.TabIndex = 170;
            this.label36.Text = "Approved By";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label35.Location = new System.Drawing.Point(1, 277);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(145, 16);
            this.label35.TabIndex = 168;
            this.label35.Text = "Credit Sales - Due Date";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Location = new System.Drawing.Point(1, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 1);
            this.panel1.TabIndex = 167;
            // 
            // txtInvoiceDeliveredBy
            // 
            this.txtInvoiceDeliveredBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceDeliveredBy.Location = new System.Drawing.Point(223, 140);
            this.txtInvoiceDeliveredBy.Name = "txtInvoiceDeliveredBy";
            this.txtInvoiceDeliveredBy.Size = new System.Drawing.Size(180, 23);
            this.txtInvoiceDeliveredBy.TabIndex = 165;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(223, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(180, 16);
            this.label21.TabIndex = 166;
            this.label21.Text = "Delivered By";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkInvoiceGenerateReferenceNumber
            // 
            this.chkInvoiceGenerateReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvoiceGenerateReferenceNumber.Location = new System.Drawing.Point(14, 245);
            this.chkInvoiceGenerateReferenceNumber.Name = "chkInvoiceGenerateReferenceNumber";
            this.chkInvoiceGenerateReferenceNumber.Size = new System.Drawing.Size(213, 20);
            this.chkInvoiceGenerateReferenceNumber.TabIndex = 164;
            this.chkInvoiceGenerateReferenceNumber.Text = "Generate Reference Number";
            this.chkInvoiceGenerateReferenceNumber.UseVisualStyleBackColor = true;
            // 
            // cboInvoiceInvoiceType
            // 
            this.cboInvoiceInvoiceType.AllowDrop = true;
            this.cboInvoiceInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoiceInvoiceType.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboInvoiceInvoiceType.FormattingEnabled = true;
            this.cboInvoiceInvoiceType.Location = new System.Drawing.Point(15, 53);
            this.cboInvoiceInvoiceType.Name = "cboInvoiceInvoiceType";
            this.cboInvoiceInvoiceType.Size = new System.Drawing.Size(180, 24);
            this.cboInvoiceInvoiceType.TabIndex = 162;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(15, 36);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 16);
            this.label26.TabIndex = 160;
            this.label26.Text = "Type";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvoiceCheckedBy
            // 
            this.txtInvoiceCheckedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceCheckedBy.Location = new System.Drawing.Point(223, 97);
            this.txtInvoiceCheckedBy.Name = "txtInvoiceCheckedBy";
            this.txtInvoiceCheckedBy.Size = new System.Drawing.Size(180, 23);
            this.txtInvoiceCheckedBy.TabIndex = 156;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label31.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label31.Location = new System.Drawing.Point(223, 82);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(180, 16);
            this.label31.TabIndex = 157;
            this.label31.Text = "Checked By";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInvoicePreparedBy
            // 
            this.txtInvoicePreparedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoicePreparedBy.Location = new System.Drawing.Point(15, 97);
            this.txtInvoicePreparedBy.Name = "txtInvoicePreparedBy";
            this.txtInvoicePreparedBy.Size = new System.Drawing.Size(180, 23);
            this.txtInvoicePreparedBy.TabIndex = 154;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label32.Location = new System.Drawing.Point(15, 82);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(180, 16);
            this.label32.TabIndex = 155;
            this.label32.Text = "Prepared By";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label33.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label33.Location = new System.Drawing.Point(0, 221);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(116, 16);
            this.label33.TabIndex = 151;
            this.label33.Text = "Reference Number";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel12.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel12.Location = new System.Drawing.Point(0, 231);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(515, 1);
            this.panel12.TabIndex = 150;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label34.Location = new System.Drawing.Point(0, 9);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(196, 16);
            this.label34.TabIndex = 149;
            this.label34.Text = "Invoice - Default Values";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel13.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel13.Location = new System.Drawing.Point(0, 17);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(515, 1);
            this.panel13.TabIndex = 148;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel14.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel14.Location = new System.Drawing.Point(8, 353);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(515, 1);
            this.panel14.TabIndex = 168;
            // 
            // panelPaymentRequest
            // 
            this.panelPaymentRequest.Controls.Add(this.chkPaymentRequestGenerateReferenceNumber);
            this.panelPaymentRequest.Controls.Add(this.label40);
            this.panelPaymentRequest.Controls.Add(this.panel15);
            this.panelPaymentRequest.Location = new System.Drawing.Point(-1000, 40);
            this.panelPaymentRequest.Name = "panelPaymentRequest";
            this.panelPaymentRequest.Size = new System.Drawing.Size(515, 432);
            this.panelPaymentRequest.TabIndex = 128;
            // 
            // chkPaymentRequestGenerateReferenceNumber
            // 
            this.chkPaymentRequestGenerateReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPaymentRequestGenerateReferenceNumber.Location = new System.Drawing.Point(36, 40);
            this.chkPaymentRequestGenerateReferenceNumber.Name = "chkPaymentRequestGenerateReferenceNumber";
            this.chkPaymentRequestGenerateReferenceNumber.Size = new System.Drawing.Size(213, 20);
            this.chkPaymentRequestGenerateReferenceNumber.TabIndex = 161;
            this.chkPaymentRequestGenerateReferenceNumber.Text = "Generate Reference Number";
            this.chkPaymentRequestGenerateReferenceNumber.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label40.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label40.Location = new System.Drawing.Point(0, 9);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(228, 16);
            this.label40.TabIndex = 149;
            this.label40.Text = "Payment Request - Reference Number";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel15.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel15.Location = new System.Drawing.Point(0, 17);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(515, 1);
            this.panel15.TabIndex = 148;
            // 
            // panelPaymentSettlement
            // 
            this.panelPaymentSettlement.Controls.Add(this.label42);
            this.panelPaymentSettlement.Controls.Add(this.txtPaymentSettlementCheckMaturityDateLength);
            this.panelPaymentSettlement.Controls.Add(this.label43);
            this.panelPaymentSettlement.Controls.Add(this.label53);
            this.panelPaymentSettlement.Controls.Add(this.panel18);
            this.panelPaymentSettlement.Location = new System.Drawing.Point(-1000, 40);
            this.panelPaymentSettlement.Name = "panelPaymentSettlement";
            this.panelPaymentSettlement.Size = new System.Drawing.Size(515, 432);
            this.panelPaymentSettlement.TabIndex = 129;
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label42.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label42.Location = new System.Drawing.Point(218, 38);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(40, 16);
            this.label42.TabIndex = 173;
            this.label42.Text = "Days";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPaymentSettlementCheckMaturityDateLength
            // 
            this.txtPaymentSettlementCheckMaturityDateLength.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentSettlementCheckMaturityDateLength.Location = new System.Drawing.Point(176, 35);
            this.txtPaymentSettlementCheckMaturityDateLength.Name = "txtPaymentSettlementCheckMaturityDateLength";
            this.txtPaymentSettlementCheckMaturityDateLength.Size = new System.Drawing.Size(40, 23);
            this.txtPaymentSettlementCheckMaturityDateLength.TabIndex = 171;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label43.Location = new System.Drawing.Point(34, 38);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(140, 16);
            this.label43.TabIndex = 172;
            this.label43.Text = "Maturity Date Length = ";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label53
            // 
            this.label53.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label53.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label53.Location = new System.Drawing.Point(0, 9);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(220, 16);
            this.label53.TabIndex = 149;
            this.label53.Text = "Payment Settlement - Maturity Date";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel18.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel18.Location = new System.Drawing.Point(0, 17);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(515, 1);
            this.panel18.TabIndex = 148;
            // 
            // panelDrugRegistrationFee
            // 
            this.panelDrugRegistrationFee.Controls.Add(this.label50);
            this.panelDrugRegistrationFee.Controls.Add(this.txtDrugRegistrationFeePercentagePaidByManufacturer);
            this.panelDrugRegistrationFee.Controls.Add(this.label49);
            this.panelDrugRegistrationFee.Controls.Add(this.label47);
            this.panelDrugRegistrationFee.Controls.Add(this.panel16);
            this.panelDrugRegistrationFee.Location = new System.Drawing.Point(-1000, 40);
            this.panelDrugRegistrationFee.Name = "panelDrugRegistrationFee";
            this.panelDrugRegistrationFee.Size = new System.Drawing.Size(515, 432);
            this.panelDrugRegistrationFee.TabIndex = 130;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label50.Location = new System.Drawing.Point(198, 38);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(226, 16);
            this.label50.TabIndex = 158;
            this.label50.Text = "% is paid by the manufacturer.";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDrugRegistrationFeePercentagePaidByManufacturer
            // 
            this.txtDrugRegistrationFeePercentagePaidByManufacturer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugRegistrationFeePercentagePaidByManufacturer.Location = new System.Drawing.Point(168, 34);
            this.txtDrugRegistrationFeePercentagePaidByManufacturer.Name = "txtDrugRegistrationFeePercentagePaidByManufacturer";
            this.txtDrugRegistrationFeePercentagePaidByManufacturer.Size = new System.Drawing.Size(30, 23);
            this.txtDrugRegistrationFeePercentagePaidByManufacturer.TabIndex = 156;
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label49.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label49.Location = new System.Drawing.Point(20, 37);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(148, 16);
            this.label49.TabIndex = 157;
            this.label49.Text = "For drug registration fee";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label47.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label47.Location = new System.Drawing.Point(0, 9);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(132, 16);
            this.label47.TabIndex = 149;
            this.label47.Text = "Drug Registration Fee";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel16.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel16.Location = new System.Drawing.Point(0, 17);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(515, 1);
            this.panel16.TabIndex = 148;
            // 
            // panelDefaults
            // 
            this.panelDefaults.Controls.Add(this.btnSearchDefaultWorkingManufacturer);
            this.panelDefaults.Controls.Add(this.txtDefaultWorkingManufacturer);
            this.panelDefaults.Controls.Add(this.label54);
            this.panelDefaults.Controls.Add(this.cboDefaultWorkingStore);
            this.panelDefaults.Controls.Add(this.cboDefaultWorkingLocation);
            this.panelDefaults.Controls.Add(this.label51);
            this.panelDefaults.Controls.Add(this.label52);
            this.panelDefaults.Controls.Add(this.label57);
            this.panelDefaults.Controls.Add(this.panel17);
            this.panelDefaults.Controls.Add(this.label58);
            this.panelDefaults.Controls.Add(this.panel19);
            this.panelDefaults.Location = new System.Drawing.Point(-1000, 40);
            this.panelDefaults.Name = "panelDefaults";
            this.panelDefaults.Size = new System.Drawing.Size(515, 432);
            this.panelDefaults.TabIndex = 131;
            // 
            // btnSearchDefaultWorkingManufacturer
            // 
            this.btnSearchDefaultWorkingManufacturer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchDefaultWorkingManufacturer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchDefaultWorkingManufacturer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchDefaultWorkingManufacturer.Location = new System.Drawing.Point(373, 175);
            this.btnSearchDefaultWorkingManufacturer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchDefaultWorkingManufacturer.Name = "btnSearchDefaultWorkingManufacturer";
            this.btnSearchDefaultWorkingManufacturer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchDefaultWorkingManufacturer.TabIndex = 181;
            this.btnSearchDefaultWorkingManufacturer.TabStop = false;
            this.btnSearchDefaultWorkingManufacturer.Text = "...";
            this.btnSearchDefaultWorkingManufacturer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchDefaultWorkingManufacturer.UseVisualStyleBackColor = true;
            this.btnSearchDefaultWorkingManufacturer.Click += new System.EventHandler(this.btnSearchDefaultWorkingManufacturer_Click);
            // 
            // txtDefaultWorkingManufacturer
            // 
            this.txtDefaultWorkingManufacturer.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefaultWorkingManufacturer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultWorkingManufacturer.Location = new System.Drawing.Point(15, 178);
            this.txtDefaultWorkingManufacturer.Name = "txtDefaultWorkingManufacturer";
            this.txtDefaultWorkingManufacturer.Size = new System.Drawing.Size(357, 23);
            this.txtDefaultWorkingManufacturer.TabIndex = 180;
            // 
            // label54
            // 
            this.label54.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(15, 162);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(120, 16);
            this.label54.TabIndex = 179;
            this.label54.Text = "Manufacturer";
            // 
            // cboDefaultWorkingStore
            // 
            this.cboDefaultWorkingStore.AllowDrop = true;
            this.cboDefaultWorkingStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDefaultWorkingStore.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboDefaultWorkingStore.FormattingEnabled = true;
            this.cboDefaultWorkingStore.Location = new System.Drawing.Point(223, 53);
            this.cboDefaultWorkingStore.Name = "cboDefaultWorkingStore";
            this.cboDefaultWorkingStore.Size = new System.Drawing.Size(180, 24);
            this.cboDefaultWorkingStore.TabIndex = 163;
            // 
            // cboDefaultWorkingLocation
            // 
            this.cboDefaultWorkingLocation.AllowDrop = true;
            this.cboDefaultWorkingLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDefaultWorkingLocation.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboDefaultWorkingLocation.FormattingEnabled = true;
            this.cboDefaultWorkingLocation.Location = new System.Drawing.Point(15, 53);
            this.cboDefaultWorkingLocation.Name = "cboDefaultWorkingLocation";
            this.cboDefaultWorkingLocation.Size = new System.Drawing.Size(180, 24);
            this.cboDefaultWorkingLocation.TabIndex = 162;
            this.cboDefaultWorkingLocation.SelectedIndexChanged += new System.EventHandler(this.cboDefaultWorkingLocation_SelectedIndexChanged);
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label51.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label51.Location = new System.Drawing.Point(223, 36);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(160, 16);
            this.label51.TabIndex = 161;
            this.label51.Text = "Store";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label52.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label52.Location = new System.Drawing.Point(15, 36);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(143, 16);
            this.label52.TabIndex = 160;
            this.label52.Text = "Location";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label57
            // 
            this.label57.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label57.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label57.Location = new System.Drawing.Point(0, 138);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(182, 16);
            this.label57.TabIndex = 151;
            this.label57.Text = "Default Working Manufacturer";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel17.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel17.Location = new System.Drawing.Point(0, 148);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(515, 1);
            this.panel17.TabIndex = 150;
            // 
            // label58
            // 
            this.label58.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label58.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label58.Location = new System.Drawing.Point(0, 9);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(212, 16);
            this.label58.TabIndex = 149;
            this.label58.Text = "Default Working Location and Store";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel19.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel19.Location = new System.Drawing.Point(0, 17);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(515, 1);
            this.panel19.TabIndex = 148;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel23.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel23.Location = new System.Drawing.Point(0, 17);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(515, 1);
            this.panel23.TabIndex = 148;
            // 
            // label63
            // 
            this.label63.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label63.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label63.Location = new System.Drawing.Point(0, 9);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(159, 16);
            this.label63.TabIndex = 149;
            this.label63.Text = "Proforma - Default Values";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.panel22.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel22.Location = new System.Drawing.Point(0, 200);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(515, 1);
            this.panel22.TabIndex = 150;
            // 
            // label62
            // 
            this.label62.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label62.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label62.Location = new System.Drawing.Point(0, 190);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(116, 16);
            this.label62.TabIndex = 151;
            this.label62.Text = "Reference Number";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label61
            // 
            this.label61.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label61.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label61.Location = new System.Drawing.Point(16, 34);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(180, 16);
            this.label61.TabIndex = 155;
            this.label61.Text = "Requested By";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProformaRequestedBy
            // 
            this.txtProformaRequestedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProformaRequestedBy.Location = new System.Drawing.Point(16, 49);
            this.txtProformaRequestedBy.Name = "txtProformaRequestedBy";
            this.txtProformaRequestedBy.Size = new System.Drawing.Size(180, 23);
            this.txtProformaRequestedBy.TabIndex = 154;
            // 
            // label60
            // 
            this.label60.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label60.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label60.Location = new System.Drawing.Point(16, 85);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(180, 16);
            this.label60.TabIndex = 157;
            this.label60.Text = "Approved By";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProformaApprovedBy
            // 
            this.txtProformaApprovedBy.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProformaApprovedBy.Location = new System.Drawing.Point(16, 100);
            this.txtProformaApprovedBy.Name = "txtProformaApprovedBy";
            this.txtProformaApprovedBy.Size = new System.Drawing.Size(180, 23);
            this.txtProformaApprovedBy.TabIndex = 156;
            // 
            // chkProformaGenerateReferenceNumber
            // 
            this.chkProformaGenerateReferenceNumber.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProformaGenerateReferenceNumber.Location = new System.Drawing.Point(14, 223);
            this.chkProformaGenerateReferenceNumber.Name = "chkProformaGenerateReferenceNumber";
            this.chkProformaGenerateReferenceNumber.Size = new System.Drawing.Size(213, 20);
            this.chkProformaGenerateReferenceNumber.TabIndex = 164;
            this.chkProformaGenerateReferenceNumber.Text = "Generate Reference Number";
            this.chkProformaGenerateReferenceNumber.UseVisualStyleBackColor = true;
            // 
            // panelProforma
            // 
            this.panelProforma.Controls.Add(this.label64);
            this.panelProforma.Controls.Add(this.txtProformaValidityPeriodLength);
            this.panelProforma.Controls.Add(this.chkProformaGenerateReferenceNumber);
            this.panelProforma.Controls.Add(this.txtProformaApprovedBy);
            this.panelProforma.Controls.Add(this.label60);
            this.panelProforma.Controls.Add(this.txtProformaRequestedBy);
            this.panelProforma.Controls.Add(this.label61);
            this.panelProforma.Controls.Add(this.label62);
            this.panelProforma.Controls.Add(this.panel22);
            this.panelProforma.Controls.Add(this.label63);
            this.panelProforma.Controls.Add(this.panel23);
            this.panelProforma.Controls.Add(this.label65);
            this.panelProforma.Location = new System.Drawing.Point(-1000, 40);
            this.panelProforma.Name = "panelProforma";
            this.panelProforma.Size = new System.Drawing.Size(515, 432);
            this.panelProforma.TabIndex = 132;
            // 
            // label64
            // 
            this.label64.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label64.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label64.Location = new System.Drawing.Point(202, 145);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(40, 16);
            this.label64.TabIndex = 176;
            this.label64.Text = "Days";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProformaValidityPeriodLength
            // 
            this.txtProformaValidityPeriodLength.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProformaValidityPeriodLength.Location = new System.Drawing.Point(161, 142);
            this.txtProformaValidityPeriodLength.Name = "txtProformaValidityPeriodLength";
            this.txtProformaValidityPeriodLength.Size = new System.Drawing.Size(35, 23);
            this.txtProformaValidityPeriodLength.TabIndex = 174;
            // 
            // label65
            // 
            this.label65.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label65.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label65.Location = new System.Drawing.Point(16, 145);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(144, 16);
            this.label65.TabIndex = 175;
            this.label65.Text = "Validity Period Length = ";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.Location = new System.Drawing.Point(575, 486);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 26);
            this.btnOk.TabIndex = 106;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::Pharma.Properties.Resources.exit1;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(666, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 26);
            this.btnCancel.TabIndex = 105;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 518);
            this.Controls.Add(this.panelDefaults);
            this.Controls.Add(this.panelDrugRegistrationFee);
            this.Controls.Add(this.panelPaymentSettlement);
            this.Controls.Add(this.panelPaymentRequest);
            this.Controls.Add(this.panelInvoice);
            this.Controls.Add(this.panelGoodsIssuance);
            this.Controls.Add(this.panelGoodsReceiving);
            this.Controls.Add(this.panelPurchaseOrder);
            this.Controls.Add(this.panelSupplierProforma);
            this.Controls.Add(this.panelOrganization);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvwSettings);
            this.Controls.Add(this.panelSuppliesRequisition);
            this.Controls.Add(this.panelProforma);
            this.Controls.Add(this.panelPriceCalculation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart System";
            this.Load += new System.EventHandler(this.frmGeneralSettings_Load);
            this.panelOrganization.ResumeLayout(false);
            this.panelOrganization.PerformLayout();
            this.gbPhoto.ResumeLayout(false);
            this.gbPhoto.PerformLayout();
            this.tsPhoto.ResumeLayout(false);
            this.tsPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelSupplierProforma.ResumeLayout(false);
            this.panelPurchaseOrder.ResumeLayout(false);
            this.panelPriceCalculation.ResumeLayout(false);
            this.panelGoodsReceiving.ResumeLayout(false);
            this.panelGoodsReceiving.PerformLayout();
            this.panelGoodsIssuance.ResumeLayout(false);
            this.panelGoodsIssuance.PerformLayout();
            this.panelSuppliesRequisition.ResumeLayout(false);
            this.panelSuppliesRequisition.PerformLayout();
            this.panelInvoice.ResumeLayout(false);
            this.panelInvoice.PerformLayout();
            this.panelPaymentRequest.ResumeLayout(false);
            this.panelPaymentSettlement.ResumeLayout(false);
            this.panelPaymentSettlement.PerformLayout();
            this.panelDrugRegistrationFee.ResumeLayout(false);
            this.panelDrugRegistrationFee.PerformLayout();
            this.panelDefaults.ResumeLayout(false);
            this.panelDefaults.PerformLayout();
            this.panelProforma.ResumeLayout(false);
            this.panelProforma.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel panelOrganization;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txtOrganizationName;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.GroupBox gbPhoto;
        private System.Windows.Forms.ToolStrip tsPhoto;
        private System.Windows.Forms.ToolStripButton btnRefreshLogo;
        private System.Windows.Forms.ToolStripButton btnImportLogo;
        private System.Windows.Forms.ToolStripButton btnPasteLogo;
        private System.Windows.Forms.ToolStripButton btnClearLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ImageList imageSettings;
        private System.Windows.Forms.OpenFileDialog dlgOpenFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrganizationPOBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrganizationFax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrganizationTelephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSupplierProforma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox cboSupplierProformaTermsOfShipment;
        public System.Windows.Forms.ComboBox cboSupplierProformaDispatch;
        private System.Windows.Forms.CheckBox chkSupplierProformaGenerateNotificationNumber;
        private System.Windows.Forms.Panel panelPurchaseOrder;
        private System.Windows.Forms.CheckBox chkPurchaseOrderGenerateReferenceNumber;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelPriceCalculation;
        private System.Windows.Forms.CheckBox chkAllowPriceRecalculation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelGoodsReceiving;
        private System.Windows.Forms.TextBox txtGoodsReceivingDeliveredBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGoodsReceivingCheckedBy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGoodsReceivingReceivedBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.ComboBox cboGoodsReceivingStore;
        public System.Windows.Forms.ComboBox cboGoodsReceivingLocation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox chkGoodsReceivingGenerateReferenceNumber;
        private System.Windows.Forms.Panel panelGoodsIssuance;
        private System.Windows.Forms.CheckBox chkGoodsIssuanceGenerateReferenceNumber;
        public System.Windows.Forms.ComboBox cboGoodsIssuanceStore;
        public System.Windows.Forms.ComboBox cboGoodsIssuanceLocation;
        public System.Windows.Forms.ComboBox cboGoodsIssuanceIssuedTo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtGoodsIssuanceCheckedBy;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtGoodsIssuanceIssuedBy;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panelSuppliesRequisition;
        private System.Windows.Forms.CheckBox chkSuppliesRequisitionGenerateReferenceNumber;
        private System.Windows.Forms.TextBox txtSuppliesRequisitionApprovedBy;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtSuppliesRequisitionRequestedBy;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.CheckBox chkSuppliesRequisitionRequestorDifferenctFromLicensee;
        private System.Windows.Forms.Panel panelInvoice;
        private System.Windows.Forms.CheckBox chkInvoiceGenerateReferenceNumber;
        public System.Windows.Forms.ComboBox cboInvoiceInvoiceType;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtInvoiceCheckedBy;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtInvoicePreparedBy;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtInvoiceDeliveredBy;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtInvoiceReturningReason;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtInvoiceDueDateLength;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtInvoiceApprovedBy;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panelPaymentRequest;
        private System.Windows.Forms.CheckBox chkPaymentRequestGenerateReferenceNumber;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panelPaymentSettlement;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtPaymentSettlementCheckMaturityDateLength;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panelDrugRegistrationFee;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtGoodsIssuanceIssuedTo;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label lblIssuedTo;
        private System.Windows.Forms.TextBox txtOrganizationTIN;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtOrganizationAddress;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox txtDrugRegistrationFeePercentagePaidByManufacturer;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Panel panelDefaults;
        public System.Windows.Forms.ComboBox cboDefaultWorkingStore;
        public System.Windows.Forms.ComboBox cboDefaultWorkingLocation;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Button btnSearchDefaultWorkingManufacturer;
        private System.Windows.Forms.TextBox txtDefaultWorkingManufacturer;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtOrganizationVAT;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox txtOrganizationMRC;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox txtOrganizationFSNumber;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox txtProformaRequestedBy;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox txtProformaApprovedBy;
        private System.Windows.Forms.CheckBox chkProformaGenerateReferenceNumber;
        private System.Windows.Forms.Panel panelProforma;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox txtProformaValidityPeriodLength;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox txtVATPercentage;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Panel panel14;

    }
}