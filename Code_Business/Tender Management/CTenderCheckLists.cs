//
// ...
// Wizard generated code
// Date: 4/13/2010 11:29:07 AM
// Class: CTenderCheckLists
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
    class CTenderCheckLists
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CTenderCheckLists()
        {
            _ConnectionString = ConnectionString;
        }
        public CTenderCheckLists(int Id, string Tenderguid, string Checklistdescription, int Checkliststatus)
        {
            _Id = Id;
            _TenderGuid = Tenderguid;
            _CheckListDescription = Checklistdescription;
            _CheckListStatus = Checkliststatus;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _TenderGuid;
        public string Tenderguid
        {
            get { return _TenderGuid; }
            set { _TenderGuid = value; }
        }

        string _CheckListDescription;
        public string Checklistdescription
        {
            get { return _CheckListDescription; }
            set { _CheckListDescription = value; }
        }

        int _CheckListStatus;
        public int Checkliststatus
        {
            get { return _CheckListStatus; }
            set { _CheckListStatus = value; }
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
            command.CommandText = "Select * from tblTenderCheckLists where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderCheckLists");
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
                    if (dTable.Rows[0]["TenderGuid"].Equals(DBNull.Value))
                        _TenderGuid = string.Empty;
                    else
                        _TenderGuid = (string)dTable.Rows[0]["TenderGuid"];
                    if (dTable.Rows[0]["CheckListDescription"].Equals(DBNull.Value))
                        _CheckListDescription = string.Empty;
                    else
                        _CheckListDescription = (string)dTable.Rows[0]["CheckListDescription"];
                    if (dTable.Rows[0]["CheckListStatus"].Equals(DBNull.Value))
                        _CheckListStatus = 0;
                    else
                        _CheckListStatus = (int)dTable.Rows[0]["CheckListStatus"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCheckLists::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblTenderCheckLists";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderCheckLists");
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
                throw new Exception("CTenderCheckLists::GetRecords::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Tenderguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderCheckLists where TenderGuid=@TenderGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderCheckLists");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCheckLists::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblTenderCheckLists" +
                                   " (TenderGuid, " +
                                   " CheckListDescription, " +
                                   " CheckListStatus)" +
                                   " Values (@TenderGuid, " +
                                   " @CheckListDescription, " +
                                   " @CheckListStatus)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TenderGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TenderGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TenderGuid", _TenderGuid));
                if (_CheckListDescription == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CheckListDescription", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckListDescription", _CheckListDescription));
                if (_CheckListStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckListStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckListStatus", _CheckListStatus));

                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCheckLists::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblTenderCheckLists" +
                                   " Set TenderGuid = @TenderGuid, " +
                                   " CheckListDescription = @CheckListDescription, " +
                                   " CheckListStatus = @CheckListStatus" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TenderGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TenderGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TenderGuid", _TenderGuid));
                if (_CheckListDescription == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CheckListDescription", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckListDescription", _CheckListDescription));
                if (_CheckListStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckListStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckListStatus", _CheckListStatus));
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCheckLists::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblTenderCheckLists Where Id = @Id ";
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
                throw new Exception("CTenderCheckLists::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCheckLists] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND CheckListDescription = @CheckListDescription";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCheckLists] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND CheckListDescription = @CheckListDescription " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", _TenderGuid));
                command.Parameters.Add(new SqlParameter("@CheckListDescription", _CheckListDescription));
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
                throw new Exception("CTenderCheckLists::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Tenderguid, string Checklistdescription, int Checkliststatus)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblTenderCheckLists" +
                                   " (TenderGuid, " +
                                   " CheckListDescription, " +
                                   " CheckListStatus)" +
                                   " Values (@TenderGuid, " +
                                   " @CheckListDescription, " +
                                   " @CheckListStatus)" +
                                   " Select @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                command.Parameters.Add(new SqlParameter("@CheckListDescription", Checklistdescription));
                command.Parameters.Add(new SqlParameter("@CheckListStatus", Checkliststatus));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCheckLists::Insert::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Tenderguid, string Checklistdescription, int Checkliststatus)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblTenderCheckLists" +
                                   " Set TenderGuid = @TenderGuid, " +
                                   " CheckListDescription = @CheckListDescription, " +
                                   " CheckListStatus = @CheckListStatus" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                command.Parameters.Add(new SqlParameter("@CheckListDescription", Checklistdescription));
                command.Parameters.Add(new SqlParameter("@CheckListStatus", Checkliststatus));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCheckLists::Update::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Delete(int Id)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblTenderCheckLists Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCheckLists::Delete::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, string Tenderguid, string Checklistdescription)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCheckLists] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND CheckListDescription = @CheckListDescription";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCheckLists] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND CheckListDescription = @CheckListDescription " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                command.Parameters.Add(new SqlParameter("@CheckListDescription", Checklistdescription));
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
                throw new Exception("CTenderCheckLists::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CTenderCheckLists> GetList()
        {
            List<CTenderCheckLists> RecordsList = new List<CTenderCheckLists>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderCheckLists";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenderCheckLists objCTenderCheckLists = new CTenderCheckLists();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenderCheckLists.Id = 0;
                    else
                        objCTenderCheckLists.Id = (int)dr["Id"];
                    if (dr["TenderGuid"].Equals(DBNull.Value))
                        objCTenderCheckLists.Tenderguid = string.Empty;
                    else
                        objCTenderCheckLists.Tenderguid = (string)dr["TenderGuid"];
                    if (dr["CheckListDescription"].Equals(DBNull.Value))
                        objCTenderCheckLists.Checklistdescription = string.Empty;
                    else
                        objCTenderCheckLists.Checklistdescription = (string)dr["CheckListDescription"];
                    if (dr["CheckListStatus"].Equals(DBNull.Value))
                        objCTenderCheckLists.Checkliststatus = 0;
                    else
                        objCTenderCheckLists.Checkliststatus = (int)dr["CheckListStatus"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenderCheckLists.Tablerowguid = string.Empty;
                    else
                        objCTenderCheckLists.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenderCheckLists);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCheckLists::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CTenderCheckLists> GetList(string Tenderguid)
        {
            List<CTenderCheckLists> RecordsList = new List<CTenderCheckLists>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderCheckLists where TenderGuid=@TenderGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenderCheckLists objCTenderCheckLists = new CTenderCheckLists();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenderCheckLists.Id = 0;
                    else
                        objCTenderCheckLists.Id = (int)dr["Id"];
                    if (dr["TenderGuid"].Equals(DBNull.Value))
                        objCTenderCheckLists.Tenderguid = string.Empty;
                    else
                        objCTenderCheckLists.Tenderguid = (string)dr["TenderGuid"];
                    if (dr["CheckListDescription"].Equals(DBNull.Value))
                        objCTenderCheckLists.Checklistdescription = string.Empty;
                    else
                        objCTenderCheckLists.Checklistdescription = (string)dr["CheckListDescription"];
                    if (dr["CheckListStatus"].Equals(DBNull.Value))
                        objCTenderCheckLists.Checkliststatus = 0;
                    else
                        objCTenderCheckLists.Checkliststatus = (int)dr["CheckListStatus"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenderCheckLists.Tablerowguid = string.Empty;
                    else
                        objCTenderCheckLists.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenderCheckLists);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCheckLists::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblTenderCheckLists] WHERE Id = @Id";
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
                throw new Exception("CTenderCheckLists::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblTenderCheckLists] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CTenderCheckLists::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
