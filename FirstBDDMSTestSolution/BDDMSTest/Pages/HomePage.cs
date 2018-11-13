using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDMSTest.Pages
{
   public class HomePage : BasePage
    {
        [FindsBy(How = How.TagName, Using = "a")]
        private IList<IWebElement> MyAccount { get; set; }

       public HomePage(IWebDriver driver) : base(driver)
       {
       }

       public AccountPage GoToAccountPage()
       {
           foreach (var element in MyAccount)
           {
               if (!element.Text.ToLower().Contains("my account")) continue;
               element.Click();
               break;
           }
           return new AccountPage(Driver);
       }
    }
}
