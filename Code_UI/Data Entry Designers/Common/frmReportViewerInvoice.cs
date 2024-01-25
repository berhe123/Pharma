using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataDynamics.ActiveReports.Document;

namespace Pharma
{
    public partial class frmReportViewerInvoice : Form
    {
        private const string DialogCaption = "Report Viewer";

        public frmReportViewerInvoice()
        {
            InitializeComponent();
        }

        public frmReportViewerInvoice(DataDynamics.ActiveReports.Document.Document document)
        {
            InitializeComponent();
            this.arViewer.Document = document;
        }

        private void arViewer_Load(object sender, EventArgs e)
        {
            WriteText();
        }

        //private void WriteText()
        //{
        //    int currentPage = 0;
        //    int divPages = this.arViewer.Document.Pages.Count / 3;

        //    System.Drawing.Font f = new System.Drawing.Font("Bradly Hand Itc", 72);
        //    foreach (DataDynamics.ActiveReports.Document.Page page in this.arViewer.Document.Pages)
        //    {
        //        page.ForeColor = System.Drawing.Color.YellowGreen;
        //        page.Font = f;
        //        page.TextAlignment = DataDynamics.ActiveReports.TextAlignment.Center;
        //        page.TextAngle = -450;
        //        page.VerticalTextAlignment = DataDynamics.ActiveReports.VerticalTextAlignment.Middle;

        //        currentPage += 1;
        //        if (currentPage <= divPages * 1)
        //            page.DrawText("ORIGINAL", 1, 0, 6.5f, 9);           
        //        else if (currentPage <= divPages * 2)
        //            page.DrawText("COPY 1", 1, 0, 6.5f, 9);
        //        else if (currentPage <= divPages * 3)
        //            page.DrawText("COPY 2", 1, 0, 6.5f, 9);
                

        //    }
        //}
        private void WriteText()
        {
            try
            {
                System.Drawing.Font f = new System.Drawing.Font("Tahoma", 7.5f);
                foreach (DataDynamics.ActiveReports.Document.Page page in this.arViewer.Document.Pages)
                {
                    page.ForeColor = System.Drawing.Color.Red;
                    page.Font = f;
                    page.TextAngle = -900;
                    page.VerticalTextAlignment = DataDynamics.ActiveReports.VerticalTextAlignment.Middle;

                    page.TextAlignment = DataDynamics.ActiveReports.TextAlignment.Left;
                    page.DrawText("System Designed and Developed by Supreme IT Solutions Tel 0111 11 77 07/33", 0.3f, 0, 6.5f, 9);

                    //page.TextAlignment = DataDynamics.ActiveReports.TextAlignment.Right;
                    //page.DrawText("Distribution: Original to Customer;  Copy 1 to Store;  Copy 2 to Finance;", 4.7f, 0, 6.5f, 9);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.ExportDocument();
        }
        /// <summary>
        /// Opens the export form to export out the current report document
        /// </summary>
        private void ExportDocument()
        {
            ExportForm _exportForm = new ExportForm(arViewer.Document);
            _exportForm.ShowDialog(this);
        }

    }
}
