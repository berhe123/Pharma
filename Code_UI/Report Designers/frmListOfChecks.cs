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
    public partial class frmListOfChecks : Form
    {
        private const string DialogCaption = "List of Checks";

        public frmListOfChecks()
        {
            InitializeComponent();
        }

        public void ShowChecks()
        {
            try
            {
                DataTable dt = new DataTable();
                rptChecksList rpt = new rptChecksList();
                frmReportViewer frm = null;

                //string CustomerId = "-1";
                string CheckStatus = "-1";

                CheckStatus = CCommon.GetItemData(this.cboCheckStatus);

                rpt.CheckStatus = Convert.ToInt32(CheckStatus);
                rpt.CheckDateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFromCheck.Text);
                rpt.CheckDateTo = CDateTime.DateFromStringForSQLMax(this.txtDateToCheck.Text);
                rpt.FilterByCheckDate = this.chkCheckDate.Checked;
                rpt.MaturityDateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFromMaturity.Text);
                rpt.MaturityDateTo = CDateTime.DateFromStringForSQLMax(this.txtDateToMaturity.Text);
                rpt.FilterByMaturityDate = this.chkMaturityDate.Checked;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT tblLocalPurchaseOrders.TableRowGuid AS PurchaseOrderGuid, tblLocalPurchaseOrders.OrderNumber,OrderDate,tblManufacturers.Name,";
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
                strSQL = strSQL + " INNER JOIN tblManufacturers ON (tblLocalPurchaseOrders.SupplierGuid = tblManufacturers.TableRowGuid) ";
                strSQL = strSQL + " WHERE (1=1)  ";

                if (this.chkCheckDate.Checked == true)
                {

                    strSQL = strSQL + " AND (CheckOrCPODate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFromCheck.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (CheckOrCPODate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateToCheck.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                  }

                if (this.chkMaturityDate.Checked == false)
                {
                    strSQL = strSQL + " AND (CheckMaturityDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFromMaturity.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                    strSQL = strSQL + " AND (CheckMaturityDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateToMaturity.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                }

                //strSQL = strSQL + " GROUP BY PaymentRequestGuid, CustomerGuid,InvoiceNumber, Customer,  CheckOrCPODate, CheckOrCPONumber, CheckMaturityDate, CheckCashedDate  ";
                strSQL = strSQL + " Order By OrderNumber,Name, CheckOrCPODate, CheckOrCPONumber, CheckMaturityDate ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "List of Checks";
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
                ShowChecks();
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
                CCommon.FillCheckStatusCombo(cboCheckStatus, false);
                this.txtDateFromCheck.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateToCheck.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateFromMaturity.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateToMaturity.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkMaturityDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkMaturityDate.CheckState == CheckState.Unchecked)
                {
                    this.txtDateFromMaturity.Enabled = false;
                    this.txtDateToMaturity.Enabled = false;
                }
                else if (this.chkMaturityDate.CheckState == CheckState.Checked)
                {
                    this.txtDateFromMaturity.Enabled = true;
                    this.txtDateToMaturity.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkCheckDate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkCheckDate.CheckState == CheckState.Unchecked)
                {
                    this.txtDateFromCheck.Enabled = false;
                    this.txtDateToCheck.Enabled = false;
                }
                else if (this.chkCheckDate.CheckState == CheckState.Checked)
                {
                    this.txtDateFromCheck.Enabled = true;
                    this.txtDateToCheck.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboCheckStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
