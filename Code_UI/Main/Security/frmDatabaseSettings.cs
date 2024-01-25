using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Pharma

{
    public partial class frmDatabaseSettings : Form
    {
        private const string DialogCaption = "Database Connection Settings";
      
        private DataSet newDataSet = new DataSet("New DataSet");   
        public frmDatabaseSettings()
        {
            InitializeComponent();
        }

        private void optSqlServerDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (optSqlServerDatabase.Checked == true)
                {
                    grpAccess.Visible = false;
                    grpSQL.Visible = true;
                }
                else
                {
                    grpAccess.Visible = true;
                    grpSQL.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optAccessDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                if (optSqlServerDatabase.Checked == true)
                {
                    grpAccess.Visible = false;
                    grpSQL.Visible = true;
                }
                else
                {
                    grpAccess.Visible = true;
                    grpSQL.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDatabaseSettings_Load(object sender, EventArgs e)
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


       

        private void optSqlServerDatabase_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = "";

                foreach (DataTable table in newDataSet.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {

                        if (table.ToString() == "add")
                            if (row["providerName"].ToString() == "System.Data.OleDb")
                            {
                                strConn = "";
                                row["name"] = "Pharma.Properties.Settings.connectionStringImportExport";
                                row["providerName"] = "System.Data.OleDb";
                                strConn = strConn + "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + txtFileName.Text.Trim();
                                if (txtAccessUserName.Text != "")
                                    strConn = strConn + ";User ID=" + txtAccessUserName.Text.Trim();
                                if (txtAccessPassword.Text != "")
                                    strConn = strConn + ";password=" + txtAccessPassword.Text.Trim();
                                row["connectionString"] = strConn;

                            }
                            else if (row["providerName"].ToString() == "System.Data.SqlClient")
                            {
                                strConn = "";
                                row["name"] = "Pharma.Properties.Settings.connectionString";
                                row["providerName"] = "System.Data.SqlClient";
                                strConn = strConn + "Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + txtDataBaseName.Text.Trim();
                                if (optWindowsAuthentication.Checked == true)
                                    strConn = strConn + ";Integrated Security=True";
                                else
                                    if (txtServerName.Text != "")
                                        strConn = strConn + ";User ID=" + txtSQLUserName.Text.Trim();
                                if (txtSQLPassword.Text != "")
                                    strConn = strConn + ";password=" + txtSQLPassword.Text.Trim();

                                row["connectionString"] = strConn;
                            }
                    }
                }
                newDataSet.WriteXml(Application.StartupPath + "\\Pharma.exe.config");
                this.Close();
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
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

        private void btnBrawse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.CheckFileExists = true;
                dlg.Filter = "mdb files (*.MDB)|*.MDB";
                dlg.DefaultExt = ".MDB";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = dlg.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optWindowsAuthentication.Checked)
                {
                    this.txtSQLUserName.Enabled = false;
                    this.txtSQLPassword.Enabled = false;
                }
                else
                {
                    this.txtSQLUserName.Enabled = true;
                    this.txtSQLPassword.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void optSQLServerAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (optSQLServerAuthentication.Checked)
                {
                    this.txtSQLUserName.Enabled = true;
                    this.txtSQLPassword.Enabled = true;
                }
                else
                {
                    this.txtSQLUserName.Enabled = false;
                    this.txtSQLPassword.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
       

       
    }
}