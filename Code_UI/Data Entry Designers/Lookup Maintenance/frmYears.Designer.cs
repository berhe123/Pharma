namespace Pharma
{
    partial class frmYears
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
            this.grpItemCategoriesEntry = new System.Windows.Forms.GroupBox();
            this.lblYearName = new System.Windows.Forms.Label();
            this.txtYearName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewCountries = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCountries = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCountries = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.lvwItemCategories = new System.Windows.Forms.ListView();
            this.colYearId = new System.Windows.Forms.ColumnHeader();
            this.colYearName = new System.Windows.Forms.ColumnHeader();
            this.ssYear = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblYear = new System.Windows.Forms.Label();
            this.grpItemCategoriesEntry.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ssYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // grpItemCategoriesEntry
            // 
            this.grpItemCategoriesEntry.Controls.Add(this.lblYearName);
            this.grpItemCategoriesEntry.Controls.Add(this.txtYearName);
            this.grpItemCategoriesEntry.Location = new System.Drawing.Point(22, 63);
            this.grpItemCategoriesEntry.Name = "grpItemCategoriesEntry";
            this.grpItemCategoriesEntry.Size = new System.Drawing.Size(540, 72);
            this.grpItemCategoriesEntry.TabIndex = 13;
            this.grpItemCategoriesEntry.TabStop = false;
            this.grpItemCategoriesEntry.Enter += new System.EventHandler(this.grpItemCategoriesEntry_Enter);
            // 
            // lblYearName
            // 
            this.lblYearName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblYearName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblYearName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblYearName.Location = new System.Drawing.Point(17, 16);
            this.lblYearName.Name = "lblYearName";
            this.lblYearName.Size = new System.Drawing.Size(107, 16);
            this.lblYearName.TabIndex = 4;
            this.lblYearName.Text = " Year ";
            this.lblYearName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtYearName
            // 
            this.txtYearName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearName.Location = new System.Drawing.Point(20, 35);
            this.txtYearName.Name = "txtYearName";
            this.txtYearName.Size = new System.Drawing.Size(454, 23);
            this.txtYearName.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnNewCountries,
            this.btnSaveCountries,
            this.btnDeleteCountries,
            this.toolStripSeparator3,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 14;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewCountries
            // 
            this.btnNewCountries.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCountries.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewCountries.Image = global::Pharma.Properties.Resources.New;
            this.btnNewCountries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewCountries.Name = "btnNewCountries";
            this.btnNewCountries.Size = new System.Drawing.Size(53, 22);
            this.btnNewCountries.Text = "New";
            this.btnNewCountries.ToolTipText = "Prepare the system to accept a new item category record";
            this.btnNewCountries.Click += new System.EventHandler(this.btnNewCountries_Click);
            // 
            // btnSaveCountries
            // 
            this.btnSaveCountries.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCountries.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveCountries.Image = global::Pharma.Properties.Resources.save;
            this.btnSaveCountries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCountries.Name = "btnSaveCountries";
            this.btnSaveCountries.Size = new System.Drawing.Size(56, 22);
            this.btnSaveCountries.Text = "Save";
            this.btnSaveCountries.ToolTipText = "Save the current item category record (i.e. newly created or edited)";
            this.btnSaveCountries.Click += new System.EventHandler(this.btnSaveCountries_Click);
            // 
            // btnDeleteCountries
            // 
            this.btnDeleteCountries.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCountries.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteCountries.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeleteCountries.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCountries.Name = "btnDeleteCountries";
            this.btnDeleteCountries.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteCountries.Text = "Delete";
            this.btnDeleteCountries.ToolTipText = "Delete the currently selected item category record";
            this.btnDeleteCountries.Click += new System.EventHandler(this.btnDeleteCountries_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 22);
            this.btnClose.Text = "Close";
            this.btnClose.ToolTipText = "Close the Item Category Maintenance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lvwItemCategories
            // 
            this.lvwItemCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colYearId,
            this.colYearName});
            this.lvwItemCategories.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwItemCategories.FullRowSelect = true;
            this.lvwItemCategories.GridLines = true;
            this.lvwItemCategories.Location = new System.Drawing.Point(23, 141);
            this.lvwItemCategories.MultiSelect = false;
            this.lvwItemCategories.Name = "lvwItemCategories";
            this.lvwItemCategories.Size = new System.Drawing.Size(534, 310);
            this.lvwItemCategories.TabIndex = 15;
            this.lvwItemCategories.UseCompatibleStateImageBehavior = false;
            this.lvwItemCategories.View = System.Windows.Forms.View.Details;
            this.lvwItemCategories.SelectedIndexChanged += new System.EventHandler(this.lvwItemCategories_SelectedIndexChanged_1);
            // 
            // colYearId
            // 
            this.colYearId.Text = "Id";
            this.colYearId.Width = 0;
            // 
            // colYearName
            // 
            this.colYearName.Text = "Year";
            this.colYearName.Width = 500;
            // 
            // ssYear
            // 
            this.ssYear.BackColor = System.Drawing.Color.Lavender;
            this.ssYear.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssYear.Location = new System.Drawing.Point(0, 459);
            this.ssYear.Name = "ssYear";
            this.ssYear.Size = new System.Drawing.Size(584, 22);
            this.ssYear.TabIndex = 16;
            this.ssYear.Text = "ssItemCategories";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(44, 17);
            this.lblMsg.Text = "lblMsg";
            // 
            // mValidator
            // 
            this.mValidator.ContainerControl = this;
            // 
            // lblYear
            // 
            this.lblYear.BackColor = System.Drawing.Color.White;
            this.lblYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblYear.Location = new System.Drawing.Point(4, 29);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(577, 36);
            this.lblYear.TabIndex = 17;
            this.lblYear.Text = "List of Years Maintenance";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmYears
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.ssYear);
            this.Controls.Add(this.lvwItemCategories);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpItemCategoriesEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYears";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Years";
            this.Load += new System.EventHandler(this.frmYears_Load);
            this.Activated += new System.EventHandler(this.frmYears_Activated);
            this.grpItemCategoriesEntry.ResumeLayout(false);
            this.grpItemCategoriesEntry.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ssYear.ResumeLayout(false);
            this.ssYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItemCategoriesEntry;
        private System.Windows.Forms.Label lblYearName;
        private System.Windows.Forms.TextBox txtYearName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewCountries;
        public System.Windows.Forms.ToolStripButton btnSaveCountries;
        public System.Windows.Forms.ToolStripButton btnDeleteCountries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ListView lvwItemCategories;
        private System.Windows.Forms.ColumnHeader colYearId;
        private System.Windows.Forms.ColumnHeader colYearName;
        private System.Windows.Forms.StatusStrip ssYear;
        private System.Windows.Forms.ErrorProvider mValidator;
        public System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.Label lblYear;
    }
}