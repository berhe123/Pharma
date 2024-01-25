

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
    public partial class frmLocalPurchaseSettlements : Form
    {
        private const string DialogCaption = "Register Batch";
        private int LocalPurchaseOrderPaymentId = 0;
        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;
        private string ManufacturerGuidSearch = string.Empty;
        private string PurchaseOrderGuid = string.Empty;

        #region Purchase Order Form Code

        private bool already_in = false;

        public frmLocalPurchaseSettlements()
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
        private void frmPurchaseOrder_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    //FillPurchaseOrdersList();
                    lblMsg.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = null;
                CCommon.FillPaymentTypeCombo(cboPaymentType);
                CCommon.FillComboBox(cboBank, "Select TableRowGuid,[name] from tblBanks", "TableRowGuid", "name");                
                CCommon.FillPaymentSettlementCombo(cboSettlementStatus, false);
                NewLocalPurchasePayment();
                this.txtOrderDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtOrderDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
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
                this.panelToolbar.Width = this.lblTitle.Width - this.panelToolbar.Left;
                this.grpOrder.Width = this.lblTitle.Width - this.grpOrder.Left - 24;
                this.PaymentTabs.Width = this.lblTitle.Width - this.PaymentTabs.Left - 24;

                this.lvwOtherPayments.Width = this.tabOtherPayments.Width - this.lvwOtherPayments.Left - 24;

                // Transactions listview
                this.lvwPaymentRequests.Height = this.Height - this.lvwPaymentRequests.Top - 58;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmRegisterBatchs_Resize(object sender, EventArgs e)
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

        #endregion

        #region Purchase Order Code

        private int PurchaseOrdersId = 0;
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
        private void btnSearchManufacturerFilter_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectManufacturer frmManu = new frmSelectManufacturer();
                frmManu.ShowDialog();
                if (frmManu.bCancel == true) return;
                this.txtManufacturerFilter.Tag = frmManu.Manufacturerguid.ToString();
                this.txtManufacturerFilter.Text = frmManu.ManufacturerName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string strCriteria = "";
                DateTime dteValidate;
                //strCriteria = strCriteria + " And DeliveryStatus = " + (int)CCommon.DeliveryStatus.Delivered;
                if (cboSettlementStatus.SelectedIndex > 0)
                {
                    if (Convert.ToInt32(CCommon.GetItemData(cboSettlementStatus)) == (int)CCommon.PaymentSettlement.NotSettled)
                        strCriteria = strCriteria + " And Settled = " + (int)CCommon.PaymentSettlement.NotSettled;
                    else
                        strCriteria = strCriteria + " And Settled = " + (int)CCommon.PaymentSettlement.Settled;
                }
                if (ManufacturerGuidSearch != string.Empty & txtManufacturerFilter.Text != "")
                    strCriteria = strCriteria + " And tblLocalPurchaseOrders.SupplierGuid = '" + ManufacturerGuidSearch + "' ";
                if (txtOrderDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtOrderDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And OrderDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtOrderDateTo.Text != "")
                    if (DateTime.TryParseExact(txtOrderDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And OrderDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                FillPaymentRequestList(strCriteria);
                NewLocalPurchaseOrderPayment();
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

                CLocalPurchaseOrderSettlements objCash = new CLocalPurchaseOrderSettlements();

                ArrayList ar = new ArrayList(objCash.GetList(strCriteria));
                this.lvwPaymentRequests.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrderSettlements Cash in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Cash.Id.ToString(),
                                                                                      Cash.Suppliername.ToString(),
                                                                                      Cash.Orderdate.ToString(CSettings.DateFormat),
                                                                                      Cash.Ordernumber.ToString(),                    
                                                                                      Cash.Modeofpayment.ToString(),
                                                                                      Cash.Bankguid.ToString(),                                                                                     
                                                                                      Cash.Bankbranchname.ToString(),
                                                                                      Cash.Checkorcponumber.ToString(),
                                                                                      Cash.Checkorcpodate.ToString(CSettings.DateFormat),
                                                                                      Cash.Checkmaturitydate.ToString(CSettings.DateFormat),
                                                                                      Cash.Settled.ToString(),
                                                                                      Cash.Purchaseorderguid.ToString()});

                    this.lvwPaymentRequests.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrderDetailsListByParent(string Purchaseorderguid)
        {
            try
            {

                CLocalPurchaseOrderDetails objPurchaseOrderDetails = new CLocalPurchaseOrderDetails();

                ArrayList ar = new ArrayList(objPurchaseOrderDetails.GetList(Purchaseorderguid));
                this.lvwPurchaseOrderDetails.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrderDetails PurchaseOrderDetails in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               PurchaseOrderDetails.Id.ToString(), 
                                                                                      PurchaseOrderDetails.Purchaseorderguid.ToString(), 
                                                                                      PurchaseOrderDetails.Itemguid.ToString(), 
                                                                                      CItems.GetItemName(PurchaseOrderDetails.Itemguid).ToString(),
                                                                                      PurchaseOrderDetails.Quantity.ToString(), 
                                                                                      PurchaseOrderDetails.Priceperunit.ToString(),
                                                                                      (PurchaseOrderDetails.Quantity * PurchaseOrderDetails.Priceperunit).ToString()});
                    this.lvwPurchaseOrderDetails.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidPurchaseOrderSettlment()
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
        private bool SavePurchaseOrderSettlment()
        {
            try
            {

                if (!IsValidPurchaseOrderSettlment()) return false;

                CLocalPurchaseOrderSettlements objLocalPurchaseOrderSettlements = new CLocalPurchaseOrderSettlements();

                objLocalPurchaseOrderSettlements.Id = LocalPurchaseOrderPaymentId;
                objLocalPurchaseOrderSettlements.Purchaseorderguid = PurchaseOrderGuid;
                objLocalPurchaseOrderSettlements.Modeofpayment = Convert.ToInt32(CCommon.GetItemData(cboPaymentType));
                objLocalPurchaseOrderSettlements.Settlementdate = Convert.ToDateTime(txtSettlementDate.Text, CSettings.Culture);
                objLocalPurchaseOrderSettlements.Settled = (int)CCommon.PaymentSettlement.Settled;
                if (Convert.ToInt32(CCommon.GetItemData(cboPaymentType)) != (int)CCommon.PaymentType.Cash)
                {
                    objLocalPurchaseOrderSettlements.Bankguid = CCommon.GetItemData(cboBank);
                    objLocalPurchaseOrderSettlements.Bankbranchname = Convert.ToString(txtBranchName.Text);
                    objLocalPurchaseOrderSettlements.Checkorcponumber = Convert.ToString(txtCheckCPONo.Text);
                    objLocalPurchaseOrderSettlements.Checkorcpodate = Convert.ToDateTime(txtCheckCPODate.Text, CSettings.Culture);
                    objLocalPurchaseOrderSettlements.Checkmaturitydate = Convert.ToDateTime(txtMaturityDate.Text, CSettings.Culture);
                }
                objLocalPurchaseOrderSettlements.Userid = Program.strUserName;
                objLocalPurchaseOrderSettlements.Eventsource = (int)CCommon.EventSource.System;
                objLocalPurchaseOrderSettlements.Computername = System.Windows.Forms.SystemInformation.ComputerName;
                //if (objCashCollections.Exists(bNewCashCollections) > 0)
                //{
                //    MessageBox.Show("There exists a request with the given reference number");
                //    return false;
                //}                

                objLocalPurchaseOrderSettlements.Update();

                LocalPurchaseOrderPaymentId = objLocalPurchaseOrderSettlements.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewLocalPurchaseOrderPayment()
        {
            try
            {
                //bNewCashCollections = true;
                LocalPurchaseOrderPaymentId = 0;
                txtOrganizationName.Text = string.Empty;
                txtSettlementDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtOrderDate.Text = string.Empty;
                txtOrderNumber.Text = string.Empty;
                cboPaymentType.SelectedIndex = 0;
                cboBank.SelectedIndex = -1;
                txtBranchName.Text = "";
                txtCheckCPONo.Text = string.Empty;
                txtCheckCPODate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                //txtMaturityDate.Text = DateTime.Today.ToString(CSettings.DateFormat);     
                txtMaturityDate.Text = "";
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion               

        #region Other Payment Functions

        private void FillPurchaseOrderPaymentsList()
        {
            try
            {

                CLocalPurchaseOrderPayments objPurchaseOrderPayments = new CLocalPurchaseOrderPayments();

                ArrayList ar = new ArrayList(objPurchaseOrderPayments.GetList());
                this.lvwOtherPayments.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrderPayments PurchaseOrderPayments in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrderPayments.Id.ToString(), 
                                                                                      PurchaseOrderPayments.Purchaseorderguid.ToString(), 
                                                                                      PurchaseOrderPayments.Paymentreason.ToString(), 
                                                                                      CCommon.GetPaymentReasonText(PurchaseOrderPayments.Paymentreason), 
                                                                                      PurchaseOrderPayments.Paymentdate.ToString(), 
                                                                                      PurchaseOrderPayments.Referencenumber.ToString(), 
                                                                                      PurchaseOrderPayments.Amount.ToString()});
                    this.lvwOtherPayments.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrderPaymentsListByParent(string Purchaseorderguid)
        {
            try
            {

                CLocalPurchaseOrderPayments objPurchaseOrderPayments = new CLocalPurchaseOrderPayments();

                ArrayList ar = new ArrayList(objPurchaseOrderPayments.GetList(Purchaseorderguid));
                this.lvwOtherPayments.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrderPayments PurchaseOrderPayments in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] { PurchaseOrderPayments.Id.ToString(), 
                                                                                      PurchaseOrderPayments.Purchaseorderguid.ToString(), 
                                                                                      PurchaseOrderPayments.Paymentreason.ToString(), 
                                                                                      CCommon.GetPaymentReasonText(PurchaseOrderPayments.Paymentreason), 
                                                                                      PurchaseOrderPayments.Paymentdate.ToString(), 
                                                                                      PurchaseOrderPayments.Referencenumber.ToString(), 
                                                                                      PurchaseOrderPayments.Amount.ToString()});
                    this.lvwOtherPayments.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion        

        #region Local Purchase Order Settlement
        private bool IsValidLocalPurchasePayment()
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
        private void NewLocalPurchasePayment()
        {
            try
            {
                //bNewCashCollections = true;
                LocalPurchaseOrderPaymentId = 0;
               
                txtSettlementDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtOrderNumber.Text = string.Empty;
                txtOrderDate.Text = string.Empty;
                cboPaymentType.SelectedIndex = 0;
                cboBank.SelectedIndex = -1;
                txtBranchName.Text = "";
                txtCheckCPONo.Text = string.Empty;
                txtCheckCPODate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                //txtMaturityDate.Text = DateTime.Today.ToString(CSettings.DateFormat);     
                txtMaturityDate.Text = "";
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveLocalPurchasePayment()
        {
            //try
            //{

            //    if (!IsValidLocalPurchasePayment()) return false;

            //    CLocalPurchaseOrderSettlements objLocalPurchaseOrderSettlements = new CLocalPurchaseOrderSettlements();

            //    objLocalPurchaseOrderSettlements.Id = LocalPurchaseOrderPaymentId;
            //    objLocalPurchaseOrderSettlements.Referencenumber = txtReferenceNoShow.Text;
            //    objLocalPurchaseOrderSettlements.Modeofpayment = Convert.ToInt32(CCommon.GetItemData(cboPaymentType));
            //    objLocalPurchaseOrderSettlements.SettlementDate = Convert.ToDateTime(txtSettlementDate.Text, CSettings.Culture);
            //    objLocalPurchaseOrderSettlements.Settled = (int)CCommon.PaymentSettlement.Settled;
            //    if (Convert.ToInt32(CCommon.GetItemData(cboPaymentType)) != (int)CCommon.PaymentType.Cash)
            //    {
            //        objLocalPurchaseOrderSettlements.Bankguid = CCommon.GetItemData(cboBank);
            //        objLocalPurchaseOrderSettlements.Bankbranchname = Convert.ToString(txtBranchName.Text);
            //        objLocalPurchaseOrderSettlements.Checkorcponumber = Convert.ToString(txtCheckCPONo.Text);
            //        objLocalPurchaseOrderSettlements.Checkorcpodate = Convert.ToDateTime(txtCheckCPODate.Text, CSettings.Culture);
            //        objLocalPurchaseOrderSettlements.Checkmaturitydate = Convert.ToDateTime(txtMaturityDate.Text, CSettings.Culture);
            //    }

            //    //if (objCashCollections.Exists(bNewCashCollections) > 0)
            //    //{
            //    //    MessageBox.Show("There exists a request with the given reference number");
            //    //    return false;
            //    //}                

            //    objLocalPurchaseOrderSettlements.UpdateSettled();

            //    LocalPurchaseOrderPaymentId = objLocalPurchaseOrderSettlements.Id;
            return true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return false;
            //}
        }
        private void EditLocalPurchasePayment()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwPaymentRequests.SelectedItems[0];

                //bNewCashCollections = false;
                LocalPurchaseOrderPaymentId = Convert.ToInt32(itmX.SubItems[colRequestId.Index].Text);
                PurchaseOrderGuid = Convert.ToString(itmX.SubItems[colPurchaseOrderGuid.Index].Text);
                txtOrganizationName.Text = Convert.ToString(itmX.SubItems[colReqOrganizationName.Index].Text);
                txtOrderDate.Text = Convert.ToString(itmX.SubItems[colRequestDate.Index].Text);
                txtOrderNumber.Text = Convert.ToString(itmX.SubItems[colReferenceNo.Index].Text);
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
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        private void SearchManufacturer(TextBox SearchTextBox, int HorizontalOffset, int VerticalOffset)
        {
            try
            {
                if (SearchTextBox.Text != "")
                {
                    CManufacturers objManufacturer = new CManufacturers();
                    string nameLike = SearchTextBox.Text + "%";
                    ArrayList ar = new ArrayList(objManufacturer.GetList(nameLike, (int)CCommon.SupplierType.Local));
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        manSelector = new frmManufacturerSelector();
                        manSelector.SearchTextBox = SearchTextBox;
                        manSelector.Width = SearchTextBox.Width;
                        manSelector.lvwManufacturer.Items.Clear();
                        foreach (CManufacturers Manufacturer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Manufacturer.Tablerowguid.ToString(),
                            Manufacturer.Name.ToString()});
                            manSelector.lvwManufacturer.Items.Add(itmX);
                        }
                        Point location = this.PointToScreen(new Point(SearchTextBox.Left + HorizontalOffset, SearchTextBox.Bottom + VerticalOffset));
                        popupHelper.ShowPopup(this, manSelector, location);

                        if (manSelector.blnSelected)
                        {
                            SearchTextBox.Tag = manSelector.Manufacturerguid;
                            SearchTextBox.Text = manSelector.ManufacturerName;
                        }
                    }
                    else
                    {
                        CManufacturers Manufacturer = (CManufacturers)ar[0];
                        SearchTextBox.Tag = Manufacturer.Tablerowguid;
                        SearchTextBox.Text = Manufacturer.Name;
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
                if (manSelector.blnSelected)
                {
                    SearchTextBox = manSelector.SearchTextBox;
                    if (SearchTextBox != null)
                    {
                        SearchTextBox.Tag = manSelector.Manufacturerguid;
                        SearchTextBox.Text = manSelector.ManufacturerName;
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

        private void txtManufacturerFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //SearchManufacturer(txtManufacturerFilter, grpFilter.Left, grpFilter.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchManufacturerFilter1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchManufacturer(txtManufacturerFilter, grpFilter.Left, grpFilter.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lvwPaymentRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwPaymentRequests.SelectedItems == null) return;
                if (lvwPaymentRequests.SelectedItems.Count <= 0) return;
                NewLocalPurchaseOrderPayment();
                EditLocalPurchasePayment();
                FillPurchaseOrderDetailsListByParent(PurchaseOrderGuid);
                FillPurchaseOrderPaymentsListByParent(PurchaseOrderGuid);
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
                
                bSaved = SavePurchaseOrderSettlment();

                if (bSaved)
                    MessageBox.Show("The current Payment Request has been settled successfully.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewLocalPurchaseOrderPayment();
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

        private void lvwPurchaseOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

       
    }
}
