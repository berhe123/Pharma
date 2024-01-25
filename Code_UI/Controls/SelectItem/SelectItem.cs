using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharma.Code_UI.Controls.SelectItem
{
    public partial class SelectItem : UserControl
    {
        private PopupWindowHelper popupHelper = null;

        private Form formToPopup;
        public Form FormToPopup
        {
            get { return formToPopup; }
            set { formToPopup = value; }
        }

        public event EventHandler BeforePopup;

        public SelectItem()
        {
            InitializeComponent();

            //
            popupHelper = new PopupWindowHelper();
            popupHelper.PopupClosed += new PopupClosedEventHandler(popupHelper_PopupClosed);
            popupHelper.PopupCancel += new PopupCancelEventHandler(popupHelper_PopupCancel);

            //


        }
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

        private void popupHelper_PopupClosed(object sender, PopupClosedEventArgs e)
        {
            Console.WriteLine("Popup Closed");
            //frmCalendar popup = (frmCalendar)e.Popup;
            //this.Value = popup.SelectedDate;
        }
        private void popupHelper_PopupCancel(object sender, PopupCancelEventArgs e)
        {
            Console.WriteLine("Popup Cancel, mouse clicked at {0}", e.CursorLocation);
        }

        private void ResizeControls()
        {
            this.btnPopupSelectionDialog.Width = 28;

            this.tlpSelectItem.Width = this.Width - 2;
            this.tlpSelectItem.Height = this.Height - 2;
        }
        private void SelectItem_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void btnPopupSelectionDialog_Click(object sender, EventArgs e)
        {
            //frmCalendar popup = new frmCalendar();

            if (BeforePopup != null) BeforePopup(this, new EventArgs());
            Form popup = formToPopup;
            if (popup == null) return;

            popup.FormBorderStyle = FormBorderStyle.None;
            //popup.SelectedDate = this.Value;
            Point location = this.PointToScreen(new Point(this.txtSelectedItem.Left, this.tlpSelectItem.Bottom));
            popupHelper.ShowPopup(this.ParentForm, popup, location);
        }

    }
}
