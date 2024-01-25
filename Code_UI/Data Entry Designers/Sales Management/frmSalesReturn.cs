using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;

namespace Pharma
{
    public partial class frmSalesReturn : Form
    {
        private const string DialogCaption = "Sales Return";

        private PopupWindowHelper popupHelper = null;
        private frmCustomerSelector childSelector = null;

        private string CustomerGuidSearch = string.Empty;
        private int intTransactionId = 0;
        private bool blnNewTransaction = false;
        private int intTransactionDetailId = 0;

        public frmSalesReturn()
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

        private void ResizeControls()
        {
            try
            {
                // Title label
                this.lblTitle.Width = this.Width + 1;

                // Line just under the title label
                this.line3.Width = this.lblTitle.Width;

                // Main toolbar
                this.panelToolBar.Width = this.lblTitle.Width - this.panelToolBar.Left;
                this.grpInvoice.Width = this.lblTitle.Width - this.grpInvoice.Left - 24;
                this.grpDataEntry.Width = this.lblTitle.Width - this.grpDataEntry.Left - 24;

                // Transactions listview
                this.lvwTransactions.Height = this.Height - this.lvwTransactions.Top - 65;

                this.grvTransactionDetails.Width = this.tabPageSalesReturnDetail.Width - 12;
                this.grvTransactionDetails.Height = this.tabPageSalesReturnDetail.Height - this.grvTransactionDetails.Top - 12;

                // Detail Groupbox and Gridview
                this.tabControlSalesReturnDetail.Height = this.Height - this.tabControlSalesReturnDetail.Top - 65;
                this.tabControlSalesReturnDetail.Width = this.lblTitle.Width - this.tabControlSalesReturnDetail.Left - 24;

                this.panelTotal.Top = this.tabControlSalesReturnDetail.Height - this.panelTotal.Height - 24;
                this.grvTransactionDetails.Width = this.tabControlSalesReturnDetail.Width - 12;
                this.grvTransactionDetails.Height = this.panelTotal.Top - this.panelToolBar.Height - 4;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmSalesReturn_Resize(object sender, EventArgs e)
        {
            try
            {
                ResizeControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmSalesReturn_Load(object sender, EventArgs e)
        {
            try
            {
                CCommon.FillInvoiceTypeCombo(cboInvoiceType);
                txtTransactionDateFrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTransactionDateTo.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTransactionDate.Text = DateTime.Today.ToString(CSettings.DateFormat);

                NewTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchCustomerFilter()
        {
            try
            {
                if (txtCustomerName.Text != "")
                {
                    CSuppliesRequisitions objCustomer = new CSuppliesRequisitions();
                    objCustomer.OrganizationName = txtCustomerName.Text + "%";
                    ArrayList ar = new ArrayList(objCustomer.GetCustomerByName());
                    if (ar.Count <= 0) return;
                    if (ar.Count > 1)
                    {
                        childSelector = new frmCustomerSelector();
                        childSelector.Width = txtCustomerName.Width;
                        childSelector.lvwCustomer.Items.Clear();
                        foreach (CSuppliesRequisitions Customer in ar)
                        {
                            ListViewItem itmX = new ListViewItem(new string[] {
                            Customer.Customerguid.ToString(),
                            Customer.OrganizationName.ToString()});
                            childSelector.lvwCustomer.Items.Add(itmX);
                        }
                        //childSelector.Owner = this;
                        //childSelector.x = 420;
                        //childSelector.y = 150;
                        //childSelector.ShowDialog();

                        //PopupWindowHelper popupHelper1 = new PopupWindowHelper();
                        //popupHelper1.AssignHandle(this.Handle);
                        Point location = this.PointToScreen(new Point(this.grpFilter.Left + this.txtCustomerName.Left, this.grpFilter.Top + this.txtCustomerName.Bottom));
                        popupHelper.ShowPopup(this, childSelector, location);

                        if (childSelector.blnSelected)
                        {
                            CustomerGuidSearch = childSelector.Customerguid;
                            txtCustomerName.Text = childSelector.OrganizationName;
                        }
                    }
                    else
                    {
                        CSuppliesRequisitions Customer = (CSuppliesRequisitions)ar[0];
                        CustomerGuidSearch = Customer.Customerguid;
                        txtCustomerName.Text = Customer.OrganizationName;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFindCustormer_Click(object sender, EventArgs e)
        {
            try
            {
                SearchCustomerFilter();
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
                if (childSelector.blnSelected)
                {
                    CustomerGuidSearch = childSelector.Customerguid;
                    txtCustomerName.Text = childSelector.OrganizationName;
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

        private void NewTransaction()
        {
            try
            {
                blnNewTransaction = true;
                intTransactionId = 0;

                txtInvoiceNumber.Tag = 0;
                txtInvoiceNumber.Text = string.Empty;
                txtReferenceNo.Text = "";
                txtSalesReturnDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtTransactionBy.Text = CSettings.GoodsIssuanceIssuedBy;
                txtReceivedBy.Text = CSettings.GoodsIssuanceIssuedTo;     
                txtTransactionDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                txtReceivedDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
                grvTransactionDetails.Rows.Clear();

                NewInvoice();

                this.txtSubTotal.Text = string.Empty;
                this.txtDiscountAmount.Text = string.Empty;
                this.txtTotalAmount.Text = string.Empty;

                //int maxReferenceNumber = CSalesReturns.GetMaxReferenceNumber((int)CCommon.SalesReturnType.Issuance);
                //this.txtReferenceNo.Text = "0" + (maxReferenceNumber + 1).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidTransaction()
        {
            try
            {
                DateTime dteValidate;

                if (!CCommon.SetRequiredMessage(txtInvoiceNumber, "Invoice number can not be empty. Please enter a valid invoice number.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtReferenceNo, "Reference number can not be empty. Please enter a valid reference number.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtSalesReturnDate, "Sales return date can not be empty.", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtSalesReturnDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtSalesReturnDate, "Please enter sales return date in a correct format", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtTransactionBy, "Issued by can not be empty.", mValidator, lblMsg))
                    return false;
                if (!CCommon.SetRequiredMessage(txtTransactionDate, "Issuance date can not be empty.", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtTransactionDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtTransactionDate, "Please enter issuance date in a correct format", mValidator, lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtReceivedBy, "Received by can not be empty.", mValidator, lblMsg))
                    return false;

                if (!CCommon.SetRequiredMessage(txtReceivedDate, "Received date can not be empty.", mValidator, lblMsg))
                    return false;
                if (!DateTime.TryParseExact(txtReceivedDate.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                {
                    CCommon.SetMessage(txtReceivedDate, "Please enter received date in a correct format", mValidator, lblMsg);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool SaveTransaction()
        {
            try
            {
                if (!IsValidTransaction()) return false;

                CSalesReturns objTransactions = new CSalesReturns();

                objTransactions.Id = intTransactionId;
                objTransactions.Customerguid = txtInvoiceCustomerName.Tag.ToString();
                if (txtInvoiceNumber.Tag != null && txtInvoiceNumber.Tag.ToString() != string.Empty)
                    objTransactions.Salesinvoiceguid = txtInvoiceNumber.Tag.ToString();
                objTransactions.Referencenumber = Convert.ToString(txtReferenceNo.Text);
                objTransactions.Salesreturndate = Convert.ToDateTime(txtSalesReturnDate.Text, CSettings.Culture);
                objTransactions.Issuedby = Convert.ToString(txtTransactionBy.Text);
                objTransactions.Issueddate = Convert.ToDateTime(txtTransactionDate.Text, CSettings.Culture);
                objTransactions.Receivedby = Convert.ToString(txtReceivedBy.Text);
                objTransactions.Receiveddate = Convert.ToDateTime(txtReceivedDate.Text, CSettings.Culture);
                objTransactions.Returnstatus = Convert.ToInt32("0");
                objTransactions.Discount = Convert.ToDecimal(txtDiscount.Text);

                if (objTransactions.Exists(blnNewTransaction) > 0)
                {
                    MessageBox.Show("There exists a sales return record with the given details.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (objTransactions.InvoiceExists(blnNewTransaction) > 0)
                {
                    MessageBox.Show("This invoice has been returned. Please check the data and try again.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (blnNewTransaction)
                    objTransactions.Insert();
                else
                    objTransactions.Update();

                intTransactionId = objTransactions.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void EditTransaction()
        {
            try
            {
                if (lvwTransactions.SelectedItems == null) return;
                if (lvwTransactions.SelectedItems.Count <= 0) return;

                ListViewItem item = new ListViewItem();
                item = lvwTransactions.SelectedItems[0];

                NewInvoice();
                txtInvoiceNumber.Tag = Convert.ToString(item.SubItems[colInvoiceGuid.Index].Text);
                if (txtInvoiceNumber.Tag != null && txtInvoiceNumber.Tag.ToString() != string.Empty)
                {
                    FindInvoices(txtInvoiceNumber.Tag.ToString());
                    FillInvoiceDetailsListByParent(txtInvoiceNumber.Tag.ToString());
                }

                blnNewTransaction = false;
                intTransactionId = Convert.ToInt32(item.SubItems[colTrasactionId.Index].Text);
                txtReferenceNo.Text = Convert.ToString(item.SubItems[colRefNo.Index].Text);
                txtSalesReturnDate.Text = Convert.ToString(item.SubItems[colSalesReturnDate.Index].Text);
                txtTransactionBy.Text = Convert.ToString(item.SubItems[colTransactionBy.Index].Text);
                txtTransactionDate.Text = Convert.ToString(item.SubItems[colTransactionDate.Index].Text);
                txtReceivedBy.Text = Convert.ToString(item.SubItems[colReceivedDate.Index].Text);
                txtReceivedDate.Text = Convert.ToString(item.SubItems[colReceivedDate.Index].Text);

                FillTransactionDetailGrid(CSalesReturns.GetTableRowGuid(intTransactionId));

                CalculateTotal();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillTransactionList(string strCriteria)
        {
            try
            {

                CSalesReturns objTransaction = new CSalesReturns();

                ArrayList ar = new ArrayList(objTransaction.GetList(strCriteria));
                this.lvwTransactions.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CSalesReturns SalesReturn in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {               SalesReturn.Id.ToString(), 
                                                                                      SalesReturn.Customerguid.ToString(), 
                                                                                      SalesReturn.Salesinvoiceguid.ToString(), 
                                                                                      SalesReturn.InvoiceNumber.ToString(), 
                                                                                      SalesReturn.Referencenumber.ToString(),
                                                                                      SalesReturn.Salesreturndate.ToString(CSettings.DateFormat),
                                                                                      SalesReturn.Issuedby.ToString(),                    
                                                                                      SalesReturn.Issueddate.ToString(CSettings.DateFormat),
                                                                                      SalesReturn.Receivedby.ToString(),
                                                                                      SalesReturn.Receiveddate.ToString(CSettings.DateFormat),
                                                                                      SalesReturn.Returnstatus.ToString(),
                                                                                      SalesReturn.Discount.ToString()});

                    this.lvwTransactions.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string ShowItem(string strBatchNo)
        {
            try
            {
                string strBrandName = "";
                CSalesReturnDetails objTranDetails = new CSalesReturnDetails();
                strBrandName = objTranDetails.GetItemByBacth(strBatchNo);
                return strBrandName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
        private void FillOrderBatchNumbersList(string strOrderNo)
        {
            
            try
            {
                grvTransactionDetails.Rows.Clear();

                CSalesReturnDetails objTranDetails = new CSalesReturnDetails();               

                ArrayList ar = new ArrayList(objTranDetails.GetBacthItemsByInvoiceNo(strOrderNo));

                if (ar.Count <= 0) return;

                foreach (CSalesReturnDetails BatchItems in ar)
                {
                    grvTransactionDetails.Rows.Add(new string[] { intTransactionDetailId.ToString(), 
                                                                    BatchItems.BatchGuidFromtblInvoiceDetails.ToString(),
                                                                    CSalesReturns.GetTableRowGuid(intTransactionId),                                        
                                                                    BatchItems.BatchNumber.ToString(),
                                                                    BatchItems.BrandName.ToString(),                                                            
                                                                    BatchItems.Quantity.ToString(),                                                            
                                                                    BatchItems.Unitprice.ToString(CSettings.CurrencyFormat),
                                                                    (BatchItems.Quantity * BatchItems.Unitprice).ToString(CSettings.CurrencyFormat)
                    });


                }
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       
        private void SaveTransactionDetail()
        {
            try
            {
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount - 1; grRow++)
                {
                    int tran_id = 0;
                    bool blnNewTransactionDetail = false;
                    if (!ValidateRow(grRow)) break;
                    CSalesReturnDetails objTranDetail = new CSalesReturnDetails();
                    if (Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value) == 0)
                    {
                        blnNewTransactionDetail = true;
                        tran_id = 0;
                    }
                    else
                    {
                        blnNewTransactionDetail = false;
                        tran_id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                    }

                    objTranDetail.Id = tran_id;
                    objTranDetail.Salesreturnguid = CSalesReturns.GetTableRowGuid(intTransactionId);
                    objTranDetail.Batchguid = grvTransactionDetails.Rows[grRow].Cells["colBatchGuid"].Value.ToString();
                    objTranDetail.Quantity = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value);
                    objTranDetail.Unitprice = Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colUnitPriceGrid"].Value);

                    if (blnNewTransactionDetail)
                    {
                        if (objTranDetail.Exists(true) <= 0)
                        {
                            objTranDetail.Insert();
                            grvTransactionDetails.Rows[grRow].Cells["colId"].Value = objTranDetail.Id;
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This Item is Already Issued! ";

                    }
                    else
                    {
                        if (objTranDetail.Exists(false) <= 0)
                        {
                            objTranDetail.Id = Convert.ToInt32(tran_id.ToString());
                            objTranDetail.Update();
                        }
                        else
                            grvTransactionDetails.Rows[grRow].ErrorText = "This Item is Already Issued! ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateRow(int grRow)
        {
            try
            {
                decimal dcmValue;

                if (grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value == null)
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The Quantity Can Not Be Empty";
                    return false;
                }
                if (!decimal.TryParse(grvTransactionDetails.Rows[grRow].Cells["colQuantity"].Value.ToString(), out dcmValue))
                {
                    grvTransactionDetails.Rows[grRow].ErrorText = "The Quantity must be numeric";
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void ShowSalesReturn()
        {
            DataTable dt = new DataTable();
            rptSalesReturn rpt = new rptSalesReturn();
            frmReportViewerInvoice frm = null;

            try
            {
                string strSQL = string.Empty;

                strSQL = strSQL + " SELECT   TOP (100) PERCENT SalesReturns.*, Groupings.* ";
                strSQL = strSQL + " FROM ( ";
                strSQL = strSQL + " SELECT   TOP (100) PERCENT tblItems.Measurement, tblItems.BrandName, tblItems.GenericName, tblItems.DosageFormGuid,   ";
                strSQL = strSQL + "                 tblItems.Strength, tblUnitOfMeasurements.Name AS UnitName, tblCustomers.Name AS CustomerName, tblCustomers.TIN AS CustomerTin,   ";
                strSQL = strSQL + "                 tblCustomers.MailingAddress, tblCustomers.email, tblCustomers.Tel2, tblCustomers.Tel1, tblCustomers.Fax,   ";
                strSQL = strSQL + "                 'Tel: ' + tblCustomers.Tel1 + ', Fax: ' + tblCustomers.Fax + ', Email: ' + tblCustomers.email AS Address1,   ";
                strSQL = strSQL + "                 tblUnitOfMeasurements.Name + ' ' + tblItems.Measurement AS UnitOfMeasurement,   ";
                strSQL = strSQL + "                 tblItems.BrandName + ' (' + tblItems.GenericName + ') ' + tblItems.Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.Name AS ItemDescription,   ";
                strSQL = strSQL + "                 tblSalesReturns.Id, tblSalesReturns.TableRowGuid, tblSalesReturns.CustomerGuid, tblSalesReturns.ReferenceNumber, tblSalesReturns.SalesReturnDate, tblSalesReturns.SalesInvoiceGuid,  ";
                strSQL = strSQL + "                 tblInvoices.ReferenceNumber AS InvoiceNumber, tblInvoices.InvoiceDate, tblSalesReturns.IssuedBy, tblSalesReturns.ReceivedBy,   ";
                strSQL = strSQL + "                 tblSalesReturns.IssuedDate, tblSalesReturns.ReceivedDate, tblSalesReturns.ReturnStatus, tblSalesReturns.Discount, tblBatchs.BatchNumber,   ";
                strSQL = strSQL + "                 tblSalesReturnDetails.UnitPrice AS PricePerUnit, tblSalesReturnDetails.Quantity, tblSalesReturnDetails.Id AS DetailId, tblSalesReturnDetails.TableRowGuid AS DetailGuid,  ";
                strSQL = strSQL + "                 tblSalesReturnDetails.UnitPrice * tblSalesReturnDetails.Quantity AS LineTotal ";
                strSQL = strSQL + " FROM      tblSalesReturns INNER JOIN tblSalesReturnDetails ";
                strSQL = strSQL + "                  ON tblSalesReturnDetails.SalesReturnGuid = tblSalesReturns.TableRowGuid  ";
                strSQL = strSQL + " 			INNER JOIN tblInvoices  ";
                strSQL = strSQL + "                  ON tblSalesReturns.SalesInvoiceGuid = tblInvoices.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblBatchs  ";
                strSQL = strSQL + "                  ON tblSalesReturnDetails.BatchGuid = tblBatchs.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblItems  ";
                strSQL = strSQL + "                  ON tblBatchs.ItemGuid = tblItems.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblUnitOfMeasurements  ";
                strSQL = strSQL + "                  ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblDosageForms  ";
                strSQL = strSQL + "                  ON tblItems.DosageFormGuid = tblDosageForms.TableRowGuid ";
                strSQL = strSQL + " 			INNER JOIN tblCustomers  ";
                strSQL = strSQL + "                  ON tblSalesReturns.CustomerGuid = tblCustomers.TableRowGuid  ";
                strSQL = strSQL + " Where tblSalesReturns.TableRowGuid = '" + CSalesReturns.GetTableRowGuid(intTransactionId) + "' ";
                strSQL = strSQL + " ) SalesReturns CROSS JOIN ";
                strSQL = strSQL + " (Select Grouping = '0' UNION Select Grouping = '1' UNION Select Grouping = '2') AS Groupings ";
                strSQL = strSQL + " ORDER BY Groupings.Grouping, SalesReturns.ItemDescription  ";

                dt = CCommon.GetRecords(strSQL);

                if (dt.Rows.Count > 0)
                {
                    if (CSalesReturns.GetSalesReturnStatus(CStoreTransactions.GetTableRowGuid(this.intTransactionId)) == 1)
                        rpt.SalesReturnIsVoid();
                    rpt.DataSource = dt;

                    rpt.Run(false);
                    frm = new frmReportViewerInvoice(rpt.Document);
                    frm.MdiParent = this.MdiParent;
                    frm.Text = "Sales Return Voucher";
                    frm.Show();
                }
                else
                    MessageBox.Show("No Record Found", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Invoice Code

        private void NewInvoice()
        {
            try
            {
                txtInvoiceCustomerName.Text = string.Empty;
                //txtInvoiceNumber.Tag = 0;
                //txtInvoiceNumber.Text = string.Empty;
                txtInvoiceDate.Text = string.Empty;
                cboInvoiceType.SelectedIndex = -1;
                this.txtDiscount.Text = string.Empty;
                lblDelivered.Visible = false;
                lblVoid.Visible = false;
                lvwInvoiceDetails.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInvoiceDetailsList()
        {
            try
            {

                CInvoiceDetails objInvoiceDetails = new CInvoiceDetails();

                ArrayList ar = new ArrayList(objInvoiceDetails.GetList());
                this.lvwInvoiceDetails.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CInvoiceDetails InvoiceDetails in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {InvoiceDetails.Id.ToString(), 
                                                                                      InvoiceDetails.Invoiceguid.ToString(), 
                                                                                      InvoiceDetails.Batchguid.ToString(), 
                                                                                      InvoiceDetails.Quantity.ToString()});
                    this.lvwInvoiceDetails.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillInvoiceDetailsListByParent(string Invoiceguid)
        {
            try
            {

                CInvoiceDetails objInvoiceDetails = new CInvoiceDetails();

                ArrayList ar = new ArrayList(objInvoiceDetails.GetList(Invoiceguid));
                this.lvwInvoiceDetails.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CInvoiceDetails InvoiceDetails in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {InvoiceDetails.Id.ToString(), 
                                                                      InvoiceDetails.Invoiceguid.ToString(), 
                                                                      InvoiceDetails.Batchguid.ToString(), 
                                                                      InvoiceDetails.BatchNumber.ToString(), 
                                                                      InvoiceDetails.ItemDescription.ToString(), 
                                                                      InvoiceDetails.UnitOfMeasurement.ToString(), 
                                                                      InvoiceDetails.Quantity.ToString(), 
                                                                      InvoiceDetails.SalePrice.ToString(), 
                                                                      (InvoiceDetails.Quantity * InvoiceDetails.SalePrice).ToString()});
                    this.lvwInvoiceDetails.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool FindInvoices(string Invoiceguid)
        {
            try
            {
                CInvoices objInvoices = new CInvoices();
                DataTable dt = new DataTable();

                objInvoices.Id = CInvoices.GetTableRowId(Invoiceguid);
                dt = objInvoices.GetRecord();
                if (dt.Rows.Count > 0)
                {
                    //InvoicesId = objInvoices.Id;
                    txtInvoiceCustomerName.Text = CCustomers.GetCustomerNameFromCollection(objInvoices.Customerguid);
                    txtInvoiceCustomerName.Tag = Convert.ToString(objInvoices.Customerguid);
                    //txtInvoiceNumber.Tag = objInvoices.Id;
                    txtInvoiceNumber.Text = Convert.ToString(objInvoices.Referencenumber);
                    txtInvoiceDate.Text = objInvoices.Invoicedate.ToString(CSettings.DateFormat);
                    cboInvoiceType.SelectedIndex = CCommon.GetIndexByItemData(cboInvoiceType, Convert.ToString(objInvoices.Invoicetype), true);
                    //txtInvoicesDuedate.Text = Convert.ToString(objInvoices.Duedate);
                    //txtInvoicesPreparedby.Text = Convert.ToString(objInvoices.Preparedby);
                    //txtInvoicesCheckedby.Text = Convert.ToString(objInvoices.Checkedby);
                    //txtInvoicesApprovedby.Text = Convert.ToString(objInvoices.Approvedby);
                    //txtInvoicesDeliveredby.Text = Convert.ToString(objInvoices.Deliveredby);
                    //txtInvoicesPrepareddate.Text = Convert.ToString(objInvoices.Prepareddate);
                    //txtInvoicesCheckeddate.Text = Convert.ToString(objInvoices.Checkeddate);
                    //txtInvoicesApprovaldate.Text = Convert.ToString(objInvoices.Approvaldate);
                    //txtInvoicesDeliverydate.Text = Convert.ToString(objInvoices.Deliverydate);
                    //txtInvoicesDeliverystatus.Text = Convert.ToString(objInvoices.Deliverystatus);
                    //txtInvoicesSuppliesrequisitionid.Text = Convert.ToString(objInvoices.Suppliesrequisitionid);
                    //txtInvoicesCashcollectionid.Text = Convert.ToString(objInvoices.Cashcollectionid);
                    txtDiscount.Text = Convert.ToString(objInvoices.Discount);

                    this.txtTransactionDate.Text = objInvoices.Invoicedate.ToString(CSettings.DateFormat);

                    int DeliveryStatus = objInvoices.Deliverystatus;
                    if (DeliveryStatus == (int)CCommon.DeliveryStatus.Pending)
                    {
                        this.lblDelivered.Visible = false;
                        this.lblVoid.Visible = false;
                    }
                    else if (DeliveryStatus == (int)CCommon.DeliveryStatus.Delivered)
                    {
                        this.lblDelivered.Visible = true;
                        this.lblVoid.Visible = false;
                    }
                    else if (DeliveryStatus == (int)CCommon.DeliveryStatus.Returned)
                    {
                        this.lblDelivered.Visible = false;
                        this.lblVoid.Visible = true;
                    }

                    return true;
                }
                else
                {
                    MessageBox.Show("Invoice record can not be found.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strCriteria = "";
                DateTime dteValidate;

                if (CustomerGuidSearch != string.Empty & txtCustomerName.Text != "")
                    strCriteria = strCriteria + " And CustomerGuid = '" + CustomerGuidSearch + "' ";
                if (txtTransactionDateFrom.Text != "")
                    if (DateTime.TryParseExact(txtTransactionDateFrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And SalesReturnDate >= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";

                if (txtTransactionDateTo.Text != "")
                    if (DateTime.TryParseExact(txtTransactionDateTo.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValidate))
                        strCriteria = strCriteria + " And SalesReturnDate <= Convert(datetime, '" + dteValidate.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
                FillTransactionList(strCriteria);
                NewTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                NewTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (SaveTransaction())
                {
                    SaveTransactionDetail();
                    MessageBox.Show("Data saved successfully", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwTransactions_Click(object sender, EventArgs e)
        {
            try
            {
                EditTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                EditTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }
        private void btnSaveDetail_Click(object sender, EventArgs e)
        {
            try
            {
                SaveTransactionDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillTransactionDetailGrid(string Transactionid)
        {

            try
            {

                CSalesReturnDetails objTranDetails = new CSalesReturnDetails();

                ArrayList ar = new ArrayList(objTranDetails.GetList(Transactionid));

                grvTransactionDetails.Rows.Clear();
                if (ar.Count <= 0) return;
                
                foreach (CSalesReturnDetails BatchItems in ar)
                {
                    grvTransactionDetails.Rows.Add(new string[] { BatchItems.Id.ToString(), 
                                                                    BatchItems.Batchguid.ToString(),
                                                                    BatchItems.Salesreturnguid.ToString(),                                        
                                                            BatchItems.BatchNumber.ToString(),
                                                            BatchItems.BrandName.ToString(),                                                            
                                                            BatchItems.Quantity.ToString(),                                                            
                                                            BatchItems.Unitprice.ToString(CSettings.CurrencyFormat),                                                            
                                                            (BatchItems.Quantity * BatchItems.Unitprice).ToString(CSettings.CurrencyFormat)
                    });


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteTransactionDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to delete the issuance record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CSalesReturnDetails objTranDetail = new CSalesReturnDetails();
                    CSalesReturns objTran = new CSalesReturns();
                    objTran.Id = intTransactionId;
                    objTranDetail.Salesreturnguid = CSalesReturns.GetTableRowGuid(intTransactionId);
                    if (!objTranDetail.CheckHasChildren())
                    {
                        objTran.Delete();
                        lvwTransactions.Items.Remove(lvwTransactions.SelectedItems[0]);
                        NewTransaction();
                    }
                    else
                        MessageBox.Show("The issuance record can not be deleted. Please delete the items first.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteTransactionDetail()
        {
            try
            {
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount; grRow++)
                {
                    if (grvTransactionDetails.SelectedRows.Contains(grvTransactionDetails.Rows[grRow]))
                    {
                        if (MessageBox.Show("Are you sure to delete the " + Convert.ToString(grRow + 1) + " row?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CSalesReturnDetails objTranDetail = new CSalesReturnDetails();
                            objTranDetail.Id = Convert.ToInt32(grvTransactionDetails.Rows[grRow].Cells["colId"].Value);
                            objTranDetail.Delete();
                            grvTransactionDetails.Rows[grRow].Visible = false;
                        }
                        //else
                        //    e.Cancel = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grvTransactionDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                DeleteTransactionDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
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
        private void btnGetBatchesFromInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceNumber.Text != "")
                    FillOrderBatchNumbersList(txtInvoiceNumber.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                frmSelectInvoice frmInvoice = new frmSelectInvoice();
                frmInvoice.ShowDialog();
                if (frmInvoice.bCancel == true) return;
                this.txtInvoiceNumber.Tag = frmInvoice.InvoiceGuid.ToString();
                this.txtInvoiceNumber.Text = frmInvoice.InvoiceReferenceNumber.ToString();

                this.NewInvoice();
                this.FindInvoices(this.txtInvoiceNumber.Tag.ToString());
                this.FillInvoiceDetailsListByParent(this.txtInvoiceNumber.Tag.ToString());

                if (txtInvoiceNumber.Text != "")
                    FillOrderBatchNumbersList(txtInvoiceNumber.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                ShowSalesReturn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal GetTotalAmount()
        {
            try
            {
                decimal decReturn = decimal.Zero;
                for (int grRow = 0; grRow < grvTransactionDetails.RowCount - 1; grRow++)
                {
                    decReturn = decReturn + Convert.ToDecimal(grvTransactionDetails.Rows[grRow].Cells["colTotalPrice"].Value);
                }
                return decReturn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return decimal.Zero;
            }
        }
        private void CalculateTotal()
        {
            try
            {
                decimal subtotal = 0;
                decimal discount = 0;
                decimal discountamount = 0;
                decimal decInvoiceTotal = 0;

                subtotal = GetTotalAmount();
                discount = Convert.ToDecimal("0" + this.txtDiscount.Text);
                discountamount = subtotal * discount / 100;
                decInvoiceTotal = subtotal - discountamount;

                txtSubTotal.Text = subtotal.ToString(CSettings.CurrencyFormat);
                txtDiscountAmount.Text = discountamount.ToString(CSettings.CurrencyFormat);
                txtTotalAmount.Text = decInvoiceTotal.ToString(CSettings.CurrencyFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CellEndEditTasks(DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGridViewTextBoxCell gvwTextBoxCell;
                string strQuantity = string.Empty;
                string strUnitPrice = string.Empty;

                if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
                {
                    strQuantity = grvTransactionDetails.Rows[e.RowIndex].Cells[5].Value.ToString();
                    strUnitPrice = grvTransactionDetails.Rows[e.RowIndex].Cells[6].Value.ToString();
                    grvTransactionDetails.Rows[e.RowIndex].Cells[7].Value = (Convert.ToDouble(strQuantity) * Convert.ToDouble(strUnitPrice)).ToString(CSettings.CurrencyFormat);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grvTransactionDetails_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CellEndEditTasks(e);
                CalculateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
