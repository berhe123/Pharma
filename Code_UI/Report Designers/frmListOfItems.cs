using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharma
{
    public partial class frmListOfItems : Form
    {
        private const string DialogCaption = "List of Items";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        public frmListOfItems()
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

        public void ShowItems()
        {
            try
            {
                DataTable dt = new DataTable();
                rptItemsList rpt = new rptItemsList();
                frmReportViewer frm = null;

                string Manufacturerguid = "0";
                string Itemcategoryguid = "0";
                string ReorderLevel = "0";

                Manufacturerguid = this.txtManufacturerFilter.Tag != null ? this.txtManufacturerFilter.Tag.ToString() : "0";
                Itemcategoryguid = CCommon.GetItemData(cboItemCategory);
                ReorderLevel = this.txtReorderLevel.Text.Length > 0 ? this.txtReorderLevel.Text : "0";

                rpt.Manufacturerguid = Manufacturerguid;
                rpt.Itemcategoryguid = Itemcategoryguid;
                rpt.ReorderLevel = Convert.ToDecimal(ReorderLevel);

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT TOP (100) PERCENT dbo.tblItems.Id, dbo.tblItems.TableRowGuid, dbo.tblItems.MakeOrganizationGuid , dbo.tblItems.ManufacturerGuid, dbo.tblItems.GenericName,   ";
                strSQL = strSQL + "                 dbo.tblItems.ModelGuid , dbo.tblItems.Measurement, dbo.tblItems.Strength, dbo.tblItems.ItemCode, ";
                strSQL = strSQL + "                 dbo.tblItems.ShelfLife, dbo.tblItems.ReorderLevel, dbo.tblItems.SellableBactchGuid, dbo.tblItems.MonthlySalesForecast,   ";
                strSQL = strSQL + "                 dbo.tblItems.ProfitMargin, dbo.tblManufacturers.Name AS Manufacturer, dbo.tblMakeOrganizations.Name AS ItemCategory,   ";
                strSQL = strSQL + "                 dbo.tblModel.Name AS Modeltype,   ";
                strSQL = strSQL + "                 (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
                strSQL = strSQL + "                 inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid  ";
                strSQL = strSQL + "                 inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblManufacturers on tblManufacturers.TableRowGuid =tblItems.ManufacturerGuid ";               
                strSQL = strSQL + " WHERE (IsNull(ReorderLevel, 0) >= " + ReorderLevel + ")  ";
                if (Manufacturerguid != "" && Manufacturerguid != "0" && Manufacturerguid != "-1") strSQL = strSQL + " AND (ManufacturerGuid = '" + Manufacturerguid + "') ";
                if (Itemcategoryguid != "-1") strSQL = strSQL + " AND (MakeOrganizationGuid  = '" + Itemcategoryguid + "') ";
                strSQL = strSQL + " Order By Manufacturer, ItemCategory,BrandName ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "List of Items";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    MessageBox.Show("Report generation - No record found", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowItemsStockValue()
        {
            try
            {
                DataTable dt = new DataTable();
                rptItemsStockValueList rpt = new rptItemsStockValueList();
                frmReportViewer frm = null;

                string Manufacturerguid = "0";
                string Itemcategoryguid = "0";
                string ReorderLevel = "0";

                Manufacturerguid = this.txtManufacturerFilter.Tag != null ? this.txtManufacturerFilter.Tag.ToString() : "0";
                Itemcategoryguid = CCommon.GetItemData(cboItemCategory);
                ReorderLevel = this.txtReorderLevel.Text.Length > 0 ? this.txtReorderLevel.Text : "0";

                rpt.Manufacturerguid = Manufacturerguid;
                rpt.Itemcategoryguid = Itemcategoryguid;
                rpt.ReorderLevel = Convert.ToDecimal(ReorderLevel);

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT TOP (100) PERCENT dbo.tblItems.Id, dbo.tblItems.TableRowGuid, dbo.tblItems.MakeOrganizationGuid , dbo.tblItems.ManufacturerGuid, dbo.tblItems.GenericName,   ";
                strSQL = strSQL + "                 dbo.tblItems.ModelGuid , dbo.tblItems.Measurement, dbo.tblItems.Strength,dbo.tblItems.ItemCode,   ";
                strSQL = strSQL + "                 dbo.tblItems.ShelfLife, dbo.tblItems.ReorderLevel, dbo.tblItems.SellableBactchGuid, dbo.tblItems.MonthlySalesForecast,   ";
                strSQL = strSQL + "                 dbo.tblItems.ProfitMargin, dbo.tblManufacturers.Name AS Manufacturer, dbo.tblMakeOrganizations.Name AS ItemCategory,   ";
                strSQL = strSQL + "                 dbo.tblModel.Name AS Modeltype,  ";
                strSQL = strSQL + "                 BatchNumber, PricePerUnit as UnitCost, (QuantityAtHand.Balance * PricePerUnit) AS LineTotalCost, ";
                strSQL = strSQL + "                 QuantityAtHand.Balance AS QuantityAtHand, ";
                strSQL = strSQL + "                 (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
                strSQL = strSQL + "                 inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid  ";
                strSQL = strSQL + "                 inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblManufacturers on tblManufacturers.TableRowGuid =tblItems.ManufacturerGuid  "; 
                strSQL = strSQL + "                 LEFT OUTER JOIN ";
                strSQL = strSQL + "                 (SELECT	tblBatchs.ItemGuid, BatchNumber, PricePerUnit , Balance = SUM(Received) -	SUM(Issued) - SUM(Damaged) - SUM(Recalled)  ";
                strSQL = strSQL + "                  FROM tblBatchs LEFT OUTER JOIN ";
                strSQL = strSQL + "                      (SELECT BatchGuid, ";
                strSQL = strSQL + "                              ISNULL(ReceivedQuantity, 0) AS Received,  ";
                strSQL = strSQL + "                              ISNULL(IssuedQuantity, 0) AS Issued,  ";
                strSQL = strSQL + "                              ISNULL(DamagedQuantity, 0) AS Damaged,  ";
                strSQL = strSQL + "                              ISNULL(RecalledQuantity, 0) AS Recalled ";
                strSQL = strSQL + "                      FROM StockUptoDateBalance(GetDate())) AS Balance ";
                strSQL = strSQL + "                      ON tblBatchs.TableRowGuid = Balance.BatchGuid ";
                strSQL = strSQL + "                  Group by tblBatchs.ItemGuid, BatchNumber, PricePerUnit) QuantityAtHand ";
                strSQL = strSQL + "                  ON dbo.tblItems.TableRowGuid = QuantityAtHand.ItemGuid  ";

                strSQL = strSQL + " WHERE (1=1) AND QuantityAtHand.Balance > 0 ";
                if (Manufacturerguid != "" && Manufacturerguid != "0" && Manufacturerguid != "-1") strSQL = strSQL + " AND (ManufacturerGuid = '" + Manufacturerguid + "') ";
                if (Itemcategoryguid != "-1") strSQL = strSQL + " AND (MakeOrganizationGuid  = '" + Itemcategoryguid + "') ";
                strSQL = strSQL + " Order By Manufacturer, ItemCategory, BrandName ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "List of Items";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    MessageBox.Show("Report generation - No record found", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowItemsPriceList()
        {
            try
            {
                DataTable dt = new DataTable();
                rptItemsPriceList rpt = new rptItemsPriceList();
                frmReportViewer frm = null;

                string Manufacturerguid = "0";
                string Itemcategoryguid = "0";
                string Storeguid = "0";

                Manufacturerguid = this.txtManufacturerFilter.Tag != null ? this.txtManufacturerFilter.Tag.ToString() : "0";
                Itemcategoryguid = CCommon.GetItemData(cboItemCategory);
                Storeguid = CCommon.GetItemData(cboStoreName);

                rpt.Manufacturerguid = Manufacturerguid;
                rpt.Itemcategoryguid = Itemcategoryguid;
                rpt.Location = this.cboStoreLocation.Text;
                rpt.Store = this.cboStoreName.Text;
                rpt.Storeguid = Storeguid;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT TOP (100) PERCENT dbo.tblItems.Id, dbo.tblItems.TableRowGuid, dbo.tblItems.MakeOrganizationGuid, dbo.tblItems.ManufacturerGuid, dbo.tblItems.GenericName,   ";
                strSQL = strSQL + "                 dbo.tblItems.ModelGuid, dbo.tblItems.Measurement, dbo.tblItems.Strength,dbo.tblItems.ItemCode,   ";
                strSQL = strSQL + "                 dbo.tblItems.ShelfLife, dbo.tblItems.ReorderLevel, dbo.tblItems.SellableBactchGuid, dbo.tblItems.MonthlySalesForecast,   ";
                strSQL = strSQL + "                 dbo.tblItems.ProfitMargin, dbo.tblManufacturers.Name AS Manufacturer, dbo.tblMakeOrganizations.Name AS ItemCategory,   ";
                strSQL = strSQL + "                 dbo.tblModel.Name AS Modeltype,   ";               
                strSQL = strSQL + "                 dbo.tblBatchs.BatchNumber, dbo.tblBatchs.SalePrice AS UnitPrice, dbo.tblBatchs.ExpiryDate, ";
                strSQL = strSQL + "                 (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
                strSQL = strSQL + "                 inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid  ";
                strSQL = strSQL + "                 inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblManufacturers on tblManufacturers.TableRowGuid =tblItems.ManufacturerGuid  "; 
                strSQL = strSQL + "                 LEFT OUTER JOIN dbo.tblBatchs ON dbo.tblItems.SellableBactchGuid= dbo.tblBatchs.TableRowGuid ";      


                //strSQL = strSQL + " FROM      dbo.tblMakeOrganizations INNER JOIN  ";
                //strSQL = strSQL + "                 dbo.tblItems ON dbo.tblMakeOrganizations.TableRowGuid = dbo.tblItems.MakeOrganizationGuid INNER JOIN  ";
                //strSQL = strSQL + "                 dbo.tblManufacturers ON dbo.tblItems.ManufacturerGuid = dbo.tblManufacturers.TableRowGuid INNER JOIN  ";
                //strSQL = strSQL + "                 dbo.tblModel ON dbo.tblItems.ModelGuid  = dbo.tblModel.TableRowGuid ";                
                //strSQL = strSQL + "                 LEFT OUTER JOIN dbo.tblBatchs ON dbo.tblItems.SellableBactchGuid= dbo.tblBatchs.TableRowGuid  ";
                strSQL = strSQL + " WHERE (1=1)  ";
                if (Manufacturerguid != "" && Manufacturerguid != "0" && Manufacturerguid != "-1") strSQL = strSQL + " AND (ManufacturerGuid = '" + Manufacturerguid + "') ";
                if (Itemcategoryguid != "-1") strSQL = strSQL + " AND (MakeOrganizationGuid  = '" + Itemcategoryguid + "') ";
                strSQL = strSQL + " Order By Manufacturer, ItemCategory, BrandName ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Items Price List";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    MessageBox.Show("Report generation - No record found", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowItemsBelowReorderLevel()
        {
            try
            {
                DataTable dt = new DataTable();
                rptItemsBelowReorderLevel rpt = new rptItemsBelowReorderLevel();
                frmReportViewer frm = null;

                string Manufacturerguid = "0";
                string Itemcategoryguid = "0";
                string Storeguid = "0";

                Manufacturerguid = this.txtManufacturerFilter.Tag != null ? this.txtManufacturerFilter.Tag.ToString() : "0";
                Itemcategoryguid = CCommon.GetItemData(cboItemCategory);
                Storeguid = CCommon.GetItemData(cboStoreName);

                rpt.Manufacturerguid = Manufacturerguid;
                rpt.Itemcategoryguid = Itemcategoryguid;
                rpt.Location = this.cboStoreLocation.Text;
                rpt.Store = this.cboStoreName.Text;
                rpt.Storeguid = Storeguid;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT TOP (100) PERCENT dbo.tblItems.Id, dbo.tblItems.TableRowGuid, dbo.tblItems.MakeOrganizationGuid, dbo.tblItems.ManufacturerGuid, dbo.tblItems.GenericName,   ";
                strSQL = strSQL + "                 dbo.tblItems.ModelGuid, dbo.tblItems.Measurement, dbo.tblItems.Strength,dbo.tblItems.ItemCode,   ";
                strSQL = strSQL + "                 dbo.tblItems.ShelfLife, dbo.tblItems.ReorderLevel, dbo.tblItems.SellableBactchGuid, dbo.tblItems.MonthlySalesForecast,   ";
                strSQL = strSQL + "                 dbo.tblItems.ProfitMargin, dbo.tblManufacturers.Name AS Manufacturer, dbo.tblMakeOrganizations.Name AS ItemCategory,   ";
                strSQL = strSQL + "                 dbo.tblModel.Name AS Modeltype,   ";
                strSQL = strSQL + "                 QuantityAtHand.Balance AS QuantityAtHand,";
                strSQL = strSQL + "                 dbo.tblBatchs.BatchNumber, dbo.tblBatchs.SalePrice AS UnitPrice, dbo.tblBatchs.ExpiryDate, ";
                strSQL = strSQL + "                 (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
                strSQL = strSQL + "                 inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid  ";
                strSQL = strSQL + "                 inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblBatchs on tblBatchs.ItemGuid =tblItems.TableRowGuid "; 
                strSQL = strSQL + "                 inner join tblManufacturers on tblManufacturers.TableRowGuid =tblItems.ManufacturerGuid  ";            
                strSQL = strSQL + "                 LEFT OUTER JOIN ";
                strSQL = strSQL + "                 (SELECT	tblBatchs.ItemGuid, Balance = SUM(Received) -	SUM(Issued) - SUM(Damaged) - SUM(Recalled)  ";
                strSQL = strSQL + "                  FROM tblBatchs LEFT OUTER JOIN ";
                strSQL = strSQL + "                      (SELECT BatchGuid, ";
                strSQL = strSQL + "                              ISNULL(ReceivedQuantity, 0) AS Received,  ";
                strSQL = strSQL + "                              ISNULL(IssuedQuantity, 0) AS Issued,  ";
                strSQL = strSQL + "                              ISNULL(DamagedQuantity, 0) AS Damaged,  ";
                strSQL = strSQL + "                              ISNULL(RecalledQuantity, 0) AS Recalled ";
                strSQL = strSQL + "                      FROM StockUptoDateBalance(GetDate())) AS Balance ";
                strSQL = strSQL + "                      ON tblBatchs.TableRowGuid = Balance.BatchGuid ";
                strSQL = strSQL + "                  Group by tblBatchs.ItemGuid) QuantityAtHand ";
                strSQL = strSQL + "                  ON dbo.tblItems.TableRowGuid = QuantityAtHand.ItemGuid  ";

                strSQL = strSQL + " WHERE (1=1) AND QuantityAtHand.Balance >= 0 ";
                if (Manufacturerguid != "" && Manufacturerguid != "0" && Manufacturerguid != "-1") strSQL = strSQL + " AND (ManufacturerGuid = '" + Manufacturerguid + "') ";
                if (Itemcategoryguid != "-1") strSQL = strSQL + " AND (MakeOrganizationGuid = '" + Itemcategoryguid + "') ";
                strSQL = strSQL + " Order By Manufacturer, ItemCategory, BrandName ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Items Price List";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    MessageBox.Show("Report generation - No record found", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (optSimpleList.Checked == true)
                    ShowItems();
                else if (optPriceList.Checked == true)
                    ShowItemsPriceList();
                else if (optItemQuantityBelowReorderLevel.Checked == true)
                    ShowItemsBelowReorderLevel();
                else if(optStockValue.Checked)
                    ShowItemsStockValue();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void frmListOfItems_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillComboBox(cboItemCategory, "Select TableRowGuid, name from tblMakeOrganizations Order by Name ", "TableRowGuid", "name", false);
                CCommon.FillComboBox(cboStoreLocation, "Select TableRowGuid, name from tblLocations Order by Name ", "TableRowGuid", "name");
                cboStoreLocation.SelectedIndex = CCommon.GetIndexByItemData(cboStoreLocation, CSettings.DefaultWorkingLocation.ToString(), true);
                cboStoreName.SelectedIndex = CCommon.GetIndexByItemData(cboStoreName, CSettings.DefaultWorkingManufacturer.ToString(), true);
                this.txtManufacturerFilter.Tag = CSettings.DefaultWorkingManufacturer.ToString();
                this.txtManufacturerFilter.Text = CManufacturers.GetManufacturerNameFromCollection(CSettings.DefaultWorkingManufacturer);
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

                this.txtManufacturerFilter.Tag = frmManu.Manufacturerguid.ToString();
                this.txtManufacturerFilter.Text = frmManu.ManufacturerName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboStoreLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboStoreLocation.SelectedIndex != -1)
                    CCommon.FillComboBox(cboStoreName, "Select TableRowGuid, name from tblStores where LocationGuid = '" + CCommon.GetItemData(cboStoreLocation) + "' Order by Name ", "TableRowGuid", "name");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optSimpleList_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optSimpleList.Checked == true)
                {
                    grpManufacturer.Enabled = true;
                    grpLocation.Enabled = false;
                    grpReorderLevel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optPriceList_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optPriceList.Checked == true)
                {
                    grpManufacturer.Enabled = true;
                    grpLocation.Enabled = true;
                    grpReorderLevel.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optItemQuantityBelowReorderLevel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optItemQuantityBelowReorderLevel.Checked == true)
                {
                    grpManufacturer.Enabled = true;
                    grpLocation.Enabled = true;
                    grpReorderLevel.Enabled = false;
                }
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
                else
                    SearchTextBox.Tag = null;                 
                
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
            //    SearchManufacturer(txtManufacturerFilter, grpManufacturer.Left, grpManufacturer.Top);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSearchManufacturerFilter1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchManufacturer(txtManufacturerFilter, grpManufacturer.Left, grpManufacturer.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optStockValue_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optStockValue.Checked == true)
                {
                    grpManufacturer.Enabled = true;
                    grpLocation.Enabled = false;
                    grpReorderLevel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

    }
}
