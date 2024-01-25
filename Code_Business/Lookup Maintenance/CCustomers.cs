//
// ...
// Wizard generated code
// Date: 8/1/2009 10:54:49 AM
// Class: CCustomers
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
    class CCustomers
    {
        public static List<CCustomers> CustomersCollection = null;

        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CCustomers()
        {
            _ConnectionString = ConnectionString;
        }
        public CCustomers(int Id, string Name, string Mailingaddress, string Fax, string Tel1, string Tel2, string Email, string Contactname, string Contactfax, string Contacttel1, string Contacttel2, string Contactemail, string Tin, decimal Discount, decimal Creditlimit, string Customertypeguid, string Locationguid)
        {
            _Id = Id;
            _Name = Name;
            _MailingAddress = Mailingaddress;
            _Fax = Fax;
            _Tel1 = Tel1;
            _Tel2 = Tel2;
            _email = Email;
            _ContactName = Contactname;
            _ContactFax = Contactfax;
            _ContactTel1 = Contacttel1;
            _ContactTel2 = Contacttel2;
            _Contactemail = Contactemail;
            _Tin = Tin;
            _Discount = Discount;
            _CreditLimit = Creditlimit;
            _CustomerTypeGuid = Customertypeguid;
            _LocationGuid = Locationguid;
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

        decimal _Discount;
        public decimal Discount
        {
            get { return _Discount; }
            set { _Discount = value; }
        }

        decimal _CreditLimit;
        public decimal CreditLimit
        {
            get { return _CreditLimit; }
            set { _CreditLimit = value; }
        }

        string _CustomerTypeGuid;
        public string Customertypeguid
        {
            get { return _CustomerTypeGuid; }
            set { _CustomerTypeGuid = value; }
        }

        string _LocationGuid;
        public string Locationguid
        {
            get { return _LocationGuid; }
            set { _LocationGuid = value; }
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
            command.CommandText = "Select * from tblCustomers where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblCustomers");
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
                    if (dTable.Rows[0]["Email"].Equals(DBNull.Value))
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
                    if (dTable.Rows[0]["Discount"].Equals(DBNull.Value))
                        _Discount = 0;
                    else
                        _Discount = (decimal)dTable.Rows[0]["Discount"];
                    if (dTable.Rows[0]["CreditLimit"].Equals(DBNull.Value))
                        _CreditLimit = 0;
                    else
                        _CreditLimit = (decimal)dTable.Rows[0]["CreditLimit"];
                    if (dTable.Rows[0]["CustomerTypeGuid"].Equals(DBNull.Value))
                        _CustomerTypeGuid = string.Empty;
                    else
                        _CustomerTypeGuid = (string)dTable.Rows[0]["CustomerTypeGuid"];
                    if (dTable.Rows[0]["LocationGuid"].Equals(DBNull.Value))
                        _LocationGuid = string.Empty;
                    else
                        _LocationGuid = (string)dTable.Rows[0]["LocationGuid"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblCustomers";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblCustomers");
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
                throw new Exception("CCustomers::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblCustomers" +
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
                                   " Tin, " +
                                   " Discount, " +
                                   " CreditLimit, " +
                                   " CustomerTypeGuid, " +
                                   " LocationGuid,UserId,ComputerName,EventSource)" +
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
                                   " @Tin, " +
                                   " @Discount, " +
                                   " @CreditLimit, " +
                                   " @CustomerTypeGuid, " +
                                   " @LocationGuid,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblCustomers ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if(_Name== string.Empty)
                    command.Parameters.Add(new SqlParameter("@Name", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Name", _Name));
                if(_MailingAddress == string.Empty)
                    command.Parameters.Add(new SqlParameter("@MailingAddress", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@MailingAddress", _MailingAddress));
                if(_Fax == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Fax", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Fax", _Fax));
                if(_Tel1 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Tel1", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Tel1", _Tel1));
                if(_Tel2 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Tel2", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Tel2", _Tel2));
                if(_email == string.Empty)
                    command.Parameters.Add(new SqlParameter("@email", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@email", _email));
                if(_ContactName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactName", _ContactName));
                if(_ContactFax == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactFax", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactFax", _ContactFax));
                if(_ContactTel1 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactTel1", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactTel1", _ContactTel1));
                if(_ContactTel2 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactTel2", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactTel2", _ContactTel2));
                if(_Contactemail == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Contactemail", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Contactemail", _Contactemail));
                if(_Tin == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Tin", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Tin", _Tin));
                if(_Discount == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@Discount", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Discount", _Discount));
                if(_CreditLimit == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@CreditLimit", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CreditLimit", _CreditLimit));
                if (_CustomerTypeGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CustomerTypeGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CustomerTypeGuid", _CustomerTypeGuid));
                if(_LocationGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@LocationGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@LocationGuid", _LocationGuid));
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
                throw new Exception("CCustomers::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblCustomers" +
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
                                   " Tin = @Tin, " +
                                   " Discount = @Discount, " +
                                   " CreditLimit = @CreditLimit, " +
                                   " CustomerTypeGuid = @CustomerTypeGuid, " +
                                   " LocationGuid = @LocationGuid," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_Name == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Name", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Name", _Name));
                if (_MailingAddress == string.Empty)
                    command.Parameters.Add(new SqlParameter("@MailingAddress", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@MailingAddress", _MailingAddress));
                if (_Fax == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Fax", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Fax", _Fax));
                if (_Tel1 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Tel1", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Tel1", _Tel1));
                if (_Tel2 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Tel2", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Tel2", _Tel2));
                if (_email == string.Empty)
                    command.Parameters.Add(new SqlParameter("@email", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@email", _email));
                if (_ContactName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactName", _ContactName));
                if (_ContactFax == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactFax", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactFax", _ContactFax));
                if (_ContactTel1 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactTel1", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactTel1", _ContactTel1));
                if (_ContactTel2 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactTel2", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactTel2", _ContactTel2));
                if (_Contactemail == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Contactemail", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Contactemail", _Contactemail));
                if (_Tin == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Tin", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Tin", _Tin));
                if (_Discount == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@Discount", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Discount", _Discount));
                if (_CreditLimit == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@CreditLimit", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CreditLimit", _CreditLimit));
                if (_CustomerTypeGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CustomerTypeGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CustomerTypeGuid", _CustomerTypeGuid));
                if (_LocationGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@LocationGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@LocationGuid", _LocationGuid));

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
                throw new Exception("CCustomers::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblCustomers Where Id = @Id ";
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
                throw new Exception("CCustomers::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblCustomers] WHERE " +
                                       " Name = @Name";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblCustomers] WHERE " +
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
                throw new Exception("CCustomers::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Name, string Mailingaddress, string Fax, string Tel1, string Tel2, string Email, string Contactname, string Contactfax, string Contacttel1, string Contacttel2, string Contactemail, string Tin, decimal Discount, decimal Creditlimit, string Customertypeguid, string Locationguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblCustomers" +
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
                                   " Tin, " +
                                   " Discount, " +
                                   " CreditLimit, " +
                                   " CustomerTypeGuid, " +
                                   " LocationGuid)" +
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
                                   " @Tin, " +
                                   " @Discount, " +
                                   " @CreditLimit, " +
                                   " @CustomerTypeGuid, " +
                                   " @LocationGuid)" +
                                   " Select @Id=Max(id) from tblCustomers ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Name", Name));
                command.Parameters.Add(new SqlParameter("@MailingAddress", Mailingaddress));
                command.Parameters.Add(new SqlParameter("@Fax", Fax));
                command.Parameters.Add(new SqlParameter("@Tel1", Tel1));
                command.Parameters.Add(new SqlParameter("@Tel2", Tel2));
                command.Parameters.Add(new SqlParameter("@email", Email));
                command.Parameters.Add(new SqlParameter("@ContactName", Contactname));
                command.Parameters.Add(new SqlParameter("@ContactFax", Contactfax));
                command.Parameters.Add(new SqlParameter("@ContactTel1", Contacttel1));
                command.Parameters.Add(new SqlParameter("@ContactTel2", Contacttel2));
                command.Parameters.Add(new SqlParameter("@Contactemail", Contactemail));
                command.Parameters.Add(new SqlParameter("@Tin", Tin));
                command.Parameters.Add(new SqlParameter("@Discount", Discount));
                command.Parameters.Add(new SqlParameter("@CreditLimit", Creditlimit));
                command.Parameters.Add(new SqlParameter("@CustomerTypeGuid", Customertypeguid));
                command.Parameters.Add(new SqlParameter("@LocationGuid", Locationguid));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Name, string Mailingaddress, string Fax, string Tel1, string Tel2, string Email, string Contactname, string Contactfax, string Contacttel1, string Contacttel2, string Contactemail, string Tin, decimal Discount, decimal Creditlimit, string Customertypeguid, string Locationguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblCustomers" +
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
                                   " Tin = @Tin, " +
                                   " Discount = @Discount, " +
                                   " CreditLimit = @CreditLimit, " +
                                   " CustomerTypeGuid = @CustomerTypeGuid, " +
                                   " LocationGuid = @LocationGuid" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Name", Name));
                command.Parameters.Add(new SqlParameter("@MailingAddress", Mailingaddress));
                command.Parameters.Add(new SqlParameter("@Fax", Fax));
                command.Parameters.Add(new SqlParameter("@Tel1", Tel1));
                command.Parameters.Add(new SqlParameter("@Tel2", Tel2));
                command.Parameters.Add(new SqlParameter("@email", Email));
                command.Parameters.Add(new SqlParameter("@ContactName", Contactname));
                command.Parameters.Add(new SqlParameter("@ContactFax", Contactfax));
                command.Parameters.Add(new SqlParameter("@ContactTel1", Contacttel1));
                command.Parameters.Add(new SqlParameter("@ContactTel2", Contacttel2));
                command.Parameters.Add(new SqlParameter("@Contactemail", Contactemail));
                command.Parameters.Add(new SqlParameter("@Tin", Tin));
                command.Parameters.Add(new SqlParameter("@Discount", Discount));
                command.Parameters.Add(new SqlParameter("@CreditLimit", Creditlimit));
                command.Parameters.Add(new SqlParameter("@CustomerTypeGuid", Customertypeguid));
                command.Parameters.Add(new SqlParameter("@LocationGuid", Locationguid));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblCustomers Where Id = @Id ";
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
                throw new Exception("CCustomers::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Name)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblCustomers] WHERE " +
                                       " Name = @Name";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblCustomers] WHERE " +
                                       " Name = @Name " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
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
                throw new Exception("CCustomers::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CCustomers> GetList()
        {
            List<CCustomers> RecordsList = new List<CCustomers>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblCustomers order by [Name]";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CCustomers objCCustomers = new CCustomers();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCCustomers.Id = 0;
                    else
                        objCCustomers.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCCustomers.Name = string.Empty;
                    else
                        objCCustomers.Name = (string)dr["Name"];
                    if (dr["MailingAddress"].Equals(DBNull.Value))
                        objCCustomers.Mailingaddress = string.Empty;
                    else
                        objCCustomers.Mailingaddress = (string)dr["MailingAddress"];
                    if (dr["Fax"].Equals(DBNull.Value))
                        objCCustomers.Fax = string.Empty;
                    else
                        objCCustomers.Fax = (string)dr["Fax"];
                    if (dr["Tel1"].Equals(DBNull.Value))
                        objCCustomers.Tel1 = string.Empty;
                    else
                        objCCustomers.Tel1 = (string)dr["Tel1"];
                    if (dr["Tel2"].Equals(DBNull.Value))
                        objCCustomers.Tel2 = string.Empty;
                    else
                        objCCustomers.Tel2 = (string)dr["Tel2"];
                    if (dr["email"].Equals(DBNull.Value))
                        objCCustomers.Email = string.Empty;
                    else
                        objCCustomers.Email = (string)dr["email"];
                    if (dr["ContactName"].Equals(DBNull.Value))
                        objCCustomers.Contactname = string.Empty;
                    else
                        objCCustomers.Contactname = (string)dr["ContactName"];
                    if (dr["ContactFax"].Equals(DBNull.Value))
                        objCCustomers.Contactfax = string.Empty;
                    else
                        objCCustomers.Contactfax = (string)dr["ContactFax"];
                    if (dr["ContactTel1"].Equals(DBNull.Value))
                        objCCustomers.Contacttel1 = string.Empty;
                    else
                        objCCustomers.Contacttel1 = (string)dr["ContactTel1"];
                    if (dr["ContactTel2"].Equals(DBNull.Value))
                        objCCustomers.Contacttel2 = string.Empty;
                    else
                        objCCustomers.Contacttel2 = (string)dr["ContactTel2"];
                    if (dr["Contactemail"].Equals(DBNull.Value))
                        objCCustomers.Contactemail = string.Empty;
                    else
                        objCCustomers.Contactemail = (string)dr["Contactemail"];
                    if (dr["TIN"].Equals(DBNull.Value))
                        objCCustomers.TIN = string.Empty;
                    else
                        objCCustomers.TIN = (string)dr["TIN"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCCustomers.Discount = decimal.MinValue;
                    else
                        objCCustomers.Discount = (decimal)dr["Discount"];
                    if (dr["CreditLimit"].Equals(DBNull.Value))
                        objCCustomers.CreditLimit = decimal.MinValue;
                    else
                        objCCustomers.CreditLimit = (decimal)dr["CreditLimit"];
                    if (dr["CustomerTypeGuid"].Equals(DBNull.Value))
                        objCCustomers.Customertypeguid = string.Empty;
                    else
                        objCCustomers.Customertypeguid = (string)dr["CustomerTypeGuid"];
                    if (dr["LocationGuid"].Equals(DBNull.Value))
                        objCCustomers.Locationguid = string.Empty;
                    else
                        objCCustomers.Locationguid = (string)dr["LocationGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCCustomers.Tablerowguid = string.Empty;
                    else
                        objCCustomers.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCCustomers);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CCustomers> GetList(string strCriteria)
        {
            List<CCustomers> RecordsList = new List<CCustomers>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblCustomers Where 1=1 " + strCriteria + " Order by Name" ;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CCustomers objCCustomers = new CCustomers();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCCustomers.Id = 0;
                    else
                        objCCustomers.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCCustomers.Name = string.Empty;
                    else
                        objCCustomers.Name = (string)dr["Name"];
                    if (dr["MailingAddress"].Equals(DBNull.Value))
                        objCCustomers.Mailingaddress = string.Empty;
                    else
                        objCCustomers.Mailingaddress = (string)dr["MailingAddress"];
                    if (dr["Fax"].Equals(DBNull.Value))
                        objCCustomers.Fax = string.Empty;
                    else
                        objCCustomers.Fax = (string)dr["Fax"];
                    if (dr["Tel1"].Equals(DBNull.Value))
                        objCCustomers.Tel1 = string.Empty;
                    else
                        objCCustomers.Tel1 = (string)dr["Tel1"];
                    if (dr["Tel2"].Equals(DBNull.Value))
                        objCCustomers.Tel2 = string.Empty;
                    else
                        objCCustomers.Tel2 = (string)dr["Tel2"];
                    if (dr["email"].Equals(DBNull.Value))
                        objCCustomers.Email = string.Empty;
                    else
                        objCCustomers.Email = (string)dr["email"];
                    if (dr["ContactName"].Equals(DBNull.Value))
                        objCCustomers.Contactname = string.Empty;
                    else
                        objCCustomers.Contactname = (string)dr["ContactName"];
                    if (dr["ContactFax"].Equals(DBNull.Value))
                        objCCustomers.Contactfax = string.Empty;
                    else
                        objCCustomers.Contactfax = (string)dr["ContactFax"];
                    if (dr["ContactTel1"].Equals(DBNull.Value))
                        objCCustomers.Contacttel1 = string.Empty;
                    else
                        objCCustomers.Contacttel1 = (string)dr["ContactTel1"];
                    if (dr["ContactTel2"].Equals(DBNull.Value))
                        objCCustomers.Contacttel2 = string.Empty;
                    else
                        objCCustomers.Contacttel2 = (string)dr["ContactTel2"];
                    if (dr["Contactemail"].Equals(DBNull.Value))
                        objCCustomers.Contactemail = string.Empty;
                    else
                        objCCustomers.Contactemail = (string)dr["Contactemail"];
                    if (dr["TIN"].Equals(DBNull.Value))
                        objCCustomers.TIN = string.Empty;
                    else
                        objCCustomers.TIN = (string)dr["TIN"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCCustomers.Discount = decimal.Zero;
                    else
                        objCCustomers.Discount = (decimal)dr["Discount"];
                    if (dr["CreditLimit"].Equals(DBNull.Value))
                        objCCustomers.CreditLimit = decimal.Zero;
                    else
                        objCCustomers.CreditLimit = (decimal)dr["CreditLimit"];
                    if (dr["CustomerTypeGuid"].Equals(DBNull.Value))
                        objCCustomers.Customertypeguid = string.Empty;
                    else
                        objCCustomers.Customertypeguid = (string)dr["CustomerTypeGuid"];
                    if (dr["LocationGuid"].Equals(DBNull.Value))
                        objCCustomers.Locationguid = string.Empty;
                    else
                        objCCustomers.Locationguid = (string)dr["LocationGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCCustomers.Tablerowguid = string.Empty;
                    else
                        objCCustomers.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCCustomers);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public string GetCustomerName(string Customerguid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT name FROM [dbo].[tblCustomers] WHERE [TableRowGuid] = @CustomerGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                connection.Open();
                return (string)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CUnits::GetCustomerName::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public decimal GetCustomerDiscountRate(string Customerguid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT Discount = Isnull(Discount, 0) FROM [dbo].[tblCustomers] WHERE [TableRowGuid] = @CustomerGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                connection.Open();
                object tmp = command.ExecuteScalar();
                if (tmp != null)
                    return (decimal)tmp;
                else
                    return 0;
            }
            catch (Exception ex)
            {
                throw new Exception("CUnits::GetCustomerDiscountRate::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        // Collection Utilities
        public static void LoadCustomersToCollection()
        {
            List<CCustomers> RecordsList = new List<CCustomers>();
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblCustomers";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CCustomers objCCustomers = new CCustomers();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCCustomers.Id = 0;
                    else
                        objCCustomers.Id = (int)dr["Id"];
                    if (dr["Name"].Equals(DBNull.Value))
                        objCCustomers.Name = string.Empty;
                    else
                        objCCustomers.Name = (string)dr["Name"];
                    if (dr["MailingAddress"].Equals(DBNull.Value))
                        objCCustomers.Mailingaddress = string.Empty;
                    else
                        objCCustomers.Mailingaddress = (string)dr["MailingAddress"];
                    if (dr["Fax"].Equals(DBNull.Value))
                        objCCustomers.Fax = string.Empty;
                    else
                        objCCustomers.Fax = (string)dr["Fax"];
                    if (dr["Tel1"].Equals(DBNull.Value))
                        objCCustomers.Tel1 = string.Empty;
                    else
                        objCCustomers.Tel1 = (string)dr["Tel1"];
                    if (dr["Tel2"].Equals(DBNull.Value))
                        objCCustomers.Tel2 = string.Empty;
                    else
                        objCCustomers.Tel2 = (string)dr["Tel2"];
                    if (dr["email"].Equals(DBNull.Value))
                        objCCustomers.Email = string.Empty;
                    else
                        objCCustomers.Email = (string)dr["email"];
                    if (dr["ContactName"].Equals(DBNull.Value))
                        objCCustomers.Contactname = string.Empty;
                    else
                        objCCustomers.Contactname = (string)dr["ContactName"];
                    if (dr["ContactFax"].Equals(DBNull.Value))
                        objCCustomers.Contactfax = string.Empty;
                    else
                        objCCustomers.Contactfax = (string)dr["ContactFax"];
                    if (dr["ContactTel1"].Equals(DBNull.Value))
                        objCCustomers.Contacttel1 = string.Empty;
                    else
                        objCCustomers.Contacttel1 = (string)dr["ContactTel1"];
                    if (dr["ContactTel2"].Equals(DBNull.Value))
                        objCCustomers.Contacttel2 = string.Empty;
                    else
                        objCCustomers.Contacttel2 = (string)dr["ContactTel2"];
                    if (dr["Contactemail"].Equals(DBNull.Value))
                        objCCustomers.Contactemail = string.Empty;
                    else
                        objCCustomers.Contactemail = (string)dr["Contactemail"];
                    if (dr["TIN"].Equals(DBNull.Value))
                        objCCustomers.TIN = string.Empty;
                    else
                        objCCustomers.TIN = (string)dr["TIN"];
                    if (dr["Discount"].Equals(DBNull.Value))
                        objCCustomers.Discount = 0;
                    else
                        objCCustomers.Discount = (decimal)dr["Discount"];
                    if (dr["CreditLimit"].Equals(DBNull.Value))
                        objCCustomers.CreditLimit = 0;
                    else
                        objCCustomers.CreditLimit = (decimal)dr["CreditLimit"];
                    if (dr["CustomerTypeGuid"].Equals(DBNull.Value))
                        objCCustomers.Customertypeguid = string.Empty;
                    else
                        objCCustomers.Customertypeguid = (string)dr["CustomerTypeGuid"];
                    if (dr["LocationGuid"].Equals(DBNull.Value))
                        objCCustomers.Locationguid = string.Empty;
                    else
                        objCCustomers.Locationguid = (string)dr["LocationGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCCustomers.Tablerowguid = string.Empty;
                    else
                        objCCustomers.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCCustomers);
                }

                CustomersCollection = RecordsList;
                //return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public static string GetCustomerNameFromCollection(string Customerguid)
        {
            string strName = string.Empty;
            try
            {
                ArrayList ar = new ArrayList(CustomersCollection);
                if (ar.Count < 0) return string.Empty;

                foreach (CCustomers app in ar)
                {
                    if (Customerguid == app.Tablerowguid)
                    {
                        strName = app.Name;
                        break;
                    }
                }
                return strName;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::GetCustomerNameFromCollection::Error! " + ex.Message, ex);
            }
        }
        public static decimal GetCustomerDiscountRateFromCollection(string Customerguid)
        {
            decimal decDiscount = 0;
            try
            {
                ArrayList ar = new ArrayList(CustomersCollection);
                if (ar.Count < 0) return 0;

                foreach (CCustomers app in ar)
                {
                    if (Customerguid == app.Tablerowguid)
                    {
                        decDiscount = app.Discount;
                        break;
                    }
                }
                return decDiscount;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::GetCustomerDiscountRateFromCollection::Error! " + ex.Message, ex);
            }
        }

        public static CCustomers FindCustomerFromCollection(string Customerguid)
        {
            CCustomers cus = null;
            try
            {
                ArrayList ar = new ArrayList(CustomersCollection);
                if (ar.Count < 0) return null;

                foreach (CCustomers app in ar)
                {
                    if (Customerguid == app.Tablerowguid)
                    {
                        cus = app;
                        break;
                    }
                }
                return cus;
            }
            catch (Exception ex)
            {
                throw new Exception("CCustomers::FindCustomerFromCollection::Error! " + ex.Message, ex);
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblCustomers] WHERE Id = @Id";
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
                throw new Exception("CCustomers::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblCustomers] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CCustomers::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
