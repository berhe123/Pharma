//
// ...
// Wizard generated code
// Date: 11/12/2009 3:29:59 PM
// Class: frmDrugRegistrationFeeTables
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
    public partial class frmDrugRegistrationFeeTables : Form
    {
        private const string DialogCaption = "Drug Registration Fee - Table";

        private bool bNewDrugRegistrationFeeTables = true;
        private int DrugRegistrationFeeTablesId = 0;
        private bool already_in = false;

        public frmDrugRegistrationFeeTables()
        {
            InitializeComponent();
        }

        #region Drug Registration Fee Table Code
        private bool IsValidDrugRegistrationFeeTables()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtDrugRegistrationFeeTablesAgent, "Agent can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtDrugRegistrationFeeTablesReferencenumber, "Reference number can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewDrugRegistrationFeeTables()
        {
            try
            {
                bNewDrugRegistrationFeeTables = true;
                DrugRegistrationFeeTablesId = 0;
                txtDrugRegistrationFeeTablesAgent.Text = CSettings.OrganizationName.ToString() ;
                txtDrugRegistrationFeeTablesSubmissiondate.Text = DateTime.Today.ToString(CSettings.DateFormat);                 
                txtDrugRegistrationFeeTablesReferencenumber.Text = String.Empty;
                chkDrugRegistrationFeeTablesAccepted.Checked = false;
                txtDrugRegistrationFeeTablesAcceptancedate.Text = string.Empty;
                txtDrugRegistrationFeeTablesRemark.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveDrugRegistrationFeeTables()
        {

            try
            {
                if (!IsValidDrugRegistrationFeeTables()) return false;

                CDrugRegistrationFeeTables objDrugRegistrationFeeTables = new CDrugRegistrationFeeTables();

                objDrugRegistrationFeeTables.Id = DrugRegistrationFeeTablesId;
                objDrugRegistrationFeeTables.Agent = Convert.ToString(txtDrugRegistrationFeeTablesAgent.Text);
                objDrugRegistrationFeeTables.Submissiondate = CDateTime.DateFromString(txtDrugRegistrationFeeTablesSubmissiondate.Text);
                objDrugRegistrationFeeTables.Referencenumber = Convert.ToString(txtDrugRegistrationFeeTablesReferencenumber.Text);
                if (chkDrugRegistrationFeeTablesAccepted.Checked)
                    objDrugRegistrationFeeTables.Accepted = 1;
                else
                    objDrugRegistrationFeeTables.Accepted = 0;
                objDrugRegistrationFeeTables.Acceptancedate = CDateTime.DateFromString(txtDrugRegistrationFeeTablesAcceptancedate.Text);
                objDrugRegistrationFeeTables.Remark = Convert.ToString(txtDrugRegistrationFeeTablesRemark.Text);

                if (objDrugRegistrationFeeTables.Exists(bNewDrugRegistrationFeeTables) > 0)
                {
                    MessageBox.Show("There exists a record with the given details. Please try using another staff code.");
                    return false;
                }

                if (bNewDrugRegistrationFeeTables)
                    objDrugRegistrationFeeTables.Insert();
                else
                    objDrugRegistrationFeeTables.Update();

                DrugRegistrationFeeTablesId = objDrugRegistrationFeeTables.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindDrugRegistrationFeeTables()
        {
            try
            {
                CDrugRegistrationFeeTables objDrugRegistrationFeeTables = new CDrugRegistrationFeeTables();
                DataTable dt = new DataTable();

                objDrugRegistrationFeeTables.Id = DrugRegistrationFeeTablesId;
                dt = objDrugRegistrationFeeTables.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    DrugRegistrationFeeTablesId = objDrugRegistrationFeeTables.Id;
                    txtDrugRegistrationFeeTablesAgent.Text = Convert.ToString(objDrugRegistrationFeeTables.Agent);
                    if (objDrugRegistrationFeeTables.Submissiondate != DateTime.MinValue)
                    {
                        txtDrugRegistrationFeeTablesSubmissiondate.Text = objDrugRegistrationFeeTables.Submissiondate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtDrugRegistrationFeeTablesSubmissiondate.Text = string.Empty;
                    }
                    txtDrugRegistrationFeeTablesReferencenumber.Text = Convert.ToString(objDrugRegistrationFeeTables.Referencenumber);
                    if (objDrugRegistrationFeeTables.Accepted == 1)
                        chkDrugRegistrationFeeTablesAccepted.Checked = true;
                    else
                        chkDrugRegistrationFeeTablesAccepted.Checked = false;
                    if (objDrugRegistrationFeeTables.Acceptancedate != DateTime.MinValue)
                    {
                        txtDrugRegistrationFeeTablesAcceptancedate.Text = objDrugRegistrationFeeTables.Acceptancedate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtDrugRegistrationFeeTablesAcceptancedate.Text = string.Empty;
                    }
                    txtDrugRegistrationFeeTablesRemark.Text = Convert.ToString(objDrugRegistrationFeeTables.Remark);

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
        private void EditDrugRegistrationFeeTables()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwDrugRegistrationFeeTables.SelectedItems[0];

                bNewDrugRegistrationFeeTables = false;
                DrugRegistrationFeeTablesId = Convert.ToInt32(itmX.SubItems[colDrugRegistrationFeeTablesId.Index].Text);
                txtDrugRegistrationFeeTablesAgent.Text = Convert.ToString(itmX.SubItems[colDrugRegistrationFeeTablesAgent.Index].Text);
                txtDrugRegistrationFeeTablesSubmissiondate.Text = itmX.SubItems[colDrugRegistrationFeeTablesSubmissiondate.Index].Text;
                txtDrugRegistrationFeeTablesReferencenumber.Text = Convert.ToString(itmX.SubItems[colDrugRegistrationFeeTablesReferencenumber.Index].Text);
                if (Convert.ToInt32(itmX.SubItems[colDrugRegistrationFeeTablesAccepted.Index].Text) == 1)
                    chkDrugRegistrationFeeTablesAccepted.Checked = true;
                else
                    chkDrugRegistrationFeeTablesAccepted.Checked = false;
                txtDrugRegistrationFeeTablesAcceptancedate.Text = itmX.SubItems[colDrugRegistrationFeeTablesAcceptancedate.Index].Text;
                txtDrugRegistrationFeeTablesRemark.Text = Convert.ToString(itmX.SubItems[colDrugRegistrationFeeTablesRemark.Index].Text);

                //this.FindDrugRegistrationFeeTables();
                FillDrugRegistrationFeeTableDetailsGrid(CDrugRegistrationFeeTables.GetTableRowGuid(DrugRegistrationFeeTablesId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDrugRegistrationFeeTablesList()
        {
            try
            {
                if (bNewDrugRegistrationFeeTables)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {DrugRegistrationFeeTablesId.ToString(), 
                                                                                      txtDrugRegistrationFeeTablesAgent.Text.ToString(), 
                                                                                      txtDrugRegistrationFeeTablesSubmissiondate.Text.ToString(), 
                                                                                      txtDrugRegistrationFeeTablesReferencenumber.Text.ToString(), 
                                                                                      chkDrugRegistrationFeeTablesAccepted.Checked ? "1" : "0", 
                                                                                      txtDrugRegistrationFeeTablesAcceptancedate.Text.ToString(), 
                                                                                      txtDrugRegistrationFeeTablesRemark.Text.ToString()});
                    lvwDrugRegistrationFeeTables.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwDrugRegistrationFeeTables.SelectedItems[0];
                    itmX.SubItems[colDrugRegistrationFeeTablesAgent.Index].Text = txtDrugRegistrationFeeTablesAgent.Text.ToString();
                    itmX.SubItems[colDrugRegistrationFeeTablesSubmissiondate.Index].Text = txtDrugRegistrationFeeTablesSubmissiondate.Text.ToString();
                    itmX.SubItems[colDrugRegistrationFeeTablesReferencenumber.Index].Text = txtDrugRegistrationFeeTablesReferencenumber.Text.ToString();
                    itmX.SubItems[colDrugRegistrationFeeTablesAccepted.Index].Text = chkDrugRegistrationFeeTablesAccepted.Checked ? "1" : "0";
                    itmX.SubItems[colDrugRegistrationFeeTablesAcceptancedate.Index].Text = txtDrugRegistrationFeeTablesAcceptancedate.Text.ToString();
                    itmX.SubItems[colDrugRegistrationFeeTablesRemark.Index].Text = txtDrugRegistrationFeeTablesRemark.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDrugRegistrationFeeTablesList()
        {
            try
            {

                CDrugRegistrationFeeTables objDrugRegistrationFeeTables = new CDrugRegistrationFeeTables();

                ArrayList ar = new ArrayList(objDrugRegistrationFeeTables.GetList());
                this.lvwDrugRegistrationFeeTables.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CDrugRegistrationFeeTables DrugRegistrationFeeTables in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               DrugRegistrationFeeTables.Id.ToString(), 
                                                                                      DrugRegistrationFeeTables.Agent.ToString(), 
                                                                                      DrugRegistrationFeeTables.Submissiondate == CSettings.MinDate ? string.Empty : DrugRegistrationFeeTables.Submissiondate.ToString(CSettings.DateFormat), 
                                                                                      DrugRegistrationFeeTables.Referencenumber.ToString(), 
                                                                                      DrugRegistrationFeeTables.Accepted.ToString(), 
                                                                                      DrugRegistrationFeeTables.Acceptancedate == CSettings.MinDate ? string.Empty : DrugRegistrationFeeTables.Acceptancedate.ToString(CSettings.DateFormat), 
                                                                                      DrugRegistrationFeeTables.Remark.ToString()});
                    this.lvwDrugRegistrationFeeTables.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDrugRegistrationFeeTablesList(string strCriteria)
        {
            try
            {

                CDrugRegistrationFeeTables objDrugRegistrationFeeTables = new CDrugRegistrationFeeTables();

                ArrayList ar = new ArrayList(objDrugRegistrationFeeTables.GetList(strCriteria));
                this.lvwDrugRegistrationFeeTables.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CDrugRegistrationFeeTables DrugRegistrationFeeTables in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               DrugRegistrationFeeTables.Id.ToString(), 
                                                                                      DrugRegistrationFeeTables.Agent.ToString(), 
                                                                                      DrugRegistrationFeeTables.Submissiondate == CSettings.MinDate ? string.Empty : DrugRegistrationFeeTables.Submissiondate.ToString(CSettings.DateFormat), 
                                                                                      DrugRegistrationFeeTables.Referencenumber.ToString(), 
                                                                                      DrugRegistrationFeeTables.Accepted.ToString(), 
                                                                                      DrugRegistrationFeeTables.Acceptancedate == CSettings.MinDate ? string.Empty : DrugRegistrationFeeTables.Acceptancedate.ToString(CSettings.DateFormat), 
                                                                                      DrugRegistrationFeeTables.Remark.ToString()});
                    this.lvwDrugRegistrationFeeTables.Items.Add(itmX);
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
                this.lvwDrugRegistrationFeeTables.Height = this.Height - this.lvwDrugRegistrationFeeTables.Top - 65;

                // Detail Groupbox and Gridview
                this.lvwRegistrationCertificates.Height = this.Height - this.lvwRegistrationCertificates.Top - 65;
                this.gvwProductRegistrationCertificates.Width = this.lblTitle.Width - this.gvwProductRegistrationCertificates.Left - 24;
                //this.lvwRequestInvoices.Height = this.Height - this.lvwRequestInvoices.Top - 65;
                this.gvwProductRegistrationCertificates.Height = this.Height - this.gvwProductRegistrationCertificates.Top - 65;
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
                                                                                      ProductRegistrationCertificates.Tablerowguid.ToString(), 
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

        private void frmDrugRegistrationFeeTables_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = null;
                this.txtRegistrationDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtRegistrationDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmDrugRegistrationFeeTables_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    //FillDrugRegistrationFeeTablesList();
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
        private void btnSaveDrugRegistrationFeeTables_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveDrugRegistrationFeeTables();

                if (bSaved)
                {
                    SaveDrugRegistrationFeeTableDetails(CDrugRegistrationFeeTables.GetTableRowGuid(DrugRegistrationFeeTablesId));
                    UpdateDrugRegistrationFeeTablesList();
                    NewDrugRegistrationFeeTables();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteDrugRegistrationFeeTables_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CDrugRegistrationFeeTables objDrugRegistrationFeeTables = new CDrugRegistrationFeeTables();
                    objDrugRegistrationFeeTables.Id = Convert.ToInt32(lvwDrugRegistrationFeeTables.SelectedItems[0].SubItems[colDrugRegistrationFeeTablesId.Index].Text);
                    objDrugRegistrationFeeTables.Delete();
                    lvwDrugRegistrationFeeTables.Items.Remove(lvwDrugRegistrationFeeTables.SelectedItems[0]);

                    NewDrugRegistrationFeeTables();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewDrugRegistrationFeeTables_Click(object sender, EventArgs e)
        {
            try
            {
                bNewDrugRegistrationFeeTables = true;
                DrugRegistrationFeeTablesId = 0;
                NewDrugRegistrationFeeTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwDrugRegistrationFeeTables_DoubleClick(object sender, EventArgs e)
        {
        }
        private void lvwDrugRegistrationFeeTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwDrugRegistrationFeeTables.SelectedItems == null) return;
                if (lvwDrugRegistrationFeeTables.SelectedItems.Count <= 0) return;

                EditDrugRegistrationFeeTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchDrugRegistrationFeeTables_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.DrugRegistrationFeeTablesId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindDrugRegistrationFeeTables();
        }
        private void btnFindDrugRegistrationFeeTables_Click(object sender, EventArgs e)
        {
            try
            {
                FindDrugRegistrationFeeTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmDrugRegistrationFeeTables_Resize(object sender, EventArgs e)
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
        private void btnSearchCertificates_Click(object sender, EventArgs e)
        {
            try
            {
                string strCriteria = "";
                DateTime dteValidate;

                strCriteria = strCriteria + " And tblProductRegistrationCertificates.TableRowGuid NOT IN ";
                strCriteria = strCriteria + " (Select ProductRegistrationCertificateGuid from tblDrugRegistrationFeeTableDetails) ";

                strCriteria = strCriteria + " And tblProductRegistrationCertificates.Status = " + ((int)CCommon.ProductRegistrationCertificateStatus.Pending).ToString();

                if (txtRegistrationDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtRegistrationDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And tblProductRegistrationCertificates.RegistrationSubmissionDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtRegistrationDateTo.Text != "")
                    if (DateTime.TryParseExact(txtRegistrationDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And tblProductRegistrationCertificates.RegistrationSubmissionDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

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
                    foreach (ListViewItem itm in lvwRegistrationCertificates.Items)
                    {
                        if (itm.Checked == true)
                        {
                            this.gvwProductRegistrationCertificates.Rows.Add("0",
                                                                this.DrugRegistrationFeeTablesId.ToString(),
                                                                itm.SubItems[colProductRegistrationCertificatesGuid.Index].Text,
                                                                itm.SubItems[colProductName.Index].Text,
                                                                itm.SubItems[colProductRegistrationCertificatesRegistrationnumber.Index].Text);

                        }
                    }
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
        private void ShowDrugRegistrationFeeTable()
        {
            try
            {
                DataTable dt = new DataTable();
                rptDrugRegistrationFeeTable rpt = new rptDrugRegistrationFeeTable();
                frmReportViewer frm = null;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   TOP (100) PERCENT tblDrugRegistrationFeeTables.Id, tblDrugRegistrationFeeTables.TableRowGuid, tblDrugRegistrationFeeTables.Submissiondate, tblDrugRegistrationFeeTables.ReferenceNumber, tblDrugRegistrationFeeTableDetails.Id as DetailId, tblDrugRegistrationFeeTableDetails.TableRowGuid as DetailGuid, ";
                strSQL = strSQL + "                 tblDrugRegistrationFeeTables.Accepted, tblDrugRegistrationFeeTables.Acceptancedate, tblDrugRegistrationFeeTables.Remark, ";
                strSQL = strSQL + "                 tblManufacturers.Name AS ManufacturerName, tblCountries.Name AS ManufacturerCountry, tblManufacturers.MailingAddress,  ";
                strSQL = strSQL + "                 tblProducts.BrandName + ' ' + tblProducts.GenericName AS ProductName, tblProductRegistrationCertificates.SlipOrCpoNumber, ";
                strSQL = strSQL + "                 tblProductRegistrationCertificates.RegistrationNumber AS CertificateNumber, tblDrugRegistrationTypes.Name AS RegistrationType,  ";
                strSQL = strSQL + "                 tblProductRegistrationCertificates.RegistrationFee, tblProductRegistrationCertificates.RegistrationFeeInForeignCurrency,  ";
                strSQL = strSQL + "                 tblProductRegistrationCertificates.Id AS CertificateId, tblProductRegistrationCertificates.TableRowGuid AS CertificateGuid ";
                strSQL = strSQL + " FROM      tblDrugRegistrationFeeTables INNER JOIN tblDrugRegistrationFeeTableDetails ";
                strSQL = strSQL + "                  ON tblDrugRegistrationFeeTables.TableRowGuid = tblDrugRegistrationFeeTableDetails.DrugRegistrationFeeTableGuid  ";
                strSQL = strSQL + "             INNER JOIN tblProductRegistrationCertificates ";
                strSQL = strSQL + "                  ON tblDrugRegistrationFeeTableDetails.ProductRegistrationCertificateGuid = tblProductRegistrationCertificates.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblProducts ";
                strSQL = strSQL + "                  ON tblProductRegistrationCertificates.ProductGuid = tblProducts.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblManufacturers ";
                strSQL = strSQL + "                  ON tblProducts.ManufacturerGuid = tblManufacturers.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblCountries ";
                strSQL = strSQL + "                  ON tblManufacturers.CountryGuid = tblCountries.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblDrugRegistrationTypes ";
                strSQL = strSQL + "                  ON tblProductRegistrationCertificates.RegistrationType = tblDrugRegistrationTypes.TableRowGuid  ";
                strSQL = strSQL + " Where tblDrugRegistrationFeeTables.TableRowGuid = " + this.DrugRegistrationFeeTablesId.ToString();
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

        private void btnPrintDrugRegistrationFeeTable_Click(object sender, EventArgs e)
        {
            try
            {
                ShowDrugRegistrationFeeTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Drug Registration Fee Table Detail Code

        #region GridColumnNames
        public class GridColumnNames
        {
            public const string Id = "Id";
            public const string DrugRegistrationFeeTableGuid = "DrugRegistrationFeeTableGuid";
            public const string ProductRegistrationCertificateGuid = "ProductRegistrationCertificateGuid";
            public const string ProductName = "ProductName";
            public const string CertificateNumber = "CertificateNumber";
        }
        #endregion
        #region GridColumnDescriptions
        public class GridColumnDescriptions
        {
            public const string Id = "Id";
            public const string DrugRegistrationFeeTableGuid = "DrugRegistrationFeeTableGuid";
            public const string ProductRegistrationCertificateGuid = "ProductRegistrationCertificateGuid";
            public const string ProductName = "Product Name";
            public const string CertificateNumber = "Certificate #";
        }
        #endregion

        private bool ValidateDrugRegistrationFeeTableDetailRow(int intRowIndex)
        {
            try
            {
                if (gvwProductRegistrationCertificates.Rows[intRowIndex].Cells[GridColumnNames.DrugRegistrationFeeTableGuid].Value == null)
                {
                    gvwProductRegistrationCertificates.Rows[intRowIndex].ErrorText = "Please enter the Drug Registration Fee Table Id.";
                    return false;
                }

                if (gvwProductRegistrationCertificates.Rows[intRowIndex].Cells[GridColumnNames.ProductRegistrationCertificateGuid].Value == null)
                {
                    gvwProductRegistrationCertificates.Rows[intRowIndex].ErrorText = "Please enter the ProductRegistration  Certificate Id.";
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
        private void SaveDrugRegistrationFeeTableDetails(string strRegistrationFeeTableGuid)
        {
            try
            {
                for (int gvwRowIndex = 0; gvwRowIndex < gvwProductRegistrationCertificates.RowCount - 1; gvwRowIndex++)
                {
                    string strId = "";

                    if (!ValidateDrugRegistrationFeeTableDetailRow(gvwRowIndex)) break;

                    CDrugRegistrationFeeTableDetails objDrugRegistrationFeeTableDetails = new CDrugRegistrationFeeTableDetails();

                    if (gvwProductRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value != null && Convert.ToString(gvwProductRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value) != "")
                        strId = gvwProductRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value.ToString();

                    if (this.DrugRegistrationFeeTablesId != 0)
                    {
                        objDrugRegistrationFeeTableDetails.Id = 0;
                        objDrugRegistrationFeeTableDetails.Drugregistrationfeetableguid = strRegistrationFeeTableGuid;
                        objDrugRegistrationFeeTableDetails.Productregistrationcertificateguid = gvwProductRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.ProductRegistrationCertificateGuid].Value.ToString();

                        if (strId == string.Empty || strId == "0")
                        {
                            if (objDrugRegistrationFeeTableDetails.Exists(true) > 0)
                            {
                                MessageBox.Show("There exists a Record with the selected item.");
                                // return;
                            }
                            else
                            {
                                objDrugRegistrationFeeTableDetails.Insert();
                                gvwProductRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value = objDrugRegistrationFeeTableDetails.Id;
                            }
                        }
                        else
                        {
                            objDrugRegistrationFeeTableDetails.Id = Convert.ToInt32(strId.ToString());
                            if (objDrugRegistrationFeeTableDetails.Exists(false) > 0)
                            {
                                MessageBox.Show("There exists a Record with the selected item.");
                                //return;
                            }
                            else
                                objDrugRegistrationFeeTableDetails.Update();

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteDrugRegistrationFeeTableDetails()
        {
            try
            {
                for (int gvwRowIndex = 0; gvwRowIndex < gvwProductRegistrationCertificates.RowCount; gvwRowIndex++)
                {
                    if (gvwProductRegistrationCertificates.SelectedRows.Contains(gvwProductRegistrationCertificates.Rows[gvwRowIndex]))
                    {
                        if (MessageBox.Show("Are you sure to delete the " + Convert.ToString(gvwRowIndex + 1) + " row?", "Drug Registration Fee Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CDrugRegistrationFeeTableDetails objDrugRegistrationFeeTableDetails = new CDrugRegistrationFeeTableDetails();
                            objDrugRegistrationFeeTableDetails.Id = Convert.ToInt32(gvwProductRegistrationCertificates.Rows[gvwRowIndex].Cells[GridColumnNames.Id].Value);
                            objDrugRegistrationFeeTableDetails.Delete();
                            gvwProductRegistrationCertificates.Rows[gvwRowIndex].Visible = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDrugRegistrationFeeTableDetailsGrid(string strRegistrationFeeTableGuid)
        {
            try
            {

                CDrugRegistrationFeeTableDetails objDrugRegistrationFeeTableDetails = new CDrugRegistrationFeeTableDetails();

                ArrayList ar = new ArrayList(objDrugRegistrationFeeTableDetails.GetList(strRegistrationFeeTableGuid));
                if (this.gvwProductRegistrationCertificates.RowCount > 1)
                    this.gvwProductRegistrationCertificates.Rows.Clear();
                if (ar.Count < 0) return;

                foreach (CDrugRegistrationFeeTableDetails objDrugRegistrationFeeTableDetail in ar)
                {
                    gvwProductRegistrationCertificates.Rows.Add(new string[] { objDrugRegistrationFeeTableDetail.Id.ToString(), 
                                                            objDrugRegistrationFeeTableDetail.Drugregistrationfeetableguid.ToString(),
                                                            objDrugRegistrationFeeTableDetail.Productregistrationcertificateguid.ToString(),
                                                            objDrugRegistrationFeeTableDetail.Productname.ToString().Trim(),
                                                            objDrugRegistrationFeeTableDetail.Certificatenumber.ToString().Trim()});
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvwDrugRegistrationFeeTableDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DeleteDrugRegistrationFeeTableDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strCriteria = "";
                DateTime dteValidate;

                if (txtSubmissionDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtSubmissionDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And SubmissionDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtSubmissionDateTo.Text != "")
                    if (DateTime.TryParseExact(txtSubmissionDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And SubmissionDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                FillDrugRegistrationFeeTablesList(strCriteria);
                NewDrugRegistrationFeeTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
