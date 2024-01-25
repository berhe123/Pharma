using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;

namespace Pharma
{
    class CPriceAnalysis
    {
        private static decimal GetTotalUnitPrice(string Purchaseorderguid)
        {
            CPurchaseOrderDetails purchaseOrderDetail = new CPurchaseOrderDetails();
            ArrayList ar = new ArrayList(purchaseOrderDetail.GetList(Purchaseorderguid));

            decimal totalUnitPrice = 0;

            if (ar.Count < 0) return totalUnitPrice;

            foreach (CPurchaseOrderDetails pod in ar)
            {
                totalUnitPrice += pod.Priceperunit;
            }

            return totalUnitPrice;
        }
        private static decimal GetTotalLocalUnitPrice(string Purchaseorderguid)
        {
            CLocalPurchaseOrderDetails purchaseOrderDetail = new CLocalPurchaseOrderDetails();
            ArrayList ar = new ArrayList(purchaseOrderDetail.GetList(Purchaseorderguid));

            decimal totalUnitPrice = 0;

            if (ar.Count < 0) return totalUnitPrice;

            foreach (CLocalPurchaseOrderDetails pod in ar)
            {
                totalUnitPrice += pod.Priceperunit;
            }

            return totalUnitPrice;
        }
        private static decimal GetInsurancePayments(string Purchaseorderguid)
        {
            CPurchaseOrderInsurances insurancePayment = new CPurchaseOrderInsurances();
            ArrayList ar = new ArrayList(insurancePayment.GetList(Purchaseorderguid));

            decimal totalInsurancePayment = 0;

            if (ar.Count < 0) return totalInsurancePayment;

            foreach (CPurchaseOrderInsurances ip in ar)
            {
                totalInsurancePayment += ip.Amount;
            }

            return totalInsurancePayment;
        }
        private static decimal GetBankPayments(string Purchaseorderguid)
        {
            CPurchaseOrderBanks bankPayment = new CPurchaseOrderBanks();
            ArrayList ar = new ArrayList(bankPayment.GetList(Purchaseorderguid));

            decimal totalBankPayment = 0;

            if (ar.Count < 0) return totalBankPayment;

            foreach (CPurchaseOrderBanks bp in ar)
            {
                totalBankPayment += bp.Servicecharge;
            }

            return totalBankPayment;
        }
        private static decimal GetOtherPayments(string Purchaseorderguid)
        {
            CPurchaseOrderPayments otherPayment = new CPurchaseOrderPayments();
            ArrayList ar = new ArrayList(otherPayment.GetList(Purchaseorderguid));

            decimal totalOtherPayment = 0;

            if (ar.Count < 0) return totalOtherPayment;

            foreach (CPurchaseOrderPayments op in ar)
            {
                totalOtherPayment += op.Amount;
            }

            return totalOtherPayment;
        }
        private static decimal GetOtherLocalPayments(string Purchaseorderguid)
        {
            CLocalPurchaseOrderPayments otherPayment = new CLocalPurchaseOrderPayments();
            ArrayList ar = new ArrayList(otherPayment.GetList(Purchaseorderguid));

            decimal totalOtherPayment = 0;

            if (ar.Count < 0) return totalOtherPayment;

            foreach (CLocalPurchaseOrderPayments op in ar)
            {
                totalOtherPayment += op.Amount;
            }

            return totalOtherPayment;
        }

