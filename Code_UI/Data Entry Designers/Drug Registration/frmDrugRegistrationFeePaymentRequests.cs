//
// ...
// Wizard generated code
// Date: 11/12/2009 3:29:59 PM
// Class: frmDrugRegistrationFeePaymentRequests
// NB: No designer code is generated here
//     so you have to design your form
//     with the control names given here
//     so that you don't have to edit this code
// Control Name Assignment is shown below 
//     Prefix ClassName FieldName 
//     ClassName: Table Name stripped of unwanted table prefixes
//     Prefix: txt = TextBox
//     Prefix: cbo = ComboBox
//     Prefix: chk = CheckBox
//     Prefix: dt  = DatePicker
//     Prefix: col = ListViewColumn
//     Example: 
//         Table Name: tblPerson
//         Class Name: Person
//         Field Name: first_name
//         Control: TextBox
//         Control Name: txtPersonFirstName 
// ...
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;

namespace Pharma
{
    public partial class frmDrugRegistrationFeePaymentRequests : Form
    {
        private const string DialogCaption = "Drug Registration Fee - Payment Request";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        private bool bNewDrugRegistrationFeePaymentRequests = true;
        private int DrugRegistrationFeePaymentRequestsId = 0;
        private bool already_in = false;

        public frmDrugRegistrationFeePaymentRequests()
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

