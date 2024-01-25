//
// ...
// Wizard generated code
// Date: 7/29/2009 4:29:50 PM
// Class: frmItemCategories
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
    public partial class frmMakeOrganizations : Form
    {
        private const string DialogCaption = "Make Organizations Maintenance";

        private bool bNewItemCategories = true;
        private int makeorganizationsId = 0;
        private bool already_in = false;

        public frmMakeOrganizations()
        {
            InitializeComponent();
        }
        private bool IsValidItemCategories()
        {
            try
            {
            
                if (!CCommon.SetRequiredMessage(txtMakeOrganizations, "Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewItemCategories()
        {
            try
            {
                bNewItemCategories = true;
                makeorganizationsId = 0;
                txtMakeOrganizations.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveItemCategories()
        {
            try
            {
                if (!IsValidItemCategories()) 
                    return false;

                CMakeOrganizations objItemCategories = new CMakeOrganizations();

                objItemCategories.Id = makeorganizationsId;
                objItemCategories.Name = Convert.ToString(txtMakeOrganizations.Text);

                if (objItemCategories.Exists(bNewItemCategories) > 0)
                {
                    MessageBox.Show("There exists an item category record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewItemCategories)
                    objItemCategories.Insert();
                else
                    objItemCategories.Update();

                makeorganizationsId = objItemCategories.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindItemCategories()
        {
            try
            {
                CMakeOrganizations objItemCategories = new CMakeOrganizations();
                DataTable dt = new DataTable();

                objItemCategories.Id = makeorganizationsId;
                dt = objItemCategories.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    makeorganizationsId = objItemCategories.Id;
                    txtMakeOrganizations.Text = Convert.ToString(objItemCategories.Name);

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
        private void EditItemCategories()
        {
            try
            {
                CMakeOrganizations objItemCategories = new CMakeOrganizations();
                DataTable dt = new DataTable();
                ListViewItem itmX = new ListViewItem();
                itmX = lvwMakeOrganizations.SelectedItems[0];

                bNewItemCategories = false;
                makeorganizationsId = Convert.ToInt32(itmX.SubItems[colMakeOrganizationsId.Index].Text);
                txtMakeOrganizations.Text = Convert.ToString(itmX.SubItems[colMakeOrganizationsName.Index].Text);

                //this.FindItemCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateItemCategoriesList()
        {
            try
            {
                if (bNewItemCategories)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {makeorganizationsId.ToString(), 
                                                                       txtMakeOrganizations.Text.ToString()});
                    lvwMakeOrganizations.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwMakeOrganizations.SelectedItems[0];
                    itmX.SubItems[colMakeOrganizationsName.Index].Text = txtMakeOrganizations.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillItemCategoriesList()
        {
            try
            {

                CMakeOrganizations objItemCategories = new CMakeOrganizations();

                ArrayList ar = new ArrayList(objItemCategories.GetList());
                this.lvwMakeOrganizations.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CMakeOrganizations ItemCategories in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ItemCategories.Id.ToString(), 
                                                                       ItemCategories.Name.ToString()});
                    this.lvwMakeOrganizations.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
       
        private void btnSearchItemCategories_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.ItemCategoriesId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindItemCategories();
        }
        private void btnFindItemCategories_Click(object sender, EventArgs e)
        {
            try
            {
                FindItemCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewCountries_Click(object sender, EventArgs e)
        {
            try
            {
                bNewItemCategories = true;
                makeorganizationsId = 0;
                NewItemCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveCountries_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveItemCategories();

                if (bSaved)
                {
                    UpdateItemCategoriesList();
                    NewItemCategories();
                };
              
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

        private void btnDeleteCountries_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CMakeOrganizations objItemCategories = new CMakeOrganizations();
                    objItemCategories.Id = Convert.ToInt32(lvwMakeOrganizations.SelectedItems[0].SubItems[colMakeOrganizationsId.Index].Text);
                    objItemCategories.Delete();
                    lvwMakeOrganizations.Items.Remove(lvwMakeOrganizations.SelectedItems[0]);

                    NewItemCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwMakeOrganizations_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwMakeOrganizations.SelectedItems == null) return;
                if (lvwMakeOrganizations.SelectedItems.Count <= 0) return;
                EditItemCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMakeOrganizations_Load(object sender, EventArgs e)
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

        private void frmMakeOrganizations_Activated(object sender, EventArgs e)
        
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillItemCategoriesList();
                    lblMsg.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

       

       
    }
}
