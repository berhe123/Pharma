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
    public partial class frmModel : Form
    {
        private const string DialogCaption = "Item Category Maintenance";

        private bool bNewItemCategories = true;
        private int ItemCategoriesId = 0;
        private bool already_in = false;

        public frmModel()
        {
            InitializeComponent();
        }
        private bool IsValidItemCategories()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtModelName, "Name can not be empty", mValidator, lblMsg))
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
                ItemCategoriesId = 0;
                txtModelName.Text = String.Empty;

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
                if (!IsValidItemCategories()) return false;

                CModel objItemCategories = new CModel();

                objItemCategories.Id = ItemCategoriesId;
                objItemCategories.Name = Convert.ToString(txtModelName.Text);

                if (objItemCategories.Exists(bNewItemCategories) > 0)
                {
                    MessageBox.Show("There exists an item category record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewItemCategories)
                    objItemCategories.Insert();
                else
                    objItemCategories.Update();

                ItemCategoriesId = objItemCategories.Id;
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
                CModel objItemCategories = new CModel();
                DataTable dt = new DataTable();

                objItemCategories.Id = ItemCategoriesId;
                dt = objItemCategories.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    ItemCategoriesId = objItemCategories.Id;
                    txtModelName.Text = Convert.ToString(objItemCategories.Name);

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
                ListViewItem itmX = new ListViewItem();
                itmX = lvwModel.SelectedItems[0];

                bNewItemCategories = false;
                ItemCategoriesId = Convert.ToInt32(itmX.SubItems[colModelId.Index].Text);
                txtModelName.Text = Convert.ToString(itmX.SubItems[colModelName.Index].Text);

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
                    ListViewItem itmX = new ListViewItem(new string[] {ItemCategoriesId.ToString(), 
                                                                       txtModelName.Text.ToString()});
                    lvwModel.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwModel.SelectedItems[0];
                    itmX.SubItems[colModelName.Index].Text = txtModelName.Text.ToString();
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

                CModel objItemCategories = new CModel();

                ArrayList ar = new ArrayList(objItemCategories.GetList());
                this.lvwModel.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CModel ItemCategories in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ItemCategories.Id.ToString(), 
                                                                       ItemCategories.Name.ToString()});
                    this.lvwModel.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
       
            
       
        private void lvwItemCategories_DoubleClick(object sender, EventArgs e)
        {
            //
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
                ItemCategoriesId = 0;
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

        private void btnDeleteCountries_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CModel objItemCategories = new CModel();
                    objItemCategories.Id = Convert.ToInt32(lvwModel.SelectedItems[0].SubItems[colModelId.Index].Text);
                    objItemCategories.Delete();
                    lvwModel.Items.Remove(lvwModel.SelectedItems[0]);

                    NewItemCategories();
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

        private void lvwModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwModel.SelectedItems == null) return;
                if (lvwModel.SelectedItems.Count <= 0) return;
                else
                {
                    EditItemCategories();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtModelName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmModel_Load(object sender, EventArgs e)
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

        private void frmModel_Activated(object sender, EventArgs e)
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
