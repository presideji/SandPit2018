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
    public class TestLink
    {
        [TestMethod, TestCategory("CLICK ON A LINK")]
        public void ClickOnLink()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());

            //IWebElement ClickLink = ObjectRepository.Driver.FindElement(By.LinkText("Login"));
            //ClickLink.Click();

            LinkHelper.ClickLink(By.LinkText("Login"));
        }
    }
}
