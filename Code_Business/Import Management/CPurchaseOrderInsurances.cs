//
// ...
// Wizard generated code
// Date: 7/25/2009 2:40:28 PM
// Class: CPurchaseOrderInsurances
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
    class CPurchaseOrderInsurances
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CPurchaseOrderInsurances()
        {
            _ConnectionString = ConnectionString;
        }
        public CPurchaseOrderInsurances(int Id, string Purchaseorderguid, string Insurername, DateTime Insureddate, string Referencenumber, decimal Amount)
        {
            _Id = Id;
            _PurchaseOrderGuid = Purchaseorderguid;
            _InsurerName = Insurername;
            _InsuredDate = Insureddate;
            _ReferenceNumber = Referencenumber;
            _Amount = Amount;
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

        string _InsurerName;
        public string Insurername
        {
            get { return _InsurerName; }
            set { _InsurerName = value; }
        }

        DateTime _InsuredDate;
        public DateTime Insureddate
        {
            get { return _InsuredDate; }
            set { _InsuredDate = value; }
        }

        string _ReferenceNumber;
        public string Referencenumber
        {
            get { return _ReferenceNumber; }
            set { _ReferenceNumber = value; }
        }

        decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
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
            command.CommandText = "Select * from tblPurchaseOrderInsurances where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrderInsurances");
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
                    if (dTable.Rows[0]["InsurerName"].Equals(DBNull.Value))
                        _InsurerName = string.Empty;
                    else
                        _InsurerName = (string)dTable.Rows[0]["InsurerName"];
                    if (dTable.Rows[0]["InsuredDate"].Equals(DBNull.Value))
                        _InsuredDate = DateTime.MinValue;
                    else
                        _InsuredDate = (DateTime)dTable.Rows[0]["InsuredDate"];
                    if (dTable.Rows[0]["ReferenceNumber"].Equals(DBNull.Value))
                        _ReferenceNumber = string.Empty;
                    else
                        _ReferenceNumber = (string)dTable.Rows[0]["ReferenceNumber"];
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
                throw new Exception("CPurchaseOrderInsurances::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblPurchaseOrderInsurances";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrderInsurances");
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
                throw new Exception("CPurchaseOrderInsurances::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Purchaseorderguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrderInsurances where PurchaseOrderGuid=@PurchaseOrderGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblPurchaseOrderInsurances");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderInsurances::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblPurchaseOrderInsurances" +
                                   " (PurchaseOrderGuid, " +
                                   " InsurerName, " +
                                   " InsuredDate, " +
                                   " ReferenceNumber, " +
                                   " Amount,UserId,ComputerName,EventSource)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @InsurerName, " +
                                   " @InsuredDate, " +
                                   " @ReferenceNumber, " +
                                   " @Amount,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblPurchaseOrderInsurances ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@InsurerName", _InsurerName));
                if (_InsuredDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InsuredDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InsuredDate", _InsuredDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
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
                throw new Exception("CPurchaseOrderInsurances::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblPurchaseOrderInsurances" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " InsurerName = @InsurerName, " +
                                   " InsuredDate = @InsuredDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " Amount = @Amount," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@InsurerName", _InsurerName));
                if (_InsuredDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InsuredDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InsuredDate", _InsuredDate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", _ReferenceNumber));
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
                throw new Exception("CPurchaseOrderInsurances::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblPurchaseOrderInsurances Where Id = @Id ";
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
                throw new Exception("CPurchaseOrderInsurances::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderInsurances] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND InsurerName = @InsurerName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderInsurances] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND InsurerName = @InsurerName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@InsurerName", _InsurerName));
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
                throw new Exception("CPurchaseOrderInsurances::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Purchaseorderguid, string Insurername, DateTime Insureddate, string Referencenumber, decimal Amount)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblPurchaseOrderInsurances" +
                                   " (PurchaseOrderGuid, " +
                                   " InsurerName, " +
                                   " InsuredDate, " +
                                   " ReferenceNumber, " +
                                   " Amount)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @InsurerName, " +
                                   " @InsuredDate, " +
                                   " @ReferenceNumber, " +
                                   " @Amount)" +
                                   " Select @Id=Max(id) from tblPurchaseOrderInsurances ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@InsurerName", Insurername));
                if (Insureddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InsuredDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InsuredDate", Insureddate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
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
                throw new Exception("CPurchaseOrderInsurances::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Purchaseorderguid, string Insurername, DateTime Insureddate, string Referencenumber, decimal Amount)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblPurchaseOrderInsurances" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " InsurerName = @InsurerName, " +
                                   " InsuredDate = @InsuredDate, " +
                                   " ReferenceNumber = @ReferenceNumber, " +
                                   " Amount = @Amount" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@InsurerName", Insurername));
                if (Insureddate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@InsuredDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@InsuredDate", Insureddate));
                command.Parameters.Add(new SqlParameter("@ReferenceNumber", Referencenumber));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderInsurances::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblPurchaseOrderInsurances Where Id = @Id ";
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
                throw new Exception("CPurchaseOrderInsurances::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Purchaseorderguid, string Insurername)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderInsurances] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND InsurerName = @InsurerName";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderInsurances] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND InsurerName = @InsurerName " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@InsurerName", Insurername));
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
                throw new Exception("CPurchaseOrderInsurances::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CPurchaseOrderInsurances> GetList()
        {
            List<CPurchaseOrderInsurances> RecordsList = new List<CPurchaseOrderInsurances>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrderInsurances";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CPurchaseOrderInsurances objCPurchaseOrderInsurances = new CPurchaseOrderInsurances();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Id = 0;
                    else
                        objCPurchaseOrderInsurances.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Purchaseorderguid = string.Empty;
                    else
                        objCPurchaseOrderInsurances.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["InsurerName"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Insurername = string.Empty;
                    else
                        objCPurchaseOrderInsurances.Insurername = (string)dr["InsurerName"];
                    if (dr["InsuredDate"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Insureddate = DateTime.MinValue;
                    else
                        objCPurchaseOrderInsurances.Insureddate = (DateTime)dr["InsuredDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Referencenumber = string.Empty;
                    else
                        objCPurchaseOrderInsurances.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["Amount"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Amount = 0;
                    else
                        objCPurchaseOrderInsurances.Amount = (decimal)dr["Amount"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrderInsurances.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrderInsurances);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderInsurances::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CPurchaseOrderInsurances> GetList(string Purchaseorderguid)
        {
            List<CPurchaseOrderInsurances> RecordsList = new List<CPurchaseOrderInsurances>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblPurchaseOrderInsurances where PurchaseOrderGuid=@PurchaseOrderGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CPurchaseOrderInsurances objCPurchaseOrderInsurances = new CPurchaseOrderInsurances();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Id = 0;
                    else
                        objCPurchaseOrderInsurances.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Purchaseorderguid = string.Empty;
                    else
                        objCPurchaseOrderInsurances.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["InsurerName"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Insurername = string.Empty;
                    else
                        objCPurchaseOrderInsurances.Insurername = (string)dr["InsurerName"];
                    if (dr["InsuredDate"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Insureddate = DateTime.MinValue;
                    else
                        objCPurchaseOrderInsurances.Insureddate = (DateTime)dr["InsuredDate"];
                    if (dr["ReferenceNumber"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Referencenumber = string.Empty;
                    else
                        objCPurchaseOrderInsurances.Referencenumber = (string)dr["ReferenceNumber"];
                    if (dr["Amount"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Amount = 0;
                    else
                        objCPurchaseOrderInsurances.Amount = (decimal)dr["Amount"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderInsurances.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrderInsurances.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrderInsurances);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CPurchaseOrderInsurances::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblPurchaseOrderInsurances] WHERE Id = @Id";
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
                throw new Exception("CPurchaseOrderInsurances::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblPurchaseOrderInsurances] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CPurchaseOrderInsurances::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
