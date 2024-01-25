//
// ...
// Wizard generated code
// Date: 9/17/2009 5:12:54 PM
// Class: frmCustomerTypes
// ...
//
namespace Pharma
{
    partial class frmCustomerTypes
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


        #region Windows Form Designer generated code CustomerTypes


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCustomerTypesDescription = new System.Windows.Forms.Label();
            this.txtCustomerTypesDescription = new System.Windows.Forms.TextBox();
            this.ssCustomerTypes = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.mValidator = new System.Windows.Forms.ErrorProvider(this.components);
            this.colCustomerTypesId = new System.Windows.Forms.ColumnHeader();
            this.colCustomerTypesDescription = new System.Windows.Forms.ColumnHeader();
            this.lvwCustomerTypes = new System.Windows.Forms.ListView();
            this.line1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.line2 = new System.Windows.Forms.Panel();
            this.tsCustomerTypes = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnNewCustomerTypes = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCustomerTypes = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCustomerTypes = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.grpCustomerTypesEntry = new System.Windows.Forms.GroupBox();
            this.ssCustomerTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panel1.SuspendLayout();
            this.tsCustomerTypes.SuspendLayout();
            this.grpCustomerTypesEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerTypesDescription
            // 
            this.lblCustomerTypesDescription.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblCustomerTypesDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCustomerTypesDescription.Location = new System.Drawing.Point(9, 16);
            this.lblCustomerTypesDescription.Name = "lblCustomerTypesDescription";
            this.lblCustomerTypesDescription.Size = new System.Drawing.Size(107, 20);
            this.lblCustomerTypesDescription.TabIndex = 4;
            this.lblCustomerTypesDescription.Text = "Customer Type";
            this.lblCustomerTypesDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerTypesDescription
            // 
            this.txtCustomerTypesDescription.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerTypesDescription.Location = new System.Drawing.Point(9, 37);
            this.txtCustomerTypesDescription.Name = "txtCustomerTypesDescription";
            this.txtCustomerTypesDescription.Size = new System.Drawing.Size(421, 23);
            this.txtCustomerTypesDescription.TabIndex = 5;
            // 
            // ssCustomerTypes
            // 
            this.ssCustomerTypes.BackColor = System.Drawing.Color.Lavender;
            this.ssCustomerTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssCustomerTypes.Location = new System.Drawing.Point(0, 400);
            this.ssCustomerTypes.Name = "ssCustomerTypes";
            this.ssCustomerTypes.Size = new System.Drawing.Size(471, 22);
            this.ssCustomerTypes.TabIndex = 7;
            this.ssCustomerTypes.Text = "ssCustomerTypes";
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
            // colCustomerTypesId
            // 
            this.colCustomerTypesId.Text = "Id";
            this.colCustomerTypesId.Width = 0;
            // 
            // colCustomerTypesDescription
            // 
            this.colCustomerTypesDescription.Text = "Customer Type";
            this.colCustomerTypesDescription.Width = 430;
            // 
            // lvwCustomerTypes
            // 
            this.lvwCustomerTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCustomerTypesId,
            this.colCustomerTypesDescription});
            this.lvwCustomerTypes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwCustomerTypes.FullRowSelect = true;
            this.lvwCustomerTypes.GridLines = true;
            this.lvwCustomerTypes.Location = new System.Drawing.Point(6, 150);
            this.lvwCustomerTypes.MultiSelect = false;
            this.lvwCustomerTypes.Name = "lvwCustomerTypes";
            this.lvwCustomerTypes.Size = new System.Drawing.Size(458, 248);
            this.lvwCustomerTypes.TabIndex = 6;
            this.lvwCustomerTypes.UseCompatibleStateImageBehavior = false;
            this.lvwCustomerTypes.View = System.Windows.Forms.View.Details;
            this.lvwCustomerTypes.SelectedIndexChanged += new System.EventHandler(this.lvwCustomerTypes_SelectedIndexChanged);
            this.lvwCustomerTypes.DoubleClick += new System.EventHandler(this.lvwCustomerTypes_DoubleClick);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(-1, 37);
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
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(478, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "    Customer Type Maintenance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.line2);
            this.panel1.Controls.Add(this.tsCustomerTypes);
            this.panel1.Location = new System.Drawing.Point(-1, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 28);
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
            // tsCustomerTypes
            // 
            this.tsCustomerTypes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tsCustomerTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnNewCustomerTypes,
            this.btnSaveCustomerTypes,
            this.btnDeleteCustomerTypes,
            this.toolStripSeparator3,
            this.btnClose});
            this.tsCustomerTypes.Location = new System.Drawing.Point(0, 0);
            this.tsCustomerTypes.Name = "tsCustomerTypes";
            this.tsCustomerTypes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsCustomerTypes.Size = new System.Drawing.Size(478, 25);
            this.tsCustomerTypes.TabIndex = 2;
            this.tsCustomerTypes.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // btnNewCustomerTypes
            // 
            this.btnNewCustomerTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomerTypes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewCustomerTypes.Image = global::Pharma.Properties.Resources.New;
            this.btnNewCustomerTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewCustomerTypes.Name = "btnNewCustomerTypes";
            this.btnNewCustomerTypes.Size = new System.Drawing.Size(53, 22);
            this.btnNewCustomerTypes.Text = "New";
            this.btnNewCustomerTypes.ToolTipText = "Prepare the system to accept a new customer type record";
            this.btnNewCustomerTypes.Click += new System.EventHandler(this.btnNewCustomerTypes_Click);
            // 
            // btnSaveCustomerTypes
            // 
            this.btnSaveCustomerTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCustomerTypes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveCustomerTypes.Image = global::Pharma.Properties.Resources.save;
            this.btnSaveCustomerTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCustomerTypes.Name = "btnSaveCustomerTypes";
            this.btnSaveCustomerTypes.Size = new System.Drawing.Size(56, 22);
            this.btnSaveCustomerTypes.Text = "Save";
            this.btnSaveCustomerTypes.ToolTipText = "Save the current customer type record (i.e. newly created or edited)";
            this.btnSaveCustomerTypes.Click += new System.EventHandler(this.btnSaveCustomerTypes_Click);
            // 
            // btnDeleteCustomerTypes
            // 
            this.btnDeleteCustomerTypes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomerTypes.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDeleteCustomerTypes.Image = global::Pharma.Properties.Resources.delete;
            this.btnDeleteCustomerTypes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCustomerTypes.Name = "btnDeleteCustomerTypes";
            this.btnDeleteCustomerTypes.Size = new System.Drawing.Size(64, 22);
            this.btnDeleteCustomerTypes.Text = "Delete";
            this.btnDeleteCustomerTypes.ToolTipText = "Delete the currently selected customer type record";
            this.btnDeleteCustomerTypes.Click += new System.EventHandler(this.btnDeleteCustomerTypes_Click);
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
            this.btnClose.ToolTipText = "Close the Customer Type Maintenance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpCustomerTypesEntry
            // 
            this.grpCustomerTypesEntry.Controls.Add(this.txtCustomerTypesDescription);
            this.grpCustomerTypesEntry.Controls.Add(this.lblCustomerTypesDescription);
            this.grpCustomerTypesEntry.Location = new System.Drawing.Point(5, 72);
            this.grpCustomerTypesEntry.Name = "grpCustomerTypesEntry";
            this.grpCustomerTypesEntry.Size = new System.Drawing.Size(464, 73);
            this.grpCustomerTypesEntry.TabIndex = 3;
            this.grpCustomerTypesEntry.TabStop = false;
            // 
            // frmCustomerTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(471, 422);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpCustomerTypesEntry);
            this.Controls.Add(this.lvwCustomerTypes);
            this.Controls.Add(this.ssCustomerTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomerTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart ";
            this.Load += new System.EventHandler(this.frmCustomerTypes_Load);
            this.Activated += new System.EventHandler(this.frmCustomerTypes_Activated);
            this.ssCustomerTypes.ResumeLayout(false);
            this.ssCustomerTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsCustomerTypes.ResumeLayout(false);
            this.tsCustomerTypes.PerformLayout();
            this.grpCustomerTypesEntry.ResumeLayout(false);
            this.grpCustomerTypesEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion



        // Declare Controls
        // put this in the InitializeComponents Method

        // put these outside the InitializeComponents Method

        private System.Windows.Forms.StatusStrip ssCustomerTypes;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;

        private System.Windows.Forms.Label lblCustomerTypesDescription;
        private System.Windows.Forms.TextBox txtCustomerTypesDescription;
        private System.Windows.Forms.ListView lvwCustomerTypes;
        private System.Windows.Forms.ColumnHeader colCustomerTypesId;
        private System.Windows.Forms.ColumnHeader colCustomerTypesDescription;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel line2;
        private System.Windows.Forms.ToolStrip tsCustomerTypes;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnNewCustomerTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox grpCustomerTypesEntry;
        public System.Windows.Forms.ToolStripButton btnSaveCustomerTypes;
        public System.Windows.Forms.ToolStripButton btnDeleteCustomerTypes;


    }
}
