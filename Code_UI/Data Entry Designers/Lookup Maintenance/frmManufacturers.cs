//
// ...
// Wizard generated code
// Date: 7/29/2009 2:35:22 PM
// Class: frmManufacturers
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
    public partial class frmManufacturers : Form
    {
        private const string DialogCaption = "Supplier Maintenance";

        private bool bNewManufacturers = true;
        private int ManufacturersId = 0;
        private bool already_in = false;

        public frmManufacturers()
        {
            InitializeComponent();
        }
        private bool IsValidManufacturers()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtManufacturersName, "Name can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtManufacturersTel1, "Manufacturer Tel can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewManufacturers()
        {
            try
            {
                bNewManufacturers = true;
                ManufacturersId = 0;
                txtManufacturersName.Text = String.Empty;
                txtManufacturersTIN.Text = String.Empty;
                txtManufacturersMailingaddress.Text = String.Empty;
                txtManufacturersFax.Text = String.Empty;
                txtManufacturersTel1.Text = String.Empty;
                txtManufacturersTel2.Text = String.Empty;
                txtManufacturersEmail.Text = String.Empty;
                txtManufacturersContactname.Text = String.Empty;
                txtManufacturersContactfax.Text = String.Empty;
                txtManufacturersContacttel1.Text = String.Empty;
                txtManufacturersContacttel2.Text = String.Empty;
                txtManufacturersContactemail.Text = String.Empty;               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveManufacturers()
        {
            try
            {
                if (!IsValidManufacturers()) return false;

                CManufacturers objManufacturers = new CManufacturers();

                objManufacturers.Id = ManufacturersId;
                objManufacturers.Name = Convert.ToString(txtManufacturersName.Text);
                objManufacturers.TIN = Convert.ToString(txtManufacturersTIN.Text);
                objManufacturers.Mailingaddress = Convert.ToString(txtManufacturersMailingaddress.Text);
                objManufacturers.Fax = Convert.ToString(txtManufacturersFax.Text);
                objManufacturers.Tel1 = Convert.ToString(txtManufacturersTel1.Text);
                objManufacturers.Tel2 = Convert.ToString(txtManufacturersTel2.Text);
                objManufacturers.Email = Convert.ToString(txtManufacturersEmail.Text);
                objManufacturers.Contactname = Convert.ToString(txtManufacturersContactname.Text);
                objManufacturers.Contactfax = Convert.ToString(txtManufacturersContactfax.Text);
                objManufacturers.Contacttel1 = Convert.ToString(txtManufacturersContacttel1.Text);
                objManufacturers.Contacttel2 = Convert.ToString(txtManufacturersContacttel2.Text);
                objManufacturers.Contactemail = Convert.ToString(txtManufacturersContactemail.Text);
               
                if (objManufacturers.Exists(bNewManufacturers) > 0)
                {
                    MessageBox.Show("There exists a manufacturer record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewManufacturers)
                    objManufacturers.Insert();
                else
                    objManufacturers.Update();

                ManufacturersId = objManufacturers.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindManufacturers()
        {
            try
            {
                CManufacturers objManufacturers = new CManufacturers();
                DataTable dt = new DataTable();

                objManufacturers.Id = ManufacturersId;
                dt = objManufacturers.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    ManufacturersId = objManufacturers.Id;
                    txtManufacturersName.Text = Convert.ToString(objManufacturers.Name);
                    txtManufacturersTIN.Text = Convert.ToString(objManufacturers.TIN);
                    txtManufacturersMailingaddress.Text = Convert.ToString(objManufacturers.Mailingaddress);
                    txtManufacturersFax.Text = Convert.ToString(objManufacturers.Fax);
                    txtManufacturersTel1.Text = Convert.ToString(objManufacturers.Tel1);
                    txtManufacturersTel2.Text = Convert.ToString(objManufacturers.Tel2);
                    txtManufacturersEmail.Text = Convert.ToString(objManufacturers.Email);
                    txtManufacturersContactname.Text = Convert.ToString(objManufacturers.Contactname);
                    txtManufacturersContactfax.Text = Convert.ToString(objManufacturers.Contactfax);
                    txtManufacturersContacttel1.Text = Convert.ToString(objManufacturers.Contacttel1);
                    txtManufacturersContacttel2.Text = Convert.ToString(objManufacturers.Contacttel2);
                    txtManufacturersContactemail.Text = Convert.ToString(objManufacturers.Contactemail);                  
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
        private void EditManufacturers()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwManufacturers.SelectedItems[0];

                bNewManufacturers = false;
                ManufacturersId = Convert.ToInt32(itmX.SubItems[colManufacturersId.Index].Text);
                txtManufacturersName.Text = Convert.ToString(itmX.SubItems[colManufacturersName.Index].Text);
                txtManufacturersTIN.Text = Convert.ToString(itmX.SubItems[colManufacturersTIN.Index].Text);
                txtManufacturersMailingaddress.Text = Convert.ToString(itmX.SubItems[colManufacturersMailingaddress.Index].Text);
                txtManufacturersFax.Text = Convert.ToString(itmX.SubItems[colManufacturersFax.Index].Text);
                txtManufacturersTel1.Text = Convert.ToString(itmX.SubItems[colManufacturersTel1.Index].Text);
                txtManufacturersTel2.Text = Convert.ToString(itmX.SubItems[colManufacturersTel2.Index].Text);
                txtManufacturersEmail.Text = Convert.ToString(itmX.SubItems[colManufacturersEmail.Index].Text);
                txtManufacturersContactname.Text = Convert.ToString(itmX.SubItems[colManufacturersContactname.Index].Text);
                txtManufacturersContactfax.Text = Convert.ToString(itmX.SubItems[colManufacturersContactfax.Index].Text);
                txtManufacturersContacttel1.Text = Convert.ToString(itmX.SubItems[colManufacturersContacttel1.Index].Text);
                txtManufacturersContacttel2.Text = Convert.ToString(itmX.SubItems[colManufacturersContacttel2.Index].Text);
                txtManufacturersContactemail.Text = Convert.ToString(itmX.SubItems[colManufacturersContactemail.Index].Text);
                
                //this.FindManufacturers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateManufacturersList()
        {
            try
            {
                if (bNewManufacturers)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ManufacturersId.ToString(), 
                                                                                      txtManufacturersName.Text.ToString(), 
                                                                                      txtManufacturersMailingaddress.Text.ToString(), 
                                                                                      txtManufacturersFax.Text.ToString(), 
                                                                                      txtManufacturersTel1.Text.ToString(), 
                                                                                      txtManufacturersTel2.Text.ToString(), 
                                                                                      txtManufacturersEmail.Text.ToString(), 
                                                                                      txtManufacturersContactname.Text.ToString(), 
                                                                                      txtManufacturersContactfax.Text.ToString(), 
                                                                                      txtManufacturersContacttel1.Text.ToString(), 
                                                                                      txtManufacturersContacttel2.Text.ToString(), 
                                                                                      txtManufacturersContactemail.Text.ToString(),                                                                                                                                                                             
                                                                                      txtManufacturersTIN.Text.ToString()});
                    lvwManufacturers.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwManufacturers.SelectedItems[0];
                    itmX.SubItems[colManufacturersName.Index].Text = txtManufacturersName.Text.ToString();
                    itmX.SubItems[colManufacturersTIN.Index].Text = txtManufacturersTIN.Text.ToString();
                    itmX.SubItems[colManufacturersMailingaddress.Index].Text = txtManufacturersMailingaddress.Text.ToString();
                    itmX.SubItems[colManufacturersFax.Index].Text = txtManufacturersFax.Text.ToString();
                    itmX.SubItems[colManufacturersTel1.Index].Text = txtManufacturersTel1.Text.ToString();
                    itmX.SubItems[colManufacturersTel2.Index].Text = txtManufacturersTel2.Text.ToString();
                    itmX.SubItems[colManufacturersEmail.Index].Text = txtManufacturersEmail.Text.ToString();
                    itmX.SubItems[colManufacturersContactname.Index].Text = txtManufacturersContactname.Text.ToString();
                    itmX.SubItems[colManufacturersContactfax.Index].Text = txtManufacturersContactfax.Text.ToString();
                    itmX.SubItems[colManufacturersContacttel1.Index].Text = txtManufacturersContacttel1.Text.ToString();
                    itmX.SubItems[colManufacturersContacttel2.Index].Text = txtManufacturersContacttel2.Text.ToString();
                    itmX.SubItems[colManufacturersContactemail.Index].Text = txtManufacturersContactemail.Text.ToString();                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillManufacturersList()
        {
            try
            {

                CManufacturers objManufacturers = new CManufacturers();

                ArrayList ar = new ArrayList(objManufacturers.GetList());
                this.lvwManufacturers.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CManufacturers Manufacturers in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {  Manufacturers.Id.ToString(), 
                                                                                      Manufacturers.Name.ToString(), 
                                                                                      Manufacturers.Mailingaddress.ToString(), 
                                                                                      Manufacturers.Fax.ToString(), 
                                                                                      Manufacturers.Tel1.ToString(), 
                                                                                      Manufacturers.Tel2.ToString(), 
                                                                                      Manufacturers.Email.ToString(), 
                                                                                      Manufacturers.Contactname.ToString(), 
                                                                                      Manufacturers.Contactfax.ToString(), 
                                                                                      Manufacturers.Contacttel1.ToString(), 
                                                                                      Manufacturers.Contacttel2.ToString(), 
                                                                                      Manufacturers.Contactemail.ToString(),                                                                                                                                                                        
                                                                                      Manufacturers.TIN.ToString()});
                    this.lvwManufacturers.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManufacturers_Load(object sender, EventArgs e)
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
        private void frmManufacturers_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    FillManufacturersList();
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
        private void btnSaveManufacturers_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveManufacturers();

                if (bSaved)
                {
                    UpdateManufacturersList();
                    NewManufacturers();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteManufacturers_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CManufacturers objManufacturers = new CManufacturers();
                    objManufacturers.Id = Convert.ToInt32(lvwManufacturers.SelectedItems[0].SubItems[colManufacturersId.Index].Text);
                    objManufacturers.Delete();
                    lvwManufacturers.Items.Remove(lvwManufacturers.SelectedItems[0]);

                    NewManufacturers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewManufacturers_Click(object sender, EventArgs e)
        {
            try
            {
                bNewManufacturers = true;
                ManufacturersId = 0;
                NewManufacturers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwManufacturers_DoubleClick(object sender, EventArgs e)
        {
            //
        }
        private void lvwManufacturers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwManufacturers.SelectedItems == null) return;
                if (lvwManufacturers.SelectedItems.Count <= 0) return;
                EditManufacturers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchManufacturers_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.ManufacturersId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindManufacturers();
        }
        private void btnFindManufacturers_Click(object sender, EventArgs e)
        {
            try
            {
                FindManufacturers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void ResizeControls()
        {
            try
            {
                // Title label
                this.lblTitle.Width = this.Width + 1;

                // Line just under the title label
                this.line1.Width = this.lblTitle.Width;
                this.line2.Width = this.lblTitle.Width;

                // Main toolbar
                this.panelToolbar.Width = this.lblTitle.Width - this.panelToolbar.Left;
                this.grpManufacturersEntry.Width = this.lblTitle.Width - this.grpManufacturersEntry.Left - 24;
                //this.grpContact.Width = this.lblTitle.Width - this.grpContact.Left - 24;
               
                // Transactions listview
                this.lvwManufacturers.Height = this.Height - this.lvwManufacturers.Top - 65;
                this.lvwManufacturers.Width = this.lblTitle.Width - this.lvwManufacturers.Left - 24;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManufacturers_Resize(object sender, EventArgs e)
        {
            try
            {
                ResizeControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

      

    }
}
