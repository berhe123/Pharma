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
    public partial class frmSelectCountry : Form
    {
        private const string DialogCaption = "Search Country";

        #region Class Property Declarations

        bool blnCancel = false;
        public bool bCancel
        {
            get { return blnCancel; }
        }

        string CountryGuid = "";
        public string Countryguid
        {
            get { return CountryGuid; }
        }

        string CountryName = "";
        public string Countryname
        {
            get { return CountryName; }
        }

        #endregion

        //private bool already_in = false;

        public frmSelectCountry()
        {
            InitializeComponent();
        }

        private void FillListFromDB()
        {

            try
            {
                int i = 0;

                DataTable tbl = new CManufacturers().GetRecords();
                if (tbl.Rows.Count <= 0) return;

                lvwCountries.Items.Clear();

                for (i = 0; i < tbl.Rows.Count; i++)
                {


                    ListViewItem itmX = new ListViewItem(

                                                new string[] {
                                                                tbl.Rows[i]["TableRowGuid"].ToString(),
                                                                tbl.Rows[i]["code"].ToString(),
                                                                tbl.Rows[i]["Name"].ToString()
                                                               }
                                                                );

                    this.lvwCountries.Items.Add(itmX);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FillList(string filter)
        {
            try
            {
                bool blnAddToList = true;

                ArrayList ar = new ArrayList(CCountries.CountriesCollection);
                if (ar.Count < 0) return;

                lvwCountries.Items.Clear();

                foreach (CCountries app in ar)
                {
                    if (filter == string.Empty)
                        blnAddToList = true;
                    else if (app.Name.ToString() == string.Empty)
                        blnAddToList = false;
                    else if (filter.ToUpper() == app.Name.ToString().Substring(0, filter.Length).ToUpper())
                    {
                        blnAddToList = true;
                    }
                    else
                        blnAddToList = false;

                    if (blnAddToList)
                    {
                        ListViewItem itmX = new ListViewItem(new string[] {
                                                                    app.Tablerowguid.ToString(),
                                                                    app.Shortname.ToString(),
                                                                    app.Name.ToString()});

                        this.lvwCountries.Items.Add(itmX);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                this.FillList(string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                blnCancel = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem itmX = new ListViewItem();

                if (this.lvwCountries.SelectedItems.Count <= 0) return;
                itmX = this.lvwCountries.SelectedItems[0];

                CountryGuid = itmX.SubItems[colGuid.Index].Text.ToString();
                CountryName = itmX.SubItems[colName.Index].Text.ToString();
                blnCancel = false;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvwCountries_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                this.btnSelect_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Tag != null)
                    if (txtName.Text.Trim() == txtName.Tag.ToString()) return;

                string filter = txtName.Text.Trim();
                this.FillList(filter);
                txtName.Tag = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Tag != null)
                    if (txtName.Text.Trim() == txtName.Tag.ToString()) return;

                string filter = txtName.Text.Trim();
                this.FillList(filter);
                txtName.Tag = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, DialogCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSelectCountry_Load(object sender, EventArgs e)
        {

        }

    }
}