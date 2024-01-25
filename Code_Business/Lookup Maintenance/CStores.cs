//
// ...
// Wizard generated code
// Date: 7/29/2009 5:44:50 PM
// Class: CStores
// ...
//

using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;

namespace Pharma
{
    class CStores
    {
        public static List<CStores> StoresCollection = null;

        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CStores()
        {
            _ConnectionString = ConnectionString;
        }
        public CStores(int Id, string Locationguid, string Name, string Address)
        {
            _Id = Id;
            _LocationGuid = Locationguid;
            _Name = Name;
            _Address = Address;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _LocationGuid;
        public string Locationguid
        {
            get { return _LocationGuid; }
            set { _LocationGuid = value; }
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        string _Address;
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
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
            command.CommandText = "Select * from tblStores where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblStores");
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
                    if (dTable.Rows[0]["LocationGuid"].Equals(DBNull.Value))
                        _LocationGuid = string.Empty;
                    else
                        _LocationGuid = (string)dTable.Rows[0]["LocationGuid"];
                    if (dTable.Rows[0]["Name"].Equals(DBNull.Value))
                        _Name = string.Empty;
                    else
                        _Name = (string)dTable.Rows[0]["Name"];
                    if (dTable.Rows[0]["Address"].Equals(DBNull.Value))
                        _Address = string.Empty;
                    else
                        _Address = (string)dTable.Rows[0]["Address"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CStores::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblStores";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblStores");
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
                throw new Exception("CStores::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblStores" +
                                   " (LocationGuid, " +
                                   " Name, " +
                                   " Address,UserId,ComputerName,EventSource)" +
                                   " Values (@LocationGuid, " +
                                   " @Name, " +
                                   " @Address,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblStores  ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@LocationGuid", _LocationGuid));
                command.Parameters.Add(new SqlParameter("@Name", _Name));
                command.Parameters.Add(new SqlParameter("@Address", _Address));

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
                throw new Exception("CStores::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblStores" +
                                   " Set LocationGuid = @LocationGuid, " +
                                   " Name = @Name, " +
                                   " Address = @Address," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@LocationGuid", _LocationGuid));
                command.Parameters.Add(new SqlParameter("@Name", _Name));
                command.Parameters.Add(new SqlParameter("@Address", _Address));

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
                throw new Exception("CStores::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblStores Where Id = @Id ";
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
                throw new Exception("CStores::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblStores] WHERE " +
                                       " LocationGuid = @LocationGuid " +
                                       " AND Name = @Name";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblStores] WHERE " +
                                       " LocationGuid = @LocationGuid " +
                                       " AND Name = @Name " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@LocationGuid", _LocationGuid));
                command.Parameters.Add(new SqlParameter("@Name", _Name));
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
                throw new Exception("CStores::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CStores> GetList()
        {
            List<CStores> RecordsList = new List<CStores>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblStores";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStores objCStores = new CStores();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCStores.Id = 0;
                    else
                        objCStores.Id = (int)dr["Id"];
                    if (dr["LocationGuid"].Equals(DBNull.Value))
                        objCStores.Locationguid = string.Empty;
                    else
                        objCStores.Locationguid = (string)dr["LocationGuid"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCStores.Name = string.Empty;
                    else
                        objCStores.Name = (string)dr["Name"];
                    if (dr["Address"].Equals(DBNull.Value))
                        objCStores.Address = string.Empty;
                    else
                        objCStores.Address = (string)dr["Address"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCStores.Tablerowguid = string.Empty;
                    else
                        objCStores.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCStores);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStores::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public string GetStoreName(string Storeguid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT name FROM [dbo].[tblStores] WHERE [TableRowGuid] = @StoreGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@StoreGuid", Storeguid));
                connection.Open();
                return (string)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CStores::GetStoreName::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        // Collection Utilities
        public static void LoadStoresToCollection()
        {
            List<CStores> RecordsList = new List<CStores>();
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblStores";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStores objCStores = new CStores();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCStores.Id = 0;
                    else
                        objCStores.Id = (int)dr["Id"];
                    if (dr["LocationGuid"].Equals(DBNull.Value))
                        objCStores.Locationguid = string.Empty;
                    else
                        objCStores.Locationguid = (string)dr["LocationGuid"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCStores.Name = string.Empty;
                    else
                        objCStores.Name = (string)dr["Name"];
                    if (dr["Address"].Equals(DBNull.Value))
                        objCStores.Address = string.Empty;
                    else
                        objCStores.Address = (string)dr["Address"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCStores.Tablerowguid = string.Empty;
                    else
                        objCStores.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCStores);
                }

                StoresCollection = RecordsList;
                //return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStores::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public static string GetStoreNameFromCollection(string Storeguid)
        {
            string strName = string.Empty;
            try
            {
                ArrayList ar = new ArrayList(StoresCollection);
                if (ar.Count < 0) return string.Empty;

                foreach (CStores app in ar)
                {
                    if (Storeguid == app.Tablerowguid)
                    {
                        strName = app.Name;
                        break;
                    }
                }
                return strName;
            }
            catch (Exception ex)
            {
                throw new Exception("CStores::GetStoreNameFromCollection::Error! " + ex.Message, ex);
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblStores] WHERE Id = @Id";
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
                throw new Exception("CStores::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblStores] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CStores::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
