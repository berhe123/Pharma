//
// ...
// Wizard generated code
// Date: 8/11/2009 6:37:50 PM
// Class: frmBanks
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
    public partial class frmBanks : Form
    {
        private const string DialogCaption = "Bank Maintenance";

        private bool bNewBanks = true;
        private int BanksId = 0;
        private bool already_in = false;

        public frmBanks()
        {
            InitializeComponent();
        }
        private bool IsValidBanks()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtBanksName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewBanks()
        {
            try
            {
                bNewBanks = true;
                BanksId = 0;
                txtBanksName.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveBanks()
        {
            try
            {
                if (!IsValidBanks()) return false;

                CBanks objBanks = new CBanks();

                objBanks.Id = BanksId;
                objBanks.Name = Convert.ToString(txtBanksName.Text);

                if (objBanks.Exists(bNewBanks) > 0)
                {
                    MessageBox.Show("There exists a bank record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewBanks)
                    objBanks.Insert();
                else
                    objBanks.Update();

                BanksId = objBanks.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindBanks()
        {
            try
            {
                CBanks objBanks = new CBanks();
                DataTable dt = new DataTable();

                objBanks.Id = BanksId;
                dt = objBanks.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    BanksId = objBanks.Id;
                    txtBanksName.Text = Convert.ToString(objBanks.Name);

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
        private void EditBanks()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwBanks.SelectedItems[0];

                bNewBanks = false;
                BanksId = Convert.ToInt32(itmX.SubItems[colBanksId.Index].Text);
                txtBanksName.Text = Convert.ToString(itmX.SubItems[colBanksName.Index].Text);

                //this.FindBanks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateBanksList()
        {
            try
            {
                if (bNewBanks)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {BanksId.ToString(), 
                                                                                      txtBanksName.Text.ToString()});
                    lvwBanks.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwBanks.SelectedItems[0];
                    itmX.SubItems[colBanksName.Index].Text = txtBanksName.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillBanksList()
        {
            try
            {

                CBanks objBanks = new CBanks();

                ArrayList ar = new ArrayList(objBanks.GetList());
                this.lvwBanks.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CBanks Banks in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      Banks.Id.ToString(), 
                                                                                      Banks.Name.ToString()});
                    this.lvwBanks.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmBanks_Load(object sender, EventArgs e)
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
        private void frmBanks_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillBanksList();
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
        private void btnSaveBanks_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveBanks();

                if (bSaved)
                {
                    UpdateBanksList();
                    NewBanks();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteBanks_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CBanks objBanks = new CBanks();
                    objBanks.Id = Convert.ToInt32(lvwBanks.SelectedItems[0].SubItems[colBanksId.Index].Text);
                    objBanks.Delete();
                    lvwBanks.Items.Remove(lvwBanks.SelectedItems[0]);

                    NewBanks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewBanks_Click(object sender, EventArgs e)
        {
            try
            {
                bNewBanks = true;
                BanksId = 0;
                NewBanks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwBanks_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwBanks_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwBanks.SelectedItems == null) return;
                if (lvwBanks.SelectedItems.Count <= 0) return;
                EditBanks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnFindBanks_Click(object sender, EventArgs e)
        {
            try
            {
                FindBanks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
