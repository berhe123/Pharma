//
// ...
// Wizard generated code
// Date: 12/31/2009 2:21:17 PM
// Class: CSalesReturns
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
    class CSalesReturns
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CSalesReturns()
        {
            _ConnectionString = ConnectionString;
        }
        public CSalesReturns(int Id, string Customerguid, string Referencenumber, DateTime Salesreturndate, string Salesinvoiceguid, string Issuedby, string Receivedby, DateTime Issueddate, DateTime Receiveddate, int Returnstatus, decimal Discount)
        {
            _Id = Id;
            _CustomerGuid = Customerguid;
            _ReferenceNumber = Referencenumber;
            _SalesReturnDate = Salesreturndate;
            _SalesInvoiceGuid = Salesinvoiceguid;
            _IssuedBy = Issuedby;
            _ReceivedBy = Receivedby;
            _IssuedDate = Issueddate;
            _ReceivedDate = Receiveddate;
            _ReturnStatus = Returnstatus;
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

        string _ReferenceNumber;
        public string Referencenumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        DateTime _SalesReturnDate;
        public DateTime Salesreturndate
        {
            get { return _SalesReturnDate; }
            set { _SalesReturnDate = value; }
        }

        string _SalesInvoiceGuid;
        public string Salesinvoiceguid
        {
            get { return _SalesInvoiceGuid; }
            set { _SalesInvoiceGuid = value; }
        }

        string _IssuedBy;
        public string Issuedby
        {
            get { return _IssuedBy; }
            set { _IssuedBy = value; }
        }

        string _ReceivedBy;
        public string Receivedby
        {
            get { return _ReceivedBy; }
            set { _ReceivedBy = value; }
        }

        DateTime _IssuedDate;
        public DateTime Issueddate
        {
            get { return _IssuedDate; }
            set { _IssuedDate = value; }
        }

        DateTime _ReceivedDate;
        public DateTime Receiveddate
        {
            get { return _ReceivedDate; }
            set { _ReceivedDate = value; }
        }

        int _ReturnStatus;
        public int Returnstatus
        {
            get { return _ReturnStatus; }
            set { _ReturnStatus = value; }
        }

        decimal _Discount;
        public decimal Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        string _InvoiceNumber;
        public string InvoiceNumber
        {
            get { return _InvoiceNumber; }
            set { _InvoiceNumber = value; }
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
            command.CommandText = "Select * from tblSalesReturns where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblSalesReturns");
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
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["SalesReturnDate"].Equals(DBNull.Value))
                        _SalesReturnDate = DateTime.MinValue;
                    else
                        _SalesReturnDate = (DateTime)dTable.Rows[0]["SalesReturnDate"];
                    if (dTable.Rows[0]["SalesInvoiceGuid"].Equals(DBNull.Value))
                        _SalesInvoiceGuid = string.Empty;
                    else
                        _SalesInvoiceGuid = (string)dTable.Rows[0]["SalesInvoiceGuid"];
                    if (dTable.Rows[0]["IssuedBy"].Equals(DBNull.Value))
                        _IssuedBy = string.Empty;
                    else
                        _IssuedBy = (string)dTable.Rows[0]["IssuedBy"];
                    if (dTable.Rows[0]["ReceivedBy"].Equals(DBNull.Value))
                        _ReceivedBy = string.Empty;
                    else
                        _ReceivedBy = (string)dTable.Rows[0]["ReceivedBy"];
                    if (dTable.Rows[0]["IssuedDate"].Equals(DBNull.Value))
                        _IssuedDate = DateTime.MinValue;
                    else
                        _IssuedDate = (DateTime)dTable.Rows[0]["IssuedDate"];
                    if (dTable.Rows[0]["ReceivedDate"].Equals(DBNull.Value))
                        _ReceivedDate = DateTime.MinValue;
                    else
                        _ReceivedDate = (DateTime)dTable.Rows[0]["ReceivedDate"];
                    if (dTable.Rows[0]["ReturnStatus"].Equals(DBNull.Value))
                        _ReturnStatus = 0;
                    else
                        _ReturnStatus = (int)dTable.Rows[0]["ReturnStatus"];
                    if (dTable.Rows[0]["Discount"].Equals(DBNull.Value))
                        _Discount = 0;
                    else
                        _Discount = (decimal)dTable.Rows[0]["Discount"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturns::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblSalesReturns";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblSalesReturns");
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
                throw new Exception("CSalesReturns::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblSalesReturns" +
                                   " (CustomerGuid, " +
                                   " ReferenceNumber, " +
                                   " SalesReturnDate, " +
                                   " SalesInvoiceGuid, " +
                                   " IssuedBy, " +
                                   " ReceivedBy, " +
                                   " IssuedDate, " +
                                   " ReceivedDate, " +
                                   " ReturnStatus, " +
                                   " Discount,UserId,ComputerName,EventSource)" +
                                   " Values (@CustomerGuid, " +
                                   " @ReferenceNumber, " +
                                   " @SalesReturnDate, " +
                                   " @SalesInvoiceGuid, " +
                                   " @IssuedBy, " +
                                   " @ReceivedBy, " +
                                   " @IssuedDate, " +
                                   " @ReceivedDate, " +
                                   " @ReturnStatus, " +
                                   " @Discount,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblSalesReturns ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@SalesReturnDate", _SalesReturnDate));
                command.Parameters.Add(new SqlParameter("@SalesInvoiceGuid", _SalesInvoiceGuid));
                command.Parameters.Add(new SqlParameter("@IssuedBy", _IssuedBy));
                command.Parameters.Add(new SqlParameter("@ReceivedBy", _ReceivedBy));
                command.Parameters.Add(new SqlParameter("@IssuedDate", _IssuedDate));
                command.Parameters.Add(new SqlParameter("@ReceivedDate", _ReceivedDate));
                command.Parameters.Add(new SqlParameter("@ReturnStatus", _ReturnStatus));
                command.Parameters.Add(new SqlParameter("@Discount", _Discount));

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
                throw new Exception("CSalesReturns::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblSalesReturns" +
                                   " Set CustomerGuid = @CustomerGuid, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " SalesReturnDate = @SalesReturnDate, " +
                                   " SalesInvoiceGuid = @SalesInvoiceGuid, " +
                                   " IssuedBy = @IssuedBy, " +
                                   " ReceivedBy = @ReceivedBy, " +
                                   " IssuedDate = @IssuedDate, " +
                                   " ReceivedDate = @ReceivedDate, " +
                                   " ReturnStatus = @ReturnStatus, " +
                                   " Discount = @Discount," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@SalesReturnDate", _SalesReturnDate));
                command.Parameters.Add(new SqlParameter("@SalesInvoiceGuid", _SalesInvoiceGuid));
                command.Parameters.Add(new SqlParameter("@IssuedBy", _IssuedBy));
                command.Parameters.Add(new SqlParameter("@ReceivedBy", _ReceivedBy));
                command.Parameters.Add(new SqlParameter("@IssuedDate", _IssuedDate));
                command.Parameters.Add(new SqlParameter("@ReceivedDate", _ReceivedDate));
                command.Parameters.Add(new SqlParameter("@ReturnStatus", _ReturnStatus));
                command.Parameters.Add(new SqlParameter("@Discount", _Discount));

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
                throw new Exception("CSalesReturns::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblSalesReturns Where Id = @Id ";
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
                throw new Exception("CSalesReturns::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblSalesReturns] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblSalesReturns] WHERE " +
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
                throw new Exception("CSalesReturns::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CSalesReturns> GetList()
        {
            List<CSalesReturns> RecordsList = new List<CSalesReturns>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblSalesReturns";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSalesReturns objCSalesReturns = new CSalesReturns();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSalesReturns.Id = 0;
                    else
                        objCSalesReturns.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCSalesReturns.Customerguid = string.Empty;
                    else
                        objCSalesReturns.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCSalesReturns.Referencenumber = string.Empty;
                    else
                        objCSalesReturns.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["SalesReturnDate"].Equals(DBNull.Value))
                        objCSalesReturns.Salesreturndate = DateTime.MinValue;
                    else
                        objCSalesReturns.Salesreturndate = (DateTime)dr["SalesReturnDate"];
                    if (dr["SalesInvoiceGuid"].Equals(DBNull.Value))
                        objCSalesReturns.Salesinvoiceguid = string.Empty;
                    else
                        objCSalesReturns.Salesinvoiceguid = (string)dr["SalesInvoiceGuid"];
                    if (dr["IssuedBy"].Equals(DBNull.Value))
                        objCSalesReturns.Issuedby = string.Empty;
                    else
                        objCSalesReturns.Issuedby = (string)dr["IssuedBy"];
                    if (dr["ReceivedBy"].Equals(DBNull.Value))
                        objCSalesReturns.Receivedby = string.Empty;
                    else
                        objCSalesReturns.Receivedby = (string)dr["ReceivedBy"];
                    if (dr["IssuedDate"].Equals(DBNull.Value))
                        objCSalesReturns.Issueddate = DateTime.MinValue;
                    else
                        objCSalesReturns.Issueddate = (DateTime)dr["IssuedDate"];
                    if (dr["ReceivedDate"].Equals(DBNull.Value))
                        objCSalesReturns.Receiveddate = DateTime.MinValue;
                    else
                        objCSalesReturns.Receiveddate = (DateTime)dr["ReceivedDate"];
                    if (dr["ReturnStatus"].Equals(DBNull.Value))
                        objCSalesReturns.Returnstatus = 0;
                    else
                        objCSalesReturns.Returnstatus = (int)dr["ReturnStatus"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCSalesReturns.Discount = 0;
                    else
                        objCSalesReturns.Discount = (decimal)dr["Discount"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSalesReturns.Tablerowguid = string.Empty;
                    else
                        objCSalesReturns.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSalesReturns);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturns::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSalesReturns> GetList(string strCriteria)
        {
            List<CSalesReturns> RecordsList = new List<CSalesReturns>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            
            command.CommandText = " Select tblSalesReturns.*, tblInvoices.ReferenceNumber AS InvoiceNumber ";
            command.CommandText += " from tblSalesReturns Left Outer Join ";
            command.CommandText += " tblInvoices on (tblSalesReturns.SalesInvoiceGuid = tblInvoices.TableRowGuid ) ";
            command.CommandText += " where 1=1 " + strCriteria;

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSalesReturns objCSalesReturns = new CSalesReturns();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSalesReturns.Id = 0;
                    else
                        objCSalesReturns.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCSalesReturns.Customerguid = string.Empty;
                    else
                        objCSalesReturns.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCSalesReturns.Referencenumber = string.Empty;
                    else
                        objCSalesReturns.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["SalesReturnDate"].Equals(DBNull.Value))
                        objCSalesReturns.Salesreturndate = DateTime.MinValue;
                    else
                        objCSalesReturns.Salesreturndate = (DateTime)dr["SalesReturnDate"];
                    if (dr["SalesInvoiceGuid"].Equals(DBNull.Value))
                        objCSalesReturns.Salesinvoiceguid = string.Empty;
                    else
                        objCSalesReturns.Salesinvoiceguid = (string)dr["SalesInvoiceGuid"];
                    if (dr["IssuedBy"].Equals(DBNull.Value))
                        objCSalesReturns.Issuedby = string.Empty;
                    else
                        objCSalesReturns.Issuedby = (string)dr["IssuedBy"];
                    if (dr["ReceivedBy"].Equals(DBNull.Value))
                        objCSalesReturns.Receivedby = string.Empty;
                    else
                        objCSalesReturns.Receivedby = (string)dr["ReceivedBy"];
                    if (dr["IssuedDate"].Equals(DBNull.Value))
                        objCSalesReturns.Issueddate = DateTime.MinValue;
                    else
                        objCSalesReturns.Issueddate = (DateTime)dr["IssuedDate"];
                    if (dr["ReceivedDate"].Equals(DBNull.Value))
                        objCSalesReturns.Receiveddate = DateTime.MinValue;
                    else
                        objCSalesReturns.Receiveddate = (DateTime)dr["ReceivedDate"];
                    if (dr["ReturnStatus"].Equals(DBNull.Value))
                        objCSalesReturns.Returnstatus = 0;
                    else
                        objCSalesReturns.Returnstatus = (int)dr["ReturnStatus"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCSalesReturns.Discount = 0;
                    else
                        objCSalesReturns.Discount = (decimal)dr["Discount"];
                    if (dr["InvoiceNumber"].Equals(DBNull.Value))
                        objCSalesReturns.InvoiceNumber = string.Empty;
                    else
                        objCSalesReturns.InvoiceNumber = (string)dr["InvoiceNumber"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSalesReturns.Tablerowguid = string.Empty;
                    else
                        objCSalesReturns.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSalesReturns);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturns::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public int InvoiceExists(bool bNew)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT Id FROM [dbo].[tblSalesReturns] ";
            command.CommandText += " WHERE SalesInvoiceGuid = @SalesInvoiceGuid ";
            if (!bNew)
                command.CommandText += " AND Id <> @Id";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SalesInvoiceGuid", _SalesInvoiceGuid));
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
                throw new Exception("CSalesReturns::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public static int GetSalesReturnStatus(string Salesreturnguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "Select ReturnStatus = IsNull(ReturnStatus, 0) from tblSalesReturns Where TableRowGuid = '" + Salesreturnguid + "' ";
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
                throw new Exception("CInvoices::GetSalesReturnStatus::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblSalesReturns] WHERE Id = @Id";
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
                throw new Exception("CSalesReturns::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblSalesReturns] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CSalesReturns::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
