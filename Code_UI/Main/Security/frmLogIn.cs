using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Pharma;

namespace SecurityManager
{
    public partial class frmLogIn : Form
    {
        private const string DialogCaption = "User Login";

        public frmLogIn()
        {
            InitializeComponent();
        }

        private void Login()
        {
            CLogIn objLogIn = new CLogIn();

            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (objLogIn.LogIn(txtUserName.Text, txtPassword.Text) == true)
                {
                    Program.blnIsAuthenticated = true;
                    Program.intUserId = objLogIn.UserId;
                    Program.intUserAccessRight = objLogIn.UserAccessRight;
                    Program.strUserName = objLogIn.UserName;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnExit_Click(object sender, EventArgs e)
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(e.KeyChar) == 13)
                {
                    Login();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                frmDatabaseSettings objDatabaseSettings = new frmDatabaseSettings();
                objDatabaseSettings.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}