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
    /// Summary description for rptInvoicesList.
    /// </summary>
    public partial class rptInvoicesList : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "List of Invoice Report";

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

        int _DeliveryStatus;
        public int DeliveryStatus
        {
            get { return _DeliveryStatus; }
            set { _DeliveryStatus = value; }
        }

        bool _FilterByDeliveryDate;
        public bool FilterByDeliveryDate
        {
            get { return _FilterByDeliveryDate; }
            set { _FilterByDeliveryDate = value; }
        }

        DateTime _DeliveryDateFrom;
        public DateTime DeliveryDateFrom
        {
            get { return _DeliveryDateFrom; }
            set { _DeliveryDateFrom = value; }
        }

        DateTime _DeliveryDateTo;
        public DateTime DeliveryDateTo
        {
            get { return _DeliveryDateTo; }
            set { _DeliveryDateTo = value; }
        }

        #endregion

        public rptInvoicesList()
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
                txtInvoiceType.Text = CCommon.GetInvoiceTypeText(Convert.ToInt32(txtInvoiceType.Value));
                //txtDeliveryStatus.Text = CCommon.GetDeliveryStatusText(Convert.ToInt32(txtDeliveryStatus.Value));
                //if (txtSettled.Text != "")
                //{
                //    if (Convert.ToInt32(txtSettled.Text) == 0)
                //        txtSettled.Text = "Not Setteld";
                //    else
                //        txtSettled.Text = "Setteld";
                //}
                //else
                //    txtSettled.Text = "Not Setteld";
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

                if (_DeliveryStatus != -1)
                    this.lblCriteria.Text += "Delivery Status: " + CCommon.GetDeliveryStatusText(Convert.ToInt32(_DeliveryStatus)) + "; ";
                else
                    this.lblCriteria.Text += "Delivery Status: All; ";

                if (_FilterByDeliveryDate)
                {
                    this.lblCriteria.Text += "Delivery Date: From " + _DeliveryDateFrom.ToString(CSettings.DateFormat)
                            + " To " + _DeliveryDateTo.ToString(CSettings.DateFormat) + "; ";
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
