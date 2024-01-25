//
// ...
// Wizard generated code
// Date: 8/20/2009 10:12:53 AM
// Class: CItems
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
    class CItems
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {
                return Pharma.Properties.Settings.Default.ConnectionString;
            }
        }

        public CItems()
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

        string _CategoryGuid;
        public string Categoryguid
        {
            get { return _CategoryGuid; }
            set { _CategoryGuid = value; }
        }

        string _ProductGuid;
        public string Productguid
        {
            get { return _ProductGuid; }
            set { _ProductGuid = value; }
        }

        string _ManufacturerGuid;
        public string Manufacturerguid
        {
            get { return _ManufacturerGuid; }
            set { _ManufacturerGuid = value; }
        }

        string _BrandName;
        public string Brandname
        {
            get { return _BrandName; }
            set { _BrandName = value; }
        }

        string _GenericName;
        public string Genericname
        {
            get { return _GenericName; }
            set { _GenericName = value; }
        }

        string _Measurement;
        public string Measurement
        {
            get { return _Measurement; }
            set { _Measurement = value; }
        }

        string _SamplePresentation;
        public string Samplepresentation
        {
            get { return _SamplePresentation; }
            set { _SamplePresentation = value; }
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

        string _ShelfLife;
        public string Shelflife
        {
            get { return _ShelfLife; }
            set { _ShelfLife = value; }
        }

        decimal _ReorderLevel;
        public decimal Reorderlevel
        {
            get { return _ReorderLevel; }
            set { _ReorderLevel = value; }
        }

        string _SellableBactchGuid;
        public string Sellablebactchguid
        {
            get { return _SellableBactchGuid; }
            set { _SellableBactchGuid = value; }
        }

        decimal _ProfitMargin;
        public decimal ProfitMargin
        {
            get { return _ProfitMargin; }
            set { _ProfitMargin = value; }
        }

        string _LevelGuid;
        public string Levelguid
        {
            get { return _LevelGuid; }
            set { _LevelGuid = value; }
        }

        bool _IsVATApplicable;
        public bool IsVATApplicable
        {
            get { return _IsVATApplicable; }
            set { _IsVATApplicable = value; }
        }

        string _ItemCode;
        public string Itemcode
        {
            get { return _ItemCode; }
            set { _ItemCode = value; }
        }
        
        string _TableRowGuid;
        public string Tablerowguid
        {
            get { return _TableRowGuid; }
            set { _TableRowGuid = value; }
        }
        string _MakeOrganization;
        public string MakeOrganization
        {
            get { return _MakeOrganization; }
            set { _MakeOrganization = value; }
        }
        string _Year;
        public string Year
        {
            get { return _Year; }
            set { _Year = value; }
        }
        string _Model;
        public string Model
        {
            get { return _Model; }
            set { _Model = value; }
        }
        string _EngineType;
        public string EngineType
        {
            get { return _EngineType; }
            set { _EngineType = value; }
        }


        byte [] _photo;
        public byte[] photo
        {
            get { return _photo; }
            set { _photo = value; }
        }




        #endregion
        
        public DataTable GetRecord()
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblItems where Id=@Id";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblItems");
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
                    if (dTable.Rows[0]["CategoryGuid"].Equals(DBNull.Value))
                        _CategoryGuid = string.Empty;
                    else
                        _CategoryGuid = (string)dTable.Rows[0]["CategoryGuid"];
                    if (dTable.Rows[0]["ProductGuid"].Equals(DBNull.Value))
                        _ProductGuid = string.Empty;
                    else
                        _ProductGuid = (string)dTable.Rows[0]["ProductGuid"];
                    if (dTable.Rows[0]["ManufacturerGuid"].Equals(DBNull.Value))
                        _ManufacturerGuid = string.Empty;
                    else
                        _ManufacturerGuid = (string)dTable.Rows[0]["ManufacturerGuid"];
                    if (dTable.Rows[0]["BrandName"].Equals(DBNull.Value))
                        _BrandName = string.Empty;
                    else
                        _BrandName = (string)dTable.Rows[0]["BrandName"];
                    if (dTable.Rows[0]["GenericName"].Equals(DBNull.Value))
                        _GenericName = string.Empty;
                    else
                        _GenericName = (string)dTable.Rows[0]["GenericName"];
                    
                    if (dTable.Rows[0]["Measurement"].Equals(DBNull.Value))
                        _Measurement = string.Empty;
                    else
                        _Measurement = (string)dTable.Rows[0]["Measurement"];
                    if (dTable.Rows[0]["SamplePresentation"].Equals(DBNull.Value))
                        _SamplePresentation = string.Empty;
                    else
                        _SamplePresentation = (string)dTable.Rows[0]["SamplePresentation"];
                    if (dTable.Rows[0]["Strength"].Equals(DBNull.Value))
                        _Strength = string.Empty;
                    else
                        _Strength = (string)dTable.Rows[0]["Strength"];
                    if (dTable.Rows[0]["DosageFormGuid"].Equals(DBNull.Value))
                        _DosageFormGuid = string.Empty;
                    else
                        _DosageFormGuid = (string)dTable.Rows[0]["DosageFormGuid"];
                    if (dTable.Rows[0]["ShelfLife"].Equals(DBNull.Value))
                        _ShelfLife = string.Empty;
                    else
                        _ShelfLife = (string)dTable.Rows[0]["ShelfLife"];
                    if (dTable.Rows[0]["ReorderLevel"].Equals(DBNull.Value))
                        _ReorderLevel = 0;
                    else
                        _ReorderLevel = (decimal)dTable.Rows[0]["ReorderLevel"];
                    if (dTable.Rows[0]["SellableBactchGuid"].Equals(DBNull.Value))
                        _SellableBactchGuid = string.Empty;
                    else
                        _SellableBactchGuid = (string)dTable.Rows[0]["SellableBactchGuid"];
                    if (dTable.Rows[0]["ProfitMargin"].Equals(DBNull.Value))
                        _ProfitMargin = 0;
                    else
                        _ProfitMargin = (decimal)dTable.Rows[0]["ProfitMargin"];
                    if (dTable.Rows[0]["LevelGuid"].Equals(DBNull.Value))
                        _LevelGuid = string.Empty;
                    else
                        _LevelGuid = (string)dTable.Rows[0]["LevelGuid"];
                    if (dTable.Rows[0]["IsVATApplicable"].Equals(DBNull.Value))
                        _IsVATApplicable = false;
                    else
                        _IsVATApplicable = (bool)dTable.Rows[0]["IsVATApplicable"];                    
                    if (dTable.Rows[0]["ItemCode"].Equals(DBNull.Value))
                        _ItemCode = string.Empty;
                    else
                        _ItemCode = (string)dTable.Rows[0]["ItemCode"];
                    if (dTable.Rows[0]["TableRowGuid"].Equals(DBNull.Value))
                        _TableRowGuid = string.Empty;
                    else
                        _TableRowGuid = (string)dTable.Rows[0]["TableRowGuid"];
                    if (dTable.Rows[0]["MakeOrganizationGuid"].Equals(DBNull.Value))
                        _MakeOrganization = string.Empty;
                    else
                        _MakeOrganization = (string)dTable.Rows[0]["MakeOrganizationGuid"];
                    if (dTable.Rows[0]["YearGuid"].Equals(DBNull.Value))
                        _Year = string.Empty;
                    else
                        _Year = (string)dTable.Rows[0]["YearGuid"];

                    if (dTable.Rows[0]["ModelGuid"].Equals(DBNull.Value))
                        _Model = string.Empty;
                    else
                        _Model = (string)dTable.Rows[0]["ModelGuid"];

                    if (dTable.Rows[0]["EngineTypeGuid"].Equals(DBNull.Value))
                        _EngineType = string.Empty;
                    else
                        _EngineType = (string)dTable.Rows[0]["EngineTypeGuid"];
                }

                return dTable;
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetRecord::Error! " + ex.Message, ex);
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
            command.CommandText = "Select * from tblItems";
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("tblItems");
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
                throw new Exception("CItems::GetRecords::Error! " + ex.Message, ex);
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
            command.CommandText = "Insert Into tblItems" +
                                   " (MakeOrganizationGuid, " +
                                   " YearGuid, " +
                                   " ModelGuid, " +
                                   " EngineTypeGuid, " +
                                   " ProductGuid, " +
                                   " ManufacturerGuid, " +
                                   " BrandName, " +
                                   " GenericName, " +
                                   " ItemCode, " +                                 
                                   " Measurement, " +
                                   " SamplePresentation, " +
                                   " Strength, " +
                                   " DosageFormGuid, " +
                                   " ShelfLife, " +
                                   " ReorderLevel, " +
                                   " ProfitMargin, " +
                                   " SellableBactchGuid, " +
                                   " Photo , " +
                                   " LevelGuid,IsVATApplicable,UserId,ComputerName,EventSource)" +
                                   " Values (@MakeOrganizationGuid, " +
                                   " @YearGuid, " +
                                   " @ModelGuid, " +
                                   " @EngineTypeGuid, " +
                                   " @ProductGuid, " +
                                   " @ManufacturerGuid, " +
                                   " @BrandName, " +
                                  
                                   " @GenericName, " +
                                   " @ItemCode, " +
                                   
                                   " @Measurement, " +
                                   " @SamplePresentation, " +
                                   " @Strength, " +
                                   " @DosageFormGuid, " +
                                   " @ShelfLife, " +
                                   " @ReorderLevel, " +
                                   " @ProfitMargin, " +
                                   " @SellableBactchGuid, " +
                                   " @Photo, " +
                                   " @LevelGuid,@IsVATApplicable,@UserId,@ComputerName,@EventSource)" +
                                   " SELECT @Id=Max(id) from tblItems ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {

                command.Parameters.Add(new SqlParameter("@MakeOrganizationGuid", _MakeOrganization));
                command.Parameters.Add(new SqlParameter("@YearGuid", _Year));
                command.Parameters.Add(new SqlParameter("@ModelGuid", _Model));
                command.Parameters.Add(new SqlParameter("@EngineTypeGuid", _EngineType));
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", _ManufacturerGuid));
                command.Parameters.Add(new SqlParameter("@BrandName", _BrandName));
               

                command.Parameters.Add(new SqlParameter("@GenericName", _GenericName));
                command.Parameters.Add(new SqlParameter("@Measurement", _Measurement));
                command.Parameters.Add(new SqlParameter("@SamplePresentation", _SamplePresentation));
                command.Parameters.Add(new SqlParameter("@Strength", _Strength));
                command.Parameters.Add(new SqlParameter("@DosageFormGuid", _DosageFormGuid));
                command.Parameters.Add(new SqlParameter("@ShelfLife", _ShelfLife));
                command.Parameters.Add(new SqlParameter("@ReorderLevel", _ReorderLevel));
                command.Parameters.Add(new SqlParameter("@SellableBactchGuid", _SellableBactchGuid));
                command.Parameters.Add(new SqlParameter("@photo", _photo));
                command.Parameters.Add(new SqlParameter("@ProfitMargin", _ProfitMargin));
                command.Parameters.Add(new SqlParameter("@LevelGuid", _LevelGuid));
                command.Parameters.Add(new SqlParameter("@IsVATApplicable", _IsVATApplicable));
                command.Parameters.Add(new SqlParameter("@ItemCode", _ItemCode));

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
                throw new Exception("CItems::Insert::Error! " + ex.Message, ex);
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
            command.CommandText = "Update tblItems" +
                                   " Set MakeOrganizationGuid = @MakeOrganizationGuid, " +
                                   " YearGuid= @YearGuid, " +
                                   " ModelGuid= @ModelGuid, " +
                                   " EngineTypeGuid= @EngineTypeGuid, " +
                                   " ProductGuid = @ProductGuid, " +
                                   " ManufacturerGuid = @ManufacturerGuid, " +
                                   " BrandName = @BrandName, " +
                                   " GenericName = @GenericName, " +
                                   " ItemCode = @ItemCode, " +
                                   " Measurement = @Measurement, " +
                                   " SamplePresentation = @SamplePresentation, " +
                                   " Strength = @Strength, " +
                                  "  Photo = @Photo, " +
                                   " DosageFormGuid = @DosageFormGuid, " +
                                   " ShelfLife = @ShelfLife, " +
                                   " ReorderLevel = @ReorderLevel, " +
                                   " ProfitMargin = @ProfitMargin, " +
                                   " SellableBactchGuid = @SellableBactchGuid, " +
                                   " LevelGuid = @LevelGuid," +
                                   " IsVATApplicable = @IsVATApplicable, " +
                                   " UserId =@UserId," +
                                   " ComputerName =@ComputerName," +
                                   " EventSource =@EventSource " +
                                   " Where Id = @Id ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {

                command.Parameters.Add(new SqlParameter("@MakeOrganizationGuid", _MakeOrganization));
                command.Parameters.Add(new SqlParameter("@YearGuid", _Year));
                command.Parameters.Add(new SqlParameter("@ModelGuid", _Model));
                command.Parameters.Add(new SqlParameter("@EngineTypeGuid", _EngineType));
                command.Parameters.Add(new SqlParameter("@ProductGuid", _ProductGuid));
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", _ManufacturerGuid));
                command.Parameters.Add(new SqlParameter("@BrandName", _BrandName));
                command.Parameters.Add(new SqlParameter("@GenericName", _GenericName));
                
                command.Parameters.Add(new SqlParameter("@Measurement", _Measurement));
                command.Parameters.Add(new SqlParameter("@SamplePresentation", _SamplePresentation));
                command.Parameters.Add(new SqlParameter("@Strength", _Strength));
                command.Parameters.Add(new SqlParameter("@DosageFormGuid", _DosageFormGuid));
                command.Parameters.Add(new SqlParameter("@ShelfLife", _ShelfLife));
                command.Parameters.Add(new SqlParameter("@ReorderLevel", _ReorderLevel));
                command.Parameters.Add(new SqlParameter("@SellableBactchGuid", _SellableBactchGuid));
                command.Parameters.Add(new SqlParameter("@ProfitMargin", _ProfitMargin));
                command.Parameters.Add(new SqlParameter("@LevelGuid", _LevelGuid));
                command.Parameters.Add(new SqlParameter("@IsVATApplicable", _IsVATApplicable));
                command.Parameters.Add(new SqlParameter("@ItemCode", _ItemCode));
                command.Parameters.Add(new SqlParameter("@Photo", _photo));
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
                throw new Exception("CItems::Update::Error! " + ex.Message, ex);
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
            command.CommandText = "Delete From tblItems Where Id = @Id ";
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
                throw new Exception("CItems::Delete::Error! " + ex.Message, ex);
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
                command.CommandText = "SELECT Id FROM [dbo].[tblItems] WHERE " +                                      
                                       " BrandName = @BrandName " +                                      
                                       " AND ItemCode = @ItemCode ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblItems] WHERE " +
                                       " BrandName = @BrandName " +                  
                                       " AND ItemCode = @ItemCode " +                                     
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {                       
                command.Parameters.Add(new SqlParameter("@BrandName", _BrandName));                
                command.Parameters.Add(new SqlParameter("@ItemCode", _ItemCode));                
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
                throw new Exception("CItems::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public int Exists1(bool bNew)
        {
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            if (bNew)
                command.CommandText = "SELECT Id FROM [dbo].[tblItems] WHERE " +                                                                       
                                       " ItemCode = @ItemCode ";
            else
                command.CommandText = "SELECT Id FROM [dbo].[tblItems] WHERE " +
                                       " ItemCode = @ItemCode " +             
                                       " AND Id <> @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
               
                command.Parameters.Add(new SqlParameter("@ItemCode", _ItemCode));                
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
                throw new Exception("CItems::Exists::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        
        public List<CItems> GetList()
        {
            List<CItems> RecordsList = new List<CItems>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = "Select * from tblItems";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CItems objCItems = new CItems();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCItems.Id = 0;
                    else
                        objCItems.Id = (int)dr["Id"];
                    if (dr["CategoryGuid"].Equals(DBNull.Value))
                        objCItems.Categoryguid = string.Empty;
                    else
                        objCItems.Categoryguid = (string)dr["CategoryGuid"];
                    if (dr["ProductGuid"].Equals(DBNull.Value))
                        objCItems.Productguid = string.Empty;
                    else
                        objCItems.Productguid = (string)dr["ProductGuid"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCItems.Manufacturerguid = string.Empty;
                    else
                        objCItems.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCItems.Brandname = string.Empty;
                    else
                        objCItems.Brandname = (string)dr["BrandName"];
                    if (dr["GenericName"].Equals(DBNull.Value))
                        objCItems.Genericname = string.Empty;
                    else
                        objCItems.Genericname = (string)dr["GenericName"];
                    
                    if (dr["Measurement"].Equals(DBNull.Value))
                        objCItems.Measurement = string.Empty;
                    else
                        objCItems.Measurement = (string)dr["Measurement"];
                    if (dr["SamplePresentation"].Equals(DBNull.Value))
                        objCItems.Samplepresentation = string.Empty;
                    else
                        objCItems.Samplepresentation = (string)dr["SamplePresentation"];
                    if (dr["Strength"].Equals(DBNull.Value))
                        objCItems.Strength = string.Empty;
                    else
                        objCItems.Strength = (string)dr["Strength"];
                    if (dr["DosageFormGuid"].Equals(DBNull.Value))
                        objCItems.Dosageformguid = string.Empty;
                    else
                        objCItems.Dosageformguid = (string)dr["DosageFormGuid"];
                    if (dr["ShelfLife"].Equals(DBNull.Value))
                        objCItems.Shelflife = string.Empty;
                    else
                        objCItems.Shelflife = (string)dr["ShelfLife"];
                    if (dr["ReorderLevel"].Equals(DBNull.Value))
                        objCItems.Reorderlevel = 0;
                    else
                        objCItems.Reorderlevel = (decimal)dr["ReorderLevel"];
                    if (dr["SellableBactchGuid"].Equals(DBNull.Value))
                        objCItems.Sellablebactchguid = string.Empty;
                    else
                        objCItems.Sellablebactchguid = (string)dr["SellableBactchGuid"];
                    if (dr["ProfitMargin"].Equals(DBNull.Value))
                        objCItems.ProfitMargin = 0;
                    else
                        objCItems.ProfitMargin = (decimal)dr["ProfitMargin"];
                    if (dr["LevelGuid"].Equals(DBNull.Value))
                        objCItems.Levelguid = string.Empty;
                    else
                        objCItems.Levelguid = (string)dr["LevelGuid"];
                    if (dr["IsVATApplicable"].Equals(DBNull.Value))
                        objCItems.IsVATApplicable = false;
                    else
                        objCItems.IsVATApplicable = (bool)dr["IsVATApplicable"];
                    if (dr["ItemCode"].Equals(DBNull.Value))
                        objCItems.Itemcode = string.Empty;
                    else
                        objCItems.Itemcode = (string)dr["ItemCode"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCItems.Tablerowguid = string.Empty;
                    else
                        objCItems.Tablerowguid = (string)dr["TableRowGuid"];

                    if (dr["MakeOrganizationGuid"].Equals(DBNull.Value))
                        objCItems.MakeOrganization = string.Empty;
                    else
                        objCItems.MakeOrganization = (string)dr["MakeOrganizationGuid"];
                    if (dr["YearGuid"].Equals(DBNull.Value))
                        objCItems.Year = string.Empty;
                    else
                        objCItems.Year= (string)dr["YearGuid"];

                    if (dr["ModelGuid"].Equals(DBNull.Value))
                        objCItems.Model = string.Empty;
                    else
                        objCItems.Model = (string)dr["ModelGuid"];
                    if (dr["EngineTypeGuid"].Equals(DBNull.Value))
                        objCItems.EngineType = string.Empty;
                    else
                        objCItems.EngineType = (string)dr["EngineTypeGuid"];


                    RecordsList.Add(objCItems);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CItems> GetList(string Manufacturerguid, string Categoryguid, string BrandName, string GenericName)
        {
            List<CItems> RecordsList = new List<CItems>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            command.CommandText = " Select * from tblItems ";
            command.CommandText += " Where BrandName Like @BrandName ";
            command.CommandText += " AND GenericName Like @GenericName ";

            command.Parameters.Add(new SqlParameter("@BrandName", BrandName + "%"));
            command.Parameters.Add(new SqlParameter("@GenericName", GenericName + "%"));

            if (Manufacturerguid != string.Empty)
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                command.CommandText += " AND ManufacturerGuid = @ManufacturerGuid ";
            }
            if (Categoryguid != string.Empty)
            {
                command.Parameters.Add(new SqlParameter("@CategoryGuid", Categoryguid));
                command.CommandText += " AND CategoryGuid = @CategoryGuid ";
            }

            command.CommandText += " Order By BrandName, GenericName, Strength, Measurement ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;


            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CItems objCItems = new CItems();
                    if (dr["Id"].Equals(DBNull.Value))
                        objCItems.Id = 0;
                    else
                        objCItems.Id = (int)dr["Id"];
                    if (dr["CategoryGuid"].Equals(DBNull.Value))
                        objCItems.Categoryguid = string.Empty;
                    else
                        objCItems.Categoryguid = (string)dr["CategoryGuid"];
                    if (dr["ProductGuid"].Equals(DBNull.Value))
                        objCItems.Productguid = string.Empty;
                    else
                        objCItems.Productguid = (string)dr["ProductGuid"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCItems.Manufacturerguid = string.Empty;
                    else
                        objCItems.Manufacturerguid = (string)dr["ManufacturerGuid"];
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCItems.Brandname = string.Empty;
                    else
                        objCItems.Brandname = (string)dr["BrandName"];
                    if (dr["GenericName"].Equals(DBNull.Value))
                        objCItems.Genericname = string.Empty;
                    else
                        objCItems.Genericname = (string)dr["GenericName"];
                   
                    if (dr["Measurement"].Equals(DBNull.Value))
                        objCItems.Measurement = string.Empty;
                    else
                        objCItems.Measurement = (string)dr["Measurement"];
                    if (dr["SamplePresentation"].Equals(DBNull.Value))
                        objCItems.Samplepresentation = string.Empty;
                    else
                        objCItems.Samplepresentation = (string)dr["SamplePresentation"];
                    if (dr["Strength"].Equals(DBNull.Value))
                        objCItems.Strength = string.Empty;
                    else
                        objCItems.Strength = (string)dr["Strength"];
                    if (dr["DosageFormGuid"].Equals(DBNull.Value))
                        objCItems.Dosageformguid = string.Empty;
                    else
                        objCItems.Dosageformguid = (string)dr["DosageFormGuid"];
                    if (dr["ShelfLife"].Equals(DBNull.Value))
                        objCItems.Shelflife = string.Empty;
                    else
                        objCItems.Shelflife = (string)dr["ShelfLife"];
                    if (dr["ReorderLevel"].Equals(DBNull.Value))
                        objCItems.Reorderlevel = 0;
                    else
                        objCItems.Reorderlevel = (decimal)dr["ReorderLevel"];
                    if (dr["SellableBactchGuid"].Equals(DBNull.Value))
                        objCItems.Sellablebactchguid = string.Empty;
                    else
                        objCItems.Sellablebactchguid = (string)dr["SellableBactchGuid"];
                    if (dr["ProfitMargin"].Equals(DBNull.Value))
                        objCItems.ProfitMargin = 0;
                    else
                        objCItems.ProfitMargin = (decimal)dr["ProfitMargin"];
                    if (dr["LevelGuid"].Equals(DBNull.Value))
                        objCItems.Levelguid = string.Empty;
                    else
                        objCItems.Levelguid = (string)dr["LevelGuid"];
                    if (dr["IsVATApplicable"].Equals(DBNull.Value))
                        objCItems.IsVATApplicable = false;
                    else
                        objCItems.IsVATApplicable = (bool)dr["IsVATApplicable"];
                    if (dr["ItemCode"].Equals(DBNull.Value))
                        objCItems.Itemcode = string.Empty;
                    else
                        objCItems.Itemcode = (string)dr["ItemCode"];
                    if (dr["TableRowGuid"].Equals(DBNull.Value))
                        objCItems.Tablerowguid = string.Empty;
                    else
                        objCItems.Tablerowguid = (string)dr["TableRowGuid"];
                    if (dr["MakeOrganizationGuid"].Equals(DBNull.Value))
                        objCItems.MakeOrganization = string.Empty;
                    else
                        objCItems.MakeOrganization = (string)dr["MakeOrganizationGuid"];
                    if (dr["YearGuid"].Equals(DBNull.Value))
                        objCItems.Year= string.Empty;
                    else
                        objCItems.Year = (string)dr["YearGuid"];

                    if (dr["ModelGuid"].Equals(DBNull.Value))
                        objCItems.Model = string.Empty;
                    else
                        objCItems.Model = (string)dr["ModelGuid"];
                    if (dr["EngineTypeGuid"].Equals(DBNull.Value))
                        objCItems.EngineType = string.Empty;
                    else
                        objCItems.EngineType = (string)dr["EngineTypeGuid"];

                    RecordsList.Add(objCItems);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public List<CItems> GetList(string Manufacturerguid, string MakeOrganizationguid, string EngineTypeguid, string Yearguid, string Modelguid, string BrandName, string GenericName, string ItemCode)
        {
            List<CItems> RecordsList = new List<CItems>();
            SqlConnection connection = new SqlConnection(_ConnectionString);

            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();

            command.CommandText = " select tblitems.Id,(tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName) As BrandName,tblitems.ItemCode,tblitems.MakeOrganizationGuid,";
            command.CommandText += " tblitems.YearGuid,tblitems.ModelGuid,tblitems.EngineTypeGuid,tblitems.ReorderLevel,tblitems.ProfitMargin,tblitems.ManufacturerGuid,tblitems.IsVATApplicable,tblitems.SellableBactchGuid from tblitems";
            command.CommandText += " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
            command.CommandText += " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
            command.CommandText += " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
            command.CommandText += " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";           
            command.CommandText += " Where BrandName Like @BrandName ";
            command.CommandText += " AND GenericName Like @GenericName ";
            command.CommandText += " AND ItemCode Like @ItemCode ";
            command.Parameters.Add(new SqlParameter("@BrandName", BrandName + "%"));
            command.Parameters.Add(new SqlParameter("@ItemCode", ItemCode + "%"));
            command.Parameters.Add(new SqlParameter("@GenericName", GenericName + "%"));

            if (Manufacturerguid != string.Empty)
            {
                command.Parameters.Add(new SqlParameter("@ManufacturerGuid", Manufacturerguid));
                command.CommandText += " AND ManufacturerGuid = @ManufacturerGuid ";
            }
            if (MakeOrganizationguid != string.Empty)
            {
                command.Parameters.Add(new SqlParameter("@MakeOrganizationGuid", MakeOrganizationguid));
                command.CommandText += " AND MakeOrganizationGuid = @MakeOrganizationGuid ";

            }
            if (EngineTypeguid != string.Empty)
            {
                command.Parameters.Add(new SqlParameter("@EngineTypeGuid", EngineTypeguid));
                command.CommandText += " AND EngineTypeGuid = @EngineTypeGuid ";

            }
            if (Yearguid != string.Empty)
            {
                command.Parameters.Add(new SqlParameter("@YearGuid", Yearguid));
                command.CommandText += " AND YearGuid = @YearGuid ";

            }
            if (Modelguid != string.Empty)
            {
                command.Parameters.Add(new SqlParameter("@ModelGuid", Modelguid));
                command.CommandText += " AND ModelGuid = @ModelGuid ";

            }
         
            //if (ItemCode != string.Empty)
            //{
            //    command.Parameters.Add(new SqlParameter("@ItemCode", ItemCode));
            //    command.CommandText += " AND ItemCode = @ItemCode ";
            //}
            command.CommandText += " Order By BrandName, GenericName, Strength, Measurement ";
            command.CommandType = CommandType.Text;
            command.Connection = connection;


            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CItems objCItems = new CItems();
                   
                    if (dr["BrandName"].Equals(DBNull.Value))
                        objCItems.Brandname = string.Empty;
                    else
                        objCItems.Brandname = (string)dr["BrandName"];
                    
                    if (dr["ItemCode"].Equals(DBNull.Value))
                        objCItems.Itemcode = string.Empty;
                    else
                        objCItems.Itemcode = (string)dr["ItemCode"];


                    if (dr["MakeOrganizationGuid"].Equals(DBNull.Value))
                        objCItems.MakeOrganization = string.Empty;
                    else
                        objCItems.MakeOrganization = (string)dr["MakeOrganizationGuid"];
                    if (dr["YearGuid"].Equals(DBNull.Value))
                        objCItems.Year = string.Empty;
                    else
                        objCItems.Year = (string)dr["YearGuid"];
                    
                    if (dr["ModelGuid"].Equals(DBNull.Value))
                        objCItems.Model = string.Empty;
                    else
                        objCItems.Model = (string)dr["ModelGuid"];
                    if (dr["EngineTypeGuid"].Equals(DBNull.Value))
                        objCItems.EngineType = string.Empty;
                    else
                        objCItems.EngineType = (string)dr["EngineTypeGuid"];
                    if (dr["ReorderLevel"].Equals(DBNull.Value))
                        objCItems.Reorderlevel = 0;
                    else
                        objCItems.Reorderlevel = (decimal)dr["ReorderLevel"];
                    if (dr["IsVATApplicable"].Equals(DBNull.Value))
                        objCItems.IsVATApplicable = false;
                    else
                        objCItems.IsVATApplicable = (bool)dr["IsVATApplicable"];
                    if (dr["ProfitMargin"].Equals(DBNull.Value))
                        objCItems.ProfitMargin = 0;
                    else
                        objCItems.ProfitMargin = (decimal)dr["ProfitMargin"];
                    if (dr["ManufacturerGuid"].Equals(DBNull.Value))
                        objCItems.Manufacturerguid = string.Empty;
                    else
                        objCItems.Manufacturerguid = (string)dr["ManufacturerGuid"];


                    if (dr["SellableBactchGuid"].Equals(DBNull.Value))
                        objCItems.Sellablebactchguid = string.Empty;
                    else
                        objCItems.Sellablebactchguid = (string)dr["SellableBactchGuid"];

                    if (dr["Id"].Equals(DBNull.Value))
                        objCItems.Id = 0;
                    else
                        objCItems.Id = (int)dr["Id"];
                   

                    RecordsList.Add(objCItems);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        public static string GetItemName(string Itemguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "  select(tblMakeOrganizations.Name +  '-' +  tblEngineType.Name + '-' + tblModel.Name + '-' + tblYear.Name + '-' + BrandName)AS BrandName  from tblitems";
            command.CommandText += " inner join tblYear on tblItems.YearGuid = tblYear.TableRowGuid";
            command.CommandText += " inner join tblMakeOrganizations on tblItems.MakeOrganizationGuid = tblMakeOrganizations.TableRowGuid";
            command.CommandText += " inner join tblEngineType on tblItems.EngineTypeGuid = tblEngineType.TableRowGuid";
            command.CommandText += " inner join tblModel on tblItems.ModelGuid = tblModel.TableRowGuid";
            command.CommandText += " inner join tblLocalPurchaseOrderDetails on tblLocalPurchaseOrderDetails.ItemGuid =tblItems.TableRowGuid";
           // command.CommandText += " inner join tblBatchs on tblBatchs.ItemGuid =tblItems.TableRowGuid"; 
            command.CommandText += " where tblItems.TableRowGuid =@ItemGuid ";         
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            try
            {
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                
                connection.Open();
                return (string)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetItemName::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static decimal GetProfitMargin(string Itemguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT ProfitMargin FROM [dbo].[tblItems] WHERE [TableRowGuid] = @ItemGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                connection.Open();
                return (decimal)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetProfitMargin::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static int GetRequiredProfessionalLevel(string Itemguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = " SELECT ProfessionalLevel = IsNull(tblLevels.ProfessionalLevel, 0) ";
            command.CommandText += " FROM tblItems INNER JOIN tblLevels ";
            command.CommandText += " ON tblItems.LevelGuid = tblLevels.TableRowGuid ";
            command.CommandText += " WHERE tblItems.TableRowGuid = @ItemGuid ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                connection.Open();
                return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetRequiredProfessionalLevel::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static bool GetIsVATApplicable(string Itemguid)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT IsVATApplicable FROM [dbo].[tblItems] WHERE [TableRowGuid] = @ItemGuid";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@ItemGuid", Itemguid));
                connection.Open();
                return (bool)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetIsVATApplicable::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        public static string GetTableRowGuid(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "SELECT TableRowGuid FROM [dbo].[tblItems] WHERE Id = @Id";
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
                throw new Exception("CItems::GetTableRowGuid::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
        public static byte[] GetPicture(int Id)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            SqlDataReader dr = null;
            Object temp;
           
            command.CommandText = "SELECT Photo FROM [dbo].[tblItems] WHERE Id = @Id";
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@Id", Id));
                connection.Open();
                dr = command.ExecuteReader();
                dr.Read();
                if (!dr["Photo"].Equals(DBNull.Value))
                    return (byte[])dr["Photo"];
                else
                    return null;


                //return (int)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("CItems::GetTableRowGuid::Error!" + ex.Message, ex);
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

            command.CommandText = "SELECT Id FROM [dbo].[tblItems] WHERE TableRowGuid = @TableRowGuid";
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
                throw new Exception("CItems::GetTableRowId::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }
    }
}