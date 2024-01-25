using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace Pharma
{
    class CCommonListView
    {
        private static decimal GetRowAmount(ListView listView, ColumnHeader columnHeader, int intRowIndex)
        {
            string strAmount = string.Empty;
            decimal decAmount = 0;

            if (listView.Items[intRowIndex].SubItems[columnHeader.Index].Text != string.Empty)
                strAmount = listView.Items[intRowIndex].SubItems[columnHeader.Index].Text.ToString();

            if (strAmount != string.Empty) decAmount = Convert.ToDecimal(strAmount);

            return decAmount;

        }
        private static decimal GetRowAmount(DataGridView dataGridView, string columnHeader, int intRowIndex)
        {
            string strAmount = string.Empty;
            decimal decAmount = 0;

            if (dataGridView.Rows[intRowIndex].Cells[columnHeader].Value != null)
                strAmount = dataGridView.Rows[intRowIndex].Cells[columnHeader].Value.ToString();

            if (strAmount != string.Empty) decAmount = Convert.ToDecimal(strAmount);

            return decAmount;

        }

        private static decimal GetRowAmount(ListView listView, ColumnHeader columnHeader, int intRowIndex, ColumnHeader columnHeaderCondition, string condition)
        {
            string strCondition = string.Empty;
            string strAmount = string.Empty;
            decimal decAmount = 0;

            //if (columnHeader.Index == columnHeaderCondition.Index)
            strCondition = listView.Items[intRowIndex].SubItems[columnHeaderCondition.Index].Text.ToString();

            if (strCondition == condition)
                if (listView.Items[intRowIndex].SubItems[columnHeader.Index].Text != string.Empty)
                    strAmount = listView.Items[intRowIndex].SubItems[columnHeader.Index].Text.ToString();

            if (strAmount != string.Empty) decAmount = Convert.ToDecimal(strAmount);

            return decAmount;

        }
        private static decimal GetRowAmount(DataGridView dataGridView, string columnHeader, int intRowIndex, string columnHeaderCondition, string condition)
        {
            string strCondition = string.Empty;
            string strAmount = string.Empty;
            decimal decAmount = 0;

            //if (columnHeader == columnHeaderCondition)
            strCondition = dataGridView.Rows[intRowIndex].Cells[columnHeaderCondition].Value.ToString();

            if (strCondition == condition)
                if (dataGridView.Rows[intRowIndex].Cells[columnHeader].Value != null)
                    strAmount = dataGridView.Rows[intRowIndex].Cells[columnHeader].Value.ToString();

            if (strAmount != string.Empty) decAmount = Convert.ToDecimal(strAmount);

            return decAmount;

        }

        public static decimal GetListTotal(ListView listView, ColumnHeader columnHeader)
        {
            decimal decTotal = 0;
            decimal decAmount = 0;

            for (int intRowIndex = 0; intRowIndex < listView.Items.Count; intRowIndex++)
            {
                decAmount = GetRowAmount(listView, columnHeader, intRowIndex);
                decTotal = decTotal + decAmount;
            }

            return decTotal;
        }
        public static decimal GetListTotal(DataGridView dataGridView, string columnHeader)
        {
            decimal decTotal = 0;
            decimal decAmount = 0;

            for (int intRowIndex = 0; intRowIndex < dataGridView.RowCount - 1; intRowIndex++)
            {
                decAmount = GetRowAmount(dataGridView, columnHeader, intRowIndex);
                decTotal = decTotal + decAmount;
            }

            return decTotal;
        }

        public static decimal GetListTotal(ListView listView, ColumnHeader columnHeader, ColumnHeader columnHeaderCondition, string condition)
        {
            decimal decTotal = 0;
            decimal decAmount = 0;

            for (int intRowIndex = 0; intRowIndex < listView.Items.Count; intRowIndex++)
            {
                decAmount = GetRowAmount(listView, columnHeader, intRowIndex, columnHeaderCondition, condition);
                decTotal = decTotal + decAmount;
            }

            return decTotal;
        }
        public static decimal GetListTotal(DataGridView dataGridView, string columnHeader, string columnHeaderCondition, string condition)
        {
            decimal decTotal = 0;
            decimal decAmount = 0;

            for (int intRowIndex = 0; intRowIndex < dataGridView.RowCount - 1; intRowIndex++)
            {
                decAmount = GetRowAmount(dataGridView, columnHeader, intRowIndex, columnHeaderCondition, condition);
                decTotal = decTotal + decAmount;
            }

            return decTotal;
        }

        public static decimal GetRowTotalPrice(ListView listView, ColumnHeader columnHeaderQuantity, ColumnHeader columnHeaderUnitPrice, int intRowIndex)
        {
            string strQuantity = string.Empty;
            string strUnitPrice = string.Empty;

            decimal decQuantity = 0;
            decimal decUnitPrice = 0;
            decimal decTotalPrice = 0;

            if (listView.Items[intRowIndex].SubItems[columnHeaderQuantity.Index].Text != string.Empty)
                strQuantity = listView.Items[intRowIndex].SubItems[columnHeaderQuantity.Index].Text.ToString();

            if (listView.Items[intRowIndex].SubItems[columnHeaderUnitPrice.Index].Text != string.Empty)
                strUnitPrice = listView.Items[intRowIndex].SubItems[columnHeaderUnitPrice.Index].Text.ToString();

            if (strQuantity != string.Empty) decQuantity = Convert.ToDecimal(strQuantity);
            if (strUnitPrice != string.Empty) decUnitPrice = Convert.ToDecimal(strUnitPrice);

            decTotalPrice = decQuantity * decUnitPrice;

            return decTotalPrice;

        }
        public static decimal GetRowTotalPrice(DataGridView dataGridView, string columnHeaderQuantity, string columnHeaderUnitPrice, int intRowIndex)
        {
            string strQuantity = string.Empty;
            string strUnitPrice = string.Empty;

            decimal decQuantity = 0;
            decimal decUnitPrice = 0;
            decimal decTotalPrice = 0;

            if (dataGridView.Rows[intRowIndex].Cells[columnHeaderQuantity].Value != null)
                strQuantity = dataGridView.Rows[intRowIndex].Cells[columnHeaderQuantity].Value.ToString();

            if (dataGridView.Rows[intRowIndex].Cells[columnHeaderUnitPrice].Value != null)
                strUnitPrice = dataGridView.Rows[intRowIndex].Cells[columnHeaderUnitPrice].Value.ToString();

            if (strQuantity != string.Empty) decQuantity = Convert.ToDecimal(strQuantity);
            if (strUnitPrice != string.Empty) decUnitPrice = Convert.ToDecimal(strUnitPrice);

            decTotalPrice = decQuantity * decUnitPrice;

            return decTotalPrice;

        }

        public static decimal GetListTotalPrice(ListView listView, ColumnHeader columnHeaderQuantity, ColumnHeader columnHeaderUnitPrice)
        {
            decimal decTotal = 0;
            decimal decAmount = 0;

            for (int intRowIndex = 0; intRowIndex < listView.Items.Count; intRowIndex++)
            {
                decAmount = GetRowTotalPrice(listView, columnHeaderQuantity, columnHeaderUnitPrice, intRowIndex);
                decTotal = decTotal + decAmount;
            }

            return decTotal;
        }
        public static decimal GetListTotalPrice(DataGridView dataGridView, string columnHeaderQuantity, string columnHeaderUnitPrice)
        {
            decimal decTotal = 0;
            decimal decAmount = 0;

            for (int intRowIndex = 0; intRowIndex < dataGridView.RowCount - 1; intRowIndex++)
            {
                decAmount = GetRowTotalPrice(dataGridView, columnHeaderQuantity, columnHeaderUnitPrice, intRowIndex);
                decTotal = decTotal + decAmount;
            }

            return decTotal;
        }

    }
}
