//
// ...
// Wizard generated code
// Date: 9/23/2009 2:41:35 PM
// Class: CCashCollectionInvoices
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
    class CCashCollectionInvoices
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }
        public CCashCollectionInvoices()
        {
            _ConnectionString = ConnectionString;
        }
        public CCashCollectionInvoices(int Id, string Cashcollectionguid, string Invoiceguid)
        {
            _Id = Id;
            _CashCollectionGuid = Cashcollectionguid;
            _InvoiceGuid = Invoiceguid;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _CashCollectionGuid;
        public string Cashcollectionguid
        {
            get { return _CashCollectionGuid; }
            set { _CashCollectionGuid = value; }
        }

        string _InvoiceGuid;
        public string Invoiceguid
        {
            get { return _InvoiceGuid; }
            set { _InvoiceGuid = value; }
        }

        string _InvoiceNo;
        public string InvoiceNo
        {
            get { return _InvoiceNo; }
            set { _InvoiceNo = value; }
        }

        int _ItemCount;
        public int ItemCount
        {
            get { return _ItemCount; }
            set { _ItemCount = value; }
        }

        decimal _TotalAmount;
        public decimal TotalAmount
        {
            get { return _TotalAmount; }
            set { _TotalAmount = value; }
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
            command.CommandText = "Select * from tblCashCollectionInvoices where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblCashCollectionInvoices");
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
                    if (dTable.Rows[0]["CashCollectionGuid"].Equals(DBNull.Value))
                        _CashCollectionGuid = string.Empty;
                    else
                        _CashCollectionGuid = (string)dTable.Rows[0]["CashCollectionGuid"];
                    if (dTable.Rows[0]["InvoiceGuid"].Equals(DBNull.Value))
                        _InvoiceGuid = string.Empty;
                    else
                        _InvoiceGuid = (string)dTable.Rows[0]["InvoiceGuid"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollectionInvoices::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                if(connection != null) if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblCashCollectionInvoices";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblCashCollectionInvoices");
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
                throw new Exception("CCashCollectionInvoices::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Cashcollectionguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblCashCollectionInvoices where CashCollectionGuid=@CashCollectionGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblCashCollectionInvoices");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollectionInvoices::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblCashCollectionInvoices" +
                                   " (CashCollectionGuid, " +
                                   " InvoiceGuid,UserId,ComputerName,EventSource)" +
                                   " Values (@CashCollectionGuid, " +
                                   " @InvoiceGuid,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id= Max(id) from tblCashCollectionInvoices ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", _CashCollectionGuid));
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));

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
                throw new Exception("CCashCollectionInvoices::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblCashCollectionInvoices" +
                                   " Set CashCollectionGuid = @CashCollectionGuid, " +
                                   " InvoiceGuid = @InvoiceGuid," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", _CashCollectionGuid));
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));

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
                throw new Exception("CCashCollectionInvoices::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblCashCollectionInvoices Where Id = @Id ";
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
                throw new Exception("CCashCollectionInvoices::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblCashCollectionInvoices] WHERE " +
                                       " CashCollectionGuid = @CashCollectionGuid " +
                                       " AND InvoiceGuid = @InvoiceGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblCashCollectionInvoices] WHERE " +
                                       " CashCollectionGuid = @CashCollectionGuid " +
                                       " AND InvoiceGuid = @InvoiceGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", _CashCollectionGuid));
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));
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
                throw new Exception("CCashCollectionInvoices::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Cashcollectionguid, string Invoiceguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblCashCollectionInvoices" +
                                   " (CashCollectionGuid, " +
                                   " InvoiceGuid)" +
                                   " Values (@CashCollectionGuid, " +
                                   " @InvoiceGuid)" +
                                   " Select @Id=Max(id) from tblCashCollectionInvoices ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", Invoiceguid));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollectionInvoices::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Cashcollectionguid, string Invoiceguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblCashCollectionInvoices" +
                                   " Set CashCollectionGuid = @CashCollectionGuid, " +
                                   " InvoiceGuid = @InvoiceGuid" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", Invoiceguid));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollectionInvoices::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblCashCollectionInvoices Where Id = @Id ";
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
                throw new Exception("CCashCollectionInvoices::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Cashcollectionguid, string Invoiceguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblCashCollectionInvoices] WHERE " +
                                       " CashCollectionGuid = @CashCollectionGuid " +
                                       " AND InvoiceGuid = @InvoiceGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblCashCollectionInvoices] WHERE " +
                                       " CashCollectionGuid = @CashCollectionGuid " +
                                       " AND InvoiceGuid = @InvoiceGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", Invoiceguid));
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
                throw new Exception("CCashCollectionInvoices::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CCashCollectionInvoices> GetList()
        {
            List<CCashCollectionInvoices> RecordsList = new List<CCashCollectionInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblCashCollectionInvoices";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CCashCollectionInvoices objCCashCollectionInvoices = new CCashCollectionInvoices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.Id = 0;
                    else
                        objCCashCollectionInvoices.Id = (int)dr["Id"];
                    if (dr["CashCollectionGuid"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.Cashcollectionguid = string.Empty;
                    else
                        objCCashCollectionInvoices.Cashcollectionguid = (string)dr["CashCollectionGuid"];
                    if (dr["InvoiceGuid"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.Invoiceguid = string.Empty;
                    else
                        objCCashCollectionInvoices.Invoiceguid = (string)dr["InvoiceGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.Tablerowguid = string.Empty;
                    else
                        objCCashCollectionInvoices.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCCashCollectionInvoices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollectionInvoices::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CCashCollectionInvoices> GetList(string Cashcollectionguid)
        {
            List<CCashCollectionInvoices> RecordsList = new List<CCashCollectionInvoices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select tblCashCollectionInvoices.Id, tblCashCollectionInvoices.TableRowGuid, ";
            command.CommandText += " CashCollectionGuid, InvoiceGuid, ";
            command.CommandText += " ReferenceNumber, ItemCount, InvoiceTotal ";
            command.CommandText += " FROM tblCashCollectionInvoices INNER JOIN ";
            command.CommandText += "    (Select tblInvoices.TableRowGuid, ReferenceNumber, ";
            command.CommandText += "    Count(tblInvoiceDetails.Id) AS ItemCount, ";
            command.CommandText += "    SUM(tblInvoiceDetails.Quantity * tblInvoiceDetails.UnitPrice - (tblInvoiceDetails.Quantity * tblInvoiceDetails.UnitPrice * tblInvoices.Discount * 0.01)) AS InvoiceTotal ";
            command.CommandText += "    FROM tblInvoices INNER JOIN tblInvoiceDetails ";
            command.CommandText += "    ON tblInvoices.TableRowGuid = tblInvoiceDetails.InvoiceGuid ";
            command.CommandText += "    INNER JOIN tblBatchs ";
            command.CommandText += "    ON tblBatchs.TableRowGuid = tblInvoiceDetails.BatchGuid ";
            command.CommandText += "    GROUP BY tblInvoices.TableRowGuid, ReferenceNumber) tblInvoices ";
            command.CommandText += " ON tblCashCollectionInvoices.InvoiceGuid = tblInvoices.TableRowGuid ";
            command.CommandText += " where CashCollectionGuid = @CashCollectionGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CashCollectionGuid", Cashcollectionguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CCashCollectionInvoices objCCashCollectionInvoices = new CCashCollectionInvoices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.Id = 0;
                    else
                        objCCashCollectionInvoices.Id = (int)dr["Id"];
                    if (dr["CashCollectionGuid"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.Cashcollectionguid = string.Empty;
                    else
                        objCCashCollectionInvoices.Cashcollectionguid = (string)dr["CashCollectionGuid"];
                    if (dr["InvoiceGuid"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.Invoiceguid = string.Empty;
                    else
                        objCCashCollectionInvoices.Invoiceguid = (string)dr["InvoiceGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.Tablerowguid = string.Empty;
                    else
                        objCCashCollectionInvoices.Tablerowguid = (string)dr["TableRowGuid"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.InvoiceNo = string.Empty;
                    else
                        objCCashCollectionInvoices.InvoiceNo = (string)dr["ReferenceNumber"];
                    if (dr["ItemCount"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.ItemCount = 0;
                    else
                        objCCashCollectionInvoices.ItemCount = (int)dr["ItemCount"];
                    if (dr["InvoiceTotal"].Equals(DBNull.Value))
                        objCCashCollectionInvoices.TotalAmount = 0;
                    else
                        objCCashCollectionInvoices.TotalAmount = (decimal)dr["InvoiceTotal"];

                    RecordsList.Add(objCCashCollectionInvoices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCashCollectionInvoices::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblCashCollectionInvoices] WHERE Id = @Id";
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
                throw new Exception("CCashCollectionInvoices::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblCashCollectionInvoices] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CCashCollectionInvoices::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
