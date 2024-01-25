namespace Pharma.Code_UI.Data_Entry_Designers.Lookup_Maintenance
{
    partial class frmImages
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImages));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dlgOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.imageSettings = new System.Windows.Forms.ImageList(this.components);
            this.tsPhoto = new System.Windows.Forms.ToolStrip();
            this.btnImportLogo = new System.Windows.Forms.ToolStripButton();
            this.btnPasteLogo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefreshLogo = new System.Windows.Forms.ToolStripButton();
            this.btnClearLogo = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tsPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(82, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(176, 319);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(87, 23);
            this.Save.TabIndex = 126;
            this.Save.Text = "Ok";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(290, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 23);
            this.button5.TabIndex = 127;
            this.button5.Text = "Close";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(64, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 36);
            this.label3.TabIndex = 128;
            this.label3.Text = "Image Maintainance";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // imageSettings
            // 
            this.imageSettings.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSettings.ImageStream")));
            this.imageSettings.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSettings.Images.SetKeyName(0, "View Details.bmp.gif");
            // 
            // tsPhoto
            // 
            this.tsPhoto.AllowItemReorder = true;
            this.tsPhoto.AutoSize = false;
            this.tsPhoto.BackColor = System.Drawing.Color.GhostWhite;
            this.tsPhoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsPhoto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportLogo,
            this.btnPasteLogo,
            this.toolStripSeparator1,
            this.btnRefreshLogo,
            this.btnClearLogo});
            this.tsPhoto.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsPhoto.Location = new System.Drawing.Point(0, 0);
            this.tsPhoto.Name = "tsPhoto";
            this.tsPhoto.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsPhoto.Size = new System.Drawing.Size(61, 358);
            this.tsPhoto.TabIndex = 129;
            this.tsPhoto.Text = "toolStrip2";
            // 
            // btnImportLogo
            // 
            this.btnImportLogo.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnImportLogo.Image")));
            this.btnImportLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportLogo.Name = "btnImportLogo";
            this.btnImportLogo.Size = new System.Drawing.Size(59, 20);
            this.btnImportLogo.Text = "Open";
            this.btnImportLogo.Click += new System.EventHandler(this.btnImportLogo_Click);
            // 
            // btnPasteLogo
            // 
            this.btnPasteLogo.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasteLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnPasteLogo.Image")));
            this.btnPasteLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPasteLogo.Name = "btnPasteLogo";
            this.btnPasteLogo.Size = new System.Drawing.Size(59, 20);
            this.btnPasteLogo.Text = "Paste";
            this.btnPasteLogo.Click += new System.EventHandler(this.btnPasteLogo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(59, 6);
            // 
            // btnRefreshLogo
            // 
            this.btnRefreshLogo.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshLogo.Image")));
            this.btnRefreshLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshLogo.Name = "btnRefreshLogo";
            this.btnRefreshLogo.Size = new System.Drawing.Size(59, 20);
            this.btnRefreshLogo.Text = "Refresh";
            this.btnRefreshLogo.Click += new System.EventHandler(this.btnRefreshLogo_Click);
            // 
            // btnClearLogo
            // 
            this.btnClearLogo.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLogo.Image = global::Pharma.Properties.Resources.delete;
            this.btnClearLogo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearLogo.Name = "btnClearLogo";
            this.btnClearLogo.Size = new System.Drawing.Size(59, 20);
            this.btnClearLogo.Text = "Clear";
            this.btnClearLogo.Click += new System.EventHandler(this.btnClearLogo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(82, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 130;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(402, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 131;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(402, 54);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(122, 106);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 132;
            this.pictureBox4.TabStop = false;
            // 
            // frmImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 358);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tsPhoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmImages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Lookup";
            this.Load += new System.EventHandler(this.frmImages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tsPhoto.ResumeLayout(false);
            this.tsPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog dlgOpenFileDialog;
        private System.Windows.Forms.ImageList imageSettings;
        private System.Windows.Forms.ToolStrip tsPhoto;
        private System.Windows.Forms.ToolStripButton btnImportLogo;
        private System.Windows.Forms.ToolStripButton btnPasteLogo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnRefreshLogo;
        private System.Windows.Forms.ToolStripButton btnClearLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}