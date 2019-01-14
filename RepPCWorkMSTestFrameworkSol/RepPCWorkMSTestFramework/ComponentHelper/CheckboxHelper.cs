using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RepPCWorkMSTestFramework.ComponentHelper
{
    public class CheckboxHelper
    {
        private static IWebElement _element;

        public static void ClickCheckbox(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            _element.Click();
        }


        //now what if the checkbox is pre-ticked. We need a "conditional statement" that says if "ticked leave it"
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
