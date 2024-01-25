using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pharma
{
    public partial class frmControlTest : Form
    {
        [DllImport("user32.dll")]
        static  extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        [Flags]
        enum AnimateWindowFlags
        {   AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }

        public frmControlTest()
        {
            InitializeComponent();
        }

        private void selectItem1_Load(object sender, EventArgs e)
        {

        }

        private void selectItem1_BeforePopup(object sender, EventArgs e)
        {
            selectItem1.FormToPopup = new frmSelectInvoice();
        }

        private void frmControlTest_Load(object sender, EventArgs e)
        {
            AnimateWindow(this.Handle, 2000, AnimateWindowFlags.AW_BLEND);
        }
    }
}
