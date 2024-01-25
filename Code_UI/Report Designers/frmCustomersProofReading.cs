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
    public partial class frmCustomersProofReading : Form
    {
        private const string DialogCaption = "Customers Proof Reading";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector cusSelector = null;

        public frmCustomersProofReading()
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

        public void ShowCustomers()
        {
            try
            {
                DataTable dt = new DataTable();
                rptCustomersProofReading rpt = new rptCustomersProofReading();
                frmReportViewer frm = null;

                string Locationguid = string.Empty;
                string Customertypeguid = string.Empty;
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
                strSQL = strSQL + "                 dbo.tblCustomerTypes.Description AS CustomerType, dbo.tblLocations.Name AS Location, ";
                strSQL = strSQL + "                 Licenses.LicenseNumber, Licenses.RegistrationDate, ";
                strSQL = strSQL + "                 Licenses.LicenseeFirstName, Licenses.LicenseeFatherName, Licenses.LicenseeGrandName, ";
                strSQL = strSQL + "                 Licenses.LevelGuid, Licenses.LicenseLevel, Licenses.ValidFrom, Licenses.ValidTo ";
                strSQL = strSQL + " FROM      dbo.tblCustomers INNER JOIN ";
                strSQL = strSQL + "                 dbo.tblCustomerTypes ON dbo.tblCustomers.CustomerTypeGuid = dbo.tblCustomerTypes.TableRowGuid INNER JOIN ";
                strSQL = strSQL + "                 dbo.tblLocations ON dbo.tblCustomers.LocationGuid = dbo.tblLocations.TableRowGuid LEFT OUTER JOIN";
                strSQL = strSQL + "                 (SELECT Top 1 tblLicenses.LicenseNumber, tblLicenses.RegistrationDate,  ";
                strSQL = strSQL + "                 tblLicenses.FirstName AS LicenseeFirstName, ";
                strSQL = strSQL + "                 tblLicenses.FatherName AS LicenseeFatherName,  ";
                strSQL = strSQL + "                 tblLicenses.GrandName AS LicenseeGrandName,  ";
                strSQL = strSQL + "                 tblLicenses.LevelGuid, tblLicenses.ValidFrom, tblLicenses.ValidTo,  ";
                strSQL = strSQL + "                 tblLicenses.CustomerGuid, tblLevels.Name AS LicenseLevel ";
                strSQL = strSQL + "                 From tblLicenses INNER JOIN tblLevels ";
                strSQL = strSQL + "                 ON dbo.tblLicenses.LevelGuid = dbo.tblLevels.TableRowGuid ";
                strSQL = strSQL + "                 Where IsNull(IsActive, 0) = 1) Licenses ";
                strSQL = strSQL + "                 ON dbo.tblCustomers.TableRowGuid = Licenses.CustomerGuid ";
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
                    frm.Text = "List of Customers - Proof Reading";
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
        public void ShowCustomersSimpleList()
        {
            try
            {
                DataTable dt = new DataTable();
                rptCustomersProofReading1 rpt = new rptCustomersProofReading1();
                frmReportViewer frm = null;

                string Customerguid = string.Empty;

                Customerguid = this.txtCustomerFilter.Text.Length > 0 && this.txtCustomerFilter.Tag != null ? this.txtCustomerFilter.Tag.ToString() : "0";

                rpt.Customerguid = Customerguid;

                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT TOP (100) PERCENT dbo.tblCustomers.Id, dbo.tblCustomers.TableRowGuid, dbo.tblCustomers.Name, dbo.tblCustomers.MailingAddress, dbo.tblCustomers.Fax, dbo.tblCustomers.Tel1,  ";
                strSQL = strSQL + "                 dbo.tblCustomers.Tel2, dbo.tblCustomers.email, dbo.tblCustomers.ContactName, dbo.tblCustomers.ContactFax,  ";
                strSQL = strSQL + "                 dbo.tblCustomers.ContactTel1, dbo.tblCustomers.ContactTel2, dbo.tblCustomers.Contactemail, dbo.tblCustomers.TIN,  ";
                strSQL = strSQL + "                 dbo.tblCustomers.CustomerTypeGuid, dbo.tblCustomers.Discount, dbo.tblCustomers.CreditLimit, dbo.tblCustomers.LocationGuid,  ";
                strSQL = strSQL + "                 dbo.tblCustomerTypes.Description AS CustomerType, dbo.tblLocations.Name AS Location, ";
                strSQL = strSQL + "                 Licenses.LicenseNumber, Licenses.RegistrationDate, ";
                strSQL = strSQL + "                 Licenses.LicenseeFirstName, Licenses.LicenseeFatherName, Licenses.LicenseeGrandName, ";
                strSQL = strSQL + "                 Licenses.LevelGuid, Licenses.LicenseLevel, Licenses.ValidFrom, Licenses.ValidTo ";
                strSQL = strSQL + " FROM      dbo.tblCustomers INNER JOIN ";
                strSQL = strSQL + "                 dbo.tblCustomerTypes ON dbo.tblCustomers.CustomerTypeGuid = dbo.tblCustomerTypes.TableRowGuid INNER JOIN ";
                strSQL = strSQL + "                 dbo.tblLocations ON dbo.tblCustomers.LocationGuid = dbo.tblLocations.TableRowGuid LEFT OUTER JOIN";
                strSQL = strSQL + "                 (SELECT Top 1 tblLicenses.LicenseNumber, tblLicenses.RegistrationDate,  ";
                strSQL = strSQL + "                 tblLicenses.FirstName AS LicenseeFirstName, ";
                strSQL = strSQL + "                 tblLicenses.FatherName AS LicenseeFatherName,  ";
                strSQL = strSQL + "                 tblLicenses.GrandName AS LicenseeGrandName,  ";
                strSQL = strSQL + "                 tblLicenses.LevelGuid, tblLicenses.ValidFrom, tblLicenses.ValidTo,  ";
                strSQL = strSQL + "                 tblLicenses.CustomerGuid, tblLevels.Name AS LicenseLevel ";
                strSQL = strSQL + "                 From tblLicenses INNER JOIN tblLevels ";
                strSQL = strSQL + "                 ON dbo.tblLicenses.LevelGuid = dbo.tblLevels.TableRowGuid ";
                strSQL = strSQL + "                 Where IsNull(IsActive, 0) = 1) Licenses ";
                strSQL = strSQL + "                 ON dbo.tblCustomers.TableRowGuid = Licenses.CustomerGuid ";
                if (Customerguid != "0" && Customerguid != string.Empty) strSQL = strSQL + " WHERE (tblCustomers.TableRowGuid = '" + Customerguid + "') ";
                strSQL = strSQL + " Order By Name ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewer(rpt.Document);
                    frm.MdiParent = this.Owner;
                    frm.Text = "List of Customers - Proof Reading";
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
                if (this.chkSimpleList.CheckState == CheckState.Unchecked)
                {
                    ShowCustomers();
                }
                else if (this.chkSimpleList.CheckState == CheckState.Checked)
                {
                    ShowCustomersSimpleList();
                }
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
                CCommon.FillComboBox(cboCustomerType, "Select TableRowGuid, description from tblCustomerTypes order by description ", "TableRowGuid", "description", false);
                cboLocation.SelectedIndex = CCommon.GetIndexByItemData(cboLocation, CSettings.DefaultWorkingLocation.ToString(), true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkSimpleList_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.chkSimpleList.CheckState == CheckState.Unchecked)
                {
                    this.grpCustomer.Enabled = false;
                    this.grpLocation.Enabled = true;
                    this.grpDiscount.Enabled = true;
                }
                else if (this.chkSimpleList.CheckState == CheckState.Checked)
                {
                    this.grpCustomer.Enabled = true;
                    this.grpLocation.Enabled = false;
                    this.grpDiscount.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectCustomer frmCust = new frmSelectCustomer();
                frmCust.ShowDialog();
                if (frmCust.bCancel == true) return;
                this.txtCustomerFilter.Tag = frmCust.Customerguid.ToString();
                this.txtCustomerFilter.Text = frmCust.CustomerName.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchCustomer(TextBox SearchTextBox, int HorizontalOffset, int VerticalOffset)
        {
            try
            {
                if (SearchTextBox.Text != "")
                {
                    CSuppliesRequisitions objCustomer = new CSuppliesRequisitions();
                    string nameLike = SearchTextBox.Text + "%";
                    objCustomer.OrganizationName = nameLike;
                    ArrayList ar = new ArrayList(objCustomer.GetCustomerByName());
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        cusSelector = new frmCustomerSelector();
                        cusSelector.SearchTextBox = SearchTextBox;
                        cusSelector.Width = SearchTextBox.Width;
                        cusSelector.lvwCustomer.Items.Clear();
                        foreach (CSuppliesRequisitions Customer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Customer.Customerguid.ToString(),
                            Customer.OrganizationName.ToString()});
                            cusSelector.lvwCustomer.Items.Add(itmX);
                        }
                        Point location = this.PointToScreen(new Point(SearchTextBox.Left + HorizontalOffset, SearchTextBox.Bottom + VerticalOffset));
                        popupHelper.ShowPopup(this, cusSelector, location);

                        if (cusSelector.blnSelected)
                        {
                            SearchTextBox.Tag = cusSelector.Customerguid;
                            SearchTextBox.Text = cusSelector.OrganizationName;
                        }
                    }
                    else
                    {
                        CSuppliesRequisitions Customer = (CSuppliesRequisitions)ar[0];
                        SearchTextBox.Tag = Customer.Customerguid;
                        SearchTextBox.Text = Customer.OrganizationName;
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
                if (cusSelector.blnSelected)
                {
                    SearchTextBox = cusSelector.SearchTextBox;
                    if (SearchTextBox != null)
                    {
                        SearchTextBox.Tag = cusSelector.Customerguid;
                        SearchTextBox.Text = cusSelector.OrganizationName;
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

        private void txtCustomerFilter_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    SearchCustomer(txtCustomerFilter, grpCustomer.Left, grpCustomer.Top);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnSearchCustomer1_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCustomer(txtCustomerFilter, grpCustomer.Left, grpCustomer.Top);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
