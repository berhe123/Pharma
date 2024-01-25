//
// ...
// Wizard generated code
// Date: 3/12/2010 4:14:21 PM
// Class: CMergeDatabases
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
    class CMergeDatabases
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }
        public CMergeDatabases()
        {
            _ConnectionString = ConnectionString;
        }       

        #region Class Property Declarations
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _HostName;
        public string Hostname
        {
            get { return _HostName; }
            set { _HostName = value; }
        }

        string _DatabaseGuid;
        public string Databaseguid
        {
            get { return _DatabaseGuid; }
            set { _DatabaseGuid = value; }
        }

        string _ConnectionStringData;
        public string ConnectionstringData
        {
            get { return _ConnectionStringData; }
            set { _ConnectionStringData = value; }
        }

        string _Alias;
        public string Alias
        {
            get { return _Alias; }
            set { _Alias = value; }
        }

        bool _IsChildServer;
        public bool Ischildserver
        {
            get { return _IsChildServer; }
            set { _IsChildServer = value; }
        }

        #endregion

        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblMergeDatabases where id=@id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblMergeDatabases");
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
                    if (dTable.Rows[0]["HostName"].Equals(DBNull.Value))
                        _HostName = string.Empty;
                    else
                        _HostName = (string)dTable.Rows[0]["HostName"];
                    if (dTable.Rows[0]["DatabaseGuid"].Equals(DBNull.Value))
                        _DatabaseGuid = string.Empty;
                    else
                        _DatabaseGuid = (string)dTable.Rows[0]["DatabaseGuid"];
                    if (dTable.Rows[0]["ConnectionString"].Equals(DBNull.Value))
                        _ConnectionStringData = string.Empty;
                    else
                        _ConnectionStringData = (string)dTable.Rows[0]["ConnectionString"];
                    if (dTable.Rows[0]["Alias"].Equals(DBNull.Value))
                        _Alias = string.Empty;
                    else
                        _Alias = (string)dTable.Rows[0]["Alias"];
                    if (dTable.Rows[0]["IsChildServer"].Equals(DBNull.Value))
                        _IsChildServer = false;
                    else
                        _IsChildServer = (bool)dTable.Rows[0]["IsChildServer"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CMergeDatabases::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblMergeDatabases";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblMergeDatabases");
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
                throw new Exception("CMergeDatabases::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblMergeDatabases" +
                                   " (HostName, " +
                                   " DatabaseGuid, " +
                                   " ConnectionString, " +
                                   " Alias, " +
                                   " IsChildServer)" +
                                   " Values (@HostName, " +
                                   " @DatabaseGuid, " +
                                   " @ConnectionString, " +
                                   " @Alias, " +
                                   " @IsChildServer)" +
                                   " SELECT @id=@@IDENTITY ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_HostName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@HostName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@HostName", _HostName));
                if (_DatabaseGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@DatabaseGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DatabaseGuid", _DatabaseGuid));
                if (_ConnectionStringData == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ConnectionString", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ConnectionString", _ConnectionStringData));
                if (_Alias == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Alias", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Alias", _Alias));

               command.Parameters.Add(new SqlParameter("@IsChildServer", _IsChildServer));

                command.Parameters.Add(new SqlParameter("@id", _id));
                command.Parameters["@id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _id = (int)command.Parameters["@id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CMergeDatabases::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblMergeDatabases" +
                                   " Set HostName = @HostName, " +
                                   " DatabaseGuid = @DatabaseGuid, " +                                  
                                   " Alias = @Alias, " +
                                   " IsChildServer = @IsChildServer" +
                                   " Where ConnectionString = @ConnectionString ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_HostName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@HostName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@HostName", _HostName));
                if (_DatabaseGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@DatabaseGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@DatabaseGuid", _DatabaseGuid));
              
              

                if (_Alias == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Alias", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Alias", _Alias));
                
                command.Parameters.Add(new SqlParameter("@IsChildServer", _IsChildServer));
                command.Parameters.Add(new SqlParameter("@ConnectionString", _ConnectionStringData));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CMergeDatabases::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblMergeDatabases Where id = @id ";
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
                throw new Exception("CMergeDatabases::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT id FROM [dbo].[tblMergeDatabases] WHERE " +
                                       " ConnectionString = @ConnectionString";
            else
                command.CommandText = "SELECT id FROM [dbo].[tblMergeDatabases] WHERE " +
                                       " ConnectionString = @ConnectionString " +
                                       " AND id <> @id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ConnectionString", _ConnectionStringData));
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
                throw new Exception("CMergeDatabases::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CMergeDatabases> GetList()
        {
            List<CMergeDatabases> RecordsList = new List<CMergeDatabases>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblMergeDatabases";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CMergeDatabases objCMergeDatabases = new CMergeDatabases();
                    if (dr["id"].Equals(DBNull.Value))
                        objCMergeDatabases.Id = 0;
                    else
                        objCMergeDatabases.Id = (int)dr["id"];
                    if (dr["HostName"].Equals(DBNull.Value))
                        objCMergeDatabases.Hostname = string.Empty;
                    else
                        objCMergeDatabases.Hostname = (string)dr["HostName"];
                    if (dr["DatabaseGuid"].Equals(DBNull.Value))
                        objCMergeDatabases.Databaseguid = string.Empty;
                    else
                        objCMergeDatabases.Databaseguid = (string)dr["DatabaseGuid"];
                    if (dr["ConnectionString"].Equals(DBNull.Value))
                        objCMergeDatabases.ConnectionstringData = string.Empty;
                    else
                        objCMergeDatabases.ConnectionstringData = (string)dr["ConnectionString"];
                    if (dr["Alias"].Equals(DBNull.Value))
                        objCMergeDatabases.Alias = string.Empty;
                    else
                        objCMergeDatabases.Alias = (string)dr["Alias"];
                    if (dr["IsChildServer"].Equals(DBNull.Value))
                        objCMergeDatabases.Ischildserver = false;
                    else
                        objCMergeDatabases.Ischildserver = (bool)dr["IsChildServer"];

                    RecordsList.Add(objCMergeDatabases);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CMergeDatabases::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public DataTable GetRemoteDatabaseDetails(string _RemoteConnectionString)
        {
            SqlConnection connection = new SqlConnection(_RemoteConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDatabaseGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDatabaseGuid");
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
                throw new Exception("CMergeDatabases::GetRemoteDatabaseDetails::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }

    }
}
