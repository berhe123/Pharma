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
    public partial class frmPerformanceBondReport : Form
    {
        private const string DialogCaption = "List of Invoices";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector cusSelector = null;

        public frmPerformanceBondReport()
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
            DateCheckBoxChanged(chkPerformanceBondIssunaceDate, txtPerformanceBondIssuanceDateFrom, txtPerformanceBondIssuanceDateTo);
            DateCheckBoxChanged(chkPerformanceBondReturnDate, txtPerformanceBondReturnDateFrom, txtPerformanceBondReturnDateTo);
           
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
            DateCheckBoxChanged(chkPerformanceBondIssunaceDate, txtPerformanceBondIssuanceDateFrom, txtPerformanceBondIssuanceDateTo);
        }       
        private void chkBidDocumentPurchaseDate_CheckedChanged(object sender, EventArgs e)
        {
            DateCheckBoxChanged(chkPerformanceBondReturnDate, txtPerformanceBondReturnDateFrom, txtPerformanceBondReturnDateTo);
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
                    ShowBidPerformance();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowBidPerformance()
        {
            try
            {
                DataTable dt = new DataTable();
                rptPerformaceBondList rpt = new rptPerformaceBondList();
                frmReportViewer frm = null;

                string Customerguid = "0";
                int BidStatus = -1;
                int BidType = -1;

                Customerguid = this.txtCustomerFilter.Text != string.Empty && this.txtCustomerFilter.Tag != null ? this.txtCustomerFilter.Tag.ToString() : "-1";
                BidStatus = Convert.ToInt32(CCommon.GetItemData(cboBidStatus));
                if (optInternationalBid.Checked)
                    BidType = (int)CCommon.TenderType.International;
                else if (optLocal.Checked)
                    BidType = (int)CCommon.TenderType.Local;
                else
                    BidType = -1;

                string strSQL = string.Empty;

                strSQL = strSQL + " Select tblTenders.Id,tblTenders.TableRowGuid,BidName,BidNumber,tblCustomers.Name as CustomerName,PerformanceBondIssuanceDate,PerformanceBondBankGuid,";
                strSQL = strSQL + " PerformanceBondBranch,PerformanceBondNumber,PerformanceBondReturnDate,PerformanceBondStatus,BidSecurityAmount,tblBanks.Name as BankName";
                strSQL = strSQL + " from tblTenders join tblCustomers on (tblTenders.CustomerGuid = tblCustomers.TableRowGuid)";
                strSQL = strSQL + " join tblBanks on (tblTenders.PerformanceBondBankGuid = tblBanks.TableRowGuid) ";               
                strSQL = strSQL + " Where 1=1 ";
                if (Customerguid != "-1" && Customerguid.Length > 0) strSQL = strSQL + " AND (tblTenders.CustomerGuid = '" + Customerguid + "') ";
                if (BidType != -1) strSQL = strSQL + " AND (tblTenders.BidType = " + BidType + ") ";
                if (BidStatus != -1) strSQL = strSQL + " AND (tblTenders.BidStatus = " + BidStatus + ") ";
                if (this.chkPerformanceBondIssunaceDate.Checked == true)
                {
                    strSQL = strSQL + " AND (tblTenders.PerformanceBondIssuanceDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtPerformanceBondIssuanceDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (tblTenders.PerformanceBondIssuanceDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtPerformanceBondIssuanceDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }                
                if (this.chkPerformanceBondReturnDate.Checked == true)
                {
                    strSQL = strSQL + " AND (tblTenders.PerformanceBondReturnDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtPerformanceBondReturnDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (tblTenders.PerformanceBondReturnDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtPerformanceBondReturnDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }
                strSQL = strSQL + " Order By PerformanceBondStatus,tblTenders.CustomerGuid, tblTenders.PerformanceBondReturnDate ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "List of Bid Bonds";
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
