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
    public partial class frmStockCard : Form
    {
        private const string DialogCaption = "Stock Card";

        private PopupWindowHelper popupHelper = null;
        private frmManufacturerSelector manSelector = null;

        public frmStockCard()
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

        private void ShowStockCard()
        {
            try
            {
                DataTable dt = new DataTable();
                rptStockCard rpt = new rptStockCard();
                frmReportViewer frm = null;

                string Storeguid = "0";
                string Itemguid = "0";

                Storeguid = CCommon.GetItemData(cboStoreName);
                Itemguid = CCommon.GetItemData(cboItem);

                if (Storeguid == "-1" || Storeguid == "0" || Storeguid == "")
                {
                    MessageBox.Show("Please select a store", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (Itemguid == "-1" || Itemguid == "0" || Itemguid == "")
                {
                    MessageBox.Show("Please select an item", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                rpt.DateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text);
                rpt.DateTo = CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text);
                rpt.Location = this.cboStoreLocation.Text;
                rpt.Store = this.cboStoreName.Text;
                rpt.Storeguid = Storeguid;
                rpt.Manufacturer = this.txtManufacturerFilter.Text;
                rpt.Itemguid = Itemguid;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT	vwStoreTransactions.TransactionDetailGuid as TableRowGuid, ";         
                strSQL = strSQL + " 		tblModel.Name + ' ' + tblItems.Measurement AS Modeltype,  ";
                strSQL = strSQL + " 		tblBatchs.BatchNumber, vwStoreTransactions.TransactionDate, vwStoreTransactions.TransactionType, ";
                strSQL = strSQL + " 		vwStoreTransactions.Quantity, vwStoreTransactions.StoreGuid ,";
                strSQL = strSQL + "                 (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
                strSQL = strSQL + "                 inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid  ";
                strSQL = strSQL + "                 inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblBatchs on tblBatchs.ItemGuid =tblItems.TableRowGuid "; 
                
                strSQL = strSQL + " 			 INNER JOIN ";
                //strSQL = strSQL + " 		dbo.vwStoreTransactions  ";
                strSQL = strSQL + " 		(Select * From vwStoreTransactions  ";
                strSQL = strSQL + " 		    Where Isnull(InvoiceGuid,'') Not IN  ";
                strSQL = strSQL + " 		        (Select InvoiceGuid From vwInvoices  ";
                strSQL = strSQL + " 		        Where vwInvoices.DeliveryStatus = 2)) AS vwStoreTransactions  ";
                strSQL = strSQL + " 			ON dbo.tblBatchs.TableRowGuid = vwStoreTransactions.BatchGuid ";
                strSQL = strSQL + " WHERE (TransactionDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                strSQL = strSQL + " AND (TransactionDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                strSQL = strSQL + " AND (StoreGuid = '" + Storeguid + "')  ";
                strSQL = strSQL + " AND (dbo.tblBatchs.TableRowGuid IN (SELECT TableRowGuid FROM tblBatchs WHERE ItemGuid = '" + Itemguid + "')) ";
                strSQL = strSQL + " ORDER BY transactiondate,TrasactionTime ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Stock Card";
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

        private void ShowStockCardOrganizationSpecific()
        {
            try
            {
                DataTable dt = new DataTable();
                rptStockCardWithInvoice rpt = new rptStockCardWithInvoice();
                frmReportViewer frm = null;

                string Storeguid = "0";
                string Itemguid = "0";

                Storeguid = CCommon.GetItemData(cboStoreName);
                Itemguid = CCommon.GetItemData(cboItem);

                rpt.DateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text);
                rpt.DateTo = CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text);
                rpt.Location = this.cboStoreLocation.Text;
                rpt.Store = this.cboStoreName.Text;
                rpt.Storeguid = Storeguid;
                rpt.Manufacturer = this.txtManufacturerFilter.Text;
                rpt.Itemguid = Itemguid;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT	vwStoreTransactions.TransactionDetailGuid as TableRowGuid, ";
                strSQL = strSQL + " 		 tblModel.Name + ' ' + tblItems.Measurement AS Modeltype,  ";
                strSQL = strSQL + " 		tblBatchs.BatchNumber, vwStoreTransactions.TransactionDate, vwStoreTransactions.TransactionType, ";
                strSQL = strSQL + " 		vwStoreTransactions.Quantity, vwStoreTransactions.StoreGuid, ";
                strSQL = strSQL + " 		vwInvoices.DeliveryStatus, vwInvoices.InvoiceDate, vwInvoices.ReferenceNumber AS InvoiceNumber, tblCustomers.Name AS Customer, ";
                strSQL = strSQL + "                 (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
                strSQL = strSQL + "                 inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid  ";
                strSQL = strSQL + "                 inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblBatchs on tblBatchs.ItemGuid =tblItems.TableRowGuid ";  
                strSQL = strSQL + " 			 INNER JOIN ";
                //strSQL = strSQL + " 		vwStoreTransactions  ";
                strSQL = strSQL + " 		(Select * From vwStoreTransactions  ";
                strSQL = strSQL + " 		    Where Isnull(InvoiceGuid,'') Not IN  ";
                strSQL = strSQL + " 		        (Select InvoiceGuid From vwInvoices  ";
                strSQL = strSQL + " 		        Where vwInvoices.DeliveryStatus = 2)) AS vwStoreTransactions  ";
                strSQL = strSQL + " 			ON dbo.tblBatchs.TableRowGuid = vwStoreTransactions.BatchGuid LEFT OUTER JOIN ";
                strSQL = strSQL + " 		vwInvoices  ";
                strSQL = strSQL + " 			ON vwInvoices.InvoiceGuid = vwStoreTransactions.InvoiceGuid ";
                strSQL = strSQL + " 			AND tblBatchs.TableRowGuid = vwInvoices.BatchGuid ";
                strSQL = strSQL + " 			AND vwInvoices.DeliveryStatus = 1 LEFT OUTER JOIN ";
                strSQL = strSQL + " 		dbo.tblCustomers  ";
                strSQL = strSQL + " 			ON dbo.tblCustomers.TableRowGuid = vwInvoices.CustomerGuid ";
                strSQL = strSQL + " WHERE (TransactionDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                strSQL = strSQL + " AND (TransactionDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                strSQL = strSQL + " AND (StoreGuid = '" + Storeguid + "')  ";
                strSQL = strSQL + " AND (dbo.tblBatchs.TableRowGuid IN (SELECT TableRowGuid FROM tblBatchs WHERE ItemGuid = '" + Itemguid + "')) ";
                strSQL = strSQL + " ORDER BY transactiondate,TrasactionTime,cast(vwInvoices.ReferenceNumber as int)";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Stock Card";
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
                if (optStandard.Checked == true)
                    ShowStockCard();
                else if (optOrganizationSpecific.Checked == true)
                    ShowStockCardOrganizationSpecific();
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

        private void frmStockCard_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillComboBox(cboStoreLocation, "Select TableRowGuid, name from tblLocations Order by Name ", "TableRowGuid", "name");

                cboStoreLocation.SelectedIndex = CCommon.GetIndexByItemData(cboStoreLocation, CSettings.DefaultWorkingLocation.ToString(), true);
                cboStoreName.SelectedIndex = CCommon.GetIndexByItemData(cboStoreName, CSettings.DefaultWorkingStore.ToString(), true);
                this.txtManufacturerFilter.Tag = CSettings.DefaultWorkingManufacturer.ToString();
                this.txtManufacturerFilter.Text = CManufacturers.GetManufacturerNameFromCollection(CSettings.DefaultWorkingManufacturer);
                GetItemsByManufacturer();

                this.txtDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtManufacturer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //SearchManufacturer(txtManufacturerFilter, grpFilter.Left, grpFilter.Top);

                //string Manufacturerguid = string.Empty;
                //CManufacturers objMan = null;

                //if (this.txtManufacturerFilter.Tag != null)
                //    if (this.txtManufacturerFilter.Tag.ToString() != string.Empty)
                //        Manufacturerguid = this.txtManufacturerFilter.Tag.ToString();
                //objMan = CManufacturers.FindManufacturerFromCollection(Manufacturerguid);

                //CCommon.FillComboBox(this.cboItem, "Select TableRowGuid, BrandName + ' (' + GenericName + ') ' + Strength as ItemName from tblItems where ManufacturerId = '" + Manufacturerguid + "'  Order by ItemName ", "TableRowGuid", "ItemName");
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
                    CCommon.FillComboBox(cboStoreName, "Select TableRowGuid, name from tblStores where LocationGuid = '" + CCommon.GetItemData(cboStoreLocation) + "'  Order by Name ", "TableRowGuid", "name");
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

        private void GetItemsByManufacturer()
        {
            try
            {
                string Manufacturerguid = string.Empty;
                CManufacturers objMan = null;

                if (this.txtManufacturerFilter.Tag != null)
                    if (this.txtManufacturerFilter.Tag.ToString() != string.Empty)
                        Manufacturerguid = this.txtManufacturerFilter.Tag.ToString();
                objMan = CManufacturers.FindManufacturerFromCollection(Manufacturerguid);

                string strSQL = "";
                strSQL = strSQL + " select (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName ) as ItemName, tblitems.TableRowGuid from tblitems ";
                strSQL = strSQL + " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
                strSQL = strSQL + " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
                strSQL = strSQL + " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
                strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
                strSQL = strSQL + " where ManufacturerGuid = '" + Manufacturerguid + "' Order by ItemName ";

                //CCommon.FillComboBox(this.cboItem, " where ManufacturerGuid = '" + Manufacturerguid + "' Order by ItemName ", "TableRowGuid", "ItemName");

                CCommon.FillComboBox(this.cboItem, strSQL, "TableRowGuid", "ItemName");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchManufacturerFilter1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchManufacturer(txtManufacturerFilter, grpFilter.Left, grpFilter.Top);
                GetItemsByManufacturer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

    }
}
