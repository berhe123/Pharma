using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Windows.Forms;

namespace Pharma
{
    /// <summary>
    /// Summary description for rptReceivingList.
    /// </summary>
    public partial class rptReceivingList : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "List of Checks Report";

        int intCount;

        #region Class Property Declarations

        DateTime _ReceivedDateFrom;
        public DateTime ReceivedDateFrom
        {
            get { return _ReceivedDateFrom; }
            set { _ReceivedDateFrom = value; }
        }

        DateTime _ReceivedDateTo;
        public DateTime ReceivedDateTo
        {
            get { return _ReceivedDateTo; }
            set { _ReceivedDateTo = value; }
        }

        #endregion

        public rptReceivingList()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void detail_Format(object sender, EventArgs e)
        {
            try
            {
                intCount = intCount + 1;
                txtSerialNumber.Text = intCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pageFooter_Format(object sender, EventArgs e)
        {
            try
            {
                this.txtPrintDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            try
            {
                this.lblCriteria.Text = "Received Date: From " + _ReceivedDateFrom.ToString(CSettings.DateFormat)
                                    + " To " + _ReceivedDateTo.ToString(CSettings.DateFormat) + "; ";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptSalesStatement_ReportStart(object sender, EventArgs e)
        {
            try
            {
                if (CSettings.OrganizationLogo != null)
                    this.picLogo.Image = CPicture.ByteArrayToPicture(CSettings.OrganizationLogo);
                lblOrganization.Text = CSettings.OrganizationName;
                txtTel.Text = CSettings.OrganizationTelephone;
                txtPOBox.Text = CSettings.OrganizationPOBox;
                txtFax.Text = CSettings.OrganizationFax;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupHeader1_Format(object sender, EventArgs e)
        {

        }
    }
}
