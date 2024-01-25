//
// ...
// Wizard generated code
// Date: 7/29/2009 4:48:11 PM
// Class: frmLocations
// ...
//
namespace Pharma
{
    partial class frmLocations
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


        #region Windows Form Designer generated code Locations


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ssLocations = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewLocations = new System.Windows.Forms.ToolStripButton();
            this.btnSaveLocations = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteLocations = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.grpLocationsEntry = new System.Windows.Forms.GroupBox();
            this.lblLocationsName = new System.Windows.Forms.Label();
            this.txtLocationsName = new System.Windows.Forms.TextBox();
            this.lvwLocations = new System.Windows.Forms.ListView();
            this.colLocationsId = new System.Windows.Forms.ColumnHeader();
            this.colLocationsName = new System.Windows.Forms.ColumnHeader();
            this.line3 = new System.Windows.Forms.Panel();
            this.ssLocations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpLocationsEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssLocations
            // 
            this.ssLocations.BackColor = System.Drawing.Color.Lavender;
            this.ssLocations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssLocations.Location = new System.Drawing.Point(0, 471);
            this.ssLocations.Name = "ssLocations";
            this.ssLocations.Size = new System.Drawing.Size(555, 22);
            this.ssLocations.TabIndex = 7;
            this.ssLocations.Text = "ssLocations";
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
            this.line1.Location = new System.Drawing.Point(-2, 35);
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
            this.label3.Location = new System.Drawing.Point(-2, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "    Location Maintenance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(-2, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 28);
            this.panel1.TabIndex = 118;
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
            this.btnNewLocations,
            this.btnSaveLocations,
            this.btnDeleteLocations,
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
            // btnNewLocations
            // 
            this.btnNewLocations.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLocations.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewLocations.Image = global::Pharma.Properties.Resources.New;
            this.btnNewLocations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewLocations.Name = "btnNewLocations";
            this.btnNewLocations.Size = new System.Drawing.Size(53, 22);
            this.btnNewLocations.Text = "New";
            this.btnNewLocations.ToolTipText = "Prepare the system to accept a new location record";
            this.btnNewLocations.Click += new System.EventHandler(this.btnNewLocations_Click);
            // 
            // btnSaveLocations
            // 
            this.btnSaveLocations.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLocations.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveLocations.Image = global::Pharma.Properties.Resources.save;
            this.btnSaveLocations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveLocations.Name = "btnSaveLocations";
            this.btnSaveLocations.Size = new System.Drawing.Size(56, 22);
            this.btnSaveLocations.Text = "Save";
            this.btnSaveLocations.ToolTipText = "Save the current location record (i.e. newly created or edited)";
            this.btnSaveLocations.Click += new System.EventHandler(this.btnSaveLocations_Click);
            // 
            // btnDeleteLocations
            // 
            this.btnDeleteLocations.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLocations.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteLocations.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeleteLocations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteLocations.Name = "btnDeleteLocations";
            this.btnDeleteLocations.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteLocations.Text = "Delete";
            this.btnDeleteLocations.ToolTipText = "Delete the currently selected location record";
            this.btnDeleteLocations.Click += new System.EventHandler(this.btnDeleteLocations_Click);
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
            this.btnClose.ToolTipText = "Close the Location Maintenance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpLocationsEntry
            // 
            this.grpLocationsEntry.Controls.Add(this.lblLocationsName);
            this.grpLocationsEntry.Controls.Add(this.txtLocationsName);
            this.grpLocationsEntry.Location = new System.Drawing.Point(4, 70);
            this.grpLocationsEntry.Name = "grpLocationsEntry";
            this.grpLocationsEntry.Size = new System.Drawing.Size(540, 85);
            this.grpLocationsEntry.TabIndex = 3;
            this.grpLocationsEntry.TabStop = false;
            // 
            // lblLocationsName
            // 
            this.lblLocationsName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblLocationsName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblLocationsName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLocationsName.Location = new System.Drawing.Point(20, 22);
            this.lblLocationsName.Name = "lblLocationsName";
            this.lblLocationsName.Size = new System.Drawing.Size(107, 16);
            this.lblLocationsName.TabIndex = 4;
            this.lblLocationsName.Text = "Locations Name";
            this.lblLocationsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLocationsName
            // 
            this.txtLocationsName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationsName.Location = new System.Drawing.Point(20, 40);
            this.txtLocationsName.Name = "txtLocationsName";
            this.txtLocationsName.Size = new System.Drawing.Size(454, 23);
            this.txtLocationsName.TabIndex = 5;
            // 
            // lvwLocations
            // 
            this.lvwLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLocationsId,
            this.colLocationsName});
            this.lvwLocations.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLocations.FullRowSelect = true;
            this.lvwLocations.GridLines = true;
            this.lvwLocations.Location = new System.Drawing.Point(8, 162);
            this.lvwLocations.MultiSelect = false;
            this.lvwLocations.Name = "lvwLocations";
            this.lvwLocations.Size = new System.Drawing.Size(534, 295);
            this.lvwLocations.TabIndex = 6;
            this.lvwLocations.UseCompatibleStateImageBehavior = false;
            this.lvwLocations.View = System.Windows.Forms.View.Details;
            this.lvwLocations.SelectedIndexChanged += new System.EventHandler(this.lvwLocations_SelectedIndexChanged);
            this.lvwLocations.DoubleClick += new System.EventHandler(this.lvwLocations_DoubleClick);
            // 
            // colLocationsId
            // 
            this.colLocationsId.Text = "Id";
            this.colLocationsId.Width = 0;
            // 
            // colLocationsName
            // 
            this.colLocationsName.Text = "Locations Name";
            this.colLocationsName.Width = 500;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(-2, 469);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(558, 1);
            this.line3.TabIndex = 122;
            // 
            // frmLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(555, 493);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.lvwLocations);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpLocationsEntry);
            this.Controls.Add(this.ssLocations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocations";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart ";
            this.Load += new System.EventHandler(this.frmLocations_Load);
            this.Activated += new System.EventHandler(this.frmLocations_Activated);
            this.ssLocations.ResumeLayout(false);
            this.ssLocations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpLocationsEntry.ResumeLayout(false);
            this.grpLocationsEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion



        // Declare Controls
        // put this in the InitializeComponents Method

        // put these outside the InitializeComponents Method

        private System.Windows.Forms.StatusStrip ssLocations;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewLocations;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox grpLocationsEntry;
        private System.Windows.Forms.Label lblLocationsName;
        private System.Windows.Forms.TextBox txtLocationsName;
        private System.Windows.Forms.ListView lvwLocations;
        private System.Windows.Forms.ColumnHeader colLocationsId;
        private System.Windows.Forms.ColumnHeader colLocationsName;
        private System.Windows.Forms.Panel line3;
        public System.Windows.Forms.ToolStripButton btnSaveLocations;
        public System.Windows.Forms.ToolStripButton btnDeleteLocations;


    }
}
