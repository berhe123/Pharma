namespace Pharma
{
    partial class frmPaymentSettlement
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
            this.cboSettlementStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFindCustormer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRequestDateTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRequestDateFrom = new System.Windows.Forms.TextBox();
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
            this.grpSettlement = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSettle = new System.Windows.Forms.Button();
            this.grbCheckCPOInfo = new System.Windows.Forms.GroupBox();
            this.txtCheckCPOAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboBank = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaturityDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCheckCPODate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCheckCPONo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboPaymentType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSettlementDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalReqAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lvwRequestInvoices = new System.Windows.Forms.ListView();
            this.colCashCollectionInvoiceId = new System.Windows.Forms.ColumnHeader();
            this.colReqInvoiceId = new System.Windows.Forms.ColumnHeader();
            this.colReqInvoiceNo = new System.Windows.Forms.ColumnHeader();
            this.colItemCount = new System.Windows.Forms.ColumnHeader();
            this.colInvoiceTotalAmount = new System.Windows.Forms.ColumnHeader();
            this.tsbToolBar = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.line3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.ssbValidator.SuspendLayout();
            this.grpRequest.SuspendLayout();
            this.grpSettlement.SuspendLayout();
            this.grbCheckCPOInfo.SuspendLayout();
            this.tsbToolBar.SuspendLayout();
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
            this.lvwPaymentRequests.Location = new System.Drawing.Point(11, 207);
            this.lvwPaymentRequests.Name = "lvwPaymentRequests";
            this.lvwPaymentRequests.Size = new System.Drawing.Size(390, 481);
            this.lvwPaymentRequests.TabIndex = 11;
            this.lvwPaymentRequests.UseCompatibleStateImageBehavior = false;
            this.lvwPaymentRequests.View = System.Windows.Forms.View.Details;
            this.lvwPaymentRequests.SelectedIndexChanged += new System.EventHandler(this.lvwPaymentRequests_SelectedIndexChanged);
            // 
            // colRequestId
            // 
            this.colRequestId.Text = "Id";
            this.colRequestId.Width = 0;
            // 
            // colReqOrganizationName
            // 
            this.colReqOrganizationName.Text = "Customer Name";
            this.colReqOrganizationName.Width = 150;
            // 
            // colRequestDate
            // 
            this.colRequestDate.Text = "Request Date";
            this.colRequestDate.Width = 100;
            // 
            // colReferenceNo
            // 
            this.colReferenceNo.Text = "ReferenceNo";
            this.colReferenceNo.Width = 100;
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
            this.colCheckOrCPONumber.Text = "CheckOrCPONumber";
            this.colCheckOrCPONumber.Width = 0;
            // 
            // colCheckOrCPODate
            // 
            this.colCheckOrCPODate.Text = "CheckOrCPODate";
            this.colCheckOrCPODate.Width = 0;
            // 
            // colCheckMaturityDate
            // 
            this.colCheckMaturityDate.Text = "CheckMaturityDate";
            this.colCheckMaturityDate.Width = 0;
            // 
            // colSettled
            // 
            this.colSettled.Text = "Settled";
            this.colSettled.Width = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.cboSettlementStatus);
            this.grpFilter.Controls.Add(this.label9);
            this.grpFilter.Controls.Add(this.btnFindCustormer);
            this.grpFilter.Controls.Add(this.txtCustomerName);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.txtRequestDateTo);
            this.grpFilter.Controls.Add(this.label5);
            this.grpFilter.Controls.Add(this.txtRequestDateFrom);
            this.grpFilter.Controls.Add(this.label6);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Location = new System.Drawing.Point(11, 38);
            this.grpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Padding = new System.Windows.Forms.Padding(4);
            this.grpFilter.Size = new System.Drawing.Size(390, 162);
            this.grpFilter.TabIndex = 2;
            this.grpFilter.TabStop = false;
            // 
            // cboSettlementStatus
            // 
            this.cboSettlementStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSettlementStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSettlementStatus.FormattingEnabled = true;
            this.cboSettlementStatus.Location = new System.Drawing.Point(5, 126);
            this.cboSettlementStatus.Name = "cboSettlementStatus";
            this.cboSettlementStatus.Size = new System.Drawing.Size(278, 24);
            this.cboSettlementStatus.TabIndex = 166;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 14);
            this.label9.TabIndex = 165;
            this.label9.Text = "Settlement Status";
            // 
            // btnFindCustormer
            // 
            this.btnFindCustormer.Location = new System.Drawing.Point(294, 38);
            this.btnFindCustormer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFindCustormer.Name = "btnFindCustormer";
            this.btnFindCustormer.Size = new System.Drawing.Size(72, 24);
            this.btnFindCustormer.TabIndex = 5;
            this.btnFindCustormer.Text = "Find";
            this.btnFindCustormer.UseVisualStyleBackColor = true;
            this.btnFindCustormer.Click += new System.EventHandler(this.btnFindCustormer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(8, 38);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(278, 22);
            this.txtCustomerName.TabIndex = 4;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(294, 126);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 24);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRequestDateTo
            // 
            this.txtRequestDateTo.Location = new System.Drawing.Point(155, 84);
            this.txtRequestDateTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRequestDateTo.Name = "txtRequestDateTo";
            this.txtRequestDateTo.Size = new System.Drawing.Size(131, 22);
            this.txtRequestDateTo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Request Date To";
            // 
            // txtRequestDateFrom
            // 
            this.txtRequestDateFrom.Location = new System.Drawing.Point(8, 84);
            this.txtRequestDateFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRequestDateFrom.Name = "txtRequestDateFrom";
            this.txtRequestDateFrom.Size = new System.Drawing.Size(131, 22);
            this.txtRequestDateFrom.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Request Date From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
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
            this.ssbValidator.Location = new System.Drawing.Point(0, 728);
            this.ssbValidator.Name = "ssbValidator";
            this.ssbValidator.Size = new System.Drawing.Size(1003, 22);
            this.ssbValidator.TabIndex = 39;
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
            this.grpRequest.Location = new System.Drawing.Point(412, 79);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(584, 108);
            this.grpRequest.TabIndex = 12;
            this.grpRequest.TabStop = false;
            // 
            // txtReferenceNoShow
            // 
            this.txtReferenceNoShow.Location = new System.Drawing.Point(10, 75);
            this.txtReferenceNoShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtReferenceNoShow.Name = "txtReferenceNoShow";
            this.txtReferenceNoShow.ReadOnly = true;
            this.txtReferenceNoShow.Size = new System.Drawing.Size(213, 22);
            this.txtReferenceNoShow.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 59);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(123, 14);
            this.label18.TabIndex = 15;
            this.label18.Text = "Reference Number";
            // 
            // txtRequestDateShow
            // 
            this.txtRequestDateShow.Location = new System.Drawing.Point(231, 75);
            this.txtRequestDateShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRequestDateShow.Name = "txtRequestDateShow";
            this.txtRequestDateShow.ReadOnly = true;
            this.txtRequestDateShow.Size = new System.Drawing.Size(183, 22);
            this.txtRequestDateShow.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(231, 59);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 14);
            this.label19.TabIndex = 17;
            this.label19.Text = "Request Date";
            // 
            // txtOrganizationName
            // 
            this.txtOrganizationName.Location = new System.Drawing.Point(13, 34);
            this.txtOrganizationName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrganizationName.Name = "txtOrganizationName";
            this.txtOrganizationName.ReadOnly = true;
            this.txtOrganizationName.Size = new System.Drawing.Size(401, 22);
            this.txtOrganizationName.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 18);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 14);
            this.label16.TabIndex = 13;
            this.label16.Text = "Customers Organization Name";
            // 
            // grpSettlement
            // 
            this.grpSettlement.Controls.Add(this.btnNew);
            this.grpSettlement.Controls.Add(this.btnSettle);
            this.grpSettlement.Controls.Add(this.grbCheckCPOInfo);
            this.grpSettlement.Controls.Add(this.cboPaymentType);
            this.grpSettlement.Controls.Add(this.label15);
            this.grpSettlement.Controls.Add(this.txtSettlementDate);
            this.grpSettlement.Controls.Add(this.label7);
            this.grpSettlement.Location = new System.Drawing.Point(412, 193);
            this.grpSettlement.Name = "grpSettlement";
            this.grpSettlement.Size = new System.Drawing.Size(584, 234);
            this.grpSettlement.TabIndex = 19;
            this.grpSettlement.TabStop = false;
            this.grpSettlement.Text = "Settlement";
            // 
            // btnNew
            // 
            this.btnNew.Image = global::Pharma.Properties.Resources.New;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(455, 29);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 29);
            this.btnNew.TabIndex = 63;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSettle
            // 
            this.btnSettle.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnSettle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettle.Location = new System.Drawing.Point(338, 29);
            this.btnSettle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(110, 29);
            this.btnSettle.TabIndex = 35;
            this.btnSettle.Text = "     Settle";
            this.btnSettle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettle.UseVisualStyleBackColor = true;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // grbCheckCPOInfo
            // 
            this.grbCheckCPOInfo.Controls.Add(this.txtCheckCPOAmount);
            this.grbCheckCPOInfo.Controls.Add(this.label2);
            this.grbCheckCPOInfo.Controls.Add(this.txtBranchName);
            this.grbCheckCPOInfo.Controls.Add(this.label14);
            this.grbCheckCPOInfo.Controls.Add(this.cboBank);
            this.grbCheckCPOInfo.Controls.Add(this.label13);
            this.grbCheckCPOInfo.Controls.Add(this.txtMaturityDate);
            this.grbCheckCPOInfo.Controls.Add(this.label12);
            this.grbCheckCPOInfo.Controls.Add(this.txtCheckCPODate);
            this.grbCheckCPOInfo.Controls.Add(this.label11);
            this.grbCheckCPOInfo.Controls.Add(this.txtCheckCPONo);
            this.grbCheckCPOInfo.Controls.Add(this.label10);
            this.grbCheckCPOInfo.Location = new System.Drawing.Point(10, 110);
            this.grbCheckCPOInfo.Name = "grbCheckCPOInfo";
            this.grbCheckCPOInfo.Size = new System.Drawing.Size(574, 110);
            this.grbCheckCPOInfo.TabIndex = 24;
            this.grbCheckCPOInfo.TabStop = false;
            this.grbCheckCPOInfo.Text = "Mode of Payment Detail";
            // 
            // txtCheckCPOAmount
            // 
            this.txtCheckCPOAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCheckCPOAmount.Location = new System.Drawing.Point(276, 81);
            this.txtCheckCPOAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckCPOAmount.Name = "txtCheckCPOAmount";
            this.txtCheckCPOAmount.Size = new System.Drawing.Size(129, 22);
            this.txtCheckCPOAmount.TabIndex = 39;
            this.txtCheckCPOAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 14);
            this.label2.TabIndex = 38;
            this.label2.Text = "Check/CPO Amount";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(276, 31);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(288, 22);
            this.txtBranchName.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(276, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 14);
            this.label14.TabIndex = 27;
            this.label14.Text = "Branch Name";
            // 
            // cboBank
            // 
            this.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBank.FormattingEnabled = true;
            this.cboBank.Location = new System.Drawing.Point(12, 31);
            this.cboBank.Name = "cboBank";
            this.cboBank.Size = new System.Drawing.Size(252, 22);
            this.cboBank.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 14);
            this.label13.TabIndex = 25;
            this.label13.Text = "Bank";
            // 
            // txtMaturityDate
            // 
            this.txtMaturityDate.Location = new System.Drawing.Point(442, 81);
            this.txtMaturityDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaturityDate.Name = "txtMaturityDate";
            this.txtMaturityDate.Size = new System.Drawing.Size(118, 22);
            this.txtMaturityDate.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(442, 67);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 14);
            this.label12.TabIndex = 33;
            this.label12.Text = "Maturity Date";
            // 
            // txtCheckCPODate
            // 
            this.txtCheckCPODate.Location = new System.Drawing.Point(153, 81);
            this.txtCheckCPODate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckCPODate.Name = "txtCheckCPODate";
            this.txtCheckCPODate.Size = new System.Drawing.Size(111, 22);
            this.txtCheckCPODate.TabIndex = 32;
            this.txtCheckCPODate.TextChanged += new System.EventHandler(this.txtCheckCPODate_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 14);
            this.label11.TabIndex = 31;
            this.label11.Text = "Check/CPO Date";
            // 
            // txtCheckCPONo
            // 
            this.txtCheckCPONo.Location = new System.Drawing.Point(12, 81);
            this.txtCheckCPONo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCheckCPONo.Name = "txtCheckCPONo";
            this.txtCheckCPONo.Size = new System.Drawing.Size(130, 22);
            this.txtCheckCPONo.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 14);
            this.label10.TabIndex = 29;
            this.label10.Text = "Check/CPO Number";
            // 
            // cboPaymentType
            // 
            this.cboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentType.FormattingEnabled = true;
            this.cboPaymentType.Location = new System.Drawing.Point(172, 36);
            this.cboPaymentType.Name = "cboPaymentType";
            this.cboPaymentType.Size = new System.Drawing.Size(152, 22);
            this.cboPaymentType.TabIndex = 23;
            this.cboPaymentType.SelectedIndexChanged += new System.EventHandler(this.cboPaymentType_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(172, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 14);
            this.label15.TabIndex = 22;
            this.label15.Text = "Mode of Payment";
            // 
            // txtSettlementDate
            // 
            this.txtSettlementDate.Location = new System.Drawing.Point(10, 36);
            this.txtSettlementDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSettlementDate.Name = "txtSettlementDate";
            this.txtSettlementDate.Size = new System.Drawing.Size(152, 22);
            this.txtSettlementDate.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 14);
            this.label7.TabIndex = 20;
            this.label7.Text = "Settlement Date";
            // 
            // txtTotalReqAmount
            // 
            this.txtTotalReqAmount.ForeColor = System.Drawing.Color.Red;
            this.txtTotalReqAmount.Location = new System.Drawing.Point(665, 666);
            this.txtTotalReqAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalReqAmount.Name = "txtTotalReqAmount";
            this.txtTotalReqAmount.Size = new System.Drawing.Size(151, 22);
            this.txtTotalReqAmount.TabIndex = 38;
            this.txtTotalReqAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Location = new System.Drawing.Point(567, 666);
            this.lblTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(95, 22);
            this.lblTotalAmount.TabIndex = 37;
            this.lblTotalAmount.Text = "Total Amount:";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lvwRequestInvoices
            // 
            this.lvwRequestInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCashCollectionInvoiceId,
            this.colReqInvoiceId,
            this.colReqInvoiceNo,
            this.colItemCount,
            this.colInvoiceTotalAmount});
            this.lvwRequestInvoices.FullRowSelect = true;
            this.lvwRequestInvoices.GridLines = true;
            this.lvwRequestInvoices.Location = new System.Drawing.Point(412, 433);
            this.lvwRequestInvoices.Name = "lvwRequestInvoices";
            this.lvwRequestInvoices.Size = new System.Drawing.Size(584, 227);
            this.lvwRequestInvoices.TabIndex = 36;
            this.lvwRequestInvoices.UseCompatibleStateImageBehavior = false;
            this.lvwRequestInvoices.View = System.Windows.Forms.View.Details;
            // 
            // colCashCollectionInvoiceId
            // 
            this.colCashCollectionInvoiceId.Text = "Id";
            this.colCashCollectionInvoiceId.Width = 0;
            // 
            // colReqInvoiceId
            // 
            this.colReqInvoiceId.Text = "id";
            this.colReqInvoiceId.Width = 0;
            // 
            // colReqInvoiceNo
            // 
            this.colReqInvoiceNo.Text = "Invoice Number";
            this.colReqInvoiceNo.Width = 150;
            // 
            // colItemCount
            // 
            this.colItemCount.Text = "Item Count";
            this.colItemCount.Width = 100;
            // 
            // colInvoiceTotalAmount
            // 
            this.colInvoiceTotalAmount.Text = "Invoice Total";
            this.colInvoiceTotalAmount.Width = 150;
            // 
            // tsbToolBar
            // 
            this.tsbToolBar.AutoSize = false;
            this.tsbToolBar.BackColor = System.Drawing.Color.Transparent;
            this.tsbToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose});
            this.tsbToolBar.Location = new System.Drawing.Point(412, 47);
            this.tsbToolBar.Name = "tsbToolBar";
            this.tsbToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsbToolBar.Size = new System.Drawing.Size(584, 25);
            this.tsbToolBar.TabIndex = 40;
            this.tsbToolBar.Text = "toolStrip1";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 22);
            this.btnClose.Text = "Close";
            this.btnClose.ToolTipText = "Close the Payment Settlement dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(0, 36);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(777, 1);
            this.line3.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(777, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "    Payment Settlement";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmPaymentSettlement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1003, 750);
            this.Controls.Add(this.grpSettlement);
            this.Controls.Add(this.txtTotalReqAmount);
            this.Controls.Add(this.lvwPaymentRequests);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpRequest);
            this.Controls.Add(this.ssbValidator);
            this.Controls.Add(this.tsbToolBar);
            this.Controls.Add(this.lvwRequestInvoices);
            this.Controls.Add(this.grpFilter);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPaymentSettlement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPaymentRequest_Load);
            this.Resize += new System.EventHandler(this.frmPaymentSettlement_Resize);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.ssbValidator.ResumeLayout(false);
            this.ssbValidator.PerformLayout();
            this.grpRequest.ResumeLayout(false);
            this.grpRequest.PerformLayout();
            this.grpSettlement.ResumeLayout(false);
            this.grpSettlement.PerformLayout();
            this.grbCheckCPOInfo.ResumeLayout(false);
            this.grbCheckCPOInfo.PerformLayout();
            this.tsbToolBar.ResumeLayout(false);
            this.tsbToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFindCustormer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtRequestDateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRequestDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.StatusStrip ssbValidator;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.GroupBox grpRequest;
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
        private System.Windows.Forms.TextBox txtReferenceNoShow;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRequestDateShow;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtOrganizationName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ColumnHeader colReqOrganizationName;
        private System.Windows.Forms.GroupBox grpSettlement;
        private System.Windows.Forms.TextBox txtTotalReqAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.GroupBox grbCheckCPOInfo;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboBank;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaturityDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCheckCPODate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCheckCPONo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboPaymentType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSettlementDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip tsbToolBar;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ListView lvwRequestInvoices;
        private System.Windows.Forms.ColumnHeader colReqInvoiceId;
        private System.Windows.Forms.ColumnHeader colReqInvoiceNo;
        private System.Windows.Forms.ColumnHeader colItemCount;
        private System.Windows.Forms.ColumnHeader colInvoiceTotalAmount;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ColumnHeader colCashCollectionInvoiceId;
        public System.Windows.Forms.Button btnSettle;
        public System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtCheckCPOAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSettlementStatus;
        private System.Windows.Forms.Label label9;
    }
}