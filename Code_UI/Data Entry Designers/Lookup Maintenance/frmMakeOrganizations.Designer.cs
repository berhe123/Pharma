namespace Pharma
{
    partial class frmMakeOrganizations
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
            this.colMakeOrganizationsId = new System.Windows.Forms.ColumnHeader();
            this.colMakeOrganizationsName = new System.Windows.Forms.ColumnHeader();
            this.lvwMakeOrganizations = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewCountries = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCountries = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCountries = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.grpItemCategoriesEntry = new System.Windows.Forms.GroupBox();
            this.lblItemCategoriesName = new System.Windows.Forms.Label();
            this.txtMakeOrganizations = new System.Windows.Forms.TextBox();
            this.ssItemCategories = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.grpItemCategoriesEntry.SuspendLayout();
            this.ssItemCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // colMakeOrganizationsId
            // 
            this.colMakeOrganizationsId.Text = "Id";
            this.colMakeOrganizationsId.Width = 0;
            // 
            // colMakeOrganizationsName
            // 
            this.colMakeOrganizationsName.Text = "Make Organizations Name";
            this.colMakeOrganizationsName.Width = 500;
            // 
            // lvwMakeOrganizations
            // 
            this.lvwMakeOrganizations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMakeOrganizationsId,
            this.colMakeOrganizationsName});
            this.lvwMakeOrganizations.Cursor = System.Windows.Forms.Cursors.Default;
            this.lvwMakeOrganizations.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMakeOrganizations.FullRowSelect = true;
            this.lvwMakeOrganizations.GridLines = true;
            this.lvwMakeOrganizations.Location = new System.Drawing.Point(36, 142);
            this.lvwMakeOrganizations.MultiSelect = false;
            this.lvwMakeOrganizations.Name = "lvwMakeOrganizations";
            this.lvwMakeOrganizations.Size = new System.Drawing.Size(534, 310);
            this.lvwMakeOrganizations.TabIndex = 8;
            this.lvwMakeOrganizations.UseCompatibleStateImageBehavior = false;
            this.lvwMakeOrganizations.View = System.Windows.Forms.View.Details;
            this.lvwMakeOrganizations.SelectedIndexChanged += new System.EventHandler(this.lvwMakeOrganizations_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(0, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "List of Make Organizatins ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            this.toolStrip1.Size = new System.Drawing.Size(577, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpItemCategoriesEntry
            // 
            this.grpItemCategoriesEntry.Controls.Add(this.lblItemCategoriesName);
            this.grpItemCategoriesEntry.Controls.Add(this.txtMakeOrganizations);
            this.grpItemCategoriesEntry.Location = new System.Drawing.Point(37, 64);
            this.grpItemCategoriesEntry.Name = "grpItemCategoriesEntry";
            this.grpItemCategoriesEntry.Size = new System.Drawing.Size(540, 72);
            this.grpItemCategoriesEntry.TabIndex = 10;
            this.grpItemCategoriesEntry.TabStop = false;
            // 
            // lblItemCategoriesName
            // 
            this.lblItemCategoriesName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblItemCategoriesName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblItemCategoriesName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblItemCategoriesName.Location = new System.Drawing.Point(17, 16);
            this.lblItemCategoriesName.Name = "lblItemCategoriesName";
            this.lblItemCategoriesName.Size = new System.Drawing.Size(172, 16);
            this.lblItemCategoriesName.TabIndex = 4;
            this.lblItemCategoriesName.Text = "Make Organizations Name";
            this.lblItemCategoriesName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMakeOrganizations
            // 
            this.txtMakeOrganizations.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMakeOrganizations.Location = new System.Drawing.Point(20, 35);
            this.txtMakeOrganizations.Name = "txtMakeOrganizations";
            this.txtMakeOrganizations.Size = new System.Drawing.Size(454, 23);
            this.txtMakeOrganizations.TabIndex = 5;
            // 
            // ssItemCategories
            // 
            this.ssItemCategories.BackColor = System.Drawing.Color.Lavender;
            this.ssItemCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssItemCategories.Location = new System.Drawing.Point(0, 468);
            this.ssItemCategories.Name = "ssItemCategories";
            this.ssItemCategories.Size = new System.Drawing.Size(577, 22);
            this.ssItemCategories.TabIndex = 11;
            this.ssItemCategories.Text = "ssItemCategories";
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
            // frmMakeOrganizations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(577, 490);
            this.Controls.Add(this.ssItemCategories);
            this.Controls.Add(this.grpItemCategoriesEntry);
            this.Controls.Add(this.lvwMakeOrganizations);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMakeOrganizations";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Organizations";
            this.Load += new System.EventHandler(this.frmMakeOrganizations_Load);
            this.Activated += new System.EventHandler(this.frmMakeOrganizations_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpItemCategoriesEntry.ResumeLayout(false);
            this.grpItemCategoriesEntry.PerformLayout();
            this.ssItemCategories.ResumeLayout(false);
            this.ssItemCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.ColumnHeader colMakeOrganizationsId;
        private System.Windows.Forms.ColumnHeader colMakeOrganizationsName;
        private System.Windows.Forms.ListView lvwMakeOrganizations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewCountries;
        public System.Windows.Forms.ToolStripButton btnSaveCountries;
        public System.Windows.Forms.ToolStripButton btnDeleteCountries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox grpItemCategoriesEntry;
        private System.Windows.Forms.Label lblItemCategoriesName;
        private System.Windows.Forms.TextBox txtMakeOrganizations;
        private System.Windows.Forms.StatusStrip ssItemCategories;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
    }
}