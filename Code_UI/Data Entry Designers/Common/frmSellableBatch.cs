using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Pharma
{
    public partial class frmSellableBatch : Form
    {
        private const string DialogCaption = "Set Sellable Batch";

        private string strItemGuid = string.Empty;
        private string strBatchGuid = string.Empty;
        public frmSellableBatch()
        {
            InitializeComponent();
        }
        
        private void frmSellableBatch_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillComboBox(cboItemCategory, "Select TableRowGuid, Name from tblItemCategories Order by Name ", "TableRowGuid", "Name",false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillItemsList(string strCriteria)
        {
            try
            {

                CSuppliesRequisitionDetails objRequest = new CSuppliesRequisitionDetails();

                ArrayList ar = new ArrayList(objRequest.GetListItems(strCriteria));
                this.lvwItems.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CSuppliesRequisitionDetails Request in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Request.Itemguid.ToString(), 
                                                                                      Request.BrandName.ToString(),
                                                                                      Request.Unit.ToString()});

                    this.lvwItems.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void GetCurrentSellableBatch(string Itemguid)
        {
            try
            {
                CInvoices objInvoice = new CInvoices();
                objInvoice = objInvoice.GetCurrentSellableBatch(Itemguid);
                txtCurrentSellableBatch.Text = objInvoice.SellableBatchName;
                txtCurrentBatchQuantity.Text = Convert.ToString(objInvoice.BatchQty);
                txtQuantityBalance.Text = Convert.ToString(objInvoice.BatchBalaceQty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboItemBatchs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CInvoices objInvoice = new CInvoices();
                strBatchGuid = CCommon.GetItemData(cboItemBatchs);
                txtBatchQuantity.Text = Convert.ToString(objInvoice.GetBatchQuantity(strBatchGuid, strItemGuid));
                txtBatchQuantityBalance.Text = Math.Abs(objInvoice.GetBatchBalanceQuantity(strBatchGuid, decimal.Zero)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetSellableBatch_Click(object sender, EventArgs e)
        {
            try
            {
                if (strItemGuid != string.Empty & strBatchGuid != string.Empty)
                {
                    CInvoices objItems = new CInvoices();
                    objItems.Itemguid = strItemGuid;
                    objItems.Sellablebatchguid = strBatchGuid;
                    //Store Transaction Detail 
                    //check weather the batch has receiving 
                    //TransactionType should be receiving 
                    CStoreTransactionDetails receiving = new CStoreTransactionDetails();

                    //receiving.Transactiontype = strtransaction;
                    int intNumberOfRows = receiving.CheckWeatherBatchIsReceived(strBatchGuid);
                    if (intNumberOfRows <= 0)
                        MessageBox.Show("This Batch is Not Received By the Store.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        objItems.UpdateSellableBatch();

                    
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void indexBar_LetterListener(object sender, EventArgs e)
        {
            try
            {
                string strCriteria = "";
                string value = ((IndexBar.IndexBarEventArgs)e).SelectedLetter;
                string[] values = null;
                if (value == "I, J")
                {
                    values = new string[2];
                    values[0] = "I";
                    values[1] = "J";
                }
                else if (value == "Q, R")
                {
                    values = new string[2];
                    values[0] = "Q";
                    values[1] = "R";
                }
                else if (value == "U, V, W")
                {
                    values = new string[3];
                    values[0] = "U";
                    values[1] = "V";
                    values[2] = "W";
                }
                else if (value == "X, Y, Z")
                {
                    values = new string[3];
                    values[0] = "X";
                    values[1] = "Y";
                    values[2] = "Z";
                }
                else if (value == "All")
                {
                    values = new string[0];
                }
                else
                {
                    values = new string[1];
                    values[0] = value;
                }
                int i;
                for (i = 0; i < values.Length; i++)
                {
                    if (i == 0)
                        strCriteria = strCriteria + " And (BrandName like '" + values[i] + "%'";
                    else
                        strCriteria = strCriteria + " Or BrandName like '" + values[i] + "%'";
                }
                if (i > 0)
                    strCriteria = strCriteria + ")";


                if (cboItemCategory.SelectedIndex > 0)
                    strCriteria = strCriteria + " And CategoryGuid = '" + CCommon.GetItemData(cboItemCategory) + "' ";

                FillItemsList(strCriteria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                cboItemBatchs.DataSource = null;
                //cboItemBatchs.Items.Clear();
                if (lvwItems.SelectedItems == null) return;
                if (lvwItems.SelectedItems.Count <= 0) return;

                ListViewItem itm;
                itm = lvwItems.SelectedItems[0];
                strItemGuid = itm.SubItems[colItemGuid.Index].Text;
                this.txtItem.Text = Convert.ToString(itm.SubItems[colItemBrandName.Index].Text);
                CCommon.FillComboBox(cboItemBatchs, "Select TableRowGuid,BatchNumber from tblBatchs where ItemGuid = '" + strItemGuid + "' ", "TableRowGuid", "BatchNumber");
                GetCurrentSellableBatch(strItemGuid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void indexBar_Load(object sender, EventArgs e)
        {

        }

           
       
    }
}
