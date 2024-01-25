//
// ...
// Wizard generated code
// Date: 8/11/2009 2:47:00 PM
// Class: CCashCollections
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
    class CCashCollections
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }
        public CCashCollections()
        {
            _ConnectionString = ConnectionString;
        }
        public CCashCollections(int Id, string Customerguid, DateTime Requestdate, string Referencenumber, int Modeofpayment, string Bankguid, string Bankbranchname, string Checkorcponumber, DateTime Checkorcpodate, DateTime Checkmaturitydate, int Settled, int Requestisvoid)
        {
            _Id = Id;
            _CustomerGuid = Customerguid;
            _RequestDate = Requestdate;
            _ReferenceNumber = Referencenumber;
            _ModeOfPayment = Modeofpayment;
            _BankGuid = Bankguid;
            _BankBranchName = Bankbranchname;
            _CheckOrCPONumber = Checkorcponumber;
            _CheckOrCPODate = Checkorcpodate;
            _CheckMaturityDate = Checkmaturitydate;
            _Settled = Settled;
            _RequestIsVoid = Requestisvoid;
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
        
        DateTime _RequestDate;
        public DateTime Requestdate
        {
            get { return _RequestDate; }
            set { _RequestDate = value; }
        }

        string _ReferenceNumber;
        public string Referencenumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        int _ModeOfPayment;
        public int Modeofpayment
        {
            get { return _ModeOfPayment; }
            set { _ModeOfPayment = value; }
        }

        string _BankGuid;
        public string Bankguid
        {
            get { return _BankGuid; }
            set { _BankGuid = value; }
        }

        string _BankBranchName;
        public string Bankbranchname
        {
            get { return _BankBranchName; }
            set { _BankBranchName = value; }
        }

        string _CheckOrCPONumber;
        public string Checkorcponumber
        {
            get { return _CheckOrCPONumber; }
            set { _CheckOrCPONumber = value; }
        }

        DateTime _CheckOrCPODate;
        public DateTime Checkorcpodate
        {
            get { return _CheckOrCPODate; }
            set { _CheckOrCPODate = value; }
        }

        DateTime _CheckMaturityDate;
        public DateTime Checkmaturitydate
        {
            get { return _CheckMaturityDate; }
            set { _CheckMaturityDate = value; }
        }

        int _Settled;
        public int Settled
        {
            get { return _Settled; }
            set { _Settled = value; }
        }

        string _OrganizationName;
        public string OrganizationName
        {
            get { return _OrganizationName; }
            set { _OrganizationName = value; }
        }

        string _InvoiceGuid;
        public string Invoiceguid
        {
            get { return _InvoiceGuid; }
            set { _InvoiceGuid = value; }
        }

        string _InvoiceNo;
        public string InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }

        int _ItemCount;
        public int ItemCount
        {
            get { return _ItemCount; }
            set { _ItemCount = value; }
        }

        decimal _TotalAmount;
        public decimal TotalAmount
        {
            get { return _TotalAmount; }
            set { _TotalAmount = value; }
        }

        DateTime _SettlementDate;
        public DateTime SettlementDate
        {
            get { return _SettlementDate; }
            set { _SettlementDate = value; }
        }

        DateTime _CheckCashedDate;
        public DateTime CheckCashedDate
        {
            get { return _CheckCashedDate; }
            set { _CheckCashedDate = value; }
        }

        int _CheckIsCashed;
        public int CheckIsCashed
        {
            get { return _CheckIsCashed; }
            set { _CheckIsCashed = value; }
        }

        int _RequestIsVoid;
        public int RequestIsVoid
        {
            get { return _RequestIsVoid; }
            set { _RequestIsVoid = value; }
        }

        DateTime _VoidDate;
        public DateTime VoidDate
        {
            get { return _VoidDate; }
            set { _VoidDate = value; }
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
            command.CommandText = "Select * from tblCashCollections where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblCashCollections");
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
                    if (dTable.Rows[0]["RequestDate"].Equals(DBNull.Value))
                        _RequestDate = DateTime.MinValue;
                    else
                        _RequestDate = (DateTime)dTable.Rows[0]["RequestDate"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["ModeOfPayment"].Equals(DBNull.Value))
                        _ModeOfPayment = 0;
                    else
                        _ModeOfPayment = (int)dTable.Rows[0]["ModeOfPayment"];
                    if (dTable.Rows[0]["BankGuid"].Equals(DBNull.Value))
                        _BankGuid = string.Empty;
                    else
                        _BankGuid = (string)dTable.Rows[0]["BankGuid"];
                    if (dTable.Rows[0]["BankBranchName"].Equals(DBNull.Value))
                        _BankBranchName = string.Empty;
                    else
                        _BankBranchName = (string)dTable.Rows[0]["BankBranchName"];
                    if (dTable.Rows[0]["CheckOrCPONumber"].Equals(DBNull.Value))
                        _CheckOrCPONumber = string.Empty;
                    else
                        _CheckOrCPONumber = (string)dTable.Rows[0]["CheckOrCPONumber"];
                    if (dTable.Rows[0]["CheckOrCPODate"].Equals(DBNull.Value))
                        _CheckOrCPODate = DateTime.MinValue;
                    else
                        _CheckOrCPODate = (DateTime)dTable.Rows[0]["CheckOrCPODate"];
                    if (dTable.Rows[0]["CheckMaturityDate"].Equals(DBNull.Value))
                        _CheckMaturityDate = DateTime.MinValue;
                    else
                        _CheckMaturityDate = (DateTime)dTable.Rows[0]["CheckMaturityDate"];
                    if (dTable.Rows[0]["Settled"].Equals(DBNull.Value))
                        _Settled = 0;
                    else
                        _Settled = (int)dTable.Rows[0]["Settled"];
                    if (dTable.Rows[0]["RequestIsVoid"].Equals(DBNull.Value))
                        _RequestIsVoid = 0;
                    else
                        _RequestIsVoid = (int)dTable.Rows[0]["RequestIsVoid"];
                    if (dTable.Rows[0]["VoidDate"].Equals(DBNull.Value))
                        _VoidDate = DateTime.MinValue;
                    else
                        _VoidDate = (DateTime)dTable.Rows[0]["VoidDate"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblCashCollections";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblCashCollections");
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
                throw new Exception("CCashCollections::GetRecords::Error! " + ex.Message, ex);
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
            strSQL = strSQL + " Insert Into tblCashCollections (CustomerGuid, RequestDate,ReferenceNumber, ";
            strSQL = strSQL + " CheckIsCashed,Settled, RequestIsVoid,UserId,ComputerName,EventSource) Values (@CustomerGuid, @RequestDate,@ReferenceNumber, ";
            strSQL = strSQL + "@CheckIsCashed,@Settled, @RequestIsVoid,@UserId,@ComputerName,@EventSource)  SELECT @Id=Max(id) from tblCashCollections ";

            command.CommandText = strSQL;
                                  
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@RequestDate", _RequestDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@CheckIsCashed", _CheckIsCashed));

               
                command.Parameters.Add(new SqlParameter("@Settled", _Settled));
                command.Parameters.Add(new SqlParameter("@RequestIsVoid", _RequestIsVoid));
                
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
                throw new Exception("CCashCollections::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool UpdateInvoice()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Update tblInvoices Set CashCollectionGuid = @CashCollectionGuid";
            strSQL = strSQL + " Where TableRowGuid = @InvoiceGuid ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", _TableRowGuid));
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::UpdateInvoice::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool UpdateSettled()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Update tblCashCollections Set ModeOfPayment = @ModeOfPayment,";
            strSQL = strSQL + " BankGuid = @BankGuid, ";
            strSQL = strSQL + " BankBranchName = @BankBranchName, ";
            strSQL = strSQL + " CheckOrCPONumber = @CheckOrCPONumber, ";
            strSQL = strSQL + " CheckOrCPODate = @CheckOrCPODate, ";
            strSQL = strSQL + " CheckMaturityDate = @CheckMaturityDate, ";
            strSQL = strSQL + " SettlementDate = @SettlementDate, ";
            strSQL = strSQL + " Settled =@Settled";
            strSQL = strSQL + " Where Id = @Id ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ModeOfPayment", _ModeOfPayment));
                if (_ModeOfPayment != (int)CCommon.PaymentType.Cash)
                {
                    command.Parameters.Add(new SqlParameter("@BankGuid", _BankGuid));
                    command.Parameters.Add(new SqlParameter("@BankBranchName", _BankBranchName));
                    command.Parameters.Add(new SqlParameter("@CheckOrCPONumber", _CheckOrCPONumber));
                    command.Parameters.Add(new SqlParameter("@CheckOrCPODate", _CheckOrCPODate));
                    command.Parameters.Add(new SqlParameter("@CheckMaturityDate", _CheckMaturityDate));
                }
                else
                {
                    command.Parameters.Add(new SqlParameter("@BankGuid", DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@BankBranchName", DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@CheckOrCPONumber", DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@CheckOrCPODate", DBNull.Value));
                    command.Parameters.Add(new SqlParameter("@CheckMaturityDate", DBNull.Value));

                }
                command.Parameters.Add(new SqlParameter("@SettlementDate", _SettlementDate));
                command.Parameters.Add(new SqlParameter("@Settled", _Settled));
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool UpdateCheckCashed()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Update tblCashCollections Set CheckIsCashed = @CheckIsCashed,";
            strSQL = strSQL + " CheckCashedDate = @CheckCashedDate ";
            strSQL = strSQL + " Where Id = @Id ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CheckIsCashed", _CheckIsCashed));
                command.Parameters.Add(new SqlParameter("@CheckCashedDate", _CheckCashedDate));

                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }       
        public bool UpdateVoid()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Update tblCashCollections Set RequestIsVoid = @RequestIsVoid,";
            strSQL = strSQL + " VoidDate = @VoidDate ";         
            strSQL = strSQL + " Where Id = @Id ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@RequestIsVoid", _RequestIsVoid));
                command.Parameters.Add(new SqlParameter("@VoidDate", _VoidDate));

                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::Update::Error! " + ex.Message, ex);
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
            string strSQL = "";
            strSQL = strSQL + " Update tblCashCollections Set CustomerGuid = @CustomerGuid, ";
            strSQL = strSQL + " RequestDate = @RequestDate, ReferenceNumber = @ReferenceNumber, ";
            strSQL = strSQL + " Settled =@Settled, RequestIsVoid =@RequestIsVoid, ";
            strSQL = strSQL + " UserId =@UserId,";
            strSQL = strSQL + " ComputerName =@ComputerName,";
            strSQL = strSQL + " EventSource =@EventSource ";
            strSQL = strSQL + " Where Id = @Id ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@RequestDate", _RequestDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));

                command.Parameters.Add(new SqlParameter("@Settled", _Settled));
                command.Parameters.Add(new SqlParameter("@RequestIsVoid", _RequestIsVoid));

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
                throw new Exception("CCashCollections::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblCashCollections Where Id = @Id ";
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
                throw new Exception("CCashCollections::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblCashCollections] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblCashCollections] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
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
                throw new Exception("CCashCollections::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Customerguid, DateTime Requestdate, string Referencenumber, int Modeofpayment, string Bankguid, string Bankbranchname, string Checkorcponumber, DateTime Checkorcpodate, DateTime Checkmaturitydate, int Settled, int Requestisvoid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblCashCollections" +
                                   " (CustomerGuid, " +
                                   " RequestDate, " +
                                   " ReferenceNumber, " +
                                   " ModeOfPayment, " +
                                   " BankGuid, " +
                                   " BankBranchName, " +
                                   " CheckOrCPONumber, " +
                                   " CheckOrCPODate, " +
                                   " CheckMaturityDate, " +
                                   " Settled, RequestIsVoid)" +
                                   " Values (@CustomerGuid, " +
                                   " @RequestDate, " +
                                   " @ReferenceNumber, " +
                                   " @ModeOfPayment, " +
                                   " @BankGuid, " +
                                   " @BankBranchName, " +
                                   " @CheckOrCPONumber, " +
                                   " @CheckOrCPODate, " +
                                   " @CheckMaturityDate, " +
                                   " @Settled, @RequestIsVoid)" +
                                   " Select @Id=Max(id) from tblCashCollections ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                command.Parameters.Add(new SqlParameter("@RequestDate", Requestdate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@ModeOfPayment", Modeofpayment));
                command.Parameters.Add(new SqlParameter("@BankGuid", Bankguid));
                command.Parameters.Add(new SqlParameter("@BankBranchName", Bankbranchname));
                command.Parameters.Add(new SqlParameter("@CheckOrCPONumber", Checkorcponumber));
                command.Parameters.Add(new SqlParameter("@CheckOrCPODate", Checkorcpodate));
                command.Parameters.Add(new SqlParameter("@CheckMaturityDate", Checkmaturitydate));
                command.Parameters.Add(new SqlParameter("@Settled", Settled));
                command.Parameters.Add(new SqlParameter("@RequestIsVoid", Requestisvoid));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Customerguid, DateTime Requestdate, string Referencenumber, int Modeofpayment, string Bankguid, string Bankbranchname, string Checkorcponumber, DateTime Checkorcpodate, DateTime Checkmaturitydate, int Settled, int Requestisvoid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblCashCollections" +
                                   " Set CustomerGuid = @CustomerGuid, " +
                                   " RequestDate = @RequestDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " ModeOfPayment = @ModeOfPayment, " +
                                   " BankGuid = @BankGuid, " +
                                   " BankBranchName = @BankBranchName, " +
                                   " CheckOrCPONumber = @CheckOrCPONumber, " +
                                   " CheckOrCPODate = @CheckOrCPODate, " +
                                   " CheckMaturityDate = @CheckMaturityDate, " +
                                   " Settled = @Settled, " +
                                   " RequestIsVoid = @RequestIsVoid " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                command.Parameters.Add(new SqlParameter("@RequestDate", Requestdate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@ModeOfPayment", Modeofpayment));
                command.Parameters.Add(new SqlParameter("@BankGuid", Bankguid));
                command.Parameters.Add(new SqlParameter("@BankBranchName", Bankbranchname));
                command.Parameters.Add(new SqlParameter("@CheckOrCPONumber", Checkorcponumber));
                command.Parameters.Add(new SqlParameter("@CheckOrCPODate", Checkorcpodate));
                command.Parameters.Add(new SqlParameter("@CheckMaturityDate", Checkmaturitydate));
                command.Parameters.Add(new SqlParameter("@Settled", Settled));
                command.Parameters.Add(new SqlParameter("@RequestIsVoid", Requestisvoid));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblCashCollections Where Id = @Id ";
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
                throw new Exception("CCashCollections::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Referencenumber)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblCashCollections] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblCashCollections] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
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
                throw new Exception("CCashCollections::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CCashCollections> GetList()
        {
            List<CCashCollections> RecordsList = new List<CCashCollections>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblCashCollections";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CCashCollections objCCashCollections = new CCashCollections();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCCashCollections.Id = 0;
                    else
                        objCCashCollections.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCCashCollections.Customerguid = string.Empty;
                    else
                        objCCashCollections.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCCashCollections.Requestdate = DateTime.MinValue;
                    else
                        objCCashCollections.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCCashCollections.Referencenumber = string.Empty;
                    else
                        objCCashCollections.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["ModeOfPayment"].Equals(DBNull.Value))
                        objCCashCollections.Modeofpayment = 0;
                    else
                        objCCashCollections.Modeofpayment = (int)dr["ModeOfPayment"];
                    if (dr["BankGuid"].Equals(DBNull.Value))
                        objCCashCollections.Bankguid = string.Empty;
                    else
                        objCCashCollections.Bankguid = (string)dr["BankGuid"];
                    if (dr["BankBranchName"].Equals(DBNull.Value))
                        objCCashCollections.Bankbranchname = string.Empty;
                    else
                        objCCashCollections.Bankbranchname = (string)dr["BankBranchName"];
                    if (dr["CheckOrCPONumber"].Equals(DBNull.Value))
                        objCCashCollections.Checkorcponumber = string.Empty;
                    else
                        objCCashCollections.Checkorcponumber = (string)dr["CheckOrCPONumber"];
                    if (dr["CheckOrCPODate"].Equals(DBNull.Value))
                        objCCashCollections.Checkorcpodate = DateTime.MinValue;
                    else
                        objCCashCollections.Checkorcpodate = (DateTime)dr["CheckOrCPODate"];
                    if (dr["CheckMaturityDate"].Equals(DBNull.Value))
                        objCCashCollections.Checkmaturitydate = DateTime.MinValue;
                    else
                        objCCashCollections.Checkmaturitydate = (DateTime)dr["CheckMaturityDate"];
                    if (dr["Settled"].Equals(DBNull.Value))
                        objCCashCollections.Settled = 0;
                    else
                        objCCashCollections.Settled = (int)dr["Settled"];
                    if (dr["SettlementDate"].Equals(DBNull.Value))
                        objCCashCollections.SettlementDate = DateTime.MinValue;
                    else
                        objCCashCollections.SettlementDate = (DateTime)dr["SettlementDate"];
                    if (dr["RequestIsVoid"].Equals(DBNull.Value))
                        objCCashCollections.RequestIsVoid = 0;
                    else
                        objCCashCollections.RequestIsVoid = (int)dr["RequestIsVoid"];
                    if (dr["VoidDate"].Equals(DBNull.Value))
                        objCCashCollections.VoidDate = DateTime.MinValue;
                    else
                        objCCashCollections.VoidDate = (DateTime)dr["VoidDate"];

                    RecordsList.Add(objCCashCollections);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CCashCollections> GetList(string strCriteria)
        {
            List<CCashCollections> RecordsList = new List<CCashCollections>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select distinct tblCashCollections.*, Name from tblCashCollections";
            strSQL = strSQL + " join tblCustomers on (tblCashCollections.CustomerGuid = tblCustomers.TableRowGuid) ";
            strSQL = strSQL + " where 1=1" + strCriteria;
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CCashCollections objCCashCollections = new CCashCollections();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCCashCollections.Id = 0;
                    else
                        objCCashCollections.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCCashCollections.Customerguid = string.Empty;
                    else
                        objCCashCollections.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCCashCollections.Requestdate = DateTime.MinValue;
                    else
                        objCCashCollections.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCCashCollections.Referencenumber = string.Empty;
                    else
                        objCCashCollections.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["ModeOfPayment"].Equals(DBNull.Value))
                        objCCashCollections.Modeofpayment = 0;
                    else
                        objCCashCollections.Modeofpayment = (int)dr["ModeOfPayment"];
                    if (dr["BankGuid"].Equals(DBNull.Value))
                        objCCashCollections.Bankguid = string.Empty;
                    else
                        objCCashCollections.Bankguid = (string)dr["BankGuid"];
                    if (dr["BankBranchName"].Equals(DBNull.Value))
                        objCCashCollections.Bankbranchname = string.Empty;
                    else
                        objCCashCollections.Bankbranchname = (string)dr["BankBranchName"];
                    if (dr["CheckOrCPONumber"].Equals(DBNull.Value))
                        objCCashCollections.Checkorcponumber = string.Empty;
                    else
                        objCCashCollections.Checkorcponumber = (string)dr["CheckOrCPONumber"];
                    if (dr["CheckOrCPODate"].Equals(DBNull.Value))
                        objCCashCollections.Checkorcpodate = DateTime.MinValue;
                    else
                        objCCashCollections.Checkorcpodate = (DateTime)dr["CheckOrCPODate"];
                    if (dr["CheckMaturityDate"].Equals(DBNull.Value))
                        objCCashCollections.Checkmaturitydate = DateTime.MinValue;
                    else
                        objCCashCollections.Checkmaturitydate = (DateTime)dr["CheckMaturityDate"];
                    if (dr["Settled"].Equals(DBNull.Value))
                        objCCashCollections.Settled = 0;
                    else
                        objCCashCollections.Settled = (int)dr["Settled"];
                    if (dr["SettlementDate"].Equals(DBNull.Value))
                        objCCashCollections.SettlementDate = DateTime.MinValue;
                    else
                        objCCashCollections.SettlementDate = (DateTime)dr["SettlementDate"];
                    if (dr["RequestIsVoid"].Equals(DBNull.Value))
                        objCCashCollections.RequestIsVoid = 0;
                    else
                        objCCashCollections.RequestIsVoid = (int)dr["RequestIsVoid"];
                    if (dr["VoidDate"].Equals(DBNull.Value))
                        objCCashCollections.VoidDate = DateTime.MinValue;
                    else
                        objCCashCollections.VoidDate = (DateTime)dr["VoidDate"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCCashCollections.OrganizationName = string.Empty;
                    else
                        objCCashCollections.OrganizationName = (string)dr["Name"];

                    RecordsList.Add(objCCashCollections);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public CCashCollections GetInvoiceDescription()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            CCashCollections objCash = new CCashCollections();
            string strSQL = "";
            strSQL = strSQL + " Select InvoiceGuid = tblInvoices.TableRowGuid,ReferenceNumber,count(InvoiceGuid)as ItemCount , ";
            strSQL = strSQL + " sum(tblInvoiceDetails.Quantity * tblInvoiceDetails.UnitPrice - (tblInvoiceDetails.Quantity * tblInvoiceDetails.UnitPrice * tblInvoices.Discount * 0.01)  ) as TotalAmount ";
            strSQL = strSQL + " From tblInvoiceDetails join tblBatchs on (tblInvoiceDetails.BatchGuid = tblBatchs.TableRowGuid )";
            strSQL = strSQL + " join tblInvoices on(tblInvoiceDetails.InvoiceGuid = tblInvoices.TableRowGuid)";
            strSQL = strSQL + " Where  tblInvoices.TableRowGuid = @InvoiceGuid ";
            strSQL = strSQL + " group by tblInvoices.TableRowGuid,tblInvoices.ReferenceNumber ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    //if (dr["Id"].Equals(DBNull.Value))
                    //    objCash.InvoiceId = 0;
                    //else
                    //    objCash.InvoiceId = (int)dr["Id"];
                    if (dr["InvoiceGuid"].Equals(DBNull.Value))
                        objCash.Invoiceguid = string.Empty;
                    else
                        objCash.Invoiceguid = (string)dr["InvoiceGuid"];
                    
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCash.InvoiceNo = string.Empty;
                    else
                        objCash.InvoiceNo = (string)dr["ReferenceNumber"];
                    if (dr["ItemCount"].Equals(DBNull.Value))
                        objCash.ItemCount = 0;
                    else
                        objCash.ItemCount = (int)dr["ItemCount"];
                    if (dr["TotalAmount"].Equals(DBNull.Value))
                        objCash.TotalAmount = decimal.Zero;
                    else
                        objCash.TotalAmount = (decimal)dr["TotalAmount"];


                }
                return objCash;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::GetInvoiceDescription::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }

        }
        public decimal GetRequestTotal(string Cashcollectionguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            decimal decReturn = decimal.Zero;
            string strSQL = "";
            strSQL = strSQL + " Select sum(tblInvoiceDetails.Quantity * tblBatchs.SalePrice ) as TotalAmount  ";          
            strSQL = strSQL + " From tblInvoiceDetails join tblBatchs on (tblInvoiceDetails.BatchGuid = tblBatchs.TableRowGuid) ";
            strSQL = strSQL + " join tblInvoices on(tblInvoiceDetails.InvoiceGuid = tblInvoices.TableRowGuid)";
            strSQL = strSQL + " Where  tblInvoices.CashCollectionGuid = @CashCollectionGuid ";
            
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    
                    if (dr["TotalAmount"].Equals(DBNull.Value))
                        decReturn = decimal.Zero;
                    else
                        decReturn = (decimal)dr["TotalAmount"];


                }
                return decReturn;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::GetRequestTotal::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }

        }
        public decimal GetRequestTotalAmount(string Cashcollectionguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            decimal decReturn = decimal.Zero;
            string strSQL = "";
            //strSQL = strSQL + " Select sum(tblInvoiceDetails.Quantity * tblBatchs.SalePrice ) as TotalAmount  ";
            //strSQL = strSQL + " From tblInvoiceDetails join tblBatchs on (tblInvoiceDetails.BatchGuid = tblBatchs.TableRowGuid) ";
            //strSQL = strSQL + " join tblInvoices on(tblInvoiceDetails.InvoiceGuid = tblInvoices.TableRowGuid)";
            //strSQL = strSQL + " Where  tblInvoices.CashCollectionGuid = @CashCollectionGuid ";

            strSQL = strSQL + " SELECT SUM(tblInvoiceDetails.Quantity * tblInvoiceDetails.UnitPrice - ";
            strSQL = strSQL + " 		tblInvoiceDetails.Quantity * tblInvoiceDetails.UnitPrice * tblInvoices.Discount * 0.01) AS TotalAmount ";
            strSQL = strSQL + " FROM tblInvoiceDetails INNER JOIN tblInvoices ";
            strSQL = strSQL + " ON tblInvoiceDetails.InvoiceGuid = tblInvoices.TableRowGuid ";
            strSQL = strSQL + " INNER JOIN tblCashCollectionInvoices ";
            strSQL = strSQL + " ON tblCashCollectionInvoices.InvoiceGuid = tblInvoices.TableRowGuid ";
            strSQL = strSQL + " WHERE tblCashCollectionInvoices.CashCollectionGuid = @CashCollectionGuid ";
            strSQL = strSQL + " GROUP BY tblCashCollectionInvoices.CashCollectionGuid ";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();

                    if (dr["TotalAmount"].Equals(DBNull.Value))
                        decReturn = decimal.Zero;
                    else
                        decReturn = (decimal)dr["TotalAmount"];


                }
                return decReturn;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::GetRequestTotal::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }

        }
        public List<CCashCollections> GetInvoiceDescription(string Cashcollectionguid)
        {
            List<CCashCollections> RecordList = new List<CCashCollections>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            
            string strSQL = "";
            strSQL = strSQL + " Select tblInvoices.id,InvoiceGuid = tblInvoices.TableRowGuid,ReferenceNumber,count(InvoiceGuid)as ItemCount , ";
            strSQL = strSQL + " sum(tblInvoiceDetails.Quantity * tblBatchs.SalePrice ) as TotalAmount ";
            strSQL = strSQL + " From tblInvoiceDetails join tblBatchs on (tblInvoiceDetails.BatchGuid = tblBatchs.TableRowGuid )";
            strSQL = strSQL + " join tblInvoices on(tblInvoiceDetails.InvoiceGuid = tblInvoices.TableRowGuid)";
            strSQL = strSQL + " Where  tblInvoices.CashCollectionGuid = @CashCollectionGuid ";
            strSQL = strSQL + " group by tblInvoices.TableRowGuid, tblInvoices.ReferenceNumber ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                dr = command.ExecuteReader();
                while(dr.Read())
                {
                    CCashCollections objCash = new CCashCollections();
                    //if (dr["Id"].Equals(DBNull.Value))
                    //    objCash.InvoiceId = 0;
                    //else
                    //    objCash.InvoiceId = (int)dr["Id"];
                    if (dr["InvoiceGuid"].Equals(DBNull.Value))
                        objCash.Invoiceguid = string.Empty;
                    else
                        objCash.Invoiceguid = (string)dr["InvoiceGuid"];

                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCash.InvoiceNo = string.Empty;
                    else
                        objCash.InvoiceNo = (string)dr["ReferenceNumber"];
                    if (dr["ItemCount"].Equals(DBNull.Value))
                        objCash.ItemCount = 0;
                    else
                        objCash.ItemCount = (int)dr["ItemCount"];
                    if (dr["TotalAmount"].Equals(DBNull.Value))
                        objCash.TotalAmount = decimal.Zero;
                    else
                        objCash.TotalAmount = (decimal)dr["TotalAmount"];

                    RecordList.Add(objCash);

                }
                return RecordList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollections::GetInvoiceDescription::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }

        }

        public static int GetMaxReferenceNumber()
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            string strCount = "Select Count(*) from tblCashCollections";
            string strMAX = "Select MAX(CAST(ReferenceNumber AS int)) from tblCashCollections";

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
                throw new Exception("CCashCollections::GetMaxReferenceNumber::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblCashCollections] WHERE Id = @Id";
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
                throw new Exception("CCashCollections::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblCashCollections] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CCashCollections::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
