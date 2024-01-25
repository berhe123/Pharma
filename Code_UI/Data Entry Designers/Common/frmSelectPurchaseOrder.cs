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
    public partial class frmSelectPurchaseOrder : Form
    {
        private const string DialogCaption = "Search Purchase Order";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        #region Class Property Declarations

        bool blnCancel = false;
        public bool bCancel
        {
            get { return blnCancel; }
        }

        string strPurchaseOrderGuid = "";
        public string Purchaseorderguid
        {
            get { return strPurchaseOrderGuid; }
        }

        string strPurchaseOrderNumber = "";
        public string PurchaseOrderNumber
        {
            get { return strPurchaseOrderNumber; }
        }
        bool blnLocalPurchase;
        public bool LocalPurchase
        {
            get { return blnLocalPurchase; }
        }
    

        #endregion

        //private bool already_in = false;

        public frmSelectPurchaseOrder()
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

        private void FillListFromDB()
        {
            try
            {
                int i = 0;

                DataTable tbl = new CManufacturers().GetRecords();
                if (tbl.Rows.Count <= 0) return;

                lvwPurchaseOrders.Items.Clear();

                for (i = 0; i < tbl.Rows.Count; i++)
                {


                    ListViewItem itmX = new ListViewItem(

                                                new string[] {
                                                                tbl.Rows[i]["TableRowGuid"].ToString(),
                                                                tbl.Rows[i]["code"].ToString(),
                                                                tbl.Rows[i]["Name"].ToString()
                                                               }
                                                                );

                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(bool NotReceived)
        {
            try
            {

                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();               
                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(NotReceived));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Tablerowguid.ToString(), 
                                                                                      PurchaseOrders.Manufacturerproformaguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofcontract.ToString(),
                                                                                      PurchaseOrders.Currencytype.ToString(), 
                                                                                      CCommon.GetCurrencyTypeText(PurchaseOrders.Currencytype), 
                                                                                      PurchaseOrders.Freightcharge.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(string Manufacturerguid, bool NotReceived)
        {
            try
            {

                
                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();
                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Manufacturerguid, NotReceived));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Tablerowguid.ToString(), 
                                                                                      PurchaseOrders.Manufacturerproformaguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofcontract.ToString(),
                                                                                      PurchaseOrders.Currencytype.ToString(), 
                                                                                      CCommon.GetCurrencyTypeText(PurchaseOrders.Currencytype), 
                                                                                      PurchaseOrders.Freightcharge.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotReceived)
        {
            try
            {
                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();
                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Convert.ToDateTime(ProformaDateFrom.ToShortDateString()), Convert.ToDateTime(ProformaDateTo.ToShortDateString()), NotReceived));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count <= 0) return;

                foreach (CPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Tablerowguid.ToString(), 
                                                                                      PurchaseOrders.Manufacturerproformaguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofcontract.ToString(),
                                                                                      PurchaseOrders.Currencytype.ToString(), 
                                                                                      CCommon.GetCurrencyTypeText(PurchaseOrders.Currencytype), 
                                                                                      PurchaseOrders.Freightcharge.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(string Manufacturerguid, DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotReceived)
        {
            try
            {
               
                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();
                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Manufacturerguid, Convert.ToDateTime(ProformaDateFrom.ToShortDateString()), Convert.ToDateTime(ProformaDateTo.ToShortDateString()), NotReceived));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Tablerowguid.ToString(), 
                                                                                      PurchaseOrders.Manufacturerproformaguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofcontract.ToString(),
                                                                                      PurchaseOrders.Currencytype.ToString(), 
                                                                                      CCommon.GetCurrencyTypeText(PurchaseOrders.Currencytype), 
                                                                                      PurchaseOrders.Freightcharge.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillLocalPurchaseOrdersList(bool NotReceived)
        {
            try
            {
                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();                

                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(NotReceived));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Tablerowguid.ToString(), 
                                                                                      "0", 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofpayment.ToString(),
                                                                                      "0", 
                                                                                      "Birr", 
                                                                                      "0"});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillLocalPurchaseOrdersList(string Manufacturerguid, bool NotReceived)
        {
            try
            {

                
                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();
                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Manufacturerguid, NotReceived));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Tablerowguid.ToString(), 
                                                                                      "0", 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofpayment.ToString(),
                                                                                      "0", 
                                                                                      "Birr", 
                                                                                      "0"});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillLocalPurchaseOrdersList(DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotReceived)
        {
            try
            {

                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();
                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Convert.ToDateTime(ProformaDateFrom.ToShortDateString()), Convert.ToDateTime(ProformaDateTo.ToShortDateString()), NotReceived));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count <= 0) return;

                foreach (CLocalPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Tablerowguid.ToString(), 
                                                                                      "0", 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofpayment.ToString(),
                                                                                      "0", 
                                                                                      "Birr", 
                                                                                      "0"});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillLocalPurchaseOrdersList(string Manufacturerguid, DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotReceived)
        {
            try
            {
               
                CLocalPurchaseOrders objPurchaseOrders = new CLocalPurchaseOrders();
                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Manufacturerguid, Convert.ToDateTime(ProformaDateFrom.ToShortDateString()), Convert.ToDateTime(ProformaDateTo.ToShortDateString()), NotReceived));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocalPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Tablerowguid.ToString(), 
                                                                                      "0", 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofpayment.ToString(),
                                                                                      "0", 
                                                                                      "Birr", 
                                                                                      "0"});
                    this.lvwPurchaseOrders.Items.Add(itmX);
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
                string strManufacturerGuid = string.Empty;
                DateTime ValidDate;
                DateTime OrderDateFrom = CSettings.SQLServerMinDate;
                DateTime OrderDateTo = CSettings.MaxDate;
                bool FilterByManufacturer = false;
                bool FilterByOrderDate = true;
                bool NotReceived = false;

                FilterByManufacturer = false;
                if (this.txtManufacturerFilter.Tag != null && this.txtManufacturerFilter.Text != string.Empty)
                {
                    strManufacturerGuid = this.txtManufacturerFilter.Tag.ToString();
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

                if (chkNotReceived.CheckState == CheckState.Checked) NotReceived = true;
                if (chkLocalPurchase.Checked)
                {
                    if (!FilterByManufacturer && !FilterByOrderDate)
                        FillLocalPurchaseOrdersList(NotReceived);
                    else if (FilterByManufacturer && !FilterByOrderDate)
                        FillLocalPurchaseOrdersList(strManufacturerGuid, NotReceived);
                    else if (!FilterByManufacturer && FilterByOrderDate)
                        FillLocalPurchaseOrdersList(OrderDateFrom, OrderDateTo, NotReceived);
                    else if (FilterByManufacturer && FilterByOrderDate)
                        FillLocalPurchaseOrdersList(strManufacturerGuid, OrderDateFrom, OrderDateTo, NotReceived);
                }
                else
                {
                    if (!FilterByManufacturer && !FilterByOrderDate)
                        FillPurchaseOrdersList(NotReceived);
                    else if (FilterByManufacturer && !FilterByOrderDate)
                        FillPurchaseOrdersList(strManufacturerGuid, NotReceived);
                    else if (!FilterByManufacturer && FilterByOrderDate)
                        FillPurchaseOrdersList(OrderDateFrom, OrderDateTo, NotReceived);
                    else if (FilterByManufacturer && FilterByOrderDate)
                        FillPurchaseOrdersList(strManufacturerGuid, OrderDateFrom, OrderDateTo, NotReceived);

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
                blnCancel = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem itmX = new ListViewItem();

                if (this.lvwPurchaseOrders.SelectedItems.Count <= 0) return;
                itmX = this.lvwPurchaseOrders.SelectedItems[0];

                strPurchaseOrderGuid = itmX.SubItems[colGuid.Index].Text.ToString();
                strPurchaseOrderNumber = itmX.SubItems[colOrderNumber.Index].Text.ToString();
                blnLocalPurchase = chkLocalPurchase.Checked;
                blnCancel = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwPurchaseOrders_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.btnSelect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
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

        private void lvwPurchaseOrders_SelectedIndexChanged(object sender, EventArgs e)
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
            //try
            //{
            //    SearchManufacturer(txtManufacturerFilter, grpFilter.Left, grpFilter.Top);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSearchManufacturer_Click(object sender, EventArgs e)
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

        private void frmSelectPurchaseOrder_Load(object sender, EventArgs e)
        {
            this.txtOrderDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
            this.txtOrderDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
        }

        private void lvwPurchaseOrders_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

    }
}