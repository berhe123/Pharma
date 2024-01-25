//
// ...
// Wizard generated code
// Date: 11/13/2009 12:41:18 PM
// Class: CDrugRegistrationFeePaymentRequestCertificates
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
    class CDrugRegistrationFeePaymentRequestCertificates
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CDrugRegistrationFeePaymentRequestCertificates()
        {
            _ConnectionString = ConnectionString;
        }
        public CDrugRegistrationFeePaymentRequestCertificates(int Id, string Drugregistrationfeepaymentrequestguid, string Drugregistrationcertificateguid, decimal Amount)
        {
            _Id = Id;
            _DrugRegistrationFeePaymentRequestGuid = Drugregistrationfeepaymentrequestguid;
            _DrugRegistrationCertificateGuid = Drugregistrationcertificateguid;
            _Amount = Amount;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _DrugRegistrationFeePaymentRequestGuid;
        public string Drugregistrationfeepaymentrequestguid
        {
            get { return _DrugRegistrationFeePaymentRequestGuid; }
            set { _DrugRegistrationFeePaymentRequestGuid = value; }
        }

        string _DrugRegistrationCertificateGuid;
        public string Drugregistrationcertificateguid
        {
            get { return _DrugRegistrationCertificateGuid; }
            set { _DrugRegistrationCertificateGuid = value; }
        }

        decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        string _CertificateNumber;
        public string Certificatenumber
        {
            get { return _CertificateNumber; }
            set { _CertificateNumber = value; }
        }

        string _ProductName;
        public string Productname
        {
            get { return _ProductName; }
            set { _ProductName = value; }
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
            command.CommandText = "Select * from tblDrugRegistrationFeePaymentRequestCertificates where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeePaymentRequestCertificates");
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
                    if (dTable.Rows[0]["DrugRegistrationFeePaymentRequestId"].Equals(DBNull.Value))
                        _DrugRegistrationFeePaymentRequestGuid = string.Empty;
                    else
                        _DrugRegistrationFeePaymentRequestGuid = (string)dTable.Rows[0]["DrugRegistrationFeePaymentRequestGuid"];
                    if (dTable.Rows[0]["DrugRegistrationCertificateGuid"].Equals(DBNull.Value))
                        _DrugRegistrationCertificateGuid = string.Empty;
                    else
                        _DrugRegistrationCertificateGuid = (string)dTable.Rows[0]["DrugRegistrationCertificateGuid"];
                    if (dTable.Rows[0]["Amount"].Equals(DBNull.Value))
                        _Amount = 0;
                    else
                        _Amount = (decimal)dTable.Rows[0]["Amount"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
                adapter.Dispose();
            }
        }
        public DataTable GetRecords()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationFeePaymentRequestCertificates";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeePaymentRequestCertificates");
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
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
                adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Drugregistrationfeepaymentrequestguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationFeePaymentRequestCertificates where DrugRegistrationFeePaymentRequestGuid=@DrugRegistrationFeePaymentRequestGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeePaymentRequestCertificates");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeePaymentRequestGuid", Drugregistrationfeepaymentrequestguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
                adapter.Dispose();
            }
        }

        public bool Insert()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblDrugRegistrationFeePaymentRequestCertificates" +
                                   " (DrugRegistrationFeePaymentRequestGuid, " +
                                   " DrugRegistrationCertificateGuid, " +
                                   " Amount,UserId,ComputerName,EventSource)" +
                                   " Values (@DrugRegistrationFeePaymentRequestGuid, " +
                                   " @DrugRegistrationCertificateGuid, " +
                                   " @Amount,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id= Max(Id) from tblDrugRegistrationFeePaymentRequestCertificates ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeePaymentRequestGuid", _DrugRegistrationFeePaymentRequestGuid));
                command.Parameters.Add(new SqlParameter("@DrugRegistrationCertificateGuid", _DrugRegistrationCertificateGuid));
                command.Parameters.Add(new SqlParameter("@Amount", _Amount));

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
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Update()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblDrugRegistrationFeePaymentRequestCertificates" +
                                   " Set DrugRegistrationFeePaymentRequestGuid = @DrugRegistrationFeePaymentRequestGuid, " +
                                   " DrugRegistrationCertificateGuid = @DrugRegistrationCertificateGuid, " +
                                   " Amount = @Amount," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeePaymentRequestGuid", _DrugRegistrationFeePaymentRequestGuid));
                command.Parameters.Add(new SqlParameter("@DrugRegistrationCertificateGuid", _DrugRegistrationCertificateGuid));
                command.Parameters.Add(new SqlParameter("@Amount", _Amount));

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
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Delete()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblDrugRegistrationFeePaymentRequestCertificates Where Id = @Id ";
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
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public int Exists(bool bNew)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequestCertificates] WHERE " +
                                       " DrugRegistrationCertificateGuid = @DrugRegistrationCertificateGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequestCertificates] WHERE " +
                                       " DrugRegistrationCertificateGuid = @DrugRegistrationCertificateGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationCertificateGuid", _DrugRegistrationCertificateGuid));
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
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public bool Insert(int Id, string Drugregistrationfeepaymentrequestguid, string Drugregistrationcertificateguid, decimal Amount)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblDrugRegistrationFeePaymentRequestCertificates" +
                                   " (DrugRegistrationFeePaymentRequestGuid, " +
                                   " DrugRegistrationCertificateGuid, " +
                                   " Amount)" +
                                   " Values (@DrugRegistrationFeePaymentRequestGuid, " +
                                   " @DrugRegistrationCertificateGuid, " +
                                   " @Amount)" +
                                   " Select @Id=Max(id) from tblDrugRegistrationFeePaymentRequestCertificates  ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeePaymentRequestGuid", Drugregistrationfeepaymentrequestguid));
                command.Parameters.Add(new SqlParameter("@DrugRegistrationCertificateGuid", Drugregistrationcertificateguid));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Update(int Id, string Drugregistrationfeepaymentrequestguid, string Drugregistrationcertificateguid, decimal Amount)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblDrugRegistrationFeePaymentRequestCertificates" +
                                   " Set DrugRegistrationFeePaymentRequestGuid = @DrugRegistrationFeePaymentRequestGuid, " +
                                   " DrugRegistrationCertificateGuid = @DrugRegistrationCertificateGuid, " +
                                   " Amount = @Amount" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeePaymentRequestGuid", Drugregistrationfeepaymentrequestguid));
                command.Parameters.Add(new SqlParameter("@DrugRegistrationCertificateGuid", Drugregistrationcertificateguid));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Delete(int Id)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Delete From tblDrugRegistrationFeePaymentRequestCertificates Where Id = @Id ";
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
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Drugregistrationcertificateguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequestCertificates] WHERE " +
                                       " DrugRegistrationCertificateGuid = @DrugRegistrationCertificateGuid ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequestCertificates] WHERE " +
                                       " DrugRegistrationCertificateGuid = @DrugRegistrationCertificateGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationCertificateGuid", Drugregistrationcertificateguid));
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
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public List<CDrugRegistrationFeePaymentRequestCertificates> GetList()
        {
            List<CDrugRegistrationFeePaymentRequestCertificates> RecordsList = new List<CDrugRegistrationFeePaymentRequestCertificates>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select tblDrugRegistrationFeePaymentRequestCertificates.*, ";
            command.CommandText += " tblProducts.BrandName + ' ' + tblProducts.GenericName AS ProductName, ";
            command.CommandText += " tblProductRegistrationCertificates.RegistrationNumber AS CertificateNumber ";
            command.CommandText += " from tblDrugRegistrationFeePaymentRequestCertificates Join ";
            command.CommandText += " tblProductRegistrationCertificates ON tblProductRegistrationCertificates.TableRowGuid = tblDrugRegistrationFeePaymentRequestCertificates.DrugRegistrationCertificateGuid ";
            command.CommandText += " INNER JOIN tblProducts ON tblProducts.TableRowGuid = tblProductRegistrationCertificates.ProductGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CDrugRegistrationFeePaymentRequestCertificates objCDrugRegistrationFeePaymentRequestCertificates = new CDrugRegistrationFeePaymentRequestCertificates();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Id = 0;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Id = (int)dr["Id"];
                    if (dr["DrugRegistrationFeePaymentRequestGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Drugregistrationfeepaymentrequestguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Drugregistrationfeepaymentrequestguid = (string)dr["DrugRegistrationFeePaymentRequestGuid"];
                    if (dr["DrugRegistrationCertificateGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Drugregistrationcertificateguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Drugregistrationcertificateguid = (string)dr["DrugRegistrationCertificateGuid"];
                    if (dr["Amount"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Amount = 0;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Amount = (decimal)dr["Amount"];
                    if (dr["CertificateNumber"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Certificatenumber = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Certificatenumber = (string)dr["CertificateNumber"];
                    if (dr["ProductName"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Productname = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Productname = (string)dr["ProductName"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Tablerowguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCDrugRegistrationFeePaymentRequestCertificates);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                dr.Close();
                command.Dispose();
            }
        }
        public List<CDrugRegistrationFeePaymentRequestCertificates> GetList(string Drugregistrationfeepaymentrequestguid)
        {
            List<CDrugRegistrationFeePaymentRequestCertificates> RecordsList = new List<CDrugRegistrationFeePaymentRequestCertificates>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select tblDrugRegistrationFeePaymentRequestCertificates.*, ";
            command.CommandText += " tblProducts.BrandName + ' ' + tblProducts.GenericName AS ProductName, ";
            command.CommandText += " tblProductRegistrationCertificates.RegistrationNumber AS CertificateNumber ";
            command.CommandText += " from tblDrugRegistrationFeePaymentRequestCertificates Join ";
            command.CommandText += " tblProductRegistrationCertificates ON tblProductRegistrationCertificates.TableRowGuid = tblDrugRegistrationFeePaymentRequestCertificates.DrugRegistrationCertificateGuid ";
            command.CommandText += " join tblProducts ON tblProducts.TableRowGuid = tblProductRegistrationCertificates.ProductGuid ";
            command.CommandText += " where tblDrugRegistrationFeePaymentRequestCertificates.DrugRegistrationFeePaymentRequestGuid=@DrugRegistrationFeePaymentRequestGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeePaymentRequestGuid", Drugregistrationfeepaymentrequestguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CDrugRegistrationFeePaymentRequestCertificates objCDrugRegistrationFeePaymentRequestCertificates = new CDrugRegistrationFeePaymentRequestCertificates();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Id = 0;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Id = (int)dr["Id"];
                    if (dr["DrugRegistrationFeePaymentRequestGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Drugregistrationfeepaymentrequestguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Drugregistrationfeepaymentrequestguid = (string)dr["DrugRegistrationFeePaymentRequestGuid"];
                    if (dr["DrugRegistrationCertificateGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Drugregistrationcertificateguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Drugregistrationcertificateguid = (string)dr["DrugRegistrationCertificateGuid"];
                    if (dr["Amount"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Amount = 0;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Amount = (decimal)dr["Amount"];
                    if (dr["CertificateNumber"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Certificatenumber = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Certificatenumber = (string)dr["CertificateNumber"];
                    if (dr["ProductName"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Productname = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Productname = (string)dr["ProductName"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeePaymentRequestCertificates.Tablerowguid = string.Empty;
                    else
                        objCDrugRegistrationFeePaymentRequestCertificates.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCDrugRegistrationFeePaymentRequestCertificates);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                dr.Close();
                command.Dispose();
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblDrugRegistrationFeePaymentRequestCertificates] WHERE Id = @Id";
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
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeePaymentRequestCertificates] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CDrugRegistrationFeePaymentRequestCertificates::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
