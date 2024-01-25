using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SecurityManager;
using System.Collections;
using Pharma.Code_UI.Data_Entry_Designers;
using Pharma.Code_UI.Data_Entry_Designers.Lookup_Maintenance;

namespace Pharma
{
    public partial class frmMain : Form
    {
        private const string DialogCaption = "Main Application Workspace";

        DataTable dtReorderLevel = new DataTable();
        DataTable dtExpiryNotification = new DataTable();
        DataTable dtMaturityChecks = new DataTable();
        DataTable dtSettled = new DataTable();
       // private string strTableRowGuid = string.Empty;

        public frmMain()
        {
            InitializeComponent();
        }

        private void recievingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceiving childForm = new frmReceiving();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                childForm.btnDelete.Enabled = false;
                childForm.btnSaveDetail.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;
                childForm.btnGetBatchesFromPurchaseOrder.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Text = recievingToolStripMenuItem.Text;
            
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void issuanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssuance childForm = new frmIssuance();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                childForm.btnDelete.Enabled = false;
                childForm.btnSaveDetail.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;
                childForm.btnGetBatchesFromInvoice.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Text = issuanceToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }
      

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers childForm = new frmCustomers();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveCountries.Enabled = false;
                childForm.btnDeleteCountries.Enabled = false;                
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {                
                childForm.btnDeleteCountries.Enabled = false;                               
            }
            childForm.MdiParent = this;
            childForm.Text = customerToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

       
        private void marketStudyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMarketStudy childForm = new frmMarketStudy();
            //childForm.MdiParent = this;
            //childForm.Text = marketStudyToolStripMenuItem.Text;
            //childForm.Show();
        }

        private void productCertifiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmProductCertificates childForm = new frmProductCertificates();
            //childForm.MdiParent = this;
            //childForm.Text = productCertifiToolStripMenuItem.Text;
            //childForm.Show();
        }

        private void itemRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItems childForm = new frmItems();
            childForm.MdiParent = this;
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveItems.Enabled = false;
                childForm.btnDeleteItems.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteItems.Enabled = false;
            }
            childForm.Text = itemRegistrationToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts childForm = new frmProducts();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnDeleteLikeProducts.Enabled = false;
                childForm.btnDeleteMarketStudies.Enabled = false;
                childForm.btnDeleteProductRegistrationCertificates.Enabled = false;
                childForm.btnDeleteProducts.Enabled = false;
                childForm.btnSaveLikeProducts.Enabled = false;
                childForm.btnSaveMarketStudies.Enabled = false;
                childForm.btnSaveProductRegistrationCertificates.Enabled = false;
                childForm.btnSaveProducts.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteLikeProducts.Enabled = false;
                childForm.btnDeleteMarketStudies.Enabled = false;
                childForm.btnDeleteProductRegistrationCertificates.Enabled = false;
                childForm.btnDeleteProducts.Enabled = false;
            }
            childForm.MdiParent = this;
           // childForm.Text = productsToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManufacturers childForm = new frmManufacturers();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveCountries.Enabled = false;
                childForm.btnDeleteCountries.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteCountries.Enabled = false;
            }
            childForm.MdiParent = this;
            //childForm.Text = manufacturerToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void itemCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItemCategories childForm = new frmItemCategories();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveCountries.Enabled = false;
                childForm.btnDeleteCountries.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteCountries.Enabled = false;
            }
            childForm.ShowDialog();

        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStores childForm = new frmStores();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                childForm.btnDelete.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
            }
            childForm.ShowDialog();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocations childForm = new frmLocations();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveLocations.Enabled = false;
                childForm.btnDeleteLocations.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteLocations.Enabled = false;
            }
            childForm.ShowDialog();
        }

        private void unitOfMeasurementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnitOfMeasurements childForm = new frmUnitOfMeasurements();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveCountries.Enabled = false;
                childForm.btnDeleteCountries.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteCountries.Enabled = false;
            }
            childForm.ShowDialog();
        }

        private void contractTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTermsOfContractTemplates childForm = new frmTermsOfContractTemplates();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                childForm.btnDelete.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
            }
            childForm.ShowDialog();
        }

        private void recallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecall childForm = new frmRecall();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                childForm.btnDelete.Enabled = false;
                childForm.btnSaveDetail.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;
                childForm.btnGetBatchesFromInvoice.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Text = recallToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void damagedItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDamaged childForm = new frmDamaged();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                childForm.btnDelete.Enabled = false;
                childForm.btnSaveDetail.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;               
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Text = damagedItemsToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }
       
        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder childForm = new frmPurchaseOrder();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                childForm.btnDelete.Enabled = false;
               
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;               
            }
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void purchaseOrderProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProcessPurchaseOrder childForm = new frmProcessPurchaseOrder();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveBankPayment.Enabled = false;
                childForm.btnSaveInsurancePayment.Enabled = false;
                childForm.btnSaveOtherPayment.Enabled = false;
                childForm.btnDeleteBankPayment.Enabled = false;
                childForm.btnDeleteInsurancePayment.Enabled = false;
                childForm.btnDeleteOtherPayment.Enabled = false;

            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteBankPayment.Enabled = false;
                childForm.btnDeleteInsurancePayment.Enabled = false;
                childForm.btnDeleteOtherPayment.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void batchRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterBatchs childForm = new frmRegisterBatchs();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveBatch.Enabled = false;
                childForm.btnDeleteBatch.Enabled = false;

            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteBatch.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice childForm = new frmInvoice();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                //childForm.btnPrepareInvoice.Enabled = false;
                childForm.btnDelete.Enabled = false;
                childForm.btnDeliver.Enabled = false;
                childForm.btnReturn.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Text = mnuSalesInvoice.Text;
            CCommon.eDeliveryStatus = CCommon.DeliveryStatus.Pending;
            childForm.intDeliveryStatus = (int)CCommon.DeliveryStatus.Pending;

            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CCommon.FillComboBox(cboItemCategoryFilter, "Select TableRowGuid, name from tblMakeOrganizations order by Name", "TableRowGuid", "Name", false);
            CCommon.FillComboBox(cboItemEngineTypeFilter, "Select TableRowGuid, name from tblEngineType order by Name", "TableRowGuid", "Name", false);
            CCommon.FillComboBox(cboItemYearFilter, "Select TableRowGuid, name from tblYear order by Name", "TableRowGuid", "Name", false);
            CCommon.FillComboBox(cboItemModelFilter, "Select TableRowGuid, name from tblModel order by Name", "TableRowGuid", "Name", false);
            ApplicationSecurityRighits();
            ShowItemsBelowReorderLevel();
            ShowChecks();
            ShowNotSettled();
        }

        private void ApplicationSecurityRighits()
        {
            CLogIn objLoIn = new CLogIn();
            ArrayList ar = new ArrayList(objLoIn.GetApplicationList(Program.intUserId));
            DisableAllMenus();
            foreach (CLogIn App in ar)
            {
               if (App.UserApplication == 1) //Administrator
                {
                    mnuMaintainaces.Enabled = true;
                    mnuReports.Enabled = true;
                    mnuLookups.Enabled = true;
                    mnuUtilities.Enabled = true;                    
                    mnuSettings.Enabled = true;
                    mnuSecurity.Enabled = true;

                    
                    mnuDrugRegistration.Enabled = true;
                    mnuImporting.Enabled = true;
                    mnuMaintainaces.Enabled = true;
                    mnuSales.Enabled = true;
                    mnuStoreManagement.Enabled = true;
                    mnuUtilities.Enabled = true;
                    mnuReports.Enabled = true;
                    mnuSalesStatement.Enabled = true;
                    mnuStockCard.Enabled = true;
                    supplierDetailsToolStripMenuItem.Enabled = true;
                    mnuLookups.Enabled = true;
                    mnuListOfItems.Enabled = true;
                    mnuInvoices.Enabled = true;
                    mnuInvoicesByItem.Enabled = true;                 
                    mnuChecks.Enabled = true;
                    mnuSettings.Enabled = true;
                    mnuSecurity.Enabled = true;
                    localPurchaseToolStripMenuItem.Enabled = true;
                    mnuInvoices.Enabled = true;
                    mnuSalesInvoice.Enabled = true;
                    mnuRequesition.Enabled = true;
                }              
                else if (App.UserApplication == 2) //Sales 
                {
                    mnuSales.Enabled = true;
                    mnuReports.Enabled = true;
                    mnuSalesStatement.Enabled = true;
                    mnuListOfItems.Enabled = true;
                    supplierDetailsToolStripMenuItem.Enabled=true;
                    mnuInvoicesByItem.Enabled = true;
                    mnuDrugRegistration.Enabled = true;
                    mnuUtilities.Enabled = true;
                    mnuStockCard.Enabled = true;
                    mnuRequesition.Enabled = true;
              }
               else if (App.UserApplication == 3) //Cashier 
               {
                   mnuSales.Enabled = true;
                   mnuUtilities.Enabled = true; 
                   mnuInvoices.Enabled = true;
                   mnuSalesInvoice.Enabled = true;

               }
            }


        }


        private void DisableAllMenus()
        {
            //mnuCashCollection.Enabled = false;
            mnuDrugRegistration.Enabled = false;
            mnuImporting.Enabled = false;
            mnuMaintainaces.Enabled = false;
            mnuSales.Enabled = false; 
            mnuStoreManagement.Enabled = false;
            mnuUtilities.Enabled = false;
            mnuReports.Enabled = false;
            mnuSalesStatement.Enabled = false;
            mnuStockCard.Enabled = false;
            mnuLookups.Enabled = false;
            mnuListOfItems.Enabled = false;
            supplierDetailsToolStripMenuItem.Enabled = false;
            mnuInvoices.Enabled = false;
            mnuInvoicesByItem.Enabled = false;
            //mnuPaymentRequest.Enabled = false;
            mnuChecks.Enabled = false;
            mnuSettings.Enabled = false;
            mnuSecurity.Enabled = false;
            localPurchaseToolStripMenuItem.Enabled = false;
            mnuRequesition.Enabled = false;
            mnuInvoices.Enabled = false;
            mnuSalesInvoice.Enabled = false;

        }

        public void ShowItemsBelowReorderLevel()
        {
            try
            {
                               
                string Manufacturerguid = "0";
                string Itemcategoryguid = "0";                

                Manufacturerguid = "0";
                Itemcategoryguid = "-1";              

                string strSQL = string.Empty;
                strSQL = strSQL + " SELECT TOP (100) PERCENT dbo.tblItems.Id, dbo.tblItems.TableRowGuid, dbo.tblItems.MakeOrganizationGuid, dbo.tblItems.ManufacturerGuid, ";
                  strSQL = strSQL + " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName) As BrandName, dbo.tblItems.GenericName,   ";
                strSQL = strSQL + "                 dbo.tblItems.UnitOfMeasurementGuid, dbo.tblItems.Measurement, dbo.tblItems.Strength,dbo.tblItems.ItemCode,   ";
                strSQL = strSQL + "                 dbo.tblItems.ShelfLife, dbo.tblItems.ReorderLevel, dbo.tblItems.SellableBactchGuid, dbo.tblItems.MonthlySalesForecast,   ";
                strSQL = strSQL + "                 dbo.tblItems.ProfitMargin, dbo.tblManufacturers.Name AS Manufacturer, dbo.tblMakeOrganizations.Name AS ItemCategory,   ";
                strSQL = strSQL + "                 dbo.tblUnitOfMeasurements.Name AS UnitOfMeasurement,   ";
                strSQL = strSQL + "                 dbo.tblItems.BrandName AS Item,  ";
                strSQL = strSQL + "                 QuantityAtHand.Balance AS QuantityAtHand ";


                strSQL = strSQL + " FROM      dbo.tblMakeOrganizations INNER JOIN  ";
                strSQL = strSQL + "                 dbo.tblItems ON dbo.tblMakeOrganizations.TableRowGuid = dbo.tblItems.MakeOrganizationGuid INNER JOIN  ";

                strSQL = strSQL + "                 tblEngineType ON dbo.tblEngineType.TableRowGuid = dbo.tblItems.EngineTypeGuid";
                strSQL = strSQL + "                 INNER JOIN";
                strSQL = strSQL + "                 tblYear ON dbo.tblYear.TableRowGuid = dbo.tblItems.YearGuid";
                strSQL = strSQL + "                 INNER JOIN";
                strSQL = strSQL + "                 tblModel ON dbo.tblModel.TableRowGuid = dbo.tblItems.ModelGuid";
                strSQL = strSQL + "                                    INNER JOIN";
                strSQL = strSQL + "                 dbo.tblManufacturers ON dbo.tblItems.ManufacturerGuid = dbo.tblManufacturers.TableRowGuid LEFT OUTER JOIN  ";
                strSQL = strSQL + "                 dbo.tblUnitOfMeasurements ON dbo.tblItems.UnitOfMeasurementGuid = dbo.tblUnitOfMeasurements.TableRowGuid ";

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
                strSQL = strSQL + " WHERE (1=1) AND QuantityAtHand.Balance >= 0";
                if (Manufacturerguid != "" && Manufacturerguid != "0" && Manufacturerguid != "-1") 
                  strSQL = strSQL + " AND (ManufacturerGuid = '" + Manufacturerguid + "') ";
                if (Itemcategoryguid != "-1") strSQL = strSQL + " AND (MakeOrganizationGuid = '" + Itemcategoryguid + "') ";
                strSQL = strSQL + " Order By Manufacturer,dbo.tblItems.MakeOrganizationGuid, Item ";
                                     
                dtReorderLevel = CCommon.GetRecords(strSQL);
                this.lvwReorderLevel.Items.Clear();
                foreach (DataRow row in dtReorderLevel.Rows)
                {
                    
                    ListViewItem itmX = new ListViewItem(new string[]{   
                                                                          row["BrandName"].ToString(), 
                                                                          row["Manufacturer"].ToString(), 
                                                                          row["QuantityAtHand"].ToString()});
                    this.lvwReorderLevel.Items.Add(itmX);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowItemsBelowReorderLevelFullReport()
        {
            try
            {
                DataTable dt = new DataTable();
                rptItemsBelowReorderLevel rpt = new rptItemsBelowReorderLevel();
                frmReportViewer frm = null;               

                if (dtReorderLevel.Rows.Count > 0)
                {
                    rpt.DataSource = dtReorderLevel;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Items Reorder Level List";
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

        public void ShowItemsExpiryDatesFullReport()
        {
            try
            {
                rptItemsPriceList rpt = new rptItemsPriceList();
                frmReportViewer frm = null;

                if (dtExpiryNotification.Rows.Count > 0)
                {
                    rpt.DataSource = dtExpiryNotification;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Items Reorder Level List";
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

        

        public void ShowItemsAvailablility( )
        {
            
            try
            {             
                string Itemcategoryguid = "-1";
                string Itemenginetypeguid = "-1";
                string Itemyearguid = "-1";
                string Itemmodelguid = "-1";
                string Itemcode = "";
                string Itemname = "";
                

                if (cboItemCategoryFilter.SelectedIndex > 0)               
                    Itemcategoryguid = CCommon.GetItemData(cboItemCategoryFilter);
                if (cboItemEngineTypeFilter.SelectedIndex > 0)
                    Itemenginetypeguid = CCommon.GetItemData(cboItemEngineTypeFilter);
                if (cboItemYearFilter.SelectedIndex > 0)
                    Itemyearguid = CCommon.GetItemData(cboItemYearFilter);
                if (cboItemModelFilter.SelectedIndex > 0)
                    Itemmodelguid = CCommon.GetItemData(cboItemModelFilter);
                if (txtBrandNameFilter.Text != string.Empty)
                    Itemname = txtBrandNameFilter.Text;
                if (txtItemsItemCode.Text != string.Empty)
                    Itemcode = txtItemsItemCode.Text;
                

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT TOP (100) PERCENT dbo.tblItems.Id, dbo.tblItems.TableRowGuid, dbo.tblItems.MakeOrganizationGuid,dbo.tblItems.EngineTypeGuid,dbo.tblItems.YearGuid,dbo.tblItems.ModelGuid, dbo.tblItems.ManufacturerGuid,";
                strSQL = strSQL + " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName) As BrandName, dbo.tblItems.GenericName,   ";
                strSQL = strSQL + "                 dbo.tblItems.UnitOfMeasurementGuid, dbo.tblItems.Measurement, dbo.tblItems.Strength,dbo.tblItems.ItemCode,   ";
                strSQL = strSQL + "                 dbo.tblItems.ShelfLife, dbo.tblItems.ReorderLevel, dbo.tblItems.SellableBactchGuid, dbo.tblItems.MonthlySalesForecast,   ";
                strSQL = strSQL + "                 dbo.tblItems.ProfitMargin, dbo.tblManufacturers.Name AS Manufacturer, dbo.tblMakeOrganizations.Name AS ItemCategory,   dbo.tblEngineType.Name AS ItemEngineType, ";
                strSQL = strSQL + "                                    dbo.tblYear.Name AS ItemYear, ";
                strSQL = strSQL + "                                    dbo.tblModel.Name AS ItemModel,   ";
                strSQL = strSQL + "                 dbo.tblUnitOfMeasurements.Name AS UnitOfMeasurement, ExpiryDate, ItemCode, ";
                strSQL = strSQL + "                 dbo.tblItems.BrandName AS Item, SalePrice, ";
                strSQL = strSQL + "                 QuantityAtHand.Balance AS QuantityAtHand ";
                strSQL = strSQL + " FROM      dbo.tblMakeOrganizations INNER JOIN  ";
                strSQL = strSQL + "                 dbo.tblItems ON dbo.tblMakeOrganizations.TableRowGuid = dbo.tblItems.MakeOrganizationGuid INNER JOIN  ";
                                      
                strSQL = strSQL + "                 tblEngineType ON dbo.tblEngineType.TableRowGuid = dbo.tblItems.EngineTypeGuid";
                strSQL = strSQL + "                 INNER JOIN";              
                strSQL = strSQL + "                 tblYear ON dbo.tblYear.TableRowGuid = dbo.tblItems.YearGuid";
                strSQL = strSQL + "                 INNER JOIN";
                strSQL = strSQL + "                 tblModel ON dbo.tblModel.TableRowGuid = dbo.tblItems.ModelGuid";
                strSQL = strSQL + "                                    INNER JOIN";
                strSQL = strSQL + "                 dbo.tblManufacturers ON dbo.tblItems.ManufacturerGuid = dbo.tblManufacturers.TableRowGuid LEFT OUTER JOIN  ";
                strSQL = strSQL + "                 dbo.tblUnitOfMeasurements ON dbo.tblItems.UnitOfMeasurementGuid = dbo.tblUnitOfMeasurements.TableRowGuid ";
                
                strSQL = strSQL + "                 LEFT OUTER JOIN ";

                strSQL = strSQL + "                 (SELECT	tblBatchs.ItemGuid, Balance = SUM(Received) -	SUM(Issued) - SUM(Damaged) - SUM(Recalled),Min(ExpiryDate) As ExpiryDate,SalePrice  ";
                strSQL = strSQL + "                  FROM tblBatchs LEFT OUTER JOIN ";
                strSQL = strSQL + "                      (SELECT BatchGuid, ";
                strSQL = strSQL + "                              ISNULL(ReceivedQuantity, 0) AS Received,  ";
                strSQL = strSQL + "                              ISNULL(IssuedQuantity, 0) AS Issued,  ";
                strSQL = strSQL + "                              ISNULL(DamagedQuantity, 0) AS Damaged,  ";
                strSQL = strSQL + "                              ISNULL(RecalledQuantity, 0) AS Recalled ";
                strSQL = strSQL + "                      FROM StockUptoDateBalance(GetDate())) AS Balance ";
                strSQL = strSQL + "                      ON tblBatchs.TableRowGuid = Balance.BatchGuid ";
                strSQL = strSQL + "                  Group by tblBatchs.ItemGuid,SalePrice) QuantityAtHand ";
                strSQL = strSQL + "                  ON dbo.tblItems.TableRowGuid = QuantityAtHand.ItemGuid  ";
                strSQL = strSQL + " WHERE (1=1) AND QuantityAtHand.Balance > 0 ";
                //strSQL = strSQL + " AND  dbo.tblItems.TableRowGuid ='"+ TableRowGuid+"'";
                 
                //if (Manufacturerguid != "" && Manufacturerguid != "0" && Manufacturerguid != "-1") strSQL = strSQL + " AND (ManufacturerGuid = '" + Manufacturerguid + "') ";
                if (Itemcategoryguid != "-1") strSQL = strSQL + " AND (MakeOrganizationGuid = '" + Itemcategoryguid + "') ";
                if (Itemenginetypeguid != "-1") strSQL = strSQL + " AND (EngineTypeGuid = '" + Itemenginetypeguid + "') ";
                if (Itemyearguid != "-1") strSQL = strSQL + " AND (YearGuid = '" + Itemyearguid + "') ";
                if (Itemmodelguid != "-1") strSQL = strSQL + " AND (ModelGuid = '" + Itemmodelguid + "') ";
                if (Itemname != "") strSQL = strSQL + " AND (tblItems.BrandName like '" + Itemname + "%') ";
                if (Itemcode != "") strSQL = strSQL + " AND (tblItems.ItemCode like'" + Itemcode + "%') ";
                strSQL = strSQL + " Order By Manufacturer, Item ";
                DataTable dt = new DataTable();
                dt = CCommon.GetRecords(strSQL);
                this.lvwSearchResult.Items.Clear();
                foreach (DataRow row in dt.Rows)
                
                {

                    ListViewItem itmX = new ListViewItem(new string[] {   row["ItemCategory"].ToString(),
                                                                          row["ItemEngineType"].ToString(),
                                                                          row["ItemYear"].ToString(),
                                                                          row["ItemModel"].ToString(),
                                                                          row["BrandName"].ToString(),
                                                                          row["ItemCode"].ToString(),
                                                                          row["QuantityAtHand"].ToString(),
                                                                          Convert.ToDecimal(row["SalePrice"]).ToString(CSettings.CurrencyFormat)});
                    this.lvwSearchResult.Items.Add(itmX);

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ShowChecks()
        {
            try
            {              
                
                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT tblLocalPurchaseOrders.TableRowGuid AS PurchaseOrderGuid, tblLocalPurchaseOrders.OrderNumber,OrderDate,";
                strSQL = strSQL + " SubTotal,CheckOrCPONumber,CheckOrCPODate,CheckMaturityDate";
                strSQL = strSQL + " FROM tblLocalPurchaseOrders";
                strSQL = strSQL + " INNER JOIN tblLocalPurchaseOrderSettlements ";
                strSQL = strSQL + " ON (tblLocalPurchaseOrderSettlements.PurchaseOrderGuid = tblLocalPurchaseOrders.TableRowGuid)";
                strSQL = strSQL + " INNER JOIN";
                strSQL = strSQL + " (";
                strSQL = strSQL + " 	SELECT PurchaseOrderGuid, SUM(LineTotal) AS SubTotal";
                strSQL = strSQL + " 	FROM";
                strSQL = strSQL + " 	(SELECT PurchaseOrderGuid, (Quantity * PricePerUnit) as LineTotal";
                strSQL = strSQL + " 	From tblLocalPurchaseOrderDetails ";
                strSQL = strSQL + " 	Group By PurchaseOrderGuid,Quantity,PricePerUnit) AS Q";
                strSQL = strSQL + " 	GROUP BY PurchaseOrderGuid";
                strSQL = strSQL + " ) AS PurchaseOrderTotal";
                strSQL = strSQL + " ON (PurchaseOrderTotal.PurchaseOrderGuid = tblLocalPurchaseOrders.TableRowGuid)  ";
                strSQL = strSQL + " WHERE CheckMaturityDate <= DateAdd(day,15, getdate()) AND CheckMaturityDate >= getdate()";

                dtMaturityChecks = CCommon.GetRecords(strSQL);
                this.lvwChecksMaturity.Items.Clear();
                foreach (DataRow row in dtMaturityChecks.Rows)
                {
                    if (IsPurchaseOrderWithVAT(row["PurchaseOrderGuid"].ToString()))
                    {                        
                        decimal VAT  = Convert.ToDecimal(CSettings.VATPercentage) / 100;
                        decimal SubTotalWithVAT =  Convert.ToDecimal(row["SubTotal"]) + Convert.ToDecimal(row["SubTotal"]) * VAT;

                        ListViewItem itmX = new ListViewItem(new string[] {   
                                                                          row["OrderNumber"].ToString(),   
                                                                          row["CheckOrCPONumber"].ToString(),
                                                                          SubTotalWithVAT.ToString(CSettings.CurrencyFormat),
                                                                          Convert.ToDateTime(row["CheckMaturityDate"]).ToString(CSettings.DateFormat)});
                        this.lvwChecksMaturity.Items.Add(itmX);
                    }
                    else
                    {

                        ListViewItem itmX = new ListViewItem(new string[] {   
                                                                          row["OrderNumber"].ToString(),   
                                                                          row["CheckOrCPONumber"].ToString(),
                                                                          Convert.ToDecimal(row["SubTotal"]).ToString(CSettings.CurrencyFormat),
                                                                          Convert.ToDateTime(row["CheckMaturityDate"]).ToString(CSettings.DateFormat)});
                        this.lvwChecksMaturity.Items.Add(itmX);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SettledDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                Pharma.Code_UI.Report_Designers.rptSetteled rpt = new Pharma.Code_UI.Report_Designers.rptSetteled();
                frmReportViewer frm = null;

                if (dtMaturityChecks.Rows.Count > 0)
                {
                    rpt.DataSource = dtMaturityChecks;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Items Settled List";
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


        public void ShowNotSettled()
        {

            try
            {

                string strSQL = string.Empty;
                strSQL = strSQL + " SELECT tblLocalPurchaseOrders.TableRowGuid AS PurchaseOrderGuid, tblLocalPurchaseOrders.OrderNumber,OrderDate,Settled,";
                strSQL = strSQL + " SubTotal,CheckOrCPONumber,CheckOrCPODate,CheckMaturityDate, SettledText = CASE Settled When 0 then 'Not Settled'  when 1 then 'Settled' else 'Unknown' end ";
                strSQL = strSQL + " FROM tblLocalPurchaseOrders";
                strSQL = strSQL + " INNER JOIN tblLocalPurchaseOrderSettlements ";
                strSQL = strSQL + " ON (tblLocalPurchaseOrderSettlements.PurchaseOrderGuid = tblLocalPurchaseOrders.TableRowGuid)";
                strSQL = strSQL + " INNER JOIN";
                strSQL = strSQL + " (";
                strSQL = strSQL + " 	SELECT PurchaseOrderGuid, SUM(LineTotal) AS SubTotal";
                strSQL = strSQL + " 	FROM";
                strSQL = strSQL + " 	(SELECT PurchaseOrderGuid, (Quantity * PricePerUnit) as LineTotal";
                strSQL = strSQL + " 	From tblLocalPurchaseOrderDetails ";
                strSQL = strSQL + " 	Group By PurchaseOrderGuid,Quantity,PricePerUnit) AS Q";
                strSQL = strSQL + " 	GROUP BY PurchaseOrderGuid";
                strSQL = strSQL + " ) AS PurchaseOrderTotal";
                strSQL = strSQL + " ON (PurchaseOrderTotal.PurchaseOrderGuid = tblLocalPurchaseOrders.TableRowGuid)  ";
                strSQL = strSQL + " where Settled = 0 ";

                dtSettled = CCommon.GetRecords(strSQL);
                this.lvwNotSettledChecks.Items.Clear();
                foreach (DataRow row in dtSettled.Rows)
                {
                    if (IsSettledWithVAT(row["PurchaseOrderGuid"].ToString()))
                    {
                        decimal VAT = Convert.ToDecimal(CSettings.VATPercentage) / 100;
                        decimal SubTotalWithVAT = Convert.ToDecimal(row["SubTotal"]) + Convert.ToDecimal(row["SubTotal"]) * VAT;

                        ListViewItem itmX = new ListViewItem(new string[] {   
                                                                          row["OrderNumber"].ToString(),
                                                                         row["SettledText"].ToString(), 
                                                                          //row["CheckOrCPONumber"].ToString(),
                                                                          SubTotalWithVAT.ToString(CSettings.CurrencyFormat),
                                                                        // Convert.ToDateTime(row["CheckMaturityDate"]).ToString(CSettings.DateFormat)
                           });
                        this.lvwNotSettledChecks.Items.Add(itmX);
                    }
                       
                    else
                    {

                        ListViewItem itmX = new ListViewItem(new string[] {   
                                                                          row["OrderNumber"].ToString(), 
                                                                          row["SettledText"].ToString(), 
                                                                         // row["CheckOrCPONumber"].ToString(),
                                                                          Convert.ToDecimal(row["SubTotal"]).ToString(CSettings.CurrencyFormat),
                                                                         // Convert.ToDateTime(row["CheckMaturityDate"]).ToString(CSettings.DateFormat)
                        });
                        this.lvwNotSettledChecks.Items.Add(itmX);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void NotSettledDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                Pharma.Code_UI.Report_Designers.rptNotSettled rpt = new Pharma.Code_UI.Report_Designers.rptNotSettled();
                frmReportViewer frm = null;

                if (dtSettled.Rows.Count > 0)
                {
                    rpt.DataSource = dtSettled;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Items NotSettled List";
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


        private bool IsPurchaseOrderWithVAT(string PurchaseOrderGuid)
        {
            CLocalPurchaseOrders objLocalPurchaseOrders = new CLocalPurchaseOrders();
            try
            {
                return objLocalPurchaseOrders.IsPurchaseOrderWithVAT(PurchaseOrderGuid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        private bool IsSettledWithVAT(string PurchaseOrderGuid)
        {
            CLocalPurchaseOrders objLocalPurchaseOrders = new CLocalPurchaseOrders();
            try
            {
                return objLocalPurchaseOrders.IsPurchaseOrderWithVAT(PurchaseOrderGuid);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void deliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice childForm = new frmInvoice();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                //childForm.btnPrepareInvoice.Enabled = false;
                childForm.btnDelete.Enabled = false;
                childForm.btnDeliver.Enabled = false;
                childForm.btnReturn.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
            }
            childForm.MdiParent = this;            
            CCommon.eDeliveryStatus = CCommon.DeliveryStatus.Pending;
            childForm.intDeliveryStatus = (int)CCommon.DeliveryStatus.Delivered;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }        
                
        private void banksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanks childForm = new frmBanks();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveBanks.Enabled = false;                
                childForm.btnDeleteBanks.Enabled = false;               
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteBanks.Enabled = false;

            }
            childForm.ShowDialog();
        }

        private void sellabeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellableBatch childForm = new frmSellableBatch();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSetSellableBatch.Enabled = false;
            }
           
            //childForm.MdiParent = this;
            //childForm.Text = sellabeToolStripMenuItem.Text;
            childForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout childForm = new frmAbout();
            childForm.ShowDialog();
        }

        private void securityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSec childForm = new frmSec();
            childForm.ShowDialog();
        }

        private void priceCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculatePrice childForm = new frmCalculatePrice();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnCalculatePrice.Enabled = false;
                childForm.btnSaveActualPriceForBatch.Enabled = false;
                childForm.btnSaveExchangeRate.Enabled = false;
            }
           
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void customerTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerTypes childForm = new frmCustomerTypes();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveCustomerTypes.Enabled = false;                
                childForm.btnDeleteCustomerTypes.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteCustomerTypes.Enabled = false;

            }
            childForm.ShowDialog();
        }

        private void salesStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesStatement childForm = new frmSalesStatement();
            //childForm.MdiParent = this;
            //childForm.Text = salesStatementToolStripMenuItem.Text;
            
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void stockCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockCard childForm = new frmStockCard();
            //childForm.MdiParent = this;
            //childForm.Text = salesStatementToolStripMenuItem.Text;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings childForm = new frmSettings();
            //childForm.MdiParent = this;
            //childForm.Text = settingsToolStripMenuItem.Text;
            childForm.ShowDialog();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfCustomers childForm = new frmListOfCustomers();
            //childForm.MdiParent = this;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void banksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowBanks(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerTypesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowCustomerTypes(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void itemCategoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowItemCategories(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void licenseLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowLicenseLevels(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void locationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowLocations(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void unitOfMeasurementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowUnitOfMeasurements(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowStores(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void countriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowCountries(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void termsOfContractTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowTermsOfContractTemplates(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void manufacturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CReports.ShowManufacturers(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customersProofReadingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomersProofReading childForm = new frmCustomersProofReading();
            //childForm.MdiParent = this;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void listOfItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfItems childForm = new frmListOfItems();
            //childForm.MdiParent = this;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfInvoices childForm = new frmListOfInvoices();
            //childForm.MdiParent = this;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void invoicesByItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfInvoicesByItems childForm = new frmListOfInvoicesByItems();
            //childForm.MdiParent = this;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void paymentRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfPaymentRequests childForm = new frmListOfPaymentRequests();
            //childForm.MdiParent = this;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void checksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfChecks childForm = new frmListOfChecks();
            //childForm.MdiParent = this;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Restart();
        }

        private void dosageFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDosageForms childForm = new frmDosageForms();
            //childForm.MdiParent = this;
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveDosageForms.Enabled = false;
                childForm.btnDeleteDosageForms.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteDosageForms.Enabled = false;
            }
            //childForm.Text = licenseLevelToolStripMenuItem.Text;
            childForm.ShowDialog();
        }

        private void mnuPasswordChange_Click(object sender, EventArgs e)
        {
            frmPasswordChange childForm = new frmPasswordChange();
            childForm.ShowDialog();
        }

        private void drugRegistrationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrugRegistrationTypes childForm = new frmDrugRegistrationTypes();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveDrugRegistrationTypes.Enabled = false;
                childForm.btnDeleteDrugRegistrationTypes.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteDrugRegistrationTypes.Enabled = false;

            }
            childForm.ShowDialog();
        }

        private void drugRegistrationFeePaymentRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrugRegistrationFeePaymentRequests childForm = new frmDrugRegistrationFeePaymentRequests();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveDrugRegistrationFeePaymentRequests.Enabled = false;
                childForm.btnDeleteDrugRegistrationFeePaymentRequests.Enabled = false;
                childForm.btnAddItem.Enabled = false;
                childForm.btnRemoveItem.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteDrugRegistrationFeePaymentRequests.Enabled = false;
                childForm.btnRemoveItem.Enabled = false;
            }
            childForm.MdiParent = this;
            //childForm.Text = drugRegistrationFeePaymentRequestToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrationFeeTable childForm = new frmRegistrationFeeTable();
            //childForm.MdiParent = this;
            //childForm.Text = salesStatementToolStripMenuItem.Text;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void drugRegistrationFeeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrugRegistrationFeeTables childForm = new frmDrugRegistrationFeeTables();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveDrugRegistrationFeeTables.Enabled = false;
                childForm.btnDeleteDrugRegistrationFeeTables.Enabled = false;
                childForm.btnAddItem.Enabled = false;
                childForm.btnRemoveItem.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteDrugRegistrationFeeTables.Enabled = false;
                childForm.btnRemoveItem.Enabled = false;
            }
            childForm.MdiParent = this;
            //childForm.Text = drugRegistrationFeePaymentRequestToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReturn childForm = new frmSalesReturn();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                childForm.btnSaveDetail.Enabled = false;
                childForm.btnDelete.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
                childForm.btnDeleteDetail.Enabled = false;
            }
            childForm.MdiParent = this;
            //childForm.Text = salesReturnToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void eventViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEvents childForm = new frmEvents();
            childForm.MdiParent = this;
            childForm.Text = eventViewerToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            //childForm.WindowState = FormWindowState.Normal;
            //childForm.WindowState = FormWindowState.Maximized;
        }

        private void eventMergerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMerger childForm = new frmMerger();
            childForm.MdiParent = this;
            childForm.Text = eventMergerToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
        }

        private void receivedItemsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceivingList childForm = new frmReceivingList();
            //childForm.MdiParent = this;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        
        private void purchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocalPurchaseOrder childForm = new frmLocalPurchaseOrder();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSave.Enabled = false;
                childForm.btnDelete.Enabled = false;

            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDelete.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void costAccumulationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalProcessPurchaseOrder childForm = new frmLocalProcessPurchaseOrder();
            if (Program.intUserAccessRight == 1) //Read Only
            {

                childForm.btnSaveOtherPayment.Enabled = false;
                childForm.btnDeleteOtherPayment.Enabled = false;

            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteOtherPayment.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void batchRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocalRegisterBatchs childForm = new frmLocalRegisterBatchs();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveBatch.Enabled = false;
                childForm.btnDeleteBatch.Enabled = false;

            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteBatch.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void priceCalculationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLocalCalculatePrice childForm = new frmLocalCalculatePrice();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnCalculatePrice.Enabled = false;
                childForm.btnSaveActualPriceForBatch.Enabled = false;

            }

            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void tendersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBidsListReport childForm = new frmBidsListReport();
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
        }

        private void bidBondLisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBidBondsReport childForm = new frmBidBondsReport();
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
        }

        private void performanceBondListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerformanceBondReport childForm = new frmPerformanceBondReport();
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            SendDashBoardToFront();
        }

        private void deliveryPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDeliveryPersons childForm = new frmDeliveryPersons();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveDeliveryPersons.Enabled = false;
                childForm.btnDeleteDeliveryPersons.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteDeliveryPersons.Enabled = false;

            }
            childForm.ShowDialog();
        }

        private void invoiceListByDeliveryPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfInvoicesByDeliveryPerson childForm = new frmListOfInvoicesByDeliveryPerson();
            //childForm.MdiParent = this;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void voidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice childForm = new frmInvoice();
            childForm.grpRequisition.Enabled = false;
            childForm.btnSave.Enabled = false;
            childForm.btnDelete.Enabled = false;
            childForm.btnPrintPreviewAttachment.Enabled = false;
            childForm.btnNew.Enabled = false;
            childForm.grpInvoice.Enabled = false;
            childForm.tabControlInvoice.Enabled = false;
            childForm.panelTotal.Enabled = false;
            childForm.grbReturning.Enabled = true;
            childForm.btnGenerateAttachmentNumber.Enabled = false;
            childForm.MdiParent = this;
            childForm.Show();
            SendDashBoardToBack();

        }

        private void settlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalPurchaseSettlements childForm = new frmLocalPurchaseSettlements();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSettle.Enabled = false;

            }
            childForm.MdiParent = this;
            childForm.Text = settlementToolStripMenuItem.Text;
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void SendDashBoardToBack()
        {
            
            grpReorderLevel.SendToBack();
            grpCheckMaturity.SendToBack();
            grpSearchAvailability.SendToBack();
            grpNotSettled.SendToBack();

        }
        private void SendDashBoardToFront()
        {
            
            grpReorderLevel.BringToFront();
            grpCheckMaturity.BringToFront();
            grpSearchAvailability.BringToFront();
            grpNotSettled.BringToFront();
        }

        private void btnShowFullReportReorderLevel_Click(object sender, EventArgs e)
        {
            ShowItemsBelowReorderLevelFullReport();
        }

      
        private void showDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendDashBoardToFront();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            lvwSearchResult.Items.Clear();
            ShowItemsAvailablility();
        }

        private void txtBrandNameFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    lvwSearchResult.Items.Clear();
                    ShowItemsAvailablility();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowFullReportExpiryDate_Click(object sender, EventArgs e)
        {
            ShowItemsExpiryDatesFullReport();
        }

        private void txtItemsItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    lvwSearchResult.Items.Clear();
                    ShowItemsAvailablility();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void licenseLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void requesitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRequesition childForm = new frmRequesition();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnAddItem.Enabled = false;
                
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnAddItem.Enabled = false;
            }
            childForm.MdiParent = this;
            childForm.Text = mnuRequesition.Text;           
            childForm.Show();
            SendDashBoardToBack();
            childForm.WindowState = FormWindowState.Normal;
            childForm.WindowState = FormWindowState.Maximized;
        }

        private void lvwExpiryDateNotification_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lvwChecksMaturity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lvwChecksMaturity_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void makeOrganizationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMakeOrganizations childForm = new frmMakeOrganizations();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveCountries.Enabled = false;
                childForm.btnDeleteCountries.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteCountries.Enabled = false;
            }
            childForm.ShowDialog();
        }

        private void lvwReorderLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void yearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYears childForm = new frmYears();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveCountries.Enabled = false;
                childForm.btnDeleteCountries.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteCountries.Enabled = false;
            }
            childForm.ShowDialog();
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModel childForm = new frmModel();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveCountries.Enabled = false;
                childForm.btnDeleteCountries.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteCountries.Enabled = false;
            }
            childForm.ShowDialog();
        }

        private void engineTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEngineTypes childForm = new frmEngineTypes();
            if (Program.intUserAccessRight == 1) //Read Only
            {
                childForm.btnSaveCountries.Enabled = false;
                childForm.btnDeleteCountries.Enabled = false;
            }
            else if (Program.intUserAccessRight == 2) //Read Write                      
            {
                childForm.btnDeleteCountries.Enabled = false;
            }
            childForm.ShowDialog();
        }

        private void cboItemCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwSearchResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpCheckMaturity_Enter(object sender, EventArgs e)
        {

        }

        private void lvwSearchResult_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnShowFullReportMatureChecks_Click(object sender, EventArgs e)
        {
            SettledDetails();
        }

        private void lvwNotSettledChecks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpNotSettled_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NotSettledDetails();
        }

        private void supplierDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier childForm = new frmSupplier();
            //childForm.MdiParent = this;
            //childForm.Text = salesStatementToolStripMenuItem.Text;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListOfCustomers childForm = new frmListOfCustomers();
            //childForm.MdiParent = this;
            //childForm.Text = salesStatementToolStripMenuItem.Text;
            childForm.Show(this);
            SendDashBoardToBack();
        }

        private void cboItemYearFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void storeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmImages childForm = new frmImages();
           
            childForm.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
  

    }
}
