using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using PCWorkMSTestFramework.Setting;

namespace PCWorkMSTestFramework.ComponentHelper
{
    public class GenericClassHelper
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                return ObjectRepository.Driver.FindElements(locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
            //return ObjectRepository.Driver.FindElements(locator).Count == 1;

        }

        public static IWebElement GetElement(By locator)
        {
            if (IsElementPresent(locator))
            {
                return ObjectRepository.Driver.FindElement(locator);
            }
            //else
            {
                throw new NoSuchElementException("Element is not present" + locator);


            }
        }

        public static void TakeAScreenShot(string filename = "Screenshot")
        {
            /*
             * *FOR THE STRING ARGUMENT ABOVE, IF THE TAKESCREENSHOT FUNCTION IS CALLED
             * BUT THE USER DOES NOT PROVIDE AN ARGUEMENT FOR FILENAME, 'Screenshot' WILL BE
             * USED AS DEFAULT. IF AN ARGUMENT IS PROVIDED, IT WILL OVERRIDE 'SHOT'
             */

            Screenshot screenshot = ObjectRepository.Driver.TakeScreenshot();
            if (filename.Equals("Screenshot"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyyMMMMdddd") + ".jpeg";
                screenshot.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
                return;
            }
            //screenshot.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
            else
            {
                filename = filename + DateTime.UtcNow.ToString("yyyyMMMMdddd") + ".jpeg";
                screenshot.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
            }
        }
    }
}

