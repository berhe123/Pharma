
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
    public partial class frmPurchaseOrder : Form
    {
        private const string DialogCaption = "Purchase Order";
        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        #region Purchase Order Form Code

        private bool already_in = false;

        public frmPurchaseOrder()
        {
            InitializeComponent();

            this.txtTermsOfContractOrder.GotFocus += new EventHandler(txtTermsOfContractOrder_GotFocus);
            this.txtTermsOfContractOrder.LostFocus += new EventHandler(txtTermsOfContractOrder_LostFocus);

            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

        }

        void txtTermsOfContractOrder_LostFocus(object sender, EventArgs e)
        {
            this.txtTermsOfContractOrder.Width = 509;
            this.txtTermsOfContractOrder.Height = 78;
        }

        void txtTermsOfContractOrder_GotFocus(object sender, EventArgs e)
        {
            this.txtTermsOfContractOrder.Width = this.txtTermsOfContractOrder.Width + cboOrderStatus.Width;
            this.txtTermsOfContractOrder.Height = this.txtTermsOfContractOrder.Height + tabDetail.Height;
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            popupHelper.AssignHandle(this.Handle);
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
                CCommon.FillDispatchCombo(this.cboDispatch, true);
                CCommon.FillTermsOfPaymentCombo(this.cboTermsOfPayment, true);
                CCommon.FillTermsOfShipmentCombo(this.cboTermsOfShipment, true);
                CCommon.FillCurrencyTypeCombo(this.cboCurrencyType, true);
                CCommon.FillProformaOrderTypeCombo(this.cboType, true);
                CCommon.FillPurchaseOrderStatusCombo(this.cboOrderStatus, true);

                NewPurchaseOrders();
                this.txtOrderDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtOrderDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
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
                this.grpProforma.Width = this.lblTitle.Width - this.grpProforma.Left - 24;
                this.lvwManufacturerProformaDetails.Width = this.grpProforma.Width - this.lvwManufacturerProformaDetails.Left - 24;
                this.grpOrder.Width = this.lblTitle.Width - this.grpOrder.Left - 24;

                // Transactions listview
                this.lvwPurchaseOrders.Height = this.Height - this.lvwPurchaseOrders.Top - 58;

                // Detail Groupbox
                this.tabDetail.Height = this.Height - this.tabDetail.Top - 58;
                this.tabDetail.Width = this.lblTitle.Width - this.tabDetail.Left - 24;

                this.panelTotal.Top = this.tabDetail.Height - this.panelTotal.Height - this.orderDetailToolStrip.Height - 2;
                this.gvwPurchaseOrderDetail.Width = this.tabDetail.Width  - 12;
                this.gvwPurchaseOrderDetail.Height = this.panelTotal.Top - this.orderDetailToolStrip.Height - 4;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmPurchaseOrder_Resize(object sender, EventArgs e)
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

        #endregion

        #region Purchase Order Code

        private bool bNewPurchaseOrders = true;
        private int PurchaseOrdersId = 0;

        private bool FindTermsOfContractTemplates(int TermsOfContractTemplatesId)
        {
            try
            {
                CTermsOfContractTemplates objTermsOfContractTemplates = new CTermsOfContractTemplates();
                DataTable dt = new DataTable();

                objTermsOfContractTemplates.Id = TermsOfContractTemplatesId;
                dt = objTermsOfContractTemplates.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    txtTermsOfContractOrder.Text = Convert.ToString(objTermsOfContractTemplates.Templatecontent);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private bool IsValidPurchaseOrders()
        {
            try
            {
                DateTime ValidDate;

                if (!CCommon.SetRequiredMessage(txtOrderNumber, "Order number can not be empty", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtOrderDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    CCommon.SetMessage(txtOrderDate, "Please enter a valid order date", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtTermsOfContractOrder, "Terms of contract can not be empty", mValidator, lblMsg))
                    return false;


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
                lvwPurchaseOrders.SelectedItems.Clear();

                bNewPurchaseOrders = true;
                PurchaseOrdersId = 0;

                txtOrderNumber.Text = String.Empty;
                txtOrderDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTermsOfContractOrder.Text = String.Empty;
                
                txtManufacturer.Text = String.Empty;
                txtManufacturer.Tag = null;
                txtProformaNumber.Text = String.Empty;
                txtProformaNumber.Tag = 0;
                txtProformaDate.Text = string.Empty;
                cboDispatch.SelectedIndex = 0;
                cboTermsOfPayment.SelectedIndex = 0;
                cboTermsOfShipment.SelectedIndex = 0;
                cboCurrencyType.SelectedIndex = 0;
                txtFreightCharge.Text = string.Empty;
                txtOriginPlace.Text = String.Empty;
                txtDestinationPlace.Text = String.Empty;
                cboType.SelectedIndex = 0;
                cboOrderStatus.SelectedIndex = 0;

                this.lvwManufacturerProformaDetails.Items.Clear();
                gvwPurchaseOrderDetail.Rows.Clear();
                CalculateTotal();

                FindTermsOfContractTemplates(2);

                gvwPurchaseOrderDetail.Rows.Clear();

                AdjsutOrderForEdit("-1");

                int maxOrderNumber = CPurchaseOrders.GetMaxOrderNumber();
                this.txtOrderNumber.Text = "0" + (maxOrderNumber + 1).ToString(); 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SavePurchaseOrders()
        {
            try
            {
                if (!IsValidPurchaseOrders()) return false;

                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();

                objPurchaseOrders.Id = PurchaseOrdersId;
                objPurchaseOrders.Manufacturerproformaguid = txtProformaNumber.Tag.ToString();
                objPurchaseOrders.Ordernumber = Convert.ToString(txtOrderNumber.Text);
                objPurchaseOrders.Orderdate = CDateTime.DateFromString(txtOrderDate.Text);
                objPurchaseOrders.Termsofcontract = Convert.ToString(txtTermsOfContractOrder.Text);
                objPurchaseOrders.Currencytype = Convert.ToInt32(CCommon.GetItemData(cboCurrencyType));
                objPurchaseOrders.Freightcharge = Convert.ToDecimal(txtFreightCharge.Text);
                objPurchaseOrders.Placeoforigin = Convert.ToString(txtOriginPlace.Text);
                objPurchaseOrders.Placeofdestination = Convert.ToString(txtDestinationPlace.Text);
                objPurchaseOrders.Ordertype = Convert.ToInt32(CCommon.GetItemData(cboType));
                objPurchaseOrders.Orderstatus = Convert.ToInt32(CCommon.GetItemData(cboOrderStatus));

                if (objPurchaseOrders.ProformaAlreadyUsed(bNewPurchaseOrders, PurchaseOrdersId, txtProformaNumber.Tag.ToString()) > 0)
                {
                    MessageBox.Show("There exists a purchase order record for the given proforma. Please try using another proforma.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (objPurchaseOrders.Exists(bNewPurchaseOrders) > 0)
                {
                    MessageBox.Show("There exists a purchase order record with the given order number. Please try using another order number.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewPurchaseOrders)
                    objPurchaseOrders.Insert();
                else
                    objPurchaseOrders.Update();

                PurchaseOrdersId = objPurchaseOrders.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindPurchaseOrders()
        {
            try
            {
                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();
                DataTable dt = new DataTable();

                objPurchaseOrders.Id = PurchaseOrdersId;
                dt = objPurchaseOrders.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    PurchaseOrdersId = objPurchaseOrders.Id;
                    txtProformaNumber.Text = CManufacturerProformas.GetManufacturerProformaNumber(objPurchaseOrders.Manufacturerproformaguid);
                    txtProformaNumber.Tag = Convert.ToString(objPurchaseOrders.Manufacturerproformaguid);
                    txtOrderNumber.Text = Convert.ToString(objPurchaseOrders.Ordernumber);
                    if (objPurchaseOrders.Orderdate != DateTime.MinValue)
                    {
                        txtOrderDate.Text = objPurchaseOrders.Orderdate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtOrderDate.Text = string.Empty;
                    }
                    txtTermsOfContractOrder.Text = Convert.ToString(objPurchaseOrders.Termsofcontract);
                    cboCurrencyType.SelectedIndex = CCommon.GetIndexByItemData(cboCurrencyType, objPurchaseOrders.Currencytype.ToString(), true);
                    txtFreightCharge.Text = Convert.ToString(objPurchaseOrders.Freightcharge);
                    txtOriginPlace.Text = Convert.ToString(objPurchaseOrders.Placeoforigin);
                    txtDestinationPlace.Text = Convert.ToString(objPurchaseOrders.Placeofdestination);
                    cboType.SelectedIndex = CCommon.GetIndexByItemData(cboType, objPurchaseOrders.Ordertype.ToString(), true);
                    cboOrderStatus.SelectedIndex = CCommon.GetIndexByItemData(cboOrderStatus, objPurchaseOrders.Orderstatus.ToString(), true);

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
        private void EditPurchaseOrders()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwPurchaseOrders.SelectedItems[0];

                bNewPurchaseOrders = false;
                PurchaseOrdersId = Convert.ToInt32(itmX.SubItems[colAutoID.Index].Text);
                txtProformaNumber.Text = CManufacturerProformas.GetManufacturerProformaNumber(itmX.SubItems[colManufacturerProformaGuid.Index].Text);
                txtProformaNumber.Tag = Convert.ToString(itmX.SubItems[colManufacturerProformaGuid.Index].Text);
                txtOrderNumber.Text = Convert.ToString(itmX.SubItems[colOrderNumber.Index].Text);
                txtOrderDate.Text = itmX.SubItems[colOrderDate.Index].Text;
                txtTermsOfContractOrder.Text = Convert.ToString(itmX.SubItems[colTermsOfContract.Index].Text);
                cboCurrencyType.SelectedIndex = CCommon.GetIndexByItemData(cboCurrencyType, itmX.SubItems[colCurrencyType.Index].Text, true);
                txtFreightCharge.Text = Convert.ToString(itmX.SubItems[colFreightCharge.Index].Text);
                txtOriginPlace.Text = Convert.ToString(itmX.SubItems[colPlaceOfOrigin.Index].Text);
                txtDestinationPlace.Text = Convert.ToString(itmX.SubItems[colPlaceOfDestination.Index].Text);
                cboType.SelectedIndex = CCommon.GetIndexByItemData(cboType, itmX.SubItems[colOrderType.Index].Text, true);
                cboOrderStatus.SelectedIndex = CCommon.GetIndexByItemData(cboOrderStatus, itmX.SubItems[colOrderStatus.Index].Text, true);

                this.FindManufacturerProformas(this.txtProformaNumber.Tag.ToString());

                //this.FindPurchaseOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdatePurchaseOrdersList()
        {
            try
            {
                if (bNewPurchaseOrders)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrdersId.ToString(), 
                                                                                      txtProformaNumber.Tag.ToString(), 
                                                                                      txtOrderNumber.Text.ToString(), 
                                                                                      txtOrderDate.Text.ToString(),  
                                                                                      txtTermsOfContractOrder.Text.ToString(),
                                                                                      CCommon.GetItemData(cboCurrencyType), 
                                                                                      cboCurrencyType.Text.ToString(), 
                                                                                      txtFreightCharge.Text.ToString(), 
                                                                                      txtOriginPlace.Text.ToString(), 
                                                                                      txtDestinationPlace.Text.ToString(), 
                                                                                      CCommon.GetItemData(cboType), 
                                                                                      CCommon.GetItemData(cboOrderStatus)});
                    lvwPurchaseOrders.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwPurchaseOrders.SelectedItems[0];
                    itmX.SubItems[colManufacturerProformaGuid.Index].Text = txtProformaNumber.Tag.ToString();
                    itmX.SubItems[colOrderNumber.Index].Text = txtOrderNumber.Text.ToString();
                    itmX.SubItems[colOrderDate.Index].Text = txtOrderDate.Text.ToString();
                    itmX.SubItems[colTermsOfContract.Index].Text = txtTermsOfContractOrder.Text.ToString();
                    itmX.SubItems[colCurrencyType.Index].Text = CCommon.GetItemData(cboCurrencyType);
                    itmX.SubItems[colCurrency.Index].Text = cboCurrencyType.Text;
                    itmX.SubItems[colFreightCharge.Index].Text = txtFreightCharge.Text.ToString();
                    itmX.SubItems[colPlaceOfOrigin.Index].Text = txtOriginPlace.Text.ToString();
                    itmX.SubItems[colPlaceOfDestination.Index].Text = txtDestinationPlace.Text.ToString();
                    itmX.SubItems[colOrderType.Index].Text = CCommon.GetItemData(cboType);
                    itmX.SubItems[colOrderTypeDescription.Index].Text = cboType.Text;
                    itmX.SubItems[colOrderStatus.Index].Text = CCommon.GetItemData(cboOrderStatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList()
        {
            try
            {

                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();

                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(false));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Id.ToString(), 
                                                                                      PurchaseOrders.Manufacturerproformaguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofcontract.ToString(),
                                                                                      PurchaseOrders.Currencytype.ToString(), 
                                                                                      CCommon.GetCurrencyTypeText(PurchaseOrders.Currencytype), 
                                                                                      PurchaseOrders.Freightcharge.ToString(), 
                                                                                      PurchaseOrders.Placeoforigin.ToString(), 
                                                                                      PurchaseOrders.Placeofdestination.ToString(), 
                                                                                      PurchaseOrders.Ordertype.ToString(), 
                                                                                      CCommon.GetProformaOrderTypeText(PurchaseOrders.Ordertype), 
                                                                                      PurchaseOrders.Orderstatus.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(string Manufacturerguid)
        {
            try
            {

                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();

                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Manufacturerguid, false));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Id.ToString(), 
                                                                                      PurchaseOrders.Manufacturerproformaguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofcontract.ToString(),
                                                                                      PurchaseOrders.Currencytype.ToString(), 
                                                                                      CCommon.GetCurrencyTypeText(PurchaseOrders.Currencytype), 
                                                                                      PurchaseOrders.Freightcharge.ToString(), 
                                                                                      PurchaseOrders.Placeoforigin.ToString(), 
                                                                                      PurchaseOrders.Placeofdestination.ToString(), 
                                                                                      PurchaseOrders.Ordertype.ToString(), 
                                                                                      CCommon.GetProformaOrderTypeText(PurchaseOrders.Ordertype), 
                                                                                      PurchaseOrders.Orderstatus.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(DateTime ProformaDateFrom, DateTime ProformaDateTo)
        {
            try
            {

                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();

                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(ProformaDateFrom, ProformaDateTo, false));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Id.ToString(), 
                                                                                      PurchaseOrders.Manufacturerproformaguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofcontract.ToString(),
                                                                                      PurchaseOrders.Currencytype.ToString(), 
                                                                                      CCommon.GetCurrencyTypeText(PurchaseOrders.Currencytype), 
                                                                                      PurchaseOrders.Freightcharge.ToString(), 
                                                                                      PurchaseOrders.Placeoforigin.ToString(), 
                                                                                      PurchaseOrders.Placeofdestination.ToString(), 
                                                                                      PurchaseOrders.Ordertype.ToString(), 
                                                                                      CCommon.GetProformaOrderTypeText(PurchaseOrders.Ordertype), 
                                                                                      PurchaseOrders.Orderstatus.ToString()});
                    this.lvwPurchaseOrders.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrdersList(string Manufacturerguid, DateTime ProformaDateFrom, DateTime ProformaDateTo)
        {
            try
            {

                CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();

                ArrayList ar = new ArrayList(objPurchaseOrders.GetList(Manufacturerguid, ProformaDateFrom, ProformaDateTo, false));
                this.lvwPurchaseOrders.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrders PurchaseOrders in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {PurchaseOrders.Id.ToString(), 
                                                                                      PurchaseOrders.Manufacturerproformaguid.ToString(), 
                                                                                      PurchaseOrders.Ordernumber.ToString(), 
                                                                                      PurchaseOrders.Orderdate == CSettings.MinDate ? string.Empty : PurchaseOrders.Orderdate.ToString(CSettings.DateFormat), 
                                                                                      PurchaseOrders.Termsofcontract.ToString(),
                                                                                      PurchaseOrders.Currencytype.ToString(), 
                                                                                      CCommon.GetCurrencyTypeText(PurchaseOrders.Currencytype), 
                                                                                      PurchaseOrders.Freightcharge.ToString(), 
                                                                                      PurchaseOrders.Placeoforigin.ToString(), 
                                                                                      PurchaseOrders.Placeofdestination.ToString(), 
                                                                                      PurchaseOrders.Ordertype.ToString(), 
                                                                                      CCommon.GetProformaOrderTypeText(PurchaseOrders.Ordertype), 
                                                                                      PurchaseOrders.Orderstatus.ToString()});
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
                string Manufacturerguid = string.Empty;
                DateTime ValidDate;
                DateTime OrderDateFrom = CSettings.SQLServerMinDate;
                DateTime OrderDateTo = CSettings.MaxDate;
                bool FilterByManufacturer = false;
                bool FilterByOrderDate = true;
                //bool NotReceived = false;

                if (this.txtManufacturerFilter.Tag != null && this.txtManufacturerFilter.Text != string.Empty)
                {
                    Manufacturerguid = this.txtManufacturerFilter.Tag.ToString();
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

                if (!FilterByManufacturer && !FilterByOrderDate)
                    FillPurchaseOrdersList();
                else if (FilterByManufacturer && !FilterByOrderDate)
                    FillPurchaseOrdersList(Manufacturerguid);
                else if (!FilterByManufacturer && FilterByOrderDate)
                    FillPurchaseOrdersList(OrderDateFrom, OrderDateTo);
                else if (FilterByManufacturer && FilterByOrderDate)
                    FillPurchaseOrdersList(Manufacturerguid, OrderDateFrom, OrderDateTo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowOrder()
        {
            try
            {
                DataTable dt = new DataTable();
                rptPurchaseOrder rpt = new rptPurchaseOrder();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = "SELECT   TOP (100) PERCENT tblManufacturerProformas.Dispatch,  ";
                strSQL = strSQL + "                 tblManufacturerProformas.TermsOfPayment, tblManufacturerProformas.TermsOfPaymentDetail,  ";
                strSQL = strSQL + "                 tblManufacturerProformas.TermsOfShipment, tblItems.BrandName, tblItems.GenericName,  ";
                strSQL = strSQL + " 				tblItems.Measurement, tblItems.SamplePresentation, ";
                strSQL = strSQL + "                 tblDosageForms.Name AS DosageForm, tblItems.Strength, tblUnitOfMeasurements.Name AS UnitOfMeasurement,  ";
                strSQL = strSQL + "                 tblManufacturers.Name AS ManufacturerName, tblManufacturerProformas.ManufacturerGuid,  ";
                strSQL = strSQL + "                 tblManufacturers.MailingAddress, tblManufacturers.email, tblManufacturers.Tel2,  ";
                strSQL = strSQL + " 				tblManufacturers.Tel1, tblManufacturers.Fax,  ";
                strSQL = strSQL + "                 'Tel: ' + tblManufacturers.Tel1 + ', Fax: ' + tblManufacturers.Fax + ', Email: ' + tblManufacturers.email AS Address1,  ";
                strSQL = strSQL + "                 tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS QuantityDescription,  ";
                strSQL = strSQL + "                 tblItems.BrandName + ' (' + tblItems.GenericName + ') ' + tblItems.Strength + ' ' AS ItemDescription,  ";
                strSQL = strSQL + "                 tblPurchaseOrders.FreightCharge, tblPurchaseOrders.CurrencyType,  ";
                strSQL = strSQL + "                 tblPurchaseOrders.TermsOfContract, tblPurchaseOrders.ManufacturerProformaGuid, tblPurchaseOrders.OrderDate,  ";
                strSQL = strSQL + "                 tblPurchaseOrders.OrderNumber, tblPurchaseOrderDetails.Id as DetailId, tblPurchaseOrderDetails.PricePerUnit,  ";
                strSQL = strSQL + "                 tblPurchaseOrderDetails.Quantity, tblPurchaseOrderDetails.TableRowGuid as DetailGuid, ";
                strSQL = strSQL + "                 tblPurchaseOrders.PlaceOfOrigin, tblPurchaseOrders.PlaceOfDestination, tblPurchaseOrders.OrderType, ";
                strSQL = strSQL + "                 tblPurchaseOrderDetails.PricePerUnit * tblPurchaseOrderDetails.Quantity AS LineTotal  ";
                strSQL = strSQL + " FROM      tblPurchaseOrders INNER JOIN tblPurchaseOrderDetails  ";
                strSQL = strSQL + " 				ON tblPurchaseOrders.TableRowGuid = tblPurchaseOrderDetails.PurchaseOrderGuid ";
                strSQL = strSQL + " 			INNER JOIN tblItems ";
                strSQL = strSQL + " 				ON tblPurchaseOrderDetails.ItemGuid = tblItems.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblUnitOfMeasurements ";
                strSQL = strSQL + " 				ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblDosageForms ";
                strSQL = strSQL + " 				ON tblItems.DosageFormGuid = tblDosageForms.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblManufacturerProformas  ";
                strSQL = strSQL + " 				ON tblPurchaseOrders.ManufacturerProformaGuid = tblManufacturerProformas.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblManufacturers  ";
                strSQL = strSQL + " 				ON tblManufacturerProformas.ManufacturerGuid = tblManufacturers.TableRowGuid  ";
                strSQL = strSQL + " Where tblPurchaseOrders.TableRowGuid = '" + CPurchaseOrders.GetTableRowGuid(PurchaseOrdersId) + "' ";
                strSQL = strSQL + " Order By ItemDescription ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Purchase order";
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
        private string IsOrderTurnedToReceiving(string Purchaseorderguid)
        {
            try
            {
                DataTable dt = new DataTable();
                CStoreTransactions receive = new CStoreTransactions();

                dt = receive.GetRecordbyPO(Purchaseorderguid, (int)CCommon.SupplierType.Exporter);

                if (dt.Rows.Count > 0)
                {
                    return (string)dt.Rows[0]["ReferenceNumber"];
                }
                else
                    return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        private void AdjsutOrderForEdit(string Purchaseorderguid)
        {
            try
            {
                string referenceNumber = IsOrderTurnedToReceiving(Purchaseorderguid);
                if (referenceNumber != string.Empty)
                {
                    this.txtReceivingReferenceNumber.Text = referenceNumber;
                    this.btnSearchProforma.Enabled = false;
                    this.txtOrderNumber.ReadOnly = true;
                    this.txtOrderDate.ReadOnly = true;
                    this.cboOrderStatus.Enabled = false;
                    this.txtTermsOfContractOrder.ReadOnly = true;
                }
                else
                {
                    this.txtReceivingReferenceNumber.Text = string.Empty;
                    this.btnSearchProforma.Enabled = true;
                    this.txtOrderNumber.ReadOnly = false;
                    this.txtOrderDate.ReadOnly = false;
                    this.cboOrderStatus.Enabled = true;
                    this.txtTermsOfContractOrder.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsOrderEditAllowed()
        {
            if (this.txtOrderNumber.ReadOnly)
            {
                MessageBox.Show("You can't edit a puchase order record which has already been used in a receiving transaction.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
                return true;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsOrderEditAllowed()) return;

                bool bSaved = false;

                bSaved = SavePurchaseOrders();

                if (bSaved)
                {
                    UpdatePurchaseOrdersList();
                    SavePurchaseOrderDetails(CPurchaseOrders.GetTableRowGuid(PurchaseOrdersId));
                    NewPurchaseOrders();
                };
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
                if (!IsOrderEditAllowed()) return;

                if (MessageBox.Show("Are you sure to delete this record?", "Purchase Orders", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CPurchaseOrders objPurchaseOrders = new CPurchaseOrders();
                    objPurchaseOrders.Id = Convert.ToInt32(lvwPurchaseOrders.SelectedItems[0].SubItems[colAutoID.Index].Text);
                    objPurchaseOrders.Delete();
                    lvwPurchaseOrders.Items.Remove(lvwPurchaseOrders.SelectedItems[0]);

                    NewPurchaseOrders();
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
                NewPurchaseOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwPurchaseOrders_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void lvwPurchaseOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwPurchaseOrders.SelectedItems == null) return;
                if (lvwPurchaseOrders.SelectedItems.Count <= 0) return;

                this.gvwPurchaseOrderDetail.Rows.Clear();
                EditPurchaseOrders();
                this.FillManufacturerProformaDetailsListByParent(this.txtProformaNumber.Tag.ToString());
                if (this.txtProformaNumber.Tag != null)
                {
                    CCommon.FillGridComboBox(this.gcboItem, "Select tblItems.TableRowGuid, BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name as ItemName from tblItems join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) where tblItems.TableRowGuid in (Select ItemGuid from tblManufacturerProformaDetails where ManufacturerProformaGuid = '" + this.txtProformaNumber.Tag.ToString() + "') ", "TableRowGuid", "ItemName");
                }
                FillPurchaseOrderDetailsGrid(CPurchaseOrders.GetTableRowGuid(PurchaseOrdersId));
                CalculateTotal();

                AdjsutOrderForEdit(CPurchaseOrders.GetTableRowGuid(PurchaseOrdersId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchPurchaseOrders_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.PurchaseOrdersId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindPurchaseOrders();
        }
        private void btnFindPurchaseOrders_Click(object sender, EventArgs e)
        {
            try
            {
                FindPurchaseOrders();
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

        private void btnShow_Click(object sender, EventArgs e)
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
        private void cboCurrencyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CCommon.GetItemData(cboCurrencyType) != "-1")
                {
                    gvwPurchaseOrderDetail.Columns[GridColumnNames.PricePerUnit].HeaderText = GridColumnDescriptions.PricePerUnit + " (" + cboCurrencyType.Text.ToString() + ")";
                    gvwPurchaseOrderDetail.Columns[GridColumnNames.LineTotal].HeaderText = GridColumnDescriptions.LineTotal + " (" + cboCurrencyType.Text.ToString() + ")";
                    lblTotalFOBCurrency.Text = " (" + cboCurrencyType.Text.ToString() + ")";
                    lblFreightChargeCurrency.Text = " (" + cboCurrencyType.Text.ToString() + ")";
                    lblTotalCandFCurrency.Text = " (" + cboCurrencyType.Text.ToString() + ")";
                }
                else
                {
                    gvwPurchaseOrderDetail.Columns[GridColumnNames.PricePerUnit].HeaderText = GridColumnDescriptions.PricePerUnit;
                    gvwPurchaseOrderDetail.Columns[GridColumnNames.LineTotal].HeaderText = GridColumnDescriptions.LineTotal;
                    lblTotalFOBCurrency.Text = " (Currency)";
                    lblFreightChargeCurrency.Text = " (Currency)";
                    lblTotalCandFCurrency.Text = " (Currency)";
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
                ShowOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboDispatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (CCommon.GetItemData(cboDispatch) != "-1")
                {
                    lblFreight.Text = "" + CCommon.GetDispatchTextForFreight(Convert.ToInt32(CCommon.GetItemData(cboDispatch))) + " Freight";
                }
                else
                {
                    lblFreight.Text = "Freight Charge";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtManufacturer_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtOriginPlace_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblTotalFOB.Text = "Total F.O.B. " + txtOriginPlace.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtDestinationPlace_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblTotalCandF.Text = "Total C+F " + CCommon.GetDispatchTextForFreight(Convert.ToInt32(CCommon.GetItemData(cboDispatch))) + " " + txtDestinationPlace.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchManufacturer(TextBox SearchTextBox, int HorizontalOffset, int VerticalOffset)
        {
            try
            {
                if (SearchTextBox.Text != "")
                {
                    CManufacturers objManufacturer = new CManufacturers();
                    string nameLike = SearchTextBox.Text + "%";
                    ArrayList ar = new ArrayList(objManufacturer.GetList(nameLike,(int)CCommon.SupplierType.Exporter));
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
            try
            {
                //SearchManufacturer(txtManufacturerFilter, grpFilter.Left, grpFilter.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Manufacturer Proforma Form Code

        private void FillGrigItemsCombo()
        {
            try
            {
                //if (CCommon.GetItemData(this.cboType) == ((int)CCommon.ProformaOrderType.Normal).ToString())
                CCommon.FillGridComboBox(this.gcboItem, "Select tblItems.TableRowGuid, BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name as ItemName from tblItems join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) where tblItems.TableRowGuid in (Select ItemGuid from tblManufacturerProformaDetails where ManufacturerProformaGuid = '" + this.txtProformaNumber.Tag.ToString() + "') Order by ItemName ", "TableRowGuid", "ItemName");
                //else if (CCommon.GetItemData(this.cboType) == ((int)CCommon.ProformaOrderType.Sample).ToString())
                    //CCommon.FillGridComboBox(this.gcboItem, "Select tblItems.TableRowGuid, BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name as ItemName from tblItems join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) where tblItems.TableRowGuid in (Select ItemGuid from tblManufacturerProformaDetails where ManufacturerProformaGuid = '" + this.txtProformaNumber.Tag.ToString() + "') Order by ItemName ", "TableRowGuid", "ItemName");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchProforma_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectManufacturerProforma frmMP = new frmSelectManufacturerProforma();
                frmMP.ShowDialog();
                if (frmMP.bCancel == true) return;
                this.txtProformaNumber.Tag = frmMP.ManufacturerProformaGuid.ToString();
                this.txtProformaNumber.Text = frmMP.ManufacturerProformaNumber.ToString();

                this.FindManufacturerProformas(this.txtProformaNumber.Tag.ToString());
                this.FillManufacturerProformaDetailsListByParent(this.txtProformaNumber.Tag.ToString());
                if (bNewPurchaseOrders)
                {
                    if (this.txtProformaNumber.Tag != null)
                    {
                        this.FillGrigItemsCombo();
                    }
                    this.FillPurchaseOrderDetailsGridFromProforma(this.txtProformaNumber.Tag.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool FindManufacturerProformas(string Manufacturerproformasguid)
        {
            try
            {
                CManufacturerProformas objManufacturerProformas = new CManufacturerProformas();
                DataTable dt = new DataTable();

                objManufacturerProformas.Id = CManufacturerProformas.GetTableRowId(Manufacturerproformasguid);
                dt = objManufacturerProformas.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    //ManufacturerProformasId = objManufacturerProformas.Id;
                    txtManufacturer.Text = CManufacturers.GetManufacturerNameFromCollection(objManufacturerProformas.Manufacturerguid);
                    txtManufacturer.Tag = Convert.ToString(objManufacturerProformas.Manufacturerguid);
                    if (objManufacturerProformas.Proformadate != DateTime.MinValue)
                    {
                        txtProformaDate.Text = objManufacturerProformas.Proformadate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProformaDate.Text = string.Empty;
                    }
                    cboDispatch.SelectedIndex = CCommon.GetIndexByItemData(cboDispatch, objManufacturerProformas.Dispatch.ToString(), true);
                    cboTermsOfPayment.SelectedIndex = CCommon.GetIndexByItemData(cboTermsOfPayment, objManufacturerProformas.Termsofpayment.ToString(), true);
                    cboTermsOfShipment.SelectedIndex = CCommon.GetIndexByItemData(cboTermsOfShipment, objManufacturerProformas.Termsofshipment.ToString(), true);

                    if (bNewPurchaseOrders)
                    {
                        txtOriginPlace.Text = Convert.ToString(objManufacturerProformas.Placeoforigin);
                        txtDestinationPlace.Text = Convert.ToString(objManufacturerProformas.Placeofdestination);
                        cboType.SelectedIndex = CCommon.GetIndexByItemData(cboType, objManufacturerProformas.Proformatype.ToString(), true);
                        cboCurrencyType.SelectedIndex = CCommon.GetIndexByItemData(cboCurrencyType, objManufacturerProformas.Currencytype.ToString(), true);
                        txtFreightCharge.Text = objManufacturerProformas.Freightcharge.ToString();
                    }

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
        private void FillManufacturerProformaDetailsList()
        {
            try
            {

                CManufacturerProformaDetails objManufacturerProformaDetails = new CManufacturerProformaDetails();

                ArrayList ar = new ArrayList(objManufacturerProformaDetails.GetList());
                this.lvwManufacturerProformaDetails.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CManufacturerProformaDetails ManufacturerProformaDetails in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {   ManufacturerProformaDetails.Id.ToString(), 
                                                                          ManufacturerProformaDetails.Manufacturerproformaguid.ToString(), 
                                                                          ManufacturerProformaDetails.Notificationnumber.ToString(), 
                                                                          ManufacturerProformaDetails.Itemguid.ToString(), 
                                                                          CItems.GetItemName(ManufacturerProformaDetails.Itemguid).ToString(), 
                                                                          ManufacturerProformaDetails.Quantity.ToString(CSettings.CurrencyFormat), 
                                                                          ManufacturerProformaDetails.Priceperunit.ToString(CSettings.CurrencyFormat), 
                                                                          (ManufacturerProformaDetails.Quantity*ManufacturerProformaDetails.Priceperunit).ToString(CSettings.CurrencyFormat)});
                    this.lvwManufacturerProformaDetails.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillManufacturerProformaDetailsListByParent(string Manufacturerproformaguid)
        {
            try
            {

                CManufacturerProformaDetails objManufacturerProformaDetails = new CManufacturerProformaDetails();

                ArrayList ar = new ArrayList(objManufacturerProformaDetails.GetList(Manufacturerproformaguid));
                this.lvwManufacturerProformaDetails.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CManufacturerProformaDetails ManufacturerProformaDetails in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {   ManufacturerProformaDetails.Id.ToString(), 
                                                                          ManufacturerProformaDetails.Manufacturerproformaguid.ToString(), 
                                                                          ManufacturerProformaDetails.Notificationnumber.ToString(), 
                                                                          ManufacturerProformaDetails.Itemguid.ToString(), 
                                                                          CItems.GetItemName(ManufacturerProformaDetails.Itemguid).ToString(), 
                                                                          ManufacturerProformaDetails.Quantity.ToString(CSettings.CurrencyFormat), 
                                                                          ManufacturerProformaDetails.Priceperunit.ToString(CSettings.CurrencyFormat), 
                                                                          (ManufacturerProformaDetails.Quantity*ManufacturerProformaDetails.Priceperunit).ToString(CSettings.CurrencyFormat)});
                    this.lvwManufacturerProformaDetails.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #endregion

        #region Purchase Order Detail Code

        #region GridColumnNames
        public class GridColumnNames
        {
            public const string Id = "Id";
            public const string OrderGuid = "PurchaseOrderGuid";
            public const string ItemGuid = "ItemGuid";
            public const string ItemDescription = "gcboItem";
            public const string Quantity = "Quantity";
            public const string PricePerUnit = "PricePerUnit";
            public const string LineTotal = "LineTotal";
        }
        #endregion
        #region GridColumnDescriptions
        public class GridColumnDescriptions
        {
            public const string Id = "Id";
            public const string OrderGuid = "Purchase Order Guid";
            public const string ItemGuid = "Item Guid";
            public const string ItemDescription = "Item";
            public const string Quantity = "Quantity";
            public const string PricePerUnit = "Price per Unit";
            public const string LineTotal = "Total";
        }
        #endregion

        private bool ValidatePurchaseOrderDetailRow(int intRowIndex)
        {
            try
            {
                double dblValue;

                if (gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemGuid].Value == null)
                {
                    gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Please select an item.";
                    return false;
                }

                if (gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.Quantity].Value != null)
                {
                    if (!double.TryParse(gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.Quantity].Value.ToString(), out dblValue))
                    {
                        gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Quantity must be a numeric value";
                        return false;
                    }
                }
                else
                {
                    gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Please enter the quantity.";
                    return false;
                }

                if (gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.PricePerUnit].Value != null)
                {
                    if (!double.TryParse(gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.PricePerUnit].Value.ToString(), out dblValue))
                    {
                        gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Price per Unit must be a numeric value";
                        return false;
                    }
                }
                else
                {
                    gvwPurchaseOrderDetail.Rows[intRowIndex].ErrorText = "Please enter the Price per Unit.";
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
        private void SavePurchaseOrderDetails(string Purchaseordersguid)
        {
            try
            {
                for (int gvwRowIndex = 0; gvwRowIndex < gvwPurchaseOrderDetail.RowCount - 1; gvwRowIndex++)
                {
                    string strId = "";

                    if (!ValidatePurchaseOrderDetailRow(gvwRowIndex)) break;

                    CPurchaseOrderDetails objPurchaseOrderDetails = new CPurchaseOrderDetails();

                    if (gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value != null && Convert.ToString(gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value) != "")
                        strId = gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value.ToString();

                    if (PurchaseOrdersId != 0)
                    {
                        objPurchaseOrderDetails.Id = 0;
                        objPurchaseOrderDetails.Purchaseorderguid = Purchaseordersguid;
                        objPurchaseOrderDetails.Itemguid = gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.ItemGuid].Value.ToString();
                        objPurchaseOrderDetails.Quantity = Convert.ToDecimal(gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Quantity].Value);
                        objPurchaseOrderDetails.Priceperunit = Convert.ToDecimal(gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.PricePerUnit].Value);

                        if (strId == string.Empty)
                        {
                            if (objPurchaseOrderDetails.Exists(true) > 0)
                            {
                                MessageBox.Show("There exists a Record with the selected item.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                // return;
                            }
                            else
                            {
                                objPurchaseOrderDetails.Insert();
                                gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value = objPurchaseOrderDetails.Id;
                            }
                        }
                        else
                        {
                            objPurchaseOrderDetails.Id = Convert.ToInt32(strId.ToString());
                            if (objPurchaseOrderDetails.Exists(false) > 0)
                            {
                                MessageBox.Show("There exists a Record with the selected item.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                //return;
                            }
                            else
                                objPurchaseOrderDetails.Update();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrderDetailsGrid(string Purchaseordersguid)
        {
            try
            {

                CPurchaseOrderDetails objPurchaseOrderDetails = new CPurchaseOrderDetails();

                ArrayList ar = new ArrayList(objPurchaseOrderDetails.GetList(Purchaseordersguid));
                if (this.gvwPurchaseOrderDetail.RowCount > 1)
                    this.gvwPurchaseOrderDetail.Rows.Clear();
                if (ar.Count < 0) return;

                foreach (CPurchaseOrderDetails objPurchaseOrderDetail in ar)
                {
                    gvwPurchaseOrderDetail.Rows.Add(new string[] { objPurchaseOrderDetail.Id.ToString(), 
                                                            objPurchaseOrderDetail.Purchaseorderguid.ToString(),
                                                            objPurchaseOrderDetail.Itemguid.ToString(),
                                                            objPurchaseOrderDetail.Itemguid.ToString().Trim(),
                                                            objPurchaseOrderDetail.Quantity.ToString(CSettings.CurrencyFormat),
                                                            objPurchaseOrderDetail.Priceperunit.ToString(CSettings.CurrencyFormat),
                                                            (objPurchaseOrderDetail.Quantity*objPurchaseOrderDetail.Priceperunit).ToString(CSettings.CurrencyFormat),});


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPurchaseOrderDetailsGridFromProforma(string Manufacturerproformasguid)
        {
            try
            {

                CManufacturerProformaDetails objManufacturerProformaDetails = new CManufacturerProformaDetails();

                ArrayList ar = new ArrayList(objManufacturerProformaDetails.GetList(Manufacturerproformasguid));
                if (this.gvwPurchaseOrderDetail.RowCount > 1)
                    this.gvwPurchaseOrderDetail.Rows.Clear();
                if (ar.Count < 0) return;

                foreach (CManufacturerProformaDetails objManufacturerProformaDetail in ar)
                {
                    gvwPurchaseOrderDetail.Rows.Add(new string[] { string.Empty, 
                                                            objManufacturerProformaDetail.Manufacturerproformaguid.ToString(),
                                                            objManufacturerProformaDetail.Itemguid.ToString(),
                                                            objManufacturerProformaDetail.Itemguid.ToString().Trim(),
                                                            objManufacturerProformaDetail.Quantity.ToString(CSettings.CurrencyFormat),
                                                            objManufacturerProformaDetail.Priceperunit.ToString(CSettings.CurrencyFormat),
                                                            (objManufacturerProformaDetail.Quantity*objManufacturerProformaDetail.Priceperunit).ToString(CSettings.CurrencyFormat)});


                }

                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RowLeaveTasks(int intRowIndex)
        {
            try
            {
                DataGridViewComboBoxCell gvwComboBoxCell;
                string Itemguid = string.Empty;

                gvwComboBoxCell = gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemDescription] as DataGridViewComboBoxCell;
                if (gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemDescription].Value != null)
                    Itemguid = gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemDescription].Value.ToString();
                gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.ItemGuid].Value = Itemguid;

                gvwPurchaseOrderDetail.Rows[intRowIndex].Cells[GridColumnNames.LineTotal].Value = CalculateGridLineTotal(gvwPurchaseOrderDetail, intRowIndex).ToString(CSettings.CurrencyFormat);
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalculateGridLineTotal(DataGridView dataGridView, int intRowIndex)
        {
            try
            {
                string strQuantity = string.Empty;
                string strPricePerUnit = string.Empty;

                decimal decQuantity = 0;
                decimal decPricePerUnit = 0;
                decimal decLineTotal = 0;

                if (dataGridView.Rows[intRowIndex].Cells[GridColumnNames.Quantity].Value != null)
                    strQuantity = dataGridView.Rows[intRowIndex].Cells[GridColumnNames.Quantity].Value.ToString();
                if (dataGridView.Rows[intRowIndex].Cells[GridColumnNames.PricePerUnit].Value != null)
                    strPricePerUnit = dataGridView.Rows[intRowIndex].Cells[GridColumnNames.PricePerUnit].Value.ToString();

                if (strQuantity != string.Empty) decQuantity = Convert.ToDecimal(strQuantity);
                if (strPricePerUnit != string.Empty) decPricePerUnit = Convert.ToDecimal(strPricePerUnit);

                decLineTotal = decQuantity * decPricePerUnit;

                return decLineTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return decimal.Zero;
            }
        }
        private decimal CalculateGridTotal(DataGridView dataGridView)
        {
            try
            {
                decimal decTotal = 0;
                decimal decLineTotal = 0;

                for (int intRowIndex = 0; intRowIndex < dataGridView.RowCount - 1; intRowIndex++)
                {
                    decLineTotal = CalculateGridLineTotal(dataGridView, intRowIndex);
                    decTotal = decTotal + decLineTotal;
                }

                return decTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return decimal.Zero;
            }
        }
        private void CalculateTotal()
        {
            try
            {
                decimal decTotalFOB = 0;
                decimal decFreightCharge = 0;
                decimal decTotalCandF = 0;

                decTotalFOB = CalculateGridTotal(gvwPurchaseOrderDetail);
                if (this.txtFreightCharge.Text != string.Empty) decFreightCharge = Convert.ToDecimal(this.txtFreightCharge.Text);
                decTotalCandF = decTotalFOB + decFreightCharge;

                this.txtTotalFOB.Text = decTotalFOB.ToString(CSettings.CurrencyFormat);
                this.txtTotalCandF.Text = decTotalCandF.ToString(CSettings.CurrencyFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvwPurchaseOrderDetail_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowLeaveTasks(e.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsOrderEditAllowed()) return;

                SavePurchaseOrderDetails(CPurchaseOrders.GetTableRowGuid(PurchaseOrdersId));
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
                if (!IsOrderEditAllowed()) return;

                for (int gvwRowIndex = 0; gvwRowIndex < gvwPurchaseOrderDetail.RowCount; gvwRowIndex++)
                {
                    if (gvwPurchaseOrderDetail.SelectedRows.Contains(gvwPurchaseOrderDetail.Rows[gvwRowIndex]))
                    {
                        if (MessageBox.Show("Are you sure to delete the " + Convert.ToString(gvwRowIndex + 1) + " row?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CPurchaseOrderDetails objPurchaseOrderDetails = new CPurchaseOrderDetails();
                            objPurchaseOrderDetails.Id = Convert.ToInt32(gvwPurchaseOrderDetail.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value);
                            objPurchaseOrderDetails.Delete();
                            gvwPurchaseOrderDetail.Rows[gvwRowIndex].Visible = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGetDetailFromProforma_Click(object sender, EventArgs e)
        {
            try
            {
                this.FillPurchaseOrderDetailsGridFromProforma(this.txtProformaNumber.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gvwPurchaseOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion

        private void btnSearchManufacturerFilter1_Click(object sender, EventArgs e)
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