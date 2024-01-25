namespace Pharma
{
    partial class frmModel
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
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewCountries = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCountries = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCountries = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.grpModelEntry = new System.Windows.Forms.GroupBox();
            this.lblModelName = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.lvwModel = new System.Windows.Forms.ListView();
            this.colModelId = new System.Windows.Forms.ColumnHeader();
            this.colModelName = new System.Windows.Forms.ColumnHeader();
            this.ssModel = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            this.grpModelEntry.SuspendLayout();
            this.ssModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(0, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model  Maintenance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // grpModelEntry
            // 
            this.grpModelEntry.Controls.Add(this.lblModelName);
            this.grpModelEntry.Controls.Add(this.txtModelName);
            this.grpModelEntry.Location = new System.Drawing.Point(11, 63);
            this.grpModelEntry.Name = "grpModelEntry";
            this.grpModelEntry.Size = new System.Drawing.Size(540, 72);
            this.grpModelEntry.TabIndex = 4;
            this.grpModelEntry.TabStop = false;
            // 
            // lblModelName
            // 
            this.lblModelName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblModelName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblModelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblModelName.Location = new System.Drawing.Point(17, 16);
            this.lblModelName.Name = "lblModelName";
            this.lblModelName.Size = new System.Drawing.Size(107, 16);
            this.lblModelName.TabIndex = 4;
            this.lblModelName.Text = "Model Name";
            this.lblModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModelName
            // 
            this.txtModelName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelName.Location = new System.Drawing.Point(20, 35);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(454, 23);
            this.txtModelName.TabIndex = 5;
            this.txtModelName.TextChanged += new System.EventHandler(this.txtModelName_TextChanged);
            // 
            // lvwModel
            // 
            this.lvwModel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colModelId,
            this.colModelName});
            this.lvwModel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwModel.FullRowSelect = true;
            this.lvwModel.GridLines = true;
            this.lvwModel.Location = new System.Drawing.Point(14, 149);
            this.lvwModel.MultiSelect = false;
            this.lvwModel.Name = "lvwModel";
            this.lvwModel.Size = new System.Drawing.Size(534, 312);
            this.lvwModel.TabIndex = 7;
            this.lvwModel.UseCompatibleStateImageBehavior = false;
            this.lvwModel.View = System.Windows.Forms.View.Details;
            this.lvwModel.SelectedIndexChanged += new System.EventHandler(this.lvwModel_SelectedIndexChanged);
            // 
            // colModelId
            // 
            this.colModelId.Text = "Id";
            this.colModelId.Width = 0;
            // 
            // colModelName
            // 
            this.colModelName.Text = "Model Name";
            this.colModelName.Width = 500;
            // 
            // ssModel
            // 
            this.ssModel.BackColor = System.Drawing.Color.Lavender;
            this.ssModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssModel.Location = new System.Drawing.Point(0, 468);
            this.ssModel.Name = "ssModel";
            this.ssModel.Size = new System.Drawing.Size(562, 22);
            this.ssModel.TabIndex = 8;
            this.ssModel.Text = "ssModel";
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
            // frmModel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(562, 490);
            this.Controls.Add(this.ssModel);
            this.Controls.Add(this.lvwModel);
            this.Controls.Add(this.grpModelEntry);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Model";
            this.Load += new System.EventHandler(this.frmModel_Load);
            this.Activated += new System.EventHandler(this.frmModel_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpModelEntry.ResumeLayout(false);
            this.grpModelEntry.PerformLayout();
            this.ssModel.ResumeLayout(false);
            this.ssModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewCountries;
        public System.Windows.Forms.ToolStripButton btnSaveCountries;
        public System.Windows.Forms.ToolStripButton btnDeleteCountries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox grpModelEntry;
        private System.Windows.Forms.Label lblModelName;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.ListView lvwModel;
        private System.Windows.Forms.ColumnHeader colModelId;
        private System.Windows.Forms.ColumnHeader colModelName;
        private System.Windows.Forms.StatusStrip ssModel;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
    }
}