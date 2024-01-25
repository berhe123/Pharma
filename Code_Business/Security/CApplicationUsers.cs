//
// ...
// Wizard generated code
// Date: 2/10/2009 1:57:08 AM
// Class: CApplicationUsers
// ...
//

using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;

namespace SecurityManager
{
    class CApplicationUsers
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }
        public CApplicationUsers()
        {
            _ConnectionString = ConnectionString;
        }
        public CApplicationUsers(int Id, int ApplicationId, int UserId)
        {
            _id = Id;
            _application_id = ApplicationId;
            _user_id = UserId;
        }

        #region Class Property Declarations
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        int _application_id;
        public int ApplicationId
        {
            get { return _application_id; }
            set { _application_id = value; }
        }

        int _user_id;
        public int UserId
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        string _user_name;
        public string UserName
        {
            get { return _user_name; }
            set { _user_name = value; }
        }


        #endregion

        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblApplicationUsers where id=@id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblApplicationUsers");
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
                    if (dTable.Rows[0]["application_id"].Equals(DBNull.Value))
                        _application_id = 0;
                    else
                        _application_id = (int)dTable.Rows[0]["application_id"];
                    if (dTable.Rows[0]["user_id"].Equals(DBNull.Value))
                        _user_id = 0;
                    else
                        _user_id = (int)dTable.Rows[0]["user_id"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CApplicationUsers::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblApplicationUsers";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblApplicationUsers");
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
                throw new Exception("CApplicationUsers::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblApplicationUsers" +
                                   " (application_id, " +
                                   " user_id)" +
                                   " Values (@application_id, " +
                                   " @user_id)" +
                                   " SELECT @id=Max(id) from tblApplicationUsers ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@application_id", _application_id));
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
                throw new Exception("CApplicationUsers::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblApplicationUsers" +
                                   " Set application_id = @application_id, " +
                                   " user_id = @user_id" +
                                   " Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@application_id", _application_id));
                command.Parameters.Add(new SqlParameter("@user_id", _user_id));
                command.Parameters.Add(new SqlParameter("@id", _id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CApplicationUsers::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblApplicationUsers Where id = @id ";
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
                throw new Exception("CApplicationUsers::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            
                command.CommandText = "SELECT id FROM [dbo].[tblApplicationUsers] WHERE " +
                                       " application_id =" + ApplicationId + " And user_id =" + UserId ;
           
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {                
                
                connection.Open();
                temp = command.ExecuteScalar();
                if (temp != null)
                    return (int)temp;
                else
                    return 0;
               
            }
            catch (Exception ex)
            {
                throw new Exception("CApplicationUsers::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, int ApplicationId, int UserId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblApplicationUsers" +
                                   " (application_id, " +
                                   " user_id)" +
                                   " Values (@application_id, " +
                                   " @user_id)" +
                                   " Select @id=Max(id) from tblApplicationUsers ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@application_id", ApplicationId));
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
                throw new Exception("CApplicationUsers::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, int ApplicationId, int UserId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblApplicationUsers" +
                                   " Set application_id = @application_id, " +
                                   " user_id = @user_id" +
                                   " Where id = @id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@application_id", ApplicationId));
                command.Parameters.Add(new SqlParameter("@user_id", UserId));

                command.Parameters.Add(new SqlParameter("@id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CApplicationUsers::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblApplicationUsers Where id = @id ";
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
                throw new Exception("CApplicationUsers::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew,
        int Id)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT id FROM [dbo].[tblApplicationUsers] WHERE " +
                                       " ";
            else
                command.CommandText = "SELECT id FROM [dbo].[tblApplicationUsers] WHERE " +
                                       "  " +
                                       " AND id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", Id));
                if (!bNew)
                    command.Parameters.Add(new SqlParameter("@id", _id));
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
                throw new Exception("CApplicationUsers::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CApplicationUsers> GetList()
        {
            List<CApplicationUsers> RecordsList = new List<CApplicationUsers>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblApplicationUsers";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CApplicationUsers objCApplicationUsers = new CApplicationUsers();
                    if (dr["id"].Equals(DBNull.Value))
                        objCApplicationUsers.Id = 0;
                    else
                        objCApplicationUsers.Id = (int)dr["id"];
                    if (dr["application_id"].Equals(DBNull.Value))
                        objCApplicationUsers.ApplicationId = 0;
                    else
                        objCApplicationUsers.ApplicationId = (int)dr["application_id"];
                    if (dr["user_id"].Equals(DBNull.Value))
                        objCApplicationUsers.UserId = 0;
                    else
                        objCApplicationUsers.UserId = (int)dr["user_id"];

                    RecordsList.Add(objCApplicationUsers);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CApplicationUsers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CApplicationUsers> GetList(int intAppId)
        {
            List<CApplicationUsers> RecordsList = new List<CApplicationUsers>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select tblApplicationUsers.*, (Select UserId From tblUsers Where id = tblApplicationUsers.user_id ) as UserName from tblApplicationUsers where application_id =" + intAppId;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CApplicationUsers objCApplicationUsers = new CApplicationUsers();
                    if (dr["id"].Equals(DBNull.Value))
                        objCApplicationUsers.Id = 0;
                    else
                        objCApplicationUsers.Id = (int)dr["id"];
                    if (dr["application_id"].Equals(DBNull.Value))
                        objCApplicationUsers.ApplicationId = 0;
                    else
                        objCApplicationUsers.ApplicationId = (int)dr["application_id"];
                    if (dr["user_id"].Equals(DBNull.Value))
                        objCApplicationUsers.UserId = 0;
                    else
                        objCApplicationUsers.UserId = (int)dr["user_id"];
                    if (dr["UserName"].Equals(DBNull.Value))
                        objCApplicationUsers.UserName = string.Empty;
                    else
                        objCApplicationUsers.UserName = (string)dr["UserName"];


                    RecordsList.Add(objCApplicationUsers);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CApplicationUsers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
