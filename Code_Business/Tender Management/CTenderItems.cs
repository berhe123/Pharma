//
// ...
// Wizard generated code
// Date: 4/13/2010 11:42:13 AM
// Class: CTenderItems
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
    class CTenderItems
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CTenderItems()
        {
            _ConnectionString = ConnectionString;
        }
        public CTenderItems(int Id, string Tenderguid, string Itemguid, decimal Quantity, decimal Unitprice)
        {
            _Id = Id;
            _TenderGuid = Tenderguid;
            _ItemGuid = Itemguid;
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

        string _TenderGuid;
        public string Tenderguid
        {
            get { return _TenderGuid; }
            set { _TenderGuid = value; }
        }

        string _ItemGuid;
        public string Itemguid
        {
            get { return _ItemGuid; }
            set { _ItemGuid = value; }
        }

        decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        decimal _UnitPrice;
        public decimal Unitprice
        {
            get { return _UnitPrice; }
            set { _UnitPrice = value; }
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
            command.CommandText = "Select * from tblTenderItems where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderItems");
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
                    if (dTable.Rows[0]["TenderGuid"].Equals(DBNull.Value))
                        _TenderGuid = string.Empty;
                    else
                        _TenderGuid = (string)dTable.Rows[0]["TenderGuid"];
                    if (dTable.Rows[0]["ItemGuid"].Equals(DBNull.Value))
                        _ItemGuid = string.Empty;
                    else
                        _ItemGuid = (string)dTable.Rows[0]["ItemGuid"];
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
                throw new Exception("CTenderItems::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblTenderItems";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderItems");
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
                throw new Exception("CTenderItems::GetRecords::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Tenderguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderItems where TenderGuid=@TenderGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderItems");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderItems::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblTenderItems" +
                                   " (TenderGuid, " +
                                   " ItemGuid, " +
                                   " Quantity, " +
                                   " UnitPrice)" +
                                   " Values (@TenderGuid, " +
                                   " @ItemGuid, " +
                                   " @Quantity, " +
                                   " @UnitPrice)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TenderGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TenderGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TenderGuid", _TenderGuid));
                if (_ItemGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ItemGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                if (_Quantity == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@Quantity", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                if (_UnitPrice == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@UnitPrice", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@UnitPrice", _UnitPrice));

                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderItems::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblTenderItems" +
                                   " Set TenderGuid = @TenderGuid, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " Quantity = @Quantity, " +
                                   " UnitPrice = @UnitPrice" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TenderGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TenderGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TenderGuid", _TenderGuid));
                if (_ItemGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ItemGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                if (_Quantity == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@Quantity", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                if (_UnitPrice == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@UnitPrice", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@UnitPrice", _UnitPrice));
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderItems::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblTenderItems Where Id = @Id ";
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
                throw new Exception("CTenderItems::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderItems] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND ItemGuid = @ItemGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderItems] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND ItemGuid = @ItemGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", _TenderGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
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
                throw new Exception("CTenderItems::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Tenderguid, string Itemguid, decimal Quantity, decimal Unitprice)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblTenderItems" +
                                   " (TenderGuid, " +
                                   " ItemGuid, " +
                                   " Quantity, " +
                                   " UnitPrice)" +
                                   " Values (@TenderGuid, " +
                                   " @ItemGuid, " +
                                   " @Quantity, " +
                                   " @UnitPrice)" +
                                   " Select @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                command.Parameters.Add(new SqlParameter("@Quantity", Quantity));
                command.Parameters.Add(new SqlParameter("@UnitPrice", Unitprice));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderItems::Insert::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Tenderguid, string Itemguid, decimal Quantity, decimal Unitprice)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblTenderItems" +
                                   " Set TenderGuid = @TenderGuid, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " Quantity = @Quantity, " +
                                   " UnitPrice = @UnitPrice" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                command.Parameters.Add(new SqlParameter("@Quantity", Quantity));
                command.Parameters.Add(new SqlParameter("@UnitPrice", Unitprice));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderItems::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblTenderItems Where Id = @Id ";
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
                throw new Exception("CTenderItems::Delete::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, string Tenderguid, string Itemguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderItems] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND ItemGuid = @ItemGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderItems] WHERE " +
                                       " TenderGuid = @TenderGuid " +
                                       " AND ItemGuid = @ItemGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
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
                throw new Exception("CTenderItems::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CTenderItems> GetList()
        {
            List<CTenderItems> RecordsList = new List<CTenderItems>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderItems";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenderItems objCTenderItems = new CTenderItems();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenderItems.Id = 0;
                    else
                        objCTenderItems.Id = (int)dr["Id"];
                    if (dr["TenderGuid"].Equals(DBNull.Value))
                        objCTenderItems.Tenderguid = string.Empty;
                    else
                        objCTenderItems.Tenderguid = (string)dr["TenderGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCTenderItems.Itemguid = string.Empty;
                    else
                        objCTenderItems.Itemguid = (string)dr["ItemGuid"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCTenderItems.Quantity = 0;
                    else
                        objCTenderItems.Quantity = (decimal)dr["Quantity"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCTenderItems.Unitprice = 0;
                    else
                        objCTenderItems.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenderItems.Tablerowguid = string.Empty;
                    else
                        objCTenderItems.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenderItems);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderItems::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CTenderItems> GetList(string Tenderguid)
        {
            List<CTenderItems> RecordsList = new List<CTenderItems>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderItems where TenderGuid=@TenderGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderGuid", Tenderguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenderItems objCTenderItems = new CTenderItems();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenderItems.Id = 0;
                    else
                        objCTenderItems.Id = (int)dr["Id"];
                    if (dr["TenderGuid"].Equals(DBNull.Value))
                        objCTenderItems.Tenderguid = string.Empty;
                    else
                        objCTenderItems.Tenderguid = (string)dr["TenderGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCTenderItems.Itemguid = string.Empty;
                    else
                        objCTenderItems.Itemguid = (string)dr["ItemGuid"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCTenderItems.Quantity = 0;
                    else
                        objCTenderItems.Quantity = (decimal)dr["Quantity"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCTenderItems.Unitprice = 0;
                    else
                        objCTenderItems.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenderItems.Tablerowguid = string.Empty;
                    else
                        objCTenderItems.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenderItems);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderItems::GetList::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblTenderItems] WHERE Id = @Id";
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
                throw new Exception("CTenderItems::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblTenderItems] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CTenderItems::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
