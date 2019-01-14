using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RepPCWorkMSTestFramework.ComponentHelper
{
    public class RadioButtonHelper
    {
        private static IWebElement _element;

        public static void ClickOnOneRadioButton(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            _element.Click();
            //the above is just basically saying when you find the button i am looking for click on it
            //if you notice it is the same code we have been repeating
        }

        public static bool IsRadioButtonSelected(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            var radioButtonStatus = _element.GetAttribute("checked");

            if (radioButtonStatus != null) // this means check theradiobutton is not false and if it has been selected tell
            //us that true with code on the next line
            {
                return radioButtonStatus.Equals(true) || radioButtonStatus.Equals("checked");
            }

            return false;// if it has not been check return it "that if has not being checked" and then click it
        }

        public static void GetExactRadioButton(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);

        }

    }
}
