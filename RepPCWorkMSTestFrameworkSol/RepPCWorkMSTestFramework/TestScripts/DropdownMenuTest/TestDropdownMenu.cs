using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RepPCWorkMSTestFramework.ComponentHelper;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.TestScripts.DropdownMenuTest
{
    [TestClass]
    public class TestDropdownMenu
    {
        [TestMethod, TestCategory("SELECT MENU OPTION")]

        public void MenuSelect()
        {
            NavigationHelper.NavigateTOURL(ObjectRepository.Config.GetWebsite());

            //IWebElement menuElement = ObjectRepository.Driver.FindElement(By.LinkText("My Account"));
            //menuElement.Click();
            //SelectElement menuPick = new SelectElement(menuElement);
            //menuPick.SelectByText("Register");

            //IWebElement menuElement = ObjectRepository.Driver.FindElement(By.LinkText("Laptops & Notebooks"));
            //SelectElement menuPick = new SelectElement(menuElement);
            //menuPick.SelectByText("Macs (0)");


        }
       


    }
}
