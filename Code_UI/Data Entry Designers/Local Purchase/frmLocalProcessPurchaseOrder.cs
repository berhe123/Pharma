
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
    public partial class frmLocalProcessPurchaseOrder : Form
    {
        private const string DialogCaption = "Purchase Order";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        #region Purchase Order Form Code

        private bool already_in = false;

        public frmLocalProcessPurchaseOrder()
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
            if (!already_in)
            {
                already_in = true;
                //FillPurchaseOrdersList();
                lblMsg.Text = null;
            }
        }
        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            lblMsg.Text = null;
            CCommon.FillPaymentReasonCombo(this.cboOtherPaymentPaymentReason, true);
            this.txtOrderDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
            this.txtOrderDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
        }

        #endregion

        #region Purchase Order Code

        //private bool bNewPurchaseOrders = true;
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
                //bNewPurchaseOrders = true;

                PurchaseOrdersId = 0;
                txtOrderNumber.Text = String.Empty;
                txtOrderDate.Text = DateTime.Today.ToString(CSettings.DateFormat);

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
                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();
                DataTable dt = new DataTable();

                objPurchaseOrders.Id = PurchaseOrdersId;
                dt = objPurchaseOrders.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    PurchaseOrdersId = objPurchaseOrders.Id;
                    txtOrderNumber.Text = Convert.ToString(objPurchaseOrders.Ordernumber);
                    if (objPurchaseOrders.Orderdate != DateTime.MinValue)
                    {
                        txtOrderDate.Text = objPurchaseOrders.Orderdate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtOrderDate.Text = string.Empty;
                    }

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

                //bNewPurchaseOrders = false;
                PurchaseOrdersId = Convert.ToInt32(itmX.SubItems[colAutoID.Index].Text);
                txtOrderNumber.Text = Convert.ToString(itmX.SubItems[colOrderNumber.Index].Text);
                txtOrderDate.Text = itmX.SubItems[colOrderDate.Index].Text;

                FillPurchaseOrderAllPaymentsList();

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
                NewPurchaseOrderPayments();
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

                CPurchaseOrderDetails objPurchaseOrderDetails = new CPurchaseOrderDetails();

                ArrayList ar = new ArrayList(objPurchaseOrderDetails.GetList());
                this.lvwPurchaseOrderDetails.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrderDetails PurchaseOrderDetails in ar)
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
                                                                                      "0",
                                                                                      "Birr",
                                                                                       "0"});
                    this.lvwPurchaseOrderDetails.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #endregion

        
        #region Other Payment Functions

        private bool bNewOtherPayment = true;
        private int OtherPaymentId = 0;

        private bool IsValidPurchaseOrderPayments()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtOrderNumber, "Please select a purchase order", mValidator, lblMsg))
                    return false;
                if (CCommon.GetItemData(cboOtherPaymentPaymentReason) == "-1")
                {
                    CCommon.SetMessage(cboOtherPaymentPaymentReason, "Please select the payment reason", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtOtherPaymentReferenceNumber, "Reference  number can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtOtherPaymentAmount, "Amount can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewPurchaseOrderPayments()
        {
            try
            {
                bNewOtherPayment = true;
                OtherPaymentId = 0;
                cboOtherPaymentPaymentReason.SelectedIndex = -1;
                txtOtherPaymentPaymentDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtOtherPaymentReferenceNumber.Text = String.Empty;
                txtOtherPaymentAmount.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SavePurchaseOrderPayments()
        {
            try
            {
                if (!IsValidPurchaseOrderPayments()) return false;

                CLocalPurchaseOrderPayments objPurchaseOrderPayments = new CLocalPurchaseOrderPayments();

                objPurchaseOrderPayments.Id = OtherPaymentId;
                objPurchaseOrderPayments.Purchaseorderguid = CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId);
                objPurchaseOrderPayments.Paymentreason = Convert.ToInt32(CCommon.GetItemData(cboOtherPaymentPaymentReason));
                objPurchaseOrderPayments.Paymentdate = CDateTime.DateFromString(txtOtherPaymentPaymentDate.Text);
                objPurchaseOrderPayments.Referencenumber = Convert.ToString(txtOtherPaymentReferenceNumber.Text);
                objPurchaseOrderPayments.Amount = Convert.ToDecimal(txtOtherPaymentAmount.Text);

                if (objPurchaseOrderPayments.Exists(bNewOtherPayment) > 0)
                {
                    MessageBox.Show("There exists a payment record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewOtherPayment)
                    objPurchaseOrderPayments.Insert();
                else
                    objPurchaseOrderPayments.Update();

                OtherPaymentId = objPurchaseOrderPayments.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindPurchaseOrderPayments()
        {
            try
            {
                CPurchaseOrderPayments objPurchaseOrderPayments = new CPurchaseOrderPayments();
                DataTable dt = new DataTable();

                objPurchaseOrderPayments.Id = OtherPaymentId;
                dt = objPurchaseOrderPayments.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    OtherPaymentId = objPurchaseOrderPayments.Id;
                    txtOrderNumber.Tag = Convert.ToString(objPurchaseOrderPayments.Purchaseorderguid);
                    cboOtherPaymentPaymentReason.SelectedIndex = CCommon.GetIndexByItemData(cboOtherPaymentPaymentReason, objPurchaseOrderPayments.Paymentreason.ToString(), true);
                    if (objPurchaseOrderPayments.Paymentdate != DateTime.MinValue)
                    {
                        txtOtherPaymentPaymentDate.Text = objPurchaseOrderPayments.Paymentdate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtOtherPaymentPaymentDate.Text = string.Empty;
                    }
                    txtOtherPaymentReferenceNumber.Text = Convert.ToString(objPurchaseOrderPayments.Referencenumber);
                    txtOtherPaymentAmount.Text = Convert.ToString(objPurchaseOrderPayments.Amount);

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
        private void EditPurchaseOrderPayments()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwOtherPayments.SelectedItems[0];

                bNewOtherPayment = false;
                OtherPaymentId = Convert.ToInt32(itmX.SubItems[colOtherPaymentId.Index].Text);
                txtOrderNumber.Tag = Convert.ToString(itmX.SubItems[colOtherPaymentPaymentOrderGuid.Index].Text);
                cboOtherPaymentPaymentReason.SelectedIndex = CCommon.GetIndexByItemData(cboOtherPaymentPaymentReason, itmX.SubItems[colOtherPaymentPaymentReason.Index].Text, true);
                txtOtherPaymentPaymentDate.Text = itmX.SubItems[colOtherPaymentPaymentDate.Index].Text;
                txtOtherPaymentReferenceNumber.Text = Convert.ToString(itmX.SubItems[colOtherPaymentReferenceNumber.Index].Text);
                txtOtherPaymentAmount.Text = Convert.ToString(itmX.SubItems[colOtherPaymentAmount.Index].Text);

                //this.FindPurchaseOrderPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdatePurchaseOrderPaymentsList()
        {
            try
            {
                if (bNewOtherPayment)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {OtherPaymentId.ToString(), 
                                                                                      CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId), 
                                                                                      CCommon.GetItemData(cboOtherPaymentPaymentReason), 
                                                                                      cboOtherPaymentPaymentReason.Text.ToString(),
                                                                                      txtOtherPaymentPaymentDate.Text.ToString(), 
                                                                                      txtOtherPaymentReferenceNumber.Text.ToString(), 
                                                                                      txtOtherPaymentAmount.Text.ToString()});
                    lvwOtherPayments.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwOtherPayments.SelectedItems[0];
                    itmX.SubItems[colOtherPaymentPaymentOrderGuid.Index].Text = CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId);
                    itmX.SubItems[colOtherPaymentPaymentReason.Index].Text = CCommon.GetItemData(cboOtherPaymentPaymentReason);
                    itmX.SubItems[colOtherPaymentPaymentReasonDescription.Index].Text = cboOtherPaymentPaymentReason.Text.ToString();
                    itmX.SubItems[colOtherPaymentPaymentDate.Index].Text = txtOtherPaymentPaymentDate.Text.ToString();
                    itmX.SubItems[colOtherPaymentReferenceNumber.Index].Text = txtOtherPaymentReferenceNumber.Text.ToString();
                    itmX.SubItems[colOtherPaymentAmount.Index].Text = txtOtherPaymentAmount.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrderPaymentsList()
        {
            try
            {

                CPurchaseOrderPayments objPurchaseOrderPayments = new CPurchaseOrderPayments();

                ArrayList ar = new ArrayList(objPurchaseOrderPayments.GetList());
                this.lvwOtherPayments.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrderPayments PurchaseOrderPayments in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrderPayments.Id.ToString(), 
                                                                                      PurchaseOrderPayments.Purchaseorderguid.ToString(), 
                                                                                      PurchaseOrderPayments.Paymentreason.ToString(), 
                                                                                      CCommon.GetPaymentReasonText(PurchaseOrderPayments.Paymentreason), 
                                                                                      PurchaseOrderPayments.Paymentdate == CSettings.MinDate ? string.Empty : PurchaseOrderPayments.Paymentdate.ToString(CSettings.DateFormat), 
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
                                                                                      PurchaseOrderPayments.Paymentdate == CSettings.MinDate ? string.Empty : PurchaseOrderPayments.Paymentdate.ToString(CSettings.DateFormat), 
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

        private void btnSavePurchaseOrderPayments_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SavePurchaseOrderPayments();

                if (bSaved)
                {
                    UpdatePurchaseOrderPaymentsList();
                    NewPurchaseOrderPayments();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeletePurchaseOrderPayments_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CPurchaseOrderPayments objPurchaseOrderPayments = new CPurchaseOrderPayments();
                    objPurchaseOrderPayments.Id = Convert.ToInt32(lvwOtherPayments.SelectedItems[0].SubItems[colOtherPaymentId.Index].Text);
                    objPurchaseOrderPayments.Delete();
                    lvwOtherPayments.Items.Remove(lvwOtherPayments.SelectedItems[0]);

                    NewPurchaseOrderPayments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewPurchaseOrderPayments_Click(object sender, EventArgs e)
        {
            try
            {
                this.lvwOtherPayments.SelectedItems.Clear();

                bNewOtherPayment = true;
                OtherPaymentId = 0;
                NewPurchaseOrderPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwOtherPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwOtherPayments.SelectedItems == null) return;
                if (lvwOtherPayments.SelectedItems.Count <= 0) return;

                EditPurchaseOrderPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowPurchaseOrderPaymentsByParent_Click(object sender, EventArgs e)
        {
            try
            {
                FillPurchaseOrderPaymentsListByParent(CLocalPurchaseOrders.GetTableRowGuid(PurchaseOrdersId));
                NewPurchaseOrderPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

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
                this.tabDetail.Width = this.lblTitle.Width - this.tabDetail.Left - 24;
                this.lvwPurchaseOrderDetails.Width = this.tabPageDetail.Width - this.lvwPurchaseOrderDetails.Left - 24;

                // Transactions listview
                this.lvwPurchaseOrders.Height = this.Height - this.lvwPurchaseOrders.Top - 58;

                // Detail Groupbox
                this.PaymentTabs.Height = this.Height - this.PaymentTabs.Top - 58;
                this.PaymentTabs.Width = this.lblTitle.Width - this.PaymentTabs.Left - 24;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProcessPurchaseOrder_Resize(object sender, EventArgs e)
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
        
        private void SearchManufacturer(TextBox SearchTextBox, int HorizontalOffset, int VerticalOffset)
        {
            try
            {
                if (SearchTextBox.Text != "")
                {
                    CManufacturers objManufacturer = new CManufacturers();
                    string nameLike = SearchTextBox.Text + "%";
                    ArrayList ar = new ArrayList(objManufacturer.GetList(nameLike,(int)CCommon.SupplierType.Local));
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

        private void lvwPurchaseOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        }

    }

