//
// ...
// Wizard generated code
// Date: 11/12/2009 11:15:14 AM
// Class: frmDrugRegistrationTypes
// ...
//
namespace Pharma
{
    partial class frmDrugRegistrationTypes
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


        #region Windows Form Designer generated code DrugRegistrationTypes


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpDrugRegistrationTypesEntry = new System.Windows.Forms.GroupBox();
            this.lblDrugRegistrationTypesName = new System.Windows.Forms.Label();
            this.txtDrugRegistrationTypesName = new System.Windows.Forms.TextBox();
            this.lvwDrugRegistrationTypes = new System.Windows.Forms.ListView();
            this.colDrugRegistrationTypesId = new System.Windows.Forms.ColumnHeader();
            this.colDrugRegistrationTypesName = new System.Windows.Forms.ColumnHeader();
            this.ssDrugRegistrationTypes = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.tsDrugRegistrationTypes = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewDrugRegistrationTypes = new System.Windows.Forms.ToolStripButton();
            this.btnSaveDrugRegistrationTypes = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDrugRegistrationTypes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.grpDrugRegistrationTypesEntry.SuspendLayout();
            this.ssDrugRegistrationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panel1.SuspendLayout();
            this.tsDrugRegistrationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDrugRegistrationTypesEntry
            // 
            this.grpDrugRegistrationTypesEntry.Controls.Add(this.lblDrugRegistrationTypesName);
            this.grpDrugRegistrationTypesEntry.Controls.Add(this.txtDrugRegistrationTypesName);
            this.grpDrugRegistrationTypesEntry.Location = new System.Drawing.Point(4, 70);
            this.grpDrugRegistrationTypesEntry.Name = "grpDrugRegistrationTypesEntry";
            this.grpDrugRegistrationTypesEntry.Size = new System.Drawing.Size(540, 85);
            this.grpDrugRegistrationTypesEntry.TabIndex = 3;
            this.grpDrugRegistrationTypesEntry.TabStop = false;
            // 
            // lblDrugRegistrationTypesName
            // 
            this.lblDrugRegistrationTypesName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblDrugRegistrationTypesName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDrugRegistrationTypesName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDrugRegistrationTypesName.Location = new System.Drawing.Point(20, 22);
            this.lblDrugRegistrationTypesName.Name = "lblDrugRegistrationTypesName";
            this.lblDrugRegistrationTypesName.Size = new System.Drawing.Size(107, 16);
            this.lblDrugRegistrationTypesName.TabIndex = 4;
            this.lblDrugRegistrationTypesName.Text = "Name";
            this.lblDrugRegistrationTypesName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDrugRegistrationTypesName
            // 
            this.txtDrugRegistrationTypesName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrugRegistrationTypesName.Location = new System.Drawing.Point(20, 40);
            this.txtDrugRegistrationTypesName.Name = "txtDrugRegistrationTypesName";
            this.txtDrugRegistrationTypesName.Size = new System.Drawing.Size(454, 23);
            this.txtDrugRegistrationTypesName.TabIndex = 5;
            // 
            // lvwDrugRegistrationTypes
            // 
            this.lvwDrugRegistrationTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDrugRegistrationTypesId,
            this.colDrugRegistrationTypesName});
            this.lvwDrugRegistrationTypes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDrugRegistrationTypes.FullRowSelect = true;
            this.lvwDrugRegistrationTypes.GridLines = true;
            this.lvwDrugRegistrationTypes.Location = new System.Drawing.Point(8, 162);
            this.lvwDrugRegistrationTypes.MultiSelect = false;
            this.lvwDrugRegistrationTypes.Name = "lvwDrugRegistrationTypes";
            this.lvwDrugRegistrationTypes.Size = new System.Drawing.Size(534, 295);
            this.lvwDrugRegistrationTypes.TabIndex = 6;
            this.lvwDrugRegistrationTypes.UseCompatibleStateImageBehavior = false;
            this.lvwDrugRegistrationTypes.View = System.Windows.Forms.View.Details;
            this.lvwDrugRegistrationTypes.SelectedIndexChanged += new System.EventHandler(this.lvwDrugRegistrationTypes_SelectedIndexChanged);
            // 
            // colDrugRegistrationTypesId
            // 
            this.colDrugRegistrationTypesId.Text = "Id";
            this.colDrugRegistrationTypesId.Width = 0;
            // 
            // colDrugRegistrationTypesName
            // 
            this.colDrugRegistrationTypesName.Text = "Drug Registration Type Name";
            this.colDrugRegistrationTypesName.Width = 500;
            // 
            // ssDrugRegistrationTypes
            // 
            this.ssDrugRegistrationTypes.BackColor = System.Drawing.Color.Lavender;
            this.ssDrugRegistrationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg,
            this.toolStripStatusLabel1});
            this.ssDrugRegistrationTypes.Location = new System.Drawing.Point(0, 469);
            this.ssDrugRegistrationTypes.Name = "ssDrugRegistrationTypes";
            this.ssDrugRegistrationTypes.Size = new System.Drawing.Size(548, 22);
            this.ssDrugRegistrationTypes.TabIndex = 7;
            this.ssDrugRegistrationTypes.Text = "ssDrugRegistrationTypes";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(44, 17);
            this.lblMsg.Text = "lblMsg";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
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
            this.label3.Text = "    Drug Registration Type Maintenance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.tsDrugRegistrationTypes);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 28);
            this.panel1.TabIndex = 121;
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
            // tsDrugRegistrationTypes
            // 
            this.tsDrugRegistrationTypes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsDrugRegistrationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnNewDrugRegistrationTypes,
            this.btnSaveDrugRegistrationTypes,
            this.btnDeleteDrugRegistrationTypes,
            this.toolStripSeparator3,
            this.btnClose});
            this.tsDrugRegistrationTypes.Location = new System.Drawing.Point(0, 0);
            this.tsDrugRegistrationTypes.Name = "tsDrugRegistrationTypes";
            this.tsDrugRegistrationTypes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsDrugRegistrationTypes.Size = new System.Drawing.Size(498, 25);
            this.tsDrugRegistrationTypes.TabIndex = 2;
            this.tsDrugRegistrationTypes.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewDrugRegistrationTypes
            // 
            this.btnNewDrugRegistrationTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDrugRegistrationTypes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewDrugRegistrationTypes.Image = global::Pharma.Properties.Resources.New;
            this.btnNewDrugRegistrationTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewDrugRegistrationTypes.Name = "btnNewDrugRegistrationTypes";
            this.btnNewDrugRegistrationTypes.Size = new System.Drawing.Size(53, 22);
            this.btnNewDrugRegistrationTypes.Text = "New";
            this.btnNewDrugRegistrationTypes.ToolTipText = "Prepare the system to accept a new drug registration type record";
            this.btnNewDrugRegistrationTypes.Click += new System.EventHandler(this.btnNewDrugRegistrationTypes_Click);
            // 
            // btnSaveDrugRegistrationTypes
            // 
            this.btnSaveDrugRegistrationTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDrugRegistrationTypes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveDrugRegistrationTypes.Image = global::Pharma.Properties.Resources.save;
            this.btnSaveDrugRegistrationTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveDrugRegistrationTypes.Name = "btnSaveDrugRegistrationTypes";
            this.btnSaveDrugRegistrationTypes.Size = new System.Drawing.Size(56, 22);
            this.btnSaveDrugRegistrationTypes.Text = "Save";
            this.btnSaveDrugRegistrationTypes.ToolTipText = "Save the current drug registration type record (i.e. newly created or edited)";
            this.btnSaveDrugRegistrationTypes.Click += new System.EventHandler(this.btnSaveDrugRegistrationTypes_Click);
            // 
            // btnDeleteDrugRegistrationTypes
            // 
            this.btnDeleteDrugRegistrationTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDrugRegistrationTypes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteDrugRegistrationTypes.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeleteDrugRegistrationTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteDrugRegistrationTypes.Name = "btnDeleteDrugRegistrationTypes";
            this.btnDeleteDrugRegistrationTypes.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteDrugRegistrationTypes.Text = "Delete";
            this.btnDeleteDrugRegistrationTypes.ToolTipText = "Delete the currently selected drug registration type record";
            this.btnDeleteDrugRegistrationTypes.Click += new System.EventHandler(this.btnDeleteDrugRegistrationTypes_Click);
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
            this.btnClose.ToolTipText = "Close the Drug Registration Type Maintenance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDrugRegistrationTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(548, 491);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwDrugRegistrationTypes);
            this.Controls.Add(this.ssDrugRegistrationTypes);
            this.Controls.Add(this.grpDrugRegistrationTypesEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDrugRegistrationTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart ";
            this.Load += new System.EventHandler(this.frmDrugRegistrationTypes_Load);
            this.Activated += new System.EventHandler(this.frmDrugRegistrationTypes_Activated);
            this.grpDrugRegistrationTypesEntry.ResumeLayout(false);
            this.grpDrugRegistrationTypesEntry.PerformLayout();
            this.ssDrugRegistrationTypes.ResumeLayout(false);
            this.ssDrugRegistrationTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsDrugRegistrationTypes.ResumeLayout(false);
            this.tsDrugRegistrationTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion



        // Declare Controls
        // put this in the InitializeComponents Method

        // put these outside the InitializeComponents Method

        private System.Windows.Forms.StatusStrip ssDrugRegistrationTypes;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;

        private System.Windows.Forms.GroupBox grpDrugRegistrationTypesEntry;
        private System.Windows.Forms.ListView lvwDrugRegistrationTypes;

        private System.Windows.Forms.Label lblDrugRegistrationTypesName;
        private System.Windows.Forms.TextBox txtDrugRegistrationTypesName;

        private System.Windows.Forms.ColumnHeader colDrugRegistrationTypesId;
        private System.Windows.Forms.ColumnHeader colDrugRegistrationTypesName;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.ToolStrip tsDrugRegistrationTypes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewDrugRegistrationTypes;
        public System.Windows.Forms.ToolStripButton btnSaveDrugRegistrationTypes;
        public System.Windows.Forms.ToolStripButton btnDeleteDrugRegistrationTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;


    }
}
