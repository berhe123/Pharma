//
// ...
// Wizard generated code
// Date: 8/6/2009 7:46:32 PM
// Class: CInvoiceDetails
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
    class CInvoiceDetails
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CInvoiceDetails()
        {
            _ConnectionString = ConnectionString;
        }
        public CInvoiceDetails(int Id, string Invoiceguid, string Batchguid, decimal Quantity, decimal Unitprice)
        {
            _Id = Id;
            _InvoiceGuid = Invoiceguid;
            _BatchGuid = Batchguid;
            _Quantity = Quantity;
            _UnitPrice = Unitprice;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _InvoiceGuid;
        public string Invoiceguid
        {
            get { return _InvoiceGuid; }
            set { _InvoiceGuid = value; }
        }

        string _BatchGuid;
        public string Batchguid
        {
            get { return _BatchGuid; }
            set { _BatchGuid = value; }
        }

        // Not a basic attribute
        string _BatchNumber;
        public string BatchNumber
        {
            get { return _BatchNumber; }
            set { _BatchNumber = value; }
        }

        // Not a basic attribute
        string _ItemDescription;
        public string ItemDescription
        {
            get { return _ItemDescription; }
            set { _ItemDescription = value; }
        }

        // Not a basic attribute
        string _UnitOfMeasurement;
        public string UnitOfMeasurement
        {
            get { return _UnitOfMeasurement; }
            set { _UnitOfMeasurement = value; }
        }

        // Not a basic attribute
        string _DosageFormGuid;
        public string Dosageformguid
        {
            get { return _DosageFormGuid; }
            set { _DosageFormGuid = value; }
        }

        decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        decimal _UnitPrice;
        public decimal UnitPrice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
        }

        // Not a basic attribute
        decimal _SalePrice;
        public decimal SalePrice
        {
            get { return _SalePrice; }
            set { _SalePrice = value; }
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
            command.CommandText = "Select * from tblInvoiceDetails where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblInvoiceDetails");
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
                    if (dTable.Rows[0]["InvoiceGuid"].Equals(DBNull.Value))
                        _InvoiceGuid = string.Empty;
                    else
                        _InvoiceGuid = (string)dTable.Rows[0]["InvoiceGuid"];
                    if (dTable.Rows[0]["BatchGuid"].Equals(DBNull.Value))
                        _BatchGuid = string.Empty;
                    else
                        _BatchGuid = (string)dTable.Rows[0]["BatchGuid"];
                    if (dTable.Rows[0]["Quantity"].Equals(DBNull.Value))
                        _Quantity = decimal.Zero;
                    else
                        _Quantity = (decimal)dTable.Rows[0]["Quantity"];
                    if (dTable.Rows[0]["UnitPrice"].Equals(DBNull.Value))
                        _UnitPrice = decimal.Zero;
                    else
                        _UnitPrice = (decimal)dTable.Rows[0]["UnitPrice"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoiceDetails::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblInvoiceDetails";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblInvoiceDetails");
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
                throw new Exception("CInvoiceDetails::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblInvoiceDetails" +
                                   " (InvoiceGuid, " +
                                   " BatchGuid, " +
                                   " Quantity, " +
                                   " UnitPrice,UserId,ComputerName,EventSource)" +
                                   " Values (@InvoiceGuid, " +
                                   " @BatchGuid, " +
                                   " @Quantity, " +
                                   " @UnitPrice,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblInvoiceDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", _BatchGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                command.Parameters.Add(new SqlParameter("@UnitPrice", _UnitPrice));

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
                throw new Exception("CInvoiceDetails::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblInvoiceDetails" +
                                   " Set InvoiceGuid = @InvoiceGuid, " +
                                   " BatchGuid = @BatchGuid, " +
                                   " Quantity = @Quantity, " +
                                   " UnitPrice = @UnitPrice," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", _InvoiceGuid));
                command.Parameters.Add(new SqlParameter("@BatchGuid", _BatchGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                command.Parameters.Add(new SqlParameter("@UnitPrice", _UnitPrice));

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
                throw new Exception("CInvoiceDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblInvoiceDetails Where Id = @Id ";
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
                throw new Exception("CInvoiceDetails::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblInvoiceDetails] WHERE " +
                                       " InvoiceGuid = @InvoiceGuid and BatchGuid =@BatchGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblInvoiceDetails] WHERE " +
                                       " InvoiceGuid = @InvoiceGuid and BatchGuid =@BatchGuid" +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@BatchGuid", _BatchGuid));
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
                throw new Exception("CInvoiceDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CInvoiceDetails> GetList()
        {
            List<CInvoiceDetails> RecordsList = new List<CInvoiceDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblInvoiceDetails";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoiceDetails objCInvoiceDetails = new CInvoiceDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCInvoiceDetails.Id = 0;
                    else
                        objCInvoiceDetails.Id = (int)dr["Id"];
                    if (dr["InvoiceGuid"].Equals(DBNull.Value))
                        objCInvoiceDetails.Invoiceguid = string.Empty;
                    else
                        objCInvoiceDetails.Invoiceguid = (string)dr["InvoiceGuid"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCInvoiceDetails.Batchguid = string.Empty;
                    else
                        objCInvoiceDetails.Batchguid = (string)dr["BatchGuid"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCInvoiceDetails.Quantity = decimal.Zero;
                    else
                        objCInvoiceDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCInvoiceDetails.UnitPrice = decimal.Zero;
                    else
                        objCInvoiceDetails.UnitPrice = (decimal)dr["UnitPrice"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCInvoiceDetails.Tablerowguid = string.Empty;
                    else
                        objCInvoiceDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCInvoiceDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoiceDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CInvoiceDetails> GetList(string Invoiceguid)
        {
            List<CInvoiceDetails> RecordsList = new List<CInvoiceDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            command.CommandText = " SELECT   tblInvoiceDetails.Id, tblInvoiceDetails.TableRowGuid, tblInvoiceDetails.InvoiceGuid, tblInvoiceDetails.BatchGuid,  ";
            command.CommandText += "                 tblInvoiceDetails.UnitPrice, tblInvoiceDetails.Quantity, tblBatchs.BatchNumber,  ";
            command.CommandText += "                 tblItems.BrandName, tblItems.GenericName, tblItems.Strength,  ";
            command.CommandText += "                 tblItems.Measurement,  ";
            command.CommandText += "                 tblUnitOfMeasurements.Name AS UnitOfMeasurement,  ";
            command.CommandText += "                 tblItems.BrandName AS ItemDescription,  ";
            command.CommandText += "                 tblBatchs.SalePrice ";
            command.CommandText += " FROM      tblInvoiceDetails INNER JOIN ";
            command.CommandText += "                 tblBatchs ON tblInvoiceDetails.BatchGuid = tblBatchs.TableRowGuid INNER JOIN ";
            command.CommandText += "                 tblItems ON tblBatchs.ItemGuid = tblItems.TableRowGuid INNER JOIN ";
            command.CommandText += "                 tblUnitOfMeasurements ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";            
            command.CommandText += " where InvoiceGuid=@InvoiceGuid ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@InvoiceGuid", Invoiceguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CInvoiceDetails objCInvoiceDetails = new CInvoiceDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCInvoiceDetails.Id = 0;
                    else
                        objCInvoiceDetails.Id = (int)dr["Id"];
                    if (dr["InvoiceGuid"].Equals(DBNull.Value))
                        objCInvoiceDetails.Invoiceguid = string.Empty;
                    else
                        objCInvoiceDetails.Invoiceguid = (string)dr["InvoiceGuid"];
                    if (dr["BatchGuid"].Equals(DBNull.Value))
                        objCInvoiceDetails.Batchguid = string.Empty;
                    else
                        objCInvoiceDetails.Batchguid = (string)dr["BatchGuid"];

                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCInvoiceDetails.BatchNumber = string.Empty;
                    else
                        objCInvoiceDetails.BatchNumber = (string)dr["BatchNumber"];
                    if (dr["ItemDescription"].Equals(DBNull.Value))
                        objCInvoiceDetails.ItemDescription = string.Empty;
                    else
                        objCInvoiceDetails.ItemDescription = (string)dr["ItemDescription"];
                    if (dr["UnitOfMeasurement"].Equals(DBNull.Value))
                        objCInvoiceDetails.UnitOfMeasurement = string.Empty;
                    else
                        objCInvoiceDetails.UnitOfMeasurement = (string)dr["UnitOfMeasurement"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCInvoiceDetails.Quantity = decimal.Zero;
                    else
                        objCInvoiceDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCInvoiceDetails.UnitPrice = decimal.Zero;
                    else
                        objCInvoiceDetails.UnitPrice = (decimal)dr["UnitPrice"];
                    if (dr["SalePrice"].Equals(DBNull.Value))
                        objCInvoiceDetails.SalePrice = decimal.Zero;
                    else
                        objCInvoiceDetails.SalePrice = (decimal)dr["SalePrice"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCInvoiceDetails.Tablerowguid = string.Empty;
                    else
                        objCInvoiceDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCInvoiceDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CInvoiceDetails::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblInvoiceDetails] WHERE Id = @Id";
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
                throw new Exception("CInvoiceDetails::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblInvoiceDetails] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CInvoiceDetails::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
