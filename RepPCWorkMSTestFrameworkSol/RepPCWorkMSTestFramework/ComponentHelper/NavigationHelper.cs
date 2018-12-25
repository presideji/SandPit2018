using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateTOURL(string URL)
        {
            //INavigation page = ObjectRepository.Driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());
           ObjectRepository.Driver.Navigate().GoToUrl(URL);
        }
    }
}
