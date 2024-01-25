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
    /// Summary description for rptItemsBelowReorderLevel.
    /// </summary>
    public partial class rptItemsBelowReorderLevel : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "List of Items Below Reorder Level Report";

        int intCount;

        #region Class Property Declarations

        string _ManufacturerGuid;
        public string Manufacturerguid
        {
            get { return _ManufacturerGuid; }
            set { _ManufacturerGuid = value; }
        }

        string _ItemCategoryGuid;
        public string Itemcategoryguid
        {
            get { return _ItemCategoryGuid; }
            set { _ItemCategoryGuid = value; }
        }

        string _Location;
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        string _Store;
        public string Store
        {
            get { return _Store; }
            set { _Store = value; }
        }

        string _StoreGuid;
        public string Storeguid
        {
            get { return _StoreGuid; }
            set { _StoreGuid = value; }
        }

        #endregion

        public rptItemsBelowReorderLevel()
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
                this.lblCriteria.Text = " Location: " + _Location + "; Store: " + _Store;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupHeader1_Format(object sender, EventArgs e)
        {
            //try
            //{
            //    intCount = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
                txtDifference.Text = (Convert.ToDouble(txtReorderLevel.Text) - Convert.ToDouble(txtQuantity.Text)).ToString();
                //txtProduct.Text = txtProduct.Text + " " + txtMeasurement.Text + " " + CCommon.GetDosageFormText(Convert.ToInt32(txtDosageForm.Value));
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

        private void rptStockCard_ReportStart(object sender, EventArgs e)
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
            //try
            //{
            //    intCount = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
