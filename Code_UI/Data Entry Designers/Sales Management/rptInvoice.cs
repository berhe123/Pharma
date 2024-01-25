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
    /// Summary description for rptInvoice.
    /// </summary>
    public partial class rptInvoice : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Invoice Report";

        int intCount;

        public rptInvoice()
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
                //txtItem.Text = txtItem.Text + " " + txtMeasurement.Text + " " + CCommon.GetDosageFormText(Convert.ToInt32(txtDosageForm.Value));
                if (this.txtInvoiceType.Text.ToString() != string.Empty && intCount == 1)
                {
                    this.txtInvoiceType.Text = CCommon.GetInvoiceTypeText(Convert.ToInt32(this.txtInvoiceType.Text.ToString()));
                    this.txtInvoiceType.Text += " Invoice";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotal()
        {
            try
            {
                decimal subtotal = Convert.ToDecimal(this.txtSubTotal.Value);
                decimal discount = Convert.ToDecimal(this.txtDiscountRate.Value);
                decimal discountamount = subtotal * discount / 100;
                decimal decInvoiceTotal = subtotal - discountamount;

                txtDiscountRate.Text = discount.ToString(CSettings.CurrencyFormat) + " % Discount";
                txtDiscount.Text = discountamount.ToString(CSettings.CurrencyFormat);
                txtInvoiceTotal.Text = decInvoiceTotal.ToString(CSettings.CurrencyFormat);
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
                CalculateTotal();

                if (this.txtInvoiceTotal.Text.ToString() != string.Empty)
                {
                    this.txtInvoiceTotalInText.Text = CDigits.GiveMeThisNumberInText(Convert.ToDecimal(this.txtInvoiceTotal.Text.ToString()));
                    this.txtInvoiceTotalInText.Text += " Only";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
           
        }

        private void rptInvoice_ReportStart(object sender, EventArgs e)
        {
            try
            {
                if (CSettings.OrganizationLogo != null)
                    this.picLogo.Image = CPicture.ByteArrayToPicture(CSettings.OrganizationLogo);
                lblOrganization.Text = CSettings.OrganizationName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
