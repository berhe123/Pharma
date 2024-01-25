//
// ...
// Wizard generated code
// Date: 7/28/2009 5:52:51 PM
// Class: CSuppliesRequisitionDetails
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
    class CSuppliesRequisitionDetails
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CSuppliesRequisitionDetails()
        {
            _ConnectionString = ConnectionString;
        }
        public CSuppliesRequisitionDetails(int Id, string Suppliesrequisitionguid, string Itemguid, decimal Requestedquantity, decimal Approvedquantity)
        {
            _Id = Id;
            _SuppliesRequisitionGuid = Suppliesrequisitionguid;
            _ItemGuid = Itemguid;
            _RequestedQuantity = Requestedquantity;
            _ApprovedQuantity = Approvedquantity;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _SuppliesRequisitionGuid;
        public string Suppliesrequisitionguid
        {
            get { return _SuppliesRequisitionGuid; }
            set { _SuppliesRequisitionGuid = value; }
        }

        string _ItemGuid;
        public string Itemguid
        {
            get { return _ItemGuid; }
            set { _ItemGuid = value; }
        }

        decimal _RequestedQuantity;
        public decimal Requestedquantity
        {
            get { return _RequestedQuantity; }
            set { _RequestedQuantity = value; }
        }

        decimal _ApprovedQuantity;
        public decimal Approvedquantity
        {
            get { return _ApprovedQuantity; }
            set { _ApprovedQuantity = value; }
        }

        string _BrandName;
        public string BrandName
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        string _Unit;
        public string Unit
        {
            get { return _Unit; }
            set { _Unit = value; }
        }

        string _BatchGuid;
        public string Batchguid
        {
            get { return _BatchGuid; }
            set { _BatchGuid = value; }
        }

        string _BatchName;
        public string BatchName
        {
            get { return _BatchName; }
            set { _BatchName = value; }
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
            command.CommandText = "Select * from tblSuppliesRequisitionDetails where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblSuppliesRequisitionDetails");
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
                    if (dTable.Rows[0]["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        _SuppliesRequisitionGuid = string.Empty;
                    else
                        _SuppliesRequisitionGuid = (string)dTable.Rows[0]["SuppliesRequisitionGuid"];
                    if (dTable.Rows[0]["ItemGuid"].Equals(DBNull.Value))
                        _ItemGuid = string.Empty;
                    else
                        _ItemGuid = (string)dTable.Rows[0]["ItemGuid"];
                    if (dTable.Rows[0]["RequestedQuantity"].Equals(DBNull.Value))
                        _RequestedQuantity = decimal.Zero;
                    else
                        _RequestedQuantity = (decimal)dTable.Rows[0]["RequestedQuantity"];
                    if (dTable.Rows[0]["ApprovedQuantity"].Equals(DBNull.Value))
                        _ApprovedQuantity = decimal.Zero;
                    else
                        _ApprovedQuantity = (decimal)dTable.Rows[0]["ApprovedQuantity"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitionDetails::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblSuppliesRequisitionDetails";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblSuppliesRequisitionDetails");
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
                throw new Exception("CSuppliesRequisitionDetails::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblSuppliesRequisitionDetails" +
                                   " (SuppliesRequisitionGuid, " +
                                   " ItemGuid, " +
                                   " RequestedQuantity, " +
                                   " ApprovedQuantity,UserId,ComputerName,EventSource)" +
                                   " Values (@SuppliesRequisitionGuid, " +
                                   " @ItemGuid, " +
                                   " @RequestedQuantity, " +
                                   " @ApprovedQuantity,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblSuppliesRequisitionDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@RequestedQuantity", _RequestedQuantity));
                command.Parameters.Add(new SqlParameter("@ApprovedQuantity", _ApprovedQuantity));

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
                throw new Exception("CSuppliesRequisitionDetails::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblSuppliesRequisitionDetails" +
                                   " Set SuppliesRequisitionGuid = @SuppliesRequisitionGuid, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " RequestedQuantity = @RequestedQuantity, " +
                                   " ApprovedQuantity = @ApprovedQuantity," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@RequestedQuantity", _RequestedQuantity));
                command.Parameters.Add(new SqlParameter("@ApprovedQuantity", _ApprovedQuantity));

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
                throw new Exception("CSuppliesRequisitionDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblSuppliesRequisitionDetails Where Id = @Id ";
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
                throw new Exception("CSuppliesRequisitionDetails::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblSuppliesRequisitionDetails] WHERE " +
                                       " SuppliesRequisitionGuid = @SuppliesRequisitionGuid " +
                                       " AND ItemGuid = @ItemGuid ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblSuppliesRequisitionDetails] WHERE " +
                                       " SuppliesRequisitionGuid = @SuppliesRequisitionGuid " +
                                       " AND ItemGuid = @ItemGuid " +                                  
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@RequestedQuantity", _RequestedQuantity));
                command.Parameters.Add(new SqlParameter("@ApprovedQuantity", _ApprovedQuantity));
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
                throw new Exception("CSuppliesRequisitionDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
                
        public List<CSuppliesRequisitionDetails> GetList()
        {
            List<CSuppliesRequisitionDetails> RecordsList = new List<CSuppliesRequisitionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblSuppliesRequisitionDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSuppliesRequisitionDetails objCSuppliesRequisitionDetails = new CSuppliesRequisitionDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSuppliesRequisitionDetails.Id = 0;
                    else
                        objCSuppliesRequisitionDetails.Id = (int)dr["Id"];
                    if (dr["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitionDetails.Suppliesrequisitionguid = string.Empty;
                    else
                        objCSuppliesRequisitionDetails.Suppliesrequisitionguid = (string)dr["SuppliesRequisitionGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitionDetails.Itemguid = string.Empty;
                    else
                        objCSuppliesRequisitionDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["RequestedQuantity"].Equals(DBNull.Value))
                        _RequestedQuantity = decimal.Zero;
                    else
                        objCSuppliesRequisitionDetails.Requestedquantity = (decimal)dr["RequestedQuantity"];
                    if (dr["ApprovedQuantity"].Equals(DBNull.Value))
                        _ApprovedQuantity = decimal.Zero;
                    else
                        objCSuppliesRequisitionDetails.Approvedquantity = (decimal)dr["ApprovedQuantity"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitionDetails.Tablerowguid = string.Empty;
                    else
                        objCSuppliesRequisitionDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCSuppliesRequisitionDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitionDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSuppliesRequisitionDetails> GetList(string Suppliesrequesitionguid)
        {
            List<CSuppliesRequisitionDetails> RecordsList = new List<CSuppliesRequisitionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL ="";
            strSQL = strSQL + " Select tblSuppliesRequisitionDetails.*, ";

            strSQL += " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
            strSQL += " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
            strSQL += " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
            strSQL += " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
            strSQL += " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
            strSQL += " inner join tblSuppliesRequisitionDetails on tblSuppliesRequisitionDetails.ItemGuid =tblItems.TableRowGuid";
            strSQL += " inner join tblSuppliesRequisitions on tblSuppliesRequisitionDetails.SuppliesRequisitionGuid =tblSuppliesRequisitions.TableRowGuid";

            //strSQL = strSQL + " from tblSuppliesRequisitionDetails join tblItems on (tblSuppliesRequisitionDetails.ItemGuid = tblItems.TableRowGuid) ";
            //strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            //strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " where SuppliesRequisitionGuid = '" + Suppliesrequesitionguid + "' ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSuppliesRequisitionDetails objCSuppliesRequisitionDetails = new CSuppliesRequisitionDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCSuppliesRequisitionDetails.Id = 0;
                    else
                        objCSuppliesRequisitionDetails.Id = (int)dr["Id"];
                    if (dr["SuppliesRequisitionGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitionDetails.Suppliesrequisitionguid = string.Empty;
                    else
                        objCSuppliesRequisitionDetails.Suppliesrequisitionguid = (string)dr["SuppliesRequisitionGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitionDetails.Itemguid = string.Empty;
                    else
                        objCSuppliesRequisitionDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["RequestedQuantity"].Equals(DBNull.Value))
                        _RequestedQuantity = decimal.Zero;
                    else
                        objCSuppliesRequisitionDetails.Requestedquantity = (decimal)dr["RequestedQuantity"];
                    if (dr["ApprovedQuantity"].Equals(DBNull.Value))
                        _ApprovedQuantity = decimal.Zero;
                    else
                        objCSuppliesRequisitionDetails.Approvedquantity = (decimal)dr["ApprovedQuantity"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        _BrandName = string.Empty;
                    else
                        objCSuppliesRequisitionDetails.BrandName = (string)dr["BrandName"];
                    //if (dr["DosageForm"].Equals(DBNull.Value))
                    //    _BrandName = _BrandName + string.Empty;
                    //else
                    //    objCSuppliesRequisitionDetails.BrandName = objCSuppliesRequisitionDetails.BrandName + " " + (string)dr["DosageForm"];
                    //if (dr["Unit"].Equals(DBNull.Value))
                    //    _BrandName = string.Empty;
                    //else
                    //    objCSuppliesRequisitionDetails.Unit = (string)dr["Unit"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitionDetails.Tablerowguid = string.Empty;
                    else
                        objCSuppliesRequisitionDetails.Tablerowguid = (string)dr["TableRowGuid"];
                     

                    RecordsList.Add(objCSuppliesRequisitionDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitionDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool CheckHasChildren()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = " Select * from tblSuppliesRequisitionDetails where SuppliesRequisitionGuid =@SuppliesRequisitionGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@SuppliesRequisitionGuid", _SuppliesRequisitionGuid));
                connection.Open();
                dr = command.ExecuteReader();
                if (dr.HasRows)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitionDetails::CheckHasChildren::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CSuppliesRequisitionDetails> GetListItems(string strCriteria)
        {
            List<CSuppliesRequisitionDetails> RecordsList = new List<CSuppliesRequisitionDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL ="";
            strSQL = strSQL + " Select tblItems.Id, tblItems.TableRowGuid as ItemGuid, ( tblItems.Measurement ) Unit ,";
            strSQL = strSQL + " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
            strSQL = strSQL + " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
            strSQL = strSQL + " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
            strSQL = strSQL + " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
            strSQL = strSQL + " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
            strSQL = strSQL + " inner join tblBatchs on  (tblItems.TableRowGuid = tblBatchs.ItemGuid) ";
           // strSQL = strSQL + " inner join tblLocalPurchaseOrders on (tblLocalPurchaseOrders.TableRowGuid =tblBatchs.PurchaseOrderguid)";
           
            //strSQL = strSQL + " from tblItems  ";
           

           // strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + "  where 1=1 " + strCriteria;
            strSQL = strSQL + " Order by BrandName ";
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CSuppliesRequisitionDetails objCSuppliesRequisitionDetails = new CSuppliesRequisitionDetails();

                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCSuppliesRequisitionDetails.Itemguid = string.Empty;
                    else
                        objCSuppliesRequisitionDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        _BrandName = string.Empty;
                    else
                        objCSuppliesRequisitionDetails.BrandName = (string)dr["BrandName"];
                     if (dr["Unit"].Equals(DBNull.Value))
                         _Unit = string.Empty;
                     else
                         objCSuppliesRequisitionDetails.Unit = (string)dr["Unit"];

                    RecordsList.Add(objCSuppliesRequisitionDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CSuppliesRequisitionDetails::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblSuppliesRequisitionDetails] WHERE Id = @Id";
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
                throw new Exception("CSuppliesRequisitionDetails::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblSuppliesRequisitionDetails] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CSuppliesRequisitionDetails::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

    }
}




