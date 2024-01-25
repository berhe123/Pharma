//
// ...
// Wizard generated code
// Date: 4/13/2010 11:32:57 AM
// Class: CTenderCompetitors
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
    class CTenderCompetitors
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CTenderCompetitors()
        {
            _ConnectionString = ConnectionString;
        }
        public CTenderCompetitors(int Id, string Tenderguid, string Competitorname)
        {
            _Id = Id;
            _TenderGuid = Tenderguid;
            _CompetitorName = Competitorname;
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

        string _CompetitorName;
        public string Competitorname
        {
            get { return _CompetitorName; }
            set { _CompetitorName = value; }
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
            command.CommandText = "Select * from tblTenderCompetitors where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderCompetitors");
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
                    if (dTable.Rows[0]["CompetitorName"].Equals(DBNull.Value))
                        _CompetitorName = string.Empty;
                    else
                        _CompetitorName = (string)dTable.Rows[0]["CompetitorName"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitors::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblTenderCompetitors";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderCompetitors");
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
                throw new Exception("CTenderCompetitors::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblTenderCompetitors where TenderGuid=@TenderGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderCompetitors");
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
                throw new Exception("CTenderCompetitors::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblTenderCompetitors" +
                                   " (TenderGuid, " +
                                   " CompetitorName)" +
                                   " Values (@TenderGuid, " +
                                   " @CompetitorName)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TenderGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TenderGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TenderGuid", _TenderGuid));
                if (_CompetitorName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CompetitorName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CompetitorName", _CompetitorName));

                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitors::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblTenderCompetitors" +
                                   " Set TenderGuid = @TenderGuid, " +
                                   " CompetitorName = @CompetitorName" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TenderGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TenderGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TenderGuid", _TenderGuid));
                if (_CompetitorName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CompetitorName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CompetitorName", _CompetitorName));
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitors::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblTenderCompetitors Where Id = @Id ";
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
                throw new Exception("CTenderCompetitors::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitors] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND CompetitorName = @CompetitorName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitors] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND CompetitorName = @CompetitorName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", _TenderGuid));
                command.Parameters.Add(new SqlParameter("@CompetitorName", _CompetitorName));
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
                throw new Exception("CTenderCompetitors::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Tenderguid, string Competitorname)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblTenderCompetitors" +
                                   " (TenderGuid, " +
                                   " CompetitorName)" +
                                   " Values (@TenderGuid, " +
                                   " @CompetitorName)" +
                                   " Select @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                command.Parameters.Add(new SqlParameter("@CompetitorName", Competitorname));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitors::Insert::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Tenderguid, string Competitorname)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblTenderCompetitors" +
                                   " Set TenderGuid = @TenderGuid, " +
                                   " CompetitorName = @CompetitorName" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                command.Parameters.Add(new SqlParameter("@CompetitorName", Competitorname));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitors::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblTenderCompetitors Where Id = @Id ";
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
                throw new Exception("CTenderCompetitors::Delete::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, string Tenderguid, string Competitorname)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitors] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND CompetitorName = @CompetitorName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitors] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND CompetitorName = @CompetitorName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                command.Parameters.Add(new SqlParameter("@CompetitorName", Competitorname));
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
                throw new Exception("CTenderCompetitors::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CTenderCompetitors> GetList()
        {
            List<CTenderCompetitors> RecordsList = new List<CTenderCompetitors>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderCompetitors";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenderCompetitors objCTenderCompetitors = new CTenderCompetitors();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenderCompetitors.Id = 0;
                    else
                        objCTenderCompetitors.Id = (int)dr["Id"];
                    if (dr["TenderGuid"].Equals(DBNull.Value))
                        objCTenderCompetitors.Tenderguid = string.Empty;
                    else
                        objCTenderCompetitors.Tenderguid = (string)dr["TenderGuid"];
                    if (dr["CompetitorName"].Equals(DBNull.Value))
                        objCTenderCompetitors.Competitorname = string.Empty;
                    else
                        objCTenderCompetitors.Competitorname = (string)dr["CompetitorName"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenderCompetitors.Tablerowguid = string.Empty;
                    else
                        objCTenderCompetitors.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenderCompetitors);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitors::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CTenderCompetitors> GetList(string Tenderguid)
        {
            List<CTenderCompetitors> RecordsList = new List<CTenderCompetitors>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderCompetitors where TenderGuid=@TenderGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenderCompetitors objCTenderCompetitors = new CTenderCompetitors();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenderCompetitors.Id = 0;
                    else
                        objCTenderCompetitors.Id = (int)dr["Id"];
                    if (dr["TenderGuid"].Equals(DBNull.Value))
                        objCTenderCompetitors.Tenderguid = string.Empty;
                    else
                        objCTenderCompetitors.Tenderguid = (string)dr["TenderGuid"];
                    if (dr["CompetitorName"].Equals(DBNull.Value))
                        objCTenderCompetitors.Competitorname = string.Empty;
                    else
                        objCTenderCompetitors.Competitorname = (string)dr["CompetitorName"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenderCompetitors.Tablerowguid = string.Empty;
                    else
                        objCTenderCompetitors.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenderCompetitors);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitors::GetList::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblTenderCompetitors] WHERE Id = @Id";
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
                throw new Exception("CTenderCompetitors::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitors] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CTenderCompetitors::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
