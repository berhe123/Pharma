//
// ...
// Wizard generated code
// Date: 8/15/2009 3:31:03 PM
// Class: CPurchaseOrders
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
    class CPurchaseOrders
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CPurchaseOrders()
        {
            _ConnectionString = ConnectionString;
        }
        public CPurchaseOrders(int Id, string Ordernumber, DateTime Orderdate, string Manufacturerproformaguid, string Termsofcontract, int Currencytype, decimal Freightcharge, decimal Exchangerate, string Placeoforigin, string Placeofdestination, int Ordertype, int Orderstatus)
        {
            _Id = Id;
            _OrderNumber = Ordernumber;
            _OrderDate = Orderdate;
            _ManufacturerProformaGuid = Manufacturerproformaguid;
            _TermsOfContract = Termsofcontract;
            _CurrencyType = Currencytype;
            _FreightCharge = Freightcharge;
            _ExchangeRate = Exchangerate;
            _PlaceOfOrigin = Placeoforigin;
            _PlaceOfDestination = Placeofdestination;
            _OrderType = Ordertype;
            _OrderStatus = Orderstatus;
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

        string _ManufacturerProformaGuid;
        public string Manufacturerproformaguid
        {
            get { return _ManufacturerProformaGuid; }
            set { _ManufacturerProformaGuid = value; }
        }

        string _TermsOfContract;
        public string Termsofcontract
        {
            get { return _TermsOfContract; }
            set { _TermsOfContract = value; }
        }

        int _CurrencyType;
        public int Currencytype
        {
            get { return _CurrencyType; }
            set { _CurrencyType = value; }
        }

        decimal _FreightCharge;
        public decimal Freightcharge
        {
            get { return _FreightCharge; }
            set { _FreightCharge = value; }
        }

        decimal _ExchangeRate;
        public decimal ExchangeRate
        {
            get { return _ExchangeRate; }
            set { _ExchangeRate = value; }
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
            command.CommandText = "Select * from tblPurchaseOrders where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrders");
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
                    if (dTable.Rows[0]["ManufacturerProformaGuid"].Equals(DBNull.Value))
                        _ManufacturerProformaGuid = string.Empty;
                    else
                        _ManufacturerProformaGuid = (string)dTable.Rows[0]["ManufacturerProformaGuid"];
                    if (dTable.Rows[0]["TermsOfContract"].Equals(DBNull.Value))
                        _TermsOfContract = string.Empty;
                    else
                        _TermsOfContract = (string)dTable.Rows[0]["TermsOfContract"];
                    if (dTable.Rows[0]["CurrencyType"].Equals(DBNull.Value))
                        _CurrencyType = 0;
                    else
                        _CurrencyType = (int)dTable.Rows[0]["CurrencyType"];
                    if (dTable.Rows[0]["FreightCharge"].Equals(DBNull.Value))
                        _FreightCharge = 0;
                    else
                        _FreightCharge = (decimal)dTable.Rows[0]["FreightCharge"];
                    if (dTable.Rows[0]["ExchangeRate"].Equals(DBNull.Value))
                        _ExchangeRate = 0;
                    else
                        _ExchangeRate = (decimal)dTable.Rows[0]["ExchangeRate"];
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
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecord(string Manufacturerproformaguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrders where ManufacturerProformaGuid=@ManufacturerProformaGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrders");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", Manufacturerproformaguid));
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
                    if (dTable.Rows[0]["ManufacturerProformaGuid"].Equals(DBNull.Value))
                        _ManufacturerProformaGuid = string.Empty;
                    else
                        _ManufacturerProformaGuid = (string)dTable.Rows[0]["ManufacturerProformaGuid"];
                    if (dTable.Rows[0]["TermsOfContract"].Equals(DBNull.Value))
                        _TermsOfContract = string.Empty;
                    else
                        _TermsOfContract = (string)dTable.Rows[0]["TermsOfContract"];
                    if (dTable.Rows[0]["CurrencyType"].Equals(DBNull.Value))
                        _CurrencyType = 0;
                    else
                        _CurrencyType = (int)dTable.Rows[0]["CurrencyType"];
                    if (dTable.Rows[0]["FreightCharge"].Equals(DBNull.Value))
                        _FreightCharge = 0;
                    else
                        _FreightCharge = (decimal)dTable.Rows[0]["FreightCharge"];
                    if (dTable.Rows[0]["ExchangeRate"].Equals(DBNull.Value))
                        _ExchangeRate = 0;
                    else
                        _ExchangeRate = (decimal)dTable.Rows[0]["ExchangeRate"];
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
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblPurchaseOrders";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrders");
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
                throw new Exception("CPurchaseOrders::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblPurchaseOrders" +
                                   " (OrderNumber, " +
                                   " OrderDate, " +
                                   " ManufacturerProformaGuid, " +
                                   " TermsOfContract, " +
                                   " CurrencyType, " +
                                   " FreightCharge, " +
                                   " ExchangeRate, " +
                                   " PlaceOfOrigin, " +
                                   " PlaceOfDestination, " +
                                   " OrderType, " +
                                   " OrderStatus,UserId,ComputerName,EventSource)" +
                                   " Values (@OrderNumber, " +
                                   " @OrderDate, " +
                                   " @ManufacturerProformaGuid, " +
                                   " @TermsOfContract, " +
                                   " @CurrencyType, " +
                                   " @FreightCharge, " +
                                   " @ExchangeRate, " +
                                   " @PlaceOfOrigin, " +
                                   " @PlaceOfDestination, " +
                                   " @OrderType, " +
                                   " @OrderStatus,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblPurchaseOrders ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@OrderNumber", _OrderNumber));
                if (_OrderDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderDate", _OrderDate));
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", _ManufacturerProformaGuid));
                command.Parameters.Add(new SqlParameter("@TermsOfContract", _TermsOfContract));
                command.Parameters.Add(new SqlParameter("@CurrencyType", _CurrencyType));
                command.Parameters.Add(new SqlParameter("@FreightCharge", _FreightCharge));
                command.Parameters.Add(new SqlParameter("@ExchangeRate", _ExchangeRate));
                command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", _PlaceOfOrigin));
                command.Parameters.Add(new SqlParameter("@PlaceOfDestination", _PlaceOfDestination));
                command.Parameters.Add(new SqlParameter("@OrderType", _OrderType));
                command.Parameters.Add(new SqlParameter("@OrderStatus", _OrderStatus));

                command.Parameters.Add(new SqlParameter("@UserId", Program.strUserName));
                command.Parameters.Add(new SqlParameter("@ComputerName", System.Windows.Forms.SystemInformation.ComputerName));
                command.Parameters.Add(new SqlParameter("@EventSource", 1));
                
                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblPurchaseOrders" +
                                   " Set OrderNumber = @OrderNumber, " +
                                   " OrderDate = @OrderDate, " +
                                   " ManufacturerProformaGuid = @ManufacturerProformaGuid, " +
                                   " TermsOfContract = @TermsOfContract, " +
                                   " CurrencyType = @CurrencyType, " +
                                   " FreightCharge = @FreightCharge, " +
                                   " ExchangeRate = @ExchangeRate, " +
                                   " PlaceOfOrigin = @PlaceOfOrigin, " +
                                   " PlaceOfDestination = @PlaceOfDestination, " +
                                   " OrderType = @OrderType, " +
                                   " OrderStatus = @OrderStatus, " +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@OrderNumber", _OrderNumber));
                if (_OrderDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderDate", _OrderDate));
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", _ManufacturerProformaGuid));
                command.Parameters.Add(new SqlParameter("@TermsOfContract", _TermsOfContract));
                command.Parameters.Add(new SqlParameter("@CurrencyType", _CurrencyType));
                command.Parameters.Add(new SqlParameter("@FreightCharge", _FreightCharge));
                command.Parameters.Add(new SqlParameter("@ExchangeRate", _ExchangeRate));
                command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", _PlaceOfOrigin));
                command.Parameters.Add(new SqlParameter("@PlaceOfDestination", _PlaceOfDestination));
                command.Parameters.Add(new SqlParameter("@OrderType", _OrderType));
                command.Parameters.Add(new SqlParameter("@OrderStatus", _OrderStatus));

                command.Parameters.Add(new SqlParameter("@UserId", Program.strUserName));
                command.Parameters.Add(new SqlParameter("@ComputerName", System.Windows.Forms.SystemInformation.ComputerName));
                command.Parameters.Add(new SqlParameter("@EventSource", 1));
                
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblPurchaseOrders Where Id = @Id ";
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
                throw new Exception("CPurchaseOrders::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrders] WHERE " +
                                       " OrderNumber = @OrderNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrders] WHERE " +
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
                throw new Exception("CPurchaseOrders::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Ordernumber, DateTime Orderdate, string Manufacturerproformaguid, string Termsofcontract, int Currencytype, decimal Freightcharge, decimal Exchangerate, string Placeoforigin, string Placeofdestination, int Ordertype, int Orderstatus)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblPurchaseOrders" +
                                   " (OrderNumber, " +
                                   " OrderDate, " +
                                   " ManufacturerProformaGuid, " +
                                   " TermsOfContract, " +
                                   " CurrencyType, " +
                                   " FreightCharge, " +
                                   " ExchangeRate, " +
                                   " PlaceOfOrigin, " +
                                   " PlaceOfDestination, " +
                                   " OrderType, " +
                                   " OrderStatus)" +
                                   " Values (@OrderNumber, " +
                                   " @OrderDate, " +
                                   " @ManufacturerProformaGuid, " +
                                   " @TermsOfContract, " +
                                   " @CurrencyType, " +
                                   " @FreightCharge, " +
                                   " @ExchangeRate, " +
                                   " @PlaceOfOrigin, " +
                                   " @PlaceOfDestination, " +
                                   " @OrderType, " +
                                   " @OrderStatus)" +
                                   " Select @Id=Max(id) from tblPurchaseOrders ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@OrderNumber", Ordernumber));
                if (Orderdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderDate", Orderdate));
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", Manufacturerproformaguid));
                command.Parameters.Add(new SqlParameter("@TermsOfContract", Termsofcontract));
                command.Parameters.Add(new SqlParameter("@CurrencyType", Currencytype));
                command.Parameters.Add(new SqlParameter("@FreightCharge", Freightcharge));
                command.Parameters.Add(new SqlParameter("@ExchangeRate", Exchangerate));
                command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", Placeoforigin));
                command.Parameters.Add(new SqlParameter("@PlaceOfDestination", Placeofdestination));
                command.Parameters.Add(new SqlParameter("@OrderType", Ordertype));
                command.Parameters.Add(new SqlParameter("@OrderStatus", Orderstatus));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Ordernumber, DateTime Orderdate, string Manufacturerproformaguid, string Termsofcontract, int Currencytype, decimal Freightcharge, decimal Exchangerate, string Placeoforigin, string Placeofdestination, int Ordertype, int Orderstatus)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblPurchaseOrders" +
                                   " Set OrderNumber = @OrderNumber, " +
                                   " OrderDate = @OrderDate, " +
                                   " ManufacturerProformaGuid = @ManufacturerProformaGuid, " +
                                   " TermsOfContract = @TermsOfContract, " +
                                   " CurrencyType = @CurrencyType, " +
                                   " FreightCharge = @FreightCharge, " +
                                   " ExchangeRate = @ExchangeRate, " +
                                   " PlaceOfOrigin = @PlaceOfOrigin, " +
                                   " PlaceOfDestination = @PlaceOfDestination, " +
                                   " OrderType = @OrderType, " +
                                   " OrderStatus = @OrderStatus " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@OrderNumber", Ordernumber));
                if (Orderdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@OrderDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@OrderDate", Orderdate));
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", Manufacturerproformaguid));
                command.Parameters.Add(new SqlParameter("@TermsOfContract", Termsofcontract));
                command.Parameters.Add(new SqlParameter("@CurrencyType", Currencytype));
                command.Parameters.Add(new SqlParameter("@FreightCharge", Freightcharge));
                command.Parameters.Add(new SqlParameter("@ExchangeRate", Exchangerate));
                command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", Placeoforigin));
                command.Parameters.Add(new SqlParameter("@PlaceOfDestination", Placeofdestination));
                command.Parameters.Add(new SqlParameter("@OrderType", Ordertype));
                command.Parameters.Add(new SqlParameter("@OrderStatus", Orderstatus));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblPurchaseOrders Where Id = @Id ";
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
                throw new Exception("CPurchaseOrders::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Ordernumber)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrders] WHERE " +
                                       " OrderNumber = @OrderNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrders] WHERE " +
                                       " OrderNumber = @OrderNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@OrderNumber", Ordernumber));
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
                throw new Exception("CPurchaseOrders::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CPurchaseOrders> GetList(bool NotReceived)
        {
            List<CPurchaseOrders> RecordsList = new List<CPurchaseOrders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrders";
            if (NotReceived)
                command.CommandText += " Where tblPurchaseOrders.TableRowGuid not in (select distinct ISNULL(PurchaseOrderGuid,'') from tblStoreTransactions) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CPurchaseOrders objCPurchaseOrders = new CPurchaseOrders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrders.Id = 0;
                    else
                        objCPurchaseOrders.Id = (int)dr["Id"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objCPurchaseOrders.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objCPurchaseOrders.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["ManufacturerProformaGuid"].Equals(DBNull.Value))
                        objCPurchaseOrders.Manufacturerproformaguid = string.Empty;
                    else
                        objCPurchaseOrders.Manufacturerproformaguid = (string)dr["ManufacturerProformaGuid"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCPurchaseOrders.Termsofcontract = string.Empty;
                    else
                        objCPurchaseOrders.Termsofcontract = (string)dr["TermsOfContract"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCPurchaseOrders.Currencytype = 0;
                    else
                        objCPurchaseOrders.Currencytype = (int)dr["CurrencyType"];
                    if (dr["FreightCharge"].Equals(DBNull.Value))
                        objCPurchaseOrders.Freightcharge = 0;
                    else
                        objCPurchaseOrders.Freightcharge = (decimal)dr["FreightCharge"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objCPurchaseOrders.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objCPurchaseOrders.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["OrderType"].Equals(DBNull.Value))
                        objCPurchaseOrders.Ordertype = 0;
                    else
                        objCPurchaseOrders.Ordertype = (int)dr["OrderType"];
                    if (dr["OrderStatus"].Equals(DBNull.Value))
                        objCPurchaseOrders.Orderstatus = 0;
                    else
                        objCPurchaseOrders.Orderstatus = (int)dr["OrderStatus"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrders.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrders);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CPurchaseOrders> GetList(string Manufacturerguid, bool NotReceived)
        {
            List<CPurchaseOrders> RecordsList = new List<CPurchaseOrders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " SELECT   tblPurchaseOrders.Id, tblPurchaseOrders.TableRowGuid, tblPurchaseOrders.OrderNumber, tblPurchaseOrders.OrderDate, tblPurchaseOrders.ManufacturerProformaGuid,  ";
            strSQL = strSQL + "                tblPurchaseOrders.TermsOfContract, tblManufacturerProformas.ManufacturerGuid, tblPurchaseOrders.CurrencyType, tblPurchaseOrders.FreightCharge, ";
            strSQL = strSQL + "                tblPurchaseOrders.PlaceOfOrigin, tblPurchaseOrders.PlaceOfDestination, tblPurchaseOrders.OrderType, tblPurchaseOrders.OrderStatus  ";
            strSQL = strSQL + " FROM      tblPurchaseOrders INNER JOIN ";
            strSQL = strSQL + "                tblManufacturerProformas ON tblPurchaseOrders.ManufacturerProformaGuid = tblManufacturerProformas.TableRowGuid ";
            strSQL = strSQL + " Where tblManufacturerProformas.ManufacturerGuid = @ManufacturerGuid ";
            if (NotReceived)
                strSQL += " AND tblPurchaseOrders.TableRowGuid not in (select distinct ISNULL(PurchaseOrderGuid,'') from tblStoreTransactions) ";

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
                    CPurchaseOrders objCPurchaseOrders = new CPurchaseOrders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrders.Id = 0;
                    else
                        objCPurchaseOrders.Id = (int)dr["Id"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objCPurchaseOrders.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objCPurchaseOrders.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["ManufacturerProformaGuid"].Equals(DBNull.Value))
                        objCPurchaseOrders.Manufacturerproformaguid = string.Empty;
                    else
                        objCPurchaseOrders.Manufacturerproformaguid = (string)dr["ManufacturerProformaGuid"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCPurchaseOrders.Termsofcontract = string.Empty;
                    else
                        objCPurchaseOrders.Termsofcontract = (string)dr["TermsOfContract"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCPurchaseOrders.Currencytype = 0;
                    else
                        objCPurchaseOrders.Currencytype = (int)dr["CurrencyType"];
                    if (dr["FreightCharge"].Equals(DBNull.Value))
                        objCPurchaseOrders.Freightcharge = 0;
                    else
                        objCPurchaseOrders.Freightcharge = (decimal)dr["FreightCharge"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objCPurchaseOrders.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objCPurchaseOrders.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["OrderType"].Equals(DBNull.Value))
                        objCPurchaseOrders.Ordertype = 0;
                    else
                        objCPurchaseOrders.Ordertype = (int)dr["OrderType"];
                    if (dr["OrderStatus"].Equals(DBNull.Value))
                        objCPurchaseOrders.Orderstatus = 0;
                    else
                        objCPurchaseOrders.Orderstatus = (int)dr["OrderStatus"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrders.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrders);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CPurchaseOrders> GetList(DateTime OrderDateFrom, DateTime OrderDateTo, bool NotReceived)
        {
            List<CPurchaseOrders> RecordsList = new List<CPurchaseOrders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " SELECT   tblPurchaseOrders.Id, tblPurchaseOrders.TableRowGuid, tblPurchaseOrders.OrderNumber, tblPurchaseOrders.OrderDate,  ";
            strSQL = strSQL + "                tblPurchaseOrders.TermsOfContract, tblPurchaseOrders.CurrencyType, tblPurchaseOrders.FreightCharge, ";
            strSQL = strSQL + "                tblPurchaseOrders.PlaceOfOrigin, tblPurchaseOrders.PlaceOfDestination, tblPurchaseOrders.OrderType, tblPurchaseOrders.OrderStatus  ";
            strSQL = strSQL + " FROM      tblPurchaseOrders ";
            strSQL = strSQL + " Where tblPurchaseOrders.OrderDate >= @OrderDateFrom ";
            strSQL = strSQL + " And tblPurchaseOrders.OrderDate <= @OrderDateTo ";
            if (NotReceived)
                strSQL += " AND tblPurchaseOrders.TableRowGuid not in (select distinct ISNULL(PurchaseOrderGuid,'') from tblStoreTransactions) ";

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
                    CPurchaseOrders objCPurchaseOrders = new CPurchaseOrders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrders.Id = 0;
                    else
                        objCPurchaseOrders.Id = (int)dr["Id"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objCPurchaseOrders.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objCPurchaseOrders.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["ManufacturerProformaGuid"].Equals(DBNull.Value))
                        objCPurchaseOrders.Manufacturerproformaguid = string.Empty;
                    else
                        objCPurchaseOrders.Manufacturerproformaguid = (string)dr["ManufacturerProformaGuid"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCPurchaseOrders.Termsofcontract = string.Empty;
                    else
                        objCPurchaseOrders.Termsofcontract = (string)dr["TermsOfContract"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCPurchaseOrders.Currencytype = 0;
                    else
                        objCPurchaseOrders.Currencytype = (int)dr["CurrencyType"];
                    if (dr["FreightCharge"].Equals(DBNull.Value))
                        objCPurchaseOrders.Freightcharge = 0;
                    else
                        objCPurchaseOrders.Freightcharge = (decimal)dr["FreightCharge"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objCPurchaseOrders.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objCPurchaseOrders.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["OrderType"].Equals(DBNull.Value))
                        objCPurchaseOrders.Ordertype = 0;
                    else
                        objCPurchaseOrders.Ordertype = (int)dr["OrderType"];
                    if (dr["OrderStatus"].Equals(DBNull.Value))
                        objCPurchaseOrders.Orderstatus = 0;
                    else
                        objCPurchaseOrders.Orderstatus = (int)dr["OrderStatus"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrders.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrders);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CPurchaseOrders> GetList(string Manufacturerguid, DateTime OrderDateFrom, DateTime OrderDateTo, bool NotReceived)
        {
            List<CPurchaseOrders> RecordsList = new List<CPurchaseOrders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " SELECT   tblPurchaseOrders.Id, tblPurchaseOrders.TableRowGuid, tblPurchaseOrders.OrderNumber, tblPurchaseOrders.OrderDate, tblPurchaseOrders.ManufacturerProformaGuid,  ";
            strSQL = strSQL + " tblPurchaseOrders.TermsOfContract, tblManufacturerProformas.ManufacturerGuid, tblPurchaseOrders.CurrencyType, tblPurchaseOrders.FreightCharge, ";
            strSQL = strSQL + "tblPurchaseOrders.PlaceOfOrigin, tblPurchaseOrders.PlaceOfDestination, tblPurchaseOrders.OrderType, tblPurchaseOrders.OrderStatus  ";
            strSQL = strSQL + " FROM      tblPurchaseOrders INNER JOIN ";
            strSQL = strSQL + "                tblManufacturerProformas ON tblPurchaseOrders.ManufacturerProformaGuid = tblManufacturerProformas.TableRowGuid ";
            strSQL = strSQL + " Where tblManufacturerProformas.ManufacturerGuid = @ManufacturerGuid ";
            strSQL = strSQL + " And tblPurchaseOrders.OrderDate >= @OrderDateFrom ";
            strSQL = strSQL + " And tblPurchaseOrders.OrderDate <= @OrderDateTo ";
            if (NotReceived)
                strSQL += " AND tblPurchaseOrders.TableRowGuid not in (select distinct ISNULL(PurchaseOrderGuid,'') from tblStoreTransactions) ";

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
                    CPurchaseOrders objCPurchaseOrders = new CPurchaseOrders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrders.Id = 0;
                    else
                        objCPurchaseOrders.Id = (int)dr["Id"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCPurchaseOrders.Ordernumber = string.Empty;
                    else
                        objCPurchaseOrders.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCPurchaseOrders.Orderdate = DateTime.MinValue;
                    else
                        objCPurchaseOrders.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["ManufacturerProformaGuid"].Equals(DBNull.Value))
                        objCPurchaseOrders.Manufacturerproformaguid = string.Empty;
                    else
                        objCPurchaseOrders.Manufacturerproformaguid = (string)dr["ManufacturerProformaGuid"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCPurchaseOrders.Termsofcontract = string.Empty;
                    else
                        objCPurchaseOrders.Termsofcontract = (string)dr["TermsOfContract"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCPurchaseOrders.Currencytype = 0;
                    else
                        objCPurchaseOrders.Currencytype = (int)dr["CurrencyType"];
                    if (dr["FreightCharge"].Equals(DBNull.Value))
                        objCPurchaseOrders.Freightcharge = 0;
                    else
                        objCPurchaseOrders.Freightcharge = (decimal)dr["FreightCharge"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCPurchaseOrders.Placeoforigin = string.Empty;
                    else
                        objCPurchaseOrders.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCPurchaseOrders.Placeofdestination = string.Empty;
                    else
                        objCPurchaseOrders.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["OrderType"].Equals(DBNull.Value))
                        objCPurchaseOrders.Ordertype = 0;
                    else
                        objCPurchaseOrders.Ordertype = (int)dr["OrderType"];
                    if (dr["OrderStatus"].Equals(DBNull.Value))
                        objCPurchaseOrders.Orderstatus = 0;
                    else
                        objCPurchaseOrders.Orderstatus = (int)dr["OrderStatus"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrders.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrders);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrders::GetList::Error! " + ex.Message, ex);
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

            string strCount = "Select Count(*) from tblPurchaseOrders";
            string strMAX = "Select MAX(CAST(OrderNumber AS int)) from tblPurchaseOrders";

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
        public int ProformaAlreadyUsed(bool bNew, int Id, string Manufacturerproformaguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrders] WHERE " +
                                       " ManufacturerProformaGuid = @ManufacturerProformaGuid ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrders] WHERE " +
                                       " ManufacturerProformaGuid = @ManufacturerProformaGuid " +
                                       " AND Id <> @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", Manufacturerproformaguid));
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
                throw new Exception("CPurchaseOrders::ProformaAlreadyUsed::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblPurchaseOrders] WHERE Id = @Id";
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
                throw new Exception("CPurchaseOrders::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrders] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CPurchaseOrders::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
