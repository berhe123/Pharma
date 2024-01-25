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
    public partial class frmSelectSuppliesRequisition : Form
    {
        private const string DialogCaption = "Search Supplies Requisition";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector cusSelector = null;

        #region Class Property Declarations

        bool blnCancel = false;
        public bool bCancel
        {
            get { return blnCancel; }
        }

        string strSuppliesRequisitionGuid = "";
        public string Suppliesrequisitionguid
        {
            get { return strSuppliesRequisitionGuid; }
        }

        string strSuppliesRequisitionReferenceNumber = "";
        public string SuppliesRequisitionReferenceNumber
        {
            get { return strSuppliesRequisitionReferenceNumber; }
        }

        string strSuppliesRequisitionItemName = "";
        public string SuppliesRequisitionItemName
        {
            get { return strSuppliesRequisitionItemName; }
        }

        #endregion

        //private bool already_in = false;

        public frmSelectSuppliesRequisition()
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

        private void FillListFromDB()
        {
            try
            {
                int i = 0;

                DataTable tbl = new CManufacturers().GetRecords();
                if (tbl.Rows.Count <= 0) return;

                lvwRequisitions.Items.Clear();

                for (i = 0; i < tbl.Rows.Count; i++)
                {


                    ListViewItem itmX = new ListViewItem(

                                                new string[] {
                                                                tbl.Rows[i]["TableRowGuid"].ToString(),
                                                                tbl.Rows[i]["code"].ToString(),
                                                                tbl.Rows[i]["Name"].ToString()
                                                               }
                                                                );

                    this.lvwRequisitions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillRequisitionsList(bool NotConvertedToInvoice)
        {
            try
            {

                CSuppliesRequisitions objRequisitions = new CSuppliesRequisitions();

                ArrayList ar = new ArrayList(objRequisitions.GetList(NotConvertedToInvoice));
                this.lvwRequisitions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CSuppliesRequisitions Requisitions in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {Requisitions.Tablerowguid.ToString(), 
                                                                          Requisitions.OrganizationName == null ? string.Empty : Requisitions.OrganizationName.ToString(), 
                                                                          Requisitions.ReferenceNumber.ToString(), 
                                                                          Requisitions.Requestdate == CSettings.MinDate ? string.Empty : Requisitions.Requestdate.ToString(CSettings.DateFormat),
                                                                          Requisitions.Approvedby.ToString(),
                                                                          Requisitions.Approvaldate == CSettings.MinDate ? string.Empty : Requisitions.Approvaldate.ToString(CSettings.DateFormat),                    
                                                                          Requisitions.RequestedBy.ToString(),
                                                                          Requisitions.ItemName.ToString(),
                                                                          Requisitions.Customerguid.ToString()});
                    this.lvwRequisitions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillRequisitionsList(string Customerguid, bool NotConvertedToInvoice)
        {
            try
            {

                CSuppliesRequisitions objRequisitions = new CSuppliesRequisitions();

                ArrayList ar = new ArrayList(objRequisitions.GetList(Customerguid, NotConvertedToInvoice));
                this.lvwRequisitions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CSuppliesRequisitions Requisitions in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {Requisitions.Tablerowguid.ToString(), 
                                                                          Requisitions.OrganizationName == null ? string.Empty : Requisitions.OrganizationName.ToString(), 
                                                                          Requisitions.ReferenceNumber.ToString(), 
                                                                          Requisitions.Requestdate == CSettings.MinDate ? string.Empty : Requisitions.Requestdate.ToString(CSettings.DateFormat),
                                                                          Requisitions.Approvedby.ToString(),
                                                                          Requisitions.Approvaldate == CSettings.MinDate ? string.Empty : Requisitions.Approvaldate.ToString(CSettings.DateFormat),                    
                                                                          Requisitions.RequestedBy.ToString(),
                                                                          Requisitions.ItemName.ToString(),
                                                                          Requisitions.Customerguid.ToString()});
                    this.lvwRequisitions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillRequisitionsList(DateTime RequestDateFrom, DateTime RequestDateTo, bool NotConvertedToInvoice)
        {
            try
            {

                CSuppliesRequisitions objRequisitions = new CSuppliesRequisitions();

                ArrayList ar = new ArrayList(objRequisitions.GetList(Convert.ToDateTime(RequestDateFrom.ToShortDateString()), Convert.ToDateTime(RequestDateTo.ToShortDateString()), NotConvertedToInvoice));
                this.lvwRequisitions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CSuppliesRequisitions Requisitions in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {Requisitions.Tablerowguid.ToString(), 
                                                                          Requisitions.OrganizationName == null ? string.Empty : Requisitions.OrganizationName.ToString(), 
                                                                          Requisitions.ReferenceNumber.ToString(), 
                                                                          Requisitions.Requestdate == CSettings.MinDate ? string.Empty : Requisitions.Requestdate.ToString(CSettings.DateFormat),
                                                                          Requisitions.Approvedby.ToString(),
                                                                          Requisitions.Approvaldate == CSettings.MinDate ? string.Empty : Requisitions.Approvaldate.ToString(CSettings.DateFormat),                    
                                                                          Requisitions.RequestedBy.ToString(),
                                                                          Requisitions.ItemName.ToString(),
                                                                          Requisitions.Customerguid.ToString()});
                    this.lvwRequisitions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillRequisitionsList(string Customerguid, DateTime RequestDateFrom, DateTime RequestDateTo, bool NotConvertedToInvoice)
        {
            try
            {

                CSuppliesRequisitions objRequisitions = new CSuppliesRequisitions();

                ArrayList ar = new ArrayList(objRequisitions.GetList(Customerguid, Convert.ToDateTime(RequestDateFrom.ToShortDateString()), Convert.ToDateTime(RequestDateTo.ToShortDateString()), NotConvertedToInvoice));
                this.lvwRequisitions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CSuppliesRequisitions Requisitions in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {Requisitions.Tablerowguid.ToString(), 
                                                                          Requisitions.OrganizationName == null ? string.Empty : Requisitions.OrganizationName.ToString(), 
                                                                          Requisitions.ReferenceNumber.ToString(), 
                                                                          Requisitions.Requestdate == CSettings.MinDate ? string.Empty : Requisitions.Requestdate.ToString(CSettings.DateFormat),
                                                                          Requisitions.Approvedby.ToString(),
                                                                          Requisitions.Approvaldate == CSettings.MinDate ? string.Empty : Requisitions.Approvaldate.ToString(CSettings.DateFormat),                    
                                                                          Requisitions.RequestedBy.ToString(),
                                                                          Requisitions.ItemName.ToString(),
                                                                          Requisitions.Customerguid.ToString()});
                    this.lvwRequisitions.Items.Add(itmX);
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
                DateTime RequestDateFrom = CSettings.SQLServerMinDate;
                DateTime RequestDateTo = CSettings.MaxDate;
                bool FilterByCustomer = false;
                bool FilterByRequestDate = true;
                bool NotConvertedToInvoice;

                FilterByCustomer = false;
                if (this.txtCustomerFilter.Tag != null && this.txtCustomerFilter.Text != string.Empty)
                {
                    strCustomerGuid = this.txtCustomerFilter.Tag.ToString();
                    FilterByCustomer = true;
                }

                if (DateTime.TryParseExact(txtRequestDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    RequestDateFrom = ValidDate;
                    FilterByRequestDate = true;
                }

                if (DateTime.TryParseExact(txtRequestDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    RequestDateTo = ValidDate;
                    FilterByRequestDate = true;
                }

                NotConvertedToInvoice = false;
                if (chkNotConvertedToInvoice.CheckState == CheckState.Checked) NotConvertedToInvoice = true;

                if (!FilterByCustomer && !FilterByRequestDate)
                    FillRequisitionsList(NotConvertedToInvoice);
                else if (FilterByCustomer && !FilterByRequestDate)
                    FillRequisitionsList(strCustomerGuid, NotConvertedToInvoice);
                else if (!FilterByCustomer && FilterByRequestDate)
                    FillRequisitionsList(RequestDateFrom, RequestDateTo, NotConvertedToInvoice);
                else if (FilterByCustomer && FilterByRequestDate)
                    FillRequisitionsList(strCustomerGuid, RequestDateFrom, RequestDateTo, NotConvertedToInvoice);
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

                if (this.lvwRequisitions.SelectedItems.Count <= 0) return;
                itmX = this.lvwRequisitions.SelectedItems[0];

                strSuppliesRequisitionGuid = itmX.SubItems[colGuid.Index].Text.ToString();
                strSuppliesRequisitionReferenceNumber = itmX.SubItems[colReferenceNumber.Index].Text.ToString();
                blnCancel = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwRequisitions_DoubleClick(object sender, EventArgs e)
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
        private void lvwRequisitions_SelectedIndexChanged(object sender, EventArgs e)
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

        private void frmSelectSuppliesRequisition_Load(object sender, EventArgs e)
        {
            this.txtRequestDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
            this.txtRequestDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
        }

        private void lvwRequisitions_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

       

        

    }
}