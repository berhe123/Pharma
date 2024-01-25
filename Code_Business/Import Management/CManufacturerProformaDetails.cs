//
// ...
// Wizard generated code
// Date: 7/22/2009 4:21:59 PM
// Class: CManufacturerProformaDetails
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
    class CManufacturerProformaDetails
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CManufacturerProformaDetails()
        {
            _ConnectionString = ConnectionString;
        }
        public CManufacturerProformaDetails(int Id, string Manufacturerproformaguid, int Notificationnumber, string Itemguid, decimal Quantity, decimal Priceperunit)
        {
            _Id = Id;
            _ManufacturerProformaGuid = Manufacturerproformaguid;
            _NotificationNumber = Notificationnumber;
            _ItemGuid = Itemguid;
            _Quantity = Quantity;
            _PricePerUnit = Priceperunit;
        }

        #region Class Property Declarations
        int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        string _ManufacturerProformaGuid;
        public string Manufacturerproformaguid
        {
            get { return _ManufacturerProformaGuid; }
            set { _ManufacturerProformaGuid = value; }
        }

        int _NotificationNumber;
        public int Notificationnumber
        {
            get { return _NotificationNumber; }
            set { _NotificationNumber = value; }
        }

        string _ItemGuid;
        public string Itemguid
        {
            get { return _ItemGuid; }
            set { _ItemGuid = value; }
        }

        string _ItemDescription;
        public string Itemdescription
        {
            get { return _ItemDescription; }
            set { _ItemDescription = value; }
        }

        decimal _Quantity;
        public decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }

        decimal _PricePerUnit;
        public decimal Priceperunit
        {
            get { return _PricePerUnit; }
            set { _PricePerUnit = value; }
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
            string strSQL = string.Empty;

            strSQL = " SELECT   tblManufacturerProformaDetails.Id, tblManufacturerProformaDetails.ManufacturerProformaGuid, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.NotificationNumber, tblManufacturerProformaDetails.ItemGuid, BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.Quantity, tblManufacturerProformaDetails.PricePerUnit ";
            strSQL = strSQL + " FROM      tblItems INNER JOIN";
            strSQL = strSQL + "                tblManufacturerProformaDetails ON tblItems.TableRowGuid = tblManufacturerProformaDetails.ItemGuid ";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " where Id=@Id";
            
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblManufacturerProformaDetails");
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
                    if (dTable.Rows[0]["ManufacturerProformaGuid"].Equals(DBNull.Value))
                        _ManufacturerProformaGuid = string.Empty;
                    else
                        _ManufacturerProformaGuid = (string)dTable.Rows[0]["ManufacturerProformaGuid"];
                    if (dTable.Rows[0]["NotificationNumber"].Equals(DBNull.Value))
                        _NotificationNumber = 0;
                    else
                        _NotificationNumber = (int)dTable.Rows[0]["NotificationNumber"];
                    if (dTable.Rows[0]["ItemGuid"].Equals(DBNull.Value))
                        _ItemGuid = string.Empty;
                    else
                        _ItemGuid = (string)dTable.Rows[0]["ItemGuid"];
                    if (dTable.Rows[0]["BrandName"].Equals(DBNull.Value))
                        _ItemDescription = string.Empty;
                    else
                        _ItemDescription = (string)dTable.Rows[0]["BrandName"];
                    if (dTable.Rows[0]["Quantity"].Equals(DBNull.Value))
                        _Quantity = 0;
                    else
                        _Quantity = (decimal)dTable.Rows[0]["Quantity"];
                    if (dTable.Rows[0]["PricePerUnit"].Equals(DBNull.Value))
                        _PricePerUnit = 0;
                    else
                        _PricePerUnit = (decimal)dTable.Rows[0]["PricePerUnit"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformaDetails::GetRecord::Error! " + ex.Message, ex);
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
            string strSQL = string.Empty;

            strSQL = " SELECT   tblManufacturerProformaDetails.Id, tblManufacturerProformaDetails.ManufacturerProformaGuid, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.NotificationNumber, tblManufacturerProformaDetails.ItemGuid, BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.Quantity, tblManufacturerProformaDetails.PricePerUnit ";
            strSQL = strSQL + " FROM      tblItems INNER JOIN";
            strSQL = strSQL + "                tblManufacturerProformaDetails ON tblItems.TableRowGuid = tblManufacturerProformaDetails.ItemGuid";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblManufacturerProformaDetails");
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
                throw new Exception("CManufacturerProformaDetails::GetRecords::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecords(string Manufacturerproformaguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " SELECT   tblManufacturerProformaDetails.Id, tblManufacturerProformaDetails.ManufacturerProformaGuid, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.NotificationNumber, tblManufacturerProformaDetails.ItemGuid, BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.Quantity, tblManufacturerProformaDetails.PricePerUnit ";
            strSQL = strSQL + " FROM      tblItems INNER JOIN";
            strSQL = strSQL + "                tblManufacturerProformaDetails ON tblItems.TableRowGuid = tblManufacturerProformaDetails.ItemGuid";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " where ManufacturerProformaGuid=@ManufacturerProformaGuid";
            
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblManufacturerProformaDetails");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", Manufacturerproformaguid));
                connection.Open();
                adapter.Fill(dTable);
                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformaDetails::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblManufacturerProformaDetails" +
                                   " (ManufacturerProformaGuid, " +
                                   " NotificationNumber, " +
                                   " ItemGuid, " +
                                   " Quantity, " +
                                   " PricePerUnit,UserId,ComputerName,EventSource)" +
                                   " Values (@ManufacturerProformaGuid, " +
                                   " @NotificationNumber, " +
                                   " @ItemGuid, " +
                                   " @Quantity, " +
                                   " @PricePerUnit,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblManufacturerProformaDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", _ManufacturerProformaGuid));
                command.Parameters.Add(new SqlParameter("@NotificationNumber", _NotificationNumber));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                command.Parameters.Add(new SqlParameter("@PricePerUnit", _PricePerUnit));

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
                throw new Exception("CManufacturerProformaDetails::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblManufacturerProformaDetails" +
                                   " Set ManufacturerProformaGuid = @ManufacturerProformaGuid, " +
                                   " NotificationNumber = @NotificationNumber, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " Quantity = @Quantity, " +
                                   " PricePerUnit = @PricePerUnit," +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", _ManufacturerProformaGuid));
                command.Parameters.Add(new SqlParameter("@NotificationNumber", _NotificationNumber));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                command.Parameters.Add(new SqlParameter("@PricePerUnit", _PricePerUnit));

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
                throw new Exception("CManufacturerProformaDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblManufacturerProformaDetails Where Id = @Id ";
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
                throw new Exception("CManufacturerProformaDetails::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformaDetails] WHERE " +
                                       " ManufacturerProformaGuid = @ManufacturerProformaGuid " +
                                       " AND NotificationNumber = @NotificationNumber " +
                                       " AND ItemGuid = @ItemGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformaDetails] WHERE " +
                                       " ManufacturerProformaGuid = @ManufacturerProformaGuid " +
                                       " AND NotificationNumber = @NotificationNumber " +
                                       " AND ItemGuid = @ItemGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", _ManufacturerProformaGuid));
                command.Parameters.Add(new SqlParameter("@NotificationNumber", _NotificationNumber));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
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
                throw new Exception("CManufacturerProformaDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Manufacturerproformaguid, int Notificationnumber, string Itemguid, decimal Quantity, decimal Priceperunit)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblManufacturerProformaDetails" +
                                   " (ManufacturerProformaGuid, " +
                                   " NotificationNumber, " +
                                   " ItemGuid, " +
                                   " Quantity, " +
                                   " PricePerUnit)" +
                                   " Values (@ManufacturerProformaId, " +
                                   " @NotificationNumber, " +
                                   " @ItemId, " +
                                   " @Quantity, " +
                                   " @PricePerUnit)" +
                                   " Select @Id=Max(id) from tblManufacturerProformaDetails ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", Manufacturerproformaguid));
                command.Parameters.Add(new SqlParameter("@NotificationNumber", Notificationnumber));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                command.Parameters.Add(new SqlParameter("@Quantity", Quantity));
                command.Parameters.Add(new SqlParameter("@PricePerUnit", Priceperunit));

                command.Parameters.Add(new SqlParameter("@Id", Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformaDetails::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Manufacturerproformaguid, int Notificationnumber, string Itemguid, decimal Quantity, decimal Priceperunit)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblManufacturerProformaDetails" +
                                   " Set ManufacturerProformaGuid = @ManufacturerProformaGuid, " +
                                   " NotificationNumber = @NotificationNumber, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " Quantity = @Quantity, " +
                                   " PricePerUnit = @PricePerUnit" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", Manufacturerproformaguid));
                command.Parameters.Add(new SqlParameter("@NotificationNumber", Notificationnumber));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                command.Parameters.Add(new SqlParameter("@Quantity", Quantity));
                command.Parameters.Add(new SqlParameter("@PricePerUnit", Priceperunit));

                command.Parameters.Add(new SqlParameter("@Id", Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformaDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblManufacturerProformaDetails Where Id = @Id ";
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
                throw new Exception("CManufacturerProformaDetails::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Manufacturerproformaguid, int Notificationnumber, string Itemguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformaDetails] WHERE " +
                                       " ManufacturerProformaGuid = @ManufacturerProformaGuid " +
                                       " AND NotificationNumber = @NotificationNumber " +
                                       " AND ItemGuid = @ItemGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformaDetails] WHERE " +
                                       " ManufacturerProformaGuid = @ManufacturerProformaGuid " +
                                       " AND NotificationNumber = @NotificationNumber " +
                                       " AND ItemGuid = @ItemGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", Manufacturerproformaguid));
                command.Parameters.Add(new SqlParameter("@NotificationNumber", Notificationnumber));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
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
                throw new Exception("CManufacturerProformaDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CManufacturerProformaDetails> GetList()
        {
            List<CManufacturerProformaDetails> RecordsList = new List<CManufacturerProformaDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " SELECT   tblManufacturerProformaDetails.Id, tblManufacturerProformaDetails.TableRowGuid, tblManufacturerProformaDetails.ManufacturerProformaGuid, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.NotificationNumber, tblManufacturerProformaDetails.ItemGuid, BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.Quantity, tblManufacturerProformaDetails.PricePerUnit ";
            strSQL = strSQL + " FROM      tblItems INNER JOIN";
            strSQL = strSQL + "                tblManufacturerProformaDetails ON tblItems.TableRowGuid = tblManufacturerProformaDetails.ItemGuid ";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturerProformaDetails objCManufacturerProformaDetails = new CManufacturerProformaDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Id = 0;
                    else
                        objCManufacturerProformaDetails.Id = (int)dr["Id"];
                    if (dr["ManufacturerProformaGuid"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Manufacturerproformaguid = string.Empty;
                    else
                        objCManufacturerProformaDetails.Manufacturerproformaguid = (string)dr["ManufacturerProformaGuid"];
                    if (dr["NotificationNumber"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Notificationnumber = 0;
                    else
                        objCManufacturerProformaDetails.Notificationnumber = (int)dr["NotificationNumber"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Itemguid = string.Empty;
                    else
                        objCManufacturerProformaDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Itemdescription = string.Empty;
                    else
                        objCManufacturerProformaDetails.Itemdescription = (string)dr["BrandName"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Quantity = 0;
                    else
                        objCManufacturerProformaDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["PricePerUnit"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Priceperunit = 0;
                    else
                        objCManufacturerProformaDetails.Priceperunit = (decimal)dr["PricePerUnit"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Tablerowguid = string.Empty;
                    else
                        objCManufacturerProformaDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturerProformaDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformaDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CManufacturerProformaDetails> GetList(string Manufacturerproformaguid)
        {
            List<CManufacturerProformaDetails> RecordsList = new List<CManufacturerProformaDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            string strSQL = string.Empty;

            strSQL = " SELECT   tblManufacturerProformaDetails.Id, tblManufacturerProformaDetails.TableRowGuid, tblManufacturerProformaDetails.ManufacturerProformaGuid, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.NotificationNumber, tblManufacturerProformaDetails.ItemGuid, BrandName = BrandName + ' (' + GenericName + ') ' + Strength + ' ' + tblItems.Measurement + ' ' + tblDosageForms.name, ";
            strSQL = strSQL + "                tblManufacturerProformaDetails.Quantity, tblManufacturerProformaDetails.PricePerUnit ";
            strSQL = strSQL + " FROM      tblItems INNER JOIN";
            strSQL = strSQL + "                tblManufacturerProformaDetails ON tblItems.TableRowGuid = tblManufacturerProformaDetails.ItemGuid ";
            strSQL = strSQL + " join tblDosageForms on (tblItems.DosageFormGuid = tblDosageForms.TableRowGuid) ";
            strSQL = strSQL + " where ManufacturerProformaGuid=@ManufacturerProformaGuid";
            strSQL = strSQL + " Order by tblManufacturerProformaDetails.NotificationNumber, tblManufacturerProformaDetails.Id ";

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerProformaGuid", Manufacturerproformaguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CManufacturerProformaDetails objCManufacturerProformaDetails = new CManufacturerProformaDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Id = 0;
                    else
                        objCManufacturerProformaDetails.Id = (int)dr["Id"];
                    if (dr["ManufacturerProformaGuid"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Manufacturerproformaguid = string.Empty;
                    else
                        objCManufacturerProformaDetails.Manufacturerproformaguid = (string)dr["ManufacturerProformaGuid"];
                    if (dr["NotificationNumber"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Notificationnumber = 0;
                    else
                        objCManufacturerProformaDetails.Notificationnumber = (int)dr["NotificationNumber"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Itemguid = string.Empty;
                    else
                        objCManufacturerProformaDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Itemdescription = string.Empty;
                    else
                        objCManufacturerProformaDetails.Itemdescription = (string)dr["BrandName"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Quantity = 0;
                    else
                        objCManufacturerProformaDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["PricePerUnit"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Priceperunit = 0;
                    else
                        objCManufacturerProformaDetails.Priceperunit = (decimal)dr["PricePerUnit"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCManufacturerProformaDetails.Tablerowguid = string.Empty;
                    else
                        objCManufacturerProformaDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCManufacturerProformaDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CManufacturerProformaDetails::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblManufacturerProformaDetails] WHERE Id = @Id";
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
                throw new Exception("CManufacturerProformaDetails::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblManufacturerProformaDetails] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CManufacturerProformaDetails::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
