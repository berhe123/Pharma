using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
namespace Pharma
{
    partial class frmSplash : Form
    {
        // This delegate enables asynchronous calls for closing
        // the splash form.
        delegate void CloseSplashCallback();

        private System.Timers.Timer aTimer;
        private bool bAlreadyIn = false;

        public string SplashText
        {
            get { return this.txtSplash.Text; }
            set { this.txtSplash.Text = value; }
        }

        public frmSplash()
        {
            InitializeComponent();
            //this.labelProductName.Text = AssemblyProduct;
            //this.labelVersion.Text = String.Format("Version {0} ", AssemblyVersion);
            //this.labelCopyright.Text = String.Format("Copyright {0} ", AssemblyCopyright);
            //this.labelCompanyName.Text = AssemblyCompany;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void frmSplash_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!bAlreadyIn)
            {
                bAlreadyIn = true;
                // Create a timer with a ten second interval.
                aTimer = new System.Timers.Timer(1500);
                aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
                aTimer.Start();
                e.Cancel = true;
            }
            else
            {
                aTimer.Dispose();
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            this.CloseSplash();
        }

        private void CloseSplash()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                CloseSplashCallback d = new CloseSplashCallback(CloseSplash);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.Close();
            }
        }

        private void picSplash_Click(object sender, EventArgs e)
        {

        }

    }
}


