

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
    public partial class frmLocalCalculatePrice : Form
    {
        private const string DialogCaption = "Calculate Product Price";

        #region Purchase Order Form Code

        private bool already_in = false;

        public frmLocalCalculatePrice()
        {
            InitializeComponent();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Purchase Order Code

        private string PurchaseOrderGuid = string.Empty;

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
                PurchaseOrderGuid = string.Empty;
                txtOrderNumber.Text = String.Empty;
                txtOrderDate.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool FindPurchaseOrders(string Purchaseorderguid)
        {
            try
            {
                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();
                DataTable dt = new DataTable();

                objPurchaseOrders.Id = CLocalPurchaseOrders.GetTableRowId(Purchaseorderguid);
                dt = objPurchaseOrders.GetRecord();
                if (dt.Rows.Count > 0)
                {
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
                    txtOrderNumber.Text = string.Empty;
                    MessageBox.Show("Record not found! ", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception ex)
            {
                txtOrderNumber.Text = string.Empty;
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void FillPurchaseOrderAllPaymentsList()
        {
            try
            {
              
                FillPurchaseOrderPaymentsListByParent(PurchaseOrderGuid);
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
       
        private void btnSearchPurchaseOrder_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectPurchaseOrder frmPO = new frmSelectPurchaseOrder();
                frmPO.chkLocalPurchase.Checked = true;
                frmPO.chkLocalPurchase.Visible = false;
                frmPO.ShowDialog();
                if (frmPO.bCancel == true) return;
                PurchaseOrderGuid = frmPO.Purchaseorderguid;
                this.txtOrderNumber.Tag = frmPO.Purchaseorderguid.ToString();
                this.txtOrderNumber.Text = frmPO.PurchaseOrderNumber.ToString();

                FillBatchsListByParent(PurchaseOrderGuid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtOrderNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bool bAlreadyIn = false;
                if (!bAlreadyIn)
                {
                    bAlreadyIn = true;

                    FindPurchaseOrders(PurchaseOrderGuid.ToString());
                    FillPurchaseOrderDetailsListByParent(PurchaseOrderGuid.ToString());
                    FillPurchaseOrderAllPaymentsList();
                    FillBatchsListByParent(PurchaseOrderGuid.ToString());
                    CalculateTotal();
                }
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
                                                                                      PurchaseOrderDetails.Quantity.ToString(CSettings.CurrencyFormat), 
                                                                                      PurchaseOrderDetails.Priceperunit.ToString(CSettings.CurrencyFormat),
                                                                                      (PurchaseOrderDetails.Quantity * PurchaseOrderDetails.Priceperunit).ToString(CSettings.CurrencyFormat)});
                    this.lvwPurchaseOrderDetails.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateTotal()
        {
            decimal decTotalFOB = 0;
            //decimal decFreightCharge = 0;
            //decimal decTotalCandF = 0;

           
            decimal decTotalOther = 0;

            decTotalFOB = CCommonListView.GetListTotalPrice(lvwPurchaseOrderDetails, colPurchaseOrderDetailsQuantity, colPurchaseOrderDetailsPriceperunit);

         
            this.txtTotalFOB.Text = decTotalFOB.ToString(CSettings.CurrencyFormat);           
          
            decTotalOther = CCommonListView.GetListTotal(lvwOtherPayments, colOtherPaymentAmount);
          
            this.txtTotalOther.Text = decTotalOther.ToString(CSettings.CurrencyFormat);

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
      
        private void FillBatchsListByParent(string Purchaseorderguid)
        {
            try
            {

                CBatchs objBatchs = new CBatchs();

                ArrayList ar = new ArrayList(objBatchs.GetList(Purchaseorderguid,(int)CCommon.SupplierType.Local));
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
                                                                                      Batchs.Saleprice.ToString()}); 
                                                                                      
                    this.lvwBatchs.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Price Analysis Code

        //private decimal GetTotalFOB()
        //{
        //    decimal decTotalFOB = 0;
        //}
        private void GetTotal()
        {
            try
            {
                decimal decTotalFOB = 0;
                decimal decFreightCharge = 0;

                decimal decTotalFOBInBirr = 0;
                decimal decFreightChargeInBirr = 0;

              
                decimal decTotalOther = 0;

                decimal decExchangeRate = 1;

                decTotalFOB = CCommonListView.GetListTotalPrice(lvwPurchaseOrderDetails, colPurchaseOrderDetailsQuantity, colPurchaseOrderDetailsPriceperunit);

                decTotalOther = CCommonListView.GetListTotal(lvwOtherPayments, colOtherPaymentAmount);

                //this.txtBatchNumber.Text = decTotalFOB.ToString(CSettings.CurrencyFormat);
                //this.txtItem.Text = decFreightCharge.ToString(CSettings.CurrencyFormat);

                decTotalFOBInBirr = decTotalFOB * decExchangeRate;
                decFreightChargeInBirr = decFreightCharge * decExchangeRate;

                this.txtPriceAnalysisTotalPriceInBirr.Text = decTotalFOBInBirr.ToString(CSettings.CurrencyFormat);
                this.txtPriceAnalysisTotalOtherInBirr.Text = decTotalOther.ToString(CSettings.CurrencyFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPriceAnalysisExchangeRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GetTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            try
            {
                CPriceAnalysis.CalculateLocalPrice(PurchaseOrderGuid);
                FillBatchsListByParent(PurchaseOrderGuid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveActualPriceForBatch(int BatchsId)
        {
            try
            {
                CBatchs objBatchs = new CBatchs();
                DataTable dt = new DataTable();

                objBatchs.Id = BatchsId;
                dt = objBatchs.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    objBatchs.Saleprice = Convert.ToDecimal(this.txtActualSellingPrice.Text);

                    return objBatchs.Update();
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
        private bool FindBatchs(int BatchsId)
        {
            try
            {
                CBatchs objBatchs = new CBatchs();
                DataTable dt = new DataTable();

                objBatchs.Id = BatchsId;
                dt = objBatchs.GetRecord();
                if (dt.Rows.Count > 0)
                {                   
                    //txtBatchsBatchnumber.Text = Convert.ToString(objBatchs.Batchnumber);
                    //cboBatchsItemid.SelectedIndex = CCommon.GetIndexByItemData(cboBatchsItemid, objBatchs.Itemid.ToString());
                    //txtBatchsQuantity.Text = Convert.ToString(objBatchs.Quantity);

                    if (objBatchs.ExchangeRate == 0) objBatchs.ExchangeRate = 1;

                    txtPriceAnalysisBatchTotalPrice.Text = (objBatchs.Priceperunit * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);

                    txtPriceAnalysisTotalPriceInBirr.Text = (objBatchs.Priceperunit * objBatchs.ExchangeRate * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisTotalOtherInBirr.Text = (objBatchs.Otherpayments * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);

                    txtPriceAnalysisTotalCostInBirrTotal.Text = ((objBatchs.Priceperunit * objBatchs.ExchangeRate +
                                                                    objBatchs.Freightpayments +                                                                   
                                                                    objBatchs.Otherpayments) * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);

                    txtPriceAnalysisUnitPriceInBirr.Text = (objBatchs.Priceperunit * objBatchs.ExchangeRate).ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisUnitOtherInBirr.Text = objBatchs.Otherpayments.ToString(CSettings.CurrencyFormat);

                    txtPriceAnalysisUnitCostInBirrTotal.Text = (objBatchs.Priceperunit * objBatchs.ExchangeRate +
                                                                    objBatchs.Freightpayments + 
                                                                    objBatchs.Otherpayments).ToString(CSettings.CurrencyFormat);

                    txtProfitMargin.Text = objBatchs.ProfitMargin.ToString(CSettings.CurrencyFormat);
                    txtSuggestedSellingPrice.Text = objBatchs.Suggestedsaleprice.ToString(CSettings.CurrencyFormat);
                    txtActualSellingPrice.Text = objBatchs.Saleprice.ToString(CSettings.CurrencyFormat);
                    

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
        private void lvwBatchs_DoubleClick(object sender, EventArgs e)
        {
            //
        }

        #endregion

        private void btnSaveActualPriceForBatch_Click(object sender, EventArgs e)
        {
            try
            {
                decimal decValue;
                ListViewItem itmX = new ListViewItem();
                itmX = lvwBatchs.SelectedItems[0];

                if (itmX == null) return;

                if (!CCommon.SetRequiredMessage(txtActualSellingPrice, "Actual selling price can not be empty", mValidator, lblMsg))
                    return;

                if (!decimal.TryParse(txtActualSellingPrice.Text, out decValue))
                {
                    CCommon.SetMessage(txtActualSellingPrice, "Actual selling price must be a numeric value", mValidator, lblMsg);
                    return;
                }

                SaveActualPriceForBatch(Convert.ToInt32(itmX.SubItems[colBatchsId.Index].Text));
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
                //this.PaymentTabs.Width = this.lblTitle.Width - this.PaymentTabs.Left - 24;
                this.tabControlPriceAnalysis.Width = this.lblTitle.Width - this.tabControlPriceAnalysis.Left - 24;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCalculatePrice_Resize(object sender, EventArgs e)
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

        private void lvwBatchs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwBatchs.SelectedItems == null) return;
                if (lvwBatchs.SelectedItems.Count <= 0) return;

                ListViewItem itmX = new ListViewItem();
                itmX = lvwBatchs.SelectedItems[0];

                txtBatchNumber.Text = Convert.ToString(itmX.SubItems[colBatchsBatchnumber.Index].Text);
                txtItem.Text = Convert.ToString(itmX.SubItems[colBatchsItemname.Index].Text);
                FindBatchs(Convert.ToInt32(itmX.SubItems[colBatchsId.Index].Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvwPurchaseOrderDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void proformaToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
