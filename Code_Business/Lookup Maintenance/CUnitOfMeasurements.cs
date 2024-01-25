//
// ...
// Wizard generated code
// Date: 7/13/2009 10:47:57 AM
// Class: CUnitOfMeasurements
// ...
//

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace Pharma
{
    class CUnitOfMeasurements
    {
        public static List<CUnitOfMeasurements> UnitOfMeasurementsCollection = null;

        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CUnitOfMeasurements()
        {
            _ConnectionString = ConnectionString;
        }
        public CUnitOfMeasurements(int Id, string Name)
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
            command.CommandText = "Select * from tblUnitOfMeasurements where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblUnitOfMeasurements");
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
                throw new Exception("CUnitOfMeasurements::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblUnitOfMeasurements";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblUnitOfMeasurements");
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
                throw new Exception("CUnitOfMeasurements::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblUnitOfMeasurements" +
                                   " (Name,UserId,ComputerName,EventSource)" +
                                   " Values (@Name,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblUnitOfMeasurements ";
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
                throw new Exception("CUnitOfMeasurements::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblUnitOfMeasurements" +
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
                throw new Exception("CUnitOfMeasurements::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblUnitOfMeasurements Where Id = @Id ";
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
                throw new Exception("CUnitOfMeasurements::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblUnitOfMeasurements] WHERE " +
                                       " Name = @Name";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblUnitOfMeasurements] WHERE " +
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
                throw new Exception("CUnitOfMeasurements::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
               
        public List<CUnitOfMeasurements> GetList()
        {
            List<CUnitOfMeasurements> RecordsList = new List<CUnitOfMeasurements>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblUnitOfMeasurements";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CUnitOfMeasurements objCUnitOfMeasurements = new CUnitOfMeasurements();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCUnitOfMeasurements.Id = 0;
                    else
                        objCUnitOfMeasurements.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCUnitOfMeasurements.Name = string.Empty;
                    else
                        objCUnitOfMeasurements.Name = (string)dr["Name"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCUnitOfMeasurements.Tablerowguid = string.Empty;
                    else
                        objCUnitOfMeasurements.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCUnitOfMeasurements);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CUnitOfMeasurements::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public string GetUnitOfMeasurementName(string Unitofmeasurementguid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT name FROM [dbo].[tblUnitOfMeasurements] WHERE [TableRowGuid] = @UnitOfMeasurementGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@UnitOfMeasurementGuid", Unitofmeasurementguid));
                connection.Open();
                return (string)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CCountries::GetUnitOfMeasurementName::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        // Collection Utilities
        public static void LoadUnitOfMeasurementsToCollection()
        {
            List<CUnitOfMeasurements> RecordsList = new List<CUnitOfMeasurements>();
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblUnitOfMeasurements";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CUnitOfMeasurements objCUnitOfMeasurements = new CUnitOfMeasurements();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCUnitOfMeasurements.Id = 0;
                    else
                        objCUnitOfMeasurements.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCUnitOfMeasurements.Name = string.Empty;
                    else
                        objCUnitOfMeasurements.Name = (string)dr["Name"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCUnitOfMeasurements.Tablerowguid = string.Empty;
                    else
                        objCUnitOfMeasurements.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCUnitOfMeasurements);
                }

                UnitOfMeasurementsCollection = RecordsList;
                //return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CUnitOfMeasurements::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public static string GetUnitOfMeasurementNameFromCollection(string Unitofmeasurementguid)
        {
            string strName = string.Empty;
            try
            {
                ArrayList ar = new ArrayList(UnitOfMeasurementsCollection);
                if (ar.Count < 0) return string.Empty;

                foreach (CUnitOfMeasurements app in ar)
                {
                    if (Unitofmeasurementguid == app.Tablerowguid)
                    {
                        strName = app.Name;
                        break;
                    }
                }
                return strName;
            }
            catch (Exception ex)
            {
                throw new Exception("CUnitOfMeasurements::GetUnitOfMeasurementNameFromCollection::Error! " + ex.Message, ex);
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblUnitsOfMeasurements] WHERE Id = @Id";
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
                throw new Exception("CUnitsOfMeasurements::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblUnitsOfMeasurements] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CUnitsOfMeasurements::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
