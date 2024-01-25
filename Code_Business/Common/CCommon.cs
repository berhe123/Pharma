using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
//using System.Configuration;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;

namespace Pharma
{
    /// <summary>
    /// Contains common tasks to be used globally.
    /// </summary>
    class CCommon
    {
        //-
        public enum ItemCategoryType
        {
            NonPsychotropic = 0,
            Psychotropic = 1
        };
        public enum LocalPurchaseOrderStatus
        {
            Ordered = 0,
            AwaitingDelivery = 1,
            Delivered = 2
        }
        public enum SupplierType
        {
            Exporter = 0,
            Local = 1
        };
        public enum TenderType
        {
            Local = 0,
            International = 1,
        }
        public enum TenderStatus
        {
            Initiated = 0,
            OnProgress = 1,
            Submitted = 2,
            Awarded = 3,
            Lost = 2,
            Discarded = 3
        }
        public enum BidBondStatus
        {
            OnHold = 0,
            Returned = 1,
        }
        public enum PerformanceBondStatus
        {
            OnHold = 0,
            Returned = 1,
        }
        public enum TenderCheckListStatus
        {
            OnPreparation = 0,
            Ready = 1,
        }
        public enum PurchaseOrderStatus
        {
            AwaitingImportPermit = 0,
            AwaitingBankPermit = 1,
            AwatingDispatchFromSupplier = 2,
            AWaitingCustomsClearance = 3
        }
        public enum ProfessionalLevel
        {
            Druggist = 0,
            Pharmacist = 1,
        }
        public enum ProductRegistrationCertificateStatus
        {
            Granted = 0,
            Denied = 1,
            Revoked = 2,
            Pending = 3
        };
        public enum MarketStudyStatus
        {
            OnProgress = 0,
            Canceled = 1,
            Approved = 2,
            Rejected = 3
        };
        public enum StoreTransactionType
        {
            Receiving = 0,
            Issuance = 1,
            Recall = 2,
            Damage = 3
        };
        public enum DosageForm
        {
            Capsule = 0,
            Tablet = 1,
            Cream = 2,
            Injection = 3,
            Ointment = 4,
        }
        public enum TermsOfPayment
        {
            CashAgainstDocument = 0,
            LetterOfCredit = 1,
            FreeOfCharge = 2,
        }
        public enum Dispatch
        {
            ByAir = 0,
            BySea = 1,
        }
        public enum TermsOfShipment
        {
            CostAndFreight = 0,
            FreeOfCharge = 1,
        }
        public enum CurrencyType
        {
            Birr = 0,
            Dollar = 1,
            Euro = 2,
        }
        public enum ProformaOrderType
        {
            Normal = 0,
            Sample = 1,
        }
        public enum PaymentReason
        {
            Transportation = 0,
            Customs = 1,
            Transitor = 2,
        }
        public enum InvoiceType
        {
            CashSales = 0,
            CreditSales = 1,
            FreeOfCharge = 2,
        };
        public enum DeliveryStatus
        {
            Pending = 0,
            Delivered = 1,
            Returned = 2
        };
        public static DeliveryStatus eDeliveryStatus = DeliveryStatus.Pending;
        public enum PaymentType
        {
            Cash = 0,
            Check = 1,
            CPO = 2
        };
        public enum PaymentSettlement
        {
            NotSettled = 0,
            Settled = 1
        };
        public enum CheckStatus
        {
            NotCashed = 0,
            Cashed = 1
        };
        public enum EventType
        {
            Insert = 1,
            Update = 2,
            Delete = 3
        };
        public enum EventSource
        {
            Default = 0,
            System = 1,
            Restored = 2,
            Merged = 3
        };

        public struct ColumnCriteria
        {
            public string ColumnName;
            public string Operator;
            public string Value;
            public int ColumnType;

        }
        public static DataTable GetRecords(string strSQL)
        {
            SqlConnection connection = new SqlConnection(Pharma.Properties.Settings.Default.ConnectionString);
            SqlCommand command = new SqlCommand();

            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            DataTable dTable = new DataTable("temp_table");
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
                throw new Exception("CCommon::GetRecord::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
                if (adapter != null) adapter.Dispose();
            }
        }

        public static bool SetRequiredMessage(ComboBox cboName, string strMsg, ErrorProvider erPr, ToolStripLabel lbl)
        {
            erPr.SetIconAlignment(cboName, ErrorIconAlignment.MiddleRight);
            erPr.SetIconPadding(cboName, 2);
            erPr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            if (cboName.SelectedIndex == -1)
            {

                erPr.SetError(cboName, strMsg);
                lbl.Text = strMsg;
                return false;

            }
            else
            {
                erPr.SetError(cboName, "");
                lbl.Text = "";
                return true;
            }
        }
        public static bool SetRequiredMessage(ComboBox cboName, string strMsg, ErrorProvider erPr, ToolStripLabel lbl, bool blnSelectItem)
        {
            erPr.SetIconAlignment(cboName, ErrorIconAlignment.MiddleRight);
            erPr.SetIconPadding(cboName, 2);
            erPr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            if (cboName.SelectedIndex < 1)
            {

                erPr.SetError(cboName, strMsg);
                lbl.Text = strMsg;
                return false;

            }
            else
            {
                erPr.SetError(cboName, "");
                lbl.Text = "";
                return true;
            }
        }
        public static bool SetRequiredMessage(TextBox txtName, string strMsg, ErrorProvider erPr, ToolStripLabel lbl)
        {
            erPr.SetIconAlignment(txtName, ErrorIconAlignment.MiddleRight);
            erPr.SetIconPadding(txtName, 2);
            erPr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            if (txtName.Text == "")
            {
                erPr.SetError(txtName, strMsg);
                lbl.Text = strMsg;
                return false;

            }
            else
            {
                erPr.SetError(txtName, "");
                lbl.Text = "";
                return true;
            }
        }
        public static bool SetRequiredMessage(RichTextBox txtName, string strMsg, ErrorProvider erPr, ToolStripLabel lbl)
        {
            erPr.SetIconAlignment(txtName, ErrorIconAlignment.MiddleRight);
            erPr.SetIconPadding(txtName, 2);
            erPr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            if (txtName.Text == "")
            {
                erPr.SetError(txtName, strMsg);
                lbl.Text = strMsg;
                return false;

            }
            else
            {
                erPr.SetError(txtName, "");
                lbl.Text = "";
                return true;
            }
        }

