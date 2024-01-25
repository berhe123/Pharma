namespace Pharma
{
    partial class frmSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.picSplash = new System.Windows.Forms.PictureBox();
            this.txtSplash = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(248, 214);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(0, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version 1.0.0.0";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCopyright
            // 
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Location = new System.Drawing.Point(248, 232);
            this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(0, 17);
            this.labelCopyright.TabIndex = 21;
            this.labelCopyright.Text = "Copyright (c) 2009";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.BackColor = System.Drawing.Color.Transparent;
            this.labelCompanyName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Location = new System.Drawing.Point(248, 250);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(0, 17);
            this.labelCompanyName.TabIndex = 22;
            this.labelCompanyName.Text = "Supreme IT Solutions";
            this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Pharma.Properties.Resources.supremelogoAA;
            this.logoPictureBox.Location = new System.Drawing.Point(494, 278);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(106, 54);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // picSplash
            // 
            this.picSplash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSplash.Image = global::Pharma.Properties.Resources.SparepaLogoLast ;
            this.picSplash.Location = new System.Drawing.Point(0, 0);
            this.picSplash.Name = "picSplash";
            this.picSplash.Size = new System.Drawing.Size(602, 250);
            this.picSplash.TabIndex = 23;
            this.picSplash.TabStop = false;
            this.picSplash.Click += new System.EventHandler(this.picSplash_Click);
            // 
            // txtSplash
            // 
            this.txtSplash.BackColor = System.Drawing.SystemColors.Window;
            this.txtSplash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSplash.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSplash.ForeColor = System.Drawing.Color.Red;
            this.txtSplash.Location = new System.Drawing.Point(0, 249);
            this.txtSplash.Name = "txtSplash";
            this.txtSplash.ReadOnly = true;
            this.txtSplash.Size = new System.Drawing.Size(602, 21);
            this.txtSplash.TabIndex = 24;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(602, 270);
            this.Controls.Add(this.txtSplash);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.picSplash);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSplash_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.PictureBox picSplash;
        private System.Windows.Forms.TextBox txtSplash;
    }
}
