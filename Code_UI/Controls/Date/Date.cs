using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Pharma
{
    public partial class Date : UserControl
    {
        private PopupWindowHelper popupHelper = null;
        
        // properties
        private bool _EthiopianDate;
        public bool EthiopianDate
        {
            get { return _EthiopianDate; }
            set { _EthiopianDate = value; }
        }

        public string Value
        {
            get 
            {
                
                DateTime dateValue;
                bool result;
                string str = String.Format("{0}/{1}/{2}", Day, Month, Year);

                result = DateTime.TryParseExact(String.Format("{0}/{1}/{2}", Day, Month, Year), CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dateValue);
                //result = DateTime.TryParse(String.Format("{0}/{1}/{2}", Day, Month, Year), CSettings.Culture, CSettings.DateTimeStyle, out dateValue);

                if (!result)
                    return DateTime.MinValue.ToString(CSettings.DateFormat);
                else
                    return dateValue.ToString(CSettings.DateFormat);
            }
            set 
            {
                DateTime dateValue;
                bool result;

                result = DateTime.TryParseExact(value, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dateValue);
               
                if (result)
                {
                    Day = dateValue.Day.ToString();
                    Month = dateValue.Month.ToString();
                    Year = dateValue.Year.ToString();
                }
                else
                {
                    Day = DateTime.MinValue.Day.ToString();
                    Month = DateTime.MinValue.Month.ToString();
                    Year = DateTime.MinValue.Year.ToString();
                }
            }
        }
        public string Day
        {
            get { return txtDay.Text == string.Empty ? "01" : txtDay.Text; }
            set { txtDay.Text = value == string.Empty ? "01" : value; }
        }
        public string Month
        {
            get { return txtMonth.Text == string.Empty ? "01" : txtMonth.Text; }
            set { txtMonth.Text = value == string.Empty ? "01" : value; }
        }
        public string Year
        {
            get { return txtYear.Text == string.Empty ? "2009" : txtYear.Text; }
            set { txtYear.Text = value == string.Empty ? "2009" : value; }
        }

        public event EventHandler DayChanged;
        public event EventHandler MonthChanged;
        public event EventHandler YearChanged;
        public event EventHandler DateChanged;

        public Date()
        {
            InitializeComponent();

            //
            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

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
        protected override void OnHandleCreated(EventArgs e)
        {
            popupHelper.AssignHandle(this.Handle);
        }

        // Override the ToString method to display an complex number in the suitable format:
        public override string ToString()
        {
            return (String.Format("{0}/{1}/{2}", Day, Month, Year));
        }

        private void ResizeControls()
        {
            this.UpDownDate.Width = 16;
            this.btnPopupCalendar.Width = 28;

            this.tlpDate.Width = this.Width - 2;
            this.tlpDate.Height = this.Height - 2;
        }
        private void Date_FontChanged(object sender, EventArgs e)
        {
            tlpDate.Font = this.Font;
            txtDay.Font = this.Font;
            lblDayMonthSeparator.Font = this.Font;
            txtMonth.Font = this.Font;
            lblMonthYearSeparator.Font = this.Font;
            txtYear.Font = this.Font;
            UpDownDate.Font = this.Font;
            btnPopupCalendar.Font = this.Font;

            ResizeControls();
        }
        private void Date_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }
        private void Date_Load(object sender, EventArgs e)
        {

        }
        private void Date_Enter(object sender, EventArgs e)
        {
            this.txtDay.Focus();
        }
        private void tlpDate_MouseClick(object sender, MouseEventArgs e)
        {
            txtYear.Focus();
        }

        public static void AllowUIntegerOnly(TextBox txtUInt)
        {
            uint i;
            
            if (!uint.TryParse(txtUInt.Text, out i) & txtUInt.TextLength > 0)
            {
                if (txtUInt.Tag != null)
                    txtUInt.Text = txtUInt.Tag.ToString();
                else
                    txtUInt.Text = string.Empty;
            }
            else
                txtUInt.Tag = txtUInt.Text;

        }
        public static bool IsValidDay(int value)
        {
            if (value <= 0 | value > 31)
                return false;
            else
                return true;
        }
        public static bool IsValidMonth(int value)
        {
            if (value <= 0 | value > 12)
                return false;
            else
                return true;
        }
        public static bool IsValidYear(int value)
        {
            if (Convert.ToString(value).Length > 4)
                return false;
            else if (value <= 2000 | value > 2099)
                return false;
            else
                return true;
        }

        private void popupHelper_PopupClosed(object sender, PopupClosedEventArgs e)
        {
            Console.WriteLine("Popup Closed");
            frmCalendar popup = (frmCalendar)e.Popup;
            this.Value = popup.SelectedDate;
        }
        private void popupHelper_PopupCancel(object sender, PopupCancelEventArgs e)
        {
            Console.WriteLine("Popup Cancel, mouse clicked at {0}", e.CursorLocation);
        }
        private void btnPopupCalendar_Click(object sender, EventArgs e)
        {
            frmCalendar popup = new frmCalendar();
            popup.SelectedDate = this.Value;
            Point location = this.PointToScreen(new Point(this.txtDay.Left, this.tlpDate.Bottom));
            popupHelper.ShowPopup(this.ParentForm, popup, location);
        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            AllowUIntegerOnly(txtDay);
            if (DayChanged != null)
                DayChanged(this, new EventArgs());
            if (DateChanged != null)
                DateChanged(this, new EventArgs());
        }
        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            AllowUIntegerOnly(txtMonth);
            if (MonthChanged != null)
                MonthChanged(this, new EventArgs());
            if (DateChanged != null)
                DateChanged(this, new EventArgs());
        }
        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            AllowUIntegerOnly(txtYear);
            if (YearChanged != null)
                YearChanged(this, new EventArgs());
            if (DateChanged != null)
                DateChanged(this, new EventArgs());
        }

        private void UpDownDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt;
            dt = Convert.ToDateTime(this.Value, CSettings.Culture);
            if (UpDownDate.Value > 0)
                Value = dt.AddDays(1).ToString(CSettings.DateFormat);
            else if (UpDownDate.Value < 0)
                Value = dt.AddDays(-1).ToString(CSettings.DateFormat);

            UpDownDate.Value = 0;
        }

        private void UpDownDate_BackColorChanged(object sender, EventArgs e)
        {
            tlpDate.BackColor = this.BackColor;
            txtDay.BackColor = this.BackColor;
            lblDayMonthSeparator.BackColor = this.BackColor;
            txtMonth.BackColor = this.BackColor;
            lblMonthYearSeparator.BackColor = this.BackColor;
            txtYear.BackColor = this.BackColor;
        }

    }
}
