using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PCWorkMSTestFramework.Configuration;
using PCWorkMSTestFramework.Interfaces;

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
            var baseUrl = "https://www.asda.com/";

            //21. Let us do it the standard way 
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // driver.Navigate().GoToUrl("https://www.asda.com/"); //23.we will put the link in a data folder n rewrite below
            driver.Navigate().GoToUrl(baseUrl);
            //driver.Close();
            //Lets say we will like to hold the website/page for sometime
            Thread.Sleep(5000);
            driver.Quit();
        }
        //24. let us create a "method" for the "App.Config" to prove we can read from it
         [TestMethod]
         [TestCategory("CONFIG")]
         public void Sample()
         {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
             //ConfigurationManager.AppSettings.Get("Browser"); // let do it as above

            //30.Create the "iconfig"
            //AppConfigReader appConfigReader = new AppConfigReader();//another way to do this is below
             IConfig config = new AppConfigReader();
             Console.WriteLine("The browser is {0}", config.GetBrowser());
             Console.WriteLine("The username is {0}", config.GetUsername());
             Console.WriteLine("The password is {0}", config.GetPassword());
            /*
             config.GetBrowser();
             config.GetUsername();
             config.GetPassword();
             */
         }

        //25.let us create a class in the interface folder "IConfig"

    }

    //32.now let us go to - Baseclass
}
