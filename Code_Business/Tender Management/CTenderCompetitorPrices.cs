//
// ...
// Wizard generated code
// Date: 4/13/2010 11:41:02 AM
// Class: CTenderCompetitorPrices
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
    class CTenderCompetitorPrices
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CTenderCompetitorPrices()
        {
            _ConnectionString = ConnectionString;
        }
        public CTenderCompetitorPrices(int Id, string Tendercompetitorguid, string Itemguid, decimal Unitprice)
        {
            _Id = Id;
            _TenderCompetitorGuid = Tendercompetitorguid;
            _ItemGuid = Itemguid;
            _UnitPrice = Unitprice;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _TenderCompetitorGuid;
        public string Tendercompetitorguid
        {
            get { return _TenderCompetitorGuid; }
            set { _TenderCompetitorGuid = value; }
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
            command.CommandText = "Select * from tblTenderCompetitorPrices where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderCompetitorPrices");
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
                    if (dTable.Rows[0]["TenderCompetitorGuid"].Equals(DBNull.Value))
                        _TenderCompetitorGuid = string.Empty;
                    else
                        _TenderCompetitorGuid = (string)dTable.Rows[0]["TenderCompetitorGuid"];
                    if (dTable.Rows[0]["ItemGuid"].Equals(DBNull.Value))
                        _ItemGuid = string.Empty;
                    else
                        _ItemGuid = (string)dTable.Rows[0]["ItemGuid"];
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
                throw new Exception("CTenderCompetitorPrices::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblTenderCompetitorPrices";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderCompetitorPrices");
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
                throw new Exception("CTenderCompetitorPrices::GetRecords::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Tendercompetitorguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderCompetitorPrices where TenderCompetitorGuid=@TenderCompetitorGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenderCompetitorPrices");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", Tendercompetitorguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitorPrices::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblTenderCompetitorPrices" +
                                   " (TenderCompetitorGuid, " +
                                   " ItemGuid, " +
                                   " UnitPrice)" +
                                   " Values (@TenderCompetitorGuid, " +
                                   " @ItemGuid, " +
                                   " @UnitPrice)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TenderCompetitorGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", _TenderCompetitorGuid));
                if (_ItemGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ItemGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
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
                throw new Exception("CTenderCompetitorPrices::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblTenderCompetitorPrices" +
                                   " Set TenderCompetitorGuid = @TenderCompetitorGuid, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " UnitPrice = @UnitPrice" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_TenderCompetitorGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", _TenderCompetitorGuid));
                if (_ItemGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ItemGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
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
                throw new Exception("CTenderCompetitorPrices::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblTenderCompetitorPrices Where Id = @Id ";
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
                throw new Exception("CTenderCompetitorPrices::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitorPrices] WHERE " +
                                       " TenderCompetitorGuid = @TenderCompetitorGuid " +
                                       " AND ItemGuid = @ItemGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitorPrices] WHERE " +
                                       " TenderCompetitorGuid = @TenderCompetitorGuid " +
                                       " AND ItemGuid = @ItemGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", _TenderCompetitorGuid));
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
                throw new Exception("CTenderCompetitorPrices::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Tendercompetitorguid, string Itemguid, decimal Unitprice)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblTenderCompetitorPrices" +
                                   " (TenderCompetitorGuid, " +
                                   " ItemGuid, " +
                                   " UnitPrice)" +
                                   " Values (@TenderCompetitorGuid, " +
                                   " @ItemGuid, " +
                                   " @UnitPrice)" +
                                   " Select @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", Tendercompetitorguid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
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
                throw new Exception("CTenderCompetitorPrices::Insert::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Tendercompetitorguid, string Itemguid, decimal Unitprice)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblTenderCompetitorPrices" +
                                   " Set TenderCompetitorGuid = @TenderCompetitorGuid, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " UnitPrice = @UnitPrice" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", Tendercompetitorguid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                command.Parameters.Add(new SqlParameter("@UnitPrice", Unitprice));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitorPrices::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblTenderCompetitorPrices Where Id = @Id ";
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
                throw new Exception("CTenderCompetitorPrices::Delete::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, string Tendercompetitorguid, string Itemguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitorPrices] WHERE " +
                                       " TenderCompetitorGuid = @TenderCompetitorGuid " +
                                       " AND ItemGuid = @ItemGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitorPrices] WHERE " +
                                       " TenderCompetitorGuid = @TenderCompetitorGuid " +
                                       " AND ItemGuid = @ItemGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", Tendercompetitorguid));
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
                throw new Exception("CTenderCompetitorPrices::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CTenderCompetitorPrices> GetList()
        {
            List<CTenderCompetitorPrices> RecordsList = new List<CTenderCompetitorPrices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderCompetitorPrices";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenderCompetitorPrices objCTenderCompetitorPrices = new CTenderCompetitorPrices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Id = 0;
                    else
                        objCTenderCompetitorPrices.Id = (int)dr["Id"];
                    if (dr["TenderCompetitorGuid"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Tendercompetitorguid = string.Empty;
                    else
                        objCTenderCompetitorPrices.Tendercompetitorguid = (string)dr["TenderCompetitorGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Itemguid = string.Empty;
                    else
                        objCTenderCompetitorPrices.Itemguid = (string)dr["ItemGuid"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Unitprice = 0;
                    else
                        objCTenderCompetitorPrices.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Tablerowguid = string.Empty;
                    else
                        objCTenderCompetitorPrices.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenderCompetitorPrices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitorPrices::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CTenderCompetitorPrices> GetList(string Tendercompetitorguid)
        {
            List<CTenderCompetitorPrices> RecordsList = new List<CTenderCompetitorPrices>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenderCompetitorPrices where TenderCompetitorGuid=@TenderCompetitorGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@TenderCompetitorGuid", Tendercompetitorguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenderCompetitorPrices objCTenderCompetitorPrices = new CTenderCompetitorPrices();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Id = 0;
                    else
                        objCTenderCompetitorPrices.Id = (int)dr["Id"];
                    if (dr["TenderCompetitorGuid"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Tendercompetitorguid = string.Empty;
                    else
                        objCTenderCompetitorPrices.Tendercompetitorguid = (string)dr["TenderCompetitorGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Itemguid = string.Empty;
                    else
                        objCTenderCompetitorPrices.Itemguid = (string)dr["ItemGuid"];
                    if (dr["UnitPrice"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Unitprice = 0;
                    else
                        objCTenderCompetitorPrices.Unitprice = (decimal)dr["UnitPrice"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenderCompetitorPrices.Tablerowguid = string.Empty;
                    else
                        objCTenderCompetitorPrices.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenderCompetitorPrices);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenderCompetitorPrices::GetList::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblTenderCompetitorPrices] WHERE Id = @Id";
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
                throw new Exception("CTenderCompetitorPrices::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblTenderCompetitorPrices] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CTenderCompetitorPrices::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
