//
// ...
// Wizard generated code
// Date: 3/22/2010 9:42:08 AM
// Class: CLocalPurchaseOrders
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
    class CLocalPurchaseOrders
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CLocalPurchaseOrders()
        {
            _ConnectionString = ConnectionString;
        }
        public CLocalPurchaseOrders(int Id, string Ordernumber, DateTime Orderdate, string Supplierguid, int Paymenttype, string Termsofpayment, string Placeoforigin, string Placeofdestination, int Ordertype, int Orderstatus, string Invoiceno, DateTime Invoicedate, string Invoiceremark)
        {
            _Id = Id;
            _OrderNumber = Ordernumber;
            _OrderDate = Orderdate;
            _SupplierGuid = Supplierguid;
            _PaymentType = Paymenttype;
            _TermsOfPayment = Termsofpayment;
            _PlaceOfOrigin = Placeoforigin;
            _PlaceOfDestination = Placeofdestination;
            _OrderType = Ordertype;
            _OrderStatus = Orderstatus;
            _InvoiceNo = Invoiceno;
            _InvoiceDate = Invoicedate;
            _InvoiceRemark = Invoiceremark;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _OrderNumber;
        public string Ordernumber
        {
            get { return _OrderNumber; }
            set { _OrderNumber = value; }
        }

        DateTime _OrderDate;
        public DateTime Orderdate
        {
            get { return _OrderDate; }
            set { _OrderDate = value; }
        }

        string _SupplierGuid;
        public string Supplierguid
        {
            get { return _SupplierGuid; }
            set { _SupplierGuid = value; }
        }

        int _PaymentType;
        public int Paymenttype
        {
            get { return _PaymentType; }
            set { _PaymentType = value; }
        }

        string _TermsOfPayment;
        public string Termsofpayment
        {
            get { return _TermsOfPayment; }
            set { _TermsOfPayment = value; }
        }

        string _PlaceOfOrigin;
        public string Placeoforigin
        {
            get { return _PlaceOfOrigin; }
            set { _PlaceOfOrigin = value; }
        }

        string _PlaceOfDestination;
        public string Placeofdestination
        {
            get { return _PlaceOfDestination; }
            set { _PlaceOfDestination = value; }
        }

        int _OrderType;
        public int Ordertype
        {
            get { return _OrderType; }
            set { _OrderType = value; }
        }

        int _OrderStatus;
        public int Orderstatus
        {
            get { return _OrderStatus; }
            set { _OrderStatus = value; }
        }

        string _InvoiceNo;
        public string Invoiceno
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }

        DateTime _InvoiceDate;
        public DateTime Invoicedate
        {
            get { return _InvoiceDate; }
            set { _InvoiceDate = value; }
        }

        string _InvoiceRemark;
        public string Invoiceremark
        {
            get { return _InvoiceRemark; }
            set { _InvoiceRemark = value; }
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
            command.CommandText = "Select * from tblLocalPurchaseOrders where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocalPurchaseOrders");
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
                    if (dTable.Rows[0]["OrderNumber"].Equals(DBNull.Value))
                        _OrderNumber = string.Empty;
                    else
                        _OrderNumber = (string)dTable.Rows[0]["OrderNumber"];
                    if (dTable.Rows[0]["OrderDate"].Equals(DBNull.Value))
                        _OrderDate = DateTime.MinValue;
                    else
                        _OrderDate = (DateTime)dTable.Rows[0]["OrderDate"];
                    if (dTable.Rows[0]["SupplierGuid"].Equals(DBNull.Value))
                        _SupplierGuid = string.Empty;
                    else
                        _SupplierGuid = (string)dTable.Rows[0]["SupplierGuid"];
                    if (dTable.Rows[0]["PaymentType"].Equals(DBNull.Value))
                        _PaymentType = 0;
                    else
                        _PaymentType = (int)dTable.Rows[0]["PaymentType"];
                    if (dTable.Rows[0]["TermsOfPayment"].Equals(DBNull.Value))
                        _TermsOfPayment = string.Empty;
                    else
                        _TermsOfPayment = (string)dTable.Rows[0]["TermsOfPayment"];
                    if (dTable.Rows[0]["PlaceOfOrigin"].Equals(DBNull.Value))
                        _PlaceOfOrigin = string.Empty;
                    else
                        _PlaceOfOrigin = (string)dTable.Rows[0]["PlaceOfOrigin"];
                    if (dTable.Rows[0]["PlaceOfDestination"].Equals(DBNull.Value))
                        _PlaceOfDestination = string.Empty;
                    else
                        _PlaceOfDestination = (string)dTable.Rows[0]["PlaceOfDestination"];
                    if (dTable.Rows[0]["OrderType"].Equals(DBNull.Value))
                        _OrderType = 0;
                    else
                        _OrderType = (int)dTable.Rows[0]["OrderType"];
                    if (dTable.Rows[0]["OrderStatus"].Equals(DBNull.Value))
                        _OrderStatus = 0;
                    else
                        _OrderStatus = (int)dTable.Rows[0]["OrderStatus"];
                    if (dTable.Rows[0]["InvoiceNo"].Equals(DBNull.Value))
                        _InvoiceNo = string.Empty;
                    else
                        _InvoiceNo = (string)dTable.Rows[0]["InvoiceNo"];
                    if (dTable.Rows[0]["InvoiceDate"].Equals(DBNull.Value))
                        _InvoiceDate = DateTime.MinValue;
                    else
                        _InvoiceDate = (DateTime)dTable.Rows[0]["InvoiceDate"];
                    if (dTable.Rows[0]["InvoiceRemark"].Equals(DBNull.Value))
                        _InvoiceRemark = string.Empty;
                    else
                        _InvoiceRemark = (string)dTable.Rows[0]["InvoiceRemark"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrders::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblLocalPurchaseOrders";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocalPurchaseOrders");
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
                throw new Exception("CLocalPurchaseOrders::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblLocalPurchaseOrders" +
                                   " (OrderNumber, " +
                                   " OrderDate, " +
                                   " SupplierGuid, " +
                                   " PaymentType, " +
                                   " TermsOfPayment, " +
                                   " PlaceOfOrigin, " +
                                   " PlaceOfDestination, " +
                                   " OrderType, " +
                                   " OrderStatus, " +
                                   " InvoiceNo, " +
                                   " InvoiceDate, " +
                                   " InvoiceRemark)" +
                                   " Values (@OrderNumber, " +
                                   " @OrderDate, " +
                                   " @SupplierGuid, " +
                                   " @PaymentType, " +
                                   " @TermsOfPayment, " +
                                   " @PlaceOfOrigin, " +
                                   " @PlaceOfDestination, " +
                                   " @OrderType, " +
                                   " @OrderStatus, " +
                                   " @InvoiceNo, " +
                                   " @InvoiceDate, " +
                                   " @InvoiceRemark)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_OrderNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@OrderNumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderNumber", _OrderNumber));
                if (_OrderDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderDate", _OrderDate));
                if (_SupplierGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@SupplierGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SupplierGuid", _SupplierGuid));
                if (_PaymentType == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@PaymentType", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PaymentType", _PaymentType));
                if (_TermsOfPayment == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TermsOfPayment", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TermsOfPayment", _TermsOfPayment));
                if (_PlaceOfOrigin == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", _PlaceOfOrigin));
                if (_PlaceOfDestination == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PlaceOfDestination", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PlaceOfDestination", _PlaceOfDestination));
                if (_OrderType == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderType", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderType", _OrderType));
                if (_OrderStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderStatus", _OrderStatus));
                if (_InvoiceNo == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceNo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceNo", _InvoiceNo));
                if (_InvoiceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", _InvoiceDate));
                if (_InvoiceRemark == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", _InvoiceRemark));

                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrders::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblLocalPurchaseOrders" +
                                   " Set OrderNumber = @OrderNumber, " +
                                   " OrderDate = @OrderDate, " +
                                   " SupplierGuid = @SupplierGuid, " +
                                   " PaymentType = @PaymentType, " +
                                   " TermsOfPayment = @TermsOfPayment, " +
                                   " PlaceOfOrigin = @PlaceOfOrigin, " +
                                   " PlaceOfDestination = @PlaceOfDestination, " +
                                   " OrderType = @OrderType, " +
                                   " OrderStatus = @OrderStatus, " +
                                   " InvoiceNo = @InvoiceNo, " +
                                   " InvoiceDate = @InvoiceDate, " +
                                   " InvoiceRemark = @InvoiceRemark" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_OrderNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@OrderNumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderNumber", _OrderNumber));
                if (_OrderDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderDate", _OrderDate));
                if (_SupplierGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@SupplierGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SupplierGuid", _SupplierGuid));
                if (_PaymentType == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@PaymentType", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PaymentType", _PaymentType));
                if (_TermsOfPayment == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TermsOfPayment", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TermsOfPayment", _TermsOfPayment));
                if (_PlaceOfOrigin == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", _PlaceOfOrigin));
                if (_PlaceOfDestination == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PlaceOfDestination", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PlaceOfDestination", _PlaceOfDestination));
                if (_OrderType == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderType", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderType", _OrderType));
                if (_OrderStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderStatus", _OrderStatus));
                if (_InvoiceNo == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceNo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceNo", _InvoiceNo));
                if (_InvoiceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", _InvoiceDate));
                if (_InvoiceRemark == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", _InvoiceRemark));
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrders::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblLocalPurchaseOrders Where Id = @Id ";
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
                throw new Exception("CLocalPurchaseOrders::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrders] WHERE " +
                                       " OrderNumber = @OrderNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrders] WHERE " +
                                       " OrderNumber = @OrderNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@OrderNumber", _OrderNumber));
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
                throw new Exception("CLocalPurchaseOrders::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool IsPurchaseOrderWithVAT(string PurchaseOrderGuid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " SELECT Top 1 IsVATApplicable FROM  ";
            command.CommandText += " tblLocalPurchaseOrderDetails INNER JOIN tblItems ON (tblLocalPurchaseOrderDetails.ItemGuid = tblItems.TableRowGuid) ";
            command.CommandText += " WHERE   tblLocalPurchaseOrderDetails.PurchaseOrderGuid = @PurchaseOrderGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", PurchaseOrderGuid));
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    return (bool)dr["IsVATApplicable"];
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrders::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CLocalPurchaseOrders> GetList()
        {
            List<CLocalPurchaseOrders> RecordsList = new List<CLocalPurchaseOrders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLocalPurchaseOrders";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocalPurchaseOrders objCLocalPurchaseOrders = new CLocalPurchaseOrders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Id = 0;
                    else
                        objCLocalPurchaseOrders.Id = (int)dr["Id"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objCLocalPurchaseOrders.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["SupplierGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Supplierguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Supplierguid = (string)dr["SupplierGuid"];
                    if (dr["PaymentType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Paymenttype = 0;
                    else
                        objCLocalPurchaseOrders.Paymenttype = (int)dr["PaymentType"];
                    if (dr["TermsOfPayment"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Termsofpayment = string.Empty;
                    else
                        objCLocalPurchaseOrders.Termsofpayment = (string)dr["TermsOfPayment"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["OrderType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordertype = 0;
                    else
                        objCLocalPurchaseOrders.Ordertype = (int)dr["OrderType"];
                    if (dr["OrderStatus"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderstatus = 0;
                    else
                        objCLocalPurchaseOrders.Orderstatus = (int)dr["OrderStatus"];
                    if (dr["InvoiceNo"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceno = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceno = (string)dr["InvoiceNo"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoicedate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceRemark"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceremark = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceremark = (string)dr["InvoiceRemark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Tablerowguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLocalPurchaseOrders);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrders::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CLocalPurchaseOrders> GetList(bool NotReceived)
        {
            List<CLocalPurchaseOrders> RecordsList = new List<CLocalPurchaseOrders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLocalPurchaseOrders";
            if (NotReceived)
                command.CommandText += " Where tblLocalPurchaseOrders.TableRowGuid not in (select distinct ISNULL(PurchaseOrderGuid,'') from tblStoreTransactions where PurchaseOrderType = " + (int)CCommon.SupplierType.Local + ") ";
            command.CommandText += " ORDER BY cast(OrderNumber as int) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocalPurchaseOrders objCLocalPurchaseOrders = new CLocalPurchaseOrders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Id = 0;
                    else
                        objCLocalPurchaseOrders.Id = (int)dr["Id"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objCLocalPurchaseOrders.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["SupplierGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Supplierguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Supplierguid = (string)dr["SupplierGuid"];
                    if (dr["PaymentType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Paymenttype = 0;
                    else
                        objCLocalPurchaseOrders.Paymenttype = (int)dr["PaymentType"];
                    if (dr["TermsOfPayment"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Termsofpayment = string.Empty;
                    else
                        objCLocalPurchaseOrders.Termsofpayment = (string)dr["TermsOfPayment"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["OrderType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordertype = 0;
                    else
                        objCLocalPurchaseOrders.Ordertype = (int)dr["OrderType"];
                    if (dr["OrderStatus"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderstatus = 0;
                    else
                        objCLocalPurchaseOrders.Orderstatus = (int)dr["OrderStatus"];
                    if (dr["InvoiceNo"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceno = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceno = (string)dr["InvoiceNo"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoicedate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceRemark"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceremark = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceremark = (string)dr["InvoiceRemark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Tablerowguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLocalPurchaseOrders);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrders::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CLocalPurchaseOrders> GetList(string Manufacturerguid, bool NotReceived)
        {
            List<CLocalPurchaseOrders> RecordsList = new List<CLocalPurchaseOrders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " SELECT   tblLocalPurchaseOrders.Id, tblLocalPurchaseOrders.TableRowGuid, tblLocalPurchaseOrders.OrderNumber, tblLocalPurchaseOrders.OrderDate, '' as ManufacturerProformaGuid,  ";
            strSQL = strSQL + "                tblLocalPurchaseOrders.PaymentType,tblLocalPurchaseOrders.TermsOfPayment as TermsOfContract, tblLocalPurchaseOrders.SupplierGuid,'Birr' as CurrencyType, 0 as FreightCharge, ";
            strSQL = strSQL + "                tblLocalPurchaseOrders.PlaceOfOrigin, tblLocalPurchaseOrders.PlaceOfDestination, tblLocalPurchaseOrders.OrderType, tblLocalPurchaseOrders.OrderStatus,tblLocalPurchaseOrders.InvoiceNo,tblLocalPurchaseOrders.InvoiceDate,tblLocalPurchaseOrders.InvoiceRemark  ";
            strSQL = strSQL + " FROM      tblLocalPurchaseOrders ";
            strSQL = strSQL + " Where tblLocalPurchaseOrders.SupplierGuid = @ManufacturerGuid ";
            if (NotReceived)
                strSQL = strSQL + " And tblLocalPurchaseOrders.TableRowGuid not in (select distinct ISNULL(PurchaseOrderGuid,'') from tblStoreTransactions where PurchaseOrderType = " + (int)CCommon.SupplierType.Local + ") ";
            strSQL = strSQL + " ORDER BY cast(OrderNumber as int) ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocalPurchaseOrders objCLocalPurchaseOrders = new CLocalPurchaseOrders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Id = 0;
                    else
                        objCLocalPurchaseOrders.Id = (int)dr["Id"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objCLocalPurchaseOrders.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["SupplierGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Supplierguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Supplierguid = (string)dr["SupplierGuid"];
                    if (dr["PaymentType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Paymenttype = 0;
                    else
                        objCLocalPurchaseOrders.Paymenttype = (int)dr["PaymentType"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Termsofpayment = string.Empty;
                    else
                        objCLocalPurchaseOrders.Termsofpayment = (string)dr["TermsOfContract"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["OrderType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordertype = 0;
                    else
                        objCLocalPurchaseOrders.Ordertype = (int)dr["OrderType"];
                    if (dr["OrderStatus"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderstatus = 0;
                    else
                        objCLocalPurchaseOrders.Orderstatus = (int)dr["OrderStatus"];
                    if (dr["InvoiceNo"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceno = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceno = (string)dr["InvoiceNo"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoicedate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceRemark"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceremark = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceremark = (string)dr["InvoiceRemark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Tablerowguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLocalPurchaseOrders);

                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrders::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CLocalPurchaseOrders> GetList(DateTime OrderDateFrom, DateTime OrderDateTo, bool NotReceived)
        {
            List<CLocalPurchaseOrders> RecordsList = new List<CLocalPurchaseOrders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " SELECT   tblLocalPurchaseOrders.Id, tblLocalPurchaseOrders.TableRowGuid, tblLocalPurchaseOrders.OrderNumber, tblLocalPurchaseOrders.OrderDate, '' as ManufacturerProformaGuid,  ";
            strSQL = strSQL + "                tblLocalPurchaseOrders.PaymentType,tblLocalPurchaseOrders.TermsOfPayment as TermsOfContract, tblLocalPurchaseOrders.SupplierGuid,'Birr' as CurrencyType, 0 as FreightCharge, ";
            strSQL = strSQL + "                tblLocalPurchaseOrders.PlaceOfOrigin, tblLocalPurchaseOrders.PlaceOfDestination, tblLocalPurchaseOrders.OrderType, tblLocalPurchaseOrders.OrderStatus,tblLocalPurchaseOrders.InvoiceNo,tblLocalPurchaseOrders.InvoiceDate,tblLocalPurchaseOrders.InvoiceRemark  ";
            strSQL = strSQL + " FROM      tblLocalPurchaseOrders ";
            strSQL = strSQL + " Where tblLocalPurchaseOrders.OrderDate >= @OrderDateFrom ";
            strSQL = strSQL + " And tblLocalPurchaseOrders.OrderDate <= @OrderDateTo ";
            if (NotReceived)
                strSQL = strSQL + " And tblLocalPurchaseOrders.TableRowGuid not in (select distinct ISNULL(PurchaseOrderGuid,'') from tblStoreTransactions where PurchaseOrderType = " + (int)CCommon.SupplierType.Local + ") ";
            strSQL = strSQL + " ORDER BY cast(OrderNumber as int) ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@OrderDateFrom", OrderDateFrom));
            command.Parameters.Add(new SqlParameter("@OrderDateTo", OrderDateTo));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocalPurchaseOrders objCLocalPurchaseOrders = new CLocalPurchaseOrders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Id = 0;
                    else
                        objCLocalPurchaseOrders.Id = (int)dr["Id"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objCLocalPurchaseOrders.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["SupplierGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Supplierguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Supplierguid = (string)dr["SupplierGuid"];
                    if (dr["PaymentType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Paymenttype = 0;
                    else
                        objCLocalPurchaseOrders.Paymenttype = (int)dr["PaymentType"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Termsofpayment = string.Empty;
                    else
                        objCLocalPurchaseOrders.Termsofpayment = (string)dr["TermsOfContract"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["OrderType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordertype = 0;
                    else
                        objCLocalPurchaseOrders.Ordertype = (int)dr["OrderType"];
                    if (dr["OrderStatus"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderstatus = 0;
                    else
                        objCLocalPurchaseOrders.Orderstatus = (int)dr["OrderStatus"];
                    if (dr["InvoiceNo"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceno = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceno = (string)dr["InvoiceNo"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoicedate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceRemark"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceremark = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceremark = (string)dr["InvoiceRemark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Tablerowguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLocalPurchaseOrders);

                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrders::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CLocalPurchaseOrders> GetList(string Manufacturerguid, DateTime OrderDateFrom, DateTime OrderDateTo, bool NotReceived)
        {
            List<CLocalPurchaseOrders> RecordsList = new List<CLocalPurchaseOrders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " SELECT   tblLocalPurchaseOrders.Id, tblLocalPurchaseOrders.TableRowGuid, tblLocalPurchaseOrders.OrderNumber, tblLocalPurchaseOrders.OrderDate, '' as ManufacturerProformaGuid,  ";
            strSQL = strSQL + "                tblLocalPurchaseOrders.PaymentType,tblLocalPurchaseOrders.TermsOfPayment as TermsOfContract, tblLocalPurchaseOrders.SupplierGuid,'Birr' as CurrencyType, 0 as FreightCharge, ";
            strSQL = strSQL + "                tblLocalPurchaseOrders.PlaceOfOrigin, tblLocalPurchaseOrders.PlaceOfDestination, tblLocalPurchaseOrders.OrderType, tblLocalPurchaseOrders.OrderStatus,tblLocalPurchaseOrders.InvoiceNo,tblLocalPurchaseOrders.InvoiceDate,tblLocalPurchaseOrders.InvoiceRemark  ";
            strSQL = strSQL + " FROM      tblLocalPurchaseOrders ";
            strSQL = strSQL + " Where tblLocalPurchaseOrders.SupplierGuid = @ManufacturerGuid ";
            strSQL = strSQL + " And tblLocalPurchaseOrders.OrderDate >= @OrderDateFrom ";
            strSQL = strSQL + " And tblLocalPurchaseOrders.OrderDate <= @OrderDateTo ";
            if (NotReceived)
                strSQL = strSQL + " And tblLocalPurchaseOrders.TableRowGuid not in (select distinct ISNULL(PurchaseOrderGuid,'') from tblStoreTransactions where PurchaseOrderType = " + (int)CCommon.SupplierType.Local + ") ";
            command.CommandText += " ORDER BY cast(OrderNumber as int) ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
            command.Parameters.Add(new SqlParameter("@OrderDateFrom", OrderDateFrom));
            command.Parameters.Add(new SqlParameter("@OrderDateTo", OrderDateTo));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocalPurchaseOrders objCLocalPurchaseOrders = new CLocalPurchaseOrders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Id = 0;
                    else
                        objCLocalPurchaseOrders.Id = (int)dr["Id"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objCLocalPurchaseOrders.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["SupplierGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Supplierguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Supplierguid = (string)dr["SupplierGuid"];
                    if (dr["PaymentType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Paymenttype = 0;
                    else
                        objCLocalPurchaseOrders.Paymenttype = (int)dr["PaymentType"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Termsofpayment = string.Empty;
                    else
                        objCLocalPurchaseOrders.Termsofpayment = (string)dr["TermsOfContract"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objCLocalPurchaseOrders.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["OrderType"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Ordertype = 0;
                    else
                        objCLocalPurchaseOrders.Ordertype = (int)dr["OrderType"];
                    if (dr["OrderStatus"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Orderstatus = 0;
                    else
                        objCLocalPurchaseOrders.Orderstatus = (int)dr["OrderStatus"];
                    if (dr["InvoiceNo"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceno = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceno = (string)dr["InvoiceNo"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoicedate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrders.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceRemark"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Invoiceremark = string.Empty;
                    else
                        objCLocalPurchaseOrders.Invoiceremark = (string)dr["InvoiceRemark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrders.Tablerowguid = string.Empty;
                    else
                        objCLocalPurchaseOrders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLocalPurchaseOrders);

                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrders::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public static int GetMaxOrderNumber()
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            string strCount = "Select Count(*) from tblLocalPurchaseOrders";
            string strMAX = "Select MAX(CAST(OrderNumber AS int)) from tblLocalPurchaseOrders";

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
                            return (int)temp;
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
                throw new Exception("CPurchaseOrders::GetMaxReferenceNumber::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid  FROM [dbo].[tblLocalPurchaseOrders] WHERE Id = @Id";
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
                throw new Exception("CLocalPurchaseOrders::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrders] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CLocalPurchaseOrders::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
