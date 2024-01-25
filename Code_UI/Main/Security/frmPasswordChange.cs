using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Pharma;

namespace SecurityManager
{
    public partial class frmPasswordChange : Form
    {
        private const string DialogCaption = "Change Password";

        public frmPasswordChange()
        {
            InitializeComponent();
        }

        private void frmPasswordChange_Load(object sender, EventArgs e)
        {
            try
            {
                if (Program.intUserId != 0)
                {
                    LoadUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadUser()
        {
            try
            {
                CUsers objUser = new CUsers();
                DataTable dt = new DataTable();
                objUser.Id = Program.intUserId;
                dt = objUser.GetRecord();
                txtUserName.Text = (string)dt.Rows[0]["UserId"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckExistingPassword()
        {
            try
            {
                CUsers objUser = new CUsers();
                CLogIn objLogIn = new CLogIn();
                if (objLogIn.LogIn(txtUserName.Text, txtPassword.Text) == true)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidPasswordChange())
                {
                    if (CheckExistingPassword())
                    {

                            CUsers objUsers = new CUsers();
                            objUsers.Id = Program.intUserId;
                            objUsers.Password = Convert.ToString(txtNewPassword.Text.GetHashCode());
                            objUsers.UpdatePassword();
                            MessageBox.Show("Your password has been changed successfully.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                    }
                }            
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);                       
            }
        }
        private bool IsValidPasswordChange()
        {
            try
            {
                errValidator.Clear();
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please enter your current password.", "Security Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtPassword, "Please enter your current password.");
                    txtPassword.Focus();
                    return false;
                }
                if (txtNewPassword.Text == "")
                {
                    MessageBox.Show("Please enter the new password.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtNewPassword, "Please enter the new password.");
                    txtNewPassword.Focus();
                    return false;
                }
                if (txtNewPassword.Text.Length < 6)
                {
                    MessageBox.Show("Please enter a password with length longer than 5 characters.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtNewPassword, "Please enter a password with length longer than 5 characters.");
                    txtNewPassword.Focus();
                    return false;
                }
                if (txtNewPassword.Text != txtConfirmNewPassword.Text)
                {
                    MessageBox.Show("The passwords you entered do not match. Please confirm your password again.", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtConfirmNewPassword, "The passwords you entered do not match. Please confirm your password again.");
                    txtConfirmNewPassword.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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

    }
}
