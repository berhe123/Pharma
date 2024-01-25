
// Wizard generated code
// Date: 8/20/2009 10:30:42 AM
// Class: frmItems
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;


namespace Pharma
{
    public partial class frmItems : Form
    {
        private const string DialogCaption = "Item Maintenance";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        private bool bNewItems = true;
        private int ItemsId = 0;
        private bool already_in = false;
       
        #region Items Functions

        public frmItems()
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
        private bool IsValidItems()
        {
            try
            {
                

                if (!CCommon.SetRequiredMessage(cbomakeorganization, "Make Organization can not be empty", mValidator, lblMsg, false))
                    return false;
                if (!CCommon.SetRequiredMessage(cboYear, "Year can not be empty", mValidator, lblMsg, false))
                    return false;
                if (!CCommon.SetRequiredMessage(cboModel, "Model can not be empty", mValidator, lblMsg, false))
                    return false;
                if (!CCommon.SetRequiredMessage(cboEngineType, "Engine Type can not be empty", mValidator, lblMsg, false))
                    return false;
               
                if (!CCommon.SetRequiredMessage(txtItemsName, "Brand name can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtItemsManufacturerid, "Make Organization can not be empty", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtItemsItemCode, "Item Code can not be empty", mValidator, lblMsg))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void NewItems()
        {
            try
            {
                bNewItems = true;
                ItemsId = 0;
               
                cbomakeorganization.SelectedIndex = CCommon.GetIndexByItemData(cbomakeorganization, "-1", false);
                cboYear.SelectedIndex = CCommon.GetIndexByItemData(cboYear, "-1", false);
                cboModel.SelectedIndex = CCommon.GetIndexByItemData(cboModel, "-1", false);
                cboEngineType.SelectedIndex = CCommon.GetIndexByItemData(cboEngineType, "-1", false);
                txtItemsName.Text = String.Empty;
                txtItemsManufacturerid.Tag = null;
                txtItemsManufacturerid.Text = String.Empty;
                txtItemsReorderlevel.Text = String.Empty;
                txtItemsProfitMargin.Text = String.Empty;
                txtItemsSellablebactchid.Text = String.Empty;
                txtItemsItemCode.Text = string.Empty;
                picItemPicture.Image = null;
                this.chkIsVATAvailable.CheckState = CheckState.Unchecked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveItems()
        {
            try
            {
                if (!IsValidItems()) return false;

                CItems objItems = new CItems();

                //byte[] img = null;
                ////FileStream fstream = new System.IO.FileStream(this.textBox_image_path.Text, FileMode.Open, FileAccess.Read);
                //BinaryReader br = new BinaryReader(fstream);
                //img = br.ReadBytes((int)fstream.Length);

                string Sellablebactchguid = string.Empty;

                objItems.Id = ItemsId;
                if (!bNewItems) objItems.GetRecord();

                objItems.MakeOrganization = CCommon.GetItemData(cbomakeorganization);
                objItems.Year = CCommon.GetItemData(cboYear);
                objItems.Model = CCommon.GetItemData(cboModel);
                objItems.EngineType = CCommon.GetItemData(cboEngineType);
                objItems.Manufacturerguid = txtItemsManufacturerid.Tag.ToString();
                objItems.Brandname = Convert.ToString(txtItemsName.Text);

                objItems.photo = CPicture.PictureToByteArray(picItemPicture.Image); 

                objItems.Reorderlevel = Convert.ToDecimal(txtItemsReorderlevel.Text);
                objItems.ProfitMargin = Convert.ToDecimal(txtItemsProfitMargin.Text);
                objItems.Itemcode = Convert.ToString(txtItemsItemCode.Text);
                objItems.Dosageformguid = Guid.Empty.ToString();
                objItems.Genericname = string.Empty;
                objItems.Levelguid = Guid.Empty.ToString();
                objItems.Productguid = Guid.Empty.ToString();
                objItems.Samplepresentation = string.Empty;
                objItems.Shelflife = string.Empty;
                objItems.Strength = string.Empty;
                objItems.Measurement = string.Empty;
                
                objItems.IsVATApplicable = chkIsVATAvailable.Checked;
                if (bNewItems) objItems.Sellablebactchguid = string.Empty;

                if (objItems.Exists(bNewItems) > 0)
                {
                    MessageBox.Show("There exists an Item with the Given Information");
                    return false;
                }
                if (objItems.Exists1(bNewItems) > 0)
                {
                    MessageBox.Show("There exists an Item with the Given Information");
                    return false;
                }
                if (bNewItems)
                    objItems.Insert();
                else
                    objItems.Update();

                ItemsId = objItems.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool FindItems()
        {
            try
            {
                CItems objItems = new CItems();
                DataTable dt = new DataTable();

                objItems.Id = ItemsId;
                dt = objItems.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    ItemsId = objItems.Id;
                    
                    //cbomakeorganization.SelectedIndex = CCommon.GetIndexByItemData(cbomakeorganization, objItems.MakeOrganization.ToString(), true);
                    //cboYear.SelectedIndex = CCommon.GetIndexByItemData(cboYear, objItems.Year.ToString(), true);
                    //cboModel.SelectedIndex = CCommon.GetIndexByItemData(cboModel, objItems.Model.ToString(), true);
                    //cboEngineType.SelectedIndex = CCommon.GetIndexByItemData(cboEngineType, objItems.EngineType.ToString(), true);
                    //txtItemsManufacturerid.Tag = Convert.ToString(objItems.Manufacturerguid);
                    //txtItemsManufacturerid.Text = CManufacturers.GetManufacturerNameFromCollection(objItems.Manufacturerguid);
                    txtItemsName.Text = Convert.ToString(objItems.Brandname);
                    
                    //txtItemsReorderlevel.Text = Convert.ToString(objItems.Reorderlevel);
                    //txtItemsProfitMargin.Text = Convert.ToString(objItems.ProfitMargin);
                    //txtItemsSellablebactchid.Text = Convert.ToString(objItems.Sellablebactchguid);
                    //txtItemsItemCode.Text = Convert.ToString(objItems.Itemcode);
                    //chkIsVATAvailable.Checked = Convert.ToBoolean(objItems.IsVATApplicable);
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
        private void EditItems()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwItems.SelectedItems[0];
                byte[] pic;

                bNewItems = false;
                ItemsId = Convert.ToInt32(itmX.SubItems[colItemsId.Index].Text);

                cbomakeorganization.SelectedIndex = CCommon.GetIndexByItemData(cbomakeorganization, itmX.SubItems[colMakeOrganization.Index].Text, true);
                cboYear.SelectedIndex = CCommon.GetIndexByItemData(cboYear, itmX.SubItems[colYear.Index].Text, true);
                cboModel.SelectedIndex = CCommon.GetIndexByItemData(cboModel, itmX.SubItems[colModel.Index].Text, true);
                cboEngineType.SelectedIndex = CCommon.GetIndexByItemData(cboEngineType, itmX.SubItems[colEngineType.Index].Text, true);
              //  txtItemsName.Text = Convert.ToString(itmX.SubItems[colItemsBrandname.Index].Text);
                txtItemsManufacturerid.Tag = Convert.ToString(itmX.SubItems[colItemsManufacturerGuid.Index].Text);
                txtItemsManufacturerid.Text = CManufacturers.GetManufacturerNameFromCollection(itmX.SubItems[colItemsManufacturerGuid.Index].Text);
                txtItemsReorderlevel.Text = Convert.ToString(itmX.SubItems[colItemsReorderlevel.Index].Text);
                txtItemsProfitMargin.Text = Convert.ToString(itmX.SubItems[colItemsProfitMargin.Index].Text);
                txtItemsSellablebactchid.Text = Convert.ToString(itmX.SubItems[colItemsSellablebactchGuid.Index].Text);
                txtItemsItemCode.Text = Convert.ToString(itmX.SubItems[colItemsItemCode.Index].Text);
                chkIsVATAvailable.Checked = Convert.ToBoolean(itmX.SubItems[colItemsIsVATAvailable.Index].Text);
                pic = CItems.GetPicture(ItemsId);
                if (pic != null)
                    picItemPicture.Image = CPicture.ByteArrayToPicture(pic);
                else
                    picItemPicture.Image = null;
                this.FindItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateItemsList()
        {
            try
            {
                if (bNewItems)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {ItemsId.ToString(), 
                                                                                     
                                                                                     // CCommon.GetItemData(cbomakeorganization), 
                                                                                      CCommon.GetItemData(cboYear), 
                                                                                      CCommon.GetItemData(cboModel),
                                                                                      CCommon.GetItemData(cboEngineType),
                                                                                      txtItemsName.Text.ToString(), 
                                                                                      txtItemsManufacturerid.Tag.ToString(), 
                                                                                      txtItemsReorderlevel.Text.ToString(), 
                                                                                      txtItemsProfitMargin.Text.ToString(), 
                                                                                      txtItemsSellablebactchid.Text.ToString(),
                                                                                      //txtItemsName.Text,
                                                                                      txtItemsItemCode.Text,
                                                                                      chkIsVATAvailable.Checked.ToString() });
                    lvwItems.Items.Add(itmX);
                }
                else
                {
                    ListViewItem itmX = new ListViewItem();
                    itmX = lvwItems.SelectedItems[0];

                    itmX.SubItems[colMakeOrganization.Index].Text = CCommon.GetItemData(cbomakeorganization);
                    itmX.SubItems[colYear.Index].Text = CCommon.GetItemData(cboYear);
                    itmX.SubItems[colModel.Index].Text = CCommon.GetItemData(cboModel);
                    itmX.SubItems[colEngineType.Index].Text = CCommon.GetItemData(cboEngineType);
                    itmX.SubItems[colItemsManufacturerGuid.Index].Text = txtItemsManufacturerid.Tag.ToString();
                   itmX.SubItems[colItemsBrandname.Index].Text = txtItemsName.Text.ToString();
                    
                    itmX.SubItems[colItemsReorderlevel.Index].Text = txtItemsReorderlevel.Text.ToString();
                    itmX.SubItems[colItemsProfitMargin.Index].Text = txtItemsProfitMargin.Text.ToString();
                    itmX.SubItems[colItemsSellablebactchGuid.Index].Text = txtItemsSellablebactchid.Text.ToString();
                   // itmX.SubItems[colItemsBrandname.Index].Text = txtItemsName.Text;
                    itmX.SubItems[colItemsItemCode.Index].Text = txtItemsItemCode.Text;
                    itmX.SubItems[colItemsIsVATAvailable.Index].Text = chkIsVATAvailable.Checked.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillItemsList()
        {
            try
            {

                CItems objItems = new CItems();

                ArrayList ar = new ArrayList(objItems.GetList());
                this.lvwItems.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CItems Items in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Items.Id.ToString(),                                                                       Items.Id.ToString(), 
                                                                                      Items.Categoryguid.ToString(), 
                                                                                    
                                                                                      Items.MakeOrganization.ToString(),
                                                                                      Items.Year.ToString(),
                                                                                      Items.Model.ToString(),
                                                                                      Items.EngineType.ToString(),
                                                                                      Items.Productguid.ToString(), 
                                                                                      Items.Manufacturerguid.ToString(), 
                                                                                      Items.Brandname.ToString(), 
                                                                                      Items.Genericname.ToString(),                                                                                     
                                                                                      Items.Measurement.ToString(), 
                                                                                      Items.Samplepresentation.ToString(), 
                                                                                      Items.Strength.ToString(), 
                                                                                      Items.Dosageformguid.ToString(), 
                                                                                      Items.Shelflife.ToString(), 
                                                                                      Items.Reorderlevel.ToString(), 
                                                                                      Items.ProfitMargin.ToString(), 
                                                                                      Items.Sellablebactchguid.ToString(),
                                                                                      Items.Brandname.ToString(), 
                                                                                      Items.Itemcode.ToString(),
                                                                                      Items.Levelguid.ToString(),
                                                                                      Items.IsVATApplicable.ToString()});
                                                                                      
                    this.lvwItems.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillItemsList(string Manufacturerguid, string Categoryguid, string BrandName, string GenericName)
        {
            try
            {

                CItems objItems = new CItems();

                ArrayList ar = new ArrayList(objItems.GetList(Manufacturerguid, Categoryguid, BrandName, GenericName));
                this.lvwItems.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CItems Items in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Items.Id.ToString(), 
                                                                                      Items.Categoryguid.ToString(), 
                                                                                      Items.MakeOrganization.ToString(),
                                                                                      Items.Year.ToString(),
                                                                                      Items.Model.ToString(),
                                                                                      Items.EngineType.ToString(),
                                                                                      Items.Productguid.ToString(), 
                                                                                      Items.Manufacturerguid.ToString(), 
                                                                                      Items.Brandname.ToString(), 
                                                                                      Items.Genericname.ToString(), 
                                                                                       
                                                                                      Items.Measurement.ToString(), 
                                                                                      Items.Samplepresentation.ToString(), 
                                                                                      Items.Strength.ToString(), 
                                                                                      Items.Dosageformguid.ToString(), 
                                                                                      Items.Shelflife.ToString(), 
                                                                                      Items.Reorderlevel.ToString(), 
                                                                                      Items.ProfitMargin.ToString(), 
                                                                                      Items.Sellablebactchguid.ToString(),
                                                                                      Items.Brandname.ToString(), 
                                                                                      Items.Itemcode.ToString(), 
                                                                                      Items.Levelguid.ToString(),
                                                                                      Items.IsVATApplicable.ToString()});
                    this.lvwItems.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillItemsList(string Manufacturerguid, string MakeOrganizationguid, string EngineTypeguid, string Yearguid, string Modelguid, string BrandName, string GenericName, string ItemCode)
        {
            try
            {

                CItems objItems = new CItems();

                ArrayList ar = new ArrayList(objItems.GetList(Manufacturerguid, MakeOrganizationguid, EngineTypeguid, Yearguid, Modelguid, BrandName, GenericName, ItemCode));
                this.lvwItems.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CItems Items in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               Items.Id.ToString(), 
                                                                                      Items.MakeOrganization.ToString(),
                                                                                      Items.Year.ToString(),
                                                                                      Items.Model.ToString(),
                                                                                      Items.EngineType.ToString(),
                                                                                      Items.Manufacturerguid.ToString(),
                                                                                      Items.Reorderlevel.ToString(), 
                                                                                      Items.ProfitMargin.ToString(), 
                                                                                      Items.Brandname.ToString(), 
                                                                                      Items.IsVATApplicable.ToString(), 
                                                                                      Items.Sellablebactchguid.ToString(), 
                                                                                      Items.Itemcode.ToString()});
                    this.lvwItems.Items.Add(itmX);
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
                string MakeOrganizationguid = string.Empty;
                string EngineTypeguid = string.Empty;
                string Yearguid = string.Empty;
                string Modelguid = string.Empty;
                string ItemName = string.Empty;
                string GenericName = string.Empty;
                string ItemCode = string.Empty;
                if (this.txtManufacturerFilter.Tag != null && this.txtManufacturerFilter.Text != string.Empty)
                    Manufacturerguid = this.txtManufacturerFilter.Tag.ToString();

                MakeOrganizationguid = CCommon.GetItemData(this.cboItemCategoryFilter);
                if (MakeOrganizationguid == "-1") MakeOrganizationguid = string.Empty;

                EngineTypeguid = CCommon.GetItemData(this.cboEngineTypeFilter);
                if (EngineTypeguid == "-1") EngineTypeguid = string.Empty;

                Yearguid = CCommon.GetItemData(this.cboYearFilter);
                if (Yearguid == "-1") Yearguid = string.Empty;

                Modelguid = CCommon.GetItemData(this.cboModelFilter);
                if (Modelguid == "-1") Modelguid = string.Empty;

                ItemName = txtBrandNameFilter.Text;

                ItemCode = txtItemCodeFilter.Text;


                FillItemsList(Manufacturerguid,MakeOrganizationguid,EngineTypeguid,Yearguid,Modelguid,ItemName, GenericName, ItemCode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchProduct(string Productguid)
        {
            try
            {
                CProducts product = new CProducts();
                DataTable dt = new DataTable();

                product.Id = CProducts.GetTableRowId(Productguid);
                dt = product.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    chkProductsStatus.CheckState = Convert.ToInt32(product.Status) == 0 ? CheckState.Unchecked : CheckState.Checked;

                    if (bNewItems)
                    {
                       
                    }

                }
                else
                {
                    MessageBox.Show("Record not found! ", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
                this.grpItemsEntry.Width = this.lblTitle.Width - this.grpItemsEntry.Left - 24;

                // Transactions listview
                this.lvwItems.Height = this.Height - this.lvwItems.Top - 65;

                // Detail Groupbox
                this.tabControlChildren.Height = this.Height - this.tabControlChildren.Top - 65;
                this.tabControlChildren.Width = this.lblTitle.Width - this.tabControlChildren.Left - 24;

                this.lvwBatchs.Width = this.tabPageBatches.Width - 12;
                this.lvwBatchs.Height = this.tabPageBatches.Height - this.lvwBatchs.Top - 12;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            try
            {
                lblMsg.Text = null;
                
                CCommon.FillComboBox(cbomakeorganization, "Select TableRowGuid, name from tblMakeOrganizations", "TableRowGuid", "Name", true);
                CCommon.FillComboBox(cboYear, "Select TableRowGuid, name from tblYear", "TableRowGuid", "Name", true);
                CCommon.FillComboBox(cboModel, "Select TableRowGuid, name from tblModel", "TableRowGuid", "Name", true);
                CCommon.FillComboBox(cboEngineType, "Select TableRowGuid, name from tblEngineType", "TableRowGuid", "Name", true);
                CCommon.FillComboBox(cboItemCategoryFilter, "Select TableRowGuid, name from tblMakeOrganizations", "TableRowGuid", "Name", false);
                CCommon.FillComboBox(cboEngineTypeFilter, "Select TableRowGuid, name from tblEngineType", "TableRowGuid", "Name", false);
                CCommon.FillComboBox(cboYearFilter, "Select TableRowGuid, name from tblYear", "TableRowGuid", "Name", false);
                CCommon.FillComboBox(cboModelFilter, "Select TableRowGuid, name from tblModel", "TableRowGuid", "Name", false);
                this.ShowImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmItems_Activated(object sender, EventArgs e)
        {
            try
            {
                if (!already_in)
                {
                    already_in = true;
                    //FillItemsList();
                    cboItemCategoryFilter.SelectedIndex = CCommon.GetIndexByItemData(cboItemCategoryFilter, "-1", false);
                    cboEngineTypeFilter.SelectedIndex = CCommon.GetIndexByItemData(cboEngineTypeFilter, "-1", false);
                    cboYearFilter.SelectedIndex = CCommon.GetIndexByItemData(cboYearFilter, "-1", false);
                    cboModelFilter.SelectedIndex = CCommon.GetIndexByItemData(cboModelFilter, "-1", false);
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
        private void btnSaveItems_Click(object sender, EventArgs e)
        {
            try
            {
                 
                bool bSaved = false;

                bSaved = SaveItems();

                if (bSaved)
                {
                    UpdateItemsList();
                    NewItems();
                    FillList();
                 
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CItems objItems = new CItems();
                    objItems.Id = Convert.ToInt32(lvwItems.SelectedItems[0].SubItems[colItemsId.Index].Text);
                    objItems.Delete();
                    lvwItems.Items.Remove(lvwItems.SelectedItems[0]);

                    NewItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewItems_Click(object sender, EventArgs e)
        {
            try
            {
                this.lvwItems.SelectedItems.Clear();
                bNewItems = true;
                ItemsId = 0;
                NewItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwItems_SelectedIndexChanged(object sender, EventArgs e)
        {
 
            try
            {
                if (lvwItems.SelectedItems == null) return;
                if (lvwItems.SelectedItems.Count <= 0) return;

                EditItems();
                FillBatchsListByParent(this.ItemsId.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchItems_Click(object sender, EventArgs e)
        {
            //frmFindByName frmF = new frmFindByName();
            //frmF.ShowDialog();
            //if (frmF.bCancel == true) return;
            //this.ItemsId = Convert.ToInt32(frmF.PID.ToString());
            //this.FindItems();
        }
        private void btnFindItems_Click(object sender, EventArgs e)
        {
            try
            {
                FindItems();
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
        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectProduct frm = new frmSelectProduct();
                frm.ShowDialog();
                if (frm.bCancel == true) return;

                //SearchProduct(this.txtItemsProductid.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmItems_Resize(object sender, EventArgs e)
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
            //    SearchManufacturer(txtManufacturerFilter, grpItemsList.Left, grpItemsList.Top);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        #endregion

        #region Batches Functions

        private void FillBatchsListByParent(string strItemGuid)
        {
            try
            {

                CBatchs objBatchs = new CBatchs();

                ArrayList ar = new ArrayList(objBatchs.GetListByItem(strItemGuid));
                this.lvwBatchs.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CBatchs Batchs in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {  Batchs.Id.ToString(), 
                                                                                      Batchs.Purchaseorderguid.ToString(), 
                                                                                      Batchs.Batchnumber.ToString(), 
                                                                                      Batchs.Itemguid.ToString(),  
                                                                                      Batchs.Quantity.ToString(), 
                                                                                      Batchs.Priceperunit.ToString(), 
                                                                                      Batchs.Freightpayments.ToString(), 
                                                                                      Batchs.Insurancepayments.ToString(), 
                                                                                      Batchs.Bankpayments.ToString(), 
                                                                                      Batchs.Otherpayments.ToString(), 
                                                                                      Batchs.Suggestedsaleprice.ToString(), 
                                                                                      Batchs.Saleprice.ToString()}); 
                                                                                      
                    this.lvwBatchs.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void lvwItems_Click(object sender, EventArgs e)
        {
            try
            {
                lvwItems_SelectedIndexChanged(sender, e);
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
                SearchManufacturer(txtManufacturerFilter, grpItemsList.Left, grpItemsList.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboItemsCategoryid_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cboItemsCategoryid.SelectedIndex > 0)
            //{
            //    if (cboItemsCategoryid.SelectedIndex == 3)
            //        chkIsVATAvailable.Checked = true;
            //    else
            //        chkIsVATAvailable.Checked = false;
            //}
        }
        private void cbomakeorganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cboItemsCategoryid.SelectedIndex > 0)
            //{
            //    if (cboItemsCategoryid.SelectedIndex == 3)
            //        chkIsVATAvailable.Checked = true;
            //    else
            //        chkIsVATAvailable.Checked = false;
            //}
        }


        private void txtBrandNameFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            try 
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    FillList();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtItemCodeFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    FillList();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



       

        private void btnSearchManufacturer_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmSelectManufacturer frmManu = new frmSelectManufacturer();
                frmManu.ShowDialog();
                if (frmManu.bCancel == true) return;
                this.txtItemsManufacturerid.Tag = frmManu.Manufacturerguid.ToString();
                this.txtItemsManufacturerid.Text = frmManu.ManufacturerName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grpItemsEntry_Enter(object sender, EventArgs e)
        {

        }

        private void cboItemCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void ssItems_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnImportLogo_Click(object sender, EventArgs e)
        {
            try
            {
                dlgOpenFileDialog.Title = "Select a Logo";
                dlgOpenFileDialog.Multiselect = false;
                dlgOpenFileDialog.Filter = "JPEG Compressed Image(*.jpg)|*.jpg|Graphic Interchange Format (*.gif)|*.gif";
                dlgOpenFileDialog.FilterIndex = 1;
                dlgOpenFileDialog.FileName = "";
                dlgOpenFileDialog.ShowDialog();
                picItemPicture.ImageLocation = dlgOpenFileDialog.FileName;
                picItemPicture.Text = dlgOpenFileDialog.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPasteLogo_Click(object sender, EventArgs e)
        {

            try
            {
                if (Clipboard.GetDataObject() != null)
                {
                    IDataObject data = Clipboard.GetDataObject();

                    if (data.GetDataPresent(DataFormats.Bitmap))
                    {
                        Image image = (Image)data.GetData(DataFormats.Bitmap, true);
                        picItemPicture.Image = image;
                    }
                    else
                    {
                        MessageBox.Show("No image exists in the clipboard.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefreshLogo_Click(object sender, EventArgs e)
        {
            try
            {
                if (CImageSetting.OrganizationLogo != null)
                {
                    picItemPicture.Image = CPhoto.ByteArrayToPicture(CImageSetting.OrganizationLogo);

                }
                else
                    picItemPicture.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowImage()
        {
            try
            {
                if (CImageSetting.OrganizationLogo != null)
                    picItemPicture.Image = CPhoto.ByteArrayToPicture(CImageSetting.OrganizationLogo);
                else
                    picItemPicture.Image = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         private void WriteSettings()
        {
            try
            {
                
                byte[] logo;
                if (picItemPicture.Image != null)
                {
                    logo = CPhoto.PictureToByteArray(picItemPicture.Image);
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", logo, "");
                }
                else
                    CImageAppSetting.SaveSetting("Pharma", "OrganizationLogo", "", "", null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearLogo_Click(object sender, EventArgs e)
        {
            try
            {
                picItemPicture.Image = null;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbomakeorganization_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

            
    }
}