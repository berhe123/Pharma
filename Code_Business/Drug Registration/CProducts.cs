//
// ...
// Wizard generated code
// Date: 8/18/2009 2:57:20 PM
// Class: CProducts
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
    class CProducts
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CProducts()
        {
            _ConnectionString = ConnectionString;
        }
        public CProducts(int Id, string Manufacturerguid, string Brandname, string Genericname, int Status)
        {
            _Id = Id;
            _ManufacturerGuid = Manufacturerguid;
            _BrandName = Brandname;
            _GenericName = Genericname;
            _Status = Status;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _ManufacturerGuid;
        public string Manufacturerguid
        {
            get { return _ManufacturerGuid; }
            set { _ManufacturerGuid = value; }
        }

        string _BrandName;
        public string Brandname
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        string _GenericName;
        public string Genericname
        {
            get { return _GenericName; }
            set { _GenericName = value; }
        }

        int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
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
            command.CommandText = "Select * from tblProducts where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblProducts");
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
                    if (dTable.Rows[0]["ManufacturerGuid"].Equals(DBNull.Value))
                        _ManufacturerGuid = string.Empty;
                    else
                        _ManufacturerGuid = (string)dTable.Rows[0]["ManufacturerGuid"];
                    if (dTable.Rows[0]["BrandName"].Equals(DBNull.Value))
                        _BrandName = string.Empty;
                    else
                        _BrandName = (string)dTable.Rows[0]["BrandName"];
                    if (dTable.Rows[0]["GenericName"].Equals(DBNull.Value))
                        _GenericName = string.Empty;
                    else
                        _GenericName = (string)dTable.Rows[0]["GenericName"];
                    if (dTable.Rows[0]["Status"].Equals(DBNull.Value))
                        _Status = 0;
                    else
                        _Status = (int)dTable.Rows[0]["Status"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CProducts::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblProducts";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblProducts");
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
                throw new Exception("CProducts::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblProducts" +
                                   " (ManufacturerGuid, " +
                                   " BrandName, " +
                                   " GenericName, " +
                                   " Status,UserId,ComputerName,EventSource)" +
                                   " Values (@ManufacturerGuid, " +
                                   " @BrandName, " +
                                   " @GenericName, " +
                                   " @Status,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblProducts ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", _ManufacturerGuid));
                command.Parameters.Add(new SqlParameter("@BrandName", _BrandName));
                command.Parameters.Add(new SqlParameter("@GenericName", _GenericName));
                command.Parameters.Add(new SqlParameter("@Status", _Status));

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
                throw new Exception("CProducts::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblProducts" +
                                   " Set ManufacturerGuid = @ManufacturerGuid, " +
                                   " BrandName = @BrandName, " +
                                   " GenericName = @GenericName, " +
                                   " Status = @Status," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", _ManufacturerGuid));
                command.Parameters.Add(new SqlParameter("@BrandName", _BrandName));
                command.Parameters.Add(new SqlParameter("@GenericName", _GenericName));
                command.Parameters.Add(new SqlParameter("@Status", _Status));

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
                throw new Exception("CProducts::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblProducts Where Id = @Id ";
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
                throw new Exception("CProducts::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblProducts] WHERE " +
                                       " ManufacturerGuid = @ManufacturerGuid " +
                                       " AND BrandName = @BrandName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblProducts] WHERE " +
                                       " ManufacturerGuid = @ManufacturerGuid " +
                                       " AND BrandName = @BrandName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", _ManufacturerGuid));
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
                throw new Exception("CProducts::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Manufacturerguid, string Brandname, string Genericname, int Status)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblProducts" +
                                   " (ManufacturerGuid, " +
                                   " BrandName, " +
                                   " GenericName, " +
                                   " Status)" +
                                   " Values (@ManufacturerGuid, " +
                                   " @BrandName, " +
                                   " @GenericName, " +
                                   " @Status)" +
                                   " Select @Id=Max(id) from tblProducts ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                command.Parameters.Add(new SqlParameter("@BrandName", Brandname));
                command.Parameters.Add(new SqlParameter("@GenericName", Genericname));
                command.Parameters.Add(new SqlParameter("@Status", Status));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CProducts::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Manufacturerguid, string Brandname, string Genericname, int Status)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblProducts" +
                                   " Set ManufacturerGuid = @ManufacturerGuid, " +
                                   " BrandName = @BrandName, " +
                                   " GenericName = @GenericName, " +
                                   " Status = @Status" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                command.Parameters.Add(new SqlParameter("@BrandName", Brandname));
                command.Parameters.Add(new SqlParameter("@GenericName", Genericname));
                command.Parameters.Add(new SqlParameter("@Status", Status));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CProducts::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblProducts Where Id = @Id ";
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
                throw new Exception("CProducts::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Manufacturerguid, string Brandname)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblProducts] WHERE " +
                                       " ManufacturerGuid = @ManufacturerGuid " +
                                       " AND BrandName = @BrandName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblProducts] WHERE " +
                                       " ManufacturerGuid = @ManufacturerGuid " +
                                       " AND BrandName = @BrandName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
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
                throw new Exception("CProducts::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CProducts> GetList()
        {
            List<CProducts> RecordsList = new List<CProducts>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblProducts";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProducts objCProducts = new CProducts();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProducts.Id = 0;
                    else
                        objCProducts.Id = (int)dr["Id"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCProducts.Manufacturerguid = string.Empty;
                    else
                        objCProducts.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCProducts.Brandname = string.Empty;
                    else
                        objCProducts.Brandname = (string)dr["BrandName"];
                    if (dr["GenericName"].Equals(DBNull.Value))
                        objCProducts.Genericname = string.Empty;
                    else
                        objCProducts.Genericname = (string)dr["GenericName"];
                    if (dr["Status"].Equals(DBNull.Value))
                        objCProducts.Status = 0;
                    else
                        objCProducts.Status = (int)dr["Status"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProducts.Tablerowguid = string.Empty;
                    else
                        objCProducts.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProducts);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProducts::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProducts> GetList(string Manufacturerguid, string BrandName, string GenericName)
        {
            List<CProducts> RecordsList = new List<CProducts>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblProducts " +
                                    " Where BrandName Like @BrandName " +
                                    " And GenericName Like @GenericName ";

            command.Parameters.Add(new SqlParameter("@BrandName", BrandName + "%"));
            command.Parameters.Add(new SqlParameter("@GenericName", GenericName + "%"));

            if (Manufacturerguid != string.Empty)
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                command.CommandText += " AND ManufacturerGuid = @ManufacturerGuid ";
            }

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProducts objCProducts = new CProducts();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProducts.Id = 0;
                    else
                        objCProducts.Id = (int)dr["Id"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCProducts.Manufacturerguid = string.Empty;
                    else
                        objCProducts.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCProducts.Brandname = string.Empty;
                    else
                        objCProducts.Brandname = (string)dr["BrandName"];
                    if (dr["GenericName"].Equals(DBNull.Value))
                        objCProducts.Genericname = string.Empty;
                    else
                        objCProducts.Genericname = (string)dr["GenericName"];
                    if (dr["Status"].Equals(DBNull.Value))
                        objCProducts.Status = 0;
                    else
                        objCProducts.Status = (int)dr["Status"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProducts.Tablerowguid = string.Empty;
                    else
                        objCProducts.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProducts);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProducts::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblProducts] WHERE Id = @Id";
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
                throw new Exception("CProducts::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblProducts] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CProducts::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
