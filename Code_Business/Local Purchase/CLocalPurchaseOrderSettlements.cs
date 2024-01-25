//
// ...
// Wizard generated code
// Date: 4/26/2014 4:57:25 PM
// Class: CLocalPurchaseOrderSettlements
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
    public class CLocalPurchaseOrderSettlements
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CLocalPurchaseOrderSettlements()
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

        string _PurchaseOrderGuid;
        public string Purchaseorderguid
        {
            get { return _PurchaseOrderGuid; }
            set { _PurchaseOrderGuid = value; }
        }

        string _BankGuid;
        public string Bankguid
        {
            get { return _BankGuid; }
            set { _BankGuid = value; }
        }

        string _BankBranchName;
        public string Bankbranchname
        {
            get { return _BankBranchName; }
            set { _BankBranchName = value; }
        }

        int _ModeOfPayment;
        public int Modeofpayment
        {
            get { return _ModeOfPayment; }
            set { _ModeOfPayment = value; }
        }

        string _CheckOrCPONumber;
        public string Checkorcponumber
        {
            get { return _CheckOrCPONumber; }
            set { _CheckOrCPONumber = value; }
        }

        DateTime _CheckOrCPODate;
        public DateTime Checkorcpodate
        {
            get { return _CheckOrCPODate; }
            set { _CheckOrCPODate = value; }
        }

        DateTime _CheckMaturityDate;
        public DateTime Checkmaturitydate
        {
            get { return _CheckMaturityDate; }
            set { _CheckMaturityDate = value; }
        }

        int _Settled;
        public int Settled
        {
            get { return _Settled; }
            set { _Settled = value; }
        }

        DateTime _SettlementDate;
        public DateTime Settlementdate
        {
            get { return _SettlementDate; }
            set { _SettlementDate = value; }
        }

        string _UserId;
        public string Userid
        {
            get { return _UserId; }
            set { _UserId = value; }
        }

        string _ComputerName;
        public string Computername
        {
            get { return _ComputerName; }
            set { _ComputerName = value; }
        }

        int _EventSource;
        public int Eventsource
        {
            get { return _EventSource; }
            set { _EventSource = value; }
        }

        string _OrderNumber;
        public string Ordernumber
        {
            get { return _OrderNumber; }
            set { _OrderNumber = value; }
        }

        DateTime _OrderDate;
        public DateTime Orderdate
        {
            get { return _OrderDate; }
            set { _OrderDate = value; }
        }

        string _SupplierName;
        public string Suppliername
        {
            get { return _SupplierName; }
            set { _SupplierName = value; }
        }


        #endregion

        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLocalPurchaseOrderSettlements where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocalPurchaseOrderSettlements");
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
                    if (dTable.Rows[0]["PurchaseOrderGuid"].Equals(DBNull.Value))
                        _PurchaseOrderGuid = string.Empty;
                    else
                        _PurchaseOrderGuid = (string)dTable.Rows[0]["PurchaseOrderGuid"];
                    if (dTable.Rows[0]["BankGuid"].Equals(DBNull.Value))
                        _BankGuid = string.Empty;
                    else
                        _BankGuid = (string)dTable.Rows[0]["BankGuid"];
                    if (dTable.Rows[0]["BankBranchName"].Equals(DBNull.Value))
                        _BankBranchName = string.Empty;
                    else
                        _BankBranchName = (string)dTable.Rows[0]["BankBranchName"];
                    if (dTable.Rows[0]["ModeOfPayment"].Equals(DBNull.Value))
                        _ModeOfPayment = 0;
                    else
                        _ModeOfPayment = (int)dTable.Rows[0]["ModeOfPayment"];
                    if (dTable.Rows[0]["CheckOrCPONumber"].Equals(DBNull.Value))
                        _CheckOrCPONumber = string.Empty;
                    else
                        _CheckOrCPONumber = (string)dTable.Rows[0]["CheckOrCPONumber"];
                    if (dTable.Rows[0]["CheckOrCPODate"].Equals(DBNull.Value))
                        _CheckOrCPODate = DateTime.MinValue;
                    else
                        _CheckOrCPODate = (DateTime)dTable.Rows[0]["CheckOrCPODate"];
                    if (dTable.Rows[0]["CheckMaturityDate"].Equals(DBNull.Value))
                        _CheckMaturityDate = DateTime.MinValue;
                    else
                        _CheckMaturityDate = (DateTime)dTable.Rows[0]["CheckMaturityDate"];
                    if (dTable.Rows[0]["Settled"].Equals(DBNull.Value))
                        _Settled = 0;
                    else
                        _Settled = (int)dTable.Rows[0]["Settled"];
                    if (dTable.Rows[0]["SettlementDate"].Equals(DBNull.Value))
                        _SettlementDate = DateTime.MinValue;
                    else
                        _SettlementDate = (DateTime)dTable.Rows[0]["SettlementDate"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderSettlements::GetRecord::Error!" + ex.Message, ex);
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
            command.CommandText = "Select * from tblLocalPurchaseOrderSettlements";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocalPurchaseOrderSettlements");
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
                throw new Exception("CLocalPurchaseOrderSettlements::GetRecords::Error!" + ex.Message, ex);
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
            command.CommandText = "Insert Into tblLocalPurchaseOrderSettlements" +
                                   " (PurchaseOrderGuid, " +
                                   " BankGuid, " +
                                   " BankBranchName, " +
                                   " ModeOfPayment, " +
                                   " CheckOrCPONumber, " +
                                   " CheckOrCPODate, " +
                                   " CheckMaturityDate, " +
                                   " Settled, " +
                                   " SettlementDate, " +
                                   " UserId, " +
                                   " ComputerName, " +
                                   " EventSource)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @BankGuid, " +
                                   " @BankBranchName, " +
                                   " @ModeOfPayment, " +
                                   " @CheckOrCPONumber, " +
                                   " @CheckOrCPODate, " +
                                   " @CheckMaturityDate, " +
                                   " @Settled, " +
                                   " @SettlementDate, " +
                                   " @UserId, " +
                                   " @ComputerName, " +
                                   " @EventSource)" +
                                   " SELECT @Id = MAX(Id) FROM tblLocalPurchaseOrderSettlements";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_PurchaseOrderGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                if (_BankGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BankGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BankGuid", _BankGuid));
                if (_BankBranchName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BankBranchName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BankBranchName", _BankBranchName));
                if (_ModeOfPayment == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@ModeOfPayment", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ModeOfPayment", _ModeOfPayment));
                if (_CheckOrCPONumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CheckOrCPONumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckOrCPONumber", _CheckOrCPONumber));
                if (_CheckOrCPODate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckOrCPODate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckOrCPODate", _CheckOrCPODate));
                if (_CheckMaturityDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckMaturityDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckMaturityDate", _CheckMaturityDate));
                if (_Settled == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@Settled", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Settled", _Settled));
                if (_SettlementDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SettlementDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SettlementDate", _SettlementDate));
                if (_UserId == string.Empty)
                    command.Parameters.Add(new SqlParameter("@UserId", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@UserId", _UserId));
                if (_ComputerName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ComputerName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ComputerName", _ComputerName));
                if (_EventSource == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@EventSource", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EventSource", _EventSource));

                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderSettlements::Insert::Error!" + ex.Message, ex);
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
            command.CommandText = "Update tblLocalPurchaseOrderSettlements" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " BankGuid = @BankGuid, " +
                                   " BankBranchName = @BankBranchName, " +
                                   " ModeOfPayment = @ModeOfPayment, " +
                                   " CheckOrCPONumber = @CheckOrCPONumber, " +
                                   " CheckOrCPODate = @CheckOrCPODate, " +
                                   " CheckMaturityDate = @CheckMaturityDate, " +
                                   " Settled = @Settled, " +
                                   " SettlementDate = @SettlementDate, " +
                                   " UserId = @UserId, " +
                                   " ComputerName = @ComputerName, " +
                                   " EventSource = @EventSource" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                if (_PurchaseOrderGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                if (_BankGuid == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BankGuid", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BankGuid", _BankGuid));
                if (_BankBranchName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@BankBranchName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@BankBranchName", _BankBranchName));
                if (_ModeOfPayment == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@ModeOfPayment", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ModeOfPayment", _ModeOfPayment));
                if (_CheckOrCPONumber == string.Empty)
                    command.Parameters.Add(new SqlParameter("@CheckOrCPONumber", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckOrCPONumber", _CheckOrCPONumber));
                if (_CheckOrCPODate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckOrCPODate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckOrCPODate", _CheckOrCPODate));
                if (_CheckMaturityDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@CheckMaturityDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@CheckMaturityDate", _CheckMaturityDate));
                if (_Settled == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@Settled", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@Settled", _Settled));
                if (_SettlementDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@SettlementDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@SettlementDate", _SettlementDate));
                if (_UserId == string.Empty)
                    command.Parameters.Add(new SqlParameter("@UserId", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@UserId", _UserId));
                if (_ComputerName == string.Empty)
                    command.Parameters.Add(new SqlParameter("@ComputerName", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ComputerName", _ComputerName));
                if (_EventSource == int.MinValue)
                    command.Parameters.Add(new SqlParameter("@EventSource", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@EventSource", _EventSource));
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderSettlements::Update::Error!" + ex.Message, ex);
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
            command.CommandText = "Delete From tblLocalPurchaseOrderSettlements Where Id = @Id ";
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
                throw new Exception("CLocalPurchaseOrderSettlements::Delete::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrderSettlements] " +
                                       " WHERE (1 = 1) " +
                                       " AND PurchaseOrderGuid = @PurchaseOrderGuid ";
            if (!bNew)
                command.CommandText += " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
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
                throw new Exception("CLocalPurchaseOrderSettlements::Exists::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CLocalPurchaseOrderSettlements> GetList()
        {
            List<CLocalPurchaseOrderSettlements> RecordsList = new List<CLocalPurchaseOrderSettlements>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLocalPurchaseOrderSettlements";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocalPurchaseOrderSettlements objCLocalPurchaseOrderSettlements = new CLocalPurchaseOrderSettlements();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Id = int.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Purchaseorderguid = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["BankGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Bankguid = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Bankguid = (string)dr["BankGuid"];
                    if (dr["BankBranchName"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Bankbranchname = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Bankbranchname = (string)dr["BankBranchName"];
                    if (dr["ModeOfPayment"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Modeofpayment = int.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Modeofpayment = (int)dr["ModeOfPayment"];
                    if (dr["CheckOrCPONumber"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Checkorcponumber = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Checkorcponumber = (string)dr["CheckOrCPONumber"];
                    if (dr["CheckOrCPODate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Checkorcpodate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Checkorcpodate = (DateTime)dr["CheckOrCPODate"];
                    if (dr["CheckMaturityDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Checkmaturitydate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Checkmaturitydate = (DateTime)dr["CheckMaturityDate"];
                    if (dr["Settled"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Settled = int.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Settled = (int)dr["Settled"];
                    if (dr["SettlementDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Settlementdate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Settlementdate = (DateTime)dr["SettlementDate"];

                    RecordsList.Add(objCLocalPurchaseOrderSettlements);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderSettlements::GetList::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CLocalPurchaseOrderSettlements> GetList(string strCriteria)
        {
            List<CLocalPurchaseOrderSettlements> RecordsList = new List<CLocalPurchaseOrderSettlements>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select tblLocalPurchaseOrderSettlements.*,tblLocalPurchaseOrders.OrderDate,tblLocalPurchaseOrders.OrderNumber, tblManufacturers.Name As SupplierName from tblLocalPurchaseOrderSettlements";
            command.CommandText += " Inner Join tblLocalPurchaseOrders ON (tblLocalPurchaseOrderSettlements.PurchaseOrderGuid = tblLocalPurchaseOrders.TableRowGuid ) ";
            command.CommandText += " Inner Join tblManufacturers ON (tblLocalPurchaseOrders.SupplierGuid = tblManufacturers.TableRowGuid)  ";
            command.CommandText += " WHERE 1 = 1 " + strCriteria;
            command.CommandText += " ORDER BY tblLocalPurchaseOrders.OrderDate,tblLocalPurchaseOrders.OrderNumber";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocalPurchaseOrderSettlements objCLocalPurchaseOrderSettlements = new CLocalPurchaseOrderSettlements();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Id = int.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Purchaseorderguid = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["BankGuid"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Bankguid = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Bankguid = (string)dr["BankGuid"];
                    if (dr["BankBranchName"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Bankbranchname = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Bankbranchname = (string)dr["BankBranchName"];
                    if (dr["ModeOfPayment"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Modeofpayment = int.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Modeofpayment = (int)dr["ModeOfPayment"];
                    if (dr["CheckOrCPONumber"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Checkorcponumber = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Checkorcponumber = (string)dr["CheckOrCPONumber"];
                    if (dr["CheckOrCPODate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Checkorcpodate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Checkorcpodate = (DateTime)dr["CheckOrCPODate"];
                    if (dr["CheckMaturityDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Checkmaturitydate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Checkmaturitydate = (DateTime)dr["CheckMaturityDate"];
                    if (dr["Settled"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Settled = int.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Settled = (int)dr["Settled"];
                    if (dr["SettlementDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Settlementdate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Settlementdate = (DateTime)dr["SettlementDate"];
                    if (dr["OrderDate"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Orderdate = DateTime.MinValue;
                    else
                        objCLocalPurchaseOrderSettlements.Orderdate = (DateTime)dr["OrderDate"];
                    if (dr["OrderNumber"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Ordernumber = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Ordernumber = (string)dr["OrderNumber"];
                    if (dr["SupplierName"].Equals(DBNull.Value))
                        objCLocalPurchaseOrderSettlements.Suppliername = string.Empty;
                    else
                        objCLocalPurchaseOrderSettlements.Suppliername = (string)dr["SupplierName"];

                    RecordsList.Add(objCLocalPurchaseOrderSettlements);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderSettlements::GetList::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblLocalPurchaseOrderSettlements] WHERE Id = @Id";
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
                throw new Exception("CLocalPurchaseOrderSettlements::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrderSettlements] WHERE TableRowGuid = @Tablerowguid";
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
                throw new Exception("CLocalPurchaseOrderSettlements::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}
