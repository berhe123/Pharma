using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Pharma
{
    public partial class frmCalendar : Form
    {
        /// <summary>
        /// The selected date in the month calendar
        /// </summary>
        private DateTime selectedDate = DateTime.MinValue;

        public frmCalendar()
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

        /// <summary>
        /// Checks if a date is selected in the calendar, if so, 
        /// stores the value and closes the form.
        /// </summary>
        private void selectDate()
        {
            this.selectedDate = monthCalendar.SelectionStart;
            this.Close();
        }

        /// <summary>
        /// Gets/sets the date selected in the monthCalendar.
        /// </summary>
        public string SelectedDate
        {
            get
            {
                return this.selectedDate.ToString(CSettings.DateFormat);
            }
            set
            {
                DateTime dateValue;
                bool result;

                result = DateTime.TryParseExact(value, CSettings.DateFormat, CSettings.Culture, CSettings.DateTimeStyle, out dateValue);
                if (result)
                {
                    this.selectedDate = Convert.ToDateTime(dateValue);
                    this.monthCalendar.SetDate(dateValue);
                }
                else
                {
                    this.selectedDate = DateTime.MinValue;
                    this.monthCalendar.SetDate(DateTime.MinValue);
                }
            }
        }

        /// <summary>
        /// Respond to key down events in the monthCalendar control.
        /// </summary>
        /// <param name="sender">monthCalendar control which received the key event</param>
        /// <param name="e">Information about the key that was depressed.</param>
        private void monthCalendar_KeyDown(object sender, KeyEventArgs e)
        {
            // If a date is selected and we get a return, then close
            if (e.KeyCode == Keys.Return)
            {
                selectDate();
            }
        }

        /// <summary>
        /// Respond to clicks on a date in the monthCalendar control.
        /// </summary>
        /// <param name="sender">monthCalendar control which was clicked</param>
        /// <param name="e">Not used</param>
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // If a date has been selected by clicking, then close
            selectDate();
        }

        private void frmCalendar_Resize(object sender, EventArgs e)
        {
            monthCalendar.Top = 1;
            monthCalendar.Left = 1;
            this.Width = monthCalendar.Width + 2;
            this.Height = monthCalendar.Height + 2;
        }

    }
}
