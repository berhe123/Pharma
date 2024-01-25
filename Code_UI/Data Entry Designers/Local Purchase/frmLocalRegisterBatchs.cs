

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
    public partial class frmLocalRegisterBatchs : Form
    {
        private const string DialogCaption = "Register Batch";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        #region Purchase Order Form Code

        private bool already_in = false;

        public frmLocalRegisterBatchs()
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
                this.lvwPurchaseOrders.Height = this.Height - this.lvwPurchaseOrders.Top - 58;

                // Detail Groupbox
                this.tabControlBatchs.Height = this.Height - this.tabControlBatchs.Top - 58;
                this.tabControlBatchs.Width = this.lblTitle.Width - this.tabControlBatchs.Left - 24;

                this.grpBatch.Width = this.tabPageBatchs.Width - this.grpBatch.Left - 24;

                this.lvwBatchs.Height = this.tabPageBatchs.Height - this.lvwBatchs.Top - 12;
                this.lvwBatchs.Width = this.tabPageBatchs.Width - this.lvwBatchs.Left - 24;
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

        private bool IsValidPurchaseOrders()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtOrderNumber, "Order number can not be empty", mValidator, lblMsg))
                    return false;
                //if (!CCommon.SetRequiredMessage(dtOrderDate, "Order date can not be empty", mValidator, lblMsg))
                //    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewPurchaseOrders()
        {
            try
            {
                PurchaseOrdersId = 0;
                txtOrderNumber.Text = String.Empty;
                txtOrderDate.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool FindPurchaseOrders()
        {
            try
            {
                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();
                DataTable dt = new DataTable();

                objPurchaseOrders.Id = PurchaseOrdersId;
                dt = objPurchaseOrders.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    PurchaseOrdersId = objPurchaseOrders.Id;
                    txtOrderNumber.Text = Convert.ToString(objPurchaseOrders.Ordernumber);
                    if (objPurchaseOrders.Orderdate != DateTime.MinValue)
                        txtOrderDate.Text = objPurchaseOrders.Orderdate.ToString(CSettings.DateFormat);
                    else
                        txtOrderDate.Text = string.Empty;

                    return true;
                }
                else
                {
                    MessageBox.Show("Record not found! ", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void EditPurchaseOrders()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwPurchaseOrders.SelectedItems[0];

                PurchaseOrdersId = Convert.ToInt32(itmX.SubItems[colAutoID.Index].Text);
                txtOrderNumber.Text = Convert.ToString(itmX.SubItems[colOrderNumber.Index].Text);
                txtOrderDate.Text = itmX.SubItems[colOrderDate.Index].Text;

                FillPurchaseOrderAllPaymentsList();
                FillBatchsListByParent(CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId));
                NewBatchs();

                //this.FindPurchaseOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrderAllPaymentsList()
        {
            try
            {
                FillPurchaseOrderPaymentsListByParent(CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList()
        {
            try
            {

                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();

                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(false));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Id.ToString(), 
                                                                                      PurchaseOrders.Supplierguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofpayment.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(string Manufacturerguid)
        {
            try
            {

                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();

                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Manufacturerguid, false));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Id.ToString(), 
                                                                                      PurchaseOrders.Supplierguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofpayment.ToString()});

                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(DateTime ProformaDateFrom, DateTime ProformaDateTo)
        {
            try
            {

                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();

                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(ProformaDateFrom, ProformaDateTo, false));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Id.ToString(), 
                                                                                      PurchaseOrders.Supplierguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofpayment.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(string Manufacturerguid, DateTime ProformaDateFrom, DateTime ProformaDateTo)
        {
            try
            {

                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();

                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Manufacturerguid, ProformaDateFrom, ProformaDateTo, false));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Id.ToString(), 
                                                                                      PurchaseOrders.Supplierguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofpayment.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
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
        private void lvwPurchaseOrders_DoubleClick(object sender, EventArgs e)
        {
        }
        private void lvwPurchaseOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwPurchaseOrders.SelectedItems == null) return;
                if (lvwPurchaseOrders.SelectedItems.Count <= 0) return;

                EditPurchaseOrders();
                FillPurchaseOrderDetailsListByParent(CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId));

                string strSQL = "";
                strSQL = strSQL + " select (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName ) as ItemName, tblitems.TableRowGuid from tblitems ";
                strSQL = strSQL + " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
                strSQL = strSQL + " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
                strSQL = strSQL + " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
                strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
                strSQL = strSQL + " inner join tblLocalPurchaseOrderDetails on tblLocalPurchaseOrderDetails.ItemGuid =tblItems.TableRowGuid";
                strSQL = strSQL + "  where tblItems.TableRowGuid in (select ItemGuid from tblLocalPurchaseOrderDetails where PurchaseOrderGuid = '" + CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId) + "') Order By ItemName"; 
               


                CCommon.FillComboBox(this.cboBatchsItemid,strSQL, "TableRowGuid", "ItemName");
                
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchPurchaseOrders_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.PurchaseOrdersId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindPurchaseOrders();
        }
        private void btnFindPurchaseOrders_Click(object sender, EventArgs e)
        {
            try
            {
                FindPurchaseOrders();
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
                FillList();
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
                string Manufacturerguid = string.Empty;
                DateTime ValidDate;
                DateTime OrderDateFrom = CSettings.SQLServerMinDate;
                DateTime OrderDateTo = CSettings.MaxDate;
                bool FilterByManufacturer = false;
                bool FilterByOrderDate = true;
                //bool NotReceived = false; 

                if (this.txtManufacturerFilter.Tag != null && this.txtManufacturerFilter.Text != string.Empty)
                {
                    Manufacturerguid = this.txtManufacturerFilter.Tag.ToString();
                    FilterByManufacturer = true;
                }

                if (DateTime.TryParseExact(txtOrderDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    OrderDateFrom = ValidDate;
                    FilterByOrderDate = true;
                }

                if (DateTime.TryParseExact(txtOrderDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    OrderDateTo = ValidDate;
                    FilterByOrderDate = true;
                }

                if (!FilterByManufacturer && !FilterByOrderDate)
                    FillPurchaseOrdersList();
                else if (FilterByManufacturer && !FilterByOrderDate)
                    FillPurchaseOrdersList(Manufacturerguid);
                else if (!FilterByManufacturer && FilterByOrderDate)
                    FillPurchaseOrdersList(OrderDateFrom, OrderDateTo);
                else if (FilterByManufacturer && FilterByOrderDate)
                    FillPurchaseOrdersList(Manufacturerguid, OrderDateFrom, OrderDateTo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Purchase Order Detail Code

        private void FillPurchaseOrderDetailsList()
        {
            try
            {

                CLocalPurchaseOrderDetails objPurchaseOrderDetails = new CLocalPurchaseOrderDetails();

                ArrayList ar = new ArrayList(objPurchaseOrderDetails.GetList());
                this.lvwPurchaseOrderDetails.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrderDetails PurchaseOrderDetails in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               PurchaseOrderDetails.Id.ToString(), 
                                                                                      PurchaseOrderDetails.Purchaseorderguid.ToString(), 
                                                                                      PurchaseOrderDetails.Itemguid.ToString(), 
                                                                                      CItems.GetItemName(PurchaseOrderDetails.Itemguid).ToString(),
                                                                                      PurchaseOrderDetails.Quantity.ToString(), 
                                                                                      PurchaseOrderDetails.Priceperunit.ToString()});
                    this.lvwPurchaseOrderDetails.Items.Add(itmX);
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

        private void GetItemDetailsForBatch(ListViewItem selectedItem)
        {
            try
            {
                string itemGuid = selectedItem.SubItems[colPurchaseOrderDetailsItemGuid.Index].Text;
                decimal quantity = Convert.ToDecimal(selectedItem.SubItems[colPurchaseOrderDetailsQuantity.Index].Text);
                decimal pricePerUnit = Convert.ToDecimal(selectedItem.SubItems[colPurchaseOrderDetailsPriceperunit.Index].Text);

                decimal quantityOfExistingBatch = CCommonListView.GetListTotal(lvwBatchs, colBatchsQuantity, colBatchsItemGuid, itemGuid.ToString());

                this.NewBatchs();
                cboBatchsItemid.SelectedIndex = CCommon.GetIndexByItemData(cboBatchsItemid, itemGuid.ToString(), true);
                this.txtBatchsQuantity.Text = (quantity - quantityOfExistingBatch).ToString();
                this.txtBatchsPriceperunit.Text = pricePerUnit.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwPurchaseOrderDetails_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (lvwPurchaseOrderDetails.SelectedItems == null) return;
                if (lvwPurchaseOrderDetails.SelectedItems.Count <= 0) return;

                GetItemDetailsForBatch(lvwPurchaseOrderDetails.SelectedItems[0]);
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

        #region Batchs Functions

        private bool bNewBatchs = true;
        private int BatchsId = 0;

        private bool IsValidBatchs()
        {
            try
            {
                DateTime ValidDate;

                if (!CCommon.SetRequiredMessage(txtOrderNumber, "Please select a purchase order", mValidator, lblMsg))
                    return false;
                if (CCommon.GetItemData(cboBatchsItemid) == "-1")
                {
                    CCommon.SetMessage(cboBatchsItemid, "Please select the item", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtBatchsBatchnumber, "Batch number can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtBatchsQuantity, "Quantity can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtBatchsPriceperunit, "Price per unit can not be empty", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtBatchsManufactureddate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    CCommon.SetMessage(txtBatchsManufactureddate, "Please enter a valid manufacturing date", mValidator, lblMsg);
                    return false;
                }
                if (!DateTime.TryParseExact(txtBatchsExpirydate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    CCommon.SetMessage(txtBatchsExpirydate, "Please enter a valid expiry date", mValidator, lblMsg);
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
        private void NewBatchs()
        {
            try
            {
                bNewBatchs = true;
                BatchsId = 0;
                txtBatchsBatchnumber.Text = String.Empty;
                cboBatchsItemid.SelectedIndex = -1;
                txtBatchsQuantity.Text = String.Empty;
                txtBatchsPriceperunit.Text = String.Empty;
                //txtBatchsFreightpayments.Text = String.Empty;
                //txtBatchsInsurancepayments.Text = String.Empty;
                //txtBatchsBankpayments.Text = String.Empty;
                //txtBatchsOtherpayments.Text = String.Empty;
                //txtBatchsSuggestedsaleprice.Text = String.Empty;
                //txtBatchsSaleprice.Text = String.Empty;
                txtBatchsManufactureddate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtBatchsExpirydate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtBatchsShelfLife.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveBatchs()
        {
            try
            {
                if (!IsValidBatchs()) return false;

                CBatchs objBatchs = new CBatchs();

                objBatchs.Id = BatchsId;
                objBatchs.Purchaseorderguid = CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId);
                objBatchs.Batchnumber = Convert.ToString(txtBatchsBatchnumber.Text);
                objBatchs.Itemguid = CCommon.GetItemData(cboBatchsItemid);
                objBatchs.Quantity = Convert.ToDecimal(txtBatchsQuantity.Text);
                objBatchs.Priceperunit = Convert.ToDecimal(txtBatchsPriceperunit.Text);
                //objBatchs.Freightpayments = Convert.ToDecimal(txtBatchsFreightpayments.Text);
                //objBatchs.Insurancepayments = Convert.ToDecimal(txtBatchsInsurancepayments.Text);
                //objBatchs.Bankpayments = Convert.ToDecimal(txtBatchsBankpayments.Text);
                //objBatchs.Otherpayments = Convert.ToDecimal(txtBatchsOtherpayments.Text);
                //objBatchs.Suggestedsaleprice = Convert.ToDecimal(txtBatchsSuggestedsaleprice.Text);
                //objBatchs.Saleprice = Convert.ToDecimal(txtBatchsSaleprice.Text);
                objBatchs.Manufactureddate = CDateTime.DateFromString(txtBatchsManufactureddate.Text);
                objBatchs.Expirydate = CDateTime.DateFromString(txtBatchsExpirydate.Text);
                objBatchs.PurchaseOrderType = (int)CCommon.SupplierType.Local;
                objBatchs.Shelflife = Convert.ToString(txtBatchsShelfLife.Text);

                if (objBatchs.Exists(bNewBatchs) > 0)
                {
                    MessageBox.Show("There exists a batch record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (!objBatchs.QuantityIsGreatherThanPurchaseOrder(bNewBatchs))
                {
                    MessageBox.Show("The quantity for the batches can not be greater than the quantity of the purchase order.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewBatchs)
                    objBatchs.Insert();
                else
                    objBatchs.UpdateBachOnly();

                BatchsId = objBatchs.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindBatchs()
        {
            try
            {
                CBatchs objBatchs = new CBatchs();
                DataTable dt = new DataTable();

                objBatchs.Id = BatchsId;
                dt = objBatchs.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    BatchsId = objBatchs.Id;
                    txtOrderNumber.Tag = Convert.ToString(objBatchs.Purchaseorderguid);
                    txtBatchsBatchnumber.Text = Convert.ToString(objBatchs.Batchnumber);
                    cboBatchsItemid.SelectedIndex = CCommon.GetIndexByItemData(cboBatchsItemid, objBatchs.Itemguid.ToString(), true);
                    txtBatchsQuantity.Text = Convert.ToString(objBatchs.Quantity);
                    txtBatchsPriceperunit.Text = Convert.ToString(objBatchs.Priceperunit);
                    //txtBatchsFreightpayments.Text = Convert.ToString(objBatchs.Freightpayments);
                    //txtBatchsInsurancepayments.Text = Convert.ToString(objBatchs.Insurancepayments);
                    //txtBatchsBankpayments.Text = Convert.ToString(objBatchs.Bankpayments);
                    //txtBatchsOtherpayments.Text = Convert.ToString(objBatchs.Otherpayments);
                    //txtBatchsSuggestedsaleprice.Text = Convert.ToString(objBatchs.Suggestedsaleprice);
                    //txtBatchsSaleprice.Text = Convert.ToString(objBatchs.Saleprice);
                    if (objBatchs.Manufactureddate != DateTime.MinValue)
                    {
                        txtBatchsManufactureddate.Text = objBatchs.Manufactureddate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtBatchsManufactureddate.Text = string.Empty;
                    }
                    if (objBatchs.Expirydate != DateTime.MinValue)
                    {
                        txtBatchsExpirydate.Text = objBatchs.Expirydate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtBatchsExpirydate.Text = string.Empty;
                    }
                    txtBatchsShelfLife.Text = Convert.ToString(objBatchs.Shelflife);
                    return true;
                }
                else
                {
                    MessageBox.Show("Record not found! ", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private void EditBatchs()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwBatchs.SelectedItems[0];

                bNewBatchs = false;
                BatchsId = Convert.ToInt32(itmX.SubItems[colBatchsId.Index].Text);
                txtOrderNumber.Tag = Convert.ToString(itmX.SubItems[colBatchsPurchaseOrderGuid.Index].Text);
                txtBatchsBatchnumber.Text = Convert.ToString(itmX.SubItems[colBatchsBatchnumber.Index].Text);
                cboBatchsItemid.SelectedIndex = CCommon.GetIndexByItemData(cboBatchsItemid, itmX.SubItems[colBatchsItemGuid.Index].Text, true);
                txtBatchsQuantity.Text = Convert.ToString(itmX.SubItems[colBatchsQuantity.Index].Text);
                txtBatchsPriceperunit.Text = Convert.ToString(itmX.SubItems[colBatchsPriceperunit.Index].Text);
                txtBatchsManufactureddate.Text = itmX.SubItems[colBatchsManufactureddate.Index].Text;
                txtBatchsExpirydate.Text = itmX.SubItems[colBatchsExpirydate.Index].Text;
                txtBatchsShelfLife.Text = itmX.SubItems[colBatchsShelfLife.Index].Text;
                //this.FindBatchs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateBatchsList()
        {
            try
            {
                if (bNewBatchs)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {BatchsId.ToString(), 
                                                                                      CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId), 
                                                                                      txtBatchsBatchnumber.Text.ToString(), 
                                                                                      CCommon.GetItemData(cboBatchsItemid), 
                                                                                      cboBatchsItemid.Text.ToString(),
                                                                                      txtBatchsQuantity.Text.ToString(), 
                                                                                      txtBatchsPriceperunit.Text.ToString(), 
                                                                                      string.Empty, //txtBatchsFreightpayments.Text.ToString(), 
                                                                                      string.Empty, //txtBatchsInsurancepayments.Text.ToString(), 
                                                                                      string.Empty, //txtBatchsBankpayments.Text.ToString(), 
                                                                                      string.Empty, //txtBatchsOtherpayments.Text.ToString(), 
                                                                                      string.Empty, //txtBatchsSuggestedsaleprice.Text.ToString(), 
                                                                                      string.Empty, //txtBatchsSaleprice.Text.ToString(), 
                                                                                      txtBatchsManufactureddate.Text.ToString(), 
                                                                                      txtBatchsExpirydate.Text.ToString(),
                                                                                      txtBatchsShelfLife.Text.ToString()});
                    lvwBatchs.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwBatchs.SelectedItems[0];
                    itmX.SubItems[colBatchsPurchaseOrderGuid.Index].Text = CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId);
                    itmX.SubItems[colBatchsBatchnumber.Index].Text = txtBatchsBatchnumber.Text.ToString();
                    itmX.SubItems[colBatchsItemGuid.Index].Text = CCommon.GetItemData(cboBatchsItemid);
                    itmX.SubItems[colBatchsQuantity.Index].Text = txtBatchsQuantity.Text.ToString();
                    itmX.SubItems[colBatchsPriceperunit.Index].Text = txtBatchsPriceperunit.Text.ToString();
                    //itmX.SubItems[colBatchsFreightpayments.Index].Text = txtBatchsFreightpayments.Text.ToString();
                    //itmX.SubItems[colBatchsInsurancepayments.Index].Text = txtBatchsInsurancepayments.Text.ToString();
                    //itmX.SubItems[colBatchsBankpayments.Index].Text = txtBatchsBankpayments.Text.ToString();
                    //itmX.SubItems[colBatchsOtherpayments.Index].Text = txtBatchsOtherpayments.Text.ToString();
                    //itmX.SubItems[colBatchsSuggestedsaleprice.Index].Text = txtBatchsSuggestedsaleprice.Text.ToString();
                    //itmX.SubItems[colBatchsSaleprice.Index].Text = txtBatchsSaleprice.Text.ToString();
                    itmX.SubItems[colBatchsManufactureddate.Index].Text = txtBatchsManufactureddate.Text.ToString();
                    itmX.SubItems[colBatchsExpirydate.Index].Text = txtBatchsExpirydate.Text.ToString();
                    itmX.SubItems[colBatchsShelfLife.Index].Text = txtBatchsShelfLife.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillBatchsList()
        {
            try
            {

                CBatchs objBatchs = new CBatchs();

                ArrayList ar = new ArrayList(objBatchs.GetList());
                this.lvwBatchs.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CBatchs Batchs in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {  Batchs.Id.ToString(), 
                                                                                      Batchs.Purchaseorderguid.ToString(), 
                                                                                      Batchs.Batchnumber.ToString(), 
                                                                                      Batchs.Itemguid.ToString(), 
                                                                                      Batchs.Itemguid.ToString(), 
                                                                                      Batchs.Quantity.ToString(), 
                                                                                      Batchs.Priceperunit.ToString(), 
                                                                                      Batchs.Freightpayments.ToString(), 
                                                                                      Batchs.Insurancepayments.ToString(), 
                                                                                      Batchs.Bankpayments.ToString(), 
                                                                                      Batchs.Otherpayments.ToString(), 
                                                                                      Batchs.Suggestedsaleprice.ToString(), 
                                                                                      Batchs.Saleprice.ToString(), 
                                                                                      Batchs.Manufactureddate == CSettings.MinDate ? string.Empty : Batchs.Manufactureddate.ToString(CSettings.DateFormat), 
                                                                                      Batchs.Expirydate == CSettings.MinDate ? string.Empty : Batchs.Expirydate.ToString(CSettings.DateFormat),
                                                                                      Batchs.Shelflife.ToString()});
                    this.lvwBatchs.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillBatchsListByParent(string Purchaseorderguid)
        {
            try
            {

                CBatchs objBatchs = new CBatchs();

                ArrayList ar = new ArrayList(objBatchs.GetList(Purchaseorderguid, (int)CCommon.SupplierType.Local));
                this.lvwBatchs.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CBatchs Batchs in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {  Batchs.Id.ToString(), 
                                                                                      Batchs.Purchaseorderguid.ToString(), 
                                                                                      Batchs.Batchnumber.ToString(), 
                                                                                      Batchs.Itemguid.ToString(), 
                                                                                      Batchs.ItemDescription.ToString(), 
                                                                                      Batchs.Quantity.ToString(), 
                                                                                      Batchs.Priceperunit.ToString(), 
                                                                                      Batchs.Freightpayments.ToString(), 
                                                                                      Batchs.Insurancepayments.ToString(), 
                                                                                      Batchs.Bankpayments.ToString(), 
                                                                                      Batchs.Otherpayments.ToString(), 
                                                                                      Batchs.Suggestedsaleprice.ToString(), 
                                                                                      Batchs.Saleprice.ToString(), 
                                                                                      Batchs.Manufactureddate == CSettings.MinDate ? string.Empty : Batchs.Manufactureddate.ToString(CSettings.DateFormat), 
                                                                                      Batchs.Expirydate == CSettings.MinDate ? string.Empty : Batchs.Expirydate.ToString(CSettings.DateFormat),
                                                                                      Batchs.Shelflife.ToString() });
                    this.lvwBatchs.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveBatchs_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveBatchs();

                if (bSaved)
                {
                    UpdateBatchsList();
                    NewBatchs();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteBatchs_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CBatchs objBatchs = new CBatchs();
                    objBatchs.Id = Convert.ToInt32(lvwBatchs.SelectedItems[0].SubItems[colBatchsId.Index].Text);
                    objBatchs.Delete();
                    lvwBatchs.Items.Remove(lvwBatchs.SelectedItems[0]);

                    NewBatchs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewBatchs_Click(object sender, EventArgs e)
        {
            try
            {
                this.lvwBatchs.SelectedItems.Clear();

                bNewBatchs = true;
                BatchsId = 0;
                NewBatchs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwBatchs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwBatchs.SelectedItems == null) return;
                if (lvwBatchs.SelectedItems.Count <= 0) return;

                EditBatchs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowBatchsByParent_Click(object sender, EventArgs e)
        {
            try
            {
                FillBatchsListByParent(CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId));
                NewBatchs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboBatchsItemid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CLocalPurchaseOrderDetails detail = new CLocalPurchaseOrderDetails();
                DataTable dt;

                if (cboBatchsItemid.Items.Count > 0)
                {
                    if (CCommon.GetItemData(cboBatchsItemid) != "-1" && CCommon.GetItemData(cboBatchsItemid) != string.Empty)
                    {
                        dt = detail.GetRecord(CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId), CCommon.GetItemData(cboBatchsItemid));
                        this.txtBatchsPriceperunit.Text = detail.Priceperunit.ToString();
                    }
                    else
                    {
                        this.txtBatchsPriceperunit.Text = string.Empty;
                    }
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


    }
}
