namespace Pharma
{
    partial class frmListOfChecks
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
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.txtDateToMaturity = new System.Windows.Forms.TextBox();
            this.txtDateFromMaturity = new System.Windows.Forms.TextBox();
            this.chkMaturityDate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCheckStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpManufacturer = new System.Windows.Forms.GroupBox();
            this.txtDateToCheck = new System.Windows.Forms.TextBox();
            this.txtDateFromCheck = new System.Windows.Forms.TextBox();
            this.chkCheckDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpRequest.SuspendLayout();
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
            this.label3.Size = new System.Drawing.Size(368, 36);
            this.label3.TabIndex = 121;
            this.label3.Text = "    Checks List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.txtDateToMaturity);
            this.grpRequest.Controls.Add(this.txtDateFromMaturity);
            this.grpRequest.Controls.Add(this.chkMaturityDate);
            this.grpRequest.Controls.Add(this.label1);
            this.grpRequest.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRequest.Location = new System.Drawing.Point(8, 182);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(352, 88);
            this.grpRequest.TabIndex = 125;
            this.grpRequest.TabStop = false;
            // 
            // txtDateToMaturity
            // 
            this.txtDateToMaturity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateToMaturity.Location = new System.Drawing.Point(182, 46);
            this.txtDateToMaturity.Name = "txtDateToMaturity";
            this.txtDateToMaturity.Size = new System.Drawing.Size(154, 23);
            this.txtDateToMaturity.TabIndex = 171;
            this.txtDateToMaturity.Visible = false;
            // 
            // txtDateFromMaturity
            // 
            this.txtDateFromMaturity.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFromMaturity.Location = new System.Drawing.Point(14, 46);
            this.txtDateFromMaturity.Name = "txtDateFromMaturity";
            this.txtDateFromMaturity.Size = new System.Drawing.Size(154, 23);
            this.txtDateFromMaturity.TabIndex = 170;
            this.txtDateFromMaturity.Visible = false;
            // 
            // chkMaturityDate
            // 
            this.chkMaturityDate.Checked = true;
            this.chkMaturityDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMaturityDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMaturityDate.Location = new System.Drawing.Point(14, 28);
            this.chkMaturityDate.Name = "chkMaturityDate";
            this.chkMaturityDate.Size = new System.Drawing.Size(154, 21);
            this.chkMaturityDate.TabIndex = 160;
            this.chkMaturityDate.Text = "Maturity Date From";
            this.chkMaturityDate.UseVisualStyleBackColor = true;
            this.chkMaturityDate.Visible = false;
            this.chkMaturityDate.CheckedChanged += new System.EventHandler(this.chkMaturityDate_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(182, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 161;
            this.label1.Text = "Maturity Date To";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // cboCheckStatus
            // 
            this.cboCheckStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheckStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCheckStatus.FormattingEnabled = true;
            this.cboCheckStatus.Location = new System.Drawing.Point(14, 40);
            this.cboCheckStatus.Name = "cboCheckStatus";
            this.cboCheckStatus.Size = new System.Drawing.Size(154, 24);
            this.cboCheckStatus.TabIndex = 163;
            this.cboCheckStatus.SelectedIndexChanged += new System.EventHandler(this.cboCheckStatus_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 162;
            this.label5.Text = "Check Status";
            // 
            // grpManufacturer
            // 
            this.grpManufacturer.Controls.Add(this.txtDateToCheck);
            this.grpManufacturer.Controls.Add(this.txtDateFromCheck);
            this.grpManufacturer.Controls.Add(this.chkCheckDate);
            this.grpManufacturer.Controls.Add(this.label2);
            this.grpManufacturer.Controls.Add(this.cboCheckStatus);
            this.grpManufacturer.Controls.Add(this.label5);
            this.grpManufacturer.Location = new System.Drawing.Point(8, 44);
            this.grpManufacturer.Name = "grpManufacturer";
            this.grpManufacturer.Size = new System.Drawing.Size(352, 130);
            this.grpManufacturer.TabIndex = 127;
            this.grpManufacturer.TabStop = false;
            // 
            // txtDateToCheck
            // 
            this.txtDateToCheck.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateToCheck.Location = new System.Drawing.Point(182, 97);
            this.txtDateToCheck.Name = "txtDateToCheck";
            this.txtDateToCheck.Size = new System.Drawing.Size(154, 23);
            this.txtDateToCheck.TabIndex = 169;
            // 
            // txtDateFromCheck
            // 
            this.txtDateFromCheck.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFromCheck.Location = new System.Drawing.Point(14, 97);
            this.txtDateFromCheck.Name = "txtDateFromCheck";
            this.txtDateFromCheck.Size = new System.Drawing.Size(154, 23);
            this.txtDateFromCheck.TabIndex = 168;
            // 
            // chkCheckDate
            // 
            this.chkCheckDate.Checked = true;
            this.chkCheckDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheckDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCheckDate.Location = new System.Drawing.Point(14, 78);
            this.chkCheckDate.Name = "chkCheckDate";
            this.chkCheckDate.Size = new System.Drawing.Size(154, 21);
            this.chkCheckDate.TabIndex = 166;
            this.chkCheckDate.Text = "Check Date From";
            this.chkCheckDate.UseVisualStyleBackColor = true;
            this.chkCheckDate.CheckedChanged += new System.EventHandler(this.chkCheckDate_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(182, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 167;
            this.label2.Text = "Check Date To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmListOfChecks
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(368, 322);
            this.Controls.Add(this.grpManufacturer);
            this.Controls.Add(this.grpRequest);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListOfChecks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checks List";
            this.Load += new System.EventHandler(this.frmListOfCustomers_Load);
            this.grpRequest.ResumeLayout(false);
            this.grpRequest.PerformLayout();
            this.grpManufacturer.ResumeLayout(false);
            this.grpManufacturer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpRequest;
        private System.Windows.Forms.CheckBox chkMaturityDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpManufacturer;
        private System.Windows.Forms.ComboBox cboCheckStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCheckDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateToCheck;
        private System.Windows.Forms.TextBox txtDateFromCheck;
        private System.Windows.Forms.TextBox txtDateToMaturity;
        private System.Windows.Forms.TextBox txtDateFromMaturity;
    }
}