        public static bool SetMessage(Control control, string strMsg, ErrorProvider erPr, ToolStripLabel lbl)
        {
            erPr.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);
            erPr.SetIconPadding(control, 2);
            erPr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            erPr.SetError(control, strMsg);
            lbl.Text = strMsg;
            return false;


        }

        public static bool SetRequiredMessage(TextBox txtName, string strMsg, ErrorProvider erPr, ToolStripLabel lbl, int intNumericType)
        {
            erPr.SetIconAlignment(txtName, ErrorIconAlignment.MiddleRight);
            erPr.SetIconPadding(txtName, 2);
            erPr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            double dblValue;
            int intValue;
            if (intNumericType == 1)
            {
                if (txtName.Text != "")
                {
                    if (!int.TryParse(txtName.Text, out intValue))
                    {
                        erPr.SetError(txtName, strMsg);
                        lbl.Text = strMsg;
                        return false;
                    }
                    else
                    {
                        erPr.SetError(txtName, "");
                        lbl.Text = "";
                        return true;
                    }

                }
                else
                {
                    erPr.SetError(txtName, "");
                    lbl.Text = "";
                    return true;
                }
            }
            else
            {
                if (txtName.Text != "")
                {
                    if (!double.TryParse(txtName.Text, out dblValue))
                    {
                        erPr.SetError(txtName, strMsg);
                        lbl.Text = strMsg;
                        return false;
                    }
                    else
                    {
                        erPr.SetError(txtName, "");
                        lbl.Text = "";
                        return true;
                    }

                }
                else
                {
                    erPr.SetError(txtName, "");
                    lbl.Text = "";
                    return true;
                }
            }

        }
        public static bool SetRequiredMessage(NumericUpDown txtName, string strMsg, ErrorProvider erPr, ToolStripLabel lbl)
        {
            erPr.SetIconAlignment(txtName, ErrorIconAlignment.MiddleRight);
            erPr.SetIconPadding(txtName, 2);
            erPr.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.BlinkIfDifferentError;
            if (txtName.Value == 0)
            {
                erPr.SetError(txtName, strMsg);
                lbl.Text = strMsg;
                return false;

            }
            else
            {
                erPr.SetError(txtName, "");
                lbl.Text = "";
                return true;

            }
        }

        public static void FillComboBox(ComboBox cboName, string strSQL, string strItemDataField, string strDisplayTextField)
        {
            try
            {

                CComboBoxItem objComboBoxItem = new CComboBoxItem();

                ArrayList ar = new ArrayList(objComboBoxItem.GetList(strSQL, strItemDataField, strDisplayTextField));
                //cboName.Items.Clear();
                if (ar.Count <= 0) return;
                //cboName.ValueMember = "ItemData";
                cboName.DisplayMember = "DisplayText";
                cboName.DataSource = ar;

            }
            catch (Exception ex)
            {
                throw new Exception("CCommon::FillComboBox::Error! " + ex.Message, ex);
            }
        }
        public static void FillComboBox(ComboBox cboName, string strSQL, string strItemDataField, string strDisplayTextField, bool blnAddSelect)
        {
            try
            {

                CComboBoxItem objComboBoxItem = new CComboBoxItem();

                ArrayList ar = new ArrayList(objComboBoxItem.GetList(strSQL, strItemDataField, strDisplayTextField, blnAddSelect));
                //cboName.Items.Clear();
                if (ar.Count < 0) return;
                cboName.ValueMember = "ItemData";
                cboName.DisplayMember = "DisplayText";
                cboName.DataSource = ar;

            }
            catch (Exception ex)
            {
                throw new Exception("CCommon::FillComboBox::Error! " + ex.Message, ex);
            }
        }

        //public static void FillComboBox(ComboBox cboName, ArrayList arl, string strItemDataField, string strDisplayTextField)
        //{
        //    try
        //    {

        //        CComboBoxItem objComboBoxItem = new CComboBoxItem();

