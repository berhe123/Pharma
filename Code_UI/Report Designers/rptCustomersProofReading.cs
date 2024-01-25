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
    /// Summary description for rptCustomersProofReading.
    /// </summary>
    public partial class rptCustomersProofReading : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Customers Proof Reading Report";

        int intCount;

        #region Class Property Declarations

        string _Location;
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        string _LocationGuid;
        public string Locationguid
        {
            get { return _LocationGuid; }
            set { _LocationGuid = value; }
        }

        string _CustomerType;
        public string CustomerType
        {
            get { return _CustomerType; }
            set { _CustomerType = value; }
        }

        string _CustomerTypeGuid;
        public string Customertypeguid
        {
            get { return _CustomerTypeGuid; }
            set { _CustomerTypeGuid = value; }
        }

        decimal _DiscountRate;
        public decimal DiscountRate
        {
            get { return _DiscountRate; }
            set { _DiscountRate = value; }
        }

        decimal _CreditLimit;
        public decimal CreditLimit
        {
            get { return _CreditLimit; }
            set { _CreditLimit = value; }
        }
        #endregion

        public rptCustomersProofReading()
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
                this.lblCriteria.Text = "Discount Rate >= " + _DiscountRate.ToString(CSettings.CurrencyFormat)
                                    + "; Credit Limit >= " + _CreditLimit.ToString(CSettings.CurrencyFormat);
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
    }
}
