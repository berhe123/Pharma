//
// ...
// Wizard generated code
// Date: 8/18/2009 6:11:15 PM
// Class: CMarketStudies
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
    class CMarketStudies
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CMarketStudies()
        {
            _ConnectionString = ConnectionString;
        }
        public CMarketStudies(int Id, string Productguid, DateTime Startdate, DateTime Enddate, int Status, string Numberofexistingproductswithsamegenericname, string Currentaverageprice, string Suggestedimportfobprice, string Currentdemandquantityperyear, string Forcastedimportquantityperyear, string Locationofstudy, string Remark)
        {
            _Id = Id;
            _ProductGuid = Productguid;
            _StartDate = Startdate;
            _EndDate = Enddate;
            _Status = Status;
            _NumberOfExistingProductsWithSameGenericName = Numberofexistingproductswithsamegenericname;
            _CurrentAveragePrice = Currentaverageprice;
            _SuggestedImportFOBPrice = Suggestedimportfobprice;
            _CurrentDemandQuantityPerYear = Currentdemandquantityperyear;
            _ForcastedImportQuantityPerYear = Forcastedimportquantityperyear;
            _LocationOfStudy = Locationofstudy;
            _Remark = Remark;
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

        DateTime _StartDate;
        public DateTime Startdate
        {
            get { return _StartDate; }
            set { _StartDate = value; }
        }

        DateTime _EndDate;
        public DateTime Enddate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        string _NumberOfExistingProductsWithSameGenericName;
        public string Numberofexistingproductswithsamegenericname
        {
            get { return _NumberOfExistingProductsWithSameGenericName; }
            set { _NumberOfExistingProductsWithSameGenericName = value; }
        }

        string _CurrentAveragePrice;
        public string Currentaverageprice
        {
            get { return _CurrentAveragePrice; }
            set { _CurrentAveragePrice = value; }
        }

        string _SuggestedImportFOBPrice;
        public string Suggestedimportfobprice
        {
            get { return _SuggestedImportFOBPrice; }
            set { _SuggestedImportFOBPrice = value; }
        }

        string _CurrentDemandQuantityPerYear;
        public string Currentdemandquantityperyear
        {
            get { return _CurrentDemandQuantityPerYear; }
            set { _CurrentDemandQuantityPerYear = value; }
        }

        string _ForcastedImportQuantityPerYear;
        public string Forcastedimportquantityperyear
        {
            get { return _ForcastedImportQuantityPerYear; }
            set { _ForcastedImportQuantityPerYear = value; }
        }

        string _LocationOfStudy;
        public string Locationofstudy
        {
            get { return _LocationOfStudy; }
            set { _LocationOfStudy = value; }
        }

        string _Remark;
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
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
            command.CommandText = "Select * from tblMarketStudies where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblMarketStudies");
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
                    if (dTable.Rows[0]["StartDate"].Equals(DBNull.Value))
                        _StartDate = DateTime.MinValue;
                    else
                        _StartDate = (DateTime)dTable.Rows[0]["StartDate"];
                    if (dTable.Rows[0]["EndDate"].Equals(DBNull.Value))
                        _EndDate = DateTime.MinValue;
                    else
                        _EndDate = (DateTime)dTable.Rows[0]["EndDate"];
                    if (dTable.Rows[0]["Status"].Equals(DBNull.Value))
                        _Status = 0;
                    else
                        _Status = (int)dTable.Rows[0]["Status"];
                    if (dTable.Rows[0]["NumberOfExistingProductsWithSameGenericName"].Equals(DBNull.Value))
                        _NumberOfExistingProductsWithSameGenericName = string.Empty;
                    else
                        _NumberOfExistingProductsWithSameGenericName = (string)dTable.Rows[0]["NumberOfExistingProductsWithSameGenericName"];
                    if (dTable.Rows[0]["CurrentAveragePrice"].Equals(DBNull.Value))
                        _CurrentAveragePrice = string.Empty;
                    else
                        _CurrentAveragePrice = (string)dTable.Rows[0]["CurrentAveragePrice"];
                    if (dTable.Rows[0]["SuggestedImportFOBPrice"].Equals(DBNull.Value))
                        _SuggestedImportFOBPrice = string.Empty;
                    else
                        _SuggestedImportFOBPrice = (string)dTable.Rows[0]["SuggestedImportFOBPrice"];
                    if (dTable.Rows[0]["CurrentDemandQuantityPerYear"].Equals(DBNull.Value))
                        _CurrentDemandQuantityPerYear = string.Empty;
                    else
                        _CurrentDemandQuantityPerYear = (string)dTable.Rows[0]["CurrentDemandQuantityPerYear"];
                    if (dTable.Rows[0]["ForcastedImportQuantityPerYear"].Equals(DBNull.Value))
                        _ForcastedImportQuantityPerYear = string.Empty;
                    else
                        _ForcastedImportQuantityPerYear = (string)dTable.Rows[0]["ForcastedImportQuantityPerYear"];
                    if (dTable.Rows[0]["LocationOfStudy"].Equals(DBNull.Value))
                        _LocationOfStudy = string.Empty;
                    else
                        _LocationOfStudy = (string)dTable.Rows[0]["LocationOfStudy"];
                    if (dTable.Rows[0]["Remark"].Equals(DBNull.Value))
                        _Remark = string.Empty;
                    else
                        _Remark = (string)dTable.Rows[0]["Remark"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CMarketStudies::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblMarketStudies";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblMarketStudies");
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
                throw new Exception("CMarketStudies::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblMarketStudies where ProductGuid=@ProductGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblMarketStudies");
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
                throw new Exception("CMarketStudies::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblMarketStudies" +
                                   " (ProductGuid, " +
                                   " StartDate, " +
                                   " EndDate, " +
                                   " Status, " +
                                   " NumberOfExistingProductsWithSameGenericName, " +
                                   " CurrentAveragePrice, " +
                                   " SuggestedImportFOBPrice, " +
                                   " CurrentDemandQuantityPerYear, " +
                                   " ForcastedImportQuantityPerYear, " +
                                   " LocationOfStudy, " +
                                   " Remark,UserId,ComputerName,EventSource)" +
                                   " Values (@ProductGuid, " +
                                   " @StartDate, " +
                                   " @EndDate, " +
                                   " @Status, " +
                                   " @NumberOfExistingProductsWithSameGenericName, " +
                                   " @CurrentAveragePrice, " +
                                   " @SuggestedImportFOBPrice, " +
                                   " @CurrentDemandQuantityPerYear, " +
                                   " @ForcastedImportQuantityPerYear, " +
                                   " @LocationOfStudy, " +
                                   " @Remark,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblMarketStudies ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                if (_StartDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@StartDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@StartDate", _StartDate));
                if (_EndDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@EndDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EndDate", _EndDate));
                command.Parameters.Add(new SqlParameter("@Status", _Status));
                command.Parameters.Add(new SqlParameter("@NumberOfExistingProductsWithSameGenericName", _NumberOfExistingProductsWithSameGenericName));
                command.Parameters.Add(new SqlParameter("@CurrentAveragePrice", _CurrentAveragePrice));
                command.Parameters.Add(new SqlParameter("@SuggestedImportFOBPrice", _SuggestedImportFOBPrice));
                command.Parameters.Add(new SqlParameter("@CurrentDemandQuantityPerYear", _CurrentDemandQuantityPerYear));
                command.Parameters.Add(new SqlParameter("@ForcastedImportQuantityPerYear", _ForcastedImportQuantityPerYear));
                command.Parameters.Add(new SqlParameter("@LocationOfStudy", _LocationOfStudy));
                command.Parameters.Add(new SqlParameter("@Remark", _Remark));

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
                throw new Exception("CMarketStudies::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblMarketStudies" +
                                   " Set ProductGuid = @ProductGuid, " +
                                   " StartDate = @StartDate, " +
                                   " EndDate = @EndDate, " +
                                   " Status = @Status, " +
                                   " NumberOfExistingProductsWithSameGenericName = @NumberOfExistingProductsWithSameGenericName, " +
                                   " CurrentAveragePrice = @CurrentAveragePrice, " +
                                   " SuggestedImportFOBPrice = @SuggestedImportFOBPrice, " +
                                   " CurrentDemandQuantityPerYear = @CurrentDemandQuantityPerYear, " +
                                   " ForcastedImportQuantityPerYear = @ForcastedImportQuantityPerYear, " +
                                   " LocationOfStudy = @LocationOfStudy, " +
                                   " Remark = @Remark," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                if (_StartDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@StartDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@StartDate", _StartDate));
                if (_EndDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@EndDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EndDate", _EndDate));
                command.Parameters.Add(new SqlParameter("@Status", _Status));
                command.Parameters.Add(new SqlParameter("@NumberOfExistingProductsWithSameGenericName", _NumberOfExistingProductsWithSameGenericName));
                command.Parameters.Add(new SqlParameter("@CurrentAveragePrice", _CurrentAveragePrice));
                command.Parameters.Add(new SqlParameter("@SuggestedImportFOBPrice", _SuggestedImportFOBPrice));
                command.Parameters.Add(new SqlParameter("@CurrentDemandQuantityPerYear", _CurrentDemandQuantityPerYear));
                command.Parameters.Add(new SqlParameter("@ForcastedImportQuantityPerYear", _ForcastedImportQuantityPerYear));
                command.Parameters.Add(new SqlParameter("@LocationOfStudy", _LocationOfStudy));
                command.Parameters.Add(new SqlParameter("@Remark", _Remark));

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
                throw new Exception("CMarketStudies::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblMarketStudies Where Id = @Id ";
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
                throw new Exception("CMarketStudies::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblMarketStudies] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND StartDate = @StartDate " +
                                       " AND LocationOfStudy = @LocationOfStudy";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblMarketStudies] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND StartDate = @StartDate " +
                                       " AND LocationOfStudy = @LocationOfStudy " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                command.Parameters.Add(new SqlParameter("@StartDate", _StartDate));
                command.Parameters.Add(new SqlParameter("@LocationOfStudy", _LocationOfStudy));
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
                throw new Exception("CMarketStudies::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Productguid, DateTime Startdate, DateTime Enddate, int Status, string Numberofexistingproductswithsamegenericname, string Currentaverageprice, string Suggestedimportfobprice, string Currentdemandquantityperyear, string Forcastedimportquantityperyear, string Locationofstudy, string Remark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblMarketStudies" +
                                   " (ProductGuid, " +
                                   " StartDate, " +
                                   " EndDate, " +
                                   " Status, " +
                                   " NumberOfExistingProductsWithSameGenericName, " +
                                   " CurrentAveragePrice, " +
                                   " SuggestedImportFOBPrice, " +
                                   " CurrentDemandQuantityPerYear, " +
                                   " ForcastedImportQuantityPerYear, " +
                                   " LocationOfStudy, " +
                                   " Remark)" +
                                   " Values (@ProductGuid, " +
                                   " @StartDate, " +
                                   " @EndDate, " +
                                   " @Status, " +
                                   " @NumberOfExistingProductsWithSameGenericName, " +
                                   " @CurrentAveragePrice, " +
                                   " @SuggestedImportFOBPrice, " +
                                   " @CurrentDemandQuantityPerYear, " +
                                   " @ForcastedImportQuantityPerYear, " +
                                   " @LocationOfStudy, " +
                                   " @Remark)" +
                                   " Select @Id=Max(id) from tblMarketStudies ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                if (Startdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@StartDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@StartDate", Startdate));
                if (Enddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@EndDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EndDate", Enddate));
                command.Parameters.Add(new SqlParameter("@Status", Status));
                command.Parameters.Add(new SqlParameter("@NumberOfExistingProductsWithSameGenericName", Numberofexistingproductswithsamegenericname));
                command.Parameters.Add(new SqlParameter("@CurrentAveragePrice", Currentaverageprice));
                command.Parameters.Add(new SqlParameter("@SuggestedImportFOBPrice", Suggestedimportfobprice));
                command.Parameters.Add(new SqlParameter("@CurrentDemandQuantityPerYear", Currentdemandquantityperyear));
                command.Parameters.Add(new SqlParameter("@ForcastedImportQuantityPerYear", Forcastedimportquantityperyear));
                command.Parameters.Add(new SqlParameter("@LocationOfStudy", Locationofstudy));
                command.Parameters.Add(new SqlParameter("@Remark", Remark));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CMarketStudies::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Productguid, DateTime Startdate, DateTime Enddate, int Status, string Numberofexistingproductswithsamegenericname, string Currentaverageprice, string Suggestedimportfobprice, string Currentdemandquantityperyear, string Forcastedimportquantityperyear, string Locationofstudy, string Remark)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblMarketStudies" +
                                   " Set ProductGuid = @ProductGuid, " +
                                   " StartDate = @StartDate, " +
                                   " EndDate = @EndDate, " +
                                   " Status = @Status, " +
                                   " NumberOfExistingProductsWithSameGenericName = @NumberOfExistingProductsWithSameGenericName, " +
                                   " CurrentAveragePrice = @CurrentAveragePrice, " +
                                   " SuggestedImportFOBPrice = @SuggestedImportFOBPrice, " +
                                   " CurrentDemandQuantityPerYear = @CurrentDemandQuantityPerYear, " +
                                   " ForcastedImportQuantityPerYear = @ForcastedImportQuantityPerYear, " +
                                   " LocationOfStudy = @LocationOfStudy, " +
                                   " Remark = @Remark" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                if (Startdate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@StartDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@StartDate", Startdate));
                if (Enddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@EndDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EndDate", Enddate));
                command.Parameters.Add(new SqlParameter("@Status", Status));
                command.Parameters.Add(new SqlParameter("@NumberOfExistingProductsWithSameGenericName", Numberofexistingproductswithsamegenericname));
                command.Parameters.Add(new SqlParameter("@CurrentAveragePrice", Currentaverageprice));
                command.Parameters.Add(new SqlParameter("@SuggestedImportFOBPrice", Suggestedimportfobprice));
                command.Parameters.Add(new SqlParameter("@CurrentDemandQuantityPerYear", Currentdemandquantityperyear));
                command.Parameters.Add(new SqlParameter("@ForcastedImportQuantityPerYear", Forcastedimportquantityperyear));
                command.Parameters.Add(new SqlParameter("@LocationOfStudy", Locationofstudy));
                command.Parameters.Add(new SqlParameter("@Remark", Remark));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CMarketStudies::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblMarketStudies Where Id = @Id ";
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
                throw new Exception("CMarketStudies::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Productguid, DateTime Startdate, string Locationofstudy)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblMarketStudies] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND StartDate = @StartDate " +
                                       " AND LocationOfStudy = @LocationOfStudy";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblMarketStudies] WHERE " +
                                       " ProductGuid = @ProductGuid " +
                                       " AND StartDate = @StartDate " +
                                       " AND LocationOfStudy = @LocationOfStudy " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                command.Parameters.Add(new SqlParameter("@StartDate", Startdate));
                command.Parameters.Add(new SqlParameter("@LocationOfStudy", Locationofstudy));
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
                throw new Exception("CMarketStudies::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CMarketStudies> GetList()
        {
            List<CMarketStudies> RecordsList = new List<CMarketStudies>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblMarketStudies";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CMarketStudies objCMarketStudies = new CMarketStudies();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCMarketStudies.Id = 0;
                    else
                        objCMarketStudies.Id = (int)dr["Id"];
                    if (dr["ProductGuid"].Equals(DBNull.Value))
                        objCMarketStudies.Productguid = string.Empty;
                    else
                        objCMarketStudies.Productguid = (string)dr["ProductGuid"];
                    if (dr["StartDate"].Equals(DBNull.Value))
                        objCMarketStudies.Startdate = DateTime.MinValue;
                    else
                        objCMarketStudies.Startdate = (DateTime)dr["StartDate"];
                    if (dr["EndDate"].Equals(DBNull.Value))
                        objCMarketStudies.Enddate = DateTime.MinValue;
                    else
                        objCMarketStudies.Enddate = (DateTime)dr["EndDate"];
                    if (dr["Status"].Equals(DBNull.Value))
                        objCMarketStudies.Status = 0;
                    else
                        objCMarketStudies.Status = (int)dr["Status"];
                    if (dr["NumberOfExistingProductsWithSameGenericName"].Equals(DBNull.Value))
                        objCMarketStudies.Numberofexistingproductswithsamegenericname = string.Empty;
                    else
                        objCMarketStudies.Numberofexistingproductswithsamegenericname = (string)dr["NumberOfExistingProductsWithSameGenericName"];
                    if (dr["CurrentAveragePrice"].Equals(DBNull.Value))
                        objCMarketStudies.Currentaverageprice = string.Empty;
                    else
                        objCMarketStudies.Currentaverageprice = (string)dr["CurrentAveragePrice"];
                    if (dr["SuggestedImportFOBPrice"].Equals(DBNull.Value))
                        objCMarketStudies.Suggestedimportfobprice = string.Empty;
                    else
                        objCMarketStudies.Suggestedimportfobprice = (string)dr["SuggestedImportFOBPrice"];
                    if (dr["CurrentDemandQuantityPerYear"].Equals(DBNull.Value))
                        objCMarketStudies.Currentdemandquantityperyear = string.Empty;
                    else
                        objCMarketStudies.Currentdemandquantityperyear = (string)dr["CurrentDemandQuantityPerYear"];
                    if (dr["ForcastedImportQuantityPerYear"].Equals(DBNull.Value))
                        objCMarketStudies.Forcastedimportquantityperyear = string.Empty;
                    else
                        objCMarketStudies.Forcastedimportquantityperyear = (string)dr["ForcastedImportQuantityPerYear"];
                    if (dr["LocationOfStudy"].Equals(DBNull.Value))
                        objCMarketStudies.Locationofstudy = string.Empty;
                    else
                        objCMarketStudies.Locationofstudy = (string)dr["LocationOfStudy"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCMarketStudies.Remark = string.Empty;
                    else
                        objCMarketStudies.Remark = (string)dr["Remark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCMarketStudies.Tablerowguid = string.Empty;
                    else
                        objCMarketStudies.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCMarketStudies);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CMarketStudies::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CMarketStudies> GetList(string Productguid)
        {
            List<CMarketStudies> RecordsList = new List<CMarketStudies>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblMarketStudies where ProductGuid=@ProductGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ProductGuid", Productguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CMarketStudies objCMarketStudies = new CMarketStudies();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCMarketStudies.Id = 0;
                    else
                        objCMarketStudies.Id = (int)dr["Id"];
                    if (dr["ProductGuid"].Equals(DBNull.Value))
                        objCMarketStudies.Productguid = string.Empty;
                    else
                        objCMarketStudies.Productguid = (string)dr["ProductGuid"];
                    if (dr["StartDate"].Equals(DBNull.Value))
                        objCMarketStudies.Startdate = DateTime.MinValue;
                    else
                        objCMarketStudies.Startdate = (DateTime)dr["StartDate"];
                    if (dr["EndDate"].Equals(DBNull.Value))
                        objCMarketStudies.Enddate = DateTime.MinValue;
                    else
                        objCMarketStudies.Enddate = (DateTime)dr["EndDate"];
                    if (dr["Status"].Equals(DBNull.Value))
                        objCMarketStudies.Status = 0;
                    else
                        objCMarketStudies.Status = (int)dr["Status"];
                    if (dr["NumberOfExistingProductsWithSameGenericName"].Equals(DBNull.Value))
                        objCMarketStudies.Numberofexistingproductswithsamegenericname = string.Empty;
                    else
                        objCMarketStudies.Numberofexistingproductswithsamegenericname = (string)dr["NumberOfExistingProductsWithSameGenericName"];
                    if (dr["CurrentAveragePrice"].Equals(DBNull.Value))
                        objCMarketStudies.Currentaverageprice = string.Empty;
                    else
                        objCMarketStudies.Currentaverageprice = (string)dr["CurrentAveragePrice"];
                    if (dr["SuggestedImportFOBPrice"].Equals(DBNull.Value))
                        objCMarketStudies.Suggestedimportfobprice = string.Empty;
                    else
                        objCMarketStudies.Suggestedimportfobprice = (string)dr["SuggestedImportFOBPrice"];
                    if (dr["CurrentDemandQuantityPerYear"].Equals(DBNull.Value))
                        objCMarketStudies.Currentdemandquantityperyear = string.Empty;
                    else
                        objCMarketStudies.Currentdemandquantityperyear = (string)dr["CurrentDemandQuantityPerYear"];
                    if (dr["ForcastedImportQuantityPerYear"].Equals(DBNull.Value))
                        objCMarketStudies.Forcastedimportquantityperyear = string.Empty;
                    else
                        objCMarketStudies.Forcastedimportquantityperyear = (string)dr["ForcastedImportQuantityPerYear"];
                    if (dr["LocationOfStudy"].Equals(DBNull.Value))
                        objCMarketStudies.Locationofstudy = string.Empty;
                    else
                        objCMarketStudies.Locationofstudy = (string)dr["LocationOfStudy"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCMarketStudies.Remark = string.Empty;
                    else
                        objCMarketStudies.Remark = (string)dr["Remark"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCMarketStudies.Tablerowguid = string.Empty;
                    else
                        objCMarketStudies.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCMarketStudies);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CMarketStudies::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblMarketStudies] WHERE Id = @Id";
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
                throw new Exception("CMarketStudies::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblMarketStudies] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CMarketStudies::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
