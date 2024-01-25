//
// ...
// Wizard generated code
// Date: 7/19/2009 10:58:29 AM
// Class: CStoreTransactions
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
    class CStoreTransactions
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CStoreTransactions()
        {
            _ConnectionString = ConnectionString;
        }
        public CStoreTransactions(int Id, string Purchaseorderguid, string Invoiceguid, string Storeguid, string Referencenumber, int Transactiontype, string Transactionby, DateTime Transactiondate, string Checkedby, DateTime Checkeddate, string Deliveredby, DateTime Deliverydate, string Issuedto)
        {
            _Id = Id;
            _PurchaseOrderGuid = Purchaseorderguid;
            _InvoiceGuid = Invoiceguid;
            _StoreGuid = Storeguid;
            _ReferenceNumber = Referencenumber;
            _TransactionType = Transactiontype;
            _TransactionBy = Transactionby;
            _TransactionDate = Transactiondate;
            _CheckedBy = Checkedby;
            _CheckedDate = Checkeddate;
            _DeliveredBy = Deliveredby;
            _DeliveryDate = Deliverydate;
            _IssuedToDeliveryPersonGuid = Issuedto;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _PurchaseOrderGuid;
        public string Purchaseorderguid
        {
            get { return _PurchaseOrderGuid; }
            set { _PurchaseOrderGuid = value; }
        }

        string _InvoiceGuid;
        public string Invoiceguid
        {
            get { return _InvoiceGuid; }
            set { _InvoiceGuid = value; }
        }

        string _StoreGuid;
        public string Storeguid
        {
            get { return _StoreGuid; }
            set { _StoreGuid = value; }
        }

        string _ReferenceNumber;
        public string ReferenceNumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        int _TransactionType;
        public int TransactionType
        {
            get { return _TransactionType; }
            set { _TransactionType = value; }
        }

        string _TransactionBy;
        public string TransactionBy
        {
            get { return _TransactionBy; }
            set { _TransactionBy = value; }
        }

        DateTime _TransactionDate;
        public DateTime TransactionDate
        {
            get { return _TransactionDate; }
            set { _TransactionDate = value; }
        }

        string _CheckedBy;
        public string CheckedBy
        {
            get { return _CheckedBy; }
            set { _CheckedBy = value; }
        }

        DateTime _CheckedDate;
        public DateTime CheckedDate
        {
            get { return _CheckedDate; }
            set { _CheckedDate = value; }
        }

        string _DeliveredBy;
        public string DeliveredBy
        {
            get { return _DeliveredBy; }
            set { _DeliveredBy = value; }
        }

        DateTime _DeliveryDate;
        public DateTime DeliveryDate
        {
            get { return _DeliveryDate; }
            set { _DeliveryDate = value; }
        }

        string _IssuedToDeliveryPersonGuid;
        public string IssuedToDeliveryPersonGuid
        {
            get { return _IssuedToDeliveryPersonGuid; }
            set { _IssuedToDeliveryPersonGuid = value; }
        }

        string _StoreName;
        public string StoreName
        {
            get { return _StoreName; }
            set { _StoreName = value; }
        }

        string _LoactionName;
        public string LocationName
        {
            get { return _LoactionName; }
            set { _LoactionName = value; }
        }

        string _InvoiceNumber;
        public string InvoiceNumber
        {
            get { return _InvoiceNumber; }
            set { _InvoiceNumber = value; }
        }

        int _PurchaseOrderType;
        public int PurchaseOrderType
        {
            get { return _PurchaseOrderType; }
            set { _PurchaseOrderType = value; }
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
            command.CommandText = "Select * from tblStoreTransactions where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblStoreTransactions");
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
                    if (dTable.Rows[0]["PurchaseOrderGuid"].Equals(DBNull.Value))
                        _PurchaseOrderGuid = string.Empty;
                    else
                        _PurchaseOrderGuid = (string)dTable.Rows[0]["PurchaseOrderGuid"];
                    if (dTable.Rows[0]["StoreGuid"].Equals(DBNull.Value))
                        _StoreGuid = string.Empty;
                    else
                        _StoreGuid = (string)dTable.Rows[0]["StoreGuid"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["TransactionType"].Equals(DBNull.Value))
                        _TransactionType = 0;
                    else
                        _TransactionType = (int)dTable.Rows[0]["TransactionType"];
                    if (dTable.Rows[0]["TransactionBy"].Equals(DBNull.Value))
                        _TransactionBy = string.Empty;
                    else
                        _TransactionBy = (string)dTable.Rows[0]["TransactionBy"];
                    if (dTable.Rows[0]["TransactionDate"].Equals(DBNull.Value))
                        _TransactionDate = DateTime.MinValue;
                    else
                        _TransactionDate = (DateTime)dTable.Rows[0]["TransactionDate"];
                    if (dTable.Rows[0]["CheckedBy"].Equals(DBNull.Value))
                        _CheckedBy = string.Empty;
                    else
                        _CheckedBy = (string)dTable.Rows[0]["CheckedBy"];
                    if (dTable.Rows[0]["CheckedDate"].Equals(DBNull.Value))
                        _CheckedDate = DateTime.MinValue;
                    else
                        _CheckedDate = (DateTime)dTable.Rows[0]["CheckedDate"];
                    if (dTable.Rows[0]["DeliveredBy"].Equals(DBNull.Value))
                        _DeliveredBy = string.Empty;
                    else
                        _DeliveredBy = (string)dTable.Rows[0]["DeliveredBy"];
                    if (dTable.Rows[0]["DeliveryDate"].Equals(DBNull.Value))
                        _DeliveryDate = DateTime.MinValue;
                    else
                        _DeliveryDate = (DateTime)dTable.Rows[0]["DeliveryDate"];
                    if (dTable.Rows[0]["IssuedToDeliveryPersonGuid"].Equals(DBNull.Value))
                        _IssuedToDeliveryPersonGuid = string.Empty;
                    else
                        _IssuedToDeliveryPersonGuid = (string)dTable.Rows[0]["IssuedToDeliveryPersonGuid"];
                    if (dTable.Rows[0]["PurchaseOrderType"].Equals(DBNull.Value))
                        _PurchaseOrderType = 0;
                    else
                        _PurchaseOrderType = (int)dTable.Rows[0]["PurchaseOrderType"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactions::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecordbyPO(string Purchaseorderguid, int PurchaseOrderType)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblStoreTransactions where PurchaseOrderGuid=@PurchaseOrderGuid And PurchaseOrderType=@PurchaseOrderType ";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblStoreTransactions");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@PurchaseOrderType", PurchaseOrderType));
                connection.Open();
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    _Id = (int)dTable.Rows[0]["Id"];
                    if (dTable.Rows[0]["PurchaseOrderGuid"].Equals(DBNull.Value))
                        _PurchaseOrderGuid = string.Empty;
                    else
                        _PurchaseOrderGuid = (string)dTable.Rows[0]["PurchaseOrderGuid"];
                    if (dTable.Rows[0]["StoreGuid"].Equals(DBNull.Value))
                        _StoreGuid = string.Empty;
                    else
                        _StoreGuid = (string)dTable.Rows[0]["StoreGuid"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["TransactionType"].Equals(DBNull.Value))
                        _TransactionType = 0;
                    else
                        _TransactionType = (int)dTable.Rows[0]["TransactionType"];
                    if (dTable.Rows[0]["TransactionBy"].Equals(DBNull.Value))
                        _TransactionBy = string.Empty;
                    else
                        _TransactionBy = (string)dTable.Rows[0]["TransactionBy"];
                    if (dTable.Rows[0]["TransactionDate"].Equals(DBNull.Value))
                        _TransactionDate = DateTime.MinValue;
                    else
                        _TransactionDate = (DateTime)dTable.Rows[0]["TransactionDate"];
                    if (dTable.Rows[0]["CheckedBy"].Equals(DBNull.Value))
                        _CheckedBy = string.Empty;
                    else
                        _CheckedBy = (string)dTable.Rows[0]["CheckedBy"];
                    if (dTable.Rows[0]["CheckedDate"].Equals(DBNull.Value))
                        _CheckedDate = DateTime.MinValue;
                    else
                        _CheckedDate = (DateTime)dTable.Rows[0]["CheckedDate"];
                    if (dTable.Rows[0]["DeliveredBy"].Equals(DBNull.Value))
                        _DeliveredBy = string.Empty;
                    else
                        _DeliveredBy = (string)dTable.Rows[0]["DeliveredBy"];
                    if (dTable.Rows[0]["DeliveryDate"].Equals(DBNull.Value))
                        _DeliveryDate = DateTime.MinValue;
                    else
                        _DeliveryDate = (DateTime)dTable.Rows[0]["DeliveryDate"];
                    if (dTable.Rows[0]["IssuedToDeliveryPersonGuid"].Equals(DBNull.Value))
                        _IssuedToDeliveryPersonGuid = string.Empty;
                    else
                        _IssuedToDeliveryPersonGuid = (string)dTable.Rows[0]["IssuedToDeliveryPersonGuid"];
                    if (dTable.Rows[0]["PurchaseOrderType"].Equals(DBNull.Value))
                        _PurchaseOrderType = 0;
                    else
                        _PurchaseOrderType = (int)dTable.Rows[0]["PurchaseOrderType"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactions::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecordbyInvoice(string Invoiceguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblStoreTransactions where InvoiceGuid=@InvoiceGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblStoreTransactions");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", Invoiceguid));
                connection.Open();
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    _Id = (int)dTable.Rows[0]["Id"];
                    if (dTable.Rows[0]["PurchaseOrderGuid"].Equals(DBNull.Value))
                        _PurchaseOrderGuid = string.Empty;
                    else
                        _PurchaseOrderGuid = (string)dTable.Rows[0]["PurchaseOrderGuid"];
                    if (dTable.Rows[0]["StoreGuid"].Equals(DBNull.Value))
                        _StoreGuid = string.Empty;
                    else
                        _StoreGuid = (string)dTable.Rows[0]["StoreGuid"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["TransactionType"].Equals(DBNull.Value))
                        _TransactionType = 0;
                    else
                        _TransactionType = (int)dTable.Rows[0]["TransactionType"];
                    if (dTable.Rows[0]["TransactionBy"].Equals(DBNull.Value))
                        _TransactionBy = string.Empty;
                    else
                        _TransactionBy = (string)dTable.Rows[0]["TransactionBy"];
                    if (dTable.Rows[0]["TransactionDate"].Equals(DBNull.Value))
                        _TransactionDate = DateTime.MinValue;
                    else
                        _TransactionDate = (DateTime)dTable.Rows[0]["TransactionDate"];
                    if (dTable.Rows[0]["CheckedBy"].Equals(DBNull.Value))
                        _CheckedBy = string.Empty;
                    else
                        _CheckedBy = (string)dTable.Rows[0]["CheckedBy"];
                    if (dTable.Rows[0]["CheckedDate"].Equals(DBNull.Value))
                        _CheckedDate = DateTime.MinValue;
                    else
                        _CheckedDate = (DateTime)dTable.Rows[0]["CheckedDate"];
                    if (dTable.Rows[0]["DeliveredBy"].Equals(DBNull.Value))
                        _DeliveredBy = string.Empty;
                    else
                        _DeliveredBy = (string)dTable.Rows[0]["DeliveredBy"];
                    if (dTable.Rows[0]["DeliveryDate"].Equals(DBNull.Value))
                        _DeliveryDate = DateTime.MinValue;
                    else
                        _DeliveryDate = (DateTime)dTable.Rows[0]["DeliveryDate"];
                    if (dTable.Rows[0]["IssuedToDeliveryPersonGuid"].Equals(DBNull.Value))
                        _IssuedToDeliveryPersonGuid = string.Empty;
                    else
                        _IssuedToDeliveryPersonGuid = (string)dTable.Rows[0]["IssuedToDeliveryPersonGuid"];
                    if (dTable.Rows[0]["PurchaseOrderType"].Equals(DBNull.Value))
                        _PurchaseOrderType = 0;
                    else
                        _PurchaseOrderType = (int)dTable.Rows[0]["PurchaseOrderType"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactions::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblStoreTransactions";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblStoreTransactions");
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
                throw new Exception("CStoreTransactions::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblStoreTransactions" +
                                   " (PurchaseOrderGuid, " +
                                   " InvoiceGuid, " +
                                   " StoreGuid, " +
                                   " ReferenceNumber, " +
                                   " TransactionType, " +
                                   " TransactionBy, " +
                                   " TransactionDate, " +
                                   " CheckedBy, " +
                                   " CheckedDate, " +
                                   " DeliveredBy, " +
                                   " DeliveryDate, " +
                                   " IssuedToDeliveryPersonGuid,PurchaseOrderType)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @InvoiceGuid, " +
                                   " @StoreGuid, " +
                                   " @ReferenceNumber, " +
                                   " @TransactionType, " +
                                   " @TransactionBy, " +
                                   " @TransactionDate, " +
                                   " @CheckedBy, " +
                                   " @CheckedDate, " +
                                   " @DeliveredBy, " +
                                   " @DeliveryDate, " +
                                   " @IssuedToDeliveryPersonGuid,@PurchaseOrderType)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_PurchaseOrderGuid != null)
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                else
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", DBNull.Value));
                if (_InvoiceGuid != null)
                    command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceGuid", DBNull.Value));
                
                command.Parameters.Add(new SqlParameter("@StoreGuid", _StoreGuid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@TransactionType", _TransactionType));
                command.Parameters.Add(new SqlParameter("@TransactionBy", _TransactionBy));
                if (_TransactionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@TransactionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TransactionDate", _TransactionDate));
                command.Parameters.Add(new SqlParameter("@CheckedBy", _CheckedBy));
                if (_CheckedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckedDate", _CheckedDate));

                if(_DeliveredBy == string.Empty)
                    command.Parameters.Add(new SqlParameter("@DeliveredBy", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DeliveredBy", _DeliveredBy));
                
                if (_DeliveryDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", _DeliveryDate));
                if(_IssuedToDeliveryPersonGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@IssuedToDeliveryPersonGuid", DBNull.Value));
                else    
                    command.Parameters.Add(new SqlParameter("@IssuedToDeliveryPersonGuid", _IssuedToDeliveryPersonGuid));
                command.Parameters.Add(new SqlParameter("@PurchaseOrderType", _PurchaseOrderType));


                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactions::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblStoreTransactions" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " InvoiceGuid = @InvoiceGuid, " +
                                   " StoreGuid = @StoreGuid, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " TransactionType = @TransactionType, " +
                                   " TransactionBy = @TransactionBy, " +
                                   " TransactionDate = @TransactionDate, " +
                                   " CheckedBy = @CheckedBy, " +
                                   " CheckedDate = @CheckedDate, " +
                                   " DeliveredBy = @DeliveredBy, " +
                                   " DeliveryDate = @DeliveryDate, " +
                                   " IssuedToDeliveryPersonGuid = @IssuedToDeliveryPersonGuid, " +
                                   " PurchaseOrderType = @PurchaseOrderType " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {

                if (_PurchaseOrderGuid != null)
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                else
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", string.Empty));
                if (_InvoiceGuid != null)
                    command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceGuid", string.Empty));
                command.Parameters.Add(new SqlParameter("@StoreGuid", _StoreGuid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@TransactionType", _TransactionType));
                command.Parameters.Add(new SqlParameter("@TransactionBy", _TransactionBy));
                if (_TransactionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@TransactionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TransactionDate", _TransactionDate));
                command.Parameters.Add(new SqlParameter("@CheckedBy", _CheckedBy));
                if (_CheckedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckedDate", _CheckedDate));
                command.Parameters.Add(new SqlParameter("@DeliveredBy", _DeliveredBy));
                if (_DeliveryDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", _DeliveryDate));
                
                if (_IssuedToDeliveryPersonGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@IssuedToDeliveryPersonGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@IssuedToDeliveryPersonGuid", _IssuedToDeliveryPersonGuid));

                command.Parameters.Add(new SqlParameter("@PurchaseOrderType", _PurchaseOrderType));


                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactions::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblStoreTransactions Where Id = @Id ";
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
                throw new Exception("CStoreTransactions::Delete::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblStoreTransactions] ";
            command.CommandText += " WHERE StoreGuid = @StoreGuid ";
            command.CommandText += " AND ReferenceNumber = @ReferenceNumber ";
            command.CommandText += " AND TransactionType = @TransactionType ";
            if (!bNew)
                command.CommandText += " AND Id <> @Id";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@StoreGuid", _StoreGuid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@TransactionType", _TransactionType));
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
                throw new Exception("CStoreTransactions::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int InvoiceExists(bool bNew)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT Id FROM [dbo].[tblStoreTransactions] ";
            command.CommandText += " WHERE TransactionType = @TransactionType ";
            if (_TransactionType == (int)CCommon.StoreTransactionType.Receiving)
                command.CommandText += " AND PurchaseOrderGuid = @PurchaseOrderGuid ";
            if (_TransactionType == (int)CCommon.StoreTransactionType.Issuance)
                command.CommandText += " AND InvoiceGuid = @InvoiceGuid ";
            if (!bNew)
                command.CommandText += " AND Id <> @Id";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TransactionType == (int)CCommon.StoreTransactionType.Receiving)
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                if (_TransactionType == (int)CCommon.StoreTransactionType.Issuance)
                    command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));
                command.Parameters.Add(new SqlParameter("@TransactionType", _TransactionType));
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
                throw new Exception("CStoreTransactions::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Purchaseorderguid, string Invoiceguid, string Storeguid, string Referencenumber, int Transactiontype, string Transactionby, DateTime Transactiondate, string Checkedby, DateTime Checkeddate, string Deliveredby, DateTime Deliverydate, string Issuedto)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblStoreTransactions" +
                                   " (PurchaseOrderGuid, " +
                                   " InvoiceGuid, " +
                                   " StoreGuid, " +
                                   " ReferenceNumber, " +
                                   " TransactionType, " +
                                   " TransactionBy, " +
                                   " TransactionDate, " +
                                   " CheckedBy, " +
                                   " CheckedDate, " +
                                   " DeliveredBy, " +
                                   " DeliveryDate, " +
                                   " IssuedToDeliveryPersonGuid)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @InvoiceGuid, " +
                                   " @StoreGuid, " +
                                   " @ReferenceNumber, " +
                                   " @TransactionType, " +
                                   " @TransactionBy, " +
                                   " @TransactionDate, " +
                                   " @CheckedBy, " +
                                   " @CheckedDate, " +
                                   " @DeliveredBy, " +
                                   " @DeliveryDate, " +
                                   " @IssuedToDeliveryPersonGuid)" +
                                   " Select @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", Invoiceguid));
                command.Parameters.Add(new SqlParameter("@StoreGuid", Storeguid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@TransactionType", Transactiontype));
                command.Parameters.Add(new SqlParameter("@TransactionBy", Transactionby));
                if (Transactiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@TransactionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TransactionDate", Transactiondate));
                command.Parameters.Add(new SqlParameter("@CheckedBy", Checkedby));
                if (Checkeddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckedDate", Checkeddate));
                command.Parameters.Add(new SqlParameter("@DeliveredBy", Deliveredby));
                if (Deliverydate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", Deliverydate));
                command.Parameters.Add(new SqlParameter("@IssuedToDeliveryPersonGuid", Issuedto));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactions::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Purchaseorderguid, string Invoiceguid, string Storeguid, string Referencenumber, int Transactiontype, string Transactionby, DateTime Transactiondate, string Checkedby, DateTime Checkeddate, string Deliveredby, DateTime Deliverydate, string Issuedto)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblStoreTransactions" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " InvoiceGuid = @InvoiceGuid, " +
                                   " StoreGuid = @StoreGuid, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " TransactionType = @TransactionType, " +
                                   " TransactionBy = @TransactionBy, " +
                                   " TransactionDate = @TransactionDate, " +
                                   " CheckedBy = @CheckedBy, " +
                                   " CheckedDate = @CheckedDate, " +
                                   " DeliveredBy = @DeliveredBy, " +
                                   " DeliveryDate = @DeliveryDate, " +
                                   " IssuedToDeliveryPersonGuid = @IssuedToDeliveryPersonGuid " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", Invoiceguid));
                command.Parameters.Add(new SqlParameter("@StoreGuid", Storeguid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@TransactionType", Transactiontype));
                command.Parameters.Add(new SqlParameter("@TransactionBy", Transactionby));
                if (Transactiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@TransactionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TransactionDate", Transactiondate));
                command.Parameters.Add(new SqlParameter("@CheckedBy", Checkedby));
                if (Checkeddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckedDate", Checkeddate));
                command.Parameters.Add(new SqlParameter("@DeliveredBy", Deliveredby));
                if (Deliverydate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DeliveryDate", Deliverydate));
                command.Parameters.Add(new SqlParameter("@IssuedToDeliveryPersonGuid", Issuedto));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactions::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblStoreTransactions Where Id = @Id ";
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
                throw new Exception("CStoreTransactions::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Purchaseorderguid, string Invoiceguid, string Storeguid, string Referencenumber, int Transactiontype)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT Id FROM [dbo].[tblStoreTransactions] ";
            command.CommandText += " WHERE StoreGuid = @StoreGuid ";
            if (Transactiontype == (int)CCommon.StoreTransactionType.Receiving)
                command.CommandText += " AND PurchaseOrderGuid = @PurchaseOrderGuid ";
            if (Transactiontype == (int)CCommon.StoreTransactionType.Issuance)
                command.CommandText += " AND InvoiceGuid = @InvoiceGuid ";
            command.CommandText += " AND ReferenceNumber = @ReferenceNumber ";
            command.CommandText += " AND TransactionType = @TransactionType ";
            if (!bNew)
                command.CommandText += " AND Id <> @Id";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@StoreGuid", Storeguid));
                if (Transactiontype == (int)CCommon.StoreTransactionType.Receiving)
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                if (Transactiontype == (int)CCommon.StoreTransactionType.Issuance)
                    command.Parameters.Add(new SqlParameter("@InvoiceGuid", Invoiceguid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@TransactionType", Transactiontype));
                if (!bNew)
                    command.Parameters.Add(new SqlParameter("@Id", Id));
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
                throw new Exception("CStoreTransactions::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CStoreTransactions> GetList()
        {
            List<CStoreTransactions> RecordsList = new List<CStoreTransactions>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblStoreTransactions";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStoreTransactions objCStoreTransactions = new CStoreTransactions();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCStoreTransactions.Id = 0;
                    else
                        objCStoreTransactions.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.Purchaseorderguid = string.Empty;
                    else
                        objCStoreTransactions.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["InvoiceGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.Invoiceguid = string.Empty;
                    else
                        objCStoreTransactions.Invoiceguid = (string)dr["InvoiceGuid"];
                    if (dr["StoreGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.Storeguid = string.Empty;
                    else
                        objCStoreTransactions.Storeguid = (string)dr["StoreGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCStoreTransactions.ReferenceNumber = string.Empty;
                    else
                        objCStoreTransactions.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["TransactionType"].Equals(DBNull.Value))
                        objCStoreTransactions.TransactionType = 0;
                    else
                        objCStoreTransactions.TransactionType = (int)dr["TransactionType"];
                    if (dr["TransactionBy"].Equals(DBNull.Value))
                        objCStoreTransactions.TransactionBy = string.Empty;
                    else
                        objCStoreTransactions.TransactionBy = (string)dr["TransactionBy"];
                    if (dr["TransactionDate"].Equals(DBNull.Value))
                        objCStoreTransactions.TransactionDate = DateTime.MinValue;
                    else
                        objCStoreTransactions.TransactionDate = (DateTime)dr["TransactionDate"];
                    if (dr["CheckedBy"].Equals(DBNull.Value))
                        objCStoreTransactions.CheckedBy = string.Empty;
                    else
                        objCStoreTransactions.CheckedBy = (string)dr["CheckedBy"];
                    if (dr["CheckedDate"].Equals(DBNull.Value))
                        objCStoreTransactions.CheckedDate = DateTime.MinValue;
                    else
                        objCStoreTransactions.CheckedDate = (DateTime)dr["CheckedDate"];
                    if (dr["DeliveredBy"].Equals(DBNull.Value))
                        objCStoreTransactions.DeliveredBy = string.Empty;
                    else
                        objCStoreTransactions.DeliveredBy = (string)dr["DeliveredBy"];
                    if (dr["DeliveryDate"].Equals(DBNull.Value))
                        objCStoreTransactions.DeliveryDate = DateTime.MinValue;
                    else
                        objCStoreTransactions.DeliveryDate = (DateTime)dr["DeliveryDate"];
                    if (dr["IssuedToDeliveryPersonGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.IssuedToDeliveryPersonGuid = string.Empty;
                    else
                        objCStoreTransactions.IssuedToDeliveryPersonGuid = (string)dr["IssuedToDeliveryPersonGuid"];
                    if (dr["PurchaseOrderType"].Equals(DBNull.Value))
                        objCStoreTransactions.PurchaseOrderType = 0;
                    else
                        objCStoreTransactions.PurchaseOrderType = (int)dr["PurchaseOrderType"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.Tablerowguid = string.Empty;
                    else
                        objCStoreTransactions.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCStoreTransactions);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactions::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CStoreTransactions> GetList(string strCriteria)
        {
            List<CStoreTransactions> RecordsList = new List<CStoreTransactions>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select tblStoreTransactions.*,tblStores.name as StoreName, tblInvoices.ReferenceNumber AS InvoiceNumber,tblLocations.name as LocationName ";
            strSQL = strSQL + " from tblStoreTransactions join tblStores on (tblStoreTransactions.StoreGuid = tblStores.TableRowGuid) join ";
            strSQL = strSQL + " tblLocations on (tblStores.LocationGuid =tblLocations.TableRowGuid ) Left Outer Join ";
            strSQL = strSQL + " tblInvoices on (tblStoreTransactions.InvoiceGuid = tblInvoices.TableRowGuid ) ";
            strSQL = strSQL + " Where 1=1 " + strCriteria;
            strSQL = strSQL + " Order By tblInvoices.ReferenceNumber ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStoreTransactions objCStoreTransactions = new CStoreTransactions();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCStoreTransactions.Id = 0;
                    else
                        objCStoreTransactions.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.Purchaseorderguid = string.Empty;
                    else
                        objCStoreTransactions.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["InvoiceGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.Invoiceguid = string.Empty;
                    else
                        objCStoreTransactions.Invoiceguid = (string)dr["InvoiceGuid"];
                    if (dr["StoreGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.Storeguid = string.Empty;
                    else
                        objCStoreTransactions.Storeguid = (string)dr["StoreGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCStoreTransactions.ReferenceNumber = string.Empty;
                    else
                        objCStoreTransactions.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["TransactionType"].Equals(DBNull.Value))
                        objCStoreTransactions.TransactionType = 0;
                    else
                        objCStoreTransactions.TransactionType = (int)dr["TransactionType"];
                    if (dr["TransactionBy"].Equals(DBNull.Value))
                        objCStoreTransactions.TransactionBy = string.Empty;
                    else
                        objCStoreTransactions.TransactionBy = (string)dr["TransactionBy"];
                    if (dr["TransactionDate"].Equals(DBNull.Value))
                        objCStoreTransactions.TransactionDate = DateTime.MinValue;
                    else
                        objCStoreTransactions.TransactionDate = (DateTime)dr["TransactionDate"];
                    if (dr["CheckedBy"].Equals(DBNull.Value))
                        objCStoreTransactions.CheckedBy = string.Empty;
                    else
                        objCStoreTransactions.CheckedBy = (string)dr["CheckedBy"];
                    if (dr["CheckedDate"].Equals(DBNull.Value))
                        objCStoreTransactions.CheckedDate = DateTime.MinValue;
                    else
                        objCStoreTransactions.CheckedDate = (DateTime)dr["CheckedDate"];
                    if (dr["DeliveredBy"].Equals(DBNull.Value))
                        objCStoreTransactions.DeliveredBy = string.Empty;
                    else
                        objCStoreTransactions.DeliveredBy = (string)dr["DeliveredBy"];
                    if (dr["DeliveryDate"].Equals(DBNull.Value))
                        objCStoreTransactions.DeliveryDate = DateTime.MinValue;
                    else
                        objCStoreTransactions.DeliveryDate = (DateTime)dr["DeliveryDate"];
                    if (dr["StoreName"].Equals(DBNull.Value))
                        objCStoreTransactions.StoreName = string.Empty;
                    else
                        objCStoreTransactions.StoreName = (string)dr["StoreName"];
                    if (dr["LocationName"].Equals(DBNull.Value))
                        objCStoreTransactions.LocationName = string.Empty;
                    else
                        objCStoreTransactions.LocationName = (string)dr["LocationName"];
                    if (dr["IssuedToDeliveryPersonGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.IssuedToDeliveryPersonGuid = string.Empty;
                    else
                        objCStoreTransactions.IssuedToDeliveryPersonGuid = (string)dr["IssuedToDeliveryPersonGuid"];
                    if (dr["InvoiceNumber"].Equals(DBNull.Value))
                        objCStoreTransactions.InvoiceNumber = string.Empty;
                    else
                        objCStoreTransactions.InvoiceNumber = (string)dr["InvoiceNumber"];
                    if (dr["PurchaseOrderType"].Equals(DBNull.Value))
                        objCStoreTransactions.PurchaseOrderType = 0;
                    else
                        objCStoreTransactions.PurchaseOrderType = (int)dr["PurchaseOrderType"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCStoreTransactions.Tablerowguid = string.Empty;
                    else
                        objCStoreTransactions.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCStoreTransactions);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactions::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public static int GetMaxReferenceNumber(int transType)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            string strCount = "Select Count(*) from tblStoreTransactions Where TransactionType = " + transType.ToString();
            string strMAX = "Select MAX(CAST(ReferenceNumber AS int)) from tblStoreTransactions Where TransactionType = " + transType.ToString();

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
                throw new Exception("CStoreTransactions::GetMaxReferenceNumber::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblStoreTransactions] WHERE Id = @Id";
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
                throw new Exception("CStoreTransactions::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblStoreTransactions] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CStoreTransactions::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
