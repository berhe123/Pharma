namespace Pharma
{
    partial class frmCheckCashing
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
            this.lvwPaymentRequests = new System.Windows.Forms.ListView();
            this.colRequestId = new System.Windows.Forms.ColumnHeader();
            this.colReqOrganizationName = new System.Windows.Forms.ColumnHeader();
            this.colRequestDate = new System.Windows.Forms.ColumnHeader();
            this.colReferenceNo = new System.Windows.Forms.ColumnHeader();
            this.colModeOfPayment = new System.Windows.Forms.ColumnHeader();
            this.colBankGuid = new System.Windows.Forms.ColumnHeader();
            this.colBankBranchName = new System.Windows.Forms.ColumnHeader();
            this.colCheckOrCPONumber = new System.Windows.Forms.ColumnHeader();
            this.colCheckOrCPODate = new System.Windows.Forms.ColumnHeader();
            this.colCheckMaturityDate = new System.Windows.Forms.ColumnHeader();
            this.colSettled = new System.Windows.Forms.ColumnHeader();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnFindCustormer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMaturityDateTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaturityDateFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.ssbValidator = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.txtReferenceNoShow = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRequestDateShow = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtOrganizationName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaturityDate = new System.Windows.Forms.TextBox();
            this.txtCheckCashedDate = new System.Windows.Forms.TextBox();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalReqAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCheckCPODate = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.txtCheckCPONo = new System.Windows.Forms.TextBox();
            this.cboBank = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tsbToolBar = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.line3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpCheck = new System.Windows.Forms.GroupBox();
            this.btnCashThisCheck = new System.Windows.Forms.Button();
            this.grpSettlement = new System.Windows.Forms.GroupBox();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.ssbValidator.SuspendLayout();
            this.grpRequest.SuspendLayout();
            this.tsbToolBar.SuspendLayout();
            this.grpCheck.SuspendLayout();
            this.grpSettlement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwPaymentRequests
            // 
            this.lvwPaymentRequests.CheckBoxes = true;
            this.lvwPaymentRequests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRequestId,
            this.colReqOrganizationName,
            this.colRequestDate,
            this.colReferenceNo,
            this.colModeOfPayment,
            this.colBankGuid,
            this.colBankBranchName,
            this.colCheckOrCPONumber,
            this.colCheckOrCPODate,
            this.colCheckMaturityDate,
            this.colSettled});
            this.lvwPaymentRequests.FullRowSelect = true;
            this.lvwPaymentRequests.GridLines = true;
            this.lvwPaymentRequests.Location = new System.Drawing.Point(8, 190);
            this.lvwPaymentRequests.Name = "lvwPaymentRequests";
            this.lvwPaymentRequests.Size = new System.Drawing.Size(485, 382);
            this.lvwPaymentRequests.TabIndex = 11;
            this.lvwPaymentRequests.UseCompatibleStateImageBehavior = false;
            this.lvwPaymentRequests.View = System.Windows.Forms.View.Details;
            this.lvwPaymentRequests.SelectedIndexChanged += new System.EventHandler(this.lvwPaymentRequests_SelectedIndexChanged);
            this.lvwPaymentRequests.Click += new System.EventHandler(this.lvwPaymentRequests_Click);
            // 
            // colRequestId
            // 
            this.colRequestId.Text = "Id";
            this.colRequestId.Width = 0;
            // 
            // colReqOrganizationName
            // 
            this.colReqOrganizationName.Text = "Customer Name";
            this.colReqOrganizationName.Width = 0;
            // 
            // colRequestDate
            // 
            this.colRequestDate.Text = "Request Date";
            this.colRequestDate.Width = 0;
            // 
            // colReferenceNo
            // 
            this.colReferenceNo.Text = "ReferenceNo";
            this.colReferenceNo.Width = 0;
            // 
            // colModeOfPayment
            // 
            this.colModeOfPayment.Text = "Mode Of Payment";
            this.colModeOfPayment.Width = 0;
            // 
            // colBankGuid
            // 
            this.colBankGuid.Text = "BankGuid";
            this.colBankGuid.Width = 0;
            // 
            // colBankBranchName
            // 
            this.colBankBranchName.Text = "BankBranchName";
            this.colBankBranchName.Width = 0;
            // 
            // colCheckOrCPONumber
            // 
            this.colCheckOrCPONumber.Text = "Check Number";
            this.colCheckOrCPONumber.Width = 150;
            // 
            // colCheckOrCPODate
            // 
            this.colCheckOrCPODate.Text = "Check Date";
            this.colCheckOrCPODate.Width = 150;
            // 
            // colCheckMaturityDate
            // 
            this.colCheckMaturityDate.Text = "Check Maturity Date";
            this.colCheckMaturityDate.Width = 150;
            // 
            // colSettled
            // 
            this.colSettled.Text = "Settled";
            this.colSettled.Width = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnFindCustormer);
            this.grpFilter.Controls.Add(this.txtCustomerName);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.txtMaturityDateTo);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Controls.Add(this.txtMaturityDateFrom);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Location = new System.Drawing.Point(8, 46);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(4);
            this.grpFilter.Size = new System.Drawing.Size(485, 138);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // btnFindCustormer
            // 
            this.btnFindCustormer.Location = new System.Drawing.Point(420, 35);
            this.btnFindCustormer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindCustormer.Name = "btnFindCustormer";
            this.btnFindCustormer.Size = new System.Drawing.Size(48, 24);
            this.btnFindCustormer.TabIndex = 5;
            this.btnFindCustormer.Text = "Find";
            this.btnFindCustormer.UseVisualStyleBackColor = true;
            this.btnFindCustormer.Click += new System.EventHandler(this.btnFindCustormer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(12, 36);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(404, 22);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 109);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(280, 24);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMaturityDateTo
            // 
            this.txtMaturityDateTo.Location = new System.Drawing.Point(162, 81);
            this.txtMaturityDateTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaturityDateTo.Name = "txtMaturityDateTo";
            this.txtMaturityDateTo.Size = new System.Drawing.Size(131, 22);
            this.txtMaturityDateTo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maturity Date To";
            // 
            // txtMaturityDateFrom
            // 
            this.txtMaturityDateFrom.Location = new System.Drawing.Point(12, 81);
            this.txtMaturityDateFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaturityDateFrom.Name = "txtMaturityDateFrom";
            this.txtMaturityDateFrom.Size = new System.Drawing.Size(131, 22);
            this.txtMaturityDateFrom.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Maturity Date From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customers Organization Name";
            // 
            // mValidator
            // 
            this.mValidator.ContainerControl = this;
            // 
            // ssbValidator
            // 
            this.ssbValidator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssbValidator.Location = new System.Drawing.Point(0, 577);
            this.ssbValidator.Name = "ssbValidator";
            this.ssbValidator.Size = new System.Drawing.Size(1016, 22);
            this.ssbValidator.TabIndex = 38;
            this.ssbValidator.Text = "statusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.txtReferenceNoShow);
            this.grpRequest.Controls.Add(this.label18);
            this.grpRequest.Controls.Add(this.txtRequestDateShow);
            this.grpRequest.Controls.Add(this.label19);
            this.grpRequest.Controls.Add(this.txtOrganizationName);
            this.grpRequest.Controls.Add(this.label16);
            this.grpRequest.Location = new System.Drawing.Point(502, 72);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(504, 112);
            this.grpRequest.TabIndex = 12;
            this.grpRequest.TabStop = false;
            // 
            // txtReferenceNoShow
            // 
            this.txtReferenceNoShow.Location = new System.Drawing.Point(7, 80);
            this.txtReferenceNoShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReferenceNoShow.Name = "txtReferenceNoShow";
            this.txtReferenceNoShow.ReadOnly = true;
            this.txtReferenceNoShow.Size = new System.Drawing.Size(203, 22);
            this.txtReferenceNoShow.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 64);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 14);
            this.label18.TabIndex = 15;
            this.label18.Text = "Reference No";
            // 
            // txtRequestDateShow
            // 
            this.txtRequestDateShow.Location = new System.Drawing.Point(221, 78);
            this.txtRequestDateShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRequestDateShow.Name = "txtRequestDateShow";
            this.txtRequestDateShow.ReadOnly = true;
            this.txtRequestDateShow.Size = new System.Drawing.Size(131, 22);
            this.txtRequestDateShow.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(221, 62);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 14);
            this.label19.TabIndex = 17;
            this.label19.Text = "Request Date";
            // 
            // txtOrganizationName
            // 
            this.txtOrganizationName.Location = new System.Drawing.Point(7, 32);
            this.txtOrganizationName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.ReadOnly = true;
            this.txtOrganizationName.Size = new System.Drawing.Size(485, 22);
            this.txtOrganizationName.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 16);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 14);
            this.label16.TabIndex = 13;
            this.label16.Text = "Customers Organization Name";
            // 
            // txtMaturityDate
            // 
            this.txtMaturityDate.Location = new System.Drawing.Point(10, 36);
            this.txtMaturityDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaturityDate.Name = "txtMaturityDate";
            this.txtMaturityDate.ReadOnly = true;
            this.txtMaturityDate.Size = new System.Drawing.Size(131, 22);
            this.txtMaturityDate.TabIndex = 34;
            // 
            // txtCheckCashedDate
            // 
            this.txtCheckCashedDate.Location = new System.Drawing.Point(221, 36);
            this.txtCheckCashedDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckCashedDate.Name = "txtCheckCashedDate";
            this.txtCheckCashedDate.Size = new System.Drawing.Size(131, 22);
            this.txtCheckCashedDate.TabIndex = 36;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(221, 32);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.ReadOnly = true;
            this.txtBranchName.Size = new System.Drawing.Size(271, 22);
            this.txtBranchName.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 14);
            this.label7.TabIndex = 35;
            this.label7.Text = "Check Cashed Date";
            // 
            // txtTotalReqAmount
            // 
            this.txtTotalReqAmount.ForeColor = System.Drawing.Color.Red;
            this.txtTotalReqAmount.Location = new System.Drawing.Point(364, 122);
            this.txtTotalReqAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalReqAmount.Name = "txtTotalReqAmount";
            this.txtTotalReqAmount.ReadOnly = true;
            this.txtTotalReqAmount.Size = new System.Drawing.Size(128, 22);
            this.txtTotalReqAmount.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 14);
            this.label12.TabIndex = 33;
            this.label12.Text = "Maturity Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 14);
            this.label9.TabIndex = 30;
            this.label9.Text = "Check Amount";
            // 
            // txtCheckCPODate
            // 
            this.txtCheckCPODate.Location = new System.Drawing.Point(221, 122);
            this.txtCheckCPODate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckCPODate.Name = "txtCheckCPODate";
            this.txtCheckCPODate.ReadOnly = true;
            this.txtCheckCPODate.Size = new System.Drawing.Size(131, 22);
            this.txtCheckCPODate.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(221, 18);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 14);
            this.label14.TabIndex = 22;
            this.label14.Text = "Branch Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(221, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 14);
            this.label11.TabIndex = 28;
            this.label11.Text = "Check Date";
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.Enabled = false;
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Location = new System.Drawing.Point(10, 78);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(203, 22);
            this.cboPaymentType.TabIndex = 25;
            // 
            // txtCheckCPONo
            // 
            this.txtCheckCPONo.Location = new System.Drawing.Point(10, 122);
            this.txtCheckCPONo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckCPONo.Name = "txtCheckCPONo";
            this.txtCheckCPONo.ReadOnly = true;
            this.txtCheckCPONo.Size = new System.Drawing.Size(203, 22);
            this.txtCheckCPONo.TabIndex = 27;
            // 
            // cboBank
            // 
            this.cboBank.Enabled = false;
            this.cboBank.FormattingEnabled = true;
            this.cboBank.Location = new System.Drawing.Point(10, 32);
            this.cboBank.Name = "cboBank";
            this.cboBank.Size = new System.Drawing.Size(203, 22);
            this.cboBank.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 108);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 14);
            this.label10.TabIndex = 26;
            this.label10.Text = "Check Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 14);
            this.label13.TabIndex = 20;
            this.label13.Text = "Bank";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 14);
            this.label15.TabIndex = 24;
            this.label15.Text = "Mode of Payment";
            // 
            // tsbToolBar
            // 
            this.tsbToolBar.AutoSize = false;
            this.tsbToolBar.BackColor = System.Drawing.Color.Transparent;
            this.tsbToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose});
            this.tsbToolBar.Location = new System.Drawing.Point(502, 46);
            this.tsbToolBar.Name = "tsbToolBar";
            this.tsbToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsbToolBar.Size = new System.Drawing.Size(504, 25);
            this.tsbToolBar.TabIndex = 39;
            this.tsbToolBar.Text = "toolStrip1";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 22);
            this.btnClose.Text = "Close";
            this.btnClose.ToolTipText = "Close the Check Cashing dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(-1, 36);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(1022, 1);
            this.line3.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(-1, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1022, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "    Check Cashing";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpCheck
            // 
            this.grpCheck.Controls.Add(this.btnCashThisCheck);
            this.grpCheck.Controls.Add(this.label7);
            this.grpCheck.Controls.Add(this.txtMaturityDate);
            this.grpCheck.Controls.Add(this.txtCheckCashedDate);
            this.grpCheck.Controls.Add(this.label12);
            this.grpCheck.Location = new System.Drawing.Point(502, 348);
            this.grpCheck.Name = "grpCheck";
            this.grpCheck.Size = new System.Drawing.Size(504, 72);
            this.grpCheck.TabIndex = 32;
            this.grpCheck.TabStop = false;
            // 
            // btnCashThisCheck
            // 
            this.btnCashThisCheck.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnCashThisCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashThisCheck.Location = new System.Drawing.Point(354, 35);
            this.btnCashThisCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCashThisCheck.Name = "btnCashThisCheck";
            this.btnCashThisCheck.Size = new System.Drawing.Size(138, 24);
            this.btnCashThisCheck.TabIndex = 37;
            this.btnCashThisCheck.Text = "Cash This Check";
            this.btnCashThisCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashThisCheck.UseVisualStyleBackColor = true;
            this.btnCashThisCheck.Click += new System.EventHandler(this.btnCashThisCheck_Click);
            // 
            // grpSettlement
            // 
            this.grpSettlement.Controls.Add(this.txtBranchName);
            this.grpSettlement.Controls.Add(this.label14);
            this.grpSettlement.Controls.Add(this.txtCheckCPODate);
            this.grpSettlement.Controls.Add(this.cboBank);
            this.grpSettlement.Controls.Add(this.cboPaymentType);
            this.grpSettlement.Controls.Add(this.label13);
            this.grpSettlement.Controls.Add(this.txtTotalReqAmount);
            this.grpSettlement.Controls.Add(this.label11);
            this.grpSettlement.Controls.Add(this.label10);
            this.grpSettlement.Controls.Add(this.label15);
            this.grpSettlement.Controls.Add(this.txtCheckCPONo);
            this.grpSettlement.Controls.Add(this.label9);
            this.grpSettlement.Location = new System.Drawing.Point(502, 190);
            this.grpSettlement.Name = "grpSettlement";
            this.grpSettlement.Size = new System.Drawing.Size(504, 154);
            this.grpSettlement.TabIndex = 19;
            this.grpSettlement.TabStop = false;
            // 
            // frmCheckCashing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1016, 599);
            this.Controls.Add(this.grpSettlement);
            this.Controls.Add(this.grpCheck);
            this.Controls.Add(this.lvwPaymentRequests);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpRequest);
            this.Controls.Add(this.ssbValidator);
            this.Controls.Add(this.tsbToolBar);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCheckCashing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPaymentRequest_Load);
            this.Resize += new System.EventHandler(this.frmCheckCashing_Resize);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.ssbValidator.ResumeLayout(false);
            this.ssbValidator.PerformLayout();
            this.grpRequest.ResumeLayout(false);
            this.grpRequest.PerformLayout();
            this.tsbToolBar.ResumeLayout(false);
            this.tsbToolBar.PerformLayout();
            this.grpCheck.ResumeLayout(false);
            this.grpCheck.PerformLayout();
            this.grpSettlement.ResumeLayout(false);
            this.grpSettlement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFindCustormer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMaturityDateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaturityDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.StatusStrip ssbValidator;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ListView lvwPaymentRequests;
        private System.Windows.Forms.ColumnHeader colRequestId;
        private System.Windows.Forms.ColumnHeader colRequestDate;
        private System.Windows.Forms.ColumnHeader colReferenceNo;
        private System.Windows.Forms.ColumnHeader colModeOfPayment;
        private System.Windows.Forms.ColumnHeader colBankGuid;
        private System.Windows.Forms.ColumnHeader colBankBranchName;
        private System.Windows.Forms.ColumnHeader colCheckOrCPONumber;
        private System.Windows.Forms.ColumnHeader colCheckOrCPODate;
        private System.Windows.Forms.ColumnHeader colCheckMaturityDate;
        private System.Windows.Forms.ColumnHeader colSettled;
        private System.Windows.Forms.ColumnHeader colReqOrganizationName;
        private System.Windows.Forms.GroupBox grpRequest;
        private System.Windows.Forms.ToolStrip tsbToolBar;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.TextBox txtMaturityDate;
        private System.Windows.Forms.TextBox txtCheckCashedDate;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalReqAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReferenceNoShow;
        private System.Windows.Forms.TextBox txtCheckCPODate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.TextBox txtCheckCPONo;
        private System.Windows.Forms.ComboBox cboBank;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtRequestDateShow;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtOrganizationName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSettlement;
        private System.Windows.Forms.GroupBox grpCheck;
        public System.Windows.Forms.Button btnCashThisCheck;
    }
}