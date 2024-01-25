using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Windows.Forms;

namespace Pharma.Code_UI.Report_Designers
{
    /// <summary>
    /// Summary description for rptSetteled.
    /// </summary>
    public partial class rptSetteled : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "List of Settled Details";
        int count = 0;
        public rptSetteled()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void detail_Format(object sender, EventArgs e)
        {
            count = count + 1;
            txtPrintDate.Text = count.ToString();
        }

        private void pageFooter_Format(object sender, EventArgs e)
        {
            try
            {
                this.textBox11.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
