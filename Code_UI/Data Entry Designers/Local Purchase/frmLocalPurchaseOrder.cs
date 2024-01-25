

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
    public partial class frmLocalPurchaseOrder : Form
    {
        private const string DialogCaption = "Purchase Order";
        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;
        private bool IsPurchaseWithVAT;

        #region Purchase Order Form Code

        private bool already_in = false;

        public frmLocalPurchaseOrder()
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
                CCommon.FillTermsOfPaymentLocalCombo(this.cboLocalPurchaseOrdersPaymenttype, true);
                CCommon.FillLocalPurchaseOrderTypeCombo(this.cboLocalPurchaseOrdersOrdertype, true);
                CCommon.FillLocalPurchaseOrderStatusCombo(this.cboLocalPurchaseOrdersOrderstatus, true);
                
                NewPurchaseOrders();
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
                // Transactions listview
                this.lvwLocalPurchaseOrders.Height = this.Height - this.lvwLocalPurchaseOrders.Top - 58;

                // Detail Groupbox
                this.tabDetail.Height = this.Height - this.tabDetail.Top - 58;
                this.tabDetail.Width = this.lblTitle.Width - this.tabDetail.Left - 24;

                this.panelTotal.Top = this.tabDetail.Height - this.panelTotal.Height - this.orderDetailToolStrip.Height - 2;
                this.gvwPurchaseOrderDetail.Width = this.tabDetail.Width  - 12;
                this.gvwPurchaseOrderDetail.Height = this.panelTotal.Top - this.orderDetailToolStrip.Height - 4;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmPurchaseOrder_Resize(object sender, EventArgs e)
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

        private bool bNewLocalPurchaseOrders = true;
        private int LocalPurchaseOrdersId = 0;

        private bool FindTermsOfContractTemplates(int TermsOfContractTemplatesId)
        {
            try
            {
                CTermsOfContractTemplates objTermsOfContractTemplates = new CTermsOfContractTemplates();
                DataTable dt = new DataTable();

                objTermsOfContractTemplates.Id = TermsOfContractTemplatesId;
                dt = objTermsOfContractTemplates.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    txtLocalPurchaseOrdersTermsofpayment.Text = Convert.ToString(objTermsOfContractTemplates.Templatecontent);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private bool IsValidPurchaseOrders()
        {
            try
            {
                DateTime ValidDate;

                if (!CCommon.SetRequiredMessage(txtLocalPurchaseOrdersOrdernumber, "Order number can not be empty", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtLocalPurchaseOrdersOrderdate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    CCommon.SetMessage(txtLocalPurchaseOrdersOrderdate, "Please enter a valid order date", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(cboLocalPurchaseOrdersOrdertype, "Please Select Order Type", mValidator, lblMsg,true))
                    return false;


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
                lvwLocalPurchaseOrders.SelectedItems.Clear();

                bNewLocalPurchaseOrders = true;
                LocalPurchaseOrdersId = 0;

                bNewLocalPurchaseOrders = true;
                LocalPurchaseOrdersId = 0;
                txtLocalPurchaseOrdersOrdernumber.Text = String.Empty;
                txtLocalPurchaseOrdersOrderdate.Text = DateTime.Today.ToString(CSettings.DateFormat); ;
                txtManufacturer.Text = String.Empty;
                cboLocalPurchaseOrdersPaymenttype.SelectedIndex = 0;
                txtLocalPurchaseOrdersTermsofpayment.Text = String.Empty;
                txtLocalPurchaseOrdersPlaceoforigin.Text = String.Empty;
                txtLocalPurchaseOrdersPlaceofdestination.Text = String.Empty;
                cboLocalPurchaseOrdersOrdertype.SelectedIndex = 0;
                cboLocalPurchaseOrdersOrderstatus.SelectedIndex = 0;
                txtLocalPurchaseOrdersInvoiceno.Text = String.Empty;
                txtLocalPurchaseOrdersInvoicedate.Text = String.Empty;
                txtLocalPurchaseOrdersInvoiceremark.Text = String.Empty;
                gvwPurchaseOrderDetail.Rows.Clear();
                CalculateTotal();                
                gvwPurchaseOrderDetail.Rows.Clear();
                AdjsutOrderForEdit("-1");
                int maxOrderNumber = CLocalPurchaseOrders.GetMaxOrderNumber();
                this.txtLocalPurchaseOrdersOrdernumber.Text = "0" + (maxOrderNumber + 1).ToString(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SavePurchaseOrders()
        {
            if (gvwPurchaseOrderDetail.RowCount > 1)
            {
                if (!IsValidPurchaseOrders()) return false;
                try
                {
                    CLocalPurchaseOrders objLocalPurchaseOrders = new CLocalPurchaseOrders();

                    objLocalPurchaseOrders.Id = LocalPurchaseOrdersId;
                    if (txtLocalPurchaseOrdersOrdernumber.Text == string.Empty)
                        objLocalPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objLocalPurchaseOrders.Ordernumber = Convert.ToString(txtLocalPurchaseOrdersOrdernumber.Text);
                    if (txtLocalPurchaseOrdersOrderdate.Text == string.Empty)
                        objLocalPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objLocalPurchaseOrders.Orderdate = CDateTime.DateFromString(txtLocalPurchaseOrdersOrderdate.Text);
                    if (txtManufacturer.Tag.ToString() == string.Empty)
                        objLocalPurchaseOrders.Supplierguid = string.Empty;
                    else
                        objLocalPurchaseOrders.Supplierguid = txtManufacturer.Tag.ToString();
                    if (cboLocalPurchaseOrdersPaymenttype.SelectedIndex == -1)
                        objLocalPurchaseOrders.Paymenttype = int.MinValue;
                    else
                        objLocalPurchaseOrders.Paymenttype = Convert.ToInt32(CCommon.GetItemData(cboLocalPurchaseOrdersPaymenttype));
                    if (txtLocalPurchaseOrdersTermsofpayment.Text == string.Empty)
                        objLocalPurchaseOrders.Termsofpayment = string.Empty;
                    else
                        objLocalPurchaseOrders.Termsofpayment = Convert.ToString(txtLocalPurchaseOrdersTermsofpayment.Text);
                    if (txtLocalPurchaseOrdersPlaceoforigin.Text == string.Empty)
                        objLocalPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objLocalPurchaseOrders.Placeoforigin = Convert.ToString(txtLocalPurchaseOrdersPlaceoforigin.Text);
                    if (txtLocalPurchaseOrdersPlaceofdestination.Text == string.Empty)
                        objLocalPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objLocalPurchaseOrders.Placeofdestination = Convert.ToString(txtLocalPurchaseOrdersPlaceofdestination.Text);
                    if (cboLocalPurchaseOrdersOrdertype.SelectedIndex == -1)
                        objLocalPurchaseOrders.Ordertype = int.MinValue;
                    else
                        objLocalPurchaseOrders.Ordertype = Convert.ToInt32(CCommon.GetItemData(cboLocalPurchaseOrdersOrdertype));
                    if (cboLocalPurchaseOrdersOrderstatus.SelectedIndex == -1)
                        objLocalPurchaseOrders.Orderstatus = int.MinValue;
                    else
                        objLocalPurchaseOrders.Orderstatus = Convert.ToInt32(CCommon.GetItemData(cboLocalPurchaseOrdersOrderstatus));
                    if (txtLocalPurchaseOrdersInvoiceno.Text == string.Empty)
                        objLocalPurchaseOrders.Invoiceno = string.Empty;
                    else
                        objLocalPurchaseOrders.Invoiceno = Convert.ToString(txtLocalPurchaseOrdersInvoiceno.Text);
                    if (txtLocalPurchaseOrdersInvoicedate.Text == string.Empty)
                        objLocalPurchaseOrders.Invoicedate = DateTime.MinValue;
                    else
                        objLocalPurchaseOrders.Invoicedate = CDateTime.DateFromString(txtLocalPurchaseOrdersInvoicedate.Text);
                    if (txtLocalPurchaseOrdersInvoiceremark.Text == string.Empty)
                        objLocalPurchaseOrders.Invoiceremark = string.Empty;
                    else
                        objLocalPurchaseOrders.Invoiceremark = Convert.ToString(txtLocalPurchaseOrdersInvoiceremark.Text);

                    if (objLocalPurchaseOrders.Exists(bNewLocalPurchaseOrders) > 0)
                    {
                        MessageBox.Show("Data Existance Error!!!.There Exists Data With The Given Information.");
                        return false;
                    }

                    if (bNewLocalPurchaseOrders)
                        objLocalPurchaseOrders.Insert();
                    else
                        objLocalPurchaseOrders.Update();

                    LocalPurchaseOrdersId = objLocalPurchaseOrders.Id;
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please add atleast one item", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        private bool FindPurchaseOrders()
        {
            CLocalPurchaseOrders objLocalPurchaseOrders = new CLocalPurchaseOrders();
            DataTable dt = new DataTable();
            try
            {
                objLocalPurchaseOrders.Id = LocalPurchaseOrdersId;
                dt = objLocalPurchaseOrders.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    LocalPurchaseOrdersId = objLocalPurchaseOrders.Id;
                    txtLocalPurchaseOrdersOrdernumber.Text = Convert.ToString(objLocalPurchaseOrders.Ordernumber);
                    txtLocalPurchaseOrdersOrderdate.Text = Convert.ToString(objLocalPurchaseOrders.Orderdate);                    
                    txtManufacturer.Tag = Convert.ToString(objLocalPurchaseOrders.Supplierguid);
                    txtManufacturer.Text = CManufacturers.GetManufacturerNameFromCollection(objLocalPurchaseOrders.Supplierguid);
                    cboLocalPurchaseOrdersPaymenttype.SelectedIndex = CCommon.GetIndexByItemData(cboLocalPurchaseOrdersPaymenttype, objLocalPurchaseOrders.Paymenttype.ToString(),true);
                    txtLocalPurchaseOrdersTermsofpayment.Text = Convert.ToString(objLocalPurchaseOrders.Termsofpayment);
                    txtLocalPurchaseOrdersPlaceoforigin.Text = Convert.ToString(objLocalPurchaseOrders.Placeoforigin);
                    txtLocalPurchaseOrdersPlaceofdestination.Text = Convert.ToString(objLocalPurchaseOrders.Placeofdestination);
                    cboLocalPurchaseOrdersOrdertype.SelectedIndex = CCommon.GetIndexByItemData(cboLocalPurchaseOrdersOrdertype, objLocalPurchaseOrders.Ordertype.ToString(),true);
                    cboLocalPurchaseOrdersOrderstatus.SelectedIndex = CCommon.GetIndexByItemData(cboLocalPurchaseOrdersOrderstatus, objLocalPurchaseOrders.Orderstatus.ToString(),true);
                    txtLocalPurchaseOrdersInvoiceno.Text = Convert.ToString(objLocalPurchaseOrders.Invoiceno);
                    txtLocalPurchaseOrdersInvoicedate.Text = Convert.ToString(objLocalPurchaseOrders.Invoicedate);
                    txtLocalPurchaseOrdersInvoiceremark.Text = Convert.ToString(objLocalPurchaseOrders.Invoiceremark);

                    return true;
                }
                else
                {
                    MessageBox.Show("Record not found!", "LocalPurchaseOrders");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        private void EditPurchaseOrders()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwLocalPurchaseOrders.SelectedItems[0];

                bNewLocalPurchaseOrders = false;
                LocalPurchaseOrdersId = Convert.ToInt32(itmX.SubItems[colLocalPurchaseOrdersId.Index].Text);
                txtLocalPurchaseOrdersOrdernumber.Text = Convert.ToString(itmX.SubItems[colLocalPurchaseOrdersOrdernumber.Index].Text);
                txtLocalPurchaseOrdersOrderdate.Text = Convert.ToString(itmX.SubItems[colLocalPurchaseOrdersOrderdate.Index].Text);
                txtManufacturer.Text = CManufacturers.GetManufacturerNameFromCollection(itmX.SubItems[colLocalPurchaseOrdersSupplierGuid.Index].Text);
                txtManufacturer.Tag = itmX.SubItems[colLocalPurchaseOrdersSupplierGuid.Index].Text;
                cboLocalPurchaseOrdersPaymenttype.SelectedIndex = CCommon.GetIndexByItemData(cboLocalPurchaseOrdersPaymenttype, itmX.SubItems[colLocalPurchaseOrdersPaymenttype.Index].Text,true);
                txtLocalPurchaseOrdersTermsofpayment.Text = Convert.ToString(itmX.SubItems[colLocalPurchaseOrdersTermsofpayment.Index].Text);
                txtLocalPurchaseOrdersPlaceoforigin.Text = Convert.ToString(itmX.SubItems[colLocalPurchaseOrdersPlaceoforigin.Index].Text);
                txtLocalPurchaseOrdersPlaceofdestination.Text = Convert.ToString(itmX.SubItems[colLocalPurchaseOrdersPlaceofdestination.Index].Text);
                cboLocalPurchaseOrdersOrdertype.SelectedIndex = CCommon.GetIndexByItemData(cboLocalPurchaseOrdersOrdertype, itmX.SubItems[colLocalPurchaseOrdersOrdertype.Index].Text,true);
                cboLocalPurchaseOrdersOrderstatus.SelectedIndex = CCommon.GetIndexByItemData(cboLocalPurchaseOrdersOrderstatus, itmX.SubItems[colLocalPurchaseOrdersOrderstatus.Index].Text,true);
                txtLocalPurchaseOrdersInvoiceno.Text = Convert.ToString(itmX.SubItems[colLocalPurchaseOrdersInvoiceno.Index].Text);
                txtLocalPurchaseOrdersInvoicedate.Text = Convert.ToString(itmX.SubItems[colLocalPurchaseOrdersInvoicedate.Index].Text);
                txtLocalPurchaseOrdersInvoiceremark.Text = Convert.ToString(itmX.SubItems[colLocalPurchaseOrdersInvoiceremark.Index].Text);


                //this.FindPurchaseOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdatePurchaseOrdersList()
        {
            try
            {
                if (bNewLocalPurchaseOrders)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {LocalPurchaseOrdersId.ToString(), 
                                                                                      txtLocalPurchaseOrdersOrdernumber.Text.ToString(), 
                                                                                      txtLocalPurchaseOrdersOrderdate.Text.ToString(),    
                                                                                      txtManufacturer.Tag.ToString(), 
                                                                                      CCommon.GetItemData(cboLocalPurchaseOrdersPaymenttype), 
                                                                                      txtLocalPurchaseOrdersTermsofpayment.Text.ToString(), 
                                                                                      txtLocalPurchaseOrdersPlaceoforigin.Text.ToString(), 
                                                                                      txtLocalPurchaseOrdersPlaceofdestination.Text.ToString(), 
                                                                                      CCommon.GetItemData(cboLocalPurchaseOrdersOrdertype), 
                                                                                      CCommon.GetItemData(cboLocalPurchaseOrdersOrderstatus), 
                                                                                      txtLocalPurchaseOrdersInvoiceno.Text.ToString(), 
                                                                                      txtLocalPurchaseOrdersInvoicedate.Text.ToString(), 
                                                                                      txtLocalPurchaseOrdersInvoiceremark.Text.ToString()});
                    lvwLocalPurchaseOrders.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwLocalPurchaseOrders.SelectedItems[0];
                    itmX.SubItems[colLocalPurchaseOrdersOrdernumber.Index].Text = txtLocalPurchaseOrdersOrdernumber.Text.ToString();
                    itmX.SubItems[colLocalPurchaseOrdersOrderdate.Index].Text = txtLocalPurchaseOrdersOrderdate.Text.ToString();
                    txtManufacturer.Text = CManufacturers.GetManufacturerNameFromCollection(itmX.SubItems[colLocalPurchaseOrdersSupplierGuid.Index].Text);                
                    itmX.SubItems[colLocalPurchaseOrdersPaymenttype.Index].Text = CCommon.GetItemData(cboLocalPurchaseOrdersPaymenttype);
                    itmX.SubItems[colLocalPurchaseOrdersTermsofpayment.Index].Text = txtLocalPurchaseOrdersTermsofpayment.Text.ToString();
                    itmX.SubItems[colLocalPurchaseOrdersPlaceoforigin.Index].Text = txtLocalPurchaseOrdersPlaceoforigin.Text.ToString();
                    itmX.SubItems[colLocalPurchaseOrdersPlaceofdestination.Index].Text = txtLocalPurchaseOrdersPlaceofdestination.Text.ToString();
                    itmX.SubItems[colLocalPurchaseOrdersOrdertype.Index].Text = CCommon.GetItemData(cboLocalPurchaseOrdersOrdertype);
                    itmX.SubItems[colLocalPurchaseOrdersOrderstatus.Index].Text = CCommon.GetItemData(cboLocalPurchaseOrdersOrderstatus);
                    itmX.SubItems[colLocalPurchaseOrdersInvoiceno.Index].Text = txtLocalPurchaseOrdersInvoiceno.Text.ToString();
                    itmX.SubItems[colLocalPurchaseOrdersInvoicedate.Index].Text = txtLocalPurchaseOrdersInvoicedate.Text.ToString();
                    itmX.SubItems[colLocalPurchaseOrdersInvoiceremark.Index].Text = txtLocalPurchaseOrdersInvoiceremark.Text.ToString();
                }
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
                this.lvwLocalPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders LocalPurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {LocalPurchaseOrders.Id.ToString(),
                                                                                      LocalPurchaseOrders.Ordernumber.ToString(), 
                                                                                      LocalPurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : LocalPurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      LocalPurchaseOrders.Supplierguid.ToString(), 
                                                                                      LocalPurchaseOrders.Paymenttype.ToString(), 
                                                                                      LocalPurchaseOrders.Termsofpayment.ToString(), 
                                                                                      LocalPurchaseOrders.Placeoforigin.ToString(), 
                                                                                      LocalPurchaseOrders.Placeofdestination.ToString(), 
                                                                                      LocalPurchaseOrders.Ordertype.ToString(), 
                                                                                      LocalPurchaseOrders.Orderstatus.ToString(), 
                                                                                      LocalPurchaseOrders.Invoiceno.ToString(), 
                                                                                      LocalPurchaseOrders.Invoicedate == CSettings.MinDate ? string.Empty : LocalPurchaseOrders.Invoicedate.ToString(CSettings.DateFormat), 
                                                                                      LocalPurchaseOrders.Invoiceremark.ToString()});
                    this.lvwLocalPurchaseOrders.Items.Add(itmX);
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
                this.lvwLocalPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders LocalPurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {LocalPurchaseOrders.Id.ToString(),
                                                                                      LocalPurchaseOrders.Ordernumber.ToString(), 
                                                                                      LocalPurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : LocalPurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      LocalPurchaseOrders.Supplierguid.ToString(), 
                                                                                      LocalPurchaseOrders.Paymenttype.ToString(), 
                                                                                      LocalPurchaseOrders.Termsofpayment.ToString(), 
                                                                                      LocalPurchaseOrders.Placeoforigin.ToString(), 
                                                                                      LocalPurchaseOrders.Placeofdestination.ToString(), 
                                                                                      LocalPurchaseOrders.Ordertype.ToString(), 
                                                                                      LocalPurchaseOrders.Orderstatus.ToString(), 
                                                                                      LocalPurchaseOrders.Invoiceno.ToString(), 
                                                                                      LocalPurchaseOrders.Invoicedate == CSettings.MinDate ? string.Empty : LocalPurchaseOrders.Invoicedate.ToString(CSettings.DateFormat), 
                                                                                      LocalPurchaseOrders.Invoiceremark.ToString()});
                    this.lvwLocalPurchaseOrders.Items.Add(itmX);
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
                this.lvwLocalPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders LocalPurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {LocalPurchaseOrders.Id.ToString(),
                                                                                      LocalPurchaseOrders.Ordernumber.ToString(), 
                                                                                      LocalPurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : LocalPurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      LocalPurchaseOrders.Supplierguid.ToString(), 
                                                                                      LocalPurchaseOrders.Paymenttype.ToString(), 
                                                                                      LocalPurchaseOrders.Termsofpayment.ToString(), 
                                                                                      LocalPurchaseOrders.Placeoforigin.ToString(), 
                                                                                      LocalPurchaseOrders.Placeofdestination.ToString(), 
                                                                                      LocalPurchaseOrders.Ordertype.ToString(), 
                                                                                      LocalPurchaseOrders.Orderstatus.ToString(), 
                                                                                      LocalPurchaseOrders.Invoiceno.ToString(), 
                                                                                      LocalPurchaseOrders.Invoicedate == CSettings.MinDate ? string.Empty : LocalPurchaseOrders.Invoicedate.ToString(CSettings.DateFormat), 
                                                                                      LocalPurchaseOrders.Invoiceremark.ToString()});
                    this.lvwLocalPurchaseOrders.Items.Add(itmX);
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
                this.lvwLocalPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders LocalPurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {LocalPurchaseOrders.Id.ToString(),
                                                                                      LocalPurchaseOrders.Ordernumber.ToString(), 
                                                                                      LocalPurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : LocalPurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      LocalPurchaseOrders.Supplierguid.ToString(), 
                                                                                      LocalPurchaseOrders.Paymenttype.ToString(), 
                                                                                      LocalPurchaseOrders.Termsofpayment.ToString(), 
                                                                                      LocalPurchaseOrders.Placeoforigin.ToString(), 
                                                                                      LocalPurchaseOrders.Placeofdestination.ToString(), 
                                                                                      LocalPurchaseOrders.Ordertype.ToString(), 
                                                                                      LocalPurchaseOrders.Orderstatus.ToString(), 
                                                                                      LocalPurchaseOrders.Invoiceno.ToString(), 
                                                                                      LocalPurchaseOrders.Invoicedate == CSettings.MinDate ? string.Empty : LocalPurchaseOrders.Invoicedate.ToString(CSettings.DateFormat), 
                                                                                      LocalPurchaseOrders.Invoiceremark.ToString()});
                    this.lvwLocalPurchaseOrders.Items.Add(itmX);
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

        private void ShowOrder()
        {
            try
            {
                DataTable dt = new DataTable();
                rptLocalPurchaseOrder rpt = new rptLocalPurchaseOrder();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = "SELECT   TOP (100) PERCENT '' as Dispatch, ";                
                strSQL = strSQL + " tblManufacturers.Name AS ManufacturerName, tblLocalPurchaseOrders.SupplierGuid as ManufacturerGuid, ";
                strSQL = strSQL + " tblManufacturers.MailingAddress, tblManufacturers.email, tblManufacturers.Tel2, ";
                strSQL = strSQL + " tblManufacturers.Tel1, tblManufacturers.Fax, ";
                strSQL = strSQL + " 'Tel: ' + tblManufacturers.Tel1 + ', Fax: ' + tblManufacturers.Fax + ', Email: ' + ";
                strSQL = strSQL + " tblManufacturers.email AS Address1, ";
                strSQL = strSQL + " tblUnitOfMeasurements.Name AS UnitOfMeasurement, ";
                strSQL = strSQL + " tblItems.BrandName AS ItemDescription, ";
                strSQL = strSQL + " '' FreightCharge, 'Birr' as CurrencyType, ";                
                strSQL = strSQL + " tblLocalPurchaseOrders.OrderDate, tblLocalPurchaseOrders.OrderNumber, tblLocalPurchaseOrderDetails.Id as DetailId, tblLocalPurchaseOrderDetails.TableRowGuid as DetailGuid, ";
                strSQL = strSQL + " tblLocalPurchaseOrderDetails.PricePerUnit, tblLocalPurchaseOrderDetails.Quantity, ";
                strSQL = strSQL + " tblLocalPurchaseOrders.PlaceOfOrigin, tblLocalPurchaseOrders.PlaceOfDestination, tblLocalPurchaseOrders.OrderType, ";             
                strSQL = strSQL + " tblLocalPurchaseOrderDetails.PricePerUnit * tblLocalPurchaseOrderDetails.Quantity AS LineTotal   ";
                strSQL = strSQL + " FROM  tblLocalPurchaseOrders INNER JOIN tblLocalPurchaseOrderDetails ";
                strSQL = strSQL + " ON tblLocalPurchaseOrders.TableRowGuid = tblLocalPurchaseOrderDetails.PurchaseOrderGuid  ";
                strSQL = strSQL + " INNER JOIN tblItems  ON tblLocalPurchaseOrderDetails.Itemguid = tblItems.TableRowGuid  ";
                strSQL = strSQL + " LEFT OUTER JOIN tblUnitOfMeasurements  ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid  ";                
                strSQL = strSQL + " INNER JOIN tblManufacturers  ON tblLocalPurchaseOrders.SupplierGuid = tblManufacturers.TableRowGuid   ";

                strSQL = strSQL + " Where tblLocalPurchaseOrders.TableRowGuid = '" + CLocalPurchaseOrders.GetTableRowGuid(LocalPurchaseOrdersId) + "' ";
                strSQL = strSQL + " Order By ItemDescription ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Purchase order";
                    frm.Show();
                }
                else
                    MessageBox.Show("No Record Found", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowOrderVAT()
        {
            try
            {
                DataTable dt = new DataTable();
                rptLocalPurchaseOrderVAT rpt = new rptLocalPurchaseOrderVAT();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = "SELECT   TOP (100) PERCENT '' as Dispatch, ";
                strSQL = strSQL + " tblManufacturers.Name AS ManufacturerName, tblLocalPurchaseOrders.SupplierGuid as ManufacturerGuid, ";
                strSQL = strSQL + " tblManufacturers.MailingAddress, tblManufacturers.email, tblManufacturers.Tel2, ";
                strSQL = strSQL + " tblManufacturers.Tel1, tblManufacturers.Fax, ";
                strSQL = strSQL + " 'Tel: ' + tblManufacturers.Tel1 + ', Fax: ' + tblManufacturers.Fax + ', Email: ' + ";
                strSQL = strSQL + " tblManufacturers.email AS Address1,  ";
                strSQL = strSQL + " tblUnitOfMeasurements.Name AS UnitOfMeasurement,  ";
                strSQL = strSQL + " tblItems.BrandName AS ItemDescription, ";
                strSQL = strSQL + " '' FreightCharge, 'Birr' as CurrencyType, ";
                strSQL = strSQL + " tblLocalPurchaseOrders.OrderDate, tblLocalPurchaseOrders.OrderNumber, tblLocalPurchaseOrderDetails.Id as DetailId, tblLocalPurchaseOrderDetails.TableRowGuid as DetailGuid, ";
                strSQL = strSQL + " tblLocalPurchaseOrderDetails.PricePerUnit, tblLocalPurchaseOrderDetails.Quantity, ";
                strSQL = strSQL + " tblLocalPurchaseOrders.PlaceOfOrigin, tblLocalPurchaseOrders.PlaceOfDestination, tblLocalPurchaseOrders.OrderType, ";
                strSQL = strSQL + " tblLocalPurchaseOrderDetails.PricePerUnit * tblLocalPurchaseOrderDetails.Quantity AS LineTotal   ";
                strSQL = strSQL + " FROM      tblLocalPurchaseOrders INNER JOIN tblLocalPurchaseOrderDetails ";
                strSQL = strSQL + " ON tblLocalPurchaseOrders.TableRowGuid = tblLocalPurchaseOrderDetails.PurchaseOrderGuid ";
                strSQL = strSQL + " INNER JOIN tblItems  				ON tblLocalPurchaseOrderDetails.Itemguid = tblItems.TableRowGuid  ";
                strSQL = strSQL + " LEFT OUTER JOIN tblUnitOfMeasurements  				ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid  ";
                strSQL = strSQL + " INNER JOIN tblManufacturers   				ON tblLocalPurchaseOrders.SupplierGuid = tblManufacturers.TableRowGuid   ";

                strSQL = strSQL + " Where tblLocalPurchaseOrders.TableRowGuid = '" + CLocalPurchaseOrders.GetTableRowGuid(LocalPurchaseOrdersId) + "' ";
                strSQL = strSQL + " Order By ItemDescription ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Purchase order";
                    frm.Show();
                }
                else
                    MessageBox.Show("No Record Found", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string IsOrderTurnedToReceiving(string Purchaseorderguid)
        {
            try
            {
                DataTable dt = new DataTable();
                CStoreTransactions receive = new CStoreTransactions();

                dt = receive.GetRecordbyPO(Purchaseorderguid, (int)CCommon.SupplierType.Local);

                if (dt.Rows.Count > 0)
                {
                    return (string)dt.Rows[0]["ReferenceNumber"];
                }
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        private void AdjsutOrderForEdit(string Purchaseorderguid)
        {
            try
            {
                string referenceNumber = IsOrderTurnedToReceiving(Purchaseorderguid);
                if (referenceNumber != string.Empty)
                {
                    this.txtReceivingReferenceNumber.Text = referenceNumber;                    
                    this.txtLocalPurchaseOrdersOrdernumber.ReadOnly = true;
                    this.txtLocalPurchaseOrdersOrderdate.ReadOnly = true;
                    this.cboLocalPurchaseOrdersOrderstatus.Enabled = false;
                    this.txtLocalPurchaseOrdersTermsofpayment.ReadOnly = true;
                }
                else
                {
                    this.txtReceivingReferenceNumber.Text = string.Empty;                   
                    this.txtLocalPurchaseOrdersOrdernumber.ReadOnly = false;
                    this.txtLocalPurchaseOrdersOrderdate.ReadOnly = false;
                    this.cboLocalPurchaseOrdersOrderstatus.Enabled = true;
                    this.txtLocalPurchaseOrdersTermsofpayment.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsOrderEditAllowed()
        {
            if (this.txtLocalPurchaseOrdersOrdernumber.ReadOnly)
            {
                MessageBox.Show("You can't edit a puchase order record which has already been used in a receiving transaction.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
                return true;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsOrderEditAllowed()) return;

                bool bSaved = false;

                bSaved = SavePurchaseOrders();

                if (bSaved)
                {
                    UpdatePurchaseOrdersList();
                    SavePurchaseOrderDetails(CLocalPurchaseOrders.GetTableRowGuid(LocalPurchaseOrdersId));                    
                    SavePurchaseOrderPayment(CLocalPurchaseOrders.GetTableRowGuid(LocalPurchaseOrdersId));
                    NewPurchaseOrders();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsOrderEditAllowed()) return;

                if (MessageBox.Show("Are you sure to delete this record?", "Purchase Orders", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();
                    objPurchaseOrders.Id = Convert.ToInt32(lvwLocalPurchaseOrders.SelectedItems[0].SubItems[colLocalPurchaseOrdersId.Index].Text);
                    objPurchaseOrders.Delete();
                    lvwLocalPurchaseOrders.Items.Remove(lvwLocalPurchaseOrders.SelectedItems[0]);

                    NewPurchaseOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                NewPurchaseOrders();
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
                if (lvwLocalPurchaseOrders.SelectedItems == null) return;
                if (lvwLocalPurchaseOrders.SelectedItems.Count <= 0) return;

                this.gvwPurchaseOrderDetail.Rows.Clear();
                EditPurchaseOrders();
                if (this.txtManufacturer.Tag != null)
                {



                    string strSQL = "";
                    strSQL = strSQL + " select (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName ) as ItemName, tblitems.TableRowGuid from tblitems ";
                    strSQL = strSQL + " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
                    strSQL = strSQL + " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
                    strSQL = strSQL + " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
                    strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
                    strSQL = strSQL + "  where ManufacturerGuid = '" + txtManufacturer.Tag.ToString() + "' Order By BrandName ";
                    CCommon.FillGridComboBox(this.gcboItem, strSQL, "TableRowGuid", "ItemName");











                   // CCommon.FillGridComboBox(this.gcboItem, "Select tblItems.TableRowGuid, BrandName as ItemName from tblItems where ManufacturerGuid = '" + txtManufacturer.Tag.ToString() + "' ORDER BY BrandName", "TableRowGuid", "ItemName");
                }
                FillPurchaseOrderDetailsGrid(CLocalPurchaseOrders.GetTableRowGuid(LocalPurchaseOrdersId));
                CalculateTotal();

                AdjsutOrderForEdit(CLocalPurchaseOrders.GetTableRowGuid(LocalPurchaseOrdersId));
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
        private void cboCurrencyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {               
                gvwPurchaseOrderDetail.Columns[GridColumnNames.PricePerUnit].HeaderText = GridColumnDescriptions.PricePerUnit + " (Birr)";
                gvwPurchaseOrderDetail.Columns[GridColumnNames.LineTotal].HeaderText = GridColumnDescriptions.LineTotal + " (Birr)";
                lblTotalFOBCurrency.Text = " (Birr)";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsPurchaseWithVAT)
                    ShowOrderVAT();
                else
                    ShowOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void txtManufacturer_TextChanged(object sender, EventArgs e)
        {

        }       
        private void SearchManufacturer(TextBox SearchTextBox, int HorizontalOffset, int VerticalOffset)
        {
            try
            {
                if (SearchTextBox.Text != "")
                {
                    CManufacturers objManufacturer = new CManufacturers();
                    string nameLike = SearchTextBox.Text + "%";
                    ArrayList ar = new ArrayList(objManufacturer.GetList(nameLike));
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

        #endregion

        #region Manufacturer Proforma Form Code

        private void FillGrigItemsCombo()
        {
            try
            {
                //if (CCommon.GetItemData(this.cboType) == ((int)CCommon.ProformaOrderType.Normal).ToString())
                CCommon.FillGridComboBox(this.gcboItem, "Select tblItems.TableRowGuid, BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name as ItemName from tblItems join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.Id) Order by ItemName ", "TableRowGuid", "ItemName");
                //else if (CCommon.GetItemData(this.cboType) == ((int)CCommon.ProformaOrderType.Sample).ToString())
                    //CCommon.FillGridComboBox(this.gcboItem, "Select tblItems.TableRowGuid, BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name as ItemName from tblItems join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.Id) Order by ItemName ", "TableRowGuid", "ItemName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        
        #endregion

        #region Purchase Order Detail Code

        #region GridColumnNames
        public class GridColumnNames
        {
            public const string Id = "Id";
            public const string OrderGuid = "PurchaseOrderGuid";
            public const string ItemGuid = "ItemGuid";
            public const string ItemDescription = "gcboItem";
            public const string Quantity = "Quantity";
            public const string PricePerUnit = "PricePerUnit";
            public const string LineTotal = "LineTotal";
        }
        #endregion
        #region GridColumnDescriptions
        public class GridColumnDescriptions
        {
            public const string Id = "Id";
            public const string OrderGuid = "Purchase Order Guid";
            public const string ItemGuid = "Item Guid";
            public const string ItemDescription = "Item";
            public const string Quantity = "Quantity";
            public const string PricePerUnit = "Price per Unit";
            public const string LineTotal = "Total";
        }
        #endregion

        private bool ValidatePurchaseOrderDetailRow(int intRowIndex)
        {
            try
            {
                double dblValue;
                bool CurrentRowIsVAT;
                if (gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemGuid].Value == null)
                {
                    gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Please select an item.";
                    return false;
                }
                else
                {
                    if (intRowIndex == 0)
                        IsPurchaseWithVAT = CItems.GetIsVATApplicable(Convert.ToString(gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemGuid].Value));
                    else
                    {
                        CurrentRowIsVAT = CItems.GetIsVATApplicable(Convert.ToString(gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemGuid].Value));
                        if (IsPurchaseWithVAT != CurrentRowIsVAT)
                        {
                            gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Can not create purchase order with VAT and Non VAT items";
                            return false;
                        }
                    }

                }

                if (gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.Quantity].Value != null)
                {
                    if (!double.TryParse(gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.Quantity].Value.ToString(), out dblValue))
                    {
                        gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Quantity must be a numeric value";
                        return false;
                    }
                }
                else
                {
                    gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Please enter the quantity.";
                    return false;
                }

                if (gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.PricePerUnit].Value != null)
                {
                    if (!double.TryParse(gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.PricePerUnit].Value.ToString(), out dblValue))
                    {
                        gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Price per Unit must be a numeric value";
                        return false;
                    }
                }
                else
                {
                    gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Please enter the Price per Unit.";
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
        private void SavePurchaseOrderDetails(string Purchaseordersguid)
        {
            try
            {
                for (int gvwRowIndex = 0; gvwRowIndex < gvwPurchaseOrderDetail.RowCount - 1; gvwRowIndex++)
                {
                    string strId = "";

                    if (!ValidatePurchaseOrderDetailRow(gvwRowIndex)) break;

                    CLocalPurchaseOrderDetails objPurchaseOrderDetails = new CLocalPurchaseOrderDetails();

                    if (gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value != null && Convert.ToString(gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value) != "")
                        strId = gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value.ToString();

                    if (LocalPurchaseOrdersId != 0)
                    {
                        objPurchaseOrderDetails.Id = 0;
                        objPurchaseOrderDetails.Purchaseorderguid = Purchaseordersguid;
                        objPurchaseOrderDetails.Itemguid = gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.ItemGuid].Value.ToString();
                        objPurchaseOrderDetails.Quantity = Convert.ToDecimal(gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Quantity].Value);
                        objPurchaseOrderDetails.Priceperunit = Convert.ToDecimal(gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.PricePerUnit].Value);

                        if (strId == string.Empty)
                        {
                            if (objPurchaseOrderDetails.Exists(true) > 0)
                            {
                                MessageBox.Show("There exists a Record with the selected item.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                // return;
                            }
                            else
                            {
                                objPurchaseOrderDetails.Insert();
                                gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value = objPurchaseOrderDetails.Id;
                            }
                        }
                        else
                        {
                            objPurchaseOrderDetails.Id = Convert.ToInt32(strId.ToString());
                            if (objPurchaseOrderDetails.Exists(false) > 0)
                            {
                                MessageBox.Show("There exists a Record with the selected item.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                //return;
                            }
                            else
                                objPurchaseOrderDetails.Update();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SavePurchaseOrderPayment(string Purchaseorderguid)
        {
            try
            {
                CLocalPurchaseOrderSettlements objLocalPurchaseOrderSettlements = new CLocalPurchaseOrderSettlements();

                objLocalPurchaseOrderSettlements.Id = 0;
                objLocalPurchaseOrderSettlements.Purchaseorderguid = Purchaseorderguid;
                objLocalPurchaseOrderSettlements.Bankguid = string.Empty;
                objLocalPurchaseOrderSettlements.Bankbranchname = string.Empty;
                objLocalPurchaseOrderSettlements.Modeofpayment = int.MinValue;
                objLocalPurchaseOrderSettlements.Checkorcponumber = string.Empty;
                objLocalPurchaseOrderSettlements.Checkorcpodate = DateTime.MinValue;
                objLocalPurchaseOrderSettlements.Checkmaturitydate = DateTime.MinValue;               
                objLocalPurchaseOrderSettlements.Settled = (int)CCommon.PaymentSettlement.NotSettled;
                objLocalPurchaseOrderSettlements.Settlementdate = DateTime.MinValue;
                objLocalPurchaseOrderSettlements.Userid = Program.strUserName;
                objLocalPurchaseOrderSettlements.Eventsource = (int)CCommon.EventSource.System;
                objLocalPurchaseOrderSettlements.Computername = System.Windows.Forms.SystemInformation.ComputerName;
                if(objLocalPurchaseOrderSettlements.Exists(true) <= 0)
                    objLocalPurchaseOrderSettlements.Insert();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void FillPurchaseOrderDetailsGrid(string Purchaseordersguid)
        {
            try
            {

                CLocalPurchaseOrderDetails objPurchaseOrderDetails = new CLocalPurchaseOrderDetails();

                ArrayList ar = new ArrayList(objPurchaseOrderDetails.GetList(Purchaseordersguid));
                if (this.gvwPurchaseOrderDetail.RowCount > 1)
                    this.gvwPurchaseOrderDetail.Rows.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrderDetails objPurchaseOrderDetail in ar)
                {
                    gvwPurchaseOrderDetail.Rows.Add(new string[] { objPurchaseOrderDetail.Id.ToString(), 
                                                            objPurchaseOrderDetail.Purchaseorderguid.ToString(),
                                                            objPurchaseOrderDetail.Itemguid.ToString(),
                                                            objPurchaseOrderDetail.Itemguid.ToString().Trim(),
                                                            objPurchaseOrderDetail.Quantity.ToString(CSettings.CurrencyFormat),
                                                            objPurchaseOrderDetail.Priceperunit.ToString(CSettings.CurrencyFormat),
                                                            (objPurchaseOrderDetail.Quantity*objPurchaseOrderDetail.Priceperunit).ToString(CSettings.CurrencyFormat),});

                    IsPurchaseWithVAT = CItems.GetIsVATApplicable(objPurchaseOrderDetail.Itemguid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrderDetailsGridFromProforma(string Manufacturerproformasguid)
        {
            try
            {

                CManufacturerProformaDetails objManufacturerProformaDetails = new CManufacturerProformaDetails();

                ArrayList ar = new ArrayList(objManufacturerProformaDetails.GetList(Manufacturerproformasguid));
                if (this.gvwPurchaseOrderDetail.RowCount > 1)
                    this.gvwPurchaseOrderDetail.Rows.Clear();
                if (ar.Count < 0) return;

                foreach (CManufacturerProformaDetails objManufacturerProformaDetail in ar)
                {
                    gvwPurchaseOrderDetail.Rows.Add(new string[] { string.Empty, 
                                                            objManufacturerProformaDetail.Manufacturerproformaguid.ToString(),
                                                            objManufacturerProformaDetail.Itemguid.ToString(),
                                                            objManufacturerProformaDetail.Itemguid.ToString().Trim(),
                                                            objManufacturerProformaDetail.Quantity.ToString(CSettings.CurrencyFormat),
                                                            objManufacturerProformaDetail.Priceperunit.ToString(CSettings.CurrencyFormat),
                                                            (objManufacturerProformaDetail.Quantity*objManufacturerProformaDetail.Priceperunit).ToString(CSettings.CurrencyFormat)});


                }

                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RowLeaveTasks(int intRowIndex)
        {
            try
            {
                DataGridViewComboBoxCell gvwComboBoxCell;
                string Itemguid = string.Empty;

                gvwComboBoxCell = gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemDescription] as DataGridViewComboBoxCell;
                if (gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemDescription].Value != null)
                    Itemguid = gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemDescription].Value.ToString();
                gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemGuid].Value = Itemguid;

                gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.LineTotal].Value = CalculateGridLineTotal(gvwPurchaseOrderDetail, intRowIndex).ToString(CSettings.CurrencyFormat);
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal CalculateGridLineTotal(DataGridView dataGridView, int intRowIndex)
        {
            try
            {
                string strQuantity = string.Empty;
                string strPricePerUnit = string.Empty;

                decimal decQuantity = 0;
                decimal decPricePerUnit = 0;
                decimal decLineTotal = 0;

                if (dataGridView.Rows[intRowIndex].Cells[GridColumnNames.Quantity].Value != null)
                    strQuantity = dataGridView.Rows[intRowIndex].Cells[GridColumnNames.Quantity].Value.ToString();
                if (dataGridView.Rows[intRowIndex].Cells[GridColumnNames.PricePerUnit].Value != null)
                    strPricePerUnit = dataGridView.Rows[intRowIndex].Cells[GridColumnNames.PricePerUnit].Value.ToString();

                if (strQuantity != string.Empty) decQuantity = Convert.ToDecimal(strQuantity);
                if (strPricePerUnit != string.Empty) decPricePerUnit = Convert.ToDecimal(strPricePerUnit);

                decLineTotal = decQuantity * decPricePerUnit;

                return decLineTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return decimal.Zero;
            }
        }
        private decimal CalculateGridTotal(DataGridView dataGridView)
        {
            try
            {
                decimal decTotal = 0;
                decimal decLineTotal = 0;

                for (int intRowIndex = 0; intRowIndex < dataGridView.RowCount - 1; intRowIndex++)
                {
                    decLineTotal = CalculateGridLineTotal(dataGridView, intRowIndex);
                    decTotal = decTotal + decLineTotal;
                }

                return decTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return decimal.Zero;
            }
        }
        private void CalculateTotal()
        {
            try
            {
                decimal decTotalFOB = 0;
                //decimal decFreightCharge = 0;
                //decimal decTotalCandF = 0;

                decTotalFOB = CalculateGridTotal(gvwPurchaseOrderDetail);
                this.txtTotalFOB.Text = decTotalFOB.ToString(CSettings.CurrencyFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvwPurchaseOrderDetail_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowLeaveTasks(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsOrderEditAllowed()) return;

                SavePurchaseOrderDetails(CLocalPurchaseOrders.GetTableRowGuid(LocalPurchaseOrdersId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsOrderEditAllowed()) return;

                for (int gvwRowIndex = 0; gvwRowIndex < gvwPurchaseOrderDetail.RowCount; gvwRowIndex++)
                {
                    if (gvwPurchaseOrderDetail.SelectedRows.Contains(gvwPurchaseOrderDetail.Rows[gvwRowIndex]))
                    {
                        if (MessageBox.Show("Are you sure to delete the " + Convert.ToString(gvwRowIndex + 1) + " row?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CLocalPurchaseOrderDetails objPurchaseOrderDetails = new CLocalPurchaseOrderDetails();
                            objPurchaseOrderDetails.Id = Convert.ToInt32(gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value);
                            objPurchaseOrderDetails.Delete();
                            gvwPurchaseOrderDetail.Rows[gvwRowIndex].Visible = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        #endregion

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
               
        private void btnSearchManufacturer1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchManufacturer(txtManufacturer, grpOrder.Left, grpOrder.Top);
                if (this.txtManufacturer.Tag != null)
                {
                    string strSQL = "";
                    strSQL = strSQL + " select (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName ) as ItemName, tblitems.TableRowGuid from tblitems ";
                    strSQL = strSQL + " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
                    strSQL = strSQL + " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
                    strSQL = strSQL + " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
                    strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
                    strSQL = strSQL + "  where ManufacturerGuid = '" + txtManufacturer.Tag.ToString() + "' Order By BrandName ";
                    CCommon.FillGridComboBox(this.gcboItem, strSQL, "TableRowGuid", "ItemName");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

    }
}
