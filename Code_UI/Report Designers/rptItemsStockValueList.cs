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
    /// Summary description for rptItemsStockValueList.
    /// </summary>
    public partial class rptItemsStockValueList : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "List of Items Report";

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

        decimal _ReorderLevel;
        public decimal ReorderLevel
        {
            get { return _ReorderLevel; }
            set { _ReorderLevel = value; }
        }

        #endregion

        public rptItemsStockValueList()
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
                //this.lblCriteria.Text = "Reorder Quantity Level >= " + _ReorderLevel.ToString(CSettings.CurrencyFormat);
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
            //    //intCount = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
