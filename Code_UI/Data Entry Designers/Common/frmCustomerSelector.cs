using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharma
{
    public partial class frmCustomerSelector : Form
    {
        private const string DialogCaption = "Search Customer";

        int _x;
        public int x
        {
            set { _x = value; }
        }
        int _y;
        public int y
        {
            set { _y = value; }
        }
        public bool blnSelected = false;
        string _CustomerGuid;
        public string Customerguid
        {
            get { return _CustomerGuid; }
            set { _CustomerGuid = value; }
        }
        string _OrganizationName;
        public string OrganizationName
        {
            get { return _OrganizationName; }
        }
        private TextBox _SearchTextBox;
        public TextBox SearchTextBox
        {
            get { return _SearchTextBox; }
            set { _SearchTextBox = value; }
        }
        
        public frmCustomerSelector()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Paint the form and draw a neat border.
        /// </summary>
        /// <param name="e">Information about the paint event</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle borderRect = new Rectangle(this.ClientRectangle.Location, this.ClientRectangle.Size);
            borderRect.Width -= 1;
            borderRect.Height -= 1;
            e.Graphics.DrawRectangle(new Pen(Color.CornflowerBlue), borderRect);
        }
        private void frmCustomerSelector_Load(object sender, EventArgs e)
        {

        }
        private void frmCustomerSelector_Resize(object sender, EventArgs e)
        {
            try
            {
                ResizeControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void ResizeControls()
        {
            try
            {
                this.lvwCustomer.Width = this.Width - this.lvwCustomer.Left;
                colOrgnaizationName.Width = this.lvwCustomer.Width - 22;
                //this.lvwCustomer.Height = this.Height - 2;
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
                ListViewItem itmX = new ListViewItem();

                if (lvwCustomer.SelectedItems.Count != 0)
                {
                    itmX = lvwCustomer.SelectedItems[0];
                    _CustomerGuid = itmX.SubItems[colGuid.Index].Text;
                    _OrganizationName = itmX.SubItems[colOrgnaizationName.Index].Text;
                }
                blnSelected = true;
                this.Close();
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
                blnSelected = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwCustomer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwCustomer.SelectedItems[0];
                _CustomerGuid = itmX.SubItems[colGuid.Index].Text;
                _OrganizationName = itmX.SubItems[colOrgnaizationName.Index].Text;
                blnSelected = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCustomerSelector_Activated(object sender, EventArgs e)
        {
            try
            {
                this.lvwCustomer.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
        }

    }
}