        //        ArrayList ar = new ArrayList(objComboBoxItem.GetList(arl, strItemDataField, strDisplayTextField));
        //        //cboName.Items.Clear();
        //        if (ar.Count < 0) return;
        //        cboName.DisplayMember = "DisplayText";
        //        cboName.DataSource = ar;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("CCommon::FillComboBox::Error! " + ex.Message, ex);
        //    }
        //}
        public static void FillGridComboBox(DataGridViewComboBoxColumn cboName, string strSQL, string strItemDataField, string strDisplayTextField)
        {
            try
            {

                CComboBoxItem objComboBoxItem = new CComboBoxItem();

                ArrayList ar = new ArrayList(objComboBoxItem.GetList(strSQL, strItemDataField, strDisplayTextField));
                //cboName.Items.Clear();
                if (ar.Count <= 0)
                {
                    cboName.DataSource = null;

                    return;
                }




                cboName.DisplayMember = "DisplayText";
                cboName.ValueMember = "ItemData";
                cboName.DataSource = ar;

            }
            catch (Exception ex)
            {
                throw new Exception("CCommon::FillGridComboBox::Error! " + ex.Message, ex);
            }
        }
        //-
        public static string GetItemData(ComboBox cboName)
        {
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = (CComboBoxItem)cboName.SelectedItem;
            if (objComboBoxItem == null)
                return String.Empty;
            else
                return objComboBoxItem.ItemData;
        }
        public static string GetItemDataGrid(DataGridViewComboBoxColumn cboName)
        {
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = (CComboBoxItem)cboName.Items[0];// SelectPharma.ToString  ToString(); // SelectedItem;
            if (objComboBoxItem == null)
                return String.Empty;
            else
                return objComboBoxItem.ItemData;
        }
        //-
        public static string GetDisplayText(ComboBox cboName)
        {
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = (CComboBoxItem)cboName.SelectedItem;
            if (objComboBoxItem == null)
                return String.Empty;
            else
                return objComboBoxItem.DisplayText;
        }
        public static int GetIndexByText(ComboBox cboName, string strValue, bool SelectItem)
        {
            CComboBoxItem objComboBoxItem;
            int intItemCount;
            int i;

            intItemCount = cboName.Items.Count;
            for (i = 0; i < intItemCount; i++)
            {

                objComboBoxItem = (CComboBoxItem)cboName.Items[i];
                if (objComboBoxItem.DisplayText == strValue)
                    return i;
            }

            // If item is not found return index of <Select an Item>
            if (SelectItem)
            {
                intItemCount = cboName.Items.Count;
                for (i = 0; i < intItemCount; i++)
                {

                    objComboBoxItem = (CComboBoxItem)cboName.Items[i];
                    if (objComboBoxItem.DisplayText == "-1")
                        return i;
                }
            }

            return -1;
        }
        public static int GetIndexByItemData(ComboBox cboName, string strValue, bool SelectItem)
        {
            CComboBoxItem objComboBoxItem;
            int intItemCount;
            int i;

            intItemCount = cboName.Items.Count;
            for (i = 0; i < intItemCount; i++)
            {

                objComboBoxItem = (CComboBoxItem)cboName.Items[i];
                if (objComboBoxItem.ItemData == strValue)
                    return i;
            }

            // If item is not found return index of <Select an Item>
            if (SelectItem)
            {
                intItemCount = cboName.Items.Count;
                for (i = 0; i < intItemCount; i++)
                {

                    objComboBoxItem = (CComboBoxItem)cboName.Items[i];
                    if (objComboBoxItem.ItemData == "-1")
                        return i;
                }
            }

            return -1;
        }
        //-
        public static void FillCurrencyTypeCombo(ComboBox cboCurrencyType, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Birr";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "US Dollar";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Euro";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboCurrencyType.Items.Clear();
            cboCurrencyType.DisplayMember = "DisplayText";
            cboCurrencyType.ValueMember = "ItemData";
            cboCurrencyType.DataSource = ar;

        }
        public static void FillCurrencyTypeCombo(DataGridViewComboBoxColumn cboCurrencyType, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Birr";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "US Dollar";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Euro";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboCurrencyType.Items.Clear();
            cboCurrencyType.DisplayMember = "DisplayText";
            cboCurrencyType.ValueMember = "ItemData";
            cboCurrencyType.DataSource = ar;

        }
        public static string GetCurrencyTypeText(int intCurrencyType)
        {
            if (intCurrencyType == 0)
                return "Birr";
            else if (intCurrencyType == 1)
                return "US Dollar";
            else if (intCurrencyType == 2)
                return "Euro";
            else
                return "Birr";
        }
        //-
        public static void FillProformaOrderTypeCombo(ComboBox cboProformaOrderType, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Normal";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Sample";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboProformaOrderType.Items.Clear();
            cboProformaOrderType.DisplayMember = "DisplayText";
            cboProformaOrderType.ValueMember = "ItemData";
            cboProformaOrderType.DataSource = ar;

        }
        public static void FillProformaOrderTypeCombo(DataGridViewComboBoxColumn cboProformaOrderType, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Normal";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Sample";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboProformaOrderType.Items.Clear();
            cboProformaOrderType.DisplayMember = "DisplayText";
            cboProformaOrderType.ValueMember = "ItemData";
            cboProformaOrderType.DataSource = ar;

        }
        public static string GetProformaOrderTypeText(int intProformaOrderType)
        {
            if (intProformaOrderType == 0)
                return "Normal";
            else if (intProformaOrderType == 1)
                return "Sample";
            else
                return "Normal";
        }
        //-
        public static void FillLocalPurchaseOrderTypeCombo(ComboBox cboProformaOrderType, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Normal";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Urgent";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboProformaOrderType.Items.Clear();
            cboProformaOrderType.DisplayMember = "DisplayText";
            cboProformaOrderType.ValueMember = "ItemData";
            cboProformaOrderType.DataSource = ar;

        }
        public static void FillLocalPurchaseOrderTypeCombo(DataGridViewComboBoxColumn cboProformaOrderType, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Normal";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Urgent";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboProformaOrderType.Items.Clear();
            cboProformaOrderType.DisplayMember = "DisplayText";
            cboProformaOrderType.ValueMember = "ItemData";
            cboProformaOrderType.DataSource = ar;

        }
        public static string GetLocalPurchaseOrderTypeText(int intProformaOrderType)
        {
            if (intProformaOrderType == 0)
                return "Normal";
            else if (intProformaOrderType == 1)
                return "Urgent";
            else
                return "Normal";
        }

