namespace Pharma
{
    partial class frmReportViewerInvoice
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
            this.arViewer = new DataDynamics.ActiveReports.Viewer.Viewer();
            this.btnExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arViewer
            // 
            this.arViewer.BackColor = System.Drawing.SystemColors.Control;
            this.arViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arViewer.Document = new DataDynamics.ActiveReports.Document.Document("ARNet Document");
            this.arViewer.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arViewer.Location = new System.Drawing.Point(0, 0);
            this.arViewer.Name = "arViewer";
            this.arViewer.ReportViewer.BackColor = System.Drawing.SystemColors.Control;
            this.arViewer.ReportViewer.CurrentPage = 0;
            this.arViewer.ReportViewer.MultiplePageCols = 3;
            this.arViewer.ReportViewer.MultiplePageRows = 2;
            this.arViewer.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal;
            this.arViewer.Size = new System.Drawing.Size(856, 507);
            this.arViewer.TabIndex = 4;
            this.arViewer.TableOfContents.Text = "Contents";
            this.arViewer.TableOfContents.Width = 200;
            this.arViewer.TabTitleLength = 35;
            this.arViewer.Toolbar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arViewer.Load += new System.EventHandler(this.arViewer_Load);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(768, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 24);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "E&xport";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmReportViewerInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 507);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.arViewer);
            this.Name = "frmReportViewerInvoice";
            this.ShowInTaskbar = false;
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public DataDynamics.ActiveReports.Viewer.Viewer arViewer;
        private System.Windows.Forms.Button btnExport;
    }
}