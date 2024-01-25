//
// ...
// Wizard generated code
// Date: 11/12/2009 11:14:00 AM
// Class: CDrugRegistrationTypes
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
    class CDrugRegistrationTypes
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CDrugRegistrationTypes()
        {
            _ConnectionString = ConnectionString;
        }
        public CDrugRegistrationTypes(int Id, string Name)
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
            command.CommandText = "Select * from tblDrugRegistrationTypes where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationTypes");
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
                throw new Exception("CDrugRegistrationTypes::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
                adapter.Dispose();
            }
        }
        public DataTable GetRecords()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationTypes";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationTypes");
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
                throw new Exception("CDrugRegistrationTypes::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
                adapter.Dispose();
            }
        }

        public bool Insert()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblDrugRegistrationTypes" +
                                   " (Name,UserId,ComputerName,EventSource)" +
                                   " Values (@Name,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblDrugRegistrationTypes ";
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
                throw new Exception("CDrugRegistrationTypes::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Update()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblDrugRegistrationTypes" +
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
                throw new Exception("CDrugRegistrationTypes::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Delete()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblDrugRegistrationTypes Where Id = @Id ";
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
                throw new Exception("CDrugRegistrationTypes::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public int Exists(bool bNew)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationTypes] WHERE " +
                                       " Name = @Name";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationTypes] WHERE " +
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
                throw new Exception("CDrugRegistrationTypes::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public List<CDrugRegistrationTypes> GetList()
        {
            List<CDrugRegistrationTypes> RecordsList = new List<CDrugRegistrationTypes>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationTypes";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CDrugRegistrationTypes objCDrugRegistrationTypes = new CDrugRegistrationTypes();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCDrugRegistrationTypes.Id = 0;
                    else
                        objCDrugRegistrationTypes.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCDrugRegistrationTypes.Name = string.Empty;
                    else
                        objCDrugRegistrationTypes.Name = (string)dr["Name"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationTypes.Tablerowguid = string.Empty;
                    else
                        objCDrugRegistrationTypes.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCDrugRegistrationTypes);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationTypes::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                dr.Close();
                command.Dispose();
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblDrugRegistrationTypes] WHERE Id = @Id";
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
                throw new Exception("CDrugRegistrationTypes::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationTypes] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CDrugRegistrationTypes::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
