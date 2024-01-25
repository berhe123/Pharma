using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharma
{
    public partial class frmBidsListReport : Form
    {
        private const string DialogCaption = "List of Bid Bonds";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector cusSelector = null;

        public frmBidsListReport()
        {
            InitializeComponent();
            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

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
        private void frmBidsListReport_Load(object sender, EventArgs e)
        {
            CCommon.FillTenderStatusCombo(cboBidStatus,true);
            DateCheckBoxChanged(chkAnnouncementDate, txtAnnouncementDateFrom, txtAnnouncementDateTo);
            DateCheckBoxChanged(chkBidDocumentPurchaseDate, txtPurchaseDateFrom, txtPurchaseDateTo);
            DateCheckBoxChanged(chkBidSubmissionDeadline, txtSubmissionDeadlineDateFrom, txtSubmissionDeadlineDateTo);
            DateCheckBoxChanged(chkBidOpening, txtOpeningDateFrom, txtOpeningDateTo);
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
        private void chkAnnouncementDate_CheckedChanged(object sender, EventArgs e)
        {
            DateCheckBoxChanged(chkAnnouncementDate, txtAnnouncementDateFrom, txtAnnouncementDateTo);
        }       
        private void chkBidDocumentPurchaseDate_CheckedChanged(object sender, EventArgs e)
        {
            DateCheckBoxChanged(chkBidDocumentPurchaseDate, txtPurchaseDateFrom, txtPurchaseDateTo);
        }
        private void chkBidSubmissionDeadline_CheckedChanged(object sender, EventArgs e)
        {
            DateCheckBoxChanged(chkBidSubmissionDeadline, txtSubmissionDeadlineDateFrom, txtSubmissionDeadlineDateTo);
        }
        private void chkBidOpening_CheckedChanged(object sender, EventArgs e)
        {
            DateCheckBoxChanged(chkBidOpening, txtOpeningDateFrom, txtOpeningDateTo);
        }
        private void DateCheckBoxChanged(CheckBox chkCheckBox, TextBox TextBoxFrom, TextBox TextBoxTo)
        {
            if (chkCheckBox.Checked)
            {
                TextBoxFrom.Enabled = true;
                TextBoxTo.Enabled = true;
                TextBoxFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                TextBoxTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            else
            {
                TextBoxFrom.Enabled = false;
                TextBoxTo.Enabled = false;
                TextBoxFrom.Text = string.Empty;
                TextBoxTo.Text = string.Empty;
            }
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {              
                    ShowTenderList();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowTenderList()
        {
            try
            {
                DataTable dt = new DataTable();
                rptTenderList rpt = new rptTenderList();
                frmReportViewer frm = null;
                string CustomerGuid = string.Empty;
                int BidStatus = -1;
                int BidType = -1;
                CustomerGuid = this.txtCustomerFilter.Text != string.Empty && this.txtCustomerFilter.Tag != null ? this.txtCustomerFilter.Tag.ToString() : "-1";
                BidStatus = Convert.ToInt32(CCommon.GetItemData(cboBidStatus));
                if (optInternationalBid.Checked)
                    BidType = (int)CCommon.TenderType.International;
                else if (optLocal.Checked)
                    BidType = (int)CCommon.TenderType.Local;
                else
                    BidType = -1;

                string strSQL = string.Empty;

                strSQL = strSQL + " Select tblTenders.Id,tblTenders.TableRowGuid,tblItems.id as DetailId,tblItems.TableRowGuid as DetailGuid,BidName,BidNumber,tblCustomers.Name as CustomerName,tblCustomers.MailingAddress,tblTenders.ContactPerson,";
                strSQL = strSQL + " tblTenders.ContactTel1,tblTenders.ContactTel2,tblTenders.ContactFax,tblTenders.ContactEmail,BidAdvertisementDate,";
                strSQL = strSQL + " BidAdvertisementReference,BidDocumentPurchaseAmount";
                strSQL = strSQL + " ,BidDocumentPurchaseDateFrom,BidDocumentPurchaseTimeFrom,  BidDocumentPurchaseDateTo,BidDocumentPurchaseTimeTo,";
                strSQL = strSQL + " BidSubmissionDeadlineDate,BidSubmissionDeadlineTime,BidOpeningDate ,BidOpeningTime,";
                strSQL = strSQL + " (dbo.tblItems.BrandName + ' (' + dbo.tblItems.GenericName + ') ' + ";
                strSQL = strSQL + " dbo.tblItems.Strength + ' ' + dbo.tblItems.Measurement + ' ' + dbo.tblDosageForms.Name ) AS Item,tblTenderItems.Quantity,tblTenderItems.UnitPrice,(isnull(tblTenderItems.Quantity,0) * isnull(tblTenderItems.UnitPrice,0)) as Total ";
                strSQL = strSQL + " from tblTenders join tblCustomers on (tblTenders.CustomerGuid = tblCustomers.TableRowGuid)  ";
                strSQL = strSQL + " join tblTenderItems on (tblTenders.TableRowGuid = tblTenderItems.TenderGuid)   ";
                strSQL = strSQL + " join tblItems on (tblTenderItems.Itemguid = tblItems.TableRowGuid)       ";
                strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid)";
                strSQL = strSQL + " Where 1=1 ";
                if (CustomerGuid != "-1" && CustomerGuid.Length > 0) strSQL = strSQL + " AND (tblTenders.CustomerGuid = '" + CustomerGuid + "') ";
                if (BidType != -1) strSQL = strSQL + " AND (tblTenders.BidType = " + BidType + ") ";
                if (BidStatus != -1) strSQL = strSQL + " AND (tblTenders.BidStatus = " + BidStatus + ") ";
                if (this.chkAnnouncementDate.Checked == true)
                {
                    strSQL = strSQL + " AND (tblTenders.BidAdvertisementDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtAnnouncementDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (tblTenders.BidAdvertisementDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtAnnouncementDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }                
                if (this.chkBidDocumentPurchaseDate.Checked == true)
                {
                    strSQL = strSQL + " AND (tblTenders.BidDocumentPurchaseDateTo >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtPurchaseDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (tblTenders.BidDocumentPurchaseDateTo <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtPurchaseDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }
                if (this.chkBidSubmissionDeadline.Checked == true)
                {
                    strSQL = strSQL + " AND (tblTenders.BidSubmissionDeadlineDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtSubmissionDeadlineDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (tblTenders.BidSubmissionDeadlineDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtSubmissionDeadlineDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }
                if (this.chkBidOpening.Checked == true)
                {
                    strSQL = strSQL + " AND (tblTenders.BidOpeningDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtOpeningDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (tblTenders.BidOpeningDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtOpeningDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }
                strSQL = strSQL + " Order By tblTenders.CustomerGuid, tblTenders.BidSubmissionDeadlineDate ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "List of Tenders";
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
        

       

    }
}
