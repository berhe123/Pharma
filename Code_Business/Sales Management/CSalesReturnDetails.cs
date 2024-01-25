//
// ...
// Wizard generated code
// Date: 12/30/2009 1:51:06 PM
// Class: CSalesReturnDetails
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
    class CSalesReturnDetails
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CSalesReturnDetails()
        {
            _ConnectionString = ConnectionString;
        }
        public CSalesReturnDetails(int Id, string Salesreturnguid, string Batchguid, decimal Unitprice, decimal Quantity)
        {
            _Id = Id;
            _SalesReturnGuid = Salesreturnguid;
            _BatchGuid = Batchguid;
            _UnitPrice = Unitprice;
            _Quantity = Quantity;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _SalesReturnGuid;
        public string Salesreturnguid
        {
            get { return _SalesReturnGuid; }
            set { _SalesReturnGuid = value; }
        }

        string _BatchGuid;
        public string Batchguid
        {
            get { return _BatchGuid; }
            set { _BatchGuid = value; }
        }

        decimal _UnitPrice;
        public decimal Unitprice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        string _BatchNumber;
        public string BatchNumber
        {
            get { return _BatchNumber; }
            set { _BatchNumber = value; }
        }

        string _BrandName;
        public string BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        string _BatchGuidFromtblInvoiceDetails;
        public string BatchGuidFromtblInvoiceDetails
        {
            get { return _BatchGuidFromtblInvoiceDetails; }
            set { _BatchGuidFromtblInvoiceDetails = value; }
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
            command.CommandText = "Select * from tblSalesReturnDetails where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblSalesReturnDetails");
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
                    if (dTable.Rows[0]["SalesReturnGuid"].Equals(DBNull.Value))
                        _SalesReturnGuid = string.Empty;
                    else
                        _SalesReturnGuid = (string)dTable.Rows[0]["SalesReturnGuid"];
                    if (dTable.Rows[0]["BatchGuid"].Equals(DBNull.Value))
                        _BatchGuid = string.Empty;
                    else
                        _BatchGuid = (string)dTable.Rows[0]["BatchGuid"];
                    if (dTable.Rows[0]["UnitPrice"].Equals(DBNull.Value))
                        _UnitPrice = 0;
                    else
                        _UnitPrice = (decimal)dTable.Rows[0]["UnitPrice"];
                    if (dTable.Rows[0]["Quantity"].Equals(DBNull.Value))
                        _Quantity = 0;
                    else
                        _Quantity = (decimal)dTable.Rows[0]["Quantity"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturnDetails::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblSalesReturnDetails";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblSalesReturnDetails");
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
                throw new Exception("CSalesReturnDetails::GetRecords::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Salesreturnguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblSalesReturnDetails where SalesReturnGuid=@SalesReturnGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblSalesReturnDetails");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SalesReturnGuid", Salesreturnguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturnDetails::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblSalesReturnDetails" +
                                   " (SalesReturnGuid, " +
                                   " BatchGuid, " +
                                   " UnitPrice, " +
                                   " Quantity,UserId,ComputerName,EventSource)" +
                                   " Values (@SalesReturnGuid, " +
                                   " @BatchGuid, " +
                                   " @UnitPrice, " +
                                   " @Quantity,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblSalesReturnDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SalesReturnGuid", _SalesReturnGuid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", _BatchGuid));
                command.Parameters.Add(new SqlParameter("@UnitPrice", _UnitPrice));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));

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
                throw new Exception("CSalesReturnDetails::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblSalesReturnDetails" +
                                   " Set SalesReturnGuid = @SalesReturnGuid, " +
                                   " BatchGuid = @BatchGuid, " +
                                   " UnitPrice = @UnitPrice, " +
                                   " Quantity = @Quantity," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SalesReturnGuid", _SalesReturnGuid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", _BatchGuid));
                command.Parameters.Add(new SqlParameter("@UnitPrice", _UnitPrice));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));

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
                throw new Exception("CSalesReturnDetails::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblSalesReturnDetails Where Id = @Id ";
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
                throw new Exception("CSalesReturnDetails::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblSalesReturnDetails] WHERE " +
                                       " SalesReturnGuid = @SalesReturnGuid " +
                                       " AND BatchGuid = @BatchGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblSalesReturnDetails] WHERE " +
                                       " SalesReturnGuid = @SalesReturnGuid " +
                                       " AND BatchGuid = @BatchGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SalesReturnGuid", _SalesReturnGuid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", _BatchGuid));
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
                throw new Exception("CSalesReturnDetails::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CSalesReturnDetails> GetList()
        {
            List<CSalesReturnDetails> RecordsList = new List<CSalesReturnDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblSalesReturnDetails";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSalesReturnDetails objCSalesReturnDetails = new CSalesReturnDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Id = 0;
                    else
                        objCSalesReturnDetails.Id = (int)dr["Id"];
                    if (dr["SalesReturnGuid"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Salesreturnguid = string.Empty;
                    else
                        objCSalesReturnDetails.Salesreturnguid = (string)dr["SalesReturnGuid"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Batchguid = string.Empty;
                    else
                        objCSalesReturnDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Unitprice = 0;
                    else
                        objCSalesReturnDetails.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Quantity = 0;
                    else
                        objCSalesReturnDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Tablerowguid = string.Empty;
                    else
                        objCSalesReturnDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSalesReturnDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturnDetails::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSalesReturnDetails> GetList(string Salesreturnguid)
        {
            List<CSalesReturnDetails> RecordsList = new List<CSalesReturnDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select tblSalesReturnDetails.*, tblBatchs.BatchNumber, ";
            command.CommandText += " BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name ";
            command.CommandText += " from tblSalesReturnDetails ";
            command.CommandText += " join tblBatchs on (tblSalesReturnDetails.BatchGuid = tblBatchs.TableRowGuid) ";
            command.CommandText += " join tblItems on (tblBatchs.ItemGuid = tblItems.TableRowGuid) ";
            command.CommandText += " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            command.CommandText += " where SalesReturnGuid = @SalesReturnGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SalesReturnGuid", Salesreturnguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSalesReturnDetails objCSalesReturnDetails = new CSalesReturnDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Id = 0;
                    else
                        objCSalesReturnDetails.Id = (int)dr["Id"];
                    if (dr["SalesReturnGuid"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Salesreturnguid = string.Empty;
                    else
                        objCSalesReturnDetails.Salesreturnguid = (string)dr["SalesReturnGuid"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Batchguid = string.Empty;
                    else
                        objCSalesReturnDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCSalesReturnDetails.BatchNumber = string.Empty;
                    else
                        objCSalesReturnDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCSalesReturnDetails.BrandName = string.Empty;
                    else
                        objCSalesReturnDetails.BrandName = (string)dr["BrandName"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Unitprice = 0;
                    else
                        objCSalesReturnDetails.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Quantity = 0;
                    else
                        objCSalesReturnDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Tablerowguid = string.Empty;
                    else
                        objCSalesReturnDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSalesReturnDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturnDetails::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public string GetItemByBacth(string strBatchNo)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            string strBrandName = "";
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name from tblItems join tblBatchs on (tblItems.TableRowGuid = tblBatchs.ItemGuid) join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) where tblBatchs.BatchNumber ='" + strBatchNo + "'";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    strBrandName = dr["BrandName"].ToString();
                }
                return strBrandName;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturnDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSalesReturnDetails> GetBacthItems(string strOrderNo)
        {
            List<CSalesReturnDetails> RecordsList = new List<CSalesReturnDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select tblBatchs.TableRowGuid as BatchGuid, BatchNumber,BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name,Quantity from tblItems join tblBatchs on ";
            strSQL = strSQL + " (tblItems.TableRowGuid = tblBatchs.ItemGuid) ";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " join tblPurchaseOrders on (tblPurchaseOrders.TableRowGuid =tblBatchs.PurchaseOrderGuid) ";
            strSQL = strSQL + " where tblPurchaseOrders.OrderNumber = '" + strOrderNo + "'";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSalesReturnDetails objCSalesReturnDetails = new CSalesReturnDetails();
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCSalesReturnDetails.BatchNumber = string.Empty;
                    else
                        objCSalesReturnDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCSalesReturnDetails.BrandName = string.Empty;
                    else
                        objCSalesReturnDetails.BrandName = (string)dr["BrandName"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Quantity = decimal.Zero;
                    else
                        objCSalesReturnDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Unitprice = decimal.Zero;
                    else
                        objCSalesReturnDetails.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCSalesReturnDetails.BatchGuidFromtblInvoiceDetails = string.Empty;
                    else
                        objCSalesReturnDetails.BatchGuidFromtblInvoiceDetails = (string)dr["BatchGuid"];

                    RecordsList.Add(objCSalesReturnDetails);

                }
                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturnDetails::GetBacthItems::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSalesReturnDetails> GetBacthItemsByInvoiceNo(string strOrderNo)
        {
            List<CSalesReturnDetails> RecordsList = new List<CSalesReturnDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select tblBatchs.TableRowGuid as BatchGuid, BatchNumber,BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name, tblInvoiceDetails.Quantity, tblInvoiceDetails.UnitPrice from tblItems join tblBatchs on ";
            strSQL = strSQL + " (tblItems.TableRowGuid = tblBatchs.ItemGuid) ";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " join tblInvoiceDetails on (tblInvoiceDetails.BatchGuid =tblBatchs.TableRowGuid) ";
            strSQL = strSQL + " join tblInvoices on (tblInvoiceDetails.InvoiceGuid =tblInvoices.TableRowGuid) ";
            strSQL = strSQL + " where tblInvoices.ReferenceNumber = '" + strOrderNo + "'";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSalesReturnDetails objCSalesReturnDetails = new CSalesReturnDetails();
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCSalesReturnDetails.BatchNumber = string.Empty;
                    else
                        objCSalesReturnDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCSalesReturnDetails.BrandName = string.Empty;
                    else
                        objCSalesReturnDetails.BrandName = (string)dr["BrandName"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Quantity = decimal.Zero;
                    else
                        objCSalesReturnDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCSalesReturnDetails.Unitprice = decimal.Zero;
                    else
                        objCSalesReturnDetails.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCSalesReturnDetails.BatchGuidFromtblInvoiceDetails = string.Empty;
                    else
                        objCSalesReturnDetails.BatchGuidFromtblInvoiceDetails = (string)dr["BatchGuid"];

                    RecordsList.Add(objCSalesReturnDetails);

                }
                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturnDetails::GetBacthItems::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool CheckHasChildren()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select * from tblSalesReturnDetails where SalesReturnGuid =@SalesReturnGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SalesReturnGuid", _SalesReturnGuid));
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CSalesReturnDetails::CheckHasChildren::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblSalesReturnDetails] WHERE Id = @Id";
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
                throw new Exception("CSalesReturnDetails::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblSalesReturnDetails] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CSalesReturnDetails::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
