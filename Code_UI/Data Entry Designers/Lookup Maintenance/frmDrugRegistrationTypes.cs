//
// ...
// Wizard generated code
// Date: 11/12/2009 11:16:03 AM
// Class: frmDrugRegistrationTypes
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
    public partial class frmDrugRegistrationTypes : Form
    {
        private const string DialogCaption = "Drug Registration Type Maintenance";

        private bool bNewDrugRegistrationTypes = true;
        private int DrugRegistrationTypesId = 0;
        private bool already_in = false;

        public frmDrugRegistrationTypes()
        {
            InitializeComponent();
        }
        private bool IsValidDrugRegistrationTypes()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtDrugRegistrationTypesName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewDrugRegistrationTypes()
        {
            try
            {
                bNewDrugRegistrationTypes = true;
                DrugRegistrationTypesId = 0;
                txtDrugRegistrationTypesName.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveDrugRegistrationTypes()
        {
            try
            {
                if (!IsValidDrugRegistrationTypes()) return false;

                CDrugRegistrationTypes objDrugRegistrationTypes = new CDrugRegistrationTypes();

                objDrugRegistrationTypes.Id = DrugRegistrationTypesId;
                objDrugRegistrationTypes.Name = Convert.ToString(txtDrugRegistrationTypesName.Text);

                if (objDrugRegistrationTypes.Exists(bNewDrugRegistrationTypes) > 0)
                {
                    MessageBox.Show("There exists a drug registration type record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewDrugRegistrationTypes)
                    objDrugRegistrationTypes.Insert();
                else
                    objDrugRegistrationTypes.Update();

                DrugRegistrationTypesId = objDrugRegistrationTypes.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindDrugRegistrationTypes()
        {
            try
            {
                CDrugRegistrationTypes objDrugRegistrationTypes = new CDrugRegistrationTypes();
                DataTable dt = new DataTable();

                objDrugRegistrationTypes.Id = DrugRegistrationTypesId;
                dt = objDrugRegistrationTypes.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    DrugRegistrationTypesId = objDrugRegistrationTypes.Id;
                    txtDrugRegistrationTypesName.Text = Convert.ToString(objDrugRegistrationTypes.Name);

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
        private void EditDrugRegistrationTypes()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwDrugRegistrationTypes.SelectedItems[0];

                bNewDrugRegistrationTypes = false;
                DrugRegistrationTypesId = Convert.ToInt32(itmX.SubItems[colDrugRegistrationTypesId.Index].Text);
                txtDrugRegistrationTypesName.Text = Convert.ToString(itmX.SubItems[colDrugRegistrationTypesName.Index].Text);

                //this.FindDrugRegistrationTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDrugRegistrationTypesList()
        {
            try
            {
                if (bNewDrugRegistrationTypes)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {DrugRegistrationTypesId.ToString(), 
                                                                                      txtDrugRegistrationTypesName.Text.ToString()});
                    lvwDrugRegistrationTypes.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwDrugRegistrationTypes.SelectedItems[0];
                    itmX.SubItems[colDrugRegistrationTypesName.Index].Text = txtDrugRegistrationTypesName.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDrugRegistrationTypesList()
        {
            try
            {

                CDrugRegistrationTypes objDrugRegistrationTypes = new CDrugRegistrationTypes();

                ArrayList ar = new ArrayList(objDrugRegistrationTypes.GetList());
                this.lvwDrugRegistrationTypes.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CDrugRegistrationTypes DrugRegistrationTypes in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      DrugRegistrationTypes.Id.ToString(), 
                                                                                      DrugRegistrationTypes.Name.ToString()});
                    this.lvwDrugRegistrationTypes.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmDrugRegistrationTypes_Load(object sender, EventArgs e)
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
        private void frmDrugRegistrationTypes_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillDrugRegistrationTypesList();
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
        private void btnSaveDrugRegistrationTypes_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveDrugRegistrationTypes();

                if (bSaved)
                {
                    UpdateDrugRegistrationTypesList();
                    NewDrugRegistrationTypes();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteDrugRegistrationTypes_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CDrugRegistrationTypes objDrugRegistrationTypes = new CDrugRegistrationTypes();
                    objDrugRegistrationTypes.Id = Convert.ToInt32(lvwDrugRegistrationTypes.SelectedItems[0].SubItems[colDrugRegistrationTypesId.Index].Text);
                    objDrugRegistrationTypes.Delete();
                    lvwDrugRegistrationTypes.Items.Remove(lvwDrugRegistrationTypes.SelectedItems[0]);

                    NewDrugRegistrationTypes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewDrugRegistrationTypes_Click(object sender, EventArgs e)
        {
            try
            {
                bNewDrugRegistrationTypes = true;
                DrugRegistrationTypesId = 0;
                NewDrugRegistrationTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwDrugRegistrationTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwDrugRegistrationTypes.SelectedItems == null) return;
                if (lvwDrugRegistrationTypes.SelectedItems.Count <= 0) return;
                EditDrugRegistrationTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchDrugRegistrationTypes_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.DrugRegistrationTypesId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindDrugRegistrationTypes();
        }
        private void btnFindDrugRegistrationTypes_Click(object sender, EventArgs e)
        {
            try
            {
                FindDrugRegistrationTypes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
