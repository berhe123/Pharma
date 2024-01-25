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
    public partial class frmRegistrationFeeTable : Form
    {
        private const string DialogCaption = "List of Registration Fee Table";

        public frmRegistrationFeeTable()
        {
            InitializeComponent();
        }

        private void ShowSalesStatement()
        {
            try
            {
                DataTable dt = new DataTable();
                rptDrugRegistrationFeeTable rpt = new rptDrugRegistrationFeeTable();
                frmReportViewer frm = null;

                //rpt.DateFrom = this.txtDateFrom.Text;
                //rpt.DateTo = this.txtDateTo.Text;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   TOP (100) PERCENT tblProductRegistrationCertificates.Id, tblProductRegistrationCertificates.TableRowGuid, ";
                strSQL = strSQL + "                 '" + CSettings.OrganizationName + "' AS Agent, ";
                strSQL = strSQL + "                 tblManufacturers.Name AS ManufacturerName, tblCountries.Name AS ManufacturerCountry, tblManufacturers.MailingAddress,  ";
                strSQL = strSQL + "                 tblProducts.BrandName + ' ' + tblProducts.GenericName AS ProductName, tblProductRegistrationCertificates.SlipOrCpoNumber, ";
                strSQL = strSQL + "                 tblProductRegistrationCertificates.RegistrationNumber AS CertificateNumber, tblDrugRegistrationTypes.Name AS RegistrationType,  ";
                strSQL = strSQL + "                 tblProductRegistrationCertificates.RegistrationFee, tblProductRegistrationCertificates.RegistrationFeeInForeignCurrency,  ";
                strSQL = strSQL + "                 tblProductRegistrationCertificates.Id AS CertificateId, tblProductRegistrationCertificates.TableRowGuid AS CertificateGuid ";
                strSQL = strSQL + " FROM      tblProductRegistrationCertificates INNER JOIN tblProducts ";
                strSQL = strSQL + "                  ON tblProductRegistrationCertificates.ProductGuid = tblProducts.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblManufacturers ";
                strSQL = strSQL + "                  ON tblProducts.ManufacturerGuid = tblManufacturers.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblCountries ";
                strSQL = strSQL + "                  ON tblManufacturers.CountryGuid = tblCountries.TableRowGuid  ";
                strSQL = strSQL + "             INNER JOIN tblDrugRegistrationTypes ";
                strSQL = strSQL + "                  ON tblProductRegistrationCertificates.RegistrationTypeGuid = tblDrugRegistrationTypes.TableRowGuid  ";
                //strSQL = strSQL + " Where tblDrugRegistrationFeePaymentRequests.TableRowGuid = '" + this.DrugRegistrationFeePaymentRequestsguId + "' ";
                strSQL = strSQL + " ORDER BY ProductName, CertificateNumber  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "Registration Fee Table";
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
                ShowSalesStatement();
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

        private void frmRegistrationFeeTable_Load(object sender, EventArgs e)
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
