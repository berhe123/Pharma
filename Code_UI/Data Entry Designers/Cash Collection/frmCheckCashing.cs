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
    public partial class frmCheckCashing : Form
    {
        private const string DialogCaption = "Check Cashing";
        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector childSelector = null;

        string CustomerGuidSearch = string.Empty;       
        //private bool bNewCashCollections = true;
        private int CashCollectionsId = 0;

        public frmCheckCashing()
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
                CCommon.FillComboBox(cboBank, "Select id, [name] from tblBanks", "id", "name");
                txtMaturityDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtMaturityDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
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
                strCriteria = strCriteria + " And Settled = " + (int)CCommon.PaymentSettlement.Settled;
                strCriteria = strCriteria + " And ModeOfPayment = " + (int)CCommon.PaymentType.Check;
                strCriteria = strCriteria + " And CheckIsCashed = " + (int)CCommon.CheckStatus.NotCashed;

                if (CustomerGuidSearch != string.Empty & txtCustomerName.Text != "")
                    strCriteria = strCriteria + " And tblCashCollections.CustomerGuid = '" + CustomerGuidSearch + "' ";
                if (txtMaturityDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtMaturityDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And CheckMaturityDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtMaturityDateTo.Text != "")
                    if (DateTime.TryParseExact(txtMaturityDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And CheckMaturityDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
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
           
        }
        private bool IsValidCashCollections()
        {
            try
            {
                DateTime dteValidate;
                if (!CCommon.SetRequiredMessage(txtCheckCashedDate, "Request date can not be empty", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtCheckCashedDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtCheckCashedDate, "Request Date must be in Date Format", mValidator, lblMsg);
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
               
                txtCheckCashedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);            
              
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
       
                CCashCollections objCashCollections = new CCashCollections();

                objCashCollections.Id = CashCollectionsId;
                objCashCollections.CheckIsCashed = (int)CCommon.CheckStatus.Cashed;
                objCashCollections.CheckCashedDate = Convert.ToDateTime(txtCheckCashedDate.Text, CSettings.Culture);             
                objCashCollections.UpdateCheckCashed();
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
                cboPaymentType.SelectedIndex = CCommon.GetIndexByItemData(cboPaymentType, Convert.ToString(itmX.SubItems[colModeOfPayment.Index].Text), true);
                cboBank.SelectedIndex = CCommon.GetIndexByItemData(cboBank, Convert.ToString(itmX.SubItems[colBankGuid.Index].Text), true);
                txtBranchName.Text = Convert.ToString(itmX.SubItems[colBankBranchName.Index].Text);
                txtCheckCPONo.Text = Convert.ToString(itmX.SubItems[colCheckOrCPONumber.Index].Text);
                txtCheckCPODate.Text = Convert.ToString(itmX.SubItems[colCheckOrCPODate.Index].Text);
                txtMaturityDate.Text = Convert.ToString(itmX.SubItems[colCheckMaturityDate.Index].Text);
                txtTotalReqAmount.Text = GetTotalAmount().ToString(CSettings.CurrencyFormat);
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
                decimal decTotal = decimal.Zero;
                CCashCollections objCash = new CCashCollections();
                decTotal = objCash.GetRequestTotalAmount(CCashCollections.GetTableRowGuid(CashCollectionsId));
                return decTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return decimal.Zero;
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
        private void lvwPaymentRequests_Click(object sender, EventArgs e)
        {
            //
        }  

        private void btnCashThisCheck_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveCashCollections();

                if (bSaved)
                    MessageBox.Show("The current Check has been cashed successfully.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                this.grpCheck.Width = this.lblTitle.Width - this.grpCheck.Left - 24;

                // Transactions listview
                this.lvwPaymentRequests.Height = this.Height - this.lvwPaymentRequests.Top - 65;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmCheckCashing_Resize(object sender, EventArgs e)
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
          
    }
}
