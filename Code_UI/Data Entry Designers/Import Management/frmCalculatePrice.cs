

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
    public partial class frmCalculatePrice : Form
    {
        private const string DialogCaption = "Calculate Product Price";

        #region Purchase Order Form Code

        private bool already_in = false;

        public frmCalculatePrice()
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
                CCommon.FillCurrencyTypeCombo(this.cboCurrencyType, true);
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
                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();
                DataTable dt = new DataTable();

                objPurchaseOrders.Id = CPurchaseOrders.GetTableRowId(Purchaseorderguid);
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
                    cboCurrencyType.SelectedIndex = CCommon.GetIndexByItemData(cboCurrencyType, objPurchaseOrders.Currencytype.ToString(), true);
                    txtFreightCharge.Text = Convert.ToString(objPurchaseOrders.Freightcharge);
                    txtPurchaseOrderExhangeRate.Text = Convert.ToString(objPurchaseOrders.ExchangeRate);
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
                FillPurchaseOrderInsurancesListByParent(PurchaseOrderGuid);
                FillPurchaseOrderBanksListByParent(PurchaseOrderGuid);
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
        
        private void cboCurrencyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CCommon.GetItemData(cboCurrencyType) != "-1")
                {
                    lblTotalFOB.Text = " (" + cboCurrencyType.Text.ToString() + ")";
                    lblFreightCharge.Text = " (" + cboCurrencyType.Text.ToString() + ")";
                    lblTotalCandF.Text = " (" + cboCurrencyType.Text.ToString() + ")";
                    lblTotalAmountIn.Text = " Total Amount in " + cboCurrencyType.Text.ToString() + "";
                    lblExchangeRate.Text = " 1 " + cboCurrencyType.Text.ToString() + " =";
                }
                else
                {
                    lblTotalFOB.Text = " (Currency)";
                    lblFreightCharge.Text = " (Currency)";
                    lblTotalCandF.Text = " (Currency)";
                    lblTotalAmountIn.Text = " Total Amount in () ";
                    lblExchangeRate.Text = " 1 (Currency)";
                }
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
                frmPO.chkLocalPurchase.Checked = false ;
                frmPO.chkLocalPurchase.Visible = false;
                frmPO.ShowDialog();
                if (frmPO.bCancel == true) return;
                PurchaseOrderGuid = frmPO.Purchaseorderguid;
                this.txtOrderNumber.Tag = frmPO.Purchaseorderguid.ToString();
                this.txtOrderNumber.Text = frmPO.PurchaseOrderNumber.ToString();
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

                    FindPurchaseOrders(PurchaseOrderGuid);
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
        private bool SaveExchangeRateForPurchaseOrder(string Purchaseorderguid)
        {
            try
            {
                CPurchaseOrders objPurchaseOrder = new CPurchaseOrders();
                DataTable dt = new DataTable();

                objPurchaseOrder.Id = CPurchaseOrders.GetTableRowId(Purchaseorderguid);
                dt = objPurchaseOrder.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    objPurchaseOrder.ExchangeRate = Convert.ToDecimal(this.txtPurchaseOrderExhangeRate.Text);

                    return objPurchaseOrder.Update();
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
        private void btnSaveExchangeRate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal decValue;

                if (txtOrderNumber.Tag == null) return;

                if (!CCommon.SetRequiredMessage(txtPurchaseOrderExhangeRate, "Exchange rate can not be empty", mValidator, lblMsg))
                    return;

                if (!decimal.TryParse(txtPurchaseOrderExhangeRate.Text, out decValue))
                {
                    CCommon.SetMessage(txtPurchaseOrderExhangeRate, "Exchange rate must be a numeric value", mValidator, lblMsg);
                    return;
                }

                SaveExchangeRateForPurchaseOrder(txtOrderNumber.Tag.ToString());
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

                CPurchaseOrderDetails objPurchaseOrderDetails = new CPurchaseOrderDetails();

                ArrayList ar = new ArrayList(objPurchaseOrderDetails.GetList(Purchaseorderguid));
                this.lvwPurchaseOrderDetails.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrderDetails PurchaseOrderDetails in ar)
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
            decimal decFreightCharge = 0;
            decimal decTotalCandF = 0;

            decimal decTotalInsurance = 0;
            decimal decTotalBank = 0;
            decimal decTotalOther = 0;

            decTotalFOB = CCommonListView.GetListTotalPrice(lvwPurchaseOrderDetails, colPurchaseOrderDetailsQuantity, colPurchaseOrderDetailsPriceperunit);
            if (this.txtFreightCharge.Text != string.Empty) decFreightCharge = Convert.ToDecimal(this.txtFreightCharge.Text);
            decTotalCandF = decTotalFOB + decFreightCharge;

            this.txtFreightCharge.Text = decFreightCharge.ToString(CSettings.CurrencyFormat);
            this.txtTotalFOB.Text = decTotalFOB.ToString(CSettings.CurrencyFormat);
            this.txtTotalCandF.Text = decTotalCandF.ToString(CSettings.CurrencyFormat);

            decTotalInsurance = CCommonListView.GetListTotal(lvwInsurancePayments, colInsurancePaymentAmount);
            decTotalBank = CCommonListView.GetListTotal(lvwBankPayments, colBankPaymentServiceCharge);
            decTotalOther = CCommonListView.GetListTotal(lvwOtherPayments, colOtherPaymentAmount);

            this.txtTotalInsurance.Text = decTotalInsurance.ToString(CSettings.CurrencyFormat);
            this.txtTotalBank.Text = decTotalBank.ToString(CSettings.CurrencyFormat);
            this.txtTotalOther.Text = decTotalOther.ToString(CSettings.CurrencyFormat);

        }


        #endregion               

        #region Insurance Payment Functions

        private void FillPurchaseOrderInsurancesList()
        {
            try
            {

                CPurchaseOrderInsurances objPurchaseOrderInsurances = new CPurchaseOrderInsurances();

                ArrayList ar = new ArrayList(objPurchaseOrderInsurances.GetList());
                this.lvwInsurancePayments.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrderInsurances PurchaseOrderInsurances in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] { PurchaseOrderInsurances.Id.ToString(), 
                                                                                      PurchaseOrderInsurances.Purchaseorderguid.ToString(), 
                                                                                      PurchaseOrderInsurances.Insurername.ToString(), 
                                                                                      PurchaseOrderInsurances.Insureddate.ToString(), 
                                                                                      PurchaseOrderInsurances.Referencenumber.ToString(), 
                                                                                      PurchaseOrderInsurances.Amount.ToString()});
                    this.lvwInsurancePayments.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrderInsurancesListByParent(string Purchaseorderguid)
        {
            try
            {

                CPurchaseOrderInsurances objPurchaseOrderInsurances = new CPurchaseOrderInsurances();

                ArrayList ar = new ArrayList(objPurchaseOrderInsurances.GetList(Purchaseorderguid));
                this.lvwInsurancePayments.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrderInsurances PurchaseOrderInsurances in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] { PurchaseOrderInsurances.Id.ToString(), 
                                                                                      PurchaseOrderInsurances.Purchaseorderguid.ToString(), 
                                                                                      PurchaseOrderInsurances.Insurername.ToString(), 
                                                                                      PurchaseOrderInsurances.Insureddate.ToString(), 
                                                                                      PurchaseOrderInsurances.Referencenumber.ToString(), 
                                                                                      PurchaseOrderInsurances.Amount.ToString()});
                    this.lvwInsurancePayments.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Bank Payment Functions

        private void FillPurchaseOrderBanksList()
        {
            try
            {

                CPurchaseOrderBanks objPurchaseOrderBanks = new CPurchaseOrderBanks();

                ArrayList ar = new ArrayList(objPurchaseOrderBanks.GetList());
                this.lvwBankPayments.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrderBanks PurchaseOrderBanks in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrderBanks.Id.ToString(), 
                                                                                      PurchaseOrderBanks.Purchaseorderguid.ToString(), 
                                                                                      PurchaseOrderBanks.Bankname.ToString(), 
                                                                                      PurchaseOrderBanks.Submissiondate.ToString(), 
                                                                                      PurchaseOrderBanks.Referencenumber.ToString(), 
                                                                                      PurchaseOrderBanks.Servicecharge.ToString()});
                    this.lvwBankPayments.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrderBanksListByParent(string Purchaseorderguid)
        {
            try
            {

                CPurchaseOrderBanks objPurchaseOrderBanks = new CPurchaseOrderBanks();

                ArrayList ar = new ArrayList(objPurchaseOrderBanks.GetList(Purchaseorderguid));
                this.lvwBankPayments.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrderBanks PurchaseOrderBanks in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] { PurchaseOrderBanks.Id.ToString(), 
                                                                                      PurchaseOrderBanks.Purchaseorderguid.ToString(), 
                                                                                      PurchaseOrderBanks.Bankname.ToString(), 
                                                                                      PurchaseOrderBanks.Submissiondate.ToString(), 
                                                                                      PurchaseOrderBanks.Referencenumber.ToString(), 
                                                                                      PurchaseOrderBanks.Servicecharge.ToString()});
                    this.lvwBankPayments.Items.Add(itmX);
                }
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

                CPurchaseOrderPayments objPurchaseOrderPayments = new CPurchaseOrderPayments();

                ArrayList ar = new ArrayList(objPurchaseOrderPayments.GetList(Purchaseorderguid));
                this.lvwOtherPayments.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrderPayments PurchaseOrderPayments in ar)
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
                                                                                      Batchs.Saleprice.ToString()}); 
                                                                                      
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

                ArrayList ar = new ArrayList(objBatchs.GetList(Purchaseorderguid, (int)CCommon.SupplierType.Exporter));
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

                decimal decTotalInsurance = 0;
                decimal decTotalBank = 0;
                decimal decTotalOther = 0;

                decimal decExchangeRate = 0;

                decTotalFOB = CCommonListView.GetListTotalPrice(lvwPurchaseOrderDetails, colPurchaseOrderDetailsQuantity, colPurchaseOrderDetailsPriceperunit);
                if (this.txtFreightCharge.Text != string.Empty) decFreightCharge = Convert.ToDecimal(this.txtFreightCharge.Text);
                if (this.txtPriceAnalysisExchangeRate.Text != string.Empty) decExchangeRate = Convert.ToDecimal(this.txtPriceAnalysisExchangeRate.Text);

                decTotalInsurance = CCommonListView.GetListTotal(lvwInsurancePayments, colInsurancePaymentAmount);
                decTotalBank = CCommonListView.GetListTotal(lvwBankPayments, colBankPaymentServiceCharge);
                decTotalOther = CCommonListView.GetListTotal(lvwOtherPayments, colOtherPaymentAmount);

                //this.txtBatchNumber.Text = decTotalFOB.ToString(CSettings.CurrencyFormat);
                //this.txtItem.Text = decFreightCharge.ToString(CSettings.CurrencyFormat);

                decTotalFOBInBirr = decTotalFOB * decExchangeRate;
                decFreightChargeInBirr = decFreightCharge * decExchangeRate;

                this.txtPriceAnalysisTotalPriceInBirr.Text = decTotalFOBInBirr.ToString(CSettings.CurrencyFormat);
                this.txtPriceAnalysisTotalFreightInBirr.Text = decFreightChargeInBirr.ToString(CSettings.CurrencyFormat);
                this.txtPriceAnalysisTotalInsuranceInBirr.Text = decTotalInsurance.ToString(CSettings.CurrencyFormat);
                this.txtPriceAnalysisTotalBankInBirr.Text = decTotalBank.ToString(CSettings.CurrencyFormat);
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
                CPriceAnalysis.CalculatePrice(PurchaseOrderGuid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveActualPriceForBatch(string Batchguid)
        {
            try
            {
                CBatchs objBatchs = new CBatchs();
                DataTable dt = new DataTable();

                objBatchs.Id = CBatchs.GetTableRowId(Batchguid);
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
        private bool FindBatchs(string Batchguid)
        {
            try
            {
                CBatchs objBatchs = new CBatchs();
                DataTable dt = new DataTable();

                objBatchs.Id = CBatchs.GetTableRowId(Batchguid);
                dt = objBatchs.GetRecord();
                if (dt.Rows.Count > 0)
                {                   
                    //txtBatchsBatchnumber.Text = Convert.ToString(objBatchs.Batchnumber);
                    //cboBatchsItemid.SelectedIndex = CCommon.GetIndexByItemData(cboBatchsItemid, objBatchs.Itemid.ToString());
                    //txtBatchsQuantity.Text = Convert.ToString(objBatchs.Quantity);

                    if (objBatchs.ExchangeRate == 0) objBatchs.ExchangeRate = 1;
                    txtPriceAnalysisExchangeRate.Text = objBatchs.ExchangeRate.ToString("#,##0.00000");

                    txtPriceAnalysisBatchTotalPrice.Text = (objBatchs.Priceperunit * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisBatchTotalFreight.Text = (objBatchs.Freightpayments * objBatchs.Quantity / objBatchs.ExchangeRate).ToString(CSettings.CurrencyFormat);

                    txtPriceAnalysisTotalPriceInBirr.Text = (objBatchs.Priceperunit * objBatchs.ExchangeRate * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisTotalFreightInBirr.Text = (objBatchs.Freightpayments * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisTotalInsuranceInBirr.Text = (objBatchs.Insurancepayments * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisTotalBankInBirr.Text = (objBatchs.Bankpayments * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisTotalOtherInBirr.Text = (objBatchs.Otherpayments * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);

                    txtPriceAnalysisTotalCostInBirrTotal.Text = ((objBatchs.Priceperunit * objBatchs.ExchangeRate +
                                                                    objBatchs.Freightpayments +
                                                                    objBatchs.Insurancepayments +
                                                                    objBatchs.Insurancepayments +
                                                                    objBatchs.Bankpayments +
                                                                    objBatchs.Otherpayments) * objBatchs.Quantity).ToString(CSettings.CurrencyFormat);

                    txtPriceAnalysisUnitPriceInBirr.Text = (objBatchs.Priceperunit * objBatchs.ExchangeRate).ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisUnitFreightInBirr.Text = objBatchs.Freightpayments.ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisUnitInsuranceInBirr.Text = objBatchs.Insurancepayments.ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisUnitBankInBirr.Text = objBatchs.Bankpayments.ToString(CSettings.CurrencyFormat);
                    txtPriceAnalysisUnitOtherInBirr.Text = objBatchs.Otherpayments.ToString(CSettings.CurrencyFormat);

                    txtPriceAnalysisUnitCostInBirrTotal.Text = (objBatchs.Priceperunit * objBatchs.ExchangeRate +
                                                                    objBatchs.Freightpayments +
                                                                    objBatchs.Insurancepayments +
                                                                    objBatchs.Insurancepayments +
                                                                    objBatchs.Bankpayments +
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

                SaveActualPriceForBatch(CBatchs.GetTableRowGuid(Convert.ToInt32(itmX.SubItems[colBatchsId.Index].Text)));
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
                FindBatchs(CBatchs.GetTableRowGuid(Convert.ToInt32(itmX.SubItems[colBatchsId.Index].Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
