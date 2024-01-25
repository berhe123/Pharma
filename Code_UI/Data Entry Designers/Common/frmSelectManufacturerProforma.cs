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
    public partial class frmSelectManufacturerProforma : Form
    {
        private const string DialogCaption = "Search Manufacturer Proforma";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        #region Class Property Declarations

        bool blnCancel = false;
        public bool bCancel
        {
            get { return blnCancel; }
        }

        string strManufacturerProformaGuid = "";
        public string ManufacturerProformaGuid
        {
            get { return strManufacturerProformaGuid; }
        }

        string strManufacturerProformaNumber = "";
        public string ManufacturerProformaNumber
        {
            get { return strManufacturerProformaNumber; }
        }

        #endregion

        //private bool already_in = false;

        public frmSelectManufacturerProforma()
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

                lvwManufacturerProformas.Items.Clear();

                for (i = 0; i < tbl.Rows.Count; i++)
                {


                    ListViewItem itmX = new ListViewItem(

                                                new string[] {
                                                                tbl.Rows[i]["TableRowGuid"].ToString(),
                                                                tbl.Rows[i]["code"].ToString(),
                                                                tbl.Rows[i]["Name"].ToString()
                                                               }
                                                                );

                    this.lvwManufacturerProformas.Items.Add(itmX);
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
                DateTime ProformaDateFrom = CSettings.SQLServerMinDate;
                DateTime ProformaDateTo = CSettings.MaxDate;
                bool FilterByManufacturer = false;
                bool FilterByProformaDate = true;
                bool NotConvertedToPurchaseOrder = false;

                FilterByManufacturer = false;
                if (this.txtManufacturerFilter.Tag != null && this.txtManufacturerFilter.Text != string.Empty)
                {
                    strManufacturerGuid = this.txtManufacturerFilter.Tag.ToString();
                    FilterByManufacturer = true;
                }

                if (DateTime.TryParseExact(txtProformaDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    ProformaDateFrom = ValidDate;
                    FilterByProformaDate = true;
                }

                if (DateTime.TryParseExact(txtProformaDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    ProformaDateTo = ValidDate;
                    FilterByProformaDate = true;
                }

                if (chkNotConvertedToPurchaseOrder.CheckState == CheckState.Checked) NotConvertedToPurchaseOrder = true;

                if (!FilterByManufacturer && !FilterByProformaDate)
                    FillManufacturerProformasList(NotConvertedToPurchaseOrder);
                else if (FilterByManufacturer && !FilterByProformaDate)
                    FillManufacturerProformasList(strManufacturerGuid, NotConvertedToPurchaseOrder);
                else if (!FilterByManufacturer && FilterByProformaDate)
                    FillManufacturerProformasList(ProformaDateFrom, ProformaDateTo, NotConvertedToPurchaseOrder);
                else if (FilterByManufacturer && FilterByProformaDate)
                    FillManufacturerProformasList(strManufacturerGuid, ProformaDateFrom, ProformaDateTo, NotConvertedToPurchaseOrder);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillManufacturerProformasList(bool NotConvertedToPurchaseOrder)
        {
            try
            {

                CManufacturerProformas objManufacturerProformas = new CManufacturerProformas();

                ArrayList ar = new ArrayList(objManufacturerProformas.GetList(NotConvertedToPurchaseOrder));
                this.lvwManufacturerProformas.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CManufacturerProformas ManufacturerProformas in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ManufacturerProformas.Tablerowguid.ToString(), 
                                                                          ManufacturerProformas.Proformanumber.ToString(), 
                                                                          ManufacturerProformas.Proformadate == CSettings.MinDate ? string.Empty : ManufacturerProformas.Proformadate.ToString(CSettings.DateFormat), 
                                                                          ManufacturerProformas.Requestreferencenumber.ToString(), 
                                                                          ManufacturerProformas.Requestdate == CSettings.MinDate ? string.Empty : ManufacturerProformas.Requestdate.ToString(CSettings.DateFormat), 
                                                                          CCommon.GetDispatchText(ManufacturerProformas.Dispatch), 
                                                                          CCommon.GetTermsOfPaymentText(ManufacturerProformas.Termsofpayment),
                                                                          CCommon.GetTermsOfShipmentText(ManufacturerProformas.Termsofshipment)});
                    this.lvwManufacturerProformas.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillManufacturerProformasList(string Manufacturerguid, bool NotConvertedToPurchaseOrder)
        {
            try
            {

                CManufacturerProformas objManufacturerProformas = new CManufacturerProformas();

                ArrayList ar = new ArrayList(objManufacturerProformas.GetList(Manufacturerguid, NotConvertedToPurchaseOrder));
                this.lvwManufacturerProformas.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CManufacturerProformas ManufacturerProformas in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ManufacturerProformas.Tablerowguid.ToString(), 
                                                                          ManufacturerProformas.Proformanumber.ToString(), 
                                                                          ManufacturerProformas.Proformadate == CSettings.MinDate ? string.Empty : ManufacturerProformas.Proformadate.ToString(CSettings.DateFormat), 
                                                                          ManufacturerProformas.Requestreferencenumber.ToString(), 
                                                                          ManufacturerProformas.Requestdate == CSettings.MinDate ? string.Empty : ManufacturerProformas.Requestdate.ToString(CSettings.DateFormat), 
                                                                          CCommon.GetDispatchText(ManufacturerProformas.Dispatch), 
                                                                          CCommon.GetTermsOfPaymentText(ManufacturerProformas.Termsofpayment),
                                                                          CCommon.GetTermsOfShipmentText(ManufacturerProformas.Termsofshipment)});
                    this.lvwManufacturerProformas.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillManufacturerProformasList(DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotConvertedToPurchaseOrder)
        {
            try
            {

                CManufacturerProformas objManufacturerProformas = new CManufacturerProformas();

                ArrayList ar = new ArrayList(objManufacturerProformas.GetList(Convert.ToDateTime(ProformaDateFrom.ToShortDateString()), Convert.ToDateTime(ProformaDateTo.ToShortDateString()), NotConvertedToPurchaseOrder));
                this.lvwManufacturerProformas.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CManufacturerProformas ManufacturerProformas in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ManufacturerProformas.Tablerowguid.ToString(), 
                                                                          ManufacturerProformas.Proformanumber.ToString(), 
                                                                          ManufacturerProformas.Proformadate == CSettings.MinDate ? string.Empty : ManufacturerProformas.Proformadate.ToString(CSettings.DateFormat), 
                                                                          ManufacturerProformas.Requestreferencenumber.ToString(), 
                                                                          ManufacturerProformas.Requestdate == CSettings.MinDate ? string.Empty : ManufacturerProformas.Requestdate.ToString(CSettings.DateFormat), 
                                                                          CCommon.GetDispatchText(ManufacturerProformas.Dispatch), 
                                                                          CCommon.GetTermsOfPaymentText(ManufacturerProformas.Termsofpayment),
                                                                          CCommon.GetTermsOfShipmentText(ManufacturerProformas.Termsofshipment)});
                    this.lvwManufacturerProformas.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillManufacturerProformasList(string Manufacturerguid, DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotConvertedToPurchaseOrder)
        {
            try
            {

                CManufacturerProformas objManufacturerProformas = new CManufacturerProformas();

                ArrayList ar = new ArrayList(objManufacturerProformas.GetList(Manufacturerguid, Convert.ToDateTime(ProformaDateFrom.ToShortDateString()), Convert.ToDateTime(ProformaDateTo.ToShortDateString()), NotConvertedToPurchaseOrder));
                this.lvwManufacturerProformas.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CManufacturerProformas ManufacturerProformas in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ManufacturerProformas.Tablerowguid.ToString(), 
                                                                          ManufacturerProformas.Proformanumber.ToString(), 
                                                                          ManufacturerProformas.Proformadate == CSettings.MinDate ? string.Empty : ManufacturerProformas.Proformadate.ToString(CSettings.DateFormat), 
                                                                          ManufacturerProformas.Requestreferencenumber.ToString(), 
                                                                          ManufacturerProformas.Requestdate == CSettings.MinDate ? string.Empty : ManufacturerProformas.Requestdate.ToString(CSettings.DateFormat), 
                                                                          CCommon.GetDispatchText(ManufacturerProformas.Dispatch), 
                                                                          CCommon.GetTermsOfPaymentText(ManufacturerProformas.Termsofpayment),
                                                                          CCommon.GetTermsOfShipmentText(ManufacturerProformas.Termsofshipment)});
                    this.lvwManufacturerProformas.Items.Add(itmX);
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

                if (this.lvwManufacturerProformas.SelectedItems.Count <= 0) return;
                itmX = this.lvwManufacturerProformas.SelectedItems[0];

                strManufacturerProformaGuid = itmX.SubItems[colGuid.Index].Text.ToString();
                strManufacturerProformaNumber = itmX.SubItems[colProformaNumber.Index].Text.ToString();
                blnCancel = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwManufacturers_DoubleClick(object sender, EventArgs e)
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

        private void lvwManufacturerProformas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmSelectManufacturerProforma_Load(object sender, EventArgs e)
        {
            this.txtProformaDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
            this.txtProformaDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
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
                        //popupHelper.ShowPopup(this, manSelector, location);

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

    }
}