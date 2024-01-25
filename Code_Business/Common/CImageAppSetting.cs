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
    class CImageAppSetting
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CImageAppSetting()
        {
            _ConnectionString = ConnectionString;
        }
        public CImageAppSetting(int Id, string AppId, string Key, string Value, string Default, byte[] photo, string UserId)
        {
            _id = Id;
            
           
            _photo = photo;
           
        }

        #region Class Property Declarations
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        byte[] _photo;
        public byte[] photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

      
        #endregion

        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblItems where id=@id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblItems");
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
                  
                  
                    if (dTable.Rows[0]["photo"].Equals(DBNull.Value))
                        _photo = null;
                    else
                        _photo = (byte[])dTable.Rows[0]["photo"];
                   

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
            command.CommandText = "Select * from tblItems";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblItems");
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
            command.CommandText = "Insert Into tblItems" +


                                   " [photo] ";
                                   
            if (_photo != null)
                command.CommandText += " @photo, ";
            else
                command.CommandText += " NULL, ";
            command.CommandText += " @user_id)" +
                                   " SELECT @id=Max(id) from tblItems ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
              

               
                if (_photo != null)
                    command.Parameters.Add(new SqlParameter("@photo", _photo));
                

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
            command.CommandText = "Update tblItems";
                                  
                                 
            if (_photo != null)
                command.CommandText += " [photo] = @photo, ";
            else
                command.CommandText += " [photo] = NULL, ";
            command.CommandText += " [user_id] = @user_id " +
                                   " Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
               
              
                if (_photo != null)
                    command.Parameters.Add(new SqlParameter("@photo", _photo));
            

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
            command.CommandText = "Delete From tblItems Where id = @id ";
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
                command.CommandText = "SELECT id FROM [dbo].[tblItems] ";
            else
                command.CommandText = "SELECT id FROM [dbo].[tblItems]" +
                                      
                                       " id <> @id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@id", _id));
           
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

        private bool Insert(int Id,  string Value, string Default, byte[] photo, string UserId)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblItems" +

                                   " [photo] ";
                                 
            if (photo != null)
                command.CommandText += " @photo, ";
            else
                command.CommandText += " NULL, ";
            command.CommandText += " @user_id)" +
                                   " Select @id=Max(id) from tblItems ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                
               
                if (photo != null)
                    command.Parameters.Add(new SqlParameter("@photo", photo));
              

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
        private bool Update(int Id, string Value, string Default, byte[] photo, string UserId)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblItems";
                                 
                                   
            if (photo != null)
                command.CommandText += " [photo] = @photo, ";
            else
                command.CommandText += " [photo] = NULL, ";
           
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
             
                
                if (photo != null)
                    command.Parameters.Add(new SqlParameter("@photo", photo));
            

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
            command.CommandText = "Delete From tblItems Where id = @id ";
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
                command.CommandText = "SELECT id FROM [dbo].[tblItems]  ";
            else
                command.CommandText = "SELECT id FROM [dbo].[tblItems]  " +
                                      
                                       "  [id] <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@id", Id));
          
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

        public List<CImageAppSetting> GetList()
        {
            List<CImageAppSetting> RecordsList = new List<CImageAppSetting>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblItems";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CImageAppSetting objCAppSettings = new CImageAppSetting();
                    if (dr["id"].Equals(DBNull.Value))
                        objCAppSettings.Id = 0;
                    else
                        objCAppSettings.Id = (int)dr["id"];
                   
                    
                    if (dr["photo"].Equals(DBNull.Value))
                        objCAppSettings.photo = null;
                    else
                        objCAppSettings.photo = (byte[])dr["photo"];
                  

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
            command.CommandText = "Select id from tblItems ";
                                    
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblItems");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
               
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
            command.CommandText = "Select * from tblItems ";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblItems");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                
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
            command.CommandText = "Select * from tblItems ";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblItems");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
               
                connection.Open();
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {

                    if (dTable.Rows[0]["photo"].Equals(DBNull.Value))
                        return null;
                    else
                        return (byte[])dTable.Rows[0]["photo"];

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

        private static bool InsertSetting(int Id, string AppId, string Key, string Value, string Default, byte[] photo, string UserId)
        {
            int table_id = 0;

            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblItems" +

                                   " [photo] ";
                                   
                                  
                                   
            if (photo != null)
                command.CommandText += " @photo, ";
            else
                command.CommandText += " NULL, ";
            command.CommandText += " @user_id)" +
                                   " Select @id=Max(id) from tblItems ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
               
                
                if (photo != null)
                    command.Parameters.Add(new SqlParameter("@photo", photo));
                

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
        private static bool UpdateSetting(int Id,  string Value, string Default, byte[] photo, string UserId)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblItems";
                                   
                                 
            if (photo != null)
                command.CommandText += " [photo] = @photo, ";
            else
                command.CommandText += " [photo] = NULL, ";
            command.CommandText += " [user_id] = @user_id" +
                                   " Where id = @id ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                
                command.Parameters.Add(new SqlParameter("@value", Value));
                command.Parameters.Add(new SqlParameter("@default", Default));
                if (photo != null)
                    command.Parameters.Add(new SqlParameter("@photo", photo));
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
        public static void SaveSetting(string AppId, string Key, string Value, string Default, byte[] photo, string UserId)
        {
            int intId = 0;

            try
            {
                intId = GetSettingID(AppId, Key);
                if (intId <= 0)
                    InsertSetting(intId, AppId, Key, Value, Default, photo, UserId);
                else
                    UpdateSetting(intId, Value, Default, photo, UserId);
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
            command.CommandText = "Delete From tblItems Where id = @id ";
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
