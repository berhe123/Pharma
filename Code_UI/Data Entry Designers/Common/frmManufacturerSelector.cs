using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pharma
{
    public partial class frmManufacturerSelector : Form
    {
        private const string DialogCaption = "Search Supplier";

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
        string _ManufacturerGuid;
        public string Manufacturerguid
        {
            get { return _ManufacturerGuid; }
            set { _ManufacturerGuid = value; }
        }
        string _ManufacturerName;
        public string ManufacturerName
        {
            get { return _ManufacturerName; }
        }
        private TextBox _SearchTextBox;
        public TextBox SearchTextBox
        {
            get { return _SearchTextBox; }
            set { _SearchTextBox = value; }
        }


        public frmManufacturerSelector()
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
        private void frmManufacturerSelector_Load(object sender, EventArgs e)
        {

        }
        private void frmManufacturerSelector_Resize(object sender, EventArgs e)
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
                this.lvwManufacturer.Width = this.Width - this.lvwManufacturer.Left;
                colManufacturerName.Width = this.lvwManufacturer.Width - 22;
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

                if (lvwManufacturer.SelectedItems.Count != 0)
                {
                    itmX = lvwManufacturer.SelectedItems[0];
                    _ManufacturerGuid = itmX.SubItems[colGuid.Index].Text;
                    _ManufacturerName = itmX.SubItems[colManufacturerName.Index].Text;
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

        private void lvwManufacturer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ListViewItem itmX = new ListViewItem();
                itmX = lvwManufacturer.SelectedItems[0];
                _ManufacturerGuid = itmX.SubItems[colGuid.Index].Text;
                _ManufacturerName = itmX.SubItems[colManufacturerName.Index].Text;
                blnSelected = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmManufacturerSelector_Activated(object sender, EventArgs e)
        {
            try
            {
                this.lvwManufacturer.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwManufacturer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //
        }


      

       

     
    }
}