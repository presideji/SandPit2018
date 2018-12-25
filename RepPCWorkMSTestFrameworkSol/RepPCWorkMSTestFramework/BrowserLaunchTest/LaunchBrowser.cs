using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using RepPCWorkMSTestFramework.Configuration;
using RepPCWorkMSTestFramework.Interfaces;

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

        [TestMethod]
        [TestCategory("CONFIG")]
        public void Sample()
        {
            //ConfigurationManager.AppSettings.Get("Browser");
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            IConfig config = new AppConfigReader();
            //AppConfigReader appConfigReader = new AppConfigReader();
            Console.WriteLine("The browser is : {0}", config.GetBrowser());
            Console.WriteLine("The username is : {0}", config.GetUsername());
            Console.WriteLine("The password is : {0}", config.GetPassword());
            /*
            config.GetBrowser();
            config.GetUsername();
            config.GetPassword();
            */
        }



    }
}
