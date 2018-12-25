using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.WebElementsTest
{
    [TestClass]
    public class ElementsTest
    {
        [TestMethod, TestCategory("WEB ELEMENTS TEST")]
        public void GetWebElement()
        {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            ObjectRepository.Driver.FindElement(By.Id("hero"));
            ObjectRepository.Driver.FindElement(By.ClassName("navbar-right"));
            ObjectRepository.Driver.FindElement(By.TagName("a"));
            //ObjectRepository.Driver.FindElement(By.XPath("//*[@id="hero"]/div[1]/div[1]/div/h1"));
            //ObjectRepository.Driver.FindElement(By.LinkText("Visit Marketplace"));
            //ObjectRepository.Driver.FindElement(By.PartialLinkText("Visit"));
            ObjectRepository.Driver.FindElement(By.CssSelector("#hero > div.container > div.row > div > p.hidden-xs > a.btn.btn-white.btn-xl"));
            //ObjectRepository.Driver.FindElement(By.Name(""));












































































































































        }
    }
}
