using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharma.Code_UI.Data_Entry_Designers
{
    public partial class frmSupplier : Form
    {
        private const string DialogCaption = " Supplier Details ";
        public frmSupplier()
        {
            InitializeComponent();
        }

        public void SupplierDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                frmReportViewer frm = null;
                Pharma.Code_UI.Report_Designers.rptSupplier rpt = new Pharma.Code_UI.Report_Designers.rptSupplier();
                string strSQL = string.Empty;
                strSQL = " Select TableRowGuid = vwReceiving.TransactionDetailGuid, Name as SupplierName, MailingAddress as Address, Tel1 as Tel,email,Fax,TIN,vwReceiving.TransactionDate from tblItems";
                strSQL = strSQL + " inner join tblBatchs on tblBatchs.ItemGuid= tblItems.TableRowGuid ";
                strSQL = strSQL + " inner join tblManufacturers on tblManufacturers.TableRowGuid =tblItems.ManufacturerGuid ";
                strSQL = strSQL + " inner join vwReceiving on vwReceiving.BatchGuid =tblBatchs.TableRowGuid ";
                strSQL = strSQL + " WHERE (vwReceiving.TransactionDate >= Convert(datetime, '" + CDateTime.DateFromStringForSQLMin(this.txtDateFrom.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                strSQL = strSQL + " AND (vwReceiving.TransactionDate <= Convert(datetime, '" + CDateTime.DateFromStringForSQLMax(this.txtDateTo.Text).ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ")) ";
                strSQL = strSQL + " order by SupplierName";
                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = " Supplier Details ";
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
                SupplierDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void frmSupplier_Load(object sender, EventArgs e)
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
