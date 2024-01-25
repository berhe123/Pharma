namespace Pharma
{
    partial class frmSalesStatement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.grpReportType = new System.Windows.Forms.GroupBox();
            this.optByItem = new System.Windows.Forms.RadioButton();
            this.optByBatch = new System.Windows.Forms.RadioButton();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpReportType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(184, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(144, 24);
            this.btnCancel.TabIndex = 50;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(184, 203);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(144, 24);
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
            this.groupBox1.Location = new System.Drawing.Point(18, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 86);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(44, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 148;
            this.label6.Text = "To:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(30, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 146;
            this.label9.Text = "From:";
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
            this.label3.Text = "    Sales Statement";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpReportType
            // 
            this.grpReportType.Controls.Add(this.optByItem);
            this.grpReportType.Controls.Add(this.optByBatch);
            this.grpReportType.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportType.Location = new System.Drawing.Point(18, 45);
            this.grpReportType.Name = "grpReportType";
            this.grpReportType.Size = new System.Drawing.Size(310, 60);
            this.grpReportType.TabIndex = 129;
            this.grpReportType.TabStop = false;
            this.grpReportType.Text = "Report Type";
            // 
            // optByItem
            // 
            this.optByItem.AutoSize = true;
            this.optByItem.BackColor = System.Drawing.Color.Transparent;
            this.optByItem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optByItem.Location = new System.Drawing.Point(152, 26);
            this.optByItem.Name = "optByItem";
            this.optByItem.Size = new System.Drawing.Size(69, 20);
            this.optByItem.TabIndex = 1;
            this.optByItem.Text = "By Item";
            this.optByItem.UseVisualStyleBackColor = false;
            // 
            // optByBatch
            // 
            this.optByBatch.AutoSize = true;
            this.optByBatch.BackColor = System.Drawing.Color.Transparent;
            this.optByBatch.Checked = true;
            this.optByBatch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optByBatch.Location = new System.Drawing.Point(23, 28);
            this.optByBatch.Name = "optByBatch";
            this.optByBatch.Size = new System.Drawing.Size(74, 20);
            this.optByBatch.TabIndex = 0;
            this.optByBatch.TabStop = true;
            this.optByBatch.Text = "By Batch";
            this.optByBatch.UseVisualStyleBackColor = false;
            // 
            // txtDateTo
            // 
            this.txtDateTo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTo.Location = new System.Drawing.Point(76, 51);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(122, 23);
            this.txtDateTo.TabIndex = 179;
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFrom.Location = new System.Drawing.Point(76, 20);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(122, 23);
            this.txtDateFrom.TabIndex = 178;
            // 
            // frmSalesStatement
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(350, 261);
            this.Controls.Add(this.grpReportType);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSalesStatement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Statement";
            this.Load += new System.EventHandler(this.frmSalesStatement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpReportType;
        private System.Windows.Forms.RadioButton optByItem;
        private System.Windows.Forms.RadioButton optByBatch;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.TextBox txtDateFrom;
    }
}