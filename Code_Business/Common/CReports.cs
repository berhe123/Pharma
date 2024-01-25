using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections;
using System.Globalization;
using System.Windows.Forms;

namespace Pharma
{
    class CReports
    {
        public static void ShowBanks(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptLookups rpt = new rptLookups();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblBanks.id, tblBanks.TableRowGuid, tblBanks.Name   ";
                strSQL = strSQL + " FROM      tblBanks  ";
                strSQL = strSQL + " Order By tblBanks.Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of Banks";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of Banks";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowBanks::Error! " + ex.Message, ex);
            }
        }
        public static void ShowLocations(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptLookups rpt = new rptLookups();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblLocations.id, tblLocations.TableRowGuid, tblLocations.Name  ";
                strSQL = strSQL + " FROM      tblLocations  ";
                strSQL = strSQL + " Order By tblLocations.Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of Locations";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of Locations";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowLocations::Error! " + ex.Message, ex);
            }
        }
        public static void ShowItemCategories(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptLookups rpt = new rptLookups();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblItemCategories.id, tblItemCategories.TableRowGuid, tblItemCategories.Name  ";
                strSQL = strSQL + " FROM      tblItemCategories  ";
                strSQL = strSQL + " Order By tblItemCategories.Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of Item Categories";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of Item Categories";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowItemCategories::Error! " + ex.Message, ex);
            }
        }
        public static void ShowUnitOfMeasurements(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptLookups rpt = new rptLookups();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblUnitOfMeasurements.id, tblUnitOfMeasurements.TableRowGuid, tblUnitOfMeasurements.Name  ";
                strSQL = strSQL + " FROM      tblUnitOfMeasurements  ";
                strSQL = strSQL + " Order By tblUnitOfMeasurements.Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of Unit of Measurements";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of Unit of Measurements";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowUnitOfMeasurements::Error! " + ex.Message, ex);
            }
        }
        public static void ShowLicenseLevels(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptLookups rpt = new rptLookups();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblLevels.id, tblLevels.TableRowGuid, tblLevels.Name  ";
                strSQL = strSQL + " FROM      tblLevels  ";
                strSQL = strSQL + " Order By tblLevels.Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of License Levels";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of License Levels";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowLicenseLevels::Error! " + ex.Message, ex);
            }
        }
        public static void ShowCustomerTypes(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptLookups rpt = new rptLookups();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblCustomerTypes.id, tblCustomerTypes.TableRowGuid, tblCustomerTypes.Description AS Name  ";
                strSQL = strSQL + " FROM      tblCustomerTypes  ";
                strSQL = strSQL + " Order By tblCustomerTypes.Description ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of Customer Types";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of Customer Types";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowCustomerTypes::Error! " + ex.Message, ex);
            }
        }
        public static void ShowTermsOfContractTemplates(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptTermsOfContractTemplates rpt = new rptTermsOfContractTemplates();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblTermsOfContractTemplates.id, tblTermsOfContractTemplates.TableRowGuid, tblTermsOfContractTemplates.TemplateName, tblTermsOfContractTemplates.TemplateContent  ";
                strSQL = strSQL + " FROM      tblTermsOfContractTemplates  ";
                strSQL = strSQL + " Order By tblTermsOfContractTemplates.TemplateName ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of Terms of Contract Templates";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of Terms of Contract Templates";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowTermsOfContractTemplates::Error! " + ex.Message, ex);
            }
        }
        public static void ShowCountries(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptCountries rpt = new rptCountries();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblCountries.id, tblCountries.TableRowGuid, tblCountries.Code, tblCountries.ShortName, tblCountries.Name   ";
                strSQL = strSQL + " FROM      tblCountries  ";
                strSQL = strSQL + " Order By tblCountries.Code, tblCountries.ShortName, tblCountries.Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of Countries";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of Countries";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowCountries::Error! " + ex.Message, ex);
            }
        }
        public static void ShowStores(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptStores rpt = new rptStores();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblStores.Id, tblStores.LocationGuid, tblStores.TableRowGuid, tblLocations.Name AS Location, tblStores.Name, tblStores.Address   ";
                strSQL = strSQL + " FROM      tblStores INNER JOIN tblLocations ";
                strSQL = strSQL + " ON      tblStores.LocationGuid = tblLocations.TableRowGuid ";
                strSQL = strSQL + " Order By tblLocations.Name, tblStores.Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of Stores";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of Stores";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowStores::Error! " + ex.Message, ex);
            }
        }
        public static void ShowManufacturers(System.Windows.Forms.Form MdiParent)
        {
            DataTable dt = new DataTable();
            rptManufacturers rpt = new rptManufacturers();
            frmReportViewer frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = " SELECT  TOP (100) PERCENT tblManufacturers.*, tblCountries.Name AS Country ";
                strSQL = strSQL + " FROM      tblManufacturers INNER JOIN tblCountries ";
                strSQL = strSQL + " ON      tblManufacturers.CountryGuid = tblCountries.TableRowGuid ";
                strSQL = strSQL + " Order By tblCountries.Name, tblManufacturers.Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;
                    rpt.ReportTitle = "List of Manufacturers";

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = MdiParent;
                    frm.Text = "List of Manufacturers";
                    frm.Show();
                    frm.WindowState = FormWindowState.Normal;
                    frm.WindowState = FormWindowState.Maximized;
                }
                else
                    throw new Exception("Report Generation - No Record Found", null);
            }
            catch (Exception ex)
            {
                throw new Exception("CReports::ShowManufacturers::Error! " + ex.Message, ex);
            }
        }

    }
}
