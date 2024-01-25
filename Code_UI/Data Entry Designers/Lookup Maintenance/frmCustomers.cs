//
// ...
// Wizard generated code
// Date: 8/1/2009 10:54:22 AM
// Class: frmCustomers
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

namespace Pharma
{
    public partial class frmCustomers : Form
    {
        private const string DialogCaption = "Customer Maintenance";

        private bool bNewCustomers = true;
        private int CustomersId = 0;
        private bool already_in = false;

        public frmCustomers()
        {
            InitializeComponent();
        }

        #region Customer Functions

        private bool IsValidCustomers()
        {
            try
            {
                decimal decValue;
                mValidator.Clear();
                if (!CCommon.SetRequiredMessage(txtCustomersName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtCustomersMailingaddress, "Customer address can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtCustomersTel1, "Customer tel. 1 can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtCustomersContactname, "Customer Contact Name can not be empty", mValidator, lblMsg))
                    return false;
                if (txtCustomersDiscount.Text != "")
                {
                    if (!decimal.TryParse(txtCustomersDiscount.Text, out decValue))
                    {
                        CCommon.SetMessage(txtCustomersDiscount, "Discount must be numberic", mValidator, lblMsg);
                        return false;
                    }
                }
                if (txtCustomersCreditlimit.Text != "")
                {
                    if (!decimal.TryParse(txtCustomersCreditlimit.Text, out decValue))
                    {
                        CCommon.SetMessage(txtCustomersCreditlimit, "Credit limit must be numberic", mValidator, lblMsg);
                        return false;
                    }
                }
                if (!CCommon.SetRequiredMessage(cboCustomersCustomertypeid, "Customer Type can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(cboCustomersLocationid, "Customer Location can not be empty", mValidator, lblMsg))
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewCustomers()
        {
            try
            {
                bNewCustomers = true;
                CustomersId = 0;
                mValidator.Clear();
                txtCustomersName.Text = String.Empty;
                txtCustomersTIN.Text = String.Empty;
                txtCustomersMailingaddress.Text = String.Empty;
                txtCustomersFax.Text = String.Empty;
                txtCustomersTel1.Text = String.Empty;
                txtCustomersTel2.Text = String.Empty;
                txtCustomersEmail.Text = String.Empty;
                txtCustomersContactname.Text = String.Empty;
                txtCustomersContactfax.Text = String.Empty;
                txtCustomersContacttel1.Text = String.Empty;
                txtCustomersContacttel2.Text = String.Empty;
                txtCustomersContactemail.Text = String.Empty;
                txtCustomersDiscount.Text = String.Empty;
                txtCustomersCreditlimit.Text = String.Empty;
                cboCustomersCustomertypeid.SelectedIndex = -1;
                cboCustomersLocationid.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveCustomers()
        {
            try
            {
                if (!IsValidCustomers()) return false;

                CCustomers objCustomers = new CCustomers();

                objCustomers.Id = CustomersId;
                if (txtCustomersName.Text == "")
                    objCustomers.Name = string.Empty;
                else
                    objCustomers.Name = Convert.ToString(txtCustomersName.Text);
                if (txtCustomersTIN.Text == "")
                    objCustomers.TIN = string.Empty;
                else
                    objCustomers.TIN = Convert.ToString(txtCustomersTIN.Text);
                if (txtCustomersMailingaddress.Text == "")
                    objCustomers.Mailingaddress = string.Empty;
                else
                    objCustomers.Mailingaddress = Convert.ToString(txtCustomersMailingaddress.Text);
                if (txtCustomersFax.Text == "")
                    objCustomers.Fax = string.Empty;
                else
                    objCustomers.Fax = Convert.ToString(txtCustomersFax.Text);
                if (txtCustomersTel1.Text == "")
                    objCustomers.Tel1 = string.Empty;
                else
                    objCustomers.Tel1 = Convert.ToString(txtCustomersTel1.Text);
                if (txtCustomersTel2.Text == "")
                    objCustomers.Tel2 = string.Empty;
                else
                    objCustomers.Tel2 = Convert.ToString(txtCustomersTel2.Text);
                if (txtCustomersEmail.Text == "")
                    objCustomers.Email = string.Empty;
                else
                    objCustomers.Email = Convert.ToString(txtCustomersEmail.Text);
                if (txtCustomersContactname.Text == "")
                    objCustomers.Contactname = string.Empty;
                else
                    objCustomers.Contactname = Convert.ToString(txtCustomersContactname.Text);
                if (txtCustomersContactfax.Text == "")
                    objCustomers.Contactfax = string.Empty;
                else
                    objCustomers.Contactfax = Convert.ToString(txtCustomersContactfax.Text);
                if(txtCustomersContacttel1.Text == "")
                    objCustomers.Contacttel1 = string.Empty;
                else
                    objCustomers.Contacttel1 = Convert.ToString(txtCustomersContacttel1.Text);
                if (txtCustomersContacttel2.Text == "")
                    objCustomers.Contacttel2 = string.Empty;
                else
                    objCustomers.Contacttel2 = Convert.ToString(txtCustomersContacttel2.Text);
                if (txtCustomersContactemail.Text == "")
                    objCustomers.Contactemail = string.Empty;
                else
                    objCustomers.Contactemail = Convert.ToString(txtCustomersContactemail.Text);
                if(txtCustomersDiscount.Text == "")
                    objCustomers.Discount = decimal.MinValue;
                else
                    objCustomers.Discount = Convert.ToDecimal(txtCustomersDiscount.Text);
                if (txtCustomersCreditlimit.Text == "")
                    objCustomers.CreditLimit = decimal.MinValue;
                else
                    objCustomers.CreditLimit = Convert.ToDecimal(txtCustomersCreditlimit.Text);
                if(cboCustomersCustomertypeid.SelectedIndex == -1)
                    objCustomers.Customertypeguid = string.Empty;
                else
                    objCustomers.Customertypeguid = CCommon.GetItemData(cboCustomersCustomertypeid);
                if (cboCustomersLocationid.SelectedIndex == -1)
                    objCustomers.Locationguid = string.Empty;
                else
                    objCustomers.Locationguid = CCommon.GetItemData(cboCustomersLocationid);
                
                if (objCustomers.Exists(bNewCustomers) > 0)
                {
                    MessageBox.Show("There exists a customer with the given Name", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewCustomers)
                    objCustomers.Insert();
                else
                    objCustomers.Update();

                CustomersId = objCustomers.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindCustomers()
        {
            try
            {
                CCustomers objCustomers = new CCustomers();
                DataTable dt = new DataTable();

                objCustomers.Id = CustomersId;
                dt = objCustomers.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    CustomersId = objCustomers.Id;
                    txtCustomersName.Text = Convert.ToString(objCustomers.Name);
                    txtCustomersTIN.Text = Convert.ToString(objCustomers.TIN);
                    txtCustomersMailingaddress.Text = Convert.ToString(objCustomers.Mailingaddress);
                    txtCustomersFax.Text = Convert.ToString(objCustomers.Fax);
                    txtCustomersTel1.Text = Convert.ToString(objCustomers.Tel1);
                    txtCustomersTel2.Text = Convert.ToString(objCustomers.Tel2);
                    txtCustomersEmail.Text = Convert.ToString(objCustomers.Email);
                    txtCustomersContactname.Text = Convert.ToString(objCustomers.Contactname);
                    txtCustomersContactfax.Text = Convert.ToString(objCustomers.Contactfax);
                    txtCustomersContacttel1.Text = Convert.ToString(objCustomers.Contacttel1);
                    txtCustomersContacttel2.Text = Convert.ToString(objCustomers.Contacttel2);
                    txtCustomersContactemail.Text = Convert.ToString(objCustomers.Contactemail);
                    txtCustomersDiscount.Text = Convert.ToString(objCustomers.Discount);
                    txtCustomersCreditlimit.Text = Convert.ToString(objCustomers.CreditLimit);
                    cboCustomersCustomertypeid.SelectedIndex = CCommon.GetIndexByItemData(cboCustomersCustomertypeid, objCustomers.Customertypeguid.ToString(), true);
                    cboCustomersLocationid.SelectedIndex = CCommon.GetIndexByItemData(cboCustomersLocationid, objCustomers.Locationguid.ToString(), true);

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
        private void EditCustomers()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwCustomers.SelectedItems[0];

                bNewCustomers = false;
                CustomersId = Convert.ToInt32(itmX.SubItems[colCustomersId.Index].Text);
                txtCustomersName.Text = Convert.ToString(itmX.SubItems[colCustomersName.Index].Text);
                txtCustomersTIN.Text = Convert.ToString(itmX.SubItems[colCustomersTIN.Index].Text);
                txtCustomersMailingaddress.Text = Convert.ToString(itmX.SubItems[colCustomersMailingaddress.Index].Text);
                txtCustomersFax.Text = Convert.ToString(itmX.SubItems[colCustomersFax.Index].Text);
                txtCustomersTel1.Text = Convert.ToString(itmX.SubItems[colCustomersTel1.Index].Text);
                txtCustomersTel2.Text = Convert.ToString(itmX.SubItems[colCustomersTel2.Index].Text);
                txtCustomersEmail.Text = Convert.ToString(itmX.SubItems[colCustomersEmail.Index].Text);
                txtCustomersContactname.Text = Convert.ToString(itmX.SubItems[colCustomersContactname.Index].Text);
                txtCustomersContactfax.Text = Convert.ToString(itmX.SubItems[colCustomersContactfax.Index].Text);
                txtCustomersContacttel1.Text = Convert.ToString(itmX.SubItems[colCustomersContacttel1.Index].Text);
                txtCustomersContacttel2.Text = Convert.ToString(itmX.SubItems[colCustomersContacttel2.Index].Text);
                txtCustomersContactemail.Text = Convert.ToString(itmX.SubItems[colCustomersContactemail.Index].Text);
                if (itmX.SubItems[colCustomersDiscount.Index].Text != "")
                {
                    if (Convert.ToDecimal(itmX.SubItems[colCustomersDiscount.Index].Text) != decimal.MinValue)
                        txtCustomersDiscount.Text = Convert.ToString(itmX.SubItems[colCustomersDiscount.Index].Text);
                    else
                        txtCustomersDiscount.Text = "";
                }
                else
                    txtCustomersDiscount.Text = "";
                if (itmX.SubItems[colCustomersCreditLimit.Index].Text != "")
                {
                    if (Convert.ToDecimal(itmX.SubItems[colCustomersCreditLimit.Index].Text) != decimal.MinValue)
                        txtCustomersCreditlimit.Text = Convert.ToString(itmX.SubItems[colCustomersCreditLimit.Index].Text);
                    else
                        txtCustomersCreditlimit.Text = "";
                }
                else
                    txtCustomersCreditlimit.Text = "";
                if (itmX.SubItems[colCustomersCustomerTypeGuid.Index].Text != "")
                {
                    if (itmX.SubItems[colCustomersCustomerTypeGuid.Index].Text != string.Empty)
                        cboCustomersCustomertypeid.SelectedIndex = CCommon.GetIndexByItemData(cboCustomersCustomertypeid, itmX.SubItems[colCustomersCustomerTypeGuid.Index].Text, true);
                    else
                        cboCustomersCustomertypeid.SelectedIndex = -1;
                }
                else
                    cboCustomersCustomertypeid.SelectedIndex = -1;
                if (itmX.SubItems[colCustomersLocationGuid.Index].Text != "")
                {
                    if (itmX.SubItems[colCustomersLocationGuid.Index].Text != string.Empty)
                        cboCustomersLocationid.SelectedIndex = CCommon.GetIndexByItemData(cboCustomersLocationid, itmX.SubItems[colCustomersLocationGuid.Index].Text, true);
                    else
                        cboCustomersLocationid.SelectedIndex = -1;
                }
                else
                    cboCustomersLocationid.SelectedIndex = -1;
                //this.FindCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCustomersList()
        {
            try
            {
                if (bNewCustomers)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {CustomersId.ToString(), 
                                                                                      txtCustomersName.Text.ToString(), 
                                                                                      txtCustomersMailingaddress.Text.ToString(), 
                                                                                      txtCustomersFax.Text.ToString(), 
                                                                                      txtCustomersTel1.Text.ToString(), 
                                                                                      txtCustomersTel2.Text.ToString(), 
                                                                                      txtCustomersEmail.Text.ToString(), 
                                                                                      txtCustomersContactname.Text.ToString(), 
                                                                                      txtCustomersContactfax.Text.ToString(), 
                                                                                      txtCustomersContacttel1.Text.ToString(), 
                                                                                      txtCustomersContacttel2.Text.ToString(), 
                                                                                      txtCustomersContactemail.Text.ToString(), 
                                                                                      txtCustomersTIN.Text.ToString(), 
                                                                                      txtCustomersDiscount.Text.ToString(), 
                                                                                      txtCustomersCreditlimit.Text.ToString(),
                                                                                      CCommon.GetItemData(cboCustomersCustomertypeid),
                                                                                      CCommon.GetItemData(cboCustomersLocationid)});
                    lvwCustomers.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwCustomers.SelectedItems[0];
                    itmX.SubItems[colCustomersName.Index].Text = txtCustomersName.Text.ToString();
                    itmX.SubItems[colCustomersTIN.Index].Text = txtCustomersTIN.Text.ToString();
                    itmX.SubItems[colCustomersMailingaddress.Index].Text = txtCustomersMailingaddress.Text.ToString();
                    itmX.SubItems[colCustomersFax.Index].Text = txtCustomersFax.Text.ToString();
                    itmX.SubItems[colCustomersTel1.Index].Text = txtCustomersTel1.Text.ToString();
                    itmX.SubItems[colCustomersTel2.Index].Text = txtCustomersTel2.Text.ToString();
                    itmX.SubItems[colCustomersEmail.Index].Text = txtCustomersEmail.Text.ToString();
                    itmX.SubItems[colCustomersContactname.Index].Text = txtCustomersContactname.Text.ToString();
                    itmX.SubItems[colCustomersContactfax.Index].Text = txtCustomersContactfax.Text.ToString();
                    itmX.SubItems[colCustomersContacttel1.Index].Text = txtCustomersContacttel1.Text.ToString();
                    itmX.SubItems[colCustomersContacttel2.Index].Text = txtCustomersContacttel2.Text.ToString();
                    itmX.SubItems[colCustomersContactemail.Index].Text = txtCustomersContactemail.Text.ToString();
                    itmX.SubItems[colCustomersDiscount.Index].Text = txtCustomersDiscount.Text.ToString();
                    itmX.SubItems[colCustomersCreditLimit.Index].Text = txtCustomersCreditlimit.Text.ToString();
                    itmX.SubItems[colCustomersCustomerTypeGuid.Index].Text = CCommon.GetItemData(cboCustomersCustomertypeid);
                    itmX.SubItems[colCustomersLocationGuid.Index].Text = CCommon.GetItemData(cboCustomersLocationid);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillCustomersList()
        {
            try
            {

                CCustomers objCustomers = new CCustomers();

                ArrayList ar = new ArrayList(objCustomers.GetList());
                this.lvwCustomers.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CCustomers Customers in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Customers.Id.ToString(), 
                                                                                      Customers.Name.ToString(), 
                                                                                      Customers.Mailingaddress.ToString(), 
                                                                                      Customers.Fax.ToString(), 
                                                                                      Customers.Tel1.ToString(), 
                                                                                      Customers.Tel2.ToString(), 
                                                                                      Customers.Email.ToString(), 
                                                                                      Customers.Contactname.ToString(), 
                                                                                      Customers.Contactfax.ToString(), 
                                                                                      Customers.Contacttel1.ToString(), 
                                                                                      Customers.Contacttel2.ToString(), 
                                                                                      Customers.Contactemail.ToString(), 
                                                                                      Customers.TIN.ToString(), 
                                                                                      Customers.Discount.ToString(), 
                                                                                      Customers.CreditLimit.ToString(), 
                                                                                      Customers.Customertypeguid.ToString(), 
                                                                                      Customers.Locationguid.ToString()});
                    this.lvwCustomers.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillCustomersList(string strCriteria)
        {
            try
            {

                CCustomers objCustomers = new CCustomers();

                ArrayList ar = new ArrayList(objCustomers.GetList(strCriteria));
                this.lvwCustomers.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CCustomers Customers in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      Customers.Id.ToString(), 
                                                                                      Customers.Name.ToString(), 
                                                                                      Customers.Mailingaddress.ToString(), 
                                                                                      Customers.Fax.ToString(), 
                                                                                      Customers.Tel1.ToString(), 
                                                                                      Customers.Tel2.ToString(), 
                                                                                      Customers.Email.ToString(), 
                                                                                      Customers.Contactname.ToString(), 
                                                                                      Customers.Contactfax.ToString(), 
                                                                                      Customers.Contacttel1.ToString(), 
                                                                                      Customers.Contacttel2.ToString(), 
                                                                                      Customers.Contactemail.ToString(), 
                                                                                      Customers.TIN.ToString(), 
                                                                                      Customers.Discount.ToString(), 
                                                                                      Customers.CreditLimit.ToString(), 
                                                                                      Customers.Customertypeguid.ToString(), 
                                                                                      Customers.Locationguid.ToString()});
                    this.lvwCustomers.Items.Add(itmX);
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
                this.line1.Width = this.lblTitle.Width;
                this.line2.Width = this.lblTitle.Width;

                // Main toolbar
                this.panelToolbar.Width = this.lblTitle.Width - this.panelToolbar.Left;
                this.grpCustomersEntry.Width = this.lblTitle.Width - this.grpCustomersEntry.Left - 24;
                this.grpContact.Width = this.lblTitle.Width - this.grpContact.Left - 24;
                this.grpTerms.Width = this.lblTitle.Width - this.grpTerms.Left - 24;

                // Transactions listview
                this.lvwCustomers.Height = this.Height - this.lvwCustomers.Top - 65;
                this.indexBar.Height = this.Height - this.indexBar.Top - 65;

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = null;
                CCommon.FillComboBox(cboCustomersCustomertypeid, "Select * from tblCustomerTypes", "TableRowGuid", "Description");
                CCommon.FillComboBox(cboCustomersLocationid, "Select * from tblLocations", "TableRowGuid", "Name");                
                NewCustomers();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCustomers_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillCustomersList();
                    lblMsg.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCustomers_Resize(object sender, EventArgs e)
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
        private void btnSaveCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveCustomers();

                if (bSaved)
                {
                    CCustomers.LoadCustomersToCollection();
                    UpdateCustomersList();
                    NewCustomers();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CCustomers objCustomers = new CCustomers();
                    objCustomers.Id = Convert.ToInt32(lvwCustomers.SelectedItems[0].SubItems[colCustomersId.Index].Text);
                    objCustomers.Delete();
                    lvwCustomers.Items.Remove(lvwCustomers.SelectedItems[0]);

                    NewCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                NewCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwCustomers_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwCustomers.SelectedItems == null) return;
                if (lvwCustomers.SelectedItems.Count <= 0) return;
                EditCustomers();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.CustomersId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindCustomers();
        }
        private void btnFindCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                FindCustomers();
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
                        strCriteria = strCriteria + " And (Name like '" + values[i] + "%'";
                    else
                        strCriteria = strCriteria + " Or Name like '" + values[i] + "%'";
                }
                if (i > 0)
                    strCriteria = strCriteria + ")";

                FillCustomersList(strCriteria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #endregion 
           
    }
}
