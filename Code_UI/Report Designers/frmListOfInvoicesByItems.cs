using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharma
{
    public partial class frmListOfInvoicesByItems : Form
    {
        private const string DialogCaption = "List of Invoices by Item";

        public frmListOfInvoicesByItems()
        {
            InitializeComponent();
        }

        public void ShowInvoices()
        {
            try
            {
                DataTable dt = new DataTable();
                rptInvoicesListByItem rpt = new rptInvoicesListByItem();
                frmReportViewer frm = null;

                string Itemcategoryguid = "-1";
                string Itemguid = "-1";
                string InvoiceType = "-1";


                Itemcategoryguid = CCommon.GetItemData(cboItemCategory);
                Itemguid = CCommon.GetItemData(cboItem);
                InvoiceType = CCommon.GetItemData(cboInvoiceType);

                rpt.Itemguid = Itemguid;
                rpt.Item = this.cboItem.Text;
                rpt.Itemcategoryguid = Itemcategoryguid;
                rpt.ItemCategory = this.cboItemCategory.Text;
                rpt.InvoiceType = Convert.ToInt32(InvoiceType);
                rpt.InvoiceDateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFromInvoice.Text);
                rpt.InvoiceDateTo = CDateTime.DateFromStringForSQLMax(this.txtDateToInvoice.Text);
                rpt.FilterByInvoiceDate = this.chkInvoiceDate.Checked;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   tblCustomers.Name AS Customer, vwInvoices.InvoiceGuid AS TableRowGuid, vwInvoices.CustomerGuid, vwInvoices.ReferenceNumber,  ";
                strSQL = strSQL + "          vwInvoices.InvoiceDate, vwInvoices.InvoiceType, vwInvoices.DueDate, vwInvoices.PreparedBy, vwInvoices.CheckedBy,  ";
                strSQL = strSQL + "          vwInvoices.ApprovedBy, vwInvoices.PreparedDate, vwInvoices.DeliveredBy, vwInvoices.CheckedDate,  ";
                strSQL = strSQL + "          vwInvoices.ApprovalDate, vwInvoices.DeliveryDate, vwInvoices.DeliveryStatus, vwInvoices.SuppliesRequisitionGuid,  ";
                strSQL = strSQL + "          vwInvoices.CashCollectionGuid, vwInvoices.InvoiceDetailGuid AS DetailGuid, vwInvoices.BatchGuid, Quantity = IsNull(vwInvoices.Quantity, 0),  ";
                strSQL = strSQL + "          tblBatchs.ItemGuid, tblItems.MakeOrganizationGuid , tblMakeOrganizations.Name AS ItemCategory,   ";
                strSQL = strSQL + "          dbo.tblModel.Name AS Modeltype,  dbo.tblItems.DosageFormGuid, ";
                strSQL = strSQL + "          (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  ,";                
                strSQL = strSQL + "          Discount = IsNull(vwInvoices.Discount, 0), UnitPrice = IsNull(vwInvoices.UnitPrice, 0), ";
                strSQL = strSQL + "          SubTotal = IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0),  ";
                strSQL = strSQL + "          DiscountAmount = IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0) * IsNull(vwInvoices.Discount, 0) * 0.01, ";
                strSQL = strSQL + "          InvoiceTotal = IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0) - IsNull(vwInvoices.Quantity, 0) * IsNull(vwInvoices.UnitPrice, 0) * IsNull(vwInvoices.Discount, 0) * 0.01 ";
                strSQL = strSQL + "          FROM      tblCustomers INNER JOIN ";
                strSQL = strSQL + "                    vwInvoices ON tblCustomers.TableRowGuid = vwInvoices.CustomerGuid INNER JOIN ";
                strSQL = strSQL + "                    tblBatchs ON vwInvoices.BatchGuid = tblBatchs.TableRowGuid INNER JOIN ";
                strSQL = strSQL + "                    tblItems ON tblBatchs.ItemGuid = tblItems.TableRowGuid INNER JOIN ";
                strSQL = strSQL + "                    tblMakeOrganizations ON tblItems.MakeOrganizationGuid  = tblMakeOrganizations.TableRowGuid INNER JOIN ";
                strSQL = strSQL + "                    tblModel ON tblItems.ModelGuid  = tblModel.TableRowGuid ";
                strSQL = strSQL + "                    inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid ";
                strSQL = strSQL + "                    inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
                strSQL = strSQL + " WHERE (1=1) AND IsNull(vwInvoices.DeliveryStatus,0) = 1   ";
                if (Itemguid != "-1") strSQL = strSQL + " AND (tblBatchs.ItemGuid = '" + Itemguid + "') ";
                if (Itemcategoryguid != "-1") strSQL = strSQL + " AND (tblItems.MakeOrganizationGuid  = '" + Itemcategoryguid + "') ";
                if (InvoiceType != "-1") strSQL = strSQL + " AND (vwInvoices.InvoiceType = " + InvoiceType + ") ";
                if (this.chkInvoiceDate.Checked == true)
                {
                    strSQL = strSQL + " AND (vwInvoices.InvoiceDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFromInvoice.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (vwInvoices.InvoiceDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateToInvoice.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }
                strSQL = strSQL + " Order By tblItems.MakeOrganizationGuid , tblBatchs.ItemGuid, vwInvoices.InvoiceType, vwInvoices.InvoiceDate, vwInvoices.ReferenceNumber, Customer ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "List of Invoices";
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
                ShowInvoices();
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

        private void frmListOfCustomers_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillComboBox(cboItemCategory, "Select TableRowGuid, name from tblMakeOrganizations Order by Name", "TableRowGuid", "name", false);
                CCommon.FillInvoiceTypeCombo(cboInvoiceType, false);

                this.txtDateFromInvoice.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateToInvoice.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkInvoiceDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkInvoiceDate.CheckState == CheckState.Unchecked)
                {
                    this.txtDateFromInvoice.Enabled = false;
                    this.txtDateToInvoice.Enabled = false;
                }
                else if (this.chkInvoiceDate.CheckState == CheckState.Checked)
                {
                    this.txtDateFromInvoice.Enabled = true;
                    this.txtDateToInvoice.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "";
                string Categoryguid = "-1";
                Categoryguid = CCommon.GetItemData(this.cboItemCategory);

                if (Categoryguid != "-1")

                    CCommon.FillComboBox(this.cboItem, "Select TableRowGuid, BrandName + ' (' + GenericName + ') ' + Strength as BrandName from tblItems where CategoryGuid = '" + Categoryguid.ToString() + "' Order by BrandName ", "TableRowGuid", "BrandName",false);
                else
                {
                    strSQL = strSQL + " select (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName ) as BrandName, tblitems.TableRowGuid from tblitems ";
                    strSQL = strSQL + " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
                    strSQL = strSQL + " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
                    strSQL = strSQL + " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
                    strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
                    CCommon.FillComboBox(this.cboItem, strSQL, "TableRowGuid", "BrandName", false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grpInvoice_Enter(object sender, EventArgs e)
        {

        }

        private void cboItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
