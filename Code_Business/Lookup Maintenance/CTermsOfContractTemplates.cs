//
// ...
// Wizard generated code
// Date: 9/15/2009 11:31:57 AM
// Class: CTermsOfContractTemplates
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
    class CTermsOfContractTemplates
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CTermsOfContractTemplates()
        {
            _ConnectionString = ConnectionString;
        }
        public CTermsOfContractTemplates(int Id, string Templatename, string Templatecontent)
        {
            _Id = Id;
            _TemplateName = Templatename;
            _TemplateContent = Templatecontent;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _TemplateName;
        public string Templatename
        {
            get { return _TemplateName; }
            set { _TemplateName = value; }
        }

        string _TemplateContent;
        public string Templatecontent
        {
            get { return _TemplateContent; }
            set { _TemplateContent = value; }
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
            command.CommandText = "Select * from tblTermsOfContractTemplates where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTermsOfContractTemplates");
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
                    if (dTable.Rows[0]["TemplateName"].Equals(DBNull.Value))
                        _TemplateName = string.Empty;
                    else
                        _TemplateName = (string)dTable.Rows[0]["TemplateName"];
                    if (dTable.Rows[0]["TemplateContent"].Equals(DBNull.Value))
                        _TemplateContent = string.Empty;
                    else
                        _TemplateContent = (string)dTable.Rows[0]["TemplateContent"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CTermsOfContractTemplates::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblTermsOfContractTemplates";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTermsOfContractTemplates");
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
                throw new Exception("CTermsOfContractTemplates::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblTermsOfContractTemplates" +
                                   " (TemplateName, " +
                                   " TemplateContent,UserId,ComputerName,EventSource)" +
                                   " Values (@TemplateName, " +
                                   " @TemplateContent,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblTermsOfContractTemplates ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TemplateName", _TemplateName));
                command.Parameters.Add(new SqlParameter("@TemplateContent", _TemplateContent));

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
                throw new Exception("CTermsOfContractTemplates::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblTermsOfContractTemplates" +
                                   " Set TemplateName = @TemplateName, " +
                                   " TemplateContent = @TemplateContent," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TemplateName", _TemplateName));
                command.Parameters.Add(new SqlParameter("@TemplateContent", _TemplateContent));

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
                throw new Exception("CTermsOfContractTemplates::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblTermsOfContractTemplates Where Id = @Id ";
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
                throw new Exception("CTermsOfContractTemplates::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblTermsOfContractTemplates] WHERE " +
                                       " TemplateName = @TemplateName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTermsOfContractTemplates] WHERE " +
                                       " TemplateName = @TemplateName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TemplateName", _TemplateName));
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
                throw new Exception("CTermsOfContractTemplates::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CTermsOfContractTemplates> GetList()
        {
            List<CTermsOfContractTemplates> RecordsList = new List<CTermsOfContractTemplates>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTermsOfContractTemplates";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTermsOfContractTemplates objCTermsOfContractTemplates = new CTermsOfContractTemplates();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTermsOfContractTemplates.Id = 0;
                    else
                        objCTermsOfContractTemplates.Id = (int)dr["Id"];
                    if (dr["TemplateName"].Equals(DBNull.Value))
                        objCTermsOfContractTemplates.Templatename = string.Empty;
                    else
                        objCTermsOfContractTemplates.Templatename = (string)dr["TemplateName"];
                    if (dr["TemplateContent"].Equals(DBNull.Value))
                        objCTermsOfContractTemplates.Templatecontent = string.Empty;
                    else
                        objCTermsOfContractTemplates.Templatecontent = (string)dr["TemplateContent"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTermsOfContractTemplates.Tablerowguid = string.Empty;
                    else
                        objCTermsOfContractTemplates.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTermsOfContractTemplates);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTermsOfContractTemplates::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblTermsOfContractTemplates] WHERE Id = @Id";
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
                throw new Exception("CTermsOfContractTemplates::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblTermsOfContractTemplates] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CTermsOfContractTemplates::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
