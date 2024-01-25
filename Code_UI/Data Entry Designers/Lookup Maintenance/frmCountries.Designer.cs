
//
// ...
// Wizard generated code
// Date: 7/29/2009 12:25:08 PM
// Class: frmCountries
// ...
//
namespace Pharma
{
    partial class frmCountries
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


        #region Windows Form Designer generated code Countries


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpCountriesEntry = new System.Windows.Forms.GroupBox();
            this.lblCountriesCode = new System.Windows.Forms.Label();
            this.txtCountriesCode = new System.Windows.Forms.TextBox();
            this.lblCountriesShortname = new System.Windows.Forms.Label();
            this.txtCountriesShortname = new System.Windows.Forms.TextBox();
            this.lblCountriesName = new System.Windows.Forms.Label();
            this.txtCountriesName = new System.Windows.Forms.TextBox();
            this.ssCountries = new System.Windows.Forms.StatusStrip();
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
            this.lvwCountries = new System.Windows.Forms.ListView();
            this.colCountriesId = new System.Windows.Forms.ColumnHeader();
            this.colCountriesCode = new System.Windows.Forms.ColumnHeader();
            this.colCountriesShortname = new System.Windows.Forms.ColumnHeader();
            this.colCountriesName = new System.Windows.Forms.ColumnHeader();
            this.line3 = new System.Windows.Forms.Panel();
            this.grpCountriesEntry.SuspendLayout();
            this.ssCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mValidator)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCountriesEntry
            // 
            this.grpCountriesEntry.Controls.Add(this.lblCountriesCode);
            this.grpCountriesEntry.Controls.Add(this.txtCountriesCode);
            this.grpCountriesEntry.Controls.Add(this.lblCountriesShortname);
            this.grpCountriesEntry.Controls.Add(this.txtCountriesShortname);
            this.grpCountriesEntry.Controls.Add(this.lblCountriesName);
            this.grpCountriesEntry.Controls.Add(this.txtCountriesName);
            this.grpCountriesEntry.Location = new System.Drawing.Point(6, 71);
            this.grpCountriesEntry.Name = "grpCountriesEntry";
            this.grpCountriesEntry.Size = new System.Drawing.Size(526, 115);
            this.grpCountriesEntry.TabIndex = 4;
            this.grpCountriesEntry.TabStop = false;
            // 
            // lblCountriesCode
            // 
            this.lblCountriesCode.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblCountriesCode.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCountriesCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCountriesCode.Location = new System.Drawing.Point(22, 17);
            this.lblCountriesCode.Name = "lblCountriesCode";
            this.lblCountriesCode.Size = new System.Drawing.Size(107, 16);
            this.lblCountriesCode.TabIndex = 5;
            this.lblCountriesCode.Text = "Country Code";
            this.lblCountriesCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCountriesCode
            // 
            this.txtCountriesCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountriesCode.Location = new System.Drawing.Point(22, 33);
            this.txtCountriesCode.Name = "txtCountriesCode";
            this.txtCountriesCode.Size = new System.Drawing.Size(107, 23);
            this.txtCountriesCode.TabIndex = 6;
            // 
            // lblCountriesShortname
            // 
            this.lblCountriesShortname.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblCountriesShortname.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCountriesShortname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCountriesShortname.Location = new System.Drawing.Point(174, 17);
            this.lblCountriesShortname.Name = "lblCountriesShortname";
            this.lblCountriesShortname.Size = new System.Drawing.Size(107, 16);
            this.lblCountriesShortname.TabIndex = 7;
            this.lblCountriesShortname.Text = "Short Text";
            this.lblCountriesShortname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCountriesShortname
            // 
            this.txtCountriesShortname.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountriesShortname.Location = new System.Drawing.Point(174, 33);
            this.txtCountriesShortname.Name = "txtCountriesShortname";
            this.txtCountriesShortname.Size = new System.Drawing.Size(107, 23);
            this.txtCountriesShortname.TabIndex = 8;
            // 
            // lblCountriesName
            // 
            this.lblCountriesName.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblCountriesName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCountriesName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCountriesName.Location = new System.Drawing.Point(22, 66);
            this.lblCountriesName.Name = "lblCountriesName";
            this.lblCountriesName.Size = new System.Drawing.Size(107, 16);
            this.lblCountriesName.TabIndex = 9;
            this.lblCountriesName.Text = "Country Name";
            this.lblCountriesName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCountriesName
            // 
            this.txtCountriesName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountriesName.Location = new System.Drawing.Point(22, 82);
            this.txtCountriesName.Name = "txtCountriesName";
            this.txtCountriesName.Size = new System.Drawing.Size(416, 23);
            this.txtCountriesName.TabIndex = 10;
            // 
            // ssCountries
            // 
            this.ssCountries.BackColor = System.Drawing.Color.Lavender;
            this.ssCountries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.ssCountries.Location = new System.Drawing.Point(0, 489);
            this.ssCountries.Name = "ssCountries";
            this.ssCountries.Size = new System.Drawing.Size(540, 22);
            this.ssCountries.TabIndex = 12;
            this.ssCountries.Text = "ssCountries";
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
            this.label3.Text = "    Country Maintenance";
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
            this.panel1.TabIndex = 2;
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
            this.btnNewCountries.ToolTipText = "Prepare the system to accept a new country record";
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
            this.btnSaveCountries.ToolTipText = "Save the current country record (i.e. newly created or edited)";
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
            this.btnDeleteCountries.ToolTipText = "Delete the currently selected country record";
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
            this.btnClose.ToolTipText = "Close the Country Maintenance dialog";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lvwCountries
            // 
            this.lvwCountries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCountriesId,
            this.colCountriesCode,
            this.colCountriesShortname,
            this.colCountriesName});
            this.lvwCountries.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwCountries.FullRowSelect = true;
            this.lvwCountries.GridLines = true;
            this.lvwCountries.Location = new System.Drawing.Point(8, 192);
            this.lvwCountries.MultiSelect = false;
            this.lvwCountries.Name = "lvwCountries";
            this.lvwCountries.Size = new System.Drawing.Size(520, 292);
            this.lvwCountries.TabIndex = 11;
            this.lvwCountries.UseCompatibleStateImageBehavior = false;
            this.lvwCountries.View = System.Windows.Forms.View.Details;
            this.lvwCountries.SelectedIndexChanged += new System.EventHandler(this.lvwCountries_SelectedIndexChanged);
            this.lvwCountries.DoubleClick += new System.EventHandler(this.lvwCountries_DoubleClick);
            // 
            // colCountriesId
            // 
            this.colCountriesId.Text = "Id";
            this.colCountriesId.Width = 0;
            // 
            // colCountriesCode
            // 
            this.colCountriesCode.Text = "Country Code";
            this.colCountriesCode.Width = 90;
            // 
            // colCountriesShortname
            // 
            this.colCountriesShortname.Text = "Short Text";
            this.colCountriesShortname.Width = 90;
            // 
            // colCountriesName
            // 
            this.colCountriesName.Text = "Country Name";
            this.colCountriesName.Width = 310;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(-6, 489);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(558, 1);
            this.line3.TabIndex = 115;
            // 
            // frmCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(540, 511);
            this.Controls.Add(this.line3);
            this.Controls.Add(this.lvwCountries);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ssCountries);
            this.Controls.Add(this.grpCountriesEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCountries";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart";
            this.Load += new System.EventHandler(this.frmCountries_Load);
            this.Activated += new System.EventHandler(this.frmCountries_Activated);
            this.grpCountriesEntry.ResumeLayout(false);
            this.grpCountriesEntry.PerformLayout();
            this.ssCountries.ResumeLayout(false);
            this.ssCountries.PerformLayout();
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

        private System.Windows.Forms.StatusStrip ssCountries;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.ErrorProvider mValidator;

        private System.Windows.Forms.GroupBox grpCountriesEntry;

        private System.Windows.Forms.Label lblCountriesCode;
        private System.Windows.Forms.TextBox txtCountriesCode;
        private System.Windows.Forms.Label lblCountriesShortname;
        private System.Windows.Forms.TextBox txtCountriesShortname;
        private System.Windows.Forms.Label lblCountriesName;
        private System.Windows.Forms.TextBox txtCountriesName;
        private System.Windows.Forms.ListView lvwCountries;
        private System.Windows.Forms.ColumnHeader colCountriesId;
        private System.Windows.Forms.ColumnHeader colCountriesCode;
        private System.Windows.Forms.ColumnHeader colCountriesShortname;
        private System.Windows.Forms.ColumnHeader colCountriesName;
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
        public System.Windows.Forms.ToolStripButton btnSaveCountries;
        public System.Windows.Forms.ToolStripButton btnDeleteCountries;


    }
}
