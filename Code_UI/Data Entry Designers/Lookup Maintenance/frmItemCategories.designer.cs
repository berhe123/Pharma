//
// ...
// Wizard generated code
// Date: 7/29/2009 4:29:20 PM
// Class: frmItemCategories
// ...
//
namespace Pharma
{
    partial class frmItemCategories
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


        #region Windows Form Designer generated code ItemCategories


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpItemCategoriesEntry = new System.Windows.Forms.GroupBox();
            this.lblItemCategoriesName = new System.Windows.Forms.Label();
            this.txtItemCategoriesName = new System.Windows.Forms.TextBox();
            this.ssItemCategories = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewCountries = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCountries = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCountries = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.line3 = new System.Windows.Forms.Panel();
            this.lvwItemCategories = new System.Windows.Forms.ListView();
            this.colItemCategoriesId = new System.Windows.Forms.ColumnHeader();
            this.colItemCategoriesName = new System.Windows.Forms.ColumnHeader();
            this.grpItemCategoriesEntry.SuspendLayout();
            this.ssItemCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpItemCategoriesEntry
            // 
            this.grpItemCategoriesEntry.Controls.Add(this.lblItemCategoriesName);
            this.grpItemCategoriesEntry.Controls.Add(this.txtItemCategoriesName);
            this.grpItemCategoriesEntry.Location = new System.Drawing.Point(6, 72);
            this.grpItemCategoriesEntry.Name = "grpItemCategoriesEntry";
            this.grpItemCategoriesEntry.Size = new System.Drawing.Size(540, 72);
            this.grpItemCategoriesEntry.TabIndex = 3;
            this.grpItemCategoriesEntry.TabStop = false;
            this.grpItemCategoriesEntry.Enter += new System.EventHandler(this.grpItemCategoriesEntry_Enter);
            // 
            // lblItemCategoriesName
            // 
            this.lblItemCategoriesName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblItemCategoriesName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblItemCategoriesName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblItemCategoriesName.Location = new System.Drawing.Point(17, 16);
            this.lblItemCategoriesName.Name = "lblItemCategoriesName";
            this.lblItemCategoriesName.Size = new System.Drawing.Size(107, 16);
            this.lblItemCategoriesName.TabIndex = 4;
            this.lblItemCategoriesName.Text = "Category Name";
            this.lblItemCategoriesName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblItemCategoriesName.Click += new System.EventHandler(this.lblItemCategoriesName_Click);
            // 
            // txtItemCategoriesName
            // 
            this.txtItemCategoriesName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemCategoriesName.Location = new System.Drawing.Point(20, 35);
            this.txtItemCategoriesName.Name = "txtItemCategoriesName";
            this.txtItemCategoriesName.Size = new System.Drawing.Size(454, 23);
            this.txtItemCategoriesName.TabIndex = 5;
            this.txtItemCategoriesName.TextChanged += new System.EventHandler(this.txtItemCategoriesName_TextChanged);
            // 
            // ssItemCategories
            // 
            this.ssItemCategories.BackColor = System.Drawing.Color.Lavender;
            this.ssItemCategories.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssItemCategories.Location = new System.Drawing.Point(0, 471);
            this.ssItemCategories.Name = "ssItemCategories";
            this.ssItemCategories.Size = new System.Drawing.Size(555, 22);
            this.ssItemCategories.TabIndex = 7;
            this.ssItemCategories.Text = "ssItemCategories";
            this.ssItemCategories.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ssItemCategories_ItemClicked);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(44, 17);
            this.lblMsg.Text = "lblMsg";
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // mValidator
            // 
            this.mValidator.ContainerControl = this;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(0, 37);
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
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "    Item Category Maintenance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 28);
            this.panel1.TabIndex = 114;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line2.Location = new System.Drawing.Point(0, 24);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(558, 1);
            this.line2.TabIndex = 111;
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
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.btnNewCountries.Click += new System.EventHandler(this.btnNewItemCategories_Click);
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
            this.btnSaveCountries.Click += new System.EventHandler(this.btnSaveItemCategories_Click);
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
            this.btnDeleteCountries.Click += new System.EventHandler(this.btnDeleteItemCategories_Click);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(-2, 469);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(558, 1);
            this.line3.TabIndex = 117;
            // 
            // lvwItemCategories
            // 
            this.lvwItemCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colItemCategoriesId,
            this.colItemCategoriesName});
            this.lvwItemCategories.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwItemCategories.FullRowSelect = true;
            this.lvwItemCategories.GridLines = true;
            this.lvwItemCategories.Location = new System.Drawing.Point(10, 150);
            this.lvwItemCategories.MultiSelect = false;
            this.lvwItemCategories.Name = "lvwItemCategories";
            this.lvwItemCategories.Size = new System.Drawing.Size(534, 310);
            this.lvwItemCategories.TabIndex = 6;
            this.lvwItemCategories.UseCompatibleStateImageBehavior = false;
            this.lvwItemCategories.View = System.Windows.Forms.View.Details;
            this.lvwItemCategories.SelectedIndexChanged += new System.EventHandler(this.lvwItemCategories_SelectedIndexChanged);
            this.lvwItemCategories.DoubleClick += new System.EventHandler(this.lvwItemCategories_DoubleClick);
            // 
            // colItemCategoriesId
            // 
            this.colItemCategoriesId.Text = "Id";
            this.colItemCategoriesId.Width = 0;
            // 
            // colItemCategoriesName
            // 
            this.colItemCategoriesName.Text = "Category Name";
            this.colItemCategoriesName.Width = 500;
            // 
            // frmItemCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(555, 493);
            this.Controls.Add(this.lvwItemCategories);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssItemCategories);
            this.Controls.Add(this.grpItemCategoriesEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemCategories";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart ";
            this.Load += new System.EventHandler(this.frmItemCategories_Load);
            this.Activated += new System.EventHandler(this.frmItemCategories_Activated);
            this.grpItemCategoriesEntry.ResumeLayout(false);
            this.grpItemCategoriesEntry.PerformLayout();
            this.ssItemCategories.ResumeLayout(false);
            this.ssItemCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion



        // Declare Controls
        // put this in the InitializeComponents Method

        // put these outside the InitializeComponents Method

        private System.Windows.Forms.StatusStrip ssItemCategories;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;

        private System.Windows.Forms.GroupBox grpItemCategoriesEntry;

        private System.Windows.Forms.Label lblItemCategoriesName;
        private System.Windows.Forms.TextBox txtItemCategoriesName;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewCountries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.ListView lvwItemCategories;
        private System.Windows.Forms.ColumnHeader colItemCategoriesId;
        private System.Windows.Forms.ColumnHeader colItemCategoriesName;
        public System.Windows.Forms.ToolStripButton btnSaveCountries;
        public System.Windows.Forms.ToolStripButton btnDeleteCountries;


    }
}
