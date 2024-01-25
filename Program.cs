using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SecurityManager;

namespace Pharma
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static bool blnIsAuthenticated = false;
        public static int intUserId = 0;
        public static int intUserAccessRight = 0;
        public static string strUserName="";


        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogIn());
            if (!blnIsAuthenticated) return;

            frmMain main = new frmMain();
            frmSplash splash = new frmSplash();

            Application.DoEvents();
            splash.Show(main);

            Application.DoEvents();
            splash.SplashText = "   Loading global settings...";
            Application.DoEvents();

            CSettings.GetSettings();

            Application.DoEvents();
            splash.SplashText = "   Loading lookups...";
            Application.DoEvents();

            CUnitOfMeasurements.LoadUnitOfMeasurementsToCollection();
            CLocations.LoadLocationsToCollection();
            
            CDosageForms.LoadDosageFormsToCollection();
            CCountries.LoadCountriesToCollection();
            CManufacturers.LoadManufacturersToCollection();
            CCustomers.LoadCustomersToCollection();

           
            Application.DoEvents();
            splash.SplashText = "Loading main interface window...";
            Application.DoEvents();

            splash.Close();
            //Application.Run(new frmControlTest());
            Application.Run(main);
        }
    }
}