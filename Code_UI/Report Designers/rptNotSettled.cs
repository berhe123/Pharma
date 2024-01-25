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
    /// Summary description for rptNotSettle.
    /// </summary>
    public partial class rptNotSettled : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "List of Unsettled Details";
        int count = 0;

        public rptNotSettled()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void detail_Format(object sender, EventArgs e)
        {
            count = count + 1;
            textBox9.Text = count.ToString();
        }

        private void pageFooter_Format(object sender, EventArgs e)
        {
            try
            {
                this.textBox12.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
