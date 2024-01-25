using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharma
{
    public partial class frmListOfPaymentRequests : Form
    {
        private const string DialogCaption = "List of Payment Requests";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector cusSelector = null;

        public frmListOfPaymentRequests()
        {
            InitializeComponent();

            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            popupHelper.AssignHandle(this.Handle);
        }

        public void ShowPaymentRequests()
        {
            try
            {
                DataTable dt = new DataTable();
                rptPaymentRequestsList rpt = new rptPaymentRequestsList();
                frmReportViewer frm = null;

                string Customerguid = "-1";
                string SettlementStatus = "-1";

                Customerguid = this.txtCustomerFilter.Text != string.Empty && this.txtCustomerFilter.Tag != null ? this.txtCustomerFilter.Tag.ToString() : "-1";
                SettlementStatus = CCommon.GetItemData(this.cboSettlementStatus);

                rpt.Customerguid = Customerguid;
                rpt.Customer = this.txtCustomerFilter.Text;
                rpt.SettlementStatus = Convert.ToInt32(SettlementStatus);
                rpt.RequestDateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFromRequest.Text);
                rpt.RequestDateTo = CDateTime.DateFromStringForSQLMax(this.txtDateToRequest.Text);
                rpt.FilterByRequestDate = this.chkRequestDate.Checked;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   PaymentRequestId, PaymentRequestGuid, CustomerGuid, Customer, RequestDate, ReferenceNumber,InvoiceNumber,  ";
                strSQL = strSQL + "         SubTotal = SUM(SubTotal), DiscountAmount = SUM(DiscountAmount), InvoiceTotal = SUM(InvoiceTotal) ";
                strSQL = strSQL + " FROM ( ";
                strSQL = strSQL + " SELECT   dbo.tblCashCollections.Id AS PaymentRequestId, dbo.tblCashCollections.TableRowGuid AS PaymentRequestGuid, dbo.tblCashCollections.CustomerGuid, dbo.tblCashCollections.RequestDate,  ";
                strSQL = strSQL + "                 dbo.tblCashCollections.ReferenceNumber, dbo.tblCashCollections.BankGuid, dbo.tblCashCollections.BankBranchName,  ";
                strSQL = strSQL + "                 dbo.tblCashCollections.ModeOfPayment, dbo.tblCashCollections.CheckOrCPONumber, dbo.tblCashCollections.CheckOrCPODate,  ";
                strSQL = strSQL + "                 dbo.tblCashCollections.CheckMaturityDate, dbo.tblCashCollections.Settled, dbo.tblCashCollections.SettlementDate,  ";
                strSQL = strSQL + "                 dbo.tblCashCollections.CheckCashedDate, dbo.tblCashCollections.CheckIsCashed,  ";
                strSQL = strSQL + "                 dbo.tblCashCollectionInvoices.Id AS PaymentRequestDetailId, dbo.tblCashCollectionInvoices.TableRowGuid AS PaymentRequestDetailGuid, dbo.tblCashCollectionInvoices.InvoiceGuid,  ";
                strSQL = strSQL + "                 dbo.vwInvoices.ReferenceNumber as InvoiceNumber,dbo.vwInvoices.Quantity, dbo.vwInvoices.InvoiceDetailGuid, dbo.tblCustomers.Name AS Customer, ";

                strSQL = strSQL + "          Discount = IsNull(vwInvoices.Discount, 0), UnitPrice = IsNull(vwInvoices.UnitPrice, 0), ";
                strSQL = strSQL + "          SubTotal = IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0),  ";
                strSQL = strSQL + "          DiscountAmount = IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0) * IsNull(vwInvoices.Discount, 0) * 0.01, ";
                strSQL = strSQL + "          InvoiceTotal = IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0) - IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0) * IsNull(vwInvoices.Discount, 0) * 0.01 ";

                strSQL = strSQL + " FROM      dbo.tblCashCollections INNER JOIN ";
                strSQL = strSQL + "                 dbo.tblCashCollectionInvoices ON dbo.tblCashCollections.TableRowGuid = dbo.tblCashCollectionInvoices.CashCollectionGuid INNER JOIN ";
                strSQL = strSQL + "                 dbo.vwInvoices ON dbo.tblCashCollectionInvoices.InvoiceGuid = dbo.vwInvoices.InvoiceGuid INNER JOIN ";
                strSQL = strSQL + "                 dbo.tblBatchs ON dbo.vwInvoices.BatchGuid = dbo.tblBatchs.TableRowGuid INNER JOIN ";
                strSQL = strSQL + "                 dbo.tblCustomers ON tblCashCollections.CustomerGuid = tblCustomers.TableRowGuid ";
                if (SettlementStatus != "-1") strSQL = strSQL + " WHERE (IsNull(tblCashCollections.Settled, 0) = " + SettlementStatus + ") ";
                strSQL = strSQL + " ) PaymentRequest ";
                strSQL = strSQL + " WHERE (1=1)  ";
                if (Customerguid != "-1" && Customerguid.Length > 0) strSQL = strSQL + " AND (PaymentRequest.CustomerGuid = '" + Customerguid + "') ";

                if (this.chkRequestDate.Checked == true)
                {
                    strSQL = strSQL + " AND (PaymentRequest.RequestDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFromRequest.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (PaymentRequest.RequestDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateToRequest.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }

                strSQL = strSQL + " GROUP BY PaymentRequestId, PaymentRequestGuid, CustomerGuid, Customer, RequestDate,InvoiceNumber, ReferenceNumber  ";
                strSQL = strSQL + " Order By Customer, RequestDate, InvoiceNumber,ReferenceNumber ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "List of Invoices";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    MessageBox.Show("Report generation - No record found", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPaymentRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmListOfCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillPaymentSettlementCombo(cboSettlementStatus, false);               
                this.txtDateFromRequest.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateToRequest.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkRequestDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkRequestDate.CheckState == CheckState.Unchecked)
                {
                    this.txtDateFromRequest.Enabled = false;
                    this.txtDateToRequest.Enabled = false;
                }
                else if (this.chkRequestDate.CheckState == CheckState.Checked)
                {
                    this.txtDateFromRequest.Enabled = true;
                    this.txtDateToRequest.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectCustomer frmCust = new frmSelectCustomer();
                frmCust.ShowDialog();
                if (frmCust.bCancel == true) return;
                this.txtCustomerFilter.Tag = frmCust.Customerguid.ToString();
                this.txtCustomerFilter.Text = frmCust.CustomerName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCustomer(TextBox SearchTextBox, int HorizontalOffset, int VerticalOffset)
        {
            try
            {
                if (SearchTextBox.Text != "")
                {
                    CSuppliesRequisitions objCustomer = new CSuppliesRequisitions();
                    string nameLike = SearchTextBox.Text + "%";
                    objCustomer.OrganizationName = nameLike;
                    ArrayList ar = new ArrayList(objCustomer.GetCustomerByName());
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        cusSelector = new frmCustomerSelector();
                        cusSelector.SearchTextBox = SearchTextBox;
                        cusSelector.Width = SearchTextBox.Width;
                        cusSelector.lvwCustomer.Items.Clear();
                        foreach (CSuppliesRequisitions Customer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Customer.Customerguid.ToString(),
                            Customer.OrganizationName.ToString()});
                            cusSelector.lvwCustomer.Items.Add(itmX);
                        }
                        Point location = this.PointToScreen(new Point(SearchTextBox.Left + HorizontalOffset, SearchTextBox.Bottom + VerticalOffset));
                        popupHelper.ShowPopup(this, cusSelector, location);

                        if (cusSelector.blnSelected)
                        {
                            SearchTextBox.Tag = cusSelector.Customerguid;
                            SearchTextBox.Text = cusSelector.OrganizationName;
                        }
                    }
                    else
                    {
                        CSuppliesRequisitions Customer = (CSuppliesRequisitions)ar[0];
                        SearchTextBox.Tag = Customer.Customerguid;
                        SearchTextBox.Text = Customer.OrganizationName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void popupHelper_PopupClosed(object sender, PopupClosedEventArgs e)
        {
            try
            {
                TextBox SearchTextBox;
                if (cusSelector.blnSelected)
                {
                    SearchTextBox = cusSelector.SearchTextBox;
                    if (SearchTextBox != null)
                    {
                        SearchTextBox.Tag = cusSelector.Customerguid;
                        SearchTextBox.Text = cusSelector.OrganizationName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void popupHelper_PopupCancel(object sender, PopupCancelEventArgs e)
        {
            //Console.WriteLine("Popup Cancel, mouse clicked at {0}", e.CursorLocation);
        }

        private void txtCustomerFilter_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SearchCustomer(txtCustomerFilter, grpCustomer.Left, grpCustomer.Top);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSearchCustomer1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCustomer(txtCustomerFilter, grpCustomer.Left, grpCustomer.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
