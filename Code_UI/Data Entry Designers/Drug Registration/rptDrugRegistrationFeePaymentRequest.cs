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
    /// Summary description for rptDrugRegistrationFeePaymentRequest.
    /// </summary>
    public partial class rptDrugRegistrationFeePaymentRequest : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Drug Registration Fee - Payment Request Report";

        int intCount;

        public rptDrugRegistrationFeePaymentRequest()
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

        private void rptRequisition_ReportStart(object sender, EventArgs e)
        {
            try
            {
                if (CSettings.OrganizationLogo != null)
                    this.picLogo.Image = CPicture.ByteArrayToPicture(CSettings.OrganizationLogo);
                lblOrganization.Text = CSettings.OrganizationName;
                txtAddress.Text = CSettings.OrganizationAddress +
                                    " P.O.Box: " + CSettings.OrganizationPOBox + ";" +
                                    " Tel: " + CSettings.OrganizationTelephone + ";" +
                                    " Fax: " + CSettings.OrganizationFax + ";";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pageFooter_Format(object sender, EventArgs e)
        {

        }

        private void pageHeader_Format(object sender, EventArgs e)
        {

        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {

        }
    }
}
