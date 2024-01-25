//
// ...
// Wizard generated code
// Date: 8/6/2009 10:36:05 AM
// Class: CInvoices
// ...
//

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;

namespace Pharma
{
    class CInvoices
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CInvoices()
        {
            _ConnectionString = ConnectionString;
        }
        public CInvoices(int Id, string Customerguid, string Licenseguid, string Referencenumber, string Attachmentreferencenumber, DateTime Invoicedate, int Invoicetype, DateTime Duedate, string Preparedby, string Checkedby, string Approvedby, string Deliveredby, DateTime Prepareddate, DateTime Checkeddate, DateTime Approvaldate, DateTime Deliverydate, int Deliverystatus, string Suppliesrequisitionguid, string Cashcollectionguid, decimal Discount)
        {
            _Id = Id;
            _CustomerGuid = Customerguid;
            _LicenseGuid = Licenseguid;
            _ReferenceNumber = Referencenumber;
            _AttachmentReferenceNumber = Attachmentreferencenumber;
            _InvoiceDate = Invoicedate;
            _InvoiceType = Invoicetype;
            _DueDate = Duedate;
            _PreparedBy = Preparedby;
            _CheckedBy = Checkedby;
            _ApprovedBy = Approvedby;
            _DeliveredBy = Deliveredby;
            _PreparedDate = Prepareddate;
            _CheckedDate = Checkeddate;
            _ApprovalDate = Approvaldate;
            _DeliveryDate = Deliverydate;
            _DeliveryStatus = Deliverystatus;
            _SuppliesRequisitionGuid = Suppliesrequisitionguid;
            _CashCollectionGuid = Cashcollectionguid;
            _Discount = Discount;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _CustomerGuid;
        public string Customerguid
        {
            get { return _CustomerGuid; }
            set { _CustomerGuid = value; }
        }

        string _LicenseGuid;
        public string Licenseguid
        {
            get { return _LicenseGuid; }
            set { _LicenseGuid = value; }
        }

        string _ReferenceNumber;
        public string Referencenumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        string _AttachmentReferenceNumber;
        public string Attachmentreferencenumber
        {
            get { return _AttachmentReferenceNumber; }
            set { _AttachmentReferenceNumber = value; }
        }

        DateTime _InvoiceDate;
        public DateTime Invoicedate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
        }

        int _InvoiceType;
        public int Invoicetype
        {
            get { return _InvoiceType; }
            set { _InvoiceType = value; }
        }

        DateTime _DueDate;
        public DateTime Duedate
        {
            get { return _DueDate; }
            set { _DueDate = value; }
        }

        string _PreparedBy;
        public string Preparedby
        {
            get { return _PreparedBy; }
            set { _PreparedBy = value; }
        }

        string _CheckedBy;
        public string Checkedby
        {
            get { return _CheckedBy; }
            set { _CheckedBy = value; }
        }

        string _ApprovedBy;
        public string Approvedby
        {
            get { return _ApprovedBy; }
            set { _ApprovedBy = value; }
        }

        string _DeliveredBy;
        public string Deliveredby
        {
            get { return _DeliveredBy; }
            set { _DeliveredBy = value; }
        }

        DateTime _PreparedDate;
        public DateTime Prepareddate
        {
            get { return _PreparedDate; }
            set { _PreparedDate = value; }
        }

        DateTime _CheckedDate;
        public DateTime Checkeddate
        {
            get { return _CheckedDate; }
            set { _CheckedDate = value; }
        }

        DateTime _ApprovalDate;
        public DateTime Approvaldate
        {
            get { return _ApprovalDate; }
            set { _ApprovalDate = value; }
        }

        DateTime _DeliveryDate;
        public DateTime Deliverydate
        {
            get { return _DeliveryDate; }
            set { _DeliveryDate = value; }
        }

        int _DeliveryStatus;
        public int Deliverystatus
        {
            get { return _DeliveryStatus; }
            set { _DeliveryStatus = value; }
        }

        string _SuppliesRequisitionGuid;
        public string Suppliesrequisitionguid
        {
            get { return _SuppliesRequisitionGuid; }
            set { _SuppliesRequisitionGuid = value; }
        }

        string _CashCollectionGuid;
        public string Cashcollectionguid
        {
            get { return _CashCollectionGuid; }
            set { _CashCollectionGuid = value; }
        }

        string _ReturnedReason;
        public string ReturnedReason
        {
            get { return _ReturnedReason; }
            set { _ReturnedReason = value; }
        }

        DateTime _ReturnedDate;
        public DateTime ReturnedDate
        {
            get { return _ReturnedDate; }
            set { _ReturnedDate = value; }
        }

        string _OrganizationName;
        public string OrganizationName
        {
            get { return _OrganizationName; }
            set { _OrganizationName = value; }
        }

        string _SellableBatchGuid;
        public string Sellablebatchguid
        {
            get { return _SellableBatchGuid; }
            set { _SellableBatchGuid = value; }
        }

        decimal _Discount;
        public decimal Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        string _SellableBatchName;
        public string SellableBatchName
        {
            get { return _SellableBatchName; }
            set { _SellableBatchName = value; }
        }

        decimal _BatchQty;
        public decimal BatchQty
        {
            get { return _BatchQty; }
            set { _BatchQty = value; }
        }

        decimal _BatchBalanceQty;
        public decimal BatchBalaceQty
        {
            get { return _BatchBalanceQty;}
            set { _BatchBalanceQty = value;}
        }

        string _ItemGuid;
        public string Itemguid
        {
            get { return _ItemGuid; }
            set { _ItemGuid = value; }
        }

        string _BrandName;
        public string BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        string _Unit;
        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        decimal _ApprovedQuantity;
        public decimal ApprovedQuantity
        {
            get { return _ApprovedQuantity; }
            set { _ApprovedQuantity = value; }
        }

        decimal _UnitPrice;
        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        decimal _SalePrice;
        public decimal SalePrice
        {
            get { return _SalePrice; }
            set { _SalePrice = value; }
        }

        decimal _TotalPrice;
        public decimal TotalPrice
        {
            get { return _TotalPrice; }
            set { _TotalPrice = value; }
        }

        int _InvoiceDetailId;
        public int Invoicedetailid
        {
            get { return _InvoiceDetailId; }
            set { _InvoiceDetailId = value; }
        }

        string _InvoiceDetailGuid;
        public string Invoicedetailguid
        {
            get { return _InvoiceDetailGuid; }
            set { _InvoiceDetailGuid = value; }
        }

        decimal _QuantityRequiredFromNextBatch;
        public decimal QuantityRequiredFromNextBatch
        {
            get { return _QuantityRequiredFromNextBatch; }
            set { _QuantityRequiredFromNextBatch = value; }
        }

        decimal _SellableBatchRemainingQuantity;
        public decimal SellableBatchRemainingQuantity
        {
            get { return _SellableBatchRemainingQuantity; }
            set { _SellableBatchRemainingQuantity = value; }
        }

        string _ReferenceNumberPsychotropic;
        public string ReferenceNumberPsychotropic
        {
            get { return _ReferenceNumberPsychotropic; }
            set { _ReferenceNumberPsychotropic = value; }
        }

        string _ReferenceNumberCash;
        public string ReferenceNumberCash
        {
            get { return _ReferenceNumberCash; }
            set { _ReferenceNumberCash = value; }
        }

        string _ReferenceNumberCredit;
        public string ReferenceNumberCredit
        {
            get { return _ReferenceNumberCredit; }
            set { _ReferenceNumberCredit = value; }
        }

        string _ReferenceNumberFreeOfCharge;
        public string ReferenceNumberFreeOfCharge
        {
            get { return _ReferenceNumberFreeOfCharge; }
            set { _ReferenceNumberFreeOfCharge = value; }
        }

        bool _IsAttachmentNumberGenerated;
        public bool AttachmentNumberGenerated
        {
            set { _IsAttachmentNumberGenerated = value; }
        }

        bool _IsVATApplicable;
        public bool IsVATApplicable
        {
            get { return _IsVATApplicable; }
            set { _IsVATApplicable = value; }
        
        }

        decimal _VAT;
        public decimal VAT
        {
            get { return _VAT; }
            set { _VAT = value; }
        }

        string _TableRowGuid;
        public string Tablerowguid
        {
            get { return _TableRowGuid; }
            set { _TableRowGuid = value; }
        }

