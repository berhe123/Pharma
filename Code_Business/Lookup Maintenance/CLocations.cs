//
// ...
// Wizard generated code
// Date: 7/29/2009 4:44:40 PM
// Class: CLocations
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
    class CLocations
    {
        public static List<CLocations> LocationsCollection = null;

        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CLocations()
        {
            _ConnectionString = ConnectionString;
        }
        public CLocations(int Id, string Name)
        {
            _Id = Id;
            _Name = Name;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
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
            command.CommandText = "Select * from tblLocations where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocations");
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
                    if (dTable.Rows[0]["Name"].Equals(DBNull.Value))
                        _Name = string.Empty;
                    else
                        _Name = (string)dTable.Rows[0]["Name"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocations::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblLocations";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocations");
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
                throw new Exception("CLocations::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblLocations" +
                                   " (Name,UserId,ComputerName,EventSource)" +
                                   " Values (@Name,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblLocations ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Name", _Name));

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
                throw new Exception("CLocations::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblLocations" +
                                   " Set Name = @Name," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Name", _Name));

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
                throw new Exception("CLocations::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblLocations Where Id = @Id ";
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
                throw new Exception("CLocations::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblLocations] WHERE " +
                                       " Name = @Name";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblLocations] WHERE " +
                                       " Name = @Name " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
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
                throw new Exception("CLocations::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CLocations> GetList()
        {
            List<CLocations> RecordsList = new List<CLocations>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLocations";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocations objCLocations = new CLocations();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLocations.Id = 0;
                    else
                        objCLocations.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCLocations.Name = string.Empty;
                    else
                        objCLocations.Name = (string)dr["Name"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLocations.Tablerowguid = string.Empty;
                    else
                        objCLocations.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLocations);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocations::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public string GetLocationName(string Locationguid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT name FROM [dbo].[tblLocations] WHERE [TableRowGuid] = @LocationGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@LocationGuid", Locationguid));
                connection.Open();
                return (string)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CLocations::GetLocationName::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        // Collection Utilities
        public static void LoadLocationsToCollection()
        {
            List<CLocations> RecordsList = new List<CLocations>();
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLocations";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocations objCLocations = new CLocations();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLocations.Id = 0;
                    else
                        objCLocations.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCLocations.Name = string.Empty;
                    else
                        objCLocations.Name = (string)dr["Name"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLocations.Tablerowguid = string.Empty;
                    else
                        objCLocations.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLocations);
                }

                LocationsCollection = RecordsList;
                //return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocations::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public static string GetLocationNameFromCollection(string Locationguid)
        {
            string strName = string.Empty;
            try
            {
                ArrayList ar = new ArrayList(LocationsCollection);
                if (ar.Count < 0) return string.Empty;

                foreach (CLocations app in ar)
                {
                    if (Locationguid == app.Tablerowguid)
                    {
                        strName = app.Name;
                        break;
                    }
                }
                return strName;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocations::GetLocationNameFromCollection::Error! " + ex.Message, ex);
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblLocations] WHERE Id = @Id";
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
                throw new Exception("CLocations::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblLocations] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CLocations::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
