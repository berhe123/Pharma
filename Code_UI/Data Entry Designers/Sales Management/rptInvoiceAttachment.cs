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
    /// Summary description for rptInvoiceAttachment.
    /// </summary>
    public partial class rptInvoiceAttachment : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Invoice Attachment Report";

        //int invoiceType = 0;
        int intCount;
        int x = 0;

        public rptInvoiceAttachment()
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
                if (this.txtInvoiceType.Value.ToString() != string.Empty)
                {
                    //this.invoiceType = Convert.ToInt32(this.txtInvoiceType.Value.ToString());
                    this.txtInvoiceType.Text = CCommon.GetInvoiceTypeText(Convert.ToInt32(this.txtInvoiceType.Value.ToString()));
                    this.txtInvoiceType.Text += " Attachment";
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
                decimal vat = Convert.ToDecimal(this.txtVAT.Value);

                decimal discountamount = subtotal * discount / 100;
                decimal vatamount = (subtotal - discountamount) * (vat / 100);
                decimal decInvoiceTotal = (subtotal - discountamount) + vatamount;

                txtDiscountRate.Text = discount.ToString(CSettings.CurrencyFormat) + " % Discount";
                txtVAT.Text = vat.ToString(CSettings.CurrencyFormat) + "% TOT";
                txtDiscount.Text = discountamount.ToString(CSettings.CurrencyFormat);
                txtVATAmount.Text = vatamount.ToString(CSettings.CurrencyFormat);
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
            //int fsnumber = 0;

            //if (this.txtFSNumber.Text.ToString() != string.Empty)
            //{
            //    fsnumber = Convert.ToInt32(this.txtFSNumber.Text.ToString().Trim());
            //    fsnumber -= 9746;

            //    this.txtFSNumber.Text = fsnumber.ToString();
            //}
        }

        private void rptInvoice_ReportStart(object sender, EventArgs e)
        {
            try
            {
                if (CSettings.OrganizationLogo != null)
                    this.picLogo.Image = CPicture.ByteArrayToPicture(CSettings.OrganizationLogo);
                lblOrganization.Text = CSettings.OrganizationName;
                txtTIN.Text = CSettings.OrganizationTIN;
                //txtFSNumber.Text = CSettings.OrganizationFSNumber;
                txtMachineRegistrationCode.Text = CSettings.OrganizationMachineRegistrationCode;
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

        private void groupHeader1_Format(object sender, EventArgs e)
        {
            try
            {
                //if (this.txtDeliveryStatus.Text == "1")
                //    this.txtDeliveryStatusText.Visible = true;
                //else
                //    this.txtDeliveryStatusText.Visible = false;

                //if (this.txtDeliveryStatus.Text == "2")
                //    this.Watermark = this.picWatermarkVoid.Image;
                //else
                //{
                //    if (this.txtGrouping.Text == "0")
                //        this.Watermark = this.picWatermarkAttachment.Image;
                //    else if (this.txtGrouping.Text == "1")
                //        this.Watermark = this.picWatermarkAttachment.Image;
                //    else if (this.txtGrouping.Text == "2")
                //        this.Watermark = this.picWatermarkAttachment.Image;
                //}

                intCount = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InvoiceIsVoid()
        {
            try
            {
                this.Watermark = this.picWatermarkVoid.Image;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupHeader3_Format(object sender, EventArgs e)
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

        private void WriteText(string textToWrite)
        {
            try
            {
                x += 1;
                System.Drawing.Font f = new System.Drawing.Font("Times New Roman", 36);
                foreach (DataDynamics.ActiveReports.Document.Page page in this.Document.Pages)
                {
                    page.ForeColor = System.Drawing.Color.YellowGreen;
                    page.Font = f;
                    page.TextAlignment = DataDynamics.ActiveReports.TextAlignment.Center;
                    page.TextAngle = 900;
                    page.VerticalTextAlignment = DataDynamics.ActiveReports.VerticalTextAlignment.Middle;
                    page.DrawText(textToWrite, 0.25f, 1, 6.5f, 9);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptInvoiceFull_PageEnd(object sender, EventArgs e)
        {
            //try
            //{
            //    WriteText("Confidential");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void rptInvoiceFull_PageStart(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.txtGrouping.Text == "0")
            //        this.Watermark = this.picWatermarkOriginal.Image;
            //    else if (this.txtGrouping.Text == "1")
            //        this.Watermark = this.picWatermarkCopy1.Image;
            //    else if (this.txtGrouping.Text == "2")
            //        this.Watermark = this.picWatermarkCopy2.Image;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
