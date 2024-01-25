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
    public partial class frmIssuance : Form
    {
        private const string DialogCaption = "Goods Issuance";

        private int intTransactionId = 0;
        private bool blnNewTransaction = false;
        private int intTransactionDetailId = 0;       

        public frmIssuance()
        {
            InitializeComponent();
        }
        private void NewTransaction()
        {
            try
            {
                blnNewTransaction = true;
                intTransactionId = 0;

                txtInvoiceNumber.Tag = 0;
                txtInvoiceNumber.Text = string.Empty;
                txtReferenceNo.Text = "";
                cboStoreLocation.SelectedIndex = CCommon.GetIndexByItemData(cboStoreLocation, CSettings.GoodsIssuanceLocation.ToString(), true);
                cboStoreName.SelectedIndex = CCommon.GetIndexByItemData(cboStoreName, CSettings.GoodsIssuanceStore.ToString(), true);
                cboIssuedTo.SelectedIndex = CCommon.GetIndexByItemData(cboIssuedTo, CSettings.GoodsIssuanceIssuedTo.ToString(), true);
                txtTransactionBy.Text = CSettings.GoodsIssuanceIssuedBy;
                txtIssuedTo.Text = CSettings.GoodsIssuanceIssuedTo;     
                txtTransactionDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                grvTransactionDetails.Rows.Clear();

                NewInvoice();

                int maxReferenceNumber = CStoreTransactions.GetMaxReferenceNumber((int)CCommon.StoreTransactionType.Issuance);
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
                                                                                      StoreTransaction.StoreName.ToString(), 
                                                                                      StoreTransaction.Invoiceguid.ToString(), 
                                                                                      StoreTransaction.InvoiceNumber.ToString(), 
                                                                                      StoreTransaction.ReferenceNumber.ToString(),
                                                                                      StoreTransaction.TransactionType.ToString(),
                                                                                      StoreTransaction.TransactionBy.ToString(),                    
                                                                                      StoreTransaction.TransactionDate.ToString(CSettings.DateFormat),
                                                                                      StoreTransaction.LocationName.ToString(),
                                                                                      StoreTransaction.IssuedToDeliveryPersonGuid.ToString()});

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
        //private void FillOrderBatchNumbersList(string strOrderNo)
        //{

        //    try
        //    {
        //        grvTransactionDetails.Rows.Clear();

        //        CStoreTransactionDetails objTranDetails = new CStoreTransactionDetails();

        //        ArrayList ar = new ArrayList(objTranDetails.GetBacthItemsByInvoiceNo(strOrderNo));

        //        if (ar.Count <= 0) return;

        //        foreach (CStoreTransactionDetails BatchItems in ar)
        //        {
        //            grvTransactionDetails.Rows.Add(new string[] { intTransactionDetailId.ToString(), 
        //                                                            BatchItems.Batchguid.ToString(),
        //                                                            CStoreTransactions.GetTableRowGuid(intTransactionId),                                        
        //                                                    BatchItems.BatchNumber.ToString(),
        //                                                    BatchItems.BrandName.ToString(),                                                            
        //                                                    BatchItems.BatchQuantity.ToString()
        //            });


        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}       
        private void FillOrderBatchNumbersList(string strOrderNo, string strInvoiceGuid)
        {
            
            try
            {
                grvTransactionDetails.Rows.Clear();

                CStoreTransactionDetails objTranDetails = new CStoreTransactionDetails();

                ArrayList ar = new ArrayList(objTranDetails.GetBacthItemsByInvoiceNo(strOrderNo, strInvoiceGuid));

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
        private bool SaveTransaction()
        {
            try
            {
                if (!IsValidTransaction()) return false;

                CStoreTransactions objTransactions = new CStoreTransactions();

                objTransactions.Id = intTransactionId;
                objTransactions.Storeguid = CCommon.GetItemData(cboStoreName);
                if (txtInvoiceNumber.Tag != null && txtInvoiceNumber.Tag.ToString() != string.Empty)
                    objTransactions.Invoiceguid = txtInvoiceNumber.Tag.ToString();
                objTransactions.ReferenceNumber = Convert.ToString(txtReferenceNo.Text);
                objTransactions.TransactionBy = Convert.ToString(txtTransactionBy.Text);
                objTransactions.TransactionDate = Convert.ToDateTime(txtTransactionDate.Text, CSettings.Culture);
                objTransactions.TransactionType = Convert.ToInt32(CCommon.StoreTransactionType.Issuance);
                objTransactions.CheckedBy = Convert.ToString(txtTransactionBy.Text);
                objTransactions.CheckedDate = Convert.ToDateTime(txtTransactionDate.Text, CSettings.Culture);
                objTransactions.DeliveredBy = Convert.ToString(txtTransactionBy.Text);
                objTransactions.DeliveryDate = Convert.ToDateTime(txtTransactionDate.Text, CSettings.Culture);
                objTransactions.IssuedToDeliveryPersonGuid = CCommon.GetItemData(cboIssuedTo);

                if (objTransactions.Exists(blnNewTransaction) > 0)
                {
                    MessageBox.Show("There exists an issuance record with the given details.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (objTransactions.InvoiceExists(blnNewTransaction) > 0)
                {
                    MessageBox.Show("This invoice has been issued. Please check the data and try again.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                if (!CCommon.SetRequiredMessage(txtInvoiceNumber, "Invoice number can not be empty. Please enter a valid invoice number.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtReferenceNo, "Reference number can not be empty. Please enter a valid reference number.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(cboStoreLocation, "Please select store location", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(cboStoreName, "Please select store name", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtTransactionBy, "Issuaed by can not be empty.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtTransactionDate, "Issuance date can not be empty.", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtTransactionDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtTransactionDate, "Please enter issuance date in a correct format", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtIssuedTo, "Issued To can not be empty.", mValidator, lblMsg))
                    return false;

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
                    objTranDetail.Transactiontype = Convert.ToInt32(CCommon.StoreTransactionType.Issuance);
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
                            grvTransactionDetails.Rows[grRow].ErrorText = "This Item is Already Issued! ";

                    }
                    else
                    {
                        if (objTranDetail.Exists(false) <= 0)
                        {
                            objTranDetail.Id = Convert.ToInt32(tran_id.ToString());
                            objTranDetail.Update();
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This Item is Already Issued! ";
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
        private void ShowIssuance()
        {
            try
            {
                DataTable dt = new DataTable();
                rptIssuance rpt = new rptIssuance();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT vwIssuances.TransactionBy, vwIssuances.TransactionDate, tblCustomers.Name AS CustomerName, ";
                strSQL = strSQL + "                 vwIssuances.IssuedTo, vwIssuances.ReferenceNumber, tblInvoices.ReferenceNumber AS InvoiceNumber, ";
                strSQL = strSQL + "                tblBatchs.BatchNumber, vwIssuances.Quantity, tblItems.Measurement, tblItems.BrandName,   ";
                strSQL = strSQL + "                tblItems.GenericName, tblItems.Strength, tblUnitOfMeasurements.Name AS UnitName,   ";
                strSQL = strSQL + "                tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS UnitOfMeasurement, tblStores.Name AS StoreName,   ";
                strSQL = strSQL + "                tblItems.BrandName AS ItemDescription,   ";
                strSQL = strSQL + "                vwIssuances.TransactionDetailGuid AS DetailGuid, tblStores.TableRowGuid AS StoreGuid, vwIssuances.TransactionGuid  ";
                strSQL = strSQL + " FROM      vwIssuances INNER JOIN  ";
                strSQL = strSQL + "                tblStores ON vwIssuances.StoreGuid = tblStores.TableRowGuid INNER JOIN  ";
                strSQL = strSQL + "                tblBatchs ON vwIssuances.BatchGuid = tblBatchs.TableRowGuid INNER JOIN ";
                strSQL = strSQL + "                tblItems ON tblItems.TableRowGuid = tblBatchs.ItemGuid INNER JOIN ";
                strSQL = strSQL + "                tblUnitOfMeasurements ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid INNER JOIN ";                
                strSQL = strSQL + "                tblInvoices ON vwIssuances.InvoiceGuid = tblInvoices.TableRowGuid INNER JOIN  ";
                strSQL = strSQL + "                tblCustomers ON tblInvoices.CustomerGuid = tblCustomers.TableRowGuid ";
                strSQL = strSQL + " Where vwIssuances.TransactionGuid = '" + CStoreTransactions.GetTableRowGuid(intTransactionId) + "' ";
                strSQL = strSQL + " Order By ItemDescription ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Goods Issuance";
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

        #region Invoice Code

        private void NewInvoice()
        {
            try
            {
                txtInvoiceCustormerName.Text = string.Empty;
                //txtInvoiceNumber.Tag = 0;
                //txtInvoiceNumber.Text = string.Empty;
                txtInvoiceDate.Text = string.Empty;
                cboInvoiceType.SelectedIndex = -1;
                lblDelivered.Visible = false;
                lblVoid.Visible = false;
                lvwInvoiceDetails.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInvoiceDetailsList()
        {
            try
            {

                CInvoiceDetails objInvoiceDetails = new CInvoiceDetails();

                ArrayList ar = new ArrayList(objInvoiceDetails.GetList());
                this.lvwInvoiceDetails.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CInvoiceDetails InvoiceDetails in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {InvoiceDetails.Id.ToString(), 
                                                                                      InvoiceDetails.Invoiceguid.ToString(), 
                                                                                      InvoiceDetails.Batchguid.ToString(), 
                                                                                      InvoiceDetails.Quantity.ToString()});
                    this.lvwInvoiceDetails.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInvoiceDetailsListByParent(string Invoiceguid)
        {
            try
            {

                CInvoiceDetails objInvoiceDetails = new CInvoiceDetails();

                ArrayList ar = new ArrayList(objInvoiceDetails.GetList(Invoiceguid));
                this.lvwInvoiceDetails.Items.Clear();
                if (ar.Count <= 0) return;

                foreach (CInvoiceDetails InvoiceDetails in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {InvoiceDetails.Id.ToString(), 
                                                                      InvoiceDetails.Invoiceguid.ToString(), 
                                                                      InvoiceDetails.Batchguid.ToString(), 
                                                                      InvoiceDetails.BatchNumber.ToString(), 
                                                                      InvoiceDetails.ItemDescription.ToString(), 
                                                                      InvoiceDetails.UnitOfMeasurement.ToString(), 
                                                                      InvoiceDetails.Quantity.ToString(), 
                                                                      InvoiceDetails.SalePrice.ToString(), 
                                                                      (InvoiceDetails.Quantity * InvoiceDetails.SalePrice).ToString()});
                    this.lvwInvoiceDetails.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool FindInvoices(string Invoiceguid)
        {
            try
            {
                CInvoices objInvoices = new CInvoices();
                DataTable dt = new DataTable();

                objInvoices.Id = CInvoices.GetTableRowId(Invoiceguid);
                dt = objInvoices.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    //InvoicesId = objInvoices.Id;
                    txtInvoiceCustormerName.Text = CCustomers.GetCustomerNameFromCollection(objInvoices.Customerguid);
                    //txtInvoiceNumber.Tag = objInvoices.Id;
                    txtInvoiceNumber.Text = Convert.ToString(objInvoices.Referencenumber);
                    txtInvoiceDate.Text = objInvoices.Invoicedate.ToString(CSettings.DateFormat);
                    cboInvoiceType.SelectedIndex = CCommon.GetIndexByItemData(cboInvoiceType, Convert.ToString(objInvoices.Invoicetype), true);
                    //txtInvoicesDuedate.Text = Convert.ToString(objInvoices.Duedate);
                    //txtInvoicesPreparedby.Text = Convert.ToString(objInvoices.Preparedby);
                    //txtInvoicesCheckedby.Text = Convert.ToString(objInvoices.Checkedby);
                    //txtInvoicesApprovedby.Text = Convert.ToString(objInvoices.Approvedby);
                    //txtInvoicesDeliveredby.Text = Convert.ToString(objInvoices.Deliveredby);
                    //txtInvoicesPrepareddate.Text = Convert.ToString(objInvoices.Prepareddate);
                    //txtInvoicesCheckeddate.Text = Convert.ToString(objInvoices.Checkeddate);
                    //txtInvoicesApprovaldate.Text = Convert.ToString(objInvoices.Approvaldate);
                    //txtInvoicesDeliverydate.Text = Convert.ToString(objInvoices.Deliverydate);
                    //txtInvoicesDeliverystatus.Text = Convert.ToString(objInvoices.Deliverystatus);
                    //txtInvoicesSuppliesrequisitionid.Text = Convert.ToString(objInvoices.Suppliesrequisitionid);
                    //txtInvoicesCashcollectionid.Text = Convert.ToString(objInvoices.Cashcollectionid);

                    this.txtTransactionDate.Text = objInvoices.Invoicedate.ToString(CSettings.DateFormat);

                    int DeliveryStatus = objInvoices.Deliverystatus;
                    if (DeliveryStatus == (int)CCommon.DeliveryStatus.Pending)
                    {
                        this.lblDelivered.Visible = false;
                        this.lblVoid.Visible = false;
                    }
                    else if (DeliveryStatus == (int)CCommon.DeliveryStatus.Delivered)
                    {
                        this.lblDelivered.Visible = true;
                        this.lblVoid.Visible = false;
                    }
                    else if (DeliveryStatus == (int)CCommon.DeliveryStatus.Returned)
                    {
                        this.lblDelivered.Visible = false;
                        this.lblVoid.Visible = true;
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Invoice record can not be found.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        #endregion

        private void frmRecieving_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillInvoiceTypeCombo(cboInvoiceType);
                CCommon.FillComboBox(cboStoreLocationSearch, "Select TableRowGuid, name from tblLocations order by name ", "TableRowGuid", "name");
                CCommon.FillComboBox(cboStoreLocation, "Select TableRowGuid, name from tblLocations order by name ", "TableRowGuid", "name");
                CCommon.FillComboBox(cboIssuedTo, "Select TableRowGuid, name from tblDeliveryPersons order by name ", "TableRowGuid", "name");
                txtTransactionDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTransactionDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTransactionDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                cboStoreLocationSearch.SelectedIndex = CCommon.GetIndexByItemData(cboStoreLocationSearch, CSettings.GoodsIssuanceLocation.ToString(), true);
                cboStoreNameSearch.SelectedIndex = CCommon.GetIndexByItemData(cboStoreNameSearch, CSettings.GoodsIssuanceStore.ToString(), true);

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

                strCriteria = strCriteria + " And TransactionType = " + Convert.ToInt32(CCommon.StoreTransactionType.Issuance);
                if (cboStoreNameSearch.SelectedIndex != -1)
                    strCriteria = strCriteria + " And StoreGuid ='" + CCommon.GetItemData(cboStoreNameSearch) + "' ";
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
                    CCommon.FillComboBox(cboStoreNameSearch, "Select TableRowGuid, name from tblStores where LocationGuid ='" + CCommon.GetItemData(cboStoreLocationSearch) + "' Order by name ", "TableRowGuid", "name");
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
                    CCommon.FillComboBox(cboStoreName, "Select TableRowGuid, name from tblStores where LocationGuid ='" + CCommon.GetItemData(cboStoreLocation) + "' Order by name ", "TableRowGuid", "name");
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
                    MessageBox.Show("Data saved successfully", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                SaveTransactionDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillTransactionDetailGrid(string Transactionguid)
        {

            try
            {

                CStoreTransactionDetails objTranDetails = new CStoreTransactionDetails();

                ArrayList ar = new ArrayList(objTranDetails.GetList(Transactionguid));

                grvTransactionDetails.Rows.Clear();
                if (ar.Count <= 0) return;
                
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
        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteTransactionDetail();
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
                if (MessageBox.Show("Are you sure to delete the issuance record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        MessageBox.Show("The issuance record can not be deleted. Please delete the items first.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteTransactionDetail()
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
                        //else
                        //    e.Cancel = true;
                    }

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
                DeleteTransactionDetail();
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
        private void lvwTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwTransactions.SelectedItems == null) return;
                if (lvwTransactions.SelectedItems.Count <= 0) return;

                ListViewItem item = new ListViewItem();
                item = lvwTransactions.SelectedItems[0];
                blnNewTransaction = false;
                intTransactionId = Convert.ToInt32(item.SubItems[colTrasactionId.Index].Text);
                txtReferenceNo.Text = Convert.ToString(item.SubItems[colRefNo.Index].Text);
                cboStoreLocation.SelectedIndex = Convert.ToInt32(CCommon.GetIndexByText(cboStoreLocation, item.SubItems[colLocationName.Index].Text, true));
                cboStoreName.SelectedIndex = Convert.ToInt32(CCommon.GetIndexByText(cboStoreName, item.SubItems[colStoreName.Index].Text, true));
                txtTransactionBy.Text = Convert.ToString(item.SubItems[colTransactionBy.Index].Text);
                txtTransactionDate.Text = Convert.ToString(item.SubItems[colTransactionDate.Index].Text);
                //txtIssuedTo.Text = Convert.ToString(item.SubItems[colIssuedTo.Index].Text);
                cboIssuedTo.SelectedIndex = Convert.ToInt32(CCommon.GetIndexByItemData(cboIssuedTo, item.SubItems[colIssuedTo.Index].Text, true));

                FillTransactionDetailGrid(CStoreTransactions.GetTableRowGuid(intTransactionId));

                NewInvoice();
                txtInvoiceNumber.Tag = Convert.ToString(item.SubItems[colInvoiceGuid.Index].Text);
                if (txtInvoiceNumber.Tag != null && txtInvoiceNumber.Tag.ToString() != string.Empty)
                {
                    FindInvoices(txtInvoiceNumber.Tag.ToString());
                    FillInvoiceDetailsListByParent(txtInvoiceNumber.Tag.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }
        private void btnGetBatchesFromInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceNumber.Text != "")
                    FillOrderBatchNumbersList(txtInvoiceNumber.Text.Trim(),txtInvoiceNumber.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectInvoice frmInvoice = new frmSelectInvoice();
                frmInvoice.ShowDialog();
                if (frmInvoice.bCancel == true) return;
                this.txtInvoiceNumber.Tag = frmInvoice.InvoiceGuid.ToString();
                this.txtInvoiceNumber.Text = frmInvoice.InvoiceReferenceNumber.ToString();

                this.NewInvoice();
                this.FindInvoices(this.txtInvoiceNumber.Tag.ToString());
                this.FillInvoiceDetailsListByParent(this.txtInvoiceNumber.Tag.ToString());

                if (txtInvoiceNumber.Text != "")
                    FillOrderBatchNumbersList(txtInvoiceNumber.Text.Trim(), txtInvoiceNumber.Tag.ToString());
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
                this.panelToolBar.Width = this.lblTitle.Width - this.panelToolBar.Left;
                this.grpInvoice.Width = this.lblTitle.Width - this.grpInvoice.Left - 24;
                this.grpDataEntry.Width = this.lblTitle.Width - this.grpDataEntry.Left - 24;

                // Transactions listview
                this.lvwTransactions.Height = this.Height - this.lvwTransactions.Top - 65;

                // Detail Groupbox and Gridview
                this.tabControlIssuanceDetail.Height = this.Height - this.tabControlIssuanceDetail.Top - 65;
                this.tabControlIssuanceDetail.Width = this.lblTitle.Width - this.tabControlIssuanceDetail.Left - 24;
                this.grvTransactionDetails.Width = this.tabPageIssuanceDetail.Width - 12;
                this.grvTransactionDetails.Height = this.tabPageIssuanceDetail.Height - this.grvTransactionDetails.Top - 12;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmIssuance_Resize(object sender, EventArgs e)
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
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                ShowIssuance();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

    }
}
