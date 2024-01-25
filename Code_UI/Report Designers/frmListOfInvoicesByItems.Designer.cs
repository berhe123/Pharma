namespace Pharma
{
    partial class frmListOfInvoicesByItems
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.txtDateToInvoice = new System.Windows.Forms.TextBox();
            this.txtDateFromInvoice = new System.Windows.Forms.TextBox();
            this.cboInvoiceType = new System.Windows.Forms.ComboBox();
            this.chkInvoiceDate = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpManufacturer = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboItem = new System.Windows.Forms.ComboBox();
            this.cboItemCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grpInvoice.SuspendLayout();
            this.grpManufacturer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(266, 287);
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
            this.btnPreview.Location = new System.Drawing.Point(170, 287);
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
            this.line1.Size = new System.Drawing.Size(426, 1);
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
            this.label3.Size = new System.Drawing.Size(367, 36);
            this.label3.TabIndex = 121;
            this.label3.Text = "    Invoices List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // grpInvoice
            // 
            this.grpInvoice.Controls.Add(this.txtDateToInvoice);
            this.grpInvoice.Controls.Add(this.txtDateFromInvoice);
            this.grpInvoice.Controls.Add(this.cboInvoiceType);
            this.grpInvoice.Controls.Add(this.chkInvoiceDate);
            this.grpInvoice.Controls.Add(this.label6);
            this.grpInvoice.Controls.Add(this.label1);
            this.grpInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInvoice.Location = new System.Drawing.Point(8, 162);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Size = new System.Drawing.Size(352, 118);
            this.grpInvoice.TabIndex = 125;
            this.grpInvoice.TabStop = false;
            this.grpInvoice.Text = "Invoice";
            this.grpInvoice.Enter += new System.EventHandler(this.grpInvoice_Enter);
            // 
            // txtDateToInvoice
            // 
            this.txtDateToInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateToInvoice.Location = new System.Drawing.Point(184, 88);
            this.txtDateToInvoice.Name = "txtDateToInvoice";
            this.txtDateToInvoice.Size = new System.Drawing.Size(154, 23);
            this.txtDateToInvoice.TabIndex = 173;
            // 
            // txtDateFromInvoice
            // 
            this.txtDateFromInvoice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFromInvoice.Location = new System.Drawing.Point(14, 88);
            this.txtDateFromInvoice.Name = "txtDateFromInvoice";
            this.txtDateFromInvoice.Size = new System.Drawing.Size(154, 23);
            this.txtDateFromInvoice.TabIndex = 172;
            // 
            // cboInvoiceType
            // 
            this.cboInvoiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvoiceType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInvoiceType.FormattingEnabled = true;
            this.cboInvoiceType.Location = new System.Drawing.Point(14, 40);
            this.cboInvoiceType.Name = "cboInvoiceType";
            this.cboInvoiceType.Size = new System.Drawing.Size(156, 24);
            this.cboInvoiceType.TabIndex = 129;
            // 
            // chkInvoiceDate
            // 
            this.chkInvoiceDate.Checked = true;
            this.chkInvoiceDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInvoiceDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvoiceDate.Location = new System.Drawing.Point(14, 70);
            this.chkInvoiceDate.Name = "chkInvoiceDate";
            this.chkInvoiceDate.Size = new System.Drawing.Size(88, 21);
            this.chkInvoiceDate.TabIndex = 160;
            this.chkInvoiceDate.Text = "Date From";
            this.chkInvoiceDate.UseVisualStyleBackColor = true;
            this.chkInvoiceDate.CheckedChanged += new System.EventHandler(this.chkInvoiceDate_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 162;
            this.label6.Text = "Type";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(184, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 161;
            this.label1.Text = "Date To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpManufacturer
            // 
            this.grpManufacturer.Controls.Add(this.label4);
            this.grpManufacturer.Controls.Add(this.cboItem);
            this.grpManufacturer.Controls.Add(this.cboItemCategory);
            this.grpManufacturer.Controls.Add(this.label7);
            this.grpManufacturer.Location = new System.Drawing.Point(8, 44);
            this.grpManufacturer.Name = "grpManufacturer";
            this.grpManufacturer.Size = new System.Drawing.Size(352, 112);
            this.grpManufacturer.TabIndex = 127;
            this.grpManufacturer.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 154;
            this.label4.Text = "Part Name";
            // 
            // cboItem
            // 
            this.cboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItem.FormattingEnabled = true;
            this.cboItem.Location = new System.Drawing.Point(12, 78);
            this.cboItem.Name = "cboItem";
            this.cboItem.Size = new System.Drawing.Size(292, 24);
            this.cboItem.TabIndex = 155;
            this.cboItem.SelectedIndexChanged += new System.EventHandler(this.cboItem_SelectedIndexChanged);
            // 
            // cboItemCategory
            // 
            this.cboItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboItemCategory.FormattingEnabled = true;
            this.cboItemCategory.Location = new System.Drawing.Point(12, 34);
            this.cboItemCategory.Name = "cboItemCategory";
            this.cboItemCategory.Size = new System.Drawing.Size(294, 24);
            this.cboItemCategory.TabIndex = 127;
            this.cboItemCategory.SelectedIndexChanged += new System.EventHandler(this.cboItemCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 126;
            this.label7.Text = "Item Category";
            this.label7.Visible = false;
            // 
            // frmListOfInvoicesByItems
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(368, 322);
            this.Controls.Add(this.grpManufacturer);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfInvoicesByItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoices List";
            this.Load += new System.EventHandler(this.frmListOfCustomers_Load);
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.grpManufacturer.ResumeLayout(false);
            this.grpManufacturer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpInvoice;
        private System.Windows.Forms.ComboBox cboInvoiceType;
        private System.Windows.Forms.CheckBox chkInvoiceDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpManufacturer;
        private System.Windows.Forms.ComboBox cboItemCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboItem;
        private System.Windows.Forms.TextBox txtDateToInvoice;
        private System.Windows.Forms.TextBox txtDateFromInvoice;
    }
}