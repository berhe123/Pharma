//
// ...
// Wizard generated code
// Date: 3/28/2009 12:39:30 PM
// Class: CAppSettings
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
    class CAppSettings
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CAppSettings()
        {
            _ConnectionString = ConnectionString;
        }
        public CAppSettings(int Id, string AppId, string Key, string Value, string Default, byte[] picture, string UserId)
        {
            _id = Id;
            _app_id = AppId;
            _key = Key;
            _value = Value;
            _default = Default;
            _picture = picture;
            _user_id = UserId;
        }

        #region Class Property Declarations
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _app_id;
        public string AppId
        {
            get { return _app_id; }
            set { _app_id = value; }
        }

        string _key;
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        string _default;
        public string Default
        {
            get { return _default; }
            set { _default = value; }
        }

        byte[] _picture;
        public byte[] picture
        {
            get { return _picture; }
            set { _picture = value; }
        }

        string _user_id;
        public string UserId
        {
            get { return _user_id; }
            set { _user_id = value; }
        }

        #endregion

        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblAppSettings where id=@id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblAppSettings");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", _id));
                connection.Open();
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    _id = (int)dTable.Rows[0]["id"];
                    if (dTable.Rows[0]["app_id"].Equals(DBNull.Value))
                        _app_id = string.Empty;
                    else
                        _app_id = (string)dTable.Rows[0]["app_id"];
                    if (dTable.Rows[0]["key"].Equals(DBNull.Value))
                        _key = string.Empty;
                    else
                        _key = (string)dTable.Rows[0]["key"];
                    if (dTable.Rows[0]["value"].Equals(DBNull.Value))
                        _value = string.Empty;
                    else
                        _value = (string)dTable.Rows[0]["value"];
                    if (dTable.Rows[0]["default"].Equals(DBNull.Value))
                        _default = string.Empty;
                    else
                        _default = (string)dTable.Rows[0]["default"];
                    if (dTable.Rows[0]["picture"].Equals(DBNull.Value))
                        _picture = null;
                    else
                        _picture = (byte[])dTable.Rows[0]["picture"];
                    if (dTable.Rows[0]["user_id"].Equals(DBNull.Value))
                        _user_id = string.Empty;
                    else
                        _user_id = (string)dTable.Rows[0]["user_id"];

                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::GetRecord::Error! " + ex.Message, ex);
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
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblAppSettings";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblAppSettings");
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
                throw new Exception("CAppSettings::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }

        private bool Insert()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblAppSettings" +
                                   " ([app_id], " +
                                   " [key], " +
                                   " [value], " +
                                   " [default], " +
                                   " [picture], " +
                                   " [user_id])" +
                                   " Values (@app_id, " +
                                   " @key, " +
                                   " @value, " +
                                   " @default, ";
            if (_picture != null)
                command.CommandText += " @picture, ";
            else
                command.CommandText += " NULL, ";
            command.CommandText += " @user_id)" +
                                   " SELECT @id=Max(id) from tblAppSettings ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@app_id", _app_id));
                command.Parameters.Add(new SqlParameter("@key", _key));
                command.Parameters.Add(new SqlParameter("@value", _value));
                command.Parameters.Add(new SqlParameter("@default", _default));
                if (_picture != null)
                    command.Parameters.Add(new SqlParameter("@picture", _picture));
                command.Parameters.Add(new SqlParameter("@user_id", _user_id));

                command.Parameters.Add(new SqlParameter("@id", _id));
                command.Parameters["@id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _id = (int)command.Parameters["@id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private bool Update()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblAppSettings" +
                                   " Set [app_id] = @app_id, " +
                                   " [key] = @key, " +
                                   " [value] = @value, " +
                                   " [default] = @default, ";
            if (_picture != null)
                command.CommandText += " [picture] = @picture, ";
            else
                command.CommandText += " [picture] = NULL, ";
            command.CommandText += " [user_id] = @user_id " +
                                   " Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@app_id", _app_id));
                command.Parameters.Add(new SqlParameter("@key", _key));
                command.Parameters.Add(new SqlParameter("@value", _value));
                command.Parameters.Add(new SqlParameter("@default", _default));
                if (_picture != null)
                    command.Parameters.Add(new SqlParameter("@picture", _picture));
                command.Parameters.Add(new SqlParameter("@user_id", _user_id));

                command.Parameters.Add(new SqlParameter("@id", _id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private bool Delete()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblAppSettings Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", _id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private int Exists(bool bNew)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT id FROM [dbo].[tblAppSettings] WHERE " +
                                       " [app_id] = @app_id " +
                                       " AND [key] = @key";
            else
                command.CommandText = "SELECT id FROM [dbo].[tblAppSettings] WHERE " +
                                       " [app_id] = @app_id " +
                                       " AND [key] = @key " +
                                       " AND id <> @id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@id", _id));
            command.Parameters.Add(new SqlParameter("@app_id", _app_id));
            command.Parameters.Add(new SqlParameter("@key", _key));
            if (!bNew)
                command.Parameters.Add(new SqlParameter("@id", _id));

            try
            {
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
                throw new Exception("CAppSettings::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        private bool Insert(int Id, string AppId, string Key, string Value, string Default, byte[] picture, string UserId)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblAppSettings" +
                                   " (app_id, " +
                                   " [key], " +
                                   " [value], " +
                                   " [default], " +
                                   " [picture], " +
                                   " [user_id])" +
                                    " Values (@app_id, " +
                                    " @key, " +
                                    " @value, " +
                                    " @default, ";
            if (picture != null)
                command.CommandText += " @picture, ";
            else
                command.CommandText += " NULL, ";
            command.CommandText += " @user_id)" +
                                   " Select @id=Max(id) from tblAppSettings ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@app_id", AppId));
                command.Parameters.Add(new SqlParameter("@key", Key));
                command.Parameters.Add(new SqlParameter("@value", Value));
                command.Parameters.Add(new SqlParameter("@default", Default));
                if (picture != null)
                    command.Parameters.Add(new SqlParameter("@picture", picture));
                command.Parameters.Add(new SqlParameter("@user_id", UserId));

                command.Parameters.Add(new SqlParameter("@id", Id));
                command.Parameters["@id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _id = (int)command.Parameters["@id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private bool Update(int Id, string AppId, string Key, string Value, string Default, byte[] picture, string UserId)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblAppSettings" +
                                   " Set [app_id] = @app_id, " +
                                   " [key] = @key, " +
                                   " [value] = @value, " +
                                   " [default] = @default, ";
            if (picture != null)
                command.CommandText += " [picture] = @picture, ";
            else
                command.CommandText += " [picture] = NULL, ";
            command.CommandText += " [user_id] = @user_id" +
                                   " Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@app_id", AppId));
                command.Parameters.Add(new SqlParameter("@key", Key));
                command.Parameters.Add(new SqlParameter("@value", Value));
                command.Parameters.Add(new SqlParameter("@default", Default));
                if (picture != null)
                    command.Parameters.Add(new SqlParameter("@picture", picture));
                command.Parameters.Add(new SqlParameter("@user_id", UserId));

                command.Parameters.Add(new SqlParameter("@id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private bool Delete(int Id)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblAppSettings Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private int Exists(bool bNew, int Id, string AppId, string Key)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT id FROM [dbo].[tblAppSettings] WHERE " +
                                       " [app_id] = @app_id " +
                                       " AND [key] = @key";
            else
                command.CommandText = "SELECT id FROM [dbo].[tblAppSettings] WHERE " +
                                       " [app_id] = @app_id " +
                                       " AND [key] = @key " +
                                       " AND [id] <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@id", Id));
            command.Parameters.Add(new SqlParameter("@app_id", AppId));
            command.Parameters.Add(new SqlParameter("@key", Key));
            if (!bNew)
                command.Parameters.Add(new SqlParameter("@id", _id));

            try
            {
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
                throw new Exception("CAppSettings::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CAppSettings> GetList()
        {
            List<CAppSettings> RecordsList = new List<CAppSettings>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblAppSettings";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CAppSettings objCAppSettings = new CAppSettings();
                    if (dr["id"].Equals(DBNull.Value))
                        objCAppSettings.Id = 0;
                    else
                        objCAppSettings.Id = (int)dr["id"];
                    if (dr["app_id"].Equals(DBNull.Value))
                        objCAppSettings.AppId = string.Empty;
                    else
                        objCAppSettings.AppId = (string)dr["app_id"];
                    if (dr["key"].Equals(DBNull.Value))
                        objCAppSettings.Key = string.Empty;
                    else
                        objCAppSettings.Key = (string)dr["key"];
                    if (dr["value"].Equals(DBNull.Value))
                        objCAppSettings.Value = string.Empty;
                    else
                        objCAppSettings.Value = (string)dr["value"];
                    if (dr["default"].Equals(DBNull.Value))
                        objCAppSettings.Default = string.Empty;
                    else
                        objCAppSettings.Default = (string)dr["default"];
                    if (dr["picture"].Equals(DBNull.Value))
                        objCAppSettings.picture = null;
                    else
                        objCAppSettings.picture = (byte[])dr["picture"];
                    if (dr["user_id"].Equals(DBNull.Value))
                        objCAppSettings.UserId = string.Empty;
                    else
                        objCAppSettings.UserId = (string)dr["user_id"];

                    RecordsList.Add(objCAppSettings);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        private static int GetSettingID(string str_app_id, string str_key)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select id from tblAppSettings " +
                                    " where [app_id]=@app_id and [key]=@key";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblAppSettings");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@app_id", str_app_id));
                command.Parameters.Add(new SqlParameter("@key", str_key));
                connection.Open();
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                    return (int)dTable.Rows[0]["id"];
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::GetSettingID::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public static string GetSetting(string str_app_id, string str_key, string str_default)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblAppSettings " +
                                    " where [app_id]=@app_id and [key]=@key";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblAppSettings");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@app_id", str_app_id));
                command.Parameters.Add(new SqlParameter("@key", str_key));
                connection.Open();
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {

                    if (dTable.Rows[0]["value"].Equals(DBNull.Value))
                        return str_default;
                    else
                        return (string)dTable.Rows[0]["value"];

                }
                else
                {
                    return str_default;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::GetSetting::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public static byte[] GetImageSetting(string str_app_id, string str_key, byte[] str_default_picture)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblAppSettings " +
                                    " where [app_id]=@app_id and [key]=@key";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblAppSettings");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@app_id", str_app_id));
                command.Parameters.Add(new SqlParameter("@key", str_key));
                connection.Open();
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {

                    if (dTable.Rows[0]["picture"].Equals(DBNull.Value))
                        return null;
                    else
                        return (byte[])dTable.Rows[0]["picture"];

                }
                else
                {
                    return str_default_picture;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::GetSetting::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }

        private static bool InsertSetting(int Id, string AppId, string Key, string Value, string Default, byte[] picture, string UserId)
        {
            int table_id = 0;

            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblAppSettings" +
                                   " (app_id, " +
                                   " [key], " +
                                   " [value], " +
                                   " [default], " +
                                   " [picture], " +
                                   " [user_id])" +
                                   " Values (@app_id, " +
                                   " @key, " +
                                   " @value, " +
                                   " @default, ";
            if (picture != null)
                command.CommandText += " @picture, ";
            else
                command.CommandText += " NULL, ";
            command.CommandText += " @user_id)" +
                                   " Select @id=Max(id) from tblAppSettings ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@app_id", AppId));
                command.Parameters.Add(new SqlParameter("@key", Key));
                command.Parameters.Add(new SqlParameter("@value", Value));
                command.Parameters.Add(new SqlParameter("@default", Default));
                if (picture != null)
                    command.Parameters.Add(new SqlParameter("@picture", picture));
                command.Parameters.Add(new SqlParameter("@user_id", UserId));

                command.Parameters.Add(new SqlParameter("@id", Id));
                command.Parameters["@id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                table_id = (int)command.Parameters["@id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        private static bool UpdateSetting(int Id, string AppId, string Key, string Value, string Default, byte[] picture, string UserId)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblAppSettings" +
                                   " Set [app_id] = @app_id, " +
                                   " [key] = @key, " +
                                   " [value] = @value, " +
                                   " [default] = @default, ";
            if (picture != null)
                command.CommandText += " [picture] = @picture, ";
            else
                command.CommandText += " [picture] = NULL, ";
            command.CommandText += " [user_id] = @user_id" +
                                   " Where id = @id ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@app_id", AppId));
                command.Parameters.Add(new SqlParameter("@key", Key));
                command.Parameters.Add(new SqlParameter("@value", Value));
                command.Parameters.Add(new SqlParameter("@default", Default));
                if (picture != null)
                    command.Parameters.Add(new SqlParameter("@picture", picture));
                command.Parameters.Add(new SqlParameter("@user_id", UserId));

                command.Parameters.Add(new SqlParameter("@id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static void SaveSetting(string AppId, string Key, string Value, string Default, byte[] picture, string UserId)
        {
            int intId = 0;

            try
            {
                intId = GetSettingID(AppId, Key);
                if (intId <= 0)
                    InsertSetting(intId, AppId, Key, Value, Default, picture, UserId);
                else
                    UpdateSetting(intId, AppId, Key, Value, Default, picture, UserId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static bool DeleteSetting(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblAppSettings Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CAppSettings::DeleteSetting::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
