namespace Pharma
{
    partial class frmBidsListReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBidsListReport));
            this.grpReportType = new System.Windows.Forms.GroupBox();
            this.optAll = new System.Windows.Forms.RadioButton();
            this.optLocal = new System.Windows.Forms.RadioButton();
            this.optInternationalBid = new System.Windows.Forms.RadioButton();
            this.grpAnnouncement = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnnouncementDateTo = new System.Windows.Forms.TextBox();
            this.txtAnnouncementDateFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer1 = new System.Windows.Forms.Button();
            this.txtCustomerFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpBidStatus = new System.Windows.Forms.GroupBox();
            this.cboBidStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkAnnouncementDate = new System.Windows.Forms.CheckBox();
            this.chkBidDocumentPurchaseDate = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPurchaseDateTo = new System.Windows.Forms.TextBox();
            this.txtPurchaseDateFrom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkBidOpening = new System.Windows.Forms.CheckBox();
            this.chkBidSubmissionDeadline = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpeningDateTo = new System.Windows.Forms.TextBox();
            this.txtOpeningDateFrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubmissionDeadlineDateTo = new System.Windows.Forms.TextBox();
            this.txtSubmissionDeadlineDateFrom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpReportType.SuspendLayout();
            this.grpAnnouncement.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpBidStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReportType
            // 
            this.grpReportType.Controls.Add(this.optAll);
            this.grpReportType.Controls.Add(this.optLocal);
            this.grpReportType.Controls.Add(this.optInternationalBid);
            this.grpReportType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportType.Location = new System.Drawing.Point(12, 12);
            this.grpReportType.Name = "grpReportType";
            this.grpReportType.Size = new System.Drawing.Size(473, 56);
            this.grpReportType.TabIndex = 131;
            this.grpReportType.TabStop = false;
            this.grpReportType.Text = "Bid Type";
            // 
            // optAll
            // 
            this.optAll.AutoSize = true;
            this.optAll.BackColor = System.Drawing.Color.Transparent;
            this.optAll.Checked = true;
            this.optAll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optAll.Location = new System.Drawing.Point(76, 22);
            this.optAll.Name = "optAll";
            this.optAll.Size = new System.Drawing.Size(40, 20);
            this.optAll.TabIndex = 2;
            this.optAll.TabStop = true;
            this.optAll.Text = "All";
            this.optAll.UseVisualStyleBackColor = false;
            // 
            // optLocal
            // 
            this.optLocal.AutoSize = true;
            this.optLocal.BackColor = System.Drawing.Color.Transparent;
            this.optLocal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optLocal.Location = new System.Drawing.Point(372, 22);
            this.optLocal.Name = "optLocal";
            this.optLocal.Size = new System.Drawing.Size(55, 20);
            this.optLocal.TabIndex = 1;
            this.optLocal.Text = "Local";
            this.optLocal.UseVisualStyleBackColor = false;
            // 
            // optInternationalBid
            // 
            this.optInternationalBid.AutoSize = true;
            this.optInternationalBid.BackColor = System.Drawing.Color.Transparent;
            this.optInternationalBid.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optInternationalBid.Location = new System.Drawing.Point(205, 22);
            this.optInternationalBid.Name = "optInternationalBid";
            this.optInternationalBid.Size = new System.Drawing.Size(98, 20);
            this.optInternationalBid.TabIndex = 0;
            this.optInternationalBid.Text = "International";
            this.optInternationalBid.UseVisualStyleBackColor = false;
            // 
            // grpAnnouncement
            // 
            this.grpAnnouncement.Controls.Add(this.label3);
            this.grpAnnouncement.Controls.Add(this.txtAnnouncementDateTo);
            this.grpAnnouncement.Controls.Add(this.txtAnnouncementDateFrom);
            this.grpAnnouncement.Controls.Add(this.label1);
            this.grpAnnouncement.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnnouncement.Location = new System.Drawing.Point(15, 239);
            this.grpAnnouncement.Name = "grpAnnouncement";
            this.grpAnnouncement.Size = new System.Drawing.Size(232, 83);
            this.grpAnnouncement.TabIndex = 129;
            this.grpAnnouncement.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(9, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 172;
            this.label3.Text = "Date From";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnnouncementDateTo
            // 
            this.txtAnnouncementDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnouncementDateTo.Location = new System.Drawing.Point(121, 38);
            this.txtAnnouncementDateTo.Name = "txtAnnouncementDateTo";
            this.txtAnnouncementDateTo.Size = new System.Drawing.Size(104, 23);
            this.txtAnnouncementDateTo.TabIndex = 171;
            // 
            // txtAnnouncementDateFrom
            // 
            this.txtAnnouncementDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnnouncementDateFrom.Location = new System.Drawing.Point(9, 39);
            this.txtAnnouncementDateFrom.Name = "txtAnnouncementDateFrom";
            this.txtAnnouncementDateFrom.Size = new System.Drawing.Size(104, 23);
            this.txtAnnouncementDateFrom.TabIndex = 170;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(121, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 161;
            this.label1.Text = "Date To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnSearchCustomer1);
            this.grpCustomer.Controls.Add(this.txtCustomerFilter);
            this.grpCustomer.Controls.Add(this.label4);
            this.grpCustomer.Controls.Add(this.btnSearchCustomer);
            this.grpCustomer.Location = new System.Drawing.Point(12, 74);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(473, 74);
            this.grpCustomer.TabIndex = 128;
            this.grpCustomer.TabStop = false;
            // 
            // btnSearchCustomer1
            // 
            this.btnSearchCustomer1.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer1.Location = new System.Drawing.Point(435, 38);
            this.btnSearchCustomer1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer1.Name = "btnSearchCustomer1";
            this.btnSearchCustomer1.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer1.TabIndex = 179;
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
            this.txtCustomerFilter.Location = new System.Drawing.Point(12, 43);
            this.txtCustomerFilter.Name = "txtCustomerFilter";
            this.txtCustomerFilter.Size = new System.Drawing.Size(415, 23);
            this.txtCustomerFilter.TabIndex = 156;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 163;
            this.label4.Text = "Customer";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.btnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCustomer.Image")));
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSearchCustomer.Location = new System.Drawing.Point(205, 14);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(30, 28);
            this.btnSearchCustomer.TabIndex = 157;
            this.btnSearchCustomer.TabStop = false;
            this.btnSearchCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Visible = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(294, 439);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(92, 24);
            this.btnPreview.TabIndex = 133;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(390, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 24);
            this.btnCancel.TabIndex = 132;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpBidStatus
            // 
            this.grpBidStatus.Controls.Add(this.cboBidStatus);
            this.grpBidStatus.Controls.Add(this.label6);
            this.grpBidStatus.Location = new System.Drawing.Point(12, 154);
            this.grpBidStatus.Name = "grpBidStatus";
            this.grpBidStatus.Size = new System.Drawing.Size(473, 70);
            this.grpBidStatus.TabIndex = 134;
            this.grpBidStatus.TabStop = false;
            // 
            // cboBidStatus
            // 
            this.cboBidStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBidStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBidStatus.FormattingEnabled = true;
            this.cboBidStatus.Location = new System.Drawing.Point(12, 32);
            this.cboBidStatus.Name = "cboBidStatus";
            this.cboBidStatus.Size = new System.Drawing.Size(195, 24);
            this.cboBidStatus.TabIndex = 163;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 164;
            this.label6.Text = "Bid Status";
            // 
            // chkAnnouncementDate
            // 
            this.chkAnnouncementDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAnnouncementDate.Location = new System.Drawing.Point(27, 230);
            this.chkAnnouncementDate.Name = "chkAnnouncementDate";
            this.chkAnnouncementDate.Size = new System.Drawing.Size(168, 21);
            this.chkAnnouncementDate.TabIndex = 161;
            this.chkAnnouncementDate.Text = "Announcement Date";
            this.chkAnnouncementDate.UseVisualStyleBackColor = true;
            this.chkAnnouncementDate.CheckedChanged += new System.EventHandler(this.chkAnnouncementDate_CheckedChanged);
            // 
            // chkBidDocumentPurchaseDate
            // 
            this.chkBidDocumentPurchaseDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBidDocumentPurchaseDate.Location = new System.Drawing.Point(265, 230);
            this.chkBidDocumentPurchaseDate.Name = "chkBidDocumentPurchaseDate";
            this.chkBidDocumentPurchaseDate.Size = new System.Drawing.Size(192, 21);
            this.chkBidDocumentPurchaseDate.TabIndex = 162;
            this.chkBidDocumentPurchaseDate.Text = "Final Bid Document Purchase Date";
            this.chkBidDocumentPurchaseDate.UseVisualStyleBackColor = true;
            this.chkBidDocumentPurchaseDate.CheckedChanged += new System.EventHandler(this.chkBidDocumentPurchaseDate_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPurchaseDateTo);
            this.groupBox1.Controls.Add(this.txtPurchaseDateFrom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(253, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 83);
            this.groupBox1.TabIndex = 163;
            this.groupBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(9, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 172;
            this.label7.Text = "Date From";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPurchaseDateTo
            // 
            this.txtPurchaseDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseDateTo.Location = new System.Drawing.Point(121, 38);
            this.txtPurchaseDateTo.Name = "txtPurchaseDateTo";
            this.txtPurchaseDateTo.Size = new System.Drawing.Size(104, 23);
            this.txtPurchaseDateTo.TabIndex = 171;
            // 
            // txtPurchaseDateFrom
            // 
            this.txtPurchaseDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseDateFrom.Location = new System.Drawing.Point(9, 39);
            this.txtPurchaseDateFrom.Name = "txtPurchaseDateFrom";
            this.txtPurchaseDateFrom.Size = new System.Drawing.Size(104, 23);
            this.txtPurchaseDateFrom.TabIndex = 170;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(121, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 161;
            this.label8.Text = "Date To";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkBidOpening
            // 
            this.chkBidOpening.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBidOpening.Location = new System.Drawing.Point(265, 328);
            this.chkBidOpening.Name = "chkBidOpening";
            this.chkBidOpening.Size = new System.Drawing.Size(168, 21);
            this.chkBidOpening.TabIndex = 165;
            this.chkBidOpening.Text = "Bid Opening";
            this.chkBidOpening.UseVisualStyleBackColor = true;
            this.chkBidOpening.CheckedChanged += new System.EventHandler(this.chkBidOpening_CheckedChanged);
            // 
            // chkBidSubmissionDeadline
            // 
            this.chkBidSubmissionDeadline.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBidSubmissionDeadline.Location = new System.Drawing.Point(27, 328);
            this.chkBidSubmissionDeadline.Name = "chkBidSubmissionDeadline";
            this.chkBidSubmissionDeadline.Size = new System.Drawing.Size(168, 21);
            this.chkBidSubmissionDeadline.TabIndex = 164;
            this.chkBidSubmissionDeadline.Text = "Bid Submission Deadline";
            this.chkBidSubmissionDeadline.UseVisualStyleBackColor = true;
            this.chkBidSubmissionDeadline.CheckedChanged += new System.EventHandler(this.chkBidSubmissionDeadline_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtOpeningDateTo);
            this.groupBox2.Controls.Add(this.txtOpeningDateFrom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(253, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 83);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 172;
            this.label2.Text = "Date From";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOpeningDateTo
            // 
            this.txtOpeningDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpeningDateTo.Location = new System.Drawing.Point(121, 38);
            this.txtOpeningDateTo.Name = "txtOpeningDateTo";
            this.txtOpeningDateTo.Size = new System.Drawing.Size(104, 23);
            this.txtOpeningDateTo.TabIndex = 171;
            // 
            // txtOpeningDateFrom
            // 
            this.txtOpeningDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpeningDateFrom.Location = new System.Drawing.Point(9, 39);
            this.txtOpeningDateFrom.Name = "txtOpeningDateFrom";
            this.txtOpeningDateFrom.Size = new System.Drawing.Size(104, 23);
            this.txtOpeningDateFrom.TabIndex = 170;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(121, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 161;
            this.label5.Text = "Date To";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtSubmissionDeadlineDateTo);
            this.groupBox3.Controls.Add(this.txtSubmissionDeadlineDateFrom);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 83);
            this.groupBox3.TabIndex = 166;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(9, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 172;
            this.label9.Text = "Date From";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubmissionDeadlineDateTo
            // 
            this.txtSubmissionDeadlineDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubmissionDeadlineDateTo.Location = new System.Drawing.Point(121, 38);
            this.txtSubmissionDeadlineDateTo.Name = "txtSubmissionDeadlineDateTo";
            this.txtSubmissionDeadlineDateTo.Size = new System.Drawing.Size(104, 23);
            this.txtSubmissionDeadlineDateTo.TabIndex = 171;
            // 
            // txtSubmissionDeadlineDateFrom
            // 
            this.txtSubmissionDeadlineDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubmissionDeadlineDateFrom.Location = new System.Drawing.Point(9, 39);
            this.txtSubmissionDeadlineDateFrom.Name = "txtSubmissionDeadlineDateFrom";
            this.txtSubmissionDeadlineDateFrom.Size = new System.Drawing.Size(104, 23);
            this.txtSubmissionDeadlineDateFrom.TabIndex = 170;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(121, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 16);
            this.label10.TabIndex = 161;
            this.label10.Text = "Date To";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBidsListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 471);
            this.Controls.Add(this.chkBidOpening);
            this.Controls.Add(this.chkBidSubmissionDeadline);
            this.Controls.Add(this.chkBidDocumentPurchaseDate);
            this.Controls.Add(this.chkAnnouncementDate);
            this.Controls.Add(this.grpBidStatus);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpReportType);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAnnouncement);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmBidsListReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bids List Report";
            this.Load += new System.EventHandler(this.frmBidsListReport_Load);
            this.grpReportType.ResumeLayout(false);
            this.grpReportType.PerformLayout();
            this.grpAnnouncement.ResumeLayout(false);
            this.grpAnnouncement.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpBidStatus.ResumeLayout(false);
            this.grpBidStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReportType;
        private System.Windows.Forms.RadioButton optLocal;
        private System.Windows.Forms.RadioButton optInternationalBid;
        private System.Windows.Forms.GroupBox grpAnnouncement;
        private System.Windows.Forms.TextBox txtAnnouncementDateTo;
        private System.Windows.Forms.TextBox txtAnnouncementDateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnSearchCustomer1;
        private System.Windows.Forms.TextBox txtCustomerFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpBidStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAnnouncementDate;
        private System.Windows.Forms.CheckBox chkBidDocumentPurchaseDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPurchaseDateTo;
        private System.Windows.Forms.TextBox txtPurchaseDateFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboBidStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkBidOpening;
        private System.Windows.Forms.CheckBox chkBidSubmissionDeadline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpeningDateTo;
        private System.Windows.Forms.TextBox txtOpeningDateFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubmissionDeadlineDateTo;
        private System.Windows.Forms.TextBox txtSubmissionDeadlineDateFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton optAll;
    }
}