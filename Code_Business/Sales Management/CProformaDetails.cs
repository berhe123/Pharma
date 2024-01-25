//
// ...
// Wizard generated code
// Date: 7/28/2009 5:52:51 PM
// Class: CProformaDetails
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
    class CProformaDetails
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CProformaDetails()
        {
            _ConnectionString = ConnectionString;
        }
        public CProformaDetails(int Id, string Proformaguid, string Itemguid, decimal Unitprice, decimal Quantity)
        {
            _Id = Id;
            _ProformaGuid = Proformaguid;
            _ItemGuid = Itemguid;
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

        string _ProformaGuid;
        public string Proformaguid
        {
            get { return _ProformaGuid; }
            set { _ProformaGuid = value; }
        }

        string _ItemGuid;
        public string Itemguid
        {
            get { return _ItemGuid; }
            set { _ItemGuid = value; }
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

        string _BrandName;
        public string BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        string _Unit;
        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        string _BatchGuid;
        public string Batchguid
        {
            get { return _BatchGuid; }
            set { _BatchGuid = value; }
        }

        string _BatchName;
        public string BatchName
        {
            get { return _BatchName; }
            set { _BatchName = value; }
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
            command.CommandText = "Select * from tblProformaDetails where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblProformaDetails");
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
                    if (dTable.Rows[0]["ProformaGuid"].Equals(DBNull.Value))
                        _ProformaGuid = string.Empty;
                    else
                        _ProformaGuid = (string)dTable.Rows[0]["ProformaGuid"];
                    if (dTable.Rows[0]["ItemGuid"].Equals(DBNull.Value))
                        _ItemGuid = string.Empty;
                    else
                        _ItemGuid = (string)dTable.Rows[0]["ItemGuid"];
                    if (dTable.Rows[0]["UnitPrice"].Equals(DBNull.Value))
                        _UnitPrice = decimal.Zero;
                    else
                        _UnitPrice = (decimal)dTable.Rows[0]["UnitPrice"];
                    if (dTable.Rows[0]["Quantity"].Equals(DBNull.Value))
                        _Quantity = decimal.Zero;
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
                throw new Exception("CProformaDetails::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblProformaDetails";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblProformaDetails");
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
                throw new Exception("CProformaDetails::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblProformaDetails" +
                                   " (ProformaGuid, " +
                                   " ItemGuid, " +
                                   " UnitPrice, " +
                                   " Quantity,UserId,ComputerName,EventSource)" +
                                   " Values (@ProformaGuid, " +
                                   " @ItemGuid, " +
                                   " @UnitPrice, " +
                                   " @Quantity,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblProformaDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProformaGuid", _ProformaGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
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
                throw new Exception("CProformaDetails::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblProformaDetails" +
                                   " Set ProformaGuid = @ProformaGuid, " +
                                   " ItemGuid = @ItemGuid, " +
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
                command.Parameters.Add(new SqlParameter("@ProformaGuid", _ProformaGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
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
                throw new Exception("CProformaDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblProformaDetails Where Id = @Id ";
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
                throw new Exception("CProformaDetails::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblProformaDetails] WHERE " +
                                       " ProformaGuid = @ProformaGuid " +
                                       " AND ItemGuid = @ItemGuid ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblProformaDetails] WHERE " +
                                       " ProformaGuid = @ProformaGuid " +
                                       " AND ItemGuid = @ItemGuid " +                                  
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProformaGuid", _ProformaGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@UnitPrice", _UnitPrice));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
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
                throw new Exception("CProformaDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
                
        public List<CProformaDetails> GetList()
        {
            List<CProformaDetails> RecordsList = new List<CProformaDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblProformaDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProformaDetails objCProformaDetails = new CProformaDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProformaDetails.Id = 0;
                    else
                        objCProformaDetails.Id = (int)dr["Id"];
                    if (dr["ProformaGuid"].Equals(DBNull.Value))
                        objCProformaDetails.Proformaguid = string.Empty;
                    else
                        objCProformaDetails.Proformaguid = (string)dr["ProformaGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCProformaDetails.Itemguid = string.Empty;
                    else
                        objCProformaDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        _UnitPrice = decimal.Zero;
                    else
                        objCProformaDetails.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        _Quantity = decimal.Zero;
                    else
                        objCProformaDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProformaDetails.Tablerowguid = string.Empty;
                    else
                        objCProformaDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProformaDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformaDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProformaDetails> GetList(string Proformaguid)
        {
            List<CProformaDetails> RecordsList = new List<CProformaDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL ="";
            strSQL = strSQL + " Select tblProformaDetails.*, ItemName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name, DosageForm=tblDosageForms.name, DosageFormGuid,(tblUnitOfMeasurements.name + ' ' + tblItems.Measurement ) Unit ";
            strSQL = strSQL + " from tblProformaDetails join tblItems on (tblProformaDetails.ItemGuid = tblItems.TableRowGuid) ";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " join tblUnitOfMeasurements on (tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid) where ProformaGuid = '" + Proformaguid + "' ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProformaDetails objCProformaDetails = new CProformaDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProformaDetails.Id = 0;
                    else
                        objCProformaDetails.Id = (int)dr["Id"];
                    if (dr["ProformaGuid"].Equals(DBNull.Value))
                        objCProformaDetails.Proformaguid = string.Empty;
                    else
                        objCProformaDetails.Proformaguid = (string)dr["ProformaGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCProformaDetails.Itemguid = string.Empty;
                    else
                        objCProformaDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        _UnitPrice = decimal.Zero;
                    else
                        objCProformaDetails.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        _Quantity = decimal.Zero;
                    else
                        objCProformaDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["ItemName"].Equals(DBNull.Value))
                        _BrandName = string.Empty;
                    else
                        objCProformaDetails.BrandName = (string)dr["ItemName"];
                    if (dr["DosageForm"].Equals(DBNull.Value))
                        _BrandName = _BrandName + string.Empty;
                    else
                        objCProformaDetails.BrandName = objCProformaDetails.BrandName + " " + (string)dr["DosageForm"];
                    if (dr["Unit"].Equals(DBNull.Value))
                        _BrandName = string.Empty;
                    else
                        objCProformaDetails.Unit = (string)dr["Unit"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProformaDetails.Tablerowguid = string.Empty;
                    else
                        objCProformaDetails.Tablerowguid = (string)dr["TableRowGuid"];
                     

                    RecordsList.Add(objCProformaDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformaDetails::GetList::Error! " + ex.Message, ex);
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
            command.CommandText = " Select * from tblProformaDetails where ProformaGuid =@ProformaGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProformaGuid", _ProformaGuid));
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformaDetails::CheckHasChildren::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProformaDetails> GetListItems(string strCriteria)
        {
            List<CProformaDetails> RecordsList = new List<CProformaDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL ="";
            strSQL = strSQL + " Select tblItems.Id, tblItems.TableRowGuid as ItemGuid, ItemName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name, DosageForm=tblDosageForms.name, DosageFormGuid, (tblUnitOfMeasurements.name + ' ' + tblItems.Measurement ) Unit from tblItems ";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " join tblUnitOfMeasurements on (tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid) where 1=1 " + strCriteria;
            strSQL = strSQL + " Order by ItemName ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProformaDetails objCProformaDetails = new CProformaDetails();

                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCProformaDetails.Itemguid = string.Empty;
                    else
                        objCProformaDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["ItemName"].Equals(DBNull.Value))
                        _BrandName = string.Empty;
                    else
                         objCProformaDetails.BrandName = (string)dr["ItemName"];
                    if (dr["DosageForm"].Equals(DBNull.Value))
                        _BrandName = _BrandName + string.Empty;
                    else
                        objCProformaDetails.BrandName = objCProformaDetails.BrandName;
                     if (dr["Unit"].Equals(DBNull.Value))
                         _Unit = string.Empty;
                     else
                         objCProformaDetails.Unit = (string)dr["Unit"];

                    RecordsList.Add(objCProformaDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProformaDetails::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblProformaDetails] WHERE Id = @Id";
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
                throw new Exception("CProformaDetails::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblProformaDetails] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CProformaDetails::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
