//
// ...
// Wizard generated code
// Date: 7/20/2009 5:07:18 PM
// Class: CManufacturerProformas
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
    class CManufacturerProformas
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CManufacturerProformas()
        {
            _ConnectionString = ConnectionString;
        }
        public CManufacturerProformas(int Id, string Manufacturerguid, string Proformanumber, DateTime Proformadate, string Requestreferencenumber, DateTime Requestdate, int Dispatch, int Termsofpayment, string Termsofpaymentdetail, int Termsofshipment, string Termsofcontract, int Currencytype, decimal Freightcharge, string Placeoforigin, string Placeofdestination, int Proformatype, string Invoicenumber, DateTime Invoicedate, string Invoiceremark)
        {
            _Id = Id;
            _ManufacturerGuid = Manufacturerguid;
            _ProformaNumber = Proformanumber;
            _ProformaDate = Proformadate;
            _RequestReferenceNumber = Requestreferencenumber;
            _RequestDate = Requestdate;
            _Dispatch = Dispatch;
            _TermsOfPayment = Termsofpayment;
            _TermsOfPaymentDetail = Termsofpaymentdetail;
            _TermsOfShipment = Termsofshipment;
            _TermsOfContract = Termsofcontract;
            _CurrencyType = Currencytype;
            _FreightCharge = Freightcharge;
            _PlaceOfOrigin = Placeoforigin;
            _PlaceOfDestination = Placeofdestination;
            _ProformaType = Proformatype;
            _InvoiceNumber = Invoicenumber;
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

        string _ManufacturerGuid;
        public string Manufacturerguid
        {
            get { return _ManufacturerGuid; }
            set { _ManufacturerGuid = value; }
        }

        string _ProformaNumber;
        public string Proformanumber
        {
            get { return _ProformaNumber; }
            set { _ProformaNumber = value; }
        }

        DateTime _ProformaDate;
        public DateTime Proformadate
        {
            get { return _ProformaDate; }
            set { _ProformaDate = value; }
        }

        string _RequestReferenceNumber;
        public string Requestreferencenumber
        {
            get { return _RequestReferenceNumber; }
            set { _RequestReferenceNumber = value; }
        }

        DateTime _RequestDate;
        public DateTime Requestdate
        {
            get { return _RequestDate; }
            set { _RequestDate = value; }
        }

        int _Dispatch;
        public int Dispatch
        {
            get { return _Dispatch; }
            set { _Dispatch = value; }
        }

        int _TermsOfPayment;
        public int Termsofpayment
        {
            get { return _TermsOfPayment; }
            set { _TermsOfPayment = value; }
        }

        string _TermsOfPaymentDetail;
        public string Termsofpaymentdetail
        {
            get { return _TermsOfPaymentDetail; }
            set { _TermsOfPaymentDetail = value; }
        }

        int _TermsOfShipment;
        public int Termsofshipment
        {
            get { return _TermsOfShipment; }
            set { _TermsOfShipment = value; }
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

        string _CurrencyTypeDescription;
        public string Currencytypedescription
        {
            get { return _CurrencyTypeDescription; }
            set { _CurrencyTypeDescription = value; }
        }

        decimal _FreightCharge;
        public decimal Freightcharge
        {
            get { return _FreightCharge; }
            set { _FreightCharge = value; }
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

        int _ProformaType;
        public int Proformatype
        {
            get { return _ProformaType; }
            set { _ProformaType = value; }
        }

        string _ProformaTypeDescription;
        public string Proformatypedescription
        {
            get { return _ProformaTypeDescription; }
            set { _ProformaTypeDescription = value; }
        }

        string _InvoiceNumber;
        public string Invoicenumber
        {
            get { return _InvoiceNumber; }
            set { _InvoiceNumber = value; }
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
            command.CommandText = "Select * from tblManufacturerProformas where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblManufacturerProformas");
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
                    if (dTable.Rows[0]["ManufacturerGuid"].Equals(DBNull.Value))
                        _ManufacturerGuid = string.Empty;
                    else
                        _ManufacturerGuid = (string)dTable.Rows[0]["ManufacturerGuid"];
                    if (dTable.Rows[0]["ProformaNumber"].Equals(DBNull.Value))
                        _ProformaNumber = string.Empty;
                    else
                        _ProformaNumber = (string)dTable.Rows[0]["ProformaNumber"];
                    if (dTable.Rows[0]["ProformaDate"].Equals(DBNull.Value))
                        _ProformaDate = DateTime.MinValue;
                    else
                        _ProformaDate = (DateTime)dTable.Rows[0]["ProformaDate"];
                    if (dTable.Rows[0]["RequestReferenceNumber"].Equals(DBNull.Value))
                        _RequestReferenceNumber = string.Empty;
                    else
                        _RequestReferenceNumber = (string)dTable.Rows[0]["RequestReferenceNumber"];
                    if (dTable.Rows[0]["RequestDate"].Equals(DBNull.Value))
                        _RequestDate = DateTime.MinValue;
                    else
                        _RequestDate = (DateTime)dTable.Rows[0]["RequestDate"];
                    if (dTable.Rows[0]["Dispatch"].Equals(DBNull.Value))
                        _Dispatch = 0;
                    else
                        _Dispatch = (int)dTable.Rows[0]["Dispatch"];
                    if (dTable.Rows[0]["TermsOfPayment"].Equals(DBNull.Value))
                        _TermsOfPayment = 0;
                    else
                        _TermsOfPayment = (int)dTable.Rows[0]["TermsOfPayment"];
                    if (dTable.Rows[0]["TermsOfPaymentDetail"].Equals(DBNull.Value))
                        _TermsOfPaymentDetail = string.Empty;
                    else
                        _TermsOfPaymentDetail = (string)dTable.Rows[0]["TermsOfPaymentDetail"];
                    if (dTable.Rows[0]["TermsOfShipment"].Equals(DBNull.Value))
                        _TermsOfShipment = 0;
                    else
                        _TermsOfShipment = (int)dTable.Rows[0]["TermsOfShipment"];
                    if (dTable.Rows[0]["TermsOfContract"].Equals(DBNull.Value))
                        _TermsOfContract = string.Empty;
                    else
                        _TermsOfContract = (string)dTable.Rows[0]["TermsOfContract"];
                    if (dTable.Rows[0]["CurrencyType"].Equals(DBNull.Value))
                        _CurrencyType = 0;
                    else
                        _CurrencyType = (int)dTable.Rows[0]["CurrencyType"];
                    if (dTable.Rows[0]["CurrencyType"].Equals(DBNull.Value))
                        _CurrencyTypeDescription = string.Empty;
                    else
                        _CurrencyTypeDescription = CCommon.GetCurrencyTypeText((int)dTable.Rows[0]["CurrencyType"]);
                    if (dTable.Rows[0]["FreightCharge"].Equals(DBNull.Value))
                        _FreightCharge = 0;
                    else
                        _FreightCharge = (decimal)dTable.Rows[0]["FreightCharge"];
                    if (dTable.Rows[0]["PlaceOfOrigin"].Equals(DBNull.Value))
                        _PlaceOfOrigin = string.Empty;
                    else
                        _PlaceOfOrigin = (string)dTable.Rows[0]["PlaceOfOrigin"];
                    if (dTable.Rows[0]["PlaceOfDestination"].Equals(DBNull.Value))
                        _PlaceOfDestination = string.Empty;
                    else
                        _PlaceOfDestination = (string)dTable.Rows[0]["PlaceOfDestination"];
                    if (dTable.Rows[0]["ProformaType"].Equals(DBNull.Value))
                        _ProformaType = 0;
                    else
                        _ProformaType = (int)dTable.Rows[0]["ProformaType"];
                    if (dTable.Rows[0]["ProformaType"].Equals(DBNull.Value))
                        _ProformaTypeDescription = string.Empty;
                    else
                        _ProformaTypeDescription = CCommon.GetProformaOrderTypeText((int)dTable.Rows[0]["ProformaType"]);
                    if (dTable.Rows[0]["InvoiceNumber"].Equals(DBNull.Value))
                        _InvoiceNumber = string.Empty;
                    else
                        _InvoiceNumber = (string)dTable.Rows[0]["InvoiceNumber"];
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
                throw new Exception("CManufacturerProformas::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblManufacturerProformas";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblManufacturerProformas");
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
                throw new Exception("CManufacturerProformas::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblManufacturerProformas" +
                                   " (ManufacturerGuid, " +
                                   " ProformaNumber, " +
                                   " ProformaDate, " +
                                   " RequestReferenceNumber, " +
                                   " RequestDate, " +
                                   " Dispatch, " +
                                   " TermsOfPayment, " +
                                   " TermsOfPaymentDetail, " +
                                   " TermsOfShipment, " +
                                   " TermsOfContract, " +
                                   " CurrencyType, " +
                                   " FreightCharge, " +
                                   " PlaceOfOrigin, " +
                                   " PlaceOfDestination, " +
                                   " ProformaType, " +
                                   " InvoiceNumber, " +
                                   " InvoiceDate, " +
                                   " InvoiceRemark,UserId,ComputerName,EventSource)" +
                                   " Values (@ManufacturerGuid, " +
                                   " @ProformaNumber, " +
                                   " @ProformaDate, " +
                                   " @RequestReferenceNumber, " +
                                   " @RequestDate, " +
                                   " @Dispatch, " +
                                   " @TermsOfPayment, " +
                                   " @TermsOfPaymentDetail, " +
                                   " @TermsOfShipment, " +
                                   " @TermsOfContract, " +
                                   " @CurrencyType, " +
                                   " @FreightCharge, " +
                                   " @PlaceOfOrigin, " +
                                   " @PlaceOfDestination, " +
                                   " @ProformaType, " +
                                   " @InvoiceNumber, " +
                                   " @InvoiceDate, " +
                                   " @InvoiceRemark,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblManufacturerProformas ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", _ManufacturerGuid));
                command.Parameters.Add(new SqlParameter("@ProformaNumber", _ProformaNumber));
                if (_ProformaDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ProformaDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ProformaDate", _ProformaDate));
                if (_RequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", _RequestDate));
                command.Parameters.Add(new SqlParameter("@RequestReferenceNumber", _RequestReferenceNumber));
                command.Parameters.Add(new SqlParameter("@Dispatch", _Dispatch));
                command.Parameters.Add(new SqlParameter("@TermsOfPayment", _TermsOfPayment));
                command.Parameters.Add(new SqlParameter("@TermsOfPaymentDetail", _TermsOfPaymentDetail));
                command.Parameters.Add(new SqlParameter("@TermsOfShipment", _TermsOfShipment));
                command.Parameters.Add(new SqlParameter("@TermsOfContract", _TermsOfContract));
                command.Parameters.Add(new SqlParameter("@CurrencyType", _CurrencyType));
                command.Parameters.Add(new SqlParameter("@FreightCharge", _FreightCharge));
                command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", _PlaceOfOrigin));
                command.Parameters.Add(new SqlParameter("@PlaceOfDestination", _PlaceOfDestination));
                command.Parameters.Add(new SqlParameter("@ProformaType", _ProformaType));
                if (_InvoiceNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceNumber", DBNull.Value));

                if (_InvoiceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", _InvoiceDate));
                
                if (_InvoiceRemark ==string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", _InvoiceRemark));

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
                throw new Exception("CManufacturerProformas::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblManufacturerProformas" +
                                   " Set ManufacturerGuid = @ManufacturerGuid, " +
                                   " ProformaNumber = @ProformaNumber, " +
                                   " ProformaDate = @ProformaDate, " +
                                   " RequestReferenceNumber = @RequestReferenceNumber, " +
                                   " RequestDate = @RequestDate, " +
                                   " Dispatch = @Dispatch, " +
                                   " TermsOfPayment = @TermsOfPayment, " +
                                   " TermsOfPaymentDetail = @TermsOfPaymentDetail, " +
                                   " TermsOfShipment = @TermsOfShipment, " +
                                   " TermsOfContract = @TermsOfContract, " +
                                   " CurrencyType = @CurrencyType, " +
                                   " FreightCharge = @FreightCharge, " +
                                   " PlaceOfOrigin = @PlaceOfOrigin, " +
                                   " PlaceOfDestination = @PlaceOfDestination, " +
                                   " ProformaType = @ProformaType, " +
                                   " InvoiceNumber = @InvoiceNumber, " +
                                   " InvoiceDate = @InvoiceDate, " +
                                   " InvoiceRemark = @InvoiceRemark, " +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", _ManufacturerGuid));
                command.Parameters.Add(new SqlParameter("@ProformaNumber", _ProformaNumber));
                if (_ProformaDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ProformaDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ProformaDate", _ProformaDate));
                if (_RequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", _RequestDate));
                command.Parameters.Add(new SqlParameter("@RequestReferenceNumber", _RequestReferenceNumber));
                command.Parameters.Add(new SqlParameter("@Dispatch", _Dispatch));
                command.Parameters.Add(new SqlParameter("@TermsOfPayment", _TermsOfPayment));
                command.Parameters.Add(new SqlParameter("@TermsOfPaymentDetail", _TermsOfPaymentDetail));
                command.Parameters.Add(new SqlParameter("@TermsOfShipment", _TermsOfShipment));
                command.Parameters.Add(new SqlParameter("@TermsOfContract", _TermsOfContract));
                command.Parameters.Add(new SqlParameter("@CurrencyType", _CurrencyType));
                command.Parameters.Add(new SqlParameter("@FreightCharge", _FreightCharge));
                command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", _PlaceOfOrigin));
                command.Parameters.Add(new SqlParameter("@PlaceOfDestination", _PlaceOfDestination));
                command.Parameters.Add(new SqlParameter("@ProformaType", _ProformaType));
                if (_InvoiceNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceNumber", DBNull.Value));

                if (_InvoiceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", _InvoiceDate));

                if (_InvoiceRemark == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", _InvoiceRemark));

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
                throw new Exception("CManufacturerProformas::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblManufacturerProformas Where Id = @Id ";
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
                throw new Exception("CManufacturerProformas::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformas] WHERE " +
                                       " ProformaNumber = @ProformaNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformas] WHERE " +
                                       " ProformaNumber = @ProformaNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProformaNumber", _ProformaNumber));
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
                throw new Exception("CManufacturerProformas::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Manufacturerguid, string Proformanumber, DateTime Proformadate, string Requestreferencenumber, DateTime Requestdate, int Dispatch, int Termsofpayment, string Termsofpaymentdetail, int Termsofshipment, string Termsofcontract, int Currencytype, decimal Freightcharge, string Placeoforigin, string Placeofdestination, int Proformatype, string Invoicenumber, DateTime Invoicedate, string Invoiceremark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblManufacturerProformas" +
                                   " (ManufacturerGuid, " +
                                   " ProformaNumber, " +
                                   " ProformaDate, " +
                                   " RequestReferenceNumber, " +
                                   " RequestDate, " +
                                   " Dispatch, " +
                                   " TermsOfPayment, " +
                                   " TermsOfPaymentDetail, " +
                                   " TermsOfShipment, " +
                                   " TermsOfContract, " +
                                   " CurrencyType, " +
                                   " FreightCharge, " +
                                   " PlaceOfOrigin, " +
                                   " PlaceOfDestination, " +
                                   " ProformaType, " +
                                   " InvoiceNumber, " +
                                   " InvoiceDate, " +
                                   " InvoiceRemark)" +
                                   " Values (@ManufacturerGuid, " +
                                   " @ProformaNumber, " +
                                   " @ProformaDate, " +
                                   " @RequestReferenceNumber, " +
                                   " @RequestDate, " +
                                   " @Dispatch, " +
                                   " @TermsOfPayment, " +
                                   " @TermsOfPaymentDetail, " +
                                   " @TermsOfShipment, " +
                                   " @TermsOfContract, " +
                                   " @CurrencyType, " +
                                   " @FreightCharge, " +
                                   " @PlaceOfOrigin, " +
                                   " @PlaceOfDestination, " +
                                   " @ProformaType, " +
                                   " @InvoiceNumber, " +
                                   " @InvoiceDate, " +
                                   " @InvoiceRemark)" +
                                   " Select @Id=Max(id) from tblManufacturerProformas ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                command.Parameters.Add(new SqlParameter("@ProformaNumber", Proformanumber));
                if (Proformadate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ProformaDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ProformaDate", Proformadate));
                if (Requestdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", Requestdate));
                command.Parameters.Add(new SqlParameter("@RequestReferenceNumber", Requestreferencenumber));
                command.Parameters.Add(new SqlParameter("@Dispatch", Dispatch));
                command.Parameters.Add(new SqlParameter("@TermsOfPayment", Termsofpayment));
                command.Parameters.Add(new SqlParameter("@TermsOfPaymentDetail", Termsofpaymentdetail));
                command.Parameters.Add(new SqlParameter("@TermsOfShipment", Termsofshipment));
                command.Parameters.Add(new SqlParameter("@TermsOfContract", Termsofcontract));
                command.Parameters.Add(new SqlParameter("@CurrencyType", Currencytype));
                command.Parameters.Add(new SqlParameter("@FreightCharge", Freightcharge));
                command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", Placeoforigin));
                command.Parameters.Add(new SqlParameter("@PlaceOfDestination", Placeofdestination));
                command.Parameters.Add(new SqlParameter("@ProformaType", Proformatype));

                if (_InvoiceNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceNumber", DBNull.Value));

                if (_InvoiceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", _InvoiceDate));

                if (_InvoiceRemark == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", _InvoiceRemark));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformas::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Manufacturerguid, string Proformanumber, DateTime Proformadate, string Requestreferencenumber, DateTime Requestdate, int Dispatch, int Termsofpayment, string Termsofpaymentdetail, int Termsofshipment, string Termsofcontract, int Currencytype, decimal Freightcharge, string Placeoforigin, string Placeofdestination, int Proformatype, string Invoicenumber, DateTime Invoicedate, string Invoiceremark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblManufacturerProformas" +
                                   " Set ManufacturerGuid = @ManufacturerGuid, " +
                                   " ProformaNumber = @ProformaNumber, " +
                                   " ProformaDate = @ProformaDate, " +
                                   " RequestReferenceNumber = @RequestReferenceNumber, " +
                                   " RequestDate = @RequestDate, " +
                                   " Dispatch = @Dispatch, " +
                                   " TermsOfPayment = @TermsOfPayment, " +
                                   " TermsOfPaymentDetail = @TermsOfPaymentDetail, " +
                                   " TermsOfShipment = @TermsOfShipment, " +
                                   " TermsOfContract = @TermsOfContract, " +
                                   " CurrencyType = @CurrencyType, " +
                                   " FreightCharge = @FreightCharge, " +
                                   " PlaceOfOrigin = @PlaceOfOrigin, " +
                                   " PlaceOfDestination = @PlaceOfDestination, " +
                                   " ProformaType = @ProformaType, " +
                                   " InvoiceNumber = @InvoiceNumber, " +
                                   " InvoiceDate = @InvoiceDate, " +
                                   " InvoiceRemark = @InvoiceRemark " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                command.Parameters.Add(new SqlParameter("@ProformaNumber", Proformanumber));
                if (Requestdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ProformaDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ProformaDate", Proformadate));
                if (Requestdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", Requestdate));
                command.Parameters.Add(new SqlParameter("@RequestReferenceNumber", Requestreferencenumber));
                command.Parameters.Add(new SqlParameter("@Dispatch", Dispatch));
                command.Parameters.Add(new SqlParameter("@TermsOfPayment", Termsofpayment));
                command.Parameters.Add(new SqlParameter("@TermsOfPaymentDetail", Termsofpaymentdetail));
                command.Parameters.Add(new SqlParameter("@TermsOfShipment", Termsofshipment));
                command.Parameters.Add(new SqlParameter("@TermsOfContract", Termsofcontract));
                command.Parameters.Add(new SqlParameter("@CurrencyType", Currencytype));
                command.Parameters.Add(new SqlParameter("@FreightCharge", Freightcharge));
                command.Parameters.Add(new SqlParameter("@PlaceOfOrigin", Placeoforigin));
                command.Parameters.Add(new SqlParameter("@PlaceOfDestination", Placeofdestination));
                command.Parameters.Add(new SqlParameter("@ProformaType", Proformatype));

                if (_InvoiceNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceNumber", DBNull.Value));

                if (_InvoiceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceDate", _InvoiceDate));

                if (_InvoiceRemark == string.Empty)
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InvoiceRemark", _InvoiceRemark));
                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformas::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblManufacturerProformas Where Id = @Id ";
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
                throw new Exception("CManufacturerProformas::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Proformanumber)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformas] WHERE " +
                                       " ProformaNumber = @ProformaNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformas] WHERE " +
                                       " ProformaNumber = @ProformaNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProformaNumber", Proformanumber));
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
                throw new Exception("CManufacturerProformas::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CManufacturerProformas> GetList(bool NotConvertedToPurchaseOrder)
        {
            List<CManufacturerProformas> RecordsList = new List<CManufacturerProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblManufacturerProformas";
            if (NotConvertedToPurchaseOrder)
                command.CommandText += " Where tblManufacturerProformas.TableRowGuid not in (select distinct ISNULL(ManufacturerProformaGuid,'') from tblPurchaseOrders) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturerProformas objCManufacturerProformas = new CManufacturerProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturerProformas.Id = 0;
                    else
                        objCManufacturerProformas.Id = (int)dr["Id"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCManufacturerProformas.Manufacturerguid = string.Empty;
                    else
                        objCManufacturerProformas.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["ProformaNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformanumber = string.Empty;
                    else
                        objCManufacturerProformas.Proformanumber = (string)dr["ProformaNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformadate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["RequestReferenceNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Requestreferencenumber = string.Empty;
                    else
                        objCManufacturerProformas.Requestreferencenumber = (string)dr["RequestReferenceNumber"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Requestdate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["Dispatch"].Equals(DBNull.Value))
                        objCManufacturerProformas.Dispatch = 0;
                    else
                        objCManufacturerProformas.Dispatch = (int)dr["Dispatch"];
                    if (dr["TermsOfPayment"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofpayment = 0;
                    else
                        objCManufacturerProformas.Termsofpayment = (int)dr["TermsOfPayment"];
                    if (dr["TermsOfPaymentDetail"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofpaymentdetail = string.Empty;
                    else
                        objCManufacturerProformas.Termsofpaymentdetail = (string)dr["TermsOfPaymentDetail"];
                    if (dr["TermsOfShipment"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofshipment = 0;
                    else
                        objCManufacturerProformas.Termsofshipment = (int)dr["TermsOfShipment"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofcontract = string.Empty;
                    else
                        objCManufacturerProformas.Termsofcontract = (string)dr["TermsOfContract"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Currencytype = 0;
                    else
                        objCManufacturerProformas.Currencytype = (int)dr["CurrencyType"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Currencytypedescription = string.Empty;
                    else
                        objCManufacturerProformas.Currencytypedescription = CCommon.GetCurrencyTypeText((int)dr["CurrencyType"]);
                    if (dr["FreightCharge"].Equals(DBNull.Value))
                        objCManufacturerProformas.Freightcharge = 0;
                    else
                        objCManufacturerProformas.Freightcharge = (decimal)dr["FreightCharge"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCManufacturerProformas.Placeoforigin = string.Empty;
                    else
                        objCManufacturerProformas.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCManufacturerProformas.Placeofdestination = string.Empty;
                    else
                        objCManufacturerProformas.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["ProformaType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformatype = 0;
                    else
                        objCManufacturerProformas.Proformatype = (int)dr["ProformaType"];
                    if (dr["ProformaType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformatypedescription = string.Empty;
                    else
                        objCManufacturerProformas.Proformatypedescription = CCommon.GetProformaOrderTypeText((int)dr["ProformaType"]);
                    if (dr["InvoiceNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoicenumber = string.Empty;
                    else
                        objCManufacturerProformas.Invoicenumber = (string)dr["InvoiceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoicedate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceRemark"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoiceremark = string.Empty;
                    else
                        objCManufacturerProformas.Invoiceremark = (string)dr["InvoiceRemark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturerProformas.Tablerowguid = string.Empty;
                    else
                        objCManufacturerProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturerProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CManufacturerProformas> GetList(string Manufacturerguid, bool NotConvertedToPurchaseOrder)
        {
            List<CManufacturerProformas> RecordsList = new List<CManufacturerProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblManufacturerProformas " +
                                    " Where ManufacturerGuid = @ManufacturerGuid ";
            if (NotConvertedToPurchaseOrder)
                command.CommandText += " AND tblManufacturerProformas.TableRowGuid not in (select distinct ISNULL(ManufacturerProformaGuid,'') from tblPurchaseOrders) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturerProformas objCManufacturerProformas = new CManufacturerProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturerProformas.Id = 0;
                    else
                        objCManufacturerProformas.Id = (int)dr["Id"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCManufacturerProformas.Manufacturerguid = string.Empty;
                    else
                        objCManufacturerProformas.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["ProformaNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformanumber = string.Empty;
                    else
                        objCManufacturerProformas.Proformanumber = (string)dr["ProformaNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformadate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["RequestReferenceNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Requestreferencenumber = string.Empty;
                    else
                        objCManufacturerProformas.Requestreferencenumber = (string)dr["RequestReferenceNumber"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Requestdate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["Dispatch"].Equals(DBNull.Value))
                        objCManufacturerProformas.Dispatch = 0;
                    else
                        objCManufacturerProformas.Dispatch = (int)dr["Dispatch"];
                    if (dr["TermsOfPayment"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofpayment = 0;
                    else
                        objCManufacturerProformas.Termsofpayment = (int)dr["TermsOfPayment"];
                    if (dr["TermsOfPaymentDetail"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofpaymentdetail = string.Empty;
                    else
                        objCManufacturerProformas.Termsofpaymentdetail = (string)dr["TermsOfPaymentDetail"];
                    if (dr["TermsOfShipment"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofshipment = 0;
                    else
                        objCManufacturerProformas.Termsofshipment = (int)dr["TermsOfShipment"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofcontract = string.Empty;
                    else
                        objCManufacturerProformas.Termsofcontract = (string)dr["TermsOfContract"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Currencytype = 0;
                    else
                        objCManufacturerProformas.Currencytype = (int)dr["CurrencyType"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Currencytypedescription = string.Empty;
                    else
                        objCManufacturerProformas.Currencytypedescription = CCommon.GetCurrencyTypeText((int)dr["CurrencyType"]);
                    if (dr["FreightCharge"].Equals(DBNull.Value))
                        objCManufacturerProformas.Freightcharge = 0;
                    else
                        objCManufacturerProformas.Freightcharge = (decimal)dr["FreightCharge"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCManufacturerProformas.Placeoforigin = string.Empty;
                    else
                        objCManufacturerProformas.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCManufacturerProformas.Placeofdestination = string.Empty;
                    else
                        objCManufacturerProformas.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["ProformaType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformatype = 0;
                    else
                        objCManufacturerProformas.Proformatype = (int)dr["ProformaType"];
                    if (dr["ProformaType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformatypedescription = string.Empty;
                    else
                        objCManufacturerProformas.Proformatypedescription = CCommon.GetProformaOrderTypeText((int)dr["ProformaType"]);
                    if (dr["InvoiceNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoicenumber = string.Empty;
                    else
                        objCManufacturerProformas.Invoicenumber = (string)dr["InvoiceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoicedate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceRemark"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoiceremark = string.Empty;
                    else
                        objCManufacturerProformas.Invoiceremark = (string)dr["InvoiceRemark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturerProformas.Tablerowguid = string.Empty;
                    else
                        objCManufacturerProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturerProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CManufacturerProformas> GetList(DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotConvertedToPurchaseOrder)
        {
            List<CManufacturerProformas> RecordsList = new List<CManufacturerProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblManufacturerProformas " +
                                    " Where ProformaDate >= @ProformaDateFrom " +
                                    " And ProformaDate <= @ProformaDateTo ";
            if (NotConvertedToPurchaseOrder)
                command.CommandText += " AND tblManufacturerProformas.TableRowGuid not in (select distinct ISNULL(ManufacturerProformaGuid,'') from tblPurchaseOrders) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@ProformaDateFrom", ProformaDateFrom));
            command.Parameters.Add(new SqlParameter("@ProformaDateTo", ProformaDateTo));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturerProformas objCManufacturerProformas = new CManufacturerProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturerProformas.Id = 0;
                    else
                        objCManufacturerProformas.Id = (int)dr["Id"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCManufacturerProformas.Manufacturerguid = string.Empty;
                    else
                        objCManufacturerProformas.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["ProformaNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformanumber = string.Empty;
                    else
                        objCManufacturerProformas.Proformanumber = (string)dr["ProformaNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformadate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["RequestReferenceNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Requestreferencenumber = string.Empty;
                    else
                        objCManufacturerProformas.Requestreferencenumber = (string)dr["RequestReferenceNumber"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Requestdate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["Dispatch"].Equals(DBNull.Value))
                        objCManufacturerProformas.Dispatch = 0;
                    else
                        objCManufacturerProformas.Dispatch = (int)dr["Dispatch"];
                    if (dr["TermsOfPayment"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofpayment = 0;
                    else
                        objCManufacturerProformas.Termsofpayment = (int)dr["TermsOfPayment"];
                    if (dr["TermsOfPaymentDetail"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofpaymentdetail = string.Empty;
                    else
                        objCManufacturerProformas.Termsofpaymentdetail = (string)dr["TermsOfPaymentDetail"];
                    if (dr["TermsOfShipment"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofshipment = 0;
                    else
                        objCManufacturerProformas.Termsofshipment = (int)dr["TermsOfShipment"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofcontract = string.Empty;
                    else
                        objCManufacturerProformas.Termsofcontract = (string)dr["TermsOfContract"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Currencytype = 0;
                    else
                        objCManufacturerProformas.Currencytype = (int)dr["CurrencyType"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Currencytypedescription = string.Empty;
                    else
                        objCManufacturerProformas.Currencytypedescription = CCommon.GetCurrencyTypeText((int)dr["CurrencyType"]);
                    if (dr["FreightCharge"].Equals(DBNull.Value))
                        objCManufacturerProformas.Freightcharge = 0;
                    else
                        objCManufacturerProformas.Freightcharge = (decimal)dr["FreightCharge"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCManufacturerProformas.Placeoforigin = string.Empty;
                    else
                        objCManufacturerProformas.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCManufacturerProformas.Placeofdestination = string.Empty;
                    else
                        objCManufacturerProformas.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["ProformaType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformatype = 0;
                    else
                        objCManufacturerProformas.Proformatype = (int)dr["ProformaType"];
                    if (dr["ProformaType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformatypedescription = string.Empty;
                    else
                        objCManufacturerProformas.Proformatypedescription = CCommon.GetProformaOrderTypeText((int)dr["ProformaType"]);
                    if (dr["InvoiceNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoicenumber = string.Empty;
                    else
                        objCManufacturerProformas.Invoicenumber = (string)dr["InvoiceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoicedate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceRemark"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoiceremark = string.Empty;
                    else
                        objCManufacturerProformas.Invoiceremark = (string)dr["InvoiceRemark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturerProformas.Tablerowguid = string.Empty;
                    else
                        objCManufacturerProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturerProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CManufacturerProformas> GetList(string Manufacturerguid, DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotConvertedToPurchaseOrder)
        {
            List<CManufacturerProformas> RecordsList = new List<CManufacturerProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblManufacturerProformas " +
                                    " Where ManufacturerGuid = @ManufacturerGuid " +
                                    " And ProformaDate >= @ProformaDateFrom " +
                                    " And ProformaDate <= @ProformaDateTo ";
            if (NotConvertedToPurchaseOrder)
                command.CommandText += " AND tblManufacturerProformas.TableRowGuid not in (select distinct ISNULL(ManufacturerProformaGuid,'') from tblPurchaseOrders) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
            command.Parameters.Add(new SqlParameter("@ProformaDateFrom", ProformaDateFrom));
            command.Parameters.Add(new SqlParameter("@ProformaDateTo", ProformaDateTo));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturerProformas objCManufacturerProformas = new CManufacturerProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturerProformas.Id = 0;
                    else
                        objCManufacturerProformas.Id = (int)dr["Id"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCManufacturerProformas.Manufacturerguid = string.Empty;
                    else
                        objCManufacturerProformas.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["ProformaNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformanumber = string.Empty;
                    else
                        objCManufacturerProformas.Proformanumber = (string)dr["ProformaNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformadate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["RequestReferenceNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Requestreferencenumber = string.Empty;
                    else
                        objCManufacturerProformas.Requestreferencenumber = (string)dr["RequestReferenceNumber"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Requestdate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["Dispatch"].Equals(DBNull.Value))
                        objCManufacturerProformas.Dispatch = 0;
                    else
                        objCManufacturerProformas.Dispatch = (int)dr["Dispatch"];
                    if (dr["TermsOfPayment"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofpayment = 0;
                    else
                        objCManufacturerProformas.Termsofpayment = (int)dr["TermsOfPayment"];
                    if (dr["TermsOfPaymentDetail"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofpaymentdetail = string.Empty;
                    else
                        objCManufacturerProformas.Termsofpaymentdetail = (string)dr["TermsOfPaymentDetail"];
                    if (dr["TermsOfShipment"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofshipment = 0;
                    else
                        objCManufacturerProformas.Termsofshipment = (int)dr["TermsOfShipment"];
                    if (dr["TermsOfContract"].Equals(DBNull.Value))
                        objCManufacturerProformas.Termsofcontract = string.Empty;
                    else
                        objCManufacturerProformas.Termsofcontract = (string)dr["TermsOfContract"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Currencytype = 0;
                    else
                        objCManufacturerProformas.Currencytype = (int)dr["CurrencyType"];
                    if (dr["CurrencyType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Currencytypedescription = string.Empty;
                    else
                        objCManufacturerProformas.Currencytypedescription = CCommon.GetCurrencyTypeText((int)dr["CurrencyType"]);
                    if (dr["FreightCharge"].Equals(DBNull.Value))
                        objCManufacturerProformas.Freightcharge = 0;
                    else
                        objCManufacturerProformas.Freightcharge = (decimal)dr["FreightCharge"];
                    if (dr["PlaceOfOrigin"].Equals(DBNull.Value))
                        objCManufacturerProformas.Placeoforigin = string.Empty;
                    else
                        objCManufacturerProformas.Placeoforigin = (string)dr["PlaceOfOrigin"];
                    if (dr["PlaceOfDestination"].Equals(DBNull.Value))
                        objCManufacturerProformas.Placeofdestination = string.Empty;
                    else
                        objCManufacturerProformas.Placeofdestination = (string)dr["PlaceOfDestination"];
                    if (dr["ProformaType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformatype = 0;
                    else
                        objCManufacturerProformas.Proformatype = (int)dr["ProformaType"];
                    if (dr["ProformaType"].Equals(DBNull.Value))
                        objCManufacturerProformas.Proformatypedescription = string.Empty;
                    else
                        objCManufacturerProformas.Proformatypedescription = CCommon.GetProformaOrderTypeText((int)dr["ProformaType"]);
                    if (dr["InvoiceNumber"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoicenumber = string.Empty;
                    else
                        objCManufacturerProformas.Invoicenumber = (string)dr["InvoiceNumber"];
                    if (dr["InvoiceDate"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoicedate = DateTime.MinValue;
                    else
                        objCManufacturerProformas.Invoicedate = (DateTime)dr["InvoiceDate"];
                    if (dr["InvoiceRemark"].Equals(DBNull.Value))
                        objCManufacturerProformas.Invoiceremark = string.Empty;
                    else
                        objCManufacturerProformas.Invoiceremark = (string)dr["InvoiceRemark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturerProformas.Tablerowguid = string.Empty;
                    else
                        objCManufacturerProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturerProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public static string GetManufacturerProformaNumber(string Manufacturerguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ProformaNumber FROM [dbo].[tblManufacturerProformas] WHERE [TableRowGuid] = @ManufacturerGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                connection.Open();
                return (string)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformas::GetManufacturerProformaNumber::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblManufacturerProformas] WHERE Id = @Id";
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
                throw new Exception("CManufacturerProformas::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformas] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CManufacturerProformas::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
