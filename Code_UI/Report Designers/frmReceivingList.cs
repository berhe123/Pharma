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
    public partial class frmReceivingList : Form
    {
        private const string DialogCaption = "Received Goods List";

        public frmReceivingList()
        {
            InitializeComponent();
        }

        public void ShowReceivedGoodsList()
        {
            try
            {
                DataTable dt = new DataTable();
                rptReceivingList rpt = new rptReceivingList();
                frmReportViewer frm = null;

                //string Customerguid = "-1";
                rpt.ReceivedDateFrom = CDateTime.DateFromStringForSQLMin(this.txtDateFromReceived.Text);
                rpt.ReceivedDateTo = CDateTime.DateFromStringForSQLMax(this.txtDateToReceived.Text);

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT	TableRowGuid = vwReceiving.TransactionDetailGuid, vwReceiving.StoreGuid, StoreName = tblStores.Name,  ";
                strSQL = strSQL + " 		vwReceiving.TransactionDate, tblBatchs.BatchNumber,  ";
                strSQL = strSQL + " 		(tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName,   ";
                strSQL = strSQL + " 		vwReceiving.Quantity, PricePerUnit = tblBatchs.PricePerUnit, ";
                strSQL = strSQL + " 		ReceivedAmount = IsNull(vwReceiving.Quantity, 0) * IsNull(tblBatchs.PricePerUnit, 0) ";
                strSQL = strSQL + " FROM	vwReceiving Inner Join tblBatchs ";
                strSQL = strSQL + " 			On dbo.vwReceiving.BatchGuid = tblBatchs.TableRowGuid ";
                strSQL = strSQL + " 		Inner Join tblItems ";
                strSQL = strSQL + " 			On tblBatchs.ItemGuid = tblItems.TableRowGuid ";


                strSQL = strSQL + "                 inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid  ";
                strSQL = strSQL + "                 inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
                strSQL = strSQL + "                 inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid ";



                strSQL = strSQL + " 		LEFT OUTER JOIN tblUnitOfMeasurements   ";
                strSQL = strSQL + " 			ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid   ";                
                strSQL = strSQL + " 		INNER JOIN tblStores   ";
                strSQL = strSQL + " 			ON vwReceiving.StoreGuid = tblStores.TableRowGuid ";
                strSQL = strSQL + " WHERE (vwReceiving.TransactionDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFromReceived.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                strSQL = strSQL + " AND (vwReceiving.TransactionDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateToReceived.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                strSQL = strSQL + " ORDER BY tblStores.Name, vwReceiving.TransactionDate, BrandName, tblBatchs.BatchNumber  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Received Goods List";
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
                ShowReceivedGoodsList();
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

        private void frmReceivingList_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtDateFromReceived.Text = DateTime.Today.ToString(CSettings.DateFormat);
                this.txtDateToReceived.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDateFromReceived_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
