using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Pharma
{
    public partial class frmMerger : Form
    {
        private const string DialogCaption = "Merger Database Connection";
        private DataSet newDataSet = new DataSet("New DataSet");
        string RemoteConnectionString = "";
        int MergeDatabasesId = 0;
        bool bNewMergeDatabases = false;
        public frmMerger()
        {
            InitializeComponent();
        }

        private void frmMerger_Load(object sender, EventArgs e)
        {
            LoadCurrentConnection();
            FillMergeDatabasesList();
        }
        private void LoadCurrentConnection()
        {
            try
            {
                newDataSet.ReadXml(Application.StartupPath + "\\Pharma.exe.config");
                PrintValues(newDataSet, "New DataSet");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrintValues(DataSet dataSet, string label)
        {
            try
            {
                foreach (DataTable table in dataSet.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {

                        if (table.ToString() == "add")


                            if (row["providerName"].ToString() == "System.Data.OleDb")
                            {
                                string strAccessCon = "";
                                string[] strSplit = new string[20];
                                char[] charSeparators = new char[] { ';' };
                                strAccessCon = row["connectionString"].ToString();
                                strSplit = strAccessCon.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                                string[] strSplitData = new string[20];
                                char[] charSep = new char[] { '=' };
                                strSplitData = strSplit[1].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
                                txtFileName.Text = strSplitData[1].Replace('"', ' ').Trim();
                                if (strSplit.Length > 2)
                                {
                                    strSplitData = strSplit[2].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
                                    txtAccessUserName.Text = strSplitData[1].Replace('"', ' ').Trim();
                                }
                                if (strSplit.Length > 3)
                                {
                                    strSplitData = strSplit[3].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
                                    txtAccessPassword.Text = strSplitData[1].Replace('"', ' ').Trim();
                                }

                            }
                            else if (row["providerName"].ToString() == "System.Data.SqlClient")
                            {

                                string strSQLCon = "";
                                optSqlServerDatabase.Checked = true;
                                string[] strSplit = new string[20];
                                char[] charSeparators = new char[] { ';' };
                                strSQLCon = row["connectionString"].ToString();
                                strSplit = strSQLCon.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                                string[] strSplitData = new string[20];
                                char[] charSep = new char[] { '=' };
                                strSplitData = strSplit[0].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
                                txtServerName.Text = strSplitData[1].Replace('"', ' ').Trim();
                                strSplitData = strSplit[1].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
                                txtDataBaseName.Text = strSplitData[1].Replace('"', ' ').Trim();
                                if (strSplit.Length > 2)
                                {
                                    strSplitData = strSplit[2].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
                                    if (strSplitData[0] == "Integrated Security")
                                        if (strSplitData[1] == "True")
                                            optWindowsAuthentication.Checked = true;
                                        else
                                            optSQLServerAuthentication.Checked = true;
                                    else if (strSplitData[0] == "User ID")
                                    {
                                        txtSQLUserName.Text = strSplitData[1].Replace('"', ' ').Trim();
                                        optSQLServerAuthentication.Checked = true;
                                    }

                                }
                                if (strSplit.Length > 3)
                                {
                                    strSplitData = strSplit[3].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
                                    if (strSplitData[0] == "User ID")
                                        txtSQLUserName.Text = strSplitData[1].Replace('"', ' ').Trim();
                                    else if (strSplitData[0] == "password")
                                        txtSQLPassword.Text = strSplitData[1].Replace('"', ' ').Trim();
                                }

                            }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PrintValues(string strConnectionString)
        {
            string strSQLCon = "";
            optSqlServerDatabase.Checked = true;
            string[] strSplit = new string[20];
            char[] charSeparators = new char[] { ';' };
            strSQLCon = strConnectionString;
            strSplit = strSQLCon.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            string[] strSplitData = new string[20];
            char[] charSep = new char[] { '=' };
            strSplitData = strSplit[0].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
            txtServerName.Text = strSplitData[1].Replace('"', ' ').Trim();
            strSplitData = strSplit[1].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
            txtDataBaseName.Text = strSplitData[1].Replace('"', ' ').Trim();
            if (strSplit.Length > 2)
            {
                strSplitData = strSplit[2].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
                if (strSplitData[0] == "Integrated Security")
                    if (strSplitData[1] == "True")
                        optWindowsAuthentication.Checked = true;
                    else
                        optSQLServerAuthentication.Checked = true;
                else if (strSplitData[0] == "User ID")
                {
                    txtSQLUserName.Text = strSplitData[1].Replace('"', ' ').Trim();
                    optSQLServerAuthentication.Checked = true;
                }

            }
            if (strSplit.Length > 3)
            {
                strSplitData = strSplit[3].Split(charSep, StringSplitOptions.RemoveEmptyEntries);
                if (strSplitData[0] == "User ID")
                    txtSQLUserName.Text = strSplitData[1].Replace('"', ' ').Trim();
                else if (strSplitData[0] == "password")
                    txtSQLPassword.Text = strSplitData[1].Replace('"', ' ').Trim();
            }

                           
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            TestDataBaseConnection();
        }
        private void TestDataBaseConnection()
        {
            if (optSqlServerDatabase.Checked == true)
            {
                string strSQLCon = "";
                strSQLCon = strSQLCon + "Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + txtDataBaseName.Text.Trim();
                if (optWindowsAuthentication.Checked == true)
                    strSQLCon = strSQLCon + ";Integrated Security=True";
                else
                    if (txtServerName.Text != "")
                        strSQLCon = strSQLCon + ";User ID=" + txtSQLUserName.Text.Trim();
                if (txtSQLPassword.Text != "")
                    strSQLCon = strSQLCon + ";password=" + txtSQLPassword.Text.Trim();


                SqlConnection sqlCon = new SqlConnection(strSQLCon);
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    
                    sqlCon.Open();
                    MessageBox.Show("Test connection succeeded", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (sqlCon != null) sqlCon.Close();
                    this.Cursor = Cursors.Arrow;
                }



            }
            else
            {
                string strAccessCon = "";
                strAccessCon = strAccessCon + "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtFileName.Text.Trim();
                if (txtAccessUserName.Text != "")
                    strAccessCon = strAccessCon + ";User ID=" + txtAccessUserName.Text.Trim();
                if (txtAccessPassword.Text != "")
                    strAccessCon = strAccessCon + ";password=" + txtAccessPassword.Text.Trim();


                OleDbConnection accessCon = new OleDbConnection(strAccessCon);
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    accessCon.Open();
                    MessageBox.Show("Test connection succeeded", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (accessCon != null) accessCon.Close();
                    this.Cursor = Cursors.Arrow;
                }
            }
        }
        private bool TestDataBaseConnectionForValidation()
        {
            if (optSqlServerDatabase.Checked == true)
            {
                string strSQLCon = "";
                strSQLCon = strSQLCon + "Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + txtDataBaseName.Text.Trim();
                if (optWindowsAuthentication.Checked == true)
                    strSQLCon = strSQLCon + ";Integrated Security=True";
                else
                    if (txtServerName.Text != "")
                        strSQLCon = strSQLCon + ";User ID=" + txtSQLUserName.Text.Trim();
                if (txtSQLPassword.Text != "")
                    strSQLCon = strSQLCon + ";password=" + txtSQLPassword.Text.Trim();


                SqlConnection sqlCon = new SqlConnection(strSQLCon);
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    sqlCon.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (sqlCon != null) sqlCon.Close();
                    this.Cursor = Cursors.Arrow;
                }
            }
            else
                return false;
        }
        private string GetDataBaseConnection()
        {
            
            string strReturn ="";
            if (optSqlServerDatabase.Checked == true)
            {
                string strSQLCon = "";
                strSQLCon = strSQLCon + "Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + txtDataBaseName.Text.Trim() ;
                if (optWindowsAuthentication.Checked == true)
                    strSQLCon = strSQLCon + ";Integrated Security=True";
                else
                    if (txtServerName.Text != "")
                        strSQLCon = strSQLCon + ";User ID=" + txtSQLUserName.Text.Trim();
                if (txtSQLPassword.Text != "")
                    strSQLCon = strSQLCon + ";password=" + txtSQLPassword.Text.Trim();


                SqlConnection sqlCon = new SqlConnection(strSQLCon);
                try
                {
                    this.Cursor = Cursors.WaitCursor;                    
                    sqlCon.Open();
                    return strSQLCon;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return strReturn;
                }
                finally
                {
                    if (sqlCon != null) sqlCon.Close();
                    this.Cursor = Cursors.Arrow;
                }
            }
            else
            {
                string strAccessCon = "";
                strAccessCon = strAccessCon + "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtFileName.Text.Trim();
                if (txtAccessUserName.Text != "")
                    strAccessCon = strAccessCon + ";User ID=" + txtAccessUserName.Text.Trim();
                if (txtAccessPassword.Text != "")
                    strAccessCon = strAccessCon + ";password=" + txtAccessPassword.Text.Trim();


                OleDbConnection accessCon = new OleDbConnection(strAccessCon);
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    accessCon.Open();
                    return strAccessCon;                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return strReturn;
                }
                finally
                {
                    if (accessCon != null) accessCon.Close();
                    this.Cursor = Cursors.Arrow;
                }
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                CMergeDatabases objMergeDatabases = new CMergeDatabases();

                string strRemoteConnectionString = GetDataBaseConnection();
                objMergeDatabases.ConnectionstringData = strRemoteConnectionString;
                if (objMergeDatabases.Exists(true) > 0)
                {
                    RemoteConnectionString = GetDataBaseConnection();
                    CCommon.FillComboBox(cboEventsTablename, "Select id,name from sysobjects where type='U' order by name ", "id", "name", true);
                }
                else
                    MessageBox.Show("Must Save The Database Before Connecting to the remote Server");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                if (RemoteConnectionString != "")
                    if (lvwColumnCriteria.Items.Count > 0)
                    {
                        int i = 0;
                        string strTableList = "( ";
                        foreach (ListViewItem item in lvwColumnCriteria.Items)
                        {
                            if (i == 0)
                                strTableList = strTableList + "'" + item.SubItems[colTableName.Index].Text + "'";
                            else
                                strTableList = strTableList + ", '" + item.SubItems[colTableName.Index].Text + "'";

                            i++;
                        }
                        strTableList = strTableList + " )";
                        Merge(strTableList);
                    }
                    else
                        Merge();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Merge()
        {
            try
            {
                CMerger objMerger = new CMerger();
                objMerger.ConnectionStringRemote = RemoteConnectionString;
                objMerger.DatabaseName = txtDataBaseName.Text;
                if (objMerger.Syncronize())
                    MessageBox.Show("Database Syncronization Succeeded", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error Database Not Syncronized", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Merge(string strTableList)
        {
            try
            {
                CMerger objMerger = new CMerger();
                objMerger.ConnectionStringRemote = RemoteConnectionString;
                if (objMerger.Syncronize(strTableList))
                    MessageBox.Show("Database Syncronization Succeeded", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error Database Not Syncronized", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #region Save Merge Databases
        private bool IsValidMergeDatabases()
        {
            try
            {
                if (!TestDataBaseConnectionForValidation())
                {
                    CCommon.SetMessage(grpSQL,"Could Not Connect To Database",mValidator,lblMsg);
                    return false;
                }
                if (!CCommon.SetRequiredMessage(txtMergeDatabasesAlias, "Server Logical Name can not be empty", mValidator, lblMsg))
                    return false;
                

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool SaveMergeDatabases()
        {

            if (!IsValidMergeDatabases()) return false;
            try
            {
                CMergeDatabases objMergeDatabases = new CMergeDatabases();
                DataTable dt = new DataTable();
                string strRemoteConnectionString = GetDataBaseConnection();
                objMergeDatabases.Id = MergeDatabasesId;
                dt = objMergeDatabases.GetRemoteDatabaseDetails(strRemoteConnectionString);
                if (dt.Rows.Count < 1)
                {
                    MessageBox.Show("Error Can Not Save Server. Could not get Remote Database Details ", "Database Merger", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                objMergeDatabases.Hostname = Convert.ToString(dt.Rows[0]["HostName"]);
                objMergeDatabases.Databaseguid = Convert.ToString(dt.Rows[0]["DatabaseGuid"]);
                objMergeDatabases.ConnectionstringData = strRemoteConnectionString;
                if (txtMergeDatabasesAlias.Text == string.Empty)
                    objMergeDatabases.Alias = string.Empty;
                else
                    objMergeDatabases.Alias = Convert.ToString(txtMergeDatabasesAlias.Text);
                if (chkIsChildServer.Checked)
                    objMergeDatabases.Ischildserver = true;
                else
                    objMergeDatabases.Ischildserver = false;

                if (objMergeDatabases.Exists(true) > 0)               
                    bNewMergeDatabases = false;                    
                else
                    bNewMergeDatabases = true;

                if (bNewMergeDatabases)
                    objMergeDatabases.Insert();
                else
                    objMergeDatabases.Update();

                MergeDatabasesId = objMergeDatabases.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }      
        private void EditMergeDatabases()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwMergeDatabases.SelectedItems[0];

                bNewMergeDatabases = false;
                MergeDatabasesId = Convert.ToInt32(itmX.SubItems[colMergeDatabasesId.Index].Text);               
                
                PrintValues(Convert.ToString(itmX.SubItems[colMergeDatabasesConnectionstring.Index].Text));
                txtMergeDatabasesAlias.Text = Convert.ToString(itmX.SubItems[colMergeDatabasesAlias.Index].Text);
                if (Convert.ToBoolean(itmX.SubItems[colMergeDatabasesIschildserver.Index].Text))
                    chkIsChildServer.Checked = true;
                else
                    chkIsChildServer.Checked = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateMergeDatabasesList()
        {
            try
            {
                FillMergeDatabasesList();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillMergeDatabasesList()
        {
            try
            {

                CMergeDatabases objMergeDatabases = new CMergeDatabases();

                ArrayList ar = new ArrayList(objMergeDatabases.GetList());
                this.lvwMergeDatabases.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CMergeDatabases MergeDatabases in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      MergeDatabases.Id.ToString(), 
                                                                                      MergeDatabases.Hostname.ToString(), 
                                                                                      MergeDatabases.Databaseguid.ToString(), 
                                                                                      MergeDatabases.ConnectionstringData.ToString(), 
                                                                                      MergeDatabases.Alias.ToString(), 
                                                                                      MergeDatabases.Ischildserver.ToString()});
                    this.lvwMergeDatabases.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lvwMergeDatabases_DoubleClick(object sender, EventArgs e)
        {
            EditMergeDatabases();
        }
        private void lvwMergeDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwMergeDatabases.SelectedItems.Count > 0)
                EditMergeDatabases();
        }

        #endregion

        private void btnSaveServer_Click(object sender, EventArgs e)
        {
            bool bSaved = false;

            bSaved = SaveMergeDatabases();

            if (bSaved)
            {
                UpdateMergeDatabasesList();                
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboEventsTablename.SelectedIndex > 0)
            {
                lvwColumnCriteria.Items.Add(CCommon.GetDisplayText(cboEventsTablename));
            }
        }

        private void cboEventsTablename_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

      
    }
}
