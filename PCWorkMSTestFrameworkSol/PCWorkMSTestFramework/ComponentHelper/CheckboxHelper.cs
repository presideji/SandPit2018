using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PCWorkMSTestFramework.ComponentHelper
{
    public class CheckboxHelper
    {
        private static IWebElement _element;

        public static void ClickCheckbox(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            _element.Click();
        }

        public static bool IsCheckboxSelected(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            string checkboxStatus = _element.GetAttribute("agree");

            if (checkboxStatus != null)
                return checkboxStatus.Equals("true") || checkboxStatus.Equals("checked");
            return false;

        }
    }
}
