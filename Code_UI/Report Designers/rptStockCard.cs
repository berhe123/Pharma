using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharma
{
    /// <summary>
    /// Summary description for rptStockCard.
    /// </summary>
    public partial class rptStockCard : DataDynamics.ActiveReports.ActiveReport3
    {
        private const string DialogCaption = "Stock Card Report";

        int intCount;
        decimal BBF = 0;
        decimal Balance = 0;

        #region Class Property Declarations
        DateTime _DateFrom;
        public DateTime DateFrom
        {
            get { return _DateFrom; }
            set { _DateFrom = value; }
        }

        DateTime _DateTo;
        public DateTime DateTo
        {
            get { return _DateTo; }
            set { _DateTo = value; }
        }

        string _Location;
        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        string _Store;
        public string Store
        {
            get { return _Store; }
            set { _Store = value; }
        }

        string _StoreGuid;
        public string Storeguid
        {
            get { return _StoreGuid; }
            set { _StoreGuid = value; }
        }

        string _Manufacturer;
        public string Manufacturer
        {
            get { return _Manufacturer; }
            set { _Manufacturer = value; }
        }

        string _ItemGuid;
        public string Itemguid
        {
            get { return _ItemGuid; }
            set { _ItemGuid = value; }
        }

        #endregion

        public rptStockCard()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        private void pageHeader_Format(object sender, EventArgs e)
        {
            try
            {
                this.lblCriteria.Text = "For the Period: From " + _DateFrom.ToString(CSettings.DateFormat)
                                    + " To " + _DateTo.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public decimal GetBBF()
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();
            Object temp;

            command.CommandText = "";
            command.CommandText += " SELECT	BBF = SUM(Received) -	SUM(Issued) - SUM(Damaged) - SUM(Recalled)  ";
            command.CommandText += " FROM tblBatchs LEFT OUTER JOIN ";
            command.CommandText += "     (SELECT BatchGuid, ";
            command.CommandText += "             ISNULL(ReceivedQuantity, 0) AS Received,  ";
            command.CommandText += "             ISNULL(IssuedQuantity, 0) AS Issued,  ";
            command.CommandText += "             ISNULL(DamagedQuantity, 0) AS Damaged,  ";
            command.CommandText += "             ISNULL(RecalledQuantity, 0) AS Recalled ";
            command.CommandText += "     FROM StockBalanceToDateAll(@StoreGuid, @UptoDate)) AS BBF ";
            command.CommandText += "     ON tblBatchs.TableRowGuid = BBF.BatchGuid ";
            command.CommandText += " WHERE ItemGuid = @ItemGuid ";

            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                command.Parameters.Add(new SqlParameter("@StoreGuid", _StoreGuid));
                command.Parameters.Add(new SqlParameter("@UptoDate", _DateFrom.AddDays(-1)));
                command.Parameters.Add(new SqlParameter("@ItemGuid", _ItemGuid));
                connection.Open();
                temp = command.ExecuteScalar();
                if (temp != null)
                    return (decimal)temp;
                else
                    return 0;
                //return (decimal)command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        private void groupHeader1_Format(object sender, EventArgs e)
        {
            try
            {
                //txtProduct.Text = txtProduct.Text + " " + txtMeasurement.Text + " " + CCommon.GetDosageFormText(Convert.ToInt32(txtDosageForm.Value));
                txtLocation.Text = _Location;
                txtStore.Text = _Store;
                txtManufacturer.Text = _Manufacturer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupFooter1_Format(object sender, EventArgs e)
        {
            try
            {
                txtEnding.Value = Balance;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void detail_Format(object sender, EventArgs e)
        {
            try
            {
                intCount = intCount + 1;
                txtSerialNumber.Text = intCount.ToString();
                txtTransactionType.Text = CCommon.GetStoreTransactionTypeText(Convert.ToInt32(txtTransactionType.Value));

                int TransactionType = Convert.ToInt32(txtTransactionType.Value);
                int Quantity = Convert.ToInt32(txtQuantity.Value);

                switch (TransactionType)
                {
                    case (int)CCommon.StoreTransactionType.Receiving: Balance = Balance + Quantity; break;
                    case (int)CCommon.StoreTransactionType.Issuance: Balance = Balance - Quantity; break;
                    case (int)CCommon.StoreTransactionType.Damage: Balance = Balance - Quantity; break;
                    case (int)CCommon.StoreTransactionType.Recall: Balance = Balance - Quantity; break;
                }

                txtBalance.Value = Balance;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pageFooter_Format(object sender, EventArgs e)
        {
            try
            {
                this.txtPrintDate.Text = DateTime.Today.ToString(CSettings.DateFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rptStockCard_ReportStart(object sender, EventArgs e)
        {
            try
            {
                if (CSettings.OrganizationLogo != null)
                    this.picLogo.Image = CPicture.ByteArrayToPicture(CSettings.OrganizationLogo);
                lblOrganization.Text = CSettings.OrganizationName;
                txtTel.Text = CSettings.OrganizationTelephone;
                txtPOBox.Text = CSettings.OrganizationPOBox;
                txtFax.Text = CSettings.OrganizationFax;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupHeader3_Format(object sender, EventArgs e)
        {
            try
            {
                BBF = GetBBF();
                Balance = BBF;
                txtBBF.Value = BBF;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
