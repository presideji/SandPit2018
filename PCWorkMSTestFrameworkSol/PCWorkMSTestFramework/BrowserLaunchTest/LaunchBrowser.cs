using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PCWorkMSTestFramework.BrowserLaunchTest
{
    //19 now let us add some attribute
    [TestClass]
    public class LaunchBrowser
    {
        [TestMethod]
        [TestCategory("Selenium test")]
        public void BrowserLaunch()
        {
            //20. Now us create an instance of ChromeDriver
            //ChromeDriver chromeDriver = new ChromeDriver();
            //chromeDriver.Manage()


            //22. explaining dataframework . normally, the below will be in a data file
            var baseURL = "https://www.asda.com/";

            //21. Let us do it the standard way 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // driver.Navigate().GoToUrl("https://www.asda.com/"); //23.we will put the link in a data folder n rewrite below
            driver.Navigate().GoToUrl(baseURL);
            //driver.Close();
            //Lets say we will like to hold the website/page for sometime
            Thread.Sleep(5000);
            driver.Quit();
            




        }
    }
}
