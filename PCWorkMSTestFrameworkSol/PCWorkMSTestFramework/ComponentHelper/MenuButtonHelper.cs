using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PCWorkMSTestFramework.ComponentHelper
{
    public class MenuButtonHelper
    {
        private static IWebElement _element;

        public static void SelectMenuButton(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            _element.Click();
        }

        public static bool IsButtonEnabled(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            return _element.Enabled; //this check if the button is visible but grey out
        }

        public static string GetButtonText(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            //if (_element.GetAttribute("value") == null)
            //{
            //    return String.Empty;
            //}
            //else
            //{
            //    return _element.GetAttribute("value"); //here "value" is "Continue"
            //}

        //we can write the above as below
            //if (_element.GetAttribute("value") == null)
            //    return string.Empty;
            //return _element.GetAttribute("value");

        //we can also write the above as below
        return _element.GetAttribute("value") ?? string.Empty;
        }

        //let us go and call it in "SelectMenuButton"


    }
}
