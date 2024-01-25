using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;


namespace SecurityManager
{
    public class CGroups
    {


        string _ConnectionString = string.Empty;
        public CGroups()
        {
            _ConnectionString = ConnectionString;
        }
        public CGroups(int Id, string GroupName, int AccessRight, string Description)
        {
            _id = Id;
            _groupName = GroupName;
            _accessRight = AccessRight;
            _description = Description;
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

        string _groupName;
        public string GroupName
        {
            get { return _groupName; }
            set { _groupName = value; }
        }

        int _accessRight;
        public int AccessRight
        {
            get { return _accessRight; }
            set { _accessRight = value; }
        }

        string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        #endregion


        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblGroups_GetRecord]";
            command.CommandType = CommandType.StoredProcedure;
            DataTable dTable = new DataTable("tblGroups");
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
                    if (dTable.Rows[0]["GroupName"].Equals(DBNull.Value))
                        _groupName = null;
                    else
                        _groupName = (string)dTable.Rows[0]["GroupName"];
                    _accessRight = (int)dTable.Rows[0]["AccessRight"];
                    if (dTable.Rows[0]["Description"].Equals(DBNull.Value))
                        _description = string.Empty;
                    else
                        _description = (string)dTable.Rows[0]["Description"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "dbo.[tblGroups_GetRecords]";
            command.CommandType = CommandType.StoredProcedure;
            DataTable dTable = new DataTable("tblGroups");
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
                throw new Exception("CGroups::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "dbo.[tblGroups_Insert]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", _id));
                command.Parameters.Add(new SqlParameter("@GroupName", _groupName));
                command.Parameters.Add(new SqlParameter("@Description", _description));
                command.Parameters.Add(new SqlParameter("@AccessRight", _accessRight));
                command.Parameters["@id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _accessRight = (int)command.Parameters["@AccessRight"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "dbo.[tblGroups_Update]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", _id));
                command.Parameters.Add(new SqlParameter("@GroupName", _groupName));
                command.Parameters.Add(new SqlParameter("@Description", _description));
                command.Parameters.Add(new SqlParameter("@AccessRight", _accessRight));


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "dbo.[tblGroups_Delete]";
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
                throw new Exception("CGroups::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Insert(int Id, string GroupName, int AccessRight, string Description)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblGroups_Insert]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", Id));
                command.Parameters.Add(new SqlParameter("@GroupName", GroupName));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@AccessRight", AccessRight));
                command.Parameters["@AccessRight"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _accessRight = (int)command.Parameters["@AccessRight"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string GroupName, int AccessRight, string Description)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblGroups_Update]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@id", Id));
                command.Parameters.Add(new SqlParameter("@GroupName", GroupName));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@AccessRight", AccessRight));


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Delete(int Id, string GroupName, int AccessRight, string Description)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblGroups_Delete]";
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
                throw new Exception("CGroups::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }


        public List<CGroups> GetList()
        {
            List<CGroups> RecordsList = new List<CGroups>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "dbo.[tblGroups_GetRecords]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CGroups objCGroups = new CGroups();
                    if (dr["id"].Equals(DBNull.Value))
                        objCGroups.Id = 0;
                    else
                        objCGroups.Id = (int)dr["id"];
                    if (dr["GroupName"].Equals(DBNull.Value))
                        objCGroups.GroupName = null;
                    else
                        objCGroups.GroupName = (string)dr["GroupName"];
                    if (dr["AccessRight"].Equals(DBNull.Value))
                        objCGroups.AccessRight = 0;
                    else
                        objCGroups.AccessRight = (int)dr["AccessRight"];
                    if (dr["Description"].Equals(DBNull.Value))
                        objCGroups.Description = string.Empty;
                    else
                        objCGroups.Description = (string)dr["Description"];
                    RecordsList.Add(objCGroups);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::GetList::Error! " + ex.Message, ex);
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
            command.CommandText = "dbo.[tblGroups_Exists]";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            try
            {
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int AreThereUsers()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();            
            command.CommandText = "dbo.tblGroups_CheckUsers";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;
            try
            {
                command.Parameters.Add(new SqlParameter("@id", _id));
                connection.Open();
                return (int)command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("CGroups::AreThereUsers::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int IsGroupExistant(bool blnNewRecord)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            if (blnNewRecord == true)
            {
                command.CommandText = "dbo.tblGroups_ExistsGroupNameNew";
                command.Parameters.Add(new SqlParameter("@GroupName", _groupName));
            }
            else
            {
                command.CommandText = "dbo.tblGroups_ExistsGroupNameUpdate";
                command.Parameters.Add(new SqlParameter("@id", _id));
                command.Parameters.Add(new SqlParameter("@GroupName", _groupName));
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
                throw new Exception("CGroups::IsGroupExistant::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public DataTable GetGroups()
        {
            string strSQL;
            strSQL = "Select id,GroupName from tblGroups";
            SqlDataAdapter DataAdapter = new SqlDataAdapter(strSQL, _ConnectionString);
            DataSet ds = new DataSet();
            DataAdapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }
    }

}
