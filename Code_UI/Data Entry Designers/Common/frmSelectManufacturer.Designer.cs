namespace Pharma
{
    partial class frmSelectManufacturer
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwManufacturers = new System.Windows.Forms.ListView();
            this.colGuid = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.Panel();
            this.line3 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Image = global::Pharma.Properties.Resources.nexts1;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(288, 482);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(84, 26);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "&Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Pharma.Properties.Resources.exit;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(386, 482);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 26);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "    Manufacturer Selection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwManufacturers
            // 
            this.lvwManufacturers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGuid,
            this.colName});
            this.lvwManufacturers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwManufacturers.FullRowSelect = true;
            this.lvwManufacturers.GridLines = true;
            this.lvwManufacturers.Location = new System.Drawing.Point(4, 97);
            this.lvwManufacturers.MultiSelect = false;
            this.lvwManufacturers.Name = "lvwManufacturers";
            this.lvwManufacturers.Size = new System.Drawing.Size(466, 366);
            this.lvwManufacturers.TabIndex = 6;
            this.lvwManufacturers.UseCompatibleStateImageBehavior = false;
            this.lvwManufacturers.View = System.Windows.Forms.View.Details;
            this.lvwManufacturers.SelectedIndexChanged += new System.EventHandler(this.lvwManufacturers_SelectedIndexChanged);
            this.lvwManufacturers.DoubleClick += new System.EventHandler(this.lvwManufacturers_DoubleClick);
            // 
            // colGuid
            // 
            this.colGuid.Text = "Guid";
            this.colGuid.Width = 0;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 380;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(4, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::Pharma.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(362, 16);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 24);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name Like...";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(120, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(240, 23);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line1.Location = new System.Drawing.Point(0, 37);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(488, 1);
            this.line1.TabIndex = 1;
            // 
            // line3
            // 
            this.line3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.line3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.line3.Location = new System.Drawing.Point(4, 476);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(466, 1);
            this.line3.TabIndex = 7;
            // 
            // frmSelectManufacturer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(475, 514);
            this.ControlBox = false;
            this.Controls.Add(this.line3);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvwManufacturers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectManufacturer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparepart System";
            this.Load += new System.EventHandler(this.frmSelectManufacturer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvwManufacturers;
        private System.Windows.Forms.ColumnHeader colGuid;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel line1;
        private System.Windows.Forms.Panel line3;
    }
}