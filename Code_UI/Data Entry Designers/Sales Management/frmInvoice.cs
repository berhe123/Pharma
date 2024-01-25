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
    public partial class frmInvoice : Form
    {
        private const string DialogCaption = "Invoice";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector childSelector = null;

        private string LicenseGuid = string.Empty;
        private string CustomerGuidSearch = string.Empty;
        //private string CustomerGuidSearchReq = string.Empty;
        private string InvoiceCustomerGuid = string.Empty;
        private string RequesitionGuid = string.Empty;
        private string CustomerGuid = string.Empty;
        private int intInvoiceDetailId = 0;
        private bool bNewInvoices = true;
        private int InvoicesId = 0;
        private string CashCollectionsGuid = string.Empty;
        public bool IsNumberGenerated =false;
        public int intDeliveryStatus;
        private int intTransactionId = 0;
        private string strItemGuid = string.Empty;

        private string strBatchGuid = string.Empty;
 
        public frmInvoice()
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

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                txtInvoiceDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtInvoiceDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtInvoiceDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtPreparedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtCheckedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtInvoiceApproveDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
              

                CCommon.FillInvoiceTypeCombo(cboInvoiceType);
                CCommon.FillDeliveryStatusCombo(cboDeliveryStatus, false);
                cboDeliveryStatus.SelectedIndex = 0;

                if (intDeliveryStatus == (int)CCommon.DeliveryStatus.Pending)
                {
                    grbDelivery.Enabled = false;
                    grbReturning.Enabled = true;
                }
                else if (intDeliveryStatus == (int)CCommon.DeliveryStatus.Delivered)
                {
                    btnNew.Enabled = false;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    grbDelivery.Enabled = true;
                    grbReturning.Enabled = true;
                    txtDeliveredBy.Text = "";
                    txtDeliveryDate.Text = "";
                }
                else if (intDeliveryStatus == (int)CCommon.DeliveryStatus.Returned)
                {
                    btnNew.Enabled = false;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    grbDelivery.Enabled = false;
                    grbReturning.Enabled = true;
                    txtReturningReason.Text = "";
                    txtReturnedDate.Text = "";
                }
                NewInvoice();
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
                //strCriteria = strCriteria + " And DeliveryStatus = " + (int)CCommon.eDeliveryStatus;

                if (CustomerGuidSearch != string.Empty & txtCustomerName.Text != "")
                    strCriteria = strCriteria + " And CustomerGuid = '" + CustomerGuidSearch + "' ";
                if (txtInvoiceDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtInvoiceDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And InvoiceDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtInvoiceDateTo.Text != "")
                    if (DateTime.TryParseExact(txtInvoiceDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And InvoiceDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
                FillInvoiceList(strCriteria);
                NewInvoice();
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

                ArrayList ar = new ArrayList(objInvoice.GetList(strCriteria));
                this.lvwTransactions.Items.Clear();
                if (ar.Count <= 0) return;

                foreach (CInvoices Invoice in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Invoice.Id.ToString(),
                                                                                      Invoice.Customerguid.ToString(),  
                                                                                      Invoice.OrganizationName.ToString(), 
                                                                                      Invoice.Attachmentreferencenumber.ToString(), 
                                                                                      Invoice.Referencenumber.ToString(),
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
                                                                                      Invoice.Suppliesrequisitionguid.ToString(),
                                                                                      Invoice.Discount.ToString(),
                                                                                      Invoice.ReturnedReason.ToString(),
                                                                                      Invoice.ReturnedDate.ToString(CSettings.DateFormat),
                                                                                      Invoice.VAT.ToString()});

                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NewInvoice()
        {
            try
            {
                CashCollectionsGuid = string.Empty;
                InvoicesId = 0;
                bNewInvoices = true;
                IsNumberGenerated = false;
                txtInvoiceCustormerName.Text = "";
                lvwRequisitionItems.Items.Clear();

                txtInvoiceCustormerName.Text = "";
                txtAttachmentReferenceNumber.Text = "";
                txtInvoiceNo.Text = "";
                
                txtInvoiceDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                SetDueDate();
                cboInvoiceType.SelectedIndex = CCommon.GetIndexByItemData(cboInvoiceType, CSettings.InvoiceInvoiceType.ToString(), true);
                txtPreparedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtPreparedBy.Text = CSettings.InvoicePreparedBy;
                txtCheckedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtChekedBy.Text = CSettings.InvoiceCheckedBy;
                txtInvoiceApproveDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtInvoiceApprovedBy.Text = CSettings.InvoiceApprovedBy;
                this.txtDeliveredBy.Text = CSettings.InvoiceDeliveredBy;
                this.txtDeliveryDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtVAT.Text = "0";
                txtInvoiceDiscount.Text = "0";

                txtSubTotal.Text = "0";
                txtDiscountAmount.Text = "0";
                txtVATAmount.Text = "0";
                txtInvoiceTotalAmount.Text = "0";
                
              
                grvTransactionDetails.Rows.Clear();                
                // 9746 = Last used paper invoice number
                int maxReferenceNumber = CInvoices.GetMaxReferenceNumber();
                this.txtInvoiceNo.Text = "0" + (maxReferenceNumber + 1).ToString();
                
                txtReturningReason.Text = "";

                lblVoid.Visible = false;
                //GetMaxReferenceNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsRequistionForPsychotropic()
        {
            return CSuppliesRequisitions.IsRequisitionForPsychotropic(RequesitionGuid);
        }
        private void GetMaxReferenceNumber()
        {
            try
            {

                bool IsRequisitionForPsychotropic = IsRequistionForPsychotropic();
                IsNumberGenerated = false;
                int maxReferenceNumber = 0;
                //maxReferenceNumber = CInvoices.GetMaxAttachmentReferenceNumber();
                //this.txtAttachmentReferenceNumber.Text = "0" + (maxReferenceNumber + 1).ToString();
                maxReferenceNumber = CInvoices.GetMaxReferenceNumberCash();
                

                if (maxReferenceNumber > 0)
                {
                    this.txtAttachmentReferenceNumber.Text = "0" + (maxReferenceNumber + 1).ToString();
                    IsNumberGenerated = true;
                }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
        private void cboInvoiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboInvoiceType.SelectedIndex != -1)
                    if (Convert.ToInt16(CCommon.GetItemData(cboInvoiceType)) == (int)CCommon.InvoiceType.CreditSales)
                        txtDueDate.Enabled = true;
                    else
                        txtDueDate.Enabled = false;
                //GetMaxReferenceNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewSuppliesRequisitions()
        {
            try
            {
                txtInvoiceCustormerName.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool FindSuppliesRequisitions(string Suppliesrequisitionguid)
        {
            try
            {
                CCustomers objCustomer;
                CSuppliesRequisitions objSuppliesRequisitions = new CSuppliesRequisitions();
                DataTable dt = new DataTable();

                objSuppliesRequisitions.Id = CSuppliesRequisitions.GetTableRowId(Suppliesrequisitionguid);
                dt = objSuppliesRequisitions.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    txtSuppliesRequisitionReferenceNumber.Tag = objSuppliesRequisitions.Tablerowguid;
                    CustomerGuid = objSuppliesRequisitions.Customerguid;
                    txtInvoiceCustormerName.Tag = objSuppliesRequisitions.Customerguid;
                    txtInvoiceCustormerName.Text = CCustomers.GetCustomerNameFromCollection(objSuppliesRequisitions.Customerguid);
                    txtSuppliesRequisitionReferenceNumber.Text = Convert.ToString(objSuppliesRequisitions.ReferenceNumber);
                    //txtRequestedBy.Text = Convert.ToString(objSuppliesRequisitions.RequestedBy);
                    //txtRequestedDate.Text = Convert.ToString(objSuppliesRequisitions.Requestdate);
                    //txtApprovedBy.Text = Convert.ToString(objSuppliesRequisitions.Approvedby);
                    //txtApprovedDate.Text = Convert.ToString(objSuppliesRequisitions.Approvaldate);
                    //txtChekedBy.Text = Convert.ToString(objSuppliesRequisitions.Checkedby);
                    //txtCheckedDate.Text = Convert.ToString(objSuppliesRequisitions.Checkeddate);

                    this.txtInvoiceDate.Text = objSuppliesRequisitions.Requestdate.ToString(CSettings.DateFormat);
                    this.txtInvoiceApproveDate.Text = objSuppliesRequisitions.Requestdate.ToString(CSettings.DateFormat);
                    this.txtPreparedDate.Text = objSuppliesRequisitions.Requestdate.ToString(CSettings.DateFormat);
                    this.txtCheckedDate.Text = objSuppliesRequisitions.Requestdate.ToString(CSettings.DateFormat);
                    //LicenseGuid = objSuppliesRequisitions.Licenseguid;
                    //FindLicenses(LicenseGuid);

                    objCustomer = new CCustomers();
                    if (bNewInvoices)
                        txtInvoiceDiscount.Text = objCustomer.GetCustomerDiscountRate(objSuppliesRequisitions.Customerguid).ToString();
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
        private void FillRequisitonDetailList(string Requisitionguid)
        {
            try
            {

                CSuppliesRequisitionDetails objReqDetails = new CSuppliesRequisitionDetails();

                ArrayList ar = new ArrayList(objReqDetails.GetList(Requisitionguid));

                if (ar.Count <= 0) return;
                lvwRequisitionItems.Items.Clear();
                foreach (CSuppliesRequisitionDetails RequesitionDetail in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {  RequesitionDetail.Id.ToString(), 
                                                                    RequesitionDetail.Itemguid.ToString(),
                                                                    RequesitionDetail.Suppliesrequisitionguid.ToString(),
                                                                    RequesitionDetail.BrandName.ToString(),                                        
                                                                   // RequesitionDetail.Unit.ToString(),
                                                                    RequesitionDetail.Requestedquantity.ToString(),                                                            
                                                                    RequesitionDetail.Approvedquantity.ToString()
                    });
                    this.lvwRequisitionItems.Items.Add(itmX);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool FindLicenses(string Licenseguid)
        {
            try
            {
                CLicenses license = new CLicenses();
                DataTable dt = new DataTable();

                license.Id = CLicenses.GetTableRowId(Licenseguid);
                dt = license.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    lblLicense.Text = "Licensee: " + license.Firstname + " " + license.Fathername + " " + license.Grandname;
                    lblLicense.Text += ",  " + license.LevelName;
                    lblLicense.Text += ";  License #: " + license.Licensenumber;

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

        private void PrepareInvoice()
        {
            try
            {
                CInvoices objInvoice = new CInvoices();
                if (RequesitionGuid != string.Empty)
                {
                    objInvoice.Suppliesrequisitionguid = RequesitionGuid;
                    if (!objInvoice.CheckIfRequisitionHasInvoice())
                    {
                        InvoiceCustomerGuid = CustomerGuid;
                        bNewInvoices = true;
                        InvoicesId = 0;
                        if (objInvoice.CheckIfVATIsApplicable())
                            txtVAT.Text = CSettings.VATPercentage.ToString();
                        else
                            txtVAT.Text = "0";

                        FillInvoiceDetailGrid(RequesitionGuid);
                        CalculateTotal();
                        //GetMaxReferenceNumber();
                        InvoicesId = objInvoice.GetInvoiceIdFromRequisitionGuid();
                    }
                    else
                    {
                        MessageBox.Show("An invoice is already prepared with the given requisition.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        InvoicesId = objInvoice.GetInvoiceIdFromRequisitionGuid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrepareInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                PrepareInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private decimal GetTotalAmount()
        {
            try
            {
                decimal decReturn = decimal.Zero;
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount - 1; grRow++)
                {
                    decReturn = decReturn + Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colTotalPrice"].Value);
                }
                return decReturn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return decimal.Zero;
            }
        }
        private void FillInvoiceDetailGrid(string Requisitionguid)
        {
            try
            {

                CInvoices objInvDetails = new CInvoices();
                ArrayList ar = new ArrayList(objInvDetails.GetListForInvoice(Requisitionguid));

                if (ar.Count <= 0)
                MessageBox.Show("This Batch is Not Received or Not Sellable By the Store.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                grvTransactionDetails.Rows.Clear();
                foreach (CInvoices InvoiceDetail in ar)
                {

                    if (objInvDetails.CheckIfQuantityIsAvailable(InvoiceDetail.Itemguid,InvoiceDetail.Sellablebatchguid, InvoiceDetail.ApprovedQuantity))
                    {
                        //there onther if checking weather the batch is received.
                        //Store Transaction Detail 
                        //check weather the batch has receiving 
                        //TransactionType should be receiving 
                        strBatchGuid = InvoiceDetail.Sellablebatchguid;
                        CStoreTransactionDetails receiving = new CStoreTransactionDetails();
                        //receiving.Transactiontype = strtransaction;
                        int intNumberOfRows = receiving.CheckWeatherBatchIsReceived(strBatchGuid);
                        if (intNumberOfRows <= 0)
                            MessageBox.Show("This Batch is Not Received By the Store.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        else     

                        grvTransactionDetails.Rows.Add(new string[] {   intInvoiceDetailId.ToString(),
                                                                        InvoiceDetail.Sellablebatchguid.ToString(), 
                                                                        InvoiceDetail.SellableBatchName.ToString(),
                                                                        InvoiceDetail.BrandName.ToString(),
                                                                        InvoiceDetail.Unit.ToString(),                                        
                                                                        InvoiceDetail.ApprovedQuantity.ToString(),
                                                                        InvoiceDetail.SalePrice.ToString(), 
                                                                        InvoiceDetail.TotalPrice.ToString(CSettings.CurrencyFormat)
                                                                        
                        });
                    }
                    else
                    {
                        if (MessageBox.Show("The item " + InvoiceDetail.BrandName.ToString() + " does not have enough quatity on the sellable batch. Do you want to sell the remaining quantity from another batch?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (objInvDetails.SellableBatchRemainingQuantity > 0)
                            {
                                grvTransactionDetails.Rows.Add(new string[] {   intInvoiceDetailId.ToString(),
                                                                        InvoiceDetail.Sellablebatchguid.ToString(), 
                                                                        InvoiceDetail.SellableBatchName.ToString(),
                                                                        InvoiceDetail.BrandName.ToString(),
                                                                        InvoiceDetail.Unit.ToString(),                                        
                                                                        objInvDetails.SellableBatchRemainingQuantity.ToString(),
                                                                        InvoiceDetail.SalePrice.ToString(),
                                                                        (objInvDetails.SellableBatchRemainingQuantity *InvoiceDetail.SalePrice).ToString(CSettings.CurrencyFormat)                                                                        
                                                                        
                             });
                            }
                            frmChangeSellableBatch childForm = new frmChangeSellableBatch();
                            childForm.Itemguid = InvoiceDetail.Itemguid;
                            childForm.BrandName = InvoiceDetail.SellableBatchName;
                            childForm.QuantityRequired = objInvDetails.QuantityRequiredFromNextBatch;
                            childForm.ShowDialog();
                            if (!childForm.Canceled)
                            {
                                CInvoices objNewInvDetails = new CInvoices();
                                ArrayList arNew = new ArrayList(objInvDetails.GetListForInvoiceChangedBatch(InvoiceDetail.Itemguid));
                                CInvoices NewInvoiceDetail = (CInvoices)arNew[0];
                                grvTransactionDetails.Rows.Add(new string[] {   intInvoiceDetailId.ToString(),
                                                                        NewInvoiceDetail.Sellablebatchguid.ToString(), 
                                                                        NewInvoiceDetail.SellableBatchName.ToString(),
                                                                        NewInvoiceDetail.BrandName.ToString(),
                                                                        NewInvoiceDetail.Unit.ToString(),                                        
                                                                        objInvDetails.QuantityRequiredFromNextBatch.ToString(),
                                                                        NewInvoiceDetail.SalePrice.ToString(),
                                                                        (objInvDetails.QuantityRequiredFromNextBatch * NewInvoiceDetail.SalePrice).ToString(CSettings.CurrencyFormat)                                                                        
                                                                        
                                });
                            }
                            
                        }
                        
                       
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInvoiceDetailGridByInvoice(string Invoiceguid, string Requesitionguid)
        {
            try
            {

                CInvoices objInvDetails = new CInvoices();

                ArrayList ar = new ArrayList(objInvDetails.GetListForInvoice(Invoiceguid, Requesitionguid));

                if (ar.Count <= 0) return;
                grvTransactionDetails.Rows.Clear();
                foreach (CInvoices InvoiceDetail in ar)
                {
                    grvTransactionDetails.Rows.Add(new string[] {   InvoiceDetail.Invoicedetailid.ToString(),
                                                                    InvoiceDetail.Sellablebatchguid.ToString(), 
                                                                    InvoiceDetail.SellableBatchName.ToString(),
                                                                    InvoiceDetail.BrandName.ToString(),
                                                                    InvoiceDetail.Unit.ToString(),                                        
                                                                    InvoiceDetail.ApprovedQuantity.ToString(),
                                                                    InvoiceDetail.UnitPrice.ToString(CSettings.CurrencyFormat),                                                            
                                                                    InvoiceDetail.TotalPrice.ToString(CSettings.CurrencyFormat)
                    });


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private bool IsValidInvoices()
        {
            try
            {
                DateTime dteValidate;
                if (!CCommon.SetRequiredMessage(txtAttachmentReferenceNumber, "attachment reference number can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtInvoiceCustormerName, "Customer can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtInvoiceNo, "Reference number can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtInvoiceDate, "Invoice date can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(cboInvoiceType, "Invoice type can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtPreparedBy, "Prepared by can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtChekedBy, "Checked by can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtInvoiceApprovedBy, "Approved by can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtPreparedDate, "Prepared date can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtCheckedDate, "Checked date can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtInvoiceApproveDate, "Approval date can not be empty", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtPreparedDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtPreparedDate, "Prepared date must be in Date Format", mValidator, lblMsg);
                    return false;
                }
                if (!DateTime.TryParseExact(txtCheckedDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtCheckedDate, "Checked date must be in Date Format", mValidator, lblMsg);
                    return false;
                }
                if (!DateTime.TryParseExact(txtInvoiceApproveDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtInvoiceApproveDate, "Checked date must be in Date Format", mValidator, lblMsg);
                    return false;
                }
                if (Convert.ToDouble(txtInvoiceTotalAmount.Text) <= 0)
                {
                    CCommon.SetMessage(txtInvoiceTotalAmount, "Invoice Total Can not be empty", mValidator, lblMsg);
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
        private bool IsValidInvoicesDelivered()
        {
            try
            {
                DateTime dteValidate;
                if (!CCommon.SetRequiredMessage(txtDeliveredBy, "Delivered by can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtDeliveryDate, "Delivered date can not be empty", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtDeliveryDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtDeliveryDate, "Delivered date must be in Date Format", mValidator, lblMsg);
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
        private bool IsValidInvoicesReturned()
        {
            try
            {
                DateTime dteValidate;
                if (!CCommon.SetRequiredMessage(txtReturningReason, "Returned Reason can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtReturnedDate, "Returned date can not be empty", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtReturnedDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtReturnedDate, "Returned date must be in Date Format", mValidator, lblMsg);
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
        private bool ValidateRow(int grRow)
        {
            try
            {
                decimal dcmValue;

                if (grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value == null)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The quantity can not be empty";
                    return false;
                }
                if (!decimal.TryParse(grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value.ToString(), out dcmValue))
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The quantity must be numeric";
                    return false;
                }
                if (dcmValue <= 0)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The quantity must be greather than 0";
                    return false;
                }
                dcmValue = decimal.Zero;
                if (grvTransactionDetails.Rows[grRow].Cells["colUnitPrice"].Value == null)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The unit price can not be empty";
                    return false;
                }
                if (!decimal.TryParse(grvTransactionDetails.Rows[grRow].Cells["colUnitPrice"].Value.ToString(), out dcmValue))
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The unit price must be numeric";
                    return false;
                }
                if (dcmValue <= 0)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The unit price must be greather than 0";
                    return false;
                }
               
                grvTransactionDetails.Rows[grRow].ErrorText = null;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool SaveInvoices()
        {
            try
            {
                if (!IsValidInvoices()) return false;

                CInvoices objInvoices = new CInvoices();
                objInvoices.Id = InvoicesId;
                objInvoices.Customerguid = InvoiceCustomerGuid;
                objInvoices.Licenseguid = LicenseGuid;

                if (IsNumberGenerated)
                {
                    objInvoices.AttachmentNumberGenerated = true;
                    objInvoices.ReferenceNumberPsychotropic = string.Empty;
                    objInvoices.ReferenceNumberCash = string.Empty;
                    objInvoices.ReferenceNumberCredit = string.Empty;
                    objInvoices.ReferenceNumberFreeOfCharge = string.Empty;

                    if (IsRequistionForPsychotropic() == true)
                        objInvoices.ReferenceNumberPsychotropic = Convert.ToString(txtAttachmentReferenceNumber.Text);
                    else if (CCommon.GetItemData(cboInvoiceType) == ((int)CCommon.InvoiceType.CashSales).ToString())
                        objInvoices.ReferenceNumberCash = Convert.ToString(txtAttachmentReferenceNumber.Text);
                    else if (CCommon.GetItemData(cboInvoiceType) == ((int)CCommon.InvoiceType.CreditSales).ToString())
                        objInvoices.ReferenceNumberCredit = Convert.ToString(txtAttachmentReferenceNumber.Text);
                    else if (CCommon.GetItemData(cboInvoiceType) == ((int)CCommon.InvoiceType.FreeOfCharge).ToString())
                        objInvoices.ReferenceNumberFreeOfCharge = Convert.ToString(txtAttachmentReferenceNumber.Text);
                }
                else
                {
                    objInvoices.AttachmentNumberGenerated = false;
                }
                objInvoices.Attachmentreferencenumber = Convert.ToString(txtAttachmentReferenceNumber.Text);
                objInvoices.Referencenumber = Convert.ToString(txtInvoiceNo.Text);
                objInvoices.Invoicedate = Convert.ToDateTime(txtInvoiceDate.Text, CSettings.Culture);
                objInvoices.Invoicetype = Convert.ToInt32(CCommon.GetItemData(cboInvoiceType));
                objInvoices.Deliverystatus = (int)CCommon.DeliveryStatus.Pending;
                if (Convert.ToInt32(CCommon.GetItemData(cboInvoiceType)) == (int)CCommon.InvoiceType.CreditSales)
                    objInvoices.Duedate = Convert.ToDateTime(txtDueDate.Text, CSettings.Culture);
                else
                    objInvoices.Duedate = DateTime.MinValue;
                objInvoices.Preparedby = Convert.ToString(txtPreparedBy.Text);
                objInvoices.Checkedby = Convert.ToString(txtChekedBy.Text);
                objInvoices.Approvedby = Convert.ToString(txtInvoiceApprovedBy.Text);
                objInvoices.Prepareddate = Convert.ToDateTime(txtPreparedDate.Text, CSettings.Culture);
                objInvoices.Checkeddate = Convert.ToDateTime(txtCheckedDate.Text, CSettings.Culture);
                objInvoices.Approvaldate = Convert.ToDateTime(txtInvoiceApproveDate.Text, CSettings.Culture);
                objInvoices.Discount = Convert.ToDecimal(txtInvoiceDiscount.Text);
                objInvoices.VAT = Convert.ToDecimal(txtVAT.Text);
                objInvoices.Suppliesrequisitionguid = RequesitionGuid;

                if (objInvoices.Exists(bNewInvoices) > 0)
                {
                    MessageBox.Show("There exists an invoice record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewInvoices)
                    objInvoices.Insert();
                else
                    objInvoices.Update();

                InvoicesId = objInvoices.Id;
                IsNumberGenerated = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool DeliverInvoices()
        {

            try
            {
                if (!IsValidInvoicesDelivered()) return false;

                CInvoices objInvoices = new CInvoices();

                objInvoices.Id = InvoicesId;
                objInvoices.Deliveredby = Convert.ToString(txtDeliveredBy.Text);
                objInvoices.Deliverydate = Convert.ToDateTime(txtDeliveryDate.Text, CSettings.Culture);
                objInvoices.Deliverystatus = (int)CCommon.DeliveryStatus.Delivered;

                objInvoices.UpdateDelivered();

                InvoicesId = objInvoices.Id;
                    
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool ReturnInvoices()
        {

            try
            {
                if (!IsValidInvoicesReturned()) return false;

                CInvoices objInvoices = new CInvoices();

                objInvoices.Id = InvoicesId;
                objInvoices.ReturnedReason = Convert.ToString(txtReturningReason.Text);
                objInvoices.ReturnedDate = Convert.ToDateTime(txtReturnedDate.Text, CSettings.Culture);
                objInvoices.Deliverystatus = (int)CCommon.DeliveryStatus.Returned;

                objInvoices.UpdateReturned();

                InvoicesId = objInvoices.Id;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void EditInvoices()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwTransactions.SelectedItems[0];

                bNewInvoices = false;
                IsNumberGenerated = false;
                CashCollectionsGuid = string.Empty;
                InvoicesId = Convert.ToInt32(itmX.SubItems[colInvoiceId.Index].Text);
                InvoiceCustomerGuid = itmX.SubItems[colInvoiceCustomerGuid.Index].Text;
                cboInvoiceType.SelectedIndex = CCommon.GetIndexByItemData(cboInvoiceType, Convert.ToString(itmX.SubItems[colInvoiceType.Index].Text), true);
                txtInvoiceCustormerName.Text = Convert.ToString(itmX.SubItems[colOrganizationName.Index].Text);
                txtAttachmentReferenceNumber.Text = Convert.ToString(itmX.SubItems[colAttachmentReferenceNumber.Index].Text);
                txtInvoiceNo.Text = Convert.ToString(itmX.SubItems[colReferenceNumber.Index].Text);
                txtInvoiceDate.Text = Convert.ToString(itmX.SubItems[colInvoiceDate.Index].Text);
                if (Convert.ToInt32(itmX.SubItems[colInvoiceType.Index].Text) == (int)CCommon.InvoiceType.CreditSales)
                    txtDueDate.Text = Convert.ToString(itmX.SubItems[colDueDate.Index].Text);

                txtPreparedBy.Text = Convert.ToString(itmX.SubItems[colPreparedBy.Index].Text);
                txtChekedBy.Text = Convert.ToString(itmX.SubItems[colCheckedBy.Index].Text);
                txtInvoiceApprovedBy.Text = Convert.ToString(itmX.SubItems[colApprovedBy.Index].Text);
                txtPreparedDate.Text = Convert.ToString(itmX.SubItems[colPreparedDate.Index].Text);
                txtCheckedDate.Text = Convert.ToString(itmX.SubItems[colCheckedDate.Index].Text);
                txtInvoiceApproveDate.Text = Convert.ToString(itmX.SubItems[colApprovalDate.Index].Text);
                txtSuppliesRequisitionReferenceNumber.Tag = itmX.SubItems[colSuppliesRequisitionGuid.Index].Text;
                txtInvoiceDiscount.Text = Convert.ToString(itmX.SubItems[colDiscount.Index].Text);
                txtVAT.Text = Convert.ToString(itmX.SubItems[colVAT.Index].Text);
                RequesitionGuid = itmX.SubItems[colSuppliesRequisitionGuid.Index].Text;

                this.txtDeliveredBy.Text = Convert.ToString(itmX.SubItems[colDeliveredBy.Index].Text);
                this.txtDeliveryDate.Text = Convert.ToString(itmX.SubItems[colDeliveryDate.Index].Text);
                if (intDeliveryStatus == (int)CCommon.DeliveryStatus.Pending)
                    this.txtDeliveryDate.Text = Convert.ToString(itmX.SubItems[colInvoiceDate.Index].Text);

                this.txtReturningReason.Text = Convert.ToString(itmX.SubItems[colReturningReason.Index].Text);
                this.txtReturnedDate.Text = Convert.ToString(itmX.SubItems[colReturnDate.Index].Text);
                if (intDeliveryStatus == (int)CCommon.DeliveryStatus.Pending)
                    this.txtReturnedDate.Text = Convert.ToString(itmX.SubItems[colInvoiceDate.Index].Text);

                if (this.intDeliveryStatus == (int)CCommon.DeliveryStatus.Delivered)
                {
                    this.txtDeliveredBy.Text = txtDeliveredBy.Text.Length <= 0 ? CSettings.InvoiceDeliveredBy : txtDeliveredBy.Text;
                    this.txtDeliveryDate.Text = txtDeliveryDate.Text.Length <= 0 ? this.txtInvoiceDate.Text : txtDeliveryDate.Text;
                }
                else if (this.intDeliveryStatus == (int)CCommon.DeliveryStatus.Returned)
                {
                    this.txtReturningReason.Text = txtReturningReason.Text.Length <= 0 ? CSettings.InvoiceReturningReason : txtReturningReason.Text;
                    this.txtReturnedDate.Text = txtReturnedDate.Text.Length <= 0 ? this.txtInvoiceDate.Text : txtReturnedDate.Text;
                }

                int DeliveryStatus = Convert.ToInt32(itmX.SubItems[colDeliveryStatus.Index].Text);
                if (DeliveryStatus == (int)CCommon.DeliveryStatus.Pending)
                {
                    this.lblDelivered.Visible = false;
                    this.lblVoid.Visible = false;
                    this.txtDeliveryDate.Text = this.txtInvoiceDate.Text;
                    this.txtReturnedDate.Text = this.txtInvoiceDate.Text;
                }
                else if (DeliveryStatus == (int)CCommon.DeliveryStatus.Delivered)
                {
                    this.lblDelivered.Visible = true;
                    this.lblVoid.Visible = false;
                    this.txtReturnedDate.Text = this.txtInvoiceDate.Text;
                }
                else if (DeliveryStatus == (int)CCommon.DeliveryStatus.Returned)
                {
                    this.lblDelivered.Visible = false;
                    this.lblVoid.Visible = true;
                    this.txtDeliveryDate.Text = this.txtInvoiceDate.Text;
                }

                FillInvoiceDetailGridByInvoice(CInvoices.GetTableRowGuid(InvoicesId), RequesitionGuid);
                //this.FindInvoices();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveInvoiceDetail()
        {
            try
            {
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount - 1; grRow++)
                {
                    int tran_id = 0;
                    bool blnNewInvDetail = false;
                    if (!ValidateRow(grRow)) break;
                    CInvoiceDetails objInvDetail = new CInvoiceDetails();
                    if (Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value.ToString()) == 0)
                    {
                        blnNewInvDetail = true;
                        tran_id = 0;
                    }
                    else
                    {
                        blnNewInvDetail = false;
                        tran_id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                    }
                    objInvDetail.Id = tran_id;
                    objInvDetail.Invoiceguid = CInvoices.GetTableRowGuid(InvoicesId);
                    objInvDetail.Batchguid = grvTransactionDetails.Rows[grRow].Cells["colBatchGuid"].Value.ToString();
                    objInvDetail.UnitPrice = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colUnitPrice"].Value);
                    objInvDetail.Quantity = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value);

                    if (blnNewInvDetail)
                    {
                        if (objInvDetail.Exists(true) <= 0)
                        {
                            objInvDetail.Insert();
                            grvTransactionDetails.Rows[grRow].Cells["colId"].Value = objInvDetail.Id;
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This Item is Already in the Invoice! ";

                    }
                    else
                    {
                        if (objInvDetail.Exists(false) <= 0)
                        {
                            objInvDetail.Id = Convert.ToInt32(tran_id.ToString());
                            objInvDetail.Update();
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This Item is Already in the Invoice! ";
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
        private bool SaveCashCollections()
        {
            try
            {
                CCashCollections objCashCollections = new CCashCollections();

                objCashCollections.Id = 0;
                objCashCollections.Customerguid = InvoiceCustomerGuid;
                objCashCollections.Requestdate = Convert.ToDateTime(txtInvoiceDate.Text, CSettings.Culture);
                objCashCollections.Referencenumber = Convert.ToString(CCashCollections.GetMaxReferenceNumber() + 1);
                objCashCollections.Settled = (int)CCommon.PaymentSettlement.NotSettled;
                objCashCollections.CheckIsCashed = (int)CCommon.CheckStatus.NotCashed;
                objCashCollections.RequestIsVoid = 0;

                objCashCollections.Insert();
                CashCollectionsGuid = CCashCollections.GetTableRowGuid(objCashCollections.Id);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool SaveCashCollectionInvoices()
        {
            try
            {
                CCashCollectionInvoices objCashCollectionInvoice = new CCashCollectionInvoices();

                objCashCollectionInvoice.Cashcollectionguid = CashCollectionsGuid;
                objCashCollectionInvoice.Invoiceguid = CInvoices.GetTableRowGuid(InvoicesId);

                if (CashCollectionsGuid == string.Empty || InvoicesId <= 0) return false;
                
                objCashCollectionInvoice.Insert();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool DeleteCashCollection()
        {
            try
            {
                CCashCollections objCashCollection = new CCashCollections();

                objCashCollection.Id = CCashCollections.GetTableRowId(CashCollectionsGuid);
                if (!DeleteCashCollectionInvoices()) return false;
                objCashCollection.Delete();
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
            try
            {
                CCashCollectionInvoices objCashCollectionInvoice = new CCashCollectionInvoices();
                ArrayList ar = new ArrayList(objCashCollectionInvoice.GetList(CashCollectionsGuid));
                if (ar.Count < 0) return true;

                foreach (CCashCollectionInvoices Cash in ar)
                {
                    objCashCollectionInvoice.Id = Cash.Id;
                    objCashCollectionInvoice.Delete();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveInvoices();
                if (!bSaved || InvoicesId <= 0) return;
                
                SaveInvoiceDetail();
                if (bNewInvoices && Convert.ToInt32(CCommon.GetItemData(cboInvoiceType)) == (int)CCommon.InvoiceType.CashSales)
                {                    
                    SaveCashCollections();
                    SaveCashCollectionInvoices();
                    DeliverInvoices();
                    IssueInvoice();
                    NewInvoice();
                }

                bNewInvoices = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void lvwTransactions_Click(object sender, EventArgs e)
        {

        }

        private void CalculateTotal()
        {
            try
            {
                decimal subtotal = 0;
                decimal discount = 0;
                decimal discountamount = 0;
                decimal decInvoiceTotal = 0;
                decimal decVATAmount = 0;

                subtotal = GetTotalAmount();
                discount = Convert.ToDecimal("0" + this.txtInvoiceDiscount.Text);
                discountamount = subtotal * discount / 100;                
                decVATAmount = (subtotal - discountamount) * (Convert.ToDecimal(txtVAT.Text) / 100);
                decInvoiceTotal = (subtotal - discountamount)  + decVATAmount;
                txtSubTotal.Text = subtotal.ToString(CSettings.CurrencyFormat);
                txtDiscountAmount.Text = discountamount.ToString(CSettings.CurrencyFormat);
                txtVATAmount.Text = decVATAmount.ToString(CSettings.CurrencyFormat);
                txtInvoiceTotalAmount.Text = decInvoiceTotal.ToString(CSettings.CurrencyFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwTransactions.SelectedItems == null) return;
                if (lvwTransactions.SelectedItems.Count <= 0) return;

                EditInvoices();

                this.NewSuppliesRequisitions();
                this.FindSuppliesRequisitions(txtSuppliesRequisitionReferenceNumber.Tag.ToString());
                this.FillRequisitonDetailList(txtSuppliesRequisitionReferenceNumber.Tag.ToString());

                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchSuppliesRequisition_Click(object sender, EventArgs e)
        {
            try
            {
                NewInvoice();
                frmRequesition frmRE = new frmRequesition();
                frmRE.ShowDialog();
                RequesitionGuid = frmRE.Suppliesrequisitionguid;

                this.txtSuppliesRequisitionReferenceNumber.Tag = frmRE.Suppliesrequisitionguid.ToString();
                this.txtSuppliesRequisitionReferenceNumber.Text = frmRE.SuppliesRequisitionReferenceNumber.ToString();


                if (frmRE.Referencenumber == int.MinValue)
                    this.txtSuppliesRequisitionReferenceNumber.Text = string.Empty;
                else
                    this.txtSuppliesRequisitionReferenceNumber.Text = Convert.ToString(frmRE.Referencenumber);
                
                this.txtInvoiceCustormerName.Text = frmRE.Customersorganizationname;
                this.CustomerGuid = frmRE.Customerguid2;
                
                this.RequesitionGuid = CSuppliesRequisitions.GetTableRowGuid(frmRE.Requisitionid);

                //Filling selected item
                this.NewSuppliesRequisitions();
                this.FindSuppliesRequisitions(txtSuppliesRequisitionReferenceNumber.Tag.ToString());
                this.FillRequisitonDetailList(txtSuppliesRequisitionReferenceNumber.Tag.ToString());

                //FillRequisitonDetailList(this.RequesitionGuid);                    

                //Preparing Invoice
                PrepareInvoice();
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ShowInvoice()
        {
            try
            {
                DataTable dt = new DataTable();
                rptInvoice rpt = new rptInvoice();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   TOP (100) PERCENT tblItems.Measurement, tblItems.BrandName, tblItems.GenericName, tblItems.DosageFormGuid,   ";
                strSQL = strSQL + "                 tblItems.Strength, tblUnitOfMeasurements.Name AS UnitName, tblCustomers.Name AS CustomerName,   ";
                strSQL = strSQL + "                 tblCustomers.MailingAddress, tblCustomers.email, tblCustomers.Tel2, tblCustomers.Tel1, tblCustomers.Fax,   ";
                strSQL = strSQL + "                 'Tel: ' + tblCustomers.Tel1 + ', Fax: ' + tblCustomers.Fax + ', Email: ' + tblCustomers.email AS Address1,   ";
                strSQL = strSQL + "                 tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS UnitOfMeasurement,   ";
                strSQL = strSQL + "                 tblItems.BrandName + ' (' + tblItems.GenericName + ') ' + tblItems.Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.Name AS ItemDescription, tblLicenses.LicenseNumber,   ";
                strSQL = strSQL + "                 tblInvoices.Id, tblInvoices.TableRowGuid, tblInvoices.CustomerGuid, tblInvoices.ReferenceNumber, tblInvoices.InvoiceDate, tblInvoices.InvoiceType,   ";
                strSQL = strSQL + "                 tblInvoices.DueDate, tblInvoices.PreparedBy, tblInvoices.CheckedBy, tblInvoices.ApprovedBy, tblInvoices.DeliveredBy,   ";
                strSQL = strSQL + "                 tblInvoices.PreparedDate, tblInvoices.CheckedDate, tblInvoices.ApprovalDate, tblInvoices.DeliveryDate,   ";
                strSQL = strSQL + "                 tblInvoices.DeliveryStatus, tblInvoices.SuppliesRequisitionGuid, tblInvoices.CashCollectionGuid, tblBatchs.BatchNumber,   ";
                strSQL = strSQL + "                 tblInvoiceDetails.UnitPrice AS PricePerUnit, tblInvoiceDetails.Quantity, tblInvoiceDetails.Id AS DetailId, tblInvoiceDetails.TableRowGuid AS DetailGuid,  ";
                strSQL = strSQL + "                 tblInvoiceDetails.UnitPrice * tblInvoiceDetails.Quantity AS LineTotal, tblInvoices.Discount, ";
                strSQL = strSQL + "                 tblLicenses.FirstName + ' ' + tblLicenses.FatherName + ' ' + tblLicenses.GrandName AS Licensee, ";
                strSQL = strSQL + "                 tblLevels.Name AS Qualification ";
                strSQL = strSQL + " FROM      tblInvoices INNER JOIN tblInvoiceDetails ";
                strSQL = strSQL + "                  ON tblInvoiceDetails.InvoiceGuid = tblInvoices.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblBatchs  ";
                strSQL = strSQL + "                  ON tblInvoiceDetails.BatchGuid = tblBatchs.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblItems  ";
                strSQL = strSQL + "                  ON tblBatchs.ItemGuid = tblItems.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblUnitOfMeasurements  ";
                strSQL = strSQL + "                  ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblDosageForms  ";
                strSQL = strSQL + "                  ON tblItems.DosageFormGuid = tblDosageForms.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblCustomers  ";
                strSQL = strSQL + "                  ON tblInvoices.CustomerGuid = tblCustomers.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblLicenses  ";
                strSQL = strSQL + "                  ON tblLicenses.TableRowGuid = tblInvoices.LicenseGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblLevels  ";
                strSQL = strSQL + "                  ON tblLicenses.LevelGuid = tblLevels.TableRowGuid  ";
                strSQL = strSQL + " Where tblInvoices.TableRowGuid = '" + CInvoices.GetTableRowGuid(InvoicesId) + "' ";
                strSQL = strSQL + " ORDER BY ItemDescription  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Invoice";
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
        private void ShowInvoiceFull()
        {
            DataTable dt = new DataTable();
            rptInvoiceFull rpt = new rptInvoiceFull();
            frmReportViewerInvoice frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   TOP (100) PERCENT Invoices.*, Groupings.* ";
                strSQL = strSQL + " FROM ( "; 
                strSQL = strSQL + " SELECT   TOP (100) PERCENT tblItems.Measurement, tblItems.BrandName, tblItems.GenericName, tblItems.DosageFormGuid,   ";
                strSQL = strSQL + "                 tblItems.Strength, tblUnitOfMeasurements.Name AS UnitName, tblCustomers.Name AS CustomerName, tblCustomers.TIN AS CustomerTin,   ";
                strSQL = strSQL + "                 tblCustomers.MailingAddress, tblCustomers.email, tblCustomers.Tel2, tblCustomers.Tel1, tblCustomers.Fax,   ";
                strSQL = strSQL + "                 'Tel: ' + tblCustomers.Tel1 + ', Fax: ' + tblCustomers.Fax + ', Email: ' + tblCustomers.email AS Address1,   ";
                strSQL = strSQL + "                 tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS UnitOfMeasurement,   ";
                strSQL = strSQL + "                 tblItems.BrandName + ' (' + tblItems.GenericName + ') ' + tblItems.Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.Name AS ItemDescription, tblLicenses.LicenseNumber,   ";
                strSQL = strSQL + "                 tblInvoices.Id, tblInvoices.TableRowGuid, tblInvoices.CustomerGuid, tblInvoices.ReferenceNumber, tblInvoices.InvoiceDate, tblInvoices.InvoiceType,   ";
                strSQL = strSQL + "                 tblInvoices.DueDate, tblInvoices.PreparedBy, tblInvoices.CheckedBy, tblInvoices.ApprovedBy, tblInvoices.DeliveredBy,   ";
                strSQL = strSQL + "                 tblInvoices.PreparedDate, tblInvoices.CheckedDate, tblInvoices.ApprovalDate, tblInvoices.DeliveryDate,   ";
                strSQL = strSQL + "                 tblInvoices.DeliveryStatus, tblInvoices.SuppliesRequisitionGuid, tblInvoices.CashCollectionGuid, tblBatchs.BatchNumber,   ";
                strSQL = strSQL + "                 tblInvoiceDetails.UnitPrice AS PricePerUnit, tblInvoiceDetails.Quantity, tblInvoiceDetails.Id AS DetailId, tblInvoiceDetails.TableRowGuid AS DetailGuid,  ";
                strSQL = strSQL + "                 tblInvoiceDetails.UnitPrice * tblInvoiceDetails.Quantity AS LineTotal, tblInvoices.Discount, ";
                strSQL = strSQL + "                 tblLicenses.FirstName + ' ' + tblLicenses.FatherName + ' ' + tblLicenses.GrandName AS Licensee, ";
                strSQL = strSQL + "                 tblLevels.Name AS Qualification ";
                strSQL = strSQL + " FROM      tblInvoices INNER JOIN tblInvoiceDetails ";
                strSQL = strSQL + "                  ON tblInvoiceDetails.InvoiceGuid = tblInvoices.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblBatchs  ";
                strSQL = strSQL + "                  ON tblInvoiceDetails.BatchGuid = tblBatchs.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblItems  ";
                strSQL = strSQL + "                  ON tblBatchs.ItemGuid = tblItems.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblUnitOfMeasurements  ";
                strSQL = strSQL + "                  ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblDosageForms  ";
                strSQL = strSQL + "                  ON tblItems.DosageFormGuid = tblDosageForms.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblCustomers  ";
                strSQL = strSQL + "                  ON tblInvoices.CustomerGuid = tblCustomers.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblLicenses  ";
                strSQL = strSQL + "                  ON tblLicenses.TableRowGuid = tblInvoices.LicenseGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblLevels  ";
                strSQL = strSQL + "                  ON tblLicenses.LevelGuid = tblLevels.TableRowGuid  ";
                strSQL = strSQL + " Where tblInvoices.TableRowGuid = '" + CInvoices.GetTableRowGuid(InvoicesId) + "' ";
                strSQL = strSQL + " ) Invoices CROSS JOIN ";
                strSQL = strSQL + " (Select Grouping = '0' UNION Select Grouping = '1' UNION Select Grouping = '2') AS Groupings ";
                strSQL = strSQL + " ORDER BY Groupings.Grouping, Invoices.ItemDescription  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    if (CInvoices.GetDeliveryStatus(CInvoices.GetTableRowGuid(this.InvoicesId)) == 2)
                        rpt.InvoiceIsVoid();
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewerInvoice(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Invoice";
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

        private bool SaveTransaction()
        {
            try
            {
                if (!IsValidTransaction()) return false;

                CStoreTransactions objTransactions = new CStoreTransactions();

                objTransactions.Id = intTransactionId;

                if (CSettings.GoodsIssuanceStore == string.Empty)
                    objTransactions.Storeguid = string.Empty;
                else
                    objTransactions.Storeguid = CSettings.GoodsIssuanceStore;
                objTransactions.Invoiceguid = CInvoices.GetTableRowGuid(InvoicesId);
                int maxReferenceNumber = CStoreTransactions.GetMaxReferenceNumber((int)CCommon.StoreTransactionType.Issuance);
                objTransactions.ReferenceNumber = "0" + (maxReferenceNumber + 1).ToString();
                objTransactions.TransactionBy = CSettings.GoodsIssuanceIssuedBy;
                objTransactions.TransactionDate = DateTime.Today.Date;
                objTransactions.TransactionType = Convert.ToInt32(CCommon.StoreTransactionType.Issuance);
                objTransactions.CheckedBy = CSettings.GoodsIssuanceIssuedBy;
                objTransactions.CheckedDate = DateTime.Today.Date; 
                objTransactions.DeliveredBy = CSettings.GoodsIssuanceIssuedBy;
                objTransactions.DeliveryDate = DateTime.Today.Date;
                objTransactions.IssuedToDeliveryPersonGuid = string.Empty;
                
                if (objTransactions.Exists(true) > 0)
                {
                    MessageBox.Show("There exists an issuance record with the given details.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (objTransactions.InvoiceExists(true) > 0)
                {
                    MessageBox.Show("This invoice has been issued. Please check the data and try again.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
              
                 objTransactions.Insert();

                intTransactionId = objTransactions.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool IsValidTransaction()
        {
            try
            {
                DateTime dteValidate;

                if (!CCommon.SetRequiredMessage(txtInvoiceNo, "Invoice number can not be empty. Please enter a valid invoice number.", mValidator, lblMsg))
                    return false;
                //if (!CCommon.SetRequiredMessage(txtReferenceNo, "Reference number can not be empty. Please enter a valid reference number.", mValidator, lblMsg))
                //    return false;
                //if (!CCommon.SetRequiredMessage(cboStoreLocation, "Please select store location", mValidator, lblMsg))
                //    return false;
                //if (!CCommon.SetRequiredMessage(cboStoreName, "Please select store name", mValidator, lblMsg))
                //    return false;
                //if (!CCommon.SetRequiredMessage(txtTransactionBy, "Issuaed by can not be empty.", mValidator, lblMsg))
                //    return false;
                //if (!CCommon.SetRequiredMessage(txtTransactionDate, "Issuance date can not be empty.", mValidator, lblMsg))
                //    return false;
                //if (!DateTime.TryParseExact(txtTransactionDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                //{
                //    CCommon.SetMessage(txtTransactionDate, "Please enter issuance date in a correct format", mValidator, lblMsg);
                //    return false;
                //}
                //if (!CCommon.SetRequiredMessage(txtIssuedTo, "Issued To can not be empty.", mValidator, lblMsg))
                //    return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void SaveTransactionDetail()
        {
            try
            {
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount - 1; grRow++)
                {
                    int tran_id = 0;                    
                    if (!ValidateRowIssuance(grRow)) break;
                    CStoreTransactionDetails objTranDetail = new CStoreTransactionDetails();   
                    objTranDetail.Id = tran_id;
                    objTranDetail.Transactionguid = CStoreTransactions.GetTableRowGuid(intTransactionId);
                    objTranDetail.Transactiontype = Convert.ToInt32(CCommon.StoreTransactionType.Issuance);
                    objTranDetail.Batchguid = grvTransactionDetails.Rows[grRow].Cells["colBatchGuid"].Value.ToString();
                    objTranDetail.Quantity = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value);
                    if (objTranDetail.Exists(true) <= 0)                       
                        objTranDetail.Insert();                            
                    else
                        grvTransactionDetails.Rows[grRow].ErrorText = "This Item is Already Issued! ";
                                      
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateRowIssuance(int grRow)
        {
            try
            {
                decimal dcmValue;

                if (grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value == null)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The Quantity Can Not Be Empty";
                    return false;
                }
                if (!decimal.TryParse(grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value.ToString(), out dcmValue))
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The Quantity must be numeric";
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
        private void IssueInvoice()
        {
            try
            {
                if (SaveTransaction())
                {
                    SaveTransactionDetail();
                    MessageBox.Show("Data saved successfully", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                ShowInvoiceFull();
                //ShowInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string IsInvoiceIssued(string Invoiceguid)
        {
            try
            {
                DataTable dt = new DataTable();
                CStoreTransactions issuance = new CStoreTransactions();

                dt = issuance.GetRecordbyInvoice(Invoiceguid);

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
        private void btnDeliver_Click(object sender, EventArgs e)
        {
            try
            {
                string issuanceNumber = IsInvoiceIssued(CInvoices.GetTableRowGuid(InvoicesId));
                if (issuanceNumber != string.Empty)
                {
                    bool bDelivered = false;
                    bDelivered = DeliverInvoices();
                    if (bDelivered)
                    {
                        this.lblDelivered.Visible = true;
                        this.lblVoid.Visible = false;
                        MessageBox.Show("The invoice is delivered successfully.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("The invoice is not delivered.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("The items in this invoice have to be issued from the store before it can be delivered.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                //string issuanceNumber = IsInvoiceIssued(InvoicesId);
                //if (issuanceNumber != string.Empty)
                //{
                bool bReturned = false;
                bReturned = ReturnInvoices();
                if (bReturned)
                    MessageBox.Show("The invoice is voided successfully.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("The invoice is not voided.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //}
                //else
                //{
                //    MessageBox.Show("The items in this invoice have to be issued from the store before it can be returned.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
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
                NewInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSuppliesRequisitionReferenceNumber_TextChanged(object sender, EventArgs e)
        {

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
                this.panelToolBar.Width = this.lblTitle.Width - this.panelToolBar.Left;
                //this.grpRequisition.Width = this.lblTitle.Width - this.grpRequisition.Left - 24;
                //this.grpInvoice.Width = this.lblTitle.Width - this.grpInvoice.Left - 24;
                this.grbDelivery.Width = this.lblTitle.Width - this.grbDelivery.Left - 24;
                this.grbReturning.Width = this.lblTitle.Width - this.grbReturning.Left - 24;

                // Transactions listview
                this.lvwTransactions.Height = this.Height - this.lvwTransactions.Top - 65;

                // Detail Groupbox and Gridview
                this.tabControlInvoice.Height = this.Height - this.tabControlInvoice.Top - 65;
                this.tabControlInvoice.Width = this.lblTitle.Width - this.tabControlInvoice.Left - 24;

                this.panelTotal.Top = this.tabControlInvoice.Height - this.panelTotal.Height - 24;
                this.grvTransactionDetails.Width = this.tabControlInvoice.Width - 12;
                this.grvTransactionDetails.Height = this.panelTotal.Top - 2;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmInvoice_Resize(object sender, EventArgs e)
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

        private void txtInvoiceDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SetDueDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDueDate()
        {
            try
            {
                DateTime dateValue;
                double dueDateLength = CSettings.InvoiceDueDateLength;
                bool result;

                result = DateTime.TryParseExact(txtInvoiceDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dateValue);

                if (bNewInvoices)
                    if (!result)
                        txtDueDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                    else
                        txtDueDate.Text = dateValue.AddDays(dueDateLength).ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtInvoiceDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CDigits.AllowDoubleOnly(txtInvoiceDiscount);
                CalculateTotal();
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

        private void ShowInvoiceAttachment()
        {
            DataTable dt = new DataTable();
            rptInvoiceAttachment rpt = new rptInvoiceAttachment();
            frmReportViewerInvoice frm = null;

            try
            {
                string guid = CInvoices.GetTableRowGuid(InvoicesId);

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   TOP (100) PERCENT Invoices.*, Groupings.* ";
                strSQL = strSQL + " FROM ( ";
                strSQL = strSQL + " SELECT   TOP (100) PERCENT tblItems.Measurement, tblItems.GenericName,   ";
                strSQL = strSQL + "                 tblItems.Strength, tblUnitOfMeasurements.Name AS UnitName, tblCustomers.Name AS CustomerName, tblCustomers.TIN AS CustomerTin, tblCustomers.VAT AS CustomerVat, ";
                strSQL = strSQL + "                 tblCustomers.MailingAddress, tblCustomers.email, tblCustomers.Tel2, tblCustomers.Tel1, tblCustomers.Fax,   ";
                strSQL = strSQL + "                 'Tel: ' + tblCustomers.Tel1 + ', Fax: ' + tblCustomers.Fax + ', Email: ' + tblCustomers.email AS Address1,   ";
                strSQL = strSQL + "                 tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS UnitOfMeasurement,   ";              
                strSQL = strSQL + "                 tblInvoices.Id, tblInvoices.TableRowGuid, tblInvoices.CustomerGuid, tblInvoices.ReferenceNumber, tblInvoices.AttachmentReferenceNumber, tblInvoices.InvoiceDate, tblInvoices.InvoiceType,   ";
                strSQL = strSQL + "                 tblInvoices.DueDate, tblInvoices.PreparedBy, tblInvoices.CheckedBy, tblInvoices.ApprovedBy, tblInvoices.DeliveredBy,   ";
                strSQL = strSQL + "                 tblInvoices.PreparedDate, tblInvoices.CheckedDate, tblInvoices.ApprovalDate, tblInvoices.DeliveryDate,   ";
                strSQL = strSQL + "                 tblInvoices.DeliveryStatus, tblInvoices.SuppliesRequisitionGuid, tblInvoices.CashCollectionGuid, tblBatchs.BatchNumber,   ";
                strSQL = strSQL + "                 tblInvoiceDetails.UnitPrice AS PricePerUnit, tblInvoiceDetails.Quantity, tblInvoiceDetails.Id AS DetailId, tblInvoiceDetails.TableRowGuid AS DetailGuid,  ";
                strSQL = strSQL + "                 tblInvoiceDetails.UnitPrice * tblInvoiceDetails.Quantity AS LineTotal, tblInvoices.Discount, tblInvoices.VAT ,";

                strSQL = strSQL + " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)As ItemDescription  from tblitems ";
                strSQL = strSQL + " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid ";
                strSQL = strSQL + " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
                strSQL = strSQL + " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
                strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
                strSQL = strSQL + " inner join tblBatchs on tblBatchs.ItemGuid =tblItems.TableRowGuid  ";
                strSQL = strSQL + " inner join tblInvoiceDetails on tblBatchs.TableRowGuid =tblInvoiceDetails.BatchGuid";
                strSQL = strSQL + " inner join tblInvoices on tblInvoices.TableRowGuid = tblInvoiceDetails.InvoiceGuid  ";
                strSQL = strSQL + " Left Outer join tblUnitOfMeasurements on (tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid) ";  

                strSQL = strSQL + " inner join tblCustomers  ";
                strSQL = strSQL + "                  ON tblInvoices.CustomerGuid = tblCustomers.TableRowGuid  ";                
                strSQL = strSQL + " Where tblInvoices.TableRowGuid = '" + CInvoices.GetTableRowGuid(InvoicesId) + "' ";
                strSQL = strSQL + " ) Invoices CROSS JOIN ";
                strSQL = strSQL + " (Select Grouping = '0' UNION Select Grouping = '1' UNION Select Grouping = '2') AS Groupings ";
                strSQL = strSQL + " ORDER BY Groupings.Grouping, Invoices.ItemDescription  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    if (CInvoices.GetDeliveryStatus(CInvoices.GetTableRowGuid(this.InvoicesId)) == 2)
                        rpt.InvoiceIsVoid();
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewerInvoice(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Invoice Attachment";
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
        private void btnPrintPreviewAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                ShowInvoiceAttachment();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateAttachmentNumber_Click(object sender, EventArgs e)
        {
            GetMaxReferenceNumber();
        }

        private void btnSearchRequisition_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectSuppliesRequisition frmSR = new frmSelectSuppliesRequisition();
                frmSR.ShowDialog();
                if (frmSR.bCancel == true) return;

                RequesitionGuid = frmSR.Suppliesrequisitionguid;
                this.txtSuppliesRequisitionReferenceNumber.Tag = frmSR.Suppliesrequisitionguid.ToString();
                this.txtSuppliesRequisitionReferenceNumber.Text = frmSR.SuppliesRequisitionReferenceNumber.ToString();

                this.NewSuppliesRequisitions();
                this.FindSuppliesRequisitions(txtSuppliesRequisitionReferenceNumber.Tag.ToString());
                this.FillRequisitonDetailList(txtSuppliesRequisitionReferenceNumber.Tag.ToString());

                PrepareInvoice();
                this.FillInvoiceDetailGrid(txtSuppliesRequisitionReferenceNumber.Tag.ToString());
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lvwRequisitionItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

      

    }
}
