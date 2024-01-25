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
    /// Summary description for rptInvoicesListByCustomer.
    /// </summary>
    public partial class rptInvoicesListByCustomer : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "List of Invoice by Customer Report";

        int intCount;

        #region Class Property Declarations

        int _InvoiceType;
        public int InvoiceType
        {
            get { return _InvoiceType; }
            set { _InvoiceType = value; }
        }

        bool _FilterByInvoiceDate;
        public bool FilterByInvoiceDate
        {
            get { return _FilterByInvoiceDate; }
            set { _FilterByInvoiceDate = value; }
        }

        DateTime _InvoiceDateFrom;
        public DateTime InvoiceDateFrom
        {
            get { return _InvoiceDateFrom; }
            set { _InvoiceDateFrom = value; }
        }

        DateTime _InvoiceDateTo;
        public DateTime InvoiceDateTo
        {
            get { return _InvoiceDateTo; }
            set { _InvoiceDateTo = value; }
        }

        #endregion

        public rptInvoicesListByCustomer()
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
                if (_InvoiceType != -1)
                    this.lblCriteria.Text += "Invoice Type: " + CCommon.GetInvoiceTypeText(Convert.ToInt32(_InvoiceType)) + "; ";
                else
                    this.lblCriteria.Text += "Invoice Type: All; ";

                if (_FilterByInvoiceDate)
                {
                    this.lblCriteria.Text += "Invoice Date: From " + _InvoiceDateFrom.ToString(CSettings.DateFormat)
                                        + " To " + _InvoiceDateTo.ToString(CSettings.DateFormat) + "; ";
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

        private void groupHeader1_Format(object sender, EventArgs e)
        {
            try
            {
                txtInvoiceType.Text = CCommon.GetInvoiceTypeText(Convert.ToInt32(txtInvoiceType.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
