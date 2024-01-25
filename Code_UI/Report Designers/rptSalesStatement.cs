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
    /// Summary description for rptSalesStatement.
    /// </summary>
    public partial class rptSalesStatement : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Sales Statement Report";

        int intCount;

        #region Class Property Declarations
        DateTime _DateFrom;
        public DateTime DateFrom
        {
            get { return _DateFrom; }
            set { _DateFrom = value; }
        }

        DateTime _DateTo;
        public DateTime DateTo
        {
            get { return _DateTo; }
            set { _DateTo = value; }
        }
        #endregion

        public rptSalesStatement()
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
                //txtItem.Text = txtItem.Text + " " + txtMeasurement.Text + " " + CCommon.GetDosageFormText(Convert.ToInt32(txtDosageForm.Value));
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
                if (_DateFrom == DateTime.MinValue && _DateTo == DateTime.MaxValue)
                    this.lblCriteria.Text = "For the Period: No Limit";
                else if (_DateFrom == DateTime.MinValue && _DateTo != DateTime.MaxValue)
                    this.lblCriteria.Text = "For the Period: Upto " + _DateTo.ToString(CSettings.DateFormat);
                else if (_DateFrom != DateTime.MinValue && _DateTo == DateTime.MaxValue)
                    this.lblCriteria.Text = "For the Period: Starting From " + _DateFrom.ToString(CSettings.DateFormat);
                else if (_DateFrom != DateTime.MinValue && _DateTo != DateTime.MaxValue)
                    this.lblCriteria.Text = "For the Period: From " + _DateFrom.ToString(CSettings.DateFormat)
                                                    + " To " + _DateTo.ToString(CSettings.DateFormat);
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
                txtAddress.Text = CSettings.OrganizationAddress +
                                    " P.O.Box: " + CSettings.OrganizationPOBox + ";" +
                                    "\n Tel: " + CSettings.OrganizationTelephone + ";" +
                                    " Fax: " + CSettings.OrganizationFax + ";";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
