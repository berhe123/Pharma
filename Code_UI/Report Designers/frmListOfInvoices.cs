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
    public partial class frmListOfInvoices : Form
    {
        private const string DialogCaption = "List of Invoices";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector cusSelector = null;

        public frmListOfInvoices()
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

        public void ShowInvoices()
        {
            try
            {
                DataTable dt = new DataTable();
                rptInvoicesList rpt = new rptInvoicesList();
                frmReportViewer frm = null;

                string Customerguid = "0";
                string InvoiceType = "-1";
                string DeliveryStatus = "-1";

                Customerguid = this.txtCustomerFilter.Text != string.Empty && this.txtCustomerFilter.Tag != null ? this.txtCustomerFilter.Tag.ToString() : "-1";
                InvoiceType = CCommon.GetItemData(cboInvoiceType);
                DeliveryStatus = CCommon.GetItemData(cboDeliveryStatus);

                rpt.Customerguid = Customerguid;
                rpt.InvoiceType = Convert.ToInt32(InvoiceType);
                rpt.InvoiceDateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFromInvoice.Text);
                rpt.InvoiceDateTo = CDateTime.DateFromStringForSQLMax(this.txtDateToInvoice.Text);
                rpt.FilterByInvoiceDate = this.chkInvoiceDate.Checked;
                rpt.DeliveryStatus = Convert.ToInt32(DeliveryStatus);
                rpt.DeliveryDateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFromDelivery.Text);
                rpt.DeliveryDateTo = CDateTime.DateFromStringForSQLMax(this.txtDateToDelivery.Text);
                rpt.FilterByDeliveryDate = this.chkDeliveryDate.Checked;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   Invoices.Customer, Invoices.TableRowGuid, Invoices.CustomerGuid, Invoices.ReferenceNumber,  ";
                strSQL = strSQL + "         Invoices.InvoiceDate, Invoices.InvoiceType, Invoices.DueDate, ";
                strSQL = strSQL + "         Invoices.DeliveryDate, Invoices.DeliveryStatus, ";
                strSQL = strSQL + "         SubTotal = Sum(Invoices.Quantity * Invoices.UnitPrice),  ";
                strSQL = strSQL + "         TOT = Sum(Invoices.Quantity * Invoices.UnitPrice * Invoices.VAT * 0.01), ";
                strSQL = strSQL + "         InvoiceTotal = Sum(Invoices.Quantity * Invoices.UnitPrice + Invoices.Quantity * Invoices.UnitPrice * Invoices.VAT * 0.01) ";
                strSQL = strSQL + "  FROM        ";
                strSQL = strSQL + "                 (SELECT   tblCustomers.Name AS Customer, vwInvoices.InvoiceGuid AS TableRowGuid, vwInvoices.CustomerGuid, vwInvoices.ReferenceNumber,  ";
                strSQL = strSQL + "                                 vwInvoices.InvoiceDate, vwInvoices.InvoiceType, vwInvoices.DueDate, vwInvoices.PreparedBy, vwInvoices.CheckedBy,  ";
                strSQL = strSQL + "                                 vwInvoices.ApprovedBy, vwInvoices.PreparedDate, vwInvoices.DeliveredBy, vwInvoices.CheckedDate, vwInvoices.VAT, ";
                strSQL = strSQL + "                                 vwInvoices.ApprovalDate, vwInvoices.DeliveryDate, vwInvoices.DeliveryStatus, vwInvoices.SuppliesRequisitionGuid,  ";
                strSQL = strSQL + "                                 vwInvoices.CashCollectionGuid, vwInvoices.InvoiceDetailGuid AS DetailGuid, vwInvoices.BatchGuid, Quantity = IsNull(vwInvoices.Quantity, 0),  ";
                strSQL = strSQL + "                                 Discount = IsNull(vwInvoices.Discount, 0), UnitPrice = IsNull(vwInvoices.UnitPrice, 0) ";
                strSQL = strSQL + "                 FROM      tblCustomers INNER JOIN ";
                strSQL = strSQL + "                                 vwInvoices ON tblCustomers.TableRowGuid = vwInvoices.CustomerGuid INNER JOIN ";
                strSQL = strSQL + "                                 tblBatchs ON vwInvoices.BatchGuid = tblBatchs.TableRowGuid) AS Invoices ";
                strSQL = strSQL + " WHERE (1=1) AND IsNull(Invoices.DeliveryStatus,0) = 1 ";
                if (Customerguid != "-1" && Customerguid.Length > 0) strSQL = strSQL + " AND (Invoices.CustomerGuid = '" + Customerguid + "') ";
                if (InvoiceType != "-1") strSQL = strSQL + " AND (Invoices.InvoiceType = " + InvoiceType + ") ";
                if (this.chkInvoiceDate.Checked == true)
                {
                    strSQL = strSQL + " AND (Invoices.InvoiceDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFromInvoice.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (Invoices.InvoiceDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateToInvoice.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }
                if (DeliveryStatus != "-1") strSQL = strSQL + " AND (Invoices.DeliveryStatus = " + DeliveryStatus + ") ";
                if (this.chkDeliveryDate.Checked == true)
                {
                    strSQL = strSQL + " AND (Invoices.DeliveryDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFromDelivery.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (Invoices.DeliveryDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateToDelivery.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }
                strSQL = strSQL + " GROUP BY Invoices.Customer, Invoices.TableRowGuid, Invoices.CustomerGuid, Invoices.ReferenceNumber,  ";
                strSQL = strSQL + "          Invoices.InvoiceDate, Invoices.InvoiceType, Invoices.DueDate, ";
                strSQL = strSQL + "          Invoices.DeliveryDate, Invoices.DeliveryStatus ";
                strSQL = strSQL + " Order By Invoices.Customer, Invoices.InvoiceDate, Invoices.InvoiceType, cast(Invoices.ReferenceNumber as int)";

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
        public void ShowInvoicesByCustomerAggregate()
        {
            try
            {
                DataTable dt = new DataTable();
                rptInvoicesListByCustomer rpt = new rptInvoicesListByCustomer();
                frmReportViewer frm = null;

                string InvoiceType = "-1";

                InvoiceType = CCommon.GetItemData(cboInvoiceType);

                rpt.InvoiceType = Convert.ToInt32(InvoiceType);
                rpt.InvoiceDateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFromInvoice.Text);
                rpt.InvoiceDateTo = CDateTime.DateFromStringForSQLMax(this.txtDateToInvoice.Text);
                rpt.FilterByInvoiceDate = this.chkInvoiceDate.Checked;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   Invoices.Customer, Invoices.CustomerGuid, Invoices.InvoiceType, ";
                strSQL = strSQL + "         SubTotal = Sum(Invoices.Quantity * Invoices.UnitPrice),  ";
                strSQL = strSQL + "         TOT = Sum(Invoices.Quantity * Invoices.UnitPrice * Invoices.VAT * 0.01), ";
                strSQL = strSQL + "         InvoiceTotal = Sum(Invoices.Quantity * Invoices.UnitPrice + Invoices.Quantity * Invoices.UnitPrice * Invoices.VAT * 0.01) ";
                strSQL = strSQL + "  FROM        ";
                strSQL = strSQL + "                 (SELECT   tblCustomers.Name AS Customer, vwInvoices.InvoiceGuid AS TableRowGuid, vwInvoices.CustomerGuid, vwInvoices.ReferenceNumber,  ";
                strSQL = strSQL + "                                 vwInvoices.InvoiceDate, vwInvoices.InvoiceType, vwInvoices.DueDate, vwInvoices.PreparedBy, vwInvoices.CheckedBy,  ";
                strSQL = strSQL + "                                 vwInvoices.ApprovedBy, vwInvoices.PreparedDate, vwInvoices.DeliveredBy, vwInvoices.CheckedDate,vwInvoices.VAT,  ";
                strSQL = strSQL + "                                 vwInvoices.ApprovalDate, vwInvoices.DeliveryDate, vwInvoices.DeliveryStatus, vwInvoices.SuppliesRequisitionGuid,  ";
                strSQL = strSQL + "                                 vwInvoices.CashCollectionGuid, vwInvoices.InvoiceDetailGuid AS DetailGuid, vwInvoices.BatchGuid, Quantity = IsNull(vwInvoices.Quantity, 0),  ";
                strSQL = strSQL + "                                 Discount = IsNull(vwInvoices.Discount, 0), UnitPrice = IsNull(vwInvoices.UnitPrice, 0) ";
                strSQL = strSQL + "                 FROM      tblCustomers INNER JOIN ";
                strSQL = strSQL + "                                 vwInvoices ON tblCustomers.TableRowGuid = vwInvoices.CustomerGuid INNER JOIN ";
                strSQL = strSQL + "                                 tblBatchs ON vwInvoices.BatchGuid = tblBatchs.TableRowGuid) AS Invoices ";
                strSQL = strSQL + " WHERE (1=1) AND IsNull(Invoices.DeliveryStatus,0) = 1 ";
                if (InvoiceType != "-1") strSQL = strSQL + " AND (Invoices.InvoiceType = " + InvoiceType + ") ";
                if (this.chkInvoiceDate.Checked == true)
                {
                    strSQL = strSQL + " AND (Invoices.InvoiceDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFromInvoice.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (Invoices.InvoiceDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateToInvoice.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }
                strSQL = strSQL + " GROUP BY Invoices.Customer, Invoices.CustomerGuid, Invoices.InvoiceType ";
                strSQL = strSQL + " Order By Invoices.InvoiceType, Invoices.Customer ";

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
        public void ShowInvoicesWithCustomer()
        {
            try
            {
                DataTable dt = new DataTable();
                rptInvoicesListByCustomerDetailed rpt = new rptInvoicesListByCustomerDetailed();
                frmReportViewer frm = null;

                string InvoiceType = "-1";

                InvoiceType = CCommon.GetItemData(cboInvoiceType);

                rpt.InvoiceType = Convert.ToInt32(InvoiceType);
                rpt.InvoiceDateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFromInvoice.Text);
                rpt.InvoiceDateTo = CDateTime.DateFromStringForSQLMax(this.txtDateToInvoice.Text);
                rpt.FilterByInvoiceDate = this.chkInvoiceDate.Checked;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   Invoices.InvoiceType, Invoices.InvoiceDate, Invoices.ReferenceNumber, Invoices.Customer, Invoices.TableRowGuid, ";
                strSQL = strSQL + "         SubTotal = Sum(Invoices.SubTotal),  ";
                strSQL = strSQL + "         TOT = Sum(Invoices.VAT), ";
                strSQL = strSQL + "         InvoiceTotal = Sum(Invoices.InvoiceTotal) ";
                strSQL = strSQL + "  FROM        ";
                strSQL = strSQL + "                 (SELECT   tblCustomers.Name AS Customer, vwInvoices.InvoiceGuid AS TableRowGuid, vwInvoices.CustomerGuid, vwInvoices.ReferenceNumber,  ";
                strSQL = strSQL + "                                 vwInvoices.InvoiceDate, vwInvoices.InvoiceType, vwInvoices.DueDate, vwInvoices.PreparedBy, vwInvoices.CheckedBy,  ";
                strSQL = strSQL + "                                 vwInvoices.ApprovedBy, vwInvoices.PreparedDate, vwInvoices.DeliveredBy, vwInvoices.CheckedDate, vwInvoices.VAT, ";
                strSQL = strSQL + "                                 vwInvoices.ApprovalDate, vwInvoices.DeliveryDate, vwInvoices.DeliveryStatus, vwInvoices.SuppliesRequisitionGuid,  ";
                strSQL = strSQL + "                                 vwInvoices.CashCollectionGuid, vwInvoices.InvoiceDetailGuid AS DetailGuid, vwInvoices.BatchGuid, Quantity = IsNull(vwInvoices.Quantity, 0),  ";
                strSQL = strSQL + "                                 DiscountRate = IsNull(vwInvoices.Discount, 0), UnitPrice = IsNull(vwInvoices.UnitPrice, 0), ";
                strSQL = strSQL + "                                 SubTotal = IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0),  ";
                strSQL = strSQL + "                                 Discount = IsNull(vwInvoices.Quantity, 0) * vwInvoices.UnitPrice * IsNull(vwInvoices.Discount, 0) * 0.01, ";
                strSQL = strSQL + "                                 InvoiceTotal = IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0) - IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0) * IsNull(vwInvoices.Discount, 0) * 0.01 ";
                strSQL = strSQL + "                 FROM      tblCustomers INNER JOIN ";
                strSQL = strSQL + "                                 vwInvoices ON tblCustomers.TableRowGuid = vwInvoices.CustomerGuid INNER JOIN ";
                strSQL = strSQL + "                                 tblBatchs ON vwInvoices.BatchGuid = tblBatchs.TableRowGuid) AS Invoices ";
                strSQL = strSQL + " WHERE (1=1) AND IsNull(Invoices.DeliveryStatus,0) = 1 ";
                if (InvoiceType != "-1") strSQL = strSQL + " AND (Invoices.InvoiceType = " + InvoiceType + ") ";
                if (this.chkInvoiceDate.Checked == true)
                {
                    strSQL = strSQL + " AND (Invoices.InvoiceDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFromInvoice.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (Invoices.InvoiceDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateToInvoice.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }
                strSQL = strSQL + " GROUP BY Invoices.InvoiceType, Invoices.InvoiceDate, Invoices.ReferenceNumber, Invoices.Customer, Invoices.TableRowGuid ";
                strSQL = strSQL + " ORDER BY Invoices.InvoiceType, Invoices.InvoiceDate, cast(Invoices.ReferenceNumber as int), Invoices.Customer, Invoices.TableRowGuid ";

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
                if (optSimpleList.Checked == true)
                    ShowInvoices();
                else if (optCustomerAggregate.Checked == true)
                    ShowInvoicesByCustomerAggregate();
                else if (optCustomerInvoiceList.Checked == true)
                    ShowInvoicesWithCustomer();
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
                CCommon.FillInvoiceTypeCombo(cboInvoiceType, false);
                CCommon.FillDeliveryStatusCombo(cboDeliveryStatus, false);

                this.txtDateFromInvoice.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateToInvoice.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateFromDelivery.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateToDelivery.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkInvoiceDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkInvoiceDate.CheckState == CheckState.Unchecked)
                {
                    this.txtDateFromInvoice.Enabled = false;
                    this.txtDateToInvoice.Enabled = false;
                }
                else if (this.chkInvoiceDate.CheckState == CheckState.Checked)
                {
                    this.txtDateFromInvoice.Enabled = true;
                    this.txtDateToInvoice.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkDeliveryDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkDeliveryDate.CheckState == CheckState.Unchecked)
                {
                    this.txtDateFromDelivery.Enabled = false;
                    this.txtDateToDelivery.Enabled = false;
                }
                else if (this.chkDeliveryDate.CheckState == CheckState.Checked)
                {
                    this.txtDateFromDelivery.Enabled = true;
                    this.txtDateToDelivery.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optSimpleList_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optSimpleList.Checked == true)
                {
                    grpCustomer.Enabled = true;
                    grpInvoice.Enabled = true;
                    grpDelivery.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optCustomerAggregate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optCustomerAggregate.Checked == true)
                {
                    grpCustomer.Enabled = false;
                    grpInvoice.Enabled = true;
                    grpDelivery.Enabled = false;
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

        private void optCustomerInvoiceList_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optCustomerInvoiceList.Checked == true)
                {
                    grpCustomer.Enabled = false;
                    grpInvoice.Enabled = true;
                    grpDelivery.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
