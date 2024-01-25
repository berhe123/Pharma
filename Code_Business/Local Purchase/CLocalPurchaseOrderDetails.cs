﻿//
// ...
// Wizard generated code
// Date: 8/15/2009 3:57:14 PM
// Class: CLocalPurchaseOrderDetails
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
    class CLocalPurchaseOrderDetails
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CLocalPurchaseOrderDetails()
        {
            _ConnectionString = ConnectionString;
        }
        public CLocalPurchaseOrderDetails(int Id, string Purchaseorderguid, string Itemguid, decimal Quantity, decimal Priceperunit)
        {
            _Id = Id;
            _PurchaseOrderGuid = Purchaseorderguid;
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

        string _PurchaseOrderGuid;
        public string Purchaseorderguid
        {
            get { return _PurchaseOrderGuid; }
            set { _PurchaseOrderGuid = value; }
        }

        string _ItemGuid;
        public string Itemguid
        {
            get { return _ItemGuid; }
            set { _ItemGuid = value; }
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
            command.CommandText = "Select * from tblLocalPurchaseOrderDetails where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocalPurchaseOrderDetails");
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
                    if (dTable.Rows[0]["ItemGuid"].Equals(DBNull.Value))
                        _ItemGuid = string.Empty;
                    else
                        _ItemGuid = (string)dTable.Rows[0]["ItemGuid"];
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
                throw new Exception("CLocalPurchaseOrderDetails::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }
        public DataTable GetRecord(string Purchaseorderguid, string Itemguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLocalPurchaseOrderDetails where PurchaseOrderGuid=@PurchaseOrderGuid and ItemGuid = @ItemGuid ";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocalPurchaseOrderDetails");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                connection.Open();
                adapter.Fill(dTable);
                if (dTable.Rows.Count > 0)
                {
                    _Id = (int)dTable.Rows[0]["Id"];
                    if (dTable.Rows[0]["PurchaseOrderGuid"].Equals(DBNull.Value))
                        _PurchaseOrderGuid = string.Empty;
                    else
                        _PurchaseOrderGuid = (string)dTable.Rows[0]["PurchaseOrderGuid"];
                    if (dTable.Rows[0]["ItemGuid"].Equals(DBNull.Value))
                        _ItemGuid = string.Empty;
                    else
                        _ItemGuid = (string)dTable.Rows[0]["ItemGuid"];
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
                throw new Exception("CLocalPurchaseOrderDetails::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblLocalPurchaseOrderDetails";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocalPurchaseOrderDetails");
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
                throw new Exception("CLocalPurchaseOrderDetails::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblLocalPurchaseOrderDetails where PurchaseOrderGuid=@PurchaseOrderGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblLocalPurchaseOrderDetails");
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
                throw new Exception("CLocalPurchaseOrderDetails::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblLocalPurchaseOrderDetails" +
                                   " (PurchaseOrderGuid, " +
                                   " ItemGuid, " +
                                   " Quantity, " +
                                   " PricePerUnit)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @ItemGuid, " +
                                   " @Quantity, " +
                                   " @PricePerUnit)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                command.Parameters.Add(new SqlParameter("@PricePerUnit", _PricePerUnit));

                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderDetails::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblLocalPurchaseOrderDetails" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " Quantity = @Quantity, " +
                                   " PricePerUnit = @PricePerUnit" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                command.Parameters.Add(new SqlParameter("@PricePerUnit", _PricePerUnit));
                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblLocalPurchaseOrderDetails Where Id = @Id ";
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
                throw new Exception("CLocalPurchaseOrderDetails::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrderDetails] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid" +
                                       " AND ItemGuid = @ItemGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrderDetails] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid" +
                                       " AND ItemGuid = @ItemGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
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
                throw new Exception("CLocalPurchaseOrderDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool Insert(int Id, string Purchaseorderguid, string Itemguid, decimal Quantity, decimal Priceperunit)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Insert Into tblLocalPurchaseOrderDetails" +
                                   " (PurchaseOrderGuid, " +
                                   " ItemGuid, " +
                                   " Quantity, " +
                                   " PricePerUnit)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @ItemGuid, " +
                                   " @Quantity, " +
                                   " @PricePerUnit)" +
                                   " Select @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
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
                throw new Exception("CLocalPurchaseOrderDetails::Insert::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public bool Update(int Id, string Purchaseorderguid, string Itemguid, decimal Quantity, decimal Priceperunit)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblLocalPurchaseOrderDetails" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " Quantity = @Quantity, " +
                                   " PricePerUnit = @PricePerUnit" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
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
                throw new Exception("CLocalPurchaseOrderDetails::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblLocalPurchaseOrderDetails Where Id = @Id ";
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
                throw new Exception("CLocalPurchaseOrderDetails::Delete::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists(bool bNew, int Id, string Itemguid, string Purchaseorderguid)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrderDetails] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid" +
                                       " AND ItemGuid = @ItemGuid";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrderDetails] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid" +
                                       " AND ItemGuid = @ItemGuid " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                if (!bNew)
                    command.Parameters.Add(new SqlParameter("@Id", Id));
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
                throw new Exception("CLocalPurchaseOrderDetails::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CLocalPurchaseOrderDetails> GetList()
        {
            List<CLocalPurchaseOrderDetails> RecordsList = new List<CLocalPurchaseOrderDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblLocalPurchaseOrderDetails";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocalPurchaseOrderDetails objCPurchaseOrderDetails = new CLocalPurchaseOrderDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Id = 0;
                    else
                        objCPurchaseOrderDetails.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Purchaseorderguid = string.Empty;
                    else
                        objCPurchaseOrderDetails.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Itemguid = string.Empty;
                    else
                        objCPurchaseOrderDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Quantity = 0;
                    else
                        objCPurchaseOrderDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["PricePerUnit"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Priceperunit = 0;
                    else
                        objCPurchaseOrderDetails.Priceperunit = (decimal)dr["PricePerUnit"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrderDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrderDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderDetails::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CLocalPurchaseOrderDetails> GetList(string Purchaseorderguid)
        {
            List<CLocalPurchaseOrderDetails> RecordsList = new List<CLocalPurchaseOrderDetails>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select tblLocalPurchaseOrderDetails.* from tblLocalPurchaseOrderDetails INNER JOIN tblItems ON (tblLocalPurchaseOrderDetails.ItemGuid = tblItems.TableRowGuid) WHERE PurchaseOrderGuid=@PurchaseOrderGuid ORDER BY tblItems.BrandName";
            command.CommandType = CommandType.Text;
            command.Connection = connection;
           
            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CLocalPurchaseOrderDetails objCPurchaseOrderDetails = new CLocalPurchaseOrderDetails();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Id = 0;
                    else
                        objCPurchaseOrderDetails.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Purchaseorderguid = string.Empty;
                    else
                        objCPurchaseOrderDetails.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Itemguid = string.Empty;
                    else
                        objCPurchaseOrderDetails.Itemguid = (string)dr["ItemGuid"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Quantity = 0;
                    else
                        objCPurchaseOrderDetails.Quantity = (decimal)dr["Quantity"];
                    if (dr["PricePerUnit"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Priceperunit = 0;
                    else
                        objCPurchaseOrderDetails.Priceperunit = (decimal)dr["PricePerUnit"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCPurchaseOrderDetails.Tablerowguid = string.Empty;
                    else
                        objCPurchaseOrderDetails.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCPurchaseOrderDetails);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderDetails::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblLocalPurchaseOrderDetails] WHERE Id = @Id";
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
                throw new Exception("CLocalPurchaseOrderDetails::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblLocalPurchaseOrderDetails] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CLocalPurchaseOrderDetails::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public static decimal GetPurchasedQuantity(string Purchaseorderguid, string Itemguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT ISNULL(Quantity,0) AS Quantity FROM [dbo].[tblLocalPurchaseOrderDetails] WHERE PurchaseOrderGuid = @PurchaseOrderGuid AND ItemGuid = @ItemGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                connection.Open();
                temp = command.ExecuteScalar();
                if (temp != null)
                    return (decimal)temp;
                else
                    return 0;
                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CLocalPurchaseOrderDetails::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }



}
