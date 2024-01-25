//
// ...
// Wizard generated code
// Date: 7/29/2009 5:27:44 PM
// Class: frmTermsOfContractTemplates
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
    public partial class frmTermsOfContractTemplates : Form
    {
        private const string DialogCaption = "Terms of Contract Template Maintenance";
        private bool bNewTermsOfContractTemplates = true;
        private int TermsOfContractTemplatesId = 0;
        private bool already_in = false;

        public frmTermsOfContractTemplates()
        {
            InitializeComponent();
        }
        private bool IsValidTermsOfContractTemplates()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtTermsOfContractTemplatesTemplatename, "Template name can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtTermsOfContractTemplatesTemplatecontent, "Template content can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewTermsOfContractTemplates()
        {
            try
            {
                bNewTermsOfContractTemplates = true;
                TermsOfContractTemplatesId = 0;
                txtTermsOfContractTemplatesTemplatename.Text = String.Empty;
                txtTermsOfContractTemplatesTemplatecontent.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveTermsOfContractTemplates()
        {
            try
            {
                if (!IsValidTermsOfContractTemplates()) return false;

                CTermsOfContractTemplates objTermsOfContractTemplates = new CTermsOfContractTemplates();

                objTermsOfContractTemplates.Id = TermsOfContractTemplatesId;
                objTermsOfContractTemplates.Templatename = Convert.ToString(txtTermsOfContractTemplatesTemplatename.Text);
                objTermsOfContractTemplates.Templatecontent = Convert.ToString(txtTermsOfContractTemplatesTemplatecontent.Text);

                if (objTermsOfContractTemplates.Exists(bNewTermsOfContractTemplates) > 0)
                {
                    MessageBox.Show("There exists a terms of contract template record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewTermsOfContractTemplates)
                    objTermsOfContractTemplates.Insert();
                else
                    objTermsOfContractTemplates.Update();

                TermsOfContractTemplatesId = objTermsOfContractTemplates.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindTermsOfContractTemplates()
        {
            try
            {
                CTermsOfContractTemplates objTermsOfContractTemplates = new CTermsOfContractTemplates();
                DataTable dt = new DataTable();

                objTermsOfContractTemplates.Id = TermsOfContractTemplatesId;
                dt = objTermsOfContractTemplates.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    TermsOfContractTemplatesId = objTermsOfContractTemplates.Id;
                    txtTermsOfContractTemplatesTemplatename.Text = Convert.ToString(objTermsOfContractTemplates.Templatename);
                    txtTermsOfContractTemplatesTemplatecontent.Text = Convert.ToString(objTermsOfContractTemplates.Templatecontent);

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
        private void EditTermsOfContractTemplates()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwTermsOfContractTemplates.SelectedItems[0];

                bNewTermsOfContractTemplates = false;
                TermsOfContractTemplatesId = Convert.ToInt32(itmX.SubItems[colTermsOfContractTemplatesId.Index].Text);
                txtTermsOfContractTemplatesTemplatename.Text = Convert.ToString(itmX.SubItems[colTermsOfContractTemplatesTemplatename.Index].Text);
                txtTermsOfContractTemplatesTemplatecontent.Text = Convert.ToString(itmX.SubItems[colTermsOfContractTemplatesTemplatecontent.Index].Text);

                //this.FindTermsOfContractTemplates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTermsOfContractTemplatesList()
        {
            try
            {
                if (bNewTermsOfContractTemplates)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {TermsOfContractTemplatesId.ToString(), 
                                                                                      txtTermsOfContractTemplatesTemplatename.Text.ToString(), 
                                                                                      txtTermsOfContractTemplatesTemplatecontent.Text.ToString()});
                    lvwTermsOfContractTemplates.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwTermsOfContractTemplates.SelectedItems[0];
                    itmX.SubItems[colTermsOfContractTemplatesTemplatename.Index].Text = txtTermsOfContractTemplatesTemplatename.Text.ToString();
                    itmX.SubItems[colTermsOfContractTemplatesTemplatecontent.Index].Text = txtTermsOfContractTemplatesTemplatecontent.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillTermsOfContractTemplatesList()
        {
            try
            {

                CTermsOfContractTemplates objTermsOfContractTemplates = new CTermsOfContractTemplates();

                ArrayList ar = new ArrayList(objTermsOfContractTemplates.GetList());
                this.lvwTermsOfContractTemplates.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CTermsOfContractTemplates TermsOfContractTemplates in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      TermsOfContractTemplates.Id.ToString(), 
                                                                                      TermsOfContractTemplates.Templatename.ToString(), 
                                                                                      TermsOfContractTemplates.Templatecontent.ToString()});
                    this.lvwTermsOfContractTemplates.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTermsOfContractTemplates_Load(object sender, EventArgs e)
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
        private void frmTermsOfContractTemplates_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillTermsOfContractTemplatesList();
                    lblMsg.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveTermsOfContractTemplates_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveTermsOfContractTemplates();

                if (bSaved)
                {
                    UpdateTermsOfContractTemplatesList();
                    NewTermsOfContractTemplates();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteTermsOfContractTemplates_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CTermsOfContractTemplates objTermsOfContractTemplates = new CTermsOfContractTemplates();
                    objTermsOfContractTemplates.Id = Convert.ToInt32(lvwTermsOfContractTemplates.SelectedItems[0].SubItems[colTermsOfContractTemplatesId.Index].Text);
                    objTermsOfContractTemplates.Delete();
                    lvwTermsOfContractTemplates.Items.Remove(lvwTermsOfContractTemplates.SelectedItems[0]);

                    NewTermsOfContractTemplates();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewTermsOfContractTemplates_Click(object sender, EventArgs e)
        {
            try
            {
                bNewTermsOfContractTemplates = true;
                TermsOfContractTemplatesId = 0;
                NewTermsOfContractTemplates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwTermsOfContractTemplates_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwTermsOfContractTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwTermsOfContractTemplates.SelectedItems == null) return;
                if (lvwTermsOfContractTemplates.SelectedItems.Count <= 0) return;
                EditTermsOfContractTemplates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchTermsOfContractTemplates_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.TermsOfContractTemplatesId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindTermsOfContractTemplates();
        }
        private void btnFindTermsOfContractTemplates_Click(object sender, EventArgs e)
        {
            try
            {
                FindTermsOfContractTemplates();
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
    }
}
