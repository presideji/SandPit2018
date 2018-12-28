using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace PCWorkMSTestFramework.ComponentHelper
{
   public class LinkHelper
   {
       private static IWebElement _element;

       public static void ClickLink(By locator)
       {
           _element = GenericClassHelper.GetElement(locator);
            _element.Click();
       }
   }
}
