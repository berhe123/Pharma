//
// ...
// Wizard generated code
// Date: 11/16/2009 8:07:18 PM
// Class: CDrugRegistrationFeeTableDetails
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
    class CDrugRegistrationFeeTableDetails
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CDrugRegistrationFeeTableDetails()
        {
            _ConnectionString = ConnectionString;
        }
        public CDrugRegistrationFeeTableDetails(int Id, string Drugregistrationfeetableguid, string Productregistrationcertificateguid)
        {
            _Id = Id;
            _DrugRegistrationFeeTableGuid = Drugregistrationfeetableguid;
            _ProductRegistrationCertificateGuid = Productregistrationcertificateguid;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _DrugRegistrationFeeTableGuid;
        public string Drugregistrationfeetableguid
        {
            get { return _DrugRegistrationFeeTableGuid; }
            set { _DrugRegistrationFeeTableGuid = value; }
        }

        string _ProductRegistrationCertificateGuid;
        public string Productregistrationcertificateguid
        {
            get { return _ProductRegistrationCertificateGuid; }
            set { _ProductRegistrationCertificateGuid = value; }
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
            command.CommandText = "Select * from tblDrugRegistrationFeeTableDetails where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeeTableDetails");
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
                    if (dTable.Rows[0]["DrugRegistrationFeeTableGuid"].Equals(DBNull.Value))
                        _DrugRegistrationFeeTableGuid = string.Empty;
                    else
                        _DrugRegistrationFeeTableGuid = (string)dTable.Rows[0]["DrugRegistrationFeeTableGuid"];
                    if (dTable.Rows[0]["ProductRegistrationCertificateGuid"].Equals(DBNull.Value))
                        _ProductRegistrationCertificateGuid = string.Empty;
                    else
                        _ProductRegistrationCertificateGuid = (string)dTable.Rows[0]["ProductRegistrationCertificateGuid"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTableDetails::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblDrugRegistrationFeeTableDetails";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeeTableDetails");
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
                throw new Exception("CDrugRegistrationFeeTableDetails::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
                adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Drugregistrationfeetableguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblDrugRegistrationFeeTableDetails where DrugRegistrationFeeTableGuid=@DrugRegistrationFeeTableGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblDrugRegistrationFeeTableDetails");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeeTableGuid", Drugregistrationfeetableguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTableDetails::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblDrugRegistrationFeeTableDetails" +
                                   " (DrugRegistrationFeeTableGuid, " +
                                   " ProductRegistrationCertificateGuid,UserId,ComputerName,EventSource)" +
                                   " Values (@DrugRegistrationFeeTableGuid, " +
                                   " @ProductRegistrationCertificateGuid,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblDrugRegistrationFeeTableDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeeTableGuid", _DrugRegistrationFeeTableGuid));
                command.Parameters.Add(new SqlParameter("@ProductRegistrationCertificateGuid", _ProductRegistrationCertificateGuid));

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
                throw new Exception("CDrugRegistrationFeeTableDetails::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblDrugRegistrationFeeTableDetails" +
                                   " Set DrugRegistrationFeeTableGuid = @DrugRegistrationFeeTableGuid, " +
                                   " ProductRegistrationCertificateGuid = @ProductRegistrationCertificateGuid," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeeTableGuid", _DrugRegistrationFeeTableGuid));
                command.Parameters.Add(new SqlParameter("@ProductRegistrationCertificateGuid", _ProductRegistrationCertificateGuid));

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
                throw new Exception("CDrugRegistrationFeeTableDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblDrugRegistrationFeeTableDetails Where Id = @Id ";
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
                throw new Exception("CDrugRegistrationFeeTableDetails::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTableDetails] WHERE " +
                                       " DrugRegistrationFeeTableGuid = @DrugRegistrationFeeTableGuid " +
                                       " AND ProductRegistrationCertificateGuid = @ProductRegistrationCertificateGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTableDetails] WHERE " +
                                       " DrugRegistrationFeeTableGuid = @DrugRegistrationFeeTableGuid " +
                                       " AND ProductRegistrationCertificateGuid = @ProductRegistrationCertificateGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeeTableGuid", _DrugRegistrationFeeTableGuid));
                command.Parameters.Add(new SqlParameter("@ProductRegistrationCertificateGuid", _ProductRegistrationCertificateGuid));
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
                throw new Exception("CDrugRegistrationFeeTableDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public bool Insert(int Id, string Drugregistrationfeetableguid, string Productregistrationcertificateguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblDrugRegistrationFeeTableDetails" +
                                   " (DrugRegistrationFeeTableGuid, " +
                                   " ProductRegistrationCertificateGuid)" +
                                   " Values (@DrugRegistrationFeeTableGuid, " +
                                   " @ProductRegistrationCertificateGuid)" +
                                   " Select @Id=Max(id) from tblDrugRegistrationFeeTableDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeeTableGuid", Drugregistrationfeetableguid));
                command.Parameters.Add(new SqlParameter("@ProductRegistrationCertificateGuid", Productregistrationcertificateguid));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTableDetails::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public bool Update(int Id, string Drugregistrationfeetableguid, string Productregistrationcertificateguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblDrugRegistrationFeeTableDetails" +
                                   " Set DrugRegistrationFeeTableGuid = @DrugRegistrationFeeTableGuid, " +
                                   " ProductRegistrationCertificateGuid = @ProductRegistrationCertificateGuid" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeeTableGuid", Drugregistrationfeetableguid));
                command.Parameters.Add(new SqlParameter("@ProductRegistrationCertificateGuid", Productregistrationcertificateguid));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTableDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblDrugRegistrationFeeTableDetails Where Id = @Id ";
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
                throw new Exception("CDrugRegistrationFeeTableDetails::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Drugregistrationfeetableguid, string Productregistrationcertificateguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTableDetails] WHERE " +
                                       " DrugRegistrationFeeTableGuid = @DrugRegistrationFeeTableGuid " +
                                       " AND ProductRegistrationCertificateGuid = @ProductRegistrationCertificateGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTableDetails] WHERE " +
                                       " DrugRegistrationFeeTableGuid = @DrugRegistrationFeeTableGuid " +
                                       " AND ProductRegistrationCertificateGuid = @ProductRegistrationCertificateGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeeTableGuid", Drugregistrationfeetableguid));
                command.Parameters.Add(new SqlParameter("@ProductRegistrationCertificateGuid", Productregistrationcertificateguid));
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
                throw new Exception("CDrugRegistrationFeeTableDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                command.Dispose();
            }
        }

        public List<CDrugRegistrationFeeTableDetails> GetList()
        {
            List<CDrugRegistrationFeeTableDetails> RecordsList = new List<CDrugRegistrationFeeTableDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select tblDrugRegistrationFeeTableDetails.*, ";
            command.CommandText += " tblProducts.BrandName + ' ' + tblProducts.GenericName AS ProductName, ";
            command.CommandText += " tblProductRegistrationCertificates.RegistrationNumber AS CertificateNumber ";
            command.CommandText += " from tblDrugRegistrationFeeTableDetails Join ";
            command.CommandText += " tblProductRegistrationCertificates ON tblProductRegistrationCertificates.TableRowGuid = tblDrugRegistrationFeeTableDetails.ProductRegistrationCertificateGuid ";
            command.CommandText += " INNER JOIN tblProducts ON tblProducts.TableRowGuid = tblProductRegistrationCertificates.ProductGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CDrugRegistrationFeeTableDetails objCDrugRegistrationFeeTableDetails = new CDrugRegistrationFeeTableDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Id = 0;
                    else
                        objCDrugRegistrationFeeTableDetails.Id = (int)dr["Id"];
                    if (dr["DrugRegistrationFeeTableGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Drugregistrationfeetableguid = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Drugregistrationfeetableguid = (string)dr["DrugRegistrationFeeTableGuid"];
                    if (dr["ProductRegistrationCertificateGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Productregistrationcertificateguid = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Productregistrationcertificateguid = (string)dr["ProductRegistrationCertificateGuid"];
                    if (dr["CertificateNumber"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Certificatenumber = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Certificatenumber = (string)dr["CertificateNumber"];
                    if (dr["ProductName"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Productname = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Productname = (string)dr["ProductName"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Tablerowguid = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCDrugRegistrationFeeTableDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTableDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                connection.Close();
                dr.Close();
                command.Dispose();
            }
        }
        public List<CDrugRegistrationFeeTableDetails> GetList(string Drugregistrationfeetableguid)
        {
            List<CDrugRegistrationFeeTableDetails> RecordsList = new List<CDrugRegistrationFeeTableDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            command.CommandText = " Select tblDrugRegistrationFeeTableDetails.*, ";
            command.CommandText += " tblProducts.BrandName + ' ' + tblProducts.GenericName AS ProductName, ";
            command.CommandText += " tblProductRegistrationCertificates.RegistrationNumber AS CertificateNumber ";
            command.CommandText += " from tblDrugRegistrationFeeTableDetails Join ";
            command.CommandText += " tblProductRegistrationCertificates ON tblProductRegistrationCertificates.TableRowGuid = tblDrugRegistrationFeeTableDetails.ProductRegistrationCertificateGuid ";
            command.CommandText += " INNER JOIN tblProducts ON tblProducts.TableRowGuid = tblProductRegistrationCertificates.ProductGuid ";
            command.CommandText += " where tblDrugRegistrationFeeTableDetails.DrugRegistrationFeeTableGuid=@DrugRegistrationFeeTableGuid";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@DrugRegistrationFeeTableGuid", Drugregistrationfeetableguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CDrugRegistrationFeeTableDetails objCDrugRegistrationFeeTableDetails = new CDrugRegistrationFeeTableDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Id = 0;
                    else
                        objCDrugRegistrationFeeTableDetails.Id = (int)dr["Id"];
                    if (dr["DrugRegistrationFeeTableGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Drugregistrationfeetableguid = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Drugregistrationfeetableguid = (string)dr["DrugRegistrationFeeTableGuid"];
                    if (dr["ProductRegistrationCertificateGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Productregistrationcertificateguid = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Productregistrationcertificateguid = (string)dr["ProductRegistrationCertificateGuid"];
                    if (dr["CertificateNumber"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Certificatenumber = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Certificatenumber = (string)dr["CertificateNumber"];
                    if (dr["ProductName"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Productname = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Productname = (string)dr["ProductName"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCDrugRegistrationFeeTableDetails.Tablerowguid = string.Empty;
                    else
                        objCDrugRegistrationFeeTableDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCDrugRegistrationFeeTableDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CDrugRegistrationFeeTableDetails::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblDrugRegistrationFeeTableDetails] WHERE Id = @Id";
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
                throw new Exception("CDrugRegistrationFeeTableDetails::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblDrugRegistrationFeeTableDetails] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CDrugRegistrationFeeTableDetails::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