        //-
        public static void FillProfessionalLevelCombo(ComboBox cboProfessionalLevel, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Druggist";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Pharmacist";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboProfessionalLevel.Items.Clear();
            cboProfessionalLevel.DisplayMember = "DisplayText";
            cboProfessionalLevel.ValueMember = "ItemData";
            cboProfessionalLevel.DataSource = ar;

        }
        public static void FillProfessionalLevelCombo(DataGridViewComboBoxColumn cboProfessionalLevel, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Druggist";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Pharmacist";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboProfessionalLevel.Items.Clear();
            cboProfessionalLevel.DisplayMember = "DisplayText";
            cboProfessionalLevel.ValueMember = "ItemData";
            cboProfessionalLevel.DataSource = ar;

        }
        public static string GetProfessionalLevelText(int intProfessionalLevel)
        {
            if (intProfessionalLevel == 0)
                return "Druggist";
            else if (intProfessionalLevel == 1)
                return "Pharmacist";
            else
                return "Pharmacist";
        }
        //-
        public static void FillDosageFormCombo(ComboBox cboDosageForm, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Capsule";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Tablet";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Cream";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Injection";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "4";
            objComboBoxItem.DisplayText = "Ointment";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboDosageForm.Items.Clear();
            cboDosageForm.DisplayMember = "DisplayText";
            cboDosageForm.DataSource = ar;
        }
        public static string GetDosageFormText(int intDosageForm)
        {
            if (intDosageForm == 0)
                return "Capsule";
            else if (intDosageForm == 1)
                return "Tablet";
            else if (intDosageForm == 2)
                return "Cream";
            else if (intDosageForm == 3)
                return "Injection";
            else if (intDosageForm == 4)
                return "Ointment";
            else
                return "Tablet";
        }
        //-
        public static void FillDeliveryStatusCombo(ComboBox cboDeliveryStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }
            else
            {
                CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                objCComboBoxItem.ItemData = "-1";
                objCComboBoxItem.DisplayText = "<All>";
                RecordsList.Add(objCComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Pending";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Delivered";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Returned";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboDeliveryStatus.Items.Clear();
            cboDeliveryStatus.DisplayMember = "DisplayText";
            cboDeliveryStatus.DataSource = ar;
        }
        public static string GetDeliveryStatusText(int intDeliveryStatus)
        {
            if (intDeliveryStatus == (int)DeliveryStatus.Pending)
                return "Pending";
            else if (intDeliveryStatus == (int)DeliveryStatus.Delivered)
                return "Delivered";
            else if (intDeliveryStatus == (int)DeliveryStatus.Returned)
                return "Returned";
            else
                return "Pending";
        }
        //-
        public static void FillPurchaseOrderStatusCombo(ComboBox cboPurchaseOrderStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }
            else
            {
                CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                objCComboBoxItem.ItemData = "-1";
                objCComboBoxItem.DisplayText = "<All>";
                RecordsList.Add(objCComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Awaiting Import Permit";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Awaiting Bank Permit";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Awating Dispatch from Supplier";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Awaiting Customs Clearance";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboPurchaseOrderStatus.Items.Clear();
            cboPurchaseOrderStatus.DisplayMember = "DisplayText";
            cboPurchaseOrderStatus.DataSource = ar;
        }
        public static string GetPurchaseOrderStatusText(int intPurchaseOrderStatus)
        {
            if (intPurchaseOrderStatus == (int)PurchaseOrderStatus.AwaitingImportPermit)
                return "Awaiting Import Permit";
            else if (intPurchaseOrderStatus == (int)PurchaseOrderStatus.AwaitingBankPermit)
                return "Awaiting Bank Permit";
            else if (intPurchaseOrderStatus == (int)PurchaseOrderStatus.AwatingDispatchFromSupplier)
                return "Awating Dispatch from Supplier";
            else if (intPurchaseOrderStatus == (int)PurchaseOrderStatus.AWaitingCustomsClearance)
                return "Awaiting Customs Clearance";
            else
                return "Awaiting Import Permit";
        }
        //-
        public static void FillLocalPurchaseOrderStatusCombo(ComboBox cboPurchaseOrderStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }
            else
            {
                CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                objCComboBoxItem.ItemData = "-1";
                objCComboBoxItem.DisplayText = "<All>";
                RecordsList.Add(objCComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Ordered";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Awaiting Delivery";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Delivered";
            RecordsList.Add(objComboBoxItem);


            ArrayList ar = new ArrayList(RecordsList);
            cboPurchaseOrderStatus.Items.Clear();
            cboPurchaseOrderStatus.DisplayMember = "DisplayText";
            cboPurchaseOrderStatus.DataSource = ar;
        }
        public static string GetLocalPurchaseOrderStatusText(int intPurchaseOrderStatus)
        {
            if (intPurchaseOrderStatus == (int)LocalPurchaseOrderStatus.Ordered)
                return "Ordered";
            else if (intPurchaseOrderStatus == (int)LocalPurchaseOrderStatus.AwaitingDelivery)
                return "Awaiting Delivery";
            else if (intPurchaseOrderStatus == (int)LocalPurchaseOrderStatus.Delivered)
                return "Delivered";
            else
                return "Ordered";
        }

        //-
        public static void FillTermsOfPaymentCombo(ComboBox cboTermsOfPayment, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Cash Against Document";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Letter of Credit / LC";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Free of Charge";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboTermsOfPayment.Items.Clear();
            cboTermsOfPayment.DisplayMember = "DisplayText";
            cboTermsOfPayment.DataSource = ar;


        }
        public static string GetTermsOfPaymentText(int intTermsOfPayment)
        {
            if (intTermsOfPayment == 0)
                return "Cash Against Document";
            else if (intTermsOfPayment == 1)
                return "Letter of Credit / LC";
            else if (intTermsOfPayment == 2)
                return "Free of Charge";
            else
                return "Cash Against Document";
        }
        public static void FillTermsOfPaymentLocalCombo(ComboBox cboTermsOfPayment, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Cash";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "4";
            objComboBoxItem.DisplayText = "Check";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "5";
            objComboBoxItem.DisplayText = "Credit";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "6";
            objComboBoxItem.DisplayText = "Post Dated Check";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "7";
            objComboBoxItem.DisplayText = "Factory Delivery";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboTermsOfPayment.Items.Clear();
            cboTermsOfPayment.DisplayMember = "DisplayText";
            cboTermsOfPayment.DataSource = ar;


        }
        public static string GetTermsOfPaymentLocalText(int intTermsOfPayment)
        {
            if (intTermsOfPayment == 3)
                return "Cash";
            else if (intTermsOfPayment == 4)
                return "Check";
            else if (intTermsOfPayment == 5)
                return "Credit";
            else if (intTermsOfPayment == 6)
                return "Post Dated Check";
            else if (intTermsOfPayment == 7)
                return "Factory Delivery";
            else
                return "Cash";
        }

        //-
        public static void FillTermsOfShipmentCombo(ComboBox cboTermsOfShipment, bool blnAddSelect)
        {

            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Cost and Freight";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Free of Charge";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboTermsOfShipment.Items.Clear();
            cboTermsOfShipment.DisplayMember = "DisplayText";
            cboTermsOfShipment.DataSource = ar;

        }
        public static string GetTermsOfShipmentText(int intTermsOfShipment)
        {
            if (intTermsOfShipment == 0)
                return "Cost and Freight";
            else if (intTermsOfShipment == 1)
                return "Free of Charge";
            else
                return "Cost and Freight";
        }
        //-
        public static void FillDispatchCombo(ComboBox cboDispatch, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "By Air";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "By Sea";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboDispatch.Items.Clear();
            cboDispatch.DisplayMember = "DisplayText";
            cboDispatch.DataSource = ar;

        }
        public static string GetDispatchText(int intDispatch)
        {
            if (intDispatch == 0)
                return "By Air";
            else if (intDispatch == 1)
                return "By Sea";
            else
                return "By Air";
        }
        public static string GetDispatchTextForFreight(int intDispatch)
        {
            if (intDispatch == 0)
                return "Air";
            else if (intDispatch == 1)
                return "Sea";
            else
                return "Air";
        }

        //-
        public static void FillMarketStudyStatusCombo(ComboBox cboMarketStudyStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "On Progress";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Canceled";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Approved";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Rejected";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboMarketStudyStatus.Items.Clear();
            cboMarketStudyStatus.DisplayMember = "DisplayText";
            cboMarketStudyStatus.DataSource = ar;

        }
        public static string GetMarketStudyStatusText(int intMarketStudyStatus)
        {
            if (intMarketStudyStatus == 0)
                return "On Progress";
            else if (intMarketStudyStatus == 1)
                return "Canceled";
            else if (intMarketStudyStatus == 2)
                return "Approved";
            else if (intMarketStudyStatus == 3)
                return "Rejected";
            else
                return "On Progress";
        }
        //-
        public static void FillProductRegistrationCertificateStatusCombo(ComboBox cboProductRegistrationCertificateStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Granted";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Denied";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Revoked";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Pending";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboProductRegistrationCertificateStatus.Items.Clear();
            cboProductRegistrationCertificateStatus.DisplayMember = "DisplayText";
            cboProductRegistrationCertificateStatus.DataSource = ar;

        }
        public static string GetProductRegistrationCertificateStatusText(int intProductRegistrationCertificateStatus)
        {
            if (intProductRegistrationCertificateStatus == 0)
                return "Granted";
            else if (intProductRegistrationCertificateStatus == 1)
                return "Denied";
            else if (intProductRegistrationCertificateStatus == 2)
                return "Revoked";
            else if (intProductRegistrationCertificateStatus == 3)
                return "Pending";
            else
                return "Granted";
        }

        //-
        public static void FillStoreTransactionTypeCombo(ComboBox cboStoreTransactionType)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(StoreTransactionType.Receiving).ToString(); ;
            objComboBoxItem.DisplayText = "Receiving";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(StoreTransactionType.Issuance).ToString();
            objComboBoxItem.DisplayText = "Issuance";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(StoreTransactionType.Recall).ToString(); ;
            objComboBoxItem.DisplayText = "Recall";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(StoreTransactionType.Damage).ToString();
            objComboBoxItem.DisplayText = "Damage";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboStoreTransactionType.Items.Clear();
            cboStoreTransactionType.DisplayMember = "DisplayText";
            cboStoreTransactionType.DataSource = ar;

        }
        public static string GetStoreTransactionTypeText(int intInvoiceType)
        {
            if (intInvoiceType == (int)StoreTransactionType.Receiving)
                return "Receiving";
            else if (intInvoiceType == (int)StoreTransactionType.Issuance)
                return "Issuance";
            else if (intInvoiceType == (int)StoreTransactionType.Recall)
                return "Recall";
            else if (intInvoiceType == (int)StoreTransactionType.Damage)
                return "Damage";
            else
                return "Receiving";
        }
        //-
        public static void FillInvoiceTypeCombo(ComboBox cboInvoiceType)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(InvoiceType.CashSales).ToString(); ;
            objComboBoxItem.DisplayText = "Cash Sales";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(InvoiceType.CreditSales).ToString();
            objComboBoxItem.DisplayText = "Credit Sales";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(InvoiceType.FreeOfCharge).ToString();
            objComboBoxItem.DisplayText = "Free of Charge";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboInvoiceType.Items.Clear();
            cboInvoiceType.DisplayMember = "DisplayText";
            cboInvoiceType.DataSource = ar;

        }
        public static void FillInvoiceTypeCombo(ComboBox cboInvoiceType, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }
            else
            {
                CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                objCComboBoxItem.ItemData = "-1";
                objCComboBoxItem.DisplayText = "<All>";
                RecordsList.Add(objCComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(InvoiceType.CashSales).ToString(); ;
            objComboBoxItem.DisplayText = "Cash Sales";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(InvoiceType.CreditSales).ToString();
            objComboBoxItem.DisplayText = "Credit Sales";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(InvoiceType.FreeOfCharge).ToString();
            objComboBoxItem.DisplayText = "Free of Charge";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboInvoiceType.Items.Clear();
            cboInvoiceType.DisplayMember = "DisplayText";
            cboInvoiceType.DataSource = ar;

        }

        public static string GetInvoiceTypeText(int intInvoiceType)
        {
            if (intInvoiceType == (int)InvoiceType.CashSales)
                return "Cash Sales";
            else if (intInvoiceType == (int)InvoiceType.CreditSales)
                return "Credit Sales";
            else if (intInvoiceType == (int)InvoiceType.FreeOfCharge)
                return "Free of Charge";
            else
                return "Cash Sales";
        }
        //-
        public static void FillPaymentSettlementCombo(ComboBox cboSettlementStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }
            else
            {
                CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                objCComboBoxItem.ItemData = "-1";
                objCComboBoxItem.DisplayText = "<All>";
                RecordsList.Add(objCComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(PaymentSettlement.NotSettled).ToString(); ;
            objComboBoxItem.DisplayText = "Not Settled";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(PaymentSettlement.Settled).ToString();
            objComboBoxItem.DisplayText = "Settled";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboSettlementStatus.Items.Clear();
            cboSettlementStatus.DisplayMember = "DisplayText";
            cboSettlementStatus.DataSource = ar;

        }
        public static string GetPaymentSettlementText(int intSettlementStatus)
        {
            if (intSettlementStatus == (int)PaymentSettlement.NotSettled)
                return "Not Settled";
            else if (intSettlementStatus == (int)PaymentSettlement.Settled)
                return "Settled";
            else
                return "Not Settled";
        }
        //-
        public static void FillCheckStatusCombo(ComboBox cboCheckStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }
            else
            {
                CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                objCComboBoxItem.ItemData = "-1";
                objCComboBoxItem.DisplayText = "<All>";
                RecordsList.Add(objCComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(CheckStatus.NotCashed).ToString(); ;
            objComboBoxItem.DisplayText = "Not Cashed";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToInt32(CheckStatus.Cashed).ToString();
            objComboBoxItem.DisplayText = "Cashed";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboCheckStatus.Items.Clear();
            cboCheckStatus.DisplayMember = "DisplayText";
            cboCheckStatus.DataSource = ar;

        }
        public static string GetCheckStatusText(int intCheckStatus)
        {
            if (intCheckStatus == (int)CheckStatus.NotCashed)
                return "Not Cashed";
            else if (intCheckStatus == (int)CheckStatus.Cashed)
                return "Cashed";
            else
                return "Not Cashed";
        }
        //-
        public static void FillPaymentTypeCombo(ComboBox cboPaymentType)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToString((int)PaymentType.Cash);
            objComboBoxItem.DisplayText = "Cash";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToString((int)PaymentType.Check);
            objComboBoxItem.DisplayText = "Check";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = Convert.ToString((int)PaymentType.CPO);
            objComboBoxItem.DisplayText = "CPO";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboPaymentType.Items.Clear();
            cboPaymentType.DisplayMember = "DisplayText";
            cboPaymentType.DataSource = ar;

        }
        public static string GetPaymentTypeText(int intPaymentType)
        {
            if (intPaymentType == (int)PaymentType.Cash)
                return "Cash";
            else if (intPaymentType == (int)PaymentType.Check)
                return "Check";
            else if (intPaymentType == (int)PaymentType.CPO)
                return "CPO";
            else
                return "Cash";
        }

        //-
        public static void FillPaymentReasonCombo(ComboBox cboPaymentReason, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Transportation";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Labour";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Other";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboPaymentReason.Items.Clear();
            cboPaymentReason.DisplayMember = "DisplayText";
            cboPaymentReason.ValueMember = "ItemData";
            cboPaymentReason.DataSource = ar;

        }
        public static void FillPaymentReasonCombo(DataGridViewComboBoxColumn cboPaymentReason, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Transportation";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Labour";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Other";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboPaymentReason.Items.Clear();
            cboPaymentReason.DisplayMember = "DisplayText";
            cboPaymentReason.ValueMember = "ItemData";
            cboPaymentReason.DataSource = ar;

        }
        public static string GetPaymentReasonText(int intPaymentReason)
        {
            if (intPaymentReason == 0)
                return "Transportation";
            else if (intPaymentReason == 1)
                return "Labour";
            else if (intPaymentReason == 2)
                return "Other";
            else
                return "Transportation";
        }

        //-
        public static void FillFillSexCombo(ComboBox cboFillSex)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Male";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Female";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboFillSex.Items.Clear();
            cboFillSex.DisplayMember = "DisplayText";
            cboFillSex.DataSource = ar;

        }
        public static string GetFillSexText(int intFillSex)
        {
            if (intFillSex == 0)
                return "Male";
            else if (intFillSex == 1)
                return "Female";
            else
                return "Male";
        }
        //-
        public static void FillRegionCombo(ComboBox cboFillRegionCombo)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Tigray";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Afar";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Amhara";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "4";
            objComboBoxItem.DisplayText = "Oromia";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "5";
            objComboBoxItem.DisplayText = "SNNP";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "6";
            objComboBoxItem.DisplayText = "Somalia";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "7";
            objComboBoxItem.DisplayText = "Benishangul";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "8";
            objComboBoxItem.DisplayText = "Addis Ababa";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboFillRegionCombo.Items.Clear();
            cboFillRegionCombo.DisplayMember = "DisplayText";
            cboFillRegionCombo.DataSource = ar;

        }
        public static void FillRegionComboDG(DataGridViewComboBoxColumn cboFillRegionCombo)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            //objComboBoxItem = new CComboBoxItem();
            //objComboBoxItem.ItemData = "1";
            //objComboBoxItem.DisplayText = "Tigray";
            //RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Afar";
            RecordsList.Add(objComboBoxItem);

            //objComboBoxItem = new CComboBoxItem();
            //objComboBoxItem.ItemData = "3";
            //objComboBoxItem.DisplayText = "Amhara";
            //RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "4";
            objComboBoxItem.DisplayText = "Oromiya";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "5";
            objComboBoxItem.DisplayText = "SNNP";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "6";
            objComboBoxItem.DisplayText = "Somalia";
            RecordsList.Add(objComboBoxItem);

            //objComboBoxItem = new CComboBoxItem();
            //objComboBoxItem.ItemData = "7";
            //objComboBoxItem.DisplayText = "Benishangul";
            //RecordsList.Add(objComboBoxItem);

            //objComboBoxItem = new CComboBoxItem();
            //objComboBoxItem.ItemData = "8";
            //objComboBoxItem.DisplayText = "Addis Ababa";
            //RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboFillRegionCombo.Items.Clear();
            cboFillRegionCombo.DisplayMember = "DisplayText";
            cboFillRegionCombo.DataSource = ar;

        }
        public static string GetFillRegionComboText(int intFillRegionCombo)
        {
            //if (intFillRegionCombo == 1)
            //    return "Tigray";
            //else 
            if (intFillRegionCombo == 2)
                return "Afar";
            //else if (intFillRegionCombo == 3)
            //    return "Amhara";
            else if (intFillRegionCombo == 4)
                return "Oromia";
            else if (intFillRegionCombo == 5)
                return "SNNP";
            else if (intFillRegionCombo == 6)
                return "Somalia";
            //else if (intFillRegionCombo == 7)
            //    return "Benishangul";
            //else if (intFillRegionCombo == 8)
            //    return "Addis Ababa";
            else
                return "Afar";
        }
        //-       
        public static void FillEventTypeCombo(ComboBox cboEventType)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "-1";
            objComboBoxItem.DisplayText = "<Select an Item>";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Insert";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Update";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Delete";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboEventType.Items.Clear();
            cboEventType.DisplayMember = "DisplayText";
            cboEventType.DataSource = ar;

        }
        public static string GetEventTypeText(int intEventType)
        {
            if (intEventType == -1)
                return "<Select an Item>";
            else if (intEventType == 1)
                return "Insert";
            else if (intEventType == 2)
                return "Update";
            else if (intEventType == 3)
                return "Delete";
            else
                return "All";
        }
        //-
        public static void FillMonthCombo(ComboBox cboMonth)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;


            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "July";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "August";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "September ";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "4";
            objComboBoxItem.DisplayText = "October ";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "5";
            objComboBoxItem.DisplayText = "November ";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "6";
            objComboBoxItem.DisplayText = "December   ";
            RecordsList.Add(objComboBoxItem);


            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "7";
            objComboBoxItem.DisplayText = "January";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "8";
            objComboBoxItem.DisplayText = "February";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "9";
            objComboBoxItem.DisplayText = "March";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "10";
            objComboBoxItem.DisplayText = "April";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "11";
            objComboBoxItem.DisplayText = "May";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "12";
            objComboBoxItem.DisplayText = "June";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboMonth.Items.Clear();
            cboMonth.DisplayMember = "DisplayText";
            cboMonth.DataSource = ar;



        }
        public static string GetMonthText(int intMonth)
        {

            if (intMonth == 1)
                return "July";
            else if (intMonth == 2)
                return "August";
            else if (intMonth == 3)
                return "September ";
            else if (intMonth == 4)
                return "October ";
            else if (intMonth == 5)
                return "November ";
            else if (intMonth == 6)
                return "December   ";
            else if (intMonth == 7)
                return "January";
            else if (intMonth == 8)
                return "February";
            else if (intMonth == 9)
                return "March";
            else if (intMonth == 10)
                return "April";
            else if (intMonth == 11)
                return "May";
            else if (intMonth == 12)
                return "June";
            else
                return "July";
        }
        //-       
        public static void FillOperatorCombo(ComboBox cboOperator)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "=";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = ">=";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = ">";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "<=";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "4";
            objComboBoxItem.DisplayText = "<";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboOperator.Items.Clear();
            cboOperator.DisplayMember = "DisplayText";
            cboOperator.DataSource = ar;

        }
        public static string GetOperatorText(int intOperator)
        {
            if (intOperator == 0)
                return "=";
            else if (intOperator == 1)
                return ">=";
            else if (intOperator == 2)
                return ">";
            else if (intOperator == 3)
                return "<=";
            else if (intOperator == 4)
                return "<";
            else
                return "=";
        }
        //-       
        public static void FillOperatorComboBoolean(ComboBox cboOperator)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "=";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboOperator.Items.Clear();
            cboOperator.DisplayMember = "DisplayText";
            cboOperator.DataSource = ar;

        }
        public static string GetOperatorComboBoolean(int intOperator)
        {
            if (intOperator == 0)
                return "=";
            else
                return "=";
        }
        //--
        public static void FillOperatorComboString(ComboBox cboOperator)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "=";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "like";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboOperator.Items.Clear();
            cboOperator.DisplayMember = "DisplayText";
            cboOperator.DataSource = ar;


        }
        public static string GetOperatorComboString(int intOperator)
        {
            if (intOperator == 0)
                return "=";
            else if (intOperator == 1)
                return "like";
            else
                return "=";
        }

        public static void FillColumnBooleanValue(ComboBox cboOperator)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "False";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "True";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboOperator.Items.Clear();
            cboOperator.DisplayMember = "DisplayText";
            cboOperator.DataSource = ar;


        }
        public static string GetColumnBooleanValue(int intOperator)
        {
            if (intOperator == 0)
                return "False";
            else if (intOperator == 1)
                return "True";
            else
                return "False";
        }
        public static void FillUserGroupCombo(ComboBox cboUserGroup)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Kebele User";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Wereda User";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Zone User";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "4";
            objComboBoxItem.DisplayText = "Region User";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboUserGroup.Items.Clear();
            cboUserGroup.DisplayMember = "DisplayText";
            cboUserGroup.DataSource = ar;

        }
        public static string GetUserGroupText(int intUserGroup)
        {
            if (intUserGroup == 1)
                return "Kebele User";
            else if (intUserGroup == 2)
                return "Wereda User";
            else if (intUserGroup == 3)
                return "Zone User";
            else if (intUserGroup == 4)
                return "Region User";
            else
                return "Kebele User";
        }
        public static void FillUserRightCombo(ComboBox cboUserRight)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Read only";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Read Write";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Administrator";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboUserRight.Items.Clear();
            cboUserRight.DisplayMember = "DisplayText";
            cboUserRight.DataSource = ar;

        }
        public static string GetUserRightText(int intUserRight)
        {
            if (intUserRight == 1)
                return "Read only";
            else if (intUserRight == 2)
                return "Read Write";
            else if (intUserRight == 3)
                return "Administrator";
            else
                return "Read only";
        }
        public static void FillSystemApplicationCombo(ComboBox cboSystemApplication)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Administrator";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Sales";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Cashier";
            RecordsList.Add(objComboBoxItem);


            ArrayList ar = new ArrayList(RecordsList);
            cboSystemApplication.Items.Clear();
            cboSystemApplication.DisplayMember = "DisplayText";
            cboSystemApplication.DataSource = ar;

        }
        public static string GetSystemApplicationText(int intSystemApplication)
        {
            if (intSystemApplication == 1)
                return "Administrator";
            else if (intSystemApplication == 2)
                return "Sales";
            else if (intSystemApplication == 3)
                return "Cashier";
            else
                return "Administrator";
        }
        public static bool ExecuteQuery(string strSQL, string strConnectionString)
        {

            SqlConnection connection = new SqlConnection(strConnectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                int _rowsAffected = command.ExecuteNonQuery();
                if (_rowsAffected > 0)
                    return true;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception("CCommon::Execute Query::Error!" + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (command != null) command.Dispose();
            }
        }

        //-
        public static void FillSupplierTypeCombo(ComboBox cboSupplierType)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "-1";
            objComboBoxItem.DisplayText = "<Select Item>";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Exporter";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Local";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboSupplierType.Items.Clear();
            cboSupplierType.DisplayMember = "DisplayText";
            cboSupplierType.DataSource = ar;

        }
        public static string GetSupplierTypeText(int intSupplierType)
        {
            if (intSupplierType == 0)
                return "Exporter";
            else if (intSupplierType == 1)
                return "Local";
            else
                return "<Select Item>";
        }

        //-
        public static void FillTenderTypeCombo(ComboBox cboTenderType, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Local";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "International";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboTenderType.Items.Clear();
            cboTenderType.DisplayMember = "DisplayText";
            cboTenderType.DataSource = ar;
        }
        public static string GetTenderTypeText(int intTenderType)
        {
            if (intTenderType == 0)
                return "Local";
            else if (intTenderType == 1)
                return "International";
            else
                return "Local";
        }

        //-
        public static void FillTenderStatusCombo(ComboBox cboTenderStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Initiated";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "On Progress";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "2";
            objComboBoxItem.DisplayText = "Submitted";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "3";
            objComboBoxItem.DisplayText = "Awarded";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "4";
            objComboBoxItem.DisplayText = "Lost";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "5";
            objComboBoxItem.DisplayText = "Discarded";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboTenderStatus.Items.Clear();
            cboTenderStatus.DisplayMember = "DisplayText";
            cboTenderStatus.DataSource = ar;
        }
        public static string GetTenderStatusText(int intTenderStatus)
        {
            if (intTenderStatus == 0)
                return "Initiated";
            else if (intTenderStatus == 1)
                return "On Progress";
            else if (intTenderStatus == 2)
                return "Submitted";
            else if (intTenderStatus == 3)
                return "Awarded";
            else if (intTenderStatus == 4)
                return "Lost";
            else if (intTenderStatus == 5)
                return "Discarded";
            else
                return "Initiated";
        }

        //-
        public static void FillBidBondStatusCombo(ComboBox cboBidBondStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "On Hold";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Returned";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboBidBondStatus.Items.Clear();
            cboBidBondStatus.DisplayMember = "DisplayText";
            cboBidBondStatus.DataSource = ar;
        }
        public static string GetBidBondStatusText(int intBidBondStatus)
        {
            if (intBidBondStatus == 0)
                return "On Hold";
            else if (intBidBondStatus == 1)
                return "Returned";
            else
                return "On Hold";
        }

        //-
        public static void FillPerformanceBondStatusCombo(ComboBox cboPerformanceBondStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "On Hold";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Returned";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboPerformanceBondStatus.Items.Clear();
            cboPerformanceBondStatus.DisplayMember = "DisplayText";
            cboPerformanceBondStatus.DataSource = ar;
        }
        public static string GetPerformanceBondStatusText(int intPerformanceBondStatus)
        {
            if (intPerformanceBondStatus == 0)
                return "On Hold";
            else if (intPerformanceBondStatus == 1)
                return "Returned";
            else
                return "On Hold";
        }

        //-
        public static void FillTenderCheckListStatusCombo(ComboBox cboTenderCheckListStatus, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "On Preparation";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Ready";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboTenderCheckListStatus.Items.Clear();
            cboTenderCheckListStatus.DisplayMember = "DisplayText";
            cboTenderCheckListStatus.DataSource = ar;
        }
        public static string GetTenderCheckListStatusText(int intTenderCheckListStatus)
        {
            if (intTenderCheckListStatus == 0)
                return "On Preparation";
            else if (intTenderCheckListStatus == 1)
                return "Ready";
            else
                return "On Preparation";
        }

        //-
        public static void FillItemCategoryTypeCombo(ComboBox cboItemCategoryType, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            CComboBoxItem objComboBoxItem;

            if (blnAddSelect)
            {
                objComboBoxItem = new CComboBoxItem();
                objComboBoxItem.ItemData = "-1";
                objComboBoxItem.DisplayText = "<Select an Item>";
                RecordsList.Add(objComboBoxItem);
            }

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "0";
            objComboBoxItem.DisplayText = "Non Psychotropic";
            RecordsList.Add(objComboBoxItem);

            objComboBoxItem = new CComboBoxItem();
            objComboBoxItem.ItemData = "1";
            objComboBoxItem.DisplayText = "Psychotropic";
            RecordsList.Add(objComboBoxItem);

            ArrayList ar = new ArrayList(RecordsList);
            cboItemCategoryType.Items.Clear();
            cboItemCategoryType.DisplayMember = "DisplayText";
            cboItemCategoryType.DataSource = ar;
        }
        public static string GetItemCategoryTypeText(int intItemCategoryType)
        {
            if (intItemCategoryType == 0)
                return "Non Psychotropic";
            else if (intItemCategoryType == 1)
                return "Psychotropic";
            else
                return "Non Psychotropic";
        }

        public static string GetEthiopianDateString(DateTime dteDate)
        {
            CCalConv ethDate = new CCalConv();
            CCalConv.TDay tday = new CCalConv.TDay();
            tday.Day = (long)dteDate.Day;
            tday.Month = (long)dteDate.Month;
            tday.Year = (long)dteDate.Year;
            tday = ethDate.GetEthiopianDay(tday);
            return tday.Day.ToString() + "/" + tday.Month.ToString() + "/" + tday.Year.ToString();
        }

    }

}
