namespace Pharma
{
    partial class frmSellableBatch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboItemCategory = new System.Windows.Forms.ComboBox();
            this.lvwItems = new System.Windows.Forms.ListView();
            this.colItemGuid = new System.Windows.Forms.ColumnHeader();
            this.colItemBrandName = new System.Windows.Forms.ColumnHeader();
            this.colItemUnit = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQuantityBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentBatchQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentSellableBatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBatchQuantityBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBatchQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSetSellableBatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboItemBatchs = new System.Windows.Forms.ComboBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.indexBar = new Pharma.IndexBar();
            this.btnClose = new System.Windows.Forms.Button();
            this.line3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboItemCategory);
            this.groupBox1.Location = new System.Drawing.Point(69, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(326, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Category";
            // 
            // cboItemCategory
            // 
            this.cboItemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemCategory.FormattingEnabled = true;
            this.cboItemCategory.Location = new System.Drawing.Point(8, 28);
            this.cboItemCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboItemCategory.Name = "cboItemCategory";
            this.cboItemCategory.Size = new System.Drawing.Size(283, 22);
            this.cboItemCategory.TabIndex = 4;
            // 
            // lvwItems
            // 
            this.lvwItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemGuid,
            this.colItemBrandName,
            this.colItemUnit});
            this.lvwItems.FullRowSelect = true;
            this.lvwItems.GridLines = true;
            this.lvwItems.Location = new System.Drawing.Point(69, 97);
            this.lvwItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwItems.Name = "lvwItems";
            this.lvwItems.Size = new System.Drawing.Size(326, 485);
            this.lvwItems.TabIndex = 6;
            this.lvwItems.UseCompatibleStateImageBehavior = false;
            this.lvwItems.View = System.Windows.Forms.View.Details;
            this.lvwItems.SelectedIndexChanged += new System.EventHandler(this.lvwItems_SelectedIndexChanged);
            // 
            // colItemGuid
            // 
            this.colItemGuid.Text = "Guid";
            this.colItemGuid.Width = 0;
            // 
            // colItemBrandName
            // 
            this.colItemBrandName.Text = "Brand Name";
            this.colItemBrandName.Width = 300;
            // 
            // colItemUnit
            // 
            this.colItemUnit.Text = "Unit";
            this.colItemUnit.Width = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQuantityBalance);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCurrentBatchQuantity);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtCurrentSellableBatch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(403, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 166);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Batch on Sale";
            // 
            // txtQuantityBalance
            // 
            this.txtQuantityBalance.Location = new System.Drawing.Point(12, 131);
            this.txtQuantityBalance.Name = "txtQuantityBalance";
            this.txtQuantityBalance.ReadOnly = true;
            this.txtQuantityBalance.Size = new System.Drawing.Size(220, 22);
            this.txtQuantityBalance.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantity Balance";
            // 
            // txtCurrentBatchQuantity
            // 
            this.txtCurrentBatchQuantity.Location = new System.Drawing.Point(12, 87);
            this.txtCurrentBatchQuantity.Name = "txtCurrentBatchQuantity";
            this.txtCurrentBatchQuantity.ReadOnly = true;
            this.txtCurrentBatchQuantity.Size = new System.Drawing.Size(220, 22);
            this.txtCurrentBatchQuantity.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Current Batch Quantity";
            // 
            // txtCurrentSellableBatch
            // 
            this.txtCurrentSellableBatch.Location = new System.Drawing.Point(12, 43);
            this.txtCurrentSellableBatch.Name = "txtCurrentSellableBatch";
            this.txtCurrentSellableBatch.ReadOnly = true;
            this.txtCurrentSellableBatch.Size = new System.Drawing.Size(220, 22);
            this.txtCurrentSellableBatch.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Sellable Batch";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBatchQuantityBalance);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBatchQuantity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnSetSellableBatch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cboItemBatchs);
            this.groupBox3.Location = new System.Drawing.Point(403, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 212);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set New Sallable Batch";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtBatchQuantityBalance
            // 
            this.txtBatchQuantityBalance.Location = new System.Drawing.Point(12, 131);
            this.txtBatchQuantityBalance.Name = "txtBatchQuantityBalance";
            this.txtBatchQuantityBalance.ReadOnly = true;
            this.txtBatchQuantityBalance.Size = new System.Drawing.Size(220, 22);
            this.txtBatchQuantityBalance.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 14);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sold Quantity";
            // 
            // txtBatchQuantity
            // 
            this.txtBatchQuantity.Location = new System.Drawing.Point(12, 88);
            this.txtBatchQuantity.Name = "txtBatchQuantity";
            this.txtBatchQuantity.ReadOnly = true;
            this.txtBatchQuantity.Size = new System.Drawing.Size(220, 22);
            this.txtBatchQuantity.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total Quantity";
            // 
            // btnSetSellableBatch
            // 
            this.btnSetSellableBatch.Location = new System.Drawing.Point(12, 166);
            this.btnSetSellableBatch.Name = "btnSetSellableBatch";
            this.btnSetSellableBatch.Size = new System.Drawing.Size(220, 32);
            this.btnSetSellableBatch.TabIndex = 24;
            this.btnSetSellableBatch.Text = "Set Sellable Batch";
            this.btnSetSellableBatch.UseVisualStyleBackColor = true;
            this.btnSetSellableBatch.Click += new System.EventHandler(this.btnSetSellableBatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 18;
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
            this.cboItemBatchs.TabIndex = 19;
            this.cboItemBatchs.SelectedIndexChanged += new System.EventHandler(this.cboItemBatchs_SelectedIndexChanged);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(0, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(786, 1);
            this.line1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(780, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "    Set the current batch on Sale";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtItem);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(403, 38);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(355, 56);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(12, 28);
            this.txtItem.Name = "txtItem";
            this.txtItem.ReadOnly = true;
            this.txtItem.Size = new System.Drawing.Size(330, 22);
            this.txtItem.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "Item";
            // 
            // indexBar
            // 
            this.indexBar.Alignment = Pharma.IndexBar.IndexBarAlignment.Vertical;
            this.indexBar.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexBar.Location = new System.Drawing.Point(9, 97);
            this.indexBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.indexBar.Name = "indexBar";
            this.indexBar.Size = new System.Drawing.Size(58, 485);
            this.indexBar.TabIndex = 5;
            this.indexBar.Load += new System.EventHandler(this.indexBar_Load);
            this.indexBar.LetterListener += new System.EventHandler(this.indexBar_LetterListener);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(674, 556);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 26);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(403, 548);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(355, 1);
            this.line3.TabIndex = 25;
            // 
            // frmSellableBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(768, 589);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvwItems);
            this.Controls.Add(this.indexBar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSellableBatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set Sellable Batch";
            this.Load += new System.EventHandler(this.frmSellableBatch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwItems;
        private System.Windows.Forms.ColumnHeader colItemGuid;
        private System.Windows.Forms.ColumnHeader colItemBrandName;
        private System.Windows.Forms.ColumnHeader colItemUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboItemCategory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQuantityBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentBatchQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentSellableBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBatchQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboItemBatchs;
        private System.Windows.Forms.TextBox txtBatchQuantityBalance;
        private System.Windows.Forms.Label label7;
        private IndexBar indexBar;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnSetSellableBatch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel line3;
    }
}