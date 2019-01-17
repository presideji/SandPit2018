using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCWorkMSTestFramework.Interfaces;
using System.Configuration;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.Configuration
{
    public class AppConfigReader : IConfig
    {
        public BrowserType GetBrowser() //29. let us "return" configuration manager below"
        {
            var browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);

        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
            //28. Now let us cretae the AppConfigKeys class in "Settings folder"

        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }

        public int GetPageLoadtimeout()
        {
            var timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.PageTimeout);
            return timeout == null ? 30 : Convert.ToInt32(timeout);
        }


        //30.now let us create "appconfigkeys" class
    }


}
