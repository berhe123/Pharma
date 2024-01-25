using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;

namespace Pharma
{
    public partial class frmPaymentRequest : Form
    {
        private const string DialogCaption = "Payment Request";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector childSelector = null;

        private PopupWindowHelper popupHelper1 = null;
        private frmCustomerSelector childSelector1 = null;

        string OrganizationGuidSearch = string.Empty;
        string CustomerGuidSearch = string.Empty;
        //string InvoiceCustomerGuidSearch = string.Empty;

        private bool bNewCashCollections = true;
        private int CashCollectionsId = 0;
        public frmPaymentRequest()
        {
            InitializeComponent();
            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

            popupHelper1 = new PopupWindowHelper();
            popupHelper1.PopupClosed += new PopupClosedEventHandler(popupHelper1_PopupClosed);
            popupHelper1.PopupCancel += new PopupCancelEventHandler(popupHelper1_PopupCancel);
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            popupHelper.AssignHandle(this.Handle);
            popupHelper1.AssignHandle(this.Handle);
        }
        private void frmPaymentRequest_Load(object sender, EventArgs e)
        {
            try
            {
                txtRequestDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtRequestDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtInvoiceDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtInvoiceDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);                
                NewCashCollections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillPaymentRequestList(string strCriteria)
        {
            try
            {

                CCashCollections objCash = new CCashCollections();

                ArrayList ar = new ArrayList(objCash.GetList(strCriteria));
                this.lvwPaymentRequests.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CCashCollections Cash in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Cash.Id.ToString(),
                                                                                      Cash.Customerguid.ToString(),
                                                                                      Cash.OrganizationName.ToString(),
                                                                                      Cash.Referencenumber.ToString(),
                                                                                      Cash.Requestdate.ToString(CSettings.DateFormat),
                                                                                      Cash.RequestIsVoid.ToString(),
                                                                                      Cash.VoidDate.ToString(CSettings.DateFormat)});

                    this.lvwPaymentRequests.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void FillInvoiceList(string strCriteria)
        {
            try
            {

                CInvoices objInvoice = new CInvoices();

                ArrayList ar = new ArrayList(objInvoice.GetListPaymentRequest(strCriteria));
                this.lvwTransactions.Items.Clear();
                if (ar.Count <= 0) return;

                foreach (CInvoices Invoice in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Invoice.Referencenumber.ToString(),
                                                                                      Invoice.OrganizationName.ToString(),
                                                                                      Invoice.Tablerowguid.ToString(),
                                                                                      Invoice.Customerguid.ToString(),                                                                                       
                                                                                      Invoice.Invoicedate.ToString(CSettings.DateFormat),
                                                                                      Invoice.Invoicetype.ToString(),                    
                                                                                      Invoice.Duedate.ToString(CSettings.DateFormat),
                                                                                      Invoice.Preparedby.ToString(),                                                                                     
                                                                                      Invoice.Checkedby.ToString(),
                                                                                      Invoice.Approvedby.ToString(),
                                                                                      Invoice.Deliveredby.ToString(),
                                                                                      Invoice.Prepareddate.ToString(CSettings.DateFormat),
                                                                                      Invoice.Checkeddate.ToString(CSettings.DateFormat),
                                                                                      Invoice.Approvaldate.ToString(CSettings.DateFormat),
                                                                                      Invoice.Deliverydate.ToString(CSettings.DateFormat),
                                                                                      Invoice.Deliverystatus.ToString(),
                                                                                      Invoice.Suppliesrequisitionguid.ToString()});

                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidCashCollections()
        {
            try
            {
                DateTime dteValidate;
                if (!CCommon.SetRequiredMessage(txtOrganizationName, "Customer name can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtRequestDate, "Request date can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtReferenceNo, "Referencenumber can not be empty", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtRequestDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtRequestDate, "Request Date must be in Date Format", mValidator, lblMsg);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewCashCollections()
        {
            try
            {
                bNewCashCollections = true;
                CashCollectionsId = 0;
                txtOrganizationName.Text = string.Empty;
                OrganizationGuidSearch = string.Empty;
                txtRequestDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                //txtRequestDateShow.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtReferenceNo.Text = string.Empty;
                //txtReferenceNoShow.Text = string.Empty;               
                txtTotalReqAmount.Text = string.Empty;

                this.txtOrganizationName.ReadOnly = false;
                this.btnFindOrganization.Enabled = true;

                lvwTransactions.Items.Clear();
                lvwRequestInvoices.Items.Clear();

                int maxReferenceNumber = CCashCollections.GetMaxReferenceNumber();
                this.txtReferenceNo.Text = "0" + (maxReferenceNumber + 1).ToString();

                this.txtVoidDate.Text = string.Empty;
                this.lblVoid.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveCashCollections()
        {
            try
            {
                if (!IsValidCashCollections()) return false;
                if (lvwRequestInvoices.Items.Count == 0) return false;

                CCashCollections objCashCollections = new CCashCollections();

                objCashCollections.Id = CashCollectionsId;
                objCashCollections.Customerguid = OrganizationGuidSearch;
                objCashCollections.Requestdate = Convert.ToDateTime(txtRequestDate.Text,CSettings.Culture);
                objCashCollections.Referencenumber = Convert.ToString(txtReferenceNo.Text);
                objCashCollections.Settled = (int)CCommon.PaymentSettlement.NotSettled;
                objCashCollections.CheckIsCashed = (int)CCommon.CheckStatus.NotCashed;

                if (objCashCollections.Exists(bNewCashCollections) > 0)
                {
                    MessageBox.Show("There exists a request with the given reference number");
                    return false;
                }

                if (bNewCashCollections)
                    objCashCollections.Insert();
                else
                    objCashCollections.Update();

                CashCollectionsId = objCashCollections.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void EditCashCollections()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwPaymentRequests.SelectedItems[0];

                bNewCashCollections = false;
                CashCollectionsId = Convert.ToInt32(itmX.SubItems[colRequestId.Index].Text);
                OrganizationGuidSearch = itmX.SubItems[colCustomerGuid.Index].Text;
                txtOrganizationName.Text = Convert.ToString(itmX.SubItems[colReqOrganizationName.Index].Text);
                //txtRequestDateShow.Text = Convert.ToString(itmX.SubItems[colRequestDate.Index].Text);
                //txtReferenceNoShow.Text = Convert.ToString(itmX.SubItems[colReferenceNo.Index].Text);

                txtRequestDate.Text = Convert.ToString(itmX.SubItems[colRequestDate.Index].Text);
                txtReferenceNo.Text = Convert.ToString(itmX.SubItems[colReferenceNo.Index].Text);

                int RequestIsVoid = Convert.ToInt32(itmX.SubItems[colVoid.Index].Text);
                if (RequestIsVoid == 0)
                {
                    this.lblVoid.Visible = false;
                    this.txtVoidDate.Text = txtRequestDate.Text;
                }
                else if (RequestIsVoid == 1)
                {
                    this.lblVoid.Visible = true;
                    this.txtVoidDate.Text = Convert.ToString(itmX.SubItems[colVoidDate.Index].Text);
                }
                FillRequestInvoiceList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FillRequestInvoiceList()
        {
            try
            {

                CCashCollectionInvoices objCashCollectionInvoice = new CCashCollectionInvoices();

                ArrayList ar = new ArrayList(objCashCollectionInvoice.GetList(CCashCollections.GetTableRowGuid(CashCollectionsId)));
                this.lvwRequestInvoices.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CCashCollectionInvoices Cash in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Cash.Id.ToString(),
                                                                                      Cash.Invoiceguid.ToString(),
                                                                                      Cash.InvoiceNo.ToString(),
                                                                                      Cash.ItemCount.ToString(), 
                                                                                      Cash.TotalAmount.ToString(CSettings.CurrencyFormat)});

                    this.lvwRequestInvoices.Items.Add(itmX);

                }
                decimal decTotalAmount;
                decTotalAmount = SumInvoiceTotals();
                txtTotalReqAmount.Text = decTotalAmount.ToString(CSettings.CurrencyFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private bool SaveCashCollectionInvoices()
        {
            if (lvwRequestInvoices.Items.Count == 0) return true;

            try
            {
                CCashCollectionInvoices objCashCollectionInvoice = new CCashCollectionInvoices();

                objCashCollectionInvoice.Cashcollectionguid = CCashCollections.GetTableRowGuid(this.CashCollectionsId);
                foreach (ListViewItem item in lvwRequestInvoices.Items)
                {
                    objCashCollectionInvoice.Invoiceguid = item.SubItems[colReqInvoiceGuid.Index].Text;
                    if (item.SubItems[colCashCollectionInvoiceId.Index].Text == string.Empty || item.SubItems[colCashCollectionInvoiceId.Index].Text == "0")
                    {
                        objCashCollectionInvoice.Insert();
                        item.SubItems[colCashCollectionInvoiceId.Index].Text = objCashCollectionInvoice.Id.ToString();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool DeleteCashCollectionInvoices()
        {
            if (lvwRequestInvoices.Items.Count == 0) return true;

            try
            {
                CCashCollectionInvoices objCashCollectionInvoice = new CCashCollectionInvoices();
                foreach (ListViewItem item in lvwRequestInvoices.Items)
                {
                    if (item.SubItems[colCashCollectionInvoiceId.Index].Text != string.Empty && item.SubItems[colCashCollectionInvoiceId.Index].Text != "0")
                    {
                        objCashCollectionInvoice.Id = Convert.ToInt32(item.SubItems[colCashCollectionInvoiceId.Index].Text);
                        objCashCollectionInvoice.Delete();
                        lvwRequestInvoices.Items.Remove(item);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void SavePaymentRequestOnInvoice()
        {
            try
            {
                CCashCollections objCash = new CCashCollections();
                foreach (ListViewItem itm in lvwRequestInvoices.Items)
                {
                    objCash.Invoiceguid = CInvoices.GetTableRowGuid(Convert.ToInt32(itm.SubItems[colReqInvoiceGuid.Index].Text));
                    objCash.Id = CashCollectionsId;
                    objCash.UpdateInvoice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal SumInvoiceTotals()
        {
            try
            {
                decimal decReturn = decimal.Zero;
                if (lvwRequestInvoices.Items.Count > 0)
                    foreach (ListViewItem itm in lvwRequestInvoices.Items)
                        decReturn = decReturn + Convert.ToDecimal(itm.SubItems[colInvoiceTotalAmount.Index].Text);
                return decReturn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return decimal.Zero;
            }
        }
        private bool VoidCashCollections()
        {
            try
            {
                CCashCollections objCashCollections = new CCashCollections();

                objCashCollections.Id = CashCollectionsId;
                objCashCollections.VoidDate = CDateTime.DateFromString(txtVoidDate.Text);
                objCashCollections.RequestIsVoid = 1;
                objCashCollections.UpdateVoid();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void SearchCustomerFilter()
        {
            try
            {
                if (txtCustomerName.Text != "")
                {
                    CSuppliesRequisitions objCustomer = new CSuppliesRequisitions();
                    objCustomer.OrganizationName = txtCustomerName.Text + "%";
                    ArrayList ar = new ArrayList(objCustomer.GetCustomerByName());
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        childSelector1 = new frmCustomerSelector();
                        childSelector1.Width = txtCustomerName.Width;
                        childSelector1.lvwCustomer.Items.Clear();
                        foreach (CSuppliesRequisitions Customer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Customer.Customerguid.ToString(),
                            Customer.OrganizationName.ToString()});
                            childSelector1.lvwCustomer.Items.Add(itmX);
                        }
                        //childSelector.Owner = this;
                        //childSelector.x = 420;
                        //childSelector.y = 150;
                        //childSelector.ShowDialog();

                        //PopupWindowHelper popupHelper1 = new PopupWindowHelper();
                        //popupHelper1.AssignHandle(this.Handle);
                        Point location = this.PointToScreen(new Point(this.grpFilter.Left + this.txtCustomerName.Left, this.grpFilter.Top + this.txtCustomerName.Bottom));
                        popupHelper1.ShowPopup(this, childSelector1, location);

                        if (childSelector1.blnSelected)
                        {
                            CustomerGuidSearch = childSelector1.Customerguid;
                            txtCustomerName.Text = childSelector1.OrganizationName;
                        }
                    }
                    else
                    {
                        CSuppliesRequisitions Customer = (CSuppliesRequisitions)ar[0];
                        CustomerGuidSearch = Customer.Customerguid;
                        txtCustomerName.Text = Customer.OrganizationName;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFindCustormer_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCustomerFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void popupHelper1_PopupClosed(object sender, PopupClosedEventArgs e)
        {
            try
            {
                if (childSelector1.blnSelected)
                {
                    CustomerGuidSearch = childSelector1.Customerguid;
                    txtCustomerName.Text = childSelector1.OrganizationName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void popupHelper1_PopupCancel(object sender, PopupCancelEventArgs e)
        {
            //Console.WriteLine("Popup Cancel, mouse clicked at {0}", e.CursorLocation);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strCriteria = "";
                DateTime dteValidate;
                //strCriteria = strCriteria + " And DeliveryStatus = " + (int)CCommon.DeliveryStatus.Delivered;
                //strCriteria = strCriteria + " And InvoiceType <> " + (int)CCommon.InvoiceType.FreeOfCharge;
                strCriteria = strCriteria + " And Settled = " + (int)CCommon.PaymentSettlement.NotSettled;

                if (CustomerGuidSearch != string.Empty & txtCustomerName.Text != "")
                    strCriteria = strCriteria + " And tblCashCollections.CustomerGuid = '" + CustomerGuidSearch + "' ";
                if (txtRequestDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtRequestDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And RequestDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtRequestDateTo.Text != "")
                    if (DateTime.TryParseExact(txtRequestDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And RequestDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
                FillPaymentRequestList(strCriteria);
                NewCashCollections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrganizationName.Text.Length <= 0)
                {
                    MessageBox.Show("Please select a cutomer first.", "Payment Request", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.txtOrganizationName.Focus();
                    return;
                }

                string strCriteria = "";
                DateTime dteValidate;

                strCriteria = strCriteria + " And DeliveryStatus = " + (int)CCommon.DeliveryStatus.Delivered;
                //strCriteria = strCriteria + " And (CashCollectionId is Null) ";

                if (OrganizationGuidSearch != string.Empty & txtOrganizationName.Text != "")
                    strCriteria = strCriteria + " And CustomerGuid = '" + OrganizationGuidSearch + "' ";
                if (txtInvoiceDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtInvoiceDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And InvoiceDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtInvoiceDateTo.Text != "")
                    if (DateTime.TryParseExact(txtInvoiceDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And InvoiceDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
                FillInvoiceList(strCriteria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTransactions.Items.Count > 0)
                    foreach (ListViewItem itm in lvwTransactions.Items)
                        itm.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTransactions.Items.Count > 0)
                    foreach (ListViewItem itm in lvwTransactions.Items)
                        itm.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnInvertSelection_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTransactions.Items.Count > 0)
                    foreach (ListViewItem itm in lvwTransactions.Items)
                    {
                        if (itm.Checked == true)
                            itm.Checked = false;
                        else
                            itm.Checked = true;
                    }
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSavePaymentRequest_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveCashCollections();
                if (bSaved = true & CashCollectionsId != 0)
                {
                    //SavePaymentRequestOnInvoice();
                    SaveCashCollectionInvoices();
                    NewCashCollections();
                    MessageBox.Show("Payment Request saved successfully.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void btnNewPaymentRequest_Click(object sender, EventArgs e)
        {
            try
            {
                NewCashCollections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwTransactions.Items.Count > 0)
                {
                    CCashCollections objCash = new CCashCollections();
                    foreach (ListViewItem itm in lvwTransactions.Items)
                    {
                        if (itm.Checked == true)
                        {
                            objCash.Invoiceguid = itm.SubItems[colInvoiceGuid.Index].Text;
                            objCash = objCash.GetInvoiceDescription();
                            ListViewItem lvwItem = new ListViewItem(new string[] { "0",
                                                                                objCash.Invoiceguid.ToString(),
                                                                                objCash.InvoiceNo.ToString(),
                                                                                objCash.ItemCount.ToString(),
                                                                                objCash.TotalAmount.ToString(CSettings.CurrencyFormat)});
                            lvwRequestInvoices.Items.Add(lvwItem);

                            this.txtOrganizationName.ReadOnly = true;
                            this.btnFindOrganization.Enabled = false;

                        }
                        decimal decTotalAmount;
                        decTotalAmount = SumInvoiceTotals();
                        txtTotalReqAmount.Text = decTotalAmount.ToString(CSettings.CurrencyFormat);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCustomer()
        {
            try
            {
                if (txtOrganizationName.Text != "")
                {
                    CSuppliesRequisitions objCustomer = new CSuppliesRequisitions();
                    objCustomer.OrganizationName = txtOrganizationName.Text + "%";
                    ArrayList ar = new ArrayList(objCustomer.GetCustomerByName());
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        childSelector = new frmCustomerSelector();
                        childSelector.Width = txtOrganizationName.Width;
                        childSelector.lvwCustomer.Items.Clear();
                        foreach (CSuppliesRequisitions Customer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Customer.Customerguid.ToString(),
                            Customer.OrganizationName.ToString()});
                            childSelector.lvwCustomer.Items.Add(itmX);
                        }
                        //childSelector.Owner = this;
                        //childSelector.x = 900;
                        //childSelector.y = 150;
                        //childSelector.ShowDialog();

                        //PopupWindowHelper popupHelper = new PopupWindowHelper();
                        //popupHelper.AssignHandle(this.Handle);
                        Point location = this.PointToScreen(new Point(this.grpRequest.Left + this.txtOrganizationName.Left, this.grpRequest.Top + this.txtOrganizationName.Bottom));
                        popupHelper.ShowPopup(this, childSelector, location);

                        if (childSelector.blnSelected)
                        {
                            OrganizationGuidSearch = childSelector.Customerguid;
                            txtOrganizationName.Text = childSelector.OrganizationName;
                            //CustomerHasLicense = GetCustomerLicense(intCustomerId);
                        }
                    }
                    else
                    {
                        CSuppliesRequisitions Customer = (CSuppliesRequisitions)ar[0];
                        OrganizationGuidSearch = Customer.Customerguid;
                        //CustomerHasLicense = true;
                        txtOrganizationName.Text = Customer.OrganizationName;
                        //CustomerHasLicense = GetCustomerLicense(intCustomerId);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFindOrganization_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCustomer();
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
                if (childSelector.blnSelected)
                {
                    OrganizationGuidSearch = childSelector.Customerguid;
                    txtOrganizationName.Text = childSelector.OrganizationName;
                    //CustomerHasLicense = GetCustomerLicense(intCustomerId);
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
        private void btnDeletePaymentRequest_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!IsProformaEditAllowed()) return;

                if (MessageBox.Show("Are you sure to delete this record?", "Payment Request", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CCashCollections objCashCollection = new CCashCollections();
                    CCashCollectionInvoices objCashCollectionInvoice = new CCashCollectionInvoices();

                    objCashCollection.Id = Convert.ToInt32(lvwPaymentRequests.SelectedItems[0].SubItems[colRequestId.Index].Text);
                    DeleteCashCollectionInvoices();
                    objCashCollection.Delete();
                    lvwPaymentRequests.Items.Remove(lvwPaymentRequests.SelectedItems[0]);

                    NewCashCollections();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void lvwPaymentRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwPaymentRequests.SelectedItems == null) return;
                if (lvwPaymentRequests.SelectedItems.Count <= 0) return;

                EditCashCollections();

                this.txtOrganizationName.ReadOnly = true;
                this.btnFindOrganization.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResizeControls()
        {
            try
            {
                // Title label
                this.lblTitle.Width = this.Width + 1;

                // Line just under the title label
                this.line3.Width = this.lblTitle.Width;

                // Main toolbar
                this.tsbToolBar.Width = this.lblTitle.Width - this.tsbToolBar.Left;
                this.grpRequest.Width = this.lblTitle.Width - this.grpRequest.Left - 24;
                this.grpVoid.Width = this.lblTitle.Width - this.grpVoid.Left - 24;

                // Transactions listview
                this.lvwPaymentRequests.Height = this.Height - this.lvwPaymentRequests.Top - 65;

                // Detail Groupbox and Gridview
                this.lvwTransactions.Height = this.Height - this.lvwTransactions.Top - 65;
                this.lvwRequestInvoices.Width = this.lblTitle.Width - this.lvwRequestInvoices.Left - 24;
                //this.lvwRequestInvoices.Height = this.Height - this.lvwRequestInvoices.Top - 65;
                this.lblTotalAmount.Top = this.lvwPaymentRequests.Top + this.lvwPaymentRequests.Height - this.lblTotalAmount.Height;
                this.txtTotalReqAmount.Top = this.lvwPaymentRequests.Top + this.lvwPaymentRequests.Height - this.txtTotalReqAmount.Height;
                this.lvwRequestInvoices.Height = this.Height - this.lvwRequestInvoices.Top - 65 - this.txtTotalReqAmount.Height - 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPaymentRequest_Resize(object sender, EventArgs e)
        {
            try
            {
                ResizeControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPaymentRequest()
        {
            DataTable dt = new DataTable();
            rptPaymentRequest rpt = new rptPaymentRequest();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   TOP (100) PERCENT tblCashCollections.TableRowGuid, tblCashCollections.RequestDate, tblCashCollections.ReferenceNumber, tblCashCollectionInvoices.TableRowGuid as DetailGuid, ";
                strSQL = strSQL + "                 tblCustomers.Name AS CustomerName, tblCustomers.MailingAddress, tblCustomers.email, tblCustomers.Tel2, tblCustomers.Tel1, tblCustomers.Fax,   ";
                strSQL = strSQL + "                 'Tel: ' + tblCustomers.Tel1 + ', Fax: ' + tblCustomers.Fax + ', Email: ' + tblCustomers.email AS Address1,   ";
                strSQL = strSQL + "                 tblCashCollections.CustomerGuid, tblInvoices.TableRowGuid AS InvoiceGuid, tblInvoices.ReferenceNumber AS InvoiceReferenceNumber, tblInvoices.InvoiceDate, tblInvoices.InvoiceType,   ";
                strSQL = strSQL + "                 tblInvoices.DueDate, tblInvoices.PreparedBy, tblInvoices.CheckedBy, tblInvoices.ApprovedBy, tblInvoices.DeliveredBy,   ";
                strSQL = strSQL + "                 tblInvoices.PreparedDate, tblInvoices.CheckedDate, tblInvoices.ApprovalDate, tblInvoices.DeliveryDate,   ";
                strSQL = strSQL + "                 tblInvoices.DeliveryStatus, tblInvoices.SuppliesRequisitionGuid, tblInvoices.CashCollectionGuid, tblBatchs.BatchNumber,   ";
                strSQL = strSQL + "                 tblInvoiceDetails.UnitPrice AS PricePerUnit, tblInvoiceDetails.Quantity, tblInvoiceDetails.TableRowGuid AS InvoiceDetailGuid,  ";
                strSQL = strSQL + "                 tblInvoiceDetails.UnitPrice * tblInvoiceDetails.Quantity AS SubTotal, tblInvoiceDetails.UnitPrice * tblInvoiceDetails.Quantity * tblInvoices.Discount * 0.01 AS Discount, ";
                strSQL = strSQL + "                 tblInvoiceDetails.UnitPrice * tblInvoiceDetails.Quantity - tblInvoiceDetails.UnitPrice * tblInvoiceDetails.Quantity * tblInvoices.Discount * 0.01 AS InvoiceTotal ";
                strSQL = strSQL + " FROM      tblCashCollections INNER JOIN tblCashCollectionInvoices ";
                strSQL = strSQL + "                  ON tblCashCollections.TableRowGuid = tblCashCollectionInvoices.CashCollectionGuid  ";
                strSQL = strSQL + "             INNER JOIN tblInvoices ";
                strSQL = strSQL + "                  ON tblCashCollectionInvoices.InvoiceGuid = tblInvoices.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblInvoiceDetails ";
                strSQL = strSQL + "                  ON tblInvoiceDetails.InvoiceGuid = tblInvoices.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblBatchs  ";
                strSQL = strSQL + "                  ON tblInvoiceDetails.BatchGuid = tblBatchs.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblCustomers  ";
                strSQL = strSQL + "                  ON tblInvoices.CustomerGuid = tblCustomers.TableRowGuid  ";
                strSQL = strSQL + " Where tblCashCollections.TableRowGuid = '" + CCashCollections.GetTableRowGuid(CashCollectionsId) + "' ";
                strSQL = strSQL + " ORDER BY InvoiceDate, InvoiceReferenceNumber  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Payment Request";
                    frm.Show();
                }
                else
                    MessageBox.Show("No Record Found", "Report Generation");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintPaymentRequest_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPaymentRequest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SearchCustomerFilter();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtOrganizationName_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SearchCustomer();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            try
            {
                if (VoidCashCollections())
                    MessageBox.Show("The current Payment Request has been made void.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                  
    }
}
