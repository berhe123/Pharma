//
// ...
// Wizard generated code
// Date: 11/17/2009 9:27:58 AM
// Class: CDrugRegistrationFeeTables
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
    class CDrugRegistrationFeeTables
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CDrugRegistrationFeeTables()
        {
            _ConnectionString = ConnectionString;
        }
        public CDrugRegistrationFeeTables(int Id, string Agent, DateTime Submissiondate, string Referencenumber, int Accepted, DateTime Acceptancedate, string Remark)
        {
            _Id = Id;
            _Agent = Agent;
            _SubmissionDate = Submissiondate;
            _ReferenceNumber = Referencenumber;
            _Accepted = Accepted;
            _AcceptanceDate = Acceptancedate;
            _Remark = Remark;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _Agent;
        public string Agent
        {
            get { return _Agent; }
            set { _Agent = value; }
        }

        DateTime _SubmissionDate;
        public DateTime Submissiondate
        {
            get { return _SubmissionDate; }
            set { _SubmissionDate = value; }
        }

        string _ReferenceNumber;
        public string Referencenumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        int _Accepted;
        public int Accepted
        {
            get { return _Accepted; }
            set { _Accepted = value; }
        }

        DateTime _AcceptanceDate;
        public DateTime Acceptancedate
        {
            get { return _AcceptanceDate; }
            set { _AcceptanceDate = value; }
        }

        string _Remark;
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        #endregion

        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationFeeTables where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeeTables");
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
                    if (dTable.Rows[0]["Agent"].Equals(DBNull.Value))
                        _Agent = string.Empty;
                    else
                        _Agent = (string)dTable.Rows[0]["Agent"];
                    if (dTable.Rows[0]["SubmissionDate"].Equals(DBNull.Value))
                        _SubmissionDate = DateTime.MinValue;
                    else
                        _SubmissionDate = (DateTime)dTable.Rows[0]["SubmissionDate"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["Accepted"].Equals(DBNull.Value))
                        _Accepted = 0;
                    else
                        _Accepted = (int)dTable.Rows[0]["Accepted"];
                    if (dTable.Rows[0]["AcceptanceDate"].Equals(DBNull.Value))
                        _AcceptanceDate = DateTime.MinValue;
                    else
                        _AcceptanceDate = (DateTime)dTable.Rows[0]["AcceptanceDate"];
                    if (dTable.Rows[0]["Remark"].Equals(DBNull.Value))
                        _Remark = string.Empty;
                    else
                        _Remark = (string)dTable.Rows[0]["Remark"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTables::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblDrugRegistrationFeeTables";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeeTables");
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
                throw new Exception("CDrugRegistrationFeeTables::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblDrugRegistrationFeeTables" +
                                   " (Agent, " +
                                   " SubmissionDate, " +
                                   " ReferenceNumber, " +
                                   " Accepted, " +
                                   " AcceptanceDate, " +
                                   " Remark,UserId,ComputerName,EventSource)" +
                                   " Values (@Agent, " +
                                   " @SubmissionDate, " +
                                   " @ReferenceNumber, " +
                                   " @Accepted, " +
                                   " @AcceptanceDate, " +
                                   " @Remark,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblDrugRegistrationFeeTables ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Agent", _Agent));
                if (_SubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", _SubmissionDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@Accepted", _Accepted));
                command.Parameters.Add(new SqlParameter("@AcceptanceDate", _AcceptanceDate));
                command.Parameters.Add(new SqlParameter("@Remark", _Remark));

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
                throw new Exception("CDrugRegistrationFeeTables::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblDrugRegistrationFeeTables" +
                                   " Set Agent = @Agent, " +
                                   " SubmissionDate = @SubmissionDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " Accepted = @Accepted, " +
                                   " AcceptanceDate = @AcceptanceDate, " +
                                   " Remark = @Remark," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Agent", _Agent));
                if (_SubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", _SubmissionDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@Accepted", _Accepted));
                command.Parameters.Add(new SqlParameter("@AcceptanceDate", _AcceptanceDate));
                command.Parameters.Add(new SqlParameter("@Remark", _Remark));

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
                throw new Exception("CDrugRegistrationFeeTables::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblDrugRegistrationFeeTables Where Id = @Id ";
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
                throw new Exception("CDrugRegistrationFeeTables::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTables] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTables] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
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
                throw new Exception("CDrugRegistrationFeeTables::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public bool Insert(int Id, string Agent, DateTime Submissiondate, string Referencenumber, int Accepted, DateTime Acceptancedate, string Remark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblDrugRegistrationFeeTables" +
                                   " (Agent, " +
                                   " SubmissionDate, " +
                                   " ReferenceNumber, " +
                                   " Accepted, " +
                                   " AcceptanceDate, " +
                                   " Remark)" +
                                   " Values (@Agent, " +
                                   " @SubmissionDate, " +
                                   " @ReferenceNumber, " +
                                   " @Accepted, " +
                                   " @AcceptanceDate, " +
                                   " @Remark)" +
                                   " Select @Id=Max(id) from tblDrugRegistrationFeeTables ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Agent", Agent));
                if (Submissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", Submissiondate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@Accepted", Accepted));
                command.Parameters.Add(new SqlParameter("@AcceptanceDate", Acceptancedate));
                command.Parameters.Add(new SqlParameter("@Remark", Remark));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTables::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Update(int Id, string Agent, DateTime Submissiondate, string Referencenumber, int Accepted, DateTime Acceptancedate, string Remark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblDrugRegistrationFeeTables" +
                                   " Set Agent = @Agent, " +
                                   " SubmissionDate = @SubmissionDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " Accepted = @Accepted, " +
                                   " AcceptanceDate = @AcceptanceDate, " +
                                   " Remark = @Remark" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Agent", Agent));
                if (Submissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", Submissiondate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@Accepted", Accepted));
                command.Parameters.Add(new SqlParameter("@AcceptanceDate", Acceptancedate));
                command.Parameters.Add(new SqlParameter("@Remark", Remark));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTables::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Delete(int Id)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblDrugRegistrationFeeTables Where Id = @Id ";
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
                throw new Exception("CDrugRegistrationFeeTables::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Referencenumber)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTables] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTables] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
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
                throw new Exception("CDrugRegistrationFeeTables::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public List<CDrugRegistrationFeeTables> GetList()
        {
            List<CDrugRegistrationFeeTables> RecordsList = new List<CDrugRegistrationFeeTables>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationFeeTables";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CDrugRegistrationFeeTables objCDrugRegistrationFeeTables = new CDrugRegistrationFeeTables();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Id = 0;
                    else
                        objCDrugRegistrationFeeTables.Id = (int)dr["Id"];
                    if (dr["Agent"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Agent = string.Empty;
                    else
                        objCDrugRegistrationFeeTables.Agent = (string)dr["Agent"];
                    if (dr["SubmissionDate"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Submissiondate = DateTime.MinValue;
                    else
                        objCDrugRegistrationFeeTables.Submissiondate = (DateTime)dr["SubmissionDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Referencenumber = string.Empty;
                    else
                        objCDrugRegistrationFeeTables.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["Accepted"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Accepted = 0;
                    else
                        objCDrugRegistrationFeeTables.Accepted = (int)dr["Accepted"];
                    if (dr["AcceptanceDate"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Acceptancedate = DateTime.MinValue;
                    else
                        objCDrugRegistrationFeeTables.Acceptancedate = (DateTime)dr["AcceptanceDate"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Remark = string.Empty;
                    else
                        objCDrugRegistrationFeeTables.Remark = (string)dr["Remark"];

                    RecordsList.Add(objCDrugRegistrationFeeTables);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTables::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                dr.Close();
                command.Dispose();
            }
        }
        public List<CDrugRegistrationFeeTables> GetList(string strCriteria)
        {
            List<CDrugRegistrationFeeTables> RecordsList = new List<CDrugRegistrationFeeTables>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationFeeTables";
            command.CommandText += " Where (1=1) " + strCriteria;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CDrugRegistrationFeeTables objCDrugRegistrationFeeTables = new CDrugRegistrationFeeTables();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Id = 0;
                    else
                        objCDrugRegistrationFeeTables.Id = (int)dr["Id"];
                    if (dr["Agent"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Agent = string.Empty;
                    else
                        objCDrugRegistrationFeeTables.Agent = (string)dr["Agent"];
                    if (dr["SubmissionDate"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Submissiondate = DateTime.MinValue;
                    else
                        objCDrugRegistrationFeeTables.Submissiondate = (DateTime)dr["SubmissionDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Referencenumber = string.Empty;
                    else
                        objCDrugRegistrationFeeTables.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["Accepted"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Accepted = 0;
                    else
                        objCDrugRegistrationFeeTables.Accepted = (int)dr["Accepted"];
                    if (dr["AcceptanceDate"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Acceptancedate = DateTime.MinValue;
                    else
                        objCDrugRegistrationFeeTables.Acceptancedate = (DateTime)dr["AcceptanceDate"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTables.Remark = string.Empty;
                    else
                        objCDrugRegistrationFeeTables.Remark = (string)dr["Remark"];

                    RecordsList.Add(objCDrugRegistrationFeeTables);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTables::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblDrugRegistrationFeeTables] WHERE Id = @Id";
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
                throw new Exception("CDrugRegistrationFeeTables::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTables] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CDrugRegistrationFeeTables::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
