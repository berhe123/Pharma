//
// ...
// Wizard generated code
// Date: 7/25/2009 4:35:04 PM
// Class: CPurchaseOrderBanks
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
    class CPurchaseOrderBanks
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CPurchaseOrderBanks()
        {
            _ConnectionString = ConnectionString;
        }
        public CPurchaseOrderBanks(int Id, string Purchaseorderguid, string Bankname, DateTime Submissiondate, string Referencenumber, decimal Servicecharge)
        {
            _Id = Id;
            _PurchaseOrderGuid = Purchaseorderguid;
            _BankName = Bankname;
            _SubmissionDate = Submissiondate;
            _ReferenceNumber = Referencenumber;
            _ServiceCharge = Servicecharge;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _PurchaseOrderGuid;
        public string Purchaseorderguid
        {
            get { return _PurchaseOrderGuid; }
            set { _PurchaseOrderGuid = value; }
        }

        string _BankName;
        public string Bankname
        {
            get { return _BankName; }
            set { _BankName = value; }
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

        decimal _ServiceCharge;
        public decimal Servicecharge
        {
            get { return _ServiceCharge; }
            set { _ServiceCharge = value; }
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
            command.CommandText = "Select * from tblPurchaseOrderBanks where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrderBanks");
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
                    if (dTable.Rows[0]["PurchaseOrderGuid"].Equals(DBNull.Value))
                        _PurchaseOrderGuid = string.Empty;
                    else
                        _PurchaseOrderGuid = (string)dTable.Rows[0]["PurchaseOrderGuid"];
                    if (dTable.Rows[0]["BankName"].Equals(DBNull.Value))
                        _BankName = string.Empty;
                    else
                        _BankName = (string)dTable.Rows[0]["BankName"];
                    if (dTable.Rows[0]["SubmissionDate"].Equals(DBNull.Value))
                        _SubmissionDate = DateTime.MinValue;
                    else
                        _SubmissionDate = (DateTime)dTable.Rows[0]["SubmissionDate"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["ServiceCharge"].Equals(DBNull.Value))
                        _ServiceCharge = 0;
                    else
                        _ServiceCharge = (decimal)dTable.Rows[0]["ServiceCharge"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderBanks::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblPurchaseOrderBanks";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrderBanks");
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
                throw new Exception("CPurchaseOrderBanks::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Purchaseorderguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrderBanks where PurchaseOrderGuid=@PurchaseOrderGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrderBanks");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderBanks::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblPurchaseOrderBanks" +
                                   " (PurchaseOrderGuid, " +
                                   " BankName, " +
                                   " SubmissionDate, " +
                                   " ReferenceNumber, " +
                                   " ServiceCharge,UserId,ComputerName,EventSource)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @BankName, " +
                                   " @SubmissionDate, " +
                                   " @ReferenceNumber, " +
                                   " @ServiceCharge,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblPurchaseOrderBanks ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@BankName", _BankName));
                if (_SubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", _SubmissionDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@ServiceCharge", _ServiceCharge));

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
                throw new Exception("CPurchaseOrderBanks::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblPurchaseOrderBanks" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " BankName = @BankName, " +
                                   " SubmissionDate = @SubmissionDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " ServiceCharge = @ServiceCharge," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@BankName", _BankName));
                if (_SubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", _SubmissionDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@ServiceCharge", _ServiceCharge));

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
                throw new Exception("CPurchaseOrderBanks::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblPurchaseOrderBanks Where Id = @Id ";
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
                throw new Exception("CPurchaseOrderBanks::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderBanks] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND BankName = @BankName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderBanks] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND BankName = @BankName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@BankName", _BankName));
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
                throw new Exception("CPurchaseOrderBanks::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Purchaseorderguid, string Bankname, DateTime Submissiondate, string Referencenumber, decimal Servicecharge)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblPurchaseOrderBanks" +
                                   " (PurchaseOrderGuid, " +
                                   " BankName, " +
                                   " SubmissionDate, " +
                                   " ReferenceNumber, " +
                                   " ServiceCharge)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @BankName, " +
                                   " @SubmissionDate, " +
                                   " @ReferenceNumber, " +
                                   " @ServiceCharge)" +
                                   " Select @Id=Max(id) from tblPurchaseOrderBanks ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@BankName", Bankname));
                if (Submissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", Submissiondate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@ServiceCharge", Servicecharge));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderBanks::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Purchaseorderguid, string Bankname, DateTime Submissiondate, string Referencenumber, decimal Servicecharge)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblPurchaseOrderBanks" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " BankName = @BankName, " +
                                   " SubmissionDate = @SubmissionDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " ServiceCharge = @ServiceCharge" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@BankName", Bankname));
                if (Submissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmissionDate", Submissiondate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@ServiceCharge", Servicecharge));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderBanks::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblPurchaseOrderBanks Where Id = @Id ";
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
                throw new Exception("CPurchaseOrderBanks::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Purchaseorderguid, string Bankname)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderBanks] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND BankName = @BankName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderBanks] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND BankName = @BankName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@BankName", Bankname));
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
                throw new Exception("CPurchaseOrderBanks::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CPurchaseOrderBanks> GetList()
        {
            List<CPurchaseOrderBanks> RecordsList = new List<CPurchaseOrderBanks>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrderBanks";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CPurchaseOrderBanks objCPurchaseOrderBanks = new CPurchaseOrderBanks();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Id = 0;
                    else
                        objCPurchaseOrderBanks.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Purchaseorderguid = string.Empty;
                    else
                        objCPurchaseOrderBanks.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["BankName"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Bankname = string.Empty;
                    else
                        objCPurchaseOrderBanks.Bankname = (string)dr["BankName"];
                    if (dr["SubmissionDate"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Submissiondate = DateTime.MinValue;
                    else
                        objCPurchaseOrderBanks.Submissiondate = (DateTime)dr["SubmissionDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Referencenumber = string.Empty;
                    else
                        objCPurchaseOrderBanks.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["ServiceCharge"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Servicecharge = 0;
                    else
                        objCPurchaseOrderBanks.Servicecharge = (decimal)dr["ServiceCharge"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrderBanks.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrderBanks);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderBanks::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CPurchaseOrderBanks> GetList(string Purchaseorderguid)
        {
            List<CPurchaseOrderBanks> RecordsList = new List<CPurchaseOrderBanks>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrderBanks where PurchaseOrderGuid=@PurchaseOrderGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CPurchaseOrderBanks objCPurchaseOrderBanks = new CPurchaseOrderBanks();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Id = 0;
                    else
                        objCPurchaseOrderBanks.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Purchaseorderguid = string.Empty;
                    else
                        objCPurchaseOrderBanks.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["BankName"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Bankname = string.Empty;
                    else
                        objCPurchaseOrderBanks.Bankname = (string)dr["BankName"];
                    if (dr["SubmissionDate"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Submissiondate = DateTime.MinValue;
                    else
                        objCPurchaseOrderBanks.Submissiondate = (DateTime)dr["SubmissionDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Referencenumber = string.Empty;
                    else
                        objCPurchaseOrderBanks.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["ServiceCharge"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Servicecharge = 0;
                    else
                        objCPurchaseOrderBanks.Servicecharge = (decimal)dr["ServiceCharge"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderBanks.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrderBanks.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrderBanks);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderBanks::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblPurchaseOrderBanks] WHERE Id = @Id";
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
                throw new Exception("CPurchaseOrderBanks::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderBanks] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CPurchaseOrderBanks::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
