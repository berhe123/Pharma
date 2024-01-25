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
    public partial class frmPaymentSettlement : Form
    {
        private const string DialogCaption = "Payment Settlement";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector childSelector = null;

        string CustomerGuidSearch = "0";       
        //private bool bNewCashCollections = true;
        private int CashCollectionsId = 0;
        public frmPaymentSettlement()
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
        private void frmPaymentRequest_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillPaymentTypeCombo(cboPaymentType);
                CCommon.FillComboBox(cboBank, "Select id,[name] from tblBanks", "id", "name");
                txtRequestDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtRequestDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
                CCommon.FillPaymentSettlementCombo(cboSettlementStatus, false);  
                NewCashCollections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        childSelector = new frmCustomerSelector();
                        childSelector.Width = txtCustomerName.Width;
                        childSelector.lvwCustomer.Items.Clear();
                        foreach (CSuppliesRequisitions Customer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Customer.Customerguid.ToString(),
                            Customer.OrganizationName.ToString()});
                            childSelector.lvwCustomer.Items.Add(itmX);
                        }
                        //childSelector.Owner = this;
                        //childSelector.x = 420;
                        //childSelector.y = 150;
                        //childSelector.ShowDialog();

                        //PopupWindowHelper popupHelper1 = new PopupWindowHelper();
                        //popupHelper1.AssignHandle(this.Handle);
                        Point location = this.PointToScreen(new Point(this.grpFilter.Left + this.txtCustomerName.Left, this.grpFilter.Top + this.txtCustomerName.Bottom));
                        popupHelper.ShowPopup(this, childSelector, location);

                        if (childSelector.blnSelected)
                        {
                            CustomerGuidSearch = childSelector.Customerguid;
                            txtCustomerName.Text = childSelector.OrganizationName;
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
        private void popupHelper_PopupClosed(object sender, PopupClosedEventArgs e)
        {
            try
            {
                if (childSelector.blnSelected)
                {
                    CustomerGuidSearch = childSelector.Customerguid;
                    txtCustomerName.Text = childSelector.OrganizationName;
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strCriteria = "";
                DateTime dteValidate;
                //strCriteria = strCriteria + " And DeliveryStatus = " + (int)CCommon.DeliveryStatus.Delivered;
                if(cboSettlementStatus.SelectedIndex > 0)
                {
                    if(Convert.ToInt32(CCommon.GetItemData(cboSettlementStatus)) == (int)CCommon.PaymentSettlement.NotSettled)
                        strCriteria = strCriteria + " And Settled = " + (int)CCommon.PaymentSettlement.NotSettled;
                    else
                        strCriteria = strCriteria + " And Settled = " + (int)CCommon.PaymentSettlement.Settled;
                }
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
                                                                                      Cash.OrganizationName.ToString(),
                                                                                      Cash.Requestdate.ToString(CSettings.DateFormat),
                                                                                      Cash.Referencenumber.ToString(),                    
                                                                                      Cash.Modeofpayment.ToString(),
                                                                                      Cash.Bankguid.ToString(),                                                                                     
                                                                                      Cash.Bankbranchname.ToString(),
                                                                                      Cash.Checkorcponumber.ToString(),
                                                                                      Cash.Checkorcpodate.ToString(CSettings.DateFormat),
                                                                                      Cash.Checkmaturitydate.ToString(CSettings.DateFormat),
                                                                                      Cash.Settled.ToString()});

                    this.lvwPaymentRequests.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
      
        private void cboPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboPaymentType.SelectedIndex != -1)
                    if (Convert.ToInt16(CCommon.GetItemData(cboPaymentType)) == (int)CCommon.PaymentType.Check | Convert.ToInt16(CCommon.GetItemData(cboPaymentType)) == (int)CCommon.PaymentType.CPO)
                        grbCheckCPOInfo.Enabled = true;
                    else
                        grbCheckCPOInfo.Enabled = false;
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
                if (!CCommon.SetRequiredMessage(txtSettlementDate, "Request date can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(cboPaymentType, "Mode of payment can not be empty", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtSettlementDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtSettlementDate, "Request Date must be in a valid Date Format", mValidator, lblMsg);
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
                //bNewCashCollections = true;
                CashCollectionsId = 0;
                txtOrganizationName.Text = string.Empty;
                txtSettlementDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtRequestDateShow.Text = string.Empty; 
                txtReferenceNoShow.Text = string.Empty;        
                cboPaymentType.SelectedIndex = 0;
                cboBank.SelectedIndex = -1;                
                txtBranchName.Text = "";             
                txtCheckCPONo.Text = string.Empty;               
                txtCheckCPODate.Text = DateTime.Today.ToString(CSettings.DateFormat);               
                //txtMaturityDate.Text = DateTime.Today.ToString(CSettings.DateFormat);     
                txtMaturityDate.Text = "";
                txtTotalReqAmount.Text = string.Empty;                
               
                lvwRequestInvoices.Items.Clear();
              

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
                objCashCollections.Referencenumber = txtReferenceNoShow.Text;
                objCashCollections.Modeofpayment = Convert.ToInt32(CCommon.GetItemData(cboPaymentType));
                objCashCollections.SettlementDate = Convert.ToDateTime(txtSettlementDate.Text, CSettings.Culture);
                objCashCollections.Settled = (int)CCommon.PaymentSettlement.Settled;
                if (Convert.ToInt32(CCommon.GetItemData(cboPaymentType)) != (int)CCommon.PaymentType.Cash)
                {
                    objCashCollections.Bankguid = CCommon.GetItemData(cboBank);
                    objCashCollections.Bankbranchname = Convert.ToString(txtBranchName.Text);
                    objCashCollections.Checkorcponumber = Convert.ToString(txtCheckCPONo.Text);
                    objCashCollections.Checkorcpodate = Convert.ToDateTime(txtCheckCPODate.Text,CSettings.Culture);
                    objCashCollections.Checkmaturitydate = Convert.ToDateTime(txtMaturityDate.Text,CSettings.Culture);
                }            
                //if (objCashCollections.Exists(bNewCashCollections) > 0)
                //{
                //    MessageBox.Show("There exists a request with the given reference number");
                //    return false;
                //}                
                
                objCashCollections.UpdateSettled();

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

                //bNewCashCollections = false;
                CashCollectionsId = Convert.ToInt32(itmX.SubItems[colRequestId.Index].Text);
                txtOrganizationName.Text = Convert.ToString(itmX.SubItems[colReqOrganizationName.Index].Text);
                txtRequestDateShow.Text = Convert.ToString(itmX.SubItems[colRequestDate.Index].Text);
                txtReferenceNoShow.Text = Convert.ToString(itmX.SubItems[colReferenceNo.Index].Text);
                txtSettlementDate.Text = Convert.ToString(itmX.SubItems[colRequestDate.Index].Text);
                if (Convert.ToInt32(itmX.SubItems[colSettled.Index].Text) == (int)CCommon.PaymentSettlement.Settled)
                {
                    cboPaymentType.SelectedIndex = CCommon.GetIndexByItemData(cboPaymentType, itmX.SubItems[colModeOfPayment.Index].Text, false);
                    cboBank.SelectedIndex = CCommon.GetIndexByItemData(cboBank, itmX.SubItems[colBankGuid.Index].Text, false);
                    txtBranchName.Text = Convert.ToString(itmX.SubItems[colBankBranchName.Index].Text);
                    txtCheckCPONo.Text = Convert.ToString(itmX.SubItems[colCheckOrCPONumber.Index].Text);
                    txtCheckCPODate.Text = Convert.ToString(itmX.SubItems[colCheckOrCPODate.Index].Text);
                    txtMaturityDate.Text = Convert.ToString(itmX.SubItems[colCheckMaturityDate.Index].Text);
                }
                FillRequestInvoiceList(CCashCollections.GetTableRowGuid(CashCollectionsId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FillRequestInvoiceList(string Cashcollectionguid)
        {
            try
            {

                CCashCollectionInvoices objCashCollectionInvoice = new CCashCollectionInvoices();

                ArrayList ar = new ArrayList(objCashCollectionInvoice.GetList(Cashcollectionguid));
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

        private void SavePaymentRequestOnInvoice()
        {
            try
            {
                CCashCollections objCash = new CCashCollections();
                foreach (ListViewItem itm in lvwRequestInvoices.Items)
                {
                    objCash.Invoiceguid = CInvoices.GetTableRowGuid(Convert.ToInt32(itm.SubItems[colReqInvoiceId.Index].Text));
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

        private void lvwPaymentRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwPaymentRequests.SelectedItems == null) return;
                if (lvwPaymentRequests.SelectedItems.Count <= 0) return;

                EditCashCollections();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSettle_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;
                decimal CheckCPOAmount = decimal.Zero;
                decimal TotalAmount = decimal.Zero;
                DialogResult ContinueSaving = DialogResult.Yes;

                if (Convert.ToInt32(CCommon.GetItemData(cboPaymentType)) != (int)CCommon.PaymentType.Cash & txtCheckCPOAmount.Text == string.Empty)
                {
                    MessageBox.Show("Check/CPO Amount can not be empty.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                TotalAmount = Convert.ToDecimal(txtTotalReqAmount.Text);
                if (Convert.ToInt32(CCommon.GetItemData(cboPaymentType)) != (int)CCommon.PaymentType.Cash)
                {
                    CheckCPOAmount = Convert.ToDecimal(txtCheckCPOAmount.Text);
                    if (CheckCPOAmount > TotalAmount)
                        ContinueSaving = MessageBox.Show("Check/CPO amount is greater than request amount. Are you sure you want to continue the settlement.", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    else if (CheckCPOAmount < TotalAmount)
                        ContinueSaving = MessageBox.Show("Check/CPO amount is less than request amount. Are you sure you want to continue the settlement.", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    ContinueSaving = MessageBox.Show("Have you received " + TotalAmount.ToString(CSettings.CurrencyFormat) + "Birr. If you are you sure you have received the amount shown click YES to continue the settlement otherwise click NO.", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }

                if (ContinueSaving == DialogResult.No) return;
                bSaved = SaveCashCollections();

                if (bSaved)
                    MessageBox.Show("The current Payment Request has been settled successfully.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.grpSettlement.Width = this.lblTitle.Width - this.grpSettlement.Left - 24;
                //this.grbCheckCPOInfo.Width = this.grpSettlement.Width - this.grbCheckCPOInfo.Left - 12;

                // Transactions listview
                this.lvwPaymentRequests.Height = this.Height - this.lvwPaymentRequests.Top - 65;

                // Detail Groupbox and Gridview
                this.lblTotalAmount.Top = this.lvwPaymentRequests.Top + this.lvwPaymentRequests.Height - this.lblTotalAmount.Height;
                this.txtTotalReqAmount.Top = this.lvwPaymentRequests.Top + this.lvwPaymentRequests.Height - this.txtTotalReqAmount.Height;
                this.lvwRequestInvoices.Height = this.Height - this.lvwRequestInvoices.Top - 65 - this.txtTotalReqAmount.Height - 2;
                //this.lvwRequestInvoices.Width = this.lblTitle.Width - this.lvwRequestInvoices.Left - 24;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPaymentSettlement_Resize(object sender, EventArgs e)
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

        private void txtCheckCPODate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime dateValue;
                double maturityDateLength = CSettings.PaymentSettlementCheckMaturityDateLength;
                bool result;

                result = DateTime.TryParseExact(txtCheckCPODate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dateValue);

                if (txtMaturityDate.Text.Length <= 0)
                    if (!result)
                        txtMaturityDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                    else
                    {
                        txtMaturityDate.Text = dateValue.AddDays(maturityDateLength).ToString(CSettings.DateFormat);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCashCollections();
        }

            
    }
}
