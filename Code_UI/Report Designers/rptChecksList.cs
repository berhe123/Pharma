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
    /// Summary description for rptChecksList.
    /// </summary>
    public partial class rptChecksList : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "List of Checks Report";

        int intCount;

        #region Class Property Declarations

        int _CheckStatus;
        public int CheckStatus
        {
            get { return _CheckStatus; }
            set { _CheckStatus = value; }
        }

        bool _FilterByCheckDate;
        public bool FilterByCheckDate
        {
            get { return _FilterByCheckDate; }
            set { _FilterByCheckDate = value; }
        }

        DateTime _CheckDateFrom;
        public DateTime CheckDateFrom
        {
            get { return _CheckDateFrom; }
            set { _CheckDateFrom = value; }
        }

        DateTime _CheckDateTo;
        public DateTime CheckDateTo
        {
            get { return _CheckDateTo; }
            set { _CheckDateTo = value; }
        }

        bool _FilterByMaturityDate;
        public bool FilterByMaturityDate
        {
            get { return _FilterByMaturityDate; }
            set { _FilterByMaturityDate = value; }
        }

        DateTime _MaturityDateFrom;
        public DateTime MaturityDateFrom
        {
            get { return _MaturityDateFrom; }
            set { _MaturityDateFrom = value; }
        }

        DateTime _MaturityDateTo;
        public DateTime MaturityDateTo
        {
            get { return _MaturityDateTo; }
            set { _MaturityDateTo = value; }
        }

        #endregion

        public rptChecksList()
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
                this.lblCriteria.Text = string.Empty;

                if (_CheckStatus != -1)
                    this.lblCriteria.Text += "Check Status: " + CCommon.GetCheckStatusText(_CheckStatus) + "; ";
                else
                    this.lblCriteria.Text += "Check Status: All; ";

                if (_FilterByCheckDate)
                {
                    this.lblCriteria.Text += "Check Date: From " + _CheckDateFrom.ToString(CSettings.DateFormat)
                                        + " To " + _CheckDateFrom.ToString(CSettings.DateFormat) + "; ";
                }

                if (_FilterByMaturityDate)
                {
                    this.lblCriteria.Text += "Maturity Date: From " + _MaturityDateFrom.ToString(CSettings.DateFormat)
                                        + " To " + _MaturityDateFrom.ToString(CSettings.DateFormat) + "; ";
                }
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

        private void groupHeader3_Format(object sender, EventArgs e)
        {

        }

        private void groupFooter3_Format(object sender, EventArgs e)
        {

        }

        private void groupHeader1_Format(object sender, EventArgs e)
        {

        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {

        }
    }
}
