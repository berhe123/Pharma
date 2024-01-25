//
// ...
// Wizard generated code
// Date: 7/29/2009 5:53:15 PM
// Class: frmStores
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
    public partial class frmStores : Form
    {
        private const string DialogCaption = "Store Maintenance";

        private bool bNewStores = true;
        private int StoresId = 0;
        private bool already_in = false;

        public frmStores()
        {
            InitializeComponent();
        }
        private bool IsValidStores()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(cboStoresLocationid, "Location can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtStoresName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewStores()
        {
            try
            {
                bNewStores = true;
                StoresId = 0;
                cboStoresLocationid.SelectedIndex = -1;
                txtStoresName.Text = String.Empty;
                txtStoresAddress.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveStores()
        {
            try
            {
                if (!IsValidStores()) return false;

                CStores objStores = new CStores();

                objStores.Id = StoresId;
                objStores.Locationguid = CCommon.GetItemData(cboStoresLocationid);
                objStores.Name = Convert.ToString(txtStoresName.Text);
                objStores.Address = Convert.ToString(txtStoresAddress.Text);

                if (objStores.Exists(bNewStores) > 0)
                {
                    MessageBox.Show("There exists a store record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewStores)
                    objStores.Insert();
                else
                    objStores.Update();

                StoresId = objStores.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindStores()
        {
            try
            {
                CStores objStores = new CStores();
                DataTable dt = new DataTable();

                objStores.Id = StoresId;
                dt = objStores.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    StoresId = objStores.Id;
                    cboStoresLocationid.SelectedIndex = CCommon.GetIndexByItemData(cboStoresLocationid, objStores.Locationguid.ToString(), true);
                    txtStoresName.Text = Convert.ToString(objStores.Name);
                    txtStoresAddress.Text = Convert.ToString(objStores.Address);

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
        private void EditStores()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwStores.SelectedItems[0];

                bNewStores = false;
                StoresId = Convert.ToInt32(itmX.SubItems[colStoresId.Index].Text);
                cboStoresLocationid.SelectedIndex = CCommon.GetIndexByItemData(cboStoresLocationid, itmX.SubItems[colStoresLocationGuid.Index].Text, true);
                txtStoresName.Text = Convert.ToString(itmX.SubItems[colStoresName.Index].Text);
                txtStoresAddress.Text = Convert.ToString(itmX.SubItems[colStoresAddress.Index].Text);

                //this.FindStores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateStoresList()
        {
            try
            {
                if (bNewStores)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {StoresId.ToString(), 
                                                                                      CCommon.GetItemData(cboStoresLocationid), 
                                                                                      cboStoresLocationid.Text.ToString(),
                                                                                      txtStoresName.Text.ToString(), 
                                                                                      txtStoresAddress.Text.ToString()});
                    lvwStores.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwStores.SelectedItems[0];
                    itmX.SubItems[colStoresLocationGuid.Index].Text = CCommon.GetItemData(cboStoresLocationid);
                    itmX.SubItems[colStoresLocation.Index].Text = cboStoresLocationid.Text.ToString();
                    itmX.SubItems[colStoresName.Index].Text = txtStoresName.Text.ToString();
                    itmX.SubItems[colStoresAddress.Index].Text = txtStoresAddress.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillStoresList()
        {
            try
            {

                CStores objStores = new CStores();

                ArrayList ar = new ArrayList(objStores.GetList());
                this.lvwStores.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CStores Stores in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Stores.Id.ToString(), 
                                                                                      Stores.Locationguid.ToString(), 
                                                                                      CLocations.GetLocationNameFromCollection(Stores.Locationguid), 
                                                                                      Stores.Name.ToString(), 
                                                                                      Stores.Address.ToString()});
                    this.lvwStores.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmStores_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = null;
                CCommon.FillComboBox(cboStoresLocationid, "Select * from tblLocations Order by Name", "TableRowGuid", "Name");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmStores_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillStoresList();
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
        private void btnSaveStores_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveStores();

                if (bSaved)
                {
                    UpdateStoresList();
                    NewStores();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteStores_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CStores objStores = new CStores();
                    objStores.Id = Convert.ToInt32(lvwStores.SelectedItems[0].SubItems[colStoresId.Index].Text);
                    objStores.Delete();
                    lvwStores.Items.Remove(lvwStores.SelectedItems[0]);

                    NewStores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewStores_Click(object sender, EventArgs e)
        {
            try
            {
                bNewStores = true;
                StoresId = 0;
                NewStores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwStores_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwStores.SelectedItems == null) return;
                if (lvwStores.SelectedItems.Count <= 0) return;
                EditStores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchStores_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.StoresId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindStores();
        }
        private void btnFindStores_Click(object sender, EventArgs e)
        {
            try
            {
                FindStores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
