//
// ...
// Wizard generated code
// Date: 10/21/2009 3:52:20 PM
// Class: frmDosageForms
// ...
//
namespace Pharma
{
    partial class frmDosageForms
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


        #region Windows Form Designer generated code DosageForms


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ssDosageForms = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.tsDosageForms = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewDosageForms = new System.Windows.Forms.ToolStripButton();
            this.btnSaveDosageForms = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteDosageForms = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.grpDosageFormsEntry = new System.Windows.Forms.GroupBox();
            this.txtDosageFormsName = new System.Windows.Forms.TextBox();
            this.lblDosageFormsName = new System.Windows.Forms.Label();
            this.lvwDosageForms = new System.Windows.Forms.ListView();
            this.colDosageFormsId = new System.Windows.Forms.ColumnHeader();
            this.colDosageFormsName = new System.Windows.Forms.ColumnHeader();
            this.ssDosageForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panel1.SuspendLayout();
            this.tsDosageForms.SuspendLayout();
            this.grpDosageFormsEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssDosageForms
            // 
            this.ssDosageForms.BackColor = System.Drawing.Color.Lavender;
            this.ssDosageForms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssDosageForms.Location = new System.Drawing.Point(0, 403);
            this.ssDosageForms.Name = "ssDosageForms";
            this.ssDosageForms.Size = new System.Drawing.Size(472, 22);
            this.ssDosageForms.TabIndex = 7;
            this.ssDosageForms.Text = "ssDosageForms";
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
            this.line1.Size = new System.Drawing.Size(478, 1);
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
            this.label3.Size = new System.Drawing.Size(478, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "   Dosage Form Maintenance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.tsDosageForms);
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 28);
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
            // tsDosageForms
            // 
            this.tsDosageForms.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsDosageForms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnNewDosageForms,
            this.btnSaveDosageForms,
            this.btnDeleteDosageForms,
            this.toolStripSeparator3,
            this.btnClose});
            this.tsDosageForms.Location = new System.Drawing.Point(0, 0);
            this.tsDosageForms.Name = "tsDosageForms";
            this.tsDosageForms.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsDosageForms.Size = new System.Drawing.Size(478, 25);
            this.tsDosageForms.TabIndex = 2;
            this.tsDosageForms.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewDosageForms
            // 
            this.btnNewDosageForms.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDosageForms.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewDosageForms.Image = global::Pharma.Properties.Resources.New;
            this.btnNewDosageForms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewDosageForms.Name = "btnNewDosageForms";
            this.btnNewDosageForms.Size = new System.Drawing.Size(53, 22);
            this.btnNewDosageForms.Text = "New";
            this.btnNewDosageForms.ToolTipText = "Prepare the system to accept a new dosage form record";
            this.btnNewDosageForms.Click += new System.EventHandler(this.btnNewDosageForms_Click);
            // 
            // btnSaveDosageForms
            // 
            this.btnSaveDosageForms.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDosageForms.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveDosageForms.Image = global::Pharma.Properties.Resources.save;
            this.btnSaveDosageForms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveDosageForms.Name = "btnSaveDosageForms";
            this.btnSaveDosageForms.Size = new System.Drawing.Size(56, 22);
            this.btnSaveDosageForms.Text = "Save";
            this.btnSaveDosageForms.ToolTipText = "Save the current dosage form record (i.e. newly created or edited)";
            this.btnSaveDosageForms.Click += new System.EventHandler(this.btnSaveDosageForms_Click);
            // 
            // btnDeleteDosageForms
            // 
            this.btnDeleteDosageForms.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDosageForms.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteDosageForms.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeleteDosageForms.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteDosageForms.Name = "btnDeleteDosageForms";
            this.btnDeleteDosageForms.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteDosageForms.Text = "Delete";
            this.btnDeleteDosageForms.ToolTipText = "Delete the currently selected dosage form record";
            this.btnDeleteDosageForms.Click += new System.EventHandler(this.btnDeleteDosageForms_Click);
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
            this.btnClose.ToolTipText = "Close the Dosage Form Maintenance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpDosageFormsEntry
            // 
            this.grpDosageFormsEntry.Controls.Add(this.txtDosageFormsName);
            this.grpDosageFormsEntry.Controls.Add(this.lblDosageFormsName);
            this.grpDosageFormsEntry.Location = new System.Drawing.Point(5, 72);
            this.grpDosageFormsEntry.Name = "grpDosageFormsEntry";
            this.grpDosageFormsEntry.Size = new System.Drawing.Size(464, 73);
            this.grpDosageFormsEntry.TabIndex = 3;
            this.grpDosageFormsEntry.TabStop = false;
            // 
            // txtDosageFormsName
            // 
            this.txtDosageFormsName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosageFormsName.Location = new System.Drawing.Point(9, 37);
            this.txtDosageFormsName.Name = "txtDosageFormsName";
            this.txtDosageFormsName.Size = new System.Drawing.Size(421, 23);
            this.txtDosageFormsName.TabIndex = 5;
            // 
            // lblDosageFormsName
            // 
            this.lblDosageFormsName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblDosageFormsName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDosageFormsName.Location = new System.Drawing.Point(9, 16);
            this.lblDosageFormsName.Name = "lblDosageFormsName";
            this.lblDosageFormsName.Size = new System.Drawing.Size(107, 20);
            this.lblDosageFormsName.TabIndex = 4;
            this.lblDosageFormsName.Text = "Dosage Form";
            this.lblDosageFormsName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwDosageForms
            // 
            this.lvwDosageForms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDosageFormsId,
            this.colDosageFormsName});
            this.lvwDosageForms.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDosageForms.FullRowSelect = true;
            this.lvwDosageForms.GridLines = true;
            this.lvwDosageForms.Location = new System.Drawing.Point(6, 150);
            this.lvwDosageForms.MultiSelect = false;
            this.lvwDosageForms.Name = "lvwDosageForms";
            this.lvwDosageForms.Size = new System.Drawing.Size(458, 248);
            this.lvwDosageForms.TabIndex = 6;
            this.lvwDosageForms.UseCompatibleStateImageBehavior = false;
            this.lvwDosageForms.View = System.Windows.Forms.View.Details;
            this.lvwDosageForms.SelectedIndexChanged += new System.EventHandler(this.lvwDosageForms_SelectedIndexChanged);
            // 
            // colDosageFormsId
            // 
            this.colDosageFormsId.Text = "Id";
            this.colDosageFormsId.Width = 0;
            // 
            // colDosageFormsName
            // 
            this.colDosageFormsName.Text = "Dosage Form";
            this.colDosageFormsName.Width = 430;
            // 
            // frmDosageForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(472, 425);
            this.Controls.Add(this.lvwDosageForms);
            this.Controls.Add(this.grpDosageFormsEntry);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssDosageForms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDosageForms";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart ";
            this.Load += new System.EventHandler(this.frmDosageForms_Load);
            this.Activated += new System.EventHandler(this.frmDosageForms_Activated);
            this.ssDosageForms.ResumeLayout(false);
            this.ssDosageForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsDosageForms.ResumeLayout(false);
            this.tsDosageForms.PerformLayout();
            this.grpDosageFormsEntry.ResumeLayout(false);
            this.grpDosageFormsEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion



        // Declare Controls
        // put this in the InitializeComponents Method

        // put these outside the InitializeComponents Method

        private System.Windows.Forms.StatusStrip ssDosageForms;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.ToolStrip tsDosageForms;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewDosageForms;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox grpDosageFormsEntry;
        private System.Windows.Forms.TextBox txtDosageFormsName;
        private System.Windows.Forms.Label lblDosageFormsName;
        private System.Windows.Forms.ListView lvwDosageForms;
        private System.Windows.Forms.ColumnHeader colDosageFormsId;
        private System.Windows.Forms.ColumnHeader colDosageFormsName;
        public System.Windows.Forms.ToolStripButton btnSaveDosageForms;
        public System.Windows.Forms.ToolStripButton btnDeleteDosageForms;


    }
}
