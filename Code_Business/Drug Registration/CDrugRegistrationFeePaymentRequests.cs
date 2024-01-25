//
// ...
// Wizard generated code
// Date: 11/12/2009 3:29:24 PM
// Class: CDrugRegistrationFeePaymentRequests
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
    class CDrugRegistrationFeePaymentRequests
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CDrugRegistrationFeePaymentRequests()
        {
            _ConnectionString = ConnectionString;
        }
        public CDrugRegistrationFeePaymentRequests(int Id, string Manufacturerguid, DateTime Requestdate, string Referencenumber, int Settled, DateTime Settlementdate, string Remark)
        {
            _Id = Id;
            _ManufacturerGuid = Manufacturerguid;
            _RequestDate = Requestdate;
            _ReferenceNumber = Referencenumber;
            _Settled = Settled;
            _SettlementDate = Settlementdate;
            _Remark = Remark;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _ManufacturerGuid;
        public string Manufacturerguid
        {
            get { return _ManufacturerGuid; }
            set { _ManufacturerGuid = value; }
        }

        DateTime _RequestDate;
        public DateTime Requestdate
        {
            get { return _RequestDate; }
            set { _RequestDate = value; }
        }

        string _ReferenceNumber;
        public string Referencenumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        int _Settled;
        public int Settled
        {
            get { return _Settled; }
            set { _Settled = value; }
        }

        DateTime _SettlementDate;
        public DateTime Settlementdate
        {
            get { return _SettlementDate; }
            set { _SettlementDate = value; }
        }

        string _Remark;
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
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
            command.CommandText = "Select * from tblDrugRegistrationFeePaymentRequests where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeePaymentRequests");
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
                    if (dTable.Rows[0]["ManufacturerGuid"].Equals(DBNull.Value))
                        _ManufacturerGuid = string.Empty;
                    else
                        _ManufacturerGuid = (string)dTable.Rows[0]["ManufacturerGuid"];
                    if (dTable.Rows[0]["RequestDate"].Equals(DBNull.Value))
                        _RequestDate = DateTime.MinValue;
                    else
                        _RequestDate = (DateTime)dTable.Rows[0]["RequestDate"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["Settled"].Equals(DBNull.Value))
                        _Settled = 0;
                    else
                        _Settled = (int)dTable.Rows[0]["Settled"];
                    if (dTable.Rows[0]["SettlementDate"].Equals(DBNull.Value))
                        _SettlementDate = DateTime.MinValue;
                    else
                        _SettlementDate = (DateTime)dTable.Rows[0]["SettlementDate"];
                    if (dTable.Rows[0]["Remark"].Equals(DBNull.Value))
                        _Remark = string.Empty;
                    else
                        _Remark = (string)dTable.Rows[0]["Remark"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequests::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblDrugRegistrationFeePaymentRequests";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeePaymentRequests");
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblDrugRegistrationFeePaymentRequests" +
                                   " (ManufacturerGuid, " +
                                   " RequestDate, " +
                                   " ReferenceNumber, " +
                                   " Settled, " +
                                   " SettlementDate, " +
                                   " Remark,UserId,ComputerName,EventSource)" +
                                   " Values (@ManufacturerGuid, " +
                                   " @RequestDate, " +
                                   " @ReferenceNumber, " +
                                   " @Settled, " +
                                   " @SettlementDate, " +
                                   " @Remark,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblDrugRegistrationFeePaymentRequests ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", _ManufacturerGuid));
                if (_RequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", _RequestDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@Settled", _Settled));
                command.Parameters.Add(new SqlParameter("@SettlementDate", _SettlementDate));
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblDrugRegistrationFeePaymentRequests" +
                                   " Set ManufacturerGuid = @ManufacturerGuid, " +
                                   " RequestDate = @RequestDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " Settled = @Settled, " +
                                   " SettlementDate = @SettlementDate, " +
                                   " Remark = @Remark," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", _ManufacturerGuid));
                if (_RequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", _RequestDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@Settled", _Settled));
                command.Parameters.Add(new SqlParameter("@SettlementDate", _SettlementDate));
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblDrugRegistrationFeePaymentRequests Where Id = @Id ";
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequests] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequests] WHERE " +
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public bool Insert(int Id, string Manufacturerguid, DateTime Requestdate, string Referencenumber, int Settled, DateTime Settlementdate, string Remark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblDrugRegistrationFeePaymentRequests" +
                                   " (ManufacturerGuid, " +
                                   " RequestDate, " +
                                   " ReferenceNumber, " +
                                   " Settled, " +
                                   " SettlementDate, " +
                                   " Remark)" +
                                   " Values (@ManufacturerGuid, " +
                                   " @RequestDate, " +
                                   " @ReferenceNumber, " +
                                   " @Settled, " +
                                   " @SettlementDate, " +
                                   " @Remark)" +
                                   " Select @Id=Max(id) from tblDrugRegistrationFeePaymentRequests ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                if (Requestdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", Requestdate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@Settled", Settled));
                command.Parameters.Add(new SqlParameter("@SettlementDate", Settlementdate));
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Update(int Id, string Manufacturerguid, DateTime Requestdate, string Referencenumber, int Settled, DateTime Settlementdate, string Remark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblDrugRegistrationFeePaymentRequests" +
                                   " Set ManufacturerGuid = @ManufacturerGuid, " +
                                   " RequestDate = @RequestDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " Settled = @Settled, " +
                                   " SettlementDate = @SettlementDate, " +
                                   " Remark = @Remark" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                if (Requestdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RequestDate", Requestdate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@Settled", Settled));
                command.Parameters.Add(new SqlParameter("@SettlementDate", Settlementdate));
                command.Parameters.Add(new SqlParameter("@Remark", Remark));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequests::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblDrugRegistrationFeePaymentRequests Where Id = @Id ";
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequests] WHERE " +
                                       " ReferenceNumber = @ReferenceNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequests] WHERE " +
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public List<CDrugRegistrationFeePaymentRequests> GetList()
        {
            List<CDrugRegistrationFeePaymentRequests> RecordsList = new List<CDrugRegistrationFeePaymentRequests>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationFeePaymentRequests";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CDrugRegistrationFeePaymentRequests objCDrugRegistrationFeePaymentRequests = new CDrugRegistrationFeePaymentRequests();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Id = 0;
                    else
                        objCDrugRegistrationFeePaymentRequests.Id = (int)dr["Id"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Manufacturerguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequests.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Requestdate = DateTime.MinValue;
                    else
                        objCDrugRegistrationFeePaymentRequests.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Referencenumber = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequests.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["Settled"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Settled = 0;
                    else
                        objCDrugRegistrationFeePaymentRequests.Settled = (int)dr["Settled"];
                    if (dr["SettlementDate"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Settlementdate = DateTime.MinValue;
                    else
                        objCDrugRegistrationFeePaymentRequests.Settlementdate = (DateTime)dr["SettlementDate"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Remark = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequests.Remark = (string)dr["Remark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Tablerowguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequests.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCDrugRegistrationFeePaymentRequests);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequests::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                dr.Close();
                command.Dispose();
            }
        }
        public List<CDrugRegistrationFeePaymentRequests> GetList(string strCriteria)
        {
            List<CDrugRegistrationFeePaymentRequests> RecordsList = new List<CDrugRegistrationFeePaymentRequests>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationFeePaymentRequests";
            command.CommandText += " Where (1=1) " + strCriteria;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CDrugRegistrationFeePaymentRequests objCDrugRegistrationFeePaymentRequests = new CDrugRegistrationFeePaymentRequests();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Id = 0;
                    else
                        objCDrugRegistrationFeePaymentRequests.Id = (int)dr["Id"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Manufacturerguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequests.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["RequestDate"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Requestdate = DateTime.MinValue;
                    else
                        objCDrugRegistrationFeePaymentRequests.Requestdate = (DateTime)dr["RequestDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Referencenumber = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequests.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["Settled"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Settled = 0;
                    else
                        objCDrugRegistrationFeePaymentRequests.Settled = (int)dr["Settled"];
                    if (dr["SettlementDate"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Settlementdate = DateTime.MinValue;
                    else
                        objCDrugRegistrationFeePaymentRequests.Settlementdate = (DateTime)dr["SettlementDate"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Remark = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequests.Remark = (string)dr["Remark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequests.Tablerowguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequests.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCDrugRegistrationFeePaymentRequests);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequests::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblDrugRegistrationFeePaymentRequests] WHERE Id = @Id";
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequests] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CDrugRegistrationFeePaymentRequests::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
