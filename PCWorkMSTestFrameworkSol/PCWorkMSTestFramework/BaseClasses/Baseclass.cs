using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using PCWorkMSTestFramework.Configuration;
using PCWorkMSTestFramework.CustomException;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.BaseClasses
{
    //43. let us create Test Class so that assembly initialize can work. go to UnitTest1 to remove "AssemblyInitialize"
    [TestClass]

    //33.Creating BAse class
    public class Baseclass
    {
        private static FirefoxProfile GetFirefoxOptions()
        {
            var fProfile = new FirefoxProfile();
            var fxManager = new FirefoxProfileManager();
            fProfile = fxManager.GetProfile("default");
            return fProfile;
        }
        private static ChromeOptions GetChromeOptions()
        {
            var cOption = new ChromeOptions();
            cOption.AddArgument("start-maximized");
            return cOption;
        }

        private static InternetExplorerOptions GetIeOption()
        {
            var iEOption = new InternetExplorerOptions();
            iEOption.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            iEOption.EnsureCleanSession = true;
            return iEOption;
        }
     

    private static IWebDriver GetFirefoxBrowser()
        {
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
            IWebDriver driver = new InternetExplorerDriver(GetIeOption());
            return driver;
        }


        private static IWebDriver GetEdgeBrowser()
        {
            IWebDriver driver = new EdgeDriver();
            return driver;
        }

        //34 let us go and create object repository in the folder setting

        //36 new let us reference ObjectRepository

        //42. we now intialize
        [AssemblyInitialize]
        public static void InitWebDriver(TestContext tc) //37 all the below is telling us if the key matches firefox, get firefox
            //for us, jump out and do whatever we want to do with firefox
        {
            ObjectRepository.Config = new AppConfigReader();// we can change the below to " a condition" statement, if else statement

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
                    /* if none of the pre-defined browser are referenced we need an input to handle the error that will be
                     * displayed. We can create a custom error handler
                        */

                    /*
                    if (ObjectRepository.Config.GetBrowser() == BrowserType.Firefox)
                        ObjectRepository.Driver = GetFirefoxBrowser();
                    else if (ObjectRepository.Config.GetBrowser() == BrowserType.Chrome)
                    {
                        ObjectRepository.Driver = GetChromeBrowser();
                    }
                    else if (ObjectRepository.Config.GetBrowser() == BrowserType.IExplorer)
                    {
                        ObjectRepository.Driver = GetIEBrowser();
                    }
                     */
                    
                //38 Now let us create a custom error handler in "customException

                //40 from unknowbrowser
                throw new UnknownBrowser("Browser is unknown: " +
                    ObjectRepository.Config.GetBrowser().ToString());

                    //41 now let us go and set up "AssemblyInitialize"

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
