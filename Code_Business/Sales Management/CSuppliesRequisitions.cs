//
// ...
// Wizard generated code
// Date: 7/27/2009 6:03:10 PM
// Class: CSuppliesRequisitions
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
    class CSuppliesRequisitions
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return   Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CSuppliesRequisitions()
        {
            _ConnectionString = ConnectionString;
        }
        public CSuppliesRequisitions(int Id, string Customerguid, string Licenseguid, string Referencenumber, DateTime Requestdate, string Approvedby, DateTime Approvaldate, string RequestedBy, DateTime Checkeddate)
        {
            _Id = Id;
            _ReferenceNumber = Referencenumber;
            _CustomerGuid = Customerguid;
            _LicenseGuid = Licenseguid;
            _RequestDate = Requestdate;
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

        string _LicenseGuid;
        public string Licenseguid
        {
            get { return _LicenseGuid; }
            set { _LicenseGuid = value; }
        }

        string _ReferenceNumber;
        public string ReferenceNumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        DateTime _RequestDate;
        public DateTime Requestdate
        {
            get { return _RequestDate; }
            set { _RequestDate = value; }
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


        string _ItemName;
        public string ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }

        #endregion

     
        
        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblSuppliesRequisitions where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblSuppliesRequisitions");
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
                    if (dTable.Rows[0]["RequestDate"].Equals(DBNull.Value))
                        _RequestDate = DateTime.MinValue;
                    else
                        _RequestDate = (DateTime)dTable.Rows[0]["RequestDate"];
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
                throw new Exception("CSuppliesRequisitions::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblSuppliesRequisitions";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblSuppliesRequisitions");
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
                throw new Exception("CSuppliesRequisitions::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblSuppliesRequisitions" +
                                   " (CustomerGuid, " +
                                   " LicenseGuid, " +
                                   " ReferenceNumber, " +
                                   " RequestDate, " +
                                   " ApprovedBy, " +
                                   " ApprovalDate, " +
                                   " RequestedBy,UserId,ComputerName,EventSource)" +
                                   " Values (@CustomerGuid, " +
                                   " @LicenseGuid, " +
                                   " @ReferenceNumber, " +
                                   " @RequestDate, " +
                                   " @ApprovedBy, " +
                                   " @ApprovalDate, " +
                                   " @RequestedBy,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblSuppliesRequisitions ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                if(_LicenseGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@LicenseGuid", DBNull.Value));
                else   
                    command.Parameters.Add(new SqlParameter("@LicenseGuid", _LicenseGuid));
                
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                
                if (_RequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", _RequestDate));
                if(_ApprovedBy == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ApprovedBy", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ApprovedBy", _ApprovedBy));
                
                if (_ApprovalDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ApprovalDate", _ApprovalDate));
                if(_RequestedBy == string.Empty)
                    command.Parameters.Add(new SqlParameter("@RequestedBy", DBNull.Value));
                else
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
                throw new Exception("CSuppliesRequisitions::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblSuppliesRequisitions" +
                                   " Set CustomerGuid = @CustomerGuid, " +
                                   " LicenseGuid = @LicenseGuid, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " RequestDate = @RequestDate, " +
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
                command.Parameters.Add(new SqlParameter("@LicenseGuid", _LicenseGuid));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                if (_RequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", _RequestDate));
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
                throw new Exception("CSuppliesRequisitions::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblSuppliesRequisitions Where Id = @Id ";
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
                throw new Exception("CSuppliesRequisitions::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblSuppliesRequisitions] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblSuppliesRequisitions] WHERE " +
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
                throw new Exception("CSuppliesRequisitions::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
                
        public List<CSuppliesRequisitions> GetList()
        {
            List<CSuppliesRequisitions> RecordsList = new List<CSuppliesRequisitions>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblSuppliesRequisitions";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSuppliesRequisitions objCSuppliesRequisitions = new CSuppliesRequisitions();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Id = 0;
                    else
                        objCSuppliesRequisitions.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Customerguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Licenseguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ReferenceNumber = string.Empty;
                    else
                        objCSuppliesRequisitions.ReferenceNumber = (string)dr["ReferenceNumber"];

                    if (dr["ItemName"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ItemName = string.Empty;
                    else
                        objCSuppliesRequisitions.ItemName = (string)dr["ItemName"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Requestdate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvedby = string.Empty;
                    else
                        objCSuppliesRequisitions.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvaldate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.RequestedBy = string.Empty;
                    else
                        objCSuppliesRequisitions.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Tablerowguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSuppliesRequisitions);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitions::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSuppliesRequisitions> GetList(bool NotConvertedToInvoice)
        {
            List<CSuppliesRequisitions> RecordsList = new List<CSuppliesRequisitions>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL;
            strSQL = " select tblSuppliesRequisitions.* ,tblItems.BrandName from tblSuppliesRequisitions";
            strSQL += " inner join tblSuppliesRequisitionDetails on tblSuppliesRequisitionDetails.SuppliesRequisitionGuid=tblSuppliesRequisitions.TableRowGuid";
            strSQL += " inner join tblItems on tblSuppliesRequisitionDetails.ItemGuid =tblItems.TableRowGuid";

            if (NotConvertedToInvoice)
                command.CommandText += " Where tblSuppliesRequisitions.TableRowGuid not in (select distinct ISNULL(SuppliesRequisitionGuid,'') from tblInvoices) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSuppliesRequisitions objCSuppliesRequisitions = new CSuppliesRequisitions();
                    if (dr["Id"].Equals(DBNull.Value))
                         objCSuppliesRequisitions.Id = 0;
                    else
                        objCSuppliesRequisitions.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Customerguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Licenseguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ReferenceNumber = string.Empty;
                    else
                        objCSuppliesRequisitions.ReferenceNumber = (string)dr["ReferenceNumber"];

                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ItemName = string.Empty;
                    else
                        objCSuppliesRequisitions.ItemName = (string)dr["BrandName"];


                    if (dr["RequestDate"].Equals(DBNull.Value))
                         objCSuppliesRequisitions.Requestdate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                         objCSuppliesRequisitions.Approvedby = string.Empty;
                    else
                        objCSuppliesRequisitions.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                         objCSuppliesRequisitions.Approvaldate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                         objCSuppliesRequisitions.RequestedBy = string.Empty;
                    else
                        objCSuppliesRequisitions.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Tablerowguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSuppliesRequisitions);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitions::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSuppliesRequisitions> GetList(string Customerguid, bool NotConvertedToInvoice)
        {
            List<CSuppliesRequisitions> RecordsList = new List<CSuppliesRequisitions>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " select tblSuppliesRequisitions.* ,tblItems.BrandName from tblSuppliesRequisitions";
            strSQL += " inner join tblSuppliesRequisitionDetails on tblSuppliesRequisitionDetails.SuppliesRequisitionGuid=tblSuppliesRequisitions.TableRowGuid";
            strSQL += " inner join tblItems on tblSuppliesRequisitionDetails.ItemGuid =tblItems.TableRowGuid";

            strSQL += " Where tblSuppliesRequisitions.CustomerGuid = @CustomerGuid ";
            if (NotConvertedToInvoice)
                strSQL += " AND tblSuppliesRequisitions.TableRowGuid not in (select distinct ISNULL(SuppliesRequisitionGuid,'') from tblInvoices) ";

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
                    CSuppliesRequisitions objCSuppliesRequisitions = new CSuppliesRequisitions();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Id = 0;
                    else
                        objCSuppliesRequisitions.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Customerguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Licenseguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ReferenceNumber = string.Empty;
                    else
                        objCSuppliesRequisitions.ReferenceNumber = (string)dr["ReferenceNumber"];

                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ItemName = string.Empty;
                    else
                        objCSuppliesRequisitions.ItemName = (string)dr["BrandName"];

                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Requestdate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvedby = string.Empty;
                    else
                        objCSuppliesRequisitions.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvaldate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.RequestedBy = string.Empty;
                    else
                        objCSuppliesRequisitions.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Tablerowguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSuppliesRequisitions);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitions::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSuppliesRequisitions> GetList(DateTime RequestDateFrom, DateTime RequestDateTo, bool NotConvertedToInvoice)
        {
            List<CSuppliesRequisitions> RecordsList = new List<CSuppliesRequisitions>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " select tblSuppliesRequisitions.* ,";
            strSQL += " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
            strSQL += " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
            strSQL += " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
            strSQL += " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
            strSQL += " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
            strSQL += " inner join tblSuppliesRequisitionDetails on tblSuppliesRequisitionDetails.ItemGuid =tblItems.TableRowGuid";
            strSQL += " inner join tblSuppliesRequisitions on tblSuppliesRequisitionDetails.SuppliesRequisitionGuid =tblSuppliesRequisitions.TableRowGuid";
            strSQL += " Where tblSuppliesRequisitions.RequestDate >= @RequestDateFrom ";
            strSQL += " AND tblSuppliesRequisitions.RequestDate <= @RequestDateTo ";
            if (NotConvertedToInvoice)
                strSQL += " AND tblSuppliesRequisitions.TableRowGuid not in (select distinct IsNull(SuppliesRequisitionGuid,'') from tblInvoices) ";

            command.CommandText = strSQL; 
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@RequestDateFrom", RequestDateFrom));
            command.Parameters.Add(new SqlParameter("@RequestDateTo", RequestDateTo));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSuppliesRequisitions objCSuppliesRequisitions = new CSuppliesRequisitions();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Id = 0;
                    else
                        objCSuppliesRequisitions.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Customerguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Licenseguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ReferenceNumber = string.Empty;
                    else
                        objCSuppliesRequisitions.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ItemName = string.Empty;
                    else
                        objCSuppliesRequisitions.ItemName = (string)dr["BrandName"];

                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Requestdate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvedby = string.Empty;
                    else
                        objCSuppliesRequisitions.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvaldate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.RequestedBy = string.Empty;
                    else
                        objCSuppliesRequisitions.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Tablerowguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSuppliesRequisitions);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitions::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSuppliesRequisitions> GetList(string Customerguid, DateTime RequestDateFrom, DateTime RequestDateTo, bool NotConvertedToInvoice)
        {
            List<CSuppliesRequisitions> RecordsList = new List<CSuppliesRequisitions>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " select tblSuppliesRequisitions.* ,tblItems.BrandName from tblSuppliesRequisitions";
            strSQL += " inner join tblSuppliesRequisitionDetails on tblSuppliesRequisitionDetails.SuppliesRequisitionGuid=tblSuppliesRequisitions.TableRowGuid";
            strSQL += " inner join tblItems on tblSuppliesRequisitionDetails.ItemGuid =tblItems.TableRowGuid";

            strSQL += " Where tblSuppliesRequisitions.CustomerGuid = @CustomerGuid ";
            strSQL += " AND tblSuppliesRequisitions.RequestDate >= @RequestDateFrom ";
            strSQL += " AND tblSuppliesRequisitions.RequestDate <= @RequestDateTo ";
            if (NotConvertedToInvoice)
                strSQL += " AND tblSuppliesRequisitions.TableRowGuid not in (select distinct ISNULL(SuppliesRequisitionGuid,'') from tblInvoices) ";

            command.CommandText = strSQL; 
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
            command.Parameters.Add(new SqlParameter("@RequestDateFrom", RequestDateFrom));
            command.Parameters.Add(new SqlParameter("@RequestDateTo", RequestDateTo));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSuppliesRequisitions objCSuppliesRequisitions = new CSuppliesRequisitions();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Id = 0;
                    else
                        objCSuppliesRequisitions.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Customerguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Licenseguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ReferenceNumber = string.Empty;
                    else
                        objCSuppliesRequisitions.ReferenceNumber = (string)dr["ReferenceNumber"];

                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ItemName = string.Empty;
                    else
                        objCSuppliesRequisitions.ItemName = (string)dr["BrandName"];

                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Requestdate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvedby = string.Empty;
                    else
                        objCSuppliesRequisitions.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvaldate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.RequestedBy = string.Empty;
                    else
                        objCSuppliesRequisitions.RequestedBy = (string)dr["RequestedBy"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Tablerowguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSuppliesRequisitions);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitions::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CSuppliesRequisitions> GetList(string strCriteria)
        {
            List<CSuppliesRequisitions> RecordsList = new List<CSuppliesRequisitions>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            string strSQL = "";
            strSQL = strSQL + " Select tblSuppliesRequisitions.id,tblSuppliesRequisitions.TableRowGuid,tblSuppliesRequisitions.CustomerGuid,tblSuppliesRequisitions.LicenseGuid,tblCustomers.Name,ReferenceNumber,RequestDate,";
            strSQL = strSQL + " ApprovedBy,ApprovalDate,RequestedBy From tblSuppliesRequisitions";
            strSQL = strSQL + " join tblCustomers on (tblSuppliesRequisitions.CustomerGuid = tblCustomers.TableRowGuid)";
            strSQL = strSQL + " where 1 = 1 " + strCriteria;
            strSQL = strSQL + " Order by  RequestDate, ReferenceNumber";

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
                    CSuppliesRequisitions objCSuppliesRequisitions = new CSuppliesRequisitions();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Id = 0;
                    else
                        objCSuppliesRequisitions.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Customerguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Licenseguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Licenseguid = (string)dr["LicenseGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.ReferenceNumber = string.Empty;
                    else
                        objCSuppliesRequisitions.ReferenceNumber = (string)dr["ReferenceNumber"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Requestdate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ApprovedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvedby = string.Empty;
                    else
                        objCSuppliesRequisitions.Approvedby = (string)dr["ApprovedBy"];
                    if (dr["ApprovalDate"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Approvaldate = DateTime.MinValue;
                    else
                        objCSuppliesRequisitions.Approvaldate = (DateTime)dr["ApprovalDate"];
                    if (dr["RequestedBy"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.RequestedBy = string.Empty;
                    else
                        objCSuppliesRequisitions.RequestedBy = (string)dr["RequestedBy"];                    
                    if (dr["Name"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.OrganizationName = string.Empty;
                    else
                        objCSuppliesRequisitions.OrganizationName = (string)dr["Name"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitions.Tablerowguid = string.Empty;
                    else
                        objCSuppliesRequisitions.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSuppliesRequisitions);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitions::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSuppliesRequisitions> GetCustomerByName()
        {
            List<CSuppliesRequisitions> RecordsList = new List<CSuppliesRequisitions>();
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
                    CSuppliesRequisitions objCustomer = new CSuppliesRequisitions();
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

            string strCount = "Select Count(*) from tblSuppliesRequisitions";
            string strMAX = "Select MAX(CAST(ReferenceNumber AS int)) from tblSuppliesRequisitions";

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
        public static int GetLicenseProfessionalLevel(string Suppliesrequisitionguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = " SELECT ProfessionalLevel = IsNull(tblLevels.ProfessionalLevel, 0) ";
            command.CommandText += " FROM tblSuppliesRequisitions INNER JOIN tblLicenses ";
            command.CommandText += " ON tblSuppliesRequisitions.LicenseGuid = tblLicenses.TableRowGuid ";
            command.CommandText += " INNER JOIN tblLevels ";
            command.CommandText += " ON tblLicenses.LevelGuid = tblLevels.TableRowGuid ";
            command.CommandText += " WHERE tblSuppliesRequisitions.TableRowGuid = @SuppliesRequisitionGuid ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", Suppliesrequisitionguid));
                connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetLicenseProfessionalLevel::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public static bool IsRequisitionForPsychotropic(string Suppliesrequisitionguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = " SELECT Top 1 tblSuppliesRequisitions.id ";
            command.CommandText += " FROM tblSuppliesRequisitions INNER JOIN tblSuppliesRequisitionDetails ";
            command.CommandText += " ON tblSuppliesRequisitionDetails.SuppliesRequisitionGuid = tblSuppliesRequisitions.TableRowGuid ";
            command.CommandText += " INNER JOIN tblItems ";
            command.CommandText += " ON tblSuppliesRequisitionDetails.ItemGuid = tblItems.TableRowGuid ";
            command.CommandText += " WHERE tblSuppliesRequisitions.TableRowGuid = @SuppliesRequisitionGuid ";
            command.CommandText += " AND tblItems.CategoryGuid IN ";
            command.CommandText += " (SELECT tblItemCategories.TableRowGuid From tblItemCategories ";
            command.CommandText += " WHERE tblItemCategories.CategoryType = " + ((int)CCommon.ItemCategoryType.Psychotropic).ToString();
            command.CommandText += " ) ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", Suppliesrequisitionguid));
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblSuppliesRequisitions] WHERE Id = @Id";
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
                throw new Exception("CSuppliesRequisitions::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblSuppliesRequisitions] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CSuppliesRequisitions::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
