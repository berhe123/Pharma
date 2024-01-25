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
    public partial class frmProforma : Form
    {
        private const string DialogCaption = "Proforma";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector childSelector = null;

        private PopupWindowHelper popupHelper1 = null;
        private frmCustomerSelector childSelector1 = null;

        private int intProformaId = 0;
        private bool blnNewProforma = false;
        private int intProformaDetailId = 0;
        private string CustomerGuidSearch = string.Empty;
        private string CustomerGuid = string.Empty;
        private string ItemGuid = string.Empty;

        public frmProforma()
        {
            InitializeComponent();

            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

            popupHelper1 = new PopupWindowHelper();
            popupHelper1.PopupClosed += new PopupClosedEventHandler(popupHelper1_PopupClosed);
            popupHelper1.PopupCancel += new PopupCancelEventHandler(popupHelper1_PopupCancel);

        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            popupHelper.AssignHandle(this.Handle);
            popupHelper1.AssignHandle(this.Handle);
        }
        private void NewProforma()
        {
            try
            {
                blnNewProforma = true;
                intProformaId = 0;
                txtOrganizationName.Text = "";
                txtReferenceNumber.Text = "";
                txtRequestedBy.Text = "";
                txtApprovedBy.Text = CSettings.ProformaApprovedBy;
                txtApprovedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProformaDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                grvTransactionDetails.Rows.Clear();
                lvwItems.Items.Clear();
                AdjsutProformaForEdit("0");
                int maxReferenceNumber = CProformas.GetMaxReferenceNumber();
                this.txtReferenceNumber.Text = "0" + (maxReferenceNumber + 1).ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillProformaList(string strCriteria)
        {
            try
            {

                CProformas objProforma = new CProformas();

                ArrayList ar = new ArrayList(objProforma.GetList(strCriteria));
                this.lvwTransactions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CProformas Proforma in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Proforma.Id.ToString(), 
                                                                                      Proforma.OrganizationName.ToString(), 
                                                                                      Proforma.ReferenceNumber.ToString(), 
                                                                                      Proforma.Proformadate.ToString(CSettings.DateFormat),
                                                                                      Proforma.Approvedby.ToString(),
                                                                                      Proforma.Approvaldate.ToString(CSettings.DateFormat),                    
                                                                                      Proforma.RequestedBy.ToString(),
                                                                                      Proforma.Customerguid.ToString()});
                                                                                            
                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   
        private bool SaveProforma()
        {
            try
            {

                if (!IsValidProforma()) return false;

                CProformas objProforma = new CProformas();

                objProforma.Id = intProformaId;
                objProforma.Customerguid = CustomerGuid;
                objProforma.ReferenceNumber = Convert.ToString(txtReferenceNumber.Text);
                objProforma.Proformadate = Convert.ToDateTime(txtProformaDate.Text, CSettings.Culture); ;
                objProforma.RequestedBy = Convert.ToString(txtRequestedBy.Text);
                objProforma.Approvaldate = Convert.ToDateTime(txtApprovedDate.Text, CSettings.Culture);
                objProforma.Approvedby = Convert.ToString(txtApprovedBy.Text);
               
                if (blnNewProforma)
                    objProforma.Insert();
                else
                    objProforma.Update();

                intProformaId = objProforma.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool IsValidProforma()
        {
            try
            {
                DateTime dteValidate;

                if (!CCommon.SetRequiredMessage(txtOrganizationName, "Please select a customer", mValidator, lblMsg))
                    return false;

                if (CustomerGuid == string.Empty)
                {
                    CCommon.SetMessage(txtOrganizationName, "Please select an a customer", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtReferenceNumber, "Reference number can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtRequestedBy, "Requested by can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtProformaDate, "Requested date can not be Empty. Please a valid date.", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtProformaDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtProformaDate, "Please enter proforma date in a correct format", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtApprovedDate, "Approved date can not be empty. Please enter a valid date.", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtApprovedDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtApprovedDate, "Please enter approved date in a correct format", mValidator, lblMsg);
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
        private void SaveProformaDetail()
        {
            try
            {
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount - 1; grRow++)
                {
                    int tran_id = 0;
                    bool blnNewProformaDetail = false;
                    if (!ValidateRow(grRow)) break;
                    CProformaDetails objProformaDetail = new CProformaDetails();
                    if (Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value) == 0)
                    {
                        blnNewProformaDetail = true;
                        tran_id = 0;
                    }
                    else
                    {
                        blnNewProformaDetail = false;
                        tran_id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                    }

                    objProformaDetail.Id = tran_id;
                    objProformaDetail.Proformaguid = CProformas.GetTableRowGuid(intProformaId);
                    objProformaDetail.Itemguid = grvTransactionDetails.Rows[grRow].Cells["colProformaItemGuid"].Value.ToString();
                    objProformaDetail.Unitprice = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colUnitPrice"].Value);
                    objProformaDetail.Quantity = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value);

                    if (blnNewProformaDetail)
                    {
                        if (objProformaDetail.Exists(true) <= 0)
                        {
                            objProformaDetail.Insert();
                            grvTransactionDetails.Rows[grRow].Cells["colId"].Value = objProformaDetail.Id;
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This item is already in the Proforma! ";

                    }
                    else
                    {
                        if (objProformaDetail.Exists(false) <= 0)
                        {
                            objProformaDetail.Id = Convert.ToInt32(tran_id.ToString());
                            objProformaDetail.Update();
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This item is already in the Proforma! ";
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

                if (grvTransactionDetails.Rows[grRow].Cells["colUnitPrice"].Value == null)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The unit price can not be empty";
                    return false;
                }
                if (!decimal.TryParse(grvTransactionDetails.Rows[grRow].Cells["colUnitPrice"].Value.ToString(), out dcmValue))
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The unit price must be numeric";
                    return false;
                }
                if (dcmValue <= 0)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The unit price must be greather than 0";
                    return false;
                }
                dcmValue = decimal.Zero;
                if (grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value == null)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The quantity Can Not Be Empty";
                    return false;
                }
                if (!decimal.TryParse(grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value.ToString(), out dcmValue))
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The quantity must be numeric";
                    return false;
                }
                if (dcmValue <= 0)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The quantity must be greather than 0";
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
        private void FillProformaDetailGrid(string Proformaguid)
        {
            try
            {

                CProformaDetails objProformaDetails = new CProformaDetails();

                ArrayList ar = new ArrayList(objProformaDetails.GetList(Proformaguid));

                grvTransactionDetails.Rows.Clear();
                if (ar.Count <= 0) return;

                foreach (CProformaDetails ProformaDetail in ar)
                {
                    grvTransactionDetails.Rows.Add(new string[] { ProformaDetail.Id.ToString(), 
                                                                    ProformaDetail.Itemguid.ToString(),
                                                                    ProformaDetail.Proformaguid.ToString(),
                                                                    ProformaDetail.BrandName.ToString(),
                                                                    ProformaDetail.Unitprice.ToString(),                                                            
                                                                    ProformaDetail.Quantity.ToString(),
                                                                    "0.00"
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

                CProformaDetails objProformaDetail = new CProformaDetails();

                ArrayList ar = new ArrayList(objProformaDetail.GetListItems(strCriteria));
                this.lvwItems.Items.Clear();
                if (ar.Count <= 0) return;

                foreach (CProformaDetails Proformadetail in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Proformadetail.Itemguid.ToString(), 
                                                                                      Proformadetail.BrandName.ToString(),
                                                                                      Proformadetail.Unitprice.ToString()});

                    this.lvwItems.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillGridWithNewItem(string Proformaguid, string Itemguid)
        {
            try
            {
                ListViewItem itm = lvwItems.SelectedItems[0];

                grvTransactionDetails.Rows.Add(new string[] { intProformaDetailId.ToString(), 
                                                                Itemguid.ToString(),
                                                                Proformaguid.ToString(),
                                                                itm.SubItems[colItemBrandName.Index].Text,
                                                                        "",                                        
                                                                itm.SubItems[colItemUnitPrice.Index].Text,                                                            
                                                                        ""
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }      
        private void ShowProforma()
        {
            try
            {
                DataTable dt = new DataTable();
                rptProforma rpt = new rptProforma();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = "SELECT   TOP (100) PERCENT tblProformas.Id, tblProformas.TableRowGuid, ";
                strSQL = strSQL + " 				tblItems.Measurement, tblItems.BrandName, tblItems.GenericName,  ";
                strSQL = strSQL + "                 tblItems.DosageFormGuid, tblItems.Strength, tblUnitOfMeasurements.Name AS UnitName,  ";
                strSQL = strSQL + "                 tblCustomers.Name AS CustomerName, tblProformas.CustomerGuid,  ";
                strSQL = strSQL + "                 IsNull(tblCustomers.MailingAddress,'') + ' Tel: ' + IsNull(tblCustomers.Tel1,'') AS MailingAddress, tblCustomers.email, tblCustomers.Tel2,  ";
                strSQL = strSQL + " 				tblCustomers.Tel1, tblCustomers.Fax,  ";
                strSQL = strSQL + "                 'Tel: ' + tblCustomers.Tel1 + ', Fax: ' + tblCustomers.Fax + ', Email: ' + tblCustomers.email AS Address1,  ";
                strSQL = strSQL + "                 tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS UnitOfMeasurement,  ";
                strSQL = strSQL + "                 tblItems.BrandName + ' (' + tblItems.GenericName + ') ' + tblItems.Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.Name AS ItemDescription,  ";
                strSQL = strSQL + "                 tblProformas.ReferenceNumber, tblProformas.RequestedBy, tblProformas.ProformaDate,  ";
                strSQL = strSQL + "                 tblProformas.ApprovedBy, tblProformas.ApprovalDate,  ";
                strSQL = strSQL + "                 tblProformas.CheckedBy, tblProformas.CheckedDate,  ";
                strSQL = strSQL + "                 tblProformaDetails.Id as DetailId, tblProformaDetails.TableRowGuid as DetailGuid, tblLicenses.LicenseNumber, tblLicenses.FirstName + ' ' + tblLicenses.FatherName + ' ' + tblLicenses.GrandName As RequestedByFromLicense, ";
                strSQL = strSQL + "                 tblProformaDetails.Unitprice, tblProformaDetails.Quantity ";
                strSQL = strSQL + " FROM      tblProformas INNER JOIN tblProformaDetails  ";
                strSQL = strSQL + " 				ON tblProformas.TableRowGuid = tblProformaDetails.ProformaGuid ";
                strSQL = strSQL + " 			INNER JOIN tblItems ";
                strSQL = strSQL + " 				ON tblProformaDetails.ItemGuid = tblItems.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblUnitOfMeasurements ";
                strSQL = strSQL + " 				ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblDosageForms ";
                strSQL = strSQL + " 				ON tblItems.DosageFormGuid = tblDosageForms.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblCustomers  ";
                strSQL = strSQL + " 				ON tblProformas.CustomerGuid = tblCustomers.TableRowGuid  ";
                strSQL = strSQL + " 			LEFT OUTER JOIN tblLicenses  "; // Don't forget to change the left to inner
                strSQL = strSQL + " 				ON tblLicenses.TableRowGuid = tblProformas.LicenseGuid  ";
                strSQL = strSQL + " Where tblProformas.TableRowGuid = '" + CProformas.GetTableRowGuid(intProformaId) + "' ";
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
                this.panelToolBar.Width = this.lblTitle.Width - this.panelToolBar.Left;
                this.grpDataEntry.Width = this.lblTitle.Width - this.grpDataEntry.Left - 24;

                // Transactions listview
                this.lvwTransactions.Height = this.Height - this.lvwTransactions.Top - 65;

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

                //if (this.indexBar.Alignment == IndexBar.IndexBarAlignment.Vertical)
                //    this.indexBar.Height = this.lvwItems.Height;
                //else
                //    this.indexBar.Width = this.lvwItems.Width;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }
        private string IsProformaTurnedToInvoice(string Proformaguid)
        {
            try
            {
                DataTable dt = new DataTable();
                CInvoices invoice = new CInvoices();

                dt = invoice.GetRecord(Proformaguid);

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
        private void AdjsutProformaForEdit(string Proformaguid)
        {
            try
            {
                string invoiceNumber = IsProformaTurnedToInvoice(Proformaguid);
                if (invoiceNumber != string.Empty)
                {
                    this.txtInvoiceNumber.Text = invoiceNumber;
                    this.txtOrganizationName.ReadOnly = true;
                    this.btnFindCustormerDataEntry.Enabled = false;
                    this.txtRequestedBy.ReadOnly = true;
                    this.txtProformaDate.ReadOnly = true;
                    this.txtReferenceNumber.ReadOnly = true;
                    this.txtApprovedBy.ReadOnly = true;
                    this.txtApprovedDate.ReadOnly = true;
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
                    this.txtRequestedBy.ReadOnly = false;
                    this.txtProformaDate.ReadOnly = false;
                    this.txtReferenceNumber.ReadOnly = false;
                    this.txtApprovedBy.ReadOnly = false;
                    this.txtApprovedDate.ReadOnly = false;
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

        private void frmProforma_Load(object sender, EventArgs e)
        {
            try
            {
                txtProformaDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProformaDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProformaDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtApprovedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                CCommon.FillComboBox(cboItemCategory, "Select TableRowGuid,Name from tblItemCategories Order by Name ", "TableRowGuid", "Name");
                NewProforma();
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

                if (CustomerGuidSearch != "0" & CustomerGuidSearch != string.Empty & txtCustomerName.Text != "")
                    strCriteria = strCriteria + " And CustomerGuid = '" + CustomerGuidSearch + "' ";
                if (txtProformaDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtProformaDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And ProformaDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtProformaDateTo.Text != "")
                    if (DateTime.TryParseExact(txtProformaDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And ProformaDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
                FillProformaList(strCriteria);
                NewProforma();
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
                NewProforma();
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
                if (SaveProforma())
                    MessageBox.Show("Data Saved Successfully", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (intProformaId != 0)
                    SaveProformaDetail();
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
                if (intProformaId != 0)
                    SaveProformaDetail();
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
                                CProformaDetails objProformaDetail = new CProformaDetails();
                                objProformaDetail.Id = intId;
                                objProformaDetail.Delete();
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

                if (MessageBox.Show("Are you sure to delete the Proforma?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CProformaDetails objProformaDetail = new CProformaDetails();
                    CProformas objReq = new CProformas();
                    objReq.Id = intProformaId;
                    objProformaDetail.Proformaguid = CProformas.GetTableRowGuid(intProformaId);
                    if (!objProformaDetail.CheckHasChildren())
                    {
                        objReq.Delete();
                        lvwTransactions.Items.Remove(lvwTransactions.SelectedItems[0]);
                        NewProforma();
                    }
                    else
                        MessageBox.Show("The Proforma can not be deleted. Please delete the items first.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void lvwTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = new ListViewItem();

                if (lvwTransactions.SelectedItems == null) return;
                if (lvwTransactions.SelectedItems.Count <= 0) return;

                item = lvwTransactions.SelectedItems[0];
                blnNewProforma = false;
                intProformaId = Convert.ToInt32(item.SubItems[colProformaId.Index].Text);
                CustomerGuid = item.SubItems[colCustomerGuid.Index].Text;
                txtOrganizationName.Text = Convert.ToString(item.SubItems[colOrganizationName.Index].Text);
                txtReferenceNumber.Text = Convert.ToString(item.SubItems[colReferenceNumber.Index].Text);
                txtProformaDate.Text = Convert.ToString(item.SubItems[colProformaDate.Index].Text);
                txtRequestedBy.Text = Convert.ToString(item.SubItems[colRequestedBy.Index].Text);
                txtApprovedBy.Text = Convert.ToString(item.SubItems[colApprovedBy.Index].Text);
                txtApprovedDate.Text = Convert.ToString(item.SubItems[colApprovalDate.Index].Text);

                FillProformaDetailGrid(CProformas.GetTableRowGuid(intProformaId));
                AdjsutProformaForEdit(CProformas.GetTableRowGuid(intProformaId));
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
                    FillGridWithNewItem(CProformas.GetTableRowGuid(intProformaId),ItemGuid);
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
                    FillGridWithNewItem(CProformas.GetTableRowGuid(intProformaId), ItemGuid);
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
                            CProformaDetails objProformaDetail = new CProformaDetails();
                            objProformaDetail.Id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                            objProformaDetail.Delete();
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
                ShowProforma();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmProforma_Resize(object sender, EventArgs e)
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


                if (cboItemCategory.SelectedIndex != -1)
                    strCriteria = strCriteria + " And CategoryGuid = '" + CCommon.GetItemData(cboItemCategory) + "' ";

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
                this.txtCustomerName.Tag = frmCus.Customerguid.ToString();
                this.txtCustomerName.Text = frmCus.CustomerName.ToString();
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
                if (txtCustomerName.Text != "")
                {
                    CProformas objCustomer = new CProformas();
                    objCustomer.OrganizationName = txtCustomerName.Text + "%";
                    ArrayList ar = new ArrayList(objCustomer.GetCustomerByName());
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        childSelector1 = new frmCustomerSelector();
                        childSelector1.Width = txtCustomerName.Width;
                        childSelector1.lvwCustomer.Items.Clear();
                        foreach (CProformas Customer in ar)
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
                        Point location = this.PointToScreen(new Point(this.grpFilter.Left + this.txtCustomerName.Left, this.grpFilter.Top + this.txtCustomerName.Bottom));
                        popupHelper1.ShowPopup(this, childSelector1, location);

                        if (childSelector1.blnSelected)
                        {
                            CustomerGuidSearch = childSelector1.Customerguid;
                            txtCustomerName.Text = childSelector1.OrganizationName;
                        }
                    }
                    else
                    {
                        CProformas Customer = (CProformas)ar[0];
                        CustomerGuidSearch = Customer.Customerguid;
                        txtCustomerName.Text = Customer.OrganizationName;

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
                    txtCustomerName.Text = childSelector1.OrganizationName;
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
                //string strRequestedQuantity = string.Empty;

                //if (e.ColumnIndex == 5)
                //{
                //    strRequestedQuantity = grvTransactionDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //    grvTransactionDetails.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = strRequestedQuantity;
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grvTransactionDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CellEndEditTasks(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchCustomer()
        {
            try
            {
                if (txtOrganizationName.Text != "")
                {
                    CProformas objCustomer = new CProformas();
                    objCustomer.OrganizationName = txtOrganizationName.Text + "%";
                    ArrayList ar = new ArrayList(objCustomer.GetCustomerByName());
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        childSelector = new frmCustomerSelector();
                        childSelector.Width = txtOrganizationName.Width;
                        childSelector.lvwCustomer.Items.Clear();
                        foreach (CProformas Customer in ar)
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
                        }
                    }
                    else
                    {
                        CProformas Customer = (CProformas)ar[0];
                        CustomerGuid = Customer.Customerguid;
                        txtOrganizationName.Text = Customer.OrganizationName;
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
    }
}
