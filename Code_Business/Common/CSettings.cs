using System;
using System.Collections.Generic;
using System.Text;

namespace Pharma
{
    class CSettings
    {

        #region Application Specific

        public static System.Globalization.CultureInfo Culture = new System.Globalization.CultureInfo("en-GB");
        public static System.Globalization.DateTimeStyles DateTimeStyle = new System.Globalization.DateTimeStyles();
        

        // The minimum possible date value in sql server is 1/1/1753 12:00:00 AM
        public static DateTime SQLServerMinDate = Convert.ToDateTime("1/2/1753 12:00:00 AM");
        public static DateTime MinDate = DateTime.MinValue; 
        public static DateTime MaxDate = DateTime.MaxValue;

        public static string DateFormat = "d/M/yyyy";
        public static string TimeFormat = "H:m:ss";
        public static string CurrencyFormat = "#,##0.00";
        public static string NumberFormat = "#,##0";

        public static string SQLDateTimeStyle = "103"; // British/French, use 101 for USA
        public static string SQLTimeStyle = "108"; 

        public static System.Drawing.Font Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        public static System.Drawing.Font FontUnicode = new System.Drawing.Font("Nyala", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        #endregion

        #region Organization

        public static string OrganizationName = "";
        public static string OrganizationAddress = "";
        public static string OrganizationTIN = "";
        public static string OrganizationVAT = "";
        public static string OrganizationFSNumber = "";
        public static string OrganizationMachineRegistrationCode = "";
        public static string OrganizationTelephone = "";
        public static string OrganizationFax = "";
        public static string OrganizationPOBox = "";
        public static byte[] OrganizationLogo = null;

        #endregion

        #region Defaults

        public static string DefaultWorkingLocation = "-1";
        public static string DefaultWorkingStore = "-1";
        public static string DefaultWorkingManufacturer = "-1";

        #endregion

        #region Drug Registration

        public static decimal DrugRegistrationFeePercentagePaidByManufacturer = 0;

        #endregion

        #region Supplier Proforma

        public static int SupplierProformaDispatch = -1;
        public static int SupplierProformaTermsOfShipment = -1;
        public static int SupplierProformaGenerateNotificationNumber = 0;

        #endregion

        #region Purchase Order

        public static int PurchaseOrderGenerateReferenceNumber = 0;
        
        #endregion

        #region Price Calculation

        public static int PriceCalculationAllowPriceRecalculation = 0;

        #endregion

        #region Goods Receiving

        public static string GoodsReceivingLocation = "-1";
        public static string GoodsReceivingStore = "-1";
        public static string GoodsReceivingReceivedBy = "";
        public static string GoodsReceivingCheckedBy = "";
        public static string GoodsReceivingDeliveredBy = "";
        public static int GoodsReceivingGenerateReferenceNumber = 0;

        #endregion

        #region Goods Issuance

        public static string GoodsIssuanceLocation = "-1";
        public static string GoodsIssuanceStore = "-1";
        //public static string GoodsIssuanceIssuedTo = "-1";
        
        public static string GoodsIssuanceIssuedBy = "";
        public static string GoodsIssuanceIssuedTo = "";
        public static string GoodsIssuanceCheckedBy = "";
        public static int GoodsIssuanceGenerateReferenceNumber = 0;

        #endregion

        #region Proforma

        public static string ProformaRequestedBy = "";
        public static string ProformaApprovedBy = "";
        public static int ProformaValidityPeriodLength = 0;
        public static int ProformaGenerateReferenceNumber = 0;

        #endregion

        #region Supplies Requisition

        public static int SuppliesRequisitionRequestorDifferentFromLicensee = 0;
        public static string SuppliesRequisitionRequestedBy = "";
        public static string SuppliesRequisitionApprovedBy = "";
        public static int SuppliesRequisitionGenerateReferenceNumber = 0;

        #endregion

        #region Invoice

        public static int InvoiceInvoiceType = -1;
        public static string InvoicePreparedBy = "";
        public static string InvoiceCheckedBy = "";
        public static string InvoiceApprovedBy = "";
        public static string InvoiceDeliveredBy = "";
        public static string InvoiceReturningReason = "";
        public static int InvoiceGenerateReferenceNumber = 0;
        public static int InvoiceDueDateLength = 0;
        public static double VATPercentage = 0;

        #endregion

        #region Payment Request

        public static int PaymentRequestGenerateReferenceNumber = 0;

        #endregion

        #region Payment Settlement

        public static int PaymentSettlementCheckMaturityDateLength = 0;

        #endregion

        public static void GetSettings()
        {
            try
            {
                CAppSettings CAppSettings = new CAppSettings();

                // Organization
                CSettings.OrganizationName = Convert.ToString(CAppSettings.GetSetting("Pharma", "OrganizationName", ""));
                CSettings.OrganizationAddress = Convert.ToString(CAppSettings.GetSetting("Pharma", "OrganizationAddress", ""));
                CSettings.OrganizationTIN = Convert.ToString(CAppSettings.GetSetting("Pharma", "OrganizationTIN", ""));
                CSettings.OrganizationVAT = Convert.ToString(CAppSettings.GetSetting("Pharma", "OrganizationVAT", ""));
                CSettings.OrganizationFSNumber = Convert.ToString(CAppSettings.GetSetting("Pharma", "OrganizationFSNumber", ""));
                CSettings.OrganizationMachineRegistrationCode = Convert.ToString(CAppSettings.GetSetting("Pharma", "OrganizationMachineRegistrationCode", ""));
                CSettings.OrganizationTelephone = Convert.ToString(CAppSettings.GetSetting("Pharma", "OrganizationTelephone", ""));
                CSettings.OrganizationFax = Convert.ToString(CAppSettings.GetSetting("Pharma", "OrganizationFax", ""));
                CSettings.OrganizationPOBox = Convert.ToString(CAppSettings.GetSetting("Pharma", "OrganizationPOBox", ""));
                CSettings.OrganizationLogo = CAppSettings.GetImageSetting("Pharma", "OrganizationLogo", null);

                // Defaults
                CSettings.DefaultWorkingLocation = CAppSettings.GetSetting("Pharma", "DefaultWorkingLocation", "-1");
                CSettings.DefaultWorkingStore = CAppSettings.GetSetting("Pharma", "DefaultWorkingStore", "-1");
                CSettings.DefaultWorkingManufacturer = CAppSettings.GetSetting("Pharma", "DefaultWorkingManufacturer", "-1");

                // Drug Registration
                CSettings.DrugRegistrationFeePercentagePaidByManufacturer = Convert.ToDecimal(CAppSettings.GetSetting("Pharma", "DrugRegistrationFeePercentagePaidByManufacturer", "50"));

                // Supplier Proforma
                CSettings.SupplierProformaDispatch = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "SupplierProformaDispatch", "0"));
                CSettings.SupplierProformaTermsOfShipment = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "SupplierProformaTermsOfShipment", "0"));
                CSettings.SupplierProformaGenerateNotificationNumber = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "SupplierProformaGenerateNotificationNumber", "1"));

                // Purchase Order
                CSettings.PurchaseOrderGenerateReferenceNumber = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "PurchaseOrderGenerateReferenceNumber", "1"));

                // Price Calculation
                CSettings.PriceCalculationAllowPriceRecalculation = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "PriceCalculationAllowPriceRecalculation", "0"));

                // Goods Receiving
                CSettings.GoodsReceivingLocation = CAppSettings.GetSetting("Pharma", "GoodsReceivingLocation", "-1");
                CSettings.GoodsReceivingStore = CAppSettings.GetSetting("Pharma", "GoodsReceivingStore", "-1");
                CSettings.GoodsReceivingReceivedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "GoodsReceivingReceivedBy", ""));
                CSettings.GoodsReceivingCheckedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "GoodsReceivingCheckedBy", ""));
                CSettings.GoodsReceivingDeliveredBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "GoodsReceivingDeliveredBy", ""));
                CSettings.GoodsReceivingGenerateReferenceNumber = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "GoodsReceivingGenerateReferenceNumber", "1"));

                // Goods Issuance
                CSettings.GoodsIssuanceLocation = CAppSettings.GetSetting("Pharma", "GoodsIssuanceLocation", "-1");
                CSettings.GoodsIssuanceStore = CAppSettings.GetSetting("Pharma", "GoodsIssuanceStore", "-1");
                CSettings.GoodsIssuanceIssuedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "GoodsIssuanceIssuedBy", ""));
                CSettings.GoodsIssuanceIssuedTo = Convert.ToString(CAppSettings.GetSetting("Pharma", "GoodsIssuanceIssuedTo", ""));
                CSettings.GoodsIssuanceCheckedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "GoodsIssuanceCheckedBy", ""));
                CSettings.GoodsIssuanceGenerateReferenceNumber = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "GoodsIssuanceGenerateReferenceNumber", "1"));

                // Proforma
                CSettings.ProformaRequestedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "ProformaRequestedBy", ""));
                CSettings.ProformaApprovedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "ProformaApprovedBy", ""));
                CSettings.ProformaGenerateReferenceNumber = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "ProformaGenerateReferenceNumber", "1"));

                // Supplies Requisition
                CSettings.SuppliesRequisitionRequestorDifferentFromLicensee = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "SuppliesRequisitionRequestorDifferentFromLicensee", "0"));
                CSettings.SuppliesRequisitionRequestedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "SuppliesRequisitionRequestedBy", ""));
                CSettings.SuppliesRequisitionApprovedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "SuppliesRequisitionApprovedBy", ""));
                CSettings.SuppliesRequisitionGenerateReferenceNumber = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "SuppliesRequisitionGenerateReferenceNumber", "1"));

                // Invoice
                CSettings.InvoiceInvoiceType = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "InvoiceInvoiceType", "-1"));
                CSettings.InvoicePreparedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "InvoicePreparedBy", ""));
                CSettings.InvoiceCheckedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "InvoiceCheckedBy", ""));
                CSettings.InvoiceApprovedBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "InvoiceApprovedBy", ""));
                CSettings.InvoiceDeliveredBy = Convert.ToString(CAppSettings.GetSetting("Pharma", "InvoiceDeliveredBy", ""));
                CSettings.InvoiceReturningReason = Convert.ToString(CAppSettings.GetSetting("Pharma", "InvoiceReturningReason", ""));
                CSettings.InvoiceGenerateReferenceNumber = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "InvoiceGenerateReferenceNumber", "1"));
                CSettings.InvoiceDueDateLength = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "InvoiceDueDateLength", "0"));
                CSettings.VATPercentage = Convert.ToDouble(CAppSettings.GetSetting("Pharma", "VATPercentage", "0"));

                // Payment Request
                CSettings.PaymentRequestGenerateReferenceNumber = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "PaymentRequestGenerateReferenceNumber", "1"));

                // Payment Settlement
                CSettings.PaymentSettlementCheckMaturityDateLength = Convert.ToInt32(CAppSettings.GetSetting("Pharma", "PaymentSettlementCheckMaturityDateLength", "0"));
            }
            catch (Exception ex)
            {
                throw new Exception("CSettings::GetSettings::Error! " + ex.Message, ex);
            }
        }

    }
}
