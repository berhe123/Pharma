using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharma
{
    public partial class frmSettings : Form
    {
        private const string DialogCaption = "Application Settings";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        private Panel CurrentPanel = new Panel();
        private Panel NewPanel = new Panel();

        #region Setting Type Declarations

        private const string NODEORGANIZATION = "NODEORGANIZATION";
        private const string NODEORGANIZATIONG = "NODEORGANIZATIONG";
        private const string NODEDEFAULTS = "NODEDEFAULTS";

        private const string NODEDRUGREGISTRATION = "NODEDRUGREGISTRATION";
        private const string NODEDRUGREGISTRATIONFEE = "NODEDRUGREGISTRATIONFEE";

        private const string NODEIMPORTING = "NODEIMPORTING";
        private const string NODESUPPLIERPROFORMA = "NODESUPPLIERPROFORMA";
        private const string NODEPURCHASEORDER = "NODEPURCHASEORDER";
        private const string NODEPRICECALCULATION = "NODEPRICECALCULATION";

        private const string NODESTOREMANAGEMENT = "NODESTOREMANAGEMENT";
        private const string NODEGOODSRECEIVING = "NODEGOODSRECEIVING";
        private const string NODEGOODSISSUANCE = "NODEGOODSISSUANCE";

        private const string NODESALES = "NODESALES";
        private const string NODEPROFORMA = "NODEPROFORMA";
        private const string NODESUPPLIESREQUISITION = "NODESUPPLIESREQUISITION";
        private const string NODEINVOICE = "NODEINVOICE";

        private const string NODECASHCOLLECTION = "NODECASHCOLLECTION";
        private const string NODEPAYMENTREQUEST = "NODEPAYMENTREQUEST";
        private const string NODEPAYMENTSETTLEMENT = "NODEPAYMENTSETTLEMENT";

        #endregion

        public frmSettings()
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

        private void tvwSettings_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string nodeName = string.Empty;
                TreeNode node = new TreeNode();

                node = this.tvwSettings.SelectedNode;
                nodeName = node.Name;
                nodeName = nodeName.ToUpper();

                switch (nodeName)
                {
                    case NODEORGANIZATION: NewPanel = panelOrganization; break;
                    case NODEORGANIZATIONG: NewPanel = panelOrganization; break;
                    case NODEDEFAULTS: NewPanel = panelDefaults; break;

                    case NODEDRUGREGISTRATION: NewPanel = panelDrugRegistrationFee; break;
                    case NODEDRUGREGISTRATIONFEE: NewPanel = panelDrugRegistrationFee; break;

                    case NODEIMPORTING: NewPanel = panelSupplierProforma; break;
                    case NODESUPPLIERPROFORMA: NewPanel = panelSupplierProforma; break;
                    case NODEPURCHASEORDER: NewPanel = panelPurchaseOrder; break;
                    case NODEPRICECALCULATION: NewPanel = panelPriceCalculation; break;

                    case NODESTOREMANAGEMENT: NewPanel = panelGoodsReceiving; break;
                    case NODEGOODSRECEIVING: NewPanel = panelGoodsReceiving; break;
                    case NODEGOODSISSUANCE: NewPanel = panelGoodsIssuance; break;

                    case NODESALES: NewPanel = panelSuppliesRequisition; break;
                    case NODEPROFORMA: NewPanel = panelProforma; break;
                    case NODESUPPLIESREQUISITION: NewPanel = panelSuppliesRequisition; break;
                    case NODEINVOICE: NewPanel = panelInvoice; break;

                    case NODECASHCOLLECTION: NewPanel = panelPaymentRequest; break;
                    case NODEPAYMENTREQUEST: NewPanel = panelPaymentRequest; break;
                    case NODEPAYMENTSETTLEMENT: NewPanel = panelPaymentSettlement; break;

                    default: CurrentPanel.Left = -1000; break;
                }

                //if (!NewPanel.Equals(CurrentPanel))
                //{
                CurrentPanel.Left = -1000;
                NewPanel.Left = 235;
                CurrentPanel = NewPanel;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                this.WriteSettings();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmGeneralSettings_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillDispatchCombo(this.cboSupplierProformaDispatch, true);
                CCommon.FillTermsOfShipmentCombo(this.cboSupplierProformaTermsOfShipment, true);
                CCommon.FillInvoiceTypeCombo(this.cboInvoiceInvoiceType, true);

                CCommon.FillComboBox(cboDefaultWorkingLocation, "Select TableRowGuid, name from tblLocations order by name ", "TableRowGuid", "name", true);
                CCommon.FillComboBox(cboDefaultWorkingStore, "Select TableRowGuid, name from tblStores Where 1 = 0 order by name ", "TableRowGuid", "name", true);

                CCommon.FillComboBox(cboGoodsReceivingLocation, "Select TableRowGuid, name from tblLocations order by name ", "TableRowGuid", "name", true);
                CCommon.FillComboBox(cboGoodsReceivingStore, "Select TableRowGuid, name from tblStores Where 1 = 0 order by name ", "TableRowGuid", "name", true);

                CCommon.FillComboBox(cboGoodsIssuanceLocation, "Select TableRowGuid, name from tblLocations order by name ", "TableRowGuid", "name", true);
                CCommon.FillComboBox(cboGoodsIssuanceStore, "Select TableRowGuid, name from tblStores Where 1 = 0 order by name ", "TableRowGuid", "name", true);

                CCommon.FillComboBox(cboGoodsIssuanceIssuedTo, "Select TableRowGuid, name from tblDeliveryPersons order by name ", "TableRowGuid", "name", true);


                this.cboDefaultWorkingLocation.SelectedIndex = CCommon.GetIndexByItemData(this.cboDefaultWorkingLocation, "-1", false);
                this.cboDefaultWorkingStore.SelectedIndex = CCommon.GetIndexByItemData(this.cboDefaultWorkingStore, "-1", false);

                this.cboSupplierProformaDispatch.SelectedIndex = CCommon.GetIndexByItemData(this.cboSupplierProformaDispatch, "-1", false);
                this.cboSupplierProformaTermsOfShipment.SelectedIndex = CCommon.GetIndexByItemData(this.cboSupplierProformaTermsOfShipment, "-1", false);
                this.cboInvoiceInvoiceType.SelectedIndex = CCommon.GetIndexByItemData(this.cboInvoiceInvoiceType, "-1", false);

                this.cboGoodsReceivingLocation.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsReceivingLocation, "-1", false);
                this.cboGoodsReceivingStore.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsReceivingStore, "-1", false);

                this.cboGoodsIssuanceLocation.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsIssuanceLocation, "-1", false);
                this.cboGoodsIssuanceStore.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsIssuanceStore, "-1", false);

                this.cboGoodsIssuanceIssuedTo.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsIssuanceIssuedTo, "-1", false);

                this.ShowSettings();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowSettings()
        {
            try
            {
                //CAppSettings setting = new CAppSettings();

                // Organization Settings
                this.txtOrganizationName.Text = CSettings.OrganizationName.ToString();
                this.txtOrganizationAddress.Text = CSettings.OrganizationAddress.ToString();
                this.txtOrganizationTIN.Text = CSettings.OrganizationTIN.ToString();
                this.txtOrganizationVAT.Text = CSettings.OrganizationVAT.ToString();
                this.txtOrganizationFSNumber.Text = CSettings.OrganizationFSNumber.ToString();
                this.txtOrganizationMRC.Text = CSettings.OrganizationMachineRegistrationCode.ToString();
                this.txtOrganizationTelephone.Text = CSettings.OrganizationTelephone.ToString();
                this.txtOrganizationFax.Text = CSettings.OrganizationFax.ToString();
                this.txtOrganizationPOBox.Text = CSettings.OrganizationPOBox.ToString();

                // Defaults
                this.cboDefaultWorkingLocation.SelectedIndex = CCommon.GetIndexByItemData(this.cboDefaultWorkingLocation, CSettings.DefaultWorkingLocation.ToString(), true);
                this.cboDefaultWorkingStore.SelectedIndex = CCommon.GetIndexByItemData(this.cboDefaultWorkingStore, CSettings.DefaultWorkingStore.ToString(), true);
                this.txtDefaultWorkingManufacturer.Tag = CSettings.DefaultWorkingManufacturer.ToString();
                this.txtDefaultWorkingManufacturer.Text = CManufacturers.GetManufacturerNameFromCollection(CSettings.DefaultWorkingManufacturer);

                //CPicture.ShowPicture(CSettings.OrganizationLogo, picLogo);
                if (CSettings.OrganizationLogo != null)
                    picLogo.Image = CPicture.ByteArrayToPicture(CSettings.OrganizationLogo);
                else
                    picLogo.Image = null;

                // Drug Registration
                this.txtDrugRegistrationFeePercentagePaidByManufacturer.Text = CSettings.DrugRegistrationFeePercentagePaidByManufacturer.ToString();

                // Supplier Proforma
                this.cboSupplierProformaDispatch.SelectedIndex = CCommon.GetIndexByItemData(this.cboSupplierProformaDispatch, CSettings.SupplierProformaDispatch.ToString(), true);
                this.cboSupplierProformaTermsOfShipment.SelectedIndex = CCommon.GetIndexByItemData(this.cboSupplierProformaTermsOfShipment, CSettings.SupplierProformaTermsOfShipment.ToString(), true);
                if (CSettings.SupplierProformaGenerateNotificationNumber == 1)
                    this.chkSupplierProformaGenerateNotificationNumber.CheckState = CheckState.Checked;
                else
                    this.chkSupplierProformaGenerateNotificationNumber.CheckState = CheckState.Unchecked;

                // Purchase order
                if (CSettings.PurchaseOrderGenerateReferenceNumber == 1)
                    this.chkPurchaseOrderGenerateReferenceNumber.CheckState = CheckState.Checked;
                else
                    this.chkPurchaseOrderGenerateReferenceNumber.CheckState = CheckState.Unchecked;

                // Price Calculation
                if (CSettings.PriceCalculationAllowPriceRecalculation == 1)
                    this.chkAllowPriceRecalculation.CheckState = CheckState.Checked;
                else
                    this.chkAllowPriceRecalculation.CheckState = CheckState.Unchecked;

                // Goods Receiving
                this.cboGoodsReceivingLocation.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsReceivingLocation, CSettings.GoodsReceivingLocation.ToString(), true);
                this.cboGoodsReceivingStore.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsReceivingStore, CSettings.GoodsReceivingStore.ToString(), true);
                this.txtGoodsReceivingReceivedBy.Text = CSettings.GoodsReceivingReceivedBy.ToString();
                this.txtGoodsReceivingCheckedBy.Text = CSettings.GoodsReceivingCheckedBy.ToString();
                this.txtGoodsReceivingDeliveredBy.Text = CSettings.GoodsReceivingDeliveredBy.ToString();
                if (CSettings.GoodsReceivingGenerateReferenceNumber == 1)
                    this.chkGoodsReceivingGenerateReferenceNumber.CheckState = CheckState.Checked;
                else
                    this.chkGoodsReceivingGenerateReferenceNumber.CheckState = CheckState.Unchecked;

                // Goods Issuance
                this.cboGoodsIssuanceLocation.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsIssuanceLocation, CSettings.GoodsIssuanceLocation.ToString(), true);
                this.cboGoodsIssuanceStore.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsIssuanceStore, CSettings.GoodsIssuanceStore.ToString(), true);
                
                this.cboGoodsIssuanceIssuedTo.SelectedIndex = CCommon.GetIndexByItemData(this.cboGoodsIssuanceIssuedTo, CSettings.GoodsIssuanceIssuedTo.ToString(), true);


                this.txtGoodsIssuanceIssuedBy.Text = CSettings.GoodsIssuanceIssuedBy.ToString();
                this.txtGoodsIssuanceIssuedTo.Text = CCommon.GetDisplayText(this.cboGoodsIssuanceIssuedTo); 
                this.txtGoodsIssuanceCheckedBy.Text = CSettings.GoodsIssuanceCheckedBy.ToString();
                if (CSettings.GoodsIssuanceGenerateReferenceNumber == 1)
                    this.chkGoodsIssuanceGenerateReferenceNumber.CheckState = CheckState.Checked;
                else
                    this.chkGoodsIssuanceGenerateReferenceNumber.CheckState = CheckState.Unchecked;

                // Proforma
                this.txtProformaRequestedBy.Text = CSettings.ProformaRequestedBy.ToString();
                this.txtProformaApprovedBy.Text = CSettings.ProformaApprovedBy.ToString();
                this.txtProformaValidityPeriodLength.Text = CSettings.ProformaValidityPeriodLength.ToString();
                if (CSettings.ProformaGenerateReferenceNumber == 1)
                    this.chkProformaGenerateReferenceNumber.CheckState = CheckState.Checked;
                else
                    this.chkProformaGenerateReferenceNumber.CheckState = CheckState.Unchecked;

                // Supplies Requisition
                if (CSettings.SuppliesRequisitionRequestorDifferentFromLicensee == 1)
                    this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.CheckState = CheckState.Checked;
                else
                    this.chkSuppliesRequisitionRequestorDifferenctFromLicensee.CheckState = CheckState.Unchecked;
                this.txtSuppliesRequisitionRequestedBy.Text = CSettings.SuppliesRequisitionRequestedBy.ToString();
                this.txtSuppliesRequisitionApprovedBy.Text = CSettings.SuppliesRequisitionApprovedBy.ToString();
                if (CSettings.SuppliesRequisitionGenerateReferenceNumber == 1)
                    this.chkSuppliesRequisitionGenerateReferenceNumber.CheckState = CheckState.Checked;
                else
                    this.chkSuppliesRequisitionGenerateReferenceNumber.CheckState = CheckState.Unchecked;

                // invoice
                this.cboInvoiceInvoiceType.SelectedIndex = CCommon.GetIndexByItemData(this.cboInvoiceInvoiceType, CSettings.InvoiceInvoiceType.ToString(), true);
                this.txtInvoicePreparedBy.Text = CSettings.InvoicePreparedBy.ToString();
                this.txtInvoiceCheckedBy.Text = CSettings.InvoiceCheckedBy.ToString();
                this.txtInvoiceApprovedBy.Text = CSettings.InvoiceApprovedBy.ToString();
                this.txtInvoiceDeliveredBy.Text = CSettings.InvoiceDeliveredBy.ToString();
                this.txtInvoiceReturningReason.Text = CSettings.InvoiceReturningReason.ToString();
                if (CSettings.InvoiceGenerateReferenceNumber == 1)
                    this.chkInvoiceGenerateReferenceNumber.CheckState = CheckState.Checked;
                else
                    this.chkInvoiceGenerateReferenceNumber.CheckState = CheckState.Unchecked;
                this.txtInvoiceDueDateLength.Text = CSettings.InvoiceDueDateLength.ToString();

                txtVATPercentage.Text = CSettings.VATPercentage.ToString();

                // Payment Request
                if (CSettings.PaymentRequestGenerateReferenceNumber == 1)
                    this.chkPaymentRequestGenerateReferenceNumber.CheckState = CheckState.Checked;
                else
                    this.chkPaymentRequestGenerateReferenceNumber.CheckState = CheckState.Unchecked;

                // Payment Settlement
                this.txtPaymentSettlementCheckMaturityDateLength.Text = CSettings.PaymentSettlementCheckMaturityDateLength.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void WriteSettings()
        {
            try
            {
                //CAppSettings CAppSettings = new CAppSettings();

                // Organization Settings
                CAppSettings.SaveSetting("Pharma", "OrganizationName", this.txtOrganizationName.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "OrganizationAddress", this.txtOrganizationAddress.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "OrganizationTIN", this.txtOrganizationTIN.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "OrganizationVAT", this.txtOrganizationVAT.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "OrganizationFSNumber", this.txtOrganizationFSNumber.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "OrganizationMachineRegistrationCode", this.txtOrganizationMRC.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "OrganizationTelephone", this.txtOrganizationTelephone.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "OrganizationFax", this.txtOrganizationFax.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "OrganizationPOBox", this.txtOrganizationPOBox.Text, "", null, "");

                byte[] logo;
                if (picLogo.Image != null)
                {
                    logo = CPicture.PictureToByteArray(picLogo.Image);
                    CAppSettings.SaveSetting("Pharma", "OrganizationLogo", "", "", logo, "");
                }
                else
                    CAppSettings.SaveSetting("Pharma", "OrganizationLogo", "", "", null, "");

                // Defaults
                CAppSettings.SaveSetting("Pharma", "DefaultWorkingLocation", CCommon.GetItemData(cboDefaultWorkingLocation), "-1", null, "");
                CAppSettings.SaveSetting("Pharma", "DefaultWorkingStore", CCommon.GetItemData(cboDefaultWorkingStore), "-1", null, "");
                if (this.txtDefaultWorkingManufacturer.Tag != null)
                    CAppSettings.SaveSetting("Pharma", "DefaultWorkingManufacturer", this.txtDefaultWorkingManufacturer.Tag.ToString(), "-1", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "DefaultWorkingManufacturer", "-1", "-1", null, "");

                // Drug Registration
                CAppSettings.SaveSetting("Pharma", "DrugRegistrationFeePercentagePaidByManufacturer", this.txtDrugRegistrationFeePercentagePaidByManufacturer.Text, "50", null, "");

                // Supplier Proforma
                CAppSettings.SaveSetting("Pharma", "SupplierProformaDispatch", CCommon.GetItemData(cboSupplierProformaDispatch), "0", null, "");
                CAppSettings.SaveSetting("Pharma", "SupplierProformaTermsOfShipment", CCommon.GetItemData(cboSupplierProformaTermsOfShipment), "0", null, "");
                if (chkSupplierProformaGenerateNotificationNumber.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "SupplierProformaGenerateNotificationNumber", "1", "1", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "SupplierProformaGenerateNotificationNumber", "0", "1", null, "");

                // Purchase Order
                if (chkPurchaseOrderGenerateReferenceNumber.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "PurchaseOrderGenerateReferenceNumber", "1", "1", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "PurchaseOrderGenerateReferenceNumber", "0", "1", null, "");

                // Price Calculation
                if (chkAllowPriceRecalculation.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "PriceCalculationAllowPriceRecalculation", "1", "0", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "PriceCalculationAllowPriceRecalculation", "0", "0", null, "");

                // Goods Receiving
                CAppSettings.SaveSetting("Pharma", "GoodsReceivingLocation", CCommon.GetItemData(cboGoodsReceivingLocation), "-1", null, "");
                CAppSettings.SaveSetting("Pharma", "GoodsReceivingStore", CCommon.GetItemData(cboGoodsReceivingStore), "-1", null, "");
                CAppSettings.SaveSetting("Pharma", "GoodsReceivingReceivedBy", this.txtGoodsReceivingReceivedBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "GoodsReceivingCheckedBy", this.txtGoodsReceivingCheckedBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "GoodsReceivingDeliveredBy", this.txtGoodsReceivingDeliveredBy.Text, "", null, "");
                if (chkGoodsReceivingGenerateReferenceNumber.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "GoodsReceivingGenerateReferenceNumber", "1", "1", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "GoodsReceivingGenerateReferenceNumber", "0", "1", null, "");

                // Goods Issuance
                CAppSettings.SaveSetting("Pharma", "GoodsIssuanceLocation", CCommon.GetItemData(cboGoodsIssuanceLocation), "-1", null, "");
                CAppSettings.SaveSetting("Pharma", "GoodsIssuanceStore", CCommon.GetItemData(cboGoodsIssuanceStore), "-1", null, "");
                CAppSettings.SaveSetting("Pharma", "GoodsIssuanceIssuedBy", this.txtGoodsIssuanceIssuedBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "GoodsIssuanceIssuedTo", CCommon.GetItemData(cboGoodsIssuanceIssuedTo), "-1", null, "");
                CAppSettings.SaveSetting("Pharma", "GoodsIssuanceCheckedBy", this.txtGoodsIssuanceCheckedBy.Text, "", null, "");
                if (chkGoodsIssuanceGenerateReferenceNumber.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "GoodsIssuanceGenerateReferenceNumber", "1", "1", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "GoodsIssuanceGenerateReferenceNumber", "0", "1", null, "");

                // Proforma
                CAppSettings.SaveSetting("Pharma", "ProformaRequestedBy", this.txtProformaRequestedBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "ProformaApprovedBy", this.txtProformaApprovedBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "ProformaValidityPeriodLength", this.txtProformaValidityPeriodLength.Text, "0", null, "");
                if (chkProformaGenerateReferenceNumber.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "ProformaGenerateReferenceNumber", "1", "1", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "ProformaGenerateReferenceNumber", "0", "1", null, "");

                // Supplies Requisition
                if (chkSuppliesRequisitionRequestorDifferenctFromLicensee.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "SuppliesRequisitionRequestorDifferentFromLicensee", "1", "0", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "SuppliesRequisitionRequestorDifferentFromLicensee", "0", "0", null, "");
                CAppSettings.SaveSetting("Pharma", "SuppliesRequisitionRequestedBy", this.txtSuppliesRequisitionRequestedBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "SuppliesRequisitionApprovedBy", this.txtSuppliesRequisitionApprovedBy.Text, "", null, "");
                if (chkSuppliesRequisitionGenerateReferenceNumber.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "SuppliesRequisitionGenerateReferenceNumber", "1", "1", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "SuppliesRequisitionGenerateReferenceNumber", "0", "1", null, "");

                // Invoice
                CAppSettings.SaveSetting("Pharma", "InvoiceInvoiceType", CCommon.GetItemData(cboInvoiceInvoiceType), "-1", null, "");
                CAppSettings.SaveSetting("Pharma", "InvoicePreparedBy", this.txtInvoicePreparedBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "InvoiceCheckedBy", this.txtInvoiceCheckedBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "InvoiceApprovedBy", this.txtInvoiceApprovedBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "InvoiceDeliveredBy", this.txtInvoiceDeliveredBy.Text, "", null, "");
                CAppSettings.SaveSetting("Pharma", "InvoiceReturningReason", this.txtInvoiceReturningReason.Text, "", null, "");
                if (chkInvoiceGenerateReferenceNumber.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "InvoiceGenerateReferenceNumber", "1", "1", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "InvoiceGenerateReferenceNumber", "0", "1", null, "");
                CAppSettings.SaveSetting("Pharma", "InvoiceDueDateLength", this.txtInvoiceDueDateLength.Text, "0", null, "");

                CAppSettings.SaveSetting("Pharma", "VATPercentage", this.txtVATPercentage.Text, "0", null, "");


                // Payment Request
                if (chkPaymentRequestGenerateReferenceNumber.CheckState == CheckState.Checked)
                    CAppSettings.SaveSetting("Pharma", "PaymentRequestGenerateReferenceNumber", "1", "1", null, "");
                else
                    CAppSettings.SaveSetting("Pharma", "PaymentRequestGenerateReferenceNumber", "0", "1", null, "");

                // Payment Settlement
                CAppSettings.SaveSetting("Pharma", "PaymentSettlementCheckMaturityDateLength", this.txtPaymentSettlementCheckMaturityDateLength.Text, "0", null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportLogo_Click(object sender, EventArgs e)
        {
            try
            {
                dlgOpenFileDialog.Title = "Select a Logo";
                dlgOpenFileDialog.Multiselect = false;
                dlgOpenFileDialog.Filter = "JPEG Compressed Image(*.jpg)|*.jpg|Graphic Interchange Format (*.gif)|*.gif";
                dlgOpenFileDialog.FilterIndex = 2;
                dlgOpenFileDialog.FileName = "";
                dlgOpenFileDialog.ShowDialog();
                picLogo.ImageLocation = dlgOpenFileDialog.FileName;
                lblLogo.Text = dlgOpenFileDialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPasteLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (Clipboard.GetDataObject() != null)
                {
                    IDataObject data = Clipboard.GetDataObject();

                    if (data.GetDataPresent(DataFormats.Bitmap))
                    {
                        Image image = (Image)data.GetData(DataFormats.Bitmap, true);
                        picLogo.Image = image;
                    }
                    else
                    {
                        MessageBox.Show("No image exists in the clipboard.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveLogo_Click(object sender, EventArgs e)
        {

        }
        private void btnRefreshLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (CSettings.OrganizationLogo != null)
                    picLogo.Image = CPicture.ByteArrayToPicture(CSettings.OrganizationLogo);
                else
                    picLogo.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClearLogo_Click(object sender, EventArgs e)
        {
            try
            {
                picLogo.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDefaultWorkingLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboDefaultWorkingLocation.SelectedIndex != -1)
                    CCommon.FillComboBox(cboDefaultWorkingStore, "Select TableRowGuid, name from tblStores where LocationGuid ='" + CCommon.GetItemData(cboDefaultWorkingLocation) + "' order by name ", "TableRowGuid", "name", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboGoodsReceivingLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboGoodsReceivingLocation.SelectedIndex != -1)
                    CCommon.FillComboBox(cboGoodsReceivingStore, "Select TableRowGuid, name from tblStores where LocationGuid ='" + CCommon.GetItemData(cboGoodsReceivingLocation) + "' order by name ", "TableRowGuid", "name", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboGoodsIssuanceLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboGoodsIssuanceLocation.SelectedIndex != -1)
                    CCommon.FillComboBox(cboGoodsIssuanceStore, "Select TableRowGuid, name from tblStores where LocationGuid ='" + CCommon.GetItemData(cboGoodsIssuanceLocation) + "' order by name ", "TableRowGuid", "name", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSuppliesRequisitionRequestorDifferenctFromLicensee_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkSuppliesRequisitionRequestorDifferenctFromLicensee.Checked)
                    this.txtSuppliesRequisitionRequestedBy.Enabled = true;
                else
                    this.txtSuppliesRequisitionRequestedBy.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchDefaultWorkingManufacturer_Click(object sender, EventArgs e)
        {
            try
            {
                SearchManufacturer(txtDefaultWorkingManufacturer, panelDefaults.Left, panelDefaults.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dlgOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

    }
}
