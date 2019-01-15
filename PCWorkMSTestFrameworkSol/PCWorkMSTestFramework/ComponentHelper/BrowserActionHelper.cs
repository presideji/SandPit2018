using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.ComponentHelper
{
    public class BrowserActionHelper
    {
        public static void MaximizeBrowser()
        {
            ObjectRepository.Driver.Manage().Window.Maximize();
        }

        public static void BackButton()
        {
            ObjectRepository.Driver.Navigate().Back();
        }

        public static void ForwardButton()
        {
            ObjectRepository.Driver.Navigate().Back();
        }

        public static void RefreshButton()
        {
            ObjectRepository.Driver.Navigate().Back();
        }
    }
}
