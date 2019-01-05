using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
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

        
    }
}
