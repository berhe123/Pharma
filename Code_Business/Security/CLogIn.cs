using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
//using System.Windows.Forms;
//using System.Collections;


namespace SecurityManager
{
    class CLogIn
       
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString; // Pharma.Properties.Settings.Default.ConnectionString;
            }
        }
        public CLogIn()
        {
            _ConnectionString = ConnectionString;
        }

        #region Property Declarations


        string _GroupName;
        public string GroupName
        {
            get {return _GroupName;}
            set {_GroupName = value;}
        }
        Int32 _UserAccessRight;
        public Int32 UserAccessRight
        {
            get{return _UserAccessRight;}
            set{_UserAccessRight = value;}
        }
        Int32 _GroupAccessRight;
        public Int32 GroupAccessRight
        {
            get{return _GroupAccessRight;}
            set{_GroupAccessRight = value;}
        }
        Int32 _user_id;
        public Int32 UserId
        {
            get { return _user_id; }
            set { _user_id = value; }
        }
        Int32 _user_application;
        public Int32 UserApplication
        {
            get { return _user_application; }
            set { _user_application = value; }
        }
        string _user_name;
        public string UserName
        {
            get { return _user_name; }
            set { _user_name = value; }
        }

        #endregion

        public bool LogIn(string strUserName, string strPassword)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            string strSQL = string.Empty;

            strSQL = "";
            strSQL = strSQL + " Select id,Userid,(Select tblGroups.GroupName From tblGroups Where id = GroupId) as GroupName, ";
            strSQL = strSQL + " AccessRight,(Select tblGroups.AccessRight From tblGroups Where id = GroupId) as GroupAccessRight ";
            strSQL = strSQL +  " From tblUsers Where userid = '" + strUserName + "'" ;
            strSQL = strSQL +  " And Password = '" + Convert.ToString(strPassword.GetHashCode()) + "'";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                
                dr.Read();
                if (dr.HasRows)
                {

                    if (!dr["GroupName"].Equals(DBNull.Value))
                        _GroupName= Convert.ToString(dr["GroupName"]);
                    if (!dr["AccessRight"].Equals(DBNull.Value))
                        _UserAccessRight = Convert.ToInt32(dr["AccessRight"]);
                    if (!dr["GroupAccessRight"].Equals(DBNull.Value))
                        _GroupAccessRight = Convert.ToInt32(dr["GroupAccessRight"]);
                    if (!dr["id"].Equals(DBNull.Value))
                         _user_id = Convert.ToInt32(dr["id"]);
                    if (!dr["Userid"].Equals(DBNull.Value))
                        _user_name = Convert.ToString(dr["Userid"]);
                    return true;
                }
                else
                {
                    throw new Exception("Invalid User Name or Password. ");
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }

        }
        public List<CLogIn> GetApplicationList(Int32 lngUserId)
        {
            List<CLogIn> RecordsList = new List<CLogIn>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select application_id from tblApplicationUsers Where user_id =" + lngUserId;
            command.CommandType = CommandType.Text;           
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLogIn objLogIn = new CLogIn();
                    if (dr["application_id"].Equals(DBNull.Value))
                        objLogIn.UserApplication = 0;
                    else
                        objLogIn.UserApplication = (int)dr["application_id"];

                    RecordsList.Add(objLogIn);
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
        public void DeleteNonPilotProjectArea()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);            
            SqlCommand command = new SqlCommand();
            SqlCommand command1 = new SqlCommand();
            string strSQL = "";
            string strSQL1 = "";
            strSQL = "Delete Zone where zone_name not in ('Jijiga','Shinile','Liben','Afeder','South Omo','Borena','East Harareghe','Bale','Zone 1','Zone 2','Zone 3','Zone 4','Zone 5')";
            strSQL1 = "Delete Woreda where woreda_name not in ('Babile','Afedem','Dolo Odo','Feltu','Bare','Dolo Baye','Dasenech', 'Ngangatom','Hammer','Arero','Chinaksan','Dawe Sere','Chifera','Berhaile','Awash Fentale','Gulina','Teru','Dewe') ";           
            command.CommandType = CommandType.Text;           
            command.Connection = connection;
            command1.CommandType = CommandType.Text;
            command1.Connection = connection;

            try
            {
                connection.Open();
                command.CommandText = strSQL;
                command.ExecuteNonQuery();
                command1.CommandText = strSQL1;
                command1.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                throw new Exception("CLogin::Delete Data::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();               
                if (command != null) command.Dispose();
            }
        }

    }
}
