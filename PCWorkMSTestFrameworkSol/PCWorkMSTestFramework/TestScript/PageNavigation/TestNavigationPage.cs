using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCWorkMSTestFramework.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;

namespace PCWorkMSTestFramework.TestScript.PageNavigation
{
    [TestClass]
    public class TestNavigationPage
    {
        [TestMethod]
        [TestCategory("NEW BROWSER LAUNCH")]
        public void OpenPage()
        {
          NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());
           // var CurrentPagetitle = ObjectRepository.Driver.Title;
           // Console.WriteLine(CurrentPagetitle);// a better way to write it
            //Console.WriteLine(ObjectRepository.Driver.Title);
            Console.WriteLine(WindowHelper.GetPageTitle());

           
        
        }
    }
}
