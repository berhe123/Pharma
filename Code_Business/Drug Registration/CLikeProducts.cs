//
// ...
// Wizard generated code
// Date: 9/14/2009 3:05:40 PM
// Class: CLikeProducts
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
    class CLikeProducts

    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CLikeProducts()
        {
            _ConnectionString = ConnectionString;
        }
        public CLikeProducts(int Id, string Productguid, string Manufacturername, string Brandname, decimal Averageprice)
        {
            _Id = Id;
            _ProductGuid = Productguid;
            _ManufacturerName = Manufacturername;
            _BrandName = Brandname;
            _AveragePrice = Averageprice;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _ProductGuid;
        public string Productguid
        {
            get { return _ProductGuid; }
            set { _ProductGuid = value; }
        }

        string _ManufacturerName;
        public string Manufacturername
        {
            get { return _ManufacturerName; }
            set { _ManufacturerName = value; }
        }

        string _BrandName;
        public string Brandname
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        decimal _AveragePrice;
        public decimal Averageprice
        {
            get { return _AveragePrice; }
            set { _AveragePrice = value; }
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
            command.CommandText = "Select * from tblLikeProducts where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLikeProducts");
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
                    if (dTable.Rows[0]["ProductGuid"].Equals(DBNull.Value))
                        _ProductGuid = string.Empty;
                    else
                        _ProductGuid = (string)dTable.Rows[0]["ProductGuid"];
                    if (dTable.Rows[0]["ManufacturerName"].Equals(DBNull.Value))
                        _ManufacturerName = string.Empty;
                    else
                        _ManufacturerName = (string)dTable.Rows[0]["ManufacturerName"];
                    if (dTable.Rows[0]["BrandName"].Equals(DBNull.Value))
                        _BrandName = string.Empty;
                    else
                        _BrandName = (string)dTable.Rows[0]["BrandName"];
                    if (dTable.Rows[0]["AveragePrice"].Equals(DBNull.Value))
                        _AveragePrice = 0;
                    else
                        _AveragePrice = (decimal)dTable.Rows[0]["AveragePrice"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CLikeProducts::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblLikeProducts";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLikeProducts");
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
                throw new Exception("CLikeProducts::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Productguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLikeProducts where ProductGuid=@ProductGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLikeProducts");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CLikeProducts::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblLikeProducts" +
                                   " (ProductGuid, " +
                                   " ManufacturerName, " +
                                   " BrandName, " +
                                   " AveragePrice,UserId,ComputerName,EventSource)" +
                                   " Values (@ProductGuid, " +
                                   " @ManufacturerName, " +
                                   " @BrandName, " +
                                   " @AveragePrice,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblLikeProducts ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                command.Parameters.Add(new SqlParameter("@ManufacturerName", _ManufacturerName));
                command.Parameters.Add(new SqlParameter("@BrandName", _BrandName));
                command.Parameters.Add(new SqlParameter("@AveragePrice", _AveragePrice));

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
                throw new Exception("CLikeProducts::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblLikeProducts" +
                                   " Set ProductGuid = @ProductGuid, " +
                                   " ManufacturerName = @ManufacturerName, " +
                                   " BrandName = @BrandName, " +
                                   " AveragePrice = @AveragePrice," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                command.Parameters.Add(new SqlParameter("@ManufacturerName", _ManufacturerName));
                command.Parameters.Add(new SqlParameter("@BrandName", _BrandName));
                command.Parameters.Add(new SqlParameter("@AveragePrice", _AveragePrice));

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
                throw new Exception("CLikeProducts::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblLikeProducts Where Id = @Id ";
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
                throw new Exception("CLikeProducts::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblLikeProducts] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND ManufacturerName = @ManufacturerName " +
                                       " AND BrandName = @BrandName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblLikeProducts] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND ManufacturerName = @ManufacturerName " +
                                       " AND BrandName = @BrandName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                command.Parameters.Add(new SqlParameter("@ManufacturerName", _ManufacturerName));
                command.Parameters.Add(new SqlParameter("@BrandName", _BrandName));
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
                throw new Exception("CLikeProducts::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Productguid, string Manufacturername, string Brandname, decimal Averageprice)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblLikeProducts" +
                                   " (ProductGuid, " +
                                   " ManufacturerName, " +
                                   " BrandName, " +
                                   " AveragePrice)" +
                                   " Values (@ProductGuid, " +
                                   " @ManufacturerName, " +
                                   " @BrandName, " +
                                   " @AveragePrice)" +
                                   " Select @Id=Max(id) from tblLikeProducts ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                command.Parameters.Add(new SqlParameter("@ManufacturerName", Manufacturername));
                command.Parameters.Add(new SqlParameter("@BrandName", Brandname));
                command.Parameters.Add(new SqlParameter("@AveragePrice", Averageprice));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CLikeProducts::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Productguid, string Manufacturername, string Brandname, decimal Averageprice)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblLikeProducts" +
                                   " Set ProductGuid = @ProductGuid, " +
                                   " ManufacturerName = @ManufacturerName, " +
                                   " BrandName = @BrandName, " +
                                   " AveragePrice = @AveragePrice" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                command.Parameters.Add(new SqlParameter("@ManufacturerName", Manufacturername));
                command.Parameters.Add(new SqlParameter("@BrandName", Brandname));
                command.Parameters.Add(new SqlParameter("@AveragePrice", Averageprice));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CLikeProducts::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblLikeProducts Where Id = @Id ";
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
                throw new Exception("CLikeProducts::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Productguid, string Manufacturername, string Brandname)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblLikeProducts] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND ManufacturerName = @ManufacturerName " +
                                       " AND BrandName = @BrandName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblLikeProducts] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND ManufacturerName = @ManufacturerName " +
                                       " AND BrandName = @BrandName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                command.Parameters.Add(new SqlParameter("@ManufacturerName", Manufacturername));
                command.Parameters.Add(new SqlParameter("@BrandName", Brandname));
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
                throw new Exception("CLikeProducts::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CLikeProducts> GetList()
        {
            List<CLikeProducts> RecordsList = new List<CLikeProducts>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLikeProducts";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLikeProducts objCLikeProducts = new CLikeProducts();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLikeProducts.Id = 0;
                    else
                        objCLikeProducts.Id = (int)dr["Id"];
                    if (dr["ProductGuid"].Equals(DBNull.Value))
                        objCLikeProducts.Productguid = string.Empty;
                    else
                        objCLikeProducts.Productguid = (string)dr["ProductGuid"];
                    if (dr["ManufacturerName"].Equals(DBNull.Value))
                        objCLikeProducts.Manufacturername = string.Empty;
                    else
                        objCLikeProducts.Manufacturername = (string)dr["ManufacturerName"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCLikeProducts.Brandname = string.Empty;
                    else
                        objCLikeProducts.Brandname = (string)dr["BrandName"];
                    if (dr["AveragePrice"].Equals(DBNull.Value))
                        objCLikeProducts.Averageprice = 0;
                    else
                        objCLikeProducts.Averageprice = (decimal)dr["AveragePrice"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLikeProducts.Tablerowguid = string.Empty;
                    else
                        objCLikeProducts.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLikeProducts);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLikeProducts::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CLikeProducts> GetList(string Productguid)
        {
            List<CLikeProducts> RecordsList = new List<CLikeProducts>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLikeProducts where ProductGuid=@ProductGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLikeProducts objCLikeProducts = new CLikeProducts();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLikeProducts.Id = 0;
                    else
                        objCLikeProducts.Id = (int)dr["Id"];
                    if (dr["ProductGuid"].Equals(DBNull.Value))
                        objCLikeProducts.Productguid = string.Empty;
                    else
                        objCLikeProducts.Productguid = (string)dr["ProductGuid"];
                    if (dr["ManufacturerName"].Equals(DBNull.Value))
                        objCLikeProducts.Manufacturername = string.Empty;
                    else
                        objCLikeProducts.Manufacturername = (string)dr["ManufacturerName"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCLikeProducts.Brandname = string.Empty;
                    else
                        objCLikeProducts.Brandname = (string)dr["BrandName"];
                    if (dr["AveragePrice"].Equals(DBNull.Value))
                        objCLikeProducts.Averageprice = 0;
                    else
                        objCLikeProducts.Averageprice = (decimal)dr["AveragePrice"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLikeProducts.Tablerowguid = string.Empty;
                    else
                        objCLikeProducts.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLikeProducts);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLikeProducts::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblLikeProducts] WHERE Id = @Id";
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
                throw new Exception("CLikeProducts::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblLikeProducts] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CLikeProducts::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
