//
// ...
// Wizard generated code
// Date: 7/27/2009 6:03:10 PM
// Class: CProformas
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
    class CProformas
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return   Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CProformas()
        {
            _ConnectionString = ConnectionString;
        }
        public CProformas(int Id, string Customerguid, string Referencenumber, DateTime Proformadate, string Approvedby, DateTime Approvaldate, string RequestedBy, DateTime Checkeddate)
        {
            _Id = Id;
            _ReferenceNumber = Referencenumber;
            _CustomerGuid = Customerguid;
            _ProformaDate = Proformadate;
            _ApprovedBy = Approvedby;
            _ApprovalDate = Approvaldate;
            _RequestedBy = RequestedBy;
            
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
        public string ReferenceNumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        DateTime _ProformaDate;
        public DateTime Proformadate
        {
            get { return _ProformaDate; }
            set { _ProformaDate = value; }
        }

        string _ApprovedBy;
        public string Approvedby
        {
            get { return _ApprovedBy; }
            set { _ApprovedBy = value; }
        }

        DateTime _ApprovalDate;
        public DateTime Approvaldate
        {
            get { return _ApprovalDate; }
            set { _ApprovalDate = value; }
        }

        string _RequestedBy;
        public string RequestedBy
        {
            get { return _RequestedBy; }
            set { _RequestedBy = value; }
        }
       
        string _OrganizationName;
        public string OrganizationName
        {
            get { return _OrganizationName; }
            set { _OrganizationName = value; } 
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
            command.CommandText = "Select * from tblProformas where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblProformas");
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
                    if (dTable.Rows[0]["ProformaDate"].Equals(DBNull.Value))
                        _ProformaDate = DateTime.MinValue;
                    else
                        _ProformaDate = (DateTime)dTable.Rows[0]["ProformaDate"];
                    if (dTable.Rows[0]["ApprovedBy"].Equals(DBNull.Value))
                        _ApprovedBy = string.Empty;
                    else
                        _ApprovedBy = (string)dTable.Rows[0]["ApprovedBy"];
                    if (dTable.Rows[0]["ApprovalDate"].Equals(DBNull.Value))
                        _ApprovalDate = DateTime.MinValue;
                    else
                        _ApprovalDate = (DateTime)dTable.Rows[0]["ApprovalDate"];
                    if (dTable.Rows[0]["RequestedBy"].Equals(DBNull.Value))
                        _RequestedBy = string.Empty;
                    else
                        _RequestedBy = (string)dTable.Rows[0]["RequestedBy"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformas::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblProformas";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblProformas");
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
                throw new Exception("CProformas::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblProformas" +
                                   " (CustomerGuid, " +
                                   " ReferenceNumber, " +
                                   " ProformaDate, " +
                                   " ApprovedBy, " +
                                   " ApprovalDate, " +
                                   " RequestedBy,UserId,ComputerName,EventSource)" +
                                   " Values (@CustomerGuid, " +
                                   " @ReferenceNumber, " +
                                   " @ProformaDate, " +
                                   " @ApprovedBy, " +
                                   " @ApprovalDate, " +
                                   " @RequestedBy,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblProformas ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                if (_ProformaDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ProformaDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ProformaDate", _ProformaDate));
                command.Parameters.Add(new SqlParameter("@ApprovedBy", _ApprovedBy));
                if (_ApprovalDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", _ApprovalDate));
                command.Parameters.Add(new SqlParameter("@RequestedBy", _RequestedBy));

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
                throw new Exception("CProformas::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblProformas" +
                                   " Set CustomerGuid = @CustomerGuid, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " ProformaDate = @ProformaDate, " +
                                   " ApprovedBy = @ApprovedBy, " +
                                   " ApprovalDate = @ApprovalDate, " +
                                   " RequestedBy = @RequestedBy, " +
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
                if (_ProformaDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ProformaDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ProformaDate", _ProformaDate));
                command.Parameters.Add(new SqlParameter("@ApprovedBy", _ApprovedBy));
                if (_ApprovalDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", _ApprovalDate));
                command.Parameters.Add(new SqlParameter("@RequestedBy", _RequestedBy));

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
                throw new Exception("CProformas::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblProformas Where Id = @Id ";
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
                throw new Exception("CProformas::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblProformas] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblProformas] WHERE " +
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
                throw new Exception("CProformas::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
                
        public List<CProformas> GetList()
        {
            List<CProformas> RecordsList = new List<CProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblProformas";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProformas objCProformas = new CProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProformas.Id = 0;
                    else
                        objCProformas.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCProformas.Customerguid = string.Empty;
                    else
                        objCProformas.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCProformas.ReferenceNumber = string.Empty;
                    else
                        objCProformas.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                        objCProformas.Proformadate = DateTime.MinValue;
                    else
                        objCProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCProformas.Approvedby = string.Empty;
                    else
                        objCProformas.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCProformas.Approvaldate = DateTime.MinValue;
                    else
                        objCProformas.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCProformas.RequestedBy = string.Empty;
                    else
                        objCProformas.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProformas.Tablerowguid = string.Empty;
                    else
                        objCProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProformas> GetList(bool NotConvertedToInvoice)
        {
            List<CProformas> RecordsList = new List<CProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblProformas";
            if (NotConvertedToInvoice)
                command.CommandText += " Where tblProformas.TableRowGuid not in (select distinct ISNULL(ProformaGuid,'') from tblInvoices) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProformas objCProformas = new CProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                         objCProformas.Id = 0;
                    else
                        objCProformas.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCProformas.Customerguid = string.Empty;
                    else
                        objCProformas.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCProformas.ReferenceNumber = string.Empty;
                    else
                        objCProformas.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                         objCProformas.Proformadate = DateTime.MinValue;
                    else
                        objCProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                         objCProformas.Approvedby = string.Empty;
                    else
                        objCProformas.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                         objCProformas.Approvaldate = DateTime.MinValue;
                    else
                        objCProformas.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                         objCProformas.RequestedBy = string.Empty;
                    else
                        objCProformas.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProformas.Tablerowguid = string.Empty;
                    else
                        objCProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProformas> GetList(string Customerguid, bool NotConvertedToInvoice)
        {
            List<CProformas> RecordsList = new List<CProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " Select * from tblProformas ";
            strSQL += " Where tblProformas.CustomerGuid = @CustomerGuid ";
            if (NotConvertedToInvoice)
                strSQL += " AND tblProformas.TableRowGuid not in (select distinct ISNULL(ProformaGuid,'') from tblInvoices) ";

            command.CommandText = strSQL; 
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProformas objCProformas = new CProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProformas.Id = 0;
                    else
                        objCProformas.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCProformas.Customerguid = string.Empty;
                    else
                        objCProformas.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCProformas.ReferenceNumber = string.Empty;
                    else
                        objCProformas.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                        objCProformas.Proformadate = DateTime.MinValue;
                    else
                        objCProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCProformas.Approvedby = string.Empty;
                    else
                        objCProformas.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCProformas.Approvaldate = DateTime.MinValue;
                    else
                        objCProformas.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCProformas.RequestedBy = string.Empty;
                    else
                        objCProformas.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProformas.Tablerowguid = string.Empty;
                    else
                        objCProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProformas> GetList(DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotConvertedToInvoice)
        {
            List<CProformas> RecordsList = new List<CProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " Select * from tblProformas ";
            strSQL += " Where tblProformas.ProformaDate >= @ProformaDateFrom ";
            strSQL += " AND tblProformas.ProformaDate <= @ProformaDateTo ";
            if (NotConvertedToInvoice)
                strSQL += " AND tblProformas.TableRowGuid not in (select distinct IsNull(ProformaGuid,'') from tblInvoices) ";

            command.CommandText = strSQL; 
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
                    CProformas objCProformas = new CProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProformas.Id = 0;
                    else
                        objCProformas.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCProformas.Customerguid = string.Empty;
                    else
                        objCProformas.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCProformas.ReferenceNumber = string.Empty;
                    else
                        objCProformas.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                        objCProformas.Proformadate = DateTime.MinValue;
                    else
                        objCProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCProformas.Approvedby = string.Empty;
                    else
                        objCProformas.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCProformas.Approvaldate = DateTime.MinValue;
                    else
                        objCProformas.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCProformas.RequestedBy = string.Empty;
                    else
                        objCProformas.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProformas.Tablerowguid = string.Empty;
                    else
                        objCProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProformas> GetList(string Customerguid, DateTime ProformaDateFrom, DateTime ProformaDateTo, bool NotConvertedToInvoice)
        {
            List<CProformas> RecordsList = new List<CProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " Select * from tblProformas ";
            strSQL += " Where tblProformas.CustomerGuid = @CustomerGuid ";
            strSQL += " AND tblProformas.ProformaDate >= @ProformaDateFrom ";
            strSQL += " AND tblProformas.ProformaDate <= @ProformaDateTo ";
            if (NotConvertedToInvoice)
                strSQL += " AND tblProformas.TableRowGuid not in (select distinct ISNULL(ProformaGuid,'') from tblInvoices) ";

            command.CommandText = strSQL; 
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
            command.Parameters.Add(new SqlParameter("@ProformaDateFrom", ProformaDateFrom));
            command.Parameters.Add(new SqlParameter("@ProformaDateTo", ProformaDateTo));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProformas objCProformas = new CProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProformas.Id = 0;
                    else
                        objCProformas.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCProformas.Customerguid = string.Empty;
                    else
                        objCProformas.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCProformas.ReferenceNumber = string.Empty;
                    else
                        objCProformas.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                        objCProformas.Proformadate = DateTime.MinValue;
                    else
                        objCProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCProformas.Approvedby = string.Empty;
                    else
                        objCProformas.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCProformas.Approvaldate = DateTime.MinValue;
                    else
                        objCProformas.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCProformas.RequestedBy = string.Empty;
                    else
                        objCProformas.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProformas.Tablerowguid = string.Empty;
                    else
                        objCProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CProformas> GetList(string strCriteria)
        {
            List<CProformas> RecordsList = new List<CProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            string strSQL = "";
            strSQL = strSQL + " Select tblProformas.id,tblProformas.TableRowGuid,tblProformas.CustomerGuid,tblCustomers.Name,ReferenceNumber,ProformaDate,";
            strSQL = strSQL + " ApprovedBy,ApprovalDate,RequestedBy From tblProformas";
            strSQL = strSQL + " join tblCustomers on (tblProformas.CustomerGuid = tblCustomers.TableRowGuid)";
            strSQL = strSQL + " where 1 = 1 " + strCriteria;
            strSQL = strSQL + " Order by  ProformaDate, ReferenceNumber";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (connection != null) connection.Close();
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProformas objCProformas = new CProformas();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProformas.Id = 0;
                    else
                        objCProformas.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCProformas.Customerguid = string.Empty;
                    else
                        objCProformas.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCProformas.ReferenceNumber = string.Empty;
                    else
                        objCProformas.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["ProformaDate"].Equals(DBNull.Value))
                        objCProformas.Proformadate = DateTime.MinValue;
                    else
                        objCProformas.Proformadate = (DateTime)dr["ProformaDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCProformas.Approvedby = string.Empty;
                    else
                        objCProformas.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCProformas.Approvaldate = DateTime.MinValue;
                    else
                        objCProformas.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCProformas.RequestedBy = string.Empty;
                    else
                        objCProformas.RequestedBy = (string)dr["RequestedBy"];                    
                    if (dr["Name"].Equals(DBNull.Value))
                        objCProformas.OrganizationName = string.Empty;
                    else
                        objCProformas.OrganizationName = (string)dr["Name"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProformas.Tablerowguid = string.Empty;
                    else
                        objCProformas.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProformas);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformas::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProformas> GetCustomerByName()
        {
            List<CProformas> RecordsList = new List<CProformas>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select TableRowGuid,Name from tblCustomers where Name like @Name";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@Name", OrganizationName));
            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProformas objCustomer = new CProformas();
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCustomer.Customerguid = string.Empty;
                    else
                        objCustomer.Customerguid = (string)dr["TableRowGuid"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCustomer.OrganizationName = string.Empty;
                    else
                        objCustomer.OrganizationName = (string)dr["Name"];

                    RecordsList.Add(objCustomer);
                }
                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::GetList::Error! " + ex.Message, ex);
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

            string strCount = "Select Count(*) from tblProformas";
            string strMAX = "Select MAX(CAST(ReferenceNumber AS int)) from tblProformas";

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
                throw new Exception("CInvoices::GetMaxReferenceNumber::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public static bool IsRequisitionForPsychotropic(string Proformaguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = " SELECT Top 1 tblProformas.id ";
            command.CommandText += " FROM tblProformas INNER JOIN tblProformaDetails ";
            command.CommandText += " ON tblProformaDetails.ProformaGuid = tblProformas.TableRowGuid ";
            command.CommandText += " INNER JOIN tblItems ";
            command.CommandText += " ON tblProformaDetails.ItemGuid = tblItems.TableRowGuid ";
            command.CommandText += " WHERE tblProformas.TableRowGuid = @ProformaGuid ";
            command.CommandText += " AND tblItems.CategoryGuid IN ";
            command.CommandText += " (SELECT tblItemCategories.TableRowGuid From tblItemCategories ";
            command.CommandText += " WHERE tblItemCategories.CategoryType = " + ((int)CCommon.ItemCategoryType.Psychotropic).ToString();
            command.CommandText += " ) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProformaGuid", Proformaguid));
                connection.Open();
                temp = command.ExecuteScalar();
                if (temp != null)
                    if ((int)temp > 0)
                        return true;
                    else
                        return false;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::IsRequisitionForPsychotropic::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblProformas] WHERE Id = @Id";
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
                throw new Exception("CProformas::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblProformas] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CProformas::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
