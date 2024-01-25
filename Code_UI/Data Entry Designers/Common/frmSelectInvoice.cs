using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Pharma
{
    public partial class frmSelectInvoice : Form
    {
        private const string DialogCaption = "Search Invoice";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector cusSelector = null;

        #region Class Property Declarations

        bool blnCancel = false;
        public bool bCancel
        {
            get { return blnCancel; }
        }

        string strInvoiceGuid = "";
        public string InvoiceGuid
        {
            get { return strInvoiceGuid; }
        }

        string strInvoiceReferenceNumber = "";
        public string InvoiceReferenceNumber
        {
            get { return strInvoiceReferenceNumber; }
        }

        #endregion

        //private bool already_in = false;

        public frmSelectInvoice()
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
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle borderRect = new Rectangle(this.ClientRectangle.Location, this.ClientRectangle.Size);
            borderRect.Width -= 1;
            borderRect.Height -= 1;
            e.Graphics.DrawRectangle(new Pen(Color.CornflowerBlue), borderRect);
        }

        private void FillListFromDB()
        {
            try
            {
                int i = 0;

                DataTable tbl = new CManufacturers().GetRecords();
                if (tbl.Rows.Count <= 0) return;

                lvwTransactions.Items.Clear();

                for (i = 0; i < tbl.Rows.Count; i++)
                {


                    ListViewItem itmX = new ListViewItem(

                                                new string[] {
                                                                tbl.Rows[i]["TableRowGuid"].ToString(),
                                                                tbl.Rows[i]["code"].ToString(),
                                                                tbl.Rows[i]["Name"].ToString()
                                                               }
                                                                );

                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInvoicesList(bool NotIssued)
        {
            try
            {

                CInvoices objInvoices = new CInvoices();

                ArrayList ar = new ArrayList(objInvoices.GetList(NotIssued));
                this.lvwTransactions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CInvoices Invoice in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {Invoice.Tablerowguid.ToString(),
                                                                          Invoice.Customerguid.ToString(),  
                                                                          Invoice.OrganizationName == null ? string.Empty : Invoice.OrganizationName.ToString(), 
                                                                          Invoice.Referencenumber.ToString(),
                                                                          Invoice.Invoicedate == CSettings.MinDate ? string.Empty : Invoice.Invoicedate.ToString(CSettings.DateFormat),
                                                                          Invoice.Invoicetype.ToString(),                    
                                                                          Invoice.Duedate == CSettings.MinDate ? string.Empty : Invoice.Duedate.ToString(CSettings.DateFormat),
                                                                          Invoice.Preparedby.ToString(),
                                                                          Invoice.Prepareddate == CSettings.MinDate ? string.Empty : Invoice.Prepareddate.ToString(CSettings.DateFormat),                                                                                     
                                                                          Invoice.Checkedby.ToString(),
                                                                          Invoice.Checkeddate == CSettings.MinDate ? string.Empty : Invoice.Checkeddate.ToString(CSettings.DateFormat),
                                                                          Invoice.Deliveredby.ToString(),
                                                                          Invoice.Deliverydate == CSettings.MinDate ? string.Empty : Invoice.Deliverydate.ToString(CSettings.DateFormat),
                                                                          Invoice.Approvedby.ToString(),
                                                                          Invoice.Approvaldate == CSettings.MinDate ? string.Empty : Invoice.Approvaldate.ToString(CSettings.DateFormat),
                                                                          Invoice.Deliverystatus.ToString(),
                                                                          Invoice.Suppliesrequisitionguid.ToString(),
                                                                          Invoice.Discount.ToString()});
                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInvoicesList(string Customerguid, bool NotIssued)
        {
            try
            {

                CInvoices objInvoices = new CInvoices();

                ArrayList ar = new ArrayList(objInvoices.GetList(Customerguid, NotIssued));
                this.lvwTransactions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CInvoices Invoice in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {Invoice.Id.ToString(),
                                                                          Invoice.Customerguid.ToString(),  
                                                                          Invoice.OrganizationName == null ? string.Empty : Invoice.OrganizationName.ToString(), 
                                                                          Invoice.Referencenumber.ToString(),
                                                                          Invoice.Invoicedate == CSettings.MinDate ? string.Empty : Invoice.Invoicedate.ToString(CSettings.DateFormat),
                                                                          Invoice.Invoicetype.ToString(),                    
                                                                          Invoice.Duedate == CSettings.MinDate ? string.Empty : Invoice.Duedate.ToString(CSettings.DateFormat),
                                                                          Invoice.Preparedby.ToString(),
                                                                          Invoice.Prepareddate == CSettings.MinDate ? string.Empty : Invoice.Prepareddate.ToString(CSettings.DateFormat),                                                                                     
                                                                          Invoice.Checkedby.ToString(),
                                                                          Invoice.Checkeddate == CSettings.MinDate ? string.Empty : Invoice.Checkeddate.ToString(CSettings.DateFormat),
                                                                          Invoice.Deliveredby.ToString(),
                                                                          Invoice.Deliverydate == CSettings.MinDate ? string.Empty : Invoice.Deliverydate.ToString(CSettings.DateFormat),
                                                                          Invoice.Approvedby.ToString(),
                                                                          Invoice.Approvaldate == CSettings.MinDate ? string.Empty : Invoice.Approvaldate.ToString(CSettings.DateFormat),
                                                                          Invoice.Deliverystatus.ToString(),
                                                                          Invoice.Suppliesrequisitionguid.ToString(),
                                                                          Invoice.Discount.ToString()});
                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInvoicesList(DateTime RequestDateFrom, DateTime RequestDateTo, bool NotIssued)
        {
            try
            {

                CInvoices objInvoices = new CInvoices();

                ArrayList ar = new ArrayList(objInvoices.GetList(Convert.ToDateTime(RequestDateFrom.ToShortDateString()), Convert.ToDateTime(RequestDateTo.ToShortDateString()), NotIssued));
                this.lvwTransactions.Items.Clear();
                if (ar.Count <= 0) return;

                foreach (CInvoices Invoice in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {Invoice.Tablerowguid.ToString(),
                                                                          Invoice.Customerguid.ToString(),  
                                                                          Invoice.OrganizationName == null ? string.Empty : Invoice.OrganizationName.ToString(), 
                                                                          Invoice.Referencenumber.ToString(),
                                                                          Invoice.Invoicedate == CSettings.MinDate ? string.Empty : Invoice.Invoicedate.ToString(CSettings.DateFormat),
                                                                          Invoice.Invoicetype.ToString(),                    
                                                                          Invoice.Duedate == CSettings.MinDate ? string.Empty : Invoice.Duedate.ToString(CSettings.DateFormat),
                                                                          Invoice.Preparedby.ToString(),
                                                                          Invoice.Prepareddate == CSettings.MinDate ? string.Empty : Invoice.Prepareddate.ToString(CSettings.DateFormat),                                                                                     
                                                                          Invoice.Checkedby.ToString(),
                                                                          Invoice.Checkeddate == CSettings.MinDate ? string.Empty : Invoice.Checkeddate.ToString(CSettings.DateFormat),
                                                                          Invoice.Deliveredby.ToString(),
                                                                          Invoice.Deliverydate == CSettings.MinDate ? string.Empty : Invoice.Deliverydate.ToString(CSettings.DateFormat),
                                                                          Invoice.Approvedby.ToString(),
                                                                          Invoice.Approvaldate == CSettings.MinDate ? string.Empty : Invoice.Approvaldate.ToString(CSettings.DateFormat),
                                                                          Invoice.Deliverystatus.ToString(),
                                                                          Invoice.Suppliesrequisitionguid.ToString(),
                                                                          Invoice.Discount.ToString()});
                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInvoicesList(string Customerguid, DateTime RequestDateFrom, DateTime RequestDateTo, bool NotIssued)
        {
            try
            {

                CInvoices objInvoices = new CInvoices();

                ArrayList ar = new ArrayList(objInvoices.GetList(Customerguid, Convert.ToDateTime(RequestDateFrom.ToShortDateString()), Convert.ToDateTime(RequestDateTo.ToShortDateString()), NotIssued));
                this.lvwTransactions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CInvoices Invoice in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {Invoice.Tablerowguid.ToString(),
                                                                          Invoice.Customerguid.ToString(),  
                                                                          Invoice.OrganizationName == null ? string.Empty : Invoice.OrganizationName.ToString(), 
                                                                          Invoice.Referencenumber.ToString(),
                                                                          Invoice.Invoicedate == CSettings.MinDate ? string.Empty : Invoice.Invoicedate.ToString(CSettings.DateFormat),
                                                                          Invoice.Invoicetype.ToString(),                    
                                                                          Invoice.Duedate == CSettings.MinDate ? string.Empty : Invoice.Duedate.ToString(CSettings.DateFormat),
                                                                          Invoice.Preparedby.ToString(),
                                                                          Invoice.Prepareddate == CSettings.MinDate ? string.Empty : Invoice.Prepareddate.ToString(CSettings.DateFormat),                                                                                     
                                                                          Invoice.Checkedby.ToString(),
                                                                          Invoice.Checkeddate == CSettings.MinDate ? string.Empty : Invoice.Checkeddate.ToString(CSettings.DateFormat),
                                                                          Invoice.Deliveredby.ToString(),
                                                                          Invoice.Deliverydate == CSettings.MinDate ? string.Empty : Invoice.Deliverydate.ToString(CSettings.DateFormat),
                                                                          Invoice.Approvedby.ToString(),
                                                                          Invoice.Approvaldate == CSettings.MinDate ? string.Empty : Invoice.Approvaldate.ToString(CSettings.DateFormat),
                                                                          Invoice.Deliverystatus.ToString(),
                                                                          Invoice.Suppliesrequisitionguid.ToString(),
                                                                          Invoice.Discount.ToString()});
                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillList()
        {
            try
            {
                string strCustomerGuid = string.Empty;
                DateTime ValidDate;
                DateTime InvoiceDateFrom = CSettings.SQLServerMinDate;
                DateTime InvoiceDateTo = CSettings.MaxDate;
                bool FilterByCustomer = false;
                bool FilterByInvoiceDate = true;
                bool NotIssued;

                FilterByCustomer = false;
                if (this.txtCustomerFilter.Tag != null && this.txtCustomerFilter.Text != string.Empty)
                {
                    strCustomerGuid = this.txtCustomerFilter.Tag.ToString();
                    FilterByCustomer = true;
                }

                if (DateTime.TryParseExact(txtInvoiceDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    InvoiceDateFrom = ValidDate;
                    FilterByInvoiceDate = true;
                }

                if (DateTime.TryParseExact(txtInvoiceDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    InvoiceDateTo = ValidDate;
                    FilterByInvoiceDate = true;
                }

                NotIssued = false;
                if (chkNotIssued.CheckState == CheckState.Checked) NotIssued = true;

                if (!FilterByCustomer && !FilterByInvoiceDate)
                    FillInvoicesList(NotIssued);
                else if (FilterByCustomer && !FilterByInvoiceDate)
                    FillInvoicesList(strCustomerGuid, NotIssued);
                else if (!FilterByCustomer && FilterByInvoiceDate)
                    FillInvoicesList(InvoiceDateFrom, InvoiceDateTo, NotIssued);
                else if (FilterByCustomer && FilterByInvoiceDate)
                    FillInvoicesList(strCustomerGuid, InvoiceDateFrom, InvoiceDateTo, NotIssued);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                blnCancel = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem itmX = new ListViewItem();

                if (this.lvwTransactions.SelectedItems.Count <= 0) return;
                itmX = this.lvwTransactions.SelectedItems[0];

                strInvoiceGuid = itmX.SubItems[colGuid.Index].Text.ToString();
                strInvoiceReferenceNumber = itmX.SubItems[colReferenceNumber.Index].Text.ToString();
                blnCancel = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwTransactions_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.btnSelect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                FillList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchCustomerFilter_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectCustomer frmCus = new frmSelectCustomer();
                frmCus.ShowDialog();
                if (frmCus.bCancel == true) return;
                this.txtCustomerFilter.Tag = frmCus.Customerguid.ToString();
                this.txtCustomerFilter.Text = frmCus.CustomerName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            //    SearchCustomer(txtCustomerFilter, grpFilter.Left, grpFilter.Top);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCustomer(txtCustomerFilter, grpFilter.Left, grpFilter.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSelectInvoice_Load(object sender, EventArgs e)
        {
            this.txtInvoiceDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
            this.txtInvoiceDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
        }

    }
}