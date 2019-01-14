using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RepPCWorkMSTestFramework.ComponentHelper
{
    public class TextboxHelper
    {
        private static IWebElement element;

        public static void SendTextToTextbox(By locator, string text) //where wherever you find a textbox call this helper class
        {
            element = GenericClassHelper.GetElement(locator);
            element.SendKeys(text);
        }

        public static void ClearTextBox(By locator)
        {
            element = GenericClassHelper.GetElement(locator);
            element.Clear();
        }

    }
}
