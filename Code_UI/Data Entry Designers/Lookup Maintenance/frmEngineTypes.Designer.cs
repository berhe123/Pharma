namespace Pharma
{
    partial class frmEngineTypes
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
            this.lblEngineType = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewCountries = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCountries = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCountries = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.grpEngineTypeEntry = new System.Windows.Forms.GroupBox();
            this.lblEngineTypeName = new System.Windows.Forms.Label();
            this.txtEngineTypeName = new System.Windows.Forms.TextBox();
            this.lvwEngineTypes = new System.Windows.Forms.ListView();
            this.colEngineTypesId = new System.Windows.Forms.ColumnHeader();
            this.colEngineTypesName = new System.Windows.Forms.ColumnHeader();
            this.ssIEngineTypes = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.grpEngineTypeEntry.SuspendLayout();
            this.ssIEngineTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEngineType
            // 
            this.lblEngineType.BackColor = System.Drawing.Color.White;
            this.lblEngineType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEngineType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEngineType.Location = new System.Drawing.Point(0, 31);
            this.lblEngineType.Name = "lblEngineType";
            this.lblEngineType.Size = new System.Drawing.Size(558, 36);
            this.lblEngineType.TabIndex = 1;
            this.lblEngineType.Text = "  Engine Type Maintenance";
            this.lblEngineType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEngineType.Click += new System.EventHandler(this.lblEngineType_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(562, 25);
            this.toolStrip1.TabIndex = 3;
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpEngineTypeEntry
            // 
            this.grpEngineTypeEntry.Controls.Add(this.lblEngineTypeName);
            this.grpEngineTypeEntry.Controls.Add(this.txtEngineTypeName);
            this.grpEngineTypeEntry.Location = new System.Drawing.Point(11, 71);
            this.grpEngineTypeEntry.Name = "grpEngineTypeEntry";
            this.grpEngineTypeEntry.Size = new System.Drawing.Size(540, 72);
            this.grpEngineTypeEntry.TabIndex = 4;
            this.grpEngineTypeEntry.TabStop = false;
            this.grpEngineTypeEntry.Enter += new System.EventHandler(this.grpEngineTypeEntry_Enter);
            // 
            // lblEngineTypeName
            // 
            this.lblEngineTypeName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblEngineTypeName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblEngineTypeName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEngineTypeName.Location = new System.Drawing.Point(17, 16);
            this.lblEngineTypeName.Name = "lblEngineTypeName";
            this.lblEngineTypeName.Size = new System.Drawing.Size(135, 16);
            this.lblEngineTypeName.TabIndex = 4;
            this.lblEngineTypeName.Text = "Engine Type Name";
            this.lblEngineTypeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEngineTypeName
            // 
            this.txtEngineTypeName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngineTypeName.Location = new System.Drawing.Point(20, 35);
            this.txtEngineTypeName.Name = "txtEngineTypeName";
            this.txtEngineTypeName.Size = new System.Drawing.Size(454, 23);
            this.txtEngineTypeName.TabIndex = 5;
            // 
            // lvwEngineTypes
            // 
            this.lvwEngineTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEngineTypesId,
            this.colEngineTypesName});
            this.lvwEngineTypes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwEngineTypes.FullRowSelect = true;
            this.lvwEngineTypes.GridLines = true;
            this.lvwEngineTypes.Location = new System.Drawing.Point(14, 152);
            this.lvwEngineTypes.MultiSelect = false;
            this.lvwEngineTypes.Name = "lvwEngineTypes";
            this.lvwEngineTypes.Size = new System.Drawing.Size(534, 310);
            this.lvwEngineTypes.TabIndex = 7;
            this.lvwEngineTypes.UseCompatibleStateImageBehavior = false;
            this.lvwEngineTypes.View = System.Windows.Forms.View.Details;
            this.lvwEngineTypes.SelectedIndexChanged += new System.EventHandler(this.lvwEngineTypes_SelectedIndexChanged);
            // 
            // colEngineTypesId
            // 
            this.colEngineTypesId.Text = "Id";
            this.colEngineTypesId.Width = 0;
            // 
            // colEngineTypesName
            // 
            this.colEngineTypesName.Text = "Engine Type Name";
            this.colEngineTypesName.Width = 500;
            // 
            // ssIEngineTypes
            // 
            this.ssIEngineTypes.BackColor = System.Drawing.Color.Lavender;
            this.ssIEngineTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssIEngineTypes.Location = new System.Drawing.Point(0, 471);
            this.ssIEngineTypes.Name = "ssIEngineTypes";
            this.ssIEngineTypes.Size = new System.Drawing.Size(562, 22);
            this.ssIEngineTypes.TabIndex = 8;
            this.ssIEngineTypes.Text = "ssEngineTypes";
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
            // frmEngineTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(562, 493);
            this.Controls.Add(this.ssIEngineTypes);
            this.Controls.Add(this.lvwEngineTypes);
            this.Controls.Add(this.grpEngineTypeEntry);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblEngineType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEngineTypes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engine Type";
            this.Load += new System.EventHandler(this.frmEngineTypes_Load);
            this.Activated += new System.EventHandler(this.frmEngineTypes_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpEngineTypeEntry.ResumeLayout(false);
            this.grpEngineTypeEntry.PerformLayout();
            this.ssIEngineTypes.ResumeLayout(false);
            this.ssIEngineTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEngineType;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewCountries;
        public System.Windows.Forms.ToolStripButton btnSaveCountries;
        public System.Windows.Forms.ToolStripButton btnDeleteCountries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox grpEngineTypeEntry;
        private System.Windows.Forms.Label lblEngineTypeName;
        private System.Windows.Forms.TextBox txtEngineTypeName;
        private System.Windows.Forms.ListView lvwEngineTypes;
        private System.Windows.Forms.ColumnHeader colEngineTypesId;
        private System.Windows.Forms.ColumnHeader colEngineTypesName;
        private System.Windows.Forms.StatusStrip ssIEngineTypes;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
    }
}