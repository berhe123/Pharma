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
    public partial class frmRequesition : Form
    {
        private const string DialogCaption = "Supplies Requisition";

        #region Class Property Declarations

        string strSuppliesRequisitionGuid = "";
        public string Suppliesrequisitionguid
        {
            get { return strSuppliesRequisitionGuid; }
        }

        string strSuppliesRequisitionReferenceNumber = "";
        public string SuppliesRequisitionReferenceNumber
        {
            get { return strSuppliesRequisitionReferenceNumber; }
        }

        int RequisitionId = int.MinValue;
        public int Requisitionid 
        {
            get { return RequisitionId; }
        }

        string CustomerGuid2 = "";
        public string Customerguid2 
        {
            get { return CustomerGuid2; }
        }

        string CustomersOrganizationName = "";
        public string Customersorganizationname
        {
            get { return CustomersOrganizationName; }
        }

        int ReferenceNumber = int.MinValue;
        public int Referencenumber 
        {
            get { return ReferenceNumber; }
        }

        ArrayList ItemList=null;
        public ArrayList Itemlist 
        {
            get { return ItemList; }
        }

        #endregion

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector childSelector = null;

        private PopupWindowHelper popupHelper1 = null;
        private frmCustomerSelector childSelector1 = null;

        private int intRequesitionId = 0;
        //private bool blnNewRequesition = false;
        private int intReqDetailId = 0;
        private string CustomerGuidSearch = string.Empty;
        private string CustomerGuid = string.Empty;
        private string ItemGuid = string.Empty;
        private string LicenseGuid = string.Empty;
        //private bool CustomerHasLicense = false;

        public frmRequesition()
        {
            InitializeComponent();

            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

            popupHelper1 = new PopupWindowHelper();
            popupHelper1.PopupClosed += new PopupClosedEventHandler(popupHelper1_PopupClosed);
            popupHelper1.PopupCancel += new PopupCancelEventHandler(popupHelper1_PopupCancel);

            CCommon.FillComboBox(cboItemCategory, "SELECT TableRowGuid,Name FROM tblMakeOrganizations", "TableRowGuid", "Name", true);
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            popupHelper.AssignHandle(this.Handle);
            popupHelper1.AssignHandle(this.Handle);
        }
        private void NewRequesition()
        {
            try
            {
                //blnNewRequesition = true;
                intRequesitionId = 0;
               // CustomerHasLicense = false;
                LicenseGuid = string.Empty;
                lblLicense.Text = string.Empty;
                txtOrganizationName.Text = "CASH";
              
                int intMaxReferenceNumber = CSuppliesRequisitions.GetMaxReferenceNumber();
                txtReferenceNumber.Text = "0" + (intMaxReferenceNumber + 1).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private bool SaveRequesition()
        {
            try
            {
                if (!IsValidRequisition()) return false;

                //if (LicenseGuid == string.Empty)
                //{
                //    MessageBox.Show("Can not save the requesition. Because the custormer does not have an active license.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return false;
                //}

                CSuppliesRequisitions objRequesition = new CSuppliesRequisitions();
                objRequesition.Id = intRequesitionId;
                objRequesition.Customerguid = CustomerGuid;
                
                if (LicenseGuid == "")
                    objRequesition.Licenseguid = "";
                else
                    objRequesition.Licenseguid = LicenseGuid;
                
                objRequesition.ReferenceNumber = Convert.ToString(txtReferenceNumber.Text);
                objRequesition.Requestdate = DateTime.Today;
                objRequesition.Approvedby = CSettings.SuppliesRequisitionApprovedBy;
                objRequesition.Approvaldate = DateTime.Today;
                objRequesition.RequestedBy = this.txtOrganizationName.Text;

                if (objRequesition.Exists(true) > 0)
                {
                    MessageBox.Show("There exists an invoice record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                //if (blnNewRequesition)
                if (objRequesition.Insert())
                {
                    intRequesitionId = objRequesition.Id;
                    this.RequisitionId = intRequesitionId;
                    return true;
                }
                else
                    return false;
                //else

                  //  objRequesition.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool IsValidRequisition()
        {
            try
            {
               // DateTime dteValidate;

                //if (!CustomerHasLicense)
                //{
                //    MessageBox.Show("This customer does not have a valid license. You can't accept his requisition.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return false;
                //}
                if (grvTransactionDetails.RowCount <= 1)
                {
                    MessageBox.Show("Please enter atleast one item","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return false;
                }

                for (int i = 0; i < grvTransactionDetails.RowCount-1;i++)
                {
                    if (!ValidateRow(i))
                        return false;
                }

                if (!CCommon.SetRequiredMessage(txtOrganizationName, "Please select a customer", mValidator, lblMsg))
                    return false;

                if (CustomerGuid == string.Empty)
                {
                    CCommon.SetMessage(txtOrganizationName, "Please select an a customer", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtReferenceNumber, "Reference number can not be empty", mValidator, lblMsg))
                    return false;
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool SaveRequisitionDetail()
        {
            try
            {
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount - 1; grRow++)
                {
                    int tran_id = 0;
                    bool blnNewReqDetail = false;
                    if (!ValidateRow(grRow)) break;
                    CSuppliesRequisitionDetails objReqDetail = new CSuppliesRequisitionDetails();
                    if (Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value) == 0)
                    {
                        blnNewReqDetail = true;
                        tran_id = 0;
                    }
                    else
                    {
                        blnNewReqDetail = false;
                        tran_id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                    }

                    objReqDetail.Id = tran_id;
                    objReqDetail.Suppliesrequisitionguid = CSuppliesRequisitions.GetTableRowGuid(intRequesitionId);
                    objReqDetail.Itemguid = grvTransactionDetails.Rows[grRow].Cells["colReqItemGuid"].Value.ToString();
                    objReqDetail.Requestedquantity = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colApprovedQuantity"].Value);
                    objReqDetail.Approvedquantity = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colApprovedQuantity"].Value);

                    if (blnNewReqDetail)
                    {
                        if (objReqDetail.Exists(true) <= 0)
                        {
                            objReqDetail.Insert();
                            grvTransactionDetails.Rows[grRow].Cells["colId"].Value = objReqDetail.Id;
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This item is already in the requesition! ";

                    }
                    else
                    {
                        if (objReqDetail.Exists(false) <= 0)
                        {
                            objReqDetail.Id = Convert.ToInt32(tran_id.ToString());
                            objReqDetail.Update();
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This item is already in the requesition! ";
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool ValidateRow(int grRow)
        {
            try
            {
                decimal dcmValue;

                //if (!HasTheRequiredProfessionalLevel(grvTransactionDetails.Rows[grRow].Cells["colReqItemGuid"].Value.ToString(), LicenseGuid))
                //{
                //    grvTransactionDetails.Rows[grRow].ErrorText = "This item can not be sold to a customer with a druggist license.";
                //    return false;
                //}
                
                dcmValue = decimal.Zero;
                if (grvTransactionDetails.Rows[grRow].Cells["colApprovedQuantity"].Value == null)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The approved quantity Can Not Be Empty";
                    return false;
                }
                if (!decimal.TryParse(grvTransactionDetails.Rows[grRow].Cells["colApprovedQuantity"].Value.ToString(), out dcmValue))
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "Quantity must be numeric";
                    return false;
                }
                if (dcmValue <= 0)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "Quantity must be greather than 0";
                    return false;
                }
                
                grvTransactionDetails.Rows[grRow].ErrorText = null;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void FillRequisitonDetailGrid(string Requisitionguid)
        {
            try
            {

                CSuppliesRequisitionDetails objReqDetails = new CSuppliesRequisitionDetails();

                ArrayList ar = new ArrayList(objReqDetails.GetList(Requisitionguid));

                grvTransactionDetails.Rows.Clear();
                if (ar.Count <= 0) return;

                foreach (CSuppliesRequisitionDetails RequesitionDetail in ar)
                {
                    grvTransactionDetails.Rows.Add(new string[] {RequesitionDetail.Id.ToString(), 
                                                                    RequesitionDetail.Itemguid.ToString(),
                                                                    RequesitionDetail.Suppliesrequisitionguid.ToString(),
                                                                    RequesitionDetail.BrandName.ToString(),                                        
                                                            RequesitionDetail.Unit.ToString(),
                                                            RequesitionDetail.Requestedquantity.ToString(),                                                            
                                                            RequesitionDetail.Approvedquantity.ToString()
                    });


                }
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
                if (ar.Count <= 0) return;

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
        private bool HasTheRequiredProfessionalLevel(string Itemguid, string Licenseguid)
        {
            try
            {

                bool hasTheRequiredProfessionalLevel = false;

                if (CItems.GetRequiredProfessionalLevel(Itemguid) == (int)CCommon.ProfessionalLevel.Pharmacist)
                {
                    if (CLicenses.GetLicenseProfessionalLevel(Licenseguid) == (int)CCommon.ProfessionalLevel.Pharmacist)
                        hasTheRequiredProfessionalLevel = true;
                }
                else
                    hasTheRequiredProfessionalLevel = true;

                return hasTheRequiredProfessionalLevel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void FillGridWithNewItem(string Requisitionguid, string Itemguid, string Licenseguid)
        {
            try
            {
                ListViewItem itm = lvwItems.SelectedItems[0];

                //if (HasTheRequiredProfessionalLevel(Itemguid, Licenseguid))
                //{
                    grvTransactionDetails.Rows.Add(new string[] { intReqDetailId.ToString(), 
                                                                    Itemguid.ToString(),
                                                                    Requisitionguid.ToString(),
                                                                    itm.SubItems[colItemBrandName.Index].Text,                                        
                                                                    itm.SubItems[colItemUnit.Index].Text,
                                                                            "",                                                            
                                                                            ""
                    });
                //}
                //else
                //    MessageBox.Show("This item cannot be sold to a customer with a druggist license.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void ShowRequisition()
        {
            try
            {
                DataTable dt = new DataTable();
                rptRequisition rpt = new rptRequisition();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = "SELECT   TOP (100) PERCENT tblSuppliesRequisitions.Id, tblSuppliesRequisitions.TableRowGuid, ";
                strSQL = strSQL + " 				tblItems.Measurement, tblItems.BrandName, tblItems.GenericName,  ";
                strSQL = strSQL + "                 tblItems.DosageFormGuid, tblItems.Strength, tblUnitOfMeasurements.Name AS UnitName,  ";
                strSQL = strSQL + "                 tblCustomers.Name AS CustomerName, tblSuppliesRequisitions.CustomerGuid,  ";
                strSQL = strSQL + "                 IsNull(tblCustomers.MailingAddress,'') + ' Tel: ' + IsNull(tblCustomers.Tel1,'') AS MailingAddress, tblCustomers.email, tblCustomers.Tel2,  ";
                strSQL = strSQL + " 				tblCustomers.Tel1, tblCustomers.Fax,  ";
                strSQL = strSQL + "                 'Tel: ' + tblCustomers.Tel1 + ', Fax: ' + tblCustomers.Fax + ', Email: ' + tblCustomers.email AS Address1,  ";
                strSQL = strSQL + "                 tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS UnitOfMeasurement,  ";
                strSQL = strSQL + "                 tblItems.BrandName + ' (' + tblItems.GenericName + ') ' + tblItems.Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.Name AS ItemDescription,  ";
                strSQL = strSQL + "                 tblSuppliesRequisitions.ReferenceNumber, tblSuppliesRequisitions.RequestedBy, tblSuppliesRequisitions.RequestDate,  ";
                strSQL = strSQL + "                 tblSuppliesRequisitions.ApprovedBy, tblSuppliesRequisitions.ApprovalDate,  ";
                strSQL = strSQL + "                 tblSuppliesRequisitions.CheckedBy, tblSuppliesRequisitions.CheckedDate,  ";
                strSQL = strSQL + "                 tblSuppliesRequisitionDetails.Id as DetailId, tblSuppliesRequisitionDetails.TableRowGuid as DetailGuid, tblLicenses.LicenseNumber, tblLicenses.FirstName + ' ' + tblLicenses.FatherName + ' ' + tblLicenses.GrandName As RequestedByFromLicense, ";
                strSQL = strSQL + "                 tblSuppliesRequisitionDetails.RequestedQuantity, tblSuppliesRequisitionDetails.ApprovedQuantity ";
                strSQL = strSQL + " FROM      tblSuppliesRequisitions INNER JOIN tblSuppliesRequisitionDetails  ";
                strSQL = strSQL + " 				ON tblSuppliesRequisitions.TableRowGuid = tblSuppliesRequisitionDetails.SuppliesRequisitionGuid ";
                strSQL = strSQL + " 			INNER JOIN tblItems ";
                strSQL = strSQL + " 				ON tblSuppliesRequisitionDetails.ItemGuid = tblItems.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblUnitOfMeasurements ";
                strSQL = strSQL + " 				ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblDosageForms ";
                strSQL = strSQL + " 				ON tblItems.DosageFormGuid = tblDosageForms.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblCustomers  ";
                strSQL = strSQL + " 				ON tblSuppliesRequisitions.CustomerGuid = tblCustomers.TableRowGuid  ";
                strSQL = strSQL + " 			LEFT OUTER JOIN tblLicenses  "; // Don't forget to change the left to inner
                strSQL = strSQL + " 				ON tblLicenses.TableRowGuid = tblSuppliesRequisitions.LicenseGuid  ";
                strSQL = strSQL + " Where tblSuppliesRequisitions.TableRowGuid = '" + CSuppliesRequisitions.GetTableRowGuid(intRequesitionId) + "' ";
                strSQL = strSQL + " Order By ItemDescription ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Clients Drug and Medical Supplies Requistion";
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
        private void ResizeControls()
        {
            try
            {
                // Title label
                this.lblTitle.Width = this.Width + 1;

                // Line just under the title label
                this.line3.Width = this.lblTitle.Width;

                // Main toolbar
                //this.panelToolBar.Width = this.lblTitle.Width - this.panelToolBar.Left;
                this.grpDataEntry.Width = this.lblTitle.Width - this.grpDataEntry.Left - 24;

                // Detail Groupbox and Gridview
                this.grpDetail.Height = this.Height - this.grpDetail.Top - 65;
                this.grpDetail.Width = this.lblTitle.Width - this.grpDetail.Left - 24;
                this.grvTransactionDetails.Width = this.grpDetail.Width - 12;
                this.grvTransactionDetails.Height = this.grpDetail.Height - this.grvTransactionDetails.Top - 12;

                // Items Groupbox and listview
                this.grpItems.Height = this.Height - this.grpItems.Top - 65;
                //this.lvwItems.Width = this.grpItems.Width - this.lvwItems.Left - 12;
                this.lvwItems.Height = this.grpItems.Height - this.lvwItems.Top - 12;
                //this.albar.Height = this.grpItems.Height - this.albar.Top;
                this.indexBar.Height = this.lvwItems.Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }
        private string IsRequisitionTurnedToInvoice(string SuppliesRequisitionguid)
        {
            try
            {
                DataTable dt = new DataTable();
                CInvoices invoice = new CInvoices();

                dt = invoice.GetRecord(SuppliesRequisitionguid);

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
        private void AdjsutRequisitionForEdit(string SuppliesRequisitionguid)
        {
            try
            {
                string invoiceNumber = IsRequisitionTurnedToInvoice(SuppliesRequisitionguid);
                if (invoiceNumber != string.Empty)
                {
                    this.txtInvoiceNumber.Text = invoiceNumber;
                    this.txtOrganizationName.ReadOnly = true;
                    this.btnFindCustormerDataEntry.Enabled = false;
                    this.txtReferenceNumber.ReadOnly = true;
                    cboItemCategory.Enabled = false;
                    indexBar.Enabled = false;
                    lvwItems.Enabled = false;
                    btnAddItem.Enabled = false;
                    this.grvTransactionDetails.ReadOnly = true;
                }
                else
                {
                    this.txtInvoiceNumber.Text = string.Empty;
                    this.txtOrganizationName.ReadOnly = false;
                    this.btnFindCustormerDataEntry.Enabled = true;
                    this.txtReferenceNumber.ReadOnly = false;
                    cboItemCategory.Enabled = true;
                    indexBar.Enabled = true;
                    lvwItems.Enabled = true;
                    btnAddItem.Enabled = true;
                    this.grvTransactionDetails.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool GetCustomerLicense(string Customerguid)
        {
            try
            {
                bool HaveLicense = false;
                CLicenses objLicense = new CLicenses();

                ArrayList ar = new ArrayList(objLicense.GetListActive(Customerguid));

                if (ar.Count <= 0)
                {

                    lblLicense.Text = "Do not accept a requisition from this customer, because there is no active license present for the customer. ";
                    lblStatus.Text = "Can not accept a requisition from this customer because there is no active license present for the customer. ";
                    return false;
                }

                foreach (CLicenses license in ar)
                {
                    if (DateTime.Today >= license.Validfrom && DateTime.Today <= license.Validto)
                    {
                        lblLicense.Text = "Licensee: " + license.Firstname + " " + license.Fathername + " " + license.Grandname;
                        lblLicense.Text += ";  License #: " + license.Licensenumber;
                        lblLicense.Text += ";  Level: " + license.LevelName;
                        HaveLicense = true;
                        LicenseGuid = license.Tablerowguid;
                        break;
                    }
                }

                if(HaveLicense == false)
                {
                    lblLicense.Text = "Do not accept a requisition from this customer, because there is no active license present for the customer. ";
                    lblStatus.Text = "Can not accept a requisition from this customer because there is no active license present for the customer. ";
                   
                }
                return HaveLicense;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindLicenses(string Licenseguid)
        {
            try
            {
                CLicenses license = new CLicenses();
                DataTable dt = new DataTable();

                license.Id = CLicenses.GetTableRowId(Licenseguid);
                dt = license.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    lblLicense.Text = "Licensee: " + license.Firstname + " " + license.Fathername + " " + license.Grandname;
                    lblLicense.Text += ",  " + license.LevelName;
                    lblLicense.Text += ";  License #: " + license.Licensenumber;

                    return true;
                }
                else
                {
                    lblLicense.Text = "Do not accept a requisition from this customer, because there is no active license present for the customer. ";
                    lblStatus.Text = "Can not accept a requisition from this customer because there is no active license present for the customer. ";
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void frmRequesition_Load(object sender, EventArgs e)
        {
            try
            {
                //txtApprovedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                CCommon.FillComboBox(cboItemCategory, "Select TableRowGuid,Name from tblMakeOrganizations Order by Name ", "TableRowGuid", "Name", false);
                NewRequesition();
                btnFindCustormerDataEntry_Click(btnFindCustormerDataEntry, new EventArgs());

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
                NewRequesition();
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
                if (SaveRequesition())
                    MessageBox.Show("Data Saved Successfully", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (intRequesitionId != 0)
                    SaveRequisitionDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwTransactions_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (intRequesitionId != 0)
                    SaveRequisitionDetail();
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
                if (txtInvoiceNumber.Text.Length > 0) return;

                for (int grRow = 0; grRow < grvTransactionDetails.RowCount; grRow++)
                {
                    if (grvTransactionDetails.SelectedRows.Contains(grvTransactionDetails.Rows[grRow]))
                    {
                        if (MessageBox.Show("Are you sure to delete the " + Convert.ToString(grRow + 1) + " row?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int intId = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                            if (intId != 0)
                            {
                                CSuppliesRequisitionDetails objReqDetail = new CSuppliesRequisitionDetails();
                                objReqDetail.Id = intId;
                                objReqDetail.Delete();
                            }
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
                if (txtInvoiceNumber.Text.Length > 0) return;

                if (MessageBox.Show("Are you sure to delete the Requisition?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CSuppliesRequisitionDetails objReqDetail = new CSuppliesRequisitionDetails();
                    CSuppliesRequisitions objReq = new CSuppliesRequisitions();
                    objReq.Id = intRequesitionId;
                    objReqDetail.Suppliesrequisitionguid = CSuppliesRequisitions.GetTableRowGuid(intRequesitionId);
                    if (!objReqDetail.CheckHasChildren())
                    {
                        objReq.Delete();
                        NewRequesition();
                    }
                    else
                        MessageBox.Show("The requesition can not be deleted. Please delete the items first.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFindCustormer_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCustomerFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnFindCustormerDataEntry_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCustomer();
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
                if (childSelector.blnSelected)
                {
                    CustomerGuid = childSelector.Customerguid;
                    txtOrganizationName.Text = childSelector.OrganizationName;
                    //CustomerHasLicense = GetCustomerLicense(CustomerGuid);
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

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ItemGuid != string.Empty)
                    FillGridWithNewItem(CSuppliesRequisitions.GetTableRowGuid(intRequesitionId),ItemGuid,LicenseGuid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwItems_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem itm;
                itm = lvwItems.SelectedItems[0];
                ItemGuid = itm.SubItems[colItemId.Index].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwItems_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ItemGuid != string.Empty)
                    FillGridWithNewItem(CSuppliesRequisitions.GetTableRowGuid(intRequesitionId), ItemGuid, LicenseGuid);
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
                            CSuppliesRequisitionDetails objReqDetail = new CSuppliesRequisitionDetails();
                            objReqDetail.Id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                            objReqDetail.Delete();
                            grvTransactionDetails.Rows[grRow].Visible = false;
                        }
                        else
                            e.Cancel = true;
                    }

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
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                ShowRequisition();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmRequesition_Resize(object sender, EventArgs e)
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
        private void indexBar_LetterListener(object sender, EventArgs e)
        {
            try
            {
                string strCriteria = "";
                string value = value = ((IndexBar.IndexBarEventArgs)e).SelectedLetter;
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
                    strCriteria = strCriteria + " And MakeOrganizationGuid = '" + CCommon.GetItemData(cboItemCategory) + "' ";

                FillItemsList(strCriteria);
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
                frmSelectCustomer frmCus = new frmSelectCustomer();
                frmCus.ShowDialog();
                if (frmCus.bCancel == true) return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCustomerFilter()
        {
            try
            {
                if (txtOrganizationName.Text != "")
                {
                    CSuppliesRequisitions objCustomer = new CSuppliesRequisitions();
                    objCustomer.OrganizationName = txtOrganizationName.Text + "%";
                    ArrayList ar = new ArrayList(objCustomer.GetCustomerByName());
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        childSelector1 = new frmCustomerSelector();
                        childSelector1.Width = txtOrganizationName.Width;
                        childSelector1.lvwCustomer.Items.Clear();
                        foreach (CSuppliesRequisitions Customer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Customer.Customerguid.ToString(),
                            Customer.OrganizationName.ToString()});
                            childSelector1.lvwCustomer.Items.Add(itmX);
                        }
                        //childSelector.Owner = this;
                        //childSelector.x = 420;
                        //childSelector.y = 150;
                        //childSelector.ShowDialog();

                        //PopupWindowHelper popupHelper1 = new PopupWindowHelper();
                        //popupHelper1.AssignHandle(this.Handle);
                        Point location = this.PointToScreen(new Point(this.grpDataEntry.Left + this.txtOrganizationName.Left, this.grpItems.Top + this.txtOrganizationName.Bottom));
                        popupHelper1.ShowPopup(this, childSelector1, location);

                        if (childSelector1.blnSelected)
                        {
                            CustomerGuidSearch = childSelector1.Customerguid;
                            txtOrganizationName.Text = childSelector1.OrganizationName;
                        }
                    }
                    else
                    {
                        CSuppliesRequisitions Customer = (CSuppliesRequisitions)ar[0];
                        CustomerGuidSearch = Customer.Customerguid;
                        txtOrganizationName.Text = Customer.OrganizationName;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SearchCustomerFilter();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void popupHelper1_PopupClosed(object sender, PopupClosedEventArgs e)
        {
            try
            {
                if (childSelector1.blnSelected)
                {
                    CustomerGuidSearch = childSelector1.Customerguid;
                    txtOrganizationName.Text = childSelector1.OrganizationName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void popupHelper1_PopupCancel(object sender, PopupCancelEventArgs e)
        {
            //Console.WriteLine("Popup Cancel, mouse clicked at {0}", e.CursorLocation);
        }
        private void CellEndEditTasks(DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGridViewTextBoxCell gvwTextBoxCell;
                string strRequestedQuantity = string.Empty;

                if (e.ColumnIndex == 5)
                {
                    strRequestedQuantity = grvTransactionDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    grvTransactionDetails.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = strRequestedQuantity;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvTransactionDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    CellEndEditTasks(e);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void SearchCustomer()
        {
            try
            {
                if (txtOrganizationName.Text != "")
                {
                    CSuppliesRequisitions objCustomer = new CSuppliesRequisitions();
                        objCustomer.OrganizationName = txtOrganizationName.Text + "%";
                    ArrayList ar = new ArrayList(objCustomer.GetCustomerByName());
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        childSelector = new frmCustomerSelector();
                        childSelector.Width = txtOrganizationName.Width;
                        childSelector.lvwCustomer.Items.Clear();
                        foreach (CSuppliesRequisitions Customer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Customer.Customerguid.ToString(),
                            Customer.OrganizationName.ToString()});
                            childSelector.lvwCustomer.Items.Add(itmX);
                        }
                        //childSelector.Owner = this;
                        //childSelector.x = 900;
                        //childSelector.y = 150;
                        //childSelector.ShowDialog();

                        //PopupWindowHelper popupHelper = new PopupWindowHelper();
                        //popupHelper.AssignHandle(this.Handle);
                        Point location = this.PointToScreen(new Point(this.grpDataEntry.Left + this.txtOrganizationName.Left, this.grpDataEntry.Top + this.txtOrganizationName.Bottom));
                        popupHelper.ShowPopup(this, childSelector, location);

                        if (childSelector.blnSelected)
                        {
                            CustomerGuid = childSelector.Customerguid;
                            txtOrganizationName.Text = childSelector.OrganizationName;
                            this.CustomerGuid2 = CustomerGuid;
                            //CustomerHasLicense = GetCustomerLicense(CustomerGuid);
                        }
                    }
                    else
                    {
                        CSuppliesRequisitions Customer = (CSuppliesRequisitions)ar[0];
                        CustomerGuid = Customer.Customerguid;
                       // CustomerHasLicense = true;
                        txtOrganizationName.Text = Customer.OrganizationName;
                        //CustomerHasLicense = GetCustomerLicense(CustomerGuid);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtOrganizationName_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SearchCustomer();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void btnPrepareInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                bool passed = false;
                //Setting information              
                if (SaveRequesition())
                {
                    if (SaveRequisitionDetail())
                    {
                        strSuppliesRequisitionReferenceNumber = this.txtReferenceNumber.Text;
                        strSuppliesRequisitionGuid = CSuppliesRequisitions.GetTableRowGuid(intRequesitionId);                        
                        //passed = true;
                    }
                }               
                //if (passed)
                //    this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void cboItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void GetItemCode()
        {

            try
            {
                string Itemcategoryguid = "-1";
                string Itemcode = "";
                string Itemname = "";


                //if (cboItemCategoryFilter.SelectedIndex > 0)
                //    Itemcategoryguid = CCommon.GetItemData(cboItemCategoryFilter);
                if (txtItemName.Text != string.Empty)
                    Itemname = txtItemName.Text;
                if (txtItemcode.Text != string.Empty)
                    Itemcode = txtItemcode.Text;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT TOP (100) PERCENT dbo.tblItems.Id, dbo.tblItems.TableRowGuid, dbo.tblItems.MakeOrganizationGuid, dbo.tblItems.ManufacturerGuid, dbo.tblItems.GenericName,  RequestedQuantity,      ";
                strSQL = strSQL + "                 dbo.tblItems.UnitOfMeasurementGuid, dbo.tblItems.Measurement, dbo.tblItems.Strength,dbo.tblItems.ItemCode,   ";
                strSQL = strSQL + "                 dbo.tblItems.ShelfLife, dbo.tblItems.ReorderLevel, dbo.tblItems.SellableBactchGuid, dbo.tblItems.MonthlySalesForecast,   ";
                strSQL = strSQL + "                 dbo.tblItems.ProfitMargin, dbo.tblManufacturers.Name AS Manufacturer, dbo.tblMakeOrganizations.Name AS ItemCategory,   ";
                strSQL = strSQL + "                 dbo.tblUnitOfMeasurements.Name AS UnitOfMeasurement, ExpiryDate, ItemCode, ";
                strSQL = strSQL + "                  SalePrice, ";
                strSQL = strSQL + "                 QuantityAtHand.Balance AS QuantityAtHand, ";
                strSQL = strSQL + "                 (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems ";
                strSQL = strSQL + "                 inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
                strSQL = strSQL + "                 inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
                strSQL = strSQL + "                 inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
                strSQL = strSQL + "                 inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
                strSQL = strSQL + "                  inner join tblSuppliesRequisitionDetails on tblSuppliesRequisitionDetails.ItemGuid =tblItems.TableRowGuid  ";
                strSQL = strSQL + "                  inner join tblSuppliesRequisitions on tblSuppliesRequisitions.TableRowGuid =tblSuppliesRequisitionDetails.SuppliesRequisitionGuid    ";             
                strSQL = strSQL + "                  INNER JOIN dbo.tblManufacturers ON dbo.tblItems.ManufacturerGuid = dbo.tblManufacturers.TableRowGuid LEFT OUTER JOIN  ";
                strSQL = strSQL + "                 dbo.tblUnitOfMeasurements ON dbo.tblItems.UnitOfMeasurementGuid = dbo.tblUnitOfMeasurements.TableRowGuid ";

                strSQL = strSQL + "                 LEFT OUTER JOIN ";

                strSQL = strSQL + "                 (SELECT	tblBatchs.ItemGuid, Balance = SUM(Received) -	SUM(Issued) - SUM(Damaged) - SUM(Recalled),Min(ExpiryDate) As ExpiryDate,SalePrice  ";
                strSQL = strSQL + "                  FROM tblBatchs LEFT OUTER JOIN ";
                strSQL = strSQL + "                      (SELECT BatchGuid, ";
                strSQL = strSQL + "                              ISNULL(ReceivedQuantity, 0) AS Received,  ";
                strSQL = strSQL + "                              ISNULL(IssuedQuantity, 0) AS Issued,  ";
                strSQL = strSQL + "                              ISNULL(DamagedQuantity, 0) AS Damaged,  ";
                strSQL = strSQL + "                              ISNULL(RecalledQuantity, 0) AS Recalled ";
                strSQL = strSQL + "                      FROM StockUptoDateBalance(GetDate())) AS Balance ";
                strSQL = strSQL + "                      ON tblBatchs.TableRowGuid = Balance.BatchGuid ";
                strSQL = strSQL + "                  Group by tblBatchs.ItemGuid,SalePrice) QuantityAtHand ";
                strSQL = strSQL + "                  ON dbo.tblItems.TableRowGuid = QuantityAtHand.ItemGuid  ";
                strSQL = strSQL + " WHERE (1=1) AND QuantityAtHand.Balance > 0 ";
                //strSQL = strSQL + " AND  dbo.tblItems.TableRowGuid ='"+ TableRowGuid+"'";

                //if (Manufacturerguid != "" && Manufacturerguid != "0" && Manufacturerguid != "-1") strSQL = strSQL + " AND (ManufacturerGuid = '" + Manufacturerguid + "') ";
                if (Itemcategoryguid != "-1") strSQL = strSQL + " AND (MakeOrganizationGuid = '" + Itemcategoryguid + "') ";
                if (Itemname != "") strSQL = strSQL + " AND (tblItems.BrandName like '" + Itemname + "%') ";
                if (Itemcode != "") strSQL = strSQL + " AND (tblItems.ItemCode like '" + Itemcode + "%') ";
                strSQL = strSQL + " Order By Manufacturer, BrandName ";
                DataTable dt = new DataTable();
                dt = CCommon.GetRecords(strSQL);
                this.lvwItems.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {

                    ListViewItem itmX = new ListViewItem(new string[] {   row["ItemCategory"].ToString(),
                                                                          row["BrandName"].ToString(),
                                                                          row["ItemCode"].ToString(),
                                                                          row["QuantityAtHand"].ToString(),
                                                                          Convert.ToDecimal(row["SalePrice"]).ToString(CSettings.CurrencyFormat)});
                    this.lvwItems.Items.Add(itmX);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            lvwItems.Items.Clear();
            GetItemCode();
        }
        private void lvwItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReferenceNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    lvwItems.Items.Clear();
                    GetItemCode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtItemcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    lvwItems.Items.Clear();
                    GetItemCode();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvTransactionDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void indexBar_Load(object sender, EventArgs e)
        {

        }
    }
}