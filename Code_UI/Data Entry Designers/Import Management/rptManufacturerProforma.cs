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
    /// Summary description for rptManufacturerProforma.
    /// </summary>
    public partial class rptManufacturerProforma : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Manufacturer Proforma Report";

        public rptManufacturerProforma()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {

        }

        private void groupHeader1_Format(object sender, EventArgs e)
        {
            try
            {
                txtDispatch.Text = CCommon.GetDispatchText(Convert.ToInt32(txtDispatch.Value));
                txtTermsOfShipment.Text = CCommon.GetTermsOfShipmentText(Convert.ToInt32(txtTermsOfShipment.Value));
                txtTermsOfPayment.Text = CCommon.GetTermsOfPaymentText(Convert.ToInt32(txtTermsOfPayment.Value));

                lblPricePerUnit.Text = "Price per Unit (" + CCommon.GetCurrencyTypeText(Convert.ToInt32(txtCurrencyType.Value)) + ")";
                lblLineTotal.Text = "Total (" + CCommon.GetCurrencyTypeText(Convert.ToInt32(txtCurrencyType.Value)) + ")";

                //if (Convert.ToInt32(txtProformaType.Value) == (int)CCommon.ProformaOrderType.Sample)
                //    lblFreeMedicalSample.Visible = true;
                //else
                //    lblFreeMedicalSample.Visible = false;
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
                decFreight = txtFreight.Text == string.Empty ? 0 : Convert.ToDecimal(txtFreight.Text);
                decTotalCandF = decTotalFob + decFreight;

                txtTotalCandF.Value = decTotalCandF.ToString();

                lblTotalFOB.Text = "Total F.O.B. " + txtOrigin.Text + " (" + CCommon.GetCurrencyTypeText(Convert.ToInt32(txtCurrencyType.Text)) + "):";
                lblFreight.Text = CCommon.GetDispatchTextForFreight(Convert.ToInt32(txtDispatch.Value)) + " Freight (" + CCommon.GetCurrencyTypeText(Convert.ToInt32(txtCurrencyType.Text)) + "):";
                lblTotalCandF.Text = "Total C+F " + CCommon.GetDispatchTextForFreight(Convert.ToInt32(txtDispatch.Value)) + " " + txtDestination.Text + " (" + CCommon.GetCurrencyTypeText(Convert.ToInt32(txtCurrencyType.Text)) + "):";
                if (Convert.ToInt32(txtTermsOfPayment.Value) == (int)CCommon.TermsOfPayment.FreeOfCharge)
                {
                    this.txtTotalFOB.Text = "Free of Charge";
                    this.txtFreight.Text = "Free of Charge";
                    this.txtTotalCandF.Text = "Free of Charge";

                    this.lblTotalFOB.Visible = false;
                    this.lblFreight.Visible = false;
                    this.lblTotalCandF.Visible = false;

                    this.txtTotalFOB.Visible = false;
                    this.txtFreight.Visible = false;
                    this.txtTotalCandF.Visible = false;
                }
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
                if (Convert.ToInt32(txtProformaType.Value) == (int)CCommon.ProformaOrderType.Sample)
                    txtQuantity.Text = txtQuantity.Text + " " + txtUnitOfMeasurement.Text + " " + txtSamplePresentation.Value;
                else
                    txtQuantity.Text = txtQuantity.Text + " " + txtUnitOfMeasurement.Text + " " + txtMeasurement.Value;

                txtProduct.Text = txtProduct.Text + " " + txtDosageForm.Value;
                if (Convert.ToInt32(txtTermsOfPayment.Value) == (int)CCommon.TermsOfPayment.FreeOfCharge)
                {
                    this.txtPricePerUnit.Text = "Free of Charge";
                    this.txtLineTotal.Text = "Free of Charge";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
