//-
using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Configuration;

namespace Pharma
{
    class CComboBoxItem : Object
    {
        string _ConnectionString = string.Empty;
        private string ConnectionString
        {
            get
            {

                return  Pharma.Properties.Settings.Default.ConnectionString;
            }
        }
        public CComboBoxItem()
        {
            _ConnectionString = ConnectionString;
        }
        public CComboBoxItem(string ItemData, string DisplayText)
        {
            _item_data = ItemData;
            _display_text = DisplayText;
        }

        #region Class Property Declarations
        string _item_data;
        public string ItemData
        {
            get { return _item_data; }
            set { _item_data = value; }
        }

        string _display_text;
        public string DisplayText
        {
            get { return _display_text; }
            set { _display_text = value; }
        }
        #endregion

        //-
        public List<CComboBoxItem> GetList(string strSQL, string strItemDataField, string strDisplayTextField)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                    if (dr[strItemDataField].Equals(DBNull.Value))
                        objCComboBoxItem.ItemData = String.Empty;
                    else
                        objCComboBoxItem.ItemData = Convert.ToString(dr[strItemDataField]);
                    if (dr[strDisplayTextField].Equals(DBNull.Value))
                        objCComboBoxItem.DisplayText = String.Empty;
                    else
                        objCComboBoxItem.DisplayText = Convert.ToString(dr[strDisplayTextField]);

                    RecordsList.Add(objCComboBoxItem);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CComboBoxItem::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }
        public List<CComboBoxItem> GetList(string strSQL, string strItemDataField, string strDisplayTextField, bool blnAddSelect)
        {
            List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();
            SqlConnection connection = new SqlConnection(_ConnectionString);
            SqlDataReader dr = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = strSQL;
            command.CommandType = CommandType.Text;
            command.Connection = connection;

            try
            {
                connection.Open();
                dr = command.ExecuteReader();

                if (blnAddSelect)
                {
                    CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                    objCComboBoxItem.ItemData = "-1";
                    objCComboBoxItem.DisplayText = "<Select an Item>";
                    RecordsList.Add(objCComboBoxItem);
                }
                else
                {
                    CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                    objCComboBoxItem.ItemData = "-1";
                    objCComboBoxItem.DisplayText = "<All>";
                    RecordsList.Add(objCComboBoxItem);
                }

                while (dr.Read())
                {
                    CComboBoxItem objCComboBoxItem = new CComboBoxItem();
                    if (dr[strItemDataField].Equals(DBNull.Value))
                        objCComboBoxItem.ItemData = String.Empty;
                    else
                        objCComboBoxItem.ItemData = Convert.ToString(dr[strItemDataField]);
                    if (dr[strDisplayTextField].Equals(DBNull.Value))
                        objCComboBoxItem.DisplayText = String.Empty;
                    else
                        objCComboBoxItem.DisplayText = Convert.ToString(dr[strDisplayTextField]);

                    RecordsList.Add(objCComboBoxItem);
                }

                return RecordsList;
            }
            catch (Exception ex)
            {
                throw new Exception("CComboBoxItem::GetList::Error! " + ex.Message, ex);
            }
            finally
            {
                if (connection != null) connection.Close();
                if (dr != null) dr.Close();
                if (command != null) command.Dispose();
            }
        }

        //public List<CComboBoxItem> GetList(ArrayList arl, string strItemDataField, string strDisplayTextField)
        //{
        //    List<CComboBoxItem> RecordsList = new List<CComboBoxItem>();

        //    try
        //    {
        //        foreach (CCountries obj in arl)
        //        {
        //            CComboBoxItem objCComboBoxItem = new CComboBoxItem();
        //            objCComboBoxItem.ItemData = Convert.ToString(obj.Id);
        //            objCComboBoxItem.DisplayText = Convert.ToString(obj.Name);

        //            RecordsList.Add(objCComboBoxItem);
        //        }

        //        return RecordsList;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("CComboBoxItem::GetList::Error! " + ex.Message, ex);
        //    }
        //}

    }
}
