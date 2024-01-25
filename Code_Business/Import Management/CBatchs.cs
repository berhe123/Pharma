//
// ...
// Wizard generated code
// Date: 7/26/2009 10:01:36 AM
// Class: CBatchs
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
    class CBatchs
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CBatchs()
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

        string _BatchNumber;
        public string Batchnumber
        {
            get { return _BatchNumber; }
            set { _BatchNumber = value; }
        }

        string _ItemGuid;
        public string Itemguid
        {
            get { return _ItemGuid; }
            set { _ItemGuid = value; }
        }

        string _ItemDescription;
        public string ItemDescription
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

        decimal _FreightPayments;
        public decimal Freightpayments
        {
            get { return _FreightPayments; }
            set { _FreightPayments = value; }
        }

        decimal _InsurancePayments;
        public decimal Insurancepayments
        {
            get { return _InsurancePayments; }
            set { _InsurancePayments = value; }
        }

        decimal _BankPayments;
        public decimal Bankpayments
        {
            get { return _BankPayments; }
            set { _BankPayments = value; }
        }

        decimal _OtherPayments;
        public decimal Otherpayments
        {
            get { return _OtherPayments; }
            set { _OtherPayments = value; }
        }

        decimal _SuggestedSalePrice;
        public decimal Suggestedsaleprice
        {
            get { return _SuggestedSalePrice; }
            set { _SuggestedSalePrice = value; }
        }

        decimal _SalePrice;
        public decimal Saleprice
        {
            get { return _SalePrice; }
            set { _SalePrice = value; }
        }

        DateTime _ManufacturedDate;
        public DateTime Manufactureddate
        {
            get { return _ManufacturedDate; }
            set { _ManufacturedDate = value; }
        }

        DateTime _ExpiryDate;
        public DateTime Expirydate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }

        decimal _ExchangeRate;
        public decimal ExchangeRate
        {
            get { return _ExchangeRate; }
            set { _ExchangeRate = value; }
        }

        decimal _ProfitMargin;
        public decimal ProfitMargin
        {
            get { return _ProfitMargin; }
            set { _ProfitMargin = value; }
        }

        int _PurchaseOrderType;
        public int PurchaseOrderType
        {
            get { return _PurchaseOrderType; }
            set { _PurchaseOrderType = value; }
        }

        string _ShelfLife;
        public string Shelflife
        {
            get { return _ShelfLife; }
            set { _ShelfLife = value; }
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
            command.CommandText = "Select * from tblBatchs where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblBatchs");
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
                    if (dTable.Rows[0]["BatchNumber"].Equals(DBNull.Value))
                        _BatchNumber = string.Empty;
                    else
                        _BatchNumber = (string)dTable.Rows[0]["BatchNumber"];
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
                    if (dTable.Rows[0]["FreightPayments"].Equals(DBNull.Value))
                        _FreightPayments = 0;
                    else
                        _FreightPayments = (decimal)dTable.Rows[0]["FreightPayments"];
                    if (dTable.Rows[0]["InsurancePayments"].Equals(DBNull.Value))
                        _InsurancePayments = 0;
                    else
                        _InsurancePayments = (decimal)dTable.Rows[0]["InsurancePayments"];
                    if (dTable.Rows[0]["BankPayments"].Equals(DBNull.Value))
                        _BankPayments = 0;
                    else
                        _BankPayments = (decimal)dTable.Rows[0]["BankPayments"];
                    if (dTable.Rows[0]["OtherPayments"].Equals(DBNull.Value))
                        _OtherPayments = 0;
                    else
                        _OtherPayments = (decimal)dTable.Rows[0]["OtherPayments"];
                    if (dTable.Rows[0]["SuggestedSalePrice"].Equals(DBNull.Value))
                        _SuggestedSalePrice = 0;
                    else
                        _SuggestedSalePrice = (decimal)dTable.Rows[0]["SuggestedSalePrice"];
                    if (dTable.Rows[0]["SalePrice"].Equals(DBNull.Value))
                        _SalePrice = 0;
                    else
                        _SalePrice = (decimal)dTable.Rows[0]["SalePrice"];
                    if (dTable.Rows[0]["ManufacturedDate"].Equals(DBNull.Value))
                        _ManufacturedDate = DateTime.MinValue;
                    else
                        _ManufacturedDate = (DateTime)dTable.Rows[0]["ManufacturedDate"];
                    if (dTable.Rows[0]["ExpiryDate"].Equals(DBNull.Value))
                        _ExpiryDate = DateTime.MinValue;
                    else
                        _ExpiryDate = (DateTime)dTable.Rows[0]["ExpiryDate"];
                    if (dTable.Rows[0]["ExchangeRate"].Equals(DBNull.Value))
                        _ExchangeRate = 0;
                    else
                        _ExchangeRate = (decimal)dTable.Rows[0]["ExchangeRate"];
                    if (dTable.Rows[0]["ProfitMargin"].Equals(DBNull.Value))
                        _ProfitMargin = 0;
                    else
                        _ProfitMargin = (decimal)dTable.Rows[0]["ProfitMargin"];
                    if (dTable.Rows[0]["PurchaseOrderType"].Equals(DBNull.Value))
                        _PurchaseOrderType = 0;
                    else
                        _PurchaseOrderType = (int)dTable.Rows[0]["PurchaseOrderType"];
                    if (dTable.Rows[0]["ShelfLife"].Equals(DBNull.Value))
                        _ShelfLife = string.Empty;
                    else
                        _ShelfLife = (string)dTable.Rows[0]["ShelfLife"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblBatchs";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblBatchs");
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
                throw new Exception("CBatchs::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblBatchs where PurchaseOrderGuid=@PurchaseOrderGuid";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblBatchs");
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
                throw new Exception("CBatchs::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblBatchs" +
                                   " (PurchaseOrderGuid, " +
                                   " BatchNumber, " +
                                   " ItemGuid, " +
                                   " Quantity, " +
                                   " PricePerUnit, " +
                                   " FreightPayments, " +
                                   " InsurancePayments, " +
                                   " BankPayments, " +
                                   " OtherPayments, " +
                                   " SuggestedSalePrice, " +
                                   " SalePrice, " +
                                   " ManufacturedDate, " +
                                   " ExpiryDate, " +
                                   " ExchangeRate, " +
                                   " ProfitMargin,PurchaseOrderType,ShelfLife)" +
                                   " Values (@PurchaseOrderGuid, " +
                                   " @BatchNumber, " +
                                   " @ItemGuid, " +
                                   " @Quantity, " +
                                   " @PricePerUnit, " +
                                   " @FreightPayments, " +
                                   " @InsurancePayments, " +
                                   " @BankPayments, " +
                                   " @OtherPayments, " +
                                   " @SuggestedSalePrice, " +
                                   " @SalePrice, " +
                                   " @ManufacturedDate, " +
                                   " @ExpiryDate, " +
                                   " @ExchangeRate, " +
                                   " @ProfitMargin,@PurchaseOrderType,@ShelfLife)" +
                                   " SELECT @Id=SCOPE_IDENTITY() ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@BatchNumber", _BatchNumber));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                command.Parameters.Add(new SqlParameter("@PricePerUnit", _PricePerUnit));
                command.Parameters.Add(new SqlParameter("@FreightPayments", _FreightPayments));
                command.Parameters.Add(new SqlParameter("@InsurancePayments", _InsurancePayments));
                command.Parameters.Add(new SqlParameter("@BankPayments", _BankPayments));
                command.Parameters.Add(new SqlParameter("@OtherPayments", _OtherPayments));
                command.Parameters.Add(new SqlParameter("@SuggestedSalePrice", _SuggestedSalePrice));
                command.Parameters.Add(new SqlParameter("@SalePrice", _SalePrice));
                if (_ManufacturedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ManufacturedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ManufacturedDate", _ManufacturedDate));
                if (_ExpiryDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ExpiryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ExpiryDate", _ExpiryDate));

                command.Parameters.Add(new SqlParameter("@ExchangeRate", _ExchangeRate));
                command.Parameters.Add(new SqlParameter("@ProfitMargin", _ProfitMargin));
                command.Parameters.Add(new SqlParameter("@PurchaseOrderType", _PurchaseOrderType));
                command.Parameters.Add(new SqlParameter("@ShelfLife", _ShelfLife));

                command.Parameters.Add(new SqlParameter("@Id", _Id));
                command.Parameters["@Id"].Direction = ParameterDirection.Output;


                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                _Id = (int)command.Parameters["@Id"].Value;
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblBatchs" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " BatchNumber = @BatchNumber, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " Quantity = @Quantity, " +
                                   " PricePerUnit = @PricePerUnit, " +
                                   " FreightPayments = @FreightPayments, " +
                                   " InsurancePayments = @InsurancePayments, " +
                                   " BankPayments = @BankPayments, " +
                                   " OtherPayments = @OtherPayments, " +
                                   " SuggestedSalePrice = @SuggestedSalePrice, " +
                                   " SalePrice = @SalePrice, " +
                                   " ManufacturedDate = @ManufacturedDate, " +
                                   " ExpiryDate = @ExpiryDate, " +
                                   " ExchangeRate = @ExchangeRate, " +
                                   " ProfitMargin = @ProfitMargin," +
                                   " PurchaseOrderType = @PurchaseOrderType," +
                                   " ShelfLife = @ShelfLife" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@BatchNumber", _BatchNumber));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));
                command.Parameters.Add(new SqlParameter("@PricePerUnit", _PricePerUnit));
                command.Parameters.Add(new SqlParameter("@FreightPayments", _FreightPayments));
                command.Parameters.Add(new SqlParameter("@InsurancePayments", _InsurancePayments));
                command.Parameters.Add(new SqlParameter("@BankPayments", _BankPayments));
                command.Parameters.Add(new SqlParameter("@OtherPayments", _OtherPayments));
                command.Parameters.Add(new SqlParameter("@SuggestedSalePrice", _SuggestedSalePrice));
                command.Parameters.Add(new SqlParameter("@SalePrice", _SalePrice));
                if (_ManufacturedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ManufacturedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ManufacturedDate", _ManufacturedDate));
                if (_ExpiryDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ExpiryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ExpiryDate", _ExpiryDate));

                command.Parameters.Add(new SqlParameter("@ExchangeRate", _ExchangeRate));
                command.Parameters.Add(new SqlParameter("@ProfitMargin", _ProfitMargin));
                command.Parameters.Add(new SqlParameter("@PurchaseOrderType", _PurchaseOrderType));
                command.Parameters.Add(new SqlParameter("@ShelfLife", _ShelfLife));

                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::Update::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool UpdateBachOnly()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Update tblBatchs" +
                                   " Set PurchaseOrderGuid = @PurchaseOrderGuid, " +
                                   " BatchNumber = @BatchNumber, " +
                                   " ItemGuid = @ItemGuid, " +
                                   " Quantity = @Quantity, " +
                                   " ManufacturedDate = @ManufacturedDate, " +
                                   " ExpiryDate = @ExpiryDate, " +
                                   " ShelfLife = @ShelfLife" +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@BatchNumber", _BatchNumber));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                command.Parameters.Add(new SqlParameter("@Quantity", _Quantity));

                if (_ManufacturedDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ManufacturedDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ManufacturedDate", _ManufacturedDate));
                if (_ExpiryDate == DateTime.MinValue)
                    command.Parameters.Add(new SqlParameter("@ExpiryDate", DBNull.Value));
                else
                    command.Parameters.Add(new SqlParameter("@ExpiryDate", _ExpiryDate));

                command.Parameters.Add(new SqlParameter("@ShelfLife", _ShelfLife));

                command.Parameters.Add(new SqlParameter("@Id", _Id));

                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblBatchs Where Id = @Id ";
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
                throw new Exception("CBatchs::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblBatchs] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND BatchNumber = @BatchNumber";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblBatchs] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND BatchNumber = @BatchNumber " +
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", _PurchaseOrderGuid));
                command.Parameters.Add(new SqlParameter("@BatchNumber", _BatchNumber));
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
                throw new Exception("CBatchs::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public bool QuantityIsGreatherThanPurchaseOrder(bool bNew)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            decimal decQuantityOnPurchase = CLocalPurchaseOrderDetails.GetPurchasedQuantity(_PurchaseOrderGuid, _ItemGuid);

            if (bNew)
                command.CommandText = "SELECT ISNULL(Quantity,0) AS Quantity FROM [dbo].[tblBatchs] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
                                       " AND ItemGuid = @ItemGuid";
            else
                command.CommandText = "SELECT ISNULL(Quantity,0) AS Quantity FROM [dbo].[tblBatchs] WHERE " +
                                       " PurchaseOrderGuid = @PurchaseOrderGuid " +
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
                decimal decAlreadySaved = temp != null ? (decimal)temp : 0;
                if ((decAlreadySaved + _Quantity) > decQuantityOnPurchase)
                    return false;
                else
                    return true;


                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CBatchs> GetList()
        {
            List<CBatchs> RecordsList = new List<CBatchs>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            //command.CommandText = "Select * from tblBatchs";
            command.CommandText =  " SELECT   tblBatchs.Id, tblBatchs.TableRowGuid, tblBatchs.BatchNumber, tblBatchs.ItemGuid, tblItems.BrandName, tblItems.GenericName, tblItems.Measurement,  ";
            command.CommandText += "                tblItems.Strength, tblItems.DosageFormGuid, tblUnitOfMeasurements.Name, tblBatchs.Quantity, tblBatchs.PricePerUnit,  ";
            command.CommandText += "                tblBatchs.FreightPayments, tblBatchs.InsurancePayments, tblBatchs.BankPayments, tblBatchs.OtherPayments, ";
            command.CommandText += "                tblBatchs.ExchangeRate, tblBatchs.ProfitMargin, tblBatchs.ShelfLife,";
            command.CommandText += "                tblBatchs.SuggestedSalePrice, tblBatchs.SalePrice, tblBatchs.ManufacturedDate, tblBatchs.ExpiryDate, tblBatchs.PurchaseOrderGuid,  ";
            command.CommandText += "                tblItems.BrandName AS ItemDescription ";
            command.CommandText += " FROM           tblBatchs INNER JOIN ";
            command.CommandText += "                tblItems ON tblBatchs.ItemGuid = tblItems.TableRowGuid  LEFT OUTER JOIN  ";
            command.CommandText += "                tblUnitOfMeasurements ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CBatchs objCBatchs = new CBatchs();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCBatchs.Id = 0;
                    else
                        objCBatchs.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCBatchs.Purchaseorderguid = string.Empty;
                    else
                        objCBatchs.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCBatchs.Batchnumber = string.Empty;
                    else
                        objCBatchs.Batchnumber = (string)dr["BatchNumber"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCBatchs.Itemguid = string.Empty;
                    else
                        objCBatchs.Itemguid = (string)dr["ItemGuid"];
                    if (dr["ItemDescription"].Equals(DBNull.Value))
                        objCBatchs.ItemDescription = string.Empty;
                    else
                        objCBatchs.ItemDescription = (string)dr["ItemDescription"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCBatchs.Quantity = 0;
                    else
                        objCBatchs.Quantity = (decimal)dr["Quantity"];
                    if (dr["PricePerUnit"].Equals(DBNull.Value))
                        objCBatchs.Priceperunit = 0;
                    else
                        objCBatchs.Priceperunit = (decimal)dr["PricePerUnit"];
                    if (dr["FreightPayments"].Equals(DBNull.Value))
                        objCBatchs.Freightpayments = 0;
                    else
                        objCBatchs.Freightpayments = (decimal)dr["FreightPayments"];
                    if (dr["InsurancePayments"].Equals(DBNull.Value))
                        objCBatchs.Insurancepayments = 0;
                    else
                        objCBatchs.Insurancepayments = (decimal)dr["InsurancePayments"];
                    if (dr["BankPayments"].Equals(DBNull.Value))
                        objCBatchs.Bankpayments = 0;
                    else
                        objCBatchs.Bankpayments = (decimal)dr["BankPayments"];
                    if (dr["OtherPayments"].Equals(DBNull.Value))
                        objCBatchs.Otherpayments = 0;
                    else
                        objCBatchs.Otherpayments = (decimal)dr["OtherPayments"];
                    if (dr["SuggestedSalePrice"].Equals(DBNull.Value))
                        objCBatchs.Suggestedsaleprice = 0;
                    else
                        objCBatchs.Suggestedsaleprice = (decimal)dr["SuggestedSalePrice"];
                    if (dr["SalePrice"].Equals(DBNull.Value))
                        objCBatchs.Saleprice = 0;
                    else
                        objCBatchs.Saleprice = (decimal)dr["SalePrice"];
                    if (dr["ManufacturedDate"].Equals(DBNull.Value))
                        objCBatchs.Manufactureddate = DateTime.MinValue;
                    else
                        objCBatchs.Manufactureddate = (DateTime)dr["ManufacturedDate"];
                    if (dr["ExpiryDate"].Equals(DBNull.Value))
                        objCBatchs.Expirydate = DateTime.MinValue;
                    else
                        objCBatchs.Expirydate = (DateTime)dr["ExpiryDate"];
                    if (dr["ExchangeRate"].Equals(DBNull.Value))
                        objCBatchs.ExchangeRate = 0;
                    else
                        objCBatchs.ExchangeRate = (decimal)dr["ExchangeRate"];
                    if (dr["ProfitMargin"].Equals(DBNull.Value))
                        objCBatchs.ProfitMargin = 0;
                    else
                        objCBatchs.ProfitMargin = (decimal)dr["ProfitMargin"];
                    if (dr["ShelfLife"].Equals(DBNull.Value))
                        objCBatchs.Shelflife = string.Empty;
                    else
                        objCBatchs.Shelflife = (string)dr["ShelfLife"];

                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCBatchs.Tablerowguid = string.Empty;
                    else
                        objCBatchs.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCBatchs);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CBatchs> GetList(string ItemGuid)
        {
            List<CBatchs> RecordsList = new List<CBatchs>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            //command.CommandText = "Select * from tblBatchs";
            command.CommandText = "SELECT   tblBatchs.Id, tblBatchs.TableRowGuid, tblBatchs.BatchNumber, tblBatchs.ItemGuid, tblItems.BrandName, tblItems.GenericName, tblItems.Measurement,  ";
            command.CommandText += "                tblItems.Strength, tblItems.DosageFormGuid, tblBatchs.Quantity, tblBatchs.PricePerUnit,  ";
            command.CommandText += "                tblBatchs.FreightPayments, tblBatchs.InsurancePayments, tblBatchs.BankPayments, tblBatchs.OtherPayments, ";
            command.CommandText += "                tblBatchs.ExchangeRate, tblBatchs.ProfitMargin,  tblBatchs.ShelfLife,";
            command.CommandText += "                tblBatchs.SuggestedSalePrice, tblBatchs.SalePrice, tblBatchs.ManufacturedDate, tblBatchs.ExpiryDate, tblBatchs.PurchaseOrderGuid,  ";
            command.CommandText += "                tblItems.BrandName AS ItemDescription ";
            command.CommandText += "FROM     tblBatchs INNER JOIN ";
            command.CommandText += "                tblItems ON tblBatchs.ItemGuid = tblItems.TableRowGuid ";
            command.CommandText += "WHERE    tblItems.TableRowGuid=@ItemGuid";

            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.Parameters.Add(new SqlParameter("@ItemGuid", ItemGuid));

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CBatchs objCBatchs = new CBatchs();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCBatchs.Id = 0;
                    else
                        objCBatchs.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCBatchs.Purchaseorderguid = string.Empty;
                    else
                        objCBatchs.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCBatchs.Batchnumber = string.Empty;
                    else
                        objCBatchs.Batchnumber = (string)dr["BatchNumber"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCBatchs.Itemguid = string.Empty;
                    else
                        objCBatchs.Itemguid = (string)dr["ItemGuid"];
                    if (dr["ItemDescription"].Equals(DBNull.Value))
                        objCBatchs.ItemDescription = string.Empty;
                    else
                        objCBatchs.ItemDescription = (string)dr["ItemDescription"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCBatchs.Quantity = 0;
                    else
                        objCBatchs.Quantity = (decimal)dr["Quantity"];
                    if (dr["PricePerUnit"].Equals(DBNull.Value))
                        objCBatchs.Priceperunit = 0;
                    else
                        objCBatchs.Priceperunit = (decimal)dr["PricePerUnit"];
                    if (dr["FreightPayments"].Equals(DBNull.Value))
                        objCBatchs.Freightpayments = 0;
                    else
                        objCBatchs.Freightpayments = (decimal)dr["FreightPayments"];
                    if (dr["InsurancePayments"].Equals(DBNull.Value))
                        objCBatchs.Insurancepayments = 0;
                    else
                        objCBatchs.Insurancepayments = (decimal)dr["InsurancePayments"];
                    if (dr["BankPayments"].Equals(DBNull.Value))
                        objCBatchs.Bankpayments = 0;
                    else
                        objCBatchs.Bankpayments = (decimal)dr["BankPayments"];
                    if (dr["OtherPayments"].Equals(DBNull.Value))
                        objCBatchs.Otherpayments = 0;
                    else
                        objCBatchs.Otherpayments = (decimal)dr["OtherPayments"];
                    if (dr["SuggestedSalePrice"].Equals(DBNull.Value))
                        objCBatchs.Suggestedsaleprice = 0;
                    else
                        objCBatchs.Suggestedsaleprice = (decimal)dr["SuggestedSalePrice"];
                    if (dr["SalePrice"].Equals(DBNull.Value))
                        objCBatchs.Saleprice = 0;
                    else
                        objCBatchs.Saleprice = (decimal)dr["SalePrice"];
                    if (dr["ManufacturedDate"].Equals(DBNull.Value))
                        objCBatchs.Manufactureddate = DateTime.MinValue;
                    else
                        objCBatchs.Manufactureddate = (DateTime)dr["ManufacturedDate"];
                    if (dr["ExpiryDate"].Equals(DBNull.Value))
                        objCBatchs.Expirydate = DateTime.MinValue;
                    else
                        objCBatchs.Expirydate = (DateTime)dr["ExpiryDate"];
                    if (dr["ExchangeRate"].Equals(DBNull.Value))
                        objCBatchs.ExchangeRate = 0;
                    else
                        objCBatchs.ExchangeRate = (decimal)dr["ExchangeRate"];
                    if (dr["ProfitMargin"].Equals(DBNull.Value))
                        objCBatchs.ProfitMargin = 0;
                    else
                        objCBatchs.ProfitMargin = (decimal)dr["ProfitMargin"];
                    if (dr["ShelfLife"].Equals(DBNull.Value))
                        objCBatchs.Shelflife = string.Empty;
                    else
                        objCBatchs.Shelflife = (string)dr["ShelfLife"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCBatchs.Tablerowguid = string.Empty;
                    else
                        objCBatchs.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCBatchs);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CBatchs> GetList(string Purchaseorderguid, int PurchaseOrderType)
        {
            List<CBatchs> RecordsList = new List<CBatchs>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            //command.CommandText = "Select * from tblBatchs where PurchaseOrderId=@PurchaseOrderId";
            command.CommandText = " SELECT   tblBatchs.Id, tblBatchs.TableRowGuid, tblBatchs.BatchNumber, tblBatchs.ItemGuid, tblItems.BrandName, tblItems.GenericName, tblItems.Measurement,  ";
            command.CommandText += "                tblItems.Strength, tblItems.DosageFormGuid, tblUnitOfMeasurements.Name, tblBatchs.Quantity, tblBatchs.PricePerUnit,  ";
            command.CommandText += "                tblBatchs.FreightPayments, tblBatchs.InsurancePayments, tblBatchs.BankPayments, tblBatchs.OtherPayments, ";
            command.CommandText += "                tblBatchs.ExchangeRate, tblBatchs.ProfitMargin, tblBatchs.ShelfLife,";
            command.CommandText += "                tblBatchs.SuggestedSalePrice, tblBatchs.SalePrice, tblBatchs.ManufacturedDate, tblBatchs.ExpiryDate, tblBatchs.PurchaseOrderGuid,  ";

            command.CommandText += " (tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName) AS ItemDescription from tblitems";
            command.CommandText += " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
            command.CommandText += " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
            command.CommandText += " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
            command.CommandText += " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
            command.CommandText += " inner join tblBatchs on tblBatchs.ItemGuid =tblItems.TableRowGuid";
            
            
            
            
            
            
            
            
           
           
            command.CommandText += "                 LEFT OUTER JOIN";
            command.CommandText += "                tblUnitOfMeasurements ON tblItems.UnitOfMeasurementGuid = tblUnitOfMeasurements.TableRowGuid ";
            //command.CommandText += "                tblDosageForms ON tblItems.DosageFormGuid = tblDosageForms.TableRowGuid ";
            command.CommandText += " where PurchaseOrderGuid=@PurchaseOrderGuid ";
            command.CommandText += " ORDER BY  tblItems.BrandName";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@PurchaseOrderType", PurchaseOrderType));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CBatchs objCBatchs = new CBatchs();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCBatchs.Id = 0;
                    else
                        objCBatchs.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCBatchs.Purchaseorderguid = string.Empty;
                    else
                        objCBatchs.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCBatchs.Batchnumber = string.Empty;
                    else
                        objCBatchs.Batchnumber = (string)dr["BatchNumber"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCBatchs.Itemguid = string.Empty;
                    else
                        objCBatchs.Itemguid = (string)dr["ItemGuid"];
                    if (dr["ItemDescription"].Equals(DBNull.Value))
                        objCBatchs.ItemDescription = string.Empty;
                    else
                        objCBatchs.ItemDescription = (string)dr["ItemDescription"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCBatchs.Quantity = 0;
                    else
                        objCBatchs.Quantity = (decimal)dr["Quantity"];
                    if (dr["PricePerUnit"].Equals(DBNull.Value))
                        objCBatchs.Priceperunit = 0;
                    else
                        objCBatchs.Priceperunit = (decimal)dr["PricePerUnit"];
                    if (dr["FreightPayments"].Equals(DBNull.Value))
                        objCBatchs.Freightpayments = 0;
                    else
                        objCBatchs.Freightpayments = (decimal)dr["FreightPayments"];
                    if (dr["InsurancePayments"].Equals(DBNull.Value))
                        objCBatchs.Insurancepayments = 0;
                    else
                        objCBatchs.Insurancepayments = (decimal)dr["InsurancePayments"];
                    if (dr["BankPayments"].Equals(DBNull.Value))
                        objCBatchs.Bankpayments = 0;
                    else
                        objCBatchs.Bankpayments = (decimal)dr["BankPayments"];
                    if (dr["OtherPayments"].Equals(DBNull.Value))
                        objCBatchs.Otherpayments = 0;
                    else
                        objCBatchs.Otherpayments = (decimal)dr["OtherPayments"];
                    if (dr["SuggestedSalePrice"].Equals(DBNull.Value))
                        objCBatchs.Suggestedsaleprice = 0;
                    else
                        objCBatchs.Suggestedsaleprice = (decimal)dr["SuggestedSalePrice"];
                    if (dr["SalePrice"].Equals(DBNull.Value))
                        objCBatchs.Saleprice = 0;
                    else
                        objCBatchs.Saleprice = (decimal)dr["SalePrice"];
                    if (dr["ManufacturedDate"].Equals(DBNull.Value))
                        objCBatchs.Manufactureddate = DateTime.MinValue;
                    else
                        objCBatchs.Manufactureddate = (DateTime)dr["ManufacturedDate"];
                    if (dr["ExpiryDate"].Equals(DBNull.Value))
                        objCBatchs.Expirydate = DateTime.MinValue;
                    else
                        objCBatchs.Expirydate = (DateTime)dr["ExpiryDate"];
                    if (dr["ExchangeRate"].Equals(DBNull.Value))
                        objCBatchs.ExchangeRate = 0;
                    else
                        objCBatchs.ExchangeRate = (decimal)dr["ExchangeRate"];
                    if (dr["ProfitMargin"].Equals(DBNull.Value))
                        objCBatchs.ProfitMargin = 0;
                    else
                        objCBatchs.ProfitMargin = (decimal)dr["ProfitMargin"];
                    if (dr["ShelfLife"].Equals(DBNull.Value))
                        objCBatchs.Shelflife = string.Empty;
                    else
                        objCBatchs.Shelflife = (string)dr["ShelfLife"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCBatchs.Tablerowguid = string.Empty;
                    else
                        objCBatchs.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCBatchs);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CBatchs> GetList(string Purchaseorderguid, string Itemguid, int PurchaseOrderType)
        {
            List<CBatchs> RecordsList = new List<CBatchs>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblBatchs where PurchaseOrderGuid=@PurchaseOrderGuid and ItemGuid=@ItemGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@PurchaseOrderGuid", Purchaseorderguid));
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                //command.Parameters.Add(new SqlParameter("@PurchaseOrderType", PurchaseOrderType));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CBatchs objCBatchs = new CBatchs();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCBatchs.Id = 0;
                    else
                        objCBatchs.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCBatchs.Purchaseorderguid = string.Empty;
                    else
                        objCBatchs.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCBatchs.Batchnumber = string.Empty;
                    else
                        objCBatchs.Batchnumber = (string)dr["BatchNumber"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCBatchs.Itemguid = string.Empty;
                    else
                        objCBatchs.Itemguid = (string)dr["ItemGuid"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCBatchs.Quantity = 0;
                    else
                        objCBatchs.Quantity = (decimal)dr["Quantity"];
                    if (dr["PricePerUnit"].Equals(DBNull.Value))
                        objCBatchs.Priceperunit = 0;
                    else
                        objCBatchs.Priceperunit = (decimal)dr["PricePerUnit"];
                    if (dr["FreightPayments"].Equals(DBNull.Value))
                        objCBatchs.Freightpayments = 0;
                    else
                        objCBatchs.Freightpayments = (decimal)dr["FreightPayments"];
                    if (dr["InsurancePayments"].Equals(DBNull.Value))
                        objCBatchs.Insurancepayments = 0;
                    else
                        objCBatchs.Insurancepayments = (decimal)dr["InsurancePayments"];
                    if (dr["BankPayments"].Equals(DBNull.Value))
                        objCBatchs.Bankpayments = 0;
                    else
                        objCBatchs.Bankpayments = (decimal)dr["BankPayments"];
                    if (dr["OtherPayments"].Equals(DBNull.Value))
                        objCBatchs.Otherpayments = 0;
                    else
                        objCBatchs.Otherpayments = (decimal)dr["OtherPayments"];
                    if (dr["SuggestedSalePrice"].Equals(DBNull.Value))
                        objCBatchs.Suggestedsaleprice = 0;
                    else
                        objCBatchs.Suggestedsaleprice = (decimal)dr["SuggestedSalePrice"];
                    if (dr["SalePrice"].Equals(DBNull.Value))
                        objCBatchs.Saleprice = 0;
                    else
                        objCBatchs.Saleprice = (decimal)dr["SalePrice"];
                    if (dr["ManufacturedDate"].Equals(DBNull.Value))
                        objCBatchs.Manufactureddate = DateTime.MinValue;
                    else
                        objCBatchs.Manufactureddate = (DateTime)dr["ManufacturedDate"];
                    if (dr["ExpiryDate"].Equals(DBNull.Value))
                        objCBatchs.Expirydate = DateTime.MinValue;
                    else
                        objCBatchs.Expirydate = (DateTime)dr["ExpiryDate"];
                    if (dr["ExchangeRate"].Equals(DBNull.Value))
                        objCBatchs.ExchangeRate = 0;
                    else
                        objCBatchs.ExchangeRate = (decimal)dr["ExchangeRate"];
                    if (dr["ProfitMargin"].Equals(DBNull.Value))
                        objCBatchs.ProfitMargin = 0;
                    else
                        objCBatchs.ProfitMargin = (decimal)dr["ProfitMargin"];
                    if (dr["ShelfLife"].Equals(DBNull.Value))
                        objCBatchs.Shelflife = string.Empty;
                    else
                        objCBatchs.Shelflife = (string)dr["ShelfLife"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCBatchs.Tablerowguid = string.Empty;
                    else
                        objCBatchs.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCBatchs);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CBatchs> GetListByItem(string Itemguid)
        {
            List<CBatchs> RecordsList = new List<CBatchs>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblBatchs where ItemGuid=@ItemGuid ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CBatchs objCBatchs = new CBatchs();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCBatchs.Id = 0;
                    else
                        objCBatchs.Id = (int)dr["Id"];
                    if (dr["PurchaseOrderGuid"].Equals(DBNull.Value))
                        objCBatchs.Purchaseorderguid = string.Empty;
                    else
                        objCBatchs.Purchaseorderguid = (string)dr["PurchaseOrderGuid"];
                    if (dr["BatchNumber"].Equals(DBNull.Value))
                        objCBatchs.Batchnumber = string.Empty;
                    else
                        objCBatchs.Batchnumber = (string)dr["BatchNumber"];
                    if (dr["ItemGuid"].Equals(DBNull.Value))
                        objCBatchs.Itemguid = string.Empty;
                    else
                        objCBatchs.Itemguid = (string)dr["ItemGuid"];
                    if (dr["Quantity"].Equals(DBNull.Value))
                        objCBatchs.Quantity = 0;
                    else
                        objCBatchs.Quantity = (decimal)dr["Quantity"];
                    if (dr["PricePerUnit"].Equals(DBNull.Value))
                        objCBatchs.Priceperunit = 0;
                    else
                        objCBatchs.Priceperunit = (decimal)dr["PricePerUnit"];
                    if (dr["FreightPayments"].Equals(DBNull.Value))
                        objCBatchs.Freightpayments = 0;
                    else
                        objCBatchs.Freightpayments = (decimal)dr["FreightPayments"];
                    if (dr["InsurancePayments"].Equals(DBNull.Value))
                        objCBatchs.Insurancepayments = 0;
                    else
                        objCBatchs.Insurancepayments = (decimal)dr["InsurancePayments"];
                    if (dr["BankPayments"].Equals(DBNull.Value))
                        objCBatchs.Bankpayments = 0;
                    else
                        objCBatchs.Bankpayments = (decimal)dr["BankPayments"];
                    if (dr["OtherPayments"].Equals(DBNull.Value))
                        objCBatchs.Otherpayments = 0;
                    else
                        objCBatchs.Otherpayments = (decimal)dr["OtherPayments"];
                    if (dr["SuggestedSalePrice"].Equals(DBNull.Value))
                        objCBatchs.Suggestedsaleprice = 0;
                    else
                        objCBatchs.Suggestedsaleprice = (decimal)dr["SuggestedSalePrice"];
                    if (dr["SalePrice"].Equals(DBNull.Value))
                        objCBatchs.Saleprice = 0;
                    else
                        objCBatchs.Saleprice = (decimal)dr["SalePrice"];
                    if (dr["ManufacturedDate"].Equals(DBNull.Value))
                        objCBatchs.Manufactureddate = DateTime.MinValue;
                    else
                        objCBatchs.Manufactureddate = (DateTime)dr["ManufacturedDate"];
                    if (dr["ExpiryDate"].Equals(DBNull.Value))
                        objCBatchs.Expirydate = DateTime.MinValue;
                    else
                        objCBatchs.Expirydate = (DateTime)dr["ExpiryDate"];
                    if (dr["ExchangeRate"].Equals(DBNull.Value))
                        objCBatchs.ExchangeRate = 0;
                    else
                        objCBatchs.ExchangeRate = (decimal)dr["ExchangeRate"];
                    if (dr["ProfitMargin"].Equals(DBNull.Value))
                        objCBatchs.ProfitMargin = 0;
                    else
                        objCBatchs.ProfitMargin = (decimal)dr["ProfitMargin"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCBatchs.Tablerowguid = string.Empty;
                    else
                        objCBatchs.Tablerowguid = (string)dr["TableRowGuid"];

                    RecordsList.Add(objCBatchs);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CBatchs::GetList::Error! " + ex.Message, ex);
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

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblBatchs] WHERE Id = @Id";
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
                throw new Exception("CBatchs::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblBatchs] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CBatchs::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}
