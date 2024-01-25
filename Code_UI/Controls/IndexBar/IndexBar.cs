using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pharma
{
    public partial class IndexBar : UserControl
    {
        // The total number of controls on this form
        int NumberOfControls = 21;

        // The vertical spacing between two controls
        int VerticalSpacing = 1;

        // The horizontal spacing between two controls
        int HorizontalSpacing = 1;

        // Letters to be sent with the event
        string[] l = new string[] { "All", "A", "B", "C", "D", "E", "F", "G", "H", "I, J", 
                                      "K", "L", "M", "N", "O", "P", "Q, R", "S", "T",
                                      "U, V, W", "X, Y, Z"};

        // This event will be raised when anyone of the buttons is clicked
        public event EventHandler LetterListener;

        // Clicked letter holder 
        string SeletedLetter;

        // For returning selected letter
        public class IndexBarEventArgs : EventArgs
        {
            public IndexBarEventArgs(string Selectedletter)
            {
                _SelectedLetter = Selectedletter;
            }

            string _SelectedLetter;
            public string SelectedLetter
            {
                get { return _SelectedLetter; }
            }
        }

        // Control Alignment
        public enum IndexBarAlignment
        {
            Horizontal = 0,
            Vertical = 1
        }
        private IndexBarAlignment _Alignment = IndexBarAlignment.Vertical;
        public IndexBarAlignment Alignment
        {
            get { return _Alignment; }
            set { _Alignment = value; ResizeControls(); }
        }

        public IndexBar()
        {
            InitializeComponent();
        }
        private void AdjustFont()
        {
            foreach (Control control in this.Controls)
            {
                control.Font = this.Font;
            }
        }
        private void ResizeControls()
        {
            if (_Alignment == IndexBarAlignment.Vertical)
                ResizeControlsVertival();
            else if (_Alignment == IndexBarAlignment.Horizontal)
                ResizeControlsHorizontal();
            else
                ResizeControlsVertival();
        }
        private void ResizeControlsVertival()
        {
            int FormHeight = 0;
            int SizeForChildControls = 0;
            int UnitSize = 0;
            int Rank = 0;

            // Actual form height
            FormHeight = this.Height;

            // Remaining size after removing vertical spacing
            SizeForChildControls = FormHeight - (NumberOfControls * VerticalSpacing);
            SizeForChildControls -= 2 * VerticalSpacing; // Subtract top and bottom margins

            // Allowed size for a single control
            UnitSize = SizeForChildControls / NumberOfControls;

            foreach (Control control in this.Controls)
            {
                control.Left = 2;
                control.Width = this.Width - 4;
                control.Height = UnitSize;
                Rank = Convert.ToInt32(control.Tag.ToString());
                control.Top = (UnitSize + VerticalSpacing) * Rank;
            }
        }
        private void ResizeControlsHorizontal()
        {
            int FormWidth = 0;
            int SizeForChildControls = 0;
            int UnitSize = 0;
            int Rank = 0;

            // Actual form width
            FormWidth = this.Width;

            // Remaining size after removing horizontal spacing
            SizeForChildControls = FormWidth - (NumberOfControls * HorizontalSpacing);
            SizeForChildControls -= 2 * HorizontalSpacing; // Subtract left and right margins

            // Allowed size for a single control
            UnitSize = SizeForChildControls / NumberOfControls;

            foreach (Control control in this.Controls)
            {
                control.Top = 2;
                control.Height = this.Height - 4;
                control.Width = UnitSize;
                Rank = Convert.ToInt32(control.Tag.ToString());
                control.Left = (UnitSize + HorizontalSpacing) * Rank;
            }
        }

        private void LetterClicked(object sender, EventArgs e)
        {
            if (sender != null)
            {
                this.SeletedLetter = ((Button)sender).Text;
                if (this.LetterListener != null) 
                    LetterListener(this, new IndexBarEventArgs(SeletedLetter));
            }
            else
            {
                if (this.LetterListener != null) 
                    LetterListener(this, new IndexBarEventArgs("All"));
            }
        }

        private void IndexBar_Load(object sender, EventArgs e)
        {
            this.SuspendLayout();
            AdjustFont();
            ResizeControls();
            this.ResumeLayout(false);
        }
        private void IndexBar_FontChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();
            AdjustFont();
            ResizeControls();
            this.ResumeLayout(false);
        }
        private void IndexBar_Resize(object sender, EventArgs e)
        {
            this.SuspendLayout();
            ResizeControls();
            this.ResumeLayout(false);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnE_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnF_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnH_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnIJ_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnK_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnL_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnM_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnN_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnP_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnQR_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnT_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnUVW_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }
        private void btnXYZ_Click(object sender, EventArgs e)
        {
            LetterClicked(sender, e);
        }

    }
}
