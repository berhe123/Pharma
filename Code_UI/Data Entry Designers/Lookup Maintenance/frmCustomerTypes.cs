//
// ...
// Wizard generated code
// Date: 9/17/2009 5:13:30 PM
// Class: frmCustomerTypes
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
    public partial class frmCustomerTypes : Form
    {
        private const string DialogCaption = "Customer Type Maintenance";

        private bool bNewCustomerTypes = true;
        private int CustomerTypesId = 0;
        private bool already_in = false;

        public frmCustomerTypes()
        {
            InitializeComponent();
        }
        private bool IsValidCustomerTypes()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtCustomerTypesDescription, "Description can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewCustomerTypes()
        {
            try
            {
                bNewCustomerTypes = true;
                CustomerTypesId = 0;
                txtCustomerTypesDescription.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveCustomerTypes()
        {
            try
            {
                if (!IsValidCustomerTypes()) return false;

                CCustomerTypes objCustomerTypes = new CCustomerTypes();

                objCustomerTypes.Id = CustomerTypesId;
                objCustomerTypes.Description = Convert.ToString(txtCustomerTypesDescription.Text);

                if (objCustomerTypes.Exists(bNewCustomerTypes) > 0)
                {
                    MessageBox.Show("There exists a customer type record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewCustomerTypes)
                    objCustomerTypes.Insert();
                else
                    objCustomerTypes.Update();

                CustomerTypesId = objCustomerTypes.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindCustomerTypes()
        {
            try
            {
                CCustomerTypes objCustomerTypes = new CCustomerTypes();
                DataTable dt = new DataTable();

                objCustomerTypes.Id = CustomerTypesId;
                dt = objCustomerTypes.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    CustomerTypesId = objCustomerTypes.Id;
                    txtCustomerTypesDescription.Text = Convert.ToString(objCustomerTypes.Description);

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
        private void EditCustomerTypes()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwCustomerTypes.SelectedItems[0];

                bNewCustomerTypes = false;
                CustomerTypesId = Convert.ToInt32(itmX.SubItems[colCustomerTypesId.Index].Text);
                txtCustomerTypesDescription.Text = Convert.ToString(itmX.SubItems[colCustomerTypesDescription.Index].Text);

                //this.FindCustomerTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCustomerTypesList()
        {
            try
            {
                if (bNewCustomerTypes)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {CustomerTypesId.ToString(), 
                                                                                      txtCustomerTypesDescription.Text.ToString()});
                    lvwCustomerTypes.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwCustomerTypes.SelectedItems[0];
                    itmX.SubItems[colCustomerTypesDescription.Index].Text = txtCustomerTypesDescription.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillCustomerTypesList()
        {
            try
            {

                CCustomerTypes objCustomerTypes = new CCustomerTypes();

                ArrayList ar = new ArrayList(objCustomerTypes.GetList());
                this.lvwCustomerTypes.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CCustomerTypes CustomerTypes in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      CustomerTypes.Id.ToString(), 
                                                                                      CustomerTypes.Description.ToString()});
                    this.lvwCustomerTypes.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCustomerTypes_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCustomerTypes_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillCustomerTypesList();
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
        private void btnSaveCustomerTypes_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveCustomerTypes();

                if (bSaved)
                {
                    UpdateCustomerTypesList();
                    NewCustomerTypes();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteCustomerTypes_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CCustomerTypes objCustomerTypes = new CCustomerTypes();
                    objCustomerTypes.Id = Convert.ToInt32(lvwCustomerTypes.SelectedItems[0].SubItems[colCustomerTypesId.Index].Text);
                    objCustomerTypes.Delete();
                    lvwCustomerTypes.Items.Remove(lvwCustomerTypes.SelectedItems[0]);

                    NewCustomerTypes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewCustomerTypes_Click(object sender, EventArgs e)
        {
            try
            {
                bNewCustomerTypes = true;
                CustomerTypesId = 0;
                NewCustomerTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwCustomerTypes_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwCustomerTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwCustomerTypes.SelectedItems == null) return;
                if (lvwCustomerTypes.SelectedItems.Count <= 0) return;
                EditCustomerTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchCustomerTypes_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.CustomerTypesId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindCustomerTypes();
        }
        private void btnFindCustomerTypes_Click(object sender, EventArgs e)
        {
            try
            {
                FindCustomerTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
