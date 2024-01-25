namespace Pharma
{
    partial class frmChangeSellableBatch
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBatchQuantityBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBatchQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboItemBatchs = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuantityBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentBatchQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentSellableBatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetSellableBatch = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtItem);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(8, 46);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(472, 71);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(6, 36);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(446, 22);
            this.txtItem.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 14);
            this.label9.TabIndex = 3;
            this.label9.Text = "Item";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBatchQuantityBalance);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBatchQuantity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboItemBatchs);
            this.groupBox3.Location = new System.Drawing.Point(238, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 168);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set New Sallable Batch";
            // 
            // txtBatchQuantityBalance
            // 
            this.txtBatchQuantityBalance.Location = new System.Drawing.Point(12, 131);
            this.txtBatchQuantityBalance.Name = "txtBatchQuantityBalance";
            this.txtBatchQuantityBalance.ReadOnly = true;
            this.txtBatchQuantityBalance.Size = new System.Drawing.Size(220, 22);
            this.txtBatchQuantityBalance.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sold Quantity";
            // 
            // txtBatchQuantity
            // 
            this.txtBatchQuantity.Location = new System.Drawing.Point(12, 88);
            this.txtBatchQuantity.Name = "txtBatchQuantity";
            this.txtBatchQuantity.ReadOnly = true;
            this.txtBatchQuantity.Size = new System.Drawing.Size(220, 22);
            this.txtBatchQuantity.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Item Batches";
            // 
            // cboItemBatchs
            // 
            this.cboItemBatchs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemBatchs.FormattingEnabled = true;
            this.cboItemBatchs.Location = new System.Drawing.Point(12, 45);
            this.cboItemBatchs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboItemBatchs.Name = "cboItemBatchs";
            this.cboItemBatchs.Size = new System.Drawing.Size(220, 22);
            this.cboItemBatchs.TabIndex = 14;
            this.cboItemBatchs.SelectedIndexChanged += new System.EventHandler(this.cboItemBatchs_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuantityBalance);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCurrentBatchQuantity);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCurrentSellableBatch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 166);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Batch on Sale";
            // 
            // txtQuantityBalance
            // 
            this.txtQuantityBalance.Location = new System.Drawing.Point(12, 131);
            this.txtQuantityBalance.Name = "txtQuantityBalance";
            this.txtQuantityBalance.ReadOnly = true;
            this.txtQuantityBalance.Size = new System.Drawing.Size(200, 22);
            this.txtQuantityBalance.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Quantity Balance";
            // 
            // txtCurrentBatchQuantity
            // 
            this.txtCurrentBatchQuantity.Location = new System.Drawing.Point(12, 87);
            this.txtCurrentBatchQuantity.Name = "txtCurrentBatchQuantity";
            this.txtCurrentBatchQuantity.ReadOnly = true;
            this.txtCurrentBatchQuantity.Size = new System.Drawing.Size(198, 22);
            this.txtCurrentBatchQuantity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Current Batch Quantity";
            // 
            // txtCurrentSellableBatch
            // 
            this.txtCurrentSellableBatch.Location = new System.Drawing.Point(12, 43);
            this.txtCurrentSellableBatch.Name = "txtCurrentSellableBatch";
            this.txtCurrentSellableBatch.ReadOnly = true;
            this.txtCurrentSellableBatch.Size = new System.Drawing.Size(200, 22);
            this.txtCurrentSellableBatch.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Sellable Batch";
            // 
            // btnSetSellableBatch
            // 
            this.btnSetSellableBatch.Location = new System.Drawing.Point(238, 316);
            this.btnSetSellableBatch.Name = "btnSetSellableBatch";
            this.btnSetSellableBatch.Size = new System.Drawing.Size(242, 32);
            this.btnSetSellableBatch.TabIndex = 19;
            this.btnSetSellableBatch.Text = "Set Sellable Batch";
            this.btnSetSellableBatch.UseVisualStyleBackColor = true;
            this.btnSetSellableBatch.Click += new System.EventHandler(this.btnSetSellableBatch_Click);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(-2, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(558, 1);
            this.line1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(-2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "    Change the current batch on sale";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(8, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(218, 32);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmChangeSellableBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(487, 360);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSetSellableBatch);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeSellableBatch";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Sellable Batch";
            this.Load += new System.EventHandler(this.frmChangeSellableBatch_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBatchQuantityBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBatchQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboItemBatchs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuantityBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentBatchQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentSellableBatch;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSetSellableBatch;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnCancel;
    }
}