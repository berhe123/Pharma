//
// ...
// Wizard generated code
// Date: 10/21/2009 3:52:55 PM
// Class: frmDosageForms
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
    public partial class frmDosageForms : Form
    {
        private const string DialogCaption = "Dosage Form Maintenance";

        private bool bNewDosageForms = true;
        private int DosageFormsId = 0;
        private bool already_in = false;

        public frmDosageForms()
        {
            InitializeComponent();
        }
        private bool IsValidDosageForms()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtDosageFormsName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewDosageForms()
        {
            try
            {
                bNewDosageForms = true;
                DosageFormsId = 0;
                txtDosageFormsName.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveDosageForms()
        {
            try
            {
                if (!IsValidDosageForms()) return false;

                CDosageForms objDosageForms = new CDosageForms();

                objDosageForms.Id = DosageFormsId;
                objDosageForms.Name = Convert.ToString(txtDosageFormsName.Text);

                if (objDosageForms.Exists(bNewDosageForms) > 0)
                {
                    MessageBox.Show("There exists a dosage form with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewDosageForms)
                    objDosageForms.Insert();
                else
                    objDosageForms.Update();

                DosageFormsId = objDosageForms.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindDosageForms()
        {
            CDosageForms objDosageForms = new CDosageForms();
            DataTable dt = new DataTable();
            try
            {
                objDosageForms.Id = DosageFormsId;
                dt = objDosageForms.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    DosageFormsId = objDosageForms.Id;
                    txtDosageFormsName.Text = Convert.ToString(objDosageForms.Name);

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
        private void EditDosageForms()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwDosageForms.SelectedItems[0];

                bNewDosageForms = false;
                DosageFormsId = Convert.ToInt32(itmX.SubItems[colDosageFormsId.Index].Text);
                txtDosageFormsName.Text = Convert.ToString(itmX.SubItems[colDosageFormsName.Index].Text);

                //this.FindDosageForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDosageFormsList()
        {
            try
            {
                if (bNewDosageForms)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {DosageFormsId.ToString(), 
                                                                                      txtDosageFormsName.Text.ToString()});
                    lvwDosageForms.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwDosageForms.SelectedItems[0];
                    itmX.SubItems[colDosageFormsName.Index].Text = txtDosageFormsName.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDosageFormsList()
        {
            try
            {

                CDosageForms objDosageForms = new CDosageForms();

                ArrayList ar = new ArrayList(objDosageForms.GetList());
                this.lvwDosageForms.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CDosageForms DosageForms in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      DosageForms.Id.ToString(), 
                                                                                      DosageForms.Name.ToString()});
                    this.lvwDosageForms.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmDosageForms_Load(object sender, EventArgs e)
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
        private void frmDosageForms_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillDosageFormsList();
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
        private void btnSaveDosageForms_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveDosageForms();

                if (bSaved)
                {
                    UpdateDosageFormsList();
                    NewDosageForms();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteDosageForms_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CDosageForms objDosageForms = new CDosageForms();
                    objDosageForms.Id = Convert.ToInt32(lvwDosageForms.SelectedItems[0].SubItems[colDosageFormsId.Index].Text);
                    objDosageForms.Delete();
                    lvwDosageForms.Items.Remove(lvwDosageForms.SelectedItems[0]);

                    NewDosageForms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewDosageForms_Click(object sender, EventArgs e)
        {
            try
            {
                bNewDosageForms = true;
                DosageFormsId = 0;
                NewDosageForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwDosageForms_DoubleClick(object sender, EventArgs e)
        {
        }
        private void lvwDosageForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwDosageForms.SelectedItems == null) return;
                if (lvwDosageForms.SelectedItems.Count <= 0) return;
                EditDosageForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchDosageForms_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.DosageFormsId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindDosageForms();
        }
        private void btnFindDosageForms_Click(object sender, EventArgs e)
        {
            try
            {
                FindDosageForms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
