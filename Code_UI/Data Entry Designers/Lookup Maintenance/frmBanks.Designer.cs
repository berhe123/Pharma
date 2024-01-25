//
// ...
// Wizard generated code
// Date: 8/11/2009 6:38:47 PM
// Class: frmBanks
// ...
//
namespace Pharma
{
    partial class frmBanks
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


        #region Windows Form Designer generated code Banks


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpBanksEntry = new System.Windows.Forms.GroupBox();
            this.lblBanksName = new System.Windows.Forms.Label();
            this.txtBanksName = new System.Windows.Forms.TextBox();
            this.lvwBanks = new System.Windows.Forms.ListView();
            this.colBanksId = new System.Windows.Forms.ColumnHeader();
            this.colBanksName = new System.Windows.Forms.ColumnHeader();
            this.ssBanks = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewBanks = new System.Windows.Forms.ToolStripButton();
            this.btnSaveBanks = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteBanks = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.grpBanksEntry.SuspendLayout();
            this.ssBanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBanksEntry
            // 
            this.grpBanksEntry.Controls.Add(this.lblBanksName);
            this.grpBanksEntry.Controls.Add(this.txtBanksName);
            this.grpBanksEntry.Location = new System.Drawing.Point(4, 72);
            this.grpBanksEntry.Name = "grpBanksEntry";
            this.grpBanksEntry.Size = new System.Drawing.Size(464, 73);
            this.grpBanksEntry.TabIndex = 5;
            this.grpBanksEntry.TabStop = false;
            // 
            // lblBanksName
            // 
            this.lblBanksName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblBanksName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBanksName.Location = new System.Drawing.Point(9, 16);
            this.lblBanksName.Name = "lblBanksName";
            this.lblBanksName.Size = new System.Drawing.Size(107, 20);
            this.lblBanksName.TabIndex = 6;
            this.lblBanksName.Text = "Name of Bank";
            this.lblBanksName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBanksName
            // 
            this.txtBanksName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBanksName.Location = new System.Drawing.Point(9, 37);
            this.txtBanksName.Name = "txtBanksName";
            this.txtBanksName.Size = new System.Drawing.Size(421, 23);
            this.txtBanksName.TabIndex = 7;
            // 
            // lvwBanks
            // 
            this.lvwBanks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBanksId,
            this.colBanksName});
            this.lvwBanks.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBanks.FullRowSelect = true;
            this.lvwBanks.GridLines = true;
            this.lvwBanks.Location = new System.Drawing.Point(6, 150);
            this.lvwBanks.MultiSelect = false;
            this.lvwBanks.Name = "lvwBanks";
            this.lvwBanks.Size = new System.Drawing.Size(458, 248);
            this.lvwBanks.TabIndex = 8;
            this.lvwBanks.UseCompatibleStateImageBehavior = false;
            this.lvwBanks.View = System.Windows.Forms.View.Details;
            this.lvwBanks.SelectedIndexChanged += new System.EventHandler(this.lvwBanks_SelectedIndexChanged);
            this.lvwBanks.DoubleClick += new System.EventHandler(this.lvwBanks_DoubleClick);
            // 
            // colBanksId
            // 
            this.colBanksId.Text = "Id";
            this.colBanksId.Width = 0;
            // 
            // colBanksName
            // 
            this.colBanksName.Text = "Name of Bank";
            this.colBanksName.Width = 430;
            // 
            // ssBanks
            // 
            this.ssBanks.BackColor = System.Drawing.Color.Lavender;
            this.ssBanks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssBanks.Location = new System.Drawing.Point(0, 402);
            this.ssBanks.Name = "ssBanks";
            this.ssBanks.Size = new System.Drawing.Size(473, 22);
            this.ssBanks.TabIndex = 9;
            this.ssBanks.Text = "ssBanks";
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
            this.line1.Location = new System.Drawing.Point(-2, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(478, 1);
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
            this.label3.Size = new System.Drawing.Size(478, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "    Bank Maintenance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(-2, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 28);
            this.panel1.TabIndex = 2;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line2.Location = new System.Drawing.Point(0, 24);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(558, 1);
            this.line2.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnNewBanks,
            this.btnSaveBanks,
            this.btnDeleteBanks,
            this.toolStripSeparator3,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(478, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewBanks
            // 
            this.btnNewBanks.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBanks.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewBanks.Image = global::Pharma.Properties.Resources.New;
            this.btnNewBanks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewBanks.Name = "btnNewBanks";
            this.btnNewBanks.Size = new System.Drawing.Size(53, 22);
            this.btnNewBanks.Text = "New";
            this.btnNewBanks.ToolTipText = "Prepare the system to accept a new bank record";
            this.btnNewBanks.Click += new System.EventHandler(this.btnNewBanks_Click);
            // 
            // btnSaveBanks
            // 
            this.btnSaveBanks.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBanks.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveBanks.Image = global::Pharma.Properties.Resources.save;
            this.btnSaveBanks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveBanks.Name = "btnSaveBanks";
            this.btnSaveBanks.Size = new System.Drawing.Size(56, 22);
            this.btnSaveBanks.Text = "Save";
            this.btnSaveBanks.ToolTipText = "Save the current bank record (i.e. newly created or edited)";
            this.btnSaveBanks.Click += new System.EventHandler(this.btnSaveBanks_Click);
            // 
            // btnDeleteBanks
            // 
            this.btnDeleteBanks.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBanks.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteBanks.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeleteBanks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteBanks.Name = "btnDeleteBanks";
            this.btnDeleteBanks.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteBanks.Text = "Delete";
            this.btnDeleteBanks.ToolTipText = "Delete the currently selected bank record";
            this.btnDeleteBanks.Click += new System.EventHandler(this.btnDeleteBanks_Click);
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
            this.btnClose.ToolTipText = "Close the Bank Maintenance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(473, 424);
            this.Controls.Add(this.lvwBanks);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssBanks);
            this.Controls.Add(this.grpBanksEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBanks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart ";
            this.Load += new System.EventHandler(this.frmBanks_Load);
            this.Activated += new System.EventHandler(this.frmBanks_Activated);
            this.grpBanksEntry.ResumeLayout(false);
            this.grpBanksEntry.PerformLayout();
            this.ssBanks.ResumeLayout(false);
            this.ssBanks.PerformLayout();
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

        private System.Windows.Forms.StatusStrip ssBanks;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;

        private System.Windows.Forms.GroupBox grpBanksEntry;
        private System.Windows.Forms.ListView lvwBanks;

        private System.Windows.Forms.Label lblBanksName;
        private System.Windows.Forms.TextBox txtBanksName;

        private System.Windows.Forms.ColumnHeader colBanksId;
        private System.Windows.Forms.ColumnHeader colBanksName;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewBanks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        public System.Windows.Forms.ToolStripButton btnSaveBanks;
        public System.Windows.Forms.ToolStripButton btnDeleteBanks;


    }
}
