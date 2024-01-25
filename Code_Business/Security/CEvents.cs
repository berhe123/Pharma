//
// ...
// Wizard generated code
// Date: 2/24/2010 6:12:35 PM
// Class: CEvents
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
    class CEvents
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }
        public CEvents()
        {
            _ConnectionString = ConnectionString;
        }
        public CEvents(long Id, string Tablename, string Tableidfieldname, int Tableid, string Userid, string Username, DateTime Eventdate, DateTime Eventtime, int Eventtype, string Searchfield, string Searchvalue, string Computername, string Tablefields, string Datafrom, string Datato, bool Restored, bool Merged, string Tablerowguid)
        {
            _id = Id;
            _TableName = Tablename;
            _TableIdFieldName = Tableidfieldname;
            _TableId = Tableid;
            _UserId = Userid;
            _UserName = Username;
            _EventDate = Eventdate;
            _EventTime = Eventtime;
            _EventType = Eventtype;
            _SearchField = Searchfield;
            _SearchValue = Searchvalue;
            _ComputerName = Computername;
            _TableFields = Tablefields;
            _DataFrom = Datafrom;
            _DataTo = Datato;
            _Restored = Restored;
            _Merged = Merged;
            _TableRowGuid = Tablerowguid;
        }

        #region Class Property Declarations
        long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _TableName;
        public string Tablename
        {
            get { return _TableName; }
            set { _TableName = value; }
        }

        string _TableIdFieldName;
        public string Tableidfieldname
        {
            get { return _TableIdFieldName; }
            set { _TableIdFieldName = value; }
        }

        int _TableId;
        public int Tableid
        {
            get { return _TableId; }
            set { _TableId = value; }
        }

        string _UserId;
        public string Userid
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        string _UserName;
        public string Username
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        DateTime _EventDate;
        public DateTime Eventdate
        {
            get { return _EventDate; }
            set { _EventDate = value; }
        }

        DateTime _EventTime;
        public DateTime Eventtime
        {
            get { return _EventTime; }
            set { _EventTime = value; }
        }

        int _EventType;
        public int Eventtype
        {
            get { return _EventType; }
            set { _EventType = value; }
        }

        string _SearchField;
        public string Searchfield
        {
            get { return _SearchField; }
            set { _SearchField = value; }
        }

        string _SearchValue;
        public string Searchvalue
        {
            get { return _SearchValue; }
            set { _SearchValue = value; }
        }

        string _ComputerName;
        public string Computername
        {
            get { return _ComputerName; }
            set { _ComputerName = value; }
        }

        string _TableFields;
        public string Tablefields
        {
            get { return _TableFields; }
            set { _TableFields = value; }
        }

        string _DataFrom;
        public string Datafrom
        {
            get { return _DataFrom; }
            set { _DataFrom = value; }
        }

        string _DataTo;
        public string Datato
        {
            get { return _DataTo; }
            set { _DataTo = value; }
        }

        bool _Restored;
        public bool Restored
        {
            get { return _Restored; }
            set { _Restored = value; }
        }

        bool _Merged;
        public bool Merged
        {
            get { return _Merged; }
            set { _Merged = value; }
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
            command.CommandText = "Select * from tblEvents where id=@id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblEvents");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", _id));
                connection.Open();
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    _id = (int)dTable.Rows[0]["id"];
                    if (dTable.Rows[0]["TableName"].Equals(DBNull.Value))
                        _TableName = string.Empty;
                    else
                        _TableName = (string)dTable.Rows[0]["TableName"];
                    if (dTable.Rows[0]["TableIdFieldName"].Equals(DBNull.Value))
                        _TableIdFieldName = string.Empty;
                    else
                        _TableIdFieldName = (string)dTable.Rows[0]["TableIdFieldName"];
                    if (dTable.Rows[0]["TableId"].Equals(DBNull.Value))
                        _TableId = 0;
                    else
                        _TableId = (int)dTable.Rows[0]["TableId"];
                    if (dTable.Rows[0]["UserId"].Equals(DBNull.Value))
                        _UserId = string.Empty;
                    else
                        _UserId = (string)dTable.Rows[0]["UserId"];
                    if (dTable.Rows[0]["UserName"].Equals(DBNull.Value))
                        _UserName = string.Empty;
                    else
                        _UserName = (string)dTable.Rows[0]["UserName"];
                    if (dTable.Rows[0]["EventDate"].Equals(DBNull.Value))
                        _EventDate = DateTime.MinValue;
                    else
                        _EventDate = (DateTime)dTable.Rows[0]["EventDate"];
                    if (dTable.Rows[0]["EventTime"].Equals(DBNull.Value))
                        _EventTime = DateTime.MinValue;
                    else
                        _EventTime = (DateTime)dTable.Rows[0]["EventTime"];
                    if (dTable.Rows[0]["EventType"].Equals(DBNull.Value))
                        _EventType = 0;
                    else
                        _EventType = (int)dTable.Rows[0]["EventType"];
                    if (dTable.Rows[0]["SearchField"].Equals(DBNull.Value))
                        _SearchField = string.Empty;
                    else
                        _SearchField = (string)dTable.Rows[0]["SearchField"];
                    if (dTable.Rows[0]["SearchValue"].Equals(DBNull.Value))
                        _SearchValue = string.Empty;
                    else
                        _SearchValue = (string)dTable.Rows[0]["SearchValue"];
                    if (dTable.Rows[0]["ComputerName"].Equals(DBNull.Value))
                        _ComputerName = string.Empty;
                    else
                        _ComputerName = (string)dTable.Rows[0]["ComputerName"];
                    if (dTable.Rows[0]["TableFields"].Equals(DBNull.Value))
                        _TableFields = string.Empty;
                    else
                        _TableFields = (string)dTable.Rows[0]["TableFields"];
                    if (dTable.Rows[0]["DataFrom"].Equals(DBNull.Value))
                        _DataFrom = string.Empty;
                    else
                        _DataFrom = (string)dTable.Rows[0]["DataFrom"];
                    if (dTable.Rows[0]["DataTo"].Equals(DBNull.Value))
                        _DataTo = string.Empty;
                    else
                        _DataTo = (string)dTable.Rows[0]["DataTo"];
                    if (dTable.Rows[0]["Restored"].Equals(DBNull.Value))
                        _Restored = false;
                    else
                        _Restored = (bool)dTable.Rows[0]["Restored"];
                    if (dTable.Rows[0]["Merged"].Equals(DBNull.Value))
                        _Merged = false;
                    else
                        _Merged = (bool)dTable.Rows[0]["Merged"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblEvents";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblEvents");
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
                throw new Exception("CEvents::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblEvents" +
                                   " (TableName, " +
                                   " TableIdFieldName, " +
                                   " TableId, " +
                                   " UserId, " +
                                   " UserName, " +
                                   " EventDate, " +
                                   " EventTime, " +
                                   " EventType, " +
                                   " SearchField, " +
                                   " SearchValue, " +
                                   " ComputerName, " +
                                   " TableFields, " +
                                   " DataFrom, " +
                                   " DataTo, " +
                                   " Restored, " +
                                   " Merged, " +
                                   " TableRowGuid)" +
                                   " Values (@TableName, " +
                                   " @TableIdFieldName, " +
                                   " @TableId, " +
                                   " @UserId, " +
                                   " @UserName, " +
                                   " @EventDate, " +
                                   " @EventTime, " +
                                   " @EventType, " +
                                   " @SearchField, " +
                                   " @SearchValue, " +
                                   " @ComputerName, " +
                                   " @TableFields, " +
                                   " @DataFrom, " +
                                   " @DataTo, " +
                                   " @Restored, " +
                                   " @Merged, " +
                                   " @TableRowGuid)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TableName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TableName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableName", _TableName));
                if (_TableIdFieldName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TableIdFieldName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableIdFieldName", _TableIdFieldName));
                if (_TableId == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@TableId", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableId", _TableId));
                if (_UserId == string.Empty)
                    command.Parameters.Add(new SqlParameter("@UserId", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@UserId", _UserId));
                if (_UserName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@UserName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@UserName", _UserName));
                if (_EventDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@EventDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EventDate", _EventDate));
                if (_EventTime == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@EventTime", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EventTime", _EventTime));
                if (_EventType == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@EventType", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EventType", _EventType));
                if (_SearchField == string.Empty)
                    command.Parameters.Add(new SqlParameter("@SearchField", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SearchField", _SearchField));
                if (_SearchValue == string.Empty)
                    command.Parameters.Add(new SqlParameter("@SearchValue", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SearchValue", _SearchValue));
                if (_ComputerName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ComputerName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ComputerName", _ComputerName));
                if (_TableFields == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TableFields", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableFields", _TableFields));
                if (_DataFrom == string.Empty)
                    command.Parameters.Add(new SqlParameter("@DataFrom", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DataFrom", _DataFrom));
                if (_DataTo == string.Empty)
                    command.Parameters.Add(new SqlParameter("@DataTo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DataTo", _DataTo));
                if (_Restored == false)
                    command.Parameters.Add(new SqlParameter("@Restored", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Restored", _Restored));
                if (_Merged ==false)
                    command.Parameters.Add(new SqlParameter("@Merged", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Merged", _Merged));
                if (_TableRowGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TableRowGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableRowGuid", _TableRowGuid));

                command.Parameters.Add(new SqlParameter("@id", _id));
                command.Parameters["@id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _id = (int)command.Parameters["@id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblEvents" +
                                   " Set TableName = @TableName, " +
                                   " TableIdFieldName = @TableIdFieldName, " +
                                   " TableId = @TableId, " +
                                   " UserId = @UserId, " +
                                   " UserName = @UserName, " +
                                   " EventDate = @EventDate, " +
                                   " EventTime = @EventTime, " +
                                   " EventType = @EventType, " +
                                   " SearchField = @SearchField, " +
                                   " SearchValue = @SearchValue, " +
                                   " ComputerName = @ComputerName, " +
                                   " TableFields = @TableFields, " +
                                   " DataFrom = @DataFrom, " +
                                   " DataTo = @DataTo, " +
                                   " Restored = @Restored, " +
                                   " Merged = @Merged, " +
                                   " TableRowGuid = @TableRowGuid" +
                                   " Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TableName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TableName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableName", _TableName));
                if (_TableIdFieldName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TableIdFieldName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableIdFieldName", _TableIdFieldName));
                if (_TableId == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@TableId", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableId", _TableId));
                if (_UserId == string.Empty)
                    command.Parameters.Add(new SqlParameter("@UserId", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@UserId", _UserId));
                if (_UserName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@UserName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@UserName", _UserName));
                if (_EventDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@EventDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EventDate", _EventDate));
                if (_EventTime == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@EventTime", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EventTime", _EventTime));
                if (_EventType == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@EventType", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EventType", _EventType));
                if (_SearchField == string.Empty)
                    command.Parameters.Add(new SqlParameter("@SearchField", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SearchField", _SearchField));
                if (_SearchValue == string.Empty)
                    command.Parameters.Add(new SqlParameter("@SearchValue", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SearchValue", _SearchValue));
                if (_ComputerName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ComputerName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ComputerName", _ComputerName));
                if (_TableFields == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TableFields", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableFields", _TableFields));
                if (_DataFrom == string.Empty)
                    command.Parameters.Add(new SqlParameter("@DataFrom", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DataFrom", _DataFrom));
                if (_DataTo == string.Empty)
                    command.Parameters.Add(new SqlParameter("@DataTo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DataTo", _DataTo));
                if (_Restored == false)
                    command.Parameters.Add(new SqlParameter("@Restored", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Restored", _Restored));
                if (_Merged == false)
                    command.Parameters.Add(new SqlParameter("@Merged", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Merged", _Merged));
                if (_TableRowGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TableRowGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TableRowGuid", _TableRowGuid));
                command.Parameters.Add(new SqlParameter("@id", _id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblEvents Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", _id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT id FROM [dbo].[tblEvents] WHERE " +
                                       " ";
            else
                command.CommandText = "SELECT id FROM [dbo].[tblEvents] WHERE " +
                                       "  " +
                                       " AND id <> @id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (!bNew)
                    command.Parameters.Add(new SqlParameter("@id", _id));
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
                throw new Exception("CEvents::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CEvents> GetList(string strCriteria)
        {
            List<CEvents> RecordsList = new List<CEvents>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblEvents where 1=1 " + strCriteria;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CEvents objCEvents = new CEvents();
                    if (dr["id"].Equals(DBNull.Value))
                        objCEvents.Id = 0;
                    else
                        objCEvents.Id = (long)dr["id"];
                    if (dr["TableName"].Equals(DBNull.Value))
                        objCEvents.Tablename = string.Empty;
                    else
                        objCEvents.Tablename = (string)dr["TableName"];
                    if (dr["TableIdFieldName"].Equals(DBNull.Value))
                        objCEvents.Tableidfieldname = string.Empty;
                    else
                        objCEvents.Tableidfieldname = (string)dr["TableIdFieldName"];
                    if (dr["TableId"].Equals(DBNull.Value))
                        objCEvents.Tableid = 0;
                    else
                        objCEvents.Tableid = (int)dr["TableId"];
                    if (dr["UserId"].Equals(DBNull.Value))
                        objCEvents.Userid = string.Empty;
                    else
                        objCEvents.Userid = (string)dr["UserId"];
                    if (dr["UserName"].Equals(DBNull.Value))
                        objCEvents.Username = string.Empty;
                    else
                        objCEvents.Username = (string)dr["UserName"];
                    if (dr["EventDate"].Equals(DBNull.Value))
                        objCEvents.Eventdate = DateTime.MinValue;
                    else
                        objCEvents.Eventdate = (DateTime)dr["EventDate"];
                    if (dr["EventTime"].Equals(DBNull.Value))
                        objCEvents.Eventtime = DateTime.MinValue;
                    else
                        objCEvents.Eventtime = (DateTime)dr["EventTime"];
                    if (dr["EventType"].Equals(DBNull.Value))
                        objCEvents.Eventtype = 0;
                    else
                        objCEvents.Eventtype = (int)dr["EventType"];
                    if (dr["SearchField"].Equals(DBNull.Value))
                        objCEvents.Searchfield = string.Empty;
                    else
                        objCEvents.Searchfield = (string)dr["SearchField"];
                    if (dr["SearchValue"].Equals(DBNull.Value))
                        objCEvents.Searchvalue = string.Empty;
                    else
                        objCEvents.Searchvalue = (string)dr["SearchValue"];
                    if (dr["ComputerName"].Equals(DBNull.Value))
                        objCEvents.Computername = string.Empty;
                    else
                        objCEvents.Computername = (string)dr["ComputerName"];
                    if (dr["TableFields"].Equals(DBNull.Value))
                        objCEvents.Tablefields = string.Empty;
                    else
                        objCEvents.Tablefields = (string)dr["TableFields"];
                    if (dr["DataFrom"].Equals(DBNull.Value))
                        objCEvents.Datafrom = string.Empty;
                    else
                        objCEvents.Datafrom = (string)dr["DataFrom"];
                    if (dr["DataTo"].Equals(DBNull.Value))
                        objCEvents.Datato = string.Empty;
                    else
                        objCEvents.Datato = (string)dr["DataTo"];
                    if (dr["Restored"].Equals(DBNull.Value))
                        objCEvents.Restored = false;
                    else
                        objCEvents.Restored = (bool)dr["Restored"];
                    if (dr["Merged"].Equals(DBNull.Value))
                        objCEvents.Merged = false;
                    else
                        objCEvents.Merged = (bool)dr["Merged"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCEvents.Tablerowguid = string.Empty;
                    else
                        objCEvents.Tablerowguid = (string)dr["TableRowGuid"];                   
                   
                    RecordsList.Add(objCEvents);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CEvents> GetList(string strCriteria,CCommon.ColumnCriteria [] strColumnCriteria)
        {
            List<CEvents> RecordsList = new List<CEvents>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblEvents where 1=1 " + strCriteria;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CEvents objCEvents = new CEvents();
                    if (dr["id"].Equals(DBNull.Value))
                        objCEvents.Id = 0;
                    else
                        objCEvents.Id = (long)dr["id"];
                    if (dr["TableName"].Equals(DBNull.Value))
                        objCEvents.Tablename = string.Empty;
                    else
                        objCEvents.Tablename = (string)dr["TableName"];
                    if (dr["TableIdFieldName"].Equals(DBNull.Value))
                        objCEvents.Tableidfieldname = string.Empty;
                    else
                        objCEvents.Tableidfieldname = (string)dr["TableIdFieldName"];
                    if (dr["TableId"].Equals(DBNull.Value))
                        objCEvents.Tableid = 0;
                    else
                        objCEvents.Tableid = (int)dr["TableId"];
                    if (dr["UserId"].Equals(DBNull.Value))
                        objCEvents.Userid = string.Empty;
                    else
                        objCEvents.Userid = (string)dr["UserId"];
                    if (dr["UserName"].Equals(DBNull.Value))
                        objCEvents.Username = string.Empty;
                    else
                        objCEvents.Username = (string)dr["UserName"];
                    if (dr["EventDate"].Equals(DBNull.Value))
                        objCEvents.Eventdate = DateTime.MinValue;
                    else
                        objCEvents.Eventdate = (DateTime)dr["EventDate"];
                    if (dr["EventTime"].Equals(DBNull.Value))
                        objCEvents.Eventtime = DateTime.MinValue;
                    else
                        objCEvents.Eventtime = (DateTime)dr["EventTime"];
                    if (dr["EventType"].Equals(DBNull.Value))
                        objCEvents.Eventtype = 0;
                    else
                        objCEvents.Eventtype = (int)dr["EventType"];
                    if (dr["SearchField"].Equals(DBNull.Value))
                        objCEvents.Searchfield = string.Empty;
                    else
                        objCEvents.Searchfield = (string)dr["SearchField"];
                    if (dr["SearchValue"].Equals(DBNull.Value))
                        objCEvents.Searchvalue = string.Empty;
                    else
                        objCEvents.Searchvalue = (string)dr["SearchValue"];
                    if (dr["ComputerName"].Equals(DBNull.Value))
                        objCEvents.Computername = string.Empty;
                    else
                        objCEvents.Computername = (string)dr["ComputerName"];
                    if (dr["TableFields"].Equals(DBNull.Value))
                        objCEvents.Tablefields = string.Empty;
                    else
                        objCEvents.Tablefields = (string)dr["TableFields"];
                    if (dr["DataFrom"].Equals(DBNull.Value))
                        objCEvents.Datafrom = string.Empty;
                    else
                        objCEvents.Datafrom = (string)dr["DataFrom"];
                    if (dr["DataTo"].Equals(DBNull.Value))
                        objCEvents.Datato = string.Empty;
                    else
                        objCEvents.Datato = (string)dr["DataTo"];
                    if (dr["Restored"].Equals(DBNull.Value))
                        objCEvents.Restored = false;
                    else
                        objCEvents.Restored = (bool)dr["Restored"];
                    if (dr["Merged"].Equals(DBNull.Value))
                        objCEvents.Merged = false;
                    else
                        objCEvents.Merged = (bool)dr["Merged"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCEvents.Tablerowguid = string.Empty;
                    else
                        objCEvents.Tablerowguid = (string)dr["TableRowGuid"];
                    if (strColumnCriteria.Length > 0)
                    {
                        if (CheckColumnCriteria(objCEvents, strColumnCriteria))
                            RecordsList.Add(objCEvents);
                    }
                    else
                        RecordsList.Add(objCEvents);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public string GetSearchField(string strTableName)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strReturn = "";
            command.CommandText = "Select top 1 SearchField from tblEvents where TableName=@TableName";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@TableName", strTableName));
            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr["SearchField"].Equals(DBNull.Value))
                        strReturn = string.Empty;
                    else
                        strReturn = (string)dr["SearchField"];
                }

                return strReturn;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        private bool CheckColumnCriteria(CEvents objEvent, CCommon.ColumnCriteria [] strColumnCriteria)
        {            
            bool blnReturn = true;           
            string[] strColumnNames = objEvent.Tablefields.ToString().Split(',');
            string[] strDataFrom = new string[strColumnNames.Length];
            string[] strDataTo = new string[strColumnNames.Length];
            if(objEvent.Eventtype == (int)CCommon.EventType.Delete)
               strDataFrom = objEvent.Datafrom.ToString().Split('|');
            else if (objEvent.Eventtype == (int)CCommon.EventType.Insert)
                strDataTo = objEvent.Datato.ToString().Split('|');
            else
            {
                strDataFrom = objEvent.Datafrom.ToString().Split('|');
                strDataTo = objEvent.Datato.ToString().Split('|');
            }
            for (int i = 0; i < strColumnCriteria.Length; i++)
            {
                for(int j=0;j<strColumnNames.Length;j++ )
                {
                    if (strColumnCriteria[i].ColumnName == strColumnNames[j])
                        if (objEvent.Eventtype == (int)CCommon.EventType.Delete)
                        {
                            if (strColumnCriteria[i].ColumnType == 61) //DateTime Column
                            {
                                DateTime dteColumnValue = Convert.ToDateTime(strDataFrom[j]);
                                DateTime dteCriteriaValue = Convert.ToDateTime(strColumnCriteria[i].Value);

                                if (strColumnCriteria[i].Operator == "=")
                                    if (dteColumnValue == dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">=")
                                    if (dteColumnValue >= dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">")
                                    if (dteColumnValue > dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<=")
                                    if (dteColumnValue <= dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<")
                                    if (dteColumnValue < dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                            }
                            else if (strColumnCriteria[i].ColumnType == 56 | strColumnCriteria[i].ColumnType == 127) //int and bigint
                            {
                                long lngColumnValue = Convert.ToInt64(strDataFrom[j]);
                                long lngCriteriaValue = Convert.ToInt64(strColumnCriteria[i].Value);

                                if (strColumnCriteria[i].Operator == "=")
                                    if (lngColumnValue == lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">=")
                                    if (lngColumnValue >= lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">")
                                    if (lngColumnValue > lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<=")
                                    if (lngColumnValue <= lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<")
                                    if (lngColumnValue < lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                            }
                            else if (strColumnCriteria[i].ColumnType == 62 | strColumnCriteria[i].ColumnType == 106) //float and decimal
                            {
                                decimal decColumnValue = Convert.ToDecimal(strDataFrom[j]);
                                decimal decCriteriaValue = Convert.ToDecimal(strColumnCriteria[i].Value);
                                if (strColumnCriteria[i].Operator == "=")
                                    if (decColumnValue == decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">=")
                                    if (decColumnValue >= decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">")
                                    if (decColumnValue > decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<=")
                                    if (decColumnValue <= decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<")
                                    if (decColumnValue < decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                            }
                            else if (strColumnCriteria[i].ColumnType == 104) //boolean
                            {
                                bool blnColumnValue = Convert.ToBoolean(strDataFrom[j]);
                                bool blnCriteriaValue;
                                if(strColumnCriteria[i].Value == "0")
                                     blnCriteriaValue = false;
                                else
                                    blnCriteriaValue = true;
                                if (strColumnCriteria[i].Operator == "=")
                                    if (blnColumnValue == blnCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;                              
                            }
                            else
                            {
                                string strColumnValue = Convert.ToString(strDataFrom[j]);
                                string strCriteriaValue = Convert.ToString(strColumnCriteria[i].Value);
                                if (strColumnCriteria[i].Operator == "=")
                                    if (strColumnValue == strCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "like")
                                    if (strColumnValue.Substring(0, strCriteriaValue.Length) == strCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                            }
                        }
                        else
                        {
                            if (strColumnCriteria[i].ColumnType == 61) //DateTime Column
                            {
                                DateTime dteColumnValue = Convert.ToDateTime(strDataTo[j]);
                                DateTime dteCriteriaValue = Convert.ToDateTime(strColumnCriteria[i].Value);

                                if (strColumnCriteria[i].Operator == "=")
                                    if (dteColumnValue == dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">=")
                                    if (dteColumnValue >= dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">")
                                    if (dteColumnValue > dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<=")
                                    if (dteColumnValue <= dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<")
                                    if (dteColumnValue < dteCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                            }
                            else if (strColumnCriteria[i].ColumnType == 56 | strColumnCriteria[i].ColumnType == 127)
                            {
                                long lngColumnValue = Convert.ToInt64(strDataTo[j]);
                                long lngCriteriaValue = Convert.ToInt64(strColumnCriteria[i].Value);

                                if (strColumnCriteria[i].Operator == "=")
                                    if (lngColumnValue == lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">=")
                                    if (lngColumnValue >= lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">")
                                    if (lngColumnValue > lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<=")
                                    if (lngColumnValue <= lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<")
                                    if (lngColumnValue < lngCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                            }
                            else if (strColumnCriteria[i].ColumnType == 62 | strColumnCriteria[i].ColumnType == 106)
                            {
                                decimal decColumnValue = Convert.ToDecimal(strDataTo[j]);
                                decimal decCriteriaValue = Convert.ToDecimal(strColumnCriteria[i].Value);
                                if (strColumnCriteria[i].Operator == "=")
                                    if (decColumnValue == decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">=")
                                    if (decColumnValue >= decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == ">")
                                    if (decColumnValue > decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<=")
                                    if (decColumnValue <= decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "<")
                                    if (decColumnValue < decCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                            }
                            else if (strColumnCriteria[i].ColumnType == 104) //boolean
                            {
                                bool blnColumnValue = Convert.ToBoolean(strDataFrom[j]);
                                bool blnCriteriaValue;
                                if (strColumnCriteria[i].Value == "0")
                                    blnCriteriaValue = false;
                                else
                                    blnCriteriaValue = true;
                                if (strColumnCriteria[i].Operator == "=")
                                    if (blnColumnValue == blnCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                            }
                            else
                            {
                                string strColumnValue = Convert.ToString(strDataTo[j]);
                                string strCriteriaValue = Convert.ToString(strColumnCriteria[i].Value);
                                if (strColumnCriteria[i].Operator == "=")
                                    if (strColumnValue == strCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                                else if (strColumnCriteria[i].Operator == "like")
                                    if (strColumnValue.Substring(0, strCriteriaValue.Length) == strCriteriaValue)
                                        blnReturn = true;
                                    else
                                        return false;
                            }
                        }
                   
                }
              
            }
            return blnReturn;
        }
        public DataTable ShowEventData()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            command.CommandText = "Select TableFields,DataFrom,DataTo,EventType,TableRowGuid from tblEvents where id=@id";
            command.CommandType = CommandType.Text;
            DataTable tblEventData = new DataTable("tblEventData");
            command.Connection = connection;

            string strTableFields;
            string strDataFrom;
            string strDataTo;
            int intEventType;
            string strTableRowGuid;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", _id));
                connection.Open();
                dr = command.ExecuteReader();
                dr.Read();
                if (dr["TableFields"].Equals(DBNull.Value))
                    strTableFields = string.Empty;
                else
                    strTableFields = (string)dr["TableFields"];
                if (dr["DataFrom"].Equals(DBNull.Value))
                    strDataFrom = string.Empty;
                else
                    strDataFrom = (string)dr["DataFrom"];
                if (dr["DataTo"].Equals(DBNull.Value))
                    strDataTo = string.Empty;
                else
                    strDataTo = (string)dr["DataTo"];
                if (dr["TableRowGuid"].Equals(DBNull.Value))
                    strTableRowGuid = string.Empty;
                else
                    strTableRowGuid = (string)dr["TableRowGuid"];
                if (dr["EventType"].Equals(DBNull.Value))
                    intEventType = 0;
                else
                    intEventType = (int)dr["EventType"];

                DataColumn dataColumnDispaly = new DataColumn(" ", typeof(string));
                tblEventData.Columns.Add(dataColumnDispaly);

                DataColumn dataColumnGuid = new DataColumn("Guid", typeof(string));
                tblEventData.Columns.Add(dataColumnGuid);
                DataColumn dataColumnEventType = new DataColumn("EventType", typeof(Int32));
                tblEventData.Columns.Add(dataColumnEventType);

                string[] strFieldArray = strTableFields.Split(',');
                for (int i = 0; i < strFieldArray.Length; i++)
                {
                    DataColumn dc = new DataColumn(strFieldArray[i].ToString());
                    tblEventData.Columns.Add(dc);
                }
                if (intEventType == (int)CCommon.EventType.Delete)
                {
                    string[] strDataFromArray = strDataFrom.Split('|');
                    DataRow drFrom = tblEventData.NewRow();
                    drFrom[0] = "Deleted Data";
                    drFrom[1] = strTableRowGuid;
                    drFrom[2] = intEventType;

                    for (int i = 0; i < strDataFromArray.Length; i++)
                        drFrom[i + 3] = strDataFromArray[i];
                    tblEventData.Rows.Add(drFrom);    
                }
                else if (intEventType == (int)CCommon.EventType.Update)
                {
                    string[] strDataFromArray = strDataFrom.Split('|');
                    string[] strDataToArray = strDataTo.Split('|');
                    DataRow drFrom = tblEventData.NewRow();
                    drFrom[0] = "Data Updated From";
                    drFrom[1] = strTableRowGuid;
                    drFrom[2] = intEventType;
                    for (int i = 0; i < strDataFromArray.Length; i++)
                        drFrom[i + 3] = strDataFromArray[i];
                    tblEventData.Rows.Add(drFrom);
                    DataRow drTo = tblEventData.NewRow();
                    drTo[0] = "Data Updated To";
                    drTo[1] = strTableRowGuid;
                    drTo[2] = intEventType;
                    for (int i = 0; i < strDataToArray.Length; i++)
                        drTo[i + 3] = strDataToArray[i];
                    tblEventData.Rows.Add(drTo);

                }
                else
                {
                    string[] strDataToArray = strDataTo.Split('|');
                    DataRow drTo = tblEventData.NewRow();
                    drTo[0] = "Inserted Data";
                    drTo[1] = strTableRowGuid;
                    drTo[2] = intEventType;
                    for (int i = 0; i < strDataToArray.Length; i++)
                        drTo[i + 3] = strDataToArray[i];
                    tblEventData.Rows.Add(drTo);
                }
                return tblEventData;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetRecord::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (dr != null) dr.Dispose();
            }
        }
        public long CheckLatestEvent(string strCriteria)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            string strSQL = "";
            strSQL = strSQL +  " Select Max(id) id from tblEvents " ;
            strSQL = strSQL + " where 1=1" + strCriteria ;
               
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
                    if (dr["id"].Equals(DBNull.Value))
                        return 0;
                    else
                        return (long)dr["id"];
                }
                else
                    return 0;

            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetRecord::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (dr != null) dr.Dispose();
            }
        }
        public bool CheckColumnsAreSame(string strtblName, string strGuid)
        {
            string[] strFields = GetTableFieldsFromEvent(strGuid);
            DataTable dtColumns = GetTableFieldsCurrent(strtblName);
            foreach (DataRow dr in dtColumns.Rows)
            {
                int i = 0;
                for (i = 0; i < strFields.Length; i++)
                {
                    if (dr["name"].ToString() == strFields[i])
                        break;
                }
                if (i == strFields.Length)
                    return false;                
            }
            return true;

        }
        private string[] GetTableFieldsFromEvent(string strGuid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            command.CommandText = "Select TableFields from tblEvents where TableRowGuid=@TableRowGuid";
            command.CommandType = CommandType.Text;
            DataTable tblEventData = new DataTable("tblEventData");
            command.Connection = connection;

            string strTableFields = "";
            try
            {
                command.Parameters.Add(new SqlParameter("@TableRowGuid", strGuid));
                connection.Open();
                dr = command.ExecuteReader();
                dr.Read();
                if (dr["TableFields"].Equals(DBNull.Value))
                    strTableFields = string.Empty;
                else
                    strTableFields = (string)dr["TableFields"];

                string[] strFieldArray = strTableFields.Split(',');
                return strFieldArray;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetRecord::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (dr != null) dr.Dispose();
            }
        }
        public bool SetEventToResored(long lngEventId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblEvents" +
                                   " Set Restored = @Restored " +                              
                                   " Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Restored", 1));
                command.Parameters.Add(new SqlParameter("@id", lngEventId));
                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                if (_rowsAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::Update::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private DataTable GetTableFieldsCurrent(string strTableName)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            command.CommandText = "Select name,xtype,status from syscolumns where id=(select id from sysobjects where name=@TableName)";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                command.Parameters.Add(new SqlParameter("@TableName", strTableName));
                connection.Open();
                da.Fill(dt);
                return dt;
              
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetRecord::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (da != null) da.Dispose();
            }
        }
        public bool RestoreInsertEvent(long lngEventId)
        {
           
            DataTable dtRowToBeRestored = new DataTable();
            dtRowToBeRestored = GetRowToRestore(lngEventId);
            
            string strSQL = "";
            strSQL = strSQL + "Delete " + dtRowToBeRestored.Rows[0]["TableName"].ToString() + " where TableRowGuid = '" + dtRowToBeRestored.Rows[0]["TableRowGuid"].ToString() + "'";
            if (CCommon.ExecuteQuery(strSQL,_ConnectionString))
                return true;
            else
                return false;                      
        }
        private DataTable GetRowToRestore(long lngEventId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            command.CommandText = "Select * from tblEvents where id=@id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                command.Parameters.Add(new SqlParameter("@id", lngEventId));
                connection.Open();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetRecord::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (da != null) da.Dispose();
            }
        }
        public bool RestoreDeleteEvent(long lngEventId)
        {

            DataTable dtRowToBeRestored = new DataTable();
            DataTable dtColumns = new DataTable();
            dtRowToBeRestored = GetRowToRestore(lngEventId);
            
            string[] strFields = dtRowToBeRestored.Rows[0]["TableFields"].ToString().Split(',');
            string[] strDataFrom = dtRowToBeRestored.Rows[0]["DataFrom"].ToString().Split('|');
            string strTableName = dtRowToBeRestored.Rows[0]["TableName"].ToString();
            string strRowGuid = dtRowToBeRestored.Rows[0]["TableRowGuid"].ToString();
            dtColumns = GetTableFieldsCurrent(strTableName);
            string strSQL = "";
            strSQL = strSQL + " Insert " + strTableName;
            strSQL = strSQL + " ( ";
            int j = 0;
            for (int i = 0; i < strFields.Length; i++)
            {
                if (j == 0)
                {
                    if (!CheckIfIdentity(dtColumns, strFields[i]))
                    {
                        j++;
                        strSQL = strSQL + strFields[i];
                    }
                }
                else
                {
                    if (!CheckIfIdentity(dtColumns, strFields[i]))
                    {
                        j++;
                        strSQL = strSQL + "," + strFields[i];
                    }
                }
            }
            j = 0;
            strSQL = strSQL + " ) values ( ";
            for (int i = 0; i < strFields.Length; i++)
            {
                if (j == 0)
                {
                    if (!CheckIfIdentity(dtColumns, strFields[i]))
                    {
                        j++;
                        int intColumnType = GetColumnType(dtColumns, strFields[i]);
                        if(intColumnType == 231 | intColumnType == 61)
                            strSQL = strSQL + "'" + strDataFrom[i] + "'"; 
                        else
                            if (strFields[i] == "EventSource")
                                strSQL = strSQL + (int)CCommon.EventSource.Restored; 
                            else
                                strSQL = strSQL + strDataFrom[i]; 

                    }
                }
                else
                {
                    if (!CheckIfIdentity(dtColumns, strFields[i]))
                    {
                        j++;
                        int intColumnType = GetColumnType(dtColumns, strFields[i]);
                        if (intColumnType == 231 | intColumnType == 61)
                            strSQL = strSQL + ",'" + strDataFrom[i] + "'";
                        else
                            if (strFields[i] == "EventSource")
                                strSQL = strSQL + "," + (int)CCommon.EventSource.Restored;
                            else
                                strSQL = strSQL + "," + strDataFrom[i]; 
                    }
                }
            }
            strSQL = strSQL + " )";

            if (CCommon.ExecuteQuery(strSQL, _ConnectionString))
                    return true;               
            else
                return false;



        }
        public bool RestoreUpdateEvent(long lngEventId)
        {

            DataTable dtRowToBeRestored = new DataTable();
            DataTable dtColumns = new DataTable();
            dtRowToBeRestored = GetRowToRestore(lngEventId);

            string[] strFields = dtRowToBeRestored.Rows[0]["TableFields"].ToString().Split(',');
            string[] strDataFrom = dtRowToBeRestored.Rows[0]["DataFrom"].ToString().Split('|');
            string strTableName = dtRowToBeRestored.Rows[0]["TableName"].ToString();
            string strRowGuid = dtRowToBeRestored.Rows[0]["TableRowGuid"].ToString();
            dtColumns = GetTableFieldsCurrent(strTableName);
            string strSQL = "";
            strSQL = strSQL + " Update " + strTableName;
            strSQL = strSQL + " Set ";
            int j = 0;           
            for (int i = 0; i < strFields.Length; i++)
            {
                if (j == 0)
                {
                    if (!CheckIfIdentity(dtColumns, strFields[i]))
                    {
                        j++;
                        int intColumnType = GetColumnType(dtColumns, strFields[i]);
                        if (intColumnType == 231 | intColumnType == 61)
                            strSQL = strSQL +  strFields[i] + " = '" + strDataFrom[i] + "'";
                        else
                            if (strFields[i] == "EventSource")
                                strSQL = strSQL +  strFields[i] + " = " + (int)CCommon.EventSource.Restored;
                            else
                                strSQL = strSQL +  strFields[i] + " = " + strDataFrom[i];

                    }
                }
                else
                {
                    if (!CheckIfIdentity(dtColumns, strFields[i]))
                    {
                        j++;
                        int intColumnType = GetColumnType(dtColumns, strFields[i]);
                        if (intColumnType == 231 | intColumnType == 61)
                            strSQL = strSQL + ","+ strFields[i] + " = '" + strDataFrom[i] + "'";
                        else
                            if (strFields[i] == "EventSource")
                                strSQL = strSQL + "," + strFields[i] + " = " + (int)CCommon.EventSource.Restored;
                            else
                                strSQL = strSQL + "," + strFields[i] + " = " + strDataFrom[i];
                    }
                }
            }
            strSQL = strSQL + " where TableRowGuid = '" +  strRowGuid + "'";

            if (CCommon.ExecuteQuery(strSQL, _ConnectionString))
                return true;
            else
                return false;



        }
        private bool CheckIfIdentity(DataTable dtColumns,string strColumnName)
        {
            bool blnReturn = false;
            foreach (DataRow row in dtColumns.Rows)
            {
                if (row["name"].ToString() == strColumnName)
                {
                    if (Convert.ToInt32(row["status"]) == 128)
                       return true;                  
                }
            }
            return blnReturn;
        }
        private int GetColumnType(DataTable dtColumns, string strColumnName)
        {
            int intReturn = 0;
            foreach (DataRow row in dtColumns.Rows)
            {
                if (row["name"].ToString() == strColumnName)
                {
                    return Convert.ToInt32(row["xtype"]);
                }
            }
            return intReturn;
        }
    }
}
