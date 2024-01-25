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
    /// Summary description for rptPurchaseOrder.
    /// </summary>
    public partial class rptLocalPurchaseOrder : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Purchase Order Report";

        int intCount;

        public rptLocalPurchaseOrder()
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

                txtOrderType.Text = CCommon.GetLocalPurchaseOrderTypeText(Convert.ToInt32(txtOrderType.Value));
                lblPricePerUnit.Text = "Price per Unit (Birr)";
                lblLineTotal.Text = "Total (Birr)";
               
                
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
                decimal decTotalFob = 0;
                decimal decFreight = 0;
                decimal decTotalCandF = 0;

                decTotalFob = txtTotalFOB.Text == string.Empty ? 0 : Convert.ToDecimal(txtTotalFOB.Text);
                decTotalCandF = decTotalFob + decFreight;


                lblTotalFOB.Text = "Total (Birr):";

               
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
                txtItemCount.Text = intCount.ToString();
                txtProduct.Text = txtProduct.Text + " " + txtMeasurement.Value + " " + txtDosageForm.Value;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptPurchaseOrder_ReportStart(object sender, EventArgs e)
        {
            try
            {
                if (CSettings.OrganizationLogo != null)
                    this.picLogo.Image = CPicture.ByteArrayToPicture(CSettings.OrganizationLogo);
                lblOrganization.Text = CSettings.OrganizationName;
                txtFax.Text = CSettings.OrganizationFax;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupHeader3_Format(object sender, EventArgs e)
        {

        }
    }
}
