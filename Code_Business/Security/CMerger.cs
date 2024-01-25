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
    class CMerger
    {
        string _ConnectionString = string.Empty;
        string _ConnectionStringRemote = string.Empty;
        #region Property Declaration
        private DateTime _max_merged_date;
        private DateTime _max_merged_time;
        string _database_name;
        public string DatabaseName
        {           
            set { _database_name = value; }
        }
        #endregion
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }
        public string ConnectionStringRemote
        {
            set { _ConnectionStringRemote = value; }
             
        }
        public CMerger()
        {
            _ConnectionString = ConnectionString;
        }
        public bool Syncronize()
        {
            
            string strHostName = GetRemoteHostName();
            strHostName = strHostName.Replace('-', '_');
          
            if (RemoteEventTableExists(strHostName))
            {
                GetLastMergedDate(strHostName);
                DeleteRemoteEventTable(strHostName);
                if (CreateTableToMerge(strHostName))
                    if (MergeData(strHostName))
                        return true;
                    else
                        return false;
                else
                    return false;
            }
            else
            {
                if (CreateTableToMerge(strHostName))
                    if (MergeData(strHostName))
                        return true;
                    else
                        return false;
                else
                    return false;
            }

            
        }
        public bool Syncronize(string strTableList)
        {

            string strHostName = GetRemoteHostName();
            strHostName = strHostName.Replace('-', '_');

            if (RemoteEventTableExists(strHostName))
            {
                GetLastMergedDate(strHostName);
                DeleteRemoteEventTable(strHostName);
                if (CreateTableToMerge(strHostName, strTableList))
                    if (MergeData(strHostName))
                        return true;
                    else
                        return false;
                else
                    return false;
            }
            else
            {
                if (CreateTableToMerge(strHostName))
                    if (MergeData(strHostName))
                        return true;
                    else
                        return false;
                else
                    return false;
            }
           

        }
        private string GetRemoteHostName()
        {
            SqlConnection connection = new SqlConnection(_ConnectionStringRemote);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strReturn = "";
            command.CommandText = "Select DatabaseGuid from tblDatabaseGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;           
            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr["DatabaseGuid"].Equals(DBNull.Value))
                        strReturn = string.Empty;
                    else
                        strReturn = (string)dr["DatabaseGuid"];
                }

                return strReturn;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetRemoteHostName::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        private string GetChildDatabasesGuid()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strReturn = "";
            string strSQL = "";
            strSQL = strSQL + " Select DatabaseGuid from tblMergeDatabases where IsChildServer=@IsChildServer";
            strSQL = strSQL + " union ";
            strSQL = strSQL + " Select DatabaseGuid from tblDatabaseGuid ";
            command.CommandText = strSQL;            
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                command.Parameters.Add(new SqlParameter("@IsChildServer", 1));
                connection.Open();
                int i = 0;
                dr = command.ExecuteReader();              
                while (dr.Read())
                {

                    if (!dr["DatabaseGuid"].Equals(DBNull.Value))
                    {
                        if (i == 0)
                            strReturn = strReturn +  "'" + (string)dr["DatabaseGuid"] + "'";
                        else
                            strReturn = strReturn + ",'" + (string)dr["DatabaseGuid"] + "'";
                    }
                    i++;
                   
                }                
                return strReturn;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetRemoteHostName::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        private void GetLastMergedDate(string strHostName)
        { 
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();           
            command.CommandText = "Select Max(EventDate) as MaxEventDate from tblEvents_" + strHostName + " where Merged=1 ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (!dr["MaxEventDate"].Equals(DBNull.Value))
                        _max_merged_date = Convert.ToDateTime(dr["MaxEventDate"]);
                    else 
                        _max_merged_date = CSettings.SQLServerMinDate;                  
                }
                if (_max_merged_date == CSettings.SQLServerMinDate)
                {
                   command.CommandText = "Select Min(EventDate) as MaxEventDate from tblEvents_" + strHostName + " where Merged=0 ";
                   dr.Close();
                   dr = command.ExecuteReader();
                   if (dr.HasRows)
                   {
                       dr.Read();
                       if (!dr["MaxEventDate"].Equals(DBNull.Value))
                           _max_merged_date = Convert.ToDateTime(dr["MaxEventDate"]);
                       else
                           _max_merged_date = CSettings.SQLServerMinDate;  
                   }

                }
                GetLastMergedTime(strHostName,_max_merged_date);

              
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetLastMergedId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        private void GetLastMergedTime(string strHostName, DateTime dteMaxMegedDate)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select Max(EventTime) as MaxEventTime from tblEvents_" + strHostName + " where Merged=1 and EventDate =@EventDate ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@EventDate", dteMaxMegedDate));
            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (!dr["MaxEventTime"].Equals(DBNull.Value))
                        _max_merged_time =Convert.ToDateTime(dr["MaxEventTime"]);
                    else
                        _max_merged_time = CSettings.SQLServerMinDate;
                        
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetLastMergedId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        private bool RemoteEventTableExists(string strHostName)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();        
            command.CommandText = "SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblEvents_" + strHostName + "]') AND type in (N'U')";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::RemoteEventTableExists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        private bool DeleteRemoteEventTable(string strHostName)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);          
            SqlCommand command = new SqlCommand();
            command.CommandText = "Drop Table [tblEvents_" + strHostName + "]";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                connection.Open();
                int _intRowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::DeleteRemoteEventTable::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private bool CreateTableToMerge(string strHostName)
        {
            SqlConnection connection = new SqlConnection(_ConnectionStringRemote);            
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            string EventSourceGuidList = GetChildDatabasesGuid();
            string strSQL = "";
            string strSQLInsert = "";
            strSQL = strSQL + " Select * from tblEvents Where EventSourceDatabaseGuid not in (" + EventSourceGuidList + ") ";
            if (_max_merged_date > DateTime.MinValue & _max_merged_time > DateTime.MinValue)
                strSQL = strSQL + " And (EventDate > @EventDate Or (EventDate = @EventDate and EventTime > @EventTime))";

            strSQL += " Order By tblEvents.Id";
            command.CommandText = strSQL;
            
            if (_max_merged_date > DateTime.MinValue & _max_merged_time > DateTime.MinValue)
            {
                command.Parameters.Add(new SqlParameter("@EventDate", _max_merged_date));
                command.Parameters.Add(new SqlParameter("@EventTime", _max_merged_time));
            }
            //command.Parameters.Add(new SqlParameter("@EventSourceGuidList", EventSourceGuidList));
            
            
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
               
                connection.Open();
                da.Fill(dt);
                if (CreateTable(dt,strHostName))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        strSQLInsert = "";
                        strSQLInsert = strSQLInsert + " Insert into [tblEvents_" + strHostName + "]";
                        strSQLInsert = strSQLInsert + " Values ( ";
                        int j = 0;
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            if (dt.Columns[i].ColumnName != "id")
                            {
                                if (row[i].Equals(DBNull.Value))
                                {
                                    if (j == 0)
                                        strSQLInsert = strSQLInsert + "NULL";
                                    else
                                        strSQLInsert = strSQLInsert + ",NULL";
                                }
                                else
                                {
                                    if (dt.Columns[i].DataType == typeof(string) | dt.Columns[i].DataType == typeof(DateTime))
                                    {
                                        if (j == 0)
                                            strSQLInsert = strSQLInsert + "'" + row[i].ToString() + "'";
                                        else
                                            strSQLInsert = strSQLInsert + ",'" + row[i].ToString() + "'";
                                    }
                                    else if (dt.Columns[i].DataType == typeof(bool))
                                    {
                                        if (j == 0)
                                            strSQLInsert = strSQLInsert + Convert.ToInt16(row[i]);
                                        else
                                            strSQLInsert = strSQLInsert + "," + Convert.ToInt16(row[i]);
                                    }
                                    else
                                    {
                                        if (j == 0)
                                            strSQLInsert = strSQLInsert + row[i].ToString();
                                        else
                                            strSQLInsert = strSQLInsert + "," + row[i].ToString();
                                    }
                                }
                                j++;
                            }
                           
                        }
                        strSQLInsert = strSQLInsert + " )";
                        CCommon.ExecuteQuery(strSQLInsert, _ConnectionString);

                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::CreateTableToMerge::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();               
                if (command != null) command.Dispose();
                if (da != null) da.Dispose();
            }
        }
        private bool CreateTableToMerge(string strHostName, string strTableList)
        {
            SqlConnection connection = new SqlConnection(_ConnectionStringRemote);
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            string EventSourceGuidList = GetChildDatabasesGuid();
            string strSQL = "";
            string strSQLInsert = "";
            strSQL = strSQL + " Select * from tblEvents Where EventSourceDatabaseGuid not in (" + EventSourceGuidList + ") ";
            strSQL = strSQL + " And tblEvents.TableName in " +  strTableList;
            if (_max_merged_date > DateTime.MinValue & _max_merged_time > DateTime.MinValue)
                strSQL = strSQL + " And (EventDate > @EventDate Or (EventDate = @EventDate and EventTime > @EventTime))";
            command.CommandText = strSQL;
            if (_max_merged_date > DateTime.MinValue & _max_merged_time > DateTime.MinValue)
            {
                command.Parameters.Add(new SqlParameter("@EventDate", _max_merged_date));
                command.Parameters.Add(new SqlParameter("@EventTime", _max_merged_time));
            }
            //command.Parameters.Add(new SqlParameter("@EventSourceGuidList", EventSourceGuidList));
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {

                connection.Open();
                da.Fill(dt);
                if (CreateTable(dt, strHostName))
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        strSQLInsert = "";
                        strSQLInsert = strSQLInsert + " Insert into [tblEvents_" + strHostName + "]";
                        strSQLInsert = strSQLInsert + " Values ( ";
                        int j = 0;
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            if (dt.Columns[i].ColumnName != "id")
                            {
                                if (row[i].Equals(DBNull.Value))
                                {
                                    if (j == 0)
                                        strSQLInsert = strSQLInsert + "NULL";
                                    else
                                        strSQLInsert = strSQLInsert + ",NULL";
                                }
                                else
                                {
                                    if (dt.Columns[i].DataType == typeof(string) | dt.Columns[i].DataType == typeof(DateTime))
                                    {
                                        if (j == 0)
                                            strSQLInsert = strSQLInsert + "'" + row[i].ToString() + "'";
                                        else
                                            strSQLInsert = strSQLInsert + ",'" + row[i].ToString() + "'";
                                    }
                                    else if (dt.Columns[i].DataType == typeof(bool))
                                    {
                                        if (j == 0)
                                            strSQLInsert = strSQLInsert + Convert.ToInt16(row[i]);
                                        else
                                            strSQLInsert = strSQLInsert + "," + Convert.ToInt16(row[i]);
                                    }
                                    else
                                    {
                                        if (j == 0)
                                            strSQLInsert = strSQLInsert + row[i].ToString();
                                        else
                                            strSQLInsert = strSQLInsert + "," + row[i].ToString();
                                    }
                                }
                                j++;
                            }

                        }
                        strSQLInsert = strSQLInsert + " )";
                        CCommon.ExecuteQuery(strSQLInsert, _ConnectionString);

                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::CreateTableToMerge::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (da != null) da.Dispose();
            }
        }
        private bool CreateTable(DataTable dt, string strHostName)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select * into [tblEvents_" + strHostName + "] from tblEvents where id=0";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                connection.Open();
                int _intRowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::DeleteRemoteEventTable::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private bool MergeData(string strHostName)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();           
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            long lngNewEventId = 0;
            string strSQL = "";
            strSQL = strSQL + " Select * from tblEvents_" + strHostName + " Order By Id" ;
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                connection.Open();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    int intEventType =  (int)row["EventType"] ;
                    long lngEventId = (long)row["id"];
                    string strEventSourceGuid = (string)row["EventSourceDatabaseGuid"];
                    if (intEventType == (int)CCommon.EventType.Insert)
                        if (MergeInsertEvent(strHostName, lngEventId))
                        {
                            lngNewEventId = GetNewEventId();
                            SetEventToMerged(strEventSourceGuid, lngNewEventId);
                            SetEventToMergedRemote(strHostName, lngEventId);
                        }
                        else
                            return false;
                    else if (intEventType == (int)CCommon.EventType.Delete)
                    {
                        if (MergeDeleteEvent(strHostName, lngEventId))
                        {
                            lngNewEventId = GetNewEventId();
                            SetEventToMerged(strEventSourceGuid, lngNewEventId);
                            SetEventToMergedRemote(strHostName, lngEventId);
                        }
                        else
                            return false;
                    }
                    else if (intEventType == (int)CCommon.EventType.Update)
                    {
                        if (MergeUpdateEvent(strHostName, lngEventId))
                        {
                            lngNewEventId = GetNewEventId();
                            SetEventToMerged(strEventSourceGuid, lngNewEventId);
                            SetEventToMergedRemote(strHostName, lngEventId);
                        }
                        else
                            return false;
                    }
                

                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::CreateTableToMerge::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (da != null) da.Dispose();
            }

        }
        private long GetNewEventId()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            long lngReturn = 0;
            command.CommandText = "Select Max(id) id from tblEvents";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (!dr["id"].Equals(DBNull.Value))
                        lngReturn = (long)dr["id"];
                }

                return lngReturn;
            }
            catch (Exception ex)
            {
                throw new Exception("CEvents::GetNewEventId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        private DataTable GetRowToRestore(string strHostName,long lngEventId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            command.CommandText = "Select * from tblEvents_" + strHostName + " where id=@id";
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
        private bool CheckIfIdentity(DataTable dtColumns, string strColumnName)
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
        public bool SetEventToMerged(string strEventSourceGuid, long lngEventId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblEvents" +
                                   " Set EventSourceDatabaseGuid = @EventSourceDatabaseGuid " +
                                   " Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@EventSourceDatabaseGuid", strEventSourceGuid));
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
        public bool SetEventToMergedRemote(string strHostName, long lngEventId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblEvents_" + strHostName +
                                   " Set Merged = @Merged " +
                                   " Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Merged", 1));
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
        private bool MergeInsertEvent(string strHostName, long lngEventId)
        {

            DataTable dtRowToBeRestored = new DataTable();
            DataTable dtColumns = new DataTable();
            dtRowToBeRestored = GetRowToRestore(strHostName,lngEventId);

            string[] strFields = dtRowToBeRestored.Rows[0]["TableFields"].ToString().Split(',');
            string[] strDataTo = dtRowToBeRestored.Rows[0]["DataTo"].ToString().Split('|');
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
                        if (intColumnType == 231 | intColumnType == 61)
                            strSQL = strSQL + "'" + strDataTo[i] + "'";
                        else
                            if (strFields[i] == "EventSource")
                                strSQL = strSQL + (int)CCommon.EventSource.Merged;
                            else
                                strSQL = strSQL + strDataTo[i];

                    }
                }
                else
                {
                    if (!CheckIfIdentity(dtColumns, strFields[i]))
                    {
                        j++;
                        int intColumnType = GetColumnType(dtColumns, strFields[i]);
                        if (intColumnType == 231 | intColumnType == 61)
                            strSQL = strSQL + ",'" + strDataTo[i] + "'";
                        else
                            if (strFields[i] == "EventSource")
                                strSQL = strSQL + "," + (int)CCommon.EventSource.Merged;
                            else
                                strSQL = strSQL + "," + strDataTo[i];
                    }
                }
            }
            strSQL = strSQL + " )";

            if (CCommon.ExecuteQuery(strSQL, _ConnectionString))
                return true;
            else
                return false;



        }
        public bool MergeDeleteEvent(string strHostName, long lngEventId)
        {

            DataTable dtRowToBeRestored = new DataTable();
            dtRowToBeRestored = GetRowToRestore(strHostName,lngEventId);

            string strSQL = "";
            strSQL = strSQL + "Delete " + dtRowToBeRestored.Rows[0]["TableName"].ToString() + " where TableRowGuid = '" + dtRowToBeRestored.Rows[0]["TableRowGuid"].ToString() + "'";
            if (CCommon.ExecuteQuery(strSQL, _ConnectionString))
                return true;
            else
                return false;



        }
        public bool MergeUpdateEvent(string strHostName, long lngEventId)
        {

            DataTable dtRowToBeRestored = new DataTable();
            DataTable dtColumns = new DataTable();
            dtRowToBeRestored = GetRowToRestore(strHostName,lngEventId);

            string[] strFields = dtRowToBeRestored.Rows[0]["TableFields"].ToString().Split(',');
            string[] strDataTo = dtRowToBeRestored.Rows[0]["DataTo"].ToString().Split('|');
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
                            strSQL = strSQL + strFields[i] + " = '" + strDataTo[i] + "'";
                        else
                            if (strFields[i] == "EventSource")
                                strSQL = strSQL + strFields[i] + " = " + (int)CCommon.EventSource.Merged;
                            else
                                strSQL = strSQL + strFields[i] + " = " + strDataTo[i];

                    }
                }
                else
                {
                    if (!CheckIfIdentity(dtColumns, strFields[i]))
                    {
                        j++;
                        int intColumnType = GetColumnType(dtColumns, strFields[i]);
                        if (intColumnType == 231 | intColumnType == 61)
                            strSQL = strSQL + "," + strFields[i] + " = '" + strDataTo[i] + "'";
                        else
                            if (strFields[i] == "EventSource")
                                strSQL = strSQL + "," + strFields[i] + " = " + (int)CCommon.EventSource.Merged;
                            else
                                strSQL = strSQL + "," + strFields[i] + " = " + strDataTo[i];
                    }
                }
            }
            strSQL = strSQL + " where TableRowGuid = '" + strRowGuid + "'";

            if (CCommon.ExecuteQuery(strSQL, _ConnectionString))
                return true;
            else
                return false;



        }
    }
}