        public static void CalculatePrice(string Purchaseorderguid)
        {
            CPurchaseOrders purchaseOrder = new CPurchaseOrders();
            CPurchaseOrderDetails purchaseOrderDetail = new CPurchaseOrderDetails();
            CBatchs batch = new CBatchs();

            purchaseOrder.Id = CPurchaseOrders.GetTableRowId(Purchaseorderguid);
            DataTable dtPurchaseOrder = purchaseOrder.GetRecord();

            ArrayList arPurchaseOrderDetail = new ArrayList(purchaseOrderDetail.GetList(Purchaseorderguid));
            ArrayList arBatch;

            decimal numberOfBatches = 0;
            decimal profitMargin = 0;

            decimal exchangeRate = 1;
            decimal totalUnitPrice = 0;
            decimal freight = 0;
            decimal insurancePayment = 0;
            decimal bankPayment = 0;
            decimal otherPayment = 0;

            decimal unitPrice = 0;
            decimal quantity = 0;

            exchangeRate = purchaseOrder.ExchangeRate;
            if (exchangeRate == 0) exchangeRate = 1;

            totalUnitPrice = GetTotalUnitPrice(Purchaseorderguid) * exchangeRate;
            freight = purchaseOrder.Freightcharge * exchangeRate;
            insurancePayment = GetInsurancePayments(Purchaseorderguid);
            bankPayment = GetBankPayments(Purchaseorderguid);
            otherPayment = GetOtherPayments(Purchaseorderguid);

            foreach (CPurchaseOrderDetails pod in arPurchaseOrderDetail)
            {
                arBatch = new ArrayList(batch.GetList(Purchaseorderguid, pod.Itemguid, (int)CCommon.SupplierType.Exporter));
                numberOfBatches = arBatch.Count;

                profitMargin = CItems.GetProfitMargin(pod.Itemguid);
                unitPrice = pod.Priceperunit * exchangeRate;
                quantity = pod.Quantity;

                foreach (CBatchs ba in arBatch)
                {

                    ba.ExchangeRate = exchangeRate;

                    unitPrice = pod.Priceperunit * exchangeRate;
                    quantity = ba.Quantity;

                    // Avoid division by zero
                    if (totalUnitPrice > 0)
                    {
                        // Get proportional values
                        ba.Insurancepayments = insurancePayment * unitPrice / totalUnitPrice;
                        ba.Bankpayments = bankPayment * unitPrice / totalUnitPrice;
                        ba.Otherpayments = otherPayment * unitPrice / totalUnitPrice;
                        ba.Freightpayments = freight * unitPrice / totalUnitPrice;
                    }

                    // Avoid division by zero
                    if (quantity > 0)
                    {
                        // Change the proportional values to unit values
                        ba.Insurancepayments = ba.Insurancepayments / pod.Quantity;
                        ba.Bankpayments = ba.Bankpayments / pod.Quantity;
                        ba.Otherpayments = ba.Otherpayments / pod.Quantity;
                        ba.Freightpayments = ba.Freightpayments / pod.Quantity;
                    }

                    // Get profit margin
                    ba.ProfitMargin = profitMargin;
                    // Item cost per unit
                    ba.Suggestedsaleprice = unitPrice;
                    // Add Other costs to the unit cost
                    ba.Suggestedsaleprice += ba.Freightpayments + ba.Insurancepayments + ba.Bankpayments + ba.Otherpayments;
                    // After the Total cost is determined 
                    // add the profit margin
                    ba.Suggestedsaleprice += ba.Suggestedsaleprice * profitMargin / 100;
                    ba.Saleprice = ba.Suggestedsaleprice;

                    ba.Update();

                }
            }

        }
        public static void CalculateLocalPrice(string Purchaseorderguid)
        {
            CLocalPurchaseOrders purchaseOrder = new CLocalPurchaseOrders();
            CLocalPurchaseOrderDetails purchaseOrderDetail = new CLocalPurchaseOrderDetails();
            CBatchs batch = new CBatchs();

            purchaseOrder.Id = CLocalPurchaseOrders.GetTableRowId(Purchaseorderguid);
            DataTable dtPurchaseOrder = purchaseOrder.GetRecord();

            ArrayList arPurchaseOrderDetail = new ArrayList(purchaseOrderDetail.GetList(Purchaseorderguid));
            ArrayList arBatch;

            decimal numberOfBatches = 0;
            decimal profitMargin = 0;

            decimal exchangeRate = 1;
            decimal totalUnitPrice = 0;
            decimal freight = 0;

            decimal otherPayment = 0;

            decimal unitPrice = 0;
            decimal quantity = 0;

            exchangeRate = 1;
            totalUnitPrice = GetTotalLocalUnitPrice(Purchaseorderguid) * exchangeRate;
            freight = 0 * exchangeRate;

            otherPayment = GetOtherLocalPayments(Purchaseorderguid);

            foreach (CLocalPurchaseOrderDetails pod in arPurchaseOrderDetail)
            {
                arBatch = new ArrayList(batch.GetList(Purchaseorderguid, pod.Itemguid, (int)CCommon.SupplierType.Local));
                numberOfBatches = arBatch.Count;

                profitMargin = CItems.GetProfitMargin(pod.Itemguid);
                unitPrice = pod.Priceperunit;
                quantity = pod.Quantity;

                foreach (CBatchs ba in arBatch)
                {

               
                    unitPrice = pod.Priceperunit;
                    quantity = ba.Quantity;

                    // Avoid division by zero
                    if (totalUnitPrice > 0)
                    {
                        // Get proportional values                       
                        ba.Otherpayments = otherPayment * unitPrice / totalUnitPrice;
                        //ba.Freightpayments = freight * unitPrice / totalUnitPrice;
                    }

                    // Avoid division by zero
                    if (quantity > 0)
                    {
                        // Change the proportional values to unit values                      
                        ba.Otherpayments = ba.Otherpayments / pod.Quantity;
                        //ba.Freightpayments = ba.Freightpayments / pod.Quantity;
                    }

                    // Get profit margin
                    ba.ProfitMargin = profitMargin;
                    // Item cost per unit
                    ba.Suggestedsaleprice = unitPrice;
                    // Add Other costs to the unit cost
                    ba.Suggestedsaleprice += ba.Otherpayments;
                    // After the Total cost is determined 
                    // add the profit margin
                    ba.Suggestedsaleprice += ba.Suggestedsaleprice * profitMargin / 100;
                    if(ba.Saleprice <= 0)
                        ba.Saleprice = ba.Suggestedsaleprice;

                    ba.Update();

                }
            }

        }
    }
}
