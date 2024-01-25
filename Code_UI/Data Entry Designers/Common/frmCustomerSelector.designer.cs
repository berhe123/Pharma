namespace Pharma
{
    partial class frmCustomerSelector
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
            this.lvwCustomer = new System.Windows.Forms.ListView();
            this.colGuid = new System.Windows.Forms.ColumnHeader();
            this.colOrgnaizationName = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwCustomer
            // 
            this.lvwCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGuid,
            this.colOrgnaizationName});
            this.lvwCustomer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwCustomer.FullRowSelect = true;
            this.lvwCustomer.GridLines = true;
            this.lvwCustomer.Location = new System.Drawing.Point(0, 0);
            this.lvwCustomer.Name = "lvwCustomer";
            this.lvwCustomer.Size = new System.Drawing.Size(275, 315);
            this.lvwCustomer.TabIndex = 0;
            this.lvwCustomer.UseCompatibleStateImageBehavior = false;
            this.lvwCustomer.View = System.Windows.Forms.View.Details;
            this.lvwCustomer.DoubleClick += new System.EventHandler(this.lvwCustomer_DoubleClick);
            this.lvwCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvwCustomer_KeyPress);
            // 
            // colGuid
            // 
            this.colGuid.Text = "Guid";
            this.colGuid.Width = 0;
            // 
            // colOrgnaizationName
            // 
            this.colOrgnaizationName.Text = "Organization Name";
            this.colOrgnaizationName.Width = 270;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(2, 319);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 24);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(79, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCustomerSelector
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(275, 348);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvwCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomerSelector";
            this.ShowInTaskbar = false;
            this.Text = "frmCustomerSelector";
            this.Load += new System.EventHandler(this.frmCustomerSelector_Load);
            this.Activated += new System.EventHandler(this.frmCustomerSelector_Activated);
            this.Resize += new System.EventHandler(this.frmCustomerSelector_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colGuid;
        private System.Windows.Forms.ColumnHeader colOrgnaizationName;
        public System.Windows.Forms.ListView lvwCustomer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}