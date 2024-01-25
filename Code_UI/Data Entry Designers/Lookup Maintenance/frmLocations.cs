//
// ...
// Wizard generated code
// Date: 7/29/2009 4:48:49 PM
// Class: frmLocations
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
    public partial class frmLocations : Form
    {
        private const string DialogCaption = "Location Maintenace";

        private bool bNewLocations = true;
        private int LocationsId = 0;
        private bool already_in = false;

        public frmLocations()
        {
            InitializeComponent();
        }
        private bool IsValidLocations()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtLocationsName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewLocations()
        {
            try
            {
                bNewLocations = true;
                LocationsId = 0;
                txtLocationsName.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveLocations()
        {
            try
            {
                if (!IsValidLocations()) return false;

                CLocations objLocations = new CLocations();

                objLocations.Id = LocationsId;
                objLocations.Name = Convert.ToString(txtLocationsName.Text);

                if (objLocations.Exists(bNewLocations) > 0)
                {
                    MessageBox.Show("There exists a location record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewLocations)
                    objLocations.Insert();
                else
                    objLocations.Update();

                LocationsId = objLocations.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindLocations()
        {
            try
            {
                CLocations objLocations = new CLocations();
                DataTable dt = new DataTable();

                objLocations.Id = LocationsId;
                dt = objLocations.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    LocationsId = objLocations.Id;
                    txtLocationsName.Text = Convert.ToString(objLocations.Name);

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
        private void EditLocations()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwLocations.SelectedItems[0];

                bNewLocations = false;
                LocationsId = Convert.ToInt32(itmX.SubItems[colLocationsId.Index].Text);
                txtLocationsName.Text = Convert.ToString(itmX.SubItems[colLocationsName.Index].Text);

                //this.FindLocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateLocationsList()
        {
            try
            {
                if (bNewLocations)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {LocationsId.ToString(), 
                                                                                      txtLocationsName.Text.ToString()});
                    lvwLocations.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwLocations.SelectedItems[0];
                    itmX.SubItems[colLocationsName.Index].Text = txtLocationsName.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillLocationsList()
        {
            try
            {

                CLocations objLocations = new CLocations();

                ArrayList ar = new ArrayList(objLocations.GetList());
                this.lvwLocations.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLocations Locations in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      Locations.Id.ToString(), 
                                                                                      Locations.Name.ToString()});
                    this.lvwLocations.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmLocations_Load(object sender, EventArgs e)
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
        private void frmLocations_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillLocationsList();
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
        private void btnSaveLocations_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveLocations();

                if (bSaved)
                {
                    UpdateLocationsList();
                    NewLocations();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteLocations_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLocations objLocations = new CLocations();
                    objLocations.Id = Convert.ToInt32(lvwLocations.SelectedItems[0].SubItems[colLocationsId.Index].Text);
                    objLocations.Delete();
                    lvwLocations.Items.Remove(lvwLocations.SelectedItems[0]);

                    NewLocations();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewLocations_Click(object sender, EventArgs e)
        {
            try
            {
                bNewLocations = true;
                LocationsId = 0;
                NewLocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwLocations_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwLocations.SelectedItems == null) return;
                if (lvwLocations.SelectedItems.Count <= 0) return;
                EditLocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchLocations_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.LocationsId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindLocations();
        }
        private void btnFindLocations_Click(object sender, EventArgs e)
        {
            try
            {
                FindLocations();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
