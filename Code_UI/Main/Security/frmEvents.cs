//
// ...
// Wizard generated code
// Date: 2/25/2010 9:43:02 AM
// Class: frmEvents
// NB: No designer code is generated here
//     so you have to design your form
//     with the control names given here
//     so that you don't have to edit this code
// Control Name Assignment is shown below 
//     Prefix ClassName FieldName 
//     ClassName: Table Name stripped of unwanted table prefixes
//     Prefix: txt = TextBox
//     Prefix: cbo = ComboBox
//     Prefix: chk = CheckBox
//     Prefix: dt  = DatePicker
//     Prefix: col = ListViewColumn
//     Example: 
//         Table Name: tblPerson
//         Class Name: Person
//         Field Name: first_name
//         Control: TextBox
//         Control Name: txtPersonFirstName 
// ...
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Pharma
{
    public partial class frmEvents : Form
    {
      
        private int EventsId = 0;
     

        public frmEvents()
        {
            InitializeComponent();
        }
       
        private void NewEvents()
        {
            //try
            //{
            //    bNewEvents = true;
            //    EventsId = 0;
            //    cboEventsTablename.SelectedIndex = -1;
            //    txtEventsTableidfieldname.Text = String.Empty;
            //    txtEventsTableid.Text = String.Empty;
            //    txtEventsUserid.Text = String.Empty;
            //    txtEventsUsername.Text = String.Empty;
            //    txtEventsEventdate.Text = String.Empty;
            //    txtEventsEventtime.Text = String.Empty;
            //    txtEventsEventtype.Text = String.Empty;
            //    txtEventsSearchfield.Text = String.Empty;
            //    txtEventsSearchvalue.Text = String.Empty;
            //    txtEventsComputername.Text = String.Empty;
            //    txtEventsTablefields.Text = String.Empty;
            //    txtEventsDatafrom.Text = String.Empty;
            //    txtEventsDatato.Text = String.Empty;
            //    txtEventsRestored.Text = String.Empty;
            //    txtEventsMerged.Text = String.Empty;
            //    txtEventsTablerowguid.Text = String.Empty;

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

        }

        private void FillEventsList(string strCriteria)
        {
            try
            {

                CEvents objEvents = new CEvents();

                ArrayList ar = new ArrayList(objEvents.GetList(strCriteria));
                this.lvwEvents.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CEvents Events in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      Events.Id.ToString(), 
                                                                                      Events.Tablename.ToString(), 
                                                                                      Events.Tableidfieldname.ToString(), 
                                                                                      Events.Tableid.ToString(), 
                                                                                      Events.Userid.ToString(), 
                                                                                      Events.Username.ToString(), 
                                                                                      Events.Eventdate.ToString(CSettings.DateFormat), 
                                                                                      Events.Eventtime.ToString(CSettings.TimeFormat), 
                                                                                      Events.Eventtype.ToString(), 
                                                                                      Events.Searchfield.ToString(), 
                                                                                      Events.Searchvalue.ToString(), 
                                                                                      Events.Computername.ToString(),                                                                                      
                                                                                      Events.Restored.ToString(), 
                                                                                      Events.Merged.ToString(), 
                                                                                      Events.Tablerowguid.ToString()});
                    this.lvwEvents.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillEventsList(string strCriteria,CCommon.ColumnCriteria [] strCriteriaColumn)
        {
            try
            {

                CEvents objEvents = new CEvents();

                ArrayList ar = new ArrayList(objEvents.GetList(strCriteria, strCriteriaColumn));
                this.lvwEvents.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CEvents Events in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      Events.Id.ToString(), 
                                                                                      Events.Tablename.ToString(), 
                                                                                      Events.Tableidfieldname.ToString(), 
                                                                                      Events.Tableid.ToString(), 
                                                                                      Events.Userid.ToString(), 
                                                                                      Events.Username.ToString(), 
                                                                                      Events.Eventdate.ToString(CSettings.DateFormat), 
                                                                                      Events.Eventtime.ToString(CSettings.TimeFormat), 
                                                                                      Events.Eventtype.ToString(), 
                                                                                      Events.Searchfield.ToString(), 
                                                                                      Events.Searchvalue.ToString(), 
                                                                                      Events.Computername.ToString(),                                                                                       
                                                                                      Events.Restored.ToString(), 
                                                                                      Events.Merged.ToString(), 
                                                                                      Events.Tablerowguid.ToString()});
                    this.lvwEvents.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmEvents_Load(object sender, EventArgs e)
        {
            lblMsg.Text = null;
            CCommon.FillEventTypeCombo(cboEventType);
            CCommon.FillComboBox(cboEventsTablename, "Select id,name from sysobjects where type='U' order by name ", "id", "name", true);
           
            EventDateChecked();
            EventTimeChecked();
        }
        private void frmEvents_Activated(object sender, EventArgs e)
        {
         
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
        private void btnNewEvents_Click(object sender, EventArgs e)
        {

            EventsId = 0;
            NewEvents();
        }
        private void lvwEvents_DoubleClick(object sender, EventArgs e)
        {
            ShowEventData();
        }
        private void lvwEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwEvents.SelectedItems.Count > 0)
                ShowEventData();
        }

        private void cboEventsTablename_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEventsTablename.SelectedIndex > 0)
            {
                CCommon.FillComboBox(cboTableCurrentFields, "Select xtype,name from syscolumns where id= " + Convert.ToInt32(CCommon.GetItemData(cboEventsTablename)), "xtype", "name");
                ClearColumnCriteria();
                CEvents objEvent = new CEvents();
                txtEventsSearchfield.Text = objEvent.GetSearchField(CCommon.GetDisplayText(cboEventsTablename));
            }
        }
        private void ClearColumnCriteria()
        {
            txtColumnType.Text = "";
            txtColumnValueField.Text = "";
            lvwColumnCriteria.Items.Clear();
        }
        private void chkEventDate_CheckedChanged(object sender, EventArgs e)
        {
            EventDateChecked();

        }
        private void EventDateChecked()
        {
            try
            {
                if (chkEventDate.Checked)
                {
                    grbEventDate.Enabled = true;
                    txtEventsEventdatefrom.Text = DateTime.Today.ToString(CSettings.DateFormat);
                    txtEventsEventdateto.Text = DateTime.Today.ToString(CSettings.DateFormat);
                }
                else
                {
                    grbEventDate.Enabled = false;
                    txtEventsEventdatefrom.Text = "";
                    txtEventsEventdateto.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error on Date!!! " + ex.Message);
            }
        }
        private void chkEventTime_CheckedChanged(object sender, EventArgs e)
        {
            EventTimeChecked();
        }
        private void EventTimeChecked()
        {
            try
            {
                if (chkEventTime.Checked)
                {
                    grbEventTime.Enabled = true;
                    txtEventsEventtimefrom.Text = DateTime.Now.ToString(CSettings.TimeFormat);
                    txtEventsEventtimeto.Text = DateTime.Now.ToString(CSettings.TimeFormat);
                }
                else
                {
                    grbEventTime.Enabled = false;
                    txtEventsEventtimefrom.Text = "";
                    txtEventsEventtimeto.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor Event Time " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboTableCurrentFields.SelectedIndex != -1 & (txtColumnValueField.Text != "" | cboColumnValue.SelectedIndex != -1) )
                AddSelectedItem();
        }
        private bool AddSelectedItem()
        {
            int intType = Convert.ToInt32(CCommon.GetItemData(cboTableCurrentFields));
            double dblValue;
            long intValue; 
            bool blnValue;
            DateTime dteValue;
            if (intType == 62 | intType == 106) //float or decimal
            {
                if (!double.TryParse(txtColumnValueField.Text, out dblValue))
                    return false;            
            }
            else if (intType == 56 | intType == 127) //int  or bigint
            {
                if (!long.TryParse(txtColumnValueField.Text, out intValue))
                    return false;
            }
            else if (intType == 104) //bool
            {
                if (!bool.TryParse(CCommon.GetDisplayText(cboColumnValue), out blnValue))
                    return false;
            }
            else if (intType == 61) //Date Time
            {
                if (!DateTime.TryParse(txtColumnValueField.Text, out dteValue))
                    return false;
            }
            ListViewItem item;
            if(intType == 104) //bool
                item = new ListViewItem(new string[] { CCommon.GetDisplayText(cboTableCurrentFields), CCommon.GetDisplayText(cboOperator), CCommon.GetDisplayText(cboColumnValue), CCommon.GetItemData(cboTableCurrentFields) });
            else
                item = new ListViewItem(new string[] { CCommon.GetDisplayText(cboTableCurrentFields), CCommon.GetDisplayText(cboOperator), txtColumnValueField.Text, CCommon.GetItemData(cboTableCurrentFields) });
            lvwColumnCriteria.Items.Add(item);
            return true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvwColumnCriteria.SelectedItems.Count > 0)
                lvwColumnCriteria.SelectedItems[0].Remove();
           
        }

        private void cboTableCurrentFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTableCurrentFields.SelectedIndex != -1)
            {
                switch (Convert.ToInt32(CCommon.GetItemData(cboTableCurrentFields)))
                {
                    case 104:
                        txtColumnType.Text = "Boolean";
                        cboOperator.DataSource = null;
                        CCommon.FillOperatorComboBoolean(cboOperator);
                        CCommon.FillColumnBooleanValue(cboColumnValue);
                        txtColumnValueField.Visible = false;
                        cboColumnValue.Visible = true;
                        break;
                    case 61:
                        txtColumnType.Text = "Date or Time";
                        cboOperator.DataSource = null;
                        CCommon.FillOperatorCombo(cboOperator);
                        txtColumnValueField.Visible = true;
                        cboColumnValue.Visible = false;
                        break;
                    case 56:
                        txtColumnType.Text = "Numeric";
                        cboOperator.DataSource = null;
                        CCommon.FillOperatorCombo(cboOperator);
                        txtColumnValueField.Visible = true;
                        cboColumnValue.Visible = false;
                        break;
                    case 127:
                        txtColumnType.Text = "Numeric";
                        cboOperator.DataSource = null;
                        CCommon.FillOperatorCombo(cboOperator);
                        txtColumnValueField.Visible = true;
                        cboColumnValue.Visible = false;
                        break;
                    case 62:
                        txtColumnType.Text = "Decimal";
                        cboOperator.DataSource = null;
                        CCommon.FillOperatorCombo(cboOperator);
                        txtColumnValueField.Visible = true;
                        cboColumnValue.Visible = false;
                        break;
                    case 106:
                        txtColumnType.Text = "Decimal";
                        cboOperator.DataSource = null;
                        CCommon.FillOperatorCombo(cboOperator);
                        txtColumnValueField.Visible = true;
                        cboColumnValue.Visible = false;
                        break;
                    default:
                        txtColumnType.Text = "String";
                        cboOperator.DataSource = null;
                        CCommon.FillOperatorComboString(cboOperator);
                        txtColumnValueField.Visible = true;
                        cboColumnValue.Visible = false;
                        break;

                }
            }
        }

        private void btnFindEvents_Click(object sender, EventArgs e)
        {
            try
            {

                string strCriteria = CollectEventCriteria();
                grvEventData.DataSource = null;
                if (lvwColumnCriteria.Items.Count > 0)
                {
                    CCommon.ColumnCriteria[] strColumnCriteria = CollectColumnCriteria();
                    FillEventsList(strCriteria, strColumnCriteria);
                }
                else
                    FillEventsList(strCriteria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string CollectEventCriteria()
        {
            string strCriteria = "";
            DateTime dteValue;
            
            if (cboEventType.SelectedIndex > 0)
                strCriteria = strCriteria + " And EventType = " + Convert.ToInt32(CCommon.GetItemData(cboEventType));
            if (cboEventsTablename.SelectedIndex > 0)
                strCriteria = strCriteria + " And TableName = '" + CCommon.GetDisplayText(cboEventsTablename) + "'";
            if (txtEventsUserid.Text != "")
                strCriteria = strCriteria + " And UserId = '" + txtEventsUserid.Text + "'";
            if (txtEventsUsername.Text != "")
                strCriteria = strCriteria + " And UserName like '" + txtEventsUsername.Text + "%'";
            if (txtEventsComputerName.Text != "")
                strCriteria = strCriteria + " And ComputerName = '" + txtEventsComputerName.Text + "'";
            if (txtEventsSearchfield.Text != "")
                strCriteria = strCriteria + " And SearchField = '" + txtEventsSearchfield.Text + "'";
            if (txtEventsSearchvalue.Text != "")
                strCriteria = strCriteria + " And SearchValue = '" + txtEventsSearchvalue.Text + "'";
            if (chkEventDate.Checked)
            {
                if (DateTime.TryParseExact(txtEventsEventdatefrom.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValue))
                    strCriteria = strCriteria + " And EventDate >= Convert(datetime, '" + dteValue.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
                if (DateTime.TryParseExact(txtEventsEventdateto.Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValue))
                    strCriteria = strCriteria + " And EventDate <= Convert(datetime, '" + dteValue.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
            }
            if (chkEventTime.Checked)
            {
                if (DateTime.TryParseExact(txtEventsEventtimefrom.Text, CSettings.TimeFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValue))
                    strCriteria = strCriteria + " And EventTime >= Convert(datetime, '" + dteValue.ToString(CSettings.TimeFormat) + "', " + CSettings.SQLTimeStyle + ") ";
                if (DateTime.TryParseExact(txtEventsEventtimeto.Text, CSettings.TimeFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValue))
                    strCriteria = strCriteria + " And EventTime <= Convert(datetime, '" + dteValue.ToString(CSettings.TimeFormat) + "', " + CSettings.SQLTimeStyle + ") ";
            }
            return strCriteria;
        }
        private CCommon.ColumnCriteria[] CollectColumnCriteria()
        {
            CCommon.ColumnCriteria[] strColumnCriteria = new CCommon.ColumnCriteria[lvwColumnCriteria.Items.Count];
            int i = 0;
            foreach (ListViewItem item in lvwColumnCriteria.Items)
            {
                strColumnCriteria[i].ColumnName = item.SubItems[colColumnName.Index].Text;
                strColumnCriteria[i].Operator = item.SubItems[colOperator.Index].Text;
                if (Convert.ToInt32(item.SubItems[colColumnType.Index].Text) == 104) //bool
                {
                    if (item.SubItems[colColumnValue.Index].Text == "False")
                        strColumnCriteria[i].Value = "0";
                    else
                        strColumnCriteria[i].Value = "1";
                }
                else
                    strColumnCriteria[i].Value = item.SubItems[colColumnValue.Index].Text;
                strColumnCriteria[i].ColumnType = Convert.ToInt32(item.SubItems[colColumnType.Index].Text);
                i++;
            }
            return strColumnCriteria;
        }
        private void ShowEventData()
        {
            try
            {
                ListViewItem item = lvwEvents.SelectedItems[0];
                EventsId = Convert.ToInt32(item.SubItems[colEventsId.Index].Text);
                CEvents objEvent = new CEvents();
                DataTable dt = new DataTable();
                objEvent.Id = EventsId;
                dt = objEvent.ShowEventData();
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (!dr["EventSource"].Equals(DBNull.Value))
                        {
                            if (Convert.ToInt32(dr["EventSource"]) == (int)CCommon.EventSource.System)
                                dr["EventSource"] = "System";
                            else if (Convert.ToInt32(dr["EventSource"]) == (int)CCommon.EventSource.Restored)
                                dr["EventSource"] = "Restored From Event";
                            else if (Convert.ToInt32(dr["EventSource"]) == (int)CCommon.EventSource.Merged)
                                dr["EventSource"] = "Merged";
                            else if (Convert.ToInt32(dr["EventSource"]) == (int)CCommon.EventSource.Default)
                                dr["EventSource"] = "Script";
                        }
                    }

                }
                grvEventData.ReadOnly = true;
                grvEventData.DataSource = dt;
                grvEventData.Columns[0].Width = 150;
                grvEventData.Columns["Guid"].Visible = false;
                grvEventData.Columns["EventType"].Visible = false;
                grvEventData.Columns["TableRowGuid"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestoreEvent_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvwEvents.SelectedItems.Count > 0)
                {
                    ListViewItem item = lvwEvents.SelectedItems[0];
                    CEvents objEvent = new CEvents();
                    DateTime dteValue;
                    DateTime dteValueTime;
                    long lngEventId = Convert.ToInt64(item.Text);
                    int intEventType = Convert.ToInt32(item.SubItems[colEventsEventtype.Index].Text);
                    string strCriteria = "";
                    strCriteria = strCriteria + " And TableRowGuid = '" + item.SubItems[colEventsTablerowguid.Index].Text + "'";
                    if (DateTime.TryParseExact(item.SubItems[colEventsEventdate.Index].Text, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValue))
                        strCriteria = strCriteria + " And (EventDate > Convert(datetime, '" + dteValue.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") ";
                    if (DateTime.TryParseExact(item.SubItems[colEventsEventtime.Index].Text, CSettings.TimeFormat, CSettings.Culture, CSettings.DateTimeStyle, out dteValueTime))
                        strCriteria = strCriteria + " Or ( EventDate = Convert(datetime, '" + dteValue.ToString(CSettings.DateFormat) + "', " + CSettings.SQLDateTimeStyle + ") " +
                                                         " And EventTime > Convert(datetime, '" + dteValueTime.ToString(CSettings.TimeFormat) + "', " + CSettings.SQLTimeStyle + "))) ";
                    if (lngEventId > objEvent.CheckLatestEvent(strCriteria))
                    {
                        if (objEvent.CheckColumnsAreSame(item.SubItems[colEventsTablename.Index].Text, item.SubItems[colEventsTablerowguid.Index].Text))
                            RestoreEvent(lngEventId, intEventType);
                        else
                            MessageBox.Show("Can Not Restore This Event!!! The Table Has Changed!!");

                    }
                    else
                        MessageBox.Show("Can Not Restore This Event!!! Because its not The latest Event for the Selected Row");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RestoreEvent(long lngEventId,int intEventType )
        {
            try
            {

                CEvents objEvent = new CEvents();
                if (intEventType == (int)CCommon.EventType.Insert)
                {
                    if (objEvent.RestoreInsertEvent(lngEventId))
                        if (objEvent.SetEventToResored(lngEventId))
                            MessageBox.Show(this, "Event Restored Successfully!!!", "Event Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(this, "Error!!! Event Not Restored ", "Event Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (intEventType == (int)CCommon.EventType.Delete)
                {
                    if (objEvent.RestoreDeleteEvent(lngEventId))
                        if (objEvent.SetEventToResored(lngEventId))
                            MessageBox.Show(this, "Event Restored Successfully!!!", "Event Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(this, "Error!!! Event Not Restored ", "Event Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (intEventType == (int)CCommon.EventType.Update)
                {
                    if (objEvent.RestoreUpdateEvent(lngEventId))
                        if (objEvent.SetEventToResored(lngEventId))
                            MessageBox.Show(this, "Event Restored Successfully!!!", "Event Viewer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else

                            MessageBox.Show(this, "Error!!! Event Not Restored ", "Event Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
