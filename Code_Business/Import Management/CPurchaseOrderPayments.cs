//
// ...
// Wizard generated code
// Date: 7/25/2009 5:18:40 PM
// Class: CPurchaseOrderPayments
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
    class CPurchaseOrderPayments
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CPurchaseOrderPayments()
        {
            _ConnectionString = ConnectionString;
        }
        public CPurchaseOrderPayments(int Id, string Purchaseorderguid, int Paymentreason, DateTime Paymentdate, string Referencenumber, decimal Amount)
        {
            _Id = Id;
            _PurchaseOrderGuid = Purchaseorderguid;
            _PaymentReason = Paymentreason;
            _PaymentDate = Paymentdate;
            _ReferenceNumber = Referencenumber;
            _Amount = Amount;
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

        int _PaymentReason;
        public int Paymentreason
        {
            get { return _PaymentReason; }
            set { _PaymentReason = value; }
        }

        DateTime _PaymentDate;
        public DateTime Paymentdate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
        }

        string _ReferenceNumber;
        public string Referencenumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
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
            command.CommandText = "Select * from tblPurchaseOrderPayments where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrderPayments");
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
                    if (dTable.Rows[0]["PaymentReason"].Equals(DBNull.Value))
                        _PaymentReason = 0;
                    else
                        _PaymentReason = (int)dTable.Rows[0]["PaymentReason"];
                    if (dTable.Rows[0]["PaymentDate"].Equals(DBNull.Value))
                        _PaymentDate = DateTime.MinValue;
                    else
                        _PaymentDate = (DateTime)dTable.Rows[0]["PaymentDate"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
                    if (dTable.Rows[0]["Amount"].Equals(DBNull.Value))
                        _Amount = 0;
                    else
                        _Amount = (decimal)dTable.Rows[0]["Amount"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderPayments::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblPurchaseOrderPayments";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrderPayments");
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
                throw new Exception("CPurchaseOrderPayments::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblPurchaseOrderPayments where PurchaseOrderGuid=@PurchaseOrderGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrderPayments");
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
                throw new Exception("CPurchaseOrderPayments::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblPurchaseOrderPayments" +
                                   " (PurchaseOrderGuid, " +
                                   " PaymentReason, " +
                                   " PaymentDate, " +
                                   " ReferenceNumber, " +
                                   " Amount,UserId,ComputerName,EventSource)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @PaymentReason, " +
                                   " @PaymentDate, " +
                                   " @ReferenceNumber, " +
                                   " @Amount,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblPurchaseOrderPayments ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@PaymentReason", _PaymentReason));
                if (_PaymentDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PaymentDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PaymentDate", _PaymentDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@Amount", _Amount));

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
                throw new Exception("CPurchaseOrderPayments::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblPurchaseOrderPayments" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " PaymentReason = @PaymentReason, " +
                                   " PaymentDate = @PaymentDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " Amount = @Amount," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@PaymentReason", _PaymentReason));
                if (_PaymentDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PaymentDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PaymentDate", _PaymentDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
                command.Parameters.Add(new SqlParameter("@Amount", _Amount));

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
                throw new Exception("CPurchaseOrderPayments::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblPurchaseOrderPayments Where Id = @Id ";
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
                throw new Exception("CPurchaseOrderPayments::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderPayments] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND PaymentReason = @PaymentReason";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderPayments] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND PaymentReason = @PaymentReason " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@PaymentReason", _PaymentReason));
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
                throw new Exception("CPurchaseOrderPayments::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Purchaseorderguid, int Paymentreason, DateTime Paymentdate, string Referencenumber, decimal Amount)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblPurchaseOrderPayments" +
                                   " (PurchaseOrderGuid, " +
                                   " PaymentReason, " +
                                   " PaymentDate, " +
                                   " ReferenceNumber, " +
                                   " Amount)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @PaymentReason, " +
                                   " @PaymentDate, " +
                                   " @ReferenceNumber, " +
                                   " @Amount)" +
                                   " Select @Id=Max(id) from tblPurchaseOrderPayments  ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@PaymentReason", Paymentreason));
                if (Paymentdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PaymentDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PaymentDate", Paymentdate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderPayments::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Purchaseorderguid, int Paymentreason, DateTime Paymentdate, string Referencenumber, decimal Amount)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblPurchaseOrderPayments" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " PaymentReason = @PaymentReason, " +
                                   " PaymentDate = @PaymentDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " Amount = @Amount" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@PaymentReason", Paymentreason));
                if (Paymentdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PaymentDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PaymentDate", Paymentdate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderPayments::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblPurchaseOrderPayments Where Id = @Id ";
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
                throw new Exception("CPurchaseOrderPayments::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Purchaseorderguid, int Paymentreason)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderPayments] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND PaymentReason = @PaymentReason";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderPayments] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND PaymentReason = @PaymentReason " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@PaymentReason", Paymentreason));
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
                throw new Exception("CPurchaseOrderPayments::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CPurchaseOrderPayments> GetList()
        {
            List<CPurchaseOrderPayments> RecordsList = new List<CPurchaseOrderPayments>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrderPayments";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CPurchaseOrderPayments objCPurchaseOrderPayments = new CPurchaseOrderPayments();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Id = 0;
                    else
                        objCPurchaseOrderPayments.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Purchaseorderguid = string.Empty;
                    else
                        objCPurchaseOrderPayments.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["PaymentReason"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Paymentreason = 0;
                    else
                        objCPurchaseOrderPayments.Paymentreason = (int)dr["PaymentReason"];
                    if (dr["PaymentDate"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Paymentdate = DateTime.MinValue;
                    else
                        objCPurchaseOrderPayments.Paymentdate = (DateTime)dr["PaymentDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Referencenumber = string.Empty;
                    else
                        objCPurchaseOrderPayments.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["Amount"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Amount = 0;
                    else
                        objCPurchaseOrderPayments.Amount = (decimal)dr["Amount"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrderPayments.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrderPayments);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderPayments::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CPurchaseOrderPayments> GetList(string Purchaseorderguid)
        {
            List<CPurchaseOrderPayments> RecordsList = new List<CPurchaseOrderPayments>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrderPayments where PurchaseOrderGuid=@PurchaseOrderGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CPurchaseOrderPayments objCPurchaseOrderPayments = new CPurchaseOrderPayments();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Id = 0;
                    else
                        objCPurchaseOrderPayments.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Purchaseorderguid = string.Empty;
                    else
                        objCPurchaseOrderPayments.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["PaymentReason"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Paymentreason = 0;
                    else
                        objCPurchaseOrderPayments.Paymentreason = (int)dr["PaymentReason"];
                    if (dr["PaymentDate"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Paymentdate = DateTime.MinValue;
                    else
                        objCPurchaseOrderPayments.Paymentdate = (DateTime)dr["PaymentDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Referencenumber = string.Empty;
                    else
                        objCPurchaseOrderPayments.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["Amount"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Amount = 0;
                    else
                        objCPurchaseOrderPayments.Amount = (decimal)dr["Amount"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderPayments.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrderPayments.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrderPayments);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderPayments::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblPurchaseOrderPayments] WHERE Id = @Id";
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
                throw new Exception("CPurchaseOrderPayments::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderPayments] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CPurchaseOrderPayments::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
