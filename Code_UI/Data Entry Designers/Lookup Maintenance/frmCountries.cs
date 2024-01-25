//
// ...
// Wizard generated code
// Date: 7/29/2009 12:26:12 PM
// Class: frmCountries
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
    public partial class frmCountries : Form
    {
        private const string DialogCaption = "Country Maintenance";

        private bool bNewCountries = true;
        private int CountriesId = 0;
        private bool already_in = false;

        public frmCountries()
        {
            InitializeComponent();
        }
        private bool IsValidCountries()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtCountriesCode, "Code can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtCountriesShortname, "Short name can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtCountriesName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewCountries()
        {
            try
            {
                bNewCountries = true;
                CountriesId = 0;
                txtCountriesCode.Text = String.Empty;
                txtCountriesShortname.Text = String.Empty;
                txtCountriesName.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveCountries()
        {
            try
            {
                if (!IsValidCountries()) return false;

                CCountries objCountries = new CCountries();

                objCountries.Id = CountriesId;
                objCountries.Code = Convert.ToString(txtCountriesCode.Text);
                objCountries.Shortname = Convert.ToString(txtCountriesShortname.Text);
                objCountries.Name = Convert.ToString(txtCountriesName.Text);

                if (objCountries.Exists(bNewCountries) > 0)
                {
                    MessageBox.Show("There exists a country record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewCountries)
                    objCountries.Insert();
                else
                    objCountries.Update();

                CountriesId = objCountries.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindCountries()
        {
            try
            {
                CCountries objCountries = new CCountries();
                DataTable dt = new DataTable();

                objCountries.Id = CountriesId;
                dt = objCountries.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    CountriesId = objCountries.Id;
                    txtCountriesCode.Text = Convert.ToString(objCountries.Code);
                    txtCountriesShortname.Text = Convert.ToString(objCountries.Shortname);
                    txtCountriesName.Text = Convert.ToString(objCountries.Name);

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
        private void EditCountries()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwCountries.SelectedItems[0];

                bNewCountries = false;
                CountriesId = Convert.ToInt32(itmX.SubItems[colCountriesId.Index].Text);
                txtCountriesCode.Text = Convert.ToString(itmX.SubItems[colCountriesCode.Index].Text);
                txtCountriesShortname.Text = Convert.ToString(itmX.SubItems[colCountriesShortname.Index].Text);
                txtCountriesName.Text = Convert.ToString(itmX.SubItems[colCountriesName.Index].Text);

                //this.FindCountries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCountriesList()
        {
            try
            {
                if (bNewCountries)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {CountriesId.ToString(), 
                                                                                      txtCountriesCode.Text.ToString(), 
                                                                                      txtCountriesShortname.Text.ToString(), 
                                                                                      txtCountriesName.Text.ToString()});
                    lvwCountries.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwCountries.SelectedItems[0];
                    itmX.SubItems[colCountriesCode.Index].Text = txtCountriesCode.Text.ToString();
                    itmX.SubItems[colCountriesShortname.Index].Text = txtCountriesShortname.Text.ToString();
                    itmX.SubItems[colCountriesName.Index].Text = txtCountriesName.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillCountriesList()
        {
            try
            {

                CCountries objCountries = new CCountries();

                ArrayList ar = new ArrayList(objCountries.GetList());
                this.lvwCountries.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CCountries Countries in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      Countries.Id.ToString(), 
                                                                                      Countries.Code.ToString(), 
                                                                                      Countries.Shortname.ToString(), 
                                                                                      Countries.Name.ToString()});
                    this.lvwCountries.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCountries_Load(object sender, EventArgs e)
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
        private void frmCountries_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillCountriesList();
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
        private void btnSaveCountries_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveCountries();

                if (bSaved)
                {
                    UpdateCountriesList();
                    NewCountries();
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
                    CCountries objCountries = new CCountries();
                    objCountries.Id = Convert.ToInt32(lvwCountries.SelectedItems[0].SubItems[colCountriesId.Index].Text);
                    objCountries.Delete();
                    lvwCountries.Items.Remove(lvwCountries.SelectedItems[0]);

                    NewCountries();
                }
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
                bNewCountries = true;
                CountriesId = 0;
                NewCountries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwCountries_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwCountries.SelectedItems == null) return;
                if (lvwCountries.SelectedItems.Count <= 0) return;
                EditCountries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchCountries_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.CountriesId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindCountries();
        }
        private void btnFindCountries_Click(object sender, EventArgs e)
        {
            try
            {
                FindCountries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
