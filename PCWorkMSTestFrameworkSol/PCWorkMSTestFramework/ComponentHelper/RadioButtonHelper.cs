using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PCWorkMSTestFramework.ComponentHelper
{
    public class RadioButtonHelper
    {
        private static IWebElement _element;

        public static void ClickOneRadiobutton(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            _element.Click();
        }

        public static bool IsRadioButtonSelected(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            var radioButtonStatus = _element.GetAttribute("checked");

            if (radioButtonStatus != null) //check the radio button is not null.That is, it is selected
            {
                return radioButtonStatus.Equals("true") || radioButtonStatus.Equals("checked");//if it
                //has been checked return the value, if not check it
            }
            return false;

        }

        public static void GetExactradioButton(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            IList<IWebElement> radio = _element.FindElements(By.TagName("input"));

            foreach (var radioOption in radio)
            {
                if (radioOption.GetAttribute("value").Equals("0"))
                {
                    radioOption.Click();
                }
            }

        }

    }
}
