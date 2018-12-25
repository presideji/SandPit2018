using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToURl(string url)
        {
            //INavigation page = ObjectRepository.Driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Navigate().GoToUrl(url);

        }
    }


}
