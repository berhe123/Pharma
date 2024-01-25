//
// ...
// Wizard generated code
// Date: 7/19/2009 11:00:57 AM
// Class: CStoreTransactionDetails
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
    class CStoreTransactionDetails
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CStoreTransactionDetails()
        {
            _ConnectionString = ConnectionString;
        }
        public CStoreTransactionDetails(int Id, string Transactionguid, string Batchguid, int Quantity)
        {
            _Id = Id;
            _TransactionGuid = Transactionguid;
            _BatchGuid = Batchguid;
            _Quantity = Quantity;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _TransactionGuid;
        public string Transactionguid
        {
            get { return _TransactionGuid; }
            set { _TransactionGuid = value; }
        }

        string _BatchGuid;
        public string Batchguid
        {
            get { return _BatchGuid; }
            set { _BatchGuid = value; }
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

        decimal _BatchQuantity;
        public decimal BatchQuantity
        {
            get { return _BatchQuantity; }
            set { _BatchQuantity = value; }
        }

        int _BatchIdFromtblBatchs;
        public int BatchIdFromtblBatchs
        {
            get { return _BatchIdFromtblBatchs; }
            set { _BatchIdFromtblBatchs = value; }
        }

        int _TransactionType;
        public int Transactiontype
        {
            get { return _TransactionType; }
            set { _TransactionType = value; }
        }

        string _TableRowGuid;
        public string Tablerowguid
        {
            get { return _TableRowGuid; }
            set { _TableRowGuid = value; }
        }

        string _PurchaseOrderGuid;
        public string Purchaseorderguid
        {
            get { return _PurchaseOrderGuid; }
            set { _PurchaseOrderGuid = value; }
        }

        #endregion

        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblStoreTransactionDetails where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblStoreTransactionDetails");
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
                    if (dTable.Rows[0]["TransactionGuid"].Equals(DBNull.Value))
                        _TransactionGuid = string.Empty;
                    else
                        _TransactionGuid = (string)dTable.Rows[0]["TransactionGuid"];
                    if (dTable.Rows[0]["BatchGuid"].Equals(DBNull.Value))
                        _BatchGuid = string.Empty;
                    else
                        _BatchGuid = (string)dTable.Rows[0]["BatchGuid"];
                    if (dTable.Rows[0]["Quantity"].Equals(DBNull.Value))
                        _Quantity = 0;
                    else
                        _Quantity = (int)dTable.Rows[0]["Quantity"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblStoreTransactionDetails";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblStoreTransactionDetails");
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
                throw new Exception("CStoreTransactionDetails::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public int CheckWeatherBatchIsReceived(string strBatchGuid)
        {

            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            int intReturn = 0;
            command.CommandText = " Select tblStoreTransactions.Id From tblStoreTransactions ";
            command.CommandText += " Inner Join tblStoreTransactionDetails on tblStoreTransactionDetails.TransactionGuid=tblStoreTransactions.TableRowGuid ";
            command.CommandText += " Where tblStoreTransactionDetails.BatchGuid = '" + strBatchGuid + "'";
            command.CommandText += " And TransactionType = 0 ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                intReturn = Convert.ToInt32(command.ExecuteScalar());
                return intReturn;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::GetBatch::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();

            }
        }
        public bool Insert()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblStoreTransactionDetails" +
                                   " (TransactionGuid, " +
                                   " BatchGuid, " +
                                   " Quantity)" +
                                   " Values (@TransactionGuid, " +
                                   " @BatchGuid, " +
                                   " @Quantity)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TransactionGuid", _TransactionGuid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", _BatchGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));

                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblStoreTransactionDetails" +
                                   " Set TransactionGuid = @TransactionGuid, " +
                                   " BatchGuid = @BatchGuid, " +
                                   " Quantity = @Quantity" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TransactionGuid", _TransactionGuid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", _BatchGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblStoreTransactionDetails Where Id = @Id ";
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
                throw new Exception("CStoreTransactionDetails::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT tblStoreTransactionDetails.Id FROM [dbo].[tblStoreTransactionDetails] join tblStoreTransactions on (tblStoreTransactionDetails.TransactionGuid =tblStoreTransactions.TableRowGuid ) WHERE " +
                                       " tblStoreTransactionDetails.TransactionGuid = @TransactionGuid AND BatchGuid = @BatchGuid And TransactionType = @TransactionType ";                                    
            else
                command.CommandText = "SELECT tblStoreTransactionDetails.Id FROM [dbo].[tblStoreTransactionDetails] join tblStoreTransactions on (tblStoreTransactionDetails.TransactionGuid =tblStoreTransactions.TableRowGuid ) WHERE " +
                                       " tblStoreTransactionDetails.TransactionGuid = @TransactionGuid AND BatchGuid = @BatchGuid And TransactionType = @TransactionType " + 
                                       " AND tblStoreTransactionDetails.Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TransactionGuid", _TransactionGuid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", _BatchGuid));
                command.Parameters.Add(new SqlParameter("@TransactionType", _TransactionType));  

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
                throw new Exception("CStoreTransactionDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Transactionguid, string Batchguid, int Quantity)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblStoreTransactionDetails" +
                                   " (TransactionGuid, " +
                                   " BatchGuid, " +
                                   " Quantity)" +
                                   " Values (@TransactionGuid, " +
                                   " @BatchGuid, " +
                                   " @Quantity)" +
                                   " Select @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TransactionGuid", Transactionguid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", Batchguid));
                command.Parameters.Add(new SqlParameter("@Quantity", Quantity));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Transactionguid, string Batchguid, int Quantity)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblStoreTransactionDetails" +
                                   " Set TransactionGuid = @TransactionGuid, " +
                                   " BatchGuid = @BatchGuid, " +
                                   " Quantity = @Quantity" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TransactionGuid", Transactionguid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", Batchguid));
                command.Parameters.Add(new SqlParameter("@Quantity", Quantity));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblStoreTransactionDetails Where Id = @Id ";
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
                throw new Exception("CStoreTransactionDetails::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Transactionguid, string Batchguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblStoreTransactionDetails] WHERE " +
                                       " TransactionGuid = @TransactionGuid " +
                                       " AND BatchGuid = @BatchGuid ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblStoreTransactionDetails] WHERE " +
                                       " TransactionGuid = @TransactionGuid " +
                                       " AND BatchGuid = @BatchGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters.Add(new SqlParameter("@TransactionGuid", Transactionguid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", Batchguid));
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
                throw new Exception("CStoreTransactionDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CStoreTransactionDetails> GetList()
        {
            List<CStoreTransactionDetails> RecordsList = new List<CStoreTransactionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblStoreTransactionDetails";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStoreTransactionDetails objCStoreTransactionDetails = new CStoreTransactionDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Id = 0;
                    else
                        objCStoreTransactionDetails.Id = (int)dr["Id"];
                    if (dr["TransactionGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Transactionguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Transactionguid = (string)dr["TransactionGuid"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Batchguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Quantity = 0;
                    else
                        objCStoreTransactionDetails.Quantity = (int)dr["Quantity"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Tablerowguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCStoreTransactionDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CStoreTransactionDetails> GetList(string Transactionguid)
        {
            List<CStoreTransactionDetails> RecordsList = new List<CStoreTransactionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select tblStoreTransactionDetails.*,BatchNumber,";
           strSQL = strSQL + " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems ";
           strSQL = strSQL + "  inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid ";
           strSQL = strSQL + "  inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid ";
           strSQL = strSQL + "  inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid ";
           strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid ";
           strSQL = strSQL + " join tblBatchs on (tblBatchs.ItemGuid = tblItems.TableRowGuid)   ";
           strSQL = strSQL + " join tblStoreTransactionDetails on (tblStoreTransactionDetails.BatchGuid = tblBatchs.TableRowGuid)   ";          
            strSQL = strSQL + " where tblStoreTransactionDetails.TransactionGuid = '" + Transactionguid + "' ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStoreTransactionDetails objCStoreTransactionDetails = new CStoreTransactionDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Id = 0;
                    else
                        objCStoreTransactionDetails.Id = (int)dr["Id"];
                    if (dr["TransactionGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Transactionguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Transactionguid = (string)dr["TransactionGuid"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Batchguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Quantity = decimal.Zero;
                    else
                        objCStoreTransactionDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchNumber = string.Empty;
                    else
                        objCStoreTransactionDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BrandName = string.Empty;
                    else
                        objCStoreTransactionDetails.BrandName = (string)dr["BrandName"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Tablerowguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCStoreTransactionDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::GetList::Error! " + ex.Message, ex);
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
                throw new Exception("CStoreTransactionDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CStoreTransactionDetails> GetBacthItems(string strOrderNo)
        {
            List<CStoreTransactionDetails> RecordsList = new List<CStoreTransactionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;           
            SqlCommand command = new SqlCommand();
            string strSQL="";
            strSQL = strSQL + " Select TableRowGuid ='', tblBatchs.id as BatchId, tblBatchs.TableRowGuid as BatchGuid, BatchNumber,BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name,Quantity from tblItems join tblBatchs on ";
            strSQL = strSQL + " (tblItems.TableRowGuid = tblBatchs.ItemGuid) ";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " join tblPurchaseOrders on (tblPurchaseOrders.TableRowGuid =tblBatchs.PurchaseOrderguid) ";
            strSQL = strSQL + " where tblPurchaseOrders.OrderNumber = '" + strOrderNo + "'";
            strSQL = strSQL + " and tblBatchs.PurchaseOrderType = " + (int)CCommon.SupplierType.Exporter;

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStoreTransactionDetails objCStoreTransactionDetails = new CStoreTransactionDetails();
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchNumber = string.Empty;
                    else
                        objCStoreTransactionDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BrandName = string.Empty;
                    else
                        objCStoreTransactionDetails.BrandName = (string)dr["BrandName"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchQuantity = decimal.Zero;
                    else
                        objCStoreTransactionDetails.BatchQuantity = (decimal)dr["Quantity"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Batchguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Tablerowguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCStoreTransactionDetails);
                    
                }
                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::GetBacthItems::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CStoreTransactionDetails> GetLocalBacthItems(string strOrderNo)
        {
            List<CStoreTransactionDetails> RecordsList = new List<CStoreTransactionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select TableRowGuid ='', tblBatchs.id as BatchId, tblBatchs.TableRowGuid as BatchGuid, BatchNumber, tblBatchs.Quantity,";
            strSQL = strSQL + " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)As BrandName  from tblitems";
            strSQL = strSQL + " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
            strSQL = strSQL + " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
            strSQL = strSQL + " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
            strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
            strSQL = strSQL + " inner join tblBatchs on  (tblItems.TableRowGuid = tblBatchs.ItemGuid)";
            strSQL = strSQL + " inner join tblLocalPurchaseOrders on (tblLocalPurchaseOrders.TableRowGuid =tblBatchs.PurchaseOrderguid)";



            //strSQL = strSQL + " from tblItems join tblBatchs on ";
            //strSQL = strSQL + " (tblItems.TableRowGuid = tblBatchs.ItemGuid) ";            
            //strSQL = strSQL + " join tblLocalPurchaseOrders on (tblLocalPurchaseOrders.TableRowGuid =tblBatchs.PurchaseOrderguid) ";
            strSQL = strSQL + " where tblLocalPurchaseOrders.OrderNumber = '" + strOrderNo + "'";
            //strSQL = strSQL + " and tblBatchs.PurchaseOrderType = " + (int)CCommon.SupplierType.Local;

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStoreTransactionDetails objCStoreTransactionDetails = new CStoreTransactionDetails();
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchNumber = string.Empty;
                    else
                        objCStoreTransactionDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BrandName = string.Empty;
                    else
                        objCStoreTransactionDetails.BrandName = (string)dr["BrandName"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchQuantity = decimal.Zero;
                    else
                        objCStoreTransactionDetails.BatchQuantity = (decimal)dr["Quantity"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Batchguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Tablerowguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCStoreTransactionDetails);

                }
                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::GetBacthItems::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CStoreTransactionDetails> GetBacthItemsByInvoiceNo(string strOrderNo, string strInvoiceGuid)
        {
            List<CStoreTransactionDetails> RecordsList = new List<CStoreTransactionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;           
            SqlCommand command = new SqlCommand();
            string strSQL="";
            strSQL = strSQL + " Select tblBatchs.id as BatchId, tblBatchs.TableRowGuid as BatchGuid, BatchNumber,BrandName = BrandName,tblInvoiceDetails.Quantity from tblItems join tblBatchs on ";
            strSQL = strSQL + " (tblItems.TableRowGuid = tblBatchs.ItemGuid) ";            
            strSQL = strSQL + " join tblInvoiceDetails on (tblInvoiceDetails.BatchGuid =tblBatchs.TableRowGuid) ";
            strSQL = strSQL + " join tblInvoices on (tblInvoiceDetails.InvoiceGuid =tblInvoices.TableRowGuid) ";
            strSQL = strSQL + " where tblInvoices.TableRowGuid = '" + strInvoiceGuid + "'";
            strSQL = strSQL + " And tblInvoices.ReferenceNumber = '" + strOrderNo + "'";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStoreTransactionDetails objCStoreTransactionDetails = new CStoreTransactionDetails();
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchNumber = string.Empty;
                    else
                        objCStoreTransactionDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BrandName = string.Empty;
                    else
                        objCStoreTransactionDetails.BrandName = (string)dr["BrandName"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchQuantity = decimal.Zero;
                    else
                        objCStoreTransactionDetails.BatchQuantity = (decimal)dr["Quantity"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Batchguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Tablerowguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Tablerowguid = (string)dr["BatchGuid"];

                    RecordsList.Add(objCStoreTransactionDetails);
                    
                }
                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::GetBacthItems::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CStoreTransactionDetails> GetBacthItemsByInvoiceNo(string strOrderNo)
        {
            List<CStoreTransactionDetails> RecordsList = new List<CStoreTransactionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select tblBatchs.id as BatchId, tblBatchs.TableRowGuid as BatchGuid, BatchNumber,BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name,tblInvoiceDetails.Quantity from tblItems join tblBatchs on ";
            strSQL = strSQL + " (tblItems.TableRowGuid = tblBatchs.ItemGuid) ";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " join tblInvoiceDetails on (tblInvoiceDetails.BatchGuid =tblBatchs.TableRowGuid) ";
            strSQL = strSQL + " join tblInvoices on (tblInvoiceDetails.InvoiceGuid =tblInvoices.TableRowGuid) ";
            strSQL = strSQL + " where tblInvoices.DeliveryStauts <> 2 ";
            strSQL = strSQL + " And tblInvoices.ReferenceNumber = '" + strOrderNo + "'";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStoreTransactionDetails objCStoreTransactionDetails = new CStoreTransactionDetails();
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchNumber = string.Empty;
                    else
                        objCStoreTransactionDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BrandName = string.Empty;
                    else
                        objCStoreTransactionDetails.BrandName = (string)dr["BrandName"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchQuantity = decimal.Zero;
                    else
                        objCStoreTransactionDetails.BatchQuantity = (decimal)dr["Quantity"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Batchguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Tablerowguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Tablerowguid = (string)dr["BatchGuid"];

                    RecordsList.Add(objCStoreTransactionDetails);

                }
                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::GetBacthItems::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CStoreTransactionDetails> GetBacthItemsByPurchaseOrderNo(string strOrderNo)
        {
            List<CStoreTransactionDetails> RecordsList = new List<CStoreTransactionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = "";
            strSQL = strSQL + " Select tblBatchs.id as BatchId, tblBatchs.TableRowGuid as BatchGuid, BatchNumber,BrandName = BrandName,tblBatchs.Quantity,tblBatchs.PurchaseOrderGuid from tblItems join tblBatchs on ";
            strSQL = strSQL + " (tblItems.TableRowGuid = tblBatchs.ItemGuid) ";
            strSQL = strSQL + " join tblLocalPurchaseOrders on (tblBatchs.PurchaseOrderGuid =tblLocalPurchaseOrders.TableRowGuid) ";
            //strSQL = strSQL + " join tblLocalPurchaseOrderDetails on (tblLocalPurchaseOrderDetails.PurchaseOrderGuid = tblLocalPurchaseOrders.TableRowGuid And tblLocalPurchaseOrderDetails.ItemGuid = tblBatchs.ItemGuid) ";            

            strSQL = strSQL + " And tblLocalPurchaseOrders.OrderNumber = '" + strOrderNo + "'";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CStoreTransactionDetails objCStoreTransactionDetails = new CStoreTransactionDetails();
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchNumber = string.Empty;
                    else
                        objCStoreTransactionDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BrandName = string.Empty;
                    else
                        objCStoreTransactionDetails.BrandName = (string)dr["BrandName"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.BatchQuantity = decimal.Zero;
                    else
                        objCStoreTransactionDetails.BatchQuantity = (decimal)dr["Quantity"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Batchguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Tablerowguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Tablerowguid = (string)dr["BatchGuid"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCStoreTransactionDetails.Purchaseorderguid = string.Empty;
                    else
                        objCStoreTransactionDetails.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];

                    RecordsList.Add(objCStoreTransactionDetails);

                }
                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::GetBacthItems::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool CheckHasChildren(string Transactionguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;           
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select * from tblStoreTransactionDetails where TransactionGuid =@TransactionGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TransactionGuid", Transactionguid));
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CStoreTransactionDetails::CheckHasChildren::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblStoreTransactionDetails] WHERE Id = @Id";
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
                throw new Exception("CStoreTransactionDetails::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblStoreTransactionDetails] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CStoreTransactionDetails::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
