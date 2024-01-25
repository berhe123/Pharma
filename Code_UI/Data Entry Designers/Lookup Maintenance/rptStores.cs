using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharma
{
    /// <summary>
    /// Summary description for rptStores.
    /// </summary>
    public partial class rptStores : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Stores Report";

        int intCount;

        #region Class Property Declarations

        string _ReportTitle;
        public string ReportTitle
        {
            get { return _ReportTitle; }
            set { _ReportTitle = value; }
        }

        #endregion

        public rptStores()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            try
            {
                this.lblTitle.Text = _ReportTitle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupHeader1_Format(object sender, EventArgs e)
        {
           
        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {
            
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

        private void rptLookup_ReportStart(object sender, EventArgs e)
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
