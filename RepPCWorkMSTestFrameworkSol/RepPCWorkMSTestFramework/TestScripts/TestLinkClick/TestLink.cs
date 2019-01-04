using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RepPCWorkMSTestFramework.ComponentHelper;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.TestScripts.TestLinkClick
{
    [TestClass]
    public class TestLink
    {
        [TestMethod, TestCategory("CLICK ON A LINK")]
        public void ClickOnLink()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());
            //IWebElement ClickLink = ObjectRepository.Driver.FindElement(By.LinkText("Login"));
            //ClickLink.Click(); //we can simplify this as below

            LinkHelper.ClickLink(By.LinkText("Login"));
        }
    }
}
