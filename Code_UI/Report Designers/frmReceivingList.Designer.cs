namespace Pharma
{
    partial class frmReceivingList
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
            this.label5 = new System.Windows.Forms.Label();
            this.grpManufacturer = new System.Windows.Forms.GroupBox();
            this.txtDateToReceived = new System.Windows.Forms.TextBox();
            this.txtDateFromReceived = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpManufacturer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(266, 242);
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
            this.btnPreview.Location = new System.Drawing.Point(170, 242);
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
            this.label3.Size = new System.Drawing.Size(426, 36);
            this.label3.TabIndex = 121;
            this.label3.Text = "    Received Goods List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 162;
            this.label5.Text = "Received Date From";
            // 
            // grpManufacturer
            // 
            this.grpManufacturer.Controls.Add(this.txtDateToReceived);
            this.grpManufacturer.Controls.Add(this.txtDateFromReceived);
            this.grpManufacturer.Controls.Add(this.label2);
            this.grpManufacturer.Controls.Add(this.label5);
            this.grpManufacturer.Location = new System.Drawing.Point(8, 46);
            this.grpManufacturer.Name = "grpManufacturer";
            this.grpManufacturer.Size = new System.Drawing.Size(352, 162);
            this.grpManufacturer.TabIndex = 127;
            this.grpManufacturer.TabStop = false;
            // 
            // txtDateToReceived
            // 
            this.txtDateToReceived.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateToReceived.Location = new System.Drawing.Point(32, 109);
            this.txtDateToReceived.Name = "txtDateToReceived";
            this.txtDateToReceived.Size = new System.Drawing.Size(154, 23);
            this.txtDateToReceived.TabIndex = 169;
            // 
            // txtDateFromReceived
            // 
            this.txtDateFromReceived.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFromReceived.Location = new System.Drawing.Point(32, 57);
            this.txtDateFromReceived.Name = "txtDateFromReceived";
            this.txtDateFromReceived.Size = new System.Drawing.Size(154, 23);
            this.txtDateFromReceived.TabIndex = 168;
            this.txtDateFromReceived.TextChanged += new System.EventHandler(this.txtDateFromReceived_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 167;
            this.label2.Text = "Received Date To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmReceivingList
            // 
            this.AcceptButton = this.btnPreview;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(368, 274);
            this.Controls.Add(this.grpManufacturer);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReceivingList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Received Goods List";
            this.Load += new System.EventHandler(this.frmReceivingList_Load);
            this.grpManufacturer.ResumeLayout(false);
            this.grpManufacturer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpManufacturer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateToReceived;
        private System.Windows.Forms.TextBox txtDateFromReceived;
    }
}