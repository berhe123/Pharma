using System;
using System.Collections.Generic;
using System.Text;
namespace Pharma
{
    class CImageSetting
    {

        #region Organization
        public static byte[] OrganizationLogo = null;
        #endregion
        public static void GetSettings()
        {
            try
            {
                CImageAppSetting CImageAppSetting = new CImageAppSetting();

                 CImageSetting.OrganizationLogo = CImageAppSetting.GetImageSetting("Pharma", "OrganizationLogo", null);
                          }
            catch (Exception ex)
            {
                throw new Exception("CSettings::GetSettings::Error! " + ex.Message, ex);
            }
        }

    }
}

