//
// ...
// Wizard generated code
// Date: 8/18/2009 7:18:46 PM
// Class: CProductRegistrationCertificates
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
    class CProductRegistrationCertificates
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CProductRegistrationCertificates()
        {
            _ConnectionString = ConnectionString;
        }
        public CProductRegistrationCertificates(int Id, string Productguid, DateTime Registrationsubmissiondate, DateTime Registrationdate, string Registrationnumber, int Status, DateTime Specificationrequestdate, DateTime Specificationreceiveddate, DateTime Specificationsubmissiondate, decimal Registrationfee, decimal Registrationfeeinforeigncurrency, DateTime Samplerequestdate, DateTime Samplereceiveddate, DateTime Samplesubmissiondate, DateTime Registrationexpirydate, string Slipofcponumber, string Registrationtypeguid, string Presentation, string Strength, string Dosageformguid)
        {
            _Id = Id;
            _ProductGuid = Productguid;
            _RegistrationSubmissionDate = Registrationsubmissiondate;
            _RegistrationDate = Registrationdate;
            _RegistrationNumber = Registrationnumber;
            _Status = Status;
            _SpecificationRequestDate = Specificationrequestdate;
            _SpecificationReceivedDate = Specificationreceiveddate;
            _SpecificationSubmissionDate = Specificationsubmissiondate;
            _RegistrationFee = Registrationfee;
            _RegistrationFeeInForeignCurrency = Registrationfeeinforeigncurrency;
            _SampleRequestDate = Samplerequestdate;
            _SampleReceivedDate = Samplereceiveddate;
            _SampleSubmissionDate = Samplesubmissiondate;
            _RegistrationExpiryDate = Registrationexpirydate;
            _SlipOrCpoNumber = Slipofcponumber;
            _RegistrationTypeGuid = Registrationtypeguid;
            _Presentation = Presentation;
            _Strength = Strength;
            _DosageFormGuid = Dosageformguid;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _ProductGuid;
        public string Productguid
        {
            get { return _ProductGuid; }
            set { _ProductGuid = value; }
        }

        DateTime _RegistrationSubmissionDate;
        public DateTime Registrationsubmissiondate
        {
            get { return _RegistrationSubmissionDate; }
            set { _RegistrationSubmissionDate = value; }
        }

        DateTime _RegistrationDate;
        public DateTime Registrationdate
        {
            get { return _RegistrationDate; }
            set { _RegistrationDate = value; }
        }

        string _RegistrationNumber;
        public string Registrationnumber
        {
            get { return _RegistrationNumber; }
            set { _RegistrationNumber = value; }
        }

        int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        DateTime _SpecificationRequestDate;
        public DateTime Specificationrequestdate
        {
            get { return _SpecificationRequestDate; }
            set { _SpecificationRequestDate = value; }
        }

        DateTime _SpecificationReceivedDate;
        public DateTime Specificationreceiveddate
        {
            get { return _SpecificationReceivedDate; }
            set { _SpecificationReceivedDate = value; }
        }

        DateTime _SpecificationSubmissionDate;
        public DateTime Specificationsubmissiondate
        {
            get { return _SpecificationSubmissionDate; }
            set { _SpecificationSubmissionDate = value; }
        }

        decimal _RegistrationFee;
        public decimal Registrationfee
        {
            get { return _RegistrationFee; }
            set { _RegistrationFee = value; }
        }

        decimal _RegistrationFeeInForeignCurrency;
        public decimal Registrationfeeinforeigncurrency
        {
            get { return _RegistrationFeeInForeignCurrency; }
            set { _RegistrationFeeInForeignCurrency = value; }
        }

        DateTime _SampleRequestDate;
        public DateTime Samplerequestdate
        {
            get { return _SampleRequestDate; }
            set { _SampleRequestDate = value; }
        }

        DateTime _SampleReceivedDate;
        public DateTime Samplereceiveddate
        {
            get { return _SampleReceivedDate; }
            set { _SampleReceivedDate = value; }
        }

        DateTime _SampleSubmissionDate;
        public DateTime Samplesubmissiondate
        {
            get { return _SampleSubmissionDate; }
            set { _SampleSubmissionDate = value; }
        }

        DateTime _RegistrationExpiryDate;
        public DateTime Registrationexpirydate
        {
            get { return _RegistrationExpiryDate; }
            set { _RegistrationExpiryDate = value; }
        }

        string _SlipOrCpoNumber;
        public string Sliporcponumber
        {
            get { return _SlipOrCpoNumber; }
            set { _SlipOrCpoNumber = value; }
        }

        string _RegistrationTypeGuid;
        public string Registrationtypeguid
        {
            get { return _RegistrationTypeGuid; }
            set { _RegistrationTypeGuid = value; }
        }

        string _Presentation;
        public string Presentation
        {
            get { return _Presentation; }
            set { _Presentation = value; }
        }

        string _Strength;
        public string Strength
        {
            get { return _Strength; }
            set { _Strength = value; }
        }

        string _DosageFormGuid;
        public string Dosageformguid
        {
            get { return _DosageFormGuid; }
            set { _DosageFormGuid = value; }
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
            command.CommandText = "Select * from tblProductRegistrationCertificates where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblProductRegistrationCertificates");
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
                    if (dTable.Rows[0]["ProductGuid"].Equals(DBNull.Value))
                        _ProductGuid = string.Empty;
                    else
                        _ProductGuid = (string)dTable.Rows[0]["ProductGuid"];
                    if (dTable.Rows[0]["RegistrationSubmissionDate"].Equals(DBNull.Value))
                        _RegistrationSubmissionDate = DateTime.MinValue;
                    else
                        _RegistrationSubmissionDate = (DateTime)dTable.Rows[0]["RegistrationSubmissionDate"];
                    if (dTable.Rows[0]["RegistrationDate"].Equals(DBNull.Value))
                        _RegistrationDate = DateTime.MinValue;
                    else
                        _RegistrationDate = (DateTime)dTable.Rows[0]["RegistrationDate"];
                    if (dTable.Rows[0]["RegistrationNumber"].Equals(DBNull.Value))
                        _RegistrationNumber = string.Empty;
                    else
                        _RegistrationNumber = (string)dTable.Rows[0]["RegistrationNumber"];
                    if (dTable.Rows[0]["Status"].Equals(DBNull.Value))
                        _Status = 0;
                    else
                        _Status = (int)dTable.Rows[0]["Status"];
                    if (dTable.Rows[0]["SpecificationRequestDate"].Equals(DBNull.Value))
                        _SpecificationRequestDate = DateTime.MinValue;
                    else
                        _SpecificationRequestDate = (DateTime)dTable.Rows[0]["SpecificationRequestDate"];
                    if (dTable.Rows[0]["SpecificationReceivedDate"].Equals(DBNull.Value))
                        _SpecificationReceivedDate = DateTime.MinValue;
                    else
                        _SpecificationReceivedDate = (DateTime)dTable.Rows[0]["SpecificationReceivedDate"];
                    if (dTable.Rows[0]["SpecificationSubmissionDate"].Equals(DBNull.Value))
                        _SpecificationSubmissionDate = DateTime.MinValue;
                    else
                        _SpecificationSubmissionDate = (DateTime)dTable.Rows[0]["SpecificationSubmissionDate"];
                    if (dTable.Rows[0]["RegistrationFee"].Equals(DBNull.Value))
                        _RegistrationFee = 0;
                    else
                        _RegistrationFee = (decimal)dTable.Rows[0]["RegistrationFee"];
                    if (dTable.Rows[0]["RegistrationFeeInForeignCurrency"].Equals(DBNull.Value))
                        _RegistrationFeeInForeignCurrency = 0;
                    else
                        _RegistrationFeeInForeignCurrency = (decimal)dTable.Rows[0]["RegistrationFeeInForeignCurrency"];
                    if (dTable.Rows[0]["SampleRequestDate"].Equals(DBNull.Value))
                        _SampleRequestDate = DateTime.MinValue;
                    else
                        _SampleRequestDate = (DateTime)dTable.Rows[0]["SampleRequestDate"];
                    if (dTable.Rows[0]["SampleReceivedDate"].Equals(DBNull.Value))
                        _SampleReceivedDate = DateTime.MinValue;
                    else
                        _SampleReceivedDate = (DateTime)dTable.Rows[0]["SampleReceivedDate"];
                    if (dTable.Rows[0]["SampleSubmissionDate"].Equals(DBNull.Value))
                        _SampleSubmissionDate = DateTime.MinValue;
                    else
                        _SampleSubmissionDate = (DateTime)dTable.Rows[0]["SampleSubmissionDate"];
                    if (dTable.Rows[0]["RegistrationExpiryDate"].Equals(DBNull.Value))
                        _RegistrationExpiryDate = DateTime.MinValue;
                    else
                        _RegistrationExpiryDate = (DateTime)dTable.Rows[0]["RegistrationExpiryDate"];
                    if (dTable.Rows[0]["SlipOrCpoNumber"].Equals(DBNull.Value))
                        _SlipOrCpoNumber = string.Empty;
                    else
                        _SlipOrCpoNumber = (string)dTable.Rows[0]["SlipOrCpoNumber"];
                    if (dTable.Rows[0]["RegistrationTypeGuid"].Equals(DBNull.Value))
                        _RegistrationTypeGuid = string.Empty;
                    else
                        _RegistrationTypeGuid = (string)dTable.Rows[0]["RegistrationTypeGuid"];
                    if (dTable.Rows[0]["Presentation"].Equals(DBNull.Value))
                        _Presentation = string.Empty;
                    else
                        _Presentation = (string)dTable.Rows[0]["Presentation"];
                    if (dTable.Rows[0]["Strength"].Equals(DBNull.Value))
                        _Strength = string.Empty;
                    else
                        _Strength = (string)dTable.Rows[0]["Strength"];
                    if (dTable.Rows[0]["DosageFormGuid"].Equals(DBNull.Value))
                        _DosageFormGuid = string.Empty;
                    else
                        _DosageFormGuid = (string)dTable.Rows[0]["DosageFormGuid"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CProductRegistrationCertificates::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblProductRegistrationCertificates";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblProductRegistrationCertificates");
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
                throw new Exception("CProductRegistrationCertificates::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Productguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblProductRegistrationCertificates where ProductGuid=@ProductGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblProductRegistrationCertificates");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CProductRegistrationCertificates::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblProductRegistrationCertificates" +
                                   " (ProductGuid, " +
                                   " RegistrationDate, " +
                                   " RegistrationNumber, " +
                                   " Status, " +
                                   " SpecificationRequestDate, " +
                                   " SpecificationReceivedDate, " +
                                   " SpecificationSubmissionDate, " +
                                   " RegistrationFee, " +
                                   " SampleRequestDate, " +
                                   " SampleReceivedDate, " +
                                   " SampleSubmissionDate, " +
                                   " RegistrationExpiryDate, " +
                                   " RegistrationSubmissionDate, " +
                                   " RegistrationFeeInForeignCurrency, " +
                                   " SlipOrCpoNumber, " +
                                   " RegistrationTypeGuid, " +
                                   " Presentation, " +
                                   " Strength, " +
                                   " DosageFormGuid,UserId,ComputerName,EventSource)" +
                                   " Values (@ProductGuid, " +
                                   " @RegistrationDate, " +
                                   " @RegistrationNumber, " +
                                   " @Status, " +
                                   " @SpecificationRequestDate, " +
                                   " @SpecificationReceivedDate, " +
                                   " @SpecificationSubmissionDate, " +
                                   " @RegistrationFee, " +
                                   " @SampleRequestDate, " +
                                   " @SampleReceivedDate, " +
                                   " @SampleSubmissionDate, " +
                                   " @RegistrationExpiryDate, " +
                                   " @RegistrationSubmissionDate, " +
                                   " @RegistrationFeeInForeignCurrency, " +
                                   " @SlipOrCpoNumber, " +
                                   " @RegistrationTypeGuid, " +
                                   " @Presentation, " +
                                   " @Strength, " +
                                   " @DosageFormGuid,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblProductRegistrationCertificates ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                if (_RegistrationDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", _RegistrationDate));
                command.Parameters.Add(new SqlParameter("@RegistrationNumber", _RegistrationNumber));
                command.Parameters.Add(new SqlParameter("@Status", _Status));
                if (_SpecificationRequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationRequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationRequestDate", _SpecificationRequestDate));
                if (_SpecificationReceivedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationReceivedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationReceivedDate", _SpecificationReceivedDate));
                if (_SpecificationSubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationSubmissionDate", _SpecificationSubmissionDate));
                command.Parameters.Add(new SqlParameter("@RegistrationFee", _RegistrationFee));

                if (_SampleRequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleRequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleRequestDate", _SampleRequestDate));
                if (_SampleReceivedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleReceivedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleReceivedDate", _SampleReceivedDate));
                if (_SampleSubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleSubmissionDate", _SampleSubmissionDate));
                if (_RegistrationExpiryDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationExpiryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationExpiryDate", _RegistrationExpiryDate));

                if (_RegistrationSubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationSubmissionDate", _RegistrationSubmissionDate));
                command.Parameters.Add(new SqlParameter("@RegistrationFeeInForeignCurrency", _RegistrationFeeInForeignCurrency));
                command.Parameters.Add(new SqlParameter("@SlipOrCpoNumber", _SlipOrCpoNumber));
                command.Parameters.Add(new SqlParameter("@RegistrationTypeGuid", _RegistrationTypeGuid));
                command.Parameters.Add(new SqlParameter("@Presentation", _Presentation));
                command.Parameters.Add(new SqlParameter("@Strength", _Strength));
                command.Parameters.Add(new SqlParameter("@DosageFormGuid", _DosageFormGuid));

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
                throw new Exception("CProductRegistrationCertificates::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblProductRegistrationCertificates" +
                                   " Set ProductGuid = @ProductGuid, " +
                                   " RegistrationDate = @RegistrationDate, " +
                                   " RegistrationNumber = @RegistrationNumber, " +
                                   " Status = @Status, " +
                                   " SpecificationRequestDate = @SpecificationRequestDate, " +
                                   " SpecificationReceivedDate = @SpecificationReceivedDate, " +
                                   " SpecificationSubmissionDate = @SpecificationSubmissionDate, " +
                                   " RegistrationFee = @RegistrationFee, " +
                                   " SampleRequestDate = @SampleRequestDate, " +
                                   " SampleReceivedDate = @SampleReceivedDate, " +
                                   " SampleSubmissionDate = @SampleSubmissionDate, " +
                                   " RegistrationExpiryDate = @RegistrationExpiryDate, " +
                                   " RegistrationSubmissionDate = @RegistrationSubmissionDate, " +
                                   " RegistrationFeeInForeignCurrency = @RegistrationFeeInForeignCurrency, " +
                                   " SlipOrCpoNumber = @SlipOrCpoNumber, " +
                                   " RegistrationTypeGuid = @RegistrationTypeGuid, " +
                                   " Presentation = @Presentation, " +
                                   " Strength = @Strength, " +
                                   " DosageFormGuid = @DosageFormGuid," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                if (_RegistrationDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", _RegistrationDate));
                command.Parameters.Add(new SqlParameter("@RegistrationNumber", _RegistrationNumber));
                command.Parameters.Add(new SqlParameter("@Status", _Status));
                if (_SpecificationRequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationRequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationRequestDate", _SpecificationRequestDate));
                if (_SpecificationReceivedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationReceivedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationReceivedDate", _SpecificationReceivedDate));
                if (_SpecificationSubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationSubmissionDate", _SpecificationSubmissionDate));
                command.Parameters.Add(new SqlParameter("@RegistrationFee", _RegistrationFee));

                if (_SampleRequestDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleRequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleRequestDate", _SampleRequestDate));
                if (_SampleReceivedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleReceivedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleReceivedDate", _SampleReceivedDate));
                if (_SampleSubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleSubmissionDate", _SampleSubmissionDate));
                if (_RegistrationExpiryDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationExpiryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationExpiryDate", _RegistrationExpiryDate));

                if (_RegistrationSubmissionDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationSubmissionDate", _RegistrationSubmissionDate));
                command.Parameters.Add(new SqlParameter("@RegistrationFeeInForeignCurrency", _RegistrationFeeInForeignCurrency));
                command.Parameters.Add(new SqlParameter("@SlipOrCpoNumber", _SlipOrCpoNumber));
                command.Parameters.Add(new SqlParameter("@RegistrationTypeGuid", _RegistrationTypeGuid));
                command.Parameters.Add(new SqlParameter("@Presentation", _Presentation));
                command.Parameters.Add(new SqlParameter("@Strength", _Strength));
                command.Parameters.Add(new SqlParameter("@DosageFormGuid", _DosageFormGuid));

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
                throw new Exception("CProductRegistrationCertificates::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblProductRegistrationCertificates Where Id = @Id ";
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
                throw new Exception("CProductRegistrationCertificates::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblProductRegistrationCertificates] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND RegistrationNumber = @RegistrationNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblProductRegistrationCertificates] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND RegistrationNumber = @RegistrationNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                command.Parameters.Add(new SqlParameter("@RegistrationNumber", _RegistrationNumber));
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
                throw new Exception("CProductRegistrationCertificates::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Productguid, DateTime Registrationsubmissiondate, DateTime Registrationdate, string Registrationnumber, int Status, DateTime Specificationrequestdate, DateTime Specificationreceiveddate, DateTime Specificationsubmissiondate, decimal Registrationfee, decimal Registrationfeeinforeigncurrency, DateTime Samplerequestdate, DateTime Samplereceiveddate, DateTime Samplesubmissiondate, DateTime Registrationexpirydate, string Slipofcponumber, string Registrationtypeguid, string Presentation, string Strength, string Dosageformguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblProductRegistrationCertificates" +
                                   " (ProductGuid, " +
                                   " RegistrationDate, " +
                                   " RegistrationNumber, " +
                                   " Status, " +
                                   " SpecificationRequestDate, " +
                                   " SpecificationReceivedDate, " +
                                   " SpecificationSubmissionDate, " +
                                   " RegistrationFee, " +
                                   " SampleRequestDate, " +
                                   " SampleReceivedDate, " +
                                   " SampleSubmissionDate, " +
                                   " RegistrationExpiryDate, " +
                                   " RegistrationSubmissionDate, " +
                                   " RegistrationFeeInForeignCurrency, " +
                                   " SlipOrCpoNumber, " +
                                   " RegistrationTypeGuid, " +
                                   " Presentation, " +
                                   " Strength, " +
                                   " DosageFormGuid)" +
                                   " Values (@ProductGuid, " +
                                   " @RegistrationDate, " +
                                   " @RegistrationNumber, " +
                                   " @Status, " +
                                   " @SpecificationRequestDate, " +
                                   " @SpecificationReceivedDate, " +
                                   " @SpecificationSubmissionDate, " +
                                   " @RegistrationFee, " +
                                   " @SampleRequestDate, " +
                                   " @SampleReceivedDate, " +
                                   " @SampleSubmissionDate, " +
                                   " @RegistrationExpiryDate, " +
                                   " @RegistrationSubmissionDate, " +
                                   " @RegistrationFeeInForeignCurrency, " +
                                   " @SlipOrCpoNumber, " +
                                   " @RegistrationTypeGuid, " +
                                   " @Presentation, " +
                                   " @Strength, " +
                                   " @DosageFormGuid)" +
                                   " Select @Id=Max(id) from tblProductRegistrationCertificates ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                if (Registrationdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", Registrationdate));
                command.Parameters.Add(new SqlParameter("@RegistrationNumber", Registrationnumber));
                command.Parameters.Add(new SqlParameter("@Status", Status));
                if (Specificationrequestdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationRequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationRequestDate", Specificationrequestdate));
                if (Specificationreceiveddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationReceivedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationReceivedDate", Specificationreceiveddate));
                if (Specificationsubmissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationSubmissionDate", Specificationsubmissiondate));
                command.Parameters.Add(new SqlParameter("@RegistrationFee", Registrationfee));
                if (Samplerequestdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleRequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleRequestDate", Samplerequestdate));
                if (Samplereceiveddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleReceivedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleReceivedDate", Samplereceiveddate));
                if (Samplesubmissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleSubmissionDate", Samplesubmissiondate));
                if (Registrationexpirydate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationExpiryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationExpiryDate", Registrationexpirydate));

                if (Registrationsubmissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationSubmissionDate", Registrationsubmissiondate));
                command.Parameters.Add(new SqlParameter("@RegistrationFeeInForeignCurrency", Registrationfeeinforeigncurrency));
                command.Parameters.Add(new SqlParameter("@SlipOrCpoNumber", Sliporcponumber));
                command.Parameters.Add(new SqlParameter("@RegistrationTypeGuid", Registrationtypeguid));
                command.Parameters.Add(new SqlParameter("@Presentation", Presentation));
                command.Parameters.Add(new SqlParameter("@Strength", Strength));
                command.Parameters.Add(new SqlParameter("@DosageFormGuid", Dosageformguid));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CProductRegistrationCertificates::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Productguid, DateTime Registrationsubmissiondate, DateTime Registrationdate, string Registrationnumber, int Status, DateTime Specificationrequestdate, DateTime Specificationreceiveddate, DateTime Specificationsubmissiondate, decimal Registrationfee, decimal Registrationfeeinforeigncurrency, DateTime Samplerequestdate, DateTime Samplereceiveddate, DateTime Samplesubmissiondate, DateTime Registrationexpirydate, string Slipofcponumber, string Registrationtypeguid, string Presentation, string Strength, string Dosageformguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblProductRegistrationCertificates" +
                                   " Set ProductGuid = @ProductGuid, " +
                                   " RegistrationDate = @RegistrationDate, " +
                                   " RegistrationNumber = @RegistrationNumber, " +
                                   " Status = @Status, " +
                                   " SpecificationRequestDate = @SpecificationRequestDate, " +
                                   " SpecificationReceivedDate = @SpecificationReceivedDate, " +
                                   " SpecificationSubmissionDate = @SpecificationSubmissionDate, " +
                                   " RegistrationFee = @RegistrationFee, " +
                                   " SampleRequestDate = @SampleRequestDate, " +
                                   " SampleReceivedDate = @SampleReceivedDate, " +
                                   " SampleSubmissionDate = @SampleSubmissionDate, " +
                                   " RegistrationExpiryDate = @RegistrationExpiryDate, " +
                                   " RegistrationSubmissionDate = @RegistrationSubmissionDate, " +
                                   " RegistrationFeeInForeignCurrency = @RegistrationFeeInForeignCurrency, " +
                                   " SlipOrCpoNumber = @SlipOrCpoNumber, " +
                                   " RegistrationTypeGuid = @RegistrationTypeGuid, " +
                                   " Presentation = @Presentation, " +
                                   " Strength = @Strength, " +
                                   " DosageFormGuid = @DosageFormGuid" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                if (Registrationdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationDate", Registrationdate));
                command.Parameters.Add(new SqlParameter("@RegistrationNumber", Registrationnumber));
                command.Parameters.Add(new SqlParameter("@Status", Status));
                if (Specificationrequestdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationRequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationRequestDate", Specificationrequestdate));
                if (Specificationreceiveddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationReceivedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationReceivedDate", Specificationreceiveddate));
                if (Specificationsubmissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SpecificationSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SpecificationSubmissionDate", Specificationsubmissiondate));
                command.Parameters.Add(new SqlParameter("@RegistrationFee", Registrationfee));
                if (Samplerequestdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleRequestDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleRequestDate", Samplerequestdate));
                if (Samplereceiveddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleReceivedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleReceivedDate", Samplereceiveddate));
                if (Samplesubmissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SampleSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SampleSubmissionDate", Samplesubmissiondate));
                if (Registrationexpirydate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationExpiryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationExpiryDate", Registrationexpirydate));

                if (Registrationsubmissiondate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@RegistrationSubmissionDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@RegistrationSubmissionDate", Registrationsubmissiondate));
                command.Parameters.Add(new SqlParameter("@RegistrationFeeInForeignCurrency", Registrationfeeinforeigncurrency));
                command.Parameters.Add(new SqlParameter("@SlipOrCpoNumber", Sliporcponumber));
                command.Parameters.Add(new SqlParameter("@RegistrationTypeGuid", Registrationtypeguid));
                command.Parameters.Add(new SqlParameter("@Presentation", Presentation));
                command.Parameters.Add(new SqlParameter("@Strength", Strength));
                command.Parameters.Add(new SqlParameter("@DosageFormGuid", Dosageformguid));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                
                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CProductRegistrationCertificates::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblProductRegistrationCertificates Where Id = @Id ";
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
                throw new Exception("CProductRegistrationCertificates::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Productguid, string Registrationnumber)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblProductRegistrationCertificates] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND RegistrationNumber = @RegistrationNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblProductRegistrationCertificates] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND RegistrationNumber = @RegistrationNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                command.Parameters.Add(new SqlParameter("@RegistrationNumber", Registrationnumber));
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
                throw new Exception("CProductRegistrationCertificates::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CProductRegistrationCertificates> GetList()
        {
            List<CProductRegistrationCertificates> RecordsList = new List<CProductRegistrationCertificates>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblProductRegistrationCertificates";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProductRegistrationCertificates objCProductRegistrationCertificates = new CProductRegistrationCertificates();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Id = 0;
                    else
                        objCProductRegistrationCertificates.Id = (int)dr["Id"];
                    if (dr["ProductGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Productguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Productguid = (string)dr["ProductGuid"];
                    if (dr["RegistrationSubmissionDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationsubmissiondate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Registrationsubmissiondate = (DateTime)dr["RegistrationSubmissionDate"];
                    if (dr["RegistrationDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationdate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Registrationdate = (DateTime)dr["RegistrationDate"];
                    if (dr["RegistrationNumber"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationnumber = string.Empty;
                    else
                        objCProductRegistrationCertificates.Registrationnumber = (string)dr["RegistrationNumber"];
                    if (dr["Status"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Status = 0;
                    else
                        objCProductRegistrationCertificates.Status = (int)dr["Status"];
                    if (dr["SpecificationRequestDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Specificationrequestdate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Specificationrequestdate = (DateTime)dr["SpecificationRequestDate"];
                    if (dr["SpecificationReceivedDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Specificationreceiveddate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Specificationreceiveddate = (DateTime)dr["SpecificationReceivedDate"];
                    if (dr["SpecificationSubmissionDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Specificationsubmissiondate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Specificationsubmissiondate = (DateTime)dr["SpecificationSubmissionDate"];
                    if (dr["RegistrationFee"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationfee = 0;
                    else
                        objCProductRegistrationCertificates.Registrationfee = (decimal)dr["RegistrationFee"];
                    if (dr["RegistrationFeeInForeignCurrency"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationfeeinforeigncurrency = 0;
                    else
                        objCProductRegistrationCertificates.Registrationfeeinforeigncurrency = (decimal)dr["RegistrationFeeInForeignCurrency"];
                    if (dr["SampleRequestDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Samplerequestdate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Samplerequestdate = (DateTime)dr["SampleRequestDate"];
                    if (dr["SampleReceivedDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Samplereceiveddate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Samplereceiveddate = (DateTime)dr["SampleReceivedDate"];
                    if (dr["SampleSubmissionDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Samplesubmissiondate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Samplesubmissiondate = (DateTime)dr["SampleSubmissionDate"];
                    if (dr["RegistrationExpiryDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationexpirydate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Registrationexpirydate = (DateTime)dr["RegistrationExpiryDate"];
                    if (dr["SlipOrCpoNumber"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Sliporcponumber = string.Empty;
                    else
                        objCProductRegistrationCertificates.Sliporcponumber = (string)dr["SlipOrCpoNumber"];
                    if (dr["RegistrationTypeGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationtypeguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Registrationtypeguid = (string)dr["RegistrationTypeGuid"];
                    if (dr["Presentation"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Presentation = string.Empty;
                    else
                        objCProductRegistrationCertificates.Presentation = (string)dr["Presentation"];
                    if (dr["Strength"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Strength = string.Empty;
                    else
                        objCProductRegistrationCertificates.Strength = (string)dr["Strength"];
                    if (dr["DosageFormGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Dosageformguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Dosageformguid = (string)dr["DosageFormGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Tablerowguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProductRegistrationCertificates);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProductRegistrationCertificates::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProductRegistrationCertificates> GetList(string Productguid, bool z)
        {
            List<CProductRegistrationCertificates> RecordsList = new List<CProductRegistrationCertificates>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblProductRegistrationCertificates where ProductGuid=@ProductGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProductRegistrationCertificates objCProductRegistrationCertificates = new CProductRegistrationCertificates();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Id = 0;
                    else
                        objCProductRegistrationCertificates.Id = (int)dr["Id"];
                    if (dr["ProductGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Productguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Productguid = (string)dr["ProductGuid"];
                    if (dr["RegistrationSubmissionDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationsubmissiondate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Registrationsubmissiondate = (DateTime)dr["RegistrationSubmissionDate"];
                    if (dr["RegistrationDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationdate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Registrationdate = (DateTime)dr["RegistrationDate"];
                    if (dr["RegistrationNumber"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationnumber = string.Empty;
                    else
                        objCProductRegistrationCertificates.Registrationnumber = (string)dr["RegistrationNumber"];
                    if (dr["Status"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Status = 0;
                    else
                        objCProductRegistrationCertificates.Status = (int)dr["Status"];
                    if (dr["SpecificationRequestDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Specificationrequestdate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Specificationrequestdate = (DateTime)dr["SpecificationRequestDate"];
                    if (dr["SpecificationReceivedDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Specificationreceiveddate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Specificationreceiveddate = (DateTime)dr["SpecificationReceivedDate"];
                    if (dr["SpecificationSubmissionDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Specificationsubmissiondate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Specificationsubmissiondate = (DateTime)dr["SpecificationSubmissionDate"];
                    if (dr["RegistrationFee"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationfee = 0;
                    else
                        objCProductRegistrationCertificates.Registrationfee = (decimal)dr["RegistrationFee"];
                    if (dr["RegistrationFeeInForeignCurrency"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationfeeinforeigncurrency = 0;
                    else
                        objCProductRegistrationCertificates.Registrationfeeinforeigncurrency = (decimal)dr["RegistrationFeeInForeignCurrency"];
                    if (dr["SampleRequestDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Samplerequestdate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Samplerequestdate = (DateTime)dr["SampleRequestDate"];
                    if (dr["SampleReceivedDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Samplereceiveddate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Samplereceiveddate = (DateTime)dr["SampleReceivedDate"];
                    if (dr["SampleSubmissionDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Samplesubmissiondate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Samplesubmissiondate = (DateTime)dr["SampleSubmissionDate"];
                    if (dr["RegistrationExpiryDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationexpirydate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Registrationexpirydate = (DateTime)dr["RegistrationExpiryDate"];
                    if (dr["SlipOrCpoNumber"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Sliporcponumber = string.Empty;
                    else
                        objCProductRegistrationCertificates.Sliporcponumber = (string)dr["SlipOrCpoNumber"];
                    if (dr["RegistrationTypeGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationtypeguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Registrationtypeguid = (string)dr["RegistrationTypeGuid"];
                    if (dr["Presentation"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Presentation = string.Empty;
                    else
                        objCProductRegistrationCertificates.Presentation = (string)dr["Presentation"];
                    if (dr["Strength"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Strength = string.Empty;
                    else
                        objCProductRegistrationCertificates.Strength = (string)dr["Strength"];
                    if (dr["DosageFormGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Dosageformguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Dosageformguid = (string)dr["DosageFormGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Tablerowguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProductRegistrationCertificates);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProductRegistrationCertificates::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CProductRegistrationCertificates> GetList(string strCriteria, int z)
        {
            List<CProductRegistrationCertificates> RecordsList = new List<CProductRegistrationCertificates>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select tblProductRegistrationCertificates.*, tblProducts.BrandName + ' ' + tblProducts.GenericName AS ProductName from  ";
            command.CommandText += "tblProductRegistrationCertificates Inner Join tblProducts ";
            command.CommandText += "ON tblProductRegistrationCertificates.ProductGuid = tblProducts.TableRowGuid ";
            command.CommandText += "where (1=1) ";
            command.CommandText += strCriteria;

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CProductRegistrationCertificates objCProductRegistrationCertificates = new CProductRegistrationCertificates();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Id = 0;
                    else
                        objCProductRegistrationCertificates.Id = (int)dr["Id"];
                    if (dr["ProductGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Productguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Productguid = (string)dr["ProductGuid"];
                    if (dr["RegistrationSubmissionDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationsubmissiondate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Registrationsubmissiondate = (DateTime)dr["RegistrationSubmissionDate"];
                    if (dr["RegistrationDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationdate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Registrationdate = (DateTime)dr["RegistrationDate"];
                    if (dr["RegistrationNumber"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationnumber = string.Empty;
                    else
                        objCProductRegistrationCertificates.Registrationnumber = (string)dr["RegistrationNumber"];
                    if (dr["Status"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Status = 0;
                    else
                        objCProductRegistrationCertificates.Status = (int)dr["Status"];
                    if (dr["SpecificationRequestDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Specificationrequestdate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Specificationrequestdate = (DateTime)dr["SpecificationRequestDate"];
                    if (dr["SpecificationReceivedDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Specificationreceiveddate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Specificationreceiveddate = (DateTime)dr["SpecificationReceivedDate"];
                    if (dr["SpecificationSubmissionDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Specificationsubmissiondate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Specificationsubmissiondate = (DateTime)dr["SpecificationSubmissionDate"];
                    if (dr["RegistrationFee"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationfee = 0;
                    else
                        objCProductRegistrationCertificates.Registrationfee = (decimal)dr["RegistrationFee"];
                    if (dr["RegistrationFeeInForeignCurrency"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationfeeinforeigncurrency = 0;
                    else
                        objCProductRegistrationCertificates.Registrationfeeinforeigncurrency = (decimal)dr["RegistrationFeeInForeignCurrency"];
                    if (dr["SampleRequestDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Samplerequestdate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Samplerequestdate = (DateTime)dr["SampleRequestDate"];
                    if (dr["SampleReceivedDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Samplereceiveddate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Samplereceiveddate = (DateTime)dr["SampleReceivedDate"];
                    if (dr["SampleSubmissionDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Samplesubmissiondate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Samplesubmissiondate = (DateTime)dr["SampleSubmissionDate"];
                    if (dr["RegistrationExpiryDate"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationexpirydate = DateTime.MinValue;
                    else
                        objCProductRegistrationCertificates.Registrationexpirydate = (DateTime)dr["RegistrationExpiryDate"];
                    if (dr["SlipOrCpoNumber"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Sliporcponumber = string.Empty;
                    else
                        objCProductRegistrationCertificates.Sliporcponumber = (string)dr["SlipOrCpoNumber"];
                    if (dr["RegistrationTypeGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Registrationtypeguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Registrationtypeguid = (string)dr["RegistrationTypeGuid"];
                    if (dr["ProductName"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Productname = string.Empty;
                    else
                        objCProductRegistrationCertificates.Productname = (string)dr["ProductName"];
                    if (dr["Presentation"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Presentation = string.Empty;
                    else
                        objCProductRegistrationCertificates.Presentation = (string)dr["Presentation"];
                    if (dr["Strength"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Strength = string.Empty;
                    else
                        objCProductRegistrationCertificates.Strength = (string)dr["Strength"];
                    if (dr["DosageFormGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Dosageformguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Dosageformguid = (string)dr["DosageFormGuid"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCProductRegistrationCertificates.Tablerowguid = string.Empty;
                    else
                        objCProductRegistrationCertificates.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCProductRegistrationCertificates);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CProductRegistrationCertificates::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblProductRegistrationCertificates] WHERE Id = @Id";
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
                throw new Exception("CProductRegistrationCertificates::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblProductRegistrationCertificates] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CProductRegistrationCertificates::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
