//
// ...
// Wizard generated code
// Date: 8/11/2009 6:37:50 PM
// Class: frmDeliveryPersons
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
    public partial class frmDeliveryPersons : Form
    {
        private const string DialogCaption = "Delivery Person Maintenance";

        private bool bNewDeliveryPersons = true;
        private int DeliveryPersonsId = 0;
        private bool already_in = false;

        public frmDeliveryPersons()
        {
            InitializeComponent();
        }
        private bool IsValidDeliveryPersons()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtDeliveryPersonsName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewDeliveryPersons()
        {
            try
            {
                bNewDeliveryPersons = true;
                DeliveryPersonsId = 0;
                txtDeliveryPersonsName.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveDeliveryPersons()
        {
            try
            {
                if (!IsValidDeliveryPersons()) return false;

                CDeliveryPersons objDeliveryPersons = new CDeliveryPersons();

                objDeliveryPersons.Id = DeliveryPersonsId;
                objDeliveryPersons.Name = Convert.ToString(txtDeliveryPersonsName.Text);

                if (objDeliveryPersons.Exists(bNewDeliveryPersons) > 0)
                {
                    MessageBox.Show("There exists a bank record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewDeliveryPersons)
                    objDeliveryPersons.Insert();
                else
                    objDeliveryPersons.Update();

                DeliveryPersonsId = objDeliveryPersons.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindDeliveryPersons()
        {
            try
            {
                CDeliveryPersons objDeliveryPersons = new CDeliveryPersons();
                DataTable dt = new DataTable();

                objDeliveryPersons.Id = DeliveryPersonsId;
                dt = objDeliveryPersons.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    DeliveryPersonsId = objDeliveryPersons.Id;
                    txtDeliveryPersonsName.Text = Convert.ToString(objDeliveryPersons.Name);

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
        private void EditDeliveryPersons()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwDeliveryPersons.SelectedItems[0];

                bNewDeliveryPersons = false;
                DeliveryPersonsId = Convert.ToInt32(itmX.SubItems[colDeliveryPersonsId.Index].Text);
                txtDeliveryPersonsName.Text = Convert.ToString(itmX.SubItems[colDeliveryPersonsName.Index].Text);

                //this.FindDeliveryPersons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDeliveryPersonsList()
        {
            try
            {
                if (bNewDeliveryPersons)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {DeliveryPersonsId.ToString(), 
                                                                                      txtDeliveryPersonsName.Text.ToString()});
                    lvwDeliveryPersons.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwDeliveryPersons.SelectedItems[0];
                    itmX.SubItems[colDeliveryPersonsName.Index].Text = txtDeliveryPersonsName.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillDeliveryPersonsList()
        {
            try
            {

                CDeliveryPersons objDeliveryPersons = new CDeliveryPersons();

                ArrayList ar = new ArrayList(objDeliveryPersons.GetList());
                this.lvwDeliveryPersons.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CDeliveryPersons DeliveryPersons in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      DeliveryPersons.Id.ToString(), 
                                                                                      DeliveryPersons.Name.ToString()});
                    this.lvwDeliveryPersons.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmDeliveryPersons_Load(object sender, EventArgs e)
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
        private void frmDeliveryPersons_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillDeliveryPersonsList();
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
        private void btnSaveDeliveryPersons_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveDeliveryPersons();

                if (bSaved)
                {
                    UpdateDeliveryPersonsList();
                    NewDeliveryPersons();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteDeliveryPersons_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CDeliveryPersons objDeliveryPersons = new CDeliveryPersons();
                    objDeliveryPersons.Id = Convert.ToInt32(lvwDeliveryPersons.SelectedItems[0].SubItems[colDeliveryPersonsId.Index].Text);
                    objDeliveryPersons.Delete();
                    lvwDeliveryPersons.Items.Remove(lvwDeliveryPersons.SelectedItems[0]);

                    NewDeliveryPersons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewDeliveryPersons_Click(object sender, EventArgs e)
        {
            try
            {
                bNewDeliveryPersons = true;
                DeliveryPersonsId = 0;
                NewDeliveryPersons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwDeliveryPersons_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwDeliveryPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwDeliveryPersons.SelectedItems == null) return;
                if (lvwDeliveryPersons.SelectedItems.Count <= 0) return;
                EditDeliveryPersons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnFindDeliveryPersons_Click(object sender, EventArgs e)
        {
            try
            {
                FindDeliveryPersons();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
