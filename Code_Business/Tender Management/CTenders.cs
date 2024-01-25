//
// ...
// Wizard generated code
// Date: 4/14/2010 9:58:54 AM
// Class: CTenders
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
    class CTenders
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CTenders()
        {
            _ConnectionString = ConnectionString;
        }
        public CTenders(int Id, string Customerguid, int Bidtype, string Bidnumber, string Bidname, string Biddetail, DateTime Bidadvertisementdate, string Bidadvertisementreference, string Contactperson, string Contacttel1, string Contacttel2, string Contactfax, string Contactemail, decimal Biddocumentpurchaseamount, DateTime Biddocumentpurchasedatefrom, DateTime Biddocumentpurchasetimefrom, DateTime Biddocumentpurchasedateto, DateTime Biddocumentpurchasetimeto, string Biddocumentreference, DateTime Bidsubmissiondeadlinedate, DateTime Bidsubmissiondeadlinetime, DateTime Bidopeningdate, DateTime Bidopeningtime, decimal Bidsecurityamount, decimal Bidsecuritypercentage, int Bidstatus, string Submittedby, DateTime Submitteddate, string Remark, DateTime Bidbondissuancedate, string Bidbondbankguid, string Bidbondbranch, string Bidbondnumber, DateTime Bidbondreturndate, int Bidbondstatus, DateTime Performancebondissuancedate, string Performancebondbankguid, string Performancebondbranch, string Performancebondnumber, DateTime Performancebondreturndate, int Performancebondstatus)
        {
            _Id = Id;
            _CustomerGuid = Customerguid;
            _BidType = Bidtype;
            _BidNumber = Bidnumber;
            _BidName = Bidname;
            _BidDetail = Biddetail;
            _BidAdvertisementDate = Bidadvertisementdate;
            _BidAdvertisementReference = Bidadvertisementreference;
            _ContactPerson = Contactperson;
            _ContactTel1 = Contacttel1;
            _ContactTel2 = Contacttel2;
            _ContactFax = Contactfax;
            _ContactEmail = Contactemail;
            _BidDocumentPurchaseAmount = Biddocumentpurchaseamount;
            _BidDocumentPurchaseDateFrom = Biddocumentpurchasedatefrom;
            _BidDocumentPurchaseTimeFrom = Biddocumentpurchasetimefrom;
            _BidDocumentPurchaseDateTo = Biddocumentpurchasedateto;
            _BidDocumentPurchaseTimeTo = Biddocumentpurchasetimeto;
            _BidDocumentReference = Biddocumentreference;
            _BidSubmissionDeadlineDate = Bidsubmissiondeadlinedate;
            _BidSubmissionDeadlineTime = Bidsubmissiondeadlinetime;
            _BidOpeningDate = Bidopeningdate;
            _BidOpeningTime = Bidopeningtime;
            _BidSecurityAmount = Bidsecurityamount;
            _BidSecurityPercentage = Bidsecuritypercentage;
            _BidStatus = Bidstatus;
            _SubmittedBy = Submittedby;
            _SubmittedDate = Submitteddate;
            _Remark = Remark;
            _BidBondIssuanceDate = Bidbondissuancedate;
            _BidBondBankGuid = Bidbondbankguid;
            _BidBondBranch = Bidbondbranch;
            _BidBondNumber = Bidbondnumber;
            _BidBondReturnDate = Bidbondreturndate;
            _BidBondStatus = Bidbondstatus;
            _PerformanceBondIssuanceDate = Performancebondissuancedate;
            _PerformanceBondBankGuid = Performancebondbankguid;
            _PerformanceBondBranch = Performancebondbranch;
            _PerformanceBondNumber = Performancebondnumber;
            _PerformanceBondReturnDate = Performancebondreturndate;
            _PerformanceBondStatus = Performancebondstatus;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _CustomerGuid;
        public string Customerguid
        {
            get { return _CustomerGuid; }
            set { _CustomerGuid = value; }
        }

        int _BidType;
        public int Bidtype
        {
            get { return _BidType; }
            set { _BidType = value; }
        }

        string _BidNumber;
        public string Bidnumber
        {
            get { return _BidNumber; }
            set { _BidNumber = value; }
        }

        string _BidName;
        public string Bidname
        {
            get { return _BidName; }
            set { _BidName = value; }
        }

        string _BidDetail;
        public string Biddetail
        {
            get { return _BidDetail; }
            set { _BidDetail = value; }
        }

        DateTime _BidAdvertisementDate;
        public DateTime Bidadvertisementdate
        {
            get { return _BidAdvertisementDate; }
            set { _BidAdvertisementDate = value; }
        }

        string _BidAdvertisementReference;
        public string Bidadvertisementreference
        {
            get { return _BidAdvertisementReference; }
            set { _BidAdvertisementReference = value; }
        }

        string _ContactPerson;
        public string Contactperson
        {
            get { return _ContactPerson; }
            set { _ContactPerson = value; }
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

        string _ContactFax;
        public string Contactfax
        {
            get { return _ContactFax; }
            set { _ContactFax = value; }
        }

        string _ContactEmail;
        public string Contactemail
        {
            get { return _ContactEmail; }
            set { _ContactEmail = value; }
        }

        decimal _BidDocumentPurchaseAmount;
        public decimal Biddocumentpurchaseamount
        {
            get { return _BidDocumentPurchaseAmount; }
            set { _BidDocumentPurchaseAmount = value; }
        }

        DateTime _BidDocumentPurchaseDateFrom;
        public DateTime Biddocumentpurchasedatefrom
        {
            get { return _BidDocumentPurchaseDateFrom; }
            set { _BidDocumentPurchaseDateFrom = value; }
        }

        DateTime _BidDocumentPurchaseTimeFrom;
        public DateTime Biddocumentpurchasetimefrom
        {
            get { return _BidDocumentPurchaseTimeFrom; }
            set { _BidDocumentPurchaseTimeFrom = value; }
        }

        DateTime _BidDocumentPurchaseDateTo;
        public DateTime Biddocumentpurchasedateto
        {
            get { return _BidDocumentPurchaseDateTo; }
            set { _BidDocumentPurchaseDateTo = value; }
        }

        DateTime _BidDocumentPurchaseTimeTo;
        public DateTime Biddocumentpurchasetimeto
        {
            get { return _BidDocumentPurchaseTimeTo; }
            set { _BidDocumentPurchaseTimeTo = value; }
        }

        string _BidDocumentReference;
        public string Biddocumentreference
        {
            get { return _BidDocumentReference; }
            set { _BidDocumentReference = value; }
        }

        DateTime _BidSubmissionDeadlineDate;
        public DateTime Bidsubmissiondeadlinedate
        {
            get { return _BidSubmissionDeadlineDate; }
            set { _BidSubmissionDeadlineDate = value; }
        }

        DateTime _BidSubmissionDeadlineTime;
        public DateTime Bidsubmissiondeadlinetime
        {
            get { return _BidSubmissionDeadlineTime; }
            set { _BidSubmissionDeadlineTime = value; }
        }

        DateTime _BidOpeningDate;
        public DateTime Bidopeningdate
        {
            get { return _BidOpeningDate; }
            set { _BidOpeningDate = value; }
        }

        DateTime _BidOpeningTime;
        public DateTime Bidopeningtime
        {
            get { return _BidOpeningTime; }
            set { _BidOpeningTime = value; }
        }

        decimal _BidSecurityAmount;
        public decimal Bidsecurityamount
        {
            get { return _BidSecurityAmount; }
            set { _BidSecurityAmount = value; }
        }

        decimal _BidSecurityPercentage;
        public decimal Bidsecuritypercentage
        {
            get { return _BidSecurityPercentage; }
            set { _BidSecurityPercentage = value; }
        }

        int _BidStatus;
        public int Bidstatus
        {
            get { return _BidStatus; }
            set { _BidStatus = value; }
        }

        string _SubmittedBy;
        public string Submittedby
        {
            get { return _SubmittedBy; }
            set { _SubmittedBy = value; }
        }

        DateTime _SubmittedDate;
        public DateTime Submitteddate
        {
            get { return _SubmittedDate; }
            set { _SubmittedDate = value; }
        }

        string _Remark;
        public string Remark
        {
            get { return _Remark; }
            set { _Remark = value; }
        }

        DateTime _BidBondIssuanceDate;
        public DateTime Bidbondissuancedate
        {
            get { return _BidBondIssuanceDate; }
            set { _BidBondIssuanceDate = value; }
        }

        string _BidBondBankGuid;
        public string Bidbondbankguid
        {
            get { return _BidBondBankGuid; }
            set { _BidBondBankGuid = value; }
        }

        string _BidBondBranch;
        public string Bidbondbranch
        {
            get { return _BidBondBranch; }
            set { _BidBondBranch = value; }
        }

        string _BidBondNumber;
        public string Bidbondnumber
        {
            get { return _BidBondNumber; }
            set { _BidBondNumber = value; }
        }

        DateTime _BidBondReturnDate;
        public DateTime Bidbondreturndate
        {
            get { return _BidBondReturnDate; }
            set { _BidBondReturnDate = value; }
        }

        int _BidBondStatus;
        public int Bidbondstatus
        {
            get { return _BidBondStatus; }
            set { _BidBondStatus = value; }
        }

        DateTime _PerformanceBondIssuanceDate;
        public DateTime Performancebondissuancedate
        {
            get { return _PerformanceBondIssuanceDate; }
            set { _PerformanceBondIssuanceDate = value; }
        }

        string _PerformanceBondBankGuid;
        public string Performancebondbankguid
        {
            get { return _PerformanceBondBankGuid; }
            set { _PerformanceBondBankGuid = value; }
        }

        string _PerformanceBondBranch;
        public string Performancebondbranch
        {
            get { return _PerformanceBondBranch; }
            set { _PerformanceBondBranch = value; }
        }

        string _PerformanceBondNumber;
        public string Performancebondnumber
        {
            get { return _PerformanceBondNumber; }
            set { _PerformanceBondNumber = value; }
        }

        DateTime _PerformanceBondReturnDate;
        public DateTime Performancebondreturndate
        {
            get { return _PerformanceBondReturnDate; }
            set { _PerformanceBondReturnDate = value; }
        }

        int _PerformanceBondStatus;
        public int Performancebondstatus
        {
            get { return _PerformanceBondStatus; }
            set { _PerformanceBondStatus = value; }
        }

        string _CustomerName;
        public string Customername
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
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
            command.CommandText = "Select * from tblTenders where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenders");
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
                    if (dTable.Rows[0]["CustomerGuid"].Equals(DBNull.Value))
                        _CustomerGuid = string.Empty;
                    else
                        _CustomerGuid = (string)dTable.Rows[0]["CustomerGuid"];
                    if (dTable.Rows[0]["BidType"].Equals(DBNull.Value))
                        _BidType = 0;
                    else
                        _BidType = (int)dTable.Rows[0]["BidType"];
                    if (dTable.Rows[0]["BidNumber"].Equals(DBNull.Value))
                        _BidNumber = string.Empty;
                    else
                        _BidNumber = (string)dTable.Rows[0]["BidNumber"];
                    if (dTable.Rows[0]["BidName"].Equals(DBNull.Value))
                        _BidName = string.Empty;
                    else
                        _BidName = (string)dTable.Rows[0]["BidName"];
                    if (dTable.Rows[0]["BidDetail"].Equals(DBNull.Value))
                        _BidDetail = string.Empty;
                    else
                        _BidDetail = (string)dTable.Rows[0]["BidDetail"];
                    if (dTable.Rows[0]["BidAdvertisementDate"].Equals(DBNull.Value))
                        _BidAdvertisementDate = DateTime.MinValue;
                    else
                        _BidAdvertisementDate = (DateTime)dTable.Rows[0]["BidAdvertisementDate"];
                    if (dTable.Rows[0]["BidAdvertisementReference"].Equals(DBNull.Value))
                        _BidAdvertisementReference = string.Empty;
                    else
                        _BidAdvertisementReference = (string)dTable.Rows[0]["BidAdvertisementReference"];
                    if (dTable.Rows[0]["ContactPerson"].Equals(DBNull.Value))
                        _ContactPerson = string.Empty;
                    else
                        _ContactPerson = (string)dTable.Rows[0]["ContactPerson"];
                    if (dTable.Rows[0]["ContactTel1"].Equals(DBNull.Value))
                        _ContactTel1 = string.Empty;
                    else
                        _ContactTel1 = (string)dTable.Rows[0]["ContactTel1"];
                    if (dTable.Rows[0]["ContactTel2"].Equals(DBNull.Value))
                        _ContactTel2 = string.Empty;
                    else
                        _ContactTel2 = (string)dTable.Rows[0]["ContactTel2"];
                    if (dTable.Rows[0]["ContactFax"].Equals(DBNull.Value))
                        _ContactFax = string.Empty;
                    else
                        _ContactFax = (string)dTable.Rows[0]["ContactFax"];
                    if (dTable.Rows[0]["ContactEmail"].Equals(DBNull.Value))
                        _ContactEmail = string.Empty;
                    else
                        _ContactEmail = (string)dTable.Rows[0]["ContactEmail"];
                    if (dTable.Rows[0]["BidDocumentPurchaseAmount"].Equals(DBNull.Value))
                        _BidDocumentPurchaseAmount = decimal.Zero;
                    else
                        _BidDocumentPurchaseAmount = (decimal)dTable.Rows[0]["BidDocumentPurchaseAmount"];
                    if (dTable.Rows[0]["BidDocumentPurchaseDateFrom"].Equals(DBNull.Value))
                        _BidDocumentPurchaseDateFrom = DateTime.MinValue;
                    else
                        _BidDocumentPurchaseDateFrom = (DateTime)dTable.Rows[0]["BidDocumentPurchaseDateFrom"];
                    if (dTable.Rows[0]["BidDocumentPurchaseTimeFrom"].Equals(DBNull.Value))
                        _BidDocumentPurchaseTimeFrom = DateTime.MinValue;
                    else
                        _BidDocumentPurchaseTimeFrom = (DateTime)dTable.Rows[0]["BidDocumentPurchaseTimeFrom"];
                    if (dTable.Rows[0]["BidDocumentPurchaseDateTo"].Equals(DBNull.Value))
                        _BidDocumentPurchaseDateTo = DateTime.MinValue;
                    else
                        _BidDocumentPurchaseDateTo = (DateTime)dTable.Rows[0]["BidDocumentPurchaseDateTo"];
                    if (dTable.Rows[0]["BidDocumentPurchaseTimeTo"].Equals(DBNull.Value))
                        _BidDocumentPurchaseTimeTo = DateTime.MinValue;
                    else
                        _BidDocumentPurchaseTimeTo = (DateTime)dTable.Rows[0]["BidDocumentPurchaseTimeTo"];
                    if (dTable.Rows[0]["BidDocumentReference"].Equals(DBNull.Value))
                        _BidDocumentReference = string.Empty;
                    else
                        _BidDocumentReference = (string)dTable.Rows[0]["BidDocumentReference"];
                    if (dTable.Rows[0]["BidSubmissionDeadlineDate"].Equals(DBNull.Value))
                        _BidSubmissionDeadlineDate = DateTime.MinValue;
                    else
                        _BidSubmissionDeadlineDate = (DateTime)dTable.Rows[0]["BidSubmissionDeadlineDate"];
                    if (dTable.Rows[0]["BidSubmissionDeadlineTime"].Equals(DBNull.Value))
                        _BidSubmissionDeadlineTime = DateTime.MinValue;
                    else
                        _BidSubmissionDeadlineTime = (DateTime)dTable.Rows[0]["BidSubmissionDeadlineTime"];
                    if (dTable.Rows[0]["BidOpeningDate"].Equals(DBNull.Value))
                        _BidOpeningDate = DateTime.MinValue;
                    else
                        _BidOpeningDate = (DateTime)dTable.Rows[0]["BidOpeningDate"];
                    if (dTable.Rows[0]["BidOpeningTime"].Equals(DBNull.Value))
                        _BidOpeningTime = DateTime.MinValue;
                    else
                        _BidOpeningTime = (DateTime)dTable.Rows[0]["BidOpeningTime"];
                    if (dTable.Rows[0]["BidSecurityAmount"].Equals(DBNull.Value))
                        _BidSecurityAmount = decimal.Zero;
                    else
                        _BidSecurityAmount = (decimal)dTable.Rows[0]["BidSecurityAmount"];
                    if (dTable.Rows[0]["BidSecurityPercentage"].Equals(DBNull.Value))
                        _BidSecurityPercentage = decimal.Zero;
                    else
                        _BidSecurityPercentage = (decimal)dTable.Rows[0]["BidSecurityPercentage"];
                    if (dTable.Rows[0]["BidStatus"].Equals(DBNull.Value))
                        _BidStatus = 0;
                    else
                        _BidStatus = (int)dTable.Rows[0]["BidStatus"];
                    if (dTable.Rows[0]["SubmittedBy"].Equals(DBNull.Value))
                        _SubmittedBy = string.Empty;
                    else
                        _SubmittedBy = (string)dTable.Rows[0]["SubmittedBy"];
                    if (dTable.Rows[0]["SubmittedDate"].Equals(DBNull.Value))
                        _SubmittedDate = DateTime.MinValue;
                    else
                        _SubmittedDate = (DateTime)dTable.Rows[0]["SubmittedDate"];
                    if (dTable.Rows[0]["Remark"].Equals(DBNull.Value))
                        _Remark = string.Empty;
                    else
                        _Remark = (string)dTable.Rows[0]["Remark"];
                    if (dTable.Rows[0]["BidBondIssuanceDate"].Equals(DBNull.Value))
                        _BidBondIssuanceDate = DateTime.MinValue;
                    else
                        _BidBondIssuanceDate = (DateTime)dTable.Rows[0]["BidBondIssuanceDate"];
                    if (dTable.Rows[0]["BidBondBankGuid"].Equals(DBNull.Value))
                        _BidBondBankGuid = string.Empty;
                    else
                        _BidBondBankGuid = (string)dTable.Rows[0]["BidBondBankGuid"];
                    if (dTable.Rows[0]["BidBondBranch"].Equals(DBNull.Value))
                        _BidBondBranch = string.Empty;
                    else
                        _BidBondBranch = (string)dTable.Rows[0]["BidBondBranch"];
                    if (dTable.Rows[0]["BidBondNumber"].Equals(DBNull.Value))
                        _BidBondNumber = string.Empty;
                    else
                        _BidBondNumber = (string)dTable.Rows[0]["BidBondNumber"];
                    if (dTable.Rows[0]["BidBondReturnDate"].Equals(DBNull.Value))
                        _BidBondReturnDate = DateTime.MinValue;
                    else
                        _BidBondReturnDate = (DateTime)dTable.Rows[0]["BidBondReturnDate"];
                    if (dTable.Rows[0]["BidBondStatus"].Equals(DBNull.Value))
                        _BidBondStatus = 0;
                    else
                        _BidBondStatus = (int)dTable.Rows[0]["BidBondStatus"];
                    if (dTable.Rows[0]["PerformanceBondIssuanceDate"].Equals(DBNull.Value))
                        _PerformanceBondIssuanceDate = DateTime.MinValue;
                    else
                        _PerformanceBondIssuanceDate = (DateTime)dTable.Rows[0]["PerformanceBondIssuanceDate"];
                    if (dTable.Rows[0]["PerformanceBondBankGuid"].Equals(DBNull.Value))
                        _PerformanceBondBankGuid = string.Empty;
                    else
                        _PerformanceBondBankGuid = (string)dTable.Rows[0]["PerformanceBondBankGuid"];
                    if (dTable.Rows[0]["PerformanceBondBranch"].Equals(DBNull.Value))
                        _PerformanceBondBranch = string.Empty;
                    else
                        _PerformanceBondBranch = (string)dTable.Rows[0]["PerformanceBondBranch"];
                    if (dTable.Rows[0]["PerformanceBondNumber"].Equals(DBNull.Value))
                        _PerformanceBondNumber = string.Empty;
                    else
                        _PerformanceBondNumber = (string)dTable.Rows[0]["PerformanceBondNumber"];
                    if (dTable.Rows[0]["PerformanceBondReturnDate"].Equals(DBNull.Value))
                        _PerformanceBondReturnDate = DateTime.MinValue;
                    else
                        _PerformanceBondReturnDate = (DateTime)dTable.Rows[0]["PerformanceBondReturnDate"];
                    if (dTable.Rows[0]["PerformanceBondStatus"].Equals(DBNull.Value))
                        _PerformanceBondStatus = 0;
                    else
                        _PerformanceBondStatus = (int)dTable.Rows[0]["PerformanceBondStatus"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenders::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblTenders";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenders");
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
                throw new Exception("CTenders::GetRecords::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Customerguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblTenders where CustomerGuid=@CustomerGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblTenders");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenders::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblTenders" +
                                   " (CustomerGuid, " +
                                   " BidType, " +
                                   " BidNumber, " +
                                   " BidName, " +
                                   " BidDetail, " +
                                   " BidAdvertisementDate, " +
                                   " BidAdvertisementReference, " +
                                   " ContactPerson, " +
                                   " ContactTel1, " +
                                   " ContactTel2, " +
                                   " ContactFax, " +
                                   " ContactEmail, " +
                                   " BidDocumentPurchaseAmount, " +
                                   " BidDocumentPurchaseDateFrom, " +
                                   " BidDocumentPurchaseTimeFrom, " +
                                   " BidDocumentPurchaseDateTo, " +
                                   " BidDocumentPurchaseTimeTo, " +
                                   " BidDocumentReference, " +
                                   " BidSubmissionDeadlineDate, " +
                                   " BidSubmissionDeadlineTime, " +
                                   " BidOpeningDate, " +
                                   " BidOpeningTime, " +
                                   " BidSecurityAmount, " +
                                   " BidSecurityPercentage, " +
                                   " BidStatus, " +
                                   " SubmittedBy, " +
                                   " SubmittedDate, " +
                                   " Remark, " +
                                   " BidBondIssuanceDate, " +
                                   " BidBondBankGuid, " +
                                   " BidBondBranch, " +
                                   " BidBondNumber, " +
                                   " BidBondReturnDate, " +
                                   " BidBondStatus, " +
                                   " PerformanceBondIssuanceDate, " +
                                   " PerformanceBondBankGuid, " +
                                   " PerformanceBondBranch, " +
                                   " PerformanceBondNumber, " +
                                   " PerformanceBondReturnDate, " +
                                   " PerformanceBondStatus)" +
                                   " Values (@CustomerGuid, " +
                                   " @BidType, " +
                                   " @BidNumber, " +
                                   " @BidName, " +
                                   " @BidDetail, " +
                                   " @BidAdvertisementDate, " +
                                   " @BidAdvertisementReference, " +
                                   " @ContactPerson, " +
                                   " @ContactTel1, " +
                                   " @ContactTel2, " +
                                   " @ContactFax, " +
                                   " @ContactEmail, " +
                                   " @BidDocumentPurchaseAmount, " +
                                   " @BidDocumentPurchaseDateFrom, " +
                                   " @BidDocumentPurchaseTimeFrom, " +
                                   " @BidDocumentPurchaseDateTo, " +
                                   " @BidDocumentPurchaseTimeTo, " +
                                   " @BidDocumentReference, " +
                                   " @BidSubmissionDeadlineDate, " +
                                   " @BidSubmissionDeadlineTime, " +
                                   " @BidOpeningDate, " +
                                   " @BidOpeningTime, " +
                                   " @BidSecurityAmount, " +
                                   " @BidSecurityPercentage, " +
                                   " @BidStatus, " +
                                   " @SubmittedBy, " +
                                   " @SubmittedDate, " +
                                   " @Remark, " +
                                   " @BidBondIssuanceDate, " +
                                   " @BidBondBankGuid, " +
                                   " @BidBondBranch, " +
                                   " @BidBondNumber, " +
                                   " @BidBondReturnDate, " +
                                   " @BidBondStatus, " +
                                   " @PerformanceBondIssuanceDate, " +
                                   " @PerformanceBondBankGuid, " +
                                   " @PerformanceBondBranch, " +
                                   " @PerformanceBondNumber, " +
                                   " @PerformanceBondReturnDate, " +
                                   " @PerformanceBondStatus)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_CustomerGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CustomerGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                if (_BidType == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidType", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidType", _BidType));
                if (_BidNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidNumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidNumber", _BidNumber));
                if (_BidName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidName", _BidName));
                if (_BidDetail == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidDetail", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDetail", _BidDetail));
                if (_BidAdvertisementDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidAdvertisementDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidAdvertisementDate", _BidAdvertisementDate));
                if (_BidAdvertisementReference == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidAdvertisementReference", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidAdvertisementReference", _BidAdvertisementReference));
                if (_ContactPerson == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactPerson", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactPerson", _ContactPerson));
                if (_ContactTel1 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactTel1", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactTel1", _ContactTel1));
                if (_ContactTel2 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactTel2", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactTel2", _ContactTel2));
                if (_ContactFax == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactFax", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactFax", _ContactFax));
                if (_ContactEmail == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactEmail", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactEmail", _ContactEmail));
                if (_BidDocumentPurchaseAmount == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseAmount", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseAmount", _BidDocumentPurchaseAmount));
                if (_BidDocumentPurchaseDateFrom == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateFrom", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateFrom", _BidDocumentPurchaseDateFrom));
                if (_BidDocumentPurchaseTimeFrom == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeFrom", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeFrom", _BidDocumentPurchaseTimeFrom));
                if (_BidDocumentPurchaseDateTo == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateTo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateTo", _BidDocumentPurchaseDateTo));
                if (_BidDocumentPurchaseTimeTo == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeTo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeTo", _BidDocumentPurchaseTimeTo));
                if (_BidDocumentReference == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidDocumentReference", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentReference", _BidDocumentReference));
                if (_BidSubmissionDeadlineDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineDate", _BidSubmissionDeadlineDate));
                if (_BidSubmissionDeadlineTime == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineTime", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineTime", _BidSubmissionDeadlineTime));
                if (_BidOpeningDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidOpeningDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidOpeningDate", _BidOpeningDate));
                if (_BidOpeningTime == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidOpeningTime", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidOpeningTime", _BidOpeningTime));
                if (_BidSecurityAmount == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidSecurityAmount", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidSecurityAmount", _BidSecurityAmount));
                if (_BidSecurityPercentage == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidSecurityPercentage", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidSecurityPercentage", _BidSecurityPercentage));
                if (_BidStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidStatus", _BidStatus));
                if (_SubmittedBy == string.Empty)
                    command.Parameters.Add(new SqlParameter("@SubmittedBy", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmittedBy", _SubmittedBy));
                if (_SubmittedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmittedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmittedDate", _SubmittedDate));
                if (_Remark == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Remark", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Remark", _Remark));
                if (_BidBondIssuanceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidBondIssuanceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondIssuanceDate", _BidBondIssuanceDate));
                if (_BidBondBankGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidBondBankGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondBankGuid", _BidBondBankGuid));
                if (_BidBondBranch == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidBondBranch", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondBranch", _BidBondBranch));
                if (_BidBondNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidBondNumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondNumber", _BidBondNumber));
                if (_BidBondReturnDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidBondReturnDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondReturnDate", _BidBondReturnDate));
                if (_BidBondStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidBondStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondStatus", _BidBondStatus));
                if (_PerformanceBondIssuanceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondIssuanceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondIssuanceDate", _PerformanceBondIssuanceDate));
                if (_PerformanceBondBankGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondBankGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondBankGuid", _PerformanceBondBankGuid));
                if (_PerformanceBondBranch == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondBranch", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondBranch", _PerformanceBondBranch));
                if (_PerformanceBondNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondNumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondNumber", _PerformanceBondNumber));
                if (_PerformanceBondReturnDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondReturnDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondReturnDate", _PerformanceBondReturnDate));
                if (_PerformanceBondStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondStatus", _PerformanceBondStatus));

                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenders::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblTenders" +
                                   " Set CustomerGuid = @CustomerGuid, " +
                                   " BidType = @BidType, " +
                                   " BidNumber = @BidNumber, " +
                                   " BidName = @BidName, " +
                                   " BidDetail = @BidDetail, " +
                                   " BidAdvertisementDate = @BidAdvertisementDate, " +
                                   " BidAdvertisementReference = @BidAdvertisementReference, " +
                                   " ContactPerson = @ContactPerson, " +
                                   " ContactTel1 = @ContactTel1, " +
                                   " ContactTel2 = @ContactTel2, " +
                                   " ContactFax = @ContactFax, " +
                                   " ContactEmail = @ContactEmail, " +
                                   " BidDocumentPurchaseAmount = @BidDocumentPurchaseAmount, " +
                                   " BidDocumentPurchaseDateFrom = @BidDocumentPurchaseDateFrom, " +
                                   " BidDocumentPurchaseTimeFrom = @BidDocumentPurchaseTimeFrom, " +
                                   " BidDocumentPurchaseDateTo = @BidDocumentPurchaseDateTo, " +
                                   " BidDocumentPurchaseTimeTo = @BidDocumentPurchaseTimeTo, " +
                                   " BidDocumentReference = @BidDocumentReference, " +
                                   " BidSubmissionDeadlineDate = @BidSubmissionDeadlineDate, " +
                                   " BidSubmissionDeadlineTime = @BidSubmissionDeadlineTime, " +
                                   " BidOpeningDate = @BidOpeningDate, " +
                                   " BidOpeningTime = @BidOpeningTime, " +
                                   " BidSecurityAmount = @BidSecurityAmount, " +
                                   " BidSecurityPercentage = @BidSecurityPercentage, " +
                                   " BidStatus = @BidStatus, " +
                                   " SubmittedBy = @SubmittedBy, " +
                                   " SubmittedDate = @SubmittedDate, " +
                                   " Remark = @Remark, " +
                                   " BidBondIssuanceDate = @BidBondIssuanceDate, " +
                                   " BidBondBankGuid = @BidBondBankGuid, " +
                                   " BidBondBranch = @BidBondBranch, " +
                                   " BidBondNumber = @BidBondNumber, " +
                                   " BidBondReturnDate = @BidBondReturnDate, " +
                                   " BidBondStatus = @BidBondStatus, " +
                                   " PerformanceBondIssuanceDate = @PerformanceBondIssuanceDate, " +
                                   " PerformanceBondBankGuid = @PerformanceBondBankGuid, " +
                                   " PerformanceBondBranch = @PerformanceBondBranch, " +
                                   " PerformanceBondNumber = @PerformanceBondNumber, " +
                                   " PerformanceBondReturnDate = @PerformanceBondReturnDate, " +
                                   " PerformanceBondStatus = @PerformanceBondStatus" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_CustomerGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CustomerGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                if (_BidType == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidType", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidType", _BidType));
                if (_BidNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidNumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidNumber", _BidNumber));
                if (_BidName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidName", _BidName));
                if (_BidDetail == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidDetail", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDetail", _BidDetail));
                if (_BidAdvertisementDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidAdvertisementDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidAdvertisementDate", _BidAdvertisementDate));
                if (_BidAdvertisementReference == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidAdvertisementReference", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidAdvertisementReference", _BidAdvertisementReference));
                if (_ContactPerson == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactPerson", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactPerson", _ContactPerson));
                if (_ContactTel1 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactTel1", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactTel1", _ContactTel1));
                if (_ContactTel2 == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactTel2", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactTel2", _ContactTel2));
                if (_ContactFax == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactFax", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactFax", _ContactFax));
                if (_ContactEmail == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ContactEmail", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ContactEmail", _ContactEmail));
                if (_BidDocumentPurchaseAmount == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseAmount", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseAmount", _BidDocumentPurchaseAmount));
                if (_BidDocumentPurchaseDateFrom == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateFrom", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateFrom", _BidDocumentPurchaseDateFrom));
                if (_BidDocumentPurchaseTimeFrom == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeFrom", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeFrom", _BidDocumentPurchaseTimeFrom));
                if (_BidDocumentPurchaseDateTo == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateTo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateTo", _BidDocumentPurchaseDateTo));
                if (_BidDocumentPurchaseTimeTo == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeTo", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeTo", _BidDocumentPurchaseTimeTo));
                if (_BidDocumentReference == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidDocumentReference", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidDocumentReference", _BidDocumentReference));
                if (_BidSubmissionDeadlineDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineDate", _BidSubmissionDeadlineDate));
                if (_BidSubmissionDeadlineTime == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineTime", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineTime", _BidSubmissionDeadlineTime));
                if (_BidOpeningDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidOpeningDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidOpeningDate", _BidOpeningDate));
                if (_BidOpeningTime == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidOpeningTime", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidOpeningTime", _BidOpeningTime));
                if (_BidSecurityAmount == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidSecurityAmount", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidSecurityAmount", _BidSecurityAmount));
                if (_BidSecurityPercentage == decimal.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidSecurityPercentage", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidSecurityPercentage", _BidSecurityPercentage));
                if (_BidStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidStatus", _BidStatus));
                if (_SubmittedBy == string.Empty)
                    command.Parameters.Add(new SqlParameter("@SubmittedBy", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmittedBy", _SubmittedBy));
                if (_SubmittedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SubmittedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SubmittedDate", _SubmittedDate));
                if (_Remark == string.Empty)
                    command.Parameters.Add(new SqlParameter("@Remark", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Remark", _Remark));
                if (_BidBondIssuanceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidBondIssuanceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondIssuanceDate", _BidBondIssuanceDate));
                if (_BidBondBankGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidBondBankGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondBankGuid", _BidBondBankGuid));
                if (_BidBondBranch == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidBondBranch", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondBranch", _BidBondBranch));
                if (_BidBondNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BidBondNumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondNumber", _BidBondNumber));
                if (_BidBondReturnDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidBondReturnDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondReturnDate", _BidBondReturnDate));
                if (_BidBondStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@BidBondStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BidBondStatus", _BidBondStatus));
                if (_PerformanceBondIssuanceDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondIssuanceDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondIssuanceDate", _PerformanceBondIssuanceDate));
                if (_PerformanceBondBankGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondBankGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondBankGuid", _PerformanceBondBankGuid));
                if (_PerformanceBondBranch == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondBranch", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondBranch", _PerformanceBondBranch));
                if (_PerformanceBondNumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondNumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondNumber", _PerformanceBondNumber));
                if (_PerformanceBondReturnDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondReturnDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondReturnDate", _PerformanceBondReturnDate));
                if (_PerformanceBondStatus == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@PerformanceBondStatus", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PerformanceBondStatus", _PerformanceBondStatus));
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenders::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblTenders Where Id = @Id ";
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
                throw new Exception("CTenders::Delete::Error!" + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblTenders] WHERE " +
                                       " CustomerGuid = @CustomerGuid " +
                                       " AND BidType = @BidType " +
                                       " AND BidNumber = @BidNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenders] WHERE " +
                                       " CustomerGuid = @CustomerGuid " +
                                       " AND BidType = @BidType " +
                                       " AND BidNumber = @BidNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@BidType", _BidType));
                command.Parameters.Add(new SqlParameter("@BidNumber", _BidNumber));
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
                throw new Exception("CTenders::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Customerguid, int Bidtype, string Bidnumber, string Bidname, string Biddetail, DateTime Bidadvertisementdate, string Bidadvertisementreference, string Contactperson, string Contacttel1, string Contacttel2, string Contactfax, string Contactemail, decimal Biddocumentpurchaseamount, DateTime Biddocumentpurchasedatefrom, DateTime Biddocumentpurchasetimefrom, DateTime Biddocumentpurchasedateto, DateTime Biddocumentpurchasetimeto, string Biddocumentreference, DateTime Bidsubmissiondeadlinedate, DateTime Bidsubmissiondeadlinetime, DateTime Bidopeningdate, DateTime Bidopeningtime, decimal Bidsecurityamount, decimal Bidsecuritypercentage, int Bidstatus, string Submittedby, DateTime Submitteddate, string Remark, DateTime Bidbondissuancedate, string Bidbondbankguid, string Bidbondbranch, string Bidbondnumber, DateTime Bidbondreturndate, int Bidbondstatus, DateTime Performancebondissuancedate, string Performancebondbankguid, string Performancebondbranch, string Performancebondnumber, DateTime Performancebondreturndate, int Performancebondstatus)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblTenders" +
                                   " (CustomerGuid, " +
                                   " BidType, " +
                                   " BidNumber, " +
                                   " BidName, " +
                                   " BidDetail, " +
                                   " BidAdvertisementDate, " +
                                   " BidAdvertisementReference, " +
                                   " ContactPerson, " +
                                   " ContactTel1, " +
                                   " ContactTel2, " +
                                   " ContactFax, " +
                                   " ContactEmail, " +
                                   " BidDocumentPurchaseAmount, " +
                                   " BidDocumentPurchaseDateFrom, " +
                                   " BidDocumentPurchaseTimeFrom, " +
                                   " BidDocumentPurchaseDateTo, " +
                                   " BidDocumentPurchaseTimeTo, " +
                                   " BidDocumentReference, " +
                                   " BidSubmissionDeadlineDate, " +
                                   " BidSubmissionDeadlineTime, " +
                                   " BidOpeningDate, " +
                                   " BidOpeningTime, " +
                                   " BidSecurityAmount, " +
                                   " BidSecurityPercentage, " +
                                   " BidStatus, " +
                                   " SubmittedBy, " +
                                   " SubmittedDate, " +
                                   " Remark, " +
                                   " BidBondIssuanceDate, " +
                                   " BidBondBankGuid, " +
                                   " BidBondBranch, " +
                                   " BidBondNumber, " +
                                   " BidBondReturnDate, " +
                                   " BidBondStatus, " +
                                   " PerformanceBondIssuanceDate, " +
                                   " PerformanceBondBankGuid, " +
                                   " PerformanceBondBranch, " +
                                   " PerformanceBondNumber, " +
                                   " PerformanceBondReturnDate, " +
                                   " PerformanceBondStatus)" +
                                   " Values (@CustomerGuid, " +
                                   " @BidType, " +
                                   " @BidNumber, " +
                                   " @BidName, " +
                                   " @BidDetail, " +
                                   " @BidAdvertisementDate, " +
                                   " @BidAdvertisementReference, " +
                                   " @ContactPerson, " +
                                   " @ContactTel1, " +
                                   " @ContactTel2, " +
                                   " @ContactFax, " +
                                   " @ContactEmail, " +
                                   " @BidDocumentPurchaseAmount, " +
                                   " @BidDocumentPurchaseDateFrom, " +
                                   " @BidDocumentPurchaseTimeFrom, " +
                                   " @BidDocumentPurchaseDateTo, " +
                                   " @BidDocumentPurchaseTimeTo, " +
                                   " @BidDocumentReference, " +
                                   " @BidSubmissionDeadlineDate, " +
                                   " @BidSubmissionDeadlineTime, " +
                                   " @BidOpeningDate, " +
                                   " @BidOpeningTime, " +
                                   " @BidSecurityAmount, " +
                                   " @BidSecurityPercentage, " +
                                   " @BidStatus, " +
                                   " @SubmittedBy, " +
                                   " @SubmittedDate, " +
                                   " @Remark, " +
                                   " @BidBondIssuanceDate, " +
                                   " @BidBondBankGuid, " +
                                   " @BidBondBranch, " +
                                   " @BidBondNumber, " +
                                   " @BidBondReturnDate, " +
                                   " @BidBondStatus, " +
                                   " @PerformanceBondIssuanceDate, " +
                                   " @PerformanceBondBankGuid, " +
                                   " @PerformanceBondBranch, " +
                                   " @PerformanceBondNumber, " +
                                   " @PerformanceBondReturnDate, " +
                                   " @PerformanceBondStatus)" +
                                   " Select @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@BidType", Bidtype));
                command.Parameters.Add(new SqlParameter("@BidNumber", Bidnumber));
                command.Parameters.Add(new SqlParameter("@BidName", Bidname));
                command.Parameters.Add(new SqlParameter("@BidDetail", Biddetail));
                command.Parameters.Add(new SqlParameter("@BidAdvertisementDate", Bidadvertisementdate));
                command.Parameters.Add(new SqlParameter("@BidAdvertisementReference", Bidadvertisementreference));
                command.Parameters.Add(new SqlParameter("@ContactPerson", Contactperson));
                command.Parameters.Add(new SqlParameter("@ContactTel1", Contacttel1));
                command.Parameters.Add(new SqlParameter("@ContactTel2", Contacttel2));
                command.Parameters.Add(new SqlParameter("@ContactFax", Contactfax));
                command.Parameters.Add(new SqlParameter("@ContactEmail", Contactemail));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseAmount", Biddocumentpurchaseamount));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateFrom", Biddocumentpurchasedatefrom));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeFrom", Biddocumentpurchasetimefrom));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateTo", Biddocumentpurchasedateto));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeTo", Biddocumentpurchasetimeto));
                command.Parameters.Add(new SqlParameter("@BidDocumentReference", Biddocumentreference));
                command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineDate", Bidsubmissiondeadlinedate));
                command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineTime", Bidsubmissiondeadlinetime));
                command.Parameters.Add(new SqlParameter("@BidOpeningDate", Bidopeningdate));
                command.Parameters.Add(new SqlParameter("@BidOpeningTime", Bidopeningtime));
                command.Parameters.Add(new SqlParameter("@BidSecurityAmount", Bidsecurityamount));
                command.Parameters.Add(new SqlParameter("@BidSecurityPercentage", Bidsecuritypercentage));
                command.Parameters.Add(new SqlParameter("@BidStatus", Bidstatus));
                command.Parameters.Add(new SqlParameter("@SubmittedBy", Submittedby));
                command.Parameters.Add(new SqlParameter("@SubmittedDate", Submitteddate));
                command.Parameters.Add(new SqlParameter("@Remark", Remark));
                command.Parameters.Add(new SqlParameter("@BidBondIssuanceDate", Bidbondissuancedate));
                command.Parameters.Add(new SqlParameter("@BidBondBankGuid", Bidbondbankguid));
                command.Parameters.Add(new SqlParameter("@BidBondBranch", Bidbondbranch));
                command.Parameters.Add(new SqlParameter("@BidBondNumber", Bidbondnumber));
                command.Parameters.Add(new SqlParameter("@BidBondReturnDate", Bidbondreturndate));
                command.Parameters.Add(new SqlParameter("@BidBondStatus", Bidbondstatus));
                command.Parameters.Add(new SqlParameter("@PerformanceBondIssuanceDate", Performancebondissuancedate));
                command.Parameters.Add(new SqlParameter("@PerformanceBondBankGuid", Performancebondbankguid));
                command.Parameters.Add(new SqlParameter("@PerformanceBondBranch", Performancebondbranch));
                command.Parameters.Add(new SqlParameter("@PerformanceBondNumber", Performancebondnumber));
                command.Parameters.Add(new SqlParameter("@PerformanceBondReturnDate", Performancebondreturndate));
                command.Parameters.Add(new SqlParameter("@PerformanceBondStatus", Performancebondstatus));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenders::Insert::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Customerguid, int Bidtype, string Bidnumber, string Bidname, string Biddetail, DateTime Bidadvertisementdate, string Bidadvertisementreference, string Contactperson, string Contacttel1, string Contacttel2, string Contactfax, string Contactemail, decimal Biddocumentpurchaseamount, DateTime Biddocumentpurchasedatefrom, DateTime Biddocumentpurchasetimefrom, DateTime Biddocumentpurchasedateto, DateTime Biddocumentpurchasetimeto, string Biddocumentreference, DateTime Bidsubmissiondeadlinedate, DateTime Bidsubmissiondeadlinetime, DateTime Bidopeningdate, DateTime Bidopeningtime, decimal Bidsecurityamount, decimal Bidsecuritypercentage, int Bidstatus, string Submittedby, DateTime Submitteddate, string Remark, DateTime Bidbondissuancedate, string Bidbondbankguid, string Bidbondbranch, string Bidbondnumber, DateTime Bidbondreturndate, int Bidbondstatus, DateTime Performancebondissuancedate, string Performancebondbankguid, string Performancebondbranch, string Performancebondnumber, DateTime Performancebondreturndate, int Performancebondstatus)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblTenders" +
                                   " Set CustomerGuid = @CustomerGuid, " +
                                   " BidType = @BidType, " +
                                   " BidNumber = @BidNumber, " +
                                   " BidName = @BidName, " +
                                   " BidDetail = @BidDetail, " +
                                   " BidAdvertisementDate = @BidAdvertisementDate, " +
                                   " BidAdvertisementReference = @BidAdvertisementReference, " +
                                   " ContactPerson = @ContactPerson, " +
                                   " ContactTel1 = @ContactTel1, " +
                                   " ContactTel2 = @ContactTel2, " +
                                   " ContactFax = @ContactFax, " +
                                   " ContactEmail = @ContactEmail, " +
                                   " BidDocumentPurchaseAmount = @BidDocumentPurchaseAmount, " +
                                   " BidDocumentPurchaseDateFrom = @BidDocumentPurchaseDateFrom, " +
                                   " BidDocumentPurchaseTimeFrom = @BidDocumentPurchaseTimeFrom, " +
                                   " BidDocumentPurchaseDateTo = @BidDocumentPurchaseDateTo, " +
                                   " BidDocumentPurchaseTimeTo = @BidDocumentPurchaseTimeTo, " +
                                   " BidDocumentReference = @BidDocumentReference, " +
                                   " BidSubmissionDeadlineDate = @BidSubmissionDeadlineDate, " +
                                   " BidSubmissionDeadlineTime = @BidSubmissionDeadlineTime, " +
                                   " BidOpeningDate = @BidOpeningDate, " +
                                   " BidOpeningTime = @BidOpeningTime, " +
                                   " BidSecurityAmount = @BidSecurityAmount, " +
                                   " BidSecurityPercentage = @BidSecurityPercentage, " +
                                   " BidStatus = @BidStatus, " +
                                   " SubmittedBy = @SubmittedBy, " +
                                   " SubmittedDate = @SubmittedDate, " +
                                   " Remark = @Remark, " +
                                   " BidBondIssuanceDate = @BidBondIssuanceDate, " +
                                   " BidBondBankGuid = @BidBondBankGuid, " +
                                   " BidBondBranch = @BidBondBranch, " +
                                   " BidBondNumber = @BidBondNumber, " +
                                   " BidBondReturnDate = @BidBondReturnDate, " +
                                   " BidBondStatus = @BidBondStatus, " +
                                   " PerformanceBondIssuanceDate = @PerformanceBondIssuanceDate, " +
                                   " PerformanceBondBankGuid = @PerformanceBondBankGuid, " +
                                   " PerformanceBondBranch = @PerformanceBondBranch, " +
                                   " PerformanceBondNumber = @PerformanceBondNumber, " +
                                   " PerformanceBondReturnDate = @PerformanceBondReturnDate, " +
                                   " PerformanceBondStatus = @PerformanceBondStatus" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@BidType", Bidtype));
                command.Parameters.Add(new SqlParameter("@BidNumber", Bidnumber));
                command.Parameters.Add(new SqlParameter("@BidName", Bidname));
                command.Parameters.Add(new SqlParameter("@BidDetail", Biddetail));
                command.Parameters.Add(new SqlParameter("@BidAdvertisementDate", Bidadvertisementdate));
                command.Parameters.Add(new SqlParameter("@BidAdvertisementReference", Bidadvertisementreference));
                command.Parameters.Add(new SqlParameter("@ContactPerson", Contactperson));
                command.Parameters.Add(new SqlParameter("@ContactTel1", Contacttel1));
                command.Parameters.Add(new SqlParameter("@ContactTel2", Contacttel2));
                command.Parameters.Add(new SqlParameter("@ContactFax", Contactfax));
                command.Parameters.Add(new SqlParameter("@ContactEmail", Contactemail));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseAmount", Biddocumentpurchaseamount));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateFrom", Biddocumentpurchasedatefrom));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeFrom", Biddocumentpurchasetimefrom));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseDateTo", Biddocumentpurchasedateto));
                command.Parameters.Add(new SqlParameter("@BidDocumentPurchaseTimeTo", Biddocumentpurchasetimeto));
                command.Parameters.Add(new SqlParameter("@BidDocumentReference", Biddocumentreference));
                command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineDate", Bidsubmissiondeadlinedate));
                command.Parameters.Add(new SqlParameter("@BidSubmissionDeadlineTime", Bidsubmissiondeadlinetime));
                command.Parameters.Add(new SqlParameter("@BidOpeningDate", Bidopeningdate));
                command.Parameters.Add(new SqlParameter("@BidOpeningTime", Bidopeningtime));
                command.Parameters.Add(new SqlParameter("@BidSecurityAmount", Bidsecurityamount));
                command.Parameters.Add(new SqlParameter("@BidSecurityPercentage", Bidsecuritypercentage));
                command.Parameters.Add(new SqlParameter("@BidStatus", Bidstatus));
                command.Parameters.Add(new SqlParameter("@SubmittedBy", Submittedby));
                command.Parameters.Add(new SqlParameter("@SubmittedDate", Submitteddate));
                command.Parameters.Add(new SqlParameter("@Remark", Remark));
                command.Parameters.Add(new SqlParameter("@BidBondIssuanceDate", Bidbondissuancedate));
                command.Parameters.Add(new SqlParameter("@BidBondBankGuid", Bidbondbankguid));
                command.Parameters.Add(new SqlParameter("@BidBondBranch", Bidbondbranch));
                command.Parameters.Add(new SqlParameter("@BidBondNumber", Bidbondnumber));
                command.Parameters.Add(new SqlParameter("@BidBondReturnDate", Bidbondreturndate));
                command.Parameters.Add(new SqlParameter("@BidBondStatus", Bidbondstatus));
                command.Parameters.Add(new SqlParameter("@PerformanceBondIssuanceDate", Performancebondissuancedate));
                command.Parameters.Add(new SqlParameter("@PerformanceBondBankGuid", Performancebondbankguid));
                command.Parameters.Add(new SqlParameter("@PerformanceBondBranch", Performancebondbranch));
                command.Parameters.Add(new SqlParameter("@PerformanceBondNumber", Performancebondnumber));
                command.Parameters.Add(new SqlParameter("@PerformanceBondReturnDate", Performancebondreturndate));
                command.Parameters.Add(new SqlParameter("@PerformanceBondStatus", Performancebondstatus));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenders::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblTenders Where Id = @Id ";
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
                throw new Exception("CTenders::Delete::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, string Customerguid, int Bidtype, string Bidnumber)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblTenders] WHERE " +
                                       " CustomerGuid = @CustomerGuid " +
                                       " AND BidType = @BidType " +
                                       " AND BidNumber = @BidNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblTenders] WHERE " +
                                       " CustomerGuid = @CustomerGuid " +
                                       " AND BidType = @BidType " +
                                       " AND BidNumber = @BidNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", _CustomerGuid));
                command.Parameters.Add(new SqlParameter("@BidType", Bidtype));
                command.Parameters.Add(new SqlParameter("@BidNumber", Bidnumber));
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
                throw new Exception("CTenders::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CTenders> GetList()
        {
            List<CTenders> RecordsList = new List<CTenders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select tblTenders.*, tblCustomers.Name As CustomerName ";
            command.CommandText += " from tblTenders Inner Join tblCustomers ";
            command.CommandText += " ON tblTenders.CustomerGuid = tblCustomers.TableRowGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenders objCTenders = new CTenders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenders.Id = 0;
                    else
                        objCTenders.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCTenders.Customerguid = string.Empty;
                    else
                        objCTenders.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["BidType"].Equals(DBNull.Value))
                        objCTenders.Bidtype = 0;
                    else
                        objCTenders.Bidtype = (int)dr["BidType"];
                    if (dr["BidNumber"].Equals(DBNull.Value))
                        objCTenders.Bidnumber = string.Empty;
                    else
                        objCTenders.Bidnumber = (string)dr["BidNumber"];
                    if (dr["BidName"].Equals(DBNull.Value))
                        objCTenders.Bidname = string.Empty;
                    else
                        objCTenders.Bidname = (string)dr["BidName"];
                    if (dr["BidDetail"].Equals(DBNull.Value))
                        objCTenders.Biddetail = string.Empty;
                    else
                        objCTenders.Biddetail = (string)dr["BidDetail"];
                    if (dr["BidAdvertisementDate"].Equals(DBNull.Value))
                        objCTenders.Bidadvertisementdate = DateTime.MinValue;
                    else
                        objCTenders.Bidadvertisementdate = (DateTime)dr["BidAdvertisementDate"];
                    if (dr["BidAdvertisementReference"].Equals(DBNull.Value))
                        objCTenders.Bidadvertisementreference = string.Empty;
                    else
                        objCTenders.Bidadvertisementreference = (string)dr["BidAdvertisementReference"];
                    if (dr["ContactPerson"].Equals(DBNull.Value))
                        objCTenders.Contactperson = string.Empty;
                    else
                        objCTenders.Contactperson = (string)dr["ContactPerson"];
                    if (dr["ContactTel1"].Equals(DBNull.Value))
                        objCTenders.Contacttel1 = string.Empty;
                    else
                        objCTenders.Contacttel1 = (string)dr["ContactTel1"];
                    if (dr["ContactTel2"].Equals(DBNull.Value))
                        objCTenders.Contacttel2 = string.Empty;
                    else
                        objCTenders.Contacttel2 = (string)dr["ContactTel2"];
                    if (dr["ContactFax"].Equals(DBNull.Value))
                        objCTenders.Contactfax = string.Empty;
                    else
                        objCTenders.Contactfax = (string)dr["ContactFax"];
                    if (dr["ContactEmail"].Equals(DBNull.Value))
                        objCTenders.Contactemail = string.Empty;
                    else
                        objCTenders.Contactemail = (string)dr["ContactEmail"];
                    if (dr["BidDocumentPurchaseAmount"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchaseamount = 0;
                    else
                        objCTenders.Biddocumentpurchaseamount = (decimal)dr["BidDocumentPurchaseAmount"];
                    if (dr["BidDocumentPurchaseDateFrom"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchasedatefrom = DateTime.MinValue;
                    else
                        objCTenders.Biddocumentpurchasedatefrom = (DateTime)dr["BidDocumentPurchaseDateFrom"];
                    if (dr["BidDocumentPurchaseTimeFrom"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchasetimefrom = DateTime.MinValue;
                    else
                        objCTenders.Biddocumentpurchasetimefrom = (DateTime)dr["BidDocumentPurchaseTimeFrom"];
                    if (dr["BidDocumentPurchaseDateTo"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchasedateto = DateTime.MinValue;
                    else
                        objCTenders.Biddocumentpurchasedateto = (DateTime)dr["BidDocumentPurchaseDateTo"];
                    if (dr["BidDocumentPurchaseTimeTo"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchasetimeto = DateTime.MinValue;
                    else
                        objCTenders.Biddocumentpurchasetimeto = (DateTime)dr["BidDocumentPurchaseTimeTo"];
                    if (dr["BidDocumentReference"].Equals(DBNull.Value))
                        objCTenders.Biddocumentreference = string.Empty;
                    else
                        objCTenders.Biddocumentreference = (string)dr["BidDocumentReference"];
                    if (dr["BidSubmissionDeadlineDate"].Equals(DBNull.Value))
                        objCTenders.Bidsubmissiondeadlinedate = DateTime.MinValue;
                    else
                        objCTenders.Bidsubmissiondeadlinedate = (DateTime)dr["BidSubmissionDeadlineDate"];
                    if (dr["BidSubmissionDeadlineTime"].Equals(DBNull.Value))
                        objCTenders.Bidsubmissiondeadlinetime = DateTime.MinValue;
                    else
                        objCTenders.Bidsubmissiondeadlinetime = (DateTime)dr["BidSubmissionDeadlineTime"];
                    if (dr["BidOpeningDate"].Equals(DBNull.Value))
                        objCTenders.Bidopeningdate = DateTime.MinValue;
                    else
                        objCTenders.Bidopeningdate = (DateTime)dr["BidOpeningDate"];
                    if (dr["BidOpeningTime"].Equals(DBNull.Value))
                        objCTenders.Bidopeningtime = DateTime.MinValue;
                    else
                        objCTenders.Bidopeningtime = (DateTime)dr["BidOpeningTime"];
                    if (dr["BidSecurityAmount"].Equals(DBNull.Value))
                        objCTenders.Bidsecurityamount = 0;
                    else
                        objCTenders.Bidsecurityamount = (decimal)dr["BidSecurityAmount"];
                    if (dr["BidSecurityPercentage"].Equals(DBNull.Value))
                        objCTenders.Bidsecuritypercentage = 0;
                    else
                        objCTenders.Bidsecuritypercentage = (decimal)dr["BidSecurityPercentage"];
                    if (dr["BidStatus"].Equals(DBNull.Value))
                        objCTenders.Bidstatus = 0;
                    else
                        objCTenders.Bidstatus = (int)dr["BidStatus"];
                    if (dr["SubmittedBy"].Equals(DBNull.Value))
                        objCTenders.Submittedby = string.Empty;
                    else
                        objCTenders.Submittedby = (string)dr["SubmittedBy"];
                    if (dr["SubmittedDate"].Equals(DBNull.Value))
                        objCTenders.Submitteddate = DateTime.MinValue;
                    else
                        objCTenders.Submitteddate = (DateTime)dr["SubmittedDate"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCTenders.Remark = string.Empty;
                    else
                        objCTenders.Remark = (string)dr["Remark"];
                    if (dr["BidBondIssuanceDate"].Equals(DBNull.Value))
                        objCTenders.Bidbondissuancedate = DateTime.MinValue;
                    else
                        objCTenders.Bidbondissuancedate = (DateTime)dr["BidBondIssuanceDate"];
                    if (dr["BidBondBankGuid"].Equals(DBNull.Value))
                        objCTenders.Bidbondbankguid = string.Empty;
                    else
                        objCTenders.Bidbondbankguid = (string)dr["BidBondBankGuid"];
                    if (dr["BidBondBranch"].Equals(DBNull.Value))
                        objCTenders.Bidbondbranch = string.Empty;
                    else
                        objCTenders.Bidbondbranch = (string)dr["BidBondBranch"];
                    if (dr["BidBondNumber"].Equals(DBNull.Value))
                        objCTenders.Bidbondnumber = string.Empty;
                    else
                        objCTenders.Bidbondnumber = (string)dr["BidBondNumber"];
                    if (dr["BidBondReturnDate"].Equals(DBNull.Value))
                        objCTenders.Bidbondreturndate = DateTime.MinValue;
                    else
                        objCTenders.Bidbondreturndate = (DateTime)dr["BidBondReturnDate"];
                    if (dr["BidBondStatus"].Equals(DBNull.Value))
                        objCTenders.Bidbondstatus = 0;
                    else
                        objCTenders.Bidbondstatus = (int)dr["BidBondStatus"];
                    if (dr["PerformanceBondIssuanceDate"].Equals(DBNull.Value))
                        objCTenders.Performancebondissuancedate = DateTime.MinValue;
                    else
                        objCTenders.Performancebondissuancedate = (DateTime)dr["PerformanceBondIssuanceDate"];
                    if (dr["PerformanceBondBankGuid"].Equals(DBNull.Value))
                        objCTenders.Performancebondbankguid = string.Empty;
                    else
                        objCTenders.Performancebondbankguid = (string)dr["PerformanceBondBankGuid"];
                    if (dr["PerformanceBondBranch"].Equals(DBNull.Value))
                        objCTenders.Performancebondbranch = string.Empty;
                    else
                        objCTenders.Performancebondbranch = (string)dr["PerformanceBondBranch"];
                    if (dr["PerformanceBondNumber"].Equals(DBNull.Value))
                        objCTenders.Performancebondnumber = string.Empty;
                    else
                        objCTenders.Performancebondnumber = (string)dr["PerformanceBondNumber"];
                    if (dr["PerformanceBondReturnDate"].Equals(DBNull.Value))
                        objCTenders.Performancebondreturndate = DateTime.MinValue;
                    else
                        objCTenders.Performancebondreturndate = (DateTime)dr["PerformanceBondReturnDate"];
                    if (dr["PerformanceBondStatus"].Equals(DBNull.Value))
                        objCTenders.Performancebondstatus = 0;
                    else
                        objCTenders.Performancebondstatus = (int)dr["PerformanceBondStatus"];
                    if (dr["CustomerName"].Equals(DBNull.Value))
                        objCTenders.Customername = string.Empty;
                    else
                        objCTenders.Customername = (string)dr["CustomerName"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenders.Tablerowguid = string.Empty;
                    else
                        objCTenders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenders);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenders::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CTenders> GetList(string Customerguid)
        {
            List<CTenders> RecordsList = new List<CTenders>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select tblTenders.*, tblCustomers.Name As CustomerName ";
            command.CommandText += " from tblTenders Inner Join tblCustomers ";
            command.CommandText += " ON tblTenders.CustomerGuid = tblCustomers.TableRowGuid ";
            command.CommandText += " where CustomerGuid=@CustomerGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@CustomerGuid", Customerguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CTenders objCTenders = new CTenders();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCTenders.Id = 0;
                    else
                        objCTenders.Id = (int)dr["Id"];
                    if (dr["CustomerGuid"].Equals(DBNull.Value))
                        objCTenders.Customerguid = string.Empty;
                    else
                        objCTenders.Customerguid = (string)dr["CustomerGuid"];
                    if (dr["BidType"].Equals(DBNull.Value))
                        objCTenders.Bidtype = 0;
                    else
                        objCTenders.Bidtype = (int)dr["BidType"];
                    if (dr["BidNumber"].Equals(DBNull.Value))
                        objCTenders.Bidnumber = string.Empty;
                    else
                        objCTenders.Bidnumber = (string)dr["BidNumber"];
                    if (dr["BidName"].Equals(DBNull.Value))
                        objCTenders.Bidname = string.Empty;
                    else
                        objCTenders.Bidname = (string)dr["BidName"];
                    if (dr["BidDetail"].Equals(DBNull.Value))
                        objCTenders.Biddetail = string.Empty;
                    else
                        objCTenders.Biddetail = (string)dr["BidDetail"];
                    if (dr["BidAdvertisementDate"].Equals(DBNull.Value))
                        objCTenders.Bidadvertisementdate = DateTime.MinValue;
                    else
                        objCTenders.Bidadvertisementdate = (DateTime)dr["BidAdvertisementDate"];
                    if (dr["BidAdvertisementReference"].Equals(DBNull.Value))
                        objCTenders.Bidadvertisementreference = string.Empty;
                    else
                        objCTenders.Bidadvertisementreference = (string)dr["BidAdvertisementReference"];
                    if (dr["ContactPerson"].Equals(DBNull.Value))
                        objCTenders.Contactperson = string.Empty;
                    else
                        objCTenders.Contactperson = (string)dr["ContactPerson"];
                    if (dr["ContactTel1"].Equals(DBNull.Value))
                        objCTenders.Contacttel1 = string.Empty;
                    else
                        objCTenders.Contacttel1 = (string)dr["ContactTel1"];
                    if (dr["ContactTel2"].Equals(DBNull.Value))
                        objCTenders.Contacttel2 = string.Empty;
                    else
                        objCTenders.Contacttel2 = (string)dr["ContactTel2"];
                    if (dr["ContactFax"].Equals(DBNull.Value))
                        objCTenders.Contactfax = string.Empty;
                    else
                        objCTenders.Contactfax = (string)dr["ContactFax"];
                    if (dr["ContactEmail"].Equals(DBNull.Value))
                        objCTenders.Contactemail = string.Empty;
                    else
                        objCTenders.Contactemail = (string)dr["ContactEmail"];
                    if (dr["BidDocumentPurchaseAmount"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchaseamount = 0;
                    else
                        objCTenders.Biddocumentpurchaseamount = (decimal)dr["BidDocumentPurchaseAmount"];
                    if (dr["BidDocumentPurchaseDateFrom"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchasedatefrom = DateTime.MinValue;
                    else
                        objCTenders.Biddocumentpurchasedatefrom = (DateTime)dr["BidDocumentPurchaseDateFrom"];
                    if (dr["BidDocumentPurchaseTimeFrom"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchasetimefrom = DateTime.MinValue;
                    else
                        objCTenders.Biddocumentpurchasetimefrom = (DateTime)dr["BidDocumentPurchaseTimeFrom"];
                    if (dr["BidDocumentPurchaseDateTo"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchasedateto = DateTime.MinValue;
                    else
                        objCTenders.Biddocumentpurchasedateto = (DateTime)dr["BidDocumentPurchaseDateTo"];
                    if (dr["BidDocumentPurchaseTimeTo"].Equals(DBNull.Value))
                        objCTenders.Biddocumentpurchasetimeto = DateTime.MinValue;
                    else
                        objCTenders.Biddocumentpurchasetimeto = (DateTime)dr["BidDocumentPurchaseTimeTo"];
                    if (dr["BidDocumentReference"].Equals(DBNull.Value))
                        objCTenders.Biddocumentreference = string.Empty;
                    else
                        objCTenders.Biddocumentreference = (string)dr["BidDocumentReference"];
                    if (dr["BidSubmissionDeadlineDate"].Equals(DBNull.Value))
                        objCTenders.Bidsubmissiondeadlinedate = DateTime.MinValue;
                    else
                        objCTenders.Bidsubmissiondeadlinedate = (DateTime)dr["BidSubmissionDeadlineDate"];
                    if (dr["BidSubmissionDeadlineTime"].Equals(DBNull.Value))
                        objCTenders.Bidsubmissiondeadlinetime = DateTime.MinValue;
                    else
                        objCTenders.Bidsubmissiondeadlinetime = (DateTime)dr["BidSubmissionDeadlineTime"];
                    if (dr["BidOpeningDate"].Equals(DBNull.Value))
                        objCTenders.Bidopeningdate = DateTime.MinValue;
                    else
                        objCTenders.Bidopeningdate = (DateTime)dr["BidOpeningDate"];
                    if (dr["BidOpeningTime"].Equals(DBNull.Value))
                        objCTenders.Bidopeningtime = DateTime.MinValue;
                    else
                        objCTenders.Bidopeningtime = (DateTime)dr["BidOpeningTime"];
                    if (dr["BidSecurityAmount"].Equals(DBNull.Value))
                        objCTenders.Bidsecurityamount = 0;
                    else
                        objCTenders.Bidsecurityamount = (decimal)dr["BidSecurityAmount"];
                    if (dr["BidSecurityPercentage"].Equals(DBNull.Value))
                        objCTenders.Bidsecuritypercentage = 0;
                    else
                        objCTenders.Bidsecuritypercentage = (decimal)dr["BidSecurityPercentage"];
                    if (dr["BidStatus"].Equals(DBNull.Value))
                        objCTenders.Bidstatus = 0;
                    else
                        objCTenders.Bidstatus = (int)dr["BidStatus"];
                    if (dr["SubmittedBy"].Equals(DBNull.Value))
                        objCTenders.Submittedby = string.Empty;
                    else
                        objCTenders.Submittedby = (string)dr["SubmittedBy"];
                    if (dr["SubmittedDate"].Equals(DBNull.Value))
                        objCTenders.Submitteddate = DateTime.MinValue;
                    else
                        objCTenders.Submitteddate = (DateTime)dr["SubmittedDate"];
                    if (dr["Remark"].Equals(DBNull.Value))
                        objCTenders.Remark = string.Empty;
                    else
                        objCTenders.Remark = (string)dr["Remark"];
                    if (dr["BidBondIssuanceDate"].Equals(DBNull.Value))
                        objCTenders.Bidbondissuancedate = DateTime.MinValue;
                    else
                        objCTenders.Bidbondissuancedate = (DateTime)dr["BidBondIssuanceDate"];
                    if (dr["BidBondBankGuid"].Equals(DBNull.Value))
                        objCTenders.Bidbondbankguid = string.Empty;
                    else
                        objCTenders.Bidbondbankguid = (string)dr["BidBondBankGuid"];
                    if (dr["BidBondBranch"].Equals(DBNull.Value))
                        objCTenders.Bidbondbranch = string.Empty;
                    else
                        objCTenders.Bidbondbranch = (string)dr["BidBondBranch"];
                    if (dr["BidBondNumber"].Equals(DBNull.Value))
                        objCTenders.Bidbondnumber = string.Empty;
                    else
                        objCTenders.Bidbondnumber = (string)dr["BidBondNumber"];
                    if (dr["BidBondReturnDate"].Equals(DBNull.Value))
                        objCTenders.Bidbondreturndate = DateTime.MinValue;
                    else
                        objCTenders.Bidbondreturndate = (DateTime)dr["BidBondReturnDate"];
                    if (dr["BidBondStatus"].Equals(DBNull.Value))
                        objCTenders.Bidbondstatus = 0;
                    else
                        objCTenders.Bidbondstatus = (int)dr["BidBondStatus"];
                    if (dr["PerformanceBondIssuanceDate"].Equals(DBNull.Value))
                        objCTenders.Performancebondissuancedate = DateTime.MinValue;
                    else
                        objCTenders.Performancebondissuancedate = (DateTime)dr["PerformanceBondIssuanceDate"];
                    if (dr["PerformanceBondBankGuid"].Equals(DBNull.Value))
                        objCTenders.Performancebondbankguid = string.Empty;
                    else
                        objCTenders.Performancebondbankguid = (string)dr["PerformanceBondBankGuid"];
                    if (dr["PerformanceBondBranch"].Equals(DBNull.Value))
                        objCTenders.Performancebondbranch = string.Empty;
                    else
                        objCTenders.Performancebondbranch = (string)dr["PerformanceBondBranch"];
                    if (dr["PerformanceBondNumber"].Equals(DBNull.Value))
                        objCTenders.Performancebondnumber = string.Empty;
                    else
                        objCTenders.Performancebondnumber = (string)dr["PerformanceBondNumber"];
                    if (dr["PerformanceBondReturnDate"].Equals(DBNull.Value))
                        objCTenders.Performancebondreturndate = DateTime.MinValue;
                    else
                        objCTenders.Performancebondreturndate = (DateTime)dr["PerformanceBondReturnDate"];
                    if (dr["PerformanceBondStatus"].Equals(DBNull.Value))
                        objCTenders.Performancebondstatus = 0;
                    else
                        objCTenders.Performancebondstatus = (int)dr["PerformanceBondStatus"];
                    if (dr["CustomerName"].Equals(DBNull.Value))
                        objCTenders.Customername = string.Empty;
                    else
                        objCTenders.Customername = (string)dr["CustomerName"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCTenders.Tablerowguid = string.Empty;
                    else
                        objCTenders.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCTenders);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CTenders::GetList::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblTenders] WHERE Id = @Id";
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
                throw new Exception("CTenders::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblTenders] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CTenders::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
