using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RepPCWorkMSTestFramework.ComponentHelper
{
    class TextboxHelper
    {
        private static IWebElement element;

        public static void SendTextToTextbox(By locator, string text)
        {
            element = GenericClassHelper.GetElement(locator);
            element.SendKeys(text);
        }

        public static void ClearText(By locator)
        {
            element = GenericClassHelper.GetElement(locator);
            element.Clear();

           
        }
    }
}
