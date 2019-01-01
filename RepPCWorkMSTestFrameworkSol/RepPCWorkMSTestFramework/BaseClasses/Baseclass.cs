using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using RepPCWorkMSTestFramework.Configuration;
using RepPCWorkMSTestFramework.CustomException;
using RepPCWorkMSTestFramework.Settings;

namespace RepPCWorkMSTestFramework.BaseClasses
{
    [TestClass]
    public class Baseclass
    {
        private static FirefoxProfile GetFirefoxOptions()
        {
            var fProfile = new FirefoxProfile();
            var fXManager = new FirefoxProfileManager();
            fXManager.GetProfile("default");
            return fProfile;
        }
        private static ChromeOptions GetChromeOptions()
        {
            var cOptions = new ChromeOptions();
            cOptions.AddArgument("start-maximized");
            return cOptions;
        }

        private static InternetExplorerOptions GetIEOption()
        {
            var iEOptions = new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                EnsureCleanSession = true
            };
            return iEOptions;



        }

        private static IWebDriver GetFirefoxBrowser()
        {
            // IWebDriver driver = new FirefoxDriver(GetFirefoxOptions());
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        private static IWebDriver GetChromeBrowser()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }

        private static IWebDriver GetIEBrowser()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOption());
            return driver;
        }

        private static IWebDriver GetEdgeBrowser()
        {
            IWebDriver driver = new EdgeDriver();
            return driver;
        }

        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc)
        {
            ObjectRepository.Config = new AppConfigReader();

            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxBrowser();
                    break;
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeBrowser();
                    break;
                case BrowserType.IExplorer:
                    ObjectRepository.Driver = GetIEBrowser();
                    break;
                default:

                    throw new UnknownBrowser("Browser is unknown: " +
                        ObjectRepository.Config.GetBrowser().ToString());

            }

        }
        [AssemblyCleanup]

        public static void TearDown()
        {
            if (ObjectRepository.Driver == null) return;
            ObjectRepository.Driver.Close();
            ObjectRepository.Driver.Quit();
        }
    }
}
