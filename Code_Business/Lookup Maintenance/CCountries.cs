//
// ...
// Wizard generated code
// Date: 7/29/2009 12:24:03 PM
// Class: CCountries
// ...
//

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace Pharma
{
    class CCountries
    {
        public static List<CCountries> CountriesCollection = null;

        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CCountries()
        {
            _ConnectionString = ConnectionString;
        }
        public CCountries(int Id, string Code, string Shortname, string Name)
        {
            _Id = Id;
            _Code = Code;
            _ShortName = Shortname;
            _Name = Name;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _Code;
        public string Code
        {
            get { return _Code; }
            set { _Code = value; }
        }

        string _ShortName;
        public string Shortname
        {
            get { return _ShortName; }
            set { _ShortName = value; }
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
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
            command.CommandText = "Select * from tblCountries where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblCountries");
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
                    if (dTable.Rows[0]["Code"].Equals(DBNull.Value))
                        _Code = string.Empty;
                    else
                        _Code = (string)dTable.Rows[0]["Code"];
                    if (dTable.Rows[0]["ShortName"].Equals(DBNull.Value))
                        _ShortName = string.Empty;
                    else
                        _ShortName = (string)dTable.Rows[0]["ShortName"];
                    if (dTable.Rows[0]["Name"].Equals(DBNull.Value))
                        _Name = string.Empty;
                    else
                        _Name = (string)dTable.Rows[0]["Name"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CCountries::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblCountries";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblCountries");
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
                throw new Exception("CCountries::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblCountries" +
                                   " (Code, " +
                                   " ShortName, " +
                                   " Name,UserId,ComputerName,EventSource)" +
                                   " Values (@Code, " +
                                   " @ShortName, " +
                                   " @Name,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblCountries ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Code", _Code));
                command.Parameters.Add(new SqlParameter("@ShortName", _ShortName));
                command.Parameters.Add(new SqlParameter("@Name", _Name));
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
                throw new Exception("CCountries::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblCountries" +
                                   " Set Code = @Code, " +
                                   " ShortName = @ShortName, " +
                                   " Name = @Name," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Code", _Code));
                command.Parameters.Add(new SqlParameter("@ShortName", _ShortName));
                command.Parameters.Add(new SqlParameter("@Name", _Name));
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
                throw new Exception("CCountries::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblCountries Where Id = @Id ";
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
                throw new Exception("CCountries::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblCountries] WHERE " +
                                       " Code = @Code " +
                                       " AND ShortName = @ShortName " +
                                       " AND Name = @Name";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblCountries] WHERE " +
                                       " Code = @Code " +
                                       " AND ShortName = @ShortName " +
                                       " AND Name = @Name " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Code", _Code));
                command.Parameters.Add(new SqlParameter("@ShortName", _ShortName));
                command.Parameters.Add(new SqlParameter("@Name", _Name));
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
                throw new Exception("CCountries::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Code, string Shortname, string Name)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblCountries" +
                                   " (Code, " +
                                   " ShortName, " +
                                   " Name)" +
                                   " Values (@Code, " +
                                   " @ShortName, " +
                                   " @Name)" +
                                   " Select @Id=Max(id) from tblCountries ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Code", Code));
                command.Parameters.Add(new SqlParameter("@ShortName", Shortname));
                command.Parameters.Add(new SqlParameter("@Name", Name));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCountries::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Code, string Shortname, string Name)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblCountries" +
                                   " Set Code = @Code, " +
                                   " ShortName = @ShortName, " +
                                   " Name = @Name" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Code", Code));
                command.Parameters.Add(new SqlParameter("@ShortName", Shortname));
                command.Parameters.Add(new SqlParameter("@Name", Name));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCountries::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblCountries Where Id = @Id ";
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
                throw new Exception("CCountries::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Code, string Shortname, string Name)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblCountries] WHERE " +
                                       " Code = @Code " +
                                       " AND ShortName = @ShortName " +
                                       " AND Name = @Name";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblCountries] WHERE " +
                                       " Code = @Code " +
                                       " AND ShortName = @ShortName " +
                                       " AND Name = @Name " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Code", Code));
                command.Parameters.Add(new SqlParameter("@ShortName", Shortname));
                command.Parameters.Add(new SqlParameter("@Name", Name));
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
                throw new Exception("CCountries::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CCountries> GetList()
        {
            List<CCountries> RecordsList = new List<CCountries>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblCountries";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CCountries objCCountries = new CCountries();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCCountries.Id = 0;
                    else
                        objCCountries.Id = (int)dr["Id"];
                    if (dr["Code"].Equals(DBNull.Value))
                        objCCountries.Code = string.Empty;
                    else
                        objCCountries.Code = (string)dr["Code"];
                    if (dr["ShortName"].Equals(DBNull.Value))
                        objCCountries.Shortname = string.Empty;
                    else
                        objCCountries.Shortname = (string)dr["ShortName"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCCountries.Name = string.Empty;
                    else
                        objCCountries.Name = (string)dr["Name"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCCountries.Tablerowguid = string.Empty;
                    else
                        objCCountries.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCCountries);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCountries::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public string GetCountryName(string Countryguid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT name FROM [dbo].[tblCountries] WHERE [TableRowGuid] = @CountryGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CountryGuid", Countryguid));
                connection.Open();
                return (string)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CCountries::GetCountryName::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        // Collection Utilities
        public static void LoadCountriesToCollection()
        {
            List<CCountries> RecordsList = new List<CCountries>();
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblCountries";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CCountries objCCountries = new CCountries();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCCountries.Id = 0;
                    else
                        objCCountries.Id = (int)dr["Id"];
                    if (dr["Code"].Equals(DBNull.Value))
                        objCCountries.Code = string.Empty;
                    else
                        objCCountries.Code = (string)dr["Code"];
                    if (dr["ShortName"].Equals(DBNull.Value))
                        objCCountries.Shortname = string.Empty;
                    else
                        objCCountries.Shortname = (string)dr["ShortName"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCCountries.Name = string.Empty;
                    else
                        objCCountries.Name = (string)dr["Name"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCCountries.Tablerowguid = string.Empty;
                    else
                        objCCountries.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCCountries);
                }

                CountriesCollection = RecordsList;
                //return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCountries::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public static string GetCountryNameFromCollection(string Countryguid)
        {
            string strName = string.Empty;
            try
            {
                ArrayList ar = new ArrayList(CountriesCollection);
                if (ar.Count < 0) return string.Empty;

                foreach (CCountries app in ar)
                {
                    if (Countryguid == app.Tablerowguid)
                    {
                        strName = app.Name;
                        break;
                    }
                }
                return strName;
            }
            catch (Exception ex)
            {
                throw new Exception("CCountries::GetCountryNameFromCollection::Error! " + ex.Message, ex);
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblCountries] WHERE Id = @Id";
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
                throw new Exception("CCountries::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblCountries] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CCountries::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
