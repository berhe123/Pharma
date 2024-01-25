//
// ...
// Wizard generated code
// Date: 7/20/2009 3:14:30 PM
// Class: CManufacturers
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
    class CManufacturers
    {
        public static List<CManufacturers> ManufacturersCollection = null;

        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CManufacturers()
        {
            _ConnectionString = ConnectionString;
        }        

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        string _MailingAddress;
        public string Mailingaddress
        {
            get { return _MailingAddress; }
            set { _MailingAddress = value; }
        }

        string _Fax;
        public string Fax
        {
            get { return _Fax; }
            set { _Fax = value; }
        }

        string _Tel1;
        public string Tel1
        {
            get { return _Tel1; }
            set { _Tel1 = value; }
        }

        string _Tel2;
        public string Tel2
        {
            get { return _Tel2; }
            set { _Tel2 = value; }
        }

        string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        string _ContactName;
        public string Contactname
        {
            get { return _ContactName; }
            set { _ContactName = value; }
        }

        string _ContactFax;
        public string Contactfax
        {
            get { return _ContactFax; }
            set { _ContactFax = value; }
        }

        string _ContactTel1;
        public string Contacttel1
        {
            get { return _ContactTel1; }
            set { _ContactTel1 = value; }
        }

        string _ContactTel2;
        public string Contacttel2
        {
            get { return _ContactTel2; }
            set { _ContactTel2 = value; }
        }

        string _Contactemail;
        public string Contactemail
        {
            get { return _Contactemail; }
            set { _Contactemail = value; }
        }
        
        string _Tin;
        public string TIN
        {
            get { return _Tin; }
            set { _Tin = value; }
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
            command.CommandText = "Select * from tblManufacturers where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblManufacturers");
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
                    if (dTable.Rows[0]["Name"].Equals(DBNull.Value))
                        _Name = string.Empty;
                    else
                        _Name = (string)dTable.Rows[0]["Name"];
                    if (dTable.Rows[0]["MailingAddress"].Equals(DBNull.Value))
                        _MailingAddress = string.Empty;
                    else
                        _MailingAddress = (string)dTable.Rows[0]["MailingAddress"];
                    if (dTable.Rows[0]["Fax"].Equals(DBNull.Value))
                        _Fax = string.Empty;
                    else
                        _Fax = (string)dTable.Rows[0]["Fax"];
                    if (dTable.Rows[0]["Tel1"].Equals(DBNull.Value))
                        _Tel1 = string.Empty;
                    else
                        _Tel1 = (string)dTable.Rows[0]["Tel1"];
                    if (dTable.Rows[0]["Tel2"].Equals(DBNull.Value))
                        _Tel2 = string.Empty;
                    else
                        _Tel2 = (string)dTable.Rows[0]["Tel2"];
                    if (dTable.Rows[0]["email"].Equals(DBNull.Value))
                        _email = string.Empty;
                    else
                        _email = (string)dTable.Rows[0]["email"];
                    if (dTable.Rows[0]["ContactName"].Equals(DBNull.Value))
                        _ContactName = string.Empty;
                    else
                        _ContactName = (string)dTable.Rows[0]["ContactName"];
                    if (dTable.Rows[0]["ContactFax"].Equals(DBNull.Value))
                        _ContactFax = string.Empty;
                    else
                        _ContactFax = (string)dTable.Rows[0]["ContactFax"];
                    if (dTable.Rows[0]["ContactTel1"].Equals(DBNull.Value))
                        _ContactTel1 = string.Empty;
                    else
                        _ContactTel1 = (string)dTable.Rows[0]["ContactTel1"];
                    if (dTable.Rows[0]["ContactTel2"].Equals(DBNull.Value))
                        _ContactTel2 = string.Empty;
                    else
                        _ContactTel2 = (string)dTable.Rows[0]["ContactTel2"];
                    if (dTable.Rows[0]["Contactemail"].Equals(DBNull.Value))
                        _Contactemail = string.Empty;
                    else
                        _Contactemail = (string)dTable.Rows[0]["Contactemail"];
                    
                    if (dTable.Rows[0]["TIN"].Equals(DBNull.Value))
                        _Tin = string.Empty;
                    else
                        _Tin = (string)dTable.Rows[0]["TIN"];
                    
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];

                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturers::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblManufacturers";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblManufacturers");
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
                throw new Exception("CManufacturers::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblManufacturers" +
                                   " (Name, " +
                                   " MailingAddress, " +
                                   " Fax, " +
                                   " Tel1, " +
                                   " Tel2, " +
                                   " email, " +
                                   " ContactName, " +
                                   " ContactFax, " +
                                   " ContactTel1, " +
                                   " ContactTel2, " +
                                   " Contactemail, " +                                                            
                                   " Tin)" +
                                   " Values (@Name, " +
                                   " @MailingAddress, " +
                                   " @Fax, " +
                                   " @Tel1, " +
                                   " @Tel2, " +
                                   " @email, " +
                                   " @ContactName, " +
                                   " @ContactFax, " +
                                   " @ContactTel1, " +
                                   " @ContactTel2, " +
                                   " @Contactemail, " +                                                                
                                   " @Tin)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Name", _Name));
                command.Parameters.Add(new SqlParameter("@MailingAddress", _MailingAddress));
                command.Parameters.Add(new SqlParameter("@Fax", _Fax));
                command.Parameters.Add(new SqlParameter("@Tel1", _Tel1));
                command.Parameters.Add(new SqlParameter("@Tel2", _Tel2));
                command.Parameters.Add(new SqlParameter("@email", _email));
                command.Parameters.Add(new SqlParameter("@ContactName", _ContactName));
                command.Parameters.Add(new SqlParameter("@ContactFax", _ContactFax));
                command.Parameters.Add(new SqlParameter("@ContactTel1", _ContactTel1));
                command.Parameters.Add(new SqlParameter("@ContactTel2", _ContactTel2));
                command.Parameters.Add(new SqlParameter("@Contactemail", _Contactemail));              
                command.Parameters.Add(new SqlParameter("@Tin", _Tin));                
                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturers::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblManufacturers" +
                                   " Set Name = @Name, " +
                                   " MailingAddress = @MailingAddress, " +
                                   " Fax = @Fax, " +
                                   " Tel1 = @Tel1, " +
                                   " Tel2 = @Tel2, " +
                                   " email = @email, " +
                                   " ContactName = @ContactName, " +
                                   " ContactFax = @ContactFax, " +
                                   " ContactTel1 = @ContactTel1, " +
                                   " ContactTel2 = @ContactTel2, " +
                                   " Contactemail = @Contactemail, " +                                   
                                   " Tin = @Tin," +                                  
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Name", _Name));
                command.Parameters.Add(new SqlParameter("@MailingAddress", _MailingAddress));
                command.Parameters.Add(new SqlParameter("@Fax", _Fax));
                command.Parameters.Add(new SqlParameter("@Tel1", _Tel1));
                command.Parameters.Add(new SqlParameter("@Tel2", _Tel2));
                command.Parameters.Add(new SqlParameter("@email", _email));
                command.Parameters.Add(new SqlParameter("@ContactName", _ContactName));
                command.Parameters.Add(new SqlParameter("@ContactFax", _ContactFax));
                command.Parameters.Add(new SqlParameter("@ContactTel1", _ContactTel1));
                command.Parameters.Add(new SqlParameter("@ContactTel2", _ContactTel2));
                command.Parameters.Add(new SqlParameter("@Contactemail", _Contactemail));                
                command.Parameters.Add(new SqlParameter("@Tin", _Tin));                

                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturers::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblManufacturers Where Id = @Id ";
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
                throw new Exception("CManufacturers::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturers] WHERE " +
                                       " Name = @Name";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturers] WHERE " +
                                       " Name = @Name " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
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
                throw new Exception("CManufacturers::Exists::Error! " + ex.Message, ex);
            }
            finally


            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CManufacturers> GetList()
        {
            List<CManufacturers> RecordsList = new List<CManufacturers>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblManufacturers";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturers objCManufacturers = new CManufacturers();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturers.Id = 0;
                    else
                        objCManufacturers.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCManufacturers.Name = string.Empty;
                    else
                        objCManufacturers.Name = (string)dr["Name"];
                    if (dr["MailingAddress"].Equals(DBNull.Value))
                        objCManufacturers.Mailingaddress = string.Empty;
                    else
                        objCManufacturers.Mailingaddress = (string)dr["MailingAddress"];
                    if (dr["Fax"].Equals(DBNull.Value))
                        objCManufacturers.Fax = string.Empty;
                    else
                        objCManufacturers.Fax = (string)dr["Fax"];
                    if (dr["Tel1"].Equals(DBNull.Value))
                        objCManufacturers.Tel1 = string.Empty;
                    else
                        objCManufacturers.Tel1 = (string)dr["Tel1"];
                    if (dr["Tel2"].Equals(DBNull.Value))
                        objCManufacturers.Tel2 = string.Empty;
                    else
                        objCManufacturers.Tel2 = (string)dr["Tel2"];
                    if (dr["email"].Equals(DBNull.Value))
                        objCManufacturers.Email = string.Empty;
                    else
                        objCManufacturers.Email = (string)dr["email"];
                    if (dr["ContactName"].Equals(DBNull.Value))
                        objCManufacturers.Contactname = string.Empty;
                    else
                        objCManufacturers.Contactname = (string)dr["ContactName"];
                    if (dr["ContactFax"].Equals(DBNull.Value))
                        objCManufacturers.Contactfax = string.Empty;
                    else
                        objCManufacturers.Contactfax = (string)dr["ContactFax"];
                    if (dr["ContactTel1"].Equals(DBNull.Value))
                        objCManufacturers.Contacttel1 = string.Empty;
                    else
                        objCManufacturers.Contacttel1 = (string)dr["ContactTel1"];
                    if (dr["ContactTel2"].Equals(DBNull.Value))
                        objCManufacturers.Contacttel2 = string.Empty;
                    else
                        objCManufacturers.Contacttel2 = (string)dr["ContactTel2"];
                    if (dr["Contactemail"].Equals(DBNull.Value))
                        objCManufacturers.Contactemail = string.Empty;
                    else
                        objCManufacturers.Contactemail = (string)dr["Contactemail"];                   
                    if (dr["TIN"].Equals(DBNull.Value))
                        objCManufacturers.TIN = string.Empty;
                    else
                        objCManufacturers.TIN = (string)dr["TIN"];
                    
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturers.Tablerowguid = string.Empty;
                    else
                        objCManufacturers.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturers);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CManufacturers> GetList(string strNameLike)
        {
            List<CManufacturers> RecordsList = new List<CManufacturers>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblManufacturers where Name like @NameLike";
            command.Parameters.Add(new SqlParameter("@NameLike", strNameLike));
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturers objCManufacturers = new CManufacturers();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturers.Id = 0;
                    else
                        objCManufacturers.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCManufacturers.Name = string.Empty;
                    else
                        objCManufacturers.Name = (string)dr["Name"];
                    if (dr["MailingAddress"].Equals(DBNull.Value))
                        objCManufacturers.Mailingaddress = string.Empty;
                    else
                        objCManufacturers.Mailingaddress = (string)dr["MailingAddress"];
                    if (dr["Fax"].Equals(DBNull.Value))
                        objCManufacturers.Fax = string.Empty;
                    else
                        objCManufacturers.Fax = (string)dr["Fax"];
                    if (dr["Tel1"].Equals(DBNull.Value))
                        objCManufacturers.Tel1 = string.Empty;
                    else
                        objCManufacturers.Tel1 = (string)dr["Tel1"];
                    if (dr["Tel2"].Equals(DBNull.Value))
                        objCManufacturers.Tel2 = string.Empty;
                    else
                        objCManufacturers.Tel2 = (string)dr["Tel2"];
                    if (dr["email"].Equals(DBNull.Value))
                        objCManufacturers.Email = string.Empty;
                    else
                        objCManufacturers.Email = (string)dr["email"];
                    if (dr["ContactName"].Equals(DBNull.Value))
                        objCManufacturers.Contactname = string.Empty;
                    else
                        objCManufacturers.Contactname = (string)dr["ContactName"];
                    if (dr["ContactFax"].Equals(DBNull.Value))
                        objCManufacturers.Contactfax = string.Empty;
                    else
                        objCManufacturers.Contactfax = (string)dr["ContactFax"];
                    if (dr["ContactTel1"].Equals(DBNull.Value))
                        objCManufacturers.Contacttel1 = string.Empty;
                    else
                        objCManufacturers.Contacttel1 = (string)dr["ContactTel1"];
                    if (dr["ContactTel2"].Equals(DBNull.Value))
                        objCManufacturers.Contacttel2 = string.Empty;
                    else
                        objCManufacturers.Contacttel2 = (string)dr["ContactTel2"];
                    if (dr["Contactemail"].Equals(DBNull.Value))
                        objCManufacturers.Contactemail = string.Empty;
                    else
                        objCManufacturers.Contactemail = (string)dr["Contactemail"];                                     
                    if (dr["TIN"].Equals(DBNull.Value))
                        objCManufacturers.TIN = string.Empty;
                    else
                        objCManufacturers.TIN = (string)dr["TIN"];
                    
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturers.Tablerowguid = string.Empty;
                    else
                        objCManufacturers.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturers);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CManufacturers> GetList(string strNameLike, int intSupplierType)
        {
            List<CManufacturers> RecordsList = new List<CManufacturers>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblManufacturers where SupplierType=@SupplierType And Name like @NameLike";
            command.Parameters.Add(new SqlParameter("@NameLike", strNameLike));
            command.Parameters.Add(new SqlParameter("@SupplierType", intSupplierType));
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturers objCManufacturers = new CManufacturers();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturers.Id = 0;
                    else
                        objCManufacturers.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCManufacturers.Name = string.Empty;
                    else
                        objCManufacturers.Name = (string)dr["Name"];
                    if (dr["MailingAddress"].Equals(DBNull.Value))
                        objCManufacturers.Mailingaddress = string.Empty;
                    else
                        objCManufacturers.Mailingaddress = (string)dr["MailingAddress"];
                    if (dr["Fax"].Equals(DBNull.Value))
                        objCManufacturers.Fax = string.Empty;
                    else
                        objCManufacturers.Fax = (string)dr["Fax"];
                    if (dr["Tel1"].Equals(DBNull.Value))
                        objCManufacturers.Tel1 = string.Empty;
                    else
                        objCManufacturers.Tel1 = (string)dr["Tel1"];
                    if (dr["Tel2"].Equals(DBNull.Value))
                        objCManufacturers.Tel2 = string.Empty;
                    else
                        objCManufacturers.Tel2 = (string)dr["Tel2"];
                    if (dr["email"].Equals(DBNull.Value))
                        objCManufacturers.Email = string.Empty;
                    else
                        objCManufacturers.Email = (string)dr["email"];
                    if (dr["ContactName"].Equals(DBNull.Value))
                        objCManufacturers.Contactname = string.Empty;
                    else
                        objCManufacturers.Contactname = (string)dr["ContactName"];
                    if (dr["ContactFax"].Equals(DBNull.Value))
                        objCManufacturers.Contactfax = string.Empty;
                    else
                        objCManufacturers.Contactfax = (string)dr["ContactFax"];
                    if (dr["ContactTel1"].Equals(DBNull.Value))
                        objCManufacturers.Contacttel1 = string.Empty;
                    else
                        objCManufacturers.Contacttel1 = (string)dr["ContactTel1"];
                    if (dr["ContactTel2"].Equals(DBNull.Value))
                        objCManufacturers.Contacttel2 = string.Empty;
                    else
                        objCManufacturers.Contacttel2 = (string)dr["ContactTel2"];
                    if (dr["Contactemail"].Equals(DBNull.Value))
                        objCManufacturers.Contactemail = string.Empty;
                    else
                        objCManufacturers.Contactemail = (string)dr["Contactemail"];                                    
                    if (dr["TIN"].Equals(DBNull.Value))
                        objCManufacturers.TIN = string.Empty;
                    else
                        objCManufacturers.TIN = (string)dr["TIN"];                    
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturers.Tablerowguid = string.Empty;
                    else
                        objCManufacturers.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturers);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public string GetManufacturerName(string Manufacturerguid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT name FROM [dbo].[tblManufacturers] WHERE [TableRowGuid] = @ManufacturerGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                connection.Open();
                return (string)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CUnits::GetManufacturerName::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        // Collection Utilities
        public static void LoadManufacturersToCollection()
        {
            List<CManufacturers> RecordsList = new List<CManufacturers>();
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblManufacturers";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturers objCManufacturers = new CManufacturers();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturers.Id = 0;
                    else
                        objCManufacturers.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCManufacturers.Name = string.Empty;
                    else
                        objCManufacturers.Name = (string)dr["Name"];
                    if (dr["MailingAddress"].Equals(DBNull.Value))
                        objCManufacturers.Mailingaddress = string.Empty;
                    else
                        objCManufacturers.Mailingaddress = (string)dr["MailingAddress"];
                    if (dr["Fax"].Equals(DBNull.Value))
                        objCManufacturers.Fax = string.Empty;
                    else
                        objCManufacturers.Fax = (string)dr["Fax"];
                    if (dr["Tel1"].Equals(DBNull.Value))
                        objCManufacturers.Tel1 = string.Empty;
                    else
                        objCManufacturers.Tel1 = (string)dr["Tel1"];
                    if (dr["Tel2"].Equals(DBNull.Value))
                        objCManufacturers.Tel2 = string.Empty;
                    else
                        objCManufacturers.Tel2 = (string)dr["Tel2"];
                    if (dr["email"].Equals(DBNull.Value))
                        objCManufacturers.Email = string.Empty;
                    else
                        objCManufacturers.Email = (string)dr["email"];
                    if (dr["ContactName"].Equals(DBNull.Value))
                        objCManufacturers.Contactname = string.Empty;
                    else
                        objCManufacturers.Contactname = (string)dr["ContactName"];
                    if (dr["ContactFax"].Equals(DBNull.Value))
                        objCManufacturers.Contactfax = string.Empty;
                    else
                        objCManufacturers.Contactfax = (string)dr["ContactFax"];
                    if (dr["ContactTel1"].Equals(DBNull.Value))
                        objCManufacturers.Contacttel1 = string.Empty;
                    else
                        objCManufacturers.Contacttel1 = (string)dr["ContactTel1"];
                    if (dr["ContactTel2"].Equals(DBNull.Value))
                        objCManufacturers.Contacttel2 = string.Empty;
                    else
                        objCManufacturers.Contacttel2 = (string)dr["ContactTel2"];
                    if (dr["Contactemail"].Equals(DBNull.Value))
                        objCManufacturers.Contactemail = string.Empty;
                    else
                        objCManufacturers.Contactemail = (string)dr["Contactemail"];                                     
                    if (dr["TIN"].Equals(DBNull.Value))
                        objCManufacturers.TIN = string.Empty;
                    else
                        objCManufacturers.TIN = (string)dr["TIN"];                    
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturers.Tablerowguid = string.Empty;
                    else
                        objCManufacturers.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturers);
                }

                ManufacturersCollection = RecordsList;
                //return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public static string GetManufacturerNameFromCollection(string Manufacturerguid)
        {
            string strName = string.Empty;
            try
            {
                ArrayList ar = new ArrayList(ManufacturersCollection);
                if (ar.Count < 0) return string.Empty;

                foreach (CManufacturers app in ar)
                {
                    if (Manufacturerguid == app.Tablerowguid)
                    {
                        strName = app.Name;
                        break;
                    }
                }
                return strName;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturers::GetManufacturerNameFromCollection::Error! " + ex.Message, ex);
            }
        }
        public static CManufacturers FindManufacturerFromCollection(string Manufacturerguid)
        {
            CManufacturers man = null;
            try
            {
                ArrayList ar = new ArrayList(ManufacturersCollection);
                if (ar.Count < 0) return null;

                foreach (CManufacturers app in ar)
                {
                    if (Manufacturerguid == app.Tablerowguid)
                    {
                        man = app;
                        break;
                    }
                }
                return man;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturers::FindManufacturerFromCollection::Error! " + ex.Message, ex);
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblManufacturers] WHERE Id = @Id";
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
                throw new Exception("CManufacturers::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblManufacturers] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CManufacturers::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
