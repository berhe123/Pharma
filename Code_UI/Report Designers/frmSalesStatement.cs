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
    public partial class frmSalesStatement : Form
    {
        private const string DialogCaption = "Sales Statement";

        public frmSalesStatement()
        {
            InitializeComponent();
        }

        private void ShowSalesStatement()
        {
            DataTable dt = new DataTable();
            rptSalesStatement rpt = new rptSalesStatement();
            frmReportViewer frm = null;

            rpt.DateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text);
            rpt.DateTo = CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text);

            try
            {
                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT	tblBatchs.Id, tblBatchs.TableRowGuid, tblItems.BrandName + ' (' + tblItems.GenericName + ') ' + tblItems.Strength + ' ' + tblDosageForms.Name AS Item,   ";
                strSQL = strSQL + " 		tblItems.DosageFormGuid, tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS Unit,   ";
                strSQL = strSQL + " 		tblBatchs.BatchNumber, UnitPrice = Isnull(tblBatchs.SalePrice, 0),   ";
                strSQL = strSQL + "         OpeningQuantity = Isnull(Opening.ReceivedQuantity, 0) - Isnull(Opening.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(Opening.DamagedQuantity, 0) - Isnull(Opening.RecalledQuantity, 0),  ";
                strSQL = strSQL + " 		ReceiptQuantity = Isnull(PeriodActivity.ReceivedQuantity, 0),  ";
                strSQL = strSQL + " 		ClosingQuantity = Isnull(Closing.ReceivedQuantity, 0) - Isnull(Closing.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(Closing.DamagedQuantity, 0) - Isnull(Closing.RecalledQuantity, 0),  ";

                strSQL = strSQL + "         SalesQuantity = (Isnull(OpeningWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 						- Isnull(OpeningWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.RecalledQuantity, 0))  ";
                strSQL = strSQL + " 		                + Isnull(PeriodActivityWithoutFOCInvoice.ReceivedQuantity, 0)  ";
                strSQL = strSQL + " 		                - (Isnull(ClosingWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(ClosingWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.RecalledQuantity, 0)),  ";


                strSQL = strSQL + "         PeriodActivityQuantity = Isnull(PeriodActivityWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(PeriodActivityWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(PeriodActivityWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(PeriodActivityWithoutFOCInvoice.RecalledQuantity, 0),  ";
                strSQL = strSQL + " 		MonthlySalesForecast = Isnull(tblItems.MonthlySalesForecast, 0),  ";
                strSQL = strSQL + "   ";
                strSQL = strSQL + " 		SalesValue = Isnull(tblBatchs.SalePrice, 0)   ";
                strSQL = strSQL + "                         * ((Isnull(OpeningWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 						- Isnull(OpeningWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.RecalledQuantity, 0))  ";
                strSQL = strSQL + " 		                + Isnull(PeriodActivityWithoutFOCInvoice.ReceivedQuantity, 0)  ";
                strSQL = strSQL + " 		                - (Isnull(ClosingWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(ClosingWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.RecalledQuantity, 0))),  ";

                strSQL = strSQL + " 		ValueOfEndingBalance = Isnull(tblBatchs.SalePrice, 0) * (Isnull(Closing.ReceivedQuantity, 0) - Isnull(Closing.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 								- Isnull(Closing.DamagedQuantity, 0) - Isnull(Closing.RecalledQuantity, 0)),  ";

                strSQL = strSQL + " 		UnitFOBPrice = Isnull(tblBatchs.PricePerUnit, 0),  ";
                strSQL = strSQL + " 		MonthlySalesInFOBPrice = Isnull(tblBatchs.PricePerUnit, 0) ";
                strSQL = strSQL + "                         * ((Isnull(OpeningWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 						- Isnull(OpeningWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.RecalledQuantity, 0))  ";
                strSQL = strSQL + " 		                + Isnull(PeriodActivityWithoutFOCInvoice.ReceivedQuantity, 0)  ";
                strSQL = strSQL + " 		                - (Isnull(ClosingWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(ClosingWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.RecalledQuantity, 0)))  ";

                strSQL = strSQL + " FROM	tblItems INNER JOIN tblUnitOfMeasurements   ";
                strSQL = strSQL + " 			ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid   ";
                strSQL = strSQL + "         INNER JOIN tblDosageForms   ";
                strSQL = strSQL + " 			ON tblItems.DosageFormGuid = tblDosageForms.TableRowGuid   ";
                strSQL = strSQL + " 		INNER JOIN tblBatchs   ";
                strSQL = strSQL + " 			ON tblItems.TableRowGuid = tblBatchs.ItemGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockUptoDateBalance(Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).AddDays(-1).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS Opening   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = Opening.BatchGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockUptoDateBalanceWithoutFOCInvoice(Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).AddDays(-1).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS OpeningWithoutFOCInvoice   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = OpeningWithoutFOCInvoice.BatchGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockUptoDateBalance(Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS Closing   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = Closing.BatchGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockUptoDateBalanceWithoutFOCInvoice(Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS ClosingWithoutFOCInvoice   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = ClosingWithoutFOCInvoice.BatchGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockPeriodActivity(Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + "), Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS PeriodActivity   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = PeriodActivity.BatchGuid  ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockPeriodActivityWithoutFOCInvoice(Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + "), Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS PeriodActivityWithoutFOCInvoice   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = PeriodActivityWithoutFOCInvoice.BatchGuid  ";
                strSQL = strSQL + " 			where ((Isnull(Opening.ReceivedQuantity, 0) - Isnull(Opening.IssuedQuantity, 0)) > 0 Or Isnull(PeriodActivity.ReceivedQuantity, 0) > 0) ";
                strSQL = strSQL + " ORDER BY Item, BatchNumber  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Sales Statement";
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

        private void ShowSalesStatementByItem()
        {
            try
            {
                DataTable dt = new DataTable();
                rptSalesStatementByItem rpt = new rptSalesStatementByItem();
                frmReportViewer frm = null;

                rpt.DateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text);
                rpt.DateTo = CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text);

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT	ItemId, ItemGuid, Item, Unit, BatchNumber = 'All', UnitPrice, UnitFOBPrice, ";
                strSQL = strSQL + " OpeningQuantity = SUM(OpeningQuantity), ReceiptQuantity = SUM(ReceiptQuantity), ";
                strSQL = strSQL + " ClosingQuantity = SUM(ClosingQuantity), SalesQuantity = SUM(SalesQuantity), ";
                strSQL = strSQL + " PeriodActivityQuantity = SUM(PeriodActivityQuantity), MonthlySalesForecast = SUM(MonthlySalesForecast), ";
                strSQL = strSQL + " SalesValue = SUM(SalesValue), ValueOfEndingBalance = SUM(ValueOfEndingBalance), ";
                strSQL = strSQL + " MonthlySalesInFOBPrice = SUM(MonthlySalesInFOBPrice) ";
                strSQL = strSQL + " FROM ( ";
                strSQL = strSQL + " SELECT	tblBatchs.Id, tblBatchs.ItemGuid, tblBatchs.TableRowGuid, tblItems.Id as ItemId, tblItems.BrandName + ' (' + tblItems.GenericName + ') ' + tblItems.Strength + ' ' + tblDosageForms.Name AS Item,   ";
                strSQL = strSQL + " 		tblItems.DosageFormGuid, tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS Unit,   ";
                strSQL = strSQL + " 		tblBatchs.BatchNumber, UnitPrice = Isnull(tblBatchs.SalePrice, 0),   ";
                strSQL = strSQL + "         OpeningQuantity = Isnull(Opening.ReceivedQuantity, 0) - Isnull(Opening.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(Opening.DamagedQuantity, 0) - Isnull(Opening.RecalledQuantity, 0),  ";
                strSQL = strSQL + " 		ReceiptQuantity = Isnull(PeriodActivity.ReceivedQuantity, 0),  ";
                strSQL = strSQL + " 		ClosingQuantity = Isnull(Closing.ReceivedQuantity, 0) - Isnull(Closing.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(Closing.DamagedQuantity, 0) - Isnull(Closing.RecalledQuantity, 0),  ";

                strSQL = strSQL + "         SalesQuantity = (Isnull(OpeningWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 						- Isnull(OpeningWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.RecalledQuantity, 0))  ";
                strSQL = strSQL + " 		                + Isnull(PeriodActivityWithoutFOCInvoice.ReceivedQuantity, 0)  ";
                strSQL = strSQL + " 		                - (Isnull(ClosingWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(ClosingWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.RecalledQuantity, 0)),  ";


                strSQL = strSQL + "         PeriodActivityQuantity = Isnull(PeriodActivityWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(PeriodActivityWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(PeriodActivityWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(PeriodActivityWithoutFOCInvoice.RecalledQuantity, 0),  ";
                strSQL = strSQL + " 		MonthlySalesForecast = Isnull(tblItems.MonthlySalesForecast, 0),  ";
                strSQL = strSQL + "   ";
                strSQL = strSQL + " 		SalesValue = Isnull(tblBatchs.SalePrice, 0)   ";
                strSQL = strSQL + "                         * ((Isnull(OpeningWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 						- Isnull(OpeningWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(OpeningWithoutFOCInvoice.RecalledQuantity, 0))  ";
                strSQL = strSQL + " 		                + Isnull(PeriodActivityWithoutFOCInvoice.ReceivedQuantity, 0)  ";
                strSQL = strSQL + " 		                - (Isnull(ClosingWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(ClosingWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.RecalledQuantity, 0))),  ";

                strSQL = strSQL + " 		ValueOfEndingBalance = Isnull(tblBatchs.SalePrice, 0) * (Isnull(Closing.ReceivedQuantity, 0) - Isnull(Closing.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 								- Isnull(Closing.DamagedQuantity, 0) - Isnull(Closing.RecalledQuantity, 0)),  ";

                strSQL = strSQL + " 		UnitFOBPrice = Isnull(tblBatchs.PricePerUnit, 0),  ";
                strSQL = strSQL + " 		MonthlySalesInFOBPrice = Isnull(tblBatchs.PricePerUnit, 0) ";
                strSQL = strSQL + "                         * ((Isnull(Opening.ReceivedQuantity, 0) - Isnull(Opening.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 						- Isnull(Opening.DamagedQuantity, 0) - Isnull(Opening.RecalledQuantity, 0))  ";
                strSQL = strSQL + " 		                + Isnull(PeriodActivity.ReceivedQuantity, 0)  ";
                strSQL = strSQL + " 		                - (Isnull(ClosingWithoutFOCInvoice.ReceivedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.IssuedQuantity, 0)   ";
                strSQL = strSQL + " 							- Isnull(ClosingWithoutFOCInvoice.DamagedQuantity, 0) - Isnull(ClosingWithoutFOCInvoice.RecalledQuantity, 0)))  ";

                strSQL = strSQL + " FROM	tblItems INNER JOIN tblUnitOfMeasurements   ";
                strSQL = strSQL + " 			ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid   ";
                strSQL = strSQL + "         INNER JOIN tblDosageForms   ";
                strSQL = strSQL + " 			ON tblItems.DosageFormGuid = tblDosageForms.TableRowGuid   ";
                strSQL = strSQL + " 		INNER JOIN tblBatchs   ";
                strSQL = strSQL + " 			ON tblItems.TableRowGuid = tblBatchs.ItemGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockUptoDateBalance(Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).AddDays(-1).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS Opening   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = Opening.BatchGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockUptoDateBalanceWithoutFOCInvoice(Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).AddDays(-1).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS OpeningWithoutFOCInvoice   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = OpeningWithoutFOCInvoice.BatchGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockUptoDateBalance(Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS Closing   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = Closing.BatchGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockUptoDateBalanceWithoutFOCInvoice(Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS ClosingWithoutFOCInvoice   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = ClosingWithoutFOCInvoice.BatchGuid   ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockPeriodActivity(Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + "), Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS PeriodActivity   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = PeriodActivity.BatchGuid  ";
                strSQL = strSQL + " 		LEFT OUTER JOIN StockPeriodActivityWithoutFOCInvoice(Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + "), Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) AS PeriodActivityWithoutFOCInvoice   ";
                strSQL = strSQL + " 			ON tblBatchs.TableRowGuid = PeriodActivityWithoutFOCInvoice.BatchGuid  ";
                strSQL = strSQL + " 			where ((Isnull(Opening.ReceivedQuantity, 0) - Isnull(Opening.IssuedQuantity, 0)) > 0 Or Isnull(PeriodActivity.ReceivedQuantity, 0) > 0) ";
                strSQL = strSQL + " ) AS Q1 ";
                strSQL = strSQL + " GROUP BY	ItemId, ItemGuid, Item, Unit, UnitPrice, UnitFOBPrice ";
                strSQL = strSQL + " ORDER BY Item  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Sales Statement";
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
                if (optByBatch.Checked == true)
                    ShowSalesStatement();
                else if (optByItem.Checked == true)
                    ShowSalesStatementByItem();
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

        private void frmSalesStatement_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
