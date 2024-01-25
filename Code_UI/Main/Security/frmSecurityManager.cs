using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;
using System.Security.Policy;

using Pharma;


namespace SecurityManager
{
    public partial class frmSec : Form
    {
        private const string DialogCaption = "Users and Groups";

        public enum eAccessRightType {eNoAccess = 0,eRead = 1,eReadWrite =2,eReadWriteDelete = 3}
        public bool blnNewGroup;
        public Int32 lngGroupId = 0;
        public bool blnNewUser;
        public Int32 lngUserId = 0;
        public string strPassword;
        private int ApplicationUsersId = 0;

        
        public frmSec()
        {
            InitializeComponent();
           
        }

        private void frmSec_Load(object sender, EventArgs e)
        {
            try
            {
                FillAccessRightCombo(cboGroupAccessRight);
                FillListGroups();
                FillAccessRightCombo(cboUserAccessRight);
                FillGroupNameCombo(cboGroupNameSearch);
                FillGroupNameCombo(cboGroupNameUser);
                FillGroupNameCombo(cboGroupNameApplication);
                CCommon.FillSystemApplicationCombo(cboApplicantionName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillApplicationUsersList(int intAppId)
        {
            try
            {

                CApplicationUsers objApplicationUsers = new CApplicationUsers();

                ArrayList ar = new ArrayList(objApplicationUsers.GetList(intAppId));
                this.lvwApplicationUsers.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CApplicationUsers ApplicationUsers in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {                                                                                      ApplicationUsers.Id.ToString(), 
                        CCommon.GetSystemApplicationText(Convert.ToInt32(ApplicationUsers.ApplicationId)), 
                        ApplicationUsers.UserName.ToString()});
                    this.lvwApplicationUsers.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillAccessRightCombo(ComboBox cboName)
        {
            try
            {
                DataTable dt = new DataTable("dtAccessRight");
                DataColumn dc;
                DataRow dr;
                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.Int32");
                dc.ColumnName = "AccessRight";
                dt.Columns.Add(dc);
                dc = new DataColumn();
                dc.DataType = System.Type.GetType("System.String");
                dc.ColumnName = "AccessDescription";
                dt.Columns.Add(dc);
                dr = dt.NewRow();
                dr["AccessRight"] = Convert.ToInt32(eAccessRightType.eNoAccess);
                dr["AccessDescription"] = "No Access";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["AccessRight"] = Convert.ToInt32(eAccessRightType.eRead);
                dr["AccessDescription"] = "Read";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["AccessRight"] = Convert.ToInt32(eAccessRightType.eReadWrite);
                dr["AccessDescription"] = "Read Write";
                dt.Rows.Add(dr);

                dr = dt.NewRow();
                dr["AccessRight"] = Convert.ToInt32(eAccessRightType.eReadWriteDelete);
                dr["AccessDescription"] = "Read Write Delete";
                dt.Rows.Add(dr);
                cboName.DataSource = dt;
                cboName.DisplayMember = Convert.ToString(dt.Columns["AccessDescription"]);
                cboName.ValueMember = Convert.ToString(dt.Columns["AccessRight"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillGroupNameCombo(ComboBox cboName)
        {
            try
            {
                CGroups objGroups = new CGroups();
                DataTable dt = new DataTable();
                DataTableReader dr = null;
                dt = objGroups.GetGroups();
                dr = dt.CreateDataReader();
                if (dt.Rows.Count > 0)
                {
                    cboName.DisplayMember = Convert.ToString(dt.Columns["GroupName"]);
                    cboName.ValueMember = Convert.ToString(dt.Columns["Id"]);
                    cboName.DataSource = dt;
                    cboName.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
        private void btnGroups_Click(object sender, EventArgs e)
        {
            try
            {
                tabSecurity.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            try
            {
                tabSecurity.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void tspGroups_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabSecurity_Selected(object sender, TabControlEventArgs e)
        {

        }
        private void NewRecord()
        {
            try
            {
                blnNewGroup = true;
                lngGroupId = 0;
                txtGroupName.Text = "";
                txtDescription.Text = "";
                cboGroupAccessRight.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NewRecordUser()
        {
            try
            {
                blnNewUser = true;
                lngUserId = 0;
                txtUserName.Text = "";
                cboGroupNameUser.SelectedIndex = -1;
                cboUserAccessRight.SelectedIndex = 0;
                txtFirstName.Text = "";
                txtFatherName.Text = "";
                txtGrandName.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtRemark.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidRecord())
                {
                    if (IsGroupExistant())
                    {
                        if (SaveGroup(blnNewGroup))
                        {
                            FormToListGroup();
                            NewRecord();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidRecord()
        {
            try
            {
                if (txtGroupName.Text == "")
                {
                    MessageBox.Show("Please enter group name", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtGroupName, "Please enter group name");
                    return false;
                }
                if (cboGroupAccessRight.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select group access right", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(cboGroupAccessRight, "Please select group access right");
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
        private bool IsValidRecordUser()
        {
            try
            {
                if (txtUserName.Text == "")
                {
                    MessageBox.Show("Please enter user name", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtUserName, "Please enter user name");
                    return false;
                }
                if (cboGroupNameUser.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select group ", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(cboGroupNameUser, "Please select group");
                    return false;
                }
                if (cboUserAccessRight.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select group access right", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(cboUserAccessRight, "Please select group access right");
                    return false;
                }
                if (txtFirstName.Text == "")
                {
                    MessageBox.Show("Please first name", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtFirstName, "Please first name");
                    return false;
                }
                if (txtFatherName.Text == "")
                {
                    MessageBox.Show("Please father name", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtFatherName, "Please father name");
                    return false;
                }
                if (txtGrandName.Text == "")
                {
                    MessageBox.Show("Please grand father name", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtGrandName, "Please grand father name");
                    return false;
                }
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Please Enter The Password", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtPassword, "Please Enter The Password");
                    return false;
                }
                if (txtPassword.Text.Length < 6)
                {
                    MessageBox.Show("Please a password greather than 5 characters", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtPassword, "Please a password greather than 5 characters");
                    return false;
                }
                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("The entered password is not correctly confirmed", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    errValidator.SetError(txtPassword, "The entered password is not correctly confirmed");
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
        private bool IsGroupExistant()
        {
            try
            {
                CGroups objGroups = new CGroups();
                objGroups.GroupName = txtGroupName.Text;
                objGroups.Id = lngGroupId;
                if (objGroups.IsGroupExistant(blnNewGroup) > 0)
                {
                    MessageBox.Show("There exists a group with the given name", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private bool IsUserExistant()
        {
            try
            {
                CUsers objUsers = new CUsers();
                objUsers.UserId = txtUserName.Text;
                objUsers.Id = lngUserId;
                if (objUsers.IsUserExistant(blnNewUser) > 0)
                {
                    MessageBox.Show("There exists a user with the given name", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private bool IsAccessRightCorrect()
        {
            try
            {
                CUsers objUsers = new CUsers();


                if (!objUsers.IsAccessRightCorrect(Convert.ToInt32(cboUserAccessRight.SelectedValue), Convert.ToInt32(cboGroupNameUser.SelectedValue)))
                {
                    MessageBox.Show("The access right of the user cannot exceed the groups access right", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private bool SaveGroup(bool blnNewRecord)
        {
            CGroups objGroups = new CGroups();
            try
            {
                objGroups.Id = lngGroupId;
                objGroups.GroupName = txtGroupName.Text;
                objGroups.AccessRight= Convert.ToInt32(cboGroupAccessRight.SelectedValue);
                objGroups.Description = txtDescription.Text;
                if (blnNewGroup)
                    objGroups.Insert();
                else
                    objGroups.Update();

                lngGroupId = objGroups.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool SaveUser(bool blnNewRecord)
        {
            CUsers objUsers = new CUsers();
           
            try
            {
                objUsers.Id = lngUserId;
                objUsers.UserId = txtUserName.Text;
                objUsers.Password = Convert.ToString(txtPassword.Text.GetHashCode());                           
                objUsers.FirstName = txtFirstName.Text;
                objUsers.FatherName = txtFatherName.Text;
                objUsers.GrandFatherName = txtGrandName.Text;
                objUsers.GroupId = Convert.ToInt32(cboGroupNameUser.SelectedValue);
                objUsers.AccessRight = Convert.ToInt32(cboUserAccessRight.SelectedValue);
                objUsers.Remark = txtRemark.Text;
                if (blnNewUser)
                    objUsers.Insert();
                else
                    objUsers.Update();

                lngUserId = objUsers.Id;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void FormToListGroup()
        {
            try
            {
                CGroups objGroups = new CGroups();
                ArrayList ar = new ArrayList(objGroups.GetList());

                if (ar.Count < 0) return;
                if (blnNewGroup == true)
                {
                    lvwGroups.Items.Clear();
                    foreach (CGroups Group in ar)
                    {

                        ListViewItem itmX = new ListViewItem(new string[] {
                                    Group.Id.ToString(),
                                    Group.GroupName,
                                    GetAccessRightName(Group.AccessRight),
                                    Group.Description});

                        this.lvwGroups.Items.Add(itmX);

                    }
                }
                else
                {
                    if (lvwGroups.SelectedItems.Count <= 0) return;
                    ListViewItem itmX = lvwGroups.SelectedItems[0];

                    foreach (CGroups Group in ar)
                    {
                        itmX.SubItems[0].Text = lngGroupId.ToString();
                        itmX.SubItems[1].Text = txtGroupName.Text;
                        itmX.SubItems[2].Text = cboGroupAccessRight.Text;
                        itmX.SubItems[3].Text = txtDescription.Text;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetAccessRightName(Int32 intAccessRight)
        {
            try
            {
                switch (intAccessRight)
                {
                    case 0:
                        return "No Access";
                    case 1:
                        return "Read";
                    case 2:
                        return "Read Write";
                    case 3:
                        return "Read Write Delete";
                    default:
                        return "";
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }        
        private void lvwGroups_Click(object sender, EventArgs e)
        {
            try
            {
                ListToFormGroup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListToFormGroup()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwGroups.SelectedItems[0];
                blnNewGroup = false;
                lngGroupId = Convert.ToInt32(itmX.SubItems[colID.Index].Text);
                txtGroupName.Text = itmX.SubItems[colGroupName.Index].Text;
                cboGroupAccessRight.Text = itmX.SubItems[colAccessRight.Index].Text;
                txtDescription.Text = itmX.SubItems[colDescription.Index].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillListGroups()
        {
            try
            {
                CGroups objGroups = new CGroups();
                ArrayList ar = new ArrayList(objGroups.GetList());
                lvwGroups.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CGroups Group in ar)
                {

                    ListViewItem itmX = new ListViewItem(new string[] {
                                    Group.Id.ToString(),
                                    Group.GroupName,
                                    GetAccessRightName(Group.AccessRight),
                                    Group.Description});

                    this.lvwGroups.Items.Add(itmX);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckUsersUnderGroup())
                {
                    if (MessageBox.Show("Are you sure you want to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        CGroups objGroups = new CGroups();
                        objGroups.Id = lngGroupId;
                        objGroups.Delete();
                        lvwGroups.Items.Remove(lvwGroups.SelectedItems[0]);
                        NewRecord();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckUsersUnderGroup()
        {
            try
            {
                CGroups objGroups = new CGroups();
                objGroups.Id = lngGroupId;
                if (objGroups.AreThereUsers() > 0)
                {
                    MessageBox.Show("There are users assaigned to this group! Please change or delete the users before deleting the group", DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                NewRecordUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNewGroup_Click(object sender, EventArgs e)
        {
            try
            {
                NewRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidRecordUser())
                {
                    if (IsUserExistant())
                    {
                        if (IsAccessRightCorrect())
                        {
                            if (SaveUser(blnNewUser))
                            {
                                FormToListUser();
                                NewRecordUser();
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
        private void tabUsers_Click(object sender, EventArgs e)
        {

        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboGroupNameSearch.SelectedIndex == -1)
                    FillListUsers();
                else
                    FillListUsers(Convert.ToInt32(cboGroupNameSearch.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillListUsers()
        {
            try
            {
                CUsers objUsers = new CUsers();
                ArrayList ar = new ArrayList(objUsers.GetList());
                lvwUsers.Items.Clear();
                if (ar.Count < 0) return;
                foreach (CUsers User in ar)
                {
                    ListViewItem itmX = new ListViewItem(new string[] {
                                    User.Id.ToString(),
                                    User.UserId,
                                    User.Password,
                                    User.FirstName,
                                    User.FatherName,
                                    User.GrandFatherName,
                                    User.GroupName,
                                    GetAccessRightName(User.AccessRight),
                                    User.Remark});

                    this.lvwUsers.Items.Add(itmX);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillListUsers(Int32 lngGroupId)
        {
            try
            {
                CUsers objUsers = new CUsers();
                ArrayList ar = new ArrayList(objUsers.GetList(lngGroupId));
                lvwUsers.Items.Clear();
                if (ar.Count < 0) return;

                foreach (CUsers User in ar)
                {

                    ListViewItem itmX = new ListViewItem(new string[] {
                                    User.Id.ToString(),
                                    User.UserId,
                                    User.Password,
                                    User.FirstName,
                                    User.FatherName,
                                    User.GrandFatherName,
                                    User.GroupName,
                                    GetAccessRightName(User.AccessRight),
                                    User.Remark});

                    this.lvwUsers.Items.Add(itmX);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillListUsersApp(Int32 lngGroupId)
        {
            try
            {
                CUsers objUsers = new CUsers();
                ArrayList ar = new ArrayList(objUsers.GetList(lngGroupId));
                lvwAppUserList.Items.Clear();
                if (ar.Count < 0) return;
                foreach (CUsers User in ar)
                {

                    ListViewItem itmX = new ListViewItem(new string[] {
                                    User.UserId,
                                    User.Id.ToString()
                                    });

                    this.lvwAppUserList.Items.Add(itmX);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FormToListUser()
        {
            try
            {
                CUsers objUsers = new CUsers();
                ArrayList ar = new ArrayList(objUsers.GetList(Convert.ToInt32(cboGroupNameSearch.SelectedValue)));

                if (ar.Count < 0) return;
                if (blnNewUser == true)
                {
                    lvwUsers.Items.Clear();
                    foreach (CUsers User in ar)
                    {
                        ListViewItem itmX = new ListViewItem(new string[] {
                                    User.Id.ToString(),
                                    User.UserId,
                                    User.Password,
                                    User.FirstName,
                                    User.FatherName,
                                    User.GrandFatherName,
                                    User.GroupName,
                                    GetAccessRightName(User.AccessRight),
                                    User.Remark});

                        this.lvwUsers.Items.Add(itmX);

                    }
                }
                else
                {
                    if (lvwUsers.SelectedItems.Count <= 0) return;
                    ListViewItem itmX = lvwUsers.SelectedItems[0];

                    foreach (CUsers User in ar)
                    {
                        itmX.SubItems[0].Text = User.Id.ToString();
                        itmX.SubItems[1].Text = User.UserId;
                        itmX.SubItems[2].Text = User.Password;
                        itmX.SubItems[3].Text = User.FirstName;
                        itmX.SubItems[4].Text = User.FatherName;
                        itmX.SubItems[5].Text = User.GrandFatherName;
                        itmX.SubItems[6].Text = User.GroupName.ToString();
                        itmX.SubItems[7].Text = GetAccessRightName(User.AccessRight);
                        itmX.SubItems[8].Text = User.Remark;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwUsers_Click(object sender, EventArgs e)
        {
            try
            {
                ListToFormUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListToFormUser()
        {
            try
            {
                ListViewItem itmX = new ListViewItem();

                itmX = lvwUsers.SelectedItems[0];
                blnNewUser = false;
                lngUserId = Convert.ToInt32(itmX.SubItems[colID.Index].Text);
                txtUserName.Text = itmX.SubItems[colUserName.Index].Text;
                txtFirstName.Text = itmX.SubItems[colFirstName.Index].Text;
                txtFatherName.Text = itmX.SubItems[colFatherName.Index].Text;
                txtGrandName.Text = itmX.SubItems[colGrandName.Index].Text;
                cboGroupNameUser.Text = itmX.SubItems[colGroupNameUser.Index].Text;
                cboUserAccessRight.Text = itmX.SubItems[colAccessRightUser.Index].Text;
                txtDescription.Text = itmX.SubItems[colRemark.Index].Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFillUsersApplication_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboGroupNameApplication.SelectedIndex != -1)
                    FillListUsersApp(Convert.ToInt32(cboGroupNameApplication.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnApplications_Click(object sender, EventArgs e)
        {
            try
            {
                tabSecurity.SelectedIndex = 2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem itmX in this.lvwAppUserList.Items)
                {
                    if (!itmX.Checked)
                    {
                        itmX.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem itmX in this.lvwAppUserList.Items)
                {
                    if (itmX.Checked)
                    {
                        itmX.Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabApps_Click(object sender, EventArgs e)
        {

        }
        private void cboApplicantionName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboApplicantionName.SelectedIndex != -1)
                    FillApplicationUsersList(Convert.ToInt32(CCommon.GetItemData(cboApplicantionName)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SaveApplicationUsers();
                if (cboApplicantionName.SelectedIndex != -1)
                    FillApplicationUsersList(Convert.ToInt32(CCommon.GetItemData(cboApplicantionName)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveApplicationUsers()
        {
           
            try
            {
                foreach (ListViewItem itmX in this.lvwAppUserList.Items)
                {
                    if (itmX.Checked == true)
                    {
                        CApplicationUsers objApplicationUsers = new CApplicationUsers();
                        objApplicationUsers.Id = ApplicationUsersId;
                        objApplicationUsers.ApplicationId = Convert.ToInt32(CCommon.GetItemData(cboApplicantionName));
                        objApplicationUsers.UserId = Convert.ToInt32(itmX.SubItems[1].Text);
                        if (objApplicationUsers.Exists() > 0)
                            break;                        
                        else                       
                            objApplicationUsers.Insert();                        

                        ApplicationUsersId = objApplicationUsers.Id;
                    }
                }
                            return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CApplicationUsers objApplicationUsers = new CApplicationUsers();
                    objApplicationUsers.Id = Convert.ToInt32(lvwApplicationUsers.SelectedItems[0].SubItems[colAppId.Index].Text);
                    objApplicationUsers.Delete();
                    lvwApplicationUsers.Items.Remove(lvwApplicationUsers.SelectedItems[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lvwGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", DialogCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CUsers objUsers = new CUsers();
                    objUsers.Id = lngUserId;
                    objUsers.Delete();
                    lvwUsers.Items.Remove(lvwUsers.SelectedItems[0]);
                    NewRecordUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}