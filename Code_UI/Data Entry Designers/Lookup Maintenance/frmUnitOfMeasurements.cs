//
// ...
// Wizard generated code
// Date: 7/29/2009 4:29:50 PM
// Class: frmUnitOfMeasurements
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
    public partial class frmUnitOfMeasurements : Form
    {
        private const string DialogCaption = "Unit of Measurement Maintenance";

        private bool bNewUnitOfMeasurements = true;
        private int UnitOfMeasurementsId = 0;
        private bool already_in = false;

        public frmUnitOfMeasurements()
        {
            InitializeComponent();
        }
        private bool IsValidUnitOfMeasurements()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtUnitOfMeasurementsName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewUnitOfMeasurements()
        {
            try
            {
                bNewUnitOfMeasurements = true;
                UnitOfMeasurementsId = 0;
                txtUnitOfMeasurementsName.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveUnitOfMeasurements()
        {
            try
            {
                if (!IsValidUnitOfMeasurements()) return false;

                CUnitOfMeasurements objUnitOfMeasurements = new CUnitOfMeasurements();

                objUnitOfMeasurements.Id = UnitOfMeasurementsId;
                objUnitOfMeasurements.Name = Convert.ToString(txtUnitOfMeasurementsName.Text);

                if (objUnitOfMeasurements.Exists(bNewUnitOfMeasurements) > 0)
                {
                    MessageBox.Show("There exists a unit of measurement record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewUnitOfMeasurements)
                    objUnitOfMeasurements.Insert();
                else
                    objUnitOfMeasurements.Update();

                UnitOfMeasurementsId = objUnitOfMeasurements.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindUnitOfMeasurements()
        {
            try
            {
                CUnitOfMeasurements objUnitOfMeasurements = new CUnitOfMeasurements();
                DataTable dt = new DataTable();

                objUnitOfMeasurements.Id = UnitOfMeasurementsId;
                dt = objUnitOfMeasurements.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    UnitOfMeasurementsId = objUnitOfMeasurements.Id;
                    txtUnitOfMeasurementsName.Text = Convert.ToString(objUnitOfMeasurements.Name);

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
        private void EditUnitOfMeasurements()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwUnitOfMeasurements.SelectedItems[0];

                bNewUnitOfMeasurements = false;
                UnitOfMeasurementsId = Convert.ToInt32(itmX.SubItems[colUnitOfMeasurementsId.Index].Text);
                txtUnitOfMeasurementsName.Text = Convert.ToString(itmX.SubItems[colUnitOfMeasurementsName.Index].Text);

                //this.FindUnitOfMeasurements();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateUnitOfMeasurementsList()
        {
            try
            {
                if (bNewUnitOfMeasurements)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {UnitOfMeasurementsId.ToString(), 
                                                                                      txtUnitOfMeasurementsName.Text.ToString()});
                    lvwUnitOfMeasurements.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwUnitOfMeasurements.SelectedItems[0];
                    itmX.SubItems[colUnitOfMeasurementsName.Index].Text = txtUnitOfMeasurementsName.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillUnitOfMeasurementsList()
        {
            try
            {

                CUnitOfMeasurements objUnitOfMeasurements = new CUnitOfMeasurements();

                ArrayList ar = new ArrayList(objUnitOfMeasurements.GetList());
                this.lvwUnitOfMeasurements.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CUnitOfMeasurements UnitOfMeasurements in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      UnitOfMeasurements.Id.ToString(), 
                                                                                      UnitOfMeasurements.Name.ToString()});
                    this.lvwUnitOfMeasurements.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmUnitOfMeasurements_Load(object sender, EventArgs e)
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
        private void frmUnitOfMeasurements_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillUnitOfMeasurementsList();
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
        private void btnSaveUnitOfMeasurements_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveUnitOfMeasurements();

                if (bSaved)
                {
                    UpdateUnitOfMeasurementsList();
                    NewUnitOfMeasurements();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteUnitOfMeasurements_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CUnitOfMeasurements objUnitOfMeasurements = new CUnitOfMeasurements();
                    objUnitOfMeasurements.Id = Convert.ToInt32(lvwUnitOfMeasurements.SelectedItems[0].SubItems[colUnitOfMeasurementsId.Index].Text);
                    objUnitOfMeasurements.Delete();
                    lvwUnitOfMeasurements.Items.Remove(lvwUnitOfMeasurements.SelectedItems[0]);

                    NewUnitOfMeasurements();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewUnitOfMeasurements_Click(object sender, EventArgs e)
        {
            try
            {
                bNewUnitOfMeasurements = true;
                UnitOfMeasurementsId = 0;
                NewUnitOfMeasurements();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwUnitOfMeasurements_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwUnitOfMeasurements_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwUnitOfMeasurements.SelectedItems == null) return;
                if (lvwUnitOfMeasurements.SelectedItems.Count <= 0) return;
                EditUnitOfMeasurements();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchUnitOfMeasurements_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.UnitOfMeasurementsId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindUnitOfMeasurements();
        }
        private void btnFindUnitOfMeasurements_Click(object sender, EventArgs e)
        {
            try
            {
                FindUnitOfMeasurements();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
