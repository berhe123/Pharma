namespace Pharma
{
    partial class frmSelect
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
            this.lvwSelect = new System.Windows.Forms.ListView();
            this.colGuid = new System.Windows.Forms.ColumnHeader();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvwSelect
            // 
            this.lvwSelect.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colGuid,
            this.colName});
            this.lvwSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwSelect.FullRowSelect = true;
            this.lvwSelect.GridLines = true;
            this.lvwSelect.Location = new System.Drawing.Point(0, 0);
            this.lvwSelect.Name = "lvwSelect";
            this.lvwSelect.Size = new System.Drawing.Size(332, 326);
            this.lvwSelect.TabIndex = 0;
            this.lvwSelect.UseCompatibleStateImageBehavior = false;
            this.lvwSelect.View = System.Windows.Forms.View.Details;
            // 
            // colGuid
            // 
            this.colGuid.Text = "Guid";
            this.colGuid.Width = 0;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 300;
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 328);
            this.Controls.Add(this.lvwSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSelect";
            this.Text = "frmSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwSelect;
        private System.Windows.Forms.ColumnHeader colGuid;
        private System.Windows.Forms.ColumnHeader colName;
    }
}