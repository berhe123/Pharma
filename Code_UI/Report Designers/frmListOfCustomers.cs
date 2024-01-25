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
    public partial class frmListOfCustomers : Form
    {
        private const string DialogCaption = "List of Customers";

        public frmListOfCustomers()
        {
            InitializeComponent();
        }

        public void ShowCustomers()
        {
            try
            {
                DataTable dt = new DataTable();
                rptCustomers rpt = new rptCustomers();
                frmReportViewer frm = null;

                string Locationguid = "0";
                string Customertypeguid = "0";
                string DiscountRate = "0";
                string CreditLimit = "0";

                Locationguid = CCommon.GetItemData(cboLocation);
                Customertypeguid = CCommon.GetItemData(cboCustomerType);
                DiscountRate = this.txtDiscountRate.Text.Length > 0 ? this.txtDiscountRate.Text : "0";
                CreditLimit = this.txtCreditLimit.Text.Length > 0 ? this.txtCreditLimit.Text : "0";

                rpt.Location = this.cboLocation.Text;
                rpt.Locationguid = Locationguid;
                rpt.CustomerType = this.cboCustomerType.Text;
                rpt.Customertypeguid = Customertypeguid;
                rpt.DiscountRate = Convert.ToDecimal(DiscountRate);
                rpt.CreditLimit = Convert.ToDecimal(CreditLimit);

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT TOP (100) PERCENT dbo.tblCustomers.Id, dbo.tblCustomers.TableRowGuid, dbo.tblCustomers.Name, dbo.tblCustomers.MailingAddress, dbo.tblCustomers.Fax, dbo.tblCustomers.Tel1,  ";
                strSQL = strSQL + "                 dbo.tblCustomers.Tel2, dbo.tblCustomers.email, dbo.tblCustomers.ContactName, dbo.tblCustomers.ContactFax,  ";
                strSQL = strSQL + "                 dbo.tblCustomers.ContactTel1, dbo.tblCustomers.ContactTel2, dbo.tblCustomers.Contactemail, dbo.tblCustomers.TIN,  ";
                strSQL = strSQL + "                 dbo.tblCustomers.CustomerTypeGuid, dbo.tblCustomers.Discount, dbo.tblCustomers.CreditLimit, dbo.tblCustomers.LocationGuid,  ";
                strSQL = strSQL + "                 dbo.tblCustomerTypes.Description AS CustomerType, dbo.tblLocations.Name AS Location ";
                strSQL = strSQL + " FROM      dbo.tblCustomers INNER JOIN ";
                strSQL = strSQL + "                 dbo.tblCustomerTypes ON dbo.tblCustomers.CustomerTypeGuid = dbo.tblCustomerTypes.TableRowGuid INNER JOIN ";
                strSQL = strSQL + "                 dbo.tblLocations ON dbo.tblCustomers.LocationGuid = dbo.tblLocations.TableRowGuid ";
                strSQL = strSQL + " WHERE (IsNull(Discount, 0) >= " + DiscountRate + ")  ";
                strSQL = strSQL + " AND (IsNull(CreditLimit, 0) >= " + CreditLimit + ")  ";
                if (Locationguid != "-1") strSQL = strSQL + " AND (LocationGuid = '" + Locationguid + "') ";
                if (Customertypeguid != "-1") strSQL = strSQL + " AND (CustomerTypeGuid = '" + Customertypeguid + "') ";
                strSQL = strSQL + " Order By Location, CustomerType, Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "List of Customers";
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
                ShowCustomers();
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
                CCommon.FillComboBox(cboLocation, "Select TableRowGuid, name from tblLocations order by name ", "TableRowGuid", "name", false);
                CCommon.FillComboBox(cboCustomerType, "Select TableRowGuid, description from tblCustomerTypes order by description", "TableRowGuid", "description", false);
                cboLocation.SelectedIndex = CCommon.GetIndexByItemData(cboLocation, CSettings.DefaultWorkingLocation.ToString(), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
