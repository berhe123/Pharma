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
    /// Summary description for rptInvoiceListByDeliveryPerson.
    /// </summary>
    public partial class rptInvoiceListByDeliveryPerson : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "List Invoices By Delivery Person Report";

        int intCount;

        #region Class Property Declarations

        string _Customer;
        public string Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        }

        string _CustomerGuid;
        public string Customerguid
        {
            get { return _CustomerGuid; }
            set { _CustomerGuid = value; }
        }

        int _SettlementStatus;
        public int SettlementStatus
        {
            get { return _SettlementStatus; }
            set { _SettlementStatus = value; }
        }

        bool _FilterByRequestDate;
        public bool FilterByRequestDate
        {
            get { return _FilterByRequestDate; }
            set { _FilterByRequestDate = value; }
        }

        DateTime _RequestDateFrom;
        public DateTime RequestDateFrom
        {
            get { return _RequestDateFrom; }
            set { _RequestDateFrom = value; }
        }

        DateTime _RequestDateTo;
        public DateTime RequestDateTo
        {
            get { return _RequestDateTo; }
            set { _RequestDateTo = value; }
        }

        #endregion

        public rptInvoiceListByDeliveryPerson()
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

                if (_SettlementStatus != -1)
                    this.lblCriteria.Text += "Settlement Status: " + CCommon.GetPaymentSettlementText(_SettlementStatus) + "; ";
                else
                    this.lblCriteria.Text += "Settlement Status: All; ";

                if (_FilterByRequestDate)
                {
                    this.lblCriteria.Text += "Invoice Date: From " + _RequestDateFrom.ToString(CSettings.DateFormat)
                                        + " To " + _RequestDateTo.ToString(CSettings.DateFormat) + "; ";
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
    }
}
