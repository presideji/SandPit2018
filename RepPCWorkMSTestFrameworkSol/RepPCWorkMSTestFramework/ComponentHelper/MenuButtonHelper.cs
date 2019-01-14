using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RepPCWorkMSTestFramework.ComponentHelper
{
    public class MenuButtonHelper
    {
        private static IWebElement _element;

        public static void SelectMenuButton(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            _element.Click();
            //the above is just basically saying when you find the button i am looking for click on it
        }

        public static bool IsButtonEnabled(By locator)
        {
            _element = GenericClassHelper.GetElement(locator);
            return _element.Enabled;
            // this means click the buttonif "button is enabled
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
            //    return _element.GetAttribute("value");
            //}

            //--NOTE - the above can be written as below



            //if (_element.GetAttribute("value") == null)
            //    return string.Empty;
            //return _element.GetAttribute("value");
            
            //-NOTE- the baove can be written as below


            return _element.GetAttribute("value") ?? string.Empty;


        }



    }
}

