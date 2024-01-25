//
// ...
// Wizard generated code
// Date: 8/18/2009 3:52:34 PM
// Class: frmProducts
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
    public partial class frmProducts : Form
    {
        private const string DialogCaption = "Product Maintenance";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        private bool bNewProducts = true;
        private int ProductsId = 0;
        private bool already_in = false;

        #region Products

        public frmProducts()
        {
            InitializeComponent();

            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            popupHelper.AssignHandle(this.Handle);
        }
        private bool IsValidProducts()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtProductsManufacturerid, "Manufacturer can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtProductsBrandname, "Brand Name can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtProductsGenericname, "Generic Name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewProducts()
        {
            try
            {
                bNewProducts = true;
                ProductsId = 0;
                txtProductsManufacturerid.Text = String.Empty;
                txtProductsManufacturerid.Tag = null;
                txtProductsBrandname.Text = String.Empty;
                txtProductsGenericname.Text = String.Empty;
                chkProductsStatus.CheckState = CheckState.Unchecked;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveProducts()
        {

            try
            {
                if (!IsValidProducts()) return false;

                CProducts objProducts = new CProducts();

                objProducts.Id = ProductsId;
                objProducts.Manufacturerguid = txtProductsManufacturerid.Tag.ToString();
                objProducts.Brandname = Convert.ToString(txtProductsBrandname.Text);
                objProducts.Genericname = Convert.ToString(txtProductsGenericname.Text);
                objProducts.Status = chkProductsStatus.CheckState == CheckState.Checked ? 1 : 0;

                if (objProducts.Exists(bNewProducts) > 0)
                {
                    MessageBox.Show("There exists a product record with the given data.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewProducts)
                    objProducts.Insert();
                else
                    objProducts.Update();

                ProductsId = objProducts.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindProducts()
        {
            try
            {
                CProducts objProducts = new CProducts();
                DataTable dt = new DataTable();

                objProducts.Id = ProductsId;
                dt = objProducts.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    ProductsId = objProducts.Id;
                    txtProductsManufacturerid.Tag = Convert.ToString(objProducts.Manufacturerguid);
                    txtProductsManufacturerid.Text = CManufacturers.GetManufacturerNameFromCollection(objProducts.Manufacturerguid);
                    txtProductsBrandname.Text = Convert.ToString(objProducts.Brandname);
                    txtProductsGenericname.Text = Convert.ToString(objProducts.Genericname);
                    chkProductsStatus.CheckState = Convert.ToInt32(objProducts.Status) == 0 ? CheckState.Unchecked : CheckState.Checked;

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
        private void EditProducts()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwProducts.SelectedItems[0];

                bNewProducts = false;
                ProductsId = Convert.ToInt32(itmX.SubItems[colProductsId.Index].Text);
                txtProductsManufacturerid.Tag = Convert.ToString(itmX.SubItems[colProductsManufacturerGuid.Index].Text);
                txtProductsManufacturerid.Text = CManufacturers.GetManufacturerNameFromCollection(itmX.SubItems[colProductsManufacturerGuid.Index].Text);
                txtProductsBrandname.Text = Convert.ToString(itmX.SubItems[colProductsBrandname.Index].Text);
                txtProductsGenericname.Text = Convert.ToString(itmX.SubItems[colProductsGenericname.Index].Text);
                chkProductsStatus.CheckState = Convert.ToInt32(itmX.SubItems[colProductsStatus.Index].Text) == 0 ? CheckState.Unchecked : CheckState.Checked;

                //this.FindProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateProductsList()
        {
            try
            {
                if (bNewProducts)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ProductsId.ToString(), 
                                                                                      txtProductsManufacturerid.Tag.ToString(), 
                                                                                      txtProductsBrandname.Text.ToString(), 
                                                                                      txtProductsGenericname.Text.ToString(), 
                                                                                      (chkProductsStatus.CheckState == CheckState.Checked ? 1 : 0).ToString()});
                    lvwProducts.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwProducts.SelectedItems[0];
                    itmX.SubItems[colProductsManufacturerGuid.Index].Text = txtProductsManufacturerid.Tag.ToString();
                    itmX.SubItems[colProductsBrandname.Index].Text = txtProductsBrandname.Text.ToString();
                    itmX.SubItems[colProductsGenericname.Index].Text = txtProductsGenericname.Text.ToString();
                    itmX.SubItems[colProductsStatus.Index].Text = (chkProductsStatus.CheckState == CheckState.Checked ? 1 : 0).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillProductsList()
        {
            try
            {

                CProducts objProducts = new CProducts();

                ArrayList ar = new ArrayList(objProducts.GetList());
                this.lvwProducts.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CProducts Products in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      Products.Id.ToString(), 
                                                                                      Products.Manufacturerguid.ToString(), 
                                                                                      Products.Brandname.ToString(), 
                                                                                      Products.Genericname.ToString(), 
                                                                                      Products.Status.ToString()});
                    this.lvwProducts.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillProductsList(string Manufacturerguid, string BrandName, string GenericName)
        {
            try
            {

                CProducts objProducts = new CProducts();

                ArrayList ar = new ArrayList(objProducts.GetList(Manufacturerguid, BrandName, GenericName));
                this.lvwProducts.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CProducts Products in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      Products.Id.ToString(), 
                                                                                      Products.Manufacturerguid.ToString(), 
                                                                                      Products.Brandname.ToString(), 
                                                                                      Products.Genericname.ToString(), 
                                                                                      Products.Status.ToString()});
                    this.lvwProducts.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillList()
        {
            try
            {
                string Manufacturerguid = string.Empty;
                string BrandName = string.Empty;
                string GenericName = string.Empty;

                if (this.txtManufacturerFilter.Tag != null && this.txtManufacturerFilter.Text != string.Empty)
                    Manufacturerguid = this.txtManufacturerFilter.Tag.ToString();
                BrandName = txtBrandNameFilter.Text;
                GenericName = txtGenericNameFilter.Text;

                FillProductsList(Manufacturerguid, BrandName, GenericName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = null;
                CCommon.FillMarketStudyStatusCombo(this.cboMarketStudiesStatus, true);
                CCommon.FillProductRegistrationCertificateStatusCombo(this.cboProductRegistrationCertificatesStatus, true);
                //CCommon.FillComboBox(cboProductRegistrationCertificatesRegistrationtype, "Select TableRowGuid, name from tblDrugRegistrationTypes Order by Name ", "TableRowGuid", "Name", true);
                //CCommon.FillComboBox(cboProductRegistrationCertificatesDosageform, "Select TableRowGuid, name from tblDosageForms Order by Name", "TableRowGuid", "Name", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmProducts_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
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
        private void btnSaveProducts_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveProducts();

                if (bSaved)
                {
                    UpdateProductsList();
                    NewProducts();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CProducts objProducts = new CProducts();
                    objProducts.Id = Convert.ToInt32(lvwProducts.SelectedItems[0].SubItems[colProductsId.Index].Text);
                    objProducts.Delete();
                    lvwProducts.Items.Remove(lvwProducts.SelectedItems[0]);

                    NewProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewProducts_Click(object sender, EventArgs e)
        {
            try
            {
                this.lvwProducts.SelectedItems.Clear();

                bNewProducts = true;
                ProductsId = 0;
                NewProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwProducts.SelectedItems == null) return;
                if (lvwProducts.SelectedItems.Count <= 0) return;

                EditProducts();
                //FillMarketStudiesListByParent(CProducts.GetTableRowGuid(this.ProductsId));
                //NewMarketStudies();
                //FillProductRegistrationCertificatesListByParent(CProducts.GetTableRowGuid(this.ProductsId));
                //NewProductRegistrationCertificates();
                //FillLikeProductsListByParent(CProducts.GetTableRowGuid(this.ProductsId));
                //NewLikeProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwProducts_Click(object sender, EventArgs e)
        {
            try
            {
                lvwProducts_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.ProductsId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindProducts();
        }
        private void btnFindProducts_Click(object sender, EventArgs e)
        {
            try
            {
                FindProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchManufacturerFilter_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectManufacturer frmManu = new frmSelectManufacturer();
                frmManu.ShowDialog();
                if (frmManu.bCancel == true) return;
                this.txtManufacturerFilter.Tag = frmManu.Manufacturerguid.ToString();
                this.txtManufacturerFilter.Text = frmManu.ManufacturerName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchManufacturer_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectManufacturer frmManu = new frmSelectManufacturer();
                frmManu.ShowDialog();
                if (frmManu.bCancel == true) return;
                this.txtProductsManufacturerid.Tag = frmManu.Manufacturerguid.ToString();
                this.txtProductsManufacturerid.Text = frmManu.ManufacturerName.ToString();
                if (this.txtProductsManufacturerid.Tag != null)
                    if (this.txtProductsManufacturerid.Tag.ToString() != frmManu.Manufacturerguid.ToString())
                        if (!bNewProducts)
                            NewProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                FillList();
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
                this.line3.Width = this.lblTitle.Width;

                // Main toolbar
                this.panelToolBar.Width = this.lblTitle.Width - this.panelToolBar.Left;
                this.grpProductsEntry.Width = this.lblTitle.Width - this.grpProductsEntry.Left - 24;

                // Transactions listview
                this.lvwProducts.Height = this.Height - this.lvwProducts.Top - 65;

                // Detail Groupbox
                this.tabControlChildren.Height = this.Height - this.tabControlChildren.Top - 65;
                this.tabControlChildren.Width = this.lblTitle.Width - this.tabControlChildren.Left - 24;

                this.grpMarketStudiesEntry.Width = this.tabPageMarketStudies.Width - 12;
                this.grpLikeProductsEntry.Width = this.tabPageMarketStudies.Width - 12;
                this.grpProductRegistrationCertificatesEntry.Width = this.tabPageMarketStudies.Width - 12;

                this.lvwMarketStudies.Width = this.tabPageMarketStudies.Width - 12;
                this.lvwMarketStudies.Height = this.tabPageMarketStudies.Height - this.lvwMarketStudies.Top - 12;

                this.lvwLikeProducts.Width = this.tabPageMarketStudies.Width - 12;
                this.lvwLikeProducts.Height = this.tabPageMarketStudies.Height - this.lvwLikeProducts.Top - 12;

                this.lvwProductRegistrationCertificates.Width = this.tabPageMarketStudies.Width - 12;
                this.lvwProductRegistrationCertificates.Height = this.tabPageMarketStudies.Height - this.lvwProductRegistrationCertificates.Top - 12;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmProducts_Resize(object sender, EventArgs e)
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

        private void txtProductsManufacturerid_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SearchManufacturer(txtProductsManufacturerid, grpProductsEntry.Left, grpProductsEntry.Top);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void SearchManufacturer(TextBox SearchTextBox, int HorizontalOffset, int VerticalOffset)
        {
            try
            {
                if (SearchTextBox.Text != "")
                {
                    CManufacturers objManufacturer = new CManufacturers();
                    string nameLike = SearchTextBox.Text + "%";
                    ArrayList ar = new ArrayList(objManufacturer.GetList(nameLike));
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        manSelector = new frmManufacturerSelector();
                        manSelector.SearchTextBox = SearchTextBox;
                        manSelector.Width = SearchTextBox.Width;
                        manSelector.lvwManufacturer.Items.Clear();
                        foreach (CManufacturers Manufacturer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Manufacturer.Tablerowguid.ToString(),
                            Manufacturer.Name.ToString()});
                            manSelector.lvwManufacturer.Items.Add(itmX);
                        }
                        Point location = this.PointToScreen(new Point(SearchTextBox.Left + HorizontalOffset, SearchTextBox.Bottom + VerticalOffset));
                        popupHelper.ShowPopup(this, manSelector, location);

                        if (manSelector.blnSelected)
                        {
                            SearchTextBox.Tag = manSelector.Manufacturerguid;
                            SearchTextBox.Text = manSelector.ManufacturerName;
                        }
                    }
                    else
                    {
                        CManufacturers Manufacturer = (CManufacturers)ar[0];
                        SearchTextBox.Tag = Manufacturer.Tablerowguid;
                        SearchTextBox.Text = Manufacturer.Name;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void popupHelper_PopupClosed(object sender, PopupClosedEventArgs e)
        {
            try
            {
                TextBox SearchTextBox;
                if (manSelector.blnSelected)
                {
                    SearchTextBox = manSelector.SearchTextBox;
                    if (SearchTextBox != null)
                    {
                        SearchTextBox.Tag = manSelector.Manufacturerguid;
                        SearchTextBox.Text = manSelector.ManufacturerName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void popupHelper_PopupCancel(object sender, PopupCancelEventArgs e)
        {
            //Console.WriteLine("Popup Cancel, mouse clicked at {0}", e.CursorLocation);
        }

        private void txtManufacturerFilter_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SearchManufacturer(txtManufacturerFilter, grpProductsList.Left, grpProductsList.Top);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        #endregion

        #region MarketStudies Functions

        private bool bNewMarketStudies = true;
        private int MarketStudiesId = 0;

        private bool IsValidMarketStudies()
        {
            try
            {
                if (!CCommon.SetRequiredMessage(txtProductsBrandname, "Please select a product", mValidator, lblMsg))
                    return false;

                DateTime ValidDate;
                if (!DateTime.TryParseExact(txtMarketStudiesStartdate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    CCommon.SetMessage(txtMarketStudiesStartdate, "Please enter a valid start date", mValidator, lblMsg);
                    return false;
                }

                if (!DateTime.TryParseExact(txtMarketStudiesEnddate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                {
                    CCommon.SetMessage(txtMarketStudiesEnddate, "Please enter a valid end date", mValidator, lblMsg);
                    return false;
                }

                if (!CCommon.SetRequiredMessage(txtMarketStudiesLocationofstudy, "Location of study can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewMarketStudies()
        {
            try
            {
                bNewMarketStudies = true;
                MarketStudiesId = 0;
                txtMarketStudiesStartdate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtMarketStudiesEnddate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                cboMarketStudiesStatus.SelectedIndex = CCommon.GetIndexByItemData(cboMarketStudiesStatus, "-1", false);
                txtMarketStudiesNumberofexistingproductswithsamegenericname.Text = String.Empty;
                txtMarketStudiesCurrentaverageprice.Text = String.Empty;
                txtMarketStudiesSuggestedimportfobprice.Text = String.Empty;
                txtMarketStudiesCurrentdemandquantityperyear.Text = String.Empty;
                txtMarketStudiesForcastedimportquantityperyear.Text = String.Empty;
                txtMarketStudiesLocationofstudy.Text = String.Empty;
                txtMarketStudiesRemark.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveMarketStudies()
        {
            try
            {
                if (!IsValidMarketStudies()) return false;

                CMarketStudies objMarketStudies = new CMarketStudies();

                objMarketStudies.Id = MarketStudiesId;
                objMarketStudies.Productguid = CProducts.GetTableRowGuid(this.ProductsId);
                objMarketStudies.Startdate = CDateTime.DateFromString(txtMarketStudiesStartdate.Text);
                objMarketStudies.Enddate = CDateTime.DateFromString(txtMarketStudiesEnddate.Text);
                objMarketStudies.Status = Convert.ToInt32(CCommon.GetItemData(cboMarketStudiesStatus));
                objMarketStudies.Numberofexistingproductswithsamegenericname = Convert.ToString(txtMarketStudiesNumberofexistingproductswithsamegenericname.Text);
                objMarketStudies.Currentaverageprice = Convert.ToString(txtMarketStudiesCurrentaverageprice.Text);
                objMarketStudies.Suggestedimportfobprice = Convert.ToString(txtMarketStudiesSuggestedimportfobprice.Text);
                objMarketStudies.Currentdemandquantityperyear = Convert.ToString(txtMarketStudiesCurrentdemandquantityperyear.Text);
                objMarketStudies.Forcastedimportquantityperyear = Convert.ToString(txtMarketStudiesForcastedimportquantityperyear.Text);
                objMarketStudies.Locationofstudy = Convert.ToString(txtMarketStudiesLocationofstudy.Text);
                objMarketStudies.Remark = Convert.ToString(txtMarketStudiesRemark.Text);

                if (objMarketStudies.Exists(bNewMarketStudies) > 0)
                {
                    MessageBox.Show("There exists an employee record with the given staff code. Please try using another staff code.");
                    return false;
                }

                if (bNewMarketStudies)
                    objMarketStudies.Insert();
                else
                    objMarketStudies.Update();

                MarketStudiesId = objMarketStudies.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindMarketStudies()
        {
            try
            {
                CMarketStudies objMarketStudies = new CMarketStudies();
                DataTable dt = new DataTable();

                objMarketStudies.Id = MarketStudiesId;
                dt = objMarketStudies.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    MarketStudiesId = objMarketStudies.Id;
                    //txtProductid.Text = Convert.ToString(objMarketStudies.Productid);
                    if (objMarketStudies.Startdate != DateTime.MinValue)
                    {
                        txtMarketStudiesStartdate.Text = objMarketStudies.Startdate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtMarketStudiesStartdate.Text = string.Empty;
                    }
                    if (objMarketStudies.Enddate != DateTime.MinValue)
                    {
                        txtMarketStudiesEnddate.Text = objMarketStudies.Enddate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtMarketStudiesEnddate.Text = string.Empty;
                    }
                    cboMarketStudiesStatus.SelectedIndex = CCommon.GetIndexByItemData(cboMarketStudiesStatus, objMarketStudies.Status.ToString(), true);
                    txtMarketStudiesNumberofexistingproductswithsamegenericname.Text = Convert.ToString(objMarketStudies.Numberofexistingproductswithsamegenericname);
                    txtMarketStudiesCurrentaverageprice.Text = Convert.ToString(objMarketStudies.Currentaverageprice);
                    txtMarketStudiesSuggestedimportfobprice.Text = Convert.ToString(objMarketStudies.Suggestedimportfobprice);
                    txtMarketStudiesCurrentdemandquantityperyear.Text = Convert.ToString(objMarketStudies.Currentdemandquantityperyear);
                    txtMarketStudiesForcastedimportquantityperyear.Text = Convert.ToString(objMarketStudies.Forcastedimportquantityperyear);
                    txtMarketStudiesLocationofstudy.Text = Convert.ToString(objMarketStudies.Locationofstudy);
                    txtMarketStudiesRemark.Text = Convert.ToString(objMarketStudies.Remark);

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
        private void EditMarketStudies()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwMarketStudies.SelectedItems[0];

                bNewMarketStudies = false;
                MarketStudiesId = Convert.ToInt32(itmX.SubItems[colMarketStudiesId.Index].Text);
                //txtProductid.Text = Convert.ToString(itmX.SubItems[colMarketStudiesProductid.Index].Text);
                txtMarketStudiesStartdate.Text = itmX.SubItems[colMarketStudiesStartdate.Index].Text;
                txtMarketStudiesEnddate.Text = itmX.SubItems[colMarketStudiesEnddate.Index].Text;
                cboMarketStudiesStatus.SelectedIndex = CCommon.GetIndexByText(cboMarketStudiesStatus, itmX.SubItems[colMarketStudiesStatus.Index].Text, true);
                txtMarketStudiesNumberofexistingproductswithsamegenericname.Text = Convert.ToString(itmX.SubItems[colMarketStudiesNumberofexistingproductswithsamegenericname.Index].Text);
                txtMarketStudiesCurrentaverageprice.Text = Convert.ToString(itmX.SubItems[colMarketStudiesCurrentaverageprice.Index].Text);
                txtMarketStudiesSuggestedimportfobprice.Text = Convert.ToString(itmX.SubItems[colMarketStudiesSuggestedimportfobprice.Index].Text);
                txtMarketStudiesCurrentdemandquantityperyear.Text = Convert.ToString(itmX.SubItems[colMarketStudiesCurrentdemandquantityperyear.Index].Text);
                txtMarketStudiesForcastedimportquantityperyear.Text = Convert.ToString(itmX.SubItems[colMarketStudiesForcastedimportquantityperyear.Index].Text);
                txtMarketStudiesLocationofstudy.Text = Convert.ToString(itmX.SubItems[colMarketStudiesLocationofstudy.Index].Text);
                txtMarketStudiesRemark.Text = Convert.ToString(itmX.SubItems[colMarketStudiesRemark.Index].Text);

                //this.FindMarketStudies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateMarketStudiesList()
        {
            try
            {
                if (bNewMarketStudies)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {MarketStudiesId.ToString(), 
                                                                                      CProducts.GetTableRowGuid(this.ProductsId), 
                                                                                      txtMarketStudiesStartdate.Text.ToString(), 
                                                                                      txtMarketStudiesEnddate.Text.ToString(), 
                                                                                      CCommon.GetMarketStudyStatusText(Convert.ToInt32(CCommon.GetItemData(cboMarketStudiesStatus))), 
                                                                                      txtMarketStudiesNumberofexistingproductswithsamegenericname.Text.ToString(), 
                                                                                      txtMarketStudiesCurrentaverageprice.Text.ToString(), 
                                                                                      txtMarketStudiesSuggestedimportfobprice.Text.ToString(), 
                                                                                      txtMarketStudiesCurrentdemandquantityperyear.Text.ToString(), 
                                                                                      txtMarketStudiesForcastedimportquantityperyear.Text.ToString(), 
                                                                                      txtMarketStudiesLocationofstudy.Text.ToString(), 
                                                                                      txtMarketStudiesRemark.Text.ToString()});
                    lvwMarketStudies.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwMarketStudies.SelectedItems[0];
                    itmX.SubItems[colMarketStudiesProductGuid.Index].Text = CProducts.GetTableRowGuid(this.ProductsId);
                    itmX.SubItems[colMarketStudiesStartdate.Index].Text = txtMarketStudiesStartdate.Text.ToString();
                    itmX.SubItems[colMarketStudiesEnddate.Index].Text = txtMarketStudiesEnddate.Text.ToString();
                    itmX.SubItems[colMarketStudiesStatus.Index].Text = CCommon.GetMarketStudyStatusText(Convert.ToInt32(CCommon.GetItemData(cboMarketStudiesStatus)));
                    itmX.SubItems[colMarketStudiesNumberofexistingproductswithsamegenericname.Index].Text = txtMarketStudiesNumberofexistingproductswithsamegenericname.Text.ToString();
                    itmX.SubItems[colMarketStudiesCurrentaverageprice.Index].Text = txtMarketStudiesCurrentaverageprice.Text.ToString();
                    itmX.SubItems[colMarketStudiesSuggestedimportfobprice.Index].Text = txtMarketStudiesSuggestedimportfobprice.Text.ToString();
                    itmX.SubItems[colMarketStudiesCurrentdemandquantityperyear.Index].Text = txtMarketStudiesCurrentdemandquantityperyear.Text.ToString();
                    itmX.SubItems[colMarketStudiesForcastedimportquantityperyear.Index].Text = txtMarketStudiesForcastedimportquantityperyear.Text.ToString();
                    itmX.SubItems[colMarketStudiesLocationofstudy.Index].Text = txtMarketStudiesLocationofstudy.Text.ToString();
                    itmX.SubItems[colMarketStudiesRemark.Index].Text = txtMarketStudiesRemark.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillMarketStudiesList()
        {
            try
            {

                CMarketStudies objMarketStudies = new CMarketStudies();

                ArrayList ar = new ArrayList(objMarketStudies.GetList());
                this.lvwMarketStudies.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CMarketStudies MarketStudies in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] { MarketStudies.Id.ToString(), 
                                                                                      MarketStudies.Productguid.ToString(), 
                                                                                      MarketStudies.Startdate == CSettings.MinDate ? string.Empty : MarketStudies.Startdate.ToString(CSettings.DateFormat), 
                                                                                      MarketStudies.Enddate == CSettings.MinDate ? string.Empty : MarketStudies.Enddate.ToString(CSettings.DateFormat), 
                                                                                      CCommon.GetMarketStudyStatusText(MarketStudies.Status), 
                                                                                      MarketStudies.Numberofexistingproductswithsamegenericname.ToString(), 
                                                                                      MarketStudies.Currentaverageprice.ToString(), 
                                                                                      MarketStudies.Suggestedimportfobprice.ToString(), 
                                                                                      MarketStudies.Currentdemandquantityperyear.ToString(), 
                                                                                      MarketStudies.Forcastedimportquantityperyear.ToString(), 
                                                                                      MarketStudies.Locationofstudy.ToString(), 
                                                                                      MarketStudies.Remark.ToString()});
                    this.lvwMarketStudies.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillMarketStudiesListByParent(string strProductGuid)
        {
            try
            {

                CMarketStudies objMarketStudies = new CMarketStudies();

                ArrayList ar = new ArrayList(objMarketStudies.GetList(strProductGuid));
                this.lvwMarketStudies.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CMarketStudies MarketStudies in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               MarketStudies.Id.ToString(), 
                                                                                      MarketStudies.Productguid.ToString(), 
                                                                                      MarketStudies.Startdate == CSettings.MinDate ? string.Empty : MarketStudies.Startdate.ToString(CSettings.DateFormat), 
                                                                                      MarketStudies.Enddate == CSettings.MinDate ? string.Empty : MarketStudies.Enddate.ToString(CSettings.DateFormat), 
                                                                                      CCommon.GetMarketStudyStatusText(MarketStudies.Status), 
                                                                                      MarketStudies.Numberofexistingproductswithsamegenericname.ToString(), 
                                                                                      MarketStudies.Currentaverageprice.ToString(), 
                                                                                      MarketStudies.Suggestedimportfobprice.ToString(), 
                                                                                      MarketStudies.Currentdemandquantityperyear.ToString(), 
                                                                                      MarketStudies.Forcastedimportquantityperyear.ToString(), 
                                                                                      MarketStudies.Locationofstudy.ToString(), 
                                                                                      MarketStudies.Remark.ToString()});
                    this.lvwMarketStudies.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveMarketStudies_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveMarketStudies();

                if (bSaved)
                {
                    UpdateMarketStudiesList();
                    NewMarketStudies();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteMarketStudies_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CMarketStudies objMarketStudies = new CMarketStudies();
                    objMarketStudies.Id = Convert.ToInt32(lvwMarketStudies.SelectedItems[0].SubItems[colMarketStudiesId.Index].Text);
                    objMarketStudies.Delete();
                    lvwMarketStudies.Items.Remove(lvwMarketStudies.SelectedItems[0]);

                    NewMarketStudies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewMarketStudies_Click(object sender, EventArgs e)
        {
            try
            {
                this.lvwMarketStudies.SelectedItems.Clear();

                bNewMarketStudies = true;
                MarketStudiesId = 0;
                NewMarketStudies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwMarketStudies_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwMarketStudies.SelectedItems == null) return;
                if (lvwMarketStudies.SelectedItems.Count <= 0) return;

                EditMarketStudies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwMarketStudies_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwMarketStudies.SelectedItems == null) return;
                if (lvwMarketStudies.SelectedItems.Count <= 0) return;

                EditMarketStudies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnShowMarketStudiesByParent_Click(object sender, EventArgs e)
        {
            try
            {
                FillMarketStudiesListByParent(CProducts.GetTableRowGuid(this.ProductsId));
                NewMarketStudies();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region ProductRegistrationCertificates Functions

        private bool bNewProductRegistrationCertificates = true;
        private int ProductRegistrationCertificatesId = 0;

        private bool IsValidProductRegistrationCertificates()
        {
            try
            {
                DateTime ValidDate;
                double ValidDouble;

                if (!CCommon.SetRequiredMessage(txtProductsBrandname, "Product can not be empty", mValidator, lblMsg))
                    return false;

                if (CCommon.GetItemData(cboProductRegistrationCertificatesRegistrationtype) == "-1")
                {
                    CCommon.SetMessage(cboProductRegistrationCertificatesRegistrationtype, "Please select the type of registration", mValidator, lblMsg);
                    return false;
                }

                if (CCommon.GetItemData(cboProductRegistrationCertificatesStatus) == "-1")
                {
                    CCommon.SetMessage(cboProductRegistrationCertificatesStatus, "Please select the status of registration", mValidator, lblMsg);
                    return false;
                }

                if (txtProductRegistrationCertificatesRegistrationfee.Text.Length > 0)
                {
                    if (!double.TryParse(txtProductRegistrationCertificatesRegistrationfee.Text, out ValidDouble))
                    {
                        CCommon.SetMessage(txtProductRegistrationCertificatesRegistrationfee, "Registration fee must be a numeric value", mValidator, lblMsg);
                        return false;
                    }
                }
                else
                {
                    txtProductRegistrationCertificatesRegistrationfee.Text = "0";
                }

                if (txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Text.Length > 0)
                {
                    if (!double.TryParse(txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Text, out ValidDouble))
                    {
                        CCommon.SetMessage(txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency, "Registration fee must be a numeric value", mValidator, lblMsg);
                        return false;
                    }
                }
                else
                {
                    txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Text = "0";
                }
                if (Convert.ToInt32(CCommon.GetItemData(cboProductRegistrationCertificatesStatus)) != (int)CCommon.ProductRegistrationCertificateStatus.Pending)
                {

                    if (!CCommon.SetRequiredMessage(txtProductRegistrationCertificatesRegistrationnumber, "Registration number can not be empty", mValidator, lblMsg))
                        return false;

                    if (!DateTime.TryParseExact(txtProductRegistrationCertificatesRegistrationdate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                    {
                        CCommon.SetMessage(txtProductRegistrationCertificatesRegistrationdate, "Please enter a valid registration date", mValidator, lblMsg);
                        return false;
                    }

                    if (!DateTime.TryParseExact(txtProductRegistrationCertificatesRegistrationexpirydate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out ValidDate))
                    {
                        CCommon.SetMessage(txtProductRegistrationCertificatesRegistrationexpirydate, "Please enter a valid registration expiry date", mValidator, lblMsg);
                        return false;
                    }
                }
                if (!CCommon.SetRequiredMessage(txtProductRegistrationCertificatesPresentation, "Presentation number can not be empty", mValidator, lblMsg))
                    return false;

                if (!CCommon.SetRequiredMessage(txtProductRegistrationCertificatesStrength, "Strength can not be empty", mValidator, lblMsg))
                    return false;

                if (CCommon.GetItemData(cboProductRegistrationCertificatesDosageform) == "-1")
                {
                    CCommon.SetMessage(cboProductRegistrationCertificatesDosageform, "Please select the dosage form of the drug", mValidator, lblMsg);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewProductRegistrationCertificates()
        {
            try
            {
                bNewProductRegistrationCertificates = true;
                ProductRegistrationCertificatesId = 0;
                txtProductRegistrationCertificatesRegistrationsubmissiondate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProductRegistrationCertificatesRegistrationdate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProductRegistrationCertificatesRegistrationnumber.Text = String.Empty;
                cboProductRegistrationCertificatesStatus.SelectedIndex = CCommon.GetIndexByItemData(cboProductRegistrationCertificatesStatus, "-1", false);
                txtProductRegistrationCertificatesSpecificationrequestdate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProductRegistrationCertificatesSpecificationreceiveddate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProductRegistrationCertificatesSpecificationsubmissiondate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProductRegistrationCertificatesRegistrationfee.Text = String.Empty;
                txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Text = String.Empty;
                txtProductRegistrationCertificatesSamplerequestdate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProductRegistrationCertificatesSamplereceiveddate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProductRegistrationCertificatesSamplesubmissiondate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProductRegistrationCertificatesRegistrationexpirydate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtProductRegistrationCertificatesSliporcponumber.Text = String.Empty;
                cboProductRegistrationCertificatesRegistrationtype.SelectedIndex = CCommon.GetIndexByItemData(cboProductRegistrationCertificatesRegistrationtype, "-1", false);

                txtProductRegistrationCertificatesPresentation.Text = String.Empty;
                txtProductRegistrationCertificatesStrength.Text = String.Empty;
                cboProductRegistrationCertificatesDosageform.SelectedIndex = CCommon.GetIndexByItemData(cboProductRegistrationCertificatesDosageform, "-1", false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveProductRegistrationCertificates()
        {
            try
            {
                if (!IsValidProductRegistrationCertificates()) return false;

                CProductRegistrationCertificates objProductRegistrationCertificates = new CProductRegistrationCertificates();

                objProductRegistrationCertificates.Id = ProductRegistrationCertificatesId;
                objProductRegistrationCertificates.Productguid = CProducts.GetTableRowGuid(this.ProductsId);
                objProductRegistrationCertificates.Registrationsubmissiondate = CDateTime.DateFromString(txtProductRegistrationCertificatesRegistrationsubmissiondate.Text);
                if (Convert.ToInt32(CCommon.GetItemData(cboProductRegistrationCertificatesStatus)) == (int)CCommon.ProductRegistrationCertificateStatus.Pending)
                {
                    objProductRegistrationCertificates.Registrationnumber = "";
                    objProductRegistrationCertificates.Registrationdate = DateTime.MinValue;
                    objProductRegistrationCertificates.Registrationexpirydate = DateTime.MinValue;
                }
                else
                {
                    objProductRegistrationCertificates.Registrationnumber = Convert.ToString(txtProductRegistrationCertificatesRegistrationnumber.Text);
                    objProductRegistrationCertificates.Registrationdate = CDateTime.DateFromString(txtProductRegistrationCertificatesRegistrationdate.Text);
                    objProductRegistrationCertificates.Registrationexpirydate = CDateTime.DateFromString(txtProductRegistrationCertificatesRegistrationexpirydate.Text);

                }

                objProductRegistrationCertificates.Status = Convert.ToInt32(CCommon.GetItemData(cboProductRegistrationCertificatesStatus));
                objProductRegistrationCertificates.Specificationrequestdate = CDateTime.DateFromString(txtProductRegistrationCertificatesSpecificationrequestdate.Text);
                objProductRegistrationCertificates.Specificationreceiveddate = CDateTime.DateFromString(txtProductRegistrationCertificatesSpecificationreceiveddate.Text);
                objProductRegistrationCertificates.Specificationsubmissiondate = CDateTime.DateFromString(txtProductRegistrationCertificatesSpecificationsubmissiondate.Text);
                objProductRegistrationCertificates.Registrationfee = Convert.ToDecimal(txtProductRegistrationCertificatesRegistrationfee.Text);
                objProductRegistrationCertificates.Registrationfeeinforeigncurrency = Convert.ToDecimal(txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Text);
                objProductRegistrationCertificates.Samplerequestdate = CDateTime.DateFromString(txtProductRegistrationCertificatesSamplerequestdate.Text);
                objProductRegistrationCertificates.Samplereceiveddate = CDateTime.DateFromString(txtProductRegistrationCertificatesSamplereceiveddate.Text);
                objProductRegistrationCertificates.Samplesubmissiondate = CDateTime.DateFromString(txtProductRegistrationCertificatesSamplesubmissiondate.Text);
                objProductRegistrationCertificates.Registrationexpirydate = CDateTime.DateFromString(txtProductRegistrationCertificatesRegistrationexpirydate.Text);
                objProductRegistrationCertificates.Sliporcponumber = Convert.ToString(txtProductRegistrationCertificatesSliporcponumber.Text);
                objProductRegistrationCertificates.Registrationtypeguid = CCommon.GetItemData(cboProductRegistrationCertificatesRegistrationtype);

                objProductRegistrationCertificates.Presentation = Convert.ToString(txtProductRegistrationCertificatesPresentation.Text);
                objProductRegistrationCertificates.Strength = Convert.ToString(txtProductRegistrationCertificatesStrength.Text);
                objProductRegistrationCertificates.Dosageformguid = CCommon.GetItemData(cboProductRegistrationCertificatesDosageform);

                if (objProductRegistrationCertificates.Exists(bNewProductRegistrationCertificates) > 0)
                {
                    MessageBox.Show("There exists a certificate record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewProductRegistrationCertificates)
                    objProductRegistrationCertificates.Insert();
                else
                    objProductRegistrationCertificates.Update();

                ProductRegistrationCertificatesId = objProductRegistrationCertificates.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindProductRegistrationCertificates()
        {
            try
            {
                CProductRegistrationCertificates objProductRegistrationCertificates = new CProductRegistrationCertificates();
                DataTable dt = new DataTable();

                objProductRegistrationCertificates.Id = ProductRegistrationCertificatesId;
                dt = objProductRegistrationCertificates.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    ProductRegistrationCertificatesId = objProductRegistrationCertificates.Id;
                    //txtProductid.Text = Convert.ToString(objProductRegistrationCertificates.Productid);
                    if (objProductRegistrationCertificates.Registrationsubmissiondate != DateTime.MinValue)
                    {
                        txtProductRegistrationCertificatesRegistrationsubmissiondate.Text = objProductRegistrationCertificates.Registrationsubmissiondate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProductRegistrationCertificatesRegistrationsubmissiondate.Text = string.Empty;
                    }
                    if (objProductRegistrationCertificates.Registrationdate != DateTime.MinValue)
                    {
                        txtProductRegistrationCertificatesRegistrationdate.Text = objProductRegistrationCertificates.Registrationdate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProductRegistrationCertificatesRegistrationdate.Text = string.Empty;
                    }
                    txtProductRegistrationCertificatesRegistrationnumber.Text = Convert.ToString(objProductRegistrationCertificates.Registrationnumber);
                    cboProductRegistrationCertificatesStatus.SelectedIndex = CCommon.GetIndexByItemData(cboProductRegistrationCertificatesStatus, objProductRegistrationCertificates.Status.ToString(), true);
                    if (Convert.ToDateTime(objProductRegistrationCertificates.Specificationrequestdate) != DateTime.MinValue)
                    {
                        txtProductRegistrationCertificatesSpecificationrequestdate.Text = objProductRegistrationCertificates.Specificationrequestdate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProductRegistrationCertificatesSpecificationrequestdate.Text = string.Empty;
                    }
                    if (Convert.ToDateTime(objProductRegistrationCertificates.Specificationreceiveddate) != DateTime.MinValue)
                    {
                        txtProductRegistrationCertificatesSpecificationreceiveddate.Text = objProductRegistrationCertificates.Specificationreceiveddate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProductRegistrationCertificatesSpecificationreceiveddate.Text = string.Empty;
                    }
                    if (Convert.ToDateTime(objProductRegistrationCertificates.Specificationsubmissiondate) != DateTime.MinValue)
                    {
                        txtProductRegistrationCertificatesSpecificationsubmissiondate.Text = objProductRegistrationCertificates.Specificationsubmissiondate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProductRegistrationCertificatesSpecificationsubmissiondate.Text = string.Empty;
                    }
                    txtProductRegistrationCertificatesRegistrationfee.Text = Convert.ToString(objProductRegistrationCertificates.Registrationfee);
                    txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Text = Convert.ToString(objProductRegistrationCertificates.Registrationfeeinforeigncurrency);
                    if (Convert.ToDateTime(objProductRegistrationCertificates.Samplerequestdate) != DateTime.MinValue)
                    {
                        txtProductRegistrationCertificatesSamplerequestdate.Text = objProductRegistrationCertificates.Samplerequestdate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProductRegistrationCertificatesSamplerequestdate.Text = string.Empty;
                    }
                    if (Convert.ToDateTime(objProductRegistrationCertificates.Samplereceiveddate) != DateTime.MinValue)
                    {
                        txtProductRegistrationCertificatesSamplereceiveddate.Text = objProductRegistrationCertificates.Samplereceiveddate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProductRegistrationCertificatesSamplereceiveddate.Text = string.Empty;
                    }
                    if (Convert.ToDateTime(objProductRegistrationCertificates.Samplesubmissiondate) != DateTime.MinValue)
                    {
                        txtProductRegistrationCertificatesSamplesubmissiondate.Text = objProductRegistrationCertificates.Samplesubmissiondate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProductRegistrationCertificatesSamplesubmissiondate.Text = string.Empty;
                    }
                    if (Convert.ToDateTime(objProductRegistrationCertificates.Registrationexpirydate) != DateTime.MinValue)
                    {
                        txtProductRegistrationCertificatesRegistrationexpirydate.Text = objProductRegistrationCertificates.Registrationexpirydate.ToString(CSettings.DateFormat);
                    }
                    else
                    {
                        txtProductRegistrationCertificatesRegistrationexpirydate.Text = string.Empty;
                    }
                    txtProductRegistrationCertificatesSliporcponumber.Text = Convert.ToString(objProductRegistrationCertificates.Sliporcponumber);
                    cboProductRegistrationCertificatesRegistrationtype.SelectedIndex = CCommon.GetIndexByItemData(cboProductRegistrationCertificatesRegistrationtype, objProductRegistrationCertificates.Registrationtypeguid.ToString(), true);

                    txtProductRegistrationCertificatesPresentation.Text = Convert.ToString(objProductRegistrationCertificates.Presentation);
                    txtProductRegistrationCertificatesStrength.Text = Convert.ToString(objProductRegistrationCertificates.Strength);
                    cboProductRegistrationCertificatesDosageform.SelectedIndex = CCommon.GetIndexByItemData(cboProductRegistrationCertificatesDosageform, objProductRegistrationCertificates.Dosageformguid.ToString(), true);
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
        private void EditProductRegistrationCertificates()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwProductRegistrationCertificates.SelectedItems[0];

                bNewProductRegistrationCertificates = false;
                ProductRegistrationCertificatesId = Convert.ToInt32(itmX.SubItems[colProductRegistrationCertificatesId.Index].Text);
                //txtProductid.Text = Convert.ToString(itmX.SubItems[colProductRegistrationCertificatesProductid.Index].Text);
                txtProductRegistrationCertificatesRegistrationsubmissiondate.Text = itmX.SubItems[colProductRegistrationCertificatesRegistrationsubmissiondate.Index].Text;
                txtProductRegistrationCertificatesRegistrationdate.Text = itmX.SubItems[colProductRegistrationCertificatesRegistrationdate.Index].Text;
                txtProductRegistrationCertificatesRegistrationnumber.Text = Convert.ToString(itmX.SubItems[colProductRegistrationCertificatesRegistrationnumber.Index].Text);
                cboProductRegistrationCertificatesStatus.SelectedIndex = CCommon.GetIndexByText(cboProductRegistrationCertificatesStatus, itmX.SubItems[colProductRegistrationCertificatesStatus.Index].Text, true);

                txtProductRegistrationCertificatesSpecificationrequestdate.Text = itmX.SubItems[colProductRegistrationCertificatesSpecificationrequestdate.Index].Text;
                txtProductRegistrationCertificatesSpecificationreceiveddate.Text = itmX.SubItems[colProductRegistrationCertificatesSpecificationreceiveddate.Index].Text;
                txtProductRegistrationCertificatesSpecificationsubmissiondate.Text = itmX.SubItems[colProductRegistrationCertificatesSpecificationsubmissiondate.Index].Text;
                txtProductRegistrationCertificatesRegistrationfee.Text = Convert.ToString(itmX.SubItems[colProductRegistrationCertificatesRegistrationfee.Index].Text);
                txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Text = Convert.ToString(itmX.SubItems[colProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Index].Text);
                txtProductRegistrationCertificatesSamplerequestdate.Text = itmX.SubItems[colProductRegistrationCertificatesSamplerequestdate.Index].Text;
                txtProductRegistrationCertificatesSamplereceiveddate.Text = itmX.SubItems[colProductRegistrationCertificatesSamplereceiveddate.Index].Text;
                txtProductRegistrationCertificatesSamplesubmissiondate.Text = itmX.SubItems[colProductRegistrationCertificatesSamplesubmissiondate.Index].Text;

                txtProductRegistrationCertificatesRegistrationexpirydate.Text = itmX.SubItems[colProductRegistrationCertificatesRegistrationexpirydate.Index].Text;
                txtProductRegistrationCertificatesSliporcponumber.Text = Convert.ToString(itmX.SubItems[colProductRegistrationCertificatesSliporcponumber.Index].Text);
                cboProductRegistrationCertificatesRegistrationtype.SelectedIndex = CCommon.GetIndexByItemData(cboProductRegistrationCertificatesRegistrationtype, itmX.SubItems[colProductRegistrationCertificatesRegistrationtype.Index].Text, true);

                txtProductRegistrationCertificatesPresentation.Text = Convert.ToString(itmX.SubItems[colProductRegistrationCertificatesPresentation.Index].Text);
                txtProductRegistrationCertificatesStrength.Text = Convert.ToString(itmX.SubItems[colProductRegistrationCertificatesStrength.Index].Text);
                cboProductRegistrationCertificatesDosageform.SelectedIndex = CCommon.GetIndexByItemData(cboProductRegistrationCertificatesDosageform, itmX.SubItems[colProductRegistrationCertificatesDosageForm.Index].Text, true);
                //this.FindProductRegistrationCertificates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateProductRegistrationCertificatesList()
        {
            try
            {
                if (bNewProductRegistrationCertificates)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ProductRegistrationCertificatesId.ToString(), 
                                                                                      CProducts.GetTableRowGuid(this.ProductsId), 
                                                                                      txtProductRegistrationCertificatesRegistrationdate.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesRegistrationnumber.Text.ToString(), 
                                                                                      CCommon.GetProductRegistrationCertificateStatusText(Convert.ToInt32(CCommon.GetItemData(cboProductRegistrationCertificatesStatus))), 
                                                                                      txtProductRegistrationCertificatesSpecificationrequestdate.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesSpecificationreceiveddate.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesSpecificationsubmissiondate.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesRegistrationfee.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesSamplerequestdate.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesSamplereceiveddate.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesSamplesubmissiondate.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesRegistrationexpirydate.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesRegistrationsubmissiondate.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesSliporcponumber.Text.ToString(), 
                                                                                      CCommon.GetItemData(cboProductRegistrationCertificatesRegistrationtype), 
                                                                                      txtProductRegistrationCertificatesPresentation.Text.ToString(), 
                                                                                      txtProductRegistrationCertificatesStrength.Text.ToString(), 
                                                                                      CCommon.GetItemData(cboProductRegistrationCertificatesDosageform)});
                    lvwProductRegistrationCertificates.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwProductRegistrationCertificates.SelectedItems[0];
                    itmX.SubItems[colProductRegistrationCertificatesProductGuid.Index].Text = CProducts.GetTableRowGuid(this.ProductsId);
                    itmX.SubItems[colProductRegistrationCertificatesRegistrationsubmissiondate.Index].Text = txtProductRegistrationCertificatesRegistrationsubmissiondate.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesRegistrationdate.Index].Text = txtProductRegistrationCertificatesRegistrationdate.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesRegistrationnumber.Index].Text = txtProductRegistrationCertificatesRegistrationnumber.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesStatus.Index].Text = CCommon.GetProductRegistrationCertificateStatusText(Convert.ToInt32(CCommon.GetItemData(cboProductRegistrationCertificatesStatus)));
                    itmX.SubItems[colProductRegistrationCertificatesSpecificationrequestdate.Index].Text = txtProductRegistrationCertificatesSpecificationrequestdate.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesSpecificationreceiveddate.Index].Text = txtProductRegistrationCertificatesSpecificationreceiveddate.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesSpecificationsubmissiondate.Index].Text = txtProductRegistrationCertificatesSpecificationsubmissiondate.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesRegistrationfee.Index].Text = txtProductRegistrationCertificatesRegistrationfee.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Index].Text = txtProductRegistrationCertificatesRegistrationfeeinforeigncurrency.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesSamplerequestdate.Index].Text = txtProductRegistrationCertificatesSamplerequestdate.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesSamplereceiveddate.Index].Text = txtProductRegistrationCertificatesSamplereceiveddate.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesSamplesubmissiondate.Index].Text = txtProductRegistrationCertificatesSamplesubmissiondate.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesRegistrationexpirydate.Index].Text = txtProductRegistrationCertificatesRegistrationexpirydate.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesSliporcponumber.Index].Text = txtProductRegistrationCertificatesSliporcponumber.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesRegistrationtype.Index].Text = CCommon.GetItemData(cboProductRegistrationCertificatesRegistrationtype);
                    itmX.SubItems[colProductRegistrationCertificatesPresentation.Index].Text = txtProductRegistrationCertificatesPresentation.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesStrength.Index].Text = txtProductRegistrationCertificatesStrength.Text.ToString();
                    itmX.SubItems[colProductRegistrationCertificatesDosageForm.Index].Text = CCommon.GetItemData(cboProductRegistrationCertificatesDosageform);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillProductRegistrationCertificatesList()
        {
            try
            {

                CProductRegistrationCertificates objProductRegistrationCertificates = new CProductRegistrationCertificates();

                ArrayList ar = new ArrayList(objProductRegistrationCertificates.GetList());
                this.lvwProductRegistrationCertificates.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CProductRegistrationCertificates ProductRegistrationCertificates in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {   ProductRegistrationCertificates.Id.ToString(), 
                                                                                      ProductRegistrationCertificates.Productguid.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationdate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Registrationdate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationnumber.ToString(), 
                                                                                      CCommon.GetProductRegistrationCertificateStatusText(ProductRegistrationCertificates.Status).ToString(), 
                                                                                      ProductRegistrationCertificates.Specificationrequestdate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Specificationrequestdate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Specificationreceiveddate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Specificationreceiveddate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Specificationsubmissiondate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Specificationsubmissiondate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationfee.ToString(), 
                                                                                      ProductRegistrationCertificates.Samplerequestdate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Samplerequestdate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Samplereceiveddate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Samplereceiveddate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Samplesubmissiondate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Samplesubmissiondate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationexpirydate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Registrationexpirydate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationsubmissiondate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Registrationsubmissiondate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationfeeinforeigncurrency.ToString(), 
                                                                                      ProductRegistrationCertificates.Sliporcponumber.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationtypeguid.ToString(), 
                                                                                      ProductRegistrationCertificates.Presentation.ToString(), 
                                                                                      ProductRegistrationCertificates.Strength.ToString(), 
                                                                                      ProductRegistrationCertificates.Dosageformguid.ToString()});
                    this.lvwProductRegistrationCertificates.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillProductRegistrationCertificatesListByParent(string strProductGuid)
        {
            try
            {

                CProductRegistrationCertificates objProductRegistrationCertificates = new CProductRegistrationCertificates();

                ArrayList ar = new ArrayList(objProductRegistrationCertificates.GetList(strProductGuid, true));
                this.lvwProductRegistrationCertificates.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CProductRegistrationCertificates ProductRegistrationCertificates in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {   ProductRegistrationCertificates.Id.ToString(), 
                                                                                      ProductRegistrationCertificates.Productguid.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationdate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Registrationdate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationnumber.ToString(), 
                                                                                      CCommon.GetProductRegistrationCertificateStatusText(ProductRegistrationCertificates.Status).ToString(), 
                                                                                      ProductRegistrationCertificates.Specificationrequestdate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Specificationrequestdate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Specificationreceiveddate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Specificationreceiveddate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Specificationsubmissiondate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Specificationsubmissiondate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationfee.ToString(), 
                                                                                      ProductRegistrationCertificates.Samplerequestdate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Samplerequestdate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Samplereceiveddate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Samplereceiveddate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Samplesubmissiondate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Samplesubmissiondate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationexpirydate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Registrationexpirydate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationsubmissiondate == CSettings.MinDate ? string.Empty : ProductRegistrationCertificates.Registrationsubmissiondate.ToString(CSettings.DateFormat), 
                                                                                      ProductRegistrationCertificates.Registrationfeeinforeigncurrency.ToString(), 
                                                                                      ProductRegistrationCertificates.Sliporcponumber.ToString(), 
                                                                                      ProductRegistrationCertificates.Registrationtypeguid.ToString(), 
                                                                                      ProductRegistrationCertificates.Presentation.ToString(), 
                                                                                      ProductRegistrationCertificates.Strength.ToString(), 
                                                                                      ProductRegistrationCertificates.Dosageformguid.ToString()});
                    this.lvwProductRegistrationCertificates.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveProductRegistrationCertificates_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveProductRegistrationCertificates();

                if (bSaved)
                {
                    
                    UpdateProductRegistrationCertificatesList();
                    NewProductRegistrationCertificates();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteProductRegistrationCertificates_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CProductRegistrationCertificates objProductRegistrationCertificates = new CProductRegistrationCertificates();
                    objProductRegistrationCertificates.Id = Convert.ToInt32(lvwProductRegistrationCertificates.SelectedItems[0].SubItems[colProductRegistrationCertificatesId.Index].Text);
                    objProductRegistrationCertificates.Delete();
                    lvwProductRegistrationCertificates.Items.Remove(lvwProductRegistrationCertificates.SelectedItems[0]);

                    NewProductRegistrationCertificates();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewProductRegistrationCertificates_Click(object sender, EventArgs e)
        {
            try
            {
                this.lvwProductRegistrationCertificates.SelectedItems.Clear();

                bNewProductRegistrationCertificates = true;
                ProductRegistrationCertificatesId = 0;
                NewProductRegistrationCertificates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwProductRegistrationCertificates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwProductRegistrationCertificates.SelectedItems == null) return;
                if (lvwProductRegistrationCertificates.SelectedItems.Count <= 0) return;

                EditProductRegistrationCertificates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwProductRegistrationCertificates_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwProductRegistrationCertificates.SelectedItems == null) return;
                if (lvwProductRegistrationCertificates.SelectedItems.Count <= 0) return;

                EditProductRegistrationCertificates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowProductRegistrationCertificatesByParent_Click(object sender, EventArgs e)
        {
            try
            {
                FillProductRegistrationCertificatesListByParent(CProducts.GetTableRowGuid(this.ProductsId));
                NewProductRegistrationCertificates();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region LikeProducts Functions

        private bool bNewLikeProducts = true;
        private int LikeProductsId = 0;

        private bool IsValidLikeProducts()
        {
            try
            {
                //if (!CCommon.SetRequiredMessage(txtProductid, "Productid can not be empty", mValidator, lblMsg))
                //    return false;
                if (!CCommon.SetRequiredMessage(txtLikeProductsManufacturername, "Manufacturer name can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtLikeProductsBrandname, "Brand name can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewLikeProducts()
        {
            try
            {
                bNewLikeProducts = true;
                LikeProductsId = 0;
                txtLikeProductsManufacturername.Text = String.Empty;
                txtLikeProductsBrandname.Text = String.Empty;
                txtLikeProductsAverageprice.Text = String.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool SaveLikeProducts()
        {
            try
            {
                if (!IsValidLikeProducts()) return false;

                CLikeProducts objLikeProducts = new CLikeProducts();

                objLikeProducts.Id = LikeProductsId;
                objLikeProducts.Productguid = CProducts.GetTableRowGuid(this.ProductsId);
                objLikeProducts.Manufacturername = Convert.ToString(txtLikeProductsManufacturername.Text);
                objLikeProducts.Brandname = Convert.ToString(txtLikeProductsBrandname.Text);
                objLikeProducts.Averageprice = Convert.ToDecimal(txtLikeProductsAverageprice.Text);

                if (objLikeProducts.Exists(bNewLikeProducts) > 0)
                {
                    MessageBox.Show("There exists a like prodcut record with the given detail.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (bNewLikeProducts)
                    objLikeProducts.Insert();
                else
                    objLikeProducts.Update();

                LikeProductsId = objLikeProducts.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindLikeProducts()
        {
            try
            {
                CLikeProducts objLikeProducts = new CLikeProducts();
                DataTable dt = new DataTable();

                objLikeProducts.Id = LikeProductsId;
                dt = objLikeProducts.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    LikeProductsId = objLikeProducts.Id;
                    //txtProductid.Text = Convert.ToString(objLikeProducts.Productid);
                    txtLikeProductsManufacturername.Text = Convert.ToString(objLikeProducts.Manufacturername);
                    txtLikeProductsBrandname.Text = Convert.ToString(objLikeProducts.Brandname);
                    txtLikeProductsAverageprice.Text = Convert.ToString(objLikeProducts.Averageprice);

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
        private void EditLikeProducts()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwLikeProducts.SelectedItems[0];

                bNewLikeProducts = false;
                LikeProductsId = Convert.ToInt32(itmX.SubItems[colLikeProductsId.Index].Text);
                //txtProductid.Text = Convert.ToString(itmX.SubItems[colLikeProductsProductid.Index].Text);
                txtLikeProductsManufacturername.Text = Convert.ToString(itmX.SubItems[colLikeProductsManufacturername.Index].Text);
                txtLikeProductsBrandname.Text = Convert.ToString(itmX.SubItems[colLikeProductsBrandname.Index].Text);
                txtLikeProductsAverageprice.Text = Convert.ToString(itmX.SubItems[colLikeProductsAverageprice.Index].Text);

                //this.FindLikeProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateLikeProductsList()
        {
            try
            {
                if (bNewLikeProducts)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {LikeProductsId.ToString(), 
                                                                                      CProducts.GetTableRowGuid(this.ProductsId), 
                                                                                      txtLikeProductsManufacturername.Text.ToString(), 
                                                                                      txtLikeProductsBrandname.Text.ToString(), 
                                                                                      txtLikeProductsAverageprice.Text.ToString()});
                    lvwLikeProducts.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwLikeProducts.SelectedItems[0];
                    itmX.SubItems[colLikeProductsProductGuid.Index].Text = CProducts.GetTableRowGuid(this.ProductsId);
                    itmX.SubItems[colLikeProductsManufacturername.Index].Text = txtLikeProductsManufacturername.Text.ToString();
                    itmX.SubItems[colLikeProductsBrandname.Index].Text = txtLikeProductsBrandname.Text.ToString();
                    itmX.SubItems[colLikeProductsAverageprice.Index].Text = txtLikeProductsAverageprice.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillLikeProductsList()
        {
            try
            {

                CLikeProducts objLikeProducts = new CLikeProducts();

                ArrayList ar = new ArrayList(objLikeProducts.GetList());
                this.lvwLikeProducts.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLikeProducts LikeProducts in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      LikeProducts.Id.ToString(), 
                                                                                      LikeProducts.Productguid.ToString(), 
                                                                                      LikeProducts.Manufacturername.ToString(), 
                                                                                      LikeProducts.Brandname.ToString(), 
                                                                                      LikeProducts.Averageprice.ToString()});
                    this.lvwLikeProducts.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillLikeProductsListByParent(string strProductGuid)
        {
            try
            {

                CLikeProducts objLikeProducts = new CLikeProducts();

                ArrayList ar = new ArrayList(objLikeProducts.GetList(CProducts.GetTableRowGuid(this.ProductsId)));
                this.lvwLikeProducts.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CLikeProducts LikeProducts in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      LikeProducts.Id.ToString(), 
                                                                                      LikeProducts.Productguid.ToString(), 
                                                                                      LikeProducts.Manufacturername.ToString(), 
                                                                                      LikeProducts.Brandname.ToString(), 
                                                                                      LikeProducts.Averageprice.ToString()});
                    this.lvwLikeProducts.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveLikeProducts_Click(object sender, EventArgs e)
        {
            try
            {
                bool bSaved = false;

                bSaved = SaveLikeProducts();

                if (bSaved)
                {
                    UpdateLikeProductsList();
                    NewLikeProducts();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteLikeProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLikeProducts objLikeProducts = new CLikeProducts();
                    objLikeProducts.Id = Convert.ToInt32(lvwLikeProducts.SelectedItems[0].SubItems[colLikeProductsId.Index].Text);
                    objLikeProducts.Delete();
                    lvwLikeProducts.Items.Remove(lvwLikeProducts.SelectedItems[0]);

                    NewLikeProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewLikeProducts_Click(object sender, EventArgs e)
        {
            try
            {
                this.lvwLikeProducts.SelectedItems.Clear();

                bNewLikeProducts = true;
                LikeProductsId = 0;
                NewLikeProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwLikeProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvwLikeProducts.SelectedItems == null) return;
                if (lvwLikeProducts.SelectedItems.Count <= 0) return;

                EditLikeProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowLikeProductsByParent_Click(object sender, EventArgs e)
        {
            try
            {
                FillLikeProductsListByParent(CProducts.GetTableRowGuid(this.ProductsId));
                NewLikeProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwLikeProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwLikeProducts.SelectedItems == null) return;
                if (lvwLikeProducts.SelectedItems.Count <= 0) return;

                EditLikeProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void btnSearchManufacturerFilter1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchManufacturer(txtManufacturerFilter, grpProductsList.Left, grpProductsList.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchManufacturer1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchManufacturer(txtProductsManufacturerid, grpProductsEntry.Left, grpProductsEntry.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboProductRegistrationCertificatesStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            IsRegistrationPending();
        }
        private void IsRegistrationPending()
        {
            if (cboProductRegistrationCertificatesStatus.SelectedIndex > 0)
            {
                if (Convert.ToInt32(CCommon.GetItemData(cboProductRegistrationCertificatesStatus)) == (int)CCommon.ProductRegistrationCertificateStatus.Pending) 
                    grpRegistration.Enabled = false;
                else
                    grpRegistration.Enabled = true;
            }
        }

    }
}
