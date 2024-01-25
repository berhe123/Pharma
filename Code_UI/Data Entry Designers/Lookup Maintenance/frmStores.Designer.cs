//
// ...
// Wizard generated code
// Date: 7/29/2009 5:52:43 PM
// Class: frmStores
// ...
//
namespace Pharma
{
    partial class frmStores
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


        #region Windows Form Designer generated code Stores


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpStoresEntry = new System.Windows.Forms.GroupBox();
            this.lblStoresLocationid = new System.Windows.Forms.Label();
            this.cboStoresLocationid = new System.Windows.Forms.ComboBox();
            this.lblStoresName = new System.Windows.Forms.Label();
            this.txtStoresName = new System.Windows.Forms.TextBox();
            this.lblStoresAddress = new System.Windows.Forms.Label();
            this.txtStoresAddress = new System.Windows.Forms.TextBox();
            this.lvwStores = new System.Windows.Forms.ListView();
            this.colStoresId = new System.Windows.Forms.ColumnHeader();
            this.colStoresLocationGuid = new System.Windows.Forms.ColumnHeader();
            this.colStoresLocation = new System.Windows.Forms.ColumnHeader();
            this.colStoresName = new System.Windows.Forms.ColumnHeader();
            this.colStoresAddress = new System.Windows.Forms.ColumnHeader();
            this.ssStores = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.line3 = new System.Windows.Forms.Panel();
            this.grpStoresEntry.SuspendLayout();
            this.ssStores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStoresEntry
            // 
            this.grpStoresEntry.Controls.Add(this.lblStoresLocationid);
            this.grpStoresEntry.Controls.Add(this.cboStoresLocationid);
            this.grpStoresEntry.Controls.Add(this.lblStoresName);
            this.grpStoresEntry.Controls.Add(this.txtStoresName);
            this.grpStoresEntry.Controls.Add(this.lblStoresAddress);
            this.grpStoresEntry.Controls.Add(this.txtStoresAddress);
            this.grpStoresEntry.Location = new System.Drawing.Point(6, 68);
            this.grpStoresEntry.Name = "grpStoresEntry";
            this.grpStoresEntry.Size = new System.Drawing.Size(542, 128);
            this.grpStoresEntry.TabIndex = 3;
            this.grpStoresEntry.TabStop = false;
            // 
            // lblStoresLocationid
            // 
            this.lblStoresLocationid.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblStoresLocationid.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStoresLocationid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStoresLocationid.Location = new System.Drawing.Point(13, 22);
            this.lblStoresLocationid.Name = "lblStoresLocationid";
            this.lblStoresLocationid.Size = new System.Drawing.Size(133, 16);
            this.lblStoresLocationid.TabIndex = 4;
            this.lblStoresLocationid.Text = "Location";
            this.lblStoresLocationid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboStoresLocationid
            // 
            this.cboStoresLocationid.AllowDrop = true;
            this.cboStoresLocationid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStoresLocationid.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.cboStoresLocationid.FormattingEnabled = true;
            this.cboStoresLocationid.Location = new System.Drawing.Point(13, 38);
            this.cboStoresLocationid.Name = "cboStoresLocationid";
            this.cboStoresLocationid.Size = new System.Drawing.Size(194, 24);
            this.cboStoresLocationid.TabIndex = 5;
            // 
            // lblStoresName
            // 
            this.lblStoresName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblStoresName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStoresName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStoresName.Location = new System.Drawing.Point(13, 73);
            this.lblStoresName.Name = "lblStoresName";
            this.lblStoresName.Size = new System.Drawing.Size(107, 16);
            this.lblStoresName.TabIndex = 6;
            this.lblStoresName.Text = "Name";
            this.lblStoresName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStoresName
            // 
            this.txtStoresName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoresName.Location = new System.Drawing.Point(13, 90);
            this.txtStoresName.Name = "txtStoresName";
            this.txtStoresName.Size = new System.Drawing.Size(194, 23);
            this.txtStoresName.TabIndex = 7;
            // 
            // lblStoresAddress
            // 
            this.lblStoresAddress.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblStoresAddress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblStoresAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStoresAddress.Location = new System.Drawing.Point(218, 22);
            this.lblStoresAddress.Name = "lblStoresAddress";
            this.lblStoresAddress.Size = new System.Drawing.Size(107, 16);
            this.lblStoresAddress.TabIndex = 8;
            this.lblStoresAddress.Text = "Address";
            this.lblStoresAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtStoresAddress
            // 
            this.txtStoresAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoresAddress.Location = new System.Drawing.Point(218, 38);
            this.txtStoresAddress.Multiline = true;
            this.txtStoresAddress.Name = "txtStoresAddress";
            this.txtStoresAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStoresAddress.Size = new System.Drawing.Size(312, 74);
            this.txtStoresAddress.TabIndex = 9;
            // 
            // lvwStores
            // 
            this.lvwStores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStoresId,
            this.colStoresLocationGuid,
            this.colStoresLocation,
            this.colStoresName,
            this.colStoresAddress});
            this.lvwStores.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwStores.FullRowSelect = true;
            this.lvwStores.GridLines = true;
            this.lvwStores.Location = new System.Drawing.Point(10, 204);
            this.lvwStores.MultiSelect = false;
            this.lvwStores.Name = "lvwStores";
            this.lvwStores.Size = new System.Drawing.Size(536, 262);
            this.lvwStores.TabIndex = 10;
            this.lvwStores.UseCompatibleStateImageBehavior = false;
            this.lvwStores.View = System.Windows.Forms.View.Details;
            this.lvwStores.SelectedIndexChanged += new System.EventHandler(this.lvwStores_SelectedIndexChanged);
            this.lvwStores.DoubleClick += new System.EventHandler(this.lvwStores_DoubleClick);
            // 
            // colStoresId
            // 
            this.colStoresId.Text = "Id";
            this.colStoresId.Width = 0;
            // 
            // colStoresLocationGuid
            // 
            this.colStoresLocationGuid.Text = "Location Guid";
            this.colStoresLocationGuid.Width = 0;
            // 
            // colStoresLocation
            // 
            this.colStoresLocation.Text = "Location";
            this.colStoresLocation.Width = 200;
            // 
            // colStoresName
            // 
            this.colStoresName.Text = "Name";
            this.colStoresName.Width = 310;
            // 
            // colStoresAddress
            // 
            this.colStoresAddress.Text = "Address";
            this.colStoresAddress.Width = 0;
            // 
            // ssStores
            // 
            this.ssStores.BackColor = System.Drawing.Color.Lavender;
            this.ssStores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssStores.Location = new System.Drawing.Point(0, 471);
            this.ssStores.Name = "ssStores";
            this.ssStores.Size = new System.Drawing.Size(555, 22);
            this.ssStores.TabIndex = 11;
            this.ssStores.Text = "ssStores";
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
            this.label3.Text = "    Store Maintenance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 28);
            this.panel1.TabIndex = 120;
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
            this.btnNew,
            this.btnSave,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(558, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNew.Image = global::Pharma.Properties.Resources.New;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(53, 22);
            this.btnNew.Text = "New";
            this.btnNew.ToolTipText = "Prepare the system to accept a new store record";
            this.btnNew.Click += new System.EventHandler(this.btnNewStores_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Image = global::Pharma.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 22);
            this.btnSave.Text = "Save";
            this.btnSave.ToolTipText = "Save the current store record (i.e. newly created or edited)";
            this.btnSave.Click += new System.EventHandler(this.btnSaveStores_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.Image = global::Pharma.Properties.Resources.delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 22);
            this.btnDelete.Text = "Delete";
            this.btnDelete.ToolTipText = "Delete the currently selected store record";
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteStores_Click);
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
            this.btnClose.ToolTipText = "Close the Store Maintenance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(-2, 469);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(558, 1);
            this.line3.TabIndex = 123;
            // 
            // frmStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(555, 493);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwStores);
            this.Controls.Add(this.ssStores);
            this.Controls.Add(this.grpStoresEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStores";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart ";
            this.Load += new System.EventHandler(this.frmStores_Load);
            this.Activated += new System.EventHandler(this.frmStores_Activated);
            this.grpStoresEntry.ResumeLayout(false);
            this.grpStoresEntry.PerformLayout();
            this.ssStores.ResumeLayout(false);
            this.ssStores.PerformLayout();
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

        private System.Windows.Forms.StatusStrip ssStores;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;

        private System.Windows.Forms.GroupBox grpStoresEntry;
        private System.Windows.Forms.ListView lvwStores;

        private System.Windows.Forms.Label lblStoresLocationid;
        private System.Windows.Forms.ComboBox cboStoresLocationid;
        private System.Windows.Forms.Label lblStoresName;
        private System.Windows.Forms.TextBox txtStoresName;
        private System.Windows.Forms.Label lblStoresAddress;
        private System.Windows.Forms.TextBox txtStoresAddress;

        private System.Windows.Forms.ColumnHeader colStoresId;
        private System.Windows.Forms.ColumnHeader colStoresLocationGuid;
        private System.Windows.Forms.ColumnHeader colStoresName;
        private System.Windows.Forms.ColumnHeader colStoresAddress;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.Panel line3;
        private System.Windows.Forms.ColumnHeader colStoresLocation;
        public System.Windows.Forms.ToolStripButton btnSave;
        public System.Windows.Forms.ToolStripButton btnDelete;


    }
}
