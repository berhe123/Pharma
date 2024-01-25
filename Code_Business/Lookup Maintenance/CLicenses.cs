//
// ...
// Wizard generated code
// Date: 8/1/2009 3:32:33 PM
// Class: CLicenses
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
    class CLicenses
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CLicenses()
        {
            _ConnectionString = ConnectionString;
        }
        public CLicenses(int Id, string Customerguid, string Licensenumber, string Firstname, string Fathername, string Grandname, string Levelguid, DateTime Validfrom, DateTime Validto, int Isactive, DateTime Registrationdate)
        {
            _Id = Id;
            _CustomerGuid = Customerguid;
            _LicenseNumber = Licensenumber;
            _FirstName = Firstname;
            _FatherName = Fathername;
            _GrandName = Grandname;
            _LevelGuid = Levelguid;
            _ValidFrom = Validfrom;
            _ValidTo = Validto;
            _IsActive = Isactive;
            _RegistrationDate = Registrationdate;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _CustomerGuid;
        public string Customerguid
        {
            get { return _CustomerGuid; }
            set { _CustomerGuid = value; }
        }

        string _LicenseNumber;
        public string Licensenumber
        {
            get { return _LicenseNumber; }
            set { _LicenseNumber = value; }
        }

        string _FirstName;
        public string Firstname
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        string _FatherName;
        public string Fathername
        {
            get { return _FatherName; }
            set { _FatherName = value; }
        }

        string _GrandName;
        public string Grandname
        {
            get { return _GrandName; }
            set { _GrandName = value; }
        }

        string _LevelGuid;
        public string Levelguid
        {
            get { return _LevelGuid; }
            set { _LevelGuid = value; }
        }

        string _LevelName;
        public string LevelName
        {
            get { return _LevelName; }
            set { _LevelName = value; }
        }

        DateTime _ValidFrom;
        public DateTime Validfrom
        {
            get { return _ValidFrom; }
            set { _ValidFrom = value; }
        }

        DateTime _ValidTo;
        public DateTime Validto
        {
            get { return _ValidTo; }
            set { _ValidTo = value; }
        }

        int _IsActive;
        public int Isactive
        {
            get { return _IsActive; }
            set { _IsActive = value; }
        }

        DateTime _RegistrationDate;
        public DateTime Registrationdate
        {
            get { return _RegistrationDate; }
            set { _RegistrationDate = value; }
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
            command.CommandText = " Select tblLicenses.*, tblLevels.Name as LevelName ";
            command.CommandText += " From tblLicenses INNER JOIN tblLevels ";
            command.CommandText += " ON tblLicenses.LevelGuid = tblLevels.TableRowGuid ";
            command.CommandText += " Where tblLicenses.Id=@Id";

            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLicenses");
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
                    if (dTable.Rows[0]["CustomerGuid"].Equals(DBNull.Value))
                        _CustomerGuid = string.Empty;
                    else
                        _CustomerGuid = (string)dTable.Rows[0]["CustomerGuid"];
                    if (dTable.Rows[0]["LicenseNumber"].Equals(DBNull.Value))
                        _LicenseNumber = string.Empty;
                    else
                        _LicenseNumber = (string)dTable.Rows[0]["LicenseNumber"];
                    if (dTable.Rows[0]["FirstName"].Equals(DBNull.Value))
                        _FirstName = string.Empty;
                    else
                        _FirstName = (string)dTable.Rows[0]["FirstName"];
                    if (dTable.Rows[0]["FatherName"].Equals(DBNull.Value))
                        _FatherName = string.Empty;
                    else
                        _FatherName = (string)dTable.Rows[0]["FatherName"];
                    if (dTable.Rows[0]["GrandName"].Equals(DBNull.Value))
                        _GrandName = string.Empty;
                    else
                        _GrandName = (string)dTable.Rows[0]["GrandName"];
                    if (dTable.Rows[0]["LevelGuid"].Equals(DBNull.Value))
                        _LevelGuid = string.Empty;
                    else
                        _LevelGuid = (string)dTable.Rows[0]["LevelGuid"];
                    if (dTable.Rows[0]["LevelName"].Equals(DBNull.Value))
                        _LevelName = string.Empty;
                    else
                        _LevelName = (string)dTable.Rows[0]["LevelName"];
                    if (dTable.Rows[0]["ValidFrom"].Equals(DBNull.Value))
                        _ValidFrom = DateTime.MinValue;
                    else
                        _ValidFrom = (DateTime)dTable.Rows[0]["ValidFrom"];
                    if (dTable.Rows[0]["ValidTo"].Equals(DBNull.Value))
                        _ValidTo = DateTime.MinValue;
                    else
                        _ValidTo = (DateTime)dTable.Rows[0]["ValidTo"];
                    if (dTable.Rows[0]["IsActive"].Equals(DBNull.Value))
                        _IsActive = 0;
                    else
                        _IsActive = (int)dTable.Rows[0]["IsActive"];
                    if (dTable.Rows[0]["RegistrationDate"].Equals(DBNull.Value))
                        _RegistrationDate = DateTime.MinValue;
                    else
                        _RegistrationDate = (DateTime)dTable.Rows[0]["RegistrationDate"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CLicenses::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = " Select tblLicenses.*, tblLevels.Name as LevelName ";
            command.CommandText += " From tblLicenses INNER JOIN tblLevels ";
            command.CommandText += " ON tblLicenses.LevelGuid = tblLevels.TableRowGuid ";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLicenses");
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
                throw new Exception("CLicenses::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Customerguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = " Select tblLicenses.*, tblLevels.Name as LevelName ";
            command.CommandText += " From tblLicenses INNER JOIN tblLevels ";
            command.CommandText += " ON tblLicenses.LevelGuid = tblLevels.TableRowGuid ";
            command.CommandText += " Where tblLicenses.CustomerGuid=@CustomerGuid";

            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLicenses");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CLicenses::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblLicenses" +
                                   " (CustomerGuid, " +
                                   " LicenseNumber, " +
                                   " FirstName, " +
                                   " FatherName, " +
                                   " GrandName, " +
                                   " LevelGuid, " +
                                   " ValidFrom, " +
                                   " ValidTo, " +
                                   " IsActive, " +
                                   " RegistrationDate,UserId,ComputerName,EventSource)" +
                                   " Values (@CustomerGuid, " +
                                   " @LicenseNumber, " +
                                   " @FirstName, " +
                                   " @FatherName, " +
                                   " @GrandName, " +
                                   " @LevelGuid, " +
                                   " @ValidFrom, " +
                                   " @ValidTo, " +
                                   " @IsActive, " +
                                   " @RegistrationDate,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblLicenses ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@LicenseNumber", _LicenseNumber));
                command.Parameters.Add(new SqlParameter("@FirstName", _FirstName));
                command.Parameters.Add(new SqlParameter("@FatherName", _FatherName));
                command.Parameters.Add(new SqlParameter("@GrandName", _GrandName));
                command.Parameters.Add(new SqlParameter("@LevelGuid", _LevelGuid));
                command.Parameters.Add(new SqlParameter("@IsActive", _IsActive));
                if (_ValidFrom == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ValidFrom", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ValidFrom", _ValidFrom));
                if (_ValidTo == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ValidTo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ValidTo", _ValidTo));
                if (_RegistrationDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", _RegistrationDate));

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
                throw new Exception("CLicenses::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblLicenses" +
                                   " Set CustomerGuid = @CustomerGuid, " +
                                   " LicenseNumber = @LicenseNumber, " +
                                   " FirstName = @FirstName, " +
                                   " FatherName = @FatherName, " +
                                   " GrandName = @GrandName, " +
                                   " LevelGuid = @LevelGuid, " +
                                   " ValidFrom = @ValidFrom, " +
                                   " ValidTo = @ValidTo, " +
                                   " IsActive = @IsActive, " +
                                   " RegistrationDate = @RegistrationDate," +
                                    " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@LicenseNumber", _LicenseNumber));
                command.Parameters.Add(new SqlParameter("@FirstName", _FirstName));
                command.Parameters.Add(new SqlParameter("@FatherName", _FatherName));
                command.Parameters.Add(new SqlParameter("@GrandName", _GrandName));
                command.Parameters.Add(new SqlParameter("@LevelGuid", _LevelGuid));
                command.Parameters.Add(new SqlParameter("@IsActive", _IsActive));
                if (_ValidFrom == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ValidFrom", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ValidFrom", _ValidFrom));
                if (_ValidTo == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ValidTo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ValidTo", _ValidTo));
                if (_RegistrationDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", _RegistrationDate));

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
                throw new Exception("CLicenses::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblLicenses Where Id = @Id ";
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
                throw new Exception("CLicenses::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblLicenses] WHERE " +
                                       " CustomerGuid = @CustomerGuid " +
                                       " AND LicenseNumber = @LicenseNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblLicenses] WHERE " +
                                       " CustomerGuid = @CustomerGuid " +
                                       " AND LicenseNumber = @LicenseNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@LicenseNumber", _LicenseNumber));
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
                throw new Exception("CLicenses::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CLicenses> GetList()
        {
            List<CLicenses> RecordsList = new List<CLicenses>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select tblLicenses.*, tblLevels.Name as LevelName ";
            command.CommandText += " From tblLicenses INNER JOIN tblLevels ";
            command.CommandText += " ON tblLicenses.LevelGuid = tblLevels.TableRowGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLicenses objCLicenses = new CLicenses();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLicenses.Id = 0;
                    else
                        objCLicenses.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCLicenses.Customerguid = string.Empty;
                    else
                        objCLicenses.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseNumber"].Equals(DBNull.Value))
                        objCLicenses.Licensenumber = string.Empty;
                    else
                        objCLicenses.Licensenumber = (string)dr["LicenseNumber"];
                    if (dr["FirstName"].Equals(DBNull.Value))
                        objCLicenses.Firstname = string.Empty;
                    else
                        objCLicenses.Firstname = (string)dr["FirstName"];
                    if (dr["FatherName"].Equals(DBNull.Value))
                        objCLicenses.Fathername = string.Empty;
                    else
                        objCLicenses.Fathername = (string)dr["FatherName"];
                    if (dr["GrandName"].Equals(DBNull.Value))
                        objCLicenses.Grandname = string.Empty;
                    else
                        objCLicenses.Grandname = (string)dr["GrandName"];
                    if (dr["LevelGuid"].Equals(DBNull.Value))
                        objCLicenses.Levelguid = string.Empty;
                    else
                        objCLicenses.Levelguid = (string)dr["LevelGuid"];
                    if (dr["LevelName"].Equals(DBNull.Value))
                        objCLicenses.LevelName = string.Empty;
                    else
                        objCLicenses.LevelName = (string)dr["LevelName"];
                    if (dr["ValidFrom"].Equals(DBNull.Value))
                        objCLicenses.Validfrom = DateTime.MinValue;
                    else
                        objCLicenses.Validfrom = (DateTime)dr["ValidFrom"];
                    if (dr["ValidTo"].Equals(DBNull.Value))
                        objCLicenses.Validto = DateTime.MinValue;
                    else
                        objCLicenses.Validto = (DateTime)dr["ValidTo"];
                    if (dr["IsActive"].Equals(DBNull.Value))
                        objCLicenses.Isactive = 0;
                    else
                        objCLicenses.Isactive = (int)dr["IsActive"];
                    if (dr["RegistrationDate"].Equals(DBNull.Value))
                        objCLicenses.Registrationdate = DateTime.MinValue;
                    else
                        objCLicenses.Registrationdate = (DateTime)dr["RegistrationDate"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLicenses.Tablerowguid = string.Empty;
                    else
                        objCLicenses.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLicenses);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLicenses::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CLicenses> GetList(string Customerguid)
        {
            List<CLicenses> RecordsList = new List<CLicenses>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select tblLicenses.*, tblLevels.Name as LevelName ";
            command.CommandText += " From tblLicenses INNER JOIN tblLevels ";
            command.CommandText += " ON tblLicenses.LevelGuid = tblLevels.TableRowGuid ";
            command.CommandText += " where tblLicenses.CustomerGuid=@CustomerGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLicenses objCLicenses = new CLicenses();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLicenses.Id = 0;
                    else
                        objCLicenses.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCLicenses.Customerguid = string.Empty;
                    else
                        objCLicenses.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseNumber"].Equals(DBNull.Value))
                        objCLicenses.Licensenumber = string.Empty;
                    else
                        objCLicenses.Licensenumber = (string)dr["LicenseNumber"];
                    if (dr["FirstName"].Equals(DBNull.Value))
                        objCLicenses.Firstname = string.Empty;
                    else
                        objCLicenses.Firstname = (string)dr["FirstName"];
                    if (dr["FatherName"].Equals(DBNull.Value))
                        objCLicenses.Fathername = string.Empty;
                    else
                        objCLicenses.Fathername = (string)dr["FatherName"];
                    if (dr["GrandName"].Equals(DBNull.Value))
                        objCLicenses.Grandname = string.Empty;
                    else
                        objCLicenses.Grandname = (string)dr["GrandName"];
                    if (dr["LevelGuid"].Equals(DBNull.Value))
                        objCLicenses.Levelguid = string.Empty;
                    else
                        objCLicenses.Levelguid = (string)dr["LevelGuid"];
                    if (dr["LevelName"].Equals(DBNull.Value))
                        objCLicenses.LevelName = string.Empty;
                    else
                        objCLicenses.LevelName = (string)dr["LevelName"];
                    if (dr["ValidFrom"].Equals(DBNull.Value))
                        objCLicenses.Validfrom = DateTime.MinValue;
                    else
                        objCLicenses.Validfrom = (DateTime)dr["ValidFrom"];
                    if (dr["ValidTo"].Equals(DBNull.Value))
                        objCLicenses.Validto = DateTime.MinValue;
                    else
                        objCLicenses.Validto = (DateTime)dr["ValidTo"];
                    if (dr["IsActive"].Equals(DBNull.Value))
                        objCLicenses.Isactive = 0;
                    else
                        objCLicenses.Isactive = (int)dr["IsActive"];
                    if (dr["RegistrationDate"].Equals(DBNull.Value))
                        objCLicenses.Registrationdate = DateTime.MinValue;
                    else
                        objCLicenses.Registrationdate = (DateTime)dr["RegistrationDate"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLicenses.Tablerowguid = string.Empty;
                    else
                        objCLicenses.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLicenses);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLicenses::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CLicenses> GetListActive(string Customerguid)
        {
            List<CLicenses> RecordsList = new List<CLicenses>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select tblLicenses.*, tblLevels.Name as LevelName ";
            command.CommandText += " From tblLicenses INNER JOIN tblLevels ";
            command.CommandText += " ON tblLicenses.LevelGuid = tblLevels.TableRowGuid ";
            command.CommandText += " where tblLicenses.CustomerGuid=@CustomerGuid ";
            command.CommandText += " AND ISNULL(tblLicenses.IsActive,0) = 1 ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLicenses objCLicenses = new CLicenses();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLicenses.Id = 0;
                    else
                        objCLicenses.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCLicenses.Customerguid = string.Empty;
                    else
                        objCLicenses.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["LicenseNumber"].Equals(DBNull.Value))
                        objCLicenses.Licensenumber = string.Empty;
                    else
                        objCLicenses.Licensenumber = (string)dr["LicenseNumber"];
                    if (dr["FirstName"].Equals(DBNull.Value))
                        objCLicenses.Firstname = string.Empty;
                    else
                        objCLicenses.Firstname = (string)dr["FirstName"];
                    if (dr["FatherName"].Equals(DBNull.Value))
                        objCLicenses.Fathername = string.Empty;
                    else
                        objCLicenses.Fathername = (string)dr["FatherName"];
                    if (dr["GrandName"].Equals(DBNull.Value))
                        objCLicenses.Grandname = string.Empty;
                    else
                        objCLicenses.Grandname = (string)dr["GrandName"];
                    if (dr["LevelGuid"].Equals(DBNull.Value))
                        objCLicenses.Levelguid = string.Empty;
                    else
                        objCLicenses.Levelguid = (string)dr["LevelGuid"];
                    if (dr["LevelName"].Equals(DBNull.Value))
                        objCLicenses.LevelName = string.Empty;
                    else
                        objCLicenses.LevelName = (string)dr["LevelName"];
                    if (dr["ValidFrom"].Equals(DBNull.Value))
                        objCLicenses.Validfrom = DateTime.MinValue;
                    else
                        objCLicenses.Validfrom = (DateTime)dr["ValidFrom"];
                    if (dr["ValidTo"].Equals(DBNull.Value))
                        objCLicenses.Validto = DateTime.MinValue;
                    else
                        objCLicenses.Validto = (DateTime)dr["ValidTo"];
                    if (dr["IsActive"].Equals(DBNull.Value))
                        objCLicenses.Isactive = 0;
                    else
                        objCLicenses.Isactive = (int)dr["IsActive"];
                    if (dr["RegistrationDate"].Equals(DBNull.Value))
                        objCLicenses.Registrationdate = DateTime.MinValue;
                    else
                        objCLicenses.Registrationdate = (DateTime)dr["RegistrationDate"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCLicenses.Tablerowguid = string.Empty;
                    else
                        objCLicenses.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCLicenses);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLicenses::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public static int GetLicenseProfessionalLevel(string Licenseguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = " SELECT ProfessionalLevel = IsNull(tblLevels.ProfessionalLevel, 0) ";
            command.CommandText += " FROM tblLicenses INNER JOIN tblLevels ";
            command.CommandText += " ON tblLicenses.LevelGuid = tblLevels.TableRowGuid ";
            command.CommandText += " WHERE tblLicenses.TableRowGuid = @LicenseGuid ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@LicenseGuid", Licenseguid));
                connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetLicenseProfessionalLevel::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblLicenses] WHERE Id = @Id";
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
                throw new Exception("CLicenses::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblLicenses] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CLicenses::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
