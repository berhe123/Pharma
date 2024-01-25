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
    public partial class frmReceiving : Form
    {
        private const string DialogCaption = "Goods Receiving";
        private int intTransactionId = 0;
        private bool blnNewTransaction = false;
        private int intTransactionDetailId = 0;
        private bool blnLocalPurchase = false;
        public frmReceiving()
        {
            InitializeComponent();
        }
        private void NewTransaction()
        {
            try
            {
                blnNewTransaction = true;
                intTransactionId = 0;
                txtCheckedBy.Text = CSettings.GoodsReceivingCheckedBy;
                txtOrderNumber.Tag = "0";
                txtOrderNumber.Text = string.Empty;
                txtReferenceNo.Text = "";
                cboStoreLocation.SelectedIndex = CCommon.GetIndexByItemData(cboStoreLocation, CSettings.GoodsReceivingLocation.ToString(), true);
                cboStoreName.SelectedIndex = CCommon.GetIndexByItemData(cboStoreName, CSettings.GoodsReceivingStore.ToString(), true);
                txtTransactionBy.Text = CSettings.GoodsReceivingReceivedBy;
                txtDeliveredBy.Text = CSettings.GoodsReceivingDeliveredBy;
                txtCheckedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);               
                txtTransactionDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                lvwBatchs.Items.Clear();
                grvTransactionDetails.Rows.Clear();
                int maxReferenceNumber = CStoreTransactions.GetMaxReferenceNumber((int)CCommon.StoreTransactionType.Receiving);
                this.txtReferenceNo.Text = "0" + (maxReferenceNumber + 1).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillTransactionList(string strCriteria)
        {
            try
            {

                CStoreTransactions objTransaction = new CStoreTransactions();

                ArrayList ar = new ArrayList(objTransaction.GetList(strCriteria));
                this.lvwTransactions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CStoreTransactions StoreTransaction in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               StoreTransaction.Id.ToString(), 
                                                                                      StoreTransaction.Purchaseorderguid.ToString(), 
                                                                                      StoreTransaction.StoreName.ToString(), 
                                                                                      StoreTransaction.ReferenceNumber.ToString(),
                                                                                      StoreTransaction.TransactionType.ToString(),
                                                                                      StoreTransaction.TransactionBy.ToString(),                    
                                                                                      StoreTransaction.TransactionDate.ToString(CSettings.DateFormat),
                                                                                      StoreTransaction.CheckedBy.ToString(),
                                                                                      StoreTransaction.CheckedDate.ToString(CSettings.DateFormat),
                                                                                      StoreTransaction.DeliveredBy.ToString(),
                                                                                      StoreTransaction.DeliveryDate.ToString(CSettings.DateFormat),
                                                                                      StoreTransaction.LocationName.ToString(),
                                                                                      StoreTransaction.PurchaseOrderType.ToString()});

                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ShowItem(string strBatchNo)
        {
            try
            {
                string strBrandName = "";
                CStoreTransactionDetails objTranDetails = new CStoreTransactionDetails();
                strBrandName = objTranDetails.GetItemByBacth(strBatchNo);
                return strBrandName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }        
        private void FillOrderBatchNumbersList(string strOrderNo)
        {
            
            try
            {

                CStoreTransactionDetails objTranDetails = new CStoreTransactionDetails();               

                ArrayList ar = new ArrayList(objTranDetails.GetBacthItems(strOrderNo));

                if (ar.Count <= 0) return;

                foreach (CStoreTransactionDetails BatchItems in ar)
                {
                    grvTransactionDetails.Rows.Add(new string[] { intTransactionDetailId.ToString(), 
                                                                    BatchItems.Batchguid.ToString(),
                                                                    CStoreTransactions.GetTableRowGuid(intTransactionId),                                        
                                                                    BatchItems.BatchNumber.ToString(),
                                                                    BatchItems.BrandName.ToString(),                                                            
                                                                    BatchItems.BatchQuantity.ToString()
                    });


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        private void FillLocalOrderBatchNumbersList(string strOrderNo)
        {
            
            try
            {

                CStoreTransactionDetails objTranDetails = new CStoreTransactionDetails();

                ArrayList ar = new ArrayList(objTranDetails.GetLocalBacthItems(strOrderNo));

                if (ar.Count <= 0) return;
                grvTransactionDetails.Rows.Clear();

                foreach (CStoreTransactionDetails BatchItems in ar)
                {
                    grvTransactionDetails.Rows.Add(new string[] { intTransactionDetailId.ToString(), 
                                                                    BatchItems.Batchguid.ToString(),
                                                                    CStoreTransactions.GetTableRowGuid(intTransactionId),                                        
                                                                    BatchItems.BatchNumber.ToString(),
                                                                    BatchItems.BrandName.ToString(),                                                            
                                                                    BatchItems.BatchQuantity.ToString()
                    });


                }
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
                objTransactions.Purchaseorderguid = this.txtOrderNumber.Tag.ToString();
                objTransactions.Storeguid = CCommon.GetItemData(cboStoreName);
                objTransactions.ReferenceNumber = Convert.ToString(txtReferenceNo.Text);
                objTransactions.TransactionBy = Convert.ToString(txtTransactionBy.Text);
                objTransactions.TransactionDate = Convert.ToDateTime(txtTransactionDate.Text, CSettings.Culture);
                objTransactions.TransactionType = Convert.ToInt32(CCommon.StoreTransactionType.Receiving);
                objTransactions.CheckedBy = Convert.ToString(txtCheckedBy.Text);
                objTransactions.CheckedDate = Convert.ToDateTime(txtCheckedDate.Text, CSettings.Culture);
                objTransactions.IssuedToDeliveryPersonGuid = string.Empty;
                objTransactions.DeliveredBy = Convert.ToString(txtDeliveredBy.Text);
                objTransactions.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text, CSettings.Culture);
                if (blnLocalPurchase)
                    objTransactions.PurchaseOrderType = (int)CCommon.SupplierType.Local;
                else
                    objTransactions.PurchaseOrderType = (int)CCommon.SupplierType.Exporter;

                if (objTransactions.Exists(blnNewTransaction) > 0)
                {
                    MessageBox.Show("There exists a recieving record with the given details.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blnNewTransaction)
                    objTransactions.Insert();
                else
                    objTransactions.Update();

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

                if (!CCommon.SetRequiredMessage(txtReferenceNo, "Reference number can not be empty.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(cboStoreLocation, "Please select store location.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(cboStoreName, "Please select store name.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtTransactionBy, "Recieved by can not be empty.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtTransactionDate, "Recieved date can not be empty.", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtTransactionDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtCheckedDate, "Please enter recieved date in the correct format.", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtCheckedBy, "Checked by can not be empty.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtCheckedDate, "Checked date can not be empty.", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtCheckedDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtCheckedDate, "Please enter checked date in the correct format.", mValidator, lblMsg);
                    return false;
                }

                if (!CCommon.SetRequiredMessage(txtDeliveredBy, "Delivered by can not be empty.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtDeliveryDate, "Delivery date can not be empty.", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtDeliveryDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtDeliveryDate, "Please enter delivery date in the correct format.", mValidator, lblMsg);
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
        private void SaveTransactionDetail()
        {
            try
            {
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount - 1; grRow++)
                {
                    int tran_id = 0;
                    bool blnNewTransactionDetail = false;
                    if (!ValidateRow(grRow)) break;
                    CStoreTransactionDetails objTranDetail = new CStoreTransactionDetails();
                    if (Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value) == 0)
                    {
                        blnNewTransactionDetail = true;
                        tran_id = 0;
                    }
                    else
                    {
                        blnNewTransactionDetail = false;
                        tran_id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                    }

                    objTranDetail.Id = tran_id;
                    objTranDetail.Transactionguid = CStoreTransactions.GetTableRowGuid(intTransactionId);
                    objTranDetail.Transactiontype = Convert.ToInt32(CCommon.StoreTransactionType.Receiving);
                    objTranDetail.Batchguid = grvTransactionDetails.Rows[grRow].Cells["colBatchGuid"].Value.ToString();
                    objTranDetail.Quantity = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value);

                    if (blnNewTransactionDetail)
                    {
                        if (objTranDetail.Exists(true) <= 0)
                        {
                            objTranDetail.Insert();
                            grvTransactionDetails.Rows[grRow].Cells["colId"].Value = objTranDetail.Id;
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This Item is Already Recieved! ";

                    }
                    else
                    {
                        if (objTranDetail.Exists(false) <= 0)
                        {
                            objTranDetail.Id = Convert.ToInt32(tran_id.ToString());
                            objTranDetail.Update();
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This Item is Already Recieved! ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateRow(int grRow)
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
        private void FillTransactionDetailGrid(string Transactionguid)
        {

            try
            {

                CStoreTransactionDetails objTranDetails = new CStoreTransactionDetails();

                ArrayList ar = new ArrayList(objTranDetails.GetList(Transactionguid));

                if (ar.Count <= 0) return;
                grvTransactionDetails.Rows.Clear();
                foreach (CStoreTransactionDetails BatchItems in ar)
                {
                    grvTransactionDetails.Rows.Add(new string[] { BatchItems.Id.ToString(), 
                                                                    BatchItems.Batchguid.ToString(),
                                                                    BatchItems.Transactionguid.ToString(),                                        
                                                            BatchItems.BatchNumber.ToString(),
                                                            BatchItems.BrandName.ToString(),                                                            
                                                            BatchItems.Quantity.ToString()
                    });


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowReceiving()
        {
            try
            {
                DataTable dt = new DataTable();
                rptReceiving rpt = new rptReceiving();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT vwReceiving.TransactionBy, vwReceiving.TransactionDate, vwReceiving.CheckedBy, vwReceiving.CheckedDate, vwReceiving.DeliveredBy, vwReceiving.DeliveryDate,   ";
                strSQL = strSQL + "                vwReceiving.ReferenceNumber, tblManufacturers.Name AS ManufacturerName, ";
                strSQL = strSQL + "                tblBatchs.BatchNumber, vwReceiving.Quantity, tblBatchs.PricePerUnit,   ";
                strSQL = strSQL + "                vwReceiving.Quantity * tblBatchs.PricePerUnit AS LineTotal, tblItems.Measurement, tblItems.BrandName,   ";
                strSQL = strSQL + "                tblItems.GenericName, tblItems.DosageFormGuid, tblItems.Strength, tblUnitOfMeasurements.Name AS UnitName,   ";
                strSQL = strSQL + "                tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS UnitOfMeasurement, tblStores.Name AS StoreName,   ";
                strSQL = strSQL + "                tblItems.BrandName AS ItemDescription,   ";
                strSQL = strSQL + "                vwReceiving.TransactionDetailGuid AS DetailGuid, tblStores.TableRowGuid AS StoreGuid, vwReceiving.TransactionGuid, ";
                strSQL = strSQL + "                tblStores.Id AS StoreId  ";
                strSQL = strSQL + " FROM      vwReceiving  ";
                strSQL = strSQL + "                INNER JOIN  tblStores ON vwReceiving.StoreGuid = tblStores.TableRowGuid ";
                strSQL = strSQL + "                INNER JOIN                  tblBatchs ON vwReceiving.BatchGuid = tblBatchs.TableRowGuid ";
                strSQL = strSQL + "                INNER JOIN                  tblItems ON tblBatchs.ItemGuid = tblItems.TableRowGuid ";
                strSQL = strSQL + "                INNER JOIN                  tblManufacturers ON tblManufacturers.TableRowGuid = tblItems.ManufacturerGuid ";
                strSQL = strSQL + "                INNER JOIN                  tblUnitOfMeasurements ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";
                strSQL = strSQL + " Where vwReceiving.TransactionGuid = '" + CStoreTransactions.GetTableRowGuid(intTransactionId) + "' ";
                strSQL = strSQL + " Order By ItemDescription ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Goods Receiving";
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
                                                                                      Batchs.Manufactureddate.ToString(CSettings.DateFormat), 
                                                                                      Batchs.Expirydate.ToString(CSettings.DateFormat)});
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
                int intPurchaseOrderType;

                if (blnLocalPurchase) 
                    intPurchaseOrderType = (int)CCommon.SupplierType.Local;
                else 
                    intPurchaseOrderType = (int)CCommon.SupplierType.Exporter;

                ArrayList ar = new ArrayList(objBatchs.GetList(Purchaseorderguid, intPurchaseOrderType));
                this.lvwBatchs.Items.Clear();
                if (ar.Count <= 0) return;

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
                                                                                      Batchs.Manufactureddate.ToString(CSettings.DateFormat), 
                                                                                      Batchs.Expirydate.ToString(CSettings.DateFormat)});
                                                                                      
                    this.lvwBatchs.Items.Add(itmX);
                }
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
                    if (Convert.ToDateTime(objPurchaseOrders.Orderdate) != DateTime.MinValue)
                    {
                        dtOrderDate.Value = Convert.ToDateTime(objPurchaseOrders.Orderdate);
                    }
                    else
                    {
                        dtOrderDate.Value = dtOrderDate.MinDate;
                    }

                    return true;
                }
                else
                {
                    txtOrderNumber.Text = string.Empty;
                    MessageBox.Show("Purchase order record not found.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private bool FindLocalPurchaseOrders(string Purchaseorderguid)
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
                    if (Convert.ToDateTime(objPurchaseOrders.Orderdate) != DateTime.MinValue)
                    {
                        dtOrderDate.Value = Convert.ToDateTime(objPurchaseOrders.Orderdate);
                    }
                    else
                    {
                        dtOrderDate.Value = dtOrderDate.MinDate;
                    }

                    return true;
                }
                else
                {
                    txtOrderNumber.Text = string.Empty;
                    MessageBox.Show("Purchase order record not found.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                this.grpPO.Width = this.lblTitle.Width - this.grpPO.Left - 24;
                this.grpDataEntry.Width = this.lblTitle.Width - this.grpDataEntry.Left - 24;

                // Transactions listview
                this.lvwTransactions.Height = this.Height - this.lvwTransactions.Top - 65;

                // Detail Groupbox and Gridview
                this.tabControlDetail.Height = this.Height - this.tabControlDetail.Top - 65;
                this.tabControlDetail.Width = this.lblTitle.Width - this.tabControlDetail.Left - 24;
                this.grvTransactionDetails.Width = this.tabPageReceivingDetail.Width - 12;
                this.grvTransactionDetails.Height = this.tabPageReceivingDetail.Height - this.grvTransactionDetails.Top - 12;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditTransaction()
        {
            try
            {
                ListViewItem item = new ListViewItem();
                item = lvwTransactions.SelectedItems[0];
                blnNewTransaction = false;
                intTransactionId = Convert.ToInt32(item.SubItems[colTrasactionId.Index].Text);
                txtOrderNumber.Tag = Convert.ToString(item.SubItems[colPurchaseOrderGuid.Index].Text);
                txtReferenceNo.Text = Convert.ToString(item.SubItems[colRefNo.Index].Text);
                cboStoreLocation.SelectedIndex = Convert.ToInt32(CCommon.GetIndexByText(cboStoreLocation, item.SubItems[colLocationName.Index].Text, true));
                cboStoreName.SelectedIndex = Convert.ToInt32(CCommon.GetIndexByText(cboStoreName, item.SubItems[colStoreName.Index].Text, true));
                txtTransactionBy.Text = Convert.ToString(item.SubItems[colTransactionBy.Index].Text);
                txtTransactionDate.Text = Convert.ToString(item.SubItems[colTransactionDate.Index].Text);
                txtCheckedBy.Text = Convert.ToString(item.SubItems[colCheckedBy.Index].Text);
                txtCheckedDate.Text = Convert.ToString(item.SubItems[colCheckedDate.Index].Text);
                txtDeliveredBy.Text = Convert.ToString(item.SubItems[colDeliveredBy.Index].Text);
                txtDeliveryDate.Text = Convert.ToString(item.SubItems[colDeliveryDate.Index].Text);
                if (Convert.ToInt32(item.SubItems[colPurchaseOrderType.Index].Text) == (int)CCommon.SupplierType.Local) 
                    blnLocalPurchase = true;
                else 
                    blnLocalPurchase = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmRecieving_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillComboBox(cboStoreLocationSearch, "Select TableRowGuid, name from tblLocations order by name ", "TableRowGuid", "name");
                CCommon.FillComboBox(cboStoreLocation, "Select TableRowGuid, name from tblLocations order by name ", "TableRowGuid", "name");
                txtTransactionDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTransactionDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtCheckedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtDeliveryDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTransactionDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                cboStoreLocationSearch.SelectedIndex = CCommon.GetIndexByItemData(cboStoreLocationSearch, CSettings.GoodsReceivingLocation.ToString(), true);
                cboStoreNameSearch.SelectedIndex = CCommon.GetIndexByItemData(cboStoreNameSearch, CSettings.GoodsReceivingStore.ToString(), true);

                NewTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strCriteria = "";
                DateTime dteValidate;

                strCriteria = strCriteria + " And TransactionType = " + Convert.ToInt32(CCommon.StoreTransactionType.Receiving);
                if (cboStoreNameSearch.SelectedIndex != -1)
                    strCriteria = strCriteria + " And StoreGuid = '" + CCommon.GetItemData(cboStoreNameSearch) + "' ";
                if (txtTransactionDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtTransactionDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And TransactionDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtTransactionDateTo.Text != "")
                    if (DateTime.TryParseExact(txtTransactionDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And TransactionDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
                FillTransactionList(strCriteria);
                NewTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboStoreLocationSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboStoreLocationSearch.SelectedIndex != -1)
                    CCommon.FillComboBox(cboStoreNameSearch, "Select TableRowGuid, name from tblStores where LocationGuid = '" + CCommon.GetItemData(cboStoreLocationSearch) + "' order by name ", "TableRowGuid", "name");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboStoreLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboStoreLocation.SelectedIndex != -1)
                    CCommon.FillComboBox(cboStoreName, "Select TableRowGuid, name from tblStores where LocationGuid = '" + CCommon.GetItemData(cboStoreLocation) + "' order by name ", "TableRowGuid", "name");
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
                NewTransaction();
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
                if (SaveTransaction())
                {
                    SaveTransactionDetail();
                    MessageBox.Show("Data saved successfully.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
        private void lvwTransactions_Click(object sender, EventArgs e)
        {
            //
        }
        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (intTransactionId != 0)
                    SaveTransactionDetail();
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
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount; grRow++)
                {
                    if (grvTransactionDetails.SelectedRows.Contains(grvTransactionDetails.Rows[grRow]))
                    {
                        if (MessageBox.Show("Are you sure to delete the " + Convert.ToString(grRow + 1) + " row?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CStoreTransactionDetails objTranDetail = new CStoreTransactionDetails();
                            objTranDetail.Id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                            objTranDetail.Delete();
                            grvTransactionDetails.Rows[grRow].Visible = false;
                        }
                    }

                }
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
                if (MessageBox.Show("Are you sure to delete the recieving record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CStoreTransactionDetails objTranDetail = new CStoreTransactionDetails();
                    CStoreTransactions objTran = new CStoreTransactions();
                    objTran.Id = intTransactionId;
                    objTranDetail.Transactionguid = CStoreTransactions.GetTableRowGuid(intTransactionId);
                    if (!objTranDetail.CheckHasChildren(CStoreTransactions.GetTableRowGuid(intTransactionId)))
                    {
                        objTran.Delete();
                        lvwTransactions.Items.Remove(lvwTransactions.SelectedItems[0]);
                        NewTransaction();
                    }
                    else
                        MessageBox.Show("The recieving record can not be deleted. Please delete the items first.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grvTransactionDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount; grRow++)
                {
                    if (grvTransactionDetails.SelectedRows.Contains(grvTransactionDetails.Rows[grRow]))
                    {
                        if (MessageBox.Show("Are you sure to delete the " + Convert.ToString(grRow + 1) + " row?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CStoreTransactionDetails objTranDetail = new CStoreTransactionDetails();
                            objTranDetail.Id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                            objTranDetail.Delete();
                            grvTransactionDetails.Rows[grRow].Visible = false;
                        }
                    }
                    else
                        e.Cancel = true;
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
                ShowReceiving();
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
                frmPO.ShowDialog();
                if (frmPO.bCancel == true) return;
                blnLocalPurchase = frmPO.LocalPurchase;
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
                if (txtOrderNumber.Tag.ToString() == "0" | txtOrderNumber.Tag == null) return;
                
                bool bAlreadyIn = false;
                if (!bAlreadyIn)
                {
                    if (blnLocalPurchase)
                    {
                        bAlreadyIn = true;
                        FindLocalPurchaseOrders(this.txtOrderNumber.Tag.ToString());
                        FillBatchsListByParent(this.txtOrderNumber.Tag.ToString());
                        if (txtOrderNumber.Text != "")
                            FillLocalOrderBatchNumbersList(txtOrderNumber.Text.Trim());
                    }
                    else
                    {
                        bAlreadyIn = true;
                        FindPurchaseOrders(this.txtOrderNumber.Tag.ToString());
                        FillBatchsListByParent(this.txtOrderNumber.Tag.ToString());
                        if (txtOrderNumber.Text != "")
                            FillOrderBatchNumbersList(txtOrderNumber.Text.Trim());
                    }
                }
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

                EditTransaction();
                if(blnLocalPurchase)
                    FindLocalPurchaseOrders(txtOrderNumber.Tag.ToString());
                else
                    FindPurchaseOrders(txtOrderNumber.Tag.ToString());

                FillTransactionDetailGrid(CStoreTransactions.GetTableRowGuid(intTransactionId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmReceiving_Resize(object sender, EventArgs e)
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
        private void txtReferenceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetBatchesFromPurchaseOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderNumber.Text != "")
                    if(blnLocalPurchase)
                        FillLocalOrderBatchNumbersList(txtOrderNumber.Text.Trim());
                    else
                        FillOrderBatchNumbersList(txtOrderNumber.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwBatchs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpDataEntry_Enter(object sender, EventArgs e)
        {

        }

        private void grvTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

      

    }
}
