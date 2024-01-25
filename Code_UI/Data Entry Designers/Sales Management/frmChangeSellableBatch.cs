using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharma
{
    public partial class frmChangeSellableBatch : Form
    {
        private const string DialogCaption = "Adjust Sellable Batch";
        bool _canceled;
        public bool Canceled
        {
            get {return _canceled;}
        }

        string _item_guid;
        public string Itemguid
        {
            get { return _item_guid;  }
            set { _item_guid = value; }
        }
        string _brand_name;
        public string BrandName
        {
            get { return _brand_name; }
            set { _brand_name = value; }
        }
        decimal _quantity_required;
        public decimal QuantityRequired
        {
            get { return _quantity_required; }
            set { _quantity_required = value; }
        }

        public frmChangeSellableBatch()
        {
            InitializeComponent();
        }

        private void frmChangeSellableBatch_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData()
        {
            try
            {
                _canceled = true;
                this.txtItem.Text = _brand_name;
                CCommon.FillComboBox(cboItemBatchs, "Select TableRowGuid, BatchNumber from tblBatchs where ItemGuid = '" + _item_guid + "' Order by BatchNumber ", "TableRowGuid", "BatchNumber");
                GetCurrentSellableBatch(_item_guid);
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
                string Batchguid = CCommon.GetItemData(cboItemBatchs);
                txtBatchQuantity.Text = Convert.ToString(objInvoice.GetBatchQuantity(Batchguid, _item_guid));
                txtBatchQuantityBalance.Text = Math.Abs(objInvoice.GetBatchBalanceQuantity(Batchguid, decimal.Zero)).ToString();
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
                if (CCommon.GetDisplayText(cboItemBatchs) != txtCurrentSellableBatch.Text)
                {
                    CInvoices objInvoice = new CInvoices();
                    string Batchguid = CCommon.GetItemData(cboItemBatchs);
                    decimal decBatchQuantity = Convert.ToDecimal(txtBatchQuantity.Text);
                    decimal decBatchQuantityBalance = Convert.ToDecimal(txtBatchQuantityBalance.Text);
                    decimal decRemaining = decBatchQuantity - decBatchQuantityBalance;

                    if (decRemaining >= _quantity_required)
                    {
                        if (_item_guid != string.Empty & Batchguid != string.Empty)
                        {
                            CInvoices objItems = new CInvoices();
                            objItems.Itemguid = _item_guid;
                            objItems.Sellablebatchguid = Batchguid;
                            objItems.UpdateSellableBatch();
                            _canceled = false;
                            this.Close();

                        }
                    }
                    else
                    {
                        MessageBox.Show("The quantity balance of the selected batch is not enough!! ", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Can not set the same sallable batch!! ", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _canceled = true;
            this.Close();
        }
    }
}