        #endregion

        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblInvoices where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblInvoices");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Id", _Id));
                connection.Open();
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    _Id = (int)dTable.Rows[0]["Id"];
                    if (dTable.Rows[0]["CustomerGuid"].Equals(DBNull.Value))
                        _CustomerGuid = string.Empty;
                    else
                        _CustomerGuid = (string)dTable.Rows[0]["CustomerGuid"];
                    if (dTable.Rows[0]["LicenseGuid"].Equals(DBNull.Value))
                        _LicenseGuid = string.Empty;
                    else
                        _LicenseGuid = (string)dTable.Rows[0]["LicenseGuid"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["AttachmentReferenceNumber"].Equals(DBNull.Value))
                        _AttachmentReferenceNumber = string.Empty;
                    else
                        _AttachmentReferenceNumber = (string)dTable.Rows[0]["AttachmentReferenceNumber"];
                    if (dTable.Rows[0]["InvoiceDate"].Equals(DBNull.Value))
                        _InvoiceDate = DateTime.MinValue;
                    else
                        _InvoiceDate = (DateTime)dTable.Rows[0]["InvoiceDate"];
                    if (dTable.Rows[0]["InvoiceType"].Equals(DBNull.Value))
                        _InvoiceType = 0;
                    else
                        _InvoiceType = (int)dTable.Rows[0]["InvoiceType"];
                    if (dTable.Rows[0]["DueDate"].Equals(DBNull.Value))
                        _DueDate = DateTime.MinValue;
                    else
                        _DueDate = (DateTime)dTable.Rows[0]["DueDate"];
                    if (dTable.Rows[0]["PreparedBy"].Equals(DBNull.Value))
                        _PreparedBy = string.Empty;
                    else
                        _PreparedBy = (string)dTable.Rows[0]["PreparedBy"];
                    if (dTable.Rows[0]["CheckedBy"].Equals(DBNull.Value))
                        _CheckedBy = string.Empty;
                    else
                        _CheckedBy = (string)dTable.Rows[0]["CheckedBy"];
                    if (dTable.Rows[0]["ApprovedBy"].Equals(DBNull.Value))
                        _ApprovedBy = string.Empty;
                    else
                        _ApprovedBy = (string)dTable.Rows[0]["ApprovedBy"];
                    if (dTable.Rows[0]["DeliveredBy"].Equals(DBNull.Value))
                        _DeliveredBy = string.Empty;
                    else
                        _DeliveredBy = (string)dTable.Rows[0]["DeliveredBy"];
                    if (dTable.Rows[0]["PreparedDate"].Equals(DBNull.Value))
                        _PreparedDate = DateTime.MinValue;
                    else
                        _PreparedDate = (DateTime)dTable.Rows[0]["PreparedDate"];
                    if (dTable.Rows[0]["CheckedDate"].Equals(DBNull.Value))
                        _CheckedDate = DateTime.MinValue;
                    else
                        _CheckedDate = (DateTime)dTable.Rows[0]["CheckedDate"];
                    if (dTable.Rows[0]["ApprovalDate"].Equals(DBNull.Value))
                        _ApprovalDate = DateTime.MinValue;
                    else
                        _ApprovalDate = (DateTime)dTable.Rows[0]["ApprovalDate"];
                    if (dTable.Rows[0]["DeliveryDate"].Equals(DBNull.Value))
                        _DeliveryDate = DateTime.MinValue;
                    else
                        _DeliveryDate = (DateTime)dTable.Rows[0]["DeliveryDate"];
                    if (dTable.Rows[0]["DeliveryStatus"].Equals(DBNull.Value))
                        _DeliveryStatus = 0;
                    else
                        _DeliveryStatus = (int)dTable.Rows[0]["DeliveryStatus"];
                    if (dTable.Rows[0]["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        _SuppliesRequisitionGuid = string.Empty;
                    else
                        _SuppliesRequisitionGuid = (string)dTable.Rows[0]["SuppliesRequisitionGuid"];
                    if (dTable.Rows[0]["CashCollectionGuid"].Equals(DBNull.Value))
                        _CashCollectionGuid = string.Empty;
                    else
                        _CashCollectionGuid = (string)dTable.Rows[0]["CashCollectionGuid"];
                    if (dTable.Rows[0]["Discount"].Equals(DBNull.Value))
                        _Discount = 0;
                    else
                        _Discount = (decimal)dTable.Rows[0]["Discount"];
                    if (dTable.Rows[0]["VAT"].Equals(DBNull.Value))
                        _VAT = 0;
                    else
                        _VAT = (decimal)dTable.Rows[0]["VAT"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecord(string Suppliesrequisitionguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblInvoices where SuppliesRequisitionGuid=@SuppliesRequisitionGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblInvoices");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", Suppliesrequisitionguid));
                connection.Open();
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    _Id = (int)dTable.Rows[0]["Id"];
                    if (dTable.Rows[0]["CustomerGuid"].Equals(DBNull.Value))
                        _CustomerGuid = string.Empty;
                    else
                        _CustomerGuid = (string)dTable.Rows[0]["CustomerGuid"];
                    if (dTable.Rows[0]["LicenseGuid"].Equals(DBNull.Value))
                        _LicenseGuid = string.Empty;
                    else
                        _LicenseGuid = (string)dTable.Rows[0]["LicenseGuid"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["AttachmentReferenceNumber"].Equals(DBNull.Value))
                        _AttachmentReferenceNumber = string.Empty;
                    else
                        _AttachmentReferenceNumber = (string)dTable.Rows[0]["AttachmentReferenceNumber"];
                    if (dTable.Rows[0]["InvoiceDate"].Equals(DBNull.Value))
                        _InvoiceDate = DateTime.MinValue;
                    else
                        _InvoiceDate = (DateTime)dTable.Rows[0]["InvoiceDate"];
                    if (dTable.Rows[0]["InvoiceType"].Equals(DBNull.Value))
                        _InvoiceType = 0;
                    else
                        _InvoiceType = (int)dTable.Rows[0]["InvoiceType"];
                    if (dTable.Rows[0]["DueDate"].Equals(DBNull.Value))
                        _DueDate = DateTime.MinValue;
                    else
                        _DueDate = (DateTime)dTable.Rows[0]["DueDate"];
                    if (dTable.Rows[0]["PreparedBy"].Equals(DBNull.Value))
                        _PreparedBy = string.Empty;
                    else
                        _PreparedBy = (string)dTable.Rows[0]["PreparedBy"];
                    if (dTable.Rows[0]["CheckedBy"].Equals(DBNull.Value))
                        _CheckedBy = string.Empty;
                    else
                        _CheckedBy = (string)dTable.Rows[0]["CheckedBy"];
                    if (dTable.Rows[0]["ApprovedBy"].Equals(DBNull.Value))
                        _ApprovedBy = string.Empty;
                    else
                        _ApprovedBy = (string)dTable.Rows[0]["ApprovedBy"];
                    if (dTable.Rows[0]["DeliveredBy"].Equals(DBNull.Value))
                        _DeliveredBy = string.Empty;
                    else
                        _DeliveredBy = (string)dTable.Rows[0]["DeliveredBy"];
                    if (dTable.Rows[0]["PreparedDate"].Equals(DBNull.Value))
                        _PreparedDate = DateTime.MinValue;
                    else
                        _PreparedDate = (DateTime)dTable.Rows[0]["PreparedDate"];
                    if (dTable.Rows[0]["CheckedDate"].Equals(DBNull.Value))
                        _CheckedDate = DateTime.MinValue;
                    else
                        _CheckedDate = (DateTime)dTable.Rows[0]["CheckedDate"];
                    if (dTable.Rows[0]["ApprovalDate"].Equals(DBNull.Value))
                        _ApprovalDate = DateTime.MinValue;
                    else
                        _ApprovalDate = (DateTime)dTable.Rows[0]["ApprovalDate"];
                    if (dTable.Rows[0]["DeliveryDate"].Equals(DBNull.Value))
                        _DeliveryDate = DateTime.MinValue;
                    else
                        _DeliveryDate = (DateTime)dTable.Rows[0]["DeliveryDate"];
                    if (dTable.Rows[0]["DeliveryStatus"].Equals(DBNull.Value))
                        _DeliveryStatus = 0;
                    else
                        _DeliveryStatus = (int)dTable.Rows[0]["DeliveryStatus"];
                    if (dTable.Rows[0]["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        _SuppliesRequisitionGuid = string.Empty;
                    else
                        _SuppliesRequisitionGuid = (string)dTable.Rows[0]["SuppliesRequisitionGuid"];
                    if (dTable.Rows[0]["CashCollectionGuid"].Equals(DBNull.Value))
                        _CashCollectionGuid = string.Empty;
                    else
                        _CashCollectionGuid = (string)dTable.Rows[0]["CashCollectionGuid"];
                    if (dTable.Rows[0]["Discount"].Equals(DBNull.Value))
                        _Discount = 0;
                    else
                        _Discount = (decimal)dTable.Rows[0]["Discount"];
                    if (dTable.Rows[0]["VAT"].Equals(DBNull.Value))
                        _VAT = 0;
                    else
                        _VAT = (decimal)dTable.Rows[0]["VAT"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblInvoices";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblInvoices");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }

        public bool Insert()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Insert Into tblInvoices (CustomerGuid, LicenseGuid, ReferenceNumber, AttachmentReferenceNumber,InvoiceDate,InvoiceType, ";
            if (_InvoiceType == (int)CCommon.InvoiceType.CreditSales)
                strSQL = strSQL +  " DueDate, ";
                strSQL = strSQL +  " PreparedBy, " +
                                   " CheckedBy, " +
                                   " ApprovedBy, " +                                  
                                   " PreparedDate, " +
                                   " CheckedDate, " +
                                   " ApprovalDate, " +                                   
                                   " DeliveryStatus, " +
                                   " SuppliesRequisitionGuid, " +
                                   " Discount, " +
                                   " VAT, " +
                                   " ReferenceNumberPsychotropic, " +
                                   " ReferenceNumberCash, " +
                                   " ReferenceNumberCredit, " +
                                   " ReferenceNumberFreeOfCharge)" +
                                   " Values (@CustomerGuid, " +
                                   " @LicenseGuid, " +
                                   " @ReferenceNumber, " +
                                   " @AttachmentReferenceNumber, " +
                                   " @InvoiceDate, " +
                                   " @InvoiceType, ";
            if (_InvoiceType == (int)CCommon.InvoiceType.CreditSales)
                    strSQL = strSQL + " @DueDate, ";
                    strSQL = strSQL + " @PreparedBy, " +
                                      " @CheckedBy, " +
                                      " @ApprovedBy, " +                                     
                                      " @PreparedDate, " +
                                      " @CheckedDate, " +
                                      " @ApprovalDate, " + 
                                      " @DeliveryStatus, "+
                                      " @SuppliesRequisitionGuid, " +
                                      " @Discount, " +
                                      " @VAT, " +
                                      " @ReferenceNumberPsychotropic, " +
                                      " @ReferenceNumberCash, " +
                                      " @ReferenceNumberCredit, " +
                                      " @ReferenceNumberFreeOfCharge)" +
                                      " SELECT @Id=Max(id) From tblInvoices ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@LicenseGuid", _LicenseGuid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@AttachmentReferenceNumber", _AttachmentReferenceNumber));
                if (_InvoiceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", _InvoiceDate));
                command.Parameters.Add(new SqlParameter("@InvoiceType", _InvoiceType));
                if (_InvoiceType == (int)CCommon.InvoiceType.CreditSales)
                    if (_DueDate == DateTime.MinValue)
                        command.Parameters.Add(new SqlParameter("@DueDate", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@DueDate", _DueDate));
                command.Parameters.Add(new SqlParameter("@PreparedBy", _PreparedBy));
                command.Parameters.Add(new SqlParameter("@CheckedBy", _CheckedBy));
                command.Parameters.Add(new SqlParameter("@ApprovedBy", _ApprovedBy));
                if (_PreparedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PreparedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PreparedDate", _PreparedDate));
                if (_CheckedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckedDate", _CheckedDate));
                if (_ApprovalDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", _ApprovalDate));
                command.Parameters.Add(new SqlParameter("@DeliveryStatus", _DeliveryStatus));
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                command.Parameters.Add(new SqlParameter("@Discount", _Discount));
                command.Parameters.Add(new SqlParameter("@VAT", _VAT));
                if (_IsAttachmentNumberGenerated)
                {
                    if (_ReferenceNumberPsychotropic == string.Empty)
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberPsychotropic", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberPsychotropic", _ReferenceNumberPsychotropic));
                    if (_ReferenceNumberCash == string.Empty)
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberCash", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberCash", _ReferenceNumberCash));
                    if (_ReferenceNumberCredit == string.Empty)
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberCredit", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberCredit", _ReferenceNumberCredit));
                    if (_ReferenceNumberFreeOfCharge == string.Empty)
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberFreeOfCharge", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberFreeOfCharge", _ReferenceNumberFreeOfCharge));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberPsychotropic", DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCash", DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCredit", DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberFreeOfCharge", DBNull.Value));
                }
                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblInvoices" +
                                   " Set CustomerGuid = @CustomerGuid, " +
                                   " LicenseGuid = @LicenseGuid, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " AttachmentReferenceNumber = @AttachmentReferenceNumber, " +
                                   " InvoiceDate = @InvoiceDate, " +
                                   " InvoiceType = @InvoiceType, ";
            if (_InvoiceType == (int)CCommon.InvoiceType.CreditSales)
                command.CommandText += " DueDate = @DueDate, ";
         command.CommandText += " PreparedBy = @PreparedBy, " +
                                   " CheckedBy = @CheckedBy, " +
                                   " ApprovedBy = @ApprovedBy, " +                                  
                                   " PreparedDate = @PreparedDate, " +
                                   " CheckedDate = @CheckedDate, " +
                                   " ApprovalDate = @ApprovalDate, " +                                   
                                   " DeliveryStatus = @DeliveryStatus, " +
                                   " SuppliesRequisitionGuid = @SuppliesRequisitionGuid, " +
                                   " Discount = @Discount, " +
                                   " VAT = @VAT, ";
             if (_IsAttachmentNumberGenerated)
             {
                 command.CommandText += " ReferenceNumberPsychotropic = @ReferenceNumberPsychotropic, " +
                                 " ReferenceNumberCash = @ReferenceNumberCash, " +
                                 " ReferenceNumberCredit = @ReferenceNumberCredit, " +
                                 " ReferenceNumberFreeOfCharge = @ReferenceNumberFreeOfCharge ";
             }
             else
             {
                 command.CommandText += " ReferenceNumberPsychotropic = ReferenceNumberPsychotropic, " +
                                 " ReferenceNumberCash = ReferenceNumberCash, " +
                                 " ReferenceNumberCredit = ReferenceNumberCredit, " +
                                 " ReferenceNumberFreeOfCharge = ReferenceNumberFreeOfCharge ";
             }

            command.CommandText += "  Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@LicenseGuid", _LicenseGuid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@AttachmentReferenceNumber", _AttachmentReferenceNumber));
                if (_InvoiceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", _InvoiceDate));
                command.Parameters.Add(new SqlParameter("@InvoiceType", _InvoiceType));
                if (_InvoiceType == (int)CCommon.InvoiceType.CreditSales)
                    if (_DueDate == DateTime.MinValue)
                        command.Parameters.Add(new SqlParameter("@DueDate", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@DueDate", _DueDate));
                command.Parameters.Add(new SqlParameter("@PreparedBy", _PreparedBy));
                command.Parameters.Add(new SqlParameter("@CheckedBy", _CheckedBy));
                command.Parameters.Add(new SqlParameter("@ApprovedBy", _ApprovedBy));
                if (_PreparedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PreparedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PreparedDate", _PreparedDate));
                if (_CheckedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckedDate", _CheckedDate));
                if (_ApprovalDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", _ApprovalDate));               
                command.Parameters.Add(new SqlParameter("@DeliveryStatus", _DeliveryStatus));
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                command.Parameters.Add(new SqlParameter("@Discount", _Discount));
                command.Parameters.Add(new SqlParameter("@VAT", _VAT));
                if (_IsAttachmentNumberGenerated)
                {
                    if (_ReferenceNumberPsychotropic == string.Empty)
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberPsychotropic", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberPsychotropic", _ReferenceNumberPsychotropic));
                    if (_ReferenceNumberCash == string.Empty)
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberCash", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberCash", _ReferenceNumberCash));
                    if (_ReferenceNumberCredit == string.Empty)
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberCredit", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberCredit", _ReferenceNumberCredit));
                    if (_ReferenceNumberFreeOfCharge == string.Empty)
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberFreeOfCharge", DBNull.Value));
                    else
                        command.Parameters.Add(new SqlParameter("@ReferenceNumberFreeOfCharge", _ReferenceNumberFreeOfCharge));
                }
               
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool UpdateDelivered()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText =  " Update tblInvoices" +
                                   " Set DeliveredBy = @DeliveredBy, " +
                                   " DeliveryStatus = @DeliveryStatus, " +
                                   " DeliveryDate = @DeliveryDate " +                               
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                command.Parameters.Add(new SqlParameter("@DeliveredBy", _DeliveredBy));
                if (_DeliveryDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", _DeliveryDate));
                command.Parameters.Add(new SqlParameter("@DeliveryStatus", _DeliveryStatus));
                command.Parameters.Add(new SqlParameter("@Id", _Id));
                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::UpdateDelivered::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool UpdateReturned()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText =  " Update tblInvoices" +
                                   " Set ReturnedReason = @ReturnedReason, " +
                                   " DeliveryStatus = @DeliveryStatus, " +
                                   " ReturnedDate = @ReturnedDate " +                               
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                command.Parameters.Add(new SqlParameter("@ReturnedReason", _ReturnedReason));
                if (_ReturnedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ReturnedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ReturnedDate", _ReturnedDate));
                command.Parameters.Add(new SqlParameter("@DeliveryStatus", _DeliveryStatus));
                command.Parameters.Add(new SqlParameter("@Id", _Id));
                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::UpdateReturned::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Delete()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblInvoices Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblInvoices] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber " +
                                       " AND SuppliesRequisitionGuid = @SuppliesRequisitionGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblInvoices] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber " +
                                       " AND SuppliesRequisitionGuid = @SuppliesRequisitionGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {              
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                if (!bNew)
                    command.Parameters.Add(new SqlParameter("@Id", _Id));
                connection.Open();
                temp = command.ExecuteScalar();
                if (temp != null)
                    return (int)temp;
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Customerguid, string Licenseguid, string Referencenumber, string AttachmentReferencenumber, DateTime Invoicedate, int Invoicetype, DateTime Duedate, string Preparedby, string Checkedby, string Approvedby, string Deliveredby, DateTime Prepareddate, DateTime Checkeddate, DateTime Approvaldate, DateTime Deliverydate, int Deliverystatus, string Suppliesrequisitionguid, string Cashcollectionguid, decimal Discount)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblInvoices" +
                                   " (CustomerGuid, " +
                                   " LicenseGuid, " +
                                   " ReferenceNumber, " +
                                   " AttachmentReferenceNumber, " +
                                   " InvoiceDate, " +
                                   " InvoiceType, " +
                                   " DueDate, " +
                                   " PreparedBy, " +
                                   " CheckedBy, " +
                                   " ApprovedBy, " +
                                   " DeliveredBy, " +
                                   " PreparedDate, " +
                                   " CheckedDate, " +
                                   " ApprovalDate, " +
                                   " DeliveryDate, " +
                                   " DeliveryStatus, " +
                                   " SuppliesRequisitionGuid, " +
                                   " CashCollectionGuid, " +
                                   " Discount, " +
                                   " ReferenceNumberPsychotropic, " +
                                   " ReferenceNumberCash, " +
                                   " ReferenceNumberCredit, " +
                                   " ReferenceNumberFreeOfCharge)" +
                                   " Values (@CustomerGuid, " +
                                   " @LicenseGuid, " +
                                   " @ReferenceNumber, " +
                                   " @AttachmentReferenceNumber, " +
                                   " @InvoiceDate, " +
                                   " @InvoiceType, " +
                                   " @DueDate, " +
                                   " @PreparedBy, " +
                                   " @CheckedBy, " +
                                   " @ApprovedBy, " +
                                   " @DeliveredBy, " +
                                   " @PreparedDate, " +
                                   " @CheckedDate, " +
                                   " @ApprovalDate, " +
                                   " @DeliveryDate, " +
                                   " @DeliveryStatus, " +
                                   " @SuppliesRequisitionGuid, " +
                                   " @CashCollectionGuid, " +
                                   " @Discount, " +
                                   " @ReferenceNumberPsychotropic, " +
                                   " @ReferenceNumberCash, " +
                                   " @ReferenceNumberCredit, " +
                                   " @ReferenceNumberFreeOfCharge)" +
                                   " SELECT @Id=Max(id) From tblInvoices ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                command.Parameters.Add(new SqlParameter("@LicenseGuid", Licenseguid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@AttachmentReferenceNumber", AttachmentReferencenumber));
                if (Invoicedate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", Invoicedate));
                command.Parameters.Add(new SqlParameter("@InvoiceType", Invoicetype));
                command.Parameters.Add(new SqlParameter("@DueDate", Duedate));
                command.Parameters.Add(new SqlParameter("@PreparedBy", Preparedby));
                command.Parameters.Add(new SqlParameter("@CheckedBy", Checkedby));
                command.Parameters.Add(new SqlParameter("@ApprovedBy", Approvedby));
                command.Parameters.Add(new SqlParameter("@DeliveredBy", Deliveredby));
                if (Prepareddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PreparedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PreparedDate", Prepareddate));
                if (Checkeddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckedDate", Checkeddate));
                if (Approvaldate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", Approvaldate));
                if (Deliverydate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", Deliverydate));
                command.Parameters.Add(new SqlParameter("@DeliveryStatus", Deliverystatus));
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", Suppliesrequisitionguid));
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                command.Parameters.Add(new SqlParameter("@Discount", Discount));

                if (_ReferenceNumberPsychotropic == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberPsychotropic", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberPsychotropic", _ReferenceNumberPsychotropic));
                if (_ReferenceNumberCash == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCash", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCash", _ReferenceNumberCash));
                if (_ReferenceNumberCredit == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCredit", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCredit", _ReferenceNumberCredit));
                if (_ReferenceNumberFreeOfCharge == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberFreeOfCharge", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberFreeOfCharge", _ReferenceNumberFreeOfCharge));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Customerguid, string Licenseguid, string Referencenumber, string AttachmentReferencenumber, DateTime Invoicedate, int Invoicetype, DateTime Duedate, string Preparedby, string Checkedby, string Approvedby, string Deliveredby, DateTime Prepareddate, DateTime Checkeddate, DateTime Approvaldate, DateTime Deliverydate, int Deliverystatus, string Suppliesrequisitionguid, string Cashcollectionguid, decimal Discount)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblInvoices" +
                                   " Set CustomerGuid = @CustomerGuid, " +
                                   " LicenseGuid = @LicenseGuid, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " AttachmentReferenceNumber = @AttachmentReferenceNumber, " +
                                   " InvoiceDate = @InvoiceDate, " +
                                   " InvoiceType = @InvoiceType, " +
                                   " DueDate = @DueDate, " +
                                   " PreparedBy = @PreparedBy, " +
                                   " CheckedBy = @CheckedBy, " +
                                   " ApprovedBy = @ApprovedBy, " +
                                   " DeliveredBy = @DeliveredBy, " +
                                   " PreparedDate = @PreparedDate, " +
                                   " CheckedDate = @CheckedDate, " +
                                   " ApprovalDate = @ApprovalDate, " +
                                   " DeliveryDate = @DeliveryDate, " +
                                   " DeliveryStatus = @DeliveryStatus, " +
                                   " SuppliesRequisitionId = @SuppliesRequisitionGuid, " +
                                   " CashCollectionGuid = @CashCollectionGuid, " +
                                   " Discount = @Discount, " +
                                   " ReferenceNumberPsychotropic = @ReferenceNumberPsychotropic, " +
                                   " ReferenceNumberCash = @ReferenceNumberCash, " +
                                   " ReferenceNumberCredit = @ReferenceNumberCredit, " +
                                   " ReferenceNumberFreeOfCharge = @ReferenceNumberFreeOfCharge " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                command.Parameters.Add(new SqlParameter("@LicenseGuid", Licenseguid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@AttachmentReferenceNumber", AttachmentReferencenumber));
                if (Invoicedate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", Invoicedate));
                command.Parameters.Add(new SqlParameter("@InvoiceType", Invoicetype));
                command.Parameters.Add(new SqlParameter("@DueDate", Duedate));
                command.Parameters.Add(new SqlParameter("@PreparedBy", Preparedby));
                command.Parameters.Add(new SqlParameter("@CheckedBy", Checkedby));
                command.Parameters.Add(new SqlParameter("@ApprovedBy", Approvedby));
                command.Parameters.Add(new SqlParameter("@DeliveredBy", Deliveredby));
                if (Prepareddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PreparedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PreparedDate", Prepareddate));
                if (Checkeddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckedDate", Checkeddate));
                if (Approvaldate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", Approvaldate));
                if (Deliverydate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", Deliverydate));
                command.Parameters.Add(new SqlParameter("@DeliveryStatus", Deliverystatus));
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", Suppliesrequisitionguid));
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                command.Parameters.Add(new SqlParameter("@Discount", Discount));

                if (_ReferenceNumberPsychotropic == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberPsychotropic", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberPsychotropic", _ReferenceNumberPsychotropic));
                if (_ReferenceNumberCash == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCash", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCash", _ReferenceNumberCash));
                if (_ReferenceNumberCredit == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCredit", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberCredit", _ReferenceNumberCredit));
                if (_ReferenceNumberFreeOfCharge == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberFreeOfCharge", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ReferenceNumberFreeOfCharge", _ReferenceNumberFreeOfCharge));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Delete(int Id)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblInvoices Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Referencenumber, string Suppliesrequisitionguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblInvoices] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber " +
                                       " AND SuppliesRequisitionGuid = @SuppliesRequisitionGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblInvoices] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber " +
                                       " AND SuppliesRequisitionGuid = @SuppliesRequisitionGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", Suppliesrequisitionguid));
                if (!bNew)
                    command.Parameters.Add(new SqlParameter("@Id", _Id));
                connection.Open();
                temp = command.ExecuteScalar();
                if (temp != null)
                    return (int)temp;
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CInvoices> GetList(bool NotIssued)
        {
            List<CInvoices> RecordsList = new List<CInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblInvoices";
            if (NotIssued)
                command.CommandText += " Where tblInvoices.TableRowGuid not in (select distinct ISNULL(InvoiceGuid,'') from tblStoreTransactions) ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoices objCInvoices = new CInvoices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCInvoices.Id = 0;
                    else
                        objCInvoices.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCInvoices.Customerguid = string.Empty;
                    else
                        objCInvoices.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCInvoices.Licenseguid = string.Empty;
                    else
                        objCInvoices.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Referencenumber = string.Empty;
                    else
                        objCInvoices.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["AttachmentReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Attachmentreferencenumber = string.Empty;
                    else
                        objCInvoices.Attachmentreferencenumber = (string)dr["AttachmentReferenceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCInvoices.Invoicedate = DateTime.MinValue;
                    else
                        objCInvoices.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceType"].Equals(DBNull.Value))
                        objCInvoices.Invoicetype = 0;
                    else
                        objCInvoices.Invoicetype = (int)dr["InvoiceType"];
                    if (dr["DueDate"].Equals(DBNull.Value))
                        objCInvoices.Duedate = DateTime.MinValue;
                    else
                        objCInvoices.Duedate = (DateTime)dr["DueDate"];
                    if (dr["PreparedBy"].Equals(DBNull.Value))
                        objCInvoices.Preparedby = string.Empty;
                    else
                        objCInvoices.Preparedby = (string)dr["PreparedBy"];
                    if (dr["CheckedBy"].Equals(DBNull.Value))
                        objCInvoices.Checkedby = string.Empty;
                    else
                        objCInvoices.Checkedby = (string)dr["CheckedBy"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCInvoices.Approvedby = string.Empty;
                    else
                        objCInvoices.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["DeliveredBy"].Equals(DBNull.Value))
                        objCInvoices.Deliveredby = string.Empty;
                    else
                        objCInvoices.Deliveredby = (string)dr["DeliveredBy"];
                    if (dr["PreparedDate"].Equals(DBNull.Value))
                        objCInvoices.Prepareddate = DateTime.MinValue;
                    else
                        objCInvoices.Prepareddate = (DateTime)dr["PreparedDate"];
                    if (dr["CheckedDate"].Equals(DBNull.Value))
                        objCInvoices.Checkeddate = DateTime.MinValue;
                    else
                        objCInvoices.Checkeddate = (DateTime)dr["CheckedDate"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCInvoices.Approvaldate = DateTime.MinValue;
                    else
                        objCInvoices.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["DeliveryDate"].Equals(DBNull.Value))
                        objCInvoices.Deliverydate = DateTime.MinValue;
                    else
                        objCInvoices.Deliverydate = (DateTime)dr["DeliveryDate"];
                    if (dr["DeliveryStatus"].Equals(DBNull.Value))
                        objCInvoices.Deliverystatus = 0;
                    else
                        objCInvoices.Deliverystatus = (int)dr["DeliveryStatus"];
                    if (dr["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        objCInvoices.Suppliesrequisitionguid = string.Empty;
                    else
                        objCInvoices.Suppliesrequisitionguid = (string)dr["SuppliesRequisitionId"];
                    if (dr["CashCollectionGuid"].Equals(DBNull.Value))
                        objCInvoices.Cashcollectionguid = string.Empty;
                    else
                        objCInvoices.Cashcollectionguid = (string)dr["CashCollectionGuid"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCInvoices.Discount = 0;
                    else
                        objCInvoices.Discount = (decimal)dr["Discount"];
                    if (dr["VAT"].Equals(DBNull.Value))
                        objCInvoices.VAT = 0;
                    else
                        objCInvoices.VAT = (decimal)dr["VAT"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCInvoices.Tablerowguid = string.Empty;
                    else
                        objCInvoices.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCInvoices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CInvoices> GetList(string Customerguid, bool NotIssued)
        {
            List<CInvoices> RecordsList = new List<CInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            command.CommandText = "Select * from tblInvoices";
            command.CommandText += " Where tblInvoices.CustomerGuid = @CustomerGuid ";
            if (NotIssued)
                command.CommandText += " AND tblInvoices.TableRowGuid not in (select distinct ISNULL(InvoiceGuid,'') from tblStoreTransactions) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoices objCInvoices = new CInvoices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCInvoices.Id = 0;
                    else
                        objCInvoices.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCInvoices.Customerguid = string.Empty;
                    else
                        objCInvoices.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCInvoices.Licenseguid = string.Empty;
                    else
                        objCInvoices.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Referencenumber = string.Empty;
                    else
                        objCInvoices.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["AttachmentReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Attachmentreferencenumber = string.Empty;
                    else
                        objCInvoices.Attachmentreferencenumber = (string)dr["AttachmentReferenceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCInvoices.Invoicedate = DateTime.MinValue;
                    else
                        objCInvoices.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceType"].Equals(DBNull.Value))
                        objCInvoices.Invoicetype = 0;
                    else
                        objCInvoices.Invoicetype = (int)dr["InvoiceType"];
                    if (dr["DueDate"].Equals(DBNull.Value))
                        objCInvoices.Duedate = DateTime.MinValue;
                    else
                        objCInvoices.Duedate = (DateTime)dr["DueDate"];
                    if (dr["PreparedBy"].Equals(DBNull.Value))
                        objCInvoices.Preparedby = string.Empty;
                    else
                        objCInvoices.Preparedby = (string)dr["PreparedBy"];
                    if (dr["CheckedBy"].Equals(DBNull.Value))
                        objCInvoices.Checkedby = string.Empty;
                    else
                        objCInvoices.Checkedby = (string)dr["CheckedBy"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCInvoices.Approvedby = string.Empty;
                    else
                        objCInvoices.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["DeliveredBy"].Equals(DBNull.Value))
                        objCInvoices.Deliveredby = string.Empty;
                    else
                        objCInvoices.Deliveredby = (string)dr["DeliveredBy"];
                    if (dr["PreparedDate"].Equals(DBNull.Value))
                        objCInvoices.Prepareddate = DateTime.MinValue;
                    else
                        objCInvoices.Prepareddate = (DateTime)dr["PreparedDate"];
                    if (dr["CheckedDate"].Equals(DBNull.Value))
                        objCInvoices.Checkeddate = DateTime.MinValue;
                    else
                        objCInvoices.Checkeddate = (DateTime)dr["CheckedDate"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCInvoices.Approvaldate = DateTime.MinValue;
                    else
                        objCInvoices.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["DeliveryDate"].Equals(DBNull.Value))
                        objCInvoices.Deliverydate = DateTime.MinValue;
                    else
                        objCInvoices.Deliverydate = (DateTime)dr["DeliveryDate"];
                    if (dr["DeliveryStatus"].Equals(DBNull.Value))
                        objCInvoices.Deliverystatus = 0;
                    else
                        objCInvoices.Deliverystatus = (int)dr["DeliveryStatus"];
                    if (dr["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        objCInvoices.Suppliesrequisitionguid = string.Empty;
                    else
                        objCInvoices.Suppliesrequisitionguid = (string)dr["SuppliesRequisitionId"];
                    if (dr["CashCollectionGuid"].Equals(DBNull.Value))
                        objCInvoices.Cashcollectionguid = string.Empty;
                    else
                        objCInvoices.Cashcollectionguid = (string)dr["CashCollectionGuid"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCInvoices.Discount = 0;
                    else
                        objCInvoices.Discount = (decimal)dr["Discount"];
                    if (dr["VAT"].Equals(DBNull.Value))
                        objCInvoices.VAT = 0;
                    else
                        objCInvoices.VAT = (decimal)dr["VAT"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCInvoices.Tablerowguid = string.Empty;
                    else
                        objCInvoices.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCInvoices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CInvoices> GetList(DateTime InvoiceDateFrom, DateTime InvoiceDateTo, bool NotIssued)
        {
            List<CInvoices> RecordsList = new List<CInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            command.CommandText = "Select * from tblInvoices";
            command.CommandText += " Where tblInvoices.InvoiceDate >= @InvoiceDateFrom ";
            command.CommandText += " AND tblInvoices.InvoiceDate <= @InvoiceDateTo ";
            if (NotIssued)
                command.CommandText += " AND tblInvoices.TableRowGuid not in (select distinct ISNULL(InvoiceGuid,'') from tblStoreTransactions) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@InvoiceDateFrom", InvoiceDateFrom));
            command.Parameters.Add(new SqlParameter("@InvoiceDateTo", InvoiceDateTo));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoices objCInvoices = new CInvoices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCInvoices.Id = 0;
                    else
                        objCInvoices.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCInvoices.Customerguid = string.Empty;
                    else
                        objCInvoices.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCInvoices.Licenseguid = string.Empty;
                    else
                        objCInvoices.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Referencenumber = string.Empty;
                    else
                        objCInvoices.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["AttachmentReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Attachmentreferencenumber = string.Empty;
                    else
                        objCInvoices.Attachmentreferencenumber = (string)dr["AttachmentReferenceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCInvoices.Invoicedate = DateTime.MinValue;
                    else
                        objCInvoices.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceType"].Equals(DBNull.Value))
                        objCInvoices.Invoicetype = 0;
                    else
                        objCInvoices.Invoicetype = (int)dr["InvoiceType"];
                    if (dr["DueDate"].Equals(DBNull.Value))
                        objCInvoices.Duedate = DateTime.MinValue;
                    else
                        objCInvoices.Duedate = (DateTime)dr["DueDate"];
                    if (dr["PreparedBy"].Equals(DBNull.Value))
                        objCInvoices.Preparedby = string.Empty;
                    else
                        objCInvoices.Preparedby = (string)dr["PreparedBy"];
                    if (dr["CheckedBy"].Equals(DBNull.Value))
                        objCInvoices.Checkedby = string.Empty;
                    else
                        objCInvoices.Checkedby = (string)dr["CheckedBy"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCInvoices.Approvedby = string.Empty;
                    else
                        objCInvoices.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["DeliveredBy"].Equals(DBNull.Value))
                        objCInvoices.Deliveredby = string.Empty;
                    else
                        objCInvoices.Deliveredby = (string)dr["DeliveredBy"];
                    if (dr["PreparedDate"].Equals(DBNull.Value))
                        objCInvoices.Prepareddate = DateTime.MinValue;
                    else
                        objCInvoices.Prepareddate = (DateTime)dr["PreparedDate"];
                    if (dr["CheckedDate"].Equals(DBNull.Value))
                        objCInvoices.Checkeddate = DateTime.MinValue;
                    else
                        objCInvoices.Checkeddate = (DateTime)dr["CheckedDate"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCInvoices.Approvaldate = DateTime.MinValue;
                    else
                        objCInvoices.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["DeliveryDate"].Equals(DBNull.Value))
                        objCInvoices.Deliverydate = DateTime.MinValue;
                    else
                        objCInvoices.Deliverydate = (DateTime)dr["DeliveryDate"];
                    if (dr["DeliveryStatus"].Equals(DBNull.Value))
                        objCInvoices.Deliverystatus = 0;
                    else
                        objCInvoices.Deliverystatus = (int)dr["DeliveryStatus"];
                    if (dr["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        objCInvoices.Suppliesrequisitionguid = string.Empty;
                    else
                        objCInvoices.Suppliesrequisitionguid = (string)dr["SuppliesRequisitionGuid"];
                    if (dr["CashCollectionGuid"].Equals(DBNull.Value))
                        objCInvoices.Cashcollectionguid = string.Empty;
                    else
                        objCInvoices.Cashcollectionguid = (string)dr["CashCollectionGuid"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCInvoices.Discount = 0;
                    else
                        objCInvoices.Discount = (decimal)dr["Discount"];
                    if (dr["VAT"].Equals(DBNull.Value))
                        objCInvoices.VAT = 0;
                    else
                        objCInvoices.VAT = (decimal)dr["VAT"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCInvoices.Tablerowguid = string.Empty;
                    else
                        objCInvoices.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCInvoices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CInvoices> GetList(string Customerguid, DateTime InvoiceDateFrom, DateTime InvoiceDateTo, bool NotIssued)
        {
            List<CInvoices> RecordsList = new List<CInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            command.CommandText = "Select * from tblInvoices";
            command.CommandText += " Where tblInvoices.CustomerGuid = @CustomerGuid ";
            command.CommandText += " AND tblInvoices.InvoiceDate >= @InvoiceDateFrom ";
            command.CommandText += " AND tblInvoices.InvoiceDate <= @InvoiceDateTo ";
            if (NotIssued)
                command.CommandText += " AND tblInvoices.TableRowGuid not in (select distinct ISNULL(InvoiceGuid,'') from tblStoreTransactions) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
            command.Parameters.Add(new SqlParameter("@InvoiceDateFrom", InvoiceDateFrom));
            command.Parameters.Add(new SqlParameter("@InvoiceDateTo", InvoiceDateTo));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoices objCInvoices = new CInvoices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCInvoices.Id = 0;
                    else
                        objCInvoices.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCInvoices.Customerguid = string.Empty;
                    else
                        objCInvoices.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCInvoices.Licenseguid = string.Empty;
                    else
                        objCInvoices.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Referencenumber = string.Empty;
                    else
                        objCInvoices.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["AttachmentReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Attachmentreferencenumber = string.Empty;
                    else
                        objCInvoices.Attachmentreferencenumber = (string)dr["AttachmentReferenceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCInvoices.Invoicedate = DateTime.MinValue;
                    else
                        objCInvoices.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceType"].Equals(DBNull.Value))
                        objCInvoices.Invoicetype = 0;
                    else
                        objCInvoices.Invoicetype = (int)dr["InvoiceType"];
                    if (dr["DueDate"].Equals(DBNull.Value))
                        objCInvoices.Duedate = DateTime.MinValue;
                    else
                        objCInvoices.Duedate = (DateTime)dr["DueDate"];
                    if (dr["PreparedBy"].Equals(DBNull.Value))
                        objCInvoices.Preparedby = string.Empty;
                    else
                        objCInvoices.Preparedby = (string)dr["PreparedBy"];
                    if (dr["CheckedBy"].Equals(DBNull.Value))
                        objCInvoices.Checkedby = string.Empty;
                    else
                        objCInvoices.Checkedby = (string)dr["CheckedBy"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCInvoices.Approvedby = string.Empty;
                    else
                        objCInvoices.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["DeliveredBy"].Equals(DBNull.Value))
                        objCInvoices.Deliveredby = string.Empty;
                    else
                        objCInvoices.Deliveredby = (string)dr["DeliveredBy"];
                    if (dr["PreparedDate"].Equals(DBNull.Value))
                        objCInvoices.Prepareddate = DateTime.MinValue;
                    else
                        objCInvoices.Prepareddate = (DateTime)dr["PreparedDate"];
                    if (dr["CheckedDate"].Equals(DBNull.Value))
                        objCInvoices.Checkeddate = DateTime.MinValue;
                    else
                        objCInvoices.Checkeddate = (DateTime)dr["CheckedDate"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCInvoices.Approvaldate = DateTime.MinValue;
                    else
                        objCInvoices.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["DeliveryDate"].Equals(DBNull.Value))
                        objCInvoices.Deliverydate = DateTime.MinValue;
                    else
                        objCInvoices.Deliverydate = (DateTime)dr["DeliveryDate"];
                    if (dr["DeliveryStatus"].Equals(DBNull.Value))
                        objCInvoices.Deliverystatus = 0;
                    else
                        objCInvoices.Deliverystatus = (int)dr["DeliveryStatus"];
                    if (dr["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        objCInvoices.Suppliesrequisitionguid = string.Empty;
                    else
                        objCInvoices.Suppliesrequisitionguid = (string)dr["SuppliesRequisitionId"];
                    if (dr["CashCollectionGuid"].Equals(DBNull.Value))
                        objCInvoices.Cashcollectionguid = string.Empty;
                    else
                        objCInvoices.Cashcollectionguid = (string)dr["CashCollectionGuid"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCInvoices.Discount = 0;
                    else
                        objCInvoices.Discount = (decimal)dr["Discount"];
                    if (dr["VAT"].Equals(DBNull.Value))
                        objCInvoices.VAT = 0;
                    else
                        objCInvoices.VAT = (decimal)dr["VAT"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCInvoices.Tablerowguid = string.Empty;
                    else
                        objCInvoices.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCInvoices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CInvoices> GetList(string strCriteria)
        {
            List<CInvoices> RecordsList = new List<CInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";

            strSQL = strSQL + " Select tblInvoices.*, Name from tblInvoices ";
            strSQL = strSQL + " join tblCustomers on (tblInvoices.CustomerGuid = tblCustomers.TableRowGuid) ";
            strSQL = strSQL + " where 1 = 1 " + strCriteria;
            strSQL = strSQL + " Order By tblInvoices.InvoiceDate, tblInvoices.ReferenceNumber ";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoices objCInvoices = new CInvoices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCInvoices.Id = 0;
                    else
                        objCInvoices.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCInvoices.Customerguid = string.Empty;
                    else
                        objCInvoices.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCInvoices.Licenseguid = string.Empty;
                    else
                        objCInvoices.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Referencenumber = string.Empty;
                    else
                        objCInvoices.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["AttachmentReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Attachmentreferencenumber = string.Empty;
                    else
                        objCInvoices.Attachmentreferencenumber = (string)dr["AttachmentReferenceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCInvoices.Invoicedate = DateTime.MinValue;
                    else
                        objCInvoices.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceType"].Equals(DBNull.Value))
                        objCInvoices.Invoicetype = 0;
                    else
                        objCInvoices.Invoicetype = (int)dr["InvoiceType"];
                    if (dr["DueDate"].Equals(DBNull.Value))
                        objCInvoices.Duedate = DateTime.MinValue;
                    else
                        objCInvoices.Duedate = (DateTime)dr["DueDate"];
                    if (dr["PreparedBy"].Equals(DBNull.Value))
                        objCInvoices.Preparedby = string.Empty;
                    else
                        objCInvoices.Preparedby = (string)dr["PreparedBy"];
                    if (dr["CheckedBy"].Equals(DBNull.Value))
                        objCInvoices.Checkedby = string.Empty;
                    else
                        objCInvoices.Checkedby = (string)dr["CheckedBy"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCInvoices.Approvedby = string.Empty;
                    else
                        objCInvoices.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["DeliveredBy"].Equals(DBNull.Value))
                        objCInvoices.Deliveredby = string.Empty;
                    else
                        objCInvoices.Deliveredby = (string)dr["DeliveredBy"];
                    if (dr["PreparedDate"].Equals(DBNull.Value))
                        objCInvoices.Prepareddate = DateTime.MinValue;
                    else
                        objCInvoices.Prepareddate = (DateTime)dr["PreparedDate"];
                    if (dr["CheckedDate"].Equals(DBNull.Value))
                        objCInvoices.Checkeddate = DateTime.MinValue;
                    else
                        objCInvoices.Checkeddate = (DateTime)dr["CheckedDate"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCInvoices.Approvaldate = DateTime.MinValue;
                    else
                        objCInvoices.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["DeliveryDate"].Equals(DBNull.Value))
                        objCInvoices.Deliverydate = DateTime.MinValue;
                    else
                        objCInvoices.Deliverydate = (DateTime)dr["DeliveryDate"];
                    if (dr["DeliveryStatus"].Equals(DBNull.Value))
                        objCInvoices.Deliverystatus = 0;
                    else
                        objCInvoices.Deliverystatus = (int)dr["DeliveryStatus"];
                    if (dr["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        objCInvoices.Suppliesrequisitionguid = string.Empty;
                    else
                        objCInvoices.Suppliesrequisitionguid = (string)dr["SuppliesRequisitionGuid"];
                    if (dr["CashCollectionGuid"].Equals(DBNull.Value))
                        objCInvoices.Cashcollectionguid = string.Empty;
                    else
                        objCInvoices.Cashcollectionguid = (string)dr["CashCollectionGuid"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCInvoices.Discount = 0;
                    else
                        objCInvoices.Discount = (decimal)dr["Discount"];
                    if (dr["VAT"].Equals(DBNull.Value))
                        objCInvoices.VAT = 0;
                    else
                        objCInvoices.VAT = (decimal)dr["VAT"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCInvoices.OrganizationName = string.Empty;
                    else
                        objCInvoices.OrganizationName = (string)dr["Name"];

                    if (dr["ReturnedDate"].Equals(DBNull.Value))
                        objCInvoices.ReturnedDate = DateTime.MinValue;
                    else
                        objCInvoices.ReturnedDate = (DateTime)dr["ReturnedDate"];
                    if (dr["ReturnedReason"].Equals(DBNull.Value))
                        objCInvoices.ReturnedReason = string.Empty;
                    else
                        objCInvoices.ReturnedReason = (string)dr["ReturnedReason"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCInvoices.Tablerowguid = string.Empty;
                    else
                        objCInvoices.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCInvoices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CInvoices> GetListPaymentRequest(string strCriteria)
        {
            List<CInvoices> RecordsList = new List<CInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";

            strSQL = strSQL + " Select tblInvoices.*, Name from tblInvoices ";
            strSQL = strSQL + " join tblCustomers on (tblInvoices.CustomerGuid = tblCustomers.TableRowGuid) ";
            strSQL = strSQL + " where tblInvoices.TableRowGuid NOT IN ";
            strSQL = strSQL + " (SELECT DISTINCT IsNull(tblCashCollectionInvoices.InvoiceGuid,'') ";
            strSQL = strSQL + " FROM tblCashCollections INNER JOIN tblCashCollectionInvoices ";
            strSQL = strSQL + " ON tblCashCollections.TableRowGuid = tblCashCollectionInvoices.CashCollectionGuid ";
            strSQL = strSQL + " AND IsNull(tblCashCollections.Settled,0) <> 0 ) " + strCriteria;
            strSQL = strSQL + " Order By tblInvoices.InvoiceDate, tblInvoices.ReferenceNumber ";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoices objCInvoices = new CInvoices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCInvoices.Id = 0;
                    else
                        objCInvoices.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCInvoices.Customerguid = string.Empty;
                    else
                        objCInvoices.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCInvoices.Licenseguid = string.Empty;
                    else
                        objCInvoices.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Referencenumber = string.Empty;
                    else
                        objCInvoices.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["AttachmentReferenceNumber"].Equals(DBNull.Value))
                        objCInvoices.Attachmentreferencenumber = string.Empty;
                    else
                        objCInvoices.Attachmentreferencenumber = (string)dr["AttachmentReferenceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCInvoices.Invoicedate = DateTime.MinValue;
                    else
                        objCInvoices.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceType"].Equals(DBNull.Value))
                        objCInvoices.Invoicetype = 0;
                    else
                        objCInvoices.Invoicetype = (int)dr["InvoiceType"];
                    if (dr["DueDate"].Equals(DBNull.Value))
                        objCInvoices.Duedate = DateTime.MinValue;
                    else
                        objCInvoices.Duedate = (DateTime)dr["DueDate"];
                    if (dr["PreparedBy"].Equals(DBNull.Value))
                        objCInvoices.Preparedby = string.Empty;
                    else
                        objCInvoices.Preparedby = (string)dr["PreparedBy"];
                    if (dr["CheckedBy"].Equals(DBNull.Value))
                        objCInvoices.Checkedby = string.Empty;
                    else
                        objCInvoices.Checkedby = (string)dr["CheckedBy"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCInvoices.Approvedby = string.Empty;
                    else
                        objCInvoices.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["DeliveredBy"].Equals(DBNull.Value))
                        objCInvoices.Deliveredby = string.Empty;
                    else
                        objCInvoices.Deliveredby = (string)dr["DeliveredBy"];
                    if (dr["PreparedDate"].Equals(DBNull.Value))
                        objCInvoices.Prepareddate = DateTime.MinValue;
                    else
                        objCInvoices.Prepareddate = (DateTime)dr["PreparedDate"];
                    if (dr["CheckedDate"].Equals(DBNull.Value))
                        objCInvoices.Checkeddate = DateTime.MinValue;
                    else
                        objCInvoices.Checkeddate = (DateTime)dr["CheckedDate"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCInvoices.Approvaldate = DateTime.MinValue;
                    else
                        objCInvoices.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["DeliveryDate"].Equals(DBNull.Value))
                        objCInvoices.Deliverydate = DateTime.MinValue;
                    else
                        objCInvoices.Deliverydate = (DateTime)dr["DeliveryDate"];
                    if (dr["DeliveryStatus"].Equals(DBNull.Value))
                        objCInvoices.Deliverystatus = 0;
                    else
                        objCInvoices.Deliverystatus = (int)dr["DeliveryStatus"];
                    if (dr["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        objCInvoices.Suppliesrequisitionguid = string.Empty;
                    else
                        objCInvoices.Suppliesrequisitionguid = (string)dr["SuppliesRequisitionGuid"];
                    if (dr["CashCollectionGuid"].Equals(DBNull.Value))
                        objCInvoices.Cashcollectionguid = string.Empty;
                    else
                        objCInvoices.Cashcollectionguid = (string)dr["CashCollectionGuid"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCInvoices.Discount = 0;
                    else
                        objCInvoices.Discount = (decimal)dr["Discount"];
                    if (dr["VAT"].Equals(DBNull.Value))
                        objCInvoices.VAT = 0;
                    else
                        objCInvoices.VAT = (decimal)dr["VAT"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCInvoices.OrganizationName = string.Empty;
                    else
                        objCInvoices.OrganizationName = (string)dr["Name"];

                    if (dr["ReturnedDate"].Equals(DBNull.Value))
                        objCInvoices.ReturnedDate = DateTime.MinValue;
                    else
                        objCInvoices.ReturnedDate = (DateTime)dr["ReturnedDate"];
                    if (dr["ReturnedReason"].Equals(DBNull.Value))
                        objCInvoices.ReturnedReason = string.Empty;
                    else
                        objCInvoices.ReturnedReason = (string)dr["ReturnedReason"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCInvoices.Tablerowguid = string.Empty;
                    else
                        objCInvoices.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCInvoices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public CInvoices GetCurrentSellableBatch(string Itemguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            CInvoices objCInvoices = new CInvoices();
            string strSQL = "";
            strSQL = strSQL + "  Select tblBatchs.Id, tblBatchs.TableRowGuid, BatchNumber,Quantity from ";
            strSQL = strSQL + "  tblBatchs join tblItems on (tblBatchs.ItemGuid = tblItems.TableRowGuid) ";
            strSQL = strSQL + "  where tblItems.SellableBactchGuid = tblBatchs.TableRowGuid ";
            strSQL = strSQL + "  And  tblItems.TableRowGuid = '" + Itemguid + "' ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
             try
            {
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCInvoices.Sellablebatchguid = string.Empty;
                    else
                        objCInvoices.Sellablebatchguid = (string)dr["TableRowGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCInvoices.SellableBatchName = string.Empty;
                    else
                        objCInvoices.SellableBatchName = (string)dr["BatchNumber"];

                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCInvoices.BatchQty = decimal.Zero;
                    else
                        objCInvoices.BatchQty = (decimal)dr["Quantity"];

                    objCInvoices.BatchBalaceQty = GetBatchBalanceQuantity(objCInvoices.Sellablebatchguid, objCInvoices.BatchQty);
                }
                return objCInvoices;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public decimal GetBatchBalanceQuantity(string Batchguid, decimal intBatchQty)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            string strSQL = "";
            strSQL = strSQL + "  Select sum(Quantity) as Quantity from tblInvoiceDetails ";
            strSQL = strSQL + "  join tblInvoices on (tblInvoiceDetails.InvoiceGuid = tblInvoices.TableRowGuid) ";
            strSQL = strSQL + "  where (tblInvoices.DeliveryStatus = " + (int)CCommon.DeliveryStatus.Delivered + " Or tblInvoices.DeliveryStatus = " + (int)CCommon.DeliveryStatus.Pending + ")";
            strSQL = strSQL + "  And tblInvoiceDetails.BatchGuid =@BatchGuid" ;
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                command.Parameters.Add(new SqlParameter("@BatchGuid", Batchguid));
                connection.Open();
                dr = command.ExecuteReader();
                dr.Read();
                if (dr["Quantity"].Equals(DBNull.Value))
                    return intBatchQty;
                else
                    return intBatchQty - (decimal)dr["Quantity"];

            }
            catch (Exception ex)
            {
                 throw new Exception("CInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                 if (connection != null) connection.Close();
                 if (dr != null) dr.Close();
                 if (command != null) command.Dispose();
            }
        }
        public decimal GetBatchQuantity(string Batchguid, string Itemguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            string strSQL = "";
            strSQL = strSQL + "  Select Quantity  from tblBatchs ";
            strSQL = strSQL + "  where tblBatchs.TableRowGuid = '" + Batchguid + "' ";
            strSQL = strSQL + "  And tblBatchs.ItemGuid = '" + Itemguid + "' ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                    if (dr["Quantity"].Equals(DBNull.Value))
                        return decimal.Zero;
                    else
                        return (decimal)dr["Quantity"];
                else
                    return decimal.Zero;

            }
            catch (Exception ex)
            {
                 throw new Exception("CInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                 if (connection != null) connection.Close();
                 if (dr != null) dr.Close();
                 if (command != null) command.Dispose();
            }
        }
        public bool UpdateSellableBatch()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblItems" +
                                   " Set SellableBactchGuid = @SellableBactchGuid " +
                                   " Where TableRowGuid = @ItemGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SellableBactchGuid", _SellableBatchGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CInvoices> GetListForInvoice(string Requesitionguid)
        {
            List<CInvoices> RecordsList = new List<CInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";

            strSQL = strSQL + " Select tblBatchs.id,tblBatchs.TableRowGuid,tblBatchs.BatchNumber, ";
            strSQL = strSQL + " ( tblItems.Measurement ) Unit, ";
            strSQL = strSQL + " tblSuppliesRequisitionDetails.ApprovedQuantity as Qty,tblBatchs.SalePrice AS UnitPrice, tblBatchs.SalePrice,";
            strSQL = strSQL + " (tblSuppliesRequisitionDetails.ApprovedQuantity * tblBatchs.SalePrice ) as TotalPrice, tblItems.TableRowGuid as ItemGuid, ";



            strSQL += " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
            strSQL += " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
            strSQL += " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
            strSQL += " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
            strSQL += " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
            strSQL = strSQL + " inner join tblBatchs on tblBatchs.ItemGuid =tblItems.TableRowGuid";
            strSQL = strSQL + " inner join tblSuppliesRequisitionDetails on tblSuppliesRequisitionDetails.ItemGuid= tblItems.TableRowGuid ";

           // strSQL = strSQL + " From tblSuppliesRequisitionDetails ";
           // strSQL = strSQL + " join tblItems on (tblSuppliesRequisitionDetails.ItemGuid = tblItems.TableRowGuid)  ";
           //// strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            
           // strSQL = strSQL + " join tblBatchs on (tblItems.TableRowGuid = tblBatchs.ItemGuid)";
            strSQL = strSQL + " where tblItems.SellableBactchGuid = tblBatchs.TableRowGuid";
            strSQL = strSQL + " and SuppliesRequisitionGuid = '" + Requesitionguid + "' ";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoices objInvoiceDetails = new CInvoices();
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objInvoiceDetails.Sellablebatchguid = string.Empty;
                    else
                        objInvoiceDetails.Sellablebatchguid = (string)dr["TableRowGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objInvoiceDetails.SellableBatchName = string.Empty;
                    else
                        objInvoiceDetails.SellableBatchName = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objInvoiceDetails.BrandName = string.Empty;
                    else
                        objInvoiceDetails.BrandName = (string)dr["BrandName"];

                    if (dr["Unit"].Equals(DBNull.Value))
                        objInvoiceDetails.Unit =string.Empty;
                    else
                        objInvoiceDetails.Unit = (string)dr["Unit"];

                    if (dr["Qty"].Equals(DBNull.Value))
                        objInvoiceDetails.ApprovedQuantity = decimal.Zero;
                    else
                        objInvoiceDetails.ApprovedQuantity = (decimal)dr["Qty"];

                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objInvoiceDetails.UnitPrice = decimal.Zero;
                    else
                        objInvoiceDetails.UnitPrice = (decimal)dr["UnitPrice"];

                    if (dr["SalePrice"].Equals(DBNull.Value))
                        objInvoiceDetails.SalePrice = decimal.Zero;
                    else
                        objInvoiceDetails.SalePrice = (decimal)dr["SalePrice"];


                    if (dr["TotalPrice"].Equals(DBNull.Value))
                        objInvoiceDetails.TotalPrice = decimal.Zero;
                    else
                        objInvoiceDetails.TotalPrice = (decimal)dr["TotalPrice"];

                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objInvoiceDetails.Itemguid = string.Empty;
                    else
                        objInvoiceDetails.Itemguid = (string)dr["ItemGuid"];

                    RecordsList.Add(objInvoiceDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoice::GetListForInvoice::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CInvoices> GetListForInvoice(string Invoiceguid, string Requesitionguid)
        {
            List<CInvoices> RecordsList = new List<CInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select tblInvoiceDetails.Id as InvoiceDetailId, tblInvoiceDetails.TableRowGuid as InvoiceDetailGuid, tblBatchs.id,tblBatchs.TableRowGuid,tblBatchs.BatchNumber,  ";
            strSQL = strSQL + " (tblUnitOfMeasurements.name + ' ' + tblItems.Measurement ) Unit,  ";
            strSQL = strSQL + " tblInvoiceDetails.Quantity as Qty,tblInvoiceDetails.UnitPrice,tblInvoiceDetails.UnitPrice AS SalePrice,";
            strSQL = strSQL + " (tblInvoiceDetails.Quantity * tblInvoiceDetails.UnitPrice ) as TotalPrice,  ";
            strSQL = strSQL + " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)As BrandName  from tblitems ";
            strSQL = strSQL + " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid ";
            strSQL = strSQL + " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
            strSQL = strSQL + " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
            strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
            strSQL = strSQL + " inner join tblBatchs on tblBatchs.ItemGuid =tblItems.TableRowGuid  ";
            strSQL = strSQL + " inner join tblInvoiceDetails on tblBatchs.TableRowGuid =tblInvoiceDetails.BatchGuid";
            strSQL = strSQL + " inner join tblInvoices on tblInvoices.TableRowGuid = tblInvoiceDetails.InvoiceGuid  ";
            strSQL = strSQL + " Left Outer join tblUnitOfMeasurements on (tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid) ";        
            strSQL = strSQL + " where tblInvoiceDetails.InvoiceGuid = '" + Invoiceguid + "' ";          
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoices objInvoiceDetails = new CInvoices();
                    if (dr["InvoiceDetailId"].Equals(DBNull.Value))
                        objInvoiceDetails.Invoicedetailid = int.MinValue;
                    else
                        objInvoiceDetails.Invoicedetailid = (int)dr["InvoiceDetailId"];
                    if (dr["InvoiceDetailGuid"].Equals(DBNull.Value))
                        objInvoiceDetails.Invoicedetailguid = string.Empty;
                    else
                        objInvoiceDetails.Invoicedetailguid = (string)dr["InvoiceDetailGuid"];

                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objInvoiceDetails.Sellablebatchguid = string.Empty;
                    else
                        objInvoiceDetails.Sellablebatchguid = (string)dr["TableRowGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objInvoiceDetails.SellableBatchName = string.Empty;
                    else
                        objInvoiceDetails.SellableBatchName = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objInvoiceDetails.BrandName = string.Empty;
                    else
                        objInvoiceDetails.BrandName = (string)dr["BrandName"];

                    if (dr["Unit"].Equals(DBNull.Value))
                        objInvoiceDetails.Unit = string.Empty;
                    else
                        objInvoiceDetails.Unit = (string)dr["Unit"];

                    if (dr["Qty"].Equals(DBNull.Value))
                        objInvoiceDetails.ApprovedQuantity = decimal.Zero;
                    else
                        objInvoiceDetails.ApprovedQuantity = (decimal)dr["Qty"];

                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objInvoiceDetails.UnitPrice = decimal.Zero;
                    else
                        objInvoiceDetails.UnitPrice = (decimal)dr["UnitPrice"];

                    if (dr["SalePrice"].Equals(DBNull.Value))
                        objInvoiceDetails.SalePrice = decimal.Zero;
                    else
                        objInvoiceDetails.SalePrice = (decimal)dr["SalePrice"];


                    if (dr["TotalPrice"].Equals(DBNull.Value))
                        objInvoiceDetails.TotalPrice = decimal.Zero;
                    else
                        objInvoiceDetails.TotalPrice = (decimal)dr["TotalPrice"];



                    RecordsList.Add(objInvoiceDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoice::GetListForInvoice::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CInvoices> GetListForInvoiceChangedBatch(string Itemguid)
        {
            List<CInvoices> RecordsList = new List<CInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";

            strSQL = strSQL + "  Select tblBatchs.id,tblBatchs.TableRowGuid,tblBatchs.BatchNumber,BrandName,  ";
            strSQL = strSQL + "  (tblUnitOfMeasurements.name + ' ' + tblItems.Measurement ) Unit,  ";
            strSQL = strSQL + "  NULL as Qty,tblBatchs.SalePrice AS UnitPrice, ";
            strSQL = strSQL + "  tblBatchs.SalePrice, NULL as TotalPrice, ";
            strSQL = strSQL + "  tblItems.TableRowGuid as ItemGuid  From  tblItems  ";
            strSQL = strSQL + "  join tblUnitOfMeasurements on (tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid) ";
            strSQL = strSQL + "  join tblBatchs on (tblItems.TableRowGuid = tblBatchs.ItemGuid) ";
            strSQL = strSQL + "  where tblItems.SellableBactchGuid = tblBatchs.TableRowGuid ";
            strSQL = strSQL + " and tblItems.TableRowGuid  = '" + Itemguid + "' ";
            
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoices objInvoiceDetails = new CInvoices();
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objInvoiceDetails.Sellablebatchguid = string.Empty;
                    else
                        objInvoiceDetails.Sellablebatchguid = (string)dr["TableRowGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objInvoiceDetails.SellableBatchName = string.Empty;
                    else
                        objInvoiceDetails.SellableBatchName = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objInvoiceDetails.BrandName = string.Empty;
                    else
                        objInvoiceDetails.BrandName = (string)dr["BrandName"];

                    if (dr["Unit"].Equals(DBNull.Value))
                        objInvoiceDetails.Unit = string.Empty;
                    else
                        objInvoiceDetails.Unit = (string)dr["Unit"];

                    if (dr["Qty"].Equals(DBNull.Value))
                        objInvoiceDetails.ApprovedQuantity = decimal.Zero;
                    else
                        objInvoiceDetails.ApprovedQuantity = (decimal)dr["Qty"];

                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objInvoiceDetails.UnitPrice = decimal.Zero;
                    else
                        objInvoiceDetails.UnitPrice = (decimal)dr["UnitPrice"];

                    if (dr["SalePrice"].Equals(DBNull.Value))
                        objInvoiceDetails.SalePrice = decimal.Zero;
                    else
                        objInvoiceDetails.SalePrice = (decimal)dr["SalePrice"];


                    if (dr["TotalPrice"].Equals(DBNull.Value))
                        objInvoiceDetails.TotalPrice = decimal.Zero;
                    else
                        objInvoiceDetails.TotalPrice = (decimal)dr["TotalPrice"];

                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objInvoiceDetails.Itemguid = string.Empty;
                    else
                        objInvoiceDetails.Itemguid = (string)dr["ItemGuid"];


                    RecordsList.Add(objInvoiceDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoice::GetListForInvoice::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool CheckIfQuantityIsAvailable(string Itemguid, string Batchguid, decimal decApprovedQuatity)
        {
            decimal decBatchQuantity = GetBatchQuantity(Batchguid, Itemguid);
            decimal decBatchBalanceQuantity = GetBatchBalanceQuantity(Batchguid, decBatchQuantity);
            if (decBatchBalanceQuantity >= decApprovedQuatity)
            {
                SellableBatchRemainingQuantity = decimal.Zero;
                QuantityRequiredFromNextBatch = decimal.Zero;
                return true;
            }
            else
            {
                SellableBatchRemainingQuantity = decBatchBalanceQuantity;
                QuantityRequiredFromNextBatch = decApprovedQuatity - decBatchBalanceQuantity;
                return false;
            }


           
        }
        public int GetInvoiceIdFromRequisitionGuid() 
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string strSQL = "";
            strSQL = strSQL + " Select id from tblInvoices where SuppliesRequisitionGuid=@SuppliesRequisitionGuid";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            adapter.SelectCommand = command;

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                connection.Open();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["id"].ToString());
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoice::GetListForInvoice::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool CheckIfRequisitionHasInvoice()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            string strSQL = "";
            strSQL = strSQL + " Select id from tblInvoices where SuppliesRequisitionGuid=@SuppliesRequisitionGuid";
           
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;        

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                connection.Open();

                dr =command.ExecuteReader();
                if(dr.HasRows)
                    return true;
                else
                    return false;


            }
            catch (Exception ex)
            {
                throw new Exception("CInvoice::GetListForInvoice::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();              
                if (command != null) command.Dispose();
            }
        }

        public bool CheckIfVATIsApplicable()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            string strSQL = "";
            strSQL = strSQL + " Select top 1 tblItems.id from tblSuppliesRequisitionDetails ";
            strSQL = strSQL + " join tblItems on (tblSuppliesRequisitionDetails.ItemGuid = tblItems.TableRowGuid)  ";
            strSQL = strSQL + " where tblSuppliesRequisitionDetails.SuppliesRequisitionGuid=@SuppliesRequisitionGuid And IsVATApplicable = 1";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                connection.Open();

                dr = command.ExecuteReader();
                if (dr.HasRows)
                    return true;
                else
                    return false;


            }
            catch (Exception ex)
            {
                throw new Exception("CInvoice::GetListForInvoice::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        
        public static int GetMaxReferenceNumber()
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;
            //Date for Cash Register Mashine 11/29/2010 
            string strCount = "Select Count(*) from tblInvoices";
            string strMAX = "Select MAX(CAST(ReferenceNumber AS int))  from tblInvoices where InvoiceDate > '11/29/2010'";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.CommandText = strCount;
                temp = command.ExecuteScalar();

                if (temp != null)
                {
                    if ((int)temp > 0)
                    {
                        temp = null;
                        command.CommandText = strMAX;
                        temp = command.ExecuteScalar();
                        if (temp != null)
                            if (temp != DBNull.Value)
                                return (int)temp;
                            else
                                return 0;
                        else
                            return 0;
                    }
                    else
                        return 0;
                }
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetMaxReferenceNumber::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static int GetMaxAttachmentReferenceNumber()
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            string strCount = "Select Count(*) from tblInvoices";
            string strMAX = "Select MAX(CAST(AttachmentReferenceNumber AS int)) from tblInvoices";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.CommandText = strCount;
                temp = command.ExecuteScalar();

                if (temp != null)
                {
                    if ((int)temp > 0)
                    {
                        temp = null;
                        command.CommandText = strMAX;
                        temp = command.ExecuteScalar();
                        if (temp != null)
                            if (temp != DBNull.Value)
                                return (int)temp;
                            else
                                return 0;
                        else
                            return 0;
                    }
                    else
                        return 0;
                }
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetMaxAttachmentReferenceNumber::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public static int GetMaxReferenceNumberPsychotropic()
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;
            
            string strCount = "Select Count(*) from tblInvoices";
            string strMAX = "Select MAX(CAST(IsNull(ReferenceNumberPsychotropic,'0') AS int))  from tblInvoices";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.CommandText = strCount;
                temp = command.ExecuteScalar();

                if (temp != null)
                {
                    if ((int)temp > 0)
                    {
                        temp = null;
                        command.CommandText = strMAX;
                        temp = command.ExecuteScalar();
                        if (temp != null)
                            if (temp != DBNull.Value)
                                return (int)temp;
                            else
                                return 0;
                        else
                            return 0;
                    }
                    else
                        return 0;
                }
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetMaxReferenceNumberPsychotropic::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static int GetMaxReferenceNumberCash()
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            string strCount = "Select Count(*) from tblInvoices";
            string strMAX = "Select MAX(CAST(IsNull(ReferenceNumberCash,'0') AS int))  from tblInvoices";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.CommandText = strCount;
                temp = command.ExecuteScalar();

                if (temp != null)
                {
                    if ((int)temp > 0)
                    {
                        temp = null;
                        command.CommandText = strMAX;
                        temp = command.ExecuteScalar();
                        if (temp != null)
                            if (temp != DBNull.Value)
                                return (int)temp;
                            else
                                return 0;
                        else
                            return 0;
                    }
                    else
                        return 0;
                }
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetMaxReferenceNumberCash::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static int GetMaxReferenceNumberCredit()
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            string strCount = "Select Count(*) from tblInvoices";
            string strMAX = "Select MAX(CAST(IsNull(ReferenceNumberCredit,'0') AS int))  from tblInvoices";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.CommandText = strCount;
                temp = command.ExecuteScalar();

                if (temp != null)
                {
                    if ((int)temp > 0)
                    {
                        temp = null;
                        command.CommandText = strMAX;
                        temp = command.ExecuteScalar();
                        if (temp != null)
                            if (temp != DBNull.Value)
                                return (int)temp;
                            else
                                return 0;
                        else
                            return 0;
                    }
                    else
                        return 0;
                }
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetMaxReferenceNumberCredit::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static int GetMaxReferenceNumberFreeOfCharge()
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            string strCount = "Select Count(*) from tblInvoices";
            string strMAX = "Select MAX(CAST(IsNull(ReferenceNumberFreeOfCharge,'0') AS int))  from tblInvoices";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.CommandText = strCount;
                temp = command.ExecuteScalar();

                if (temp != null)
                {
                    if ((int)temp > 0)
                    {
                        temp = null;
                        command.CommandText = strMAX;
                        temp = command.ExecuteScalar();
                        if (temp != null)
                            if (temp != DBNull.Value)
                                return (int)temp;
                            else
                                return 0;
                        else
                            return 0;
                    }
                    else
                        return 0;
                }
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetMaxReferenceNumberFreeOfCharge::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public static int GetDeliveryStatus(string Invoiceguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "Select DeliveryStatus = IsNull(DeliveryStatus, 0) from tblInvoices Where TableRowGuid = '" + Invoiceguid + "' ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                temp = command.ExecuteScalar();
                if (temp != null)
                    return (int)temp;
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetDeliveryStatus::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblInvoices] WHERE Id = @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Id", Id));
                connection.Open();
                temp = command.ExecuteScalar();
                if (temp != null)
                    return (string)temp;
                else
                    return string.Empty;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetTableRowGuid::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static int GetTableRowId(string Tablerowguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT Id FROM [dbo].[tblInvoices] WHERE TableRowGuid = @TableRowGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TableRowGuid", Tablerowguid));
                connection.Open();
                temp = command.ExecuteScalar();
                if (temp != null)
                    return (int)temp;
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoices::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
