using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.BrowserAction
{
    [TestClass]
    public class GenericBrowserActions
    {
        private TimeSpan PollingInterval;

        [TestMethod, TestCategory("BROWSER ACTIONS")]
        public void SimulateActions()
        {
            //ObjectRepository.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
                //we do not need above any more
            //NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            NavigationHelper.NavigateToURl("https://www.bbc.co.uk/");


           //NavigationHelper.NavigateToURl("https://demo.opencart.com/");
           // ObjectRepository.Driver.Manage().Window.Maximize();

            MenuButtonHelper.SelectMenuButton(By.Id("idcta-username"));
            //ObjectRepository.Driver.Navigate().Back();
            //since we have created a helper class, we will replace it with the below
            BrowserActionHelper.BackButton();
            //ObjectRepository.Driver.Navigate().Forward();
            BrowserActionHelper.ForwardButton();
            //ObjectRepository.Driver.Navigate().Refresh();
            BrowserActionHelper.RefreshButton();
        }

        [TestMethod, TestCategory("EXPLICIT WAIT")]

        public void TestExplicitWait()
        {
           // string me = "andre";

            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            var wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(30));
            {
                PollingInterval = TimeSpan.FromMilliseconds(250);
            }
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
           // wait.Until(WaitForElement()); //we comment this out because of the "waitforstring" below and we now have
           //wait.Until(WaitForString());
           wait.Until(WaitForElementTwo());

           TextboxHelper.SendTextToTextbox(By.ClassName("btn-default"), "Andre");

        }

        private static Func<IWebDriver, bool> WaitForElement() // we just want to know  if it exist
        {
            //Console.WriteLine("Waiting to select the search button"); //we do not need it just put it to show us it works
            return (x) => x.FindElements(By.ClassName("btn-default")).Count == 1;
        }

        private static Func<IWebDriver, string> WaitForString() //wait until the string is display
        {
            return (x) => x.Title.Equals("Your Store") ? x.Title : null; //confirm page title "contains" or "equal" to "Your Store" if not
            //no

        }

        private static Func<IWebDriver, IWebElement> WaitForElementTwo() //look through it
        {
            Console.WriteLine("Waiting to select the search button");
            return x => x.FindElements(By.ClassName("btn-default")).Count == 1
                ? x.FindElement(By.ClassName("btn-default"))
                : null;


        }
    }
}
