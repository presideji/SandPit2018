using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.BrowserAction
{
    [TestClass]
    public class GenericBrowserActions
    {
        [TestMethod, TestCategory("BROWSER ACTIONS")]
        public void SimulateActions()
        {
           NavigationHelper.NavigateToURl("https://demo.opencart.com/");
            ObjectRepository.Driver.Manage().Window.Maximize();
            MenuButtonHelper.SelectMenuButton(By.ClassName("btn-default"));
            //ObjectRepository.Driver.Navigate().Back();
            //since we have created a helper class, we will replace it with the below
            BrowserActionHelper.BackButton();
            //ObjectRepository.Driver.Navigate().Forward();
            BrowserActionHelper.ForwardButton();
            //ObjectRepository.Driver.Navigate().Refresh();
            BrowserActionHelper.RefreshButton();
        }


    }
}
