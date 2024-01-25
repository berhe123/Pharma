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
    /// Summary description for rptTenderCheckList.
    /// </summary>
    public partial class rptBidBondList : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Tender Check List Report";

        int intCount;

        public rptBidBondList()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void groupHeader1_Format(object sender, EventArgs e)
        {
            try
            {
                intCount = 0;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {
            try
            {
                //
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void detail_Format(object sender, EventArgs e)
        {
            try
            {
                intCount = intCount + 1;
                txtCount.Text = intCount.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptTenderCheckList_ReportStart(object sender, EventArgs e)
        {
            try
            {
                if (CSettings.OrganizationLogo != null)                    
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

        }

        private void groupHeader3_Format(object sender, EventArgs e)
        {
            txtBidStatus.Text = CCommon.GetBidBondStatusText(Convert.ToInt32(txtBidStatus.Value));
        }
    }
}
