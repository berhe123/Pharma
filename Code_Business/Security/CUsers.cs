using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;

namespace SecurityManager
{
    public class CUsers
    {


        string _ConnectionString = string.Empty;
        public CUsers()
        {
            _ConnectionString = ConnectionString;
        }
        public CUsers(int Id, string UserId, string Password, string FirstName, string FatherName, string GrandFatherName, int GroupId, int AccessRight, string Remark)
        {
            _id = Id;
            _userId = UserId;
            _password = Password;
            _firstName = FirstName;
            _fatherName = FatherName;
            _grandFatherName = GrandFatherName;
            _groupId = GroupId;
            _accessRight = AccessRight;
            _remark = Remark;
        }
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }


        #region Class Property Declarations
        int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        string _userId;
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        string _fatherName;
        public string FatherName
        {
            get { return _fatherName; }
            set { _fatherName = value; }
        }

        string _grandFatherName;
        public string GrandFatherName
        {
            get { return _grandFatherName; }
            set { _grandFatherName = value; }
        }

        int _groupId;
        public int GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }

        int _accessRight;
        public int AccessRight
        {
            get { return _accessRight; }
            set { _accessRight = value; }
        }

        string _remark;
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
        }
        string _groupname;
        public string GroupName
        {
            get { return _groupname; }
            set { _groupname = value; }
        }
        #endregion


        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblUsers_GetRecord]";
            command.CommandType = CommandType.StoredProcedure;
            DataTable dTable = new DataTable("CUsers");
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
                    if (dTable.Rows[0]["UserId"].Equals(DBNull.Value))
                        _userId = null;
                    else
                        _userId = (string)dTable.Rows[0]["UserId"];
                    if (dTable.Rows[0]["password"].Equals(DBNull.Value))
                        _password = null;
                    else
                        _password = (string)dTable.Rows[0]["password"];
                    if (dTable.Rows[0]["FirstName"].Equals(DBNull.Value))
                        _firstName = string.Empty;
                    else
                        _firstName = (string)dTable.Rows[0]["FirstName"];
                    if (dTable.Rows[0]["FatherName"].Equals(DBNull.Value))
                        _fatherName = string.Empty;
                    else
                        _fatherName = (string)dTable.Rows[0]["FatherName"];
                    if (dTable.Rows[0]["GrandFatherName"].Equals(DBNull.Value))
                        _grandFatherName = string.Empty;
                    else
                        _grandFatherName = (string)dTable.Rows[0]["GrandFatherName"];
                    _groupId = (int)dTable.Rows[0]["GroupId"];
                    if (dTable.Rows[0]["AccessRight"].Equals(DBNull.Value))
                        _accessRight = 0;
                    else
                        _accessRight = (int)dTable.Rows[0]["AccessRight"];
                    if (dTable.Rows[0]["Remark"].Equals(DBNull.Value))
                        _remark = string.Empty;
                    else
                        _remark = (string)dTable.Rows[0]["Remark"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CUsers::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "dbo.[tblUsers_GetRecords]";
            command.CommandType = CommandType.StoredProcedure;
            DataTable dTable = new DataTable("CUsers");
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
                throw new Exception("CUsers::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "dbo.[tblUsers_Insert]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@UserId", _userId));
                command.Parameters.Add(new SqlParameter("@password", _password));
                command.Parameters.Add(new SqlParameter("@FirstName", _firstName));
                command.Parameters.Add(new SqlParameter("@FatherName", _fatherName));
                command.Parameters.Add(new SqlParameter("@GrandFatherName", _grandFatherName));
                command.Parameters.Add(new SqlParameter("@GroupId", _groupId));
                command.Parameters.Add(new SqlParameter("@AccessRight", _accessRight));
                command.Parameters.Add(new SqlParameter("@Remark", _remark));
                command.Parameters.Add(new SqlParameter("@id", _id));
                command.Parameters["@id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _id = (int)command.Parameters["@id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CUsers::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "dbo.[tblUsers_Update]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@UserId", _userId));
                command.Parameters.Add(new SqlParameter("@password", _password));
                command.Parameters.Add(new SqlParameter("@FirstName", _firstName));
                command.Parameters.Add(new SqlParameter("@FatherName", _fatherName));
                command.Parameters.Add(new SqlParameter("@GrandFatherName", _grandFatherName));
                command.Parameters.Add(new SqlParameter("@GroupId", _groupId));
                command.Parameters.Add(new SqlParameter("@AccessRight", _accessRight));
                command.Parameters.Add(new SqlParameter("@Remark", _remark));
                command.Parameters.Add(new SqlParameter("@id", _id));


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CUsers::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool UpdatePassword()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblUsers_UpdatePassword]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@password", _password));
                command.Parameters.Add(new SqlParameter("@id", _id));


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CUsers::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "dbo.[tblUsers_Delete]";
            command.CommandType = CommandType.StoredProcedure;
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
                throw new Exception("CUsers::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Insert(int Id, string UserId, string Password, string FirstName, string FatherName, string GrandFatherName, int GroupId, int AccessRight, string Remark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblUsers_Insert]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@UserId", UserId));
                command.Parameters.Add(new SqlParameter("@password", Password));
                command.Parameters.Add(new SqlParameter("@FirstName", FirstName));
                command.Parameters.Add(new SqlParameter("@FatherName", FatherName));
                command.Parameters.Add(new SqlParameter("@GrandFatherName", GrandFatherName));
                command.Parameters.Add(new SqlParameter("@GroupId", GroupId));
                command.Parameters.Add(new SqlParameter("@AccessRight", AccessRight));
                command.Parameters.Add(new SqlParameter("@Remark", Remark));
                command.Parameters.Add(new SqlParameter("@id", Id));
                command.Parameters["@id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _id = (int)command.Parameters["@id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CUsers::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string UserId, string Password, string FirstName, string FatherName, string GrandFatherName, int GroupId, int AccessRight, string Remark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblUsers_Update]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@UserId", UserId));
                command.Parameters.Add(new SqlParameter("@password", Password));
                command.Parameters.Add(new SqlParameter("@FirstName", FirstName));
                command.Parameters.Add(new SqlParameter("@FatherName", FatherName));
                command.Parameters.Add(new SqlParameter("@GrandFatherName", GrandFatherName));
                command.Parameters.Add(new SqlParameter("@GroupId", GroupId));
                command.Parameters.Add(new SqlParameter("@AccessRight", AccessRight));
                command.Parameters.Add(new SqlParameter("@Remark", Remark));
                command.Parameters.Add(new SqlParameter("@id", Id));


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CUsers::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Delete(int Id, string UserId, string Password, string FirstName, string FatherName, string GrandFatherName, int GroupId, int AccessRight, string Remark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblUsers_Delete]";
            command.CommandType = CommandType.StoredProcedure;
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
                throw new Exception("CUsers::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }


        public List<CUsers> GetList()
        {
            List<CUsers> RecordsList = new List<CUsers>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblUsers_GetRecords]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CUsers objCUsers = new CUsers();
                    if (dr["id"].Equals(DBNull.Value))
                        objCUsers.Id = 0;
                    else
                        objCUsers.Id = (int)dr["id"];
                    if (dr["UserId"].Equals(DBNull.Value))
                        objCUsers.UserId = null;
                    else
                        objCUsers.UserId = (string)dr["UserId"];
                    if (dr["password"].Equals(DBNull.Value))
                        objCUsers.Password = null;
                    else
                        objCUsers.Password = (string)dr["password"];
                    if (dr["FirstName"].Equals(DBNull.Value))
                        objCUsers.FirstName = string.Empty;
                    else
                        objCUsers.FirstName = (string)dr["FirstName"];
                    if (dr["FatherName"].Equals(DBNull.Value))
                        objCUsers.FatherName = string.Empty;
                    else
                        objCUsers.FatherName = (string)dr["FatherName"];
                    if (dr["GrandFatherName"].Equals(DBNull.Value))
                        objCUsers.GrandFatherName = string.Empty;
                    else
                        objCUsers.GrandFatherName = (string)dr["GrandFatherName"];
                    if (dr["GroupId"].Equals(DBNull.Value))
                        objCUsers.GroupId = 0;
                    else
                        objCUsers.GroupId = (int)dr["GroupId"];
                    if (dr["AccessRight"].Equals(DBNull.Value))
                        objCUsers.AccessRight = 0;
                    else
                        objCUsers.AccessRight = (int)dr["AccessRight"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCUsers.Remark = string.Empty;
                    else
                        objCUsers.Remark = (string)dr["Remark"];
                    if (dr["GroupName"].Equals(DBNull.Value))
                        objCUsers.GroupName = string.Empty;
                    else
                        objCUsers.GroupName = (string)dr["GroupName"];



                    RecordsList.Add(objCUsers);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CUsers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CUsers> GetList(Int32 lngGroupId)
        {
            List<CUsers> RecordsList = new List<CUsers>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblUsers_GetRecordsByGroup]";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@GroupId", lngGroupId));
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CUsers objCUsers = new CUsers();
                    if (dr["id"].Equals(DBNull.Value))
                        objCUsers.Id = 0;
                    else
                        objCUsers.Id = (int)dr["id"];
                    if (dr["UserId"].Equals(DBNull.Value))
                        objCUsers.UserId = null;
                    else
                        objCUsers.UserId = (string)dr["UserId"];
                    if (dr["password"].Equals(DBNull.Value))
                        objCUsers.Password = null;
                    else
                        objCUsers.Password = (string)dr["password"];
                    if (dr["FirstName"].Equals(DBNull.Value))
                        objCUsers.FirstName = string.Empty;
                    else
                        objCUsers.FirstName = (string)dr["FirstName"];
                    if (dr["FatherName"].Equals(DBNull.Value))
                        objCUsers.FatherName = string.Empty;
                    else
                        objCUsers.FatherName = (string)dr["FatherName"];
                    if (dr["GrandFatherName"].Equals(DBNull.Value))
                        objCUsers.GrandFatherName = string.Empty;
                    else
                        objCUsers.GrandFatherName = (string)dr["GrandFatherName"];
                    if (dr["GroupId"].Equals(DBNull.Value))
                        objCUsers.GroupId = 0;
                    else
                        objCUsers.GroupId = (int)dr["GroupId"];
                    if (dr["AccessRight"].Equals(DBNull.Value))
                        objCUsers.AccessRight = 0;
                    else
                        objCUsers.AccessRight = (int)dr["AccessRight"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCUsers.Remark = string.Empty;
                    else
                        objCUsers.Remark = (string)dr["Remark"];
                    if (dr["GroupName"].Equals(DBNull.Value))
                        objCUsers.GroupName = string.Empty;
                    else
                        objCUsers.GroupName = (string)dr["GroupName"];
                    RecordsList.Add(objCUsers);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CUsers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblUsers_Exists]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CUsers::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int IsUserExistant(bool blnNewRecord)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            if (blnNewRecord == true)
            {
                command.CommandText = "dbo.tblUsers_ExistsUserNameNew";
                command.Parameters.Add(new SqlParameter("@UserName", _userId));
            }
            else
            {
                command.CommandText = "dbo.tblUsers_ExistsUserNameUpdate";
                command.Parameters.Add(new SqlParameter("@id", _id));
                command.Parameters.Add(new SqlParameter("@UserName", _userId));
            }

            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            try
            {

                connection.Open();
                return (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::IsUserExistant::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool IsAccessRightCorrect(int intUserAccessRight, int intGruopId)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            command.CommandText = "Select AccessRight From tblGroups where id =" + intGruopId;
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {

                connection.Open();
                dr = command.ExecuteReader();
                dr.Read();
                if (intUserAccessRight > Convert.ToInt32(dr["AccessRight"]))
                    return false;
                else
                    return true;             
            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::IsUserExistant::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        
    }
}