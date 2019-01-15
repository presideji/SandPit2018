using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using PCWorkMSTestFramework.ComponentHelper;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.TestScript.Shots
{
    [TestClass]
    public class TakeScreenShots
    {
        [TestMethod, TestCategory("Smoke")]

        public void Screenshots()
        {
            NavigationHelper.NavigateToURl(ObjectRepository.Config.GetWebsite());

            //Screenshot screenshot = ObjectRepository.Driver.TakeScreenshot();
            //screenshot.SaveAsFile("Screen.jpeg", ScreenshotImageFormat.Jpeg);

            GenericClassHelper.TakeAScreenShot();
            GenericClassHelper.TakeAScreenShot("Landing page");
            //you put the above code in a "Try and Catch block"
            //try
            //{

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    GenericClassHelper.TakeAScreenShot();
            //    GenericClassHelper.TakeAScreenShot("Landing page");
            //}

            const string pageTitle = "Your Store";
            var title = ObjectRepository.Driver.Title;
            Assert.AreEqual(pageTitle.ToLower(), title.ToLower());
        }
    }
}
