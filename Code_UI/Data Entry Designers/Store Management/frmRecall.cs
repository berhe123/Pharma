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
    public partial class frmRecall : Form
    {
        private const string DialogCaption = "Recall Items";

        private int intTransactionId = 0;
        private bool blnNewTransaction = false;
        private int intTransactionDetailId = 0;
        private string Purchaseorderguid = string.Empty;
       
        public frmRecall()
        {
            InitializeComponent();
        }
        private void frmRecieving_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillComboBox(cboStoreLocationSearch, "Select TableRowGuid, name from tblLocations order by name ", "TableRowGuid", "name");
                CCommon.FillComboBox(cboStoreLocation, "Select TableRowGuid, name from tblLocations order by name", "TableRowGuid", "name");
                txtTransactionDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTransactionDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtCheckedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTransactionDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                NewTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NewTransaction()
        {
            try
            {
                blnNewTransaction = true;
                intTransactionId = 0;
                txtCheckedBy.Text = "";
                txtReferenceNo.Text = "";
                cboStoreLocation.SelectedIndex = 0;
                cboStoreName.SelectedIndex = 0;
                txtTransactionBy.Text = "";               
                txtCheckedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);               
                txtTransactionDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                grvTransactionDetails.Rows.Clear();

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

                strCriteria = strCriteria + " And TransactionType = " + Convert.ToInt32(CCommon.StoreTransactionType.Recall);

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
                                                                                      StoreTransaction.ReferenceNumber.ToString(),
                                                                                      StoreTransaction.TransactionType.ToString(),
                                                                                      StoreTransaction.TransactionBy.ToString(),                    
                                                                                      StoreTransaction.TransactionDate.ToString(CSettings.DateFormat),
                                                                                      StoreTransaction.CheckedBy.ToString(),
                                                                                      StoreTransaction.CheckedDate.ToString(CSettings.DateFormat),
                                                                                      StoreTransaction.LocationName.ToString()});

                    this.lvwTransactions.Items.Add(itmX);
                }
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
                    CCommon.FillComboBox(cboStoreName, "Select TableRowGuid, name from tblStores where LocationGuid ='" + CCommon.GetItemData(cboStoreLocation) + "' order by name ", "TableRowGuid", "name");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowBachsByOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderNumber.Text != "")
                    FillOrderBatchNumbersList(txtOrderNumber.Text.Trim());
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

                ArrayList ar = new ArrayList(objTranDetails.GetBacthItemsByPurchaseOrderNo(strOrderNo));

                if (ar.Count <= 0) return;
                Purchaseorderguid = objTranDetails.Purchaseorderguid;
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
        private bool SaveTransaction()
        {
            try
            {
                if (!IsValidTransaction()) return false;

                CStoreTransactions objTransactions = new CStoreTransactions();

                objTransactions.Id = intTransactionId;
                objTransactions.Storeguid = CCommon.GetItemData(cboStoreName);
                objTransactions.Purchaseorderguid = Purchaseorderguid;
                objTransactions.Invoiceguid = string.Empty;
                objTransactions.ReferenceNumber = Convert.ToString(txtReferenceNo.Text);
                objTransactions.TransactionBy = Convert.ToString(txtTransactionBy.Text);
                objTransactions.TransactionDate = Convert.ToDateTime(txtTransactionDate.Text, CSettings.Culture);
                objTransactions.TransactionType = Convert.ToInt32(CCommon.StoreTransactionType.Recall);
                objTransactions.CheckedBy = Convert.ToString(txtCheckedBy.Text);
                objTransactions.CheckedDate = Convert.ToDateTime(txtCheckedDate.Text, CSettings.Culture);
                objTransactions.DeliveredBy = string.Empty;
                objTransactions.IssuedToDeliveryPersonGuid = string.Empty;
                if (objTransactions.Exists(blnNewTransaction) > 0)
                {
                    MessageBox.Show("There exists a recall record with the given details.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                if (!CCommon.SetRequiredMessage(txtReferenceNo, "Reference Number Can Not Be Empty! Please Enter Data", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(cboStoreLocation, "Please Select Store Location", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(cboStoreName, "Please Select Store Name", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtTransactionBy, "Recieved By Can Not Be Empty! Please Enter Data ", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtTransactionDate, "Recieved Date Can Not be Empty! Please Enter Data", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtTransactionDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtCheckedDate, "Please Enter Recall Date in a Correct Format", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtCheckedBy, "Checked by Can Not Be Empty! Please Enter Data", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtCheckedDate, "Checked Date Can Not Be Empty! Please Enter Data", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtCheckedDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtCheckedDate, "Please Enter Checked Date in a Correct Format", mValidator, lblMsg);
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
        private void lvwTransactions_Click(object sender, EventArgs e)
        {
            //
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
                    objTranDetail.Transactiontype = Convert.ToInt32(CCommon.StoreTransactionType.Recall);
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
                if (MessageBox.Show("Are you sure to delete the recall record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        MessageBox.Show("The recall record can not be deleted. Please delete the items first", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                            //break;
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
                txtCheckedBy.Text = Convert.ToString(item.SubItems[colCheckedBy.Index].Text);
                txtCheckedDate.Text = Convert.ToString(item.SubItems[colCheckedDate.Index].Text);
                FillTransactionDetailGrid(CStoreTransactions.GetTableRowGuid(intTransactionId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
    }
}
