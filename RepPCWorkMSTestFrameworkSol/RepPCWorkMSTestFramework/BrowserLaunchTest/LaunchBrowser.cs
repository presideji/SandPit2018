using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace RepPCWorkMSTestFramework.BrowserLaunchTest
{
    [TestClass]
    public class LaunchBrowser
    {
        [TestMethod]
        [TestCategory("Selenium Tests")]
        public void BrowserLaunch()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://www.asda.com/");
            //driver.Close();
            //Thread.Sleep(5000);
            //driver.Quit();


            var baseURL = "https://www.bbc.co.uk";
            //Let us use Internet explorer now
            IWebDriver driver = new InternetExplorerDriver();
            driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
            driver.Navigate().GoToUrl(baseURL);
            // driver.Close();
            Thread.Sleep(5000);
            driver.Quit();




        }


    }
}
