using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace BDDMSTest.Pages
{
    public class WelcomePage : BasePage
    {
        [FindsBy(How = How.Id, Using = "search")]
        private IWebElement Searchelement { get; set; }
        [FindsBy(How = How.Id, Using = "search_mini_form")]
        private IWebElement ParentSearchElement { get; set; }

        public WelcomePage(IWebDriver driver) : base(driver)
        {
        
        }

        public bool ValidatSuccessfulLogon(string message)
        {
            return Driver.PageSource.ToLower().Contains(message.ToLower());
        }
    }
}