        #region Payment Request Code
        private bool IsValidDrugRegistrationFeePaymentRequests()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtDrugRegistrationFeePaymentRequestsManufacturerid, "Manufacturer can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtDrugRegistrationFeePaymentRequestsReferencenumber, "Reference number can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewDrugRegistrationFeePaymentRequests()
        {
            try
            {
                bNewDrugRegistrationFeePaymentRequests = true;
                DrugRegistrationFeePaymentRequestsId = 0;
                txtDrugRegistrationFeePaymentRequestsManufacturerid.Text = String.Empty;
                txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag = null;
                txtDrugRegistrationFeePaymentRequestsRequestdate.Text = string.Empty;
                txtDrugRegistrationFeePaymentRequestsReferencenumber.Text = String.Empty;
                chkDrugRegistrationFeePaymentRequestsSettled.Checked = false;
                txtDrugRegistrationFeePaymentRequestsSettlementdate.Text = string.Empty;
                txtDrugRegistrationFeePaymentRequestsRemark.Text = String.Empty;

                this.txtDrugRegistrationFeePaymentRequestsManufacturerid.ReadOnly = false;
                this.btnSearchManufacturer.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveDrugRegistrationFeePaymentRequests()
        {

            try
            {
                if (!IsValidDrugRegistrationFeePaymentRequests()) return false;

                CDrugRegistrationFeePaymentRequests objDrugRegistrationFeePaymentRequests = new CDrugRegistrationFeePaymentRequests();

                objDrugRegistrationFeePaymentRequests.Id = DrugRegistrationFeePaymentRequestsId;
                objDrugRegistrationFeePaymentRequests.Manufacturerguid = txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag.ToString();
                objDrugRegistrationFeePaymentRequests.Requestdate = CDateTime.DateFromString(txtDrugRegistrationFeePaymentRequestsRequestdate.Text);
                objDrugRegistrationFeePaymentRequests.Referencenumber = Convert.ToString(txtDrugRegistrationFeePaymentRequestsReferencenumber.Text);
                if (chkDrugRegistrationFeePaymentRequestsSettled.Checked)
                    objDrugRegistrationFeePaymentRequests.Settled = 1;
                else
                    objDrugRegistrationFeePaymentRequests.Settled = 0;
                objDrugRegistrationFeePaymentRequests.Settlementdate = CDateTime.DateFromString(txtDrugRegistrationFeePaymentRequestsSettlementdate.Text);
                objDrugRegistrationFeePaymentRequests.Remark = Convert.ToString(txtDrugRegistrationFeePaymentRequestsRemark.Text);

                if (objDrugRegistrationFeePaymentRequests.Exists(bNewDrugRegistrationFeePaymentRequests) > 0)
                {
                    MessageBox.Show("There exists an employee record with the given staff code. Please try using another staff code.");
                    return false;
                }

                if (bNewDrugRegistrationFeePaymentRequests)
                    objDrugRegistrationFeePaymentRequests.Insert();
                else
                    objDrugRegistrationFeePaymentRequests.Update();

                DrugRegistrationFeePaymentRequestsId = objDrugRegistrationFeePaymentRequests.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindDrugRegistrationFeePaymentRequests()
        {
            try
            {
                CDrugRegistrationFeePaymentRequests objDrugRegistrationFeePaymentRequests = new CDrugRegistrationFeePaymentRequests();
                DataTable dt = new DataTable();

                objDrugRegistrationFeePaymentRequests.Id = DrugRegistrationFeePaymentRequestsId;
                dt = objDrugRegistrationFeePaymentRequests.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    DrugRegistrationFeePaymentRequestsId = objDrugRegistrationFeePaymentRequests.Id;
                    txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag = objDrugRegistrationFeePaymentRequests.Manufacturerguid;
                    txtDrugRegistrationFeePaymentRequestsManufacturerid.Text = CManufacturers.GetManufacturerNameFromCollection(objDrugRegistrationFeePaymentRequests.Manufacturerguid);
                    if (objDrugRegistrationFeePaymentRequests.Requestdate != DateTime.MinValue)
                    {
                        txtDrugRegistrationFeePaymentRequestsRequestdate.Text = objDrugRegistrationFeePaymentRequests.Requestdate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtDrugRegistrationFeePaymentRequestsRequestdate.Text = string.Empty;
                    }
                    txtDrugRegistrationFeePaymentRequestsReferencenumber.Text = Convert.ToString(objDrugRegistrationFeePaymentRequests.Referencenumber);
                    if (objDrugRegistrationFeePaymentRequests.Settled == 1)
                        chkDrugRegistrationFeePaymentRequestsSettled.Checked = true;
                    else
                        chkDrugRegistrationFeePaymentRequestsSettled.Checked = false;
                    if (objDrugRegistrationFeePaymentRequests.Settlementdate != DateTime.MinValue)
                    {
                        txtDrugRegistrationFeePaymentRequestsSettlementdate.Text = objDrugRegistrationFeePaymentRequests.Settlementdate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtDrugRegistrationFeePaymentRequestsSettlementdate.Text = string.Empty;
                    }
                    txtDrugRegistrationFeePaymentRequestsRemark.Text = Convert.ToString(objDrugRegistrationFeePaymentRequests.Remark);

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
        private void EditDrugRegistrationFeePaymentRequests()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwDrugRegistrationFeePaymentRequests.SelectedItems[0];

                bNewDrugRegistrationFeePaymentRequests = false;
                DrugRegistrationFeePaymentRequestsId = Convert.ToInt32(itmX.SubItems[colDrugRegistrationFeePaymentRequestsId.Index].Text);
                txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag = itmX.SubItems[colDrugRegistrationFeePaymentRequestsManufacturerGuid.Index].Text;
                txtDrugRegistrationFeePaymentRequestsManufacturerid.Text = CManufacturers.GetManufacturerNameFromCollection(itmX.SubItems[colDrugRegistrationFeePaymentRequestsManufacturerGuid.Index].Text);
                txtDrugRegistrationFeePaymentRequestsRequestdate.Text = itmX.SubItems[colDrugRegistrationFeePaymentRequestsRequestdate.Index].Text;
                txtDrugRegistrationFeePaymentRequestsReferencenumber.Text = Convert.ToString(itmX.SubItems[colDrugRegistrationFeePaymentRequestsReferencenumber.Index].Text);
                if (Convert.ToInt32(itmX.SubItems[colDrugRegistrationFeePaymentRequestsSettled.Index].Text) == 1)
                    chkDrugRegistrationFeePaymentRequestsSettled.Checked = true;
                else
                    chkDrugRegistrationFeePaymentRequestsSettled.Checked = false;
                txtDrugRegistrationFeePaymentRequestsSettlementdate.Text = itmX.SubItems[colDrugRegistrationFeePaymentRequestsSettlementdate.Index].Text;
                txtDrugRegistrationFeePaymentRequestsRemark.Text = Convert.ToString(itmX.SubItems[colDrugRegistrationFeePaymentRequestsRemark.Index].Text);

                //this.FindDrugRegistrationFeePaymentRequests();
                FillPaymentRequestDetailsGrid(CDrugRegistrationFeePaymentRequests.GetTableRowGuid(DrugRegistrationFeePaymentRequestsId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateDrugRegistrationFeePaymentRequestsList()
        {
            try
            {
                if (bNewDrugRegistrationFeePaymentRequests)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {DrugRegistrationFeePaymentRequestsId.ToString(), 
                                                                                      txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag.ToString(), 
                                                                                      txtDrugRegistrationFeePaymentRequestsRequestdate.Text.ToString(), 
                                                                                      txtDrugRegistrationFeePaymentRequestsReferencenumber.Text.ToString(), 
                                                                                      chkDrugRegistrationFeePaymentRequestsSettled.Checked ? "1" : "0", 
                                                                                      txtDrugRegistrationFeePaymentRequestsSettlementdate.Text.ToString(), 
                                                                                      txtDrugRegistrationFeePaymentRequestsRemark.Text.ToString()});
                    lvwDrugRegistrationFeePaymentRequests.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwDrugRegistrationFeePaymentRequests.SelectedItems[0];
                    itmX.SubItems[colDrugRegistrationFeePaymentRequestsManufacturerGuid.Index].Text = txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag.ToString();
                    itmX.SubItems[colDrugRegistrationFeePaymentRequestsRequestdate.Index].Text = txtDrugRegistrationFeePaymentRequestsRequestdate.Text.ToString();
                    itmX.SubItems[colDrugRegistrationFeePaymentRequestsReferencenumber.Index].Text = txtDrugRegistrationFeePaymentRequestsReferencenumber.Text.ToString();
                    itmX.SubItems[colDrugRegistrationFeePaymentRequestsSettled.Index].Text = chkDrugRegistrationFeePaymentRequestsSettled.Checked ? "1" : "0";
                    itmX.SubItems[colDrugRegistrationFeePaymentRequestsSettlementdate.Index].Text = txtDrugRegistrationFeePaymentRequestsSettlementdate.Text.ToString();
                    itmX.SubItems[colDrugRegistrationFeePaymentRequestsRemark.Index].Text = txtDrugRegistrationFeePaymentRequestsRemark.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDrugRegistrationFeePaymentRequestsList()
        {
            try
            {

                CDrugRegistrationFeePaymentRequests objDrugRegistrationFeePaymentRequests = new CDrugRegistrationFeePaymentRequests();

                ArrayList ar = new ArrayList(objDrugRegistrationFeePaymentRequests.GetList());
                this.lvwDrugRegistrationFeePaymentRequests.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CDrugRegistrationFeePaymentRequests DrugRegistrationFeePaymentRequests in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               DrugRegistrationFeePaymentRequests.Id.ToString(), 
                                                                                      DrugRegistrationFeePaymentRequests.Manufacturerguid.ToString(), 
                                                                                      DrugRegistrationFeePaymentRequests.Requestdate == CSettings.MinDate ? string.Empty : DrugRegistrationFeePaymentRequests.Requestdate.ToString(CSettings.DateFormat), 
                                                                                      DrugRegistrationFeePaymentRequests.Referencenumber.ToString(), 
                                                                                      DrugRegistrationFeePaymentRequests.Settled.ToString(), 
                                                                                      DrugRegistrationFeePaymentRequests.Settlementdate == CSettings.MinDate ? string.Empty : DrugRegistrationFeePaymentRequests.Settlementdate.ToString(CSettings.DateFormat), 
                                                                                      DrugRegistrationFeePaymentRequests.Remark.ToString()});
                    this.lvwDrugRegistrationFeePaymentRequests.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDrugRegistrationFeePaymentRequestsList(string strCriteria)
        {
            try
            {

                CDrugRegistrationFeePaymentRequests objDrugRegistrationFeePaymentRequests = new CDrugRegistrationFeePaymentRequests();

                ArrayList ar = new ArrayList(objDrugRegistrationFeePaymentRequests.GetList(strCriteria));
                this.lvwDrugRegistrationFeePaymentRequests.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CDrugRegistrationFeePaymentRequests DrugRegistrationFeePaymentRequests in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               DrugRegistrationFeePaymentRequests.Id.ToString(), 
                                                                                      DrugRegistrationFeePaymentRequests.Manufacturerguid.ToString(), 
                                                                                      DrugRegistrationFeePaymentRequests.Requestdate == CSettings.MinDate ? string.Empty : DrugRegistrationFeePaymentRequests.Requestdate.ToString(CSettings.DateFormat), 
                                                                                      DrugRegistrationFeePaymentRequests.Referencenumber.ToString(), 
                                                                                      DrugRegistrationFeePaymentRequests.Settled.ToString(), 
                                                                                      DrugRegistrationFeePaymentRequests.Settlementdate == CSettings.MinDate ? string.Empty : DrugRegistrationFeePaymentRequests.Settlementdate.ToString(CSettings.DateFormat), 
                                                                                      DrugRegistrationFeePaymentRequests.Remark.ToString()});
                    this.lvwDrugRegistrationFeePaymentRequests.Items.Add(itmX);
                }
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
                this.tsbToolBar.Width = this.lblTitle.Width - this.tsbToolBar.Left;
                this.grpRequest.Width = this.lblTitle.Width - this.grpRequest.Left - 24;
                //this.grpRegistrationCertificate.Width = this.lblTitle.Width - this.grpRegistrationCertificate.Left - 24;
                this.grpSettlement.Width = this.lblTitle.Width - this.grpSettlement.Left - 24;

                // Transactions listview
                this.lvwDrugRegistrationFeePaymentRequests.Height = this.Height - this.lvwDrugRegistrationFeePaymentRequests.Top - 65;

                // Detail Groupbox and Gridview
                this.lvwRegistrationCertificates.Height = this.Height - this.lvwRegistrationCertificates.Top - 65;
                this.gvwRequestRegistrationCertificates.Width = this.lblTitle.Width - this.gvwRequestRegistrationCertificates.Left - 24;
                //this.lvwRequestInvoices.Height = this.Height - this.lvwRequestInvoices.Top - 65;
                this.lblTotalAmount.Top = this.lvwDrugRegistrationFeePaymentRequests.Top + this.lvwDrugRegistrationFeePaymentRequests.Height - this.lblTotalAmount.Height;
                this.txtTotalReqAmount.Top = this.lvwDrugRegistrationFeePaymentRequests.Top + this.lvwDrugRegistrationFeePaymentRequests.Height - this.txtTotalReqAmount.Height;
                this.gvwRequestRegistrationCertificates.Height = this.Height - this.gvwRequestRegistrationCertificates.Top - 65 - this.txtTotalReqAmount.Height - 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillCertificatesList(string strCriteria)
        {
            try
            {

                CProductRegistrationCertificates objProductRegistrationCertificates = new CProductRegistrationCertificates();

                ArrayList ar = new ArrayList(objProductRegistrationCertificates.GetList(strCriteria, 0));
                this.lvwRegistrationCertificates.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CProductRegistrationCertificates ProductRegistrationCertificates in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               ProductRegistrationCertificates.Productname.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationnumber.ToString(), 
                                                                                      ProductRegistrationCertificates.Id.ToString(), 
                                                                                      ProductRegistrationCertificates.Productguid.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationdate.ToString(), 
                                                                                      CCommon.GetProductRegistrationCertificateStatusText(ProductRegistrationCertificates.Status).ToString(), 
                                                                                      ProductRegistrationCertificates.Specificationrequestdate.ToString(), 
                                                                                      ProductRegistrationCertificates.Specificationreceiveddate.ToString(), 
                                                                                      ProductRegistrationCertificates.Specificationsubmissiondate.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationfee.ToString(), 
                                                                                      ProductRegistrationCertificates.Samplerequestdate.ToString(), 
                                                                                      ProductRegistrationCertificates.Samplereceiveddate.ToString(), 
                                                                                      ProductRegistrationCertificates.Samplesubmissiondate.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationexpirydate.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationsubmissiondate.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationfeeinforeigncurrency.ToString(), 
                                                                                      ProductRegistrationCertificates.Sliporcponumber.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationtypeguid.ToString()});
                    this.lvwRegistrationCertificates.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDrugRegistrationFeePaymentRequests_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = null;
                this.txtRequestDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtRequestDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmDrugRegistrationFeePaymentRequests_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    //FillDrugRegistrationFeePaymentRequestsList();
                    lblMsg.Text = null;
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
        private void btnSaveDrugRegistrationFeePaymentRequests_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveDrugRegistrationFeePaymentRequests();

                if (bSaved)
                {
                    SavePaymentRequestDetails(CDrugRegistrationFeePaymentRequests.GetTableRowGuid(DrugRegistrationFeePaymentRequestsId));
                    UpdateDrugRegistrationFeePaymentRequestsList();
                    NewDrugRegistrationFeePaymentRequests();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteDrugRegistrationFeePaymentRequests_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CDrugRegistrationFeePaymentRequests objDrugRegistrationFeePaymentRequests = new CDrugRegistrationFeePaymentRequests();
                    objDrugRegistrationFeePaymentRequests.Id = Convert.ToInt32(lvwDrugRegistrationFeePaymentRequests.SelectedItems[0].SubItems[colDrugRegistrationFeePaymentRequestsId.Index].Text);
                    objDrugRegistrationFeePaymentRequests.Delete();
                    lvwDrugRegistrationFeePaymentRequests.Items.Remove(lvwDrugRegistrationFeePaymentRequests.SelectedItems[0]);

                    NewDrugRegistrationFeePaymentRequests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewDrugRegistrationFeePaymentRequests_Click(object sender, EventArgs e)
        {
            try
            {
                bNewDrugRegistrationFeePaymentRequests = true;
                DrugRegistrationFeePaymentRequestsId = 0;
                NewDrugRegistrationFeePaymentRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwDrugRegistrationFeePaymentRequests_DoubleClick(object sender, EventArgs e)
        {
        }
        private void lvwDrugRegistrationFeePaymentRequests_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwDrugRegistrationFeePaymentRequests.SelectedItems == null) return;
                if (lvwDrugRegistrationFeePaymentRequests.SelectedItems.Count <= 0) return;

                EditDrugRegistrationFeePaymentRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchDrugRegistrationFeePaymentRequests_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //frmFindByName frmF = new frmFindByName();
            //    //frmF.ShowDialog();
            //    //if (frmF.bCancel == true) return;
            //    //this.DrugRegistrationFeePaymentRequestsId = Convert.ToInt32(frmF.PID.ToString());
            //    //this.FindDrugRegistrationFeePaymentRequests();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void btnFindDrugRegistrationFeePaymentRequests_Click(object sender, EventArgs e)
        {
            try
            {
                FindDrugRegistrationFeePaymentRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmDrugRegistrationFeePaymentRequests_Resize(object sender, EventArgs e)
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
        private void btnSearchManufacturer_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectManufacturer frmManu = new frmSelectManufacturer();
                frmManu.ShowDialog();
                if (frmManu.bCancel == true) return;
                this.txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag = frmManu.Manufacturerguid.ToString();
                this.txtDrugRegistrationFeePaymentRequestsManufacturerid.Text = frmManu.ManufacturerName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchCertificates_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDrugRegistrationFeePaymentRequestsManufacturerid.Text.Length <= 0)
                {
                    MessageBox.Show("Please select a manufacturer first.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.txtDrugRegistrationFeePaymentRequestsManufacturerid.Focus();
                    return;
                }

                string strCriteria = "";
                DateTime dteValidate;

                strCriteria = strCriteria + " And tblProductRegistrationCertificates.TableRowGuid NOT IN ";
                strCriteria = strCriteria + " (Select DrugRegistrationCertificateGuid from tblDrugRegistrationFeePaymentRequestCertificates) ";

                strCriteria = strCriteria + " And tblProductRegistrationCertificates.Status = " + ((int)CCommon.ProductRegistrationCertificateStatus.Granted).ToString();

                if (txtDrugRegistrationFeePaymentRequestsManufacturerid.Text != "")
                    strCriteria = strCriteria + " And tblProducts.ManufacturerGuid = '" + txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag.ToString() + "' ";
                if (txtRegistrationDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtRegistrationDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And tblProductRegistrationCertificates.RegistrationDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtRegistrationDateTo.Text != "")
                    if (DateTime.TryParseExact(txtRegistrationDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And tblProductRegistrationCertificates.RegistrationDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                FillCertificatesList(strCriteria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddItem()
        {
            try
            {
                if (lvwRegistrationCertificates.Items.Count > 0)
                {
                    CCashCollections objCash = new CCashCollections();
                    string val = string.Empty;
                    decimal amt = 0;
                    foreach (ListViewItem itm in lvwRegistrationCertificates.Items)
                    {
                        if (itm.Checked == true)
                        {

                            val = itm.SubItems[colProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Index].Text;
                            amt = val.Trim() == string.Empty ? 0 : Convert.ToDecimal(val);
                            amt = amt * CSettings.DrugRegistrationFeePercentagePaidByManufacturer / 100;

                            this.gvwRequestRegistrationCertificates.Rows.Add("0",
                                                                this.DrugRegistrationFeePaymentRequestsId.ToString(),
                                                                itm.SubItems[colProductRegistrationCertificatesGuid.Index].Text,
                                                                itm.SubItems[colProductName.Index].Text,
                                                                itm.SubItems[colProductRegistrationCertificatesRegistrationnumber.Index].Text,
                                                                amt.ToString());

                            this.txtDrugRegistrationFeePaymentRequestsManufacturerid.ReadOnly = true;
                            this.btnSearchManufacturer.Enabled = false;

                        }
                    }
                    CalculateTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Manufacturer Proforma Detail Code

        #region GridColumnNames
        public class GridColumnNames
        {
            public const string Id = "Id";
            public const string PaymentRequestGuid = "PaymentRequestGuid";
            public const string CertificateGuid = "CertificateGuid";
            public const string CertificateNumber = "CertificateNumber";
            public const string PaymentAmount = "PaymentAmount";
        }
        #endregion
        #region GridColumnDescriptions
        public class GridColumnDescriptions
        {
            public const string Id = "Id";
            public const string PaymentRequestGuid = "PaymentRequestGuid";
            public const string CertificateGuid = "CertificateGuid";
            public const string CertificateNumber = "Certificate #";
            public const string PaymentAmount = "Amount";
        }
        #endregion

        private void CalculateTotal()
        {
            try
            {
                decimal decTotalAmount;
                decTotalAmount = CCommonListView.GetListTotal(gvwRequestRegistrationCertificates, GridColumnNames.PaymentAmount);
                txtTotalReqAmount.Text = decTotalAmount.ToString(CSettings.CurrencyFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidatePaymentRequestDetailRow(int intRowIndex)
        {
            try
            {
                double dblValue;

                if (gvwRequestRegistrationCertificates.Rows[intRowIndex].Cells[GridColumnNames.CertificateGuid].Value == null)
                {
                    gvwRequestRegistrationCertificates.Rows[intRowIndex].ErrorText = "Please enter the certificate id.";
                    return false;
                }

                if (gvwRequestRegistrationCertificates.Rows[intRowIndex].Cells[GridColumnNames.CertificateNumber].Value == null)
                {
                    gvwRequestRegistrationCertificates.Rows[intRowIndex].ErrorText = "Please enter the certificate number.";
                    return false;
                }

                if (gvwRequestRegistrationCertificates.Rows[intRowIndex].Cells[GridColumnNames.PaymentAmount].Value != null)
                {
                    if (!double.TryParse(gvwRequestRegistrationCertificates.Rows[intRowIndex].Cells[GridColumnNames.PaymentAmount].Value.ToString(), out dblValue))
                    {
                        gvwRequestRegistrationCertificates.Rows[intRowIndex].ErrorText = "Payment amount must be a numeric value";
                        return false;
                    }
                }
                else
                {
                    gvwRequestRegistrationCertificates.Rows[intRowIndex].ErrorText = "Please enter the payment amount.";
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
        private void SavePaymentRequestDetails(string strRequestGuid)
        {
            try
            {
                for (int gvwRowIndex = 0; gvwRowIndex < gvwRequestRegistrationCertificates.RowCount - 1; gvwRowIndex++)
                {
                    string strId = "";

                    if (!ValidatePaymentRequestDetailRow(gvwRowIndex)) break;

                    CDrugRegistrationFeePaymentRequestCertificates objPaymentRequestDetails = new CDrugRegistrationFeePaymentRequestCertificates();

                    if (gvwRequestRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value != null && Convert.ToString(gvwRequestRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value) != "")
                        strId = gvwRequestRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value.ToString();

                    if (this.DrugRegistrationFeePaymentRequestsId != 0)
                    {
                        objPaymentRequestDetails.Id = 0;
                        objPaymentRequestDetails.Drugregistrationfeepaymentrequestguid = strRequestGuid;
                        objPaymentRequestDetails.Drugregistrationcertificateguid = gvwRequestRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.CertificateGuid].Value.ToString();
                        objPaymentRequestDetails.Amount = Convert.ToDecimal(gvwRequestRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.PaymentAmount].Value);

                        if (strId == string.Empty || strId == "0")
                        {
                            if (objPaymentRequestDetails.Exists(true) > 0)
                            {
                                MessageBox.Show("There exists a Record with the selected item.");
                                // return;
                            }
                            else
                            {
                                objPaymentRequestDetails.Insert();
                                gvwRequestRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value = objPaymentRequestDetails.Id;
                            }
                        }
                        else
                        {
                            objPaymentRequestDetails.Id = Convert.ToInt32(strId.ToString());
                            if (objPaymentRequestDetails.Exists(false) > 0)
                            {
                                MessageBox.Show("There exists a Record with the selected item.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                //return;
                            }
                            else
                                objPaymentRequestDetails.Update();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletePaymentRequestDetails()
        {
            try
            {
                for (int gvwRowIndex = 0; gvwRowIndex < gvwRequestRegistrationCertificates.RowCount; gvwRowIndex++)
                {
                    if (gvwRequestRegistrationCertificates.SelectedRows.Contains(gvwRequestRegistrationCertificates.Rows[gvwRowIndex]))
                    {
                        if (MessageBox.Show("Are you sure to delete the " + Convert.ToString(gvwRowIndex + 1) + " row?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CDrugRegistrationFeePaymentRequestCertificates objPaymentRequestDetails = new CDrugRegistrationFeePaymentRequestCertificates();
                            objPaymentRequestDetails.Id = Convert.ToInt32(gvwRequestRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value);
                            objPaymentRequestDetails.Delete();
                            gvwRequestRegistrationCertificates.Rows[gvwRowIndex].Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillPaymentRequestDetailsGrid(string strRequestGuid)
        {
            try
            {

                CDrugRegistrationFeePaymentRequestCertificates objPaymentRequestDetails = new CDrugRegistrationFeePaymentRequestCertificates();

                ArrayList ar = new ArrayList(objPaymentRequestDetails.GetList(strRequestGuid));
                if (this.gvwRequestRegistrationCertificates.RowCount > 1)
                    this.gvwRequestRegistrationCertificates.Rows.Clear();
                if (ar.Count < 0) return;

                foreach (CDrugRegistrationFeePaymentRequestCertificates objPaymentRequestDetail in ar)
                {
                    gvwRequestRegistrationCertificates.Rows.Add(new string[] { objPaymentRequestDetail.Id.ToString(), 
                                                            objPaymentRequestDetail.Drugregistrationfeepaymentrequestguid.ToString(),
                                                            objPaymentRequestDetail.Drugregistrationcertificateguid.ToString(),
                                                            objPaymentRequestDetail.Productname.ToString().Trim(),
                                                            objPaymentRequestDetail.Certificatenumber.ToString().Trim(),
                                                            objPaymentRequestDetail.Amount.ToString(CSettings.CurrencyFormat)});
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
                //DataGridViewComboBoxCell gvwComboBoxCell;
                string strItemId = string.Empty;

                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvwProformaDetail_RowLeave(object sender, DataGridViewCellEventArgs e)
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

        #endregion

        private void gvwRequestRegistrationCertificates_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DeletePaymentRequestDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowPaymentRequest()
        {
            try
            {
                DataTable dt = new DataTable();
                rptDrugRegistrationFeePaymentRequest rpt = new rptDrugRegistrationFeePaymentRequest();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   TOP (100) PERCENT tblDrugRegistrationFeePaymentRequests.Id, DrugRegistrationFeePaymentRequestGuid = tblDrugRegistrationFeePaymentRequests.TableRowGuid, tblDrugRegistrationFeePaymentRequests.RequestDate, tblDrugRegistrationFeePaymentRequests.ReferenceNumber, tblDrugRegistrationFeePaymentRequestCertificates.Id as DetailId, ";
                strSQL = strSQL + "                 tblDrugRegistrationFeePaymentRequests.Settled, tblDrugRegistrationFeePaymentRequests.SettlementDate, tblDrugRegistrationFeePaymentRequests.Remark, ";
                strSQL = strSQL + "                 tblManufacturers.Name AS ManufacturerName, tblCountries.Name AS ManufacturerCountry, tblManufacturers.MailingAddress,  ";
                strSQL = strSQL + "                 tblProducts.BrandName + ' ' + tblProducts.GenericName AS ProductName, tblProductRegistrationCertificates.SlipOrCpoNumber, ";
                strSQL = strSQL + "                 tblProductRegistrationCertificates.RegistrationNumber AS CertificateNumber, tblDrugRegistrationTypes.Name AS RegistrationType,  ";
                strSQL = strSQL + "                 tblProductRegistrationCertificates.RegistrationFee, tblProductRegistrationCertificates.RegistrationFeeInForeignCurrency,  ";
                strSQL = strSQL + "                 tblProductRegistrationCertificates.Id AS CertificateId, tblProductRegistrationCertificates.TableRowGuid AS CertificateGuid, tblDrugRegistrationFeePaymentRequestCertificates.Amount ";
                strSQL = strSQL + " FROM      tblDrugRegistrationFeePaymentRequests INNER JOIN tblDrugRegistrationFeePaymentRequestCertificates ";
                strSQL = strSQL + "                  ON tblDrugRegistrationFeePaymentRequests.TableRowGuid = tblDrugRegistrationFeePaymentRequestCertificates.DrugRegistrationFeePaymentRequestGuid  ";
                strSQL = strSQL + "             INNER JOIN tblProductRegistrationCertificates ";
                strSQL = strSQL + "                  ON tblDrugRegistrationFeePaymentRequestCertificates.DrugRegistrationCertificateGuid = tblProductRegistrationCertificates.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblProducts ";
                strSQL = strSQL + "                  ON tblProductRegistrationCertificates.ProductGuid = tblProducts.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblManufacturers ";
                strSQL = strSQL + "                  ON tblProducts.ManufacturerGuid = tblManufacturers.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblCountries ";
                strSQL = strSQL + "                  ON tblManufacturers.CountryGuid = tblCountries.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblDrugRegistrationTypes ";
                strSQL = strSQL + "                  ON tblProductRegistrationCertificates.RegistrationTypeGuid = tblDrugRegistrationTypes.TableRowGuid  ";
                strSQL = strSQL + " Where tblDrugRegistrationFeePaymentRequests.TableRowGuid = '" + CDrugRegistrationFeePaymentRequests.GetTableRowGuid(this.DrugRegistrationFeePaymentRequestsId) + "' ";
                strSQL = strSQL + " ORDER BY ProductName, CertificateNumber  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Drug Registration Fee Payment Request";
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

        private void btnPrintPaymentRequest_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPaymentRequest();
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

                if (txtRequestDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtRequestDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And RequestDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtRequestDateTo.Text != "")
                    if (DateTime.TryParseExact(txtRequestDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And RequestDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                FillDrugRegistrationFeePaymentRequestsList(strCriteria);
                NewDrugRegistrationFeePaymentRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchManufacturer()
        {
            try
            {
                if (txtDrugRegistrationFeePaymentRequestsManufacturerid.Text != "")
                {
                    CManufacturers objManufacturer = new CManufacturers();
                    string nameLike = txtDrugRegistrationFeePaymentRequestsManufacturerid.Text + "%";
                    ArrayList ar = new ArrayList(objManufacturer.GetList(nameLike));
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        manSelector = new frmManufacturerSelector();
                        manSelector.Width = txtDrugRegistrationFeePaymentRequestsManufacturerid.Width;
                        manSelector.lvwManufacturer.Items.Clear();
                        foreach (CManufacturers Manufacturer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Manufacturer.Tablerowguid.ToString(),
                            Manufacturer.Name.ToString()});
                            manSelector.lvwManufacturer.Items.Add(itmX);
                        }
                        Point location = this.PointToScreen(new Point(this.grpRequest.Left + this.txtDrugRegistrationFeePaymentRequestsManufacturerid.Left, this.grpRequest.Top + this.txtDrugRegistrationFeePaymentRequestsManufacturerid.Bottom));
                        popupHelper.ShowPopup(this, manSelector, location);

                        if (manSelector.blnSelected)
                        {
                            txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag = manSelector.Manufacturerguid;
                            txtDrugRegistrationFeePaymentRequestsManufacturerid.Text = manSelector.ManufacturerName;
                        }
                    }
                    else
                    {
                        CManufacturers Manufacturer = (CManufacturers)ar[0];
                        txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag = Manufacturer.Tablerowguid;
                        txtDrugRegistrationFeePaymentRequestsManufacturerid.Text = Manufacturer.Name;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDrugRegistrationFeePaymentRequestsManufacturerid_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SearchManufacturer();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void popupHelper_PopupClosed(object sender, PopupClosedEventArgs e)
        {
            try
            {
                if (manSelector.blnSelected)
                {
                    txtDrugRegistrationFeePaymentRequestsManufacturerid.Tag = manSelector.Manufacturerguid;
                    txtDrugRegistrationFeePaymentRequestsManufacturerid.Text = manSelector.ManufacturerName;
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

        private void btnSearchManufacturer1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchManufacturer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
