using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.TestLinkClick
{
    [TestClass]
    public class TestLink
    {
        [TestMethod, TestCategory("CLICK ON A LINK")]
        public void ClickOnLink()
        {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());//This will launch website

            //IWebElement ClickLink = ObjectRepository.Driver.FindElement(By.LinkText("Login"));
            //ClickLink.Click();

            LinkHelper.ClickLink(By.LinkText("Login"));


        }
    }
}
