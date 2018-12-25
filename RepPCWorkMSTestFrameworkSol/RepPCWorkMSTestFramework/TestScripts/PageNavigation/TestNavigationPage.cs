using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using RepPCWorkMSTestFramework.ComponentHelper;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.TestScripts.PageNavigation
{
    [TestClass]
    public class TestNavigationPage
    {
        [TestMethod]
        [TestCategory("NEW BROWSER LAUNCH")]
        public void OpenPage()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());


        }
    }
}
