using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.DropdownMenuTest
{
    [TestClass]
    public class TestDropdownMenu
    {
        [TestMethod, TestCategory("SELECT A MENU OPTION")]
        public void MenuSelect()
        {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            IWebElement menuElement = ObjectRepository.Driver.FindElement(By.ClassName("dropdown-toggle"));
            menuElement.Click();
            //SelectElement menuPick = new SelectElement(menuElement);
            //menuPick.SelectByText("Register");

            //IWebElement menuElement = ObjectRepository.Driver.FindElement(By.LinkText("Laptops & Notebooks"));
            //SelectElement menuPick = new SelectElement(menuElement);
            //menuPick.SelectByText("Mac (0)");


        }
    }
}
